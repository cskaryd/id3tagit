using System;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmSplash : Form
  {
    #region Designer

    public Label lblState;
    private Label lblVersion;
    private System.Windows.Forms.PictureBox picLogo;
    private Label lblUpdate;
    private Label lblCopyright;

    protected override void Dispose(bool disposing)
    {
      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
      this.lblState = new System.Windows.Forms.Label();
      this.lblVersion = new System.Windows.Forms.Label();
      this.picLogo = new System.Windows.Forms.PictureBox();
      this.lblUpdate = new System.Windows.Forms.Label();
      this.lblCopyright = new System.Windows.Forms.Label();
      ((System.ComponentModel.ISupportInitialize)(this.picLogo)).BeginInit();
      this.SuspendLayout();
      // 
      // lblState
      // 
      this.lblState.BackColor = System.Drawing.Color.Transparent;
      this.lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblState.ForeColor = System.Drawing.Color.SteelBlue;
      this.lblState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblState.Location = new System.Drawing.Point(0, 154);
      this.lblState.Name = "lblState";
      this.lblState.Size = new System.Drawing.Size(376, 18);
      this.lblState.TabIndex = 4;
      this.lblState.Text = "Copyright 2000-2004 by Michael Pluemper";
      this.lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblVersion
      // 
      this.lblVersion.BackColor = System.Drawing.Color.Transparent;
      this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblVersion.ForeColor = System.Drawing.Color.SteelBlue;
      this.lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblVersion.Location = new System.Drawing.Point(0, 128);
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(376, 16);
      this.lblVersion.TabIndex = 6;
      this.lblVersion.Text = "Version 3.x";
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // picLogo
      // 
      this.picLogo.BackColor = System.Drawing.Color.White;
      this.picLogo.Image = global::Properties.Resources.ID3_TagIT_Logo;
      this.picLogo.Location = new System.Drawing.Point(0, 8);
      this.picLogo.Name = "picLogo";
      this.picLogo.Size = new System.Drawing.Size(376, 112);
      this.picLogo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picLogo.TabIndex = 5;
      this.picLogo.TabStop = false;
      // 
      // lblUpdate
      // 
      this.lblUpdate.BackColor = System.Drawing.Color.Transparent;
      this.lblUpdate.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblUpdate.ForeColor = System.Drawing.Color.SteelBlue;
      this.lblUpdate.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblUpdate.Location = new System.Drawing.Point(0, 195);
      this.lblUpdate.Name = "lblUpdate";
      this.lblUpdate.Size = new System.Drawing.Size(376, 18);
      this.lblUpdate.TabIndex = 7;
      this.lblUpdate.Text = "Recompiled Updates in 2022 by Chris Skaryd";
      this.lblUpdate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblCopyright
      // 
      this.lblCopyright.BackColor = System.Drawing.Color.Transparent;
      this.lblCopyright.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblCopyright.ForeColor = System.Drawing.Color.SteelBlue;
      this.lblCopyright.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCopyright.Location = new System.Drawing.Point(0, 174);
      this.lblCopyright.Name = "lblCopyright";
      this.lblCopyright.Size = new System.Drawing.Size(376, 18);
      this.lblCopyright.TabIndex = 8;
      this.lblCopyright.Text = "Copyright 2000-2004 by Michael Pluemper";
      this.lblCopyright.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // frmSplash
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(376, 220);
      this.Controls.Add(this.lblCopyright);
      this.Controls.Add(this.lblUpdate);
      this.Controls.Add(this.lblVersion);
      this.Controls.Add(this.picLogo);
      this.Controls.Add(this.lblState);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmSplash";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ID3-TagIT";
      ((System.ComponentModel.ISupportInitialize)(this.picLogo)).EndInit();
      this.ResumeLayout(false);

    }

    public frmSplash()
    {
      base.Load += new EventHandler(this.frmSplash_Load);
      this.InitializeComponent();
    }

    #endregion

    #region Events

    private void frmSplash_Load(object sender, EventArgs e)
    {
      this.lblVersion.Text = "Version: " + Application.ProductVersion.ToString().Substring(0, Application.ProductVersion.ToString().LastIndexOf("."));
    }

    #endregion
  }
}