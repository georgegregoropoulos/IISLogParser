namespace IISLogParser {
  partial class frmFileManager {
    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing) {
      if (disposing && (components != null)) {
        components.Dispose();
      }
      base.Dispose(disposing);
    }

    #region Windows Form Designer generated code

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    private void InitializeComponent() {
      this.btnAddFiles = new System.Windows.Forms.Button();
      this.chkLBFiles = new System.Windows.Forms.CheckedListBox();
      this.grbFilesSelected = new System.Windows.Forms.GroupBox();
      this.btnRemoveFiles = new System.Windows.Forms.Button();
      this.btnOk = new System.Windows.Forms.Button();
      this.grbFilesSelected.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnAddFiles
      // 
      this.btnAddFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnAddFiles.Location = new System.Drawing.Point(1170, 12);
      this.btnAddFiles.Name = "btnAddFiles";
      this.btnAddFiles.Size = new System.Drawing.Size(160, 33);
      this.btnAddFiles.TabIndex = 1;
      this.btnAddFiles.Text = "Add file(s)";
      this.btnAddFiles.UseVisualStyleBackColor = true;
      this.btnAddFiles.Click += new System.EventHandler(this.btnAddFiles_Click);
      // 
      // chkLBFiles
      // 
      this.chkLBFiles.Dock = System.Windows.Forms.DockStyle.Fill;
      this.chkLBFiles.FormattingEnabled = true;
      this.chkLBFiles.Location = new System.Drawing.Point(3, 22);
      this.chkLBFiles.Name = "chkLBFiles";
      this.chkLBFiles.Size = new System.Drawing.Size(1146, 541);
      this.chkLBFiles.TabIndex = 2;
      // 
      // grbFilesSelected
      // 
      this.grbFilesSelected.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grbFilesSelected.Controls.Add(this.chkLBFiles);
      this.grbFilesSelected.Location = new System.Drawing.Point(12, 12);
      this.grbFilesSelected.Name = "grbFilesSelected";
      this.grbFilesSelected.Size = new System.Drawing.Size(1152, 566);
      this.grbFilesSelected.TabIndex = 3;
      this.grbFilesSelected.TabStop = false;
      this.grbFilesSelected.Text = "Files selected";
      // 
      // btnRemoveFiles
      // 
      this.btnRemoveFiles.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnRemoveFiles.Location = new System.Drawing.Point(1170, 51);
      this.btnRemoveFiles.Name = "btnRemoveFiles";
      this.btnRemoveFiles.Size = new System.Drawing.Size(160, 33);
      this.btnRemoveFiles.TabIndex = 4;
      this.btnRemoveFiles.Text = "Remove file(s)";
      this.btnRemoveFiles.UseVisualStyleBackColor = true;
      this.btnRemoveFiles.Click += new System.EventHandler(this.btnRemoveFiles_Click);
      // 
      // btnOk
      // 
      this.btnOk.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.btnOk.Location = new System.Drawing.Point(1170, 542);
      this.btnOk.Name = "btnOk";
      this.btnOk.Size = new System.Drawing.Size(160, 33);
      this.btnOk.TabIndex = 5;
      this.btnOk.Text = "Ok";
      this.btnOk.UseVisualStyleBackColor = true;
      this.btnOk.Click += new System.EventHandler(this.btnOk_Click);
      // 
      // frmFileManager
      // 
      this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
      this.ClientSize = new System.Drawing.Size(1342, 590);
      this.Controls.Add(this.btnOk);
      this.Controls.Add(this.btnRemoveFiles);
      this.Controls.Add(this.grbFilesSelected);
      this.Controls.Add(this.btnAddFiles);
      this.Name = "frmFileManager";
      this.Text = "File Manager";
      this.grbFilesSelected.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    #endregion
    private System.Windows.Forms.Button btnAddFiles;
    private System.Windows.Forms.CheckedListBox chkLBFiles;
    private System.Windows.Forms.GroupBox grbFilesSelected;
    private System.Windows.Forms.Button btnRemoveFiles;
    private System.Windows.Forms.Button btnOk;
  }
}