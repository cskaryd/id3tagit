using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmSplash : Form
  {
    private Label lblState;
    private Label lblVersion;
    private System.Windows.Forms.PictureBox PictureBox;
    private IContainer components;

    public frmSplash()
    {
      base.Load += new EventHandler(this.frmSplash_Load);
      this.InitializeComponent();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    private void frmSplash_Load(object sender, EventArgs e)
    {
      this.lblVersion.Text = "Version: " + Application.ProductVersion.ToString().Substring(0, Application.ProductVersion.ToString().LastIndexOf("."));
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
      this.lblState = new System.Windows.Forms.Label();
      this.lblVersion = new System.Windows.Forms.Label();
      this.PictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).BeginInit();
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
      this.lblState.Size = new System.Drawing.Size(376, 29);
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
      // PictureBox
      // 
      this.PictureBox.BackColor = System.Drawing.Color.White;
      this.PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("PictureBox.Image")));
      this.PictureBox.Location = new System.Drawing.Point(0, 8);
      this.PictureBox.Name = "PictureBox";
      this.PictureBox.Size = new System.Drawing.Size(376, 112);
      this.PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.PictureBox.TabIndex = 5;
      this.PictureBox.TabStop = false;
      // 
      // frmSplash
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(376, 192);
      this.Controls.Add(this.lblVersion);
      this.Controls.Add(this.PictureBox);
      this.Controls.Add(this.lblState);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Name = "frmSplash";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ID3-TagIT";
      ((System.ComponentModel.ISupportInitialize)(this.PictureBox)).EndInit();
      this.ResumeLayout(false);

    }
  }
}