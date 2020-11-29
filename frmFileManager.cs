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
  public partial class frmFileManager : Form {
    public frmFileManager() {
      InitializeComponent();
    }

    public frmFileManager(List<string> files) : this() {

      foreach(var it in files) {
        chkLBFiles.Items.Add(it);
      }
    }

    public List<string> FilesSelected {

      get {
        List<string> files = new List<string>();
        foreach(var it in chkLBFiles.Items) {
          files.Add((string) it);
        }
        return files;
      }
      private set { }
    }

    private void btnAddFiles_Click(object sender, EventArgs e) {
      try {
        OpenFileDialog fdlg = new OpenFileDialog();
        fdlg.Filter = "IIS Log Files (.log)|*.log|All Files (*.*)|*.*";
        fdlg.FilterIndex = 1;
        fdlg.Multiselect = true;

        using (fdlg) {
          if (fdlg.ShowDialog() == System.Windows.Forms.DialogResult.OK) {
            foreach (var it in fdlg.FileNames) {

              if (!IsUnique(it)) continue;

              chkLBFiles.Items.Add(it);

            }
          }
          //if (_filenames == null || _filenames.Count == 0) return;
          //this.Text = String.Format("{0} [{1}]", _textLabel, _filenames[0]);
        }
      } catch(Exception ex) {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private bool IsUnique(string d) {
      foreach(var it in chkLBFiles.Items) {
        if ((string)it == d) return false;
      }
      return true;
    }

    private void btnRemoveFiles_Click(object sender, EventArgs e) {
      try {
        List<object> remove = new List<object>();
        foreach(var it in chkLBFiles.SelectedItems) {
          remove.Add(it);
        }
        foreach (var it in remove) {
          chkLBFiles.Items.Remove(it);
        }
      } catch(Exception ex) {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnOk_Click(object sender, EventArgs e) {
      DialogResult = DialogResult.OK;
      Close();
    }
  }
}
