namespace IISLogParser
{
  partial class MainDlg
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea1 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend1 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series1 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea2 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend2 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea3 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend3 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea4 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend4 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series2 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series3 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series4 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainDlg));
      this.button1 = new System.Windows.Forms.Button();
      this.lstVGeoIPResults = new System.Windows.Forms.ListView();
      this.columnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.columnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.m_BWorker = new System.ComponentModel.BackgroundWorker();
      this.btnLoadLogFile = new System.Windows.Forms.Button();
      this.btnStartProcess = new System.Windows.Forms.Button();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage2 = new System.Windows.Forms.TabPage();
      this.btnUrlExec = new System.Windows.Forms.Button();
      this.gvAveragaExecTime = new System.Windows.Forms.DataGridView();
      this.rtbAvgExecTime = new System.Windows.Forms.RichTextBox();
      this.tabPage1 = new System.Windows.Forms.TabPage();
      this.btnStopGeoIPLoc = new System.Windows.Forms.Button();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.gvExecutionTimeMinAvMax = new System.Windows.Forms.DataGridView();
      this.rtbExecutionTimeMinAvMax = new System.Windows.Forms.RichTextBox();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.gvExecutionTimeMoreThan10s = new System.Windows.Forms.DataGridView();
      this.rtbExecutionTimeMore10s = new System.Windows.Forms.RichTextBox();
      this.tabPage5 = new System.Windows.Forms.TabPage();
      this.gvExecutionTimeMore20s = new System.Windows.Forms.DataGridView();
      this.rtbExecutionTimeMore20s = new System.Windows.Forms.RichTextBox();
      this.tabPage6 = new System.Windows.Forms.TabPage();
      this.m_chartHitsByExtention = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.rtbHitsByExtention = new System.Windows.Forms.RichTextBox();
      this.tabPage7 = new System.Windows.Forms.TabPage();
      this.m_chartHitsByHour = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.rtbHitsByHour = new System.Windows.Forms.RichTextBox();
      this.tabPage8 = new System.Windows.Forms.TabPage();
      this.gvHitsByIP = new System.Windows.Forms.DataGridView();
      this.rtbIPs = new System.Windows.Forms.RichTextBox();
      this.tbHitsByDateHour = new System.Windows.Forms.TabPage();
      this.pnl_Chart = new System.Windows.Forms.Panel();
      this.m_chartHitsByDateHour = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.rtbHitsByDateHour = new System.Windows.Forms.RichTextBox();
      this.tabPage9 = new System.Windows.Forms.TabPage();
      this.m_chartStatusCode = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.rtbStatusCode = new System.Windows.Forms.RichTextBox();
      this.tabPage10 = new System.Windows.Forms.TabPage();
      this.rtbStatusCodeWithOutStatic = new System.Windows.Forms.RichTextBox();
      this.tabPage11 = new System.Windows.Forms.TabPage();
      this.rtbTop1000ExecutionTime = new System.Windows.Forms.RichTextBox();
      this.tabPage12 = new System.Windows.Forms.TabPage();
      this.rtbUniqueIPs = new System.Windows.Forms.RichTextBox();
      this.tabPage13 = new System.Windows.Forms.TabPage();
      this.gvUrl404 = new System.Windows.Forms.DataGridView();
      this.rtbUrl404_ = new System.Windows.Forms.RichTextBox();
      this.tabPage14 = new System.Windows.Forms.TabPage();
      this.rtbUrl500 = new System.Windows.Forms.RichTextBox();
      this.tabPage15 = new System.Windows.Forms.TabPage();
      this.rtbUrl500Full = new System.Windows.Forms.RichTextBox();
      this.tabPage16 = new System.Windows.Forms.TabPage();
      this.rtbUserAgent = new System.Windows.Forms.RichTextBox();
      this.tabPage17 = new System.Windows.Forms.TabPage();
      this.rtbUserAgentFirefox = new System.Windows.Forms.RichTextBox();
      this.tabPage18 = new System.Windows.Forms.TabPage();
      this.rtbUserAgentFull = new System.Windows.Forms.RichTextBox();
      this.tabPage19 = new System.Windows.Forms.TabPage();
      this.m_chartUserAgentIE = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.rtbUserAgentIE = new System.Windows.Forms.RichTextBox();
      this.tabPage20 = new System.Windows.Forms.TabPage();
      this.rtbUserAgentOpera = new System.Windows.Forms.RichTextBox();
      this.tabPage21 = new System.Windows.Forms.TabPage();
      this.m_chartFindOS = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.rtbFindOS = new System.Windows.Forms.RichTextBox();
      this.tbNoOfRequestsByUser = new System.Windows.Forms.TabPage();
      this.dgvNoRequestsByUser = new System.Windows.Forms.DataGridView();
      this.rtNoRequestsByUser = new System.Windows.Forms.RichTextBox();
      this.tpVarious = new System.Windows.Forms.TabPage();
      this.chrtExecutionTimes = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.btnTimeExecution = new System.Windows.Forms.Button();
      this.pnlBottom = new System.Windows.Forms.Panel();
      this._statusStrip = new System.Windows.Forms.StatusStrip();
      this._toolStripProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      this._toolStripStatusLabel_Script = new System.Windows.Forms.ToolStripStatusLabel();
      this.pnlTop = new System.Windows.Forms.Panel();
      this.btnCustomExecution = new System.Windows.Forms.Button();
      this.btnAbout = new System.Windows.Forms.Button();
      this.m_bwParseLog = new System.ComponentModel.BackgroundWorker();
      this._panelTop = new System.Windows.Forms.Panel();
      this.tabControl1.SuspendLayout();
      this.tabPage2.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvAveragaExecTime)).BeginInit();
      this.tabPage1.SuspendLayout();
      this.tabPage3.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvExecutionTimeMinAvMax)).BeginInit();
      this.tabPage4.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvExecutionTimeMoreThan10s)).BeginInit();
      this.tabPage5.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvExecutionTimeMore20s)).BeginInit();
      this.tabPage6.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartHitsByExtention)).BeginInit();
      this.tabPage7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartHitsByHour)).BeginInit();
      this.tabPage8.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvHitsByIP)).BeginInit();
      this.tbHitsByDateHour.SuspendLayout();
      this.pnl_Chart.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartHitsByDateHour)).BeginInit();
      this.tabPage9.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartStatusCode)).BeginInit();
      this.tabPage10.SuspendLayout();
      this.tabPage11.SuspendLayout();
      this.tabPage12.SuspendLayout();
      this.tabPage13.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.gvUrl404)).BeginInit();
      this.tabPage14.SuspendLayout();
      this.tabPage15.SuspendLayout();
      this.tabPage16.SuspendLayout();
      this.tabPage17.SuspendLayout();
      this.tabPage18.SuspendLayout();
      this.tabPage19.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartUserAgentIE)).BeginInit();
      this.tabPage20.SuspendLayout();
      this.tabPage21.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartFindOS)).BeginInit();
      this.tbNoOfRequestsByUser.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.dgvNoRequestsByUser)).BeginInit();
      this.tpVarious.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.chrtExecutionTimes)).BeginInit();
      this.pnlBottom.SuspendLayout();
      this._statusStrip.SuspendLayout();
      this.pnlTop.SuspendLayout();
      this._panelTop.SuspendLayout();
      this.SuspendLayout();
      // 
      // button1
      // 
      this.button1.Location = new System.Drawing.Point(12, 9);
      this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.button1.Name = "button1";
      this.button1.Size = new System.Drawing.Size(309, 35);
      this.button1.TabIndex = 0;
      this.button1.Text = "GeoIP Locator";
      this.button1.UseVisualStyleBackColor = true;
      this.button1.Click += new System.EventHandler(this.button1_Click);
      // 
      // lstVGeoIPResults
      // 
      this.lstVGeoIPResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstVGeoIPResults.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader4,
            this.columnHeader1,
            this.columnHeader2,
            this.columnHeader3});
      this.lstVGeoIPResults.Location = new System.Drawing.Point(14, 54);
      this.lstVGeoIPResults.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.lstVGeoIPResults.Name = "lstVGeoIPResults";
      this.lstVGeoIPResults.Size = new System.Drawing.Size(2032, 709);
      this.lstVGeoIPResults.TabIndex = 1;
      this.lstVGeoIPResults.UseCompatibleStateImageBehavior = false;
      this.lstVGeoIPResults.View = System.Windows.Forms.View.Details;
      // 
      // columnHeader4
      // 
      this.columnHeader4.Text = "#";
      // 
      // columnHeader1
      // 
      this.columnHeader1.Text = "Country";
      // 
      // columnHeader2
      // 
      this.columnHeader2.Text = "IP";
      // 
      // columnHeader3
      // 
      this.columnHeader3.Text = "Hits";
      // 
      // btnLoadLogFile
      // 
      this.btnLoadLogFile.Location = new System.Drawing.Point(4, 15);
      this.btnLoadLogFile.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnLoadLogFile.Name = "btnLoadLogFile";
      this.btnLoadLogFile.Size = new System.Drawing.Size(262, 35);
      this.btnLoadLogFile.TabIndex = 2;
      this.btnLoadLogFile.Text = "Select & Manage IIS Log file(s)..";
      this.btnLoadLogFile.UseVisualStyleBackColor = true;
      this.btnLoadLogFile.Click += new System.EventHandler(this.btnLoadLogFile_Click);
      // 
      // btnStartProcess
      // 
      this.btnStartProcess.Location = new System.Drawing.Point(331, 15);
      this.btnStartProcess.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnStartProcess.Name = "btnStartProcess";
      this.btnStartProcess.Size = new System.Drawing.Size(309, 35);
      this.btnStartProcess.TabIndex = 3;
      this.btnStartProcess.Text = "Start process";
      this.btnStartProcess.UseVisualStyleBackColor = true;
      this.btnStartProcess.Click += new System.EventHandler(this.btnStartProcess_Click);
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage2);
      this.tabControl1.Controls.Add(this.tabPage1);
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Controls.Add(this.tabPage5);
      this.tabControl1.Controls.Add(this.tabPage6);
      this.tabControl1.Controls.Add(this.tabPage7);
      this.tabControl1.Controls.Add(this.tabPage8);
      this.tabControl1.Controls.Add(this.tbHitsByDateHour);
      this.tabControl1.Controls.Add(this.tabPage9);
      this.tabControl1.Controls.Add(this.tabPage10);
      this.tabControl1.Controls.Add(this.tabPage11);
      this.tabControl1.Controls.Add(this.tabPage12);
      this.tabControl1.Controls.Add(this.tabPage13);
      this.tabControl1.Controls.Add(this.tabPage14);
      this.tabControl1.Controls.Add(this.tabPage15);
      this.tabControl1.Controls.Add(this.tabPage16);
      this.tabControl1.Controls.Add(this.tabPage17);
      this.tabControl1.Controls.Add(this.tabPage18);
      this.tabControl1.Controls.Add(this.tabPage19);
      this.tabControl1.Controls.Add(this.tabPage20);
      this.tabControl1.Controls.Add(this.tabPage21);
      this.tabControl1.Controls.Add(this.tbNoOfRequestsByUser);
      this.tabControl1.Controls.Add(this.tpVarious);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(2031, 776);
      this.tabControl1.TabIndex = 4;
      // 
      // tabPage2
      // 
      
      this.tabPage2.Controls.Add(this.gvAveragaExecTime);
      this.tabPage2.Controls.Add(this._panelTop);
      this.tabPage2.Controls.Add(this.rtbAvgExecTime);
      this.tabPage2.Location = new System.Drawing.Point(4, 29);
      this.tabPage2.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage2.Name = "tabPage2";
      this.tabPage2.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage2.Size = new System.Drawing.Size(2023, 743);
      this.tabPage2.TabIndex = 1;
      this.tabPage2.Text = "Average Execution Time";
      this.tabPage2.UseVisualStyleBackColor = true;
      // 
      // btnUrlExec
      // 
      this.btnUrlExec.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnUrlExec.Location = new System.Drawing.Point(1362, 1);
      this.btnUrlExec.Name = "btnUrlExec";
      this.btnUrlExec.Size = new System.Drawing.Size(181, 42);
      this.btnUrlExec.TabIndex = 2;
      this.btnUrlExec.Text = "URL execution times";
      this.btnUrlExec.UseVisualStyleBackColor = true;
      this.btnUrlExec.Click += new System.EventHandler(this.btnUrlExec_Click);
      // 
      // gvAveragaExecTime
      // 
      this.gvAveragaExecTime.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvAveragaExecTime.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvAveragaExecTime.Location = new System.Drawing.Point(476, 5);
      this.gvAveragaExecTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gvAveragaExecTime.Name = "gvAveragaExecTime";
      this.gvAveragaExecTime.Size = new System.Drawing.Size(1543, 733);
      this.gvAveragaExecTime.TabIndex = 1;
      // 
      // rtbAvgExecTime
      // 
      this.rtbAvgExecTime.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbAvgExecTime.Location = new System.Drawing.Point(4, 5);
      this.rtbAvgExecTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbAvgExecTime.Name = "rtbAvgExecTime";
      this.rtbAvgExecTime.Size = new System.Drawing.Size(472, 733);
      this.rtbAvgExecTime.TabIndex = 0;
      this.rtbAvgExecTime.Text = "";
      // 
      // tabPage1
      // 
      this.tabPage1.Controls.Add(this.btnStopGeoIPLoc);
      this.tabPage1.Controls.Add(this.lstVGeoIPResults);
      this.tabPage1.Controls.Add(this.button1);
      this.tabPage1.Location = new System.Drawing.Point(4, 29);
      this.tabPage1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage1.Name = "tabPage1";
      this.tabPage1.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage1.Size = new System.Drawing.Size(2023, 743);
      this.tabPage1.TabIndex = 0;
      this.tabPage1.Text = "GeoIP Locator";
      this.tabPage1.UseVisualStyleBackColor = true;
      // 
      // btnStopGeoIPLoc
      // 
      this.btnStopGeoIPLoc.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnStopGeoIPLoc.Location = new System.Drawing.Point(1804, 9);
      this.btnStopGeoIPLoc.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnStopGeoIPLoc.Name = "btnStopGeoIPLoc";
      this.btnStopGeoIPLoc.Size = new System.Drawing.Size(243, 35);
      this.btnStopGeoIPLoc.TabIndex = 2;
      this.btnStopGeoIPLoc.Text = "Stop GeoIP Locator";
      this.btnStopGeoIPLoc.UseVisualStyleBackColor = true;
      this.btnStopGeoIPLoc.Click += new System.EventHandler(this.btnStopGeoIPLoc_Click);
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.gvExecutionTimeMinAvMax);
      this.tabPage3.Controls.Add(this.rtbExecutionTimeMinAvMax);
      this.tabPage3.Location = new System.Drawing.Point(4, 29);
      this.tabPage3.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Size = new System.Drawing.Size(2023, 743);
      this.tabPage3.TabIndex = 2;
      this.tabPage3.Text = "Execution Time Min Av Max";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // gvExecutionTimeMinAvMax
      // 
      this.gvExecutionTimeMinAvMax.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvExecutionTimeMinAvMax.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvExecutionTimeMinAvMax.Location = new System.Drawing.Point(463, 0);
      this.gvExecutionTimeMinAvMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gvExecutionTimeMinAvMax.Name = "gvExecutionTimeMinAvMax";
      this.gvExecutionTimeMinAvMax.Size = new System.Drawing.Size(1560, 743);
      this.gvExecutionTimeMinAvMax.TabIndex = 1;
      // 
      // rtbExecutionTimeMinAvMax
      // 
      this.rtbExecutionTimeMinAvMax.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbExecutionTimeMinAvMax.Location = new System.Drawing.Point(0, 0);
      this.rtbExecutionTimeMinAvMax.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbExecutionTimeMinAvMax.Name = "rtbExecutionTimeMinAvMax";
      this.rtbExecutionTimeMinAvMax.Size = new System.Drawing.Size(463, 743);
      this.rtbExecutionTimeMinAvMax.TabIndex = 0;
      this.rtbExecutionTimeMinAvMax.Text = "";
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.gvExecutionTimeMoreThan10s);
      this.tabPage4.Controls.Add(this.rtbExecutionTimeMore10s);
      this.tabPage4.Location = new System.Drawing.Point(4, 29);
      this.tabPage4.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage4.Size = new System.Drawing.Size(2023, 743);
      this.tabPage4.TabIndex = 3;
      this.tabPage4.Text = "ExecutionTimeMore10s";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // gvExecutionTimeMoreThan10s
      // 
      this.gvExecutionTimeMoreThan10s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvExecutionTimeMoreThan10s.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvExecutionTimeMoreThan10s.Location = new System.Drawing.Point(396, 5);
      this.gvExecutionTimeMoreThan10s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gvExecutionTimeMoreThan10s.Name = "gvExecutionTimeMoreThan10s";
      this.gvExecutionTimeMoreThan10s.Size = new System.Drawing.Size(1623, 733);
      this.gvExecutionTimeMoreThan10s.TabIndex = 2;
      // 
      // rtbExecutionTimeMore10s
      // 
      this.rtbExecutionTimeMore10s.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbExecutionTimeMore10s.Location = new System.Drawing.Point(4, 5);
      this.rtbExecutionTimeMore10s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbExecutionTimeMore10s.Name = "rtbExecutionTimeMore10s";
      this.rtbExecutionTimeMore10s.Size = new System.Drawing.Size(392, 733);
      this.rtbExecutionTimeMore10s.TabIndex = 1;
      this.rtbExecutionTimeMore10s.Text = "";
      // 
      // tabPage5
      // 
      this.tabPage5.Controls.Add(this.gvExecutionTimeMore20s);
      this.tabPage5.Controls.Add(this.rtbExecutionTimeMore20s);
      this.tabPage5.Location = new System.Drawing.Point(4, 29);
      this.tabPage5.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage5.Name = "tabPage5";
      this.tabPage5.Size = new System.Drawing.Size(2023, 743);
      this.tabPage5.TabIndex = 4;
      this.tabPage5.Text = "ExecutionTimeMore20s";
      this.tabPage5.UseVisualStyleBackColor = true;
      // 
      // gvExecutionTimeMore20s
      // 
      this.gvExecutionTimeMore20s.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvExecutionTimeMore20s.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvExecutionTimeMore20s.Location = new System.Drawing.Point(337, 0);
      this.gvExecutionTimeMore20s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gvExecutionTimeMore20s.Name = "gvExecutionTimeMore20s";
      this.gvExecutionTimeMore20s.Size = new System.Drawing.Size(1686, 743);
      this.gvExecutionTimeMore20s.TabIndex = 3;
      // 
      // rtbExecutionTimeMore20s
      // 
      this.rtbExecutionTimeMore20s.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbExecutionTimeMore20s.Location = new System.Drawing.Point(0, 0);
      this.rtbExecutionTimeMore20s.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbExecutionTimeMore20s.Name = "rtbExecutionTimeMore20s";
      this.rtbExecutionTimeMore20s.Size = new System.Drawing.Size(337, 743);
      this.rtbExecutionTimeMore20s.TabIndex = 1;
      this.rtbExecutionTimeMore20s.Text = "";
      // 
      // tabPage6
      // 
      this.tabPage6.Controls.Add(this.m_chartHitsByExtention);
      this.tabPage6.Controls.Add(this.rtbHitsByExtention);
      this.tabPage6.Location = new System.Drawing.Point(4, 29);
      this.tabPage6.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage6.Name = "tabPage6";
      this.tabPage6.Size = new System.Drawing.Size(2023, 743);
      this.tabPage6.TabIndex = 5;
      this.tabPage6.Text = "Hits By Extention";
      this.tabPage6.UseVisualStyleBackColor = true;
      // 
      // m_chartHitsByExtention
      // 
      chartArea1.Name = "ChartArea1";
      this.m_chartHitsByExtention.ChartAreas.Add(chartArea1);
      this.m_chartHitsByExtention.Dock = System.Windows.Forms.DockStyle.Fill;
      legend1.Name = "Legend1";
      this.m_chartHitsByExtention.Legends.Add(legend1);
      this.m_chartHitsByExtention.Location = new System.Drawing.Point(338, 0);
      this.m_chartHitsByExtention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_chartHitsByExtention.Name = "m_chartHitsByExtention";
      series1.ChartArea = "ChartArea1";
      series1.Legend = "Legend1";
      series1.Name = "Series1";
      this.m_chartHitsByExtention.Series.Add(series1);
      this.m_chartHitsByExtention.Size = new System.Drawing.Size(1685, 743);
      this.m_chartHitsByExtention.TabIndex = 2;
      this.m_chartHitsByExtention.Text = "chart1";
      // 
      // rtbHitsByExtention
      // 
      this.rtbHitsByExtention.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbHitsByExtention.Location = new System.Drawing.Point(0, 0);
      this.rtbHitsByExtention.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbHitsByExtention.Name = "rtbHitsByExtention";
      this.rtbHitsByExtention.Size = new System.Drawing.Size(338, 743);
      this.rtbHitsByExtention.TabIndex = 1;
      this.rtbHitsByExtention.Text = "";
      // 
      // tabPage7
      // 
      this.tabPage7.Controls.Add(this.m_chartHitsByHour);
      this.tabPage7.Controls.Add(this.rtbHitsByHour);
      this.tabPage7.Location = new System.Drawing.Point(4, 29);
      this.tabPage7.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage7.Name = "tabPage7";
      this.tabPage7.Size = new System.Drawing.Size(2023, 743);
      this.tabPage7.TabIndex = 6;
      this.tabPage7.Text = "HitsByHour";
      this.tabPage7.UseVisualStyleBackColor = true;
      // 
      // m_chartHitsByHour
      // 
      chartArea2.Name = "ChartArea1";
      this.m_chartHitsByHour.ChartAreas.Add(chartArea2);
      this.m_chartHitsByHour.Dock = System.Windows.Forms.DockStyle.Fill;
      legend2.Name = "Legend1";
      this.m_chartHitsByHour.Legends.Add(legend2);
      this.m_chartHitsByHour.Location = new System.Drawing.Point(370, 0);
      this.m_chartHitsByHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_chartHitsByHour.Name = "m_chartHitsByHour";
      this.m_chartHitsByHour.Size = new System.Drawing.Size(1653, 743);
      this.m_chartHitsByHour.TabIndex = 2;
      this.m_chartHitsByHour.Text = "chart1";
      // 
      // rtbHitsByHour
      // 
      this.rtbHitsByHour.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbHitsByHour.Location = new System.Drawing.Point(0, 0);
      this.rtbHitsByHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbHitsByHour.Name = "rtbHitsByHour";
      this.rtbHitsByHour.Size = new System.Drawing.Size(370, 743);
      this.rtbHitsByHour.TabIndex = 1;
      this.rtbHitsByHour.Text = "";
      // 
      // tabPage8
      // 
      this.tabPage8.Controls.Add(this.gvHitsByIP);
      this.tabPage8.Controls.Add(this.rtbIPs);
      this.tabPage8.Location = new System.Drawing.Point(4, 29);
      this.tabPage8.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage8.Name = "tabPage8";
      this.tabPage8.Size = new System.Drawing.Size(2023, 743);
      this.tabPage8.TabIndex = 7;
      this.tabPage8.Text = "IPs";
      this.tabPage8.UseVisualStyleBackColor = true;
      // 
      // gvHitsByIP
      // 
      this.gvHitsByIP.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvHitsByIP.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvHitsByIP.Location = new System.Drawing.Point(373, 0);
      this.gvHitsByIP.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gvHitsByIP.Name = "gvHitsByIP";
      this.gvHitsByIP.Size = new System.Drawing.Size(1650, 743);
      this.gvHitsByIP.TabIndex = 2;
      // 
      // rtbIPs
      // 
      this.rtbIPs.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbIPs.Location = new System.Drawing.Point(0, 0);
      this.rtbIPs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbIPs.Name = "rtbIPs";
      this.rtbIPs.Size = new System.Drawing.Size(373, 743);
      this.rtbIPs.TabIndex = 1;
      this.rtbIPs.Text = "";
      // 
      // tbHitsByDateHour
      // 
      this.tbHitsByDateHour.Controls.Add(this.pnl_Chart);
      this.tbHitsByDateHour.Controls.Add(this.rtbHitsByDateHour);
      this.tbHitsByDateHour.Location = new System.Drawing.Point(4, 29);
      this.tbHitsByDateHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tbHitsByDateHour.Name = "tbHitsByDateHour";
      this.tbHitsByDateHour.Size = new System.Drawing.Size(2023, 743);
      this.tbHitsByDateHour.TabIndex = 21;
      this.tbHitsByDateHour.Text = "HitsByDateHour";
      this.tbHitsByDateHour.UseVisualStyleBackColor = true;
      // 
      // pnl_Chart
      // 
      this.pnl_Chart.AutoSize = true;
      this.pnl_Chart.Controls.Add(this.m_chartHitsByDateHour);
      this.pnl_Chart.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnl_Chart.Location = new System.Drawing.Point(370, 0);
      this.pnl_Chart.Name = "pnl_Chart";
      this.pnl_Chart.Size = new System.Drawing.Size(1653, 743);
      this.pnl_Chart.TabIndex = 4;
      // 
      // m_chartHitsByDateHour
      // 
      chartArea3.Name = "ChartArea1";
      this.m_chartHitsByDateHour.ChartAreas.Add(chartArea3);
      this.m_chartHitsByDateHour.Dock = System.Windows.Forms.DockStyle.Fill;
      legend3.Name = "Legend1";
      this.m_chartHitsByDateHour.Legends.Add(legend3);
      this.m_chartHitsByDateHour.Location = new System.Drawing.Point(0, 0);
      this.m_chartHitsByDateHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_chartHitsByDateHour.Name = "m_chartHitsByDateHour";
      this.m_chartHitsByDateHour.Size = new System.Drawing.Size(1653, 743);
      this.m_chartHitsByDateHour.TabIndex = 3;
      this.m_chartHitsByDateHour.Text = "chart1";
      // 
      // rtbHitsByDateHour
      // 
      this.rtbHitsByDateHour.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbHitsByDateHour.Location = new System.Drawing.Point(0, 0);
      this.rtbHitsByDateHour.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbHitsByDateHour.Name = "rtbHitsByDateHour";
      this.rtbHitsByDateHour.Size = new System.Drawing.Size(370, 743);
      this.rtbHitsByDateHour.TabIndex = 2;
      this.rtbHitsByDateHour.Text = "";
      // 
      // tabPage9
      // 
      this.tabPage9.Controls.Add(this.m_chartStatusCode);
      this.tabPage9.Controls.Add(this.rtbStatusCode);
      this.tabPage9.Location = new System.Drawing.Point(4, 29);
      this.tabPage9.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage9.Name = "tabPage9";
      this.tabPage9.Size = new System.Drawing.Size(2023, 743);
      this.tabPage9.TabIndex = 8;
      this.tabPage9.Text = "StatusCode";
      this.tabPage9.UseVisualStyleBackColor = true;
      // 
      // m_chartStatusCode
      // 
      chartArea4.Name = "ChartArea1";
      this.m_chartStatusCode.ChartAreas.Add(chartArea4);
      this.m_chartStatusCode.Dock = System.Windows.Forms.DockStyle.Fill;
      legend4.Name = "Legend1";
      this.m_chartStatusCode.Legends.Add(legend4);
      this.m_chartStatusCode.Location = new System.Drawing.Point(318, 0);
      this.m_chartStatusCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_chartStatusCode.Name = "m_chartStatusCode";
      series2.ChartArea = "ChartArea1";
      series2.Legend = "Legend1";
      series2.Name = "Series1";
      this.m_chartStatusCode.Series.Add(series2);
      this.m_chartStatusCode.Size = new System.Drawing.Size(1705, 743);
      this.m_chartStatusCode.TabIndex = 2;
      this.m_chartStatusCode.Text = "chart1";
      // 
      // rtbStatusCode
      // 
      this.rtbStatusCode.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbStatusCode.Location = new System.Drawing.Point(0, 0);
      this.rtbStatusCode.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbStatusCode.Name = "rtbStatusCode";
      this.rtbStatusCode.Size = new System.Drawing.Size(318, 743);
      this.rtbStatusCode.TabIndex = 1;
      this.rtbStatusCode.Text = "";
      // 
      // tabPage10
      // 
      this.tabPage10.Controls.Add(this.rtbStatusCodeWithOutStatic);
      this.tabPage10.Location = new System.Drawing.Point(4, 29);
      this.tabPage10.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage10.Name = "tabPage10";
      this.tabPage10.Size = new System.Drawing.Size(2023, 743);
      this.tabPage10.TabIndex = 9;
      this.tabPage10.Text = "StatusCodeWithOutStatic";
      this.tabPage10.UseVisualStyleBackColor = true;
      // 
      // rtbStatusCodeWithOutStatic
      // 
      this.rtbStatusCodeWithOutStatic.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbStatusCodeWithOutStatic.Location = new System.Drawing.Point(0, 0);
      this.rtbStatusCodeWithOutStatic.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbStatusCodeWithOutStatic.Name = "rtbStatusCodeWithOutStatic";
      this.rtbStatusCodeWithOutStatic.Size = new System.Drawing.Size(2023, 743);
      this.rtbStatusCodeWithOutStatic.TabIndex = 1;
      this.rtbStatusCodeWithOutStatic.Text = "";
      // 
      // tabPage11
      // 
      this.tabPage11.Controls.Add(this.rtbTop1000ExecutionTime);
      this.tabPage11.Location = new System.Drawing.Point(4, 29);
      this.tabPage11.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage11.Name = "tabPage11";
      this.tabPage11.Size = new System.Drawing.Size(2023, 743);
      this.tabPage11.TabIndex = 10;
      this.tabPage11.Text = "Top1000ExecutionTimeMaximum";
      this.tabPage11.UseVisualStyleBackColor = true;
      // 
      // rtbTop1000ExecutionTime
      // 
      this.rtbTop1000ExecutionTime.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbTop1000ExecutionTime.Location = new System.Drawing.Point(0, 0);
      this.rtbTop1000ExecutionTime.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbTop1000ExecutionTime.Name = "rtbTop1000ExecutionTime";
      this.rtbTop1000ExecutionTime.Size = new System.Drawing.Size(2023, 743);
      this.rtbTop1000ExecutionTime.TabIndex = 1;
      this.rtbTop1000ExecutionTime.Text = "";
      // 
      // tabPage12
      // 
      this.tabPage12.Controls.Add(this.rtbUniqueIPs);
      this.tabPage12.Location = new System.Drawing.Point(4, 29);
      this.tabPage12.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage12.Name = "tabPage12";
      this.tabPage12.Size = new System.Drawing.Size(2023, 743);
      this.tabPage12.TabIndex = 11;
      this.tabPage12.Text = "UniqueIPs";
      this.tabPage12.UseVisualStyleBackColor = true;
      // 
      // rtbUniqueIPs
      // 
      this.rtbUniqueIPs.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbUniqueIPs.Location = new System.Drawing.Point(0, 0);
      this.rtbUniqueIPs.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbUniqueIPs.Name = "rtbUniqueIPs";
      this.rtbUniqueIPs.Size = new System.Drawing.Size(2023, 743);
      this.rtbUniqueIPs.TabIndex = 1;
      this.rtbUniqueIPs.Text = "";
      // 
      // tabPage13
      // 
      this.tabPage13.Controls.Add(this.gvUrl404);
      this.tabPage13.Controls.Add(this.rtbUrl404_);
      this.tabPage13.Location = new System.Drawing.Point(4, 29);
      this.tabPage13.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage13.Name = "tabPage13";
      this.tabPage13.Size = new System.Drawing.Size(2023, 743);
      this.tabPage13.TabIndex = 12;
      this.tabPage13.Text = "Url404";
      this.tabPage13.UseVisualStyleBackColor = true;
      // 
      // gvUrl404
      // 
      this.gvUrl404.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.gvUrl404.Dock = System.Windows.Forms.DockStyle.Fill;
      this.gvUrl404.Location = new System.Drawing.Point(384, 0);
      this.gvUrl404.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.gvUrl404.Name = "gvUrl404";
      this.gvUrl404.Size = new System.Drawing.Size(1639, 743);
      this.gvUrl404.TabIndex = 3;
      // 
      // rtbUrl404_
      // 
      this.rtbUrl404_.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbUrl404_.Location = new System.Drawing.Point(0, 0);
      this.rtbUrl404_.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbUrl404_.Name = "rtbUrl404_";
      this.rtbUrl404_.Size = new System.Drawing.Size(384, 743);
      this.rtbUrl404_.TabIndex = 2;
      this.rtbUrl404_.Text = "";
      // 
      // tabPage14
      // 
      this.tabPage14.Controls.Add(this.rtbUrl500);
      this.tabPage14.Location = new System.Drawing.Point(4, 29);
      this.tabPage14.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage14.Name = "tabPage14";
      this.tabPage14.Size = new System.Drawing.Size(2023, 743);
      this.tabPage14.TabIndex = 13;
      this.tabPage14.Text = "Url500";
      this.tabPage14.UseVisualStyleBackColor = true;
      // 
      // rtbUrl500
      // 
      this.rtbUrl500.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbUrl500.Location = new System.Drawing.Point(0, 0);
      this.rtbUrl500.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbUrl500.Name = "rtbUrl500";
      this.rtbUrl500.Size = new System.Drawing.Size(2023, 743);
      this.rtbUrl500.TabIndex = 1;
      this.rtbUrl500.Text = "";
      // 
      // tabPage15
      // 
      this.tabPage15.Controls.Add(this.rtbUrl500Full);
      this.tabPage15.Location = new System.Drawing.Point(4, 29);
      this.tabPage15.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage15.Name = "tabPage15";
      this.tabPage15.Size = new System.Drawing.Size(2023, 743);
      this.tabPage15.TabIndex = 14;
      this.tabPage15.Text = "Url500Full";
      this.tabPage15.UseVisualStyleBackColor = true;
      // 
      // rtbUrl500Full
      // 
      this.rtbUrl500Full.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbUrl500Full.Location = new System.Drawing.Point(0, 0);
      this.rtbUrl500Full.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbUrl500Full.Name = "rtbUrl500Full";
      this.rtbUrl500Full.Size = new System.Drawing.Size(2023, 743);
      this.rtbUrl500Full.TabIndex = 1;
      this.rtbUrl500Full.Text = "";
      // 
      // tabPage16
      // 
      this.tabPage16.Controls.Add(this.rtbUserAgent);
      this.tabPage16.Location = new System.Drawing.Point(4, 29);
      this.tabPage16.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage16.Name = "tabPage16";
      this.tabPage16.Size = new System.Drawing.Size(2023, 743);
      this.tabPage16.TabIndex = 15;
      this.tabPage16.Text = "UserAgent";
      this.tabPage16.UseVisualStyleBackColor = true;
      // 
      // rtbUserAgent
      // 
      this.rtbUserAgent.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbUserAgent.Location = new System.Drawing.Point(0, 0);
      this.rtbUserAgent.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbUserAgent.Name = "rtbUserAgent";
      this.rtbUserAgent.Size = new System.Drawing.Size(2023, 743);
      this.rtbUserAgent.TabIndex = 1;
      this.rtbUserAgent.Text = "";
      // 
      // tabPage17
      // 
      this.tabPage17.Controls.Add(this.rtbUserAgentFirefox);
      this.tabPage17.Location = new System.Drawing.Point(4, 29);
      this.tabPage17.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage17.Name = "tabPage17";
      this.tabPage17.Size = new System.Drawing.Size(2023, 743);
      this.tabPage17.TabIndex = 16;
      this.tabPage17.Text = "UserAgentFireFox";
      this.tabPage17.UseVisualStyleBackColor = true;
      // 
      // rtbUserAgentFirefox
      // 
      this.rtbUserAgentFirefox.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbUserAgentFirefox.Location = new System.Drawing.Point(0, 0);
      this.rtbUserAgentFirefox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbUserAgentFirefox.Name = "rtbUserAgentFirefox";
      this.rtbUserAgentFirefox.Size = new System.Drawing.Size(2023, 743);
      this.rtbUserAgentFirefox.TabIndex = 1;
      this.rtbUserAgentFirefox.Text = "";
      // 
      // tabPage18
      // 
      this.tabPage18.Controls.Add(this.rtbUserAgentFull);
      this.tabPage18.Location = new System.Drawing.Point(4, 29);
      this.tabPage18.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage18.Name = "tabPage18";
      this.tabPage18.Size = new System.Drawing.Size(2023, 743);
      this.tabPage18.TabIndex = 17;
      this.tabPage18.Text = "UserAgentFull";
      this.tabPage18.UseVisualStyleBackColor = true;
      // 
      // rtbUserAgentFull
      // 
      this.rtbUserAgentFull.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbUserAgentFull.Location = new System.Drawing.Point(0, 0);
      this.rtbUserAgentFull.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbUserAgentFull.Name = "rtbUserAgentFull";
      this.rtbUserAgentFull.Size = new System.Drawing.Size(2023, 743);
      this.rtbUserAgentFull.TabIndex = 1;
      this.rtbUserAgentFull.Text = "";
      // 
      // tabPage19
      // 
      this.tabPage19.Controls.Add(this.m_chartUserAgentIE);
      this.tabPage19.Controls.Add(this.rtbUserAgentIE);
      this.tabPage19.Location = new System.Drawing.Point(4, 29);
      this.tabPage19.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage19.Name = "tabPage19";
      this.tabPage19.Size = new System.Drawing.Size(2023, 743);
      this.tabPage19.TabIndex = 18;
      this.tabPage19.Text = "UserAgentIE";
      this.tabPage19.UseVisualStyleBackColor = true;
      // 
      // m_chartUserAgentIE
      // 
      chartArea5.Name = "ChartArea1";
      this.m_chartUserAgentIE.ChartAreas.Add(chartArea5);
      this.m_chartUserAgentIE.Dock = System.Windows.Forms.DockStyle.Fill;
      legend5.Name = "Legend1";
      this.m_chartUserAgentIE.Legends.Add(legend5);
      this.m_chartUserAgentIE.Location = new System.Drawing.Point(388, 0);
      this.m_chartUserAgentIE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_chartUserAgentIE.Name = "m_chartUserAgentIE";
      series3.ChartArea = "ChartArea1";
      series3.Legend = "Legend1";
      series3.Name = "Series1";
      this.m_chartUserAgentIE.Series.Add(series3);
      this.m_chartUserAgentIE.Size = new System.Drawing.Size(1635, 743);
      this.m_chartUserAgentIE.TabIndex = 2;
      this.m_chartUserAgentIE.Text = "chart1";
      // 
      // rtbUserAgentIE
      // 
      this.rtbUserAgentIE.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbUserAgentIE.Location = new System.Drawing.Point(0, 0);
      this.rtbUserAgentIE.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbUserAgentIE.Name = "rtbUserAgentIE";
      this.rtbUserAgentIE.Size = new System.Drawing.Size(388, 743);
      this.rtbUserAgentIE.TabIndex = 1;
      this.rtbUserAgentIE.Text = "";
      // 
      // tabPage20
      // 
      this.tabPage20.Controls.Add(this.rtbUserAgentOpera);
      this.tabPage20.Location = new System.Drawing.Point(4, 29);
      this.tabPage20.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage20.Name = "tabPage20";
      this.tabPage20.Size = new System.Drawing.Size(2023, 743);
      this.tabPage20.TabIndex = 19;
      this.tabPage20.Text = "UserAgentOpera";
      this.tabPage20.UseVisualStyleBackColor = true;
      // 
      // rtbUserAgentOpera
      // 
      this.rtbUserAgentOpera.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtbUserAgentOpera.Location = new System.Drawing.Point(0, 0);
      this.rtbUserAgentOpera.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbUserAgentOpera.Name = "rtbUserAgentOpera";
      this.rtbUserAgentOpera.Size = new System.Drawing.Size(2023, 743);
      this.rtbUserAgentOpera.TabIndex = 1;
      this.rtbUserAgentOpera.Text = "";
      // 
      // tabPage21
      // 
      this.tabPage21.Controls.Add(this.m_chartFindOS);
      this.tabPage21.Controls.Add(this.rtbFindOS);
      this.tabPage21.Location = new System.Drawing.Point(4, 29);
      this.tabPage21.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tabPage21.Name = "tabPage21";
      this.tabPage21.Size = new System.Drawing.Size(2023, 743);
      this.tabPage21.TabIndex = 20;
      this.tabPage21.Text = "Operating System(s) / Hits";
      this.tabPage21.UseVisualStyleBackColor = true;
      // 
      // m_chartFindOS
      // 
      chartArea6.Name = "ChartArea1";
      this.m_chartFindOS.ChartAreas.Add(chartArea6);
      this.m_chartFindOS.Dock = System.Windows.Forms.DockStyle.Fill;
      legend6.Name = "Legend1";
      this.m_chartFindOS.Legends.Add(legend6);
      this.m_chartFindOS.Location = new System.Drawing.Point(553, 0);
      this.m_chartFindOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.m_chartFindOS.Name = "m_chartFindOS";
      series4.ChartArea = "ChartArea1";
      series4.Legend = "Legend1";
      series4.Name = "Series1";
      this.m_chartFindOS.Series.Add(series4);
      this.m_chartFindOS.Size = new System.Drawing.Size(1470, 743);
      this.m_chartFindOS.TabIndex = 3;
      this.m_chartFindOS.Text = "chart1";
      // 
      // rtbFindOS
      // 
      this.rtbFindOS.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtbFindOS.Location = new System.Drawing.Point(0, 0);
      this.rtbFindOS.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtbFindOS.Name = "rtbFindOS";
      this.rtbFindOS.Size = new System.Drawing.Size(553, 743);
      this.rtbFindOS.TabIndex = 1;
      this.rtbFindOS.Text = "";
      // 
      // tbNoOfRequestsByUser
      // 
      this.tbNoOfRequestsByUser.Controls.Add(this.dgvNoRequestsByUser);
      this.tbNoOfRequestsByUser.Controls.Add(this.rtNoRequestsByUser);
      this.tbNoOfRequestsByUser.Location = new System.Drawing.Point(4, 29);
      this.tbNoOfRequestsByUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tbNoOfRequestsByUser.Name = "tbNoOfRequestsByUser";
      this.tbNoOfRequestsByUser.Padding = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.tbNoOfRequestsByUser.Size = new System.Drawing.Size(2023, 743);
      this.tbNoOfRequestsByUser.TabIndex = 22;
      this.tbNoOfRequestsByUser.Text = "No Requests by User";
      this.tbNoOfRequestsByUser.UseVisualStyleBackColor = true;
      // 
      // dgvNoRequestsByUser
      // 
      this.dgvNoRequestsByUser.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
      this.dgvNoRequestsByUser.Dock = System.Windows.Forms.DockStyle.Fill;
      this.dgvNoRequestsByUser.Location = new System.Drawing.Point(388, 5);
      this.dgvNoRequestsByUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.dgvNoRequestsByUser.Name = "dgvNoRequestsByUser";
      this.dgvNoRequestsByUser.Size = new System.Drawing.Size(1631, 733);
      this.dgvNoRequestsByUser.TabIndex = 5;
      // 
      // rtNoRequestsByUser
      // 
      this.rtNoRequestsByUser.Dock = System.Windows.Forms.DockStyle.Left;
      this.rtNoRequestsByUser.Location = new System.Drawing.Point(4, 5);
      this.rtNoRequestsByUser.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.rtNoRequestsByUser.Name = "rtNoRequestsByUser";
      this.rtNoRequestsByUser.Size = new System.Drawing.Size(384, 733);
      this.rtNoRequestsByUser.TabIndex = 4;
      this.rtNoRequestsByUser.Text = "";
      // 
      // tpVarious
      // 
      this.tpVarious.Controls.Add(this.chrtExecutionTimes);
      this.tpVarious.Controls.Add(this.btnTimeExecution);
      this.tpVarious.Location = new System.Drawing.Point(4, 29);
      this.tpVarious.Name = "tpVarious";
      this.tpVarious.Padding = new System.Windows.Forms.Padding(3);
      this.tpVarious.Size = new System.Drawing.Size(2023, 743);
      this.tpVarious.TabIndex = 23;
      this.tpVarious.Text = "Various";
      this.tpVarious.UseVisualStyleBackColor = true;
      // 
      // chrtExecutionTimes
      // 
      chartArea7.Name = "ChartArea1";
      this.chrtExecutionTimes.ChartAreas.Add(chartArea7);
      legend7.Name = "Legend1";
      this.chrtExecutionTimes.Legends.Add(legend7);
      this.chrtExecutionTimes.Location = new System.Drawing.Point(27, 99);
      this.chrtExecutionTimes.Name = "chrtExecutionTimes";
      series5.ChartArea = "ChartArea1";
      series5.Legend = "Legend1";
      series5.Name = "Series1";
      this.chrtExecutionTimes.Series.Add(series5);
      this.chrtExecutionTimes.Size = new System.Drawing.Size(1864, 357);
      this.chrtExecutionTimes.TabIndex = 1;
      this.chrtExecutionTimes.Text = "chart1";
      // 
      // btnTimeExecution
      // 
      this.btnTimeExecution.Location = new System.Drawing.Point(27, 27);
      this.btnTimeExecution.Name = "btnTimeExecution";
      this.btnTimeExecution.Size = new System.Drawing.Size(344, 66);
      this.btnTimeExecution.TabIndex = 0;
      this.btnTimeExecution.Text = "button2";
      this.btnTimeExecution.UseVisualStyleBackColor = true;
      this.btnTimeExecution.Click += new System.EventHandler(this.btnTimeExecution_Click);
      // 
      // pnlBottom
      // 
      this.pnlBottom.Controls.Add(this.tabControl1);
      this.pnlBottom.Controls.Add(this._statusStrip);
      this.pnlBottom.Dock = System.Windows.Forms.DockStyle.Fill;
      this.pnlBottom.Location = new System.Drawing.Point(0, 74);
      this.pnlBottom.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.pnlBottom.Name = "pnlBottom";
      this.pnlBottom.Size = new System.Drawing.Size(2031, 806);
      this.pnlBottom.TabIndex = 5;
      // 
      // _statusStrip
      // 
      this._statusStrip.ImageScalingSize = new System.Drawing.Size(24, 24);
      this._statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this._toolStripProgressBar,
            this._toolStripStatusLabel_Script});
      this._statusStrip.Location = new System.Drawing.Point(0, 776);
      this._statusStrip.Name = "_statusStrip";
      this._statusStrip.Size = new System.Drawing.Size(2031, 30);
      this._statusStrip.TabIndex = 10;
      this._statusStrip.Text = "statusStrip1";
      // 
      // _toolStripProgressBar
      // 
      this._toolStripProgressBar.Name = "_toolStripProgressBar";
      this._toolStripProgressBar.Size = new System.Drawing.Size(200, 24);
      // 
      // _toolStripStatusLabel_Script
      // 
      this._toolStripStatusLabel_Script.Name = "_toolStripStatusLabel_Script";
      this._toolStripStatusLabel_Script.Size = new System.Drawing.Size(179, 25);
      this._toolStripStatusLabel_Script.Text = "toolStripStatusLabel1";
      // 
      // pnlTop
      // 
      this.pnlTop.Controls.Add(this.btnCustomExecution);
      this.pnlTop.Controls.Add(this.btnAbout);
      this.pnlTop.Controls.Add(this.btnStartProcess);
      this.pnlTop.Controls.Add(this.btnLoadLogFile);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(2031, 74);
      this.pnlTop.TabIndex = 6;
      // 
      // btnCustomExecution
      // 
      this.btnCustomExecution.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnCustomExecution.Location = new System.Drawing.Point(1689, 18);
      this.btnCustomExecution.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnCustomExecution.Name = "btnCustomExecution";
      this.btnCustomExecution.Size = new System.Drawing.Size(202, 35);
      this.btnCustomExecution.TabIndex = 8;
      this.btnCustomExecution.Text = "Custom Execution";
      this.btnCustomExecution.UseVisualStyleBackColor = true;
      this.btnCustomExecution.Click += new System.EventHandler(this.btnCustomExecution_Click);
      // 
      // btnAbout
      // 
      this.btnAbout.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAbout.Location = new System.Drawing.Point(1900, 18);
      this.btnAbout.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.btnAbout.Name = "btnAbout";
      this.btnAbout.Size = new System.Drawing.Size(112, 35);
      this.btnAbout.TabIndex = 7;
      this.btnAbout.Text = "About";
      this.btnAbout.UseVisualStyleBackColor = true;
      this.btnAbout.Click += new System.EventHandler(this.btnAbout_Click);
      // 
      // _panelTop
      // 
      this._panelTop.Controls.Add(this.btnUrlExec);
      this._panelTop.Dock = System.Windows.Forms.DockStyle.Top;
      this._panelTop.Location = new System.Drawing.Point(476, 5);
      this._panelTop.Name = "_panelTop";
      this._panelTop.Size = new System.Drawing.Size(1543, 46);
      this._panelTop.TabIndex = 3;
      // 
      // MainDlg
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(2031, 880);
      this.Controls.Add(this.pnlBottom);
      this.Controls.Add(this.pnlTop);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
      this.Name = "MainDlg";
      this.Text = "IIS Logparser UI (v0.8)";
      this.tabControl1.ResumeLayout(false);
      this.tabPage2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvAveragaExecTime)).EndInit();
      this.tabPage1.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvExecutionTimeMinAvMax)).EndInit();
      this.tabPage4.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvExecutionTimeMoreThan10s)).EndInit();
      this.tabPage5.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvExecutionTimeMore20s)).EndInit();
      this.tabPage6.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_chartHitsByExtention)).EndInit();
      this.tabPage7.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_chartHitsByHour)).EndInit();
      this.tabPage8.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvHitsByIP)).EndInit();
      this.tbHitsByDateHour.ResumeLayout(false);
      this.tbHitsByDateHour.PerformLayout();
      this.pnl_Chart.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_chartHitsByDateHour)).EndInit();
      this.tabPage9.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_chartStatusCode)).EndInit();
      this.tabPage10.ResumeLayout(false);
      this.tabPage11.ResumeLayout(false);
      this.tabPage12.ResumeLayout(false);
      this.tabPage13.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.gvUrl404)).EndInit();
      this.tabPage14.ResumeLayout(false);
      this.tabPage15.ResumeLayout(false);
      this.tabPage16.ResumeLayout(false);
      this.tabPage17.ResumeLayout(false);
      this.tabPage18.ResumeLayout(false);
      this.tabPage19.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_chartUserAgentIE)).EndInit();
      this.tabPage20.ResumeLayout(false);
      this.tabPage21.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_chartFindOS)).EndInit();
      this.tbNoOfRequestsByUser.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.dgvNoRequestsByUser)).EndInit();
      this.tpVarious.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.chrtExecutionTimes)).EndInit();
      this.pnlBottom.ResumeLayout(false);
      this.pnlBottom.PerformLayout();
      this._statusStrip.ResumeLayout(false);
      this._statusStrip.PerformLayout();
      this.pnlTop.ResumeLayout(false);
      this._panelTop.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Button button1;
    private System.Windows.Forms.ListView lstVGeoIPResults;
    private System.Windows.Forms.ColumnHeader columnHeader1;
    private System.Windows.Forms.ColumnHeader columnHeader2;
    private System.Windows.Forms.ColumnHeader columnHeader3;
    private System.ComponentModel.BackgroundWorker m_BWorker;
    private System.Windows.Forms.ColumnHeader columnHeader4;
    private System.Windows.Forms.Button btnLoadLogFile;
    private System.Windows.Forms.Button btnStartProcess;
    private System.Windows.Forms.TabControl tabControl1;
    private System.Windows.Forms.TabPage tabPage1;
    private System.Windows.Forms.TabPage tabPage2;
    private System.Windows.Forms.Panel pnlBottom;
    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.RichTextBox rtbAvgExecTime;
    private System.Windows.Forms.TabPage tabPage3;
    private System.Windows.Forms.RichTextBox rtbExecutionTimeMinAvMax;
    private System.Windows.Forms.TabPage tabPage4;
    private System.Windows.Forms.RichTextBox rtbExecutionTimeMore10s;
    private System.Windows.Forms.TabPage tabPage5;
    private System.Windows.Forms.RichTextBox rtbExecutionTimeMore20s;
    private System.Windows.Forms.TabPage tabPage6;
    private System.Windows.Forms.RichTextBox rtbHitsByExtention;
    private System.Windows.Forms.TabPage tabPage7;
    private System.Windows.Forms.RichTextBox rtbHitsByHour;
    private System.Windows.Forms.TabPage tabPage8;
    private System.Windows.Forms.RichTextBox rtbIPs;
    private System.Windows.Forms.TabPage tabPage9;
    private System.Windows.Forms.RichTextBox rtbStatusCode;
    private System.Windows.Forms.TabPage tabPage10;
    private System.Windows.Forms.RichTextBox rtbStatusCodeWithOutStatic;
    private System.Windows.Forms.TabPage tabPage11;
    private System.Windows.Forms.RichTextBox rtbTop1000ExecutionTime;
    private System.Windows.Forms.TabPage tabPage12;
    private System.Windows.Forms.RichTextBox rtbUniqueIPs;
    private System.Windows.Forms.TabPage tabPage13;
    private System.Windows.Forms.RichTextBox rtbUrl404_;
    private System.Windows.Forms.TabPage tabPage14;
    private System.Windows.Forms.RichTextBox rtbUrl500;
    private System.Windows.Forms.TabPage tabPage15;
    private System.Windows.Forms.RichTextBox rtbUrl500Full;
    private System.Windows.Forms.TabPage tabPage16;
    private System.Windows.Forms.RichTextBox rtbUserAgent;
    private System.Windows.Forms.TabPage tabPage17;
    private System.Windows.Forms.RichTextBox rtbUserAgentFirefox;
    private System.Windows.Forms.TabPage tabPage18;
    private System.Windows.Forms.RichTextBox rtbUserAgentFull;
    private System.Windows.Forms.TabPage tabPage19;
    private System.Windows.Forms.RichTextBox rtbUserAgentIE;
    private System.Windows.Forms.TabPage tabPage20;
    private System.Windows.Forms.RichTextBox rtbUserAgentOpera;
    private System.Windows.Forms.Button btnStopGeoIPLoc;
    private System.ComponentModel.BackgroundWorker m_bwParseLog;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chartHitsByHour;
    private System.Windows.Forms.DataGridView gvAveragaExecTime;
    private System.Windows.Forms.DataGridView gvExecutionTimeMoreThan10s;
    private System.Windows.Forms.DataGridView gvExecutionTimeMore20s;
    private System.Windows.Forms.DataGridView gvHitsByIP;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chartUserAgentIE;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chartStatusCode;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chartHitsByExtention;
    private System.Windows.Forms.DataGridView gvExecutionTimeMinAvMax;
    private System.Windows.Forms.DataGridView gvUrl404;
    private System.Windows.Forms.TabPage tabPage21;
    private System.Windows.Forms.RichTextBox rtbFindOS;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chartFindOS;
    private System.Windows.Forms.Button btnAbout;
    private System.Windows.Forms.TabPage tbHitsByDateHour;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chartHitsByDateHour;
    private System.Windows.Forms.RichTextBox rtbHitsByDateHour;
    private System.Windows.Forms.Button btnCustomExecution;
    private System.Windows.Forms.TabPage tbNoOfRequestsByUser;
    private System.Windows.Forms.DataGridView dgvNoRequestsByUser;
    private System.Windows.Forms.RichTextBox rtNoRequestsByUser;
    private System.Windows.Forms.Panel pnl_Chart;
    private System.Windows.Forms.TabPage tpVarious;
    private System.Windows.Forms.Button btnTimeExecution;
    private System.Windows.Forms.DataVisualization.Charting.Chart chrtExecutionTimes;
    private System.Windows.Forms.Button btnUrlExec;
    private System.Windows.Forms.StatusStrip _statusStrip;
    private System.Windows.Forms.ToolStripProgressBar _toolStripProgressBar;
    private System.Windows.Forms.ToolStripStatusLabel _toolStripStatusLabel_Script;
    private System.Windows.Forms.Panel _panelTop;
  }
}

