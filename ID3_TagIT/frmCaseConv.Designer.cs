using System;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmCaseConv : Form
  {
    #region Designer

    private IContainer components;
    private Button btnAdd;
    private Button btnCancel;
    private Button btnOK;
    private Button btnRemove;
    private CheckBox chkAlbum;
    private CheckBox chkAlwaysFirst;
    private CheckBox chkArtist;
    private CheckBox chkComment;
    private CheckBox chkFilename;
    private CheckBox chkSeparator;
    private CheckBox chkReplace20Space;
    private CheckBox chkReplaceSpace20;
    private CheckBox chkReplaceSpaceUnder;
    private CheckBox chkReplaceUnderSpace;
    private CheckBox chkTitle;
    private CheckBox chkVer1;
    private CheckBox chkVer2;
    private GroupBox frameMethod;
    private GroupBox frameOptions;
    private GroupBox frameTAGOptions;
    private Label lblInfo;
    private ListBox lstExceptions;
    private frmMain MainForm;
    private RadioButton optAllFirstUp;
    private RadioButton optAllLow;
    private RadioButton optAllUp;
    private RadioButton optFirstUp;
    private TabControl tabControl1;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private TextBox txtException;
    private TextBox txtSeparator;
    private ToolTip ToolTip;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabPage3 = new System.Windows.Forms.TabPage();
      this.frameTAGOptions = new System.Windows.Forms.GroupBox();
      this.chkArtist = new System.Windows.Forms.CheckBox();
      this.chkTitle = new System.Windows.Forms.CheckBox();
      this.chkAlbum = new System.Windows.Forms.CheckBox();
      this.chkComment = new System.Windows.Forms.CheckBox();
      this.chkFilename = new System.Windows.Forms.CheckBox();
      this.chkVer2 = new System.Windows.Forms.CheckBox();
      this.chkVer1 = new System.Windows.Forms.CheckBox();
      this.frameOptions = new System.Windows.Forms.GroupBox();
      this.chkAlwaysFirst = new System.Windows.Forms.CheckBox();
      this.chkReplaceSpaceUnder = new System.Windows.Forms.CheckBox();
      this.chkReplaceSpace20 = new System.Windows.Forms.CheckBox();
      this.chkReplaceUnderSpace = new System.Windows.Forms.CheckBox();
      this.chkReplace20Space = new System.Windows.Forms.CheckBox();
      this.txtSeparator = new System.Windows.Forms.TextBox();
      this.chkSeparator = new System.Windows.Forms.CheckBox();
      this.frameMethod = new System.Windows.Forms.GroupBox();
      this.optAllFirstUp = new System.Windows.Forms.RadioButton();
      this.optFirstUp = new System.Windows.Forms.RadioButton();
      this.optAllUp = new System.Windows.Forms.RadioButton();
      this.optAllLow = new System.Windows.Forms.RadioButton();
      this.tabPage4 = new System.Windows.Forms.TabPage();
      this.lstExceptions = new System.Windows.Forms.ListBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.lblInfo = new System.Windows.Forms.Label();
      this.txtException = new System.Windows.Forms.TextBox();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.tabControl1.SuspendLayout();
      this.tabPage3.SuspendLayout();
      this.frameTAGOptions.SuspendLayout();
      this.frameOptions.SuspendLayout();
      this.frameMethod.SuspendLayout();
      this.tabPage4.SuspendLayout();
      this.SuspendLayout();
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabPage3);
      this.tabControl1.Controls.Add(this.tabPage4);
      this.tabControl1.Location = new System.Drawing.Point(2, 2);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(450, 336);
      this.tabControl1.TabIndex = 118;
      // 
      // tabPage3
      // 
      this.tabPage3.Controls.Add(this.frameTAGOptions);
      this.tabPage3.Controls.Add(this.chkFilename);
      this.tabPage3.Controls.Add(this.chkVer2);
      this.tabPage3.Controls.Add(this.chkVer1);
      this.tabPage3.Controls.Add(this.frameOptions);
      this.tabPage3.Controls.Add(this.frameMethod);
      this.tabPage3.Location = new System.Drawing.Point(4, 22);
      this.tabPage3.Name = "tabPage3";
      this.tabPage3.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage3.Size = new System.Drawing.Size(442, 310);
      this.tabPage3.TabIndex = 0;
      this.tabPage3.Text = "Case Conversion";
      this.tabPage3.UseVisualStyleBackColor = true;
      // 
      // frameTAGOptions
      // 
      this.frameTAGOptions.BackColor = System.Drawing.Color.Transparent;
      this.frameTAGOptions.Controls.Add(this.chkArtist);
      this.frameTAGOptions.Controls.Add(this.chkTitle);
      this.frameTAGOptions.Controls.Add(this.chkAlbum);
      this.frameTAGOptions.Controls.Add(this.chkComment);
      this.frameTAGOptions.Location = new System.Drawing.Point(6, 55);
      this.frameTAGOptions.Name = "frameTAGOptions";
      this.frameTAGOptions.Size = new System.Drawing.Size(184, 120);
      this.frameTAGOptions.TabIndex = 28;
      this.frameTAGOptions.TabStop = false;
      this.frameTAGOptions.Text = "TAG fields to convert";
      // 
      // chkArtist
      // 
      this.chkArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkArtist.Location = new System.Drawing.Point(16, 24);
      this.chkArtist.Name = "chkArtist";
      this.chkArtist.Size = new System.Drawing.Size(160, 16);
      this.chkArtist.TabIndex = 4;
      this.chkArtist.Text = "&Artist";
      // 
      // chkTitle
      // 
      this.chkTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkTitle.Location = new System.Drawing.Point(16, 72);
      this.chkTitle.Name = "chkTitle";
      this.chkTitle.Size = new System.Drawing.Size(160, 16);
      this.chkTitle.TabIndex = 6;
      this.chkTitle.Text = "&Title";
      // 
      // chkAlbum
      // 
      this.chkAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkAlbum.Location = new System.Drawing.Point(16, 48);
      this.chkAlbum.Name = "chkAlbum";
      this.chkAlbum.Size = new System.Drawing.Size(160, 16);
      this.chkAlbum.TabIndex = 5;
      this.chkAlbum.Text = "Al&bum";
      // 
      // chkComment
      // 
      this.chkComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkComment.Location = new System.Drawing.Point(16, 96);
      this.chkComment.Name = "chkComment";
      this.chkComment.Size = new System.Drawing.Size(160, 16);
      this.chkComment.TabIndex = 7;
      this.chkComment.Text = "&Comment";
      // 
      // chkFilename
      // 
      this.chkFilename.BackColor = System.Drawing.Color.Transparent;
      this.chkFilename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkFilename.Location = new System.Drawing.Point(22, 7);
      this.chkFilename.Name = "chkFilename";
      this.chkFilename.Size = new System.Drawing.Size(192, 16);
      this.chkFilename.TabIndex = 25;
      this.chkFilename.Text = "Convert &Filename";
      this.chkFilename.UseVisualStyleBackColor = false;
      // 
      // chkVer2
      // 
      this.chkVer2.BackColor = System.Drawing.Color.Transparent;
      this.chkVer2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkVer2.Location = new System.Drawing.Point(238, 31);
      this.chkVer2.Name = "chkVer2";
      this.chkVer2.Size = new System.Drawing.Size(192, 16);
      this.chkVer2.TabIndex = 27;
      this.chkVer2.Text = "Convert TAG Ver. &2";
      this.chkVer2.UseVisualStyleBackColor = false;
      // 
      // chkVer1
      // 
      this.chkVer1.BackColor = System.Drawing.Color.Transparent;
      this.chkVer1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkVer1.Location = new System.Drawing.Point(22, 31);
      this.chkVer1.Name = "chkVer1";
      this.chkVer1.Size = new System.Drawing.Size(192, 16);
      this.chkVer1.TabIndex = 26;
      this.chkVer1.Text = "Convert TAG Ver. &1";
      this.chkVer1.UseVisualStyleBackColor = false;
      // 
      // frameOptions
      // 
      this.frameOptions.BackColor = System.Drawing.Color.Transparent;
      this.frameOptions.Controls.Add(this.chkAlwaysFirst);
      this.frameOptions.Controls.Add(this.chkReplaceSpaceUnder);
      this.frameOptions.Controls.Add(this.chkReplaceSpace20);
      this.frameOptions.Controls.Add(this.chkReplaceUnderSpace);
      this.frameOptions.Controls.Add(this.chkReplace20Space);
      this.frameOptions.Controls.Add(this.txtSeparator);
      this.frameOptions.Controls.Add(this.chkSeparator);
      this.frameOptions.Location = new System.Drawing.Point(6, 183);
      this.frameOptions.Name = "frameOptions";
      this.frameOptions.Size = new System.Drawing.Size(432, 120);
      this.frameOptions.TabIndex = 30;
      this.frameOptions.TabStop = false;
      this.frameOptions.Text = "Options";
      // 
      // chkAlwaysFirst
      // 
      this.chkAlwaysFirst.BackColor = System.Drawing.Color.Transparent;
      this.chkAlwaysFirst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkAlwaysFirst.Location = new System.Drawing.Point(16, 96);
      this.chkAlwaysFirst.Name = "chkAlwaysFirst";
      this.chkAlwaysFirst.Size = new System.Drawing.Size(408, 16);
      this.chkAlwaysFirst.TabIndex = 16;
      this.chkAlwaysFirst.Text = "Always uppercase first letter of entry";
      this.chkAlwaysFirst.UseVisualStyleBackColor = false;
      // 
      // chkReplaceSpaceUnder
      // 
      this.chkReplaceSpaceUnder.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkReplaceSpaceUnder.Location = new System.Drawing.Point(232, 72);
      this.chkReplaceSpaceUnder.Name = "chkReplaceSpaceUnder";
      this.chkReplaceSpaceUnder.Size = new System.Drawing.Size(192, 16);
      this.chkReplaceSpaceUnder.TabIndex = 18;
      this.chkReplaceSpaceUnder.Text = "Replace space by \'_\'";
      // 
      // chkReplaceSpace20
      // 
      this.chkReplaceSpace20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkReplaceSpace20.Location = new System.Drawing.Point(232, 48);
      this.chkReplaceSpace20.Name = "chkReplaceSpace20";
      this.chkReplaceSpace20.Size = new System.Drawing.Size(192, 16);
      this.chkReplaceSpace20.TabIndex = 17;
      this.chkReplaceSpace20.Text = "Replace space by \'%20\'";
      // 
      // chkReplaceUnderSpace
      // 
      this.chkReplaceUnderSpace.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkReplaceUnderSpace.Location = new System.Drawing.Point(16, 72);
      this.chkReplaceUnderSpace.Name = "chkReplaceUnderSpace";
      this.chkReplaceUnderSpace.Size = new System.Drawing.Size(208, 16);
      this.chkReplaceUnderSpace.TabIndex = 15;
      this.chkReplaceUnderSpace.Text = "Replace \'_\' by space";
      // 
      // chkReplace20Space
      // 
      this.chkReplace20Space.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkReplace20Space.Location = new System.Drawing.Point(16, 48);
      this.chkReplace20Space.Name = "chkReplace20Space";
      this.chkReplace20Space.Size = new System.Drawing.Size(208, 16);
      this.chkReplace20Space.TabIndex = 14;
      this.chkReplace20Space.Text = "Replace \'%20\' by space";
      // 
      // txtSeparator
      // 
      this.txtSeparator.Location = new System.Drawing.Point(96, 22);
      this.txtSeparator.Name = "txtSeparator";
      this.txtSeparator.Size = new System.Drawing.Size(64, 20);
      this.txtSeparator.TabIndex = 13;
      // 
      // chkSeparator
      // 
      this.chkSeparator.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkSeparator.Location = new System.Drawing.Point(16, 24);
      this.chkSeparator.Name = "chkSeparator";
      this.chkSeparator.Size = new System.Drawing.Size(80, 16);
      this.chkSeparator.TabIndex = 12;
      this.chkSeparator.Text = "&Separator:";
      // 
      // frameMethod
      // 
      this.frameMethod.BackColor = System.Drawing.Color.Transparent;
      this.frameMethod.Controls.Add(this.optAllFirstUp);
      this.frameMethod.Controls.Add(this.optFirstUp);
      this.frameMethod.Controls.Add(this.optAllUp);
      this.frameMethod.Controls.Add(this.optAllLow);
      this.frameMethod.Location = new System.Drawing.Point(198, 55);
      this.frameMethod.Name = "frameMethod";
      this.frameMethod.Size = new System.Drawing.Size(240, 120);
      this.frameMethod.TabIndex = 29;
      this.frameMethod.TabStop = false;
      this.frameMethod.Text = "Convert method";
      // 
      // optAllFirstUp
      // 
      this.optAllFirstUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optAllFirstUp.Location = new System.Drawing.Point(16, 96);
      this.optAllFirstUp.Name = "optAllFirstUp";
      this.optAllFirstUp.Size = new System.Drawing.Size(216, 16);
      this.optAllFirstUp.TabIndex = 11;
      this.optAllFirstUp.Text = "A&ll first letters uppercase";
      // 
      // optFirstUp
      // 
      this.optFirstUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optFirstUp.Location = new System.Drawing.Point(16, 72);
      this.optFirstUp.Name = "optFirstUp";
      this.optFirstUp.Size = new System.Drawing.Size(216, 16);
      this.optFirstUp.TabIndex = 10;
      this.optFirstUp.Text = "&First letter uppercase";
      // 
      // optAllUp
      // 
      this.optAllUp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optAllUp.Location = new System.Drawing.Point(16, 48);
      this.optAllUp.Name = "optAllUp";
      this.optAllUp.Size = new System.Drawing.Size(216, 16);
      this.optAllUp.TabIndex = 9;
      this.optAllUp.Text = "All &uppercase";
      // 
      // optAllLow
      // 
      this.optAllLow.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optAllLow.Location = new System.Drawing.Point(16, 24);
      this.optAllLow.Name = "optAllLow";
      this.optAllLow.Size = new System.Drawing.Size(216, 16);
      this.optAllLow.TabIndex = 8;
      this.optAllLow.Text = "All &lowercase";
      // 
      // tabPage4
      // 
      this.tabPage4.Controls.Add(this.lstExceptions);
      this.tabPage4.Controls.Add(this.btnAdd);
      this.tabPage4.Controls.Add(this.btnRemove);
      this.tabPage4.Controls.Add(this.lblInfo);
      this.tabPage4.Controls.Add(this.txtException);
      this.tabPage4.Location = new System.Drawing.Point(4, 22);
      this.tabPage4.Name = "tabPage4";
      this.tabPage4.Padding = new System.Windows.Forms.Padding(3);
      this.tabPage4.Size = new System.Drawing.Size(442, 310);
      this.tabPage4.TabIndex = 1;
      this.tabPage4.Text = "Exceptions";
      this.tabPage4.UseVisualStyleBackColor = true;
      // 
      // lstExceptions
      // 
      this.lstExceptions.Location = new System.Drawing.Point(6, 38);
      this.lstExceptions.Name = "lstExceptions";
      this.lstExceptions.Size = new System.Drawing.Size(200, 264);
      this.lstExceptions.TabIndex = 49;
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
      this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAdd.Location = new System.Drawing.Point(214, 38);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(216, 24);
      this.btnAdd.TabIndex = 47;
      this.btnAdd.Text = "&Add";
      this.btnAdd.UseVisualStyleBackColor = false;
      // 
      // btnRemove
      // 
      this.btnRemove.BackColor = System.Drawing.SystemColors.Control;
      this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemove.Location = new System.Drawing.Point(214, 70);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(216, 24);
      this.btnRemove.TabIndex = 48;
      this.btnRemove.Text = "&Remove";
      this.btnRemove.UseVisualStyleBackColor = false;
      // 
      // lblInfo
      // 
      this.lblInfo.BackColor = System.Drawing.Color.Transparent;
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(214, 246);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(216, 56);
      this.lblInfo.TabIndex = 50;
      this.lblInfo.Text = "All the words in the list will always be written in the casing you entered here.";
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // txtException
      // 
      this.txtException.Location = new System.Drawing.Point(6, 6);
      this.txtException.Name = "txtException";
      this.txtException.Size = new System.Drawing.Size(424, 20);
      this.txtException.TabIndex = 46;
      // 
      // btnOK
      // 
      this.btnOK.BackColor = System.Drawing.SystemColors.Control;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(216, 344);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(112, 24);
      this.btnOK.TabIndex = 1;
      this.btnOK.Text = "&OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(336, 344);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(112, 24);
      this.btnCancel.TabIndex = 2;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      // 
      // frmCaseConv
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(452, 375);
      this.ControlBox = false;
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.tabControl1);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmCaseConv";
      this.ShowInTaskbar = false;
      this.Text = "Case Conversion";
      this.tabControl1.ResumeLayout(false);
      this.tabPage3.ResumeLayout(false);
      this.frameTAGOptions.ResumeLayout(false);
      this.frameOptions.ResumeLayout(false);
      this.frameOptions.PerformLayout();
      this.frameMethod.ResumeLayout(false);
      this.tabPage4.ResumeLayout(false);
      this.tabPage4.PerformLayout();
      this.ResumeLayout(false);

    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    public frmCaseConv(frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmCaseConv_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion
  }
}