using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmMain : Form
  {
    #region Designer

    private SplitContainer spltTop;
    private SplitContainer spltQuickInfo;
    private ArrayList alstCopyPaste;
    private ErrorProvider errorProvider1;
    private IContainer components;
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

    #region Events

    private void btnQuickEditOK_Click(object sender, EventArgs e)
    {
      Form form;
      frmProgress.Callback callback;
      ArrayList list = new ArrayList();

      this.MP3View.BeginUpdate();

      if (this.vbytVersionToShow == 1)
      {
        form = this;
        callback = new frmProgress.Callback(this.Multi1CB);
        frmProgress progress = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback);
        progress.SetStateMultiple();
        progress.List = list;
        progress.ShowDialog(this);
      }
      else
      {
        form = this;
        callback = new frmProgress.Callback(this.Multi2CB);
        frmProgress progress2 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback);
        progress2.SetStateMultiple();
        progress2.List = list;
        progress2.ShowDialog(this);
      }

      this.MP3View.EndUpdate();

      if (list.Count > 0)
      {
        Declarations.UNDOList.Add(list);
        this.UnDoEnable(true, true);
      }
    }

    private void btnQuickEditMore_Click(object sender, EventArgs e)
    {
      frmMain main;
      if (this.vbytVersionToShow == 1)
      {
        if (this.MP3View.SelectedItems.Count == 1)
        {
          if (this.MP3View.SelectedItems.Count == 0)
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
          else
          {
            main = this;
            new frmTAG1(ref main).ShowDialog(this);
          }
        }
        else if (this.MP3View.SelectedItems.Count > 1)
        {
          if (this.MP3View.SelectedItems.Count == 0)
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
          else
          {
            main = this;
            new frmTAG1Multi(ref main).ShowDialog(this);
          }
        }
      }
      else if (this.vbytVersionToShow == 2)
      {
        if (this.MP3View.SelectedItems.Count == 1)
        {
          if (this.MP3View.SelectedItems.Count == 0)
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
          else
          {
            main = this;
            new frmTAG2(ref main).ShowDialog(this);
          }
        }
        else if (this.MP3View.SelectedItems.Count > 1)
        {
          if (this.MP3View.SelectedItems.Count == 0)
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
          else
          {
            main = this;
            new frmTAG2Multi(ref main).ShowDialog(this);
          }
        }
      }
    }

    //public DevComponents.DotNetBar.DotNetBarManager DotNetBarManager;
    //this.DotNetBarManager = new DevComponents.DotNetBar.DotNetBarManager(this.components);
    // 
    // DotNetBarManager
    // 
    //this.DotNetBarManager.AllowUserBarCustomize = false;
    //this.DotNetBarManager.DefinitionName = "ID3-TagIT.MenuBars.xml";
    //this.DotNetBarManager.ParentForm = this;
    //this.DotNetBarManager.ShowShortcutKeysInToolTips = true;
    //this.DotNetBarManager.Style = DevComponents.DotNetBar.eDotNetBarStyle.Office2003;
    //this.DotNetBarManager.TopDockSite = null;
    //this.DotNetBarManager.ItemClick += new System.EventHandler(this.DotNetBarManager_ItemClick);
    //    private void DotNetBarManager_ItemClick(object sender, EventArgs e)
    //    {
    //      bool flag2 = false;
    //      BaseItem item = (BaseItem)sender;

    //      string name = item.Name;

    //      if (StringType.StrCmp(name, "mnubtnRefresh", false) != 0)
    //      {
    //        if (StringType.StrCmp(name, "mnubtnOrganizeFiles", false) != 0)
    //        {
    //          ButtonItem item23 = null;

    //          if ((StringType.StrCmp(name, "mnubtnEnumFilename", false) == 0) || (StringType.StrCmp(name, "mnubtnEnumV1", false) == 0) || (StringType.StrCmp(name, "mnubtnEnumV2", false) == 0))
    //          {
    //            ((ButtonItem)item).Checked ^= true;

    //            if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
    //              this.aintLastSelected = null;

    //            if (StringType.StrCmp(item.Name, "mnubtnEnumFilename", false) == 0)
    //              Declarations.objSettings.EnumFile ^= true;

    //            if (StringType.StrCmp(item.Name, "mnubtnEnumV1", false) == 0)
    //              Declarations.objSettings.EnumVer1 ^= true;

    //            if (StringType.StrCmp(item.Name, "mnubtnEnumV2", false) == 0)
    //              Declarations.objSettings.EnumVer2 ^= true;

    //            if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
    //            {
    //              this.vintEnumCount = Declarations.objSettings.FilenumberStart;
    //              this.mnutEnumerateCounter.Text = StringType.FromInteger(this.vintEnumCount);
    //            }

    //            this.Enumerate();
    //            return;
    //          }

    //          if ((((((StringType.StrCmp(name, "mnubtnFilterA", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterB", false) != 0)) &&
    //                 ((StringType.StrCmp(name, "mnubtnFilterC", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterD", false) != 0))) &&
    //                (((StringType.StrCmp(name, "mnubtnFilterE", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterF", false) != 0)) &&
    //                 ((StringType.StrCmp(name, "mnubtnFilterG", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterH", false) != 0)))) &&
    //               ((((StringType.StrCmp(name, "mnubtnFilterI", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterJ", false) != 0)) &&
    //                 ((StringType.StrCmp(name, "mnubtnFilterK", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterL", false) != 0))) &&
    //                (((StringType.StrCmp(name, "mnubtnFilterM", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterN", false) != 0)) &&
    //                 ((StringType.StrCmp(name, "mnubtnFilterO", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterP", false) != 0))))) &&
    //              (((((StringType.StrCmp(name, "mnubtnFilterQ", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterR", false) != 0)) &&
    //                 ((StringType.StrCmp(name, "mnubtnFilterS", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterT", false) != 0))) &&
    //                (((StringType.StrCmp(name, "mnubtnFilterU", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterV", false) != 0)) &&
    //                 ((StringType.StrCmp(name, "mnubtnFilterW", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterX", false) != 0)))) &&
    //                (((StringType.StrCmp(name, "mnubtnFilterY", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterZ", false) != 0)) &&
    //                (((StringType.StrCmp(name, "mnubtnFilterOther", false) != 0) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterEmpty", false) != 0)) &&
    //                  (StringType.StrCmp(name, "mnubtnFilterNumber", false) != 0)))))
    //          {
    //            ButtonItem item25 = null;

    //            if (StringType.StrCmp(name, "mnubtnRemoveFilter", false) != 0)
    //              return;

    //            switch (this.vbytFilterIndex)
    //            {
    //              case 0:
    //                item25 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"];
    //                break;

    //              case 1:
    //                item25 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"];
    //                break;

    //              case 2:
    //                item25 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"];
    //                break;

    //              case 0xff:
    //                return;
    //            }

    //            item25.Checked = false;

    //            foreach (ButtonItem item26 in item25.SubItems)
    //              item26.Checked = false;

    //            this.vbytFilterIndex = 0xff;
    //            this.vstrFilter = "*";
    //            Application.DoEvents();
    //            this.MP3View_FillColumns(ref Declarations.MP3s);
    //            this.Timer.Start();
    //            this.MP3View.Focus();
    //            return;
    //          }
    //          switch (this.vbytFilterIndex)
    //          {
    //            case 0:
    //              item23 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"];
    //              break;

    //            case 1:
    //              item23 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"];
    //              break;

    //            case 2:
    //              item23 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"];
    //              break;

    //            case 0xff:
    //              goto Label_31F2;
    //          }

    //          item23.Checked = false;

    //          foreach (ButtonItem item24 in item23.SubItems)
    //            item24.Checked = false;

    //          goto Label_31F2;
    //        }

    //        if (this.MP3View.SelectedItems.Count == 0)
    //        {
    //          Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
    //          return;
    //        }

    //        flag2 = false;
    //      }

    //      do
    //      {
    //        if (this.CheckAllChanged())
    //        {
    //          switch (Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(
    //            Declarations.objResources.ResStrings["ChangesNotSaved"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)),
    //            MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
    //          {
    //            case MsgBoxResult.Cancel:
    //              return;

    //            case MsgBoxResult.Yes:
    //              this.SaveChanges();

    //              if (!this.CheckAllChanged())
    //                flag2 = true;

    //              break;

    //            case MsgBoxResult.No:
    //              flag2 = true;
    //              break;
    //          }
    //        }
    //        else
    //          flag2 = true;
    //      }
    //      while (!flag2);

    //      try
    //      {
    //        this.CalcAudioCheckSumThread.Abort();
    //        this.CalcAudioCheckSumThread.Join();
    //      }
    //      catch (Exception exception7)
    //      {
    //        ProjectData.SetProjectError(exception7);
    //        Exception exception2 = exception7;
    //        ProjectData.ClearProjectError();
    //      }

    //Label_31F2:
    //      this.vstrFilter = ((ButtonItem)item).Text;
    //      ((ButtonItem)item).Checked = true;
    //      string sLeft = ((ButtonItem)item).Parent.Name;

    //      if (StringType.StrCmp(sLeft, "mnubtnFilterArtist", false) == 0)
    //      {
    //        this.vbytFilterIndex = 0;
    //        ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"]).Checked = true;
    //      }
    //      else if (StringType.StrCmp(sLeft, "mnubtnFilterTitle", false) == 0)
    //      {
    //        this.vbytFilterIndex = 1;
    //        ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"]).Checked = true;
    //      }
    //      else if (StringType.StrCmp(sLeft, "mnubtnFilterAlbum", false) == 0)
    //      {
    //        this.vbytFilterIndex = 2;
    //        ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"]).Checked = true;
    //      }

    //      Application.DoEvents();
    //      this.MP3View_FillColumns(ref Declarations.MP3s);
    //      this.Timer.Start();
    //      this.MP3View.Focus();
    //    }

    private void FavTree_AfterSelect(object sender, TreeViewEventArgs e)
    {
      int num;
      ToolStripMenuItem item2 = null;
      bool flag = false;

      if (((e.Action == TreeViewAction.Expand) | (e.Action == TreeViewAction.Collapse)) | (e.Action == TreeViewAction.Unknown))
        goto Label_021B;

      this.vstrFilter = "*";

      switch (this.vbytFilterIndex)
      {
        case 0:
          item2 = tsmiArtist;
          break;
        case 1:
          item2 = tsmiTitle;
          break;
        case 2:
          item2 = tsmiAlbum;
          break;
        case 0xff:
          goto Label_010A;

      }
      item2.Checked = false;

      foreach (ToolStripMenuItem item3 in item2.DropDownItems)
        item3.Checked = false;

      this.vbytFilterIndex = 0xff;

Label_010A:
      this.MP3View.Items.Clear();
      Declarations.MP3s.Clear();

      if (e.Node.Parent == null)
      {
        ArrayList alstFolders = new ArrayList();

        foreach (TreeNode node in e.Node.Nodes)
        {
          if (!flag & Directory.Exists(e.Node.Text))
          {
            Declarations.objSettings.CurrentPath = e.Node.Text;
            flag = true;
          }

          alstFolders.Add(node.Text);
        }

        this.GetFiles(alstFolders, false, false);
      }
      else
      {
        ArrayList list2 = new ArrayList { e.Node.Text };
        this.GetFiles(list2, true, false);

        if (Directory.Exists(e.Node.Text))
          Declarations.objSettings.CurrentPath = e.Node.Text;
      }

      this.MP3View_FillColumns(ref Declarations.MP3s);

Label_021B:
      num = 0;

      foreach (ListViewItem item in this.MP3View.SelectedItems)
        num = IntegerType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(item.Tag, null, "Duration", new object[0], null, null)));

      int num3 = num / 3600;
      num3 = (num - ((num / 3600) * 3600)) / 60;
      string introduced21 = num3.ToString().PadLeft(2, '0') + ":";
      num3 = (num - ((num / 3600) * 3600)) - (((num - ((num / 3600) * 3600)) / 60) * 60);
      string introduced22 = introduced21 + num3.ToString().PadLeft(2, '0') + ":";
      string str = introduced22 + num3.ToString().PadLeft(2, '0');
      object[] args = new object[] { "%3", str };
      bool[] copyBack = new bool[] { false, true };

      if (copyBack[1])
        str = StringType.FromObject(args[1]);

      lblNumber.Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["Number"], null, "Replace", new object[] { "%1", this.MP3View.Items.Count.ToString() }, null, null), null, "Replace", new object[] { "%2", this.MP3View.SelectedItems.Count.ToString() }, null, null), null, "Replace", args, null, copyBack));
      args = new object[2];
      args[0] = "%1";
      Settings objSettings = Declarations.objSettings;
      args[1] = objSettings.CurrentPath;
      object[] objArray2 = args;
      copyBack = new bool[] { false, true };

      if (copyBack[1])
        objSettings.CurrentPath = StringType.FromObject(objArray2[1]);

      lblPath.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", objArray2, null, copyBack));

      try
      {
        lblLength.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", this.MP3View.FocusedItem.Text.Length.ToString() }, null, null));
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        lblLength.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", "0" }, null, null));
        ProjectData.ClearProjectError();
      }
    }

    private void FavTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
    {
      bool flag = false;

      if (!this.vbooRefreshFlag & !this.vbooClosing)
      {
        do
        {
          if (this.CheckAllChanged())
          {
            switch (Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["ChangesNotSaved"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
            {
              case MsgBoxResult.Cancel:
                e.Cancel = true;
                return;

              case MsgBoxResult.Yes:
                this.SaveChanges();

                if (!this.CheckAllChanged())
                  flag = true;

                break;

              case MsgBoxResult.No:
                flag = true;
                break;
            }
          }
          else
            flag = true;
        }
        while (!flag);
      }
    }

    private void FavTree_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        // FIXME DNB ButtonItem item = (ButtonItem)this.DotNetBarManager.ContextMenus["FavouritesMenu"];
        //item.Displayed = false;
        //item.PopupMenu(Control.MousePosition);
      }
    }

    private void FolderRenameEventProcessor(object myObject, EventArgs myEventArgs)
    {
      Application.DoEvents();
      this.vbytFolderRenameCount = (byte)(this.vbytFolderRenameCount + 1);

      if (Directory.Exists(this.vstrFolderRenameNewPath) & !Directory.Exists(this.vstrFolderRenameOldPath))
      {
        this.FolderRenameTimer.Stop();
        this.vbytFolderRenameCount = 0;
        Declarations.objSettings.CurrentPath = (string)this.FolderTree.SelectedNode.Tag;
        object[] objArray2 = new object[2];
        objArray2[0] = "%1";
        Settings objSettings = Declarations.objSettings;
        objArray2[1] = objSettings.CurrentPath;
        object[] args = objArray2;
        bool[] copyBack = new bool[] { false, true };

        if (copyBack[1])
          objSettings.CurrentPath = StringType.FromObject(args[1]);

        lblPath.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", args, null, copyBack));
        Form ownerForm = this;
        frmProgress.Callback cB = new frmProgress.Callback(this.FolderRenameCB);
        frmProgress progress = new frmProgress(0, this.MP3View.Items.Count, 1, ref ownerForm, ref cB);
        progress.SetStateFolderRename();
        progress.String01 = this.vstrFolderRenameOldPath;
        progress.String02 = this.vstrFolderRenameNewPath;
        progress.ShowDialog(this);
        this.vstrFolderRenameOldPath = "";
        this.vstrFolderRenameNewPath = "";
        this.vbooFolderRename = false;
        this.vbooStartUp = true;
        this.FolderTree.RefreshView();
        this.vbooStartUp = false;
      }

      if (this.vbytFolderRenameCount > 30)
      {
        this.FolderRenameTimer.Stop();
        this.vbytFolderRenameCount = 0;
        this.vbooFolderRename = false;
      }
    }

    private void FolderTree_AfterLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      string label = e.Label;
      this.vstrFolderRenameOldPath = (string)e.Node.Tag;
      this.vstrFolderRenameNewPath = this.vstrFolderRenameOldPath.Substring(0, this.vstrFolderRenameOldPath.LastIndexOf(@"\")) + @"\" + label;

      if (!Directory.Exists(this.vstrFolderRenameNewPath))
        this.FolderRenameTimer.Start();
      else
      {
        this.vstrFolderRenameOldPath = "";
        this.vstrFolderRenameNewPath = "";
        this.vbooFolderRename = false;
      }
    }

    private void FolderTree_AfterSelect(object sender, TreeViewEventArgs e)
    {
      ToolStripMenuItem item2 = null;

      if (this.vbooClosing | this.vbooStartUp)
        return;

      Declarations.objSettings.CurrentPath = (string)this.FolderTree.SelectedNode.Tag;
      this.vstrFilter = "*";

      switch (this.vbytFilterIndex)
      {
        case 0:
          item2 = tsmiArtist;
          break;
        case 1:
          item2 = tsmiTitle;
          break;
        case 2:
          item2 = tsmiAlbum;
          break;
        case 0xff:
          goto Label_010B;
      }

      item2.Checked = false;

      foreach (ToolStripMenuItem item3 in item2.DropDownItems)
        item3.Checked = false;

      this.vbytFilterIndex = 0xff;

Label_010B:
      this.GetFiles(null, true, true);
      int num = 0;

      foreach (ListViewItem item in this.MP3View.SelectedItems)
        num = IntegerType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(item.Tag, null, "Duration", new object[0], null, null)));

      int num3 = num / 3600;
      num3 = (num - ((num / 3600) * 3600)) / 60;
      string introduced16 = num3.ToString().PadLeft(2, '0') + ":";
      num3 = (num - ((num / 3600) * 3600)) - (((num - ((num / 3600) * 3600)) / 60) * 60);
      string introduced17 = introduced16 + num3.ToString().PadLeft(2, '0') + ":";
      string str = introduced17 + num3.ToString().PadLeft(2, '0');
      object[] args = new object[] { "%3", str };
      bool[] copyBack = new bool[] { false, true };

      if (copyBack[1])
        str = StringType.FromObject(args[1]);

      lblNumber.Text = StringType.FromObject(
                         LateBinding.LateGet(
                           LateBinding.LateGet(
                             LateBinding.LateGet(
                               Declarations.objResources.ResStrings["Number"], null, "Replace", new object[] { "%1", this.MP3View.Items.Count.ToString() }, null, null),
                             null, "Replace", new object[] { "%2", this.MP3View.SelectedItems.Count.ToString() }, null, null),
                           null, "Replace", args, null, copyBack));
      args = new object[2];
      args[0] = "%1";
      Settings objSettings = Declarations.objSettings;
      args[1] = objSettings.CurrentPath;
      object[] objArray2 = args;
      copyBack = new bool[] { false, true };

      if (copyBack[1])
        objSettings.CurrentPath = StringType.FromObject(objArray2[1]);

      lblPath.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", objArray2, null, copyBack));

      try
      {
        if (this.MP3View.FocusedItem != null)
          lblLength.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"],
                                                                     null,
                                                                     "Replace",
                                                                     new object[] { "%1", this.MP3View.FocusedItem.Text.Length.ToString() },
                                                                     null,
                                                                     null));
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        lblLength.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", "0" }, null, null));
        ProjectData.ClearProjectError();
      }

      try
      {
        Declarations.UNDOList.Clear();
        Declarations.REDOList.Clear();

        this.btnUndo.Enabled = false;
        this.btnRedo.Enabled = false;
        this.undoToolStripMenuItem.Enabled = false;
        this.redoToolStripMenuItem.Enabled = false;
      }
      catch (Exception exception2)
      {
        ProjectData.SetProjectError(exception2);
        ProjectData.ClearProjectError();
      }
    }

    private void FolderTree_BeforeLabelEdit(object sender, NodeLabelEditEventArgs e)
    {
      this.vbooFolderRename = true;
    }

    private void FolderTree_BeforeSelect(object sender, CancelEventArgs e)
    {
      bool flag = false;
      if ((!this.vbooRefreshFlag & !this.vbooClosing) & !this.vbooFolderRename)
      {
        do
        {
          if (this.CheckAllChanged())
          {
            switch (Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["ChangesNotSaved"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
            {
              case MsgBoxResult.Cancel:
                e.Cancel = true;
                return;

              case MsgBoxResult.Yes:
                this.SaveChanges();
                if (!this.CheckAllChanged())
                {
                  flag = true;
                }
                break;

              case MsgBoxResult.No:
                flag = true;
                break;
            }
          }
          else
          {
            flag = true;
          }
        }
        while (!flag);
      }
    }

    private void frmMain_Closing(object sender, CancelEventArgs e)
    {
      this.vbooClosing = true;

      try
      {
        Id3TagIT_Main.objDebugStream.Seek(0L, SeekOrigin.Begin);

        if (Id3TagIT_Main.objDebugStream.ReadByte() == 0x20)
        {
          FileStream stream = new FileStream(Environment.GetFolderPath(Environment.SpecialFolder.DesktopDirectory) + @"\ID3-TagIT-Log.txt", FileMode.OpenOrCreate);
          Id3TagIT_Main.objDebugStream.Flush();
          stream.Write(Id3TagIT_Main.objDebugStream.ToArray(), 0, Id3TagIT_Main.objDebugStream.ToArray().Length);
          stream.Flush();
          stream.Close();
        }

        Id3TagIT_Main.objDebugStream.Close();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }

      bool flag = false;

      do
      {
        if (this.CheckAllChanged())
        {
          switch (Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["ChangesNotSaved"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
          {
            case MsgBoxResult.Cancel:
              e.Cancel = true;
              this.vbooClosing = false;
              return;

            case MsgBoxResult.Yes:
              this.SaveChanges();

              if (!this.CheckAllChanged())
                flag = true;

              break;

            case MsgBoxResult.No:
              flag = true;
              break;
          }
        }
        else
          flag = true;
      }
      while (!flag);

      try
      {
        this.GetFilesTimeThread.Abort();
      }
      catch (Exception exception5)
      {
        ProjectData.SetProjectError(exception5);
        Exception exception2 = exception5;
        ProjectData.ClearProjectError();
      }

      try
      {
        if (CalcAudioCheckSumThread != null)
        {
          this.CalcAudioCheckSumThread.Abort();
          this.CalcAudioCheckSumThread.Join();
        }
      }
      catch (Exception exception6)
      {
        ProjectData.SetProjectError(exception6);
        Exception exception3 = exception6;
        ProjectData.ClearProjectError();
      }

      try
      {
        if (this.PicMStream != null)
          this.PicMStream.Close();
      }
      catch (Exception exception7)
      {
        ProjectData.SetProjectError(exception7);
        Exception exception4 = exception7;
        ProjectData.ClearProjectError();
      }

      try
      {
        // FIXME DNB this.DotNetBarManager.SaveLayout(Path.Combine(Declarations.vstrUserAppData, "Interface.xml"));
        // FIXME DNB this.DotNetBarManager.Bars["Toolbar"].SaveDefinition(Path.Combine(Declarations.vstrUserAppData, "Toolbar.xml"));
        // FIXME DNB this.DotNetBarManager.Bars["ExtToolbar"].SaveDefinition(Path.Combine(Declarations.vstrUserAppData, "ExtToolbar.xml"));
        // FIXME this.BarGroupTools.SubItems.Clear();
        //this.SideBar.SaveDefinition(Path.Combine(Declarations.vstrUserAppData, "Sidebar.xml"));
        //this.NavigationPan.SaveLayout(Path.Combine(Declarations.vstrUserAppData, "Navpanel.xml"));
      }
      catch (Exception exception8)
      {
        ProjectData.SetProjectError(exception8);
        ProjectData.ClearProjectError();
      }

      // FIXME - Distaince - Declarations.objSettings.NavPanWidth = this.NavigationPan.Width;
      // FIXME - Distaince - Declarations.objSettings.SideBarWidth = this.splitContainer1.Panel2.Width;
      //Declarations.objSettings.ErrorHeight = this.ErrorMsg.Height;
      //Declarations.objSettings.NavPanExpanded = this.SplitterLeft.Expanded;
      //Declarations.objSettings.SideBarExpanded = this.SplitterRight.Expanded;
      //Declarations.objSettings.ErrorExpanded = this.SplitterBottom.Expanded;

      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      this.MP3View_SaveColumns();
      Declarations.objSettings.WriteSettings();
      var enumerator = Declarations.TempFiles.GetEnumerator();

      while (enumerator.MoveNext())
      {
        string path = StringType.FromObject(enumerator.Current);
        try
        {
          File.Delete(path);
          continue;
        }
        catch (Exception exception9)
        {
          ProjectData.SetProjectError(exception9);
          ProjectData.ClearProjectError();
          continue;
        }
      }

      Declarations.UNDOList.Clear();
      Declarations.REDOList.Clear();
    }

    private void frmMain_Load(object sender, EventArgs e)
    {
      this.Visible = false;
      frmSplash splash = new frmSplash();
      splash.Show();
      Application.DoEvents();
      splash.lblState.Text = "Checking Registry settings";
      Application.DoEvents();

      try
      {
        RegistryKey key4 = Registry.ClassesRoot.OpenSubKey(@"Folder\Shell\ID3-TagIT", true);
        string executablePath = Application.ExecutablePath;

        if (key4 != null)
          Registry.ClassesRoot.OpenSubKey(@"Folder\Shell", true).DeleteSubKeyTree("ID3-TagIT");

        RegistryKey key3 = Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT", true);

        if (Declarations.objSettings.ExplorerContext)
        {
          if (key3 != null)
            Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).DeleteSubKeyTree("ID3-TagIT");

          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).CreateSubKey("ID3-TagIT");
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT", true).CreateSubKey("command");
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT\command", true).SetValue(null, "\"" + executablePath + "\"" + " " + "\"" + "/P=%1" + "\"");
        }

        if (!Declarations.objSettings.ExplorerContext & (key3 != null))
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).DeleteSubKeyTree("ID3-TagIT");
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }

      splash.lblState.Text = "Restoring interface";
      Application.DoEvents();
      Form form = this;
      Id3TagIT_Main.RestoreFormSettings(ref form);

      //try
      //{
      //  if (File.Exists(Path.Combine(Declarations.vstrUserAppData, "Toolbar.xml")))
      //    this.DotNetBarManager.Bars["Toolbar"].LoadDefinition(Path.Combine(Declarations.vstrUserAppData, "Toolbar.xml"));
      //}
      //catch (Exception exception2)
      //{
      //  ProjectData.SetProjectError(exception2);
      //  ProjectData.ClearProjectError();
      //}

      //try
      //{
      //  if (File.Exists(Path.Combine(Declarations.vstrUserAppData, "ExtToolbar.xml")))
      //    this.DotNetBarManager.Bars["ExtToolbar"].LoadDefinition(Path.Combine(Declarations.vstrUserAppData, "ExtToolbar.xml"));
      //}
      //catch (Exception exception3)
      //{
      //  ProjectData.SetProjectError(exception3);
      //  ProjectData.ClearProjectError();
      //}

      //try
      //{
      //  if (File.Exists(Path.Combine(Declarations.vstrUserAppData, "Navpanel.xml")))
      //    this.NavigationPan.LoadLayout(Path.Combine(Declarations.vstrUserAppData, "Navpanel.xml"));
      //}
      //catch (Exception exception4)
      //{
      //  ProjectData.SetProjectError(exception4);
      //  ProjectData.ClearProjectError();
      //}

      try
      {
        // FIXME DNB if (File.Exists(Path.Combine(Declarations.vstrUserAppData, "Interface.xml")))
        // FIXME DNB   this.DotNetBarManager.LoadLayout(Path.Combine(Declarations.vstrUserAppData, "Interface.xml"));
      }
      catch (Exception exception5)
      {
        ProjectData.SetProjectError(exception5);
        ProjectData.ClearProjectError();
      }

      try
      {
        if (File.Exists(Path.Combine(Declarations.vstrUserAppData, "Sidebar.xml")))
        {
          // FIXME
          //this.SideBar.LoadDefinition(Path.Combine(Declarations.vstrUserAppData, "Sidebar.xml"));
          //this.BarGroupEdit = (ExplorerBarGroupItem)this.SideBar.Groups[0];
          //this.BarGroupPicture = (ExplorerBarGroupItem)this.SideBar.Groups[1];
          //this.BarGroupInfo = (ExplorerBarGroupItem)this.SideBar.Groups[2];
          //this.BarGroupTools = (ExplorerBarGroupItem)this.SideBar.Groups[3];
        }
      }
      catch (Exception exception6)
      {
        ProjectData.SetProjectError(exception6);
        ProjectData.ClearProjectError();
      }

      this.mnutEnumerateCounter.Text = StringType.FromInteger(Declarations.objSettings.FilenumberStart);

      if (Declarations.objResources.ResStrings != null)
      {
        // FIXME DNB ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"]).Text = StringType.FromObject(Declarations.objResources.ResStrings["Col05"]);
        // FIXME DNB ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"]).Text = StringType.FromObject(Declarations.objResources.ResStrings["Col06"]);
        // FIXME DNB ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"]).Text = StringType.FromObject(Declarations.objResources.ResStrings["Col07"]);
      }

      this.btnUndo.Enabled = false;
      this.btnRedo.Enabled = false;
      this.undoToolStripMenuItem.Enabled = false;
      this.redoToolStripMenuItem.Enabled = false;

      enumerateInTAGVer1ToolStripMenuItem1.Checked = Declarations.objSettings.EnumVer1;
      enumerateInTAGVer2ToolStripMenuItem1.Checked = Declarations.objSettings.EnumVer2;
      enumerateInTAGVer1ToolStripMenuItem.Checked = Declarations.objSettings.EnumVer1;
      enumerateInTAGVer2ToolStripMenuItem.Checked = Declarations.objSettings.EnumVer2;
      scanSubdirectoriesToolStripMenuItem.Checked = Declarations.objSettings.ScanSubDirs;
      quickFilenameEditingToolStripMenuItem.Checked = Declarations.objSettings.QuickFilenameEditing;
      synchronizeVer1AndVer2EditingToolStripMenuItem.Checked = Declarations.objSettings.SynchronizeTAGs;

      viewTAGVer1ToolStripMenuItem.Checked = BooleanType.FromObject(Declarations.objSettings.VersionToShow == 1);
      viewTAGVer2ToolStripMenuItem.Checked = BooleanType.FromObject(Declarations.objSettings.VersionToShow == 2);

      if (Declarations.objResources.ResStrings != null)
      {
        btnSwitchV1V2.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
        lblVersion.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
      }

      if (Declarations.objResources.ResStrings != null)
        if (Declarations.objSettings.ScanSubDirs)
          lblSubDirs.Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsYes"]);
        else
          lblSubDirs.Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsNo"]);

      // FIXME - Distance - this.NavigationPan.Width = Declarations.objSettings.NavPanWidth;
      // FIXME - Distance - this.splitContainer1.Panel2.Width = Declarations.objSettings.SideBarWidth;
      this.ErrorMsg.Height = Declarations.objSettings.ErrorHeight;
      string sLeft = "";
      RegistryKey key = Registry.ClassesRoot.OpenSubKey(".mp3", false);
      Application.DoEvents();

      if (key != null)
      {
        sLeft = StringType.FromObject(key.GetValue(""));
        string name = sLeft + @"\DefaultIcon\";
        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(name, false);
        Application.DoEvents();

        if (key2 != null)
        {
          sLeft = StringType.FromObject(key2.GetValue(""));
          try
          {
            sLeft = sLeft.Substring(0, sLeft.LastIndexOf(","));
          }
          catch (Exception exception7)
          {
            ProjectData.SetProjectError(exception7);
            ProjectData.ClearProjectError();
          }
        }
      }

      int num = -1;

      foreach (DataRow row in Declarations.objSettings.Tools.Rows)
      {
        num++;

        // FIXME - external tools
        //try
        //{
        //  if (BooleanType.FromObject(row["DefaultPlayer"]))
        //  {
        //    if (StringType.StrCmp(sLeft, "", false) != 0)
        //      this.ToolsIcons.Images.Add(Id3TagIT_Main.GetAppIcon(sLeft, true));
        //
        //    ButtonItem item2 = new ButtonItem("ToolItem" + num.ToString(), row["ToolDescription"].ToString())
        //    {
        //      ImageIndex = num,
        //      Tag = num,
        //      ButtonStyle = eButtonStyle.ImageAndText
        //    };
        //
        //    // FIXME this.BarGroupTools.SubItems.Add(item2);
        //  }
        //  else
        //  {
        //    this.ToolsIcons.Images.Add(Id3TagIT_Main.GetAppIcon(StringType.FromObject(row["ToolPath"]), true));
        //    ButtonItem item3 = new ButtonItem("ToolItem" + num.ToString(), row["ToolDescription"].ToString())
        //    {
        //      ImageIndex = num,
        //      Tag = num,
        //      ButtonStyle = eButtonStyle.ImageAndText
        //    };
        //    // FIXME this.BarGroupTools.SubItems.Add(item3);
        //  }
        //}
        //catch (Exception exception8)
        //{
        //  ProjectData.SetProjectError(exception8);
        //  ButtonItem item4 = new ButtonItem("ToolItem" + num.ToString(), row["ToolDescription"].ToString())
        //  {
        //    Tag = num,
        //    ButtonStyle = eButtonStyle.Default
        //  };
        //  // FIXME this.BarGroupTools.SubItems.Add(item4);
        //  ProjectData.ClearProjectError();
        //}
      }

      this.FavTree.BeginUpdate();

      foreach (TreeNode node in Declarations.objSettings.FavNodes)
        LateBinding.LateCall(this.FavTree.Nodes, null, "Add", new object[] { RuntimeHelpers.GetObjectValue(node.Clone()) }, null, null);

      this.FavTree.EndUpdate();

      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
        this.cboQEArtist.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));

      if (Declarations.objResources.ResStrings != null)
      {
        this.colHErrFile.Text = StringType.FromObject(Declarations.objResources.ResStrings["CHError1"]);
        this.colHErrMsg.Text = StringType.FromObject(Declarations.objResources.ResStrings["CHError2"]);
      }

      this.colHErrFile.Width = 200;
      this.colHErrMsg.Width = 200;
      this.ErrorMsg.Columns.AddRange(new ColumnHeader[] { this.colHErrFile, this.colHErrMsg });
      splash.lblState.Text = "Adding Columns";
      Application.DoEvents();

      this.MP3View_AddColumns();
      this.lblQEArtist.Text = this.colHArtist.Text;
      this.lblQETitle.Text = this.colHTitle.Text;
      this.lblQEAlbum.Text = this.colHAlbum.Text;
      splash.lblState.Text = "Localizing Menus";
      cboLanguage.SelectedIndex = Declarations.objSettings.Language;
      this.SetLanguage();
      splash.lblState.Text = "Restoring folder";
      Application.DoEvents();

      this.FolderTree.SelectNode(Declarations.objSettings.CurrentPath);
      Application.DoEvents();

      splash.Close();
      Application.DoEvents();

      form = this;
      this.MP3View.Focus();
      Application.DoEvents();

      this.Visible = true;
      this.GetFiles(null, true, true);
      this.Timer.Tick += new EventHandler(this.TimerEventProcessor);
      this.FolderRenameTimer.Tick += new EventHandler(this.FolderRenameEventProcessor);
      int num2 = 0;

      foreach (ListViewItem item in this.MP3View.Items)
        num2 = IntegerType.FromObject(ObjectType.AddObj(num2, LateBinding.LateGet(item.Tag, null, "Duration", new object[0], null, null)));

      int num4 = num2 / 3600;
      num4 = (num2 - ((num2 / 3600) * 3600)) / 60;
      string introduced45 = num4.ToString().PadLeft(2, '0') + ":";
      num4 = (num2 - ((num2 / 3600) * 3600)) - (((num2 - ((num2 / 3600) * 3600)) / 60) * 60);
      string introduced46 = introduced45 + num4.ToString().PadLeft(2, '0') + ":";
      string str3 = introduced46 + num4.ToString().PadLeft(2, '0');
      object[] args = new object[] { "%3", str3 };
      bool[] copyBack = new bool[] { false, true };

      if (copyBack[1])
        str3 = StringType.FromObject(args[1]);

      lblNumber.Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["Number"], null, "Replace", new object[] { "%1", this.MP3View.Items.Count.ToString() }, null, null), null, "Replace", new object[] { "%2", this.MP3View.SelectedItems.Count.ToString() }, null, null), null, "Replace", args, null, copyBack));
      args = new object[2];
      args[0] = "%1";
      Settings objSettings = Declarations.objSettings;
      args[1] = objSettings.CurrentPath;
      object[] objArray2 = args;
      copyBack = new bool[] { false, true };

      if (copyBack[1])
        objSettings.CurrentPath = StringType.FromObject(objArray2[1]);

      lblPath.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", objArray2, null, copyBack));

      try
      {
        if (this.MP3View.FocusedItem != null)
          lblLength.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", this.MP3View.FocusedItem.Text.Length.ToString() }, null, null));
      }
      catch (Exception exception9)
      {
        ProjectData.SetProjectError(exception9);
        lblLength.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", "0" }, null, null));
        ProjectData.ClearProjectError();
      }

      this.colHErrFile.Width = (int)Math.Round((double)(this.ErrorMsg.Width * 0.4));
      this.colHErrMsg.Width = (int)Math.Round((double)(this.ErrorMsg.Width * 0.55));
      //this.SplitterLeft.Expanded = Declarations.objSettings.NavPanExpanded;
      //this.SplitterRight.Expanded = Declarations.objSettings.SideBarExpanded;
      //this.SplitterBottom.Expanded = Declarations.objSettings.ErrorExpanded;
      //this.NavigationPan.RecalcLayout();
      //this.NavigationPan.ResetText();
      this.vbooStartUp = false;
    }

    private void MP3View_AfterLabelEdit(object sender, LabelEditEventArgs e)
    {
      string label = e.Label;
      if ((label == null) || (StringType.StrCmp(label.Trim(new char[] { ' ' }), "", false) == 0))
      {
        e.CancelEdit = true;
        this.MP3View.LabelEdit = Declarations.objSettings.MouseFilenameEditing;
      }
      else
      {
        label = label.Trim(new char[] { ' ' }).Replace("<", "_").Replace(">", "_").Replace("|", "_").Replace("\"", "_").Replace("/", "_").Replace("*", "_").Replace("?", "_").Replace(":", "_").Replace(@"\", "_");
        MP3 tag = (MP3)this.MP3View.Items[e.Item].Tag;
        string str = tag.CurrentFullName.Substring(0, tag.CurrentFullName.LastIndexOf(@"\") + 1) + label + tag.FI.Extension;
        if (str.Length > 0xff)
        {
          Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["InvalidPathLength"]), MsgBoxStyle.Exclamation, null);
          e.CancelEdit = true;
          this.MP3View.LabelEdit = Declarations.objSettings.MouseFilenameEditing;
        }
        else
        {
          foreach (MP3 mp2 in Declarations.MP3s)
          {
            if ((StringType.StrCmp(mp2.CurrentFullName.ToLower(), str.ToLower(), false) == 0) & (tag != mp2))
            {
              object[] objArray5 = new object[2];
              objArray5[0] = "%1";
              MP3 mp4 = mp2;
              objArray5[1] = mp4.CurrentFullName;
              object[] args = objArray5;
              bool[] copyBack = new bool[] { false, true };
              if (copyBack[1])
                mp4.CurrentFullName = StringType.FromObject(args[1]);
              object[] objArray3 = new object[2];
              objArray3[0] = "%2";
              MP3 mp3 = tag;
              objArray3[1] = mp3.CurrentFullName;
              object[] objArray2 = objArray3;
              bool[] flagArray = new bool[] { false, true };
              if (flagArray[1])
                mp3.CurrentFullName = StringType.FromObject(objArray2[1]);
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["FileAlreadyExistsRename"], null, "Replace", args, null, copyBack), null, "Replace", objArray2, null, flagArray), null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Exclamation, null);
              e.CancelEdit = true;
              this.MP3View.LabelEdit = Declarations.objSettings.MouseFilenameEditing;
              return;
            }
          }
          ArrayList list = new ArrayList();
          Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
          list.Add(@do);
          Declarations.UNDOList.Add(list);
          this.UnDoEnable(true, true);
          tag.CurrentFullName = str;
          tag.Changed = true;
          this.MP3View.Items[e.Item].Text = tag.CurrentName;
          this.MP3View.Items[e.Item].BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedBack);
          this.MP3View.Items[e.Item].ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedText);
          if (Declarations.objSettings.QuickFilenameEditing & ((this.MP3View.Items.Count - 1) > e.Item))
          {
            this.MP3View.Items[e.Item].Selected = false;
            this.MP3View.Items[e.Item + 1].Selected = true;
            this.MP3View.Items[e.Item + 1].Focused = true;
            this.MP3View.FocusedItem.BeginEdit();
          }
          this.MP3View.LabelEdit = Declarations.objSettings.MouseFilenameEditing;
          e.CancelEdit = true;
        }
      }
    }

    private void MP3View_BuildColumns(ref ColumnHeader Column, DataRow DataRo, string ColumnHeaderText)
    {
      Column.Text = ColumnHeaderText;
      Column.Width = IntegerType.FromObject(DataRo["Width"]);
      object obj2 = DataRo["Alignment"];
      if (ObjectType.ObjTst(obj2, "Left", false) == 0)
        Column.TextAlign = HorizontalAlignment.Left;
      else if (ObjectType.ObjTst(obj2, "Right", false) == 0)
        Column.TextAlign = HorizontalAlignment.Right;
      else if (ObjectType.ObjTst(obj2, "Center", false) == 0)
        Column.TextAlign = HorizontalAlignment.Center;
      this.MP3View.Columns.Add(Column);
    }

    private void MP3View_Click(object sender, EventArgs e)
    {
      this.Enumerate();
    }

    private void MP3View_ColumnClick(object sender, ColumnClickEventArgs e)
    {
      Declarations.LVCOLUMN lvcolumn;
      IntPtr ptr2 = Declarations.SendMessage(Declarations.SendMessage(this.MP3View.Handle, 0x101f, 0, 0), 0x1208, 0, this.ColumnHeaderIcons.Handle.ToInt32());
      lvcolumn.mask = 1;
      if ((((((((((StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHTrack.Text, false) == 0) | (StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHPosMedia.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHBPM.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHYear.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHRating.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHBitrate.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHPicCount.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHAudioCheckSum.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHFileSize.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[this.SortedColumn].Text, this.colHSamplerate.Text, false) == 0))
        lvcolumn.fmt = 1;
      else
        lvcolumn.fmt = 0;
      lvcolumn.iImage = 0;
      lvcolumn.cchTextMax = 0;
      lvcolumn.cx = 0;
      lvcolumn.iOrder = 0;
      lvcolumn.iSubItem = 0;
      lvcolumn.pszText = IntPtr.Zero;
      ptr2 = Declarations.SendMessage(this.MP3View.Handle, 0x101a, this.SortedColumn, ref lvcolumn);
      lvcolumn.mask = 0x11;
      if ((((((((((StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHTrack.Text, false) == 0) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHPosMedia.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHBPM.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHYear.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHRating.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHBitrate.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHPicCount.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHAudioCheckSum.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHFileSize.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHSamplerate.Text, false) == 0))
        lvcolumn.fmt = 0x1801;
      else
        lvcolumn.fmt = 0x1800;
      if (this.LastSortedColumn == e.Column)
        lvcolumn.iImage = 0;
      else
        lvcolumn.iImage = 1;
      lvcolumn.cchTextMax = 0;
      lvcolumn.cx = 0;
      lvcolumn.iOrder = 0;
      lvcolumn.iSubItem = 0;
      lvcolumn.pszText = IntPtr.Zero;
      ptr2 = Declarations.SendMessage(this.MP3View.Handle, 0x101a, e.Column, ref lvcolumn);
      SortClass class2 = new SortClass
      {
        Column = e.Column
      };
      this.SortedColumn = e.Column;
      string text = this.MP3View.Columns[e.Column].Text;
      if ((((StringType.StrCmp(text, this.colHPicCount.Text, false) == 0) || (StringType.StrCmp(text, this.colHAudioCheckSum.Text, false) == 0)) || ((StringType.StrCmp(text, this.colHFileSize.Text, false) == 0) || (StringType.StrCmp(text, this.colHTrack.Text, false) == 0))) || ((((StringType.StrCmp(text, this.colHPosMedia.Text, false) == 0) || (StringType.StrCmp(text, this.colHBPM.Text, false) == 0)) || ((StringType.StrCmp(text, this.colHYear.Text, false) == 0) || (StringType.StrCmp(text, this.colHRating.Text, false) == 0))) || ((StringType.StrCmp(text, this.colHBitrate.Text, false) == 0) || (StringType.StrCmp(text, this.colHSamplerate.Text, false) == 0))))
        class2.SortMethod = SortClass.SorterMethod.Numeric;
      else if ((StringType.StrCmp(text, this.colHDate.Text, false) == 0) || (StringType.StrCmp(text, this.colHCreateDate.Text, false) == 0))
        class2.SortMethod = SortClass.SorterMethod.Dat;
      else
        class2.SortMethod = SortClass.SorterMethod.Text;
      if (this.LastSortedColumn == e.Column)
      {
        class2.AltSort = true;
        this.LastSortedColumn = -1;
      }
      else
        this.LastSortedColumn = e.Column;
      this.MP3View.ListViewItemSorter = class2;
    }

    private void MP3View_DoubleClick(object sender, EventArgs e)
    {
      frmMain main;
      switch (Declarations.objSettings.EditDialog)
      {
        case 1:
          main = this;
          new frmTAG1(ref main).ShowDialog(this);
          break;

        case 2:
          main = this;
          new frmTAG2(ref main).ShowDialog(this);
          break;

        case 3:
          if (this.vbytVersionToShow != 1)
          {
            main = this;
            new frmTAG2(ref main).ShowDialog(this);
            break;
          }
          main = this;
          new frmTAG1(ref main).ShowDialog(this);
          break;
      }
    }

    public void MP3View_FillColumns(ref ArrayList MP3sList)
    {
      if ((this.LastSortedColumn == -1) & !this.vbooStartUp)
        this.LastSortedColumn = this.SortedColumn;
      else
        this.LastSortedColumn = -1;
      this.MP3View.ListViewItemSorter = null;
      Form ownerForm = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.MP3View_FillColumnsCB);
      frmProgress progress = new frmProgress(0, Declarations.MP3s.Count, IntegerType.FromObject(Declarations.MP3s.Count < 0x3e8 ? Declarations.MP3s.Count / 10 : 100), ref ownerForm, ref cB)
      {
        List = MP3sList
      };
      progress.SetStateFill();
      this.MP3View.BeginUpdate();
      this.MP3View.Items.Clear();
      progress.ShowDialog(this);
      ColumnClickEventArgs e = new ColumnClickEventArgs(this.SortedColumn);
      this.MP3View_ColumnClick(this, e);
      this.MP3View.EndUpdate();
      this.cboQEArtist.Text = "";
      this.txtQETitle.Text = "";
      this.txtQEAlbum.Text = "";
      this.picCover.Image = null;
      this.txtInformation.Text = "";
      this.txtInformation.Text = this.colHDuration.Text + ":\r\n";
      this.txtInformation.AppendText(this.colHFileSize.Text + ":\r\n");
      this.txtInformation.AppendText(this.colHBitrate.Text + ":\r\n");
      this.txtInformation.AppendText(this.colHVBR.Text + ":\r\n");
      this.txtInformation.AppendText(this.colHSamplerate.Text + ":\r\n");
      this.txtInformation.AppendText(this.colHChannel.Text + ":\r\n");
      this.txtInformation.AppendText(this.colHVersion.Text + ":");
      this.AudioCheckSumCalculation();
    }

    public void MP3View_FillColumnsCB(ref frmProgress frmProg)
    {
      ArrayList list = frmProg.List;
      int num3 = IntegerType.FromObject(Declarations.MP3s.Count < 0x3e8 ? Declarations.MP3s.Count / 10 : 100);
      foreach (MP3 mp in list)
      {
        object objectValue;
        int num2 = 0;
        num2++;
        Application.DoEvents();
        if (frmProg.Canceled)
          break;
        bool flag = false;
        if (StringType.StrCmp(this.vstrFilter, "*", false) == 0)
          goto Label_11EA;
        switch (this.vbytFilterIndex)
        {
          case 0:
            if (Declarations.objSettings.VersionToShow != 2)
              goto Label_053C;
            if (!mp.V2TAG.FrameExists("TPE1"))
              goto Label_051D;
            if (ObjectType.ObjTst(LateBinding.LateGet(mp.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), "", false) != 0)
            {
              if (!(Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null))) & (StringType.StrCmp(this.vstrFilter, "#", false) == 0)))
                break;
              flag = true;
            }
            goto Label_11ED;

          case 1:
            if (Declarations.objSettings.VersionToShow != 2)
              goto Label_0AFE;
            if (!mp.V2TAG.FrameExists("TIT2"))
              goto Label_0ADF;
            if (ObjectType.ObjTst(LateBinding.LateGet(mp.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), "", false) != 0)
            {
              if (!(Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null))) & (StringType.StrCmp(this.vstrFilter, "#", false) == 0)))
                goto Label_0739;
              flag = true;
            }
            goto Label_11ED;

          case 2:
            if (Declarations.objSettings.VersionToShow != 2)
              goto Label_10C0;
            if (!mp.V2TAG.FrameExists("TALB"))
              goto Label_10A1;
            if (ObjectType.ObjTst(LateBinding.LateGet(mp.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), "", false) != 0)
            {
              if (!(Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null))) & (StringType.StrCmp(this.vstrFilter, "#", false) == 0)))
                goto Label_0CFB;
              flag = true;
            }
            goto Label_11ED;

          default:
            goto Label_11ED;
        }
        object[] args = new object[1];
        object frame = mp.V2TAG.GetFrame("TPE1");
        object[] objArray14 = new object[0];
        string[] paramnames = null;
        object[] objArray13 = new object[2];
        object[] objArray15 = objArray13;
        int index = 0;
        object obj7 = 0;
        objArray15[index] = RuntimeHelpers.GetObjectValue(obj7);
        int num10 = 1;
        object obj6 = 1;
        objArray15[num10] = RuntimeHelpers.GetObjectValue(obj6);
        object[] objArray12 = objArray15;
        string[] strArray3 = null;
        args[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(frame, null, "Content", objArray14, paramnames, null), null, "Substring", objArray12, strArray3, null), null, "ToUpper", new object[0], null, null));
        object[] objArray10 = args;
        bool[] copyBack = new bool[] { true };
        if (copyBack[0])
        {
          objArray15 = objArray13;
          objArray15[index] = RuntimeHelpers.GetObjectValue(obj7);
          objArray15[num10] = RuntimeHelpers.GetObjectValue(obj6);
          LateBinding.LateSetComplex(LateBinding.LateGet(LateBinding.LateGet(frame, null, "Content", objArray14, paramnames, null), null, "Substring", objArray12, strArray3, null), null, "ToUpper", new object[] { RuntimeHelpers.GetObjectValue(objArray10[0]) }, null, true, true);
        }
        object[] objArray4 = new object[1];
        object o = mp.V2TAG.GetFrame("TPE1");
        object[] objArray7 = new object[0];
        string[] strArray2 = null;
        object[] objArray6 = new object[2];
        object[] objArray8 = objArray6;
        int num9 = 0;
        object obj4 = 0;
        objArray8[num9] = RuntimeHelpers.GetObjectValue(obj4);
        int num8 = 1;
        object obj3 = 1;
        objArray8[num8] = RuntimeHelpers.GetObjectValue(obj3);
        object[] objArray5 = objArray8;
        string[] strArray = null;
        objArray4[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(o, null, "Content", objArray7, strArray2, null), null, "Substring", objArray5, strArray, null), null, "ToUpper", new object[0], null, null));
        object[] objArray3 = objArray4;
        bool[] flagArray = new bool[] { true };
        if (flagArray[0])
        {
          objArray8 = objArray6;
          objArray8[num9] = RuntimeHelpers.GetObjectValue(obj4);
          objArray8[num8] = RuntimeHelpers.GetObjectValue(obj3);
          LateBinding.LateSetComplex(LateBinding.LateGet(LateBinding.LateGet(o, null, "Content", objArray7, strArray2, null), null, "Substring", objArray5, strArray, null), null, "ToUpper", new object[] { RuntimeHelpers.GetObjectValue(objArray3[0]) }, null, true, true);
        }
        if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(null, typeof(Strings), "Asc", objArray10, null, copyBack), 0x41, false) < 0, ObjectType.ObjTst(LateBinding.LateGet(null, typeof(Strings), "Asc", objArray3, null, flagArray), 90, false) > 0), StringType.StrCmp(this.vstrFilter, "@", false) == 0), !Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null))))))
          flag = true;
        else if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null), null, "ToUpper", new object[0], null, null), this.vstrFilter, false) == 0)
          flag = true;
        goto Label_11ED;
