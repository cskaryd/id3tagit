using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Threading;
using System.Windows.Forms;

namespace ID3_TagIT
{
  partial class frmMain
  {
    #region Windows Form Designer generated code

    /// <summary>
    /// Required designer variable.
    /// </summary>
    private System.ComponentModel.IContainer components = null;

    private SplitContainer spltTop;
    private SplitContainer spltQuickInfo;
    private ArrayList alstCopyPaste;
    private ErrorProvider errorProvider1;
    private ImageList ColumnHeaderIcons;
    private ImageList GroupIcons;
    private ImageList ToolsIcons;
    private Label EnumInfo;
    private MemoryStream PicMStream;
    private MenuStrip mnuBtns;
    private MenuStrip mnuDDs;
    private MenuStrip mnuExtended;
    private FolderBrowserDialog FolderBrowserDialog;
    private System.Windows.Forms.Timer FolderRenameTimer;
    private System.Windows.Forms.Timer Timer;
    private Thread CalcAudioCheckSumThread;
    private Thread GetFilesTimeThread;
    private ToolStripComboBox cboLanguage;
    private ToolStripMenuItem aboutToolStripMenuItem;
    private ToolStripMenuItem addDirectoryToolStripMenuItem;
    private ToolStripMenuItem analyseToolStripMenuItem;
    private ToolStripMenuItem artistAlbumToolStripMenuItem1;
    private ToolStripMenuItem artistAlbumToolStripMenuItem;
    private ToolStripMenuItem artistTitleToolStripMenuItem1;
    private ToolStripMenuItem artistTitleToolStripMenuItem;
    private ToolStripMenuItem btnAddFolder;
    private ToolStripMenuItem btnEditV1;
    private ToolStripMenuItem btnEditV2;
    private ToolStripMenuItem btnFileToTagV1;
    private ToolStripMenuItem btnFileToTagV2;
    private ToolStripMenuItem btnMultiEditV1;
    private ToolStripMenuItem btnMultiEditV2;
    private ToolStripMenuItem btnPlay;
    private ToolStripMenuItem btnRedo;
    private ToolStripMenuItem btnRefresh;
    private ToolStripMenuItem btnRemoveV1;
    private ToolStripMenuItem btnRemoveV2;
    private ToolStripMenuItem btnSave;
    private ToolStripMenuItem btnSwitchV1V2;
    private ToolStripMenuItem btnTagToFileV1;
    private ToolStripMenuItem btnTagToFileV2;
    private ToolStripMenuItem btnUndo;
    private ToolStripMenuItem caseConversionToolStripMenuItem;
    private ToolStripMenuItem changeTAGVer2TextencodingToolStripMenuItem;
    private ToolStripMenuItem compareFilenameWthTAGInformationToolStripMenuItem;
    private ToolStripMenuItem copyFilesToolStripMenuItem;
    private ToolStripMenuItem copyTAGInformationToolStripMenuItem;
    private ToolStripMenuItem copyTAGVer1And2ToolStripMenuItem;
    private ToolStripMenuItem copyTAGVer1OnlyToolStripMenuItem;
    private ToolStripMenuItem copyTAGVer2OnlyToolStripMenuItem;
    private ToolStripMenuItem createFilelistPlaylistToolStripMenuItem;
    private ToolStripMenuItem deleteFilesToolStripMenuItem;
    private ToolStripMenuItem editLibrariesToolStripMenuItem;
    private ToolStripMenuItem editTAGVer1ToolStripMenuItem;
    private ToolStripMenuItem editTAGVer2ToolStripMenuItem;
    private ToolStripMenuItem editToolStripMenuItem;
    private ToolStripMenuItem enumerateInTAGVer1ToolStripMenuItem;
    private ToolStripMenuItem enumerateInTAGVer2ToolStripMenuItem;
    private ToolStripMenuItem enumerateInfilenameToolStripMenuItem;
    private ToolStripMenuItem extendedFunctionsToolStripMenuItem;
    private ToolStripMenuItem filePropertiesToolStripMenuItem;
    private ToolStripMenuItem fileToolStripMenuItem;
    private ToolStripMenuItem filenameTAGVer1ToolStripMenuItem;
    private ToolStripMenuItem findduplicateFilesToolStripMenuItem;
    private ToolStripMenuItem groupSelectionToolStripMenuItem;
    private ToolStripMenuItem helpToolStripMenuItem1;
    private ToolStripMenuItem helpToolStripMenuItem;
    private ToolStripMenuItem iD3FunctionsToolStripMenuItem;
    private ToolStripMenuItem invertSelectionToolStripMenuItem;
    private ToolStripMenuItem moveFilesToolStripMenuItem;
    private ToolStripMenuItem multipleEditTAGVer1ToolStripMenuItem;
    private ToolStripMenuItem multipleEditTAGVer2ToolStripMenuItem;
    private ToolStripMenuItem openFileLocationToolStripMenuItem;
    private ToolStripMenuItem optionsToolStripMenuItem;
    private ToolStripMenuItem organizeFilesToolStripMenuItem;
    private ToolStripMenuItem pasteTAGInformationToolStripMenuItem;
    private ToolStripMenuItem playToolStripMenuItem;
    private ToolStripMenuItem preferencesToolStripMenuItem;
    private ToolStripMenuItem queryFreeDBToolStripMenuItem;
    private ToolStripMenuItem quickFilenameEditingToolStripMenuItem;
    private ToolStripMenuItem quitToolStripMenuItem;
    private ToolStripMenuItem redoToolStripMenuItem;
    private ToolStripMenuItem refreshToolStripMenuItem;
    private ToolStripMenuItem removeEmptyFoldersToolStripMenuItem;
    private ToolStripMenuItem removeSelectedFilesFromListToolStripMenuItem;
    private ToolStripMenuItem removeTAGVer1ToolStripMenuItem1;
    private ToolStripMenuItem filenameToTagV2;
    private ToolStripMenuItem removeTAGVer1ToolStripMenuItem;
    private ToolStripMenuItem renameFilefolderToolStripMenuItem;
    private ToolStripMenuItem saveToolStripMenuItem;
    private ToolStripMenuItem scanSubdirectoriesToolStripMenuItem;
    private ToolStripMenuItem searchandReplaceToolStripMenuItem;
    private ToolStripMenuItem selectChangedFilesToolStripMenuItem;
    private ToolStripMenuItem selectDuplicateFilesToolStripMenuItem;
    private ToolStripMenuItem selectFilesByformatToolStripMenuItem;
    private ToolStripMenuItem selectallToolStripMenuItem;
    private ToolStripMenuItem selectmismatchingFilenameTAGFilesToolStripMenuItem;
    private ToolStripMenuItem shortcutsToolStripMenuItem;
    private ToolStripMenuItem splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem;
    private ToolStripMenuItem splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem;
    private ToolStripMenuItem swapTAGVer1EntriesToolStripMenuItem;
    private ToolStripMenuItem swapTAGVer2EntriesToolStripMenuItem;
    private ToolStripMenuItem synchronizeVer1AndVer2EditingToolStripMenuItem;
    private ToolStripMenuItem tAGVer1FilenameToolStripMenuItem;
    private ToolStripMenuItem tAGVer2FilenameToolStripMenuItem;
    private ToolStripMenuItem titleAlbumToolStripMenuItem1;
    private ToolStripMenuItem titleAlbumToolStripMenuItem;
    private ToolStripMenuItem transferConvertTAGsToolStripMenuItem;
    private ToolStripMenuItem undoToolStripMenuItem;
    private ToolStripMenuItem viewTAGVer1ToolStripMenuItem;
    private ToolStripMenuItem viewTAGVer2ToolStripMenuItem;
    private ToolStripMenuItem viewToolStripMenuItem;
    private ToolStripSeparator sepButtons1;
    private ToolStripSeparator sepButtons2;
    private ToolStripSeparator sepButtons3;
    private ToolStripSeparator sepButtons4;
    private ToolStripSeparator sepButtons5;
    private ToolStripSeparator sepButtons6;
    private ToolStripSeparator sepButtons7;
    private ToolStripSeparator sepButtons8;
    private ToolStripSeparator sepButtons9;
    private ToolStripSeparator toolStripSeparator10;
    private ToolStripSeparator toolStripSeparator11;
    private ToolStripSeparator toolStripSeparator12;
    private ToolStripSeparator toolStripSeparator13;
    private ToolStripSeparator toolStripSeparator14;
    private ToolStripSeparator toolStripSeparator15;
    private ToolStripSeparator toolStripSeparator16;
    private ToolStripSeparator toolStripSeparator17;
    private ToolStripSeparator toolStripSeparator18;
    private ToolStripSeparator toolStripSeparator19;
    private ToolStripSeparator toolStripSeparator1;
    private ToolStripSeparator toolStripSeparator20;
    private ToolStripSeparator toolStripSeparator21;
    private ToolStripSeparator toolStripSeparator2;
    private ToolStripSeparator toolStripSeparator3;
    private ToolStripSeparator toolStripSeparator4;
    private ToolStripSeparator toolStripSeparator5;
    private ToolStripSeparator toolStripSeparator6;
    private ToolStripSeparator toolStripSeparator7;
    private ToolStripSeparator toolStripSeparator8;
    private ToolStripSeparator toolStripSeparator9;
    private bool vbooClosing;
    private bool vbooFolderRename;
    private bool vbooRefreshFlag;
    private bool vbooStartUp;
    private byte vbytFilterIndex;
    private byte vbytFolderRenameCount;
    private byte vbytSelTimerCount;
    private int vintEnumCount;
    private int vintHelpCount;
    private int vintSelTimerCount;
    private int[] aintLastSelected;
    private string vstrFilter;
    private string vstrFolderRenameNewPath;
    private string vstrFolderRenameOldPath;
    public ColumnHeader colHAlbum;
    public ColumnHeader colHArtist;
    public ColumnHeader colHAudioCheckSum;
    public ColumnHeader colHBPM;
    public ColumnHeader colHBitrate;
    public ColumnHeader colHChannel;
    public ColumnHeader colHComment;
    public ColumnHeader colHComposer;
    public ColumnHeader colHCreateDate;
    public ColumnHeader colHDate;
    public ColumnHeader colHDuration;
    public ColumnHeader colHErrFile;
    public ColumnHeader colHErrMsg;
    public ColumnHeader colHFileSize;
    public ColumnHeader colHFilename;
    public ColumnHeader colHGenre;
    public ColumnHeader colHPicCount;
    public ColumnHeader colHPosMedia;
    public ColumnHeader colHRating;
    public ColumnHeader colHSamplerate;
    public ColumnHeader colHSubDir;
    public ColumnHeader colHTAGVer1;
    public ColumnHeader colHTAGVer2;
    public ColumnHeader colHTitle;
    public ColumnHeader colHTrack;
    public ColumnHeader colHVBR;
    public ColumnHeader colHVersion;
    public ColumnHeader colHYear;
    public ListView MP3View;
    public byte vbytVersionToShow;
    public int LastSortedColumn;
    private StatusStrip statusStrip1;
    private ToolStripStatusLabel lblNumber;
    private ToolStripStatusLabel lblPath;
    private ToolStripStatusLabel lblVersion;
    private ToolStripStatusLabel lblLength;
    private ToolStripStatusLabel lblSubDirs;
    private ToolStripStatusLabel lblProgress;
    private ToolStripProgressBar StatusProgressBar;
    private ContextMenuStrip errContext;
    private ToolStripMenuItem ctxClearErrors;
    private ToolStripMenuItem mnubCaseConv;
    private ToolStripMenuItem mnubTransferConvertTags;
    private ToolStripMenuItem mnubSwapV1;
    private ToolStripMenuItem mnubSwapV2;
    private ToolStripMenuItem mnubQueryFreeDB;
    private ToolStripMenuItem mnubEnumerate;
    private ToolStripMenuItem tsmiDecrease;
    private ToolStripMenuItem tsmiIncrease;
    private ToolStripMenuItem tsmiArtist;
    private ToolStripMenuItem tsmiTitle;
    private ToolStripMenuItem tsmiAlbum;
    private ToolStripMenuItem tsmiClearFilter;
    private ToolStripTextBox mnutEnumerateCounter;
    private ToolStripMenuItem artistTitleToolStripMenuItem2;
    private ToolStripMenuItem artistAlbumToolStripMenuItem2;
    private ToolStripMenuItem titleAlbumToolStripMenuItem2;
    private ToolStripMenuItem artistTitleToolStripMenuItem3;
    private ToolStripMenuItem artistAlbumToolStripMenuItem3;
    private ToolStripMenuItem titleAlbumToolStripMenuItem3;
    private ToolStripMenuItem enumerateInFilenameToolStripMenuItem1;
    private ToolStripMenuItem enumerateInTAGVer1ToolStripMenuItem1;
    private ToolStripMenuItem enumerateInTAGVer2ToolStripMenuItem1;
    private ToolStripMenuItem mnubArtistFilterA;
    private ToolStripMenuItem bToolStripMenuItem;
    private ToolStripMenuItem cToolStripMenuItem;
    private ToolStripMenuItem dToolStripMenuItem;
    private ToolStripMenuItem eToolStripMenuItem;
    private ToolStripMenuItem fToolStripMenuItem;
    private ToolStripMenuItem gToolStripMenuItem;
    private ToolStripMenuItem hToolStripMenuItem;
    private ToolStripMenuItem iToolStripMenuItem;
    private ToolStripMenuItem jToolStripMenuItem;
    private ToolStripMenuItem kToolStripMenuItem;
    private ToolStripMenuItem lToolStripMenuItem;
    private ToolStripMenuItem mToolStripMenuItem;
    private ToolStripMenuItem nToolStripMenuItem;
    private ToolStripMenuItem oToolStripMenuItem;
    private ToolStripMenuItem pToolStripMenuItem;
    private ToolStripMenuItem qToolStripMenuItem;
    private ToolStripMenuItem rToolStripMenuItem;
    private ToolStripMenuItem sToolStripMenuItem;
    private ToolStripMenuItem tToolStripMenuItem;
    private ToolStripMenuItem uToolStripMenuItem;
    private ToolStripMenuItem vToolStripMenuItem;
    private ToolStripMenuItem wToolStripMenuItem;
    private ToolStripMenuItem xToolStripMenuItem;
    private ToolStripMenuItem yToolStripMenuItem;
    private ToolStripMenuItem zToolStripMenuItem;
    private ToolStripMenuItem toolStripMenuItem2;
    private ToolStripMenuItem toolStripMenuItem3;
    private ToolStripMenuItem toolStripMenuItem4;
    private ToolStripMenuItem mnubTitleFilterA;
    private ToolStripMenuItem mnubAlbumFilterA;
    private ToolStripMenuItem bToolStripMenuItem1;
    private ToolStripMenuItem cToolStripMenuItem1;
    private ToolStripMenuItem dToolStripMenuItem1;
    private ToolStripMenuItem eToolStripMenuItem1;
    private ToolStripMenuItem fToolStripMenuItem1;
    private ToolStripMenuItem gToolStripMenuItem1;
    private ToolStripMenuItem hToolStripMenuItem1;
    private ToolStripMenuItem iToolStripMenuItem1;
    private ToolStripMenuItem jToolStripMenuItem1;
    private ToolStripMenuItem kToolStripMenuItem1;
    private ToolStripMenuItem lToolStripMenuItem1;
    private ToolStripMenuItem mToolStripMenuItem1;
    private ToolStripMenuItem nToolStripMenuItem1;
    private ToolStripMenuItem oToolStripMenuItem1;
    private ToolStripMenuItem pToolStripMenuItem1;
    private ToolStripMenuItem qToolStripMenuItem1;
    private ToolStripMenuItem rToolStripMenuItem1;
    private ToolStripMenuItem sToolStripMenuItem1;
    private ToolStripMenuItem tToolStripMenuItem1;
    private ToolStripMenuItem uToolStripMenuItem1;
    private ToolStripMenuItem vToolStripMenuItem1;
    private ToolStripMenuItem wToolStripMenuItem1;
    private ToolStripMenuItem xToolStripMenuItem1;
    private ToolStripMenuItem yToolStripMenuItem1;
    private ToolStripMenuItem zToolStripMenuItem1;
    private ToolStripMenuItem toolStripMenuItem5;
    private ToolStripMenuItem toolStripMenuItem6;
    private ToolStripMenuItem bToolStripMenuItem2;
    private ToolStripMenuItem cToolStripMenuItem2;
    private ToolStripMenuItem dToolStripMenuItem2;
    private ToolStripMenuItem eToolStripMenuItem2;
    private ToolStripMenuItem fToolStripMenuItem2;
    private ToolStripMenuItem gToolStripMenuItem2;
    private ToolStripMenuItem hToolStripMenuItem2;
    private ToolStripMenuItem iToolStripMenuItem2;
    private ToolStripMenuItem jToolStripMenuItem2;
    private ToolStripMenuItem kToolStripMenuItem2;
    private ToolStripMenuItem lToolStripMenuItem2;
    private ToolStripMenuItem mToolStripMenuItem2;
    private ToolStripMenuItem nToolStripMenuItem2;
    private ToolStripMenuItem oToolStripMenuItem2;
    private ToolStripMenuItem pToolStripMenuItem2;
    private ToolStripMenuItem qToolStripMenuItem2;
    private ToolStripMenuItem rToolStripMenuItem2;
    private ToolStripMenuItem sToolStripMenuItem2;
    private ToolStripMenuItem tToolStripMenuItem2;
    private ToolStripMenuItem uToolStripMenuItem2;
    private ToolStripMenuItem vToolStripMenuItem2;
    private ToolStripMenuItem wToolStripMenuItem2;
    private ToolStripMenuItem xToolStripMenuItem2;
    private ToolStripMenuItem yToolStripMenuItem2;
    private ToolStripMenuItem zToolStripMenuItem2;
    private ToolStripMenuItem toolStripMenuItem7;
    private ToolStripMenuItem toolStripMenuItem8;
    private Panel pnlTools;
    private LinkLabel lnkToolsExpCol;
    private Label lblTools;
    private ListView lstTools;
    private Panel pnlInformation;
    private LinkLabel lnkInfoExpCol;
    private RichTextBox txtInformation;
    private Label lblInformation;
    private Panel pnlPicture;
    private LinkLabel lnkPictureExpCol;
    private PictureBox picCover;
    private Label lblPicture;
    private Panel pnlQuickEdit;
    private LinkLabel lnkQuickEditExpCol;
    private Button btnQuickEditOK;
    private TextBox txtQETitle;
    private TextBox txtQEAlbum;
    private Label lblQETitle;
    private Label lblQEAlbum;
    public ComboBox cboQEArtist;
    private Label lblQEArtist;
    private Label lblQuickEdit;
    private Button btnQuickEditMore;
    private System.Windows.Forms.TabControl tabControl1;
    private TabPage tabFolders;
    private FolderTreeView FolderTree;
    private TabPage tabFavorites;
    public TreeView FavTree;
    private SplitContainer spltMiddle;
    public ListView ErrorMsg;
    public int SortedColumn;

    /// <summary>
    /// Clean up any resources being used.
    /// </summary>
    /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
    }

