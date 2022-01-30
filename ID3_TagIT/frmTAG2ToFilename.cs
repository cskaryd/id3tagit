using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmTAG2ToFilename : Form
  {
    #region Designer

    private Button btnAdd;
    private Button btnCancel;
    private Button btnOK;
    private Button btnRemove;
    private CheckBox chkRebuildName;
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
    private Label L3;
    private Label L4;
    private Label L5;
    private Label L6;
    private Label L7;
    private Label L8;
    private Label L9;
    private Label lbl1;
    private Label lbl2;
    private Label lblDigits;
    private Label lblFormat;
    private Label lblInfo;
    private System.Windows.Forms.ToolTip ToolTip;
    private NumericUpDown txtDigits;
    private NumericUpDown txtFDigits;
    private NumericUpDown txtStartNr;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTAG2ToFilename));
      this.lblInfo = new System.Windows.Forms.Label();
      this.lblDigits = new System.Windows.Forms.Label();
      this.txtDigits = new System.Windows.Forms.NumericUpDown();
      this.framePara = new System.Windows.Forms.GroupBox();
      this.L13 = new System.Windows.Forms.Label();
      this.lbl2 = new System.Windows.Forms.Label();
      this.txtFDigits = new System.Windows.Forms.NumericUpDown();
      this.lbl1 = new System.Windows.Forms.Label();
      this.txtStartNr = new System.Windows.Forms.NumericUpDown();
      this.L19 = new System.Windows.Forms.Label();
      this.L18 = new System.Windows.Forms.Label();
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
      this.chkRebuildName = new System.Windows.Forms.CheckBox();
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).BeginInit();
      this.framePara.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtFDigits)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartNr)).BeginInit();
      this.SuspendLayout();
      // 
      // lblInfo
      // 
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(8, 304);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(496, 56);
      this.lblInfo.TabIndex = 34;
      this.lblInfo.Text = resources.GetString("lblInfo.Text");
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
      this.framePara.Controls.Add(this.L13);
      this.framePara.Controls.Add(this.lbl2);
      this.framePara.Controls.Add(this.txtFDigits);
      this.framePara.Controls.Add(this.lbl1);
      this.framePara.Controls.Add(this.txtStartNr);
      this.framePara.Controls.Add(this.L19);
      this.framePara.Controls.Add(this.L18);
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
      this.framePara.Location = new System.Drawing.Point(8, 112);
      this.framePara.Name = "framePara";
      this.framePara.Size = new System.Drawing.Size(496, 185);
      this.framePara.TabIndex = 33;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
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
      // lbl2
      // 
      this.lbl2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lbl2.Location = new System.Drawing.Point(240, 154);
      this.lbl2.Name = "lbl2";
      this.lbl2.Size = new System.Drawing.Size(184, 16);
      this.lbl2.TabIndex = 35;
      this.lbl2.Text = "Number of digits";
      // 
      // txtFDigits
      // 
      this.txtFDigits.Location = new System.Drawing.Point(168, 152);
      this.txtFDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtFDigits.Name = "txtFDigits";
      this.txtFDigits.Size = new System.Drawing.Size(64, 20);
      this.txtFDigits.TabIndex = 36;
      this.txtFDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtFDigits.Validated += new System.EventHandler(this.txtDigits_Validated);
      // 
      // lbl1
      // 
      this.lbl1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lbl1.Location = new System.Drawing.Point(240, 128);
      this.lbl1.Name = "lbl1";
      this.lbl1.Size = new System.Drawing.Size(184, 16);
      this.lbl1.TabIndex = 33;
      this.lbl1.Text = "Number to start with";
      // 
      // txtStartNr
      // 
      this.txtStartNr.Location = new System.Drawing.Point(168, 126);
      this.txtStartNr.Maximum = new decimal(new int[] {
            10000000,
            0,
            0,
            0});
      this.txtStartNr.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtStartNr.Name = "txtStartNr";
      this.txtStartNr.Size = new System.Drawing.Size(64, 20);
      this.txtStartNr.TabIndex = 34;
      this.txtStartNr.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtStartNr.Validated += new System.EventHandler(this.txtStartNr_ValueChanged);
      // 
      // L19
      // 
      this.L19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L19.Location = new System.Drawing.Point(8, 128);
      this.L19.Name = "L19";
      this.L19.Size = new System.Drawing.Size(152, 16);
      this.L19.TabIndex = 18;
      this.L19.Text = "<#> = Enumerate files:";
      this.L19.Click += new System.EventHandler(this.Label_Click);
      // 
      // L18
      // 
      this.L18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.L18.Location = new System.Drawing.Point(328, 104);
      this.L18.Name = "L18";
      this.L18.Size = new System.Drawing.Size(152, 16);
      this.L18.TabIndex = 17;
      this.L18.Text = "<F> = Current Filename";
      this.L18.Click += new System.EventHandler(this.Label_Click);
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
      // chkRebuildName
      // 
      this.chkRebuildName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkRebuildName.Location = new System.Drawing.Point(104, 88);
      this.chkRebuildName.Name = "chkRebuildName";
      this.chkRebuildName.Size = new System.Drawing.Size(392, 16);
      this.chkRebuildName.TabIndex = 33;
      this.chkRebuildName.Text = "Rebuild filename from original filename entry if present (ignores format)";
      // 
      // frmTAG2ToFilename
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(514, 397);
      this.ControlBox = false;
      this.Controls.Add(this.chkRebuildName);
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
      this.Name = "frmTAG2ToFilename";
      this.ShowInTaskbar = false;
      this.Text = "TAG Ver. 2 -> Filename";
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).EndInit();
      this.framePara.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtFDigits)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtStartNr)).EndInit();
      this.ResumeLayout(false);
    }

    public frmTAG2ToFilename(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG2ToFilename_Load);
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

    private void btnOK_Click(object sender, EventArgs e)
    {
      string vstrFormat = "";
      ArrayList list = new ArrayList();
      vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });

      if (vstrFormat.IndexOf(":") >= 0)
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });

      switch (ID3Functions.FormatReplaceCheck(vstrFormat, Declarations.FormatReplace.TAGToFilename | Declarations.FormatReplace.TAGVer2))
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

      byte tracknumberDigitsFilename = Declarations.objSettings.TracknumberDigitsFilename;
      byte filenumberDigits = Declarations.objSettings.FilenumberDigits;
      byte filenumberStart = (byte)Declarations.objSettings.FilenumberStart;
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      Declarations.objSettings.RebuildOFilename = this.chkRebuildName.Checked;
      Declarations.objSettings.T2FFormats.Rows.Clear();
      Declarations.objSettings.T2FFormat = this.cmbFormat.Text;
      Declarations.objSettings.TracknumberDigitsFilename = Convert.ToByte(this.txtDigits.Value);
      Declarations.objSettings.FilenumberDigits = Convert.ToByte(this.txtFDigits.Value);
      Declarations.objSettings.FilenumberStart = Convert.ToInt32(this.txtStartNr.Value);
      int num6 = this.cmbFormat.Items.Count - 1;

      for (int i = 0; i <= num6; i++)
      {
        DataRow row = Declarations.objSettings.T2FFormats.NewRow();
        row["Format"] = this.cmbFormat.Items[i].ToString();
        Declarations.objSettings.T2FFormats.Rows.Add(row);
      }

      int num4 = Convert.ToInt32(decimal.Subtract(this.txtStartNr.Value, decimal.One));
      this.MainForm.MP3View.BeginUpdate();
      form = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.TAG2ToFilenameCB);
      frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref form, ref cB);
      progress.SetStateTAGFilename();
      progress.List = list;
      progress.String01 = vstrFormat;
      progress.Integer01 = num4;
      progress.ShowDialog(this);
      this.MainForm.MP3View.EndUpdate();

      if (list.Count > 0)
      {
        Declarations.UNDOList.Add(list);
        this.MainForm.UnDoEnable(true, true);
      }

      Declarations.objSettings.TracknumberDigitsFilename = tracknumberDigitsFilename;
      Declarations.objSettings.FilenumberDigits = filenumberDigits;
      Declarations.objSettings.FilenumberStart = filenumberStart;
      form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      this.Close();
    }

    private void btnRemove_Click(object sender, EventArgs e)
    {
      this.cmbFormat.Items.Remove(this.cmbFormat.Text);
    }

    private void cmbFormat_KeyPress(object sender, KeyPressEventArgs e)
    {
      switch (e.KeyChar)
      {
        case '\\':
        case '|':
        case '"':
        case '/':
        case '*':
        case '?':
          e.Handled = true;
          break;
      }
    }

    private void frmTAG2ToFilename_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      int num2 = Declarations.objSettings.T2FFormats.Rows.Count - 1;

      for (int i = 0; i <= num2; i++)
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.T2FFormats.Rows[i]["Format"]));

      this.cmbFormat.Text = Declarations.objSettings.T2FFormat;
      this.txtDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsFilename);
      this.txtFDigits.Value = new decimal(Declarations.objSettings.FilenumberDigits);
      this.txtStartNr.Value = new decimal(Declarations.objSettings.FilenumberStart);
      this.chkRebuildName.Checked = Declarations.objSettings.RebuildOFilename;
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

    private void txtDigits_Validated(object sender, EventArgs e)
    {
      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Minimum) < 0)
        this.txtDigits.Value = this.txtDigits.Minimum;

      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Maximum) > 0)
        this.txtDigits.Value = this.txtDigits.Maximum;
    }

    private void txtStartNr_ValueChanged(object sender, EventArgs e)
    {
      if (decimal.Compare(this.txtStartNr.Value, this.txtStartNr.Minimum) < 0)
        this.txtStartNr.Value = this.txtStartNr.Minimum;
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmTAG2ToFilename";
      Control txtDigits = this.txtDigits;
      this.txtDigits = (NumericUpDown)txtDigits;
      this.ToolTip.SetToolTip(this.txtDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.txtFDigits;
      this.txtFDigits = (NumericUpDown)txtDigits;
      this.ToolTip.SetToolTip(this.txtFDigits, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.txtStartNr;
      this.txtStartNr = (NumericUpDown)txtDigits;
      this.ToolTip.SetToolTip(this.txtStartNr, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.btnRemove;
      this.btnRemove = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnRemove, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.btnAdd;
      this.btnAdd = (Button)txtDigits;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.cmbFormat;
      this.cmbFormat = (ComboBox)txtDigits;
      this.ToolTip.SetToolTip(this.cmbFormat, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));

      vstrName = "frmTAG2ToFilename";
      txtDigits = this.chkRebuildName;
      this.chkRebuildName = (CheckBox)txtDigits;
      this.ToolTip.SetToolTip(this.chkRebuildName, Declarations.objResources.GetToolTip(ref vstrName, ref txtDigits));
    }

    private void TAG2ToFilenameCB(ref frmProgress frmProg)
    {
      bool flag = false;

      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        string str3;
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        MP3 tag = (MP3)item.Tag;
        frmProg.Infos.Text = tag.CurrentFullName;
        flag = false;
        frmProgress progress = frmProg;
        progress.Integer01++;

        if (!this.chkRebuildName.Checked)
          str3 = ID3Functions.FormatReplacedByTag(tag, frmProg.String01, 2).Replace("<#>", frmProg.Integer01.ToString().PadLeft(Convert.ToInt32(this.txtFDigits.Value), '0')).Replace("<F>", tag.CurrentName);
        else if (tag.V2TAG.FrameExists("TOFN"))
          str3 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TOFN"), null, "Content", new object[0], null, null));
        else
          str3 = "";

        str3 = str3.Replace("<", "_").Replace(">", "_").Replace("|", "_").Replace("\"", "_").Replace(@"\", "_").Replace("/", "_").Replace("*", "_").Replace("?", "_").Replace(":", "_").Trim(new char[] { ' ' });

        if (StringType.StrCmp(str3, "", false) != 0)
        {
          bool[] flagArray;
          object[] objArray;
          object[] objArray2;
          string str4;
          DataRow resStrings;
          string str = tag.CurrentFullName.Substring(0, tag.CurrentFullName.LastIndexOf(@"\") + 1) + str3 + tag.FI.Extension;

          if (str.Length <= 0xff)
          {
            foreach (MP3 mp2 in Declarations.MP3s)
            {
              if ((StringType.StrCmp(str.ToLower(), mp2.CurrentFullName.ToLower(), false) == 0) && (mp2 != tag))
              {
                flag = true;
                break;
              }
            }

            if (!flag)
            {
              if (StringType.StrCmp(str3, tag.CurrentName, false) != 0)
              {
                Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
                frmProg.List.Add(@do);
                tag.CurrentName = str3;
                item.Text = str3;
                tag.Changed = true;
                item.BackColor = Color.FromArgb(Declarations.objSettings.ColorChangedBack);
                item.ForeColor = Color.FromArgb(Declarations.objSettings.ColorChangedText);
              }
            }
            else
            {
              ListViewItem item3 = new ListViewItem              {                Text = tag.CurrentFullName              };
              objArray2 = new object[1];
              resStrings = Declarations.objResources.ResStrings;
              str4 = "ErrorTFExists";
              objArray2[0] = RuntimeHelpers.GetObjectValue(resStrings[str4]);
              objArray = objArray2;
              flagArray = new bool[] { true };
              LateBinding.LateCall(item3.SubItems, null, "Add", objArray, null, flagArray);

              if (flagArray[0])
                resStrings[str4] = RuntimeHelpers.GetObjectValue(objArray[0]);

              this.MainForm.ErrorMsg.Items.Insert(0, item3);
              this.MainForm.SplitterBottom.Expanded = true;
            }
          }
          else
          {
            ListViewItem item4 = new ListViewItem            {              Text = tag.CurrentFullName            };
            objArray = new object[1];
            resStrings = Declarations.objResources.ResStrings;
            str4 = "InvalidPathLength";
            objArray[0] = RuntimeHelpers.GetObjectValue(resStrings[str4]);
            objArray2 = objArray;
            flagArray = new bool[] { true };
            LateBinding.LateCall(item4.SubItems, null, "Add", objArray2, null, flagArray);

            if (flagArray[0])
              resStrings[str4] = RuntimeHelpers.GetObjectValue(objArray2[0]);

            this.MainForm.ErrorMsg.Items.Insert(0, item4);
            this.MainForm.SplitterBottom.Expanded = true;
          }
        }

        frmProg.ProgressBar.PerformStep();
      }
    }

    #endregion
  }
}