Label_051D:
        if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
          flag = true;
        goto Label_11ED;
Label_053C:
        if (StringType.StrCmp(mp.V1TAG.Artist, "", false) != 0)
        {
          if (StringType.StrCmp(mp.V1TAG.Artist, "", false) != 0)
          {
            if (Information.IsNumeric(mp.V1TAG.Artist.Substring(0, 1)) & (StringType.StrCmp(this.vstrFilter, "#", false) == 0))
              flag = true;
            else if ((((Strings.Asc(mp.V1TAG.Artist.Substring(0, 1).ToUpper()) < 0x41) | (Strings.Asc(mp.V1TAG.Artist.Substring(0, 1).ToUpper()) > 90)) & (StringType.StrCmp(this.vstrFilter, "@", false) == 0)) & !Information.IsNumeric(mp.V1TAG.Artist.Substring(0, 1)))
              flag = true;
            else if (StringType.StrCmp(mp.V1TAG.Artist.Substring(0, 1).ToUpper(), this.vstrFilter, false) == 0)
              flag = true;
          }
        }
        else if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
          flag = true;
        goto Label_11ED;
Label_0739:
        objArray5 = new object[1];
        obj3 = mp.V2TAG.GetFrame("TIT2");
        object[] objArray2 = new object[0];
        strArray = null;
        objArray3 = new object[2];
        object[] objArray = objArray3;
        num8 = 0;
        obj4 = 0;
        objArray[num8] = RuntimeHelpers.GetObjectValue(obj4);
        num9 = 1;
        o = 1;
        objArray[num9] = RuntimeHelpers.GetObjectValue(o);
        objArray4 = objArray;
        strArray2 = null;
        objArray5[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(obj3, null, "Content", objArray2, strArray, null), null, "Substring", objArray4, strArray2, null), null, "ToUpper", new object[0], null, null));
        objArray6 = objArray5;
        flagArray = new bool[] { true };
        if (flagArray[0])
        {
          objArray = objArray3;
          objArray[num8] = RuntimeHelpers.GetObjectValue(obj4);
          objArray[num9] = RuntimeHelpers.GetObjectValue(o);
          LateBinding.LateSetComplex(LateBinding.LateGet(LateBinding.LateGet(obj3, null, "Content", objArray2, strArray, null), null, "Substring", objArray4, strArray2, null), null, "ToUpper", new object[] { RuntimeHelpers.GetObjectValue(objArray6[0]) }, null, true, true);
        }
        objArray12 = new object[1];
        obj6 = mp.V2TAG.GetFrame("TIT2");
        object[] objArray9 = new object[0];
        strArray3 = null;
        objArray10 = new object[2];
        objArray8 = objArray10;
        num10 = 0;
        obj7 = 0;
        objArray8[num10] = RuntimeHelpers.GetObjectValue(obj7);
        index = 1;
        frame = 1;
        objArray8[index] = RuntimeHelpers.GetObjectValue(frame);
        args = objArray8;
        paramnames = null;
        objArray12[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(obj6, null, "Content", objArray9, strArray3, null), null, "Substring", args, paramnames, null), null, "ToUpper", new object[0], null, null));
        objArray13 = objArray12;
        copyBack = new bool[] { true };
        if (copyBack[0])
        {
          objArray8 = objArray10;
          objArray8[num10] = RuntimeHelpers.GetObjectValue(obj7);
          objArray8[index] = RuntimeHelpers.GetObjectValue(frame);
          LateBinding.LateSetComplex(LateBinding.LateGet(LateBinding.LateGet(obj6, null, "Content", objArray9, strArray3, null), null, "Substring", args, paramnames, null), null, "ToUpper", new object[] { RuntimeHelpers.GetObjectValue(objArray13[0]) }, null, true, true);
        }
        if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(null, typeof(Strings), "Asc", objArray6, null, flagArray), 0x41, false) < 0, ObjectType.ObjTst(LateBinding.LateGet(null, typeof(Strings), "Asc", objArray13, null, copyBack), 90, false) > 0), StringType.StrCmp(this.vstrFilter, "@", false) == 0), !Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null))))))
          flag = true;
        else if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null), null, "ToUpper", new object[0], null, null), this.vstrFilter, false) == 0)
          flag = true;
        goto Label_11ED;
