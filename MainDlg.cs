using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Net;
using System.IO;
using System.Xml;

namespace IISLogParser
{
  public partial class MainDlg : Form
  {
    private List<string> _filenames = new List<string>();
    private string _textLabel = String.Format("{0} ({1})", "IIS Log Parser", System.Reflection.Assembly.GetExecutingAssembly().GetName().Version.ToString());

    public MainDlg()
    {
      InitializeComponent();
    }

    protected override void OnLoad(EventArgs e)
    {
      base.OnLoad(e);

      string ss = System.Configuration.ConfigurationManager.AppSettings["kdkdkd"];


      m_BWorker.DoWork += m_BWorker_DoWork;
      m_BWorker.WorkerReportsProgress = true;
      m_BWorker.ProgressChanged += m_BWorker_ProgressChanged;
      m_BWorker.WorkerSupportsCancellation = true;

      m_bwParseLog.DoWork += m_bwParseLog_DoWork;
      m_bwParseLog.WorkerReportsProgress = true;
      m_bwParseLog.ProgressChanged += m_bwParseLog_ProgressChanged;
      m_bwParseLog.WorkerSupportsCancellation = true;

      this.Text = _textLabel;
    }

    void m_bwParseLog_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      OnUpdateProgressBar(e.ProgressPercentage, Convert.ToString(e.UserState));
    }

