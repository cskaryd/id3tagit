namespace ID3_TagIT
{
  using System;
  using System.ComponentModel;
  using System.Diagnostics;
  using System.Drawing;
  using System.Resources;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

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
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void frmSplash_Load(object sender, EventArgs e)
    {
      this.lblVersion.Text = "Version: " + Application.ProductVersion.ToString().Substring(0, Application.ProductVersion.ToString().LastIndexOf("."));
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      ResourceManager manager = new ResourceManager(typeof(frmSplash));
      this.lblState = new Label();
      this.lblVersion = new Label();
      this.PictureBox = new System.Windows.Forms.PictureBox();
      this.SuspendLayout();
      this.lblState.BackColor = Color.Transparent;
      this.lblState.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.lblState.ForeColor = Color.SteelBlue;
      this.lblState.ImeMode = ImeMode.NoControl;
      Point point = new Point(0, 0x90);
      this.lblState.Location = point;
      this.lblState.Name = "lblState";
      Size size = new Size(0x178, 40);
      this.lblState.Size = size;
      this.lblState.TabIndex = 4;
      this.lblState.Text = "Copyright 2000-2004 by Michael Pluemper";
      this.lblState.TextAlign = ContentAlignment.MiddleCenter;
      this.lblVersion.BackColor = Color.Transparent;
      this.lblVersion.Font = new Font("Microsoft Sans Serif", 9f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblVersion.ForeColor = Color.SteelBlue;
      this.lblVersion.ImeMode = ImeMode.NoControl;
      point = new Point(0, 0x80);
      this.lblVersion.Location = point;
      this.lblVersion.Name = "lblVersion";
      size = new Size(0x178, 0x10);
      this.lblVersion.Size = size;
      this.lblVersion.TabIndex = 6;
      this.lblVersion.Text = "Version 3.x";
      this.lblVersion.TextAlign = ContentAlignment.MiddleCenter;
      this.PictureBox.BackColor = Color.White;
      this.PictureBox.Image = (Image)manager.GetObject("PictureBox.Image");
      point = new Point(0, 8);
      this.PictureBox.Location = point;
      this.PictureBox.Name = "PictureBox";
      size = new Size(0x178, 0x70);
      this.PictureBox.Size = size;
      this.PictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
      this.PictureBox.TabIndex = 5;
      this.PictureBox.TabStop = false;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.BackColor = Color.White;
      size = new Size(0x178, 0xc0);
      this.ClientSize = size;
      this.Controls.Add(this.lblVersion);
      this.Controls.Add(this.PictureBox);
      this.Controls.Add(this.lblState);
      this.FormBorderStyle = FormBorderStyle.None;
      this.Icon = (Icon)manager.GetObject("$this.Icon");
      this.Name = "frmSplash";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ID3-TagIT";
      this.ResumeLayout(false);
    }

    internal virtual Label lblState
    {
      get
      {
        return this._lblState;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblState != null)
        {
        }
        this._lblState = value;
        if (this._lblState != null)
        {
        }
      }
    }

    internal virtual Label lblVersion
    {
      get
      {
        return this._lblVersion;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblVersion != null)
        {
        }
        this._lblVersion = value;
        if (this._lblVersion != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.PictureBox PictureBox
    {
      get
      {
        return this._PictureBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._PictureBox != null)
        {
        }
        this._PictureBox = value;
        if (this._PictureBox != null)
        {
        }
      }
    }
  }
}