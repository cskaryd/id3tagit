using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmOrganize : Form
  {
    #region Designer

    private Button btnAdd;
    private Button btnBrowse;
    private Button btnCancel;
    private Button btnOK;
    private Button btnRemove;
    private CheckBox chkCopy;
    private CheckBox chkOverwrite;
    private ComboBox cmbFormat;
    private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
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
    private Label lblPath;
    private RadioButton optID3V1;
    private RadioButton optID3V2;
    private System.Windows.Forms.ToolTip ToolTip;
    private NumericUpDown txtDigits;
    private TextBox txtPath;
    private IContainer components;
    private frmMain MainForm;

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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmOrganize));
      this.lblPath = new System.Windows.Forms.Label();
      this.lblFormat = new System.Windows.Forms.Label();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.btnBrowse = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.cmbFormat = new System.Windows.Forms.ComboBox();
      this.btnAdd = new System.Windows.Forms.Button();
      this.btnRemove = new System.Windows.Forms.Button();
      this.framePara = new System.Windows.Forms.GroupBox();
      this.L19 = new System.Windows.Forms.Label();
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
      this.L18 = new System.Windows.Forms.Label();
      this.lblDigits = new System.Windows.Forms.Label();
      this.optID3V2 = new System.Windows.Forms.RadioButton();
      this.optID3V1 = new System.Windows.Forms.RadioButton();
      this.txtDigits = new System.Windows.Forms.NumericUpDown();
      this.lblInfo = new System.Windows.Forms.Label();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.chkOverwrite = new System.Windows.Forms.CheckBox();
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.chkCopy = new System.Windows.Forms.CheckBox();
      this.framePara.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).BeginInit();
      this.SuspendLayout();
      // 
      // lblPath
      // 
      this.lblPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPath.Location = new System.Drawing.Point(8, 8);
      this.lblPath.Name = "lblPath";
      this.lblPath.Size = new System.Drawing.Size(96, 16);
      this.lblPath.TabIndex = 0;
      this.lblPath.Text = "&Root-Path:";
      // 
      // lblFormat
      // 
      this.lblFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblFormat.Location = new System.Drawing.Point(8, 40);
      this.lblFormat.Name = "lblFormat";
      this.lblFormat.Size = new System.Drawing.Size(96, 16);
      this.lblFormat.TabIndex = 3;
      this.lblFormat.Text = "&Format:";
      // 
      // txtPath
      // 
      this.txtPath.Location = new System.Drawing.Point(104, 6);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(304, 20);
      this.txtPath.TabIndex = 1;
      this.txtPath.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtPath_KeyPress);
      // 
      // btnBrowse
      // 
      this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnBrowse.Location = new System.Drawing.Point(416, 4);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(88, 24);
      this.btnBrowse.TabIndex = 2;
      this.btnBrowse.Text = "&Browse ...";
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(384, 376);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 18;
      this.btnCancel.Text = "&Cancel";
      // 
      // btnOK
      // 
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(256, 376);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 17;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // cmbFormat
      // 
      this.cmbFormat.ItemHeight = 13;
      this.cmbFormat.Location = new System.Drawing.Point(104, 32);
      this.cmbFormat.Name = "cmbFormat";
      this.cmbFormat.Size = new System.Drawing.Size(400, 21);
      this.cmbFormat.TabIndex = 4;
      this.cmbFormat.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.cmbFormat_KeyPress);
      // 
      // btnAdd
      // 
      this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAdd.Location = new System.Drawing.Point(104, 56);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(192, 24);
      this.btnAdd.TabIndex = 5;
      this.btnAdd.Text = "&Add format to list";
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // btnRemove
      // 
      this.btnRemove.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemove.Location = new System.Drawing.Point(312, 56);
      this.btnRemove.Name = "btnRemove";
      this.btnRemove.Size = new System.Drawing.Size(192, 24);
      this.btnRemove.TabIndex = 6;
      this.btnRemove.Text = "&Remove format from list";
      this.btnRemove.Click += new System.EventHandler(this.btnRemove_Click);
      // 
      // framePara
      // 
      this.framePara.Controls.Add(this.L19);
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
      this.framePara.Controls.Add(this.L18);
      this.framePara.Location = new System.Drawing.Point(8, 144);
      this.framePara.Name = "framePara";
      this.framePara.Size = new System.Drawing.Size(496, 136);
      this.framePara.TabIndex = 11;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      // 
      // L19
      // 
      this.L19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L19.Location = new System.Drawing.Point(8, 112);
      this.L19.Name = "L19";
      this.L19.Size = new System.Drawing.Size(152, 16);
      this.L19.TabIndex = 56;
      this.L19.Text = "<I> = Bitrate";
      this.L19.Click += new System.EventHandler(this.Label_Click);
      // 
      // L20
      // 
      this.L20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L20.Location = new System.Drawing.Point(168, 112);
      this.L20.Name = "L20";
      this.L20.Size = new System.Drawing.Size(152, 16);
      this.L20.TabIndex = 55;
      this.L20.Text = "\\ = Folder";
      // 
      // L13
      // 
      this.L13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L13.Location = new System.Drawing.Point(8, 80);
      this.L13.Name = "L13";
      this.L13.Size = new System.Drawing.Size(152, 16);
      this.L13.TabIndex = 54;
      this.L13.Text = "<R> = Composer";
      this.L13.Click += new System.EventHandler(this.Label_Click);
      // 
      // L16
      // 
      this.L16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L16.Location = new System.Drawing.Point(8, 96);
      this.L16.Name = "L16";
      this.L16.Size = new System.Drawing.Size(152, 16);
      this.L16.TabIndex = 53;
      this.L16.Text = "<E> = Beats/minute (BPM)";
      this.L16.Click += new System.EventHandler(this.Label_Click);
      // 
      // L15
      // 
      this.L15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L15.Location = new System.Drawing.Point(328, 80);
      this.L15.Name = "L15";
      this.L15.Size = new System.Drawing.Size(160, 16);
      this.L15.TabIndex = 52;
      this.L15.Text = "<O> = Band / Orchestra";
      this.L15.Click += new System.EventHandler(this.Label_Click);
      // 
      // L14
      // 
      this.L14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L14.Location = new System.Drawing.Point(168, 80);
      this.L14.Name = "L14";
      this.L14.Size = new System.Drawing.Size(160, 16);
      this.L14.TabIndex = 51;
      this.L14.Text = "<S> = Subtitle";
      this.L14.Click += new System.EventHandler(this.Label_Click);
      // 
      // L17
      // 
      this.L17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L17.Location = new System.Drawing.Point(168, 96);
      this.L17.Name = "L17";
      this.L17.Size = new System.Drawing.Size(160, 16);
      this.L17.TabIndex = 50;
      this.L17.Text = "<M> = Modified / Remixed by";
      this.L17.Click += new System.EventHandler(this.Label_Click);
      // 
      // L12
      // 
      this.L12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L12.Location = new System.Drawing.Point(328, 64);
      this.L12.Name = "L12";
      this.L12.Size = new System.Drawing.Size(160, 16);
      this.L12.TabIndex = 49;
      this.L12.Text = "<N> = Conductor";
      this.L12.Click += new System.EventHandler(this.Label_Click);
      // 
      // L11
      // 
      this.L11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L11.Location = new System.Drawing.Point(168, 64);
      this.L11.Name = "L11";
      this.L11.Size = new System.Drawing.Size(160, 16);
      this.L11.TabIndex = 48;
      this.L11.Text = "<p> = Total number of medias";
      this.L11.Click += new System.EventHandler(this.Label_Click);
      // 
      // L10
      // 
      this.L10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L10.Location = new System.Drawing.Point(8, 64);
      this.L10.Name = "L10";
      this.L10.Size = new System.Drawing.Size(160, 16);
      this.L10.TabIndex = 47;
      this.L10.Text = "<P> = Position in media set";
      this.L10.Click += new System.EventHandler(this.Label_Click);
      // 
      // L9
      // 
      this.L9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L9.Location = new System.Drawing.Point(328, 48);
      this.L9.Name = "L9";
      this.L9.Size = new System.Drawing.Size(160, 16);
      this.L9.TabIndex = 46;
      this.L9.Text = "<U> = Content Group";
      this.L9.Click += new System.EventHandler(this.Label_Click);
      // 
      // L8
      // 
      this.L8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L8.Location = new System.Drawing.Point(168, 48);
      this.L8.Name = "L8";
      this.L8.Size = new System.Drawing.Size(160, 16);
      this.L8.TabIndex = 45;
      this.L8.Text = "<k> = Total number of tracks";
      this.L8.Click += new System.EventHandler(this.Label_Click);
      // 
      // L7
      // 
      this.L7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L7.Location = new System.Drawing.Point(8, 48);
      this.L7.Name = "L7";
      this.L7.Size = new System.Drawing.Size(160, 16);
      this.L7.TabIndex = 44;
      this.L7.Text = "<K> = Track number";
      this.L7.Click += new System.EventHandler(this.Label_Click);
      // 
      // L6
      // 
      this.L6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L6.Location = new System.Drawing.Point(328, 32);
      this.L6.Name = "L6";
      this.L6.Size = new System.Drawing.Size(160, 16);
      this.L6.TabIndex = 43;
      this.L6.Text = "<G> = First Genre";
      this.L6.Click += new System.EventHandler(this.Label_Click);
      // 
      // L5
      // 
      this.L5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L5.Location = new System.Drawing.Point(168, 32);
      this.L5.Name = "L5";
      this.L5.Size = new System.Drawing.Size(160, 16);
      this.L5.TabIndex = 42;
      this.L5.Text = "<Y> = Year";
      this.L5.Click += new System.EventHandler(this.Label_Click);
      // 
      // L4
      // 
      this.L4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L4.Location = new System.Drawing.Point(8, 32);
      this.L4.Name = "L4";
      this.L4.Size = new System.Drawing.Size(160, 16);
      this.L4.TabIndex = 41;
      this.L4.Text = "<C> = Comment";
      this.L4.Click += new System.EventHandler(this.Label_Click);
      // 
      // L3
      // 
      this.L3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L3.Location = new System.Drawing.Point(328, 16);
      this.L3.Name = "L3";
      this.L3.Size = new System.Drawing.Size(160, 16);
      this.L3.TabIndex = 40;
      this.L3.Text = "<B> = Album";
      this.L3.Click += new System.EventHandler(this.Label_Click);
      // 
      // L2
      // 
      this.L2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L2.Location = new System.Drawing.Point(168, 16);
      this.L2.Name = "L2";
      this.L2.Size = new System.Drawing.Size(160, 16);
      this.L2.TabIndex = 39;
      this.L2.Text = "<T> = Title";
      this.L2.Click += new System.EventHandler(this.Label_Click);
      // 
      // L1
      // 
      this.L1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L1.Location = new System.Drawing.Point(8, 16);
      this.L1.Name = "L1";
      this.L1.Size = new System.Drawing.Size(160, 16);
      this.L1.TabIndex = 38;
      this.L1.Text = "<A> = Artist";
      this.L1.Click += new System.EventHandler(this.Label_Click);
      // 
      // L18
      // 
      this.L18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L18.Location = new System.Drawing.Point(328, 96);
      this.L18.Name = "L18";
      this.L18.Size = new System.Drawing.Size(152, 16);
      this.L18.TabIndex = 16;
      this.L18.Text = "<1> = First letter of artist";
      this.L18.Click += new System.EventHandler(this.Label_Click);
      // 
      // lblDigits
      // 
      this.lblDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDigits.Location = new System.Drawing.Point(104, 112);
      this.lblDigits.Name = "lblDigits";
      this.lblDigits.Size = new System.Drawing.Size(184, 16);
      this.lblDigits.TabIndex = 9;
      this.lblDigits.Text = "&Number of digits of track numbers:";
      // 
      // optID3V2
      // 
      this.optID3V2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optID3V2.Location = new System.Drawing.Point(312, 88);
      this.optID3V2.Name = "optID3V2";
      this.optID3V2.Size = new System.Drawing.Size(168, 16);
      this.optID3V2.TabIndex = 8;
      this.optID3V2.Text = "Use Ver. &2 TAG information";
      // 
      // optID3V1
      // 
      this.optID3V1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optID3V1.Location = new System.Drawing.Point(104, 88);
      this.optID3V1.Name = "optID3V1";
      this.optID3V1.Size = new System.Drawing.Size(168, 16);
      this.optID3V1.TabIndex = 7;
      this.optID3V1.Text = "Use Ver. &1 TAG information";
      this.optID3V1.CheckedChanged += new System.EventHandler(this.optID3V1_CheckedChanged);
      // 
      // txtDigits
      // 
      this.txtDigits.Location = new System.Drawing.Point(312, 110);
      this.txtDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Name = "txtDigits";
      this.txtDigits.Size = new System.Drawing.Size(64, 20);
      this.txtDigits.TabIndex = 10;
      this.txtDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Validated += new System.EventHandler(this.txtDigits_Validated);
      // 
      // lblInfo
      // 
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(8, 288);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(496, 48);
      this.lblInfo.TabIndex = 12;
      this.lblInfo.Text = resources.GetString("lblInfo.Text");
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // chkOverwrite
      // 
      this.chkOverwrite.Checked = true;
      this.chkOverwrite.CheckState = System.Windows.Forms.CheckState.Checked;
      this.chkOverwrite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkOverwrite.Location = new System.Drawing.Point(16, 348);
      this.chkOverwrite.Name = "chkOverwrite";
      this.chkOverwrite.Size = new System.Drawing.Size(224, 16);
      this.chkOverwrite.TabIndex = 15;
      this.chkOverwrite.Text = "Overwrite existing files";
      // 
      // chkCopy
      // 
      this.chkCopy.Location = new System.Drawing.Point(264, 348);
      this.chkCopy.Name = "chkCopy";
      this.chkCopy.Size = new System.Drawing.Size(232, 16);
      this.chkCopy.TabIndex = 16;
      this.chkCopy.Text = "Copy the files instead of moving them";
      // 
      // frmOrganize
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(514, 408);
      this.ControlBox = false;
      this.Controls.Add(this.chkCopy);
      this.Controls.Add(this.chkOverwrite);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.lblDigits);
      this.Controls.Add(this.optID3V2);
      this.Controls.Add(this.optID3V1);
      this.Controls.Add(this.txtDigits);
      this.Controls.Add(this.framePara);
      this.Controls.Add(this.btnRemove);
      this.Controls.Add(this.btnAdd);
      this.Controls.Add(this.cmbFormat);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.lblPath);
      this.Controls.Add(this.lblFormat);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmOrganize";
      this.ShowInTaskbar = false;
      this.Text = "Organize files";
      this.framePara.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public frmOrganize(frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmOrganize_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

    #region Events

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.cmbFormat.Text, "", false) != 0)
        this.cmbFormat.Items.Add(this.cmbFormat.Text);
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      string selectedPath = "";
      this.FolderBrowserDialog.Description = StringType.FromObject(Declarations.objResources.ResStrings["FileMoveText"]);
      this.FolderBrowserDialog.SelectedPath = Declarations.objSettings.OrganizePath;

      if (this.FolderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
      {
        selectedPath = this.FolderBrowserDialog.SelectedPath;
        this.txtPath.Text = selectedPath;
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      string vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });
      string vstrName = this.txtPath.Text.Trim(new char[] { ' ' });

      if (!vstrName.EndsWith(@"\"))
        vstrName = vstrName + @"\";

      if (vstrFormat.IndexOf(":") >= 0)
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });

      if (vstrFormat.StartsWith(@"\"))
        vstrFormat = vstrFormat.Substring(1);

      if (!Id3TagIT_Main.CheckFilename(vstrName, true))
      {
        this.DialogResult = System.Windows.Forms.DialogResult.None;
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidCharPath"]), MsgBoxStyle.Exclamation, null);
      }
      else
      {
        switch (ID3Functions.FormatReplaceCheck(vstrFormat, (Declarations.FormatReplace)IntegerType.FromObject(ObjectType.BitOrObj(Interaction.IIf(this.optID3V1.Checked, Declarations.FormatReplace.TAGVer1, Declarations.FormatReplace.TAGVer2), Declarations.FormatReplace.OrganizeFiles))))
        {
          case Declarations.FormatReplaceFeedback.InvalidFormat:
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidFormat"]), MsgBoxStyle.Exclamation, null);
            return;

          case Declarations.FormatReplaceFeedback.InvalidCharFormat:
            this.DialogResult = System.Windows.Forms.DialogResult.None;
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidCharFormat"]), MsgBoxStyle.Exclamation, null);
            return;
        }

        if (!Directory.Exists(vstrName))
        {
          this.DialogResult = System.Windows.Forms.DialogResult.None;
          Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidPath"]), MsgBoxStyle.Exclamation, null);
        }
        else
        {
          Form form = this;
          Id3TagIT_Main.SaveFormSettings(ref form);
          byte tracknumberDigitsFilename = Declarations.objSettings.TracknumberDigitsFilename;
          Declarations.objSettings.OrganizeFormats.Rows.Clear();
          Declarations.objSettings.OrganizePath = vstrName;
          Declarations.objSettings.OrganizeFormat = this.cmbFormat.Text;
          Declarations.objSettings.OrganizeOverwrite = this.chkOverwrite.Checked;
          Declarations.objSettings.OrganizeCopy = this.chkCopy.Checked;
          Declarations.objSettings.OrganizeVersion = ByteType.FromObject(Interaction.IIf(this.optID3V1.Checked, 1, 2));
          Declarations.objSettings.TracknumberDigitsFilename = Convert.ToByte(this.txtDigits.Value);
          int num3 = this.cmbFormat.Items.Count - 1;

          for (int i = 0; i <= num3; i++)
          {
            DataRow row = Declarations.objSettings.OrganizeFormats.NewRow();
            row["Format"] = this.cmbFormat.Items[i].ToString();
            Declarations.objSettings.OrganizeFormats.Rows.Add(row);
          }

          form = this;
          frmProgress.Callback cB = new frmProgress.Callback(this.OrganizeCB);
          frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref form, ref cB);
          progress.SetStateOrganize();
          progress.String01 = vstrFormat;
          progress.String02 = vstrName;
          progress.ShowDialog(this);
          Declarations.objSettings.TracknumberDigitsFilename = tracknumberDigitsFilename;
          this.DialogResult = System.Windows.Forms.DialogResult.OK;
          this.Close();
        }
      }
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      this.cmbFormat.Items.Remove(this.cmbFormat.Text);
    }

    private void cmbFormat_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '|':
        case '"':
        case '/':
        case '*':
        case '?':
          e.Handled = true;
          this.cmbFormat.Text = this.cmbFormat.Text.Remove(this.cmbFormat.Text.Length - 1, 1);
          this.cmbFormat.SelectionStart = this.cmbFormat.Text.Length;
          break;
      }
    }

    private void frmOrganize_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      int num2 = Declarations.objSettings.OrganizeFormats.Rows.Count - 1;

      for (int i = 0; i <= num2; i++)
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.OrganizeFormats.Rows[i]["Format"]));

      this.cmbFormat.Text = Declarations.objSettings.OrganizeFormat;
      this.txtPath.Text = Declarations.objSettings.OrganizePath;
      this.chkOverwrite.Checked = Declarations.objSettings.OrganizeOverwrite;
      this.chkCopy.Checked = Declarations.objSettings.OrganizeCopy;

      if (Declarations.objSettings.OrganizeVersion == 1)
        this.optID3V1.Checked = true;
      else
        this.optID3V2.Checked = true;

      this.txtDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsFilename);
      this.AddToolTips();
    }

    private void Label_Click(object sender, EventArgs e)
    {
      string selectedText = this.cmbFormat.SelectedText;
      int selectionStart = this.cmbFormat.SelectionStart;

      if (this.cmbFormat.SelectionLength == 0)
      {
        this.cmbFormat.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(this.cmbFormat.Text.Substring(0, this.cmbFormat.SelectionStart), LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 3 }, null, null)), this.cmbFormat.Text.Substring(this.cmbFormat.SelectionStart)));
        this.cmbFormat.SelectionStart = selectionStart + 3;
      }
      else
      {
        string str2 = this.cmbFormat.Text.Substring(0, selectionStart);
        this.cmbFormat.Text = Strings.Replace(this.cmbFormat.Text, selectedText, StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), null, "Substring", new object[] { 0, 3 }, null, null)), selectionStart + 1, 1, CompareMethod.Text);
        this.cmbFormat.Text = str2 + this.cmbFormat.Text;
        this.cmbFormat.SelectionStart = selectionStart + 3;
      }
    }

    private void optID3V1_CheckedChanged(object sender, EventArgs e)
    {
      var viz = !BooleanType.FromObject(LateBinding.LateGet(sender, null, "checked", new object[0], null, null));

      this.L8.Visible = viz;
      this.L9.Visible = viz;
      this.L10.Visible = viz;
      this.L11.Visible = viz;
      this.L12.Visible = viz;
      this.L13.Visible = viz;
      this.L14.Visible = viz;
      this.L15.Visible = viz;
      this.L16.Visible = viz;
      this.L17.Visible = viz;
    }

    private void txtDigits_Validated(object sender, EventArgs e)
    {
      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Minimum) < 0)
        this.txtDigits.Value = this.txtDigits.Minimum;

      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Maximum) > 0)
        this.txtDigits.Value = this.txtDigits.Maximum;
    }

    private void txtPath_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '<':
        case '>':
        case '|':
        case '"':
        case '/':
        case '*':
        case '?':
          e.Handled = true;
          break;
      }
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmOrganize";
      Control txtPath = this.txtPath;
      this.txtPath = (TextBox)txtPath;
      this.ToolTip.SetToolTip(this.txtPath, Declarations.objResources.GetToolTip(ref vstrName, ref txtPath));

      vstrName = "frmOrganize";
      txtPath = this.btnBrowse;
      this.btnBrowse = (Button)txtPath;
      this.ToolTip.SetToolTip(this.btnBrowse, Declarations.objResources.GetToolTip(ref vstrName, ref txtPath));

      vstrName = "frmOrganize";
      txtPath = this.cmbFormat;
      this.cmbFormat = (ComboBox)txtPath;
      this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref txtPath));

      vstrName = "frmOrganize";
      txtPath = this.btnAdd;
      this.btnAdd = (Button)txtPath;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref txtPath));

      vstrName = "frmOrganize";
      txtPath = this.btnRemove;
      this.btnRemove = (Button)txtPath;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref txtPath));

      vstrName = "frmOrganize";
      txtPath = this.optID3V2;
      this.optID3V2 = (RadioButton)txtPath;
      this.ToolTip.SetToolTip(this.optID3V2, Declarations.objResources.GetToolTip(ref vstrName, ref txtPath));

      vstrName = "frmOrganize";
      txtPath = this.optID3V1;
      this.optID3V1 = (RadioButton)txtPath;
      this.ToolTip.SetToolTip(this.optID3V1, Declarations.objResources.GetToolTip(ref vstrName, ref txtPath));

      vstrName = "frmOrganize";
      txtPath = this.txtDigits;
      this.txtDigits = (NumericUpDown)txtPath;
      this.ToolTip.SetToolTip(this.txtDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtPath));
    }

    private void OrganizeCB(ref frmProgress frmProg)
    {
      string vstrFormat = frmProg.String01;
      string str5 = frmProg.String02;

      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
          break;

        MP3 tag = (MP3)item.Tag;
        frmProg.Infos.Text = tag.CurrentFullName;
        string path = ID3Functions.FormatReplacedByTag(tag, vstrFormat, Declarations.objSettings.OrganizeVersion);
        if (!path.EndsWith(@"\"))
          path = path + @"\";

        path = path.Trim(new char[] { ' ' }).Replace("<", "_").Replace(">", "_").Replace("|", "_").Replace("\"", "_").Replace("/", "_").Replace("*", "_").Replace("?", "_").Replace(":", "_");
        path = str5 + path;

        while ((path.IndexOf(@"\\") > 0) | (path.IndexOf(@"\ \") > 0))
          path = path.Replace(@"\\", @"\").Replace(@"\ \", @"\");

        if ((path + tag.FI.Name).Length <= 0xff)
        {
          string fullName = tag.FI.FullName;
          string str = path + tag.FI.Name;

          if (StringType.StrCmp(fullName.ToLower(), str.ToLower(), false) != 0)
          {
            try
            {
              if (!Directory.Exists(path))
                Directory.CreateDirectory(path);

              if (Directory.Exists(path))
              {
                if (File.Exists(str))
                {
                  if (this.chkOverwrite.Checked)
                  {
                    File.Delete(str);
                    Application.DoEvents();

                    if (this.chkCopy.Checked)
                      File.Copy(fullName, str);
                    else
                      File.Move(fullName, str);
                  }
                }
                else if (this.chkCopy.Checked)
                  File.Copy(fullName, str);
                else
                  File.Move(fullName, str);
              }
            }
            catch (Exception exception1)
            {
              ProjectData.SetProjectError(exception1);
              Exception exception = exception1;
              ListViewItem item2 = new ListViewItem
              {
                Text = StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)),
                SubItems = { exception.Message }
              };
              this.MainForm.ErrorMsg.Items.Insert(0, item2);
              // FIXME - exp this.MainForm.SplitterBottom.Expanded = true;
              ProjectData.ClearProjectError();
            }
          }
        }
        else
        {
          ListViewItem item3 = new ListViewItem
          {
            Text = StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null))
          };
          object[] objArray2 = new object[1];
          DataRow resStrings = Declarations.objResources.ResStrings;
          string str6 = "InvalidPathLength";
          objArray2[0] = RuntimeHelpers.GetObjectValue(resStrings[str6]);
          object[] args = objArray2;
          bool[] copyBack = new bool[] { true };
          LateBinding.LateCall(item3.SubItems, null, "Add", args, null, copyBack);
          if (copyBack[0])
            resStrings[str6] = RuntimeHelpers.GetObjectValue(args[0]);
          this.MainForm.ErrorMsg.Items.Insert(0, item3);
          // FIXME - exp this.MainForm.SplitterBottom.Expanded = true;
        }
        frmProg.ProgressBar.PerformStep();
      }
    }

    #endregion
  }
}