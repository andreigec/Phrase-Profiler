using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Windows.Forms.DataVisualization.Charting;
using ANDREICSLIB;
using ANDREICSLIB.ClassExtras;

namespace Phrase_Profiler
{
    public static class ChartMethods
    {
        public static int zoomMax = 20;
        public static int itemMax = 100;
        public static void HashMouseOver(Chart c, MouseEventArgs e, Form f)
        {
            var point = GetPointAtMouse(c, e);
            //default cursor
            f.Cursor = Cursors.Default;

            //turn all points off hashing
            if (c.Series.Count == 0)
                return;

            foreach (var p in c.Series[0].Points)
            {
                hatchChart(p, false, f);
            }

            // If the mouse if over a data point
            // Change the appearance of the data point
            if (point != null)
                hatchChart(point, true);
        }

        private static void hatchChart(DataPoint point, bool hatch, Form f = null)
        {
            if (hatch)
            {
                point.BackSecondaryColor = Color.White;
                point.BackHatchStyle = ChartHatchStyle.Percent25;
                point.BorderWidth = 2;
                if (f != null)
                    f.Cursor = Cursors.Hand;
            }
            else
            {
                point.BackSecondaryColor = Color.Transparent;
                point.BackHatchStyle = ChartHatchStyle.None;
            }
        }


        public static DataPoint GetPointAtMouse(Chart c, MouseEventArgs e)
        {
            var result = c.HitTest(e.X, e.Y);
            // If the mouse if over a data point
            if (result.ChartElementType == ChartElementType.DataPoint)
            {
                // Find selected data point
                var point = c.Series[0].Points[result.PointIndex];
                return point;
            }
            return null;
        }

        public static void SetChart(Dictionary<string, int> rawValues, Chart chart)
        {
            int fmin = 0;
            int fmax = 1;

            if (rawValues.Count > 0)
            {
                fmax = rawValues.Max(x => x.Value);
                fmin = rawValues.Min(x => x.Value);
            }

            //series init
            chart.Series.Clear();
            //   chart.Tag = values;
            var s = new Series();
            s.ChartType = SeriesChartType.Bar;

            foreach (var kvp in rawValues)
            {
                s.Points.AddXY(kvp.Key, kvp.Value);
                var dpc = s.Points[s.Points.Count - 1];
                dpc.Color = ColorExtras.GetRedGreenBlendedColour(kvp.Value, 0, fmax);
                dpc.ToolTip = kvp.Key + ":" + kvp.Value;
            }

            s.YAxisType = AxisType.Primary;
            s.XAxisType = AxisType.Secondary;
            s.IsVisibleInLegend = false;
            chart.Series.Add(s);
            //chartarea init
            chart.ChartAreas.Clear();
            var ca = new ChartArea();

          //  ca.CursorX.IsUserEnabled = true;
           // ca.CursorX.IsUserSelectionEnabled = true;
            
            ca.AxisX2.ScrollBar.IsPositionedInside = false;
            ca.AxisX2.ScaleView.Size = zoomMax;
            ca.AxisX2.ScaleView.Position=rawValues.Count-ca.AxisX2.ScaleView.Size;
            
            ca.AxisX2.Interval = 1;
            ca.AxisY.Interval = MathExtras.Ceiling((Math.Abs(fmax) - Math.Abs(fmin)) / 8);
            if (ca.AxisY.Interval<1)
                ca.AxisY.Interval = 1;

            ca.AxisY.Minimum = fmin;
            ca.AxisY.Maximum = fmax;
            if (Math.Abs(ca.AxisY.Minimum - ca.AxisY.Maximum) < 1)
                ca.AxisY.Minimum--;

            s.Sort(PointSortOrder.Ascending);
            chart.ChartAreas.Add(ca);
        }

        public static void SaveChartCSV(Chart c, string filename)
        {
            String save = "text,count\r\n";
            foreach(var dp in c.Series[0].Points.Reverse())
            {
                save += dp.AxisLabel + "," + dp.YValues[0]+"\r\n";
            }
            FileExtras.SaveToFile(StringExtras.ReplaceAllChars(filename,":","_"), save);
        }


    }
}