Label_0ADF:
        if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
          flag = true;
        goto Label_11ED;
Label_0AFE:
        if (StringType.StrCmp(mp.V1TAG.Title, "", false) != 0)
        {
          if (StringType.StrCmp(mp.V1TAG.Title, "", false) != 0)
          {
            if (Information.IsNumeric(mp.V1TAG.Title.Substring(0, 1)) & (StringType.StrCmp(this.vstrFilter, "#", false) == 0))
              flag = true;
            else if ((((Strings.Asc(mp.V1TAG.Title.Substring(0, 1).ToUpper()) < 0x41) | (Strings.Asc(mp.V1TAG.Title.Substring(0, 1).ToUpper()) > 90)) & (StringType.StrCmp(this.vstrFilter, "@", false) == 0)) & !Information.IsNumeric(mp.V1TAG.Title.Substring(0, 1)))
              flag = true;
            else if (StringType.StrCmp(mp.V1TAG.Title.Substring(0, 1).ToUpper(), this.vstrFilter, false) == 0)
              flag = true;
          }
        }
        else if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
        {
          flag = true;
        }
        goto Label_11ED;
Label_0CFB:
        objArray5 = new object[1];
        obj3 = mp.V2TAG.GetFrame("TALB");
        objArray2 = new object[0];
        strArray = null;
        objArray3 = new object[2];
        objArray = objArray3;
        num8 = 0;
        obj4 = 0;
        objArray[num8] = RuntimeHelpers.GetObjectValue(obj4);
        num9 = 1;
        o = 1;
        objArray[num9] = RuntimeHelpers.GetObjectValue(o);
        objArray4 = objArray;
        strArray2 = null;
        objArray5[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(obj3, null, "Content", objArray2, strArray, null), null, "Substring", objArray4, strArray2, null), null, "ToUpper", new object[0], null, null));
        objArray6 = objArray5;
        flagArray = new bool[] { true };
        if (flagArray[0])
        {
          objArray = objArray3;
          objArray[num8] = RuntimeHelpers.GetObjectValue(obj4);
          objArray[num9] = RuntimeHelpers.GetObjectValue(o);
          LateBinding.LateSetComplex(LateBinding.LateGet(LateBinding.LateGet(obj3, null, "Content", objArray2, strArray, null), null, "Substring", objArray4, strArray2, null), null, "ToUpper", new object[] { RuntimeHelpers.GetObjectValue(objArray6[0]) }, null, true, true);
        }
        objArray12 = new object[1];
        obj6 = mp.V2TAG.GetFrame("TALB");
        objArray9 = new object[0];
        strArray3 = null;
        objArray10 = new object[2];
        objArray8 = objArray10;
        num10 = 0;
        obj7 = 0;
        objArray8[num10] = RuntimeHelpers.GetObjectValue(obj7);
        index = 1;
        frame = 1;
        objArray8[index] = RuntimeHelpers.GetObjectValue(frame);
        args = objArray8;
        paramnames = null;
        objArray12[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(obj6, null, "Content", objArray9, strArray3, null), null, "Substring", args, paramnames, null), null, "ToUpper", new object[0], null, null));
        objArray13 = objArray12;
        copyBack = new bool[] { true };
        if (copyBack[0])
        {
          objArray8 = objArray10;
          objArray8[num10] = RuntimeHelpers.GetObjectValue(obj7);
          objArray8[index] = RuntimeHelpers.GetObjectValue(frame);
          LateBinding.LateSetComplex(LateBinding.LateGet(LateBinding.LateGet(obj6, null, "Content", objArray9, strArray3, null), null, "Substring", args, paramnames, null), null, "ToUpper", new object[] { RuntimeHelpers.GetObjectValue(objArray13[0]) }, null, true, true);
        }
        if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.BitAndObj(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(null, typeof(Strings), "Asc", objArray6, null, flagArray), 0x41, false) < 0, ObjectType.ObjTst(LateBinding.LateGet(null, typeof(Strings), "Asc", objArray13, null, copyBack), 90, false) > 0), StringType.StrCmp(this.vstrFilter, "@", false) == 0), !Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null))))))
          flag = true;
        else if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null), null, "ToUpper", new object[0], null, null), this.vstrFilter, false) == 0)
          flag = true;
        goto Label_11ED;
Label_10A1:
        if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
          flag = true;
        goto Label_11ED;
Label_10C0:
        if (StringType.StrCmp(mp.V1TAG.Album, "", false) != 0)
        {
          if (StringType.StrCmp(mp.V1TAG.Album, "", false) != 0)
          {
            if (Information.IsNumeric(mp.V1TAG.Album.Substring(0, 1)) & (StringType.StrCmp(this.vstrFilter, "#", false) == 0))
              flag = true;
            else if ((((Strings.Asc(mp.V1TAG.Album.Substring(0, 1).ToUpper()) < 0x41) | (Strings.Asc(mp.V1TAG.Album.Substring(0, 1).ToUpper()) > 90)) & (StringType.StrCmp(this.vstrFilter, "@", false) == 0)) & !Information.IsNumeric(mp.V1TAG.Album.Substring(0, 1)))
              flag = true;
            else if (StringType.StrCmp(mp.V1TAG.Album.Substring(0, 1).ToUpper(), this.vstrFilter, false) == 0)
              flag = true;
          }
        }
        else if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
          flag = true;
        goto Label_11ED;
Label_11EA:
        flag = true;
