  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.ComponentModel;
  using System.Data;
  using System.Diagnostics;
  using System.Drawing;
  using System.IO;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmOrganize : Form
  {
    [AccessedThroughProperty("btnAdd")]
    private Button _btnAdd;
    [AccessedThroughProperty("btnBrowse")]
    private Button _btnBrowse;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnRemove")]
    private Button _btnRemove;
    [AccessedThroughProperty("chkCopy")]
    private CheckBox _chkCopy;
    [AccessedThroughProperty("chkOverwrite")]
    private CheckBox _chkOverwrite;
    [AccessedThroughProperty("cmbFormat")]
    private ComboBox _cmbFormat;
    [AccessedThroughProperty("FolderBrowserDialog")]
    private System.Windows.Forms.FolderBrowserDialog _FolderBrowserDialog;
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
    [AccessedThroughProperty("L20")]
    private Label _L20;
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
    [AccessedThroughProperty("lblDigits")]
    private Label _lblDigits;
    [AccessedThroughProperty("lblFormat")]
    private Label _lblFormat;
    [AccessedThroughProperty("lblInfo")]
    private Label _lblInfo;
    [AccessedThroughProperty("lblPath")]
    private Label _lblPath;
    [AccessedThroughProperty("optID3V1")]
    private RadioButton _optID3V1;
    [AccessedThroughProperty("optID3V2")]
    private RadioButton _optID3V2;
    [AccessedThroughProperty("ToolTip")]
    private System.Windows.Forms.ToolTip _ToolTip;
    [AccessedThroughProperty("txtDigits")]
    private NumericUpDown _txtDigits;
    [AccessedThroughProperty("txtPath")]
    private TextBox _txtPath;
    private IContainer components;
    private frmMain MainForm;

    public frmOrganize(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmOrganize_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

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

      if (!Main.CheckFilename(vstrName, true))
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
          Main.SaveFormSettings(ref form);
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

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    private void frmOrganize_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
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

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      this.lblPath = new Label();
      this.lblFormat = new Label();
      this.txtPath = new TextBox();
      this.btnBrowse = new Button();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.cmbFormat = new ComboBox();
      this.btnAdd = new Button();
      this.btnRemove = new Button();
      this.framePara = new GroupBox();
      this.L19 = new Label();
      this.L20 = new Label();
      this.L13 = new Label();
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
      this.L18 = new Label();
      this.lblDigits = new Label();
      this.optID3V2 = new RadioButton();
      this.optID3V1 = new RadioButton();
      this.txtDigits = new NumericUpDown();
      this.lblInfo = new Label();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.chkOverwrite = new CheckBox();
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.chkCopy = new CheckBox();
      this.framePara.SuspendLayout();
      this.txtDigits.BeginInit();
      this.SuspendLayout();
      this.lblPath.ImeMode = ImeMode.NoControl;
      Point point = new Point(8, 8);
      this.lblPath.Location = point;
      this.lblPath.Name = "lblPath";
      Size size = new Size(0x60, 0x10);
      this.lblPath.Size = size;
      this.lblPath.TabIndex = 0;
      this.lblPath.Text = "&Root-Path:";
      this.lblFormat.ImeMode = ImeMode.NoControl;
      point = new Point(8, 40);
      this.lblFormat.Location = point;
      this.lblFormat.Name = "lblFormat";
      size = new Size(0x60, 0x10);
      this.lblFormat.Size = size;
      this.lblFormat.TabIndex = 3;
      this.lblFormat.Text = "&Format:";
      point = new Point(0x68, 6);
      this.txtPath.Location = point;
      this.txtPath.Name = "txtPath";
      size = new Size(0x130, 20);
      this.txtPath.Size = size;
      this.txtPath.TabIndex = 1;
      this.txtPath.Text = "";
      this.btnBrowse.ImeMode = ImeMode.NoControl;
      point = new Point(0x1a0, 4);
      this.btnBrowse.Location = point;
      this.btnBrowse.Name = "btnBrowse";
      size = new Size(0x58, 0x18);
      this.btnBrowse.Size = size;
      this.btnBrowse.TabIndex = 2;
      this.btnBrowse.Text = "&Browse ...";
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      point = new Point(0x180, 0x178);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(120, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x12;
      this.btnCancel.Text = "&Cancel";
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(0x100, 0x178);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(120, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 0x11;
      this.btnOK.Text = "&OK";
      this.cmbFormat.ItemHeight = 13;
      point = new Point(0x68, 0x20);
      this.cmbFormat.Location = point;
      this.cmbFormat.Name = "cmbFormat";
      size = new Size(400, 0x15);
      this.cmbFormat.Size = size;
      this.cmbFormat.TabIndex = 4;
      this.btnAdd.ImeMode = ImeMode.NoControl;
      point = new Point(0x68, 0x38);
      this.btnAdd.Location = point;
      this.btnAdd.Name = "btnAdd";
      size = new Size(0xc0, 0x18);
      this.btnAdd.Size = size;
      this.btnAdd.TabIndex = 5;
      this.btnAdd.Text = "&Add format to list";
      this.btnRemove.ImeMode = ImeMode.NoControl;
      point = new Point(0x138, 0x38);
      this.btnRemove.Location = point;
      this.btnRemove.Name = "btnRemove";
      size = new Size(0xc0, 0x18);
      this.btnRemove.Size = size;
      this.btnRemove.TabIndex = 6;
      this.btnRemove.Text = "&Remove format from list";
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
      point = new Point(8, 0x90);
      this.framePara.Location = point;
      this.framePara.Name = "framePara";
      size = new Size(0x1f0, 0x88);
      this.framePara.Size = size;
      this.framePara.TabIndex = 11;
      this.framePara.TabStop = false;
      this.framePara.Text = "Parameters (Tip: click the label to add the parameter to the format)";
      this.L19.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x70);
      this.L19.Location = point;
      this.L19.Name = "L19";
      size = new Size(0x98, 0x10);
      this.L19.Size = size;
      this.L19.TabIndex = 0x38;
      this.L19.Text = "<I> = Bitrate";
      this.L20.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x70);
      this.L20.Location = point;
      this.L20.Name = "L20";
      size = new Size(0x98, 0x10);
      this.L20.Size = size;
      this.L20.TabIndex = 0x37;
      this.L20.Text = @"\ = Folder";
      this.L13.ImeMode = ImeMode.NoControl;
      point = new Point(8, 80);
      this.L13.Location = point;
      this.L13.Name = "L13";
      size = new Size(0x98, 0x10);
      this.L13.Size = size;
      this.L13.TabIndex = 0x36;
      this.L13.Text = "<R> = Composer";
      this.L16.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x60);
      this.L16.Location = point;
      this.L16.Name = "L16";
      size = new Size(0x98, 0x10);
      this.L16.Size = size;
      this.L16.TabIndex = 0x35;
      this.L16.Text = "<E> = Beats/minute (BPM)";
      this.L15.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 80);
      this.L15.Location = point;
      this.L15.Name = "L15";
      size = new Size(160, 0x10);
      this.L15.Size = size;
      this.L15.TabIndex = 0x34;
      this.L15.Text = "<O> = Band / Orchestra";
      this.L14.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 80);
      this.L14.Location = point;
      this.L14.Name = "L14";
      size = new Size(160, 0x10);
      this.L14.Size = size;
      this.L14.TabIndex = 0x33;
      this.L14.Text = "<S> = Subtitle";
      this.L17.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x60);
      this.L17.Location = point;
      this.L17.Name = "L17";
      size = new Size(160, 0x10);
      this.L17.Size = size;
      this.L17.TabIndex = 50;
      this.L17.Text = "<M> = Modified / Remixed by";
      this.L12.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x40);
      this.L12.Location = point;
      this.L12.Name = "L12";
      size = new Size(160, 0x10);
      this.L12.Size = size;
      this.L12.TabIndex = 0x31;
      this.L12.Text = "<N> = Conductor";
      this.L11.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x40);
      this.L11.Location = point;
      this.L11.Name = "L11";
      size = new Size(160, 0x10);
      this.L11.Size = size;
      this.L11.TabIndex = 0x30;
      this.L11.Text = "<p> = Total number of medias";
      this.L10.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x40);
      this.L10.Location = point;
      this.L10.Name = "L10";
      size = new Size(160, 0x10);
      this.L10.Size = size;
      this.L10.TabIndex = 0x2f;
      this.L10.Text = "<P> = Position in media set";
      this.L9.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x30);
      this.L9.Location = point;
      this.L9.Name = "L9";
      size = new Size(160, 0x10);
      this.L9.Size = size;
      this.L9.TabIndex = 0x2e;
      this.L9.Text = "<U> = Content Group";
      this.L8.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x30);
      this.L8.Location = point;
      this.L8.Name = "L8";
      size = new Size(160, 0x10);
      this.L8.Size = size;
      this.L8.TabIndex = 0x2d;
      this.L8.Text = "<k> = Total number of tracks";
      this.L7.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x30);
      this.L7.Location = point;
      this.L7.Name = "L7";
      size = new Size(160, 0x10);
      this.L7.Size = size;
      this.L7.TabIndex = 0x2c;
      this.L7.Text = "<K> = Track number";
      this.L6.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x20);
      this.L6.Location = point;
      this.L6.Name = "L6";
      size = new Size(160, 0x10);
      this.L6.Size = size;
      this.L6.TabIndex = 0x2b;
      this.L6.Text = "<G> = First Genre";
      this.L5.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x20);
      this.L5.Location = point;
      this.L5.Name = "L5";
      size = new Size(160, 0x10);
      this.L5.Size = size;
      this.L5.TabIndex = 0x2a;
      this.L5.Text = "<Y> = Year";
      this.L4.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.L4.Location = point;
      this.L4.Name = "L4";
      size = new Size(160, 0x10);
      this.L4.Size = size;
      this.L4.TabIndex = 0x29;
      this.L4.Text = "<C> = Comment";
      this.L3.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x10);
      this.L3.Location = point;
      this.L3.Name = "L3";
      size = new Size(160, 0x10);
      this.L3.Size = size;
      this.L3.TabIndex = 40;
      this.L3.Text = "<B> = Album";
      this.L2.ImeMode = ImeMode.NoControl;
      point = new Point(0xa8, 0x10);
      this.L2.Location = point;
      this.L2.Name = "L2";
      size = new Size(160, 0x10);
      this.L2.Size = size;
      this.L2.TabIndex = 0x27;
      this.L2.Text = "<T> = Title";
      this.L1.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x10);
      this.L1.Location = point;
      this.L1.Name = "L1";
      size = new Size(160, 0x10);
      this.L1.Size = size;
      this.L1.TabIndex = 0x26;
      this.L1.Text = "<A> = Artist";
      this.L18.ImeMode = ImeMode.NoControl;
      point = new Point(0x148, 0x60);
      this.L18.Location = point;
      this.L18.Name = "L18";
      size = new Size(0x98, 0x10);
      this.L18.Size = size;
      this.L18.TabIndex = 0x10;
      this.L18.Text = "<1> = First letter of artist";
      this.lblDigits.ImeMode = ImeMode.NoControl;
      point = new Point(0x68, 0x70);
      this.lblDigits.Location = point;
      this.lblDigits.Name = "lblDigits";
      size = new Size(0xb8, 0x10);
      this.lblDigits.Size = size;
      this.lblDigits.TabIndex = 9;
      this.lblDigits.Text = "&Number of digits of track numbers:";
      this.optID3V2.ImeMode = ImeMode.NoControl;
      point = new Point(0x138, 0x58);
      this.optID3V2.Location = point;
      this.optID3V2.Name = "optID3V2";
      size = new Size(0xa8, 0x10);
      this.optID3V2.Size = size;
      this.optID3V2.TabIndex = 8;
      this.optID3V2.Text = "Use Ver. &2 TAG information";
      this.optID3V1.ImeMode = ImeMode.NoControl;
      point = new Point(0x68, 0x58);
      this.optID3V1.Location = point;
      this.optID3V1.Name = "optID3V1";
      size = new Size(0xa8, 0x10);
      this.optID3V1.Size = size;
      this.optID3V1.TabIndex = 7;
      this.optID3V1.Text = "Use Ver. &1 TAG information";
      point = new Point(0x138, 110);
      this.txtDigits.Location = point;
      decimal num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtDigits.Minimum = num;
      this.txtDigits.Name = "txtDigits";
      size = new Size(0x40, 20);
      this.txtDigits.Size = size;
      this.txtDigits.TabIndex = 10;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtDigits.Value = num;
      this.lblInfo.BorderStyle = BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x120);
      this.lblInfo.Location = point;
      this.lblInfo.Name = "lblInfo";
      size = new Size(0x1f0, 0x30);
      this.lblInfo.Size = size;
      this.lblInfo.TabIndex = 12;
      this.lblInfo.Text = "With this dialog you can orginze your MP3 files within folders using the TAG information. Enter the format using the parameters above. To save the format give it a description (using the following syntax: \"Description: Format\") and add it to the list.";
      this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
      this.chkOverwrite.Checked = true;
      this.chkOverwrite.CheckState = CheckState.Checked;
      this.chkOverwrite.ImeMode = ImeMode.NoControl;
      point = new Point(0x10, 0x15c);
      this.chkOverwrite.Location = point;
      this.chkOverwrite.Name = "chkOverwrite";
      size = new Size(0xe0, 0x10);
      this.chkOverwrite.Size = size;
      this.chkOverwrite.TabIndex = 15;
      this.chkOverwrite.Text = "Overwrite existing files";
      point = new Point(0x108, 0x15c);
      this.chkCopy.Location = point;
      this.chkCopy.Name = "chkCopy";
      size = new Size(0xe8, 0x10);
      this.chkCopy.Size = size;
      this.chkCopy.TabIndex = 0x10;
      this.chkCopy.Text = "Copy the files instead of moving them";
      this.AcceptButton = this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = this.btnCancel;
      size = new Size(0x202, 0x198);
      this.ClientSize = size;
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
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmOrganize";
      this.ShowInTaskbar = false;
      this.Text = "Organize files";
      this.framePara.ResumeLayout(false);
      this.txtDigits.EndInit();
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

    private void optID3V1_CheckedChanged(object sender, EventArgs e)
    {
      if (BooleanType.FromObject(LateBinding.LateGet(sender, null, "checked", new object[0], null, null)))
      {
        this.L8.Visible = false;
        this.L9.Visible = false;
        this.L10.Visible = false;
        this.L11.Visible = false;
        this.L12.Visible = false;
        this.L13.Visible = false;
        this.L14.Visible = false;
        this.L15.Visible = false;
        this.L16.Visible = false;
        this.L17.Visible = false;
      }
      else
      {
        this.L8.Visible = true;
        this.L9.Visible = true;
        this.L10.Visible = true;
        this.L11.Visible = true;
        this.L12.Visible = true;
        this.L13.Visible = true;
        this.L14.Visible = true;
        this.L15.Visible = true;
        this.L16.Visible = true;
        this.L17.Visible = true;
      }
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
              this.MainForm.SplitterBottom.Expanded = true;
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
          this.MainForm.SplitterBottom.Expanded = true;
        }
        frmProg.ProgressBar.PerformStep();
      }
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
          this._btnAdd.Click -= new EventHandler(this.btnAdd_Click);

        this._btnAdd = value;

        if (this._btnAdd != null)
          this._btnAdd.Click += new EventHandler(this.btnAdd_Click);
      }
    }

    internal virtual Button btnBrowse
    {
      get
      {
        return this._btnBrowse;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnBrowse != null)
          this._btnBrowse.Click -= new EventHandler(this.btnBrowse_Click);

        this._btnBrowse = value;

        if (this._btnBrowse != null)
          this._btnBrowse.Click += new EventHandler(this.btnBrowse_Click);
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
        this._btnCancel = value;
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
          this._btnOK.Click -= new EventHandler(this.btnOK_Click);

        this._btnOK = value;

        if (this._btnOK != null)
          this._btnOK.Click += new EventHandler(this.btnOK_Click);
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
          this._btnRemove.Click -= new EventHandler(this.btnRemove_Click);

        this._btnRemove = value;

        if (this._btnRemove != null)
          this._btnRemove.Click += new EventHandler(this.btnRemove_Click);
      }
    }

    internal virtual CheckBox chkCopy
    {
      get
      {
        return this._chkCopy;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._chkCopy = value;
      }
    }

    internal virtual CheckBox chkOverwrite
    {
      get
      {
        return this._chkOverwrite;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._chkOverwrite = value;
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
          this._cmbFormat.KeyPress -= new KeyPressEventHandler(this.cmbFormat_KeyPress);

        this._cmbFormat = value;

        if (this._cmbFormat != null)
          this._cmbFormat.KeyPress += new KeyPressEventHandler(this.cmbFormat_KeyPress);
      }
    }

    internal virtual System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog
    {
      get
      {
        return this._FolderBrowserDialog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._FolderBrowserDialog = value;
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
        this._framePara = value;
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
          this._L1.Click -= new EventHandler(this.Label_Click);

        this._L1 = value;

        if (this._L1 != null)
          this._L1.Click += new EventHandler(this.Label_Click);
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
          this._L10.Click -= new EventHandler(this.Label_Click);

        this._L10 = value;

        if (this._L10 != null)
          this._L10.Click += new EventHandler(this.Label_Click);
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
          this._L11.Click -= new EventHandler(this.Label_Click);

        this._L11 = value;

        if (this._L11 != null)
          this._L11.Click += new EventHandler(this.Label_Click);
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
          this._L12.Click -= new EventHandler(this.Label_Click);

        this._L12 = value;

        if (this._L12 != null)
          this._L12.Click += new EventHandler(this.Label_Click);
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
          this._L13.Click -= new EventHandler(this.Label_Click);

        this._L13 = value;

        if (this._L13 != null)
          this._L13.Click += new EventHandler(this.Label_Click);
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
          this._L14.Click -= new EventHandler(this.Label_Click);

        this._L14 = value;

        if (this._L14 != null)
          this._L14.Click += new EventHandler(this.Label_Click);
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
          this._L15.Click -= new EventHandler(this.Label_Click);

        this._L15 = value;

        if (this._L15 != null)
          this._L15.Click += new EventHandler(this.Label_Click);
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
          this._L16.Click -= new EventHandler(this.Label_Click);

        this._L16 = value;

        if (this._L16 != null)
          this._L16.Click += new EventHandler(this.Label_Click);
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
          this._L17.Click -= new EventHandler(this.Label_Click);

        this._L17 = value;

        if (this._L17 != null)
          this._L17.Click += new EventHandler(this.Label_Click);
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
          this._L18.Click -= new EventHandler(this.Label_Click);

        this._L18 = value;

        if (this._L18 != null)
          this._L18.Click += new EventHandler(this.Label_Click);
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
          this._L19.Click -= new EventHandler(this.Label_Click);

        this._L19 = value;

        if (this._L19 != null)
          this._L19.Click += new EventHandler(this.Label_Click);
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
          this._L2.Click -= new EventHandler(this.Label_Click);

        this._L2 = value;

        if (this._L2 != null)
          this._L2.Click += new EventHandler(this.Label_Click);
      }
    }

    internal virtual Label L20
    {
      get
      {
        return this._L20;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._L20 = value;
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
          this._L3.Click -= new EventHandler(this.Label_Click);

        this._L3 = value;

        if (this._L3 != null)
          this._L3.Click += new EventHandler(this.Label_Click);
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
          this._L4.Click -= new EventHandler(this.Label_Click);

        this._L4 = value;

        if (this._L4 != null)
          this._L4.Click += new EventHandler(this.Label_Click);
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
          this._L5.Click -= new EventHandler(this.Label_Click);

        this._L5 = value;

        if (this._L5 != null)
          this._L5.Click += new EventHandler(this.Label_Click);
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
          this._L6.Click -= new EventHandler(this.Label_Click);

        this._L6 = value;

        if (this._L6 != null)
          this._L6.Click += new EventHandler(this.Label_Click);
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
          this._L7.Click -= new EventHandler(this.Label_Click);

        this._L7 = value;

        if (this._L7 != null)
          this._L7.Click += new EventHandler(this.Label_Click);
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
          this._L8.Click -= new EventHandler(this.Label_Click);

        this._L8 = value;

        if (this._L8 != null)
          this._L8.Click += new EventHandler(this.Label_Click);
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
          this._L9.Click -= new EventHandler(this.Label_Click);

        this._L9 = value;

        if (this._L9 != null)
          this._L9.Click += new EventHandler(this.Label_Click);
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
        this._lblDigits = value;
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
        this._lblFormat = value;
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
        this._lblInfo = value;
      }
    }

    internal virtual Label lblPath
    {
      get
      {
        return this._lblPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._lblPath = value;
      }
    }

    internal virtual RadioButton optID3V1
    {
      get
      {
        return this._optID3V1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._optID3V1 != null)
          this._optID3V1.CheckedChanged -= new EventHandler(this.optID3V1_CheckedChanged);

        this._optID3V1 = value;

        if (this._optID3V1 != null)
          this._optID3V1.CheckedChanged += new EventHandler(this.optID3V1_CheckedChanged);
      }
    }

    internal virtual RadioButton optID3V2
    {
      get
      {
        return this._optID3V2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._optID3V2 = value;
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
        this._ToolTip = value;
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
          this._txtDigits.Validated -= new EventHandler(this.txtDigits_Validated);

        this._txtDigits = value;

        if (this._txtDigits != null)
          this._txtDigits.Validated += new EventHandler(this.txtDigits_Validated);
      }
    }

    private TextBox txtPath
    {
      get
      {
        return this._txtPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPath != null)
          this._txtPath.KeyPress -= new KeyPressEventHandler(this.txtPath_KeyPress);

        this._txtPath = value;

        if (this._txtPath != null)
          this._txtPath.KeyPress += new KeyPressEventHandler(this.txtPath_KeyPress);
      }
    }
  }
}