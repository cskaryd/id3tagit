using DevComponents.DotNetBar;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmLibraries : Form
  {
    #region Designer

    private TabItem Artist;
    private ListBox ArtistList;
    private Button btnAdd;
    private Button btnAddCommD;
    private Button btnAddFav;
    private Button btnAddFavDir;
    private Button btnAddG;
    private Button btnCancel;
    private Button btnClearA;
    private Button btnClearCommD;
    private Button btnDeleteA;
    private Button btnDeleteG;
    private Button btnFavBrowse;
    private Button btnGetArtistV1;
    private Button btnGetArtistV2;
    private Button btnOK;
    private Button btnRemoveCommD;
    private Button btnRemoveFav;
    private Button btnRemoveFavDir;
    private CheckBox chkOnlyOwn;
    private ComboBox cmbV1V2;
    private ComboBox cmbV2V1;
    private ColumnHeader colHName;
    private ColumnHeader colHV1V2;
    private ColumnHeader colHV2V1;
    private ListBox CommDList;
    private TabItem Comment;
    private TabItem Favourites;
    private TreeView FavTree;
    private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    private TabItem Genre;
    private ListView GenreList;
    private Label Label1;
    private Label Label2;
    private Label Label3;
    private Label lblArtistName;
    private Label lblCorres;
    private Label lblDescArtist;
    private Label lblDescGenre;
    private Label lblGenreName;
    private Label lblInfo1;
    private Label lblInfo2;
    private DevComponents.DotNetBar.TabControl Libraries;
    private TabControlPanel TabControlPanel1;
    private TabControlPanel TabControlPanel2;
    private TabControlPanel TabControlPanel3;
    private TabControlPanel TabControlPanel4;
    private System.Windows.Forms.ToolTip ToolTip;
    private TextBox txtArtistName;
    private TextBox txtDir;
    private TextBox txtGenreName;
    private TextBox txtName;
    private TextBox txtNewCommD;
    private IContainer components;
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
      System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmLibraries));
      this.lblInfo1 = new System.Windows.Forms.Label();
      this.btnFavBrowse = new System.Windows.Forms.Button();
      this.btnRemoveFavDir = new System.Windows.Forms.Button();
      this.btnAddFavDir = new System.Windows.Forms.Button();
      this.txtDir = new System.Windows.Forms.TextBox();
      this.Label2 = new System.Windows.Forms.Label();
      this.btnRemoveFav = new System.Windows.Forms.Button();
      this.btnAddFav = new System.Windows.Forms.Button();
      this.txtName = new System.Windows.Forms.TextBox();
      this.Label1 = new System.Windows.Forms.Label();
      this.FavTree = new System.Windows.Forms.TreeView();
      this.chkOnlyOwn = new System.Windows.Forms.CheckBox();
      this.lblDescGenre = new System.Windows.Forms.Label();
      this.cmbV2V1 = new System.Windows.Forms.ComboBox();
      this.cmbV1V2 = new System.Windows.Forms.ComboBox();
      this.lblCorres = new System.Windows.Forms.Label();
      this.btnDeleteG = new System.Windows.Forms.Button();
      this.btnAddG = new System.Windows.Forms.Button();
      this.lblGenreName = new System.Windows.Forms.Label();
      this.txtGenreName = new System.Windows.Forms.TextBox();
      this.GenreList = new System.Windows.Forms.ListView();
      this.colHName = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colHV1V2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.colHV2V1 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
      this.lblDescArtist = new System.Windows.Forms.Label();
      this.btnClearA = new System.Windows.Forms.Button();
      this.btnDeleteA = new System.Windows.Forms.Button();
      this.btnAdd = new System.Windows.Forms.Button();
      this.lblArtistName = new System.Windows.Forms.Label();
      this.txtArtistName = new System.Windows.Forms.TextBox();
      this.btnGetArtistV1 = new System.Windows.Forms.Button();
      this.ArtistList = new System.Windows.Forms.ListBox();
      this.btnGetArtistV2 = new System.Windows.Forms.Button();
      this.btnClearCommD = new System.Windows.Forms.Button();
      this.btnRemoveCommD = new System.Windows.Forms.Button();
      this.btnAddCommD = new System.Windows.Forms.Button();
      this.Label3 = new System.Windows.Forms.Label();
      this.txtNewCommD = new System.Windows.Forms.TextBox();
      this.CommDList = new System.Windows.Forms.ListBox();
      this.lblInfo2 = new System.Windows.Forms.Label();
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.Libraries = new DevComponents.DotNetBar.TabControl();
      this.TabControlPanel1 = new DevComponents.DotNetBar.TabControlPanel();
      this.Favourites = new DevComponents.DotNetBar.TabItem(this.components);
      this.TabControlPanel4 = new DevComponents.DotNetBar.TabControlPanel();
      this.Comment = new DevComponents.DotNetBar.TabItem(this.components);
      this.TabControlPanel2 = new DevComponents.DotNetBar.TabControlPanel();
      this.Genre = new DevComponents.DotNetBar.TabItem(this.components);
      this.TabControlPanel3 = new DevComponents.DotNetBar.TabControlPanel();
      this.Artist = new DevComponents.DotNetBar.TabItem(this.components);
      ((System.ComponentModel.ISupportInitialize)(this.Libraries)).BeginInit();
      this.Libraries.SuspendLayout();
      this.TabControlPanel1.SuspendLayout();
      this.TabControlPanel4.SuspendLayout();
      this.TabControlPanel2.SuspendLayout();
      this.TabControlPanel3.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblInfo1
      // 
      this.lblInfo1.BackColor = System.Drawing.Color.Transparent;
      this.lblInfo1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo1.Location = new System.Drawing.Point(8, 352);
      this.lblInfo1.Name = "lblInfo1";
      this.lblInfo1.Size = new System.Drawing.Size(288, 48);
      this.lblInfo1.TabIndex = 20;
      this.lblInfo1.Text = "You can group different directories under one Favourite so that can access them d" +
    "irectly with one click.";
      this.lblInfo1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnFavBrowse
      // 
      this.btnFavBrowse.BackColor = System.Drawing.SystemColors.Control;
      this.btnFavBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnFavBrowse.Location = new System.Drawing.Point(163, 177);
      this.btnFavBrowse.Name = "btnFavBrowse";
      this.btnFavBrowse.Size = new System.Drawing.Size(136, 24);
      this.btnFavBrowse.TabIndex = 9;
      this.btnFavBrowse.Text = "Browse ...";
      this.btnFavBrowse.UseVisualStyleBackColor = false;
      this.btnFavBrowse.Click += new System.EventHandler(this.btnFavBrowse_Click);
      // 
      // btnRemoveFavDir
      // 
      this.btnRemoveFavDir.BackColor = System.Drawing.SystemColors.Control;
      this.btnRemoveFavDir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveFavDir.Location = new System.Drawing.Point(163, 145);
      this.btnRemoveFavDir.Name = "btnRemoveFavDir";
      this.btnRemoveFavDir.Size = new System.Drawing.Size(136, 24);
      this.btnRemoveFavDir.TabIndex = 8;
      this.btnRemoveFavDir.Text = "Remove";
      this.btnRemoveFavDir.UseVisualStyleBackColor = false;
      this.btnRemoveFavDir.Click += new System.EventHandler(this.btnRemoveFavDir_Click);
      // 
      // btnAddFavDir
      // 
      this.btnAddFavDir.BackColor = System.Drawing.SystemColors.Control;
      this.btnAddFavDir.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddFavDir.Location = new System.Drawing.Point(11, 145);
      this.btnAddFavDir.Name = "btnAddFavDir";
      this.btnAddFavDir.Size = new System.Drawing.Size(136, 24);
      this.btnAddFavDir.TabIndex = 7;
      this.btnAddFavDir.Text = "Add";
      this.btnAddFavDir.UseVisualStyleBackColor = false;
      this.btnAddFavDir.Click += new System.EventHandler(this.btnAddFavDir_Click);
      // 
      // txtDir
      // 
      this.txtDir.Location = new System.Drawing.Point(11, 119);
      this.txtDir.Name = "txtDir";
      this.txtDir.Size = new System.Drawing.Size(288, 20);
      this.txtDir.TabIndex = 6;
      // 
      // Label2
      // 
      this.Label2.BackColor = System.Drawing.Color.Transparent;
      this.Label2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label2.Location = new System.Drawing.Point(11, 97);
      this.Label2.Name = "Label2";
      this.Label2.Size = new System.Drawing.Size(184, 16);
      this.Label2.TabIndex = 5;
      this.Label2.Text = "Name of Directory:";
      // 
      // btnRemoveFav
      // 
      this.btnRemoveFav.BackColor = System.Drawing.SystemColors.Control;
      this.btnRemoveFav.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveFav.Location = new System.Drawing.Point(163, 57);
      this.btnRemoveFav.Name = "btnRemoveFav";
      this.btnRemoveFav.Size = new System.Drawing.Size(136, 24);
      this.btnRemoveFav.TabIndex = 4;
      this.btnRemoveFav.Text = "Remove";
      this.btnRemoveFav.UseVisualStyleBackColor = false;
      this.btnRemoveFav.Click += new System.EventHandler(this.btnRemoveFav_Click);
      // 
      // btnAddFav
      // 
      this.btnAddFav.BackColor = System.Drawing.SystemColors.Control;
      this.btnAddFav.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddFav.Location = new System.Drawing.Point(11, 57);
      this.btnAddFav.Name = "btnAddFav";
      this.btnAddFav.Size = new System.Drawing.Size(136, 24);
      this.btnAddFav.TabIndex = 3;
      this.btnAddFav.Text = "Add";
      this.btnAddFav.UseVisualStyleBackColor = false;
      this.btnAddFav.Click += new System.EventHandler(this.btnAddFav_Click);
      // 
      // txtName
      // 
      this.txtName.Location = new System.Drawing.Point(11, 31);
      this.txtName.Name = "txtName";
      this.txtName.Size = new System.Drawing.Size(288, 20);
      this.txtName.TabIndex = 2;
      // 
      // Label1
      // 
      this.Label1.BackColor = System.Drawing.Color.Transparent;
      this.Label1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label1.Location = new System.Drawing.Point(11, 9);
      this.Label1.Name = "Label1";
      this.Label1.Size = new System.Drawing.Size(184, 16);
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Name of Favourite:";
      // 
      // FavTree
      // 
      this.FavTree.Indent = 19;
      this.FavTree.ItemHeight = 16;
      this.FavTree.Location = new System.Drawing.Point(315, 9);
      this.FavTree.Name = "FavTree";
      this.FavTree.ShowLines = false;
      this.FavTree.Size = new System.Drawing.Size(277, 391);
      this.FavTree.TabIndex = 0;
      // 
      // chkOnlyOwn
      // 
      this.chkOnlyOwn.BackColor = System.Drawing.Color.Transparent;
      this.chkOnlyOwn.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkOnlyOwn.Location = new System.Drawing.Point(8, 312);
      this.chkOnlyOwn.Name = "chkOnlyOwn";
      this.chkOnlyOwn.Size = new System.Drawing.Size(584, 16);
      this.chkOnlyOwn.TabIndex = 17;
      this.chkOnlyOwn.Text = "Use only the own genres entered above in TAG Ver. 2 genre dropdown lists";
      this.chkOnlyOwn.UseVisualStyleBackColor = false;
      // 
      // lblDescGenre
      // 
      this.lblDescGenre.BackColor = System.Drawing.Color.Transparent;
      this.lblDescGenre.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblDescGenre.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDescGenre.Location = new System.Drawing.Point(8, 336);
      this.lblDescGenre.Name = "lblDescGenre";
      this.lblDescGenre.Size = new System.Drawing.Size(584, 64);
      this.lblDescGenre.TabIndex = 19;
      this.lblDescGenre.Text = resources.GetString("lblDescGenre.Text");
      this.lblDescGenre.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // cmbV2V1
      // 
      this.cmbV2V1.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbV2V1.ItemHeight = 13;
      this.cmbV2V1.Location = new System.Drawing.Point(304, 248);
      this.cmbV2V1.Name = "cmbV2V1";
      this.cmbV2V1.Size = new System.Drawing.Size(288, 21);
      this.cmbV2V1.TabIndex = 14;
      // 
      // cmbV1V2
      // 
      this.cmbV1V2.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
      this.cmbV1V2.ItemHeight = 13;
      this.cmbV1V2.Location = new System.Drawing.Point(8, 248);
      this.cmbV1V2.Name = "cmbV1V2";
      this.cmbV1V2.Size = new System.Drawing.Size(288, 21);
      this.cmbV1V2.TabIndex = 13;
      // 
      // lblCorres
      // 
      this.lblCorres.BackColor = System.Drawing.Color.Transparent;
      this.lblCorres.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblCorres.Location = new System.Drawing.Point(8, 232);
      this.lblCorres.Name = "lblCorres";
      this.lblCorres.Size = new System.Drawing.Size(584, 16);
      this.lblCorres.TabIndex = 12;
      this.lblCorres.Text = "Corres&ponding TAG Ver. 1 genres for transfer from  Ver. 1 to Ver. 2 and  Ver. 2 " +
    "to Ver. 1:";
      // 
      // btnDeleteG
      // 
      this.btnDeleteG.BackColor = System.Drawing.SystemColors.Control;
      this.btnDeleteG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnDeleteG.Location = new System.Drawing.Point(304, 280);
      this.btnDeleteG.Name = "btnDeleteG";
      this.btnDeleteG.Size = new System.Drawing.Size(288, 24);
      this.btnDeleteG.TabIndex = 16;
      this.btnDeleteG.Text = "&Delete selected genre";
      this.btnDeleteG.UseVisualStyleBackColor = false;
      this.btnDeleteG.Click += new System.EventHandler(this.btnDeleteG_Click);
      // 
      // btnAddG
      // 
      this.btnAddG.BackColor = System.Drawing.SystemColors.Control;
      this.btnAddG.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddG.Location = new System.Drawing.Point(8, 280);
      this.btnAddG.Name = "btnAddG";
      this.btnAddG.Size = new System.Drawing.Size(288, 24);
      this.btnAddG.TabIndex = 15;
      this.btnAddG.Text = "&Add genre to library";
      this.btnAddG.UseVisualStyleBackColor = false;
      this.btnAddG.Click += new System.EventHandler(this.btnAddG_Click);
      // 
      // lblGenreName
      // 
      this.lblGenreName.BackColor = System.Drawing.Color.Transparent;
      this.lblGenreName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblGenreName.Location = new System.Drawing.Point(8, 192);
      this.lblGenreName.Name = "lblGenreName";
      this.lblGenreName.Size = new System.Drawing.Size(584, 16);
      this.lblGenreName.TabIndex = 10;
      this.lblGenreName.Text = "&New TAG Ver. 2 genre name:";
      // 
      // txtGenreName
      // 
      this.txtGenreName.Location = new System.Drawing.Point(8, 208);
      this.txtGenreName.Name = "txtGenreName";
      this.txtGenreName.Size = new System.Drawing.Size(584, 20);
      this.txtGenreName.TabIndex = 11;
      // 
      // GenreList
      // 
      this.GenreList.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.colHName,
            this.colHV1V2,
            this.colHV2V1});
      this.GenreList.FullRowSelect = true;
      this.GenreList.GridLines = true;
      this.GenreList.Location = new System.Drawing.Point(8, 8);
      this.GenreList.Name = "GenreList";
      this.GenreList.Size = new System.Drawing.Size(584, 176);
      this.GenreList.Sorting = System.Windows.Forms.SortOrder.Ascending;
      this.GenreList.TabIndex = 18;
      this.GenreList.UseCompatibleStateImageBehavior = false;
      this.GenreList.View = System.Windows.Forms.View.Details;
      this.GenreList.SelectedIndexChanged += new System.EventHandler(this.GenreList_SelectedIndexChanged);
      // 
      // colHName
      // 
      this.colHName.Text = "Own TAG Ver. 2 genre";
      this.colHName.Width = 178;
      // 
      // colHV1V2
      // 
      this.colHV1V2.Text = "TAG Ver. 1 genre for transfer 1 ->  2";
      this.colHV1V2.Width = 189;
      // 
      // colHV2V1
      // 
      this.colHV2V1.Text = "TAG Ver. 1 genre for transfer 2 ->1";
      this.colHV2V1.Width = 182;
      // 
      // lblDescArtist
      // 
      this.lblDescArtist.BackColor = System.Drawing.Color.Transparent;
      this.lblDescArtist.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblDescArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblDescArtist.Location = new System.Drawing.Point(9, 336);
      this.lblDescArtist.Name = "lblDescArtist";
      this.lblDescArtist.Size = new System.Drawing.Size(583, 64);
      this.lblDescArtist.TabIndex = 9;
      this.lblDescArtist.Text = resources.GetString("lblDescArtist.Text");
      this.lblDescArtist.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnClearA
      // 
      this.btnClearA.BackColor = System.Drawing.SystemColors.Control;
      this.btnClearA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnClearA.Location = new System.Drawing.Point(209, 272);
      this.btnClearA.Name = "btnClearA";
      this.btnClearA.Size = new System.Drawing.Size(184, 24);
      this.btnClearA.TabIndex = 5;
      this.btnClearA.Text = "Clea&r Library";
      this.btnClearA.UseVisualStyleBackColor = false;
      this.btnClearA.Click += new System.EventHandler(this.btnClearA_Click);
      // 
      // btnDeleteA
      // 
      this.btnDeleteA.BackColor = System.Drawing.SystemColors.Control;
      this.btnDeleteA.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnDeleteA.Location = new System.Drawing.Point(209, 240);
      this.btnDeleteA.Name = "btnDeleteA";
      this.btnDeleteA.Size = new System.Drawing.Size(184, 24);
      this.btnDeleteA.TabIndex = 4;
      this.btnDeleteA.Text = "&Delete selected artist";
      this.btnDeleteA.UseVisualStyleBackColor = false;
      this.btnDeleteA.Click += new System.EventHandler(this.btnDelete_Click);
      // 
      // btnAdd
      // 
      this.btnAdd.BackColor = System.Drawing.SystemColors.Control;
      this.btnAdd.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAdd.Location = new System.Drawing.Point(9, 240);
      this.btnAdd.Name = "btnAdd";
      this.btnAdd.Size = new System.Drawing.Size(184, 24);
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "&Add artist to library";
      this.btnAdd.UseVisualStyleBackColor = false;
      this.btnAdd.Click += new System.EventHandler(this.btnAdd_Click);
      // 
      // lblArtistName
      // 
      this.lblArtistName.BackColor = System.Drawing.Color.Transparent;
      this.lblArtistName.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblArtistName.Location = new System.Drawing.Point(9, 192);
      this.lblArtistName.Name = "lblArtistName";
      this.lblArtistName.Size = new System.Drawing.Size(583, 16);
      this.lblArtistName.TabIndex = 1;
      this.lblArtistName.Text = "&New artist name:";
      // 
      // txtArtistName
      // 
      this.txtArtistName.Location = new System.Drawing.Point(8, 208);
      this.txtArtistName.Name = "txtArtistName";
      this.txtArtistName.Size = new System.Drawing.Size(584, 20);
      this.txtArtistName.TabIndex = 2;
      // 
      // btnGetArtistV1
      // 
      this.btnGetArtistV1.BackColor = System.Drawing.SystemColors.Control;
      this.btnGetArtistV1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnGetArtistV1.Location = new System.Drawing.Point(409, 240);
      this.btnGetArtistV1.Name = "btnGetArtistV1";
      this.btnGetArtistV1.Size = new System.Drawing.Size(184, 24);
      this.btnGetArtistV1.TabIndex = 6;
      this.btnGetArtistV1.Text = "Get artists from TAGs Ver. &1";
      this.btnGetArtistV1.UseVisualStyleBackColor = false;
      this.btnGetArtistV1.Click += new System.EventHandler(this.btnGetArtist_Click);
      // 
      // ArtistList
      // 
      this.ArtistList.Location = new System.Drawing.Point(8, 8);
      this.ArtistList.Name = "ArtistList";
      this.ArtistList.Size = new System.Drawing.Size(584, 173);
      this.ArtistList.TabIndex = 8;
      // 
      // btnGetArtistV2
      // 
      this.btnGetArtistV2.BackColor = System.Drawing.SystemColors.Control;
      this.btnGetArtistV2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnGetArtistV2.Location = new System.Drawing.Point(409, 272);
      this.btnGetArtistV2.Name = "btnGetArtistV2";
      this.btnGetArtistV2.Size = new System.Drawing.Size(184, 24);
      this.btnGetArtistV2.TabIndex = 7;
      this.btnGetArtistV2.Text = "Get artists from TAGs Ver. &2";
      this.btnGetArtistV2.UseVisualStyleBackColor = false;
      this.btnGetArtistV2.Click += new System.EventHandler(this.btnGetArtist_Click);
      // 
      // btnClearCommD
      // 
      this.btnClearCommD.BackColor = System.Drawing.SystemColors.Control;
      this.btnClearCommD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnClearCommD.Location = new System.Drawing.Point(408, 237);
      this.btnClearCommD.Name = "btnClearCommD";
      this.btnClearCommD.Size = new System.Drawing.Size(184, 24);
      this.btnClearCommD.TabIndex = 26;
      this.btnClearCommD.Text = "Clea&r Library";
      this.btnClearCommD.UseVisualStyleBackColor = false;
      this.btnClearCommD.Click += new System.EventHandler(this.btnClearCommD_Click);
      // 
      // btnRemoveCommD
      // 
      this.btnRemoveCommD.BackColor = System.Drawing.SystemColors.Control;
      this.btnRemoveCommD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnRemoveCommD.Location = new System.Drawing.Point(208, 237);
      this.btnRemoveCommD.Name = "btnRemoveCommD";
      this.btnRemoveCommD.Size = new System.Drawing.Size(184, 24);
      this.btnRemoveCommD.TabIndex = 25;
      this.btnRemoveCommD.Text = "&Delete selected com. descriptor";
      this.btnRemoveCommD.UseVisualStyleBackColor = false;
      this.btnRemoveCommD.Click += new System.EventHandler(this.btnRemoveCommD_Click);
      // 
      // btnAddCommD
      // 
      this.btnAddCommD.BackColor = System.Drawing.SystemColors.Control;
      this.btnAddCommD.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnAddCommD.Location = new System.Drawing.Point(8, 237);
      this.btnAddCommD.Name = "btnAddCommD";
      this.btnAddCommD.Size = new System.Drawing.Size(184, 24);
      this.btnAddCommD.TabIndex = 24;
      this.btnAddCommD.Text = "&Add com. descriptor to library";
      this.btnAddCommD.UseVisualStyleBackColor = false;
      this.btnAddCommD.Click += new System.EventHandler(this.btnAddCommD_Click);
      // 
      // Label3
      // 
      this.Label3.BackColor = System.Drawing.Color.Transparent;
      this.Label3.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Label3.Location = new System.Drawing.Point(8, 192);
      this.Label3.Name = "Label3";
      this.Label3.Size = new System.Drawing.Size(584, 16);
      this.Label3.TabIndex = 22;
      this.Label3.Text = "&New comment descriptor:";
      // 
      // txtNewCommD
      // 
      this.txtNewCommD.Location = new System.Drawing.Point(8, 208);
      this.txtNewCommD.Name = "txtNewCommD";
      this.txtNewCommD.Size = new System.Drawing.Size(584, 20);
      this.txtNewCommD.TabIndex = 23;
      // 
      // CommDList
      // 
      this.CommDList.Location = new System.Drawing.Point(8, 8);
      this.CommDList.Name = "CommDList";
      this.CommDList.Size = new System.Drawing.Size(584, 173);
      this.CommDList.TabIndex = 27;
      // 
      // lblInfo2
      // 
      this.lblInfo2.BackColor = System.Drawing.Color.Transparent;
      this.lblInfo2.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo2.Location = new System.Drawing.Point(7, 368);
      this.lblInfo2.Name = "lblInfo2";
      this.lblInfo2.Size = new System.Drawing.Size(585, 32);
      this.lblInfo2.TabIndex = 21;
      this.lblInfo2.Text = "Add or remove comment descriptors which will be displayed in the TAG Ver. 2 Edit " +
    "dialogs.";
      this.lblInfo2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(472, 412);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(120, 24);
      this.btnCancel.TabIndex = 21;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      // 
      // btnOK
      // 
      this.btnOK.BackColor = System.Drawing.SystemColors.Control;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(335, 412);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(120, 24);
      this.btnOK.TabIndex = 20;
      this.btnOK.Text = "&OK";
      this.btnOK.UseVisualStyleBackColor = false;
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // Libraries
      // 
      this.Libraries.CanReorderTabs = true;
      this.Libraries.Controls.Add(this.TabControlPanel1);
      this.Libraries.Controls.Add(this.TabControlPanel4);
      this.Libraries.Controls.Add(this.TabControlPanel2);
      this.Libraries.Controls.Add(this.TabControlPanel3);
      this.Libraries.Dock = System.Windows.Forms.DockStyle.Fill;
      this.Libraries.Location = new System.Drawing.Point(0, 0);
      this.Libraries.Name = "Libraries";
      this.Libraries.SelectedTabFont = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold);
      this.Libraries.SelectedTabIndex = 0;
      this.Libraries.Size = new System.Drawing.Size(606, 478);
      this.Libraries.Style = DevComponents.DotNetBar.eTabStripStyle.VS2005Document;
      this.Libraries.TabIndex = 22;
      this.Libraries.TabLayoutType = DevComponents.DotNetBar.eTabLayoutType.FixedWithNavigationBox;
      this.Libraries.Tabs.Add(this.Favourites);
      this.Libraries.Tabs.Add(this.Genre);
      this.Libraries.Tabs.Add(this.Artist);
      this.Libraries.Tabs.Add(this.Comment);
      // 
      // TabControlPanel1
      // 
      this.TabControlPanel1.AntiAlias = true;
      this.TabControlPanel1.Controls.Add(this.btnCancel);
      this.TabControlPanel1.Controls.Add(this.btnAddFavDir);
      this.TabControlPanel1.Controls.Add(this.btnOK);
      this.TabControlPanel1.Controls.Add(this.lblInfo1);
      this.TabControlPanel1.Controls.Add(this.btnFavBrowse);
      this.TabControlPanel1.Controls.Add(this.FavTree);
      this.TabControlPanel1.Controls.Add(this.Label1);
      this.TabControlPanel1.Controls.Add(this.txtName);
      this.TabControlPanel1.Controls.Add(this.btnAddFav);
      this.TabControlPanel1.Controls.Add(this.btnRemoveFav);
      this.TabControlPanel1.Controls.Add(this.Label2);
      this.TabControlPanel1.Controls.Add(this.txtDir);
      this.TabControlPanel1.Controls.Add(this.btnRemoveFavDir);
      this.TabControlPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControlPanel1.Location = new System.Drawing.Point(0, 26);
      this.TabControlPanel1.Name = "TabControlPanel1";
      this.TabControlPanel1.Padding = new System.Windows.Forms.Padding(1);
      this.TabControlPanel1.Size = new System.Drawing.Size(606, 452);
      this.TabControlPanel1.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
      this.TabControlPanel1.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.TabControlPanel1.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
      this.TabControlPanel1.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
      this.TabControlPanel1.Style.GradientAngle = 90;
      this.TabControlPanel1.TabIndex = 1;
      this.TabControlPanel1.TabItem = this.Favourites;
      // 
      // Favourites
      // 
      this.Favourites.AttachedControl = this.TabControlPanel1;
      this.Favourites.Name = "Favourites";
      this.Favourites.Text = "Favourites Library";
      // 
      // TabControlPanel4
      // 
      this.TabControlPanel4.AntiAlias = true;
      this.TabControlPanel4.Controls.Add(this.btnClearCommD);
      this.TabControlPanel4.Controls.Add(this.btnAddCommD);
      this.TabControlPanel4.Controls.Add(this.Label3);
      this.TabControlPanel4.Controls.Add(this.txtNewCommD);
      this.TabControlPanel4.Controls.Add(this.btnRemoveCommD);
      this.TabControlPanel4.Controls.Add(this.CommDList);
      this.TabControlPanel4.Controls.Add(this.lblInfo2);
      this.TabControlPanel4.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControlPanel4.Location = new System.Drawing.Point(0, 26);
      this.TabControlPanel4.Name = "TabControlPanel4";
      this.TabControlPanel4.Padding = new System.Windows.Forms.Padding(1);
      this.TabControlPanel4.Size = new System.Drawing.Size(606, 452);
      this.TabControlPanel4.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
      this.TabControlPanel4.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.TabControlPanel4.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
      this.TabControlPanel4.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
      this.TabControlPanel4.Style.GradientAngle = 90;
      this.TabControlPanel4.TabIndex = 4;
      this.TabControlPanel4.TabItem = this.Comment;
      // 
      // Comment
      // 
      this.Comment.AttachedControl = this.TabControlPanel4;
      this.Comment.Name = "Comment";
      this.Comment.Text = "Comment descriptor Library";
      // 
      // TabControlPanel2
      // 
      this.TabControlPanel2.AntiAlias = true;
      this.TabControlPanel2.Controls.Add(this.txtGenreName);
      this.TabControlPanel2.Controls.Add(this.lblCorres);
      this.TabControlPanel2.Controls.Add(this.chkOnlyOwn);
      this.TabControlPanel2.Controls.Add(this.lblDescGenre);
      this.TabControlPanel2.Controls.Add(this.cmbV2V1);
      this.TabControlPanel2.Controls.Add(this.cmbV1V2);
      this.TabControlPanel2.Controls.Add(this.btnDeleteG);
      this.TabControlPanel2.Controls.Add(this.btnAddG);
      this.TabControlPanel2.Controls.Add(this.lblGenreName);
      this.TabControlPanel2.Controls.Add(this.GenreList);
      this.TabControlPanel2.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControlPanel2.Location = new System.Drawing.Point(0, 26);
      this.TabControlPanel2.Name = "TabControlPanel2";
      this.TabControlPanel2.Padding = new System.Windows.Forms.Padding(1);
      this.TabControlPanel2.Size = new System.Drawing.Size(606, 452);
      this.TabControlPanel2.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
      this.TabControlPanel2.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.TabControlPanel2.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
      this.TabControlPanel2.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
      this.TabControlPanel2.Style.GradientAngle = 90;
      this.TabControlPanel2.TabIndex = 2;
      this.TabControlPanel2.TabItem = this.Genre;
      // 
      // Genre
      // 
      this.Genre.AttachedControl = this.TabControlPanel2;
      this.Genre.Name = "Genre";
      this.Genre.Text = "Genre Library";
      // 
      // TabControlPanel3
      // 
      this.TabControlPanel3.AntiAlias = true;
      this.TabControlPanel3.Controls.Add(this.btnGetArtistV1);
      this.TabControlPanel3.Controls.Add(this.btnClearA);
      this.TabControlPanel3.Controls.Add(this.btnDeleteA);
      this.TabControlPanel3.Controls.Add(this.btnAdd);
      this.TabControlPanel3.Controls.Add(this.ArtistList);
      this.TabControlPanel3.Controls.Add(this.txtArtistName);
      this.TabControlPanel3.Controls.Add(this.lblArtistName);
      this.TabControlPanel3.Controls.Add(this.lblDescArtist);
      this.TabControlPanel3.Controls.Add(this.btnGetArtistV2);
      this.TabControlPanel3.Dock = System.Windows.Forms.DockStyle.Fill;
      this.TabControlPanel3.Location = new System.Drawing.Point(0, 26);
      this.TabControlPanel3.Name = "TabControlPanel3";
      this.TabControlPanel3.Padding = new System.Windows.Forms.Padding(1);
      this.TabControlPanel3.Size = new System.Drawing.Size(606, 452);
      this.TabControlPanel3.Style.BackColor2.Color = System.Drawing.Color.FromArgb(((int)(((byte)(252)))), ((int)(((byte)(252)))), ((int)(((byte)(252)))));
      this.TabControlPanel3.Style.Border = DevComponents.DotNetBar.eBorderType.SingleLine;
      this.TabControlPanel3.Style.BorderColor.Color = System.Drawing.Color.FromArgb(((int)(((byte)(127)))), ((int)(((byte)(157)))), ((int)(((byte)(185)))));
      this.TabControlPanel3.Style.BorderSide = ((DevComponents.DotNetBar.eBorderSide)(((DevComponents.DotNetBar.eBorderSide.Left | DevComponents.DotNetBar.eBorderSide.Right) 
            | DevComponents.DotNetBar.eBorderSide.Bottom)));
      this.TabControlPanel3.Style.GradientAngle = 90;
      this.TabControlPanel3.TabIndex = 3;
      this.TabControlPanel3.TabItem = this.Artist;
      // 
      // Artist
      // 
      this.Artist.AttachedControl = this.TabControlPanel3;
      this.Artist.Name = "Artist";
      this.Artist.Text = "Artist Library";
      // 
      // frmLibraries
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(606, 478);
      this.ControlBox = false;
      this.Controls.Add(this.Libraries);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmLibraries";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Libraries";
      ((System.ComponentModel.ISupportInitialize)(this.Libraries)).EndInit();
      this.Libraries.ResumeLayout(false);
      this.TabControlPanel1.ResumeLayout(false);
      this.TabControlPanel1.PerformLayout();
      this.TabControlPanel4.ResumeLayout(false);
      this.TabControlPanel4.PerformLayout();
      this.TabControlPanel2.ResumeLayout(false);
      this.TabControlPanel2.PerformLayout();
      this.TabControlPanel3.ResumeLayout(false);
      this.TabControlPanel3.PerformLayout();
      this.ResumeLayout(false);

    }

    public frmLibraries(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmLibraries_Load);
      this.vstrPfad = Declarations.objSettings.CurrentPath;
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

    #endregion

    #region Local variables

    private string vstrPfad;

    #endregion

    #region Event handlers

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.txtArtistName.Text.Trim(), "", false) != 0)
      {
        DataRow current;
        var enumerator2 = Declarations.objSettings.Artists.Rows.GetEnumerator();

        while (enumerator2.MoveNext())
        {
          current = (DataRow)enumerator2.Current;
          if (ObjectType.ObjTst(current["Name"], this.txtArtistName.Text.Trim(), false) == 0)
          {
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["DoubleArtist"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Exclamation, null);
            return;
          }
        }

        current = Declarations.objSettings.Artists.NewRow();
        current["Name"] = this.txtArtistName.Text.Trim();
        Declarations.objSettings.Artists.Rows.Add(current);
        LateBinding.LateSetComplex(LateBinding.LateGet(this.ArtistList.Items[0], null, "DataView", new object[0], null, null), null, "Sort", new object[] { "Name" }, null, false, true);

        foreach (DataRowView view in this.ArtistList.Items)
        {
          if (ObjectType.ObjTst(view["Name"], this.txtArtistName.Text.Trim(), false) == 0)
          {
            this.ArtistList.SelectedItem = view;
            break;
          }
        }
      }
    }

    private void btnAddCommD_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.txtNewCommD.Text.Trim(), "", false) != 0)
      {
        DataRow current;
        var enumerator2 = Declarations.objSettings.CommDescriptors.Rows.GetEnumerator();

        while (enumerator2.MoveNext())
        {
          current = (DataRow)enumerator2.Current;
          if (ObjectType.ObjTst(current["Name"], this.txtNewCommD.Text.Trim(), false) == 0)
          {
            Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["DoubleCommD"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Exclamation, null);
            return;
          }
        }

        current = Declarations.objSettings.CommDescriptors.NewRow();
        current["Name"] = this.txtNewCommD.Text.Trim();
        Declarations.objSettings.CommDescriptors.Rows.Add(current);
        LateBinding.LateSetComplex(LateBinding.LateGet(this.CommDList.Items[0], null, "DataView", new object[0], null, null), null, "Sort", new object[] { "Name" }, null, false, true);

        foreach (DataRowView view in this.CommDList.Items)
        {
          if (ObjectType.ObjTst(view["Name"], this.txtNewCommD.Text.Trim(), false) == 0)
          {
            this.CommDList.SelectedItem = view;
            break;
          }
        }
      }
    }

    private void btnAddFav_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.txtName.Text, "", false) != 0)
      {
        foreach (TreeNode node2 in this.FavTree.Nodes)
          if (StringType.StrCmp(node2.Text, this.txtName.Text, false) == 0)
            return;

        TreeNode node = new TreeNode(this.txtName.Text);
        this.FavTree.Nodes.Add(node);
        this.FavTree.SelectedNode = node;
      }
    }

    private void btnAddFavDir_Click(object sender, EventArgs e)
    {
      if (this.FavTree.SelectedNode != null)
      {
        if (this.FavTree.SelectedNode.Parent != null)
          this.FavTree.SelectedNode = this.FavTree.SelectedNode.Parent;

        if (Directory.Exists(this.txtDir.Text.Trim()))
        {
          foreach (TreeNode node in this.FavTree.SelectedNode.Nodes)
            if (StringType.StrCmp(node.Text, this.txtName.Text, false) == 0)
              return;

          TreeNode node2 = new TreeNode { Text = this.txtDir.Text.Trim() };
          this.FavTree.SelectedNode.Nodes.Add(node2);
          this.FavTree.SelectedNode.Expand();
        }
      }
    }

    private void btnAddG_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.txtGenreName.Text.Trim(), "", false) != 0)
      {
        try
        {
          DataRow row = Declarations.objSettings.Genres.NewRow();
          row["Name"] = this.txtGenreName.Text.Trim();
          row["V1V2"] = ID3Functions.GetV1GenreByName(this.cmbV1V2.SelectedItem.ToString());
          row["V2V1"] = ID3Functions.GetV1GenreByName(this.cmbV2V1.SelectedItem.ToString());
          Declarations.objSettings.Genres.Rows.Add(row);

          ListViewItem item = new ListViewItem(this.txtGenreName.Text.Trim())
          {
            SubItems = { this.cmbV1V2.SelectedItem.ToString(), this.cmbV2V1.SelectedItem.ToString() }
          };

          this.GenreList.Items.Add(item);
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);

          foreach (DataRow row in Declarations.objSettings.Genres.Rows)
            if (ObjectType.ObjTst(row["Name"], this.txtGenreName.Text.Trim(), false) == 0)
            {
              row["V1V2"] = ID3Functions.GetV1GenreByName(this.cmbV1V2.SelectedItem.ToString());
              row["V2V1"] = ID3Functions.GetV1GenreByName(this.cmbV2V1.SelectedItem.ToString());
              break;
            }

          foreach (ListViewItem item2 in this.GenreList.Items)
            if (StringType.StrCmp(item2.Text, this.txtGenreName.Text.Trim(), false) == 0)
            {
              item2.SubItems[this.colHV1V2.Index].Text = this.cmbV1V2.SelectedItem.ToString();
              item2.SubItems[this.colHV2V1.Index].Text = this.cmbV2V1.SelectedItem.ToString();
              break;
            }

          ProjectData.ClearProjectError();
        }
      }

      this.txtGenreName.Text = "";
      this.cmbV1V2.SelectedIndex = 0;
      this.cmbV2V1.SelectedIndex = 0;
    }

    private void btnClearA_Click(object sender, EventArgs e)
    {
      this.ArtistList.DataSource = null;
      Declarations.objSettings.Artists.Rows.Clear();
      this.ArtistList.DataSource = Declarations.objSettings.Artists;
      this.ArtistList.DisplayMember = "Name";
      this.ArtistList.ValueMember = Declarations.objSettings.Artists.Columns["Name"].ToString();
    }

    private void btnClearCommD_Click(object sender, EventArgs e)
    {
      this.CommDList.DataSource = null;
      Declarations.objSettings.CommDescriptors.Rows.Clear();
      this.CommDList.DataSource = Declarations.objSettings.CommDescriptors;
      this.CommDList.DisplayMember = "Name";
      this.CommDList.ValueMember = Declarations.objSettings.CommDescriptors.Columns["Name"].ToString();
    }

    private void btnDelete_Click(object sender, EventArgs e)
    {
      ((DataRowView)this.ArtistList.SelectedItem).Delete();
    }

    private void btnDeleteG_Click(object sender, EventArgs e)
    {
      if (this.GenreList.FocusedItem != null)
        foreach (DataRow row in Declarations.objSettings.Genres.Rows)
          if (ObjectType.ObjTst(row["Name"], this.GenreList.FocusedItem.Text, false) == 0)
          {
            Declarations.objSettings.Genres.Rows.Remove(row);
            break;
          }

      this.GenreList.Items.Remove(this.GenreList.FocusedItem);
    }

    private void btnFavBrowse_Click(object sender, EventArgs e)
    {
      string vstrPfad = this.vstrPfad;
      this.FolderBrowserDialog.Description = "";
      this.FolderBrowserDialog.SelectedPath = vstrPfad;

      if (this.FolderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
      {
        this.vstrPfad = this.FolderBrowserDialog.SelectedPath;
        this.txtDir.Text = this.vstrPfad;
      }
    }

    private void btnGetArtist_Click(object sender, EventArgs e)
    {
      frmProgress.Callback callback;
      Form form;
      ArrayList list = new ArrayList();
      this.ArtistList.Enabled = false;
      this.ArtistList.DataSource = null;

      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
        list.Add(RuntimeHelpers.GetObjectValue(row["Name"]));

      Declarations.objSettings.Artists.Rows.Clear();

      if (ObjectType.ObjTst(LateBinding.LateGet(sender, null, "Name", new object[0], null, null), this.btnGetArtistV1.Name, false) == 0)
      {
        form = this;
        callback = new frmProgress.Callback(this.V1CB);

        frmProgress progress2 = new frmProgress(0, Declarations.MP3s.Count, 1, ref form, ref callback)
        {
          btnCancel = { Enabled = false },
          List = list
        };

        progress2.SetStateGetArtists();
        progress2.ShowDialog(this);
      }

      if (ObjectType.ObjTst(LateBinding.LateGet(sender, null, "Name", new object[0], null, null), this.btnGetArtistV2.Name, false) == 0)
      {
        form = this;
        callback = new frmProgress.Callback(this.V2CB);

        frmProgress progress3 = new frmProgress(0, Declarations.MP3s.Count, 1, ref form, ref callback)
        {
          btnCancel = { Enabled = false },
          List = list
        };

        progress3.SetStateGetArtists();
        progress3.ShowDialog(this);
      }

      list.Sort();
      form = this;
      callback = new frmProgress.Callback(this.LibCB);

      frmProgress progress = new frmProgress(0, list.Count, 1, ref form, ref callback)
      {
        List = list
      };

      progress.SetStateCreateLib();
      progress.ShowDialog(this);
      this.ArtistList.DataSource = Declarations.objSettings.Artists;
      this.ArtistList.DisplayMember = "Name";
      this.ArtistList.ValueMember = Declarations.objSettings.Artists.Columns["Name"].ToString();
      this.ArtistList.Enabled = true;
      this.ArtistList.Refresh();
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      Declarations.objSettings.FavNodes.Clear();

      foreach (TreeNode node in this.FavTree.Nodes)
        Declarations.objSettings.FavNodes.Add(node);

      this.MainForm.FavTree.BeginUpdate();
      this.MainForm.FavTree.Nodes.Clear();

      foreach (TreeNode node in Declarations.objSettings.FavNodes)
        LateBinding.LateCall(this.MainForm.FavTree.Nodes, null, "Add", new object[] { RuntimeHelpers.GetObjectValue(node.Clone()) }, null, null);

      this.MainForm.FavTree.EndUpdate();
      ArrayList list = new ArrayList();
      ArrayList list2 = new ArrayList();
      Declarations.objSettings.OwnGenreOnly = this.chkOnlyOwn.Checked;

      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
        list.Add(RuntimeHelpers.GetObjectValue(row["Name"]));

      list.Sort();
      this.ArtistList.Enabled = false;
      this.ArtistList.DataSource = null;

      foreach (DataRow row in Declarations.objSettings.CommDescriptors.Rows)
        list2.Add(RuntimeHelpers.GetObjectValue(row["Name"]));

      list2.Sort();
      this.CommDList.Enabled = false;
      this.CommDList.DataSource = null;
      Declarations.objSettings.Artists.Rows.Clear();
      Declarations.objSettings.CommDescriptors.Rows.Clear();
      Declarations.objSettings.Genres.Rows.Clear();
      form = this;

      frmProgress.Callback cB = new frmProgress.Callback(this.ArtistCB);
      frmProgress progress = new frmProgress(0, list.Count, 1, ref form, ref cB)      {        btnCancel = { Enabled = false }      };

      progress.SetStateSaveLib();
      progress.List = list;
      progress.ShowDialog(this);
      Application.DoEvents();
      form = this;
      cB = new frmProgress.Callback(this.GenreCB);
      frmProgress progress2 = new frmProgress(0, this.GenreList.Items.Count, 1, ref form, ref cB)      {        btnCancel = { Enabled = false }      };

      progress2.SetStateSaveLib();
      progress2.ShowDialog(this);
      Application.DoEvents();
      form = this;
      cB = new frmProgress.Callback(this.CommDCB);
      frmProgress progress3 = new frmProgress(0, list2.Count, 1, ref form, ref cB)      {        btnCancel = { Enabled = false }      };

      progress3.SetStateSaveLib();
      progress3.List = list2;
      progress3.ShowDialog(this);
      this.MainForm.cmbArtist.Items.Clear();

      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
        this.MainForm.cmbArtist.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));      

      this.Close();
    }

    private void btnRemoveCommD_Click(object sender, EventArgs e)
    {
      ((DataRowView)this.CommDList.SelectedItem).Delete();
    }

    private void btnRemoveFav_Click(object sender, EventArgs e)
    {
      if ((this.FavTree.SelectedNode != null) && (this.FavTree.SelectedNode.Parent == null))
        this.FavTree.Nodes.Remove(this.FavTree.SelectedNode);
    }

    private void btnRemoveFavDir_Click(object sender, EventArgs e)
    {
      if ((this.FavTree.SelectedNode != null) && (this.FavTree.SelectedNode.Parent != null))
        this.FavTree.Nodes.Remove(this.FavTree.SelectedNode);
    }

    private void frmLibraries_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);

      foreach (TreeNode node in Declarations.objSettings.FavNodes)
        LateBinding.LateCall(this.FavTree.Nodes, null, "Add", new object[] { RuntimeHelpers.GetObjectValue(node.Clone()) }, null, null);

      this.chkOnlyOwn.Checked = Declarations.objSettings.OwnGenreOnly;
      this.cmbV1V2.Items.Add("< undefined >");
      this.cmbV2V1.Items.Add("< undefined >");
      byte upperBound = (byte)Declarations.astrGenreLookup.GetUpperBound(0);

      for (byte i = 0; i <= upperBound; i = (byte)(i + 1))
      {
        this.cmbV1V2.Items.Add(Declarations.astrGenreLookup[i]);
        this.cmbV2V1.Items.Add(Declarations.astrGenreLookup[i]);
      }

      this.cmbV1V2.Sorted = true;
      this.cmbV1V2.SelectedIndex = 0;
      this.cmbV2V1.Sorted = true;
      this.cmbV2V1.SelectedIndex = 0;
      this.ArtistList.DataSource = Declarations.objSettings.Artists;
      this.ArtistList.DisplayMember = "Name";
      this.ArtistList.ValueMember = Declarations.objSettings.Artists.Columns["Name"].ToString();
      this.CommDList.DataSource = Declarations.objSettings.CommDescriptors;
      this.CommDList.DisplayMember = "Name";
      this.CommDList.ValueMember = Declarations.objSettings.CommDescriptors.Columns["Name"].ToString();
      this.GenreList.Columns[0].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol01"]);
      this.GenreList.Columns[1].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol02"]);
      this.GenreList.Columns[2].Text = StringType.FromObject(Declarations.objResources.ResStrings["DialogCol03"]);

      foreach (DataRow row in Declarations.objSettings.Genres.Rows)
      {
        ListViewItem item = new ListViewItem(row["Name"].ToString());

        if (ObjectType.ObjTst(row["V1V2"], 0x94, false) < 0)
          item.SubItems.Add(Declarations.astrGenreLookup[IntegerType.FromObject(row["V1V2"])]);
        else
          item.SubItems.Add("< undefined >");

        if (ObjectType.ObjTst(row["V2V1"], 0x94, false) < 0)
          item.SubItems.Add(Declarations.astrGenreLookup[IntegerType.FromObject(row["V2V1"])]);
        else
          item.SubItems.Add("< undefined >");

        this.GenreList.Items.Add(item);
      }
      this.AddToolTips();
    }

    private void GenreList_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.txtGenreName.Text = this.GenreList.FocusedItem.Text;
      this.cmbV1V2.Text = this.GenreList.FocusedItem.SubItems[this.colHV1V2.Index].Text;
      this.cmbV2V1.Text = this.GenreList.FocusedItem.SubItems[this.colHV2V1.Index].Text;
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmLibraries";
      Control txtDir = this.txtDir;
      this.txtDir = (TextBox)txtDir;
      this.ToolTip.SetToolTip(this.txtDir, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.txtName;
      this.txtName = (TextBox)txtDir;
      this.ToolTip.SetToolTip(this.txtName, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.chkOnlyOwn;
      this.chkOnlyOwn = (CheckBox)txtDir;
      this.ToolTip.SetToolTip(this.chkOnlyOwn, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.cmbV2V1;
      this.cmbV2V1 = (ComboBox)txtDir;
      this.ToolTip.SetToolTip(this.cmbV2V1, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.cmbV1V2;
      this.cmbV1V2 = (ComboBox)txtDir;
      this.ToolTip.SetToolTip(this.cmbV1V2, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnDeleteG;
      this.btnDeleteG = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnDeleteG, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnAddG;
      this.btnAddG = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnAddG, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.txtGenreName;
      this.txtGenreName = (TextBox)txtDir;
      this.ToolTip.SetToolTip(this.txtGenreName, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.GenreList;
      this.GenreList = (ListView)txtDir;
      this.ToolTip.SetToolTip(this.GenreList, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnClearA;
      this.btnClearA = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnClearA, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnDeleteA;
      this.btnDeleteA = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnDeleteA, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnAdd;
      this.btnAdd = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnAdd, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.txtArtistName;
      this.txtArtistName = (TextBox)txtDir;
      this.ToolTip.SetToolTip(this.txtArtistName, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnGetArtistV1;
      this.btnGetArtistV1 = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnGetArtistV1, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.ArtistList;
      this.ArtistList = (ListBox)txtDir;
      this.ToolTip.SetToolTip(this.ArtistList, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnGetArtistV2;
      this.btnGetArtistV2 = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnGetArtistV2, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnClearCommD;
      this.btnClearCommD = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnClearCommD, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnRemoveCommD;
      this.btnRemoveCommD = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnRemoveCommD, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.btnAddCommD;
      this.btnAddCommD = (Button)txtDir;
      this.ToolTip.SetToolTip(this.btnAddCommD, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.txtNewCommD;
      this.txtNewCommD = (TextBox)txtDir;
      this.ToolTip.SetToolTip(this.txtNewCommD, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));

      vstrName = "frmLibraries";
      txtDir = this.CommDList;
      this.CommDList = (ListBox)txtDir;
      this.ToolTip.SetToolTip(this.CommDList, Declarations.objResources.GetToolTip(ref vstrName, ref txtDir));
    }

    private void ArtistCB(ref frmProgress frmProg)
    {
      IEnumerator enumerator = null;

      try
      {
        enumerator = frmProg.List.GetEnumerator();

        while (enumerator.MoveNext())
        {
          string str = StringType.FromObject(enumerator.Current);
          DataRow row = Declarations.objSettings.Artists.NewRow();
          row["Name"] = str;

          try
          {
            Declarations.objSettings.Artists.Rows.Add(row);
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
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

    private void CommDCB(ref frmProgress frmProg)
    {
      IEnumerator enumerator = null;

      try
      {
        enumerator = frmProg.List.GetEnumerator();

        while (enumerator.MoveNext())
        {
          string str = StringType.FromObject(enumerator.Current);
          DataRow row = Declarations.objSettings.CommDescriptors.NewRow();
          row["Name"] = str;

          try
          {
            Declarations.objSettings.CommDescriptors.Rows.Add(row);
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
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

    private void GenreCB(ref frmProgress frmProg)
    {
      IEnumerator enumerator = null;

      try
      {
        enumerator = this.GenreList.Items.GetEnumerator();

        while (enumerator.MoveNext())
        {
          ListViewItem current = (ListViewItem)enumerator.Current;
          DataRow row = Declarations.objSettings.Genres.NewRow();
          row["Name"] = current.Text;
          row["V1V2"] = ID3Functions.GetV1GenreByName(current.SubItems[this.colHV1V2.Index].Text);
          row["V2V1"] = ID3Functions.GetV1GenreByName(current.SubItems[this.colHV2V1.Index].Text);
          Declarations.objSettings.Genres.Rows.Add(row);
          frmProg.ProgressBar.PerformStep();
        }
      }
      finally
      {
        if (enumerator is IDisposable)
          ((IDisposable)enumerator).Dispose();
      }
    }

    private void LibCB(ref frmProgress frmProg)
    {
      var enumerator = frmProg.List.GetEnumerator();

      while (enumerator.MoveNext())
      {
        string sLeft = StringType.FromObject(enumerator.Current);
        Application.DoEvents();

        if (frmProg.Canceled)
          return;

        if (StringType.StrCmp(sLeft, "", false) != 0)
        {
          DataRow row = Declarations.objSettings.Artists.NewRow();
          row["Name"] = sLeft;

          try
          {
            Declarations.objSettings.Artists.Rows.Add(row);
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }
        }

        frmProg.ProgressBar.PerformStep();
      }
    }

    private void V1CB(ref frmProgress frmProg)
    {
      IEnumerator enumerator = null;

      try
      {
        enumerator = Declarations.MP3s.GetEnumerator();

        while (enumerator.MoveNext())
        {
          MP3 current = (MP3)enumerator.Current;

          if (current.V1TAG.TAGPresent && !frmProg.List.Contains(current.V1TAG.Artist))
            frmProg.List.Add(current.V1TAG.Artist);

          frmProg.ProgressBar.PerformStep();
        }
      }
      finally
      {
        if (enumerator is IDisposable)
          ((IDisposable)enumerator).Dispose();
      }
    }

    private void V2CB(ref frmProgress frmProg)
    {
      IEnumerator enumerator = null;

      try
      {
        enumerator = Declarations.MP3s.GetEnumerator();

        while (enumerator.MoveNext())
        {
          MP3 current = (MP3)enumerator.Current;

          if (current.V2TAG.TAGHeaderPresent && current.V2TAG.FrameExists("TPE1"))
          {
            object objectValue = RuntimeHelpers.GetObjectValue(current.V2TAG.GetFrame("TPE1"));

            if (!frmProg.List.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null))))
              frmProg.List.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)));
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

    #endregion
  }
}