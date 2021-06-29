namespace IISLogParser
{
  partial class frmCustomSql
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
            this.pnlTop = new System.Windows.Forms.Panel();
            this.btnClose = new System.Windows.Forms.Button();
            this.btnExecute = new System.Windows.Forms.Button();
            this.rtExecutionScript = new System.Windows.Forms.RichTextBox();
            this.grpExecution = new System.Windows.Forms.GroupBox();
            this.grpResults = new System.Windows.Forms.GroupBox();
            this.rtResults = new System.Windows.Forms.RichTextBox();
            this.statusStrip = new System.Windows.Forms.StatusStrip();
            this.toolStripStatusLabel = new System.Windows.Forms.ToolStripStatusLabel();
            this.pnlTop.SuspendLayout();
            this.grpExecution.SuspendLayout();
            this.grpResults.SuspendLayout();
            this.statusStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // pnlTop
            // 
            this.pnlTop.Controls.Add(this.btnClose);
            this.pnlTop.Controls.Add(this.btnExecute);
            this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
            this.pnlTop.Location = new System.Drawing.Point(0, 0);
            this.pnlTop.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.pnlTop.Name = "pnlTop";
            this.pnlTop.Size = new System.Drawing.Size(1132, 34);
            this.pnlTop.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.btnClose.Location = new System.Drawing.Point(969, 1);
            this.btnClose.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(159, 32);
            this.btnClose.TabIndex = 1;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnExecute
            // 
            this.btnExecute.Location = new System.Drawing.Point(4, 2);
            this.btnExecute.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.btnExecute.Name = "btnExecute";
            this.btnExecute.Size = new System.Drawing.Size(159, 28);
            this.btnExecute.TabIndex = 0;
            this.btnExecute.Text = "Execute";
            this.btnExecute.UseVisualStyleBackColor = true;
            this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
            // 
            // rtExecutionScript
            // 
            this.rtExecutionScript.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtExecutionScript.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.rtExecutionScript.Location = new System.Drawing.Point(4, 19);
            this.rtExecutionScript.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtExecutionScript.Name = "rtExecutionScript";
            this.rtExecutionScript.Size = new System.Drawing.Size(1124, 227);
            this.rtExecutionScript.TabIndex = 1;
            this.rtExecutionScript.Text = "";
            // 
            // grpExecution
            // 
            this.grpExecution.Controls.Add(this.rtExecutionScript);
            this.grpExecution.Dock = System.Windows.Forms.DockStyle.Top;
            this.grpExecution.Location = new System.Drawing.Point(0, 34);
            this.grpExecution.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExecution.Name = "grpExecution";
            this.grpExecution.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpExecution.Size = new System.Drawing.Size(1132, 250);
            this.grpExecution.TabIndex = 2;
            this.grpExecution.TabStop = false;
            this.grpExecution.Text = "SQL statement";
            // 
            // grpResults
            // 
            this.grpResults.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.grpResults.Controls.Add(this.rtResults);
            this.grpResults.Location = new System.Drawing.Point(0, 284);
            this.grpResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResults.Name = "grpResults";
            this.grpResults.Padding = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.grpResults.Size = new System.Drawing.Size(1132, 466);
            this.grpResults.TabIndex = 3;
            this.grpResults.TabStop = false;
            this.grpResults.Text = "Results";
            // 
            // rtResults
            // 
            this.rtResults.Dock = System.Windows.Forms.DockStyle.Fill;
            this.rtResults.Location = new System.Drawing.Point(4, 19);
            this.rtResults.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.rtResults.Name = "rtResults";
            this.rtResults.ReadOnly = true;
            this.rtResults.Size = new System.Drawing.Size(1124, 443);
            this.rtResults.TabIndex = 0;
            this.rtResults.Text = "";
            // 
            // statusStrip
            // 
            this.statusStrip.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.statusStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripStatusLabel});
            this.statusStrip.Location = new System.Drawing.Point(0, 750);
            this.statusStrip.Name = "statusStrip";
            this.statusStrip.Size = new System.Drawing.Size(1132, 26);
            this.statusStrip.TabIndex = 1;
            this.statusStrip.Text = ".....";
            // 
            // toolStripStatusLabel
            // 
            this.toolStripStatusLabel.Name = "toolStripStatusLabel";
            this.toolStripStatusLabel.Size = new System.Drawing.Size(151, 20);
            this.toolStripStatusLabel.Text = "toolStripStatusLabel1";
            // 
            // frmCustomSql
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1132, 776);
            this.Controls.Add(this.statusStrip);
            this.Controls.Add(this.grpResults);
            this.Controls.Add(this.grpExecution);
            this.Controls.Add(this.pnlTop);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "frmCustomSql";
            this.Text = "Custom execution";
            this.pnlTop.ResumeLayout(false);
            this.grpExecution.ResumeLayout(false);
            this.grpResults.ResumeLayout(false);
            this.statusStrip.ResumeLayout(false);
            this.statusStrip.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.RichTextBox rtExecutionScript;
    private System.Windows.Forms.GroupBox grpExecution;
    private System.Windows.Forms.GroupBox grpResults;
    private System.Windows.Forms.RichTextBox rtResults;
        private System.Windows.Forms.StatusStrip statusStrip;
        private System.Windows.Forms.ToolStripStatusLabel toolStripStatusLabel;
    }
}