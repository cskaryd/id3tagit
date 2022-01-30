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
  public class frmTAG2 : Form
  {
    #region Designer

    private IContainer components;
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
    private Button btnExPic;
    private Button btnGetPic;
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
    private Button btnTLEN;
    private Button btnV1Album;
    private Button btnV1Artist;
    private Button btnV1Comment;
    private Button btnV1Genre;
    private Button btnV1Title;
    private Button btnV1Track;
    private Button btnV1Year;
    private CheckBox chkPicInclude;
    private CheckBox chkPicRelativPath;
    private ColumnHeader ColumnHeader10;
    private ColumnHeader ColumnHeader11;
    private ColumnHeader ColumnHeader12;
    private ColumnHeader ColumnHeader13;
    private ColumnHeader ColumnHeader14;
    private ColumnHeader ColumnHeader15;
    private ColumnHeader ColumnHeader16;
    private ColumnHeader ColumnHeader17;
    private ColumnHeader ColumnHeader18;
    private ColumnHeader ColumnHeader1;
    private ColumnHeader ColumnHeader2;
    private ColumnHeader ColumnHeader3;
    private ColumnHeader ColumnHeader4;
    private ColumnHeader ColumnHeader5;
    private ColumnHeader ColumnHeader6;
    private ColumnHeader ColumnHeader7;
    private ColumnHeader ColumnHeader8;
    private ColumnHeader ColumnHeader9;
    private ColumnHeader Content;
    private ColumnHeader FrameID;
    private ColumnHeader colComment;
    private ColumnHeader colDescriptor;
    private ColumnHeader colLanguage;
    private ComboBox cboFormat;
    private ComboBox cmbCLanguage;
    private ComboBox cmbLLanguage;
    private ComboBox cmbMedia;
    private ComboBox cmbPicType;
    private ComboBoxAutoComplete cmbArtist;
    private ComboBoxAutoComplete cmbCDescriptor;
    private ComboBoxAutoComplete cmbGenre;
    private Control FocusControl;
    private HScrollBar TORYFormat;
    private HScrollBar YearFormat;
    private Label label1;
    private Label label2;
    private Label lblAlbum;
    private Label lblAlbumSort;
    private Label lblArtist;
    private Label lblArtistSort;
    private Label lblArtistURL;
    private Label lblAudioFileURL;
    private Label lblAudioSRCURL;
    private Label lblBPM;
    private Label lblBand;
    private Label lblCOMM;
    private Label lblCOMMDesc;
    private Label lblCOMMInfURL;
    private Label lblCOMMLan;
    private Label lblCommDescInfo;
    private Label lblCommand;
    private Label lblComposer;
    private Label lblConductor;
    private Label lblContent;
    private Label lblCopyInfURL;
    private Label lblCopyright;
    private Label lblDigits;
    private Label lblEncoded;
    private Label lblGenre;
    private Label lblGenreInfo;
    private Label lblINetRadioURL;
    private Label lblInfo;
    private Label lblInvFunction;
    private Label lblInvPerson;
    private Label lblLyDesc;
    private Label lblLyLan;
    private Label lblLyWriter;
    private Label lblLyrics;
    private Label lblMediaTyp;
    private Label lblModified;
    private Label lblMusicianInfo;
    private Label lblMusicianInst;
    private Label lblMusicianName;
    private Label lblNot;
    private Label lblOAlbum;
    private Label lblOArtist;
    private Label lblOFilename;
    private Label lblOLyWriter;
    private Label lblOOwner;
    private Label lblOYear;
    private Label lblOYearInfo;
    private Label lblOf1;
    private Label lblOf2;
    private Label lblPayURL;
    private Label lblPicDesc;
    private Label lblPicPath;
    private Label lblPicType;
    private Label lblPosMedia;
    private Label lblPubURL;
    private Label lblPublisher;
    private Label lblRatingCounter;
    private Label lblRatingRating;
    private Label lblRatingUser;
    private Label lblSelected;
    private Label lblSubTitle;
    private Label lblTLEN;
    private Label lblTXXXContent;
    private Label lblTXXXDesc;
    private Label lblTitle;
    private Label lblTitleSort;
    private Label lblTopPanel;
    private Label lblTrack;
    private Label lblWXXXContent;
    private Label lblWXXXDesc;
    private Label lblYear;
    private LinkLabel lblDetailedInfo;
    private LinkLabel lblGetFromFile;
    private LinkLabel lblInvolvedPeople;
    private LinkLabel lblLyricsPane;
    private LinkLabel lblMainEntries;
    private LinkLabel lblNext;
    private LinkLabel lblOriginalInfo;
    private LinkLabel lblPictures;
    private LinkLabel lblPrevious;
    private LinkLabel lblRating;
    private LinkLabel lblSwapArtAlb;
    private LinkLabel lblSwapTtlAlb;
    private LinkLabel lblSwapArtTtl;
    private LinkLabel lblUnsupported;
    private LinkLabel lblUserDefined;
    private LinkLabel lblWebInfo;
    private LinkLabel lblXferFromV1;
    private LinkLabel lblXferToV1;
    private ListBox GenreList;
    private ListView CommentList;
    private ListView LyricsList;
    private ListView NotSupportList;
    private ListView PicList;
    private ListView RatingList;
    private ListView TIPLList;
    private ListView TMCLList;
    private ListView TXXXList;
    private ListView WXXXList;
    private MaskedTextBox txtBPM;
    private MaskedTextBox txtPOS1;
    private MaskedTextBox txtPOS2;
    private MaskedTextBox txtTLEN;
    private MaskedTextBox txtTORY;
    private MaskedTextBox txtTrack1;
    private MaskedTextBox txtTrack2;
    private MaskedTextBox txtYear;
    private NumericUpDown txtDigits;
    private NumericUpDown txtRatingCounter;
    private NumericUpDown txtRatingRating;
    private Panel Panel10;
    private Panel Panel11;
    private Panel Panel12;
    private Panel Panel13;
    private Panel Panel14;
    private Panel Panel15;
    private Panel Panel16;
    private Panel Panel1;
    private Panel Panel2;
    private Panel Panel3;
    private Panel Panel4;
    private Panel Panel5;
    private Panel Panel6;
    private Panel Panel7;
    private Panel Panel8;
    private Panel Panel9;
    private Panel panDetail;
    private Panel panInvolved;
    private Panel panLyrics;
    private Panel panMain;
    private Panel panNot;
    private Panel panOriginal;
    private Panel panPic;
    private Panel panRating;
    private Panel panUser;
    private Panel panWeb;
    private Panel pnlCommands;
    private Panel pnlTagInfo;
    private Panel pnlXferImport;
    private Panel pnlLeft;
    private PictureBox APICView;
    private RichTextBox txtLyrics;
    private System.Windows.Forms.OpenFileDialog OpenFileDialog;
    private System.Windows.Forms.SaveFileDialog SaveFileDialog;
    private System.Windows.Forms.TextBox txtAlbum;
    private System.Windows.Forms.TextBox txtArtistURL;
    private System.Windows.Forms.TextBox txtAudioFileURL;
    private System.Windows.Forms.TextBox txtAudioSRCURL;
    private System.Windows.Forms.TextBox txtBand;
    private System.Windows.Forms.TextBox txtCOMMInfURL;
    private System.Windows.Forms.TextBox txtComment;
    private System.Windows.Forms.TextBox txtComposer;
    private System.Windows.Forms.TextBox txtConductor;
    private System.Windows.Forms.TextBox txtContent;
    private System.Windows.Forms.TextBox txtCopyInfURL;
    private System.Windows.Forms.TextBox txtCopyright;
    private System.Windows.Forms.TextBox txtEncoded;
    private System.Windows.Forms.TextBox txtINetRadioURL;
    private System.Windows.Forms.TextBox txtInvFunction;
    private System.Windows.Forms.TextBox txtInvPerson;
    private System.Windows.Forms.TextBox txtLDescriptor;
    private System.Windows.Forms.TextBox txtLyWriter;
    private System.Windows.Forms.TextBox txtModified;
    private System.Windows.Forms.TextBox txtMusicianInst;
    private System.Windows.Forms.TextBox txtMusicianName;
    private System.Windows.Forms.TextBox txtOAlbum;
    private System.Windows.Forms.TextBox txtOArtist;
    private System.Windows.Forms.TextBox txtOFilename;
    private System.Windows.Forms.TextBox txtOLyWriter;
    private System.Windows.Forms.TextBox txtOOwner;
    private System.Windows.Forms.TextBox txtPDescriptor;
    private System.Windows.Forms.TextBox txtPayURL;
    private System.Windows.Forms.TextBox txtPicPath;
    private System.Windows.Forms.TextBox txtPubURL;
    private System.Windows.Forms.TextBox txtPublisher;
    private System.Windows.Forms.TextBox txtRatingUser;
    private System.Windows.Forms.TextBox txtSelected;
    private System.Windows.Forms.TextBox txtSortAlbum;
    private System.Windows.Forms.TextBox txtSortArtist;
    private System.Windows.Forms.TextBox txtSortTitle;
    private System.Windows.Forms.TextBox txtSubTitle;
    private System.Windows.Forms.TextBox txtTXXXContent;
    private System.Windows.Forms.TextBox txtTXXXDesc;
    private System.Windows.Forms.TextBox txtTitle;
    private System.Windows.Forms.TextBox txtWXXXContent;
    private System.Windows.Forms.TextBox txtWXXXDesc;
    private System.Windows.Forms.ToolTip ToolTip;
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
      this.APICView = new System.Windows.Forms.PictureBox();
      this.ColumnHeader1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader10 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader11 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader12 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader13 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader14 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader15 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader16 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader17 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader18 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader3 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader4 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader5 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader6 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader7 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader8 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.ColumnHeader9 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.CommentList = new System.Windows.Forms.ListView();
      this.colDescriptor = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colComment = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colLanguage = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.Content = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.FrameID = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.GenreList = new System.Windows.Forms.ListBox();
      this.LyricsList = new System.Windows.Forms.ListView();
      this.NotSupportList = new System.Windows.Forms.ListView();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.Panel1 = new System.Windows.Forms.Panel();
      this.txtPOS2 = new System.Windows.Forms.MaskedTextBox();
      this.txtPOS1 = new System.Windows.Forms.MaskedTextBox();
      this.txtTrack2 = new System.Windows.Forms.MaskedTextBox();
      this.txtTrack1 = new System.Windows.Forms.MaskedTextBox();
      this.txtYear = new System.Windows.Forms.MaskedTextBox();
      this.txtBPM = new System.Windows.Forms.MaskedTextBox();
      this.cmbArtist = new ID3_TagIT.ComboBoxAutoComplete();
      this.lblBPM = new System.Windows.Forms.Label();
      this.YearFormat = new System.Windows.Forms.HScrollBar();
      this.btnV1Title = new System.Windows.Forms.Button();
      this.btnV1Album = new System.Windows.Forms.Button();
      this.btnV1Track = new System.Windows.Forms.Button();
      this.btnV1Year = new System.Windows.Forms.Button();
      this.btnV1Artist = new System.Windows.Forms.Button();
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
      this.Panel10 = new System.Windows.Forms.Panel();
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
      this.Panel11 = new System.Windows.Forms.Panel();
      this.lblInfo = new System.Windows.Forms.Label();
      this.btnMoveRating = new System.Windows.Forms.Button();
      this.btnRemoveRating = new System.Windows.Forms.Button();
      this.btnAddRating = new System.Windows.Forms.Button();
      this.RatingList = new System.Windows.Forms.ListView();
      this.txtRatingCounter = new System.Windows.Forms.NumericUpDown();
      this.txtRatingRating = new System.Windows.Forms.NumericUpDown();
      this.txtRatingUser = new System.Windows.Forms.TextBox();
      this.lblRatingRating = new System.Windows.Forms.Label();
      this.lblRatingCounter = new System.Windows.Forms.Label();
      this.lblRatingUser = new System.Windows.Forms.Label();
      this.Panel12 = new System.Windows.Forms.Panel();
      this.txtTXXXContent = new System.Windows.Forms.TextBox();
      this.btnRemoveTXXX = new System.Windows.Forms.Button();
      this.btnAddTXXX = new System.Windows.Forms.Button();
      this.lblTXXXContent = new System.Windows.Forms.Label();
      this.lblTXXXDesc = new System.Windows.Forms.Label();
      this.txtTXXXDesc = new System.Windows.Forms.TextBox();
      this.TXXXList = new System.Windows.Forms.ListView();
      this.Panel13 = new System.Windows.Forms.Panel();
      this.txtWXXXContent = new System.Windows.Forms.TextBox();
      this.btnRemoveWXXX = new System.Windows.Forms.Button();
      this.btnAddWXXX = new System.Windows.Forms.Button();
      this.lblWXXXContent = new System.Windows.Forms.Label();
      this.lblWXXXDesc = new System.Windows.Forms.Label();
      this.txtWXXXDesc = new System.Windows.Forms.TextBox();
      this.WXXXList = new System.Windows.Forms.ListView();
      this.Panel14 = new System.Windows.Forms.Panel();
      this.btnTLEN = new System.Windows.Forms.Button();
      this.txtTLEN = new System.Windows.Forms.MaskedTextBox();
      this.lblTLEN = new System.Windows.Forms.Label();
      this.cmbMedia = new System.Windows.Forms.ComboBox();
      this.lblMediaTyp = new System.Windows.Forms.Label();
      this.Panel15 = new System.Windows.Forms.Panel();
      this.lblMusicianInfo = new System.Windows.Forms.Label();
      this.txtMusicianName = new System.Windows.Forms.TextBox();
      this.btnRemoveMusician = new System.Windows.Forms.Button();
      this.btnAddMusician = new System.Windows.Forms.Button();
      this.lblMusicianName = new System.Windows.Forms.Label();
      this.lblMusicianInst = new System.Windows.Forms.Label();
      this.txtMusicianInst = new System.Windows.Forms.TextBox();
      this.TMCLList = new System.Windows.Forms.ListView();
      this.Panel16 = new System.Windows.Forms.Panel();
      this.txtInvPerson = new System.Windows.Forms.TextBox();
      this.btnRemoveInv = new System.Windows.Forms.Button();
      this.btnAddInv = new System.Windows.Forms.Button();
      this.lblInvPerson = new System.Windows.Forms.Label();
      this.lblInvFunction = new System.Windows.Forms.Label();
      this.txtInvFunction = new System.Windows.Forms.TextBox();
      this.TIPLList = new System.Windows.Forms.ListView();
      this.Panel2 = new System.Windows.Forms.Panel();
      this.cmbGenre = new ID3_TagIT.ComboBoxAutoComplete();
      this.btnV1Genre = new System.Windows.Forms.Button();
      this.lblGenreInfo = new System.Windows.Forms.Label();
      this.btnMoveGenre = new System.Windows.Forms.Button();
      this.btnRemoveGenre = new System.Windows.Forms.Button();
      this.btnAddGenre = new System.Windows.Forms.Button();
      this.lblGenre = new System.Windows.Forms.Label();
      this.Panel3 = new System.Windows.Forms.Panel();
      this.lblCommDescInfo = new System.Windows.Forms.Label();
      this.cmbCDescriptor = new ID3_TagIT.ComboBoxAutoComplete();
      this.btnV1Comment = new System.Windows.Forms.Button();
      this.btnMoveComment = new System.Windows.Forms.Button();
      this.btnRemoveComment = new System.Windows.Forms.Button();
      this.btnAddComment = new System.Windows.Forms.Button();
      this.lblCOMM = new System.Windows.Forms.Label();
      this.lblCOMMLan = new System.Windows.Forms.Label();
      this.lblCOMMDesc = new System.Windows.Forms.Label();
      this.cmbCLanguage = new System.Windows.Forms.ComboBox();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.Panel4 = new System.Windows.Forms.Panel();
      this.txtComposer = new System.Windows.Forms.TextBox();
      this.lblComposer = new System.Windows.Forms.Label();
      this.txtBand = new System.Windows.Forms.TextBox();
      this.txtModified = new System.Windows.Forms.TextBox();
      this.txtConductor = new System.Windows.Forms.TextBox();
      this.lblConductor = new System.Windows.Forms.Label();
      this.lblModified = new System.Windows.Forms.Label();
      this.lblBand = new System.Windows.Forms.Label();
      this.txtCopyright = new System.Windows.Forms.TextBox();
      this.lblCopyright = new System.Windows.Forms.Label();
      this.txtLyWriter = new System.Windows.Forms.TextBox();
      this.txtEncoded = new System.Windows.Forms.TextBox();
      this.txtPublisher = new System.Windows.Forms.TextBox();
      this.lblPublisher = new System.Windows.Forms.Label();
      this.lblEncoded = new System.Windows.Forms.Label();
      this.lblLyWriter = new System.Windows.Forms.Label();
      this.Panel5 = new System.Windows.Forms.Panel();
      this.txtContent = new System.Windows.Forms.TextBox();
      this.txtSubTitle = new System.Windows.Forms.TextBox();
      this.lblSubTitle = new System.Windows.Forms.Label();
      this.lblContent = new System.Windows.Forms.Label();
      this.Panel6 = new System.Windows.Forms.Panel();
      this.txtTORY = new System.Windows.Forms.MaskedTextBox();
      this.lblOYearInfo = new System.Windows.Forms.Label();
      this.TORYFormat = new System.Windows.Forms.HScrollBar();
      this.lblOYear = new System.Windows.Forms.Label();
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
      this.Panel7 = new System.Windows.Forms.Panel();
      this.chkPicRelativPath = new System.Windows.Forms.CheckBox();
      this.btnExPic = new System.Windows.Forms.Button();
      this.btnRemovePicture = new System.Windows.Forms.Button();
      this.btnAddPicture = new System.Windows.Forms.Button();
      this.btnGetPic = new System.Windows.Forms.Button();
      this.chkPicInclude = new System.Windows.Forms.CheckBox();
      this.lblPicPath = new System.Windows.Forms.Label();
      this.txtPicPath = new System.Windows.Forms.TextBox();
      this.PicList = new System.Windows.Forms.ListView();
      this.lblPicType = new System.Windows.Forms.Label();
      this.lblPicDesc = new System.Windows.Forms.Label();
      this.cmbPicType = new System.Windows.Forms.ComboBox();
      this.txtPDescriptor = new System.Windows.Forms.TextBox();
      this.Panel8 = new System.Windows.Forms.Panel();
      this.txtLyrics = new System.Windows.Forms.RichTextBox();
      this.btnLyricsFile = new System.Windows.Forms.Button();
      this.btnMoveLyrics = new System.Windows.Forms.Button();
      this.btnRemoveLyrics = new System.Windows.Forms.Button();
      this.btnAddLyrics = new System.Windows.Forms.Button();
      this.lblLyrics = new System.Windows.Forms.Label();
      this.lblLyLan = new System.Windows.Forms.Label();
      this.lblLyDesc = new System.Windows.Forms.Label();
      this.cmbLLanguage = new System.Windows.Forms.ComboBox();
      this.txtLDescriptor = new System.Windows.Forms.TextBox();
      this.Panel9 = new System.Windows.Forms.Panel();
      this.txtSortArtist = new System.Windows.Forms.TextBox();
      this.txtSortTitle = new System.Windows.Forms.TextBox();
      this.txtSortAlbum = new System.Windows.Forms.TextBox();
      this.lblAlbumSort = new System.Windows.Forms.Label();
      this.lblTitleSort = new System.Windows.Forms.Label();
      this.lblArtistSort = new System.Windows.Forms.Label();
      this.SaveFileDialog = new System.Windows.Forms.SaveFileDialog();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.cboFormat = new System.Windows.Forms.ComboBox();
      this.label1 = new System.Windows.Forms.Label();
      this.label2 = new System.Windows.Forms.Label();
      this.lblCommand = new System.Windows.Forms.Label();
      this.lblDetailedInfo = new System.Windows.Forms.LinkLabel();
      this.lblDigits = new System.Windows.Forms.Label();
      this.lblGetFromFile = new System.Windows.Forms.LinkLabel();
      this.lblInvolvedPeople = new System.Windows.Forms.LinkLabel();
      this.lblLyricsPane = new System.Windows.Forms.LinkLabel();
      this.lblMainEntries = new System.Windows.Forms.LinkLabel();
      this.lblNext = new System.Windows.Forms.LinkLabel();
      this.lblNot = new System.Windows.Forms.Label();
      this.lblOriginalInfo = new System.Windows.Forms.LinkLabel();
      this.lblPictures = new System.Windows.Forms.LinkLabel();
      this.lblPrevious = new System.Windows.Forms.LinkLabel();
      this.lblRating = new System.Windows.Forms.LinkLabel();
      this.lblSelected = new System.Windows.Forms.Label();
      this.lblSwapArtAlb = new System.Windows.Forms.LinkLabel();
      this.lblSwapTtlAlb = new System.Windows.Forms.LinkLabel();
      this.lblSwapArtTtl = new System.Windows.Forms.LinkLabel();
      this.lblTopPanel = new System.Windows.Forms.Label();
      this.lblUnsupported = new System.Windows.Forms.LinkLabel();
      this.lblUserDefined = new System.Windows.Forms.LinkLabel();
      this.lblWebInfo = new System.Windows.Forms.LinkLabel();
      this.lblXferFromV1 = new System.Windows.Forms.LinkLabel();
      this.lblXferToV1 = new System.Windows.Forms.LinkLabel();
      this.panDetail = new System.Windows.Forms.Panel();
      this.panInvolved = new System.Windows.Forms.Panel();
      this.panLyrics = new System.Windows.Forms.Panel();
      this.panMain = new System.Windows.Forms.Panel();
      this.panNot = new System.Windows.Forms.Panel();
      this.panOriginal = new System.Windows.Forms.Panel();
      this.panPic = new System.Windows.Forms.Panel();
      this.panRating = new System.Windows.Forms.Panel();
      this.panUser = new System.Windows.Forms.Panel();
      this.panWeb = new System.Windows.Forms.Panel();
      this.pnlCommands = new System.Windows.Forms.Panel();
      this.pnlTagInfo = new System.Windows.Forms.Panel();
      this.pnlXferImport = new System.Windows.Forms.Panel();
      this.pnlLeft = new System.Windows.Forms.Panel();
      this.txtDigits = new System.Windows.Forms.NumericUpDown();
      this.txtSelected = new System.Windows.Forms.TextBox();
      ((System.ComponentModel.ISupportInitialize)(this.APICView)).BeginInit();
      this.Panel1.SuspendLayout();
      this.Panel10.SuspendLayout();
      this.Panel11.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatingCounter)).BeginInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatingRating)).BeginInit();
      this.Panel12.SuspendLayout();
      this.Panel13.SuspendLayout();
      this.Panel14.SuspendLayout();
      this.Panel15.SuspendLayout();
      this.Panel16.SuspendLayout();
      this.Panel2.SuspendLayout();
      this.Panel3.SuspendLayout();
      this.Panel4.SuspendLayout();
      this.Panel5.SuspendLayout();
      this.Panel6.SuspendLayout();
      this.Panel7.SuspendLayout();
      this.Panel8.SuspendLayout();
      this.Panel9.SuspendLayout();
      this.panDetail.SuspendLayout();
      this.panInvolved.SuspendLayout();
      this.panLyrics.SuspendLayout();
      this.panMain.SuspendLayout();
      this.panNot.SuspendLayout();
      this.panOriginal.SuspendLayout();
      this.panPic.SuspendLayout();
      this.panRating.SuspendLayout();
      this.panUser.SuspendLayout();
      this.panWeb.SuspendLayout();
      this.pnlCommands.SuspendLayout();
      this.pnlTagInfo.SuspendLayout();
      this.pnlXferImport.SuspendLayout();
      this.pnlLeft.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).BeginInit();
      this.SuspendLayout();
      // 
      // APICView
      // 
      this.APICView.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.APICView.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.APICView.Location = new System.Drawing.Point(464, 8);
      this.APICView.Name = "APICView";
      this.APICView.Size = new System.Drawing.Size(176, 176);
      this.APICView.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.APICView.TabIndex = 1;
      this.APICView.TabStop = false;
      // 
      // ColumnHeader1
      // 
      this.ColumnHeader1.Text = "Descriptor";
      this.ColumnHeader1.Width = 132;
      // 
      // ColumnHeader10
      // 
      this.ColumnHeader10.Text = "Play Counter";
      this.ColumnHeader10.Width = 80;
      // 
      // ColumnHeader11
      // 
      this.ColumnHeader11.Text = "Descriptor";
      this.ColumnHeader11.Width = 200;
      // 
      // ColumnHeader12
      // 
      this.ColumnHeader12.Text = "Content";
      this.ColumnHeader12.Width = 258;
      // 
      // ColumnHeader13
      // 
      this.ColumnHeader13.Text = "Descriptor";
      this.ColumnHeader13.Width = 200;
      // 
      // ColumnHeader14
      // 
      this.ColumnHeader14.Text = "Content";
      this.ColumnHeader14.Width = 260;
      // 
      // ColumnHeader15
      // 
      this.ColumnHeader15.Text = "Instrument";
      this.ColumnHeader15.Width = 200;
      // 
      // ColumnHeader16
      // 
      this.ColumnHeader16.Text = "Name";
      this.ColumnHeader16.Width = 254;
      // 
      // ColumnHeader17
      // 
      this.ColumnHeader17.Text = "Function";
      this.ColumnHeader17.Width = 191;
      // 
      // ColumnHeader18
      // 
      this.ColumnHeader18.Text = "Name";
      this.ColumnHeader18.Width = 264;
      // 
      // ColumnHeader2
      // 
      this.ColumnHeader2.Text = "Text";
      this.ColumnHeader2.Width = 356;
      // 
      // ColumnHeader3
      // 
      this.ColumnHeader3.Text = "Language";
      this.ColumnHeader3.Width = 103;
      // 
      // ColumnHeader4
      // 
      this.ColumnHeader4.Text = "Descriptor";
      this.ColumnHeader4.Width = 160;
      // 
      // ColumnHeader5
      // 
      this.ColumnHeader5.Text = "Picture Type";
      this.ColumnHeader5.Width = 99;
      // 
      // ColumnHeader6
      // 
      this.ColumnHeader6.Text = "Path";
      this.ColumnHeader6.Width = 288;
      // 
      // ColumnHeader7
      // 
      this.ColumnHeader7.Text = "Include";
      // 
      // ColumnHeader8
      // 
      this.ColumnHeader8.Text = "User";
      this.ColumnHeader8.Width = 238;
      // 
      // ColumnHeader9
      // 
      this.ColumnHeader9.Text = "Rating";
      this.ColumnHeader9.Width = 100;
      // 
      // CommentList
      // 
      this.CommentList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colDescriptor,
            this.colComment,
            this.colLanguage});
      this.CommentList.FullRowSelect = true;
      this.CommentList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.CommentList.HideSelection = false;
      this.CommentList.Location = new System.Drawing.Point(136, 112);
      this.CommentList.MultiSelect = false;
      this.CommentList.Name = "CommentList";
      this.CommentList.Size = new System.Drawing.Size(504, 64);
      this.CommentList.TabIndex = 45;
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
      this.colComment.Width = 262;
      // 
      // colLanguage
      // 
      this.colLanguage.Text = "Language";
      this.colLanguage.Width = 91;
      // 
      // Content
      // 
      this.Content.Text = "Content";
      this.Content.Width = 467;
      // 
      // FrameID
      // 
      this.FrameID.Text = "Frame ID";
      this.FrameID.Width = 150;
      // 
      // GenreList
      // 
      this.GenreList.Location = new System.Drawing.Point(136, 32);
      this.GenreList.Name = "GenreList";
      this.GenreList.Size = new System.Drawing.Size(232, 69);
      this.GenreList.TabIndex = 34;
      this.GenreList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // LyricsList
      // 
      this.LyricsList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader1,
            this.ColumnHeader2,
            this.ColumnHeader3});
      this.LyricsList.FullRowSelect = true;
      this.LyricsList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.LyricsList.HideSelection = false;
      this.LyricsList.Location = new System.Drawing.Point(8, 320);
      this.LyricsList.MultiSelect = false;
      this.LyricsList.Name = "LyricsList";
      this.LyricsList.Size = new System.Drawing.Size(632, 112);
      this.LyricsList.TabIndex = 23;
      this.LyricsList.UseCompatibleStateImageBehavior = false;
      this.LyricsList.View = System.Windows.Forms.View.Details;
      this.LyricsList.Click += new System.EventHandler(this.LyricsList_Click);
      this.LyricsList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // NotSupportList
      // 
      this.NotSupportList.CheckBoxes = true;
      this.NotSupportList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.FrameID,
            this.Content});
      this.NotSupportList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.NotSupportList.HideSelection = false;
      this.NotSupportList.Location = new System.Drawing.Point(8, 8);
      this.NotSupportList.Name = "NotSupportList";
      this.NotSupportList.Size = new System.Drawing.Size(648, 392);
      this.NotSupportList.TabIndex = 0;
      this.NotSupportList.UseCompatibleStateImageBehavior = false;
      this.NotSupportList.View = System.Windows.Forms.View.Details;
      this.NotSupportList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // OpenFileDialog
      // 
      this.OpenFileDialog.RestoreDirectory = true;
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
      this.Panel1.Location = new System.Drawing.Point(8, 8);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new System.Drawing.Size(648, 128);
      this.Panel1.TabIndex = 0;
      // 
      // txtPOS2
      // 
      this.txtPOS2.Location = new System.Drawing.Point(576, 102);
      this.txtPOS2.Mask = "000";
      this.txtPOS2.Name = "txtPOS2";
      this.txtPOS2.Size = new System.Drawing.Size(64, 20);
      this.txtPOS2.TabIndex = 25;
      this.txtPOS2.Validating += new System.ComponentModel.CancelEventHandler(this.txtPOS2_Validating);
      // 
      // txtPOS1
      // 
      this.txtPOS1.Location = new System.Drawing.Point(488, 102);
      this.txtPOS1.Mask = "000";
      this.txtPOS1.Name = "txtPOS1";
      this.txtPOS1.Size = new System.Drawing.Size(64, 20);
      this.txtPOS1.TabIndex = 24;
      this.txtPOS1.Validating += new System.ComponentModel.CancelEventHandler(this.txtPOS1_Validating);
      // 
      // txtTrack2
      // 
      this.txtTrack2.Location = new System.Drawing.Point(224, 102);
      this.txtTrack2.Mask = "000";
      this.txtTrack2.Name = "txtTrack2";
      this.txtTrack2.Size = new System.Drawing.Size(64, 20);
      this.txtTrack2.TabIndex = 21;
      this.txtTrack2.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrack2_Validating);
      // 
      // txtTrack1
      // 
      this.txtTrack1.Location = new System.Drawing.Point(136, 102);
      this.txtTrack1.Mask = "000";
      this.txtTrack1.Name = "txtTrack1";
      this.txtTrack1.Size = new System.Drawing.Size(64, 20);
      this.txtTrack1.TabIndex = 20;
      this.txtTrack1.ValidatingType = typeof(int);
      this.txtTrack1.Validating += new System.ComponentModel.CancelEventHandler(this.txtTrack1_Validating);
      // 
      // txtYear
      // 
      this.txtYear.Location = new System.Drawing.Point(136, 78);
      this.txtYear.Mask = "0000-00-00";
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new System.Drawing.Size(112, 20);
      this.txtYear.TabIndex = 13;
      this.txtYear.Enter += new System.EventHandler(this.Select_Enter);
      this.txtYear.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtBPM
      // 
      this.txtBPM.Location = new System.Drawing.Point(488, 78);
      this.txtBPM.Mask = "000";
      this.txtBPM.Name = "txtBPM";
      this.txtBPM.Size = new System.Drawing.Size(152, 20);
      this.txtBPM.TabIndex = 18;
      this.txtBPM.Enter += new System.EventHandler(this.Select_Enter);
      this.txtBPM.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // cmbArtist
      // 
      this.cmbArtist.Autocomplete = true;
      this.cmbArtist.ItemHeight = 13;
      this.cmbArtist.Location = new System.Drawing.Point(136, 6);
      this.cmbArtist.Name = "cmbArtist";
      this.cmbArtist.Size = new System.Drawing.Size(440, 21);
      this.cmbArtist.TabIndex = 4;
      this.cmbArtist.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbArtist.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblBPM
      // 
      this.lblBPM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblBPM.Location = new System.Drawing.Point(368, 80);
      this.lblBPM.Name = "lblBPM";
      this.lblBPM.Size = new System.Drawing.Size(128, 16);
      this.lblBPM.TabIndex = 117;
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
      this.YearFormat.TabIndex = 14;
      this.YearFormat.Scroll += new System.Windows.Forms.ScrollEventHandler(this.YearFormat_Scroll);
      // 
      // btnV1Title
      // 
      this.btnV1Title.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnV1Title.Location = new System.Drawing.Point(584, 30);
      this.btnV1Title.Name = "btnV1Title";
      this.btnV1Title.Size = new System.Drawing.Size(56, 20);
      this.btnV1Title.TabIndex = 8;
      this.btnV1Title.Text = "<- Ver. 1";
      this.btnV1Title.Click += new System.EventHandler(this.btnV1Title_Click);
      // 
      // btnV1Album
      // 
      this.btnV1Album.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnV1Album.Location = new System.Drawing.Point(584, 54);
      this.btnV1Album.Name = "btnV1Album";
      this.btnV1Album.Size = new System.Drawing.Size(56, 20);
      this.btnV1Album.TabIndex = 11;
      this.btnV1Album.Text = "<- Ver. 1";
      this.btnV1Album.Click += new System.EventHandler(this.btnV1Album_Click);
      // 
      // btnV1Track
      // 
      this.btnV1Track.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnV1Track.Location = new System.Drawing.Point(296, 102);
      this.btnV1Track.Name = "btnV1Track";
      this.btnV1Track.Size = new System.Drawing.Size(56, 20);
      this.btnV1Track.TabIndex = 22;
      this.btnV1Track.Text = "<- Ver. 1";
      this.btnV1Track.Click += new System.EventHandler(this.btnV1Track_Click);
      // 
      // btnV1Year
      // 
      this.btnV1Year.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnV1Year.Location = new System.Drawing.Point(296, 78);
      this.btnV1Year.Name = "btnV1Year";
      this.btnV1Year.Size = new System.Drawing.Size(56, 20);
      this.btnV1Year.TabIndex = 16;
      this.btnV1Year.Text = "<- Ver. 1";
      this.btnV1Year.Click += new System.EventHandler(this.btnV1Year_Click);
      // 
      // btnV1Artist
      // 
      this.btnV1Artist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnV1Artist.Location = new System.Drawing.Point(584, 6);
      this.btnV1Artist.Name = "btnV1Artist";
      this.btnV1Artist.Size = new System.Drawing.Size(56, 20);
      this.btnV1Artist.TabIndex = 5;
      this.btnV1Artist.Text = "<- Ver. 1";
      this.btnV1Artist.Click += new System.EventHandler(this.btnV1Artist_Click);
      // 
      // lblOf2
      // 
      this.lblOf2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOf2.Location = new System.Drawing.Point(560, 104);
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
      this.txtAlbum.Size = new System.Drawing.Size(440, 20);
      this.txtAlbum.TabIndex = 10;
      this.txtAlbum.Enter += new System.EventHandler(this.Select_Enter);
      this.txtAlbum.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtTitle
      // 
      this.txtTitle.Location = new System.Drawing.Point(136, 30);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new System.Drawing.Size(440, 20);
      this.txtTitle.TabIndex = 7;
      this.txtTitle.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTitle.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblTitle
      // 
      this.lblTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitle.Location = new System.Drawing.Point(8, 32);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new System.Drawing.Size(128, 16);
      this.lblTitle.TabIndex = 6;
      this.lblTitle.Text = "&Title:";
      // 
      // lblAlbum
      // 
      this.lblAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAlbum.Location = new System.Drawing.Point(8, 56);
      this.lblAlbum.Name = "lblAlbum";
      this.lblAlbum.Size = new System.Drawing.Size(128, 16);
      this.lblAlbum.TabIndex = 9;
      this.lblAlbum.Text = "Al&bum:";
      // 
      // lblPosMedia
      // 
      this.lblPosMedia.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPosMedia.Location = new System.Drawing.Point(368, 104);
      this.lblPosMedia.Name = "lblPosMedia";
      this.lblPosMedia.Size = new System.Drawing.Size(120, 16);
      this.lblPosMedia.TabIndex = 23;
      this.lblPosMedia.Text = "Position in media &set:";
      // 
      // lblYear
      // 
      this.lblYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblYear.Location = new System.Drawing.Point(8, 80);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new System.Drawing.Size(128, 16);
      this.lblYear.TabIndex = 12;
      this.lblYear.Text = "&Year (date) of recording:";
      // 
      // lblTrack
      // 
      this.lblTrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTrack.Location = new System.Drawing.Point(8, 104);
      this.lblTrack.Name = "lblTrack";
      this.lblTrack.Size = new System.Drawing.Size(128, 16);
      this.lblTrack.TabIndex = 19;
      this.lblTrack.Text = "Trac&k number:";
      // 
      // lblArtist
      // 
      this.lblArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblArtist.Location = new System.Drawing.Point(8, 8);
      this.lblArtist.Name = "lblArtist";
      this.lblArtist.Size = new System.Drawing.Size(128, 16);
      this.lblArtist.TabIndex = 3;
      this.lblArtist.Text = "Lead &Artist:";
      // 
      // Panel10
      // 
      this.Panel10.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.Panel10.Size = new System.Drawing.Size(648, 200);
      this.Panel10.TabIndex = 4;
      // 
      // txtCOMMInfURL
      // 
      this.txtCOMMInfURL.Location = new System.Drawing.Point(200, 174);
      this.txtCOMMInfURL.Name = "txtCOMMInfURL";
      this.txtCOMMInfURL.Size = new System.Drawing.Size(440, 20);
      this.txtCOMMInfURL.TabIndex = 17;
      this.txtCOMMInfURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtCOMMInfURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblCOMMInfURL
      // 
      this.lblCOMMInfURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCOMMInfURL.Location = new System.Drawing.Point(8, 176);
      this.lblCOMMInfURL.Name = "lblCOMMInfURL";
      this.lblCOMMInfURL.Size = new System.Drawing.Size(184, 16);
      this.lblCOMMInfURL.TabIndex = 16;
      this.lblCOMMInfURL.Text = "Commercial information URL:";
      // 
      // txtPubURL
      // 
      this.txtPubURL.Location = new System.Drawing.Point(200, 150);
      this.txtPubURL.Name = "txtPubURL";
      this.txtPubURL.Size = new System.Drawing.Size(440, 20);
      this.txtPubURL.TabIndex = 15;
      this.txtPubURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPubURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblPubURL
      // 
      this.lblPubURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPubURL.Location = new System.Drawing.Point(8, 152);
      this.lblPubURL.Name = "lblPubURL";
      this.lblPubURL.Size = new System.Drawing.Size(184, 16);
      this.lblPubURL.TabIndex = 14;
      this.lblPubURL.Text = "Offical publisher URL:";
      // 
      // txtPayURL
      // 
      this.txtPayURL.Location = new System.Drawing.Point(200, 126);
      this.txtPayURL.Name = "txtPayURL";
      this.txtPayURL.Size = new System.Drawing.Size(440, 20);
      this.txtPayURL.TabIndex = 13;
      this.txtPayURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPayURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblPayURL
      // 
      this.lblPayURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPayURL.Location = new System.Drawing.Point(8, 128);
      this.lblPayURL.Name = "lblPayURL";
      this.lblPayURL.Size = new System.Drawing.Size(184, 16);
      this.lblPayURL.TabIndex = 12;
      this.lblPayURL.Text = "Offical payment URL:";
      // 
      // txtINetRadioURL
      // 
      this.txtINetRadioURL.Location = new System.Drawing.Point(200, 102);
      this.txtINetRadioURL.Name = "txtINetRadioURL";
      this.txtINetRadioURL.Size = new System.Drawing.Size(440, 20);
      this.txtINetRadioURL.TabIndex = 11;
      this.txtINetRadioURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtINetRadioURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblINetRadioURL
      // 
      this.lblINetRadioURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblINetRadioURL.Location = new System.Drawing.Point(8, 104);
      this.lblINetRadioURL.Name = "lblINetRadioURL";
      this.lblINetRadioURL.Size = new System.Drawing.Size(184, 16);
      this.lblINetRadioURL.TabIndex = 10;
      this.lblINetRadioURL.Text = "Offical internet radio station URL:";
      // 
      // txtAudioSRCURL
      // 
      this.txtAudioSRCURL.Location = new System.Drawing.Point(200, 78);
      this.txtAudioSRCURL.Name = "txtAudioSRCURL";
      this.txtAudioSRCURL.Size = new System.Drawing.Size(440, 20);
      this.txtAudioSRCURL.TabIndex = 9;
      this.txtAudioSRCURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtAudioSRCURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblAudioSRCURL
      // 
      this.lblAudioSRCURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAudioSRCURL.Location = new System.Drawing.Point(8, 80);
      this.lblAudioSRCURL.Name = "lblAudioSRCURL";
      this.lblAudioSRCURL.Size = new System.Drawing.Size(184, 16);
      this.lblAudioSRCURL.TabIndex = 8;
      this.lblAudioSRCURL.Text = "Offical audio source URL:";
      // 
      // txtCopyInfURL
      // 
      this.txtCopyInfURL.Location = new System.Drawing.Point(200, 6);
      this.txtCopyInfURL.Name = "txtCopyInfURL";
      this.txtCopyInfURL.Size = new System.Drawing.Size(440, 20);
      this.txtCopyInfURL.TabIndex = 3;
      this.txtCopyInfURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtCopyInfURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtArtistURL
      // 
      this.txtArtistURL.Location = new System.Drawing.Point(200, 54);
      this.txtArtistURL.Name = "txtArtistURL";
      this.txtArtistURL.Size = new System.Drawing.Size(440, 20);
      this.txtArtistURL.TabIndex = 7;
      this.txtArtistURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtArtistURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtAudioFileURL
      // 
      this.txtAudioFileURL.Location = new System.Drawing.Point(200, 30);
      this.txtAudioFileURL.Name = "txtAudioFileURL";
      this.txtAudioFileURL.Size = new System.Drawing.Size(440, 20);
      this.txtAudioFileURL.TabIndex = 5;
      this.txtAudioFileURL.Enter += new System.EventHandler(this.Select_Enter);
      this.txtAudioFileURL.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblAudioFileURL
      // 
      this.lblAudioFileURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAudioFileURL.Location = new System.Drawing.Point(8, 32);
      this.lblAudioFileURL.Name = "lblAudioFileURL";
      this.lblAudioFileURL.Size = new System.Drawing.Size(184, 16);
      this.lblAudioFileURL.TabIndex = 4;
      this.lblAudioFileURL.Text = "Offical audio file URL:";
      // 
      // lblArtistURL
      // 
      this.lblArtistURL.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblArtistURL.Location = new System.Drawing.Point(8, 56);
      this.lblArtistURL.Name = "lblArtistURL";
      this.lblArtistURL.Size = new System.Drawing.Size(184, 16);
      this.lblArtistURL.TabIndex = 6;
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
      // Panel11
      // 
      this.Panel11.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.Panel11.Size = new System.Drawing.Size(648, 280);
      this.Panel11.TabIndex = 5;
      // 
      // lblInfo
      // 
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(136, 208);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(496, 56);
      this.lblInfo.TabIndex = 43;
      this.lblInfo.Text = "The rating is 1-255 where 1 is worst and 255 is best. Note that many programs hav" +
    "e their own rating scale. The scale 1-255 is given by the ID3 standard and the o" +
    "ther programs rescale it.";
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnMoveRating
      // 
      this.btnMoveRating.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnMoveRating.Location = new System.Drawing.Point(472, 80);
      this.btnMoveRating.Name = "btnMoveRating";
      this.btnMoveRating.Size = new System.Drawing.Size(160, 24);
      this.btnMoveRating.TabIndex = 26;
      this.btnMoveRating.Text = "Move Rating to top";
      this.btnMoveRating.Click += new System.EventHandler(this.btnMoveRating_Click);
      // 
      // btnRemoveRating
      // 
      this.btnRemoveRating.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveRating.Location = new System.Drawing.Point(304, 80);
      this.btnRemoveRating.Name = "btnRemoveRating";
      this.btnRemoveRating.Size = new System.Drawing.Size(160, 24);
      this.btnRemoveRating.TabIndex = 25;
      this.btnRemoveRating.Text = "Remove Rating";
      this.btnRemoveRating.Click += new System.EventHandler(this.btnRemoveRating_Click);
      // 
      // btnAddRating
      // 
      this.btnAddRating.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddRating.Location = new System.Drawing.Point(136, 80);
      this.btnAddRating.Name = "btnAddRating";
      this.btnAddRating.Size = new System.Drawing.Size(160, 24);
      this.btnAddRating.TabIndex = 24;
      this.btnAddRating.Text = "Add Rating";
      this.btnAddRating.Click += new System.EventHandler(this.btnAddRating_Click);
      // 
      // RatingList
      // 
      this.RatingList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader8,
            this.ColumnHeader9,
            this.ColumnHeader10});
      this.RatingList.FullRowSelect = true;
      this.RatingList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.RatingList.HideSelection = false;
      this.RatingList.Location = new System.Drawing.Point(136, 112);
      this.RatingList.MultiSelect = false;
      this.RatingList.Name = "RatingList";
      this.RatingList.Size = new System.Drawing.Size(496, 88);
      this.RatingList.TabIndex = 27;
      this.RatingList.UseCompatibleStateImageBehavior = false;
      this.RatingList.View = System.Windows.Forms.View.Details;
      this.RatingList.Click += new System.EventHandler(this.RatingList_Click);
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
      this.txtRatingCounter.TabIndex = 23;
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
      this.txtRatingRating.TabIndex = 21;
      this.txtRatingRating.Enter += new System.EventHandler(this.Select_Enter);
      this.txtRatingRating.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtRatingUser
      // 
      this.txtRatingUser.Location = new System.Drawing.Point(136, 6);
      this.txtRatingUser.Name = "txtRatingUser";
      this.txtRatingUser.Size = new System.Drawing.Size(224, 20);
      this.txtRatingUser.TabIndex = 19;
      this.txtRatingUser.Enter += new System.EventHandler(this.Select_Enter);
      this.txtRatingUser.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblRatingRating
      // 
      this.lblRatingRating.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblRatingRating.Location = new System.Drawing.Point(8, 32);
      this.lblRatingRating.Name = "lblRatingRating";
      this.lblRatingRating.Size = new System.Drawing.Size(120, 16);
      this.lblRatingRating.TabIndex = 20;
      this.lblRatingRating.Text = "Rating:";
      // 
      // lblRatingCounter
      // 
      this.lblRatingCounter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblRatingCounter.Location = new System.Drawing.Point(8, 56);
      this.lblRatingCounter.Name = "lblRatingCounter";
      this.lblRatingCounter.Size = new System.Drawing.Size(120, 16);
      this.lblRatingCounter.TabIndex = 22;
      this.lblRatingCounter.Text = "Play counter:";
      // 
      // lblRatingUser
      // 
      this.lblRatingUser.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblRatingUser.Location = new System.Drawing.Point(8, 8);
      this.lblRatingUser.Name = "lblRatingUser";
      this.lblRatingUser.Size = new System.Drawing.Size(120, 16);
      this.lblRatingUser.TabIndex = 18;
      this.lblRatingUser.Text = "User (email):";
      // 
      // Panel12
      // 
      this.Panel12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel12.Controls.Add(this.txtTXXXContent);
      this.Panel12.Controls.Add(this.btnRemoveTXXX);
      this.Panel12.Controls.Add(this.btnAddTXXX);
      this.Panel12.Controls.Add(this.lblTXXXContent);
      this.Panel12.Controls.Add(this.lblTXXXDesc);
      this.Panel12.Controls.Add(this.txtTXXXDesc);
      this.Panel12.Controls.Add(this.TXXXList);
      this.Panel12.Location = new System.Drawing.Point(8, 8);
      this.Panel12.Name = "Panel12";
      this.Panel12.Size = new System.Drawing.Size(648, 176);
      this.Panel12.TabIndex = 0;
      // 
      // txtTXXXContent
      // 
      this.txtTXXXContent.Location = new System.Drawing.Point(136, 30);
      this.txtTXXXContent.Name = "txtTXXXContent";
      this.txtTXXXContent.Size = new System.Drawing.Size(344, 20);
      this.txtTXXXContent.TabIndex = 5;
      this.txtTXXXContent.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTXXXContent.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnRemoveTXXX
      // 
      this.btnRemoveTXXX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveTXXX.Location = new System.Drawing.Point(488, 32);
      this.btnRemoveTXXX.Name = "btnRemoveTXXX";
      this.btnRemoveTXXX.Size = new System.Drawing.Size(152, 20);
      this.btnRemoveTXXX.TabIndex = 7;
      this.btnRemoveTXXX.Text = "Remove user text frame";
      this.btnRemoveTXXX.Click += new System.EventHandler(this.btnRemoveTXXX_Click);
      // 
      // btnAddTXXX
      // 
      this.btnAddTXXX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddTXXX.Location = new System.Drawing.Point(488, 8);
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
      this.txtTXXXDesc.Size = new System.Drawing.Size(344, 20);
      this.txtTXXXDesc.TabIndex = 3;
      this.txtTXXXDesc.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTXXXDesc.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // TXXXList
      // 
      this.TXXXList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader11,
            this.ColumnHeader12});
      this.TXXXList.FullRowSelect = true;
      this.TXXXList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.TXXXList.HideSelection = false;
      this.TXXXList.Location = new System.Drawing.Point(136, 64);
      this.TXXXList.MultiSelect = false;
      this.TXXXList.Name = "TXXXList";
      this.TXXXList.Size = new System.Drawing.Size(504, 104);
      this.TXXXList.TabIndex = 8;
      this.TXXXList.UseCompatibleStateImageBehavior = false;
      this.TXXXList.View = System.Windows.Forms.View.Details;
      this.TXXXList.Click += new System.EventHandler(this.TXXXList_Click);
      this.TXXXList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // Panel13
      // 
      this.Panel13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel13.Controls.Add(this.txtWXXXContent);
      this.Panel13.Controls.Add(this.btnRemoveWXXX);
      this.Panel13.Controls.Add(this.btnAddWXXX);
      this.Panel13.Controls.Add(this.lblWXXXContent);
      this.Panel13.Controls.Add(this.lblWXXXDesc);
      this.Panel13.Controls.Add(this.txtWXXXDesc);
      this.Panel13.Controls.Add(this.WXXXList);
      this.Panel13.Location = new System.Drawing.Point(8, 192);
      this.Panel13.Name = "Panel13";
      this.Panel13.Size = new System.Drawing.Size(648, 176);
      this.Panel13.TabIndex = 1;
      // 
      // txtWXXXContent
      // 
      this.txtWXXXContent.Location = new System.Drawing.Point(136, 30);
      this.txtWXXXContent.Name = "txtWXXXContent";
      this.txtWXXXContent.Size = new System.Drawing.Size(344, 20);
      this.txtWXXXContent.TabIndex = 12;
      this.txtWXXXContent.Enter += new System.EventHandler(this.Select_Enter);
      this.txtWXXXContent.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnRemoveWXXX
      // 
      this.btnRemoveWXXX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveWXXX.Location = new System.Drawing.Point(488, 32);
      this.btnRemoveWXXX.Name = "btnRemoveWXXX";
      this.btnRemoveWXXX.Size = new System.Drawing.Size(152, 20);
      this.btnRemoveWXXX.TabIndex = 14;
      this.btnRemoveWXXX.Text = "Remove user web frame";
      this.btnRemoveWXXX.Click += new System.EventHandler(this.btnRemoveWXXX_Click);
      // 
      // btnAddWXXX
      // 
      this.btnAddWXXX.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddWXXX.Location = new System.Drawing.Point(488, 8);
      this.btnAddWXXX.Name = "btnAddWXXX";
      this.btnAddWXXX.Size = new System.Drawing.Size(152, 20);
      this.btnAddWXXX.TabIndex = 13;
      this.btnAddWXXX.Text = "Add user web frame";
      this.btnAddWXXX.Click += new System.EventHandler(this.btnAddWXXX_Click);
      // 
      // lblWXXXContent
      // 
      this.lblWXXXContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblWXXXContent.Location = new System.Drawing.Point(8, 32);
      this.lblWXXXContent.Name = "lblWXXXContent";
      this.lblWXXXContent.Size = new System.Drawing.Size(128, 16);
      this.lblWXXXContent.TabIndex = 11;
      this.lblWXXXContent.Text = "Web frame &Content:";
      // 
      // lblWXXXDesc
      // 
      this.lblWXXXDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblWXXXDesc.Location = new System.Drawing.Point(8, 8);
      this.lblWXXXDesc.Name = "lblWXXXDesc";
      this.lblWXXXDesc.Size = new System.Drawing.Size(128, 16);
      this.lblWXXXDesc.TabIndex = 9;
      this.lblWXXXDesc.Text = "Web frame &Descriptor:";
      // 
      // txtWXXXDesc
      // 
      this.txtWXXXDesc.Location = new System.Drawing.Point(136, 6);
      this.txtWXXXDesc.Name = "txtWXXXDesc";
      this.txtWXXXDesc.Size = new System.Drawing.Size(344, 20);
      this.txtWXXXDesc.TabIndex = 10;
      this.txtWXXXDesc.Enter += new System.EventHandler(this.Select_Enter);
      this.txtWXXXDesc.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // WXXXList
      // 
      this.WXXXList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader13,
            this.ColumnHeader14});
      this.WXXXList.FullRowSelect = true;
      this.WXXXList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.WXXXList.HideSelection = false;
      this.WXXXList.Location = new System.Drawing.Point(136, 64);
      this.WXXXList.MultiSelect = false;
      this.WXXXList.Name = "WXXXList";
      this.WXXXList.Size = new System.Drawing.Size(504, 104);
      this.WXXXList.TabIndex = 15;
      this.WXXXList.UseCompatibleStateImageBehavior = false;
      this.WXXXList.View = System.Windows.Forms.View.Details;
      this.WXXXList.Click += new System.EventHandler(this.WXXXList_Click);
      this.WXXXList.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // Panel14
      // 
      this.Panel14.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel14.Controls.Add(this.btnTLEN);
      this.Panel14.Controls.Add(this.txtTLEN);
      this.Panel14.Controls.Add(this.lblTLEN);
      this.Panel14.Controls.Add(this.cmbMedia);
      this.Panel14.Controls.Add(this.lblMediaTyp);
      this.Panel14.Location = new System.Drawing.Point(8, 368);
      this.Panel14.Name = "Panel14";
      this.Panel14.Size = new System.Drawing.Size(648, 64);
      this.Panel14.TabIndex = 3;
      // 
      // btnTLEN
      // 
      this.btnTLEN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnTLEN.Location = new System.Drawing.Point(312, 32);
      this.btnTLEN.Name = "btnTLEN";
      this.btnTLEN.Size = new System.Drawing.Size(112, 20);
      this.btnTLEN.TabIndex = 30;
      this.btnTLEN.Text = "Length from file";
      this.btnTLEN.Click += new System.EventHandler(this.btnTLEN_Click);
      // 
      // txtTLEN
      // 
      this.txtTLEN.Location = new System.Drawing.Point(168, 32);
      this.txtTLEN.Name = "txtTLEN";
      this.txtTLEN.Size = new System.Drawing.Size(136, 20);
      this.txtTLEN.TabIndex = 29;
      // 
      // lblTLEN
      // 
      this.lblTLEN.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTLEN.Location = new System.Drawing.Point(8, 32);
      this.lblTLEN.Name = "lblTLEN";
      this.lblTLEN.Size = new System.Drawing.Size(152, 16);
      this.lblTLEN.TabIndex = 28;
      this.lblTLEN.Text = "Track length (msec):";
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
      this.cmbMedia.Location = new System.Drawing.Point(168, 6);
      this.cmbMedia.Name = "cmbMedia";
      this.cmbMedia.Size = new System.Drawing.Size(256, 21);
      this.cmbMedia.TabIndex = 18;
      this.cmbMedia.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbMedia.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblMediaTyp
      // 
      this.lblMediaTyp.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblMediaTyp.Location = new System.Drawing.Point(8, 8);
      this.lblMediaTyp.Name = "lblMediaTyp";
      this.lblMediaTyp.Size = new System.Drawing.Size(152, 16);
      this.lblMediaTyp.TabIndex = 17;
      this.lblMediaTyp.Text = "M&edia type:";
      // 
      // Panel15
      // 
      this.Panel15.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.Panel15.Size = new System.Drawing.Size(648, 144);
      this.Panel15.TabIndex = 5;
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
      this.txtMusicianName.Size = new System.Drawing.Size(320, 20);
      this.txtMusicianName.TabIndex = 12;
      this.txtMusicianName.Enter += new System.EventHandler(this.Select_Enter);
      this.txtMusicianName.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnRemoveMusician
      // 
      this.btnRemoveMusician.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveMusician.Location = new System.Drawing.Point(488, 32);
      this.btnRemoveMusician.Name = "btnRemoveMusician";
      this.btnRemoveMusician.Size = new System.Drawing.Size(152, 20);
      this.btnRemoveMusician.TabIndex = 14;
      this.btnRemoveMusician.Text = "Remove musician";
      this.btnRemoveMusician.Click += new System.EventHandler(this.btnRemoveMusican_Click);
      // 
      // btnAddMusician
      // 
      this.btnAddMusician.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddMusician.Location = new System.Drawing.Point(488, 8);
      this.btnAddMusician.Name = "btnAddMusician";
      this.btnAddMusician.Size = new System.Drawing.Size(152, 20);
      this.btnAddMusician.TabIndex = 13;
      this.btnAddMusician.Text = "Add musician";
      this.btnAddMusician.Click += new System.EventHandler(this.btnAddMusican_Click);
      // 
      // lblMusicianName
      // 
      this.lblMusicianName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblMusicianName.Location = new System.Drawing.Point(8, 32);
      this.lblMusicianName.Name = "lblMusicianName";
      this.lblMusicianName.Size = new System.Drawing.Size(128, 16);
      this.lblMusicianName.TabIndex = 11;
      this.lblMusicianName.Text = "Musician name:";
      // 
      // lblMusicianInst
      // 
      this.lblMusicianInst.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblMusicianInst.Location = new System.Drawing.Point(8, 8);
      this.lblMusicianInst.Name = "lblMusicianInst";
      this.lblMusicianInst.Size = new System.Drawing.Size(128, 16);
      this.lblMusicianInst.TabIndex = 9;
      this.lblMusicianInst.Text = "Musician instrument:";
      // 
      // txtMusicianInst
      // 
      this.txtMusicianInst.Location = new System.Drawing.Point(160, 6);
      this.txtMusicianInst.Name = "txtMusicianInst";
      this.txtMusicianInst.Size = new System.Drawing.Size(320, 20);
      this.txtMusicianInst.TabIndex = 10;
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
      this.TMCLList.HideSelection = false;
      this.TMCLList.Location = new System.Drawing.Point(160, 64);
      this.TMCLList.MultiSelect = false;
      this.TMCLList.Name = "TMCLList";
      this.TMCLList.Size = new System.Drawing.Size(480, 72);
      this.TMCLList.TabIndex = 15;
      this.TMCLList.UseCompatibleStateImageBehavior = false;
      this.TMCLList.View = System.Windows.Forms.View.Details;
      this.TMCLList.Click += new System.EventHandler(this.TMCLList_Click);
      // 
      // Panel16
      // 
      this.Panel16.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel16.Controls.Add(this.txtInvPerson);
      this.Panel16.Controls.Add(this.btnRemoveInv);
      this.Panel16.Controls.Add(this.btnAddInv);
      this.Panel16.Controls.Add(this.lblInvPerson);
      this.Panel16.Controls.Add(this.lblInvFunction);
      this.Panel16.Controls.Add(this.txtInvFunction);
      this.Panel16.Controls.Add(this.TIPLList);
      this.Panel16.Location = new System.Drawing.Point(8, 8);
      this.Panel16.Name = "Panel16";
      this.Panel16.Size = new System.Drawing.Size(648, 144);
      this.Panel16.TabIndex = 4;
      // 
      // txtInvPerson
      // 
      this.txtInvPerson.Location = new System.Drawing.Point(160, 30);
      this.txtInvPerson.Name = "txtInvPerson";
      this.txtInvPerson.Size = new System.Drawing.Size(320, 20);
      this.txtInvPerson.TabIndex = 5;
      this.txtInvPerson.Enter += new System.EventHandler(this.Select_Enter);
      this.txtInvPerson.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnRemoveInv
      // 
      this.btnRemoveInv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveInv.Location = new System.Drawing.Point(488, 32);
      this.btnRemoveInv.Name = "btnRemoveInv";
      this.btnRemoveInv.Size = new System.Drawing.Size(152, 20);
      this.btnRemoveInv.TabIndex = 7;
      this.btnRemoveInv.Text = "Remove involved person";
      this.btnRemoveInv.Click += new System.EventHandler(this.btnRemoveInv_Click);
      // 
      // btnAddInv
      // 
      this.btnAddInv.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddInv.Location = new System.Drawing.Point(488, 8);
      this.btnAddInv.Name = "btnAddInv";
      this.btnAddInv.Size = new System.Drawing.Size(152, 20);
      this.btnAddInv.TabIndex = 6;
      this.btnAddInv.Text = "Add involved person";
      this.btnAddInv.Click += new System.EventHandler(this.btnAddInv_Click);
      // 
      // lblInvPerson
      // 
      this.lblInvPerson.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInvPerson.Location = new System.Drawing.Point(8, 32);
      this.lblInvPerson.Name = "lblInvPerson";
      this.lblInvPerson.Size = new System.Drawing.Size(144, 16);
      this.lblInvPerson.TabIndex = 4;
      this.lblInvPerson.Text = "Involved person name:";
      // 
      // lblInvFunction
      // 
      this.lblInvFunction.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInvFunction.Location = new System.Drawing.Point(8, 8);
      this.lblInvFunction.Name = "lblInvFunction";
      this.lblInvFunction.Size = new System.Drawing.Size(144, 16);
      this.lblInvFunction.TabIndex = 2;
      this.lblInvFunction.Text = "Involved person function:";
      // 
      // txtInvFunction
      // 
      this.txtInvFunction.Location = new System.Drawing.Point(160, 6);
      this.txtInvFunction.Name = "txtInvFunction";
      this.txtInvFunction.Size = new System.Drawing.Size(320, 20);
      this.txtInvFunction.TabIndex = 3;
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
      this.TIPLList.HideSelection = false;
      this.TIPLList.Location = new System.Drawing.Point(160, 64);
      this.TIPLList.MultiSelect = false;
      this.TIPLList.Name = "TIPLList";
      this.TIPLList.Size = new System.Drawing.Size(480, 72);
      this.TIPLList.TabIndex = 8;
      this.TIPLList.UseCompatibleStateImageBehavior = false;
      this.TIPLList.View = System.Windows.Forms.View.Details;
      this.TIPLList.Click += new System.EventHandler(this.TIPLList_Click);
      // 
      // Panel2
      // 
      this.Panel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel2.Controls.Add(this.cmbGenre);
      this.Panel2.Controls.Add(this.btnV1Genre);
      this.Panel2.Controls.Add(this.lblGenreInfo);
      this.Panel2.Controls.Add(this.btnMoveGenre);
      this.Panel2.Controls.Add(this.btnRemoveGenre);
      this.Panel2.Controls.Add(this.btnAddGenre);
      this.Panel2.Controls.Add(this.lblGenre);
      this.Panel2.Controls.Add(this.GenreList);
      this.Panel2.Location = new System.Drawing.Point(8, 144);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new System.Drawing.Size(648, 112);
      this.Panel2.TabIndex = 1;
      // 
      // cmbGenre
      // 
      this.cmbGenre.Autocomplete = true;
      this.cmbGenre.ItemHeight = 13;
      this.cmbGenre.Location = new System.Drawing.Point(136, 6);
      this.cmbGenre.Name = "cmbGenre";
      this.cmbGenre.Size = new System.Drawing.Size(232, 21);
      this.cmbGenre.TabIndex = 29;
      this.cmbGenre.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbGenre.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnV1Genre
      // 
      this.btnV1Genre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnV1Genre.Location = new System.Drawing.Point(512, 32);
      this.btnV1Genre.Name = "btnV1Genre";
      this.btnV1Genre.Size = new System.Drawing.Size(128, 20);
      this.btnV1Genre.TabIndex = 33;
      this.btnV1Genre.Text = "<- Ver. 1";
      this.btnV1Genre.Click += new System.EventHandler(this.btnV1Genre_Click);
      // 
      // lblGenreInfo
      // 
      this.lblGenreInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblGenreInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblGenreInfo.Location = new System.Drawing.Point(376, 64);
      this.lblGenreInfo.Name = "lblGenreInfo";
      this.lblGenreInfo.Size = new System.Drawing.Size(264, 40);
      this.lblGenreInfo.TabIndex = 29;
      this.lblGenreInfo.Text = "Note: Many programs only show the first genre entered. So move the important genr" +
    "e to the top of the list.";
      // 
      // btnMoveGenre
      // 
      this.btnMoveGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnMoveGenre.Location = new System.Drawing.Point(376, 32);
      this.btnMoveGenre.Name = "btnMoveGenre";
      this.btnMoveGenre.Size = new System.Drawing.Size(128, 20);
      this.btnMoveGenre.TabIndex = 32;
      this.btnMoveGenre.Text = "Move Genre to top";
      this.btnMoveGenre.Click += new System.EventHandler(this.btnMoveGenre_Click);
      // 
      // btnRemoveGenre
      // 
      this.btnRemoveGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveGenre.Location = new System.Drawing.Point(512, 8);
      this.btnRemoveGenre.Name = "btnRemoveGenre";
      this.btnRemoveGenre.Size = new System.Drawing.Size(128, 20);
      this.btnRemoveGenre.TabIndex = 31;
      this.btnRemoveGenre.Text = "Remove Genre";
      this.btnRemoveGenre.Click += new System.EventHandler(this.btnRemoveGenre_Click);
      // 
      // btnAddGenre
      // 
      this.btnAddGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddGenre.Location = new System.Drawing.Point(376, 8);
      this.btnAddGenre.Name = "btnAddGenre";
      this.btnAddGenre.Size = new System.Drawing.Size(128, 20);
      this.btnAddGenre.TabIndex = 30;
      this.btnAddGenre.Text = "Add Genre";
      this.btnAddGenre.Click += new System.EventHandler(this.btnAddGenre_Click);
      // 
      // lblGenre
      // 
      this.lblGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblGenre.Location = new System.Drawing.Point(8, 8);
      this.lblGenre.Name = "lblGenre";
      this.lblGenre.Size = new System.Drawing.Size(128, 16);
      this.lblGenre.TabIndex = 28;
      this.lblGenre.Text = "&Genre:";
      // 
      // Panel3
      // 
      this.Panel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.Panel3.Location = new System.Drawing.Point(8, 264);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new System.Drawing.Size(648, 184);
      this.Panel3.TabIndex = 2;
      // 
      // lblCommDescInfo
      // 
      this.lblCommDescInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblCommDescInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCommDescInfo.Location = new System.Drawing.Point(8, 112);
      this.lblCommDescInfo.Name = "lblCommDescInfo";
      this.lblCommDescInfo.Size = new System.Drawing.Size(120, 64);
      this.lblCommDescInfo.TabIndex = 47;
      this.lblCommDescInfo.Text = "Predefined comment descriptors can be set under Edit Libraries (Options menu)";
      this.lblCommDescInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cmbCDescriptor
      // 
      this.cmbCDescriptor.Autocomplete = true;
      this.cmbCDescriptor.ItemHeight = 13;
      this.cmbCDescriptor.Location = new System.Drawing.Point(136, 6);
      this.cmbCDescriptor.Name = "cmbCDescriptor";
      this.cmbCDescriptor.Size = new System.Drawing.Size(264, 21);
      this.cmbCDescriptor.TabIndex = 36;
      this.cmbCDescriptor.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbCDescriptor.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // btnV1Comment
      // 
      this.btnV1Comment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnV1Comment.Location = new System.Drawing.Point(408, 80);
      this.btnV1Comment.Name = "btnV1Comment";
      this.btnV1Comment.Size = new System.Drawing.Size(232, 20);
      this.btnV1Comment.TabIndex = 44;
      this.btnV1Comment.Text = "<- Ver. 1";
      this.btnV1Comment.Click += new System.EventHandler(this.btnV1Comment_Click);
      // 
      // btnMoveComment
      // 
      this.btnMoveComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnMoveComment.Location = new System.Drawing.Point(408, 56);
      this.btnMoveComment.Name = "btnMoveComment";
      this.btnMoveComment.Size = new System.Drawing.Size(232, 20);
      this.btnMoveComment.TabIndex = 43;
      this.btnMoveComment.Text = "Move Comment to top";
      this.btnMoveComment.Click += new System.EventHandler(this.btnMoveComment_Click);
      // 
      // btnRemoveComment
      // 
      this.btnRemoveComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveComment.Location = new System.Drawing.Point(408, 32);
      this.btnRemoveComment.Name = "btnRemoveComment";
      this.btnRemoveComment.Size = new System.Drawing.Size(232, 20);
      this.btnRemoveComment.TabIndex = 42;
      this.btnRemoveComment.Text = "Remove Comment";
      this.btnRemoveComment.Click += new System.EventHandler(this.btnRemoveComment_Click);
      // 
      // btnAddComment
      // 
      this.btnAddComment.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddComment.Location = new System.Drawing.Point(408, 8);
      this.btnAddComment.Name = "btnAddComment";
      this.btnAddComment.Size = new System.Drawing.Size(232, 20);
      this.btnAddComment.TabIndex = 41;
      this.btnAddComment.Text = "Add Comment";
      this.btnAddComment.Click += new System.EventHandler(this.btnAddComment_Click);
      // 
      // lblCOMM
      // 
      this.lblCOMM.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCOMM.Location = new System.Drawing.Point(8, 56);
      this.lblCOMM.Name = "lblCOMM";
      this.lblCOMM.Size = new System.Drawing.Size(128, 16);
      this.lblCOMM.TabIndex = 39;
      this.lblCOMM.Text = "&Comment:";
      // 
      // lblCOMMLan
      // 
      this.lblCOMMLan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCOMMLan.Location = new System.Drawing.Point(8, 32);
      this.lblCOMMLan.Name = "lblCOMMLan";
      this.lblCOMMLan.Size = new System.Drawing.Size(128, 16);
      this.lblCOMMLan.TabIndex = 37;
      this.lblCOMMLan.Text = "Comment &Language:";
      // 
      // lblCOMMDesc
      // 
      this.lblCOMMDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCOMMDesc.Location = new System.Drawing.Point(8, 8);
      this.lblCOMMDesc.Name = "lblCOMMDesc";
      this.lblCOMMDesc.Size = new System.Drawing.Size(128, 16);
      this.lblCOMMDesc.TabIndex = 35;
      this.lblCOMMDesc.Text = "Comment &Descriptor:";
      // 
      // cmbCLanguage
      // 
      this.cmbCLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbCLanguage.ItemHeight = 13;
      this.cmbCLanguage.Location = new System.Drawing.Point(136, 30);
      this.cmbCLanguage.Name = "cmbCLanguage";
      this.cmbCLanguage.Size = new System.Drawing.Size(264, 21);
      this.cmbCLanguage.TabIndex = 38;
      this.cmbCLanguage.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbCLanguage.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtComment
      // 
      this.txtComment.AcceptsReturn = true;
      this.txtComment.Location = new System.Drawing.Point(136, 56);
      this.txtComment.Multiline = true;
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new System.Drawing.Size(264, 48);
      this.txtComment.TabIndex = 40;
      this.txtComment.Enter += new System.EventHandler(this.Select_Enter);
      this.txtComment.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // Panel4
      // 
      this.Panel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.Panel4.Location = new System.Drawing.Point(8, 8);
      this.Panel4.Name = "Panel4";
      this.Panel4.Size = new System.Drawing.Size(648, 200);
      this.Panel4.TabIndex = 0;
      // 
      // txtComposer
      // 
      this.txtComposer.Location = new System.Drawing.Point(168, 75);
      this.txtComposer.Name = "txtComposer";
      this.txtComposer.Size = new System.Drawing.Size(472, 20);
      this.txtComposer.TabIndex = 11;
      this.txtComposer.Enter += new System.EventHandler(this.Select_Enter);
      this.txtComposer.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblComposer
      // 
      this.lblComposer.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblComposer.Location = new System.Drawing.Point(8, 77);
      this.lblComposer.Name = "lblComposer";
      this.lblComposer.Size = new System.Drawing.Size(128, 16);
      this.lblComposer.TabIndex = 10;
      this.lblComposer.Text = "Co&mposer:";
      // 
      // txtBand
      // 
      this.txtBand.Location = new System.Drawing.Point(168, 6);
      this.txtBand.Name = "txtBand";
      this.txtBand.Size = new System.Drawing.Size(472, 20);
      this.txtBand.TabIndex = 5;
      this.txtBand.Enter += new System.EventHandler(this.Select_Enter);
      this.txtBand.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtModified
      // 
      this.txtModified.Location = new System.Drawing.Point(168, 52);
      this.txtModified.Name = "txtModified";
      this.txtModified.Size = new System.Drawing.Size(472, 20);
      this.txtModified.TabIndex = 9;
      this.txtModified.Enter += new System.EventHandler(this.Select_Enter);
      this.txtModified.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtConductor
      // 
      this.txtConductor.Location = new System.Drawing.Point(168, 29);
      this.txtConductor.Name = "txtConductor";
      this.txtConductor.Size = new System.Drawing.Size(472, 20);
      this.txtConductor.TabIndex = 7;
      this.txtConductor.Enter += new System.EventHandler(this.Select_Enter);
      this.txtConductor.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblConductor
      // 
      this.lblConductor.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblConductor.Location = new System.Drawing.Point(8, 31);
      this.lblConductor.Name = "lblConductor";
      this.lblConductor.Size = new System.Drawing.Size(128, 16);
      this.lblConductor.TabIndex = 6;
      this.lblConductor.Text = "&Conductor:";
      // 
      // lblModified
      // 
      this.lblModified.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblModified.Location = new System.Drawing.Point(8, 54);
      this.lblModified.Name = "lblModified";
      this.lblModified.Size = new System.Drawing.Size(128, 16);
      this.lblModified.TabIndex = 8;
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
      // txtCopyright
      // 
      this.txtCopyright.Location = new System.Drawing.Point(168, 167);
      this.txtCopyright.Name = "txtCopyright";
      this.txtCopyright.Size = new System.Drawing.Size(472, 20);
      this.txtCopyright.TabIndex = 23;
      this.txtCopyright.Enter += new System.EventHandler(this.Select_Enter);
      this.txtCopyright.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblCopyright
      // 
      this.lblCopyright.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCopyright.Location = new System.Drawing.Point(8, 169);
      this.lblCopyright.Name = "lblCopyright";
      this.lblCopyright.Size = new System.Drawing.Size(128, 16);
      this.lblCopyright.TabIndex = 22;
      this.lblCopyright.Text = "Copyright:";
      // 
      // txtLyWriter
      // 
      this.txtLyWriter.Location = new System.Drawing.Point(168, 98);
      this.txtLyWriter.Name = "txtLyWriter";
      this.txtLyWriter.Size = new System.Drawing.Size(472, 20);
      this.txtLyWriter.TabIndex = 17;
      this.txtLyWriter.Enter += new System.EventHandler(this.Select_Enter);
      this.txtLyWriter.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtEncoded
      // 
      this.txtEncoded.Location = new System.Drawing.Point(168, 144);
      this.txtEncoded.Name = "txtEncoded";
      this.txtEncoded.Size = new System.Drawing.Size(472, 20);
      this.txtEncoded.TabIndex = 21;
      this.txtEncoded.Enter += new System.EventHandler(this.Select_Enter);
      this.txtEncoded.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtPublisher
      // 
      this.txtPublisher.Location = new System.Drawing.Point(168, 121);
      this.txtPublisher.Name = "txtPublisher";
      this.txtPublisher.Size = new System.Drawing.Size(472, 20);
      this.txtPublisher.TabIndex = 19;
      this.txtPublisher.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPublisher.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblPublisher
      // 
      this.lblPublisher.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPublisher.Location = new System.Drawing.Point(8, 123);
      this.lblPublisher.Name = "lblPublisher";
      this.lblPublisher.Size = new System.Drawing.Size(128, 16);
      this.lblPublisher.TabIndex = 18;
      this.lblPublisher.Text = "Publis&her:";
      // 
      // lblEncoded
      // 
      this.lblEncoded.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblEncoded.Location = new System.Drawing.Point(8, 146);
      this.lblEncoded.Name = "lblEncoded";
      this.lblEncoded.Size = new System.Drawing.Size(128, 16);
      this.lblEncoded.TabIndex = 20;
      this.lblEncoded.Text = "&Encoded by:";
      // 
      // lblLyWriter
      // 
      this.lblLyWriter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLyWriter.Location = new System.Drawing.Point(8, 100);
      this.lblLyWriter.Name = "lblLyWriter";
      this.lblLyWriter.Size = new System.Drawing.Size(128, 16);
      this.lblLyWriter.TabIndex = 16;
      this.lblLyWriter.Text = "Lyr&ics / Text Writer:";
      // 
      // Panel5
      // 
      this.Panel5.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel5.Controls.Add(this.txtContent);
      this.Panel5.Controls.Add(this.txtSubTitle);
      this.Panel5.Controls.Add(this.lblSubTitle);
      this.Panel5.Controls.Add(this.lblContent);
      this.Panel5.Location = new System.Drawing.Point(8, 216);
      this.Panel5.Name = "Panel5";
      this.Panel5.Size = new System.Drawing.Size(648, 56);
      this.Panel5.TabIndex = 1;
      // 
      // txtContent
      // 
      this.txtContent.Location = new System.Drawing.Point(168, 6);
      this.txtContent.Name = "txtContent";
      this.txtContent.Size = new System.Drawing.Size(472, 20);
      this.txtContent.TabIndex = 13;
      this.txtContent.Enter += new System.EventHandler(this.Select_Enter);
      this.txtContent.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtSubTitle
      // 
      this.txtSubTitle.Location = new System.Drawing.Point(168, 30);
      this.txtSubTitle.Name = "txtSubTitle";
      this.txtSubTitle.Size = new System.Drawing.Size(472, 20);
      this.txtSubTitle.TabIndex = 15;
      this.txtSubTitle.Enter += new System.EventHandler(this.Select_Enter);
      this.txtSubTitle.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblSubTitle
      // 
      this.lblSubTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblSubTitle.Location = new System.Drawing.Point(8, 32);
      this.lblSubTitle.Name = "lblSubTitle";
      this.lblSubTitle.Size = new System.Drawing.Size(128, 16);
      this.lblSubTitle.TabIndex = 14;
      this.lblSubTitle.Text = "&Sub Title:";
      // 
      // lblContent
      // 
      this.lblContent.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblContent.Location = new System.Drawing.Point(8, 8);
      this.lblContent.Name = "lblContent";
      this.lblContent.Size = new System.Drawing.Size(128, 16);
      this.lblContent.TabIndex = 12;
      this.lblContent.Text = "Con&tent Group:";
      // 
      // Panel6
      // 
      this.Panel6.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.Panel6.Location = new System.Drawing.Point(8, 8);
      this.Panel6.Name = "Panel6";
      this.Panel6.Size = new System.Drawing.Size(648, 152);
      this.Panel6.TabIndex = 3;
      // 
      // txtTORY
      // 
      this.txtTORY.Location = new System.Drawing.Point(168, 126);
      this.txtTORY.Mask = "0000-00-00";
      this.txtTORY.Name = "txtTORY";
      this.txtTORY.Size = new System.Drawing.Size(112, 20);
      this.txtTORY.TabIndex = 33;
      this.txtTORY.Enter += new System.EventHandler(this.Select_Enter);
      this.txtTORY.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblOYearInfo
      // 
      this.lblOYearInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOYearInfo.Location = new System.Drawing.Point(336, 128);
      this.lblOYearInfo.Name = "lblOYearInfo";
      this.lblOYearInfo.Size = new System.Drawing.Size(304, 16);
      this.lblOYearInfo.TabIndex = 36;
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
      this.TORYFormat.TabIndex = 34;
      this.TORYFormat.Scroll += new System.Windows.Forms.ScrollEventHandler(this.TORYFormat_Scroll);
      // 
      // lblOYear
      // 
      this.lblOYear.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOYear.Location = new System.Drawing.Point(8, 128);
      this.lblOYear.Name = "lblOYear";
      this.lblOYear.Size = new System.Drawing.Size(144, 16);
      this.lblOYear.TabIndex = 32;
      this.lblOYear.Text = "Original release &year (date):";
      // 
      // txtOOwner
      // 
      this.txtOOwner.Location = new System.Drawing.Point(168, 102);
      this.txtOOwner.Name = "txtOOwner";
      this.txtOOwner.Size = new System.Drawing.Size(472, 20);
      this.txtOOwner.TabIndex = 31;
      this.txtOOwner.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOOwner.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblOOwner
      // 
      this.lblOOwner.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOOwner.Location = new System.Drawing.Point(8, 104);
      this.lblOOwner.Name = "lblOOwner";
      this.lblOOwner.Size = new System.Drawing.Size(128, 16);
      this.lblOOwner.TabIndex = 30;
      this.lblOOwner.Text = "Original &owner:";
      // 
      // txtOArtist
      // 
      this.txtOArtist.Location = new System.Drawing.Point(168, 78);
      this.txtOArtist.Name = "txtOArtist";
      this.txtOArtist.Size = new System.Drawing.Size(472, 20);
      this.txtOArtist.TabIndex = 29;
      this.txtOArtist.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOArtist.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblOArtist
      // 
      this.lblOArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOArtist.Location = new System.Drawing.Point(8, 80);
      this.lblOArtist.Name = "lblOArtist";
      this.lblOArtist.Size = new System.Drawing.Size(128, 16);
      this.lblOArtist.TabIndex = 28;
      this.lblOArtist.Text = "Original &artist:";
      // 
      // txtOAlbum
      // 
      this.txtOAlbum.Location = new System.Drawing.Point(168, 6);
      this.txtOAlbum.Name = "txtOAlbum";
      this.txtOAlbum.Size = new System.Drawing.Size(472, 20);
      this.txtOAlbum.TabIndex = 23;
      this.txtOAlbum.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOAlbum.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtOLyWriter
      // 
      this.txtOLyWriter.Location = new System.Drawing.Point(168, 54);
      this.txtOLyWriter.Name = "txtOLyWriter";
      this.txtOLyWriter.Size = new System.Drawing.Size(472, 20);
      this.txtOLyWriter.TabIndex = 27;
      this.txtOLyWriter.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOLyWriter.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtOFilename
      // 
      this.txtOFilename.Location = new System.Drawing.Point(168, 30);
      this.txtOFilename.Name = "txtOFilename";
      this.txtOFilename.Size = new System.Drawing.Size(472, 20);
      this.txtOFilename.TabIndex = 25;
      this.txtOFilename.Enter += new System.EventHandler(this.Select_Enter);
      this.txtOFilename.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblOFilename
      // 
      this.lblOFilename.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOFilename.Location = new System.Drawing.Point(8, 32);
      this.lblOFilename.Name = "lblOFilename";
      this.lblOFilename.Size = new System.Drawing.Size(128, 16);
      this.lblOFilename.TabIndex = 24;
      this.lblOFilename.Text = "Original &filename:";
      // 
      // lblOLyWriter
      // 
      this.lblOLyWriter.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOLyWriter.Location = new System.Drawing.Point(8, 56);
      this.lblOLyWriter.Name = "lblOLyWriter";
      this.lblOLyWriter.Size = new System.Drawing.Size(128, 16);
      this.lblOLyWriter.TabIndex = 26;
      this.lblOLyWriter.Text = "Original lyrics &writer:";
      // 
      // lblOAlbum
      // 
      this.lblOAlbum.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblOAlbum.Location = new System.Drawing.Point(8, 8);
      this.lblOAlbum.Name = "lblOAlbum";
      this.lblOAlbum.Size = new System.Drawing.Size(128, 16);
      this.lblOAlbum.TabIndex = 22;
      this.lblOAlbum.Text = "Original a&lbum title:";
      // 
      // Panel7
      // 
      this.Panel7.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.Panel7.Location = new System.Drawing.Point(8, 8);
      this.Panel7.Name = "Panel7";
      this.Panel7.Size = new System.Drawing.Size(648, 288);
      this.Panel7.TabIndex = 0;
      // 
      // chkPicRelativPath
      // 
      this.chkPicRelativPath.Location = new System.Drawing.Point(8, 104);
      this.chkPicRelativPath.Name = "chkPicRelativPath";
      this.chkPicRelativPath.Size = new System.Drawing.Size(448, 16);
      this.chkPicRelativPath.TabIndex = 9;
      this.chkPicRelativPath.Text = "Use relativ path if picture is not included";
      this.chkPicRelativPath.CheckedChanged += new System.EventHandler(this.chkPicRelativPath_CheckedChanged);
      // 
      // btnExPic
      // 
      this.btnExPic.Enabled = false;
      this.btnExPic.Location = new System.Drawing.Point(312, 160);
      this.btnExPic.Name = "btnExPic";
      this.btnExPic.Size = new System.Drawing.Size(144, 24);
      this.btnExPic.TabIndex = 13;
      this.btnExPic.Text = "Extract picture";
      this.btnExPic.Click += new System.EventHandler(this.btnExPic_Click);
      // 
      // btnRemovePicture
      // 
      this.btnRemovePicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemovePicture.Location = new System.Drawing.Point(160, 128);
      this.btnRemovePicture.Name = "btnRemovePicture";
      this.btnRemovePicture.Size = new System.Drawing.Size(144, 24);
      this.btnRemovePicture.TabIndex = 11;
      this.btnRemovePicture.Text = "Remove Picture";
      this.btnRemovePicture.Click += new System.EventHandler(this.btnRemovePicture_Click);
      // 
      // btnAddPicture
      // 
      this.btnAddPicture.Enabled = false;
      this.btnAddPicture.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddPicture.Location = new System.Drawing.Point(8, 128);
      this.btnAddPicture.Name = "btnAddPicture";
      this.btnAddPicture.Size = new System.Drawing.Size(144, 24);
      this.btnAddPicture.TabIndex = 10;
      this.btnAddPicture.Text = "Add Picture";
      this.btnAddPicture.Click += new System.EventHandler(this.btnAddPicture_Click);
      // 
      // btnGetPic
      // 
      this.btnGetPic.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnGetPic.Location = new System.Drawing.Point(312, 128);
      this.btnGetPic.Name = "btnGetPic";
      this.btnGetPic.Size = new System.Drawing.Size(144, 24);
      this.btnGetPic.TabIndex = 12;
      this.btnGetPic.Text = "Get new picture";
      this.btnGetPic.Click += new System.EventHandler(this.btnGetPic_Click);
      // 
      // chkPicInclude
      // 
      this.chkPicInclude.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkPicInclude.Location = new System.Drawing.Point(8, 84);
      this.chkPicInclude.Name = "chkPicInclude";
      this.chkPicInclude.Size = new System.Drawing.Size(448, 16);
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
      this.txtPicPath.Size = new System.Drawing.Size(304, 20);
      this.txtPicPath.TabIndex = 7;
      this.txtPicPath.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPicPath.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // PicList
      // 
      this.PicList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.ColumnHeader4,
            this.ColumnHeader5,
            this.ColumnHeader6,
            this.ColumnHeader7});
      this.PicList.FullRowSelect = true;
      this.PicList.HeaderStyle = System.Windows.Forms.ColumnHeaderStyle.Nonclickable;
      this.PicList.HideSelection = false;
      this.PicList.Location = new System.Drawing.Point(8, 200);
      this.PicList.MultiSelect = false;
      this.PicList.Name = "PicList";
      this.PicList.Size = new System.Drawing.Size(632, 80);
      this.PicList.TabIndex = 14;
      this.PicList.UseCompatibleStateImageBehavior = false;
      this.PicList.View = System.Windows.Forms.View.Details;
      this.PicList.Click += new System.EventHandler(this.PicList_Click);
      this.PicList.Leave += new System.EventHandler(this.Select_Leave);
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
      this.cmbPicType.Size = new System.Drawing.Size(304, 21);
      this.cmbPicType.TabIndex = 5;
      this.cmbPicType.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbPicType.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtPDescriptor
      // 
      this.txtPDescriptor.Location = new System.Drawing.Point(152, 6);
      this.txtPDescriptor.Name = "txtPDescriptor";
      this.txtPDescriptor.Size = new System.Drawing.Size(304, 20);
      this.txtPDescriptor.TabIndex = 3;
      this.txtPDescriptor.Enter += new System.EventHandler(this.Select_Enter);
      this.txtPDescriptor.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // Panel8
      // 
      this.Panel8.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
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
      this.Panel8.Location = new System.Drawing.Point(8, 8);
      this.Panel8.Name = "Panel8";
      this.Panel8.Size = new System.Drawing.Size(648, 440);
      this.Panel8.TabIndex = 1;
      // 
      // txtLyrics
      // 
      this.txtLyrics.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.txtLyrics.Location = new System.Drawing.Point(136, 56);
      this.txtLyrics.Name = "txtLyrics";
      this.txtLyrics.Size = new System.Drawing.Size(504, 192);
      this.txtLyrics.TabIndex = 18;
      this.txtLyrics.Text = "";
      // 
      // btnLyricsFile
      // 
      this.btnLyricsFile.Location = new System.Drawing.Point(136, 256);
      this.btnLyricsFile.Name = "btnLyricsFile";
      this.btnLyricsFile.Size = new System.Drawing.Size(504, 24);
      this.btnLyricsFile.TabIndex = 19;
      this.btnLyricsFile.Text = "Get lyrics from text file";
      this.btnLyricsFile.Click += new System.EventHandler(this.btnLyricsFile_Click);
      // 
      // btnMoveLyrics
      // 
      this.btnMoveLyrics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnMoveLyrics.Location = new System.Drawing.Point(488, 288);
      this.btnMoveLyrics.Name = "btnMoveLyrics";
      this.btnMoveLyrics.Size = new System.Drawing.Size(152, 24);
      this.btnMoveLyrics.TabIndex = 22;
      this.btnMoveLyrics.Text = "Move Lyrics to top";
      this.btnMoveLyrics.Click += new System.EventHandler(this.btnMoveLyrics_Click);
      // 
      // btnRemoveLyrics
      // 
      this.btnRemoveLyrics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveLyrics.Location = new System.Drawing.Point(312, 288);
      this.btnRemoveLyrics.Name = "btnRemoveLyrics";
      this.btnRemoveLyrics.Size = new System.Drawing.Size(152, 24);
      this.btnRemoveLyrics.TabIndex = 21;
      this.btnRemoveLyrics.Text = "Remove Lyrics";
      this.btnRemoveLyrics.Click += new System.EventHandler(this.btnRemoveLyrics_Click);
      // 
      // btnAddLyrics
      // 
      this.btnAddLyrics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddLyrics.Location = new System.Drawing.Point(136, 288);
      this.btnAddLyrics.Name = "btnAddLyrics";
      this.btnAddLyrics.Size = new System.Drawing.Size(152, 24);
      this.btnAddLyrics.TabIndex = 20;
      this.btnAddLyrics.Text = "Add Lyrics";
      this.btnAddLyrics.Click += new System.EventHandler(this.btnAddLyrics_Click);
      // 
      // lblLyrics
      // 
      this.lblLyrics.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLyrics.Location = new System.Drawing.Point(8, 56);
      this.lblLyrics.Name = "lblLyrics";
      this.lblLyrics.Size = new System.Drawing.Size(128, 16);
      this.lblLyrics.TabIndex = 17;
      this.lblLyrics.Text = "&Lyrics Text:";
      // 
      // lblLyLan
      // 
      this.lblLyLan.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLyLan.Location = new System.Drawing.Point(8, 32);
      this.lblLyLan.Name = "lblLyLan";
      this.lblLyLan.Size = new System.Drawing.Size(128, 16);
      this.lblLyLan.TabIndex = 15;
      this.lblLyLan.Text = "Lyrics &Language:";
      // 
      // lblLyDesc
      // 
      this.lblLyDesc.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblLyDesc.Location = new System.Drawing.Point(8, 8);
      this.lblLyDesc.Name = "lblLyDesc";
      this.lblLyDesc.Size = new System.Drawing.Size(128, 16);
      this.lblLyDesc.TabIndex = 13;
      this.lblLyDesc.Text = "Lyrics &Descriptor:";
      // 
      // cmbLLanguage
      // 
      this.cmbLLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbLLanguage.ItemHeight = 13;
      this.cmbLLanguage.Location = new System.Drawing.Point(136, 30);
      this.cmbLLanguage.Name = "cmbLLanguage";
      this.cmbLLanguage.Size = new System.Drawing.Size(208, 21);
      this.cmbLLanguage.TabIndex = 16;
      this.cmbLLanguage.Enter += new System.EventHandler(this.Select_Enter);
      this.cmbLLanguage.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtLDescriptor
      // 
      this.txtLDescriptor.Location = new System.Drawing.Point(136, 6);
      this.txtLDescriptor.Name = "txtLDescriptor";
      this.txtLDescriptor.Size = new System.Drawing.Size(208, 20);
      this.txtLDescriptor.TabIndex = 14;
      this.txtLDescriptor.Enter += new System.EventHandler(this.Select_Enter);
      this.txtLDescriptor.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // Panel9
      // 
      this.Panel9.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.Panel9.Controls.Add(this.txtSortArtist);
      this.Panel9.Controls.Add(this.txtSortTitle);
      this.Panel9.Controls.Add(this.txtSortAlbum);
      this.Panel9.Controls.Add(this.lblAlbumSort);
      this.Panel9.Controls.Add(this.lblTitleSort);
      this.Panel9.Controls.Add(this.lblArtistSort);
      this.Panel9.Location = new System.Drawing.Point(8, 280);
      this.Panel9.Name = "Panel9";
      this.Panel9.Size = new System.Drawing.Size(648, 80);
      this.Panel9.TabIndex = 2;
      // 
      // txtSortArtist
      // 
      this.txtSortArtist.Location = new System.Drawing.Point(168, 6);
      this.txtSortArtist.Name = "txtSortArtist";
      this.txtSortArtist.Size = new System.Drawing.Size(472, 20);
      this.txtSortArtist.TabIndex = 17;
      this.txtSortArtist.Enter += new System.EventHandler(this.Select_Enter);
      this.txtSortArtist.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtSortTitle
      // 
      this.txtSortTitle.Location = new System.Drawing.Point(168, 54);
      this.txtSortTitle.Name = "txtSortTitle";
      this.txtSortTitle.Size = new System.Drawing.Size(472, 20);
      this.txtSortTitle.TabIndex = 21;
      this.txtSortTitle.Enter += new System.EventHandler(this.Select_Enter);
      this.txtSortTitle.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // txtSortAlbum
      // 
      this.txtSortAlbum.Location = new System.Drawing.Point(168, 30);
      this.txtSortAlbum.Name = "txtSortAlbum";
      this.txtSortAlbum.Size = new System.Drawing.Size(472, 20);
      this.txtSortAlbum.TabIndex = 19;
      this.txtSortAlbum.Enter += new System.EventHandler(this.Select_Enter);
      this.txtSortAlbum.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // lblAlbumSort
      // 
      this.lblAlbumSort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblAlbumSort.Location = new System.Drawing.Point(8, 32);
      this.lblAlbumSort.Name = "lblAlbumSort";
      this.lblAlbumSort.Size = new System.Drawing.Size(168, 16);
      this.lblAlbumSort.TabIndex = 18;
      this.lblAlbumSort.Text = "Al&bum sort name (Ver. 2.4 only):";
      // 
      // lblTitleSort
      // 
      this.lblTitleSort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblTitleSort.Location = new System.Drawing.Point(8, 56);
      this.lblTitleSort.Name = "lblTitleSort";
      this.lblTitleSort.Size = new System.Drawing.Size(160, 16);
      this.lblTitleSort.TabIndex = 20;
      this.lblTitleSort.Text = "&Title sort name (Ver. 2.4 only):";
      // 
      // lblArtistSort
      // 
      this.lblArtistSort.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblArtistSort.Location = new System.Drawing.Point(8, 8);
      this.lblArtistSort.Name = "lblArtistSort";
      this.lblArtistSort.Size = new System.Drawing.Size(168, 16);
      this.lblArtistSort.TabIndex = 16;
      this.lblArtistSort.Text = "&Artist sort name (Ver. 2.4 only):";
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(721, 511);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(96, 24);
      this.btnCancel.TabIndex = 104;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // btnOK
      // 
      this.btnOK.BackColor = System.Drawing.SystemColors.Control;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(617, 511);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(96, 24);
      this.btnOK.TabIndex = 103;
      this.btnOK.Text = "&OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // cboFormat
      // 
      this.cboFormat.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboFormat.FormattingEnabled = true;
      this.cboFormat.Location = new System.Drawing.Point(14, 96);
      this.cboFormat.Name = "cboFormat";
      this.cboFormat.Size = new System.Drawing.Size(131, 21);
      this.cboFormat.TabIndex = 4;
      // 
      // label1
      // 
      this.label1.AutoSize = true;
      this.label1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.label1.Location = new System.Drawing.Point(11, 9);
      this.label1.Name = "label1";
      this.label1.Size = new System.Drawing.Size(100, 15);
      this.label1.TabIndex = 0;
      this.label1.Text = "TAG Information";
      // 
      // label2
      // 
      this.label2.AutoSize = true;
      this.label2.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.label2.Location = new System.Drawing.Point(11, 9);
      this.label2.Name = "label2";
      this.label2.Size = new System.Drawing.Size(118, 15);
      this.label2.TabIndex = 0;
      this.label2.Text = "Transfer and Import";
      // 
      // lblCommand
      // 
      this.lblCommand.AutoSize = true;
      this.lblCommand.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.World);
      this.lblCommand.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblCommand.Location = new System.Drawing.Point(11, 9);
      this.lblCommand.Name = "lblCommand";
      this.lblCommand.Size = new System.Drawing.Size(68, 15);
      this.lblCommand.TabIndex = 0;
      this.lblCommand.Text = "Commands";
      // 
      // lblDetailedInfo
      // 
      this.lblDetailedInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblDetailedInfo.AutoSize = true;
      this.lblDetailedInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblDetailedInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblDetailedInfo.Location = new System.Drawing.Point(22, 52);
      this.lblDetailedInfo.Name = "lblDetailedInfo";
      this.lblDetailedInfo.Size = new System.Drawing.Size(101, 13);
      this.lblDetailedInfo.TabIndex = 2;
      this.lblDetailedInfo.TabStop = true;
      this.lblDetailedInfo.Text = "Detailed Information";
      this.lblDetailedInfo.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblDetailedInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblDetailedInfo_LinkClicked);
      // 
      // lblDigits
      // 
      this.lblDigits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.lblDigits.BackColor = System.Drawing.SystemColors.Control;
      this.lblDigits.ForeColor = System.Drawing.Color.Black;
      this.lblDigits.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDigits.Location = new System.Drawing.Point(185, 517);
      this.lblDigits.Name = "lblDigits";
      this.lblDigits.Size = new System.Drawing.Size(184, 16);
      this.lblDigits.TabIndex = 101;
      this.lblDigits.Text = "Number of digits of track numbers:";
      // 
      // lblGetFromFile
      // 
      this.lblGetFromFile.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblGetFromFile.AutoSize = true;
      this.lblGetFromFile.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblGetFromFile.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblGetFromFile.Location = new System.Drawing.Point(22, 73);
      this.lblGetFromFile.Name = "lblGetFromFile";
      this.lblGetFromFile.Size = new System.Drawing.Size(95, 13);
      this.lblGetFromFile.TabIndex = 3;
      this.lblGetFromFile.TabStop = true;
      this.lblGetFromFile.Text = "Get From Filename";
      this.lblGetFromFile.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblGetFromFile.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblGetFromFile_LinkClicked);
      // 
      // lblInvolvedPeople
      // 
      this.lblInvolvedPeople.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblInvolvedPeople.AutoSize = true;
      this.lblInvolvedPeople.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblInvolvedPeople.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblInvolvedPeople.Location = new System.Drawing.Point(22, 94);
      this.lblInvolvedPeople.Name = "lblInvolvedPeople";
      this.lblInvolvedPeople.Size = new System.Drawing.Size(84, 13);
      this.lblInvolvedPeople.TabIndex = 4;
      this.lblInvolvedPeople.TabStop = true;
      this.lblInvolvedPeople.Text = "Involved People";
      this.lblInvolvedPeople.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblInvolvedPeople.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblInvolvedPeople_LinkClicked);
      // 
      // lblLyricsPane
      // 
      this.lblLyricsPane.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblLyricsPane.AutoSize = true;
      this.lblLyricsPane.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblLyricsPane.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblLyricsPane.Location = new System.Drawing.Point(22, 157);
      this.lblLyricsPane.Name = "lblLyricsPane";
      this.lblLyricsPane.Size = new System.Drawing.Size(34, 13);
      this.lblLyricsPane.TabIndex = 7;
      this.lblLyricsPane.TabStop = true;
      this.lblLyricsPane.Text = "Lyrics";
      this.lblLyricsPane.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblLyricsPane.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblLyricsPane_LinkClicked);
      // 
      // lblMainEntries
      // 
      this.lblMainEntries.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblMainEntries.AutoSize = true;
      this.lblMainEntries.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblMainEntries.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblMainEntries.Location = new System.Drawing.Point(22, 31);
      this.lblMainEntries.Name = "lblMainEntries";
      this.lblMainEntries.Size = new System.Drawing.Size(65, 13);
      this.lblMainEntries.TabIndex = 1;
      this.lblMainEntries.TabStop = true;
      this.lblMainEntries.Text = "Main Entries";
      this.lblMainEntries.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblMainEntries.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblMainEntries_LinkClicked);
      // 
      // lblNext
      // 
      this.lblNext.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblNext.AutoSize = true;
      this.lblNext.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblNext.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblNext.Location = new System.Drawing.Point(22, 52);
      this.lblNext.Name = "lblNext";
      this.lblNext.Size = new System.Drawing.Size(48, 13);
      this.lblNext.TabIndex = 2;
      this.lblNext.TabStop = true;
      this.lblNext.Text = "Next File";
      this.lblNext.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblNext.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblNext_LinkClicked);
      // 
      // lblNot
      // 
      this.lblNot.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblNot.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblNot.Location = new System.Drawing.Point(8, 408);
      this.lblNot.Name = "lblNot";
      this.lblNot.Size = new System.Drawing.Size(648, 40);
      this.lblNot.TabIndex = 44;
      this.lblNot.Text = "All frames which are not supported by ID3-TagIT. You cannot edit them but you can" +
    " remove them by unchecking the checkbox.";
      this.lblNot.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // lblOriginalInfo
      // 
      this.lblOriginalInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblOriginalInfo.AutoSize = true;
      this.lblOriginalInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblOriginalInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblOriginalInfo.Location = new System.Drawing.Point(22, 73);
      this.lblOriginalInfo.Name = "lblOriginalInfo";
      this.lblOriginalInfo.Size = new System.Drawing.Size(97, 13);
      this.lblOriginalInfo.TabIndex = 3;
      this.lblOriginalInfo.TabStop = true;
      this.lblOriginalInfo.Text = "Original Information";
      this.lblOriginalInfo.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblOriginalInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblOriginalInfo_LinkClicked);
      // 
      // lblPictures
      // 
      this.lblPictures.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblPictures.AutoSize = true;
      this.lblPictures.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblPictures.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblPictures.Location = new System.Drawing.Point(22, 136);
      this.lblPictures.Name = "lblPictures";
      this.lblPictures.Size = new System.Drawing.Size(45, 13);
      this.lblPictures.TabIndex = 6;
      this.lblPictures.TabStop = true;
      this.lblPictures.Text = "Pictures";
      this.lblPictures.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblPictures.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPictures_LinkClicked);
      // 
      // lblPrevious
      // 
      this.lblPrevious.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblPrevious.AutoSize = true;
      this.lblPrevious.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblPrevious.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblPrevious.Location = new System.Drawing.Point(22, 31);
      this.lblPrevious.Name = "lblPrevious";
      this.lblPrevious.Size = new System.Drawing.Size(67, 13);
      this.lblPrevious.TabIndex = 1;
      this.lblPrevious.TabStop = true;
      this.lblPrevious.Text = "Previous File";
      this.lblPrevious.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblPrevious.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblPrevious_LinkClicked);
      // 
      // lblRating
      // 
      this.lblRating.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblRating.AutoSize = true;
      this.lblRating.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblRating.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblRating.Location = new System.Drawing.Point(22, 178);
      this.lblRating.Name = "lblRating";
      this.lblRating.Size = new System.Drawing.Size(38, 13);
      this.lblRating.TabIndex = 8;
      this.lblRating.TabStop = true;
      this.lblRating.Text = "Rating";
      this.lblRating.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblRating.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblRating_LinkClicked);
      // 
      // lblSelected
      // 
      this.lblSelected.BackColor = System.Drawing.SystemColors.Control;
      this.lblSelected.ForeColor = System.Drawing.Color.Black;
      this.lblSelected.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblSelected.Location = new System.Drawing.Point(174, 29);
      this.lblSelected.Name = "lblSelected";
      this.lblSelected.Size = new System.Drawing.Size(104, 16);
      this.lblSelected.TabIndex = 107;
      this.lblSelected.Text = "Selected file:";
      // 
      // lblSwapArtAlb
      // 
      this.lblSwapArtAlb.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblSwapArtAlb.AutoSize = true;
      this.lblSwapArtAlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtAlb.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtAlb.Location = new System.Drawing.Point(22, 94);
      this.lblSwapArtAlb.Name = "lblSwapArtAlb";
      this.lblSwapArtAlb.Size = new System.Drawing.Size(92, 13);
      this.lblSwapArtAlb.TabIndex = 4;
      this.lblSwapArtAlb.TabStop = true;
      this.lblSwapArtAlb.Text = "Swap Artist-Album";
      this.lblSwapArtAlb.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtAlb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSwapArtAlb_LinkClicked);
      // 
      // lblSwapTtlAlb
      // 
      this.lblSwapTtlAlb.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblSwapTtlAlb.AutoSize = true;
      this.lblSwapTtlAlb.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapTtlAlb.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapTtlAlb.Location = new System.Drawing.Point(22, 115);
      this.lblSwapTtlAlb.Name = "lblSwapTtlAlb";
      this.lblSwapTtlAlb.Size = new System.Drawing.Size(89, 13);
      this.lblSwapTtlAlb.TabIndex = 5;
      this.lblSwapTtlAlb.TabStop = true;
      this.lblSwapTtlAlb.Text = "Swap Title-Album";
      this.lblSwapTtlAlb.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapTtlAlb.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSwapTtlAlb_LinkClicked);
      // 
      // lblSwapArtTtl
      // 
      this.lblSwapArtTtl.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblSwapArtTtl.AutoSize = true;
      this.lblSwapArtTtl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtTtl.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtTtl.Location = new System.Drawing.Point(22, 73);
      this.lblSwapArtTtl.Name = "lblSwapArtTtl";
      this.lblSwapArtTtl.Size = new System.Drawing.Size(83, 13);
      this.lblSwapArtTtl.TabIndex = 3;
      this.lblSwapArtTtl.TabStop = true;
      this.lblSwapArtTtl.Text = "Swap Artist-Title";
      this.lblSwapArtTtl.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblSwapArtTtl.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblSwapArtTtl_LinkClicked);
      // 
      // lblTopPanel
      // 
      this.lblTopPanel.AutoSize = true;
      this.lblTopPanel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
      this.lblTopPanel.Location = new System.Drawing.Point(174, 9);
      this.lblTopPanel.Name = "lblTopPanel";
      this.lblTopPanel.Size = new System.Drawing.Size(75, 16);
      this.lblTopPanel.TabIndex = 126;
      this.lblTopPanel.Text = "TopPanel";
      // 
      // lblUnsupported
      // 
      this.lblUnsupported.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblUnsupported.AutoSize = true;
      this.lblUnsupported.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblUnsupported.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblUnsupported.Location = new System.Drawing.Point(22, 220);
      this.lblUnsupported.Name = "lblUnsupported";
      this.lblUnsupported.Size = new System.Drawing.Size(102, 13);
      this.lblUnsupported.TabIndex = 10;
      this.lblUnsupported.TabStop = true;
      this.lblUnsupported.Text = "Unsupported frames";
      this.lblUnsupported.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblUnsupported.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUnsupported_LinkClicked);
      // 
      // lblUserDefined
      // 
      this.lblUserDefined.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblUserDefined.AutoSize = true;
      this.lblUserDefined.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblUserDefined.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblUserDefined.Location = new System.Drawing.Point(22, 199);
      this.lblUserDefined.Name = "lblUserDefined";
      this.lblUserDefined.Size = new System.Drawing.Size(121, 13);
      this.lblUserDefined.TabIndex = 9;
      this.lblUserDefined.TabStop = true;
      this.lblUserDefined.Text = "User defined information";
      this.lblUserDefined.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblUserDefined.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblUserDefined_LinkClicked);
      // 
      // lblWebInfo
      // 
      this.lblWebInfo.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblWebInfo.AutoSize = true;
      this.lblWebInfo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblWebInfo.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblWebInfo.Location = new System.Drawing.Point(22, 115);
      this.lblWebInfo.Name = "lblWebInfo";
      this.lblWebInfo.Size = new System.Drawing.Size(85, 13);
      this.lblWebInfo.TabIndex = 5;
      this.lblWebInfo.TabStop = true;
      this.lblWebInfo.Text = "Web Information";
      this.lblWebInfo.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblWebInfo.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblWebInfo_LinkClicked);
      // 
      // lblXferFromV1
      // 
      this.lblXferFromV1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblXferFromV1.AutoSize = true;
      this.lblXferFromV1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblXferFromV1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblXferFromV1.Location = new System.Drawing.Point(22, 31);
      this.lblXferFromV1.Name = "lblXferFromV1";
      this.lblXferFromV1.Size = new System.Drawing.Size(103, 13);
      this.lblXferFromV1.TabIndex = 1;
      this.lblXferFromV1.TabStop = true;
      this.lblXferFromV1.Text = "Transfer From Ver. 1";
      this.lblXferFromV1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblXferFromV1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblXferFromV1_LinkClicked);
      // 
      // lblXferToV1
      // 
      this.lblXferToV1.ActiveLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(66)))), ((int)(((byte)(142)))), ((int)(((byte)(255)))));
      this.lblXferToV1.AutoSize = true;
      this.lblXferToV1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblXferToV1.LinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblXferToV1.Location = new System.Drawing.Point(22, 52);
      this.lblXferToV1.Name = "lblXferToV1";
      this.lblXferToV1.Size = new System.Drawing.Size(88, 13);
      this.lblXferToV1.TabIndex = 2;
      this.lblXferToV1.TabStop = true;
      this.lblXferToV1.Text = "Tranfer To Ver. 1";
      this.lblXferToV1.VisitedLinkColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(93)))), ((int)(((byte)(198)))));
      this.lblXferToV1.LinkClicked += new System.Windows.Forms.LinkLabelLinkClickedEventHandler(this.lblXferToV1_LinkClicked);
      // 
      // panDetail
      // 
      this.panDetail.BackColor = System.Drawing.SystemColors.Control;
      this.panDetail.Controls.Add(this.Panel4);
      this.panDetail.Controls.Add(this.Panel5);
      this.panDetail.Controls.Add(this.Panel9);
      this.panDetail.Controls.Add(this.Panel14);
      this.panDetail.Location = new System.Drawing.Point(168, 48);
      this.panDetail.Name = "panDetail";
      this.panDetail.Size = new System.Drawing.Size(664, 432);
      this.panDetail.TabIndex = 117;
      // 
      // panInvolved
      // 
      this.panInvolved.Controls.Add(this.Panel16);
      this.panInvolved.Controls.Add(this.Panel15);
      this.panInvolved.Location = new System.Drawing.Point(168, 48);
      this.panInvolved.Name = "panInvolved";
      this.panInvolved.Size = new System.Drawing.Size(664, 320);
      this.panInvolved.TabIndex = 119;
      // 
      // panLyrics
      // 
      this.panLyrics.Controls.Add(this.Panel8);
      this.panLyrics.Location = new System.Drawing.Point(168, 48);
      this.panLyrics.Name = "panLyrics";
      this.panLyrics.Size = new System.Drawing.Size(664, 456);
      this.panLyrics.TabIndex = 121;
      // 
      // panMain
      // 
      this.panMain.Controls.Add(this.Panel3);
      this.panMain.Controls.Add(this.Panel1);
      this.panMain.Controls.Add(this.Panel2);
      this.panMain.Location = new System.Drawing.Point(168, 48);
      this.panMain.Name = "panMain";
      this.panMain.Size = new System.Drawing.Size(664, 456);
      this.panMain.TabIndex = 116;
      // 
      // panNot
      // 
      this.panNot.Controls.Add(this.lblNot);
      this.panNot.Controls.Add(this.NotSupportList);
      this.panNot.Location = new System.Drawing.Point(168, 48);
      this.panNot.Name = "panNot";
      this.panNot.Size = new System.Drawing.Size(664, 440);
      this.panNot.TabIndex = 125;
      // 
      // panOriginal
      // 
      this.panOriginal.Controls.Add(this.Panel6);
      this.panOriginal.Location = new System.Drawing.Point(168, 48);
      this.panOriginal.Name = "panOriginal";
      this.panOriginal.Size = new System.Drawing.Size(664, 424);
      this.panOriginal.TabIndex = 118;
      // 
      // panPic
      // 
      this.panPic.Controls.Add(this.Panel7);
      this.panPic.Location = new System.Drawing.Point(168, 56);
      this.panPic.Name = "panPic";
      this.panPic.Size = new System.Drawing.Size(664, 304);
      this.panPic.TabIndex = 120;
      // 
      // panRating
      // 
      this.panRating.Controls.Add(this.Panel11);
      this.panRating.Location = new System.Drawing.Point(168, 48);
      this.panRating.Name = "panRating";
      this.panRating.Size = new System.Drawing.Size(664, 432);
      this.panRating.TabIndex = 123;
      // 
      // panUser
      // 
      this.panUser.Controls.Add(this.Panel13);
      this.panUser.Controls.Add(this.Panel12);
      this.panUser.Location = new System.Drawing.Point(168, 56);
      this.panUser.Name = "panUser";
      this.panUser.Size = new System.Drawing.Size(664, 416);
      this.panUser.TabIndex = 124;
      // 
      // panWeb
      // 
      this.panWeb.Controls.Add(this.Panel10);
      this.panWeb.Location = new System.Drawing.Point(168, 48);
      this.panWeb.Name = "panWeb";
      this.panWeb.Size = new System.Drawing.Size(664, 360);
      this.panWeb.TabIndex = 122;
      // 
      // pnlCommands
      // 
      this.pnlCommands.Controls.Add(this.lblSwapTtlAlb);
      this.pnlCommands.Controls.Add(this.lblSwapArtAlb);
      this.pnlCommands.Controls.Add(this.lblSwapArtTtl);
      this.pnlCommands.Controls.Add(this.lblNext);
      this.pnlCommands.Controls.Add(this.lblPrevious);
      this.pnlCommands.Controls.Add(this.lblCommand);
      this.pnlCommands.Location = new System.Drawing.Point(12, 392);
      this.pnlCommands.Name = "pnlCommands";
      this.pnlCommands.Size = new System.Drawing.Size(135, 147);
      this.pnlCommands.TabIndex = 0;
      // 
      // pnlTagInfo
      // 
      this.pnlTagInfo.Controls.Add(this.lblUnsupported);
      this.pnlTagInfo.Controls.Add(this.lblUserDefined);
      this.pnlTagInfo.Controls.Add(this.lblRating);
      this.pnlTagInfo.Controls.Add(this.lblLyricsPane);
      this.pnlTagInfo.Controls.Add(this.lblPictures);
      this.pnlTagInfo.Controls.Add(this.lblWebInfo);
      this.pnlTagInfo.Controls.Add(this.lblInvolvedPeople);
      this.pnlTagInfo.Controls.Add(this.lblOriginalInfo);
      this.pnlTagInfo.Controls.Add(this.lblDetailedInfo);
      this.pnlTagInfo.Controls.Add(this.lblMainEntries);
      this.pnlTagInfo.Controls.Add(this.label1);
      this.pnlTagInfo.Location = new System.Drawing.Point(12, 6);
      this.pnlTagInfo.Name = "pnlTagInfo";
      this.pnlTagInfo.Size = new System.Drawing.Size(145, 243);
      this.pnlTagInfo.TabIndex = 0;
      // 
      // pnlXferImport
      // 
      this.pnlXferImport.Controls.Add(this.cboFormat);
      this.pnlXferImport.Controls.Add(this.lblGetFromFile);
      this.pnlXferImport.Controls.Add(this.lblXferToV1);
      this.pnlXferImport.Controls.Add(this.lblXferFromV1);
      this.pnlXferImport.Controls.Add(this.label2);
      this.pnlXferImport.Location = new System.Drawing.Point(12, 255);
      this.pnlXferImport.Name = "pnlXferImport";
      this.pnlXferImport.Size = new System.Drawing.Size(150, 131);
      this.pnlXferImport.TabIndex = 0;
      // 
      // pnlLeft
      // 
      this.pnlLeft.Controls.Add(this.pnlCommands);
      this.pnlLeft.Controls.Add(this.pnlXferImport);
      this.pnlLeft.Controls.Add(this.pnlTagInfo);
      this.pnlLeft.Location = new System.Drawing.Point(0, 0);
      this.pnlLeft.Name = "pnlLeft";
      this.pnlLeft.Size = new System.Drawing.Size(168, 544);
      this.pnlLeft.TabIndex = 35;
      // 
      // txtDigits
      // 
      this.txtDigits.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
      this.txtDigits.Location = new System.Drawing.Point(377, 515);
      this.txtDigits.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
      this.txtDigits.Name = "txtDigits";
      this.txtDigits.Size = new System.Drawing.Size(64, 20);
      this.txtDigits.TabIndex = 102;
      this.txtDigits.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
      // 
      // txtSelected
      // 
      this.txtSelected.BackColor = System.Drawing.SystemColors.Control;
      this.txtSelected.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.txtSelected.ForeColor = System.Drawing.Color.Black;
      this.txtSelected.Location = new System.Drawing.Point(278, 29);
      this.txtSelected.Name = "txtSelected";
      this.txtSelected.ReadOnly = true;
      this.txtSelected.Size = new System.Drawing.Size(544, 13);
      this.txtSelected.TabIndex = 108;
      this.txtSelected.TabStop = false;
      this.txtSelected.Enter += new System.EventHandler(this.Select_Enter);
      this.txtSelected.Leave += new System.EventHandler(this.Select_Leave);
      // 
      // frmTAG2
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(842, 544);
      this.ControlBox = false;
      this.Controls.Add(this.lblDigits);
      this.Controls.Add(this.btnOK);
      this.Controls.Add(this.txtDigits);
      this.Controls.Add(this.lblTopPanel);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.txtSelected);
      this.Controls.Add(this.panMain);
      this.Controls.Add(this.lblSelected);
      this.Controls.Add(this.panLyrics);
      this.Controls.Add(this.panPic);
      this.Controls.Add(this.panNot);
      this.Controls.Add(this.panUser);
      this.Controls.Add(this.panInvolved);
      this.Controls.Add(this.panDetail);
      this.Controls.Add(this.panRating);
      this.Controls.Add(this.panWeb);
      this.Controls.Add(this.panOriginal);
      this.Controls.Add(this.pnlLeft);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.KeyPreview = true;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG2";
      this.ShowInTaskbar = false;
      this.Text = "Edit TAG Ver. 2";
      ((System.ComponentModel.ISupportInitialize)(this.APICView)).EndInit();
      this.Panel1.ResumeLayout(false);
      this.Panel1.PerformLayout();
      this.Panel10.ResumeLayout(false);
      this.Panel10.PerformLayout();
      this.Panel11.ResumeLayout(false);
      this.Panel11.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatingCounter)).EndInit();
      ((System.ComponentModel.ISupportInitialize)(this.txtRatingRating)).EndInit();
      this.Panel12.ResumeLayout(false);
      this.Panel12.PerformLayout();
      this.Panel13.ResumeLayout(false);
      this.Panel13.PerformLayout();
      this.Panel14.ResumeLayout(false);
      this.Panel14.PerformLayout();
      this.Panel15.ResumeLayout(false);
      this.Panel15.PerformLayout();
      this.Panel16.ResumeLayout(false);
      this.Panel16.PerformLayout();
      this.Panel2.ResumeLayout(false);
      this.Panel3.ResumeLayout(false);
      this.Panel3.PerformLayout();
      this.Panel4.ResumeLayout(false);
      this.Panel4.PerformLayout();
      this.Panel5.ResumeLayout(false);
      this.Panel5.PerformLayout();
      this.Panel6.ResumeLayout(false);
      this.Panel6.PerformLayout();
      this.Panel7.ResumeLayout(false);
      this.Panel7.PerformLayout();
      this.Panel8.ResumeLayout(false);
      this.Panel8.PerformLayout();
      this.Panel9.ResumeLayout(false);
      this.Panel9.PerformLayout();
      this.panDetail.ResumeLayout(false);
      this.panInvolved.ResumeLayout(false);
      this.panLyrics.ResumeLayout(false);
      this.panMain.ResumeLayout(false);
      this.panNot.ResumeLayout(false);
      this.panOriginal.ResumeLayout(false);
      this.panPic.ResumeLayout(false);
      this.panRating.ResumeLayout(false);
      this.panUser.ResumeLayout(false);
      this.panWeb.ResumeLayout(false);
      this.pnlCommands.ResumeLayout(false);
      this.pnlCommands.PerformLayout();
      this.pnlTagInfo.ResumeLayout(false);
      this.pnlTagInfo.PerformLayout();
      this.pnlXferImport.ResumeLayout(false);
      this.pnlXferImport.PerformLayout();
      this.pnlLeft.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.txtDigits)).EndInit();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

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
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

    #region Local variables

    private bool vbooCommentMoved;
    private bool vbooLyricsMoved;
    private bool vbooRatingMoved;
    private ArrayList alstRemovedAPICFrames;
    private ArrayList alstRemovedLDCFrames;
    private ArrayList alstRemovedPOPMFrames;
    private ArrayList alstRemovedTXXXFrames;
    private ArrayList alstRemovedWXXXFrames;
    private ID3_TagIT.MP3 MP3;
    private FileStream PicFStream;
    private MemoryStream PicMStream;

    #endregion

    #region Events

    private void btnAddComment_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      V2LDCFrame frame = new V2LDCFrame { FID = "COMM" };

      if (StringType.StrCmp(this.txtComment.Text, "", false) != 0)
      {
        foreach (ListViewItem item2 in this.CommentList.Items)
          if ((StringType.StrCmp(item2.Text.ToLower(), this.cmbCDescriptor.Text.ToLower(), false) == 0) & (StringType.StrCmp(item2.SubItems[2].Text, this.cmbCLanguage.Text.Substring(0, 3), false) == 0))
          {
            item2.Text = this.cmbCDescriptor.Text;
            item2.SubItems[1].Text = this.txtComment.Text.Replace("\r\n", "\n");
            this.cmbCDescriptor.Text = "";
            this.txtComment.Text = "";
            return;
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
          if (StringType.StrCmp(item.Text.ToLower(), this.txtInvFunction.Text.TrimEnd(new char[] { ' ' }).ToLower(), false) == 0)
          {
            item.Text = this.txtInvFunction.Text.TrimEnd(new char[] { ' ' });
            item.SubItems[1].Text = this.txtInvPerson.Text.TrimEnd(new char[] { ' ' });
            return;
          }

        ListViewItem newItem = new ListViewItem
        {
          Text = this.txtInvFunction.Text.TrimEnd(new char[] { ' ' }),
          SubItems = { this.txtInvPerson.Text.TrimEnd(new char[] { ' ' }) }
        };

        this.TIPLList.Items.Add(newItem);
        this.txtInvFunction.Text = "";
        this.txtInvPerson.Text = "";
      }
    }

    private void btnAddLyrics_Click(object sender, EventArgs e)
    {
      ListViewItem item = new ListViewItem();
      V2LDCFrame frame = new V2LDCFrame { FID = "USLT" };

      if (StringType.StrCmp(this.txtLyrics.Text, "", false) != 0)
      {
        foreach (ListViewItem item2 in this.LyricsList.Items)
          if ((StringType.StrCmp(item2.Text.ToLower(), this.txtLDescriptor.Text.ToLower(), false) == 0) & (StringType.StrCmp(item2.SubItems[2].Text, this.cmbLLanguage.Text.Substring(0, 3), false) == 0))
          {
            if (ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null), this.txtLDescriptor.Text, false) != 0)
              item2.Text = this.txtLDescriptor.Text;

            if (ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Content", new object[0], null, null), this.txtLyrics.Text.Replace("\r\n", "\n"), false) != 0)
              item2.SubItems[1].Text = this.txtLyrics.Text.Replace("\r\n", "\n");

            this.txtLDescriptor.Text = "";
            this.txtLyrics.Text = "";
            return;
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
          if (StringType.StrCmp(item.Text.ToLower(), this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' }).ToLower(), false) == 0)
          {
            item.Text = this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' });
            item.SubItems[1].Text = this.txtMusicianName.Text.TrimEnd(new char[] { ' ' });
            return;
          }

        ListViewItem newItem = new ListViewItem
        {
          Text = this.txtMusicianInst.Text.TrimEnd(new char[] { ' ' }),
          SubItems = { this.txtMusicianName.Text.TrimEnd(new char[] { ' ' }) }
        };

        this.TMCLList.Items.Add(newItem);
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
          // FIXME
          //if ((((long)-((StringType.StrCmp(item2.Text.ToLower(), this.txtPDescriptor.Text.ToLower(), false) == 0) > false)) &
          //     ((long)Math.Round(Conversion.Val(DoubleType.FromString(item2.SubItems[1].Text.Substring(0, 2)) == Conversion.Val(this.cmbPicType.Text.Substring(0, 2)))))) > 0L)
          if (((ulong)-(StringType.StrCmp(item2.Text.ToLower(), this.txtPDescriptor.Text.ToLower(), false) == 0 ? 1 : 0) &
               (ulong)checked((long)Math.Round(Conversion.Val((object)unchecked(DoubleType.FromString(item2.SubItems[1].Text.Substring(0, 2)) == Conversion.Val(this.cmbPicType.Text.Substring(0, 2))))))) > 0UL)
          {
            if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Descriptor", new object[0], null, null), this.txtPDescriptor.Text, false) == 0, ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "PicType", new object[0], null, null), Conversion.Val(this.cmbPicType.Text.Substring(0, 2)), false) == 0), ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Path", new object[0], null, null), this.txtPicPath.Text, false) == 0), ObjectType.ObjTst(LateBinding.LateGet(item2.Tag, null, "Include", new object[0], null, null), this.chkPicInclude.Checked, false) == 0)))
              return;

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
            frame.MIMEType = "image/jpeg";
          else if (StringType.StrCmp(sLeft, "bmp", false) == 0)
            frame.MIMEType = "image/bmp";
          else if (StringType.StrCmp(sLeft, "gif", false) == 0)
            frame.MIMEType = "image/gif";
          else if (StringType.StrCmp(sLeft, "png", false) == 0)
            frame.MIMEType = "image/png";
          else if (StringType.StrCmp(sLeft, "ico", false) == 0)
            frame.MIMEType = "image/ico";
          else
            frame.MIMEType = "image/" + frame.Path.Substring(frame.Path.LastIndexOf(".") + 1).ToLower();
        }
        else
          frame.MIMEType = "-->";

        if (this.chkPicRelativPath.Checked)
          item.Font = new Font(item.Font, FontStyle.Bold);
        else
          item.Font = new Font(item.Font, FontStyle.Regular);

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
      V2POPMFrame frame = new V2POPMFrame { FID = "POPM" };

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
      V2TXXXFrame frame = new V2TXXXFrame { FID = "TXXX" };

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
      V2WXXXFrame frame = new V2WXXXFrame { FID = "WXXX" };

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

        if (this.PicFStream != null)
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
        if (this.PicFStream != null)
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
        MemoryStream stream2 = null;

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

    private void lblGetFromFile_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string vstrFormat = "";
      FilenameToTAGFormat format = new FilenameToTAGFormat();
      vstrFormat = this.cboFormat.Text.TrimStart(new char[] { ' ' });

      if (vstrFormat.IndexOf(":") >= 0)
        vstrFormat = vstrFormat.Substring(vstrFormat.IndexOf(":") + 1).TrimStart(new char[] { ' ' });

      if (vstrFormat.StartsWith(@"\"))
        vstrFormat = vstrFormat.Substring(1);

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
              this.txtPicPath.Text = Id3TagIT_Main.GetRelativePath(Path.GetDirectoryName(this.MP3.FI.FullName), this.txtPicPath.Text);
            else
              this.txtPicPath.Text = Path.GetFullPath(this.txtPicPath.Text);
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

    private void btnLyricsFile_Click(object sender, EventArgs e)
    {
      this.OpenFileDialog.Filter = "*.TXT|*.TXT";
      this.OpenFileDialog.FilterIndex = 1;

      if (this.OpenFileDialog.ShowDialog() == System.Windows.Forms.DialogResult.OK)
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
      Declarations.objSettings.FT2Format = this.cboFormat.Text;
      Declarations.objSettings.V2Language = this.cmbCLanguage.SelectedIndex;

      this.SaveToTAG();
      this.Close();
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

    private void btnTLEN_Click(object sender, EventArgs e)
    {
      this.txtTLEN.Text = this.MP3.DurationMS.ToString();
    }

    private void btnV1Album_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.MP3.V1TAG.Album, "", false) != 0)
        this.txtAlbum.Text = this.MP3.V1TAG.Album;
    }

    private void btnV1Artist_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.MP3.V1TAG.Artist, "", false) != 0)
        this.cmbArtist.Text = this.MP3.V1TAG.Artist;
    }

    private void btnV1Comment_Click(object sender, EventArgs e)
    {
      if (!Declarations.objSettings.SingleGC)
      {
        if (StringType.StrCmp(this.MP3.V1TAG.Comment, "", false) != 0)
        {
          ListViewItem item = new ListViewItem();
          V2LDCFrame frame = new V2LDCFrame
          {
            FID = "COMM",
            Descriptor = "TAG Ver. 1 Comment",
            Content = this.MP3.V1TAG.Comment,
            Language = StringType.FromObject(LateBinding.LateGet(this.cmbCLanguage.Items[Declarations.objSettings.V2Language], null, "Substring", new object[] { 0, 3 }, null, null))
          };

          foreach (ListViewItem item2 in this.CommentList.Items)
            if ((StringType.StrCmp(item2.Text, frame.Descriptor, false) == 0) & (StringType.StrCmp(item2.SubItems[2].Text, frame.Language, false) == 0))
            {
              item2.SubItems[1].Text = this.MP3.V1TAG.Comment;
              item2.Tag = frame;
              return;
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
            LateBinding.LateSetComplex(o, null, "Substring", new object[] { num2, num, RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, true);

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
          this.GenreList.Items.Add(this.MP3.V1TAG.GenreText);
      }
      else if (StringType.StrCmp(this.MP3.V1TAG.GenreText, "< undefined >", false) != 0)
        this.cmbGenre.Text = this.MP3.V1TAG.GenreText;
    }

    private void btnV1Title_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.MP3.V1TAG.Title, "", false) != 0)
        this.txtTitle.Text = this.MP3.V1TAG.Title;
    }

    private void btnV1Track_Click(object sender, EventArgs e)
    {
      if (this.MP3.V1TAG.Tracknumber != 0)
        this.txtTrack1.Text = this.MP3.V1TAG.Tracknumber.ToString();
    }

    private void btnV1Year_Click(object sender, EventArgs e)
    {
      if (this.MP3.V1TAG.Year != 0)
        this.txtYear.Text = this.MP3.V1TAG.Year.ToString().Trim(new char[] { ' ' }).PadLeft(4, '0') + "-01-01";
    }

    private void chkPicInclude_CheckedChanged(object sender, EventArgs e)
    {
      try
      {
        if (this.chkPicInclude.Checked)
          this.chkPicRelativPath.Checked = false;
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
          this.txtPicPath.Text = Id3TagIT_Main.GetRelativePath(Path.GetDirectoryName(this.MP3.FI.FullName), this.txtPicPath.Text);
        }
        else
          this.txtPicPath.Text = Path.GetFullPath(this.txtPicPath.Text);
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }
    }

    private void CommentList_Click(object sender, EventArgs e)
    {
      this.cmbCDescriptor.Text = this.CommentList.FocusedItem.Text;

      foreach (var item in this.cmbCLanguage.Items)
      {
        string str = StringType.FromObject(item);

        if (str.StartsWith(this.CommentList.FocusedItem.SubItems[2].Text))
        {
          this.cmbCLanguage.SelectedItem = str;
          goto Label_0089;
        }
      }

      Label_0089:
      this.txtComment.Text = this.CommentList.FocusedItem.SubItems[1].Text.Replace("\n", "\r\n");
    }

    private void frmTAG2_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;

      this.panDetail.Enabled = false;
      this.panOriginal.Enabled = false;
      this.panWeb.Enabled = false;
      this.panRating.Enabled = false;
      this.panPic.Enabled = false;
      this.panLyrics.Enabled = false;
      this.panNot.Enabled = false;
      this.panInvolved.Enabled = false;
      this.panUser.Enabled = false;
      this.lblTopPanel.Text = "Main Entries";

      if (this.MainForm.MP3View.FocusedItem == null)
        this.MainForm.MP3View.Items[this.MainForm.MP3View.SelectedItems[0].Index].Focused = true;

      this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
      this.FocusControl = this.cmbArtist;

      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
        this.cmbArtist.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));

      foreach (DataRow row in Declarations.objSettings.CommDescriptors.Rows)
        this.cmbCDescriptor.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));

      if (Declarations.objSettings.OwnGenreOnly)
      {
        foreach (DataRow row in Declarations.objSettings.Genres.Rows)
          this.cmbGenre.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
      else
      {
        foreach (DataRow row in Declarations.objSettings.Genres.Rows)
          this.cmbGenre.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));

        foreach (string str in Declarations.astrGenreLookup)
          this.cmbGenre.Items.Add(str);
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
        this.cboFormat.Items.Add(RuntimeHelpers.GetObjectValue(Declarations.objSettings.FT2Formats.Rows[i]["Format"]));

      this.cboFormat.Text = Declarations.objSettings.FT2Format;
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

      Directory.SetCurrentDirectory(Path.GetDirectoryName(this.MP3.FI.FullName));
      this.FillForm();
      //this.UpdateI18n(); FIXME - do language stuff later
      this.AddToolTips();
      this.AddColumnText();
      this.cmbArtist.Select();
      this.cmbArtist.Focus();
    }

    private void lblDetailedInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "Detailed Information";
      this.panDetail.Visible = true;
      this.panDetail.Enabled = true;
    }

    private void lblInvolvedPeople_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "Involved People";
      this.panInvolved.Visible = true;
      this.panInvolved.Enabled = true;
    }

    private void lblLyricsPane_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "Lyrics";
      this.panLyrics.Visible = true;
      this.panLyrics.Enabled = true;
    }

    private void lblMainEntries_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "Main Entries";
      this.panMain.Visible = true;
      this.panMain.Enabled = true;
    }

    private void lblOriginalInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "Original Information";
      this.panOriginal.Visible = true;
      this.panOriginal.Enabled = true;
    }

    private void lblNext_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.SaveToTAG();

      if (this.MainForm.MP3View.FocusedItem.Index < (this.MainForm.MP3View.Items.Count - 1))
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.FocusedItem.Index + 1].Focused = true;
        this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
        this.ClearForm();
        this.FillForm();

        // FIXME
        //if (this.ActiveControl == this.btnNext)
        //  this.FocusControl.Focus();
      }
      // FIXME
      //else if (this.ActiveControl == this.btnNext)
      //{
      //  this.FocusControl.Focus();
      //}

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

    private void lblPictures_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "Pictures";
      this.panPic.Visible = true;
      this.panPic.Enabled = true;
    }

    private void lblPrevious_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      this.SaveToTAG();

      if (this.MainForm.MP3View.FocusedItem.Index != 0)
      {
        this.MainForm.MP3View.Items[this.MainForm.MP3View.FocusedItem.Index - 1].Focused = true;
        this.MP3 = (ID3_TagIT.MP3)this.MainForm.MP3View.FocusedItem.Tag;
        this.ClearForm();
        this.FillForm();
        // FIXME
        //if (this.ActiveControl == this.btnPrev)
        //  this.FocusControl.Focus();
      }
      // FIXME
      //else if (this.ActiveControl == this.btnPrev)
      //  this.FocusControl.Focus();

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

    private void lblRating_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "Rating";
      this.panRating.Visible = true;
      this.panRating.Enabled = true;
    }

    private void lblSwapArtAlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtAlbum.Text;
      this.txtAlbum.Text = text;
    }

    private void lblSwapArtTtl_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string text = this.cmbArtist.Text;
      this.cmbArtist.Text = this.txtTitle.Text;
      this.txtTitle.Text = text;
    }

    private void lblSwapTtlAlb_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      string text = this.txtTitle.Text;
      this.txtTitle.Text = this.txtAlbum.Text;
      this.txtAlbum.Text = text;
    }

    private void lblUnsupported_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "Not Supported";
      this.panNot.Visible = true;
      this.panNot.Enabled = true;
    }

    private void lblUserDefined_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "User Defined Information";
      this.panUser.Visible = true;
      this.panUser.Enabled = true;
    }

    private void lblWebInfo_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      DisablePanels();
      lblTopPanel.Text = "Web Information";
      this.panWeb.Visible = true;
      this.panWeb.Enabled = true;
    }

    private void lblXferFromV1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
    {
      if (StringType.StrCmp(this.MP3.V1TAG.Artist, "", false) != 0)
        this.cmbArtist.Text = this.MP3.V1TAG.Artist;

      if (StringType.StrCmp(this.MP3.V1TAG.Title, "", false) != 0)
        this.txtTitle.Text = this.MP3.V1TAG.Title;

      if (StringType.StrCmp(this.MP3.V1TAG.Album, "", false) != 0)
        this.txtAlbum.Text = this.MP3.V1TAG.Album;

      if (this.MP3.V1TAG.Year != 0)
        this.txtYear.Text = this.MP3.V1TAG.Year.ToString().Trim(new char[] { ' ' }).PadLeft(4, '0') + "-01-01";

      if (this.MP3.V1TAG.Tracknumber != 0)
        this.txtTrack1.Text = this.MP3.V1TAG.Tracknumber.ToString();

      if ((StringType.StrCmp(this.MP3.V1TAG.GenreText, "< undefined >", false) != 0) & !this.GenreList.Items.Contains(this.MP3.V1TAG.GenreText))
        this.GenreList.Items.Add(this.MP3.V1TAG.GenreText);

      if (StringType.StrCmp(this.MP3.V1TAG.Comment, "", false) != 0)
      {
        ListViewItem item = new ListViewItem();
        V2LDCFrame frame = new V2LDCFrame
        {
          FID = "COMM",
          Descriptor = "TAG Ver. 1 Comment",
          Content = this.MP3.V1TAG.Comment,
          Language = StringType.FromObject(LateBinding.LateGet(this.cmbCLanguage.Items[Declarations.objSettings.V2Language], null, "Substring", new object[] { 0, 3 }, null, null))
        };

        foreach (ListViewItem item2 in this.CommentList.Items)
          if ((StringType.StrCmp(item2.Text, frame.Descriptor, false) == 0) & (StringType.StrCmp(item2.SubItems[2].Text, frame.Language, false) == 0))
          {
            item2.SubItems[1].Text = this.MP3.V1TAG.Comment;
            item2.Tag = frame;
            return;
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
          LateBinding.LateSetComplex(o, null, "Substring", new object[] { num3, num, RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, true);

        item.Tag = frame;
        this.CommentList.Items.Add(item);
      }
    }

    private void lblXferToV1_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
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

    private void LyricsList_Click(object sender, EventArgs e)
    {
      this.txtLDescriptor.Text = this.LyricsList.FocusedItem.Text;

      foreach (var item in this.cmbLLanguage.Items)
      {
        string str = StringType.FromObject(item);

        if (str.StartsWith(this.LyricsList.FocusedItem.SubItems[2].Text))
        {
          this.cmbLLanguage.SelectedItem = str;
          goto Label_0089;
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

        if (this.PicFStream != null)
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

        if (this.PicFStream != null)
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
          this.APICView.Image = null;

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
        LateBinding.LateSetComplex(LateBinding.LateGet(o, null, "Text", args, paramnames, null), null, "Length", new object[] { RuntimeHelpers.GetObjectValue(objArray2[1]) }, null, true, true);
    }

    private void Select_Leave(object sender, EventArgs e)
    {
      MaskedTextBox tmpYear;
      this.FocusControl = (Control)sender;

      if (((sender == this.txtRatingCounter) | (sender == this.txtRatingRating)) && (ObjectType.ObjTst(LateBinding.LateGet(sender, null, "Text", new object[0], null, null), "", false) == 0))
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
          this.txtTORY.Mask = "####";
          break;

        case 1:
          this.txtTORY.Mask = "####-##";

          if (this.txtTORY.Text.Length < 7)
          {
            string str = DateTime.Now.Year.ToString() + "-01";
            tmpTORY = this.txtTORY;
            tmpTORY.Text = tmpTORY.Text + str.Substring(this.txtTORY.Text.Length);
          }

          break;

        case 2:
          this.txtTORY.Mask = "####-##-##";

          if (this.txtTORY.Text.Length < 10)
          {
            string str2 = DateTime.Now.Year.ToString() + "-01-01";
            tmpTORY = this.txtTORY;
            tmpTORY.Text = tmpTORY.Text + str2.Substring(this.txtTORY.Text.Length);
          }

          break;
      }
    }

    private void txtPOS1_Validating(object sender, CancelEventArgs e)
    {
      if (txtPOS1.ValidateText() != null)
        if ((int)txtPOS1.ValidateText() < 0 || (int)txtPOS1.ValidateText() > 255)
          e.Cancel = true;
    }

    private void txtPOS2_Validating(object sender, CancelEventArgs e)
    {
      if (txtPOS2.ValidateText() != null)
        if ((int)txtPOS2.ValidateText() < 0 || (int)txtPOS2.ValidateText() > 255)
          e.Cancel = true;
    }

    private void txtTrack1_Validating(object sender, CancelEventArgs e)
    {
      if (txtTrack1.ValidateText() != null)
        if ((int)txtTrack1.ValidateText() < 0 || (int)txtTrack1.ValidateText() > 255)
          e.Cancel = true;
    }

    private void txtTrack2_Validating(object sender, CancelEventArgs e)
    {
      if (txtTrack2.ValidateText() != null)
        if ((int)txtTrack2.ValidateText() < 0 || (int)txtTrack2.ValidateText() > 255)
          e.Cancel = true;
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
      MaskedTextBox tmpYear;

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
            tmpYear = this.txtYear;
            tmpYear.Text = tmpYear.Text + str.Substring(this.txtYear.Text.Length);
          }

          break;

        case 2:
          this.txtYear.Mask = "####-##-##";

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

      this.NotSupportList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol23"]);
      this.NotSupportList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol24"]);
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
      this.txtTLEN = (MaskedTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTLEN, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));

      vstrName = "frmTAG2";
      txtSelected = this.txtPOS2;
      this.txtPOS2 = (MaskedTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtPOS2, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));

      vstrName = "frmTAG2";
      txtSelected = this.txtPOS1;
      this.txtPOS1 = (MaskedTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtPOS1, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));

      vstrName = "frmTAG2";
      txtSelected = this.txtTrack2;
      this.txtTrack2 = (MaskedTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTrack2, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));

      vstrName = "frmTAG2";
      txtSelected = this.txtTrack1;
      this.txtTrack1 = (MaskedTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtTrack1, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));

      vstrName = "frmTAG2";
      txtSelected = this.txtYear;
      this.txtYear = (MaskedTextBox)txtSelected;
      this.ToolTip.SetToolTip(this.txtYear, Declarations.objResources.GetToolTip(ref vstrName, ref txtSelected));

      vstrName = "frmTAG2";
      txtSelected = this.txtBPM;
      this.txtBPM = (MaskedTextBox)txtSelected;
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
      this.txtTORY = (MaskedTextBox)txtSelected;
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

    private void DisablePanels()
    {
      this.panMain.Visible = false;
      this.panMain.Enabled = false;

      this.panNot.Visible = false;
      this.panNot.Enabled = false;

      this.panDetail.Visible = false;
      this.panDetail.Enabled = false;

      this.panOriginal.Visible = false;
      this.panOriginal.Enabled = false;

      this.panInvolved.Visible = false;
      this.panInvolved.Enabled = false;

      this.panWeb.Visible = false;
      this.panWeb.Enabled = false;

      this.panPic.Visible = false;
      this.panPic.Enabled = false;

      this.panLyrics.Visible = false;
      this.panLyrics.Enabled = false;

      this.panRating.Visible = false;
      this.panRating.Enabled = false;

      this.panUser.Visible = false;
      this.panUser.Enabled = false;
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
              LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", args, strArray6, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray2[1]) }, null, true, true);

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
              LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", objArray, strArray6, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);

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
        foreach (string str2 in Strings.Split(this.MP3.V2TAG.GetTextWebFrameContent("TCON"), "\0", -1, CompareMethod.Binary))
        {
          var ss22 = str2;

          if (StringType.StrCmp(ss22, "", false) != 0)
          {
            if ((ss22.Length > 2) && Information.IsNumeric(ss22.Replace("(", "").Replace(")", "")))
              if ((Conversion.Val(ss22.Replace("(", "").Replace(")", "")) >= 0.0) & (Conversion.Val(ss22.Replace("(", "").Replace(")", "")) < 148.0))
                ss22 = Declarations.astrGenreLookup[(int)Math.Round(Conversion.Val(ss22.Replace("(", "").Replace(")", "")))];
              else
                ss22 = "< undefined >";

            this.GenreList.Items.Add(ss22);
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
          ListViewItem item = new ListViewItem { Text = strArray2[i], SubItems = { strArray2[i + 1] } };
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
          ListViewItem item2 = new ListViewItem { Text = strArray3[j], SubItems = { strArray3[j + 1] } };
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
          ListViewItem item3 = new ListViewItem { Text = strArray4[k], SubItems = { strArray4[k + 1] } };
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
              LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", objArray, strArray6, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);

            str = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray));
          }
        }
      }
      else
        str = "";

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
          LateBinding.LateSet(objectValue, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 4 }, null, null))).ToString() }, null);

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
              LateBinding.LateSetComplex(LateBinding.LateGet(obj5, null, "Content", objArray, strArray6, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);

            str = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray));
          }
        }
      }
      else
        str = "";

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
          LateBinding.LateSetComplex(obj5, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);

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
          LateBinding.LateSetComplex(obj5, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);

        objArray = new object[1];
        obj5 = objectValue;
        objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj5, null, "Language", new object[0], null, null));
        objArray2 = objArray;
        flagArray = new bool[] { true };
        LateBinding.LateCall(item5.SubItems, null, "Add", objArray2, null, flagArray);

        if (flagArray[0])
          LateBinding.LateSetComplex(obj5, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(objArray2[0]) }, null, true, false);

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

    public void GetInfo(ID3_TagIT.MP3 MP3, ArrayList alstFormat)
    {
      int num5;
      ArrayList list2 = new ArrayList();
      ArrayList list = new ArrayList();
      string[] strArray2 = MP3.CurrentFullName.Remove(MP3.CurrentFullName.LastIndexOf("."), MP3.FI.Extension.Length).Split(new char[] { '\\' });

      if (alstFormat.Count >= strArray2.Length)
        num5 = strArray2.Length - 1;
      else
        num5 = alstFormat.Count - 1;

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
        var enumerator = list.GetEnumerator();

        while (enumerator.MoveNext())
        {
          string str = StringType.FromObject(enumerator.Current);
          num3++;

          if ((num3 != list2.Count) && (ObjectType.ObjTst(list2[num3], "", false) != 0))
          {
            string sLeft = str;

            if ((StringType.StrCmp(sLeft, "<A>", false) == 0) || (StringType.StrCmp(sLeft, "<a>", false) == 0))
              this.cmbArtist.Text = StringType.FromObject(list2[num3]);
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
                    this.txtTrack2.Text = StringType.FromObject(list2[num3]);
                  else if (StringType.StrCmp(str3, "<K>", false) == 0)
                    this.txtTrack1.Text = StringType.FromObject(list2[num3]);
                  else if (StringType.StrCmp(str3, "<p>", false) == 0)
                    this.txtPOS2.Text = StringType.FromObject(list2[num3]);
                  else if (StringType.StrCmp(str3, "<P>", false) == 0)
                    this.txtPOS1.Text = StringType.FromObject(list2[num3]);
                }

                continue;
              }

              if ((StringType.StrCmp(sLeft, "<Y>", false) == 0) || (StringType.StrCmp(sLeft, "<y>", false) == 0))
              {
                if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(list2[num3])))
                  this.txtYear.Text = list2[num3].ToString().Trim(new char[] { ' ' }).PadLeft(4, '0') + "-01-01";

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
                  LateBinding.LateSetComplex(obj4, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(args[0]) }, null, true, false);

                object[] objArray = new object[1];
                obj4 = o;
                objArray[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(obj4, null, "Language", new object[0], null, null));
                args = objArray;
                copyBack = new bool[] { true };
                LateBinding.LateCall(item.SubItems, null, "Add", args, null, copyBack);

                if (copyBack[0])
                  LateBinding.LateSetComplex(obj4, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(args[0]) }, null, true, false);

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
                  this.txtBPM.Text = StringType.FromObject(list2[num3]);

                continue;
              }

              if ((StringType.StrCmp(sLeft, "<X>", false) != 0) && (StringType.StrCmp(sLeft, "<x>", false) == 0))
              { /* Don't do a damned thing */ }
            }
          }
        }
      }
    }

    private void SaveToTAG()
    {
      string text;
      ArrayList list = new ArrayList();

      Declarations.UnDoReDo @do = new Declarations.UnDoReDo(this.MP3, this.MP3.V1TAG.Clone(), this.MP3.V2TAG.Clone(), this.MP3.CurrentFullName, this.MP3.Changed);
      list.Add(@do);

      object o = ID3Functions.CreateTextFrame("TPE1", this.cmbArtist.Text);

      if (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TIT2", this.txtTitle.Text);

      if (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TALB", this.txtAlbum.Text);

      if (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TPE2", this.txtBand.Text);

      if (StringType.StrCmp(this.txtBand.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TPE3", this.txtConductor.Text);

      if (StringType.StrCmp(this.txtConductor.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TPE4", this.txtModified.Text);

      if (StringType.StrCmp(this.txtModified.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TIT1", this.txtContent.Text);

      if (StringType.StrCmp(this.txtContent.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TIT3", this.txtSubTitle.Text);

      if (StringType.StrCmp(this.txtSubTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TCOM", this.txtComposer.Text);

      if (StringType.StrCmp(this.txtComposer.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TCOP", this.txtCopyright.Text);

      if (StringType.StrCmp(this.txtCopyright.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));

      if ((((StringType.StrCmp(this.txtSortAlbum.Text.TrimEnd(new char[] { ' ' }), "", false) != 0) | (StringType.StrCmp(this.txtSortArtist.Text.TrimEnd(new char[] { ' ' }), "", false) != 0)) | (StringType.StrCmp(this.txtSortTitle.Text.TrimEnd(new char[] { ' ' }), "", false) != 0)) & (((this.MP3.V2TAG.TAGVersion == 0) & (Declarations.objSettings.NewV2Version == 4)) | (this.MP3.V2TAG.TAGVersion == 4)))
      {
        o = ID3Functions.CreateTextFrame("TSOA", this.txtSortAlbum.Text);

        if (StringType.StrCmp(this.txtSortAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = ID3Functions.CreateTextFrame("TSOP", this.txtSortArtist.Text);

        if (StringType.StrCmp(this.txtSortArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
        o = ID3Functions.CreateTextFrame("TSOT", this.txtSortTitle.Text);

        if (StringType.StrCmp(this.txtSortTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }

      o = ID3Functions.CreateTextFrame("TEXT", this.txtLyWriter.Text);

      if (StringType.StrCmp(this.txtLyWriter.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TPUB", this.txtPublisher.Text);

      if (StringType.StrCmp(this.txtPublisher.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TENC", this.txtEncoded.Text);

      if (StringType.StrCmp(this.txtEncoded.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOAL", this.txtOAlbum.Text);

      if (StringType.StrCmp(this.txtOAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOFN", this.txtOFilename.Text);

      if (StringType.StrCmp(this.txtOFilename.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOPE", this.txtOArtist.Text);

      if (StringType.StrCmp(this.txtOArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOLY", this.txtOLyWriter.Text);

      if (StringType.StrCmp(this.txtOLyWriter.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TOWN", this.txtOOwner.Text);

      if (StringType.StrCmp(this.txtOOwner.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateTextFrame("TLEN", this.txtTLEN.Text);

      if (StringType.StrCmp(this.txtTLEN.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WCOM", this.txtCOMMInfURL.Text);

      if (StringType.StrCmp(this.txtCOMMInfURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WCOP", this.txtCopyInfURL.Text);

      if (StringType.StrCmp(this.txtCopyInfURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WOAF", this.txtAudioFileURL.Text);

      if (StringType.StrCmp(this.txtAudioFileURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WOAR", this.txtArtistURL.Text);

      if (StringType.StrCmp(this.txtArtistURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WOAS", this.txtAudioSRCURL.Text);

      if (StringType.StrCmp(this.txtAudioSRCURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WORS", this.txtINetRadioURL.Text);

      if (StringType.StrCmp(this.txtINetRadioURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WPAY", this.txtPayURL.Text);

      if (StringType.StrCmp(this.txtPayURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      o = ID3Functions.CreateWebFrame("WPUB", this.txtPubURL.Text);

      if (StringType.StrCmp(this.txtPubURL.Text.Trim(new char[] { ' ' }), "", false) == 0)
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));

      if (this.TIPLList.Items.Count > 0)
      {
        if (!this.MP3.V2TAG.TAGHeaderPresent)
          this.MP3.V2TAG.TAGHeaderPresent = true;

        string vstrContent = "";

        foreach (ListViewItem item in this.TIPLList.Items)
          vstrContent = vstrContent + item.Text + "\0" + item.SubItems[1].Text + "\0";

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
          this.MP3.V2TAG.TAGHeaderPresent = true;

        string str4 = "";

        foreach (ListViewItem item in this.TMCLList.Items)
          str4 = str4 + item.Text + "\0" + item.SubItems[1].Text + "\0";

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
          this.MP3.V2TAG.TAGHeaderPresent = true;

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
          this.MP3.V2TAG.TAGHeaderPresent = true;

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
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));

      if (StringType.StrCmp(this.txtTrack1.Text, "", false) != 0)
      {
        if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
          o = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtTrack2.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
        else
          o = ID3Functions.CreateTextFrame("TRCK", this.txtTrack1.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
      }
      else if (StringType.StrCmp(this.txtTrack2.Text, "", false) != 0)
        o = ID3Functions.CreateTextFrame("TRCK", "/" + this.txtTrack2.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
      else
      {
        o = ID3Functions.CreateTextFrame("TRCK", "0".PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
      }

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));

      if (StringType.StrCmp(this.txtPOS1.Text, "", false) != 0)
      {
        if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
          o = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0') + "/" + this.txtPOS2.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
        else
          o = ID3Functions.CreateTextFrame("TPOS", this.txtPOS1.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
      }
      else if (StringType.StrCmp(this.txtPOS2.Text, "", false) != 0)
        o = ID3Functions.CreateTextFrame("TPOS", "/" + this.txtPOS2.Text.TrimStart(new char[] { '0' }).PadLeft(Convert.ToInt32(this.txtDigits.Value), '0'));
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
        o = ID3Functions.CreateTextFrame("TBPM", this.txtBPM.Text);

      this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));

      var enumerator18 = this.alstRemovedTXXXFrames.GetEnumerator();

      while (enumerator18.MoveNext())
      {
        o = RuntimeHelpers.GetObjectValue(enumerator18.Current);
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
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

      var enumerator16 = this.alstRemovedWXXXFrames.GetEnumerator();

      while (enumerator16.MoveNext())
      {
        o = RuntimeHelpers.GetObjectValue(enumerator16.Current);
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
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

        var enumerator14 = this.GenreList.Items.GetEnumerator();

        while (enumerator14.MoveNext())
        {
          string str2 = StringType.FromObject(enumerator14.Current);
          text = text + str2 + "\0";
        }

        if (text.EndsWith("\0"))
          text = text.Substring(0, text.Length - 1);

        o = ID3Functions.CreateTextFrame("TCON", text);

        if (StringType.StrCmp(text, "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }
      else
      {
        text = this.cmbGenre.Text;
        o = ID3Functions.CreateTextFrame("TCON", text);

        if (StringType.StrCmp(text, "", false) == 0)
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);

        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }

      if (this.vbooLyricsMoved)
      {
        ArrayList alstFrames = new ArrayList();

        foreach (ListViewItem item2 in this.LyricsList.Items)
          alstFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(item2.Tag, null, "Clone", new object[0], null, null)));

        this.MP3.V2TAG.RemoveFrames("USLT");
        this.MP3.V2TAG.AddFrames(alstFrames);
      }

      if (this.vbooRatingMoved)
      {
        ArrayList list3 = new ArrayList();

        foreach (ListViewItem item3 in this.RatingList.Items)
          list3.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(item3.Tag, null, "Clone", new object[0], null, null)));

        this.MP3.V2TAG.RemoveFrames("POPM");
        this.MP3.V2TAG.AddFrames(list3);
      }

      foreach (var frameItem in this.alstRemovedLDCFrames)
      {
        o = RuntimeHelpers.GetObjectValue(frameItem);

        if (ObjectType.ObjTst(LateBinding.LateGet(o, null, "FID", new object[0], null, null), "USLT", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
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

      foreach (var frameItem in this.alstRemovedPOPMFrames)
      {
        o = RuntimeHelpers.GetObjectValue(frameItem);

        if (ObjectType.ObjTst(LateBinding.LateGet(o, null, "FID", new object[0], null, null), "POPM", false) == 0)
        {
          LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
          this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
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

      foreach (var frameItem in this.alstRemovedAPICFrames)
      {
        o = RuntimeHelpers.GetObjectValue(frameItem);
        LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
      }

      foreach (ListViewItem item in this.PicList.Items)
        this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(item.Tag));

      if (!Declarations.objSettings.SingleGC)
      {
        if (this.vbooCommentMoved)
        {
          ArrayList list4 = new ArrayList();

          foreach (ListViewItem item4 in this.CommentList.Items)
            list4.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(item4.Tag, null, "Clone", new object[0], null, null)));

          this.MP3.V2TAG.RemoveFrames("COMM");
          this.MP3.V2TAG.AddFrames(list4);
        }

        foreach (var frameItem in this.alstRemovedLDCFrames)
        {
          o = RuntimeHelpers.GetObjectValue(frameItem);

          if (ObjectType.ObjTst(LateBinding.LateGet(o, null, "FID", new object[0], null, null), "COMM", false) == 0)
          {
            LateBinding.LateSet(o, null, "Remove", new object[] { true }, null);
            this.MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(o));
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
            this.MP3.V2TAG.AddFrame(frame);
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
          this.MP3.V2TAG.RemoveFrameExact(RuntimeHelpers.GetObjectValue(item.Tag));
      }

      if (this.MP3.V2TAG.Changed)
      {
        if (!this.MP3.V2TAG.TAGHeaderPresent)
          this.MP3.V2TAG.TAGHeaderPresent = true;

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
            this.MP3.Changed = true;

          this.MP3.V1TAG.GenreByte = 0xff;
        }
        else
        {
          string sRight = StringType.FromObject(LateBinding.LateGet(this.MP3.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null));
          bool flag = false;

          if (sRight.IndexOf('\0') > 0)
            sRight = sRight.Substring(0, sRight.IndexOf('\0'));

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

    // FIXME This simply does the i18n text swaps.  Do this later.
    //private void UpdateI18n()
    //{
    //  IEnumerator enumerator = null;

    //  try
    //  {
    //    enumerator = this.SelectionBar.Groups.GetEnumerator();

    //    while (enumerator.MoveNext())
    //    {
    //      ExplorerBarGroupItem current = (ExplorerBarGroupItem)enumerator.Current;
    //      current.Text = StringType.FromObject(Declarations.objResources.SelectionBar[current.Name]);

    //      try
    //      {
    //        foreach (ButtonItem item in current.SubItems)
    //          item.Text = StringType.FromObject(Declarations.objResources.SelectionBar[item.Name]);

    //        continue;
    //      }
    //      catch (Exception exception1)
    //      {
    //        ProjectData.SetProjectError(exception1);
    //        ProjectData.ClearProjectError();
    //        continue;
    //      }
    //    }
    //  }
    //  finally
    //  {
    //    if (enumerator is IDisposable)
    //      ((IDisposable)enumerator).Dispose();
    //  }
    //}

    #endregion
  }
}