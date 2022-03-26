using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmAbout : Form
  {
    #region Events

    private void frmAbout_Load(object sender, EventArgs e)
    {
      this.lblVersion.Text = string.Format("Version: {0}", Application.ProductVersion.ToString());

      if (Id3TagIT_Main.IS_ALPHA)
        this.lblVersion.Text = string.Format("{0} alpha", this.lblVersion.Text);

      if (Id3TagIT_Main.IS_BETA)
        this.lblVersion.Text = string.Format("{0} beta", this.lblVersion.Text);
    }

    private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(this.lblLink.Text);
    }

    #endregion
  }
}