using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmCompareFileTAG : Form
  {
    #region Designer

    private Button btnAdd;
    private Button btnCancel;
    private Button btnOK;
    private Button btnRemove;
    private CheckBox chkIgnoreCase;
    private CheckBox chkReplaceUnderScore;
    private ComboBox cmbFormat;
    private GroupBox framePara;
    private Label L1;
    private Label L10;
    private Label L11;
    private Label L12;
    private Label L13;
    private Label L14;
    private Label L15;
    private Label L16;
    private Label L17;
    private Label L18;
    private Label L19;
    private Label L2;
    private Label L20;
    private Label L3;
    private Label L4;
    private Label L5;
    private Label L6;
    private Label L7;
    private Label L8;
    private Label L9;
    private Label lblDigits;
    private Label lblFormat;
    private Label lblInfo;
    private RadioButton optTAGV1;
    private RadioButton optTAGV2;
    private System.Windows.Forms.ToolTip ToolTip;
    private NumericUpDown txtDigits;
    private IContainer components;
    private frmMain MainForm;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.lblInfo = new System.Windows.Forms.Label();
      this.lblDigits = new System.Windows.Forms.Label();
      this.txtDigits = new System.Windows.Forms.NumericUpDown();
      this.framePara = new System.Windows.Forms.GroupBox();
      this.L19 = new System.Windows.Forms.Label();
      this.L18 = new System.Windows.Forms.Label();
      this.L20 = new System.Windows.Forms.Label();
      this.L13 = new System.Windows.Forms.Label();
      this.L16 = new System.Windows.Forms.Label();
      this.L15 = new System.Windows.Forms.Label();
      this.L14 = new System.Windows.Forms.Label();
      this.L17 = new System.Windows.Forms.Label();
      this.L12 = new System.Windows.Forms.Label();
      this.L11 = new System.Windows.Forms.Label();
      this.L10 = new System.Windows.Forms.Label();
      this.L9 = new System.Windows.Forms.Label();
      this.L8 = new System.Windows.Forms.Label();
      this.L7 = new System.Windows.Forms.Label();
      this.L6 = new System.Windows.Forms.Label();
      this.L5 = new System.Windows.Forms.Label();
      this.L4 = new System.Windows.Forms.Label();
      this.L3 = new System.Windows.Forms.Label();
      this.L2 = new System.Windows.Forms.Label();
      this.L1 = new System.Windows.Forms.Label();
      this.btnRemove = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.cmbFormat = new System.Windows.Forms.ComboBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.lblFormat = new System.Windows.Forms.Label();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.optTAGV1 = new System.Windows.Forms.RadioButton();
      this.optTAGV2 = new System.Windows.Forms.RadioButton();
      this.chkReplaceUnderScore = new System.Windows.Forms.CheckBox();
      this.chkIgnoreCase = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).BeginInit();
      this.framePara.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblInfo
      // 
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(8, 320);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(496, 40);
      this.lblInfo.TabIndex = 34;
      this.lblInfo.Text = "This function compares the current filename with the filename created by the form" +
    " at. If there is a mismatch the file will marked.";
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblDigits
      // 
      this.lblDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDigits.Location = new System.Drawing.Point(105, 65);
      this.lblDigits.Name = "lblDigits";
      this.lblDigits.Size = new System.Drawing.Size(184, 16);
      this.lblDigits.TabIndex = 31;
      this.lblDigits.Text = "&Number of digits of track numbers:";
      // 
      // txtDigits
      // 
      this.txtDigits.Location = new System.Drawing.Point(313, 63);
      this.txtDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Name = "txtDigits";
      this.txtDigits.Size = new System.Drawing.Size(64, 20);
      this.txtDigits.TabIndex = 32;
      this.txtDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Validated += new System.EventHandler(this.txtDigits_Validated);
      // 
      // framePara
      // 
      this.framePara.Controls.Add(this.L19);
      this.framePara.Controls.Add(this.L18);
      this.framePara.Controls.Add(this.L20);
      this.framePara.Controls.Add(this.L13);
      this.framePara.Controls.Add(this.L16);
      this.framePara.Controls.Add(this.L15);
      this.framePara.Controls.Add(this.L14);
      this.framePara.Controls.Add(this.L17);
      this.framePara.Controls.Add(this.L12);
      this.framePara.Controls.Add(this.L11);
      this.framePara.Controls.Add(this.L10);
      this.framePara.Controls.Add(this.L9);
      this.framePara.Controls.Add(this.L8);
      this.framePara.Controls.Add(this.L7);
      this.framePara.Controls.Add(this.L6);
      this.framePara.Controls.Add(this.L5);
      this.framePara.Controls.Add(this.L4);
      this.framePara.Controls.Add(this.L3);
      this.framePara.Controls.Add(this.L2);
      this.framePara.Controls.Add(this.L1);
      this.framePara.Location = new System.Drawing.Point(9, 95);
      this.framePara.Name = "framePara";
      this.framePara.Size = new System.Drawing.Size(496, 145);
      this.framePara.TabIndex = 33;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      // 
      // L19
      // 
      this.L19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L19.Location = new System.Drawing.Point(12, 120);
      this.L19.Name = "L19";
      this.L19.Size = new System.Drawing.Size(152, 16);
      this.L19.TabIndex = 58;
      this.L19.Text = "<I> = Bitrate";
      // 
      // L18
      // 
      this.L18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L18.Location = new System.Drawing.Point(328, 104);
      this.L18.Name = "L18";
      this.L18.Size = new System.Drawing.Size(152, 16);
      this.L18.TabIndex = 57;
      this.L18.Text = "<1> = First letter of artist";
      // 
      // L20
      // 
      this.L20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L20.Location = new System.Drawing.Point(168, 120);
      this.L20.Name = "L20";
      this.L20.Size = new System.Drawing.Size(152, 16);
      this.L20.TabIndex = 56;
      this.L20.Text = "\\ = Folder";
      // 
      // L13
      // 
      this.L13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L13.Location = new System.Drawing.Point(8, 88);
      this.L13.Name = "L13";
      this.L13.Size = new System.Drawing.Size(152, 16);
      this.L13.TabIndex = 37;
      this.L13.Text = "<R> = Composer";
      // 
      // L16
      // 
      this.L16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L16.Location = new System.Drawing.Point(8, 104);
      this.L16.Name = "L16";
      this.L16.Size = new System.Drawing.Size(152, 16);
      this.L16.TabIndex = 16;
      this.L16.Text = "<E> = Beats/minute (BPM)";
      this.L16.Click += new System.EventHandler(this.Label_Click);
      // 
      // L15
      // 
      this.L15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L15.Location = new System.Drawing.Point(328, 88);
      this.L15.Name = "L15";
      this.L15.Size = new System.Drawing.Size(160, 16);
      this.L15.TabIndex = 14;
      this.L15.Text = "<O> = Band / Orchestra";
      this.L15.Click += new System.EventHandler(this.Label_Click);
      // 
      // L14
      // 
      this.L14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L14.Location = new System.Drawing.Point(168, 88);
      this.L14.Name = "L14";
      this.L14.Size = new System.Drawing.Size(160, 16);
      this.L14.TabIndex = 13;
      this.L14.Text = "<S> = Subtitle";
      this.L14.Click += new System.EventHandler(this.Label_Click);
      // 
      // L17
      // 
      this.L17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L17.Location = new System.Drawing.Point(168, 104);
      this.L17.Name = "L17";
      this.L17.Size = new System.Drawing.Size(160, 16);
      this.L17.TabIndex = 12;
      this.L17.Text = "<M> = Modified / Remixed by";
      this.L17.Click += new System.EventHandler(this.Label_Click);
      // 
      // L12
      // 
      this.L12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L12.Location = new System.Drawing.Point(328, 72);
      this.L12.Name = "L12";
      this.L12.Size = new System.Drawing.Size(160, 16);
      this.L12.TabIndex = 11;
      this.L12.Text = "<N> = Conductor";
      this.L12.Click += new System.EventHandler(this.Label_Click);
      // 
      // L11
      // 
      this.L11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L11.Location = new System.Drawing.Point(168, 72);
      this.L11.Name = "L11";
      this.L11.Size = new System.Drawing.Size(160, 16);
      this.L11.TabIndex = 10;
      this.L11.Text = "<p> = Total number of medias";
      this.L11.Click += new System.EventHandler(this.Label_Click);
      // 
      // L10
      // 
      this.L10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L10.Location = new System.Drawing.Point(8, 72);
      this.L10.Name = "L10";
      this.L10.Size = new System.Drawing.Size(160, 16);
      this.L10.TabIndex = 9;
      this.L10.Text = "<P> = Position in media set";
      this.L10.Click += new System.EventHandler(this.Label_Click);
      // 
      // L9
      // 
      this.L9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L9.Location = new System.Drawing.Point(328, 56);
      this.L9.Name = "L9";
      this.L9.Size = new System.Drawing.Size(160, 16);
      this.L9.TabIndex = 8;
      this.L9.Text = "<U> = Content Group";
      this.L9.Click += new System.EventHandler(this.Label_Click);
      // 
      // L8
      // 
      this.L8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L8.Location = new System.Drawing.Point(168, 56);
      this.L8.Name = "L8";
      this.L8.Size = new System.Drawing.Size(160, 16);
      this.L8.TabIndex = 7;
      this.L8.Text = "<k> = Total number of tracks";
      this.L8.Click += new System.EventHandler(this.Label_Click);
      // 
      // L7
      // 
      this.L7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L7.Location = new System.Drawing.Point(8, 56);
      this.L7.Name = "L7";
      this.L7.Size = new System.Drawing.Size(160, 16);
      this.L7.TabIndex = 6;
      this.L7.Text = "<K> = Track number";
      this.L7.Click += new System.EventHandler(this.Label_Click);
      // 
      // L6
      // 
      this.L6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L6.Location = new System.Drawing.Point(328, 40);
      this.L6.Name = "L6";
      this.L6.Size = new System.Drawing.Size(160, 16);
      this.L6.TabIndex = 5;
      this.L6.Text = "<G> = First Genre";
      this.L6.Click += new System.EventHandler(this.Label_Click);
      // 
      // L5
      // 
      this.L5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L5.Location = new System.Drawing.Point(168, 40);
      this.L5.Name = "L5";
      this.L5.Size = new System.Drawing.Size(160, 16);
      this.L5.TabIndex = 4;
      this.L5.Text = "<Y> = Year";
      this.L5.Click += new System.EventHandler(this.Label_Click);
      // 
      // L4
      // 
      this.L4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L4.Location = new System.Drawing.Point(8, 40);
      this.L4.Name = "L4";
      this.L4.Size = new System.Drawing.Size(160, 16);
      this.L4.TabIndex = 3;
      this.L4.Text = "<C> = Comment";
      this.L4.Click += new System.EventHandler(this.Label_Click);
      // 
      // L3
      // 
      this.L3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L3.Location = new System.Drawing.Point(328, 24);
      this.L3.Name = "L3";
      this.L3.Size = new System.Drawing.Size(160, 16);
      this.L3.TabIndex = 2;
      this.L3.Text = "<B> = Album";
      this.L3.Click += new System.EventHandler(this.Label_Click);
      // 
      // L2
      // 
      this.L2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L2.Location = new System.Drawing.Point(168, 24);
      this.L2.Name = "L2";
      this.L2.Size = new System.Drawing.Size(160, 16);
      this.L2.TabIndex = 1;
      this.L2.Text = "<T> = Title";
      this.L2.Click += new System.EventHandler(this.Label_Click);
      // 
      // L1
      // 
      this.L1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L1.Location = new System.Drawing.Point(8, 24);
      this.L1.Name = "L1";
      this.L1.Size = new System.Drawing.Size(160, 16);
      this.L1.TabIndex = 0;
      this.L1.Text = "<A> = Artist";
      this.L1.Click += new System.EventHandler(this.Label_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemove.Location = new System.Drawing.Point(313, 31);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(192, 24);
      this.btnRemove.TabIndex = 30;
      this.btnRemove.Text = "&Remove format from list";
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAdd.Location = new System.Drawing.Point(105, 31);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(192, 24);
      this.btnAdd.TabIndex = 29;
      this.btnAdd.Text = "&Add format to list";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // cmbFormat
      // 
      this.cmbFormat.ItemHeight = 13;
      this.cmbFormat.Location = new System.Drawing.Point(105, 7);
      this.cmbFormat.Name = "cmbFormat";
      this.cmbFormat.Size = new System.Drawing.Size(400, 21);
      this.cmbFormat.TabIndex = 28;
      this.cmbFormat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFormat_KeyPress);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(384, 368);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 36;
      this.btnCancel.Text = "&Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(256, 368);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 35;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // lblFormat
      // 
      this.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblFormat.Location = new System.Drawing.Point(9, 7);
      this.lblFormat.Name = "lblFormat";
      this.lblFormat.Size = new System.Drawing.Size(96, 16);
      this.lblFormat.TabIndex = 27;
      this.lblFormat.Text = "&Format:";
      // 
      // optTAGV1
      // 
      this.optTAGV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optTAGV1.Location = new System.Drawing.Point(24, 248);
      this.optTAGV1.Name = "optTAGV1";
      this.optTAGV1.Size = new System.Drawing.Size(224, 16);
      this.optTAGV1.TabIndex = 38;
      this.optTAGV1.Text = "Use TAG Ver. 1 for comparing";
      this.optTAGV1.CheckedChanged += new System.EventHandler(this.optTAG_CheckedChanged);
      // 
      // optTAGV2
      // 
      this.optTAGV2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optTAGV2.Location = new System.Drawing.Point(264, 248);
      this.optTAGV2.Name = "optTAGV2";
      this.optTAGV2.Size = new System.Drawing.Size(224, 16);
      this.optTAGV2.TabIndex = 37;
      this.optTAGV2.Text = "Use TAG Ver. 2 for comparing";
      this.optTAGV2.CheckedChanged += new System.EventHandler(this.optTAG_CheckedChanged);
      // 
      // chkReplaceUnderScore
      // 
      this.chkReplaceUnderScore.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkReplaceUnderScore.Location = new System.Drawing.Point(24, 272);
      this.chkReplaceUnderScore.Name = "chkReplaceUnderScore";
      this.chkReplaceUnderScore.Size = new System.Drawing.Size(464, 16);
      this.chkReplaceUnderScore.TabIndex = 39;
      this.chkReplaceUnderScore.Text = "Replace characters not allowed in filenames by \"_\"";
      // 
      // chkIgnoreCase
      // 
      this.chkIgnoreCase.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkIgnoreCase.Location = new System.Drawing.Point(24, 296);
      this.chkIgnoreCase.Name = "chkIgnoreCase";
      this.chkIgnoreCase.Size = new System.Drawing.Size(464, 16);
      this.chkIgnoreCase.TabIndex = 40;
      this.chkIgnoreCase.Text = "Ignore case during comparing";
      // 
      // frmCompareFileTAG
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(514, 397);
      this.ControlBox = false;
      this.Controls.Add(this.chkIgnoreCase);
      this.Controls.Add(this.chkReplaceUnderScore);
      this.Controls.Add(this.optTAGV1);
      this.Controls.Add(this.optTAGV2);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.lblDigits);
      this.Controls.Add(this.txtDigits);
      this.Controls.Add(this.framePara);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.cmbFormat);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.lblFormat);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmCompareFileTAG";
      this.ShowInTaskbar = false;
      this.Text = "Compare filename with TAG entries";
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).EndInit();
      this.framePara.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    public frmCompareFileTAG(frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmCompareFileTAG_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

  }
}