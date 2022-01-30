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
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public class frmTAG1Multi : Form
  {
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnSwapAA")]
    private ButtonItem _btnSwapAA;
    [AccessedThroughProperty("btnSwapAT")]
    private ButtonItem _btnSwapAT;
    [AccessedThroughProperty("btnSwapTA")]
    private ButtonItem _btnSwapTA;
    [AccessedThroughProperty("ButtomPanel")]
    private PanelEx _ButtomPanel;
    [AccessedThroughProperty("CheckBox1")]
    private CheckBox _CheckBox1;
    [AccessedThroughProperty("CheckBox2")]
    private CheckBox _CheckBox2;
    [AccessedThroughProperty("CheckBox3")]
    private CheckBox _CheckBox3;
    [AccessedThroughProperty("CheckBox4")]
    private CheckBox _CheckBox4;
    [AccessedThroughProperty("CheckBox5")]
    private CheckBox _CheckBox5;
    [AccessedThroughProperty("CheckBox6")]
    private CheckBox _CheckBox6;
    [AccessedThroughProperty("CheckBox7")]
    private CheckBox _CheckBox7;
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
    [AccessedThroughProperty("lblInfoStar")]
    private Label _lblInfoStar;
    [AccessedThroughProperty("lblTitle")]
    private Label _lblTitle;
    [AccessedThroughProperty("lblTrack")]
    private Label _lblTrack;
    [AccessedThroughProperty("lblYear")]
    private Label _lblYear;
    [AccessedThroughProperty("SelectionBar")]
    private ExplorerBar _SelectionBar;
    [AccessedThroughProperty("TAGV2grpCommands")]
    private ExplorerBarGroupItem _TAGV2grpCommands;
    [AccessedThroughProperty("ToolTip")]
    private System.Windows.Forms.ToolTip _ToolTip;
    [AccessedThroughProperty("txtAlbum")]
    private System.Windows.Forms.TextBox _txtAlbum;
    [AccessedThroughProperty("txtComment")]
    private System.Windows.Forms.TextBox _txtComment;
    [AccessedThroughProperty("txtTitle")]
    private System.Windows.Forms.TextBox _txtTitle;
    [AccessedThroughProperty("txtTrack")]
    private NumericTextBox _txtTrack;
    [AccessedThroughProperty("txtYear")]
    private NumericTextBox _txtYear;
    private IContainer components;
    private frmMain MainForm;

    public frmTAG1Multi(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG1Multi_Load);
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
              item.Text = StringType.FromObject(Declarations.objResources.SelectionBar[item.Name]);
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
      string vstrName = "frmTAG1Multi";
      Control objControl = this.CheckBox1;
      this.CheckBox1 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox1, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox2;
      this.CheckBox2 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox2, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox3;
      this.CheckBox3 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox3, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox4;
      this.CheckBox4 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox4, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox5;
      this.CheckBox5 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox5, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox6;
      this.CheckBox6 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox6, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1Multi";
      objControl = this.CheckBox7;
      this.CheckBox7 = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.CheckBox7, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1";
      objControl = this.txtAlbum;
      this.txtAlbum = (System.Windows.Forms.TextBox)objControl;
      this.ToolTip.SetToolTip(this.txtAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1";
      objControl = this.txtComment;
      this.txtComment = (System.Windows.Forms.TextBox)objControl;
      this.ToolTip.SetToolTip(this.txtComment, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1";
      objControl = this.txtTitle;
      this.txtTitle = (System.Windows.Forms.TextBox)objControl;
      this.ToolTip.SetToolTip(this.txtTitle, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1";
      objControl = this.txtTrack;
      this.txtTrack = (NumericTextBox)objControl;
      this.ToolTip.SetToolTip(this.txtTrack, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1";
      objControl = this.txtYear;
      this.txtYear = (NumericTextBox)objControl;
      this.ToolTip.SetToolTip(this.txtYear, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1";
      objControl = this.cmbArtist;
      this.cmbArtist = (ComboBoxAutoComplete)objControl;
      this.ToolTip.SetToolTip(this.cmbArtist, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
      vstrName = "frmTAG1";
      objControl = this.cmbGenre;
      this.cmbGenre = (ComboBoxAutoComplete)objControl;
      this.ToolTip.SetToolTip(this.cmbGenre, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      Form form = this;
      Main.SaveFormSettings(ref form);
      this.SaveToTAG();
      this.Close();
    }

    private void btnSwapAA_Click(object sender, EventArgs e)
    {
      this.cmbArtist.Text = "<B>";
      this.txtAlbum.Text = "<A>";
    }

    private void btnSwapAT_Click(object sender, EventArgs e)
    {
      this.cmbArtist.Text = "<T>";
      this.txtTitle.Text = "<A>";
    }

    private void btnSwapTA_Click(object sender, EventArgs e)
    {
      this.txtTitle.Text = "<B>";
      this.txtAlbum.Text = "<T>";
    }

    private string CheckReplace(V1TAG V1ReplaceTAG, string vstrEntry)
    {
      if ((vstrEntry.IndexOf("<") >= 0) && (vstrEntry.IndexOf(">") >= 0))
      {
        vstrEntry = vstrEntry.Replace("<A>", V1ReplaceTAG.Artist);
        vstrEntry = vstrEntry.Replace("<T>", V1ReplaceTAG.Title);
        vstrEntry = vstrEntry.Replace("<B>", V1ReplaceTAG.Album);
        vstrEntry = vstrEntry.Replace("<Y>", V1ReplaceTAG.Year.ToString());
        vstrEntry = vstrEntry.Replace("<K>", V1ReplaceTAG.Tracknumber.ToString());
        vstrEntry = vstrEntry.Replace("<C>", V1ReplaceTAG.Comment);
        vstrEntry = vstrEntry.Replace("<G>", V1ReplaceTAG.GenreText);
        return vstrEntry;
      }
      return vstrEntry;
    }

    private void cmbArtist_SelectedIndexChanged(object sender, EventArgs e)
    {
      object obj2 = LateBinding.LateGet(sender, null, "Name", new object[0], null, null);
      if (ObjectType.ObjTst(obj2, "cmbArtist", false) == 0)
      {
        this.CheckBox1.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "cmbGenre", false) == 0)
      {
        this.CheckBox6.Checked = true;
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

    private void FillForm()
    {
      byte num = 0;
      this.cmbArtist.Autocomplete = false;
      if (this.MainForm.MP3View.SelectedItems.Count > 0)
      {
        MP3 tag = (MP3)this.MainForm.MP3View.SelectedItems[0].Tag;
        foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
        {
          MP3 mp2 = (MP3)item.Tag;
          if (tag != mp2)
          {
            if ((((num & 1) == 0) && (StringType.StrCmp(mp2.V1TAG.Artist.ToLower(), tag.V1TAG.Artist.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Artist, "", false) == 0))
            {
              num = (byte)(num | 1);
            }
            if ((((num & 2) == 0) && (StringType.StrCmp(mp2.V1TAG.Title.ToLower(), tag.V1TAG.Title.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Title, "", false) == 0))
            {
              num = (byte)(num | 2);
            }
            if ((((num & 4) == 0) && (StringType.StrCmp(mp2.V1TAG.Album.ToLower(), tag.V1TAG.Album.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Album, "", false) == 0))
            {
              num = (byte)(num | 4);
            }
            if ((((num & 8) == 0) && (mp2.V1TAG.Year != tag.V1TAG.Year)) | (mp2.V1TAG.Year == 0))
            {
              num = (byte)(num | 8);
            }
            if ((((num & 0x10) == 0) && (StringType.StrCmp(mp2.V1TAG.GenreText.ToLower(), tag.V1TAG.GenreText.ToLower(), false) != 0)) | (mp2.V1TAG.GenreByte == 0xff))
            {
              num = (byte)(num | 0x10);
            }
            if ((((num & 0x20) == 0) && (StringType.StrCmp(mp2.V1TAG.Comment.ToLower(), tag.V1TAG.Comment.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Comment, "", false) == 0))
            {
              num = (byte)(num | 0x20);
            }
            if (num == 0x3f)
            {
              break;
            }
          }
        }
        if (num != 0x3f)
        {
          if ((num & 1) == 0)
          {
            this.cmbArtist.Text = tag.V1TAG.Artist;
          }
          if ((num & 2) == 0)
          {
            this.txtTitle.Text = tag.V1TAG.Title;
          }
          if ((num & 4) == 0)
          {
            this.txtAlbum.Text = tag.V1TAG.Album;
          }
          try
          {
            if ((num & 8) == 0)
            {
              this.txtYear.Text = StringType.FromObject(Interaction.IIf(tag.V1TAG.Year == 0, "", tag.V1TAG.Year.ToString()));
            }
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }
          if ((num & 0x10) == 0)
          {
            this.cmbGenre.Text = tag.V1TAG.GenreText;
          }
          if ((num & 0x20) == 0)
          {
            this.txtComment.Text = tag.V1TAG.Comment;
          }
        }
      }
      this.CheckBox1.Checked = false;
      this.CheckBox2.Checked = false;
      this.CheckBox3.Checked = false;
      this.CheckBox4.Checked = false;
      this.CheckBox5.Checked = false;
      this.CheckBox6.Checked = false;
      this.CheckBox7.Checked = false;
      this.cmbArtist.Autocomplete = true;
    }

    private void frmTAG1Multi_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
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
      this.AddToolTips();
      this.AddSelectionBar();
      this.cmbArtist.Select();
      this.cmbArtist.Focus();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
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
      this.CheckBox1 = new CheckBox();
      this.CheckBox2 = new CheckBox();
      this.CheckBox3 = new CheckBox();
      this.CheckBox4 = new CheckBox();
      this.CheckBox5 = new CheckBox();
      this.CheckBox6 = new CheckBox();
      this.CheckBox7 = new CheckBox();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.cmbGenre = new ComboBoxAutoComplete();
      this.cmbArtist = new ComboBoxAutoComplete();
      this.txtYear = new NumericTextBox();
      this.txtTrack = new NumericTextBox();
      this.lblInfoStar = new Label();
      this.SelectionBar = new ExplorerBar();
      this.TAGV2grpCommands = new ExplorerBarGroupItem();
      this.btnSwapAT = new ButtonItem();
      this.btnSwapAA = new ButtonItem();
      this.btnSwapTA = new ButtonItem();
      this.ButtomPanel = new PanelEx();
      ((ISupportInitialize)this.SelectionBar).BeginInit();
      this.ButtomPanel.SuspendLayout();
      this.SuspendLayout();
      this.btnCancel.BackColor = SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      Point point = new Point(0x150, 8);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      Size size = new Size(0x70, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x18;
      this.btnCancel.Text = "&Cancel";
      this.btnOK.BackColor = SystemColors.Control;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(0xd8, 8);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(0x70, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 0x17;
      this.btnOK.Text = "&OK";
      this.lblGenre.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0x80);
      this.lblGenre.Location = point;
      this.lblGenre.Name = "lblGenre";
      size = new Size(0x90, 0x10);
      this.lblGenre.Size = size;
      this.lblGenre.TabIndex = 15;
      this.lblGenre.Text = "&Genres:";
      point = new Point(0x148, 0x38);
      this.txtAlbum.Location = point;
      this.txtAlbum.MaxLength = 30;
      this.txtAlbum.Name = "txtAlbum";
      size = new Size(0x108, 20);
      this.txtAlbum.Size = size;
      this.txtAlbum.TabIndex = 7;
      this.txtAlbum.Text = "";
      this.lblComment.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0x98);
      this.lblComment.Location = point;
      this.lblComment.Name = "lblComment";
      size = new Size(0x90, 0x10);
      this.lblComment.Size = size;
      this.lblComment.TabIndex = 0x12;
      this.lblComment.Text = "&Comment:";
      this.lblTitle.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0x20);
      this.lblTitle.Location = point;
      this.lblTitle.Name = "lblTitle";
      size = new Size(0x90, 0x10);
      this.lblTitle.Size = size;
      this.lblTitle.TabIndex = 3;
      this.lblTitle.Text = "&Title:";
      this.lblAlbum.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0x38);
      this.lblAlbum.Location = point;
      this.lblAlbum.Name = "lblAlbum";
      size = new Size(0x90, 0x10);
      this.lblAlbum.Size = size;
      this.lblAlbum.TabIndex = 6;
      this.lblAlbum.Text = "Al&bum:";
      this.lblYear.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 80);
      this.lblYear.Location = point;
      this.lblYear.Name = "lblYear";
      size = new Size(0x90, 0x10);
      this.lblYear.Size = size;
      this.lblYear.TabIndex = 9;
      this.lblYear.Text = "&Year:";
      this.lblTrack.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 0x68);
      this.lblTrack.Location = point;
      this.lblTrack.Name = "lblTrack";
      size = new Size(0x90, 0x10);
      this.lblTrack.Size = size;
      this.lblTrack.TabIndex = 12;
      this.lblTrack.Text = "&Track number:";
      this.lblArtist.ImeMode = ImeMode.NoControl;
      point = new Point(0xb0, 8);
      this.lblArtist.Location = point;
      this.lblArtist.Name = "lblArtist";
      size = new Size(0x90, 0x10);
      this.lblArtist.Size = size;
      this.lblArtist.TabIndex = 0;
      this.lblArtist.Text = "Lead &Artist:";
      point = new Point(0x148, 0x98);
      this.txtComment.Location = point;
      this.txtComment.MaxLength = 30;
      this.txtComment.Name = "txtComment";
      size = new Size(0x108, 20);
      this.txtComment.Size = size;
      this.txtComment.TabIndex = 0x13;
      this.txtComment.Text = "";
      point = new Point(0x148, 0x20);
      this.txtTitle.Location = point;
      this.txtTitle.MaxLength = 30;
      this.txtTitle.Name = "txtTitle";
      size = new Size(0x108, 20);
      this.txtTitle.Size = size;
      this.txtTitle.TabIndex = 4;
      this.txtTitle.Text = "";
      this.CheckBox1.ImeMode = ImeMode.NoControl;
      point = new Point(600, 10);
      this.CheckBox1.Location = point;
      this.CheckBox1.Name = "CheckBox1";
      size = new Size(0x10, 0x10);
      this.CheckBox1.Size = size;
      this.CheckBox1.TabIndex = 2;
      this.CheckBox2.ImeMode = ImeMode.NoControl;
      point = new Point(600, 0x22);
      this.CheckBox2.Location = point;
      this.CheckBox2.Name = "CheckBox2";
      size = new Size(0x10, 0x10);
      this.CheckBox2.Size = size;
      this.CheckBox2.TabIndex = 5;
      this.CheckBox3.ImeMode = ImeMode.NoControl;
      point = new Point(600, 0x3a);
      this.CheckBox3.Location = point;
      this.CheckBox3.Name = "CheckBox3";
      size = new Size(0x10, 0x10);
      this.CheckBox3.Size = size;
      this.CheckBox3.TabIndex = 8;
      this.CheckBox4.ImeMode = ImeMode.NoControl;
      point = new Point(400, 0x52);
      this.CheckBox4.Location = point;
      this.CheckBox4.Name = "CheckBox4";
      size = new Size(0x10, 0x10);
      this.CheckBox4.Size = size;
      this.CheckBox4.TabIndex = 11;
      this.CheckBox5.ImeMode = ImeMode.NoControl;
      point = new Point(400, 0x6a);
      this.CheckBox5.Location = point;
      this.CheckBox5.Name = "CheckBox5";
      size = new Size(0x10, 0x10);
      this.CheckBox5.Size = size;
      this.CheckBox5.TabIndex = 14;
      this.CheckBox6.ImeMode = ImeMode.NoControl;
      point = new Point(600, 130);
      this.CheckBox6.Location = point;
      this.CheckBox6.Name = "CheckBox6";
      size = new Size(0x10, 0x10);
      this.CheckBox6.Size = size;
      this.CheckBox6.TabIndex = 0x11;
      this.CheckBox7.ImeMode = ImeMode.NoControl;
      point = new Point(600, 0x9a);
      this.CheckBox7.Location = point;
      this.CheckBox7.Name = "CheckBox7";
      size = new Size(0x10, 0x10);
      this.CheckBox7.Size = size;
      this.CheckBox7.TabIndex = 20;
      this.cmbGenre.Autocomplete = true;
      this.cmbGenre.ItemHeight = 13;
      this.cmbGenre.ListItemsOnly = true;
      point = new Point(0x148, 0x80);
      this.cmbGenre.Location = point;
      this.cmbGenre.Name = "cmbGenre";
      size = new Size(0x108, 0x15);
      this.cmbGenre.Size = size;
      this.cmbGenre.TabIndex = 0x10;
      this.cmbArtist.Autocomplete = true;
      this.cmbArtist.ItemHeight = 13;
      point = new Point(0x148, 8);
      this.cmbArtist.Location = point;
      this.cmbArtist.MaxLength = 30;
      this.cmbArtist.Name = "cmbArtist";
      size = new Size(0x108, 0x15);
      this.cmbArtist.Size = size;
      this.cmbArtist.TabIndex = 1;
      this.txtYear.AllowNegative = true;
      this.txtYear.DigitsInGroup = 0;
      this.txtYear.Flags = 0x10;
      point = new Point(0x148, 80);
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
      this.txtYear.TabIndex = 10;
      this.txtTrack.AllowNegative = true;
      this.txtTrack.DigitsInGroup = 0;
      this.txtTrack.Flags = 0x10;
      point = new Point(0x148, 0x68);
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
      this.txtTrack.TabIndex = 13;
      this.lblInfoStar.BorderStyle = BorderStyle.Fixed3D;
      point = new Point(0xb0, 0xb8);
      this.lblInfoStar.Location = point;
      this.lblInfoStar.Name = "lblInfoStar";
      size = new Size(440, 0x30);
      this.lblInfoStar.Size = size;
      this.lblInfoStar.TabIndex = 0x15;
      this.lblInfoStar.Text = "You can use the following parameters to enter the information from one field into another: <A>=Artist, <T>=Title, <B>=Album, <C>=Comment, <K>=Tracknumber, <Y>=Year, <G>=Genre";
      this.lblInfoStar.TextAlign = ContentAlignment.MiddleCenter;
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
      size = new Size(0xa8, 280);
      this.SelectionBar.Size = size;
      this.SelectionBar.TabIndex = 0x19;
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
      this.TAGV2grpCommands.SubItems.AddRange(new BaseItem[] { this.btnSwapAT, this.btnSwapAA, this.btnSwapTA });
      this.TAGV2grpCommands.Text = "Commands";
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
      this.ButtomPanel.AntiAlias = true;
      this.ButtomPanel.Controls.Add(this.btnCancel);
      this.ButtomPanel.Controls.Add(this.btnOK);
      this.ButtomPanel.Dock = DockStyle.Bottom;
      point = new Point(0xa8, 240);
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
      this.ButtomPanel.TabIndex = 0x16;
      this.AcceptButton = this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = this.btnCancel;
      size = new Size(0x272, 280);
      this.ClientSize = size;
      this.ControlBox = false;
      this.Controls.Add(this.ButtomPanel);
      this.Controls.Add(this.SelectionBar);
      this.Controls.Add(this.lblInfoStar);
      this.Controls.Add(this.txtYear);
      this.Controls.Add(this.txtTrack);
      this.Controls.Add(this.cmbGenre);
      this.Controls.Add(this.cmbArtist);
      this.Controls.Add(this.txtAlbum);
      this.Controls.Add(this.txtComment);
      this.Controls.Add(this.txtTitle);
      this.Controls.Add(this.CheckBox7);
      this.Controls.Add(this.CheckBox6);
      this.Controls.Add(this.CheckBox5);
      this.Controls.Add(this.CheckBox4);
      this.Controls.Add(this.CheckBox3);
      this.Controls.Add(this.CheckBox2);
      this.Controls.Add(this.CheckBox1);
      this.Controls.Add(this.lblGenre);
      this.Controls.Add(this.lblComment);
      this.Controls.Add(this.lblTitle);
      this.Controls.Add(this.lblAlbum);
      this.Controls.Add(this.lblYear);
      this.Controls.Add(this.lblTrack);
      this.Controls.Add(this.lblArtist);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG1Multi";
      this.ShowInTaskbar = false;
      this.Text = "Multiple Edit TAG Ver. 1";
      ((ISupportInitialize)this.SelectionBar).EndInit();
      this.ButtomPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void Multi1CB(ref frmProgress frmProg)
    {
      ListViewItem item = new ListViewItem();
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        object obj2;
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        MP3 tag = (MP3)item.Tag;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        frmProg.Infos.Text = tag.CurrentFullName;
        V1TAG vtag = tag.V1TAG.Clone();
        if (this.CheckBox1.Checked)
        {
          if (StringType.StrCmp(tag.V1TAG.Artist, this.cmbArtist.Text, false) != 0)
          {
            tag.V1TAG.Artist = this.CheckReplace(vtag, this.cmbArtist.Text);
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = ID3Functions.CreateTextFrame("TPE1", tag.V1TAG.Artist);
            if (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
            {
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }
        if (this.CheckBox2.Checked)
        {
          if (StringType.StrCmp(tag.V1TAG.Title, this.txtTitle.Text, false) != 0)
          {
            tag.V1TAG.Title = this.CheckReplace(vtag, this.txtTitle.Text);
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = ID3Functions.CreateTextFrame("TIT2", tag.V1TAG.Title);
            if (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
            {
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }
        if (this.CheckBox3.Checked)
        {
          if (StringType.StrCmp(tag.V1TAG.Album, this.txtAlbum.Text, false) != 0)
          {
            tag.V1TAG.Album = this.CheckReplace(vtag, this.txtAlbum.Text);
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = ID3Functions.CreateTextFrame("TALB", tag.V1TAG.Album);
            if (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
            {
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }
        if (this.CheckBox4.Checked)
        {
          if (tag.V1TAG.Year != Conversion.Val(this.txtYear.Text))
          {
            tag.V1TAG.Year = (int)Math.Round(Conversion.Val(this.txtYear.Text));
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            if (!tag.V2TAG.TAGHeaderPresent)
            {
              tag.V2TAG.TAGHeaderPresent = true;
            }
            if (tag.V2TAG.TAGVersion == DoubleType.FromString("3"))
            {
              obj2 = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text.PadLeft(4, '0'));
              if (StringType.StrCmp(this.txtYear.Text, "", false) == 0)
              {
                LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
              }
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            }
            else
            {
              obj2 = ID3Functions.CreateTextFrame("TDRC", this.txtYear.Text.PadLeft(4, '0'));
              if (StringType.StrCmp(this.txtYear.Text, "", false) == 0)
              {
                LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
              }
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            }
          }
        }
        if (this.CheckBox5.Checked)
        {
          if (tag.V1TAG.Tracknumber != Conversion.Val(this.txtTrack.Text))
          {
            tag.V1TAG.Tracknumber = (byte)Math.Round(Conversion.Val(this.txtTrack.Text));
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = ID3Functions.CreateTextFrame("TRCK", this.txtTrack.Text.PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'));
            if (Conversion.Val(this.txtTrack.Text) == 0.0)
            {
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }
        if (this.CheckBox6.Checked)
        {
          if (tag.V1TAG.GenreByte != ID3Functions.GetV1GenreByName(this.cmbGenre.Text))
          {
            tag.V1TAG.GenreText = this.cmbGenre.Text;
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            string text = this.cmbGenre.Text;
            foreach (DataRow row in Declarations.objSettings.Genres.Rows)
            {
              if (ObjectType.ObjTst(row["V1V2"], ID3Functions.GetV1GenreByName(this.cmbGenre.Text), false) == 0)
              {
                text = row["Name"].ToString();
                break;
              }
            }
            obj2 = ID3Functions.CreateTextFrame("TCON", text);
            if (StringType.StrCmp(this.cmbGenre.Text.Trim(new char[] { ' ' }), "", false) == 0)
            {
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }
        if (this.CheckBox7.Checked)
        {
          if (StringType.StrCmp(tag.V1TAG.Comment, this.txtComment.Text, false) != 0)
          {
            tag.V1TAG.Comment = this.CheckReplace(vtag, this.txtComment.Text);
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            obj2 = new V2LDCFrame();
            LateBinding.LateSet(obj2, null, "FID", new object[] { "COMM" }, null);
            LateBinding.LateSet(obj2, null, "Language", new object[] { Declarations.astrLanLookup[Declarations.objSettings.V2Language].Substring(0, 3) }, null);
            LateBinding.LateSet(obj2, null, "Descriptor", new object[] { Declarations.objSettings.TransferCommentD }, null);
            LateBinding.LateSet(obj2, null, "Content", new object[] { tag.V1TAG.Comment }, null);
            if (StringType.StrCmp(this.txtComment.Text, "", false) == 0)
            {
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }
        if (tag.V2TAG.Changed)
        {
          if (!tag.V2TAG.TAGHeaderPresent)
          {
            tag.V2TAG.TAGHeaderPresent = true;
          }
          tag.Changed = true;
        }
        this.MainForm.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void SaveToTAG()
    {
      ArrayList list = new ArrayList();
      this.MainForm.MP3View.BeginUpdate();
      Form ownerForm = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.Multi1CB);
      frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref ownerForm, ref cB);
      progress.SetStateMultiple();
      progress.List = list;
      progress.ShowDialog(this);
      this.MainForm.MP3View.EndUpdate();
      if (list.Count > 0)
      {
        Declarations.UNDOList.Add(list);
        this.MainForm.UnDoEnable(true, true);
      }
      ownerForm = this;
      Main.SaveFormSettings(ref ownerForm);
      this.Close();
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

    private void txt_TextChanged(object sender, EventArgs e)
    {
      object obj2 = LateBinding.LateGet(sender, null, "Name", new object[0], null, null);
      if (ObjectType.ObjTst(obj2, "cmbArtist", false) == 0)
      {
        this.CheckBox1.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtTitle", false) == 0)
      {
        this.CheckBox2.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtAlbum", false) == 0)
      {
        this.CheckBox3.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtYear", false) == 0)
      {
        this.CheckBox4.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtTrack", false) == 0)
      {
        this.CheckBox5.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "cmbGenre", false) == 0)
      {
        this.CheckBox6.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtComment", false) == 0)
      {
        this.CheckBox7.Checked = true;
      }
    }

    private void txtTrack_Leave(object sender, EventArgs e)
    {
      if (Conversion.Val(this.txtTrack.Text) > 0.0)
      {
        if (this.txtComment.TextLength > 0x1c)
        {
          this.txtComment.Text = this.txtComment.Text.Substring(0, 0x1c);
        }
        this.txtComment.MaxLength = 0x1c;
      }
      else
      {
        this.txtComment.MaxLength = 30;
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

    internal virtual CheckBox CheckBox1
    {
      get
      {
        return this._CheckBox1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._CheckBox1 != null)
        {
        }
        this._CheckBox1 = value;
        if (this._CheckBox1 != null)
        {
        }
      }
    }

    internal virtual CheckBox CheckBox2
    {
      get
      {
        return this._CheckBox2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._CheckBox2 != null)
        {
        }
        this._CheckBox2 = value;
        if (this._CheckBox2 != null)
        {
        }
      }
    }

    internal virtual CheckBox CheckBox3
    {
      get
      {
        return this._CheckBox3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._CheckBox3 != null)
        {
        }
        this._CheckBox3 = value;
        if (this._CheckBox3 != null)
        {
        }
      }
    }

    internal virtual CheckBox CheckBox4
    {
      get
      {
        return this._CheckBox4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._CheckBox4 != null)
        {
        }
        this._CheckBox4 = value;
        if (this._CheckBox4 != null)
        {
        }
      }
    }

    internal virtual CheckBox CheckBox5
    {
      get
      {
        return this._CheckBox5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._CheckBox5 != null)
        {
        }
        this._CheckBox5 = value;
        if (this._CheckBox5 != null)
        {
        }
      }
    }

    internal virtual CheckBox CheckBox6
    {
      get
      {
        return this._CheckBox6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._CheckBox6 != null)
        {
        }
        this._CheckBox6 = value;
        if (this._CheckBox6 != null)
        {
        }
      }
    }

    internal virtual CheckBox CheckBox7
    {
      get
      {
        return this._CheckBox7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._CheckBox7 != null)
        {
        }
        this._CheckBox7 = value;
        if (this._CheckBox7 != null)
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
          this._cmbArtist.SelectedIndexChanged -= new EventHandler(this.cmbArtist_SelectedIndexChanged);
          this._cmbArtist.TextChanged -= new EventHandler(this.txt_TextChanged);
          this._cmbArtist.Enter -= new EventHandler(this.Select_Enter);
        }
        this._cmbArtist = value;
        if (this._cmbArtist != null)
        {
          this._cmbArtist.SelectedIndexChanged += new EventHandler(this.cmbArtist_SelectedIndexChanged);
          this._cmbArtist.TextChanged += new EventHandler(this.txt_TextChanged);
          this._cmbArtist.Enter += new EventHandler(this.Select_Enter);
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
          this._cmbGenre.SelectedIndexChanged -= new EventHandler(this.cmbArtist_SelectedIndexChanged);
          this._cmbGenre.TextChanged -= new EventHandler(this.txt_TextChanged);
          this._cmbGenre.Enter -= new EventHandler(this.Select_Enter);
        }
        this._cmbGenre = value;
        if (this._cmbGenre != null)
        {
          this._cmbGenre.SelectedIndexChanged += new EventHandler(this.cmbArtist_SelectedIndexChanged);
          this._cmbGenre.TextChanged += new EventHandler(this.txt_TextChanged);
          this._cmbGenre.Enter += new EventHandler(this.Select_Enter);
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

    internal virtual Label lblInfoStar
    {
      get
      {
        return this._lblInfoStar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblInfoStar != null)
        {
        }
        this._lblInfoStar = value;
        if (this._lblInfoStar != null)
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
          this._txtAlbum.TextChanged -= new EventHandler(this.txt_TextChanged);
          this._txtAlbum.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtAlbum = value;
        if (this._txtAlbum != null)
        {
          this._txtAlbum.TextChanged += new EventHandler(this.txt_TextChanged);
          this._txtAlbum.Enter += new EventHandler(this.Select_Enter);
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
          this._txtComment.TextChanged -= new EventHandler(this.txt_TextChanged);
          this._txtComment.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtComment = value;
        if (this._txtComment != null)
        {
          this._txtComment.TextChanged += new EventHandler(this.txt_TextChanged);
          this._txtComment.Enter += new EventHandler(this.Select_Enter);
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
          this._txtTitle.TextChanged -= new EventHandler(this.txt_TextChanged);
          this._txtTitle.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtTitle = value;
        if (this._txtTitle != null)
        {
          this._txtTitle.TextChanged += new EventHandler(this.txt_TextChanged);
          this._txtTitle.Enter += new EventHandler(this.Select_Enter);
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
          this._txtTrack.TextChanged -= new EventHandler(this.txt_TextChanged);
          this._txtTrack.Leave -= new EventHandler(this.txtTrack_Leave);
          this._txtTrack.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtTrack = value;
        if (this._txtTrack != null)
        {
          this._txtTrack.TextChanged += new EventHandler(this.txt_TextChanged);
          this._txtTrack.Leave += new EventHandler(this.txtTrack_Leave);
          this._txtTrack.Enter += new EventHandler(this.Select_Enter);
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
          this._txtYear.TextChanged -= new EventHandler(this.txt_TextChanged);
          this._txtYear.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtYear = value;
        if (this._txtYear != null)
        {
          this._txtYear.TextChanged += new EventHandler(this.txt_TextChanged);
          this._txtYear.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }
  }
}