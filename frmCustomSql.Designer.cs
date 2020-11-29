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
      this.pnlTop.SuspendLayout();
      this.grpExecution.SuspendLayout();
      this.grpResults.SuspendLayout();
      this.SuspendLayout();
      // 
      // pnlTop
      // 
      this.pnlTop.Controls.Add(this.btnClose);
      this.pnlTop.Controls.Add(this.btnExecute);
      this.pnlTop.Dock = System.Windows.Forms.DockStyle.Top;
      this.pnlTop.Location = new System.Drawing.Point(0, 0);
      this.pnlTop.Name = "pnlTop";
      this.pnlTop.Size = new System.Drawing.Size(839, 28);
      this.pnlTop.TabIndex = 0;
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.Location = new System.Drawing.Point(717, 1);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(119, 26);
      this.btnClose.TabIndex = 1;
      this.btnClose.Text = "Close";
      this.btnClose.UseVisualStyleBackColor = true;
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // btnExecute
      // 
      this.btnExecute.Location = new System.Drawing.Point(3, 2);
      this.btnExecute.Name = "btnExecute";
      this.btnExecute.Size = new System.Drawing.Size(119, 23);
      this.btnExecute.TabIndex = 0;
      this.btnExecute.Text = "Execute";
      this.btnExecute.UseVisualStyleBackColor = true;
      this.btnExecute.Click += new System.EventHandler(this.btnExecute_Click);
      // 
      // rtExecutionScript
      // 
      this.rtExecutionScript.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtExecutionScript.Font = new System.Drawing.Font("Courier New", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
      this.rtExecutionScript.Location = new System.Drawing.Point(3, 16);
      this.rtExecutionScript.Name = "rtExecutionScript";
      this.rtExecutionScript.Size = new System.Drawing.Size(833, 184);
      this.rtExecutionScript.TabIndex = 1;
      this.rtExecutionScript.Text = "";
      // 
      // grpExecution
      // 
      this.grpExecution.Controls.Add(this.rtExecutionScript);
      this.grpExecution.Dock = System.Windows.Forms.DockStyle.Top;
      this.grpExecution.Location = new System.Drawing.Point(0, 28);
      this.grpExecution.Name = "grpExecution";
      this.grpExecution.Size = new System.Drawing.Size(839, 203);
      this.grpExecution.TabIndex = 2;
      this.grpExecution.TabStop = false;
      this.grpExecution.Text = "SQL statement";
      // 
      // grpResults
      // 
      this.grpResults.Controls.Add(this.rtResults);
      this.grpResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.grpResults.Location = new System.Drawing.Point(0, 231);
      this.grpResults.Name = "grpResults";
      this.grpResults.Size = new System.Drawing.Size(839, 280);
      this.grpResults.TabIndex = 3;
      this.grpResults.TabStop = false;
      this.grpResults.Text = "Results";
      // 
      // rtResults
      // 
      this.rtResults.Dock = System.Windows.Forms.DockStyle.Fill;
      this.rtResults.Location = new System.Drawing.Point(3, 16);
      this.rtResults.Name = "rtResults";
      this.rtResults.ReadOnly = true;
      this.rtResults.Size = new System.Drawing.Size(833, 261);
      this.rtResults.TabIndex = 0;
      this.rtResults.Text = "";
      // 
      // frmCustomSql
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(839, 511);
      this.Controls.Add(this.grpResults);
      this.Controls.Add(this.grpExecution);
      this.Controls.Add(this.pnlTop);
      this.Name = "frmCustomSql";
      this.Text = "Custom execution";
      this.pnlTop.ResumeLayout(false);
      this.grpExecution.ResumeLayout(false);
      this.grpResults.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion

    private System.Windows.Forms.Panel pnlTop;
    private System.Windows.Forms.Button btnClose;
    private System.Windows.Forms.Button btnExecute;
    private System.Windows.Forms.RichTextBox rtExecutionScript;
    private System.Windows.Forms.GroupBox grpExecution;
    private System.Windows.Forms.GroupBox grpResults;
    private System.Windows.Forms.RichTextBox rtResults;
  }
}