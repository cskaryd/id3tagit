using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmDouble : Form
  {
    #region Designer

    private Button btnCancel;
    private Button btnOK;
    private System.Windows.Forms.GroupBox GroupBox;
    private Label lblStatus;
    private RadioButton optAD;
    private RadioButton optAT;
    private RadioButton optATA;
    private RadioButton optTAGV1;
    private RadioButton optTAGV2;
    private Panel Panel1;
    private Panel Panel2;
    private System.Windows.Forms.ProgressBar ProgressBar;
    private System.Windows.Forms.ToolTip ToolTip;
    private IContainer components;
    private frmMain MainForm;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.GroupBox = new System.Windows.Forms.GroupBox();
      this.lblStatus = new System.Windows.Forms.Label();
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.Panel1 = new System.Windows.Forms.Panel();
      this.optTAGV1 = new System.Windows.Forms.RadioButton();
      this.optTAGV2 = new System.Windows.Forms.RadioButton();
      this.Panel2 = new System.Windows.Forms.Panel();
      this.optAD = new System.Windows.Forms.RadioButton();
      this.optATA = new System.Windows.Forms.RadioButton();
      this.optAT = new System.Windows.Forms.RadioButton();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.GroupBox.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(352, 256);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(112, 24);
      this.btnCancel.TabIndex = 19;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(232, 256);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(112, 24);
      this.btnOK.TabIndex = 18;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // GroupBox
      // 
      this.GroupBox.Controls.Add(this.lblStatus);
      this.GroupBox.Controls.Add(this.ProgressBar);
      this.GroupBox.Enabled = false;
      this.GroupBox.Location = new System.Drawing.Point(8, 168);
      this.GroupBox.Name = "GroupBox";
      this.GroupBox.Size = new System.Drawing.Size(464, 80);
      this.GroupBox.TabIndex = 20;
      this.GroupBox.TabStop = false;
      this.GroupBox.Text = "Progress ...";
      // 
      // lblStatus
      // 
      this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblStatus.Location = new System.Drawing.Point(8, 24);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(448, 16);
      this.lblStatus.TabIndex = 1;
      this.lblStatus.Text = "Status";
      // 
      // ProgressBar
      // 
      this.ProgressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ProgressBar.Location = new System.Drawing.Point(8, 48);
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Size = new System.Drawing.Size(448, 16);
      this.ProgressBar.TabIndex = 0;
      // 
      // Panel1
      // 
      this.Panel1.Controls.Add(this.optTAGV1);
      this.Panel1.Controls.Add(this.optTAGV2);
      this.Panel1.Location = new System.Drawing.Point(8, 104);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new System.Drawing.Size(464, 56);
      this.Panel1.TabIndex = 22;
      // 
      // optTAGV1
      // 
      this.optTAGV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optTAGV1.Location = new System.Drawing.Point(8, 8);
      this.optTAGV1.Name = "optTAGV1";
      this.optTAGV1.Size = new System.Drawing.Size(256, 18);
      this.optTAGV1.TabIndex = 5;
      this.optTAGV1.Text = "Use TAG Ver. 1 for comparing";
      // 
      // optTAGV2
      // 
      this.optTAGV2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optTAGV2.Location = new System.Drawing.Point(8, 32);
      this.optTAGV2.Name = "optTAGV2";
      this.optTAGV2.Size = new System.Drawing.Size(256, 18);
      this.optTAGV2.TabIndex = 4;
      this.optTAGV2.Text = "Use TAG Ver. 2 for comparing";
      // 
      // Panel2
      // 
      this.Panel2.Controls.Add(this.optAD);
      this.Panel2.Controls.Add(this.optATA);
      this.Panel2.Controls.Add(this.optAT);
      this.Panel2.Location = new System.Drawing.Point(8, 8);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new System.Drawing.Size(464, 88);
      this.Panel2.TabIndex = 23;
      // 
      // optAD
      // 
      this.optAD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optAD.Location = new System.Drawing.Point(8, 60);
      this.optAD.Name = "optAD";
      this.optAD.Size = new System.Drawing.Size(424, 18);
      this.optAD.TabIndex = 8;
      this.optAD.Text = "Find files with same audio data (LENGTHY operation)";
      // 
      // optATA
      // 
      this.optATA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optATA.Location = new System.Drawing.Point(8, 36);
      this.optATA.Name = "optATA";
      this.optATA.Size = new System.Drawing.Size(424, 18);
      this.optATA.TabIndex = 7;
      this.optATA.Text = "Find files with same artist, title, album";
      // 
      // optAT
      // 
      this.optAT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optAT.Location = new System.Drawing.Point(8, 12);
      this.optAT.Name = "optAT";
      this.optAT.Size = new System.Drawing.Size(424, 18);
      this.optAT.TabIndex = 6;
      this.optAT.Text = "Find files with same artist and title";
      // 
      // frmDouble
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(480, 288);
      this.ControlBox = false;
      this.Controls.Add(this.Panel2);
      this.Controls.Add(this.Panel1);
      this.Controls.Add(this.GroupBox);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "frmDouble";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Find duplicate files";
      this.GroupBox.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    public frmDouble(frmMain Main)
    {
      base.Load += new EventHandler(this.frmDouble_Load);
      this.vbooCancel = false;
      this.InitializeComponent();
      this.MainForm = Main;
    }

    #endregion
  }
}