Label_11ED:
        if (!flag)
          goto Label_23AA;
        ListViewItem item = new ListViewItem(mp.CurrentName);
        if (mp.Selected)
        {
          item.Selected = true;
          mp.Selected = false;
        }
        int num7 = this.MP3View.Columns.Count - 1;
        for (int i = 1; i <= num7; i++)
          item.SubItems.Add("");
        if (mp.Changed)
        {
          item.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedBack);
          item.ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedText);
        }
        if (mp.FileTAGCompare)
        {
          item.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorCompareBack);
          item.ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorCompareText);
        }
        if (mp.Doubled)
        {
          item.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorDoubleBack);
          item.ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorDoubleText);
        }
        if (this.MP3View.Columns.Contains(this.colHSubDir))
          item.SubItems[this.colHSubDir.Index].Text = StringType.FromObject(Declarations.objSettings.CurrentPath.EndsWith(":") ? mp.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath + @"\", "") : mp.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath, ""));
        if (!((mp.Bitrate > 0x61a80) | (mp.Bitrate == 0)))
        {
          if (this.MP3View.Columns.Contains(this.colHChannel))
            item.SubItems[this.colHChannel.Index].Text = mp.ChannelText;
          if (this.MP3View.Columns.Contains(this.colHBitrate))
            item.SubItems[this.colHBitrate.Index].Text = StringType.FromInteger(mp.Bitrate / 1000);
          if (this.MP3View.Columns.Contains(this.colHVBR))
            item.SubItems[this.colHVBR.Index].Text = StringType.FromObject(mp.VBR ? "VBR" : "CBR");
          if (this.MP3View.Columns.Contains(this.colHSamplerate))
            item.SubItems[this.colHSamplerate.Index].Text = StringType.FromInteger(mp.Samplerate);
          if (this.MP3View.Columns.Contains(this.colHVersion))
            item.SubItems[this.colHVersion.Index].Text = mp.VersionText + " " + mp.LayerText;
          if (this.MP3View.Columns.Contains(this.colHDuration))
            item.SubItems[this.colHDuration.Index].Text = mp.DurationFormated;
        }
        else
        {
          if (this.MP3View.Columns.Contains(this.colHChannel))
            item.SubItems[this.colHChannel.Index].Text = "";
          if (this.MP3View.Columns.Contains(this.colHBitrate))
            item.SubItems[this.colHBitrate.Index].Text = "";
          if (this.MP3View.Columns.Contains(this.colHVBR))
            item.SubItems[this.colHVBR.Index].Text = "";
          if (this.MP3View.Columns.Contains(this.colHSamplerate))
            item.SubItems[this.colHSamplerate.Index].Text = "";
          if (this.MP3View.Columns.Contains(this.colHVersion))
            item.SubItems[this.colHVersion.Index].Text = "";
          if (this.MP3View.Columns.Contains(this.colHDuration))
            item.SubItems[this.colHDuration.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHTAGVer1))
          item.SubItems[this.colHTAGVer1.Index].Text = mp.V1TAG.TAGVersion.ToString().Replace("0", "-").Replace("1-", "1.0").Replace("11", "1.1");
        if (this.MP3View.Columns.Contains(this.colHTAGVer2))
          item.SubItems[this.colHTAGVer2.Index].Text = mp.V2TAG.TAGVersion.ToString().Replace("2", "2.2").Replace("3", "2.3").Replace("4", "2.4").Replace("0", "-");
        if (this.MP3View.Columns.Contains(this.colHDate))
          item.SubItems[this.colHDate.Index].Text = mp.FI.LastWriteTime.ToString();
        if (this.MP3View.Columns.Contains(this.colHCreateDate))
          item.SubItems[this.colHCreateDate.Index].Text = mp.FI.CreationTime.ToString();
        if (this.MP3View.Columns.Contains(this.colHFileSize))
          item.SubItems[this.colHFileSize.Index].Text = (mp.FI.Length / 1024L).ToString();
        if (this.MP3View.Columns.Contains(this.colHAudioCheckSum))
          item.SubItems[this.colHAudioCheckSum.Index].Text = StringType.FromObject(mp.AudioCheckSum != 0 ? mp.AudioCheckSum.ToString() : "");
        if (!mp.V2TAG.TAGHeaderPresent || (this.vbytVersionToShow != 2))
          goto Label_216E;
        if (this.MP3View.Columns.Contains(this.colHArtist))
        {
          if (mp.V2TAG.FrameExists("TPE1"))
            item.SubItems[this.colHArtist.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
          else
            item.SubItems[this.colHArtist.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHTitle))
        {
          if (mp.V2TAG.FrameExists("TIT2"))
            item.SubItems[this.colHTitle.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
          else
            item.SubItems[this.colHTitle.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHAlbum))
        {
          if (mp.V2TAG.FrameExists("TALB"))
            item.SubItems[this.colHAlbum.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
          else
            item.SubItems[this.colHAlbum.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHTrack))
        {
          if (mp.V2TAG.FrameExists("TRCK"))
            item.SubItems[this.colHTrack.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null));
          else
            item.SubItems[this.colHTrack.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHGenre))
        {
          if (mp.V2TAG.FrameExists("TCON"))
            item.SubItems[this.colHGenre.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null));
          else
            item.SubItems[this.colHGenre.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHYear))
        {
          if (mp.V2TAG.FrameExists("TYER"))
            item.SubItems[this.colHYear.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TYER"), null, "Content", new object[0], null, null));
          else if (mp.V2TAG.FrameExists("TDRC"))
          {
            try
            {
              item.SubItems[this.colHYear.Index].Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TDRC"), null, "Content", new object[0], null, null), null, "SubString", new object[] { 0, 4 }, null, null));
            }
            catch (Exception exception1)
            {
              ProjectData.SetProjectError(exception1);
              ProjectData.ClearProjectError();
            }
          }
          else
            item.SubItems[this.colHYear.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHPosMedia))
        {
          if (mp.V2TAG.FrameExists("TPOS"))
            item.SubItems[this.colHPosMedia.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TPOS"), null, "Content", new object[0], null, null));
          else
            item.SubItems[this.colHPosMedia.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHBPM))
        {
          if (mp.V2TAG.FrameExists("TBPM"))
          {
            if (mp.V2TAG.FrameExists("TBPM"))
            {
              try
              {
                if (StringType.StrCmp(mp.V2TAG.GetTextWebFrameContent("TBPM").Trim(new char[] { ' ' }), "", false) == 0)
                  item.SubItems[this.colHBPM.Index].Text = "";
                else
                  item.SubItems[this.colHBPM.Index].Text = ((int)Math.Round(Conversion.Fix(Conversion.Val(mp.V2TAG.GetTextWebFrameContent("TBPM").Trim(new char[] { ' ' }))))).ToString();
              }
              catch (Exception exception2)
              {
                ProjectData.SetProjectError(exception2);
                mp.V2TAG.RemoveFrame("TBPM");
                item.SubItems[this.colHBPM.Index].Text = "";
                ProjectData.ClearProjectError();
              }
            }
            else
              item.SubItems[this.colHBPM.Index].Text = "";
          }
          else
            item.SubItems[this.colHBPM.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHComment))
        {
          if (mp.V2TAG.FrameExists("COMM"))
          {
            var enumerator2 = mp.V2TAG.GetFrames("COMM").GetEnumerator();
            while (enumerator2.MoveNext())
            {
              objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
              item.SubItems[this.colHComment.Index].Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null));
              goto Label_1FBE;
            }
          }
          else
            item.SubItems[this.colHComment.Index].Text = "";
        }
Label_1FBE:
        if (this.MP3View.Columns.Contains(this.colHRating))
        {
          if (mp.V2TAG.FrameExists("POPM"))
          {
            var enumerator = mp.V2TAG.GetFrames("POPM").GetEnumerator();
            while (enumerator.MoveNext())
            {
              objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
              item.SubItems[this.colHRating.Index].Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Rating", new object[0], null, null));
              goto Label_208F;
            }
          }
          else
            item.SubItems[this.colHRating.Index].Text = "";
        }
Label_208F:
        if (this.MP3View.Columns.Contains(this.colHComposer))
        {
          if (mp.V2TAG.FrameExists("TCOM"))
            item.SubItems[this.colHComposer.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TCOM"), null, "Content", new object[0], null, null));
          else
            item.SubItems[this.colHComposer.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHPicCount))
          item.SubItems[this.colHPicCount.Index].Text = StringType.FromInteger(mp.V2TAG.GetFrames("APIC").Count);
Label_216E:
        if (mp.V1TAG.TAGPresent && (this.vbytVersionToShow == 1))
        {
          if (this.MP3View.Columns.Contains(this.colHArtist))
            item.SubItems[this.colHArtist.Index].Text = mp.V1TAG.Artist;
          if (this.MP3View.Columns.Contains(this.colHTitle))
            item.SubItems[this.colHTitle.Index].Text = mp.V1TAG.Title;
          if (this.MP3View.Columns.Contains(this.colHAlbum))
            item.SubItems[this.colHAlbum.Index].Text = mp.V1TAG.Album;
          if (this.MP3View.Columns.Contains(this.colHTrack))
            item.SubItems[this.colHTrack.Index].Text = StringType.FromObject(mp.V1TAG.Tracknumber > 0 ? mp.V1TAG.Tracknumber.ToString() : "");
          if (this.MP3View.Columns.Contains(this.colHYear))
            item.SubItems[this.colHYear.Index].Text = StringType.FromObject(mp.V1TAG.Year > 0 ? mp.V1TAG.Year.ToString() : "");
          if (this.MP3View.Columns.Contains(this.colHGenre))
            item.SubItems[this.colHGenre.Index].Text = mp.V1TAG.GenreText;
          if (this.MP3View.Columns.Contains(this.colHComment))
            item.SubItems[this.colHComment.Index].Text = mp.V1TAG.Comment;
        }
        item.Tag = mp;
        this.MP3View.Items.Add(item);
Label_23AA:
        if ((num3 > 0) && ((num2 % num3) == 0))
          frmProg.ProgressBar.PerformStep();
        if (num2 == list.Count)
          frmProg.ProgressBar.Value = frmProg.ProgressBar.Maximum;
      }
    }

    private void MP3View_ItemDrag(object sender, ItemDragEventArgs e)
    {
      string[] data = new string[(this.MP3View.SelectedItems.Count - 1) + 1];
      int num2 = this.MP3View.SelectedItems.Count - 1;
      for (int i = 0; i <= num2; i++)
        data[i] = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(this.MP3View.SelectedItems[i].Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null));
      DataObject obj2 = new DataObject(DataFormats.FileDrop, data);
      obj2.SetData(data);
      this.MP3View.DoDragDrop(obj2, DragDropEffects.Move | DragDropEffects.Copy);
    }

    private void MP3View_KeyDown(object sender, KeyEventArgs e)
    {
      if (e.Control & (e.KeyCode == Keys.Enter))
      {
        frmMain main;
        if (this.MP3View.SelectedItems.Count != 1)
        {
          switch (Declarations.objSettings.EditDialog)
          {
            case 1:
              main = this;
              new frmTAG1Multi(ref main).ShowDialog(this);
              break;

            case 2:
              main = this;
              new frmTAG2Multi(ref main).ShowDialog(this);
              break;

            case 3:
              if (this.vbytVersionToShow != 1)
              {
                main = this;
                new frmTAG2Multi(ref main).ShowDialog(this);
                break;
              }
              main = this;
              new frmTAG1Multi(ref main).ShowDialog(this);
              break;
          }
        }
        else
        {
          switch (Declarations.objSettings.EditDialog)
          {
            case 1:
              main = this;
              new frmTAG1(ref main).ShowDialog(this);
              break;

            case 2:
              main = this;
              new frmTAG2(ref main).ShowDialog(this);
              break;

            case 3:
              if (this.vbytVersionToShow != 1)
              {
                main = this;
                new frmTAG2(ref main).ShowDialog(this);
                break;
              }
              main = this;
              new frmTAG1(ref main).ShowDialog(this);
              break;
          }
        }
      }
    }

    private void MP3View_MouseEnter(object sender, EventArgs e)
    {
      if ((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2)
        this.EnumInfo.Visible = true;
    }

    private void MP3View_MouseLeave(object sender, EventArgs e)
    {
      this.EnumInfo.Visible = false;
    }

    private void MP3View_MouseMove(object sender, MouseEventArgs e)
    {
      this.EnumInfo.Left = e.X + this.MP3View.Left;
      this.EnumInfo.Top = (e.Y + this.MP3View.Top) - 0x12;
    }

    private void MP3View_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        // FIXME DNB ButtonItem item = (ButtonItem)this.DotNetBarManager.ContextMenus["MP3ViewMenu"];
        //item.Displayed = false;
        //item.PopupMenu(Control.MousePosition);
      }
    }

    private void MP3View_SaveColumns()
    {
      Declarations.objSettings.Columns.Rows.Clear();
      int[] columnOrder = Id3TagIT_Main.GetColumnOrder(this.MP3View);

      foreach (int num in columnOrder)
      {
        ColumnHeader header = this.MP3View.Columns[num];
        DataRow row = Declarations.objSettings.Columns.NewRow();

        if (header == this.colHFilename)
          row["ID"] = 1;

        if (header == this.colHSubDir)
          row["ID"] = 2;

        if (header == this.colHTAGVer1)
          row["ID"] = 3;

        if (header == this.colHTAGVer2)
          row["ID"] = 4;

        if (header == this.colHArtist)
          row["ID"] = 5;

        if (header == this.colHTitle)
          row["ID"] = 6;

        if (header == this.colHAlbum)
          row["ID"] = 7;

        if (header == this.colHTrack)
          row["ID"] = 8;

        if (header == this.colHPosMedia)
          row["ID"] = 9;

        if (header == this.colHComment)
          row["ID"] = 10;

        if (header == this.colHGenre)
          row["ID"] = 11;

        if (header == this.colHYear)
          row["ID"] = 12;

        if (header == this.colHRating)
          row["ID"] = 13;

        if (header == this.colHDuration)
          row["ID"] = 14;

        if (header == this.colHBitrate)
          row["ID"] = 15;

        if (header == this.colHVBR)
          row["ID"] = 0x10;

        if (header == this.colHSamplerate)
          row["ID"] = 0x11;

        if (header == this.colHChannel)
          row["ID"] = 0x12;

        if (header == this.colHVersion)
          row["ID"] = 0x13;

        if (header == this.colHDate)
          row["ID"] = 20;

        if (header == this.colHComposer)
          row["ID"] = 0x15;

        if (header == this.colHFileSize)
          row["ID"] = 0x16;

        if (header == this.colHBPM)
          row["ID"] = 0x17;

        if (header == this.colHPicCount)
          row["ID"] = 0x18;

        if (header == this.colHAudioCheckSum)
          row["ID"] = 0x19;

        if (header == this.colHCreateDate)
          row["ID"] = 0x1a;

        row["Width"] = header.Width;
        row["Alignment"] = header.TextAlign.ToString();
        Declarations.objSettings.Columns.Rows.Add(row);
      }
    }

    private void MP3View_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.Timer.Start();
    }

    // FIXME - These are the external tools clicks
    //private void SideBar_ItemClick_Fuck(object sender, EventArgs e)
    //{
    //  if ((sender is BaseItem) && StringType.FromObject(LateBinding.LateGet(sender, null, "Name", new object[0], null, null)).StartsWith("ToolItem"))
    //  {
    //    Process process = new Process();
    //    DataRow row = Declarations.objSettings.Tools.Rows[IntegerType.FromObject(LateBinding.LateGet(sender, null, "Tag", new object[0], null, null))];
    //    try
    //    {
    //      ListViewItem current;
    //      IEnumerator enumerator = null;
    //      if (BooleanType.FromObject(row["DefaultPlayer"]))
    //      {
    //        var enumerator2 = this.MP3View.SelectedItems.GetEnumerator();
    //        while (enumerator2.MoveNext())
    //        {
    //          current = (ListViewItem)enumerator2.Current;
    //          process.StartInfo.FileName = StringType.FromObject(
    //            ObjectType.StrCatObj(
    //              ObjectType.StrCatObj(
    //                '"', LateBinding.LateGet(LateBinding.LateGet(current.Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null)), '"'));
    //          process.StartInfo.Verb = StringType.FromObject(row["ShellCommand"]);
    //          process.Start();
    //        }
    //        return;
    //      }
    //      try
    //      {
    //        enumerator = this.MP3View.SelectedItems.GetEnumerator();
    //        while (enumerator.MoveNext())
    //        {
    //          current = (ListViewItem)enumerator.Current;
    //          process.StartInfo.FileName = StringType.FromObject(row["ToolPath"]);
    //          process.StartInfo.Arguments = StringType.FromObject(
    //            LateBinding.LateGet(
    //              row["ToolParameter"], null, "Replace", new object[] { "%P", ObjectType.StrCatObj(
    //                ObjectType.StrCatObj(
    //                  '"', LateBinding.LateGet(
    //                    LateBinding.LateGet(current.Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null)), '"') }, null, null));
    //          process.Start();
    //        }
    //      }
    //      finally
    //      {
    //        if (enumerator is IDisposable)
    //          ((IDisposable)enumerator).Dispose();
    //      }
    //    }
    //    catch (Exception exception1)
    //    {
    //      ProjectData.SetProjectError(exception1);
    //      ProjectData.ClearProjectError();
    //    }
    //  }
    //}

    private void TimerEventProcessor(object myObject, EventArgs myEventArgs)
    {
      MP3 tag;
      byte num3;

      if (this.vbooStartUp)
        return;

      if (this.vintSelTimerCount == this.MP3View.SelectedItems.Count)
        this.vbytSelTimerCount = (byte)(this.vbytSelTimerCount + 1);
      else
        this.vintSelTimerCount = this.MP3View.SelectedItems.Count;

      if (this.vbytSelTimerCount > 5)
      {
        this.Timer.Stop();
        this.vbytSelTimerCount = 0;
      }

      int num = 0;

      foreach (ListViewItem item in this.MP3View.SelectedItems)
        num = IntegerType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(item.Tag, null, "Duration", new object[0], null, null)));

      int num6 = num / 3600;
      num6 = (num - ((num / 3600) * 3600)) / 60;
      string introduced34 = num6.ToString().PadLeft(2, '0') + ":";
      num6 = (num - ((num / 3600) * 3600)) - (((num - ((num / 3600) * 3600)) / 60) * 60);
      string introduced35 = introduced34 + num6.ToString().PadLeft(2, '0') + ":";
      string str = introduced35 + num6.ToString().PadLeft(2, '0');
      object[] args = new object[] { "%3", str };
      bool[] copyBack = new bool[] { false, true };

      if (copyBack[1])
        str = StringType.FromObject(args[1]);

      lblNumber.Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["Number"], null, "Replace", new object[] { "%1", this.MP3View.Items.Count.ToString() }, null, null), null, "Replace", new object[] { "%2", this.MP3View.SelectedItems.Count.ToString() }, null, null), null, "Replace", args, null, copyBack));

      try
      {
        if (this.MP3View.FocusedItem != null)
          lblLength.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", this.MP3View.FocusedItem.Text.Length.ToString() }, null, null));
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        lblLength.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", "0" }, null, null));
        ProjectData.ClearProjectError();
      }

      this.cboQEArtist.Text = "";
      this.txtQETitle.Text = "";
      this.txtQEAlbum.Text = "";

      try
      {
        this.picCover.Image = null;
      }
      catch (Exception exception3)
      {
        ProjectData.SetProjectError(exception3);
        Exception exception = exception3;
        ProjectData.ClearProjectError();
      }

      try
      {
        if (this.PicMStream != null)
          this.PicMStream.Close();
      }
      catch (Exception exception4)
      {
        ProjectData.SetProjectError(exception4);
        Exception exception2 = exception4;
        ProjectData.ClearProjectError();
      }

      if (this.vbytVersionToShow != 1)
      {
        num3 = 0;

        if (this.MP3View.SelectedItems.Count == 1)
        {
          tag = (MP3)this.MP3View.SelectedItems[0].Tag;

          if (tag.V2TAG.FrameExists("TPE1"))
            this.cboQEArtist.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));

          if (tag.V2TAG.FrameExists("TIT2"))
            this.txtQETitle.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));

          if (tag.V2TAG.FrameExists("TALB"))
            this.txtQEAlbum.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
        }

        if (this.MP3View.SelectedItems.Count <= 1)
          goto Label_0B93;

        tag = (MP3)this.MP3View.SelectedItems[0].Tag;

        foreach (ListViewItem item in this.MP3View.SelectedItems)
        {
          MP3 mp4 = (MP3)item.Tag;

          if (tag != mp4)
          {
            if ((((num3 & 1) == 0) && tag.V2TAG.FrameExists("TPE1")) && mp4.V2TAG.FrameExists("TPE1"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp4.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp4.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), "", false) == 0)))
                num3 = (byte)(num3 | 1);
            }
            else
              num3 = (byte)(num3 | 1);

            if ((((num3 & 2) == 0) && tag.V2TAG.FrameExists("TIT2")) && mp4.V2TAG.FrameExists("TIT2"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp4.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp4.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), "", false) == 0)))
                num3 = (byte)(num3 | 2);
            }
            else
              num3 = (byte)(num3 | 2);

            if ((((num3 & 4) == 0) && tag.V2TAG.FrameExists("TALB")) && mp4.V2TAG.FrameExists("TALB"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp4.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp4.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), "", false) == 0)))
                num3 = (byte)(num3 | 4);
            }
            else
              num3 = (byte)(num3 | 4);

            if (num3 == 7)
              break;
          }
        }
      }
      else
      {
        MP3 mp;
        byte num2 = 0;

        if (this.MP3View.SelectedItems.Count == 1)
        {
          mp = (MP3)this.MP3View.SelectedItems[0].Tag;
          this.cboQEArtist.Text = mp.V1TAG.Artist;
          this.txtQETitle.Text = mp.V1TAG.Title;
          this.txtQEAlbum.Text = mp.V1TAG.Album;
        }

        if (this.MP3View.SelectedItems.Count > 1)
        {
          mp = (MP3)this.MP3View.SelectedItems[0].Tag;

          foreach (ListViewItem item in this.MP3View.SelectedItems)
          {
            MP3 mp2 = (MP3)item.Tag;

            if (mp != mp2)
            {
              if ((((num2 & 1) == 0) && (StringType.StrCmp(mp2.V1TAG.Artist.ToLower(), mp.V1TAG.Artist.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Artist, "", false) == 0))
                num2 = (byte)(num2 | 1);

              if ((((num2 & 2) == 0) && (StringType.StrCmp(mp2.V1TAG.Title.ToLower(), mp.V1TAG.Title.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Title, "", false) == 0))
                num2 = (byte)(num2 | 2);

              if ((((num2 & 4) == 0) && (StringType.StrCmp(mp2.V1TAG.Album.ToLower(), mp.V1TAG.Album.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Album, "", false) == 0))
                num2 = (byte)(num2 | 4);

              if (num2 == 7)
                break;
            }
          }

          if (num2 != 7)
          {
            if ((num2 & 1) == 0)
              this.cboQEArtist.Text = mp.V1TAG.Artist;

            if ((num2 & 2) == 0)
              this.txtQETitle.Text = mp.V1TAG.Title;

            if ((num2 & 4) == 0)
              this.txtQEAlbum.Text = mp.V1TAG.Album;
          }
        }
        goto Label_0B93;
      }

      if (num3 != 7)
      {
        if ((num3 & 1) == 0)
          this.cboQEArtist.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));

        if ((num3 & 2) == 0)
          this.txtQETitle.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));

        if ((num3 & 4) == 0)
          this.txtQEAlbum.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
      }

