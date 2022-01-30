using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmSplash : Form
  {
    [AccessedThroughProperty("lblState")]
    private Label _lblState;
    [AccessedThroughProperty("lblVersion")]
    private Label _lblVersion;
    [AccessedThroughProperty("PictureBox")]
    private System.Windows.Forms.PictureBox _PictureBox;
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
      this._lblVersion.Text = "Version: " + Application.ProductVersion.ToString().Substring(0, Application.ProductVersion.ToString().LastIndexOf("."));
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSplash));
      this._lblState = new System.Windows.Forms.Label();
      this._lblVersion = new System.Windows.Forms.Label();
      this._PictureBox = new System.Windows.Forms.PictureBox();
      ((System.ComponentModel.ISupportInitialize)(this._PictureBox)).BeginInit();
      this.SuspendLayout();
      // 
      // _lblState
      // 
      this._lblState.BackColor = System.Drawing.Color.Transparent;
      this._lblState.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblState.ForeColor = System.Drawing.Color.SteelBlue;
      this._lblState.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this._lblState.Location = new System.Drawing.Point(0, 154);
      this._lblState.Name = "_lblState";
      this._lblState.Size = new System.Drawing.Size(376, 29);
      this._lblState.TabIndex = 4;
      this._lblState.Text = "Copyright 2000-2004 by Michael Pluemper";
      this._lblState.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // _lblVersion
      // 
      this._lblVersion.BackColor = System.Drawing.Color.Transparent;
      this._lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this._lblVersion.ForeColor = System.Drawing.Color.SteelBlue;
      this._lblVersion.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this._lblVersion.Location = new System.Drawing.Point(0, 128);
      this._lblVersion.Name = "_lblVersion";
      this._lblVersion.Size = new System.Drawing.Size(376, 16);
      this._lblVersion.TabIndex = 6;
      this._lblVersion.Text = "Version 3.x";
      this._lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // _PictureBox
      // 
      this._PictureBox.BackColor = System.Drawing.Color.White;
      this._PictureBox.Image = ((System.Drawing.Image)(resources.GetObject("_PictureBox.Image")));
      this._PictureBox.Location = new System.Drawing.Point(0, 8);
      this._PictureBox.Name = "_PictureBox";
      this._PictureBox.Size = new System.Drawing.Size(376, 112);
      this._PictureBox.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this._PictureBox.TabIndex = 5;
      this._PictureBox.TabStop = false;
      // 
      // frmSplash
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.BackColor = System.Drawing.Color.White;
      this.ClientSize = new System.Drawing.Size(376, 192);
      this.Controls.Add(this._lblVersion);
      this.Controls.Add(this._PictureBox);
      this.Controls.Add(this._lblState);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.Name = "frmSplash";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ID3-TagIT";
      ((System.ComponentModel.ISupportInitialize)(this._PictureBox)).EndInit();
      this.ResumeLayout(false);
    }

    public Label lblState
    {
      get
      {
        return this._lblState;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._lblState = value;
      }
    }

    public Label lblVersion
    {
      get
      {
        return this._lblVersion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._lblVersion = value;
      }
    }

    public PictureBox PictureBox
    {
      get
      {
        return this._PictureBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._PictureBox = value;
      }
    }
  }
}