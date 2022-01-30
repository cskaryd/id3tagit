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
  using System.IO;
  using System.Resources;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public class frmTAG2 : Form
  {
    [AccessedThroughProperty("APICView")]
    private PictureBox _APICView;
    [AccessedThroughProperty("btnAddComment")]
    private Button _btnAddComment;
    [AccessedThroughProperty("btnAddGenre")]
    private Button _btnAddGenre;
    [AccessedThroughProperty("btnAddInv")]
    private Button _btnAddInv;
    [AccessedThroughProperty("btnAddLyrics")]
    private Button _btnAddLyrics;
    [AccessedThroughProperty("btnAddMusician")]
    private Button _btnAddMusician;
    [AccessedThroughProperty("btnAddPicture")]
    private Button _btnAddPicture;
    [AccessedThroughProperty("btnAddRating")]
    private Button _btnAddRating;
    [AccessedThroughProperty("btnAddTXXX")]
    private Button _btnAddTXXX;
    [AccessedThroughProperty("btnAddWXXX")]
    private Button _btnAddWXXX;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnExPic")]
    private Button _btnExPic;
    [AccessedThroughProperty("btnExport")]
    private ButtonItem _btnExport;
    [AccessedThroughProperty("btnGet")]
    private ButtonItem _btnGet;
    [AccessedThroughProperty("btnGetPic")]
    private Button _btnGetPic;
    [AccessedThroughProperty("btnImport")]
    private ButtonItem _btnImport;
    [AccessedThroughProperty("btnLyricsFile")]
    private Button _btnLyricsFile;
    [AccessedThroughProperty("btnMoveComment")]
    private Button _btnMoveComment;
    [AccessedThroughProperty("btnMoveGenre")]
    private Button _btnMoveGenre;
    [AccessedThroughProperty("btnMoveLyrics")]
    private Button _btnMoveLyrics;
    [AccessedThroughProperty("btnMoveRating")]
    private Button _btnMoveRating;
    [AccessedThroughProperty("btnNext")]
    private ButtonItem _btnNext;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnPrev")]
    private ButtonItem _btnPrev;
    [AccessedThroughProperty("btnRemoveComment")]
    private Button _btnRemoveComment;
    [AccessedThroughProperty("btnRemoveGenre")]
    private Button _btnRemoveGenre;
    [AccessedThroughProperty("btnRemoveInv")]
    private Button _btnRemoveInv;
    [AccessedThroughProperty("btnRemoveLyrics")]
    private Button _btnRemoveLyrics;
    [AccessedThroughProperty("btnRemoveMusician")]
    private Button _btnRemoveMusician;
    [AccessedThroughProperty("btnRemovePicture")]
    private Button _btnRemovePicture;
    [AccessedThroughProperty("btnRemoveRating")]
    private Button _btnRemoveRating;
    [AccessedThroughProperty("btnRemoveTXXX")]
    private Button _btnRemoveTXXX;
    [AccessedThroughProperty("btnRemoveWXXX")]
    private Button _btnRemoveWXXX;
    [AccessedThroughProperty("btnSwapAA")]
    private ButtonItem _btnSwapAA;
    [AccessedThroughProperty("btnSwapAT")]
    private ButtonItem _btnSwapAT;
    [AccessedThroughProperty("btnSwapTA")]
    private ButtonItem _btnSwapTA;
    [AccessedThroughProperty("btnTLEN")]
    private Button _btnTLEN;
    [AccessedThroughProperty("btnV1Album")]
    private Button _btnV1Album;
    [AccessedThroughProperty("btnV1Artist")]
    private Button _btnV1Artist;
    [AccessedThroughProperty("btnV1Comment")]
    private Button _btnV1Comment;
    [AccessedThroughProperty("btnV1Genre")]
    private Button _btnV1Genre;
    [AccessedThroughProperty("btnV1Title")]
    private Button _btnV1Title;
    [AccessedThroughProperty("btnV1Track")]
    private Button _btnV1Track;
    [AccessedThroughProperty("btnV1Year")]
    private Button _btnV1Year;
    [AccessedThroughProperty("ButtomPanel")]
    private PanelEx _ButtomPanel;
    [AccessedThroughProperty("chkPicInclude")]
    private CheckBox _chkPicInclude;
    [AccessedThroughProperty("chkPicRelativPath")]
    private CheckBox _chkPicRelativPath;
    [AccessedThroughProperty("cmbArtist")]
    private ComboBoxAutoComplete _cmbArtist;
    [AccessedThroughProperty("cmbCDescriptor")]
    private ComboBoxAutoComplete _cmbCDescriptor;
    [AccessedThroughProperty("cmbCLanguage")]
    private ComboBox _cmbCLanguage;
    [AccessedThroughProperty("cmbGenre")]
    private ComboBoxAutoComplete _cmbGenre;
    [AccessedThroughProperty("cmbLLanguage")]
    private ComboBox _cmbLLanguage;
    [AccessedThroughProperty("cmbMedia")]
    private ComboBox _cmbMedia;
    [AccessedThroughProperty("cmbPicType")]
    private ComboBox _cmbPicType;
    [AccessedThroughProperty("colComment")]
    private ColumnHeader _colComment;
    [AccessedThroughProperty("colDescriptor")]
    private ColumnHeader _colDescriptor;
    [AccessedThroughProperty("colLanguage")]
    private ColumnHeader _colLanguage;
    [AccessedThroughProperty("ColumnHeader1")]
    private ColumnHeader _ColumnHeader1;
    [AccessedThroughProperty("ColumnHeader10")]
    private ColumnHeader _ColumnHeader10;
    [AccessedThroughProperty("ColumnHeader11")]
    private ColumnHeader _ColumnHeader11;
    [AccessedThroughProperty("ColumnHeader12")]
    private ColumnHeader _ColumnHeader12;
    [AccessedThroughProperty("ColumnHeader13")]
    private ColumnHeader _ColumnHeader13;
    [AccessedThroughProperty("ColumnHeader14")]
    private ColumnHeader _ColumnHeader14;
    [AccessedThroughProperty("ColumnHeader15")]
    private ColumnHeader _ColumnHeader15;
    [AccessedThroughProperty("ColumnHeader16")]
    private ColumnHeader _ColumnHeader16;
    [AccessedThroughProperty("ColumnHeader17")]
    private ColumnHeader _ColumnHeader17;
    [AccessedThroughProperty("ColumnHeader18")]
    private ColumnHeader _ColumnHeader18;
    [AccessedThroughProperty("ColumnHeader2")]
    private ColumnHeader _ColumnHeader2;
    [AccessedThroughProperty("ColumnHeader3")]
    private ColumnHeader _ColumnHeader3;
    [AccessedThroughProperty("ColumnHeader4")]
    private ColumnHeader _ColumnHeader4;
    [AccessedThroughProperty("ColumnHeader5")]
    private ColumnHeader _ColumnHeader5;
    [AccessedThroughProperty("ColumnHeader6")]
    private ColumnHeader _ColumnHeader6;
    [AccessedThroughProperty("ColumnHeader7")]
    private ColumnHeader _ColumnHeader7;
    [AccessedThroughProperty("ColumnHeader8")]
    private ColumnHeader _ColumnHeader8;
    [AccessedThroughProperty("ColumnHeader9")]
    private ColumnHeader _ColumnHeader9;
    [AccessedThroughProperty("CommentList")]
    private ListView _CommentList;
    [AccessedThroughProperty("Content")]
    private ColumnHeader _Content;
    [AccessedThroughProperty("FrameID")]
    private ColumnHeader _FrameID;
    [AccessedThroughProperty("GenreList")]
    private ListBox _GenreList;
    [AccessedThroughProperty("lblAlbum")]
    private Label _lblAlbum;
    [AccessedThroughProperty("lblAlbumSort")]
    private Label _lblAlbumSort;
    [AccessedThroughProperty("lblArtist")]
    private Label _lblArtist;
    [AccessedThroughProperty("lblArtistSort")]
    private Label _lblArtistSort;
    [AccessedThroughProperty("lblArtistURL")]
    private Label _lblArtistURL;
    [AccessedThroughProperty("lblAudioFileURL")]
    private Label _lblAudioFileURL;
    [AccessedThroughProperty("lblAudioSRCURL")]
    private Label _lblAudioSRCURL;
    [AccessedThroughProperty("lblBand")]
    private Label _lblBand;
    [AccessedThroughProperty("lblBPM")]
    private Label _lblBPM;
    [AccessedThroughProperty("lblCOMM")]
    private Label _lblCOMM;
    [AccessedThroughProperty("lblCOMMDesc")]
    private Label _lblCOMMDesc;
    [AccessedThroughProperty("lblCommDescInfo")]
    private Label _lblCommDescInfo;
    [AccessedThroughProperty("lblCOMMInfURL")]
    private Label _lblCOMMInfURL;
    [AccessedThroughProperty("lblCOMMLan")]
    private Label _lblCOMMLan;
    [AccessedThroughProperty("lblComposer")]
    private Label _lblComposer;
    [AccessedThroughProperty("lblConductor")]
    private Label _lblConductor;
    [AccessedThroughProperty("lblContent")]
    private Label _lblContent;
    [AccessedThroughProperty("lblCopyInfURL")]
    private Label _lblCopyInfURL;
    [AccessedThroughProperty("lblCopyright")]
    private Label _lblCopyright;
    [AccessedThroughProperty("lblDigits")]
    private Label _lblDigits;
    [AccessedThroughProperty("lblEncoded")]
    private Label _lblEncoded;
    [AccessedThroughProperty("lblGenre")]
    private Label _lblGenre;
    [AccessedThroughProperty("lblGenreInfo")]
    private Label _lblGenreInfo;
    [AccessedThroughProperty("lblINetRadioURL")]
    private Label _lblINetRadioURL;
    [AccessedThroughProperty("lblInfo")]
    private Label _lblInfo;
    [AccessedThroughProperty("lblInvFunction")]
    private Label _lblInvFunction;
    [AccessedThroughProperty("lblInvPerson")]
    private Label _lblInvPerson;
    [AccessedThroughProperty("lblLyDesc")]
    private Label _lblLyDesc;
    [AccessedThroughProperty("lblLyLan")]
    private Label _lblLyLan;
    [AccessedThroughProperty("lblLyrics")]
    private Label _lblLyrics;
    [AccessedThroughProperty("lblLyWriter")]
    private Label _lblLyWriter;
    [AccessedThroughProperty("lblMediaTyp")]
    private Label _lblMediaTyp;
    [AccessedThroughProperty("lblModified")]
    private Label _lblModified;
    [AccessedThroughProperty("lblMusicianInfo")]
    private Label _lblMusicianInfo;
    [AccessedThroughProperty("lblMusicianInst")]
    private Label _lblMusicianInst;
    [AccessedThroughProperty("lblMusicianName")]
    private Label _lblMusicianName;
    [AccessedThroughProperty("lblNot")]
    private Label _lblNot;
    [AccessedThroughProperty("lblOAlbum")]
    private Label _lblOAlbum;
    [AccessedThroughProperty("lblOArtist")]
    private Label _lblOArtist;
    [AccessedThroughProperty("lblOf1")]
    private Label _lblOf1;
    [AccessedThroughProperty("lblOf2")]
    private Label _lblOf2;
    [AccessedThroughProperty("lblOFilename")]
    private Label _lblOFilename;
    [AccessedThroughProperty("lblOLyWriter")]
    private Label _lblOLyWriter;
    [AccessedThroughProperty("lblOOwner")]
    private Label _lblOOwner;
    [AccessedThroughProperty("lblOYear")]
    private Label _lblOYear;
    [AccessedThroughProperty("lblOYearInfo")]
    private Label _lblOYearInfo;
    [AccessedThroughProperty("lblPayURL")]
    private Label _lblPayURL;
    [AccessedThroughProperty("lblPicDesc")]
    private Label _lblPicDesc;
    [AccessedThroughProperty("lblPicPath")]
    private Label _lblPicPath;
    [AccessedThroughProperty("lblPicType")]
    private Label _lblPicType;
    [AccessedThroughProperty("lblPosMedia")]
    private Label _lblPosMedia;
    [AccessedThroughProperty("lblPublisher")]
    private Label _lblPublisher;
    [AccessedThroughProperty("lblPubURL")]
    private Label _lblPubURL;
    [AccessedThroughProperty("lblRatingCounter")]
    private Label _lblRatingCounter;
    [AccessedThroughProperty("lblRatingRating")]
    private Label _lblRatingRating;
    [AccessedThroughProperty("lblRatingUser")]
    private Label _lblRatingUser;
    [AccessedThroughProperty("lblSelected")]
    private Label _lblSelected;
    [AccessedThroughProperty("lblSubTitle")]
    private Label _lblSubTitle;
    [AccessedThroughProperty("lblTitle")]
    private Label _lblTitle;
    [AccessedThroughProperty("lblTitleSort")]
    private Label _lblTitleSort;
    [AccessedThroughProperty("lblTLEN")]
    private Label _lblTLEN;
    [AccessedThroughProperty("lblTrack")]
    private Label _lblTrack;
    [AccessedThroughProperty("lblTXXXContent")]
    private Label _lblTXXXContent;
    [AccessedThroughProperty("lblTXXXDesc")]
    private Label _lblTXXXDesc;
    [AccessedThroughProperty("lblWXXXContent")]
    private Label _lblWXXXContent;
    [AccessedThroughProperty("lblWXXXDesc")]
    private Label _lblWXXXDesc;
    [AccessedThroughProperty("lblYear")]
    private Label _lblYear;
    [AccessedThroughProperty("LyricsList")]
    private ListView _LyricsList;
    [AccessedThroughProperty("NotSupportList")]
    private ListView _NotSupportList;
    [AccessedThroughProperty("OpenFileDialog")]
    private System.Windows.Forms.OpenFileDialog _OpenFileDialog;
    [AccessedThroughProperty("panDetail")]
    private Panel _panDetail;
    [AccessedThroughProperty("Panel1")]
    private Panel _Panel1;
    [AccessedThroughProperty("Panel10")]
    private Panel _Panel10;
    [AccessedThroughProperty("Panel11")]
    private Panel _Panel11;
    [AccessedThroughProperty("Panel12")]
    private Panel _Panel12;
    [AccessedThroughProperty("Panel13")]
    private Panel _Panel13;
    [AccessedThroughProperty("Panel14")]
    private Panel _Panel14;
    [AccessedThroughProperty("Panel15")]
    private Panel _Panel15;
    [AccessedThroughProperty("Panel16")]
    private Panel _Panel16;
    [AccessedThroughProperty("Panel2")]
    private Panel _Panel2;
    [AccessedThroughProperty("Panel3")]
    private Panel _Panel3;
    [AccessedThroughProperty("Panel4")]
    private Panel _Panel4;
    [AccessedThroughProperty("Panel5")]
    private Panel _Panel5;
    [AccessedThroughProperty("Panel6")]
    private Panel _Panel6;
    [AccessedThroughProperty("Panel7")]
    private Panel _Panel7;
    [AccessedThroughProperty("Panel8")]
    private Panel _Panel8;
    [AccessedThroughProperty("Panel9")]
    private Panel _Panel9;
    [AccessedThroughProperty("panInvolved")]
    private Panel _panInvolved;
    [AccessedThroughProperty("panLyrics")]
    private Panel _panLyrics;
    [AccessedThroughProperty("panMain")]
    private Panel _panMain;
    [AccessedThroughProperty("panNot")]
    private Panel _panNot;
    [AccessedThroughProperty("panOriginal")]
    private Panel _panOriginal;
    [AccessedThroughProperty("panPic")]
    private Panel _panPic;
    [AccessedThroughProperty("panRating")]
    private Panel _panRating;
    [AccessedThroughProperty("panUser")]
    private Panel _panUser;
    [AccessedThroughProperty("panWeb")]
    private Panel _panWeb;
    [AccessedThroughProperty("PicList")]
    private ListView _PicList;
    [AccessedThroughProperty("RatingList")]
    private ListView _RatingList;
    [AccessedThroughProperty("SaveFileDialog")]
    private System.Windows.Forms.SaveFileDialog _SaveFileDialog;
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
    [AccessedThroughProperty("TAGV2grpTAG")]
    private ExplorerBarGroupItem _TAGV2grpTAG;
    [AccessedThroughProperty("TAGV2grpTransfer")]
    private ExplorerBarGroupItem _TAGV2grpTransfer;
    [AccessedThroughProperty("TIPLList")]
    private ListView _TIPLList;
    [AccessedThroughProperty("TMCLList")]
    private ListView _TMCLList;
    [AccessedThroughProperty("ToolTip")]
    private System.Windows.Forms.ToolTip _ToolTip;
    [AccessedThroughProperty("TopPanel")]
    private PanelEx _TopPanel;
    [AccessedThroughProperty("TORYFormat")]
    private HScrollBar _TORYFormat;
    [AccessedThroughProperty("txtAlbum")]
    private System.Windows.Forms.TextBox _txtAlbum;
    [AccessedThroughProperty("txtArtistURL")]
    private System.Windows.Forms.TextBox _txtArtistURL;
    [AccessedThroughProperty("txtAudioFileURL")]
    private System.Windows.Forms.TextBox _txtAudioFileURL;
    [AccessedThroughProperty("txtAudioSRCURL")]
    private System.Windows.Forms.TextBox _txtAudioSRCURL;
    [AccessedThroughProperty("txtBand")]
    private System.Windows.Forms.TextBox _txtBand;
    [AccessedThroughProperty("txtBPM")]
    private NumericTextBox _txtBPM;
    [AccessedThroughProperty("txtComment")]
    private System.Windows.Forms.TextBox _txtComment;
    [AccessedThroughProperty("txtCOMMInfURL")]
    private System.Windows.Forms.TextBox _txtCOMMInfURL;
    [AccessedThroughProperty("txtComposer")]
    private System.Windows.Forms.TextBox _txtComposer;
    [AccessedThroughProperty("txtConductor")]
    private System.Windows.Forms.TextBox _txtConductor;
    [AccessedThroughProperty("txtContent")]
    private System.Windows.Forms.TextBox _txtContent;
    [AccessedThroughProperty("txtCopyInfURL")]
    private System.Windows.Forms.TextBox _txtCopyInfURL;
    [AccessedThroughProperty("txtCopyright")]
    private System.Windows.Forms.TextBox _txtCopyright;
    [AccessedThroughProperty("txtDigits")]
    private NumericUpDown _txtDigits;
    [AccessedThroughProperty("txtEncoded")]
    private System.Windows.Forms.TextBox _txtEncoded;
    [AccessedThroughProperty("txtINetRadioURL")]
    private System.Windows.Forms.TextBox _txtINetRadioURL;
    [AccessedThroughProperty("txtInvFunction")]
    private System.Windows.Forms.TextBox _txtInvFunction;
    [AccessedThroughProperty("txtInvPerson")]
    private System.Windows.Forms.TextBox _txtInvPerson;
    [AccessedThroughProperty("txtLDescriptor")]
    private System.Windows.Forms.TextBox _txtLDescriptor;
    [AccessedThroughProperty("txtLyrics")]
    private RichTextBox _txtLyrics;
    [AccessedThroughProperty("txtLyWriter")]
    private System.Windows.Forms.TextBox _txtLyWriter;
    [AccessedThroughProperty("txtModified")]
    private System.Windows.Forms.TextBox _txtModified;
    [AccessedThroughProperty("txtMusicianInst")]
    private System.Windows.Forms.TextBox _txtMusicianInst;
    [AccessedThroughProperty("txtMusicianName")]
    private System.Windows.Forms.TextBox _txtMusicianName;
    [AccessedThroughProperty("txtOAlbum")]
    private System.Windows.Forms.TextBox _txtOAlbum;
    [AccessedThroughProperty("txtOArtist")]
    private System.Windows.Forms.TextBox _txtOArtist;
    [AccessedThroughProperty("txtOFilename")]
    private System.Windows.Forms.TextBox _txtOFilename;
    [AccessedThroughProperty("txtOLyWriter")]
    private System.Windows.Forms.TextBox _txtOLyWriter;
    [AccessedThroughProperty("txtOOwner")]
    private System.Windows.Forms.TextBox _txtOOwner;
    [AccessedThroughProperty("txtPayURL")]
    private System.Windows.Forms.TextBox _txtPayURL;
    [AccessedThroughProperty("txtPDescriptor")]
    private System.Windows.Forms.TextBox _txtPDescriptor;
    [AccessedThroughProperty("txtPicPath")]
    private System.Windows.Forms.TextBox _txtPicPath;
    [AccessedThroughProperty("txtPOS1")]
    private IntegerTextBox _txtPOS1;
    [AccessedThroughProperty("txtPOS2")]
    private IntegerTextBox _txtPOS2;
    [AccessedThroughProperty("txtPublisher")]
    private System.Windows.Forms.TextBox _txtPublisher;
    [AccessedThroughProperty("txtPubURL")]
    private System.Windows.Forms.TextBox _txtPubURL;
    [AccessedThroughProperty("txtRatingCounter")]
    private NumericUpDown _txtRatingCounter;
    [AccessedThroughProperty("txtRatingRating")]
    private NumericUpDown _txtRatingRating;
    [AccessedThroughProperty("txtRatingUser")]
    private System.Windows.Forms.TextBox _txtRatingUser;
    [AccessedThroughProperty("txtSelected")]
    private System.Windows.Forms.TextBox _txtSelected;
    [AccessedThroughProperty("txtSortAlbum")]
    private System.Windows.Forms.TextBox _txtSortAlbum;
    [AccessedThroughProperty("txtSortArtist")]
    private System.Windows.Forms.TextBox _txtSortArtist;
    [AccessedThroughProperty("txtSortTitle")]
    private System.Windows.Forms.TextBox _txtSortTitle;
    [AccessedThroughProperty("txtSubTitle")]
    private System.Windows.Forms.TextBox _txtSubTitle;
    [AccessedThroughProperty("txtTitle")]
    private System.Windows.Forms.TextBox _txtTitle;
    [AccessedThroughProperty("txtTLEN")]
    private IntegerTextBox _txtTLEN;
    [AccessedThroughProperty("txtTORY")]
    private AMS.TextBox.MaskedTextBox _txtTORY;
    [AccessedThroughProperty("txtTrack1")]
    private IntegerTextBox _txtTrack1;
    [AccessedThroughProperty("txtTrack2")]
    private IntegerTextBox _txtTrack2;
    [AccessedThroughProperty("txtTXXXContent")]
    private System.Windows.Forms.TextBox _txtTXXXContent;
    [AccessedThroughProperty("txtTXXXDesc")]
    private System.Windows.Forms.TextBox _txtTXXXDesc;
    [AccessedThroughProperty("txtWXXXContent")]
    private System.Windows.Forms.TextBox _txtWXXXContent;
    [AccessedThroughProperty("txtWXXXDesc")]
    private System.Windows.Forms.TextBox _txtWXXXDesc;
    [AccessedThroughProperty("txtYear")]
    private AMS.TextBox.MaskedTextBox _txtYear;
    [AccessedThroughProperty("TXXXList")]
    private ListView _TXXXList;
    [AccessedThroughProperty("WXXXList")]
    private ListView _WXXXList;
    [AccessedThroughProperty("YearFormat")]
    private HScrollBar _YearFormat;
    private ArrayList alstRemovedAPICFrames;
    private ArrayList alstRemovedLDCFrames;
    private ArrayList alstRemovedPOPMFrames;
    private ArrayList alstRemovedTXXXFrames;
    private ArrayList alstRemovedWXXXFrames;
    private ComboBoxItem cmbFormat;
    private IContainer components;
    private Control FocusControl;
    private frmMain MainForm;
    private ID3_TagIT.MP3 MP3;
    private FileStream PicFStream;
    private MemoryStream PicMStream;
    private bool vbooCommentMoved;
    private bool vbooLyricsMoved;
    private bool vbooRatingMoved;

    public frmTAG2(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG2_Load);
      this.alstRemovedLDCFrames = new ArrayList();
      this.alstRemovedAPICFrames = new ArrayList();
      this.alstRemovedPOPMFrames = new ArrayList();
      this.alstRemovedTXXXFrames = new ArrayList();
      this.alstRemovedWXXXFrames = new ArrayList();
      this.vbooCommentMoved = false;
      this.vbooLyricsMoved = false;
      this.vbooRatingMoved = false;
      this.cmbFormat = new ComboBoxItem();
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

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
      this.NotSupportList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol23"]);
      this.NotSupportList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol24"]);
    }

    private void AddSelectionBar()
    {
      IEnumerator enumerator;
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
      string vstrName = "frmTAG2";
      Control txtSelected = this.txtSelected;
      this.txtSelected = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtSelected, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.cmbCDescriptor;
      this.cmbCDescriptor = (ComboBoxAutoComplete)txtSelected;
      this.ToolTip.SetToolTip(this.cmbCDescriptor, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnV1Comment;
      this.btnV1Comment = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnV1Comment, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnMoveComment;
      this.btnMoveComment = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnMoveComment, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnRemoveComment;
      this.btnRemoveComment = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnRemoveComment, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnAddComment;
      this.btnAddComment = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnAddComment, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.cmbCLanguage;
      this.cmbCLanguage = (ComboBox)txtSelected;
      this.ToolTip.SetToolTip(this.cmbCLanguage, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtComment;
      this.txtComment = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtComment, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.cmbGenre;
      this.cmbGenre = (ComboBoxAutoComplete)txtSelected;
      this.ToolTip.SetToolTip(this.cmbGenre, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnV1Genre;
      this.btnV1Genre = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnV1Genre, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnMoveGenre;
      this.btnMoveGenre = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnMoveGenre, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnRemoveGenre;
      this.btnRemoveGenre = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnRemoveGenre, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnAddGenre;
      this.btnAddGenre = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnAddGenre, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.GenreList;
      this.GenreList = (ListBox)txtSelected;
      this.ToolTip.SetToolTip(this.GenreList, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnTLEN;
      this.btnTLEN = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnTLEN, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtTLEN;
      this.txtTLEN = (IntegerTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTLEN, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtPOS2;
      this.txtPOS2 = (IntegerTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtPOS2, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtPOS1;
      this.txtPOS1 = (IntegerTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtPOS1, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtTrack2;
      this.txtTrack2 = (IntegerTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTrack2, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtTrack1;
      this.txtTrack1 = (IntegerTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTrack1, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtYear;
      this.txtYear = (AMS.TextBox.MaskedTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtYear, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtBPM;
      this.txtBPM = (NumericTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtBPM, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.cmbArtist;
      this.cmbArtist = (ComboBoxAutoComplete)txtSelected;
      this.ToolTip.SetToolTip(this.cmbArtist, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnV1Title;
      this.btnV1Title = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnV1Title, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnV1Album;
      this.btnV1Album = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnV1Album, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnV1Track;
      this.btnV1Track = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnV1Track, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnV1Year;
      this.btnV1Year = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnV1Year, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnV1Artist;
      this.btnV1Artist = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnV1Artist, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.cmbMedia;
      this.cmbMedia = (ComboBox)txtSelected;
      this.ToolTip.SetToolTip(this.cmbMedia, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtAlbum;
      this.txtAlbum = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtTitle;
      this.txtTitle = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTitle, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtSortArtist;
      this.txtSortArtist = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtSortArtist, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtSortTitle;
      this.txtSortTitle = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtSortTitle, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtSortAlbum;
      this.txtSortAlbum = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtSortAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtTORY;
      this.txtTORY = (AMS.TextBox.MaskedTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTORY, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtOOwner;
      this.txtOOwner = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtOOwner, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtOArtist;
      this.txtOArtist = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtOArtist, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtOAlbum;
      this.txtOAlbum = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtOAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtOLyWriter;
      this.txtOLyWriter = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtOLyWriter, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtOFilename;
      this.txtOFilename = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtOFilename, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtContent;
      this.txtContent = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtContent, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtSubTitle;
      this.txtSubTitle = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtSubTitle, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtComposer;
      this.txtComposer = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtComposer, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtBand;
      this.txtBand = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtBand, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtModified;
      this.txtModified = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtModified, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtConductor;
      this.txtConductor = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtConductor, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtMusicianName;
      this.txtMusicianName = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtMusicianName, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnRemoveMusician;
      this.btnRemoveMusician = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnRemoveMusician, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnAddMusician;
      this.btnAddMusician = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnAddMusician, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtMusicianInst;
      this.txtMusicianInst = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtMusicianInst, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtInvPerson;
      this.txtInvPerson = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtInvPerson, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnRemoveInv;
      this.btnRemoveInv = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnRemoveInv, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnAddInv;
      this.btnAddInv = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnAddInv, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtInvFunction;
      this.txtInvFunction = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtInvFunction, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtCopyright;
      this.txtCopyright = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtCopyright, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtLyWriter;
      this.txtLyWriter = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtLyWriter, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtEncoded;
      this.txtEncoded = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtEncoded, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtPublisher;
      this.txtPublisher = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtPublisher, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnRemovePicture;
      this.btnRemovePicture = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnRemovePicture, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnAddPicture;
      this.btnAddPicture = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnAddPicture, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnGetPic;
      this.btnGetPic = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnGetPic, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtPicPath;
      this.txtPicPath = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtPicPath, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.cmbPicType;
      this.cmbPicType = (ComboBox)txtSelected;
      this.ToolTip.SetToolTip(this.cmbPicType, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtPDescriptor;
      this.txtPDescriptor = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtPDescriptor, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.APICView;
      this.APICView = (PictureBox)txtSelected;
      this.ToolTip.SetToolTip(this.APICView, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.cmbLLanguage;
      this.cmbLLanguage = (ComboBox)txtSelected;
      this.ToolTip.SetToolTip(this.cmbLLanguage, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtLDescriptor;
      this.txtLDescriptor = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtLDescriptor, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnMoveRating;
      this.btnMoveRating = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnMoveRating, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnRemoveRating;
      this.btnRemoveRating = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnRemoveRating, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnAddRating;
      this.btnAddRating = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnAddRating, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtRatingCounter;
      this.txtRatingCounter = (NumericUpDown)txtSelected;
      this.ToolTip.SetToolTip(this.txtRatingCounter, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtRatingRating;
      this.txtRatingRating = (NumericUpDown)txtSelected;
      this.ToolTip.SetToolTip(this.txtRatingRating, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtRatingUser;
      this.txtRatingUser = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtRatingUser, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtCOMMInfURL;
      this.txtCOMMInfURL = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtCOMMInfURL, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtPubURL;
      this.txtPubURL = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtPubURL, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtPayURL;
      this.txtPayURL = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtPayURL, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtINetRadioURL;
      this.txtINetRadioURL = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtINetRadioURL, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtAudioSRCURL;
      this.txtAudioSRCURL = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtAudioSRCURL, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtCopyInfURL;
      this.txtCopyInfURL = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtCopyInfURL, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtArtistURL;
      this.txtArtistURL = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtArtistURL, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtAudioFileURL;
      this.txtAudioFileURL = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtAudioFileURL, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtWXXXContent;
      this.txtWXXXContent = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtWXXXContent, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnRemoveWXXX;
      this.btnRemoveWXXX = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnRemoveWXXX, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnAddWXXX;
      this.btnAddWXXX = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnAddWXXX, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtWXXXDesc;
      this.txtWXXXDesc = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtWXXXDesc, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtTXXXContent;
      this.txtTXXXContent = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTXXXContent, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnRemoveTXXX;
      this.btnRemoveTXXX = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnRemoveTXXX, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnAddTXXX;
      this.btnAddTXXX = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnAddTXXX, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.txtTXXXDesc;
      this.txtTXXXDesc = (System.Windows.Forms.TextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTXXXDesc, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
      vstrName = "frmTAG2";
      txtSelected = this.btnExPic;
      this.btnExPic = (Button)txtSelected;
      this.ToolTip.SetToolTip(this.btnExPic, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));
    }

    private void btnAddComment_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      ListViewItem item2 = new ListViewItem();
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
        foreach (ListViewItem item in this.TIPLList.Items)
        {
          if (StringType.StrCmp(item.Text.ToLower(), this.txtInvFunction.Text.TrimEnd(new char[] { ' ' }).ToLower(), false) == 0)
          {
            item.Text = this.txtInvFunction.Text.TrimEnd(new char[] { ' ' });
            item.SubItems[1].Text = this.txtInvPerson.Text.TrimEnd(new char[] { ' ' });
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
      ListViewItem item2 = new ListViewItem();
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
        this.LyricsList.Items.Add(item);
        this.txtLDescriptor.Text = "";
        this.txtLyrics.Text = "";
      }
    }

    private void btnAddMusican_Click(object sender, EventArgs e)
    {
      if (!((StringType.StrCmp(this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' }), "", false) == 0) | (StringType.StrCmp(this.txtMusicianName.Text.TrimEnd(new char[] { ' ' }), "", false) == 0)))
      {
        foreach (ListViewItem item in this.TMCLList.Items)
        {
          if (StringType.StrCmp(item.Text.ToLower(), this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' }).ToLower(), false) == 0)
          {
            item.Text = this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' });
            item.SubItems[1].Text = this.txtMusicianName.Text.TrimEnd(new char[] { ' ' });
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
      ListViewItem item2 = new ListViewItem();
      V2APICFrame frame = new V2APICFrame();
      if (!((StringType.StrCmp(this.txtPicPath.Text, "", false) == 0) | this.txtPicPath.Text.ToLower().EndsWith("mp3")))
      {
        frame.FID = "APIC";
        foreach (ListViewItem item2 in this.PicList.Items)
        {
          if ((((long)-((StringType.StrCmp(item2.Text.ToLower(), this.txtPDescriptor.Text.ToLower(), false) == 0) > false)) & ((long)Math.Round(Conversion.Val(DoubleType.FromString(item2.SubItems[1].Text.Substring(0, 2)) == Conversion.Val(this.cmbPicType.Text.Substring(0, 2)))))) > 0L)
          {
            if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null), this.txtPDescriptor.Text, false) == 0, ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "PicType", new object[0], null, null), Conversion.Val(this.cmbPicType.Text.Substring(0, 2)), false) == 0), ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Path", new object[0], null, null), this.txtPicPath.Text, false) == 0), ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Include", new object[0], null, null), this.chkPicInclude.Checked, false) == 0)))
            {
              return;
            }
            this.alstRemovedAPICFrames.Add(RuntimeHelpers.GetObjectValue(item2.Tag));
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
        this.PicList.Items.Insert(index, item);
        this.txtPDescriptor.Text = "";
        this.txtPicPath.Text = "";
        this.chkPicInclude.Checked = false;
        this.chkPicInclude.Enabled = true;
        this.chkPicRelativPath.Checked = false;
        this.APICView.Image = null;
        this.cmbPicType.SelectedIndex = 0;
        this.btnAddPicture.Enabled = false;
        this.btnExPic.Enabled = false;
      }
    }

    private void btnAddRating_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      ListViewItem item2 = new ListViewItem();
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
        this.RatingList.Items.Add(item);
        this.txtRatingUser.Text = "";
        this.txtRatingRating.Value = decimal.Zero;
        this.txtRatingCounter.Value = decimal.Zero;
      }
    }

    private void btnAddTXXX_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      ListViewItem item2 = new ListViewItem();
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
        this.TXXXList.Items.Add(item);
        this.txtTXXXDesc.Text = "";
        this.txtTXXXContent.Text = "";
      }
    }

    private void btnAddWXXX_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      ListViewItem item2 = new ListViewItem();
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

    private void btnExPic_Click(object sender, EventArgs e)
    {
      V2APICFrame tag = (V2APICFrame)this.PicList.FocusedItem.Tag;
      if (StringType.StrCmp(this.PicList.FocusedItem.SubItems[2].Text, this.MP3.FI.FullName, false) == 0)
      {
        FileStream stream;
        MemoryStream stream2;
        if (StringType.StrCmp(tag.TempPath, "", false) == 0)
        {
          stream = new FileStream(this.MP3.FI.FullName, FileMode.Open);
          stream.Seek((long)tag.DataStart, SeekOrigin.Begin);
          byte[] array = new byte[(tag.DataLength - 1) + 1];
          stream.Read(array, 0, tag.DataLength);
          stream.Close();
          this.SaveFileDialog.Filter = "*.*|*.*";
          this.SaveFileDialog.FilterIndex = 1;
          this.SaveFileDialog.InitialDirectory = this.MP3.FI.DirectoryName;
          try
          {
            this.SaveFileDialog.FileName = this.MP3.FI.Name.Replace(this.MP3.FI.Extension, tag.MIMEType.Substring(tag.MIMEType.LastIndexOf("/") + 1));
            if (this.SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              stream2 = new MemoryStream(array);
              stream = new FileStream(this.SaveFileDialog.FileName, FileMode.OpenOrCreate);
              stream2.WriteTo(stream);
              stream2.Close();
              stream.Close();
            }
            tag.Include = false;
            tag.Path = stream.Name;
            tag.MIMEType = "-->";
            this.PicList.FocusedItem.SubItems[2].Text = stream.Name;
            this.PicList.FocusedItem.SubItems[3].Text = StringType.FromBoolean(false);
            this.MP3.V2TAG.Changed = true;
            this.MP3.Changed = true;
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            Exception exception = exception1;
            stream2.Close();
            stream.Close();
            Interaction.MsgBox(exception.ToString(), MsgBoxStyle.ApplicationModal, null);
            ProjectData.ClearProjectError();
          }
        }
        else
        {
          stream = new FileStream(tag.TempPath, FileMode.Open);
          stream.Seek(0L, SeekOrigin.Begin);
          byte[] buffer2 = new byte[((int)(stream.Length - 1L)) + 1];
          stream.Read(buffer2, 0, buffer2.Length);
          stream.Close();
          this.SaveFileDialog.Filter = "*.*|*.*";
          this.SaveFileDialog.FilterIndex = 1;
          this.SaveFileDialog.InitialDirectory = this.MP3.FI.DirectoryName;
          try
          {
            this.SaveFileDialog.FileName = this.MP3.FI.Name.Replace(this.MP3.FI.Extension, tag.MIMEType.Substring(tag.MIMEType.LastIndexOf("/") + 1));
            if (this.SaveFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
            {
              stream2 = new MemoryStream(buffer2);
              stream = new FileStream(this.SaveFileDialog.FileName, FileMode.OpenOrCreate);
              stream2.WriteTo(stream);
              stream2.Close();
              stream.Close();
            }
            tag.Include = false;
            tag.Path = stream.Name;
            tag.MIMEType = "-->";
            this.PicList.FocusedItem.SubItems[2].Text = stream.Name;
            this.PicList.FocusedItem.SubItems[3].Text = StringType.FromBoolean(false);
            this.MP3.V2TAG.Changed = true;
            this.MP3.Changed = true;
          }
          catch (Exception exception3)
          {
            ProjectData.SetProjectError(exception3);
            Exception exception2 = exception3;
            stream2.Close();
            stream.Close();
            Interaction.MsgBox(exception2.ToString(), MsgBoxStyle.ApplicationModal, null);
            ProjectData.ClearProjectError();
          }
        }
      }
      this.btnExPic.Enabled = false;
    }

    private void btnExport_Click(object sender, EventArgs e)
    {
      if ((StringType.StrCmp(this.cmbArtist.Text, "", false) != 0) & (StringType.StrCmp(this.MP3.V1TAG.Artist, this.cmbArtist.Text, false) != 0))
      {
        this.MP3.V1TAG.Artist = this.cmbArtist.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if ((StringType.StrCmp(this.txtTitle.Text, "", false) != 0) & (StringType.StrCmp(this.MP3.V1TAG.Title, this.txtTitle.Text, false) != 0))
      {
        this.MP3.V1TAG.Title = this.txtTitle.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if ((StringType.StrCmp(this.txtAlbum.Text, "", false) != 0) & (StringType.StrCmp(this.MP3.V1TAG.Album, this.txtAlbum.Text, false) != 0))
      {
        this.MP3.V1TAG.Album = this.txtAlbum.Text;
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if ((StringType.StrCmp(this.txtYear.Text, "", false) != 0) && (StringType.StrCmp(this.MP3.V1TAG.Year.ToString(), this.txtYear.Text.Substring(0, 4), false) != 0))
      {
        this.MP3.V1TAG.Year = (int)Math.Round(Conversion.Val(this.txtYear.Text.Substring(0, 4)));
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if ((StringType.StrCmp(this.txtTrack1.Text, "", false) != 0) & (this.MP3.V1TAG.Tracknumber != Conversion.Val(this.txtTrack1.Text)))
      {
        this.MP3.V1TAG.Tracknumber = (byte)Math.Round(Conversion.Val(this.txtTrack1.Text));
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if ((this.GenreList.Items.Count > 0) && (ObjectType.ObjTst(this.MP3.V1TAG.GenreText, this.GenreList.Items[0], false) != 0))
      {
        this.MP3.V1TAG.GenreText = StringType.FromObject(this.GenreList.Items[0]);
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      if ((this.CommentList.Items.Count > 0) && (ObjectType.ObjTst(this.MP3.V1TAG.Comment, LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Content", new object[0], null, null), false) != 0))
      {
        this.MP3.V1TAG.Comment = StringType.FromObject(LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Content", new object[0], null, null));
        this.MP3.V1TAG.TAGPresent = true;
        this.MP3.Changed = true;
      }
      this.MainForm.UpdateListItem(this.MainForm.MP3View.FocusedItem, false);
    }

    private void btnGet_Click(object sender, EventArgs e)
    {
      string vstrFormat = "";
      FilenameToTAGFormat format = new FilenameToTAGFormat();
      vstrFormat = this.cmbFormat.Text.TrimStart(new char[] { ' ' });
      if (vstrFormat.IndexOf(":") >= 0)
      {
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });
      }
      if (vstrFormat.StartsWith(@"\"))
      {
        vstrFormat = vstrFormat.Substring(1);
      }
      switch (ID3Functions.FormatReplaceCheck(vstrFormat, Declarations.FormatReplace.FilenameToTAG | Declarations.FormatReplace.TAGVer2))
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
      format.Create(vstrFormat, 2);
      ArrayList parts = format.Parts;
      this.GetInfo((ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag, parts);
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
      catch (Exception exception5)
      {
        ProjectData.SetProjectError(exception5);
        Exception exception2 = exception5;
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
          try
          {
            if (this.chkPicRelativPath.Checked)
            {
              this.txtPicPath.Text = Main.GetRelativePath(Path.GetDirectoryName(this.MP3.FI.FullName), this.txtPicPath.Text);
            }
            else
            {
              this.txtPicPath.Text = Path.GetFullPath(this.txtPicPath.Text);
            }
          }
          catch (Exception exception6)
          {
            ProjectData.SetProjectError(exception6);
            Exception exception3 = exception6;
            ProjectData.ClearProjectError();
          }
        }
        catch (Exception exception7)
        {
          ProjectData.SetProjectError(exception7);
          Exception exception4 = exception7;
          Interaction.MsgBox(exception4.Message, MsgBoxStyle.ApplicationModal, null);
          ProjectData.ClearProjectError();
        }
      }
    }

    private void btnImport_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.MP3.V1TAG.Artist, "", false) != 0)
      {
        this.cmbArtist.Text = this.MP3.V1TAG.Artist;
      }
      if (StringType.StrCmp(this.MP3.V1TAG.Title, "", false) != 0)
      {
        this.txtTitle.Text = this.MP3.V1TAG.Title;
      }
      if (StringType.StrCmp(this.MP3.V1TAG.Album, "", false) != 0)
      {
        this.txtAlbum.Text = this.MP3.V1TAG.Album;
      }
      if (this.MP3.V1TAG.Year != 0)
      {
        this.txtYear.Text = this.MP3.V1TAG.Year.ToString().Trim(new char[] { ' ' }).PadLeft(4, '0') + "-01-01";
      }
      if (this.MP3.V1TAG.Tracknumber != 0)
      {
        this.txtTrack1.Text = this.MP3.V1TAG.Tracknumber.ToString();
      }
      if ((StringType.StrCmp(this.MP3.V1TAG.GenreText, "< undefined >", false) != 0) & !this.GenreList.Items.Contains(this.MP3.V1TAG.GenreText))
      {
        this.GenreList.Items.Add(this.MP3.V1TAG.GenreText);
      }
      if (StringType.StrCmp(this.MP3.V1TAG.Comment, "", false) != 0)
      {
        ListViewItem item = new ListViewItem();
        ListViewItem item2 = new ListViewItem();
        V2LDCFrame frame = new V2LDCFrame
        {
          FID = "COMM",
          Descriptor = "TAG Ver. 1 Comment",
          Content = this.MP3.V1TAG.Comment,
          Language = StringType.FromObject(LateBinding.LateGet(this.cmbCLanguage.Items[Declarations.objSettings.V2Language], null, "Substring", new object[] {
                        0,
                        3
                    }, null, null))
        };
        foreach (ListViewItem item2 in this.CommentList.Items)
        {
          if ((StringType.StrCmp(item2.Text, frame.Descriptor, false) == 0) & (StringType.StrCmp(item2.SubItems[2].Text, frame.Language, false) == 0))
          {
            item2.SubItems[1].Text = this.MP3.V1TAG.Comment;
            item2.Tag = frame;
            return;
          }
        }
        item.Text = frame.Descriptor;
        item.SubItems.Add(frame.Content);
        object[] objArray3 = new object[1];
        object o = this.cmbCLanguage.Items[Declarations.objSettings.V2Language];
        object[] args = new object[2];
        int num3 = 0;
        args[0] = num3;
        int num = 3;
        args[1] = num;
        objArray3[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(o, null, "Substring", args, null, null));
        object[] objArray2 = objArray3;
        bool[] copyBack = new bool[] { true };
        LateBinding.LateCall(item.SubItems, null, "Add", objArray2, null, copyBack);
        if (copyBack[0])
        {
          LateBinding.LateSetComplex(o, null, "Substring", new object[] { num3, num, RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, true);
        }
        item.Tag = frame;
        this.CommentList.Items.Add(item);
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
      this.panNot.Visible = false;
      this.panInvolved.Visible = false;
      this.panUser.Visible = false;
      this.panMain.Enabled = false;
      this.panDetail.Enabled = false;
      this.panOriginal.Enabled = false;
      this.panWeb.Enabled = false;
      this.panRating.Enabled = false;
      this.panPic.Enabled = false;
      this.panLyrics.Enabled = false;
      this.panNot.Enabled = false;
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
      else if (ObjectType.ObjTst(obj2, "TAGV2ButtonItem10", false) == 0)
      {
        this.panNot.Visible = true;
        this.panNot.Enabled = true;
        this.panNot.Dock = DockStyle.Fill;
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
          this.FocusControl.Focus();
        }
      }
      else if (this.ActiveControl == this.btnNext)
      {
        this.FocusControl.Focus();
      }
      if (this.ActiveControl is System.Windows.Forms.TextBox)
      {
        System.Windows.Forms.TextBox activeControl = (System.Windows.Forms.TextBox)this.ActiveControl;
        activeControl.Select(0, activeControl.Text.Length);
      }
      else if (this.ActiveControl is ComboBox)
      {
        ComboBox box2 = (ComboBox)this.ActiveControl;
        box2.Select(0, box2.Text.Length);
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
      Main.SaveFormSettings(ref form);
      Declarations.objSettings.FT2Format = this.cmbFormat.Text;
      Declarations.objSettings.V2Language = this.cmbCLanguage.SelectedIndex;
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
          this.FocusControl.Focus();
        }
      }
      else if (this.ActiveControl == this.btnPrev)
      {
        this.FocusControl.Focus();
      }
      if (this.ActiveControl is System.Windows.Forms.TextBox)
      {
        System.Windows.Forms.TextBox activeControl = (System.Windows.Forms.TextBox)this.ActiveControl;
        activeControl.Select(0, activeControl.Text.Length);
      }
      else if (this.ActiveControl is ComboBox)
      {
        ComboBox box2 = (ComboBox)this.ActiveControl;
        box2.Select(0, box2.Text.Length);
      }
    }

    private void btnRemoveComment_Click(object sender, EventArgs e)
    {
      try
      {
        this.alstRemovedLDCFrames.Add(RuntimeHelpers.GetObjectValue(this.CommentList.FocusedItem.Tag));
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
        this.alstRemovedLDCFrames.Add(RuntimeHelpers.GetObjectValue(this.LyricsList.FocusedItem.Tag));
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
        this.alstRemovedAPICFrames.Add(RuntimeHelpers.GetObjectValue(this.PicList.FocusedItem.Tag));
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
      this.btnExPic.Enabled = false;
    }

    private void btnRemoveRating_Click(object sender, EventArgs e)
    {
      try
      {
        this.alstRemovedPOPMFrames.Add(RuntimeHelpers.GetObjectValue(this.RatingList.FocusedItem.Tag));
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
        this.alstRemovedTXXXFrames.Add(RuntimeHelpers.GetObjectValue(this.TXXXList.FocusedItem.Tag));
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
        this.alstRemovedWXXXFrames.Add(RuntimeHelpers.GetObjectValue(this.WXXXList.FocusedItem.Tag));
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

    private void btnTLEN_Click(object sender, EventArgs e)
    {
      this.txtTLEN.Text = this.MP3.DurationMS.ToString();
    }

    private void btnV1Album_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.MP3.V1TAG.Album, "", false) != 0)
      {
        this.txtAlbum.Text = this.MP3.V1TAG.Album;
      }
    }

    private void btnV1Artist_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.MP3.V1TAG.Artist, "", false) != 0)
      {
        this.cmbArtist.Text = this.MP3.V1TAG.Artist;
      }
    }

    private void btnV1Comment_Click(object sender, EventArgs e)
    {
      if (!Declarations.objSettings.SingleGC)
      {
        if (StringType.StrCmp(this.MP3.V1TAG.Comment, "", false) != 0)
        {
          ListViewItem item = new ListViewItem();
          ListViewItem item2 = new ListViewItem();
          V2LDCFrame frame = new V2LDCFrame
          {
            FID = "COMM",
            Descriptor = "TAG Ver. 1 Comment",
            Content = this.MP3.V1TAG.Comment,
            Language = StringType.FromObject(LateBinding.LateGet(this.cmbCLanguage.Items[Declarations.objSettings.V2Language], null, "Substring", new object[] {
                            0,
                            3
                        }, null, null))
          };
          foreach (ListViewItem item2 in this.CommentList.Items)
          {
            if ((StringType.StrCmp(item2.Text, frame.Descriptor, false) == 0) & (StringType.StrCmp(item2.SubItems[2].Text, frame.Language, false) == 0))
            {
              item2.SubItems[1].Text = this.MP3.V1TAG.Comment;
              item2.Tag = frame;
              return;
            }
          }
          item.Text = frame.Descriptor;
          item.SubItems.Add(frame.Content);
          object[] objArray3 = new object[1];
          object o = this.cmbCLanguage.Items[Declarations.objSettings.V2Language];
          object[] args = new object[2];
          int num2 = 0;
          args[0] = num2;
          int num = 3;
          args[1] = num;
          objArray3[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(o, null, "Substring", args, null, null));
          object[] objArray2 = objArray3;
          bool[] copyBack = new bool[] { true };
          LateBinding.LateCall(item.SubItems, null, "Add", objArray2, null, copyBack);
          if (copyBack[0])
          {
            LateBinding.LateSetComplex(o, null, "Substring", new object[] { num2, num, RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, true);
          }
          item.Tag = frame;
          this.CommentList.Items.Add(item);
        }
      }
      else if (StringType.StrCmp(this.MP3.V1TAG.Comment, "", false) != 0)
      {
        this.cmbCDescriptor.Text = "TAG Ver. 1 Comment";
        this.txtComment.Text = this.MP3.V1TAG.Comment;
      }
    }

    private void btnV1Genre_Click(object sender, EventArgs e)
    {
      if (!Declarations.objSettings.SingleGC)
      {
        if ((StringType.StrCmp(this.MP3.V1TAG.GenreText, "< undefined >", false) != 0) & !this.GenreList.Items.Contains(this.MP3.V1TAG.GenreText))
        {
          this.GenreList.Items.Add(this.MP3.V1TAG.GenreText);
        }
      }
      else if (StringType.StrCmp(this.MP3.V1TAG.GenreText, "< undefined >", false) != 0)
      {
        this.cmbGenre.Text = this.MP3.V1TAG.GenreText;
      }
    }

    private void btnV1Title_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.MP3.V1TAG.Title, "", false) != 0)
      {
        this.txtTitle.Text = this.MP3.V1TAG.Title;
      }
    }

    private void btnV1Track_Click(object sender, EventArgs e)
    {
      if (this.MP3.V1TAG.Tracknumber != 0)
      {
        this.txtTrack1.Text = this.MP3.V1TAG.Tracknumber.ToString();
      }
    }

    private void btnV1Year_Click(object sender, EventArgs e)
    {
      if (this.MP3.V1TAG.Year != 0)
      {
        this.txtYear.Text = this.MP3.V1TAG.Year.ToString().Trim(new char[] { ' ' }).PadLeft(4, '0') + "-01-01";
      }
    }

    private void chkPicInclude_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.chkPicInclude.Checked)
        {
          this.chkPicRelativPath.Checked = false;
        }
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }
    }

    private void chkPicRelativPath_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.chkPicRelativPath.Checked)
        {
          this.chkPicInclude.Checked = false;
          this.txtPicPath.Text = Main.GetRelativePath(Path.GetDirectoryName(this.MP3.FI.FullName), this.txtPicPath.Text);
        }
        else
        {
          this.txtPicPath.Text = Path.GetFullPath(this.txtPicPath.Text);
        }
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }
    }

    private void ClearForm()
    {
      this.cmbArtist.Text = "";
      this.txtTitle.Text = "";
      this.txtAlbum.Text = "";
      this.txtTrack1.Text = "";
      this.txtTrack2.Text = "";
      this.txtPOS1.Text = "";
      this.txtPOS2.Text = "";
      this.txtBPM.Text = "";
      this.txtTLEN.Text = "";
      this.txtBand.Text = "";
      this.txtConductor.Text = "";
      this.txtModified.Text = "";
      this.txtContent.Text = "";
      this.txtSubTitle.Text = "";
      this.txtComposer.Text = "";
      this.txtSortArtist.Text = "";
      this.txtSortAlbum.Text = "";
      this.txtSortTitle.Text = "";
      this.txtLyWriter.Text = "";
      this.txtPublisher.Text = "";
      this.txtEncoded.Text = "";
      this.txtCopyright.Text = "";
      this.txtInvFunction.Text = "";
      this.txtInvPerson.Text = "";
      this.TIPLList.Items.Clear();
      this.txtMusicianInst.Text = "";
      this.txtMusicianName.Text = "";
      this.TMCLList.Items.Clear();
      this.txtOAlbum.Text = "";
      this.txtOFilename.Text = "";
      this.txtOArtist.Text = "";
      this.txtOLyWriter.Text = "";
      this.txtOOwner.Text = "";
      this.txtYear.Text = "";
      this.txtTORY.Text = "";
      this.cmbMedia.Text = "";
      this.cmbGenre.Text = "";
      this.GenreList.Items.Clear();
      this.cmbCDescriptor.Text = "";
      this.txtComment.Text = "";
      this.CommentList.Items.Clear();
      this.txtLDescriptor.Text = "";
      this.txtLyrics.Text = "";
      this.LyricsList.Items.Clear();
      this.txtPDescriptor.Text = "";
      this.txtPicPath.Text = "";
      this.chkPicInclude.Checked = false;
      this.PicList.Items.Clear();
      this.APICView.Image = null;
      this.txtCOMMInfURL.Text = "";
      this.txtCopyInfURL.Text = "";
      this.txtAudioFileURL.Text = "";
      this.txtArtistURL.Text = "";
      this.txtAudioSRCURL.Text = "";
      this.txtINetRadioURL.Text = "";
      this.txtPayURL.Text = "";
      this.txtPubURL.Text = "";
      this.txtRatingUser.Text = "";
      this.txtRatingRating.Value = decimal.Zero;
      this.txtRatingCounter.Value = decimal.Zero;
      this.RatingList.Items.Clear();
      this.txtTXXXDesc.Text = "";
      this.txtTXXXContent.Text = "";
      this.TXXXList.Items.Clear();
      this.txtWXXXDesc.Text = "";
      this.txtWXXXContent.Text = "";
      this.WXXXList.Items.Clear();
      this.NotSupportList.Items.Clear();
    }

    private void CommentList_Click(object sender, EventArgs e)
    {
      this.cmbCDescriptor.Text = this.CommentList.FocusedItem.Text;
      using (IEnumerator enumerator = this.cmbCLanguage.Items.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          string str = StringType.FromObject(enumerator.Current);
          if (str.StartsWith(this.CommentList.FocusedItem.SubItems[2].Text))
          {
            this.cmbCLanguage.SelectedItem = str;
            goto Label_0089;
          }
        }
      }
      Label_0089:
      this.txtComment.Text = this.CommentList.FocusedItem.SubItems[1].Text.Replace("\n", "\r\n");
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
      object objectValue;
      object[] objArray;
      bool[] flagArray;
      object[] objArray2;
      object[] objArray3;
      object[] objArray4;
      string str4;
      string[] strArray6;
      object obj5;
      this.cmbArtist.Autocomplete = false;
      this.cmbGenre.Autocomplete = false;
      this.YearFormat.Value = Declarations.objSettings.V2YearOnly;
      this.TORYFormat.Value = Declarations.objSettings.V2YearOnly;
      this.txtSelected.Text = this.MP3.CurrentFullName;
      this.cmbArtist.Text = this.MP3.V2TAG.GetTextWebFrameContent("TPE1");
      this.txtTitle.Text = this.MP3.V2TAG.GetTextWebFrameContent("TIT2");
      this.txtAlbum.Text = this.MP3.V2TAG.GetTextWebFrameContent("TALB");
      this.txtBand.Text = this.MP3.V2TAG.GetTextWebFrameContent("TPE2");
      this.txtConductor.Text = this.MP3.V2TAG.GetTextWebFrameContent("TPE3");
      this.txtModified.Text = this.MP3.V2TAG.GetTextWebFrameContent("TPE4");
      this.txtContent.Text = this.MP3.V2TAG.GetTextWebFrameContent("TIT1");
      this.txtSubTitle.Text = this.MP3.V2TAG.GetTextWebFrameContent("TIT3");
      this.txtComposer.Text = this.MP3.V2TAG.GetTextWebFrameContent("TCOM");
      this.txtCopyright.Text = this.MP3.V2TAG.GetTextWebFrameContent("TCOP");
      this.txtSortArtist.Text = this.MP3.V2TAG.GetTextWebFrameContent("TSOP");
      this.txtSortAlbum.Text = this.MP3.V2TAG.GetTextWebFrameContent("TSOA");
      this.txtSortTitle.Text = this.MP3.V2TAG.GetTextWebFrameContent("TSOT");
      this.txtLyWriter.Text = this.MP3.V2TAG.GetTextWebFrameContent("TEXT");
      this.txtPublisher.Text = this.MP3.V2TAG.GetTextWebFrameContent("TPUB");
      this.txtEncoded.Text = this.MP3.V2TAG.GetTextWebFrameContent("TENC");
      this.txtOAlbum.Text = this.MP3.V2TAG.GetTextWebFrameContent("TOAL");
      this.txtOFilename.Text = this.MP3.V2TAG.GetTextWebFrameContent("TOFN");
      this.txtOArtist.Text = this.MP3.V2TAG.GetTextWebFrameContent("TOPE");
      this.txtOLyWriter.Text = this.MP3.V2TAG.GetTextWebFrameContent("TOLY");
      this.txtOOwner.Text = this.MP3.V2TAG.GetTextWebFrameContent("TOWN");
      this.cmbMedia.Text = this.MP3.V2TAG.GetTextWebFrameContent("TMED");
      try
      {
        this.txtTLEN.Text = this.MP3.V2TAG.GetTextWebFrameContent("TLEN");
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        this.txtTLEN.Text = "";
        ProjectData.ClearProjectError();
      }
      if (this.MP3.V2TAG.FrameExists("TRCK"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(this.MP3.V2TAG.GetFrame("TRCK"));
        if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
        {
          try
          {
            this.txtTrack1.Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null));
          }
          catch (Exception exception2)
          {
            ProjectData.SetProjectError(exception2);
            this.txtTrack1.Text = "";
            ProjectData.ClearProjectError();
          }
          this.txtTrack2.Text = "";
        }
        else
        {
          try
          {
            objArray3 = new object[2];
            objArray3[0] = 0;
            obj5 = objectValue;
            object[] args = new object[0];
            strArray6 = null;
            objArray4 = new object[1];
            str4 = "/";
            objArray4[0] = str4;
            objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj5, null, "Content", args, strArray6, null), null, "IndexOf", objArray4, null, null));
            objArray2 = objArray3;
            flagArray = new bool[] { false, true };
            if (flagArray[1])
            {
              LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", args, strArray6, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray2[1]) }, null, true, true);
            }
            this.txtTrack1.Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray2, null, flagArray));
          }
          catch (Exception exception3)
          {
            ProjectData.SetProjectError(exception3);
            this.txtTrack1.Text = "";
            ProjectData.ClearProjectError();
          }
          try
          {
            this.txtTrack2.Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", new object[] { ObjectType.AddObj(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 1) }, null, null));
          }
          catch (Exception exception4)
          {
            ProjectData.SetProjectError(exception4);
            this.txtTrack2.Text = "";
            ProjectData.ClearProjectError();
          }
        }
      }
      if (this.MP3.V2TAG.FrameExists("TPOS"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(this.MP3.V2TAG.GetFrame("TPOS"));
        if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
        {
          try
          {
            this.txtPOS1.Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null));
          }
          catch (Exception exception5)
          {
            ProjectData.SetProjectError(exception5);
            this.txtPOS1.Text = "";
            ProjectData.ClearProjectError();
          }
          this.txtPOS2.Text = "";
        }
        else
        {
          try
          {
            objArray3 = new object[2];
            objArray3[0] = 0;
            obj5 = objectValue;
            objArray = new object[0];
            strArray6 = null;
            objArray2 = new object[1];
            str4 = "/";
            objArray2[0] = str4;
            objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj5, null, "Content", objArray, strArray6, null), null, "IndexOf", objArray2, null, null));
            objArray4 = objArray3;
            flagArray = new bool[] { false, true };
            if (flagArray[1])
            {
              LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", objArray, strArray6, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);
            }
            this.txtPOS1.Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray));
          }
          catch (Exception exception6)
          {
            ProjectData.SetProjectError(exception6);
            this.txtPOS1.Text = "";
            ProjectData.ClearProjectError();
          }
          try
          {
            this.txtPOS2.Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", new object[] { ObjectType.AddObj(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 1) }, null, null));
          }
          catch (Exception exception7)
          {
            ProjectData.SetProjectError(exception7);
            this.txtPOS2.Text = "";
            ProjectData.ClearProjectError();
          }
        }
      }
      if (this.MP3.V2TAG.FrameExists("TCON"))
      {
        foreach (string str2 in Strings.Split(this.MP3.V2TAG.GetTextWebFrameContent("TCON"), "\0", -1, CompareMethod.Binary))
        {
          if (StringType.StrCmp(str2, "", false) != 0)
          {
            if ((str2.Length > 2) && Information.IsNumeric(str2.Replace("(", "").Replace(")", "")))
            {
              if ((Conversion.Val(str2.Replace("(", "").Replace(")", "")) >= 0.0) & (Conversion.Val(str2.Replace("(", "").Replace(")", "")) < 148.0))
                str2 = Declarations.astrGenreLookup[(int)Math.Round(Conversion.Val(str2.Replace("(", "").Replace(")", "")))];
              else
                str2 = "< undefined >";
            }
            this.GenreList.Items.Add(str2);
          }
        }
      }
      if (this.MP3.V2TAG.FrameExists("TIPL"))
      {
        string[] strArray2 = Strings.Split(this.MP3.V2TAG.GetTextWebFrameContent("TIPL"), "\0", -1, CompareMethod.Binary);
        int length = strArray2.GetLength(0);
        if ((length / 2) != 0)
          length--;
        int num13 = length - 1;
        for (int i = 0; i <= num13; i += 2)
        {
          ListViewItem item = new ListViewItem
          {
            Text = strArray2[i],
            SubItems = { strArray2[i + 1] }
          };
          this.TIPLList.Items.Add(item);
        }
      }
      if (this.MP3.V2TAG.FrameExists("TMCL"))
      {
        string[] strArray3 = Strings.Split(this.MP3.V2TAG.GetTextWebFrameContent("TMCL"), "\0", -1, CompareMethod.Binary);
        int num4 = strArray3.GetLength(0);
        if ((num4 / 2) != 0)
          num4--;
        int num12 = num4 - 1;
        for (int j = 0; j <= num12; j += 2)
        {
          ListViewItem item2 = new ListViewItem
          {
            Text = strArray3[j],
            SubItems = { strArray3[j + 1] }
          };
          this.TMCLList.Items.Add(item2);
        }
      }
      if (this.MP3.V2TAG.FrameExists("IPLS"))
      {
        string[] strArray4 = Strings.Split(this.MP3.V2TAG.GetTextWebFrameContent("IPLS"), "\0", -1, CompareMethod.Binary);
        int num6 = strArray4.GetLength(0);
        if ((num6 / 2) != 0)
          num6--;
        int num11 = num6 - 1;
        for (int k = 0; k <= num11; k += 2)
        {
          ListViewItem item3 = new ListViewItem
          {
            Text = strArray4[k],
            SubItems = { strArray4[k + 1] }
          };
          this.TIPLList.Items.Add(item3);
        }
      }
      try
      {
        int num7 = (int)Math.Round(Conversion.Fix(Conversion.Val(this.MP3.V2TAG.GetTextWebFrameContent("TBPM").Trim(new char[] { ' ' }))));
        this.txtBPM.Text = StringType.FromObject(Interaction.IIf(num7 > 0, num7.ToString(), ""));
      }
      catch (Exception exception8)
      {
        ProjectData.SetProjectError(exception8);
        this.MP3.V2TAG.RemoveFrame("TBPM");
        this.txtBPM.Text = "";
        ProjectData.ClearProjectError();
      }
      string str = "yyyy-MM-dd";
      if (this.MP3.V2TAG.FrameExists("TYER"))
      {
        object obj3;
        objectValue = RuntimeHelpers.GetObjectValue(this.MP3.V2TAG.GetFrame("TYER"));
        if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Length", new object[0], null, null), 4, false) > 0)
          LateBinding.LateSet(objectValue, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 4 }, null, null))).ToString() }, null);
        if (Convert.ToInt32(Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)))) >= 0)
        {
          str = str.Replace("yyyy", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "PadLeft", new object[] { 4, "0" }, null, null)));
          if (this.MP3.V2TAG.FrameExists("TDAT"))
          {
            obj3 = RuntimeHelpers.GetObjectValue(this.MP3.V2TAG.GetFrame("TDAT"));
            str = str.Replace("MM", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(obj3, null, "Content", new object[0], null, null), null, "Substring", new object[] { 2, 2 }, null, null))).Replace("dd", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(obj3, null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 2 }, null, null)));
            this.txtYear.Mask = "####-##-##";
            this.YearFormat.Value = 2;
          }
          if (str.IndexOf("MM") >= 0)
          {
            this.txtYear.Mask = "####";
            this.YearFormat.Value = 0;
          }
        }
        else
        {
          str = str.Replace("yyyy", StringType.FromInteger(DateTime.Now.Year));
          if (this.MP3.V2TAG.FrameExists("TDAT"))
          {
            obj3 = RuntimeHelpers.GetObjectValue(this.MP3.V2TAG.GetFrame("TDAT"));
            str = str.Replace("MM", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(obj3, null, "Content", new object[0], null, null), null, "Substring", new object[] { 2, 2 }, null, null))).Replace("dd", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(obj3, null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 2 }, null, null)));
            this.txtYear.Mask = "####-##-##";
            this.YearFormat.Value = 2;
          }
          if (str.IndexOf("MM") >= 0)
          {
            this.txtYear.Mask = "####";
            this.YearFormat.Value = 0;
          }
        }
      }
      else if (this.MP3.V2TAG.FrameExists("TDRC"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(this.MP3.V2TAG.GetFrame("TDRC"));
        if ((ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Length", new object[0], null, null), 4, false) >= 0) && (Convert.ToInt32(Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 4 }, null, null)))) >= 0))
        {
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "T" }, null, null), 0, false) < 0)
          {
            str = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "PadLeft", new object[] { 4, "0" }, null, null));
            if (str.Length == 10)
              this.YearFormat.Value = 2;
            if (str.Length == 7)
            {
              str = str + "-01";
              this.YearFormat.Value = 1;
            }
            if (str.Length == 4)
            {
              str = str + "-01-01";
              this.YearFormat.Value = 0;
            }
          }
          else
          {
            objArray3 = new object[2];
            objArray3[0] = 0;
            obj5 = objectValue;
            objArray = new object[0];
            strArray6 = null;
            objArray2 = new object[1];
            str4 = "T";
            objArray2[0] = str4;
            objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj5, null, "Content", objArray, strArray6, null), null, "IndexOf", objArray2, null, null));
            objArray4 = objArray3;
            flagArray = new bool[] { false, true };
            if (flagArray[1])
            {
              LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", objArray, strArray6, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);
            }
            str = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray));
          }
        }
      }
      else
      {
        str = "";
      }
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
      str = str.Replace("dd", "01").Replace("MM", "01").Replace("yyyy", StringType.FromInteger(DateTime.Now.Year));
      try
      {
        this.txtYear.Text = str;
      }
      catch (Exception exception9)
      {
        ProjectData.SetProjectError(exception9);
        this.txtYear.Text = "";
        ProjectData.ClearProjectError();
      }
      str = "yyyy-MM-dd";
      if (this.MP3.V2TAG.FrameExists("TORY"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(this.MP3.V2TAG.GetFrame("TORY"));
        if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Length", new object[0], null, null), 4, false) > 0)
        {
          LateBinding.LateSet(objectValue, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 4 }, null, null))).ToString() }, null);
        }
        if (Convert.ToInt32(Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)))) >= 0)
        {
          str = str.Replace("yyyy", StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)));
          if (str.IndexOf("MM") >= 0)
          {
            this.txtTORY.Mask = "####";
            this.TORYFormat.Value = 0;
          }
        }
        else
        {
          str = str.Replace("yyyy", StringType.FromInteger(DateTime.Now.Year));
          if (str.IndexOf("MM") >= 0)
          {
            this.txtTORY.Mask = "####";
            this.TORYFormat.Value = 0;
          }
        }
      }
      else if (this.MP3.V2TAG.FrameExists("TDOR"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(this.MP3.V2TAG.GetFrame("TDOR"));
        if ((ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Length", new object[0], null, null), 4, false) >= 0) && (Convert.ToInt32(Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 4 }, null, null)))) >= 0))
        {
          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "T" }, null, null), 0, false) < 0)
          {
            str = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null));
            if (str.Length == 10)
              this.TORYFormat.Value = 2;
            if (str.Length == 7)
            {
              str = str + "-01";
              this.TORYFormat.Value = 1;
            }
            if (str.Length == 4)
            {
              str = str + "-01-01";
              this.TORYFormat.Value = 0;
            }
          }
          else
          {
            objArray3 = new object[2];
            objArray3[0] = 0;
            obj5 = objectValue;
            objArray = new object[0];
            strArray6 = null;
            objArray2 = new object[1];
            str4 = "T";
            objArray2[0] = str4;
            objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj5, null, "Content", objArray, strArray6, null), null, "IndexOf", objArray2, null, null));
            objArray4 = objArray3;
            flagArray = new bool[] { false, true };
            if (flagArray[1])
            {
              LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", objArray, strArray6, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);
            }
            str = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray));
          }
        }
      }
      else
      {
        str = "";
      }
      switch (this.TORYFormat.Value)
      {
        case 0:
          this.txtTORY.Mask = "####";
          break;

        case 1:
          this.txtTORY.Mask = "####-##";
          break;

        case 2:
          this.txtTORY.Mask = "####-##-##";
          break;
      }
      str = str.Replace("dd", "01").Replace("MM", "01").Replace("yyyy", StringType.FromInteger(DateTime.Now.Year));
      try
      {
        this.txtTORY.Text = str;
      }
      catch (Exception exception10)
      {
        ProjectData.SetProjectError(exception10);
        this.txtTORY.Text = "";
        ProjectData.ClearProjectError();
      }
      this.txtCOMMInfURL.Text = this.MP3.V2TAG.GetTextWebFrameContent("WCOM");
      this.txtCopyInfURL.Text = this.MP3.V2TAG.GetTextWebFrameContent("WCOP");
      this.txtAudioFileURL.Text = this.MP3.V2TAG.GetTextWebFrameContent("WOAF");
      this.txtArtistURL.Text = this.MP3.V2TAG.GetTextWebFrameContent("WOAR");
      this.txtAudioSRCURL.Text = this.MP3.V2TAG.GetTextWebFrameContent("WOAS");
      this.txtINetRadioURL.Text = this.MP3.V2TAG.GetTextWebFrameContent("WORS");
      this.txtPayURL.Text = this.MP3.V2TAG.GetTextWebFrameContent("WPAY");
      this.txtPubURL.Text = this.MP3.V2TAG.GetTextWebFrameContent("WPUB");

      foreach (var frameItem in this.MP3.V2TAG.GetFrames("COMM"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(frameItem);
        ListViewItem item4 = new ListViewItem
        {
          Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Descriptor", new object[0], null, null))
        };
        objArray = new object[1];
        obj5 = objectValue;
        objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj5, null, "Content", new object[0], null, null));
        objArray2 = objArray;
        flagArray = new bool[] { true };
        LateBinding.LateCall(item4.SubItems, null, "Add", objArray2, null, flagArray);
        if (flagArray[0])
          LateBinding.LateSetComplex(obj5, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);
        objArray = new object[1];
        obj5 = objectValue;
        objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj5, null, "Language", new object[0], null, null));
        objArray2 = objArray;
        flagArray = new bool[] { true };
        LateBinding.LateCall(item4.SubItems, null, "Add", objArray2, null, flagArray);
        if (flagArray[0])
        {
          LateBinding.LateSetComplex(obj5, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);
        }
        item4.Tag = RuntimeHelpers.GetObjectValue(objectValue);
        this.CommentList.Items.Add(item4);
      }

      foreach (var frameItem in this.MP3.V2TAG.GetFrames("USLT"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(frameItem);
        ListViewItem item5 = new ListViewItem
        {
          Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Descriptor", new object[0], null, null))
        };
        objArray = new object[1];
        obj5 = objectValue;
        objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj5, null, "Content", new object[0], null, null));
        objArray2 = objArray;
        flagArray = new bool[] { true };
        LateBinding.LateCall(item5.SubItems, null, "Add", objArray2, null, flagArray);
        if (flagArray[0])
        {
          LateBinding.LateSetComplex(obj5, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);
        }
        objArray = new object[1];
        obj5 = objectValue;
        objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj5, null, "Language", new object[0], null, null));
        objArray2 = objArray;
        flagArray = new bool[] { true };
        LateBinding.LateCall(item5.SubItems, null, "Add", objArray2, null, flagArray);
        if (flagArray[0])
        {
          LateBinding.LateSetComplex(obj5, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);
        }
        item5.Tag = RuntimeHelpers.GetObjectValue(objectValue);
        this.LyricsList.Items.Add(item5);
      }

      foreach (var frameItem in this.MP3.V2TAG.GetFrames("APIC"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(frameItem);
        ListViewItem item6 = new ListViewItem
        {
          Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Descriptor", new object[0], null, null))
        };
        objArray2 = new object[1];
        ComboBox.ObjectCollection items = this.cmbPicType.Items;
        obj5 = objectValue;
        objArray = new object[0];
        strArray6 = null;
        objArray2[0] = RuntimeHelpers.GetObjectValue(items[IntegerType.FromObject(LateBinding.LateGet(obj5, null, "PicType", objArray, strArray6, null))]);
        objArray3 = objArray2;
        flagArray = new bool[] { true };
        LateBinding.LateCall(item6.SubItems, null, "Add", objArray3, null, flagArray);
        if (flagArray[0])
          items[IntegerType.FromObject(LateBinding.LateGet(obj5, null, "PicType", objArray, strArray6, null))] = RuntimeHelpers.GetObjectValue(objArray3[0]);
        objArray = new object[1];
        obj5 = objectValue;
        objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj5, null, "Path", new object[0], null, null));
        objArray2 = objArray;
        flagArray = new bool[] { true };
        LateBinding.LateCall(item6.SubItems, null, "Add", objArray2, null, flagArray);
        if (flagArray[0])
          LateBinding.LateSetComplex(obj5, null, "Path", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);
        item6.SubItems.Add(LateBinding.LateGet(objectValue, null, "Include", new object[0], null, null).ToString());
        if (ObjectType.ObjTst(Path.GetFullPath(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Path", new object[0], null, null))), LateBinding.LateGet(objectValue, null, "Path", new object[0], null, null), false) != 0)
          item6.Font = new Font(item6.Font, FontStyle.Bold);
        item6.Tag = RuntimeHelpers.GetObjectValue(objectValue);
        this.PicList.Items.Add(item6);
      }

      foreach (var frameItem in this.MP3.V2TAG.GetFrames("POPM"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(frameItem);
        ListViewItem item7 = new ListViewItem
        {
          Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "User", new object[0], null, null)),
          SubItems = {
                            LateBinding.LateGet(objectValue, null, "Rating", new object[0], null, null).ToString(),
                            LateBinding.LateGet(objectValue, null, "Counter", new object[0], null, null).ToString()
                        },
          Tag = RuntimeHelpers.GetObjectValue(objectValue)
        };
        this.RatingList.Items.Add(item7);
      }

      foreach (var frameItem in this.MP3.V2TAG.GetFrames("TXXX"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(frameItem);
        ListViewItem item8 = new ListViewItem
        {
          Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Descriptor", new object[0], null, null))
        };
        objArray = new object[1];
        obj5 = objectValue;
        objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj5, null, "Content", new object[0], null, null));
        objArray2 = objArray;
        flagArray = new bool[] { true };
        LateBinding.LateCall(item8.SubItems, null, "Add", objArray2, null, flagArray);
        if (flagArray[0])
          LateBinding.LateSetComplex(obj5, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);
        item8.Tag = RuntimeHelpers.GetObjectValue(objectValue);
        this.TXXXList.Items.Add(item8);
      }
      foreach (var frameItem in this.MP3.V2TAG.GetFrames("WXXX"))
      {
        objectValue = RuntimeHelpers.GetObjectValue(frameItem);
        ListViewItem item9 = new ListViewItem
        {
          Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Descriptor", new object[0], null, null))
        };
        objArray = new object[1];
        obj5 = objectValue;
        objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj5, null, "Content", new object[0], null, null));
        objArray2 = objArray;
        flagArray = new bool[] { true };
        LateBinding.LateCall(item9.SubItems, null, "Add", objArray2, null, flagArray);
        if (flagArray[0])
          LateBinding.LateSetComplex(obj5, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);
        item9.Tag = RuntimeHelpers.GetObjectValue(objectValue);
        this.WXXXList.Items.Add(item9);
      }
      if (!Declarations.objSettings.SingleGC)
        goto Label_22A4;
      if (this.GenreList.Items.Count > 0)
        this.cmbGenre.Text = StringType.FromObject(this.GenreList.Items[0]);
      if (this.CommentList.Items.Count <= 0)
        goto Label_22A4;
      this.cmbCDescriptor.Text = StringType.FromObject(LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Descriptor", new object[0], null, null));

      foreach (var langItem in this.cmbCLanguage.Items)
      {
        string str3 = StringType.FromObject(langItem);
        if (str3.StartsWith(StringType.FromObject(LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Language", new object[0], null, null))))
        {
          this.cmbCLanguage.SelectedItem = str3;
          goto Label_226B;
        }
      }
      Label_226B:
      this.txtComment.Text = StringType.FromObject(LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Content", new object[0], null, null));
      Label_22A4:

      foreach (var frameItem in this.MP3.V2TAG.GetAllSupportedFrames())
      {
        objectValue = RuntimeHelpers.GetObjectValue(frameItem);
        object obj4 = LateBinding.LateGet(objectValue, null, "FID", new object[0], null, null);
        if (((((((ObjectType.ObjTst(obj4, "TPE1", false) != 0) && (ObjectType.ObjTst(obj4, "TPE2", false) != 0)) && ((ObjectType.ObjTst(obj4, "TPE3", false) != 0) && (ObjectType.ObjTst(obj4, "TPE4", false) != 0))) && (((ObjectType.ObjTst(obj4, "TIT1", false) != 0) && (ObjectType.ObjTst(obj4, "TIT2", false) != 0)) && ((ObjectType.ObjTst(obj4, "TIT3", false) != 0) && (ObjectType.ObjTst(obj4, "TALB", false) != 0)))) && ((((ObjectType.ObjTst(obj4, "TRCK", false) != 0) && (ObjectType.ObjTst(obj4, "TBPM", false) != 0)) && ((ObjectType.ObjTst(obj4, "TCOM", false) != 0) && (ObjectType.ObjTst(obj4, "TCON", false) != 0))) && (((ObjectType.ObjTst(obj4, "TDAT", false) != 0) && (ObjectType.ObjTst(obj4, "TENC", false) != 0)) && ((ObjectType.ObjTst(obj4, "TMED", false) != 0) && (ObjectType.ObjTst(obj4, "TYER", false) != 0))))) && (((((ObjectType.ObjTst(obj4, "TEXT", false) != 0) && (ObjectType.ObjTst(obj4, "TPUB", false) != 0)) && ((ObjectType.ObjTst(obj4, "TOAL", false) != 0) && (ObjectType.ObjTst(obj4, "TOFN", false) != 0))) && (((ObjectType.ObjTst(obj4, "TOPE", false) != 0) && (ObjectType.ObjTst(obj4, "TDRC", false) != 0)) && ((ObjectType.ObjTst(obj4, "TPOS", false) != 0) && (ObjectType.ObjTst(obj4, "TORY", false) != 0)))) && ((((ObjectType.ObjTst(obj4, "TCOP", false) != 0) && (ObjectType.ObjTst(obj4, "TOLY", false) != 0)) && ((ObjectType.ObjTst(obj4, "TOWN", false) != 0) && (ObjectType.ObjTst(obj4, "TDOR", false) != 0))) && (((ObjectType.ObjTst(obj4, "WCOM", false) != 0) && (ObjectType.ObjTst(obj4, "WCOP", false) != 0)) && ((ObjectType.ObjTst(obj4, "WOAF", false) != 0) && (ObjectType.ObjTst(obj4, "WOAR", false) != 0)))))) && ((((((ObjectType.ObjTst(obj4, "WOAS", false) != 0) && (ObjectType.ObjTst(obj4, "WORS", false) != 0)) && ((ObjectType.ObjTst(obj4, "WPAY", false) != 0) && (ObjectType.ObjTst(obj4, "WPUB", false) != 0))) && (((ObjectType.ObjTst(obj4, "TSOA", false) != 0) && (ObjectType.ObjTst(obj4, "TSOP", false) != 0)) && ((ObjectType.ObjTst(obj4, "TSOT", false) != 0) && (ObjectType.ObjTst(obj4, "TIPL", false) != 0)))) && ((((ObjectType.ObjTst(obj4, "TMCL", false) != 0) && (ObjectType.ObjTst(obj4, "IPLS", false) != 0)) && ((ObjectType.ObjTst(obj4, "TLEN", false) != 0) && (ObjectType.ObjTst(obj4, "COMM", false) != 0))) && (((ObjectType.ObjTst(obj4, "USLT", false) != 0) && (ObjectType.ObjTst(obj4, "POPM", false) != 0)) && ((ObjectType.ObjTst(obj4, "TXXX", false) != 0) && (ObjectType.ObjTst(obj4, "WXXX", false) != 0))))) && (ObjectType.ObjTst(obj4, "APIC", false) != 0)))
        {
          ListViewItem item10 = new ListViewItem
          {
            Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "FID", new object[0], null, null))
          };
          LateBinding.LateCall(item10.SubItems, null, "Add", new object[] { RuntimeHelpers.GetObjectValue(Interaction.IIf(BooleanType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "FID", new object[0], null, null), null, "StartsWith", new object[] { "T" }, null, null)), RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)), "")) }, null, null);
          item10.Checked = true;
          item10.Tag = RuntimeHelpers.GetObjectValue(objectValue);
          this.NotSupportList.Items.Add(item10);
        }
      }

      foreach (var frameItem in this.MP3.V2TAG.GetAllNotSupportedFrames())
      {
        objectValue = RuntimeHelpers.GetObjectValue(frameItem);
        ListViewItem item11 = new ListViewItem
        {
          Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "FID", new object[0], null, null)),
          SubItems = { "" },
          Checked = true,
          Tag = RuntimeHelpers.GetObjectValue(objectValue)
        };
        this.NotSupportList.Items.Add(item11);
      }
      this.cmbArtist.Autocomplete = true;
      this.cmbGenre.Autocomplete = true;
    }

    private void frmTAG2_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
      this.panDetail.Enabled = false;
      this.panOriginal.Enabled = false;
      this.panWeb.Enabled = false;
      this.panRating.Enabled = false;
      this.panPic.Enabled = false;
      this.panLyrics.Enabled = false;
      this.panNot.Enabled = false;
      this.panInvolved.Enabled = false;
      this.panUser.Enabled = false;
      this.panMain.Dock = DockStyle.Fill;
      this.TopPanel.Text = StringType.FromObject(Declarations.objResources.SelectionBar["TAGV2ButtonItem1"]);
      if (this.MainForm.MP3View.FocusedItem == null)
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.SelectedItems[0].Index].Focused = true;
      }
      this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
      this.FocusControl = this.cmbArtist;
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
      int num2 = Declarations.objSettings.FT2Formats.Rows.Count - 1;
      for (int i = 0; i <= num2; i++)
      {
        this.cmbFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.FT2Formats.Rows[i]["Format"]));
      }
      this.cmbFormat.Text = Declarations.objSettings.FT2Format;
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
      }
      this.cmbFormat.Stretch = true;
      this.TAGV2grpTransfer.SubItems.Add(this.cmbFormat);
      Directory.SetCurrentDirectory(Path.GetDirectoryName(this.MP3.FI.FullName));
      this.FillForm();
      this.txtBPM.ModifyFlags(0x10, true);
      this.txtTLEN.ModifyFlags(0x10, true);
      this.txtTrack1.ModifyFlags(0x10, true);
      this.txtTrack2.ModifyFlags(0x10, true);
      this.txtPOS1.ModifyFlags(0x10, true);
      this.txtPOS2.ModifyFlags(0x10, true);
      this.AddSelectionBar();
      this.AddToolTips();
      this.AddColumnText();
      this.TAGV2grpTAG.Expanded = true;
      this.TAGV2grpCommands.Expanded = true;
      this.cmbArtist.Select();
      this.cmbArtist.Focus();
    }

    public void GetInfo(ID3_TagIT.MP3 MP3, ArrayList alstFormat)
    {
      int num5;
      ArrayList list2 = new ArrayList();
      ArrayList list = new ArrayList();
      string[] strArray2 = MP3.CurrentFullName.Remove(MP3.CurrentFullName.LastIndexOf("."), MP3.FI.Extension.Length).Split(new char[] { '\\' });
      if (alstFormat.Count >= strArray2.Length)
      {
        num5 = strArray2.Length - 1;
      }
      else
      {
        num5 = alstFormat.Count - 1;
      }
      int num7 = num5;
      for (int i = 0; i <= num7; i++)
      {
        list2.Clear();
        string[] strArray = (string[])LateBinding.LateGet(alstFormat[i], null, "Delimiters", new object[0], null, null);
        list = (ArrayList)LateBinding.LateGet(alstFormat[i], null, "Parameters", new object[0], null, null);
        string str2 = strArray2[strArray2.GetUpperBound(0) - i];
        int upperBound = strArray.GetUpperBound(0);
        for (int j = 0; j <= upperBound; j++)
        {
          if ((j == strArray.GetUpperBound(0)) | (StringType.StrCmp(strArray[j], "", false) != 0))
          {
            if (str2.IndexOf(strArray[j]) < 0)
            {
              list2.Add(str2);
              break;
            }
            list2.Add(RuntimeHelpers.GetObjectValue(Interaction.IIf(StringType.StrCmp(strArray[j], "", false) == 0, str2, str2.Substring(0, str2.IndexOf(strArray[j])))));
            str2 = str2.Substring(str2.IndexOf(strArray[j]) + strArray[j].Length);
          }
        }
        int num3 = -1;
        int num4 = 1;
        using (IEnumerator enumerator = list.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            string str = StringType.FromObject(enumerator.Current);
            num3++;
            if ((num3 != list2.Count) && (ObjectType.ObjTst(list2[num3], "", false) != 0))
            {
              string sLeft = str;
              if ((StringType.StrCmp(sLeft, "<A>", false) == 0) || (StringType.StrCmp(sLeft, "<a>", false) == 0))
              {
                this.cmbArtist.Text = StringType.FromObject(list2[num3]);
              }
              else
              {
                if ((StringType.StrCmp(sLeft, "<T>", false) == 0) || (StringType.StrCmp(sLeft, "<t>", false) == 0))
                {
                  this.txtTitle.Text = StringType.FromObject(list2[num3]);
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<B>", false) == 0) || (StringType.StrCmp(sLeft, "<b>", false) == 0))
                {
                  this.txtAlbum.Text = StringType.FromObject(list2[num3]);
                  continue;
                }
                if (((StringType.StrCmp(sLeft, "<K>", false) == 0) || (StringType.StrCmp(sLeft, "<k>", false) == 0)) || ((StringType.StrCmp(sLeft, "<P>", false) == 0) || (StringType.StrCmp(sLeft, "<p>", false) == 0)))
                {
                  if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(list2[num3])))
                  {
                    string str3 = str;
                    if (StringType.StrCmp(str3, "<k>", false) == 0)
                    {
                      this.txtTrack2.Text = StringType.FromObject(list2[num3]);
                    }
                    else if (StringType.StrCmp(str3, "<K>", false) == 0)
                    {
                      this.txtTrack1.Text = StringType.FromObject(list2[num3]);
                    }
                    else if (StringType.StrCmp(str3, "<p>", false) == 0)
                    {
                      this.txtPOS2.Text = StringType.FromObject(list2[num3]);
                    }
                    else if (StringType.StrCmp(str3, "<P>", false) == 0)
                    {
                      this.txtPOS1.Text = StringType.FromObject(list2[num3]);
                    }
                  }
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<Y>", false) == 0) || (StringType.StrCmp(sLeft, "<y>", false) == 0))
                {
                  if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(list2[num3])))
                  {
                    this.txtYear.Text = list2[num3].ToString().Trim(new char[] { ' ' }).PadLeft(4, '0') + "-01-01";
                  }
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<G>", false) == 0) || (StringType.StrCmp(sLeft, "<g>", false) == 0))
                {
                  this.GenreList.Items.Add(RuntimeHelpers.GetObjectValue(list2[num3]));
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<C>", false) == 0) || (StringType.StrCmp(sLeft, "<c>", false) == 0))
                {
                  object o = new V2LDCFrame();
                  LateBinding.LateSet(o, null, "FID", new object[] { "COMM" }, null);
                  LateBinding.LateSet(o, null, "Descriptor", new object[] { "ID3-TagIT FT " + num4.ToString().Trim(new char[] { ' ' }) }, null);
                  num4++;
                  LateBinding.LateSet(o, null, "Language", new object[] { Declarations.astrLanLookup[Declarations.objSettings.V2Language].Substring(0, 3) }, null);
                  LateBinding.LateSet(o, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(list2[num3]) }, null);
                  ListViewItem item = new ListViewItem
                  {
                    Text = StringType.FromObject(LateBinding.LateGet(o, null, "Descriptor", new object[0], null, null))
                  };
                  object[] objArray3 = new object[1];
                  object obj4 = o;
                  objArray3[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj4, null, "Content", new object[0], null, null));
                  object[] args = objArray3;
                  bool[] copyBack = new bool[] { true };
                  LateBinding.LateCall(item.SubItems, null, "Add", args, null, copyBack);
                  if (copyBack[0])
                  {
                    LateBinding.LateSetComplex(obj4, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(args[0]) }, null, true, false);
                  }
                  object[] objArray = new object[1];
                  obj4 = o;
                  objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj4, null, "Language", new object[0], null, null));
                  args = objArray;
                  copyBack = new bool[] { true };
                  LateBinding.LateCall(item.SubItems, null, "Add", args, null, copyBack);
                  if (copyBack[0])
                  {
                    LateBinding.LateSetComplex(obj4, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(args[0]) }, null, true, false);
                  }
                  item.Tag = RuntimeHelpers.GetObjectValue(o);
                  this.CommentList.Items.Add(item);
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<O>", false) == 0) || (StringType.StrCmp(sLeft, "<o>", false) == 0))
                {
                  this.txtBand.Text = StringType.FromObject(list2[num3]);
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<N>", false) == 0) || (StringType.StrCmp(sLeft, "<n>", false) == 0))
                {
                  this.txtConductor.Text = StringType.FromObject(list2[num3]);
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<M>", false) == 0) || (StringType.StrCmp(sLeft, "<m>", false) == 0))
                {
                  this.txtModified.Text = StringType.FromObject(list2[num3]);
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<U>", false) == 0) || (StringType.StrCmp(sLeft, "<u>", false) == 0))
                {
                  this.txtContent.Text = StringType.FromObject(list2[num3]);
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<S>", false) == 0) || (StringType.StrCmp(sLeft, "<s>", false) == 0))
                {
                  this.txtSubTitle.Text = StringType.FromObject(list2[num3]);
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<R>", false) == 0) || (StringType.StrCmp(sLeft, "<r>", false) == 0))
                {
                  this.txtComposer.Text = StringType.FromObject(list2[num3]);
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<E>", false) == 0) || (StringType.StrCmp(sLeft, "<e>", false) == 0))
                {
                  if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(list2[num3])))
                  {
                    this.txtBPM.Text = StringType.FromObject(list2[num3]);
                  }
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<X>", false) != 0) && (StringType.StrCmp(sLeft, "<x>", false) == 0))
                {
                }
              }
            }
          }
        }
      }
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      ResourceManager manager = new ResourceManager(typeof(frmTAG2));
      this.lblSelected = new Label();
      this.txtSelected = new System.Windows.Forms.TextBox();
      this.Panel3 = new Panel();
      this.lblCommDescInfo = new Label();
      this.cmbCDescriptor = new ComboBoxAutoComplete();
      this.btnV1Comment = new Button();
      this.btnMoveComment = new Button();
      this.btnRemoveComment = new Button();
      this.btnAddComment = new Button();
      this.lblCOMM = new Label();
      this.lblCOMMLan = new Label();
      this.lblCOMMDesc = new Label();
      this.cmbCLanguage = new ComboBox();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.CommentList = new ListView();
      this.colDescriptor = new ColumnHeader();
      this.colComment = new ColumnHeader();
      this.colLanguage = new ColumnHeader();
      this.Panel2 = new Panel();
      this.cmbGenre = new ComboBoxAutoComplete();
      this.btnV1Genre = new Button();
      this.lblGenreInfo = new Label();
      this.btnMoveGenre = new Button();
      this.btnRemoveGenre = new Button();
      this.btnAddGenre = new Button();
      this.lblGenre = new Label();
      this.GenreList = new ListBox();
      this.Panel1 = new Panel();
      this.txtPOS2 = new IntegerTextBox();
      this.txtPOS1 = new IntegerTextBox();
      this.txtTrack2 = new IntegerTextBox();
      this.txtTrack1 = new IntegerTextBox();
      this.txtYear = new AMS.TextBox.MaskedTextBox();
      this.txtBPM = new NumericTextBox();
      this.cmbArtist = new ComboBoxAutoComplete();
      this.lblBPM = new Label();
      this.YearFormat = new HScrollBar();
      this.btnV1Title = new Button();
      this.btnV1Album = new Button();
      this.btnV1Track = new Button();
      this.btnV1Year = new Button();
      this.btnV1Artist = new Button();
      this.lblOf2 = new Label();
      this.lblOf1 = new Label();
      this.txtAlbum = new System.Windows.Forms.TextBox();
      this.txtTitle = new System.Windows.Forms.TextBox();
      this.lblTitle = new Label();
      this.lblAlbum = new Label();
      this.lblPosMedia = new Label();
      this.lblYear = new Label();
      this.lblTrack = new Label();
      this.lblArtist = new Label();
      this.btnTLEN = new Button();
      this.txtTLEN = new IntegerTextBox();
      this.lblTLEN = new Label();
      this.cmbMedia = new ComboBox();
      this.lblMediaTyp = new Label();
      this.Panel9 = new Panel();
      this.txtSortArtist = new System.Windows.Forms.TextBox();
      this.txtSortTitle = new System.Windows.Forms.TextBox();
      this.txtSortAlbum = new System.Windows.Forms.TextBox();
      this.lblAlbumSort = new Label();
      this.lblTitleSort = new Label();
      this.lblArtistSort = new Label();
      this.Panel6 = new Panel();
      this.txtTORY = new AMS.TextBox.MaskedTextBox();
      this.lblOYearInfo = new Label();
      this.TORYFormat = new HScrollBar();
      this.lblOYear = new Label();
      this.txtOOwner = new System.Windows.Forms.TextBox();
      this.lblOOwner = new Label();
      this.txtOArtist = new System.Windows.Forms.TextBox();
      this.lblOArtist = new Label();
      this.txtOAlbum = new System.Windows.Forms.TextBox();
      this.txtOLyWriter = new System.Windows.Forms.TextBox();
      this.txtOFilename = new System.Windows.Forms.TextBox();
      this.lblOFilename = new Label();
      this.lblOLyWriter = new Label();
      this.lblOAlbum = new Label();
      this.Panel5 = new Panel();
      this.txtContent = new System.Windows.Forms.TextBox();
      this.txtSubTitle = new System.Windows.Forms.TextBox();
      this.lblSubTitle = new Label();
      this.lblContent = new Label();
      this.Panel4 = new Panel();
      this.txtComposer = new System.Windows.Forms.TextBox();
      this.lblComposer = new Label();
      this.txtBand = new System.Windows.Forms.TextBox();
      this.txtModified = new System.Windows.Forms.TextBox();
      this.txtConductor = new System.Windows.Forms.TextBox();
      this.lblConductor = new Label();
      this.lblModified = new Label();
      this.lblBand = new Label();
      this.txtCopyright = new System.Windows.Forms.TextBox();
      this.lblCopyright = new Label();
      this.txtLyWriter = new System.Windows.Forms.TextBox();
      this.txtEncoded = new System.Windows.Forms.TextBox();
      this.txtPublisher = new System.Windows.Forms.TextBox();
      this.lblPublisher = new Label();
      this.lblEncoded = new Label();
      this.lblLyWriter = new Label();
      this.Panel15 = new Panel();
      this.lblMusicianInfo = new Label();
      this.txtMusicianName = new System.Windows.Forms.TextBox();
      this.btnRemoveMusician = new Button();
      this.btnAddMusician = new Button();
      this.lblMusicianName = new Label();
      this.lblMusicianInst = new Label();
      this.txtMusicianInst = new System.Windows.Forms.TextBox();
      this.TMCLList = new ListView();
      this.ColumnHeader15 = new ColumnHeader();
      this.ColumnHeader16 = new ColumnHeader();
      this.Panel16 = new Panel();
      this.txtInvPerson = new System.Windows.Forms.TextBox();
      this.btnRemoveInv = new Button();
      this.btnAddInv = new Button();
      this.lblInvPerson = new Label();
      this.lblInvFunction = new Label();
      this.txtInvFunction = new System.Windows.Forms.TextBox();
      this.TIPLList = new ListView();
      this.ColumnHeader17 = new ColumnHeader();
      this.ColumnHeader18 = new ColumnHeader();
      this.Panel14 = new Panel();
      this.Panel7 = new Panel();
      this.chkPicRelativPath = new CheckBox();
      this.btnExPic = new Button();
      this.btnRemovePicture = new Button();
      this.btnAddPicture = new Button();
      this.btnGetPic = new Button();
      this.chkPicInclude = new CheckBox();
      this.lblPicPath = new Label();
      this.txtPicPath = new System.Windows.Forms.TextBox();
      this.PicList = new ListView();
      this.ColumnHeader4 = new ColumnHeader();
      this.ColumnHeader5 = new ColumnHeader();
      this.ColumnHeader6 = new ColumnHeader();
      this.ColumnHeader7 = new ColumnHeader();
      this.lblPicType = new Label();
      this.lblPicDesc = new Label();
      this.cmbPicType = new ComboBox();
      this.txtPDescriptor = new System.Windows.Forms.TextBox();
      this.APICView = new PictureBox();
      this.Panel8 = new Panel();
      this.txtLyrics = new RichTextBox();
      this.btnLyricsFile = new Button();
      this.btnMoveLyrics = new Button();
      this.btnRemoveLyrics = new Button();
      this.btnAddLyrics = new Button();
      this.lblLyrics = new Label();
      this.lblLyLan = new Label();
      this.lblLyDesc = new Label();
      this.cmbLLanguage = new ComboBox();
      this.txtLDescriptor = new System.Windows.Forms.TextBox();
      this.LyricsList = new ListView();
      this.ColumnHeader1 = new ColumnHeader();
      this.ColumnHeader2 = new ColumnHeader();
      this.ColumnHeader3 = new ColumnHeader();
      this.Panel11 = new Panel();
      this.lblInfo = new Label();
      this.btnMoveRating = new Button();
      this.btnRemoveRating = new Button();
      this.btnAddRating = new Button();
      this.RatingList = new ListView();
      this.ColumnHeader8 = new ColumnHeader();
      this.ColumnHeader9 = new ColumnHeader();
      this.ColumnHeader10 = new ColumnHeader();
      this.txtRatingCounter = new NumericUpDown();
      this.txtRatingRating = new NumericUpDown();
      this.txtRatingUser = new System.Windows.Forms.TextBox();
      this.lblRatingRating = new Label();
      this.lblRatingCounter = new Label();
      this.lblRatingUser = new Label();
      this.Panel10 = new Panel();
      this.txtCOMMInfURL = new System.Windows.Forms.TextBox();
      this.lblCOMMInfURL = new Label();
      this.txtPubURL = new System.Windows.Forms.TextBox();
      this.lblPubURL = new Label();
      this.txtPayURL = new System.Windows.Forms.TextBox();
      this.lblPayURL = new Label();
      this.txtINetRadioURL = new System.Windows.Forms.TextBox();
      this.lblINetRadioURL = new Label();
      this.txtAudioSRCURL = new System.Windows.Forms.TextBox();
      this.lblAudioSRCURL = new Label();
      this.txtCopyInfURL = new System.Windows.Forms.TextBox();
      this.txtArtistURL = new System.Windows.Forms.TextBox();
      this.txtAudioFileURL = new System.Windows.Forms.TextBox();
      this.lblAudioFileURL = new Label();
      this.lblArtistURL = new Label();
      this.lblCopyInfURL = new Label();
      this.Panel13 = new Panel();
      this.txtWXXXContent = new System.Windows.Forms.TextBox();
      this.btnRemoveWXXX = new Button();
      this.btnAddWXXX = new Button();
      this.lblWXXXContent = new Label();
      this.lblWXXXDesc = new Label();
      this.txtWXXXDesc = new System.Windows.Forms.TextBox();
      this.WXXXList = new ListView();
      this.ColumnHeader13 = new ColumnHeader();
      this.ColumnHeader14 = new ColumnHeader();
      this.Panel12 = new Panel();
      this.txtTXXXContent = new System.Windows.Forms.TextBox();
      this.btnRemoveTXXX = new Button();
      this.btnAddTXXX = new Button();
      this.lblTXXXContent = new Label();
      this.lblTXXXDesc = new Label();
      this.txtTXXXDesc = new System.Windows.Forms.TextBox();
      this.TXXXList = new ListView();
      this.ColumnHeader11 = new ColumnHeader();
      this.ColumnHeader12 = new ColumnHeader();
      this.lblNot = new Label();
      this.NotSupportList = new ListView();
      this.FrameID = new ColumnHeader();
      this.Content = new ColumnHeader();
      this.txtDigits = new NumericUpDown();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.SelectionBar = new ExplorerBar();
      this.TAGV2grpTAG = new ExplorerBarGroupItem();
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
      this.TAGV2grpTransfer = new ExplorerBarGroupItem();
      this.btnImport = new ButtonItem();
      this.btnExport = new ButtonItem();
      this.btnGet = new ButtonItem();
      this.TAGV2grpCommands = new ExplorerBarGroupItem();
      this.btnPrev = new ButtonItem();
      this.btnNext = new ButtonItem();
      this.btnSwapAT = new ButtonItem();
      this.btnSwapAA = new ButtonItem();
      this.btnSwapTA = new ButtonItem();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.lblDigits = new Label();
      this.TopPanel = new PanelEx();
      this.panDetail = new Panel();
      this.panMain = new Panel();
      this.panOriginal = new Panel();
      this.panInvolved = new Panel();
      this.panPic = new Panel();
      this.panLyrics = new Panel();
      this.panWeb = new Panel();
      this.panRating = new Panel();
      this.panUser = new Panel();
      this.panNot = new Panel();
      this.ButtomPanel = new PanelEx();
      this.Panel3.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.Panel1.SuspendLayout();
      this.Panel9.SuspendLayout();
      this.Panel6.SuspendLayout();
      this.Panel5.SuspendLayout();
      this.Panel4.SuspendLayout();
      this.Panel15.SuspendLayout();
      this.Panel16.SuspendLayout();
      this.Panel14.SuspendLayout();
      this.Panel7.SuspendLayout();
      this.Panel8.SuspendLayout();
      this.Panel11.SuspendLayout();
      this.txtRatingCounter.BeginInit();
      this.txtRatingRating.BeginInit();
      this.Panel10.SuspendLayout();
      this.Panel13.SuspendLayout();
      this.Panel12.SuspendLayout();
      this.txtDigits.BeginInit();
      ((ISupportInitialize)this.SelectionBar).BeginInit();
      this.TopPanel.SuspendLayout();
      this.panDetail.SuspendLayout();
      this.panMain.SuspendLayout();
      this.panOriginal.SuspendLayout();
      this.panInvolved.SuspendLayout();
      this.panPic.SuspendLayout();
      this.panLyrics.SuspendLayout();
      this.panWeb.SuspendLayout();
      this.panRating.SuspendLayout();
      this.panUser.SuspendLayout();
      this.panNot.SuspendLayout();
      this.ButtomPanel.SuspendLayout();
      this.SuspendLayout();
      this.lblSelected.BackColor = Color.White;
      this.lblSelected.ForeColor = Color.Black;
      this.lblSelected.ImeMode = ImeMode.NoControl;
      Point point = new Point(8, 0x18);
      this.lblSelected.Location = point;
      this.lblSelected.Name = "lblSelected";
      Size size = new Size(0x68, 0x10);
      this.lblSelected.Size = size;
      this.lblSelected.TabIndex = 0x6b;
      this.lblSelected.Text = "Selected file:";
      this.txtSelected.BackColor = Color.White;
      this.txtSelected.BorderStyle = BorderStyle.None;
      this.txtSelected.ForeColor = Color.Black;
      point = new Point(0x70, 0x18);
      this.txtSelected.Location = point;
      this.txtSelected.Name = "txtSelected";
      this.txtSelected.ReadOnly = true;
      size = new Size(0x220, 13);
      this.txtSelected.Size = size;
      this.txtSelected.TabIndex = 0x6c;
      this.txtSelected.TabStop = false;
      this.txtSelected.Text = "";
      this.Panel3.BorderStyle = BorderStyle.FixedSingle;
      this.Panel3.Controls.Add(this.lblCommDescInfo);
      this.Panel3.Controls.Add(this.cmbCDescriptor);
      this.Panel3.Controls.Add(this.btnV1Comment);
      this.Panel3.Controls.Add(this.btnMoveComment);
      this.Panel3.Controls.Add(this.btnRemoveComment);
      this.Panel3.Controls.Add(this.btnAddComment);
      this.Panel3.Controls.Add(this.lblCOMM);
      this.Panel3.Controls.Add(this.lblCOMMLan);
      this.Panel3.Controls.Add(this.lblCOMMDesc);
      this.Panel3.Controls.Add(this.cmbCLanguage);
      this.Panel3.Controls.Add(this.txtComment);
      this.Panel3.Controls.Add(this.CommentList);
      point = new Point(8, 0x108);
      this.Panel3.Location = point;
      this.Panel3.Name = "Panel3";
      size = new Size(0x288, 0xb8);
      this.Panel3.Size = size;
      this.Panel3.TabIndex = 2;
      this.lblCommDescInfo.BorderStyle = BorderStyle.Fixed3D;
      this.lblCommDescInfo.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x70);
      this.lblCommDescInfo.Location = point;
      this.lblCommDescInfo.Name = "lblCommDescInfo";
      size = new Size(120, 0x40);
      this.lblCommDescInfo.Size = size;
      this.lblCommDescInfo.TabIndex = 0x2f;
      this.lblCommDescInfo.Text = "Predefined comment descriptors can be set under Edit Libraries (Options menu)";
      this.lblCommDescInfo.TextAlign = ContentAlignment.MiddleCenter;
      this.cmbCDescriptor.Autocomplete = true;
      this.cmbCDescriptor.ItemHeight = 13;
      point = new Point(0x88, 6);
      this.cmbCDescriptor.Location = point;
      this.cmbCDescriptor.Name = "cmbCDescriptor";
      size = new Size(0x108, 0x15);
      this.cmbCDescriptor.Size = size;
      this.cmbCDescriptor.TabIndex = 0x24;
      this.btnV1Comment.ImeMode = ImeMode.NoControl;
      point = new Point(0x198, 80);
      this.btnV1Comment.Location = point;
      this.btnV1Comment.Name = "btnV1Comment";
      size = new Size(0xe8, 20);
      this.btnV1Comment.Size = size;
      this.btnV1Comment.TabIndex = 0x2c;
      this.btnV1Comment.Text = "<- Ver. 1";
      this.btnMoveComment.ImeMode = ImeMode.NoControl;
      point = new Point(0x198, 0x38);
      this.btnMoveComment.Location = point;
      this.btnMoveComment.Name = "btnMoveComment";
      size = new Size(0xe8, 20);
      this.btnMoveComment.Size = size;
      this.btnMoveComment.TabIndex = 0x2b;
      this.btnMoveComment.Text = "Move Comment to top";
      this.btnRemoveComment.ImeMode = ImeMode.NoControl;
      point = new Point(0x198, 0x20);
      this.btnRemoveComment.Location = point;
      this.btnRemoveComment.Name = "btnRemoveComment";
      size = new Size(0xe8, 20);
      this.btnRemoveComment.Size = size;
      this.btnRemoveComment.TabIndex = 0x2a;
      this.btnRemoveComment.Text = "Remove Comment";
      this.btnAddComment.ImeMode = ImeMode.NoControl;
      point = new Point(0x198, 8);
      this.btnAddComment.Location = point;
      this.btnAddComment.Name = "btnAddComment";
      size = new Size(0xe8, 20);
      this.btnAddComment.Size = size;
      this.btnAddComment.TabIndex = 0x29;
      this.btnAddComment.Text = "Add Comment";
      this.lblCOMM.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblCOMM.Location = point;
      this.lblCOMM.Name = "lblCOMM";
      size = new Size(0x80, 0x10);
      this.lblCOMM.Size = size;
      this.lblCOMM.TabIndex = 0x27;
      this.lblCOMM.Text = "&Comment:";
      this.lblCOMMLan.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblCOMMLan.Location = point;
      this.lblCOMMLan.Name = "lblCOMMLan";
      size = new Size(0x80, 0x10);
      this.lblCOMMLan.Size = size;
      this.lblCOMMLan.TabIndex = 0x25;
      this.lblCOMMLan.Text = "Comment &Language:";
      this.lblCOMMDesc.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblCOMMDesc.Location = point;
      this.lblCOMMDesc.Name = "lblCOMMDesc";
      size = new Size(0x80, 0x10);
      this.lblCOMMDesc.Size = size;
      this.lblCOMMDesc.TabIndex = 0x23;
      this.lblCOMMDesc.Text = "Comment &Descriptor:";
      this.cmbCLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbCLanguage.ItemHeight = 13;
      point = new Point(0x88, 30);
      this.cmbCLanguage.Location = point;
      this.cmbCLanguage.Name = "cmbCLanguage";
      size = new Size(0x108, 0x15);
      this.cmbCLanguage.Size = size;
      this.cmbCLanguage.TabIndex = 0x26;
      this.txtComment.AcceptsReturn = true;
      point = new Point(0x88, 0x38);
      this.txtComment.Location = point;
      this.txtComment.Multiline = true;
      this.txtComment.Name = "txtComment";
      size = new Size(0x108, 0x30);
      this.txtComment.Size = size;
      this.txtComment.TabIndex = 40;
      this.txtComment.Text = "";
      this.CommentList.Columns.AddRange(new ColumnHeader[] { this.colDescriptor, this.colComment, this.colLanguage });
      this.CommentList.FullRowSelect = true;
      this.CommentList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(0x88, 0x70);
      this.CommentList.Location = point;
      this.CommentList.MultiSelect = false;
      this.CommentList.Name = "CommentList";
      size = new Size(0x1f8, 0x40);
      this.CommentList.Size = size;
      this.CommentList.TabIndex = 0x2d;
      this.CommentList.View = View.Details;
      this.colDescriptor.Text = "Descriptor";
      this.colDescriptor.Width = 0x7c;
      this.colComment.Text = "Comment";
      this.colComment.Width = 0x106;
      this.colLanguage.Text = "Language";
      this.colLanguage.Width = 0x5b;
      this.Panel2.BorderStyle = BorderStyle.FixedSingle;
      this.Panel2.Controls.Add(this.cmbGenre);
      this.Panel2.Controls.Add(this.btnV1Genre);
      this.Panel2.Controls.Add(this.lblGenreInfo);
      this.Panel2.Controls.Add(this.btnMoveGenre);
      this.Panel2.Controls.Add(this.btnRemoveGenre);
      this.Panel2.Controls.Add(this.btnAddGenre);
      this.Panel2.Controls.Add(this.lblGenre);
      this.Panel2.Controls.Add(this.GenreList);
      point = new Point(8, 0x90);
      this.Panel2.Location = point;
      this.Panel2.Name = "Panel2";
      size = new Size(0x288, 0x70);
      this.Panel2.Size = size;
      this.Panel2.TabIndex = 1;
      this.cmbGenre.Autocomplete = true;
      this.cmbGenre.ItemHeight = 13;
      point = new Point(0x88, 6);
      this.cmbGenre.Location = point;
      this.cmbGenre.Name = "cmbGenre";
      size = new Size(0xe8, 0x15);
      this.cmbGenre.Size = size;
      this.cmbGenre.TabIndex = 0x1d;
      this.btnV1Genre.ImeMode = ImeMode.NoControl;
      point = new Point(0x200, 0x20);
      this.btnV1Genre.Location = point;
      this.btnV1Genre.Name = "btnV1Genre";
      size = new Size(0x80, 20);
      this.btnV1Genre.Size = size;
      this.btnV1Genre.TabIndex = 0x21;
      this.btnV1Genre.Text = "<- Ver. 1";
      this.lblGenreInfo.BorderStyle = BorderStyle.Fixed3D;
      this.lblGenreInfo.ImeMode = ImeMode.NoControl;
      point = new Point(0x178, 0x40);
      this.lblGenreInfo.Location = point;
      this.lblGenreInfo.Name = "lblGenreInfo";
      size = new Size(0x108, 40);
      this.lblGenreInfo.Size = size;
      this.lblGenreInfo.TabIndex = 0x1d;
      this.lblGenreInfo.Text = "Note: Many programs only show the first genre entered. So move the important genre to the top of the list.";
      this.btnMoveGenre.ImeMode = ImeMode.NoControl;
      point = new Point(0x178, 0x20);
      this.btnMoveGenre.Location = point;
      this.btnMoveGenre.Name = "btnMoveGenre";
      size = new Size(0x80, 20);
      this.btnMoveGenre.Size = size;
      this.btnMoveGenre.TabIndex = 0x20;
      this.btnMoveGenre.Text = "Move Genre to top";
      this.btnRemoveGenre.ImeMode = ImeMode.NoControl;
      point = new Point(0x200, 8);
      this.btnRemoveGenre.Location = point;
      this.btnRemoveGenre.Name = "btnRemoveGenre";
      size = new Size(0x80, 20);
      this.btnRemoveGenre.Size = size;
      this.btnRemoveGenre.TabIndex = 0x1f;
      this.btnRemoveGenre.Text = "Remove Genre";
      this.btnAddGenre.ImeMode = ImeMode.NoControl;
      point = new Point(0x178, 8);
      this.btnAddGenre.Location = point;
      this.btnAddGenre.Name = "btnAddGenre";
      size = new Size(0x80, 20);
      this.btnAddGenre.Size = size;
      this.btnAddGenre.TabIndex = 30;
      this.btnAddGenre.Text = "Add Genre";
      this.lblGenre.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblGenre.Location = point;
      this.lblGenre.Name = "lblGenre";
      size = new Size(0x80, 0x10);
      this.lblGenre.Size = size;
      this.lblGenre.TabIndex = 0x1c;
      this.lblGenre.Text = "&Genre:";
      point = new Point(0x88, 0x20);
      this.GenreList.Location = point;
      this.GenreList.Name = "GenreList";
      size = new Size(0xe8, 0x45);
      this.GenreList.Size = size;
      this.GenreList.TabIndex = 0x22;
      this.Panel1.BorderStyle = BorderStyle.FixedSingle;
      this.Panel1.Controls.Add(this.txtPOS2);
      this.Panel1.Controls.Add(this.txtPOS1);
      this.Panel1.Controls.Add(this.txtTrack2);
      this.Panel1.Controls.Add(this.txtTrack1);
      this.Panel1.Controls.Add(this.txtYear);
      this.Panel1.Controls.Add(this.txtBPM);
      this.Panel1.Controls.Add(this.cmbArtist);
      this.Panel1.Controls.Add(this.lblBPM);
      this.Panel1.Controls.Add(this.YearFormat);
      this.Panel1.Controls.Add(this.btnV1Title);
      this.Panel1.Controls.Add(this.btnV1Album);
      this.Panel1.Controls.Add(this.btnV1Track);
      this.Panel1.Controls.Add(this.btnV1Year);
      this.Panel1.Controls.Add(this.btnV1Artist);
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
      point = new Point(8, 8);
      this.Panel1.Location = point;
      this.Panel1.Name = "Panel1";
      size = new Size(0x288, 0x80);
      this.Panel1.Size = size;
      this.Panel1.TabIndex = 0;
      this.txtPOS2.AllowNegative = false;
      this.txtPOS2.DigitsInGroup = 0;
      this.txtPOS2.Flags = 0x10000;
      point = new Point(0x240, 0x66);
      this.txtPOS2.Location = point;
      this.txtPOS2.MaxDecimalPlaces = 0;
      this.txtPOS2.MaxLength = 6;
      this.txtPOS2.MaxWholeDigits = 6;
      this.txtPOS2.Name = "txtPOS2";
      this.txtPOS2.Prefix = "";
      this.txtPOS2.RangeMax = 999999.0;
      this.txtPOS2.RangeMin = 0.0;
      size = new Size(0x40, 20);
      this.txtPOS2.Size = size;
      this.txtPOS2.TabIndex = 0x19;
      this.txtPOS1.AllowNegative = false;
      this.txtPOS1.DigitsInGroup = 0;
      this.txtPOS1.Flags = 0x10000;
      point = new Point(0x1e8, 0x66);
      this.txtPOS1.Location = point;
      this.txtPOS1.MaxDecimalPlaces = 0;
      this.txtPOS1.MaxLength = 6;
      this.txtPOS1.MaxWholeDigits = 6;
      this.txtPOS1.Name = "txtPOS1";
      this.txtPOS1.Prefix = "";
      this.txtPOS1.RangeMax = 999999.0;
      this.txtPOS1.RangeMin = 0.0;
      size = new Size(0x40, 20);
      this.txtPOS1.Size = size;
      this.txtPOS1.TabIndex = 0x18;
      this.txtTrack2.AllowNegative = false;
      this.txtTrack2.DigitsInGroup = 0;
      this.txtTrack2.Flags = 0x10000;
      point = new Point(0xe0, 0x66);
      this.txtTrack2.Location = point;
      this.txtTrack2.MaxDecimalPlaces = 0;
      this.txtTrack2.MaxLength = 6;
      this.txtTrack2.MaxWholeDigits = 6;
      this.txtTrack2.Name = "txtTrack2";
      this.txtTrack2.Prefix = "";
      this.txtTrack2.RangeMax = 999999.0;
      this.txtTrack2.RangeMin = 0.0;
      size = new Size(0x40, 20);
      this.txtTrack2.Size = size;
      this.txtTrack2.TabIndex = 0x15;
      this.txtTrack1.AllowNegative = false;
      this.txtTrack1.DigitsInGroup = 0;
      this.txtTrack1.Flags = 0x10000;
      point = new Point(0x88, 0x66);
      this.txtTrack1.Location = point;
      this.txtTrack1.MaxDecimalPlaces = 0;
      this.txtTrack1.MaxLength = 6;
      this.txtTrack1.MaxWholeDigits = 6;
      this.txtTrack1.Name = "txtTrack1";
      this.txtTrack1.Prefix = "";
      this.txtTrack1.RangeMax = 999999.0;
      this.txtTrack1.RangeMin = 0.0;
      size = new Size(0x40, 20);
      this.txtTrack1.Size = size;
      this.txtTrack1.TabIndex = 20;
      this.txtYear.Flags = 0;
      point = new Point(0x88, 0x4e);
      this.txtYear.Location = point;
      this.txtYear.Mask = "####-##-##";
      this.txtYear.Name = "txtYear";
      size = new Size(0x70, 20);
      this.txtYear.Size = size;
      this.txtYear.TabIndex = 13;
      this.txtBPM.AllowNegative = false;
      this.txtBPM.DigitsInGroup = 0;
      this.txtBPM.Flags = 0x10000;
      point = new Point(0x1e8, 0x4e);
      this.txtBPM.Location = point;
      this.txtBPM.MaxDecimalPlaces = 0;
      this.txtBPM.MaxLength = 3;
      this.txtBPM.MaxWholeDigits = 3;
      this.txtBPM.Name = "txtBPM";
      this.txtBPM.Prefix = "";
      this.txtBPM.RangeMax = 999999.0;
      this.txtBPM.RangeMin = 1.0;
      size = new Size(0x98, 20);
      this.txtBPM.Size = size;
      this.txtBPM.TabIndex = 0x12;
      this.cmbArtist.Autocomplete = true;
      this.cmbArtist.ItemHeight = 13;
      point = new Point(0x88, 6);
      this.cmbArtist.Location = point;
      this.cmbArtist.Name = "cmbArtist";
      size = new Size(440, 0x15);
      this.cmbArtist.Size = size;
      this.cmbArtist.TabIndex = 4;
      this.lblBPM.ImeMode = ImeMode.NoControl;
      point = new Point(0x170, 80);
      this.lblBPM.Location = point;
      this.lblBPM.Name = "lblBPM";
      size = new Size(0x80, 0x10);
      this.lblBPM.Size = size;
      this.lblBPM.TabIndex = 0x75;
      this.lblBPM.Text = "BP&M:";
      this.YearFormat.ImeMode = ImeMode.NoControl;
      this.YearFormat.LargeChange = 1;
      point = new Point(0x100, 80);
      this.YearFormat.Location = point;
      this.YearFormat.Maximum = 2;
      this.YearFormat.Name = "YearFormat";
      size = new Size(0x20, 0x10);
      this.YearFormat.Size = size;
      this.YearFormat.TabIndex = 14;
      this.btnV1Title.ImeMode = ImeMode.NoControl;
      point = new Point(0x248, 30);
      this.btnV1Title.Location = point;
      this.btnV1Title.Name = "btnV1Title";
      size = new Size(0x38, 20);
      this.btnV1Title.Size = size;
      this.btnV1Title.TabIndex = 8;
      this.btnV1Title.Text = "<- Ver. 1";
      this.btnV1Album.ImeMode = ImeMode.NoControl;
      point = new Point(0x248, 0x36);
      this.btnV1Album.Location = point;
      this.btnV1Album.Name = "btnV1Album";
      size = new Size(0x38, 20);
      this.btnV1Album.Size = size;
      this.btnV1Album.TabIndex = 11;
      this.btnV1Album.Text = "<- Ver. 1";
      this.btnV1Track.ImeMode = ImeMode.NoControl;
      point = new Point(0x128, 0x66);
      this.btnV1Track.Location = point;
      this.btnV1Track.Name = "btnV1Track";
      size = new Size(0x38, 20);
      this.btnV1Track.Size = size;
      this.btnV1Track.TabIndex = 0x16;
      this.btnV1Track.Text = "<- Ver. 1";
      this.btnV1Year.ImeMode = ImeMode.NoControl;
      point = new Point(0x128, 0x4e);
      this.btnV1Year.Location = point;
      this.btnV1Year.Name = "btnV1Year";
      size = new Size(0x38, 20);
      this.btnV1Year.Size = size;
      this.btnV1Year.TabIndex = 0x10;
      this.btnV1Year.Text = "<- Ver. 1";
      this.btnV1Artist.ImeMode = ImeMode.NoControl;
      point = new Point(0x248, 6);
      this.btnV1Artist.Location = point;
      this.btnV1Artist.Name = "btnV1Artist";
      size = new Size(0x38, 20);
      this.btnV1Artist.Size = size;
      this.btnV1Artist.TabIndex = 5;
      this.btnV1Artist.Text = "<- Ver. 1";
      this.lblOf2.ImeMode = ImeMode.NoControl;
      point = new Point(560, 0x68);
      this.lblOf2.Location = point;
      this.lblOf2.Name = "lblOf2";
      size = new Size(0x10, 0x10);
      this.lblOf2.Size = size;
      this.lblOf2.TabIndex = 0x15;
      this.lblOf2.Text = "/";
      this.lblOf1.ImeMode = ImeMode.NoControl;
      point = new Point(0xd0, 0x68);
      this.lblOf1.Location = point;
      this.lblOf1.Name = "lblOf1";
      size = new Size(0x10, 0x10);
      this.lblOf1.Size = size;
      this.lblOf1.TabIndex = 0x10;
      this.lblOf1.Text = "/";
      point = new Point(0x88, 0x36);
      this.txtAlbum.Location = point;
      this.txtAlbum.Name = "txtAlbum";
      size = new Size(440, 20);
      this.txtAlbum.Size = size;
      this.txtAlbum.TabIndex = 10;
      this.txtAlbum.Text = "";
      point = new Point(0x88, 30);
      this.txtTitle.Location = point;
      this.txtTitle.Name = "txtTitle";
      size = new Size(440, 20);
      this.txtTitle.Size = size;
      this.txtTitle.TabIndex = 7;
      this.txtTitle.Text = "";
      this.lblTitle.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblTitle.Location = point;
      this.lblTitle.Name = "lblTitle";
      size = new Size(0x80, 0x10);
      this.lblTitle.Size = size;
      this.lblTitle.TabIndex = 6;
      this.lblTitle.Text = "&Title:";
      this.lblAlbum.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblAlbum.Location = point;
      this.lblAlbum.Name = "lblAlbum";
      size = new Size(0x80, 0x10);
      this.lblAlbum.Size = size;
      this.lblAlbum.TabIndex = 9;
      this.lblAlbum.Text = "Al&bum:";
      this.lblPosMedia.ImeMode = ImeMode.NoControl;
      point = new Point(0x170, 0x68);
      this.lblPosMedia.Location = point;
      this.lblPosMedia.Name = "lblPosMedia";
      size = new Size(120, 0x10);
      this.lblPosMedia.Size = size;
      this.lblPosMedia.TabIndex = 0x17;
      this.lblPosMedia.Text = "Position in media &set:";
      this.lblYear.ImeMode = ImeMode.NoControl;
      point = new Point(8, 80);
      this.lblYear.Location = point;
      this.lblYear.Name = "lblYear";
      size = new Size(0x80, 0x10);
      this.lblYear.Size = size;
      this.lblYear.TabIndex = 12;
      this.lblYear.Text = "&Year (date) of recording:";
      this.lblTrack.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x68);
      this.lblTrack.Location = point;
      this.lblTrack.Name = "lblTrack";
      size = new Size(0x80, 0x10);
      this.lblTrack.Size = size;
      this.lblTrack.TabIndex = 0x13;
      this.lblTrack.Text = "Trac&k number:";
      this.lblArtist.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblArtist.Location = point;
      this.lblArtist.Name = "lblArtist";
      size = new Size(0x80, 0x10);
      this.lblArtist.Size = size;
      this.lblArtist.TabIndex = 3;
      this.lblArtist.Text = "Lead &Artist:";
      this.btnTLEN.ImeMode = ImeMode.NoControl;
      point = new Point(0x138, 0x20);
      this.btnTLEN.Location = point;
      this.btnTLEN.Name = "btnTLEN";
      size = new Size(0x70, 20);
      this.btnTLEN.Size = size;
      this.btnTLEN.TabIndex = 30;
      this.btnTLEN.Text = "Length from file";
      this.txtTLEN.AllowNegative = false;
      this.txtTLEN.DigitsInGroup = 0;
      this.txtTLEN.Flags = 0x10000;
      point = new Point(0xa8, 0x20);
      this.txtTLEN.Location = point;
      this.txtTLEN.MaxDecimalPlaces = 0;
      this.txtTLEN.MaxLength = 10;
      this.txtTLEN.MaxWholeDigits = 10;
      this.txtTLEN.Name = "txtTLEN";
      this.txtTLEN.Prefix = "";
      this.txtTLEN.RangeMax = 9999999999;
      this.txtTLEN.RangeMin = 0.0;
      size = new Size(0x88, 20);
      this.txtTLEN.Size = size;
      this.txtTLEN.TabIndex = 0x1d;
      this.lblTLEN.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblTLEN.Location = point;
      this.lblTLEN.Name = "lblTLEN";
      size = new Size(0x98, 0x10);
      this.lblTLEN.Size = size;
      this.lblTLEN.TabIndex = 0x1c;
      this.lblTLEN.Text = "Track length (msec):";
      this.cmbMedia.ItemHeight = 13;
      this.cmbMedia.Items.AddRange(new object[] { "ANA (Other analogue media)", "CD (CD)", "DAT (DAT)", "DCC (DCC)", "DIG (Other digital media)", "DVD (DVD)", "LD (LaserDisc)", "MC (Music Cassette)", "MD (MiniDisc)", "RAD (Radio)", "REE (Reel)", "TEL (Telephone)", "TT (Turntable records)", "TV (Television)", "VID (Video)" });
      point = new Point(0xa8, 6);
      this.cmbMedia.Location = point;
      this.cmbMedia.Name = "cmbMedia";
      size = new Size(0x100, 0x15);
      this.cmbMedia.Size = size;
      this.cmbMedia.TabIndex = 0x12;
      this.lblMediaTyp.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblMediaTyp.Location = point;
      this.lblMediaTyp.Name = "lblMediaTyp";
      size = new Size(0x98, 0x10);
      this.lblMediaTyp.Size = size;
      this.lblMediaTyp.TabIndex = 0x11;
      this.lblMediaTyp.Text = "M&edia type:";
      this.Panel9.BorderStyle = BorderStyle.FixedSingle;
      this.Panel9.Controls.Add(this.txtSortArtist);
      this.Panel9.Controls.Add(this.txtSortTitle);
      this.Panel9.Controls.Add(this.txtSortAlbum);
      this.Panel9.Controls.Add(this.lblAlbumSort);
      this.Panel9.Controls.Add(this.lblTitleSort);
      this.Panel9.Controls.Add(this.lblArtistSort);
      point = new Point(8, 280);
      this.Panel9.Location = point;
      this.Panel9.Name = "Panel9";
      size = new Size(0x288, 80);
      this.Panel9.Size = size;
      this.Panel9.TabIndex = 2;
      point = new Point(0xa8, 6);
      this.txtSortArtist.Location = point;
      this.txtSortArtist.Name = "txtSortArtist";
      size = new Size(0x1d8, 20);
      this.txtSortArtist.Size = size;
      this.txtSortArtist.TabIndex = 0x11;
      this.txtSortArtist.Text = "";
      point = new Point(0xa8, 0x36);
      this.txtSortTitle.Location = point;
      this.txtSortTitle.Name = "txtSortTitle";
      size = new Size(0x1d8, 20);
      this.txtSortTitle.Size = size;
      this.txtSortTitle.TabIndex = 0x15;
      this.txtSortTitle.Text = "";
      point = new Point(0xa8, 30);
      this.txtSortAlbum.Location = point;
      this.txtSortAlbum.Name = "txtSortAlbum";
      size = new Size(0x1d8, 20);
      this.txtSortAlbum.Size = size;
      this.txtSortAlbum.TabIndex = 0x13;
      this.txtSortAlbum.Text = "";
      this.lblAlbumSort.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblAlbumSort.Location = point;
      this.lblAlbumSort.Name = "lblAlbumSort";
      size = new Size(0xa8, 0x10);
      this.lblAlbumSort.Size = size;
      this.lblAlbumSort.TabIndex = 0x12;
      this.lblAlbumSort.Text = "Al&bum sort name (Ver. 2.4 only):";
      this.lblTitleSort.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblTitleSort.Location = point;
      this.lblTitleSort.Name = "lblTitleSort";
      size = new Size(160, 0x10);
      this.lblTitleSort.Size = size;
      this.lblTitleSort.TabIndex = 20;
      this.lblTitleSort.Text = "&Title sort name (Ver. 2.4 only):";
      this.lblArtistSort.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblArtistSort.Location = point;
      this.lblArtistSort.Name = "lblArtistSort";
      size = new Size(0xa8, 0x10);
      this.lblArtistSort.Size = size;
      this.lblArtistSort.TabIndex = 0x10;
      this.lblArtistSort.Text = "&Artist sort name (Ver. 2.4 only):";
      this.Panel6.BorderStyle = BorderStyle.FixedSingle;
      this.Panel6.Controls.Add(this.txtTORY);
      this.Panel6.Controls.Add(this.lblOYearInfo);
      this.Panel6.Controls.Add(this.TORYFormat);
      this.Panel6.Controls.Add(this.lblOYear);
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
      point = new Point(8, 8);
      this.Panel6.Location = point;
      this.Panel6.Name = "Panel6";
      size = new Size(0x288, 0x98);
      this.Panel6.Size = size;
      this.Panel6.TabIndex = 3;
      this.txtTORY.Flags = 0;
      point = new Point(0xa8, 0x7e);
      this.txtTORY.Location = point;
      this.txtTORY.Mask = "####-##-##";
      this.txtTORY.Name = "txtTORY";
      size = new Size(0x70, 20);
      this.txtTORY.Size = size;
      this.txtTORY.TabIndex = 0x21;
      this.lblOYearInfo.ImeMode = ImeMode.NoControl;
      point = new Point(0x150, 0x80);
      this.lblOYearInfo.Location = point;
      this.lblOYearInfo.Name = "lblOYearInfo";
      size = new Size(0x130, 0x10);
      this.lblOYearInfo.Size = size;
      this.lblOYearInfo.TabIndex = 0x24;
      this.lblOYearInfo.Text = "(In TAG Ver. 2.3 only the year entry will be saved)";
      this.TORYFormat.ImeMode = ImeMode.NoControl;
      this.TORYFormat.LargeChange = 1;
      point = new Point(0x120, 0x80);
      this.TORYFormat.Location = point;
      this.TORYFormat.Maximum = 2;
      this.TORYFormat.Name = "TORYFormat";
      size = new Size(0x20, 0x10);
      this.TORYFormat.Size = size;
      this.TORYFormat.TabIndex = 0x22;
      this.lblOYear.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x80);
      this.lblOYear.Location = point;
      this.lblOYear.Name = "lblOYear";
      size = new Size(0x90, 0x10);
      this.lblOYear.Size = size;
      this.lblOYear.TabIndex = 0x20;
      this.lblOYear.Text = "Original release &year (date):";
      point = new Point(0xa8, 0x66);
      this.txtOOwner.Location = point;
      this.txtOOwner.Name = "txtOOwner";
      size = new Size(0x1d8, 20);
      this.txtOOwner.Size = size;
      this.txtOOwner.TabIndex = 0x1f;
      this.txtOOwner.Text = "";
      this.lblOOwner.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x68);
      this.lblOOwner.Location = point;
      this.lblOOwner.Name = "lblOOwner";
      size = new Size(0x80, 0x10);
      this.lblOOwner.Size = size;
      this.lblOOwner.TabIndex = 30;
      this.lblOOwner.Text = "Original &owner:";
      point = new Point(0xa8, 0x4e);
      this.txtOArtist.Location = point;
      this.txtOArtist.Name = "txtOArtist";
      size = new Size(0x1d8, 20);
      this.txtOArtist.Size = size;
      this.txtOArtist.TabIndex = 0x1d;
      this.txtOArtist.Text = "";
      this.lblOArtist.ImeMode = ImeMode.NoControl;
      point = new Point(8, 80);
      this.lblOArtist.Location = point;
      this.lblOArtist.Name = "lblOArtist";
      size = new Size(0x80, 0x10);
      this.lblOArtist.Size = size;
      this.lblOArtist.TabIndex = 0x1c;
      this.lblOArtist.Text = "Original &artist:";
      point = new Point(0xa8, 6);
      this.txtOAlbum.Location = point;
      this.txtOAlbum.Name = "txtOAlbum";
      size = new Size(0x1d8, 20);
      this.txtOAlbum.Size = size;
      this.txtOAlbum.TabIndex = 0x17;
      this.txtOAlbum.Text = "";
      point = new Point(0xa8, 0x36);
      this.txtOLyWriter.Location = point;
      this.txtOLyWriter.Name = "txtOLyWriter";
      size = new Size(0x1d8, 20);
      this.txtOLyWriter.Size = size;
      this.txtOLyWriter.TabIndex = 0x1b;
      this.txtOLyWriter.Text = "";
      point = new Point(0xa8, 30);
      this.txtOFilename.Location = point;
      this.txtOFilename.Name = "txtOFilename";
      size = new Size(0x1d8, 20);
      this.txtOFilename.Size = size;
      this.txtOFilename.TabIndex = 0x19;
      this.txtOFilename.Text = "";
      this.lblOFilename.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblOFilename.Location = point;
      this.lblOFilename.Name = "lblOFilename";
      size = new Size(0x80, 0x10);
      this.lblOFilename.Size = size;
      this.lblOFilename.TabIndex = 0x18;
      this.lblOFilename.Text = "Original &filename:";
      this.lblOLyWriter.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblOLyWriter.Location = point;
      this.lblOLyWriter.Name = "lblOLyWriter";
      size = new Size(0x80, 0x10);
      this.lblOLyWriter.Size = size;
      this.lblOLyWriter.TabIndex = 0x1a;
      this.lblOLyWriter.Text = "Original lyrics &writer:";
      this.lblOAlbum.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblOAlbum.Location = point;
      this.lblOAlbum.Name = "lblOAlbum";
      size = new Size(0x80, 0x10);
      this.lblOAlbum.Size = size;
      this.lblOAlbum.TabIndex = 0x16;
      this.lblOAlbum.Text = "Original a&lbum title:";
      this.Panel5.BorderStyle = BorderStyle.FixedSingle;
      this.Panel5.Controls.Add(this.txtContent);
      this.Panel5.Controls.Add(this.txtSubTitle);
      this.Panel5.Controls.Add(this.lblSubTitle);
      this.Panel5.Controls.Add(this.lblContent);
      point = new Point(8, 0xd8);
      this.Panel5.Location = point;
      this.Panel5.Name = "Panel5";
      size = new Size(0x288, 0x38);
      this.Panel5.Size = size;
      this.Panel5.TabIndex = 1;
      point = new Point(0xa8, 6);
      this.txtContent.Location = point;
      this.txtContent.Name = "txtContent";
      size = new Size(0x1d8, 20);
      this.txtContent.Size = size;
      this.txtContent.TabIndex = 13;
      this.txtContent.Text = "";
      point = new Point(0xa8, 30);
      this.txtSubTitle.Location = point;
      this.txtSubTitle.Name = "txtSubTitle";
      size = new Size(0x1d8, 20);
      this.txtSubTitle.Size = size;
      this.txtSubTitle.TabIndex = 15;
      this.txtSubTitle.Text = "";
      this.lblSubTitle.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblSubTitle.Location = point;
      this.lblSubTitle.Name = "lblSubTitle";
      size = new Size(0x80, 0x10);
      this.lblSubTitle.Size = size;
      this.lblSubTitle.TabIndex = 14;
      this.lblSubTitle.Text = "&Sub Title:";
      this.lblContent.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblContent.Location = point;
      this.lblContent.Name = "lblContent";
      size = new Size(0x80, 0x10);
      this.lblContent.Size = size;
      this.lblContent.TabIndex = 12;
      this.lblContent.Text = "Con&tent Group:";
      this.Panel4.BorderStyle = BorderStyle.FixedSingle;
      this.Panel4.Controls.Add(this.txtComposer);
      this.Panel4.Controls.Add(this.lblComposer);
      this.Panel4.Controls.Add(this.txtBand);
      this.Panel4.Controls.Add(this.txtModified);
      this.Panel4.Controls.Add(this.txtConductor);
      this.Panel4.Controls.Add(this.lblConductor);
      this.Panel4.Controls.Add(this.lblModified);
      this.Panel4.Controls.Add(this.lblBand);
      this.Panel4.Controls.Add(this.txtCopyright);
      this.Panel4.Controls.Add(this.lblCopyright);
      this.Panel4.Controls.Add(this.txtLyWriter);
      this.Panel4.Controls.Add(this.txtEncoded);
      this.Panel4.Controls.Add(this.txtPublisher);
      this.Panel4.Controls.Add(this.lblPublisher);
      this.Panel4.Controls.Add(this.lblEncoded);
      this.Panel4.Controls.Add(this.lblLyWriter);
      point = new Point(8, 8);
      this.Panel4.Location = point;
      this.Panel4.Name = "Panel4";
      size = new Size(0x288, 200);
      this.Panel4.Size = size;
      this.Panel4.TabIndex = 0;
      point = new Point(0xa8, 0x4b);
      this.txtComposer.Location = point;
      this.txtComposer.Name = "txtComposer";
      size = new Size(0x1d8, 20);
      this.txtComposer.Size = size;
      this.txtComposer.TabIndex = 11;
      this.txtComposer.Text = "";
      this.lblComposer.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x4d);
      this.lblComposer.Location = point;
      this.lblComposer.Name = "lblComposer";
      size = new Size(0x80, 0x10);
      this.lblComposer.Size = size;
      this.lblComposer.TabIndex = 10;
      this.lblComposer.Text = "Co&mposer:";
      point = new Point(0xa8, 6);
      this.txtBand.Location = point;
      this.txtBand.Name = "txtBand";
      size = new Size(0x1d8, 20);
      this.txtBand.Size = size;
      this.txtBand.TabIndex = 5;
      this.txtBand.Text = "";
      point = new Point(0xa8, 0x34);
      this.txtModified.Location = point;
      this.txtModified.Name = "txtModified";
      size = new Size(0x1d8, 20);
      this.txtModified.Size = size;
      this.txtModified.TabIndex = 9;
      this.txtModified.Text = "";
      point = new Point(0xa8, 0x1d);
      this.txtConductor.Location = point;
      this.txtConductor.Name = "txtConductor";
      size = new Size(0x1d8, 20);
      this.txtConductor.Size = size;
      this.txtConductor.TabIndex = 7;
      this.txtConductor.Text = "";
      this.lblConductor.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x1f);
      this.lblConductor.Location = point;
      this.lblConductor.Name = "lblConductor";
      size = new Size(0x80, 0x10);
      this.lblConductor.Size = size;
      this.lblConductor.TabIndex = 6;
      this.lblConductor.Text = "&Conductor:";
      this.lblModified.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x36);
      this.lblModified.Location = point;
      this.lblModified.Name = "lblModified";
      size = new Size(0x80, 0x10);
      this.lblModified.Size = size;
      this.lblModified.TabIndex = 8;
      this.lblModified.Text = "Modified / Remixed b&y:";
      this.lblBand.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblBand.Location = point;
      this.lblBand.Name = "lblBand";
      size = new Size(0x80, 0x10);
      this.lblBand.Size = size;
      this.lblBand.TabIndex = 4;
      this.lblBand.Text = "&Band / Orchestra:";
      point = new Point(0xa8, 0xa7);
      this.txtCopyright.Location = point;
      this.txtCopyright.Name = "txtCopyright";
      size = new Size(0x1d8, 20);
      this.txtCopyright.Size = size;
      this.txtCopyright.TabIndex = 0x17;
      this.txtCopyright.Text = "";
      this.lblCopyright.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0xa9);
      this.lblCopyright.Location = point;
      this.lblCopyright.Name = "lblCopyright";
      size = new Size(0x80, 0x10);
      this.lblCopyright.Size = size;
      this.lblCopyright.TabIndex = 0x16;
      this.lblCopyright.Text = "Copyright:";
      point = new Point(0xa8, 0x62);
      this.txtLyWriter.Location = point;
      this.txtLyWriter.Name = "txtLyWriter";
      size = new Size(0x1d8, 20);
      this.txtLyWriter.Size = size;
      this.txtLyWriter.TabIndex = 0x11;
      this.txtLyWriter.Text = "";
      point = new Point(0xa8, 0x90);
      this.txtEncoded.Location = point;
      this.txtEncoded.Name = "txtEncoded";
      size = new Size(0x1d8, 20);
      this.txtEncoded.Size = size;
      this.txtEncoded.TabIndex = 0x15;
      this.txtEncoded.Text = "";
      point = new Point(0xa8, 0x79);
      this.txtPublisher.Location = point;
      this.txtPublisher.Name = "txtPublisher";
      size = new Size(0x1d8, 20);
      this.txtPublisher.Size = size;
      this.txtPublisher.TabIndex = 0x13;
      this.txtPublisher.Text = "";
      this.lblPublisher.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x7b);
      this.lblPublisher.Location = point;
      this.lblPublisher.Name = "lblPublisher";
      size = new Size(0x80, 0x10);
      this.lblPublisher.Size = size;
      this.lblPublisher.TabIndex = 0x12;
      this.lblPublisher.Text = "Publis&her:";
      this.lblEncoded.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x92);
      this.lblEncoded.Location = point;
      this.lblEncoded.Name = "lblEncoded";
      size = new Size(0x80, 0x10);
      this.lblEncoded.Size = size;
      this.lblEncoded.TabIndex = 20;
      this.lblEncoded.Text = "&Encoded by:";
      this.lblLyWriter.ImeMode = ImeMode.NoControl;
      point = new Point(8, 100);
      this.lblLyWriter.Location = point;
      this.lblLyWriter.Name = "lblLyWriter";
      size = new Size(0x80, 0x10);
      this.lblLyWriter.Size = size;
      this.lblLyWriter.TabIndex = 0x10;
      this.lblLyWriter.Text = "Lyr&ics / Text Writer:";
      this.Panel15.BorderStyle = BorderStyle.FixedSingle;
      this.Panel15.Controls.Add(this.lblMusicianInfo);
      this.Panel15.Controls.Add(this.txtMusicianName);
      this.Panel15.Controls.Add(this.btnRemoveMusician);
      this.Panel15.Controls.Add(this.btnAddMusician);
      this.Panel15.Controls.Add(this.lblMusicianName);
      this.Panel15.Controls.Add(this.lblMusicianInst);
      this.Panel15.Controls.Add(this.txtMusicianInst);
      this.Panel15.Controls.Add(this.TMCLList);
      point = new Point(8, 160);
      this.Panel15.Location = point;
      this.Panel15.Name = "Panel15";
      size = new Size(0x288, 0x90);
      this.Panel15.Size = size;
      this.Panel15.TabIndex = 5;
      this.lblMusicianInfo.ImeMode = ImeMode.NoControl;
      point = new Point(8, 120);
      this.lblMusicianInfo.Location = point;
      this.lblMusicianInfo.Name = "lblMusicianInfo";
      size = new Size(0x80, 0x10);
      this.lblMusicianInfo.Size = size;
      this.lblMusicianInfo.TabIndex = 0x10;
      this.lblMusicianInfo.Text = "(TAG Ver. 2.4 only)";
      point = new Point(160, 30);
      this.txtMusicianName.Location = point;
      this.txtMusicianName.Name = "txtMusicianName";
      size = new Size(320, 20);
      this.txtMusicianName.Size = size;
      this.txtMusicianName.TabIndex = 12;
      this.txtMusicianName.Text = "";
      this.btnRemoveMusician.ImeMode = ImeMode.NoControl;
      point = new Point(0x1e8, 0x20);
      this.btnRemoveMusician.Location = point;
      this.btnRemoveMusician.Name = "btnRemoveMusician";
      size = new Size(0x98, 20);
      this.btnRemoveMusician.Size = size;
      this.btnRemoveMusician.TabIndex = 14;
      this.btnRemoveMusician.Text = "Remove musician";
      this.btnAddMusician.ImeMode = ImeMode.NoControl;
      point = new Point(0x1e8, 8);
      this.btnAddMusician.Location = point;
      this.btnAddMusician.Name = "btnAddMusician";
      size = new Size(0x98, 20);
      this.btnAddMusician.Size = size;
      this.btnAddMusician.TabIndex = 13;
      this.btnAddMusician.Text = "Add musician";
      this.lblMusicianName.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblMusicianName.Location = point;
      this.lblMusicianName.Name = "lblMusicianName";
      size = new Size(0x80, 0x10);
      this.lblMusicianName.Size = size;
      this.lblMusicianName.TabIndex = 11;
      this.lblMusicianName.Text = "Musician name:";
      this.lblMusicianInst.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblMusicianInst.Location = point;
      this.lblMusicianInst.Name = "lblMusicianInst";
      size = new Size(0x80, 0x10);
      this.lblMusicianInst.Size = size;
      this.lblMusicianInst.TabIndex = 9;
      this.lblMusicianInst.Text = "Musician instrument:";
      point = new Point(160, 6);
      this.txtMusicianInst.Location = point;
      this.txtMusicianInst.Name = "txtMusicianInst";
      size = new Size(320, 20);
      this.txtMusicianInst.Size = size;
      this.txtMusicianInst.TabIndex = 10;
      this.txtMusicianInst.Text = "";
      this.TMCLList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader15, this.ColumnHeader16 });
      this.TMCLList.FullRowSelect = true;
      this.TMCLList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(160, 0x40);
      this.TMCLList.Location = point;
      this.TMCLList.MultiSelect = false;
      this.TMCLList.Name = "TMCLList";
      size = new Size(480, 0x48);
      this.TMCLList.Size = size;
      this.TMCLList.TabIndex = 15;
      this.TMCLList.View = View.Details;
      this.ColumnHeader15.Text = "Instrument";
      this.ColumnHeader15.Width = 200;
      this.ColumnHeader16.Text = "Name";
      this.ColumnHeader16.Width = 0xfe;
      this.Panel16.BorderStyle = BorderStyle.FixedSingle;
      this.Panel16.Controls.Add(this.txtInvPerson);
      this.Panel16.Controls.Add(this.btnRemoveInv);
      this.Panel16.Controls.Add(this.btnAddInv);
      this.Panel16.Controls.Add(this.lblInvPerson);
      this.Panel16.Controls.Add(this.lblInvFunction);
      this.Panel16.Controls.Add(this.txtInvFunction);
      this.Panel16.Controls.Add(this.TIPLList);
      point = new Point(8, 8);
      this.Panel16.Location = point;
      this.Panel16.Name = "Panel16";
      size = new Size(0x288, 0x90);
      this.Panel16.Size = size;
      this.Panel16.TabIndex = 4;
      point = new Point(160, 30);
      this.txtInvPerson.Location = point;
      this.txtInvPerson.Name = "txtInvPerson";
      size = new Size(320, 20);
      this.txtInvPerson.Size = size;
      this.txtInvPerson.TabIndex = 5;
      this.txtInvPerson.Text = "";
      this.btnRemoveInv.ImeMode = ImeMode.NoControl;
      point = new Point(0x1e8, 0x20);
      this.btnRemoveInv.Location = point;
      this.btnRemoveInv.Name = "btnRemoveInv";
      size = new Size(0x98, 20);
      this.btnRemoveInv.Size = size;
      this.btnRemoveInv.TabIndex = 7;
      this.btnRemoveInv.Text = "Remove involved person";
      this.btnAddInv.ImeMode = ImeMode.NoControl;
      point = new Point(0x1e8, 8);
      this.btnAddInv.Location = point;
      this.btnAddInv.Name = "btnAddInv";
      size = new Size(0x98, 20);
      this.btnAddInv.Size = size;
      this.btnAddInv.TabIndex = 6;
      this.btnAddInv.Text = "Add involved person";
      this.lblInvPerson.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblInvPerson.Location = point;
      this.lblInvPerson.Name = "lblInvPerson";
      size = new Size(0x90, 0x10);
      this.lblInvPerson.Size = size;
      this.lblInvPerson.TabIndex = 4;
      this.lblInvPerson.Text = "Involved person name:";
      this.lblInvFunction.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblInvFunction.Location = point;
      this.lblInvFunction.Name = "lblInvFunction";
      size = new Size(0x90, 0x10);
      this.lblInvFunction.Size = size;
      this.lblInvFunction.TabIndex = 2;
      this.lblInvFunction.Text = "Involved person function:";
      point = new Point(160, 6);
      this.txtInvFunction.Location = point;
      this.txtInvFunction.Name = "txtInvFunction";
      size = new Size(320, 20);
      this.txtInvFunction.Size = size;
      this.txtInvFunction.TabIndex = 3;
      this.txtInvFunction.Text = "";
      this.TIPLList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader17, this.ColumnHeader18 });
      this.TIPLList.FullRowSelect = true;
      this.TIPLList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(160, 0x40);
      this.TIPLList.Location = point;
      this.TIPLList.MultiSelect = false;
      this.TIPLList.Name = "TIPLList";
      size = new Size(480, 0x48);
      this.TIPLList.Size = size;
      this.TIPLList.TabIndex = 8;
      this.TIPLList.View = View.Details;
      this.ColumnHeader17.Text = "Function";
      this.ColumnHeader17.Width = 0xbf;
      this.ColumnHeader18.Text = "Name";
      this.ColumnHeader18.Width = 0x108;
      this.Panel14.BorderStyle = BorderStyle.FixedSingle;
      this.Panel14.Controls.Add(this.btnTLEN);
      this.Panel14.Controls.Add(this.txtTLEN);
      this.Panel14.Controls.Add(this.lblTLEN);
      this.Panel14.Controls.Add(this.cmbMedia);
      this.Panel14.Controls.Add(this.lblMediaTyp);
      point = new Point(8, 0x170);
      this.Panel14.Location = point;
      this.Panel14.Name = "Panel14";
      size = new Size(0x288, 0x40);
      this.Panel14.Size = size;
      this.Panel14.TabIndex = 3;
      this.Panel7.BorderStyle = BorderStyle.FixedSingle;
      this.Panel7.Controls.Add(this.chkPicRelativPath);
      this.Panel7.Controls.Add(this.btnExPic);
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
      point = new Point(8, 8);
      this.Panel7.Location = point;
      this.Panel7.Name = "Panel7";
      size = new Size(0x288, 0x120);
      this.Panel7.Size = size;
      this.Panel7.TabIndex = 0;
      point = new Point(8, 0x68);
      this.chkPicRelativPath.Location = point;
      this.chkPicRelativPath.Name = "chkPicRelativPath";
      size = new Size(0x1c0, 0x10);
      this.chkPicRelativPath.Size = size;
      this.chkPicRelativPath.TabIndex = 9;
      this.chkPicRelativPath.Text = "Use relativ path if picture is not included";
      this.btnExPic.Enabled = false;
      point = new Point(0x138, 160);
      this.btnExPic.Location = point;
      this.btnExPic.Name = "btnExPic";
      size = new Size(0x90, 0x18);
      this.btnExPic.Size = size;
      this.btnExPic.TabIndex = 13;
      this.btnExPic.Text = "Extract picture";
      this.btnRemovePicture.ImeMode = ImeMode.NoControl;
      point = new Point(160, 0x80);
      this.btnRemovePicture.Location = point;
      this.btnRemovePicture.Name = "btnRemovePicture";
      size = new Size(0x90, 0x18);
      this.btnRemovePicture.Size = size;
      this.btnRemovePicture.TabIndex = 11;
      this.btnRemovePicture.Text = "Remove Picture";
      this.btnAddPicture.Enabled = false;
      this.btnAddPicture.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x80);
      this.btnAddPicture.Location = point;
      this.btnAddPicture.Name = "btnAddPicture";
      size = new Size(0x90, 0x18);
      this.btnAddPicture.Size = size;
      this.btnAddPicture.TabIndex = 10;
      this.btnAddPicture.Text = "Add Picture";
      this.btnGetPic.ImeMode = ImeMode.NoControl;
      point = new Point(0x138, 0x80);
      this.btnGetPic.Location = point;
      this.btnGetPic.Name = "btnGetPic";
      size = new Size(0x90, 0x18);
      this.btnGetPic.Size = size;
      this.btnGetPic.TabIndex = 12;
      this.btnGetPic.Text = "Get new picture";
      this.chkPicInclude.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x54);
      this.chkPicInclude.Location = point;
      this.chkPicInclude.Name = "chkPicInclude";
      size = new Size(0x1c0, 0x10);
      this.chkPicInclude.Size = size;
      this.chkPicInclude.TabIndex = 8;
      this.chkPicInclude.Text = "Include picture within the MP3 file when saving";
      this.lblPicPath.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblPicPath.Location = point;
      this.lblPicPath.Name = "lblPicPath";
      size = new Size(0x88, 0x10);
      this.lblPicPath.Size = size;
      this.lblPicPath.TabIndex = 6;
      this.lblPicPath.Text = "P&ath containing pic. data:";
      point = new Point(0x98, 0x36);
      this.txtPicPath.Location = point;
      this.txtPicPath.Name = "txtPicPath";
      this.txtPicPath.ReadOnly = true;
      size = new Size(0x130, 20);
      this.txtPicPath.Size = size;
      this.txtPicPath.TabIndex = 7;
      this.txtPicPath.Text = "";
      this.PicList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader4, this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader7 });
      this.PicList.FullRowSelect = true;
      this.PicList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(8, 200);
      this.PicList.Location = point;
      this.PicList.MultiSelect = false;
      this.PicList.Name = "PicList";
      size = new Size(0x278, 80);
      this.PicList.Size = size;
      this.PicList.TabIndex = 14;
      this.PicList.View = View.Details;
      this.ColumnHeader4.Text = "Descriptor";
      this.ColumnHeader4.Width = 160;
      this.ColumnHeader5.Text = "Picture Type";
      this.ColumnHeader5.Width = 0x63;
      this.ColumnHeader6.Text = "Path";
      this.ColumnHeader6.Width = 0x120;
      this.ColumnHeader7.Text = "Include";
      this.lblPicType.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblPicType.Location = point;
      this.lblPicType.Name = "lblPicType";
      size = new Size(0x88, 0x10);
      this.lblPicType.Size = size;
      this.lblPicType.TabIndex = 4;
      this.lblPicType.Text = "Picture &Type:";
      this.lblPicDesc.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblPicDesc.Location = point;
      this.lblPicDesc.Name = "lblPicDesc";
      size = new Size(0x88, 0x10);
      this.lblPicDesc.Size = size;
      this.lblPicDesc.TabIndex = 2;
      this.lblPicDesc.Text = "&Picture Descriptor:";
      this.cmbPicType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbPicType.ItemHeight = 13;
      this.cmbPicType.Items.AddRange(new object[] {
                "00 - Other", "01 - 32x32 pixels 'file icon' (PNG only)", "02 - Other file icon", "03 - Cover (front)", "04 - Cover (back)", "05 - Leaflet page", "06 - Media (e.g. label side of CD)", "07 - Lead artist/lead performer/soloist", "08 - Artist/performer", "09 - Conductor", "10 - Band/Orchestra", "11 - Composer", "12 - Lyricist/text writer", "13 - Recording Location", "14 - During recording", "15 - During performance",
                "16 - Movie/video screen capture", "17 - A bright coloured fish", "18 - Illustration", "19 - Band/artist logotype", "20 - Publisher/Studio logotype"
            });
      point = new Point(0x98, 30);
      this.cmbPicType.Location = point;
      this.cmbPicType.Name = "cmbPicType";
      size = new Size(0x130, 0x15);
      this.cmbPicType.Size = size;
      this.cmbPicType.TabIndex = 5;
      point = new Point(0x98, 6);
      this.txtPDescriptor.Location = point;
      this.txtPDescriptor.Name = "txtPDescriptor";
      size = new Size(0x130, 20);
      this.txtPDescriptor.Size = size;
      this.txtPDescriptor.TabIndex = 3;
      this.txtPDescriptor.Text = "";
      this.APICView.BorderStyle = BorderStyle.FixedSingle;
      this.APICView.ImeMode = ImeMode.NoControl;
      point = new Point(0x1d0, 8);
      this.APICView.Location = point;
      this.APICView.Name = "APICView";
      size = new Size(0xb0, 0xb0);
      this.APICView.Size = size;
      this.APICView.SizeMode = PictureBoxSizeMode.StretchImage;
      this.APICView.TabIndex = 1;
      this.APICView.TabStop = false;
      this.Panel8.BorderStyle = BorderStyle.FixedSingle;
      this.Panel8.Controls.Add(this.txtLyrics);
      this.Panel8.Controls.Add(this.btnLyricsFile);
      this.Panel8.Controls.Add(this.btnMoveLyrics);
      this.Panel8.Controls.Add(this.btnRemoveLyrics);
      this.Panel8.Controls.Add(this.btnAddLyrics);
      this.Panel8.Controls.Add(this.lblLyrics);
      this.Panel8.Controls.Add(this.lblLyLan);
      this.Panel8.Controls.Add(this.lblLyDesc);
      this.Panel8.Controls.Add(this.cmbLLanguage);
      this.Panel8.Controls.Add(this.txtLDescriptor);
      this.Panel8.Controls.Add(this.LyricsList);
      point = new Point(8, 8);
      this.Panel8.Location = point;
      this.Panel8.Name = "Panel8";
      size = new Size(0x288, 440);
      this.Panel8.Size = size;
      this.Panel8.TabIndex = 1;
      this.txtLyrics.BorderStyle = BorderStyle.FixedSingle;
      point = new Point(0x88, 0x38);
      this.txtLyrics.Location = point;
      this.txtLyrics.Name = "txtLyrics";
      size = new Size(0x1f8, 0xc0);
      this.txtLyrics.Size = size;
      this.txtLyrics.TabIndex = 0x12;
      this.txtLyrics.Text = "";
      point = new Point(0x88, 0x100);
      this.btnLyricsFile.Location = point;
      this.btnLyricsFile.Name = "btnLyricsFile";
      size = new Size(0x1f8, 0x18);
      this.btnLyricsFile.Size = size;
      this.btnLyricsFile.TabIndex = 0x13;
      this.btnLyricsFile.Text = "Get lyrics from text file";
      this.btnMoveLyrics.ImeMode = ImeMode.NoControl;
      point = new Point(0x1e8, 0x120);
      this.btnMoveLyrics.Location = point;
      this.btnMoveLyrics.Name = "btnMoveLyrics";
      size = new Size(0x98, 0x18);
      this.btnMoveLyrics.Size = size;
      this.btnMoveLyrics.TabIndex = 0x16;
      this.btnMoveLyrics.Text = "Move Lyrics to top";
      this.btnRemoveLyrics.ImeMode = ImeMode.NoControl;
      point = new Point(0x138, 0x120);
      this.btnRemoveLyrics.Location = point;
      this.btnRemoveLyrics.Name = "btnRemoveLyrics";
      size = new Size(0x98, 0x18);
      this.btnRemoveLyrics.Size = size;
      this.btnRemoveLyrics.TabIndex = 0x15;
      this.btnRemoveLyrics.Text = "Remove Lyrics";
      this.btnAddLyrics.ImeMode = ImeMode.NoControl;
      point = new Point(0x88, 0x120);
      this.btnAddLyrics.Location = point;
      this.btnAddLyrics.Name = "btnAddLyrics";
      size = new Size(0x98, 0x18);
      this.btnAddLyrics.Size = size;
      this.btnAddLyrics.TabIndex = 20;
      this.btnAddLyrics.Text = "Add Lyrics";
      this.lblLyrics.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblLyrics.Location = point;
      this.lblLyrics.Name = "lblLyrics";
      size = new Size(0x80, 0x10);
      this.lblLyrics.Size = size;
      this.lblLyrics.TabIndex = 0x11;
      this.lblLyrics.Text = "&Lyrics Text:";
      this.lblLyLan.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblLyLan.Location = point;
      this.lblLyLan.Name = "lblLyLan";
      size = new Size(0x80, 0x10);
      this.lblLyLan.Size = size;
      this.lblLyLan.TabIndex = 15;
      this.lblLyLan.Text = "Lyrics &Language:";
      this.lblLyDesc.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblLyDesc.Location = point;
      this.lblLyDesc.Name = "lblLyDesc";
      size = new Size(0x80, 0x10);
      this.lblLyDesc.Size = size;
      this.lblLyDesc.TabIndex = 13;
      this.lblLyDesc.Text = "Lyrics &Descriptor:";
      this.cmbLLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLLanguage.ItemHeight = 13;
      point = new Point(0x88, 30);
      this.cmbLLanguage.Location = point;
      this.cmbLLanguage.Name = "cmbLLanguage";
      size = new Size(0xd0, 0x15);
      this.cmbLLanguage.Size = size;
      this.cmbLLanguage.TabIndex = 0x10;
      point = new Point(0x88, 6);
      this.txtLDescriptor.Location = point;
      this.txtLDescriptor.Name = "txtLDescriptor";
      size = new Size(0xd0, 20);
      this.txtLDescriptor.Size = size;
      this.txtLDescriptor.TabIndex = 14;
      this.txtLDescriptor.Text = "";
      this.LyricsList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3 });
      this.LyricsList.FullRowSelect = true;
      this.LyricsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(8, 320);
      this.LyricsList.Location = point;
      this.LyricsList.MultiSelect = false;
      this.LyricsList.Name = "LyricsList";
      size = new Size(0x278, 0x70);
      this.LyricsList.Size = size;
      this.LyricsList.TabIndex = 0x17;
      this.LyricsList.View = View.Details;
      this.ColumnHeader1.Text = "Descriptor";
      this.ColumnHeader1.Width = 0x84;
      this.ColumnHeader2.Text = "Text";
      this.ColumnHeader2.Width = 0x164;
      this.ColumnHeader3.Text = "Language";
      this.ColumnHeader3.Width = 0x67;
      this.Panel11.BorderStyle = BorderStyle.FixedSingle;
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
      point = new Point(8, 8);
      this.Panel11.Location = point;
      this.Panel11.Name = "Panel11";
      size = new Size(0x288, 280);
      this.Panel11.Size = size;
      this.Panel11.TabIndex = 5;
      this.lblInfo.BorderStyle = BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = ImeMode.NoControl;
      point = new Point(0x88, 0xd0);
      this.lblInfo.Location = point;
      this.lblInfo.Name = "lblInfo";
      size = new Size(0x1f0, 0x38);
      this.lblInfo.Size = size;
      this.lblInfo.TabIndex = 0x2b;
      this.lblInfo.Text = "The rating is 1-255 where 1 is worst and 255 is best. Note that many programs have their own rating scale. The scale 1-255 is given by the ID3 standard and the other programs rescale it.";
      this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
      this.btnMoveRating.ImeMode = ImeMode.NoControl;
      point = new Point(0x1d8, 80);
      this.btnMoveRating.Location = point;
      this.btnMoveRating.Name = "btnMoveRating";
      size = new Size(160, 0x18);
      this.btnMoveRating.Size = size;
      this.btnMoveRating.TabIndex = 0x1a;
      this.btnMoveRating.Text = "Move Rating to top";
      this.btnRemoveRating.ImeMode = ImeMode.NoControl;
      point = new Point(0x130, 80);
      this.btnRemoveRating.Location = point;
      this.btnRemoveRating.Name = "btnRemoveRating";
      size = new Size(160, 0x18);
      this.btnRemoveRating.Size = size;
      this.btnRemoveRating.TabIndex = 0x19;
      this.btnRemoveRating.Text = "Remove Rating";
      this.btnAddRating.ImeMode = ImeMode.NoControl;
      point = new Point(0x88, 80);
      this.btnAddRating.Location = point;
      this.btnAddRating.Name = "btnAddRating";
      size = new Size(160, 0x18);
      this.btnAddRating.Size = size;
      this.btnAddRating.TabIndex = 0x18;
      this.btnAddRating.Text = "Add Rating";
      this.RatingList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader8, this.ColumnHeader9, this.ColumnHeader10 });
      this.RatingList.FullRowSelect = true;
      this.RatingList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(0x88, 0x70);
      this.RatingList.Location = point;
      this.RatingList.MultiSelect = false;
      this.RatingList.Name = "RatingList";
      size = new Size(0x1f0, 0x58);
      this.RatingList.Size = size;
      this.RatingList.TabIndex = 0x1b;
      this.RatingList.View = View.Details;
      this.ColumnHeader8.Text = "User";
      this.ColumnHeader8.Width = 0xee;
      this.ColumnHeader9.Text = "Rating";
      this.ColumnHeader9.Width = 100;
      this.ColumnHeader10.Text = "Play Counter";
      this.ColumnHeader10.Width = 80;
      point = new Point(0x88, 0x36);
      this.txtRatingCounter.Location = point;
      decimal num = new decimal(new int[] { 0xf4240, 0, 0, 0 });
      this.txtRatingCounter.Maximum = num;
      this.txtRatingCounter.Name = "txtRatingCounter";
      size = new Size(80, 20);
      this.txtRatingCounter.Size = size;
      this.txtRatingCounter.TabIndex = 0x17;
      point = new Point(0x88, 30);
      this.txtRatingRating.Location = point;
      num = new decimal(new int[] { 0xff, 0, 0, 0 });
      this.txtRatingRating.Maximum = num;
      this.txtRatingRating.Name = "txtRatingRating";
      size = new Size(80, 20);
      this.txtRatingRating.Size = size;
      this.txtRatingRating.TabIndex = 0x15;
      point = new Point(0x88, 6);
      this.txtRatingUser.Location = point;
      this.txtRatingUser.Name = "txtRatingUser";
      size = new Size(0xe0, 20);
      this.txtRatingUser.Size = size;
      this.txtRatingUser.TabIndex = 0x13;
      this.txtRatingUser.Text = "";
      this.lblRatingRating.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblRatingRating.Location = point;
      this.lblRatingRating.Name = "lblRatingRating";
      size = new Size(120, 0x10);
      this.lblRatingRating.Size = size;
      this.lblRatingRating.TabIndex = 20;
      this.lblRatingRating.Text = "Rating:";
      this.lblRatingCounter.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblRatingCounter.Location = point;
      this.lblRatingCounter.Name = "lblRatingCounter";
      size = new Size(120, 0x10);
      this.lblRatingCounter.Size = size;
      this.lblRatingCounter.TabIndex = 0x16;
      this.lblRatingCounter.Text = "Play counter:";
      this.lblRatingUser.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblRatingUser.Location = point;
      this.lblRatingUser.Name = "lblRatingUser";
      size = new Size(120, 0x10);
      this.lblRatingUser.Size = size;
      this.lblRatingUser.TabIndex = 0x12;
      this.lblRatingUser.Text = "User (email):";
      this.Panel10.BorderStyle = BorderStyle.FixedSingle;
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
      point = new Point(8, 8);
      this.Panel10.Location = point;
      this.Panel10.Name = "Panel10";
      size = new Size(0x288, 200);
      this.Panel10.Size = size;
      this.Panel10.TabIndex = 4;
      point = new Point(200, 0xae);
      this.txtCOMMInfURL.Location = point;
      this.txtCOMMInfURL.Name = "txtCOMMInfURL";
      size = new Size(440, 20);
      this.txtCOMMInfURL.Size = size;
      this.txtCOMMInfURL.TabIndex = 0x11;
      this.txtCOMMInfURL.Text = "";
      this.lblCOMMInfURL.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0xb0);
      this.lblCOMMInfURL.Location = point;
      this.lblCOMMInfURL.Name = "lblCOMMInfURL";
      size = new Size(0xb8, 0x10);
      this.lblCOMMInfURL.Size = size;
      this.lblCOMMInfURL.TabIndex = 0x10;
      this.lblCOMMInfURL.Text = "Commercial information URL:";
      point = new Point(200, 150);
      this.txtPubURL.Location = point;
      this.txtPubURL.Name = "txtPubURL";
      size = new Size(440, 20);
      this.txtPubURL.Size = size;
      this.txtPubURL.TabIndex = 15;
      this.txtPubURL.Text = "";
      this.lblPubURL.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x98);
      this.lblPubURL.Location = point;
      this.lblPubURL.Name = "lblPubURL";
      size = new Size(0xb8, 0x10);
      this.lblPubURL.Size = size;
      this.lblPubURL.TabIndex = 14;
      this.lblPubURL.Text = "Offical publisher URL:";
      point = new Point(200, 0x7e);
      this.txtPayURL.Location = point;
      this.txtPayURL.Name = "txtPayURL";
      size = new Size(440, 20);
      this.txtPayURL.Size = size;
      this.txtPayURL.TabIndex = 13;
      this.txtPayURL.Text = "";
      this.lblPayURL.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x80);
      this.lblPayURL.Location = point;
      this.lblPayURL.Name = "lblPayURL";
      size = new Size(0xb8, 0x10);
      this.lblPayURL.Size = size;
      this.lblPayURL.TabIndex = 12;
      this.lblPayURL.Text = "Offical payment URL:";
      point = new Point(200, 0x66);
      this.txtINetRadioURL.Location = point;
      this.txtINetRadioURL.Name = "txtINetRadioURL";
      size = new Size(440, 20);
      this.txtINetRadioURL.Size = size;
      this.txtINetRadioURL.TabIndex = 11;
      this.txtINetRadioURL.Text = "";
      this.lblINetRadioURL.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x68);
      this.lblINetRadioURL.Location = point;
      this.lblINetRadioURL.Name = "lblINetRadioURL";
      size = new Size(0xb8, 0x10);
      this.lblINetRadioURL.Size = size;
      this.lblINetRadioURL.TabIndex = 10;
      this.lblINetRadioURL.Text = "Offical internet radio station URL:";
      point = new Point(200, 0x4e);
      this.txtAudioSRCURL.Location = point;
      this.txtAudioSRCURL.Name = "txtAudioSRCURL";
      size = new Size(440, 20);
      this.txtAudioSRCURL.Size = size;
      this.txtAudioSRCURL.TabIndex = 9;
      this.txtAudioSRCURL.Text = "";
      this.lblAudioSRCURL.ImeMode = ImeMode.NoControl;
      point = new Point(8, 80);
      this.lblAudioSRCURL.Location = point;
      this.lblAudioSRCURL.Name = "lblAudioSRCURL";
      size = new Size(0xb8, 0x10);
      this.lblAudioSRCURL.Size = size;
      this.lblAudioSRCURL.TabIndex = 8;
      this.lblAudioSRCURL.Text = "Offical audio source URL:";
      point = new Point(200, 6);
      this.txtCopyInfURL.Location = point;
      this.txtCopyInfURL.Name = "txtCopyInfURL";
      size = new Size(440, 20);
      this.txtCopyInfURL.Size = size;
      this.txtCopyInfURL.TabIndex = 3;
      this.txtCopyInfURL.Text = "";
      point = new Point(200, 0x36);
      this.txtArtistURL.Location = point;
      this.txtArtistURL.Name = "txtArtistURL";
      size = new Size(440, 20);
      this.txtArtistURL.Size = size;
      this.txtArtistURL.TabIndex = 7;
      this.txtArtistURL.Text = "";
      point = new Point(200, 30);
      this.txtAudioFileURL.Location = point;
      this.txtAudioFileURL.Name = "txtAudioFileURL";
      size = new Size(440, 20);
      this.txtAudioFileURL.Size = size;
      this.txtAudioFileURL.TabIndex = 5;
      this.txtAudioFileURL.Text = "";
      this.lblAudioFileURL.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblAudioFileURL.Location = point;
      this.lblAudioFileURL.Name = "lblAudioFileURL";
      size = new Size(0xb8, 0x10);
      this.lblAudioFileURL.Size = size;
      this.lblAudioFileURL.TabIndex = 4;
      this.lblAudioFileURL.Text = "Offical audio file URL:";
      this.lblArtistURL.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblArtistURL.Location = point;
      this.lblArtistURL.Name = "lblArtistURL";
      size = new Size(0xb8, 0x10);
      this.lblArtistURL.Size = size;
      this.lblArtistURL.TabIndex = 6;
      this.lblArtistURL.Text = "Offical artist URL:";
      this.lblCopyInfURL.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblCopyInfURL.Location = point;
      this.lblCopyInfURL.Name = "lblCopyInfURL";
      size = new Size(0xb8, 0x10);
      this.lblCopyInfURL.Size = size;
      this.lblCopyInfURL.TabIndex = 2;
      this.lblCopyInfURL.Text = "Copyright information URL:";
      this.Panel13.BorderStyle = BorderStyle.FixedSingle;
      this.Panel13.Controls.Add(this.txtWXXXContent);
      this.Panel13.Controls.Add(this.btnRemoveWXXX);
      this.Panel13.Controls.Add(this.btnAddWXXX);
      this.Panel13.Controls.Add(this.lblWXXXContent);
      this.Panel13.Controls.Add(this.lblWXXXDesc);
      this.Panel13.Controls.Add(this.txtWXXXDesc);
      this.Panel13.Controls.Add(this.WXXXList);
      point = new Point(8, 0xc0);
      this.Panel13.Location = point;
      this.Panel13.Name = "Panel13";
      size = new Size(0x288, 0xb0);
      this.Panel13.Size = size;
      this.Panel13.TabIndex = 1;
      point = new Point(0x88, 30);
      this.txtWXXXContent.Location = point;
      this.txtWXXXContent.Name = "txtWXXXContent";
      size = new Size(0x158, 20);
      this.txtWXXXContent.Size = size;
      this.txtWXXXContent.TabIndex = 12;
      this.txtWXXXContent.Text = "";
      this.btnRemoveWXXX.ImeMode = ImeMode.NoControl;
      point = new Point(0x1e8, 0x20);
      this.btnRemoveWXXX.Location = point;
      this.btnRemoveWXXX.Name = "btnRemoveWXXX";
      size = new Size(0x98, 20);
      this.btnRemoveWXXX.Size = size;
      this.btnRemoveWXXX.TabIndex = 14;
      this.btnRemoveWXXX.Text = "Remove user web frame";
      this.btnAddWXXX.ImeMode = ImeMode.NoControl;
      point = new Point(0x1e8, 8);
      this.btnAddWXXX.Location = point;
      this.btnAddWXXX.Name = "btnAddWXXX";
      size = new Size(0x98, 20);
      this.btnAddWXXX.Size = size;
      this.btnAddWXXX.TabIndex = 13;
      this.btnAddWXXX.Text = "Add user web frame";
      this.lblWXXXContent.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblWXXXContent.Location = point;
      this.lblWXXXContent.Name = "lblWXXXContent";
      size = new Size(0x80, 0x10);
      this.lblWXXXContent.Size = size;
      this.lblWXXXContent.TabIndex = 11;
      this.lblWXXXContent.Text = "Web frame &Content:";
      this.lblWXXXDesc.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblWXXXDesc.Location = point;
      this.lblWXXXDesc.Name = "lblWXXXDesc";
      size = new Size(0x80, 0x10);
      this.lblWXXXDesc.Size = size;
      this.lblWXXXDesc.TabIndex = 9;
      this.lblWXXXDesc.Text = "Web frame &Descriptor:";
      point = new Point(0x88, 6);
      this.txtWXXXDesc.Location = point;
      this.txtWXXXDesc.Name = "txtWXXXDesc";
      size = new Size(0x158, 20);
      this.txtWXXXDesc.Size = size;
      this.txtWXXXDesc.TabIndex = 10;
      this.txtWXXXDesc.Text = "";
      this.WXXXList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader13, this.ColumnHeader14 });
      this.WXXXList.FullRowSelect = true;
      this.WXXXList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(0x88, 0x40);
      this.WXXXList.Location = point;
      this.WXXXList.MultiSelect = false;
      this.WXXXList.Name = "WXXXList";
      size = new Size(0x1f8, 0x68);
      this.WXXXList.Size = size;
      this.WXXXList.TabIndex = 15;
      this.WXXXList.View = View.Details;
      this.ColumnHeader13.Text = "Descriptor";
      this.ColumnHeader13.Width = 200;
      this.ColumnHeader14.Text = "Content";
      this.ColumnHeader14.Width = 260;
      this.Panel12.BorderStyle = BorderStyle.FixedSingle;
      this.Panel12.Controls.Add(this.txtTXXXContent);
      this.Panel12.Controls.Add(this.btnRemoveTXXX);
      this.Panel12.Controls.Add(this.btnAddTXXX);
      this.Panel12.Controls.Add(this.lblTXXXContent);
      this.Panel12.Controls.Add(this.lblTXXXDesc);
      this.Panel12.Controls.Add(this.txtTXXXDesc);
      this.Panel12.Controls.Add(this.TXXXList);
      point = new Point(8, 8);
      this.Panel12.Location = point;
      this.Panel12.Name = "Panel12";
      size = new Size(0x288, 0xb0);
      this.Panel12.Size = size;
      this.Panel12.TabIndex = 0;
      point = new Point(0x88, 30);
      this.txtTXXXContent.Location = point;
      this.txtTXXXContent.Name = "txtTXXXContent";
      size = new Size(0x158, 20);
      this.txtTXXXContent.Size = size;
      this.txtTXXXContent.TabIndex = 5;
      this.txtTXXXContent.Text = "";
      this.btnRemoveTXXX.ImeMode = ImeMode.NoControl;
      point = new Point(0x1e8, 0x20);
      this.btnRemoveTXXX.Location = point;
      this.btnRemoveTXXX.Name = "btnRemoveTXXX";
      size = new Size(0x98, 20);
      this.btnRemoveTXXX.Size = size;
      this.btnRemoveTXXX.TabIndex = 7;
      this.btnRemoveTXXX.Text = "Remove user text frame";
      this.btnAddTXXX.ImeMode = ImeMode.NoControl;
      point = new Point(0x1e8, 8);
      this.btnAddTXXX.Location = point;
      this.btnAddTXXX.Name = "btnAddTXXX";
      size = new Size(0x98, 20);
      this.btnAddTXXX.Size = size;
      this.btnAddTXXX.TabIndex = 6;
      this.btnAddTXXX.Text = "Add user text frame";
      this.lblTXXXContent.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x20);
      this.lblTXXXContent.Location = point;
      this.lblTXXXContent.Name = "lblTXXXContent";
      size = new Size(0x80, 0x10);
      this.lblTXXXContent.Size = size;
      this.lblTXXXContent.TabIndex = 4;
      this.lblTXXXContent.Text = "Text frame &Content:";
      this.lblTXXXDesc.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblTXXXDesc.Location = point;
      this.lblTXXXDesc.Name = "lblTXXXDesc";
      size = new Size(0x80, 0x10);
      this.lblTXXXDesc.Size = size;
      this.lblTXXXDesc.TabIndex = 2;
      this.lblTXXXDesc.Text = "Text frame &Descriptor:";
      point = new Point(0x88, 6);
      this.txtTXXXDesc.Location = point;
      this.txtTXXXDesc.Name = "txtTXXXDesc";
      size = new Size(0x158, 20);
      this.txtTXXXDesc.Size = size;
      this.txtTXXXDesc.TabIndex = 3;
      this.txtTXXXDesc.Text = "";
      this.TXXXList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader11, this.ColumnHeader12 });
      this.TXXXList.FullRowSelect = true;
      this.TXXXList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(0x88, 0x40);
      this.TXXXList.Location = point;
      this.TXXXList.MultiSelect = false;
      this.TXXXList.Name = "TXXXList";
      size = new Size(0x1f8, 0x68);
      this.TXXXList.Size = size;
      this.TXXXList.TabIndex = 8;
      this.TXXXList.View = View.Details;
      this.ColumnHeader11.Text = "Descriptor";
      this.ColumnHeader11.Width = 200;
      this.ColumnHeader12.Text = "Content";
      this.ColumnHeader12.Width = 0x102;
      this.lblNot.BorderStyle = BorderStyle.Fixed3D;
      this.lblNot.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x198);
      this.lblNot.Location = point;
      this.lblNot.Name = "lblNot";
      size = new Size(0x288, 40);
      this.lblNot.Size = size;
      this.lblNot.TabIndex = 0x2c;
      this.lblNot.Text = "All frames which are not supported by ID3-TagIT. You cannot edit them but you can remove them by unchecking the checkbox.";
      this.lblNot.TextAlign = ContentAlignment.MiddleCenter;
      this.NotSupportList.CheckBoxes = true;
      this.NotSupportList.Columns.AddRange(new ColumnHeader[] { this.FrameID, this.Content });
      this.NotSupportList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      point = new Point(8, 8);
      this.NotSupportList.Location = point;
      this.NotSupportList.Name = "NotSupportList";
      size = new Size(0x288, 0x188);
      this.NotSupportList.Size = size;
      this.NotSupportList.TabIndex = 0;
      this.NotSupportList.View = View.Details;
      this.FrameID.Text = "Frame ID";
      this.FrameID.Width = 150;
      this.Content.Text = "Content";
      this.Content.Width = 0x1d3;
      this.txtDigits.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
      point = new Point(200, 10);
      this.txtDigits.Location = point;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtDigits.Minimum = num;
      this.txtDigits.Name = "txtDigits";
      size = new Size(0x40, 20);
      this.txtDigits.Size = size;
      this.txtDigits.TabIndex = 0x66;
      num = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtDigits.Value = num;
      this.OpenFileDialog.RestoreDirectory = true;
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
      this.SelectionBar.Groups.AddRange(new BaseItem[] { this.TAGV2grpTAG, this.TAGV2grpTransfer, this.TAGV2grpCommands });
      this.SelectionBar.Images = null;
      point = new Point(0, 0);
      this.SelectionBar.Location = point;
      this.SelectionBar.Name = "SelectionBar";
      size = new Size(0xa8, 0x220);
      this.SelectionBar.Size = size;
      this.SelectionBar.StockStyle = eExplorerBarStockStyle.Silver;
      this.SelectionBar.TabIndex = 0x69;
      this.SelectionBar.Text = "Select TAG section";
      this.TAGV2grpTAG.BackgroundStyle.BackColor1.Color = Color.FromArgb(0xd6, 0xdf, 0xf7);
      this.TAGV2grpTAG.BackgroundStyle.Border = eBorderType.SingleLine;
      this.TAGV2grpTAG.BackgroundStyle.BorderColor.Color = Color.White;
      this.TAGV2grpTAG.CanCustomize = false;
      this.TAGV2grpTAG.HeaderHotStyle.BackColor1.Color = Color.White;
      this.TAGV2grpTAG.HeaderHotStyle.BackColor2.Color = Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.TAGV2grpTAG.HeaderHotStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.TAGV2grpTAG.HeaderHotStyle.ForeColor.Color = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2grpTAG.HeaderStyle.BackColor1.Color = Color.White;
      this.TAGV2grpTAG.HeaderStyle.BackColor2.Color = Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.TAGV2grpTAG.HeaderStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.TAGV2grpTAG.HeaderStyle.ForeColor.Color = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2grpTAG.Name = "TAGV2grpTAG";
      this.TAGV2grpTAG.StockStyle = eExplorerBarStockStyle.Blue;
      this.TAGV2grpTAG.SubItems.AddRange(new BaseItem[] { this.TAGV2ButtonItem1, this.TAGV2ButtonItem2, this.TAGV2ButtonItem3, this.TAGV2ButtonItem4, this.TAGV2ButtonItem5, this.TAGV2ButtonItem6, this.TAGV2ButtonItem7, this.TAGV2ButtonItem8, this.TAGV2ButtonItem9, this.TAGV2ButtonItem10 });
      this.TAGV2grpTAG.Text = "TAG information";
      this.TAGV2ButtonItem1.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem1.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem1.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem1.HotFontUnderline = true;
      this.TAGV2ButtonItem1.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem1.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem1.Icon = (Icon)manager.GetObject("TAGV2ButtonItem1.Icon");
      this.TAGV2ButtonItem1.Name = "TAGV2ButtonItem1";
      this.TAGV2ButtonItem1.Text = "Main Entries";
      this.TAGV2ButtonItem2.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem2.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem2.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem2.HotFontUnderline = true;
      this.TAGV2ButtonItem2.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem2.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem2.Icon = (Icon)manager.GetObject("TAGV2ButtonItem2.Icon");
      this.TAGV2ButtonItem2.Name = "TAGV2ButtonItem2";
      this.TAGV2ButtonItem2.Text = "Detailed information";
      this.TAGV2ButtonItem3.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem3.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem3.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem3.HotFontUnderline = true;
      this.TAGV2ButtonItem3.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem3.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem3.Icon = (Icon)manager.GetObject("TAGV2ButtonItem3.Icon");
      this.TAGV2ButtonItem3.Name = "TAGV2ButtonItem3";
      this.TAGV2ButtonItem3.Text = "Original information";
      this.TAGV2ButtonItem4.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem4.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem4.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem4.HotFontUnderline = true;
      this.TAGV2ButtonItem4.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem4.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem4.Icon = (Icon)manager.GetObject("TAGV2ButtonItem4.Icon");
      this.TAGV2ButtonItem4.Name = "TAGV2ButtonItem4";
      this.TAGV2ButtonItem4.Text = "Involved people";
      this.TAGV2ButtonItem5.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem5.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem5.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem5.HotFontUnderline = true;
      this.TAGV2ButtonItem5.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem5.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem5.Icon = (Icon)manager.GetObject("TAGV2ButtonItem5.Icon");
      this.TAGV2ButtonItem5.Name = "TAGV2ButtonItem5";
      this.TAGV2ButtonItem5.Text = "Web information";
      this.TAGV2ButtonItem6.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem6.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem6.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem6.HotFontUnderline = true;
      this.TAGV2ButtonItem6.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem6.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem6.Icon = (Icon)manager.GetObject("TAGV2ButtonItem6.Icon");
      this.TAGV2ButtonItem6.Name = "TAGV2ButtonItem6";
      this.TAGV2ButtonItem6.Text = "Pictures";
      this.TAGV2ButtonItem7.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem7.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem7.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem7.HotFontUnderline = true;
      this.TAGV2ButtonItem7.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem7.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem7.Icon = (Icon)manager.GetObject("TAGV2ButtonItem7.Icon");
      this.TAGV2ButtonItem7.Name = "TAGV2ButtonItem7";
      this.TAGV2ButtonItem7.Text = "Lyrics";
      this.TAGV2ButtonItem8.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem8.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem8.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem8.HotFontUnderline = true;
      this.TAGV2ButtonItem8.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem8.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem8.Icon = (Icon)manager.GetObject("TAGV2ButtonItem8.Icon");
      this.TAGV2ButtonItem8.Name = "TAGV2ButtonItem8";
      this.TAGV2ButtonItem8.Text = "Rating";
      this.TAGV2ButtonItem9.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem9.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem9.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem9.HotFontUnderline = true;
      this.TAGV2ButtonItem9.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem9.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem9.Icon = (Icon)manager.GetObject("TAGV2ButtonItem9.Icon");
      this.TAGV2ButtonItem9.Name = "TAGV2ButtonItem9";
      this.TAGV2ButtonItem9.Text = "User defined information";
      this.TAGV2ButtonItem10.ButtonStyle = eButtonStyle.ImageAndText;
      this.TAGV2ButtonItem10.Cursor = Cursors.Hand;
      this.TAGV2ButtonItem10.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2ButtonItem10.HotFontUnderline = true;
      this.TAGV2ButtonItem10.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2ButtonItem10.HotTrackingStyle = eHotTrackingStyle.None;
      this.TAGV2ButtonItem10.Icon = (Icon)manager.GetObject("TAGV2ButtonItem10.Icon");
      this.TAGV2ButtonItem10.Name = "TAGV2ButtonItem10";
      this.TAGV2ButtonItem10.Text = "Not supported frames";
      this.TAGV2grpTransfer.BackgroundStyle.BackColor1.Color = Color.FromArgb(0xd6, 0xdf, 0xf7);
      this.TAGV2grpTransfer.BackgroundStyle.Border = eBorderType.SingleLine;
      this.TAGV2grpTransfer.BackgroundStyle.BorderColor.Color = Color.White;
      this.TAGV2grpTransfer.CanCustomize = false;
      this.TAGV2grpTransfer.HeaderHotStyle.BackColor1.Color = Color.White;
      this.TAGV2grpTransfer.HeaderHotStyle.BackColor2.Color = Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.TAGV2grpTransfer.HeaderHotStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.TAGV2grpTransfer.HeaderHotStyle.ForeColor.Color = Color.FromArgb(0x42, 0x8e, 0xff);
      this.TAGV2grpTransfer.HeaderStyle.BackColor1.Color = Color.White;
      this.TAGV2grpTransfer.HeaderStyle.BackColor2.Color = Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.TAGV2grpTransfer.HeaderStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.TAGV2grpTransfer.HeaderStyle.ForeColor.Color = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.TAGV2grpTransfer.Name = "TAGV2grpTransfer";
      this.TAGV2grpTransfer.StockStyle = eExplorerBarStockStyle.Blue;
      this.TAGV2grpTransfer.SubItems.AddRange(new BaseItem[] { this.btnImport, this.btnExport, this.btnGet });
      this.TAGV2grpTransfer.Text = "Transfer and Import";
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
      this.TAGV2grpCommands.BackgroundStyle.BackColor1.Color = Color.FromArgb(0xd6, 0xdf, 0xf7);
      this.TAGV2grpCommands.BackgroundStyle.Border = eBorderType.SingleLine;
      this.TAGV2grpCommands.BackgroundStyle.BorderColor.Color = Color.White;
      this.TAGV2grpCommands.CanCustomize = false;
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
      this.btnCancel.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
      this.btnCancel.BackColor = SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      point = new Point(560, 8);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(0x60, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x68;
      this.btnCancel.Text = "&Cancel";
      this.btnOK.Anchor = AnchorStyles.Right | AnchorStyles.Bottom;
      this.btnOK.BackColor = SystemColors.Control;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(0x1c8, 8);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(0x60, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 0x67;
      this.btnOK.Text = "&OK";
      this.lblDigits.Anchor = AnchorStyles.Left | AnchorStyles.Bottom;
      this.lblDigits.BackColor = Color.White;
      this.lblDigits.ForeColor = Color.Black;
      this.lblDigits.ImeMode = ImeMode.NoControl;
      point = new Point(8, 12);
      this.lblDigits.Location = point;
      this.lblDigits.Name = "lblDigits";
      size = new Size(0xb8, 0x10);
      this.lblDigits.Size = size;
      this.lblDigits.TabIndex = 0x65;
      this.lblDigits.Text = "Number of digits of track numbers:";
      this.TopPanel.AntiAlias = true;
      this.TopPanel.Controls.Add(this.txtSelected);
      this.TopPanel.Controls.Add(this.lblSelected);
      this.TopPanel.Dock = DockStyle.Top;
      point = new Point(0xa8, 0);
      this.TopPanel.Location = point;
      this.TopPanel.Name = "TopPanel";
      size = new Size(0x29a, 0x30);
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
      this.TopPanel.TabIndex = 0x6a;
      this.TopPanel.Text = "TopPanel";
      this.panDetail.BackColor = SystemColors.Control;
      this.panDetail.Controls.Add(this.Panel4);
      this.panDetail.Controls.Add(this.Panel5);
      this.panDetail.Controls.Add(this.Panel9);
      this.panDetail.Controls.Add(this.Panel14);
      point = new Point(0xa8, 0x30);
      this.panDetail.Location = point;
      this.panDetail.Name = "panDetail";
      size = new Size(0x298, 0x1b0);
      this.panDetail.Size = size;
      this.panDetail.TabIndex = 0x75;
      this.panMain.Controls.Add(this.Panel3);
      this.panMain.Controls.Add(this.Panel1);
      this.panMain.Controls.Add(this.Panel2);
      point = new Point(0xa8, 0x30);
      this.panMain.Location = point;
      this.panMain.Name = "panMain";
      size = new Size(0x298, 0x1c8);
      this.panMain.Size = size;
      this.panMain.TabIndex = 0x74;
      this.panOriginal.Controls.Add(this.Panel6);
      point = new Point(0xa8, 0x30);
      this.panOriginal.Location = point;
      this.panOriginal.Name = "panOriginal";
      size = new Size(0x298, 0x1a8);
      this.panOriginal.Size = size;
      this.panOriginal.TabIndex = 0x76;
      this.panInvolved.Controls.Add(this.Panel16);
      this.panInvolved.Controls.Add(this.Panel15);
      point = new Point(0xa8, 0x30);
      this.panInvolved.Location = point;
      this.panInvolved.Name = "panInvolved";
      size = new Size(0x298, 320);
      this.panInvolved.Size = size;
      this.panInvolved.TabIndex = 0x77;
      this.panPic.Controls.Add(this.Panel7);
      point = new Point(0xa8, 0x38);
      this.panPic.Location = point;
      this.panPic.Name = "panPic";
      size = new Size(0x298, 0x130);
      this.panPic.Size = size;
      this.panPic.TabIndex = 120;
      this.panLyrics.Controls.Add(this.Panel8);
      point = new Point(0xa8, 0x30);
      this.panLyrics.Location = point;
      this.panLyrics.Name = "panLyrics";
      size = new Size(0x298, 0x1b0);
      this.panLyrics.Size = size;
      this.panLyrics.TabIndex = 0x79;
      this.panWeb.Controls.Add(this.Panel10);
      point = new Point(0xa8, 0x30);
      this.panWeb.Location = point;
      this.panWeb.Name = "panWeb";
      size = new Size(0x298, 360);
      this.panWeb.Size = size;
      this.panWeb.TabIndex = 0x7a;
      this.panRating.Controls.Add(this.Panel11);
      point = new Point(0xa8, 0x30);
      this.panRating.Location = point;
      this.panRating.Name = "panRating";
      size = new Size(0x298, 0x1b0);
      this.panRating.Size = size;
      this.panRating.TabIndex = 0x7b;
      this.panUser.Controls.Add(this.Panel13);
      this.panUser.Controls.Add(this.Panel12);
      point = new Point(0xa8, 0x38);
      this.panUser.Location = point;
      this.panUser.Name = "panUser";
      size = new Size(0x298, 0x1a0);
      this.panUser.Size = size;
      this.panUser.TabIndex = 0x7c;
      this.panNot.Controls.Add(this.lblNot);
      this.panNot.Controls.Add(this.NotSupportList);
      point = new Point(0xa8, 0x30);
      this.panNot.Location = point;
      this.panNot.Name = "panNot";
      size = new Size(0x298, 440);
      this.panNot.Size = size;
      this.panNot.TabIndex = 0x7d;
      this.ButtomPanel.AntiAlias = true;
      this.ButtomPanel.Controls.Add(this.btnOK);
      this.ButtomPanel.Controls.Add(this.btnCancel);
      this.ButtomPanel.Controls.Add(this.lblDigits);
      this.ButtomPanel.Controls.Add(this.txtDigits);
      this.ButtomPanel.Dock = DockStyle.Bottom;
      point = new Point(0xa8, 0x1f8);
      this.ButtomPanel.Location = point;
      this.ButtomPanel.Name = "ButtomPanel";
      size = new Size(0x29a, 40);
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
      this.ButtomPanel.TabIndex = 100;
      this.AcceptButton = this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = this.btnCancel;
      size = new Size(0x342, 0x220);
      this.ClientSize = size;
      this.ControlBox = false;
      this.Controls.Add(this.panMain);
      this.Controls.Add(this.panLyrics);
      this.Controls.Add(this.panPic);
      this.Controls.Add(this.panNot);
      this.Controls.Add(this.panUser);
      this.Controls.Add(this.panInvolved);
      this.Controls.Add(this.panDetail);
      this.Controls.Add(this.panRating);
      this.Controls.Add(this.panWeb);
      this.Controls.Add(this.panOriginal);
      this.Controls.Add(this.TopPanel);
      this.Controls.Add(this.ButtomPanel);
      this.Controls.Add(this.SelectionBar);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG2";
      this.ShowInTaskbar = false;
      this.Text = "Edit TAG Ver. 2";
      this.Panel3.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel9.ResumeLayout(false);
      this.Panel6.ResumeLayout(false);
      this.Panel5.ResumeLayout(false);
      this.Panel4.ResumeLayout(false);
      this.Panel15.ResumeLayout(false);
      this.Panel16.ResumeLayout(false);
      this.Panel14.ResumeLayout(false);
      this.Panel7.ResumeLayout(false);
      this.Panel8.ResumeLayout(false);
      this.Panel11.ResumeLayout(false);
      this.txtRatingCounter.EndInit();
      this.txtRatingRating.EndInit();
      this.Panel10.ResumeLayout(false);
      this.Panel13.ResumeLayout(false);
      this.Panel12.ResumeLayout(false);
      this.txtDigits.EndInit();
      ((ISupportInitialize)this.SelectionBar).EndInit();
      this.TopPanel.ResumeLayout(false);
      this.panDetail.ResumeLayout(false);
      this.panMain.ResumeLayout(false);
      this.panOriginal.ResumeLayout(false);
      this.panInvolved.ResumeLayout(false);
      this.panPic.ResumeLayout(false);
      this.panLyrics.ResumeLayout(false);
      this.panWeb.ResumeLayout(false);
      this.panRating.ResumeLayout(false);
      this.panUser.ResumeLayout(false);
      this.panNot.ResumeLayout(false);
      this.ButtomPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void LyricsList_Click(object sender, EventArgs e)
    {
      this.txtLDescriptor.Text = this.LyricsList.FocusedItem.Text;
      using (IEnumerator enumerator = this.cmbLLanguage.Items.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          string str = StringType.FromObject(enumerator.Current);
          if (str.StartsWith(this.LyricsList.FocusedItem.SubItems[2].Text))
          {
            this.cmbLLanguage.SelectedItem = str;
            goto Label_0089;
          }
        }
      }
      Label_0089:
      this.txtLyrics.Text = this.LyricsList.FocusedItem.SubItems[1].Text.Replace("\n", "\r\n");
    }

    private void PicList_Click(object sender, EventArgs e)
    {
      V2APICFrame tag = (V2APICFrame)this.PicList.FocusedItem.Tag;
      this.txtPDescriptor.Text = this.PicList.FocusedItem.Text;
      this.cmbPicType.SelectedIndex = (int)Math.Round(Conversion.Val(this.PicList.FocusedItem.SubItems[1].Text.Substring(0, 2)));
      this.txtPicPath.Text = this.PicList.FocusedItem.SubItems[2].Text;
      this.chkPicInclude.Checked = Convert.ToBoolean(this.PicList.FocusedItem.SubItems[3].Text);
      this.chkPicRelativPath.Checked = (this.PicList.FocusedItem.Font.Style & FontStyle.Bold) == FontStyle.Bold;
      if (StringType.StrCmp(this.PicList.FocusedItem.SubItems[2].Text, this.MP3.FI.FullName, false) == 0)
      {
        this.chkPicInclude.Enabled = false;
        this.chkPicRelativPath.Enabled = false;
      }
      else
      {
        this.chkPicInclude.Enabled = true;
        this.chkPicRelativPath.Enabled = true;
      }
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
      if (StringType.StrCmp(this.txtPicPath.Text, this.MP3.FI.FullName, false) == 0)
      {
        if (StringType.StrCmp(tag.TempPath, "", false) == 0)
        {
          FileStream stream = new FileStream(this.MP3.FI.FullName, FileMode.Open, FileAccess.Read);
          stream.Seek((long)tag.DataStart, SeekOrigin.Begin);
          byte[] array = new byte[(tag.DataLength - 1) + 1];
          stream.Read(array, 0, tag.DataLength);
          this.PicMStream = new MemoryStream(array);
          this.APICView.Image = Image.FromStream(this.PicMStream);
          stream.Close();
        }
        else
        {
          FileStream stream2 = new FileStream(tag.TempPath, FileMode.Open, FileAccess.Read);
          stream2.Seek(0L, SeekOrigin.Begin);
          byte[] buffer2 = new byte[((int)(stream2.Length - 1L)) + 1];
          stream2.Read(buffer2, 0, buffer2.Length);
          this.PicMStream = new MemoryStream(buffer2);
          this.APICView.Image = Image.FromStream(this.PicMStream);
          stream2.Close();
        }
        this.btnAddPicture.Enabled = false;
        this.btnExPic.Enabled = true;
      }
      else
      {
        if (File.Exists(this.txtPicPath.Text))
        {
          FileStream stream3 = new FileStream(this.txtPicPath.Text, FileMode.Open, FileAccess.Read);
          stream3.Seek(0L, SeekOrigin.Begin);
          byte[] buffer3 = new byte[((int)(stream3.Length - 1L)) + 1];
          stream3.Read(buffer3, 0, buffer3.Length);
          this.PicMStream = new MemoryStream(buffer3);
          this.APICView.Image = Image.FromStream(this.PicMStream);
          stream3.Close();
        }
        else
        {
          this.APICView.Image = null;
        }
        this.btnAddPicture.Enabled = true;
        this.btnExPic.Enabled = false;
      }
    }

    private void RatingList_Click(object sender, EventArgs e)
    {
      this.txtRatingUser.Text = this.RatingList.FocusedItem.Text;
      this.txtRatingRating.Value = new decimal(Convert.ToByte(Conversion.Val(this.RatingList.FocusedItem.SubItems[1].Text)));
      this.txtRatingCounter.Value = new decimal(Convert.ToInt32(Conversion.Val(this.RatingList.FocusedItem.SubItems[2].Text)));
    }

    private void SaveToTAG()
    {
      string text;
      ListViewItem item = new ListViewItem();
      ArrayList list = new ArrayList();
      Declarations.UnDoReDo @do = new Declarations.UnDoReDo(this.MP3, this.MP3.V1TAG.Clone(), this.MP3.V2TAG.Clone(), this.MP3.CurrentFullName, this.MP3.Changed);
      list.Add(@do);
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
      o = ID3Functions.CreateTextFrame("TPE2", this.txtBand.Text);
      if (StringType.StrCmp(this.txtBand.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TPE3", this.txtConductor.Text);
      if (StringType.StrCmp(this.txtConductor.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TPE4", this.txtModified.Text);
      if (StringType.StrCmp(this.txtModified.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TIT1", this.txtContent.Text);
      if (StringType.StrCmp(this.txtContent.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TIT3", this.txtSubTitle.Text);
      if (StringType.StrCmp(this.txtSubTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TCOM", this.txtComposer.Text);
      if (StringType.StrCmp(this.txtComposer.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TCOP", this.txtCopyright.Text);
      if (StringType.StrCmp(this.txtCopyright.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      if ((((StringType.StrCmp(this.txtSortAlbum.Text.TrimEnd(new char[] { ' ' }), "", false) != 0) | (StringType.StrCmp(this.txtSortArtist.Text.TrimEnd(new char[] { ' ' }), "", false) != 0)) | (StringType.StrCmp(this.txtSortTitle.Text.TrimEnd(new char[] { ' ' }), "", false) != 0)) & (((this.MP3.V2TAG.TAGVersion == 0) & (Declarations.objSettings.NewV2Version == 4)) | (this.MP3.V2TAG.TAGVersion == 4)))
      {
        o = ID3Functions.CreateTextFrame("TSOA", this.txtSortAlbum.Text);
        if (StringType.StrCmp(this.txtSortAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = ID3Functions.CreateTextFrame("TSOP", this.txtSortArtist.Text);
        if (StringType.StrCmp(this.txtSortArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = ID3Functions.CreateTextFrame("TSOT", this.txtSortTitle.Text);
        if (StringType.StrCmp(this.txtSortTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }
      o = ID3Functions.CreateTextFrame("TEXT", this.txtLyWriter.Text);
      if (StringType.StrCmp(this.txtLyWriter.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TPUB", this.txtPublisher.Text);
      if (StringType.StrCmp(this.txtPublisher.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TENC", this.txtEncoded.Text);
      if (StringType.StrCmp(this.txtEncoded.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOAL", this.txtOAlbum.Text);
      if (StringType.StrCmp(this.txtOAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOFN", this.txtOFilename.Text);
      if (StringType.StrCmp(this.txtOFilename.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOPE", this.txtOArtist.Text);
      if (StringType.StrCmp(this.txtOArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOLY", this.txtOLyWriter.Text);
      if (StringType.StrCmp(this.txtOLyWriter.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOWN", this.txtOOwner.Text);
      if (StringType.StrCmp(this.txtOOwner.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TLEN", this.txtTLEN.Text);
      if (StringType.StrCmp(this.txtTLEN.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WCOM", this.txtCOMMInfURL.Text);
      if (StringType.StrCmp(this.txtCOMMInfURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WCOP", this.txtCopyInfURL.Text);
      if (StringType.StrCmp(this.txtCopyInfURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WOAF", this.txtAudioFileURL.Text);
      if (StringType.StrCmp(this.txtAudioFileURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WOAR", this.txtArtistURL.Text);
      if (StringType.StrCmp(this.txtArtistURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WOAS", this.txtAudioSRCURL.Text);
      if (StringType.StrCmp(this.txtAudioSRCURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WORS", this.txtINetRadioURL.Text);
      if (StringType.StrCmp(this.txtINetRadioURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WPAY", this.txtPayURL.Text);
      if (StringType.StrCmp(this.txtPayURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WPUB", this.txtPubURL.Text);
      if (StringType.StrCmp(this.txtPubURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      if (this.TIPLList.Items.Count > 0)
      {
        if (!this.MP3.V2TAG.TAGHeaderPresent)
        {
          this.MP3.V2TAG.TAGHeaderPresent = true;
        }
        string vstrContent = "";
        foreach (ListViewItem item in this.TIPLList.Items)
        {
          vstrContent = vstrContent + item.Text + "\0" + item.SubItems[1].Text + "\0";
        }
        vstrContent = vstrContent.TrimEnd(new char[] { '\0' });
        if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
        {
          o = ID3Functions.CreateTextFrame("IPLS", vstrContent);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TIPL", vstrContent);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
      }
      else if (this.MP3.V2TAG.TAGHeaderPresent)
      {
        if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
        {
          o = ID3Functions.CreateTextFrame("IPLS", "");
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TIPL", "");
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
      }
      if (this.TMCLList.Items.Count > 0)
      {
        if (!this.MP3.V2TAG.TAGHeaderPresent)
        {
          this.MP3.V2TAG.TAGHeaderPresent = true;
        }
        string str4 = "";
        foreach (ListViewItem item in this.TMCLList.Items)
        {
          str4 = str4 + item.Text + "\0" + item.SubItems[1].Text + "\0";
        }
        str4 = str4.TrimEnd(new char[] { '\0' });
        if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("4"))
        {
          o = ID3Functions.CreateTextFrame("TMCL", str4);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
      }
      else if (this.MP3.V2TAG.TAGHeaderPresent && (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("4")))
      {
        o = ID3Functions.CreateTextFrame("TMCL", "");
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }
      if (StringType.StrCmp(this.txtYear.Text, "", false) != 0)
      {
        if (!this.MP3.V2TAG.TAGHeaderPresent)
        {
          this.MP3.V2TAG.TAGHeaderPresent = true;
        }
        if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
        {
          switch (this.YearFormat.Value)
          {
            case 0:
              o = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text);
              this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
              o = ID3Functions.CreateTextFrame("TDAT", "0000");
              LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
              this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
              break;

            case 1:
              o = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text.Substring(0, 4));
              this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
              o = ID3Functions.CreateTextFrame("TDAT", "01" + this.txtYear.Text.Substring(5, 2).PadLeft(2, '0'));
              this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
              break;

            case 2:
              o = ID3Functions.CreateTextFrame("TYER", this.txtYear.Text.Substring(0, 4));
              this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
              o = ID3Functions.CreateTextFrame("TDAT", this.txtYear.Text.Substring(8, 2).PadLeft(2, '0') + this.txtYear.Text.Substring(5, 2).PadLeft(2, '0'));
              this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
              break;
          }
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TDRC", this.txtYear.Text);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
      }
      else if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
      {
        o = ID3Functions.CreateTextFrame("TYER", "0000");
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = ID3Functions.CreateTextFrame("TDAT", "0000");
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }
      else
      {
        o = ID3Functions.CreateTextFrame("TDRC", "0000");
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }
      if (StringType.StrCmp(this.txtTORY.Text, "", false) != 0)
      {
        if (!this.MP3.V2TAG.TAGHeaderPresent)
        {
          this.MP3.V2TAG.TAGHeaderPresent = true;
        }
        if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
        {
          o = ID3Functions.CreateTextFrame("TORY", this.txtTORY.Text.PadLeft(4, '0').Substring(0, 4));
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TDOR", this.txtTORY.Text);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
      }
      else if (this.MP3.V2TAG.TAGVersion == DoubleType.FromString("3"))
      {
        o = ID3Functions.CreateTextFrame("TORY", "0000");
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }
      else
      {
        o = ID3Functions.CreateTextFrame("TDOR", "0000");
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }
      o = ID3Functions.CreateTextFrame("TMED", this.cmbMedia.Text);
      if (StringType.StrCmp(this.cmbMedia.Text.Trim(new char[] { ' ' }), "", false) == 0)
      {
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      if (StringType.StrCmp(this.txtTrack1.Text, "", false) != 0)
      {
        if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
        {
          o = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtTrack2.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
        }
      }
      else if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
      {
        o = ID3Functions.CreateTextFrame("TRCK", "/" + this.txtTrack2.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
      }
      else
      {
        o = ID3Functions.CreateTextFrame("TRCK", "0".PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      if (StringType.StrCmp(this.txtPOS1.Text, "", false) != 0)
      {
        if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
        {
          o = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtPOS2.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
        }
        else
        {
          o = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
        }
      }
      else if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
      {
        o = ID3Functions.CreateTextFrame("TPOS", "/" + this.txtPOS2.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
      }
      else
      {
        o = ID3Functions.CreateTextFrame("TPOS", "0".PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      if (StringType.StrCmp(this.txtBPM.Text, "", false) == 0)
      {
        o = ID3Functions.CreateTextFrame("TBPM", this.txtBPM.Text);
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }
      else
      {
        o = ID3Functions.CreateTextFrame("TBPM", this.txtBPM.Text);
      }
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      using (IEnumerator enumerator18 = this.alstRemovedTXXXFrames.GetEnumerator())
      {
        while (enumerator18.MoveNext())
        {
          o = RuntimeHelpers.GetObjectValue(enumerator18.Current);
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
      }
      foreach (ListViewItem item in this.TXXXList.Items)
      {
        if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Descriptor", new object[0], null, null), item.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Content", new object[0], null, null), item.SubItems[1].Text, false) != 0)))
        {
          LateBinding.LateSetComplex(item.Tag, null, "Descriptor", new object[] { item.Text }, null, false, true);
          LateBinding.LateSetComplex(item.Tag, null, "Content", new object[] { item.SubItems[1].Text }, null, false, true);
          this.MP3.V2TAG.Changed = true;
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(item.Tag));
      }
      using (IEnumerator enumerator16 = this.alstRemovedWXXXFrames.GetEnumerator())
      {
        while (enumerator16.MoveNext())
        {
          o = RuntimeHelpers.GetObjectValue(enumerator16.Current);
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
      }
      foreach (ListViewItem item in this.WXXXList.Items)
      {
        if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Descriptor", new object[0], null, null), item.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Content", new object[0], null, null), item.SubItems[1].Text, false) != 0)))
        {
          LateBinding.LateSetComplex(item.Tag, null, "Descriptor", new object[] { item.Text }, null, false, true);
          LateBinding.LateSetComplex(item.Tag, null, "Content", new object[] { item.SubItems[1].Text }, null, false, true);
          this.MP3.V2TAG.Changed = true;
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(item.Tag));
      }
      if (!Declarations.objSettings.SingleGC)
      {
        text = "";
        using (IEnumerator enumerator14 = this.GenreList.Items.GetEnumerator())
        {
          while (enumerator14.MoveNext())
          {
            string str2 = StringType.FromObject(enumerator14.Current);
            text = text + str2 + "\0";
          }
        }
        if (text.EndsWith("\0"))
        {
          text = text.Substring(0, text.Length - 1);
        }
        o = ID3Functions.CreateTextFrame("TCON", text);
        if (StringType.StrCmp(text, "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }
      else
      {
        text = this.cmbGenre.Text;
        o = ID3Functions.CreateTextFrame("TCON", text);
        if (StringType.StrCmp(text, "", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }
      if (this.vbooLyricsMoved)
      {
        ArrayList alstFrames = new ArrayList();
        foreach (ListViewItem item2 in this.LyricsList.Items)
        {
          alstFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(item2.Tag, null, "Clone", new object[0], null, null)));
        }
        this.MP3.V2TAG.RemoveFrames("USLT");
        this.MP3.V2TAG.AddFrames(alstFrames);
      }
      if (this.vbooRatingMoved)
      {
        ArrayList list3 = new ArrayList();
        foreach (ListViewItem item3 in this.RatingList.Items)
        {
          list3.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(item3.Tag, null, "Clone", new object[0], null, null)));
        }
        this.MP3.V2TAG.RemoveFrames("POPM");
        this.MP3.V2TAG.AddFrames(list3);
      }
      using (IEnumerator enumerator11 = this.alstRemovedLDCFrames.GetEnumerator())
      {
        while (enumerator11.MoveNext())
        {
          o = RuntimeHelpers.GetObjectValue(enumerator11.Current);
          if (ObjectType.ObjTst(LateBinding.LateGet(o, null, "FID", new object[0], null, null), "USLT", false) == 0)
          {
            LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
            this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
          }
        }
      }
      foreach (ListViewItem item in this.LyricsList.Items)
      {
        if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Descriptor", new object[0], null, null), item.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Content", new object[0], null, null), item.SubItems[1].Text, false) != 0)))
        {
          LateBinding.LateSetComplex(item.Tag, null, "Descriptor", new object[] { item.Text }, null, false, true);
          LateBinding.LateSetComplex(item.Tag, null, "Content", new object[] { item.SubItems[1].Text }, null, false, true);
          this.MP3.V2TAG.Changed = true;
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(item.Tag));
      }
      using (IEnumerator enumerator9 = this.alstRemovedPOPMFrames.GetEnumerator())
      {
        while (enumerator9.MoveNext())
        {
          o = RuntimeHelpers.GetObjectValue(enumerator9.Current);
          if (ObjectType.ObjTst(LateBinding.LateGet(o, null, "FID", new object[0], null, null), "POPM", false) == 0)
          {
            LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
            this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
          }
        }
      }
      foreach (ListViewItem item in this.RatingList.Items)
      {
        if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "User", new object[0], null, null), item.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Rating", new object[0], null, null), Convert.ToByte(item.SubItems[1].Text), false) != 0), ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Counter", new object[0], null, null), Convert.ToInt32(item.SubItems[2].Text), false) != 0)))
        {
          LateBinding.LateSetComplex(item.Tag, null, "User", new object[] { item.Text }, null, false, true);
          LateBinding.LateSetComplex(item.Tag, null, "Rating", new object[] { Convert.ToByte(item.SubItems[1].Text) }, null, false, true);
          LateBinding.LateSetComplex(item.Tag, null, "Counter", new object[] { Convert.ToInt32(item.SubItems[2].Text) }, null, false, true);
          this.MP3.V2TAG.Changed = true;
        }
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(item.Tag));
      }
      using (IEnumerator enumerator7 = this.alstRemovedAPICFrames.GetEnumerator())
      {
        while (enumerator7.MoveNext())
        {
          o = RuntimeHelpers.GetObjectValue(enumerator7.Current);
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        }
      }
      foreach (ListViewItem item in this.PicList.Items)
      {
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(item.Tag));
      }
      if (!Declarations.objSettings.SingleGC)
      {
        if (this.vbooCommentMoved)
        {
          ArrayList list4 = new ArrayList();
          foreach (ListViewItem item4 in this.CommentList.Items)
          {
            list4.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(item4.Tag, null, "Clone", new object[0], null, null)));
          }
          this.MP3.V2TAG.RemoveFrames("COMM");
          this.MP3.V2TAG.AddFrames(list4);
        }
        using (IEnumerator enumerator4 = this.alstRemovedLDCFrames.GetEnumerator())
        {
          while (enumerator4.MoveNext())
          {
            o = RuntimeHelpers.GetObjectValue(enumerator4.Current);
            if (ObjectType.ObjTst(LateBinding.LateGet(o, null, "FID", new object[0], null, null), "COMM", false) == 0)
            {
              LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
              this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
            }
          }
        }
        foreach (ListViewItem item in this.CommentList.Items)
        {
          if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Descriptor", new object[0], null, null), item.Text, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(item.Tag, null, "Content", new object[0], null, null), item.SubItems[1].Text, false) != 0)))
          {
            LateBinding.LateSetComplex(item.Tag, null, "Descriptor", new object[] { item.Text }, null, false, true);
            LateBinding.LateSetComplex(item.Tag, null, "Content", new object[] { item.SubItems[1].Text }, null, false, true);
            this.MP3.V2TAG.Changed = true;
          }
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(item.Tag));
        }
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (this.CommentList.Items.Count > 0)
          {
            if (ObjectType.ObjTst(this.MP3.V1TAG.Comment, LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Content", new object[0], null, null), false) != 0)
            {
              this.MP3.V1TAG.Comment = StringType.FromObject(LateBinding.LateGet(this.CommentList.Items[0].Tag, null, "Content", new object[0], null, null));
              this.MP3.V1TAG.TAGPresent = true;
              this.MP3.Changed = true;
            }
          }
          else
          {
            if (StringType.StrCmp(this.MP3.V1TAG.Comment, "", false) != 0)
            {
              this.MP3.V1TAG.TAGPresent = true;
              this.MP3.Changed = true;
            }
            this.MP3.V1TAG.Comment = "";
          }
        }
      }
      else
      {
        if (StringType.StrCmp(this.txtComment.Text, "", false) != 0)
        {
          V2LDCFrame frame = new V2LDCFrame
          {
            FID = "COMM",
            Descriptor = this.cmbCDescriptor.Text,
            Content = this.txtComment.Text.Replace("\r\n", "\n"),
            Language = this.cmbCLanguage.Text.Substring(0, 3)
          };
          if (this.MP3.V2TAG.GetFrames("COMM").Count > 1)
          {
            this.MP3.V2TAG.RemoveFrames("COMM");
            this.MP3.V2TAG.AddFrame(frame);
          }
          else
          {
            this.MP3.V2TAG.AddFrame(frame);
          }
        }
        else if (this.MP3.V2TAG.FrameExists("COMM"))
        {
          this.MP3.V2TAG.RemoveFrames("COMM");
          this.MP3.V2TAG.Changed = true;
        }
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (StringType.StrCmp(this.txtComment.Text, "", false) != 0)
          {
            if (StringType.StrCmp(this.MP3.V1TAG.Comment, this.txtComment.Text, false) != 0)
            {
              this.MP3.V1TAG.Comment = this.txtComment.Text;
              this.MP3.V1TAG.TAGPresent = true;
              this.MP3.Changed = true;
            }
          }
          else
          {
            if (StringType.StrCmp(this.MP3.V1TAG.Comment, "", false) != 0)
            {
              this.MP3.V1TAG.TAGPresent = true;
              this.MP3.Changed = true;
            }
            this.MP3.V1TAG.Comment = "";
          }
        }
      }
      foreach (ListViewItem item in this.NotSupportList.Items)
      {
        if (!item.Checked)
        {
          this.MP3.V2TAG.RemoveFrameExact(RuntimeHelpers.GetObjectValue(item.Tag));
        }
      }
      if (this.MP3.V2TAG.Changed)
      {
        if (!this.MP3.V2TAG.TAGHeaderPresent)
        {
          this.MP3.V2TAG.TAGHeaderPresent = true;
        }
        this.MP3.Changed = true;
        Declarations.UNDOList.Add(list);
        this.MainForm.UnDoEnable(true, true);
        this.MainForm.UpdateListItem(this.MainForm.MP3View.FocusedItem, false);
      }
      this.vbooCommentMoved = false;
      this.vbooLyricsMoved = false;
      this.vbooRatingMoved = false;
      if (Declarations.objSettings.SynchronizeTAGs)
      {
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
        if (StringType.StrCmp(this.txtYear.Text, "", false) != 0)
        {
          if (StringType.StrCmp(this.MP3.V1TAG.Year.ToString(), this.txtYear.Text.Substring(0, 4), false) != 0)
          {
            this.MP3.V1TAG.Year = (int)Math.Round(Conversion.Val(this.txtYear.Text.Substring(0, 4)));
            this.MP3.V1TAG.TAGPresent = true;
            this.MP3.Changed = true;
          }
        }
        else if (this.MP3.V1TAG.Year != 0)
        {
          this.MP3.V1TAG.Year = 0;
          this.MP3.V1TAG.TAGPresent = true;
          this.MP3.Changed = true;
        }
        if ((Conversion.Val(this.txtTrack1.Text) <= 255.0) && (this.MP3.V1TAG.Tracknumber != Conversion.Val(this.txtTrack1.Text)))
        {
          this.MP3.V1TAG.Tracknumber = (byte)Math.Round(Conversion.Val(this.txtTrack1.Text));
          this.MP3.V1TAG.TAGPresent = true;
          this.MP3.Changed = true;
        }
        if (!this.MP3.V2TAG.FrameExists("TCON"))
        {
          if (this.MP3.V1TAG.GenreByte != 0xff)
          {
            this.MP3.Changed = true;
          }
          this.MP3.V1TAG.GenreByte = 0xff;
        }
        else
        {
          string sRight = StringType.FromObject(LateBinding.LateGet(this.MP3.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null));
          bool flag = false;
          if (sRight.IndexOf('\0') > 0)
          {
            sRight = sRight.Substring(0, sRight.IndexOf('\0'));
          }
          foreach (DataRow row in Declarations.objSettings.Genres.Rows)
          {
            if (StringType.StrCmp(row["Name"].ToString().ToLower(), sRight.ToLower(), false) == 0)
            {
              if (ObjectType.ObjTst(this.MP3.V1TAG.GenreByte, row["V2V1"], false) != 0)
              {
                this.MP3.V1TAG.GenreByte = ByteType.FromObject(row["V2V1"]);
                flag = true;
                this.MP3.Changed = true;
              }
              break;
            }
          }
          if (!flag & (StringType.StrCmp(this.MP3.V1TAG.GenreText, sRight, false) != 0))
          {
            this.MP3.V1TAG.GenreText = sRight;
            this.MP3.Changed = true;
          }
        }
        this.MainForm.UpdateListItem(this.MainForm.MP3View.FocusedItem, false);
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
      AMS.TextBox.MaskedTextBox txtYear;
      this.FocusControl = (Control)sender;
      if (((sender == this.txtRatingCounter) | (sender == this.txtRatingRating)) && (ObjectType.ObjTst(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), "", false) == 0))
      {
        LateBinding.LateSet(sender, null, "Text", new object[] { "0" }, null);
      }
      if (sender == this.txtYear)
      {
        switch (this.YearFormat.Value)
        {
          case 0:
            this.txtYear.Mask = "####";
            break;

          case 1:
            this.txtYear.Mask = "####-##";
            if (this.txtYear.Text.Length < 7)
            {
              string str = DateTime.Now.Year.ToString() + "-01";
              txtYear = this.txtYear;
              txtYear.Text = txtYear.Text + str.Substring(this.txtYear.Text.Length);
            }
            if ((Conversion.Val(this.txtYear.Text.Substring(5, 2)) > 12.0) | (Conversion.Val(this.txtYear.Text.Substring(5, 2)) < 1.0))
            {
              this.txtYear.Text = this.txtYear.Text.Substring(0, 4) + "-01";
            }
            break;

          case 2:
            this.txtYear.Mask = "####-##-##";
            if (this.txtYear.Text.Length < 10)
            {
              string str2 = DateTime.Now.Year.ToString() + "-01-01";
              txtYear = this.txtYear;
              txtYear.Text = txtYear.Text + str2.Substring(this.txtYear.Text.Length);
            }
            if ((Conversion.Val(this.txtYear.Text.Substring(5, 2)) > 12.0) | (Conversion.Val(this.txtYear.Text.Substring(5, 2)) < 1.0))
            {
              this.txtYear.Text = this.txtYear.Text.Substring(0, 4) + "-01" + this.txtYear.Text.Substring(7);
            }
            if ((Conversion.Val(this.txtYear.Text.Substring(8, 2)) > 31.0) | (Conversion.Val(this.txtYear.Text.Substring(8, 2)) < 1.0))
            {
              this.txtYear.Text = this.txtYear.Text.Substring(0, 7) + "-01";
            }
            break;
        }
        this.txtYear.Text.TrimStart(new char[] { '0' });
        if (this.txtYear.Text.Length < 4)
        {
          this.txtYear.Text = this.txtYear.Text.PadLeft(4, '0');
        }
        if (Conversion.Val(this.txtYear.Text.Substring(0, 4)) <= 0.0)
        {
          this.txtYear.Text = "";
        }
      }
      if (sender == this.txtTORY)
      {
        switch (this.TORYFormat.Value)
        {
          case 0:
            this.txtTORY.Mask = "####";
            if (this.txtTORY.Text.Length < 4)
            {
              this.txtTORY.Text = this.txtTORY.Text.PadRight(4, '0');
            }
            break;

          case 1:
            this.txtTORY.Mask = "####-##";
            if (this.txtTORY.Text.Length < 7)
            {
              string str3 = DateTime.Now.Year.ToString() + "-01";
              txtYear = this.txtTORY;
              txtYear.Text = txtYear.Text + str3.Substring(this.txtTORY.Text.Length);
            }
            if ((Conversion.Val(this.txtTORY.Text.Substring(5, 2)) > 12.0) | (Conversion.Val(this.txtTORY.Text.Substring(5, 2)) < 1.0))
            {
              this.txtTORY.Text = this.txtTORY.Text.Substring(0, 4) + "-01";
            }
            break;

          case 2:
            this.txtTORY.Mask = "####-##-##";
            if (this.txtTORY.Text.Length < 10)
            {
              string str4 = DateTime.Now.Year.ToString() + "-01-01";
              txtYear = this.txtTORY;
              txtYear.Text = txtYear.Text + str4.Substring(this.txtTORY.Text.Length);
            }
            if ((Conversion.Val(this.txtTORY.Text.Substring(5, 2)) > 12.0) | (Conversion.Val(this.txtTORY.Text.Substring(5, 2)) < 1.0))
            {
              this.txtTORY.Text = this.txtTORY.Text.Substring(0, 4) + "-01" + this.txtTORY.Text.Substring(7);
            }
            if ((Conversion.Val(this.txtTORY.Text.Substring(8, 2)) > 31.0) | (Conversion.Val(this.txtTORY.Text.Substring(8, 2)) < 1.0))
            {
              this.txtTORY.Text = this.txtTORY.Text.Substring(0, 7) + "-01";
            }
            break;
        }
        this.txtTORY.Text.TrimStart(new char[] { '0' });
        if (this.txtTORY.Text.Length < 4)
        {
          this.txtTORY.Text = this.txtTORY.Text.PadLeft(4, '0');
        }
        if (Conversion.Val(this.txtTORY.Text.Substring(0, 4)) <= 0.0)
        {
          this.txtTORY.Text = "";
        }
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
      AMS.TextBox.MaskedTextBox txtTORY;
      switch (this.TORYFormat.Value)
      {
        case 0:
          this.txtTORY.Mask = "####";
          break;

        case 1:
          this.txtTORY.Mask = "####-##";
          if (this.txtTORY.Text.Length < 7)
          {
            string str = DateTime.Now.Year.ToString() + "-01";
            txtTORY = this.txtTORY;
            txtTORY.Text = txtTORY.Text + str.Substring(this.txtTORY.Text.Length);
          }
          break;

        case 2:
          this.txtTORY.Mask = "####-##-##";
          if (this.txtTORY.Text.Length < 10)
          {
            string str2 = DateTime.Now.Year.ToString() + "-01-01";
            txtTORY = this.txtTORY;
            txtTORY.Text = txtTORY.Text + str2.Substring(this.txtTORY.Text.Length);
          }
          break;
      }
    }

    private void TXXXList_Click(object sender, EventArgs e)
    {
      this.txtTXXXDesc.Text = this.TXXXList.FocusedItem.Text;
      this.txtTXXXContent.Text = this.TXXXList.FocusedItem.SubItems[1].Text;
    }

    private void WXXXList_Click(object sender, EventArgs e)
    {
      this.txtWXXXDesc.Text = this.WXXXList.FocusedItem.Text;
      this.txtWXXXContent.Text = this.WXXXList.FocusedItem.SubItems[1].Text;
    }

    private void YearFormat_Scroll(object sender, ScrollEventArgs e)
    {
      AMS.TextBox.MaskedTextBox txtYear;
      switch (this.YearFormat.Value)
      {
        case 0:
          this.txtYear.Mask = "####";
          break;

        case 1:
          this.txtYear.Mask = "####-##";
          if (this.txtYear.Text.Length < 7)
          {
            string str = DateTime.Now.Year.ToString() + "-01";
            txtYear = this.txtYear;
            txtYear.Text = txtYear.Text + str.Substring(this.txtYear.Text.Length);
          }
          break;

        case 2:
          this.txtYear.Mask = "####-##-##";
          if (this.txtYear.Text.Length < 10)
          {
            string str2 = DateTime.Now.Year.ToString() + "-01-01";
            txtYear = this.txtYear;
            txtYear.Text = txtYear.Text + str2.Substring(this.txtYear.Text.Length);
          }
          break;
      }
    }

    internal virtual PictureBox APICView
    {
      get
      {
        return this._APICView;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._APICView != null)
        {
        }
        this._APICView = value;
        if (this._APICView != null)
        {
        }
      }
    }

    internal virtual Button btnAddComment
    {
      get
      {
        return this._btnAddComment;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddComment != null)
        {
          this._btnAddComment.Click -= new EventHandler(this.btnAddComment_Click);
        }
        this._btnAddComment = value;
        if (this._btnAddComment != null)
        {
          this._btnAddComment.Click += new EventHandler(this.btnAddComment_Click);
        }
      }
    }

    internal virtual Button btnAddGenre
    {
      get
      {
        return this._btnAddGenre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddGenre != null)
        {
          this._btnAddGenre.Click -= new EventHandler(this.btnAddGenre_Click);
        }
        this._btnAddGenre = value;
        if (this._btnAddGenre != null)
        {
          this._btnAddGenre.Click += new EventHandler(this.btnAddGenre_Click);
        }
      }
    }

    internal virtual Button btnAddInv
    {
      get
      {
        return this._btnAddInv;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddInv != null)
        {
          this._btnAddInv.Click -= new EventHandler(this.btnAddInv_Click);
        }
        this._btnAddInv = value;
        if (this._btnAddInv != null)
        {
          this._btnAddInv.Click += new EventHandler(this.btnAddInv_Click);
        }
      }
    }

    internal virtual Button btnAddLyrics
    {
      get
      {
        return this._btnAddLyrics;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddLyrics != null)
        {
          this._btnAddLyrics.Click -= new EventHandler(this.btnAddLyrics_Click);
        }
        this._btnAddLyrics = value;
        if (this._btnAddLyrics != null)
        {
          this._btnAddLyrics.Click += new EventHandler(this.btnAddLyrics_Click);
        }
      }
    }

    internal virtual Button btnAddMusician
    {
      get
      {
        return this._btnAddMusician;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddMusician != null)
        {
          this._btnAddMusician.Click -= new EventHandler(this.btnAddMusican_Click);
        }
        this._btnAddMusician = value;
        if (this._btnAddMusician != null)
        {
          this._btnAddMusician.Click += new EventHandler(this.btnAddMusican_Click);
        }
      }
    }

    internal virtual Button btnAddPicture
    {
      get
      {
        return this._btnAddPicture;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddPicture != null)
        {
          this._btnAddPicture.Click -= new EventHandler(this.btnAddPicture_Click);
        }
        this._btnAddPicture = value;
        if (this._btnAddPicture != null)
        {
          this._btnAddPicture.Click += new EventHandler(this.btnAddPicture_Click);
        }
      }
    }

    internal virtual Button btnAddRating
    {
      get
      {
        return this._btnAddRating;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddRating != null)
        {
          this._btnAddRating.Click -= new EventHandler(this.btnAddRating_Click);
        }
        this._btnAddRating = value;
        if (this._btnAddRating != null)
        {
          this._btnAddRating.Click += new EventHandler(this.btnAddRating_Click);
        }
      }
    }

    internal virtual Button btnAddTXXX
    {
      get
      {
        return this._btnAddTXXX;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddTXXX != null)
        {
          this._btnAddTXXX.Click -= new EventHandler(this.btnAddTXXX_Click);
        }
        this._btnAddTXXX = value;
        if (this._btnAddTXXX != null)
        {
          this._btnAddTXXX.Click += new EventHandler(this.btnAddTXXX_Click);
        }
      }
    }

    internal virtual Button btnAddWXXX
    {
      get
      {
        return this._btnAddWXXX;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddWXXX != null)
        {
          this._btnAddWXXX.Click -= new EventHandler(this.btnAddWXXX_Click);
        }
        this._btnAddWXXX = value;
        if (this._btnAddWXXX != null)
        {
          this._btnAddWXXX.Click += new EventHandler(this.btnAddWXXX_Click);
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
          this._btnCancel.Click -= new EventHandler(this.btnCancel_Click);
        }
        this._btnCancel = value;
        if (this._btnCancel != null)
        {
          this._btnCancel.Click += new EventHandler(this.btnCancel_Click);
        }
      }
    }

    internal virtual Button btnExPic
    {
      get
      {
        return this._btnExPic;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnExPic != null)
        {
          this._btnExPic.Click -= new EventHandler(this.btnExPic_Click);
        }
        this._btnExPic = value;
        if (this._btnExPic != null)
        {
          this._btnExPic.Click += new EventHandler(this.btnExPic_Click);
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
          this._btnExport.Click -= new EventHandler(this.btnExport_Click);
        }
        this._btnExport = value;
        if (this._btnExport != null)
        {
          this._btnExport.Click += new EventHandler(this.btnExport_Click);
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
          this._btnGet.Click -= new EventHandler(this.btnGet_Click);
        }
        this._btnGet = value;
        if (this._btnGet != null)
        {
          this._btnGet.Click += new EventHandler(this.btnGet_Click);
        }
      }
    }

    internal virtual Button btnGetPic
    {
      get
      {
        return this._btnGetPic;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnGetPic != null)
        {
          this._btnGetPic.Click -= new EventHandler(this.btnGetPic_Click);
        }
        this._btnGetPic = value;
        if (this._btnGetPic != null)
        {
          this._btnGetPic.Click += new EventHandler(this.btnGetPic_Click);
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
          this._btnImport.Click -= new EventHandler(this.btnImport_Click);
        }
        this._btnImport = value;
        if (this._btnImport != null)
        {
          this._btnImport.Click += new EventHandler(this.btnImport_Click);
        }
      }
    }

    internal virtual Button btnLyricsFile
    {
      get
      {
        return this._btnLyricsFile;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnLyricsFile != null)
        {
          this._btnLyricsFile.Click -= new EventHandler(this.btnLyricsFile_Click);
        }
        this._btnLyricsFile = value;
        if (this._btnLyricsFile != null)
        {
          this._btnLyricsFile.Click += new EventHandler(this.btnLyricsFile_Click);
        }
      }
    }

    internal virtual Button btnMoveComment
    {
      get
      {
        return this._btnMoveComment;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnMoveComment != null)
        {
          this._btnMoveComment.Click -= new EventHandler(this.btnMoveComment_Click);
        }
        this._btnMoveComment = value;
        if (this._btnMoveComment != null)
        {
          this._btnMoveComment.Click += new EventHandler(this.btnMoveComment_Click);
        }
      }
    }

    internal virtual Button btnMoveGenre
    {
      get
      {
        return this._btnMoveGenre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnMoveGenre != null)
        {
          this._btnMoveGenre.Click -= new EventHandler(this.btnMoveGenre_Click);
        }
        this._btnMoveGenre = value;
        if (this._btnMoveGenre != null)
        {
          this._btnMoveGenre.Click += new EventHandler(this.btnMoveGenre_Click);
        }
      }
    }

    internal virtual Button btnMoveLyrics
    {
      get
      {
        return this._btnMoveLyrics;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnMoveLyrics != null)
        {
          this._btnMoveLyrics.Click -= new EventHandler(this.btnMoveLyrics_Click);
        }
        this._btnMoveLyrics = value;
        if (this._btnMoveLyrics != null)
        {
          this._btnMoveLyrics.Click += new EventHandler(this.btnMoveLyrics_Click);
        }
      }
    }

    internal virtual Button btnMoveRating
    {
      get
      {
        return this._btnMoveRating;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnMoveRating != null)
        {
          this._btnMoveRating.Click -= new EventHandler(this.btnMoveRating_Click);
        }
        this._btnMoveRating = value;
        if (this._btnMoveRating != null)
        {
          this._btnMoveRating.Click += new EventHandler(this.btnMoveRating_Click);
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

    internal virtual Button btnRemoveComment
    {
      get
      {
        return this._btnRemoveComment;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveComment != null)
        {
          this._btnRemoveComment.Click -= new EventHandler(this.btnRemoveComment_Click);
        }
        this._btnRemoveComment = value;
        if (this._btnRemoveComment != null)
        {
          this._btnRemoveComment.Click += new EventHandler(this.btnRemoveComment_Click);
        }
      }
    }

    internal virtual Button btnRemoveGenre
    {
      get
      {
        return this._btnRemoveGenre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveGenre != null)
        {
          this._btnRemoveGenre.Click -= new EventHandler(this.btnRemoveGenre_Click);
        }
        this._btnRemoveGenre = value;
        if (this._btnRemoveGenre != null)
        {
          this._btnRemoveGenre.Click += new EventHandler(this.btnRemoveGenre_Click);
        }
      }
    }

    internal virtual Button btnRemoveInv
    {
      get
      {
        return this._btnRemoveInv;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveInv != null)
        {
          this._btnRemoveInv.Click -= new EventHandler(this.btnRemoveInv_Click);
        }
        this._btnRemoveInv = value;
        if (this._btnRemoveInv != null)
        {
          this._btnRemoveInv.Click += new EventHandler(this.btnRemoveInv_Click);
        }
      }
    }

    internal virtual Button btnRemoveLyrics
    {
      get
      {
        return this._btnRemoveLyrics;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveLyrics != null)
        {
          this._btnRemoveLyrics.Click -= new EventHandler(this.btnRemoveLyrics_Click);
        }
        this._btnRemoveLyrics = value;
        if (this._btnRemoveLyrics != null)
        {
          this._btnRemoveLyrics.Click += new EventHandler(this.btnRemoveLyrics_Click);
        }
      }
    }

    internal virtual Button btnRemoveMusician
    {
      get
      {
        return this._btnRemoveMusician;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveMusician != null)
        {
          this._btnRemoveMusician.Click -= new EventHandler(this.btnRemoveMusican_Click);
        }
        this._btnRemoveMusician = value;
        if (this._btnRemoveMusician != null)
        {
          this._btnRemoveMusician.Click += new EventHandler(this.btnRemoveMusican_Click);
        }
      }
    }

    internal virtual Button btnRemovePicture
    {
      get
      {
        return this._btnRemovePicture;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemovePicture != null)
        {
          this._btnRemovePicture.Click -= new EventHandler(this.btnRemovePicture_Click);
        }
        this._btnRemovePicture = value;
        if (this._btnRemovePicture != null)
        {
          this._btnRemovePicture.Click += new EventHandler(this.btnRemovePicture_Click);
        }
      }
    }

    internal virtual Button btnRemoveRating
    {
      get
      {
        return this._btnRemoveRating;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveRating != null)
        {
          this._btnRemoveRating.Click -= new EventHandler(this.btnRemoveRating_Click);
        }
        this._btnRemoveRating = value;
        if (this._btnRemoveRating != null)
        {
          this._btnRemoveRating.Click += new EventHandler(this.btnRemoveRating_Click);
        }
      }
    }

    internal virtual Button btnRemoveTXXX
    {
      get
      {
        return this._btnRemoveTXXX;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveTXXX != null)
        {
          this._btnRemoveTXXX.Click -= new EventHandler(this.btnRemoveTXXX_Click);
        }
        this._btnRemoveTXXX = value;
        if (this._btnRemoveTXXX != null)
        {
          this._btnRemoveTXXX.Click += new EventHandler(this.btnRemoveTXXX_Click);
        }
      }
    }

    internal virtual Button btnRemoveWXXX
    {
      get
      {
        return this._btnRemoveWXXX;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveWXXX != null)
        {
          this._btnRemoveWXXX.Click -= new EventHandler(this.btnRemoveWXXX_Click);
        }
        this._btnRemoveWXXX = value;
        if (this._btnRemoveWXXX != null)
        {
          this._btnRemoveWXXX.Click += new EventHandler(this.btnRemoveWXXX_Click);
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

    internal virtual Button btnTLEN
    {
      get
      {
        return this._btnTLEN;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnTLEN != null)
        {
          this._btnTLEN.Click -= new EventHandler(this.btnTLEN_Click);
        }
        this._btnTLEN = value;
        if (this._btnTLEN != null)
        {
          this._btnTLEN.Click += new EventHandler(this.btnTLEN_Click);
        }
      }
    }

    internal virtual Button btnV1Album
    {
      get
      {
        return this._btnV1Album;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnV1Album != null)
        {
          this._btnV1Album.Click -= new EventHandler(this.btnV1Album_Click);
        }
        this._btnV1Album = value;
        if (this._btnV1Album != null)
        {
          this._btnV1Album.Click += new EventHandler(this.btnV1Album_Click);
        }
      }
    }

    internal virtual Button btnV1Artist
    {
      get
      {
        return this._btnV1Artist;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnV1Artist != null)
        {
          this._btnV1Artist.Click -= new EventHandler(this.btnV1Artist_Click);
        }
        this._btnV1Artist = value;
        if (this._btnV1Artist != null)
        {
          this._btnV1Artist.Click += new EventHandler(this.btnV1Artist_Click);
        }
      }
    }

    internal virtual Button btnV1Comment
    {
      get
      {
        return this._btnV1Comment;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnV1Comment != null)
        {
          this._btnV1Comment.Click -= new EventHandler(this.btnV1Comment_Click);
        }
        this._btnV1Comment = value;
        if (this._btnV1Comment != null)
        {
          this._btnV1Comment.Click += new EventHandler(this.btnV1Comment_Click);
        }
      }
    }

    internal virtual Button btnV1Genre
    {
      get
      {
        return this._btnV1Genre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnV1Genre != null)
        {
          this._btnV1Genre.Click -= new EventHandler(this.btnV1Genre_Click);
        }
        this._btnV1Genre = value;
        if (this._btnV1Genre != null)
        {
          this._btnV1Genre.Click += new EventHandler(this.btnV1Genre_Click);
        }
      }
    }

    internal virtual Button btnV1Title
    {
      get
      {
        return this._btnV1Title;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnV1Title != null)
        {
          this._btnV1Title.Click -= new EventHandler(this.btnV1Title_Click);
        }
        this._btnV1Title = value;
        if (this._btnV1Title != null)
        {
          this._btnV1Title.Click += new EventHandler(this.btnV1Title_Click);
        }
      }
    }

    internal virtual Button btnV1Track
    {
      get
      {
        return this._btnV1Track;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnV1Track != null)
        {
          this._btnV1Track.Click -= new EventHandler(this.btnV1Track_Click);
        }
        this._btnV1Track = value;
        if (this._btnV1Track != null)
        {
          this._btnV1Track.Click += new EventHandler(this.btnV1Track_Click);
        }
      }
    }

    internal virtual Button btnV1Year
    {
      get
      {
        return this._btnV1Year;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnV1Year != null)
        {
          this._btnV1Year.Click -= new EventHandler(this.btnV1Year_Click);
        }
        this._btnV1Year = value;
        if (this._btnV1Year != null)
        {
          this._btnV1Year.Click += new EventHandler(this.btnV1Year_Click);
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

    internal virtual CheckBox chkPicInclude
    {
      get
      {
        return this._chkPicInclude;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkPicInclude != null)
        {
          this._chkPicInclude.CheckedChanged -= new EventHandler(this.chkPicInclude_CheckedChanged);
        }
        this._chkPicInclude = value;
        if (this._chkPicInclude != null)
        {
          this._chkPicInclude.CheckedChanged += new EventHandler(this.chkPicInclude_CheckedChanged);
        }
      }
    }

    internal virtual CheckBox chkPicRelativPath
    {
      get
      {
        return this._chkPicRelativPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkPicRelativPath != null)
        {
          this._chkPicRelativPath.CheckedChanged -= new EventHandler(this.chkPicRelativPath_CheckedChanged);
        }
        this._chkPicRelativPath = value;
        if (this._chkPicRelativPath != null)
        {
          this._chkPicRelativPath.CheckedChanged += new EventHandler(this.chkPicRelativPath_CheckedChanged);
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
          this._cmbArtist.Leave -= new EventHandler(this.Select_Leave);
          this._cmbArtist.Enter -= new EventHandler(this.Select_Enter);
        }
        this._cmbArtist = value;
        if (this._cmbArtist != null)
        {
          this._cmbArtist.Leave += new EventHandler(this.Select_Leave);
          this._cmbArtist.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual ComboBoxAutoComplete cmbCDescriptor
    {
      get
      {
        return this._cmbCDescriptor;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbCDescriptor != null)
        {
          this._cmbCDescriptor.Leave -= new EventHandler(this.Select_Leave);
          this._cmbCDescriptor.Enter -= new EventHandler(this.Select_Enter);
        }
        this._cmbCDescriptor = value;
        if (this._cmbCDescriptor != null)
        {
          this._cmbCDescriptor.Leave += new EventHandler(this.Select_Leave);
          this._cmbCDescriptor.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual ComboBox cmbCLanguage
    {
      get
      {
        return this._cmbCLanguage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbCLanguage != null)
        {
          this._cmbCLanguage.Leave -= new EventHandler(this.Select_Leave);
          this._cmbCLanguage.Enter -= new EventHandler(this.Select_Enter);
        }
        this._cmbCLanguage = value;
        if (this._cmbCLanguage != null)
        {
          this._cmbCLanguage.Leave += new EventHandler(this.Select_Leave);
          this._cmbCLanguage.Enter += new EventHandler(this.Select_Enter);
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
          this._cmbGenre.Leave -= new EventHandler(this.Select_Leave);
          this._cmbGenre.Enter -= new EventHandler(this.Select_Enter);
        }
        this._cmbGenre = value;
        if (this._cmbGenre != null)
        {
          this._cmbGenre.Leave += new EventHandler(this.Select_Leave);
          this._cmbGenre.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual ComboBox cmbLLanguage
    {
      get
      {
        return this._cmbLLanguage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbLLanguage != null)
        {
          this._cmbLLanguage.Leave -= new EventHandler(this.Select_Leave);
          this._cmbLLanguage.Enter -= new EventHandler(this.Select_Enter);
        }
        this._cmbLLanguage = value;
        if (this._cmbLLanguage != null)
        {
          this._cmbLLanguage.Leave += new EventHandler(this.Select_Leave);
          this._cmbLLanguage.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual ComboBox cmbMedia
    {
      get
      {
        return this._cmbMedia;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbMedia != null)
        {
          this._cmbMedia.Leave -= new EventHandler(this.Select_Leave);
          this._cmbMedia.Enter -= new EventHandler(this.Select_Enter);
        }
        this._cmbMedia = value;
        if (this._cmbMedia != null)
        {
          this._cmbMedia.Leave += new EventHandler(this.Select_Leave);
          this._cmbMedia.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual ComboBox cmbPicType
    {
      get
      {
        return this._cmbPicType;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbPicType != null)
        {
          this._cmbPicType.Leave -= new EventHandler(this.Select_Leave);
          this._cmbPicType.Enter -= new EventHandler(this.Select_Enter);
        }
        this._cmbPicType = value;
        if (this._cmbPicType != null)
        {
          this._cmbPicType.Leave += new EventHandler(this.Select_Leave);
          this._cmbPicType.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual ColumnHeader colComment
    {
      get
      {
        return this._colComment;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._colComment != null)
        {
        }
        this._colComment = value;
        if (this._colComment != null)
        {
        }
      }
    }

    internal virtual ColumnHeader colDescriptor
    {
      get
      {
        return this._colDescriptor;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._colDescriptor != null)
        {
        }
        this._colDescriptor = value;
        if (this._colDescriptor != null)
        {
        }
      }
    }

    internal virtual ColumnHeader colLanguage
    {
      get
      {
        return this._colLanguage;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._colLanguage != null)
        {
        }
        this._colLanguage = value;
        if (this._colLanguage != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader1
    {
      get
      {
        return this._ColumnHeader1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader1 != null)
        {
        }
        this._ColumnHeader1 = value;
        if (this._ColumnHeader1 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader10
    {
      get
      {
        return this._ColumnHeader10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader10 != null)
        {
        }
        this._ColumnHeader10 = value;
        if (this._ColumnHeader10 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader11
    {
      get
      {
        return this._ColumnHeader11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader11 != null)
        {
        }
        this._ColumnHeader11 = value;
        if (this._ColumnHeader11 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader12
    {
      get
      {
        return this._ColumnHeader12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader12 != null)
        {
        }
        this._ColumnHeader12 = value;
        if (this._ColumnHeader12 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader13
    {
      get
      {
        return this._ColumnHeader13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader13 != null)
        {
        }
        this._ColumnHeader13 = value;
        if (this._ColumnHeader13 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader14
    {
      get
      {
        return this._ColumnHeader14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader14 != null)
        {
        }
        this._ColumnHeader14 = value;
        if (this._ColumnHeader14 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader15
    {
      get
      {
        return this._ColumnHeader15;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader15 != null)
        {
        }
        this._ColumnHeader15 = value;
        if (this._ColumnHeader15 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader16
    {
      get
      {
        return this._ColumnHeader16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader16 != null)
        {
        }
        this._ColumnHeader16 = value;
        if (this._ColumnHeader16 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader17
    {
      get
      {
        return this._ColumnHeader17;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader17 != null)
        {
        }
        this._ColumnHeader17 = value;
        if (this._ColumnHeader17 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader18
    {
      get
      {
        return this._ColumnHeader18;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader18 != null)
        {
        }
        this._ColumnHeader18 = value;
        if (this._ColumnHeader18 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader2
    {
      get
      {
        return this._ColumnHeader2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader2 != null)
        {
        }
        this._ColumnHeader2 = value;
        if (this._ColumnHeader2 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader3
    {
      get
      {
        return this._ColumnHeader3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader3 != null)
        {
        }
        this._ColumnHeader3 = value;
        if (this._ColumnHeader3 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader4
    {
      get
      {
        return this._ColumnHeader4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader4 != null)
        {
        }
        this._ColumnHeader4 = value;
        if (this._ColumnHeader4 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader5
    {
      get
      {
        return this._ColumnHeader5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader5 != null)
        {
        }
        this._ColumnHeader5 = value;
        if (this._ColumnHeader5 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader6
    {
      get
      {
        return this._ColumnHeader6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader6 != null)
        {
        }
        this._ColumnHeader6 = value;
        if (this._ColumnHeader6 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader7
    {
      get
      {
        return this._ColumnHeader7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader7 != null)
        {
        }
        this._ColumnHeader7 = value;
        if (this._ColumnHeader7 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader8
    {
      get
      {
        return this._ColumnHeader8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader8 != null)
        {
        }
        this._ColumnHeader8 = value;
        if (this._ColumnHeader8 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader ColumnHeader9
    {
      get
      {
        return this._ColumnHeader9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ColumnHeader9 != null)
        {
        }
        this._ColumnHeader9 = value;
        if (this._ColumnHeader9 != null)
        {
        }
      }
    }

    internal virtual ListView CommentList
    {
      get
      {
        return this._CommentList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._CommentList != null)
        {
          this._CommentList.Leave -= new EventHandler(this.Select_Leave);
          this._CommentList.Click -= new EventHandler(this.CommentList_Click);
        }
        this._CommentList = value;
        if (this._CommentList != null)
        {
          this._CommentList.Leave += new EventHandler(this.Select_Leave);
          this._CommentList.Click += new EventHandler(this.CommentList_Click);
        }
      }
    }

    internal virtual ColumnHeader Content
    {
      get
      {
        return this._Content;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Content != null)
        {
        }
        this._Content = value;
        if (this._Content != null)
        {
        }
      }
    }

    internal virtual ColumnHeader FrameID
    {
      get
      {
        return this._FrameID;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._FrameID != null)
        {
        }
        this._FrameID = value;
        if (this._FrameID != null)
        {
        }
      }
    }

    internal virtual ListBox GenreList
    {
      get
      {
        return this._GenreList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._GenreList != null)
        {
          this._GenreList.Leave -= new EventHandler(this.Select_Leave);
        }
        this._GenreList = value;
        if (this._GenreList != null)
        {
          this._GenreList.Leave += new EventHandler(this.Select_Leave);
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

    internal virtual Label lblAlbumSort
    {
      get
      {
        return this._lblAlbumSort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblAlbumSort != null)
        {
        }
        this._lblAlbumSort = value;
        if (this._lblAlbumSort != null)
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

    internal virtual Label lblArtistSort
    {
      get
      {
        return this._lblArtistSort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblArtistSort != null)
        {
        }
        this._lblArtistSort = value;
        if (this._lblArtistSort != null)
        {
        }
      }
    }

    internal virtual Label lblArtistURL
    {
      get
      {
        return this._lblArtistURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblArtistURL != null)
        {
        }
        this._lblArtistURL = value;
        if (this._lblArtistURL != null)
        {
        }
      }
    }

    internal virtual Label lblAudioFileURL
    {
      get
      {
        return this._lblAudioFileURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblAudioFileURL != null)
        {
        }
        this._lblAudioFileURL = value;
        if (this._lblAudioFileURL != null)
        {
        }
      }
    }

    internal virtual Label lblAudioSRCURL
    {
      get
      {
        return this._lblAudioSRCURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblAudioSRCURL != null)
        {
        }
        this._lblAudioSRCURL = value;
        if (this._lblAudioSRCURL != null)
        {
        }
      }
    }

    internal virtual Label lblBand
    {
      get
      {
        return this._lblBand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblBand != null)
        {
        }
        this._lblBand = value;
        if (this._lblBand != null)
        {
        }
      }
    }

    internal virtual Label lblBPM
    {
      get
      {
        return this._lblBPM;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblBPM != null)
        {
        }
        this._lblBPM = value;
        if (this._lblBPM != null)
        {
        }
      }
    }

    internal virtual Label lblCOMM
    {
      get
      {
        return this._lblCOMM;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblCOMM != null)
        {
        }
        this._lblCOMM = value;
        if (this._lblCOMM != null)
        {
        }
      }
    }

    internal virtual Label lblCOMMDesc
    {
      get
      {
        return this._lblCOMMDesc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblCOMMDesc != null)
        {
        }
        this._lblCOMMDesc = value;
        if (this._lblCOMMDesc != null)
        {
        }
      }
    }

    internal virtual Label lblCommDescInfo
    {
      get
      {
        return this._lblCommDescInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblCommDescInfo != null)
        {
        }
        this._lblCommDescInfo = value;
        if (this._lblCommDescInfo != null)
        {
        }
      }
    }

    internal virtual Label lblCOMMInfURL
    {
      get
      {
        return this._lblCOMMInfURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblCOMMInfURL != null)
        {
        }
        this._lblCOMMInfURL = value;
        if (this._lblCOMMInfURL != null)
        {
        }
      }
    }

    internal virtual Label lblCOMMLan
    {
      get
      {
        return this._lblCOMMLan;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblCOMMLan != null)
        {
        }
        this._lblCOMMLan = value;
        if (this._lblCOMMLan != null)
        {
        }
      }
    }

    internal virtual Label lblComposer
    {
      get
      {
        return this._lblComposer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblComposer != null)
        {
        }
        this._lblComposer = value;
        if (this._lblComposer != null)
        {
        }
      }
    }

    internal virtual Label lblConductor
    {
      get
      {
        return this._lblConductor;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblConductor != null)
        {
        }
        this._lblConductor = value;
        if (this._lblConductor != null)
        {
        }
      }
    }

    internal virtual Label lblContent
    {
      get
      {
        return this._lblContent;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblContent != null)
        {
        }
        this._lblContent = value;
        if (this._lblContent != null)
        {
        }
      }
    }

    internal virtual Label lblCopyInfURL
    {
      get
      {
        return this._lblCopyInfURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblCopyInfURL != null)
        {
        }
        this._lblCopyInfURL = value;
        if (this._lblCopyInfURL != null)
        {
        }
      }
    }

    internal virtual Label lblCopyright
    {
      get
      {
        return this._lblCopyright;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblCopyright != null)
        {
        }
        this._lblCopyright = value;
        if (this._lblCopyright != null)
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

    internal virtual Label lblEncoded
    {
      get
      {
        return this._lblEncoded;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblEncoded != null)
        {
        }
        this._lblEncoded = value;
        if (this._lblEncoded != null)
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

    internal virtual Label lblGenreInfo
    {
      get
      {
        return this._lblGenreInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblGenreInfo != null)
        {
        }
        this._lblGenreInfo = value;
        if (this._lblGenreInfo != null)
        {
        }
      }
    }

    internal virtual Label lblINetRadioURL
    {
      get
      {
        return this._lblINetRadioURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblINetRadioURL != null)
        {
        }
        this._lblINetRadioURL = value;
        if (this._lblINetRadioURL != null)
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

    internal virtual Label lblInvFunction
    {
      get
      {
        return this._lblInvFunction;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblInvFunction != null)
        {
        }
        this._lblInvFunction = value;
        if (this._lblInvFunction != null)
        {
        }
      }
    }

    internal virtual Label lblInvPerson
    {
      get
      {
        return this._lblInvPerson;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblInvPerson != null)
        {
        }
        this._lblInvPerson = value;
        if (this._lblInvPerson != null)
        {
        }
      }
    }

    internal virtual Label lblLyDesc
    {
      get
      {
        return this._lblLyDesc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblLyDesc != null)
        {
        }
        this._lblLyDesc = value;
        if (this._lblLyDesc != null)
        {
        }
      }
    }

    internal virtual Label lblLyLan
    {
      get
      {
        return this._lblLyLan;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblLyLan != null)
        {
        }
        this._lblLyLan = value;
        if (this._lblLyLan != null)
        {
        }
      }
    }

    internal virtual Label lblLyrics
    {
      get
      {
        return this._lblLyrics;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblLyrics != null)
        {
        }
        this._lblLyrics = value;
        if (this._lblLyrics != null)
        {
        }
      }
    }

    internal virtual Label lblLyWriter
    {
      get
      {
        return this._lblLyWriter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblLyWriter != null)
        {
        }
        this._lblLyWriter = value;
        if (this._lblLyWriter != null)
        {
        }
      }
    }

    internal virtual Label lblMediaTyp
    {
      get
      {
        return this._lblMediaTyp;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblMediaTyp != null)
        {
        }
        this._lblMediaTyp = value;
        if (this._lblMediaTyp != null)
        {
        }
      }
    }

    internal virtual Label lblModified
    {
      get
      {
        return this._lblModified;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblModified != null)
        {
        }
        this._lblModified = value;
        if (this._lblModified != null)
        {
        }
      }
    }

    internal virtual Label lblMusicianInfo
    {
      get
      {
        return this._lblMusicianInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblMusicianInfo != null)
        {
        }
        this._lblMusicianInfo = value;
        if (this._lblMusicianInfo != null)
        {
        }
      }
    }

    internal virtual Label lblMusicianInst
    {
      get
      {
        return this._lblMusicianInst;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblMusicianInst != null)
        {
        }
        this._lblMusicianInst = value;
        if (this._lblMusicianInst != null)
        {
        }
      }
    }

    internal virtual Label lblMusicianName
    {
      get
      {
        return this._lblMusicianName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblMusicianName != null)
        {
        }
        this._lblMusicianName = value;
        if (this._lblMusicianName != null)
        {
        }
      }
    }

    internal virtual Label lblNot
    {
      get
      {
        return this._lblNot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblNot != null)
        {
        }
        this._lblNot = value;
        if (this._lblNot != null)
        {
        }
      }
    }

    internal virtual Label lblOAlbum
    {
      get
      {
        return this._lblOAlbum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblOAlbum != null)
        {
        }
        this._lblOAlbum = value;
        if (this._lblOAlbum != null)
        {
        }
      }
    }

    internal virtual Label lblOArtist
    {
      get
      {
        return this._lblOArtist;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblOArtist != null)
        {
        }
        this._lblOArtist = value;
        if (this._lblOArtist != null)
        {
        }
      }
    }

    internal virtual Label lblOf1
    {
      get
      {
        return this._lblOf1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblOf1 != null)
        {
        }
        this._lblOf1 = value;
        if (this._lblOf1 != null)
        {
        }
      }
    }

    internal virtual Label lblOf2
    {
      get
      {
        return this._lblOf2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblOf2 != null)
        {
        }
        this._lblOf2 = value;
        if (this._lblOf2 != null)
        {
        }
      }
    }

    internal virtual Label lblOFilename
    {
      get
      {
        return this._lblOFilename;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblOFilename != null)
        {
        }
        this._lblOFilename = value;
        if (this._lblOFilename != null)
        {
        }
      }
    }

    internal virtual Label lblOLyWriter
    {
      get
      {
        return this._lblOLyWriter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblOLyWriter != null)
        {
        }
        this._lblOLyWriter = value;
        if (this._lblOLyWriter != null)
        {
        }
      }
    }

    internal virtual Label lblOOwner
    {
      get
      {
        return this._lblOOwner;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblOOwner != null)
        {
        }
        this._lblOOwner = value;
        if (this._lblOOwner != null)
        {
        }
      }
    }

    internal virtual Label lblOYear
    {
      get
      {
        return this._lblOYear;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblOYear != null)
        {
        }
        this._lblOYear = value;
        if (this._lblOYear != null)
        {
        }
      }
    }

    internal virtual Label lblOYearInfo
    {
      get
      {
        return this._lblOYearInfo;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblOYearInfo != null)
        {
        }
        this._lblOYearInfo = value;
        if (this._lblOYearInfo != null)
        {
        }
      }
    }

    internal virtual Label lblPayURL
    {
      get
      {
        return this._lblPayURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPayURL != null)
        {
        }
        this._lblPayURL = value;
        if (this._lblPayURL != null)
        {
        }
      }
    }

    internal virtual Label lblPicDesc
    {
      get
      {
        return this._lblPicDesc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPicDesc != null)
        {
        }
        this._lblPicDesc = value;
        if (this._lblPicDesc != null)
        {
        }
      }
    }

    internal virtual Label lblPicPath
    {
      get
      {
        return this._lblPicPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPicPath != null)
        {
        }
        this._lblPicPath = value;
        if (this._lblPicPath != null)
        {
        }
      }
    }

    internal virtual Label lblPicType
    {
      get
      {
        return this._lblPicType;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPicType != null)
        {
        }
        this._lblPicType = value;
        if (this._lblPicType != null)
        {
        }
      }
    }

    internal virtual Label lblPosMedia
    {
      get
      {
        return this._lblPosMedia;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPosMedia != null)
        {
        }
        this._lblPosMedia = value;
        if (this._lblPosMedia != null)
        {
        }
      }
    }

    internal virtual Label lblPublisher
    {
      get
      {
        return this._lblPublisher;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPublisher != null)
        {
        }
        this._lblPublisher = value;
        if (this._lblPublisher != null)
        {
        }
      }
    }

    internal virtual Label lblPubURL
    {
      get
      {
        return this._lblPubURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPubURL != null)
        {
        }
        this._lblPubURL = value;
        if (this._lblPubURL != null)
        {
        }
      }
    }

    internal virtual Label lblRatingCounter
    {
      get
      {
        return this._lblRatingCounter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblRatingCounter != null)
        {
        }
        this._lblRatingCounter = value;
        if (this._lblRatingCounter != null)
        {
        }
      }
    }

    internal virtual Label lblRatingRating
    {
      get
      {
        return this._lblRatingRating;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblRatingRating != null)
        {
        }
        this._lblRatingRating = value;
        if (this._lblRatingRating != null)
        {
        }
      }
    }

    internal virtual Label lblRatingUser
    {
      get
      {
        return this._lblRatingUser;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblRatingUser != null)
        {
        }
        this._lblRatingUser = value;
        if (this._lblRatingUser != null)
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

    internal virtual Label lblSubTitle
    {
      get
      {
        return this._lblSubTitle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblSubTitle != null)
        {
        }
        this._lblSubTitle = value;
        if (this._lblSubTitle != null)
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

    internal virtual Label lblTitleSort
    {
      get
      {
        return this._lblTitleSort;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblTitleSort != null)
        {
        }
        this._lblTitleSort = value;
        if (this._lblTitleSort != null)
        {
        }
      }
    }

    internal virtual Label lblTLEN
    {
      get
      {
        return this._lblTLEN;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblTLEN != null)
        {
        }
        this._lblTLEN = value;
        if (this._lblTLEN != null)
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

    internal virtual Label lblTXXXContent
    {
      get
      {
        return this._lblTXXXContent;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblTXXXContent != null)
        {
        }
        this._lblTXXXContent = value;
        if (this._lblTXXXContent != null)
        {
        }
      }
    }

    internal virtual Label lblTXXXDesc
    {
      get
      {
        return this._lblTXXXDesc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblTXXXDesc != null)
        {
        }
        this._lblTXXXDesc = value;
        if (this._lblTXXXDesc != null)
        {
        }
      }
    }

    internal virtual Label lblWXXXContent
    {
      get
      {
        return this._lblWXXXContent;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblWXXXContent != null)
        {
        }
        this._lblWXXXContent = value;
        if (this._lblWXXXContent != null)
        {
        }
      }
    }

    internal virtual Label lblWXXXDesc
    {
      get
      {
        return this._lblWXXXDesc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblWXXXDesc != null)
        {
        }
        this._lblWXXXDesc = value;
        if (this._lblWXXXDesc != null)
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

    internal virtual ListView LyricsList
    {
      get
      {
        return this._LyricsList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._LyricsList != null)
        {
          this._LyricsList.Leave -= new EventHandler(this.Select_Leave);
          this._LyricsList.Click -= new EventHandler(this.LyricsList_Click);
        }
        this._LyricsList = value;
        if (this._LyricsList != null)
        {
          this._LyricsList.Leave += new EventHandler(this.Select_Leave);
          this._LyricsList.Click += new EventHandler(this.LyricsList_Click);
        }
      }
    }

    internal virtual ListView NotSupportList
    {
      get
      {
        return this._NotSupportList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._NotSupportList != null)
        {
          this._NotSupportList.Leave -= new EventHandler(this.Select_Leave);
        }
        this._NotSupportList = value;
        if (this._NotSupportList != null)
        {
          this._NotSupportList.Leave += new EventHandler(this.Select_Leave);
        }
      }
    }

    internal virtual System.Windows.Forms.OpenFileDialog OpenFileDialog
    {
      get
      {
        return this._OpenFileDialog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._OpenFileDialog != null)
        {
        }
        this._OpenFileDialog = value;
        if (this._OpenFileDialog != null)
        {
        }
      }
    }

    internal virtual Panel panDetail
    {
      get
      {
        return this._panDetail;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panDetail != null)
        {
        }
        this._panDetail = value;
        if (this._panDetail != null)
        {
        }
      }
    }

    internal virtual Panel Panel1
    {
      get
      {
        return this._Panel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel1 != null)
        {
        }
        this._Panel1 = value;
        if (this._Panel1 != null)
        {
        }
      }
    }

    internal virtual Panel Panel10
    {
      get
      {
        return this._Panel10;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel10 != null)
        {
        }
        this._Panel10 = value;
        if (this._Panel10 != null)
        {
        }
      }
    }

    internal virtual Panel Panel11
    {
      get
      {
        return this._Panel11;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel11 != null)
        {
        }
        this._Panel11 = value;
        if (this._Panel11 != null)
        {
        }
      }
    }

    internal virtual Panel Panel12
    {
      get
      {
        return this._Panel12;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel12 != null)
        {
        }
        this._Panel12 = value;
        if (this._Panel12 != null)
        {
        }
      }
    }

    internal virtual Panel Panel13
    {
      get
      {
        return this._Panel13;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel13 != null)
        {
        }
        this._Panel13 = value;
        if (this._Panel13 != null)
        {
        }
      }
    }

    internal virtual Panel Panel14
    {
      get
      {
        return this._Panel14;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel14 != null)
        {
        }
        this._Panel14 = value;
        if (this._Panel14 != null)
        {
        }
      }
    }

    internal virtual Panel Panel15
    {
      get
      {
        return this._Panel15;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel15 != null)
        {
        }
        this._Panel15 = value;
        if (this._Panel15 != null)
        {
        }
      }
    }

    internal virtual Panel Panel16
    {
      get
      {
        return this._Panel16;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel16 != null)
        {
        }
        this._Panel16 = value;
        if (this._Panel16 != null)
        {
        }
      }
    }

    internal virtual Panel Panel2
    {
      get
      {
        return this._Panel2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel2 != null)
        {
        }
        this._Panel2 = value;
        if (this._Panel2 != null)
        {
        }
      }
    }

    internal virtual Panel Panel3
    {
      get
      {
        return this._Panel3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel3 != null)
        {
        }
        this._Panel3 = value;
        if (this._Panel3 != null)
        {
        }
      }
    }

    internal virtual Panel Panel4
    {
      get
      {
        return this._Panel4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel4 != null)
        {
        }
        this._Panel4 = value;
        if (this._Panel4 != null)
        {
        }
      }
    }

    internal virtual Panel Panel5
    {
      get
      {
        return this._Panel5;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel5 != null)
        {
        }
        this._Panel5 = value;
        if (this._Panel5 != null)
        {
        }
      }
    }

    internal virtual Panel Panel6
    {
      get
      {
        return this._Panel6;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel6 != null)
        {
        }
        this._Panel6 = value;
        if (this._Panel6 != null)
        {
        }
      }
    }

    internal virtual Panel Panel7
    {
      get
      {
        return this._Panel7;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel7 != null)
        {
        }
        this._Panel7 = value;
        if (this._Panel7 != null)
        {
        }
      }
    }

    internal virtual Panel Panel8
    {
      get
      {
        return this._Panel8;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel8 != null)
        {
        }
        this._Panel8 = value;
        if (this._Panel8 != null)
        {
        }
      }
    }

    internal virtual Panel Panel9
    {
      get
      {
        return this._Panel9;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Panel9 != null)
        {
        }
        this._Panel9 = value;
        if (this._Panel9 != null)
        {
        }
      }
    }

    internal virtual Panel panInvolved
    {
      get
      {
        return this._panInvolved;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panInvolved != null)
        {
        }
        this._panInvolved = value;
        if (this._panInvolved != null)
        {
        }
      }
    }

    internal virtual Panel panLyrics
    {
      get
      {
        return this._panLyrics;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panLyrics != null)
        {
        }
        this._panLyrics = value;
        if (this._panLyrics != null)
        {
        }
      }
    }

    internal virtual Panel panMain
    {
      get
      {
        return this._panMain;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panMain != null)
        {
        }
        this._panMain = value;
        if (this._panMain != null)
        {
        }
      }
    }

    internal virtual Panel panNot
    {
      get
      {
        return this._panNot;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panNot != null)
        {
        }
        this._panNot = value;
        if (this._panNot != null)
        {
        }
      }
    }

    internal virtual Panel panOriginal
    {
      get
      {
        return this._panOriginal;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panOriginal != null)
        {
        }
        this._panOriginal = value;
        if (this._panOriginal != null)
        {
        }
      }
    }

    internal virtual Panel panPic
    {
      get
      {
        return this._panPic;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panPic != null)
        {
        }
        this._panPic = value;
        if (this._panPic != null)
        {
        }
      }
    }

    internal virtual Panel panRating
    {
      get
      {
        return this._panRating;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panRating != null)
        {
        }
        this._panRating = value;
        if (this._panRating != null)
        {
        }
      }
    }

    internal virtual Panel panUser
    {
      get
      {
        return this._panUser;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panUser != null)
        {
        }
        this._panUser = value;
        if (this._panUser != null)
        {
        }
      }
    }

    internal virtual Panel panWeb
    {
      get
      {
        return this._panWeb;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._panWeb != null)
        {
        }
        this._panWeb = value;
        if (this._panWeb != null)
        {
        }
      }
    }

    internal virtual ListView PicList
    {
      get
      {
        return this._PicList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._PicList != null)
        {
          this._PicList.Leave -= new EventHandler(this.Select_Leave);
          this._PicList.Click -= new EventHandler(this.PicList_Click);
        }
        this._PicList = value;
        if (this._PicList != null)
        {
          this._PicList.Leave += new EventHandler(this.Select_Leave);
          this._PicList.Click += new EventHandler(this.PicList_Click);
        }
      }
    }

    internal virtual ListView RatingList
    {
      get
      {
        return this._RatingList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._RatingList != null)
        {
          this._RatingList.Click -= new EventHandler(this.RatingList_Click);
        }
        this._RatingList = value;
        if (this._RatingList != null)
        {
          this._RatingList.Click += new EventHandler(this.RatingList_Click);
        }
      }
    }

    internal virtual System.Windows.Forms.SaveFileDialog SaveFileDialog
    {
      get
      {
        return this._SaveFileDialog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._SaveFileDialog != null)
        {
        }
        this._SaveFileDialog = value;
        if (this._SaveFileDialog != null)
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
          this._TAGV2ButtonItem1.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem1 = value;
        if (this._TAGV2ButtonItem1 != null)
        {
          this._TAGV2ButtonItem1.Click += new EventHandler(this.btnItem_Click);
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
          this._TAGV2ButtonItem10.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem10 = value;
        if (this._TAGV2ButtonItem10 != null)
        {
          this._TAGV2ButtonItem10.Click += new EventHandler(this.btnItem_Click);
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
          this._TAGV2ButtonItem2.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem2 = value;
        if (this._TAGV2ButtonItem2 != null)
        {
          this._TAGV2ButtonItem2.Click += new EventHandler(this.btnItem_Click);
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
          this._TAGV2ButtonItem3.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem3 = value;
        if (this._TAGV2ButtonItem3 != null)
        {
          this._TAGV2ButtonItem3.Click += new EventHandler(this.btnItem_Click);
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
          this._TAGV2ButtonItem4.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem4 = value;
        if (this._TAGV2ButtonItem4 != null)
        {
          this._TAGV2ButtonItem4.Click += new EventHandler(this.btnItem_Click);
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
          this._TAGV2ButtonItem5.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem5 = value;
        if (this._TAGV2ButtonItem5 != null)
        {
          this._TAGV2ButtonItem5.Click += new EventHandler(this.btnItem_Click);
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
          this._TAGV2ButtonItem6.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem6 = value;
        if (this._TAGV2ButtonItem6 != null)
        {
          this._TAGV2ButtonItem6.Click += new EventHandler(this.btnItem_Click);
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
          this._TAGV2ButtonItem7.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem7 = value;
        if (this._TAGV2ButtonItem7 != null)
        {
          this._TAGV2ButtonItem7.Click += new EventHandler(this.btnItem_Click);
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
          this._TAGV2ButtonItem8.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem8 = value;
        if (this._TAGV2ButtonItem8 != null)
        {
          this._TAGV2ButtonItem8.Click += new EventHandler(this.btnItem_Click);
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
          this._TAGV2ButtonItem9.Click -= new EventHandler(this.btnItem_Click);
        }
        this._TAGV2ButtonItem9 = value;
        if (this._TAGV2ButtonItem9 != null)
        {
          this._TAGV2ButtonItem9.Click += new EventHandler(this.btnItem_Click);
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

    internal virtual ExplorerBarGroupItem TAGV2grpTAG
    {
      get
      {
        return this._TAGV2grpTAG;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2grpTAG != null)
        {
        }
        this._TAGV2grpTAG = value;
        if (this._TAGV2grpTAG != null)
        {
        }
      }
    }

    internal virtual ExplorerBarGroupItem TAGV2grpTransfer
    {
      get
      {
        return this._TAGV2grpTransfer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TAGV2grpTransfer != null)
        {
        }
        this._TAGV2grpTransfer = value;
        if (this._TAGV2grpTransfer != null)
        {
        }
      }
    }

    internal virtual ListView TIPLList
    {
      get
      {
        return this._TIPLList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TIPLList != null)
        {
          this._TIPLList.Click -= new EventHandler(this.TIPLList_Click);
        }
        this._TIPLList = value;
        if (this._TIPLList != null)
        {
          this._TIPLList.Click += new EventHandler(this.TIPLList_Click);
        }
      }
    }

    internal virtual ListView TMCLList
    {
      get
      {
        return this._TMCLList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TMCLList != null)
        {
          this._TMCLList.Click -= new EventHandler(this.TMCLList_Click);
        }
        this._TMCLList = value;
        if (this._TMCLList != null)
        {
          this._TMCLList.Click += new EventHandler(this.TMCLList_Click);
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

    internal virtual HScrollBar TORYFormat
    {
      get
      {
        return this._TORYFormat;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TORYFormat != null)
        {
          this._TORYFormat.Scroll -= new ScrollEventHandler(this.TORYFormat_Scroll);
        }
        this._TORYFormat = value;
        if (this._TORYFormat != null)
        {
          this._TORYFormat.Scroll += new ScrollEventHandler(this.TORYFormat_Scroll);
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
          this._txtAlbum.Leave -= new EventHandler(this.Select_Leave);
          this._txtAlbum.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtAlbum = value;
        if (this._txtAlbum != null)
        {
          this._txtAlbum.Leave += new EventHandler(this.Select_Leave);
          this._txtAlbum.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtArtistURL
    {
      get
      {
        return this._txtArtistURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtArtistURL != null)
        {
          this._txtArtistURL.Leave -= new EventHandler(this.Select_Leave);
          this._txtArtistURL.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtArtistURL = value;
        if (this._txtArtistURL != null)
        {
          this._txtArtistURL.Leave += new EventHandler(this.Select_Leave);
          this._txtArtistURL.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtAudioFileURL
    {
      get
      {
        return this._txtAudioFileURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtAudioFileURL != null)
        {
          this._txtAudioFileURL.Leave -= new EventHandler(this.Select_Leave);
          this._txtAudioFileURL.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtAudioFileURL = value;
        if (this._txtAudioFileURL != null)
        {
          this._txtAudioFileURL.Leave += new EventHandler(this.Select_Leave);
          this._txtAudioFileURL.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtAudioSRCURL
    {
      get
      {
        return this._txtAudioSRCURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtAudioSRCURL != null)
        {
          this._txtAudioSRCURL.Leave -= new EventHandler(this.Select_Leave);
          this._txtAudioSRCURL.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtAudioSRCURL = value;
        if (this._txtAudioSRCURL != null)
        {
          this._txtAudioSRCURL.Leave += new EventHandler(this.Select_Leave);
          this._txtAudioSRCURL.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtBand
    {
      get
      {
        return this._txtBand;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtBand != null)
        {
          this._txtBand.Leave -= new EventHandler(this.Select_Leave);
          this._txtBand.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtBand = value;
        if (this._txtBand != null)
        {
          this._txtBand.Leave += new EventHandler(this.Select_Leave);
          this._txtBand.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual NumericTextBox txtBPM
    {
      get
      {
        return this._txtBPM;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtBPM != null)
        {
          this._txtBPM.Leave -= new EventHandler(this.Select_Leave);
          this._txtBPM.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtBPM = value;
        if (this._txtBPM != null)
        {
          this._txtBPM.Leave += new EventHandler(this.Select_Leave);
          this._txtBPM.Enter += new EventHandler(this.Select_Enter);
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
          this._txtComment.Leave -= new EventHandler(this.Select_Leave);
          this._txtComment.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtComment = value;
        if (this._txtComment != null)
        {
          this._txtComment.Leave += new EventHandler(this.Select_Leave);
          this._txtComment.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtCOMMInfURL
    {
      get
      {
        return this._txtCOMMInfURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtCOMMInfURL != null)
        {
          this._txtCOMMInfURL.Leave -= new EventHandler(this.Select_Leave);
          this._txtCOMMInfURL.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtCOMMInfURL = value;
        if (this._txtCOMMInfURL != null)
        {
          this._txtCOMMInfURL.Leave += new EventHandler(this.Select_Leave);
          this._txtCOMMInfURL.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtComposer
    {
      get
      {
        return this._txtComposer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtComposer != null)
        {
          this._txtComposer.Leave -= new EventHandler(this.Select_Leave);
          this._txtComposer.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtComposer = value;
        if (this._txtComposer != null)
        {
          this._txtComposer.Leave += new EventHandler(this.Select_Leave);
          this._txtComposer.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtConductor
    {
      get
      {
        return this._txtConductor;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtConductor != null)
        {
          this._txtConductor.Leave -= new EventHandler(this.Select_Leave);
          this._txtConductor.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtConductor = value;
        if (this._txtConductor != null)
        {
          this._txtConductor.Leave += new EventHandler(this.Select_Leave);
          this._txtConductor.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtContent
    {
      get
      {
        return this._txtContent;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtContent != null)
        {
          this._txtContent.Leave -= new EventHandler(this.Select_Leave);
          this._txtContent.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtContent = value;
        if (this._txtContent != null)
        {
          this._txtContent.Leave += new EventHandler(this.Select_Leave);
          this._txtContent.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtCopyInfURL
    {
      get
      {
        return this._txtCopyInfURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtCopyInfURL != null)
        {
          this._txtCopyInfURL.Leave -= new EventHandler(this.Select_Leave);
          this._txtCopyInfURL.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtCopyInfURL = value;
        if (this._txtCopyInfURL != null)
        {
          this._txtCopyInfURL.Leave += new EventHandler(this.Select_Leave);
          this._txtCopyInfURL.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtCopyright
    {
      get
      {
        return this._txtCopyright;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtCopyright != null)
        {
          this._txtCopyright.Leave -= new EventHandler(this.Select_Leave);
          this._txtCopyright.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtCopyright = value;
        if (this._txtCopyright != null)
        {
          this._txtCopyright.Leave += new EventHandler(this.Select_Leave);
          this._txtCopyright.Enter += new EventHandler(this.Select_Enter);
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
        }
        this._txtDigits = value;
        if (this._txtDigits != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtEncoded
    {
      get
      {
        return this._txtEncoded;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtEncoded != null)
        {
          this._txtEncoded.Leave -= new EventHandler(this.Select_Leave);
          this._txtEncoded.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtEncoded = value;
        if (this._txtEncoded != null)
        {
          this._txtEncoded.Leave += new EventHandler(this.Select_Leave);
          this._txtEncoded.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtINetRadioURL
    {
      get
      {
        return this._txtINetRadioURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtINetRadioURL != null)
        {
          this._txtINetRadioURL.Leave -= new EventHandler(this.Select_Leave);
          this._txtINetRadioURL.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtINetRadioURL = value;
        if (this._txtINetRadioURL != null)
        {
          this._txtINetRadioURL.Leave += new EventHandler(this.Select_Leave);
          this._txtINetRadioURL.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtInvFunction
    {
      get
      {
        return this._txtInvFunction;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtInvFunction != null)
        {
          this._txtInvFunction.Leave -= new EventHandler(this.Select_Leave);
          this._txtInvFunction.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtInvFunction = value;
        if (this._txtInvFunction != null)
        {
          this._txtInvFunction.Leave += new EventHandler(this.Select_Leave);
          this._txtInvFunction.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtInvPerson
    {
      get
      {
        return this._txtInvPerson;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtInvPerson != null)
        {
          this._txtInvPerson.Leave -= new EventHandler(this.Select_Leave);
          this._txtInvPerson.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtInvPerson = value;
        if (this._txtInvPerson != null)
        {
          this._txtInvPerson.Leave += new EventHandler(this.Select_Leave);
          this._txtInvPerson.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtLDescriptor
    {
      get
      {
        return this._txtLDescriptor;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtLDescriptor != null)
        {
          this._txtLDescriptor.Leave -= new EventHandler(this.Select_Leave);
          this._txtLDescriptor.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtLDescriptor = value;
        if (this._txtLDescriptor != null)
        {
          this._txtLDescriptor.Leave += new EventHandler(this.Select_Leave);
          this._txtLDescriptor.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual RichTextBox txtLyrics
    {
      get
      {
        return this._txtLyrics;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtLyrics != null)
        {
        }
        this._txtLyrics = value;
        if (this._txtLyrics != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtLyWriter
    {
      get
      {
        return this._txtLyWriter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtLyWriter != null)
        {
          this._txtLyWriter.Leave -= new EventHandler(this.Select_Leave);
          this._txtLyWriter.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtLyWriter = value;
        if (this._txtLyWriter != null)
        {
          this._txtLyWriter.Leave += new EventHandler(this.Select_Leave);
          this._txtLyWriter.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtModified
    {
      get
      {
        return this._txtModified;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtModified != null)
        {
          this._txtModified.Leave -= new EventHandler(this.Select_Leave);
          this._txtModified.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtModified = value;
        if (this._txtModified != null)
        {
          this._txtModified.Leave += new EventHandler(this.Select_Leave);
          this._txtModified.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtMusicianInst
    {
      get
      {
        return this._txtMusicianInst;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtMusicianInst != null)
        {
          this._txtMusicianInst.Leave -= new EventHandler(this.Select_Leave);
          this._txtMusicianInst.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtMusicianInst = value;
        if (this._txtMusicianInst != null)
        {
          this._txtMusicianInst.Leave += new EventHandler(this.Select_Leave);
          this._txtMusicianInst.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtMusicianName
    {
      get
      {
        return this._txtMusicianName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtMusicianName != null)
        {
          this._txtMusicianName.Leave -= new EventHandler(this.Select_Leave);
          this._txtMusicianName.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtMusicianName = value;
        if (this._txtMusicianName != null)
        {
          this._txtMusicianName.Leave += new EventHandler(this.Select_Leave);
          this._txtMusicianName.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtOAlbum
    {
      get
      {
        return this._txtOAlbum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtOAlbum != null)
        {
          this._txtOAlbum.Leave -= new EventHandler(this.Select_Leave);
          this._txtOAlbum.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtOAlbum = value;
        if (this._txtOAlbum != null)
        {
          this._txtOAlbum.Leave += new EventHandler(this.Select_Leave);
          this._txtOAlbum.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtOArtist
    {
      get
      {
        return this._txtOArtist;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtOArtist != null)
        {
          this._txtOArtist.Leave -= new EventHandler(this.Select_Leave);
          this._txtOArtist.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtOArtist = value;
        if (this._txtOArtist != null)
        {
          this._txtOArtist.Leave += new EventHandler(this.Select_Leave);
          this._txtOArtist.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtOFilename
    {
      get
      {
        return this._txtOFilename;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtOFilename != null)
        {
          this._txtOFilename.Leave -= new EventHandler(this.Select_Leave);
          this._txtOFilename.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtOFilename = value;
        if (this._txtOFilename != null)
        {
          this._txtOFilename.Leave += new EventHandler(this.Select_Leave);
          this._txtOFilename.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtOLyWriter
    {
      get
      {
        return this._txtOLyWriter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtOLyWriter != null)
        {
          this._txtOLyWriter.Leave -= new EventHandler(this.Select_Leave);
          this._txtOLyWriter.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtOLyWriter = value;
        if (this._txtOLyWriter != null)
        {
          this._txtOLyWriter.Leave += new EventHandler(this.Select_Leave);
          this._txtOLyWriter.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtOOwner
    {
      get
      {
        return this._txtOOwner;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtOOwner != null)
        {
          this._txtOOwner.Leave -= new EventHandler(this.Select_Leave);
          this._txtOOwner.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtOOwner = value;
        if (this._txtOOwner != null)
        {
          this._txtOOwner.Leave += new EventHandler(this.Select_Leave);
          this._txtOOwner.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtPayURL
    {
      get
      {
        return this._txtPayURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPayURL != null)
        {
          this._txtPayURL.Leave -= new EventHandler(this.Select_Leave);
          this._txtPayURL.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtPayURL = value;
        if (this._txtPayURL != null)
        {
          this._txtPayURL.Leave += new EventHandler(this.Select_Leave);
          this._txtPayURL.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtPDescriptor
    {
      get
      {
        return this._txtPDescriptor;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPDescriptor != null)
        {
          this._txtPDescriptor.Leave -= new EventHandler(this.Select_Leave);
          this._txtPDescriptor.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtPDescriptor = value;
        if (this._txtPDescriptor != null)
        {
          this._txtPDescriptor.Leave += new EventHandler(this.Select_Leave);
          this._txtPDescriptor.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtPicPath
    {
      get
      {
        return this._txtPicPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPicPath != null)
        {
          this._txtPicPath.Leave -= new EventHandler(this.Select_Leave);
          this._txtPicPath.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtPicPath = value;
        if (this._txtPicPath != null)
        {
          this._txtPicPath.Leave += new EventHandler(this.Select_Leave);
          this._txtPicPath.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual IntegerTextBox txtPOS1
    {
      get
      {
        return this._txtPOS1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPOS1 != null)
        {
        }
        this._txtPOS1 = value;
        if (this._txtPOS1 != null)
        {
        }
      }
    }

    internal virtual IntegerTextBox txtPOS2
    {
      get
      {
        return this._txtPOS2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPOS2 != null)
        {
        }
        this._txtPOS2 = value;
        if (this._txtPOS2 != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtPublisher
    {
      get
      {
        return this._txtPublisher;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPublisher != null)
        {
          this._txtPublisher.Leave -= new EventHandler(this.Select_Leave);
          this._txtPublisher.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtPublisher = value;
        if (this._txtPublisher != null)
        {
          this._txtPublisher.Leave += new EventHandler(this.Select_Leave);
          this._txtPublisher.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtPubURL
    {
      get
      {
        return this._txtPubURL;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPubURL != null)
        {
          this._txtPubURL.Leave -= new EventHandler(this.Select_Leave);
          this._txtPubURL.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtPubURL = value;
        if (this._txtPubURL != null)
        {
          this._txtPubURL.Leave += new EventHandler(this.Select_Leave);
          this._txtPubURL.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual NumericUpDown txtRatingCounter
    {
      get
      {
        return this._txtRatingCounter;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtRatingCounter != null)
        {
          this._txtRatingCounter.Leave -= new EventHandler(this.Select_Leave);
          this._txtRatingCounter.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtRatingCounter = value;
        if (this._txtRatingCounter != null)
        {
          this._txtRatingCounter.Leave += new EventHandler(this.Select_Leave);
          this._txtRatingCounter.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual NumericUpDown txtRatingRating
    {
      get
      {
        return this._txtRatingRating;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtRatingRating != null)
        {
          this._txtRatingRating.Leave -= new EventHandler(this.Select_Leave);
          this._txtRatingRating.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtRatingRating = value;
        if (this._txtRatingRating != null)
        {
          this._txtRatingRating.Leave += new EventHandler(this.Select_Leave);
          this._txtRatingRating.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtRatingUser
    {
      get
      {
        return this._txtRatingUser;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtRatingUser != null)
        {
          this._txtRatingUser.Leave -= new EventHandler(this.Select_Leave);
          this._txtRatingUser.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtRatingUser = value;
        if (this._txtRatingUser != null)
        {
          this._txtRatingUser.Leave += new EventHandler(this.Select_Leave);
          this._txtRatingUser.Enter += new EventHandler(this.Select_Enter);
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
          this._txtSelected.Leave -= new EventHandler(this.Select_Leave);
          this._txtSelected.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtSelected = value;
        if (this._txtSelected != null)
        {
          this._txtSelected.Leave += new EventHandler(this.Select_Leave);
          this._txtSelected.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtSortAlbum
    {
      get
      {
        return this._txtSortAlbum;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtSortAlbum != null)
        {
          this._txtSortAlbum.Leave -= new EventHandler(this.Select_Leave);
          this._txtSortAlbum.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtSortAlbum = value;
        if (this._txtSortAlbum != null)
        {
          this._txtSortAlbum.Leave += new EventHandler(this.Select_Leave);
          this._txtSortAlbum.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtSortArtist
    {
      get
      {
        return this._txtSortArtist;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtSortArtist != null)
        {
          this._txtSortArtist.Leave -= new EventHandler(this.Select_Leave);
          this._txtSortArtist.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtSortArtist = value;
        if (this._txtSortArtist != null)
        {
          this._txtSortArtist.Leave += new EventHandler(this.Select_Leave);
          this._txtSortArtist.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtSortTitle
    {
      get
      {
        return this._txtSortTitle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtSortTitle != null)
        {
          this._txtSortTitle.Leave -= new EventHandler(this.Select_Leave);
          this._txtSortTitle.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtSortTitle = value;
        if (this._txtSortTitle != null)
        {
          this._txtSortTitle.Leave += new EventHandler(this.Select_Leave);
          this._txtSortTitle.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtSubTitle
    {
      get
      {
        return this._txtSubTitle;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtSubTitle != null)
        {
          this._txtSubTitle.Leave -= new EventHandler(this.Select_Leave);
          this._txtSubTitle.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtSubTitle = value;
        if (this._txtSubTitle != null)
        {
          this._txtSubTitle.Leave += new EventHandler(this.Select_Leave);
          this._txtSubTitle.Enter += new EventHandler(this.Select_Enter);
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
          this._txtTitle.Leave -= new EventHandler(this.Select_Leave);
          this._txtTitle.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtTitle = value;
        if (this._txtTitle != null)
        {
          this._txtTitle.Leave += new EventHandler(this.Select_Leave);
          this._txtTitle.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual IntegerTextBox txtTLEN
    {
      get
      {
        return this._txtTLEN;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTLEN != null)
        {
        }
        this._txtTLEN = value;
        if (this._txtTLEN != null)
        {
        }
      }
    }

    internal virtual AMS.TextBox.MaskedTextBox txtTORY
    {
      get
      {
        return this._txtTORY;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTORY != null)
        {
          this._txtTORY.Leave -= new EventHandler(this.Select_Leave);
          this._txtTORY.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtTORY = value;
        if (this._txtTORY != null)
        {
          this._txtTORY.Leave += new EventHandler(this.Select_Leave);
          this._txtTORY.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual IntegerTextBox txtTrack1
    {
      get
      {
        return this._txtTrack1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTrack1 != null)
        {
        }
        this._txtTrack1 = value;
        if (this._txtTrack1 != null)
        {
        }
      }
    }

    internal virtual IntegerTextBox txtTrack2
    {
      get
      {
        return this._txtTrack2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTrack2 != null)
        {
        }
        this._txtTrack2 = value;
        if (this._txtTrack2 != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtTXXXContent
    {
      get
      {
        return this._txtTXXXContent;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTXXXContent != null)
        {
          this._txtTXXXContent.Leave -= new EventHandler(this.Select_Leave);
          this._txtTXXXContent.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtTXXXContent = value;
        if (this._txtTXXXContent != null)
        {
          this._txtTXXXContent.Leave += new EventHandler(this.Select_Leave);
          this._txtTXXXContent.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtTXXXDesc
    {
      get
      {
        return this._txtTXXXDesc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtTXXXDesc != null)
        {
          this._txtTXXXDesc.Leave -= new EventHandler(this.Select_Leave);
          this._txtTXXXDesc.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtTXXXDesc = value;
        if (this._txtTXXXDesc != null)
        {
          this._txtTXXXDesc.Leave += new EventHandler(this.Select_Leave);
          this._txtTXXXDesc.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtWXXXContent
    {
      get
      {
        return this._txtWXXXContent;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtWXXXContent != null)
        {
          this._txtWXXXContent.Leave -= new EventHandler(this.Select_Leave);
          this._txtWXXXContent.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtWXXXContent = value;
        if (this._txtWXXXContent != null)
        {
          this._txtWXXXContent.Leave += new EventHandler(this.Select_Leave);
          this._txtWXXXContent.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual System.Windows.Forms.TextBox txtWXXXDesc
    {
      get
      {
        return this._txtWXXXDesc;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtWXXXDesc != null)
        {
          this._txtWXXXDesc.Leave -= new EventHandler(this.Select_Leave);
          this._txtWXXXDesc.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtWXXXDesc = value;
        if (this._txtWXXXDesc != null)
        {
          this._txtWXXXDesc.Leave += new EventHandler(this.Select_Leave);
          this._txtWXXXDesc.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual AMS.TextBox.MaskedTextBox txtYear
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
          this._txtYear.Leave -= new EventHandler(this.Select_Leave);
          this._txtYear.Enter -= new EventHandler(this.Select_Enter);
        }
        this._txtYear = value;
        if (this._txtYear != null)
        {
          this._txtYear.Leave += new EventHandler(this.Select_Leave);
          this._txtYear.Enter += new EventHandler(this.Select_Enter);
        }
      }
    }

    internal virtual ListView TXXXList
    {
      get
      {
        return this._TXXXList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TXXXList != null)
        {
          this._TXXXList.Leave -= new EventHandler(this.Select_Leave);
          this._TXXXList.Click -= new EventHandler(this.TXXXList_Click);
        }
        this._TXXXList = value;
        if (this._TXXXList != null)
        {
          this._TXXXList.Leave += new EventHandler(this.Select_Leave);
          this._TXXXList.Click += new EventHandler(this.TXXXList_Click);
        }
      }
    }

    internal virtual ListView WXXXList
    {
      get
      {
        return this._WXXXList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._WXXXList != null)
        {
          this._WXXXList.Leave -= new EventHandler(this.Select_Leave);
          this._WXXXList.Click -= new EventHandler(this.WXXXList_Click);
        }
        this._WXXXList = value;
        if (this._WXXXList != null)
        {
          this._WXXXList.Leave += new EventHandler(this.Select_Leave);
          this._WXXXList.Click += new EventHandler(this.WXXXList_Click);
        }
      }
    }

    internal virtual HScrollBar YearFormat
    {
      get
      {
        return this._YearFormat;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._YearFormat != null)
        {
          this._YearFormat.Scroll -= new ScrollEventHandler(this.YearFormat_Scroll);
        }
        this._YearFormat = value;
        if (this._YearFormat != null)
        {
          this._YearFormat.Scroll += new ScrollEventHandler(this.YearFormat_Scroll);
        }
      }
    }
  }
}