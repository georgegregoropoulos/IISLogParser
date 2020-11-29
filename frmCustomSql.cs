using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace IISLogParser
{
  public partial class frmCustomSql : Form
  {
    private List<string> _LogFiles = null;
    public frmCustomSql()
    {
      InitializeComponent();

    }


    public frmCustomSql(List<string> sLogFiles)
    {
      InitializeComponent();

      _LogFiles = sLogFiles;
    }

    private void btnExecute_Click(object sender, EventArgs e)
    {
      if (String.IsNullOrEmpty(rtExecutionScript.Text)) return;

      try
      {
        LogParser.LogParser lp = new LogParser.LogParser(_LogFiles);

        List<string> scripts = new List<string>();
        scripts.Add(rtExecutionScript.Text);

        Dictionary<string, string> res = lp.Run(scripts);

        rtResults.Text = res["customScript_0"];
      }
      catch (Exception ex)
      {
        MessageBox.Show(ex.ToString(), "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      Close();
    }
  }
}
