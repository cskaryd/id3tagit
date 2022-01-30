using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmTAG2Multi : Form
  {
    #region Designer

    private PictureBox APICView;
    private Button btnAddComment;
    private Button btnAddGenre;
    private Button btnAddInv;
    private Button btnAddLyrics;
    private Button btnAddMusician;
    private Button btnAddPicture;
    private Button btnAddRating;
    private Button btnAddTXXX;
    private Button btnAddWXXX;
    private Button btnCancel;
    private ButtonItem btnExport;
    private ButtonItem btnGet;
    private Button btnGetPic;
    private ButtonItem btnImport;
    private Button btnLyricsFile;
    private Button btnMoveComment;
    private Button btnMoveGenre;
    private Button btnMoveLyrics;
    private Button btnMoveRating;
    private Button btnOK;
    private Button btnRemoveComment;
    private Button btnRemoveGenre;
    private Button btnRemoveInv;
    private Button btnRemoveLyrics;
    private Button btnRemoveMusician;
    private Button btnRemovePicture;
    private Button btnRemoveRating;
    private Button btnRemoveTXXX;
    private Button btnRemoveWXXX;
    private ButtonItem btnSwapAA;
    private ButtonItem btnSwapAT;
    private ButtonItem btnSwapTA;
    private PanelEx ButtomPanel;
    private CheckBox CheckBox1;
    private CheckBox CheckBox10;
    private CheckBox CheckBox11;
    private CheckBox CheckBox12;
    private CheckBox CheckBox13;
    private CheckBox CheckBox14;
    private CheckBox CheckBox15;
    private CheckBox CheckBox16;
    private CheckBox CheckBox17;
    private CheckBox CheckBox18;
    private CheckBox CheckBox19;
    private CheckBox CheckBox2;
    private CheckBox CheckBox20;
    private CheckBox CheckBox21;
    private CheckBox CheckBox22;
    private CheckBox CheckBox23;
    private CheckBox CheckBox24;
    private CheckBox CheckBox25;
    private CheckBox CheckBox26;
    private CheckBox CheckBox27;
    private CheckBox CheckBox28;
    private CheckBox CheckBox29;
    private CheckBox CheckBox3;
    private CheckBox CheckBox30;
    private CheckBox CheckBox31;
    private CheckBox CheckBox32;
    private CheckBox CheckBox33;
    private CheckBox CheckBox34;
    private CheckBox CheckBox35;
    private CheckBox CheckBox36;
    private CheckBox CheckBox37;
    private CheckBox CheckBox38;
    private CheckBox CheckBox39;
    private CheckBox CheckBox4;
    private CheckBox CheckBox40;
    private CheckBox CheckBox41;
    private CheckBox CheckBox42;
    private CheckBox CheckBox43;
    private CheckBox CheckBox44;
    private CheckBox CheckBox45;
    private CheckBox CheckBox5;
    private CheckBox CheckBox6;
    private CheckBox CheckBox7;
    private CheckBox CheckBox8;
    private CheckBox CheckBox9;
    private CheckBox chkPicInclude;
    private CheckBox chkPicRelativPath;
    private CheckBox chkRemoveAllNOT;
    private CheckBox chkTLEN;
    private ComboBoxAutoComplete cmbArtist;
    private ComboBoxAutoComplete cmbCDescriptor;
    private ComboBox cmbCLanguage;
    private ComboBoxAutoComplete cmbGenre;
    private ComboBox cmbLLanguage;
    private ComboBox cmbMedia;
    private ComboBox cmbPicType;
    private ColumnHeader colComment;
    private ColumnHeader colDescriptor;
    private ColumnHeader colLanguage;
    private ColumnHeader ColumnHeader1;
    private ColumnHeader ColumnHeader10;
    private ColumnHeader ColumnHeader11;
    private ColumnHeader ColumnHeader12;
    private ColumnHeader ColumnHeader13;
    private ColumnHeader ColumnHeader14;
    private ColumnHeader ColumnHeader15;
    private ColumnHeader ColumnHeader16;
    private ColumnHeader ColumnHeader17;
    private ColumnHeader ColumnHeader18;
    private ColumnHeader ColumnHeader2;
    private ColumnHeader ColumnHeader3;
    private ColumnHeader ColumnHeader4;
    private ColumnHeader ColumnHeader5;
    private ColumnHeader ColumnHeader6;
    private ColumnHeader ColumnHeader7;
    private ColumnHeader ColumnHeader8;
    private ColumnHeader ColumnHeader9;
    private ListView CommentList;
    private ListBox GenreList;
    private ButtonItem Label;
    private System.Windows.Forms.Label lblAlbum;
    private System.Windows.Forms.Label lblAlbumSort;
    private System.Windows.Forms.Label lblArtist;
    private System.Windows.Forms.Label lblArtistSort;
    private System.Windows.Forms.Label lblArtistURL;
    private System.Windows.Forms.Label lblAudioFileURL;
    private System.Windows.Forms.Label lblAudioSRCURL;
    private System.Windows.Forms.Label lblBand;
    private System.Windows.Forms.Label lblBPM;
    private System.Windows.Forms.Label lblCOMM;
    private System.Windows.Forms.Label lblCOMMDesc;
    private System.Windows.Forms.Label lblCommDescInfo;
    private System.Windows.Forms.Label lblCOMMInfURL;
    private System.Windows.Forms.Label lblCOMMLan;
    private System.Windows.Forms.Label lblComposer;
    private System.Windows.Forms.Label lblConductor;
    private System.Windows.Forms.Label lblContent;
    private System.Windows.Forms.Label lblCopyInfURL;
    private System.Windows.Forms.Label lblCopyright;
    private System.Windows.Forms.Label lblDigits;
    private System.Windows.Forms.Label lblEncoded;
    private System.Windows.Forms.Label lblGenre;
    private System.Windows.Forms.Label lblGenreInfo;
    private System.Windows.Forms.Label lblINetRadioURL;
    private System.Windows.Forms.Label lblInfo;
    private System.Windows.Forms.Label lblInfoStar;
    private System.Windows.Forms.Label lblInvFunction;
    private System.Windows.Forms.Label lblInvPerson;
    private System.Windows.Forms.Label lblLyDesc;
    private System.Windows.Forms.Label lblLyLan;
    private System.Windows.Forms.Label lblLyrics;
    private System.Windows.Forms.Label lblLyWriter;
    private System.Windows.Forms.Label lblMediaTyp;
    private System.Windows.Forms.Label lblModified;
    private System.Windows.Forms.Label lblMusicianInfo;
    private System.Windows.Forms.Label lblMusicianInst;
    private System.Windows.Forms.Label lblMusicianName;
    private System.Windows.Forms.Label lblOAlbum;
    private System.Windows.Forms.Label lblOArtist;
    private System.Windows.Forms.Label lblOf1;
    private System.Windows.Forms.Label lblOf2;
    private System.Windows.Forms.Label lblOFilename;
    private System.Windows.Forms.Label lblOLyWriter;
    private System.Windows.Forms.Label lblOOwner;
    private System.Windows.Forms.Label lblOYear;
    private System.Windows.Forms.Label lblOYearInfo;
    private System.Windows.Forms.Label lblPayURL;
    private System.Windows.Forms.Label lblPicDesc;
    private System.Windows.Forms.Label lblPicPath;
    private System.Windows.Forms.Label lblPicType;
    private System.Windows.Forms.Label lblPosMedia;
    private System.Windows.Forms.Label lblPublisher;
    private System.Windows.Forms.Label lblPubURL;
    private System.Windows.Forms.Label lblRatingCounter;
    private System.Windows.Forms.Label lblRatingRating;
    private System.Windows.Forms.Label lblRatingUser;
    private System.Windows.Forms.Label lblSubTitle;
    private System.Windows.Forms.Label lblTitle;
    private System.Windows.Forms.Label lblTitleSort;
    private System.Windows.Forms.Label lblTLEN;
    private System.Windows.Forms.Label lblTrack;
    private System.Windows.Forms.Label lblTXXXContent;
    private System.Windows.Forms.Label lblTXXXDesc;
    private System.Windows.Forms.Label lblWXXXContent;
    private System.Windows.Forms.Label lblWXXXDesc;
    private System.Windows.Forms.Label lblYear;
    private ListView LyricsList;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    private Panel panDetail;
    private Panel Panel1;
    private Panel Panel10;
    private Panel Panel11;
    private Panel Panel12;
    private Panel Panel13;
    private Panel Panel14;
    private Panel Panel15;
    private Panel Panel16;
    private Panel Panel2;
    private Panel Panel3;
    private Panel Panel4;
    private Panel Panel5;
    private Panel Panel6;
    private Panel Panel7;
    private Panel Panel8;
    private Panel Panel9;
    private Panel panInvolved;
    private Panel panLyrics;
    private Panel panMain;
    private Panel panOriginal;
    private Panel panPic;
    private Panel panRating;
    private Panel panUser;
    private Panel panWeb;
    private ListView PicList;
    private ListView RatingList;
    private ExplorerBar SelectionBar;
    private ButtonItem TAGV2ButtonItem1;
    private ButtonItem TAGV2ButtonItem2;
    private ButtonItem TAGV2ButtonItem3;
    private ButtonItem TAGV2ButtonItem4;
    private ButtonItem TAGV2ButtonItem5;
    private ButtonItem TAGV2ButtonItem6;
    private ButtonItem TAGV2ButtonItem7;
    private ButtonItem TAGV2ButtonItem8;
    private ButtonItem TAGV2ButtonItem9;
    private ExplorerBarGroupItem TAGV2grpCommands;
    private ExplorerBarGroupItem TAGV2grpTAG;
    private ListView TIPLList;
    private ListView TMCLList;
    private System.Windows.Forms.ToolTip ToolTip;
    private PanelEx TopPanel;
    private HScrollBar TORYFormat;
    private System.Windows.Forms.TextBox txtAlbum;
    private System.Windows.Forms.TextBox txtArtistURL;
    private System.Windows.Forms.TextBox txtAudioFileURL;
    private System.Windows.Forms.TextBox txtAudioSRCURL;
    private System.Windows.Forms.TextBox txtBand;
    private MaskedTextBox txtBPM;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.TextBox txtCOMMInfURL;
    private System.Windows.Forms.TextBox txtComposer;
    private System.Windows.Forms.TextBox txtConductor;
    private System.Windows.Forms.TextBox txtContent;
    private System.Windows.Forms.TextBox txtCopyInfURL;
    private System.Windows.Forms.TextBox txtCopyright;
    private NumericUpDown txtDigits;
    private System.Windows.Forms.TextBox txtEncoded;
    private System.Windows.Forms.TextBox txtINetRadioURL;
    private System.Windows.Forms.TextBox txtInvFunction;
    private System.Windows.Forms.TextBox txtInvPerson;
    private System.Windows.Forms.TextBox txtLDescriptor;
    private RichTextBox txtLyrics;
    private System.Windows.Forms.TextBox txtLyWriter;
    private System.Windows.Forms.TextBox txtModified;
    private System.Windows.Forms.TextBox txtMusicianInst;
    private System.Windows.Forms.TextBox txtMusicianName;
    private System.Windows.Forms.TextBox txtOAlbum;
    private System.Windows.Forms.TextBox txtOArtist;
    private System.Windows.Forms.TextBox txtOFilename;
    private System.Windows.Forms.TextBox txtOLyWriter;
    private System.Windows.Forms.TextBox txtOOwner;
    private System.Windows.Forms.TextBox txtPayURL;
    private System.Windows.Forms.TextBox txtPDescriptor;
    private System.Windows.Forms.TextBox txtPicPath;
    private MaskedTextBox txtPOS1;
    private MaskedTextBox txtPOS2;
    private System.Windows.Forms.TextBox txtPublisher;
    private System.Windows.Forms.TextBox txtPubURL;
    private NumericUpDown txtRatingCounter;
    private NumericUpDown txtRatingRating;
    private System.Windows.Forms.TextBox txtRatingUser;
    private System.Windows.Forms.TextBox txtSortAlbum;
    private System.Windows.Forms.TextBox txtSortArtist;
    private System.Windows.Forms.TextBox txtSortTitle;
    private System.Windows.Forms.TextBox txtSubTitle;
    private System.Windows.Forms.TextBox txtTitle;
    private MaskedTextBox txtTORY;
    private MaskedTextBox txtTrack1;
    private MaskedTextBox txtTrack2;
    private System.Windows.Forms.TextBox txtTXXXContent;
    private System.Windows.Forms.TextBox txtTXXXDesc;
    private System.Windows.Forms.TextBox txtWXXXContent;
    private System.Windows.Forms.TextBox txtWXXXDesc;
    private MaskedTextBox txtYear;
    private ListView TXXXList;
    private ListView WXXXList;
    private HScrollBar YearFormat;
    private IContainer components;
    private frmMain MainForm;

    //ResourceManager manager = new ResourceManager(typeof(frmTAG2Multi));
    //this.TAGV2ButtonItem1.Icon = (Icon)manager.GetObject("TAGV2ButtonItem1.Icon");
    //this.TAGV2ButtonItem2.Icon = (Icon)manager.GetObject("TAGV2ButtonItem2.Icon");
    //this.TAGV2ButtonItem3.Icon = (Icon)manager.GetObject("TAGV2ButtonItem3.Icon");
    //this.TAGV2ButtonItem4.Icon = (Icon)manager.GetObject("TAGV2ButtonItem4.Icon");
    //this.TAGV2ButtonItem5.Icon = (Icon)manager.GetObject("TAGV2ButtonItem5.Icon");
    //this.TAGV2ButtonItem6.Icon = (Icon)manager.GetObject("TAGV2ButtonItem6.Icon");
    //this.TAGV2ButtonItem7.Icon = (Icon)manager.GetObject("TAGV2ButtonItem7.Icon");
    //this.TAGV2ButtonItem9.Icon = (Icon)manager.GetObject("TAGV2ButtonItem9.Icon");
    //this.TAGV2ButtonItem8.Icon = (Icon)manager.GetObject("TAGV2ButtonItem8.Icon");

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
      this.panDetail = new System.Windows.Forms.Panel();
      this.Panel9 = new System.Windows.Forms.Panel();
      this.cmbMedia = new System.Windows.Forms.ComboBox();
      this.lblMediaTyp = new System.Windows.Forms.Label();
      this.chkTLEN = new System.Windows.Forms.CheckBox();
      this.lblTLEN = new System.Windows.Forms.Label();
      this.CheckBox5 = new System.Windows.Forms.CheckBox();
      this.Panel5 = new System.Windows.Forms.Panel();
      this.CheckBox16 = new System.Windows.Forms.CheckBox();
      this.CheckBox15 = new System.Windows.Forms.CheckBox();
      this.txtContent = new System.Windows.Forms.TextBox();
      this.txtSubTitle = new System.Windows.Forms.TextBox();
      this.lblSubTitle = new System.Windows.Forms.Label();
      this.lblContent = new System.Windows.Forms.Label();
      this.Panel14 = new System.Windows.Forms.Panel();
      this.CheckBox41 = new System.Windows.Forms.CheckBox();
      this.CheckBox42 = new System.Windows.Forms.CheckBox();
      this.CheckBox43 = new System.Windows.Forms.CheckBox();
      this.txtSortArtist = new System.Windows.Forms.TextBox();
      this.txtSortTitle = new System.Windows.Forms.TextBox();
      this.txtSortAlbum = new System.Windows.Forms.TextBox();
      this.lblAlbumSort = new System.Windows.Forms.Label();
      this.lblTitleSort = new System.Windows.Forms.Label();
      this.lblArtistSort = new System.Windows.Forms.Label();
      this.Panel4 = new System.Windows.Forms.Panel();
      this.CheckBox14 = new System.Windows.Forms.CheckBox();
      this.CheckBox13 = new System.Windows.Forms.CheckBox();
      this.CheckBox12 = new System.Windows.Forms.CheckBox();
      this.CheckBox11 = new System.Windows.Forms.CheckBox();
      this.txtComposer = new System.Windows.Forms.TextBox();
      this.lblComposer = new System.Windows.Forms.Label();
      this.txtBand = new System.Windows.Forms.TextBox();
      this.txtModified = new System.Windows.Forms.TextBox();
      this.txtConductor = new System.Windows.Forms.TextBox();
      this.lblConductor = new System.Windows.Forms.Label();
      this.lblModified = new System.Windows.Forms.Label();
      this.lblBand = new System.Windows.Forms.Label();
      this.CheckBox40 = new System.Windows.Forms.CheckBox();
      this.txtCopyright = new System.Windows.Forms.TextBox();
      this.lblCopyright = new System.Windows.Forms.Label();
      this.CheckBox19 = new System.Windows.Forms.CheckBox();
      this.CheckBox18 = new System.Windows.Forms.CheckBox();
      this.CheckBox17 = new System.Windows.Forms.CheckBox();
      this.txtLyWriter = new System.Windows.Forms.TextBox();
      this.txtEncoded = new System.Windows.Forms.TextBox();
      this.txtPublisher = new System.Windows.Forms.TextBox();
      this.lblPublisher = new System.Windows.Forms.Label();
      this.lblEncoded = new System.Windows.Forms.Label();
      this.lblLyWriter = new System.Windows.Forms.Label();
      this.panOriginal = new System.Windows.Forms.Panel();
      this.Panel6 = new System.Windows.Forms.Panel();
      this.txtTORY = new System.Windows.Forms.MaskedTextBox();
      this.CheckBox39 = new System.Windows.Forms.CheckBox();
      this.lblOYearInfo = new System.Windows.Forms.Label();
      this.TORYFormat = new System.Windows.Forms.HScrollBar();
      this.lblOYear = new System.Windows.Forms.Label();
      this.CheckBox24 = new System.Windows.Forms.CheckBox();
      this.CheckBox23 = new System.Windows.Forms.CheckBox();
      this.CheckBox22 = new System.Windows.Forms.CheckBox();
      this.CheckBox21 = new System.Windows.Forms.CheckBox();
      this.CheckBox20 = new System.Windows.Forms.CheckBox();
      this.txtOOwner = new System.Windows.Forms.TextBox();
      this.lblOOwner = new System.Windows.Forms.Label();
      this.txtOArtist = new System.Windows.Forms.TextBox();
      this.lblOArtist = new System.Windows.Forms.Label();
      this.txtOAlbum = new System.Windows.Forms.TextBox();
      this.txtOLyWriter = new System.Windows.Forms.TextBox();
      this.txtOFilename = new System.Windows.Forms.TextBox();
      this.lblOFilename = new System.Windows.Forms.Label();
      this.lblOLyWriter = new System.Windows.Forms.Label();
      this.lblOAlbum = new System.Windows.Forms.Label();
      this.panMain = new System.Windows.Forms.Panel();
      this.Panel3 = new System.Windows.Forms.Panel();
      this.lblCommDescInfo = new System.Windows.Forms.Label();
      this.cmbCDescriptor = new ID3_TagIT.ComboBoxAutoComplete();
      this.CheckBox38 = new System.Windows.Forms.CheckBox();
      this.CheckBox10 = new System.Windows.Forms.CheckBox();
      this.btnMoveComment = new System.Windows.Forms.Button();
      this.btnRemoveComment = new System.Windows.Forms.Button();
      this.btnAddComment = new System.Windows.Forms.Button();
      this.lblCOMM = new System.Windows.Forms.Label();
      this.lblCOMMLan = new System.Windows.Forms.Label();
      this.lblCOMMDesc = new System.Windows.Forms.Label();
      this.cmbCLanguage = new System.Windows.Forms.ComboBox();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.CommentList = new System.Windows.Forms.ListView();
      this.colDescriptor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.Panel1 = new System.Windows.Forms.Panel();
      this.txtPOS2 = new System.Windows.Forms.MaskedTextBox();
      this.txtPOS1 = new System.Windows.Forms.MaskedTextBox();
      this.txtTrack2 = new System.Windows.Forms.MaskedTextBox();
      this.txtTrack1 = new System.Windows.Forms.MaskedTextBox();
      this.txtYear = new System.Windows.Forms.MaskedTextBox();
      this.txtBPM = new System.Windows.Forms.MaskedTextBox();
      this.cmbArtist = new ID3_TagIT.ComboBoxAutoComplete();
      this.CheckBox8 = new System.Windows.Forms.CheckBox();
      this.CheckBox7 = new System.Windows.Forms.CheckBox();
      this.CheckBox6 = new System.Windows.Forms.CheckBox();
      this.CheckBox4 = new System.Windows.Forms.CheckBox();
      this.CheckBox3 = new System.Windows.Forms.CheckBox();
      this.CheckBox2 = new System.Windows.Forms.CheckBox();
      this.CheckBox1 = new System.Windows.Forms.CheckBox();
      this.lblBPM = new System.Windows.Forms.Label();
      this.YearFormat = new System.Windows.Forms.HScrollBar();
      this.lblOf2 = new System.Windows.Forms.Label();
      this.lblOf1 = new System.Windows.Forms.Label();
      this.txtAlbum = new System.Windows.Forms.TextBox();
      this.txtTitle = new System.Windows.Forms.TextBox();
      this.lblTitle = new System.Windows.Forms.Label();
      this.lblAlbum = new System.Windows.Forms.Label();
      this.lblPosMedia = new System.Windows.Forms.Label();
      this.lblYear = new System.Windows.Forms.Label();
      this.lblTrack = new System.Windows.Forms.Label();
      this.lblArtist = new System.Windows.Forms.Label();
      this.Panel2 = new System.Windows.Forms.Panel();
      this.cmbGenre = new ID3_TagIT.ComboBoxAutoComplete();
      this.lblGenreInfo = new System.Windows.Forms.Label();
      this.CheckBox9 = new System.Windows.Forms.CheckBox();
      this.btnMoveGenre = new System.Windows.Forms.Button();
      this.btnRemoveGenre = new System.Windows.Forms.Button();
      this.btnAddGenre = new System.Windows.Forms.Button();
      this.lblGenre = new System.Windows.Forms.Label();
      this.GenreList = new System.Windows.Forms.ListBox();
      this.panWeb = new System.Windows.Forms.Panel();
      this.Panel10 = new System.Windows.Forms.Panel();
      this.CheckBox32 = new System.Windows.Forms.CheckBox();
      this.CheckBox31 = new System.Windows.Forms.CheckBox();
      this.CheckBox30 = new System.Windows.Forms.CheckBox();
      this.CheckBox29 = new System.Windows.Forms.CheckBox();
      this.CheckBox28 = new System.Windows.Forms.CheckBox();
      this.CheckBox27 = new System.Windows.Forms.CheckBox();
      this.CheckBox26 = new System.Windows.Forms.CheckBox();
      this.CheckBox25 = new System.Windows.Forms.CheckBox();
      this.txtCOMMInfURL = new System.Windows.Forms.TextBox();
      this.lblCOMMInfURL = new System.Windows.Forms.Label();
      this.txtPubURL = new System.Windows.Forms.TextBox();
      this.lblPubURL = new System.Windows.Forms.Label();
      this.txtPayURL = new System.Windows.Forms.TextBox();
      this.lblPayURL = new System.Windows.Forms.Label();
      this.txtINetRadioURL = new System.Windows.Forms.TextBox();
      this.lblINetRadioURL = new System.Windows.Forms.Label();
      this.txtAudioSRCURL = new System.Windows.Forms.TextBox();
      this.lblAudioSRCURL = new System.Windows.Forms.Label();
      this.txtCopyInfURL = new System.Windows.Forms.TextBox();
      this.txtArtistURL = new System.Windows.Forms.TextBox();
      this.txtAudioFileURL = new System.Windows.Forms.TextBox();
      this.lblAudioFileURL = new System.Windows.Forms.Label();
      this.lblArtistURL = new System.Windows.Forms.Label();
      this.lblCopyInfURL = new System.Windows.Forms.Label();
      this.panRating = new System.Windows.Forms.Panel();
      this.Panel11 = new System.Windows.Forms.Panel();
      this.CheckBox33 = new System.Windows.Forms.CheckBox();
      this.lblInfo = new System.Windows.Forms.Label();
      this.btnMoveRating = new System.Windows.Forms.Button();
      this.btnRemoveRating = new System.Windows.Forms.Button();
      this.btnAddRating = new System.Windows.Forms.Button();
      this.RatingList = new System.Windows.Forms.ListView();
      this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.txtRatingCounter = new System.Windows.Forms.NumericUpDown();
      this.txtRatingRating = new System.Windows.Forms.NumericUpDown();
      this.txtRatingUser = new System.Windows.Forms.TextBox();
      this.lblRatingRating = new System.Windows.Forms.Label();
      this.lblRatingCounter = new System.Windows.Forms.Label();
      this.lblRatingUser = new System.Windows.Forms.Label();
      this.panInvolved = new System.Windows.Forms.Panel();
      this.Panel15 = new System.Windows.Forms.Panel();
      this.CheckBox45 = new System.Windows.Forms.CheckBox();
      this.lblMusicianInfo = new System.Windows.Forms.Label();
      this.txtMusicianName = new System.Windows.Forms.TextBox();
      this.btnRemoveMusician = new System.Windows.Forms.Button();
      this.btnAddMusician = new System.Windows.Forms.Button();
      this.lblMusicianName = new System.Windows.Forms.Label();
      this.lblMusicianInst = new System.Windows.Forms.Label();
      this.txtMusicianInst = new System.Windows.Forms.TextBox();
      this.TMCLList = new System.Windows.Forms.ListView();
      this.ColumnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.Panel16 = new System.Windows.Forms.Panel();
      this.CheckBox44 = new System.Windows.Forms.CheckBox();
      this.txtInvPerson = new System.Windows.Forms.TextBox();
      this.btnRemoveInv = new System.Windows.Forms.Button();
      this.btnAddInv = new System.Windows.Forms.Button();
      this.lblInvPerson = new System.Windows.Forms.Label();
      this.lblInvFunction = new System.Windows.Forms.Label();
      this.txtInvFunction = new System.Windows.Forms.TextBox();
      this.TIPLList = new System.Windows.Forms.ListView();
      this.ColumnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.panPic = new System.Windows.Forms.Panel();
      this.Panel7 = new System.Windows.Forms.Panel();
      this.chkPicRelativPath = new System.Windows.Forms.CheckBox();
      this.CheckBox34 = new System.Windows.Forms.CheckBox();
      this.btnRemovePicture = new System.Windows.Forms.Button();
      this.btnAddPicture = new System.Windows.Forms.Button();
      this.btnGetPic = new System.Windows.Forms.Button();
      this.chkPicInclude = new System.Windows.Forms.CheckBox();
      this.lblPicPath = new System.Windows.Forms.Label();
      this.txtPicPath = new System.Windows.Forms.TextBox();
      this.PicList = new System.Windows.Forms.ListView();
      this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lblPicType = new System.Windows.Forms.Label();
      this.lblPicDesc = new System.Windows.Forms.Label();
      this.cmbPicType = new System.Windows.Forms.ComboBox();
      this.txtPDescriptor = new System.Windows.Forms.TextBox();
      this.APICView = new System.Windows.Forms.PictureBox();
      this.panLyrics = new System.Windows.Forms.Panel();
      this.Panel8 = new System.Windows.Forms.Panel();
      this.txtLyrics = new System.Windows.Forms.RichTextBox();
      this.btnLyricsFile = new System.Windows.Forms.Button();
      this.CheckBox35 = new System.Windows.Forms.CheckBox();
      this.btnMoveLyrics = new System.Windows.Forms.Button();
      this.btnRemoveLyrics = new System.Windows.Forms.Button();
      this.btnAddLyrics = new System.Windows.Forms.Button();
      this.lblLyrics = new System.Windows.Forms.Label();
      this.lblLyLan = new System.Windows.Forms.Label();
      this.lblLyDesc = new System.Windows.Forms.Label();
      this.cmbLLanguage = new System.Windows.Forms.ComboBox();
      this.txtLDescriptor = new System.Windows.Forms.TextBox();
      this.LyricsList = new System.Windows.Forms.ListView();
      this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.panUser = new System.Windows.Forms.Panel();
      this.Panel12 = new System.Windows.Forms.Panel();
      this.CheckBox36 = new System.Windows.Forms.CheckBox();
      this.txtTXXXContent = new System.Windows.Forms.TextBox();
      this.btnRemoveTXXX = new System.Windows.Forms.Button();
      this.btnAddTXXX = new System.Windows.Forms.Button();
      this.lblTXXXContent = new System.Windows.Forms.Label();
      this.lblTXXXDesc = new System.Windows.Forms.Label();
      this.txtTXXXDesc = new System.Windows.Forms.TextBox();
      this.TXXXList = new System.Windows.Forms.ListView();
      this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.Panel13 = new System.Windows.Forms.Panel();
      this.CheckBox37 = new System.Windows.Forms.CheckBox();
      this.txtWXXXContent = new System.Windows.Forms.TextBox();
      this.btnRemoveWXXX = new System.Windows.Forms.Button();
      this.btnAddWXXX = new System.Windows.Forms.Button();
      this.lblWXXXContent = new System.Windows.Forms.Label();
      this.lblWXXXDesc = new System.Windows.Forms.Label();
      this.txtWXXXDesc = new System.Windows.Forms.TextBox();
      this.WXXXList = new System.Windows.Forms.ListView();
      this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lblDigits = new System.Windows.Forms.Label();
      this.txtDigits = new System.Windows.Forms.NumericUpDown();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.chkRemoveAllNOT = new System.Windows.Forms.CheckBox();
      this.lblInfoStar = new System.Windows.Forms.Label();
      this.SelectionBar = new DevComponents.DotNetBar.ExplorerBar();
      this.TAGV2grpTAG = new DevComponents.DotNetBar.ExplorerBarGroupItem();
      this.TAGV2ButtonItem1 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem2 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem3 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem4 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem5 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem6 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem7 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem8 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2ButtonItem9 = new DevComponents.DotNetBar.ButtonItem();
      this.TAGV2grpCommands = new DevComponents.DotNetBar.ExplorerBarGroupItem();
      this.btnSwapAT = new DevComponents.DotNetBar.ButtonItem();
      this.btnSwapAA = new DevComponents.DotNetBar.ButtonItem();
      this.btnSwapTA = new DevComponents.DotNetBar.ButtonItem();
      this.btnImport = new DevComponents.DotNetBar.ButtonItem();
      this.btnExport = new DevComponents.DotNetBar.ButtonItem();
      this.btnGet = new DevComponents.DotNetBar.ButtonItem();
      this.TopPanel = new DevComponents.DotNetBar.PanelEx();
      this.btnOK = new System.Windows.Forms.Button();
      this.btnCancel = new System.Windows.Forms.Button();
      this.ButtomPanel = new DevComponents.DotNetBar.PanelEx();
      this.Label = new DevComponents.DotNetBar.ButtonItem();
      this.panDetail.SuspendLayout();
      this.Panel9.SuspendLayout();
      this.Panel5.SuspendLayout();
      this.Panel14.SuspendLayout();
      this.Panel4.SuspendLayout();
      this.panOriginal.SuspendLayout();
      this.Panel6.SuspendLayout();
      this.panMain.SuspendLayout();
      this.Panel3.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.panWeb.SuspendLayout();
      this.Panel10.SuspendLayout();
      this.panRating.SuspendLayout();
      this.Panel11.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatingCounter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatingRating)).BeginInit();
      this.panInvolved.SuspendLayout();
      this.Panel15.SuspendLayout();
      this.Panel16.SuspendLayout();
      this.panPic.SuspendLayout();
      this.Panel7.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.APICView)).BeginInit();
      this.panLyrics.SuspendLayout();
      this.Panel8.SuspendLayout();
      this.panUser.SuspendLayout();
      this.Panel12.SuspendLayout();
      this.Panel13.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.SelectionBar)).BeginInit();
      this.ButtomPanel.SuspendLayout();
      this.SuspendLayout();
      // 
      // panDetail
      // 
      this.panDetail.Controls.Add(this.Panel9);
      this.panDetail.Controls.Add(this.Panel5);
      this.panDetail.Controls.Add(this.Panel14);
      this.panDetail.Controls.Add(this.Panel4);
      this.panDetail.Location = new System.Drawing.Point(168, 24);
      this.panDetail.Name = "panDetail";
      this.panDetail.Size = new System.Drawing.Size(688, 456);
      this.panDetail.TabIndex = 4;
      // 
      // Panel9
      // 
      this.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel9.Controls.Add(this.cmbMedia);
      this.Panel9.Controls.Add(this.lblMediaTyp);
      this.Panel9.Controls.Add(this.chkTLEN);
      this.Panel9.Controls.Add(this.lblTLEN);
      this.Panel9.Controls.Add(this.CheckBox5);
      this.Panel9.Location = new System.Drawing.Point(8, 376);
      this.Panel9.Name = "Panel9";
      this.Panel9.Size = new System.Drawing.Size(672, 64);
      this.Panel9.TabIndex = 3;
      // 
      // cmbMedia
      // 
      this.cmbMedia.ItemHeight = 13;
      this.cmbMedia.Items.AddRange(new object[] {
            "ANA (Other analogue media)",
            "CD (CD)",
            "DAT (DAT)",
            "DCC (DCC)",
            "DIG (Other digital media)",
            "DVD (DVD)",
            "LD (LaserDisc)",
            "MC (Music Cassette)",
            "MD (MiniDisc)",
            "RAD (Radio)",
            "REE (Reel)",
            "TEL (Telephone)",
            "TT (Turntable records)",
            "TV (Television)",
            "VID (Video)"});
      this.cmbMedia.Location = new System.Drawing.Point(167, 8);
      this.cmbMedia.Name = "cmbMedia";
      this.cmbMedia.Size = new System.Drawing.Size(209, 21);
      this.cmbMedia.TabIndex = 19;
      this.cmbMedia.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.cmbMedia.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbMedia.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblMediaTyp
      // 
      this.lblMediaTyp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblMediaTyp.Location = new System.Drawing.Point(8, 10);
      this.lblMediaTyp.Name = "lblMediaTyp";
      this.lblMediaTyp.Size = new System.Drawing.Size(120, 16);
      this.lblMediaTyp.TabIndex = 18;
      this.lblMediaTyp.Text = "M&edia type:";
      // 
      // chkTLEN
      // 
      this.chkTLEN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkTLEN.Location = new System.Drawing.Point(167, 40);
      this.chkTLEN.Name = "chkTLEN";
      this.chkTLEN.Size = new System.Drawing.Size(232, 16);
      this.chkTLEN.TabIndex = 33;
      this.chkTLEN.Text = "Create track length entry from file";
      // 
      // lblTLEN
      // 
      this.lblTLEN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTLEN.Location = new System.Drawing.Point(8, 40);
      this.lblTLEN.Name = "lblTLEN";
      this.lblTLEN.Size = new System.Drawing.Size(112, 16);
      this.lblTLEN.TabIndex = 32;
      this.lblTLEN.Text = "Track length (msec):";
      // 
      // CheckBox5
      // 
      this.CheckBox5.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox5.Location = new System.Drawing.Point(384, 10);
      this.CheckBox5.Name = "CheckBox5";
      this.CheckBox5.Size = new System.Drawing.Size(16, 16);
      this.CheckBox5.TabIndex = 20;
      // 
      // Panel5
      // 
      this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel5.Controls.Add(this.CheckBox16);
      this.Panel5.Controls.Add(this.CheckBox15);
      this.Panel5.Controls.Add(this.txtContent);
      this.Panel5.Controls.Add(this.txtSubTitle);
      this.Panel5.Controls.Add(this.lblSubTitle);
      this.Panel5.Controls.Add(this.lblContent);
      this.Panel5.Location = new System.Drawing.Point(8, 224);
      this.Panel5.Name = "Panel5";
      this.Panel5.Size = new System.Drawing.Size(672, 56);
      this.Panel5.TabIndex = 1;
      // 
      // CheckBox16
      // 
      this.CheckBox16.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox16.Location = new System.Drawing.Point(648, 32);
      this.CheckBox16.Name = "CheckBox16";
      this.CheckBox16.Size = new System.Drawing.Size(16, 16);
      this.CheckBox16.TabIndex = 21;
      // 
      // CheckBox15
      // 
      this.CheckBox15.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox15.Location = new System.Drawing.Point(648, 8);
      this.CheckBox15.Name = "CheckBox15";
      this.CheckBox15.Size = new System.Drawing.Size(16, 16);
      this.CheckBox15.TabIndex = 18;
      // 
      // txtContent
      // 
      this.txtContent.Location = new System.Drawing.Point(168, 6);
      this.txtContent.Name = "txtContent";
      this.txtContent.Size = new System.Drawing.Size(472, 20);
      this.txtContent.TabIndex = 17;
      this.txtContent.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtContent.Enter += new System.EventHandler(this.Select_Enter);
      this.txtContent.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtSubTitle
      // 
      this.txtSubTitle.Location = new System.Drawing.Point(168, 30);
      this.txtSubTitle.Name = "txtSubTitle";
      this.txtSubTitle.Size = new System.Drawing.Size(472, 20);
      this.txtSubTitle.TabIndex = 20;
      this.txtSubTitle.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtSubTitle.Enter += new System.EventHandler(this.Select_Enter);
      this.txtSubTitle.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblSubTitle
      // 
      this.lblSubTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblSubTitle.Location = new System.Drawing.Point(8, 32);
      this.lblSubTitle.Name = "lblSubTitle";
      this.lblSubTitle.Size = new System.Drawing.Size(128, 16);
      this.lblSubTitle.TabIndex = 19;
      this.lblSubTitle.Text = "&Sub Title:";
      // 
      // lblContent
      // 
      this.lblContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblContent.Location = new System.Drawing.Point(8, 8);
      this.lblContent.Name = "lblContent";
      this.lblContent.Size = new System.Drawing.Size(128, 16);
      this.lblContent.TabIndex = 16;
      this.lblContent.Text = "Con&tent Group:";
      // 
      // Panel14
      // 
      this.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel14.Controls.Add(this.CheckBox41);
      this.Panel14.Controls.Add(this.CheckBox42);
      this.Panel14.Controls.Add(this.CheckBox43);
      this.Panel14.Controls.Add(this.txtSortArtist);
      this.Panel14.Controls.Add(this.txtSortTitle);
      this.Panel14.Controls.Add(this.txtSortAlbum);
      this.Panel14.Controls.Add(this.lblAlbumSort);
      this.Panel14.Controls.Add(this.lblTitleSort);
      this.Panel14.Controls.Add(this.lblArtistSort);
      this.Panel14.Location = new System.Drawing.Point(8, 288);
      this.Panel14.Name = "Panel14";
      this.Panel14.Size = new System.Drawing.Size(672, 80);
      this.Panel14.TabIndex = 2;
      // 
      // CheckBox41
      // 
      this.CheckBox41.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox41.Location = new System.Drawing.Point(648, 56);
      this.CheckBox41.Name = "CheckBox41";
      this.CheckBox41.Size = new System.Drawing.Size(16, 16);
      this.CheckBox41.TabIndex = 30;
      // 
      // CheckBox42
      // 
      this.CheckBox42.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox42.Location = new System.Drawing.Point(648, 32);
      this.CheckBox42.Name = "CheckBox42";
      this.CheckBox42.Size = new System.Drawing.Size(16, 16);
      this.CheckBox42.TabIndex = 27;
      // 
      // CheckBox43
      // 
      this.CheckBox43.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox43.Location = new System.Drawing.Point(648, 8);
      this.CheckBox43.Name = "CheckBox43";
      this.CheckBox43.Size = new System.Drawing.Size(16, 16);
      this.CheckBox43.TabIndex = 24;
      // 
      // txtSortArtist
      // 
      this.txtSortArtist.Location = new System.Drawing.Point(168, 6);
      this.txtSortArtist.Name = "txtSortArtist";
      this.txtSortArtist.Size = new System.Drawing.Size(472, 20);
      this.txtSortArtist.TabIndex = 23;
      this.txtSortArtist.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtSortArtist.Enter += new System.EventHandler(this.Select_Enter);
      this.txtSortArtist.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtSortTitle
      // 
      this.txtSortTitle.Location = new System.Drawing.Point(168, 54);
      this.txtSortTitle.Name = "txtSortTitle";
      this.txtSortTitle.Size = new System.Drawing.Size(472, 20);
      this.txtSortTitle.TabIndex = 29;
      this.txtSortTitle.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtSortTitle.Enter += new System.EventHandler(this.Select_Enter);
      this.txtSortTitle.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtSortAlbum
      // 
      this.txtSortAlbum.Location = new System.Drawing.Point(168, 30);
      this.txtSortAlbum.Name = "txtSortAlbum";
      this.txtSortAlbum.Size = new System.Drawing.Size(472, 20);
      this.txtSortAlbum.TabIndex = 26;
      this.txtSortAlbum.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtSortAlbum.Enter += new System.EventHandler(this.Select_Enter);
      this.txtSortAlbum.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblAlbumSort
      // 
      this.lblAlbumSort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAlbumSort.Location = new System.Drawing.Point(8, 32);
      this.lblAlbumSort.Name = "lblAlbumSort";
      this.lblAlbumSort.Size = new System.Drawing.Size(168, 16);
      this.lblAlbumSort.TabIndex = 25;
      this.lblAlbumSort.Text = "Al&bum sort name (Ver. 2.4 only):";
      // 
      // lblTitleSort
      // 
      this.lblTitleSort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitleSort.Location = new System.Drawing.Point(8, 56);
      this.lblTitleSort.Name = "lblTitleSort";
      this.lblTitleSort.Size = new System.Drawing.Size(160, 16);
      this.lblTitleSort.TabIndex = 28;
      this.lblTitleSort.Text = "&Title sort name (Ver. 2.4 only):";
      // 
      // lblArtistSort
      // 
      this.lblArtistSort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblArtistSort.Location = new System.Drawing.Point(8, 8);
      this.lblArtistSort.Name = "lblArtistSort";
      this.lblArtistSort.Size = new System.Drawing.Size(168, 16);
      this.lblArtistSort.TabIndex = 22;
      this.lblArtistSort.Text = "&Artist sort name (Ver. 2.4 only):";
      // 
      // Panel4
      // 
      this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel4.Controls.Add(this.CheckBox14);
      this.Panel4.Controls.Add(this.CheckBox13);
      this.Panel4.Controls.Add(this.CheckBox12);
      this.Panel4.Controls.Add(this.CheckBox11);
      this.Panel4.Controls.Add(this.txtComposer);
      this.Panel4.Controls.Add(this.lblComposer);
      this.Panel4.Controls.Add(this.txtBand);
      this.Panel4.Controls.Add(this.txtModified);
      this.Panel4.Controls.Add(this.txtConductor);
      this.Panel4.Controls.Add(this.lblConductor);
      this.Panel4.Controls.Add(this.lblModified);
      this.Panel4.Controls.Add(this.lblBand);
      this.Panel4.Controls.Add(this.CheckBox40);
      this.Panel4.Controls.Add(this.txtCopyright);
      this.Panel4.Controls.Add(this.lblCopyright);
      this.Panel4.Controls.Add(this.CheckBox19);
      this.Panel4.Controls.Add(this.CheckBox18);
      this.Panel4.Controls.Add(this.CheckBox17);
      this.Panel4.Controls.Add(this.txtLyWriter);
      this.Panel4.Controls.Add(this.txtEncoded);
      this.Panel4.Controls.Add(this.txtPublisher);
      this.Panel4.Controls.Add(this.lblPublisher);
      this.Panel4.Controls.Add(this.lblEncoded);
      this.Panel4.Controls.Add(this.lblLyWriter);
      this.Panel4.Location = new System.Drawing.Point(8, 8);
      this.Panel4.Name = "Panel4";
      this.Panel4.Size = new System.Drawing.Size(672, 208);
      this.Panel4.TabIndex = 0;
      // 
      // CheckBox14
      // 
      this.CheckBox14.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox14.Location = new System.Drawing.Point(648, 81);
      this.CheckBox14.Name = "CheckBox14";
      this.CheckBox14.Size = new System.Drawing.Size(16, 16);
      this.CheckBox14.TabIndex = 15;
      // 
      // CheckBox13
      // 
      this.CheckBox13.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox13.Location = new System.Drawing.Point(648, 57);
      this.CheckBox13.Name = "CheckBox13";
      this.CheckBox13.Size = new System.Drawing.Size(16, 16);
      this.CheckBox13.TabIndex = 12;
      // 
      // CheckBox12
      // 
      this.CheckBox12.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox12.Location = new System.Drawing.Point(648, 33);
      this.CheckBox12.Name = "CheckBox12";
      this.CheckBox12.Size = new System.Drawing.Size(16, 16);
      this.CheckBox12.TabIndex = 9;
      // 
      // CheckBox11
      // 
      this.CheckBox11.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox11.Location = new System.Drawing.Point(648, 9);
      this.CheckBox11.Name = "CheckBox11";
      this.CheckBox11.Size = new System.Drawing.Size(16, 16);
      this.CheckBox11.TabIndex = 6;
      // 
      // txtComposer
      // 
      this.txtComposer.Location = new System.Drawing.Point(168, 78);
      this.txtComposer.Name = "txtComposer";
      this.txtComposer.Size = new System.Drawing.Size(472, 20);
      this.txtComposer.TabIndex = 14;
      this.txtComposer.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtComposer.Enter += new System.EventHandler(this.Select_Enter);
      this.txtComposer.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblComposer
      // 
      this.lblComposer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblComposer.Location = new System.Drawing.Point(8, 80);
      this.lblComposer.Name = "lblComposer";
      this.lblComposer.Size = new System.Drawing.Size(128, 16);
      this.lblComposer.TabIndex = 13;
      this.lblComposer.Text = "Co&mposer:";
      // 
      // txtBand
      // 
      this.txtBand.Location = new System.Drawing.Point(168, 6);
      this.txtBand.Name = "txtBand";
      this.txtBand.Size = new System.Drawing.Size(472, 20);
      this.txtBand.TabIndex = 5;
      this.txtBand.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtBand.Enter += new System.EventHandler(this.Select_Enter);
      this.txtBand.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtModified
      // 
      this.txtModified.Location = new System.Drawing.Point(168, 54);
      this.txtModified.Name = "txtModified";
      this.txtModified.Size = new System.Drawing.Size(472, 20);
      this.txtModified.TabIndex = 11;
      this.txtModified.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtModified.Enter += new System.EventHandler(this.Select_Enter);
      this.txtModified.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtConductor
      // 
      this.txtConductor.Location = new System.Drawing.Point(168, 30);
      this.txtConductor.Name = "txtConductor";
      this.txtConductor.Size = new System.Drawing.Size(472, 20);
      this.txtConductor.TabIndex = 8;
      this.txtConductor.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtConductor.Enter += new System.EventHandler(this.Select_Enter);
      this.txtConductor.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblConductor
      // 
      this.lblConductor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblConductor.Location = new System.Drawing.Point(8, 32);
      this.lblConductor.Name = "lblConductor";
      this.lblConductor.Size = new System.Drawing.Size(128, 16);
      this.lblConductor.TabIndex = 7;
      this.lblConductor.Text = "&Conductor:";
      // 
      // lblModified
      // 
      this.lblModified.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblModified.Location = new System.Drawing.Point(8, 56);
      this.lblModified.Name = "lblModified";
      this.lblModified.Size = new System.Drawing.Size(128, 16);
      this.lblModified.TabIndex = 10;
      this.lblModified.Text = "Modified / Remixed b&y:";
      // 
      // lblBand
      // 
      this.lblBand.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblBand.Location = new System.Drawing.Point(8, 8);
      this.lblBand.Name = "lblBand";
      this.lblBand.Size = new System.Drawing.Size(128, 16);
      this.lblBand.TabIndex = 4;
      this.lblBand.Text = "&Band / Orchestra:";
      // 
      // CheckBox40
      // 
      this.CheckBox40.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox40.Location = new System.Drawing.Point(648, 176);
      this.CheckBox40.Name = "CheckBox40";
      this.CheckBox40.Size = new System.Drawing.Size(16, 16);
      this.CheckBox40.TabIndex = 11;
      // 
      // txtCopyright
      // 
      this.txtCopyright.Location = new System.Drawing.Point(168, 175);
      this.txtCopyright.Name = "txtCopyright";
      this.txtCopyright.Size = new System.Drawing.Size(472, 20);
      this.txtCopyright.TabIndex = 10;
      this.txtCopyright.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtCopyright.Enter += new System.EventHandler(this.Select_Enter);
      this.txtCopyright.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblCopyright
      // 
      this.lblCopyright.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCopyright.Location = new System.Drawing.Point(8, 175);
      this.lblCopyright.Name = "lblCopyright";
      this.lblCopyright.Size = new System.Drawing.Size(128, 16);
      this.lblCopyright.TabIndex = 9;
      this.lblCopyright.Text = "Copyright:";
      // 
      // CheckBox19
      // 
      this.CheckBox19.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox19.Location = new System.Drawing.Point(648, 152);
      this.CheckBox19.Name = "CheckBox19";
      this.CheckBox19.Size = new System.Drawing.Size(16, 16);
      this.CheckBox19.TabIndex = 8;
      // 
      // CheckBox18
      // 
      this.CheckBox18.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox18.Location = new System.Drawing.Point(648, 128);
      this.CheckBox18.Name = "CheckBox18";
      this.CheckBox18.Size = new System.Drawing.Size(16, 16);
      this.CheckBox18.TabIndex = 5;
      // 
      // CheckBox17
      // 
      this.CheckBox17.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox17.Location = new System.Drawing.Point(648, 104);
      this.CheckBox17.Name = "CheckBox17";
      this.CheckBox17.Size = new System.Drawing.Size(16, 16);
      this.CheckBox17.TabIndex = 2;
      // 
      // txtLyWriter
      // 
      this.txtLyWriter.Location = new System.Drawing.Point(168, 103);
      this.txtLyWriter.Name = "txtLyWriter";
      this.txtLyWriter.Size = new System.Drawing.Size(472, 20);
      this.txtLyWriter.TabIndex = 1;
      this.txtLyWriter.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtLyWriter.Enter += new System.EventHandler(this.Select_Enter);
      this.txtLyWriter.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtEncoded
      // 
      this.txtEncoded.Location = new System.Drawing.Point(168, 151);
      this.txtEncoded.Name = "txtEncoded";
      this.txtEncoded.Size = new System.Drawing.Size(472, 20);
      this.txtEncoded.TabIndex = 7;
      this.txtEncoded.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtEncoded.Enter += new System.EventHandler(this.Select_Enter);
      this.txtEncoded.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtPublisher
      // 
      this.txtPublisher.Location = new System.Drawing.Point(168, 127);
      this.txtPublisher.Name = "txtPublisher";
      this.txtPublisher.Size = new System.Drawing.Size(472, 20);
      this.txtPublisher.TabIndex = 4;
      this.txtPublisher.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtPublisher.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPublisher.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblPublisher
      // 
      this.lblPublisher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPublisher.Location = new System.Drawing.Point(8, 127);
      this.lblPublisher.Name = "lblPublisher";
      this.lblPublisher.Size = new System.Drawing.Size(128, 16);
      this.lblPublisher.TabIndex = 3;
      this.lblPublisher.Text = "Publis&her:";
      // 
      // lblEncoded
      // 
      this.lblEncoded.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblEncoded.Location = new System.Drawing.Point(8, 151);
      this.lblEncoded.Name = "lblEncoded";
      this.lblEncoded.Size = new System.Drawing.Size(128, 16);
      this.lblEncoded.TabIndex = 6;
      this.lblEncoded.Text = "&Encoded by:";
      // 
      // lblLyWriter
      // 
      this.lblLyWriter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLyWriter.Location = new System.Drawing.Point(8, 103);
      this.lblLyWriter.Name = "lblLyWriter";
      this.lblLyWriter.Size = new System.Drawing.Size(128, 16);
      this.lblLyWriter.TabIndex = 0;
      this.lblLyWriter.Text = "Lyr&ics / Text Writer:";
      // 
      // panOriginal
      // 
      this.panOriginal.Controls.Add(this.Panel6);
      this.panOriginal.Location = new System.Drawing.Point(168, 24);
      this.panOriginal.Name = "panOriginal";
      this.panOriginal.Size = new System.Drawing.Size(688, 240);
      this.panOriginal.TabIndex = 5;
      // 
      // Panel6
      // 
      this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel6.Controls.Add(this.txtTORY);
      this.Panel6.Controls.Add(this.CheckBox39);
      this.Panel6.Controls.Add(this.lblOYearInfo);
      this.Panel6.Controls.Add(this.TORYFormat);
      this.Panel6.Controls.Add(this.lblOYear);
      this.Panel6.Controls.Add(this.CheckBox24);
      this.Panel6.Controls.Add(this.CheckBox23);
      this.Panel6.Controls.Add(this.CheckBox22);
      this.Panel6.Controls.Add(this.CheckBox21);
      this.Panel6.Controls.Add(this.CheckBox20);
      this.Panel6.Controls.Add(this.txtOOwner);
      this.Panel6.Controls.Add(this.lblOOwner);
      this.Panel6.Controls.Add(this.txtOArtist);
      this.Panel6.Controls.Add(this.lblOArtist);
      this.Panel6.Controls.Add(this.txtOAlbum);
      this.Panel6.Controls.Add(this.txtOLyWriter);
      this.Panel6.Controls.Add(this.txtOFilename);
      this.Panel6.Controls.Add(this.lblOFilename);
      this.Panel6.Controls.Add(this.lblOLyWriter);
      this.Panel6.Controls.Add(this.lblOAlbum);
      this.Panel6.Location = new System.Drawing.Point(8, 8);
      this.Panel6.Name = "Panel6";
      this.Panel6.Size = new System.Drawing.Size(672, 176);
      this.Panel6.TabIndex = 3;
      // 
      // txtTORY
      // 
      this.txtTORY.Location = new System.Drawing.Point(168, 126);
      this.txtTORY.Mask = "####-##-##";
      this.txtTORY.Name = "txtTORY";
      this.txtTORY.Size = new System.Drawing.Size(112, 20);
      this.txtTORY.TabIndex = 47;
      this.txtTORY.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtTORY.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTORY.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // CheckBox39
      // 
      this.CheckBox39.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox39.Location = new System.Drawing.Point(336, 128);
      this.CheckBox39.Name = "CheckBox39";
      this.CheckBox39.Size = new System.Drawing.Size(16, 16);
      this.CheckBox39.TabIndex = 51;
      // 
      // lblOYearInfo
      // 
      this.lblOYearInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOYearInfo.Location = new System.Drawing.Point(168, 152);
      this.lblOYearInfo.Name = "lblOYearInfo";
      this.lblOYearInfo.Size = new System.Drawing.Size(336, 16);
      this.lblOYearInfo.TabIndex = 50;
      this.lblOYearInfo.Text = "(In TAG Ver. 2.3 only the year entry will be saved)";
      // 
      // TORYFormat
      // 
      this.TORYFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.TORYFormat.LargeChange = 1;
      this.TORYFormat.Location = new System.Drawing.Point(288, 128);
      this.TORYFormat.Maximum = 2;
      this.TORYFormat.Name = "TORYFormat";
      this.TORYFormat.Size = new System.Drawing.Size(32, 16);
      this.TORYFormat.TabIndex = 48;
      this.TORYFormat.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TORYFormat_Scroll);
      // 
      // lblOYear
      // 
      this.lblOYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOYear.Location = new System.Drawing.Point(8, 128);
      this.lblOYear.Name = "lblOYear";
      this.lblOYear.Size = new System.Drawing.Size(144, 16);
      this.lblOYear.TabIndex = 46;
      this.lblOYear.Text = "Original release &year (date):";
      // 
      // CheckBox24
      // 
      this.CheckBox24.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox24.Location = new System.Drawing.Point(648, 104);
      this.CheckBox24.Name = "CheckBox24";
      this.CheckBox24.Size = new System.Drawing.Size(16, 16);
      this.CheckBox24.TabIndex = 45;
      // 
      // CheckBox23
      // 
      this.CheckBox23.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox23.Location = new System.Drawing.Point(648, 80);
      this.CheckBox23.Name = "CheckBox23";
      this.CheckBox23.Size = new System.Drawing.Size(16, 16);
      this.CheckBox23.TabIndex = 42;
      // 
      // CheckBox22
      // 
      this.CheckBox22.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox22.Location = new System.Drawing.Point(648, 56);
      this.CheckBox22.Name = "CheckBox22";
      this.CheckBox22.Size = new System.Drawing.Size(16, 16);
      this.CheckBox22.TabIndex = 39;
      // 
      // CheckBox21
      // 
      this.CheckBox21.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox21.Location = new System.Drawing.Point(648, 32);
      this.CheckBox21.Name = "CheckBox21";
      this.CheckBox21.Size = new System.Drawing.Size(16, 16);
      this.CheckBox21.TabIndex = 36;
      // 
      // CheckBox20
      // 
      this.CheckBox20.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox20.Location = new System.Drawing.Point(648, 8);
      this.CheckBox20.Name = "CheckBox20";
      this.CheckBox20.Size = new System.Drawing.Size(16, 16);
      this.CheckBox20.TabIndex = 33;
      // 
      // txtOOwner
      // 
      this.txtOOwner.Location = new System.Drawing.Point(168, 102);
      this.txtOOwner.Name = "txtOOwner";
      this.txtOOwner.Size = new System.Drawing.Size(472, 20);
      this.txtOOwner.TabIndex = 44;
      this.txtOOwner.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtOOwner.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOOwner.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblOOwner
      // 
      this.lblOOwner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOOwner.Location = new System.Drawing.Point(8, 104);
      this.lblOOwner.Name = "lblOOwner";
      this.lblOOwner.Size = new System.Drawing.Size(128, 16);
      this.lblOOwner.TabIndex = 43;
      this.lblOOwner.Text = "Original &owner:";
      // 
      // txtOArtist
      // 
      this.txtOArtist.Location = new System.Drawing.Point(168, 78);
      this.txtOArtist.Name = "txtOArtist";
      this.txtOArtist.Size = new System.Drawing.Size(472, 20);
      this.txtOArtist.TabIndex = 41;
      this.txtOArtist.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtOArtist.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOArtist.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblOArtist
      // 
      this.lblOArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOArtist.Location = new System.Drawing.Point(8, 80);
      this.lblOArtist.Name = "lblOArtist";
      this.lblOArtist.Size = new System.Drawing.Size(128, 16);
      this.lblOArtist.TabIndex = 40;
      this.lblOArtist.Text = "Original &artist:";
      // 
      // txtOAlbum
      // 
      this.txtOAlbum.Location = new System.Drawing.Point(168, 6);
      this.txtOAlbum.Name = "txtOAlbum";
      this.txtOAlbum.Size = new System.Drawing.Size(472, 20);
      this.txtOAlbum.TabIndex = 32;
      this.txtOAlbum.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtOAlbum.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOAlbum.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtOLyWriter
      // 
      this.txtOLyWriter.Location = new System.Drawing.Point(168, 54);
      this.txtOLyWriter.Name = "txtOLyWriter";
      this.txtOLyWriter.Size = new System.Drawing.Size(472, 20);
      this.txtOLyWriter.TabIndex = 38;
      this.txtOLyWriter.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtOLyWriter.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOLyWriter.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtOFilename
      // 
      this.txtOFilename.Location = new System.Drawing.Point(168, 30);
      this.txtOFilename.Name = "txtOFilename";
      this.txtOFilename.Size = new System.Drawing.Size(472, 20);
      this.txtOFilename.TabIndex = 35;
      this.txtOFilename.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtOFilename.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOFilename.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblOFilename
      // 
      this.lblOFilename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOFilename.Location = new System.Drawing.Point(8, 32);
      this.lblOFilename.Name = "lblOFilename";
      this.lblOFilename.Size = new System.Drawing.Size(128, 16);
      this.lblOFilename.TabIndex = 34;
      this.lblOFilename.Text = "Original &filename:";
      // 
      // lblOLyWriter
      // 
      this.lblOLyWriter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOLyWriter.Location = new System.Drawing.Point(8, 56);
      this.lblOLyWriter.Name = "lblOLyWriter";
      this.lblOLyWriter.Size = new System.Drawing.Size(128, 16);
      this.lblOLyWriter.TabIndex = 37;
      this.lblOLyWriter.Text = "Original lyrics &writer:";
      // 
      // lblOAlbum
      // 
      this.lblOAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOAlbum.Location = new System.Drawing.Point(8, 8);
      this.lblOAlbum.Name = "lblOAlbum";
      this.lblOAlbum.Size = new System.Drawing.Size(128, 16);
      this.lblOAlbum.TabIndex = 31;
      this.lblOAlbum.Text = "Original a&lbum title:";
      // 
      // panMain
      // 
      this.panMain.Controls.Add(this.Panel3);
      this.panMain.Controls.Add(this.Panel1);
      this.panMain.Controls.Add(this.Panel2);
      this.panMain.Location = new System.Drawing.Point(168, 24);
      this.panMain.Name = "panMain";
      this.panMain.Size = new System.Drawing.Size(688, 456);
      this.panMain.TabIndex = 4;
      // 
      // Panel3
      // 
      this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel3.Controls.Add(this.lblCommDescInfo);
      this.Panel3.Controls.Add(this.cmbCDescriptor);
      this.Panel3.Controls.Add(this.CheckBox38);
      this.Panel3.Controls.Add(this.CheckBox10);
      this.Panel3.Controls.Add(this.btnMoveComment);
      this.Panel3.Controls.Add(this.btnRemoveComment);
      this.Panel3.Controls.Add(this.btnAddComment);
      this.Panel3.Controls.Add(this.lblCOMM);
      this.Panel3.Controls.Add(this.lblCOMMLan);
      this.Panel3.Controls.Add(this.lblCOMMDesc);
      this.Panel3.Controls.Add(this.cmbCLanguage);
      this.Panel3.Controls.Add(this.txtComment);
      this.Panel3.Controls.Add(this.CommentList);
      this.Panel3.Location = new System.Drawing.Point(8, 264);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new System.Drawing.Size(672, 184);
      this.Panel3.TabIndex = 3;
      // 
      // lblCommDescInfo
      // 
      this.lblCommDescInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblCommDescInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCommDescInfo.Location = new System.Drawing.Point(8, 112);
      this.lblCommDescInfo.Name = "lblCommDescInfo";
      this.lblCommDescInfo.Size = new System.Drawing.Size(120, 64);
      this.lblCommDescInfo.TabIndex = 51;
      this.lblCommDescInfo.Text = "Predefined comment descriptors can be set under Edit Libraries (Options menu)";
      this.lblCommDescInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cmbCDescriptor
      // 
      this.cmbCDescriptor.Autocomplete = true;
      this.cmbCDescriptor.ItemHeight = 13;
      this.cmbCDescriptor.Location = new System.Drawing.Point(136, 6);
      this.cmbCDescriptor.Name = "cmbCDescriptor";
      this.cmbCDescriptor.Size = new System.Drawing.Size(256, 21);
      this.cmbCDescriptor.TabIndex = 40;
      this.cmbCDescriptor.EnabledChanged += new System.EventHandler(this.Select_Enter);
      this.cmbCDescriptor.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // CheckBox38
      // 
      this.CheckBox38.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox38.Location = new System.Drawing.Point(400, 56);
      this.CheckBox38.Name = "CheckBox38";
      this.CheckBox38.Size = new System.Drawing.Size(16, 16);
      this.CheckBox38.TabIndex = 45;
      this.CheckBox38.Visible = false;
      // 
      // CheckBox10
      // 
      this.CheckBox10.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox10.Location = new System.Drawing.Point(424, 88);
      this.CheckBox10.Name = "CheckBox10";
      this.CheckBox10.Size = new System.Drawing.Size(224, 16);
      this.CheckBox10.TabIndex = 48;
      this.CheckBox10.Text = "Remove all existing comments first";
      // 
      // btnMoveComment
      // 
      this.btnMoveComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnMoveComment.Location = new System.Drawing.Point(424, 56);
      this.btnMoveComment.Name = "btnMoveComment";
      this.btnMoveComment.Size = new System.Drawing.Size(240, 20);
      this.btnMoveComment.TabIndex = 47;
      this.btnMoveComment.Text = "Move Comment to top";
      this.btnMoveComment.Click += new System.EventHandler(this.btnMoveComment_Click);
      // 
      // btnRemoveComment
      // 
      this.btnRemoveComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveComment.Location = new System.Drawing.Point(424, 32);
      this.btnRemoveComment.Name = "btnRemoveComment";
      this.btnRemoveComment.Size = new System.Drawing.Size(240, 20);
      this.btnRemoveComment.TabIndex = 46;
      this.btnRemoveComment.Text = "Remove Comment";
      this.btnRemoveComment.Click += new System.EventHandler(this.btnRemoveComment_Click);
      // 
      // btnAddComment
      // 
      this.btnAddComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddComment.Location = new System.Drawing.Point(424, 8);
      this.btnAddComment.Name = "btnAddComment";
      this.btnAddComment.Size = new System.Drawing.Size(240, 20);
      this.btnAddComment.TabIndex = 45;
      this.btnAddComment.Text = "Add Comment";
      this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
      // 
      // lblCOMM
      // 
      this.lblCOMM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCOMM.Location = new System.Drawing.Point(8, 56);
      this.lblCOMM.Name = "lblCOMM";
      this.lblCOMM.Size = new System.Drawing.Size(128, 16);
      this.lblCOMM.TabIndex = 43;
      this.lblCOMM.Text = "&Comment:";
      // 
      // lblCOMMLan
      // 
      this.lblCOMMLan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCOMMLan.Location = new System.Drawing.Point(8, 32);
      this.lblCOMMLan.Name = "lblCOMMLan";
      this.lblCOMMLan.Size = new System.Drawing.Size(128, 16);
      this.lblCOMMLan.TabIndex = 41;
      this.lblCOMMLan.Text = "Comment &Language:";
      // 
      // lblCOMMDesc
      // 
      this.lblCOMMDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCOMMDesc.Location = new System.Drawing.Point(8, 8);
      this.lblCOMMDesc.Name = "lblCOMMDesc";
      this.lblCOMMDesc.Size = new System.Drawing.Size(128, 16);
      this.lblCOMMDesc.TabIndex = 39;
      this.lblCOMMDesc.Text = "Comment &Descriptor:";
      // 
      // cmbCLanguage
      // 
      this.cmbCLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCLanguage.ItemHeight = 13;
      this.cmbCLanguage.Location = new System.Drawing.Point(136, 30);
      this.cmbCLanguage.Name = "cmbCLanguage";
      this.cmbCLanguage.Size = new System.Drawing.Size(256, 21);
      this.cmbCLanguage.TabIndex = 42;
      this.cmbCLanguage.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.cmbCLanguage.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbCLanguage.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtComment
      // 
      this.txtComment.AcceptsReturn = true;
      this.txtComment.Location = new System.Drawing.Point(136, 56);
      this.txtComment.Multiline = true;
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(256, 48);
      this.txtComment.TabIndex = 44;
      this.txtComment.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtComment.Enter += new System.EventHandler(this.Select_Enter);
      this.txtComment.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // CommentList
      // 
      this.CommentList.CheckBoxes = true;
      this.CommentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescriptor,
            this.colComment,
            this.colLanguage});
      this.CommentList.FullRowSelect = true;
      this.CommentList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.CommentList.Location = new System.Drawing.Point(136, 112);
      this.CommentList.MultiSelect = false;
      this.CommentList.Name = "CommentList";
      this.CommentList.Size = new System.Drawing.Size(528, 64);
      this.CommentList.TabIndex = 49;
      this.CommentList.UseCompatibleStateImageBehavior = false;
      this.CommentList.View = System.Windows.Forms.View.Details;
      this.CommentList.Click += new System.EventHandler(this.CommentList_Click);
      this.CommentList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // colDescriptor
      // 
      this.colDescriptor.Text = "Descriptor";
      this.colDescriptor.Width = 124;
      // 
      // colComment
      // 
      this.colComment.Text = "Comment";
      this.colComment.Width = 264;
      // 
      // colLanguage
      // 
      this.colLanguage.Text = "Language";
      this.colLanguage.Width = 95;
      // 
      // Panel1
      // 
      this.Panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel1.Controls.Add(this.txtPOS2);
      this.Panel1.Controls.Add(this.txtPOS1);
      this.Panel1.Controls.Add(this.txtTrack2);
      this.Panel1.Controls.Add(this.txtTrack1);
      this.Panel1.Controls.Add(this.txtYear);
      this.Panel1.Controls.Add(this.txtBPM);
      this.Panel1.Controls.Add(this.cmbArtist);
      this.Panel1.Controls.Add(this.CheckBox8);
      this.Panel1.Controls.Add(this.CheckBox7);
      this.Panel1.Controls.Add(this.CheckBox6);
      this.Panel1.Controls.Add(this.CheckBox4);
      this.Panel1.Controls.Add(this.CheckBox3);
      this.Panel1.Controls.Add(this.CheckBox2);
      this.Panel1.Controls.Add(this.CheckBox1);
      this.Panel1.Controls.Add(this.lblBPM);
      this.Panel1.Controls.Add(this.YearFormat);
      this.Panel1.Controls.Add(this.lblOf2);
      this.Panel1.Controls.Add(this.lblOf1);
      this.Panel1.Controls.Add(this.txtAlbum);
      this.Panel1.Controls.Add(this.txtTitle);
      this.Panel1.Controls.Add(this.lblTitle);
      this.Panel1.Controls.Add(this.lblAlbum);
      this.Panel1.Controls.Add(this.lblPosMedia);
      this.Panel1.Controls.Add(this.lblYear);
      this.Panel1.Controls.Add(this.lblTrack);
      this.Panel1.Controls.Add(this.lblArtist);
      this.Panel1.Location = new System.Drawing.Point(8, 8);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new System.Drawing.Size(672, 128);
      this.Panel1.TabIndex = 1;
      // 
      // txtPOS2
      // 
      this.txtPOS2.Location = new System.Drawing.Point(560, 102);
      this.txtPOS2.Mask = "00";
      this.txtPOS2.Name = "txtPOS2";
      this.txtPOS2.Size = new System.Drawing.Size(64, 20);
      this.txtPOS2.TabIndex = 26;
      this.txtPOS2.ValidatingType = typeof(int);
      this.txtPOS2.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtPOS2.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPOS2.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtPOS1
      // 
      this.txtPOS1.Location = new System.Drawing.Point(472, 102);
      this.txtPOS1.Mask = "00";
      this.txtPOS1.Name = "txtPOS1";
      this.txtPOS1.Size = new System.Drawing.Size(64, 20);
      this.txtPOS1.TabIndex = 25;
      this.txtPOS1.ValidatingType = typeof(int);
      this.txtPOS1.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtPOS1.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPOS1.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtTrack2
      // 
      this.txtTrack2.Location = new System.Drawing.Point(224, 102);
      this.txtTrack2.Mask = "00";
      this.txtTrack2.Name = "txtTrack2";
      this.txtTrack2.Size = new System.Drawing.Size(64, 20);
      this.txtTrack2.TabIndex = 23;
      this.txtTrack2.ValidatingType = typeof(int);
      this.txtTrack2.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtTrack2.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTrack2.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtTrack1
      // 
      this.txtTrack1.Location = new System.Drawing.Point(136, 102);
      this.txtTrack1.Mask = "00";
      this.txtTrack1.Name = "txtTrack1";
      this.txtTrack1.Size = new System.Drawing.Size(64, 20);
      this.txtTrack1.TabIndex = 22;
      this.txtTrack1.ValidatingType = typeof(int);
      this.txtTrack1.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtTrack1.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTrack1.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtYear
      // 
      this.txtYear.Location = new System.Drawing.Point(136, 78);
      this.txtYear.Mask = "####-##-##";
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(112, 20);
      this.txtYear.TabIndex = 14;
      this.txtYear.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtYear.Enter += new System.EventHandler(this.Select_Enter);
      this.txtYear.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtBPM
      // 
      this.txtBPM.Location = new System.Drawing.Point(472, 80);
      this.txtBPM.Mask = "000";
      this.txtBPM.Name = "txtBPM";
      this.txtBPM.Size = new System.Drawing.Size(152, 20);
      this.txtBPM.TabIndex = 19;
      this.txtBPM.ValidatingType = typeof(int);
      this.txtBPM.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtBPM.Enter += new System.EventHandler(this.Select_Enter);
      this.txtBPM.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // cmbArtist
      // 
      this.cmbArtist.Autocomplete = true;
      this.cmbArtist.ItemHeight = 13;
      this.cmbArtist.Location = new System.Drawing.Point(136, 6);
      this.cmbArtist.Name = "cmbArtist";
      this.cmbArtist.Size = new System.Drawing.Size(488, 21);
      this.cmbArtist.TabIndex = 5;
      this.cmbArtist.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.cmbArtist.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbArtist.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // CheckBox8
      // 
      this.CheckBox8.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox8.Location = new System.Drawing.Point(632, 80);
      this.CheckBox8.Name = "CheckBox8";
      this.CheckBox8.Size = new System.Drawing.Size(16, 16);
      this.CheckBox8.TabIndex = 20;
      // 
      // CheckBox7
      // 
      this.CheckBox7.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox7.Location = new System.Drawing.Point(632, 104);
      this.CheckBox7.Name = "CheckBox7";
      this.CheckBox7.Size = new System.Drawing.Size(16, 16);
      this.CheckBox7.TabIndex = 28;
      // 
      // CheckBox6
      // 
      this.CheckBox6.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox6.Location = new System.Drawing.Point(304, 104);
      this.CheckBox6.Name = "CheckBox6";
      this.CheckBox6.Size = new System.Drawing.Size(16, 16);
      this.CheckBox6.TabIndex = 24;
      // 
      // CheckBox4
      // 
      this.CheckBox4.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox4.Location = new System.Drawing.Point(304, 80);
      this.CheckBox4.Name = "CheckBox4";
      this.CheckBox4.Size = new System.Drawing.Size(16, 16);
      this.CheckBox4.TabIndex = 17;
      // 
      // CheckBox3
      // 
      this.CheckBox3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox3.Location = new System.Drawing.Point(632, 56);
      this.CheckBox3.Name = "CheckBox3";
      this.CheckBox3.Size = new System.Drawing.Size(16, 16);
      this.CheckBox3.TabIndex = 12;
      // 
      // CheckBox2
      // 
      this.CheckBox2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox2.Location = new System.Drawing.Point(632, 32);
      this.CheckBox2.Name = "CheckBox2";
      this.CheckBox2.Size = new System.Drawing.Size(16, 16);
      this.CheckBox2.TabIndex = 9;
      // 
      // CheckBox1
      // 
      this.CheckBox1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox1.Location = new System.Drawing.Point(632, 8);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new System.Drawing.Size(16, 16);
      this.CheckBox1.TabIndex = 6;
      // 
      // lblBPM
      // 
      this.lblBPM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblBPM.Location = new System.Drawing.Point(352, 80);
      this.lblBPM.Name = "lblBPM";
      this.lblBPM.Size = new System.Drawing.Size(104, 16);
      this.lblBPM.TabIndex = 18;
      this.lblBPM.Text = "BP&M:";
      // 
      // YearFormat
      // 
      this.YearFormat.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.YearFormat.LargeChange = 1;
      this.YearFormat.Location = new System.Drawing.Point(256, 80);
      this.YearFormat.Maximum = 2;
      this.YearFormat.Name = "YearFormat";
      this.YearFormat.Size = new System.Drawing.Size(32, 16);
      this.YearFormat.TabIndex = 15;
      this.YearFormat.Scroll += new System.Windows.Forms.ScrollEventHandler(this.YearFormat_Scroll);
      // 
      // lblOf2
      // 
      this.lblOf2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOf2.Location = new System.Drawing.Point(544, 104);
      this.lblOf2.Name = "lblOf2";
      this.lblOf2.Size = new System.Drawing.Size(16, 16);
      this.lblOf2.TabIndex = 21;
      this.lblOf2.Text = "/";
      // 
      // lblOf1
      // 
      this.lblOf1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOf1.Location = new System.Drawing.Point(208, 104);
      this.lblOf1.Name = "lblOf1";
      this.lblOf1.Size = new System.Drawing.Size(16, 16);
      this.lblOf1.TabIndex = 16;
      this.lblOf1.Text = "/";
      // 
      // txtAlbum
      // 
      this.txtAlbum.Location = new System.Drawing.Point(136, 54);
      this.txtAlbum.Name = "txtAlbum";
      this.txtAlbum.Size = new System.Drawing.Size(488, 20);
      this.txtAlbum.TabIndex = 11;
      this.txtAlbum.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtAlbum.Enter += new System.EventHandler(this.Select_Enter);
      this.txtAlbum.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtTitle
      // 
      this.txtTitle.Location = new System.Drawing.Point(136, 30);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new System.Drawing.Size(488, 20);
      this.txtTitle.TabIndex = 8;
      this.txtTitle.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtTitle.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTitle.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblTitle
      // 
      this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitle.Location = new System.Drawing.Point(8, 32);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(128, 16);
      this.lblTitle.TabIndex = 7;
      this.lblTitle.Text = "&Title:";
      // 
      // lblAlbum
      // 
      this.lblAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAlbum.Location = new System.Drawing.Point(8, 56);
      this.lblAlbum.Name = "lblAlbum";
      this.lblAlbum.Size = new System.Drawing.Size(128, 16);
      this.lblAlbum.TabIndex = 10;
      this.lblAlbum.Text = "Al&bum:";
      // 
      // lblPosMedia
      // 
      this.lblPosMedia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPosMedia.Location = new System.Drawing.Point(352, 104);
      this.lblPosMedia.Name = "lblPosMedia";
      this.lblPosMedia.Size = new System.Drawing.Size(120, 16);
      this.lblPosMedia.TabIndex = 25;
      this.lblPosMedia.Text = "Position in media &set:";
      // 
      // lblYear
      // 
      this.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblYear.Location = new System.Drawing.Point(8, 80);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new System.Drawing.Size(128, 16);
      this.lblYear.TabIndex = 13;
      this.lblYear.Text = "&Year (date) of recording:";
      // 
      // lblTrack
      // 
      this.lblTrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTrack.Location = new System.Drawing.Point(8, 104);
      this.lblTrack.Name = "lblTrack";
      this.lblTrack.Size = new System.Drawing.Size(128, 16);
      this.lblTrack.TabIndex = 21;
      this.lblTrack.Text = "Trac&k number:";
      // 
      // lblArtist
      // 
      this.lblArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblArtist.Location = new System.Drawing.Point(8, 8);
      this.lblArtist.Name = "lblArtist";
      this.lblArtist.Size = new System.Drawing.Size(128, 16);
      this.lblArtist.TabIndex = 4;
      this.lblArtist.Text = "Lead &Artist:";
      // 
      // Panel2
      // 
      this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel2.Controls.Add(this.cmbGenre);
      this.Panel2.Controls.Add(this.lblGenreInfo);
      this.Panel2.Controls.Add(this.CheckBox9);
      this.Panel2.Controls.Add(this.btnMoveGenre);
      this.Panel2.Controls.Add(this.btnRemoveGenre);
      this.Panel2.Controls.Add(this.btnAddGenre);
      this.Panel2.Controls.Add(this.lblGenre);
      this.Panel2.Controls.Add(this.GenreList);
      this.Panel2.Location = new System.Drawing.Point(8, 144);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new System.Drawing.Size(672, 112);
      this.Panel2.TabIndex = 2;
      // 
      // cmbGenre
      // 
      this.cmbGenre.Autocomplete = true;
      this.cmbGenre.ItemHeight = 13;
      this.cmbGenre.Location = new System.Drawing.Point(136, 6);
      this.cmbGenre.Name = "cmbGenre";
      this.cmbGenre.Size = new System.Drawing.Size(256, 21);
      this.cmbGenre.TabIndex = 33;
      this.cmbGenre.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.cmbGenre.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbGenre.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblGenreInfo
      // 
      this.lblGenreInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblGenreInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblGenreInfo.Location = new System.Drawing.Point(400, 64);
      this.lblGenreInfo.Name = "lblGenreInfo";
      this.lblGenreInfo.Size = new System.Drawing.Size(264, 40);
      this.lblGenreInfo.TabIndex = 34;
      this.lblGenreInfo.Text = "Note: Many programs only show the first genre entered. So move the important genr" +
    "e to the top of the list.";
      // 
      // CheckBox9
      // 
      this.CheckBox9.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox9.Location = new System.Drawing.Point(376, 32);
      this.CheckBox9.Name = "CheckBox9";
      this.CheckBox9.Size = new System.Drawing.Size(16, 16);
      this.CheckBox9.TabIndex = 38;
      // 
      // btnMoveGenre
      // 
      this.btnMoveGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnMoveGenre.Location = new System.Drawing.Point(400, 32);
      this.btnMoveGenre.Name = "btnMoveGenre";
      this.btnMoveGenre.Size = new System.Drawing.Size(128, 20);
      this.btnMoveGenre.TabIndex = 36;
      this.btnMoveGenre.Text = "Move Genre to top";
      this.btnMoveGenre.Click += new System.EventHandler(this.btnMoveGenre_Click);
      // 
      // btnRemoveGenre
      // 
      this.btnRemoveGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveGenre.Location = new System.Drawing.Point(536, 8);
      this.btnRemoveGenre.Name = "btnRemoveGenre";
      this.btnRemoveGenre.Size = new System.Drawing.Size(128, 20);
      this.btnRemoveGenre.TabIndex = 35;
      this.btnRemoveGenre.Text = "Remove Genre";
      this.btnRemoveGenre.Click += new System.EventHandler(this.btnRemoveGenre_Click);
      // 
      // btnAddGenre
      // 
      this.btnAddGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddGenre.Location = new System.Drawing.Point(400, 8);
      this.btnAddGenre.Name = "btnAddGenre";
      this.btnAddGenre.Size = new System.Drawing.Size(128, 20);
      this.btnAddGenre.TabIndex = 34;
      this.btnAddGenre.Text = "Add Genre";
      this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
      // 
      // lblGenre
      // 
      this.lblGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblGenre.Location = new System.Drawing.Point(8, 8);
      this.lblGenre.Name = "lblGenre";
      this.lblGenre.Size = new System.Drawing.Size(128, 16);
      this.lblGenre.TabIndex = 32;
      this.lblGenre.Text = "&Genre:";
      // 
      // GenreList
      // 
      this.GenreList.Location = new System.Drawing.Point(136, 32);
      this.GenreList.Name = "GenreList";
      this.GenreList.Size = new System.Drawing.Size(232, 69);
      this.GenreList.TabIndex = 37;
      this.GenreList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // panWeb
      // 
      this.panWeb.Controls.Add(this.Panel10);
      this.panWeb.Location = new System.Drawing.Point(168, 32);
      this.panWeb.Name = "panWeb";
      this.panWeb.Size = new System.Drawing.Size(688, 304);
      this.panWeb.TabIndex = 3;
      // 
      // Panel10
      // 
      this.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel10.Controls.Add(this.CheckBox32);
      this.Panel10.Controls.Add(this.CheckBox31);
      this.Panel10.Controls.Add(this.CheckBox30);
      this.Panel10.Controls.Add(this.CheckBox29);
      this.Panel10.Controls.Add(this.CheckBox28);
      this.Panel10.Controls.Add(this.CheckBox27);
      this.Panel10.Controls.Add(this.CheckBox26);
      this.Panel10.Controls.Add(this.CheckBox25);
      this.Panel10.Controls.Add(this.txtCOMMInfURL);
      this.Panel10.Controls.Add(this.lblCOMMInfURL);
      this.Panel10.Controls.Add(this.txtPubURL);
      this.Panel10.Controls.Add(this.lblPubURL);
      this.Panel10.Controls.Add(this.txtPayURL);
      this.Panel10.Controls.Add(this.lblPayURL);
      this.Panel10.Controls.Add(this.txtINetRadioURL);
      this.Panel10.Controls.Add(this.lblINetRadioURL);
      this.Panel10.Controls.Add(this.txtAudioSRCURL);
      this.Panel10.Controls.Add(this.lblAudioSRCURL);
      this.Panel10.Controls.Add(this.txtCopyInfURL);
      this.Panel10.Controls.Add(this.txtArtistURL);
      this.Panel10.Controls.Add(this.txtAudioFileURL);
      this.Panel10.Controls.Add(this.lblAudioFileURL);
      this.Panel10.Controls.Add(this.lblArtistURL);
      this.Panel10.Controls.Add(this.lblCopyInfURL);
      this.Panel10.Location = new System.Drawing.Point(8, 8);
      this.Panel10.Name = "Panel10";
      this.Panel10.Size = new System.Drawing.Size(672, 200);
      this.Panel10.TabIndex = 0;
      // 
      // CheckBox32
      // 
      this.CheckBox32.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox32.Location = new System.Drawing.Point(648, 176);
      this.CheckBox32.Name = "CheckBox32";
      this.CheckBox32.Size = new System.Drawing.Size(16, 16);
      this.CheckBox32.TabIndex = 25;
      // 
      // CheckBox31
      // 
      this.CheckBox31.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox31.Location = new System.Drawing.Point(648, 152);
      this.CheckBox31.Name = "CheckBox31";
      this.CheckBox31.Size = new System.Drawing.Size(16, 16);
      this.CheckBox31.TabIndex = 22;
      // 
      // CheckBox30
      // 
      this.CheckBox30.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox30.Location = new System.Drawing.Point(648, 128);
      this.CheckBox30.Name = "CheckBox30";
      this.CheckBox30.Size = new System.Drawing.Size(16, 16);
      this.CheckBox30.TabIndex = 19;
      // 
      // CheckBox29
      // 
      this.CheckBox29.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox29.Location = new System.Drawing.Point(648, 104);
      this.CheckBox29.Name = "CheckBox29";
      this.CheckBox29.Size = new System.Drawing.Size(16, 16);
      this.CheckBox29.TabIndex = 16;
      // 
      // CheckBox28
      // 
      this.CheckBox28.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox28.Location = new System.Drawing.Point(648, 80);
      this.CheckBox28.Name = "CheckBox28";
      this.CheckBox28.Size = new System.Drawing.Size(16, 16);
      this.CheckBox28.TabIndex = 13;
      // 
      // CheckBox27
      // 
      this.CheckBox27.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox27.Location = new System.Drawing.Point(648, 56);
      this.CheckBox27.Name = "CheckBox27";
      this.CheckBox27.Size = new System.Drawing.Size(16, 16);
      this.CheckBox27.TabIndex = 10;
      // 
      // CheckBox26
      // 
      this.CheckBox26.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox26.Location = new System.Drawing.Point(648, 32);
      this.CheckBox26.Name = "CheckBox26";
      this.CheckBox26.Size = new System.Drawing.Size(16, 16);
      this.CheckBox26.TabIndex = 7;
      // 
      // CheckBox25
      // 
      this.CheckBox25.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox25.Location = new System.Drawing.Point(648, 8);
      this.CheckBox25.Name = "CheckBox25";
      this.CheckBox25.Size = new System.Drawing.Size(16, 16);
      this.CheckBox25.TabIndex = 4;
      // 
      // txtCOMMInfURL
      // 
      this.txtCOMMInfURL.Location = new System.Drawing.Point(200, 174);
      this.txtCOMMInfURL.Name = "txtCOMMInfURL";
      this.txtCOMMInfURL.Size = new System.Drawing.Size(440, 20);
      this.txtCOMMInfURL.TabIndex = 24;
      this.txtCOMMInfURL.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtCOMMInfURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtCOMMInfURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblCOMMInfURL
      // 
      this.lblCOMMInfURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCOMMInfURL.Location = new System.Drawing.Point(8, 176);
      this.lblCOMMInfURL.Name = "lblCOMMInfURL";
      this.lblCOMMInfURL.Size = new System.Drawing.Size(184, 16);
      this.lblCOMMInfURL.TabIndex = 23;
      this.lblCOMMInfURL.Text = "Commercial information URL:";
      // 
      // txtPubURL
      // 
      this.txtPubURL.Location = new System.Drawing.Point(200, 150);
      this.txtPubURL.Name = "txtPubURL";
      this.txtPubURL.Size = new System.Drawing.Size(440, 20);
      this.txtPubURL.TabIndex = 21;
      this.txtPubURL.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtPubURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPubURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblPubURL
      // 
      this.lblPubURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPubURL.Location = new System.Drawing.Point(8, 152);
      this.lblPubURL.Name = "lblPubURL";
      this.lblPubURL.Size = new System.Drawing.Size(184, 16);
      this.lblPubURL.TabIndex = 20;
      this.lblPubURL.Text = "Offical publisher URL:";
      // 
      // txtPayURL
      // 
      this.txtPayURL.Location = new System.Drawing.Point(200, 126);
      this.txtPayURL.Name = "txtPayURL";
      this.txtPayURL.Size = new System.Drawing.Size(440, 20);
      this.txtPayURL.TabIndex = 18;
      this.txtPayURL.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtPayURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPayURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblPayURL
      // 
      this.lblPayURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPayURL.Location = new System.Drawing.Point(8, 128);
      this.lblPayURL.Name = "lblPayURL";
      this.lblPayURL.Size = new System.Drawing.Size(184, 16);
      this.lblPayURL.TabIndex = 17;
      this.lblPayURL.Text = "Offical payment URL:";
      // 
      // txtINetRadioURL
      // 
      this.txtINetRadioURL.Location = new System.Drawing.Point(200, 102);
      this.txtINetRadioURL.Name = "txtINetRadioURL";
      this.txtINetRadioURL.Size = new System.Drawing.Size(440, 20);
      this.txtINetRadioURL.TabIndex = 15;
      this.txtINetRadioURL.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtINetRadioURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtINetRadioURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblINetRadioURL
      // 
      this.lblINetRadioURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblINetRadioURL.Location = new System.Drawing.Point(8, 104);
      this.lblINetRadioURL.Name = "lblINetRadioURL";
      this.lblINetRadioURL.Size = new System.Drawing.Size(184, 16);
      this.lblINetRadioURL.TabIndex = 14;
      this.lblINetRadioURL.Text = "Offical internet radio station URL:";
      // 
      // txtAudioSRCURL
      // 
      this.txtAudioSRCURL.Location = new System.Drawing.Point(200, 78);
      this.txtAudioSRCURL.Name = "txtAudioSRCURL";
      this.txtAudioSRCURL.Size = new System.Drawing.Size(440, 20);
      this.txtAudioSRCURL.TabIndex = 12;
      this.txtAudioSRCURL.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtAudioSRCURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtAudioSRCURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblAudioSRCURL
      // 
      this.lblAudioSRCURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAudioSRCURL.Location = new System.Drawing.Point(8, 80);
      this.lblAudioSRCURL.Name = "lblAudioSRCURL";
      this.lblAudioSRCURL.Size = new System.Drawing.Size(184, 16);
      this.lblAudioSRCURL.TabIndex = 11;
      this.lblAudioSRCURL.Text = "Offical audio source URL:";
      // 
      // txtCopyInfURL
      // 
      this.txtCopyInfURL.Location = new System.Drawing.Point(200, 6);
      this.txtCopyInfURL.Name = "txtCopyInfURL";
      this.txtCopyInfURL.Size = new System.Drawing.Size(440, 20);
      this.txtCopyInfURL.TabIndex = 3;
      this.txtCopyInfURL.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtCopyInfURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtCopyInfURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtArtistURL
      // 
      this.txtArtistURL.Location = new System.Drawing.Point(200, 54);
      this.txtArtistURL.Name = "txtArtistURL";
      this.txtArtistURL.Size = new System.Drawing.Size(440, 20);
      this.txtArtistURL.TabIndex = 9;
      this.txtArtistURL.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtArtistURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtArtistURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtAudioFileURL
      // 
      this.txtAudioFileURL.Location = new System.Drawing.Point(200, 30);
      this.txtAudioFileURL.Name = "txtAudioFileURL";
      this.txtAudioFileURL.Size = new System.Drawing.Size(440, 20);
      this.txtAudioFileURL.TabIndex = 6;
      this.txtAudioFileURL.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtAudioFileURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtAudioFileURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblAudioFileURL
      // 
      this.lblAudioFileURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAudioFileURL.Location = new System.Drawing.Point(8, 32);
      this.lblAudioFileURL.Name = "lblAudioFileURL";
      this.lblAudioFileURL.Size = new System.Drawing.Size(184, 16);
      this.lblAudioFileURL.TabIndex = 5;
      this.lblAudioFileURL.Text = "Offical audio file URL:";
      // 
      // lblArtistURL
      // 
      this.lblArtistURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblArtistURL.Location = new System.Drawing.Point(8, 56);
      this.lblArtistURL.Name = "lblArtistURL";
      this.lblArtistURL.Size = new System.Drawing.Size(184, 16);
      this.lblArtistURL.TabIndex = 8;
      this.lblArtistURL.Text = "Offical artist URL:";
      // 
      // lblCopyInfURL
      // 
      this.lblCopyInfURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCopyInfURL.Location = new System.Drawing.Point(8, 8);
      this.lblCopyInfURL.Name = "lblCopyInfURL";
      this.lblCopyInfURL.Size = new System.Drawing.Size(184, 16);
      this.lblCopyInfURL.TabIndex = 2;
      this.lblCopyInfURL.Text = "Copyright information URL:";
      // 
      // panRating
      // 
      this.panRating.Controls.Add(this.Panel11);
      this.panRating.Location = new System.Drawing.Point(168, 24);
      this.panRating.Name = "panRating";
      this.panRating.Size = new System.Drawing.Size(688, 448);
      this.panRating.TabIndex = 2;
      // 
      // Panel11
      // 
      this.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel11.Controls.Add(this.CheckBox33);
      this.Panel11.Controls.Add(this.lblInfo);
      this.Panel11.Controls.Add(this.btnMoveRating);
      this.Panel11.Controls.Add(this.btnRemoveRating);
      this.Panel11.Controls.Add(this.btnAddRating);
      this.Panel11.Controls.Add(this.RatingList);
      this.Panel11.Controls.Add(this.txtRatingCounter);
      this.Panel11.Controls.Add(this.txtRatingRating);
      this.Panel11.Controls.Add(this.txtRatingUser);
      this.Panel11.Controls.Add(this.lblRatingRating);
      this.Panel11.Controls.Add(this.lblRatingCounter);
      this.Panel11.Controls.Add(this.lblRatingUser);
      this.Panel11.Location = new System.Drawing.Point(8, 8);
      this.Panel11.Name = "Panel11";
      this.Panel11.Size = new System.Drawing.Size(672, 304);
      this.Panel11.TabIndex = 1;
      // 
      // CheckBox33
      // 
      this.CheckBox33.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox33.Location = new System.Drawing.Point(136, 232);
      this.CheckBox33.Name = "CheckBox33";
      this.CheckBox33.Size = new System.Drawing.Size(528, 16);
      this.CheckBox33.TabIndex = 35;
      this.CheckBox33.Text = "Remove all existing ratings first";
      // 
      // lblInfo
      // 
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(136, 256);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(528, 40);
      this.lblInfo.TabIndex = 43;
      this.lblInfo.Text = "The rating is 1-255 where 1 is worst and 255 is best. Note that many programs hav" +
    "e their own rating scale. The scale 1-255 is given by the ID3 standard and the o" +
    "ther programs rescale it.";
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnMoveRating
      // 
      this.btnMoveRating.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnMoveRating.Location = new System.Drawing.Point(488, 88);
      this.btnMoveRating.Name = "btnMoveRating";
      this.btnMoveRating.Size = new System.Drawing.Size(176, 24);
      this.btnMoveRating.TabIndex = 34;
      this.btnMoveRating.Text = "Move Rating to top";
      this.btnMoveRating.Click += new System.EventHandler(this.btnMoveRating_Click);
      // 
      // btnRemoveRating
      // 
      this.btnRemoveRating.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveRating.Location = new System.Drawing.Point(312, 88);
      this.btnRemoveRating.Name = "btnRemoveRating";
      this.btnRemoveRating.Size = new System.Drawing.Size(168, 24);
      this.btnRemoveRating.TabIndex = 33;
      this.btnRemoveRating.Text = "Remove Rating";
      this.btnRemoveRating.Click += new System.EventHandler(this.btnRemoveRating_Click);
      // 
      // btnAddRating
      // 
      this.btnAddRating.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddRating.Location = new System.Drawing.Point(136, 88);
      this.btnAddRating.Name = "btnAddRating";
      this.btnAddRating.Size = new System.Drawing.Size(168, 24);
      this.btnAddRating.TabIndex = 32;
      this.btnAddRating.Text = "Add Rating";
      this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
      // 
      // RatingList
      // 
      this.RatingList.CheckBoxes = true;
      this.RatingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10});
      this.RatingList.FullRowSelect = true;
      this.RatingList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.RatingList.Location = new System.Drawing.Point(136, 120);
      this.RatingList.MultiSelect = false;
      this.RatingList.Name = "RatingList";
      this.RatingList.Size = new System.Drawing.Size(528, 104);
      this.RatingList.TabIndex = 36;
      this.RatingList.UseCompatibleStateImageBehavior = false;
      this.RatingList.View = System.Windows.Forms.View.Details;
      this.RatingList.Click += new System.EventHandler(this.RatingList_Click);
      // 
      // ColumnHeader8
      // 
      this.ColumnHeader8.Text = "User";
      this.ColumnHeader8.Width = 289;
      // 
      // ColumnHeader9
      // 
      this.ColumnHeader9.Text = "Rating";
      this.ColumnHeader9.Width = 100;
      // 
      // ColumnHeader10
      // 
      this.ColumnHeader10.Text = "Play Counter";
      this.ColumnHeader10.Width = 80;
      // 
      // txtRatingCounter
      // 
      this.txtRatingCounter.Location = new System.Drawing.Point(136, 54);
      this.txtRatingCounter.Maximum = new decimal(new int[] {
            1000000,
            0,
            0,
            0});
      this.txtRatingCounter.Name = "txtRatingCounter";
      this.txtRatingCounter.Size = new System.Drawing.Size(80, 20);
      this.txtRatingCounter.TabIndex = 31;
      this.txtRatingCounter.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtRatingCounter.Enter += new System.EventHandler(this.Select_Enter);
      this.txtRatingCounter.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtRatingRating
      // 
      this.txtRatingRating.Location = new System.Drawing.Point(136, 30);
      this.txtRatingRating.Maximum = new decimal(new int[] {
            255,
            0,
            0,
            0});
      this.txtRatingRating.Name = "txtRatingRating";
      this.txtRatingRating.Size = new System.Drawing.Size(80, 20);
      this.txtRatingRating.TabIndex = 29;
      this.txtRatingRating.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtRatingRating.Enter += new System.EventHandler(this.Select_Enter);
      this.txtRatingRating.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtRatingUser
      // 
      this.txtRatingUser.Location = new System.Drawing.Point(136, 6);
      this.txtRatingUser.Name = "txtRatingUser";
      this.txtRatingUser.Size = new System.Drawing.Size(224, 20);
      this.txtRatingUser.TabIndex = 27;
      this.txtRatingUser.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtRatingUser.Enter += new System.EventHandler(this.Select_Enter);
      this.txtRatingUser.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblRatingRating
      // 
      this.lblRatingRating.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblRatingRating.Location = new System.Drawing.Point(8, 32);
      this.lblRatingRating.Name = "lblRatingRating";
      this.lblRatingRating.Size = new System.Drawing.Size(120, 16);
      this.lblRatingRating.TabIndex = 28;
      this.lblRatingRating.Text = "Rating:";
      // 
      // lblRatingCounter
      // 
      this.lblRatingCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblRatingCounter.Location = new System.Drawing.Point(8, 56);
      this.lblRatingCounter.Name = "lblRatingCounter";
      this.lblRatingCounter.Size = new System.Drawing.Size(120, 16);
      this.lblRatingCounter.TabIndex = 30;
      this.lblRatingCounter.Text = "Play counter:";
      // 
      // lblRatingUser
      // 
      this.lblRatingUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblRatingUser.Location = new System.Drawing.Point(8, 8);
      this.lblRatingUser.Name = "lblRatingUser";
      this.lblRatingUser.Size = new System.Drawing.Size(120, 16);
      this.lblRatingUser.TabIndex = 26;
      this.lblRatingUser.Text = "User (email):";
      // 
      // panInvolved
      // 
      this.panInvolved.Controls.Add(this.Panel15);
      this.panInvolved.Controls.Add(this.Panel16);
      this.panInvolved.Location = new System.Drawing.Point(168, 32);
      this.panInvolved.Name = "panInvolved";
      this.panInvolved.Size = new System.Drawing.Size(688, 408);
      this.panInvolved.TabIndex = 3;
      // 
      // Panel15
      // 
      this.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel15.Controls.Add(this.CheckBox45);
      this.Panel15.Controls.Add(this.lblMusicianInfo);
      this.Panel15.Controls.Add(this.txtMusicianName);
      this.Panel15.Controls.Add(this.btnRemoveMusician);
      this.Panel15.Controls.Add(this.btnAddMusician);
      this.Panel15.Controls.Add(this.lblMusicianName);
      this.Panel15.Controls.Add(this.lblMusicianInst);
      this.Panel15.Controls.Add(this.txtMusicianInst);
      this.Panel15.Controls.Add(this.TMCLList);
      this.Panel15.Location = new System.Drawing.Point(8, 160);
      this.Panel15.Name = "Panel15";
      this.Panel15.Size = new System.Drawing.Size(672, 144);
      this.Panel15.TabIndex = 2;
      // 
      // CheckBox45
      // 
      this.CheckBox45.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox45.Location = new System.Drawing.Point(648, 64);
      this.CheckBox45.Name = "CheckBox45";
      this.CheckBox45.Size = new System.Drawing.Size(16, 16);
      this.CheckBox45.TabIndex = 26;
      // 
      // lblMusicianInfo
      // 
      this.lblMusicianInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblMusicianInfo.Location = new System.Drawing.Point(8, 120);
      this.lblMusicianInfo.Name = "lblMusicianInfo";
      this.lblMusicianInfo.Size = new System.Drawing.Size(128, 16);
      this.lblMusicianInfo.TabIndex = 16;
      this.lblMusicianInfo.Text = "(TAG Ver. 2.4 only)";
      // 
      // txtMusicianName
      // 
      this.txtMusicianName.Location = new System.Drawing.Point(160, 30);
      this.txtMusicianName.Name = "txtMusicianName";
      this.txtMusicianName.Size = new System.Drawing.Size(344, 20);
      this.txtMusicianName.TabIndex = 22;
      this.txtMusicianName.Enter += new System.EventHandler(this.Select_Enter);
      this.txtMusicianName.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnRemoveMusician
      // 
      this.btnRemoveMusician.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveMusician.Location = new System.Drawing.Point(512, 32);
      this.btnRemoveMusician.Name = "btnRemoveMusician";
      this.btnRemoveMusician.Size = new System.Drawing.Size(152, 20);
      this.btnRemoveMusician.TabIndex = 24;
      this.btnRemoveMusician.Text = "Remove musician";
      this.btnRemoveMusician.Click += new System.EventHandler(this.btnRemoveMusican_Click);
      // 
      // btnAddMusician
      // 
      this.btnAddMusician.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddMusician.Location = new System.Drawing.Point(512, 8);
      this.btnAddMusician.Name = "btnAddMusician";
      this.btnAddMusician.Size = new System.Drawing.Size(152, 20);
      this.btnAddMusician.TabIndex = 23;
      this.btnAddMusician.Text = "Add musician";
      this.btnAddMusician.Click += new System.EventHandler(this.btnAddMusican_Click);
      // 
      // lblMusicianName
      // 
      this.lblMusicianName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblMusicianName.Location = new System.Drawing.Point(8, 32);
      this.lblMusicianName.Name = "lblMusicianName";
      this.lblMusicianName.Size = new System.Drawing.Size(128, 16);
      this.lblMusicianName.TabIndex = 21;
      this.lblMusicianName.Text = "Musician name:";
      // 
      // lblMusicianInst
      // 
      this.lblMusicianInst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblMusicianInst.Location = new System.Drawing.Point(8, 8);
      this.lblMusicianInst.Name = "lblMusicianInst";
      this.lblMusicianInst.Size = new System.Drawing.Size(128, 16);
      this.lblMusicianInst.TabIndex = 19;
      this.lblMusicianInst.Text = "Musician instrument:";
      // 
      // txtMusicianInst
      // 
      this.txtMusicianInst.Location = new System.Drawing.Point(160, 6);
      this.txtMusicianInst.Name = "txtMusicianInst";
      this.txtMusicianInst.Size = new System.Drawing.Size(344, 20);
      this.txtMusicianInst.TabIndex = 20;
      this.txtMusicianInst.Enter += new System.EventHandler(this.Select_Enter);
      this.txtMusicianInst.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // TMCLList
      // 
      this.TMCLList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader15,
            this.ColumnHeader16});
      this.TMCLList.FullRowSelect = true;
      this.TMCLList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.TMCLList.Location = new System.Drawing.Point(160, 64);
      this.TMCLList.MultiSelect = false;
      this.TMCLList.Name = "TMCLList";
      this.TMCLList.Size = new System.Drawing.Size(480, 72);
      this.TMCLList.TabIndex = 25;
      this.TMCLList.UseCompatibleStateImageBehavior = false;
      this.TMCLList.View = System.Windows.Forms.View.Details;
      this.TMCLList.Click += new System.EventHandler(this.TMCLList_Click);
      // 
      // ColumnHeader15
      // 
      this.ColumnHeader15.Text = "Instrument";
      this.ColumnHeader15.Width = 200;
      // 
      // ColumnHeader16
      // 
      this.ColumnHeader16.Text = "Name";
      this.ColumnHeader16.Width = 247;
      // 
      // Panel16
      // 
      this.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel16.Controls.Add(this.CheckBox44);
      this.Panel16.Controls.Add(this.txtInvPerson);
      this.Panel16.Controls.Add(this.btnRemoveInv);
      this.Panel16.Controls.Add(this.btnAddInv);
      this.Panel16.Controls.Add(this.lblInvPerson);
      this.Panel16.Controls.Add(this.lblInvFunction);
      this.Panel16.Controls.Add(this.txtInvFunction);
      this.Panel16.Controls.Add(this.TIPLList);
      this.Panel16.Location = new System.Drawing.Point(8, 8);
      this.Panel16.Name = "Panel16";
      this.Panel16.Size = new System.Drawing.Size(672, 144);
      this.Panel16.TabIndex = 1;
      // 
      // CheckBox44
      // 
      this.CheckBox44.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox44.Location = new System.Drawing.Point(648, 64);
      this.CheckBox44.Name = "CheckBox44";
      this.CheckBox44.Size = new System.Drawing.Size(16, 16);
      this.CheckBox44.TabIndex = 19;
      // 
      // txtInvPerson
      // 
      this.txtInvPerson.Location = new System.Drawing.Point(160, 30);
      this.txtInvPerson.Name = "txtInvPerson";
      this.txtInvPerson.Size = new System.Drawing.Size(344, 20);
      this.txtInvPerson.TabIndex = 15;
      this.txtInvPerson.Enter += new System.EventHandler(this.Select_Enter);
      this.txtInvPerson.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnRemoveInv
      // 
      this.btnRemoveInv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveInv.Location = new System.Drawing.Point(512, 32);
      this.btnRemoveInv.Name = "btnRemoveInv";
      this.btnRemoveInv.Size = new System.Drawing.Size(152, 20);
      this.btnRemoveInv.TabIndex = 17;
      this.btnRemoveInv.Text = "Remove involved person";
      this.btnRemoveInv.Click += new System.EventHandler(this.btnRemoveInv_Click);
      // 
      // btnAddInv
      // 
      this.btnAddInv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddInv.Location = new System.Drawing.Point(512, 8);
      this.btnAddInv.Name = "btnAddInv";
      this.btnAddInv.Size = new System.Drawing.Size(152, 20);
      this.btnAddInv.TabIndex = 16;
      this.btnAddInv.Text = "Add involved person";
      this.btnAddInv.Click += new System.EventHandler(this.btnAddInv_Click);
      // 
      // lblInvPerson
      // 
      this.lblInvPerson.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInvPerson.Location = new System.Drawing.Point(8, 32);
      this.lblInvPerson.Name = "lblInvPerson";
      this.lblInvPerson.Size = new System.Drawing.Size(144, 16);
      this.lblInvPerson.TabIndex = 14;
      this.lblInvPerson.Text = "Involved person name:";
      // 
      // lblInvFunction
      // 
      this.lblInvFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInvFunction.Location = new System.Drawing.Point(8, 8);
      this.lblInvFunction.Name = "lblInvFunction";
      this.lblInvFunction.Size = new System.Drawing.Size(144, 16);
      this.lblInvFunction.TabIndex = 12;
      this.lblInvFunction.Text = "Involved person function:";
      // 
      // txtInvFunction
      // 
      this.txtInvFunction.Location = new System.Drawing.Point(160, 6);
      this.txtInvFunction.Name = "txtInvFunction";
      this.txtInvFunction.Size = new System.Drawing.Size(344, 20);
      this.txtInvFunction.TabIndex = 13;
      this.txtInvFunction.Enter += new System.EventHandler(this.Select_Enter);
      this.txtInvFunction.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // TIPLList
      // 
      this.TIPLList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader17,
            this.ColumnHeader18});
      this.TIPLList.FullRowSelect = true;
      this.TIPLList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.TIPLList.Location = new System.Drawing.Point(160, 64);
      this.TIPLList.MultiSelect = false;
      this.TIPLList.Name = "TIPLList";
      this.TIPLList.Size = new System.Drawing.Size(480, 72);
      this.TIPLList.TabIndex = 18;
      this.TIPLList.UseCompatibleStateImageBehavior = false;
      this.TIPLList.View = System.Windows.Forms.View.Details;
      this.TIPLList.Click += new System.EventHandler(this.TIPLList_Click);
      // 
      // ColumnHeader17
      // 
      this.ColumnHeader17.Text = "Function";
      this.ColumnHeader17.Width = 176;
      // 
      // ColumnHeader18
      // 
      this.ColumnHeader18.Text = "Name";
      this.ColumnHeader18.Width = 272;
      // 
      // panPic
      // 
      this.panPic.Controls.Add(this.Panel7);
      this.panPic.Location = new System.Drawing.Point(168, 24);
      this.panPic.Name = "panPic";
      this.panPic.Size = new System.Drawing.Size(688, 328);
      this.panPic.TabIndex = 3;
      // 
      // Panel7
      // 
      this.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel7.Controls.Add(this.chkPicRelativPath);
      this.Panel7.Controls.Add(this.CheckBox34);
      this.Panel7.Controls.Add(this.btnRemovePicture);
      this.Panel7.Controls.Add(this.btnAddPicture);
      this.Panel7.Controls.Add(this.btnGetPic);
      this.Panel7.Controls.Add(this.chkPicInclude);
      this.Panel7.Controls.Add(this.lblPicPath);
      this.Panel7.Controls.Add(this.txtPicPath);
      this.Panel7.Controls.Add(this.PicList);
      this.Panel7.Controls.Add(this.lblPicType);
      this.Panel7.Controls.Add(this.lblPicDesc);
      this.Panel7.Controls.Add(this.cmbPicType);
      this.Panel7.Controls.Add(this.txtPDescriptor);
      this.Panel7.Controls.Add(this.APICView);
      this.Panel7.Location = new System.Drawing.Point(8, 8);
      this.Panel7.Name = "Panel7";
      this.Panel7.Size = new System.Drawing.Size(672, 304);
      this.Panel7.TabIndex = 0;
      // 
      // chkPicRelativPath
      // 
      this.chkPicRelativPath.Location = new System.Drawing.Point(8, 112);
      this.chkPicRelativPath.Name = "chkPicRelativPath";
      this.chkPicRelativPath.Size = new System.Drawing.Size(472, 16);
      this.chkPicRelativPath.TabIndex = 9;
      this.chkPicRelativPath.Text = "Use relativ path if picture is not included";
      this.chkPicRelativPath.CheckedChanged += new System.EventHandler(this.chkPicRelativPath_CheckedChanged);
      // 
      // CheckBox34
      // 
      this.CheckBox34.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox34.Location = new System.Drawing.Point(8, 280);
      this.CheckBox34.Name = "CheckBox34";
      this.CheckBox34.Size = new System.Drawing.Size(656, 16);
      this.CheckBox34.TabIndex = 14;
      this.CheckBox34.Text = "Remove all existing pictures first";
      // 
      // btnRemovePicture
      // 
      this.btnRemovePicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemovePicture.Location = new System.Drawing.Point(168, 160);
      this.btnRemovePicture.Name = "btnRemovePicture";
      this.btnRemovePicture.Size = new System.Drawing.Size(152, 24);
      this.btnRemovePicture.TabIndex = 11;
      this.btnRemovePicture.Text = "Remove Picture";
      this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
      // 
      // btnAddPicture
      // 
      this.btnAddPicture.Enabled = false;
      this.btnAddPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddPicture.Location = new System.Drawing.Point(8, 160);
      this.btnAddPicture.Name = "btnAddPicture";
      this.btnAddPicture.Size = new System.Drawing.Size(152, 24);
      this.btnAddPicture.TabIndex = 10;
      this.btnAddPicture.Text = "Add Picture";
      this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
      // 
      // btnGetPic
      // 
      this.btnGetPic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnGetPic.Location = new System.Drawing.Point(328, 160);
      this.btnGetPic.Name = "btnGetPic";
      this.btnGetPic.Size = new System.Drawing.Size(152, 24);
      this.btnGetPic.TabIndex = 12;
      this.btnGetPic.Text = "Get new picture";
      this.btnGetPic.Click += new System.EventHandler(this.btnGetPic_Click);
      // 
      // chkPicInclude
      // 
      this.chkPicInclude.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkPicInclude.Location = new System.Drawing.Point(8, 88);
      this.chkPicInclude.Name = "chkPicInclude";
      this.chkPicInclude.Size = new System.Drawing.Size(472, 16);
      this.chkPicInclude.TabIndex = 8;
      this.chkPicInclude.Text = "Include picture within the MP3 file when saving";
      this.chkPicInclude.CheckedChanged += new System.EventHandler(this.chkPicInclude_CheckedChanged);
      // 
      // lblPicPath
      // 
      this.lblPicPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPicPath.Location = new System.Drawing.Point(8, 56);
      this.lblPicPath.Name = "lblPicPath";
      this.lblPicPath.Size = new System.Drawing.Size(136, 16);
      this.lblPicPath.TabIndex = 6;
      this.lblPicPath.Text = "P&ath containing pic. data:";
      // 
      // txtPicPath
      // 
      this.txtPicPath.Location = new System.Drawing.Point(152, 54);
      this.txtPicPath.Name = "txtPicPath";
      this.txtPicPath.ReadOnly = true;
      this.txtPicPath.Size = new System.Drawing.Size(328, 20);
      this.txtPicPath.TabIndex = 7;
      this.txtPicPath.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtPicPath.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPicPath.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // PicList
      // 
      this.PicList.CheckBoxes = true;
      this.PicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7});
      this.PicList.FullRowSelect = true;
      this.PicList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.PicList.Location = new System.Drawing.Point(8, 192);
      this.PicList.MultiSelect = false;
      this.PicList.Name = "PicList";
      this.PicList.Size = new System.Drawing.Size(656, 80);
      this.PicList.TabIndex = 13;
      this.PicList.UseCompatibleStateImageBehavior = false;
      this.PicList.View = System.Windows.Forms.View.Details;
      this.PicList.Click += new System.EventHandler(this.PicList_Click);
      this.PicList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // ColumnHeader4
      // 
      this.ColumnHeader4.Text = "Descriptor";
      this.ColumnHeader4.Width = 160;
      // 
      // ColumnHeader5
      // 
      this.ColumnHeader5.Text = "Picture Type";
      this.ColumnHeader5.Width = 80;
      // 
      // ColumnHeader6
      // 
      this.ColumnHeader6.Text = "Path";
      this.ColumnHeader6.Width = 160;
      // 
      // ColumnHeader7
      // 
      this.ColumnHeader7.Text = "Include";
      // 
      // lblPicType
      // 
      this.lblPicType.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPicType.Location = new System.Drawing.Point(8, 32);
      this.lblPicType.Name = "lblPicType";
      this.lblPicType.Size = new System.Drawing.Size(136, 16);
      this.lblPicType.TabIndex = 4;
      this.lblPicType.Text = "Picture &Type:";
      // 
      // lblPicDesc
      // 
      this.lblPicDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPicDesc.Location = new System.Drawing.Point(8, 8);
      this.lblPicDesc.Name = "lblPicDesc";
      this.lblPicDesc.Size = new System.Drawing.Size(136, 16);
      this.lblPicDesc.TabIndex = 2;
      this.lblPicDesc.Text = "&Picture Descriptor:";
      // 
      // cmbPicType
      // 
      this.cmbPicType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbPicType.ItemHeight = 13;
      this.cmbPicType.Items.AddRange(new object[] {
            "00 - Other",
            "01 - 32x32 pixels \'file icon\' (PNG only)",
            "02 - Other file icon",
            "03 - Cover (front)",
            "04 - Cover (back)",
            "05 - Leaflet page",
            "06 - Media (e.g. label side of CD)",
            "07 - Lead artist/lead performer/soloist",
            "08 - Artist/performer",
            "09 - Conductor",
            "10 - Band/Orchestra",
            "11 - Composer",
            "12 - Lyricist/text writer",
            "13 - Recording Location",
            "14 - During recording",
            "15 - During performance",
            "16 - Movie/video screen capture",
            "17 - A bright coloured fish",
            "18 - Illustration",
            "19 - Band/artist logotype",
            "20 - Publisher/Studio logotype"});
      this.cmbPicType.Location = new System.Drawing.Point(152, 30);
      this.cmbPicType.Name = "cmbPicType";
      this.cmbPicType.Size = new System.Drawing.Size(328, 21);
      this.cmbPicType.TabIndex = 5;
      this.cmbPicType.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.cmbPicType.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbPicType.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtPDescriptor
      // 
      this.txtPDescriptor.Location = new System.Drawing.Point(152, 6);
      this.txtPDescriptor.Name = "txtPDescriptor";
      this.txtPDescriptor.Size = new System.Drawing.Size(328, 20);
      this.txtPDescriptor.TabIndex = 3;
      this.txtPDescriptor.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtPDescriptor.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPDescriptor.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // APICView
      // 
      this.APICView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.APICView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.APICView.Location = new System.Drawing.Point(488, 8);
      this.APICView.Name = "APICView";
      this.APICView.Size = new System.Drawing.Size(176, 176);
      this.APICView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.APICView.TabIndex = 1;
      this.APICView.TabStop = false;
      // 
      // panLyrics
      // 
      this.panLyrics.Controls.Add(this.Panel8);
      this.panLyrics.Location = new System.Drawing.Point(168, 24);
      this.panLyrics.Name = "panLyrics";
      this.panLyrics.Size = new System.Drawing.Size(688, 456);
      this.panLyrics.TabIndex = 2;
      // 
      // Panel8
      // 
      this.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel8.Controls.Add(this.txtLyrics);
      this.Panel8.Controls.Add(this.btnLyricsFile);
      this.Panel8.Controls.Add(this.CheckBox35);
      this.Panel8.Controls.Add(this.btnMoveLyrics);
      this.Panel8.Controls.Add(this.btnRemoveLyrics);
      this.Panel8.Controls.Add(this.btnAddLyrics);
      this.Panel8.Controls.Add(this.lblLyrics);
      this.Panel8.Controls.Add(this.lblLyLan);
      this.Panel8.Controls.Add(this.lblLyDesc);
      this.Panel8.Controls.Add(this.cmbLLanguage);
      this.Panel8.Controls.Add(this.txtLDescriptor);
      this.Panel8.Controls.Add(this.LyricsList);
      this.Panel8.Location = new System.Drawing.Point(8, 8);
      this.Panel8.Name = "Panel8";
      this.Panel8.Size = new System.Drawing.Size(672, 440);
      this.Panel8.TabIndex = 1;
      // 
      // txtLyrics
      // 
      this.txtLyrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtLyrics.Location = new System.Drawing.Point(136, 56);
      this.txtLyrics.Name = "txtLyrics";
      this.txtLyrics.Size = new System.Drawing.Size(528, 184);
      this.txtLyrics.TabIndex = 17;
      this.txtLyrics.Text = "";
      // 
      // btnLyricsFile
      // 
      this.btnLyricsFile.Location = new System.Drawing.Point(136, 248);
      this.btnLyricsFile.Name = "btnLyricsFile";
      this.btnLyricsFile.Size = new System.Drawing.Size(528, 24);
      this.btnLyricsFile.TabIndex = 18;
      this.btnLyricsFile.Text = "Get lyrics from text file";
      this.btnLyricsFile.Click += new System.EventHandler(this.btnLyricsFile_Click);
      // 
      // CheckBox35
      // 
      this.CheckBox35.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox35.Location = new System.Drawing.Point(8, 416);
      this.CheckBox35.Name = "CheckBox35";
      this.CheckBox35.Size = new System.Drawing.Size(656, 16);
      this.CheckBox35.TabIndex = 23;
      this.CheckBox35.Text = "Remove all existing lyrics first";
      // 
      // btnMoveLyrics
      // 
      this.btnMoveLyrics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnMoveLyrics.Location = new System.Drawing.Point(496, 280);
      this.btnMoveLyrics.Name = "btnMoveLyrics";
      this.btnMoveLyrics.Size = new System.Drawing.Size(168, 24);
      this.btnMoveLyrics.TabIndex = 21;
      this.btnMoveLyrics.Text = "Move Lyrics to top";
      this.btnMoveLyrics.Click += new System.EventHandler(this.btnMoveLyrics_Click);
      // 
      // btnRemoveLyrics
      // 
      this.btnRemoveLyrics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveLyrics.Location = new System.Drawing.Point(312, 280);
      this.btnRemoveLyrics.Name = "btnRemoveLyrics";
      this.btnRemoveLyrics.Size = new System.Drawing.Size(176, 24);
      this.btnRemoveLyrics.TabIndex = 20;
      this.btnRemoveLyrics.Text = "Remove Lyrics";
      this.btnRemoveLyrics.Click += new System.EventHandler(this.btnRemoveLyrics_Click);
      // 
      // btnAddLyrics
      // 
      this.btnAddLyrics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddLyrics.Location = new System.Drawing.Point(136, 280);
      this.btnAddLyrics.Name = "btnAddLyrics";
      this.btnAddLyrics.Size = new System.Drawing.Size(168, 24);
      this.btnAddLyrics.TabIndex = 19;
      this.btnAddLyrics.Text = "Add Lyrics";
      this.btnAddLyrics.Click += new System.EventHandler(this.btnAddLyrics_Click);
      // 
      // lblLyrics
      // 
      this.lblLyrics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLyrics.Location = new System.Drawing.Point(8, 56);
      this.lblLyrics.Name = "lblLyrics";
      this.lblLyrics.Size = new System.Drawing.Size(128, 16);
      this.lblLyrics.TabIndex = 16;
      this.lblLyrics.Text = "&Lyrics Text:";
      // 
      // lblLyLan
      // 
      this.lblLyLan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLyLan.Location = new System.Drawing.Point(8, 32);
      this.lblLyLan.Name = "lblLyLan";
      this.lblLyLan.Size = new System.Drawing.Size(128, 16);
      this.lblLyLan.TabIndex = 14;
      this.lblLyLan.Text = "Lyrics &Language:";
      // 
      // lblLyDesc
      // 
      this.lblLyDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLyDesc.Location = new System.Drawing.Point(8, 8);
      this.lblLyDesc.Name = "lblLyDesc";
      this.lblLyDesc.Size = new System.Drawing.Size(128, 16);
      this.lblLyDesc.TabIndex = 12;
      this.lblLyDesc.Text = "Lyrics &Descriptor:";
      // 
      // cmbLLanguage
      // 
      this.cmbLLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbLLanguage.ItemHeight = 13;
      this.cmbLLanguage.Location = new System.Drawing.Point(136, 30);
      this.cmbLLanguage.Name = "cmbLLanguage";
      this.cmbLLanguage.Size = new System.Drawing.Size(208, 21);
      this.cmbLLanguage.TabIndex = 15;
      this.cmbLLanguage.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.cmbLLanguage.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbLLanguage.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtLDescriptor
      // 
      this.txtLDescriptor.Location = new System.Drawing.Point(136, 6);
      this.txtLDescriptor.Name = "txtLDescriptor";
      this.txtLDescriptor.Size = new System.Drawing.Size(208, 20);
      this.txtLDescriptor.TabIndex = 13;
      this.txtLDescriptor.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtLDescriptor.Enter += new System.EventHandler(this.Select_Enter);
      this.txtLDescriptor.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // LyricsList
      // 
      this.LyricsList.CheckBoxes = true;
      this.LyricsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
      this.LyricsList.FullRowSelect = true;
      this.LyricsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.LyricsList.Location = new System.Drawing.Point(8, 312);
      this.LyricsList.MultiSelect = false;
      this.LyricsList.Name = "LyricsList";
      this.LyricsList.Size = new System.Drawing.Size(656, 96);
      this.LyricsList.TabIndex = 22;
      this.LyricsList.UseCompatibleStateImageBehavior = false;
      this.LyricsList.View = System.Windows.Forms.View.Details;
      this.LyricsList.Click += new System.EventHandler(this.LyricsList_Click);
      this.LyricsList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // ColumnHeader1
      // 
      this.ColumnHeader1.Text = "Descriptor";
      this.ColumnHeader1.Width = 139;
      // 
      // ColumnHeader2
      // 
      this.ColumnHeader2.Text = "Text";
      this.ColumnHeader2.Width = 386;
      // 
      // ColumnHeader3
      // 
      this.ColumnHeader3.Text = "Language";
      this.ColumnHeader3.Width = 88;
      // 
      // panUser
      // 
      this.panUser.Controls.Add(this.Panel12);
      this.panUser.Controls.Add(this.Panel13);
      this.panUser.Location = new System.Drawing.Point(168, 24);
      this.panUser.Name = "panUser";
      this.panUser.Size = new System.Drawing.Size(688, 456);
      this.panUser.TabIndex = 2;
      // 
      // Panel12
      // 
      this.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel12.Controls.Add(this.CheckBox36);
      this.Panel12.Controls.Add(this.txtTXXXContent);
      this.Panel12.Controls.Add(this.btnRemoveTXXX);
      this.Panel12.Controls.Add(this.btnAddTXXX);
      this.Panel12.Controls.Add(this.lblTXXXContent);
      this.Panel12.Controls.Add(this.lblTXXXDesc);
      this.Panel12.Controls.Add(this.txtTXXXDesc);
      this.Panel12.Controls.Add(this.TXXXList);
      this.Panel12.Location = new System.Drawing.Point(8, 8);
      this.Panel12.Name = "Panel12";
      this.Panel12.Size = new System.Drawing.Size(672, 216);
      this.Panel12.TabIndex = 0;
      // 
      // CheckBox36
      // 
      this.CheckBox36.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox36.Location = new System.Drawing.Point(136, 192);
      this.CheckBox36.Name = "CheckBox36";
      this.CheckBox36.Size = new System.Drawing.Size(520, 16);
      this.CheckBox36.TabIndex = 9;
      this.CheckBox36.Text = "Remove all existing user text frames first";
      // 
      // txtTXXXContent
      // 
      this.txtTXXXContent.Location = new System.Drawing.Point(136, 30);
      this.txtTXXXContent.Name = "txtTXXXContent";
      this.txtTXXXContent.Size = new System.Drawing.Size(368, 20);
      this.txtTXXXContent.TabIndex = 5;
      this.txtTXXXContent.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtTXXXContent.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTXXXContent.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnRemoveTXXX
      // 
      this.btnRemoveTXXX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveTXXX.Location = new System.Drawing.Point(512, 30);
      this.btnRemoveTXXX.Name = "btnRemoveTXXX";
      this.btnRemoveTXXX.Size = new System.Drawing.Size(152, 20);
      this.btnRemoveTXXX.TabIndex = 7;
      this.btnRemoveTXXX.Text = "Remove user text frame";
      this.btnRemoveTXXX.Click += new System.EventHandler(this.btnRemoveTXXX_Click);
      // 
      // btnAddTXXX
      // 
      this.btnAddTXXX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddTXXX.Location = new System.Drawing.Point(512, 6);
      this.btnAddTXXX.Name = "btnAddTXXX";
      this.btnAddTXXX.Size = new System.Drawing.Size(152, 20);
      this.btnAddTXXX.TabIndex = 6;
      this.btnAddTXXX.Text = "Add user text frame";
      this.btnAddTXXX.Click += new System.EventHandler(this.btnAddTXXX_Click);
      // 
      // lblTXXXContent
      // 
      this.lblTXXXContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTXXXContent.Location = new System.Drawing.Point(8, 32);
      this.lblTXXXContent.Name = "lblTXXXContent";
      this.lblTXXXContent.Size = new System.Drawing.Size(128, 16);
      this.lblTXXXContent.TabIndex = 4;
      this.lblTXXXContent.Text = "Text frame &Content:";
      // 
      // lblTXXXDesc
      // 
      this.lblTXXXDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTXXXDesc.Location = new System.Drawing.Point(8, 8);
      this.lblTXXXDesc.Name = "lblTXXXDesc";
      this.lblTXXXDesc.Size = new System.Drawing.Size(128, 16);
      this.lblTXXXDesc.TabIndex = 2;
      this.lblTXXXDesc.Text = "Text frame &Descriptor:";
      // 
      // txtTXXXDesc
      // 
      this.txtTXXXDesc.Location = new System.Drawing.Point(136, 6);
      this.txtTXXXDesc.Name = "txtTXXXDesc";
      this.txtTXXXDesc.Size = new System.Drawing.Size(368, 20);
      this.txtTXXXDesc.TabIndex = 3;
      this.txtTXXXDesc.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtTXXXDesc.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTXXXDesc.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // TXXXList
      // 
      this.TXXXList.CheckBoxes = true;
      this.TXXXList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader11,
            this.ColumnHeader12});
      this.TXXXList.FullRowSelect = true;
      this.TXXXList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.TXXXList.Location = new System.Drawing.Point(136, 56);
      this.TXXXList.MultiSelect = false;
      this.TXXXList.Name = "TXXXList";
      this.TXXXList.Size = new System.Drawing.Size(528, 128);
      this.TXXXList.TabIndex = 8;
      this.TXXXList.UseCompatibleStateImageBehavior = false;
      this.TXXXList.View = System.Windows.Forms.View.Details;
      this.TXXXList.Click += new System.EventHandler(this.TXXXList_Click);
      this.TXXXList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // ColumnHeader11
      // 
      this.ColumnHeader11.Text = "Descriptor";
      this.ColumnHeader11.Width = 180;
      // 
      // ColumnHeader12
      // 
      this.ColumnHeader12.Text = "Content";
      this.ColumnHeader12.Width = 321;
      // 
      // Panel13
      // 
      this.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel13.Controls.Add(this.CheckBox37);
      this.Panel13.Controls.Add(this.txtWXXXContent);
      this.Panel13.Controls.Add(this.btnRemoveWXXX);
      this.Panel13.Controls.Add(this.btnAddWXXX);
      this.Panel13.Controls.Add(this.lblWXXXContent);
      this.Panel13.Controls.Add(this.lblWXXXDesc);
      this.Panel13.Controls.Add(this.txtWXXXDesc);
      this.Panel13.Controls.Add(this.WXXXList);
      this.Panel13.Location = new System.Drawing.Point(8, 232);
      this.Panel13.Name = "Panel13";
      this.Panel13.Size = new System.Drawing.Size(672, 216);
      this.Panel13.TabIndex = 1;
      // 
      // CheckBox37
      // 
      this.CheckBox37.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.CheckBox37.Location = new System.Drawing.Point(136, 192);
      this.CheckBox37.Name = "CheckBox37";
      this.CheckBox37.Size = new System.Drawing.Size(512, 16);
      this.CheckBox37.TabIndex = 17;
      this.CheckBox37.Text = "Remove all existing user web frames first";
      // 
      // txtWXXXContent
      // 
      this.txtWXXXContent.Location = new System.Drawing.Point(136, 30);
      this.txtWXXXContent.Name = "txtWXXXContent";
      this.txtWXXXContent.Size = new System.Drawing.Size(368, 20);
      this.txtWXXXContent.TabIndex = 13;
      this.txtWXXXContent.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtWXXXContent.Enter += new System.EventHandler(this.Select_Enter);
      this.txtWXXXContent.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnRemoveWXXX
      // 
      this.btnRemoveWXXX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveWXXX.Location = new System.Drawing.Point(512, 30);
      this.btnRemoveWXXX.Name = "btnRemoveWXXX";
      this.btnRemoveWXXX.Size = new System.Drawing.Size(152, 20);
      this.btnRemoveWXXX.TabIndex = 15;
      this.btnRemoveWXXX.Text = "Remove user web frame";
      this.btnRemoveWXXX.Click += new System.EventHandler(this.btnRemoveWXXX_Click);
      // 
      // btnAddWXXX
      // 
      this.btnAddWXXX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddWXXX.Location = new System.Drawing.Point(512, 6);
      this.btnAddWXXX.Name = "btnAddWXXX";
      this.btnAddWXXX.Size = new System.Drawing.Size(152, 20);
      this.btnAddWXXX.TabIndex = 14;
      this.btnAddWXXX.Text = "Add user web frame";
      this.btnAddWXXX.Click += new System.EventHandler(this.btnAddWXXX_Click);
      // 
      // lblWXXXContent
      // 
      this.lblWXXXContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblWXXXContent.Location = new System.Drawing.Point(8, 32);
      this.lblWXXXContent.Name = "lblWXXXContent";
      this.lblWXXXContent.Size = new System.Drawing.Size(128, 16);
      this.lblWXXXContent.TabIndex = 12;
      this.lblWXXXContent.Text = "Web frame &Content:";
      // 
      // lblWXXXDesc
      // 
      this.lblWXXXDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblWXXXDesc.Location = new System.Drawing.Point(8, 8);
      this.lblWXXXDesc.Name = "lblWXXXDesc";
      this.lblWXXXDesc.Size = new System.Drawing.Size(128, 16);
      this.lblWXXXDesc.TabIndex = 10;
      this.lblWXXXDesc.Text = "Web frame &Descriptor:";
      // 
      // txtWXXXDesc
      // 
      this.txtWXXXDesc.Location = new System.Drawing.Point(136, 6);
      this.txtWXXXDesc.Name = "txtWXXXDesc";
      this.txtWXXXDesc.Size = new System.Drawing.Size(368, 20);
      this.txtWXXXDesc.TabIndex = 11;
      this.txtWXXXDesc.TextChanged += new System.EventHandler(this.Select_TextChanged);
      this.txtWXXXDesc.Enter += new System.EventHandler(this.Select_Enter);
      this.txtWXXXDesc.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // WXXXList
      // 
      this.WXXXList.CheckBoxes = true;
      this.WXXXList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader13,
            this.ColumnHeader14});
      this.WXXXList.FullRowSelect = true;
      this.WXXXList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.WXXXList.Location = new System.Drawing.Point(136, 56);
      this.WXXXList.MultiSelect = false;
      this.WXXXList.Name = "WXXXList";
      this.WXXXList.Size = new System.Drawing.Size(528, 128);
      this.WXXXList.TabIndex = 16;
      this.WXXXList.UseCompatibleStateImageBehavior = false;
      this.WXXXList.View = System.Windows.Forms.View.Details;
      this.WXXXList.Click += new System.EventHandler(this.WXXXList_Click);
      this.WXXXList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // ColumnHeader13
      // 
      this.ColumnHeader13.Text = "Descriptor";
      this.ColumnHeader13.Width = 177;
      // 
      // ColumnHeader14
      // 
      this.ColumnHeader14.Text = "Content";
      this.ColumnHeader14.Width = 322;
      // 
      // lblDigits
      // 
      this.lblDigits.BackColor = System.Drawing.Color.White;
      this.lblDigits.ForeColor = System.Drawing.Color.Black;
      this.lblDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDigits.Location = new System.Drawing.Point(8, 68);
      this.lblDigits.Name = "lblDigits";
      this.lblDigits.Size = new System.Drawing.Size(184, 16);
      this.lblDigits.TabIndex = 102;
      this.lblDigits.Text = "Number of digits of track numbers:";
      // 
      // txtDigits
      // 
      this.txtDigits.Location = new System.Drawing.Point(192, 66);
      this.txtDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Name = "txtDigits";
      this.txtDigits.Size = new System.Drawing.Size(48, 20);
      this.txtDigits.TabIndex = 103;
      this.txtDigits.Value = new decimal(new int[] {
            2,
            0,
            0,
            0});
      // 
      // OpenFileDialog
      // 
      this.OpenFileDialog.RestoreDirectory = true;
      // 
      // chkRemoveAllNOT
      // 
      this.chkRemoveAllNOT.BackColor = System.Drawing.Color.White;
      this.chkRemoveAllNOT.ForeColor = System.Drawing.Color.Black;
      this.chkRemoveAllNOT.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkRemoveAllNOT.Location = new System.Drawing.Point(248, 68);
      this.chkRemoveAllNOT.Name = "chkRemoveAllNOT";
      this.chkRemoveAllNOT.Size = new System.Drawing.Size(232, 16);
      this.chkRemoveAllNOT.TabIndex = 104;
      this.chkRemoveAllNOT.Text = "Remove all NOT supported entries";
      this.chkRemoveAllNOT.UseVisualStyleBackColor = false;
      // 
      // lblInfoStar
      // 
      this.lblInfoStar.BackColor = System.Drawing.Color.White;
      this.lblInfoStar.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.lblInfoStar.Font = new System.Drawing.Font("Microsoft Sans Serif", 7F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblInfoStar.Location = new System.Drawing.Point(8, 8);
      this.lblInfoStar.Name = "lblInfoStar";
      this.lblInfoStar.Size = new System.Drawing.Size(672, 48);
      this.lblInfoStar.TabIndex = 101;
      this.lblInfoStar.Text = "Placeholders";
      this.lblInfoStar.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // SelectionBar
      // 
      this.SelectionBar.AccessibleRole = System.Windows.Forms.AccessibleRole.ToolBar;
      this.SelectionBar.AllowUserCustomize = false;
      this.SelectionBar.AntiAlias = true;
      this.SelectionBar.BackColor = System.Drawing.SystemColors.Control;
      this.SelectionBar.BackgroundStyle.BackColor1.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground;
      this.SelectionBar.BackgroundStyle.BackColor2.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.ExplorerBarBackground2;
      this.SelectionBar.BackgroundStyle.GradientAngle = 90;
      this.SelectionBar.Dock = System.Windows.Forms.DockStyle.Left;
      this.SelectionBar.Font = new System.Drawing.Font("Tahoma", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.World);
      this.SelectionBar.GroupImages = null;
      this.SelectionBar.Groups.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TAGV2grpTAG,
            this.TAGV2grpCommands});
      this.SelectionBar.Images = null;
      this.SelectionBar.Location = new System.Drawing.Point(0, 0);
      this.SelectionBar.Name = "SelectionBar";
      this.SelectionBar.Size = new System.Drawing.Size(168, 576);
      this.SelectionBar.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.Blue;
      this.SelectionBar.TabIndex = 107;
      this.SelectionBar.Text = "Select TAG section";
      this.SelectionBar.ThemeAware = true;
      // 
      // TAGV2grpTAG
      // 
      this.TAGV2grpTAG.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
      this.TAGV2grpTAG.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.TAGV2grpTAG.BackgroundStyle.BorderColor.Color = System.Drawing.Color.White;
      this.TAGV2grpTAG.CanCustomize = false;
      this.TAGV2grpTAG.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.White;
      this.TAGV2grpTAG.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
      this.TAGV2grpTAG.HeaderHotStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.TAGV2grpTAG.HeaderHotStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2grpTAG.HeaderStyle.BackColor1.Color = System.Drawing.Color.White;
      this.TAGV2grpTAG.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
      this.TAGV2grpTAG.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.TAGV2grpTAG.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2grpTAG.Name = "TAGV2grpTAG";
      this.TAGV2grpTAG.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.Blue;
      this.TAGV2grpTAG.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.TAGV2ButtonItem1,
            this.TAGV2ButtonItem2,
            this.TAGV2ButtonItem3,
            this.TAGV2ButtonItem4,
            this.TAGV2ButtonItem5,
            this.TAGV2ButtonItem6,
            this.TAGV2ButtonItem7,
            this.TAGV2ButtonItem8,
            this.TAGV2ButtonItem9});
      this.TAGV2grpTAG.Text = "TAG information";
      this.TAGV2grpTAG.ThemeAware = true;
      // 
      // TAGV2ButtonItem1
      // 
      this.TAGV2ButtonItem1.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem1.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem1.HotFontUnderline = true;
      this.TAGV2ButtonItem1.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem1.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem1.Name = "TAGV2ButtonItem1";
      this.TAGV2ButtonItem1.Text = "Main Entries";
      this.TAGV2ButtonItem1.Click += new System.EventHandler(this.btnItem_Click);
      // 
      // TAGV2ButtonItem2
      // 
      this.TAGV2ButtonItem2.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem2.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem2.HotFontUnderline = true;
      this.TAGV2ButtonItem2.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem2.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem2.Name = "TAGV2ButtonItem2";
      this.TAGV2ButtonItem2.Text = "Detailed information";
      this.TAGV2ButtonItem2.Click += new System.EventHandler(this.btnItem_Click);
      // 
      // TAGV2ButtonItem3
      // 
      this.TAGV2ButtonItem3.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem3.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem3.HotFontUnderline = true;
      this.TAGV2ButtonItem3.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem3.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem3.Name = "TAGV2ButtonItem3";
      this.TAGV2ButtonItem3.Text = "Original information";
      this.TAGV2ButtonItem3.Click += new System.EventHandler(this.btnItem_Click);
      // 
      // TAGV2ButtonItem4
      // 
      this.TAGV2ButtonItem4.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem4.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem4.HotFontUnderline = true;
      this.TAGV2ButtonItem4.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem4.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem4.Name = "TAGV2ButtonItem4";
      this.TAGV2ButtonItem4.Text = "Involved people";
      this.TAGV2ButtonItem4.Click += new System.EventHandler(this.btnItem_Click);
      // 
      // TAGV2ButtonItem5
      // 
      this.TAGV2ButtonItem5.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem5.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem5.HotFontUnderline = true;
      this.TAGV2ButtonItem5.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem5.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem5.Name = "TAGV2ButtonItem5";
      this.TAGV2ButtonItem5.Text = "Web information";
      this.TAGV2ButtonItem5.Click += new System.EventHandler(this.btnItem_Click);
      // 
      // TAGV2ButtonItem6
      // 
      this.TAGV2ButtonItem6.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem6.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem6.HotFontUnderline = true;
      this.TAGV2ButtonItem6.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem6.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem6.Name = "TAGV2ButtonItem6";
      this.TAGV2ButtonItem6.Text = "Pictures";
      this.TAGV2ButtonItem6.Click += new System.EventHandler(this.btnItem_Click);
      // 
      // TAGV2ButtonItem7
      // 
      this.TAGV2ButtonItem7.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem7.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem7.HotFontUnderline = true;
      this.TAGV2ButtonItem7.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem7.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem7.Name = "TAGV2ButtonItem7";
      this.TAGV2ButtonItem7.Text = "Lyrics";
      this.TAGV2ButtonItem7.Click += new System.EventHandler(this.btnItem_Click);
      // 
      // TAGV2ButtonItem8
      // 
      this.TAGV2ButtonItem8.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem8.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem8.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem8.HotFontUnderline = true;
      this.TAGV2ButtonItem8.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem8.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem8.Name = "TAGV2ButtonItem8";
      this.TAGV2ButtonItem8.Text = "Rating";
      this.TAGV2ButtonItem8.Click += new System.EventHandler(this.btnItem_Click);
      // 
      // TAGV2ButtonItem9
      // 
      this.TAGV2ButtonItem9.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem9.Cursor = System.Windows.Forms.Cursors.Hand;
      this.TAGV2ButtonItem9.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2ButtonItem9.HotFontUnderline = true;
      this.TAGV2ButtonItem9.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2ButtonItem9.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.TAGV2ButtonItem9.Name = "TAGV2ButtonItem9";
      this.TAGV2ButtonItem9.Text = "User defined information";
      this.TAGV2ButtonItem9.Click += new System.EventHandler(this.btnItem_Click);
      // 
      // TAGV2grpCommands
      // 
      this.TAGV2grpCommands.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(((int)(((byte)(214)))), ((int)(((byte)(223)))), ((int)(((byte)(247)))));
      this.TAGV2grpCommands.BackgroundStyle.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.TAGV2grpCommands.BackgroundStyle.BorderColor.Color = System.Drawing.Color.White;
      this.TAGV2grpCommands.CanCustomize = false;
      this.TAGV2grpCommands.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.White;
      this.TAGV2grpCommands.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
      this.TAGV2grpCommands.HeaderHotStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.TAGV2grpCommands.HeaderHotStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.TAGV2grpCommands.HeaderStyle.BackColor1.Color = System.Drawing.Color.White;
      this.TAGV2grpCommands.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(199)))), ((int)(((byte)(211)))), ((int)(((byte)(247)))));
      this.TAGV2grpCommands.HeaderStyle.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.TAGV2grpCommands.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.TAGV2grpCommands.Name = "TAGV2grpCommands";
      this.TAGV2grpCommands.StockStyle = DevComponents.DotNetBar.eExplorerBarStockStyle.Blue;
      this.TAGV2grpCommands.SubItems.AddRange(new DevComponents.DotNetBar.BaseItem[] {
            this.btnSwapAT,
            this.btnSwapAA,
            this.btnSwapTA});
      this.TAGV2grpCommands.Text = "Commands";
      this.TAGV2grpCommands.ThemeAware = true;
      // 
      // btnSwapAT
      // 
      this.btnSwapAT.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnSwapAT.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSwapAT.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnSwapAT.HotFontUnderline = true;
      this.btnSwapAT.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnSwapAT.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnSwapAT.Name = "btnSwapAT";
      this.btnSwapAT.Text = "Swap Artist-Title";
      this.btnSwapAT.Click += new System.EventHandler(this.btnSwapAT_Click);
      // 
      // btnSwapAA
      // 
      this.btnSwapAA.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnSwapAA.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSwapAA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnSwapAA.HotFontUnderline = true;
      this.btnSwapAA.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnSwapAA.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnSwapAA.Name = "btnSwapAA";
      this.btnSwapAA.Text = "Swap Artist-Album";
      this.btnSwapAA.Click += new System.EventHandler(this.btnSwapAA_Click);
      // 
      // btnSwapTA
      // 
      this.btnSwapTA.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnSwapTA.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnSwapTA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnSwapTA.HotFontUnderline = true;
      this.btnSwapTA.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnSwapTA.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnSwapTA.Name = "btnSwapTA";
      this.btnSwapTA.Text = "Swap Title-Album";
      this.btnSwapTA.Click += new System.EventHandler(this.btnSwapTA_Click);
      // 
      // btnImport
      // 
      this.btnImport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnImport.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnImport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnImport.HotFontUnderline = true;
      this.btnImport.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnImport.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnImport.Name = "btnImport";
      this.btnImport.Text = "Transfer from Ver. 1";
      // 
      // btnExport
      // 
      this.btnExport.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnExport.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnExport.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnExport.HotFontUnderline = true;
      this.btnExport.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnExport.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnExport.Name = "btnExport";
      this.btnExport.Text = "Transfer to Ver. 1";
      // 
      // btnGet
      // 
      this.btnGet.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.btnGet.Cursor = System.Windows.Forms.Cursors.Hand;
      this.btnGet.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.btnGet.HotFontUnderline = true;
      this.btnGet.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.btnGet.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.btnGet.Name = "btnGet";
      this.btnGet.Text = "Get from filename";
      // 
      // TopPanel
      // 
      this.TopPanel.AntiAlias = true;
      this.TopPanel.Dock = System.Windows.Forms.DockStyle.Top;
      this.TopPanel.Location = new System.Drawing.Point(168, 0);
      this.TopPanel.Name = "TopPanel";
      this.TopPanel.Size = new System.Drawing.Size(690, 24);
      this.TopPanel.Style.BackColor1.Color = System.Drawing.Color.White;
      this.TopPanel.Style.BackColor2.Color = System.Drawing.Color.White;
      this.TopPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
      this.TopPanel.Style.BorderWidth = 0;
      this.TopPanel.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.TopPanel.Style.ForeColor.Color = System.Drawing.Color.Black;
      this.TopPanel.Style.GradientAngle = 90;
      this.TopPanel.Style.LineAlignment = System.Drawing.StringAlignment.Near;
      this.TopPanel.Style.MarginBottom = 2;
      this.TopPanel.Style.MarginLeft = 7;
      this.TopPanel.Style.MarginRight = 2;
      this.TopPanel.Style.MarginTop = 2;
      this.TopPanel.TabIndex = 108;
      this.TopPanel.Text = "TopPanel";
      // 
      // btnOK
      // 
      this.btnOK.BackColor = System.Drawing.SystemColors.Control;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(480, 64);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(96, 24);
      this.btnOK.TabIndex = 105;
      this.btnOK.Text = "&OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(584, 64);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(96, 24);
      this.btnCancel.TabIndex = 106;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // ButtomPanel
      // 
      this.ButtomPanel.AntiAlias = true;
      this.ButtomPanel.Controls.Add(this.chkRemoveAllNOT);
      this.ButtomPanel.Controls.Add(this.txtDigits);
      this.ButtomPanel.Controls.Add(this.btnCancel);
      this.ButtomPanel.Controls.Add(this.btnOK);
      this.ButtomPanel.Controls.Add(this.lblDigits);
      this.ButtomPanel.Controls.Add(this.lblInfoStar);
      this.ButtomPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
      this.ButtomPanel.Location = new System.Drawing.Point(168, 480);
      this.ButtomPanel.Name = "ButtomPanel";
      this.ButtomPanel.Size = new System.Drawing.Size(690, 96);
      this.ButtomPanel.Style.BackColor1.Color = System.Drawing.Color.White;
      this.ButtomPanel.Style.BackColor2.Color = System.Drawing.Color.White;
      this.ButtomPanel.Style.BorderColor.ColorSchemePart = DevComponents.DotNetBar.eColorSchemePart.PanelBorder;
      this.ButtomPanel.Style.BorderWidth = 0;
      this.ButtomPanel.Style.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.ButtomPanel.Style.ForeColor.Color = System.Drawing.Color.Black;
      this.ButtomPanel.Style.GradientAngle = 90;
      this.ButtomPanel.Style.LineAlignment = System.Drawing.StringAlignment.Near;
      this.ButtomPanel.Style.MarginBottom = 2;
      this.ButtomPanel.Style.MarginLeft = 7;
      this.ButtomPanel.Style.MarginRight = 2;
      this.ButtomPanel.Style.MarginTop = 2;
      this.ButtomPanel.TabIndex = 100;
      // 
      // Label
      // 
      this.Label.ButtonStyle = DevComponents.DotNetBar.eButtonStyle.ImageAndText;
      this.Label.Cursor = System.Windows.Forms.Cursors.Hand;
      this.Label.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.Label.HotFontUnderline = true;
      this.Label.HotForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.Label.HotTrackingStyle = DevComponents.DotNetBar.eHotTrackingStyle.None;
      this.Label.Name = "Label";
      this.Label.PopupAnimation = DevComponents.DotNetBar.ePopupAnimation.None;
      this.Label.Text = "New Button";
      // 
      // frmTAG2Multi
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(858, 576);
      this.ControlBox = false;
      this.Controls.Add(this.panMain);
      this.Controls.Add(this.panOriginal);
      this.Controls.Add(this.panLyrics);
      this.Controls.Add(this.panPic);
      this.Controls.Add(this.panRating);
      this.Controls.Add(this.panInvolved);
      this.Controls.Add(this.panWeb);
      this.Controls.Add(this.panUser);
      this.Controls.Add(this.panDetail);
      this.Controls.Add(this.TopPanel);
      this.Controls.Add(this.ButtomPanel);
      this.Controls.Add(this.SelectionBar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG2Multi";
      this.ShowInTaskbar = false;
      this.Text = "Multiple Edit TAG Ver. 2";
      this.panDetail.ResumeLayout(false);
      this.Panel9.ResumeLayout(false);
      this.Panel5.ResumeLayout(false);
      this.Panel5.PerformLayout();
      this.Panel14.ResumeLayout(false);
      this.Panel14.PerformLayout();
      this.Panel4.ResumeLayout(false);
      this.Panel4.PerformLayout();
      this.panOriginal.ResumeLayout(false);
      this.Panel6.ResumeLayout(false);
      this.Panel6.PerformLayout();
      this.panMain.ResumeLayout(false);
      this.Panel3.ResumeLayout(false);
      this.Panel3.PerformLayout();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.Panel2.ResumeLayout(false);
      this.panWeb.ResumeLayout(false);
      this.Panel10.ResumeLayout(false);
      this.Panel10.PerformLayout();
      this.panRating.ResumeLayout(false);
      this.Panel11.ResumeLayout(false);
      this.Panel11.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatingCounter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatingRating)).EndInit();
      this.panInvolved.ResumeLayout(false);
      this.Panel15.ResumeLayout(false);
      this.Panel15.PerformLayout();
      this.Panel16.ResumeLayout(false);
      this.Panel16.PerformLayout();
      this.panPic.ResumeLayout(false);
      this.Panel7.ResumeLayout(false);
      this.Panel7.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.APICView)).EndInit();
      this.panLyrics.ResumeLayout(false);
      this.Panel8.ResumeLayout(false);
      this.Panel8.PerformLayout();
      this.panUser.ResumeLayout(false);
      this.Panel12.ResumeLayout(false);
      this.Panel12.PerformLayout();
      this.Panel13.ResumeLayout(false);
      this.Panel13.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.SelectionBar)).EndInit();
      this.ButtomPanel.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    //this.txtPOS2.AllowNegative = false;
    //this.txtPOS2.DigitsInGroup = 0;
    //this.txtPOS2.Flags = 65536;
    //this.txtPOS2.MaxDecimalPlaces = 0;
    //this.txtPOS2.MaxWholeDigits = 6;
    //this.txtPOS2.Prefix = "";
    //this.txtPOS2.RangeMax = 999999D;
    //this.txtPOS2.RangeMin = 0D;
    //this.txtPOS1.AllowNegative = false;
    //this.txtPOS1.DigitsInGroup = 0;
    //this.txtPOS1.Flags = 65536;
    //this.txtPOS1.MaxDecimalPlaces = 0;
    //this.txtPOS1.MaxWholeDigits = 6;
    //this.txtPOS1.Prefix = "";
    //this.txtPOS1.RangeMax = 999999D;
    //this.txtPOS1.RangeMin = 0D;

    //this.txtPOS1.ModifyFlags(0x10, true);
    //this.txtPOS2.ModifyFlags(0x10, true);

    public frmTAG2Multi(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG2Multi_Load);
      this.vbooCommentMoved = false;
      this.vbooLyricsMoved = false;
      this.vbooRatingMoved = false;
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

    #region Local variables

    private FileStream PicFStream;
    private MemoryStream PicMStream;
    private bool vbooCommentMoved;
    private bool vbooLyricsMoved;
    private bool vbooRatingMoved;

    #endregion

    #region Events

    private void btnAddComment_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      V2LDCFrame frame = new V2LDCFrame
      {
        FID = "COMM"
      };
      if (StringType.StrCmp(this.txtComment.Text, "", false) != 0)
      {
        foreach (ListViewItem item2 in this.CommentList.Items)
        {
          if ((StringType.StrCmp(item2.Text.ToLower(), this.cmbCDescriptor.Text.ToLower(), false) == 0) & (StringType.StrCmp(item2.SubItems[2].Text, this.cmbCLanguage.Text.Substring(0, 3), false) == 0))
          {
            item2.Text = this.cmbCDescriptor.Text;
            item2.SubItems[1].Text = this.txtComment.Text.Replace("\r\n", "\n");
            this.cmbCDescriptor.Text = "";
            this.txtComment.Text = "";
            return;
          }
        }
        item.Text = this.cmbCDescriptor.Text;
        item.SubItems.Add(this.txtComment.Text.Replace("\r\n", "\n"));
        item.SubItems.Add(this.cmbCLanguage.Text.Substring(0, 3));
        frame.Descriptor = this.cmbCDescriptor.Text;
        frame.Content = this.txtComment.Text.Replace("\r\n", "\n");
        frame.Language = this.cmbCLanguage.Text.Substring(0, 3);
        item.Tag = frame;
        item.Checked = true;
        this.CommentList.Items.Add(item);
        this.cmbCDescriptor.Text = "";
        this.txtComment.Text = "";
      }
    }

    private void btnAddGenre_Click(object sender, EventArgs e)
    {
      if (!this.GenreList.Items.Contains(this.cmbGenre.Text.Trim(new char[] { ' ' })) & (StringType.StrCmp(this.cmbGenre.Text.Trim(new char[] { ' ' }), "", false) != 0))
      {
        this.GenreList.Items.Add(this.cmbGenre.Text.Trim(new char[] { ' ' }));
        this.cmbGenre.Text = "";
      }
    }

    private void btnAddInv_Click(object sender, EventArgs e)
    {
      if (!((StringType.StrCmp(this.txtInvFunction.Text.TrimEnd(new char[] { ' ' }), "", false) == 0) | (StringType.StrCmp(this.txtInvPerson.Text.TrimEnd(new char[] { ' ' }), "", false) == 0)))
      {
        this.CheckBox44.Checked = true;
        foreach (ListViewItem item2 in this.TIPLList.Items)
        {
          if (StringType.StrCmp(item2.Text.ToLower(), this.txtInvFunction.Text.TrimEnd(new char[] { ' ' }).ToLower(), false) == 0)
          {
            item2.Text = this.txtInvFunction.Text.TrimEnd(new char[] { ' ' });
            item2.SubItems[1].Text = this.txtInvPerson.Text.TrimEnd(new char[] { ' ' });
            return;
          }
        }
        ListViewItem item = new ListViewItem
        {
          Text = this.txtInvFunction.Text.TrimEnd(new char[] { ' ' }),
          SubItems = { this.txtInvPerson.Text.TrimEnd(new char[] { ' ' }) }
        };
        this.TIPLList.Items.Add(item);
        this.txtInvFunction.Text = "";
        this.txtInvPerson.Text = "";
      }
    }

    private void btnAddLyrics_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      V2LDCFrame frame = new V2LDCFrame
      {
        FID = "USLT"
      };
      if (StringType.StrCmp(this.txtLyrics.Text, "", false) != 0)
      {
        foreach (ListViewItem item2 in this.LyricsList.Items)
        {
          if ((StringType.StrCmp(item2.Text.ToLower(), this.txtLDescriptor.Text.ToLower(), false) == 0) & (StringType.StrCmp(item2.SubItems[2].Text, this.cmbLLanguage.Text.Substring(0, 3), false) == 0))
          {
            if (ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null), this.txtLDescriptor.Text, false) != 0)
            {
              item2.Text = this.txtLDescriptor.Text;
            }
            if (ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null), this.txtLyrics.Text.Replace("\r\n", "\n"), false) != 0)
            {
              item2.SubItems[1].Text = this.txtLyrics.Text.Replace("\r\n", "\n");
            }
            this.txtLDescriptor.Text = "";
            this.txtLyrics.Text = "";
            return;
          }
        }
        item.Text = this.txtLDescriptor.Text;
        item.SubItems.Add(this.txtLyrics.Text.Replace("\r\n", "\n"));
        item.SubItems.Add(this.cmbLLanguage.Text.Substring(0, 3));
        frame.Descriptor = this.txtLDescriptor.Text;
        frame.Content = this.txtLyrics.Text.Replace("\r\n", "\n");
        frame.Language = this.cmbLLanguage.Text.Substring(0, 3);
        item.Tag = frame;
        item.Checked = true;
        this.LyricsList.Items.Add(item);
        this.txtLDescriptor.Text = "";
        this.txtLyrics.Text = "";
      }
    }

    private void btnAddMusican_Click(object sender, EventArgs e)
    {
      if (!((StringType.StrCmp(this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' }), "", false) == 0) | (StringType.StrCmp(this.txtMusicianName.Text.TrimEnd(new char[] { ' ' }), "", false) == 0)))
      {
        this.CheckBox45.Checked = true;
        foreach (ListViewItem item2 in this.TMCLList.Items)
        {
          if (StringType.StrCmp(item2.Text.ToLower(), this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' }).ToLower(), false) == 0)
          {
            item2.Text = this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' });
            item2.SubItems[1].Text = this.txtMusicianName.Text.TrimEnd(new char[] { ' ' });
            return;
          }
        }
        ListViewItem item = new ListViewItem
        {
          Text = this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' }),
          SubItems = { this.txtMusicianName.Text.TrimEnd(new char[] { ' ' }) }
        };
        this.TMCLList.Items.Add(item);
        this.txtMusicianInst.Text = "";
        this.txtMusicianName.Text = "";
      }
    }

    private void btnAddPicture_Click(object sender, EventArgs e)
    {
      int index = 0;
      ListViewItem item = new ListViewItem();
      V2APICFrame frame = new V2APICFrame();

      if (!((StringType.StrCmp(this.txtPicPath.Text, "", false) == 0) | this.txtPicPath.Text.ToLower().EndsWith("mp3")))
      {
        frame.FID = "APIC";
        foreach (ListViewItem item2 in this.PicList.Items)
        {
          if (((ulong)-(StringType.StrCmp(item2.Text.ToLower(), this.txtPDescriptor.Text.ToLower(), false) == 0 ? 1 : 0)
            & (ulong)checked((long)Math.Round(Conversion.Val((object)unchecked(DoubleType.FromString(item2.SubItems[1].Text.Substring(0, 2)) == Conversion.Val(this.cmbPicType.Text.Substring(0, 2))))))) > 0UL)
          //if ((((long)-((StringType.StrCmp(item2.Text.ToLower(), this.txtPDescriptor.Text.ToLower(), false) == 0) > false)) 
          // & ((long)Math.Round(Conversion.Val(DoubleType.FromString(item2.SubItems[1].Text.Substring(0, 2)) == Conversion.Val(this.cmbPicType.Text.Substring(0, 2)))))) > 0L)
          {
            if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null), this.txtPDescriptor.Text, false) == 0, ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "PicType", new object[0], null, null), Conversion.Val(this.cmbPicType.Text.Substring(0, 2)), false) == 0), ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Path", new object[0], null, null), this.txtPicPath.Text, false) == 0), ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Include", new object[0], null, null), this.chkPicInclude.Checked, false) == 0), ((item2.Font.Style == FontStyle.Bold) & this.chkPicRelativPath.Checked) | ((item2.Font.Style == FontStyle.Regular) & !this.chkPicRelativPath.Checked))))
              return;
            item2.Remove();
            break;
          }
          index++;
        }

        item.Text = this.txtPDescriptor.Text;
        frame.Descriptor = this.txtPDescriptor.Text;
        item.SubItems.Add(this.cmbPicType.Text);
        frame.PicType = (byte)Math.Round(Conversion.Val(this.cmbPicType.Text.Substring(0, 2)));
        item.SubItems.Add(this.txtPicPath.Text);
        frame.Path = this.txtPicPath.Text;
        item.SubItems.Add(this.chkPicInclude.Checked.ToString());
        frame.Include = this.chkPicInclude.Checked;

        if (frame.Include)
        {
          string sLeft = frame.Path.Substring(frame.Path.LastIndexOf(".") + 1).ToLower();
          if (StringType.StrCmp(sLeft, "jpg", false) == 0)
          {
            frame.MIMEType = "image/jpeg";
          }
          else if (StringType.StrCmp(sLeft, "bmp", false) == 0)
          {
            frame.MIMEType = "image/bmp";
          }
          else if (StringType.StrCmp(sLeft, "gif", false) == 0)
          {
            frame.MIMEType = "image/gif";
          }
          else if (StringType.StrCmp(sLeft, "png", false) == 0)
          {
            frame.MIMEType = "image/png";
          }
          else if (StringType.StrCmp(sLeft, "ico", false) == 0)
          {
            frame.MIMEType = "image/ico";
          }
          else
          {
            frame.MIMEType = "image/" + frame.Path.Substring(frame.Path.LastIndexOf(".") + 1).ToLower();
          }
        }
        else
        {
          frame.MIMEType = "-->";
        }
        if (this.chkPicRelativPath.Checked)
        {
          item.Font = new Font(item.Font, FontStyle.Bold);
        }
        else
        {
          item.Font = new Font(item.Font, FontStyle.Regular);
        }
        item.Tag = frame;
        item.Checked = true;
        this.PicList.Items.Insert(index, item);
        this.txtPDescriptor.Text = "";
        this.txtPicPath.Text = "";
        this.chkPicInclude.Checked = false;
        this.chkPicInclude.Enabled = true;
        this.chkPicRelativPath.Checked = false;
        this.btnAddPicture.Enabled = false;
        this.APICView.Image = null;
        this.cmbPicType.SelectedIndex = 0;
      }
    }

    private void btnAddRating_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      V2POPMFrame frame = new V2POPMFrame
      {
        FID = "POPM"
      };
      if (decimal.Compare(this.txtRatingRating.Value, decimal.Zero) != 0)
      {
        foreach (ListViewItem item2 in this.RatingList.Items)
        {
          if (StringType.StrCmp(item2.Text.ToLower(), this.txtRatingUser.Text.ToLower(), false) == 0)
          {
            item2.Text = this.txtRatingUser.Text;
            item2.SubItems[1].Text = this.txtRatingRating.Text;
            item2.SubItems[2].Text = this.txtRatingCounter.Text;
            this.txtRatingUser.Text = "";
            this.txtRatingRating.Value = decimal.Zero;
            this.txtRatingCounter.Value = decimal.Zero;
            return;
          }
        }
        item.Text = this.txtRatingUser.Text;
        item.SubItems.Add(this.txtRatingRating.Text);
        item.SubItems.Add(this.txtRatingCounter.Text);
        frame.User = this.txtRatingUser.Text;
        frame.Rating = Convert.ToByte(this.txtRatingRating.Value);
        frame.Counter = Convert.ToInt32(this.txtRatingCounter.Value);
        item.Tag = frame;
        item.Checked = true;
        this.RatingList.Items.Add(item);
        this.txtRatingUser.Text = "";
        this.txtRatingRating.Value = decimal.Zero;
        this.txtRatingCounter.Value = decimal.Zero;
      }
    }

    private void btnAddTXXX_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      V2TXXXFrame frame = new V2TXXXFrame
      {
        FID = "TXXX"
      };
      if (StringType.StrCmp(this.txtTXXXContent.Text, "", false) != 0)
      {
        foreach (ListViewItem item2 in this.TXXXList.Items)
        {
          if (StringType.StrCmp(item2.Text.ToLower(), this.txtTXXXDesc.Text.ToLower(), false) == 0)
          {
            item2.Text = this.txtTXXXDesc.Text;
            item2.SubItems[1].Text = this.txtTXXXContent.Text;
            this.txtTXXXDesc.Text = "";
            this.txtTXXXContent.Text = "";
            return;
          }
        }
        item.Text = this.txtTXXXDesc.Text;
        item.SubItems.Add(this.txtTXXXContent.Text);
        frame.Descriptor = this.txtTXXXDesc.Text;
        frame.Content = this.txtTXXXContent.Text;
        item.Tag = frame;
        item.Checked = true;
        this.TXXXList.Items.Add(item);
        this.txtTXXXDesc.Text = "";
        this.txtTXXXContent.Text = "";
      }
    }

    private void btnAddWXXX_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      V2WXXXFrame frame = new V2WXXXFrame
      {
        FID = "WXXX"
      };
      if (StringType.StrCmp(this.txtWXXXContent.Text, "", false) != 0)
      {
        foreach (ListViewItem item2 in this.WXXXList.Items)
        {
          if (StringType.StrCmp(item2.Text.ToLower(), this.txtWXXXDesc.Text.ToLower(), false) == 0)
          {
            item2.Text = this.txtWXXXDesc.Text;
            item2.SubItems[1].Text = this.txtWXXXContent.Text;
            this.txtWXXXDesc.Text = "";
            this.txtWXXXContent.Text = "";
            return;
          }
        }
        item.Text = this.txtWXXXDesc.Text;
        item.SubItems.Add(this.txtWXXXContent.Text);
        frame.Descriptor = this.txtWXXXDesc.Text;
        frame.Content = this.txtWXXXContent.Text;
        item.Tag = frame;
        item.Checked = true;
        this.WXXXList.Items.Add(item);
        this.txtWXXXDesc.Text = "";
        this.txtWXXXContent.Text = "";
      }
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      try
      {
        this.APICView.Image = null;
        this.PicFStream.Close();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }
      try
      {
        this.APICView.Image = null;
        this.PicMStream.Close();
      }
      catch (Exception exception3)
      {
        ProjectData.SetProjectError(exception3);
        Exception exception2 = exception3;
        ProjectData.ClearProjectError();
      }
      this.Close();
    }

    private void btnGetPic_Click(object sender, EventArgs e)
    {
      this.OpenFileDialog.Filter = "*.BMP;*.JPG;*.GIF;*.PNG;*.ICO|*.BMP;*.JPG;*.GIF;*.PNG;*.ICO";
      this.OpenFileDialog.FilterIndex = 1;
      try
      {
        this.APICView.Image = null;
        this.PicFStream.Close();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }
      try
      {
        this.APICView.Image = null;
        this.PicMStream.Close();
      }
      catch (Exception exception4)
      {
        ProjectData.SetProjectError(exception4);
        Exception exception2 = exception4;
        ProjectData.ClearProjectError();
      }
      if (this.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        try
        {
          this.PicFStream = (FileStream)this.OpenFileDialog.OpenFile();
          this.APICView.Image = Image.FromStream(this.PicFStream);
          this.txtPicPath.Text = this.OpenFileDialog.FileName;
          this.chkPicInclude.Enabled = true;
          this.chkPicInclude.Checked = false;
          this.btnAddPicture.Enabled = true;
        }
        catch (Exception exception5)
        {
          ProjectData.SetProjectError(exception5);
          Exception exception3 = exception5;
          Interaction.MsgBox(exception3.Message, MsgBoxStyle.ApplicationModal, null);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void btnItem_Click(object sender, EventArgs e)
    {
      this.TopPanel.Text = StringType.FromObject(LateBinding.LateGet(sender, null, "Text", new object[0], null, null));
      this.panMain.Visible = false;
      this.panDetail.Visible = false;
      this.panOriginal.Visible = false;
      this.panWeb.Visible = false;
      this.panRating.Visible = false;
      this.panPic.Visible = false;
      this.panLyrics.Visible = false;
      this.panInvolved.Visible = false;
      this.panUser.Visible = false;
      this.panMain.Enabled = false;
      this.panDetail.Enabled = false;
      this.panOriginal.Enabled = false;
      this.panWeb.Enabled = false;
      this.panRating.Enabled = false;
      this.panPic.Enabled = false;
      this.panLyrics.Enabled = false;
      this.panInvolved.Enabled = false;
      this.panUser.Enabled = false;
      object obj2 = LateBinding.LateGet(sender, null, "Name", new object[0], null, null);
      if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem1", false) == 0)
      {
        this.panMain.Visible = true;
        this.panMain.Enabled = true;
        this.panMain.Dock = DockStyle.Fill;
      }
      else if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem2", false) == 0)
      {
        this.panDetail.Visible = true;
        this.panDetail.Enabled = true;
        this.panDetail.Dock = DockStyle.Fill;
      }
      else if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem3", false) == 0)
      {
        this.panOriginal.Visible = true;
        this.panOriginal.Enabled = true;
        this.panOriginal.Dock = DockStyle.Fill;
      }
      else if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem4", false) == 0)
      {
        this.panInvolved.Visible = true;
        this.panInvolved.Enabled = true;
        this.panInvolved.Dock = DockStyle.Fill;
      }
      else if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem5", false) == 0)
      {
        this.panWeb.Visible = true;
        this.panWeb.Enabled = true;
        this.panWeb.Dock = DockStyle.Fill;
      }
      else if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem6", false) == 0)
      {
        this.panPic.Visible = true;
        this.panPic.Enabled = true;
        this.panPic.Dock = DockStyle.Fill;
      }
      else if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem7", false) == 0)
      {
        this.panLyrics.Visible = true;
        this.panLyrics.Enabled = true;
        this.panLyrics.Dock = DockStyle.Fill;
      }
      else if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem8", false) == 0)
      {
        this.panRating.Visible = true;
        this.panRating.Enabled = true;
        this.panRating.Dock = DockStyle.Fill;
      }
      else if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem9", false) == 0)
      {
        this.panUser.Visible = true;
        this.panUser.Enabled = true;
        this.panUser.Dock = DockStyle.Fill;
      }
    }

    private void btnLyricsFile_Click(object sender, EventArgs e)
    {
      this.OpenFileDialog.Filter = "*.TXT|*.TXT";
      this.OpenFileDialog.FilterIndex = 1;
      if (this.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
      {
        try
        {
          this.txtLyrics.LoadFile(this.OpenFileDialog.FileName, RichTextBoxStreamType.PlainText);
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          Exception exception = exception1;
          Interaction.MsgBox(exception.Message, MsgBoxStyle.ApplicationModal, null);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void btnMoveComment_Click(object sender, EventArgs e)
    {
      if ((this.CommentList.FocusedItem != null) && (this.CommentList.FocusedItem.Index > 0))
      {
        ListViewItem focusedItem = this.CommentList.FocusedItem;
        ListViewItem item = (ListViewItem)focusedItem.Clone();
        this.CommentList.Items.Insert(0, item);
        this.CommentList.Items.Remove(focusedItem);
        this.vbooCommentMoved = true;
      }
    }

    private void btnMoveGenre_Click(object sender, EventArgs e)
    {
      if (this.GenreList.SelectedIndex >= 0)
      {
        string item = StringType.FromObject(this.GenreList.SelectedItem);
        int selectedIndex = this.GenreList.SelectedIndex;
        this.GenreList.Items.Insert(0, item);
        this.GenreList.Items.RemoveAt(selectedIndex + 1);
        this.CheckBox9.Checked = true;
      }
    }

    private void btnMoveLyrics_Click(object sender, EventArgs e)
    {
      if ((this.LyricsList.FocusedItem != null) && (this.LyricsList.FocusedItem.Index > 0))
      {
        ListViewItem focusedItem = this.LyricsList.FocusedItem;
        ListViewItem item = (ListViewItem)focusedItem.Clone();
        this.LyricsList.Items.Insert(0, item);
        this.LyricsList.Items.Remove(focusedItem);
        this.vbooLyricsMoved = true;
      }
    }

    private void btnMoveRating_Click(object sender, EventArgs e)
    {
      if ((this.RatingList.FocusedItem != null) && (this.RatingList.FocusedItem.Index > 0))
      {
        ListViewItem focusedItem = this.RatingList.FocusedItem;
        ListViewItem item = (ListViewItem)focusedItem.Clone();
        this.RatingList.Items.Insert(0, item);
        this.RatingList.Items.Remove(focusedItem);
        this.vbooRatingMoved = true;
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      try
      {
        this.APICView.Image = null;
        this.PicFStream.Close();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }
      try
      {
        this.APICView.Image = null;
        this.PicMStream.Close();
      }
      catch (Exception exception3)
      {
        ProjectData.SetProjectError(exception3);
        Exception exception2 = exception3;
        ProjectData.ClearProjectError();
      }
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      Declarations.objSettings.V2Language = this.cmbCLanguage.SelectedIndex;
      this.SaveToTAG();
      this.Close();
    }

    private void btnRemoveComment_Click(object sender, EventArgs e)
    {
      try
      {
        this.CommentList.Items.Remove(this.CommentList.FocusedItem);
        this.cmbCDescriptor.Text = "";
        this.cmbCLanguage.Text = "";
        this.txtComment.Text = "";
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
    }

    private void btnRemoveGenre_Click(object sender, EventArgs e)
    {
      this.GenreList.Items.Remove(RuntimeHelpers.GetObjectValue(this.GenreList.SelectedItem));
      this.cmbGenre.Text = "";
      this.CheckBox9.Checked = true;
    }

    private void btnRemoveInv_Click(object sender, EventArgs e)
    {
      if (this.TIPLList.FocusedItem != null)
      {
        this.TIPLList.Items.Remove(this.TIPLList.FocusedItem);
        this.txtInvFunction.Text = "";
        this.txtInvPerson.Text = "";
      }
    }

    private void btnRemoveLyrics_Click(object sender, EventArgs e)
    {
      try
      {
        this.LyricsList.Items.Remove(this.LyricsList.FocusedItem);
        this.txtLDescriptor.Text = "";
        this.cmbLLanguage.Text = "";
        this.txtLyrics.Text = "";
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
    }

    private void btnRemoveMusican_Click(object sender, EventArgs e)
    {
      if (this.TMCLList.FocusedItem != null)
      {
        this.TMCLList.Items.Remove(this.TMCLList.FocusedItem);
        this.txtMusicianInst.Text = "";
        this.txtMusicianName.Text = "";
      }
    }

    private void btnRemovePicture_Click(object sender, EventArgs e)
    {
      try
      {
        this.PicList.Items.Remove(this.PicList.FocusedItem);
        this.txtPDescriptor.Text = "";
        this.txtPicPath.Text = "";
        this.chkPicInclude.Checked = false;
        this.chkPicInclude.Enabled = true;
        this.chkPicRelativPath.Checked = false;
        this.APICView.Image = null;
        this.cmbPicType.SelectedIndex = 0;
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
      this.btnAddPicture.Enabled = false;
    }

    private void btnRemoveRating_Click(object sender, EventArgs e)
    {
      try
      {
        this.RatingList.Items.Remove(this.RatingList.FocusedItem);
        this.txtRatingUser.Text = "";
        this.txtRatingRating.Value = decimal.Zero;
        this.txtRatingCounter.Value = decimal.Zero;
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
    }

    private void btnRemoveTXXX_Click(object sender, EventArgs e)
    {
      try
      {
        this.TXXXList.Items.Remove(this.TXXXList.FocusedItem);
        this.txtTXXXDesc.Text = "";
        this.txtTXXXContent.Text = "";
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
    }

    private void btnRemoveWXXX_Click(object sender, EventArgs e)
    {
      try
      {
        this.WXXXList.Items.Remove(this.WXXXList.FocusedItem);
        this.txtWXXXDesc.Text = "";
        this.txtWXXXContent.Text = "";
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
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

    private void chkPicInclude_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkPicInclude.Checked)
      {
        this.chkPicRelativPath.Checked = false;
      }
    }

    private void chkPicRelativPath_CheckedChanged(object sender, EventArgs e)
    {
      if (this.chkPicRelativPath.Checked)
      {
        this.chkPicInclude.Checked = false;
      }
    }

    private void frmTAG2Multi_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);
      this.panDetail.Enabled = false;
      this.panOriginal.Enabled = false;
      this.panWeb.Enabled = false;
      this.panRating.Enabled = false;
      this.panPic.Enabled = false;
      this.panLyrics.Enabled = false;
      this.panInvolved.Enabled = false;
      this.panUser.Enabled = false;
      this.panMain.Dock = DockStyle.Fill;
      this.TopPanel.Text = StringType.FromObject(Declarations.objResources.SelectionBar["TAGV2ButtonItem1"]);
      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
      {
        this.cmbArtist.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
      foreach (DataRow row in Declarations.objSettings.CommDescriptors.Rows)
      {
        this.cmbCDescriptor.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
      if (Declarations.objSettings.OwnGenreOnly)
      {
        foreach (DataRow row in Declarations.objSettings.Genres.Rows)
        {
          this.cmbGenre.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
        }
      }
      else
      {
        foreach (DataRow row in Declarations.objSettings.Genres.Rows)
        {
          this.cmbGenre.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
        }
        foreach (string str in Declarations.astrGenreLookup)
        {
          this.cmbGenre.Items.Add(str);
        }
      }
      this.cmbGenre.Sorted = true;
      this.cmbGenre.Sorted = false;
      foreach (string str in Declarations.astrLanLookup)
      {
        this.cmbCLanguage.Items.Add(str);
        this.cmbLLanguage.Items.Add(str);
      }
      this.cmbCLanguage.SelectedIndex = Declarations.objSettings.V2Language;
      this.cmbLLanguage.SelectedIndex = Declarations.objSettings.V2Language;
      switch (this.YearFormat.Value)
      {
        case 0:
          this.txtYear.Mask = "####";
          this.txtTORY.Mask = "####";
          break;

        case 1:
          this.txtYear.Mask = "####-##";
          this.txtTORY.Mask = "####-##";
          break;

        case 2:
          this.txtYear.Mask = "####-##-##";
          this.txtTORY.Mask = "####-##-##";
          break;
      }
      this.CheckBox8.Checked = false;
      this.cmbPicType.SelectedIndex = 0;
      this.txtDigits.Value = new decimal(Declarations.objSettings.TracknumberDigitsTAG);
      if (Declarations.objSettings.SingleGC)
      {
        this.btnAddGenre.Visible = false;
        this.btnRemoveGenre.Visible = false;
        this.btnMoveGenre.Visible = false;
        this.GenreList.Visible = false;
        this.btnAddComment.Visible = false;
        this.btnRemoveComment.Visible = false;
        this.btnMoveComment.Visible = false;
        this.CommentList.Visible = false;
        this.lblGenreInfo.Visible = false;
        this.CheckBox10.Visible = false;
        this.CheckBox38.Visible = true;
      }
      this.FillForm();
      this.AddSelectionBar();
      this.AddToolTips();
      this.AddColumnText();
      this.TAGV2grpTAG.Expanded = true;
      this.TAGV2grpCommands.Expanded = true;
      this.cmbArtist.Select();
      this.cmbArtist.Focus();
    }

    private void LyricsList_Click(object sender, EventArgs e)
    {
      if (this.LyricsList.FocusedItem == null)
      {
        return;
      }
      this.txtLDescriptor.Text = this.LyricsList.FocusedItem.Text;
      var enumerator = this.cmbLLanguage.Items.GetEnumerator();
      while (enumerator.MoveNext())
      {
        string str = StringType.FromObject(enumerator.Current);
        if (str.StartsWith(this.LyricsList.FocusedItem.SubItems[2].Text))
        {
          this.cmbLLanguage.SelectedItem = str;
          goto Label_0099;
        }
      }
      Label_0099:
      this.txtLyrics.Text = this.LyricsList.FocusedItem.SubItems[1].Text.Replace("\n", "\r\n");
    }

    private void Multi2CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        object objectValue = null;
        object[] objArray;
        bool[] flagArray;
        object[] objArray3;
        object[] objArray4;
        object[] objArray5;
        string str12;
        string[] strArray;
        object[] objArray6;
        object obj4;
        bool[] flagArray2;
        object[] objArray8;
        object[] objArray9;
        string str13;
        string[] strArray2;
        object obj5;
        object[] objArray11;
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        MP3 tag = (MP3)item.Tag;
        V2TAG vtag = tag.V2TAG.Clone();
        frmProg.Infos.Text = tag.CurrentFullName;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        if (this.chkTLEN.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TLEN", tag.DurationMS.ToString());
          if (tag.DurationMS == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox1.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TPE1", this.CheckReplace(vtag, this.cmbArtist.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          if (Declarations.objSettings.SynchronizeTAGs && (ObjectType.ObjTst(tag.V1TAG.Artist, LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), false) != 0))
          {
            tag.V1TAG.Artist = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null));
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
        }
        if (this.CheckBox2.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TIT2", this.CheckReplace(vtag, this.txtTitle.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          if (Declarations.objSettings.SynchronizeTAGs && (ObjectType.ObjTst(tag.V1TAG.Title, LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), false) != 0))
          {
            tag.V1TAG.Title = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null));
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
        }
        if (this.CheckBox3.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TALB", this.CheckReplace(vtag, this.txtAlbum.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          if (Declarations.objSettings.SynchronizeTAGs && (ObjectType.ObjTst(tag.V1TAG.Album, LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), false) != 0))
          {
            tag.V1TAG.Album = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null));
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
        }
        if (this.CheckBox4.Checked)
        {
          if (StringType.StrCmp(this.txtYear.Text, "", false) != 0)
          {
            if (!tag.V2TAG.TAGHeaderPresent)
            {
              tag.V2TAG.TAGHeaderPresent = true;
            }
            if (tag.V2TAG.TAGVersion == DoubleType.FromString("3"))
            {
              switch (this.YearFormat.Value)
              {
                case 0:
                  objectValue = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text);
                  tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                  objectValue = ID3Functions.CreateTextFrame("TDAT", "0000");
                  LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
                  tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                  break;

                case 1:
                  objectValue = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text.Substring(0, 4));
                  tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                  objectValue = ID3Functions.CreateTextFrame("TDAT", "01" + this.txtYear.Text.Substring(5, 2).PadLeft(2, '0'));
                  tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                  break;

                case 2:
                  objectValue = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text.Substring(0, 4));
                  tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                  objectValue = ID3Functions.CreateTextFrame("TDAT", this.txtYear.Text.Substring(8, 2).PadLeft(2, '0') + this.txtYear.Text.Substring(5, 2).PadLeft(2, '0'));
                  tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                  break;
              }
            }
            else
            {
              objectValue = ID3Functions.CreateTextFrame("TDRC", this.txtYear.Text);
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
            }
          }
          else if (tag.V2TAG.TAGVersion == DoubleType.FromString("3"))
          {
            objectValue = ID3Functions.CreateTextFrame("TYER", "0000");
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
            objectValue = ID3Functions.CreateTextFrame("TDAT", "0000");
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          else
          {
            objectValue = ID3Functions.CreateTextFrame("TDRC", "0000");
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            if (StringType.StrCmp(this.txtYear.Text, "", false) != 0)
            {
              if (StringType.StrCmp(tag.V1TAG.Year.ToString(), this.txtYear.Text.Substring(0, 4), false) != 0)
              {
                tag.V1TAG.Year = (int)Math.Round(Conversion.Val(this.txtYear.Text.Substring(0, 4)));
                tag.V1TAG.TAGPresent = true;
                tag.Changed = true;
              }
            }
            else if (tag.V1TAG.Year != 0)
            {
              tag.V1TAG.Year = 0;
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
          }
        }
        if (this.CheckBox39.Checked)
        {
          if (StringType.StrCmp(this.txtTORY.Text, "", false) != 0)
          {
            if (!tag.V2TAG.TAGHeaderPresent)
            {
              tag.V2TAG.TAGHeaderPresent = true;
            }
            if (tag.V2TAG.TAGVersion == DoubleType.FromString("3"))
            {
              objectValue = ID3Functions.CreateTextFrame("TORY", this.txtTORY.Text.PadLeft(4, '0').Substring(0, 4));
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
            }
            else
            {
              objectValue = ID3Functions.CreateTextFrame("TDOR", this.txtTORY.Text);
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
            }
          }
          else if (tag.V2TAG.TAGVersion == DoubleType.FromString("3"))
          {
            objectValue = ID3Functions.CreateTextFrame("TORY", "0000");
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          else
          {
            objectValue = ID3Functions.CreateTextFrame("TDOR", "0000");
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
        }
        if (this.CheckBox5.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TMED", this.cmbMedia.Text);
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox6.Checked)
        {
          if ((StringType.StrCmp(this.txtTrack1.Text, "", false) == 0) & (StringType.StrCmp(this.txtTrack2.Text, "", false) == 0))
          {
            objectValue = ID3Functions.CreateTextFrame("TRCK", "0".PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          else
          {
            string sLeft = "";
            if (tag.V2TAG.FrameExists("TRCK"))
            {
              sLeft = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null));
            }
            if (StringType.StrCmp(sLeft, "", false) == 0)
            {
              if (StringType.StrCmp(this.txtTrack1.Text, "", false) != 0)
              {
                if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
                {
                  objectValue = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtTrack2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
                else
                {
                  objectValue = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
              }
              else if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
              {
                objectValue = ID3Functions.CreateTextFrame("TRCK", "/" + this.txtTrack2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
              }
            }
            else if (sLeft.IndexOf("/") < 0)
            {
              if (StringType.StrCmp(this.txtTrack1.Text, "", false) != 0)
              {
                if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
                {
                  objectValue = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtTrack2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
                else
                {
                  objectValue = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
              }
              else if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
              {
                objectValue = ID3Functions.CreateTextFrame("TRCK", sLeft.Trim(new char[] { ' ' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtTrack2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
              }
            }
            else
            {
              string str5 = "";
              string str4 = "";
              if (!sLeft.StartsWith("/"))
              {
                str5 = sLeft.Substring(0, sLeft.IndexOf("/"));
              }
              if (!sLeft.EndsWith("/"))
              {
                str4 = sLeft.Substring(sLeft.IndexOf("/"));
              }
              if (StringType.StrCmp(this.txtTrack1.Text, "", false) != 0)
              {
                if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
                {
                  objectValue = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtTrack2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
                else
                {
                  objectValue = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + str4);
                }
              }
              else if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
              {
                objectValue = ID3Functions.CreateTextFrame("TRCK", str5.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtTrack2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
              }
            }
            if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
            {
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))) == 0.0)
              {
                LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
              }
            }
            else
            {
              objArray9 = new object[2];
              objArray9[0] = 0;
              obj5 = objectValue;
              object[] args = new object[0];
              strArray2 = null;
              objArray11 = new object[1];
              str13 = "/";
              objArray11[0] = str13;
              objArray9[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj5, null, "Content", args, strArray2, null), null, "IndexOf", objArray11, null, null));
              objArray8 = objArray9;
              flagArray2 = new bool[] { false, true };
              if (flagArray2[1])
              {
                LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", args, strArray2, null), null, "IndexOf", new object[] { str13, RuntimeHelpers.GetObjectValue(objArray8[1]) }, null, true, true);
              }
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray8, null, flagArray2))) == 0.0)
              {
                objArray = new object[1];
                objArray4 = new object[1];
                obj4 = objectValue;
                objArray6 = new object[0];
                strArray = null;
                objArray5 = new object[1];
                str12 = "/";
                objArray5[0] = str12;
                objArray4[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray6, strArray, null), null, "IndexOf", objArray5, null, null));
                objArray3 = objArray4;
                flagArray = new bool[] { true };
                if (flagArray[0])
                {
                  LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray6, strArray, null), null, "IndexOf", new object[] { str12, RuntimeHelpers.GetObjectValue(objArray3[0]) }, null, true, true);
                }
                objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray3, null, flagArray));
                LateBinding.LateSet(objectValue, null, "Content", objArray, null);
              }
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", new object[] { ObjectType.AddObj(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 1) }, null, null))) == 0.0)
              {
                objArray8 = new object[1];
                objArray5 = new object[2];
                objArray5[0] = 0;
                obj4 = objectValue;
                objArray3 = new object[0];
                strArray = null;
                objArray4 = new object[1];
                str12 = "/";
                objArray4[0] = str12;
                objArray5[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray3, strArray, null), null, "IndexOf", objArray4, null, null));
                objArray6 = objArray5;
                flagArray = new bool[] { false, true };
                if (flagArray[1])
                {
                  LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray3, strArray, null), null, "IndexOf", new object[] { str12, RuntimeHelpers.GetObjectValue(objArray6[1]) }, null, true, true);
                }
                objArray8[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray6, null, flagArray));
                LateBinding.LateSet(objectValue, null, "Content", objArray8, null);
              }
              if (ObjectType.ObjTst(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), "/", false) == 0)
              {
                LateBinding.LateSet(objectValue, null, "remove", new object[] { true }, null);
              }
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          if ((Declarations.objSettings.SynchronizeTAGs && (Conversion.Val(this.txtTrack1.Text) <= 255.0)) && (tag.V1TAG.Tracknumber != Conversion.Val(this.txtTrack1.Text)))
          {
            tag.V1TAG.Tracknumber = (byte)Math.Round(Conversion.Val(this.txtTrack1.Text));
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
        }
        if (this.CheckBox7.Checked)
        {
          if ((StringType.StrCmp(this.txtPOS1.Text, "", false) == 0) & (StringType.StrCmp(this.txtPOS2.Text, "", false) == 0))
          {
            objectValue = ID3Functions.CreateTextFrame("TPOS", "0".PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          else
          {
            string str6 = "";
            if (tag.V2TAG.FrameExists("TPOS"))
            {
              str6 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPOS"), null, "Content", new object[0], null, null));
            }
            if (StringType.StrCmp(str6, "", false) == 0)
            {
              if (StringType.StrCmp(this.txtPOS1.Text, "", false) != 0)
              {
                if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
                {
                  objectValue = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtPOS2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
                else
                {
                  objectValue = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
              }
              else if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
              {
                objectValue = ID3Functions.CreateTextFrame("TPOS", "/" + this.txtPOS2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
              }
            }
            else if (str6.IndexOf("/") < 0)
            {
              if (StringType.StrCmp(this.txtPOS1.Text, "", false) != 0)
              {
                if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
                {
                  objectValue = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtPOS2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
                else
                {
                  objectValue = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
              }
              else if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
              {
                objectValue = ID3Functions.CreateTextFrame("TPOS", str6.Trim(new char[] { ' ' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtPOS2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
              }
            }
            else
            {
              string str8 = "";
              string str7 = "";
              if (!str6.StartsWith("/"))
              {
                str8 = str6.Substring(0, str6.IndexOf("/"));
              }
              if (!str6.EndsWith("/"))
              {
                str7 = str6.Substring(str6.IndexOf("/"));
              }
              if (StringType.StrCmp(this.txtPOS1.Text, "", false) != 0)
              {
                if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
                {
                  objectValue = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtPOS2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
                }
                else
                {
                  objectValue = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + str7);
                }
              }
              else if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
              {
                objectValue = ID3Functions.CreateTextFrame("TPOS", str8.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtPOS2.Text.PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
              }
            }
            if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
            {
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))) == 0.0)
              {
                LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
              }
            }
            else
            {
              objArray3 = new object[2];
              objArray3[0] = 0;
              obj4 = objectValue;
              objArray = new object[0];
              strArray = null;
              object[] objArray2 = new object[1];
              str12 = "/";
              objArray2[0] = str12;
              objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray, strArray, null), null, "IndexOf", objArray2, null, null));
              objArray4 = objArray3;
              flagArray = new bool[] { false, true };
              if (flagArray[1])
              {
                LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray, strArray, null), null, "IndexOf", new object[] { str12, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);
              }
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray))) == 0.0)
              {
                objArray11 = new object[1];
                objArray8 = new object[1];
                obj5 = objectValue;
                objArray6 = new object[0];
                strArray2 = null;
                object[] objArray7 = new object[1];
                str13 = "/";
                objArray7[0] = str13;
                objArray8[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj5, null, "Content", objArray6, strArray2, null), null, "IndexOf", objArray7, null, null));
                objArray9 = objArray8;
                flagArray2 = new bool[] { true };
                if (flagArray2[0])
                {
                  LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", objArray6, strArray2, null), null, "IndexOf", new object[] { str13, RuntimeHelpers.GetObjectValue(objArray9[0]) }, null, true, true);
                }
                objArray11[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray9, null, flagArray2));
                LateBinding.LateSet(objectValue, null, "Content", objArray11, null);
              }
              if (Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", new object[] { ObjectType.AddObj(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 1) }, null, null))) == 0.0)
              {
                objArray8 = new object[1];
                objArray5 = new object[2];
                objArray5[0] = 0;
                obj4 = objectValue;
                objArray3 = new object[0];
                strArray = null;
                objArray4 = new object[1];
                str12 = "/";
                objArray4[0] = str12;
                objArray5[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray3, strArray, null), null, "IndexOf", objArray4, null, null));
                objArray6 = objArray5;
                flagArray = new bool[] { false, true };
                if (flagArray[1])
                {
                  LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray3, strArray, null), null, "IndexOf", new object[] { str12, RuntimeHelpers.GetObjectValue(objArray6[1]) }, null, true, true);
                }
                objArray8[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray6, null, flagArray));
                LateBinding.LateSet(objectValue, null, "Content", objArray8, null);
              }
              if (ObjectType.ObjTst(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), "/", false) == 0)
              {
                LateBinding.LateSet(objectValue, null, "remove", new object[] { true }, null);
              }
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
        }
        if (this.CheckBox8.Checked)
        {
          if (StringType.StrCmp(this.txtBPM.Text, "", false) == 0)
          {
            objectValue = ID3Functions.CreateTextFrame("TBPM", this.txtBPM.Text);
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          else
          {
            objectValue = ID3Functions.CreateTextFrame("TBPM", this.txtBPM.Text);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox9.Checked)
        {
          string text;
          if (!Declarations.objSettings.SingleGC)
          {
            text = "";
            var enumerator15 = this.GenreList.Items.GetEnumerator();
            while (enumerator15.MoveNext())
            {
              string vstrEntry = StringType.FromObject(enumerator15.Current);
              text = text + this.CheckReplace(vtag, vstrEntry) + "\0";
            }
            if (text.EndsWith("\0"))
            {
              text = text.Substring(0, text.Length - 1);
            }
            objectValue = ID3Functions.CreateTextFrame("TCON", text);
            if (StringType.StrCmp(text, "", false) == 0)
            {
              LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          else
          {
            text = this.cmbGenre.Text;
            objectValue = ID3Functions.CreateTextFrame("TCON", this.CheckReplace(vtag, text));
            if (StringType.StrCmp(text, "", false) == 0)
            {
              LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            if (tag.V2TAG.FrameExists("TCON"))
            {
              string sRight = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null));
              bool flag = false;
              if (sRight.IndexOf('\0') > 0)
              {
                sRight = sRight.Substring(0, sRight.IndexOf('\0'));
              }
              foreach (DataRow row in Declarations.objSettings.Genres.Rows)
              {
                if (StringType.StrCmp(row["Name"].ToString().ToLower(), sRight.ToLower(), false) == 0)
                {
                  if (ObjectType.ObjTst(tag.V1TAG.GenreByte, row["V2V1"], false) != 0)
                  {
                    tag.V1TAG.GenreByte = ByteType.FromObject(row["V2V1"]);
                    flag = true;
                    tag.Changed = true;
                  }
                  break;
                }
              }
              if (!flag & (StringType.StrCmp(tag.V1TAG.GenreText, sRight, false) != 0))
              {
                tag.V1TAG.GenreText = sRight;
                tag.Changed = true;
              }
            }
            else
            {
              if (tag.V1TAG.GenreByte != 0xff)
              {
                tag.Changed = true;
              }
              tag.V1TAG.GenreByte = 0xff;
            }
          }
        }
        if (this.CheckBox44.Checked)
        {
          if (this.TIPLList.Items.Count > 0)
          {
            if (!tag.V2TAG.TAGHeaderPresent)
            {
              tag.V2TAG.TAGHeaderPresent = true;
            }
            string vstrContent = "";
            foreach (ListViewItem item3 in this.TIPLList.Items)
            {
              vstrContent = vstrContent + item3.Text + "\0" + this.CheckReplace(vtag, item3.SubItems[1].Text) + "\0";
            }
            vstrContent = vstrContent.TrimEnd(new char[] { '\0' });
            if (tag.V2TAG.TAGVersion == DoubleType.FromString("3"))
            {
              objectValue = ID3Functions.CreateTextFrame("IPLS", vstrContent);
              if (StringType.StrCmp(vstrContent, "", false) == 0)
              {
                LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
              }
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
            }
            else
            {
              objectValue = ID3Functions.CreateTextFrame("TIPL", vstrContent);
              if (StringType.StrCmp(vstrContent, "", false) == 0)
              {
                LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
              }
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
            }
          }
          else if (tag.V2TAG.TAGHeaderPresent)
          {
            if (tag.V2TAG.TAGVersion == DoubleType.FromString("3"))
            {
              objectValue = ID3Functions.CreateTextFrame("IPLS", "");
              LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
            }
            else
            {
              objectValue = ID3Functions.CreateTextFrame("TIPL", "");
              LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
            }
          }
        }
        if (this.CheckBox45.Checked)
        {
          if (this.TMCLList.Items.Count > 0)
          {
            if (!tag.V2TAG.TAGHeaderPresent)
            {
              tag.V2TAG.TAGHeaderPresent = true;
            }
            string str11 = "";
            foreach (ListViewItem item4 in this.TMCLList.Items)
            {
              str11 = str11 + item4.Text + "\0" + this.CheckReplace(vtag, item4.SubItems[1].Text) + "\0";
            }
            str11 = str11.TrimEnd(new char[] { '\0' });
            if (tag.V2TAG.TAGVersion == DoubleType.FromString("4"))
            {
              objectValue = ID3Functions.CreateTextFrame("TMCL", str11);
              if (StringType.StrCmp(str11, "", false) == 0)
              {
                LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
              }
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
            }
          }
          else if (tag.V2TAG.TAGHeaderPresent && (tag.V2TAG.TAGVersion == DoubleType.FromString("4")))
          {
            objectValue = ID3Functions.CreateTextFrame("TMCL", "");
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
        }
        if (this.CheckBox11.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TPE2", this.CheckReplace(vtag, this.txtBand.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox12.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TPE3", this.CheckReplace(vtag, this.txtConductor.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox13.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TPE4", this.CheckReplace(vtag, this.txtModified.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox15.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TIT1", this.CheckReplace(vtag, this.txtContent.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox16.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TIT3", this.CheckReplace(vtag, this.txtSubTitle.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox14.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TCOM", this.CheckReplace(vtag, this.txtComposer.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox17.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TEXT", this.CheckReplace(vtag, this.txtLyWriter.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox18.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TPUB", this.CheckReplace(vtag, this.txtPublisher.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox19.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TENC", this.CheckReplace(vtag, this.txtEncoded.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox40.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TCOP", this.CheckReplace(vtag, this.txtCopyright.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (((tag.V2TAG.TAGVersion == 0) & (Declarations.objSettings.NewV2Version == 4)) | (tag.V2TAG.TAGVersion == 4))
        {
          if (this.CheckBox42.Checked)
          {
            objectValue = ID3Functions.CreateTextFrame("TSOA", this.CheckReplace(vtag, this.txtSortAlbum.Text));
            if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
            {
              LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          if (this.CheckBox43.Checked)
          {
            objectValue = ID3Functions.CreateTextFrame("TSOP", this.CheckReplace(vtag, this.txtSortArtist.Text));
            if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
            {
              LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          if (this.CheckBox41.Checked)
          {
            objectValue = ID3Functions.CreateTextFrame("TSOT", this.CheckReplace(vtag, this.txtSortTitle.Text));
            if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
            {
              LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
        }
        if (this.CheckBox20.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TOAL", this.CheckReplace(vtag, this.txtOAlbum.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox21.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TOFN", this.CheckReplace(vtag, this.txtOFilename.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox23.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TOPE", this.CheckReplace(vtag, this.txtOArtist.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox22.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TOLY", this.CheckReplace(vtag, this.txtOLyWriter.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox24.Checked)
        {
          objectValue = ID3Functions.CreateTextFrame("TOWN", this.CheckReplace(vtag, this.txtOOwner.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox25.Checked)
        {
          objectValue = ID3Functions.CreateWebFrame("WCOP", this.CheckReplace(vtag, this.txtCopyInfURL.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox26.Checked)
        {
          objectValue = ID3Functions.CreateWebFrame("WOAF", this.CheckReplace(vtag, this.txtAudioFileURL.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox27.Checked)
        {
          objectValue = ID3Functions.CreateWebFrame("WOAR", this.CheckReplace(vtag, this.txtArtistURL.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox28.Checked)
        {
          objectValue = ID3Functions.CreateWebFrame("WOAS", this.CheckReplace(vtag, this.txtAudioSRCURL.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox29.Checked)
        {
          objectValue = ID3Functions.CreateWebFrame("WORS", this.CheckReplace(vtag, this.txtINetRadioURL.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox30.Checked)
        {
          objectValue = ID3Functions.CreateWebFrame("WPAY", this.CheckReplace(vtag, this.txtPayURL.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox31.Checked)
        {
          objectValue = ID3Functions.CreateWebFrame("WPUB", this.CheckReplace(vtag, this.txtPubURL.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox32.Checked)
        {
          objectValue = ID3Functions.CreateWebFrame("WCOM", this.CheckReplace(vtag, this.txtCOMMInfURL.Text));
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), "", false) == 0)
          {
            LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
        if (this.CheckBox10.Checked & tag.V2TAG.FrameExists("COMM"))
        {
          tag.V2TAG.RemoveFrames("COMM");
          tag.V2TAG.Changed = true;
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            if (StringType.StrCmp(tag.V1TAG.Comment, "", false) != 0)
            {
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
            tag.V1TAG.Comment = "";
          }
        }
        if (!Declarations.objSettings.SingleGC)
        {
          if (this.vbooCommentMoved)
          {
            ArrayList alstFrames = new ArrayList();
            foreach (ListViewItem item5 in this.CommentList.Items)
            {
              alstFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(item5.Tag, null, "Clone", new object[0], null, null)));
            }
            tag.V2TAG.RemoveFrames("COMM");
            tag.V2TAG.AddFrames(alstFrames);
          }
          foreach (ListViewItem item2 in this.CommentList.Items)
          {
            V2LDCFrame frame = new V2LDCFrame
            {
              FID = "COMM",
              Descriptor = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null)),
              Content = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null)),
              Language = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Language", new object[0], null, null))
            };
            if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null), item2.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null), this.CheckReplace(vtag, item2.SubItems[1].Text), false) != 0)))
            {
              frame.Descriptor = item2.Text;
              frame.Content = this.CheckReplace(vtag, item2.SubItems[1].Text);
              tag.V2TAG.Changed = true;
            }
            if (!item2.Checked)
            {
              frame.Remove = true;
            }
            if (StringType.StrCmp(frame.Content, "", false) == 0)
            {
              frame.Remove = true;
            }
            tag.V2TAG.AddFrame(frame);
          }
          if ((Declarations.objSettings.SynchronizeTAGs && (this.CommentList.CheckedItems.Count > 0)) && (ObjectType.ObjTst(tag.V1TAG.Comment, LateBinding.LateGet(this.CommentList.CheckedItems[0].Tag, null, "Content", new object[0], null, null), false) != 0))
          {
            tag.V1TAG.Comment = StringType.FromObject(LateBinding.LateGet(this.CommentList.CheckedItems[0].Tag, null, "Content", new object[0], null, null));
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
        }
        else if (this.CheckBox38.Checked)
        {
          if (StringType.StrCmp(this.txtComment.Text, "", false) != 0)
          {
            V2LDCFrame frame2 = new V2LDCFrame
            {
              FID = "COMM",
              Descriptor = this.cmbCDescriptor.Text,
              Content = this.CheckReplace(vtag, this.txtComment.Text.Replace("\r\n", "\n")),
              Language = this.cmbCLanguage.Text.Substring(0, 3)
            };
            if (StringType.StrCmp(frame2.Content, "", false) == 0)
            {
              frame2.Remove = true;
            }
            if (tag.V2TAG.GetFrames("COMM").Count > 1)
            {
              tag.V2TAG.RemoveFrames("COMM");
              tag.V2TAG.AddFrame(frame2);
            }
            else
            {
              tag.V2TAG.AddFrame(frame2);
            }
          }
          else if (tag.V2TAG.FrameExists("COMM"))
          {
            tag.V2TAG.RemoveFrames("COMM");
            tag.V2TAG.Changed = true;
          }
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            if (StringType.StrCmp(this.txtComment.Text, "", false) != 0)
            {
              if (StringType.StrCmp(tag.V1TAG.Comment, this.txtComment.Text, false) != 0)
              {
                tag.V1TAG.Comment = this.txtComment.Text;
                tag.V1TAG.TAGPresent = true;
                tag.Changed = true;
              }
            }
            else
            {
              if (StringType.StrCmp(tag.V1TAG.Comment, "", false) != 0)
              {
                tag.V1TAG.TAGPresent = true;
                tag.Changed = true;
              }
              tag.V1TAG.Comment = "";
            }
          }
        }
        if (this.CheckBox35.Checked & tag.V2TAG.FrameExists("USLT"))
        {
          tag.V2TAG.RemoveFrames("USLT");
          tag.V2TAG.Changed = true;
        }
        if (this.vbooLyricsMoved)
        {
          ArrayList list2 = new ArrayList();
          foreach (ListViewItem item6 in this.LyricsList.Items)
          {
            list2.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(item6.Tag, null, "Clone", new object[0], null, null)));
          }
          tag.V2TAG.RemoveFrames("USLT");
          tag.V2TAG.AddFrames(list2);
        }
        if (this.CheckBox33.Checked & tag.V2TAG.FrameExists("POPM"))
        {
          tag.V2TAG.RemoveFrames("POPM");
          tag.V2TAG.Changed = true;
        }
        if (this.vbooRatingMoved)
        {
          ArrayList list3 = new ArrayList();
          foreach (ListViewItem item7 in this.RatingList.Items)
          {
            list3.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(item7.Tag, null, "Clone", new object[0], null, null)));
          }
          tag.V2TAG.RemoveFrames("POPM");
          tag.V2TAG.AddFrames(list3);
        }
        foreach (ListViewItem item2 in this.LyricsList.Items)
        {
          V2LDCFrame frame3 = new V2LDCFrame
          {
            FID = "USLT",
            Descriptor = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null)),
            Content = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null)),
            Language = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Language", new object[0], null, null))
          };
          if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null), item2.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null), this.CheckReplace(vtag, item2.SubItems[1].Text), false) != 0)))
          {
            frame3.Descriptor = item2.Text;
            frame3.Content = this.CheckReplace(vtag, item2.SubItems[1].Text);
            tag.V2TAG.Changed = true;
          }
          if (!item2.Checked)
          {
            frame3.Remove = true;
          }
          if (StringType.StrCmp(frame3.Content, "", false) == 0)
          {
            frame3.Remove = true;
          }
          tag.V2TAG.AddFrame(frame3);
        }
        foreach (ListViewItem item2 in this.RatingList.Items)
        {
          V2POPMFrame frame4 = new V2POPMFrame
          {
            FID = "POPM",
            User = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "User", new object[0], null, null)),
            Rating = ByteType.FromObject(LateBinding.LateGet(item2.Tag, null, "Rating", new object[0], null, null)),
            Counter = IntegerType.FromObject(LateBinding.LateGet(item2.Tag, null, "Counter", new object[0], null, null))
          };
          if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "User", new object[0], null, null), item2.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Rating", new object[0], null, null), Convert.ToByte(item2.SubItems[1].Text), false) != 0), ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Counter", new object[0], null, null), Convert.ToInt32(item2.SubItems[2].Text), false) != 0)))
          {
            frame4.User = item2.Text;
            frame4.Rating = Convert.ToByte(item2.SubItems[1].Text);
            frame4.Counter = Convert.ToInt32(item2.SubItems[2].Text);
            tag.V2TAG.Changed = true;
          }
          if (!item2.Checked)
          {
            frame4.Remove = true;
          }
          tag.V2TAG.AddFrame(frame4);
        }
        if (this.CheckBox34.Checked & tag.V2TAG.FrameExists("APIC"))
        {
          tag.V2TAG.RemoveFrames("APIC");
          tag.V2TAG.Changed = true;
        }
        foreach (ListViewItem item2 in this.PicList.Items)
        {
          V2APICFrame frame5 = (V2APICFrame)LateBinding.LateGet(item2.Tag, null, "Clone", new object[0], null, null);
          Directory.SetCurrentDirectory(Path.GetDirectoryName(tag.FI.FullName));
          if (!item2.Checked)
          {
            frame5.Remove = true;
          }
          if (item2.Font.Style == FontStyle.Bold)
          {
            frame5.Path = Id3TagIT_Main.GetRelativePath(Path.GetDirectoryName(tag.FI.FullName), frame5.Path);
          }
          else
          {
            frame5.Path = Path.GetFullPath(frame5.Path);
          }
          tag.V2TAG.AddFrame(frame5);
          frame5 = null;
        }
        if (this.CheckBox36.Checked & tag.V2TAG.FrameExists("TXXX"))
        {
          tag.V2TAG.RemoveFrames("TXXX");
          tag.V2TAG.Changed = true;
        }
        foreach (ListViewItem item2 in this.TXXXList.Items)
        {
          V2TXXXFrame frame6 = new V2TXXXFrame
          {
            FID = "TXXX",
            Descriptor = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null)),
            Content = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null))
          };
          if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null), item2.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null), this.CheckReplace(vtag, item2.SubItems[1].Text), false) != 0)))
          {
            frame6.Descriptor = item2.Text;
            frame6.Content = this.CheckReplace(vtag, item2.SubItems[1].Text);
            tag.V2TAG.Changed = true;
          }
          if (!item2.Checked)
          {
            frame6.Remove = true;
          }
          if (StringType.StrCmp(frame6.Content, "", false) == 0)
          {
            frame6.Remove = true;
          }
          tag.V2TAG.AddFrame(frame6);
        }
        if (this.CheckBox37.Checked & tag.V2TAG.FrameExists("WXXX"))
        {
          tag.V2TAG.RemoveFrames("WXXX");
          tag.V2TAG.Changed = true;
        }
        foreach (ListViewItem item2 in this.WXXXList.Items)
        {
          V2WXXXFrame frame7 = new V2WXXXFrame
          {
            FID = "WXXX",
            Descriptor = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null)),
            Content = StringType.FromObject(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null))
          };
          if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null), item2.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null), this.CheckReplace(vtag, item2.SubItems[1].Text), false) != 0)))
          {
            frame7.Descriptor = item2.Text;
            frame7.Content = this.CheckReplace(vtag, item2.SubItems[1].Text);
            tag.V2TAG.Changed = true;
          }
          if (!item2.Checked)
            frame7.Remove = true;
          if (StringType.StrCmp(frame7.Content, "", false) == 0)
            frame7.Remove = true;
          tag.V2TAG.AddFrame(frame7);
        }
        if (this.chkRemoveAllNOT.Checked)
        {
          ArrayList list4 = new ArrayList();
          var enumerator2 = tag.V2TAG.GetAllSupportedFrames().GetEnumerator();
          while (enumerator2.MoveNext())
          {
            objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
            object obj3 = LateBinding.LateGet(objectValue, null, "FID", new object[0], null, null);
            if (((((((ObjectType.ObjTst(obj3, "TPE1", false) != 0) && (ObjectType.ObjTst(obj3, "TPE2", false) != 0)) && ((ObjectType.ObjTst(obj3, "TPE3", false) != 0) && (ObjectType.ObjTst(obj3, "TPE4", false) != 0))) && (((ObjectType.ObjTst(obj3, "TIT1", false) != 0) && (ObjectType.ObjTst(obj3, "TIT2", false) != 0)) && ((ObjectType.ObjTst(obj3, "TIT3", false) != 0) && (ObjectType.ObjTst(obj3, "TALB", false) != 0)))) && ((((ObjectType.ObjTst(obj3, "TRCK", false) != 0) && (ObjectType.ObjTst(obj3, "TBPM", false) != 0)) && ((ObjectType.ObjTst(obj3, "TCOM", false) != 0) && (ObjectType.ObjTst(obj3, "TCON", false) != 0))) && (((ObjectType.ObjTst(obj3, "TDAT", false) != 0) && (ObjectType.ObjTst(obj3, "TENC", false) != 0)) && ((ObjectType.ObjTst(obj3, "TMED", false) != 0) && (ObjectType.ObjTst(obj3, "TYER", false) != 0))))) && (((((ObjectType.ObjTst(obj3, "TEXT", false) != 0) && (ObjectType.ObjTst(obj3, "TPUB", false) != 0)) && ((ObjectType.ObjTst(obj3, "TOAL", false) != 0) && (ObjectType.ObjTst(obj3, "TOFN", false) != 0))) && (((ObjectType.ObjTst(obj3, "TOPE", false) != 0) && (ObjectType.ObjTst(obj3, "TDRC", false) != 0)) && ((ObjectType.ObjTst(obj3, "TPOS", false) != 0) && (ObjectType.ObjTst(obj3, "TORY", false) != 0)))) && ((((ObjectType.ObjTst(obj3, "TCOP", false) != 0) && (ObjectType.ObjTst(obj3, "TOLY", false) != 0)) && ((ObjectType.ObjTst(obj3, "TOWN", false) != 0) && (ObjectType.ObjTst(obj3, "TDOR", false) != 0))) && (((ObjectType.ObjTst(obj3, "WCOM", false) != 0) && (ObjectType.ObjTst(obj3, "WCOP", false) != 0)) && ((ObjectType.ObjTst(obj3, "WOAF", false) != 0) && (ObjectType.ObjTst(obj3, "WOAR", false) != 0)))))) && ((((((ObjectType.ObjTst(obj3, "WOAS", false) != 0) && (ObjectType.ObjTst(obj3, "WORS", false) != 0)) && ((ObjectType.ObjTst(obj3, "WPAY", false) != 0) && (ObjectType.ObjTst(obj3, "WPUB", false) != 0))) && (((ObjectType.ObjTst(obj3, "TSOA", false) != 0) && (ObjectType.ObjTst(obj3, "TSOP", false) != 0)) && ((ObjectType.ObjTst(obj3, "TSOT", false) != 0) && (ObjectType.ObjTst(obj3, "TIPL", false) != 0)))) && ((((ObjectType.ObjTst(obj3, "TMCL", false) != 0) && (ObjectType.ObjTst(obj3, "IPLS", false) != 0)) && ((ObjectType.ObjTst(obj3, "TLEN", false) != 0) && (ObjectType.ObjTst(obj3, "COMM", false) != 0))) && (((ObjectType.ObjTst(obj3, "USLT", false) != 0) && (ObjectType.ObjTst(obj3, "POPM", false) != 0)) && ((ObjectType.ObjTst(obj3, "TXXX", false) != 0) && (ObjectType.ObjTst(obj3, "WXXX", false) != 0))))) && (ObjectType.ObjTst(obj3, "APIC", false) != 0)))
            {
              LateBinding.LateSet(objectValue, null, "Remove", new object[] { true }, null);
              list4.Add(RuntimeHelpers.GetObjectValue(objectValue));
            }
          }
          var enumerator = list4.GetEnumerator();
          while (enumerator.MoveNext())
          {
            objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
          }
          tag.V2TAG.RemoveAllNotSupportedFrames();
        }
        if (tag.V2TAG.Changed)
        {
          if (!tag.V2TAG.TAGHeaderPresent)
          {
            tag.V2TAG.TAGHeaderPresent = true;
          }
          tag.Changed = true;
          this.MainForm.UpdateListItem(item, false);
        }
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void PicList_Click(object sender, EventArgs e)
    {
      V2APICFrame tag = (V2APICFrame)this.PicList.FocusedItem.Tag;
      try
      {
        this.APICView.Image = null;
        this.PicFStream.Close();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }
      try
      {
        this.APICView.Image = null;
        this.PicMStream.Close();
      }
      catch (Exception exception3)
      {
        ProjectData.SetProjectError(exception3);
        Exception exception2 = exception3;
        ProjectData.ClearProjectError();
      }
      if (this.PicList.FocusedItem != null)
      {
        this.txtPDescriptor.Text = this.PicList.FocusedItem.Text;
        this.cmbPicType.SelectedIndex = (int)Math.Round(Conversion.Val(this.PicList.FocusedItem.SubItems[1].Text.Substring(0, 2)));
        this.txtPicPath.Text = this.PicList.FocusedItem.SubItems[2].Text;
        this.chkPicInclude.Checked = Convert.ToBoolean(this.PicList.FocusedItem.SubItems[3].Text);
        this.chkPicInclude.Enabled = true;
        this.chkPicRelativPath.Checked = (this.PicList.FocusedItem.Font.Style & FontStyle.Bold) == FontStyle.Bold;
        if (File.Exists(this.PicList.FocusedItem.SubItems[2].Text))
        {
          FileStream stream = new FileStream(this.PicList.FocusedItem.SubItems[2].Text, FileMode.Open, FileAccess.Read);
          stream.Seek(0L, SeekOrigin.Begin);
          byte[] array = new byte[((int)(stream.Length - 1L)) + 1];
          stream.Read(array, 0, array.Length);
          this.PicMStream = new MemoryStream(array);
          this.APICView.Image = Image.FromStream(this.PicMStream);
          stream.Close();
        }
        else
        {
          this.APICView.Image = null;
        }
        this.btnAddPicture.Enabled = true;
      }
    }

    private void RatingList_Click(object sender, EventArgs e)
    {
      if (this.RatingList.FocusedItem != null)
      {
        this.txtRatingUser.Text = this.RatingList.FocusedItem.Text;
        this.txtRatingRating.Value = new decimal(Convert.ToByte(this.RatingList.FocusedItem.SubItems[1].Text));
        this.txtRatingCounter.Value = new decimal(Convert.ToInt32(this.RatingList.FocusedItem.SubItems[2].Text));
      }
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

    private void Select_Leave(object sender, EventArgs e)
    {
      MaskedTextBox tmpYear;

      if (((sender == this.txtRatingCounter) |
        (sender == this.txtRatingRating)) &&
        (ObjectType.ObjTst(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), "", false) == 0))
        LateBinding.LateSet(sender, null, "Text", new object[] { "0" }, null);

      if (sender == this.txtYear)
      {
        switch (this.YearFormat.Value)
        {
          case 0:
            this.txtYear.Mask = "0000";
            break;

          case 1:
            this.txtYear.Mask = "0000-00";

            if (this.txtYear.Text.Length < 7)
            {
              string str = DateTime.Now.Year.ToString() + "-01";
              tmpYear = this.txtYear;
              tmpYear.Text = tmpYear.Text + str.Substring(this.txtYear.Text.Length);
            }

            if ((Conversion.Val(this.txtYear.Text.Substring(5, 2)) > 12.0) | (Conversion.Val(this.txtYear.Text.Substring(5, 2)) < 1.0))
              this.txtYear.Text = this.txtYear.Text.Substring(0, 4) + "-01";

            break;

          case 2:
            this.txtYear.Mask = "0000-00-00";

            if (this.txtYear.Text.Length < 10)
            {
              string str2 = DateTime.Now.Year.ToString() + "-01-01";
              tmpYear = this.txtYear;
              tmpYear.Text = tmpYear.Text + str2.Substring(this.txtYear.Text.Length);
            }

            if ((Conversion.Val(this.txtYear.Text.Substring(5, 2)) > 12.0) | (Conversion.Val(this.txtYear.Text.Substring(5, 2)) < 1.0))
              this.txtYear.Text = this.txtYear.Text.Substring(0, 4) + "-01" + this.txtYear.Text.Substring(7);

            if ((Conversion.Val(this.txtYear.Text.Substring(8, 2)) > 31.0) | (Conversion.Val(this.txtYear.Text.Substring(8, 2)) < 1.0))
              this.txtYear.Text = this.txtYear.Text.Substring(0, 7) + "-01";

            break;
        }

        this.txtYear.Text.TrimStart(new char[] { '0' });

        if (this.txtYear.Text.Length < 4)
          this.txtYear.Text = this.txtYear.Text.PadLeft(4, '0');

        if (Conversion.Val(this.txtYear.Text.Substring(0, 4)) <= 0.0)
          this.txtYear.Text = "";
      }

      if (sender == this.txtTORY)
      {
        switch (this.TORYFormat.Value)
        {
          case 0:
            this.txtTORY.Mask = "####";

            if (this.txtTORY.Text.Length < 4)
              this.txtTORY.Text = this.txtTORY.Text.PadRight(4, '0');

            break;

          case 1:
            this.txtTORY.Mask = "####-##";

            if (this.txtTORY.Text.Length < 7)
            {
              string str3 = DateTime.Now.Year.ToString() + "-01";
              tmpYear = this.txtTORY;
              tmpYear.Text = tmpYear.Text + str3.Substring(this.txtTORY.Text.Length);
            }

            if ((Conversion.Val(this.txtTORY.Text.Substring(5, 2)) > 12.0) | (Conversion.Val(this.txtTORY.Text.Substring(5, 2)) < 1.0))
              this.txtTORY.Text = this.txtTORY.Text.Substring(0, 4) + "-01";

            break;

          case 2:
            this.txtTORY.Mask = "####-##-##";

            if (this.txtTORY.Text.Length < 10)
            {
              string str4 = DateTime.Now.Year.ToString() + "-01-01";
              tmpYear = this.txtTORY;
              tmpYear.Text = tmpYear.Text + str4.Substring(this.txtTORY.Text.Length);
            }

            if ((Conversion.Val(this.txtTORY.Text.Substring(5, 2)) > 12.0) | (Conversion.Val(this.txtTORY.Text.Substring(5, 2)) < 1.0))
              this.txtTORY.Text = this.txtTORY.Text.Substring(0, 4) + "-01" + this.txtTORY.Text.Substring(7);

            if ((Conversion.Val(this.txtTORY.Text.Substring(8, 2)) > 31.0) | (Conversion.Val(this.txtTORY.Text.Substring(8, 2)) < 1.0))
              this.txtTORY.Text = this.txtTORY.Text.Substring(0, 7) + "-01";

            break;
        }

        this.txtTORY.Text.TrimStart(new char[] { '0' });

        if (this.txtTORY.Text.Length < 4)
          this.txtTORY.Text = this.txtTORY.Text.PadLeft(4, '0');

        if (Conversion.Val(this.txtTORY.Text.Substring(0, 4)) <= 0.0)
          this.txtTORY.Text = "";
      }
    }

    private void Select_TextChanged(object sender, EventArgs e)
    {
      object obj2 = LateBinding.LateGet(sender, null, "Name", new object[0], null, null);
      if (ObjectType.ObjTst(obj2, "txtComment", false) == 0)
      {
        this.CheckBox38.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtAlbum", false) == 0)
      {
        this.CheckBox3.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtArtistURL", false) == 0)
      {
        this.CheckBox27.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtAudioFileURL", false) == 0)
      {
        this.CheckBox26.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtAudioSRCURL", false) == 0)
      {
        this.CheckBox28.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtBand", false) == 0)
      {
        this.CheckBox11.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtCOMMInfURL", false) == 0)
      {
        this.CheckBox32.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtComposer", false) == 0)
      {
        this.CheckBox14.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtConductor", false) == 0)
      {
        this.CheckBox12.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtContent", false) == 0)
      {
        this.CheckBox15.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtCopyInfURL", false) == 0)
      {
        this.CheckBox25.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtEncoded", false) == 0)
      {
        this.CheckBox19.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtINetRadioURL", false) == 0)
      {
        this.CheckBox29.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtLyWriter", false) == 0)
      {
        this.CheckBox17.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtModified", false) == 0)
      {
        this.CheckBox13.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtOAlbum", false) == 0)
      {
        this.CheckBox20.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtOArtist", false) == 0)
      {
        this.CheckBox23.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtOFilename", false) == 0)
      {
        this.CheckBox21.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtOLyWriter", false) == 0)
      {
        this.CheckBox22.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtOOwner", false) == 0)
      {
        this.CheckBox24.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtPayURL", false) == 0)
      {
        this.CheckBox30.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtPublisher", false) == 0)
      {
        this.CheckBox18.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtPubURL", false) == 0)
      {
        this.CheckBox31.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtSubTitle", false) == 0)
      {
        this.CheckBox16.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtTitle", false) == 0)
      {
        this.CheckBox2.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "cmbArtist", false) == 0)
      {
        this.CheckBox1.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "cmbGenre", false) == 0)
      {
        this.CheckBox9.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "cmbMedia", false) == 0)
      {
        this.CheckBox5.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtSortAlbum", false) == 0)
      {
        this.CheckBox42.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtSortArtist", false) == 0)
      {
        this.CheckBox43.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtSortTitle", false) == 0)
      {
        this.CheckBox41.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtCopyright", false) == 0)
      {
        this.CheckBox40.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtBPM", false) == 0)
      {
        this.CheckBox8.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtPOS1", false) == 0)
      {
        this.CheckBox7.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtPOS2", false) == 0)
      {
        this.CheckBox7.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtTrack1", false) == 0)
      {
        this.CheckBox6.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtTrack2", false) == 0)
      {
        this.CheckBox6.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtYear", false) == 0)
      {
        this.CheckBox4.Checked = true;
      }
      else if (ObjectType.ObjTst(obj2, "txtTORY", false) == 0)
      {
        this.CheckBox39.Checked = true;
      }
    }

    private void TIPLList_Click(object sender, EventArgs e)
    {
      if (this.TIPLList.FocusedItem != null)
      {
        this.txtInvFunction.Text = this.TIPLList.FocusedItem.Text;
        this.txtInvPerson.Text = this.TIPLList.FocusedItem.SubItems[1].Text;
      }
    }

    private void TMCLList_Click(object sender, EventArgs e)
    {
      if (this.TMCLList.FocusedItem != null)
      {
        this.txtMusicianInst.Text = this.TMCLList.FocusedItem.Text;
        this.txtMusicianName.Text = this.TMCLList.FocusedItem.SubItems[1].Text;
      }
    }

    private void TORYFormat_Scroll(object sender, ScrollEventArgs e)
    {
      MaskedTextBox tmpTORY;

      switch (this.TORYFormat.Value)
      {
        case 0:
          this.txtTORY.Mask = "0000";
          break;

        case 1:
          this.txtTORY.Mask = "0000-00";

          if (this.txtTORY.Text.Length < 7)
          {
            string str = DateTime.Now.Year.ToString() + "-01";
            tmpTORY = this.txtTORY;
            tmpTORY.Text = tmpTORY.Text + str.Substring(this.txtTORY.Text.Length);
          }

          break;

        case 2:
          this.txtTORY.Mask = "0000-00-00";

          if (this.txtTORY.Text.Length < 10)
          {
            string str2 = DateTime.Now.Year.ToString() + "-01-01";
            tmpTORY = this.txtTORY;
            tmpTORY.Text = tmpTORY.Text + str2.Substring(this.txtTORY.Text.Length);
          }

          break;
      }
    }

    private void TXXXList_Click(object sender, EventArgs e)
    {
      if (this.TXXXList.FocusedItem != null)
      {
        this.txtTXXXDesc.Text = this.TXXXList.FocusedItem.Text;
        this.txtTXXXContent.Text = this.TXXXList.FocusedItem.SubItems[1].Text;
      }
    }

    private void WXXXList_Click(object sender, EventArgs e)
    {
      if (this.WXXXList.FocusedItem != null)
      {
        this.txtWXXXDesc.Text = this.WXXXList.FocusedItem.Text;
        this.txtWXXXContent.Text = this.WXXXList.FocusedItem.SubItems[1].Text;
      }
    }

    private void YearFormat_Scroll(object sender, ScrollEventArgs e)
    {
      MaskedTextBox tmpYear;

      switch (this.YearFormat.Value)
      {
        case 0:
          this.txtYear.Mask = "0000";
          break;

        case 1:
          this.txtYear.Mask = "0000-00";

          if (this.txtYear.Text.Length < 7)
          {
            string str = DateTime.Now.Year.ToString() + "-01";
            tmpYear = this.txtYear;
            tmpYear.Text = tmpYear.Text + str.Substring(this.txtYear.Text.Length);
          }

          break;

        case 2:
          this.txtYear.Mask = "0000-00-00";

            if (this.txtYear.Text.Length < 10)
          {
            string str2 = DateTime.Now.Year.ToString() + "-01-01";
            tmpYear = this.txtYear;
            tmpYear.Text = tmpYear.Text + str2.Substring(this.txtYear.Text.Length);
          }

          break;
      }
    }

    #endregion

    #region Class logic

    private void AddColumnText()
    {
      this.CommentList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol04"]);
      this.CommentList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol05"]);
      this.CommentList.Columns[2].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol06"]);
      this.TIPLList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol07"]);
      this.TIPLList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol08"]);
      this.TMCLList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol09"]);
      this.TMCLList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol10"]);
      this.PicList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol11"]);
      this.PicList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol12"]);
      this.PicList.Columns[2].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol13"]);
      this.PicList.Columns[3].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol14"]);
      this.LyricsList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol15"]);
      this.LyricsList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol16"]);
      this.LyricsList.Columns[2].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol17"]);
      this.RatingList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol18"]);
      this.RatingList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol19"]);
      this.RatingList.Columns[2].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol20"]);
      this.TXXXList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol21"]);
      this.TXXXList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol22"]);
      this.WXXXList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol21"]);
      this.WXXXList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol22"]);
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
          try
          {
            current.Text = StringType.FromObject(Declarations.objResources.SelectionBar[current.Name]);
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }
          try
          {
            foreach (ButtonItem item in current.SubItems)
            {
              item.Text = StringType.FromObject(Declarations.objResources.SelectionBar[item.Name]);
            }
            continue;
          }
          catch (Exception exception2)
          {
            ProjectData.SetProjectError(exception2);
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
      string vstrName = "frmTAG2Multi";
      Control cmbCDescriptor = this.cmbCDescriptor;
      this.cmbCDescriptor = (ComboBoxAutoComplete)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.cmbCDescriptor, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox38;
      this.CheckBox38 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox38, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox10;
      this.CheckBox10 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox10, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnMoveComment;
      this.btnMoveComment = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnMoveComment, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnRemoveComment;
      this.btnRemoveComment = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnRemoveComment, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnAddComment;
      this.btnAddComment = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnAddComment, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.cmbCLanguage;
      this.cmbCLanguage = (ComboBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.cmbCLanguage, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtComment;
      this.txtComment = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtComment, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.cmbGenre;
      this.cmbGenre = (ComboBoxAutoComplete)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.cmbGenre, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox9;
      this.CheckBox9 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox9, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnMoveGenre;
      this.btnMoveGenre = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnMoveGenre, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnRemoveGenre;
      this.btnRemoveGenre = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnRemoveGenre, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnAddGenre;
      this.btnAddGenre = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnAddGenre, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.GenreList;
      this.GenreList = (ListBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.GenreList, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.chkTLEN;
      this.chkTLEN = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.chkTLEN, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtPOS2;
      this.txtPOS2 = (MaskedTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtPOS2, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtPOS1;
      this.txtPOS1 = (MaskedTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtPOS1, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtTrack2;
      this.txtTrack2 = (MaskedTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtTrack2, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtTrack1;
      this.txtTrack1 = (MaskedTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtTrack1, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtYear;
      this.txtYear = (MaskedTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtYear, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtBPM;
      this.txtBPM = (MaskedTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtBPM, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.cmbArtist;
      this.cmbArtist = (ComboBoxAutoComplete)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.cmbArtist, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox8;
      this.CheckBox8 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox8, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox7;
      this.CheckBox7 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox7, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox6;
      this.CheckBox6 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox6, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox5;
      this.CheckBox5 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox5, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox4;
      this.CheckBox4 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox4, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox3;
      this.CheckBox3 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox3, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox2;
      this.CheckBox2 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox2, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox1;
      this.CheckBox1 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox1, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.YearFormat;
      this.YearFormat = (HScrollBar)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.YearFormat, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.cmbMedia;
      this.cmbMedia = (ComboBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.cmbMedia, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtAlbum;
      this.txtAlbum = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtTitle;
      this.txtTitle = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtTitle, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox41;
      this.CheckBox41 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox41, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox42;
      this.CheckBox42 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox42, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox43;
      this.CheckBox43 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox43, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtSortArtist;
      this.txtSortArtist = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtSortArtist, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtSortTitle;
      this.txtSortTitle = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtSortTitle, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtSortAlbum;
      this.txtSortAlbum = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtSortAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtTORY;
      this.txtTORY = (MaskedTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtTORY, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox39;
      this.CheckBox39 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox39, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox24;
      this.CheckBox24 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox24, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox23;
      this.CheckBox23 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox23, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox22;
      this.CheckBox22 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox22, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox21;
      this.CheckBox21 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox21, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox20;
      this.CheckBox20 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox20, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtOOwner;
      this.txtOOwner = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtOOwner, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtOArtist;
      this.txtOArtist = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtOArtist, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtOAlbum;
      this.txtOAlbum = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtOAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtOLyWriter;
      this.txtOLyWriter = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtOLyWriter, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtOFilename;
      this.txtOFilename = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtOFilename, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox16;
      this.CheckBox16 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox16, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox15;
      this.CheckBox15 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox15, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtContent;
      this.txtContent = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtContent, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtSubTitle;
      this.txtSubTitle = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtSubTitle, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox14;
      this.CheckBox14 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox14, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox13;
      this.CheckBox13 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox13, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox12;
      this.CheckBox12 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox12, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox11;
      this.CheckBox11 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox11, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtComposer;
      this.txtComposer = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtComposer, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtBand;
      this.txtBand = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtBand, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtModified;
      this.txtModified = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtModified, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtConductor;
      this.txtConductor = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtConductor, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox40;
      this.CheckBox40 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox40, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtCopyright;
      this.txtCopyright = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtCopyright, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox19;
      this.CheckBox19 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox19, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox18;
      this.CheckBox18 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox18, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox17;
      this.CheckBox17 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox17, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtLyWriter;
      this.txtLyWriter = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtLyWriter, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtEncoded;
      this.txtEncoded = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtEncoded, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtPublisher;
      this.txtPublisher = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtPublisher, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox45;
      this.CheckBox45 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox45, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtMusicianName;
      this.txtMusicianName = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtMusicianName, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnRemoveMusician;
      this.btnRemoveMusician = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnRemoveMusician, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnAddMusician;
      this.btnAddMusician = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnAddMusician, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtMusicianInst;
      this.txtMusicianInst = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtMusicianInst, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox44;
      this.CheckBox44 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox44, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtInvPerson;
      this.txtInvPerson = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtInvPerson, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnRemoveInv;
      this.btnRemoveInv = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnRemoveInv, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnAddInv;
      this.btnAddInv = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnAddInv, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtInvFunction;
      this.txtInvFunction = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtInvFunction, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox34;
      this.CheckBox34 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox34, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnRemovePicture;
      this.btnRemovePicture = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnRemovePicture, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnAddPicture;
      this.btnAddPicture = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnAddPicture, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnGetPic;
      this.btnGetPic = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnGetPic, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.chkPicInclude;
      this.chkPicInclude = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.chkPicInclude, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtPicPath;
      this.txtPicPath = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtPicPath, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.cmbPicType;
      this.cmbPicType = (ComboBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.cmbPicType, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtPDescriptor;
      this.txtPDescriptor = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtPDescriptor, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox35;
      this.CheckBox35 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox35, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.cmbLLanguage;
      this.cmbLLanguage = (ComboBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.cmbLLanguage, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtLDescriptor;
      this.txtLDescriptor = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtLDescriptor, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox33;
      this.CheckBox33 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox33, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnMoveRating;
      this.btnMoveRating = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnMoveRating, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnRemoveRating;
      this.btnRemoveRating = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnRemoveRating, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnAddRating;
      this.btnAddRating = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnAddRating, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtRatingCounter;
      this.txtRatingCounter = (NumericUpDown)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtRatingCounter, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtRatingRating;
      this.txtRatingRating = (NumericUpDown)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtRatingRating, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtRatingUser;
      this.txtRatingUser = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtRatingUser, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox32;
      this.CheckBox32 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox32, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox31;
      this.CheckBox31 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox31, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox30;
      this.CheckBox30 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox30, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox29;
      this.CheckBox29 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox29, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox28;
      this.CheckBox28 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox28, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox27;
      this.CheckBox27 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox27, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox26;
      this.CheckBox26 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox26, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox25;
      this.CheckBox25 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox25, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtCOMMInfURL;
      this.txtCOMMInfURL = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtCOMMInfURL, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtPubURL;
      this.txtPubURL = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtPubURL, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtPayURL;
      this.txtPayURL = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtPayURL, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtINetRadioURL;
      this.txtINetRadioURL = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtINetRadioURL, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtAudioSRCURL;
      this.txtAudioSRCURL = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtAudioSRCURL, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtCopyInfURL;
      this.txtCopyInfURL = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtCopyInfURL, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtArtistURL;
      this.txtArtistURL = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtArtistURL, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtAudioFileURL;
      this.txtAudioFileURL = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtAudioFileURL, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox37;
      this.CheckBox37 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox37, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtWXXXContent;
      this.txtWXXXContent = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtWXXXContent, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnRemoveWXXX;
      this.btnRemoveWXXX = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnRemoveWXXX, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnAddWXXX;
      this.btnAddWXXX = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnAddWXXX, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtWXXXDesc;
      this.txtWXXXDesc = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtWXXXDesc, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.CheckBox36;
      this.CheckBox36 = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.CheckBox36, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtTXXXContent;
      this.txtTXXXContent = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtTXXXContent, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnRemoveTXXX;
      this.btnRemoveTXXX = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnRemoveTXXX, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.btnAddTXXX;
      this.btnAddTXXX = (Button)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.btnAddTXXX, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtTXXXDesc;
      this.txtTXXXDesc = (System.Windows.Forms.TextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtTXXXDesc, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtDigits;
      this.txtDigits = (NumericUpDown)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtDigits, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.chkRemoveAllNOT;
      this.chkRemoveAllNOT = (CheckBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.chkRemoveAllNOT, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
    }

    private string CheckReplace(V2TAG V2ReplaceTAG, string vstrEntry)
    {
      if ((vstrEntry.IndexOf("<") >= 0) && (vstrEntry.IndexOf(">") >= 0))
      {
        if (vstrEntry.IndexOf("<A>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TPE1"))
          {
            vstrEntry = vstrEntry.Replace("<A>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TPE1"), null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<A>", "");
          }
        }
        if (vstrEntry.IndexOf("<T>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TIT2"))
          {
            vstrEntry = vstrEntry.Replace("<T>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TIT2"), null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<T>", "");
          }
        }
        if (vstrEntry.IndexOf("<B>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TALB"))
          {
            vstrEntry = vstrEntry.Replace("<B>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TALB"), null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<B>", "");
          }
        }
        if ((vstrEntry.IndexOf("<") < 0) || (vstrEntry.IndexOf(">") < 0))
        {
          return vstrEntry;
        }
        if (vstrEntry.IndexOf("<C>") >= 0)
        {
          if (V2ReplaceTAG.GetFrames("COMM").Count > 0)
          {
            vstrEntry = vstrEntry.Replace("<C>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrames("COMM")[0], null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<C>", "");
          }
        }
        if (vstrEntry.IndexOf("<E>") >= 0)
        {
          if (V2ReplaceTAG.GetFrames("TBPM").Count > 0)
          {
            vstrEntry = vstrEntry.Replace("<E>", Conversion.Fix(Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(V2ReplaceTAG.GetFrames("TBPM")[0], null, "Content", new object[0], null, null)))).ToString());
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<E>", "");
          }
        }
        if (vstrEntry.IndexOf("<U>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TIT1"))
          {
            vstrEntry = vstrEntry.Replace("<U>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TIT1"), null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<U>", "");
          }
        }
        if (vstrEntry.IndexOf("<S>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TIT3"))
          {
            vstrEntry = vstrEntry.Replace("<S>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TIT3"), null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<S>", "");
          }
        }
        if (vstrEntry.IndexOf("<O>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TPE2"))
          {
            vstrEntry = vstrEntry.Replace("<O>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TPE2"), null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<O>", "");
          }
        }
        if (vstrEntry.IndexOf("<N>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TPE3"))
          {
            vstrEntry = vstrEntry.Replace("<N>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TPE3"), null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<N>", "");
          }
        }
        if (vstrEntry.IndexOf("<M>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TPE4"))
          {
            vstrEntry = vstrEntry.Replace("<M>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TPE4"), null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<M>", "");
          }
        }
        if (vstrEntry.IndexOf("<G>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TCON"))
          {
            string newValue = StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TCON"), null, "Content", new object[0], null, null));
            if (newValue.IndexOf("\0") >= 0)
            {
              newValue = newValue.Substring(0, newValue.IndexOf("\0"));
            }
            vstrEntry = vstrEntry.Replace("<G>", newValue);
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<G>", "");
          }
        }
        if (vstrEntry.IndexOf("<R>") >= 0)
        {
          if (V2ReplaceTAG.FrameExists("TCOM"))
          {
            vstrEntry = vstrEntry.Replace("<R>", StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TCOM"), null, "Content", new object[0], null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<R>", "");
          }
        }
        if (vstrEntry.IndexOf("<Y>") >= 0)
        {
          if (V2ReplaceTAG.TAGVersion == 3)
          {
            if (V2ReplaceTAG.FrameExists("TYER"))
            {
              vstrEntry = vstrEntry.Replace("<Y>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TYER"), null, "Content", new object[0], null, null), null, "PadLeft", new object[] { 4, "0" }, null, null), null, "Substring", new object[] { 0, 4 }, null, null)));
            }
            else
            {
              vstrEntry = vstrEntry.Replace("<Y>", "");
            }
          }
          else if (V2ReplaceTAG.FrameExists("TDRC"))
          {
            vstrEntry = vstrEntry.Replace("<Y>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TDRC"), null, "Content", new object[0], null, null), null, "PadLeft", new object[] { 4, "0" }, null, null), null, "Substring", new object[] { 0, 4 }, null, null)));
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<Y>", "");
          }
        }
        if ((vstrEntry.IndexOf("<K>") >= 0) | (vstrEntry.IndexOf("<k>") >= 0))
        {
          if (V2ReplaceTAG.FrameExists("TRCK"))
          {
            string str3 = "";
            string str4 = "";
            str3 = StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TRCK"), null, "Content", new object[0], null, null));
            if (str3.IndexOf("/") >= 0)
            {
              str4 = str3.Substring(str3.IndexOf("/") + 1);
            }
            str3 = str3.Replace("/" + str4, "");
            vstrEntry = vstrEntry.Replace("<K>", str3);
            vstrEntry = vstrEntry.Replace("<k>", str4);
          }
          else
          {
            vstrEntry = vstrEntry.Replace("<K>", "").Replace("<k>", "");
          }
        }
        if ((vstrEntry.IndexOf("<P>") >= 0) | (vstrEntry.IndexOf("<p>") >= 0))
        {
          if (V2ReplaceTAG.FrameExists("TPOS"))
          {
            string str5 = "";
            string str6 = "";
            str5 = StringType.FromObject(LateBinding.LateGet(V2ReplaceTAG.GetFrame("TPOS"), null, "Content", new object[0], null, null));
            if (str5.IndexOf("/") >= 0)
            {
              str6 = str5.Substring(str5.IndexOf("/") + 1);
            }
            str5 = str5.Replace("/" + str6, "");
            vstrEntry = vstrEntry.Replace("<P>", str5);
            vstrEntry = vstrEntry.Replace("<p>", str6);
            return vstrEntry;
          }
          vstrEntry = vstrEntry.Replace("<P>", "").Replace("<p>", "");
        }
      }
      return vstrEntry;
    }

    private void CommentList_Click(object sender, EventArgs e)
    {
      if (this.CommentList.FocusedItem == null)
      {
        return;
      }
      this.cmbCDescriptor.Text = this.CommentList.FocusedItem.Text;
      var enumerator = this.cmbCLanguage.Items.GetEnumerator();
      while (enumerator.MoveNext())
      {
        string str = StringType.FromObject(enumerator.Current);
        if (str.StartsWith(this.CommentList.FocusedItem.SubItems[2].Text))
        {
          this.cmbCLanguage.SelectedItem = str;
          goto Label_0099;
        }
      }
      Label_0099:
      this.txtComment.Text = this.CommentList.FocusedItem.SubItems[1].Text.Replace("\n", "\r\n");
    }

    private void FillForm()
    {
      byte num = 0;
      this.cmbArtist.Autocomplete = false;
      this.cmbGenre.Autocomplete = false;
      if (this.MainForm.MP3View.SelectedItems.Count > 0)
      {
        V2TextFrame frame;
        V2TextFrame frame2;
        MP3 tag = (MP3)this.MainForm.MP3View.SelectedItems[0].Tag;
        string sLeft = "yyyy-MM-dd";
        if (tag.V2TAG.TAGVersion == 3)
        {
          if (tag.V2TAG.FrameExists("TYER"))
          {
            frame = (V2TextFrame)tag.V2TAG.GetFrame("TYER");
            if (frame.Content.Length > 4)
            {
              frame.Content = Conversion.Val(frame.Content.Substring(0, 4)).ToString();
            }
            if (Convert.ToInt32(Conversion.Val(frame.Content)) >= 0)
            {
              sLeft = sLeft.Replace("yyyy", frame.Content.PadLeft(4, '0'));
              if (tag.V2TAG.FrameExists("TDAT"))
              {
                frame2 = (V2TextFrame)tag.V2TAG.GetFrame("TDAT");
                sLeft = sLeft.Replace("MM", frame2.Content.Substring(2, 2)).Replace("dd", frame2.Content.Substring(0, 2));
                this.txtYear.Mask = "####-##-##";
                this.YearFormat.Value = 2;
              }
              if (sLeft.IndexOf("MM") >= 0)
              {
                this.txtYear.Mask = "####";
                this.YearFormat.Value = 0;
              }
            }
            else
            {
              sLeft = sLeft.Replace("yyyy", StringType.FromInteger(DateTime.Now.Year));
              if (tag.V2TAG.FrameExists("TDAT"))
              {
                frame2 = (V2TextFrame)tag.V2TAG.GetFrame("TDAT");
                sLeft = sLeft.Replace("MM", frame2.Content.Substring(2, 2)).Replace("dd", frame2.Content.Substring(0, 2));
                this.txtYear.Mask = "####-##-##";
                this.YearFormat.Value = 2;
              }
              if (sLeft.IndexOf("MM") >= 0)
              {
                this.txtYear.Mask = "####";
                this.YearFormat.Value = 0;
              }
            }
            if (sLeft.IndexOf("MM") >= 0)
            {
              sLeft = sLeft.Substring(0, 4);
            }
          }
          else
          {
            sLeft = "";
            num = (byte)(num | 8);
          }
        }
        else if (tag.V2TAG.FrameExists("TDRC"))
        {
          frame = (V2TextFrame)tag.V2TAG.GetFrame("TDRC");
          if ((frame.Content.Length >= 4) && (Convert.ToInt32(Conversion.Val(frame.Content.Substring(0, 4))) >= 0))
          {
            if (frame.Content.IndexOf("T") < 0)
            {
              sLeft = frame.Content.PadLeft(4, '0');
              if (sLeft.Length == 10)
              {
                this.txtYear.Mask = "####-##-##";
                this.YearFormat.Value = 2;
              }
              if (sLeft.Length == 7)
              {
                this.txtYear.Mask = "####-##";
                this.YearFormat.Value = 1;
              }
              if (sLeft.Length == 4)
              {
                this.txtYear.Mask = "####";
                this.YearFormat.Value = 0;
              }
            }
            else
            {
              sLeft = frame.Content.Substring(0, frame.Content.IndexOf("T"));
              this.txtYear.Mask = "####-##-##";
              this.YearFormat.Value = 2;
            }
          }
        }
        else
        {
          sLeft = "";
          num = (byte)(num | 8);
        }
        foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
        {
          MP3 mp2 = (MP3)item.Tag;
          if (tag != mp2)
          {
            if ((((num & 1) == 0) && tag.V2TAG.FrameExists("TPE1")) && mp2.V2TAG.FrameExists("TPE1"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp2.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp2.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), "", false) == 0)))
              {
                num = (byte)(num | 1);
              }
            }
            else
            {
              num = (byte)(num | 1);
            }
            if ((((num & 2) == 0) && tag.V2TAG.FrameExists("TIT2")) && mp2.V2TAG.FrameExists("TIT2"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp2.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp2.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), "", false) == 0)))
              {
                num = (byte)(num | 2);
              }
            }
            else
            {
              num = (byte)(num | 2);
            }
            if ((((num & 4) == 0) && tag.V2TAG.FrameExists("TALB")) && mp2.V2TAG.FrameExists("TALB"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp2.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp2.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), "", false) == 0)))
              {
                num = (byte)(num | 4);
              }
            }
            else
            {
              num = (byte)(num | 4);
            }
            if ((num & 8) == 0)
            {
              string sRight = "yyyy-MM-dd";
              if (mp2.V2TAG.TAGVersion == 3)
              {
                if (mp2.V2TAG.FrameExists("TYER"))
                {
                  frame = (V2TextFrame)mp2.V2TAG.GetFrame("TYER");
                  if (frame.Content.Length > 4)
                  {
                    frame.Content = Conversion.Val(frame.Content.Substring(0, 4)).ToString();
                  }
                  if (Convert.ToInt32(Conversion.Val(frame.Content)) >= 0x708)
                  {
                    sRight = sRight.Replace("yyyy", frame.Content);
                    if (mp2.V2TAG.FrameExists("TDAT"))
                    {
                      frame2 = (V2TextFrame)mp2.V2TAG.GetFrame("TDAT");
                      sRight = sRight.Replace("MM", frame2.Content.Substring(2, 2)).Replace("dd", frame2.Content.Substring(0, 2));
                    }
                  }
                  else
                  {
                    sRight = sRight.Replace("yyyy", StringType.FromInteger(DateTime.Now.Year));
                    if (mp2.V2TAG.FrameExists("TDAT"))
                    {
                      frame2 = (V2TextFrame)mp2.V2TAG.GetFrame("TDAT");
                      sRight = sRight.Replace("MM", frame2.Content.Substring(2, 2)).Replace("dd", frame2.Content.Substring(0, 2));
                    }
                  }
                  if (sRight.IndexOf("MM") >= 0)
                  {
                    sRight = sRight.Substring(0, 4);
                  }
                }
                else
                {
                  sRight = "";
                  num = (byte)(num | 8);
                }
              }
              else if (mp2.V2TAG.FrameExists("TDRC"))
              {
                frame = (V2TextFrame)mp2.V2TAG.GetFrame("TDRC");
                if ((frame.Content.Length >= 4) && (Convert.ToInt32(Conversion.Val(frame.Content.Substring(0, 4))) >= 0x708))
                {
                  if (frame.Content.IndexOf("T") < 0)
                  {
                    sRight = frame.Content;
                  }
                  else
                  {
                    sRight = frame.Content.Substring(0, frame.Content.IndexOf("T"));
                  }
                }
              }
              else
              {
                sRight = "";
                num = (byte)(num | 8);
              }
              if (StringType.StrCmp(sLeft, sRight, false) != 0)
              {
                num = (byte)(num | 8);
              }
            }
            if ((((num & 0x10) == 0) && tag.V2TAG.FrameExists("TCON")) && mp2.V2TAG.FrameExists("TCON"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp2.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp2.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null), "", false) == 0)))
              {
                num = (byte)(num | 0x10);
              }
            }
            else
            {
              num = (byte)(num | 0x10);
            }
            if (num == 0x1f)
            {
              break;
            }
          }
        }
        if (num != 0x1f)
        {
          if (((num & 1) == 0) & tag.V2TAG.FrameExists("TPE1"))
          {
            this.cmbArtist.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
          }
          if (((num & 2) == 0) & tag.V2TAG.FrameExists("TIT2"))
          {
            this.txtTitle.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
          }
          if (((num & 4) == 0) & tag.V2TAG.FrameExists("TALB"))
          {
            this.txtAlbum.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
          }
          if ((num & 8) == 0)
          {
            switch (this.YearFormat.Value)
            {
              case 0:
                this.txtYear.Mask = "####";
                break;

              case 1:
                this.txtYear.Mask = "####-##";
                break;

              case 2:
                this.txtYear.Mask = "####-##-##";
                break;
            }
            sLeft = sLeft.Replace("dd", "01").Replace("MM", "01").Replace("yyyy", StringType.FromInteger(DateTime.Now.Year));
            try
            {
              this.txtYear.Text = sLeft;
            }
            catch (Exception exception1)
            {
              ProjectData.SetProjectError(exception1);
              this.txtYear.Text = "";
              ProjectData.ClearProjectError();
            }
          }
          if (((num & 0x10) == 0) & tag.V2TAG.FrameExists("TCON"))
          {
            foreach (string str3 in Strings.Split(StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null)), "\0", -1, CompareMethod.Binary))
            {
              var ss33 = str3;

              if (StringType.StrCmp(ss33, "", false) != 0)
              {
                if ((ss33.Length > 2) && Information.IsNumeric(ss33.Replace("(", "").Replace(")", "")))
                {
                  if ((Conversion.Val(ss33.Replace("(", "").Replace(")", "")) >= 0.0) & (Conversion.Val(ss33.Replace("(", "").Replace(")", "")) < 148.0))
                  {
                    ss33 = Declarations.astrGenreLookup[(int)Math.Round(Conversion.Val(ss33.Replace("(", "").Replace(")", "")))];
                    this.CheckBox9.Checked = true;
                  }
                  else
                    ss33 = "< undefined >";
                }
                this.GenreList.Items.Add(ss33);
              }
            }
          }
        }
      }
      this.CheckBox1.Checked = false;
      this.CheckBox2.Checked = false;
      this.CheckBox3.Checked = false;
      this.CheckBox4.Checked = false;
      this.CheckBox9.Checked = false;
      if (!Declarations.objSettings.SingleGC)
        goto Label_0F9C;
      if (this.GenreList.Items.Count > 0)
      {
        this.cmbGenre.Text = StringType.FromObject(this.GenreList.Items[0]);
      }
      if (this.CommentList.Items.Count <= 0)
      {
        goto Label_0F9C;
      }
      this.cmbCDescriptor.Text = StringType.FromObject(LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Descriptor", new object[0], null, null));
      var enumerator = this.cmbCLanguage.Items.GetEnumerator();
      while (enumerator.MoveNext())
      {
        string str4 = StringType.FromObject(enumerator.Current);
        if (str4.StartsWith(StringType.FromObject(LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Language", new object[0], null, null))))
        {
          this.cmbCLanguage.SelectedItem = str4;
          goto Label_0F63;
        }
      }
      Label_0F63:
      this.txtComment.Text = StringType.FromObject(LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Content", new object[0], null, null));
      Label_0F9C:
      this.cmbArtist.Autocomplete = true;
      this.cmbGenre.Autocomplete = true;
    }

    private void SaveToTAG()
    {
      ArrayList list = new ArrayList();
      this.MainForm.MP3View.BeginUpdate();
      Form ownerForm = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.Multi2CB);
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
      Id3TagIT_Main.SaveFormSettings(ref ownerForm);
      this.Close();
    }

    #endregion
  }
}