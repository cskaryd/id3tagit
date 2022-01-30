using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmAbout : Form
  {
    #region Designer

    private Button btnOK;
    private Label lblCopyright;
    private Label lblHome;
    private LinkLabel lblLink;
    private Label lblVersion;
    private Label lblUpdate;
    private System.Windows.Forms.PictureBox picLogo;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.lblVersion = new System.Windows.Forms.Label();
      this.lblCopyright = new System.Windows.Forms.Label();
      this.lblHome = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.lblLink = new System.Windows.Forms.LinkLabel();
      this.picLogo = new System.Windows.Forms.PictureBox();
      this.lblUpdate = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // lblVersion
      // 
      this.lblVersion.BackColor = System.Drawing.Color.Transparent;
      this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblVersion.Location = new System.Drawing.Point(40, 120);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(304, 16);
      this.lblVersion.TabIndex = 1;
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblCopyright
      // 
      this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
      this.lblCopyright.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCopyright.Location = new System.Drawing.Point(40, 165);
      this.lblCopyright.Name = "lblCopyright";
      this.lblCopyright.Size = new System.Drawing.Size(304, 16);
      this.lblCopyright.TabIndex = 2;
      this.lblCopyright.Text = "Copyright 2000-2004 by Michael Pluemper";
      this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblHome
      // 
      this.lblHome.BackColor = System.Drawing.Color.Transparent;
      this.lblHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblHome.Location = new System.Drawing.Point(96, 141);
      this.lblHome.Name = "lblHome";
      this.lblHome.Size = new System.Drawing.Size(68, 16);
      this.lblHome.TabIndex = 3;
      this.lblHome.Text = "Homepage:";
      this.lblHome.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnOK
      // 
      this.btnOK.BackColor = System.Drawing.SystemColors.Control;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(126, 214);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 16;
      this.btnOK.Text = "&OK";
      this.btnOK.UseVisualStyleBackColor = false;
      // 
      // lblLink
      // 
      this.lblLink.BackColor = System.Drawing.Color.Transparent;
      this.lblLink.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLink.LinkArea = new System.Windows.Forms.LinkArea(0, 23);
      this.lblLink.Location = new System.Drawing.Point(170, 143);
      this.lblLink.Name = "lblLink";
      this.lblLink.Size = new System.Drawing.Size(120, 16);
      this.lblLink.TabIndex = 17;
      this.lblLink.TabStop = true;
      this.lblLink.Text = "http://www.id3-tagit.de";
      this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
      // 
      // picLogo
      // 
      this.picLogo.BackColor = System.Drawing.Color.White;
      this.picLogo.Image = global::Properties.Resources.ID3_TagIT_Logo;
      this.picLogo.Location = new System.Drawing.Point(0, 0);
      this.picLogo.Name = "picLogo";
      this.picLogo.Size = new System.Drawing.Size(376, 112);
      this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picLogo.TabIndex = 18;
      this.picLogo.TabStop = false;
      // 
      // lblUpdate
      // 
      this.lblUpdate.AutoSize = true;
      this.lblUpdate.Location = new System.Drawing.Point(72, 189);
      this.lblUpdate.Name = "lblUpdate";
      this.lblUpdate.Size = new System.Drawing.Size(230, 13);
      this.lblUpdate.TabIndex = 19;
      this.lblUpdate.Text = "Recompiled version by Chris Skaryd made in 2022";
      // 
      // frmAbout
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.btnOK;
      this.ClientSize = new System.Drawing.Size(378, 250);
      this.ControlBox = false;
      this.Controls.Add(this.lblUpdate);
      this.Controls.Add(this.lblLink);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.lblHome);
      this.Controls.Add(this.lblCopyright);
      this.Controls.Add(this.lblVersion);
      this.Controls.Add(this.picLogo);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAbout";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About ...";
      ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }

    public frmAbout()
    {
      base.Load += new EventHandler(this.frmAbout_Load);
      this.InitializeComponent();
    }

    #endregion

    #region Events

    private void frmAbout_Load(object sender, EventArgs e)
    {
      Form formToCheck = this;
      //Main.WindowsXPCheck(ref formToCheck);
      this.lblVersion.Text = "Version: " + Application.ProductVersion.ToString().Substring(0, Application.ProductVersion.ToString().LastIndexOf("."));
    }

    private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(this.lblLink.Text);
    }

    #endregion
  }
}