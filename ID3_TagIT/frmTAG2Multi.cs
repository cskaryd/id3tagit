﻿using AMS.TextBox;
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

namespace ID3_TagIT
{
  public class frmTAG2Multi : Form
  {
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
    private NumericTextBox txtBPM;
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
    private IntegerTextBox txtPOS1;
    private IntegerTextBox txtPOS2;
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
    private AMS.TextBox.MaskedTextBox txtTORY;
    private IntegerTextBox txtTrack1;
    private IntegerTextBox txtTrack2;
    private System.Windows.Forms.TextBox txtTXXXContent;
    private System.Windows.Forms.TextBox txtTXXXDesc;
    private System.Windows.Forms.TextBox txtWXXXContent;
    private System.Windows.Forms.TextBox txtWXXXDesc;
    private AMS.TextBox.MaskedTextBox txtYear;
    private ListView TXXXList;
    private ListView WXXXList;
    private HScrollBar YearFormat;
    private IContainer components;
    private frmMain MainForm;
    private FileStream PicFStream;
    private MemoryStream PicMStream;
    private bool vbooCommentMoved;
    private bool vbooLyricsMoved;
    private bool vbooRatingMoved;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      ResourceManager manager = new ResourceManager(typeof(frmTAG2Multi));
      this.panDetail = new Panel();
      this.Panel9 = new Panel();
      this.cmbMedia = new ComboBox();
      this.lblMediaTyp = new System.Windows.Forms.Label();
      this.chkTLEN = new CheckBox();
      this.lblTLEN = new System.Windows.Forms.Label();
      this.CheckBox5 = new CheckBox();
      this.Panel5 = new Panel();
      this.CheckBox16 = new CheckBox();
      this.CheckBox15 = new CheckBox();
      this.txtContent = new System.Windows.Forms.TextBox();
      this.txtSubTitle = new System.Windows.Forms.TextBox();
      this.lblSubTitle = new System.Windows.Forms.Label();
      this.lblContent = new System.Windows.Forms.Label();
      this.Panel14 = new Panel();
      this.CheckBox41 = new CheckBox();
      this.CheckBox42 = new CheckBox();
      this.CheckBox43 = new CheckBox();
      this.txtSortArtist = new System.Windows.Forms.TextBox();
      this.txtSortTitle = new System.Windows.Forms.TextBox();
      this.txtSortAlbum = new System.Windows.Forms.TextBox();
      this.lblAlbumSort = new System.Windows.Forms.Label();
      this.lblTitleSort = new System.Windows.Forms.Label();
      this.lblArtistSort = new System.Windows.Forms.Label();
      this.Panel4 = new Panel();
      this.CheckBox14 = new CheckBox();
      this.CheckBox13 = new CheckBox();
      this.CheckBox12 = new CheckBox();
      this.CheckBox11 = new CheckBox();
      this.txtComposer = new System.Windows.Forms.TextBox();
      this.lblComposer = new System.Windows.Forms.Label();
      this.txtBand = new System.Windows.Forms.TextBox();
      this.txtModified = new System.Windows.Forms.TextBox();
      this.txtConductor = new System.Windows.Forms.TextBox();
      this.lblConductor = new System.Windows.Forms.Label();
      this.lblModified = new System.Windows.Forms.Label();
      this.lblBand = new System.Windows.Forms.Label();
      this.CheckBox40 = new CheckBox();
      this.txtCopyright = new System.Windows.Forms.TextBox();
      this.lblCopyright = new System.Windows.Forms.Label();
      this.CheckBox19 = new CheckBox();
      this.CheckBox18 = new CheckBox();
      this.CheckBox17 = new CheckBox();
      this.txtLyWriter = new System.Windows.Forms.TextBox();
      this.txtEncoded = new System.Windows.Forms.TextBox();
      this.txtPublisher = new System.Windows.Forms.TextBox();
      this.lblPublisher = new System.Windows.Forms.Label();
      this.lblEncoded = new System.Windows.Forms.Label();
      this.lblLyWriter = new System.Windows.Forms.Label();
      this.panOriginal = new Panel();
      this.Panel6 = new Panel();
      this.txtTORY = new AMS.TextBox.MaskedTextBox();
      this.CheckBox39 = new CheckBox();
      this.lblOYearInfo = new System.Windows.Forms.Label();
      this.TORYFormat = new HScrollBar();
      this.lblOYear = new System.Windows.Forms.Label();
      this.CheckBox24 = new CheckBox();
      this.CheckBox23 = new CheckBox();
      this.CheckBox22 = new CheckBox();
      this.CheckBox21 = new CheckBox();
      this.CheckBox20 = new CheckBox();
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
      this.panMain = new Panel();
      this.Panel3 = new Panel();
      this.lblCommDescInfo = new System.Windows.Forms.Label();
      this.cmbCDescriptor = new ComboBoxAutoComplete();
      this.CheckBox38 = new CheckBox();
      this.CheckBox10 = new CheckBox();
      this.btnMoveComment = new Button();
      this.btnRemoveComment = new Button();
      this.btnAddComment = new Button();
      this.lblCOMM = new System.Windows.Forms.Label();
      this.lblCOMMLan = new System.Windows.Forms.Label();
      this.lblCOMMDesc = new System.Windows.Forms.Label();
      this.cmbCLanguage = new ComboBox();
      this.txtComment = new System.Windows.Forms.TextBox();
      this.CommentList = new ListView();
      this.colDescriptor = new ColumnHeader();
      this.colComment = new ColumnHeader();
      this.colLanguage = new ColumnHeader();
      this.Panel1 = new Panel();
      this.txtPOS2 = new IntegerTextBox();
      this.txtPOS1 = new IntegerTextBox();
      this.txtTrack2 = new IntegerTextBox();
      this.txtTrack1 = new IntegerTextBox();
      this.txtYear = new AMS.TextBox.MaskedTextBox();
      this.txtBPM = new NumericTextBox();
      this.cmbArtist = new ComboBoxAutoComplete();
      this.CheckBox8 = new CheckBox();
      this.CheckBox7 = new CheckBox();
      this.CheckBox6 = new CheckBox();
      this.CheckBox4 = new CheckBox();
      this.CheckBox3 = new CheckBox();
      this.CheckBox2 = new CheckBox();
      this.CheckBox1 = new CheckBox();
      this.lblBPM = new System.Windows.Forms.Label();
      this.YearFormat = new HScrollBar();
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
      this.Panel2 = new Panel();
      this.cmbGenre = new ComboBoxAutoComplete();
      this.lblGenreInfo = new System.Windows.Forms.Label();
      this.CheckBox9 = new CheckBox();
      this.btnMoveGenre = new Button();
      this.btnRemoveGenre = new Button();
      this.btnAddGenre = new Button();
      this.lblGenre = new System.Windows.Forms.Label();
      this.GenreList = new ListBox();
      this.panWeb = new Panel();
      this.Panel10 = new Panel();
      this.CheckBox32 = new CheckBox();
      this.CheckBox31 = new CheckBox();
      this.CheckBox30 = new CheckBox();
      this.CheckBox29 = new CheckBox();
      this.CheckBox28 = new CheckBox();
      this.CheckBox27 = new CheckBox();
      this.CheckBox26 = new CheckBox();
      this.CheckBox25 = new CheckBox();
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
      this.panRating = new Panel();
      this.Panel11 = new Panel();
      this.CheckBox33 = new CheckBox();
      this.lblInfo = new System.Windows.Forms.Label();
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
      this.lblRatingRating = new System.Windows.Forms.Label();
      this.lblRatingCounter = new System.Windows.Forms.Label();
      this.lblRatingUser = new System.Windows.Forms.Label();
      this.panInvolved = new Panel();
      this.Panel15 = new Panel();
      this.CheckBox45 = new CheckBox();
      this.lblMusicianInfo = new System.Windows.Forms.Label();
      this.txtMusicianName = new System.Windows.Forms.TextBox();
      this.btnRemoveMusician = new Button();
      this.btnAddMusician = new Button();
      this.lblMusicianName = new System.Windows.Forms.Label();
      this.lblMusicianInst = new System.Windows.Forms.Label();
      this.txtMusicianInst = new System.Windows.Forms.TextBox();
      this.TMCLList = new ListView();
      this.ColumnHeader15 = new ColumnHeader();
      this.ColumnHeader16 = new ColumnHeader();
      this.Panel16 = new Panel();
      this.CheckBox44 = new CheckBox();
      this.txtInvPerson = new System.Windows.Forms.TextBox();
      this.btnRemoveInv = new Button();
      this.btnAddInv = new Button();
      this.lblInvPerson = new System.Windows.Forms.Label();
      this.lblInvFunction = new System.Windows.Forms.Label();
      this.txtInvFunction = new System.Windows.Forms.TextBox();
      this.TIPLList = new ListView();
      this.ColumnHeader17 = new ColumnHeader();
      this.ColumnHeader18 = new ColumnHeader();
      this.panPic = new Panel();
      this.Panel7 = new Panel();
      this.chkPicRelativPath = new CheckBox();
      this.CheckBox34 = new CheckBox();
      this.btnRemovePicture = new Button();
      this.btnAddPicture = new Button();
      this.btnGetPic = new Button();
      this.chkPicInclude = new CheckBox();
      this.lblPicPath = new System.Windows.Forms.Label();
      this.txtPicPath = new System.Windows.Forms.TextBox();
      this.PicList = new ListView();
      this.ColumnHeader4 = new ColumnHeader();
      this.ColumnHeader5 = new ColumnHeader();
      this.ColumnHeader6 = new ColumnHeader();
      this.ColumnHeader7 = new ColumnHeader();
      this.lblPicType = new System.Windows.Forms.Label();
      this.lblPicDesc = new System.Windows.Forms.Label();
      this.cmbPicType = new ComboBox();
      this.txtPDescriptor = new System.Windows.Forms.TextBox();
      this.APICView = new PictureBox();
      this.panLyrics = new Panel();
      this.Panel8 = new Panel();
      this.txtLyrics = new RichTextBox();
      this.btnLyricsFile = new Button();
      this.CheckBox35 = new CheckBox();
      this.btnMoveLyrics = new Button();
      this.btnRemoveLyrics = new Button();
      this.btnAddLyrics = new Button();
      this.lblLyrics = new System.Windows.Forms.Label();
      this.lblLyLan = new System.Windows.Forms.Label();
      this.lblLyDesc = new System.Windows.Forms.Label();
      this.cmbLLanguage = new ComboBox();
      this.txtLDescriptor = new System.Windows.Forms.TextBox();
      this.LyricsList = new ListView();
      this.ColumnHeader1 = new ColumnHeader();
      this.ColumnHeader2 = new ColumnHeader();
      this.ColumnHeader3 = new ColumnHeader();
      this.panUser = new Panel();
      this.Panel12 = new Panel();
      this.CheckBox36 = new CheckBox();
      this.txtTXXXContent = new System.Windows.Forms.TextBox();
      this.btnRemoveTXXX = new Button();
      this.btnAddTXXX = new Button();
      this.lblTXXXContent = new System.Windows.Forms.Label();
      this.lblTXXXDesc = new System.Windows.Forms.Label();
      this.txtTXXXDesc = new System.Windows.Forms.TextBox();
      this.TXXXList = new ListView();
      this.ColumnHeader11 = new ColumnHeader();
      this.ColumnHeader12 = new ColumnHeader();
      this.Panel13 = new Panel();
      this.CheckBox37 = new CheckBox();
      this.txtWXXXContent = new System.Windows.Forms.TextBox();
      this.btnRemoveWXXX = new Button();
      this.btnAddWXXX = new Button();
      this.lblWXXXContent = new System.Windows.Forms.Label();
      this.lblWXXXDesc = new System.Windows.Forms.Label();
      this.txtWXXXDesc = new System.Windows.Forms.TextBox();
      this.WXXXList = new ListView();
      this.ColumnHeader13 = new ColumnHeader();
      this.ColumnHeader14 = new ColumnHeader();
      this.lblDigits = new System.Windows.Forms.Label();
      this.txtDigits = new NumericUpDown();
      this.OpenFileDialog = new System.Windows.Forms.OpenFileDialog();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.chkRemoveAllNOT = new CheckBox();
      this.lblInfoStar = new System.Windows.Forms.Label();
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
      this.TAGV2grpCommands = new ExplorerBarGroupItem();
      this.btnSwapAT = new ButtonItem();
      this.btnSwapAA = new ButtonItem();
      this.btnSwapTA = new ButtonItem();
      this.btnImport = new ButtonItem();
      this.btnExport = new ButtonItem();
      this.btnGet = new ButtonItem();
      this.TopPanel = new PanelEx();
      this.btnOK = new Button();
      this.btnCancel = new Button();
      this.ButtomPanel = new PanelEx();
      this.Label = new ButtonItem();
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
      this.txtRatingCounter.BeginInit();
      this.txtRatingRating.BeginInit();
      this.panInvolved.SuspendLayout();
      this.Panel15.SuspendLayout();
      this.Panel16.SuspendLayout();
      this.panPic.SuspendLayout();
      this.Panel7.SuspendLayout();
      this.panLyrics.SuspendLayout();
      this.Panel8.SuspendLayout();
      this.panUser.SuspendLayout();
      this.Panel12.SuspendLayout();
      this.Panel13.SuspendLayout();
      this.txtDigits.BeginInit();
      ((ISupportInitialize)this.SelectionBar).BeginInit();
      this.ButtomPanel.SuspendLayout();
      this.SuspendLayout();
      this.panDetail.Controls.Add(this.Panel9);
      this.panDetail.Controls.Add(this.Panel5);
      this.panDetail.Controls.Add(this.Panel14);
      this.panDetail.Controls.Add(this.Panel4);
      this.panDetail.Location = new Point(0xa8, 0x18);
      this.panDetail.Name = "panDetail";
      this.panDetail.Size = new Size(0x2b0, 0x1c8);
      this.panDetail.TabIndex = 4;
      this.Panel9.BorderStyle = BorderStyle.FixedSingle;
      this.Panel9.Controls.Add(this.cmbMedia);
      this.Panel9.Controls.Add(this.lblMediaTyp);
      this.Panel9.Controls.Add(this.chkTLEN);
      this.Panel9.Controls.Add(this.lblTLEN);
      this.Panel9.Controls.Add(this.CheckBox5);
      this.Panel9.Location = new Point(8, 0x178);
      this.Panel9.Name = "Panel9";
      this.Panel9.Size = new Size(0x2a0, 0x40);
      this.Panel9.TabIndex = 3;
      this.cmbMedia.ItemHeight = 13;
      this.cmbMedia.Items.AddRange(new object[] { "ANA (Other analogue media)", "CD (CD)", "DAT (DAT)", "DCC (DCC)", "DIG (Other digital media)", "DVD (DVD)", "LD (LaserDisc)", "MC (Music Cassette)", "MD (MiniDisc)", "RAD (Radio)", "REE (Reel)", "TEL (Telephone)", "TT (Turntable records)", "TV (Television)", "VID (Video)" });
      this.cmbMedia.Location = new Point(0xa7, 8);
      this.cmbMedia.Name = "cmbMedia";
      this.cmbMedia.Size = new Size(0xd1, 0x15);
      this.cmbMedia.TabIndex = 0x13;
      this.lblMediaTyp.ImeMode = ImeMode.NoControl;
      this.lblMediaTyp.Location = new Point(8, 10);
      this.lblMediaTyp.Name = "lblMediaTyp";
      this.lblMediaTyp.Size = new Size(120, 0x10);
      this.lblMediaTyp.TabIndex = 0x12;
      this.lblMediaTyp.Text = "M&edia type:";
      this.chkTLEN.ImeMode = ImeMode.NoControl;
      this.chkTLEN.Location = new Point(0xa7, 40);
      this.chkTLEN.Name = "chkTLEN";
      this.chkTLEN.Size = new Size(0xe8, 0x10);
      this.chkTLEN.TabIndex = 0x21;
      this.chkTLEN.Text = "Create track length entry from file";
      this.lblTLEN.ImeMode = ImeMode.NoControl;
      this.lblTLEN.Location = new Point(8, 40);
      this.lblTLEN.Name = "lblTLEN";
      this.lblTLEN.Size = new Size(0x70, 0x10);
      this.lblTLEN.TabIndex = 0x20;
      this.lblTLEN.Text = "Track length (msec):";
      this.CheckBox5.ImeMode = ImeMode.NoControl;
      this.CheckBox5.Location = new Point(0x180, 10);
      this.CheckBox5.Name = "CheckBox5";
      this.CheckBox5.Size = new Size(0x10, 0x10);
      this.CheckBox5.TabIndex = 20;
      this.Panel5.BorderStyle = BorderStyle.FixedSingle;
      this.Panel5.Controls.Add(this.CheckBox16);
      this.Panel5.Controls.Add(this.CheckBox15);
      this.Panel5.Controls.Add(this.txtContent);
      this.Panel5.Controls.Add(this.txtSubTitle);
      this.Panel5.Controls.Add(this.lblSubTitle);
      this.Panel5.Controls.Add(this.lblContent);
      this.Panel5.Location = new Point(8, 0xe0);
      this.Panel5.Name = "Panel5";
      this.Panel5.Size = new Size(0x2a0, 0x38);
      this.Panel5.TabIndex = 1;
      this.CheckBox16.ImeMode = ImeMode.NoControl;
      this.CheckBox16.Location = new Point(0x288, 0x20);
      this.CheckBox16.Name = "CheckBox16";
      this.CheckBox16.Size = new Size(0x10, 0x10);
      this.CheckBox16.TabIndex = 0x15;
      this.CheckBox15.ImeMode = ImeMode.NoControl;
      this.CheckBox15.Location = new Point(0x288, 8);
      this.CheckBox15.Name = "CheckBox15";
      this.CheckBox15.Size = new Size(0x10, 0x10);
      this.CheckBox15.TabIndex = 0x12;
      this.txtContent.Location = new Point(0xa8, 6);
      this.txtContent.Name = "txtContent";
      this.txtContent.Size = new Size(0x1d8, 20);
      this.txtContent.TabIndex = 0x11;
      this.txtContent.Text = "";
      this.txtSubTitle.Location = new Point(0xa8, 30);
      this.txtSubTitle.Name = "txtSubTitle";
      this.txtSubTitle.Size = new Size(0x1d8, 20);
      this.txtSubTitle.TabIndex = 20;
      this.txtSubTitle.Text = "";
      this.lblSubTitle.ImeMode = ImeMode.NoControl;
      this.lblSubTitle.Location = new Point(8, 0x20);
      this.lblSubTitle.Name = "lblSubTitle";
      this.lblSubTitle.Size = new Size(0x80, 0x10);
      this.lblSubTitle.TabIndex = 0x13;
      this.lblSubTitle.Text = "&Sub Title:";
      this.lblContent.ImeMode = ImeMode.NoControl;
      this.lblContent.Location = new Point(8, 8);
      this.lblContent.Name = "lblContent";
      this.lblContent.Size = new Size(0x80, 0x10);
      this.lblContent.TabIndex = 0x10;
      this.lblContent.Text = "Con&tent Group:";
      this.Panel14.BorderStyle = BorderStyle.FixedSingle;
      this.Panel14.Controls.Add(this.CheckBox41);
      this.Panel14.Controls.Add(this.CheckBox42);
      this.Panel14.Controls.Add(this.CheckBox43);
      this.Panel14.Controls.Add(this.txtSortArtist);
      this.Panel14.Controls.Add(this.txtSortTitle);
      this.Panel14.Controls.Add(this.txtSortAlbum);
      this.Panel14.Controls.Add(this.lblAlbumSort);
      this.Panel14.Controls.Add(this.lblTitleSort);
      this.Panel14.Controls.Add(this.lblArtistSort);
      this.Panel14.Location = new Point(8, 0x120);
      this.Panel14.Name = "Panel14";
      this.Panel14.Size = new Size(0x2a0, 80);
      this.Panel14.TabIndex = 2;
      this.CheckBox41.ImeMode = ImeMode.NoControl;
      this.CheckBox41.Location = new Point(0x288, 0x38);
      this.CheckBox41.Name = "CheckBox41";
      this.CheckBox41.Size = new Size(0x10, 0x10);
      this.CheckBox41.TabIndex = 30;
      this.CheckBox42.ImeMode = ImeMode.NoControl;
      this.CheckBox42.Location = new Point(0x288, 0x20);
      this.CheckBox42.Name = "CheckBox42";
      this.CheckBox42.Size = new Size(0x10, 0x10);
      this.CheckBox42.TabIndex = 0x1b;
      this.CheckBox43.ImeMode = ImeMode.NoControl;
      this.CheckBox43.Location = new Point(0x288, 8);
      this.CheckBox43.Name = "CheckBox43";
      this.CheckBox43.Size = new Size(0x10, 0x10);
      this.CheckBox43.TabIndex = 0x18;
      this.txtSortArtist.Location = new Point(0xa8, 6);
      this.txtSortArtist.Name = "txtSortArtist";
      this.txtSortArtist.Size = new Size(0x1d8, 20);
      this.txtSortArtist.TabIndex = 0x17;
      this.txtSortArtist.Text = "";
      this.txtSortTitle.Location = new Point(0xa8, 0x36);
      this.txtSortTitle.Name = "txtSortTitle";
      this.txtSortTitle.Size = new Size(0x1d8, 20);
      this.txtSortTitle.TabIndex = 0x1d;
      this.txtSortTitle.Text = "";
      this.txtSortAlbum.Location = new Point(0xa8, 30);
      this.txtSortAlbum.Name = "txtSortAlbum";
      this.txtSortAlbum.Size = new Size(0x1d8, 20);
      this.txtSortAlbum.TabIndex = 0x1a;
      this.txtSortAlbum.Text = "";
      this.lblAlbumSort.ImeMode = ImeMode.NoControl;
      this.lblAlbumSort.Location = new Point(8, 0x20);
      this.lblAlbumSort.Name = "lblAlbumSort";
      this.lblAlbumSort.Size = new Size(0xa8, 0x10);
      this.lblAlbumSort.TabIndex = 0x19;
      this.lblAlbumSort.Text = "Al&bum sort name (Ver. 2.4 only):";
      this.lblTitleSort.ImeMode = ImeMode.NoControl;
      this.lblTitleSort.Location = new Point(8, 0x38);
      this.lblTitleSort.Name = "lblTitleSort";
      this.lblTitleSort.Size = new Size(160, 0x10);
      this.lblTitleSort.TabIndex = 0x1c;
      this.lblTitleSort.Text = "&Title sort name (Ver. 2.4 only):";
      this.lblArtistSort.ImeMode = ImeMode.NoControl;
      this.lblArtistSort.Location = new Point(8, 8);
      this.lblArtistSort.Name = "lblArtistSort";
      this.lblArtistSort.Size = new Size(0xa8, 0x10);
      this.lblArtistSort.TabIndex = 0x16;
      this.lblArtistSort.Text = "&Artist sort name (Ver. 2.4 only):";
      this.Panel4.BorderStyle = BorderStyle.FixedSingle;
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
      this.Panel4.Location = new Point(8, 8);
      this.Panel4.Name = "Panel4";
      this.Panel4.Size = new Size(0x2a0, 0xd0);
      this.Panel4.TabIndex = 0;
      this.CheckBox14.ImeMode = ImeMode.NoControl;
      this.CheckBox14.Location = new Point(0x288, 0x51);
      this.CheckBox14.Name = "CheckBox14";
      this.CheckBox14.Size = new Size(0x10, 0x10);
      this.CheckBox14.TabIndex = 15;
      this.CheckBox13.ImeMode = ImeMode.NoControl;
      this.CheckBox13.Location = new Point(0x288, 0x39);
      this.CheckBox13.Name = "CheckBox13";
      this.CheckBox13.Size = new Size(0x10, 0x10);
      this.CheckBox13.TabIndex = 12;
      this.CheckBox12.ImeMode = ImeMode.NoControl;
      this.CheckBox12.Location = new Point(0x288, 0x21);
      this.CheckBox12.Name = "CheckBox12";
      this.CheckBox12.Size = new Size(0x10, 0x10);
      this.CheckBox12.TabIndex = 9;
      this.CheckBox11.ImeMode = ImeMode.NoControl;
      this.CheckBox11.Location = new Point(0x288, 9);
      this.CheckBox11.Name = "CheckBox11";
      this.CheckBox11.Size = new Size(0x10, 0x10);
      this.CheckBox11.TabIndex = 6;
      this.txtComposer.Location = new Point(0xa8, 0x4e);
      this.txtComposer.Name = "txtComposer";
      this.txtComposer.Size = new Size(0x1d8, 20);
      this.txtComposer.TabIndex = 14;
      this.txtComposer.Text = "";
      this.lblComposer.ImeMode = ImeMode.NoControl;
      this.lblComposer.Location = new Point(8, 80);
      this.lblComposer.Name = "lblComposer";
      this.lblComposer.Size = new Size(0x80, 0x10);
      this.lblComposer.TabIndex = 13;
      this.lblComposer.Text = "Co&mposer:";
      this.txtBand.Location = new Point(0xa8, 6);
      this.txtBand.Name = "txtBand";
      this.txtBand.Size = new Size(0x1d8, 20);
      this.txtBand.TabIndex = 5;
      this.txtBand.Text = "";
      this.txtModified.Location = new Point(0xa8, 0x36);
      this.txtModified.Name = "txtModified";
      this.txtModified.Size = new Size(0x1d8, 20);
      this.txtModified.TabIndex = 11;
      this.txtModified.Text = "";
      this.txtConductor.Location = new Point(0xa8, 30);
      this.txtConductor.Name = "txtConductor";
      this.txtConductor.Size = new Size(0x1d8, 20);
      this.txtConductor.TabIndex = 8;
      this.txtConductor.Text = "";
      this.lblConductor.ImeMode = ImeMode.NoControl;
      this.lblConductor.Location = new Point(8, 0x20);
      this.lblConductor.Name = "lblConductor";
      this.lblConductor.Size = new Size(0x80, 0x10);
      this.lblConductor.TabIndex = 7;
      this.lblConductor.Text = "&Conductor:";
      this.lblModified.ImeMode = ImeMode.NoControl;
      this.lblModified.Location = new Point(8, 0x38);
      this.lblModified.Name = "lblModified";
      this.lblModified.Size = new Size(0x80, 0x10);
      this.lblModified.TabIndex = 10;
      this.lblModified.Text = "Modified / Remixed b&y:";
      this.lblBand.ImeMode = ImeMode.NoControl;
      this.lblBand.Location = new Point(8, 8);
      this.lblBand.Name = "lblBand";
      this.lblBand.Size = new Size(0x80, 0x10);
      this.lblBand.TabIndex = 4;
      this.lblBand.Text = "&Band / Orchestra:";
      this.CheckBox40.ImeMode = ImeMode.NoControl;
      this.CheckBox40.Location = new Point(0x288, 0xb0);
      this.CheckBox40.Name = "CheckBox40";
      this.CheckBox40.Size = new Size(0x10, 0x10);
      this.CheckBox40.TabIndex = 11;
      this.txtCopyright.Location = new Point(0xa8, 0xaf);
      this.txtCopyright.Name = "txtCopyright";
      this.txtCopyright.Size = new Size(0x1d8, 20);
      this.txtCopyright.TabIndex = 10;
      this.txtCopyright.Text = "";
      this.lblCopyright.ImeMode = ImeMode.NoControl;
      this.lblCopyright.Location = new Point(8, 0xaf);
      this.lblCopyright.Name = "lblCopyright";
      this.lblCopyright.Size = new Size(0x80, 0x10);
      this.lblCopyright.TabIndex = 9;
      this.lblCopyright.Text = "Copyright:";
      this.CheckBox19.ImeMode = ImeMode.NoControl;
      this.CheckBox19.Location = new Point(0x288, 0x98);
      this.CheckBox19.Name = "CheckBox19";
      this.CheckBox19.Size = new Size(0x10, 0x10);
      this.CheckBox19.TabIndex = 8;
      this.CheckBox18.ImeMode = ImeMode.NoControl;
      this.CheckBox18.Location = new Point(0x288, 0x80);
      this.CheckBox18.Name = "CheckBox18";
      this.CheckBox18.Size = new Size(0x10, 0x10);
      this.CheckBox18.TabIndex = 5;
      this.CheckBox17.ImeMode = ImeMode.NoControl;
      this.CheckBox17.Location = new Point(0x288, 0x68);
      this.CheckBox17.Name = "CheckBox17";
      this.CheckBox17.Size = new Size(0x10, 0x10);
      this.CheckBox17.TabIndex = 2;
      this.txtLyWriter.Location = new Point(0xa8, 0x67);
      this.txtLyWriter.Name = "txtLyWriter";
      this.txtLyWriter.Size = new Size(0x1d8, 20);
      this.txtLyWriter.TabIndex = 1;
      this.txtLyWriter.Text = "";
      this.txtEncoded.Location = new Point(0xa8, 0x97);
      this.txtEncoded.Name = "txtEncoded";
      this.txtEncoded.Size = new Size(0x1d8, 20);
      this.txtEncoded.TabIndex = 7;
      this.txtEncoded.Text = "";
      this.txtPublisher.Location = new Point(0xa8, 0x7f);
      this.txtPublisher.Name = "txtPublisher";
      this.txtPublisher.Size = new Size(0x1d8, 20);
      this.txtPublisher.TabIndex = 4;
      this.txtPublisher.Text = "";
      this.lblPublisher.ImeMode = ImeMode.NoControl;
      this.lblPublisher.Location = new Point(8, 0x7f);
      this.lblPublisher.Name = "lblPublisher";
      this.lblPublisher.Size = new Size(0x80, 0x10);
      this.lblPublisher.TabIndex = 3;
      this.lblPublisher.Text = "Publis&her:";
      this.lblEncoded.ImeMode = ImeMode.NoControl;
      this.lblEncoded.Location = new Point(8, 0x97);
      this.lblEncoded.Name = "lblEncoded";
      this.lblEncoded.Size = new Size(0x80, 0x10);
      this.lblEncoded.TabIndex = 6;
      this.lblEncoded.Text = "&Encoded by:";
      this.lblLyWriter.ImeMode = ImeMode.NoControl;
      this.lblLyWriter.Location = new Point(8, 0x67);
      this.lblLyWriter.Name = "lblLyWriter";
      this.lblLyWriter.Size = new Size(0x80, 0x10);
      this.lblLyWriter.TabIndex = 0;
      this.lblLyWriter.Text = "Lyr&ics / Text Writer:";
      this.panOriginal.Controls.Add(this.Panel6);
      this.panOriginal.Location = new Point(0xa8, 0x18);
      this.panOriginal.Name = "panOriginal";
      this.panOriginal.Size = new Size(0x2b0, 240);
      this.panOriginal.TabIndex = 5;
      this.Panel6.BorderStyle = BorderStyle.FixedSingle;
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
      this.Panel6.Location = new Point(8, 8);
      this.Panel6.Name = "Panel6";
      this.Panel6.Size = new Size(0x2a0, 0xb0);
      this.Panel6.TabIndex = 3;
      this.txtTORY.Flags = 0;
      this.txtTORY.Location = new Point(0xa8, 0x7e);
      this.txtTORY.Mask = "####-##-##";
      this.txtTORY.Name = "txtTORY";
      this.txtTORY.Size = new Size(0x70, 20);
      this.txtTORY.TabIndex = 0x2f;
      this.CheckBox39.ImeMode = ImeMode.NoControl;
      this.CheckBox39.Location = new Point(0x150, 0x80);
      this.CheckBox39.Name = "CheckBox39";
      this.CheckBox39.Size = new Size(0x10, 0x10);
      this.CheckBox39.TabIndex = 0x33;
      this.lblOYearInfo.ImeMode = ImeMode.NoControl;
      this.lblOYearInfo.Location = new Point(0xa8, 0x98);
      this.lblOYearInfo.Name = "lblOYearInfo";
      this.lblOYearInfo.Size = new Size(0x150, 0x10);
      this.lblOYearInfo.TabIndex = 50;
      this.lblOYearInfo.Text = "(In TAG Ver. 2.3 only the year entry will be saved)";
      this.TORYFormat.ImeMode = ImeMode.NoControl;
      this.TORYFormat.LargeChange = 1;
      this.TORYFormat.Location = new Point(0x120, 0x80);
      this.TORYFormat.Maximum = 2;
      this.TORYFormat.Name = "TORYFormat";
      this.TORYFormat.Size = new Size(0x20, 0x10);
      this.TORYFormat.TabIndex = 0x30;
      this.lblOYear.ImeMode = ImeMode.NoControl;
      this.lblOYear.Location = new Point(8, 0x80);
      this.lblOYear.Name = "lblOYear";
      this.lblOYear.Size = new Size(0x90, 0x10);
      this.lblOYear.TabIndex = 0x2e;
      this.lblOYear.Text = "Original release &year (date):";
      this.CheckBox24.ImeMode = ImeMode.NoControl;
      this.CheckBox24.Location = new Point(0x288, 0x68);
      this.CheckBox24.Name = "CheckBox24";
      this.CheckBox24.Size = new Size(0x10, 0x10);
      this.CheckBox24.TabIndex = 0x2d;
      this.CheckBox23.ImeMode = ImeMode.NoControl;
      this.CheckBox23.Location = new Point(0x288, 80);
      this.CheckBox23.Name = "CheckBox23";
      this.CheckBox23.Size = new Size(0x10, 0x10);
      this.CheckBox23.TabIndex = 0x2a;
      this.CheckBox22.ImeMode = ImeMode.NoControl;
      this.CheckBox22.Location = new Point(0x288, 0x38);
      this.CheckBox22.Name = "CheckBox22";
      this.CheckBox22.Size = new Size(0x10, 0x10);
      this.CheckBox22.TabIndex = 0x27;
      this.CheckBox21.ImeMode = ImeMode.NoControl;
      this.CheckBox21.Location = new Point(0x288, 0x20);
      this.CheckBox21.Name = "CheckBox21";
      this.CheckBox21.Size = new Size(0x10, 0x10);
      this.CheckBox21.TabIndex = 0x24;
      this.CheckBox20.ImeMode = ImeMode.NoControl;
      this.CheckBox20.Location = new Point(0x288, 8);
      this.CheckBox20.Name = "CheckBox20";
      this.CheckBox20.Size = new Size(0x10, 0x10);
      this.CheckBox20.TabIndex = 0x21;
      this.txtOOwner.Location = new Point(0xa8, 0x66);
      this.txtOOwner.Name = "txtOOwner";
      this.txtOOwner.Size = new Size(0x1d8, 20);
      this.txtOOwner.TabIndex = 0x2c;
      this.txtOOwner.Text = "";
      this.lblOOwner.ImeMode = ImeMode.NoControl;
      this.lblOOwner.Location = new Point(8, 0x68);
      this.lblOOwner.Name = "lblOOwner";
      this.lblOOwner.Size = new Size(0x80, 0x10);
      this.lblOOwner.TabIndex = 0x2b;
      this.lblOOwner.Text = "Original &owner:";
      this.txtOArtist.Location = new Point(0xa8, 0x4e);
      this.txtOArtist.Name = "txtOArtist";
      this.txtOArtist.Size = new Size(0x1d8, 20);
      this.txtOArtist.TabIndex = 0x29;
      this.txtOArtist.Text = "";
      this.lblOArtist.ImeMode = ImeMode.NoControl;
      this.lblOArtist.Location = new Point(8, 80);
      this.lblOArtist.Name = "lblOArtist";
      this.lblOArtist.Size = new Size(0x80, 0x10);
      this.lblOArtist.TabIndex = 40;
      this.lblOArtist.Text = "Original &artist:";
      this.txtOAlbum.Location = new Point(0xa8, 6);
      this.txtOAlbum.Name = "txtOAlbum";
      this.txtOAlbum.Size = new Size(0x1d8, 20);
      this.txtOAlbum.TabIndex = 0x20;
      this.txtOAlbum.Text = "";
      this.txtOLyWriter.Location = new Point(0xa8, 0x36);
      this.txtOLyWriter.Name = "txtOLyWriter";
      this.txtOLyWriter.Size = new Size(0x1d8, 20);
      this.txtOLyWriter.TabIndex = 0x26;
      this.txtOLyWriter.Text = "";
      this.txtOFilename.Location = new Point(0xa8, 30);
      this.txtOFilename.Name = "txtOFilename";
      this.txtOFilename.Size = new Size(0x1d8, 20);
      this.txtOFilename.TabIndex = 0x23;
      this.txtOFilename.Text = "";
      this.lblOFilename.ImeMode = ImeMode.NoControl;
      this.lblOFilename.Location = new Point(8, 0x20);
      this.lblOFilename.Name = "lblOFilename";
      this.lblOFilename.Size = new Size(0x80, 0x10);
      this.lblOFilename.TabIndex = 0x22;
      this.lblOFilename.Text = "Original &filename:";
      this.lblOLyWriter.ImeMode = ImeMode.NoControl;
      this.lblOLyWriter.Location = new Point(8, 0x38);
      this.lblOLyWriter.Name = "lblOLyWriter";
      this.lblOLyWriter.Size = new Size(0x80, 0x10);
      this.lblOLyWriter.TabIndex = 0x25;
      this.lblOLyWriter.Text = "Original lyrics &writer:";
      this.lblOAlbum.ImeMode = ImeMode.NoControl;
      this.lblOAlbum.Location = new Point(8, 8);
      this.lblOAlbum.Name = "lblOAlbum";
      this.lblOAlbum.Size = new Size(0x80, 0x10);
      this.lblOAlbum.TabIndex = 0x1f;
      this.lblOAlbum.Text = "Original a&lbum title:";
      this.panMain.Controls.Add(this.Panel3);
      this.panMain.Controls.Add(this.Panel1);
      this.panMain.Controls.Add(this.Panel2);
      this.panMain.Location = new Point(0xa8, 0x18);
      this.panMain.Name = "panMain";
      this.panMain.Size = new Size(0x2b0, 0x1c8);
      this.panMain.TabIndex = 4;
      this.Panel3.BorderStyle = BorderStyle.FixedSingle;
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
      this.Panel3.Location = new Point(8, 0x108);
      this.Panel3.Name = "Panel3";
      this.Panel3.Size = new Size(0x2a0, 0xb8);
      this.Panel3.TabIndex = 3;
      this.lblCommDescInfo.BorderStyle = BorderStyle.Fixed3D;
      this.lblCommDescInfo.ImeMode = ImeMode.NoControl;
      this.lblCommDescInfo.Location = new Point(8, 0x70);
      this.lblCommDescInfo.Name = "lblCommDescInfo";
      this.lblCommDescInfo.Size = new Size(120, 0x40);
      this.lblCommDescInfo.TabIndex = 0x33;
      this.lblCommDescInfo.Text = "Predefined comment descriptors can be set under Edit Libraries (Options menu)";
      this.lblCommDescInfo.TextAlign = ContentAlignment.MiddleCenter;
      this.cmbCDescriptor.Autocomplete = true;
      this.cmbCDescriptor.ItemHeight = 13;
      this.cmbCDescriptor.Location = new Point(0x88, 6);
      this.cmbCDescriptor.Name = "cmbCDescriptor";
      this.cmbCDescriptor.Size = new Size(0x100, 0x15);
      this.cmbCDescriptor.TabIndex = 40;
      this.CheckBox38.ImeMode = ImeMode.NoControl;
      this.CheckBox38.Location = new Point(400, 0x38);
      this.CheckBox38.Name = "CheckBox38";
      this.CheckBox38.Size = new Size(0x10, 0x10);
      this.CheckBox38.TabIndex = 0x2d;
      this.CheckBox38.Visible = false;
      this.CheckBox10.ImeMode = ImeMode.NoControl;
      this.CheckBox10.Location = new Point(0x1a8, 0x58);
      this.CheckBox10.Name = "CheckBox10";
      this.CheckBox10.Size = new Size(0xe0, 0x10);
      this.CheckBox10.TabIndex = 0x30;
      this.CheckBox10.Text = "Remove all existing comments first";
      this.btnMoveComment.ImeMode = ImeMode.NoControl;
      this.btnMoveComment.Location = new Point(0x1a8, 0x38);
      this.btnMoveComment.Name = "btnMoveComment";
      this.btnMoveComment.Size = new Size(240, 20);
      this.btnMoveComment.TabIndex = 0x2f;
      this.btnMoveComment.Text = "Move Comment to top";
      this.btnRemoveComment.ImeMode = ImeMode.NoControl;
      this.btnRemoveComment.Location = new Point(0x1a8, 0x20);
      this.btnRemoveComment.Name = "btnRemoveComment";
      this.btnRemoveComment.Size = new Size(240, 20);
      this.btnRemoveComment.TabIndex = 0x2e;
      this.btnRemoveComment.Text = "Remove Comment";
      this.btnAddComment.ImeMode = ImeMode.NoControl;
      this.btnAddComment.Location = new Point(0x1a8, 8);
      this.btnAddComment.Name = "btnAddComment";
      this.btnAddComment.Size = new Size(240, 20);
      this.btnAddComment.TabIndex = 0x2d;
      this.btnAddComment.Text = "Add Comment";
      this.lblCOMM.ImeMode = ImeMode.NoControl;
      this.lblCOMM.Location = new Point(8, 0x38);
      this.lblCOMM.Name = "lblCOMM";
      this.lblCOMM.Size = new Size(0x80, 0x10);
      this.lblCOMM.TabIndex = 0x2b;
      this.lblCOMM.Text = "&Comment:";
      this.lblCOMMLan.ImeMode = ImeMode.NoControl;
      this.lblCOMMLan.Location = new Point(8, 0x20);
      this.lblCOMMLan.Name = "lblCOMMLan";
      this.lblCOMMLan.Size = new Size(0x80, 0x10);
      this.lblCOMMLan.TabIndex = 0x29;
      this.lblCOMMLan.Text = "Comment &Language:";
      this.lblCOMMDesc.ImeMode = ImeMode.NoControl;
      this.lblCOMMDesc.Location = new Point(8, 8);
      this.lblCOMMDesc.Name = "lblCOMMDesc";
      this.lblCOMMDesc.Size = new Size(0x80, 0x10);
      this.lblCOMMDesc.TabIndex = 0x27;
      this.lblCOMMDesc.Text = "Comment &Descriptor:";
      this.cmbCLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbCLanguage.ItemHeight = 13;
      this.cmbCLanguage.Location = new Point(0x88, 30);
      this.cmbCLanguage.Name = "cmbCLanguage";
      this.cmbCLanguage.Size = new Size(0x100, 0x15);
      this.cmbCLanguage.TabIndex = 0x2a;
      this.txtComment.AcceptsReturn = true;
      this.txtComment.Location = new Point(0x88, 0x38);
      this.txtComment.Multiline = true;
      this.txtComment.Name = "txtComment";
      this.txtComment.Size = new Size(0x100, 0x30);
      this.txtComment.TabIndex = 0x2c;
      this.txtComment.Text = "";
      this.CommentList.CheckBoxes = true;
      this.CommentList.Columns.AddRange(new ColumnHeader[] { this.colDescriptor, this.colComment, this.colLanguage });
      this.CommentList.FullRowSelect = true;
      this.CommentList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.CommentList.Location = new Point(0x88, 0x70);
      this.CommentList.MultiSelect = false;
      this.CommentList.Name = "CommentList";
      this.CommentList.Size = new Size(0x210, 0x40);
      this.CommentList.TabIndex = 0x31;
      this.CommentList.View = View.Details;
      this.colDescriptor.Text = "Descriptor";
      this.colDescriptor.Width = 0x7c;
      this.colComment.Text = "Comment";
      this.colComment.Width = 0x108;
      this.colLanguage.Text = "Language";
      this.colLanguage.Width = 0x5f;
      this.Panel1.BorderStyle = BorderStyle.FixedSingle;
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
      this.Panel1.Location = new Point(8, 8);
      this.Panel1.Name = "Panel1";
      this.Panel1.Size = new Size(0x2a0, 0x80);
      this.Panel1.TabIndex = 1;
      this.txtPOS2.AllowNegative = false;
      this.txtPOS2.DigitsInGroup = 0;
      this.txtPOS2.Flags = 0x10000;
      this.txtPOS2.Location = new Point(560, 0x66);
      this.txtPOS2.MaxDecimalPlaces = 0;
      this.txtPOS2.MaxLength = 6;
      this.txtPOS2.MaxWholeDigits = 6;
      this.txtPOS2.Name = "txtPOS2";
      this.txtPOS2.Prefix = "";
      this.txtPOS2.RangeMax = 999999.0;
      this.txtPOS2.RangeMin = 0.0;
      this.txtPOS2.Size = new Size(0x40, 20);
      this.txtPOS2.TabIndex = 0x1a;
      this.txtPOS1.AllowNegative = false;
      this.txtPOS1.DigitsInGroup = 0;
      this.txtPOS1.Flags = 0x10000;
      this.txtPOS1.Location = new Point(0x1d8, 0x66);
      this.txtPOS1.MaxDecimalPlaces = 0;
      this.txtPOS1.MaxLength = 6;
      this.txtPOS1.MaxWholeDigits = 6;
      this.txtPOS1.Name = "txtPOS1";
      this.txtPOS1.Prefix = "";
      this.txtPOS1.RangeMax = 999999.0;
      this.txtPOS1.RangeMin = 0.0;
      this.txtPOS1.Size = new Size(0x40, 20);
      this.txtPOS1.TabIndex = 0x19;
      this.txtTrack2.AllowNegative = false;
      this.txtTrack2.DigitsInGroup = 0;
      this.txtTrack2.Flags = 0x10000;
      this.txtTrack2.Location = new Point(0xe0, 0x66);
      this.txtTrack2.MaxDecimalPlaces = 0;
      this.txtTrack2.MaxLength = 6;
      this.txtTrack2.MaxWholeDigits = 6;
      this.txtTrack2.Name = "txtTrack2";
      this.txtTrack2.Prefix = "";
      this.txtTrack2.RangeMax = 999999.0;
      this.txtTrack2.RangeMin = 0.0;
      this.txtTrack2.Size = new Size(0x40, 20);
      this.txtTrack2.TabIndex = 0x17;
      this.txtTrack1.AllowNegative = false;
      this.txtTrack1.DigitsInGroup = 0;
      this.txtTrack1.Flags = 0x10000;
      this.txtTrack1.Location = new Point(0x88, 0x66);
      this.txtTrack1.MaxDecimalPlaces = 0;
      this.txtTrack1.MaxLength = 6;
      this.txtTrack1.MaxWholeDigits = 6;
      this.txtTrack1.Name = "txtTrack1";
      this.txtTrack1.Prefix = "";
      this.txtTrack1.RangeMax = 999999.0;
      this.txtTrack1.RangeMin = 0.0;
      this.txtTrack1.Size = new Size(0x40, 20);
      this.txtTrack1.TabIndex = 0x16;
      this.txtYear.Flags = 0;
      this.txtYear.Location = new Point(0x88, 0x4e);
      this.txtYear.Mask = "####-##-##";
      this.txtYear.Name = "txtYear";
      this.txtYear.Size = new Size(0x70, 20);
      this.txtYear.TabIndex = 14;
      this.txtBPM.AllowNegative = false;
      this.txtBPM.DigitsInGroup = 0;
      this.txtBPM.Flags = 0x10000;
      this.txtBPM.Location = new Point(0x1d8, 80);
      this.txtBPM.MaxDecimalPlaces = 0;
      this.txtBPM.MaxLength = 3;
      this.txtBPM.MaxWholeDigits = 3;
      this.txtBPM.Name = "txtBPM";
      this.txtBPM.Prefix = "";
      this.txtBPM.RangeMax = 999999.0;
      this.txtBPM.RangeMin = 1.0;
      this.txtBPM.Size = new Size(0x98, 20);
      this.txtBPM.TabIndex = 0x13;
      this.cmbArtist.Autocomplete = true;
      this.cmbArtist.ItemHeight = 13;
      this.cmbArtist.Location = new Point(0x88, 6);
      this.cmbArtist.Name = "cmbArtist";
      this.cmbArtist.Size = new Size(0x1e8, 0x15);
      this.cmbArtist.TabIndex = 5;
      this.CheckBox8.ImeMode = ImeMode.NoControl;
      this.CheckBox8.Location = new Point(0x278, 80);
      this.CheckBox8.Name = "CheckBox8";
      this.CheckBox8.Size = new Size(0x10, 0x10);
      this.CheckBox8.TabIndex = 20;
      this.CheckBox7.ImeMode = ImeMode.NoControl;
      this.CheckBox7.Location = new Point(0x278, 0x68);
      this.CheckBox7.Name = "CheckBox7";
      this.CheckBox7.Size = new Size(0x10, 0x10);
      this.CheckBox7.TabIndex = 0x1c;
      this.CheckBox6.ImeMode = ImeMode.NoControl;
      this.CheckBox6.Location = new Point(0x130, 0x68);
      this.CheckBox6.Name = "CheckBox6";
      this.CheckBox6.Size = new Size(0x10, 0x10);
      this.CheckBox6.TabIndex = 0x18;
      this.CheckBox4.ImeMode = ImeMode.NoControl;
      this.CheckBox4.Location = new Point(0x130, 80);
      this.CheckBox4.Name = "CheckBox4";
      this.CheckBox4.Size = new Size(0x10, 0x10);
      this.CheckBox4.TabIndex = 0x11;
      this.CheckBox3.ImeMode = ImeMode.NoControl;
      this.CheckBox3.Location = new Point(0x278, 0x38);
      this.CheckBox3.Name = "CheckBox3";
      this.CheckBox3.Size = new Size(0x10, 0x10);
      this.CheckBox3.TabIndex = 12;
      this.CheckBox2.ImeMode = ImeMode.NoControl;
      this.CheckBox2.Location = new Point(0x278, 0x20);
      this.CheckBox2.Name = "CheckBox2";
      this.CheckBox2.Size = new Size(0x10, 0x10);
      this.CheckBox2.TabIndex = 9;
      this.CheckBox1.ImeMode = ImeMode.NoControl;
      this.CheckBox1.Location = new Point(0x278, 8);
      this.CheckBox1.Name = "CheckBox1";
      this.CheckBox1.Size = new Size(0x10, 0x10);
      this.CheckBox1.TabIndex = 6;
      this.lblBPM.ImeMode = ImeMode.NoControl;
      this.lblBPM.Location = new Point(0x160, 80);
      this.lblBPM.Name = "lblBPM";
      this.lblBPM.Size = new Size(0x68, 0x10);
      this.lblBPM.TabIndex = 0x12;
      this.lblBPM.Text = "BP&M:";
      this.YearFormat.ImeMode = ImeMode.NoControl;
      this.YearFormat.LargeChange = 1;
      this.YearFormat.Location = new Point(0x100, 80);
      this.YearFormat.Maximum = 2;
      this.YearFormat.Name = "YearFormat";
      this.YearFormat.Size = new Size(0x20, 0x10);
      this.YearFormat.TabIndex = 15;
      this.lblOf2.ImeMode = ImeMode.NoControl;
      this.lblOf2.Location = new Point(0x220, 0x68);
      this.lblOf2.Name = "lblOf2";
      this.lblOf2.Size = new Size(0x10, 0x10);
      this.lblOf2.TabIndex = 0x15;
      this.lblOf2.Text = "/";
      this.lblOf1.ImeMode = ImeMode.NoControl;
      this.lblOf1.Location = new Point(0xd0, 0x68);
      this.lblOf1.Name = "lblOf1";
      this.lblOf1.Size = new Size(0x10, 0x10);
      this.lblOf1.TabIndex = 0x10;
      this.lblOf1.Text = "/";
      this.txtAlbum.Location = new Point(0x88, 0x36);
      this.txtAlbum.Name = "txtAlbum";
      this.txtAlbum.Size = new Size(0x1e8, 20);
      this.txtAlbum.TabIndex = 11;
      this.txtAlbum.Text = "";
      this.txtTitle.Location = new Point(0x88, 30);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new Size(0x1e8, 20);
      this.txtTitle.TabIndex = 8;
      this.txtTitle.Text = "";
      this.lblTitle.ImeMode = ImeMode.NoControl;
      this.lblTitle.Location = new Point(8, 0x20);
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.Size = new Size(0x80, 0x10);
      this.lblTitle.TabIndex = 7;
      this.lblTitle.Text = "&Title:";
      this.lblAlbum.ImeMode = ImeMode.NoControl;
      this.lblAlbum.Location = new Point(8, 0x38);
      this.lblAlbum.Name = "lblAlbum";
      this.lblAlbum.Size = new Size(0x80, 0x10);
      this.lblAlbum.TabIndex = 10;
      this.lblAlbum.Text = "Al&bum:";
      this.lblPosMedia.ImeMode = ImeMode.NoControl;
      this.lblPosMedia.Location = new Point(0x160, 0x68);
      this.lblPosMedia.Name = "lblPosMedia";
      this.lblPosMedia.Size = new Size(120, 0x10);
      this.lblPosMedia.TabIndex = 0x19;
      this.lblPosMedia.Text = "Position in media &set:";
      this.lblYear.ImeMode = ImeMode.NoControl;
      this.lblYear.Location = new Point(8, 80);
      this.lblYear.Name = "lblYear";
      this.lblYear.Size = new Size(0x80, 0x10);
      this.lblYear.TabIndex = 13;
      this.lblYear.Text = "&Year (date) of recording:";
      this.lblTrack.ImeMode = ImeMode.NoControl;
      this.lblTrack.Location = new Point(8, 0x68);
      this.lblTrack.Name = "lblTrack";
      this.lblTrack.Size = new Size(0x80, 0x10);
      this.lblTrack.TabIndex = 0x15;
      this.lblTrack.Text = "Trac&k number:";
      this.lblArtist.ImeMode = ImeMode.NoControl;
      this.lblArtist.Location = new Point(8, 8);
      this.lblArtist.Name = "lblArtist";
      this.lblArtist.Size = new Size(0x80, 0x10);
      this.lblArtist.TabIndex = 4;
      this.lblArtist.Text = "Lead &Artist:";
      this.Panel2.BorderStyle = BorderStyle.FixedSingle;
      this.Panel2.Controls.Add(this.cmbGenre);
      this.Panel2.Controls.Add(this.lblGenreInfo);
      this.Panel2.Controls.Add(this.CheckBox9);
      this.Panel2.Controls.Add(this.btnMoveGenre);
      this.Panel2.Controls.Add(this.btnRemoveGenre);
      this.Panel2.Controls.Add(this.btnAddGenre);
      this.Panel2.Controls.Add(this.lblGenre);
      this.Panel2.Controls.Add(this.GenreList);
      this.Panel2.Location = new Point(8, 0x90);
      this.Panel2.Name = "Panel2";
      this.Panel2.Size = new Size(0x2a0, 0x70);
      this.Panel2.TabIndex = 2;
      this.cmbGenre.Autocomplete = true;
      this.cmbGenre.ItemHeight = 13;
      this.cmbGenre.Location = new Point(0x88, 6);
      this.cmbGenre.Name = "cmbGenre";
      this.cmbGenre.Size = new Size(0x100, 0x15);
      this.cmbGenre.TabIndex = 0x21;
      this.lblGenreInfo.BorderStyle = BorderStyle.Fixed3D;
      this.lblGenreInfo.ImeMode = ImeMode.NoControl;
      this.lblGenreInfo.Location = new Point(400, 0x40);
      this.lblGenreInfo.Name = "lblGenreInfo";
      this.lblGenreInfo.Size = new Size(0x108, 40);
      this.lblGenreInfo.TabIndex = 0x22;
      this.lblGenreInfo.Text = "Note: Many programs only show the first genre entered. So move the important genre to the top of the list.";
      this.CheckBox9.ImeMode = ImeMode.NoControl;
      this.CheckBox9.Location = new Point(0x178, 0x20);
      this.CheckBox9.Name = "CheckBox9";
      this.CheckBox9.Size = new Size(0x10, 0x10);
      this.CheckBox9.TabIndex = 0x26;
      this.btnMoveGenre.ImeMode = ImeMode.NoControl;
      this.btnMoveGenre.Location = new Point(400, 0x20);
      this.btnMoveGenre.Name = "btnMoveGenre";
      this.btnMoveGenre.Size = new Size(0x80, 20);
      this.btnMoveGenre.TabIndex = 0x24;
      this.btnMoveGenre.Text = "Move Genre to top";
      this.btnRemoveGenre.ImeMode = ImeMode.NoControl;
      this.btnRemoveGenre.Location = new Point(0x218, 8);
      this.btnRemoveGenre.Name = "btnRemoveGenre";
      this.btnRemoveGenre.Size = new Size(0x80, 20);
      this.btnRemoveGenre.TabIndex = 0x23;
      this.btnRemoveGenre.Text = "Remove Genre";
      this.btnAddGenre.ImeMode = ImeMode.NoControl;
      this.btnAddGenre.Location = new Point(400, 8);
      this.btnAddGenre.Name = "btnAddGenre";
      this.btnAddGenre.Size = new Size(0x80, 20);
      this.btnAddGenre.TabIndex = 0x22;
      this.btnAddGenre.Text = "Add Genre";
      this.lblGenre.ImeMode = ImeMode.NoControl;
      this.lblGenre.Location = new Point(8, 8);
      this.lblGenre.Name = "lblGenre";
      this.lblGenre.Size = new Size(0x80, 0x10);
      this.lblGenre.TabIndex = 0x20;
      this.lblGenre.Text = "&Genre:";
      this.GenreList.Location = new Point(0x88, 0x20);
      this.GenreList.Name = "GenreList";
      this.GenreList.Size = new Size(0xe8, 0x45);
      this.GenreList.TabIndex = 0x25;
      this.panWeb.Controls.Add(this.Panel10);
      this.panWeb.Location = new Point(0xa8, 0x20);
      this.panWeb.Name = "panWeb";
      this.panWeb.Size = new Size(0x2b0, 0x130);
      this.panWeb.TabIndex = 3;
      this.Panel10.BorderStyle = BorderStyle.FixedSingle;
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
      this.Panel10.Location = new Point(8, 8);
      this.Panel10.Name = "Panel10";
      this.Panel10.Size = new Size(0x2a0, 200);
      this.Panel10.TabIndex = 0;
      this.CheckBox32.ImeMode = ImeMode.NoControl;
      this.CheckBox32.Location = new Point(0x288, 0xb0);
      this.CheckBox32.Name = "CheckBox32";
      this.CheckBox32.Size = new Size(0x10, 0x10);
      this.CheckBox32.TabIndex = 0x19;
      this.CheckBox31.ImeMode = ImeMode.NoControl;
      this.CheckBox31.Location = new Point(0x288, 0x98);
      this.CheckBox31.Name = "CheckBox31";
      this.CheckBox31.Size = new Size(0x10, 0x10);
      this.CheckBox31.TabIndex = 0x16;
      this.CheckBox30.ImeMode = ImeMode.NoControl;
      this.CheckBox30.Location = new Point(0x288, 0x80);
      this.CheckBox30.Name = "CheckBox30";
      this.CheckBox30.Size = new Size(0x10, 0x10);
      this.CheckBox30.TabIndex = 0x13;
      this.CheckBox29.ImeMode = ImeMode.NoControl;
      this.CheckBox29.Location = new Point(0x288, 0x68);
      this.CheckBox29.Name = "CheckBox29";
      this.CheckBox29.Size = new Size(0x10, 0x10);
      this.CheckBox29.TabIndex = 0x10;
      this.CheckBox28.ImeMode = ImeMode.NoControl;
      this.CheckBox28.Location = new Point(0x288, 80);
      this.CheckBox28.Name = "CheckBox28";
      this.CheckBox28.Size = new Size(0x10, 0x10);
      this.CheckBox28.TabIndex = 13;
      this.CheckBox27.ImeMode = ImeMode.NoControl;
      this.CheckBox27.Location = new Point(0x288, 0x38);
      this.CheckBox27.Name = "CheckBox27";
      this.CheckBox27.Size = new Size(0x10, 0x10);
      this.CheckBox27.TabIndex = 10;
      this.CheckBox26.ImeMode = ImeMode.NoControl;
      this.CheckBox26.Location = new Point(0x288, 0x20);
      this.CheckBox26.Name = "CheckBox26";
      this.CheckBox26.Size = new Size(0x10, 0x10);
      this.CheckBox26.TabIndex = 7;
      this.CheckBox25.ImeMode = ImeMode.NoControl;
      this.CheckBox25.Location = new Point(0x288, 8);
      this.CheckBox25.Name = "CheckBox25";
      this.CheckBox25.Size = new Size(0x10, 0x10);
      this.CheckBox25.TabIndex = 4;
      this.txtCOMMInfURL.Location = new Point(200, 0xae);
      this.txtCOMMInfURL.Name = "txtCOMMInfURL";
      this.txtCOMMInfURL.Size = new Size(440, 20);
      this.txtCOMMInfURL.TabIndex = 0x18;
      this.txtCOMMInfURL.Text = "";
      this.lblCOMMInfURL.ImeMode = ImeMode.NoControl;
      this.lblCOMMInfURL.Location = new Point(8, 0xb0);
      this.lblCOMMInfURL.Name = "lblCOMMInfURL";
      this.lblCOMMInfURL.Size = new Size(0xb8, 0x10);
      this.lblCOMMInfURL.TabIndex = 0x17;
      this.lblCOMMInfURL.Text = "Commercial information URL:";
      this.txtPubURL.Location = new Point(200, 150);
      this.txtPubURL.Name = "txtPubURL";
      this.txtPubURL.Size = new Size(440, 20);
      this.txtPubURL.TabIndex = 0x15;
      this.txtPubURL.Text = "";
      this.lblPubURL.ImeMode = ImeMode.NoControl;
      this.lblPubURL.Location = new Point(8, 0x98);
      this.lblPubURL.Name = "lblPubURL";
      this.lblPubURL.Size = new Size(0xb8, 0x10);
      this.lblPubURL.TabIndex = 20;
      this.lblPubURL.Text = "Offical publisher URL:";
      this.txtPayURL.Location = new Point(200, 0x7e);
      this.txtPayURL.Name = "txtPayURL";
      this.txtPayURL.Size = new Size(440, 20);
      this.txtPayURL.TabIndex = 0x12;
      this.txtPayURL.Text = "";
      this.lblPayURL.ImeMode = ImeMode.NoControl;
      this.lblPayURL.Location = new Point(8, 0x80);
      this.lblPayURL.Name = "lblPayURL";
      this.lblPayURL.Size = new Size(0xb8, 0x10);
      this.lblPayURL.TabIndex = 0x11;
      this.lblPayURL.Text = "Offical payment URL:";
      this.txtINetRadioURL.Location = new Point(200, 0x66);
      this.txtINetRadioURL.Name = "txtINetRadioURL";
      this.txtINetRadioURL.Size = new Size(440, 20);
      this.txtINetRadioURL.TabIndex = 15;
      this.txtINetRadioURL.Text = "";
      this.lblINetRadioURL.ImeMode = ImeMode.NoControl;
      this.lblINetRadioURL.Location = new Point(8, 0x68);
      this.lblINetRadioURL.Name = "lblINetRadioURL";
      this.lblINetRadioURL.Size = new Size(0xb8, 0x10);
      this.lblINetRadioURL.TabIndex = 14;
      this.lblINetRadioURL.Text = "Offical internet radio station URL:";
      this.txtAudioSRCURL.Location = new Point(200, 0x4e);
      this.txtAudioSRCURL.Name = "txtAudioSRCURL";
      this.txtAudioSRCURL.Size = new Size(440, 20);
      this.txtAudioSRCURL.TabIndex = 12;
      this.txtAudioSRCURL.Text = "";
      this.lblAudioSRCURL.ImeMode = ImeMode.NoControl;
      this.lblAudioSRCURL.Location = new Point(8, 80);
      this.lblAudioSRCURL.Name = "lblAudioSRCURL";
      this.lblAudioSRCURL.Size = new Size(0xb8, 0x10);
      this.lblAudioSRCURL.TabIndex = 11;
      this.lblAudioSRCURL.Text = "Offical audio source URL:";
      this.txtCopyInfURL.Location = new Point(200, 6);
      this.txtCopyInfURL.Name = "txtCopyInfURL";
      this.txtCopyInfURL.Size = new Size(440, 20);
      this.txtCopyInfURL.TabIndex = 3;
      this.txtCopyInfURL.Text = "";
      this.txtArtistURL.Location = new Point(200, 0x36);
      this.txtArtistURL.Name = "txtArtistURL";
      this.txtArtistURL.Size = new Size(440, 20);
      this.txtArtistURL.TabIndex = 9;
      this.txtArtistURL.Text = "";
      this.txtAudioFileURL.Location = new Point(200, 30);
      this.txtAudioFileURL.Name = "txtAudioFileURL";
      this.txtAudioFileURL.Size = new Size(440, 20);
      this.txtAudioFileURL.TabIndex = 6;
      this.txtAudioFileURL.Text = "";
      this.lblAudioFileURL.ImeMode = ImeMode.NoControl;
      this.lblAudioFileURL.Location = new Point(8, 0x20);
      this.lblAudioFileURL.Name = "lblAudioFileURL";
      this.lblAudioFileURL.Size = new Size(0xb8, 0x10);
      this.lblAudioFileURL.TabIndex = 5;
      this.lblAudioFileURL.Text = "Offical audio file URL:";
      this.lblArtistURL.ImeMode = ImeMode.NoControl;
      this.lblArtistURL.Location = new Point(8, 0x38);
      this.lblArtistURL.Name = "lblArtistURL";
      this.lblArtistURL.Size = new Size(0xb8, 0x10);
      this.lblArtistURL.TabIndex = 8;
      this.lblArtistURL.Text = "Offical artist URL:";
      this.lblCopyInfURL.ImeMode = ImeMode.NoControl;
      this.lblCopyInfURL.Location = new Point(8, 8);
      this.lblCopyInfURL.Name = "lblCopyInfURL";
      this.lblCopyInfURL.Size = new Size(0xb8, 0x10);
      this.lblCopyInfURL.TabIndex = 2;
      this.lblCopyInfURL.Text = "Copyright information URL:";
      this.panRating.Controls.Add(this.Panel11);
      this.panRating.Location = new Point(0xa8, 0x18);
      this.panRating.Name = "panRating";
      this.panRating.Size = new Size(0x2b0, 0x1c0);
      this.panRating.TabIndex = 2;
      this.Panel11.BorderStyle = BorderStyle.FixedSingle;
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
      this.Panel11.Location = new Point(8, 8);
      this.Panel11.Name = "Panel11";
      this.Panel11.Size = new Size(0x2a0, 0x130);
      this.Panel11.TabIndex = 1;
      this.CheckBox33.ImeMode = ImeMode.NoControl;
      this.CheckBox33.Location = new Point(0x88, 0xe8);
      this.CheckBox33.Name = "CheckBox33";
      this.CheckBox33.Size = new Size(0x210, 0x10);
      this.CheckBox33.TabIndex = 0x23;
      this.CheckBox33.Text = "Remove all existing ratings first";
      this.lblInfo.BorderStyle = BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = ImeMode.NoControl;
      this.lblInfo.Location = new Point(0x88, 0x100);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new Size(0x210, 40);
      this.lblInfo.TabIndex = 0x2b;
      this.lblInfo.Text = "The rating is 1-255 where 1 is worst and 255 is best. Note that many programs have their own rating scale. The scale 1-255 is given by the ID3 standard and the other programs rescale it.";
      this.lblInfo.TextAlign = ContentAlignment.MiddleCenter;
      this.btnMoveRating.ImeMode = ImeMode.NoControl;
      this.btnMoveRating.Location = new Point(0x1e8, 0x58);
      this.btnMoveRating.Name = "btnMoveRating";
      this.btnMoveRating.Size = new Size(0xb0, 0x18);
      this.btnMoveRating.TabIndex = 0x22;
      this.btnMoveRating.Text = "Move Rating to top";
      this.btnRemoveRating.ImeMode = ImeMode.NoControl;
      this.btnRemoveRating.Location = new Point(0x138, 0x58);
      this.btnRemoveRating.Name = "btnRemoveRating";
      this.btnRemoveRating.Size = new Size(0xa8, 0x18);
      this.btnRemoveRating.TabIndex = 0x21;
      this.btnRemoveRating.Text = "Remove Rating";
      this.btnAddRating.ImeMode = ImeMode.NoControl;
      this.btnAddRating.Location = new Point(0x88, 0x58);
      this.btnAddRating.Name = "btnAddRating";
      this.btnAddRating.Size = new Size(0xa8, 0x18);
      this.btnAddRating.TabIndex = 0x20;
      this.btnAddRating.Text = "Add Rating";
      this.RatingList.CheckBoxes = true;
      this.RatingList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader8, this.ColumnHeader9, this.ColumnHeader10 });
      this.RatingList.FullRowSelect = true;
      this.RatingList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.RatingList.Location = new Point(0x88, 120);
      this.RatingList.MultiSelect = false;
      this.RatingList.Name = "RatingList";
      this.RatingList.Size = new Size(0x210, 0x68);
      this.RatingList.TabIndex = 0x24;
      this.RatingList.View = View.Details;
      this.ColumnHeader8.Text = "User";
      this.ColumnHeader8.Width = 0x121;
      this.ColumnHeader9.Text = "Rating";
      this.ColumnHeader9.Width = 100;
      this.ColumnHeader10.Text = "Play Counter";
      this.ColumnHeader10.Width = 80;
      this.txtRatingCounter.Location = new Point(0x88, 0x36);
      this.txtRatingCounter.Maximum = new decimal(new int[] { 0xf4240, 0, 0, 0 });
      this.txtRatingCounter.Name = "txtRatingCounter";
      this.txtRatingCounter.Size = new Size(80, 20);
      this.txtRatingCounter.TabIndex = 0x1f;
      this.txtRatingRating.Location = new Point(0x88, 30);
      this.txtRatingRating.Maximum = new decimal(new int[] { 0xff, 0, 0, 0 });
      this.txtRatingRating.Name = "txtRatingRating";
      this.txtRatingRating.Size = new Size(80, 20);
      this.txtRatingRating.TabIndex = 0x1d;
      this.txtRatingUser.Location = new Point(0x88, 6);
      this.txtRatingUser.Name = "txtRatingUser";
      this.txtRatingUser.Size = new Size(0xe0, 20);
      this.txtRatingUser.TabIndex = 0x1b;
      this.txtRatingUser.Text = "";
      this.lblRatingRating.ImeMode = ImeMode.NoControl;
      this.lblRatingRating.Location = new Point(8, 0x20);
      this.lblRatingRating.Name = "lblRatingRating";
      this.lblRatingRating.Size = new Size(120, 0x10);
      this.lblRatingRating.TabIndex = 0x1c;
      this.lblRatingRating.Text = "Rating:";
      this.lblRatingCounter.ImeMode = ImeMode.NoControl;
      this.lblRatingCounter.Location = new Point(8, 0x38);
      this.lblRatingCounter.Name = "lblRatingCounter";
      this.lblRatingCounter.Size = new Size(120, 0x10);
      this.lblRatingCounter.TabIndex = 30;
      this.lblRatingCounter.Text = "Play counter:";
      this.lblRatingUser.ImeMode = ImeMode.NoControl;
      this.lblRatingUser.Location = new Point(8, 8);
      this.lblRatingUser.Name = "lblRatingUser";
      this.lblRatingUser.Size = new Size(120, 0x10);
      this.lblRatingUser.TabIndex = 0x1a;
      this.lblRatingUser.Text = "User (email):";
      this.panInvolved.Controls.Add(this.Panel15);
      this.panInvolved.Controls.Add(this.Panel16);
      this.panInvolved.Location = new Point(0xa8, 0x20);
      this.panInvolved.Name = "panInvolved";
      this.panInvolved.Size = new Size(0x2b0, 0x198);
      this.panInvolved.TabIndex = 3;
      this.Panel15.BorderStyle = BorderStyle.FixedSingle;
      this.Panel15.Controls.Add(this.CheckBox45);
      this.Panel15.Controls.Add(this.lblMusicianInfo);
      this.Panel15.Controls.Add(this.txtMusicianName);
      this.Panel15.Controls.Add(this.btnRemoveMusician);
      this.Panel15.Controls.Add(this.btnAddMusician);
      this.Panel15.Controls.Add(this.lblMusicianName);
      this.Panel15.Controls.Add(this.lblMusicianInst);
      this.Panel15.Controls.Add(this.txtMusicianInst);
      this.Panel15.Controls.Add(this.TMCLList);
      this.Panel15.Location = new Point(8, 160);
      this.Panel15.Name = "Panel15";
      this.Panel15.Size = new Size(0x2a0, 0x90);
      this.Panel15.TabIndex = 2;
      this.CheckBox45.ImeMode = ImeMode.NoControl;
      this.CheckBox45.Location = new Point(0x288, 0x40);
      this.CheckBox45.Name = "CheckBox45";
      this.CheckBox45.Size = new Size(0x10, 0x10);
      this.CheckBox45.TabIndex = 0x1a;
      this.lblMusicianInfo.ImeMode = ImeMode.NoControl;
      this.lblMusicianInfo.Location = new Point(8, 120);
      this.lblMusicianInfo.Name = "lblMusicianInfo";
      this.lblMusicianInfo.Size = new Size(0x80, 0x10);
      this.lblMusicianInfo.TabIndex = 0x10;
      this.lblMusicianInfo.Text = "(TAG Ver. 2.4 only)";
      this.txtMusicianName.Location = new Point(160, 30);
      this.txtMusicianName.Name = "txtMusicianName";
      this.txtMusicianName.Size = new Size(0x158, 20);
      this.txtMusicianName.TabIndex = 0x16;
      this.txtMusicianName.Text = "";
      this.btnRemoveMusician.ImeMode = ImeMode.NoControl;
      this.btnRemoveMusician.Location = new Point(0x200, 0x20);
      this.btnRemoveMusician.Name = "btnRemoveMusician";
      this.btnRemoveMusician.Size = new Size(0x98, 20);
      this.btnRemoveMusician.TabIndex = 0x18;
      this.btnRemoveMusician.Text = "Remove musician";
      this.btnAddMusician.ImeMode = ImeMode.NoControl;
      this.btnAddMusician.Location = new Point(0x200, 8);
      this.btnAddMusician.Name = "btnAddMusician";
      this.btnAddMusician.Size = new Size(0x98, 20);
      this.btnAddMusician.TabIndex = 0x17;
      this.btnAddMusician.Text = "Add musician";
      this.lblMusicianName.ImeMode = ImeMode.NoControl;
      this.lblMusicianName.Location = new Point(8, 0x20);
      this.lblMusicianName.Name = "lblMusicianName";
      this.lblMusicianName.Size = new Size(0x80, 0x10);
      this.lblMusicianName.TabIndex = 0x15;
      this.lblMusicianName.Text = "Musician name:";
      this.lblMusicianInst.ImeMode = ImeMode.NoControl;
      this.lblMusicianInst.Location = new Point(8, 8);
      this.lblMusicianInst.Name = "lblMusicianInst";
      this.lblMusicianInst.Size = new Size(0x80, 0x10);
      this.lblMusicianInst.TabIndex = 0x13;
      this.lblMusicianInst.Text = "Musician instrument:";
      this.txtMusicianInst.Location = new Point(160, 6);
      this.txtMusicianInst.Name = "txtMusicianInst";
      this.txtMusicianInst.Size = new Size(0x158, 20);
      this.txtMusicianInst.TabIndex = 20;
      this.txtMusicianInst.Text = "";
      this.TMCLList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader15, this.ColumnHeader16 });
      this.TMCLList.FullRowSelect = true;
      this.TMCLList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.TMCLList.Location = new Point(160, 0x40);
      this.TMCLList.MultiSelect = false;
      this.TMCLList.Name = "TMCLList";
      this.TMCLList.Size = new Size(480, 0x48);
      this.TMCLList.TabIndex = 0x19;
      this.TMCLList.View = View.Details;
      this.ColumnHeader15.Text = "Instrument";
      this.ColumnHeader15.Width = 200;
      this.ColumnHeader16.Text = "Name";
      this.ColumnHeader16.Width = 0xf7;
      this.Panel16.BorderStyle = BorderStyle.FixedSingle;
      this.Panel16.Controls.Add(this.CheckBox44);
      this.Panel16.Controls.Add(this.txtInvPerson);
      this.Panel16.Controls.Add(this.btnRemoveInv);
      this.Panel16.Controls.Add(this.btnAddInv);
      this.Panel16.Controls.Add(this.lblInvPerson);
      this.Panel16.Controls.Add(this.lblInvFunction);
      this.Panel16.Controls.Add(this.txtInvFunction);
      this.Panel16.Controls.Add(this.TIPLList);
      this.Panel16.Location = new Point(8, 8);
      this.Panel16.Name = "Panel16";
      this.Panel16.Size = new Size(0x2a0, 0x90);
      this.Panel16.TabIndex = 1;
      this.CheckBox44.ImeMode = ImeMode.NoControl;
      this.CheckBox44.Location = new Point(0x288, 0x40);
      this.CheckBox44.Name = "CheckBox44";
      this.CheckBox44.Size = new Size(0x10, 0x10);
      this.CheckBox44.TabIndex = 0x13;
      this.txtInvPerson.Location = new Point(160, 30);
      this.txtInvPerson.Name = "txtInvPerson";
      this.txtInvPerson.Size = new Size(0x158, 20);
      this.txtInvPerson.TabIndex = 15;
      this.txtInvPerson.Text = "";
      this.btnRemoveInv.ImeMode = ImeMode.NoControl;
      this.btnRemoveInv.Location = new Point(0x200, 0x20);
      this.btnRemoveInv.Name = "btnRemoveInv";
      this.btnRemoveInv.Size = new Size(0x98, 20);
      this.btnRemoveInv.TabIndex = 0x11;
      this.btnRemoveInv.Text = "Remove involved person";
      this.btnAddInv.ImeMode = ImeMode.NoControl;
      this.btnAddInv.Location = new Point(0x200, 8);
      this.btnAddInv.Name = "btnAddInv";
      this.btnAddInv.Size = new Size(0x98, 20);
      this.btnAddInv.TabIndex = 0x10;
      this.btnAddInv.Text = "Add involved person";
      this.lblInvPerson.ImeMode = ImeMode.NoControl;
      this.lblInvPerson.Location = new Point(8, 0x20);
      this.lblInvPerson.Name = "lblInvPerson";
      this.lblInvPerson.Size = new Size(0x90, 0x10);
      this.lblInvPerson.TabIndex = 14;
      this.lblInvPerson.Text = "Involved person name:";
      this.lblInvFunction.ImeMode = ImeMode.NoControl;
      this.lblInvFunction.Location = new Point(8, 8);
      this.lblInvFunction.Name = "lblInvFunction";
      this.lblInvFunction.Size = new Size(0x90, 0x10);
      this.lblInvFunction.TabIndex = 12;
      this.lblInvFunction.Text = "Involved person function:";
      this.txtInvFunction.Location = new Point(160, 6);
      this.txtInvFunction.Name = "txtInvFunction";
      this.txtInvFunction.Size = new Size(0x158, 20);
      this.txtInvFunction.TabIndex = 13;
      this.txtInvFunction.Text = "";
      this.TIPLList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader17, this.ColumnHeader18 });
      this.TIPLList.FullRowSelect = true;
      this.TIPLList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.TIPLList.Location = new Point(160, 0x40);
      this.TIPLList.MultiSelect = false;
      this.TIPLList.Name = "TIPLList";
      this.TIPLList.Size = new Size(480, 0x48);
      this.TIPLList.TabIndex = 0x12;
      this.TIPLList.View = View.Details;
      this.ColumnHeader17.Text = "Function";
      this.ColumnHeader17.Width = 0xb0;
      this.ColumnHeader18.Text = "Name";
      this.ColumnHeader18.Width = 0x110;
      this.panPic.Controls.Add(this.Panel7);
      this.panPic.Location = new Point(0xa8, 0x18);
      this.panPic.Name = "panPic";
      this.panPic.Size = new Size(0x2b0, 0x148);
      this.panPic.TabIndex = 3;
      this.Panel7.BorderStyle = BorderStyle.FixedSingle;
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
      this.Panel7.Location = new Point(8, 8);
      this.Panel7.Name = "Panel7";
      this.Panel7.Size = new Size(0x2a0, 0x130);
      this.Panel7.TabIndex = 0;
      this.chkPicRelativPath.Location = new Point(8, 0x70);
      this.chkPicRelativPath.Name = "chkPicRelativPath";
      this.chkPicRelativPath.Size = new Size(0x1d8, 0x10);
      this.chkPicRelativPath.TabIndex = 9;
      this.chkPicRelativPath.Text = "Use relativ path if picture is not included";
      this.CheckBox34.ImeMode = ImeMode.NoControl;
      this.CheckBox34.Location = new Point(8, 280);
      this.CheckBox34.Name = "CheckBox34";
      this.CheckBox34.Size = new Size(0x290, 0x10);
      this.CheckBox34.TabIndex = 14;
      this.CheckBox34.Text = "Remove all existing pictures first";
      this.btnRemovePicture.ImeMode = ImeMode.NoControl;
      this.btnRemovePicture.Location = new Point(0xa8, 160);
      this.btnRemovePicture.Name = "btnRemovePicture";
      this.btnRemovePicture.Size = new Size(0x98, 0x18);
      this.btnRemovePicture.TabIndex = 11;
      this.btnRemovePicture.Text = "Remove Picture";
      this.btnAddPicture.Enabled = false;
      this.btnAddPicture.ImeMode = ImeMode.NoControl;
      this.btnAddPicture.Location = new Point(8, 160);
      this.btnAddPicture.Name = "btnAddPicture";
      this.btnAddPicture.Size = new Size(0x98, 0x18);
      this.btnAddPicture.TabIndex = 10;
      this.btnAddPicture.Text = "Add Picture";
      this.btnGetPic.ImeMode = ImeMode.NoControl;
      this.btnGetPic.Location = new Point(0x148, 160);
      this.btnGetPic.Name = "btnGetPic";
      this.btnGetPic.Size = new Size(0x98, 0x18);
      this.btnGetPic.TabIndex = 12;
      this.btnGetPic.Text = "Get new picture";
      this.chkPicInclude.ImeMode = ImeMode.NoControl;
      this.chkPicInclude.Location = new Point(8, 0x58);
      this.chkPicInclude.Name = "chkPicInclude";
      this.chkPicInclude.Size = new Size(0x1d8, 0x10);
      this.chkPicInclude.TabIndex = 8;
      this.chkPicInclude.Text = "Include picture within the MP3 file when saving";
      this.lblPicPath.ImeMode = ImeMode.NoControl;
      this.lblPicPath.Location = new Point(8, 0x38);
      this.lblPicPath.Name = "lblPicPath";
      this.lblPicPath.Size = new Size(0x88, 0x10);
      this.lblPicPath.TabIndex = 6;
      this.lblPicPath.Text = "P&ath containing pic. data:";
      this.txtPicPath.Location = new Point(0x98, 0x36);
      this.txtPicPath.Name = "txtPicPath";
      this.txtPicPath.ReadOnly = true;
      this.txtPicPath.Size = new Size(0x148, 20);
      this.txtPicPath.TabIndex = 7;
      this.txtPicPath.Text = "";
      this.PicList.CheckBoxes = true;
      this.PicList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader4, this.ColumnHeader5, this.ColumnHeader6, this.ColumnHeader7 });
      this.PicList.FullRowSelect = true;
      this.PicList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.PicList.Location = new Point(8, 0xc0);
      this.PicList.MultiSelect = false;
      this.PicList.Name = "PicList";
      this.PicList.Size = new Size(0x290, 80);
      this.PicList.TabIndex = 13;
      this.PicList.View = View.Details;
      this.ColumnHeader4.Text = "Descriptor";
      this.ColumnHeader4.Width = 160;
      this.ColumnHeader5.Text = "Picture Type";
      this.ColumnHeader5.Width = 80;
      this.ColumnHeader6.Text = "Path";
      this.ColumnHeader6.Width = 160;
      this.ColumnHeader7.Text = "Include";
      this.lblPicType.ImeMode = ImeMode.NoControl;
      this.lblPicType.Location = new Point(8, 0x20);
      this.lblPicType.Name = "lblPicType";
      this.lblPicType.Size = new Size(0x88, 0x10);
      this.lblPicType.TabIndex = 4;
      this.lblPicType.Text = "Picture &Type:";
      this.lblPicDesc.ImeMode = ImeMode.NoControl;
      this.lblPicDesc.Location = new Point(8, 8);
      this.lblPicDesc.Name = "lblPicDesc";
      this.lblPicDesc.Size = new Size(0x88, 0x10);
      this.lblPicDesc.TabIndex = 2;
      this.lblPicDesc.Text = "&Picture Descriptor:";
      this.cmbPicType.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbPicType.ItemHeight = 13;
      this.cmbPicType.Items.AddRange(new object[] {
                "00 - Other", "01 - 32x32 pixels 'file icon' (PNG only)", "02 - Other file icon", "03 - Cover (front)", "04 - Cover (back)", "05 - Leaflet page", "06 - Media (e.g. label side of CD)", "07 - Lead artist/lead performer/soloist", "08 - Artist/performer", "09 - Conductor", "10 - Band/Orchestra", "11 - Composer", "12 - Lyricist/text writer", "13 - Recording Location", "14 - During recording", "15 - During performance",
                "16 - Movie/video screen capture", "17 - A bright coloured fish", "18 - Illustration", "19 - Band/artist logotype", "20 - Publisher/Studio logotype"
            });
      this.cmbPicType.Location = new Point(0x98, 30);
      this.cmbPicType.Name = "cmbPicType";
      this.cmbPicType.Size = new Size(0x148, 0x15);
      this.cmbPicType.TabIndex = 5;
      this.txtPDescriptor.Location = new Point(0x98, 6);
      this.txtPDescriptor.Name = "txtPDescriptor";
      this.txtPDescriptor.Size = new Size(0x148, 20);
      this.txtPDescriptor.TabIndex = 3;
      this.txtPDescriptor.Text = "";
      this.APICView.BorderStyle = BorderStyle.FixedSingle;
      this.APICView.ImeMode = ImeMode.NoControl;
      this.APICView.Location = new Point(0x1e8, 8);
      this.APICView.Name = "APICView";
      this.APICView.Size = new Size(0xb0, 0xb0);
      this.APICView.SizeMode = PictureBoxSizeMode.StretchImage;
      this.APICView.TabIndex = 1;
      this.APICView.TabStop = false;
      this.panLyrics.Controls.Add(this.Panel8);
      this.panLyrics.Location = new Point(0xa8, 0x18);
      this.panLyrics.Name = "panLyrics";
      this.panLyrics.Size = new Size(0x2b0, 0x1c8);
      this.panLyrics.TabIndex = 2;
      this.Panel8.BorderStyle = BorderStyle.FixedSingle;
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
      this.Panel8.Location = new Point(8, 8);
      this.Panel8.Name = "Panel8";
      this.Panel8.Size = new Size(0x2a0, 440);
      this.Panel8.TabIndex = 1;
      this.txtLyrics.BorderStyle = BorderStyle.FixedSingle;
      this.txtLyrics.Location = new Point(0x88, 0x38);
      this.txtLyrics.Name = "txtLyrics";
      this.txtLyrics.Size = new Size(0x210, 0xb8);
      this.txtLyrics.TabIndex = 0x11;
      this.txtLyrics.Text = "";
      this.btnLyricsFile.Location = new Point(0x88, 0xf8);
      this.btnLyricsFile.Name = "btnLyricsFile";
      this.btnLyricsFile.Size = new Size(0x210, 0x18);
      this.btnLyricsFile.TabIndex = 0x12;
      this.btnLyricsFile.Text = "Get lyrics from text file";
      this.CheckBox35.ImeMode = ImeMode.NoControl;
      this.CheckBox35.Location = new Point(8, 0x1a0);
      this.CheckBox35.Name = "CheckBox35";
      this.CheckBox35.Size = new Size(0x290, 0x10);
      this.CheckBox35.TabIndex = 0x17;
      this.CheckBox35.Text = "Remove all existing lyrics first";
      this.btnMoveLyrics.ImeMode = ImeMode.NoControl;
      this.btnMoveLyrics.Location = new Point(0x1f0, 280);
      this.btnMoveLyrics.Name = "btnMoveLyrics";
      this.btnMoveLyrics.Size = new Size(0xa8, 0x18);
      this.btnMoveLyrics.TabIndex = 0x15;
      this.btnMoveLyrics.Text = "Move Lyrics to top";
      this.btnRemoveLyrics.ImeMode = ImeMode.NoControl;
      this.btnRemoveLyrics.Location = new Point(0x138, 280);
      this.btnRemoveLyrics.Name = "btnRemoveLyrics";
      this.btnRemoveLyrics.Size = new Size(0xb0, 0x18);
      this.btnRemoveLyrics.TabIndex = 20;
      this.btnRemoveLyrics.Text = "Remove Lyrics";
      this.btnAddLyrics.ImeMode = ImeMode.NoControl;
      this.btnAddLyrics.Location = new Point(0x88, 280);
      this.btnAddLyrics.Name = "btnAddLyrics";
      this.btnAddLyrics.Size = new Size(0xa8, 0x18);
      this.btnAddLyrics.TabIndex = 0x13;
      this.btnAddLyrics.Text = "Add Lyrics";
      this.lblLyrics.ImeMode = ImeMode.NoControl;
      this.lblLyrics.Location = new Point(8, 0x38);
      this.lblLyrics.Name = "lblLyrics";
      this.lblLyrics.Size = new Size(0x80, 0x10);
      this.lblLyrics.TabIndex = 0x10;
      this.lblLyrics.Text = "&Lyrics Text:";
      this.lblLyLan.ImeMode = ImeMode.NoControl;
      this.lblLyLan.Location = new Point(8, 0x20);
      this.lblLyLan.Name = "lblLyLan";
      this.lblLyLan.Size = new Size(0x80, 0x10);
      this.lblLyLan.TabIndex = 14;
      this.lblLyLan.Text = "Lyrics &Language:";
      this.lblLyDesc.ImeMode = ImeMode.NoControl;
      this.lblLyDesc.Location = new Point(8, 8);
      this.lblLyDesc.Name = "lblLyDesc";
      this.lblLyDesc.Size = new Size(0x80, 0x10);
      this.lblLyDesc.TabIndex = 12;
      this.lblLyDesc.Text = "Lyrics &Descriptor:";
      this.cmbLLanguage.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbLLanguage.ItemHeight = 13;
      this.cmbLLanguage.Location = new Point(0x88, 30);
      this.cmbLLanguage.Name = "cmbLLanguage";
      this.cmbLLanguage.Size = new Size(0xd0, 0x15);
      this.cmbLLanguage.TabIndex = 15;
      this.txtLDescriptor.Location = new Point(0x88, 6);
      this.txtLDescriptor.Name = "txtLDescriptor";
      this.txtLDescriptor.Size = new Size(0xd0, 20);
      this.txtLDescriptor.TabIndex = 13;
      this.txtLDescriptor.Text = "";
      this.LyricsList.CheckBoxes = true;
      this.LyricsList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader1, this.ColumnHeader2, this.ColumnHeader3 });
      this.LyricsList.FullRowSelect = true;
      this.LyricsList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.LyricsList.Location = new Point(8, 0x138);
      this.LyricsList.MultiSelect = false;
      this.LyricsList.Name = "LyricsList";
      this.LyricsList.Size = new Size(0x290, 0x60);
      this.LyricsList.TabIndex = 0x16;
      this.LyricsList.View = View.Details;
      this.ColumnHeader1.Text = "Descriptor";
      this.ColumnHeader1.Width = 0x8b;
      this.ColumnHeader2.Text = "Text";
      this.ColumnHeader2.Width = 0x182;
      this.ColumnHeader3.Text = "Language";
      this.ColumnHeader3.Width = 0x58;
      this.panUser.Controls.Add(this.Panel12);
      this.panUser.Controls.Add(this.Panel13);
      this.panUser.Location = new Point(0xa8, 0x18);
      this.panUser.Name = "panUser";
      this.panUser.Size = new Size(0x2b0, 0x1c8);
      this.panUser.TabIndex = 2;
      this.Panel12.BorderStyle = BorderStyle.FixedSingle;
      this.Panel12.Controls.Add(this.CheckBox36);
      this.Panel12.Controls.Add(this.txtTXXXContent);
      this.Panel12.Controls.Add(this.btnRemoveTXXX);
      this.Panel12.Controls.Add(this.btnAddTXXX);
      this.Panel12.Controls.Add(this.lblTXXXContent);
      this.Panel12.Controls.Add(this.lblTXXXDesc);
      this.Panel12.Controls.Add(this.txtTXXXDesc);
      this.Panel12.Controls.Add(this.TXXXList);
      this.Panel12.Location = new Point(8, 8);
      this.Panel12.Name = "Panel12";
      this.Panel12.Size = new Size(0x2a0, 0xd8);
      this.Panel12.TabIndex = 0;
      this.CheckBox36.ImeMode = ImeMode.NoControl;
      this.CheckBox36.Location = new Point(0x88, 0xc0);
      this.CheckBox36.Name = "CheckBox36";
      this.CheckBox36.Size = new Size(520, 0x10);
      this.CheckBox36.TabIndex = 9;
      this.CheckBox36.Text = "Remove all existing user text frames first";
      this.txtTXXXContent.Location = new Point(0x88, 30);
      this.txtTXXXContent.Name = "txtTXXXContent";
      this.txtTXXXContent.Size = new Size(0x170, 20);
      this.txtTXXXContent.TabIndex = 5;
      this.txtTXXXContent.Text = "";
      this.btnRemoveTXXX.ImeMode = ImeMode.NoControl;
      this.btnRemoveTXXX.Location = new Point(0x200, 30);
      this.btnRemoveTXXX.Name = "btnRemoveTXXX";
      this.btnRemoveTXXX.Size = new Size(0x98, 20);
      this.btnRemoveTXXX.TabIndex = 7;
      this.btnRemoveTXXX.Text = "Remove user text frame";
      this.btnAddTXXX.ImeMode = ImeMode.NoControl;
      this.btnAddTXXX.Location = new Point(0x200, 6);
      this.btnAddTXXX.Name = "btnAddTXXX";
      this.btnAddTXXX.Size = new Size(0x98, 20);
      this.btnAddTXXX.TabIndex = 6;
      this.btnAddTXXX.Text = "Add user text frame";
      this.lblTXXXContent.ImeMode = ImeMode.NoControl;
      this.lblTXXXContent.Location = new Point(8, 0x20);
      this.lblTXXXContent.Name = "lblTXXXContent";
      this.lblTXXXContent.Size = new Size(0x80, 0x10);
      this.lblTXXXContent.TabIndex = 4;
      this.lblTXXXContent.Text = "Text frame &Content:";
      this.lblTXXXDesc.ImeMode = ImeMode.NoControl;
      this.lblTXXXDesc.Location = new Point(8, 8);
      this.lblTXXXDesc.Name = "lblTXXXDesc";
      this.lblTXXXDesc.Size = new Size(0x80, 0x10);
      this.lblTXXXDesc.TabIndex = 2;
      this.lblTXXXDesc.Text = "Text frame &Descriptor:";
      this.txtTXXXDesc.Location = new Point(0x88, 6);
      this.txtTXXXDesc.Name = "txtTXXXDesc";
      this.txtTXXXDesc.Size = new Size(0x170, 20);
      this.txtTXXXDesc.TabIndex = 3;
      this.txtTXXXDesc.Text = "";
      this.TXXXList.CheckBoxes = true;
      this.TXXXList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader11, this.ColumnHeader12 });
      this.TXXXList.FullRowSelect = true;
      this.TXXXList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.TXXXList.Location = new Point(0x88, 0x38);
      this.TXXXList.MultiSelect = false;
      this.TXXXList.Name = "TXXXList";
      this.TXXXList.Size = new Size(0x210, 0x80);
      this.TXXXList.TabIndex = 8;
      this.TXXXList.View = View.Details;
      this.ColumnHeader11.Text = "Descriptor";
      this.ColumnHeader11.Width = 180;
      this.ColumnHeader12.Text = "Content";
      this.ColumnHeader12.Width = 0x141;
      this.Panel13.BorderStyle = BorderStyle.FixedSingle;
      this.Panel13.Controls.Add(this.CheckBox37);
      this.Panel13.Controls.Add(this.txtWXXXContent);
      this.Panel13.Controls.Add(this.btnRemoveWXXX);
      this.Panel13.Controls.Add(this.btnAddWXXX);
      this.Panel13.Controls.Add(this.lblWXXXContent);
      this.Panel13.Controls.Add(this.lblWXXXDesc);
      this.Panel13.Controls.Add(this.txtWXXXDesc);
      this.Panel13.Controls.Add(this.WXXXList);
      this.Panel13.Location = new Point(8, 0xe8);
      this.Panel13.Name = "Panel13";
      this.Panel13.Size = new Size(0x2a0, 0xd8);
      this.Panel13.TabIndex = 1;
      this.CheckBox37.ImeMode = ImeMode.NoControl;
      this.CheckBox37.Location = new Point(0x88, 0xc0);
      this.CheckBox37.Name = "CheckBox37";
      this.CheckBox37.Size = new Size(0x200, 0x10);
      this.CheckBox37.TabIndex = 0x11;
      this.CheckBox37.Text = "Remove all existing user web frames first";
      this.txtWXXXContent.Location = new Point(0x88, 30);
      this.txtWXXXContent.Name = "txtWXXXContent";
      this.txtWXXXContent.Size = new Size(0x170, 20);
      this.txtWXXXContent.TabIndex = 13;
      this.txtWXXXContent.Text = "";
      this.btnRemoveWXXX.ImeMode = ImeMode.NoControl;
      this.btnRemoveWXXX.Location = new Point(0x200, 30);
      this.btnRemoveWXXX.Name = "btnRemoveWXXX";
      this.btnRemoveWXXX.Size = new Size(0x98, 20);
      this.btnRemoveWXXX.TabIndex = 15;
      this.btnRemoveWXXX.Text = "Remove user web frame";
      this.btnAddWXXX.ImeMode = ImeMode.NoControl;
      this.btnAddWXXX.Location = new Point(0x200, 6);
      this.btnAddWXXX.Name = "btnAddWXXX";
      this.btnAddWXXX.Size = new Size(0x98, 20);
      this.btnAddWXXX.TabIndex = 14;
      this.btnAddWXXX.Text = "Add user web frame";
      this.lblWXXXContent.ImeMode = ImeMode.NoControl;
      this.lblWXXXContent.Location = new Point(8, 0x20);
      this.lblWXXXContent.Name = "lblWXXXContent";
      this.lblWXXXContent.Size = new Size(0x80, 0x10);
      this.lblWXXXContent.TabIndex = 12;
      this.lblWXXXContent.Text = "Web frame &Content:";
      this.lblWXXXDesc.ImeMode = ImeMode.NoControl;
      this.lblWXXXDesc.Location = new Point(8, 8);
      this.lblWXXXDesc.Name = "lblWXXXDesc";
      this.lblWXXXDesc.Size = new Size(0x80, 0x10);
      this.lblWXXXDesc.TabIndex = 10;
      this.lblWXXXDesc.Text = "Web frame &Descriptor:";
      this.txtWXXXDesc.Location = new Point(0x88, 6);
      this.txtWXXXDesc.Name = "txtWXXXDesc";
      this.txtWXXXDesc.Size = new Size(0x170, 20);
      this.txtWXXXDesc.TabIndex = 11;
      this.txtWXXXDesc.Text = "";
      this.WXXXList.CheckBoxes = true;
      this.WXXXList.Columns.AddRange(new ColumnHeader[] { this.ColumnHeader13, this.ColumnHeader14 });
      this.WXXXList.FullRowSelect = true;
      this.WXXXList.HeaderStyle = ColumnHeaderStyle.Nonclickable;
      this.WXXXList.Location = new Point(0x88, 0x38);
      this.WXXXList.MultiSelect = false;
      this.WXXXList.Name = "WXXXList";
      this.WXXXList.Size = new Size(0x210, 0x80);
      this.WXXXList.TabIndex = 0x10;
      this.WXXXList.View = View.Details;
      this.ColumnHeader13.Text = "Descriptor";
      this.ColumnHeader13.Width = 0xb1;
      this.ColumnHeader14.Text = "Content";
      this.ColumnHeader14.Width = 0x142;
      this.lblDigits.BackColor = Color.White;
      this.lblDigits.ForeColor = Color.Black;
      this.lblDigits.ImeMode = ImeMode.NoControl;
      this.lblDigits.Location = new Point(8, 0x44);
      this.lblDigits.Name = "lblDigits";
      this.lblDigits.Size = new Size(0xb8, 0x10);
      this.lblDigits.TabIndex = 0x66;
      this.lblDigits.Text = "Number of digits of track numbers:";
      this.txtDigits.Location = new Point(0xc0, 0x42);
      this.txtDigits.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
      this.txtDigits.Name = "txtDigits";
      this.txtDigits.Size = new Size(0x30, 20);
      this.txtDigits.TabIndex = 0x67;
      this.txtDigits.Value = new decimal(new int[] { 2, 0, 0, 0 });
      this.OpenFileDialog.RestoreDirectory = true;
      this.chkRemoveAllNOT.BackColor = Color.White;
      this.chkRemoveAllNOT.ForeColor = Color.Black;
      this.chkRemoveAllNOT.ImeMode = ImeMode.NoControl;
      this.chkRemoveAllNOT.Location = new Point(0xf8, 0x44);
      this.chkRemoveAllNOT.Name = "chkRemoveAllNOT";
      this.chkRemoveAllNOT.Size = new Size(0xe8, 0x10);
      this.chkRemoveAllNOT.TabIndex = 0x68;
      this.chkRemoveAllNOT.Text = "Remove all NOT supported entries";
      this.lblInfoStar.BackColor = Color.White;
      this.lblInfoStar.BorderStyle = BorderStyle.FixedSingle;
      this.lblInfoStar.Font = new Font("Microsoft Sans Serif", 7f, FontStyle.Regular, GraphicsUnit.Point, 0);
      this.lblInfoStar.Location = new Point(8, 8);
      this.lblInfoStar.Name = "lblInfoStar";
      this.lblInfoStar.Size = new Size(0x2a0, 0x30);
      this.lblInfoStar.TabIndex = 0x65;
      this.lblInfoStar.Text = "Placeholders";
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
      this.SelectionBar.Groups.AddRange(new BaseItem[] { this.TAGV2grpTAG, this.TAGV2grpCommands });
      this.SelectionBar.Images = null;
      this.SelectionBar.Location = new Point(0, 0);
      this.SelectionBar.Name = "SelectionBar";
      this.SelectionBar.Size = new Size(0xa8, 0x240);
      this.SelectionBar.StockStyle = eExplorerBarStockStyle.Blue;
      this.SelectionBar.TabIndex = 0x6b;
      this.SelectionBar.Text = "Select TAG section";
      this.SelectionBar.ThemeAware = true;
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
      this.TAGV2grpTAG.SubItems.AddRange(new BaseItem[] { this.TAGV2ButtonItem1, this.TAGV2ButtonItem2, this.TAGV2ButtonItem3, this.TAGV2ButtonItem4, this.TAGV2ButtonItem5, this.TAGV2ButtonItem6, this.TAGV2ButtonItem7, this.TAGV2ButtonItem8, this.TAGV2ButtonItem9 });
      this.TAGV2grpTAG.Text = "TAG information";
      this.TAGV2grpTAG.ThemeAware = true;
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
      this.TAGV2grpCommands.SubItems.AddRange(new BaseItem[] { this.btnSwapAT, this.btnSwapAA, this.btnSwapTA });
      this.TAGV2grpCommands.Text = "Commands";
      this.TAGV2grpCommands.ThemeAware = true;
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
      this.TopPanel.AntiAlias = true;
      this.TopPanel.Dock = DockStyle.Top;
      this.TopPanel.Location = new Point(0xa8, 0);
      this.TopPanel.Name = "TopPanel";
      this.TopPanel.Size = new Size(690, 0x18);
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
      this.TopPanel.TabIndex = 0x6c;
      this.TopPanel.Text = "TopPanel";
      this.btnOK.BackColor = SystemColors.Control;
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = ImeMode.NoControl;
      this.btnOK.Location = new Point(480, 0x40);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new Size(0x60, 0x18);
      this.btnOK.TabIndex = 0x69;
      this.btnOK.Text = "&OK";
      this.btnCancel.BackColor = SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      this.btnCancel.Location = new Point(0x248, 0x40);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new Size(0x60, 0x18);
      this.btnCancel.TabIndex = 0x6a;
      this.btnCancel.Text = "&Cancel";
      this.ButtomPanel.AntiAlias = true;
      this.ButtomPanel.Controls.Add(this.chkRemoveAllNOT);
      this.ButtomPanel.Controls.Add(this.txtDigits);
      this.ButtomPanel.Controls.Add(this.btnCancel);
      this.ButtomPanel.Controls.Add(this.btnOK);
      this.ButtomPanel.Controls.Add(this.lblDigits);
      this.ButtomPanel.Controls.Add(this.lblInfoStar);
      this.ButtomPanel.Dock = DockStyle.Bottom;
      this.ButtomPanel.Location = new Point(0xa8, 480);
      this.ButtomPanel.Name = "ButtomPanel";
      this.ButtomPanel.Size = new Size(690, 0x60);
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
      this.Label.ButtonStyle = eButtonStyle.ImageAndText;
      this.Label.Cursor = Cursors.Hand;
      this.Label.ForeColor = Color.FromArgb(0x21, 0x5d, 0xc6);
      this.Label.HotFontUnderline = true;
      this.Label.HotForeColor = Color.FromArgb(0x42, 0x8e, 0xff);
      this.Label.HotTrackingStyle = eHotTrackingStyle.None;
      this.Label.Name = "Label";
      this.Label.PopupAnimation = ePopupAnimation.None;
      this.Label.Text = "New Button";

      this.btnAddComment.Click += new EventHandler(this.btnAddComment_Click);
      this.btnAddGenre.Click += new EventHandler(this.btnAddGenre_Click);
      this.btnAddInv.Click += new EventHandler(this.btnAddInv_Click);
      this.btnAddLyrics.Click += new EventHandler(this.btnAddLyrics_Click);
      this.btnAddMusician.Click += new EventHandler(this.btnAddMusican_Click);
      this.btnAddPicture.Click += new EventHandler(this.btnAddPicture_Click);
      this.btnAddRating.Click += new EventHandler(this.btnAddRating_Click);
      this.btnAddTXXX.Click += new EventHandler(this.btnAddTXXX_Click);
      this.btnAddWXXX.Click += new EventHandler(this.btnAddWXXX_Click);
      this.btnCancel.Click += new EventHandler(this.btnCancel_Click);
      this.btnGetPic.Click += new EventHandler(this.btnGetPic_Click);
      this.btnLyricsFile.Click += new EventHandler(this.btnLyricsFile_Click);
      this.btnMoveComment.Click += new EventHandler(this.btnMoveComment_Click);
      this.btnMoveGenre.Click += new EventHandler(this.btnMoveGenre_Click);
      this.btnMoveLyrics.Click += new EventHandler(this.btnMoveLyrics_Click);
      this.btnMoveRating.Click += new EventHandler(this.btnMoveRating_Click);
      this.btnOK.Click += new EventHandler(this.btnOK_Click);
      this.btnRemoveComment.Click += new EventHandler(this.btnRemoveComment_Click);
      this.btnRemoveGenre.Click += new EventHandler(this.btnRemoveGenre_Click);
      this.btnRemoveInv.Click += new EventHandler(this.btnRemoveInv_Click);
      this.btnRemoveLyrics.Click += new EventHandler(this.btnRemoveLyrics_Click);
      this.btnRemoveMusician.Click += new EventHandler(this.btnRemoveMusican_Click);
      this.btnRemovePicture.Click += new EventHandler(this.btnRemovePicture_Click);
      this.btnRemoveRating.Click += new EventHandler(this.btnRemoveRating_Click);
      this.btnRemoveTXXX.Click += new EventHandler(this.btnRemoveTXXX_Click);
      this.btnRemoveWXXX.Click += new EventHandler(this.btnRemoveWXXX_Click);
      this.btnSwapAA.Click += new EventHandler(this.btnSwapAA_Click);
      this.btnSwapAT.Click += new EventHandler(this.btnSwapAT_Click);
      this.btnSwapTA.Click += new EventHandler(this.btnSwapTA_Click);
      this.chkPicInclude.CheckedChanged += new EventHandler(this.chkPicInclude_CheckedChanged);
      this.chkPicRelativPath.CheckedChanged += new EventHandler(this.chkPicRelativPath_CheckedChanged);
      this.cmbArtist.Leave += new EventHandler(this.Select_Leave);
      this.cmbArtist.TextChanged += new EventHandler(this.Select_TextChanged);
      this.cmbArtist.Enter += new EventHandler(this.Select_Enter);
      this.cmbCDescriptor.Leave += new EventHandler(this.Select_Leave);
      this.cmbCDescriptor.EnabledChanged += new EventHandler(this.Select_Enter);
      this.cmbCLanguage.Leave += new EventHandler(this.Select_Leave);
      this.cmbCLanguage.TextChanged += new EventHandler(this.Select_TextChanged);
      this.cmbCLanguage.Enter += new EventHandler(this.Select_Enter);
      this.cmbGenre.Leave += new EventHandler(this.Select_Leave);
      this.cmbGenre.TextChanged += new EventHandler(this.Select_TextChanged);
      this.cmbGenre.Enter += new EventHandler(this.Select_Enter);
      this.cmbLLanguage.Leave += new EventHandler(this.Select_Leave);
      this.cmbLLanguage.TextChanged += new EventHandler(this.Select_TextChanged);
      this.cmbLLanguage.Enter += new EventHandler(this.Select_Enter);
      this.cmbMedia.Leave += new EventHandler(this.Select_Leave);
      this.cmbMedia.TextChanged += new EventHandler(this.Select_TextChanged);
      this.cmbMedia.Enter += new EventHandler(this.Select_Enter);
      this.cmbPicType.Leave += new EventHandler(this.Select_Leave);
      this.cmbPicType.TextChanged += new EventHandler(this.Select_TextChanged);
      this.cmbPicType.Enter += new EventHandler(this.Select_Enter);
      this.CommentList.Leave += new EventHandler(this.Select_Leave);
      this.CommentList.Click += new EventHandler(this.CommentList_Click);
      this.GenreList.Leave += new EventHandler(this.Select_Leave);
      this.LyricsList.Leave += new EventHandler(this.Select_Leave);
      this.LyricsList.Click += new EventHandler(this.LyricsList_Click);
      this.PicList.Leave += new EventHandler(this.Select_Leave);
      this.PicList.Click += new EventHandler(this.PicList_Click);
      this.RatingList.Click += new EventHandler(this.RatingList_Click);
      this.TAGV2ButtonItem1.Click += new EventHandler(this.btnItem_Click);
      this.TAGV2ButtonItem2.Click += new EventHandler(this.btnItem_Click);
      this.TAGV2ButtonItem3.Click += new EventHandler(this.btnItem_Click);
      this.TAGV2ButtonItem4.Click += new EventHandler(this.btnItem_Click);
      this.TAGV2ButtonItem5.Click += new EventHandler(this.btnItem_Click);
      this.TAGV2ButtonItem6.Click += new EventHandler(this.btnItem_Click);
      this.TAGV2ButtonItem7.Click += new EventHandler(this.btnItem_Click);
      this.TAGV2ButtonItem8.Click += new EventHandler(this.btnItem_Click);
      this.TAGV2ButtonItem9.Click += new EventHandler(this.btnItem_Click);
      this.TIPLList.Click += new EventHandler(this.TIPLList_Click);
      this.TMCLList.Click += new EventHandler(this.TMCLList_Click);
      this.TORYFormat.Scroll += new ScrollEventHandler(this.TORYFormat_Scroll);
      this.txtAlbum.Leave += new EventHandler(this.Select_Leave);
      this.txtAlbum.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtAlbum.Enter += new EventHandler(this.Select_Enter);
      this.txtArtistURL.Leave += new EventHandler(this.Select_Leave);
      this.txtArtistURL.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtArtistURL.Enter += new EventHandler(this.Select_Enter);
      this.txtAudioFileURL.Leave += new EventHandler(this.Select_Leave);
      this.txtAudioFileURL.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtAudioFileURL.Enter += new EventHandler(this.Select_Enter);
      this.txtAudioSRCURL.Leave += new EventHandler(this.Select_Leave);
      this.txtAudioSRCURL.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtAudioSRCURL.Enter += new EventHandler(this.Select_Enter);
      this.txtBand.Leave += new EventHandler(this.Select_Leave);
      this.txtBand.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtBand.Enter += new EventHandler(this.Select_Enter);
      this.txtBPM.Leave += new EventHandler(this.Select_Leave);
      this.txtBPM.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtBPM.Enter += new EventHandler(this.Select_Enter);
      this.txtComment.Leave += new EventHandler(this.Select_Leave);
      this.txtComment.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtComment.Enter += new EventHandler(this.Select_Enter);
      this.txtCOMMInfURL.Leave += new EventHandler(this.Select_Leave);
      this.txtCOMMInfURL.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtCOMMInfURL.Enter += new EventHandler(this.Select_Enter);
      this.txtComposer.Leave += new EventHandler(this.Select_Leave);
      this.txtComposer.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtComposer.Enter += new EventHandler(this.Select_Enter);
      this.txtConductor.Leave += new EventHandler(this.Select_Leave);
      this.txtConductor.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtConductor.Enter += new EventHandler(this.Select_Enter);
      this.txtContent.Leave += new EventHandler(this.Select_Leave);
      this.txtContent.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtContent.Enter += new EventHandler(this.Select_Enter);
      this.txtCopyInfURL.Leave += new EventHandler(this.Select_Leave);
      this.txtCopyInfURL.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtCopyInfURL.Enter += new EventHandler(this.Select_Enter);
      this.txtCopyright.Leave += new EventHandler(this.Select_Leave);
      this.txtCopyright.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtCopyright.Enter += new EventHandler(this.Select_Enter);
      this.txtEncoded.Leave += new EventHandler(this.Select_Leave);
      this.txtEncoded.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtEncoded.Enter += new EventHandler(this.Select_Enter);
      this.txtINetRadioURL.Leave += new EventHandler(this.Select_Leave);
      this.txtINetRadioURL.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtINetRadioURL.Enter += new EventHandler(this.Select_Enter);
      this.txtInvFunction.Leave += new EventHandler(this.Select_Leave);
      this.txtInvFunction.Enter += new EventHandler(this.Select_Enter);
      this.txtInvPerson.Leave += new EventHandler(this.Select_Leave);
      this.txtInvPerson.Enter += new EventHandler(this.Select_Enter);
      this.txtLDescriptor.Leave += new EventHandler(this.Select_Leave);
      this.txtLDescriptor.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtLDescriptor.Enter += new EventHandler(this.Select_Enter);
      this.txtLyWriter.Leave += new EventHandler(this.Select_Leave);
      this.txtLyWriter.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtLyWriter.Enter += new EventHandler(this.Select_Enter);
      this.txtModified.Leave += new EventHandler(this.Select_Leave);
      this.txtModified.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtModified.Enter += new EventHandler(this.Select_Enter);
      this.txtMusicianInst.Leave += new EventHandler(this.Select_Leave);
      this.txtMusicianInst.Enter += new EventHandler(this.Select_Enter);
      this.txtMusicianName.Leave += new EventHandler(this.Select_Leave);
      this.txtMusicianName.Enter += new EventHandler(this.Select_Enter);
      this.txtOAlbum.Leave += new EventHandler(this.Select_Leave);
      this.txtOAlbum.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtOAlbum.Enter += new EventHandler(this.Select_Enter);
      this.txtOArtist.Leave += new EventHandler(this.Select_Leave);
      this.txtOArtist.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtOArtist.Enter += new EventHandler(this.Select_Enter);
      this.txtOFilename.Leave += new EventHandler(this.Select_Leave);
      this.txtOFilename.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtOFilename.Enter += new EventHandler(this.Select_Enter);
      this.txtOLyWriter.Leave += new EventHandler(this.Select_Leave);
      this.txtOLyWriter.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtOLyWriter.Enter += new EventHandler(this.Select_Enter);
      this.txtOOwner.Leave += new EventHandler(this.Select_Leave);
      this.txtOOwner.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtOOwner.Enter += new EventHandler(this.Select_Enter);
      this.txtPayURL.Leave += new EventHandler(this.Select_Leave);
      this.txtPayURL.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtPayURL.Enter += new EventHandler(this.Select_Enter);
      this.txtPDescriptor.Leave += new EventHandler(this.Select_Leave);
      this.txtPDescriptor.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtPDescriptor.Enter += new EventHandler(this.Select_Enter);
      this.txtPicPath.Leave += new EventHandler(this.Select_Leave);
      this.txtPicPath.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtPicPath.Enter += new EventHandler(this.Select_Enter);
      this.txtPOS1.Leave += new EventHandler(this.Select_Leave);
      this.txtPOS1.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtPOS1.Enter += new EventHandler(this.Select_Enter);
      this.txtPOS2.Leave += new EventHandler(this.Select_Leave);
      this.txtPOS2.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtPOS2.Enter += new EventHandler(this.Select_Enter);
      this.txtPublisher.Leave += new EventHandler(this.Select_Leave);
      this.txtPublisher.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtPublisher.Enter += new EventHandler(this.Select_Enter);
      this.txtPubURL.Leave += new EventHandler(this.Select_Leave);
      this.txtPubURL.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtPubURL.Enter += new EventHandler(this.Select_Enter);
      this.txtRatingCounter.Leave += new EventHandler(this.Select_Leave);
      this.txtRatingCounter.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtRatingCounter.Enter += new EventHandler(this.Select_Enter);
      this.txtRatingRating.Leave += new EventHandler(this.Select_Leave);
      this.txtRatingRating.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtRatingRating.Enter += new EventHandler(this.Select_Enter);
      this.txtRatingUser.Leave += new EventHandler(this.Select_Leave);
      this.txtRatingUser.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtRatingUser.Enter += new EventHandler(this.Select_Enter);
      this.txtSortAlbum.Leave += new EventHandler(this.Select_Leave);
      this.txtSortAlbum.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtSortAlbum.Enter += new EventHandler(this.Select_Enter);
      this.txtSortArtist.Leave += new EventHandler(this.Select_Leave);
      this.txtSortArtist.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtSortArtist.Enter += new EventHandler(this.Select_Enter);
      this.txtSortTitle.Leave += new EventHandler(this.Select_Leave);
      this.txtSortTitle.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtSortTitle.Enter += new EventHandler(this.Select_Enter);
      this.txtSubTitle.Leave += new EventHandler(this.Select_Leave);
      this.txtSubTitle.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtSubTitle.Enter += new EventHandler(this.Select_Enter);
      this.txtTitle.Leave += new EventHandler(this.Select_Leave);
      this.txtTitle.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtTitle.Enter += new EventHandler(this.Select_Enter);
      this.txtTORY.Leave += new EventHandler(this.Select_Leave);
      this.txtTORY.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtTORY.Enter += new EventHandler(this.Select_Enter);
      this.txtTrack1.Leave += new EventHandler(this.Select_Leave);
      this.txtTrack1.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtTrack1.Enter += new EventHandler(this.Select_Enter);
      this.txtTrack2.Leave += new EventHandler(this.Select_Leave);
      this.txtTrack2.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtTrack2.Enter += new EventHandler(this.Select_Enter);
      this.txtTXXXContent.Leave += new EventHandler(this.Select_Leave);
      this.txtTXXXContent.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtTXXXContent.Enter += new EventHandler(this.Select_Enter);
      this.txtTXXXDesc.Leave += new EventHandler(this.Select_Leave);
      this.txtTXXXDesc.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtTXXXDesc.Enter += new EventHandler(this.Select_Enter);
      this.txtWXXXContent.Leave += new EventHandler(this.Select_Leave);
      this.txtWXXXContent.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtWXXXContent.Enter += new EventHandler(this.Select_Enter);
      this.txtWXXXDesc.Leave += new EventHandler(this.Select_Leave);
      this.txtWXXXDesc.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtWXXXDesc.Enter += new EventHandler(this.Select_Enter);
      this.txtYear.Leave += new EventHandler(this.Select_Leave);
      this.txtYear.TextChanged += new EventHandler(this.Select_TextChanged);
      this.txtYear.Enter += new EventHandler(this.Select_Enter);
      this.TXXXList.Leave += new EventHandler(this.Select_Leave);
      this.TXXXList.Click += new EventHandler(this.TXXXList_Click);
      this.WXXXList.Leave += new EventHandler(this.Select_Leave);
      this.WXXXList.Click += new EventHandler(this.WXXXList_Click);
      this.YearFormat.Scroll += new ScrollEventHandler(this.YearFormat_Scroll);

      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new Size(0x35a, 0x240);
      this.ControlBox = false;
      this.Controls.Add(this.panMain);
      this.Controls.Add(this.panLyrics);
      this.Controls.Add(this.panPic);
      this.Controls.Add(this.panRating);
      this.Controls.Add(this.panInvolved);
      this.Controls.Add(this.panWeb);
      this.Controls.Add(this.panUser);
      this.Controls.Add(this.panOriginal);
      this.Controls.Add(this.panDetail);
      this.Controls.Add(this.TopPanel);
      this.Controls.Add(this.ButtomPanel);
      this.Controls.Add(this.SelectionBar);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmTAG2Multi";
      this.ShowInTaskbar = false;
      this.Text = "Multiple Edit TAG Ver. 2";
      this.panDetail.ResumeLayout(false);
      this.Panel9.ResumeLayout(false);
      this.Panel5.ResumeLayout(false);
      this.Panel14.ResumeLayout(false);
      this.Panel4.ResumeLayout(false);
      this.panOriginal.ResumeLayout(false);
      this.Panel6.ResumeLayout(false);
      this.panMain.ResumeLayout(false);
      this.Panel3.ResumeLayout(false);
      this.Panel1.ResumeLayout(false);
      this.Panel2.ResumeLayout(false);
      this.panWeb.ResumeLayout(false);
      this.Panel10.ResumeLayout(false);
      this.panRating.ResumeLayout(false);
      this.Panel11.ResumeLayout(false);
      this.txtRatingCounter.EndInit();
      this.txtRatingRating.EndInit();
      this.panInvolved.ResumeLayout(false);
      this.Panel15.ResumeLayout(false);
      this.Panel16.ResumeLayout(false);
      this.panPic.ResumeLayout(false);
      this.Panel7.ResumeLayout(false);
      this.panLyrics.ResumeLayout(false);
      this.Panel8.ResumeLayout(false);
      this.panUser.ResumeLayout(false);
      this.Panel12.ResumeLayout(false);
      this.Panel13.ResumeLayout(false);
      this.txtDigits.EndInit();
      ((ISupportInitialize)this.SelectionBar).EndInit();
      this.ButtomPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public frmTAG2Multi(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmTAG2Multi_Load);
      this.vbooCommentMoved = false;
      this.vbooLyricsMoved = false;
      this.vbooRatingMoved = false;
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
      this.txtPOS2 = (IntegerTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtPOS2, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtPOS1;
      this.txtPOS1 = (IntegerTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtPOS1, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtTrack2;
      this.txtTrack2 = (IntegerTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtTrack2, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtTrack1;
      this.txtTrack1 = (IntegerTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtTrack1, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtYear;
      this.txtYear = (AMS.TextBox.MaskedTextBox)cmbCDescriptor;
      this.ToolTip.SetToolTip(this.txtYear, Declarations.objResources.GetToolTip(ref vstrName, ref cmbCDescriptor));
      vstrName = "frmTAG2Multi";
      cmbCDescriptor = this.txtBPM;
      this.txtBPM = (NumericTextBox)cmbCDescriptor;
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
      this.txtTORY = (AMS.TextBox.MaskedTextBox)cmbCDescriptor;
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
      this.txtBPM.ModifyFlags(0x10, true);
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


    //internal virtual PictureBox APICView
    //{
    //  get
    //  {
    //    return this._APICView;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._APICView != null)
    //    {
    //    }
    //    this._APICView = value;
    //    if (this._APICView != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Button btnAddComment
    //{
    //  get
    //  {
    //    return this._btnAddComment;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnAddComment != null)
    //    {
    //      this._btnAddComment.Click -= new EventHandler(this.btnAddComment_Click);
    //    }
    //    this._btnAddComment = value;
    //    if (this._btnAddComment != null)
    //    {
    //      this._btnAddComment.Click += new EventHandler(this.btnAddComment_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnAddGenre
    //{
    //  get
    //  {
    //    return this._btnAddGenre;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnAddGenre != null)
    //    {
    //      this._btnAddGenre.Click -= new EventHandler(this.btnAddGenre_Click);
    //    }
    //    this._btnAddGenre = value;
    //    if (this._btnAddGenre != null)
    //    {
    //      this._btnAddGenre.Click += new EventHandler(this.btnAddGenre_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnAddInv
    //{
    //  get
    //  {
    //    return this._btnAddInv;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnAddInv != null)
    //    {
    //      this._btnAddInv.Click -= new EventHandler(this.btnAddInv_Click);
    //    }
    //    this._btnAddInv = value;
    //    if (this._btnAddInv != null)
    //    {
    //      this._btnAddInv.Click += new EventHandler(this.btnAddInv_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnAddLyrics
    //{
    //  get
    //  {
    //    return this._btnAddLyrics;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnAddLyrics != null)
    //    {
    //      this._btnAddLyrics.Click -= new EventHandler(this.btnAddLyrics_Click);
    //    }
    //    this._btnAddLyrics = value;
    //    if (this._btnAddLyrics != null)
    //    {
    //      this._btnAddLyrics.Click += new EventHandler(this.btnAddLyrics_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnAddMusician
    //{
    //  get
    //  {
    //    return this._btnAddMusician;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnAddMusician != null)
    //    {
    //      this._btnAddMusician.Click -= new EventHandler(this.btnAddMusican_Click);
    //    }
    //    this._btnAddMusician = value;
    //    if (this._btnAddMusician != null)
    //    {
    //      this._btnAddMusician.Click += new EventHandler(this.btnAddMusican_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnAddPicture
    //{
    //  get
    //  {
    //    return this._btnAddPicture;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnAddPicture != null)
    //    {
    //      this._btnAddPicture.Click -= new EventHandler(this.btnAddPicture_Click);
    //    }
    //    this._btnAddPicture = value;
    //    if (this._btnAddPicture != null)
    //    {
    //      this._btnAddPicture.Click += new EventHandler(this.btnAddPicture_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnAddRating
    //{
    //  get
    //  {
    //    return this._btnAddRating;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnAddRating != null)
    //    {
    //      this._btnAddRating.Click -= new EventHandler(this.btnAddRating_Click);
    //    }
    //    this._btnAddRating = value;
    //    if (this._btnAddRating != null)
    //    {
    //      this._btnAddRating.Click += new EventHandler(this.btnAddRating_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnAddTXXX
    //{
    //  get
    //  {
    //    return this._btnAddTXXX;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnAddTXXX != null)
    //    {
    //      this._btnAddTXXX.Click -= new EventHandler(this.btnAddTXXX_Click);
    //    }
    //    this._btnAddTXXX = value;
    //    if (this._btnAddTXXX != null)
    //    {
    //      this._btnAddTXXX.Click += new EventHandler(this.btnAddTXXX_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnAddWXXX
    //{
    //  get
    //  {
    //    return this._btnAddWXXX;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnAddWXXX != null)
    //    {
    //      this._btnAddWXXX.Click -= new EventHandler(this.btnAddWXXX_Click);
    //    }
    //    this._btnAddWXXX = value;
    //    if (this._btnAddWXXX != null)
    //    {
    //      this._btnAddWXXX.Click += new EventHandler(this.btnAddWXXX_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnCancel
    //{
    //  get
    //  {
    //    return this._btnCancel;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnCancel != null)
    //    {
    //      this._btnCancel.Click -= new EventHandler(this.btnCancel_Click);
    //    }
    //    this._btnCancel = value;
    //    if (this._btnCancel != null)
    //    {
    //      this._btnCancel.Click += new EventHandler(this.btnCancel_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem btnExport
    //{
    //  get
    //  {
    //    return this._btnExport;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnExport != null)
    //    {
    //    }
    //    this._btnExport = value;
    //    if (this._btnExport != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ButtonItem btnGet
    //{
    //  get
    //  {
    //    return this._btnGet;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnGet != null)
    //    {
    //    }
    //    this._btnGet = value;
    //    if (this._btnGet != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Button btnGetPic
    //{
    //  get
    //  {
    //    return this._btnGetPic;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnGetPic != null)
    //    {
    //      this._btnGetPic.Click -= new EventHandler(this.btnGetPic_Click);
    //    }
    //    this._btnGetPic = value;
    //    if (this._btnGetPic != null)
    //    {
    //      this._btnGetPic.Click += new EventHandler(this.btnGetPic_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem btnImport
    //{
    //  get
    //  {
    //    return this._btnImport;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnImport != null)
    //    {
    //    }
    //    this._btnImport = value;
    //    if (this._btnImport != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Button btnLyricsFile
    //{
    //  get
    //  {
    //    return this._btnLyricsFile;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnLyricsFile != null)
    //    {
    //      this._btnLyricsFile.Click -= new EventHandler(this.btnLyricsFile_Click);
    //    }
    //    this._btnLyricsFile = value;
    //    if (this._btnLyricsFile != null)
    //    {
    //      this._btnLyricsFile.Click += new EventHandler(this.btnLyricsFile_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnMoveComment
    //{
    //  get
    //  {
    //    return this._btnMoveComment;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnMoveComment != null)
    //    {
    //      this._btnMoveComment.Click -= new EventHandler(this.btnMoveComment_Click);
    //    }
    //    this._btnMoveComment = value;
    //    if (this._btnMoveComment != null)
    //    {
    //      this._btnMoveComment.Click += new EventHandler(this.btnMoveComment_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnMoveGenre
    //{
    //  get
    //  {
    //    return this._btnMoveGenre;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnMoveGenre != null)
    //    {
    //      this._btnMoveGenre.Click -= new EventHandler(this.btnMoveGenre_Click);
    //    }
    //    this._btnMoveGenre = value;
    //    if (this._btnMoveGenre != null)
    //    {
    //      this._btnMoveGenre.Click += new EventHandler(this.btnMoveGenre_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnMoveLyrics
    //{
    //  get
    //  {
    //    return this._btnMoveLyrics;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnMoveLyrics != null)
    //    {
    //      this._btnMoveLyrics.Click -= new EventHandler(this.btnMoveLyrics_Click);
    //    }
    //    this._btnMoveLyrics = value;
    //    if (this._btnMoveLyrics != null)
    //    {
    //      this._btnMoveLyrics.Click += new EventHandler(this.btnMoveLyrics_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnMoveRating
    //{
    //  get
    //  {
    //    return this._btnMoveRating;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnMoveRating != null)
    //    {
    //      this._btnMoveRating.Click -= new EventHandler(this.btnMoveRating_Click);
    //    }
    //    this._btnMoveRating = value;
    //    if (this._btnMoveRating != null)
    //    {
    //      this._btnMoveRating.Click += new EventHandler(this.btnMoveRating_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnOK
    //{
    //  get
    //  {
    //    return this._btnOK;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnOK != null)
    //    {
    //      this._btnOK.Click -= new EventHandler(this.btnOK_Click);
    //    }
    //    this._btnOK = value;
    //    if (this._btnOK != null)
    //    {
    //      this._btnOK.Click += new EventHandler(this.btnOK_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnRemoveComment
    //{
    //  get
    //  {
    //    return this._btnRemoveComment;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnRemoveComment != null)
    //    {
    //      this._btnRemoveComment.Click -= new EventHandler(this.btnRemoveComment_Click);
    //    }
    //    this._btnRemoveComment = value;
    //    if (this._btnRemoveComment != null)
    //    {
    //      this._btnRemoveComment.Click += new EventHandler(this.btnRemoveComment_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnRemoveGenre
    //{
    //  get
    //  {
    //    return this._btnRemoveGenre;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnRemoveGenre != null)
    //    {
    //      this._btnRemoveGenre.Click -= new EventHandler(this.btnRemoveGenre_Click);
    //    }
    //    this._btnRemoveGenre = value;
    //    if (this._btnRemoveGenre != null)
    //    {
    //      this._btnRemoveGenre.Click += new EventHandler(this.btnRemoveGenre_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnRemoveInv
    //{
    //  get
    //  {
    //    return this._btnRemoveInv;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnRemoveInv != null)
    //    {
    //      this._btnRemoveInv.Click -= new EventHandler(this.btnRemoveInv_Click);
    //    }
    //    this._btnRemoveInv = value;
    //    if (this._btnRemoveInv != null)
    //    {
    //      this._btnRemoveInv.Click += new EventHandler(this.btnRemoveInv_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnRemoveLyrics
    //{
    //  get
    //  {
    //    return this._btnRemoveLyrics;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnRemoveLyrics != null)
    //    {
    //      this._btnRemoveLyrics.Click -= new EventHandler(this.btnRemoveLyrics_Click);
    //    }
    //    this._btnRemoveLyrics = value;
    //    if (this._btnRemoveLyrics != null)
    //    {
    //      this._btnRemoveLyrics.Click += new EventHandler(this.btnRemoveLyrics_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnRemoveMusician
    //{
    //  get
    //  {
    //    return this._btnRemoveMusician;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnRemoveMusician != null)
    //    {
    //      this._btnRemoveMusician.Click -= new EventHandler(this.btnRemoveMusican_Click);
    //    }
    //    this._btnRemoveMusician = value;
    //    if (this._btnRemoveMusician != null)
    //    {
    //      this._btnRemoveMusician.Click += new EventHandler(this.btnRemoveMusican_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnRemovePicture
    //{
    //  get
    //  {
    //    return this._btnRemovePicture;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnRemovePicture != null)
    //    {
    //      this._btnRemovePicture.Click -= new EventHandler(this.btnRemovePicture_Click);
    //    }
    //    this._btnRemovePicture = value;
    //    if (this._btnRemovePicture != null)
    //    {
    //      this._btnRemovePicture.Click += new EventHandler(this.btnRemovePicture_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnRemoveRating
    //{
    //  get
    //  {
    //    return this._btnRemoveRating;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnRemoveRating != null)
    //    {
    //      this._btnRemoveRating.Click -= new EventHandler(this.btnRemoveRating_Click);
    //    }
    //    this._btnRemoveRating = value;
    //    if (this._btnRemoveRating != null)
    //    {
    //      this._btnRemoveRating.Click += new EventHandler(this.btnRemoveRating_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnRemoveTXXX
    //{
    //  get
    //  {
    //    return this._btnRemoveTXXX;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnRemoveTXXX != null)
    //    {
    //      this._btnRemoveTXXX.Click -= new EventHandler(this.btnRemoveTXXX_Click);
    //    }
    //    this._btnRemoveTXXX = value;
    //    if (this._btnRemoveTXXX != null)
    //    {
    //      this._btnRemoveTXXX.Click += new EventHandler(this.btnRemoveTXXX_Click);
    //    }
    //  }
    //}

    //internal virtual Button btnRemoveWXXX
    //{
    //  get
    //  {
    //    return this._btnRemoveWXXX;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnRemoveWXXX != null)
    //    {
    //      this._btnRemoveWXXX.Click -= new EventHandler(this.btnRemoveWXXX_Click);
    //    }
    //    this._btnRemoveWXXX = value;
    //    if (this._btnRemoveWXXX != null)
    //    {
    //      this._btnRemoveWXXX.Click += new EventHandler(this.btnRemoveWXXX_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem btnSwapAA
    //{
    //  get
    //  {
    //    return this._btnSwapAA;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnSwapAA != null)
    //    {
    //      this._btnSwapAA.Click -= new EventHandler(this.btnSwapAA_Click);
    //    }
    //    this._btnSwapAA = value;
    //    if (this._btnSwapAA != null)
    //    {
    //      this._btnSwapAA.Click += new EventHandler(this.btnSwapAA_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem btnSwapAT
    //{
    //  get
    //  {
    //    return this._btnSwapAT;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnSwapAT != null)
    //    {
    //      this._btnSwapAT.Click -= new EventHandler(this.btnSwapAT_Click);
    //    }
    //    this._btnSwapAT = value;
    //    if (this._btnSwapAT != null)
    //    {
    //      this._btnSwapAT.Click += new EventHandler(this.btnSwapAT_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem btnSwapTA
    //{
    //  get
    //  {
    //    return this._btnSwapTA;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._btnSwapTA != null)
    //    {
    //      this._btnSwapTA.Click -= new EventHandler(this.btnSwapTA_Click);
    //    }
    //    this._btnSwapTA = value;
    //    if (this._btnSwapTA != null)
    //    {
    //      this._btnSwapTA.Click += new EventHandler(this.btnSwapTA_Click);
    //    }
    //  }
    //}

    //internal virtual PanelEx ButtomPanel
    //{
    //  get
    //  {
    //    return this._ButtomPanel;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ButtomPanel != null)
    //    {
    //    }
    //    this._ButtomPanel = value;
    //    if (this._ButtomPanel != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox1
    //{
    //  get
    //  {
    //    return this._CheckBox1;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox1 != null)
    //    {
    //    }
    //    this._CheckBox1 = value;
    //    if (this._CheckBox1 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox10
    //{
    //  get
    //  {
    //    return this._CheckBox10;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox10 != null)
    //    {
    //    }
    //    this._CheckBox10 = value;
    //    if (this._CheckBox10 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox11
    //{
    //  get
    //  {
    //    return this._CheckBox11;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox11 != null)
    //    {
    //    }
    //    this._CheckBox11 = value;
    //    if (this._CheckBox11 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox12
    //{
    //  get
    //  {
    //    return this._CheckBox12;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox12 != null)
    //    {
    //    }
    //    this._CheckBox12 = value;
    //    if (this._CheckBox12 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox13
    //{
    //  get
    //  {
    //    return this._CheckBox13;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox13 != null)
    //    {
    //    }
    //    this._CheckBox13 = value;
    //    if (this._CheckBox13 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox14
    //{
    //  get
    //  {
    //    return this._CheckBox14;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox14 != null)
    //    {
    //    }
    //    this._CheckBox14 = value;
    //    if (this._CheckBox14 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox15
    //{
    //  get
    //  {
    //    return this._CheckBox15;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox15 != null)
    //    {
    //    }
    //    this._CheckBox15 = value;
    //    if (this._CheckBox15 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox16
    //{
    //  get
    //  {
    //    return this._CheckBox16;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox16 != null)
    //    {
    //    }
    //    this._CheckBox16 = value;
    //    if (this._CheckBox16 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox17
    //{
    //  get
    //  {
    //    return this._CheckBox17;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox17 != null)
    //    {
    //    }
    //    this._CheckBox17 = value;
    //    if (this._CheckBox17 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox18
    //{
    //  get
    //  {
    //    return this._CheckBox18;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox18 != null)
    //    {
    //    }
    //    this._CheckBox18 = value;
    //    if (this._CheckBox18 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox19
    //{
    //  get
    //  {
    //    return this._CheckBox19;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox19 != null)
    //    {
    //    }
    //    this._CheckBox19 = value;
    //    if (this._CheckBox19 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox2
    //{
    //  get
    //  {
    //    return this._CheckBox2;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox2 != null)
    //    {
    //    }
    //    this._CheckBox2 = value;
    //    if (this._CheckBox2 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox20
    //{
    //  get
    //  {
    //    return this._CheckBox20;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox20 != null)
    //    {
    //    }
    //    this._CheckBox20 = value;
    //    if (this._CheckBox20 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox21
    //{
    //  get
    //  {
    //    return this._CheckBox21;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox21 != null)
    //    {
    //    }
    //    this._CheckBox21 = value;
    //    if (this._CheckBox21 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox22
    //{
    //  get
    //  {
    //    return this._CheckBox22;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox22 != null)
    //    {
    //    }
    //    this._CheckBox22 = value;
    //    if (this._CheckBox22 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox23
    //{
    //  get
    //  {
    //    return this._CheckBox23;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox23 != null)
    //    {
    //    }
    //    this._CheckBox23 = value;
    //    if (this._CheckBox23 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox24
    //{
    //  get
    //  {
    //    return this._CheckBox24;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox24 != null)
    //    {
    //    }
    //    this._CheckBox24 = value;
    //    if (this._CheckBox24 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox25
    //{
    //  get
    //  {
    //    return this._CheckBox25;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox25 != null)
    //    {
    //    }
    //    this._CheckBox25 = value;
    //    if (this._CheckBox25 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox26
    //{
    //  get
    //  {
    //    return this._CheckBox26;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox26 != null)
    //    {
    //    }
    //    this._CheckBox26 = value;
    //    if (this._CheckBox26 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox27
    //{
    //  get
    //  {
    //    return this._CheckBox27;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox27 != null)
    //    {
    //    }
    //    this._CheckBox27 = value;
    //    if (this._CheckBox27 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox28
    //{
    //  get
    //  {
    //    return this._CheckBox28;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox28 != null)
    //    {
    //    }
    //    this._CheckBox28 = value;
    //    if (this._CheckBox28 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox29
    //{
    //  get
    //  {
    //    return this._CheckBox29;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox29 != null)
    //    {
    //    }
    //    this._CheckBox29 = value;
    //    if (this._CheckBox29 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox3
    //{
    //  get
    //  {
    //    return this._CheckBox3;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox3 != null)
    //    {
    //    }
    //    this._CheckBox3 = value;
    //    if (this._CheckBox3 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox30
    //{
    //  get
    //  {
    //    return this._CheckBox30;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox30 != null)
    //    {
    //    }
    //    this._CheckBox30 = value;
    //    if (this._CheckBox30 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox31
    //{
    //  get
    //  {
    //    return this._CheckBox31;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox31 != null)
    //    {
    //    }
    //    this._CheckBox31 = value;
    //    if (this._CheckBox31 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox32
    //{
    //  get
    //  {
    //    return this._CheckBox32;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox32 != null)
    //    {
    //    }
    //    this._CheckBox32 = value;
    //    if (this._CheckBox32 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox33
    //{
    //  get
    //  {
    //    return this._CheckBox33;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox33 != null)
    //    {
    //    }
    //    this._CheckBox33 = value;
    //    if (this._CheckBox33 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox34
    //{
    //  get
    //  {
    //    return this._CheckBox34;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox34 != null)
    //    {
    //    }
    //    this._CheckBox34 = value;
    //    if (this._CheckBox34 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox35
    //{
    //  get
    //  {
    //    return this._CheckBox35;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox35 != null)
    //    {
    //    }
    //    this._CheckBox35 = value;
    //    if (this._CheckBox35 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox36
    //{
    //  get
    //  {
    //    return this._CheckBox36;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox36 != null)
    //    {
    //    }
    //    this._CheckBox36 = value;
    //    if (this._CheckBox36 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox37
    //{
    //  get
    //  {
    //    return this._CheckBox37;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox37 != null)
    //    {
    //    }
    //    this._CheckBox37 = value;
    //    if (this._CheckBox37 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox38
    //{
    //  get
    //  {
    //    return this._CheckBox38;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox38 != null)
    //    {
    //    }
    //    this._CheckBox38 = value;
    //    if (this._CheckBox38 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox39
    //{
    //  get
    //  {
    //    return this._CheckBox39;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox39 != null)
    //    {
    //    }
    //    this._CheckBox39 = value;
    //    if (this._CheckBox39 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox4
    //{
    //  get
    //  {
    //    return this._CheckBox4;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox4 != null)
    //    {
    //    }
    //    this._CheckBox4 = value;
    //    if (this._CheckBox4 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox40
    //{
    //  get
    //  {
    //    return this._CheckBox40;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox40 != null)
    //    {
    //    }
    //    this._CheckBox40 = value;
    //    if (this._CheckBox40 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox41
    //{
    //  get
    //  {
    //    return this._CheckBox41;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox41 != null)
    //    {
    //    }
    //    this._CheckBox41 = value;
    //    if (this._CheckBox41 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox42
    //{
    //  get
    //  {
    //    return this._CheckBox42;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox42 != null)
    //    {
    //    }
    //    this._CheckBox42 = value;
    //    if (this._CheckBox42 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox43
    //{
    //  get
    //  {
    //    return this._CheckBox43;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox43 != null)
    //    {
    //    }
    //    this._CheckBox43 = value;
    //    if (this._CheckBox43 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox44
    //{
    //  get
    //  {
    //    return this._CheckBox44;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox44 != null)
    //    {
    //    }
    //    this._CheckBox44 = value;
    //    if (this._CheckBox44 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox45
    //{
    //  get
    //  {
    //    return this._CheckBox45;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox45 != null)
    //    {
    //    }
    //    this._CheckBox45 = value;
    //    if (this._CheckBox45 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox5
    //{
    //  get
    //  {
    //    return this._CheckBox5;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox5 != null)
    //    {
    //    }
    //    this._CheckBox5 = value;
    //    if (this._CheckBox5 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox6
    //{
    //  get
    //  {
    //    return this._CheckBox6;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox6 != null)
    //    {
    //    }
    //    this._CheckBox6 = value;
    //    if (this._CheckBox6 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox7
    //{
    //  get
    //  {
    //    return this._CheckBox7;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox7 != null)
    //    {
    //    }
    //    this._CheckBox7 = value;
    //    if (this._CheckBox7 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox8
    //{
    //  get
    //  {
    //    return this._CheckBox8;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox8 != null)
    //    {
    //    }
    //    this._CheckBox8 = value;
    //    if (this._CheckBox8 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox CheckBox9
    //{
    //  get
    //  {
    //    return this._CheckBox9;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CheckBox9 != null)
    //    {
    //    }
    //    this._CheckBox9 = value;
    //    if (this._CheckBox9 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox chkPicInclude
    //{
    //  get
    //  {
    //    return this._chkPicInclude;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._chkPicInclude != null)
    //    {
    //      this._chkPicInclude.CheckedChanged -= new EventHandler(this.chkPicInclude_CheckedChanged);
    //    }
    //    this._chkPicInclude = value;
    //    if (this._chkPicInclude != null)
    //    {
    //      this._chkPicInclude.CheckedChanged += new EventHandler(this.chkPicInclude_CheckedChanged);
    //    }
    //  }
    //}

    //internal virtual CheckBox chkPicRelativPath
    //{
    //  get
    //  {
    //    return this._chkPicRelativPath;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._chkPicRelativPath != null)
    //    {
    //      this._chkPicRelativPath.CheckedChanged -= new EventHandler(this.chkPicRelativPath_CheckedChanged);
    //    }
    //    this._chkPicRelativPath = value;
    //    if (this._chkPicRelativPath != null)
    //    {
    //      this._chkPicRelativPath.CheckedChanged += new EventHandler(this.chkPicRelativPath_CheckedChanged);
    //    }
    //  }
    //}

    //internal virtual CheckBox chkRemoveAllNOT
    //{
    //  get
    //  {
    //    return this._chkRemoveAllNOT;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._chkRemoveAllNOT != null)
    //    {
    //    }
    //    this._chkRemoveAllNOT = value;
    //    if (this._chkRemoveAllNOT != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual CheckBox chkTLEN
    //{
    //  get
    //  {
    //    return this._chkTLEN;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._chkTLEN != null)
    //    {
    //    }
    //    this._chkTLEN = value;
    //    if (this._chkTLEN != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ComboBoxAutoComplete cmbArtist
    //{
    //  get
    //  {
    //    return this._cmbArtist;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._cmbArtist != null)
    //    {
    //      this._cmbArtist.Leave -= new EventHandler(this.Select_Leave);
    //      this._cmbArtist.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._cmbArtist.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._cmbArtist = value;
    //    if (this._cmbArtist != null)
    //    {
    //      this._cmbArtist.Leave += new EventHandler(this.Select_Leave);
    //      this._cmbArtist.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._cmbArtist.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual ComboBoxAutoComplete cmbCDescriptor
    //{
    //  get
    //  {
    //    return this._cmbCDescriptor;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._cmbCDescriptor != null)
    //    {
    //      this._cmbCDescriptor.Leave -= new EventHandler(this.Select_Leave);
    //      this._cmbCDescriptor.EnabledChanged -= new EventHandler(this.Select_Enter);
    //    }
    //    this._cmbCDescriptor = value;
    //    if (this._cmbCDescriptor != null)
    //    {
    //      this._cmbCDescriptor.Leave += new EventHandler(this.Select_Leave);
    //      this._cmbCDescriptor.EnabledChanged += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual ComboBox cmbCLanguage
    //{
    //  get
    //  {
    //    return this._cmbCLanguage;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._cmbCLanguage != null)
    //    {
    //      this._cmbCLanguage.Leave -= new EventHandler(this.Select_Leave);
    //      this._cmbCLanguage.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._cmbCLanguage.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._cmbCLanguage = value;
    //    if (this._cmbCLanguage != null)
    //    {
    //      this._cmbCLanguage.Leave += new EventHandler(this.Select_Leave);
    //      this._cmbCLanguage.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._cmbCLanguage.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual ComboBoxAutoComplete cmbGenre
    //{
    //  get
    //  {
    //    return this._cmbGenre;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._cmbGenre != null)
    //    {
    //      this._cmbGenre.Leave -= new EventHandler(this.Select_Leave);
    //      this._cmbGenre.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._cmbGenre.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._cmbGenre = value;
    //    if (this._cmbGenre != null)
    //    {
    //      this._cmbGenre.Leave += new EventHandler(this.Select_Leave);
    //      this._cmbGenre.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._cmbGenre.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual ComboBox cmbLLanguage
    //{
    //  get
    //  {
    //    return this._cmbLLanguage;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._cmbLLanguage != null)
    //    {
    //      this._cmbLLanguage.Leave -= new EventHandler(this.Select_Leave);
    //      this._cmbLLanguage.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._cmbLLanguage.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._cmbLLanguage = value;
    //    if (this._cmbLLanguage != null)
    //    {
    //      this._cmbLLanguage.Leave += new EventHandler(this.Select_Leave);
    //      this._cmbLLanguage.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._cmbLLanguage.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual ComboBox cmbMedia
    //{
    //  get
    //  {
    //    return this._cmbMedia;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._cmbMedia != null)
    //    {
    //      this._cmbMedia.Leave -= new EventHandler(this.Select_Leave);
    //      this._cmbMedia.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._cmbMedia.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._cmbMedia = value;
    //    if (this._cmbMedia != null)
    //    {
    //      this._cmbMedia.Leave += new EventHandler(this.Select_Leave);
    //      this._cmbMedia.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._cmbMedia.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual ComboBox cmbPicType
    //{
    //  get
    //  {
    //    return this._cmbPicType;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._cmbPicType != null)
    //    {
    //      this._cmbPicType.Leave -= new EventHandler(this.Select_Leave);
    //      this._cmbPicType.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._cmbPicType.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._cmbPicType = value;
    //    if (this._cmbPicType != null)
    //    {
    //      this._cmbPicType.Leave += new EventHandler(this.Select_Leave);
    //      this._cmbPicType.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._cmbPicType.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual ColumnHeader colComment
    //{
    //  get
    //  {
    //    return this._colComment;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._colComment != null)
    //    {
    //    }
    //    this._colComment = value;
    //    if (this._colComment != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader colDescriptor
    //{
    //  get
    //  {
    //    return this._colDescriptor;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._colDescriptor != null)
    //    {
    //    }
    //    this._colDescriptor = value;
    //    if (this._colDescriptor != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader colLanguage
    //{
    //  get
    //  {
    //    return this._colLanguage;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._colLanguage != null)
    //    {
    //    }
    //    this._colLanguage = value;
    //    if (this._colLanguage != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader1
    //{
    //  get
    //  {
    //    return this._ColumnHeader1;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader1 != null)
    //    {
    //    }
    //    this._ColumnHeader1 = value;
    //    if (this._ColumnHeader1 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader10
    //{
    //  get
    //  {
    //    return this._ColumnHeader10;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader10 != null)
    //    {
    //    }
    //    this._ColumnHeader10 = value;
    //    if (this._ColumnHeader10 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader11
    //{
    //  get
    //  {
    //    return this._ColumnHeader11;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader11 != null)
    //    {
    //    }
    //    this._ColumnHeader11 = value;
    //    if (this._ColumnHeader11 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader12
    //{
    //  get
    //  {
    //    return this._ColumnHeader12;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader12 != null)
    //    {
    //    }
    //    this._ColumnHeader12 = value;
    //    if (this._ColumnHeader12 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader13
    //{
    //  get
    //  {
    //    return this._ColumnHeader13;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader13 != null)
    //    {
    //    }
    //    this._ColumnHeader13 = value;
    //    if (this._ColumnHeader13 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader14
    //{
    //  get
    //  {
    //    return this._ColumnHeader14;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader14 != null)
    //    {
    //    }
    //    this._ColumnHeader14 = value;
    //    if (this._ColumnHeader14 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader15
    //{
    //  get
    //  {
    //    return this._ColumnHeader15;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader15 != null)
    //    {
    //    }
    //    this._ColumnHeader15 = value;
    //    if (this._ColumnHeader15 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader16
    //{
    //  get
    //  {
    //    return this._ColumnHeader16;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader16 != null)
    //    {
    //    }
    //    this._ColumnHeader16 = value;
    //    if (this._ColumnHeader16 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader17
    //{
    //  get
    //  {
    //    return this._ColumnHeader17;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader17 != null)
    //    {
    //    }
    //    this._ColumnHeader17 = value;
    //    if (this._ColumnHeader17 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader18
    //{
    //  get
    //  {
    //    return this._ColumnHeader18;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader18 != null)
    //    {
    //    }
    //    this._ColumnHeader18 = value;
    //    if (this._ColumnHeader18 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader2
    //{
    //  get
    //  {
    //    return this._ColumnHeader2;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader2 != null)
    //    {
    //    }
    //    this._ColumnHeader2 = value;
    //    if (this._ColumnHeader2 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader3
    //{
    //  get
    //  {
    //    return this._ColumnHeader3;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader3 != null)
    //    {
    //    }
    //    this._ColumnHeader3 = value;
    //    if (this._ColumnHeader3 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader4
    //{
    //  get
    //  {
    //    return this._ColumnHeader4;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader4 != null)
    //    {
    //    }
    //    this._ColumnHeader4 = value;
    //    if (this._ColumnHeader4 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader5
    //{
    //  get
    //  {
    //    return this._ColumnHeader5;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader5 != null)
    //    {
    //    }
    //    this._ColumnHeader5 = value;
    //    if (this._ColumnHeader5 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader6
    //{
    //  get
    //  {
    //    return this._ColumnHeader6;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader6 != null)
    //    {
    //    }
    //    this._ColumnHeader6 = value;
    //    if (this._ColumnHeader6 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader7
    //{
    //  get
    //  {
    //    return this._ColumnHeader7;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader7 != null)
    //    {
    //    }
    //    this._ColumnHeader7 = value;
    //    if (this._ColumnHeader7 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader8
    //{
    //  get
    //  {
    //    return this._ColumnHeader8;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader8 != null)
    //    {
    //    }
    //    this._ColumnHeader8 = value;
    //    if (this._ColumnHeader8 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ColumnHeader ColumnHeader9
    //{
    //  get
    //  {
    //    return this._ColumnHeader9;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ColumnHeader9 != null)
    //    {
    //    }
    //    this._ColumnHeader9 = value;
    //    if (this._ColumnHeader9 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ListView CommentList
    //{
    //  get
    //  {
    //    return this._CommentList;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._CommentList != null)
    //    {
    //      this._CommentList.Leave -= new EventHandler(this.Select_Leave);
    //      this._CommentList.Click -= new EventHandler(this.CommentList_Click);
    //    }
    //    this._CommentList = value;
    //    if (this._CommentList != null)
    //    {
    //      this._CommentList.Leave += new EventHandler(this.Select_Leave);
    //      this._CommentList.Click += new EventHandler(this.CommentList_Click);
    //    }
    //  }
    //}

    //internal virtual ListBox GenreList
    //{
    //  get
    //  {
    //    return this._GenreList;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._GenreList != null)
    //    {
    //      this._GenreList.Leave -= new EventHandler(this.Select_Leave);
    //    }
    //    this._GenreList = value;
    //    if (this._GenreList != null)
    //    {
    //      this._GenreList.Leave += new EventHandler(this.Select_Leave);
    //    }
    //  }
    //}

    //internal virtual ButtonItem Label
    //{
    //  get
    //  {
    //    return this._Label;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Label != null)
    //    {
    //    }
    //    this._Label = value;
    //    if (this._Label != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblAlbum
    //{
    //  get
    //  {
    //    return this._lblAlbum;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblAlbum != null)
    //    {
    //    }
    //    this._lblAlbum = value;
    //    if (this._lblAlbum != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblAlbumSort
    //{
    //  get
    //  {
    //    return this._lblAlbumSort;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblAlbumSort != null)
    //    {
    //    }
    //    this._lblAlbumSort = value;
    //    if (this._lblAlbumSort != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblArtist
    //{
    //  get
    //  {
    //    return this._lblArtist;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblArtist != null)
    //    {
    //    }
    //    this._lblArtist = value;
    //    if (this._lblArtist != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblArtistSort
    //{
    //  get
    //  {
    //    return this._lblArtistSort;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblArtistSort != null)
    //    {
    //    }
    //    this._lblArtistSort = value;
    //    if (this._lblArtistSort != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblArtistURL
    //{
    //  get
    //  {
    //    return this._lblArtistURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblArtistURL != null)
    //    {
    //    }
    //    this._lblArtistURL = value;
    //    if (this._lblArtistURL != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblAudioFileURL
    //{
    //  get
    //  {
    //    return this._lblAudioFileURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblAudioFileURL != null)
    //    {
    //    }
    //    this._lblAudioFileURL = value;
    //    if (this._lblAudioFileURL != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblAudioSRCURL
    //{
    //  get
    //  {
    //    return this._lblAudioSRCURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblAudioSRCURL != null)
    //    {
    //    }
    //    this._lblAudioSRCURL = value;
    //    if (this._lblAudioSRCURL != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblBand
    //{
    //  get
    //  {
    //    return this._lblBand;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblBand != null)
    //    {
    //    }
    //    this._lblBand = value;
    //    if (this._lblBand != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblBPM
    //{
    //  get
    //  {
    //    return this._lblBPM;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblBPM != null)
    //    {
    //    }
    //    this._lblBPM = value;
    //    if (this._lblBPM != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblCOMM
    //{
    //  get
    //  {
    //    return this._lblCOMM;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblCOMM != null)
    //    {
    //    }
    //    this._lblCOMM = value;
    //    if (this._lblCOMM != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblCOMMDesc
    //{
    //  get
    //  {
    //    return this._lblCOMMDesc;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblCOMMDesc != null)
    //    {
    //    }
    //    this._lblCOMMDesc = value;
    //    if (this._lblCOMMDesc != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblCommDescInfo
    //{
    //  get
    //  {
    //    return this._lblCommDescInfo;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblCommDescInfo != null)
    //    {
    //    }
    //    this._lblCommDescInfo = value;
    //    if (this._lblCommDescInfo != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblCOMMInfURL
    //{
    //  get
    //  {
    //    return this._lblCOMMInfURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblCOMMInfURL != null)
    //    {
    //    }
    //    this._lblCOMMInfURL = value;
    //    if (this._lblCOMMInfURL != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblCOMMLan
    //{
    //  get
    //  {
    //    return this._lblCOMMLan;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblCOMMLan != null)
    //    {
    //    }
    //    this._lblCOMMLan = value;
    //    if (this._lblCOMMLan != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblComposer
    //{
    //  get
    //  {
    //    return this._lblComposer;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblComposer != null)
    //    {
    //    }
    //    this._lblComposer = value;
    //    if (this._lblComposer != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblConductor
    //{
    //  get
    //  {
    //    return this._lblConductor;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblConductor != null)
    //    {
    //    }
    //    this._lblConductor = value;
    //    if (this._lblConductor != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblContent
    //{
    //  get
    //  {
    //    return this._lblContent;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblContent != null)
    //    {
    //    }
    //    this._lblContent = value;
    //    if (this._lblContent != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblCopyInfURL
    //{
    //  get
    //  {
    //    return this._lblCopyInfURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblCopyInfURL != null)
    //    {
    //    }
    //    this._lblCopyInfURL = value;
    //    if (this._lblCopyInfURL != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblCopyright
    //{
    //  get
    //  {
    //    return this._lblCopyright;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblCopyright != null)
    //    {
    //    }
    //    this._lblCopyright = value;
    //    if (this._lblCopyright != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblDigits
    //{
    //  get
    //  {
    //    return this._lblDigits;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblDigits != null)
    //    {
    //    }
    //    this._lblDigits = value;
    //    if (this._lblDigits != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblEncoded
    //{
    //  get
    //  {
    //    return this._lblEncoded;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblEncoded != null)
    //    {
    //    }
    //    this._lblEncoded = value;
    //    if (this._lblEncoded != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblGenre
    //{
    //  get
    //  {
    //    return this._lblGenre;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblGenre != null)
    //    {
    //    }
    //    this._lblGenre = value;
    //    if (this._lblGenre != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblGenreInfo
    //{
    //  get
    //  {
    //    return this._lblGenreInfo;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblGenreInfo != null)
    //    {
    //    }
    //    this._lblGenreInfo = value;
    //    if (this._lblGenreInfo != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblINetRadioURL
    //{
    //  get
    //  {
    //    return this._lblINetRadioURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblINetRadioURL != null)
    //    {
    //    }
    //    this._lblINetRadioURL = value;
    //    if (this._lblINetRadioURL != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblInfo
    //{
    //  get
    //  {
    //    return this._lblInfo;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblInfo != null)
    //    {
    //    }
    //    this._lblInfo = value;
    //    if (this._lblInfo != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblInfoStar
    //{
    //  get
    //  {
    //    return this._lblInfoStar;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblInfoStar != null)
    //    {
    //    }
    //    this._lblInfoStar = value;
    //    if (this._lblInfoStar != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblInvFunction
    //{
    //  get
    //  {
    //    return this._lblInvFunction;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblInvFunction != null)
    //    {
    //    }
    //    this._lblInvFunction = value;
    //    if (this._lblInvFunction != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblInvPerson
    //{
    //  get
    //  {
    //    return this._lblInvPerson;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblInvPerson != null)
    //    {
    //    }
    //    this._lblInvPerson = value;
    //    if (this._lblInvPerson != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblLyDesc
    //{
    //  get
    //  {
    //    return this._lblLyDesc;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblLyDesc != null)
    //    {
    //    }
    //    this._lblLyDesc = value;
    //    if (this._lblLyDesc != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblLyLan
    //{
    //  get
    //  {
    //    return this._lblLyLan;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblLyLan != null)
    //    {
    //    }
    //    this._lblLyLan = value;
    //    if (this._lblLyLan != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblLyrics
    //{
    //  get
    //  {
    //    return this._lblLyrics;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblLyrics != null)
    //    {
    //    }
    //    this._lblLyrics = value;
    //    if (this._lblLyrics != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblLyWriter
    //{
    //  get
    //  {
    //    return this._lblLyWriter;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblLyWriter != null)
    //    {
    //    }
    //    this._lblLyWriter = value;
    //    if (this._lblLyWriter != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblMediaTyp
    //{
    //  get
    //  {
    //    return this._lblMediaTyp;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblMediaTyp != null)
    //    {
    //    }
    //    this._lblMediaTyp = value;
    //    if (this._lblMediaTyp != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblModified
    //{
    //  get
    //  {
    //    return this._lblModified;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblModified != null)
    //    {
    //    }
    //    this._lblModified = value;
    //    if (this._lblModified != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblMusicianInfo
    //{
    //  get
    //  {
    //    return this._lblMusicianInfo;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblMusicianInfo != null)
    //    {
    //    }
    //    this._lblMusicianInfo = value;
    //    if (this._lblMusicianInfo != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblMusicianInst
    //{
    //  get
    //  {
    //    return this._lblMusicianInst;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblMusicianInst != null)
    //    {
    //    }
    //    this._lblMusicianInst = value;
    //    if (this._lblMusicianInst != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblMusicianName
    //{
    //  get
    //  {
    //    return this._lblMusicianName;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblMusicianName != null)
    //    {
    //    }
    //    this._lblMusicianName = value;
    //    if (this._lblMusicianName != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblOAlbum
    //{
    //  get
    //  {
    //    return this._lblOAlbum;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblOAlbum != null)
    //    {
    //    }
    //    this._lblOAlbum = value;
    //    if (this._lblOAlbum != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblOArtist
    //{
    //  get
    //  {
    //    return this._lblOArtist;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblOArtist != null)
    //    {
    //    }
    //    this._lblOArtist = value;
    //    if (this._lblOArtist != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblOf1
    //{
    //  get
    //  {
    //    return this._lblOf1;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblOf1 != null)
    //    {
    //    }
    //    this._lblOf1 = value;
    //    if (this._lblOf1 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblOf2
    //{
    //  get
    //  {
    //    return this._lblOf2;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblOf2 != null)
    //    {
    //    }
    //    this._lblOf2 = value;
    //    if (this._lblOf2 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblOFilename
    //{
    //  get
    //  {
    //    return this._lblOFilename;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblOFilename != null)
    //    {
    //    }
    //    this._lblOFilename = value;
    //    if (this._lblOFilename != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblOLyWriter
    //{
    //  get
    //  {
    //    return this._lblOLyWriter;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblOLyWriter != null)
    //    {
    //    }
    //    this._lblOLyWriter = value;
    //    if (this._lblOLyWriter != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblOOwner
    //{
    //  get
    //  {
    //    return this._lblOOwner;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblOOwner != null)
    //    {
    //    }
    //    this._lblOOwner = value;
    //    if (this._lblOOwner != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblOYear
    //{
    //  get
    //  {
    //    return this._lblOYear;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblOYear != null)
    //    {
    //    }
    //    this._lblOYear = value;
    //    if (this._lblOYear != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblOYearInfo
    //{
    //  get
    //  {
    //    return this._lblOYearInfo;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblOYearInfo != null)
    //    {
    //    }
    //    this._lblOYearInfo = value;
    //    if (this._lblOYearInfo != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblPayURL
    //{
    //  get
    //  {
    //    return this._lblPayURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblPayURL != null)
    //    {
    //    }
    //    this._lblPayURL = value;
    //    if (this._lblPayURL != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblPicDesc
    //{
    //  get
    //  {
    //    return this._lblPicDesc;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblPicDesc != null)
    //    {
    //    }
    //    this._lblPicDesc = value;
    //    if (this._lblPicDesc != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblPicPath
    //{
    //  get
    //  {
    //    return this._lblPicPath;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblPicPath != null)
    //    {
    //    }
    //    this._lblPicPath = value;
    //    if (this._lblPicPath != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblPicType
    //{
    //  get
    //  {
    //    return this._lblPicType;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblPicType != null)
    //    {
    //    }
    //    this._lblPicType = value;
    //    if (this._lblPicType != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblPosMedia
    //{
    //  get
    //  {
    //    return this._lblPosMedia;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblPosMedia != null)
    //    {
    //    }
    //    this._lblPosMedia = value;
    //    if (this._lblPosMedia != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblPublisher
    //{
    //  get
    //  {
    //    return this._lblPublisher;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblPublisher != null)
    //    {
    //    }
    //    this._lblPublisher = value;
    //    if (this._lblPublisher != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblPubURL
    //{
    //  get
    //  {
    //    return this._lblPubURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblPubURL != null)
    //    {
    //    }
    //    this._lblPubURL = value;
    //    if (this._lblPubURL != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblRatingCounter
    //{
    //  get
    //  {
    //    return this._lblRatingCounter;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblRatingCounter != null)
    //    {
    //    }
    //    this._lblRatingCounter = value;
    //    if (this._lblRatingCounter != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblRatingRating
    //{
    //  get
    //  {
    //    return this._lblRatingRating;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblRatingRating != null)
    //    {
    //    }
    //    this._lblRatingRating = value;
    //    if (this._lblRatingRating != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblRatingUser
    //{
    //  get
    //  {
    //    return this._lblRatingUser;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblRatingUser != null)
    //    {
    //    }
    //    this._lblRatingUser = value;
    //    if (this._lblRatingUser != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblSubTitle
    //{
    //  get
    //  {
    //    return this._lblSubTitle;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblSubTitle != null)
    //    {
    //    }
    //    this._lblSubTitle = value;
    //    if (this._lblSubTitle != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblTitle
    //{
    //  get
    //  {
    //    return this._lblTitle;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblTitle != null)
    //    {
    //    }
    //    this._lblTitle = value;
    //    if (this._lblTitle != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblTitleSort
    //{
    //  get
    //  {
    //    return this._lblTitleSort;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblTitleSort != null)
    //    {
    //    }
    //    this._lblTitleSort = value;
    //    if (this._lblTitleSort != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblTLEN
    //{
    //  get
    //  {
    //    return this._lblTLEN;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblTLEN != null)
    //    {
    //    }
    //    this._lblTLEN = value;
    //    if (this._lblTLEN != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblTrack
    //{
    //  get
    //  {
    //    return this._lblTrack;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblTrack != null)
    //    {
    //    }
    //    this._lblTrack = value;
    //    if (this._lblTrack != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblTXXXContent
    //{
    //  get
    //  {
    //    return this._lblTXXXContent;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblTXXXContent != null)
    //    {
    //    }
    //    this._lblTXXXContent = value;
    //    if (this._lblTXXXContent != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblTXXXDesc
    //{
    //  get
    //  {
    //    return this._lblTXXXDesc;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblTXXXDesc != null)
    //    {
    //    }
    //    this._lblTXXXDesc = value;
    //    if (this._lblTXXXDesc != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblWXXXContent
    //{
    //  get
    //  {
    //    return this._lblWXXXContent;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblWXXXContent != null)
    //    {
    //    }
    //    this._lblWXXXContent = value;
    //    if (this._lblWXXXContent != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblWXXXDesc
    //{
    //  get
    //  {
    //    return this._lblWXXXDesc;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblWXXXDesc != null)
    //    {
    //    }
    //    this._lblWXXXDesc = value;
    //    if (this._lblWXXXDesc != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.Label lblYear
    //{
    //  get
    //  {
    //    return this._lblYear;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._lblYear != null)
    //    {
    //    }
    //    this._lblYear = value;
    //    if (this._lblYear != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ListView LyricsList
    //{
    //  get
    //  {
    //    return this._LyricsList;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._LyricsList != null)
    //    {
    //      this._LyricsList.Leave -= new EventHandler(this.Select_Leave);
    //      this._LyricsList.Click -= new EventHandler(this.LyricsList_Click);
    //    }
    //    this._LyricsList = value;
    //    if (this._LyricsList != null)
    //    {
    //      this._LyricsList.Leave += new EventHandler(this.Select_Leave);
    //      this._LyricsList.Click += new EventHandler(this.LyricsList_Click);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.OpenFileDialog OpenFileDialog
    //{
    //  get
    //  {
    //    return this._OpenFileDialog;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._OpenFileDialog != null)
    //    {
    //    }
    //    this._OpenFileDialog = value;
    //    if (this._OpenFileDialog != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel panDetail
    //{
    //  get
    //  {
    //    return this._panDetail;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._panDetail != null)
    //    {
    //    }
    //    this._panDetail = value;
    //    if (this._panDetail != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel1
    //{
    //  get
    //  {
    //    return this._Panel1;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel1 != null)
    //    {
    //    }
    //    this._Panel1 = value;
    //    if (this._Panel1 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel10
    //{
    //  get
    //  {
    //    return this._Panel10;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel10 != null)
    //    {
    //    }
    //    this._Panel10 = value;
    //    if (this._Panel10 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel11
    //{
    //  get
    //  {
    //    return this._Panel11;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel11 != null)
    //    {
    //    }
    //    this._Panel11 = value;
    //    if (this._Panel11 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel12
    //{
    //  get
    //  {
    //    return this._Panel12;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel12 != null)
    //    {
    //    }
    //    this._Panel12 = value;
    //    if (this._Panel12 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel13
    //{
    //  get
    //  {
    //    return this._Panel13;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel13 != null)
    //    {
    //    }
    //    this._Panel13 = value;
    //    if (this._Panel13 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel14
    //{
    //  get
    //  {
    //    return this._Panel14;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel14 != null)
    //    {
    //    }
    //    this._Panel14 = value;
    //    if (this._Panel14 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel15
    //{
    //  get
    //  {
    //    return this._Panel15;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel15 != null)
    //    {
    //    }
    //    this._Panel15 = value;
    //    if (this._Panel15 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel16
    //{
    //  get
    //  {
    //    return this._Panel16;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel16 != null)
    //    {
    //    }
    //    this._Panel16 = value;
    //    if (this._Panel16 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel2
    //{
    //  get
    //  {
    //    return this._Panel2;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel2 != null)
    //    {
    //    }
    //    this._Panel2 = value;
    //    if (this._Panel2 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel3
    //{
    //  get
    //  {
    //    return this._Panel3;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel3 != null)
    //    {
    //    }
    //    this._Panel3 = value;
    //    if (this._Panel3 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel4
    //{
    //  get
    //  {
    //    return this._Panel4;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel4 != null)
    //    {
    //    }
    //    this._Panel4 = value;
    //    if (this._Panel4 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel5
    //{
    //  get
    //  {
    //    return this._Panel5;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel5 != null)
    //    {
    //    }
    //    this._Panel5 = value;
    //    if (this._Panel5 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel6
    //{
    //  get
    //  {
    //    return this._Panel6;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel6 != null)
    //    {
    //    }
    //    this._Panel6 = value;
    //    if (this._Panel6 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel7
    //{
    //  get
    //  {
    //    return this._Panel7;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel7 != null)
    //    {
    //    }
    //    this._Panel7 = value;
    //    if (this._Panel7 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel8
    //{
    //  get
    //  {
    //    return this._Panel8;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel8 != null)
    //    {
    //    }
    //    this._Panel8 = value;
    //    if (this._Panel8 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel Panel9
    //{
    //  get
    //  {
    //    return this._Panel9;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._Panel9 != null)
    //    {
    //    }
    //    this._Panel9 = value;
    //    if (this._Panel9 != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel panInvolved
    //{
    //  get
    //  {
    //    return this._panInvolved;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._panInvolved != null)
    //    {
    //    }
    //    this._panInvolved = value;
    //    if (this._panInvolved != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel panLyrics
    //{
    //  get
    //  {
    //    return this._panLyrics;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._panLyrics != null)
    //    {
    //    }
    //    this._panLyrics = value;
    //    if (this._panLyrics != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel panMain
    //{
    //  get
    //  {
    //    return this._panMain;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._panMain != null)
    //    {
    //    }
    //    this._panMain = value;
    //    if (this._panMain != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel panOriginal
    //{
    //  get
    //  {
    //    return this._panOriginal;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._panOriginal != null)
    //    {
    //    }
    //    this._panOriginal = value;
    //    if (this._panOriginal != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel panPic
    //{
    //  get
    //  {
    //    return this._panPic;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._panPic != null)
    //    {
    //    }
    //    this._panPic = value;
    //    if (this._panPic != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel panRating
    //{
    //  get
    //  {
    //    return this._panRating;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._panRating != null)
    //    {
    //    }
    //    this._panRating = value;
    //    if (this._panRating != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel panUser
    //{
    //  get
    //  {
    //    return this._panUser;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._panUser != null)
    //    {
    //    }
    //    this._panUser = value;
    //    if (this._panUser != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual Panel panWeb
    //{
    //  get
    //  {
    //    return this._panWeb;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._panWeb != null)
    //    {
    //    }
    //    this._panWeb = value;
    //    if (this._panWeb != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ListView PicList
    //{
    //  get
    //  {
    //    return this._PicList;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._PicList != null)
    //    {
    //      this._PicList.Leave -= new EventHandler(this.Select_Leave);
    //      this._PicList.Click -= new EventHandler(this.PicList_Click);
    //    }
    //    this._PicList = value;
    //    if (this._PicList != null)
    //    {
    //      this._PicList.Leave += new EventHandler(this.Select_Leave);
    //      this._PicList.Click += new EventHandler(this.PicList_Click);
    //    }
    //  }
    //}

    //internal virtual ListView RatingList
    //{
    //  get
    //  {
    //    return this._RatingList;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._RatingList != null)
    //    {
    //      this._RatingList.Click -= new EventHandler(this.RatingList_Click);
    //    }
    //    this._RatingList = value;
    //    if (this._RatingList != null)
    //    {
    //      this._RatingList.Click += new EventHandler(this.RatingList_Click);
    //    }
    //  }
    //}

    //internal virtual ExplorerBar SelectionBar
    //{
    //  get
    //  {
    //    return this._SelectionBar;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._SelectionBar != null)
    //    {
    //    }
    //    this._SelectionBar = value;
    //    if (this._SelectionBar != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ButtonItem TAGV2ButtonItem1
    //{
    //  get
    //  {
    //    return this._TAGV2ButtonItem1;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2ButtonItem1 != null)
    //    {
    //      this._TAGV2ButtonItem1.Click -= new EventHandler(this.btnItem_Click);
    //    }
    //    this._TAGV2ButtonItem1 = value;
    //    if (this._TAGV2ButtonItem1 != null)
    //    {
    //      this._TAGV2ButtonItem1.Click += new EventHandler(this.btnItem_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem TAGV2ButtonItem2
    //{
    //  get
    //  {
    //    return this._TAGV2ButtonItem2;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2ButtonItem2 != null)
    //    {
    //      this._TAGV2ButtonItem2.Click -= new EventHandler(this.btnItem_Click);
    //    }
    //    this._TAGV2ButtonItem2 = value;
    //    if (this._TAGV2ButtonItem2 != null)
    //    {
    //      this._TAGV2ButtonItem2.Click += new EventHandler(this.btnItem_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem TAGV2ButtonItem3
    //{
    //  get
    //  {
    //    return this._TAGV2ButtonItem3;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2ButtonItem3 != null)
    //    {
    //      this._TAGV2ButtonItem3.Click -= new EventHandler(this.btnItem_Click);
    //    }
    //    this._TAGV2ButtonItem3 = value;
    //    if (this._TAGV2ButtonItem3 != null)
    //    {
    //      this._TAGV2ButtonItem3.Click += new EventHandler(this.btnItem_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem TAGV2ButtonItem4
    //{
    //  get
    //  {
    //    return this._TAGV2ButtonItem4;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2ButtonItem4 != null)
    //    {
    //      this._TAGV2ButtonItem4.Click -= new EventHandler(this.btnItem_Click);
    //    }
    //    this._TAGV2ButtonItem4 = value;
    //    if (this._TAGV2ButtonItem4 != null)
    //    {
    //      this._TAGV2ButtonItem4.Click += new EventHandler(this.btnItem_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem TAGV2ButtonItem5
    //{
    //  get
    //  {
    //    return this._TAGV2ButtonItem5;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2ButtonItem5 != null)
    //    {
    //      this._TAGV2ButtonItem5.Click -= new EventHandler(this.btnItem_Click);
    //    }
    //    this._TAGV2ButtonItem5 = value;
    //    if (this._TAGV2ButtonItem5 != null)
    //    {
    //      this._TAGV2ButtonItem5.Click += new EventHandler(this.btnItem_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem TAGV2ButtonItem6
    //{
    //  get
    //  {
    //    return this._TAGV2ButtonItem6;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2ButtonItem6 != null)
    //    {
    //      this._TAGV2ButtonItem6.Click -= new EventHandler(this.btnItem_Click);
    //    }
    //    this._TAGV2ButtonItem6 = value;
    //    if (this._TAGV2ButtonItem6 != null)
    //    {
    //      this._TAGV2ButtonItem6.Click += new EventHandler(this.btnItem_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem TAGV2ButtonItem7
    //{
    //  get
    //  {
    //    return this._TAGV2ButtonItem7;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2ButtonItem7 != null)
    //    {
    //      this._TAGV2ButtonItem7.Click -= new EventHandler(this.btnItem_Click);
    //    }
    //    this._TAGV2ButtonItem7 = value;
    //    if (this._TAGV2ButtonItem7 != null)
    //    {
    //      this._TAGV2ButtonItem7.Click += new EventHandler(this.btnItem_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem TAGV2ButtonItem8
    //{
    //  get
    //  {
    //    return this._TAGV2ButtonItem8;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2ButtonItem8 != null)
    //    {
    //      this._TAGV2ButtonItem8.Click -= new EventHandler(this.btnItem_Click);
    //    }
    //    this._TAGV2ButtonItem8 = value;
    //    if (this._TAGV2ButtonItem8 != null)
    //    {
    //      this._TAGV2ButtonItem8.Click += new EventHandler(this.btnItem_Click);
    //    }
    //  }
    //}

    //internal virtual ButtonItem TAGV2ButtonItem9
    //{
    //  get
    //  {
    //    return this._TAGV2ButtonItem9;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2ButtonItem9 != null)
    //    {
    //      this._TAGV2ButtonItem9.Click -= new EventHandler(this.btnItem_Click);
    //    }
    //    this._TAGV2ButtonItem9 = value;
    //    if (this._TAGV2ButtonItem9 != null)
    //    {
    //      this._TAGV2ButtonItem9.Click += new EventHandler(this.btnItem_Click);
    //    }
    //  }
    //}

    //internal virtual ExplorerBarGroupItem TAGV2grpCommands
    //{
    //  get
    //  {
    //    return this._TAGV2grpCommands;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2grpCommands != null)
    //    {
    //    }
    //    this._TAGV2grpCommands = value;
    //    if (this._TAGV2grpCommands != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ExplorerBarGroupItem TAGV2grpTAG
    //{
    //  get
    //  {
    //    return this._TAGV2grpTAG;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TAGV2grpTAG != null)
    //    {
    //    }
    //    this._TAGV2grpTAG = value;
    //    if (this._TAGV2grpTAG != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual ListView TIPLList
    //{
    //  get
    //  {
    //    return this._TIPLList;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TIPLList != null)
    //    {
    //      this._TIPLList.Click -= new EventHandler(this.TIPLList_Click);
    //    }
    //    this._TIPLList = value;
    //    if (this._TIPLList != null)
    //    {
    //      this._TIPLList.Click += new EventHandler(this.TIPLList_Click);
    //    }
    //  }
    //}

    //internal virtual ListView TMCLList
    //{
    //  get
    //  {
    //    return this._TMCLList;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TMCLList != null)
    //    {
    //      this._TMCLList.Click -= new EventHandler(this.TMCLList_Click);
    //    }
    //    this._TMCLList = value;
    //    if (this._TMCLList != null)
    //    {
    //      this._TMCLList.Click += new EventHandler(this.TMCLList_Click);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.ToolTip ToolTip
    //{
    //  get
    //  {
    //    return this._ToolTip;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._ToolTip != null)
    //    {
    //    }
    //    this._ToolTip = value;
    //    if (this._ToolTip != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual PanelEx TopPanel
    //{
    //  get
    //  {
    //    return this._TopPanel;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TopPanel != null)
    //    {
    //    }
    //    this._TopPanel = value;
    //    if (this._TopPanel != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual HScrollBar TORYFormat
    //{
    //  get
    //  {
    //    return this._TORYFormat;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TORYFormat != null)
    //    {
    //      this._TORYFormat.Scroll -= new ScrollEventHandler(this.TORYFormat_Scroll);
    //    }
    //    this._TORYFormat = value;
    //    if (this._TORYFormat != null)
    //    {
    //      this._TORYFormat.Scroll += new ScrollEventHandler(this.TORYFormat_Scroll);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtAlbum
    //{
    //  get
    //  {
    //    return this._txtAlbum;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtAlbum != null)
    //    {
    //      this._txtAlbum.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtAlbum.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtAlbum.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtAlbum = value;
    //    if (this._txtAlbum != null)
    //    {
    //      this._txtAlbum.Leave += new EventHandler(this.Select_Leave);
    //      this._txtAlbum.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtAlbum.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtArtistURL
    //{
    //  get
    //  {
    //    return this._txtArtistURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtArtistURL != null)
    //    {
    //      this._txtArtistURL.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtArtistURL.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtArtistURL.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtArtistURL = value;
    //    if (this._txtArtistURL != null)
    //    {
    //      this._txtArtistURL.Leave += new EventHandler(this.Select_Leave);
    //      this._txtArtistURL.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtArtistURL.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtAudioFileURL
    //{
    //  get
    //  {
    //    return this._txtAudioFileURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtAudioFileURL != null)
    //    {
    //      this._txtAudioFileURL.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtAudioFileURL.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtAudioFileURL.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtAudioFileURL = value;
    //    if (this._txtAudioFileURL != null)
    //    {
    //      this._txtAudioFileURL.Leave += new EventHandler(this.Select_Leave);
    //      this._txtAudioFileURL.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtAudioFileURL.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtAudioSRCURL
    //{
    //  get
    //  {
    //    return this._txtAudioSRCURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtAudioSRCURL != null)
    //    {
    //      this._txtAudioSRCURL.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtAudioSRCURL.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtAudioSRCURL.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtAudioSRCURL = value;
    //    if (this._txtAudioSRCURL != null)
    //    {
    //      this._txtAudioSRCURL.Leave += new EventHandler(this.Select_Leave);
    //      this._txtAudioSRCURL.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtAudioSRCURL.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtBand
    //{
    //  get
    //  {
    //    return this._txtBand;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtBand != null)
    //    {
    //      this._txtBand.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtBand.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtBand.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtBand = value;
    //    if (this._txtBand != null)
    //    {
    //      this._txtBand.Leave += new EventHandler(this.Select_Leave);
    //      this._txtBand.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtBand.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual NumericTextBox txtBPM
    //{
    //  get
    //  {
    //    return this._txtBPM;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtBPM != null)
    //    {
    //      this._txtBPM.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtBPM.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtBPM.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtBPM = value;
    //    if (this._txtBPM != null)
    //    {
    //      this._txtBPM.Leave += new EventHandler(this.Select_Leave);
    //      this._txtBPM.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtBPM.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtComment
    //{
    //  get
    //  {
    //    return this._txtComment;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtComment != null)
    //    {
    //      this._txtComment.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtComment.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtComment.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtComment = value;
    //    if (this._txtComment != null)
    //    {
    //      this._txtComment.Leave += new EventHandler(this.Select_Leave);
    //      this._txtComment.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtComment.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtCOMMInfURL
    //{
    //  get
    //  {
    //    return this._txtCOMMInfURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtCOMMInfURL != null)
    //    {
    //      this._txtCOMMInfURL.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtCOMMInfURL.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtCOMMInfURL.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtCOMMInfURL = value;
    //    if (this._txtCOMMInfURL != null)
    //    {
    //      this._txtCOMMInfURL.Leave += new EventHandler(this.Select_Leave);
    //      this._txtCOMMInfURL.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtCOMMInfURL.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtComposer
    //{
    //  get
    //  {
    //    return this._txtComposer;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtComposer != null)
    //    {
    //      this._txtComposer.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtComposer.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtComposer.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtComposer = value;
    //    if (this._txtComposer != null)
    //    {
    //      this._txtComposer.Leave += new EventHandler(this.Select_Leave);
    //      this._txtComposer.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtComposer.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtConductor
    //{
    //  get
    //  {
    //    return this._txtConductor;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtConductor != null)
    //    {
    //      this._txtConductor.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtConductor.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtConductor.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtConductor = value;
    //    if (this._txtConductor != null)
    //    {
    //      this._txtConductor.Leave += new EventHandler(this.Select_Leave);
    //      this._txtConductor.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtConductor.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtContent
    //{
    //  get
    //  {
    //    return this._txtContent;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtContent != null)
    //    {
    //      this._txtContent.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtContent.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtContent.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtContent = value;
    //    if (this._txtContent != null)
    //    {
    //      this._txtContent.Leave += new EventHandler(this.Select_Leave);
    //      this._txtContent.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtContent.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtCopyInfURL
    //{
    //  get
    //  {
    //    return this._txtCopyInfURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtCopyInfURL != null)
    //    {
    //      this._txtCopyInfURL.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtCopyInfURL.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtCopyInfURL.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtCopyInfURL = value;
    //    if (this._txtCopyInfURL != null)
    //    {
    //      this._txtCopyInfURL.Leave += new EventHandler(this.Select_Leave);
    //      this._txtCopyInfURL.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtCopyInfURL.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtCopyright
    //{
    //  get
    //  {
    //    return this._txtCopyright;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtCopyright != null)
    //    {
    //      this._txtCopyright.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtCopyright.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtCopyright.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtCopyright = value;
    //    if (this._txtCopyright != null)
    //    {
    //      this._txtCopyright.Leave += new EventHandler(this.Select_Leave);
    //      this._txtCopyright.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtCopyright.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual NumericUpDown txtDigits
    //{
    //  get
    //  {
    //    return this._txtDigits;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtDigits != null)
    //    {
    //    }
    //    this._txtDigits = value;
    //    if (this._txtDigits != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtEncoded
    //{
    //  get
    //  {
    //    return this._txtEncoded;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtEncoded != null)
    //    {
    //      this._txtEncoded.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtEncoded.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtEncoded.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtEncoded = value;
    //    if (this._txtEncoded != null)
    //    {
    //      this._txtEncoded.Leave += new EventHandler(this.Select_Leave);
    //      this._txtEncoded.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtEncoded.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtINetRadioURL
    //{
    //  get
    //  {
    //    return this._txtINetRadioURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtINetRadioURL != null)
    //    {
    //      this._txtINetRadioURL.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtINetRadioURL.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtINetRadioURL.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtINetRadioURL = value;
    //    if (this._txtINetRadioURL != null)
    //    {
    //      this._txtINetRadioURL.Leave += new EventHandler(this.Select_Leave);
    //      this._txtINetRadioURL.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtINetRadioURL.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtInvFunction
    //{
    //  get
    //  {
    //    return this._txtInvFunction;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtInvFunction != null)
    //    {
    //      this._txtInvFunction.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtInvFunction.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtInvFunction = value;
    //    if (this._txtInvFunction != null)
    //    {
    //      this._txtInvFunction.Leave += new EventHandler(this.Select_Leave);
    //      this._txtInvFunction.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtInvPerson
    //{
    //  get
    //  {
    //    return this._txtInvPerson;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtInvPerson != null)
    //    {
    //      this._txtInvPerson.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtInvPerson.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtInvPerson = value;
    //    if (this._txtInvPerson != null)
    //    {
    //      this._txtInvPerson.Leave += new EventHandler(this.Select_Leave);
    //      this._txtInvPerson.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtLDescriptor
    //{
    //  get
    //  {
    //    return this._txtLDescriptor;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtLDescriptor != null)
    //    {
    //      this._txtLDescriptor.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtLDescriptor.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtLDescriptor.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtLDescriptor = value;
    //    if (this._txtLDescriptor != null)
    //    {
    //      this._txtLDescriptor.Leave += new EventHandler(this.Select_Leave);
    //      this._txtLDescriptor.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtLDescriptor.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual RichTextBox txtLyrics
    //{
    //  get
    //  {
    //    return this._txtLyrics;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtLyrics != null)
    //    {
    //    }
    //    this._txtLyrics = value;
    //    if (this._txtLyrics != null)
    //    {
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtLyWriter
    //{
    //  get
    //  {
    //    return this._txtLyWriter;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtLyWriter != null)
    //    {
    //      this._txtLyWriter.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtLyWriter.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtLyWriter.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtLyWriter = value;
    //    if (this._txtLyWriter != null)
    //    {
    //      this._txtLyWriter.Leave += new EventHandler(this.Select_Leave);
    //      this._txtLyWriter.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtLyWriter.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtModified
    //{
    //  get
    //  {
    //    return this._txtModified;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtModified != null)
    //    {
    //      this._txtModified.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtModified.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtModified.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtModified = value;
    //    if (this._txtModified != null)
    //    {
    //      this._txtModified.Leave += new EventHandler(this.Select_Leave);
    //      this._txtModified.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtModified.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtMusicianInst
    //{
    //  get
    //  {
    //    return this._txtMusicianInst;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtMusicianInst != null)
    //    {
    //      this._txtMusicianInst.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtMusicianInst.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtMusicianInst = value;
    //    if (this._txtMusicianInst != null)
    //    {
    //      this._txtMusicianInst.Leave += new EventHandler(this.Select_Leave);
    //      this._txtMusicianInst.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtMusicianName
    //{
    //  get
    //  {
    //    return this._txtMusicianName;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtMusicianName != null)
    //    {
    //      this._txtMusicianName.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtMusicianName.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtMusicianName = value;
    //    if (this._txtMusicianName != null)
    //    {
    //      this._txtMusicianName.Leave += new EventHandler(this.Select_Leave);
    //      this._txtMusicianName.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtOAlbum
    //{
    //  get
    //  {
    //    return this._txtOAlbum;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtOAlbum != null)
    //    {
    //      this._txtOAlbum.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtOAlbum.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtOAlbum.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtOAlbum = value;
    //    if (this._txtOAlbum != null)
    //    {
    //      this._txtOAlbum.Leave += new EventHandler(this.Select_Leave);
    //      this._txtOAlbum.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtOAlbum.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtOArtist
    //{
    //  get
    //  {
    //    return this._txtOArtist;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtOArtist != null)
    //    {
    //      this._txtOArtist.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtOArtist.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtOArtist.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtOArtist = value;
    //    if (this._txtOArtist != null)
    //    {
    //      this._txtOArtist.Leave += new EventHandler(this.Select_Leave);
    //      this._txtOArtist.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtOArtist.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtOFilename
    //{
    //  get
    //  {
    //    return this._txtOFilename;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtOFilename != null)
    //    {
    //      this._txtOFilename.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtOFilename.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtOFilename.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtOFilename = value;
    //    if (this._txtOFilename != null)
    //    {
    //      this._txtOFilename.Leave += new EventHandler(this.Select_Leave);
    //      this._txtOFilename.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtOFilename.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtOLyWriter
    //{
    //  get
    //  {
    //    return this._txtOLyWriter;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtOLyWriter != null)
    //    {
    //      this._txtOLyWriter.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtOLyWriter.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtOLyWriter.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtOLyWriter = value;
    //    if (this._txtOLyWriter != null)
    //    {
    //      this._txtOLyWriter.Leave += new EventHandler(this.Select_Leave);
    //      this._txtOLyWriter.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtOLyWriter.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtOOwner
    //{
    //  get
    //  {
    //    return this._txtOOwner;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtOOwner != null)
    //    {
    //      this._txtOOwner.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtOOwner.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtOOwner.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtOOwner = value;
    //    if (this._txtOOwner != null)
    //    {
    //      this._txtOOwner.Leave += new EventHandler(this.Select_Leave);
    //      this._txtOOwner.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtOOwner.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtPayURL
    //{
    //  get
    //  {
    //    return this._txtPayURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtPayURL != null)
    //    {
    //      this._txtPayURL.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtPayURL.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtPayURL.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtPayURL = value;
    //    if (this._txtPayURL != null)
    //    {
    //      this._txtPayURL.Leave += new EventHandler(this.Select_Leave);
    //      this._txtPayURL.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtPayURL.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtPDescriptor
    //{
    //  get
    //  {
    //    return this._txtPDescriptor;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtPDescriptor != null)
    //    {
    //      this._txtPDescriptor.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtPDescriptor.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtPDescriptor.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtPDescriptor = value;
    //    if (this._txtPDescriptor != null)
    //    {
    //      this._txtPDescriptor.Leave += new EventHandler(this.Select_Leave);
    //      this._txtPDescriptor.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtPDescriptor.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtPicPath
    //{
    //  get
    //  {
    //    return this._txtPicPath;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtPicPath != null)
    //    {
    //      this._txtPicPath.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtPicPath.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtPicPath.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtPicPath = value;
    //    if (this._txtPicPath != null)
    //    {
    //      this._txtPicPath.Leave += new EventHandler(this.Select_Leave);
    //      this._txtPicPath.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtPicPath.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual IntegerTextBox txtPOS1
    //{
    //  get
    //  {
    //    return this._txtPOS1;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtPOS1 != null)
    //    {
    //      this._txtPOS1.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtPOS1.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtPOS1.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtPOS1 = value;
    //    if (this._txtPOS1 != null)
    //    {
    //      this._txtPOS1.Leave += new EventHandler(this.Select_Leave);
    //      this._txtPOS1.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtPOS1.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual IntegerTextBox txtPOS2
    //{
    //  get
    //  {
    //    return this._txtPOS2;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtPOS2 != null)
    //    {
    //      this._txtPOS2.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtPOS2.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtPOS2.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtPOS2 = value;
    //    if (this._txtPOS2 != null)
    //    {
    //      this._txtPOS2.Leave += new EventHandler(this.Select_Leave);
    //      this._txtPOS2.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtPOS2.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtPublisher
    //{
    //  get
    //  {
    //    return this._txtPublisher;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtPublisher != null)
    //    {
    //      this._txtPublisher.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtPublisher.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtPublisher.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtPublisher = value;
    //    if (this._txtPublisher != null)
    //    {
    //      this._txtPublisher.Leave += new EventHandler(this.Select_Leave);
    //      this._txtPublisher.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtPublisher.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtPubURL
    //{
    //  get
    //  {
    //    return this._txtPubURL;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtPubURL != null)
    //    {
    //      this._txtPubURL.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtPubURL.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtPubURL.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtPubURL = value;
    //    if (this._txtPubURL != null)
    //    {
    //      this._txtPubURL.Leave += new EventHandler(this.Select_Leave);
    //      this._txtPubURL.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtPubURL.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual NumericUpDown txtRatingCounter
    //{
    //  get
    //  {
    //    return this._txtRatingCounter;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtRatingCounter != null)
    //    {
    //      this._txtRatingCounter.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtRatingCounter.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtRatingCounter.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtRatingCounter = value;
    //    if (this._txtRatingCounter != null)
    //    {
    //      this._txtRatingCounter.Leave += new EventHandler(this.Select_Leave);
    //      this._txtRatingCounter.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtRatingCounter.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual NumericUpDown txtRatingRating
    //{
    //  get
    //  {
    //    return this._txtRatingRating;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtRatingRating != null)
    //    {
    //      this._txtRatingRating.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtRatingRating.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtRatingRating.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtRatingRating = value;
    //    if (this._txtRatingRating != null)
    //    {
    //      this._txtRatingRating.Leave += new EventHandler(this.Select_Leave);
    //      this._txtRatingRating.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtRatingRating.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtRatingUser
    //{
    //  get
    //  {
    //    return this._txtRatingUser;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtRatingUser != null)
    //    {
    //      this._txtRatingUser.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtRatingUser.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtRatingUser.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtRatingUser = value;
    //    if (this._txtRatingUser != null)
    //    {
    //      this._txtRatingUser.Leave += new EventHandler(this.Select_Leave);
    //      this._txtRatingUser.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtRatingUser.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtSortAlbum
    //{
    //  get
    //  {
    //    return this._txtSortAlbum;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtSortAlbum != null)
    //    {
    //      this._txtSortAlbum.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtSortAlbum.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtSortAlbum.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtSortAlbum = value;
    //    if (this._txtSortAlbum != null)
    //    {
    //      this._txtSortAlbum.Leave += new EventHandler(this.Select_Leave);
    //      this._txtSortAlbum.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtSortAlbum.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtSortArtist
    //{
    //  get
    //  {
    //    return this._txtSortArtist;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtSortArtist != null)
    //    {
    //      this._txtSortArtist.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtSortArtist.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtSortArtist.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtSortArtist = value;
    //    if (this._txtSortArtist != null)
    //    {
    //      this._txtSortArtist.Leave += new EventHandler(this.Select_Leave);
    //      this._txtSortArtist.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtSortArtist.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtSortTitle
    //{
    //  get
    //  {
    //    return this._txtSortTitle;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtSortTitle != null)
    //    {
    //      this._txtSortTitle.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtSortTitle.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtSortTitle.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtSortTitle = value;
    //    if (this._txtSortTitle != null)
    //    {
    //      this._txtSortTitle.Leave += new EventHandler(this.Select_Leave);
    //      this._txtSortTitle.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtSortTitle.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtSubTitle
    //{
    //  get
    //  {
    //    return this._txtSubTitle;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtSubTitle != null)
    //    {
    //      this._txtSubTitle.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtSubTitle.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtSubTitle.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtSubTitle = value;
    //    if (this._txtSubTitle != null)
    //    {
    //      this._txtSubTitle.Leave += new EventHandler(this.Select_Leave);
    //      this._txtSubTitle.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtSubTitle.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtTitle
    //{
    //  get
    //  {
    //    return this._txtTitle;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtTitle != null)
    //    {
    //      this._txtTitle.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtTitle.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtTitle.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtTitle = value;
    //    if (this._txtTitle != null)
    //    {
    //      this._txtTitle.Leave += new EventHandler(this.Select_Leave);
    //      this._txtTitle.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtTitle.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual AMS.TextBox.MaskedTextBox txtTORY
    //{
    //  get
    //  {
    //    return this._txtTORY;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtTORY != null)
    //    {
    //      this._txtTORY.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtTORY.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtTORY.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtTORY = value;
    //    if (this._txtTORY != null)
    //    {
    //      this._txtTORY.Leave += new EventHandler(this.Select_Leave);
    //      this._txtTORY.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtTORY.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual IntegerTextBox txtTrack1
    //{
    //  get
    //  {
    //    return this._txtTrack1;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtTrack1 != null)
    //    {
    //      this._txtTrack1.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtTrack1.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtTrack1.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtTrack1 = value;
    //    if (this._txtTrack1 != null)
    //    {
    //      this._txtTrack1.Leave += new EventHandler(this.Select_Leave);
    //      this._txtTrack1.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtTrack1.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual IntegerTextBox txtTrack2
    //{
    //  get
    //  {
    //    return this._txtTrack2;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtTrack2 != null)
    //    {
    //      this._txtTrack2.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtTrack2.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtTrack2.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtTrack2 = value;
    //    if (this._txtTrack2 != null)
    //    {
    //      this._txtTrack2.Leave += new EventHandler(this.Select_Leave);
    //      this._txtTrack2.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtTrack2.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtTXXXContent
    //{
    //  get
    //  {
    //    return this._txtTXXXContent;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtTXXXContent != null)
    //    {
    //      this._txtTXXXContent.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtTXXXContent.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtTXXXContent.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtTXXXContent = value;
    //    if (this._txtTXXXContent != null)
    //    {
    //      this._txtTXXXContent.Leave += new EventHandler(this.Select_Leave);
    //      this._txtTXXXContent.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtTXXXContent.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtTXXXDesc
    //{
    //  get
    //  {
    //    return this._txtTXXXDesc;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtTXXXDesc != null)
    //    {
    //      this._txtTXXXDesc.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtTXXXDesc.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtTXXXDesc.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtTXXXDesc = value;
    //    if (this._txtTXXXDesc != null)
    //    {
    //      this._txtTXXXDesc.Leave += new EventHandler(this.Select_Leave);
    //      this._txtTXXXDesc.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtTXXXDesc.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtWXXXContent
    //{
    //  get
    //  {
    //    return this._txtWXXXContent;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtWXXXContent != null)
    //    {
    //      this._txtWXXXContent.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtWXXXContent.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtWXXXContent.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtWXXXContent = value;
    //    if (this._txtWXXXContent != null)
    //    {
    //      this._txtWXXXContent.Leave += new EventHandler(this.Select_Leave);
    //      this._txtWXXXContent.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtWXXXContent.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual System.Windows.Forms.TextBox txtWXXXDesc
    //{
    //  get
    //  {
    //    return this._txtWXXXDesc;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtWXXXDesc != null)
    //    {
    //      this._txtWXXXDesc.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtWXXXDesc.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtWXXXDesc.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtWXXXDesc = value;
    //    if (this._txtWXXXDesc != null)
    //    {
    //      this._txtWXXXDesc.Leave += new EventHandler(this.Select_Leave);
    //      this._txtWXXXDesc.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtWXXXDesc.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual AMS.TextBox.MaskedTextBox txtYear
    //{
    //  get
    //  {
    //    return this._txtYear;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._txtYear != null)
    //    {
    //      this._txtYear.Leave -= new EventHandler(this.Select_Leave);
    //      this._txtYear.TextChanged -= new EventHandler(this.Select_TextChanged);
    //      this._txtYear.Enter -= new EventHandler(this.Select_Enter);
    //    }
    //    this._txtYear = value;
    //    if (this._txtYear != null)
    //    {
    //      this._txtYear.Leave += new EventHandler(this.Select_Leave);
    //      this._txtYear.TextChanged += new EventHandler(this.Select_TextChanged);
    //      this._txtYear.Enter += new EventHandler(this.Select_Enter);
    //    }
    //  }
    //}

    //internal virtual ListView TXXXList
    //{
    //  get
    //  {
    //    return this._TXXXList;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._TXXXList != null)
    //    {
    //      this._TXXXList.Leave -= new EventHandler(this.Select_Leave);
    //      this._TXXXList.Click -= new EventHandler(this.TXXXList_Click);
    //    }
    //    this._TXXXList = value;
    //    if (this._TXXXList != null)
    //    {
    //      this._TXXXList.Leave += new EventHandler(this.Select_Leave);
    //      this._TXXXList.Click += new EventHandler(this.TXXXList_Click);
    //    }
    //  }
    //}

    //internal virtual ListView WXXXList
    //{
    //  get
    //  {
    //    return this._WXXXList;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._WXXXList != null)
    //    {
    //      this._WXXXList.Leave -= new EventHandler(this.Select_Leave);
    //      this._WXXXList.Click -= new EventHandler(this.WXXXList_Click);
    //    }
    //    this._WXXXList = value;
    //    if (this._WXXXList != null)
    //    {
    //      this._WXXXList.Leave += new EventHandler(this.Select_Leave);
    //      this._WXXXList.Click += new EventHandler(this.WXXXList_Click);
    //    }
    //  }
    //}

    //internal virtual HScrollBar YearFormat
    //{
    //  get
    //  {
    //    return this._YearFormat;
    //  }
    //  [MethodImpl(MethodImplOptions.Synchronized)]
    //  set
    //  {
    //    if (this._YearFormat != null)
    //    {
    //      this._YearFormat.Scroll -= new ScrollEventHandler(this.YearFormat_Scroll);
    //    }
    //    this._YearFormat = value;
    //    if (this._YearFormat != null)
    //    {
    //      this._YearFormat.Scroll += new ScrollEventHandler(this.YearFormat_Scroll);
    //    }
    //  }
    //}
  }
}