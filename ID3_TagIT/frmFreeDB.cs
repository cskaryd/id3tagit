using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Net;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmFreeDB : Form
  {
    #region Designer

    private Button btnCancel;
    private Button btnClose;
    private Button btnQuery;
    private Button btnSearch;
    private Button btnWrite;
    private CheckBox chkArtist;
    private CheckBox chkArtistExact;
    private CheckBox chkComplete;
    private CheckBox chkTitle;
    private CheckBox chkTrack;
    private CheckBox chkWrite1;
    private CheckBox chkWrite2;
    private GroupBox grpSearchFile;
    private GroupBox grpSearchWord;
    private GroupBox grpStatus;
    private Label lblInfo;
    private Label lblSearchWord;
    private RadioButton optSingleArtist;
    private RadioButton optVariousArtist;
    private GroupBox pnlWrite;
    private TreeView ResultTree;
    private Label Status;
    private System.Windows.Forms.ToolTip ToolTip;
    private TextBox txtSearch;
    public ArrayList alstFilesToTAG;
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
      this.lblInfo = new System.Windows.Forms.Label();
      this.btnQuery = new System.Windows.Forms.Button();
      this.Status = new System.Windows.Forms.Label();
      this.ResultTree = new System.Windows.Forms.TreeView();
      this.btnClose = new System.Windows.Forms.Button();
      this.pnlWrite = new System.Windows.Forms.GroupBox();
      this.btnWrite = new System.Windows.Forms.Button();
      this.chkWrite2 = new System.Windows.Forms.CheckBox();
      this.chkWrite1 = new System.Windows.Forms.CheckBox();
      this.optVariousArtist = new System.Windows.Forms.RadioButton();
      this.optSingleArtist = new System.Windows.Forms.RadioButton();
      this.chkTrack = new System.Windows.Forms.CheckBox();
      this.chkTitle = new System.Windows.Forms.CheckBox();
      this.btnSearch = new System.Windows.Forms.Button();
      this.txtSearch = new System.Windows.Forms.TextBox();
      this.btnCancel = new System.Windows.Forms.Button();
      this.grpStatus = new System.Windows.Forms.GroupBox();
      this.grpSearchWord = new System.Windows.Forms.GroupBox();
      this.chkArtistExact = new System.Windows.Forms.CheckBox();
      this.chkArtist = new System.Windows.Forms.CheckBox();
      this.chkComplete = new System.Windows.Forms.CheckBox();
      this.grpSearchFile = new System.Windows.Forms.GroupBox();
      this.lblSearchWord = new System.Windows.Forms.Label();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.pnlWrite.SuspendLayout();
      this.grpStatus.SuspendLayout();
      this.grpSearchWord.SuspendLayout();
      this.grpSearchFile.SuspendLayout();
      this.SuspendLayout();
      // 
      // lblInfo
      // 
      this.lblInfo.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblInfo.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(8, 480);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(536, 24);
      this.lblInfo.TabIndex = 3;
      this.lblInfo.Text = "With this function you can query FreeDB for information. For connection settings " +
    "go to the preferences.";
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // btnQuery
      // 
      this.btnQuery.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnQuery.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnQuery.Location = new System.Drawing.Point(8, 96);
      this.btnQuery.Name = "btnQuery";
      this.btnQuery.Size = new System.Drawing.Size(232, 24);
      this.btnQuery.TabIndex = 1;
      this.btnQuery.Text = "Start search by files";
      this.btnQuery.Click += new System.EventHandler(this.btnQuery_Click);
      // 
      // Status
      // 
      this.Status.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.Status.Location = new System.Drawing.Point(8, 24);
      this.Status.Name = "Status";
      this.Status.Size = new System.Drawing.Size(232, 40);
      this.Status.TabIndex = 13;
      // 
      // ResultTree
      // 
      this.ResultTree.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.ResultTree.Indent = 19;
      this.ResultTree.ItemHeight = 16;
      this.ResultTree.Location = new System.Drawing.Point(8, 256);
      this.ResultTree.Name = "ResultTree";
      this.ResultTree.Size = new System.Drawing.Size(656, 216);
      this.ResultTree.TabIndex = 5;
      this.ResultTree.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.ResultTree_AfterSelect);
      // 
      // btnClose
      // 
      this.btnClose.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
      this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnClose.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnClose.Location = new System.Drawing.Point(552, 480);
      this.btnClose.Name = "btnClose";
      this.btnClose.Size = new System.Drawing.Size(112, 24);
      this.btnClose.TabIndex = 6;
      this.btnClose.Text = "Close";
      this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
      // 
      // pnlWrite
      // 
      this.pnlWrite.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.pnlWrite.Controls.Add(this.btnWrite);
      this.pnlWrite.Controls.Add(this.chkWrite2);
      this.pnlWrite.Controls.Add(this.chkWrite1);
      this.pnlWrite.Controls.Add(this.optVariousArtist);
      this.pnlWrite.Controls.Add(this.optSingleArtist);
      this.pnlWrite.Enabled = false;
      this.pnlWrite.Location = new System.Drawing.Point(264, 144);
      this.pnlWrite.Name = "pnlWrite";
      this.pnlWrite.Size = new System.Drawing.Size(400, 104);
      this.pnlWrite.TabIndex = 4;
      this.pnlWrite.TabStop = false;
      this.pnlWrite.Text = "Where should the selected information be stored?";
      // 
      // btnWrite
      // 
      this.btnWrite.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnWrite.Location = new System.Drawing.Point(8, 72);
      this.btnWrite.Name = "btnWrite";
      this.btnWrite.Size = new System.Drawing.Size(384, 24);
      this.btnWrite.TabIndex = 14;
      this.btnWrite.Text = "Write information";
      this.btnWrite.Click += new System.EventHandler(this.btnWrite_Click);
      // 
      // chkWrite2
      // 
      this.chkWrite2.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkWrite2.Location = new System.Drawing.Point(200, 48);
      this.chkWrite2.Name = "chkWrite2";
      this.chkWrite2.Size = new System.Drawing.Size(192, 16);
      this.chkWrite2.TabIndex = 13;
      this.chkWrite2.Text = "Write information into TAG Ver. 2";
      // 
      // chkWrite1
      // 
      this.chkWrite1.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkWrite1.Location = new System.Drawing.Point(200, 24);
      this.chkWrite1.Name = "chkWrite1";
      this.chkWrite1.Size = new System.Drawing.Size(192, 16);
      this.chkWrite1.TabIndex = 12;
      this.chkWrite1.Text = "Write information into TAG Ver. 1";
      // 
      // optVariousArtist
      // 
      this.optVariousArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optVariousArtist.Location = new System.Drawing.Point(16, 48);
      this.optVariousArtist.Name = "optVariousArtist";
      this.optVariousArtist.Size = new System.Drawing.Size(176, 16);
      this.optVariousArtist.TabIndex = 11;
      this.optVariousArtist.Text = "Album of various artists";
      // 
      // optSingleArtist
      // 
      this.optSingleArtist.Checked = true;
      this.optSingleArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.optSingleArtist.Location = new System.Drawing.Point(16, 24);
      this.optSingleArtist.Name = "optSingleArtist";
      this.optSingleArtist.Size = new System.Drawing.Size(176, 16);
      this.optSingleArtist.TabIndex = 10;
      this.optSingleArtist.TabStop = true;
      this.optSingleArtist.Text = "Album of single artist";
      // 
      // chkTrack
      // 
      this.chkTrack.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkTrack.Location = new System.Drawing.Point(296, 48);
      this.chkTrack.Name = "chkTrack";
      this.chkTrack.Size = new System.Drawing.Size(96, 16);
      this.chkTrack.TabIndex = 5;
      this.chkTrack.Text = "Track";
      // 
      // chkTitle
      // 
      this.chkTitle.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkTitle.Location = new System.Drawing.Point(176, 48);
      this.chkTitle.Name = "chkTitle";
      this.chkTitle.Size = new System.Drawing.Size(104, 16);
      this.chkTitle.TabIndex = 4;
      this.chkTitle.Text = "Title";
      // 
      // btnSearch
      // 
      this.btnSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.btnSearch.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnSearch.Location = new System.Drawing.Point(8, 96);
      this.btnSearch.Name = "btnSearch";
      this.btnSearch.Size = new System.Drawing.Size(384, 24);
      this.btnSearch.TabIndex = 8;
      this.btnSearch.Text = "Start search by words";
      this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
      // 
      // txtSearch
      // 
      this.txtSearch.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.txtSearch.Location = new System.Drawing.Point(8, 16);
      this.txtSearch.Name = "txtSearch";
      this.txtSearch.Size = new System.Drawing.Size(384, 20);
      this.txtSearch.TabIndex = 0;
      this.txtSearch.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txtSearch_KeyUp);
      // 
      // btnCancel
      // 
      this.btnCancel.Enabled = false;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(8, 72);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(232, 24);
      this.btnCancel.TabIndex = 8;
      this.btnCancel.Text = "Cancel connection";
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // grpStatus
      // 
      this.grpStatus.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpStatus.Controls.Add(this.btnCancel);
      this.grpStatus.Controls.Add(this.Status);
      this.grpStatus.Location = new System.Drawing.Point(8, 144);
      this.grpStatus.Name = "grpStatus";
      this.grpStatus.Size = new System.Drawing.Size(248, 104);
      this.grpStatus.TabIndex = 3;
      this.grpStatus.TabStop = false;
      this.grpStatus.Text = "Status ... ";
      // 
      // grpSearchWord
      // 
      this.grpSearchWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpSearchWord.Controls.Add(this.chkArtistExact);
      this.grpSearchWord.Controls.Add(this.chkArtist);
      this.grpSearchWord.Controls.Add(this.chkComplete);
      this.grpSearchWord.Controls.Add(this.chkTitle);
      this.grpSearchWord.Controls.Add(this.btnSearch);
      this.grpSearchWord.Controls.Add(this.chkTrack);
      this.grpSearchWord.Controls.Add(this.txtSearch);
      this.grpSearchWord.Location = new System.Drawing.Point(8, 8);
      this.grpSearchWord.Name = "grpSearchWord";
      this.grpSearchWord.Size = new System.Drawing.Size(400, 128);
      this.grpSearchWord.TabIndex = 0;
      this.grpSearchWord.TabStop = false;
      this.grpSearchWord.Text = "Search by words ";
      // 
      // chkArtistExact
      // 
      this.chkArtistExact.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkArtistExact.Location = new System.Drawing.Point(16, 72);
      this.chkArtistExact.Name = "chkArtistExact";
      this.chkArtistExact.Size = new System.Drawing.Size(152, 16);
      this.chkArtistExact.TabIndex = 6;
      this.chkArtistExact.Text = "Exact artist search";
      this.chkArtistExact.CheckedChanged += new System.EventHandler(this.chkArtistEact_CheckedChanged);
      // 
      // chkArtist
      // 
      this.chkArtist.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkArtist.Location = new System.Drawing.Point(16, 48);
      this.chkArtist.Name = "chkArtist";
      this.chkArtist.Size = new System.Drawing.Size(152, 16);
      this.chkArtist.TabIndex = 3;
      this.chkArtist.Text = "Artist";
      this.chkArtist.CheckedChanged += new System.EventHandler(this.chkArtistEact_CheckedChanged);
      // 
      // chkComplete
      // 
      this.chkComplete.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkComplete.Location = new System.Drawing.Point(176, 72);
      this.chkComplete.Name = "chkComplete";
      this.chkComplete.Size = new System.Drawing.Size(208, 16);
      this.chkComplete.TabIndex = 7;
      this.chkComplete.Text = "Match complete search string";
      // 
      // grpSearchFile
      // 
      this.grpSearchFile.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.grpSearchFile.Controls.Add(this.lblSearchWord);
      this.grpSearchFile.Controls.Add(this.btnQuery);
      this.grpSearchFile.Location = new System.Drawing.Point(416, 8);
      this.grpSearchFile.Name = "grpSearchFile";
      this.grpSearchFile.Size = new System.Drawing.Size(248, 128);
      this.grpSearchFile.TabIndex = 1;
      this.grpSearchFile.TabStop = false;
      this.grpSearchFile.Text = "Search by selected files ";
      // 
      // lblSearchWord
      // 
      this.lblSearchWord.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
      this.lblSearchWord.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblSearchWord.Location = new System.Drawing.Point(8, 24);
      this.lblSearchWord.Name = "lblSearchWord";
      this.lblSearchWord.Size = new System.Drawing.Size(232, 56);
      this.lblSearchWord.TabIndex = 3;
      this.lblSearchWord.Text = "ID3-TagIT will try to find the CDs that match the selected MP3 files. So it is ne" +
    "ssesary for a successful search to select all files of the album in the correct order.";
      this.lblSearchWord.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // frmFreeDB
      // 
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnClose;
      this.ClientSize = new System.Drawing.Size(666, 528);
      this.ControlBox = false;
      this.Controls.Add(this.grpSearchFile);
      this.Controls.Add(this.grpSearchWord);
      this.Controls.Add(this.grpStatus);
      this.Controls.Add(this.btnClose);
      this.Controls.Add(this.pnlWrite);
      this.Controls.Add(this.ResultTree);
      this.Controls.Add(this.lblInfo);
      this.MaximumSize = new System.Drawing.Size(682, 1600);
      this.MinimumSize = new System.Drawing.Size(682, 544);
      this.Name = "frmFreeDB";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "FreeDB";
      this.pnlWrite.ResumeLayout(false);
      this.grpStatus.ResumeLayout(false);
      this.grpSearchWord.ResumeLayout(false);
      this.grpSearchWord.PerformLayout();
      this.grpSearchFile.ResumeLayout(false);
      this.ResumeLayout(false);

    }

    public frmFreeDB(frmMain frmM)
    {
      base.Load += new EventHandler(this.frmFreeDB_Load);
      this.alstFilesToTAG = new ArrayList();
      this.vbooCancel = false;
      this.InitializeComponent();
      this.MainForm = frmM;
    }

    #endregion

    #region Local variables

    private ID3_TagIT.FreeDB FreeDB;
    private bool vbooCancel;

    [StructLayout(LayoutKind.Sequential)]
    private struct Result
    {
      public string Artist;
      public string Album;
      public ArrayList Tracks;
      public string Year;
      public string Genre;
    }

    #endregion

    #region Events

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.vbooCancel = true;
      this.btnCancel.Enabled = false;
      this.btnClose.Enabled = true;
    }

    private void btnClose_Click(object sender, EventArgs e)
    {
      this.Close();
    }

    private void btnQuery_Click(object sender, EventArgs e)
    {
      this.pnlWrite.Enabled = false;
      this.btnClose.Enabled = false;
      this.btnSearch.Enabled = false;
      this.btnQuery.Enabled = false;
      this.btnCancel.Enabled = true;
      string str4 = "";
      int[] tracksLength = new int[(this.MainForm.MP3View.SelectedItems.Count - 1) + 1];
      ArrayList returnedMatches = new ArrayList();
      this.FreeDB = new ID3_TagIT.FreeDB(Declarations.objSettings.FreeDBUser, "www.id3-tagit.de", "ID3-TagIT", Application.ProductVersion.ToString(), Declarations.objSettings.FreeDBServer, Declarations.objSettings.FreeDBPort);

      int num2 = this.MainForm.MP3View.SelectedItems.Count - 1;

      for (int i = 0; i <= num2; i++)
      {
        MP3 tag = (MP3)this.MainForm.MP3View.SelectedItems[i].Tag;
        tracksLength[i] = tag.Duration;
      }

      string discID = this.FreeDB.HTMLCalcDiskID(tracksLength);
      Application.DoEvents();
      this.Status.Text = StringType.FromObject(Declarations.objResources.ResStrings["Querying"]);
      bool flag = false;
      this.ResultTree.Nodes.Clear();

      switch (this.FreeDB.HTMLQuery(discID, tracksLength, ref returnedMatches))
      {
        case ID3_TagIT.FreeDB.FreeDBQueryResult.FoundExactMatch:
        case ID3_TagIT.FreeDB.FreeDBQueryResult.FoundInexactMatches:
          foreach (ID3_TagIT.FreeDB.FreeDBQueryItem item in returnedMatches)
          {
            string str = null;
            string str2 = null;
            string str5;
            string str6 = null;
            Application.DoEvents();

            if (this.vbooCancel)
            {
              this.vbooCancel = false;
              break;
            }

            ArrayList returnedTracks = new ArrayList();
            str4 = this.FreeDB.HTMLRead(item.Category, item.DiscID, ref str2, ref str, ref returnedTracks, ref str6) + "\r\n";

            Result result = new Result
            {
              Artist = str2,
              Album = str,
              Tracks = (ArrayList)returnedTracks.Clone(),
              Year = str6,
              Genre = Strings.StrConv(item.Category, VbStrConv.ProperCase, 0)
            };

            bool flag2 = false;

            foreach (TreeNode node in this.ResultTree.Nodes)
            {
              if (StringType.StrCmp(node.Text, str2.Trim(new char[] { ' ' }), false) == 0)
              {
                TreeNode node3 = node;
                TreeNode node2 = new TreeNode
                {
                  Text = str.Trim(new char[] { ' ' }),
                  Tag = result
                };

                var enumerator2 = returnedTracks.GetEnumerator();

                while (enumerator2.MoveNext())
                {
                  str5 = StringType.FromObject(enumerator2.Current);
                  node2.Nodes.Add(str5.Trim(new char[] { ' ' }));
                }

                if (returnedTracks.Count > 0)
                {
                  flag2 = true;
                  node3.Nodes.Add(node2);
                  flag = true;
                }

                node3.Expand();
              }

              if (flag2)
                break;
            }

            if (!flag2)
            {
              TreeNode node5 = new TreeNode { Text = str2.Trim(new char[] { ' ' }) };
              TreeNode node4 = new TreeNode { Text = str.Trim(new char[] { ' ' }), Tag = result };

              var enumerator = returnedTracks.GetEnumerator();

              while (enumerator.MoveNext())
              {
                str5 = StringType.FromObject(enumerator.Current);
                node4.Nodes.Add(str5.Trim(new char[] { ' ' }));
              }

              if (returnedTracks.Count > 0)
              {
                node5.Nodes.Add(node4);
                this.ResultTree.Nodes.Add(node5);
                flag = true;
              }

              node5.Expand();
            }
          }

          break;

        default:
          this.Status.Text = StringType.FromObject(Declarations.objResources.ResStrings["NoMatches"]);
          this.pnlWrite.Enabled = false;
          goto Label_0515;
      }

      if (flag)
      {
        this.Status.Text = StringType.FromObject(Declarations.objResources.ResStrings["Matches"]);
        this.pnlWrite.Enabled = true;
      }
      else
      {
        this.Status.Text = StringType.FromObject(Declarations.objResources.ResStrings["NoMatches"]);
        this.pnlWrite.Enabled = false;
      }

      Label_0515:
      this.btnClose.Enabled = true;
      this.btnSearch.Enabled = true;
      this.btnQuery.Enabled = true;
      this.btnCancel.Enabled = false;
    }

    private void btnSearch_Click(object sender, EventArgs e)
    {
      this.pnlWrite.Enabled = false;
      this.btnClose.Enabled = false;
      this.btnQuery.Enabled = false;
      this.btnSearch.Enabled = false;
      this.btnCancel.Enabled = true;
      string requestUriString = "http://www.freedb.org/freedb_search.php?";
      requestUriString = (requestUriString + "words=" + this.txtSearch.Text.Replace(" ", "+")) + "&allfields=NO";

      if (this.chkArtist.Checked | this.chkArtistExact.Checked)
        requestUriString = requestUriString + "&fields=artist";

      if (this.chkTitle.Checked)
        requestUriString = requestUriString + "&fields=title";

      if (this.chkTrack.Checked)
        requestUriString = requestUriString + "&fields=track";

      requestUriString = requestUriString + "&allcats=YES&grouping=none";
      this.Status.Text = StringType.FromObject(Declarations.objResources.ResStrings["Connecting"]);
      Application.DoEvents();
      this.FreeDB = new ID3_TagIT.FreeDB(Declarations.objSettings.FreeDBUser, "www.id3-tagit.de", "ID3-TagIT", Application.ProductVersion.ToString(), Declarations.objSettings.FreeDBServer, Declarations.objSettings.FreeDBPort);
      string str = "";

      try
      {
        str = new StreamReader(WebRequest.Create(requestUriString).GetResponse().GetResponseStream()).ReadToEnd();
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }

      ArrayList list = new ArrayList();

      if (str.IndexOf("http://www.freedb.org/freedb_search_fmt.php?") >= 0)
      {
        str = str.Substring(str.IndexOf("cat="));

        while (str.IndexOf("cat=") >= 0)
        {
          list.Add(str.Substring(str.IndexOf("cat=") + 4, (str.IndexOf('"', str.IndexOf("cat=") + 4) - str.IndexOf("cat=")) - 4));

          try
          {
            str = str.Substring(str.IndexOf("cat=", 1));
            continue;
          }
          catch (Exception exception2)
          {
            ProjectData.SetProjectError(exception2);
            ProjectData.ClearProjectError();
            break;
          }
        }
      }

      string str5 = "";
      this.Status.Text = StringType.FromObject(Declarations.objResources.ResStrings["Querying"]);
      bool flag2 = false;
      this.ResultTree.Nodes.Clear();

      var enumerator6 = list.GetEnumerator();

      while (enumerator6.MoveNext())
      {
        string str2 = null;
        string str3 = null;
        string str8 = null;
        string str4 = StringType.FromObject(enumerator6.Current);
        Application.DoEvents();

        if (this.vbooCancel)
        {
          this.vbooCancel = false;
          goto Label_0903;
        }

        ArrayList returnedTracks = new ArrayList();
        str5 = this.FreeDB.HTMLRead(str4.Substring(0, str4.IndexOf("&")), str4.Substring(str4.IndexOf("&") + 4), ref str3, ref str2, ref returnedTracks, ref str8) + "\r\n";
        bool flag = false;

        if ((((this.chkArtistExact.Checked & (StringType.StrCmp(str3.ToLower(), this.txtSearch.Text.Trim(new char[] { ' ' }).ToLower(), false) == 0)) | this.chkArtist.Checked) | this.chkTitle.Checked) | this.chkTrack.Checked)
        {
          string str6;
          Result result = new Result
          {
            Artist = str3,
            Album = str2,
            Tracks = (ArrayList)returnedTracks.Clone(),
            Year = str8,
            Genre = Strings.StrConv(str4.Substring(0, str4.IndexOf("&")), VbStrConv.ProperCase, 0)
          };

          bool flag3 = false;
          foreach (TreeNode node2 in this.ResultTree.Nodes)
          {
            if (StringType.StrCmp(node2.Text, str3.Trim(new char[] { ' ' }), false) == 0)
            {
              TreeNode node4 = node2;
              TreeNode node3 = new TreeNode
              {
                Text = str2.Trim(new char[] { ' ' }),
                Tag = result
              };

              var enumerator4 = returnedTracks.GetEnumerator();
              while (enumerator4.MoveNext())
              {
                str6 = StringType.FromObject(enumerator4.Current);
                node3.Nodes.Add(str6.Trim(new char[] { ' ' }));
              }

              if (returnedTracks.Count > 0)
              {
                flag3 = true;

                if (this.chkComplete.Checked)
                {
                  if (this.chkArtist.Checked & (str3.ToLower().Trim(new char[] { ' ' }).IndexOf(this.txtSearch.Text.Trim(new char[] { ' ' }).ToLower()) >= 0))
                    flag = true;

                  if (this.chkTitle.Checked & (str2.ToLower().Trim(new char[] { ' ' }).IndexOf(this.txtSearch.Text.Trim(new char[] { ' ' }).ToLower()) >= 0))
                    flag = true;

                  if (this.chkTrack.Checked)
                  {
                    foreach (TreeNode node in node3.Nodes)
                    {
                      if (flag)
                        break;

                      if (node.Text.ToLower().Trim(new char[] { ' ' }).IndexOf(this.txtSearch.Text.Trim(new char[] { ' ' }).ToLower()) >= 0)
                        flag = true;
                    }
                  }

                  if (flag)
                  {
                    node4.Nodes.Add(node3);
                    flag2 = true;
                  }
                }
                else
                {
                  node4.Nodes.Add(node3);
                  flag2 = true;
                }
              }

              node4.Expand();
            }

            if (flag3)
              break;
          }

          if (!flag3)
          {
            TreeNode node6 = new TreeNode { Text = str3.Trim(new char[] { ' ' }) };
            TreeNode node5 = new TreeNode { Text = str2.Trim(new char[] { ' ' }), Tag = result };

            var enumerator2 = returnedTracks.GetEnumerator();
            while (enumerator2.MoveNext())
            {
              str6 = StringType.FromObject(enumerator2.Current);
              node5.Nodes.Add(str6.Trim(new char[] { ' ' }));
            }

            if (returnedTracks.Count > 0)
            {
              if (this.chkComplete.Checked)
              {
                if (this.chkArtist.Checked & (str3.ToLower().Trim(new char[] { ' ' }).IndexOf(this.txtSearch.Text.Trim(new char[] { ' ' }).ToLower()) >= 0))
                  flag = true;

                if (this.chkTitle.Checked & (str2.ToLower().Trim(new char[] { ' ' }).IndexOf(this.txtSearch.Text.Trim(new char[] { ' ' }).ToLower()) >= 0))
                  flag = true;

                if (this.chkTrack.Checked)
                {
                  foreach (TreeNode node in node5.Nodes)
                  {
                    if (flag)
                      break;

                    if (node.Text.ToLower().Trim(new char[] { ' ' }).IndexOf(this.txtSearch.Text.Trim(new char[] { ' ' }).ToLower()) >= 0)
                      flag = true;
                  }
                }

                if (flag)
                {
                  node6.Nodes.Add(node5);
                  this.ResultTree.Nodes.Add(node6);
                  flag2 = true;
                }
              }
              else
              {
                node6.Nodes.Add(node5);
                this.ResultTree.Nodes.Add(node6);
                flag2 = true;
              }
            }

            node6.Expand();
          }
        }
      }

      Label_0903:
      if (flag2)
      {
        this.Status.Text = StringType.FromObject(Declarations.objResources.ResStrings["Matches"]);
        this.pnlWrite.Enabled = true;
      }
      else
      {
        this.Status.Text = StringType.FromObject(Declarations.objResources.ResStrings["NoMatches"]);
        this.pnlWrite.Enabled = false;
      }

      this.btnSearch.Enabled = true;
      this.btnQuery.Enabled = true;
      this.btnClose.Enabled = true;
      this.btnCancel.Enabled = false;
    }

    private void btnWrite_Click(object sender, EventArgs e)
    {
      ArrayList list = new ArrayList();
      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      Declarations.objSettings.FreeDBSingleArtist = this.optSingleArtist.Checked;
      Declarations.objSettings.FreeDBWrite1 = this.chkWrite1.Checked;
      Declarations.objSettings.FreeDBWrite2 = this.chkWrite2.Checked;
      Declarations.objSettings.FreeDBLastSearch = this.txtSearch.Text;
      byte num2 = 0;

      if (this.chkArtist.Checked)
        num2 = (byte)(num2 | 1);

      if (this.chkTitle.Checked)
        num2 = (byte)(num2 | 2);

      if (this.chkTrack.Checked)
        num2 = (byte)(num2 | 4);

      if (this.chkArtistExact.Checked)
        num2 = (byte)(num2 | 8);

      if (this.chkComplete.Checked)
        num2 = (byte)(num2 | 0x10);

      Declarations.objSettings.FreeDBSearchOptions = num2;
      if (ObjectType.ObjTst(this.Status.Text, Declarations.objResources.ResStrings["NoMatches"], false) != 0)
      {
        if (this.ResultTree.SelectedNode != null)
        {
          int num;
          frmFreeDBAssociate associate = new frmFreeDBAssociate(this.MainForm);
          this.alstFilesToTAG.Clear();
          associate.lblYear.Text = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Year", new object[0], null, null));
          associate.lblGenre.Text = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Genre", new object[0], null, null));

          foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
            LateBinding.LateCall(associate.lvwFiles.Items, null, "Add", new object[] { RuntimeHelpers.GetObjectValue(item.Clone()) }, null, null);

          var enumerator2 = ((IEnumerable)LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", new object[0], null, null)).GetEnumerator();
          while (enumerator2.MoveNext())
          {
            string text = StringType.FromObject(enumerator2.Current);
            associate.lvwFreeDB.Items.Add(text);
          }

          if (associate.lvwFiles.Items.Count < associate.lvwFreeDB.Items.Count)
          {
            int count = associate.lvwFreeDB.Items.Count;

            for (num = associate.lvwFiles.Items.Count + 1; num <= count; num++)
              associate.lvwFiles.Items.Add("***** Ignore *****");
          }

          if (associate.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
          {
            int num4;
            bool[] flagArray;
            object[] objArray;
            object[] objArray2;
            bool[] flagArray2;
            object[] objArray3;
            int num10 = this.alstFilesToTAG.Count - 1;

            for (num = 0; num <= num10; num++)
            {
              if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.NotObj(LateBinding.LateGet(LateBinding.LateGet(this.alstFilesToTAG[num], null, "Text", new object[0], null, null), null, "StartsWith", new object[] { "*" }, null, null)), LateBinding.LateGet(this.alstFilesToTAG[num], null, "Checked", new object[0], null, null))))
              {
                MP3 mp = (MP3)LateBinding.LateGet(this.alstFilesToTAG[num], null, "Tag", new object[0], null, null);
                Declarations.UnDoReDo @do = new Declarations.UnDoReDo(mp, mp.V1TAG.Clone(), mp.V2TAG.Clone(), mp.CurrentFullName, mp.Changed);
                list.Add(@do);
              }
            }

            this.MainForm.UnDoEnable(true, true);

            if (this.chkWrite1.Checked)
            {
              string sLeft = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Artist", new object[0], null, null));
              string str2 = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Album", new object[0], null, null));
              string str5 = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Year", new object[0], null, null));
              string str4 = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Genre", new object[0], null, null));
              num4 = IntegerType.FromObject(LateBinding.LateGet(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", new object[0], null, null), null, "Count", new object[0], null, null));

              if (this.optSingleArtist.Checked)
              {
                int num9 = num4 - 1;

                for (num = 0; num <= num9; num++)
                {
                  if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.NotObj(LateBinding.LateGet(LateBinding.LateGet(this.alstFilesToTAG[num], null, "Text", new object[0], null, null), null, "StartsWith", new object[] { "*" }, null, null)), LateBinding.LateGet(this.alstFilesToTAG[num], null, "Checked", new object[0], null, null))))
                  {
                    MP3 mp2 = (MP3)LateBinding.LateGet(this.alstFilesToTAG[num], null, "Tag", new object[0], null, null);

                    if ((StringType.StrCmp(sLeft, mp2.V1TAG.Artist, false) != 0) & (StringType.StrCmp(sLeft, "", false) != 0))
                    {
                      mp2.V1TAG.Artist = sLeft;
                      mp2.V1TAG.TAGPresent = true;
                      mp2.Changed = true;
                    }

                    if ((StringType.StrCmp(str2, mp2.V1TAG.Album, false) != 0) & (StringType.StrCmp(str2, "", false) != 0))
                    {
                      mp2.V1TAG.Album = str2;
                      mp2.V1TAG.TAGPresent = true;
                      mp2.Changed = true;
                    }

                    if ((StringType.StrCmp(str5, mp2.V1TAG.Year.ToString(), false) != 0) & (StringType.StrCmp(str5, "", false) != 0))
                    {
                      mp2.V1TAG.Year = (int)Math.Round(Conversion.Val(str5));
                      mp2.V1TAG.TAGPresent = true;
                      mp2.Changed = true;
                    }

                    if ((StringType.StrCmp(str4, mp2.V1TAG.GenreText, false) != 0) & (StringType.StrCmp(str4, "", false) != 0))
                    {
                      mp2.V1TAG.GenreText = str4;
                      mp2.V1TAG.TAGPresent = true;
                      mp2.Changed = true;
                    }

                    object[] args = new object[] { num };
                    bool[] copyBack = new bool[] { true };

                    if (copyBack[0])
                      num = IntegerType.FromObject(args[0]);

                    objArray3 = new object[] { num };
                    flagArray2 = new bool[] { true };

                    if (flagArray2[0])
                      num = IntegerType.FromObject(objArray3[0]);

                    if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.ObjTst(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", args, null, copyBack), mp2.V1TAG.Title, false) != 0, ObjectType.ObjTst(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", objArray3, null, flagArray2), "", false) != 0)))
                    {
                      objArray = new object[] { num };
                      flagArray = new bool[] { true };

                      if (flagArray[0])
                        num = IntegerType.FromObject(objArray[0]);

                      mp2.V1TAG.Title = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", objArray, null, flagArray));
                      mp2.V1TAG.TAGPresent = true;
                      mp2.Changed = true;
                    }

                    if (mp2.V1TAG.Tracknumber != (num + 1))
                    {
                      mp2.V1TAG.Tracknumber = (byte)(num + 1);
                      mp2.V1TAG.TAGPresent = true;
                      mp2.Changed = true;
                    }
                  }
                }
              }
              else
              {
                int num7 = num4 - 1;

                for (num = 0; num <= num7; num++)
                {
                  if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.NotObj(LateBinding.LateGet(LateBinding.LateGet(this.alstFilesToTAG[num], null, "Text", new object[0], null, null), null, "StartsWith", new object[] { "*" }, null, null)), LateBinding.LateGet(this.alstFilesToTAG[num], null, "Checked", new object[0], null, null))))
                  {
                    MP3 mp3 = (MP3)LateBinding.LateGet(this.alstFilesToTAG[num], null, "Tag", new object[0], null, null);

                    try
                    {
                      objArray2 = new object[] { num };
                      flagArray = new bool[] { true };

                      if (flagArray[0])
                        num = IntegerType.FromObject(objArray2[0]);

                      string[] strArray = (string[])LateBinding.LateGet(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", objArray2, null, flagArray), null, "Split", new object[] { "/" }, null, null);

                      if ((StringType.StrCmp(strArray[0].Trim(new char[] { ' ' }), mp3.V1TAG.Artist, false) != 0) & (StringType.StrCmp(strArray[0].Trim(new char[] { ' ' }), "", false) != 0))
                      {
                        mp3.V1TAG.Artist = strArray[0].Trim(new char[] { ' ' });
                        mp3.V1TAG.TAGPresent = true;
                        mp3.Changed = true;
                      }

                      if ((StringType.StrCmp(str2, mp3.V1TAG.Album, false) != 0) & (StringType.StrCmp(str2, "", false) != 0))
                      {
                        mp3.V1TAG.Album = str2;
                        mp3.V1TAG.TAGPresent = true;
                        mp3.Changed = true;
                      }

                      if ((StringType.StrCmp(str5, mp3.V1TAG.Year.ToString(), false) != 0) & (StringType.StrCmp(str5, "", false) != 0))
                      {
                        mp3.V1TAG.Year = (int)Math.Round(Conversion.Val(str5));
                        mp3.V1TAG.TAGPresent = true;
                        mp3.Changed = true;
                      }

                      if ((StringType.StrCmp(str4, mp3.V1TAG.GenreText, false) != 0) & (StringType.StrCmp(str4, "", false) != 0))
                      {
                        mp3.V1TAG.GenreText = str4;
                        mp3.V1TAG.TAGPresent = true;
                        mp3.Changed = true;
                      }

                      if ((StringType.StrCmp(strArray[1].Trim(new char[] { ' ' }), mp3.V1TAG.Title, false) != 0) & (StringType.StrCmp(strArray[1].Trim(new char[] { ' ' }), "", false) != 0))
                      {
                        mp3.V1TAG.Title = strArray[1].Trim(new char[] { ' ' });
                        mp3.V1TAG.TAGPresent = true;
                        mp3.Changed = true;
                      }

                      if (mp3.V1TAG.Tracknumber != (num + 1))
                      {
                        mp3.V1TAG.Tracknumber = (byte)(num + 1);
                        mp3.V1TAG.TAGPresent = true;
                        mp3.Changed = true;
                      }
                    }
                    catch (Exception exception1)
                    {
                      ProjectData.SetProjectError(exception1);
                      ProjectData.ClearProjectError();
                    }
                  }
                }
              }
            }

            if (this.chkWrite2.Checked)
            {
              object objectValue;
              object obj3;
              string str10;
              string[] strArray3;
              object obj4;
              object[] objArray4;
              int num8;
              object[] objArray6;
              string str7 = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Artist", new object[0], null, null));
              string str6 = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Album", new object[0], null, null));
              string str9 = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Year", new object[0], null, null));
              string str8 = StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Genre", new object[0], null, null));
              num4 = IntegerType.FromObject(LateBinding.LateGet(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", new object[0], null, null), null, "Count", new object[0], null, null));

              if (this.optSingleArtist.Checked)
              {
                int num6 = num4 - 1;

                for (num = 0; num <= num6; num++)
                {
                  if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.NotObj(LateBinding.LateGet(LateBinding.LateGet(this.alstFilesToTAG[num], null, "Text", new object[0], null, null), null, "StartsWith", new object[] { "*" }, null, null)), LateBinding.LateGet(this.alstFilesToTAG[num], null, "Checked", new object[0], null, null))))
                  {
                    MP3 mp4 = (MP3)LateBinding.LateGet(this.alstFilesToTAG[num], null, "Tag", new object[0], null, null);

                    if (StringType.StrCmp(str7, "", false) != 0)
                      mp4.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TPE1", str7));

                    if (StringType.StrCmp(str6, "", false) != 0)
                      mp4.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TALB", str6));

                    if (StringType.StrCmp(str9, "", false) != 0)
                    {
                      if (!mp4.V2TAG.TAGHeaderPresent)
                        mp4.V2TAG.TAGHeaderPresent = true;

                      if (mp4.V2TAG.TAGVersion == 3)
                        mp4.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TYER", str9));
                      else
                        mp4.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TDRC", str9));
                    }

                    if (StringType.StrCmp(str8, "", false) != 0)
                      mp4.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TCON", str8));

                    objArray2 = new object[] { num };
                    flagArray = new bool[] { true };

                    if (flagArray[0])
                      num = IntegerType.FromObject(objArray2[0]);

                    if (ObjectType.ObjTst(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", objArray2, null, flagArray), "", false) != 0)
                    {
                      objArray4 = new object[] { num };
                      flagArray2 = new bool[] { true };

                      if (flagArray2[0])
                        num = IntegerType.FromObject(objArray4[0]);

                      mp4.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TIT2", StringType.FromObject(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", objArray4, null, flagArray2))));
                    }

                    if (mp4.V2TAG.FrameExists("TRCK"))
                    {
                      objectValue = RuntimeHelpers.GetObjectValue(mp4.V2TAG.GetFrame("TRCK"));
                      obj3 = new V2TextFrame();
                      LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);

                      if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
                      {
                        objArray2 = new object[1];
                        num8 = num + 1;
                        objArray2[0] = num8.ToString().PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0');
                        LateBinding.LateSet(obj3, null, "Content", objArray2, null);
                      }
                      else
                      {
                        objArray6 = new object[1];
                        num8 = num + 1;
                        objArray3 = new object[1];
                        obj4 = objectValue;
                        objArray = new object[0];
                        strArray3 = null;
                        objArray2 = new object[1];
                        str10 = "/";
                        objArray2[0] = str10;
                        objArray3[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", objArray2, null, null));
                        objArray4 = objArray3;
                        flagArray = new bool[] { true };

                        if (flagArray[0])
                          LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", new object[] { str10, RuntimeHelpers.GetObjectValue(objArray4[0]) }, null, true, true);

                        objArray6[0] = ObjectType.StrCatObj(num8.ToString().PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'), LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray));
                        LateBinding.LateSet(obj3, null, "Content", objArray6, null);
                      }

                      mp4.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                    }
                    else
                    {
                      num8 = num + 1;
                      mp4.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TRCK", num8.ToString().PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0')));
                    }

                    if (mp4.V2TAG.Changed)
                    {
                      if (!mp4.V2TAG.TAGHeaderPresent)
                        mp4.V2TAG.TAGHeaderPresent = true;

                      mp4.Changed = true;
                    }
                  }
                }
              }
              else
              {
                int num5 = num4 - 1;

                for (num = 0; num <= num5; num++)
                {
                  if (BooleanType.FromObject(ObjectType.BitAndObj(ObjectType.NotObj(LateBinding.LateGet(LateBinding.LateGet(this.alstFilesToTAG[num], null, "Text", new object[0], null, null), null, "StartsWith", new object[] { "*" }, null, null)), LateBinding.LateGet(this.alstFilesToTAG[num], null, "Checked", new object[0], null, null))))
                  {
                    MP3 mp5 = (MP3)LateBinding.LateGet(this.alstFilesToTAG[num], null, "Tag", new object[0], null, null);

                    try
                    {
                      objArray2 = new object[] { num };
                      flagArray = new bool[] { true };

                      if (flagArray[0])
                        num = IntegerType.FromObject(objArray2[0]);

                      string[] strArray2 = (string[])LateBinding.LateGet(LateBinding.LateGet(this.ResultTree.SelectedNode.Tag, null, "Tracks", objArray2, null, flagArray), null, "Split", new object[] { "/" }, null, null);

                      if (StringType.StrCmp(strArray2[0].Trim(new char[] { ' ' }), "", false) != 0)
                        mp5.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TPE1", strArray2[0].Trim(new char[] { ' ' })));

                      if (StringType.StrCmp(str6, "", false) != 0)
                        mp5.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TALB", str6));

                      if (StringType.StrCmp(strArray2[1].Trim(new char[] { ' ' }), "", false) != 0)
                        mp5.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TIT2", strArray2[1].Trim(new char[] { ' ' })));

                      if (StringType.StrCmp(str9, "", false) != 0)
                      {
                        if (!mp5.V2TAG.TAGHeaderPresent)
                          mp5.V2TAG.TAGHeaderPresent = true;

                        if (mp5.V2TAG.TAGVersion == 3)
                          mp5.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TYER", str9));
                        else
                          mp5.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TDRC", str9));
                      }

                      if (StringType.StrCmp(str8, "", false) != 0)
                        mp5.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TCON", str8));

                      if (mp5.V2TAG.FrameExists("TRCK"))
                      {
                        objectValue = RuntimeHelpers.GetObjectValue(mp5.V2TAG.GetFrame("TRCK"));
                        obj3 = new V2TextFrame();
                        LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);

                        if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
                        {
                          objArray2 = new object[1];
                          num8 = num + 1;
                          objArray2[0] = num8.ToString().PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0');
                          LateBinding.LateSet(obj3, null, "Content", objArray2, null);
                        }
                        else
                        {
                          objArray6 = new object[1];
                          num8 = num + 1;
                          objArray3 = new object[1];
                          obj4 = objectValue;
                          objArray = new object[0];
                          strArray3 = null;
                          objArray2 = new object[1];
                          str10 = "/";
                          objArray2[0] = str10;
                          objArray3[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", objArray2, null, null));
                          objArray4 = objArray3;
                          flagArray = new bool[] { true };

                          if (flagArray[0])
                            LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", new object[] { str10, RuntimeHelpers.GetObjectValue(objArray4[0]) }, null, true, true);

                          objArray6[0] = ObjectType.StrCatObj(num8.ToString().PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'), LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray));
                          LateBinding.LateSet(obj3, null, "Content", objArray6, null);
                        }

                        mp5.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                      }
                      else
                      {
                        num8 = num + 1;
                        mp5.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TRCK", num8.ToString().PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0')));
                      }
                    }
                    catch (Exception exception2)
                    {
                      ProjectData.SetProjectError(exception2);
                      ProjectData.ClearProjectError();
                    }

                    if (mp5.V2TAG.Changed)
                    {
                      if (!mp5.V2TAG.TAGHeaderPresent)
                        mp5.V2TAG.TAGHeaderPresent = true;

                      mp5.Changed = true;
                    }
                  }
                }
              }
            }

            foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
              this.MainForm.UpdateListItem(item, false);

            if (list.Count > 0)
              Declarations.UNDOList.Add(list);

            this.Close();
          }
        }
      }
      else
        this.Close();
    }

    private void chkArtistEact_CheckedChanged(object sender, EventArgs e)
    {
      if (sender == this.chkArtist)
      {
        if (this.chkArtist.Checked)
        {
          this.chkArtist.Checked = true;
          this.chkArtistExact.Checked = false;
        }
      }
      else if (this.chkArtistExact.Checked)
      {
        this.chkArtist.Checked = false;
        this.chkArtistExact.Checked = true;
      }
    }

    private void frmFreeDB_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);
      this.optSingleArtist.Checked = Declarations.objSettings.FreeDBSingleArtist;
      this.optVariousArtist.Checked = !Declarations.objSettings.FreeDBSingleArtist;
      this.chkWrite1.Checked = Declarations.objSettings.FreeDBWrite1;
      this.chkWrite2.Checked = Declarations.objSettings.FreeDBWrite2;
      this.txtSearch.Text = Declarations.objSettings.FreeDBLastSearch;

      if ((Declarations.objSettings.FreeDBSearchOptions & 1) == 1)
        this.chkArtist.Checked = true;

      if ((Declarations.objSettings.FreeDBSearchOptions & 2) == 2)
        this.chkTitle.Checked = true;

      if ((Declarations.objSettings.FreeDBSearchOptions & 4) == 4)
        this.chkTrack.Checked = true;

      if ((Declarations.objSettings.FreeDBSearchOptions & 8) == 8)
        this.chkArtistExact.Checked = true;

      if ((Declarations.objSettings.FreeDBSearchOptions & 0x10) == 0x10)
        this.chkComplete.Checked = true;

      this.alstFilesToTAG.Clear();

      if (Declarations.objSettings.FreeDBProxyUse)
      {
        NetworkCredential credential = new NetworkCredential(Declarations.objSettings.FreeDBProxyUser, Declarations.objSettings.FreeDBProxyPassword);
        WebProxy proxy = new WebProxy(Declarations.objSettings.FreeDBProxyServer, Declarations.objSettings.FreeDBProxyPort);

        try
        {
          if (StringType.StrCmp(Declarations.objSettings.FreeDBProxyUser, "", false) != 0)
            proxy.Credentials = credential;
          else
            proxy.Credentials = CredentialCache.DefaultCredentials;
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          ProjectData.ClearProjectError();
        }

        GlobalProxySelection.Select = proxy;
      }
      else
        GlobalProxySelection.Select = GlobalProxySelection.GetEmptyWebProxy();

      if (Declarations.objSettings.SynchronizeTAGs)
      {
        this.chkWrite1.Checked = true;
        this.chkWrite2.Checked = true;
        this.chkWrite1.Enabled = false;
        this.chkWrite2.Enabled = false;
      }

      this.AddToolTips();
    }

    private void ResultTree_AfterSelect(object sender, TreeViewEventArgs e)
    {
      if (this.ResultTree.SelectedNode != null)
      {
        if (this.ResultTree.SelectedNode.Parent == null)
        {
          if (this.ResultTree.SelectedNode.FirstNode != null)
            this.ResultTree.SelectedNode = this.ResultTree.SelectedNode.FirstNode;
        }
        else if (this.ResultTree.SelectedNode.FirstNode == null)
        {
          this.ResultTree.SelectedNode = this.ResultTree.SelectedNode.Parent;
        }
      }
    }

    private void txtSearch_KeyUp(object sender, KeyEventArgs e)
    {
      if (e.KeyCode == Keys.Enter)
        this.btnSearch.PerformClick();
    }

    #endregion

    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmFreeDB";
      Control btnQuery = this.btnQuery;
      this.btnQuery = (Button)btnQuery;
      this.ToolTip.SetToolTip(this.btnQuery, Declarations.objResources.GetToolTip(ref vstrName, ref btnQuery));

      vstrName = "frmFreeDB";
      btnQuery = this.optVariousArtist;
      this.optVariousArtist = (RadioButton)btnQuery;
      this.ToolTip.SetToolTip(this.optVariousArtist, Declarations.objResources.GetToolTip(ref vstrName, ref btnQuery));

      vstrName = "frmFreeDB";
      btnQuery = this.optSingleArtist;
      this.optSingleArtist = (RadioButton)btnQuery;
      this.ToolTip.SetToolTip(this.optSingleArtist, Declarations.objResources.GetToolTip(ref vstrName, ref btnQuery));

      vstrName = "frmFreeDB";
      btnQuery = this.chkTrack;
      this.chkTrack = (CheckBox)btnQuery;
      this.ToolTip.SetToolTip(this.chkTrack, Declarations.objResources.GetToolTip(ref vstrName, ref btnQuery));

      vstrName = "frmFreeDB";
      btnQuery = this.chkTitle;
      this.chkTitle = (CheckBox)btnQuery;
      this.ToolTip.SetToolTip(this.chkTitle, Declarations.objResources.GetToolTip(ref vstrName, ref btnQuery));

      vstrName = "frmFreeDB";
      btnQuery = this.btnSearch;
      this.btnSearch = (Button)btnQuery;
      this.ToolTip.SetToolTip(this.btnSearch, Declarations.objResources.GetToolTip(ref vstrName, ref btnQuery));

      vstrName = "frmFreeDB";
      btnQuery = this.chkArtistExact;
      this.chkArtistExact = (CheckBox)btnQuery;
      this.ToolTip.SetToolTip(this.chkArtistExact, Declarations.objResources.GetToolTip(ref vstrName, ref btnQuery));

      vstrName = "frmFreeDB";
      btnQuery = this.chkArtist;
      this.chkArtist = (CheckBox)btnQuery;
      this.ToolTip.SetToolTip(this.chkArtist, Declarations.objResources.GetToolTip(ref vstrName, ref btnQuery));

      vstrName = "frmFreeDB";
      btnQuery = this.chkComplete;
      this.chkComplete = (CheckBox)btnQuery;
      this.ToolTip.SetToolTip(this.chkComplete, Declarations.objResources.GetToolTip(ref vstrName, ref btnQuery));
    }

    #endregion
  }
}