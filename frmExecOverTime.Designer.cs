namespace IISLogParser
{
  partial class frmExecOverTime
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
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea5 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend5 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series5 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea6 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend6 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series6 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea7 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend7 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series7 = new System.Windows.Forms.DataVisualization.Charting.Series();
      System.Windows.Forms.DataVisualization.Charting.ChartArea chartArea8 = new System.Windows.Forms.DataVisualization.Charting.ChartArea();
      System.Windows.Forms.DataVisualization.Charting.Legend legend8 = new System.Windows.Forms.DataVisualization.Charting.Legend();
      System.Windows.Forms.DataVisualization.Charting.Series series8 = new System.Windows.Forms.DataVisualization.Charting.Series();
      this.panel1 = new System.Windows.Forms.Panel();
      this.label2 = new System.Windows.Forms.Label();
      this.label1 = new System.Windows.Forms.Label();
      this.btnExecute = new System.Windows.Forms.Button();
      this.txtUri = new System.Windows.Forms.TextBox();
      this.m_chartExec = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.m_chartHits = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.m_chartExec2 = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.grpChart3 = new System.Windows.Forms.GroupBox();
      this.grp = new System.Windows.Forms.GroupBox();
      this.grpChart1 = new System.Windows.Forms.GroupBox();
      this.grp_HitsError = new System.Windows.Forms.GroupBox();
      this.m_chart_hitsError = new System.Windows.Forms.DataVisualization.Charting.Chart();
      this.panel1.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartExec)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartHits)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartExec2)).BeginInit();
      this.grpChart3.SuspendLayout();
      this.grp.SuspendLayout();
      this.grpChart1.SuspendLayout();
      this.grp_HitsError.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_chart_hitsError)).BeginInit();
      this.SuspendLayout();
      // 
      // panel1
      // 
      this.panel1.Controls.Add(this.label2);
      this.panel1.Controls.Add(this.label1);
      this.panel1.Controls.Add(this.btnExecute);
      this.panel1.Controls.Add(this.txtUri);
      this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
      this.panel1.Location = new System.Drawing.Point(0, 0);
      this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.panel1.Name = "panel1";
      this.panel1.Size = new System.Drawing.Size(1145, 40);
      this.panel1.TabIndex = 0;
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Location = new System.Drawing.Point(973, 14);
      this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(76, 13);
      this.label2.TabIndex = 3;
      this.label2.Text = "Time is in UTC";
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Location = new System.Drawing.Point(9, 11);
      this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(26, 13);
      this.label1.TabIndex = 2;
      this.label1.Text = "URI";
      // 
      // btnExecute
      // 
      this.btnExecute.Location = new System.Drawing.Point(402, 6);
      this.btnExecute.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(114, 21);
      this.btnExecute.TabIndex = 1;
      this.btnExecute.Text = "Show";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // txtUri
      // 
      this.txtUri.Location = new System.Drawing.Point(38, 8);
      this.txtUri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.txtUri.Name = "txtUri";
      this.txtUri.Size = new System.Drawing.Size(346, 20);
      this.txtUri.TabIndex = 0;
      // 
      // m_chartExec
      // 
      chartArea5.Name = "ChartArea1";
      this.m_chartExec.ChartAreas.Add(chartArea5);
      this.m_chartExec.Dock = System.Windows.Forms.DockStyle.Fill;
      legend5.Name = "Legend1";
      this.m_chartExec.Legends.Add(legend5);
      this.m_chartExec.Location = new System.Drawing.Point(2, 15);
      this.m_chartExec.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.m_chartExec.Name = "m_chartExec";
      series5.ChartArea = "ChartArea1";
      series5.Legend = "Legend1";
      series5.Name = "Series1";
      this.m_chartExec.Series.Add(series5);
      this.m_chartExec.Size = new System.Drawing.Size(1141, 190);
      this.m_chartExec.TabIndex = 1;
      this.m_chartExec.Text = "chart1";
      // 
      // m_chartHits
      // 
      chartArea6.Name = "ChartArea1";
      this.m_chartHits.ChartAreas.Add(chartArea6);
      this.m_chartHits.Dock = System.Windows.Forms.DockStyle.Fill;
      legend6.Name = "Legend1";
      this.m_chartHits.Legends.Add(legend6);
      this.m_chartHits.Location = new System.Drawing.Point(2, 15);
      this.m_chartHits.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.m_chartHits.Name = "m_chartHits";
      series6.ChartArea = "ChartArea1";
      series6.Legend = "Legend1";
      series6.Name = "Series1";
      this.m_chartHits.Series.Add(series6);
      this.m_chartHits.Size = new System.Drawing.Size(1141, 190);
      this.m_chartHits.TabIndex = 2;
      this.m_chartHits.Text = "chart1";
      // 
      // m_chartExec2
      // 
      chartArea7.Name = "ChartArea1";
      this.m_chartExec2.ChartAreas.Add(chartArea7);
      this.m_chartExec2.Dock = System.Windows.Forms.DockStyle.Fill;
      legend7.Name = "Legend1";
      this.m_chartExec2.Legends.Add(legend7);
      this.m_chartExec2.Location = new System.Drawing.Point(2, 15);
      this.m_chartExec2.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.m_chartExec2.Name = "m_chartExec2";
      series7.ChartArea = "ChartArea1";
      series7.Legend = "Legend1";
      series7.Name = "Series1";
      this.m_chartExec2.Series.Add(series7);
      this.m_chartExec2.Size = new System.Drawing.Size(1141, 157);
      this.m_chartExec2.TabIndex = 3;
      this.m_chartExec2.Text = "chart1";
      // 
      // grpChart3
      // 
      this.grpChart3.Controls.Add(this.m_chartExec2);
      this.grpChart3.Dock = System.Windows.Forms.DockStyle.Top;
      this.grpChart3.Location = new System.Drawing.Point(0, 454);
      this.grpChart3.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grpChart3.Name = "grpChart3";
      this.grpChart3.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grpChart3.Size = new System.Drawing.Size(1145, 174);
      this.grpChart3.TabIndex = 4;
      this.grpChart3.TabStop = false;
      this.grpChart3.Text = "Exec Time (ms)";
      // 
      // grp
      // 
      this.grp.Controls.Add(this.m_chartHits);
      this.grp.Dock = System.Windows.Forms.DockStyle.Top;
      this.grp.Location = new System.Drawing.Point(0, 40);
      this.grp.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grp.Name = "grp";
      this.grp.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grp.Size = new System.Drawing.Size(1145, 207);
      this.grp.TabIndex = 5;
      this.grp.TabStop = false;
      this.grp.Text = "No of Hits (Avg every 5m)";
      // 
      // grpChart1
      // 
      this.grpChart1.Controls.Add(this.m_chartExec);
      this.grpChart1.Dock = System.Windows.Forms.DockStyle.Top;
      this.grpChart1.Location = new System.Drawing.Point(0, 247);
      this.grpChart1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grpChart1.Name = "grpChart1";
      this.grpChart1.Padding = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.grpChart1.Size = new System.Drawing.Size(1145, 207);
      this.grpChart1.TabIndex = 6;
      this.grpChart1.TabStop = false;
      this.grpChart1.Text = "Avg exec time every 5mins (ms)";
      // 
      // grp_HitsError
      // 
      this.grp_HitsError.Controls.Add(this.m_chart_hitsError);
      this.grp_HitsError.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grp_HitsError.Location = new System.Drawing.Point(0, 628);
      this.grp_HitsError.Margin = new System.Windows.Forms.Padding(2);
      this.grp_HitsError.Name = "grp_HitsError";
      this.grp_HitsError.Padding = new System.Windows.Forms.Padding(2);
      this.grp_HitsError.Size = new System.Drawing.Size(1145, 245);
      this.grp_HitsError.TabIndex = 5;
      this.grp_HitsError.TabStop = false;
      this.grp_HitsError.Text = "Hits Error (http status <> 200)";
      // 
      // m_chart_hitsError
      // 
      chartArea8.Name = "ChartArea1";
      this.m_chart_hitsError.ChartAreas.Add(chartArea8);
      this.m_chart_hitsError.Dock = System.Windows.Forms.DockStyle.Fill;
      legend8.Name = "Legend1";
      this.m_chart_hitsError.Legends.Add(legend8);
      this.m_chart_hitsError.Location = new System.Drawing.Point(2, 15);
      this.m_chart_hitsError.Margin = new System.Windows.Forms.Padding(2);
      this.m_chart_hitsError.Name = "m_chart_hitsError";
      series8.ChartArea = "ChartArea1";
      series8.Legend = "Legend1";
      series8.Name = "Series1";
      this.m_chart_hitsError.Series.Add(series8);
      this.m_chart_hitsError.Size = new System.Drawing.Size(1141, 228);
      this.m_chart_hitsError.TabIndex = 3;
      this.m_chart_hitsError.Text = "chart1";
      // 
      // frmExecOverTime
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1145, 873);
      this.Controls.Add(this.grp_HitsError);
      this.Controls.Add(this.grpChart3);
      this.Controls.Add(this.grpChart1);
      this.Controls.Add(this.grp);
      this.Controls.Add(this.panel1);
      this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
      this.Name = "frmExecOverTime";
      this.Text = "Executions times";
      this.panel1.ResumeLayout(false);
      this.panel1.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartExec)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartHits)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.m_chartExec2)).EndInit();
      this.grpChart3.ResumeLayout(false);
      this.grp.ResumeLayout(false);
      this.grpChart1.ResumeLayout(false);
      this.grp_HitsError.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.m_chart_hitsError)).EndInit();
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel panel1;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.TextBox txtUri;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chartExec;
    private System.Windows.Forms.Label label1;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chartHits;
    private System.Windows.Forms.Label label2;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chartExec2;
    private System.Windows.Forms.GroupBox grpChart3;
    private System.Windows.Forms.GroupBox grp;
    private System.Windows.Forms.GroupBox grpChart1;
    private System.Windows.Forms.GroupBox grp_HitsError;
    private System.Windows.Forms.DataVisualization.Charting.Chart m_chart_hitsError;
  }
}