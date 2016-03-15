namespace Phrase_Profiler
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
            System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
            System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.loadFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreHTML = new System.Windows.Forms.ToolStripMenuItem();
            this.ignoreNonAlphabetCharactersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.chartOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.partialcull = new System.Windows.Forms.ToolStripMenuItem();
            this.min3WordsInPhrasesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.excludeTop20WordsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.resetZoomToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.exportChartsToFileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.programOptionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.savebox = new System.Windows.Forms.ToolStripMenuItem();
            this.loadlast = new System.Windows.Forms.ToolStripMenuItem();
            this.dontsave = new System.Windows.Forms.ToolStripMenuItem();
            this.phrasesPage = new System.Windows.Forms.TabPage();
            this.phrasesChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.panel4 = new System.Windows.Forms.Panel();
            this.clearReqWordsB = new System.Windows.Forms.Button();
            this.addReqPhraseB = new System.Windows.Forms.Button();
            this.requiredphraseTB = new System.Windows.Forms.TextBox();
            this.requiredItems = new System.Windows.Forms.ListView();
            this.removeItemRC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.removeBRC = new System.Windows.Forms.ToolStripMenuItem();
            this.label3 = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.clearExcWordsB = new System.Windows.Forms.Button();
            this.excludedphrasetextbox = new System.Windows.Forms.TextBox();
            this.Addexphrasebutton = new System.Windows.Forms.Button();
            this.excludedItems = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.wordsPage = new System.Windows.Forms.TabPage();
            this.wordsChart = new System.Windows.Forms.DataVisualization.Charting.Chart();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.wordscontext = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.excludeItemsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.removeChartItemRC = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.addRemChartRCB = new System.Windows.Forms.ToolStripMenuItem();
            this.addReqChartRCB = new System.Windows.Forms.ToolStripMenuItem();
            this.panel1 = new System.Windows.Forms.Panel();
            this.splitter1 = new System.Windows.Forms.Splitter();
            this.splitter2 = new System.Windows.Forms.Splitter();
            this.statusStrip1 = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel1 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalwordscountTS = new System.Windows.Forms.ToolStripStatusLabel();
            this.toolStripStatusLabel2 = new System.Windows.Forms.ToolStripStatusLabel();
            this.totalPhrasesCountTS = new System.Windows.Forms.ToolStripStatusLabel();
            this.menuStrip1.SuspendLayout();
            this.phrasesPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phrasesChart)).BeginInit();
            this.panel4.SuspendLayout();
            this.removeItemRC.SuspendLayout();
            this.panel3.SuspendLayout();
            this.wordsPage.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.wordsChart)).BeginInit();
            this.tabControl1.SuspendLayout();
            this.wordscontext.SuspendLayout();
            this.removeChartItemRC.SuspendLayout();
            this.panel1.SuspendLayout();
            this.statusStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.Color.Silver;
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.chartOptionsToolStripMenuItem,
            this.programOptionsToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(1195, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.loadFileToolStripMenuItem,
            this.exitToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // loadFileToolStripMenuItem
            // 
            this.loadFileToolStripMenuItem.Name = "loadFileToolStripMenuItem";
            this.loadFileToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.loadFileToolStripMenuItem.Text = "Load File/s";
            this.loadFileToolStripMenuItem.Click += new System.EventHandler(this.loadFileToolStripMenuItem_Click);
            // 
            // exitToolStripMenuItem
            // 
            this.exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            this.exitToolStripMenuItem.Size = new System.Drawing.Size(131, 22);
            this.exitToolStripMenuItem.Text = "Exit";
            this.exitToolStripMenuItem.Click += new System.EventHandler(this.exitToolStripMenuItem_Click);
            // 
            // optionsToolStripMenuItem
            // 
            this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ignoreHTML,
            this.ignoreNonAlphabetCharactersToolStripMenuItem});
            this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
            this.optionsToolStripMenuItem.Size = new System.Drawing.Size(128, 20);
            this.optionsToolStripMenuItem.Text = "File Loading Options";
            // 
            // ignoreHTML
            // 
            this.ignoreHTML.Checked = true;
            this.ignoreHTML.CheckOnClick = true;
            this.ignoreHTML.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreHTML.Name = "ignoreHTML";
            this.ignoreHTML.Size = new System.Drawing.Size(265, 22);
            this.ignoreHTML.Text = "Ignore bracketed words, such as <i>";
            // 
            // ignoreNonAlphabetCharactersToolStripMenuItem
            // 
            this.ignoreNonAlphabetCharactersToolStripMenuItem.Checked = true;
            this.ignoreNonAlphabetCharactersToolStripMenuItem.CheckOnClick = true;
            this.ignoreNonAlphabetCharactersToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
            this.ignoreNonAlphabetCharactersToolStripMenuItem.Name = "ignoreNonAlphabetCharactersToolStripMenuItem";
            this.ignoreNonAlphabetCharactersToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
            this.ignoreNonAlphabetCharactersToolStripMenuItem.Text = "Ignore non alphabet characters";
            // 
            // chartOptionsToolStripMenuItem
            // 
            this.chartOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.partialcull,
            this.min3WordsInPhrasesToolStripMenuItem,
            this.toolStripSeparator1,
            this.excludeTop20WordsToolStripMenuItem,
            this.resetZoomToolStripMenuItem,
            this.exportChartsToFileToolStripMenuItem});
            this.chartOptionsToolStripMenuItem.Name = "chartOptionsToolStripMenuItem";
            this.chartOptionsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
            this.chartOptionsToolStripMenuItem.Text = "Chart Options";
            // 
            // partialcull
            // 
            this.partialcull.Checked = true;
            this.partialcull.CheckOnClick = true;
            this.partialcull.CheckState = System.Windows.Forms.CheckState.Checked;
            this.partialcull.Name = "partialcull";
            this.partialcull.Size = new System.Drawing.Size(320, 22);
            this.partialcull.Text = "Remove partial sentences with only one parent";
            this.partialcull.Click += new System.EventHandler(this.partialcull_Click);
            // 
            // min3WordsInPhrasesToolStripMenuItem
            // 
            this.min3WordsInPhrasesToolStripMenuItem.CheckOnClick = true;
            this.min3WordsInPhrasesToolStripMenuItem.Name = "min3WordsInPhrasesToolStripMenuItem";
            this.min3WordsInPhrasesToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.min3WordsInPhrasesToolStripMenuItem.Text = "Min 3 words in phrases";
            this.min3WordsInPhrasesToolStripMenuItem.Click += new System.EventHandler(this.min3WordsInPhrasesToolStripMenuItem_Click_1);
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(317, 6);
            // 
            // excludeTop20WordsToolStripMenuItem
            // 
            this.excludeTop20WordsToolStripMenuItem.Name = "excludeTop20WordsToolStripMenuItem";
            this.excludeTop20WordsToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.excludeTop20WordsToolStripMenuItem.Text = "Exclude top 20 words";
            this.excludeTop20WordsToolStripMenuItem.Click += new System.EventHandler(this.excludeTop20WordsToolStripMenuItem_Click);
            // 
            // resetZoomToolStripMenuItem
            // 
            this.resetZoomToolStripMenuItem.Name = "resetZoomToolStripMenuItem";
            this.resetZoomToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.resetZoomToolStripMenuItem.Text = "Reset Zoom";
            this.resetZoomToolStripMenuItem.Click += new System.EventHandler(this.resetZoomToolStripMenuItem_Click);
            // 
            // exportChartsToFileToolStripMenuItem
            // 
            this.exportChartsToFileToolStripMenuItem.Name = "exportChartsToFileToolStripMenuItem";
            this.exportChartsToFileToolStripMenuItem.Size = new System.Drawing.Size(320, 22);
            this.exportChartsToFileToolStripMenuItem.Text = "Export charts to file";
            this.exportChartsToFileToolStripMenuItem.Click += new System.EventHandler(this.exportChartsToFileToolStripMenuItem_Click);
            // 
            // programOptionsToolStripMenuItem
            // 
            this.programOptionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.savebox,
            this.loadlast,
            this.dontsave});
            this.programOptionsToolStripMenuItem.Name = "programOptionsToolStripMenuItem";
            this.programOptionsToolStripMenuItem.Size = new System.Drawing.Size(110, 20);
            this.programOptionsToolStripMenuItem.Text = "Program Options";
            // 
            // savebox
            // 
            this.savebox.Checked = true;
            this.savebox.CheckOnClick = true;
            this.savebox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.savebox.Name = "savebox";
            this.savebox.Size = new System.Drawing.Size(287, 22);
            this.savebox.Text = "Remember required and excluded words";
            // 
            // loadlast
            // 
            this.loadlast.CheckOnClick = true;
            this.loadlast.Name = "loadlast";
            this.loadlast.Size = new System.Drawing.Size(287, 22);
            this.loadlast.Text = "Remember last loaded files";
            // 
            // dontsave
            // 
            this.dontsave.CheckOnClick = true;
            this.dontsave.Name = "dontsave";
            this.dontsave.Size = new System.Drawing.Size(287, 22);
            this.dontsave.Text = "Don\'t remember menu options";
            // 
            // phrasesPage
            // 
            this.phrasesPage.Controls.Add(this.phrasesChart);
            this.phrasesPage.Location = new System.Drawing.Point(4, 22);
            this.phrasesPage.Name = "phrasesPage";
            this.phrasesPage.Padding = new System.Windows.Forms.Padding(3);
            this.phrasesPage.Size = new System.Drawing.Size(982, 524);
            this.phrasesPage.TabIndex = 1;
            this.phrasesPage.Text = "Phrases";
            this.phrasesPage.UseVisualStyleBackColor = true;
            // 
            // phrasesChart
            // 
            chartArea1.Name = "ChartArea1";
            this.phrasesChart.ChartAreas.Add(chartArea1);
            this.phrasesChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend1.Name = "Legend1";
            this.phrasesChart.Legends.Add(legend1);
            this.phrasesChart.Location = new System.Drawing.Point(3, 3);
            this.phrasesChart.Name = "phrasesChart";
            series1.ChartArea = "ChartArea1";
            series1.Legend = "Legend1";
            series1.Name = "Series1";
            this.phrasesChart.Series.Add(series1);
            this.phrasesChart.Size = new System.Drawing.Size(976, 518);
            this.phrasesChart.TabIndex = 2;
            this.phrasesChart.Text = "chart1";
            this.phrasesChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChartMouseClick);
            this.phrasesChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.phrasesChart_MouseMove);
            // 
            // panel4
            // 
            this.panel4.Controls.Add(this.clearReqWordsB);
            this.panel4.Controls.Add(this.addReqPhraseB);
            this.panel4.Controls.Add(this.requiredphraseTB);
            this.panel4.Controls.Add(this.requiredItems);
            this.panel4.Controls.Add(this.label3);
            this.panel4.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel4.Location = new System.Drawing.Point(0, 385);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(200, 165);
            this.panel4.TabIndex = 16;
            // 
            // clearReqWordsB
            // 
            this.clearReqWordsB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearReqWordsB.Location = new System.Drawing.Point(94, 6);
            this.clearReqWordsB.Name = "clearReqWordsB";
            this.clearReqWordsB.Size = new System.Drawing.Size(101, 20);
            this.clearReqWordsB.TabIndex = 18;
            this.clearReqWordsB.Text = "Clear";
            this.clearReqWordsB.UseVisualStyleBackColor = true;
            this.clearReqWordsB.Click += new System.EventHandler(this.clearReqWordsB_Click);
            // 
            // addReqPhraseB
            // 
            this.addReqPhraseB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.addReqPhraseB.Location = new System.Drawing.Point(6, 130);
            this.addReqPhraseB.Name = "addReqPhraseB";
            this.addReqPhraseB.Size = new System.Drawing.Size(188, 23);
            this.addReqPhraseB.TabIndex = 17;
            this.addReqPhraseB.Text = "Add";
            this.addReqPhraseB.UseVisualStyleBackColor = true;
            this.addReqPhraseB.Click += new System.EventHandler(this.addReqPhraseB_Click_1);
            // 
            // requiredphraseTB
            // 
            this.requiredphraseTB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requiredphraseTB.Location = new System.Drawing.Point(6, 104);
            this.requiredphraseTB.Name = "requiredphraseTB";
            this.requiredphraseTB.Size = new System.Drawing.Size(188, 20);
            this.requiredphraseTB.TabIndex = 16;
            this.requiredphraseTB.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.requiredphraseTB_KeyPress);
            // 
            // requiredItems
            // 
            this.requiredItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.requiredItems.ContextMenuStrip = this.removeItemRC;
            this.requiredItems.FullRowSelect = true;
            this.requiredItems.Location = new System.Drawing.Point(6, 26);
            this.requiredItems.Name = "requiredItems";
            this.requiredItems.Size = new System.Drawing.Size(188, 72);
            this.requiredItems.TabIndex = 15;
            this.requiredItems.UseCompatibleStateImageBehavior = false;
            this.requiredItems.View = System.Windows.Forms.View.List;
            // 
            // removeItemRC
            // 
            this.removeItemRC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.removeBRC});
            this.removeItemRC.Name = "excWordRC";
            this.removeItemRC.Size = new System.Drawing.Size(118, 26);
            this.removeItemRC.Opening += new System.ComponentModel.CancelEventHandler(this.excWordRC_Opening);
            // 
            // removeBRC
            // 
            this.removeBRC.Name = "removeBRC";
            this.removeBRC.Size = new System.Drawing.Size(117, 22);
            this.removeBRC.Text = "Remove";
            this.removeBRC.Click += new System.EventHandler(this.removeBRC_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(3, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(84, 13);
            this.label3.TabIndex = 14;
            this.label3.Text = "Required Words";
            // 
            // panel3
            // 
            this.panel3.Controls.Add(this.clearExcWordsB);
            this.panel3.Controls.Add(this.excludedphrasetextbox);
            this.panel3.Controls.Add(this.Addexphrasebutton);
            this.panel3.Controls.Add(this.excludedItems);
            this.panel3.Controls.Add(this.label2);
            this.panel3.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel3.Location = new System.Drawing.Point(0, 0);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(200, 380);
            this.panel3.TabIndex = 14;
            // 
            // clearExcWordsB
            // 
            this.clearExcWordsB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.clearExcWordsB.Location = new System.Drawing.Point(94, 4);
            this.clearExcWordsB.Name = "clearExcWordsB";
            this.clearExcWordsB.Size = new System.Drawing.Size(101, 20);
            this.clearExcWordsB.TabIndex = 9;
            this.clearExcWordsB.Text = "Clear";
            this.clearExcWordsB.UseVisualStyleBackColor = true;
            this.clearExcWordsB.Click += new System.EventHandler(this.clearExcWordsB_Click);
            // 
            // excludedphrasetextbox
            // 
            this.excludedphrasetextbox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.excludedphrasetextbox.Location = new System.Drawing.Point(6, 325);
            this.excludedphrasetextbox.Name = "excludedphrasetextbox";
            this.excludedphrasetextbox.Size = new System.Drawing.Size(188, 20);
            this.excludedphrasetextbox.TabIndex = 7;
            this.excludedphrasetextbox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.excludedphrasetextbox_KeyPress);
            // 
            // Addexphrasebutton
            // 
            this.Addexphrasebutton.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Addexphrasebutton.Location = new System.Drawing.Point(6, 351);
            this.Addexphrasebutton.Name = "Addexphrasebutton";
            this.Addexphrasebutton.Size = new System.Drawing.Size(188, 23);
            this.Addexphrasebutton.TabIndex = 8;
            this.Addexphrasebutton.Text = "Add";
            this.Addexphrasebutton.UseVisualStyleBackColor = true;
            this.Addexphrasebutton.Click += new System.EventHandler(this.Addexphrasebutton_Click);
            // 
            // excludedItems
            // 
            this.excludedItems.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.excludedItems.ContextMenuStrip = this.removeItemRC;
            this.excludedItems.FullRowSelect = true;
            this.excludedItems.Location = new System.Drawing.Point(6, 30);
            this.excludedItems.Name = "excludedItems";
            this.excludedItems.Size = new System.Drawing.Size(188, 289);
            this.excludedItems.TabIndex = 6;
            this.excludedItems.UseCompatibleStateImageBehavior = false;
            this.excludedItems.View = System.Windows.Forms.View.List;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(3, 8);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(85, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Excluded Words";
            // 
            // wordsPage
            // 
            this.wordsPage.Controls.Add(this.wordsChart);
            this.wordsPage.Location = new System.Drawing.Point(4, 22);
            this.wordsPage.Name = "wordsPage";
            this.wordsPage.Padding = new System.Windows.Forms.Padding(3);
            this.wordsPage.Size = new System.Drawing.Size(982, 524);
            this.wordsPage.TabIndex = 0;
            this.wordsPage.Text = "Words";
            this.wordsPage.UseVisualStyleBackColor = true;
            // 
            // wordsChart
            // 
            chartArea2.Name = "ChartArea1";
            this.wordsChart.ChartAreas.Add(chartArea2);
            this.wordsChart.Cursor = System.Windows.Forms.Cursors.Default;
            this.wordsChart.Dock = System.Windows.Forms.DockStyle.Fill;
            legend2.Name = "Legend1";
            this.wordsChart.Legends.Add(legend2);
            this.wordsChart.Location = new System.Drawing.Point(3, 3);
            this.wordsChart.Name = "wordsChart";
            series2.ChartArea = "ChartArea1";
            series2.Legend = "Legend1";
            series2.Name = "Series1";
            this.wordsChart.Series.Add(series2);
            this.wordsChart.Size = new System.Drawing.Size(976, 518);
            this.wordsChart.TabIndex = 0;
            this.wordsChart.Text = "wordsChart";
            this.wordsChart.MouseClick += new System.Windows.Forms.MouseEventHandler(this.ChartMouseClick);
            this.wordsChart.MouseMove += new System.Windows.Forms.MouseEventHandler(this.wordsChart_MouseMove);
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.wordsPage);
            this.tabControl1.Controls.Add(this.phrasesPage);
            this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tabControl1.Enabled = false;
            this.tabControl1.Location = new System.Drawing.Point(205, 24);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(990, 550);
            this.tabControl1.TabIndex = 4;
            // 
            // wordscontext
            // 
            this.wordscontext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.excludeItemsToolStripMenuItem});
            this.wordscontext.Name = "wordscontext";
            this.wordscontext.Size = new System.Drawing.Size(142, 26);
            // 
            // excludeItemsToolStripMenuItem
            // 
            this.excludeItemsToolStripMenuItem.Name = "excludeItemsToolStripMenuItem";
            this.excludeItemsToolStripMenuItem.Size = new System.Drawing.Size(141, 22);
            this.excludeItemsToolStripMenuItem.Text = "Exclude Item";
            // 
            // removeChartItemRC
            // 
            this.removeChartItemRC.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addRemChartRCB,
            this.addReqChartRCB});
            this.removeChartItemRC.Name = "removeChartItemRC";
            this.removeChartItemRC.Size = new System.Drawing.Size(182, 48);
            // 
            // addRemChartRCB
            // 
            this.addRemChartRCB.Name = "addRemChartRCB";
            this.addRemChartRCB.Size = new System.Drawing.Size(181, 22);
            this.addRemChartRCB.Text = "Add to Excluded List";
            this.addRemChartRCB.Click += new System.EventHandler(this.removeToolStripMenuItem_Click);
            // 
            // addReqChartRCB
            // 
            this.addReqChartRCB.Name = "addReqChartRCB";
            this.addReqChartRCB.Size = new System.Drawing.Size(181, 22);
            this.addReqChartRCB.Text = "Add to Required List";
            this.addReqChartRCB.Click += new System.EventHandler(this.requireToolStripMenuItem_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.panel4);
            this.panel1.Controls.Add(this.splitter1);
            this.panel1.Controls.Add(this.panel3);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Left;
            this.panel1.Location = new System.Drawing.Point(0, 24);
            this.panel1.MinimumSize = new System.Drawing.Size(128, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(200, 550);
            this.panel1.TabIndex = 17;
            // 
            // splitter1
            // 
            this.splitter1.BackColor = System.Drawing.Color.Silver;
            this.splitter1.Dock = System.Windows.Forms.DockStyle.Top;
            this.splitter1.Location = new System.Drawing.Point(0, 380);
            this.splitter1.Name = "splitter1";
            this.splitter1.Size = new System.Drawing.Size(200, 5);
            this.splitter1.TabIndex = 17;
            this.splitter1.TabStop = false;
            // 
            // splitter2
            // 
            this.splitter2.BackColor = System.Drawing.Color.Silver;
            this.splitter2.Location = new System.Drawing.Point(200, 24);
            this.splitter2.Name = "splitter2";
            this.splitter2.Size = new System.Drawing.Size(5, 550);
            this.splitter2.TabIndex = 18;
            this.splitter2.TabStop = false;
            // 
            // statusStrip1
            // 
            this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel1,
            this.totalwordscountTS,
            this.toolStripStatusLabel2,
            this.totalPhrasesCountTS});
            this.statusStrip1.Location = new System.Drawing.Point(0, 574);
            this.statusStrip1.Name = "statusStrip1";
            this.statusStrip1.Size = new System.Drawing.Size(1195, 22);
            this.statusStrip1.TabIndex = 19;
            this.statusStrip1.Text = "statusStrip1";
            // 
            // toolStripStatusLabel1
            // 
            this.toolStripStatusLabel1.Name = "toolStripStatusLabel1";
            this.toolStripStatusLabel1.Size = new System.Drawing.Size(106, 17);
            this.toolStripStatusLabel1.Text = "Total words count:";
            // 
            // totalwordscountTS
            // 
            this.totalwordscountTS.Name = "totalwordscountTS";
            this.totalwordscountTS.Size = new System.Drawing.Size(16, 17);
            this.totalwordscountTS.Text = "...";
            // 
            // toolStripStatusLabel2
            // 
            this.toolStripStatusLabel2.Name = "toolStripStatusLabel2";
            this.toolStripStatusLabel2.Size = new System.Drawing.Size(114, 17);
            this.toolStripStatusLabel2.Text = "Total phrases count:";
            // 
            // totalPhrasesCountTS
            // 
            this.totalPhrasesCountTS.Name = "totalPhrasesCountTS";
            this.totalPhrasesCountTS.Size = new System.Drawing.Size(16, 17);
            this.totalPhrasesCountTS.Text = "...";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1195, 596);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.splitter2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.menuStrip1);
            this.Controls.Add(this.statusStrip1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.Form1_FormClosing);
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.phrasesPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.phrasesChart)).EndInit();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.removeItemRC.ResumeLayout(false);
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.wordsPage.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.wordsChart)).EndInit();
            this.tabControl1.ResumeLayout(false);
            this.wordscontext.ResumeLayout(false);
            this.removeChartItemRC.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.statusStrip1.ResumeLayout(false);
            this.statusStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem exitToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem optionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem ignoreHTML;
        private System.Windows.Forms.ToolStripMenuItem ignoreNonAlphabetCharactersToolStripMenuItem;
        private System.Windows.Forms.TabPage phrasesPage;
        private System.Windows.Forms.TabPage wordsPage;
        private System.Windows.Forms.DataVisualization.Charting.Chart wordsChart;
        public System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.ToolStripMenuItem loadFileToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip wordscontext;
        private System.Windows.Forms.ToolStripMenuItem excludeItemsToolStripMenuItem;
        private System.Windows.Forms.Button Addexphrasebutton;
        private System.Windows.Forms.TextBox excludedphrasetextbox;
        private System.Windows.Forms.ListView excludedItems;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ToolStripMenuItem chartOptionsToolStripMenuItem;
        public System.Windows.Forms.ToolStripMenuItem min3WordsInPhrasesToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip removeItemRC;
        private System.Windows.Forms.ToolStripMenuItem removeBRC;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Panel panel4;
        private System.Windows.Forms.Button addReqPhraseB;
        private System.Windows.Forms.TextBox requiredphraseTB;
        private System.Windows.Forms.ListView requiredItems;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ContextMenuStrip removeChartItemRC;
        private System.Windows.Forms.ToolStripMenuItem addRemChartRCB;
        private System.Windows.Forms.ToolStripMenuItem addReqChartRCB;
        private System.Windows.Forms.DataVisualization.Charting.Chart phrasesChart;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Splitter splitter1;
        private System.Windows.Forms.Splitter splitter2;
        private System.Windows.Forms.ToolStripMenuItem resetZoomToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem excludeTop20WordsToolStripMenuItem;
        private System.Windows.Forms.Button clearReqWordsB;
        private System.Windows.Forms.Button clearExcWordsB;
        private System.Windows.Forms.ToolStripMenuItem exportChartsToFileToolStripMenuItem;
        private System.Windows.Forms.StatusStrip statusStrip1;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel1;
        private System.Windows.Forms.ToolStripStatusLabel totalwordscountTS;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel2;
        private System.Windows.Forms.ToolStripStatusLabel totalPhrasesCountTS;
        private System.Windows.Forms.ToolStripMenuItem partialcull;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripMenuItem programOptionsToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem dontsave;
        private System.Windows.Forms.ToolStripMenuItem savebox;
        private System.Windows.Forms.ToolStripMenuItem loadlast;
    }
}

