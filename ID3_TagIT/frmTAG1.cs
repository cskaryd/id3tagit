namespace ID3_TagIT
{
  using AMS.TextBox;
  using DevComponents.DotNetBar;
  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.Collections;
  using System.ComponentModel;
  using System.Data;
  using System.Diagnostics;
  using System.Drawing;
  using System.Resources;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public class frmTAG1 : Form
  {
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnExport")]
    private ButtonItem _btnExport;
    [AccessedThroughProperty("btnGet")]
    private ButtonItem _btnGet;
    [AccessedThroughProperty("btnImport")]
    private ButtonItem _btnImport;
    [AccessedThroughProperty("btnNext")]
    private ButtonItem _btnNext;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnPrev")]
    private ButtonItem _btnPrev;
    [AccessedThroughProperty("btnSwapAA")]
    private ButtonItem _btnSwapAA;
    [AccessedThroughProperty("btnSwapAT")]
    private ButtonItem _btnSwapAT;
    [AccessedThroughProperty("btnSwapTA")]
    private ButtonItem _btnSwapTA;
    [AccessedThroughProperty("ButtomPanel")]
    private PanelEx _ButtomPanel;
    [AccessedThroughProperty("cmbArtist")]
    private ComboBoxAutoComplete _cmbArtist;
    [AccessedThroughProperty("cmbGenre")]
    private ComboBoxAutoComplete _cmbGenre;
    [AccessedThroughProperty("lblAlbum")]
    private Label _lblAlbum;
    [AccessedThroughProperty("lblArtist")]
    private Label _lblArtist;
    [AccessedThroughProperty("lblComment")]
    private Label _lblComment;
    [AccessedThroughProperty("lblGenre")]
    private Label _lblGenre;
    [AccessedThroughProperty("lblSelected")]
    private Label _lblSelected;
    [AccessedThroughProperty("lblTitle")]
    private Label _lblTitle;
    [AccessedThroughProperty("lblTrack")]
    private Label _lblTrack;
    [AccessedThroughProperty("lblYear")]
    private Label _lblYear;
    [AccessedThroughProperty("SelectionBar")]
    private ExplorerBar _SelectionBar;
    [AccessedThroughProperty("TAGV2ButtonItem1")]
    private ButtonItem _TAGV2ButtonItem1;
    [AccessedThroughProperty("TAGV2ButtonItem10")]
    private ButtonItem _TAGV2ButtonItem10;
    [AccessedThroughProperty("TAGV2ButtonItem2")]
    private ButtonItem _TAGV2ButtonItem2;
    [AccessedThroughProperty("TAGV2ButtonItem3")]
    private ButtonItem _TAGV2ButtonItem3;
    [AccessedThroughProperty("TAGV2ButtonItem4")]
    private ButtonItem _TAGV2ButtonItem4;
    [AccessedThroughProperty("TAGV2ButtonItem5")]
    private ButtonItem _TAGV2ButtonItem5;
    [AccessedThroughProperty("TAGV2ButtonItem6")]
    private ButtonItem _TAGV2ButtonItem6;
    [AccessedThroughProperty("TAGV2ButtonItem7")]
    private ButtonItem _TAGV2ButtonItem7;
    [AccessedThroughProperty("TAGV2ButtonItem8")]
    private ButtonItem _TAGV2ButtonItem8;
    [AccessedThroughProperty("TAGV2ButtonItem9")]
    private ButtonItem _TAGV2ButtonItem9;
    [AccessedThroughProperty("TAGV2grpCommands")]
    private ExplorerBarGroupItem _TAGV2grpCommands;
    [AccessedThroughProperty("ToolTip")]
    private System.Windows.Forms.ToolTip _ToolTip;
    [AccessedThroughProperty("TopPanel")]
    private PanelEx _TopPanel;
    [AccessedThroughProperty("txtAlbum")]
    private System.Windows.Forms.TextBox _txtAlbum;
    [AccessedThroughProperty("txtComment")]
    private System.Windows.Forms.TextBox _txtComment;
    [AccessedThroughProperty("txtSelected")]
    private System.Windows.Forms.TextBox _txtSelected;
    [AccessedThroughProperty("txtTitle")]
    private System.Windows.Forms.TextBox _txtTitle;
    [AccessedThroughProperty("txtTrack")]
    private NumericTextBox _txtTrack;
    [AccessedThroughProperty("txtYear")]
    private NumericTextBox _txtYear;
    private IContainer components;
    private Control FocusedControl;
    private frmMain MainForm;
    private ID3_TagIT.MP3 MP3;

    public frmTAG1(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG1_Load);
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    private void AddSelectionBar()
    {
      IEnumerator enumerator = null;
      try
      {
        enumerator = this.SelectionBar.Groups.GetEnumerator();
        while (enumerator.MoveNext())
        {
          ExplorerBarGroupItem current = (ExplorerBarGroupItem)enumerator.Current;
          current.Text = StringType.FromObject(Declarations.objResources.SelectionBar[current.Name]);
          try
          {
            foreach (ButtonItem item in current.SubItems)
            {
              item.Text = StringType.FromObject(Declarations.objResources.SelectionBar[item.Name]);
            }
            continue;
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
            continue;
          }
        }
      }
      finally
      {
        if (enumerator is IDisposable)
        {
          ((IDisposable)enumerator).Dispose();
        }
      }
    }

    private void AddToolTips()
    {
      string vstrName = "frmTAG1";
      Control txtAlbum = this.txtAlbum;
      this.txtAlbum = (System.Windows.Forms.TextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));
      vstrName = "frmTAG1";
      txtAlbum = this.txtComment;
      this.txtComment = (System.Windows.Forms.TextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtComment, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));
      vstrName = "frmTAG1";
      txtAlbum = this.txtTitle;
      this.txtTitle = (System.Windows.Forms.TextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtTitle, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));
      vstrName = "frmTAG1";
      txtAlbum = this.txtTrack;
      this.txtTrack = (NumericTextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtTrack, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));
      vstrName = "frmTAG1";
      txtAlbum = this.txtYear;
      this.txtYear = (NumericTextBox)txtAlbum;
      this.ToolTip.SetToolTip(this.txtYear, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));
      vstrName = "frmTAG1";
      txtAlbum = this.cmbArtist;
      this.cmbArtist = (ComboBoxAutoComplete)txtAlbum;
      this.ToolTip.SetToolTip(this.cmbArtist, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));
      vstrName = "frmTAG1";
      txtAlbum = this.cmbGenre;
      this.cmbGenre = (ComboBoxAutoComplete)txtAlbum;
      this.ToolTip.SetToolTip(this.cmbGenre, Declarations.objResources.GetToolTip(ref vstrName, ref txtAlbum));
    }

    private void btnNext_Click(object sender, EventArgs e)
    {
      this.SaveToTAG();
      if (this.MainForm.MP3View.FocusedItem.Index < (this.MainForm.MP3View.Items.Count - 1))
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.FocusedItem.Index + 1].Focused = true;
        this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
        this.ClearForm();
        this.FillForm();
        if (this.ActiveControl == this.btnNext)
        {
          this.FocusedControl.Focus();
        }
      }
      else if (this.ActiveControl == this.btnNext)
      {
        this.FocusedControl.Focus();
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      Form form = this;
      Main.SaveFormSettings(ref form);
      this.SaveToTAG();
      this.Close();
    }

    private void btnPrev_Click(object sender, EventArgs e)
    {
      this.SaveToTAG();
      if (this.MainForm.MP3View.FocusedItem.Index != 0)
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.FocusedItem.Index - 1].Focused = true;
        this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
        this.ClearForm();
        this.FillForm();
        if (this.ActiveControl == this.btnPrev)
        {
          this.FocusedControl.Focus();
        }
      }
      else if (this.ActiveControl == this.btnPrev)
      {
        this.FocusedControl.Focus();
      }
    }

    private void btnSwapAA_Click(object sender, EventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtAlbum.Text;
      this.txtAlbum.Text = text;
    }

    private void btnSwapAT_Click(object sender, EventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtTitle.Text;
      this.txtTitle.Text = text;
    }

    private void btnSwapTA_Click(object sender, EventArgs e)
    {
      string text = this.txtTitle.Text;
      this.txtTitle.Text = this.txtAlbum.Text;
      this.txtAlbum.Text = text;
    }

    private void ClearForm()
    {
      this.cmbArtist.Text = "";
      this.txtTitle.Text = "";
      this.txtAlbum.Text = "";
      this.txtTrack.Text = "";
      this.txtYear.Text = "";
      this.cmbGenre.Text = "";
      this.txtComment.Text = "";
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void FillForm()
    {
      this.cmbArtist.Autocomplete = false;
      if (this.MP3.V1TAG.TAGVersion < 11)
      {
        this.txtComment.MaxLength = 30;
      }
      else
      {
        this.txtComment.MaxLength = 0x1c;
      }
      this.txtSelected.Text = this.MP3.CurrentFullName;
      this.cmbArtist.Text = this.MP3.V1TAG.Artist;
      this.txtTitle.Text = this.MP3.V1TAG.Title;
      this.txtAlbum.Text = this.MP3.V1TAG.Album;
      try
      {
        this.txtTrack.Text = StringType.FromObject(Interaction.IIf(this.MP3.V1TAG.Tracknumber == 0, "", this.MP3.V1TAG.Tracknumber.ToString()));
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
      try
      {
        this.txtYear.Text = StringType.FromObject(Interaction.IIf(this.MP3.V1TAG.Year == 0, "", this.MP3.V1TAG.Year.ToString()));
      }
      catch (Exception exception2)
      {
        ProjectData.SetProjectError(exception2);
        ProjectData.ClearProjectError();
      }
      this.cmbGenre.Text = this.MP3.V1TAG.GenreText;
      this.txtComment.Text = this.MP3.V1TAG.Comment;
      this.cmbArtist.Autocomplete = true;
    }

    private void Focus_Leave(object sender, EventArgs e)
    {
      this.FocusedControl = (Control)sender;
    }

    private void frmTAG1_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
      if (this.MainForm.MP3View.FocusedItem == null)
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.SelectedItems[0].Index].Focused = true;
      }
      this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.SelectedItems[0].Tag;
      this.FocusedControl = this.cmbArtist;
      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
      {
        this.cmbArtist.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
      this.cmbGenre.Items.Add("");
      foreach (DataRow row in Declarations.objSettings.Genres.Rows)
      {
        this.cmbGenre.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
      foreach (string str in Declarations.astrGenreLookup)
      {
        this.cmbGenre.Items.Add(str);
      }
      this.cmbGenre.Sorted = true;
      this.cmbGenre.Sorted = false;
      this.FillForm();
      this.AddSelectionBar();
      this.AddToolTips();
      this.cmbArtist.Select();
      this.cmbArtist.Focus();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      ResourceManager manager = new ResourceManager(typeof(frmTAG1));
      this.lblSelected = new Label();
      this.txtSelected = new System.Windows.Forms.TextBox();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.lblGenre = new Label();
      this.txtAlbum = new System.Windows.Forms.TextBox();
      this.lblComment = new Label();
      this.lblTitle = new Label();
      this.lblAlbum = new Label();
      this.lblYear = new Label();
      this.lblTrack = new Label();
      this.lblArtist = new Label();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.txtTitle = new System.Windows.Forms.TextBox();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.cmbArtist = new ComboBoxAutoComplete();
      this.cmbGenre = new ComboBoxAutoComplete();
      this.txtTrack = new NumericTextBox();
      this.txtYear = new NumericTextBox();
      this.SelectionBar = new ExplorerBar();
      this.TAGV2grpCommands = new ExplorerBarGroupItem();
      this.btnPrev = new ButtonItem();
      this.btnNext = new ButtonItem();
      this.btnSwapAT = new ButtonItem();
      this.btnSwapAA = new ButtonItem();
      this.btnSwapTA = new ButtonItem();
      this.TAGV2ButtonItem1 = new ButtonItem();
      this.TAGV2ButtonItem2 = new ButtonItem();
      this.TAGV2ButtonItem3 = new ButtonItem();
      this.TAGV2ButtonItem4 = new ButtonItem();
      this.TAGV2ButtonItem5 = new ButtonItem();
      this.TAGV2ButtonItem6 = new ButtonItem();
      this.TAGV2ButtonItem7 = new ButtonItem();
      this.TAGV2ButtonItem8 = new ButtonItem();
      this.TAGV2ButtonItem9 = new ButtonItem();
      this.TAGV2ButtonItem10 = new ButtonItem();
      this.btnImport = new ButtonItem();
      this.btnExport = new ButtonItem();
      this.btnGet = new ButtonItem();
      this.ButtomPanel = new PanelEx();
      this.TopPanel = new PanelEx();
      ((ISupportInitialize)this.SelectionBar).BeginInit();
      this.ButtomPanel.SuspendLayout();
      this.TopPanel.SuspendLayout();
      this.SuspendLayout();
      this.lblSelected.BackColor = Color.White;
      this.lblSelected.ForeColor = Color.Black;
      this.lblSelected.ImeMode = ImeMode.NoControl;
      Point point = new Point(8, 8);
      this.lblSelected.Location = point;
      this.lblSelected.Name = "lblSelected";
      Size size = new Size(0x98, 0x10);
      this.lblSelected.Size = size;
      this.lblSelected.TabIndex = 0x13;
      this.lblSelected.Text = "Selected file:";
      this.txtSelected.BackColor = Color.White;
      this.txtSelected.BorderStyle = BorderStyle.None;
      this.txtSelected.ForeColor = Color.Black;
      point = new Point(8, 0x18);
      this.txtSelected.Location = point;
      this.txtSelected.Name = "txtSelected";
      this.txtSelected.ReadOnly = true;
      size = new Size(440, 13);
      this.txtSelected.Size = size;
      this.txtSelected.TabIndex = 20;
      this.txtSelected.Text = "";
      this.btnCancel.BackColor = SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      point = new Point(0x150, 8);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(0x70, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x10;
      this.btnCancel.Text = "&Cancel";
      this.btnOK.BackColor = SystemColors.Control;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(0xd8, 8);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(0x70, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 15;
      this.btnOK.Text = "&OK";
      this.lblGenre.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0xb0);
      this.lblGenre.Location = point;
      this.lblGenre.Name = "lblGenre";
      size = new Size(0x90, 0x10);
      this.lblGenre.Size = size;
      this.lblGenre.TabIndex = 10;
      this.lblGenre.Text = "&Genres:";
      point = new Point(0x148, 0x66);
      this.txtAlbum.Location = point;
      this.txtAlbum.MaxLength = 30;
      this.txtAlbum.Name = "txtAlbum";
      size = new Size(0x120, 20);
      this.txtAlbum.Size = size;
      this.txtAlbum.TabIndex = 5;
      this.txtAlbum.Text = "";
      this.lblComment.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 200);
      this.lblComment.Location = point;
      this.lblComment.Name = "lblComment";
      size = new Size(0x90, 0x10);
      this.lblComment.Size = size;
      this.lblComment.TabIndex = 12;
      this.lblComment.Text = "&Comment:";
      this.lblTitle.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 80);
      this.lblTitle.Location = point;
      this.lblTitle.Name = "lblTitle";
      size = new Size(0x90, 0x10);
      this.lblTitle.Size = size;
      this.lblTitle.TabIndex = 2;
      this.lblTitle.Text = "&Title:";
      this.lblAlbum.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0x68);
      this.lblAlbum.Location = point;
      this.lblAlbum.Name = "lblAlbum";
      size = new Size(0x90, 0x10);
      this.lblAlbum.Size = size;
      this.lblAlbum.TabIndex = 4;
      this.lblAlbum.Text = "Al&bum:";
      this.lblYear.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0x80);
      this.lblYear.Location = point;
      this.lblYear.Name = "lblYear";
      size = new Size(0x90, 0x10);
      this.lblYear.Size = size;
      this.lblYear.TabIndex = 6;
      this.lblYear.Text = "&Year:";
      this.lblTrack.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0x98);
      this.lblTrack.Location = point;
      this.lblTrack.Name = "lblTrack";
      size = new Size(0x90, 0x10);
      this.lblTrack.Size = size;
      this.lblTrack.TabIndex = 8;
      this.lblTrack.Text = "&Track number:";
      this.lblArtist.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0x38);
      this.lblArtist.Location = point;
      this.lblArtist.Name = "lblArtist";
      size = new Size(0x90, 0x10);
      this.lblArtist.Size = size;
      this.lblArtist.TabIndex = 0;
      this.lblArtist.Text = "Lead &Artist:";
      point = new Point(0x148, 0xc6);
      this.txtComment.Location = point;
      this.txtComment.MaxLength = 30;
      this.txtComment.Name = "txtComment";
      size = new Size(0x120, 20);
      this.txtComment.Size = size;
      this.txtComment.TabIndex = 13;
      this.txtComment.Text = "";
      point = new Point(0x148, 0x4e);
      this.txtTitle.Location = point;
      this.txtTitle.MaxLength = 30;
      this.txtTitle.Name = "txtTitle";
      size = new Size(0x120, 20);
      this.txtTitle.Size = size;
      this.txtTitle.TabIndex = 3;
      this.txtTitle.Text = "";
      this.cmbArtist.Autocomplete = true;
      this.cmbArtist.ItemHeight = 13;
      point = new Point(0x148, 0x36);
      this.cmbArtist.Location = point;
      this.cmbArtist.MaxLength = 30;
      this.cmbArtist.Name = "cmbArtist";
      size = new Size(0x120, 0x15);
      this.cmbArtist.Size = size;
      this.cmbArtist.TabIndex = 1;
      this.cmbGenre.Autocomplete = true;
      this.cmbGenre.ItemHeight = 13;
      this.cmbGenre.ListItemsOnly = true;
      point = new Point(0x148, 0xae);
      this.cmbGenre.Location = point;
      this.cmbGenre.Name = "cmbGenre";
      size = new Size(0x120, 0x15);
      this.cmbGenre.Size = size;
      this.cmbGenre.TabIndex = 11;
      this.txtTrack.AllowNegative = true;
      this.txtTrack.DigitsInGroup = 0;
      this.txtTrack.Flags = 0x10;
      point = new Point(0x148, 150);
      this.txtTrack.Location = point;
      this.txtTrack.MaxDecimalPlaces = 0;
      this.txtTrack.MaxLength = 3;
      this.txtTrack.MaxWholeDigits = 3;
      this.txtTrack.Name = "txtTrack";
      this.txtTrack.Prefix = "";
      this.txtTrack.RangeMax = 255.0;
      this.txtTrack.RangeMin = 1.0;
      size = new Size(0x40, 20);
      this.txtTrack.Size = size;
      this.txtTrack.TabIndex = 9;
      this.txtYear.AllowNegative = true;
      this.txtYear.DigitsInGroup = 0;
      this.txtYear.Flags = 0x10;
      point = new Point(0x148, 0x7e);
      this.txtYear.Location = point;
      this.txtYear.MaxDecimalPlaces = 0;
      this.txtYear.MaxLength = 4;
      this.txtYear.MaxWholeDigits = 4;
      this.txtYear.Name = "txtYear";
      this.txtYear.Prefix = "";
      this.txtYear.RangeMax = 9999.0;
      this.txtYear.RangeMin = 1800.0;
      size = new Size(0x40, 20);
      this.txtYear.Size = size;
      this.txtYear.TabIndex = 7;
      this.SelectionBar.AccessibleRole = AccessibleRole.ToolBar;
      this.SelectionBar.AllowUserCustomize = false;
      this.SelectionBar.AntiAlias = true;
      this.SelectionBar.BackColor = SystemColors.Control;
      this.SelectionBar.BackgroundStyle.BackColor1.ColorSchemePart = eColorSchemePart.ExplorerBarBackground;
      this.SelectionBar.BackgroundStyle.BackColor2.ColorSchemePart = eColorSchemePart.ExplorerBarBackground2;
      this.SelectionBar.BackgroundStyle.GradientAngle = 90;
      this.SelectionBar.Dock = DockStyle.Left;
      this.SelectionBar.Font = new Font("Tahoma", 11f, FontStyle.Regular, GraphicsUnit.World);
      this.SelectionBar.GroupImages = null;
      this.SelectionBar.Groups.AddRange(new BaseItem[] { this.TAGV2grpCommands });
      this.SelectionBar.Images = null;
      point = new Point(0, 0);
      this.SelectionBar.Location = point;
      this.SelectionBar.Name = "SelectionBar";
      size = new Size(0xa8, 0x110);
      this.SelectionBar.Size = size;
      this.SelectionBar.TabIndex = 0x11;
      this.SelectionBar.Text = "Select TAG section";
      this.TAGV2grpCommands.BackgroundStyle.BackColor1.Color = Color.FromArgb(0xd6, 0xdf, 0xf7);
      this.TAGV2grpCommands.BackgroundStyle.Border = eBorderType.SingleLine;
      this.TAGV2grpCommands.BackgroundStyle.BorderColor.Color = Color.White;
      this.TAGV2grpCommands.CanCustomize = false;
      this.TAGV2grpCommands.Expanded = true;
      this.TAGV2grpCommands.HeaderHotStyle.BackColor1.Color = Color.White;
      this.TAGV2grpCommands.HeaderHotStyle.BackColor2.Color = Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.TAGV2grpCommands.HeaderHotStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.TAGV2grpCommands.HeaderHotStyle.ForeColor.Color = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2grpCommands.HeaderStyle.BackColor1.Color = Color.White;
      this.TAGV2grpCommands.HeaderStyle.BackColor2.Color = Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.TAGV2grpCommands.HeaderStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.TAGV2grpCommands.HeaderStyle.ForeColor.Color = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2grpCommands.Name = "TAGV2grpCommands";
      this.TAGV2grpCommands.StockStyle = eExplorerBarStockStyle.Blue;
      this.TAGV2grpCommands.SubItems.AddRange(new BaseItem[] { this.btnPrev, this.btnNext, this.btnSwapAT, this.btnSwapAA, this.btnSwapTA });
      this.TAGV2grpCommands.Text = "Commands";
      this.btnPrev.ButtonStyle = eButtonStyle.ImageAndText;
      this.btnPrev.Cursor = Cursors.Hand;
      this.btnPrev.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.btnPrev.HotFontUnderline = true;
      this.btnPrev.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.btnPrev.HotTrackingStyle = eHotTrackingStyle.None;
      this.btnPrev.Icon = (Icon)manager.GetObject("btnPrev.Icon");
      this.btnPrev.Name = "btnPrev";
      this.btnPrev.Shortcuts.Add(eShortcut.CtrlB);
      this.btnPrev.Text = "Previous File";
      this.btnNext.ButtonStyle = eButtonStyle.ImageAndText;
      this.btnNext.Cursor = Cursors.Hand;
      this.btnNext.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.btnNext.HotFontUnderline = true;
      this.btnNext.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.btnNext.HotTrackingStyle = eHotTrackingStyle.None;
      this.btnNext.Icon = (Icon)manager.GetObject("btnNext.Icon");
      this.btnNext.Name = "btnNext";
      this.btnNext.Shortcuts.Add(eShortcut.CtrlN);
      this.btnNext.Text = "Next File";
      this.btnSwapAT.ButtonStyle = eButtonStyle.ImageAndText;
      this.btnSwapAT.Cursor = Cursors.Hand;
      this.btnSwapAT.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.btnSwapAT.HotFontUnderline = true;
      this.btnSwapAT.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.btnSwapAT.HotTrackingStyle = eHotTrackingStyle.None;
      this.btnSwapAT.Name = "btnSwapAT";
      this.btnSwapAT.Text = "Swap Artist-Title";
      this.btnSwapAA.ButtonStyle = eButtonStyle.ImageAndText;
      this.btnSwapAA.Cursor = Cursors.Hand;
      this.btnSwapAA.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.btnSwapAA.HotFontUnderline = true;
      this.btnSwapAA.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.btnSwapAA.HotTrackingStyle = eHotTrackingStyle.None;
      this.btnSwapAA.Name = "btnSwapAA";
      this.btnSwapAA.Text = "Swap Artist-Album";
      this.btnSwapTA.ButtonStyle = eButtonStyle.ImageAndText;
      this.btnSwapTA.Cursor = Cursors.Hand;
      this.btnSwapTA.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.btnSwapTA.HotFontUnderline = true;
      this.btnSwapTA.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.btnSwapTA.HotTrackingStyle = eHotTrackingStyle.None;
      this.btnSwapTA.Name = "btnSwapTA";
      this.btnSwapTA.Text = "Swap Title-Album";
      this.TAGV2ButtonItem1.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem1.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem1.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem1.HotFontUnderline = true;
      this.TAGV2ButtonItem1.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem1.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem1.Name = "TAGV2ButtonItem1";
      this.TAGV2ButtonItem1.Text = "Main Entries";
      this.TAGV2ButtonItem2.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem2.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem2.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem2.HotFontUnderline = true;
      this.TAGV2ButtonItem2.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem2.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem2.Name = "TAGV2ButtonItem2";
      this.TAGV2ButtonItem2.Text = "Detailed information";
      this.TAGV2ButtonItem3.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem3.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem3.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem3.HotFontUnderline = true;
      this.TAGV2ButtonItem3.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem3.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem3.Name = "TAGV2ButtonItem3";
      this.TAGV2ButtonItem3.Text = "Original information";
      this.TAGV2ButtonItem4.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem4.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem4.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem4.HotFontUnderline = true;
      this.TAGV2ButtonItem4.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem4.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem4.Name = "TAGV2ButtonItem4";
      this.TAGV2ButtonItem4.Text = "Involved people";
      this.TAGV2ButtonItem5.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem5.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem5.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem5.HotFontUnderline = true;
      this.TAGV2ButtonItem5.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem5.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem5.Name = "TAGV2ButtonItem5";
      this.TAGV2ButtonItem5.Text = "Web information";
      this.TAGV2ButtonItem6.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem6.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem6.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem6.HotFontUnderline = true;
      this.TAGV2ButtonItem6.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem6.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem6.Name = "TAGV2ButtonItem6";
      this.TAGV2ButtonItem6.Text = "Pictures";
      this.TAGV2ButtonItem7.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem7.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem7.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem7.HotFontUnderline = true;
      this.TAGV2ButtonItem7.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem7.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem7.Name = "TAGV2ButtonItem7";
      this.TAGV2ButtonItem7.Text = "Lyrics";
      this.TAGV2ButtonItem8.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem8.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem8.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem8.HotFontUnderline = true;
      this.TAGV2ButtonItem8.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem8.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem8.Name = "TAGV2ButtonItem8";
      this.TAGV2ButtonItem8.Text = "Rating";
      this.TAGV2ButtonItem9.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem9.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem9.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem9.HotFontUnderline = true;
      this.TAGV2ButtonItem9.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem9.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem9.Name = "TAGV2ButtonItem9";
      this.TAGV2ButtonItem9.Text = "User defined information";
      this.TAGV2ButtonItem10.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem10.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem10.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem10.HotFontUnderline = true;
      this.TAGV2ButtonItem10.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem10.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem10.Name = "TAGV2ButtonItem10";
      this.TAGV2ButtonItem10.Text = "Not supported frames";
      this.btnImport.ButtonStyle = eButtonStyle.ImageAndText;
      this.btnImport.Cursor = Cursors.Hand;
      this.btnImport.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.btnImport.HotFontUnderline = true;
      this.btnImport.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.btnImport.HotTrackingStyle = eHotTrackingStyle.None;
      this.btnImport.Name = "btnImport";
      this.btnImport.Text = "Transfer from Ver. 1";
      this.btnExport.ButtonStyle = eButtonStyle.ImageAndText;
      this.btnExport.Cursor = Cursors.Hand;
      this.btnExport.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.btnExport.HotFontUnderline = true;
      this.btnExport.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.btnExport.HotTrackingStyle = eHotTrackingStyle.None;
      this.btnExport.Name = "btnExport";
      this.btnExport.Text = "Transfer to Ver. 1";
      this.btnGet.ButtonStyle = eButtonStyle.ImageAndText;
      this.btnGet.Cursor = Cursors.Hand;
      this.btnGet.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.btnGet.HotFontUnderline = true;
      this.btnGet.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.btnGet.HotTrackingStyle = eHotTrackingStyle.None;
      this.btnGet.Name = "btnGet";
      this.btnGet.Text = "Get from filename";
      this.ButtomPanel.AntiAlias = true;
      this.ButtomPanel.Controls.Add(this.btnOK);
      this.ButtomPanel.Controls.Add(this.btnCancel);
      this.ButtomPanel.Dock = DockStyle.Bottom;
      point = new Point(0xa8, 0xe8);
      this.ButtomPanel.Location = point;
      this.ButtomPanel.Name = "ButtomPanel";
      size = new Size(0x1ca, 40);
      this.ButtomPanel.Size = size;
      this.ButtomPanel.Style.BackColor1.Color = Color.White;
      this.ButtomPanel.Style.BackColor2.Color = Color.White;
      this.ButtomPanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
      this.ButtomPanel.Style.BorderWidth = 0;
      this.ButtomPanel.Style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.ButtomPanel.Style.ForeColor.Color = Color.Black;
      this.ButtomPanel.Style.GradientAngle = 90;
      this.ButtomPanel.Style.LineAlignment = StringAlignment.Near;
      this.ButtomPanel.Style.MarginBottom = 2;
      this.ButtomPanel.Style.MarginLeft = 7;
      this.ButtomPanel.Style.MarginRight = 2;
      this.ButtomPanel.Style.MarginTop = 2;
      this.ButtomPanel.TabIndex = 14;
      this.TopPanel.AntiAlias = true;
      this.TopPanel.Controls.Add(this.txtSelected);
      this.TopPanel.Controls.Add(this.lblSelected);
      this.TopPanel.Dock = DockStyle.Top;
      point = new Point(0xa8, 0);
      this.TopPanel.Location = point;
      this.TopPanel.Name = "TopPanel";
      size = new Size(0x1ca, 0x30);
      this.TopPanel.Size = size;
      this.TopPanel.Style.BackColor1.Color = Color.White;
      this.TopPanel.Style.BackColor2.Color = Color.White;
      this.TopPanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
      this.TopPanel.Style.BorderWidth = 0;
      this.TopPanel.Style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.TopPanel.Style.ForeColor.Color = Color.Black;
      this.TopPanel.Style.GradientAngle = 90;
      this.TopPanel.Style.LineAlignment = StringAlignment.Near;
      this.TopPanel.Style.MarginBottom = 2;
      this.TopPanel.Style.MarginLeft = 7;
      this.TopPanel.Style.MarginRight = 2;
      this.TopPanel.Style.MarginTop = 2;
      this.TopPanel.TabIndex = 0x12;
      this.AcceptButton = this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = this.btnCancel;
      size = new Size(0x272, 0x110);
      this.ClientSize = size;
      this.ControlBox = false;
      this.Controls.Add(this.ButtomPanel);
      this.Controls.Add(this.txtYear);
      this.Controls.Add(this.txtTrack);
      this.Controls.Add(this.cmbGenre);
      this.Controls.Add(this.cmbArtist);
      this.Controls.Add(this.lblGenre);
      this.Controls.Add(this.txtAlbum);
      this.Controls.Add(this.lblComment);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.lblAlbum);
      this.Controls.Add(this.lblYear);
      this.Controls.Add(this.lblTrack);
      this.Controls.Add(this.lblArtist);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.txtTitle);
      this.Controls.Add(this.TopPanel);
      this.Controls.Add(this.SelectionBar);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG1";
      this.ShowInTaskbar = false;
      this.Text = "Edit TAG Ver. 1";
      ((ISupportInitialize)this.SelectionBar).EndInit();
      this.ButtomPanel.ResumeLayout(false);
      this.TopPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void SaveToTAG()
    {
      ArrayList list = new ArrayList();
      Declarations.UnDoReDo @do = new Declarations.UnDoReDo(this.MP3, this.MP3.V1TAG.Clone(), this.MP3.V2TAG.Clone(), this.MP3.CurrentFullName, this.MP3.Changed);
      list.Add(@do);
      Declarations.UNDOList.Add(list);
      this.MainForm.UnDoEnable(true, true);
      if (StringType.StrCmp(this.MP3.V1TAG.Artist, this.cmbArtist.Text, false) != 0)
      {
        this.MP3.V1TAG.Artist = this.cmbArtist.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if (StringType.StrCmp(this.MP3.V1TAG.Title, this.txtTitle.Text, false) != 0)
      {
        this.MP3.V1TAG.Title = this.txtTitle.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if (StringType.StrCmp(this.MP3.V1TAG.Album, this.txtAlbum.Text, false) != 0)
      {
        this.MP3.V1TAG.Album = this.txtAlbum.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if (this.MP3.V1TAG.Year != Conversion.Val(this.txtYear.Text))
      {
        this.MP3.V1TAG.Year = (int)Math.Round(Conversion.Val(this.txtYear.Text));
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if (this.MP3.V1TAG.Tracknumber != Conversion.Val(this.txtTrack.Text))
      {
        this.MP3.V1TAG.Tracknumber = (byte)Math.Round(Conversion.Val(this.txtTrack.Text));
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if (this.MP3.V1TAG.GenreByte != ID3Functions.GetV1GenreByName(this.cmbGenre.Text))
      {
        this.MP3.V1TAG.GenreText = this.cmbGenre.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if (StringType.StrCmp(this.MP3.V1TAG.Comment, this.txtComment.Text, false) != 0)
      {
        this.MP3.V1TAG.Comment = this.txtComment.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if (Declarations.objSettings.SynchronizeTAGs)
      {
        object o = ID3Functions.CreateTextFrame("TPE1", this.cmbArtist.Text);
        if (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = ID3Functions.CreateTextFrame("TIT2", this.txtTitle.Text);
        if (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = ID3Functions.CreateTextFrame("TALB", this.txtAlbum.Text);
        if (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        string text = this.cmbGenre.Text;
        foreach (DataRow row in Declarations.objSettings.Genres.Rows)
        {
          if (ObjectType.ObjTst(row["V1V2"], ID3Functions.GetV1GenreByName(this.cmbGenre.Text), false) == 0)
          {
            text = row["Name"].ToString();
            break;
          }
        }
        o = ID3Functions.CreateTextFrame("TCON", text);
        if (StringType.StrCmp(this.cmbGenre.Text.Trim(new char[] { ' ' }), "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = new V2LDCFrame();
        LateBinding.LateSet(o, null, "FID", new object[] { "COMM" }, null);
        LateBinding.LateSet(o, null, "Language", new object[] { Declarations.astrLanLookup[Declarations.objSettings.V2Language].Substring(0, 3) }, null);
        LateBinding.LateSet(o, null, "Descriptor", new object[] { Declarations.objSettings.TransferCommentD }, null);
        LateBinding.LateSet(o, null, "Content", new object[] { this.txtComment.Text }, null);
        if (StringType.StrCmp(this.txtComment.Text, "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        if (StringType.StrCmp(this.txtYear.Text, "", false) != 0)
        {
          if (!this.MP3.V2TAG.TAGHeaderPresent)
          {
            this.MP3.V2TAG.TAGHeaderPresent = true;
          }
          if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
          {
            o = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text.PadLeft(4, '0'));
            this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
          }
          else
          {
            o = ID3Functions.CreateTextFrame("TDRC", this.txtYear.Text.PadLeft(4, '0'));
            this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
          }
        }
        else if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
        {
          o = ID3Functions.CreateTextFrame("TYER", "0000");
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TDRC", "0000");
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
        if (StringType.StrCmp(this.txtTrack.Text, "", false) != 0)
        {
          o = ID3Functions.CreateTextFrame("TRCK", this.txtTrack.Text.PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'));
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TRCK", "0");
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
        if (this.MP3.V2TAG.Changed)
        {
          if (!this.MP3.V2TAG.TAGHeaderPresent)
          {
            this.MP3.V2TAG.TAGHeaderPresent = true;
          }
          this.MP3.Changed = true;
        }
      }
      this.MainForm.UpdateListItem(this.MainForm.MP3View.FocusedItem, false);
    }

    private void Select_Enter(object sender, EventArgs e)
    {
      object[] objArray3 = new object[2];
      objArray3[0] = 0;
      object o = sender;
      object[] args = new object[0];
      string[] paramnames = null;
      objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(o, null, "Text", args, paramnames, null), null, "Length", new object[0], null, null));
      object[] objArray2 = objArray3;
      bool[] copyBack = new bool[] { false, true };
      LateBinding.LateCall(sender, null, "Select", objArray2, null, copyBack);
      if (copyBack[1])
      {
        LateBinding.LateSetComplex(LateBinding.LateGet(o, null, "Text", args, paramnames, null), null, "Length", new object[] { RuntimeHelpers.GetObjectValue(objArray2[1]) }, null, true, true);
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

    internal virtual ButtonItem btnExport
    {
      get
      {
        return this._btnExport;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnExport != null)
        {
        }
        this._btnExport = value;
        if (this._btnExport != null)
        {
        }
      }
    }

    internal virtual ButtonItem btnGet
    {
      get
      {
        return this._btnGet;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnGet != null)
        {
        }
        this._btnGet = value;
        if (this._btnGet != null)
        {
        }
      }
    }

    internal virtual ButtonItem btnImport
    {
      get
      {
        return this._btnImport;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnImport != null)
        {
        }
        this._btnImport = value;
        if (this._btnImport != null)
        {
        }
      }
    }

    internal virtual ButtonItem btnNext
    {
      get
      {
        return this._btnNext;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnNext != null)
        {
          this._btnNext.Click -= new EventHandler(this.btnNext_Click);
        }
        this._btnNext = value;
        if (this._btnNext != null)
        {
          this._btnNext.Click += new EventHandler(this.btnNext_Click);
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

    internal virtual ButtonItem btnPrev
    {
      get
      {
        return this._btnPrev;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnPrev != null)
        {
          this._btnPrev.Click -= new EventHandler(this.btnPrev_Click);
        }
        this._btnPrev = value;
        if (this._btnPrev != null)
        {
          this._btnPrev.Click += new EventHandler(this.btnPrev_Click);
        }
      }
    }

    internal virtual ButtonItem btnSwapAA
    {
      get
      {
        return this._btnSwapAA;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnSwapAA != null)
        {
          this._btnSwapAA.Click -= new EventHandler(this.btnSwapAA_Click);
        }
        this._btnSwapAA = value;
        if (this._btnSwapAA != null)
        {
          this._btnSwapAA.Click += new EventHandler(this.btnSwapAA_Click);
        }
      }
    }

    internal virtual ButtonItem btnSwapAT
    {
      get
      {
        return this._btnSwapAT;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnSwapAT != null)
        {
          this._btnSwapAT.Click -= new EventHandler(this.btnSwapAT_Click);
        }
        this._btnSwapAT = value;
        if (this._btnSwapAT != null)
        {
          this._btnSwapAT.Click += new EventHandler(this.btnSwapAT_Click);
        }
      }
    }

    internal virtual ButtonItem btnSwapTA
    {
      get
      {
        return this._btnSwapTA;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnSwapTA != null)
        {
          this._btnSwapTA.Click -= new EventHandler(this.btnSwapTA_Click);
        }
        this._btnSwapTA = value;
        if (this._btnSwapTA != null)
        {
          this._btnSwapTA.Click += new EventHandler(this.btnSwapTA_Click);
        }
      }
    }

    internal virtual PanelEx ButtomPanel
    {
      get
      {
        return this._ButtomPanel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ButtomPanel != null)
        {
        }
        this._ButtomPanel = value;
        if (this._ButtomPanel != null)
        {
        }
      }
    }

    internal virtual ComboBoxAutoComplete cmbArtist
    {
      get
      {
        return this._cmbArtist;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbArtist != null)
        {
          this._cmbArtist.Enter -= new EventHandler(this.Select_Enter);
          this._cmbArtist.Leave -= new EventHandler(this.Focus_Leave);
        }
        this._cmbArtist = value;
        if (this._cmbArtist != null)
        {
          this._cmbArtist.Enter += new EventHandler(this.Select_Enter);
          this._cmbArtist.Leave += new EventHandler(this.Focus_Leave);
        }
      }
    }

    internal virtual ComboBoxAutoComplete cmbGenre
    {
      get
      {
        return this._cmbGenre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbGenre != null)
        {
          this._cmbGenre.Enter -= new EventHandler(this.Select_Enter);
          this._cmbGenre.Leave -= new EventHandler(this.Focus_Leave);
        }
        this._cmbGenre = value;
        if (this._cmbGenre != null)
        {
          this._cmbGenre.Enter += new EventHandler(this.Select_Enter);
          this._cmbGenre.Leave += new EventHandler(this.Focus_Leave);
        }
      }
    }

    internal virtual Label lblAlbum
    {
      get
      {
        return this._lblAlbum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblAlbum != null)
        {
        }
        this._lblAlbum = value;
        if (this._lblAlbum != null)
        {
        }
      }
    }

    internal virtual Label lblArtist
    {
      get
      {
        return this._lblArtist;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblArtist != null)
        {
        }
        this._lblArtist = value;
        if (this._lblArtist != null)
        {
        }
      }
    }

    internal virtual Label lblComment
    {
      get
      {
        return this._lblComment;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblComment != null)
        {
        }
        this._lblComment = value;
        if (this._lblComment != null)
        {
        }
      }
    }

    internal virtual Label lblGenre
    {
      get
      {
        return this._lblGenre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblGenre != null)
        {
        }
        this._lblGenre = value;
        if (this._lblGenre != null)
        {
        }
      }
    }

    internal virtual Label lblSelected
    {
      get
      {
        return this._lblSelected;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblSelected != null)
        {
        }
        this._lblSelected = value;
        if (this._lblSelected != null)
        {
        }
      }
    }

    internal virtual Label lblTitle
    {
      get
      {
        return this._lblTitle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblTitle != null)
        {
        }
        this._lblTitle = value;
        if (this._lblTitle != null)
        {
        }
      }
    }

    internal virtual Label lblTrack
    {
      get
      {
        return this._lblTrack;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblTrack != null)
        {
        }
        this._lblTrack = value;
        if (this._lblTrack != null)
        {
        }
      }
    }

    internal virtual Label lblYear
    {
      get
      {
        return this._lblYear;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblYear != null)
        {
        }
        this._lblYear = value;
        if (this._lblYear != null)
        {
        }
      }
    }

    internal virtual ExplorerBar SelectionBar
    {
      get
      {
        return this._SelectionBar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._SelectionBar != null)
        {
        }
        this._SelectionBar = value;
        if (this._SelectionBar != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem1
    {
      get
      {
        return this._TAGV2ButtonItem1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem1 != null)
        {
        }
        this._TAGV2ButtonItem1 = value;
        if (this._TAGV2ButtonItem1 != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem10
    {
      get
      {
        return this._TAGV2ButtonItem10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem10 != null)
        {
        }
        this._TAGV2ButtonItem10 = value;
        if (this._TAGV2ButtonItem10 != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem2
    {
      get
      {
        return this._TAGV2ButtonItem2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem2 != null)
        {
        }
        this._TAGV2ButtonItem2 = value;
        if (this._TAGV2ButtonItem2 != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem3
    {
      get
      {
        return this._TAGV2ButtonItem3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem3 != null)
        {
        }
        this._TAGV2ButtonItem3 = value;
        if (this._TAGV2ButtonItem3 != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem4
    {
      get
      {
        return this._TAGV2ButtonItem4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem4 != null)
        {
        }
        this._TAGV2ButtonItem4 = value;
        if (this._TAGV2ButtonItem4 != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem5
    {
      get
      {
        return this._TAGV2ButtonItem5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem5 != null)
        {
        }
        this._TAGV2ButtonItem5 = value;
        if (this._TAGV2ButtonItem5 != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem6
    {
      get
      {
        return this._TAGV2ButtonItem6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem6 != null)
        {
        }
        this._TAGV2ButtonItem6 = value;
        if (this._TAGV2ButtonItem6 != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem7
    {
      get
      {
        return this._TAGV2ButtonItem7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem7 != null)
        {
        }
        this._TAGV2ButtonItem7 = value;
        if (this._TAGV2ButtonItem7 != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem8
    {
      get
      {
        return this._TAGV2ButtonItem8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem8 != null)
        {
        }
        this._TAGV2ButtonItem8 = value;
        if (this._TAGV2ButtonItem8 != null)
        {
        }
      }
    }

    internal virtual ButtonItem TAGV2ButtonItem9
    {
      get
      {
        return this._TAGV2ButtonItem9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2ButtonItem9 != null)
        {
        }
        this._TAGV2ButtonItem9 = value;
        if (this._TAGV2ButtonItem9 != null)
        {
        }
      }
    }

    internal virtual ExplorerBarGroupItem TAGV2grpCommands
    {
      get
      {
        return this._TAGV2grpCommands;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2grpCommands != null)
        {
        }
        this._TAGV2grpCommands = value;
        if (this._TAGV2grpCommands != null)
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

    internal virtual PanelEx TopPanel
    {
      get
      {
        return this._TopPanel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TopPanel != null)
        {
        }
        this._TopPanel = value;
        if (this._TopPanel != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtAlbum
    {
      get
      {
        return this._txtAlbum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtAlbum != null)
        {
          this._txtAlbum.Enter -= new EventHandler(this.Select_Enter);
          this._txtAlbum.Leave -= new EventHandler(this.Focus_Leave);
        }
        this._txtAlbum = value;
        if (this._txtAlbum != null)
        {
          this._txtAlbum.Enter += new EventHandler(this.Select_Enter);
          this._txtAlbum.Leave += new EventHandler(this.Focus_Leave);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtComment
    {
      get
      {
        return this._txtComment;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtComment != null)
        {
          this._txtComment.Enter -= new EventHandler(this.Select_Enter);
          this._txtComment.Leave -= new EventHandler(this.Focus_Leave);
        }
        this._txtComment = value;
        if (this._txtComment != null)
        {
          this._txtComment.Enter += new EventHandler(this.Select_Enter);
          this._txtComment.Leave += new EventHandler(this.Focus_Leave);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtSelected
    {
      get
      {
        return this._txtSelected;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtSelected != null)
        {
        }
        this._txtSelected = value;
        if (this._txtSelected != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtTitle
    {
      get
      {
        return this._txtTitle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTitle != null)
        {
          this._txtTitle.Enter -= new EventHandler(this.Select_Enter);
          this._txtTitle.Leave -= new EventHandler(this.Focus_Leave);
        }
        this._txtTitle = value;
        if (this._txtTitle != null)
        {
          this._txtTitle.Enter += new EventHandler(this.Select_Enter);
          this._txtTitle.Leave += new EventHandler(this.Focus_Leave);
        }
      }
    }

    internal virtual NumericTextBox txtTrack
    {
      get
      {
        return this._txtTrack;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTrack != null)
        {
          this._txtTrack.Enter -= new EventHandler(this.Select_Enter);
          this._txtTrack.Leave -= new EventHandler(this.Focus_Leave);
        }
        this._txtTrack = value;
        if (this._txtTrack != null)
        {
          this._txtTrack.Enter += new EventHandler(this.Select_Enter);
          this._txtTrack.Leave += new EventHandler(this.Focus_Leave);
        }
      }
    }

    internal virtual NumericTextBox txtYear
    {
      get
      {
        return this._txtYear;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtYear != null)
        {
          this._txtYear.Enter -= new EventHandler(this.Select_Enter);
          this._txtYear.Leave -= new EventHandler(this.Focus_Leave);
        }
        this._txtYear = value;
        if (this._txtYear != null)
        {
          this._txtYear.Enter += new EventHandler(this.Select_Enter);
          this._txtYear.Leave += new EventHandler(this.Focus_Leave);
        }
      }
    }
  }
}