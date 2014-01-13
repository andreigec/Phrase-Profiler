using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ANDREICSLIB;
using ANDREICSLIB.ClassExtras;
using Phrase_Profiler.ServiceReference1;

namespace Phrase_Profiler
{
    public partial class Form1 : Form
    {
        private static string configPath = "PP.cfg";
        private ListViewSorter excludedSort = new ListViewSorter();
        private ListViewSorter requiredSort = new ListViewSorter();
        #region licensing

        private const string AppTitle = "Phrase Profiler";
        private const double AppVersion = 0.2;
        private const String HelpString = "";

        private readonly String OtherText =
            @"©" + DateTime.Now.Year +
            @" Andrei Gec (http://www.andreigec.net)

Licensed under GNU LGPL (http://www.gnu.org/)

Zip Assets © SharpZipLib (http://www.sharpdevelop.net/OpenSource/SharpZipLib/)
";
        #endregion

        private static string defaultTitle;

        public Form1()
        {
            InitializeComponent();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void LoadFiles(IEnumerable<string> files)
        {
            string text = "";
            foreach (var f in files)
            {
                var fi = new System.IO.FileInfo(f);
                if (text.Length > 0)
                    text += ",";
                text += fi.Name;
            }

            text = StringExtras.Truncate(text, 100);
            Text = defaultTitle + " - " + text;

            var op = new textoptions(ignoreHTML.Checked, ignoreNonAlphabetCharactersToolStripMenuItem.Checked);
            var errorfile = controller.LoadFiles(files.ToList(), op);
            if (errorfile != null)
            {
                MessageBox.Show("Error loading file:" + errorfile);
                return;
            }

            SetControlsEnable(true);
            RefreshCharts();
        }

        private void LoadFiles()
        {
            var ofd = new OpenFileDialog();
            ofd.Title = "Select file/s to load";
            ofd.Filter = "|*.*";
            ofd.Multiselect = true;
            var result = ofd.ShowDialog();
            if (result != DialogResult.OK)
                return;

            LoadFiles(ofd.FileNames);
        }

        public void SetControlsEnable(bool enabled)
        {
             chartOptionsToolStripMenuItem.Enabled= tabControl1.Enabled = panel1.Enabled = splitter1.Enabled = splitter2.Enabled = enabled;
        }

        private void RefreshCharts()
        {
            List<String> ep = (from ListViewItem k in excludedItems.Items select k.Text).ToList();
            List<String> rp = (from ListViewItem k in requiredItems.Items select k.Text).ToList();

            controller.Refresh(ep, rp,wordsChart,phrasesChart, min3WordsInPhrasesToolStripMenuItem.Checked,partialcull.Checked);

            totalwordscountTS.Text = wordsChart.Series[0].Points.Sum(s => s.YValues[0]).ToString(CultureInfo.InvariantCulture);
            totalPhrasesCountTS.Text = phrasesChart.Series[0].Points.Sum(s => s.YValues[0]).ToString(CultureInfo.InvariantCulture);
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            SetControlsEnable(false);
            Licensing.CreateLicense(this, menuStrip1, new Licensing.SolutionDetails(GetDetails, HelpString, AppTitle, AppVersion, OtherText));

            defaultTitle = Text;
            loadConfig();
            if (savebox.Checked==false)
            {
                excludedItems.Items.Clear();
                requiredItems.Items.Clear();
            }
            excludedItems.ListViewItemSorter = excludedSort;
            requiredItems.ListViewItemSorter = requiredSort;
        }

        public Licensing.DownloadedSolutionDetails GetDetails()
        {
            try
            {
                var sr = new ServicesClient();
                var ti = sr.GetTitleInfo(AppTitle);
                if (ti == null)
                    return null;
                return ToDownloadedSolutionDetails(ti);

            }
            catch (Exception)
            {
            }
            return null;
        }

        public static Licensing.DownloadedSolutionDetails ToDownloadedSolutionDetails(TitleInfoServiceModel tism)
        {
            return new Licensing.DownloadedSolutionDetails()
            {
                ZipFileLocation = tism.LatestTitleDownloadPath,
                ChangeLog = tism.LatestTitleChangelog,
                Version = tism.LatestTitleVersion
            };
        }

        public void saveConfig()
        {
            var savethese1 = new List<Control>();
            var savethese2 = new List<ToolStripItem>();
            var savethese3 = new List<Tuple<string, string>>();

            if (dontsave.Checked)
            {
                savethese2.Add(dontsave);
            }
            else
            {
                if (savebox.Checked)
                {
                    savethese1.Add(excludedItems);
                    savethese1.Add(requiredItems);    
                }

                savethese2.Add(loadlast);
                savethese2.Add(savebox);
                savethese2.Add(ignoreHTML);
                savethese2.Add(ignoreNonAlphabetCharactersToolStripMenuItem);
                savethese2.Add(partialcull);
                savethese2.Add(min3WordsInPhrasesToolStripMenuItem);

                if (loadlast.Checked)
                {
                    String loadedfiles = "";
                    if (controller.M != null && controller.M.loadedFiles != null)
                    {
                        foreach (var f in controller.M.loadedFiles)
                        {
                            loadedfiles += f + "|";
                        }
                    }
                    savethese3.Add(new Tuple<string, string>(loadlast.Name, loadedfiles));    
                }
            }

            FormConfigRestore.SaveConfig(this, configPath, savethese1, savethese2,savethese3);
        }

        public void loadConfig()
        {
            var lits=FormConfigRestore.LoadConfig(this, configPath);
            if (lits!=null)
            {
                foreach (var l in lits)
                {
                    if (l.Item1.Equals(loadlast.Name))
                    {
                        var files = l.Item2.Split(new[] { "|" }, StringSplitOptions.RemoveEmptyEntries);
                        LoadFiles(files);
                    }
                }   
            }
        }

        private void AddExcludedPhrase(String text,bool refresh=true)
        {
            if (excludedItems.Items.ContainsKey(text))
                return;
            excludedItems.Items.Add(text).Name = text;
            excludedItems.Sort();

            if (refresh)
            RefreshCharts();
        }

        private void AddRequiredPhrase(String text)
        {
            if (requiredItems.Items.ContainsKey(text))
                return;
            requiredItems.Items.Add(text).Name = text;
            requiredItems.Sort();
            RefreshCharts();
        }

        private void loadFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            LoadFiles();
        }

        private void AddExPhraseButton()
        {
            if (excludedphrasetextbox.Text.Length == 0)
                return;
            AddExcludedPhrase(excludedphrasetextbox.Text);
            excludedphrasetextbox.Text = "";
        }

        private void Addexphrasebutton_Click(object sender, EventArgs e)
        {
            AddExPhraseButton();
        }

        private void min3WordsInPhrasesToolStripMenuItem_Click_1(object sender, EventArgs e)
        {
            RefreshCharts();
        }

        private void excWordRC_Opening(object sender, CancelEventArgs e)
        {
            removeBRC.Enabled = false;

            var lv = (ListView)ContextMenuStripExtras.GetContextParent(sender, typeof(ListView));
            if (lv == null)
                return;
                removeBRC.Enabled = lv.SelectedItems.Count != 0;
        }

        private void removeBRC_Click(object sender, EventArgs e)
        {
            var lb = ContextMenuStripExtras.GetContextParent(sender, typeof(ListView)) as ListView;
            if (lb == null)
                return;

            foreach (ListViewItem s in lb.SelectedItems)
            {
                lb.Items.RemoveByKey(s.Text);
            }
            RefreshCharts();
        }

        private void AddReqPhraseButton()
        {
             if (requiredphraseTB.Text.Length == 0)
                return;

            AddRequiredPhrase(requiredphraseTB.Text);
            requiredphraseTB.Text = "";
        
        }

        private void addReqPhraseB_Click_1(object sender, EventArgs e)
        {
            AddReqPhraseButton();
        }


        private void ChartMouseClick(object sender, MouseEventArgs e)
        {
            if (e.Button != MouseButtons.Right)
            {
                return;
            }

            var p = ChartMethods.GetPointAtMouse(sender as Chart, e);
            if (p == null)
                return;

            var label = p.AxisLabel;
            if (String.IsNullOrEmpty(label))
                return;

            var ll = ((Chart)sender).PointToScreen(new Point(e.X, e.Y));
            removeChartItemRC.Tag = sender as Chart;
            removeChartItemRC.Name = label;
            //remove everything up to the first : if it exists
            if (addRemChartRCB.Text.Contains(":"))
            {
                addRemChartRCB.Text = addRemChartRCB.Text.Substring(0, addRemChartRCB.Text.IndexOf(":", System.StringComparison.Ordinal));
                addReqChartRCB.Text = addReqChartRCB.Text.Substring(0, addReqChartRCB.Text.IndexOf(":", System.StringComparison.Ordinal));
            }
            addRemChartRCB.Text += ":" + label;
            addReqChartRCB.Text += ":" + label;
            removeChartItemRC.Show(ll);
        }

        private void removeToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var chart = removeChartItemRC.Tag as Chart;
            var label = removeChartItemRC.Name;

            if (chart == null || string.IsNullOrWhiteSpace(label))
                return;

            if (chart == wordsChart)
            {
                AddExcludedPhrase(label);
            }
            else if (chart == phrasesChart)
            {
                AddExcludedPhrase(label);
            }
        }

        private void requireToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var chart = removeChartItemRC.Tag as Chart;
            var label = removeChartItemRC.Name;

            if (chart == null || string.IsNullOrWhiteSpace(label))
                return;

            if (chart == wordsChart)
            {
                AddRequiredPhrase(label);
            }
            else if (chart == phrasesChart)
            {
                AddRequiredPhrase(label);
            }
        }

