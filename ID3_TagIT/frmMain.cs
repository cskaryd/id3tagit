using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.Win32;
using SkySoftware.FolderViewControl;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmMain : Form
  {
    private PictureBox APICView;
    private DockSite barBottomDockSite;
    private ExplorerBarGroupItem BarGroupEdit;
    private ExplorerBarGroupItem BarGroupInfo;
    private ExplorerBarGroupItem BarGroupPicture;
    private ExplorerBarGroupItem BarGroupTools;
    private DockSite barLeftDockSite;
    private DockSite barRightDockSite;
    private DockSite barTopDockSite;
    private Button btnQuickEdit;
    private Button btnQuickEditMore;
    private ControlContainerItem CContainerAlbum;
    private ControlContainerItem CContainerAPICView;
    private ControlContainerItem CContainerArtist;
    private ControlContainerItem CContainerbtnQuickEditMore;
    private ControlContainerItem CContainerbtnQuickEditOK;
    private ControlContainerItem CContainerTitle;
    private ControlContainerItem CContainertxtInfo;
    public ComboBoxAutoComplete cmbArtist;
    private ImageList ColumnHeaderIcons;
    public DevComponents.DotNetBar.DotNetBarManager DotNetBarManager;
    private Label EnumInfo;
    public ListView ErrorMsg;
    private ButtonItem FavouritesPan;
    private NavigationPanePanel FavouritesPanel;
    public TreeView FavTree;
    private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    private System.Windows.Forms.Timer FolderRenameTimer;
    private ButtonItem FoldersPan;
    private NavigationPanePanel FoldersPanel;
    private FolderView FolderTree;
    private ImageList GroupIcons;
    private LabelItem lblAlbum;
    private LabelItem lblArtist;
    private LabelItem lblQuickSpacer1;
    private LabelItem lblTitle;
    public ListView MP3View;
    private NavigationPane NavigationPan;
    private ExplorerBar SideBar;
    public ExpandableSplitter SplitterBottom;
    private ExpandableSplitter SplitterLeft;
    private ExpandableSplitter SplitterRight;
    private System.Windows.Forms.Timer Timer;
    private ImageList ToolsIcons;
    private TextBox txtAlbum;
    private RichTextBox txtInfo;
    private TextBox txtTitle;
    private int[] aintLastSelected;
    private ArrayList alstCopyPaste;
    private ButtonItem btnV1V2View;
    private Thread CalcAudioCheckSumThread;
    public ColumnHeader colHAlbum;
    public ColumnHeader colHArtist;
    public ColumnHeader colHAudioCheckSum;
    public ColumnHeader colHBitrate;
    public ColumnHeader colHBPM;
    public ColumnHeader colHChannel;
    public ColumnHeader colHComment;
    public ColumnHeader colHComposer;
    public ColumnHeader colHCreateDate;
    public ColumnHeader colHDate;
    public ColumnHeader colHDuration;
    public ColumnHeader colHErrFile;
    public ColumnHeader colHErrMsg;
    public ColumnHeader colHFilename;
    public ColumnHeader colHFileSize;
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
    private IContainer components;
    private Thread GetFilesTimeThread;
    public int LastSortedColumn;
    private ButtonItem mnubtnEnumCounter;
    private ButtonItem mnubtnEnumMinus;
    private ButtonItem mnubtnEnumPlus;
    private ButtonItem mnubtnRedo;
    private ButtonItem mnubtnUndo;
    private ButtonItem mnubtnViewVer1;
    private ButtonItem mnubtnViewVer2;
    private MemoryStream PicMStream;
    public int SortedColumn;
    private bool vbooClosing;
    private bool vbooFolderRename;
    private bool vbooRefreshFlag;
    private bool vbooStartUp;
    private byte vbytFilterIndex;
    private byte vbytFolderRenameCount;
    private byte vbytSelTimerCount;
    private byte vbytToolBarTAGVersion;
    public byte vbytVersionToShow;
    private int vintEnumCount;
    private int vintHelpCount;
    private int vintSelTimerCount;
    private string vstrFilter;
    private string vstrFolderRenameNewPath;
    private string vstrFolderRenameOldPath;

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      this.ColumnHeaderIcons = new ImageList(this.components);
      this.ToolsIcons = new ImageList(this.components);
      this.GroupIcons = new ImageList(this.components);
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.Timer = new System.Windows.Forms.Timer(this.components);
      this.FolderRenameTimer = new System.Windows.Forms.Timer(this.components);
      this.DotNetBarManager = new DevComponents.DotNetBar.DotNetBarManager(this.components);
      this.barBottomDockSite = new DockSite();
      this.barLeftDockSite = new DockSite();
      this.barRightDockSite = new DockSite();
      this.barTopDockSite = new DockSite();
      this.SplitterLeft = new ExpandableSplitter();
      this.NavigationPan = new NavigationPane();
      this.FoldersPanel = new NavigationPanePanel();
      this.FolderTree = new FolderView();
      this.FoldersPan = new ButtonItem();
      this.FavouritesPanel = new NavigationPanePanel();
      this.FavTree = new TreeView();
      this.FavouritesPan = new ButtonItem();
      this.SplitterBottom = new ExpandableSplitter();
      this.ErrorMsg = new ListView();
      this.SplitterRight = new ExpandableSplitter();
      this.SideBar = new ExplorerBar();
      this.cmbArtist = new ComboBoxAutoComplete();
      this.txtTitle = new TextBox();
      this.txtAlbum = new TextBox();
      this.btnQuickEdit = new Button();
      this.btnQuickEditMore = new Button();
      this.APICView = new PictureBox();
      this.txtInfo = new RichTextBox();
      this.BarGroupEdit = new ExplorerBarGroupItem();
      this.lblArtist = new LabelItem();
      this.CContainerArtist = new ControlContainerItem();
      this.lblTitle = new LabelItem();
      this.CContainerTitle = new ControlContainerItem();
      this.lblAlbum = new LabelItem();
      this.CContainerAlbum = new ControlContainerItem();
      this.lblQuickSpacer1 = new LabelItem();
      this.CContainerbtnQuickEditOK = new ControlContainerItem();
      this.CContainerbtnQuickEditMore = new ControlContainerItem();
      this.BarGroupPicture = new ExplorerBarGroupItem();
      this.CContainerAPICView = new ControlContainerItem();
      this.BarGroupInfo = new ExplorerBarGroupItem();
      this.CContainertxtInfo = new ControlContainerItem();
      this.BarGroupTools = new ExplorerBarGroupItem();
      this.MP3View = new ListView();
      this.EnumInfo = new Label();
      this.NavigationPan.SuspendLayout();
      this.FoldersPanel.SuspendLayout();
      this.FavouritesPanel.SuspendLayout();
      ((ISupportInitialize)this.SideBar).BeginInit();
      this.SideBar.SuspendLayout();
      this.SuspendLayout();
      this.ColumnHeaderIcons.ImageSize = new Size(0x10, 0x10);
      this.ColumnHeaderIcons.ImageStream = (ImageListStreamer)(new ResourceManager(typeof(frmMain))).GetObject("ColumnHeaderIcons.ImageStream");
      this.ColumnHeaderIcons.TransparentColor = System.Drawing.Color.Transparent;
      this.ToolsIcons.ColorDepth = ColorDepth.Depth32Bit;
      this.ToolsIcons.ImageSize = new Size(0x10, 0x10);
      this.ToolsIcons.TransparentColor = System.Drawing.Color.Transparent;
      this.GroupIcons.ColorDepth = ColorDepth.Depth32Bit;
      this.GroupIcons.ImageSize = new Size(0x10, 0x10);
      this.GroupIcons.ImageStream = (ImageListStreamer)(new ResourceManager(typeof(frmMain))).GetObject("GroupIcons.ImageStream");
      this.GroupIcons.TransparentColor = System.Drawing.Color.Transparent;
      this.Timer.Enabled = true;
      this.Timer.Interval = 200;
      this.DotNetBarManager.AllowUserBarCustomize = false;
      this.DotNetBarManager.BottomDockSite = this.barBottomDockSite;
      this.DotNetBarManager.DefinitionName = "ID3-TagIT.MenuBars.xml";
      this.DotNetBarManager.LeftDockSite = this.barLeftDockSite;
      this.DotNetBarManager.ParentForm = this;
      this.DotNetBarManager.RightDockSite = this.barRightDockSite;
      this.DotNetBarManager.ShowShortcutKeysInToolTips = true;
      this.DotNetBarManager.Style = eDotNetBarStyle.Office2003;
      this.DotNetBarManager.TopDockSite = this.barTopDockSite;
      this.barBottomDockSite.AccessibleRole = AccessibleRole.Window;
      this.barBottomDockSite.BackgroundImageAlpha = 0xff;
      this.barBottomDockSite.Dock = DockStyle.Bottom;
      this.barBottomDockSite.Location = new Point(0, 0x22e);
      this.barBottomDockSite.Name = "barBottomDockSite";
      this.barBottomDockSite.Size = new Size(960, 0x18);
      this.barBottomDockSite.TabIndex = 20;
      this.barBottomDockSite.TabStop = false;
      this.barLeftDockSite.AccessibleRole = AccessibleRole.Window;
      this.barLeftDockSite.BackgroundImageAlpha = 0xff;
      this.barLeftDockSite.Dock = DockStyle.Left;
      this.barLeftDockSite.Location = new Point(0, 0x4a);
      this.barLeftDockSite.Name = "barLeftDockSite";
      this.barLeftDockSite.Size = new Size(0, 0x1e4);
      this.barLeftDockSite.TabIndex = 0x11;
      this.barLeftDockSite.TabStop = false;
      this.barRightDockSite.AccessibleRole = AccessibleRole.Window;
      this.barRightDockSite.BackgroundImageAlpha = 0xff;
      this.barRightDockSite.Dock = DockStyle.Right;
      this.barRightDockSite.Location = new Point(960, 0x4a);
      this.barRightDockSite.Name = "barRightDockSite";
      this.barRightDockSite.Size = new Size(0, 0x1e4);
      this.barRightDockSite.TabIndex = 0x12;
      this.barRightDockSite.TabStop = false;
      this.barTopDockSite.AccessibleRole = AccessibleRole.Window;
      this.barTopDockSite.BackgroundImageAlpha = 0xff;
      this.barTopDockSite.Dock = DockStyle.Top;
      this.barTopDockSite.Location = new Point(0, 0);
      this.barTopDockSite.Name = "barTopDockSite";
      this.barTopDockSite.Size = new Size(960, 0x4a);
      this.barTopDockSite.TabIndex = 0x13;
      this.barTopDockSite.TabStop = false;
      this.SplitterLeft.BackColor2 = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterLeft.BackColor2SchemePart = eColorSchemePart.PanelBorder;
      this.SplitterLeft.BackColorSchemePart = eColorSchemePart.PanelBackground;
      this.SplitterLeft.ExpandableControl = this.NavigationPan;
      this.SplitterLeft.ExpandFillColor = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterLeft.ExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
      this.SplitterLeft.ExpandLineColor = SystemColors.ControlText;
      this.SplitterLeft.ExpandLineColorSchemePart = eColorSchemePart.ItemText;
      this.SplitterLeft.GripDarkColor = SystemColors.ControlText;
      this.SplitterLeft.GripDarkColorSchemePart = eColorSchemePart.ItemText;
      this.SplitterLeft.GripLightColor = System.Drawing.Color.FromArgb(0xdf, 0xed, 0xfe);
      this.SplitterLeft.GripLightColorSchemePart = eColorSchemePart.BarBackground;
      this.SplitterLeft.HotBackColor = System.Drawing.Color.FromArgb(0xfe, 0x8e, 0x4b);
      this.SplitterLeft.HotBackColor2 = System.Drawing.Color.FromArgb(0xff, 0xcf, 0x8b);
      this.SplitterLeft.HotBackColor2SchemePart = eColorSchemePart.ItemPressedBackground2;
      this.SplitterLeft.HotBackColorSchemePart = eColorSchemePart.ItemPressedBackground;
      this.SplitterLeft.HotExpandFillColor = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterLeft.HotExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
      this.SplitterLeft.HotExpandLineColor = SystemColors.ControlText;
      this.SplitterLeft.HotExpandLineColorSchemePart = eColorSchemePart.ItemText;
      this.SplitterLeft.HotGripDarkColor = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterLeft.HotGripDarkColorSchemePart = eColorSchemePart.PanelBorder;
      this.SplitterLeft.HotGripLightColor = System.Drawing.Color.FromArgb(0xdf, 0xed, 0xfe);
      this.SplitterLeft.HotGripLightColorSchemePart = eColorSchemePart.BarBackground;
      this.SplitterLeft.Location = new Point(0xd8, 0x4a);
      this.SplitterLeft.MinExtra = 5;
      this.SplitterLeft.MinSize = 5;
      this.SplitterLeft.Name = "SplitterLeft";
      this.SplitterLeft.Size = new Size(8, 0x1e4);
      this.SplitterLeft.TabIndex = 0x18;
      this.SplitterLeft.TabStop = false;
      this.NavigationPan.ConfigureAddRemoveVisible = false;
      this.NavigationPan.Controls.Add(this.FoldersPanel);
      this.NavigationPan.Controls.Add(this.FavouritesPanel);
      this.NavigationPan.Controls.Add(this.NavigationPan.TitlePanel);
      this.NavigationPan.Dock = DockStyle.Left;
      this.NavigationPan.ItemPaddingBottom = 2;
      this.NavigationPan.ItemPaddingTop = 2;
      this.NavigationPan.Items.AddRange(new BaseItem[] { this.FoldersPan, this.FavouritesPan });
      this.NavigationPan.Location = new Point(0, 0x4a);
      this.NavigationPan.Name = "NavigationPan";
      this.NavigationPan.NavigationBarHeight = 0x58;
      this.NavigationPan.Size = new Size(0xd8, 0x1e4);
      this.NavigationPan.TabIndex = 0x17;
      this.NavigationPan.TitlePanel.AntiAlias = true;
      this.NavigationPan.TitlePanel.Dock = DockStyle.Top;
      this.NavigationPan.TitlePanel.Font = new Font("Tahoma", 12f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this.NavigationPan.TitlePanel.Location = new Point(0, 0);
      this.NavigationPan.TitlePanel.Name = "panelEx1";
      this.NavigationPan.TitlePanel.Size = new Size(0xd8, 0x18);
      this.NavigationPan.TitlePanel.Style.BackColor1.ColorSchemePart = eColorSchemePart.PanelBackground;
      this.NavigationPan.TitlePanel.Style.BackColor2.ColorSchemePart = eColorSchemePart.PanelBackground2;
      this.NavigationPan.TitlePanel.Style.Border = eBorderType.SingleLine;
      this.NavigationPan.TitlePanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
      this.NavigationPan.TitlePanel.Style.ForeColor.ColorSchemePart = eColorSchemePart.PanelText;
      this.NavigationPan.TitlePanel.Style.GradientAngle = 90;
      this.NavigationPan.TitlePanel.Style.MarginLeft = 4;
      this.NavigationPan.TitlePanel.TabIndex = 0;
      this.NavigationPan.TitlePanel.Text = "Folders";
      this.FoldersPanel.AntiAlias = true;
      this.FoldersPanel.Controls.Add(this.FolderTree);
      this.FoldersPanel.Dock = DockStyle.Fill;
      this.FoldersPanel.DockPadding.Left = 1;
      this.FoldersPanel.DockPadding.Right = 1;
      this.FoldersPanel.DockPadding.Top = 1;
      this.FoldersPanel.Location = new Point(0, 0x18);
      this.FoldersPanel.Name = "FoldersPanel";
      this.FoldersPanel.ParentItem = this.FoldersPan;
      this.FoldersPanel.Size = new Size(0xd8, 0x174);
      this.FoldersPanel.Style.Alignment = StringAlignment.Center;
      this.FoldersPanel.Style.BackColor1.ColorSchemePart = eColorSchemePart.BarBackground;
      this.FoldersPanel.Style.BackColor2.ColorSchemePart = eColorSchemePart.BarBackground2;
      this.FoldersPanel.Style.BackgroundImagePosition = eBackgroundImagePosition.Tile;
      this.FoldersPanel.Style.Border = eBorderType.SingleLine;
      this.FoldersPanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
      this.FoldersPanel.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
      this.FoldersPanel.Style.GradientAngle = 90;
      this.FoldersPanel.StyleMouseDown.Alignment = StringAlignment.Center;
      this.FoldersPanel.StyleMouseOver.Alignment = StringAlignment.Center;
      this.FoldersPanel.TabIndex = 2;
      this.FolderTree.AllowDragDrop = false;
      this.FolderTree.BorderStyle = BorderStyles.None;
      this.FolderTree.Dock = DockStyle.Fill;
      this.FolderTree.HasLines = false;
      this.FolderTree.Location = new Point(1, 1);
      this.FolderTree.Name = "FolderTree";
      this.FolderTree.ShowContextMenus = false;
      this.FolderTree.ShowHiddenObjects = false;
      this.FolderTree.ShowSpecialFolders = false;
      this.FolderTree.Size = new Size(0xd6, 0x173);
      this.FolderTree.TabIndex = 1;
      this.FolderTree.Text = "FolderTree";
      this.FoldersPan.ButtonStyle = eButtonStyle.ImageAndText;
      this.FoldersPan.Checked = true;
      this.FoldersPan.Icon = (Icon)(new ResourceManager(typeof(frmMain))).GetObject("FoldersPan.Icon");
      this.FoldersPan.ImageIndex = 0;
      this.FoldersPan.Name = "FoldersPan";
      this.FoldersPan.OptionGroup = "navBar";
      this.FoldersPan.Style = eDotNetBarStyle.Office2003;
      this.FoldersPan.Text = "Folders";
      this.FavouritesPanel.AntiAlias = true;
      this.FavouritesPanel.Controls.Add(this.FavTree);
      this.FavouritesPanel.Dock = DockStyle.Fill;
      this.FavouritesPanel.DockPadding.Left = 1;
      this.FavouritesPanel.DockPadding.Right = 1;
      this.FavouritesPanel.DockPadding.Top = 1;
      this.FavouritesPanel.Location = new Point(0, 0x18);
      this.FavouritesPanel.Name = "FavouritesPanel";
      this.FavouritesPanel.ParentItem = this.FavouritesPan;
      this.FavouritesPanel.Size = new Size(0xd8, 0x174);
      this.FavouritesPanel.Style.Alignment = StringAlignment.Center;
      this.FavouritesPanel.Style.BackColor1.ColorSchemePart = eColorSchemePart.BarBackground;
      this.FavouritesPanel.Style.BackColor2.ColorSchemePart = eColorSchemePart.BarBackground2;
      this.FavouritesPanel.Style.BackgroundImagePosition = eBackgroundImagePosition.Tile;
      this.FavouritesPanel.Style.Border = eBorderType.SingleLine;
      this.FavouritesPanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
      this.FavouritesPanel.Style.ForeColor.ColorSchemePart = eColorSchemePart.ItemText;
      this.FavouritesPanel.Style.GradientAngle = 90;
      this.FavouritesPanel.StyleMouseDown.Alignment = StringAlignment.Center;
      this.FavouritesPanel.StyleMouseOver.Alignment = StringAlignment.Center;
      this.FavouritesPanel.TabIndex = 3;
      this.FavTree.Dock = DockStyle.Fill;
      this.FavTree.HideSelection = false;
      this.FavTree.ImageIndex = -1;
      this.FavTree.Indent = 0x13;
      this.FavTree.ItemHeight = 0x10;
      this.FavTree.Location = new Point(1, 1);
      this.FavTree.Name = "FavTree";
      this.FavTree.SelectedImageIndex = -1;
      this.FavTree.Size = new Size(0xd6, 0x173);
      this.FavTree.TabIndex = 8;
      this.FavouritesPan.ButtonStyle = eButtonStyle.ImageAndText;
      this.FavouritesPan.Icon = (Icon)(new ResourceManager(typeof(frmMain))).GetObject("FavouritesPan.Icon");
      this.FavouritesPan.Name = "FavouritesPan";
      this.FavouritesPan.OptionGroup = "navBar";
      this.FavouritesPan.Style = eDotNetBarStyle.Office2003;
      this.FavouritesPan.Text = "Favourites";
      this.SplitterBottom.BackColor2 = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterBottom.BackColor2SchemePart = eColorSchemePart.PanelBorder;
      this.SplitterBottom.BackColorSchemePart = eColorSchemePart.PanelBackground;
      this.SplitterBottom.Dock = DockStyle.Bottom;
      this.SplitterBottom.ExpandableControl = this.ErrorMsg;
      this.SplitterBottom.ExpandFillColor = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterBottom.ExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
      this.SplitterBottom.ExpandLineColor = SystemColors.ControlText;
      this.SplitterBottom.ExpandLineColorSchemePart = eColorSchemePart.ItemText;
      this.SplitterBottom.GripDarkColor = SystemColors.ControlText;
      this.SplitterBottom.GripDarkColorSchemePart = eColorSchemePart.ItemText;
      this.SplitterBottom.GripLightColor = System.Drawing.Color.FromArgb(0xdf, 0xed, 0xfe);
      this.SplitterBottom.GripLightColorSchemePart = eColorSchemePart.BarBackground;
      this.SplitterBottom.HotBackColor = System.Drawing.Color.FromArgb(0xfe, 0x8e, 0x4b);
      this.SplitterBottom.HotBackColor2 = System.Drawing.Color.FromArgb(0xff, 0xcf, 0x8b);
      this.SplitterBottom.HotBackColor2SchemePart = eColorSchemePart.ItemPressedBackground2;
      this.SplitterBottom.HotBackColorSchemePart = eColorSchemePart.ItemPressedBackground;
      this.SplitterBottom.HotExpandFillColor = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterBottom.HotExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
      this.SplitterBottom.HotExpandLineColor = SystemColors.ControlText;
      this.SplitterBottom.HotExpandLineColorSchemePart = eColorSchemePart.ItemText;
      this.SplitterBottom.HotGripDarkColor = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterBottom.HotGripDarkColorSchemePart = eColorSchemePart.PanelBorder;
      this.SplitterBottom.HotGripLightColor = System.Drawing.Color.FromArgb(0xdf, 0xed, 0xfe);
      this.SplitterBottom.HotGripLightColorSchemePart = eColorSchemePart.BarBackground;
      this.SplitterBottom.Location = new Point(0xe0, 430);
      this.SplitterBottom.MinExtra = 5;
      this.SplitterBottom.MinSize = 5;
      this.SplitterBottom.Name = "SplitterBottom";
      this.SplitterBottom.Size = new Size(0x210, 8);
      this.SplitterBottom.TabIndex = 0x19;
      this.SplitterBottom.TabStop = false;
      this.ErrorMsg.BackColor = SystemColors.Window;
      this.ErrorMsg.Dock = DockStyle.Bottom;
      this.ErrorMsg.FullRowSelect = true;
      this.ErrorMsg.GridLines = true;
      this.ErrorMsg.HideSelection = false;
      this.ErrorMsg.Location = new Point(0xe0, 0x1b6);
      this.ErrorMsg.Name = "ErrorMsg";
      this.ErrorMsg.Size = new Size(0x210, 120);
      this.ErrorMsg.TabIndex = 7;
      this.ErrorMsg.View = View.Details;
      this.SplitterRight.AnimationTime = 0;
      this.SplitterRight.BackColor2 = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterRight.BackColor2SchemePart = eColorSchemePart.PanelBorder;
      this.SplitterRight.BackColorSchemePart = eColorSchemePart.PanelBackground;
      this.SplitterRight.Dock = DockStyle.Right;
      this.SplitterRight.ExpandableControl = this.SideBar;
      this.SplitterRight.ExpandFillColor = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterRight.ExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
      this.SplitterRight.ExpandLineColor = SystemColors.ControlText;
      this.SplitterRight.ExpandLineColorSchemePart = eColorSchemePart.ItemText;
      this.SplitterRight.GripDarkColor = SystemColors.ControlText;
      this.SplitterRight.GripDarkColorSchemePart = eColorSchemePart.ItemText;
      this.SplitterRight.GripLightColor = System.Drawing.Color.FromArgb(0xdf, 0xed, 0xfe);
      this.SplitterRight.GripLightColorSchemePart = eColorSchemePart.BarBackground;
      this.SplitterRight.HotBackColor = System.Drawing.Color.FromArgb(0xfe, 0x8e, 0x4b);
      this.SplitterRight.HotBackColor2 = System.Drawing.Color.FromArgb(0xff, 0xcf, 0x8b);
      this.SplitterRight.HotBackColor2SchemePart = eColorSchemePart.ItemPressedBackground2;
      this.SplitterRight.HotBackColorSchemePart = eColorSchemePart.ItemPressedBackground;
      this.SplitterRight.HotExpandFillColor = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterRight.HotExpandFillColorSchemePart = eColorSchemePart.PanelBorder;
      this.SplitterRight.HotExpandLineColor = SystemColors.ControlText;
      this.SplitterRight.HotExpandLineColorSchemePart = eColorSchemePart.ItemText;
      this.SplitterRight.HotGripDarkColor = System.Drawing.Color.FromArgb(0, 0x2d, 150);
      this.SplitterRight.HotGripDarkColorSchemePart = eColorSchemePart.PanelBorder;
      this.SplitterRight.HotGripLightColor = System.Drawing.Color.FromArgb(0xdf, 0xed, 0xfe);
      this.SplitterRight.HotGripLightColorSchemePart = eColorSchemePart.BarBackground;
      this.SplitterRight.Location = new Point(0x2f0, 0x4a);
      this.SplitterRight.MinExtra = 5;
      this.SplitterRight.MinSize = 5;
      this.SplitterRight.Name = "SplitterRight";
      this.SplitterRight.Size = new Size(8, 0x1e4);
      this.SplitterRight.TabIndex = 0x1b;
      this.SplitterRight.TabStop = false;
      this.SideBar.AccessibleRole = AccessibleRole.ToolBar;
      this.SideBar.AntiAlias = true;
      this.SideBar.BackColor = SystemColors.Control;
      this.SideBar.BackgroundStyle.BackColor1.ColorSchemePart = eColorSchemePart.ExplorerBarBackground;
      this.SideBar.BackgroundStyle.BackColor2.ColorSchemePart = eColorSchemePart.ExplorerBarBackground2;
      this.SideBar.BackgroundStyle.GradientAngle = 90;
      this.SideBar.Controls.Add(this.cmbArtist);
      this.SideBar.Controls.Add(this.txtTitle);
      this.SideBar.Controls.Add(this.txtAlbum);
      this.SideBar.Controls.Add(this.btnQuickEdit);
      this.SideBar.Controls.Add(this.btnQuickEditMore);
      this.SideBar.Controls.Add(this.APICView);
      this.SideBar.Controls.Add(this.txtInfo);
      this.SideBar.Dock = DockStyle.Right;
      this.SideBar.Font = new Font("Tahoma", 11f, FontStyle.Regular, GraphicsUnit.World);
      this.SideBar.GroupImages = this.GroupIcons;
      this.SideBar.Groups.AddRange(new BaseItem[] { this.BarGroupEdit, this.BarGroupPicture, this.BarGroupInfo, this.BarGroupTools });
      this.SideBar.Images = this.ToolsIcons;
      this.SideBar.Location = new Point(760, 0x4a);
      this.SideBar.Name = "SideBar";
      this.SideBar.Size = new Size(200, 0x1e4);
      this.SideBar.TabIndex = 2;
      this.SideBar.Text = "SideBar";
      this.SideBar.ThemeAware = true;
      this.cmbArtist.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
      this.cmbArtist.Autocomplete = true;
      this.cmbArtist.Location = new Point(10, 0x2b);
      this.cmbArtist.Name = "cmbArtist";
      this.cmbArtist.Size = new Size(180, 0x15);
      this.cmbArtist.TabIndex = 2;
      this.txtTitle.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
      this.txtTitle.Location = new Point(10, 80);
      this.txtTitle.Name = "txtTitle";
      this.txtTitle.Size = new Size(180, 0x15);
      this.txtTitle.TabIndex = 3;
      this.txtTitle.Text = "";
      this.txtAlbum.Anchor = AnchorStyles.Right | AnchorStyles.Left | AnchorStyles.Top;
      this.txtAlbum.Location = new Point(10, 0x75);
      this.txtAlbum.Name = "txtAlbum";
      this.txtAlbum.Size = new Size(180, 0x15);
      this.txtAlbum.TabIndex = 4;
      this.txtAlbum.Text = "";
      this.btnQuickEdit.ImeMode = ImeMode.NoControl;
      this.btnQuickEdit.Location = new Point(10, 0x9a);
      this.btnQuickEdit.Name = "btnQuickEdit";
      this.btnQuickEdit.Size = new Size(180, 0x18);
      this.btnQuickEdit.TabIndex = 5;
      this.btnQuickEdit.Text = "OK";
      this.btnQuickEditMore.Anchor = AnchorStyles.Right | AnchorStyles.Top;
      this.btnQuickEditMore.ImeMode = ImeMode.NoControl;
      this.btnQuickEditMore.Location = new Point(10, 180);
      this.btnQuickEditMore.Name = "btnQuickEditMore";
      this.btnQuickEditMore.Size = new Size(180, 0x18);
      this.btnQuickEditMore.TabIndex = 6;
      this.btnQuickEditMore.Text = "More ...";
      this.APICView.Location = new Point(10, 0xfb);
      this.APICView.Name = "APICView";
      this.APICView.Size = new Size(160, 160);
      this.APICView.SizeMode = PictureBoxSizeMode.StretchImage;
      this.APICView.TabIndex = 0x1c;
      this.APICView.TabStop = false;
      this.txtInfo.AcceptsTab = true;
      this.txtInfo.BorderStyle = BorderStyle.None;
      this.txtInfo.Location = new Point(10, 0x11d);
      this.txtInfo.Name = "txtInfo";
      this.txtInfo.ReadOnly = true;
      this.txtInfo.Size = new Size(180, 0x5c);
      this.txtInfo.TabIndex = 0x1c;
      this.txtInfo.TabStop = false;
      this.txtInfo.Text = "";
      this.BarGroupEdit.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(0xd6, 0xdf, 0xf7);
      this.BarGroupEdit.BackgroundStyle.Border = eBorderType.SingleLine;
      this.BarGroupEdit.BackgroundStyle.BorderColor.Color = System.Drawing.Color.White;
      this.BarGroupEdit.Expanded = true;
      this.BarGroupEdit.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.White;
      this.BarGroupEdit.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.BarGroupEdit.HeaderHotStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.BarGroupEdit.HeaderHotStyle.ForeColor.Color = System.Drawing.Color.FromArgb(0x42, 0x8e, 0xff);
      this.BarGroupEdit.HeaderStyle.BackColor1.Color = System.Drawing.Color.White;
      this.BarGroupEdit.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.BarGroupEdit.HeaderStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.BarGroupEdit.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(0x21, 0x5d, 0xc6);
      this.BarGroupEdit.ImageIndex = 0;
      this.BarGroupEdit.Name = "BarGroupEdit";
      this.BarGroupEdit.StockStyle = eExplorerBarStockStyle.Blue;
      this.BarGroupEdit.SubItems.AddRange(new BaseItem[] { this.lblArtist, this.CContainerArtist, this.lblTitle, this.CContainerTitle, this.lblAlbum, this.CContainerAlbum, this.lblQuickSpacer1, this.CContainerbtnQuickEditOK, this.CContainerbtnQuickEditMore });
      this.BarGroupEdit.Text = "Quick Edit";
      this.BarGroupEdit.ThemeAware = true;
      this.lblArtist.BackColor = System.Drawing.Color.Empty;
      this.lblArtist.BorderType = eBorderType.None;
      this.lblArtist.DividerStyle = false;
      this.lblArtist.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.lblArtist.ForeColor = SystemColors.ControlText;
      this.lblArtist.Name = "lblArtist";
      this.lblArtist.PaddingBottom = 0;
      this.lblArtist.PaddingLeft = 0;
      this.lblArtist.PaddingRight = 0;
      this.lblArtist.PaddingTop = 0;
      this.lblArtist.SingleLineColor = SystemColors.ControlDark;
      this.lblArtist.Text = "Artist";
      this.lblArtist.TextAlignment = StringAlignment.Near;
      this.lblArtist.TextLineAlignment = StringAlignment.Center;
      this.lblArtist.ThemeAware = true;
      this.CContainerArtist.AllowItemResize = true;
      this.CContainerArtist.Control = this.cmbArtist;
      this.CContainerArtist.MenuVisibility = eMenuVisibility.VisibleAlways;
      this.CContainerArtist.Name = "CContainerArtist";
      this.CContainerArtist.ThemeAware = true;
      this.lblTitle.BackColor = System.Drawing.Color.Empty;
      this.lblTitle.BorderType = eBorderType.None;
      this.lblTitle.DividerStyle = false;
      this.lblTitle.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.lblTitle.ForeColor = SystemColors.ControlText;
      this.lblTitle.Name = "lblTitle";
      this.lblTitle.PaddingBottom = 0;
      this.lblTitle.PaddingLeft = 0;
      this.lblTitle.PaddingRight = 0;
      this.lblTitle.PaddingTop = 0;
      this.lblTitle.SingleLineColor = SystemColors.ControlDark;
      this.lblTitle.Text = "Title";
      this.lblTitle.TextAlignment = StringAlignment.Near;
      this.lblTitle.TextLineAlignment = StringAlignment.Center;
      this.lblTitle.ThemeAware = true;
      this.CContainerTitle.AllowItemResize = true;
      this.CContainerTitle.Control = this.txtTitle;
      this.CContainerTitle.MenuVisibility = eMenuVisibility.VisibleAlways;
      this.CContainerTitle.Name = "CContainerTitle";
      this.CContainerTitle.ThemeAware = true;
      this.lblAlbum.BackColor = System.Drawing.Color.Empty;
      this.lblAlbum.BorderType = eBorderType.None;
      this.lblAlbum.DividerStyle = false;
      this.lblAlbum.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.lblAlbum.ForeColor = SystemColors.ControlText;
      this.lblAlbum.Name = "lblAlbum";
      this.lblAlbum.PaddingBottom = 0;
      this.lblAlbum.PaddingLeft = 0;
      this.lblAlbum.PaddingRight = 0;
      this.lblAlbum.PaddingTop = 0;
      this.lblAlbum.SingleLineColor = SystemColors.ControlDark;
      this.lblAlbum.Text = "Album";
      this.lblAlbum.TextAlignment = StringAlignment.Near;
      this.lblAlbum.TextLineAlignment = StringAlignment.Center;
      this.lblAlbum.ThemeAware = true;
      this.CContainerAlbum.AllowItemResize = true;
      this.CContainerAlbum.Control = this.txtAlbum;
      this.CContainerAlbum.MenuVisibility = eMenuVisibility.VisibleAlways;
      this.CContainerAlbum.Name = "CContainerAlbum";
      this.CContainerAlbum.ThemeAware = true;
      this.lblQuickSpacer1.BackColor = System.Drawing.Color.Empty;
      this.lblQuickSpacer1.BorderType = eBorderType.None;
      this.lblQuickSpacer1.DividerStyle = true;
      this.lblQuickSpacer1.Font = new Font("Microsoft Sans Serif", 8.25f);
      this.lblQuickSpacer1.ForeColor = SystemColors.ControlText;
      this.lblQuickSpacer1.Name = "lblQuickSpacer1";
      this.lblQuickSpacer1.PaddingBottom = 0;
      this.lblQuickSpacer1.PaddingLeft = 0;
      this.lblQuickSpacer1.PaddingRight = 0;
      this.lblQuickSpacer1.PaddingTop = 0;
      this.lblQuickSpacer1.SingleLineColor = SystemColors.ControlDark;
      this.lblQuickSpacer1.TextAlignment = StringAlignment.Near;
      this.lblQuickSpacer1.TextLineAlignment = StringAlignment.Center;
      this.lblQuickSpacer1.ThemeAware = true;
      this.CContainerbtnQuickEditOK.AllowItemResize = true;
      this.CContainerbtnQuickEditOK.Control = this.btnQuickEdit;
      this.CContainerbtnQuickEditOK.MenuVisibility = eMenuVisibility.VisibleAlways;
      this.CContainerbtnQuickEditOK.Name = "CContainerbtnQuickEditOK";
      this.CContainerbtnQuickEditOK.ThemeAware = true;
      this.CContainerbtnQuickEditMore.AllowItemResize = true;
      this.CContainerbtnQuickEditMore.Control = this.btnQuickEditMore;
      this.CContainerbtnQuickEditMore.MenuVisibility = eMenuVisibility.VisibleAlways;
      this.CContainerbtnQuickEditMore.Name = "CContainerbtnQuickEditMore";
      this.CContainerbtnQuickEditMore.ThemeAware = true;
      this.BarGroupPicture.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(0xd6, 0xdf, 0xf7);
      this.BarGroupPicture.BackgroundStyle.Border = eBorderType.SingleLine;
      this.BarGroupPicture.BackgroundStyle.BorderColor.Color = System.Drawing.Color.White;
      this.BarGroupPicture.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.White;
      this.BarGroupPicture.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.BarGroupPicture.HeaderHotStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.BarGroupPicture.HeaderHotStyle.ForeColor.Color = System.Drawing.Color.FromArgb(0x42, 0x8e, 0xff);
      this.BarGroupPicture.HeaderStyle.BackColor1.Color = System.Drawing.Color.White;
      this.BarGroupPicture.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.BarGroupPicture.HeaderStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.BarGroupPicture.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(0x21, 0x5d, 0xc6);
      this.BarGroupPicture.ImageIndex = 2;
      this.BarGroupPicture.Name = "BarGroupPicture";
      this.BarGroupPicture.StockStyle = eExplorerBarStockStyle.Blue;
      this.BarGroupPicture.SubItems.AddRange(new BaseItem[] { this.CContainerAPICView });
      this.BarGroupPicture.Text = "Picture";
      this.BarGroupPicture.ThemeAware = true;
      this.CContainerAPICView.AllowItemResize = false;
      this.CContainerAPICView.Control = this.APICView;
      this.CContainerAPICView.MenuVisibility = eMenuVisibility.VisibleAlways;
      this.CContainerAPICView.Name = "CContainerAPICView";
      this.CContainerAPICView.ThemeAware = true;
      this.BarGroupInfo.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(0xd6, 0xdf, 0xf7);
      this.BarGroupInfo.BackgroundStyle.Border = eBorderType.SingleLine;
      this.BarGroupInfo.BackgroundStyle.BorderColor.Color = System.Drawing.Color.White;
      this.BarGroupInfo.Expanded = true;
      this.BarGroupInfo.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.White;
      this.BarGroupInfo.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.BarGroupInfo.HeaderHotStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.BarGroupInfo.HeaderHotStyle.ForeColor.Color = System.Drawing.Color.FromArgb(0x42, 0x8e, 0xff);
      this.BarGroupInfo.HeaderStyle.BackColor1.Color = System.Drawing.Color.White;
      this.BarGroupInfo.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.BarGroupInfo.HeaderStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.BarGroupInfo.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(0x21, 0x5d, 0xc6);
      this.BarGroupInfo.ImageIndex = 3;
      this.BarGroupInfo.Name = "BarGroupInfo";
      this.BarGroupInfo.StockStyle = eExplorerBarStockStyle.Blue;
      this.BarGroupInfo.SubItems.AddRange(new BaseItem[] { this.CContainertxtInfo });
      this.BarGroupInfo.Text = "Information";
      this.BarGroupInfo.ThemeAware = true;
      this.CContainertxtInfo.AllowItemResize = true;
      this.CContainertxtInfo.Control = this.txtInfo;
      this.CContainertxtInfo.MenuVisibility = eMenuVisibility.VisibleAlways;
      this.CContainertxtInfo.Name = "CContainertxtInfo";
      this.CContainertxtInfo.ThemeAware = true;
      this.BarGroupTools.BackgroundStyle.BackColor1.Color = System.Drawing.Color.FromArgb(0xd6, 0xdf, 0xf7);
      this.BarGroupTools.BackgroundStyle.Border = eBorderType.SingleLine;
      this.BarGroupTools.BackgroundStyle.BorderColor.Color = System.Drawing.Color.White;
      this.BarGroupTools.Expanded = true;
      this.BarGroupTools.HeaderHotStyle.BackColor1.Color = System.Drawing.Color.White;
      this.BarGroupTools.HeaderHotStyle.BackColor2.Color = System.Drawing.Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.BarGroupTools.HeaderHotStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.BarGroupTools.HeaderHotStyle.ForeColor.Color = System.Drawing.Color.FromArgb(0x42, 0x8e, 0xff);
      this.BarGroupTools.HeaderStyle.BackColor1.Color = System.Drawing.Color.White;
      this.BarGroupTools.HeaderStyle.BackColor2.Color = System.Drawing.Color.FromArgb(0xc7, 0xd3, 0xf7);
      this.BarGroupTools.HeaderStyle.Font = new Font("Tahoma", 11f, FontStyle.Bold, GraphicsUnit.World);
      this.BarGroupTools.HeaderStyle.ForeColor.Color = System.Drawing.Color.FromArgb(0x21, 0x5d, 0xc6);
      this.BarGroupTools.ImageIndex = 1;
      this.BarGroupTools.Name = "BarGroupTools";
      this.BarGroupTools.StockStyle = eExplorerBarStockStyle.Blue;
      this.BarGroupTools.Text = "Tools";
      this.BarGroupTools.ThemeAware = true;
      this.MP3View.AllowColumnReorder = true;
      this.MP3View.Dock = DockStyle.Fill;
      this.MP3View.FullRowSelect = true;
      this.MP3View.HideSelection = false;
      this.MP3View.Location = new Point(0xe0, 0x4a);
      this.MP3View.Name = "MP3View";
      this.MP3View.Size = new Size(0x210, 0x164);
      this.MP3View.TabIndex = 0;
      this.MP3View.View = View.Details;
      this.EnumInfo.BackColor = SystemColors.Info;
      this.EnumInfo.BorderStyle = BorderStyle.FixedSingle;
      this.EnumInfo.Font = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
      this.EnumInfo.ForeColor = SystemColors.InfoText;
      this.EnumInfo.ImeMode = ImeMode.NoControl;
      this.EnumInfo.Location = new Point(600, 0x20);
      this.EnumInfo.Name = "EnumInfo";
      this.EnumInfo.Size = new Size(0x90, 0x10);
      this.EnumInfo.TabIndex = 0x16;
      this.EnumInfo.Text = "Enumeration mode";
      this.EnumInfo.TextAlign = ContentAlignment.MiddleCenter;
      this.EnumInfo.Visible = false;

      this.btnQuickEdit.Click += new EventHandler(this.btnQuickEdit_Click);
      this.btnQuickEditMore.Click += new EventHandler(this.btnQuickEditMore_Click);
      this.cmbArtist.KeyUp += new KeyEventHandler(this.txtQuickEdit_KeyUp);
      this.cmbArtist.Enter += new EventHandler(this.txtArtistTitleAlbum_Enter);
      this.DotNetBarManager.ItemClick += new EventHandler(this.DotNetBarManager_ItemClick);
      this.ErrorMsg.MouseUp += new MouseEventHandler(this.ErrorMsg_MouseUp);
      this.FavTree.MouseUp += new MouseEventHandler(this.FavTree_MouseUp);
      this.FavTree.AfterSelect += new TreeViewEventHandler(this.FavTree_AfterSelect);
      this.FavTree.BeforeSelect += new TreeViewCancelEventHandler(this.FavTree_BeforeSelect);
      this.MP3View.ItemDrag += new ItemDragEventHandler(this.MP3View_ItemDrag);
      this.MP3View.AfterLabelEdit += new LabelEditEventHandler(this.MP3View_AfterLabelEdit);
      this.MP3View.DoubleClick += new EventHandler(this.MP3View_DoubleClick);
      this.MP3View.Click += new EventHandler(this.MP3View_Click);
      this.MP3View.KeyDown += new KeyEventHandler(this.MP3View_KeyDown);
      this.MP3View.MouseUp += new MouseEventHandler(this.MP3View_MouseUp);
      this.MP3View.MouseLeave += new EventHandler(this.MP3View_MouseLeave);
      this.MP3View.MouseEnter += new EventHandler(this.MP3View_MouseEnter);
      this.MP3View.MouseMove += new MouseEventHandler(this.MP3View_MouseMove);
      this.MP3View.SelectedIndexChanged += new EventHandler(this.MP3View_SelectedIndexChanged);
      this.MP3View.ColumnClick += new ColumnClickEventHandler(this.MP3View_ColumnClick);
      this.txtTitle.KeyUp += new KeyEventHandler(this.txtQuickEdit_KeyUp);
      this.txtTitle.Enter += new EventHandler(this.txtArtistTitleAlbum_Enter);
      this.txtAlbum.KeyUp += new KeyEventHandler(this.txtQuickEdit_KeyUp);
      this.txtAlbum.EnabledChanged += new EventHandler(this.txtArtistTitleAlbum_Enter);
      this.SideBar.ItemClick += new EventHandler(this.SideBar_ItemClick);
      this.SideBar.ContainerLoadControl += new EventHandler(this.SideBar_ContainerLoadControl);

      this.AutoScaleBaseSize = new Size(5, 13);
      this.ClientSize = new Size(960, 0x246);
      this.Controls.Add(this.EnumInfo);
      this.Controls.Add(this.MP3View);
      this.Controls.Add(this.SplitterBottom);
      this.Controls.Add(this.ErrorMsg);
      this.Controls.Add(this.SplitterRight);
      this.Controls.Add(this.SideBar);
      this.Controls.Add(this.SplitterLeft);
      this.Controls.Add(this.NavigationPan);
      this.Controls.Add(this.barLeftDockSite);
      this.Controls.Add(this.barRightDockSite);
      this.Controls.Add(this.barTopDockSite);
      this.Controls.Add(this.barBottomDockSite);
      this.Icon = (Icon)(new ResourceManager(typeof(frmMain))).GetObject("$this.Icon");
      this.Name = "frmMain";
      this.Text = "ID3-TagIT";
      this.NavigationPan.ResumeLayout(false);
      this.FoldersPanel.ResumeLayout(false);
      this.FavouritesPanel.ResumeLayout(false);
      ((ISupportInitialize)this.SideBar).EndInit();
      this.SideBar.ResumeLayout(false);
      this.ResumeLayout(false);
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
      this.vbytToolBarTAGVersion = 0;
      this.vbooFolderRename = false;
      this.vstrFolderRenameOldPath = "";
      this.vstrFolderRenameNewPath = "";
      this.alstCopyPaste = new ArrayList();
      this.vintEnumCount = Declarations.objSettings.FilenumberStart;
      this.vintHelpCount = 0;
      this.InitializeComponent();
    }

    private void AudioCheckSumCalculation()
    {
      if (Declarations.objSettings.AudioChecksumCalc)
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
          ((ProgressBarItem)this.DotNetBarManager.GetItem("StatusProgressBar")).Value = 0;
        ((ProgressBarItem)this.DotNetBarManager.GetItem("StatusProgressBar")).Maximum = this.MP3View.Items.Count;
        this.DotNetBarManager.GetItem("lblVersion").Visible = false;
        this.DotNetBarManager.GetItem("lblSubDirs").Visible = false;
        this.DotNetBarManager.GetItem("lblProgress").Visible = true;
        this.DotNetBarManager.GetItem("StatusProgressBar").Visible = true;
        this.CalcAudioCheckSumThread = new Thread(new ThreadStart(this.CalcAudioCheckSum));
        this.CalcAudioCheckSumThread.IsBackground = true;
        this.CalcAudioCheckSumThread.Priority = ThreadPriority.Lowest;
        this.CalcAudioCheckSumThread.Start();
      }
    }

    private void btnQuickEdit_Click(object sender, EventArgs e)
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

    private void btnQuickEditMore_Click(object sender, EventArgs e)
    {
      frmMain main;
      if (this.vbytVersionToShow == 1)
      {
        if (this.MP3View.SelectedItems.Count == 1)
        {
          if (this.MP3View.SelectedItems.Count == 0)
          {
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
          }
          else
          {
            main = this;
            new frmTAG1(ref main).ShowDialog(this);
          }
        }
        else if (this.MP3View.SelectedItems.Count > 1)
        {
          if (this.MP3View.SelectedItems.Count == 0)
          {
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
          }
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
          {
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
          }
          else
          {
            main = this;
            new frmTAG2(ref main).ShowDialog(this);
          }
        }
        else if (this.MP3View.SelectedItems.Count > 1)
        {
          if (this.MP3View.SelectedItems.Count == 0)
          {
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
          }
          else
          {
            main = this;
            new frmTAG2Multi(ref main).ShowDialog(this);
          }
        }
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
            {
              this.MP3View.Items[i].SubItems[this.colHAudioCheckSum.Index].Text = StringType.FromObject(Interaction.IIf(tag.AudioCheckSum != 0, tag.AudioCheckSum.ToString(), ""));
            }
          }
            ((ProgressBarItem)this.DotNetBarManager.GetItem("StatusProgressBar")).PerformStep();
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
        this.DotNetBarManager.GetItem("lblVersion").Visible = true;
        this.DotNetBarManager.GetItem("lblSubDirs").Visible = true;
        this.DotNetBarManager.GetItem("lblProgress").Visible = false;
        this.DotNetBarManager.GetItem("StatusProgressBar").Visible = false;
      }
    }

    private void CalcGetTime()
    {
      do
      {
        Thread.Sleep(0x3e8);
        this.vintHelpCount++;
      }
      while (1 != 0);
    }

    private bool CheckAllChanged()
    {
      foreach (ListViewItem item in this.MP3View.Items)
      {
        if (BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)))
        {
          return true;
        }
      }
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
          {
            vLeft = StringType.FromObject(ObjectType.StrCatObj(vLeft, ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null), "\0")));
          }
          Id3TagIT_Main.ShellFileOp(vLeft, path, Declarations.ShellOperation.CopyOp, Declarations.ShellOperationFlags.FilesOnly | Declarations.ShellOperationFlags.AllowUndo, this);
          if (path.StartsWith(Declarations.objSettings.CurrentPath) & Declarations.objSettings.ScanSubDirs)
          {
            this.GetFiles(null, true, true);
          }
          else
          {
            this.AudioCheckSumCalculation();
          }
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
        {
          this.GetFiles(null, true, true);
        }
      }
      this.Focus();
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
      {
        this.components.Dispose();
      }
      base.Dispose(disposing);
    }

    private void DotNetBarManager_ItemClick(object sender, EventArgs e)
    {
      bool flag2;
      frmMain main;
      BaseItem item = (BaseItem)sender;
      if (StringType.StrCmp(item.Name, "btnErrorListClear", false) == 0)
      {
        this.ErrorMsg.BeginUpdate();
        this.ErrorMsg.Items.Clear();
        this.ErrorMsg.EndUpdate();
        return;
      }
      string name = item.Name;
      if (StringType.StrCmp(name, "mnubtnAddDir", false) == 0)
      {
        string selectedPath = "";
        this.FolderBrowserDialog.Description = StringType.FromObject(Declarations.objResources.ResStrings["FileAddDir"]);
        this.FolderBrowserDialog.SelectedPath = Declarations.objSettings.MoveCopyPath;
        if (this.FolderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
        {
          selectedPath = this.FolderBrowserDialog.SelectedPath;
          if (StringType.StrCmp(selectedPath, Declarations.objSettings.CurrentPath, false) != 0)
          {
            ArrayList alstFolders = new ArrayList {
                            selectedPath
                        };
            this.GetFiles(alstFolders, false, true);
          }
        }
        this.Timer.Start();
        return;
      }
      if (StringType.StrCmp(name, "mnubtnRefresh", false) != 0)
      {
        if (StringType.StrCmp(name, "mnubtnSave", false) == 0)
        {
          this.SaveChanges();
          return;
        }
        if (StringType.StrCmp(name, "mnubtnMoveFiles", false) == 0)
        {
          this.MoveFiles();
          return;
        }
        if (StringType.StrCmp(name, "mnubtnCopyFiles", false) == 0)
        {
          this.CopyFiles();
          return;
        }
        if (StringType.StrCmp(name, "mnubtnDeleteFiles", false) == 0)
        {
          this.DeleteFiles();
          return;
        }
        if (StringType.StrCmp(name, "mnubtnOrganizeFiles", false) != 0)
        {
          ButtonItem item23 = null;
          Declarations.CopyTAG ytag2;
          frmProgress.Callback callback;
          Form form;
          if (StringType.StrCmp(name, "mnubtnLocation", false) == 0)
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
            return;
          }
          if (StringType.StrCmp(name, "mnubtnRemoveFolders", false) == 0)
          {
            new frmRemoveFolders(this).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnPlay", false) == 0)
          {
            Process process2 = new Process();
            string vLeft = "";
            foreach (ListViewItem item3 in this.MP3View.SelectedItems)
            {
              vLeft = StringType.FromObject(ObjectType.StrCatObj(vLeft, ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(item3.Tag, null, "FI", new object[0], null, null), null, "FullName", new object[0], null, null), "\r\n")));
            }
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
            return;
          }
          if (StringType.StrCmp(name, "mnubtnRename", false) == 0)
          {
            if ((this.ActiveControl == this.FolderTree) | (this.ActiveControl == this.NavigationPan))
            {
              this.FolderTree.SelectedNode.ExecuteShellCommand(ShellCommands.Rename);
            }
            else if (this.MP3View.FocusedItem != null)
            {
              this.MP3View.LabelEdit = true;
              this.MP3View.FocusedItem.BeginEdit();
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnProperties", false) == 0)
          {
            Declarations.SHELLEXECUTEINFO expression = new Declarations.SHELLEXECUTEINFO();
            if (this.MP3View.FocusedItem != null)
            {
              expression.cbSize = Strings.Len(expression);
              expression.fMask = 0x44c;
              expression.hwnd = this.Handle.ToInt32();
              expression.lpVerb = "properties";
              expression.lpFile = StringType.FromObject(ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(this.MP3View.FocusedItem.Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null), "\0"));
              expression.lpParameters = "\0";
              expression.lpDirectory = "\0";
              expression.nShow = 0;
              expression.hInstApp = 0;
              expression.lpIDList = 0;
              Declarations.ShellExecuteEx(ref expression);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnQuit", false) == 0)
          {
            Declarations.MP3s = null;
            this.Close();
            return;
          }
          if (StringType.StrCmp(name, "mnubtnUndo", false) == 0)
          {
            if (Declarations.UNDOList.Count > 0)
            {
              ArrayList list2 = (ArrayList)Declarations.UNDOList[Declarations.UNDOList.Count - 1];
              ArrayList list3 = new ArrayList();
              form = this;
              callback = new frmProgress.Callback(this.UnDoCB);
              frmProgress progress = new frmProgress(0, list2.Count, 50, ref form, ref callback);
              progress.SetStateUndo();
              progress.List = list2;
              progress.ListHelp = list3;
              progress.ShowDialog(this);
              progress.ProgressBar.Value = progress.ProgressBar.Maximum;
              Declarations.REDOList.Add(list3);
              this.mnubtnRedo.Enabled = true;
              Declarations.UNDOList.RemoveAt(Declarations.UNDOList.Count - 1);
              if (Declarations.UNDOList.Count == 0)
              {
                this.UnDoEnable(false, false);
              }
              this.MP3View_FillColumns(ref Declarations.MP3s);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnRedo", false) == 0)
          {
            if (Declarations.REDOList.Count > 0)
            {
              ArrayList list4 = (ArrayList)Declarations.REDOList[Declarations.REDOList.Count - 1];
              ArrayList list5 = new ArrayList();
              form = this;
              callback = new frmProgress.Callback(this.ReDoCB);
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
                this.mnubtnRedo.Enabled = false;
              }
              this.MP3View_FillColumns(ref Declarations.MP3s);
              progress2.Close();
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnCopyV1", false) == 0)
          {
            foreach (ListViewItem item4 in this.MP3View.SelectedItems)
            {
              ytag2 = new Declarations.CopyTAG((V1TAG)LateBinding.LateGet(LateBinding.LateGet(item4.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), null);
              this.alstCopyPaste.Add(ytag2);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnCopyV2", false) == 0)
          {
            this.alstCopyPaste.Clear();
            foreach (ListViewItem item5 in this.MP3View.SelectedItems)
            {
              ytag2 = new Declarations.CopyTAG(null, (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item5.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null));
              this.alstCopyPaste.Add(ytag2);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnCopyV1V2", false) == 0)
          {
            this.alstCopyPaste.Clear();
            foreach (ListViewItem item6 in this.MP3View.SelectedItems)
            {
              ytag2 = new Declarations.CopyTAG((V1TAG)LateBinding.LateGet(LateBinding.LateGet(item6.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item6.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null));
              this.alstCopyPaste.Add(ytag2);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnPaste", false) == 0)
          {
            ArrayList list6 = new ArrayList();
            if (!((this.MP3View.SelectedItems.Count == 0) | (this.alstCopyPaste.Count == 0)))
            {
              this.MP3View.BeginUpdate();
              if (this.alstCopyPaste.Count == 1)
              {
                form = this;
                callback = new frmProgress.Callback(this.Paste1CB);
                frmProgress progress3 = new frmProgress(0, IntegerType.FromObject(Interaction.IIf(this.MP3View.SelectedItems.Count <= this.alstCopyPaste.Count, this.MP3View.SelectedItems.Count, this.alstCopyPaste.Count)), 1, ref form, ref callback);
                progress3.SetStatePaste();
                progress3.List = list6;
                progress3.ShowDialog(this);
              }
              else if (this.MP3View.SelectedItems.Count <= this.alstCopyPaste.Count)
              {
                form = this;
                callback = new frmProgress.Callback(this.Paste2CB);
                frmProgress progress4 = new frmProgress(0, IntegerType.FromObject(Interaction.IIf(this.MP3View.SelectedItems.Count <= this.alstCopyPaste.Count, this.MP3View.SelectedItems.Count, this.alstCopyPaste.Count)), 1, ref form, ref callback);
                progress4.SetStatePaste();
                progress4.List = list6;
                progress4.ShowDialog(this);
              }
              else
              {
                form = this;
                callback = new frmProgress.Callback(this.Paste3CB);
                frmProgress progress5 = new frmProgress(0, IntegerType.FromObject(Interaction.IIf(this.MP3View.SelectedItems.Count <= this.alstCopyPaste.Count, this.MP3View.SelectedItems.Count, this.alstCopyPaste.Count)), 1, ref form, ref callback);
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
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSearchReplace", false) == 0)
          {
            new frmSearch { MainForm = this }.Show();
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSelectAll", false) == 0)
          {
            this.MP3View.BeginUpdate();
            foreach (ListViewItem item7 in this.MP3View.Items)
            {
              item7.Selected = true;
            }
            this.MP3View.EndUpdate();
            try
            {
              if (this.MP3View.FocusedItem == null)
              {
                this.MP3View.Items[0].Focused = true;
              }
            }
            catch (Exception exception9)
            {
              ProjectData.SetProjectError(exception9);
              ProjectData.ClearProjectError();
            }
            this.MP3View.Focus();
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSelectInvert", false) == 0)
          {
            this.MP3View.BeginUpdate();
            foreach (ListViewItem item8 in this.MP3View.Items)
            {
              item8.Selected ^= true;
            }
            this.MP3View.EndUpdate();
            try
            {
              if (this.MP3View.FocusedItem == null)
              {
                this.MP3View.Items[0].Focused = true;
              }
            }
            catch (Exception exception10)
            {
              ProjectData.SetProjectError(exception10);
              ProjectData.ClearProjectError();
            }
            this.MP3View.Focus();
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSelectGroup", false) == 0)
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
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSelectFormat", false) == 0)
          {
            main = this;
            new frmSelectFormat(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSelectChanged", false) == 0)
          {
            this.MP3View.ListViewItemSorter = null;
            foreach (ListViewItem item11 in this.MP3View.Items)
            {
              if (BooleanType.FromObject(LateBinding.LateGet(item11.Tag, null, "Changed", new object[0], null, null)))
              {
                item11.Selected = true;
              }
              else if (Declarations.objSettings.SelectionMode == 1)
              {
                item11.Selected = false;
              }
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSelectDouble", false) == 0)
          {
            this.MP3View.ListViewItemSorter = null;
            foreach (ListViewItem item12 in this.MP3View.Items)
            {
              if (BooleanType.FromObject(LateBinding.LateGet(item12.Tag, null, "Doubled", new object[0], null, null)))
              {
                item12.Selected = true;
              }
              else if (Declarations.objSettings.SelectionMode == 1)
              {
                item12.Selected = false;
              }
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSelectCompare", false) == 0)
          {
            this.MP3View.ListViewItemSorter = null;
            foreach (ListViewItem item13 in this.MP3View.Items)
            {
              if (BooleanType.FromObject(LateBinding.LateGet(item13.Tag, null, "FileTAGCompare", new object[0], null, null)))
              {
                item13.Selected = true;
              }
              else if (Declarations.objSettings.SelectionMode == 1)
              {
                item13.Selected = false;
              }
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnViewVer1", false) == 0)
          {
            if (this.vbytVersionToShow != 1)
            {
              this.vbytVersionToShow = 1;
              Declarations.objSettings.VersionToShow = this.vbytVersionToShow;
              this.mnubtnViewVer2.Checked = false;
              this.mnubtnViewVer1.Checked = true;
              try
              {
                this.DotNetBarManager.GetItem("btnV1V2View").Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
              }
              catch (Exception exception11)
              {
                ProjectData.SetProjectError(exception11);
                Exception exception3 = exception11;
                ProjectData.ClearProjectError();
              }
              this.DotNetBarManager.GetItem("lblVersion").Text = StringType.FromObject(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " 1"));
              foreach (ListViewItem item14 in this.MP3View.SelectedItems)
              {
                LateBinding.LateSetComplex(item14.Tag, null, "Selected", new object[] { true }, null, false, true);
              }
              this.MP3View_FillColumns(ref Declarations.MP3s);
              this.MP3View.Focus();
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnViewVer2", false) == 0)
          {
            if (this.vbytVersionToShow != 2)
            {
              this.vbytVersionToShow = 2;
              Declarations.objSettings.VersionToShow = this.vbytVersionToShow;
              this.mnubtnViewVer2.Checked = true;
              this.mnubtnViewVer1.Checked = false;
              try
              {
                this.DotNetBarManager.GetItem("btnV1V2View").Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
              }
              catch (Exception exception12)
              {
                ProjectData.SetProjectError(exception12);
                Exception exception4 = exception12;
                ProjectData.ClearProjectError();
              }
              this.DotNetBarManager.GetItem("lblVersion").Text = StringType.FromObject(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " 2"));
              foreach (ListViewItem item15 in this.MP3View.SelectedItems)
              {
                LateBinding.LateSetComplex(item15.Tag, null, "Selected", new object[] { true }, null, false, true);
              }
              this.MP3View_FillColumns(ref Declarations.MP3s);
              this.MP3View.Focus();
            }
            return;
          }
          if (StringType.StrCmp(name, "btnV1V2View", false) == 0)
          {
            if (this.vbytVersionToShow != 1)
            {
              this.vbytVersionToShow = 1;
              Declarations.objSettings.VersionToShow = this.vbytVersionToShow;
              this.mnubtnViewVer2.Checked = false;
              this.mnubtnViewVer1.Checked = true;
              try
              {
                this.DotNetBarManager.GetItem("btnV1V2View").Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
              }
              catch (Exception exception13)
              {
                ProjectData.SetProjectError(exception13);
                Exception exception5 = exception13;
                ProjectData.ClearProjectError();
              }
              this.DotNetBarManager.GetItem("lblVersion").Text = StringType.FromObject(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " 1"));
              foreach (ListViewItem item16 in this.MP3View.SelectedItems)
              {
                LateBinding.LateSetComplex(item16.Tag, null, "Selected", new object[] { true }, null, false, true);
              }
              this.MP3View_FillColumns(ref Declarations.MP3s);
              this.MP3View.Focus();
            }
            else
            {
              this.vbytVersionToShow = 2;
              Declarations.objSettings.VersionToShow = this.vbytVersionToShow;
              this.mnubtnViewVer2.Checked = true;
              this.mnubtnViewVer1.Checked = false;
              try
              {
                this.DotNetBarManager.GetItem("btnV1V2View").Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
              }
              catch (Exception exception14)
              {
                ProjectData.SetProjectError(exception14);
                Exception exception6 = exception14;
                ProjectData.ClearProjectError();
              }
              this.DotNetBarManager.GetItem("lblVersion").Text = StringType.FromObject(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " 2"));
              foreach (ListViewItem item17 in this.MP3View.SelectedItems)
              {
                LateBinding.LateSetComplex(item17.Tag, null, "Selected", new object[] { true }, null, false, true);
              }
              this.MP3View_FillColumns(ref Declarations.MP3s);
              this.MP3View.Focus();
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnRemove", false) == 0)
          {
            this.MP3View.ListViewItemSorter = null;
            this.MP3View.BeginUpdate();
            foreach (ListViewItem item18 in this.MP3View.SelectedItems)
            {
              Declarations.MP3s.Remove(RuntimeHelpers.GetObjectValue(item18.Tag));
              this.MP3View.Items.Remove(item18);
            }
            this.MP3View.EndUpdate();
            return;
          }
          if (StringType.StrCmp(name, "mnubtnE1", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
              return;
            }
            main = this;
            new frmTAG1(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnME1", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
              return;
            }
            main = this;
            new frmTAG1Multi(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnRemoveV1", false) == 0)
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
              form = this;
              callback = new frmProgress.Callback(this.Remove1CB);
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
            return;
          }
          if (StringType.StrCmp(name, "mnubtnFT1", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
              return;
            }
            main = this;
            new frmFilenameToTAG1(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnT1F", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
              return;
            }
            main = this;
            new frmTAG1ToFilename(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnE2", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
              return;
            }
            main = this;
            new frmTAG2(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnME2", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
              return;
            }
            main = this;
            new frmTAG2Multi(ref main).ShowDialog();
            return;
          }
          if (StringType.StrCmp(name, "mnubtnRemoveV2", false) == 0)
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
              form = this;
              callback = new frmProgress.Callback(this.Remove2CB);
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
            return;
          }
          if (StringType.StrCmp(name, "mnubtnFT2", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
              return;
            }
            main = this;
            new frmFilenameToTAG2(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnT2F", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
              return;
            }
            main = this;
            new frmTAG2ToFilename(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnChangeTextEnc", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
              return;
            }
            main = this;
            new frmEncoding(ref main).ShowDialog(this);
            return;
          }
          if (((StringType.StrCmp(name, "mnubtnEnumFilename", false) == 0) || (StringType.StrCmp(name, "mnubtnEnumV1", false) == 0)) || (StringType.StrCmp(name, "mnubtnEnumV2", false) == 0))
          {
            ((ButtonItem)item).Checked ^= true;
            if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
            {
              this.aintLastSelected = null;
            }
            if (StringType.StrCmp(item.Name, "mnubtnEnumFilename", false) == 0)
            {
              Declarations.objSettings.EnumFile ^= true;
            }
            if (StringType.StrCmp(item.Name, "mnubtnEnumV1", false) == 0)
            {
              Declarations.objSettings.EnumVer1 ^= true;
            }
            if (StringType.StrCmp(item.Name, "mnubtnEnumV2", false) == 0)
            {
              Declarations.objSettings.EnumVer2 ^= true;
            }
            if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
            {
              this.vintEnumCount = Declarations.objSettings.FilenumberStart;
              this.mnubtnEnumCounter.Text = StringType.FromInteger(this.vintEnumCount);
            }
            this.Enumerate();
            return;
          }
          if (StringType.StrCmp(name, "mnubtnEnumMinus", false) == 0)
          {
            this.vintEnumCount--;
            if (this.vintEnumCount < 1)
            {
              this.vintEnumCount = 1;
            }
            this.mnubtnEnumCounter.Text = StringType.FromInteger(this.vintEnumCount);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnEnumPlus", false) == 0)
          {
            this.vintEnumCount++;
            this.mnubtnEnumCounter.Text = StringType.FromInteger(this.vintEnumCount);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnCaseConversion", false) == 0)
          {
            main = this;
            new frmCaseConv(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnTransfer", false) == 0)
          {
            main = this;
            new frmTransfer(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSwapV1AT", false) == 0)
          {
            ArrayList list9 = new ArrayList();
            this.MP3View.BeginUpdate();
            form = this;
            callback = new frmProgress.Callback(this.SwapArtistTitle1CB);
            frmProgress progress8 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback)
            {
              List = list9
            };
            progress8.SetStateSwap();
            progress8.ShowDialog(this);
            this.MP3View.EndUpdate();
            if (list9.Count > 0)
            {
              Declarations.UNDOList.Add(list9);
              this.UnDoEnable(true, true);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSwapV2AT", false) == 0)
          {
            ArrayList list10 = new ArrayList();
            this.MP3View.BeginUpdate();
            form = this;
            callback = new frmProgress.Callback(this.SwapArtistTitle2CB);
            frmProgress progress9 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback)
            {
              List = list10
            };
            progress9.SetStateSwap();
            progress9.ShowDialog(this);
            this.MP3View.EndUpdate();
            if (list10.Count > 0)
            {
              Declarations.UNDOList.Add(list10);
              this.UnDoEnable(true, true);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSwapV1AA", false) == 0)
          {
            ArrayList list11 = new ArrayList();
            this.MP3View.BeginUpdate();
            form = this;
            callback = new frmProgress.Callback(this.SwapArtistAlbum1CB);
            frmProgress progress10 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback)
            {
              List = list11
            };
            progress10.SetStateSwap();
            progress10.ShowDialog(this);
            this.MP3View.EndUpdate();
            if (list11.Count > 0)
            {
              Declarations.UNDOList.Add(list11);
              this.UnDoEnable(true, true);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSwapV2AA", false) == 0)
          {
            ArrayList list12 = new ArrayList();
            this.MP3View.BeginUpdate();
            form = this;
            callback = new frmProgress.Callback(this.SwapArtistAlbum2CB);
            frmProgress progress11 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback)
            {
              List = list12
            };
            progress11.SetStateSwap();
            progress11.ShowDialog(this);
            this.MP3View.EndUpdate();
            if (list12.Count > 0)
            {
              Declarations.UNDOList.Add(list12);
              this.UnDoEnable(true, true);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSwapV1TA", false) == 0)
          {
            ArrayList list13 = new ArrayList();
            this.MP3View.BeginUpdate();
            form = this;
            callback = new frmProgress.Callback(this.SwapTitleAlbum1CB);
            frmProgress progress12 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback)
            {
              List = list13
            };
            progress12.SetStateSwap();
            progress12.ShowDialog(this);
            this.MP3View.EndUpdate();
            if (list13.Count > 0)
            {
              Declarations.UNDOList.Add(list13);
              this.UnDoEnable(true, true);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSwapV2TA", false) == 0)
          {
            ArrayList list14 = new ArrayList();
            this.MP3View.BeginUpdate();
            form = this;
            callback = new frmProgress.Callback(this.SwapTitleAlbum2CB);
            frmProgress progress13 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback)
            {
              List = list14
            };
            progress13.SetStateSwap();
            progress13.ShowDialog(this);
            this.MP3View.EndUpdate();
            if (list14.Count > 0)
            {
              Declarations.UNDOList.Add(list14);
              this.UnDoEnable(true, true);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSplitArtist1", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count > 0)
            {
              ArrayList list15 = new ArrayList();
              string str5 = Interaction.InputBox(StringType.FromObject(Declarations.objResources.ResStrings["SplitATText"]), StringType.FromObject(Declarations.objResources.ResStrings["SplitAT1"]), Declarations.objSettings.SplitSeparator, -1, -1);
              if (StringType.StrCmp(str5, "", false) == 0)
              {
                return;
              }
              Declarations.objSettings.SplitSeparator = str5;
              this.MP3View.BeginUpdate();
              form = this;
              callback = new frmProgress.Callback(this.SplitArtist1CB);
              frmProgress progress14 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback)
              {
                List = list15,
                String01 = str5
              };
              progress14.SetStateSplit();
              progress14.ShowDialog(this);
              this.MP3View.EndUpdate();
              if (list15.Count > 0)
              {
                Declarations.UNDOList.Add(list15);
                this.UnDoEnable(true, true);
              }
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSplitArtist2", false) == 0)
          {
            if (this.MP3View.SelectedItems.Count > 0)
            {
              ArrayList list16 = new ArrayList();
              string str6 = Interaction.InputBox(StringType.FromObject(Declarations.objResources.ResStrings["SplitATText"]), StringType.FromObject(Declarations.objResources.ResStrings["SplitAT2"]), Declarations.objSettings.SplitSeparator, -1, -1);
              if (StringType.StrCmp(str6, "", false) == 0)
              {
                return;
              }
              Declarations.objSettings.SplitSeparator = str6;
              this.MP3View.BeginUpdate();
              form = this;
              callback = new frmProgress.Callback(this.SplitArtist2CB);
              frmProgress progress15 = new frmProgress(0, this.MP3View.SelectedItems.Count, 1, ref form, ref callback)
              {
                List = list16,
                String01 = str6
              };
              progress15.SetStateSplit();
              progress15.ShowDialog(this);
              this.MP3View.EndUpdate();
              if (list16.Count > 0)
              {
                Declarations.UNDOList.Add(list16);
                this.UnDoEnable(true, true);
              }
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnFreeDB", false) == 0)
          {
            int num2 = 0;
            foreach (ListViewItem item19 in this.MP3View.SelectedItems)
            {
              num2 = IntegerType.FromObject(ObjectType.AddObj(num2, LateBinding.LateGet(item19.Tag, null, "Duration", new object[0], null, null)));
            }
            if (((this.MP3View.SelectedItems.Count > 0) & (this.MP3View.SelectedItems.Count < 100)) & (num2 < 0x1770))
            {
              new frmFreeDB(this).ShowDialog();
            }
            else
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["FreeDBToLong"]), MsgBoxStyle.Exclamation, null);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnDouble", false) == 0)
          {
            if (this.MP3View.Items.Count > 2)
            {
              new frmDouble(this).ShowDialog(this);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnCompareFileTAG", false) == 0)
          {
            if (this.MP3View.Items.Count > 2)
            {
              main = this;
              new frmCompareFileTAG(ref main).ShowDialog(this);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnEditLibraries", false) == 0)
          {
            main = this;
            new frmLibraries(ref main).ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnLists", false) == 0)
          {
            frmLists lists = new frmLists
            {
              MainForm = this
            };
            bool flag3 = false;
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
                    {
                      flag3 = true;
                    }
                    break;

                  case MsgBoxResult.No:
                    flag3 = true;
                    break;
                }
              }
              else
              {
                flag3 = true;
              }
            }
            while (!flag3);
            lists.ShowDialog(this);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnQuickFilename", false) == 0)
          {
            Declarations.objSettings.QuickFilenameEditing ^= true;
            LateBinding.LateSet(sender, null, "Checked", new object[] { ObjectType.BitXorObj(LateBinding.LateGet(sender, null, "Checked", new object[0], null, null), true) }, null);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnScanSubDirs", false) == 0)
          {
            Declarations.objSettings.ScanSubDirs ^= true;
            LateBinding.LateSet(sender, null, "Checked", new object[] { ObjectType.BitXorObj(LateBinding.LateGet(sender, null, "Checked", new object[0], null, null), true) }, null);
            if (Declarations.objSettings.ScanSubDirs)
            {
              this.DotNetBarManager.GetItem("lblSubDirs").Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsYes"]);
            }
            else
            {
              this.DotNetBarManager.GetItem("lblSubDirs").Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsNo"]);
            }
            return;
          }
          if (StringType.StrCmp(name, "mnubtnSynchronize", false) == 0)
          {
            Declarations.objSettings.SynchronizeTAGs ^= true;
            LateBinding.LateSet(sender, null, "Checked", new object[] { ObjectType.BitXorObj(LateBinding.LateGet(sender, null, "Checked", new object[0], null, null), true) }, null);
            return;
          }
          if (StringType.StrCmp(name, "mnubtnPreferences", false) == 0)
          {
            new frmPreferences(this).ShowDialog();
            if (!((Declarations.objSettings.EnumFile | Declarations.objSettings.EnumVer1) | Declarations.objSettings.EnumVer2))
            {
              this.vintEnumCount = Declarations.objSettings.FilenumberStart;
              this.mnubtnEnumCounter.Text = StringType.FromInteger(this.vintEnumCount);
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
            this.BarGroupTools.SubItems.Clear();
            this.ToolsIcons.Images.Clear();
            int num4 = -1;
            foreach (DataRow row in Declarations.objSettings.Tools.Rows)
            {
              num4++;
              try
              {
                if (BooleanType.FromObject(row["DefaultPlayer"]))
                {
                  if (StringType.StrCmp(str9, "", false) != 0)
                  {
                    this.ToolsIcons.Images.Add(Id3TagIT_Main.GetAppIcon(str9, true));
                  }
                  ButtonItem item20 = new ButtonItem("ToolItem" + num4.ToString(), row["ToolDescription"].ToString())
                  {
                    ImageIndex = num4,
                    Tag = num4,
                    ButtonStyle = eButtonStyle.ImageAndText
                  };
                  this.BarGroupTools.SubItems.Add(item20);
                }
                else
                {
                  this.ToolsIcons.Images.Add(Id3TagIT_Main.GetAppIcon(StringType.FromObject(row["ToolPath"]), true));
                  ButtonItem item21 = new ButtonItem("ToolItem" + num4.ToString(), row["ToolDescription"].ToString())
                  {
                    ImageIndex = num4,
                    Tag = num4,
                    ButtonStyle = eButtonStyle.ImageAndText
                  };
                  this.BarGroupTools.SubItems.Add(item21);
                }
              }
              catch (Exception exception16)
              {
                ProjectData.SetProjectError(exception16);
                ButtonItem item22 = new ButtonItem("ToolItem" + num4.ToString(), row["ToolDescription"].ToString())
                {
                  Tag = num4,
                  ButtonStyle = eButtonStyle.TextOnlyAlways
                };
                this.BarGroupTools.SubItems.Add(item22);
                ProjectData.ClearProjectError();
              }
            }
            this.BarGroupTools.RecalcSize();
            this.BarGroupTools.Expanded = false;
            this.BarGroupTools.Expanded = true;
            return;
          }
          if (StringType.StrCmp(name, "mnubtnHelp", false) == 0)
          {
            new Process
            {
              StartInfo = {
                            FileName = StringType.FromObject(Interaction.IIf(Application.StartupPath.EndsWith(@"\"), Application.StartupPath + @"Help\index.htm", Application.StartupPath + @"\Help\index.htm")),
                            UseShellExecute = true
                        }
            }.Start();
            return;
          }
          if (StringType.StrCmp(name, "mnubtnShortcuts", false) == 0)
          {
            new Process
            {
              StartInfo = {
                            FileName = StringType.FromObject(Interaction.IIf(Application.StartupPath.EndsWith(@"\"), Application.StartupPath + @"Help\shortcuts.htm", Application.StartupPath + @"\Help\shortcuts.htm")),
                            UseShellExecute = true
                        }
            }.Start();
            return;
          }
          if (StringType.StrCmp(name, "mnubtnAbout", false) == 0)
          {
            new frmAbout().ShowDialog();
            return;
          }
          if ((((((StringType.StrCmp(name, "mnubtnFilterA", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterB", false) != 0)) && ((StringType.StrCmp(name, "mnubtnFilterC", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterD", false) != 0))) && (((StringType.StrCmp(name, "mnubtnFilterE", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterF", false) != 0)) && ((StringType.StrCmp(name, "mnubtnFilterG", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterH", false) != 0)))) && ((((StringType.StrCmp(name, "mnubtnFilterI", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterJ", false) != 0)) && ((StringType.StrCmp(name, "mnubtnFilterK", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterL", false) != 0))) && (((StringType.StrCmp(name, "mnubtnFilterM", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterN", false) != 0)) && ((StringType.StrCmp(name, "mnubtnFilterO", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterP", false) != 0))))) && (((((StringType.StrCmp(name, "mnubtnFilterQ", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterR", false) != 0)) && ((StringType.StrCmp(name, "mnubtnFilterS", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterT", false) != 0))) && (((StringType.StrCmp(name, "mnubtnFilterU", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterV", false) != 0)) && ((StringType.StrCmp(name, "mnubtnFilterW", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterX", false) != 0)))) && (((StringType.StrCmp(name, "mnubtnFilterY", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterZ", false) != 0)) && (((StringType.StrCmp(name, "mnubtnFilterOther", false) != 0) && (StringType.StrCmp(name, "mnubtnFilterEmpty", false) != 0)) && (StringType.StrCmp(name, "mnubtnFilterNumber", false) != 0)))))
          {
            ButtonItem item25 = null;
            if (StringType.StrCmp(name, "mnubtnRemoveFilter", false) != 0)
            {
              if ((StringType.StrCmp(name, "mnucmbLanguage", false) == 0) && !this.vbooStartUp)
              {
                Declarations.objSettings.Language = (byte)((ComboBoxItem)this.DotNetBarManager.GetItem("mnucmbLanguage")).SelectedIndex;
                Declarations.objResources.ReadResources();
                this.SetLanguage();
              }
              return;
            }
            switch (this.vbytFilterIndex)
            {
              case 0:
                item25 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"];
                break;

              case 1:
                item25 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"];
                break;

              case 2:
                item25 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"];
                break;

              case 0xff:
                return;
            }
            item25.Checked = false;
            foreach (ButtonItem item26 in item25.SubItems)
            {
              item26.Checked = false;
            }
            this.vbytFilterIndex = 0xff;
            this.vstrFilter = "*";
            Application.DoEvents();
            this.MP3View_FillColumns(ref Declarations.MP3s);
            this.Timer.Start();
            this.MP3View.Focus();
            return;
          }
          switch (this.vbytFilterIndex)
          {
            case 0:
              item23 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"];
              break;

            case 1:
              item23 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"];
              break;

            case 2:
              item23 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"];
              break;

            case 0xff:
              goto Label_31F2;
          }
          item23.Checked = false;
          foreach (ButtonItem item24 in item23.SubItems)
          {
            item24.Checked = false;
          }
          goto Label_31F2;
        }
        if (this.MP3View.SelectedItems.Count == 0)
        {
          Interaction.MsgBox(RuntimeHelpers.GetObjectValue(Declarations.objResources.ResStrings["SelectFiles"]), MsgBoxStyle.Exclamation, null);
          return;
        }
        flag2 = false;
      }
      else
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
        this.mnubtnUndo.Enabled = false;
        this.mnubtnRedo.Enabled = false;
        return;
      }
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
              {
                flag2 = true;
              }
              break;

            case MsgBoxResult.No:
              flag2 = true;
              break;
          }
        }
        else
        {
          flag2 = true;
        }
      }
      while (!flag2);
      try
      {
        this.CalcAudioCheckSumThread.Abort();
        this.CalcAudioCheckSumThread.Join();
      }
      catch (Exception exception7)
      {
        ProjectData.SetProjectError(exception7);
        Exception exception2 = exception7;
        ProjectData.ClearProjectError();
      }
      main = this;
      frmOrganize organize = new frmOrganize(ref main);
      if (organize.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
      {
        this.vbooRefreshFlag = true;
        this.FolderTree.RefreshView();
        this.vbooRefreshFlag = false;
      }
      this.AudioCheckSumCalculation();
      return;
      Label_31F2:
      this.vstrFilter = ((ButtonItem)item).Text;
      ((ButtonItem)item).Checked = true;
      string sLeft = ((ButtonItem)item).Parent.Name;
      if (StringType.StrCmp(sLeft, "mnubtnFilterArtist", false) == 0)
      {
        this.vbytFilterIndex = 0;
        ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"]).Checked = true;
      }
      else if (StringType.StrCmp(sLeft, "mnubtnFilterTitle", false) == 0)
      {
        this.vbytFilterIndex = 1;
        ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"]).Checked = true;
      }
      else if (StringType.StrCmp(sLeft, "mnubtnFilterAlbum", false) == 0)
      {
        this.vbytFilterIndex = 2;
        ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"]).Checked = true;
      }
      Application.DoEvents();
      this.MP3View_FillColumns(ref Declarations.MP3s);
      this.Timer.Start();
      this.MP3View.Focus();
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
                V2TextFrame frame2 = new V2TextFrame
                {
                  FID = "TRCK"
                };
                if (frame.Content.IndexOf("/") < 0)
                {
                  frame2.Content = this.vintEnumCount.ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0');
                }
                else
                {
                  frame2.Content = this.vintEnumCount.ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') + frame.Content.Substring(frame.Content.IndexOf("/"));
                }
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
                {
                  tag.V2TAG.TAGHeaderPresent = true;
                }
                tag.Changed = true;
              }
              this.UpdateListItem(item, false);
            }
            this.vintEnumCount++;
            this.mnubtnEnumCounter.Text = this.vintEnumCount.ToString();
          }
        }
        this.MP3View.EndUpdate();
        Declarations.UNDOList.Add(list);
        this.UnDoEnable(true, true);
      }
      this.aintLastSelected = new int[(this.MP3View.SelectedIndices.Count - 1) + 1];
      this.MP3View.SelectedIndices.CopyTo(this.aintLastSelected, 0);
    }

    private void ErrorMsg_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        ButtonItem item = (ButtonItem)this.DotNetBarManager.ContextMenus["ErrorListMenu"];
        item.Displayed = false;
        item.PopupMenu(Control.MousePosition);
      }
    }

    private void FavTree_AfterSelect(object sender, TreeViewEventArgs e)
    {
      int num;
      ButtonItem item2 = null;
      bool flag = false;
      if (((e.Action == TreeViewAction.Expand) | (e.Action == TreeViewAction.Collapse)) | (e.Action == TreeViewAction.Unknown))
      {
        goto Label_021B;
      }
      this.vstrFilter = "*";
      switch (this.vbytFilterIndex)
      {
        case 0:
          item2 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"];
          break;

        case 1:
          item2 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"];
          break;

        case 2:
          item2 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"];
          break;

        case 0xff:
          goto Label_010A;
      }
      item2.Checked = false;
      foreach (ButtonItem item3 in item2.SubItems)
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
        ArrayList list2 = new ArrayList {
                    e.Node.Text
                };
        this.GetFiles(list2, true, false);
        if (Directory.Exists(e.Node.Text))
        {
          Declarations.objSettings.CurrentPath = e.Node.Text;
        }
      }
      this.MP3View_FillColumns(ref Declarations.MP3s);
      Label_021B:
      num = 0;
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        num = IntegerType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(item.Tag, null, "Duration", new object[0], null, null)));
      }
      int num3 = num / 0xe10;
      num3 = (num - ((num / 0xe10) * 0xe10)) / 60;
      string introduced21 = num3.ToString().PadLeft(2, '0') + ":";
      num3 = (num - ((num / 0xe10) * 0xe10)) - (((num - ((num / 0xe10) * 0xe10)) / 60) * 60);
      string introduced22 = introduced21 + num3.ToString().PadLeft(2, '0') + ":";
      string str = introduced22 + num3.ToString().PadLeft(2, '0');
      object[] args = new object[] { "%3", str };
      bool[] copyBack = new bool[] { false, true };
      if (copyBack[1])
      {
        str = StringType.FromObject(args[1]);
      }
      this.DotNetBarManager.GetItem("lblNumber").Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["Number"], null, "Replace", new object[] { "%1", this.MP3View.Items.Count.ToString() }, null, null), null, "Replace", new object[] { "%2", this.MP3View.SelectedItems.Count.ToString() }, null, null), null, "Replace", args, null, copyBack));
      args = new object[2];
      args[0] = "%1";
      Settings objSettings = Declarations.objSettings;
      args[1] = objSettings.CurrentPath;
      object[] objArray2 = args;
      copyBack = new bool[] { false, true };
      if (copyBack[1])
      {
        objSettings.CurrentPath = StringType.FromObject(objArray2[1]);
      }
      this.DotNetBarManager.GetItem("lblPath").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", objArray2, null, copyBack));
      try
      {
        this.DotNetBarManager.GetItem("lblLength").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", this.MP3View.FocusedItem.Text.Length.ToString() }, null, null));
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        this.DotNetBarManager.GetItem("lblLength").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", "0" }, null, null));
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

    private void FavTree_MouseUp(object sender, MouseEventArgs e)
    {
      if (e.Button == MouseButtons.Right)
      {
        ButtonItem item = (ButtonItem)this.DotNetBarManager.ContextMenus["FavouritesMenu"];
        item.Displayed = false;
        item.PopupMenu(Control.MousePosition);
      }
    }

    private void FolderRenameCB(ref frmProgress frmProg)
    {
      IEnumerator enumerator = null;
      string oldValue = frmProg.String01;
      string newValue = frmProg.String02;
      frmProg.btnCancel.Enabled = false;
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
            {
              current.FI = new FileInfo(path);
            }
          }
          frmProg.ProgressBar.PerformStep();
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

    private void FolderRenameEventProcessor(object myObject, EventArgs myEventArgs)
    {
      Application.DoEvents();
      this.vbytFolderRenameCount = (byte)(this.vbytFolderRenameCount + 1);
      if (Directory.Exists(this.vstrFolderRenameNewPath) & !Directory.Exists(this.vstrFolderRenameOldPath))
      {
        this.FolderRenameTimer.Stop();
        this.vbytFolderRenameCount = 0;
        Declarations.objSettings.CurrentPath = this.FolderTree.SelectedNode.Path;
        object[] objArray2 = new object[2];
        objArray2[0] = "%1";
        Settings objSettings = Declarations.objSettings;
        objArray2[1] = objSettings.CurrentPath;
        object[] args = objArray2;
        bool[] copyBack = new bool[] { false, true };
        if (copyBack[1])
        {
          objSettings.CurrentPath = StringType.FromObject(args[1]);
        }
        this.DotNetBarManager.GetItem("lblPath").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", args, null, copyBack));
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

    private void FolderTree_AfterLabelEdit(object sender, FolderViewNodeLabelEditEventArgs e)
    {
      string label = e.Label;
      this.vstrFolderRenameOldPath = e.Node.Path;
      this.vstrFolderRenameNewPath = this.vstrFolderRenameOldPath.Substring(0, this.vstrFolderRenameOldPath.LastIndexOf(@"\")) + @"\" + label;
      if (!Directory.Exists(this.vstrFolderRenameNewPath))
      {
        this.FolderRenameTimer.Start();
      }
      else
      {
        this.vstrFolderRenameOldPath = "";
        this.vstrFolderRenameNewPath = "";
        this.vbooFolderRename = false;
      }
    }

    private void FolderTree_AfterSelect(object sender, FolderViewEventArgs e)
    {
      ButtonItem item2 = null;
      if (this.vbooClosing | this.vbooStartUp)
      {
        return;
      }
      Declarations.objSettings.CurrentPath = this.FolderTree.SelectedNode.Path;
      this.vstrFilter = "*";
      switch (this.vbytFilterIndex)
      {
        case 0:
          item2 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"];
          break;

        case 1:
          item2 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"];
          break;

        case 2:
          item2 = (ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"];
          break;

        case 0xff:
          goto Label_010B;
      }
      item2.Checked = false;
      foreach (ButtonItem item3 in item2.SubItems)
      {
        item3.Checked = false;
      }
      this.vbytFilterIndex = 0xff;
      Label_010B:
      this.GetFiles(null, true, true);
      int num = 0;
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        num = IntegerType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(item.Tag, null, "Duration", new object[0], null, null)));
      }
      int num3 = num / 0xe10;
      num3 = (num - ((num / 0xe10) * 0xe10)) / 60;
      string introduced16 = num3.ToString().PadLeft(2, '0') + ":";
      num3 = (num - ((num / 0xe10) * 0xe10)) - (((num - ((num / 0xe10) * 0xe10)) / 60) * 60);
      string introduced17 = introduced16 + num3.ToString().PadLeft(2, '0') + ":";
      string str = introduced17 + num3.ToString().PadLeft(2, '0');
      object[] args = new object[] { "%3", str };
      bool[] copyBack = new bool[] { false, true };
      if (copyBack[1])
      {
        str = StringType.FromObject(args[1]);
      }
      this.DotNetBarManager.GetItem("lblNumber").Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["Number"], null, "Replace", new object[] { "%1", this.MP3View.Items.Count.ToString() }, null, null), null, "Replace", new object[] { "%2", this.MP3View.SelectedItems.Count.ToString() }, null, null), null, "Replace", args, null, copyBack));
      args = new object[2];
      args[0] = "%1";
      Settings objSettings = Declarations.objSettings;
      args[1] = objSettings.CurrentPath;
      object[] objArray2 = args;
      copyBack = new bool[] { false, true };
      if (copyBack[1])
      {
        objSettings.CurrentPath = StringType.FromObject(objArray2[1]);
      }
      this.DotNetBarManager.GetItem("lblPath").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", objArray2, null, copyBack));
      try
      {
        this.DotNetBarManager.GetItem("lblLength").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", this.MP3View.FocusedItem.Text.Length.ToString() }, null, null));
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        this.DotNetBarManager.GetItem("lblLength").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", "0" }, null, null));
        ProjectData.ClearProjectError();
      }
      try
      {
        Declarations.UNDOList.Clear();
        Declarations.REDOList.Clear();
        this.mnubtnUndo.Enabled = false;
        this.mnubtnRedo.Enabled = false;
      }
      catch (Exception exception2)
      {
        ProjectData.SetProjectError(exception2);
        ProjectData.ClearProjectError();
      }
    }

    private void FolderTree_BeforeLabelEdit(object sender, FolderViewNodeLabelEditEventArgs e)
    {
      this.vbooFolderRename = true;
    }

    private void FolderTree_BeforeSelect(object sender, FolderViewCancelEventArgs e)
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
        this.CalcAudioCheckSumThread.Abort();
        this.CalcAudioCheckSumThread.Join();
      }
      catch (Exception exception6)
      {
        ProjectData.SetProjectError(exception6);
        Exception exception3 = exception6;
        ProjectData.ClearProjectError();
      }
      try
      {
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
        this.DotNetBarManager.SaveLayout(Path.Combine(Declarations.vstrUserAppData, "Interface.xml"));
        this.NavigationPan.SaveLayout(Path.Combine(Declarations.vstrUserAppData, "Navpanel.xml"));
        this.DotNetBarManager.Bars["Toolbar"].SaveDefinition(Path.Combine(Declarations.vstrUserAppData, "Toolbar.xml"));
        this.DotNetBarManager.Bars["ExtToolbar"].SaveDefinition(Path.Combine(Declarations.vstrUserAppData, "ExtToolbar.xml"));
        this.BarGroupTools.SubItems.Clear();
        this.SideBar.SaveDefinition(Path.Combine(Declarations.vstrUserAppData, "Sidebar.xml"));
      }
      catch (Exception exception8)
      {
        ProjectData.SetProjectError(exception8);
        ProjectData.ClearProjectError();
      }
      Declarations.objSettings.NavPanWidth = this.NavigationPan.Width;
      Declarations.objSettings.SideBarWidth = this.SideBar.Width;
      Declarations.objSettings.ErrorHeight = this.ErrorMsg.Height;
      Declarations.objSettings.NavPanExpanded = this.SplitterLeft.Expanded;
      Declarations.objSettings.SideBarExpanded = this.SplitterRight.Expanded;
      Declarations.objSettings.ErrorExpanded = this.SplitterBottom.Expanded;
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
        {
          Registry.ClassesRoot.OpenSubKey(@"Folder\Shell", true).DeleteSubKeyTree("ID3-TagIT");
        }
        RegistryKey key3 = Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT", true);
        if (Declarations.objSettings.ExplorerContext)
        {
          if (key3 != null)
          {
            Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).DeleteSubKeyTree("ID3-TagIT");
          }
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).CreateSubKey("ID3-TagIT");
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT", true).CreateSubKey("command");
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell\ID3-TagIT\command", true).SetValue(null, "\"" + executablePath + "\"" + " " + "\"" + "/P=%1" + "\"");
        }
        if (!Declarations.objSettings.ExplorerContext & (key3 != null))
        {
          Registry.ClassesRoot.OpenSubKey(@"Directory\Shell", true).DeleteSubKeyTree("ID3-TagIT");
        }
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
      try
      {
        if (File.Exists(Path.Combine(Declarations.vstrUserAppData, "Toolbar.xml")))
        {
          this.DotNetBarManager.Bars["Toolbar"].LoadDefinition(Path.Combine(Declarations.vstrUserAppData, "Toolbar.xml"));
        }
      }
      catch (Exception exception2)
      {
        ProjectData.SetProjectError(exception2);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (File.Exists(Path.Combine(Declarations.vstrUserAppData, "ExtToolbar.xml")))
        {
          this.DotNetBarManager.Bars["ExtToolbar"].LoadDefinition(Path.Combine(Declarations.vstrUserAppData, "ExtToolbar.xml"));
        }
      }
      catch (Exception exception3)
      {
        ProjectData.SetProjectError(exception3);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (File.Exists(Path.Combine(Declarations.vstrUserAppData, "Navpanel.xml")))
        {
          this.NavigationPan.LoadLayout(Path.Combine(Declarations.vstrUserAppData, "Navpanel.xml"));
        }
      }
      catch (Exception exception4)
      {
        ProjectData.SetProjectError(exception4);
        ProjectData.ClearProjectError();
      }
      try
      {
        if (File.Exists(Path.Combine(Declarations.vstrUserAppData, "Interface.xml")))
        {
          this.DotNetBarManager.LoadLayout(Path.Combine(Declarations.vstrUserAppData, "Interface.xml"));
        }
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
          this.SideBar.LoadDefinition(Path.Combine(Declarations.vstrUserAppData, "Sidebar.xml"));
          this.BarGroupEdit = (ExplorerBarGroupItem)this.SideBar.Groups[0];
          this.BarGroupPicture = (ExplorerBarGroupItem)this.SideBar.Groups[1];
          this.BarGroupInfo = (ExplorerBarGroupItem)this.SideBar.Groups[2];
          this.BarGroupTools = (ExplorerBarGroupItem)this.SideBar.Groups[3];
        }
      }
      catch (Exception exception6)
      {
        ProjectData.SetProjectError(exception6);
        ProjectData.ClearProjectError();
      }
      this.mnubtnUndo = (ButtonItem)this.DotNetBarManager.GetItem("mnubtnUndo");
      this.mnubtnRedo = (ButtonItem)this.DotNetBarManager.GetItem("mnubtnRedo");
      this.mnubtnEnumMinus = (ButtonItem)this.DotNetBarManager.GetItem("mnubtnEnumMinus");
      this.mnubtnEnumPlus = (ButtonItem)this.DotNetBarManager.GetItem("mnubtnEnumPlus");
      this.mnubtnEnumCounter = (ButtonItem)this.DotNetBarManager.GetItem("mnubtnEnumCounter");
      this.mnubtnEnumCounter.Text = StringType.FromInteger(Declarations.objSettings.FilenumberStart);
      this.mnubtnViewVer1 = (ButtonItem)this.DotNetBarManager.GetItem("mnubtnViewVer1");
      this.mnubtnViewVer2 = (ButtonItem)this.DotNetBarManager.GetItem("mnubtnViewVer2");
      ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterArtist"]).Text = StringType.FromObject(Declarations.objResources.ResStrings["Col05"]);
      ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterTitle"]).Text = StringType.FromObject(Declarations.objResources.ResStrings["Col06"]);
      ((ButtonItem)this.DotNetBarManager.Items["mnubtnFilterAlbum"]).Text = StringType.FromObject(Declarations.objResources.ResStrings["Col07"]);
      this.mnubtnUndo.Enabled = false;
      this.mnubtnRedo.Enabled = false;
      ((ButtonItem)this.DotNetBarManager.GetItem("mnubtnEnumFilename")).Checked = Declarations.objSettings.EnumFile;
      ((ButtonItem)this.DotNetBarManager.GetItem("mnubtnEnumV1")).Checked = Declarations.objSettings.EnumVer1;
      ((ButtonItem)this.DotNetBarManager.GetItem("mnubtnEnumV2")).Checked = Declarations.objSettings.EnumVer2;
      ((ButtonItem)this.DotNetBarManager.GetItem("mnubtnScanSubDirs")).Checked = Declarations.objSettings.ScanSubDirs;
      ((ButtonItem)this.DotNetBarManager.GetItem("mnubtnQuickFilename")).Checked = Declarations.objSettings.QuickFilenameEditing;
      ((ButtonItem)this.DotNetBarManager.GetItem("mnubtnSynchronize")).Checked = Declarations.objSettings.SynchronizeTAGs;
      this.mnubtnViewVer1.Checked = BooleanType.FromObject(Interaction.IIf(Declarations.objSettings.VersionToShow == 1, true, false));
      this.mnubtnViewVer2.Checked = BooleanType.FromObject(Interaction.IIf(Declarations.objSettings.VersionToShow == 2, true, false));
      this.DotNetBarManager.GetItem("btnV1V2View").Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
      this.DotNetBarManager.GetItem("lblVersion").Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
      if (Declarations.objSettings.ScanSubDirs)
      {
        this.DotNetBarManager.GetItem("lblSubDirs").Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsYes"]);
      }
      else
      {
        this.DotNetBarManager.GetItem("lblSubDirs").Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsNo"]);
      }
      if (Declarations.objSettings.UseThemes)
      {
        foreach (Bar bar in this.DotNetBarManager.Bars)
        {
          bar.ThemeAware = true;
          bar.Refresh();
        }
      }
      else
      {
        foreach (Bar bar in this.DotNetBarManager.Bars)
        {
          bar.ThemeAware = false;
          bar.Refresh();
        }
      }
      this.NavigationPan.Width = Declarations.objSettings.NavPanWidth;
      this.SideBar.Width = Declarations.objSettings.SideBarWidth;
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
        try
        {
          if (BooleanType.FromObject(row["DefaultPlayer"]))
          {
            if (StringType.StrCmp(sLeft, "", false) != 0)
            {
              this.ToolsIcons.Images.Add(Id3TagIT_Main.GetAppIcon(sLeft, true));
            }
            ButtonItem item2 = new ButtonItem("ToolItem" + num.ToString(), row["ToolDescription"].ToString())
            {
              ImageIndex = num,
              Tag = num,
              ButtonStyle = eButtonStyle.ImageAndText
            };
            this.BarGroupTools.SubItems.Add(item2);
          }
          else
          {
            this.ToolsIcons.Images.Add(Id3TagIT_Main.GetAppIcon(StringType.FromObject(row["ToolPath"]), true));
            ButtonItem item3 = new ButtonItem("ToolItem" + num.ToString(), row["ToolDescription"].ToString())
            {
              ImageIndex = num,
              Tag = num,
              ButtonStyle = eButtonStyle.ImageAndText
            };
            this.BarGroupTools.SubItems.Add(item3);
          }
        }
        catch (Exception exception8)
        {
          ProjectData.SetProjectError(exception8);
          ButtonItem item4 = new ButtonItem("ToolItem" + num.ToString(), row["ToolDescription"].ToString())
          {
            Tag = num,
            ButtonStyle = eButtonStyle.Default
          };
          this.BarGroupTools.SubItems.Add(item4);
          ProjectData.ClearProjectError();
        }
      }
      this.FavTree.BeginUpdate();
      foreach (TreeNode node in Declarations.objSettings.FavNodes)
      {
        LateBinding.LateCall(this.FavTree.Nodes, null, "Add", new object[] { RuntimeHelpers.GetObjectValue(node.Clone()) }, null, null);
      }
      this.FavTree.EndUpdate();
      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
      {
        this.cmbArtist.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
      this.colHErrFile.Text = StringType.FromObject(Declarations.objResources.ResStrings["CHError1"]);
      this.colHErrFile.Width = 200;
      this.colHErrMsg.Text = StringType.FromObject(Declarations.objResources.ResStrings["CHError2"]);
      this.colHErrMsg.Width = 200;
      this.ErrorMsg.Columns.AddRange(new ColumnHeader[] { this.colHErrFile, this.colHErrMsg });
      splash.lblState.Text = "Adding Columns";
      Application.DoEvents();
      this.MP3View_AddColumns();
      this.lblArtist.Text = this.colHArtist.Text;
      this.lblTitle.Text = this.colHTitle.Text;
      this.lblAlbum.Text = this.colHAlbum.Text;
      splash.lblState.Text = "Localizing Menus";
      ((ComboBoxItem)this.DotNetBarManager.GetItem("mnucmbLanguage")).SelectedIndex = Declarations.objSettings.Language;
      this.SetLanguage();
      splash.lblState.Text = "Restoring folder";
      Application.DoEvents();
      this.FolderTree.SelectNode(Declarations.objSettings.CurrentPath, null, true);
      Application.DoEvents();
      splash.Close();
      Application.DoEvents();
      form = this;
      Id3TagIT_Main.WindowsXPCheck(ref form);
      this.MP3View.Focus();
      Application.DoEvents();
      this.Visible = true;
      this.GetFiles(null, true, true);
      this.Timer.Tick += new EventHandler(this.TimerEventProcessor);
      this.FolderRenameTimer.Tick += new EventHandler(this.FolderRenameEventProcessor);
      int num2 = 0;
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        num2 = IntegerType.FromObject(ObjectType.AddObj(num2, LateBinding.LateGet(item.Tag, null, "Duration", new object[0], null, null)));
      }
      int num4 = num2 / 0xe10;
      num4 = (num2 - ((num2 / 0xe10) * 0xe10)) / 60;
      string introduced45 = num4.ToString().PadLeft(2, '0') + ":";
      num4 = (num2 - ((num2 / 0xe10) * 0xe10)) - (((num2 - ((num2 / 0xe10) * 0xe10)) / 60) * 60);
      string introduced46 = introduced45 + num4.ToString().PadLeft(2, '0') + ":";
      string str3 = introduced46 + num4.ToString().PadLeft(2, '0');
      object[] args = new object[] { "%3", str3 };
      bool[] copyBack = new bool[] { false, true };
      if (copyBack[1])
      {
        str3 = StringType.FromObject(args[1]);
      }
      this.DotNetBarManager.GetItem("lblNumber").Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["Number"], null, "Replace", new object[] { "%1", this.MP3View.Items.Count.ToString() }, null, null), null, "Replace", new object[] { "%2", this.MP3View.SelectedItems.Count.ToString() }, null, null), null, "Replace", args, null, copyBack));
      args = new object[2];
      args[0] = "%1";
      Settings objSettings = Declarations.objSettings;
      args[1] = objSettings.CurrentPath;
      object[] objArray2 = args;
      copyBack = new bool[] { false, true };
      if (copyBack[1])
      {
        objSettings.CurrentPath = StringType.FromObject(objArray2[1]);
      }
      this.DotNetBarManager.GetItem("lblPath").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", objArray2, null, copyBack));
      try
      {
        this.DotNetBarManager.GetItem("lblLength").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", this.MP3View.FocusedItem.Text.Length.ToString() }, null, null));
      }
      catch (Exception exception9)
      {
        ProjectData.SetProjectError(exception9);
        this.DotNetBarManager.GetItem("lblLength").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", "0" }, null, null));
        ProjectData.ClearProjectError();
      }
      this.colHErrFile.Width = (int)Math.Round((double)(this.ErrorMsg.Width * 0.4));
      this.colHErrMsg.Width = (int)Math.Round((double)(this.ErrorMsg.Width * 0.55));
      this.SplitterLeft.Expanded = Declarations.objSettings.NavPanExpanded;
      this.SplitterRight.Expanded = Declarations.objSettings.SideBarExpanded;
      this.SplitterBottom.Expanded = Declarations.objSettings.ErrorExpanded;
      this.NavigationPan.RecalcLayout();
      this.NavigationPan.ResetText();
      this.vbooStartUp = false;
    }

    private void GetFiles([Optional, DefaultParameterValue(null)] ArrayList alstFolders, [Optional, DefaultParameterValue(true)] bool vbooClear, [Optional, DefaultParameterValue(true)] bool vbooFill)
    {
      ArrayList list = new ArrayList();
      try
      {
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
        this.CalcAudioCheckSumThread.Abort();
        this.CalcAudioCheckSumThread.Join();
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
      {
        this.MP3View_FillColumns(ref Declarations.MP3s);
      }
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
        {
          return;
        }
        frmProg.Infos.Text = vstrFullFilename;
        MP3 mp = new MP3(vstrFullFilename);
        if (mp.ExploreMP3())
        {
          Declarations.MP3s.Add(mp);
        }
        if (vintHelpCount != this.vintHelpCount)
        {
          vintHelpCount = this.vintHelpCount;
          try
          {
            if (Declarations.MP3s.Count > 0)
            {
              num3 = (count - Declarations.MP3s.Count) / (Declarations.MP3s.Count / vintHelpCount);
            }
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            Exception exception = exception1;
            ProjectData.ClearProjectError();
          }
          int num6 = num3 / 0xe10;
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
            {
              this.GetFiles(null, true, true);
            }
          }
          else
          {
            this.GetFiles(null, true, true);
          }
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
        {
          this.colHFilename.Width = IntegerType.FromObject(dataRo["Width"]);
        }
        else if (ObjectType.ObjTst(obj3, 2, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHSubDir, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 3, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHTAGVer1, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 4, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHTAGVer2, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 5, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHArtist, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 6, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHTitle, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 7, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHAlbum, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 8, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHTrack, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 9, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHPosMedia, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 10, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHComment, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 11, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHGenre, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 12, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHYear, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 13, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHRating, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 14, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHDuration, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 15, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHBitrate, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x10, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHVBR, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x11, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHSamplerate, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x12, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHChannel, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x13, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHVersion, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 20, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHDate, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x15, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHComposer, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x16, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHFileSize, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x17, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHBPM, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x18, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHPicCount, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x19, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHAudioCheckSum, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
        else if (ObjectType.ObjTst(obj3, 0x1a, false) == 0)
        {
          this.MP3View_BuildColumns(ref this.colHCreateDate, dataRo, StringType.FromObject(Declarations.objResources.ResStrings["Col" + dataRo["ID"].ToString().PadLeft(2, '0')]));
        }
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
          {
            sortOrder[num] = 0;
          }
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
              {
                mp4.CurrentFullName = StringType.FromObject(args[1]);
              }
              object[] objArray3 = new object[2];
              objArray3[0] = "%2";
              MP3 mp3 = tag;
              objArray3[1] = mp3.CurrentFullName;
              object[] objArray2 = objArray3;
              bool[] flagArray = new bool[] { false, true };
              if (flagArray[1])
              {
                mp3.CurrentFullName = StringType.FromObject(objArray2[1]);
              }
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
      {
        Column.TextAlign = HorizontalAlignment.Left;
      }
      else if (ObjectType.ObjTst(obj2, "Right", false) == 0)
      {
        Column.TextAlign = HorizontalAlignment.Right;
      }
      else if (ObjectType.ObjTst(obj2, "Center", false) == 0)
      {
        Column.TextAlign = HorizontalAlignment.Center;
      }
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
      {
        lvcolumn.fmt = 1;
      }
      else
      {
        lvcolumn.fmt = 0;
      }
      lvcolumn.iImage = 0;
      lvcolumn.cchTextMax = 0;
      lvcolumn.cx = 0;
      lvcolumn.iOrder = 0;
      lvcolumn.iSubItem = 0;
      lvcolumn.pszText = IntPtr.Zero;
      ptr2 = Declarations.SendMessage(this.MP3View.Handle, 0x101a, this.SortedColumn, ref lvcolumn);
      lvcolumn.mask = 0x11;
      if ((((((((((StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHTrack.Text, false) == 0) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHPosMedia.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHBPM.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHYear.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHRating.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHBitrate.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHPicCount.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHAudioCheckSum.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHFileSize.Text, false) == 0)) | (StringType.StrCmp(this.MP3View.Columns[e.Column].Text, this.colHSamplerate.Text, false) == 0))
      {
        lvcolumn.fmt = 0x1801;
      }
      else
      {
        lvcolumn.fmt = 0x1800;
      }
      if (this.LastSortedColumn == e.Column)
      {
        lvcolumn.iImage = 0;
      }
      else
      {
        lvcolumn.iImage = 1;
      }
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
      {
        class2.SortMethod = SortClass.SorterMethod.Numeric;
      }
      else if ((StringType.StrCmp(text, this.colHDate.Text, false) == 0) || (StringType.StrCmp(text, this.colHCreateDate.Text, false) == 0))
      {
        class2.SortMethod = SortClass.SorterMethod.Dat;
      }
      else
      {
        class2.SortMethod = SortClass.SorterMethod.Text;
      }
      if (this.LastSortedColumn == e.Column)
      {
        class2.AltSort = true;
        this.LastSortedColumn = -1;
      }
      else
      {
        this.LastSortedColumn = e.Column;
      }
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
      {
        this.LastSortedColumn = this.SortedColumn;
      }
      else
      {
        this.LastSortedColumn = -1;
      }
      this.MP3View.ListViewItemSorter = null;
      Form ownerForm = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.MP3View_FillColumnsCB);
      frmProgress progress = new frmProgress(0, Declarations.MP3s.Count, IntegerType.FromObject(Interaction.IIf(Declarations.MP3s.Count < 0x3e8, Declarations.MP3s.Count / 10, 100)), ref ownerForm, ref cB)
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
      this.cmbArtist.Text = "";
      this.txtTitle.Text = "";
      this.txtAlbum.Text = "";
      this.APICView.Image = null;
      this.txtInfo.Text = "";
      this.txtInfo.Text = this.colHDuration.Text + ":\r\n";
      this.txtInfo.AppendText(this.colHFileSize.Text + ":\r\n");
      this.txtInfo.AppendText(this.colHBitrate.Text + ":\r\n");
      this.txtInfo.AppendText(this.colHVBR.Text + ":\r\n");
      this.txtInfo.AppendText(this.colHSamplerate.Text + ":\r\n");
      this.txtInfo.AppendText(this.colHChannel.Text + ":\r\n");
      this.txtInfo.AppendText(this.colHVersion.Text + ":");
      this.AudioCheckSumCalculation();
    }

    public void MP3View_FillColumnsCB(ref frmProgress frmProg)
    {
      ArrayList list = frmProg.List;
      int num3 = IntegerType.FromObject(Interaction.IIf(Declarations.MP3s.Count < 0x3e8, Declarations.MP3s.Count / 10, 100));
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
        {
          flag = true;
        }
        else if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null), null, "ToUpper", new object[0], null, null), this.vstrFilter, false) == 0)
        {
          flag = true;
        }
        goto Label_11ED;
        Label_051D:
        if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
        {
          flag = true;
        }
        goto Label_11ED;
        Label_053C:
        if (StringType.StrCmp(mp.V1TAG.Artist, "", false) != 0)
        {
          if (StringType.StrCmp(mp.V1TAG.Artist, "", false) != 0)
          {
            if (Information.IsNumeric(mp.V1TAG.Artist.Substring(0, 1)) & (StringType.StrCmp(this.vstrFilter, "#", false) == 0))
            {
              flag = true;
            }
            else if ((((Strings.Asc(mp.V1TAG.Artist.Substring(0, 1).ToUpper()) < 0x41) | (Strings.Asc(mp.V1TAG.Artist.Substring(0, 1).ToUpper()) > 90)) & (StringType.StrCmp(this.vstrFilter, "@", false) == 0)) & !Information.IsNumeric(mp.V1TAG.Artist.Substring(0, 1)))
            {
              flag = true;
            }
            else if (StringType.StrCmp(mp.V1TAG.Artist.Substring(0, 1).ToUpper(), this.vstrFilter, false) == 0)
            {
              flag = true;
            }
          }
        }
        else if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
        {
          flag = true;
        }
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
        {
          flag = true;
        }
        else if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null), null, "ToUpper", new object[0], null, null), this.vstrFilter, false) == 0)
        {
          flag = true;
        }
        goto Label_11ED;
        Label_0ADF:
        if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
        {
          flag = true;
        }
        goto Label_11ED;
        Label_0AFE:
        if (StringType.StrCmp(mp.V1TAG.Title, "", false) != 0)
        {
          if (StringType.StrCmp(mp.V1TAG.Title, "", false) != 0)
          {
            if (Information.IsNumeric(mp.V1TAG.Title.Substring(0, 1)) & (StringType.StrCmp(this.vstrFilter, "#", false) == 0))
            {
              flag = true;
            }
            else if ((((Strings.Asc(mp.V1TAG.Title.Substring(0, 1).ToUpper()) < 0x41) | (Strings.Asc(mp.V1TAG.Title.Substring(0, 1).ToUpper()) > 90)) & (StringType.StrCmp(this.vstrFilter, "@", false) == 0)) & !Information.IsNumeric(mp.V1TAG.Title.Substring(0, 1)))
            {
              flag = true;
            }
            else if (StringType.StrCmp(mp.V1TAG.Title.Substring(0, 1).ToUpper(), this.vstrFilter, false) == 0)
            {
              flag = true;
            }
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
        {
          flag = true;
        }
        else if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(mp.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "Substring", new object[] { 0, 1 }, null, null), null, "ToUpper", new object[0], null, null), this.vstrFilter, false) == 0)
        {
          flag = true;
        }
        goto Label_11ED;
        Label_10A1:
        if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
        {
          flag = true;
        }
        goto Label_11ED;
        Label_10C0:
        if (StringType.StrCmp(mp.V1TAG.Album, "", false) != 0)
        {
          if (StringType.StrCmp(mp.V1TAG.Album, "", false) != 0)
          {
            if (Information.IsNumeric(mp.V1TAG.Album.Substring(0, 1)) & (StringType.StrCmp(this.vstrFilter, "#", false) == 0))
            {
              flag = true;
            }
            else if ((((Strings.Asc(mp.V1TAG.Album.Substring(0, 1).ToUpper()) < 0x41) | (Strings.Asc(mp.V1TAG.Album.Substring(0, 1).ToUpper()) > 90)) & (StringType.StrCmp(this.vstrFilter, "@", false) == 0)) & !Information.IsNumeric(mp.V1TAG.Album.Substring(0, 1)))
            {
              flag = true;
            }
            else if (StringType.StrCmp(mp.V1TAG.Album.Substring(0, 1).ToUpper(), this.vstrFilter, false) == 0)
            {
              flag = true;
            }
          }
        }
        else if (StringType.StrCmp(this.vstrFilter, "\"", false) == 0)
        {
          flag = true;
        }
        goto Label_11ED;
        Label_11EA:
        flag = true;
        Label_11ED:
        if (!flag)
        {
          goto Label_23AA;
        }
        ListViewItem item = new ListViewItem(mp.CurrentName);
        if (mp.Selected)
        {
          item.Selected = true;
          mp.Selected = false;
        }
        int num7 = this.MP3View.Columns.Count - 1;
        for (int i = 1; i <= num7; i++)
        {
          item.SubItems.Add("");
        }
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
        {
          item.SubItems[this.colHSubDir.Index].Text = StringType.FromObject(Interaction.IIf(Declarations.objSettings.CurrentPath.EndsWith(":"), mp.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath + @"\", ""), mp.FI.DirectoryName.Replace(Declarations.objSettings.CurrentPath, "")));
        }
        if (!((mp.Bitrate > 0x61a80) | (mp.Bitrate == 0)))
        {
          if (this.MP3View.Columns.Contains(this.colHChannel))
          {
            item.SubItems[this.colHChannel.Index].Text = mp.ChannelText;
          }
          if (this.MP3View.Columns.Contains(this.colHBitrate))
          {
            item.SubItems[this.colHBitrate.Index].Text = StringType.FromInteger(mp.Bitrate / 0x3e8);
          }
          if (this.MP3View.Columns.Contains(this.colHVBR))
          {
            item.SubItems[this.colHVBR.Index].Text = StringType.FromObject(Interaction.IIf(mp.VBR, "VBR", "CBR"));
          }
          if (this.MP3View.Columns.Contains(this.colHSamplerate))
          {
            item.SubItems[this.colHSamplerate.Index].Text = StringType.FromInteger(mp.Samplerate);
          }
          if (this.MP3View.Columns.Contains(this.colHVersion))
          {
            item.SubItems[this.colHVersion.Index].Text = mp.VersionText + " " + mp.LayerText;
          }
          if (this.MP3View.Columns.Contains(this.colHDuration))
          {
            item.SubItems[this.colHDuration.Index].Text = mp.DurationFormated;
          }
        }
        else
        {
          if (this.MP3View.Columns.Contains(this.colHChannel))
          {
            item.SubItems[this.colHChannel.Index].Text = "";
          }
          if (this.MP3View.Columns.Contains(this.colHBitrate))
          {
            item.SubItems[this.colHBitrate.Index].Text = "";
          }
          if (this.MP3View.Columns.Contains(this.colHVBR))
          {
            item.SubItems[this.colHVBR.Index].Text = "";
          }
          if (this.MP3View.Columns.Contains(this.colHSamplerate))
          {
            item.SubItems[this.colHSamplerate.Index].Text = "";
          }
          if (this.MP3View.Columns.Contains(this.colHVersion))
          {
            item.SubItems[this.colHVersion.Index].Text = "";
          }
          if (this.MP3View.Columns.Contains(this.colHDuration))
          {
            item.SubItems[this.colHDuration.Index].Text = "";
          }
        }
        if (this.MP3View.Columns.Contains(this.colHTAGVer1))
        {
          item.SubItems[this.colHTAGVer1.Index].Text = mp.V1TAG.TAGVersion.ToString().Replace("0", "-").Replace("1-", "1.0").Replace("11", "1.1");
        }
        if (this.MP3View.Columns.Contains(this.colHTAGVer2))
        {
          item.SubItems[this.colHTAGVer2.Index].Text = mp.V2TAG.TAGVersion.ToString().Replace("2", "2.2").Replace("3", "2.3").Replace("4", "2.4").Replace("0", "-");
        }
        if (this.MP3View.Columns.Contains(this.colHDate))
        {
          item.SubItems[this.colHDate.Index].Text = mp.FI.LastWriteTime.ToString();
        }
        if (this.MP3View.Columns.Contains(this.colHCreateDate))
        {
          item.SubItems[this.colHCreateDate.Index].Text = mp.FI.CreationTime.ToString();
        }
        if (this.MP3View.Columns.Contains(this.colHFileSize))
        {
          item.SubItems[this.colHFileSize.Index].Text = (mp.FI.Length / 0x400L).ToString();
        }
        if (this.MP3View.Columns.Contains(this.colHAudioCheckSum))
        {
          item.SubItems[this.colHAudioCheckSum.Index].Text = StringType.FromObject(Interaction.IIf(mp.AudioCheckSum != 0, mp.AudioCheckSum.ToString(), ""));
        }
        if (!mp.V2TAG.TAGHeaderPresent || (this.vbytVersionToShow != 2))
        {
          goto Label_216E;
        }
        if (this.MP3View.Columns.Contains(this.colHArtist))
        {
          if (mp.V2TAG.FrameExists("TPE1"))
          {
            item.SubItems[this.colHArtist.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
          }
          else
          {
            item.SubItems[this.colHArtist.Index].Text = "";
          }
        }
        if (this.MP3View.Columns.Contains(this.colHTitle))
        {
          if (mp.V2TAG.FrameExists("TIT2"))
          {
            item.SubItems[this.colHTitle.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
          }
          else
          {
            item.SubItems[this.colHTitle.Index].Text = "";
          }
        }
        if (this.MP3View.Columns.Contains(this.colHAlbum))
        {
          if (mp.V2TAG.FrameExists("TALB"))
          {
            item.SubItems[this.colHAlbum.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
          }
          else
          {
            item.SubItems[this.colHAlbum.Index].Text = "";
          }
        }
        if (this.MP3View.Columns.Contains(this.colHTrack))
        {
          if (mp.V2TAG.FrameExists("TRCK"))
          {
            item.SubItems[this.colHTrack.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null));
          }
          else
          {
            item.SubItems[this.colHTrack.Index].Text = "";
          }
        }
        if (this.MP3View.Columns.Contains(this.colHGenre))
        {
          if (mp.V2TAG.FrameExists("TCON"))
          {
            item.SubItems[this.colHGenre.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null));
          }
          else
          {
            item.SubItems[this.colHGenre.Index].Text = "";
          }
        }
        if (this.MP3View.Columns.Contains(this.colHYear))
        {
          if (mp.V2TAG.FrameExists("TYER"))
          {
            item.SubItems[this.colHYear.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TYER"), null, "Content", new object[0], null, null));
          }
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
          {
            item.SubItems[this.colHYear.Index].Text = "";
          }
        }
        if (this.MP3View.Columns.Contains(this.colHPosMedia))
        {
          if (mp.V2TAG.FrameExists("TPOS"))
          {
            item.SubItems[this.colHPosMedia.Index].Text = StringType.FromObject(LateBinding.LateGet(mp.V2TAG.GetFrame("TPOS"), null, "Content", new object[0], null, null));
          }
          else
          {
            item.SubItems[this.colHPosMedia.Index].Text = "";
          }
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
                {
                  item.SubItems[this.colHBPM.Index].Text = "";
                }
                else
                {
                  item.SubItems[this.colHBPM.Index].Text = ((int)Math.Round(Conversion.Fix(Conversion.Val(mp.V2TAG.GetTextWebFrameContent("TBPM").Trim(new char[] { ' ' }))))).ToString();
                }
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
            {
              item.SubItems[this.colHBPM.Index].Text = "";
            }
          }
          else
          {
            item.SubItems[this.colHBPM.Index].Text = "";
          }
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
          {
            item.SubItems[this.colHArtist.Index].Text = mp.V1TAG.Artist;
          }
          if (this.MP3View.Columns.Contains(this.colHTitle))
          {
            item.SubItems[this.colHTitle.Index].Text = mp.V1TAG.Title;
          }
          if (this.MP3View.Columns.Contains(this.colHAlbum))
          {
            item.SubItems[this.colHAlbum.Index].Text = mp.V1TAG.Album;
          }
          if (this.MP3View.Columns.Contains(this.colHTrack))
          {
            item.SubItems[this.colHTrack.Index].Text = StringType.FromObject(Interaction.IIf(mp.V1TAG.Tracknumber > 0, mp.V1TAG.Tracknumber.ToString(), ""));
          }
          if (this.MP3View.Columns.Contains(this.colHYear))
          {
            item.SubItems[this.colHYear.Index].Text = StringType.FromObject(Interaction.IIf(mp.V1TAG.Year > 0, mp.V1TAG.Year.ToString(), ""));
          }
          if (this.MP3View.Columns.Contains(this.colHGenre))
          {
            item.SubItems[this.colHGenre.Index].Text = mp.V1TAG.GenreText;
          }
          if (this.MP3View.Columns.Contains(this.colHComment))
          {
            item.SubItems[this.colHComment.Index].Text = mp.V1TAG.Comment;
          }
        }
        item.Tag = mp;
        this.MP3View.Items.Add(item);
        Label_23AA:
        if ((num3 > 0) && ((num2 % num3) == 0))
        {
          frmProg.ProgressBar.PerformStep();
        }
        if (num2 == list.Count)
        {
          frmProg.ProgressBar.Value = frmProg.ProgressBar.Maximum;
        }
      }
    }

    private void MP3View_ItemDrag(object sender, ItemDragEventArgs e)
    {
      string[] data = new string[(this.MP3View.SelectedItems.Count - 1) + 1];
      int num2 = this.MP3View.SelectedItems.Count - 1;
      for (int i = 0; i <= num2; i++)
      {
        data[i] = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(this.MP3View.SelectedItems[i].Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null));
      }
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
      {
        this.EnumInfo.Visible = true;
      }
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
        ButtonItem item = (ButtonItem)this.DotNetBarManager.ContextMenus["MP3ViewMenu"];
        item.Displayed = false;
        item.PopupMenu(Control.MousePosition);
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

    private void Multi1CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        MP3 tag = (MP3)item.Tag;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        frmProg.Infos.Text = tag.CurrentFullName;
        if (this.MP3View.SelectedItems.Count == 1)
        {
          if (StringType.StrCmp(tag.V1TAG.Artist, this.cmbArtist.Text.Trim(new char[] { ' ' }), false) != 0)
          {
            tag.V1TAG.Artist = this.cmbArtist.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (StringType.StrCmp(tag.V1TAG.Title, this.txtTitle.Text.Trim(new char[] { ' ' }), false) != 0)
          {
            tag.V1TAG.Title = this.txtTitle.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if (StringType.StrCmp(tag.V1TAG.Album, this.txtAlbum.Text.Trim(new char[] { ' ' }), false) != 0)
          {
            tag.V1TAG.Album = this.txtAlbum.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
        }
        else
        {
          if ((StringType.StrCmp(tag.V1TAG.Artist, this.cmbArtist.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) != 0))
          {
            tag.V1TAG.Artist = this.cmbArtist.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if ((StringType.StrCmp(tag.V1TAG.Title, this.txtTitle.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) != 0))
          {
            tag.V1TAG.Title = this.txtTitle.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
          if ((StringType.StrCmp(tag.V1TAG.Album, this.txtAlbum.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) != 0))
          {
            tag.V1TAG.Album = this.txtAlbum.Text.Trim(new char[] { ' ' });
            tag.V1TAG.TAGPresent = true;
            tag.Changed = true;
          }
        }
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          object obj2;
          if (this.MP3View.SelectedItems.Count == 1)
          {
            obj2 = ID3Functions.CreateTextFrame("TPE1", this.cmbArtist.Text.Trim(new char[] { ' ' }));
            if (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
            {
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            obj2 = ID3Functions.CreateTextFrame("TIT2", this.txtTitle.Text.Trim(new char[] { ' ' }));
            if (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
            {
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            obj2 = ID3Functions.CreateTextFrame("TALB", this.txtAlbum.Text.Trim(new char[] { ' ' }));
            if (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
            {
              LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
            }
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
          else
          {
            if (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) != 0)
            {
              obj2 = ID3Functions.CreateTextFrame("TPE1", this.cmbArtist.Text.Trim(new char[] { ' ' }));
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            }
            if (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) != 0)
            {
              obj2 = ID3Functions.CreateTextFrame("TIT2", this.txtTitle.Text.Trim(new char[] { ' ' }));
              tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
            }
            if (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) != 0)
            {
              obj2 = ID3Functions.CreateTextFrame("TALB", this.txtAlbum.Text.Trim(new char[] { ' ' }));
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
        {
          break;
        }
        MP3 tag = (MP3)item.Tag;
        frmProg.Infos.Text = tag.CurrentFullName;
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo(tag, tag.V1TAG.Clone(), tag.V2TAG.Clone(), tag.CurrentFullName, tag.Changed);
        frmProg.List.Add(@do);
        if (this.MP3View.SelectedItems.Count == 1)
        {
          obj2 = ID3Functions.CreateTextFrame("TPE1", this.cmbArtist.Text.Trim(new char[] { ' ' }));
          if (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) == 0)
          {
            LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          obj2 = ID3Functions.CreateTextFrame("TIT2", this.txtTitle.Text.Trim(new char[] { ' ' }));
          if (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) == 0)
          {
            LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          obj2 = ID3Functions.CreateTextFrame("TALB", this.txtAlbum.Text.Trim(new char[] { ' ' }));
          if (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) == 0)
          {
            LateBinding.LateSet(obj2, null, "Remove", new object[] { true }, null);
          }
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
        }
        else
        {
          if (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) != 0)
          {
            obj2 = ID3Functions.CreateTextFrame("TPE1", this.cmbArtist.Text.Trim(new char[] { ' ' }));
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
          if (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) != 0)
          {
            obj2 = ID3Functions.CreateTextFrame("TIT2", this.txtTitle.Text.Trim(new char[] { ' ' }));
            tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj2));
          }
          if (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) != 0)
          {
            obj2 = ID3Functions.CreateTextFrame("TALB", this.txtAlbum.Text.Trim(new char[] { ' ' }));
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
          this.UpdateListItem(item, false);
        }
        if (Declarations.objSettings.SynchronizeTAGs)
        {
          if (this.MP3View.SelectedItems.Count == 1)
          {
            if (StringType.StrCmp(tag.V1TAG.Artist, this.cmbArtist.Text.Trim(new char[] { ' ' }), false) != 0)
            {
              tag.V1TAG.Artist = this.cmbArtist.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
            if (StringType.StrCmp(tag.V1TAG.Title, this.txtTitle.Text.Trim(new char[] { ' ' }), false) != 0)
            {
              tag.V1TAG.Title = this.txtTitle.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
            if (StringType.StrCmp(tag.V1TAG.Album, this.txtAlbum.Text.Trim(new char[] { ' ' }), false) != 0)
            {
              tag.V1TAG.Album = this.txtAlbum.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
          }
          else
          {
            if ((StringType.StrCmp(tag.V1TAG.Artist, this.cmbArtist.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.cmbArtist.Text.Trim(new char[] { ' ' }), "", false) != 0))
            {
              tag.V1TAG.Artist = this.cmbArtist.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
            if ((StringType.StrCmp(tag.V1TAG.Title, this.txtTitle.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.txtTitle.Text.Trim(new char[] { ' ' }), "", false) != 0))
            {
              tag.V1TAG.Title = this.txtTitle.Text.Trim(new char[] { ' ' });
              tag.V1TAG.TAGPresent = true;
              tag.Changed = true;
            }
            if ((StringType.StrCmp(tag.V1TAG.Album, this.txtAlbum.Text.Trim(new char[] { ' ' }), false) != 0) & (StringType.StrCmp(this.txtAlbum.Text.Trim(new char[] { ' ' }), "", false) != 0))
            {
              tag.V1TAG.Album = this.txtAlbum.Text.Trim(new char[] { ' ' });
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
        {
          break;
        }
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (LateBinding.LateGet(this.alstCopyPaste[0], null, "V1TAG", new object[0], null, null) != null)
        {
          LateBinding.LateSetComplex(item.Tag, null, "V1TAG", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.alstCopyPaste[0], null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null)) }, null, false, true);
        }
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
              {
                frame.Path = tag.FI.FullName;
              }
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
        {
          break;
        }
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (LateBinding.LateGet(this.alstCopyPaste[num], null, "V1TAG", new object[0], null, null) != null)
        {
          LateBinding.LateSetComplex(item.Tag, null, "V1TAG", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.alstCopyPaste[num], null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null)) }, null, false, true);
        }
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
              {
                frame.Path = tag.FI.FullName;
              }
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
        {
          break;
        }
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (LateBinding.LateGet(this.alstCopyPaste[num], null, "V1TAG", new object[0], null, null) != null)
        {
          LateBinding.LateSetComplex(item.Tag, null, "V1TAG", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(this.alstCopyPaste[num], null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null)) }, null, false, true);
        }
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
              {
                frame.Path = tag.FI.FullName;
              }
            }
          }
        }
        LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
        this.UpdateListItem(item, true);
        this.UpdateListItem(item, false);
        if (num == (this.alstCopyPaste.Count - 1))
        {
          break;
        }
        num++;
        frmProg.ProgressBar.PerformStep();
      }
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
          {
            frmProg.ProgressBar.PerformStep();
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

    private void Remove1CB(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        Application.DoEvents();
        if (frmProg.Canceled)
        {
          break;
        }
        frmProg.Infos.Text = StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null));
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (BooleanType.FromObject(LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "TAGPresent", new object[0], null, null)))
        {
          LateBinding.LateCall(item.Tag, null, "RemoveV1TAG", new object[0], null, null);
          LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
          this.UpdateListItem(item, BooleanType.FromObject(Interaction.IIf(Declarations.objSettings.VersionToShow == 1, true, false)));
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            LateBinding.LateCall(item.Tag, null, "RemoveV2TAG", new object[0], null, null);
            LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
            this.UpdateListItem(item, BooleanType.FromObject(Interaction.IIf(Declarations.objSettings.VersionToShow == 2, true, false)));
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
        {
          break;
        }
        frmProg.Infos.Text = StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null));
        Declarations.UnDoReDo @do = new Declarations.UnDoReDo((MP3)item.Tag, (V1TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null), null, "Clone", new object[0], null, null), (V2TAG)LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "Clone", new object[0], null, null), StringType.FromObject(LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)), BooleanType.FromObject(LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        if (BooleanType.FromObject(LateBinding.LateGet(LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null), null, "TAGHeaderPresent", new object[0], null, null)))
        {
          LateBinding.LateCall(item.Tag, null, "RemoveV2TAG", new object[0], null, null);
          LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
          this.UpdateListItem(item, BooleanType.FromObject(Interaction.IIf(Declarations.objSettings.VersionToShow == 2, true, false)));
          if (Declarations.objSettings.SynchronizeTAGs)
          {
            LateBinding.LateCall(item.Tag, null, "RemoveV1TAG", new object[0], null, null);
            LateBinding.LateSetComplex(item.Tag, null, "Changed", new object[] { true }, null, false, true);
            this.UpdateListItem(item, BooleanType.FromObject(Interaction.IIf(Declarations.objSettings.VersionToShow == 1, true, false)));
          }
        }
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void SaveChanges()
    {
      int vintMaximum = 0;
      foreach (ListViewItem item in this.MP3View.Items)
      {
        MP3 tag = (MP3)item.Tag;
        if (tag.Changed)
        {
          vintMaximum++;
        }
      }
      if (vintMaximum > 0)
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
        {
          break;
        }
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
            {
              resStrings[str] = RuntimeHelpers.GetObjectValue(args[0]);
            }
            this.ErrorMsg.Items.Insert(0, item2);
            this.SplitterBottom.Expanded = true;
          }
        }
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
        var enumerator = this.DotNetBarManager.GetItems(column.ColumnName).GetEnumerator();
        while (enumerator.MoveNext())
        {
          object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
          try
          {
            LateBinding.LateSet(objectValue, null, "Text", new object[] { Declarations.objResources.GetMenuText(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Name", new object[0], null, null))) }, null);
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            Exception exception = exception1;
            ProjectData.ClearProjectError();
          }
          try
          {
            LateBinding.LateSet(objectValue, null, "Tooltip", new object[] { Declarations.objResources.GetMenuToolTip(StringType.FromObject(LateBinding.LateGet(objectValue, null, "Name", new object[0], null, null))) }, null);
            continue;
          }
          catch (Exception exception4)
          {
            ProjectData.SetProjectError(exception4);
            Exception exception2 = exception4;
            ProjectData.ClearProjectError();
            continue;
          }
        }
      }
      ((ButtonItem)this.DotNetBarManager.ContextMenus["MP3ViewMenu"]).SubItems["TAGV1"].Text = Declarations.objResources.GetMenuText("TAGV1");
      ((ButtonItem)this.DotNetBarManager.ContextMenus["MP3ViewMenu"]).SubItems["TAGV2"].Text = Declarations.objResources.GetMenuText("TAGV2");
      try
      {
        this.DotNetBarManager.GetItem("btnV1V2View").Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], " "), Declarations.objSettings.VersionToShow.ToString()));
      }
      catch (Exception exception5)
      {
        ProjectData.SetProjectError(exception5);
        Exception exception3 = exception5;
        ProjectData.ClearProjectError();
      }
      this.DotNetBarManager.GetItem("lblVersion").Text = StringType.FromObject(ObjectType.StrCatObj(Declarations.objResources.ResStrings["TAGVer"], Declarations.objSettings.VersionToShow.ToString()));
      object[] objArray2 = new object[2];
      objArray2[0] = "%1";
      Settings objSettings = Declarations.objSettings;
      objArray2[1] = objSettings.CurrentPath;
      object[] args = objArray2;
      bool[] copyBack = new bool[] { false, true };
      if (copyBack[1])
      {
        objSettings.CurrentPath = StringType.FromObject(args[1]);
      }
      this.DotNetBarManager.GetItem("lblPath").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["Path"], null, "Replace", args, null, copyBack));
      this.DotNetBarManager.GetItem("lblProgress").Text = StringType.FromObject(Declarations.objResources.ResStrings["ProgressChecksum"]);
      if (Declarations.objSettings.ScanSubDirs)
      {
        this.DotNetBarManager.GetItem("lblSubDirs").Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsYes"]);
      }
      else
      {
        this.DotNetBarManager.GetItem("lblSubDirs").Text = StringType.FromObject(Declarations.objResources.ResStrings["SubDirsNo"]);
      }
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
      this.lblArtist.Text = this.colHArtist.Text;
      this.lblTitle.Text = this.colHTitle.Text;
      this.lblAlbum.Text = this.colHAlbum.Text;
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      this.FoldersPan.Text = StringType.FromObject(Declarations.objResources.ResStrings["FoldersPan"]);
      this.BarGroupTools.Text = StringType.FromObject(Declarations.objResources.ResStrings["ToolsPan"]);
      this.BarGroupEdit.Text = StringType.FromObject(Declarations.objResources.ResStrings["QuickEditPan"]);
      this.BarGroupPicture.Text = StringType.FromObject(Declarations.objResources.ResStrings["PicturePan"]);
      this.FavouritesPan.Text = StringType.FromObject(Declarations.objResources.ResStrings["FavouritesPan"]);
      this.FoldersPan.Refresh();
      this.FavouritesPan.Refresh();
      this.BarGroupTools.Refresh();
      this.BarGroupEdit.Refresh();
      this.BarGroupPicture.Refresh();
      this.NavigationPan.RecalcLayout();
      this.NavigationPan.Refresh();
      this.Timer.Start();
    }

    private void SideBar_ContainerLoadControl(object sender, EventArgs e)
    {
      ControlContainerItem item = (ControlContainerItem)sender;
      string name = item.Name;
      if (StringType.StrCmp(name, "CContainerArtist", false) == 0)
      {
        item.Control = this.cmbArtist;
      }
      else if (StringType.StrCmp(name, "CContainerTitle", false) == 0)
      {
        item.Control = this.txtTitle;
      }
      else if (StringType.StrCmp(name, "CContainerAlbum", false) == 0)
      {
        item.Control = this.txtAlbum;
      }
      else if (StringType.StrCmp(name, "CContainerbtnQuickEditOK", false) == 0)
      {
        item.Control = this.btnQuickEdit;
      }
      else if (StringType.StrCmp(name, "CContainerbtnQuickEditMore", false) == 0)
      {
        item.Control = this.btnQuickEditMore;
      }
      else if (StringType.StrCmp(name, "CContainerAPICView", false) == 0)
      {
        item.Control = this.APICView;
      }
      else if (StringType.StrCmp(name, "CContainertxtInfo", false) == 0)
      {
        item.Control = this.txtInfo;
      }
    }

    private void SideBar_ItemClick(object sender, EventArgs e)
    {
      if ((sender is BaseItem) && StringType.FromObject(LateBinding.LateGet(sender, null, "Name", new object[0], null, null)).StartsWith("ToolItem"))
      {
        Process process = new Process();
        DataRow row = Declarations.objSettings.Tools.Rows[IntegerType.FromObject(LateBinding.LateGet(sender, null, "Tag", new object[0], null, null))];
        try
        {
          ListViewItem current;
          IEnumerator enumerator = null;
          if (BooleanType.FromObject(row["DefaultPlayer"]))
          {
            var enumerator2 = this.MP3View.SelectedItems.GetEnumerator();
            while (enumerator2.MoveNext())
            {
              current = (ListViewItem)enumerator2.Current;
              process.StartInfo.FileName = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj('"', LateBinding.LateGet(LateBinding.LateGet(current.Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null)), '"'));
              process.StartInfo.Verb = StringType.FromObject(row["ShellCommand"]);
              process.Start();
            }
            return;
          }
          try
          {
            enumerator = this.MP3View.SelectedItems.GetEnumerator();
            while (enumerator.MoveNext())
            {
              current = (ListViewItem)enumerator.Current;
              process.StartInfo.FileName = StringType.FromObject(row["ToolPath"]);
              process.StartInfo.Arguments = StringType.FromObject(LateBinding.LateGet(row["ToolParameter"], null, "Replace", new object[] { "%P", ObjectType.StrCatObj(ObjectType.StrCatObj('"', LateBinding.LateGet(LateBinding.LateGet(current.Tag, null, "FI", new object[0], null, null), null, "Fullname", new object[0], null, null)), '"') }, null, null));
              process.Start();
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
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          ProjectData.ClearProjectError();
        }
      }
    }

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
        {
          break;
        }
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
            {
              str2 = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
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

    private void SwapArtistAlbum2CB(ref frmProgress frmProg)
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

    private void TimerEventProcessor(object myObject, EventArgs myEventArgs)
    {
      MP3 tag;
      byte num3;
      if (this.vbooStartUp)
      {
        return;
      }
      if (this.vintSelTimerCount == this.MP3View.SelectedItems.Count)
      {
        this.vbytSelTimerCount = (byte)(this.vbytSelTimerCount + 1);
      }
      else
      {
        this.vintSelTimerCount = this.MP3View.SelectedItems.Count;
      }
      if (this.vbytSelTimerCount > 5)
      {
        this.Timer.Stop();
        this.vbytSelTimerCount = 0;
      }
      int num = 0;
      foreach (ListViewItem item in this.MP3View.SelectedItems)
      {
        num = IntegerType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(item.Tag, null, "Duration", new object[0], null, null)));
      }
      int num6 = num / 0xe10;
      num6 = (num - ((num / 0xe10) * 0xe10)) / 60;
      string introduced34 = num6.ToString().PadLeft(2, '0') + ":";
      num6 = (num - ((num / 0xe10) * 0xe10)) - (((num - ((num / 0xe10) * 0xe10)) / 60) * 60);
      string introduced35 = introduced34 + num6.ToString().PadLeft(2, '0') + ":";
      string str = introduced35 + num6.ToString().PadLeft(2, '0');
      object[] args = new object[] { "%3", str };
      bool[] copyBack = new bool[] { false, true };
      if (copyBack[1])
      {
        str = StringType.FromObject(args[1]);
      }
      this.DotNetBarManager.GetItem("lblNumber").Text = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(Declarations.objResources.ResStrings["Number"], null, "Replace", new object[] { "%1", this.MP3View.Items.Count.ToString() }, null, null), null, "Replace", new object[] { "%2", this.MP3View.SelectedItems.Count.ToString() }, null, null), null, "Replace", args, null, copyBack));
      try
      {
        this.DotNetBarManager.GetItem("lblLength").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", this.MP3View.FocusedItem.Text.Length.ToString() }, null, null));
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        this.DotNetBarManager.GetItem("lblLength").Text = StringType.FromObject(LateBinding.LateGet(Declarations.objResources.ResStrings["FilenameLen"], null, "Replace", new object[] { "%1", "0" }, null, null));
        ProjectData.ClearProjectError();
      }
      this.cmbArtist.Text = "";
      this.txtTitle.Text = "";
      this.txtAlbum.Text = "";
      try
      {
        this.APICView.Image = null;
      }
      catch (Exception exception3)
      {
        ProjectData.SetProjectError(exception3);
        Exception exception = exception3;
        ProjectData.ClearProjectError();
      }
      try
      {
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
          {
            this.cmbArtist.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
          }
          if (tag.V2TAG.FrameExists("TIT2"))
          {
            this.txtTitle.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
          }
          if (tag.V2TAG.FrameExists("TALB"))
          {
            this.txtAlbum.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
          }
        }
        if (this.MP3View.SelectedItems.Count <= 1)
        {
          goto Label_0B93;
        }
        tag = (MP3)this.MP3View.SelectedItems[0].Tag;
        foreach (ListViewItem item in this.MP3View.SelectedItems)
        {
          MP3 mp4 = (MP3)item.Tag;
          if (tag != mp4)
          {
            if ((((num3 & 1) == 0) && tag.V2TAG.FrameExists("TPE1")) && mp4.V2TAG.FrameExists("TPE1"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp4.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp4.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), "", false) == 0)))
              {
                num3 = (byte)(num3 | 1);
              }
            }
            else
            {
              num3 = (byte)(num3 | 1);
            }
            if ((((num3 & 2) == 0) && tag.V2TAG.FrameExists("TIT2")) && mp4.V2TAG.FrameExists("TIT2"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp4.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp4.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null), "", false) == 0)))
              {
                num3 = (byte)(num3 | 2);
              }
            }
            else
            {
              num3 = (byte)(num3 | 2);
            }
            if ((((num3 & 4) == 0) && tag.V2TAG.FrameExists("TALB")) && mp4.V2TAG.FrameExists("TALB"))
            {
              if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(mp4.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), LateBinding.LateGet(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), null, "ToLower", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(mp4.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null), "", false) == 0)))
              {
                num3 = (byte)(num3 | 4);
              }
            }
            else
            {
              num3 = (byte)(num3 | 4);
            }
            if (num3 == 7)
            {
              break;
            }
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
          this.cmbArtist.Text = mp.V1TAG.Artist;
          this.txtTitle.Text = mp.V1TAG.Title;
          this.txtAlbum.Text = mp.V1TAG.Album;
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
              {
                num2 = (byte)(num2 | 1);
              }
              if ((((num2 & 2) == 0) && (StringType.StrCmp(mp2.V1TAG.Title.ToLower(), mp.V1TAG.Title.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Title, "", false) == 0))
              {
                num2 = (byte)(num2 | 2);
              }
              if ((((num2 & 4) == 0) && (StringType.StrCmp(mp2.V1TAG.Album.ToLower(), mp.V1TAG.Album.ToLower(), false) != 0)) | (StringType.StrCmp(mp2.V1TAG.Album, "", false) == 0))
              {
                num2 = (byte)(num2 | 4);
              }
              if (num2 == 7)
              {
                break;
              }
            }
          }
          if (num2 != 7)
          {
            if ((num2 & 1) == 0)
            {
              this.cmbArtist.Text = mp.V1TAG.Artist;
            }
            if ((num2 & 2) == 0)
            {
              this.txtTitle.Text = mp.V1TAG.Title;
            }
            if ((num2 & 4) == 0)
            {
              this.txtAlbum.Text = mp.V1TAG.Album;
            }
          }
        }
        goto Label_0B93;
      }
      if (num3 != 7)
      {
        if ((num3 & 1) == 0)
        {
          this.cmbArtist.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
        }
        if ((num3 & 2) == 0)
        {
          this.txtTitle.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
        }
        if ((num3 & 4) == 0)
        {
          this.txtAlbum.Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
        }
      }
      Label_0B93:
      if (this.BarGroupInfo.Expanded & (this.MP3View.SelectedItems.Count == 1))
      {
        MP3 mp5 = (MP3)this.MP3View.SelectedItems[0].Tag;
        this.txtInfo.Text = "";
        this.txtInfo.Text = StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHDuration.Text + ":", Interaction.IIf(this.colHDuration.Text.Length < 9, "\t\t", "\t")), mp5.DurationFormated), "\r\n"));
        long num4 = mp5.FI.Length / 0x400L;
        this.txtInfo.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHFileSize.Text + ":", Interaction.IIf(this.colHFileSize.Text.Length < 9, "\t\t", "\t")), num4.ToString()), "\r\n")));
        int num5 = mp5.Bitrate / 0x3e8;
        this.txtInfo.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHBitrate.Text + ":", Interaction.IIf(this.colHBitrate.Text.Length < 9, "\t\t", "\t")), num5.ToString()), "\r\n")));
        this.txtInfo.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHVBR.Text + ":", Interaction.IIf(this.colHVBR.Text.Length < 9, "\t\t", "\t")), Interaction.IIf(mp5.VBR, "VBR", "CBR")), "\r\n")));
        this.txtInfo.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHSamplerate.Text + ":", Interaction.IIf(this.colHSamplerate.Text.Length < 9, "\t\t", "\t")), mp5.Samplerate), "\r\n")));
        this.txtInfo.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHChannel.Text + ":", Interaction.IIf(this.colHChannel.Text.Length < 9, "\t\t", "\t")), mp5.ChannelText), "\r\n")));
        this.txtInfo.AppendText(StringType.FromObject(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(ObjectType.StrCatObj(this.colHVersion.Text + ":", Interaction.IIf(this.colHVersion.Text.Length < 9, "\t\t", "\t")), mp5.VersionText), " "), mp5.LayerText)));
      }
      else
      {
        this.txtInfo.Text = "";
        this.txtInfo.Text = this.colHDuration.Text + ":\r\n";
        this.txtInfo.AppendText(this.colHFileSize.Text + ":\r\n");
        this.txtInfo.AppendText(this.colHBitrate.Text + ":\r\n");
        this.txtInfo.AppendText(this.colHVBR.Text + ":\r\n");
        this.txtInfo.AppendText(this.colHSamplerate.Text + ":\r\n");
        this.txtInfo.AppendText(this.colHChannel.Text + ":\r\n");
        this.txtInfo.AppendText(this.colHVersion.Text + ":");
      }
      if (this.BarGroupPicture.Expanded & (this.MP3View.SelectedItems.Count == 1))
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
              this.APICView.Image = Image.FromStream(this.PicMStream);
              stream.Close();
            }
            else
            {
              FileStream stream2 = new FileStream(frame3.TempPath, FileMode.Open, FileAccess.Read);
              stream2.Seek(0L, SeekOrigin.Begin);
              byte[] buffer2 = new byte[((int)(stream2.Length - 1L)) + 1];
              stream2.Read(buffer2, 0, buffer2.Length);
              this.PicMStream = new MemoryStream(buffer2);
              this.APICView.Image = Image.FromStream(this.PicMStream);
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
              this.APICView.Image = Image.FromStream(this.PicMStream);
              stream3.Close();
            }
          }
          break;
        }
      }
      else
      {
        this.APICView.Image = null;
      }
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
      this.mnubtnUndo.Enabled = vbooEnabled;
      if (vbooClear)
      {
        this.mnubtnRedo.Enabled = false;
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
      {
        lstItem.SubItems[this.colHTAGVer1.Index].Text = tag.V1TAG.TAGVersion.ToString().Replace("0", "-").Replace("1-", "1.0").Replace("11", "1.1");
      }
      if (this.MP3View.Columns.Contains(this.colHTAGVer2))
      {
        lstItem.SubItems[this.colHTAGVer2.Index].Text = tag.V2TAG.TAGVersion.ToString().Replace("2", "2.2").Replace("3", "2.3").Replace("4", "2.4").Replace("0", "-");
      }
      if (this.MP3View.Columns.Contains(this.colHDate))
      {
        lstItem.SubItems[this.colHDate.Index].Text = tag.FI.LastWriteTime.ToString();
      }
      if (this.MP3View.Columns.Contains(this.colHCreateDate))
      {
        lstItem.SubItems[this.colHCreateDate.Index].Text = tag.FI.CreationTime.ToString();
      }
      if (this.MP3View.Columns.Contains(this.colHFileSize))
      {
        lstItem.SubItems[this.colHFileSize.Index].Text = (tag.FI.Length / 0x400L).ToString();
      }
      if (this.MP3View.Columns.Contains(this.colHAudioCheckSum))
      {
        lstItem.SubItems[this.colHAudioCheckSum.Index].Text = StringType.FromObject(Interaction.IIf(tag.AudioCheckSum != 0, tag.AudioCheckSum.ToString(), ""));
      }
      if (vbooClear)
      {
        if (this.MP3View.Columns.Contains(this.colHArtist))
        {
          lstItem.SubItems[this.colHArtist.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHTitle))
        {
          lstItem.SubItems[this.colHTitle.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHAlbum))
        {
          lstItem.SubItems[this.colHAlbum.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHTrack))
        {
          lstItem.SubItems[this.colHTrack.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHGenre))
        {
          lstItem.SubItems[this.colHGenre.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHYear))
        {
          lstItem.SubItems[this.colHYear.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHPosMedia))
        {
          lstItem.SubItems[this.colHPosMedia.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHComment))
        {
          lstItem.SubItems[this.colHComment.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHRating))
        {
          lstItem.SubItems[this.colHRating.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHComposer))
        {
          lstItem.SubItems[this.colHComposer.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHBPM))
        {
          lstItem.SubItems[this.colHBPM.Index].Text = "";
        }
        if (this.MP3View.Columns.Contains(this.colHPicCount))
        {
          lstItem.SubItems[this.colHPicCount.Index].Text = "";
          return;
        }
        return;
      }
      if (!tag.V2TAG.TAGHeaderPresent || (this.vbytVersionToShow != 2))
      {
        goto Label_0DA3;
      }
      if (this.MP3View.Columns.Contains(this.colHArtist))
      {
        if (tag.V2TAG.FrameExists("TPE1"))
        {
          lstItem.SubItems[this.colHArtist.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
        }
        else
        {
          lstItem.SubItems[this.colHArtist.Index].Text = "";
        }
      }
      if (this.MP3View.Columns.Contains(this.colHTitle))
      {
        if (tag.V2TAG.FrameExists("TIT2"))
        {
          lstItem.SubItems[this.colHTitle.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
        }
        else
        {
          lstItem.SubItems[this.colHTitle.Index].Text = "";
        }
      }
      if (this.MP3View.Columns.Contains(this.colHAlbum))
      {
        if (tag.V2TAG.FrameExists("TALB"))
        {
          lstItem.SubItems[this.colHAlbum.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
        }
        else
        {
          lstItem.SubItems[this.colHAlbum.Index].Text = "";
        }
      }
      if (this.MP3View.Columns.Contains(this.colHTrack))
      {
        if (tag.V2TAG.FrameExists("TRCK"))
        {
          lstItem.SubItems[this.colHTrack.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null));
        }
        else
        {
          lstItem.SubItems[this.colHTrack.Index].Text = "";
        }
      }
      if (this.MP3View.Columns.Contains(this.colHGenre))
      {
        if (tag.V2TAG.FrameExists("TCON"))
        {
          lstItem.SubItems[this.colHGenre.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null));
        }
        else
        {
          lstItem.SubItems[this.colHGenre.Index].Text = "";
        }
      }
      if (this.MP3View.Columns.Contains(this.colHYear))
      {
        if (tag.V2TAG.FrameExists("TYER"))
        {
          lstItem.SubItems[this.colHYear.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TYER"), null, "Content", new object[0], null, null));
        }
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
        {
          lstItem.SubItems[this.colHYear.Index].Text = "";
        }
      }
      if (this.MP3View.Columns.Contains(this.colHPosMedia))
      {
        if (tag.V2TAG.FrameExists("TPOS"))
        {
          lstItem.SubItems[this.colHPosMedia.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPOS"), null, "Content", new object[0], null, null));
        }
        else
        {
          lstItem.SubItems[this.colHPosMedia.Index].Text = "";
        }
      }
      if (this.MP3View.Columns.Contains(this.colHBPM))
      {
        try
        {
          if (StringType.StrCmp(tag.V2TAG.GetTextWebFrameContent("TBPM").Trim(new char[] { ' ' }), "", false) == 0)
          {
            lstItem.SubItems[this.colHBPM.Index].Text = "";
          }
          else
          {
            lstItem.SubItems[this.colHBPM.Index].Text = ((int)Math.Round(Conversion.Fix(Conversion.Val(tag.V2TAG.GetTextWebFrameContent("TBPM").Trim(new char[] { ' ' }))))).ToString();
          }
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
        {
          lstItem.SubItems[this.colHComposer.Index].Text = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TCOM"), null, "Content", new object[0], null, null));
        }
        else
        {
          lstItem.SubItems[this.colHComposer.Index].Text = "";
        }
      }
      if (this.MP3View.Columns.Contains(this.colHPicCount))
      {
        lstItem.SubItems[this.colHPicCount.Index].Text = StringType.FromInteger(tag.V2TAG.GetFrames("APIC").Count);
      }
      Label_0DA3:
      if (tag.V1TAG.TAGPresent && (this.vbytVersionToShow == 1))
      {
        if (this.MP3View.Columns.Contains(this.colHArtist))
        {
          lstItem.SubItems[this.colHArtist.Index].Text = tag.V1TAG.Artist;
        }
        if (this.MP3View.Columns.Contains(this.colHTitle))
        {
          lstItem.SubItems[this.colHTitle.Index].Text = tag.V1TAG.Title;
        }
        if (this.MP3View.Columns.Contains(this.colHAlbum))
        {
          lstItem.SubItems[this.colHAlbum.Index].Text = tag.V1TAG.Album;
        }
        if (this.MP3View.Columns.Contains(this.colHTrack))
        {
          lstItem.SubItems[this.colHTrack.Index].Text = StringType.FromObject(Interaction.IIf(tag.V1TAG.Tracknumber > 0, tag.V1TAG.Tracknumber.ToString(), ""));
        }
        if (this.MP3View.Columns.Contains(this.colHYear))
        {
          lstItem.SubItems[this.colHYear.Index].Text = StringType.FromObject(Interaction.IIf(tag.V1TAG.Year > 0, tag.V1TAG.Year.ToString(), ""));
        }
        if (this.MP3View.Columns.Contains(this.colHGenre))
        {
          lstItem.SubItems[this.colHGenre.Index].Text = tag.V1TAG.GenreText;
        }
        if (this.MP3View.Columns.Contains(this.colHComment))
        {
          lstItem.SubItems[this.colHComment.Index].Text = tag.V1TAG.Comment;
        }
      }
    }

    private void ffff()
    {
      if (false)
      {
        //this.FolderTree.add_AfterLabelEdit(new AfterLabelEditHandler(this.FolderTree_AfterLabelEdit));
        //this.FolderTree.add_BeforeLabelEdit(new BeforeLabelEditHandler(this.FolderTree_BeforeLabelEdit));
        //this.FolderTree.add_AfterSelect(new AfterSelectHandler(this.FolderTree_AfterSelect));
        //this.FolderTree.add_BeforeSelect(new BeforeSelectHandler(this.FolderTree_BeforeSelect));
      }
    }
  }
}