    delegate void pf_SetDataToTabs(Dictionary<string, string> data);
    protected void OnSetDataToTabs(Dictionary<string, string> data)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new pf_SetDataToTabs(OnSetDataToTabs), new object[] { data });
      }
      else
      {

       // rtbFindOS.Text = data["FindOS"];
       // PrepareFindOS(data["FindOS"]);

        rtbAvgExecTime.Text = data["AverageExecutionTime"];
        PrepareAverageExecutionTime(data["AverageExecutionTime"]);

        rtbExecutionTimeMinAvMax.Text = data["ExecutionTimeMinAvMax"];
        ExecutionTimeMinAvMax(data["ExecutionTimeMinAvMax"]);

        rtbExecutionTimeMore10s.Text = data["ExecutionTimeMore10s"];
        PrepareExecutionTimeMoreThan10s(data["ExecutionTimeMore10s"]);

        rtbExecutionTimeMore20s.Text = data["ExecutionTimeMore20s"];
        PrepareExecutionTimeMoreThan20s(data["ExecutionTimeMore20s"]);

        rtbHitsByExtention.Text = data["HitsByExtension"];
        PrepareHitsByExtention(data["HitsByExtension"]);

        rtbHitsByHour.Text = data["HitsByHour"];
        PrepareHitsByHourChart(data["HitsByHour"]);

        rtbHitsByDateHour.Text = data["HitsByDateHour"];
        PrepareHitsByDateHourChart(data["HitsByDateHour"]);

        rtbIPs.Text = data["IPs"];
        HitsByIP(data["IPs"]);

        rtbStatusCode.Text = data["StatusCode"];
        PrepareStatusCode(data["StatusCode"]);

        rtbStatusCodeWithOutStatic.Text = data["StatusCodeWithoutStatic"];
        rtbTop1000ExecutionTime.Text = data["Top1000ExecutionTimeMaximum"];
        rtbUniqueIPs.Text = data["UniqueIPs"];
        
        rtbUrl404_.AppendText( data["Url404"] );
        Prepare404(data["Url404"]);

        rtbUrl500.Text = data["Url500"];
        rtbUrl500Full.Text = data["Url500Full"];
        rtbUserAgent.Text = data["UserAgent"];
        rtbUserAgentFirefox.Text = data["UserAgentFireFox"];
        rtbUserAgentFull.Text = data["UserAgentFull"];

        rtbUserAgentIE.Text = data["UserAgentIE"];
        PrepareUserAgentIE(data["UserAgentIE"]);

        rtbUserAgentOpera.Text = data["UserAgentOpera"];

        //rtNoRequestsByUser.Text = data["NoOfRequestsMadeByUser"];
        //PrepareNoRequestsByUser(data["NoOfRequestsMadeByUser"]);

        
        
        _results = data;

      }
    }

    private void ExecutionTimeMinAvMax(string data)
    {
      DataTable tb = new DataTable("ExecutionTimeMinAvMax");
      tb.Columns.Add("MinExecutionTime", typeof(double));
      tb.Columns.Add("AverageExecutionTime", typeof(double));
      tb.Columns.Add("MaxExecutionTime", typeof(double));
      tb.Columns.Add("Hits", typeof(double));
      tb.Columns.Add("URL", typeof(string));

      StringReader sr = new StringReader(data);
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        DataRow dr = tb.NewRow();
        if (!string.IsNullOrEmpty(sb[0]))
        {
          //dr[0] = sb[0];
          double d = 0;
          if (double.TryParse(sb[0], out d))
          {
            dr[0] = d;
          }
          else
          {
            break;
          }
        }
        else
        {
          dr[0] = 0;
        }
        if (!string.IsNullOrEmpty(sb[1]))
        {
          dr[1] = sb[1];
        }
        else
        {
          dr[1] = 0;
        }
        if (!string.IsNullOrEmpty(sb[2]))
        {
          dr[2] = sb[2];
        }
        else
        {
          dr[2] = 0;
        }

        dr[3] = sb[3];
        dr[4] = sb[4];
        tb.Rows.Add(dr);
        line = sr.ReadLine();
      }
      gvExecutionTimeMinAvMax.ReadOnly = true;
      gvExecutionTimeMinAvMax.DataSource = tb;
    }

    private void HitsByIP(string data)
    {
      DataTable tb = new DataTable("HitsByIP");
      tb.Columns.Add("IP", typeof(String));
      tb.Columns.Add("Hits", typeof(double));

      StringReader sr = new StringReader(data);
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        DataRow dr = tb.NewRow();
        if (sb[0] == "Task completed with parse errors.") break;
        if (sb[0] == "Parse errors:") break;
        dr[0] = sb[0];
        dr[1] = sb[1];
        tb.Rows.Add(dr);
        line = sr.ReadLine();
      }
      gvHitsByIP.ReadOnly = true;
      gvHitsByIP.DataSource = tb;
    }

    private void Prepare404(string data)
    {
      DataTable tb = new DataTable("Url 404");
      tb.Columns.Add("URL", typeof(String));
      tb.Columns.Add("Hits", typeof(double));

      StringReader sr = new StringReader(data);
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        DataRow dr = tb.NewRow();
        if (sb[0] == "Task completed with parse errors.") break;
        dr[0] = sb[0];
        if (sb.Length > 1)
        {
          dr[1] = sb[1];
        }
        
        tb.Rows.Add(dr);
        line = sr.ReadLine();
      }
      gvUrl404.ReadOnly = true;
      gvUrl404.DataSource = tb;
    }

    private void PrepareExecutionTimeMoreThan10s(string data)
    {
      DataTable tb = new DataTable("AverageExecutionTime");
      tb.Columns.Add("URL", typeof(String));
      tb.Columns.Add("AverageExecutionTime", typeof(double));
      tb.Columns.Add("Hits", typeof(double));

      StringReader sr = new StringReader(data);
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        DataRow dr = tb.NewRow();
        if (sb[0] == "Task completed with parse errors.") break;
        dr[0] = sb[0];
        if (sb.Length > 1)
        {
          dr[1] = sb[1];
        }
        if (sb.Length > 2)
        {
          dr[2] = sb[2];
        }
        tb.Rows.Add(dr);
        line = sr.ReadLine();
      }
      gvExecutionTimeMoreThan10s.ReadOnly = true;
      gvExecutionTimeMoreThan10s.DataSource = tb;
    }

    private void PrepareExecutionTimeMoreThan20s(string data)
    {
      DataTable tb = new DataTable("AverageExecutionTime");
      tb.Columns.Add("URL", typeof(String));
      tb.Columns.Add("AverageExecutionTime", typeof(double));
      tb.Columns.Add("Hits", typeof(double));

      StringReader sr = new StringReader(data);
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        DataRow dr = tb.NewRow();
        if (sb[0] == "Task completed with parse errors.") break;

        if (sb.Length > 0) dr[0] = sb[0];
        if (sb.Length > 1) dr[1] = sb[1];
        if (sb.Length > 2) dr[2] = sb[2];
        if (sb.Length > 0) tb.Rows.Add(dr);

        line = sr.ReadLine();
      }
      gvExecutionTimeMore20s.ReadOnly = true;
      gvExecutionTimeMore20s.DataSource = tb;
    }

    private void PrepareAverageExecutionTime(string data)
    {
      DataTable tb = new DataTable("AverageExecutionTime");
      tb.Columns.Add("AverageExecutionTime", typeof(double));
      tb.Columns.Add("Hits", typeof(double));
      tb.Columns.Add("URL", typeof(String));

      StringReader sr = new StringReader(data);
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        DataRow dr = tb.NewRow();
        if (!String.IsNullOrEmpty(sb[0]))
        {
          double d = 0;
          if (double.TryParse(sb[0], out d))
          {
            dr[0] = d;
          }
          else
          {
            break;
          }
        }
        dr[1] = sb[1];
        dr[2] = sb[2];
        tb.Rows.Add(dr);
        line = sr.ReadLine();
      }
      gvAveragaExecTime.DataSource = tb;
    }

    private void PrepareNoRequestsByUser(string data)
    {
      DataTable tb = new DataTable("NoRequestsByUser");
      tb.Columns.Add("User", typeof(string));
      tb.Columns.Add("Hits", typeof(double));

      StringReader sr = new StringReader(data);
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        DataRow dr = tb.NewRow();
        if (!String.IsNullOrEmpty(sb[0]))
        {
          double d = 0;
          if (double.TryParse(sb[0], out d))
          {
            dr[0] = d;
          }
          else
          {
            break;
          }
        }
        dr[1] = sb[1];
        dr[2] = sb[2];
        tb.Rows.Add(dr);
        line = sr.ReadLine();
      }
      dgvNoRequestsByUser.DataSource = tb;
    }

    private void PrepareHitsByExtention(string data)
    {
      StringReader sr = new StringReader(data);
      System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("Hits by extention");
      ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        string x = sb[0];
        if (x == "Task completed with parse errors.") break;
        if (x == "Parse errors:") break;
        double y = Double.Parse(sb[1]);
        ser.Points.AddXY(x, y);
        ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        line = sr.ReadLine();
      }

      m_chartHitsByExtention.Series.Clear();
      m_chartHitsByExtention.Series.Add(ser);
    }

    private void PrepareFindOS(string data)
    {
      StringReader sr = new StringReader(data);
      System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("Operating System(s) \\ Hits");
      ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        string x = sb[0];
        if (x == "Task completed with parse errors.") break;
        if (sb.Length == 1)
        {
          line = sr.ReadLine();
          continue;
        }
        double y = Double.Parse(sb[1]);
        ser.Points.AddXY(x, y);
        ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        line = sr.ReadLine();
      }

      m_chartFindOS.Series.Clear();
      m_chartFindOS.Series.Add(ser);
    }

    private void PrepareStatusCode(string data)
    {
      StringReader sr = new StringReader(data);
      System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("Status Codes");
      ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        string x = sb[0];
        if (x == "Task completed with parse errors.") break;
        double y = Double.Parse(sb[1]);
        ser.Points.AddXY(x, y);
        ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        line = sr.ReadLine();
      }

      m_chartStatusCode.Series.Clear();
      m_chartStatusCode.Series.Add(ser);
    }

    private void PrepareUserAgentIE(string data)
    {
      StringReader sr = new StringReader(data);
      System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("User agent IE");
      ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Pie;
      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        string x = sb[0];
        if (x == "Task completed with parse errors.") break;
        double y = Double.Parse(sb[1]);
        ser.Points.AddXY(x, y);
        ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.String;
        ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
        line = sr.ReadLine();
      }

      m_chartUserAgentIE.Series.Clear();
      m_chartUserAgentIE.Series.Add(ser);
    }

    private class HitsByHour
    {
      public DateTime Date { get; set; }
      public double Value { get; set; }
    }
    private void PrepareHitsByHourChart(string data)
    {
      StringReader sr = new StringReader(data);
      System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("Hits by hour");
      ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

      List<HitsByHour> srtData = new List<HitsByHour>();

      string line = sr.ReadLine();
      line = sr.ReadLine();

      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        if (sb[0] == "Task completed with parse errors.") break;
        if (sb[0] == "Parse errors:") break;
        DateTime x = DateTime.Parse(sb[0]);
        double y = Double.Parse(sb[1]);

        srtData.Add(new HitsByHour() { Date = x, Value = y });
        
        line = sr.ReadLine();
      }

      foreach(var it in srtData.OrderBy(x=>x.Date).ToList())
      {
        ser.Points.AddXY(new DateTime(DateTime.MinValue.Year, DateTime.MinValue.Month, DateTime.MinValue.Day, it.Date.Hour, it.Date.Minute, it.Date.Second).ToOADate(), it.Value);
      }

      ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;
      ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Date;
      
      m_chartHitsByHour.ChartAreas.Clear();
      m_chartHitsByHour.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("HitsByHour"));
      m_chartHitsByHour.Series.Clear();
      m_chartHitsByHour.Series.Add(ser);
      m_chartHitsByHour.ChartAreas[0].AxisX.LabelStyle.Format = "HH:mm:ss";
      m_chartHitsByHour.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
      m_chartHitsByHour.ChartAreas[0].AxisX.Interval = 1;
    }

    private void PrepareHitsByDateHourChart(string data)
    {
      StringReader sr = new StringReader(data);
      System.Windows.Forms.DataVisualization.Charting.Series ser = new System.Windows.Forms.DataVisualization.Charting.Series("Hits by Date / Hour");
      ser.ChartType = System.Windows.Forms.DataVisualization.Charting.SeriesChartType.Bar;

      string line = sr.ReadLine();
      line = sr.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        string[] sb = line.Split('\t');
        if (sb[0] == "Task completed with parse errors.") break;
        if (sb[0] == "Parse errors:") break;
        DateTime x = DateTime.Parse(sb[0] + " " + sb[1]);
        double y = Double.Parse(sb[2]);
        ser.Points.AddXY(x.ToOADate(), y);
        
        line = sr.ReadLine();
      }
      ser.XValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.DateTime;
      ser.YValueType = System.Windows.Forms.DataVisualization.Charting.ChartValueType.Double;

      m_chartHitsByDateHour.ChartAreas.Clear();
      m_chartHitsByDateHour.ChartAreas.Add(new System.Windows.Forms.DataVisualization.Charting.ChartArea("HitsByDateHour"));
      m_chartHitsByDateHour.Series.Clear();
      m_chartHitsByDateHour.Series.Add(ser);
      m_chartHitsByDateHour.Series.Clear();
      m_chartHitsByDateHour.Series.Add(ser);
      m_chartHitsByDateHour.ChartAreas[0].AxisX.LabelStyle.Format = "yyyy/MM/dd HH:mm:ss";
      m_chartHitsByDateHour.ChartAreas[0].AxisX.IntervalType = System.Windows.Forms.DataVisualization.Charting.DateTimeIntervalType.Hours;
      m_chartHitsByDateHour.ChartAreas[0].AxisX.Interval = 5;
    }

    void m_bwParseLog_DoWork(object sender, DoWorkEventArgs e)
    {
      LogParser.LogParser cls = new LogParser.LogParser(_filenames);
      cls.eOneQueryExecuted += cls_eOneQueryExecuted;
      cls.eDoneExecution += cls_eDoneExecution;


      Dictionary<string, string> res = cls.Run();
      OnSetDataToTabs(res);
    }

    delegate void pf_cls_eDoneExecution(string message);
    private void cls_eDoneExecution(string message) {
      if (this.InvokeRequired) {
        this.BeginInvoke(new pf_cls_eDoneExecution(cls_eDoneExecution), new object[] { message });
      } else {
        _toolStripProgressBar.PerformStep();

        _toolStripStatusLabel_Script.Text = message;
      }
    }

    delegate void pf_OnUpdateProgressBar(int i, string scriptName);
    protected void OnUpdateProgressBar(int i, string scriptName)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new pf_OnUpdateProgressBar(OnUpdateProgressBar), new object[] { i, scriptName });
      }
      else
      {
        _toolStripProgressBar.PerformStep();

        _toolStripStatusLabel_Script.Text = scriptName;
      }
    }

    void cls_eOneQueryExecuted(int i, string scriptName)
    {
      m_bwParseLog.ReportProgress(i, scriptName);
    }

    void m_BWorker_ProgressChanged(object sender, ProgressChangedEventArgs e)
    {
      //throw new NotImplementedException();
    }

    private class IPs
    {
      public int Hits { get; set; }
      public string IP { get; set; }
    }
    void m_BWorker_DoWork(object sender, DoWorkEventArgs e)
    {
      WebClient client = new WebClient();
      StringReader rw = new StringReader(_results["IPs"]);
      List<IPs> dataIps = new List<IPs>();

      string line = rw.ReadLine();
      while (!string.IsNullOrEmpty(line))
      {
        if (line[0] == 'I') { line = rw.ReadLine(); continue; };
        if (line.Length == 0) break;

        string[] s = line.Split(new char[] { '\t' });
        if (s.Length != 2) continue;
        
        IPs p = new IPs();
        p.IP = s[0];
        p.Hits = Int32.Parse(s[1]);
        dataIps.Add(p);
        if (m_BWorker.CancellationPending) break;

        line = rw.ReadLine();
      }

      foreach (var itdata in dataIps.OrderByDescending(x => x.Hits).ToList())
      {
        string country = string.Empty;
        Stream data = null;
        StreamReader reader = null;
        try
        {
          data = client.OpenRead(string.Format("http://freegeoip.net/xml/{0}", itdata.IP));

          reader = new StreamReader(data);

          XmlDocument xmlDoc = new XmlDocument();
          xmlDoc.Load(reader);
          XmlElement root = xmlDoc.DocumentElement;
          XmlNode xn = root.SelectSingleNode("/Response/CountryName");
          if (xn != null)
          {
            country = xn.InnerText;
          }
        }
        catch (System.Net.WebException webEx)
        {
          country = "Not found";
          // MessageBox.Show(webEx.ToString());
        }
        finally
        {
          if (data != null) data.Close();
          if (reader != null) reader.Close();
        }

        ListViewItem it = new ListViewItem();
        ListViewItem.ListViewSubItem its = new ListViewItem.ListViewSubItem();
        its.Text = country;
        it.SubItems.Add(its);
        its = new ListViewItem.ListViewSubItem();
        its.Text = itdata.IP;
        it.SubItems.Add(its);
        its = new ListViewItem.ListViewSubItem();
        its.Text = itdata.Hits.ToString();
        it.SubItems.Add(its);
        //lstVGeoIPResults.Items.Add(it);
        OnUpdateListBox(it);
        System.Diagnostics.Debug.WriteLine(String.Format("Country[{0}], IP[{1}], Hits[{2}].", country, itdata.IP, itdata.Hits));

        if (m_BWorker.CancellationPending) break;
      }
    }
    delegate void pf_OnUpdateListBox(ListViewItem it);

    void OnUpdateListBox(ListViewItem it)
    {
      if (this.InvokeRequired)
      {
        this.BeginInvoke(new pf_OnUpdateListBox(OnUpdateListBox), new object[] { it });
      }
      else
      {
        lstVGeoIPResults.Items.Add(it);
      }
    }

    private void button1_Click(object sender, EventArgs e)
    {
      try
      {
        if (_results == null) { MessageBox.Show("Parse a log file first."); return; }
        if (!m_BWorker.IsBusy)
        {
          m_BWorker.RunWorkerAsync();
        }
        else
        {
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    private void btnLoadLogFile_Click(object sender, EventArgs e)
    {
      try
      {
        frmFileManager fff = new frmFileManager(_filenames);
        using (fff) {
          if(fff.ShowDialog(this) == DialogResult.OK) {
            _filenames = fff.FilesSelected;
          }
        }

        //_filenames = new List<string>();
        //OpenFileDialog fdlg = new OpenFileDialog();
        //fdlg.Filter = "IIS Log Files (.log)|*.log|All Files (*.*)|*.*";
        //fdlg.FilterIndex = 1;
        //fdlg.Multiselect = false;

        //using (fdlg)
        //{
        //  if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
        //  {
        //    if (String.IsNullOrEmpty(fdlg.FileName))
        //    {
        //      return;
        //    }
        //    _filenames.Add(fdlg.FileName);
        //  }
        //  if (_filenames == null || _filenames.Count == 0) return;
        //  this.Text = String.Format("{0} [{1}]", _textLabel, _filenames[0]);
        //}
        
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    Dictionary<string, string> _results = null;
    private void btnStartProcess_Click(object sender, EventArgs e)
    {
      _toolStripStatusLabel_Script.Text = "..";
      //foreach(var it in System.Net.NetworkInformation.NetworkInterface.GetAllNetworkInterfaces())
      //{
      //  System.Diagnostics.Debug.WriteLine(it.Description);
      //  System.Net.NetworkInformation.IPInterfaceProperties p = it.GetIPProperties();
      //  foreach(var iii in p.UnicastAddresses)
      //  {
      //    System.Diagnostics.Debug.WriteLine(iii.Address.ToString());
      //  }
      //}
      if (_filenames == null || _filenames.Count() == 0)
      {
        MessageBox.Show(this, "Please select log file or folder first.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
        return;
      }
      if (!m_bwParseLog.IsBusy)
      {
        _toolStripProgressBar.Minimum = 0;
        _toolStripProgressBar.Maximum = LogParser.LogParser.NumberOfQueriesToExecute;
        _toolStripProgressBar.Step = 1;
        _toolStripProgressBar.Value = 0;
        //_toolStripProgressBar.Show();

        m_bwParseLog.RunWorkerAsync(this);
      }
      else
      {
        MessageBox.Show("Still executing..", "Info", MessageBoxButtons.OK, MessageBoxIcon.Information);
      }
    }

    private void btnStopGeoIPLoc_Click(object sender, EventArgs e)
    {
      if (m_BWorker.IsBusy)
      {
        m_BWorker.CancelAsync();
      }
    }

    private void btnSelectFolder_Click(object sender, EventArgs e)
    {
      try
      {
        _filenames = new List<string>();
        FolderBrowserDialog fdlg =  new FolderBrowserDialog();
        //fdlg.Filter = "IIS Log Files (.log)|*.log|All Files (*.*)|*.*";
        //fdlg.FilterIndex = 1;
        //fdlg.Multiselect = true;
        fdlg.ShowNewFolderButton = false;
        
        using (fdlg)
        {
          if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
          {
            if (String.IsNullOrEmpty(fdlg.SelectedPath))
            {
              MessageBox.Show(this, "Please select a folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
            if (!System.IO.Directory.Exists(fdlg.SelectedPath))
            {
              MessageBox.Show(this, "Please select a valid folder.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
              return;
            }
            foreach (var it in System.IO.Directory.GetFiles(fdlg.SelectedPath, "*.log"))
            {
              _filenames.Add(it);
            }
            this.Text = String.Format("{0} [{1}]", _textLabel, fdlg.SelectedPath);
            if (_filenames == null || _filenames.Count == 0) return;
            
          }
        }
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString());
      }
    }

    private void btnAbout_Click(object sender, EventArgs e)
    {
      AboutBox frm = new AboutBox();
      using (frm)
      {
        frm.ShowDialog();
      }
    }

    private void btnCustomExecution_Click(object sender, EventArgs e)
    {
      frmCustomSql frm = new frmCustomSql(_filenames);
      using (frm)
      {
        frm.ShowDialog();
      }
    }

    private void btnTimeExecution_Click(object sender, EventArgs e)
    {
      frmExecOverTime frm = new frmExecOverTime();
      using (frm)
      {
        frm.Logfilenames = _filenames;
        frm.ShowDialog(this);
      }
    }

    private void btnUrlExec_Click(object sender, EventArgs e)
    {
      try
      {
        frmExecOverTime frm = new frmExecOverTime();
        string url = string.Empty;
        //if(gvAveragaExecTime.SelectedCells.Count>0)
        //{
        //  url = 
        //}
        if (gvAveragaExecTime.SelectedRows.Count > 0)
        {
          url = (string)gvAveragaExecTime.SelectedRows[0].Cells[2].Value;
        }
        else
        {
          MessageBox.Show("Please select a row.", "Information", MessageBoxButtons.OK, MessageBoxIcon.Information);
          return;
        }
        frm.URL = url;
        using (frm)
        {
          frm.Logfilenames = _filenames;
          frm.ShowDialog(this);
        }
      }catch(Exception ex)
      {

      }
      finally
      { }
    }
  }
}
