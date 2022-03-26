using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmProgress : Form
  {
    #region Designer

    public Button btnCancel;
    public Label lblInfo;
    public ProgressBar ProgressBar;
    public Label State;
    private Timer Timer;
    private IContainer components;

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.btnCancel = new System.Windows.Forms.Button();
      this.State = new System.Windows.Forms.Label();
      this.lblInfo = new System.Windows.Forms.Label();
      this.Timer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // ProgressBar
      // 
      this.ProgressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ProgressBar.Location = new System.Drawing.Point(16, 40);
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Size = new System.Drawing.Size(376, 16);
      this.ProgressBar.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
      this.ProgressBar.TabIndex = 0;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(138, 132);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(128, 24);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // State
      // 
      this.State.BackColor = System.Drawing.SystemColors.Control;
      this.State.ForeColor = System.Drawing.Color.Black;
      this.State.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.State.Location = new System.Drawing.Point(12, 9);
      this.State.Name = "State";
      this.State.Size = new System.Drawing.Size(384, 16);
      this.State.TabIndex = 2;
      // 
      // lblInfo
      // 
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(16, 64);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(376, 56);
      this.lblInfo.TabIndex = 3;
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Timer
      // 
      this.Timer.Enabled = true;
      this.Timer.Interval = 10;
      this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
      // 
      // frmProgress
      // 
      this.AllowDrop = true;
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(408, 168);
      this.ControlBox = false;
      this.Controls.Add(this.State);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.ProgressBar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmProgress";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ID3-TagIT - Progress window";
      this.ResumeLayout(false);

    }

    public frmProgress(int vintMinimum, int vintMaximum, int vintStep, ref Form OwnerForm, ref Callback CB)
    {
      base.Load += new EventHandler(this.frmProgress_Load);
      base.Closing += new CancelEventHandler(this.frmProgress_Closing);
      this.vbooCanceled = false;
      this.vbooFinished = false;
      this.vstr01 = "";
      this.vstr02 = "";
      this.vstr03 = "";
      this.vint01 = 0;
      this.vint02 = 0;
      this.vint03 = 0;
      this.vboo01 = false;
      this.vboo02 = false;
      this.objMP3 = null;
      this.objList = null;
      this.objListHelp = null;
      this.InitializeComponent();
      this.ProgressBar.Minimum = vintMinimum;
      this.ProgressBar.Maximum = vintMaximum;
      this.ProgressBar.Step = vintStep;
      this.ProgressBar.Value = vintMinimum;
      this.Owner = OwnerForm;
      this.CBack = CB;
    }

    #endregion
  }
}