        private void wordsChart_MouseMove(object sender, MouseEventArgs e)
        {
            ChartMethods.HashMouseOver(wordsChart, e, this);
        }

        private void phrasesChart_MouseMove(object sender, MouseEventArgs e)
        {
            ChartMethods.HashMouseOver(phrasesChart, e, this);
        }

        private void resetZoomToolStripMenuItem_Click(object sender, EventArgs e)
        {
            phrasesChart.ChartAreas[0].AxisX2.ScaleView.Zoom(0,ChartMethods.zoomMax);
            wordsChart.ChartAreas[0].AxisX2.ScaleView.Zoom(0, ChartMethods.zoomMax);
        }

        private void excludeTop20WordsToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var s = wordsChart.Series[0];
            int c = s.Points.Count - 1;
            int c2 = c > 20 ? c - 20 : 0;
            for (int a=c;a>c2;a--)
            {
                var dp = s.Points[a];
                if (dp==null)
                    return;
                AddExcludedPhrase(dp.AxisLabel,false);
            }
            RefreshCharts();
        }

        private void clearExcWordsB_Click(object sender, EventArgs e)
        {
            excludedItems.Items.Clear();
            RefreshCharts();
        }

        private void clearReqWordsB_Click(object sender, EventArgs e)
        {
            requiredItems.Items.Clear();
            RefreshCharts();
        }

        private void exportChartsToFileToolStripMenuItem_Click(object sender, EventArgs e)
        {
            string ext = DateTime.Now.ToShortTimeString() + ".csv";
            ChartMethods.SaveChartCSV(wordsChart, "wordsChart" + ext);
            ChartMethods.SaveChartCSV(phrasesChart, "phrasesChart" + ext);
        }

        private void partialcull_Click(object sender, EventArgs e)
        {
            RefreshCharts();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            saveConfig();
        }

        private void excludedphrasetextbox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                AddExPhraseButton();
        }

        private void requiredphraseTB_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == 13)
                AddReqPhraseButton();
        }

    }
}
