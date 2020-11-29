using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IISLogParser {
  public partial class frmExecOverTime : Form {
    public frmExecOverTime() {
      InitializeComponent();
    }

    protected override void OnLoad(EventArgs e) {
      base.OnLoad(e);

      if (!String.IsNullOrEmpty(URL)) {
        txtUri.Text = URL;
      }
    }

    public List<string> Logfilenames { get; set; }
    public string URL { get; set; }

    private void btnExecute_Click(object sender, EventArgs e) {
      try {
        string s = "SELECT "
          + " date as DateGMT, "
          + " QUANTIZE(time,300) AS TimeGMT, "
          + " AVG(time-taken) as AvgExecTime "
          + " FROM '<%FILENAME%>' "
          + " WHERE cs-uri-stem like '{0}' "
          + " GROUP BY DateGMT, TimeGMT";

        string s2 = "SELECT "
          + " date as DateGMT, "
          + " time AS TimeGMT, "
          + " time-taken as AvgExecTime "
          + " FROM '<%FILENAME%>' "
          + " WHERE cs-uri-stem like '{0}' ";

        if (!String.IsNullOrEmpty(URL)) {
          txtUri.Text = URL;
        }

        string hits = " SELECT "
          + " date as DateGMT, "
          + " QUANTIZE(time, 300) AS TimeGMT, "
          + " COUNT(*) AS Hits "
          + " FROM "
          + "  '<%FILENAME%>' "
          + " WHERE cs-uri-stem like '{0}' "
          + " GROUP BY "
          + " date, TimeGMT "
          + " ORDER BY "
          + " DateGMT, TimeGMT ASC";

        string hits_error = " SELECT "
          + " date as DateGMT, "
          + " QUANTIZE(time, 300) AS TimeGMT, "
          + " COUNT(*) AS Hits "
          + " FROM "
          + "  '<%FILENAME%>' "
          + " WHERE (cs-uri-stem like '{0}') AND NOT(sc-status = 200)"
          + " GROUP BY "
          + " date, TimeGMT "
          + " ORDER BY "
          + " DateGMT, TimeGMT ASC";

        hits = String.Format(hits, txtUri.Text);

        string exec = string.Format(s, txtUri.Text);
        string exec2 = string.Format(s2, txtUri.Text);
        string hits_err = String.Format(hits_error, txtUri.Text);

        LogParser.LogParser p = new IISLogParser.LogParser.LogParser(Logfilenames);

        List<string> script = new List<string>();
        script.Add(exec);
        script.Add(hits);
        script.Add(exec2);
        script.Add(hits_err);

        Dictionary<string, string> result = p.Run(script);

        if (result["customScript_0"] != null) {
          string[] lines = result["customScript_0"].Split(new char[] { '\n' });

          System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series();
          ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Point;

          for (int i = 0; i < lines.Count(); ++i) {
            if (i == 0) continue;

            if (String.IsNullOrEmpty(lines[i])) break;
            if (lines[i] == "\r") break;

            string[] col = lines[i].Split(new char[] { '\t' });

            if (col == null || col.Length != 3) break;
            DateTime dt = DateTime.Parse(col[0] + " " + col[1]);

            ser.Points.AddXY(dt.ToOADate(), Convert.ToDouble(col[2]));
          }

          ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
          ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;

          m_chartExec.ChartAreas.Clear();
          m_chartExec.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("Avg exec time every 5mins (ms)"));
          m_chartExec.Series.Clear();
          m_chartExec.Series.Add(ser);
          m_chartExec.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
          m_chartExec.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
          m_chartExec.ChartAreas[0].AxisX.Interval = 1;
          m_chartExec.Legends.Clear();
        }
        if (result["customScript_1"] != null) {
          string[] lines = result["customScript_1"].Split(new char[] { '\n' });

          System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("Hits avg by 5mins");
          ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

          for (int i = 0; i < lines.Count(); ++i) {
            if (i == 0) continue;

            if (String.IsNullOrEmpty(lines[i])) break;
            if (lines[i] == "\r") break;

            string[] col = lines[i].Split(new char[] { '\t' });
            if (col == null || col.Length != 3) break;
            DateTime dt = DateTime.Parse(col[0] + " " + col[1]);

            ser.Points.AddXY(dt.ToOADate(), Convert.ToDouble(col[2]));
          }

          ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
          ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;

          m_chartHits.ChartAreas.Clear();
          m_chartHits.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea());
          m_chartHits.Series.Clear();
          m_chartHits.Series.Add(ser);
          m_chartHits.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
          m_chartHits.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
          m_chartHits.ChartAreas[0].AxisX.Interval = 1;
          m_chartHits.Legends.Clear();
        }
        if (result["customScript_2"] != null) {
          string[] lines = result["customScript_2"].Split(new char[] { '\n' });

          System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("Exec time (ms)");
          ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

          for (int i = 0; i < lines.Count(); ++i) {
            if (i == 0) continue;

            if (String.IsNullOrEmpty(lines[i])) break;
            if (lines[i] == "\r") break;

            string[] col = lines[i].Split(new char[] { '\t' });

            if (col == null || col.Length != 3) break;
            DateTime dt = DateTime.Parse(col[0] + " " + col[1]);

            ser.Points.AddXY(dt.ToOADate(), Convert.ToDouble(col[2]));
          }

          ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
          ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;

          m_chartExec2.ChartAreas.Clear();
          m_chartExec2.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea());
          m_chartExec2.Series.Clear();
          m_chartExec2.Series.Add(ser);
          m_chartExec2.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
          m_chartExec2.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
          m_chartExec2.ChartAreas[0].AxisX.Interval = 1;
          m_chartExec2.Legends.Clear();
        }
        if (result["customScript_3"] != null) {
          string[] lines = result["customScript_3"].Split(new char[] { '\n' });

          System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("Hits error");
          ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Column;

          for (int i = 0; i < lines.Count(); ++i) {
            if (i == 0) continue;

            if (String.IsNullOrEmpty(lines[i])) break;
            if (lines[i] == "\r") break;

            string[] col = lines[i].Split(new char[] { '\t' });

            if (col == null || col.Length != 3) break;
            DateTime dt = DateTime.Parse(col[0] + " " + col[1]);

            ser.Points.AddXY(dt.ToOADate(), Convert.ToDouble(col[2]));
          }

          ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
          ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;

          m_chart_hitsError.ChartAreas.Clear();
          m_chart_hitsError.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea());
          m_chart_hitsError.Series.Clear();
          m_chart_hitsError.Series.Add(ser);
          m_chart_hitsError.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
          m_chart_hitsError.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
          m_chart_hitsError.ChartAreas[0].AxisX.Interval = 1;
          m_chart_hitsError.Legends.Clear();
        }
      }
      catch (Exception ex) {
        System.Diagnostics.Debug.WriteLine(ex.ToString());
      }
    }
  }
}