    /// <summary>
    /// Required method for Designer support - do not modify
    /// the contents of this method with the code editor.
    /// </summary>
    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new System.ComponentModel.Container();
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMain));
      this.spltQuickInfo = new System.Windows.Forms.SplitContainer();
      this.spltTop = new System.Windows.Forms.SplitContainer();
      this.tabControl1 = new System.Windows.Forms.TabControl();
      this.tabFolders = new System.Windows.Forms.TabPage();
      this.FolderTree = new ID3_TagIT.FolderTreeView();
      this.tabFavorites = new System.Windows.Forms.TabPage();
      this.FavTree = new System.Windows.Forms.TreeView();
      this.spltMiddle = new System.Windows.Forms.SplitContainer();
      this.MP3View = new System.Windows.Forms.ListView();
      this.ctxRightClick = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ctxRightTag1 = new System.Windows.Forms.ToolStripMenuItem();
      this.editTAGVer1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.multipleEditTAGVer1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.removeTAGVer1 = new System.Windows.Forms.ToolStripMenuItem();
      this.filenameTAGVer1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.tAGVer1FilenameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxRightTag2 = new System.Windows.Forms.ToolStripMenuItem();
      this.editTAGVer2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.multipleEditTAGVer2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.removeTAGVer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.filenameTAGVer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tAGVer2FilenameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.sepRight1 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxRightSwap1 = new System.Windows.Forms.ToolStripMenuItem();
      this.artistTitleToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.artistAlbumToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.titleAlbumToolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxRightSwap2 = new System.Windows.Forms.ToolStripMenuItem();
      this.artistTitleToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.artistAlbumToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.titleAlbumToolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.sepRight2 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxRightPlay = new System.Windows.Forms.ToolStripMenuItem();
      this.sepRight3 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxRightOpen = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxRightRename = new System.Windows.Forms.ToolStripMenuItem();
      this.sepRight4 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxRightMove = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxRightCopy = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxRightDelete = new System.Windows.Forms.ToolStripMenuItem();
      this.sepRight5 = new System.Windows.Forms.ToolStripSeparator();
      this.ctxRightCopyTAG = new System.Windows.Forms.ToolStripMenuItem();
      this.copyTAGVer1OnlyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.copyTAGVer2OnlyToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.copyTAGVer1And2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.ctxRightPasteTAG = new System.Windows.Forms.ToolStripMenuItem();
      this.ErrorMsg = new System.Windows.Forms.ListView();
      this.errContext = new System.Windows.Forms.ContextMenuStrip(this.components);
      this.ctxClearErrors = new System.Windows.Forms.ToolStripMenuItem();
      this.pnlTools = new System.Windows.Forms.Panel();
      this.lnkToolsExpCol = new System.Windows.Forms.LinkLabel();
      this.lblTools = new System.Windows.Forms.Label();
      this.lstTools = new System.Windows.Forms.ListView();
      this.pnlInformation = new System.Windows.Forms.Panel();
      this.lnkInfoExpCol = new System.Windows.Forms.LinkLabel();
      this.txtInformation = new System.Windows.Forms.RichTextBox();
      this.lblInformation = new System.Windows.Forms.Label();
      this.pnlPicture = new System.Windows.Forms.Panel();
      this.lnkPictureExpCol = new System.Windows.Forms.LinkLabel();
      this.picCover = new System.Windows.Forms.PictureBox();
      this.lblPicture = new System.Windows.Forms.Label();
      this.pnlQuickEdit = new System.Windows.Forms.Panel();
      this.btnQuickEditMore = new System.Windows.Forms.Button();
      this.lnkQuickEditExpCol = new System.Windows.Forms.LinkLabel();
      this.btnQuickEditOK = new System.Windows.Forms.Button();
      this.txtQETitle = new System.Windows.Forms.TextBox();
      this.txtQEAlbum = new System.Windows.Forms.TextBox();
      this.lblQETitle = new System.Windows.Forms.Label();
      this.lblQEAlbum = new System.Windows.Forms.Label();
      this.cboQEArtist = new System.Windows.Forms.ComboBox();
      this.lblQEArtist = new System.Windows.Forms.Label();
      this.lblQuickEdit = new System.Windows.Forms.Label();
      this.GroupIcons = new System.Windows.Forms.ImageList(this.components);
      this.ToolsIcons = new System.Windows.Forms.ImageList(this.components);
      this.ColumnHeaderIcons = new System.Windows.Forms.ImageList(this.components);
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.Timer = new System.Windows.Forms.Timer(this.components);
      this.FolderRenameTimer = new System.Windows.Forms.Timer(this.components);
      this.EnumInfo = new System.Windows.Forms.Label();
      this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
      this.mnuDDs = new System.Windows.Forms.MenuStrip();
      this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.addDirectoryToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.refreshToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator2 = new System.Windows.Forms.ToolStripSeparator();
      this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator3 = new System.Windows.Forms.ToolStripSeparator();
      this.playToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator4 = new System.Windows.Forms.ToolStripSeparator();
      this.moveFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.deleteFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.organizeFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator5 = new System.Windows.Forms.ToolStripSeparator();
      this.openFileLocationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removeEmptyFoldersToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.renameFilefolderToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.filePropertiesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator6 = new System.Windows.Forms.ToolStripSeparator();
      this.quitToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.undoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.redoToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator18 = new System.Windows.Forms.ToolStripSeparator();
      this.searchandReplaceToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator19 = new System.Windows.Forms.ToolStripSeparator();
      this.swapTAGVer1EntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.artistTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.artistAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.titleAlbumToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.swapTAGVer2EntriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.artistTitleToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.artistAlbumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.titleAlbumToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator20 = new System.Windows.Forms.ToolStripSeparator();
      this.splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator21 = new System.Windows.Forms.ToolStripSeparator();
      this.copyTAGInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyTAGVer1OnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyTAGVer2OnlyToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.copyTAGVer1And2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pasteTAGInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewTAGVer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.viewTAGVer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator7 = new System.Windows.Forms.ToolStripSeparator();
      this.selectallToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.groupSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.invertSelectionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator8 = new System.Windows.Forms.ToolStripSeparator();
      this.selectFilesByformatToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.selectChangedFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator9 = new System.Windows.Forms.ToolStripSeparator();
      this.removeSelectedFilesFromListToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.iD3FunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.editTAGVer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.multipleEditTAGVer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removeTAGVer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.filenameTAGVer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tAGVer1FilenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator17 = new System.Windows.Forms.ToolStripSeparator();
      this.editTAGVer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.multipleEditTAGVer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.removeTAGVer1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.filenameToTagV2 = new System.Windows.Forms.ToolStripMenuItem();
      this.tAGVer2FilenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.extendedFunctionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.caseConversionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.transferConvertTAGsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.changeTAGVer2TextencodingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator14 = new System.Windows.Forms.ToolStripSeparator();
      this.queryFreeDBToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator15 = new System.Windows.Forms.ToolStripSeparator();
      this.enumerateInfilenameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enumerateInTAGVer1ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.enumerateInTAGVer2ToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator16 = new System.Windows.Forms.ToolStripSeparator();
      this.createFilelistPlaylistToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.analyseToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.findduplicateFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.compareFilenameWthTAGInformationToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator10 = new System.Windows.Forms.ToolStripSeparator();
      this.selectDuplicateFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.selectmismatchingFilenameTAGFilesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.optionsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.scanSubdirectoriesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.quickFilenameEditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.synchronizeVer1AndVer2EditingToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator11 = new System.Windows.Forms.ToolStripSeparator();
      this.editLibrariesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator12 = new System.Windows.Forms.ToolStripSeparator();
      this.preferencesToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator13 = new System.Windows.Forms.ToolStripSeparator();
      this.cboLanguage = new System.Windows.Forms.ToolStripComboBox();
      this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.helpToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.shortcutsToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
      this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mnuExtended = new System.Windows.Forms.MenuStrip();
      this.mnubCaseConv = new System.Windows.Forms.ToolStripMenuItem();
      this.mnubTransferConvertTags = new System.Windows.Forms.ToolStripMenuItem();
      this.sepButtons6 = new System.Windows.Forms.ToolStripSeparator();
      this.mnubSwapV1 = new System.Windows.Forms.ToolStripMenuItem();
      this.artistTitleToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.artistAlbumToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.titleAlbumToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.mnubSwapV2 = new System.Windows.Forms.ToolStripMenuItem();
      this.artistTitleToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.artistAlbumToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.titleAlbumToolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.sepButtons7 = new System.Windows.Forms.ToolStripSeparator();
      this.mnubQueryFreeDB = new System.Windows.Forms.ToolStripMenuItem();
      this.sepButtons8 = new System.Windows.Forms.ToolStripSeparator();
      this.mnubEnumerate = new System.Windows.Forms.ToolStripMenuItem();
      this.enumerateInFilenameToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.enumerateInTAGVer1ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.enumerateInTAGVer2ToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiDecrease = new System.Windows.Forms.ToolStripMenuItem();
      this.mnutEnumerateCounter = new System.Windows.Forms.ToolStripTextBox();
      this.tsmiIncrease = new System.Windows.Forms.ToolStripMenuItem();
      this.sepButtons9 = new System.Windows.Forms.ToolStripSeparator();
      this.tsmiArtist = new System.Windows.Forms.ToolStripMenuItem();
      this.mnubArtistFilterA = new System.Windows.Forms.ToolStripMenuItem();
      this.bToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.cToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.dToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.eToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.fToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.gToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.hToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.iToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.jToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.kToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.lToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.mToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.nToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.oToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.pToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.qToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.rToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.sToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.tToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.uToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.vToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.wToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.xToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.yToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.zToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem4 = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiTitle = new System.Windows.Forms.ToolStripMenuItem();
      this.mnubTitleFilterA = new System.Windows.Forms.ToolStripMenuItem();
      this.bToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.cToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.dToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.eToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.fToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.gToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.hToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.iToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.jToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.kToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.lToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.mToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.nToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.oToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.pToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.qToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.rToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.sToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.tToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.uToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.vToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.wToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.xToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.yToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.zToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem5 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem6 = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiAlbum = new System.Windows.Forms.ToolStripMenuItem();
      this.mnubAlbumFilterA = new System.Windows.Forms.ToolStripMenuItem();
      this.bToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.cToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.dToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.eToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.fToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.gToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.hToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.iToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.jToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.kToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.lToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.mToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.nToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.oToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.pToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.qToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.rToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.sToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.tToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.uToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.vToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.wToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.xToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.yToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.zToolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem7 = new System.Windows.Forms.ToolStripMenuItem();
      this.toolStripMenuItem8 = new System.Windows.Forms.ToolStripMenuItem();
      this.tsmiClearFilter = new System.Windows.Forms.ToolStripMenuItem();
      this.sepButtons1 = new System.Windows.Forms.ToolStripSeparator();
      this.sepButtons2 = new System.Windows.Forms.ToolStripSeparator();
      this.sepButtons3 = new System.Windows.Forms.ToolStripSeparator();
      this.sepButtons4 = new System.Windows.Forms.ToolStripSeparator();
      this.sepButtons5 = new System.Windows.Forms.ToolStripSeparator();
      this.mnuBtns = new System.Windows.Forms.MenuStrip();
      this.btnAddFolder = new System.Windows.Forms.ToolStripMenuItem();
      this.btnSave = new System.Windows.Forms.ToolStripMenuItem();
      this.btnPlay = new System.Windows.Forms.ToolStripMenuItem();
      this.btnRefresh = new System.Windows.Forms.ToolStripMenuItem();
      this.btnUndo = new System.Windows.Forms.ToolStripMenuItem();
      this.btnRedo = new System.Windows.Forms.ToolStripMenuItem();
      this.btnEditV1 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnMultiEditV1 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnRemoveV1 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnFileToTagV1 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnTagToFileV1 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnSwitchV1V2 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnEditV2 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnMultiEditV2 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnRemoveV2 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnFileToTagV2 = new System.Windows.Forms.ToolStripMenuItem();
      this.btnTagToFileV2 = new System.Windows.Forms.ToolStripMenuItem();
      this.statusStrip1 = new System.Windows.Forms.StatusStrip();
      this.lblNumber = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblPath = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblVersion = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblLength = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblSubDirs = new System.Windows.Forms.ToolStripStatusLabel();
      this.lblProgress = new System.Windows.Forms.ToolStripStatusLabel();
      this.StatusProgressBar = new System.Windows.Forms.ToolStripProgressBar();
      ((System.ComponentModel.ISupportInitialize)(this.spltQuickInfo)).BeginInit();
      this.spltQuickInfo.Panel1.SuspendLayout();
      this.spltQuickInfo.Panel2.SuspendLayout();
      this.spltQuickInfo.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spltTop)).BeginInit();
      this.spltTop.Panel1.SuspendLayout();
      this.spltTop.Panel2.SuspendLayout();
      this.spltTop.SuspendLayout();
      this.tabControl1.SuspendLayout();
      this.tabFolders.SuspendLayout();
      this.tabFavorites.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.spltMiddle)).BeginInit();
      this.spltMiddle.Panel1.SuspendLayout();
      this.spltMiddle.Panel2.SuspendLayout();
      this.spltMiddle.SuspendLayout();
      this.ctxRightClick.SuspendLayout();
      this.errContext.SuspendLayout();
      this.pnlTools.SuspendLayout();
      this.pnlInformation.SuspendLayout();
      this.pnlPicture.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picCover)).BeginInit();
      this.pnlQuickEdit.SuspendLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
      this.mnuDDs.SuspendLayout();
      this.mnuExtended.SuspendLayout();
      this.mnuBtns.SuspendLayout();
      this.statusStrip1.SuspendLayout();
      this.SuspendLayout();
      // 
      // spltQuickInfo
      // 
      this.spltQuickInfo.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spltQuickInfo.Location = new System.Drawing.Point(0, 78);
      this.spltQuickInfo.Name = "spltQuickInfo";
      // 
      // spltQuickInfo.Panel1
      // 
      this.spltQuickInfo.Panel1.Controls.Add(this.spltTop);
      // 
      // spltQuickInfo.Panel2
      // 
      this.spltQuickInfo.Panel2.Controls.Add(this.pnlTools);
      this.spltQuickInfo.Panel2.Controls.Add(this.pnlInformation);
      this.spltQuickInfo.Panel2.Controls.Add(this.pnlPicture);
      this.spltQuickInfo.Panel2.Controls.Add(this.pnlQuickEdit);
      this.spltQuickInfo.Size = new System.Drawing.Size(1178, 764);
      this.spltQuickInfo.SplitterDistance = 975;
      this.spltQuickInfo.TabIndex = 31;
      this.spltQuickInfo.Click += new System.EventHandler(this.spltQuickInfo_Click);
      // 
      // spltTop
      // 
      this.spltTop.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spltTop.Location = new System.Drawing.Point(0, 0);
      this.spltTop.Name = "spltTop";
      // 
      // spltTop.Panel1
      // 
      this.spltTop.Panel1.Controls.Add(this.tabControl1);
      // 
      // spltTop.Panel2
      // 
      this.spltTop.Panel2.Controls.Add(this.spltMiddle);
      this.spltTop.Size = new System.Drawing.Size(975, 764);
      this.spltTop.SplitterDistance = 196;
      this.spltTop.TabIndex = 26;
      // 
      // tabControl1
      // 
      this.tabControl1.Controls.Add(this.tabFolders);
      this.tabControl1.Controls.Add(this.tabFavorites);
      this.tabControl1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.tabControl1.Location = new System.Drawing.Point(0, 0);
      this.tabControl1.Name = "tabControl1";
      this.tabControl1.SelectedIndex = 0;
      this.tabControl1.Size = new System.Drawing.Size(196, 764);
      this.tabControl1.TabIndex = 0;
      // 
      // tabFolders
      // 
      this.tabFolders.Controls.Add(this.FolderTree);
      this.tabFolders.Location = new System.Drawing.Point(4, 22);
      this.tabFolders.Name = "tabFolders";
      this.tabFolders.Padding = new System.Windows.Forms.Padding(3);
      this.tabFolders.Size = new System.Drawing.Size(188, 738);
      this.tabFolders.TabIndex = 0;
      this.tabFolders.Text = "Folders";
      this.tabFolders.UseVisualStyleBackColor = true;
      // 
      // FolderTree
      // 
      this.FolderTree.BackColor = System.Drawing.SystemColors.Control;
      this.FolderTree.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FolderTree.Location = new System.Drawing.Point(3, 3);
      this.FolderTree.Name = "FolderTree";
      this.FolderTree.Size = new System.Drawing.Size(182, 732);
      this.FolderTree.TabIndex = 2;
      this.FolderTree.AfterLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.FolderTree_AfterLabelEdit);
      this.FolderTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FolderTree_AfterSelect);
      this.FolderTree.BeforeLabelEdit += new System.Windows.Forms.NodeLabelEditEventHandler(this.FolderTree_BeforeLabelEdit);
      this.FolderTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.FolderTree_BeforeSelect);
      // 
      // tabFavorites
      // 
      this.tabFavorites.Controls.Add(this.FavTree);
      this.tabFavorites.Location = new System.Drawing.Point(4, 22);
      this.tabFavorites.Name = "tabFavorites";
      this.tabFavorites.Padding = new System.Windows.Forms.Padding(3);
      this.tabFavorites.Size = new System.Drawing.Size(188, 738);
      this.tabFavorites.TabIndex = 1;
      this.tabFavorites.Text = "Favorites";
      this.tabFavorites.UseVisualStyleBackColor = true;
      // 
      // FavTree
      // 
      this.FavTree.Dock = System.Windows.Forms.DockStyle.Fill;
      this.FavTree.HideSelection = false;
      this.FavTree.Indent = 19;
      this.FavTree.ItemHeight = 16;
      this.FavTree.Location = new System.Drawing.Point(3, 3);
      this.FavTree.Name = "FavTree";
      this.FavTree.Size = new System.Drawing.Size(182, 732);
      this.FavTree.TabIndex = 9;
      this.FavTree.BeforeSelect += new System.Windows.Forms.TreeViewCancelEventHandler(this.FavTree_BeforeSelect);
      this.FavTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.FavTree_AfterSelect);
      this.FavTree.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FavTree_MouseUp);
      // 
      // spltMiddle
      // 
      this.spltMiddle.Dock = System.Windows.Forms.DockStyle.Fill;
      this.spltMiddle.Location = new System.Drawing.Point(0, 0);
      this.spltMiddle.Name = "spltMiddle";
      this.spltMiddle.Orientation = System.Windows.Forms.Orientation.Horizontal;
      // 
      // spltMiddle.Panel1
      // 
      this.spltMiddle.Panel1.Controls.Add(this.MP3View);
      // 
      // spltMiddle.Panel2
      // 
      this.spltMiddle.Panel2.Controls.Add(this.ErrorMsg);
      this.spltMiddle.Size = new System.Drawing.Size(775, 764);
      this.spltMiddle.SplitterDistance = 555;
      this.spltMiddle.TabIndex = 26;
      // 
      // MP3View
      // 
      this.MP3View.AllowColumnReorder = true;
      this.MP3View.ContextMenuStrip = this.ctxRightClick;
      this.MP3View.Dock = System.Windows.Forms.DockStyle.Fill;
      this.MP3View.FullRowSelect = true;
      this.MP3View.HideSelection = false;
      this.MP3View.Location = new System.Drawing.Point(0, 0);
      this.MP3View.Name = "MP3View";
      this.MP3View.Size = new System.Drawing.Size(775, 555);
      this.MP3View.TabIndex = 0;
      this.MP3View.UseCompatibleStateImageBehavior = false;
      this.MP3View.View = System.Windows.Forms.View.Details;
      this.MP3View.AfterLabelEdit += new System.Windows.Forms.LabelEditEventHandler(this.MP3View_AfterLabelEdit);
      this.MP3View.ColumnClick += new System.Windows.Forms.ColumnClickEventHandler(this.MP3View_ColumnClick);
      this.MP3View.ItemDrag += new System.Windows.Forms.ItemDragEventHandler(this.MP3View_ItemDrag);
      this.MP3View.SelectedIndexChanged += new System.EventHandler(this.MP3View_SelectedIndexChanged);
      this.MP3View.Click += new System.EventHandler(this.MP3View_Click);
      this.MP3View.DoubleClick += new System.EventHandler(this.MP3View_DoubleClick);
      this.MP3View.KeyDown += new System.Windows.Forms.KeyEventHandler(this.MP3View_KeyDown);
      this.MP3View.MouseEnter += new System.EventHandler(this.MP3View_MouseEnter);
      this.MP3View.MouseLeave += new System.EventHandler(this.MP3View_MouseLeave);
      this.MP3View.MouseMove += new System.Windows.Forms.MouseEventHandler(this.MP3View_MouseMove);
      this.MP3View.MouseUp += new System.Windows.Forms.MouseEventHandler(this.MP3View_MouseUp);
      // 
      // ctxRightClick
      // 
      this.ctxRightClick.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxRightTag1,
            this.ctxRightTag2,
            this.sepRight1,
            this.ctxRightSwap1,
            this.ctxRightSwap2,
            this.sepRight2,
            this.ctxRightPlay,
            this.sepRight3,
            this.ctxRightOpen,
            this.ctxRightRename,
            this.sepRight4,
            this.ctxRightMove,
            this.ctxRightCopy,
            this.ctxRightDelete,
            this.sepRight5,
            this.ctxRightCopyTAG,
            this.ctxRightPasteTAG});
      this.ctxRightClick.Name = "ctxRightClick";
      this.ctxRightClick.Size = new System.Drawing.Size(266, 320);
      // 
      // ctxRightTag1
      // 
      this.ctxRightTag1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTAGVer1ToolStripMenuItem1,
            this.multipleEditTAGVer1ToolStripMenuItem1,
            this.removeTAGVer1,
            this.filenameTAGVer1ToolStripMenuItem1,
            this.tAGVer1FilenameToolStripMenuItem1});
      this.ctxRightTag1.Name = "ctxRightTag1";
      this.ctxRightTag1.Size = new System.Drawing.Size(265, 22);
      this.ctxRightTag1.Text = "TAG Ver. 1 function";
      // 
      // editTAGVer1ToolStripMenuItem1
      // 
      this.editTAGVer1ToolStripMenuItem1.Name = "editTAGVer1ToolStripMenuItem1";
      this.editTAGVer1ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
      this.editTAGVer1ToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
      this.editTAGVer1ToolStripMenuItem1.Text = "Edit TAG Ver. &1";
      this.editTAGVer1ToolStripMenuItem1.Click += new System.EventHandler(this.editTAGVer1ToolStripMenuItem1_Click);
      // 
      // multipleEditTAGVer1ToolStripMenuItem1
      // 
      this.multipleEditTAGVer1ToolStripMenuItem1.Name = "multipleEditTAGVer1ToolStripMenuItem1";
      this.multipleEditTAGVer1ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
      this.multipleEditTAGVer1ToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
      this.multipleEditTAGVer1ToolStripMenuItem1.Text = "&Multiple Edit TAG Ver. 1";
      this.multipleEditTAGVer1ToolStripMenuItem1.Click += new System.EventHandler(this.multipleEditTAGVer1ToolStripMenuItem1_Click);
      // 
      // removeTAGVer1
      // 
      this.removeTAGVer1.Name = "removeTAGVer1";
      this.removeTAGVer1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
      this.removeTAGVer1.Size = new System.Drawing.Size(241, 22);
      this.removeTAGVer1.Text = "&Remove TAG Ver. 1";
      this.removeTAGVer1.Click += new System.EventHandler(this.removeTAGVer1_Click);
      // 
      // filenameTAGVer1ToolStripMenuItem1
      // 
      this.filenameTAGVer1ToolStripMenuItem1.Name = "filenameTAGVer1ToolStripMenuItem1";
      this.filenameTAGVer1ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
      this.filenameTAGVer1ToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
      this.filenameTAGVer1ToolStripMenuItem1.Text = "&Filename -> TAG Ver. 1";
      this.filenameTAGVer1ToolStripMenuItem1.Click += new System.EventHandler(this.filenameTAGVer1ToolStripMenuItem1_Click);
      // 
      // tAGVer1FilenameToolStripMenuItem1
      // 
      this.tAGVer1FilenameToolStripMenuItem1.Name = "tAGVer1FilenameToolStripMenuItem1";
      this.tAGVer1FilenameToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
      this.tAGVer1FilenameToolStripMenuItem1.Size = new System.Drawing.Size(241, 22);
      this.tAGVer1FilenameToolStripMenuItem1.Text = "&TAG Ver. 1 -> Filename";
      this.tAGVer1FilenameToolStripMenuItem1.Click += new System.EventHandler(this.tAGVer1FilenameToolStripMenuItem1_Click);
      // 
      // ctxRightTag2
      // 
      this.ctxRightTag2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTAGVer2ToolStripMenuItem1,
            this.multipleEditTAGVer2ToolStripMenuItem1,
            this.removeTAGVer2ToolStripMenuItem,
            this.filenameTAGVer2ToolStripMenuItem,
            this.tAGVer2FilenameToolStripMenuItem1});
      this.ctxRightTag2.Name = "ctxRightTag2";
      this.ctxRightTag2.Size = new System.Drawing.Size(265, 22);
      this.ctxRightTag2.Text = "TAG Ver. 2 function";
      // 
      // editTAGVer2ToolStripMenuItem1
      // 
      this.editTAGVer2ToolStripMenuItem1.Name = "editTAGVer2ToolStripMenuItem1";
      this.editTAGVer2ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
      this.editTAGVer2ToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
      this.editTAGVer2ToolStripMenuItem1.Text = "Edit TAG Ver. &2";
      this.editTAGVer2ToolStripMenuItem1.Click += new System.EventHandler(this.editTAGVer2ToolStripMenuItem1_Click);
      // 
      // multipleEditTAGVer2ToolStripMenuItem1
      // 
      this.multipleEditTAGVer2ToolStripMenuItem1.Name = "multipleEditTAGVer2ToolStripMenuItem1";
      this.multipleEditTAGVer2ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.multipleEditTAGVer2ToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
      this.multipleEditTAGVer2ToolStripMenuItem1.Text = "Multi&ple Edit TAG Ver. 2";
      this.multipleEditTAGVer2ToolStripMenuItem1.Click += new System.EventHandler(this.multipleEditTAGVer2ToolStripMenuItem1_Click);
      // 
      // removeTAGVer2ToolStripMenuItem
      // 
      this.removeTAGVer2ToolStripMenuItem.Name = "removeTAGVer2ToolStripMenuItem";
      this.removeTAGVer2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
      this.removeTAGVer2ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.removeTAGVer2ToolStripMenuItem.Text = "Remo&ve TAG Ver. 2";
      this.removeTAGVer2ToolStripMenuItem.Click += new System.EventHandler(this.removeTAGVer2ToolStripMenuItem_Click);
      // 
      // filenameTAGVer2ToolStripMenuItem
      // 
      this.filenameTAGVer2ToolStripMenuItem.Name = "filenameTAGVer2ToolStripMenuItem";
      this.filenameTAGVer2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.filenameTAGVer2ToolStripMenuItem.Size = new System.Drawing.Size(239, 22);
      this.filenameTAGVer2ToolStripMenuItem.Text = "File&name -> TAG Ver. 2";
      this.filenameTAGVer2ToolStripMenuItem.Click += new System.EventHandler(this.filenameTAGVer2ToolStripMenuItem_Click);
      // 
      // tAGVer2FilenameToolStripMenuItem1
      // 
      this.tAGVer2FilenameToolStripMenuItem1.Name = "tAGVer2FilenameToolStripMenuItem1";
      this.tAGVer2FilenameToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      this.tAGVer2FilenameToolStripMenuItem1.Size = new System.Drawing.Size(239, 22);
      this.tAGVer2FilenameToolStripMenuItem1.Text = "TA&G Ver. 2 -> Filename";
      this.tAGVer2FilenameToolStripMenuItem1.Click += new System.EventHandler(this.tAGVer2FilenameToolStripMenuItem1_Click);
      // 
      // sepRight1
      // 
      this.sepRight1.Name = "sepRight1";
      this.sepRight1.Size = new System.Drawing.Size(262, 6);
      // 
      // ctxRightSwap1
      // 
      this.ctxRightSwap1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistTitleToolStripMenuItem5,
            this.artistAlbumToolStripMenuItem5,
            this.titleAlbumToolStripMenuItem5});
      this.ctxRightSwap1.Image = global::Properties.Resources.SwapV1;
      this.ctxRightSwap1.Name = "ctxRightSwap1";
      this.ctxRightSwap1.Size = new System.Drawing.Size(265, 22);
      this.ctxRightSwap1.Text = "S&wap TAGVer. 1 entries";
      // 
      // artistTitleToolStripMenuItem5
      // 
      this.artistTitleToolStripMenuItem5.Name = "artistTitleToolStripMenuItem5";
      this.artistTitleToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
      this.artistTitleToolStripMenuItem5.Size = new System.Drawing.Size(216, 22);
      this.artistTitleToolStripMenuItem5.Text = "Artist <-> Title";
      this.artistTitleToolStripMenuItem5.Click += new System.EventHandler(this.artistTitleToolStripMenuItem5_Click);
      // 
      // artistAlbumToolStripMenuItem5
      // 
      this.artistAlbumToolStripMenuItem5.Name = "artistAlbumToolStripMenuItem5";
      this.artistAlbumToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
      this.artistAlbumToolStripMenuItem5.Size = new System.Drawing.Size(216, 22);
      this.artistAlbumToolStripMenuItem5.Text = "Artist <-> Album";
      this.artistAlbumToolStripMenuItem5.Click += new System.EventHandler(this.artistAlbumToolStripMenuItem5_Click);
      // 
      // titleAlbumToolStripMenuItem5
      // 
      this.titleAlbumToolStripMenuItem5.Name = "titleAlbumToolStripMenuItem5";
      this.titleAlbumToolStripMenuItem5.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
      this.titleAlbumToolStripMenuItem5.Size = new System.Drawing.Size(216, 22);
      this.titleAlbumToolStripMenuItem5.Text = "Title <-> Album";
      this.titleAlbumToolStripMenuItem5.Click += new System.EventHandler(this.titleAlbumToolStripMenuItem5_Click);
      // 
      // ctxRightSwap2
      // 
      this.ctxRightSwap2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistTitleToolStripMenuItem4,
            this.artistAlbumToolStripMenuItem4,
            this.titleAlbumToolStripMenuItem4});
      this.ctxRightSwap2.Image = global::Properties.Resources.SwapV2;
      this.ctxRightSwap2.Name = "ctxRightSwap2";
      this.ctxRightSwap2.Size = new System.Drawing.Size(265, 22);
      this.ctxRightSwap2.Text = "Sw&ap TAGVer. 2 entries";
      // 
      // artistTitleToolStripMenuItem4
      // 
      this.artistTitleToolStripMenuItem4.Name = "artistTitleToolStripMenuItem4";
      this.artistTitleToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
      this.artistTitleToolStripMenuItem4.Size = new System.Drawing.Size(216, 22);
      this.artistTitleToolStripMenuItem4.Text = "Artist <-> Title";
      this.artistTitleToolStripMenuItem4.Click += new System.EventHandler(this.artistTitleToolStripMenuItem4_Click);
      // 
      // artistAlbumToolStripMenuItem4
      // 
      this.artistAlbumToolStripMenuItem4.Name = "artistAlbumToolStripMenuItem4";
      this.artistAlbumToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
      this.artistAlbumToolStripMenuItem4.Size = new System.Drawing.Size(216, 22);
      this.artistAlbumToolStripMenuItem4.Text = "Artist <-> Album";
      this.artistAlbumToolStripMenuItem4.Click += new System.EventHandler(this.artistAlbumToolStripMenuItem4_Click);
      // 
      // titleAlbumToolStripMenuItem4
      // 
      this.titleAlbumToolStripMenuItem4.Name = "titleAlbumToolStripMenuItem4";
      this.titleAlbumToolStripMenuItem4.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F7)));
      this.titleAlbumToolStripMenuItem4.Size = new System.Drawing.Size(216, 22);
      this.titleAlbumToolStripMenuItem4.Text = "Title <-> Album";
      this.titleAlbumToolStripMenuItem4.Click += new System.EventHandler(this.titleAlbumToolStripMenuItem4_Click);
      // 
      // sepRight2
      // 
      this.sepRight2.Name = "sepRight2";
      this.sepRight2.Size = new System.Drawing.Size(262, 6);
      // 
      // ctxRightPlay
      // 
      this.ctxRightPlay.Image = global::Properties.Resources.Play;
      this.ctxRightPlay.Name = "ctxRightPlay";
      this.ctxRightPlay.ShortcutKeys = System.Windows.Forms.Keys.F9;
      this.ctxRightPlay.Size = new System.Drawing.Size(265, 22);
      this.ctxRightPlay.Text = "&Play";
      this.ctxRightPlay.Click += new System.EventHandler(this.ctxRightPlay_Click);
      // 
      // sepRight3
      // 
      this.sepRight3.Name = "sepRight3";
      this.sepRight3.Size = new System.Drawing.Size(262, 6);
      // 
      // ctxRightOpen
      // 
      this.ctxRightOpen.Image = global::Properties.Resources.OpenLocation;
      this.ctxRightOpen.Name = "ctxRightOpen";
      this.ctxRightOpen.Size = new System.Drawing.Size(265, 22);
      this.ctxRightOpen.Text = "&Open file location";
      this.ctxRightOpen.Click += new System.EventHandler(this.ctxRightOpen_Click);
      // 
      // ctxRightRename
      // 
      this.ctxRightRename.Image = global::Properties.Resources.Rename;
      this.ctxRightRename.Name = "ctxRightRename";
      this.ctxRightRename.ShortcutKeys = System.Windows.Forms.Keys.F2;
      this.ctxRightRename.Size = new System.Drawing.Size(265, 22);
      this.ctxRightRename.Text = "&Rename file/folder";
      this.ctxRightRename.Click += new System.EventHandler(this.ctxRightRename_Click);
      // 
      // sepRight4
      // 
      this.sepRight4.Name = "sepRight4";
      this.sepRight4.Size = new System.Drawing.Size(262, 6);
      // 
      // ctxRightMove
      // 
      this.ctxRightMove.Image = global::Properties.Resources.MoveFiles;
      this.ctxRightMove.Name = "ctxRightMove";
      this.ctxRightMove.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
      this.ctxRightMove.Size = new System.Drawing.Size(265, 22);
      this.ctxRightMove.Text = "&Move files";
      this.ctxRightMove.Click += new System.EventHandler(this.ctxRightMove_Click);
      // 
      // ctxRightCopy
      // 
      this.ctxRightCopy.Image = global::Properties.Resources.CopyFiles;
      this.ctxRightCopy.Name = "ctxRightCopy";
      this.ctxRightCopy.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.ctxRightCopy.Size = new System.Drawing.Size(265, 22);
      this.ctxRightCopy.Text = "&Copy files";
      this.ctxRightCopy.Click += new System.EventHandler(this.ctxRightCopy_Click);
      // 
      // ctxRightDelete
      // 
      this.ctxRightDelete.Image = global::Properties.Resources.Delete;
      this.ctxRightDelete.Name = "ctxRightDelete";
      this.ctxRightDelete.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
      this.ctxRightDelete.Size = new System.Drawing.Size(265, 22);
      this.ctxRightDelete.Text = "&Delete files";
      this.ctxRightDelete.Click += new System.EventHandler(this.ctxRightDelete_Click);
      // 
      // sepRight5
      // 
      this.sepRight5.Name = "sepRight5";
      this.sepRight5.Size = new System.Drawing.Size(262, 6);
      // 
      // ctxRightCopyTAG
      // 
      this.ctxRightCopyTAG.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTAGVer1OnlyToolStripMenuItem1,
            this.copyTAGVer2OnlyToolStripMenuItem1,
            this.copyTAGVer1And2ToolStripMenuItem1});
      this.ctxRightCopyTAG.Image = global::Properties.Resources.Copy;
      this.ctxRightCopyTAG.Name = "ctxRightCopyTAG";
      this.ctxRightCopyTAG.Size = new System.Drawing.Size(265, 22);
      this.ctxRightCopyTAG.Text = "Copy TAG informatio&n";
      // 
      // copyTAGVer1OnlyToolStripMenuItem1
      // 
      this.copyTAGVer1OnlyToolStripMenuItem1.Name = "copyTAGVer1OnlyToolStripMenuItem1";
      this.copyTAGVer1OnlyToolStripMenuItem1.Size = new System.Drawing.Size(263, 22);
      this.copyTAGVer1OnlyToolStripMenuItem1.Text = "Copy TAG Ver. &1 only";
      this.copyTAGVer1OnlyToolStripMenuItem1.Click += new System.EventHandler(this.copyTAGVer1OnlyToolStripMenuItem1_Click);
      // 
      // copyTAGVer2OnlyToolStripMenuItem1
      // 
      this.copyTAGVer2OnlyToolStripMenuItem1.Name = "copyTAGVer2OnlyToolStripMenuItem1";
      this.copyTAGVer2OnlyToolStripMenuItem1.Size = new System.Drawing.Size(263, 22);
      this.copyTAGVer2OnlyToolStripMenuItem1.Text = "Copy TAG Ver. &2 only";
      this.copyTAGVer2OnlyToolStripMenuItem1.Click += new System.EventHandler(this.copyTAGVer2OnlyToolStripMenuItem1_Click);
      // 
      // copyTAGVer1And2ToolStripMenuItem1
      // 
      this.copyTAGVer1And2ToolStripMenuItem1.Image = global::Properties.Resources.Copy;
      this.copyTAGVer1And2ToolStripMenuItem1.Name = "copyTAGVer1And2ToolStripMenuItem1";
      this.copyTAGVer1And2ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
      this.copyTAGVer1And2ToolStripMenuItem1.Size = new System.Drawing.Size(263, 22);
      this.copyTAGVer1And2ToolStripMenuItem1.Text = "&Copy TAG Ver. 1 and 2";
      this.copyTAGVer1And2ToolStripMenuItem1.Click += new System.EventHandler(this.copyTAGVer1And2ToolStripMenuItem1_Click);
      // 
      // ctxRightPasteTAG
      // 
      this.ctxRightPasteTAG.Image = global::Properties.Resources.Paste;
      this.ctxRightPasteTAG.Name = "ctxRightPasteTAG";
      this.ctxRightPasteTAG.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
      this.ctxRightPasteTAG.Size = new System.Drawing.Size(265, 22);
      this.ctxRightPasteTAG.Text = "Pa&ste TAG information";
      this.ctxRightPasteTAG.Click += new System.EventHandler(this.ctxRightPasteTAG_Click);
      // 
      // ErrorMsg
      // 
      this.ErrorMsg.BackColor = System.Drawing.SystemColors.Window;
      this.ErrorMsg.ContextMenuStrip = this.errContext;
      this.ErrorMsg.Dock = System.Windows.Forms.DockStyle.Fill;
      this.ErrorMsg.FullRowSelect = true;
      this.ErrorMsg.GridLines = true;
      this.ErrorMsg.HideSelection = false;
      this.ErrorMsg.Location = new System.Drawing.Point(0, 0);
      this.ErrorMsg.Name = "ErrorMsg";
      this.ErrorMsg.Size = new System.Drawing.Size(775, 205);
      this.ErrorMsg.TabIndex = 7;
      this.ErrorMsg.UseCompatibleStateImageBehavior = false;
      this.ErrorMsg.View = System.Windows.Forms.View.Details;
      // 
      // errContext
      // 
      this.errContext.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.ctxClearErrors});
      this.errContext.Name = "contextMenuStrip1";
      this.errContext.Size = new System.Drawing.Size(120, 26);
      // 
      // ctxClearErrors
      // 
      this.ctxClearErrors.Image = global::Properties.Resources.Delete;
      this.ctxClearErrors.Name = "ctxClearErrors";
      this.ctxClearErrors.Size = new System.Drawing.Size(119, 22);
      this.ctxClearErrors.Text = "Clear list";
      this.ctxClearErrors.Click += new System.EventHandler(this.ctxClearErrors_Click);
      // 
      // pnlTools
      // 
      this.pnlTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlTools.Controls.Add(this.lnkToolsExpCol);
      this.pnlTools.Controls.Add(this.lblTools);
      this.pnlTools.Controls.Add(this.lstTools);
      this.pnlTools.Location = new System.Drawing.Point(2, 571);
      this.pnlTools.Name = "pnlTools";
      this.pnlTools.Size = new System.Drawing.Size(195, 137);
      this.pnlTools.TabIndex = 9;
      this.pnlTools.Tag = "Expanded";
      // 
      // lnkToolsExpCol
      // 
      this.lnkToolsExpCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lnkToolsExpCol.Image = global::Properties.Resources.Collapse;
      this.lnkToolsExpCol.Location = new System.Drawing.Point(171, 1);
      this.lnkToolsExpCol.Name = "lnkToolsExpCol";
      this.lnkToolsExpCol.Size = new System.Drawing.Size(18, 18);
      this.lnkToolsExpCol.TabIndex = 4;
      this.lnkToolsExpCol.Click += new System.EventHandler(this.lnkToolsExpCol_Click);
      // 
      // lblTools
      // 
      this.lblTools.AutoSize = true;
      this.lblTools.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblTools.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.lblTools.Image = global::Properties.Resources.Tools;
      this.lblTools.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblTools.Location = new System.Drawing.Point(3, 1);
      this.lblTools.Name = "lblTools";
      this.lblTools.Size = new System.Drawing.Size(67, 16);
      this.lblTools.TabIndex = 0;
      this.lblTools.Text = "     Tools";
      // 
      // lstTools
      // 
      this.lstTools.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lstTools.HideSelection = false;
      this.lstTools.Location = new System.Drawing.Point(6, 22);
      this.lstTools.Name = "lstTools";
      this.lstTools.Size = new System.Drawing.Size(183, 108);
      this.lstTools.TabIndex = 2;
      this.lstTools.UseCompatibleStateImageBehavior = false;
      // 
      // pnlInformation
      // 
      this.pnlInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlInformation.Controls.Add(this.lnkInfoExpCol);
      this.pnlInformation.Controls.Add(this.txtInformation);
      this.pnlInformation.Controls.Add(this.lblInformation);
      this.pnlInformation.Location = new System.Drawing.Point(3, 407);
      this.pnlInformation.Name = "pnlInformation";
      this.pnlInformation.Size = new System.Drawing.Size(195, 164);
      this.pnlInformation.TabIndex = 7;
      this.pnlInformation.Tag = "Expanded";
      // 
      // lnkInfoExpCol
      // 
      this.lnkInfoExpCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lnkInfoExpCol.Image = global::Properties.Resources.Collapse;
      this.lnkInfoExpCol.Location = new System.Drawing.Point(171, 1);
      this.lnkInfoExpCol.Name = "lnkInfoExpCol";
      this.lnkInfoExpCol.Size = new System.Drawing.Size(18, 18);
      this.lnkInfoExpCol.TabIndex = 6;
      this.lnkInfoExpCol.Click += new System.EventHandler(this.lnkInfoExpCol_Click);
      // 
      // txtInformation
      // 
      this.txtInformation.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtInformation.Location = new System.Drawing.Point(6, 22);
      this.txtInformation.Name = "txtInformation";
      this.txtInformation.Size = new System.Drawing.Size(183, 136);
      this.txtInformation.TabIndex = 1;
      this.txtInformation.Text = "";
      // 
      // lblInformation
      // 
      this.lblInformation.AutoSize = true;
      this.lblInformation.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
      this.lblInformation.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.lblInformation.Image = global::Properties.Resources.Info16;
      this.lblInformation.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblInformation.Location = new System.Drawing.Point(3, 1);
      this.lblInformation.Name = "lblInformation";
      this.lblInformation.Size = new System.Drawing.Size(103, 16);
      this.lblInformation.TabIndex = 0;
      this.lblInformation.Text = "     Information";
      // 
      // pnlPicture
      // 
      this.pnlPicture.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlPicture.Controls.Add(this.lnkPictureExpCol);
      this.pnlPicture.Controls.Add(this.picCover);
      this.pnlPicture.Controls.Add(this.lblPicture);
      this.pnlPicture.Location = new System.Drawing.Point(2, 211);
      this.pnlPicture.Name = "pnlPicture";
      this.pnlPicture.Size = new System.Drawing.Size(195, 196);
      this.pnlPicture.TabIndex = 8;
      this.pnlPicture.Tag = "Expanded";
      // 
      // lnkPictureExpCol
      // 
      this.lnkPictureExpCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lnkPictureExpCol.Image = global::Properties.Resources.Collapse;
      this.lnkPictureExpCol.Location = new System.Drawing.Point(171, 1);
      this.lnkPictureExpCol.Name = "lnkPictureExpCol";
      this.lnkPictureExpCol.Size = new System.Drawing.Size(18, 18);
      this.lnkPictureExpCol.TabIndex = 5;
      this.lnkPictureExpCol.Click += new System.EventHandler(this.lnkPictureExpCol_Click);
      // 
      // picCover
      // 
      this.picCover.BackColor = System.Drawing.SystemColors.ControlLight;
      this.picCover.Location = new System.Drawing.Point(6, 22);
      this.picCover.Name = "picCover";
      this.picCover.Size = new System.Drawing.Size(168, 168);
      this.picCover.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
      this.picCover.TabIndex = 1;
      this.picCover.TabStop = false;
      // 
      // lblPicture
      // 
      this.lblPicture.AutoSize = true;
      this.lblPicture.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold);
      this.lblPicture.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.lblPicture.Image = global::Properties.Resources.Picture;
      this.lblPicture.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblPicture.Location = new System.Drawing.Point(3, 1);
      this.lblPicture.Name = "lblPicture";
      this.lblPicture.Size = new System.Drawing.Size(75, 16);
      this.lblPicture.TabIndex = 0;
      this.lblPicture.Text = "     Picture";
      // 
      // pnlQuickEdit
      // 
      this.pnlQuickEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlQuickEdit.Controls.Add(this.btnQuickEditMore);
      this.pnlQuickEdit.Controls.Add(this.lnkQuickEditExpCol);
      this.pnlQuickEdit.Controls.Add(this.btnQuickEditOK);
      this.pnlQuickEdit.Controls.Add(this.txtQETitle);
      this.pnlQuickEdit.Controls.Add(this.txtQEAlbum);
      this.pnlQuickEdit.Controls.Add(this.lblQETitle);
      this.pnlQuickEdit.Controls.Add(this.lblQEAlbum);
      this.pnlQuickEdit.Controls.Add(this.cboQEArtist);
      this.pnlQuickEdit.Controls.Add(this.lblQEArtist);
      this.pnlQuickEdit.Controls.Add(this.lblQuickEdit);
      this.pnlQuickEdit.Location = new System.Drawing.Point(3, 3);
      this.pnlQuickEdit.Name = "pnlQuickEdit";
      this.pnlQuickEdit.Size = new System.Drawing.Size(195, 208);
      this.pnlQuickEdit.TabIndex = 6;
      this.pnlQuickEdit.Tag = "Expanded";
      // 
      // btnQuickEditMore
      // 
      this.btnQuickEditMore.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnQuickEditMore.Location = new System.Drawing.Point(6, 175);
      this.btnQuickEditMore.Name = "btnQuickEditMore";
      this.btnQuickEditMore.Size = new System.Drawing.Size(183, 23);
      this.btnQuickEditMore.TabIndex = 5;
      this.btnQuickEditMore.Text = "More ...";
      this.btnQuickEditMore.UseVisualStyleBackColor = true;
      this.btnQuickEditMore.Click += new System.EventHandler(this.btnQuickEditMore_Click);
      // 
      // lnkQuickEditExpCol
      // 
      this.lnkQuickEditExpCol.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
      this.lnkQuickEditExpCol.Image = global::Properties.Resources.Collapse;
      this.lnkQuickEditExpCol.Location = new System.Drawing.Point(171, 1);
      this.lnkQuickEditExpCol.Name = "lnkQuickEditExpCol";
      this.lnkQuickEditExpCol.Size = new System.Drawing.Size(18, 18);
      this.lnkQuickEditExpCol.TabIndex = 4;
      this.lnkQuickEditExpCol.Click += new System.EventHandler(this.lnkQuickEditExpCol_Click);
      // 
      // btnQuickEditOK
      // 
      this.btnQuickEditOK.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnQuickEditOK.Location = new System.Drawing.Point(6, 147);
      this.btnQuickEditOK.Name = "btnQuickEditOK";
      this.btnQuickEditOK.Size = new System.Drawing.Size(183, 23);
      this.btnQuickEditOK.TabIndex = 3;
      this.btnQuickEditOK.Text = "OK";
      this.btnQuickEditOK.UseVisualStyleBackColor = true;
      this.btnQuickEditOK.Click += new System.EventHandler(this.btnQuickEditOK_Click);
      // 
      // txtQETitle
      // 
      this.txtQETitle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtQETitle.Location = new System.Drawing.Point(6, 80);
      this.txtQETitle.Name = "txtQETitle";
      this.txtQETitle.Size = new System.Drawing.Size(183, 20);
      this.txtQETitle.TabIndex = 2;
      // 
      // txtQEAlbum
      // 
      this.txtQEAlbum.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtQEAlbum.Location = new System.Drawing.Point(6, 120);
      this.txtQEAlbum.Name = "txtQEAlbum";
      this.txtQEAlbum.Size = new System.Drawing.Size(183, 20);
      this.txtQEAlbum.TabIndex = 2;
      // 
      // lblQETitle
      // 
      this.lblQETitle.AutoSize = true;
      this.lblQETitle.Location = new System.Drawing.Point(3, 64);
      this.lblQETitle.Name = "lblQETitle";
      this.lblQETitle.Size = new System.Drawing.Size(27, 13);
      this.lblQETitle.TabIndex = 0;
      this.lblQETitle.Text = "Title";
      // 
      // lblQEAlbum
      // 
      this.lblQEAlbum.AutoSize = true;
      this.lblQEAlbum.Location = new System.Drawing.Point(3, 104);
      this.lblQEAlbum.Name = "lblQEAlbum";
      this.lblQEAlbum.Size = new System.Drawing.Size(36, 13);
      this.lblQEAlbum.TabIndex = 0;
      this.lblQEAlbum.Text = "Album";
      // 
      // cboQEArtist
      // 
      this.cboQEArtist.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.cboQEArtist.FormattingEnabled = true;
      this.cboQEArtist.Location = new System.Drawing.Point(6, 39);
      this.cboQEArtist.Name = "cboQEArtist";
      this.cboQEArtist.Size = new System.Drawing.Size(183, 21);
      this.cboQEArtist.TabIndex = 1;
      // 
      // lblQEArtist
      // 
      this.lblQEArtist.AutoSize = true;
      this.lblQEArtist.Location = new System.Drawing.Point(3, 22);
      this.lblQEArtist.Name = "lblQEArtist";
      this.lblQEArtist.Size = new System.Drawing.Size(30, 13);
      this.lblQEArtist.TabIndex = 0;
      this.lblQEArtist.Text = "Artist";
      // 
      // lblQuickEdit
      // 
      this.lblQuickEdit.AutoSize = true;
      this.lblQuickEdit.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
      this.lblQuickEdit.ForeColor = System.Drawing.SystemColors.HotTrack;
      this.lblQuickEdit.Image = global::Properties.Resources.QuickEdit;
      this.lblQuickEdit.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.lblQuickEdit.Location = new System.Drawing.Point(3, 1);
      this.lblQuickEdit.Name = "lblQuickEdit";
      this.lblQuickEdit.Size = new System.Drawing.Size(97, 16);
      this.lblQuickEdit.TabIndex = 0;
      this.lblQuickEdit.Text = "     Quick Edit";
      // 
      // GroupIcons
      // 
      this.GroupIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("GroupIcons.ImageStream")));
      this.GroupIcons.TransparentColor = System.Drawing.Color.Transparent;
      this.GroupIcons.Images.SetKeyName(0, "");
      this.GroupIcons.Images.SetKeyName(1, "");
      this.GroupIcons.Images.SetKeyName(2, "");
      this.GroupIcons.Images.SetKeyName(3, "");
      // 
      // ToolsIcons
      // 
      this.ToolsIcons.ColorDepth = System.Windows.Forms.ColorDepth.Depth32Bit;
      this.ToolsIcons.ImageSize = new System.Drawing.Size(16, 16);
      this.ToolsIcons.TransparentColor = System.Drawing.Color.Transparent;
      // 
      // ColumnHeaderIcons
      // 
      this.ColumnHeaderIcons.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ColumnHeaderIcons.ImageStream")));
      this.ColumnHeaderIcons.TransparentColor = System.Drawing.Color.Transparent;
      this.ColumnHeaderIcons.Images.SetKeyName(0, "");
      this.ColumnHeaderIcons.Images.SetKeyName(1, "");
      // 
      // Timer
      // 
      this.Timer.Enabled = true;
      this.Timer.Interval = 200;
      // 
      // EnumInfo
      // 
      this.EnumInfo.BackColor = System.Drawing.SystemColors.Info;
      this.EnumInfo.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
      this.EnumInfo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.EnumInfo.ForeColor = System.Drawing.SystemColors.InfoText;
      this.EnumInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.EnumInfo.Location = new System.Drawing.Point(550, 5);
      this.EnumInfo.Name = "EnumInfo";
      this.EnumInfo.Size = new System.Drawing.Size(144, 16);
      this.EnumInfo.TabIndex = 22;
      this.EnumInfo.Text = "Enumeration mode";
      this.EnumInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      this.EnumInfo.Visible = false;
      // 
      // errorProvider1
      // 
      this.errorProvider1.ContainerControl = this;
      // 
      // mnuDDs
      // 
      this.mnuDDs.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem,
            this.editToolStripMenuItem,
            this.viewToolStripMenuItem,
            this.iD3FunctionsToolStripMenuItem,
            this.extendedFunctionsToolStripMenuItem,
            this.analyseToolStripMenuItem,
            this.optionsToolStripMenuItem,
            this.helpToolStripMenuItem});
      this.mnuDDs.Location = new System.Drawing.Point(0, 0);
      this.mnuDDs.Name = "mnuDDs";
      this.mnuDDs.Size = new System.Drawing.Size(1178, 24);
      this.mnuDDs.TabIndex = 28;
      this.mnuDDs.Text = "menuStrip1";
      // 
      // fileToolStripMenuItem
      // 
      this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.addDirectoryToolStripMenuItem,
            this.refreshToolStripMenuItem,
            this.toolStripSeparator2,
            this.saveToolStripMenuItem,
            this.toolStripSeparator3,
            this.playToolStripMenuItem,
            this.toolStripSeparator4,
            this.moveFilesToolStripMenuItem,
            this.copyFilesToolStripMenuItem,
            this.deleteFilesToolStripMenuItem,
            this.organizeFilesToolStripMenuItem,
            this.toolStripSeparator5,
            this.openFileLocationToolStripMenuItem,
            this.removeEmptyFoldersToolStripMenuItem,
            this.renameFilefolderToolStripMenuItem,
            this.filePropertiesToolStripMenuItem,
            this.toolStripSeparator6,
            this.quitToolStripMenuItem});
      this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
      this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
      this.fileToolStripMenuItem.Text = "&File";
      // 
      // addDirectoryToolStripMenuItem
      // 
      this.addDirectoryToolStripMenuItem.Image = global::Properties.Resources.AddFolder;
      this.addDirectoryToolStripMenuItem.Name = "addDirectoryToolStripMenuItem";
      this.addDirectoryToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F8;
      this.addDirectoryToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.addDirectoryToolStripMenuItem.Text = "&Add directory";
      this.addDirectoryToolStripMenuItem.Click += new System.EventHandler(this.mnuAddFolder_Click);
      // 
      // refreshToolStripMenuItem
      // 
      this.refreshToolStripMenuItem.Image = global::Properties.Resources.Refresh;
      this.refreshToolStripMenuItem.Name = "refreshToolStripMenuItem";
      this.refreshToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F5;
      this.refreshToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.refreshToolStripMenuItem.Text = "&Refresh";
      this.refreshToolStripMenuItem.Click += new System.EventHandler(this.mnuRefresh_Click);
      // 
      // toolStripSeparator2
      // 
      this.toolStripSeparator2.Name = "toolStripSeparator2";
      this.toolStripSeparator2.Size = new System.Drawing.Size(262, 6);
      // 
      // saveToolStripMenuItem
      // 
      this.saveToolStripMenuItem.Image = global::Properties.Resources.Save;
      this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
      this.saveToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.S)));
      this.saveToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.saveToolStripMenuItem.Text = "&Save";
      this.saveToolStripMenuItem.Click += new System.EventHandler(this.mnuSave_Click);
      // 
      // toolStripSeparator3
      // 
      this.toolStripSeparator3.Name = "toolStripSeparator3";
      this.toolStripSeparator3.Size = new System.Drawing.Size(262, 6);
      // 
      // playToolStripMenuItem
      // 
      this.playToolStripMenuItem.Image = global::Properties.Resources.Play;
      this.playToolStripMenuItem.Name = "playToolStripMenuItem";
      this.playToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F9;
      this.playToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.playToolStripMenuItem.Text = "&Play";
      this.playToolStripMenuItem.Click += new System.EventHandler(this.mnuPlay_Click);
      // 
      // toolStripSeparator4
      // 
      this.toolStripSeparator4.Name = "toolStripSeparator4";
      this.toolStripSeparator4.Size = new System.Drawing.Size(262, 6);
      // 
      // moveFilesToolStripMenuItem
      // 
      this.moveFilesToolStripMenuItem.Image = global::Properties.Resources.MoveFiles;
      this.moveFilesToolStripMenuItem.Name = "moveFilesToolStripMenuItem";
      this.moveFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.B)));
      this.moveFilesToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.moveFilesToolStripMenuItem.Text = "&Move files";
      this.moveFilesToolStripMenuItem.Click += new System.EventHandler(this.moveFilesToolStripMenuItem_Click);
      // 
      // copyFilesToolStripMenuItem
      // 
      this.copyFilesToolStripMenuItem.Image = global::Properties.Resources.CopyFiles;
      this.copyFilesToolStripMenuItem.Name = "copyFilesToolStripMenuItem";
      this.copyFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Y)));
      this.copyFilesToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.copyFilesToolStripMenuItem.Text = "&Copy files";
      this.copyFilesToolStripMenuItem.Click += new System.EventHandler(this.copyFilesToolStripMenuItem_Click);
      // 
      // deleteFilesToolStripMenuItem
      // 
      this.deleteFilesToolStripMenuItem.Image = global::Properties.Resources.Delete;
      this.deleteFilesToolStripMenuItem.Name = "deleteFilesToolStripMenuItem";
      this.deleteFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.D)));
      this.deleteFilesToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.deleteFilesToolStripMenuItem.Text = "&Delete files";
      this.deleteFilesToolStripMenuItem.Click += new System.EventHandler(this.deleteFilesToolStripMenuItem_Click);
      // 
      // organizeFilesToolStripMenuItem
      // 
      this.organizeFilesToolStripMenuItem.Name = "organizeFilesToolStripMenuItem";
      this.organizeFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.O)));
      this.organizeFilesToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.organizeFilesToolStripMenuItem.Text = "&Organize files";
      this.organizeFilesToolStripMenuItem.Click += new System.EventHandler(this.organizeFilesToolStripMenuItem_Click);
      // 
      // toolStripSeparator5
      // 
      this.toolStripSeparator5.Name = "toolStripSeparator5";
      this.toolStripSeparator5.Size = new System.Drawing.Size(262, 6);
      // 
      // openFileLocationToolStripMenuItem
      // 
      this.openFileLocationToolStripMenuItem.Image = global::Properties.Resources.OpenLocation;
      this.openFileLocationToolStripMenuItem.Name = "openFileLocationToolStripMenuItem";
      this.openFileLocationToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.openFileLocationToolStripMenuItem.Text = "&Open file location";
      this.openFileLocationToolStripMenuItem.Click += new System.EventHandler(this.openFileLocationToolStripMenuItem_Click);
      // 
      // removeEmptyFoldersToolStripMenuItem
      // 
      this.removeEmptyFoldersToolStripMenuItem.Image = global::Properties.Resources.DeleteFolder;
      this.removeEmptyFoldersToolStripMenuItem.Name = "removeEmptyFoldersToolStripMenuItem";
      this.removeEmptyFoldersToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.F)));
      this.removeEmptyFoldersToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.removeEmptyFoldersToolStripMenuItem.Text = "R&emove empty folders";
      this.removeEmptyFoldersToolStripMenuItem.Click += new System.EventHandler(this.removeEmptyFoldersToolStripMenuItem_Click);
      // 
      // renameFilefolderToolStripMenuItem
      // 
      this.renameFilefolderToolStripMenuItem.Image = global::Properties.Resources.Rename;
      this.renameFilefolderToolStripMenuItem.Name = "renameFilefolderToolStripMenuItem";
      this.renameFilefolderToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F2;
      this.renameFilefolderToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.renameFilefolderToolStripMenuItem.Text = "&Rename file/folder";
      this.renameFilefolderToolStripMenuItem.Click += new System.EventHandler(this.renameFilefolderToolStripMenuItem_Click);
      // 
      // filePropertiesToolStripMenuItem
      // 
      this.filePropertiesToolStripMenuItem.Name = "filePropertiesToolStripMenuItem";
      this.filePropertiesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F11;
      this.filePropertiesToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.filePropertiesToolStripMenuItem.Text = "&File properties";
      this.filePropertiesToolStripMenuItem.Click += new System.EventHandler(this.filePropertiesToolStripMenuItem_Click);
      // 
      // toolStripSeparator6
      // 
      this.toolStripSeparator6.Name = "toolStripSeparator6";
      this.toolStripSeparator6.Size = new System.Drawing.Size(262, 6);
      // 
      // quitToolStripMenuItem
      // 
      this.quitToolStripMenuItem.Image = global::Properties.Resources.Quit;
      this.quitToolStripMenuItem.Name = "quitToolStripMenuItem";
      this.quitToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F4)));
      this.quitToolStripMenuItem.Size = new System.Drawing.Size(265, 22);
      this.quitToolStripMenuItem.Text = "&Quit";
      this.quitToolStripMenuItem.Click += new System.EventHandler(this.quitToolStripMenuItem_Click);
      // 
      // editToolStripMenuItem
      // 
      this.editToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.undoToolStripMenuItem,
            this.redoToolStripMenuItem,
            this.toolStripSeparator18,
            this.searchandReplaceToolStripMenuItem,
            this.toolStripSeparator19,
            this.swapTAGVer1EntriesToolStripMenuItem,
            this.swapTAGVer2EntriesToolStripMenuItem,
            this.toolStripSeparator20,
            this.splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem,
            this.splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem,
            this.toolStripSeparator21,
            this.copyTAGInformationToolStripMenuItem,
            this.pasteTAGInformationToolStripMenuItem});
      this.editToolStripMenuItem.Name = "editToolStripMenuItem";
      this.editToolStripMenuItem.Size = new System.Drawing.Size(39, 20);
      this.editToolStripMenuItem.Text = "&Edit";
      // 
      // undoToolStripMenuItem
      // 
      this.undoToolStripMenuItem.Enabled = false;
      this.undoToolStripMenuItem.Image = global::Properties.Resources.Undo;
      this.undoToolStripMenuItem.Name = "undoToolStripMenuItem";
      this.undoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Z)));
      this.undoToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
      this.undoToolStripMenuItem.Text = "&Undo";
      this.undoToolStripMenuItem.Click += new System.EventHandler(this.mnuUndo_Click);
      // 
      // redoToolStripMenuItem
      // 
      this.redoToolStripMenuItem.Enabled = false;
      this.redoToolStripMenuItem.Image = global::Properties.Resources.Redo;
      this.redoToolStripMenuItem.Name = "redoToolStripMenuItem";
      this.redoToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.Z)));
      this.redoToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
      this.redoToolStripMenuItem.Text = "&Redo";
      this.redoToolStripMenuItem.Click += new System.EventHandler(this.mnuRedo_Click);
      // 
      // toolStripSeparator18
      // 
      this.toolStripSeparator18.Name = "toolStripSeparator18";
      this.toolStripSeparator18.Size = new System.Drawing.Size(334, 6);
      // 
      // searchandReplaceToolStripMenuItem
      // 
      this.searchandReplaceToolStripMenuItem.Image = global::Properties.Resources.Search;
      this.searchandReplaceToolStripMenuItem.Name = "searchandReplaceToolStripMenuItem";
      this.searchandReplaceToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F3;
      this.searchandReplaceToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
      this.searchandReplaceToolStripMenuItem.Text = "&Search (and Replace)";
      this.searchandReplaceToolStripMenuItem.Click += new System.EventHandler(this.searchandReplaceToolStripMenuItem_Click);
      // 
      // toolStripSeparator19
      // 
      this.toolStripSeparator19.Name = "toolStripSeparator19";
      this.toolStripSeparator19.Size = new System.Drawing.Size(334, 6);
      // 
      // swapTAGVer1EntriesToolStripMenuItem
      // 
      this.swapTAGVer1EntriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistTitleToolStripMenuItem,
            this.artistAlbumToolStripMenuItem,
            this.titleAlbumToolStripMenuItem});
      this.swapTAGVer1EntriesToolStripMenuItem.Image = global::Properties.Resources.SwapV1;
      this.swapTAGVer1EntriesToolStripMenuItem.Name = "swapTAGVer1EntriesToolStripMenuItem";
      this.swapTAGVer1EntriesToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
      this.swapTAGVer1EntriesToolStripMenuItem.Text = "S&wap TAG Ver. 1 entries";
      // 
      // artistTitleToolStripMenuItem
      // 
      this.artistTitleToolStripMenuItem.Name = "artistTitleToolStripMenuItem";
      this.artistTitleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
      this.artistTitleToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
      this.artistTitleToolStripMenuItem.Text = "Artist <-> &Title";
      this.artistTitleToolStripMenuItem.Click += new System.EventHandler(this.artistTitleToolStripMenuItem_Click);
      // 
      // artistAlbumToolStripMenuItem
      // 
      this.artistAlbumToolStripMenuItem.Name = "artistAlbumToolStripMenuItem";
      this.artistAlbumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
      this.artistAlbumToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
      this.artistAlbumToolStripMenuItem.Text = "&Artist <-> Album";
      this.artistAlbumToolStripMenuItem.Click += new System.EventHandler(this.artistAlbumToolStripMenuItem_Click);
      // 
      // titleAlbumToolStripMenuItem
      // 
      this.titleAlbumToolStripMenuItem.Name = "titleAlbumToolStripMenuItem";
      this.titleAlbumToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
      this.titleAlbumToolStripMenuItem.Size = new System.Drawing.Size(216, 22);
      this.titleAlbumToolStripMenuItem.Text = "Title <-> Al&bum";
      this.titleAlbumToolStripMenuItem.Click += new System.EventHandler(this.titleAlbumToolStripMenuItem_Click);
      // 
      // swapTAGVer2EntriesToolStripMenuItem
      // 
      this.swapTAGVer2EntriesToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistTitleToolStripMenuItem1,
            this.artistAlbumToolStripMenuItem1,
            this.titleAlbumToolStripMenuItem1});
      this.swapTAGVer2EntriesToolStripMenuItem.Image = global::Properties.Resources.SwapV2;
      this.swapTAGVer2EntriesToolStripMenuItem.Name = "swapTAGVer2EntriesToolStripMenuItem";
      this.swapTAGVer2EntriesToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
      this.swapTAGVer2EntriesToolStripMenuItem.Text = "Sw&ap TAG Ver. 2 entries";
      // 
      // artistTitleToolStripMenuItem1
      // 
      this.artistTitleToolStripMenuItem1.Name = "artistTitleToolStripMenuItem1";
      this.artistTitleToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
      this.artistTitleToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
      this.artistTitleToolStripMenuItem1.Text = "Artist <-> &Title";
      this.artistTitleToolStripMenuItem1.Click += new System.EventHandler(this.artistTitleToolStripMenuItem1_Click);
      // 
      // artistAlbumToolStripMenuItem1
      // 
      this.artistAlbumToolStripMenuItem1.Name = "artistAlbumToolStripMenuItem1";
      this.artistAlbumToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
      this.artistAlbumToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
      this.artistAlbumToolStripMenuItem1.Text = "&Artist <-> Album";
      this.artistAlbumToolStripMenuItem1.Click += new System.EventHandler(this.artistAlbumToolStripMenuItem1_Click);
      // 
      // titleAlbumToolStripMenuItem1
      // 
      this.titleAlbumToolStripMenuItem1.Name = "titleAlbumToolStripMenuItem1";
      this.titleAlbumToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
      this.titleAlbumToolStripMenuItem1.Size = new System.Drawing.Size(216, 22);
      this.titleAlbumToolStripMenuItem1.Text = "Title <-> Al&bum";
      this.titleAlbumToolStripMenuItem1.Click += new System.EventHandler(this.titleAlbumToolStripMenuItem1_Click);
      // 
      // toolStripSeparator20
      // 
      this.toolStripSeparator20.Name = "toolStripSeparator20";
      this.toolStripSeparator20.Size = new System.Drawing.Size(334, 6);
      // 
      // splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem
      // 
      this.splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem.Name = "splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem";
      this.splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F4)));
      this.splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
      this.splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem.Text = "S&plit TAG Ver. 1 Artist into Artist and Title";
      this.splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem.Click += new System.EventHandler(this.splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem_Click);
      // 
      // splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem
      // 
      this.splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem.Name = "splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem";
      this.splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F8)));
      this.splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
      this.splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem.Text = "Sp&lit TAG Ver. 2 Artist into Artist and Title";
      this.splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem.Click += new System.EventHandler(this.splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem_Click);
      // 
      // toolStripSeparator21
      // 
      this.toolStripSeparator21.Name = "toolStripSeparator21";
      this.toolStripSeparator21.Size = new System.Drawing.Size(334, 6);
      // 
      // copyTAGInformationToolStripMenuItem
      // 
      this.copyTAGInformationToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.copyTAGVer1OnlyToolStripMenuItem,
            this.copyTAGVer2OnlyToolStripMenuItem,
            this.copyTAGVer1And2ToolStripMenuItem});
      this.copyTAGInformationToolStripMenuItem.Name = "copyTAGInformationToolStripMenuItem";
      this.copyTAGInformationToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
      this.copyTAGInformationToolStripMenuItem.Text = "&Copy TAG information";
      // 
      // copyTAGVer1OnlyToolStripMenuItem
      // 
      this.copyTAGVer1OnlyToolStripMenuItem.Name = "copyTAGVer1OnlyToolStripMenuItem";
      this.copyTAGVer1OnlyToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
      this.copyTAGVer1OnlyToolStripMenuItem.Text = "Copy TAG Ver. &1 only";
      this.copyTAGVer1OnlyToolStripMenuItem.Click += new System.EventHandler(this.copyTAGVer1OnlyToolStripMenuItem_Click);
      // 
      // copyTAGVer2OnlyToolStripMenuItem
      // 
      this.copyTAGVer2OnlyToolStripMenuItem.Name = "copyTAGVer2OnlyToolStripMenuItem";
      this.copyTAGVer2OnlyToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
      this.copyTAGVer2OnlyToolStripMenuItem.Text = "Copy TAG Ver. &2 only";
      this.copyTAGVer2OnlyToolStripMenuItem.Click += new System.EventHandler(this.copyTAGVer2OnlyToolStripMenuItem_Click);
      // 
      // copyTAGVer1And2ToolStripMenuItem
      // 
      this.copyTAGVer1And2ToolStripMenuItem.Image = global::Properties.Resources.Copy;
      this.copyTAGVer1And2ToolStripMenuItem.Name = "copyTAGVer1And2ToolStripMenuItem";
      this.copyTAGVer1And2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.C)));
      this.copyTAGVer1And2ToolStripMenuItem.Size = new System.Drawing.Size(263, 22);
      this.copyTAGVer1And2ToolStripMenuItem.Text = "&Copy TAG Ver. 1 and 2";
      this.copyTAGVer1And2ToolStripMenuItem.Click += new System.EventHandler(this.copyTAGVer1And2ToolStripMenuItem_Click);
      // 
      // pasteTAGInformationToolStripMenuItem
      // 
      this.pasteTAGInformationToolStripMenuItem.Image = global::Properties.Resources.Paste;
      this.pasteTAGInformationToolStripMenuItem.Name = "pasteTAGInformationToolStripMenuItem";
      this.pasteTAGInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)(((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.Shift) 
            | System.Windows.Forms.Keys.V)));
      this.pasteTAGInformationToolStripMenuItem.Size = new System.Drawing.Size(337, 22);
      this.pasteTAGInformationToolStripMenuItem.Text = "&Paste TAG information";
      this.pasteTAGInformationToolStripMenuItem.Click += new System.EventHandler(this.pasteTAGInformationToolStripMenuItem_Click);
      // 
      // viewToolStripMenuItem
      // 
      this.viewToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.viewTAGVer1ToolStripMenuItem,
            this.viewTAGVer2ToolStripMenuItem,
            this.toolStripSeparator7,
            this.selectallToolStripMenuItem,
            this.groupSelectionToolStripMenuItem,
            this.invertSelectionToolStripMenuItem,
            this.toolStripSeparator8,
            this.selectFilesByformatToolStripMenuItem,
            this.selectChangedFilesToolStripMenuItem,
            this.toolStripSeparator9,
            this.removeSelectedFilesFromListToolStripMenuItem});
      this.viewToolStripMenuItem.Name = "viewToolStripMenuItem";
      this.viewToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.viewToolStripMenuItem.Text = "&View";
      // 
      // viewTAGVer1ToolStripMenuItem
      // 
      this.viewTAGVer1ToolStripMenuItem.Name = "viewTAGVer1ToolStripMenuItem";
      this.viewTAGVer1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F1)));
      this.viewTAGVer1ToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
      this.viewTAGVer1ToolStripMenuItem.Text = "View TAG Ver. &1";
      this.viewTAGVer1ToolStripMenuItem.Click += new System.EventHandler(this.viewTAGVer1ToolStripMenuItem_Click);
      // 
      // viewTAGVer2ToolStripMenuItem
      // 
      this.viewTAGVer2ToolStripMenuItem.Checked = true;
      this.viewTAGVer2ToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.viewTAGVer2ToolStripMenuItem.Name = "viewTAGVer2ToolStripMenuItem";
      this.viewTAGVer2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F2)));
      this.viewTAGVer2ToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
      this.viewTAGVer2ToolStripMenuItem.Text = "View TAG Ver. &2";
      this.viewTAGVer2ToolStripMenuItem.Click += new System.EventHandler(this.viewTAGVer2ToolStripMenuItem_Click);
      // 
      // toolStripSeparator7
      // 
      this.toolStripSeparator7.Name = "toolStripSeparator7";
      this.toolStripSeparator7.Size = new System.Drawing.Size(272, 6);
      // 
      // selectallToolStripMenuItem
      // 
      this.selectallToolStripMenuItem.Image = global::Properties.Resources.SelectAll;
      this.selectallToolStripMenuItem.Name = "selectallToolStripMenuItem";
      this.selectallToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.A)));
      this.selectallToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
      this.selectallToolStripMenuItem.Text = "Select &all";
      this.selectallToolStripMenuItem.Click += new System.EventHandler(this.selectallToolStripMenuItem_Click);
      // 
      // groupSelectionToolStripMenuItem
      // 
      this.groupSelectionToolStripMenuItem.Image = global::Properties.Resources.GroupSelection;
      this.groupSelectionToolStripMenuItem.Name = "groupSelectionToolStripMenuItem";
      this.groupSelectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.G)));
      this.groupSelectionToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
      this.groupSelectionToolStripMenuItem.Text = "&Group selection";
      this.groupSelectionToolStripMenuItem.Click += new System.EventHandler(this.groupSelectionToolStripMenuItem_Click);
      // 
      // invertSelectionToolStripMenuItem
      // 
      this.invertSelectionToolStripMenuItem.Image = global::Properties.Resources.Invert;
      this.invertSelectionToolStripMenuItem.Name = "invertSelectionToolStripMenuItem";
      this.invertSelectionToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.I)));
      this.invertSelectionToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
      this.invertSelectionToolStripMenuItem.Text = "&Invert selection";
      this.invertSelectionToolStripMenuItem.Click += new System.EventHandler(this.invertSelectionToolStripMenuItem_Click);
      // 
      // toolStripSeparator8
      // 
      this.toolStripSeparator8.Name = "toolStripSeparator8";
      this.toolStripSeparator8.Size = new System.Drawing.Size(272, 6);
      // 
      // selectFilesByformatToolStripMenuItem
      // 
      this.selectFilesByformatToolStripMenuItem.Name = "selectFilesByformatToolStripMenuItem";
      this.selectFilesByformatToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F5)));
      this.selectFilesByformatToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
      this.selectFilesByformatToolStripMenuItem.Text = "Select files by &format";
      this.selectFilesByformatToolStripMenuItem.Click += new System.EventHandler(this.selectFilesByformatToolStripMenuItem_Click);
      // 
      // selectChangedFilesToolStripMenuItem
      // 
      this.selectChangedFilesToolStripMenuItem.Name = "selectChangedFilesToolStripMenuItem";
      this.selectChangedFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F6)));
      this.selectChangedFilesToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
      this.selectChangedFilesToolStripMenuItem.Text = "Select c&hanged files";
      this.selectChangedFilesToolStripMenuItem.Click += new System.EventHandler(this.selectChangedFilesToolStripMenuItem_Click);
      // 
      // toolStripSeparator9
      // 
      this.toolStripSeparator9.Name = "toolStripSeparator9";
      this.toolStripSeparator9.Size = new System.Drawing.Size(272, 6);
      // 
      // removeSelectedFilesFromListToolStripMenuItem
      // 
      this.removeSelectedFilesFromListToolStripMenuItem.Name = "removeSelectedFilesFromListToolStripMenuItem";
      this.removeSelectedFilesFromListToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.K)));
      this.removeSelectedFilesFromListToolStripMenuItem.Size = new System.Drawing.Size(275, 22);
      this.removeSelectedFilesFromListToolStripMenuItem.Text = "&Remove selected files from list";
      this.removeSelectedFilesFromListToolStripMenuItem.Click += new System.EventHandler(this.removeSelectedFilesFromListToolStripMenuItem_Click);
      // 
      // iD3FunctionsToolStripMenuItem
      // 
      this.iD3FunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.editTAGVer1ToolStripMenuItem,
            this.multipleEditTAGVer1ToolStripMenuItem,
            this.removeTAGVer1ToolStripMenuItem,
            this.filenameTAGVer1ToolStripMenuItem,
            this.tAGVer1FilenameToolStripMenuItem,
            this.toolStripSeparator17,
            this.editTAGVer2ToolStripMenuItem,
            this.multipleEditTAGVer2ToolStripMenuItem,
            this.removeTAGVer1ToolStripMenuItem1,
            this.filenameToTagV2,
            this.tAGVer2FilenameToolStripMenuItem});
      this.iD3FunctionsToolStripMenuItem.Name = "iD3FunctionsToolStripMenuItem";
      this.iD3FunctionsToolStripMenuItem.Size = new System.Drawing.Size(93, 20);
      this.iD3FunctionsToolStripMenuItem.Text = "&ID3-Functions";
      // 
      // editTAGVer1ToolStripMenuItem
      // 
      this.editTAGVer1ToolStripMenuItem.Image = global::Properties.Resources.EditV1;
      this.editTAGVer1ToolStripMenuItem.Name = "editTAGVer1ToolStripMenuItem";
      this.editTAGVer1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.E)));
      this.editTAGVer1ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
      this.editTAGVer1ToolStripMenuItem.Text = "Edit TAG Ver. &1";
      this.editTAGVer1ToolStripMenuItem.Click += new System.EventHandler(this.mnuEditV1_Click);
      // 
      // multipleEditTAGVer1ToolStripMenuItem
      // 
      this.multipleEditTAGVer1ToolStripMenuItem.Image = global::Properties.Resources.MultiEditV1;
      this.multipleEditTAGVer1ToolStripMenuItem.Name = "multipleEditTAGVer1ToolStripMenuItem";
      this.multipleEditTAGVer1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.M)));
      this.multipleEditTAGVer1ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
      this.multipleEditTAGVer1ToolStripMenuItem.Text = "&Multiple Edit TAG Ver. 1 ";
      this.multipleEditTAGVer1ToolStripMenuItem.Click += new System.EventHandler(this.mnuMultiEditV1_Click);
      // 
      // removeTAGVer1ToolStripMenuItem
      // 
      this.removeTAGVer1ToolStripMenuItem.Image = global::Properties.Resources.RemoveV1;
      this.removeTAGVer1ToolStripMenuItem.Name = "removeTAGVer1ToolStripMenuItem";
      this.removeTAGVer1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F11)));
      this.removeTAGVer1ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
      this.removeTAGVer1ToolStripMenuItem.Text = "&Remove TAG Ver. 1";
      this.removeTAGVer1ToolStripMenuItem.Click += new System.EventHandler(this.mnuRemoveV1_Click);
      // 
      // filenameTAGVer1ToolStripMenuItem
      // 
      this.filenameTAGVer1ToolStripMenuItem.Image = global::Properties.Resources.FileToTagV1;
      this.filenameTAGVer1ToolStripMenuItem.Name = "filenameTAGVer1ToolStripMenuItem";
      this.filenameTAGVer1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F)));
      this.filenameTAGVer1ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
      this.filenameTAGVer1ToolStripMenuItem.Text = "&Filename -> TAG Ver. 1";
      this.filenameTAGVer1ToolStripMenuItem.Click += new System.EventHandler(this.mnuFileToTagV2_Click);
      // 
      // tAGVer1FilenameToolStripMenuItem
      // 
      this.tAGVer1FilenameToolStripMenuItem.Image = global::Properties.Resources.TagToFileV1;
      this.tAGVer1FilenameToolStripMenuItem.Name = "tAGVer1FilenameToolStripMenuItem";
      this.tAGVer1FilenameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.T)));
      this.tAGVer1FilenameToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
      this.tAGVer1FilenameToolStripMenuItem.Text = "&TAG Ver. 1 -> Filename";
      this.tAGVer1FilenameToolStripMenuItem.Click += new System.EventHandler(this.mnuTagToFileV1_Click);
      // 
      // toolStripSeparator17
      // 
      this.toolStripSeparator17.Name = "toolStripSeparator17";
      this.toolStripSeparator17.Size = new System.Drawing.Size(241, 6);
      // 
      // editTAGVer2ToolStripMenuItem
      // 
      this.editTAGVer2ToolStripMenuItem.Image = global::Properties.Resources.EditV2;
      this.editTAGVer2ToolStripMenuItem.Name = "editTAGVer2ToolStripMenuItem";
      this.editTAGVer2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.W)));
      this.editTAGVer2ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
      this.editTAGVer2ToolStripMenuItem.Text = "Edit TAG Ver. &2";
      this.editTAGVer2ToolStripMenuItem.Click += new System.EventHandler(this.mnuEditV2_Click);
      // 
      // multipleEditTAGVer2ToolStripMenuItem
      // 
      this.multipleEditTAGVer2ToolStripMenuItem.Image = global::Properties.Resources.MultiEditV2;
      this.multipleEditTAGVer2ToolStripMenuItem.Name = "multipleEditTAGVer2ToolStripMenuItem";
      this.multipleEditTAGVer2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.N)));
      this.multipleEditTAGVer2ToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
      this.multipleEditTAGVer2ToolStripMenuItem.Text = "&Multi&ple Edit TAG Ver. 2";
      this.multipleEditTAGVer2ToolStripMenuItem.Click += new System.EventHandler(this.mnuMultiEditV2_Click);
      // 
      // removeTAGVer1ToolStripMenuItem1
      // 
      this.removeTAGVer1ToolStripMenuItem1.Image = global::Properties.Resources.RemoveV2;
      this.removeTAGVer1ToolStripMenuItem1.Name = "removeTAGVer1ToolStripMenuItem1";
      this.removeTAGVer1ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F12)));
      this.removeTAGVer1ToolStripMenuItem1.Size = new System.Drawing.Size(244, 22);
      this.removeTAGVer1ToolStripMenuItem1.Text = "Remo&ve TAG Ver. 2";
      this.removeTAGVer1ToolStripMenuItem1.Click += new System.EventHandler(this.removeTAGVer2ToolStripMenuItem2_Click);
      // 
      // filenameToTagV2
      // 
      this.filenameToTagV2.Image = global::Properties.Resources.FileToTagV2;
      this.filenameToTagV2.Name = "filenameToTagV2";
      this.filenameToTagV2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.D)));
      this.filenameToTagV2.Size = new System.Drawing.Size(244, 22);
      this.filenameToTagV2.Text = "File&name -> TAG Ver. 2";
      this.filenameToTagV2.Click += new System.EventHandler(this.mnuFileToTagV2_Click);
      // 
      // tAGVer2FilenameToolStripMenuItem
      // 
      this.tAGVer2FilenameToolStripMenuItem.Image = global::Properties.Resources.TagToFileV2;
      this.tAGVer2FilenameToolStripMenuItem.Name = "tAGVer2FilenameToolStripMenuItem";
      this.tAGVer2FilenameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.R)));
      this.tAGVer2FilenameToolStripMenuItem.Size = new System.Drawing.Size(244, 22);
      this.tAGVer2FilenameToolStripMenuItem.Text = "TA&G Ver. 2 -> Filename";
      this.tAGVer2FilenameToolStripMenuItem.Click += new System.EventHandler(this.mnuTagToFileV2_Click);
      // 
      // extendedFunctionsToolStripMenuItem
      // 
      this.extendedFunctionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.caseConversionToolStripMenuItem,
            this.transferConvertTAGsToolStripMenuItem,
            this.changeTAGVer2TextencodingToolStripMenuItem,
            this.toolStripSeparator14,
            this.queryFreeDBToolStripMenuItem,
            this.toolStripSeparator15,
            this.enumerateInfilenameToolStripMenuItem,
            this.enumerateInTAGVer1ToolStripMenuItem,
            this.enumerateInTAGVer2ToolStripMenuItem,
            this.toolStripSeparator16,
            this.createFilelistPlaylistToolStripMenuItem});
      this.extendedFunctionsToolStripMenuItem.Name = "extendedFunctionsToolStripMenuItem";
      this.extendedFunctionsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
      this.extendedFunctionsToolStripMenuItem.Size = new System.Drawing.Size(123, 20);
      this.extendedFunctionsToolStripMenuItem.Text = "E&xtended Functions";
      // 
      // caseConversionToolStripMenuItem
      // 
      this.caseConversionToolStripMenuItem.Image = global::Properties.Resources.CaseConversion;
      this.caseConversionToolStripMenuItem.Name = "caseConversionToolStripMenuItem";
      this.caseConversionToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F6;
      this.caseConversionToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
      this.caseConversionToolStripMenuItem.Text = "C&ase Conversion";
      this.caseConversionToolStripMenuItem.Click += new System.EventHandler(this.caseConversionToolStripMenuItem_Click);
      // 
      // transferConvertTAGsToolStripMenuItem
      // 
      this.transferConvertTAGsToolStripMenuItem.Image = global::Properties.Resources.TransferConvertTags;
      this.transferConvertTAGsToolStripMenuItem.Name = "transferConvertTAGsToolStripMenuItem";
      this.transferConvertTAGsToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F7;
      this.transferConvertTAGsToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
      this.transferConvertTAGsToolStripMenuItem.Text = "&Transfer/Convert TAGs";
      this.transferConvertTAGsToolStripMenuItem.Click += new System.EventHandler(this.transferConvertTAGsToolStripMenuItem_Click);
      // 
      // changeTAGVer2TextencodingToolStripMenuItem
      // 
      this.changeTAGVer2TextencodingToolStripMenuItem.Name = "changeTAGVer2TextencodingToolStripMenuItem";
      this.changeTAGVer2TextencodingToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
      this.changeTAGVer2TextencodingToolStripMenuItem.Text = "Change TAG Ver. 2 text &encoding";
      this.changeTAGVer2TextencodingToolStripMenuItem.Click += new System.EventHandler(this.changeTAGVer2TextencodingToolStripMenuItem_Click);
      // 
      // toolStripSeparator14
      // 
      this.toolStripSeparator14.Name = "toolStripSeparator14";
      this.toolStripSeparator14.Size = new System.Drawing.Size(253, 6);
      // 
      // queryFreeDBToolStripMenuItem
      // 
      this.queryFreeDBToolStripMenuItem.Image = global::Properties.Resources.QueryFreeDB;
      this.queryFreeDBToolStripMenuItem.Name = "queryFreeDBToolStripMenuItem";
      this.queryFreeDBToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F4;
      this.queryFreeDBToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
      this.queryFreeDBToolStripMenuItem.Text = "&Query FreeDB";
      this.queryFreeDBToolStripMenuItem.Click += new System.EventHandler(this.queryFreeDBToolStripMenuItem_Click);
      // 
      // toolStripSeparator15
      // 
      this.toolStripSeparator15.Name = "toolStripSeparator15";
      this.toolStripSeparator15.Size = new System.Drawing.Size(253, 6);
      // 
      // enumerateInfilenameToolStripMenuItem
      // 
      this.enumerateInfilenameToolStripMenuItem.Name = "enumerateInfilenameToolStripMenuItem";
      this.enumerateInfilenameToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F9)));
      this.enumerateInfilenameToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
      this.enumerateInfilenameToolStripMenuItem.Text = "Enumerate in &filename";
      this.enumerateInfilenameToolStripMenuItem.Click += new System.EventHandler(this.enumerateInfilenameToolStripMenuItem_Click);
      // 
      // enumerateInTAGVer1ToolStripMenuItem
      // 
      this.enumerateInTAGVer1ToolStripMenuItem.Name = "enumerateInTAGVer1ToolStripMenuItem";
      this.enumerateInTAGVer1ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F11)));
      this.enumerateInTAGVer1ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
      this.enumerateInTAGVer1ToolStripMenuItem.Text = "Enumerate in TAG Ver. &1";
      this.enumerateInTAGVer1ToolStripMenuItem.Click += new System.EventHandler(this.enumerateInTAGVer1ToolStripMenuItem_Click);
      // 
      // enumerateInTAGVer2ToolStripMenuItem
      // 
      this.enumerateInTAGVer2ToolStripMenuItem.Name = "enumerateInTAGVer2ToolStripMenuItem";
      this.enumerateInTAGVer2ToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F12)));
      this.enumerateInTAGVer2ToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
      this.enumerateInTAGVer2ToolStripMenuItem.Text = "Enumerate in TAG Ver. &2";
      this.enumerateInTAGVer2ToolStripMenuItem.Click += new System.EventHandler(this.enumerateInTAGVer2ToolStripMenuItem_Click);
      // 
      // toolStripSeparator16
      // 
      this.toolStripSeparator16.Name = "toolStripSeparator16";
      this.toolStripSeparator16.Size = new System.Drawing.Size(253, 6);
      // 
      // createFilelistPlaylistToolStripMenuItem
      // 
      this.createFilelistPlaylistToolStripMenuItem.Image = global::Properties.Resources.Playlist;
      this.createFilelistPlaylistToolStripMenuItem.Name = "createFilelistPlaylistToolStripMenuItem";
      this.createFilelistPlaylistToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.L)));
      this.createFilelistPlaylistToolStripMenuItem.Size = new System.Drawing.Size(256, 22);
      this.createFilelistPlaylistToolStripMenuItem.Text = "&Create Filelist / Playlist";
      this.createFilelistPlaylistToolStripMenuItem.Click += new System.EventHandler(this.createFilelistPlaylistToolStripMenuItem_Click);
      // 
      // analyseToolStripMenuItem
      // 
      this.analyseToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.findduplicateFilesToolStripMenuItem,
            this.compareFilenameWthTAGInformationToolStripMenuItem,
            this.toolStripSeparator10,
            this.selectDuplicateFilesToolStripMenuItem,
            this.selectmismatchingFilenameTAGFilesToolStripMenuItem});
      this.analyseToolStripMenuItem.Name = "analyseToolStripMenuItem";
      this.analyseToolStripMenuItem.Size = new System.Drawing.Size(60, 20);
      this.analyseToolStripMenuItem.Text = "Anal&yse";
      // 
      // findduplicateFilesToolStripMenuItem
      // 
      this.findduplicateFilesToolStripMenuItem.Name = "findduplicateFilesToolStripMenuItem";
      this.findduplicateFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F7)));
      this.findduplicateFilesToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
      this.findduplicateFilesToolStripMenuItem.Text = "Find &duplicate files";
      this.findduplicateFilesToolStripMenuItem.Click += new System.EventHandler(this.findduplicateFilesToolStripMenuItem_Click);
      // 
      // compareFilenameWthTAGInformationToolStripMenuItem
      // 
      this.compareFilenameWthTAGInformationToolStripMenuItem.Name = "compareFilenameWthTAGInformationToolStripMenuItem";
      this.compareFilenameWthTAGInformationToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Control | System.Windows.Forms.Keys.F8)));
      this.compareFilenameWthTAGInformationToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
      this.compareFilenameWthTAGInformationToolStripMenuItem.Text = "&Compare filename wth TAG information";
      this.compareFilenameWthTAGInformationToolStripMenuItem.Click += new System.EventHandler(this.compareFilenameWthTAGInformationToolStripMenuItem_Click);
      // 
      // toolStripSeparator10
      // 
      this.toolStripSeparator10.Name = "toolStripSeparator10";
      this.toolStripSeparator10.Size = new System.Drawing.Size(343, 6);
      // 
      // selectDuplicateFilesToolStripMenuItem
      // 
      this.selectDuplicateFilesToolStripMenuItem.Name = "selectDuplicateFilesToolStripMenuItem";
      this.selectDuplicateFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F7)));
      this.selectDuplicateFilesToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
      this.selectDuplicateFilesToolStripMenuItem.Text = "&Select duplicate files";
      this.selectDuplicateFilesToolStripMenuItem.Click += new System.EventHandler(this.selectDuplicateFilesToolStripMenuItem_Click);
      // 
      // selectmismatchingFilenameTAGFilesToolStripMenuItem
      // 
      this.selectmismatchingFilenameTAGFilesToolStripMenuItem.Name = "selectmismatchingFilenameTAGFilesToolStripMenuItem";
      this.selectmismatchingFilenameTAGFilesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F8)));
      this.selectmismatchingFilenameTAGFilesToolStripMenuItem.Size = new System.Drawing.Size(346, 22);
      this.selectmismatchingFilenameTAGFilesToolStripMenuItem.Text = "Select &mismatching filename <--> TAG files";
      this.selectmismatchingFilenameTAGFilesToolStripMenuItem.Click += new System.EventHandler(this.selectmismatchingFilenameTAGFilesToolStripMenuItem_Click);
      // 
      // optionsToolStripMenuItem
      // 
      this.optionsToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.scanSubdirectoriesToolStripMenuItem,
            this.quickFilenameEditingToolStripMenuItem,
            this.synchronizeVer1AndVer2EditingToolStripMenuItem,
            this.toolStripSeparator11,
            this.editLibrariesToolStripMenuItem,
            this.toolStripSeparator12,
            this.preferencesToolStripMenuItem,
            this.toolStripSeparator13,
            this.cboLanguage});
      this.optionsToolStripMenuItem.Name = "optionsToolStripMenuItem";
      this.optionsToolStripMenuItem.Size = new System.Drawing.Size(61, 20);
      this.optionsToolStripMenuItem.Text = "&Options";
      // 
      // scanSubdirectoriesToolStripMenuItem
      // 
      this.scanSubdirectoriesToolStripMenuItem.Name = "scanSubdirectoriesToolStripMenuItem";
      this.scanSubdirectoriesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F9)));
      this.scanSubdirectoriesToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
      this.scanSubdirectoriesToolStripMenuItem.Text = "&Scan subdirectories";
      this.scanSubdirectoriesToolStripMenuItem.Click += new System.EventHandler(this.scanSubdirectoriesToolStripMenuItem_Click);
      // 
      // quickFilenameEditingToolStripMenuItem
      // 
      this.quickFilenameEditingToolStripMenuItem.Checked = true;
      this.quickFilenameEditingToolStripMenuItem.CheckState = System.Windows.Forms.CheckState.Checked;
      this.quickFilenameEditingToolStripMenuItem.Name = "quickFilenameEditingToolStripMenuItem";
      this.quickFilenameEditingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F10)));
      this.quickFilenameEditingToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
      this.quickFilenameEditingToolStripMenuItem.Text = "&Quick filename editing";
      this.quickFilenameEditingToolStripMenuItem.Click += new System.EventHandler(this.quickFilenameEditingToolStripMenuItem_Click);
      // 
      // synchronizeVer1AndVer2EditingToolStripMenuItem
      // 
      this.synchronizeVer1AndVer2EditingToolStripMenuItem.Name = "synchronizeVer1AndVer2EditingToolStripMenuItem";
      this.synchronizeVer1AndVer2EditingToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F11)));
      this.synchronizeVer1AndVer2EditingToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
      this.synchronizeVer1AndVer2EditingToolStripMenuItem.Text = "Synchronize Ver. 1 and Ver. 2 editing";
      this.synchronizeVer1AndVer2EditingToolStripMenuItem.Click += new System.EventHandler(this.synchronizeVer1AndVer2EditingToolStripMenuItem_Click);
      // 
      // toolStripSeparator11
      // 
      this.toolStripSeparator11.Name = "toolStripSeparator11";
      this.toolStripSeparator11.Size = new System.Drawing.Size(308, 6);
      // 
      // editLibrariesToolStripMenuItem
      // 
      this.editLibrariesToolStripMenuItem.Image = global::Properties.Resources.HelpBook;
      this.editLibrariesToolStripMenuItem.Name = "editLibrariesToolStripMenuItem";
      this.editLibrariesToolStripMenuItem.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Alt | System.Windows.Forms.Keys.F12)));
      this.editLibrariesToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
      this.editLibrariesToolStripMenuItem.Text = "Edit &Libraries";
      this.editLibrariesToolStripMenuItem.Click += new System.EventHandler(this.editLibrariesToolStripMenuItem_Click);
      // 
      // toolStripSeparator12
      // 
      this.toolStripSeparator12.Name = "toolStripSeparator12";
      this.toolStripSeparator12.Size = new System.Drawing.Size(308, 6);
      // 
      // preferencesToolStripMenuItem
      // 
      this.preferencesToolStripMenuItem.Image = global::Properties.Resources.Preferences;
      this.preferencesToolStripMenuItem.Name = "preferencesToolStripMenuItem";
      this.preferencesToolStripMenuItem.ShortcutKeys = System.Windows.Forms.Keys.F12;
      this.preferencesToolStripMenuItem.Size = new System.Drawing.Size(311, 22);
      this.preferencesToolStripMenuItem.Text = "Preferences ...";
      this.preferencesToolStripMenuItem.Click += new System.EventHandler(this.preferencesToolStripMenuItem_Click);
      // 
      // toolStripSeparator13
      // 
      this.toolStripSeparator13.Name = "toolStripSeparator13";
      this.toolStripSeparator13.Size = new System.Drawing.Size(308, 6);
      // 
      // cboLanguage
      // 
      this.cboLanguage.AutoSize = false;
      this.cboLanguage.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cboLanguage.DropDownWidth = 250;
      this.cboLanguage.Items.AddRange(new object[] {
            "English",
            "Deutsch"});
      this.cboLanguage.Name = "cboLanguage";
      this.cboLanguage.Size = new System.Drawing.Size(250, 23);
      this.cboLanguage.Click += new System.EventHandler(this.cboLanguage_Click);
      // 
      // helpToolStripMenuItem
      // 
      this.helpToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.helpToolStripMenuItem1,
            this.shortcutsToolStripMenuItem,
            this.toolStripSeparator1,
            this.aboutToolStripMenuItem});
      this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
      this.helpToolStripMenuItem.Size = new System.Drawing.Size(44, 20);
      this.helpToolStripMenuItem.Text = "&Help";
      // 
      // helpToolStripMenuItem1
      // 
      this.helpToolStripMenuItem1.Image = global::Properties.Resources.Question;
      this.helpToolStripMenuItem1.Name = "helpToolStripMenuItem1";
      this.helpToolStripMenuItem1.ShortcutKeys = System.Windows.Forms.Keys.F1;
      this.helpToolStripMenuItem1.Size = new System.Drawing.Size(136, 22);
      this.helpToolStripMenuItem1.Text = "&Help ...";
      this.helpToolStripMenuItem1.Click += new System.EventHandler(this.helpToolStripMenuItem1_Click);
      // 
      // shortcutsToolStripMenuItem
      // 
      this.shortcutsToolStripMenuItem.Name = "shortcutsToolStripMenuItem";
      this.shortcutsToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
      this.shortcutsToolStripMenuItem.Text = "&Shortcuts ...";
      this.shortcutsToolStripMenuItem.Click += new System.EventHandler(this.shortcutsToolStripMenuItem_Click);
      // 
      // toolStripSeparator1
      // 
      this.toolStripSeparator1.Name = "toolStripSeparator1";
      this.toolStripSeparator1.Size = new System.Drawing.Size(133, 6);
      // 
      // aboutToolStripMenuItem
      // 
      this.aboutToolStripMenuItem.Image = global::Properties.Resources.Info;
      this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
      this.aboutToolStripMenuItem.Size = new System.Drawing.Size(136, 22);
      this.aboutToolStripMenuItem.Text = "&About ...";
      this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
      // 
      // mnuExtended
      // 
      this.mnuExtended.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubCaseConv,
            this.mnubTransferConvertTags,
            this.sepButtons6,
            this.mnubSwapV1,
            this.mnubSwapV2,
            this.sepButtons7,
            this.mnubQueryFreeDB,
            this.sepButtons8,
            this.mnubEnumerate,
            this.tsmiDecrease,
            this.mnutEnumerateCounter,
            this.tsmiIncrease,
            this.sepButtons9,
            this.tsmiArtist,
            this.tsmiTitle,
            this.tsmiAlbum,
            this.tsmiClearFilter});
      this.mnuExtended.Location = new System.Drawing.Point(0, 51);
      this.mnuExtended.Name = "mnuExtended";
      this.mnuExtended.Size = new System.Drawing.Size(1178, 27);
      this.mnuExtended.TabIndex = 29;
      // 
      // mnubCaseConv
      // 
      this.mnubCaseConv.Image = global::Properties.Resources.CaseConversion;
      this.mnubCaseConv.Name = "mnubCaseConv";
      this.mnubCaseConv.Size = new System.Drawing.Size(28, 23);
      this.mnubCaseConv.Click += new System.EventHandler(this.mnubCaseConv_Click);
      // 
      // mnubTransferConvertTags
      // 
      this.mnubTransferConvertTags.Image = global::Properties.Resources.TransferConvertTags;
      this.mnubTransferConvertTags.Name = "mnubTransferConvertTags";
      this.mnubTransferConvertTags.Size = new System.Drawing.Size(28, 23);
      this.mnubTransferConvertTags.Click += new System.EventHandler(this.mnubTransferConvertTags_Click);
      // 
      // sepButtons6
      // 
      this.sepButtons6.Name = "sepButtons6";
      this.sepButtons6.Size = new System.Drawing.Size(6, 23);
      // 
      // mnubSwapV1
      // 
      this.mnubSwapV1.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistTitleToolStripMenuItem2,
            this.artistAlbumToolStripMenuItem2,
            this.titleAlbumToolStripMenuItem2});
      this.mnubSwapV1.Image = global::Properties.Resources.SwapV1;
      this.mnubSwapV1.Name = "mnubSwapV1";
      this.mnubSwapV1.Size = new System.Drawing.Size(28, 23);
      // 
      // artistTitleToolStripMenuItem2
      // 
      this.artistTitleToolStripMenuItem2.Name = "artistTitleToolStripMenuItem2";
      this.artistTitleToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F1)));
      this.artistTitleToolStripMenuItem2.Size = new System.Drawing.Size(216, 22);
      this.artistTitleToolStripMenuItem2.Text = "Artist <-> Title";
      this.artistTitleToolStripMenuItem2.Click += new System.EventHandler(this.artistTitleToolStripMenuItem2_Click);
      // 
      // artistAlbumToolStripMenuItem2
      // 
      this.artistAlbumToolStripMenuItem2.Name = "artistAlbumToolStripMenuItem2";
      this.artistAlbumToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F2)));
      this.artistAlbumToolStripMenuItem2.Size = new System.Drawing.Size(216, 22);
      this.artistAlbumToolStripMenuItem2.Text = "Artist <-> Album";
      this.artistAlbumToolStripMenuItem2.Click += new System.EventHandler(this.artistAlbumToolStripMenuItem2_Click);
      // 
      // titleAlbumToolStripMenuItem2
      // 
      this.titleAlbumToolStripMenuItem2.Name = "titleAlbumToolStripMenuItem2";
      this.titleAlbumToolStripMenuItem2.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F3)));
      this.titleAlbumToolStripMenuItem2.Size = new System.Drawing.Size(216, 22);
      this.titleAlbumToolStripMenuItem2.Text = "Title <-> Album";
      this.titleAlbumToolStripMenuItem2.Click += new System.EventHandler(this.titleAlbumToolStripMenuItem2_Click);
      // 
      // mnubSwapV2
      // 
      this.mnubSwapV2.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.artistTitleToolStripMenuItem3,
            this.artistAlbumToolStripMenuItem3,
            this.titleAlbumToolStripMenuItem3});
      this.mnubSwapV2.Image = global::Properties.Resources.SwapV2;
      this.mnubSwapV2.Name = "mnubSwapV2";
      this.mnubSwapV2.Size = new System.Drawing.Size(28, 23);
      // 
      // artistTitleToolStripMenuItem3
      // 
      this.artistTitleToolStripMenuItem3.Name = "artistTitleToolStripMenuItem3";
      this.artistTitleToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F5)));
      this.artistTitleToolStripMenuItem3.Size = new System.Drawing.Size(216, 22);
      this.artistTitleToolStripMenuItem3.Text = "Artist <-> Title";
      this.artistTitleToolStripMenuItem3.Click += new System.EventHandler(this.artistTitleToolStripMenuItem3_Click);
      // 
      // artistAlbumToolStripMenuItem3
      // 
      this.artistAlbumToolStripMenuItem3.Name = "artistAlbumToolStripMenuItem3";
      this.artistAlbumToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F6)));
      this.artistAlbumToolStripMenuItem3.Size = new System.Drawing.Size(216, 22);
      this.artistAlbumToolStripMenuItem3.Text = "Artist <-> Album";
      this.artistAlbumToolStripMenuItem3.Click += new System.EventHandler(this.artistAlbumToolStripMenuItem3_Click);
      // 
      // titleAlbumToolStripMenuItem3
      // 
      this.titleAlbumToolStripMenuItem3.Name = "titleAlbumToolStripMenuItem3";
      this.titleAlbumToolStripMenuItem3.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F7)));
      this.titleAlbumToolStripMenuItem3.Size = new System.Drawing.Size(216, 22);
      this.titleAlbumToolStripMenuItem3.Text = "Title <-> Album";
      this.titleAlbumToolStripMenuItem3.Click += new System.EventHandler(this.titleAlbumToolStripMenuItem3_Click);
      // 
      // sepButtons7
      // 
      this.sepButtons7.Name = "sepButtons7";
      this.sepButtons7.Size = new System.Drawing.Size(6, 23);
      // 
      // mnubQueryFreeDB
      // 
      this.mnubQueryFreeDB.Image = global::Properties.Resources.QueryFreeDB;
      this.mnubQueryFreeDB.Name = "mnubQueryFreeDB";
      this.mnubQueryFreeDB.Size = new System.Drawing.Size(28, 23);
      this.mnubQueryFreeDB.Click += new System.EventHandler(this.mnubQueryFreeDB_Click);
      // 
      // sepButtons8
      // 
      this.sepButtons8.Name = "sepButtons8";
      this.sepButtons8.Size = new System.Drawing.Size(6, 23);
      // 
      // mnubEnumerate
      // 
      this.mnubEnumerate.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.enumerateInFilenameToolStripMenuItem1,
            this.enumerateInTAGVer1ToolStripMenuItem1,
            this.enumerateInTAGVer2ToolStripMenuItem1});
      this.mnubEnumerate.Image = global::Properties.Resources.Enumerate;
      this.mnubEnumerate.Name = "mnubEnumerate";
      this.mnubEnumerate.Size = new System.Drawing.Size(28, 23);
      // 
      // enumerateInFilenameToolStripMenuItem1
      // 
      this.enumerateInFilenameToolStripMenuItem1.Name = "enumerateInFilenameToolStripMenuItem1";
      this.enumerateInFilenameToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F9)));
      this.enumerateInFilenameToolStripMenuItem1.Size = new System.Drawing.Size(256, 22);
      this.enumerateInFilenameToolStripMenuItem1.Text = "Enumerate in filename";
      this.enumerateInFilenameToolStripMenuItem1.Click += new System.EventHandler(this.enumerateInFilenameToolStripMenuItem1_Click);
      // 
      // enumerateInTAGVer1ToolStripMenuItem1
      // 
      this.enumerateInTAGVer1ToolStripMenuItem1.Name = "enumerateInTAGVer1ToolStripMenuItem1";
      this.enumerateInTAGVer1ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F11)));
      this.enumerateInTAGVer1ToolStripMenuItem1.Size = new System.Drawing.Size(256, 22);
      this.enumerateInTAGVer1ToolStripMenuItem1.Text = "Enumerate in TAG Ver. 1";
      this.enumerateInTAGVer1ToolStripMenuItem1.Click += new System.EventHandler(this.enumerateInTAGVer1ToolStripMenuItem1_Click);
      // 
      // enumerateInTAGVer2ToolStripMenuItem1
      // 
      this.enumerateInTAGVer2ToolStripMenuItem1.Name = "enumerateInTAGVer2ToolStripMenuItem1";
      this.enumerateInTAGVer2ToolStripMenuItem1.ShortcutKeys = ((System.Windows.Forms.Keys)((System.Windows.Forms.Keys.Shift | System.Windows.Forms.Keys.F12)));
      this.enumerateInTAGVer2ToolStripMenuItem1.Size = new System.Drawing.Size(256, 22);
      this.enumerateInTAGVer2ToolStripMenuItem1.Text = "Enumerate in TAG Ver. 2";
      this.enumerateInTAGVer2ToolStripMenuItem1.Click += new System.EventHandler(this.enumerateInTAGVer2ToolStripMenuItem1_Click);
      // 
      // tsmiDecrease
      // 
      this.tsmiDecrease.Image = global::Properties.Resources.Decrease;
      this.tsmiDecrease.Name = "tsmiDecrease";
      this.tsmiDecrease.Size = new System.Drawing.Size(28, 23);
      this.tsmiDecrease.Click += new System.EventHandler(this.tsmiDecrease_Click);
      // 
      // mnutEnumerateCounter
      // 
      this.mnutEnumerateCounter.BorderStyle = System.Windows.Forms.BorderStyle.None;
      this.mnutEnumerateCounter.Font = new System.Drawing.Font("Segoe UI", 9F, System.Drawing.FontStyle.Bold);
      this.mnutEnumerateCounter.Name = "mnutEnumerateCounter";
      this.mnutEnumerateCounter.ReadOnly = true;
      this.mnutEnumerateCounter.Size = new System.Drawing.Size(23, 23);
      this.mnutEnumerateCounter.Text = "1";
      this.mnutEnumerateCounter.TextBoxTextAlign = System.Windows.Forms.HorizontalAlignment.Center;
      // 
      // tsmiIncrease
      // 
      this.tsmiIncrease.Image = global::Properties.Resources.Increase;
      this.tsmiIncrease.Name = "tsmiIncrease";
      this.tsmiIncrease.Size = new System.Drawing.Size(28, 23);
      this.tsmiIncrease.Click += new System.EventHandler(this.tsmiIncrease_Click);
      // 
      // sepButtons9
      // 
      this.sepButtons9.Name = "sepButtons9";
      this.sepButtons9.Size = new System.Drawing.Size(6, 23);
      // 
      // tsmiArtist
      // 
      this.tsmiArtist.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubArtistFilterA,
            this.bToolStripMenuItem,
            this.cToolStripMenuItem,
            this.dToolStripMenuItem,
            this.eToolStripMenuItem,
            this.fToolStripMenuItem,
            this.gToolStripMenuItem,
            this.hToolStripMenuItem,
            this.iToolStripMenuItem,
            this.jToolStripMenuItem,
            this.kToolStripMenuItem,
            this.lToolStripMenuItem,
            this.mToolStripMenuItem,
            this.nToolStripMenuItem,
            this.oToolStripMenuItem,
            this.pToolStripMenuItem,
            this.qToolStripMenuItem,
            this.rToolStripMenuItem,
            this.sToolStripMenuItem,
            this.tToolStripMenuItem,
            this.uToolStripMenuItem,
            this.vToolStripMenuItem,
            this.wToolStripMenuItem,
            this.xToolStripMenuItem,
            this.yToolStripMenuItem,
            this.zToolStripMenuItem,
            this.toolStripMenuItem2,
            this.toolStripMenuItem3,
            this.toolStripMenuItem4});
      this.tsmiArtist.Image = global::Properties.Resources.Filter;
      this.tsmiArtist.Name = "tsmiArtist";
      this.tsmiArtist.Size = new System.Drawing.Size(63, 23);
      this.tsmiArtist.Text = "Artist";
      // 
      // mnubArtistFilterA
      // 
      this.mnubArtistFilterA.Name = "mnubArtistFilterA";
      this.mnubArtistFilterA.Size = new System.Drawing.Size(85, 22);
      this.mnubArtistFilterA.Text = "A";
      this.mnubArtistFilterA.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // bToolStripMenuItem
      // 
      this.bToolStripMenuItem.Name = "bToolStripMenuItem";
      this.bToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.bToolStripMenuItem.Text = "B";
      this.bToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // cToolStripMenuItem
      // 
      this.cToolStripMenuItem.Name = "cToolStripMenuItem";
      this.cToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.cToolStripMenuItem.Text = "C";
      this.cToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // dToolStripMenuItem
      // 
      this.dToolStripMenuItem.Name = "dToolStripMenuItem";
      this.dToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.dToolStripMenuItem.Text = "D";
      this.dToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // eToolStripMenuItem
      // 
      this.eToolStripMenuItem.Name = "eToolStripMenuItem";
      this.eToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.eToolStripMenuItem.Text = "E";
      this.eToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // fToolStripMenuItem
      // 
      this.fToolStripMenuItem.Name = "fToolStripMenuItem";
      this.fToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.fToolStripMenuItem.Text = "F";
      this.fToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // gToolStripMenuItem
      // 
      this.gToolStripMenuItem.Name = "gToolStripMenuItem";
      this.gToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.gToolStripMenuItem.Text = "G";
      this.gToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // hToolStripMenuItem
      // 
      this.hToolStripMenuItem.Name = "hToolStripMenuItem";
      this.hToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.hToolStripMenuItem.Text = "H";
      this.hToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // iToolStripMenuItem
      // 
      this.iToolStripMenuItem.Name = "iToolStripMenuItem";
      this.iToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.iToolStripMenuItem.Text = "I";
      this.iToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // jToolStripMenuItem
      // 
      this.jToolStripMenuItem.Name = "jToolStripMenuItem";
      this.jToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.jToolStripMenuItem.Text = "J";
      this.jToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // kToolStripMenuItem
      // 
      this.kToolStripMenuItem.Name = "kToolStripMenuItem";
      this.kToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.kToolStripMenuItem.Text = "K";
      this.kToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // lToolStripMenuItem
      // 
      this.lToolStripMenuItem.Name = "lToolStripMenuItem";
      this.lToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.lToolStripMenuItem.Text = "L";
      this.lToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // mToolStripMenuItem
      // 
      this.mToolStripMenuItem.Name = "mToolStripMenuItem";
      this.mToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.mToolStripMenuItem.Text = "M";
      this.mToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // nToolStripMenuItem
      // 
      this.nToolStripMenuItem.Name = "nToolStripMenuItem";
      this.nToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.nToolStripMenuItem.Text = "N";
      this.nToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // oToolStripMenuItem
      // 
      this.oToolStripMenuItem.Name = "oToolStripMenuItem";
      this.oToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.oToolStripMenuItem.Text = "O";
      this.oToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // pToolStripMenuItem
      // 
      this.pToolStripMenuItem.Name = "pToolStripMenuItem";
      this.pToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.pToolStripMenuItem.Text = "P";
      this.pToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // qToolStripMenuItem
      // 
      this.qToolStripMenuItem.Name = "qToolStripMenuItem";
      this.qToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.qToolStripMenuItem.Text = "Q";
      this.qToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // rToolStripMenuItem
      // 
      this.rToolStripMenuItem.Name = "rToolStripMenuItem";
      this.rToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.rToolStripMenuItem.Text = "R";
      this.rToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // sToolStripMenuItem
      // 
      this.sToolStripMenuItem.Name = "sToolStripMenuItem";
      this.sToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.sToolStripMenuItem.Text = "S";
      this.sToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // tToolStripMenuItem
      // 
      this.tToolStripMenuItem.Name = "tToolStripMenuItem";
      this.tToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.tToolStripMenuItem.Text = "T";
      this.tToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // uToolStripMenuItem
      // 
      this.uToolStripMenuItem.Name = "uToolStripMenuItem";
      this.uToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.uToolStripMenuItem.Text = "U";
      this.uToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // vToolStripMenuItem
      // 
      this.vToolStripMenuItem.Name = "vToolStripMenuItem";
      this.vToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.vToolStripMenuItem.Text = "V";
      this.vToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // wToolStripMenuItem
      // 
      this.wToolStripMenuItem.Name = "wToolStripMenuItem";
      this.wToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.wToolStripMenuItem.Text = "W";
      this.wToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // xToolStripMenuItem
      // 
      this.xToolStripMenuItem.Name = "xToolStripMenuItem";
      this.xToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.xToolStripMenuItem.Text = "X";
      this.xToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // yToolStripMenuItem
      // 
      this.yToolStripMenuItem.Name = "yToolStripMenuItem";
      this.yToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.yToolStripMenuItem.Text = "Y";
      this.yToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // zToolStripMenuItem
      // 
      this.zToolStripMenuItem.Name = "zToolStripMenuItem";
      this.zToolStripMenuItem.Size = new System.Drawing.Size(85, 22);
      this.zToolStripMenuItem.Text = "Z";
      this.zToolStripMenuItem.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // toolStripMenuItem2
      // 
      this.toolStripMenuItem2.Name = "toolStripMenuItem2";
      this.toolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.toolStripMenuItem2.Text = "#";
      this.toolStripMenuItem2.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // toolStripMenuItem3
      // 
      this.toolStripMenuItem3.Name = "toolStripMenuItem3";
      this.toolStripMenuItem3.Size = new System.Drawing.Size(85, 22);
      this.toolStripMenuItem3.Text = "\'\'";
      this.toolStripMenuItem3.Click += new System.EventHandler(this.mnubArtistFilter_Click);
      // 
      // toolStripMenuItem4
      // 
      this.toolStripMenuItem4.Name = "toolStripMenuItem4";
      this.toolStripMenuItem4.Size = new System.Drawing.Size(85, 22);
      this.toolStripMenuItem4.Text = "@";
      // 
      // tsmiTitle
      // 
      this.tsmiTitle.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubTitleFilterA,
            this.bToolStripMenuItem1,
            this.cToolStripMenuItem1,
            this.dToolStripMenuItem1,
            this.eToolStripMenuItem1,
            this.fToolStripMenuItem1,
            this.gToolStripMenuItem1,
            this.hToolStripMenuItem1,
            this.iToolStripMenuItem1,
            this.jToolStripMenuItem1,
            this.kToolStripMenuItem1,
            this.lToolStripMenuItem1,
            this.mToolStripMenuItem1,
            this.nToolStripMenuItem1,
            this.oToolStripMenuItem1,
            this.pToolStripMenuItem1,
            this.qToolStripMenuItem1,
            this.rToolStripMenuItem1,
            this.sToolStripMenuItem1,
            this.tToolStripMenuItem1,
            this.uToolStripMenuItem1,
            this.vToolStripMenuItem1,
            this.wToolStripMenuItem1,
            this.xToolStripMenuItem1,
            this.yToolStripMenuItem1,
            this.zToolStripMenuItem1,
            this.toolStripMenuItem5,
            this.toolStripMenuItem6});
      this.tsmiTitle.Image = global::Properties.Resources.Filter;
      this.tsmiTitle.Name = "tsmiTitle";
      this.tsmiTitle.Size = new System.Drawing.Size(57, 23);
      this.tsmiTitle.Text = "Title";
      // 
      // mnubTitleFilterA
      // 
      this.mnubTitleFilterA.Name = "mnubTitleFilterA";
      this.mnubTitleFilterA.Size = new System.Drawing.Size(85, 22);
      this.mnubTitleFilterA.Text = "A";
      this.mnubTitleFilterA.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // bToolStripMenuItem1
      // 
      this.bToolStripMenuItem1.Name = "bToolStripMenuItem1";
      this.bToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.bToolStripMenuItem1.Text = "B";
      this.bToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // cToolStripMenuItem1
      // 
      this.cToolStripMenuItem1.Name = "cToolStripMenuItem1";
      this.cToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.cToolStripMenuItem1.Text = "C";
      this.cToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // dToolStripMenuItem1
      // 
      this.dToolStripMenuItem1.Name = "dToolStripMenuItem1";
      this.dToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.dToolStripMenuItem1.Text = "D";
      this.dToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // eToolStripMenuItem1
      // 
      this.eToolStripMenuItem1.Name = "eToolStripMenuItem1";
      this.eToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.eToolStripMenuItem1.Text = "E";
      this.eToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // fToolStripMenuItem1
      // 
      this.fToolStripMenuItem1.Name = "fToolStripMenuItem1";
      this.fToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.fToolStripMenuItem1.Text = "F";
      this.fToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // gToolStripMenuItem1
      // 
      this.gToolStripMenuItem1.Name = "gToolStripMenuItem1";
      this.gToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.gToolStripMenuItem1.Text = "G";
      this.gToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // hToolStripMenuItem1
      // 
      this.hToolStripMenuItem1.Name = "hToolStripMenuItem1";
      this.hToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.hToolStripMenuItem1.Text = "H";
      this.hToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // iToolStripMenuItem1
      // 
      this.iToolStripMenuItem1.Name = "iToolStripMenuItem1";
      this.iToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.iToolStripMenuItem1.Text = "I";
      this.iToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // jToolStripMenuItem1
      // 
      this.jToolStripMenuItem1.Name = "jToolStripMenuItem1";
      this.jToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.jToolStripMenuItem1.Text = "J";
      this.jToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // kToolStripMenuItem1
      // 
      this.kToolStripMenuItem1.Name = "kToolStripMenuItem1";
      this.kToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.kToolStripMenuItem1.Text = "K";
      this.kToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // lToolStripMenuItem1
      // 
      this.lToolStripMenuItem1.Name = "lToolStripMenuItem1";
      this.lToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.lToolStripMenuItem1.Text = "L";
      this.lToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // mToolStripMenuItem1
      // 
      this.mToolStripMenuItem1.Name = "mToolStripMenuItem1";
      this.mToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.mToolStripMenuItem1.Text = "M";
      this.mToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // nToolStripMenuItem1
      // 
      this.nToolStripMenuItem1.Name = "nToolStripMenuItem1";
      this.nToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.nToolStripMenuItem1.Text = "N";
      this.nToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // oToolStripMenuItem1
      // 
      this.oToolStripMenuItem1.Name = "oToolStripMenuItem1";
      this.oToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.oToolStripMenuItem1.Text = "O";
      this.oToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // pToolStripMenuItem1
      // 
      this.pToolStripMenuItem1.Name = "pToolStripMenuItem1";
      this.pToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.pToolStripMenuItem1.Text = "P";
      this.pToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // qToolStripMenuItem1
      // 
      this.qToolStripMenuItem1.Name = "qToolStripMenuItem1";
      this.qToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.qToolStripMenuItem1.Text = "Q";
      this.qToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // rToolStripMenuItem1
      // 
      this.rToolStripMenuItem1.Name = "rToolStripMenuItem1";
      this.rToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.rToolStripMenuItem1.Text = "R";
      this.rToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // sToolStripMenuItem1
      // 
      this.sToolStripMenuItem1.Name = "sToolStripMenuItem1";
      this.sToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.sToolStripMenuItem1.Text = "S";
      this.sToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // tToolStripMenuItem1
      // 
      this.tToolStripMenuItem1.Name = "tToolStripMenuItem1";
      this.tToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.tToolStripMenuItem1.Text = "T";
      this.tToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // uToolStripMenuItem1
      // 
      this.uToolStripMenuItem1.Name = "uToolStripMenuItem1";
      this.uToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.uToolStripMenuItem1.Text = "U";
      this.uToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // vToolStripMenuItem1
      // 
      this.vToolStripMenuItem1.Name = "vToolStripMenuItem1";
      this.vToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.vToolStripMenuItem1.Text = "V";
      this.vToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // wToolStripMenuItem1
      // 
      this.wToolStripMenuItem1.Name = "wToolStripMenuItem1";
      this.wToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.wToolStripMenuItem1.Text = "W";
      this.wToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // xToolStripMenuItem1
      // 
      this.xToolStripMenuItem1.Name = "xToolStripMenuItem1";
      this.xToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.xToolStripMenuItem1.Text = "X";
      this.xToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // yToolStripMenuItem1
      // 
      this.yToolStripMenuItem1.Name = "yToolStripMenuItem1";
      this.yToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.yToolStripMenuItem1.Text = "Y";
      this.yToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // zToolStripMenuItem1
      // 
      this.zToolStripMenuItem1.Name = "zToolStripMenuItem1";
      this.zToolStripMenuItem1.Size = new System.Drawing.Size(85, 22);
      this.zToolStripMenuItem1.Text = "Z";
      this.zToolStripMenuItem1.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // toolStripMenuItem5
      // 
      this.toolStripMenuItem5.Name = "toolStripMenuItem5";
      this.toolStripMenuItem5.Size = new System.Drawing.Size(85, 22);
      this.toolStripMenuItem5.Text = "#";
      this.toolStripMenuItem5.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // toolStripMenuItem6
      // 
      this.toolStripMenuItem6.Name = "toolStripMenuItem6";
      this.toolStripMenuItem6.Size = new System.Drawing.Size(85, 22);
      this.toolStripMenuItem6.Text = "\'\'";
      this.toolStripMenuItem6.Click += new System.EventHandler(this.mnubTitleFilter_Click);
      // 
      // tsmiAlbum
      // 
      this.tsmiAlbum.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.mnubAlbumFilterA,
            this.bToolStripMenuItem2,
            this.cToolStripMenuItem2,
            this.dToolStripMenuItem2,
            this.eToolStripMenuItem2,
            this.fToolStripMenuItem2,
            this.gToolStripMenuItem2,
            this.hToolStripMenuItem2,
            this.iToolStripMenuItem2,
            this.jToolStripMenuItem2,
            this.kToolStripMenuItem2,
            this.lToolStripMenuItem2,
            this.mToolStripMenuItem2,
            this.nToolStripMenuItem2,
            this.oToolStripMenuItem2,
            this.pToolStripMenuItem2,
            this.qToolStripMenuItem2,
            this.rToolStripMenuItem2,
            this.sToolStripMenuItem2,
            this.tToolStripMenuItem2,
            this.uToolStripMenuItem2,
            this.vToolStripMenuItem2,
            this.wToolStripMenuItem2,
            this.xToolStripMenuItem2,
            this.yToolStripMenuItem2,
            this.zToolStripMenuItem2,
            this.toolStripMenuItem7,
            this.toolStripMenuItem8});
      this.tsmiAlbum.Image = global::Properties.Resources.Filter;
      this.tsmiAlbum.Name = "tsmiAlbum";
      this.tsmiAlbum.Size = new System.Drawing.Size(71, 23);
      this.tsmiAlbum.Text = "Album";
      // 
      // mnubAlbumFilterA
      // 
      this.mnubAlbumFilterA.Name = "mnubAlbumFilterA";
      this.mnubAlbumFilterA.Size = new System.Drawing.Size(85, 22);
      this.mnubAlbumFilterA.Text = "A";
      this.mnubAlbumFilterA.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // bToolStripMenuItem2
      // 
      this.bToolStripMenuItem2.Name = "bToolStripMenuItem2";
      this.bToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.bToolStripMenuItem2.Text = "B";
      this.bToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // cToolStripMenuItem2
      // 
      this.cToolStripMenuItem2.Name = "cToolStripMenuItem2";
      this.cToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.cToolStripMenuItem2.Text = "C";
      this.cToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // dToolStripMenuItem2
      // 
      this.dToolStripMenuItem2.Name = "dToolStripMenuItem2";
      this.dToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.dToolStripMenuItem2.Text = "D";
      this.dToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // eToolStripMenuItem2
      // 
      this.eToolStripMenuItem2.Name = "eToolStripMenuItem2";
      this.eToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.eToolStripMenuItem2.Text = "E";
      this.eToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // fToolStripMenuItem2
      // 
      this.fToolStripMenuItem2.Name = "fToolStripMenuItem2";
      this.fToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.fToolStripMenuItem2.Text = "F";
      this.fToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // gToolStripMenuItem2
      // 
      this.gToolStripMenuItem2.Name = "gToolStripMenuItem2";
      this.gToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.gToolStripMenuItem2.Text = "G";
      this.gToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // hToolStripMenuItem2
      // 
      this.hToolStripMenuItem2.Name = "hToolStripMenuItem2";
      this.hToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.hToolStripMenuItem2.Text = "H";
      this.hToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // iToolStripMenuItem2
      // 
      this.iToolStripMenuItem2.Name = "iToolStripMenuItem2";
      this.iToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.iToolStripMenuItem2.Text = "I";
      this.iToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // jToolStripMenuItem2
      // 
      this.jToolStripMenuItem2.Name = "jToolStripMenuItem2";
      this.jToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.jToolStripMenuItem2.Text = "J";
      this.jToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // kToolStripMenuItem2
      // 
      this.kToolStripMenuItem2.Name = "kToolStripMenuItem2";
      this.kToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.kToolStripMenuItem2.Text = "K";
      this.kToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // lToolStripMenuItem2
      // 
      this.lToolStripMenuItem2.Name = "lToolStripMenuItem2";
      this.lToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.lToolStripMenuItem2.Text = "L";
      this.lToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // mToolStripMenuItem2
      // 
      this.mToolStripMenuItem2.Name = "mToolStripMenuItem2";
      this.mToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.mToolStripMenuItem2.Text = "M";
      this.mToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // nToolStripMenuItem2
      // 
      this.nToolStripMenuItem2.Name = "nToolStripMenuItem2";
      this.nToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.nToolStripMenuItem2.Text = "N";
      this.nToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // oToolStripMenuItem2
      // 
      this.oToolStripMenuItem2.Name = "oToolStripMenuItem2";
      this.oToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.oToolStripMenuItem2.Text = "O";
      this.oToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // pToolStripMenuItem2
      // 
      this.pToolStripMenuItem2.Name = "pToolStripMenuItem2";
      this.pToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.pToolStripMenuItem2.Text = "P";
      this.pToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // qToolStripMenuItem2
      // 
      this.qToolStripMenuItem2.Name = "qToolStripMenuItem2";
      this.qToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.qToolStripMenuItem2.Text = "Q";
      this.qToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // rToolStripMenuItem2
      // 
      this.rToolStripMenuItem2.Name = "rToolStripMenuItem2";
      this.rToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.rToolStripMenuItem2.Text = "R";
      this.rToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // sToolStripMenuItem2
      // 
      this.sToolStripMenuItem2.Name = "sToolStripMenuItem2";
      this.sToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.sToolStripMenuItem2.Text = "S";
      this.sToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // tToolStripMenuItem2
      // 
      this.tToolStripMenuItem2.Name = "tToolStripMenuItem2";
      this.tToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.tToolStripMenuItem2.Text = "T";
      this.tToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // uToolStripMenuItem2
      // 
      this.uToolStripMenuItem2.Name = "uToolStripMenuItem2";
      this.uToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.uToolStripMenuItem2.Text = "U";
      this.uToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // vToolStripMenuItem2
      // 
      this.vToolStripMenuItem2.Name = "vToolStripMenuItem2";
      this.vToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.vToolStripMenuItem2.Text = "V";
      this.vToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // wToolStripMenuItem2
      // 
      this.wToolStripMenuItem2.Name = "wToolStripMenuItem2";
      this.wToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.wToolStripMenuItem2.Text = "W";
      this.wToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // xToolStripMenuItem2
      // 
      this.xToolStripMenuItem2.Name = "xToolStripMenuItem2";
      this.xToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.xToolStripMenuItem2.Text = "X";
      this.xToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // yToolStripMenuItem2
      // 
      this.yToolStripMenuItem2.Name = "yToolStripMenuItem2";
      this.yToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.yToolStripMenuItem2.Text = "Y";
      this.yToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // zToolStripMenuItem2
      // 
      this.zToolStripMenuItem2.Name = "zToolStripMenuItem2";
      this.zToolStripMenuItem2.Size = new System.Drawing.Size(85, 22);
      this.zToolStripMenuItem2.Text = "Z";
      this.zToolStripMenuItem2.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // toolStripMenuItem7
      // 
      this.toolStripMenuItem7.Name = "toolStripMenuItem7";
      this.toolStripMenuItem7.Size = new System.Drawing.Size(85, 22);
      this.toolStripMenuItem7.Text = "#";
      this.toolStripMenuItem7.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // toolStripMenuItem8
      // 
      this.toolStripMenuItem8.Name = "toolStripMenuItem8";
      this.toolStripMenuItem8.Size = new System.Drawing.Size(85, 22);
      this.toolStripMenuItem8.Text = "\'\'";
      this.toolStripMenuItem8.Click += new System.EventHandler(this.mnubAlbumFilter_Click);
      // 
      // tsmiClearFilter
      // 
      this.tsmiClearFilter.Image = global::Properties.Resources.ClearFilter;
      this.tsmiClearFilter.Name = "tsmiClearFilter";
      this.tsmiClearFilter.Size = new System.Drawing.Size(28, 23);
      this.tsmiClearFilter.Click += new System.EventHandler(this.tsmiClearFilter_Click);
      // 
      // sepButtons1
      // 
      this.sepButtons1.Name = "sepButtons1";
      this.sepButtons1.Size = new System.Drawing.Size(6, 23);
      // 
      // sepButtons2
      // 
      this.sepButtons2.Name = "sepButtons2";
      this.sepButtons2.Size = new System.Drawing.Size(6, 23);
      // 
      // sepButtons3
      // 
      this.sepButtons3.Name = "sepButtons3";
      this.sepButtons3.Size = new System.Drawing.Size(6, 23);
      // 
      // sepButtons4
      // 
      this.sepButtons4.Name = "sepButtons4";
      this.sepButtons4.Size = new System.Drawing.Size(6, 23);
      // 
      // sepButtons5
      // 
      this.sepButtons5.Name = "sepButtons5";
      this.sepButtons5.Size = new System.Drawing.Size(6, 23);
      // 
      // mnuBtns
      // 
      this.mnuBtns.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.btnAddFolder,
            this.btnSave,
            this.btnPlay,
            this.sepButtons1,
            this.btnRefresh,
            this.sepButtons2,
            this.btnUndo,
            this.btnRedo,
            this.sepButtons3,
            this.btnEditV1,
            this.btnMultiEditV1,
            this.btnRemoveV1,
            this.btnFileToTagV1,
            this.btnTagToFileV1,
            this.sepButtons4,
            this.btnSwitchV1V2,
            this.sepButtons5,
            this.btnEditV2,
            this.btnMultiEditV2,
            this.btnRemoveV2,
            this.btnFileToTagV2,
            this.btnTagToFileV2});
      this.mnuBtns.Location = new System.Drawing.Point(0, 24);
      this.mnuBtns.Name = "mnuBtns";
      this.mnuBtns.Size = new System.Drawing.Size(1178, 27);
      this.mnuBtns.TabIndex = 29;
      this.mnuBtns.Text = "mnuBtns";
      // 
      // btnAddFolder
      // 
      this.btnAddFolder.Image = global::Properties.Resources.AddFolder;
      this.btnAddFolder.Name = "btnAddFolder";
      this.btnAddFolder.Padding = new System.Windows.Forms.Padding(3, 0, 3, 0);
      this.btnAddFolder.Size = new System.Drawing.Size(26, 23);
      this.btnAddFolder.Click += new System.EventHandler(this.mnuAddFolder_Click);
      // 
      // btnSave
      // 
      this.btnSave.Image = ((System.Drawing.Image)(resources.GetObject("btnSave.Image")));
      this.btnSave.Name = "btnSave";
      this.btnSave.Size = new System.Drawing.Size(28, 23);
      this.btnSave.Click += new System.EventHandler(this.mnuSave_Click);
      // 
      // btnPlay
      // 
      this.btnPlay.Image = ((System.Drawing.Image)(resources.GetObject("btnPlay.Image")));
      this.btnPlay.Name = "btnPlay";
      this.btnPlay.Size = new System.Drawing.Size(28, 23);
      this.btnPlay.Click += new System.EventHandler(this.mnuPlay_Click);
      // 
      // btnRefresh
      // 
      this.btnRefresh.Image = ((System.Drawing.Image)(resources.GetObject("btnRefresh.Image")));
      this.btnRefresh.Name = "btnRefresh";
      this.btnRefresh.Size = new System.Drawing.Size(28, 23);
      this.btnRefresh.Click += new System.EventHandler(this.mnuRefresh_Click);
      // 
      // btnUndo
      // 
      this.btnUndo.Image = ((System.Drawing.Image)(resources.GetObject("btnUndo.Image")));
      this.btnUndo.Name = "btnUndo";
      this.btnUndo.Size = new System.Drawing.Size(28, 23);
      this.btnUndo.Click += new System.EventHandler(this.mnuUndo_Click);
      // 
      // btnRedo
      // 
      this.btnRedo.Image = ((System.Drawing.Image)(resources.GetObject("btnRedo.Image")));
      this.btnRedo.Name = "btnRedo";
      this.btnRedo.Size = new System.Drawing.Size(28, 23);
      this.btnRedo.Click += new System.EventHandler(this.mnuRedo_Click);
      // 
      // btnEditV1
      // 
      this.btnEditV1.Image = ((System.Drawing.Image)(resources.GetObject("btnEditV1.Image")));
      this.btnEditV1.Name = "btnEditV1";
      this.btnEditV1.Size = new System.Drawing.Size(28, 23);
      this.btnEditV1.Click += new System.EventHandler(this.mnuEditV1_Click);
      // 
      // btnMultiEditV1
      // 
      this.btnMultiEditV1.Image = ((System.Drawing.Image)(resources.GetObject("btnMultiEditV1.Image")));
      this.btnMultiEditV1.Name = "btnMultiEditV1";
      this.btnMultiEditV1.Size = new System.Drawing.Size(28, 23);
      this.btnMultiEditV1.Click += new System.EventHandler(this.mnuMultiEditV1_Click);
      // 
      // btnRemoveV1
      // 
      this.btnRemoveV1.Image = ((System.Drawing.Image)(resources.GetObject("btnRemoveV1.Image")));
      this.btnRemoveV1.Name = "btnRemoveV1";
      this.btnRemoveV1.Size = new System.Drawing.Size(28, 23);
      this.btnRemoveV1.Click += new System.EventHandler(this.mnuRemoveV1_Click);
      // 
      // btnFileToTagV1
      // 
      this.btnFileToTagV1.Image = ((System.Drawing.Image)(resources.GetObject("btnFileToTagV1.Image")));
      this.btnFileToTagV1.Name = "btnFileToTagV1";
      this.btnFileToTagV1.Size = new System.Drawing.Size(28, 23);
      this.btnFileToTagV1.Click += new System.EventHandler(this.mnuFileToTagV1_Click);
      // 
      // btnTagToFileV1
      // 
      this.btnTagToFileV1.Image = ((System.Drawing.Image)(resources.GetObject("btnTagToFileV1.Image")));
      this.btnTagToFileV1.Name = "btnTagToFileV1";
      this.btnTagToFileV1.Size = new System.Drawing.Size(28, 23);
      this.btnTagToFileV1.Click += new System.EventHandler(this.mnuTagToFileV1_Click);
      // 
      // btnSwitchV1V2
      // 
      this.btnSwitchV1V2.Image = ((System.Drawing.Image)(resources.GetObject("btnSwitchV1V2.Image")));
      this.btnSwitchV1V2.Name = "btnSwitchV1V2";
      this.btnSwitchV1V2.Size = new System.Drawing.Size(133, 23);
      this.btnSwitchV1V2.Text = "Shown Tag Version";
      this.btnSwitchV1V2.Click += new System.EventHandler(this.btnSwitchV1V2_Click);
      // 
      // btnEditV2
      // 
      this.btnEditV2.Image = global::Properties.Resources.EditV2;
      this.btnEditV2.Name = "btnEditV2";
      this.btnEditV2.Size = new System.Drawing.Size(28, 23);
      this.btnEditV2.Click += new System.EventHandler(this.mnuEditV2_Click);
      // 
      // btnMultiEditV2
      // 
      this.btnMultiEditV2.Image = global::Properties.Resources.MultiEditV2;
      this.btnMultiEditV2.Name = "btnMultiEditV2";
      this.btnMultiEditV2.Size = new System.Drawing.Size(28, 23);
      this.btnMultiEditV2.Click += new System.EventHandler(this.mnuMultiEditV2_Click);
      // 
      // btnRemoveV2
      // 
      this.btnRemoveV2.Image = global::Properties.Resources.RemoveV2;
      this.btnRemoveV2.Name = "btnRemoveV2";
      this.btnRemoveV2.Size = new System.Drawing.Size(28, 23);
      this.btnRemoveV2.Click += new System.EventHandler(this.mnuRemoveV2_Click);
      // 
      // btnFileToTagV2
      // 
      this.btnFileToTagV2.Image = global::Properties.Resources.FileToTagV2;
      this.btnFileToTagV2.Name = "btnFileToTagV2";
      this.btnFileToTagV2.Size = new System.Drawing.Size(28, 23);
      this.btnFileToTagV2.Click += new System.EventHandler(this.mnuFileToTagV2_Click);
      // 
      // btnTagToFileV2
      // 
      this.btnTagToFileV2.Image = global::Properties.Resources.TagToFileV2;
      this.btnTagToFileV2.Name = "btnTagToFileV2";
      this.btnTagToFileV2.Size = new System.Drawing.Size(28, 23);
      this.btnTagToFileV2.Click += new System.EventHandler(this.mnuTagToFileV2_Click);
      // 
      // statusStrip1
      // 
      this.statusStrip1.AllowMerge = false;
      this.statusStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.lblNumber,
            this.lblPath,
            this.lblVersion,
            this.lblLength,
            this.lblSubDirs,
            this.lblProgress,
            this.StatusProgressBar});
      this.statusStrip1.Location = new System.Drawing.Point(0, 842);
      this.statusStrip1.Name = "statusStrip1";
      this.statusStrip1.Size = new System.Drawing.Size(1178, 22);
      this.statusStrip1.TabIndex = 30;
      this.statusStrip1.Text = "statusStrip1";
      // 
      // lblNumber
      // 
      this.lblNumber.AutoSize = false;
      this.lblNumber.Name = "lblNumber";
      this.lblNumber.Size = new System.Drawing.Size(220, 17);
      this.lblNumber.Text = "lblNumber";
      this.lblNumber.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblPath
      // 
      this.lblPath.Name = "lblPath";
      this.lblPath.Size = new System.Drawing.Size(281, 17);
      this.lblPath.Spring = true;
      this.lblPath.Text = "lblPath";
      this.lblPath.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblVersion
      // 
      this.lblVersion.AutoSize = false;
      this.lblVersion.Name = "lblVersion";
      this.lblVersion.Size = new System.Drawing.Size(110, 17);
      this.lblVersion.Text = "lblVersion";
      this.lblVersion.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblLength
      // 
      this.lblLength.AutoSize = false;
      this.lblLength.Name = "lblLength";
      this.lblLength.Size = new System.Drawing.Size(160, 17);
      this.lblLength.Text = "lblLength";
      this.lblLength.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblSubDirs
      // 
      this.lblSubDirs.AutoSize = false;
      this.lblSubDirs.Name = "lblSubDirs";
      this.lblSubDirs.Size = new System.Drawing.Size(140, 17);
      this.lblSubDirs.Text = "lblSubDirs";
      this.lblSubDirs.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // lblProgress
      // 
      this.lblProgress.AutoSize = false;
      this.lblProgress.Name = "lblProgress";
      this.lblProgress.Size = new System.Drawing.Size(150, 17);
      this.lblProgress.Text = "lblProgress";
      this.lblProgress.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
      // 
      // StatusProgressBar
      // 
      this.StatusProgressBar.AutoSize = false;
      this.StatusProgressBar.Name = "StatusProgressBar";
      this.StatusProgressBar.Size = new System.Drawing.Size(100, 16);
      // 
      // frmMain
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.ClientSize = new System.Drawing.Size(1178, 864);
      this.Controls.Add(this.spltQuickInfo);
      this.Controls.Add(this.EnumInfo);
      this.Controls.Add(this.mnuExtended);
      this.Controls.Add(this.mnuBtns);
      this.Controls.Add(this.mnuDDs);
      this.Controls.Add(this.statusStrip1);
      this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
      this.MainMenuStrip = this.mnuDDs;
      this.Name = "frmMain";
      this.Text = "ID3-TagIT";
      this.spltQuickInfo.Panel1.ResumeLayout(false);
      this.spltQuickInfo.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.spltQuickInfo)).EndInit();
      this.spltQuickInfo.ResumeLayout(false);
      this.spltTop.Panel1.ResumeLayout(false);
      this.spltTop.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.spltTop)).EndInit();
      this.spltTop.ResumeLayout(false);
      this.tabControl1.ResumeLayout(false);
      this.tabFolders.ResumeLayout(false);
      this.tabFavorites.ResumeLayout(false);
      this.spltMiddle.Panel1.ResumeLayout(false);
      this.spltMiddle.Panel2.ResumeLayout(false);
      ((System.ComponentModel.ISupportInitialize)(this.spltMiddle)).EndInit();
      this.spltMiddle.ResumeLayout(false);
      this.ctxRightClick.ResumeLayout(false);
      this.errContext.ResumeLayout(false);
      this.pnlTools.ResumeLayout(false);
      this.pnlTools.PerformLayout();
      this.pnlInformation.ResumeLayout(false);
      this.pnlInformation.PerformLayout();
      this.pnlPicture.ResumeLayout(false);
      this.pnlPicture.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.picCover)).EndInit();
      this.pnlQuickEdit.ResumeLayout(false);
      this.pnlQuickEdit.PerformLayout();
      ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
      this.mnuDDs.ResumeLayout(false);
      this.mnuDDs.PerformLayout();
      this.mnuExtended.ResumeLayout(false);
      this.mnuExtended.PerformLayout();
      this.mnuBtns.ResumeLayout(false);
      this.mnuBtns.PerformLayout();
      this.statusStrip1.ResumeLayout(false);
      this.statusStrip1.PerformLayout();
      this.ResumeLayout(false);
      this.PerformLayout();

    }

    public frmMain()
    {
      base.Load += new EventHandler(this.frmMain_Load);
      base.Closing += new CancelEventHandler(this.frmMain_Closing);
      this.colHFilename = new ColumnHeader();
      this.colHSubDir = new ColumnHeader();
      this.colHTAGVer1 = new ColumnHeader();
      this.colHTAGVer2 = new ColumnHeader();
      this.colHArtist = new ColumnHeader();
      this.colHTitle = new ColumnHeader();
      this.colHAlbum = new ColumnHeader();
      this.colHTrack = new ColumnHeader();
      this.colHPosMedia = new ColumnHeader();
      this.colHComment = new ColumnHeader();
      this.colHGenre = new ColumnHeader();
      this.colHYear = new ColumnHeader();
      this.colHRating = new ColumnHeader();
      this.colHDuration = new ColumnHeader();
      this.colHBitrate = new ColumnHeader();
      this.colHVBR = new ColumnHeader();
      this.colHSamplerate = new ColumnHeader();
      this.colHChannel = new ColumnHeader();
      this.colHVersion = new ColumnHeader();
      this.colHDate = new ColumnHeader();
      this.colHComposer = new ColumnHeader();
      this.colHFileSize = new ColumnHeader();
      this.colHBPM = new ColumnHeader();
      this.colHPicCount = new ColumnHeader();
      this.colHAudioCheckSum = new ColumnHeader();
      this.colHCreateDate = new ColumnHeader();
      this.colHErrFile = new ColumnHeader();
      this.colHErrMsg = new ColumnHeader();
      this.vbytVersionToShow = Declarations.objSettings.VersionToShow;
      this.LastSortedColumn = -1;
      this.SortedColumn = 0;
      this.vstrFilter = "*";
      this.vbytFilterIndex = 0xff;
      this.vbytSelTimerCount = 0;
      this.vintSelTimerCount = 0;
      this.vbytFolderRenameCount = 0;
      this.vbooClosing = false;
      this.vbooStartUp = true;
      this.vbooRefreshFlag = false;
      this.vbooFolderRename = false;
      this.vstrFolderRenameOldPath = "";
      this.vstrFolderRenameNewPath = "";
      this.alstCopyPaste = new ArrayList();
      this.vintEnumCount = Declarations.objSettings.FilenumberStart;
      this.vintHelpCount = 0;
      this.InitializeComponent();
    }

    #endregion

    private ContextMenuStrip ctxRightClick;
    private ToolStripMenuItem ctxRightTag1;
    private ToolStripMenuItem ctxRightTag2;
    private ToolStripSeparator sepRight1;
    private ToolStripMenuItem ctxRightSwap1;
    private ToolStripMenuItem ctxRightSwap2;
    private ToolStripSeparator sepRight2;
    private ToolStripMenuItem ctxRightPlay;
    private ToolStripSeparator sepRight3;
    private ToolStripMenuItem ctxRightOpen;
    private ToolStripMenuItem ctxRightRename;
    private ToolStripSeparator sepRight4;
    private ToolStripMenuItem ctxRightMove;
    private ToolStripMenuItem ctxRightCopy;
    private ToolStripMenuItem ctxRightDelete;
    private ToolStripSeparator sepRight5;
    private ToolStripMenuItem ctxRightCopyTAG;
    private ToolStripMenuItem ctxRightPasteTAG;
    private ToolStripMenuItem editTAGVer1ToolStripMenuItem1;
    private ToolStripMenuItem multipleEditTAGVer1ToolStripMenuItem1;
    private ToolStripMenuItem removeTAGVer1;
    private ToolStripMenuItem filenameTAGVer1ToolStripMenuItem1;
    private ToolStripMenuItem tAGVer1FilenameToolStripMenuItem1;
    private ToolStripMenuItem editTAGVer2ToolStripMenuItem1;
    private ToolStripMenuItem multipleEditTAGVer2ToolStripMenuItem1;
    private ToolStripMenuItem removeTAGVer2ToolStripMenuItem;
    private ToolStripMenuItem filenameTAGVer2ToolStripMenuItem;
    private ToolStripMenuItem tAGVer2FilenameToolStripMenuItem1;
    private ToolStripMenuItem artistTitleToolStripMenuItem5;
    private ToolStripMenuItem artistAlbumToolStripMenuItem5;
    private ToolStripMenuItem titleAlbumToolStripMenuItem5;
    private ToolStripMenuItem artistTitleToolStripMenuItem4;
    private ToolStripMenuItem artistAlbumToolStripMenuItem4;
    private ToolStripMenuItem titleAlbumToolStripMenuItem4;
    private ToolStripMenuItem copyTAGVer1OnlyToolStripMenuItem1;
    private ToolStripMenuItem copyTAGVer2OnlyToolStripMenuItem1;
    private ToolStripMenuItem copyTAGVer1And2ToolStripMenuItem1;
  }
}