Label_0B93:
      if (this.pnlInformation.Tag.ToString() == "Expanded" & (this.MP3View.SelectedItems.Count == 1))
      {
        MP3 mp5 = (MP3)this.MP3View.SelectedItems[0].Tag;
        this.txtInformation.Text = "";
        this.txtInformation.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHDuration.Text + ":", this.colHDuration.Text.Length < 9 ? "\t\t" : "\t"), mp5.DurationFormated), "\r\n"));
        long num4 = mp5.FI.Length / 1024L;
        this.txtInformation.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHFileSize.Text + ":", this.colHFileSize.Text.Length < 9 ? "\t\t" : "\t"), num4.ToString()), "\r\n")));
        int num5 = mp5.Bitrate / 1000;
        this.txtInformation.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHBitrate.Text + ":", this.colHBitrate.Text.Length < 9 ? "\t\t" : "\t"), num5.ToString()), "\r\n")));
        this.txtInformation.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHVBR.Text + ":", this.colHVBR.Text.Length < 9 ? "\t\t" : "\t"), mp5.VBR ? "VBR" : "CBR"), "\r\n")));
        this.txtInformation.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHSamplerate.Text + ":", this.colHSamplerate.Text.Length < 9 ? "\t\t" : "\t"), mp5.Samplerate), "\r\n")));
        this.txtInformation.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHChannel.Text + ":", this.colHChannel.Text.Length < 9 ? "\t\t" : "\t"), mp5.ChannelText), "\r\n")));
        this.txtInformation.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHVersion.Text + ":", this.colHVersion.Text.Length < 9 ? "\t\t" : "\t"), mp5.VersionText), " "), mp5.LayerText)));
      }
      else
      {
        this.txtInformation.Text = "";
        this.txtInformation.Text = this.colHDuration.Text + ":\r\n";
        this.txtInformation.AppendText(this.colHFileSize.Text + ":\r\n");
        this.txtInformation.AppendText(this.colHBitrate.Text + ":\r\n");
        this.txtInformation.AppendText(this.colHVBR.Text + ":\r\n");
        this.txtInformation.AppendText(this.colHSamplerate.Text + ":\r\n");
        this.txtInformation.AppendText(this.colHChannel.Text + ":\r\n");
        this.txtInformation.AppendText(this.colHVersion.Text + ":");
      }

      if (pnlPicture.Tag.ToString() == "Expanded" & (this.MP3View.SelectedItems.Count == 1))
      {
        MP3 mp6 = (MP3)this.MP3View.SelectedItems[0].Tag;

        foreach (V2APICFrame frame3 in mp6.V2TAG.GetFrames("APIC"))
        {
          if (StringType.StrCmp(frame3.Path, mp6.FI.FullName, false) == 0)
          {
            if (StringType.StrCmp(frame3.TempPath, "", false) == 0)
            {
              FileStream stream = new FileStream(mp6.FI.FullName, FileMode.Open, FileAccess.Read);
              stream.Seek((long)frame3.DataStart, SeekOrigin.Begin);
              byte[] array = new byte[(frame3.DataLength - 1) + 1];
              stream.Read(array, 0, frame3.DataLength);
              this.PicMStream = new MemoryStream(array);
              this.picCover.Image = Image.FromStream(this.PicMStream);
              stream.Close();
            }
            else
            {
              FileStream stream2 = new FileStream(frame3.TempPath, FileMode.Open, FileAccess.Read);
              stream2.Seek(0L, SeekOrigin.Begin);
              byte[] buffer2 = new byte[((int)(stream2.Length - 1L)) + 1];
              stream2.Read(buffer2, 0, buffer2.Length);
              this.PicMStream = new MemoryStream(buffer2);
              this.picCover.Image = Image.FromStream(this.PicMStream);
              stream2.Close();
            }
          }
          else
          {
            Directory.SetCurrentDirectory(Path.GetDirectoryName(mp6.FI.FullName));

            if (File.Exists(frame3.Path))
            {
              FileStream stream3 = new FileStream(frame3.Path, FileMode.Open, FileAccess.Read);
              stream3.Seek(0L, SeekOrigin.Begin);
              byte[] buffer3 = new byte[((int)(stream3.Length - 1L)) + 1];
              stream3.Read(buffer3, 0, buffer3.Length);
              this.PicMStream = new MemoryStream(buffer3);
              this.picCover.Image = Image.FromStream(this.PicMStream);
              stream3.Close();
            }
          }

          break;
        }
      }
      else
        this.picCover.Image = null;
    }

    private void txtArtistTitleAlbum_Enter(object sender, EventArgs e)
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

    private void txtQuickEdit_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
      {
        frmProgress.Callback callback;
        Form form;
        ArrayList list = new ArrayList();
        this.MP3View.BeginUpdate();
        if (this.vbytVersionToShow == 1)
        {
          form = this;
          callback = new frmProgress.Callback(this.Multi1CB);
          frmProgress progress = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback);
          progress.SetStateMultiple();
          progress.List = list;
          progress.ShowDialog(this);
        }
        else
        {
          form = this;
          callback = new frmProgress.Callback(this.Multi2CB);
          frmProgress progress2 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback);
          progress2.SetStateMultiple();
          progress2.List = list;
          progress2.ShowDialog(this);
        }
        this.MP3View.EndUpdate();
        if (list.Count > 0)
        {
          Declarations.UNDOList.Add(list);
          this.UnDoEnable(true, true);
        }
      }
    }

    #endregion

    #region Class logic

    private void AudioCheckSumCalculation()
    {
      if (Declarations.objSettings.AudioChecksumCalc)
      {
        try
        {
          if (this.CalcAudioCheckSumThread != null)
          {
            this.CalcAudioCheckSumThread.Abort();
            this.CalcAudioCheckSumThread.Join();
          }
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          Exception exception = exception1;
          ProjectData.ClearProjectError();
        }

        StatusProgressBar.Value = 0;
        StatusProgressBar.Maximum = this.MP3View.Items.Count;
        lblVersion.Visible = false;
        lblSubDirs.Visible = false;
        lblProgress.Visible = true;
        StatusProgressBar.Visible = true;
        this.CalcAudioCheckSumThread = new Thread(new ThreadStart(this.CalcAudioCheckSum));
        this.CalcAudioCheckSumThread.IsBackground = true;
        this.CalcAudioCheckSumThread.Priority = ThreadPriority.Lowest;
        this.CalcAudioCheckSumThread.Start();
      }
    }

    private void CalcAudioCheckSum()
    {
      MP3 tag = null;

      try
      {
        int num3 = this.MP3View.Items.Count - 1;

        for (int i = 0; i <= num3; i++)
        {
          tag = (MP3)this.MP3View.Items[i].Tag;

          if (tag.AudioCheckSum == 0)
          {
            tag.CalcAudioCheckSum();

            if (this.MP3View.Columns.Contains(this.colHAudioCheckSum))
              this.MP3View.Items[i].SubItems[this.colHAudioCheckSum.Index].Text = StringType.FromObject(tag.AudioCheckSum != 0 ? tag.AudioCheckSum.ToString() : "");
          }

          StatusProgressBar.PerformStep();
        }
      }
      catch (ThreadAbortException exception1)
      {
        ProjectData.SetProjectError(exception1);
        ThreadAbortException exception = exception1;

        try
        {
          tag.CloseBinaryReader();
        }
        catch (Exception exception2)
        {
          ProjectData.SetProjectError(exception2);
          ProjectData.ClearProjectError();
        }

        try
        {
          tag.CloseFileStream();
        }
        catch (Exception exception3)
        {
          ProjectData.SetProjectError(exception3);
          ProjectData.ClearProjectError();
        }

        ProjectData.ClearProjectError();
      }
      finally
      {
        lblVersion.Visible = true;
        lblSubDirs.Visible = true;
        lblProgress.Visible = false;
        StatusProgressBar.Visible = false;
      }
    }

    private void CalcGetTime()
    {
      do
      {
        Thread.Sleep(1000);
        this.vintHelpCount++;
      }
      while (false);
    }

    private bool CheckAllChanged()
    {
      foreach (ListViewItem item in this.MP3View.Items)
        if (BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)))
          return true;

      return false;
    }

    private void CopyFiles()
    {
      string path = "";
      string vLeft = "";
      bool flag = false;

      do
      {
        if (this.CheckAllChanged())
        {
          switch (Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["ChangesNotSaved"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
          {
            case MsgBoxResult.Cancel:
              return;

            case MsgBoxResult.Yes:
              this.SaveChanges();

              if (!this.CheckAllChanged())
                flag = true;

              break;

            case MsgBoxResult.No:
              flag = true;
              break;
          }
        }
        else
          flag = true;
      }
      while (!flag);

      this.FolderBrowserDialog.Description = StringType.FromObject(Declarations.objResources.ResStrings["FileCopyText"]);
      this.FolderBrowserDialog.SelectedPath = Declarations.objSettings.MoveCopyPath;

      if (this.FolderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
      {
        path = this.FolderBrowserDialog.SelectedPath;

        if (Directory.Exists(path))
        {
          try
          {
            this.CalcAudioCheckSumThread.Abort();
            this.CalcAudioCheckSumThread.Join();
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            Exception exception = exception1;
            ProjectData.ClearProjectError();
          }

          foreach (ListViewItem item in this.MP3View.SelectedItems)
            vLeft = StringType.FromObject(ObjectType.StrCatObj(vLeft, ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null), "\0")));

          Id3TagIT_Main.ShellFileOp(vLeft, path, Declarations.ShellOperation.CopyOp, Declarations.ShellOperationFlags.FilesOnly | Declarations.ShellOperationFlags.AllowUndo, this);

          if (path.StartsWith(Declarations.objSettings.CurrentPath) & Declarations.objSettings.ScanSubDirs)
            this.GetFiles(null, true, true);
          else
            this.AudioCheckSumCalculation();

          this.Focus();
          Declarations.objSettings.MoveCopyPath = path;
        }
      }
    }

    private void DeleteFiles()
    {
      string vstrDestFolder = "";
      string vLeft = "";

      if (MessageBox.Show(StringType.FromObject(Declarations.objResources.ResStrings["FileDelete"]), "", MessageBoxButtons.YesNo, MessageBoxIcon.Question, MessageBoxDefaultButton.Button2) == System.Windows.Forms.DialogResult.Yes)
      {
        IEnumerator enumerator = null;

        try
        {
          enumerator = this.MP3View.SelectedItems.GetEnumerator();
          while (enumerator.MoveNext())
          {
            ListViewItem current = (ListViewItem)enumerator.Current;
            vLeft = StringType.FromObject(ObjectType.StrCatObj(vLeft, ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(current.Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null), "\0")));
          }
        }
        finally
        {
          if (enumerator is IDisposable)
          {
            ((IDisposable)enumerator).Dispose();
          }
        }

        try
        {
          this.CalcAudioCheckSumThread.Abort();
          this.CalcAudioCheckSumThread.Join();
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          Exception exception = exception1;
          ProjectData.ClearProjectError();
        }

        if (Id3TagIT_Main.ShellFileOp(vLeft, vstrDestFolder, Declarations.ShellOperation.DeleteOp, Declarations.ShellOperationFlags.FilesOnly | Declarations.ShellOperationFlags.AllowUndo, this))
        {
          this.MP3View.BeginUpdate();

          foreach (ListViewItem item in this.MP3View.SelectedItems)
          {
            Declarations.MP3s.Remove(RuntimeHelpers.GetObjectValue(item.Tag));
            this.MP3View.Items.Remove(item);
          }

          this.MP3View.EndUpdate();
          this.AudioCheckSumCalculation();
        }
        else
          this.GetFiles(null, true, true);
      }

      this.Focus();
    }

    public void Enumerate()
    {
      if (((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2) & (this.MP3View.FocusedItem != null))
      {
        ArrayList list = new ArrayList();
        this.MP3View.BeginUpdate();

        foreach (ListViewItem item in this.MP3View.SelectedItems)
        {
          if ((this.aintLastSelected == null) || (Array.IndexOf(this.aintLastSelected, item.Index) == -1))
          {
            MP3 tag = (MP3)item.Tag;
            Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
            list.Add(@do);

            if (Declarations.objSettings.EnumFile)
            {
              tag.CurrentName = this.vintEnumCount.ToString().PadLeft(Declarations.objSettings.FilenumberDigits, '0') + Declarations.objSettings.EnumSeparator + tag.CurrentName;
              tag.Changed = true;
              item.Text = tag.CurrentName;
              item.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedBack);
              item.ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedText);
            }

            if ((Declarations.objSettings.EnumVer1 | (Declarations.objSettings.SynchronizeTAGs & Declarations.objSettings.EnumVer2)) && (this.vintEnumCount <= 0xff))
            {
              if (!tag.V1TAG.TAGPresent)
              {
                tag.V1TAG.TAGPresent = true;
                tag.V1TAG.Tracknumber = (byte)this.vintEnumCount;
                tag.Changed = true;
                this.UpdateListItem(item, false);
              }
              else if (tag.V1TAG.Tracknumber != this.vintEnumCount)
              {
                tag.V1TAG.Tracknumber = (byte)this.vintEnumCount;
                tag.Changed = true;
                this.UpdateListItem(item, false);
              }
            }

            if (Declarations.objSettings.EnumVer2 | (Declarations.objSettings.SynchronizeTAGs & Declarations.objSettings.EnumVer1))
            {
              if (tag.V2TAG.FrameExists("TRCK"))
              {
                V2TextFrame frame = (V2TextFrame)tag.V2TAG.GetFrame("TRCK");
                V2TextFrame frame2 = new V2TextFrame { FID = "TRCK" };

                if (frame.Content.IndexOf("/") < 0)
                  frame2.Content = this.vintEnumCount.ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0');
                else
                  frame2.Content = this.vintEnumCount.ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') + frame.Content.Substring(frame.Content.IndexOf("/"));

                tag.V2TAG.AddFrame(frame2);
              }
              else
              {
                V2TextFrame frame3 = new V2TextFrame
                {
                  FID = "TRCK",
                  Content = this.vintEnumCount.ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0')
                };

                tag.V2TAG.AddFrame(frame3);
              }

              if (tag.V2TAG.Changed)
              {
                if (!tag.V2TAG.TAGHeaderPresent)
                  tag.V2TAG.TAGHeaderPresent = true;

                tag.Changed = true;
              }

              this.UpdateListItem(item, false);
            }

            this.vintEnumCount++;
            this.mnutEnumerateCounter.Text = this.vintEnumCount.ToString();
          }
        }

        this.MP3View.EndUpdate();
        Declarations.UNDOList.Add(list);
        this.UnDoEnable(true, true);
      }

      this.aintLastSelected = new int[(this.MP3View.SelectedIndices.Count - 1) + 1];
      this.MP3View.SelectedIndices.CopyTo(this.aintLastSelected, 0);
    }

    private void enumerateInFilename(object sender)
    {
      ((ToolStripMenuItem)sender).Checked ^= true;

      if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
        this.aintLastSelected = null;

      Declarations.objSettings.EnumFile ^= true;

      if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
      {
        this.vintEnumCount = Declarations.objSettings.FilenumberStart;
        this.mnutEnumerateCounter.Text = StringType.FromInteger(this.vintEnumCount);
      }

      this.Enumerate();
    }

    private void enumerateInTAGVer1(object sender)
    {
      ((ToolStripMenuItem)sender).Checked ^= true;

      if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
        this.aintLastSelected = null;

      Declarations.objSettings.EnumVer1 ^= true;

      if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
      {
        this.vintEnumCount = Declarations.objSettings.FilenumberStart;
        this.mnutEnumerateCounter.Text = StringType.FromInteger(this.vintEnumCount);
      }

      this.Enumerate();
    }

    private void enumerateInTAGVer2(object sender)
    {
      ((ToolStripMenuItem)sender).Checked ^= true;

      if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
        this.aintLastSelected = null;

      Declarations.objSettings.EnumVer2 ^= true;


      if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
      {
        this.vintEnumCount = Declarations.objSettings.FilenumberStart;
        this.mnutEnumerateCounter.Text = StringType.FromInteger(this.vintEnumCount);
      }

      this.Enumerate();
    }

    private void FolderRenameCB(ref frmProgress frmProg)
    {
      IEnumerator enumerator = null;
      frmProg.btnCancel.Enabled = false;
      string oldValue = frmProg.String01;
      string newValue = frmProg.String02;

      try
      {
        enumerator = Declarations.MP3s.GetEnumerator();

        while (enumerator.MoveNext())
        {
          MP3 current = (MP3)enumerator.Current;
          current.CurrentFullName = current.CurrentFullName.Replace(oldValue, newValue);

          if (!File.Exists(current.FI.FullName))
          {
            string path = current.CurrentFullName.Substring(0, current.CurrentFullName.LastIndexOf(@"\")) + @"\" + current.FI.Name;

            if (File.Exists(path))
              current.FI = new FileInfo(path);
          }

          frmProg.ProgressBar.PerformStep();
        }
      }
      finally
      {
        if (enumerator is IDisposable)
          ((IDisposable)enumerator).Dispose();
      }
    }

    private void GetFiles([Optional, DefaultParameterValue(null)] ArrayList alstFolders, [Optional, DefaultParameterValue(true)] bool vbooClear, [Optional, DefaultParameterValue(true)] bool vbooFill)
    {
      ArrayList list = new ArrayList();

      try
      {
        if (this.GetFilesTimeThread != null)
          this.GetFilesTimeThread.Abort();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }

      try
      {
        if (this.CalcAudioCheckSumThread != null)
        {
          this.CalcAudioCheckSumThread.Abort();
          this.CalcAudioCheckSumThread.Join();
        }
      }
      catch (Exception exception4)
      {
        ProjectData.SetProjectError(exception4);
        Exception exception2 = exception4;
        ProjectData.ClearProjectError();
      }

      if (vbooClear)
      {
        this.MP3View.Items.Clear();
        Declarations.MP3s.Clear();
      }

      if (alstFolders == null)
      {
        alstFolders = new ArrayList();
        alstFolders.Add(Declarations.objSettings.CurrentPath);
      }

      Form ownerForm = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.ScanCB);
      frmProgress progress = new frmProgress(0, list.Count, 1, ref ownerForm, ref cB)
      {
        List = list,
        ListHelp = alstFolders
      };

      progress.SetStateScan();
      progress.ShowDialog(this);
      this.vintHelpCount = 0;
      this.GetFilesTimeThread = new Thread(new ThreadStart(this.CalcGetTime));
      this.GetFilesTimeThread.IsBackground = true;
      this.GetFilesTimeThread.Priority = ThreadPriority.BelowNormal;
      this.GetFilesTimeThread.Start();
      ownerForm = this;
      cB = new frmProgress.Callback(this.GetFilesCB);

      progress = new frmProgress(0, list.Count, 1, ref ownerForm, ref cB)
      {
        List = list
      };

      progress.SetStateRead();
      progress.ShowDialog(this);

      try
      {
        this.GetFilesTimeThread.Abort();
      }
      catch (Exception exception5)
      {
        ProjectData.SetProjectError(exception5);
        Exception exception3 = exception5;
        ProjectData.ClearProjectError();
      }

      if (vbooFill)
        this.MP3View_FillColumns(ref Declarations.MP3s);
    }

    private void GetFilesCB(ref frmProgress frmProg)
    {
      int num3 = 0;
      int count = frmProg.List.Count;
      int vintHelpCount = 0;

      var enumerator = frmProg.List.GetEnumerator();

      while (enumerator.MoveNext())
      {
        string vstrFullFilename = StringType.FromObject(enumerator.Current);
        Application.DoEvents();

        if (frmProg.Canceled)
          return;

        frmProg.Infos.Text = vstrFullFilename;
        MP3 mp = new MP3(vstrFullFilename);
        if (mp.ExploreMP3())
          Declarations.MP3s.Add(mp);
        if (vintHelpCount != this.vintHelpCount)
        {
          vintHelpCount = this.vintHelpCount;
          try
          {
            if (Declarations.MP3s.Count > 0)
              num3 = (count - Declarations.MP3s.Count) / (Declarations.MP3s.Count / vintHelpCount);
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            Exception exception = exception1;
            ProjectData.ClearProjectError();
          }
          int num6 = num3 / 3600;
          int num5 = (num3 / 60) % 60;
          int num4 = num3 % 60;
          frmProg.State.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["Read"], " ("), num6.ToString().PadLeft(2, '0')), ":"), num5.ToString().PadLeft(2, '0')), ":"), num4.ToString().PadLeft(2, '0')), ")"));
        }
        frmProg.ProgressBar.PerformStep();
        mp = null;
      }
    }

    private void MoveFiles()
    {
      string path = "";
      string vLeft = "";
      bool flag = false;
      do
      {
        if (this.CheckAllChanged())
        {
          switch (Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["ChangesNotSaved"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
          {
            case MsgBoxResult.Cancel:
              return;

            case MsgBoxResult.Yes:
              this.SaveChanges();
              if (!this.CheckAllChanged())
                flag = true;
              break;

            case MsgBoxResult.No:
              flag = true;
              break;
          }
        }
        else
          flag = true;
      }
      while (!flag);
      this.FolderBrowserDialog.Description = StringType.FromObject(Declarations.objResources.ResStrings["FileMoveText"]);
      this.FolderBrowserDialog.SelectedPath = Declarations.objSettings.MoveCopyPath;
      if (this.FolderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
      {
        path = this.FolderBrowserDialog.SelectedPath;
        if (Directory.Exists(path))
        {
          try
          {
            this.CalcAudioCheckSumThread.Abort();
            this.CalcAudioCheckSumThread.Join();
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            Exception exception = exception1;
            ProjectData.ClearProjectError();
          }
          foreach (ListViewItem item in this.MP3View.SelectedItems)
          {
            vLeft = StringType.FromObject(ObjectType.StrCatObj(vLeft, ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null), "\0")));
          }
          if (Id3TagIT_Main.ShellFileOp(vLeft, path, Declarations.ShellOperation.MoveOp, Declarations.ShellOperationFlags.FilesOnly | Declarations.ShellOperationFlags.AllowUndo, this))
          {
            if (!path.StartsWith(Declarations.objSettings.CurrentPath))
            {
              this.MP3View.BeginUpdate();
              foreach (ListViewItem item in this.MP3View.SelectedItems)
              {
                Declarations.MP3s.Remove(RuntimeHelpers.GetObjectValue(item.Tag));
                this.MP3View.Items.Remove(item);
              }
              this.MP3View.EndUpdate();
              this.AudioCheckSumCalculation();
            }
            else
              this.GetFiles(null, true, true);
          }
          else
            this.GetFiles(null, true, true);
          this.Focus();
          Declarations.objSettings.MoveCopyPath = path;
        }
      }
    }

    public void MP3View_AddColumns()
    {
      int num;
      this.MP3View.BeginUpdate();
      this.MP3View.Items.Clear();
      this.MP3View.Columns.Clear();
      this.colHFilename.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col01"]);
      this.colHFilename.TextAlign = HorizontalAlignment.Left;
      this.MP3View.Columns.Add(this.colHFilename);
      int num4 = Declarations.objSettings.Columns.Rows.Count - 1;
      for (num = 0; num <= num4; num++)
      {
        DataRow dataRo = Declarations.objSettings.Columns.Rows[num];
        object obj3 = dataRo["ID"];
        if (ObjectType.ObjTst(obj3, 1, false) == 0)
          this.colHFilename.Width = IntegerType.FromObject(dataRo["Width"]);
        else if (ObjectType.ObjTst(obj3, 2, false) == 0)
          this.MP3View_BuildColumns(ref this.colHSubDir, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 3, false) == 0)
          this.MP3View_BuildColumns(ref this.colHTAGVer1, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 4, false) == 0)
          this.MP3View_BuildColumns(ref this.colHTAGVer2, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 5, false) == 0)
          this.MP3View_BuildColumns(ref this.colHArtist, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 6, false) == 0)
          this.MP3View_BuildColumns(ref this.colHTitle, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 7, false) == 0)
          this.MP3View_BuildColumns(ref this.colHAlbum, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 8, false) == 0)
          this.MP3View_BuildColumns(ref this.colHTrack, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 9, false) == 0)
          this.MP3View_BuildColumns(ref this.colHPosMedia, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 10, false) == 0)
          this.MP3View_BuildColumns(ref this.colHComment, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 11, false) == 0)
          this.MP3View_BuildColumns(ref this.colHGenre, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 12, false) == 0)
          this.MP3View_BuildColumns(ref this.colHYear, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 13, false) == 0)
          this.MP3View_BuildColumns(ref this.colHRating, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 14, false) == 0)
          this.MP3View_BuildColumns(ref this.colHDuration, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 15, false) == 0)
          this.MP3View_BuildColumns(ref this.colHBitrate, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x10, false) == 0)
          this.MP3View_BuildColumns(ref this.colHVBR, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x11, false) == 0)
          this.MP3View_BuildColumns(ref this.colHSamplerate, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x12, false) == 0)
          this.MP3View_BuildColumns(ref this.colHChannel, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x13, false) == 0)
          this.MP3View_BuildColumns(ref this.colHVersion, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 20, false) == 0)
          this.MP3View_BuildColumns(ref this.colHDate, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x15, false) == 0)
          this.MP3View_BuildColumns(ref this.colHComposer, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x16, false) == 0)
          this.MP3View_BuildColumns(ref this.colHFileSize, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x17, false) == 0)
          this.MP3View_BuildColumns(ref this.colHBPM, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x18, false) == 0)
          this.MP3View_BuildColumns(ref this.colHPicCount, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x19, false) == 0)
          this.MP3View_BuildColumns(ref this.colHAudioCheckSum, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        else if (ObjectType.ObjTst(obj3, 0x1a, false) == 0)
          this.MP3View_BuildColumns(ref this.colHCreateDate, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
      }
      if (ObjectType.ObjTst(Declarations.objSettings.Columns.Rows[0]["ID"], 1, false) != 0)
      {
        int[] sortOrder = new int[(Declarations.objSettings.Columns.Rows.Count - 1) + 1];
        int num2 = 1;
        int num3 = Declarations.objSettings.Columns.Rows.Count - 1;
        for (num = 0; num <= num3; num++)
        {
          DataRow row2 = Declarations.objSettings.Columns.Rows[num];
          object obj2 = row2["ID"];
          if (ObjectType.ObjTst(obj2, 1, false) == 0)
            sortOrder[num] = 0;
          else
          {
            sortOrder[num] = num2;
            num2++;
          }
        }
        Id3TagIT_Main.SetColumnOrder(this.MP3View, sortOrder);
      }
      this.MP3View.EndUpdate();
    }

    private void Multi1CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
          break;
        MP3 tag = (MP3)item.Tag;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        frmProg.Infos.Text = tag.CurrentFullName;
        if (this.MP3View.SelectedItems.Count == 1)
        {
          if (StringType.StrCmp(tag.V1TAG.Artist, this.cboQEArtist.Text.Trim(new char[] { ' ' }), false) != 0)
          {
            tag.V1TAG.Artist = this.cboQEArtist.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (StringType.StrCmp(tag.V1TAG.Title, this.txtQETitle.Text.Trim(new char[] { ' ' }), false) != 0)
          {
            tag.V1TAG.Title = this.txtQETitle.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (StringType.StrCmp(tag.V1TAG.Album, this.txtQEAlbum.Text.Trim(new char[] { ' ' }), false) != 0)
          {
            tag.V1TAG.Album = this.txtQEAlbum.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
        }
        else
        {
          if ((StringType.StrCmp(tag.V1TAG.Artist, this.cboQEArtist.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.cboQEArtist.Text.Trim(new char[] { ' ' }), "", false) != 0))
          {
            tag.V1TAG.Artist = this.cboQEArtist.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if ((StringType.StrCmp(tag.V1TAG.Title, this.txtQETitle.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.txtQETitle.Text.Trim(new char[] { ' ' }), "", false) != 0))
          {
            tag.V1TAG.Title = this.txtQETitle.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if ((StringType.StrCmp(tag.V1TAG.Album, this.txtQEAlbum.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.txtQEAlbum.Text.Trim(new char[] { ' ' }), "", false) != 0))
          {
            tag.V1TAG.Album = this.txtQEAlbum.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
        }
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          object obj2;
          if (this.MP3View.SelectedItems.Count == 1)
          {
            obj2 = ID3Functions.CreateTextFrame("TPE1", this.cboQEArtist.Text.Trim(new char[] { ' ' }));
            if (StringType.StrCmp(this.cboQEArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            obj2 = ID3Functions.CreateTextFrame("TIT2", this.txtQETitle.Text.Trim(new char[] { ' ' }));
            if (StringType.StrCmp(this.txtQETitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            obj2 = ID3Functions.CreateTextFrame("TALB", this.txtQEAlbum.Text.Trim(new char[] { ' ' }));
            if (StringType.StrCmp(this.txtQEAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
          else
          {
            if (StringType.StrCmp(this.cboQEArtist.Text.Trim(new char[] { ' ' }), "", false) != 0)
            {
              obj2 = ID3Functions.CreateTextFrame("TPE1", this.cboQEArtist.Text.Trim(new char[] { ' ' }));
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            }
            if (StringType.StrCmp(this.txtQETitle.Text.Trim(new char[] { ' ' }), "", false) != 0)
            {
              obj2 = ID3Functions.CreateTextFrame("TIT2", this.txtQETitle.Text.Trim(new char[] { ' ' }));
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            }
            if (StringType.StrCmp(this.txtQEAlbum.Text.Trim(new char[] { ' ' }), "", false) != 0)
            {
              obj2 = ID3Functions.CreateTextFrame("TALB", this.txtQEAlbum.Text.Trim(new char[] { ' ' }));
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            }
          }
          if (tag.V2TAG.Changed)
          {
            if (!tag.V2TAG.TAGHeaderPresent)
              tag.V2TAG.TAGHeaderPresent = true;
            tag.Changed = true;
          }
        }
        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void Multi2CB(ref frmProgress frmProg)
    {
      ListViewItem item2 = new ListViewItem();
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        object obj2;
        Application.DoEvents();
        if (frmProg.Canceled)
          break;
        MP3 tag = (MP3)item.Tag;
        frmProg.Infos.Text = tag.CurrentFullName;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        if (this.MP3View.SelectedItems.Count == 1)
        {
          obj2 = ID3Functions.CreateTextFrame("TPE1", this.cboQEArtist.Text.Trim(new char[] { ' ' }));
          if (StringType.StrCmp(this.cboQEArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
            LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          obj2 = ID3Functions.CreateTextFrame("TIT2", this.txtQETitle.Text.Trim(new char[] { ' ' }));
          if (StringType.StrCmp(this.txtQETitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
            LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          obj2 = ID3Functions.CreateTextFrame("TALB", this.txtQEAlbum.Text.Trim(new char[] { ' ' }));
          if (StringType.StrCmp(this.txtQEAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
            LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
        }
        else
        {
          if (StringType.StrCmp(this.cboQEArtist.Text.Trim(new char[] { ' ' }), "", false) != 0)
          {
            obj2 = ID3Functions.CreateTextFrame("TPE1", this.cboQEArtist.Text.Trim(new char[] { ' ' }));
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
          if (StringType.StrCmp(this.txtQETitle.Text.Trim(new char[] { ' ' }), "", false) != 0)
          {
            obj2 = ID3Functions.CreateTextFrame("TIT2", this.txtQETitle.Text.Trim(new char[] { ' ' }));
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
          if (StringType.StrCmp(this.txtQEAlbum.Text.Trim(new char[] { ' ' }), "", false) != 0)
          {
            obj2 = ID3Functions.CreateTextFrame("TALB", this.txtQEAlbum.Text.Trim(new char[] { ' ' }));
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
        }
        if (tag.V2TAG.Changed)
        {
          if (!tag.V2TAG.TAGHeaderPresent)
            tag.V2TAG.TAGHeaderPresent = true;
          tag.Changed = true;
          this.UpdateListItem(item, false);
        }
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (this.MP3View.SelectedItems.Count == 1)
          {
            if (StringType.StrCmp(tag.V1TAG.Artist, this.cboQEArtist.Text.Trim(new char[] { ' ' }), false) != 0)
            {
              tag.V1TAG.Artist = this.cboQEArtist.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
            if (StringType.StrCmp(tag.V1TAG.Title, this.txtQETitle.Text.Trim(new char[] { ' ' }), false) != 0)
            {
              tag.V1TAG.Title = this.txtQETitle.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
            if (StringType.StrCmp(tag.V1TAG.Album, this.txtQEAlbum.Text.Trim(new char[] { ' ' }), false) != 0)
            {
              tag.V1TAG.Album = this.txtQEAlbum.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
          }
          else
          {
            if ((StringType.StrCmp(tag.V1TAG.Artist, this.cboQEArtist.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.cboQEArtist.Text.Trim(new char[] { ' ' }), "", false) != 0))
            {
              tag.V1TAG.Artist = this.cboQEArtist.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
            if ((StringType.StrCmp(tag.V1TAG.Title, this.txtQETitle.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.txtQETitle.Text.Trim(new char[] { ' ' }), "", false) != 0))
            {
              tag.V1TAG.Title = this.txtQETitle.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
            if ((StringType.StrCmp(tag.V1TAG.Album, this.txtQEAlbum.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.txtQEAlbum.Text.Trim(new char[] { ' ' }), "", false) != 0))
            {
              tag.V1TAG.Album = this.txtQEAlbum.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
          }
          this.UpdateListItem(item, false);
        }
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void Paste1CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
          break;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (LateBinding.LateGet(this.alstCopyPaste[0], null, "V1TAG", new object[0], null, null) != null)
          LateBinding.LateSetComplex(item.Tag, null, "V1TAG", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.alstCopyPaste[0], null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null)) }, null, false, true);
        if (LateBinding.LateGet(this.alstCopyPaste[0], null, "V2TAG", new object[0], null, null) != null)
        {
          LateBinding.LateSetComplex(item.Tag, null, "V2TAG", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.alstCopyPaste[0], null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null)) }, null, false, true);
          MP3 tag = (MP3)item.Tag;
          foreach (V2APICFrame frame in tag.V2TAG.GetFrames("APIC"))
          {
            if ((StringType.StrCmp(frame.MIMEType, "-->", false) != 0) && (StringType.StrCmp(frame.Path, tag.FI.FullName, false) != 0))
            {
              if (StringType.StrCmp(frame.TempPath, "", false) == 0)
              {
                FileStream stream = new FileStream(frame.Path, FileMode.Open, FileAccess.Read);
                stream.Seek((long)frame.DataStart, SeekOrigin.Begin);
                byte[] array = new byte[(frame.DataLength - 1) + 1];
                stream.Read(array, 0, frame.DataLength);
                frame.TempPath = Id3TagIT_Main.CreateTempFile(array, "");
                frame.Path = tag.FI.FullName;
                frame.DataLength = 0;
                frame.DataStart = 0;
              }
              else
                frame.Path = tag.FI.FullName;
            }
          }
        }
        LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
        this.UpdateListItem(item, true);
        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void Paste2CB(ref frmProgress frmProg)
    {
      int num = 0;
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
          break;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (LateBinding.LateGet(this.alstCopyPaste[num], null, "V1TAG", new object[0], null, null) != null)
          LateBinding.LateSetComplex(item.Tag, null, "V1TAG", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.alstCopyPaste[num], null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null)) }, null, false, true);
        if (LateBinding.LateGet(this.alstCopyPaste[num], null, "V2TAG", new object[0], null, null) != null)
        {
          LateBinding.LateSetComplex(item.Tag, null, "V2TAG", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.alstCopyPaste[num], null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null)) }, null, false, true);
          MP3 tag = (MP3)item.Tag;
          foreach (V2APICFrame frame in tag.V2TAG.GetFrames("APIC"))
          {
            if ((StringType.StrCmp(frame.MIMEType, "-->", false) != 0) && (StringType.StrCmp(frame.Path, tag.FI.FullName, false) != 0))
            {
              if (StringType.StrCmp(frame.TempPath, "", false) == 0)
              {
                FileStream stream = new FileStream(frame.Path, FileMode.Open, FileAccess.Read);
                stream.Seek((long)frame.DataStart, SeekOrigin.Begin);
                byte[] array = new byte[(frame.DataLength - 1) + 1];
                stream.Read(array, 0, frame.DataLength);
                frame.TempPath = Id3TagIT_Main.CreateTempFile(array, "");
                frame.Path = tag.FI.FullName;
                frame.DataLength = 0;
                frame.DataStart = 0;
              }
              else
                frame.Path = tag.FI.FullName;
            }
          }
        }
        LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
        this.UpdateListItem(item, true);
        this.UpdateListItem(item, false);
        num++;
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void Paste3CB(ref frmProgress frmProg)
    {
      int num = 0;
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
          break;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (LateBinding.LateGet(this.alstCopyPaste[num], null, "V1TAG", new object[0], null, null) != null)
          LateBinding.LateSetComplex(item.Tag, null, "V1TAG", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.alstCopyPaste[num], null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null)) }, null, false, true);
        if (LateBinding.LateGet(this.alstCopyPaste[num], null, "V2TAG", new object[0], null, null) != null)
        {
          LateBinding.LateSetComplex(item.Tag, null, "V2TAG", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.alstCopyPaste[num], null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null)) }, null, false, true);
          MP3 tag = (MP3)item.Tag;
          foreach (V2APICFrame frame in tag.V2TAG.GetFrames("APIC"))
          {
            if ((StringType.StrCmp(frame.MIMEType, "-->", false) != 0) && (StringType.StrCmp(frame.Path, tag.FI.FullName, false) != 0))
            {
              if (StringType.StrCmp(frame.TempPath, "", false) == 0)
              {
                FileStream stream = new FileStream(frame.Path, FileMode.Open, FileAccess.Read);
                stream.Seek((long)frame.DataStart, SeekOrigin.Begin);
                byte[] array = new byte[(frame.DataLength - 1) + 1];
                stream.Read(array, 0, frame.DataLength);
                frame.TempPath = Id3TagIT_Main.CreateTempFile(array, "");
                frame.Path = tag.FI.FullName;
                frame.DataLength = 0;
                frame.DataStart = 0;
              }
              else
                frame.Path = tag.FI.FullName;
            }
          }
        }
        LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
        this.UpdateListItem(item, true);
        this.UpdateListItem(item, false);
        if (num == (this.alstCopyPaste.Count - 1))
          break;
        num++;
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void queryFreeDb()
    {
      int num2 = 0;

      foreach (ListViewItem item19 in this.MP3View.SelectedItems)
        num2 = IntegerType.FromObject(ObjectType.AddObj(num2, LateBinding.LateGet(item19.Tag, null, "Duration", new object[0], null, null)));

      if (((this.MP3View.SelectedItems.Count > 0) & (this.MP3View.SelectedItems.Count < 100)) & (num2 < 0x1770))
        new frmFreeDB(this).ShowDialog();
      else
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["FreeDBToLong"]), MsgBoxStyle.Exclamation, null);
    }

    private void ReDoCB(ref frmProgress frmProg)
    {
      IEnumerator enumerator = null;
      int num = 0;
      try
      {
        enumerator = frmProg.List.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Declarations.UnDoReDo current = (Declarations.UnDoReDo)enumerator.Current;
          num++;
          V1TAG introduced4 = current.MP3.V1TAG.Clone();
          V2TAG introduced5 = current.MP3.V2TAG.Clone();
          Declarations.UnDoReDo do2 = new Declarations.UnDoReDo(current.MP3, introduced4, introduced5, current.MP3.CurrentFullName, current.MP3.Changed);
          frmProg.ListHelp.Add(do2);
          current.MP3.V1TAG = current.V1TAG.Clone();
          current.MP3.V2TAG = current.V2TAG.Clone();
          current.MP3.CurrentFullName = current.Filename;
          current.MP3.Changed = current.Changed;
          if ((num % 50) == 0)
            frmProg.ProgressBar.PerformStep();
        }
      }
      finally
      {
        if (enumerator is IDisposable)
          ((IDisposable)enumerator).Dispose();
      }
    }

    private void Remove1CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
          break;
        frmProg.Infos.Text = StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null));
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (BooleanType.FromObject(LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "TAGPresent", new object[0], null, null)))
        {
          LateBinding.LateCall(item.Tag, null, "RemoveV1TAG", new object[0], null, null);
          LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
          this.UpdateListItem(item, BooleanType.FromObject(Declarations.objSettings.VersionToShow == 1));
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            LateBinding.LateCall(item.Tag, null, "RemoveV2TAG", new object[0], null, null);
            LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
            this.UpdateListItem(item, BooleanType.FromObject(Declarations.objSettings.VersionToShow == 2));
          }
        }
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void Remove2CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
          break;
        frmProg.Infos.Text = StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null));
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (BooleanType.FromObject(LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "TAGHeaderPresent", new object[0], null, null)))
        {
          LateBinding.LateCall(item.Tag, null, "RemoveV2TAG", new object[0], null, null);
          LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
          this.UpdateListItem(item, BooleanType.FromObject(Declarations.objSettings.VersionToShow == 2));
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            LateBinding.LateCall(item.Tag, null, "RemoveV1TAG", new object[0], null, null);
            LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
            this.UpdateListItem(item, BooleanType.FromObject(Declarations.objSettings.VersionToShow == 1));
          }
        }
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void RemoveV1Tag()
    {
      ArrayList list7 = new ArrayList();

      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      if (Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["TAGRemove"], null, "Replace", new object[] { "%1", "1" }, null, null), null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Question | MsgBoxStyle.OkCancel, null) == MsgBoxResult.Ok)
      {
        this.MP3View.BeginUpdate();

        var form = (Form)this;
        var callback = new frmProgress.Callback(this.Remove1CB);

        frmProgress progress6 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback);
        progress6.SetStateRemoveTAG();
        progress6.List = list7;
        progress6.ShowDialog(this);
        this.MP3View.EndUpdate();

        if (list7.Count > 0)
        {
          Declarations.UNDOList.Add(list7);
          this.UnDoEnable(true, true);
        }
      }
    }

    private void RemoveV2Tag()
    {
      ArrayList list8 = new ArrayList();

      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      if (Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["TAGRemove"], null, "Replace", new object[] { "%1", "2" }, null, null), null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Question | MsgBoxStyle.OkCancel, null) == MsgBoxResult.Ok)
      {
        this.MP3View.BeginUpdate();
        var form = (Form)this;
        var callback = new frmProgress.Callback(this.Remove2CB);
        frmProgress progress7 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback);
        progress7.SetStateRemoveTAG();
        progress7.List = list8;
        progress7.ShowDialog(this);
        this.MP3View.EndUpdate();

        if (list8.Count > 0)
        {
          Declarations.UNDOList.Add(list8);
          this.UnDoEnable(true, true);
        }
      }
    }

    private void SaveChanges()
    {
      int vintMaximum = 0;

      foreach (ListViewItem item in this.MP3View.Items)
      {
        MP3 tag = (MP3)item.Tag;

        if (tag.Changed)
          vintMaximum++;
      }

      if (vintMaximum > 0)
      {
        try
        {
          if (this.CalcAudioCheckSumThread != null)
          {
            this.CalcAudioCheckSumThread.Abort();
            this.CalcAudioCheckSumThread.Join();
          }
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          Exception exception = exception1;
          ProjectData.ClearProjectError();
        }

        Form ownerForm = this;
        frmProgress.Callback cB = new frmProgress.Callback(this.SaveChangesCB);
        frmProgress progress = new frmProgress(0, vintMaximum, 1, ref ownerForm, ref cB);
        progress.SetStateSave();
        progress.ShowDialog(this);
        this.AudioCheckSumCalculation();
      }
    }

    private void SaveChangesCB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.Items)
      {
        if (frmProg.Canceled)
          break;

        MP3 tag = (MP3)item.Tag;

        if (tag.Changed)
        {
          frmProg.Infos.Text = tag.CurrentFullName;

          if (tag.WriteChanges())
          {
            item.BackColor = SystemColors.Window;
            item.ForeColor = SystemColors.WindowText;

            if (tag.FileTAGCompare)
            {
              item.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorCompareBack);
              item.ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorCompareText);
            }

            if (tag.Doubled)
            {
              item.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorDoubleBack);
              item.ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorDoubleText);
            }

            frmProg.ProgressBar.PerformStep();
          }
          else
          {
            ListViewItem item2 = new ListViewItem
            {
              Text = StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null))
            };

            object[] objArray2 = new object[1];
            DataRow resStrings = Declarations.objResources.ResStrings;
            string str = "ErrorCouldNotWriteChanges";
            objArray2[0] = RuntimeHelpers.GetObjectValue(resStrings[str]);
            object[] args = objArray2;
            bool[] copyBack = new bool[] { true };
            LateBinding.LateCall(item2.SubItems, null, "Add", args, null, copyBack);

            if (copyBack[0])
              resStrings[str] = RuntimeHelpers.GetObjectValue(args[0]);

            this.ErrorMsg.Items.Insert(0, item2);
            // FIXME - Exp this.SplitterBottom.Expanded = true;
          }
        }

        Application.DoEvents();
      }
    }

    private void ScanCB(ref frmProgress frmProg)
    {
      frmProgress progress = frmProg;
      ArrayList alstFile = progress.List;
      Id3TagIT_Main.ScanForFiles(frmProg.ListHelp, "*.mp3", Declarations.objSettings.ScanSubDirs, ref alstFile, ref frmProg);
      progress.List = alstFile;
    }

    private void SetLanguage()
    {
      foreach (DataColumn column in Declarations.objResources.MenuTable.Columns)
      {
        // FIXME - internationalization
        //var enumerator = this.DotNetBarManager.GetItems(column.ColumnName).GetEnumerator();
        //while (enumerator.MoveNext())
        //{
        //  object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
        //  try
        //  {
        //    LateBinding.LateSet(objectValue, null, "Text", new object[] { Declarations.objResources.GetMenuText(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Name", new object[0], null, null))) }, null);
        //  }
        //  catch (Exception exception1)
        //  {
        //    ProjectData.SetProjectError(exception1);
        //    Exception exception = exception1;
        //    ProjectData.ClearProjectError();
        //  }
        //  try
        //  {
        //    LateBinding.LateSet(objectValue, null, "Tooltip", new object[] { Declarations.objResources.GetMenuToolTip(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Name", new object[0], null, null))) }, null);
        //    continue;
        //  }
        //  catch (Exception exception4)
        //  {
        //    ProjectData.SetProjectError(exception4);
        //    Exception exception2 = exception4;
        //    ProjectData.ClearProjectError();
        //    continue;
        //  }
        //}
      }
      //((ButtonItem)this.DotNetBarManager.ContextMenus["MP3ViewMenu"]).SubItems["TAGV1"].Text = Declarations.objResources.GetMenuText("TAGV1");
      //((ButtonItem)this.DotNetBarManager.ContextMenus["MP3ViewMenu"]).SubItems["TAGV2"].Text = Declarations.objResources.GetMenuText("TAGV2");

      try
      {
        btnSwitchV1V2.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
      }
      catch (Exception exception5)
      {
        ProjectData.SetProjectError(exception5);
        Exception exception3 = exception5;
        ProjectData.ClearProjectError();
      }

      lblVersion.Text = StringType.FromObject(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], Declarations.objSettings.VersionToShow.ToString()));
      object[] objArray2 = new object[2];
      objArray2[0] = "%1";
      Settings objSettings = Declarations.objSettings;
      objArray2[1] = objSettings.CurrentPath;
      object[] args = objArray2;
      bool[] copyBack = new bool[] { false, true };
      if (copyBack[1])
        objSettings.CurrentPath = StringType.FromObject(args[1]);
      lblPath.Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", args, null, copyBack));
      lblProgress.Text = StringType.FromObject(Declarations.objResources.ResStrings["ProgressChecksum"]);
      if (Declarations.objSettings.ScanSubDirs)
        lblSubDirs.Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsYes"]);
      else
        lblSubDirs.Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsNo"]);
      this.colHFilename.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col01"]);
      this.colHSubDir.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col02"]);
      this.colHTAGVer1.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col03"]);
      this.colHTAGVer2.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col04"]);
      this.colHArtist.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col05"]);
      this.colHTitle.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col06"]);
      this.colHAlbum.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col07"]);
      this.colHTrack.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col08"]);
      this.colHPosMedia.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col09"]);
      this.colHComment.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col10"]);
      this.colHGenre.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col11"]);
      this.colHYear.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col12"]);
      this.colHRating.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col13"]);
      this.colHDuration.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col14"]);
      this.colHBitrate.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col15"]);
      this.colHVBR.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col16"]);
      this.colHSamplerate.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col17"]);
      this.colHChannel.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col18"]);
      this.colHVersion.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col19"]);
      this.colHDate.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col20"]);
      this.colHComposer.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col21"]);
      this.colHFileSize.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col22"]);
      this.colHBPM.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col23"]);
      this.colHPicCount.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col24"]);
      this.colHAudioCheckSum.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col25"]);
      this.colHCreateDate.Text = StringType.FromObject(Declarations.objResources.ResStrings["Col26"]);
      this.colHErrFile.Text = StringType.FromObject(Declarations.objResources.ResStrings["CHError1"]);
      this.colHErrMsg.Text = StringType.FromObject(Declarations.objResources.ResStrings["CHError2"]);
      this.lblQEArtist.Text = this.colHArtist.Text;
      this.lblQETitle.Text = this.colHTitle.Text;
      this.lblQEAlbum.Text = this.colHAlbum.Text;
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      this.Timer.Start();
    }
    //this.NavigationPan.RecalcLayout();
    //this.NavigationPan.Refresh();
    // this.BarGroupTools.Refresh();
    // this.BarGroupEdit.Refresh();
    // this.BarGroupPicture.Refresh();
    //this.BarGroupTools.Text = StringType.FromObject(Declarations.objResources.ResStrings["ToolsPan"]);
    //this.BarGroupEdit.Text = StringType.FromObject(Declarations.objResources.ResStrings["QuickEditPan"]);
    //this.BarGroupPicture.Text = StringType.FromObject(Declarations.objResources.ResStrings["PicturePan"]);

    private void SplitArtist1CB(ref frmProgress frmProg)
    {
      string str2 = frmProg.String01;
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        MP3 tag = (MP3)item.Tag;
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        if (tag.V1TAG.TAGPresent && (tag.V1TAG.Artist.IndexOf(str2) >= 0))
        {
          tag.V1TAG.Title = tag.V1TAG.Artist.Substring(tag.V1TAG.Artist.IndexOf(str2) + str2.Length);
          tag.V1TAG.Artist = tag.V1TAG.Artist.Substring(0, tag.V1TAG.Artist.IndexOf(str2));
          tag.Changed = true;
        }
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (tag.V2TAG.TAGHeaderPresent)
          {
            string str = null;
            if (tag.V2TAG.FrameExists("TPE1"))
            {
              str = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
            }
            if (str.IndexOf(str2) >= 0)
            {
              V2TextFrame frame = ID3Functions.CreateTextFrame("TIT2", str.Substring(str.IndexOf(str2) + str2.Length));
              tag.V2TAG.AddFrame(frame);
              frame = ID3Functions.CreateTextFrame("TPE1", str.Substring(0, str.IndexOf(str2)));
              tag.V2TAG.AddFrame(frame);
            }
          }
          if (tag.V2TAG.Changed)
          {
            tag.Changed = true;
          }
        }
        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void SplitArtist2CB(ref frmProgress frmProg)
    {
      string str2 = frmProg.String01;
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        MP3 tag = (MP3)item.Tag;
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        if (tag.V2TAG.TAGHeaderPresent)
        {
          string str = null;
          if (tag.V2TAG.FrameExists("TPE1"))
          {
            str = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
          }
          if (str.IndexOf(str2) >= 0)
          {
            V2TextFrame frame = ID3Functions.CreateTextFrame("TIT2", str.Substring(str.IndexOf(str2) + str2.Length));
            tag.V2TAG.AddFrame(frame);
            frame = ID3Functions.CreateTextFrame("TPE1", str.Substring(0, str.IndexOf(str2)));
            tag.V2TAG.AddFrame(frame);
          }
        }
        if (tag.V2TAG.Changed)
        {
          tag.Changed = true;
        }
        if ((Declarations.objSettings.SynchronizeTAGs && tag.V1TAG.TAGPresent) && (tag.V1TAG.Artist.IndexOf(str2) >= 0))
        {
          tag.V1TAG.Title = tag.V1TAG.Artist.Substring(tag.V1TAG.Artist.IndexOf(str2) + str2.Length);
          tag.V1TAG.Artist = tag.V1TAG.Artist.Substring(0, tag.V1TAG.Artist.IndexOf(str2));
          tag.Changed = true;
        }
        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void SwapArtistAlbum1CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        MP3 tag = (MP3)item.Tag;
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);

        frmProg.List.Add(@do);

        if (tag.V1TAG.TAGPresent)
        {
          string album = tag.V1TAG.Album;
          tag.V1TAG.Album = tag.V1TAG.Artist;
          tag.V1TAG.Artist = album;
        }

        tag.Changed = true;

        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (tag.V2TAG.TAGHeaderPresent)
          {
            string str2;
            string str3;

            if (tag.V2TAG.FrameExists("TPE1"))
              str2 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
            else
              str2 = "";

            if (tag.V2TAG.FrameExists("TALB"))
              str3 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
            else
              str3 = "";

            V2TextFrame frame = ID3Functions.CreateTextFrame("TALB", str2);

            frame.Remove = (StringType.StrCmp(str2, "", false) == 0);
            tag.V2TAG.AddFrame(frame);
            frame = ID3Functions.CreateTextFrame("TPE1", str3);
            frame.Remove = (StringType.StrCmp(str3, "", false) == 0);
            tag.V2TAG.AddFrame(frame);
          }

          if (tag.V2TAG.Changed)
            tag.Changed = true;
        }
        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void SwapArtistAlbum2CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        MP3 tag = (MP3)item.Tag;
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);

        if (tag.V2TAG.TAGHeaderPresent)
        {
          string str2;
          string str3;

          if (tag.V2TAG.FrameExists("TPE1"))
            str2 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
          else
            str2 = "";

          if (tag.V2TAG.FrameExists("TALB"))
            str3 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
          else
            str3 = "";

          V2TextFrame frame = ID3Functions.CreateTextFrame("TALB", str2);

          frame.Remove = (StringType.StrCmp(str2, "", false) == 0);
          tag.V2TAG.AddFrame(frame);
          frame = ID3Functions.CreateTextFrame("TPE1", str3);
          frame.Remove = (StringType.StrCmp(str3, "", false) == 0);

          tag.V2TAG.AddFrame(frame);
        }

        if (tag.V2TAG.Changed)
          tag.Changed = true;

        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (tag.V1TAG.TAGPresent)
          {
            string album = tag.V1TAG.Album;
            tag.V1TAG.Album = tag.V1TAG.Artist;
            tag.V1TAG.Artist = album;
          }

          tag.Changed = true;
        }

        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void swapArtistAlbumV1()
    {
      Form form;
      frmProgress.Callback callback;
      ArrayList list11 = new ArrayList();
      this.MP3View.BeginUpdate();
      form = this;
      callback = new frmProgress.Callback(this.SwapArtistAlbum1CB);
      frmProgress progress10 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback) { List = list11 };
      progress10.SetStateSwap();
      progress10.ShowDialog(this);
      this.MP3View.EndUpdate();

      if (list11.Count > 0)
      {
        Declarations.UNDOList.Add(list11);
        this.UnDoEnable(true, true);
      }
    }

    private void swapArtistAlbumV2()
    {
      Form form;
      frmProgress.Callback callback;
      ArrayList list12 = new ArrayList();
      this.MP3View.BeginUpdate();
      form = this;
      callback = new frmProgress.Callback(this.SwapArtistAlbum2CB);
      frmProgress progress11 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback) { List = list12 };
      progress11.SetStateSwap();
      progress11.ShowDialog(this);
      this.MP3View.EndUpdate();

      if (list12.Count > 0)
      {
        Declarations.UNDOList.Add(list12);
        this.UnDoEnable(true, true);
      }
    }

    private void SwapArtistTitle1CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        MP3 tag = (MP3)item.Tag;
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        if (tag.V1TAG.TAGPresent)
        {
          string title = tag.V1TAG.Title;
          tag.V1TAG.Title = tag.V1TAG.Artist;
          tag.V1TAG.Artist = title;
        }
        tag.Changed = true;
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (tag.V2TAG.TAGHeaderPresent)
          {
            string str2;
            string str3;
            if (tag.V2TAG.FrameExists("TPE1"))
            {
              str2 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
            }
            else
            {
              str2 = "";
            }
            if (tag.V2TAG.FrameExists("TIT2"))
            {
              str3 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
            }
            else
            {
              str3 = "";
            }
            V2TextFrame frame = ID3Functions.CreateTextFrame("TIT2", str2);
            if (StringType.StrCmp(str2, "", false) == 0)
            {
              frame.Remove = true;
            }
            else
            {
              frame.Remove = false;
            }
            tag.V2TAG.AddFrame(frame);
            frame = ID3Functions.CreateTextFrame("TPE1", str3);
            if (StringType.StrCmp(str3, "", false) == 0)
            {
              frame.Remove = true;
            }
            else
            {
              frame.Remove = false;
            }
            tag.V2TAG.AddFrame(frame);
          }
          if (tag.V2TAG.Changed)
          {
            tag.Changed = true;
          }
        }
        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void SwapArtistTitle2CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        MP3 tag = (MP3)item.Tag;
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        if (tag.V2TAG.TAGHeaderPresent)
        {
          string str2;
          string str3;
          if (tag.V2TAG.FrameExists("TPE1"))
          {
            str2 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
          }
          else
          {
            str2 = "";
          }
          if (tag.V2TAG.FrameExists("TIT2"))
          {
            str3 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
          }
          else
          {
            str3 = "";
          }
          V2TextFrame frame = ID3Functions.CreateTextFrame("TIT2", str2);
          if (StringType.StrCmp(str2, "", false) == 0)
          {
            frame.Remove = true;
          }
          else
          {
            frame.Remove = false;
          }
          tag.V2TAG.AddFrame(frame);
          frame = ID3Functions.CreateTextFrame("TPE1", str3);
          if (StringType.StrCmp(str3, "", false) == 0)
          {
            frame.Remove = true;
          }
          else
          {
            frame.Remove = false;
          }
          tag.V2TAG.AddFrame(frame);
        }
        if (tag.V2TAG.Changed)
        {
          tag.Changed = true;
        }
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (tag.V1TAG.TAGPresent)
          {
            string title = tag.V1TAG.Title;
            tag.V1TAG.Title = tag.V1TAG.Artist;
            tag.V1TAG.Artist = title;
          }
          tag.Changed = true;
        }
        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void swapArtistTitleV1()
    {
      Form form;
      frmProgress.Callback callback;
      ArrayList list9 = new ArrayList();
      this.MP3View.BeginUpdate();
      form = this;
      callback = new frmProgress.Callback(this.SwapArtistTitle1CB);
      frmProgress progress8 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback) { List = list9 };
      progress8.SetStateSwap();
      progress8.ShowDialog(this);
      this.MP3View.EndUpdate();

      if (list9.Count > 0)
      {
        Declarations.UNDOList.Add(list9);
        this.UnDoEnable(true, true);
      }
    }

    private void swapArtistTitleV2()
    {
      Form form;
      frmProgress.Callback callback;
      ArrayList list10 = new ArrayList();
      this.MP3View.BeginUpdate();
      form = this;
      callback = new frmProgress.Callback(this.SwapArtistTitle2CB);
      frmProgress progress9 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback) { List = list10 };
      progress9.SetStateSwap();
      progress9.ShowDialog(this);
      this.MP3View.EndUpdate();

      if (list10.Count > 0)
      {
        Declarations.UNDOList.Add(list10);
        this.UnDoEnable(true, true);
      }
    }

    private void SwapTitleAlbum1CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        MP3 tag = (MP3)item.Tag;
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        if (tag.V1TAG.TAGPresent)
        {
          string album = tag.V1TAG.Album;
          tag.V1TAG.Album = tag.V1TAG.Title;
          tag.V1TAG.Title = album;
        }
        tag.Changed = true;
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (tag.V2TAG.TAGHeaderPresent)
          {
            string str2;
            string str3;
            if (tag.V2TAG.FrameExists("TIT2"))
            {
              str2 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
            }
            else
            {
              str2 = "";
            }
            if (tag.V2TAG.FrameExists("TALB"))
            {
              str3 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
            }
            else
            {
              str3 = "";
            }
            V2TextFrame frame = ID3Functions.CreateTextFrame("TALB", str2);
            if (StringType.StrCmp(str2, "", false) == 0)
            {
              frame.Remove = true;
            }
            else
            {
              frame.Remove = false;
            }
            tag.V2TAG.AddFrame(frame);
            frame = ID3Functions.CreateTextFrame("TIT2", str3);
            if (StringType.StrCmp(str3, "", false) == 0)
            {
              frame.Remove = true;
            }
            else
            {
              frame.Remove = false;
            }
            tag.V2TAG.AddFrame(frame);
          }
          if (tag.V2TAG.Changed)
          {
            tag.Changed = true;
          }
        }
        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void SwapTitleAlbum2CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        MP3 tag = (MP3)item.Tag;
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        if (tag.V2TAG.TAGHeaderPresent)
        {
          string str2;
          string str3;
          if (tag.V2TAG.FrameExists("TIT2"))
          {
            str2 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
          }
          else
          {
            str2 = "";
          }
          if (tag.V2TAG.FrameExists("TALB"))
          {
            str3 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
          }
          else
          {
            str3 = "";
          }
          V2TextFrame frame = ID3Functions.CreateTextFrame("TALB", str2);
          if (StringType.StrCmp(str2, "", false) == 0)
          {
            frame.Remove = true;
          }
          else
          {
            frame.Remove = false;
          }
          tag.V2TAG.AddFrame(frame);
          frame = ID3Functions.CreateTextFrame("TIT2", str3);
          if (StringType.StrCmp(str3, "", false) == 0)
          {
            frame.Remove = true;
          }
          else
          {
            frame.Remove = false;
          }
          tag.V2TAG.AddFrame(frame);
        }
        if (tag.V2TAG.Changed)
        {
          tag.Changed = true;
        }
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (tag.V1TAG.TAGPresent)
          {
            string album = tag.V1TAG.Album;
            tag.V1TAG.Album = tag.V1TAG.Title;
            tag.V1TAG.Title = album;
          }
          tag.Changed = true;
        }
        this.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void swapTitleAlbumV1()
    {
      Form form;
      frmProgress.Callback callback;
      ArrayList list13 = new ArrayList();
      this.MP3View.BeginUpdate();
      form = this;
      callback = new frmProgress.Callback(this.SwapTitleAlbum1CB);
      frmProgress progress12 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback) { List = list13 };
      progress12.SetStateSwap();
      progress12.ShowDialog(this);
      this.MP3View.EndUpdate();

      if (list13.Count > 0)
      {
        Declarations.UNDOList.Add(list13);
        this.UnDoEnable(true, true);
      }
    }

    private void swapTitleAlbumV2()
    {
      Form form;
      frmProgress.Callback callback;
      ArrayList list14 = new ArrayList();
      this.MP3View.BeginUpdate();
      form = this;
      callback = new frmProgress.Callback(this.SwapTitleAlbum2CB);
      frmProgress progress13 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback) { List = list14 };
      progress13.SetStateSwap();
      progress13.ShowDialog(this);
      this.MP3View.EndUpdate();

      if (list14.Count > 0)
      {
        Declarations.UNDOList.Add(list14);
        this.UnDoEnable(true, true);
      }
    }

    private void SwitchToV1()
    {
      if (this.vbytVersionToShow == 1)
        return;

      this.vbytVersionToShow = 1;
      Declarations.objSettings.VersionToShow = this.vbytVersionToShow;
      viewTAGVer1ToolStripMenuItem.Checked = true;
      viewTAGVer2ToolStripMenuItem.Checked = false;

      try
      {
        btnSwitchV1V2.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
      }
      catch (Exception exception13)
      {
        ProjectData.SetProjectError(exception13);
        Exception exception5 = exception13;
        ProjectData.ClearProjectError();
      }

      lblVersion.Text = StringType.FromObject(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " 1"));

      foreach (ListViewItem item16 in this.MP3View.SelectedItems)
        LateBinding.LateSetComplex(item16.Tag, null, "Selected", new object[] { true }, null, false, true);

      this.MP3View_FillColumns(ref Declarations.MP3s);
      this.MP3View.Focus();
    }

    private void SwitchToV2()
    {
      if (this.vbytVersionToShow == 2)
        return;

      this.vbytVersionToShow = 2;
      Declarations.objSettings.VersionToShow = this.vbytVersionToShow;
      viewTAGVer1ToolStripMenuItem.Checked = false;
      viewTAGVer2ToolStripMenuItem.Checked = true;

      try
      {
        btnSwitchV1V2.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
      }
      catch (Exception exception14)
      {
        ProjectData.SetProjectError(exception14);
        Exception exception6 = exception14;
        ProjectData.ClearProjectError();
      }

      lblVersion.Text = StringType.FromObject(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " 2"));

      foreach (ListViewItem item17 in this.MP3View.SelectedItems)
        LateBinding.LateSetComplex(item17.Tag, null, "Selected", new object[] { true }, null, false, true);

      this.MP3View_FillColumns(ref Declarations.MP3s);
      this.MP3View.Focus();
    }

    private void UnDoCB(ref frmProgress frmProg)
    {
      IEnumerator enumerator = null;
      int num = 0;
      try
      {
        enumerator = frmProg.List.GetEnumerator();
        while (enumerator.MoveNext())
        {
          Declarations.UnDoReDo current = (Declarations.UnDoReDo)enumerator.Current;
          num++;
          V1TAG introduced4 = current.MP3.V1TAG.Clone();
          V2TAG introduced5 = current.MP3.V2TAG.Clone();
          Declarations.UnDoReDo do2 = new Declarations.UnDoReDo(current.MP3, introduced4, introduced5, current.MP3.CurrentFullName, current.MP3.Changed);
          frmProg.ListHelp.Add(do2);
          current.MP3.V1TAG = current.V1TAG.Clone();
          current.MP3.V2TAG = current.V2TAG.Clone();
          current.MP3.CurrentFullName = current.Filename;
          current.MP3.Changed = current.Changed;
          if ((num % 50) == 0)
          {
            frmProg.ProgressBar.PerformStep();
          }
        }
      }
      finally
      {
        if (enumerator is IDisposable)
          ((IDisposable)enumerator).Dispose();
      }
    }

    public void UnDoEnable(bool vbooEnabled, bool vbooClear)
    {
      this.btnUndo.Enabled = vbooEnabled;
      this.undoToolStripMenuItem.Enabled = vbooEnabled;

      if (vbooClear)
      {
        this.btnRedo.Enabled = false;
        Declarations.REDOList.Clear();
      }
    }

    public void UpdateListItem(ListViewItem lstItem, [Optional, DefaultParameterValue(false)] bool vbooClear)
    {
      object objectValue;
      MP3 tag = (MP3)lstItem.Tag;
      lstItem.Text = tag.CurrentName;

      if (tag.Changed)
      {
        lstItem.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedBack);
        lstItem.ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorChangedText);
      }

      if (tag.FileTAGCompare)
      {
        lstItem.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorCompareBack);
        lstItem.ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorCompareText);
      }

      if (tag.Doubled)
      {
        lstItem.BackColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorDoubleBack);
        lstItem.ForeColor = System.Drawing.Color.FromArgb(Declarations.objSettings.ColorDoubleText);
      }

      if (this.MP3View.Columns.Contains(this.colHTAGVer1))
        lstItem.SubItems[this.colHTAGVer1.Index].Text = tag.V1TAG.TAGVersion.ToString().Replace("0", "-").Replace("1-", "1.0").Replace("11", "1.1");

      if (this.MP3View.Columns.Contains(this.colHTAGVer2))
        lstItem.SubItems[this.colHTAGVer2.Index].Text = tag.V2TAG.TAGVersion.ToString().Replace("2", "2.2").Replace("3", "2.3").Replace("4", "2.4").Replace("0", "-");

      if (this.MP3View.Columns.Contains(this.colHDate))
        lstItem.SubItems[this.colHDate.Index].Text = tag.FI.LastWriteTime.ToString();

      if (this.MP3View.Columns.Contains(this.colHCreateDate))
        lstItem.SubItems[this.colHCreateDate.Index].Text = tag.FI.CreationTime.ToString();

      if (this.MP3View.Columns.Contains(this.colHFileSize))
        lstItem.SubItems[this.colHFileSize.Index].Text = (tag.FI.Length / 0x400L).ToString();

      if (this.MP3View.Columns.Contains(this.colHAudioCheckSum))
        lstItem.SubItems[this.colHAudioCheckSum.Index].Text = StringType.FromObject(tag.AudioCheckSum != 0 ? tag.AudioCheckSum.ToString() : "");

      if (vbooClear)
      {
        if (this.MP3View.Columns.Contains(this.colHArtist))
          lstItem.SubItems[this.colHArtist.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHTitle))
          lstItem.SubItems[this.colHTitle.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHAlbum))
          lstItem.SubItems[this.colHAlbum.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHTrack))
          lstItem.SubItems[this.colHTrack.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHGenre))
          lstItem.SubItems[this.colHGenre.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHYear))
          lstItem.SubItems[this.colHYear.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHPosMedia))
          lstItem.SubItems[this.colHPosMedia.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHComment))
          lstItem.SubItems[this.colHComment.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHRating))
          lstItem.SubItems[this.colHRating.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHComposer))
          lstItem.SubItems[this.colHComposer.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHBPM))
          lstItem.SubItems[this.colHBPM.Index].Text = "";

        if (this.MP3View.Columns.Contains(this.colHPicCount))
        {
          lstItem.SubItems[this.colHPicCount.Index].Text = "";
          return;
        }

        return;
      }

      if (!tag.V2TAG.TAGHeaderPresent || (this.vbytVersionToShow != 2))
        goto Label_0DA3;

      if (this.MP3View.Columns.Contains(this.colHArtist))
      {
        if (tag.V2TAG.FrameExists("TPE1"))
          lstItem.SubItems[this.colHArtist.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
        else
          lstItem.SubItems[this.colHArtist.Index].Text = "";
      }

      if (this.MP3View.Columns.Contains(this.colHTitle))
      {
        if (tag.V2TAG.FrameExists("TIT2"))
          lstItem.SubItems[this.colHTitle.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
        else
          lstItem.SubItems[this.colHTitle.Index].Text = "";
      }

      if (this.MP3View.Columns.Contains(this.colHAlbum))
      {
        if (tag.V2TAG.FrameExists("TALB"))
          lstItem.SubItems[this.colHAlbum.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
        else
          lstItem.SubItems[this.colHAlbum.Index].Text = "";
      }

      if (this.MP3View.Columns.Contains(this.colHTrack))
      {
        if (tag.V2TAG.FrameExists("TRCK"))
          lstItem.SubItems[this.colHTrack.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null));
        else
          lstItem.SubItems[this.colHTrack.Index].Text = "";
      }

      if (this.MP3View.Columns.Contains(this.colHGenre))
      {
        if (tag.V2TAG.FrameExists("TCON"))
          lstItem.SubItems[this.colHGenre.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null));
        else
          lstItem.SubItems[this.colHGenre.Index].Text = "";
      }

      if (this.MP3View.Columns.Contains(this.colHYear))
      {
        if (tag.V2TAG.FrameExists("TYER"))
          lstItem.SubItems[this.colHYear.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TYER"), null, "Content", new object[0], null, null));
        else if (tag.V2TAG.FrameExists("TDRC"))
        {
          try
          {
            lstItem.SubItems[this.colHYear.Index].Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TDRC"), null, "Content", new object[0], null, null), null, "SubString", new object[] { 0, 4 }, null, null));
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }
        }
        else
          lstItem.SubItems[this.colHYear.Index].Text = "";
      }

      if (this.MP3View.Columns.Contains(this.colHPosMedia))
      {
        if (tag.V2TAG.FrameExists("TPOS"))
          lstItem.SubItems[this.colHPosMedia.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPOS"), null, "Content", new object[0], null, null));
        else
          lstItem.SubItems[this.colHPosMedia.Index].Text = "";
      }

      if (this.MP3View.Columns.Contains(this.colHBPM))
      {
        try
        {
          if (StringType.StrCmp(tag.V2TAG.GetTextWebFrameContent("TBPM").Trim(new char[] { ' ' }), "", false) == 0)
            lstItem.SubItems[this.colHBPM.Index].Text = "";
          else
            lstItem.SubItems[this.colHBPM.Index].Text = ((int)Math.Round(Conversion.Fix(Conversion.Val(tag.V2TAG.GetTextWebFrameContent("TBPM").Trim(new char[] { ' ' }))))).ToString();
        }
        catch (Exception exception2)
        {
          ProjectData.SetProjectError(exception2);
          tag.V2TAG.RemoveFrame("TBPM");
          lstItem.SubItems[this.colHBPM.Index].Text = "";
          ProjectData.ClearProjectError();
        }
      }

      if (this.MP3View.Columns.Contains(this.colHComment))
      {
        if (tag.V2TAG.FrameExists("COMM"))
        {
          var enumerator2 = tag.V2TAG.GetFrames("COMM").GetEnumerator();
          while (enumerator2.MoveNext())
          {
            objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
            lstItem.SubItems[this.colHComment.Index].Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null));
            goto Label_0BFB;
          }
        }
        else
          lstItem.SubItems[this.colHComment.Index].Text = "";
      }

Label_0BFB:
      if (this.MP3View.Columns.Contains(this.colHRating))
      {
        if (tag.V2TAG.FrameExists("POPM"))
        {
          var enumerator = tag.V2TAG.GetFrames("POPM").GetEnumerator();
          while (enumerator.MoveNext())
          {
            objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
            lstItem.SubItems[this.colHRating.Index].Text = StringType.FromObject(LateBinding.LateGet(objectValue, null, "Rating", new object[0], null, null));
            goto Label_0CC7;
          }
        }
        else
        {
          lstItem.SubItems[this.colHRating.Index].Text = "";
        }
      }

Label_0CC7:
      if (this.MP3View.Columns.Contains(this.colHComposer))
      {
        if (tag.V2TAG.FrameExists("TCOM"))
          lstItem.SubItems[this.colHComposer.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TCOM"), null, "Content", new object[0], null, null));
        else
          lstItem.SubItems[this.colHComposer.Index].Text = "";
      }

      if (this.MP3View.Columns.Contains(this.colHPicCount))
        lstItem.SubItems[this.colHPicCount.Index].Text = StringType.FromInteger(tag.V2TAG.GetFrames("APIC").Count);

Label_0DA3:
      if (tag.V1TAG.TAGPresent && (this.vbytVersionToShow == 1))
      {
        if (this.MP3View.Columns.Contains(this.colHArtist))
          lstItem.SubItems[this.colHArtist.Index].Text = tag.V1TAG.Artist;

        if (this.MP3View.Columns.Contains(this.colHTitle))
          lstItem.SubItems[this.colHTitle.Index].Text = tag.V1TAG.Title;

        if (this.MP3View.Columns.Contains(this.colHAlbum))
          lstItem.SubItems[this.colHAlbum.Index].Text = tag.V1TAG.Album;

        if (this.MP3View.Columns.Contains(this.colHTrack))
          lstItem.SubItems[this.colHTrack.Index].Text = StringType.FromObject(tag.V1TAG.Tracknumber > 0 ? tag.V1TAG.Tracknumber.ToString() : "");

        if (this.MP3View.Columns.Contains(this.colHYear))
          lstItem.SubItems[this.colHYear.Index].Text = StringType.FromObject(tag.V1TAG.Year > 0 ? tag.V1TAG.Year.ToString() : "");

        if (this.MP3View.Columns.Contains(this.colHGenre))
          lstItem.SubItems[this.colHGenre.Index].Text = tag.V1TAG.GenreText;

        if (this.MP3View.Columns.Contains(this.colHComment))
          lstItem.SubItems[this.colHComment.Index].Text = tag.V1TAG.Comment;
      }
    }

    #endregion

    #region New Events

    private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmAbout().ShowDialog();
    }

    private void artistAlbumToolStripMenuItem_Click(object sender, EventArgs e)
    {
      swapArtistAlbumV1();
    }

    private void artistAlbumToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      swapArtistAlbumV2();
    }

    private void artistAlbumToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      swapArtistAlbumV1();
    }

    private void artistAlbumToolStripMenuItem3_Click(object sender, EventArgs e)
    {
      swapArtistAlbumV2();
    }

    private void artistTitleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      swapArtistTitleV1();
    }

    private void artistTitleToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      swapArtistTitleV2();
    }

    private void artistTitleToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      swapArtistTitleV1();
    }

    private void artistTitleToolStripMenuItem3_Click(object sender, EventArgs e)
    {
      swapArtistTitleV2();
    }

    private void btnSwitchV1V2_Click(object sender, EventArgs e)
    {
      if (this.vbytVersionToShow != 1)
        SwitchToV1();
      else
        SwitchToV2();
    }

    private void caseConversionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmCaseConv(this).ShowDialog(this);
    }

    private void cboLanguage_Click(object sender, EventArgs e)
    {
      Declarations.objSettings.Language = (byte)cboLanguage.SelectedIndex;
      Declarations.objResources.ReadResources();
      this.SetLanguage();
    }

    private void changeTAGVer2TextencodingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      new frmEncoding(this).ShowDialog(this);
    }

    private void compareFilenameWthTAGInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.MP3View.Items.Count > 2)
        new frmCompareFileTAG(this).ShowDialog(this);
    }

    private void copyFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.CopyFiles();
    }

    private void copyTAGVer1OnlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      foreach (ListViewItem item4 in this.MP3View.SelectedItems)
      {
        var ytag2 = new Declarations.CopyTAG((V1TAG)LateBinding.LateGet(LateBinding.LateGet(item4.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), null);
        this.alstCopyPaste.Add(ytag2);
      }
    }

    private void copyTAGVer2OnlyToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.alstCopyPaste.Clear();

      foreach (ListViewItem item5 in this.MP3View.SelectedItems)
      {
        var ytag2 = new Declarations.CopyTAG(null, (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item5.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null));
        this.alstCopyPaste.Add(ytag2);
      }
    }

    private void copyTAGVer1And2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.alstCopyPaste.Clear();

      foreach (ListViewItem item6 in this.MP3View.SelectedItems)
      {
        var ytag2 = new Declarations.CopyTAG(
          (V1TAG)LateBinding.LateGet(
            LateBinding.LateGet(item6.Tag, null, "V1TAG", new object[0], null, null),
              null, "Clone", new object[0], null, null),
          (V2TAG)LateBinding.LateGet(
            LateBinding.LateGet(item6.Tag, null, "V2TAG", new object[0], null, null),
            null, "Clone", new object[0], null, null));
        this.alstCopyPaste.Add(ytag2);
      }
    }

    private void createFilelistPlaylistToolStripMenuItem_Click(object sender, EventArgs e)
    {
      bool flag3 = false;
      frmLists lists = new frmLists { MainForm = this };

      do
      {
        if (this.CheckAllChanged())
        {
          switch (Interaction.MsgBox(
            RuntimeHelpers.GetObjectValue(
              LateBinding.LateGet(
                Declarations.objResources.ResStrings["ChangesNotSaved"],
                null,
                "Replace",
                new object[] { "%C", "\r\n" }, null, null)),
            MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel,
            null))
          {
            case MsgBoxResult.Cancel:
              return;

            case MsgBoxResult.Yes:
              this.SaveChanges();
              if (!this.CheckAllChanged())
                flag3 = true;

              break;

            case MsgBoxResult.No:
              flag3 = true;
              break;
          }
        }
        else
          flag3 = true;
      }
      while (!flag3);

      lists.ShowDialog(this);
    }

    private void ctxClearErrors_Click(object sender, EventArgs e)
    {
      this.ErrorMsg.BeginUpdate();
      this.ErrorMsg.Items.Clear();
      this.ErrorMsg.EndUpdate();
    }

    private void deleteFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.DeleteFiles();
    }

    private void editLibrariesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmLibraries(this).ShowDialog(this);
    }

    private void enumerateInfilenameToolStripMenuItem_Click(object sender, EventArgs e)
    {
      enumerateInFilename(sender);
    }

    private void enumerateInFilenameToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      enumerateInFilename(sender);
    }

    private void enumerateInTAGVer1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      enumerateInTAGVer1(sender);
    }

    private void enumerateInTAGVer1ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      enumerateInTAGVer2(sender);
    }

    private void enumerateInTAGVer2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      enumerateInTAGVer2(sender);
    }

    private void enumerateInTAGVer2ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      enumerateInTAGVer2(sender);
    }

    private void filePropertiesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Declarations.SHELLEXECUTEINFO expression = new Declarations.SHELLEXECUTEINFO();
      if (this.MP3View.FocusedItem != null)
      {
        expression.cbSize = Strings.Len(expression);
        expression.fMask = 0x44c;
        expression.hwnd = this.Handle.ToInt32();
        expression.lpVerb = "properties";
        expression.lpFile = StringType.FromObject(
          ObjectType.StrCatObj(
            LateBinding.LateGet(
              LateBinding.LateGet(
                this.MP3View.FocusedItem.Tag, null, "FI", new object[0], null, null),
              null, "Fullname", new object[0], null, null),
            "\0"));
        expression.lpParameters = "\0";
        expression.lpDirectory = "\0";
        expression.nShow = 0;
        expression.hInstApp = 0;
        expression.lpIDList = 0;
        Declarations.ShellExecuteEx(ref expression);
      }
    }

    private void findduplicateFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.MP3View.Items.Count > 2)
        new frmDouble(this).ShowDialog(this);
    }

    private void groupSelectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      int index = 0;
      this.MP3View.ListViewItemSorter = null;
      this.MP3View.BeginUpdate();

      foreach (ListViewItem item9 in this.MP3View.SelectedItems)
      {
        ListViewItem item10 = (ListViewItem)item9.Clone();
        this.MP3View.Items.Insert(index, item10);

        if (index == 0)
        {
          item10.Focused = true;
          item10.EnsureVisible();
        }

        index++;
        item10.Selected = true;
        this.MP3View.Items.Remove(item9);
      }

      this.MP3View.EndUpdate();
    }

    private void helpToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      new Process
      {
        StartInfo =
        {
          FileName = StringType.FromObject(Application.StartupPath.EndsWith(@"\") ? Application.StartupPath + @"Help\index.htm" : Application.StartupPath + @"\Help\index.htm"),
          UseShellExecute = true
        }
      }.Start();
    }

    private void invertSelectionToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.MP3View.BeginUpdate();

      foreach (ListViewItem item8 in this.MP3View.Items)
        item8.Selected ^= true;

      this.MP3View.EndUpdate();

      try
      {
        if (this.MP3View.FocusedItem == null)
          this.MP3View.Items[0].Focused = true;
      }
      catch (Exception exception10)
      {
        ProjectData.SetProjectError(exception10);
        ProjectData.ClearProjectError();
      }

      this.MP3View.Focus();
    }

    private void mnuAddFolder_Click(object sender, EventArgs e)
    {
      string selectedPath = "";
      this.FolderBrowserDialog.Description = StringType.FromObject(Declarations.objResources.ResStrings["FileAddDir"]);
      this.FolderBrowserDialog.SelectedPath = Declarations.objSettings.MoveCopyPath;
      if (this.FolderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
      {
        selectedPath = this.FolderBrowserDialog.SelectedPath;
        if (StringType.StrCmp(selectedPath, Declarations.objSettings.CurrentPath, false) != 0)
        {
          ArrayList alstFolders = new ArrayList { selectedPath };
          this.GetFiles(alstFolders, false, true);
        }
      }
      this.Timer.Start();
    }

    private void mnubCaseConv_Click(object sender, EventArgs e)
    {
      new frmCaseConv(this).ShowDialog(this);
    }

    private void mnubQueryFreeDB_Click(object sender, EventArgs e)
    {
      queryFreeDb();
    }

    private void mnubTransferConvertTags_Click(object sender, EventArgs e)
    {
      new frmTransfer(this).ShowDialog(this);
    }

    private void mnuEditV1_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      var main = this;
      new frmTAG1(ref main).ShowDialog(this);
    }

    private void mnuEditV2_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      var main = this;
      new frmTAG2(ref main).ShowDialog(this);
    }

    private void mnuFileToTagV1_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      var main = this;
      new frmFilenameToTAG1(ref main).ShowDialog(this);
    }

    private void mnuFileToTagV2_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      var main = this;
      new frmFilenameToTAG2(ref main).ShowDialog(this);
    }

    private void mnuMultiEditV1_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      var main = this;
      new frmTAG1Multi(ref main).ShowDialog(this);
    }

    private void mnuMultiEditV2_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      var main = this;
      new frmTAG2Multi(ref main).ShowDialog();
    }

    private void mnuPlay_Click(object sender, EventArgs e)
    {
      string vLeft = "";
      Process process2 = new Process();

      foreach (ListViewItem item3 in this.MP3View.SelectedItems)
        vLeft = StringType.FromObject(ObjectType.StrCatObj(vLeft, ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(item3.Tag, null, "FI", new object[0], null, null), null, "FullName", new object[0], null, null), "\r\n")));

      if (StringType.StrCmp(vLeft, "", false) != 0)
      {
        string str3 = Id3TagIT_Main.CreateTempFile(Encoding.Default.GetBytes(vLeft), "m3u");
        process2.StartInfo.UseShellExecute = true;
        process2.StartInfo.FileName = str3;

        try
        {
          process2.StartInfo.Verb = Declarations.objSettings.Play;
        }
        catch (Exception exception8)
        {
          ProjectData.SetProjectError(exception8);
          process2.StartInfo.Verb = "open";
          ProjectData.ClearProjectError();
        }

        process2.Start();
      }
    }

    private void mnuRedo_Click(object sender, EventArgs e)
    {
      if (Declarations.REDOList.Count > 0)
      {
        ArrayList list4 = (ArrayList)Declarations.REDOList[Declarations.REDOList.Count - 1];
        ArrayList list5 = new ArrayList();
        var form = (Form)this;
        var callback = new frmProgress.Callback(this.ReDoCB);
        frmProgress progress2 = new frmProgress(0, list4.Count, 50, ref form, ref callback);
        progress2.SetStateRedo();
        progress2.List = list4;
        progress2.ListHelp = list5;
        progress2.ShowDialog(this);
        progress2.ProgressBar.Value = progress2.ProgressBar.Maximum;
        Declarations.UNDOList.Add(list5);
        this.UnDoEnable(true, false);
        Declarations.REDOList.RemoveAt(Declarations.REDOList.Count - 1);

        if (Declarations.REDOList.Count == 0)
        {
          this.btnRedo.Enabled = false;
          this.redoToolStripMenuItem.Enabled = false;
        }

        this.MP3View_FillColumns(ref Declarations.MP3s);
        progress2.Close();
      }
    }

    private void mnuRemoveV1_Click(object sender, EventArgs e)
    {
      RemoveV1Tag();
    }

    private void mnuRemoveV2_Click(object sender, EventArgs e)
    {
      RemoveV2Tag();
    }

    private void mnuRefresh_Click(object sender, EventArgs e)
    {
      bool flag = false;

      do
      {
        if (this.CheckAllChanged())
        {
          switch (Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["ChangesNotSaved"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Question | MsgBoxStyle.YesNoCancel, null))
          {
            case MsgBoxResult.Cancel:
              return;

            case MsgBoxResult.Yes:
              this.SaveChanges();

              if (!this.CheckAllChanged())
                flag = true;

              break;

            case MsgBoxResult.No:
              flag = true;
              break;
          }
        }
        else
          flag = true;
      }
      while (!flag);

      try
      {
        this.CalcAudioCheckSumThread.Abort();
        this.CalcAudioCheckSumThread.Join();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }

      this.vbooRefreshFlag = true;
      this.FolderTree.RefreshView();
      this.vbooRefreshFlag = false;
      Declarations.UNDOList.Clear();
      Declarations.REDOList.Clear();
      this.btnUndo.Enabled = false;
      this.btnRedo.Enabled = false;
      this.undoToolStripMenuItem.Enabled = false;
      this.redoToolStripMenuItem.Enabled = false;
    }

    private void mnuSave_Click(object sender, EventArgs e)
    {
      this.SaveChanges();
    }

    private void mnuTagToFileV1_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      var main = this;
      new frmTAG1ToFilename(ref main).ShowDialog(this);
    }

    private void mnuTagToFileV2_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count == 0)
      {
        Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
        return;
      }

      var main = this;
      new frmTAG2ToFilename(ref main).ShowDialog(this);
    }

    private void mnuUndo_Click(object sender, EventArgs e)
    {
      if (Declarations.UNDOList.Count > 0)
      {
        ArrayList list2 = (ArrayList)Declarations.UNDOList[Declarations.UNDOList.Count - 1];
        ArrayList list3 = new ArrayList();
        var form = (Form)this;
        var callback = new frmProgress.Callback(this.UnDoCB);
        frmProgress progress = new frmProgress(0, list2.Count, 50, ref form, ref callback);
        progress.SetStateUndo();
        progress.List = list2;
        progress.ListHelp = list3;
        progress.ShowDialog(this);
        progress.ProgressBar.Value = progress.ProgressBar.Maximum;
        Declarations.REDOList.Add(list3);
        this.btnRedo.Enabled = true;
        this.redoToolStripMenuItem.Enabled = true;
        Declarations.UNDOList.RemoveAt(Declarations.UNDOList.Count - 1);

        if (Declarations.UNDOList.Count == 0)
          this.UnDoEnable(false, false);

        this.MP3View_FillColumns(ref Declarations.MP3s);
      }
    }

    private void moveFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.MoveFiles();
    }

    private void openFileLocationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count > 0)
      {
        Process process = new Process();
        MP3 tag = (MP3)this.MP3View.FocusedItem.Tag;
        process.StartInfo.UseShellExecute = true;
        process.StartInfo.FileName = Path.GetDirectoryName(tag.FI.FullName);
        process.StartInfo.Verb = "open";
        process.Start();
      }
    }

    private void organizeFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      var organize = new frmOrganize(this);

      if (organize.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
      {
        this.vbooRefreshFlag = true;
        this.FolderTree.RefreshView();
        this.vbooRefreshFlag = false;
      }

      this.AudioCheckSumCalculation();
    }

    private void pasteTAGInformationToolStripMenuItem_Click(object sender, EventArgs e)
    {
      ArrayList list6 = new ArrayList();

      if (!((this.MP3View.SelectedItems.Count == 0) | (this.alstCopyPaste.Count == 0)))
      {
        Form form;
        frmProgress.Callback callback;
        this.MP3View.BeginUpdate();

        if (this.alstCopyPaste.Count == 1)
        {
          form = this;
          callback = new frmProgress.Callback(this.Paste1CB);
          frmProgress progress3 = new frmProgress(0, IntegerType.FromObject(this.MP3View.SelectedItems.Count <= this.alstCopyPaste.Count ? this.MP3View.SelectedItems.Count : this.alstCopyPaste.Count), 1, ref form, ref callback);
          progress3.SetStatePaste();
          progress3.List = list6;
          progress3.ShowDialog(this);
        }
        else if (this.MP3View.SelectedItems.Count <= this.alstCopyPaste.Count)
        {
          form = this;
          callback = new frmProgress.Callback(this.Paste2CB);
          frmProgress progress4 = new frmProgress(0, IntegerType.FromObject(this.MP3View.SelectedItems.Count <= this.alstCopyPaste.Count ? this.MP3View.SelectedItems.Count : this.alstCopyPaste.Count), 1, ref form, ref callback);
          progress4.SetStatePaste();
          progress4.List = list6;
          progress4.ShowDialog(this);
        }
        else
        {
          form = this;
          callback = new frmProgress.Callback(this.Paste3CB);
          frmProgress progress5 = new frmProgress(0, IntegerType.FromObject(this.MP3View.SelectedItems.Count <= this.alstCopyPaste.Count ? this.MP3View.SelectedItems.Count : this.alstCopyPaste.Count), 1, ref form, ref callback);
          progress5.SetStatePaste();
          progress5.List = list6;
          progress5.ShowDialog(this);
        }

        this.MP3View.EndUpdate();

        if (list6.Count > 0)
        {
          Declarations.UNDOList.Add(list6);
          this.UnDoEnable(true, true);
        }
      }
    }

    private void preferencesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmPreferences(this).ShowDialog();

      if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
      {
        this.vintEnumCount = Declarations.objSettings.FilenumberStart;
        this.mnutEnumerateCounter.Text = StringType.FromInteger(this.vintEnumCount);
      }

      string str9 = "";
      RegistryKey key = Registry.ClassesRoot.OpenSubKey(".mp3", false);
      Application.DoEvents();

      if (key != null)
      {
        str9 = StringType.FromObject(key.GetValue(""));
        string str8 = str9 + @"\DefaultIcon\";
        RegistryKey key2 = Registry.ClassesRoot.OpenSubKey(str8, false);
        Application.DoEvents();

        if (key2 != null)
        {
          str9 = StringType.FromObject(key2.GetValue(""));

          try
          {
            str9 = str9.Substring(0, str9.LastIndexOf(","));
          }
          catch (Exception exception15)
          {
            ProjectData.SetProjectError(exception15);
            ProjectData.ClearProjectError();
          }
        }
      }

      // FIXME this.BarGroupTools.SubItems.Clear();
      this.ToolsIcons.Images.Clear();

      int num4 = -1;

      foreach (DataRow row in Declarations.objSettings.Tools.Rows)
      {
        num4++;

        // FIXME - External tools
        //try
        //{
        //  if (BooleanType.FromObject(row["DefaultPlayer"]))
        //  {
        //    if (StringType.StrCmp(str9, "", false) != 0)
        //      this.ToolsIcons.Images.Add(Id3TagIT_Main.GetAppIcon(str9, true));
        //
        //    ButtonItem item20 = new ButtonItem("ToolItem" + num4.ToString(), row["ToolDescription"].ToString())
        //    {
        //      ImageIndex = num4,
        //      Tag = num4,
        //      ButtonStyle = eButtonStyle.ImageAndText
        //    };
        //
        //    // FIXME this.BarGroupTools.SubItems.Add(item20);
        //  }
        //  else
        //  {
        //    this.ToolsIcons.Images.Add(Id3TagIT_Main.GetAppIcon(StringType.FromObject(row["ToolPath"]), true));
        //    ButtonItem item21 = new ButtonItem("ToolItem" + num4.ToString(), row["ToolDescription"].ToString())
        //    {
        //      ImageIndex = num4,
        //      Tag = num4,
        //      ButtonStyle = eButtonStyle.ImageAndText
        //    };
        //    // FIXME this.BarGroupTools.SubItems.Add(item21);
        //  }
        //}
        //catch (Exception exception16)
        //{
        //  ProjectData.SetProjectError(exception16);
        //  ButtonItem item22 = new ButtonItem("ToolItem" + num4.ToString(), row["ToolDescription"].ToString())
        //  {
        //    Tag = num4,
        //    ButtonStyle = eButtonStyle.TextOnlyAlways
        //  };
        //  // FIXME this.BarGroupTools.SubItems.Add(item22);
        //  ProjectData.ClearProjectError();
        //}
      }

      // FIXME
      // this.BarGroupTools.RecalcSize();
      // this.BarGroupTools.Expanded = false;
      // this.BarGroupTools.Expanded = true;
    }

    private void queryFreeDBToolStripMenuItem_Click(object sender, EventArgs e)
    {
      queryFreeDb();
    }

    private void quickFilenameEditingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Declarations.objSettings.QuickFilenameEditing ^= true;
      LateBinding.LateSet(sender, null, "Checked", new object[] { ObjectType.BitXorObj(LateBinding.LateGet(sender, null, "Checked", new object[0], null, null), true) }, null);
    }

    private void quitToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Declarations.MP3s = null;
      this.Close();
    }

    private void removeEmptyFoldersToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmRemoveFolders(this).ShowDialog(this);
    }

    private void renameFilefolderToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.ActiveControl == this.FolderTree | this.ActiveControl == this.tabControl1 |
          this.ActiveControl == this.tabFolders | this.ActiveControl == this.tabFavorites)
      // FIXME - Do rename...
      { } // this.FolderTree.SelectedNode.ExecuteShellCommand(ShellCommands.Rename);
      else if (this.MP3View.FocusedItem != null)
      {
        this.MP3View.LabelEdit = true;
        this.MP3View.FocusedItem.BeginEdit();
      }
    }

    private void removeSelectedFilesFromListToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.MP3View.ListViewItemSorter = null;
      this.MP3View.BeginUpdate();

      foreach (ListViewItem item18 in this.MP3View.SelectedItems)
      {
        Declarations.MP3s.Remove(RuntimeHelpers.GetObjectValue(item18.Tag));
        this.MP3View.Items.Remove(item18);
      }

      this.MP3View.EndUpdate();
    }

    private void removeTAGVer1ToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      RemoveV1Tag();
    }

    private void removeTAGVer2ToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      RemoveV2Tag();
    }

    private void scanSubdirectoriesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Declarations.objSettings.ScanSubDirs ^= true;
      LateBinding.LateSet(sender, null, "Checked", new object[] { ObjectType.BitXorObj(LateBinding.LateGet(sender, null, "Checked", new object[0], null, null), true) }, null);
      if (Declarations.objSettings.ScanSubDirs)
        lblSubDirs.Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsYes"]);
      else
        lblSubDirs.Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsNo"]);
    }

    private void searchandReplaceToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmSearch { MainForm = this }.Show();
    }

    private void selectallToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.MP3View.BeginUpdate();

      foreach (ListViewItem item7 in this.MP3View.Items)
        item7.Selected = true;

      this.MP3View.EndUpdate();

      try
      {
        if (this.MP3View.FocusedItem == null)
          this.MP3View.Items[0].Focused = true;
      }
      catch (Exception exception9)
      {
        ProjectData.SetProjectError(exception9);
        ProjectData.ClearProjectError();
      }

      this.MP3View.Focus();
    }

    private void selectChangedFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.MP3View.ListViewItemSorter = null;

      foreach (ListViewItem item11 in this.MP3View.Items)
      {
        if (BooleanType.FromObject(LateBinding.LateGet(item11.Tag, null, "Changed", new object[0], null, null)))
          item11.Selected = true;
        else if (Declarations.objSettings.SelectionMode == 1)
          item11.Selected = false;
      }
    }

    private void selectDuplicateFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.MP3View.ListViewItemSorter = null;

      foreach (ListViewItem item12 in this.MP3View.Items)
      {
        if (BooleanType.FromObject(LateBinding.LateGet(item12.Tag, null, "Doubled", new object[0], null, null)))
          item12.Selected = true;
        else if (Declarations.objSettings.SelectionMode == 1)
          item12.Selected = false;
      }
    }

    private void selectFilesByformatToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmSelectFormat(this).ShowDialog(this);
    }

    private void selectmismatchingFilenameTAGFilesToolStripMenuItem_Click(object sender, EventArgs e)
    {
      this.MP3View.ListViewItemSorter = null;

      foreach (ListViewItem item13 in this.MP3View.Items)
      {
        if (BooleanType.FromObject(LateBinding.LateGet(item13.Tag, null, "FileTAGCompare", new object[0], null, null)))
          item13.Selected = true;
        else if (Declarations.objSettings.SelectionMode == 1)
          item13.Selected = false;
      }
    }

    private void shortcutsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new Process
      {
        StartInfo =
        {
          FileName = StringType.FromObject(Application.StartupPath.EndsWith(@"\") ? Application.StartupPath + @"Help\shortcuts.htm" : Application.StartupPath + @"\Help\shortcuts.htm"),
          UseShellExecute = true
        }
      }.Start();
    }

    private void splitTAGVer1ArtistIntoArtistAndTitleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count > 0)
      {
        ArrayList list15 = new ArrayList();
        string str5 = Interaction.InputBox(StringType.FromObject(Declarations.objResources.ResStrings["SplitATText"]), StringType.FromObject(Declarations.objResources.ResStrings["SplitAT1"]), Declarations.objSettings.SplitSeparator, -1, -1);

        if (StringType.StrCmp(str5, "", false) == 0)
          return;

        Form form;
        frmProgress.Callback callback;
        Declarations.objSettings.SplitSeparator = str5;
        this.MP3View.BeginUpdate();
        form = this;
        callback = new frmProgress.Callback(this.SplitArtist1CB);
        frmProgress progress14 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback) { List = list15, String01 = str5 };
        progress14.SetStateSplit();
        progress14.ShowDialog(this);
        this.MP3View.EndUpdate();

        if (list15.Count > 0)
        {
          Declarations.UNDOList.Add(list15);
          this.UnDoEnable(true, true);
        }
      }
    }

    private void splitTAGVer2ArtistIntoArtistAndTitleToolStripMenuItem_Click(object sender, EventArgs e)
    {
      if (this.MP3View.SelectedItems.Count > 0)
      {
        ArrayList list16 = new ArrayList();
        string str6 = Interaction.InputBox(StringType.FromObject(Declarations.objResources.ResStrings["SplitATText"]), StringType.FromObject(Declarations.objResources.ResStrings["SplitAT2"]), Declarations.objSettings.SplitSeparator, -1, -1);

        if (StringType.StrCmp(str6, "", false) == 0)
          return;

        Form form;
        frmProgress.Callback callback;
        Declarations.objSettings.SplitSeparator = str6;
        this.MP3View.BeginUpdate();
        form = this;
        callback = new frmProgress.Callback(this.SplitArtist2CB);
        frmProgress progress15 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback) { List = list16, String01 = str6 };
        progress15.SetStateSplit();
        progress15.ShowDialog(this);
        this.MP3View.EndUpdate();

        if (list16.Count > 0)
        {
          Declarations.UNDOList.Add(list16);
          this.UnDoEnable(true, true);
        }
      }
    }

    private void synchronizeVer1AndVer2EditingToolStripMenuItem_Click(object sender, EventArgs e)
    {
      Declarations.objSettings.SynchronizeTAGs ^= true;
      LateBinding.LateSet(sender, null, "Checked", new object[] { ObjectType.BitXorObj(LateBinding.LateGet(sender, null, "Checked", new object[0], null, null), true) }, null);
    }

    private void titleAlbumToolStripMenuItem_Click(object sender, EventArgs e)
    {
      swapTitleAlbumV1();
    }

    private void titleAlbumToolStripMenuItem1_Click(object sender, EventArgs e)
    {
      swapTitleAlbumV2();
    }

    private void titleAlbumToolStripMenuItem2_Click(object sender, EventArgs e)
    {
      swapTitleAlbumV1();
    }

    private void titleAlbumToolStripMenuItem3_Click(object sender, EventArgs e)
    {
      swapTitleAlbumV2();
    }

    private void transferConvertTAGsToolStripMenuItem_Click(object sender, EventArgs e)
    {
      new frmTransfer(this).ShowDialog(this);
    }

    private void viewTAGVer1ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SwitchToV1();
    }

    private void viewTAGVer2ToolStripMenuItem_Click(object sender, EventArgs e)
    {
      SwitchToV2();
    }

    #endregion

    private void lnkQuickEditExpCol_Click(object sender, EventArgs e)
    {
      if (pnlQuickEdit.Tag.ToString() == "Expanded")
      {
        lnkQuickEditExpCol.Image = global::Properties.Resources.Expand;
        pnlQuickEdit.Height = 21;
        pnlQuickEdit.Tag = "Collapsed";
      }
      else
      {
        lnkQuickEditExpCol.Image = global::Properties.Resources.Collapse;
        pnlQuickEdit.Height = 208;
        pnlQuickEdit.Tag = "Expanded";
      }

      pnlPicture.Top = pnlQuickEdit.Top + pnlQuickEdit.Height + 6;
      pnlInformation.Top = pnlPicture.Top + pnlPicture.Height + 6;
      pnlTools.Top = pnlInformation.Top + pnlInformation.Height + 6;
    }

    private void lnkPictureExpCol_Click(object sender, EventArgs e)
    {
      if (pnlPicture.Tag.ToString() == "Expanded")
      {
        lnkPictureExpCol.Image = global::Properties.Resources.Expand;
        pnlPicture.Height = 21;
        pnlPicture.Tag = "Collapsed";
      }
      else
      {
        lnkPictureExpCol.Image = global::Properties.Resources.Collapse;
        pnlPicture.Height = 196;
        pnlPicture.Tag = "Expanded";
      }

      pnlInformation.Top = pnlPicture.Top + pnlPicture.Height + 6;
      pnlTools.Top = pnlInformation.Top + pnlInformation.Height + 6;
    }

    private void lnkInfoExpCol_Click(object sender, EventArgs e)
    {
      if (pnlInformation.Tag.ToString() == "Expanded")
      {
        lnkInfoExpCol.Image = global::Properties.Resources.Expand;
        pnlInformation.Height = 21;
        pnlInformation.Tag = "Collapsed";
      }
      else
      {
        lnkInfoExpCol.Image = global::Properties.Resources.Collapse;
        pnlInformation.Height = 164;
        pnlInformation.Tag = "Expanded";
      }

      pnlTools.Top = pnlInformation.Top + pnlInformation.Height + 6;
    }

    private void lnkToolsExpCol_Click(object sender, EventArgs e)
    {
      if (pnlTools.Tag.ToString() == "Expanded")
      {
        lnkToolsExpCol.Image = global::Properties.Resources.Expand;
        pnlTools.Height = 21;
        pnlTools.Tag = "Collapsed";
      }
      else
      {
        lnkToolsExpCol.Image = global::Properties.Resources.Collapse;
        pnlTools.Height = 137;
        pnlTools.Tag = "Expanded";
      }
    }

    private void tsmiDecrease_Click(object sender, EventArgs e)
    {
      this.vintEnumCount--;

      if (this.vintEnumCount < 1)
        this.vintEnumCount = 1;

      this.mnutEnumerateCounter.Text = StringType.FromInteger(this.vintEnumCount);
    }

    private void tsmiIncrease_Click(object sender, EventArgs e)
    {
      this.vintEnumCount++;
      this.mnutEnumerateCounter.Text = StringType.FromInteger(this.vintEnumCount);
    }

    private void tsmiClearFilter_Click(object sender, EventArgs e)
    {
    }

    private void mnubArtistFilter_Click(object sender, EventArgs e)
    {

    }

    private void mnubTitleFilter_Click(object sender, EventArgs e)
    {

    }

    private void mnubAlbumFilter_Click(object sender, EventArgs e)
    {

    }

    private void FolderTree_BeforeSelect(object sender, TreeViewCancelEventArgs e)
    {

    }

    private void spltQuickInfo_Click(object sender, EventArgs e)
    {
      // FIXME - Nope,  this hides the splitter control  :/
      // spltQuickInfo.Panel2Collapsed = !spltQuickInfo.Panel2Collapsed;
    }
  }
}