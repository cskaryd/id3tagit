using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmAbout : Form
  {
    private Button btnOK;
    private Label lblCopyRight;
    private Label lblHome;
    private LinkLabel lblLink;
    private Label lblVersion;
    private System.Windows.Forms.PictureBox PictureBox;

    public frmAbout()
    {
      base.Load += new EventHandler(this.frmAbout_Load);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }

    private void frmAbout_Load(object sender, EventArgs e)
    {
      Form formToCheck = this;
      //Main.WindowsXPCheck(ref formToCheck);
      this.lblVersion.Text = "Version: " + Application.ProductVersion.ToString().Substring(0, Application.ProductVersion.ToString().LastIndexOf("."));
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.lblVersion = new System.Windows.Forms.Label();
      this.lblCopyRight = new System.Windows.Forms.Label();
      this.lblHome = new System.Windows.Forms.Label();
      this.btnOK = new System.Windows.Forms.Button();
      this.lblLink = new System.Windows.Forms.LinkLabel();
      this.PictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // lblVersion
      // 
      this.lblVersion.BackColor = System.Drawing.Color.Transparent;
      this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblVersion.Location = new System.Drawing.Point(40, 104);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(304, 16);
      this.lblVersion.TabIndex = 1;
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblCopyRight
      // 
      this.lblCopyRight.BackColor = System.Drawing.Color.Transparent;
      this.lblCopyRight.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCopyRight.Location = new System.Drawing.Point(40, 160);
      this.lblCopyRight.Name = "lblCopyRight";
      this.lblCopyRight.Size = new System.Drawing.Size(304, 16);
      this.lblCopyRight.TabIndex = 2;
      this.lblCopyRight.Text = "Copyright 2000-2004 by Michael Pluemper";
      this.lblCopyRight.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblHome
      // 
      this.lblHome.BackColor = System.Drawing.Color.Transparent;
      this.lblHome.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblHome.Location = new System.Drawing.Point(96, 136);
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
      this.btnOK.Location = new System.Drawing.Point(128, 192);
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
      this.lblLink.Location = new System.Drawing.Point(168, 136);
      this.lblLink.Name = "lblLink";
      this.lblLink.Size = new System.Drawing.Size(120, 16);
      this.lblLink.TabIndex = 17;
      this.lblLink.TabStop = true;
      this.lblLink.Text = "http://www.id3-tagit.de";
      this.lblLink.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLink_LinkClicked);
      // 
      // PictureBox
      // 
      this.PictureBox.BackColor = System.Drawing.Color.White;
      this.PictureBox.Location = new System.Drawing.Point(0, 0);
      this.PictureBox.Name = "PictureBox";
      this.PictureBox.Size = new System.Drawing.Size(376, 112);
      this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.PictureBox.TabIndex = 18;
      this.PictureBox.TabStop = false;
      // 
      // frmAbout
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.White;
      this.CancelButton = this.btnOK;
      this.ClientSize = new System.Drawing.Size(378, 224);
      this.ControlBox = false;
      this.Controls.Add(this.lblLink);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.lblHome);
      this.Controls.Add(this.lblCopyRight);
      this.Controls.Add(this.lblVersion);
      this.Controls.Add(this.PictureBox);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmAbout";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "About ...";
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
      this.ResumeLayout(false);

    }

    private void lblLink_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      Process.Start(this.lblLink.Text);
    }
  }
}