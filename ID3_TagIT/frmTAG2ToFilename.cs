namespace ID3_TagIT
{
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

  public class frmTAG2ToFilename : Form
  {
    [AccessedThroughProperty("btnAdd")]
    private Button _btnAdd;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnRemove")]
    private Button _btnRemove;
    [AccessedThroughProperty("chkRebuildName")]
    private CheckBox _chkRebuildName;
    [AccessedThroughProperty("cmbFormat")]
    private ComboBox _cmbFormat;
    [AccessedThroughProperty("framePara")]
    private GroupBox _framePara;
    [AccessedThroughProperty("L1")]
    private Label _L1;
    [AccessedThroughProperty("L10")]
    private Label _L10;
    [AccessedThroughProperty("L11")]
    private Label _L11;
    [AccessedThroughProperty("L12")]
    private Label _L12;
    [AccessedThroughProperty("L13")]
    private Label _L13;
    [AccessedThroughProperty("L14")]
    private Label _L14;
    [AccessedThroughProperty("L15")]
    private Label _L15;
    [AccessedThroughProperty("L16")]
    private Label _L16;
    [AccessedThroughProperty("L17")]
    private Label _L17;
    [AccessedThroughProperty("L18")]
    private Label _L18;
    [AccessedThroughProperty("L19")]
    private Label _L19;
    [AccessedThroughProperty("L2")]
    private Label _L2;
    [AccessedThroughProperty("L3")]
    private Label _L3;
    [AccessedThroughProperty("L4")]
    private Label _L4;
    [AccessedThroughProperty("L5")]
    private Label _L5;
    [AccessedThroughProperty("L6")]
    private Label _L6;
    [AccessedThroughProperty("L7")]
    private Label _L7;
    [AccessedThroughProperty("L8")]
    private Label _L8;
    [AccessedThroughProperty("L9")]
    private Label _L9;
    [AccessedThroughProperty("lbl1")]
    private Label _lbl1;
    [AccessedThroughProperty("lbl2")]
    private Label _lbl2;
    [AccessedThroughProperty("lblDigits")]
    private Label _lblDigits;
    [AccessedThroughProperty("lblFormat")]
    private Label _lblFormat;
    [AccessedThroughProperty("lblInfo")]
    private Label _lblInfo;
    [AccessedThroughProperty("ToolTip")]
    private System.Windows.Forms.ToolTip _ToolTip;
    [AccessedThroughProperty("txtDigits")]
    private NumericUpDown _txtDigits;
    [AccessedThroughProperty("txtFDigits")]
    private NumericUpDown _txtFDigits;
    [AccessedThroughProperty("txtStartNr")]
    private NumericUpDown _txtStartNr;
    private IContainer components;
    private frmMain MainForm;

    public frmTAG2ToFilename(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG2ToFilename_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

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

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.cmbFormat.Text, "", false) != 0)
      {
        this.cmbFormat.Items.Add(this.cmbFormat.Text);
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      string vstrFormat = "";
      ArrayList list = new ArrayList();
      vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });
      if (vstrFormat.IndexOf(":") >= 0)
      {
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });
      }
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
      Main.SaveFormSettings(ref form);
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
      Main.SaveFormSettings(ref form);
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

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void frmTAG2ToFilename_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
      int num2 = Declarations.objSettings.T2FFormats.Rows.Count - 1;
      for (int i = 0; i <= num2; i++)
      {
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.T2FFormats.Rows[i]["Format"]));
      }
      this.cmbFormat.Text = Declarations.objSettings.T2FFormat;
      this.txtDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsFilename);
      this.txtFDigits.Value = new decimal(Declarations.objSettings.FilenumberDigits);
      this.txtStartNr.Value = new decimal(Declarations.objSettings.FilenumberStart);
      this.chkRebuildName.Checked = Declarations.objSettings.RebuildOFilename;
      this.AddToolTips();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      this.lblInfo = new Label();
      this.lblDigits = new Label();
      this.txtDigits = new NumericUpDown();
      this.framePara = new GroupBox();
      this.L13 = new Label();
      this.lbl2 = new Label();
      this.txtFDigits = new NumericUpDown();
      this.lbl1 = new Label();
      this.txtStartNr = new NumericUpDown();
      this.L19 = new Label();
      this.L18 = new Label();
      this.L16 = new Label();
      this.L15 = new Label();
      this.L14 = new Label();
      this.L17 = new Label();
      this.L12 = new Label();
      this.L11 = new Label();
      this.L10 = new Label();
      this.L9 = new Label();
      this.L8 = new Label();
      this.L7 = new Label();
      this.L6 = new Label();
      this.L5 = new Label();
      this.L4 = new Label();
      this.L3 = new Label();
      this.L2 = new Label();
      this.L1 = new Label();
      this.btnRemove = new Button();
      this.btnAdd = new Button();
      this.cmbFormat = new ComboBox();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.lblFormat = new Label();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.chkRebuildName = new CheckBox();
      this.txtDigits.BeginInit();
      this.framePara.SuspendLayout();
      this.txtFDigits.BeginInit();
      this.txtStartNr.BeginInit();
      this.SuspendLayout();
      this.lblInfo.BorderStyle = BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = ImeMode.NoControl;
      Point point = new Point(8, 0x130);
      this.lblInfo.Location = point;
      this.lblInfo.Name = "lblInfo";
      Size size = new Size(0x1f0, 0x38);
      this.lblInfo.Size = size;
      this.lblInfo.TabIndex = 0x22;
      this.lblInfo.Text = "This function offers you the possibilty to extract information from the TAG and write it into the filename.  Enter the format using the parameters above. To save the format give it a description (using the following syntax: \"Description: Format\") and add it to the list.";
      this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
      this.lblDigits.ImeMode = ImeMode.NoControl;
      point = new Point(0x69, 0x41);
      this.lblDigits.Location = point;
      this.lblDigits.Name = "lblDigits";
      size = new Size(0xb8, 0x10);
      this.lblDigits.Size = size;
      this.lblDigits.TabIndex = 0x1f;
      this.lblDigits.Text = "&Number of digits of track numbers:";
      point = new Point(0x139, 0x3f);
      this.txtDigits.Location = point;
      decimal num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtDigits.Minimum = num;
      this.txtDigits.Name = "txtDigits";
      size = new Size(0x40, 20);
      this.txtDigits.Size = size;
      this.txtDigits.TabIndex = 0x20;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtDigits.Value = num;
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
      point = new Point(8, 0x70);
      this.framePara.Location = point;
      this.framePara.Name = "framePara";
      size = new Size(0x1f0, 0xb9);
      this.framePara.Size = size;
      this.framePara.TabIndex = 0x21;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      this.L13.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x58);
      this.L13.Location = point;
      this.L13.Name = "L13";
      size = new Size(0x98, 0x10);
      this.L13.Size = size;
      this.L13.TabIndex = 0x25;
      this.L13.Text = "<R> = Composer";
      this.lbl2.ImeMode = ImeMode.NoControl;
      point = new Point(240, 0x9a);
      this.lbl2.Location = point;
      this.lbl2.Name = "lbl2";
      size = new Size(0xb8, 0x10);
      this.lbl2.Size = size;
      this.lbl2.TabIndex = 0x23;
      this.lbl2.Text = "Number of digits";
      point = new Point(0xa8, 0x98);
      this.txtFDigits.Location = point;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtFDigits.Minimum = num;
      this.txtFDigits.Name = "txtFDigits";
      size = new Size(0x40, 20);
      this.txtFDigits.Size = size;
      this.txtFDigits.TabIndex = 0x24;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtFDigits.Value = num;
      this.lbl1.ImeMode = ImeMode.NoControl;
      point = new Point(240, 0x80);
      this.lbl1.Location = point;
      this.lbl1.Name = "lbl1";
      size = new Size(0xb8, 0x10);
      this.lbl1.Size = size;
      this.lbl1.TabIndex = 0x21;
      this.lbl1.Text = "Number to start with";
      point = new Point(0xa8, 0x7e);
      this.txtStartNr.Location = point;
      num = new decimal(new int[] { 0x989680, 0, 0, 0 });
      this.txtStartNr.Maximum = num;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtStartNr.Minimum = num;
      this.txtStartNr.Name = "txtStartNr";
      size = new Size(0x40, 20);
      this.txtStartNr.Size = size;
      this.txtStartNr.TabIndex = 0x22;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtStartNr.Value = num;
      this.L19.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x80);
      this.L19.Location = point;
      this.L19.Name = "L19";
      size = new Size(0x98, 0x10);
      this.L19.Size = size;
      this.L19.TabIndex = 0x12;
      this.L19.Text = "<#> = Enumerate files:";
      this.L18.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x68);
      this.L18.Location = point;
      this.L18.Name = "L18";
      size = new Size(0x98, 0x10);
      this.L18.Size = size;
      this.L18.TabIndex = 0x11;
      this.L18.Text = "<F> = Current Filename";
      this.L16.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x68);
      this.L16.Location = point;
      this.L16.Name = "L16";
      size = new Size(0x98, 0x10);
      this.L16.Size = size;
      this.L16.TabIndex = 0x10;
      this.L16.Text = "<E> = Beats/minute (BPM)";
      this.L15.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x58);
      this.L15.Location = point;
      this.L15.Name = "L15";
      size = new Size(160, 0x10);
      this.L15.Size = size;
      this.L15.TabIndex = 14;
      this.L15.Text = "<O> = Band / Orchestra";
      this.L14.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x58);
      this.L14.Location = point;
      this.L14.Name = "L14";
      size = new Size(160, 0x10);
      this.L14.Size = size;
      this.L14.TabIndex = 13;
      this.L14.Text = "<S> = Subtitle";
      this.L17.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x68);
      this.L17.Location = point;
      this.L17.Name = "L17";
      size = new Size(160, 0x10);
      this.L17.Size = size;
      this.L17.TabIndex = 12;
      this.L17.Text = "<M> = Modified / Remixed by";
      this.L12.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x48);
      this.L12.Location = point;
      this.L12.Name = "L12";
      size = new Size(160, 0x10);
      this.L12.Size = size;
      this.L12.TabIndex = 11;
      this.L12.Text = "<N> = Conductor";
      this.L11.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x48);
      this.L11.Location = point;
      this.L11.Name = "L11";
      size = new Size(160, 0x10);
      this.L11.Size = size;
      this.L11.TabIndex = 10;
      this.L11.Text = "<p> = Total number of medias";
      this.L10.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x48);
      this.L10.Location = point;
      this.L10.Name = "L10";
      size = new Size(160, 0x10);
      this.L10.Size = size;
      this.L10.TabIndex = 9;
      this.L10.Text = "<P> = Position in media set";
      this.L9.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x38);
      this.L9.Location = point;
      this.L9.Name = "L9";
      size = new Size(160, 0x10);
      this.L9.Size = size;
      this.L9.TabIndex = 8;
      this.L9.Text = "<U> = Content Group";
      this.L8.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x38);
      this.L8.Location = point;
      this.L8.Name = "L8";
      size = new Size(160, 0x10);
      this.L8.Size = size;
      this.L8.TabIndex = 7;
      this.L8.Text = "<k> = Total number of tracks";
      this.L7.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.L7.Location = point;
      this.L7.Name = "L7";
      size = new Size(160, 0x10);
      this.L7.Size = size;
      this.L7.TabIndex = 6;
      this.L7.Text = "<K> = Track number";
      this.L6.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 40);
      this.L6.Location = point;
      this.L6.Name = "L6";
      size = new Size(160, 0x10);
      this.L6.Size = size;
      this.L6.TabIndex = 5;
      this.L6.Text = "<G> = First Genre";
      this.L5.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 40);
      this.L5.Location = point;
      this.L5.Name = "L5";
      size = new Size(160, 0x10);
      this.L5.Size = size;
      this.L5.TabIndex = 4;
      this.L5.Text = "<Y> = Year";
      this.L4.ImeMode = ImeMode.NoControl;
      point = new Point(8, 40);
      this.L4.Location = point;
      this.L4.Name = "L4";
      size = new Size(160, 0x10);
      this.L4.Size = size;
      this.L4.TabIndex = 3;
      this.L4.Text = "<C> = Comment";
      this.L3.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x18);
      this.L3.Location = point;
      this.L3.Name = "L3";
      size = new Size(160, 0x10);
      this.L3.Size = size;
      this.L3.TabIndex = 2;
      this.L3.Text = "<B> = Album";
      this.L2.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x18);
      this.L2.Location = point;
      this.L2.Name = "L2";
      size = new Size(160, 0x10);
      this.L2.Size = size;
      this.L2.TabIndex = 1;
      this.L2.Text = "<T> = Title";
      this.L1.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x18);
      this.L1.Location = point;
      this.L1.Name = "L1";
      size = new Size(160, 0x10);
      this.L1.Size = size;
      this.L1.TabIndex = 0;
      this.L1.Text = "<A> = Artist";
      this.btnRemove.ImeMode = ImeMode.NoControl;
      point = new Point(0x139, 0x1f);
      this.btnRemove.Location = point;
      this.btnRemove.Name = "btnRemove";
      size = new Size(0xc0, 0x18);
      this.btnRemove.Size = size;
      this.btnRemove.TabIndex = 30;
      this.btnRemove.Text = "&Remove format from list";
      this.btnAdd.ImeMode = ImeMode.NoControl;
      point = new Point(0x69, 0x1f);
      this.btnAdd.Location = point;
      this.btnAdd.Name = "btnAdd";
      size = new Size(0xc0, 0x18);
      this.btnAdd.Size = size;
      this.btnAdd.TabIndex = 0x1d;
      this.btnAdd.Text = "&Add format to list";
      this.cmbFormat.ItemHeight = 13;
      point = new Point(0x69, 7);
      this.cmbFormat.Location = point;
      this.cmbFormat.Name = "cmbFormat";
      size = new Size(400, 0x15);
      this.cmbFormat.Size = size;
      this.cmbFormat.TabIndex = 0x1c;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      point = new Point(0x180, 0x170);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(120, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x24;
      this.btnCancel.Text = "&Cancel";
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(0x100, 0x170);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(120, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 0x23;
      this.btnOK.Text = "&OK";
      this.lblFormat.ImeMode = ImeMode.NoControl;
      point = new Point(9, 7);
      this.lblFormat.Location = point;
      this.lblFormat.Name = "lblFormat";
      size = new Size(0x60, 0x10);
      this.lblFormat.Size = size;
      this.lblFormat.TabIndex = 0x1b;
      this.lblFormat.Text = "&Format:";
      this.chkRebuildName.ImeMode = ImeMode.NoControl;
      point = new Point(0x68, 0x58);
      this.chkRebuildName.Location = point;
      this.chkRebuildName.Name = "chkRebuildName";
      size = new Size(0x188, 0x10);
      this.chkRebuildName.Size = size;
      this.chkRebuildName.TabIndex = 0x21;
      this.chkRebuildName.Text = "Rebuild filename from original filename entry if present (ignores format)";
      this.AcceptButton = this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = this.btnCancel;
      size = new Size(0x202, 0x18d);
      this.ClientSize = size;
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
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.ImeMode = ImeMode.NoControl;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG2ToFilename";
      this.ShowInTaskbar = false;
      this.Text = "TAG Ver. 2 -> Filename";
      this.txtDigits.EndInit();
      this.framePara.ResumeLayout(false);
      this.txtFDigits.EndInit();
      this.txtStartNr.EndInit();
      this.ResumeLayout(false);
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

    private void TAG2ToFilenameCB(ref frmProgress frmProg)
    {
      bool flag = false;
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        string str3;
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        MP3 tag = (MP3)item.Tag;
        frmProg.Infos.Text = tag.CurrentFullName;
        flag = false;
        frmProgress progress = frmProg;
        progress.Integer01++;
        if (!this.chkRebuildName.Checked)
        {
          str3 = ID3Functions.FormatReplacedByTag(tag, frmProg.String01, 2).Replace("<#>", frmProg.Integer01.ToString().PadLeft(Convert.ToInt32(this.txtFDigits.Value), '0')).Replace("<F>", tag.CurrentName);
        }
        else if (tag.V2TAG.FrameExists("TOFN"))
        {
          str3 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TOFN"), null, "Content", new object[0], null, null));
        }
        else
        {
          str3 = "";
        }
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
              ListViewItem item3 = new ListViewItem
              {
                Text = tag.CurrentFullName
              };
              objArray2 = new object[1];
              resStrings = Declarations.objResources.ResStrings;
              str4 = "ErrorTFExists";
              objArray2[0] = RuntimeHelpers.GetObjectValue(resStrings[str4]);
              objArray = objArray2;
              flagArray = new bool[] { true };
              LateBinding.LateCall(item3.SubItems, null, "Add", objArray, null, flagArray);
              if (flagArray[0])
              {
                resStrings[str4] = RuntimeHelpers.GetObjectValue(objArray[0]);
              }
              this.MainForm.ErrorMsg.Items.Insert(0, item3);
              this.MainForm.SplitterBottom.Expanded = true;
            }
          }
          else
          {
            ListViewItem item4 = new ListViewItem
            {
              Text = tag.CurrentFullName
            };
            objArray = new object[1];
            resStrings = Declarations.objResources.ResStrings;
            str4 = "InvalidPathLength";
            objArray[0] = RuntimeHelpers.GetObjectValue(resStrings[str4]);
            objArray2 = objArray;
            flagArray = new bool[] { true };
            LateBinding.LateCall(item4.SubItems, null, "Add", objArray2, null, flagArray);
            if (flagArray[0])
            {
              resStrings[str4] = RuntimeHelpers.GetObjectValue(objArray2[0]);
            }
            this.MainForm.ErrorMsg.Items.Insert(0, item4);
            this.MainForm.SplitterBottom.Expanded = true;
          }
        }
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void txtDigits_Validated(object sender, EventArgs e)
    {
      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Minimum) < 0)
      {
        this.txtDigits.Value = this.txtDigits.Minimum;
      }
      if (decimal.Compare(this.txtDigits.Value, this.txtDigits.Maximum) > 0)
      {
        this.txtDigits.Value = this.txtDigits.Maximum;
      }
    }

    private void txtStartNr_ValueChanged(object sender, EventArgs e)
    {
      if (decimal.Compare(this.txtStartNr.Value, this.txtStartNr.Minimum) < 0)
      {
        this.txtStartNr.Value = this.txtStartNr.Minimum;
      }
    }

    internal virtual Button btnAdd
    {
      get
      {
        return this._btnAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAdd != null)
        {
          this._btnAdd.Click -= new EventHandler(this.btnAdd_Click);
        }
        this._btnAdd = value;
        if (this._btnAdd != null)
        {
          this._btnAdd.Click += new EventHandler(this.btnAdd_Click);
        }
      }
    }

    internal virtual Button btnCancel
    {
      get
      {
        return this._btnCancel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnCancel != null)
        {
        }
        this._btnCancel = value;
        if (this._btnCancel != null)
        {
        }
      }
    }

    internal virtual Button btnOK
    {
      get
      {
        return this._btnOK;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnOK != null)
        {
          this._btnOK.Click -= new EventHandler(this.btnOK_Click);
        }
        this._btnOK = value;
        if (this._btnOK != null)
        {
          this._btnOK.Click += new EventHandler(this.btnOK_Click);
        }
      }
    }

    internal virtual Button btnRemove
    {
      get
      {
        return this._btnRemove;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemove != null)
        {
          this._btnRemove.Click -= new EventHandler(this.btnRemove_Click);
        }
        this._btnRemove = value;
        if (this._btnRemove != null)
        {
          this._btnRemove.Click += new EventHandler(this.btnRemove_Click);
        }
      }
    }

    internal virtual CheckBox chkRebuildName
    {
      get
      {
        return this._chkRebuildName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkRebuildName != null)
        {
        }
        this._chkRebuildName = value;
        if (this._chkRebuildName != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbFormat
    {
      get
      {
        return this._cmbFormat;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbFormat != null)
        {
          this._cmbFormat.KeyPress -= new KeyPressEventHandler(this.cmbFormat_KeyPress);
        }
        this._cmbFormat = value;
        if (this._cmbFormat != null)
        {
          this._cmbFormat.KeyPress += new KeyPressEventHandler(this.cmbFormat_KeyPress);
        }
      }
    }

    internal virtual GroupBox framePara
    {
      get
      {
        return this._framePara;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._framePara != null)
        {
        }
        this._framePara = value;
        if (this._framePara != null)
        {
        }
      }
    }

    internal virtual Label L1
    {
      get
      {
        return this._L1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L1 != null)
        {
          this._L1.Click -= new EventHandler(this.Label_Click);
        }
        this._L1 = value;
        if (this._L1 != null)
        {
          this._L1.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L10
    {
      get
      {
        return this._L10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L10 != null)
        {
          this._L10.Click -= new EventHandler(this.Label_Click);
        }
        this._L10 = value;
        if (this._L10 != null)
        {
          this._L10.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L11
    {
      get
      {
        return this._L11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L11 != null)
        {
          this._L11.Click -= new EventHandler(this.Label_Click);
        }
        this._L11 = value;
        if (this._L11 != null)
        {
          this._L11.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L12
    {
      get
      {
        return this._L12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L12 != null)
        {
          this._L12.Click -= new EventHandler(this.Label_Click);
        }
        this._L12 = value;
        if (this._L12 != null)
        {
          this._L12.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L13
    {
      get
      {
        return this._L13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L13 != null)
        {
        }
        this._L13 = value;
        if (this._L13 != null)
        {
        }
      }
    }

    internal virtual Label L14
    {
      get
      {
        return this._L14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L14 != null)
        {
          this._L14.Click -= new EventHandler(this.Label_Click);
        }
        this._L14 = value;
        if (this._L14 != null)
        {
          this._L14.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L15
    {
      get
      {
        return this._L15;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L15 != null)
        {
          this._L15.Click -= new EventHandler(this.Label_Click);
        }
        this._L15 = value;
        if (this._L15 != null)
        {
          this._L15.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L16
    {
      get
      {
        return this._L16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L16 != null)
        {
          this._L16.Click -= new EventHandler(this.Label_Click);
        }
        this._L16 = value;
        if (this._L16 != null)
        {
          this._L16.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L17
    {
      get
      {
        return this._L17;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L17 != null)
        {
          this._L17.Click -= new EventHandler(this.Label_Click);
        }
        this._L17 = value;
        if (this._L17 != null)
        {
          this._L17.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L18
    {
      get
      {
        return this._L18;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L18 != null)
        {
          this._L18.Click -= new EventHandler(this.Label_Click);
        }
        this._L18 = value;
        if (this._L18 != null)
        {
          this._L18.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L19
    {
      get
      {
        return this._L19;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L19 != null)
        {
          this._L19.Click -= new EventHandler(this.Label_Click);
        }
        this._L19 = value;
        if (this._L19 != null)
        {
          this._L19.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L2
    {
      get
      {
        return this._L2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L2 != null)
        {
          this._L2.Click -= new EventHandler(this.Label_Click);
        }
        this._L2 = value;
        if (this._L2 != null)
        {
          this._L2.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L3
    {
      get
      {
        return this._L3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L3 != null)
        {
          this._L3.Click -= new EventHandler(this.Label_Click);
        }
        this._L3 = value;
        if (this._L3 != null)
        {
          this._L3.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L4
    {
      get
      {
        return this._L4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L4 != null)
        {
          this._L4.Click -= new EventHandler(this.Label_Click);
        }
        this._L4 = value;
        if (this._L4 != null)
        {
          this._L4.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L5
    {
      get
      {
        return this._L5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L5 != null)
        {
          this._L5.Click -= new EventHandler(this.Label_Click);
        }
        this._L5 = value;
        if (this._L5 != null)
        {
          this._L5.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L6
    {
      get
      {
        return this._L6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L6 != null)
        {
          this._L6.Click -= new EventHandler(this.Label_Click);
        }
        this._L6 = value;
        if (this._L6 != null)
        {
          this._L6.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L7
    {
      get
      {
        return this._L7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L7 != null)
        {
          this._L7.Click -= new EventHandler(this.Label_Click);
        }
        this._L7 = value;
        if (this._L7 != null)
        {
          this._L7.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L8
    {
      get
      {
        return this._L8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L8 != null)
        {
          this._L8.Click -= new EventHandler(this.Label_Click);
        }
        this._L8 = value;
        if (this._L8 != null)
        {
          this._L8.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label L9
    {
      get
      {
        return this._L9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._L9 != null)
        {
          this._L9.Click -= new EventHandler(this.Label_Click);
        }
        this._L9 = value;
        if (this._L9 != null)
        {
          this._L9.Click += new EventHandler(this.Label_Click);
        }
      }
    }

    internal virtual Label lbl1
    {
      get
      {
        return this._lbl1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lbl1 != null)
        {
        }
        this._lbl1 = value;
        if (this._lbl1 != null)
        {
        }
      }
    }

    internal virtual Label lbl2
    {
      get
      {
        return this._lbl2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lbl2 != null)
        {
        }
        this._lbl2 = value;
        if (this._lbl2 != null)
        {
        }
      }
    }

    internal virtual Label lblDigits
    {
      get
      {
        return this._lblDigits;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblDigits != null)
        {
        }
        this._lblDigits = value;
        if (this._lblDigits != null)
        {
        }
      }
    }

    internal virtual Label lblFormat
    {
      get
      {
        return this._lblFormat;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblFormat != null)
        {
        }
        this._lblFormat = value;
        if (this._lblFormat != null)
        {
        }
      }
    }

    internal virtual Label lblInfo
    {
      get
      {
        return this._lblInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblInfo != null)
        {
        }
        this._lblInfo = value;
        if (this._lblInfo != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.ToolTip ToolTip
    {
      get
      {
        return this._ToolTip;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ToolTip != null)
        {
        }
        this._ToolTip = value;
        if (this._ToolTip != null)
        {
        }
      }
    }

    internal virtual NumericUpDown txtDigits
    {
      get
      {
        return this._txtDigits;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtDigits != null)
        {
          this._txtDigits.Validated -= new EventHandler(this.txtDigits_Validated);
        }
        this._txtDigits = value;
        if (this._txtDigits != null)
        {
          this._txtDigits.Validated += new EventHandler(this.txtDigits_Validated);
        }
      }
    }

    internal virtual NumericUpDown txtFDigits
    {
      get
      {
        return this._txtFDigits;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtFDigits != null)
        {
          this._txtFDigits.Validated -= new EventHandler(this.txtDigits_Validated);
        }
        this._txtFDigits = value;
        if (this._txtFDigits != null)
        {
          this._txtFDigits.Validated += new EventHandler(this.txtDigits_Validated);
        }
      }
    }

    internal virtual NumericUpDown txtStartNr
    {
      get
      {
        return this._txtStartNr;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtStartNr != null)
        {
          this._txtStartNr.Validated -= new EventHandler(this.txtStartNr_ValueChanged);
        }
        this._txtStartNr = value;
        if (this._txtStartNr != null)
        {
          this._txtStartNr.Validated += new EventHandler(this.txtStartNr_ValueChanged);
        }
      }
    }
  }
}