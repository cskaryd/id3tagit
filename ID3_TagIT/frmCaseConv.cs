using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Text.RegularExpressions;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmCaseConv : Form
  {
    #region Designer

    private System.Windows.Forms.ToolTip ToolTip;
    private IContainer components;
    private frmMain MainForm;
    private System.Windows.Forms.TabControl tabControl1;
    private TabPage tabPage3;
    private TabPage tabPage4;
    private GroupBox frameTAGOptions;
    private CheckBox chkArtist;
    private CheckBox chkTitle;
    private CheckBox chkAlbum;
    private CheckBox chkComment;
    private CheckBox chkFilename;
    private CheckBox chkVer2;
    private CheckBox chkVer1;
    private GroupBox frameOptions;
    private CheckBox chkAlwaysFirst;
    private CheckBox chkReplaceSpaceUnder;
    private CheckBox chkReplaceSpace20;
    private CheckBox chkReplaceUnderSpace;
    private CheckBox chkReplace20Space;
    private TextBox txtSeparator;
    private CheckBox chkSeparator;
    private GroupBox frameMethod;
    private RadioButton optAllFirstUp;
    private RadioButton optFirstUp;
    private RadioButton optAllUp;
    private RadioButton optAllLow;
    private ListBox lstExceptions;
    private Button btnAdd;
    private Button btnRemove;
    private Label lblInfo;
    private TextBox txtException;
    private Button btnOK;
    private Button btnCancel;

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

    public frmCaseConv(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmCaseConv_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

    #region Local variables

    private string vstrExcep;

    #endregion

    #region Events

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.txtException.Text, "", false) != 0)
      {
        foreach (DataRow row in Declarations.objSettings.Exceptions.Rows)
          if (ObjectType.ObjTst(row["Name"], this.txtException.Text.Trim(new char[] { CharType.FromString(Strings.Space(1)) }), false) == 0)
            return;

        DataRow row2 = Declarations.objSettings.Exceptions.NewRow();
        row2["Name"] = this.txtException.Text.Trim(new char[] { CharType.FromString(Strings.Space(1)) });
        Declarations.objSettings.Exceptions.Rows.Add(row2);
        this.txtException.Text = "";
        this.txtException.Focus();
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      ArrayList list = new ArrayList();
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      Declarations.objSettings.ConvertFilename = this.chkFilename.Checked;
      Declarations.objSettings.ConvertVer1 = this.chkVer1.Checked;
      Declarations.objSettings.ConvertVer2 = this.chkVer2.Checked;
      Declarations.objSettings.ConvertArtist = this.chkArtist.Checked;
      Declarations.objSettings.ConvertTitle = this.chkTitle.Checked;
      Declarations.objSettings.ConvertAlbum = this.chkAlbum.Checked;
      Declarations.objSettings.ConvertComment = this.chkComment.Checked;
      Declarations.objSettings.ConvertSeparat = this.chkSeparator.Checked;
      Declarations.objSettings.ConvertSeparator = this.txtSeparator.Text;

      if (this.optAllLow.Checked)
        Declarations.objSettings.ConvertMethod = 1;
      if (this.optAllUp.Checked)
        Declarations.objSettings.ConvertMethod = 2;
      if (this.optFirstUp.Checked)
        Declarations.objSettings.ConvertMethod = 3;
      if (this.optAllFirstUp.Checked)
        Declarations.objSettings.ConvertMethod = 4;

      Declarations.objSettings.ConvertReplaceSpace20 = this.chkReplaceSpace20.Checked;
      Declarations.objSettings.ConvertReplaceSpaceUnder = this.chkReplaceSpaceUnder.Checked;
      Declarations.objSettings.ConvertReplace20Space = this.chkReplace20Space.Checked;
      Declarations.objSettings.ConvertReplaceUnderSpace = this.chkReplaceUnderSpace.Checked;
      Declarations.objSettings.ConvertAlwaysFirst = this.chkAlwaysFirst.Checked;
      form = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.CaseConvertCB);
      frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref form, ref cB);
      progress.SetStateCaseConv();
      progress.List = list;
      this.MainForm.MP3View.BeginUpdate();

      if ((this.chkFilename.Checked | this.chkVer1.Checked) | this.chkVer2.Checked)
        progress.ShowDialog(this);

      this.MainForm.MP3View.EndUpdate();

      if (list.Count > 0)
      {
        Declarations.UNDOList.Add(list);
        this.MainForm.UnDoEnable(true, true);
      }

      progress.Close();
      this.Close();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      if (this.lstExceptions.SelectedItem != null)
        foreach (DataRow row in Declarations.objSettings.Exceptions.Rows)
          if (ObjectType.ObjTst(row["Name"], this.lstExceptions.SelectedValue, false) == 0)
          {
            Declarations.objSettings.Exceptions.Rows.Remove(row);
            break;
          }
    }

    private void chkReplaceSpace_CheckedChanged(object sender, EventArgs e)
    {
      if (!BooleanType.FromObject(ObjectType.NotObj(LateBinding.LateGet(sender, null, "Checked", new object[0], null, null))))
        if (ObjectType.ObjTst(LateBinding.LateGet(sender, null, "Name", new object[0], null, null), "chkReplaceSpace20", false) == 0)
          this.chkReplaceSpaceUnder.Checked = !this.chkReplaceSpace20.Checked;
        else
          this.chkReplaceSpace20.Checked = !this.chkReplaceSpaceUnder.Checked;
    }

    private void chkVer_CheckedChanged(object sender, EventArgs e)
    {
      if (!Declarations.objSettings.SynchronizeTAGs)
        return;

      if (sender == this.chkVer1)
      {
        if (this.chkVer1.Checked)
          this.chkVer2.Checked = true;
        else
          this.chkVer2.Checked = false;

        if (this.chkVer2.Checked)
          this.chkVer1.Checked = true;
        else
          this.chkVer1.Checked = false;
      }
      else
      {
        if (this.chkVer2.Checked)
          this.chkVer1.Checked = true;
        else
          this.chkVer1.Checked = false;

        if (this.chkVer1.Checked)
          this.chkVer2.Checked = true;
        else
          this.chkVer2.Checked = false;
      }
    }

    private void frmCaseConv_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      this.lstExceptions.DataSource = Declarations.objSettings.Exceptions;
      this.lstExceptions.DisplayMember = "Name";
      this.lstExceptions.ValueMember = "Name";
      this.chkFilename.Checked = Declarations.objSettings.ConvertFilename;
      this.chkVer1.Checked = Declarations.objSettings.ConvertVer1;
      this.chkVer2.Checked = Declarations.objSettings.ConvertVer2;
      this.chkArtist.Checked = Declarations.objSettings.ConvertArtist;
      this.chkTitle.Checked = Declarations.objSettings.ConvertTitle;
      this.chkAlbum.Checked = Declarations.objSettings.ConvertAlbum;
      this.chkComment.Checked = Declarations.objSettings.ConvertComment;
      this.chkSeparator.Checked = Declarations.objSettings.ConvertSeparat;
      this.txtSeparator.Text = Declarations.objSettings.ConvertSeparator;
      switch (Declarations.objSettings.ConvertMethod)
      {
        case 1:
          this.optAllLow.Checked = true;
          break;

        case 2:
          this.optAllUp.Checked = true;
          break;

        case 3:
          this.optFirstUp.Checked = true;
          break;

        case 4:
          this.optAllFirstUp.Checked = true;
          break;
      }
      this.chkReplaceSpace20.Checked = Declarations.objSettings.ConvertReplaceSpace20;
      this.chkReplaceSpaceUnder.Checked = Declarations.objSettings.ConvertReplaceSpaceUnder;
      this.chkReplace20Space.Checked = Declarations.objSettings.ConvertReplace20Space;
      this.chkReplaceUnderSpace.Checked = Declarations.objSettings.ConvertReplaceUnderSpace;
      this.chkAlwaysFirst.Checked = Declarations.objSettings.ConvertAlwaysFirst;
      this.AddToolTips();
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmCaseConv";
      Control chkAlwaysFirst = this.chkAlwaysFirst;
      this.chkAlwaysFirst = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkAlwaysFirst, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkReplaceSpaceUnder;
      this.chkReplaceSpaceUnder = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkReplaceSpaceUnder, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkReplaceSpace20;
      this.chkReplaceSpace20 = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkReplaceSpace20, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkReplaceUnderSpace;
      this.chkReplaceUnderSpace = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkReplaceUnderSpace, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkReplace20Space;
      this.chkReplace20Space = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkReplace20Space, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.txtSeparator;
      this.txtSeparator = (TextBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.txtSeparator, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkSeparator;
      this.chkSeparator = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkSeparator, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.optAllFirstUp;
      this.optAllFirstUp = (RadioButton)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.optAllFirstUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.optFirstUp;
      this.optFirstUp = (RadioButton)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.optFirstUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.optAllUp;
      this.optAllUp = (RadioButton)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.optAllUp, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.optAllLow;
      this.optAllLow = (RadioButton)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.optAllLow, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkVer1;
      this.chkVer1 = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkVer1, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkVer2;
      this.chkVer2 = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkVer2, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkFilename;
      this.chkFilename = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkFilename, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkArtist;
      this.chkArtist = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkArtist, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkTitle;
      this.chkTitle = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkTitle, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkAlbum;
      this.chkAlbum = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.chkComment;
      this.chkComment = (CheckBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.chkComment, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.btnRemove;
      this.btnRemove = (Button)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.btnAdd;
      this.btnAdd = (Button)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.lstExceptions;
      this.lstExceptions = (ListBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.lstExceptions, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));

      vstrName = "frmCaseConv";
      chkAlwaysFirst = this.txtException;
      this.txtException = (TextBox)chkAlwaysFirst;
      this.ToolTip.SetToolTip(this.txtException, Declarations.objResources.GetToolTip(ref vstrName, ref chkAlwaysFirst));
    }

    private void CaseConvertCB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        bool flag = false;
        MP3 tag = (MP3)item.Tag;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        frmProg.Infos.Text = tag.CurrentFullName;

        if (this.chkFilename.Checked)
        {
          string sRight = this.ConvertCase(tag.CurrentName);

          if (StringType.StrCmp(tag.CurrentName, sRight, false) != 0)
          {
            string newValue = tag.CurrentFullName.Substring(0, tag.CurrentFullName.LastIndexOf(@"\") + 1) + sRight + tag.FI.Extension;

            foreach (MP3 mp in Declarations.MP3s)
            {
              if ((StringType.StrCmp(newValue.ToLower(), mp.CurrentFullName.ToLower(), false) == 0) && (mp != tag))
              {
                flag = true;
                break;
              }
            }

            if (!flag)
            {
              tag.CurrentName = sRight;
              tag.Changed = true;
            }
            else
            {
              ListViewItem item2 = new ListViewItem
              {
                Text = tag.CurrentFullName,
                SubItems = { Convert.ToString(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["FileAlreadyExistsRename"])).Replace("%1", newValue).Replace("%2", tag.CurrentFullName).Replace("%C", "") }
              };
              this.MainForm.ErrorMsg.Items.Insert(0, item2);
              this.MainForm.SplitterBottom.Expanded = true;
            }
          }
        }

        if (this.chkVer1.Checked)
        {
          if (this.chkArtist.Checked)
          {
            string str3 = this.ConvertCase(tag.V1TAG.Artist);
            if (StringType.StrCmp(tag.V1TAG.Artist, str3, false) != 0)
            {
              tag.V1TAG.Artist = str3;
              tag.Changed = true;
            }
          }

          if (this.chkAlbum.Checked)
          {
            string str4 = this.ConvertCase(tag.V1TAG.Album);
            if (StringType.StrCmp(tag.V1TAG.Album, str4, false) != 0)
            {
              tag.V1TAG.Album = str4;
              tag.Changed = true;
            }
          }

          if (this.chkTitle.Checked)
          {
            string str5 = this.ConvertCase(tag.V1TAG.Title);
            if (StringType.StrCmp(tag.V1TAG.Title, str5, false) != 0)
            {
              tag.V1TAG.Title = str5;
              tag.Changed = true;
            }
          }

          if (this.chkComment.Checked)
          {
            string str6 = this.ConvertCase(tag.V1TAG.Comment);
            if (StringType.StrCmp(tag.V1TAG.Comment, str6, false) != 0)
            {
              tag.V1TAG.Comment = str6;
              tag.Changed = true;
            }
          }
        }

        if (this.chkVer2.Checked)
        {
          if (this.chkArtist.Checked & tag.V2TAG.FrameExists("TPE1"))
          {
            string str7 = this.ConvertCase(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null)));
            if (ObjectType.ObjTst(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), str7, false) != 0)
            {
              LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[] { str7 }, null, false, true);
              tag.Changed = true;
            }
          }

          if (this.chkAlbum.Checked & tag.V2TAG.FrameExists("TALB"))
          {
            string str8 = this.ConvertCase(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null)));
            if (ObjectType.ObjTst(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), str8, false) != 0)
            {
              LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[] { str8 }, null, false, true);
              tag.Changed = true;
            }
          }

          if (this.chkTitle.Checked & tag.V2TAG.FrameExists("TIT2"))
          {
            string str9 = this.ConvertCase(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null)));
            if (ObjectType.ObjTst(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), str9, false) != 0)
            {
              LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[] { str9 }, null, false, true);
              tag.Changed = true;
            }
          }

          if (this.chkComment.Checked)
          {
            var enumerator = tag.V2TAG.GetFrames("COMM").GetEnumerator();
            while (enumerator.MoveNext())
            {
              object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
              string str10 = this.ConvertCase(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)));
              if (ObjectType.ObjTst(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), str10, false) != 0)
              {
                LateBinding.LateSet(objectValue, null, "Content", new object[] { str10 }, null);
                tag.Changed = true;
              }
            }
          }
        }

        this.MainForm.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private string ConvertCase(string vstrText)
    {
      if (vstrText.Length < 1)
        return "";

      if (this.chkReplace20Space.Checked)
        vstrText = vstrText.Replace("%20", Strings.Space(1));

      if (this.chkReplaceUnderSpace.Checked)
        vstrText = vstrText.Replace("_", Strings.Space(1));

      if (this.optAllLow.Checked)
        vstrText = vstrText.ToLower();
      else if (this.optAllUp.Checked)
        vstrText = vstrText.ToUpper();
      else if (this.optFirstUp.Checked)
      {
        int num;

        if (this.chkSeparator.Checked)
        {
          vstrText = vstrText.Replace(this.txtSeparator.Text, "\x0001");
          string[] strArray = vstrText.Split(new char[] { '\x0001' });
          vstrText = "";
          foreach (string str2 in strArray)
          {
            var ss22 = str2;
            if (StringType.StrCmp(ss22, "", false) == 0)
              continue;

            ss22 = ss22.ToLower();
            int num3 = ss22.Length - 1;
            num = 0;

            while (num <= num3)
            {
              if (StringType.StrCmp(ss22.Substring(num, 1).ToUpper(), ss22.Substring(num, 1), false) != 0)
              {
                if (num == 0)
                  ss22 = ss22.Substring(0, 1).ToUpper() + ss22.Substring(1);
                else if (num == (ss22.Length - 1))
                  ss22 = ss22.Substring(0, num) + ss22.Substring(num).ToUpper();
                else
                  ss22 = ss22.Substring(0, num) + ss22.Substring(num, 1).ToUpper() + ss22.Substring(num + 1);
                break;
              }
              num++;
            }
            vstrText = vstrText + ss22 + "\x0001";
          }
          vstrText = vstrText.TrimEnd(new char[] { '\x0001' });
          vstrText = vstrText.Replace("\x0001", this.txtSeparator.Text);
        }
        else if (StringType.StrCmp(vstrText, "", false) != 0)
        {
          vstrText = vstrText.ToLower();
          int num2 = vstrText.Length - 1;

          for (num = 0; num <= num2; num++)
          {
            if (StringType.StrCmp(vstrText.Substring(num, 1).ToUpper(), vstrText.Substring(num, 1), false) != 0)
            {
              if (num == 0)
                vstrText = vstrText.Substring(0, 1).ToUpper() + vstrText.Substring(1);
              else if (num == (vstrText.Length - 1))
                vstrText = vstrText.Substring(0, num) + vstrText.Substring(num).ToUpper();
              else
                vstrText = vstrText.Substring(0, num) + vstrText.Substring(num, 1).ToUpper() + vstrText.Substring(num + 1);

              break;
            }
          }
        }
      }
      else if (this.optAllFirstUp.Checked)
        vstrText = Strings.StrConv(vstrText, VbStrConv.ProperCase, 0);

      foreach (DataRow row in Declarations.objSettings.Exceptions.Rows)
      {
        this.vstrExcep = StringType.FromObject(row["Name"]);
        this.vstrExcep = Regex.Escape(this.vstrExcep);
        vstrText = Regex.Replace(vstrText, @"(\W|^)" + this.vstrExcep + @"(\W|$)", new MatchEvaluator(this.ReplaceCallback), RegexOptions.Singleline | RegexOptions.IgnoreCase);
      }

      if (this.chkReplaceSpace20.Checked)
        vstrText = vstrText.Replace(Strings.Space(1), "%20");

      if (this.chkReplaceSpaceUnder.Checked)
        vstrText = vstrText.Replace(Strings.Space(1), "_");

      if (this.chkAlwaysFirst.Checked)
        vstrText = vstrText.Substring(0, 1).ToUpper() + vstrText.Substring(1);

      return vstrText;
    }

    private string ReplaceCallback(Match Match)
    {
      this.vstrExcep = this.vstrExcep.Replace(@"\\", "\x0001").Replace(@"\", "").Replace("\x0001", @"\");
      return Strings.Replace(Match.Value, this.vstrExcep, this.vstrExcep, 1, -1, CompareMethod.Text);
    }

    #endregion
  }
}