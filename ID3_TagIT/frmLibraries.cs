namespace ID3_TagIT
{
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

  public class frmLibraries : Form
  {
    [AccessedThroughProperty("Artist")]
    private TabItem _Artist;
    [AccessedThroughProperty("ArtistList")]
    private ListBox _ArtistList;
    [AccessedThroughProperty("btnAdd")]
    private Button _btnAdd;
    [AccessedThroughProperty("btnAddCommD")]
    private Button _btnAddCommD;
    [AccessedThroughProperty("btnAddFav")]
    private Button _btnAddFav;
    [AccessedThroughProperty("btnAddFavDir")]
    private Button _btnAddFavDir;
    [AccessedThroughProperty("btnAddG")]
    private Button _btnAddG;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnClearA")]
    private Button _btnClearA;
    [AccessedThroughProperty("btnClearCommD")]
    private Button _btnClearCommD;
    [AccessedThroughProperty("btnDeleteA")]
    private Button _btnDeleteA;
    [AccessedThroughProperty("btnDeleteG")]
    private Button _btnDeleteG;
    [AccessedThroughProperty("btnFavBrowse")]
    private Button _btnFavBrowse;
    [AccessedThroughProperty("btnGetArtistV1")]
    private Button _btnGetArtistV1;
    [AccessedThroughProperty("btnGetArtistV2")]
    private Button _btnGetArtistV2;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("btnRemoveCommD")]
    private Button _btnRemoveCommD;
    [AccessedThroughProperty("btnRemoveFav")]
    private Button _btnRemoveFav;
    [AccessedThroughProperty("btnRemoveFavDir")]
    private Button _btnRemoveFavDir;
    [AccessedThroughProperty("ButtomPanel")]
    private PanelEx _ButtomPanel;
    [AccessedThroughProperty("chkOnlyOwn")]
    private CheckBox _chkOnlyOwn;
    [AccessedThroughProperty("cmbV1V2")]
    private ComboBox _cmbV1V2;
    [AccessedThroughProperty("cmbV2V1")]
    private ComboBox _cmbV2V1;
    [AccessedThroughProperty("colHName")]
    private ColumnHeader _colHName;
    [AccessedThroughProperty("colHV1V2")]
    private ColumnHeader _colHV1V2;
    [AccessedThroughProperty("colHV2V1")]
    private ColumnHeader _colHV2V1;
    [AccessedThroughProperty("CommDList")]
    private ListBox _CommDList;
    [AccessedThroughProperty("Comment")]
    private TabItem _Comment;
    [AccessedThroughProperty("Favourites")]
    private TabItem _Favourites;
    [AccessedThroughProperty("FavTree")]
    private TreeView _FavTree;
    [AccessedThroughProperty("FolderBrowserDialog")]
    private System.Windows.Forms.FolderBrowserDialog _FolderBrowserDialog;
    [AccessedThroughProperty("Genre")]
    private TabItem _Genre;
    [AccessedThroughProperty("GenreList")]
    private ListView _GenreList;
    [AccessedThroughProperty("Label1")]
    private Label _Label1;
    [AccessedThroughProperty("Label2")]
    private Label _Label2;
    [AccessedThroughProperty("Label3")]
    private Label _Label3;
    [AccessedThroughProperty("lblArtistName")]
    private Label _lblArtistName;
    [AccessedThroughProperty("lblCorres")]
    private Label _lblCorres;
    [AccessedThroughProperty("lblDescArtist")]
    private Label _lblDescArtist;
    [AccessedThroughProperty("lblDescGenre")]
    private Label _lblDescGenre;
    [AccessedThroughProperty("lblGenreName")]
    private Label _lblGenreName;
    [AccessedThroughProperty("lblInfo1")]
    private Label _lblInfo1;
    [AccessedThroughProperty("lblInfo2")]
    private Label _lblInfo2;
    [AccessedThroughProperty("Libraries")]
    private DevComponents.DotNetBar.TabControl _Libraries;
    [AccessedThroughProperty("TabControlPanel1")]
    private TabControlPanel _TabControlPanel1;
    [AccessedThroughProperty("TabControlPanel2")]
    private TabControlPanel _TabControlPanel2;
    [AccessedThroughProperty("TabControlPanel3")]
    private TabControlPanel _TabControlPanel3;
    [AccessedThroughProperty("TabControlPanel4")]
    private TabControlPanel _TabControlPanel4;
    [AccessedThroughProperty("ToolTip")]
    private System.Windows.Forms.ToolTip _ToolTip;
    [AccessedThroughProperty("txtArtistName")]
    private TextBox _txtArtistName;
    [AccessedThroughProperty("txtDir")]
    private TextBox _txtDir;
    [AccessedThroughProperty("txtGenreName")]
    private TextBox _txtGenreName;
    [AccessedThroughProperty("txtName")]
    private TextBox _txtName;
    [AccessedThroughProperty("txtNewCommD")]
    private TextBox _txtNewCommD;
    private IContainer components;
    private frmMain MainForm;
    private string vstrPfad;

    public frmLibraries(ref frmMain FormMain)
    {
      base.Load += new EventHandler(this.frmLibraries_Load);
      this.vstrPfad = Declarations.objSettings.CurrentPath;
      this.InitializeComponent();
      this.MainForm = FormMain;
    }

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
      IEnumerator enumerator;
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
        {
          ((IDisposable)enumerator).Dispose();
        }
      }
    }

    private void btnAdd_Click(object sender, EventArgs e)
    {
      if (StringType.StrCmp(this.txtArtistName.Text.Trim(), "", false) != 0)
      {
        DataRow current;
        using (IEnumerator enumerator2 = Declarations.objSettings.Artists.Rows.GetEnumerator())
        {
          while (enumerator2.MoveNext())
          {
            current = (DataRow)enumerator2.Current;
            if (ObjectType.ObjTst(current["Name"], this.txtArtistName.Text.Trim(), false) == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["DoubleArtist"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Exclamation, null);
              return;
            }
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
        using (IEnumerator enumerator2 = Declarations.objSettings.CommDescriptors.Rows.GetEnumerator())
        {
          while (enumerator2.MoveNext())
          {
            current = (DataRow)enumerator2.Current;
            if (ObjectType.ObjTst(current["Name"], this.txtNewCommD.Text.Trim(), false) == 0)
            {
              Interaction.MsgBox(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Declarations.objResources.ResStrings["DoubleCommD"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)), MsgBoxStyle.Exclamation, null);
              return;
            }
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
        {
          if (StringType.StrCmp(node2.Text, this.txtName.Text, false) == 0)
          {
            return;
          }
        }
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
        {
          this.FavTree.SelectedNode = this.FavTree.SelectedNode.Parent;
        }
        if (Directory.Exists(this.txtDir.Text.Trim()))
        {
          foreach (TreeNode node in this.FavTree.SelectedNode.Nodes)
          {
            if (StringType.StrCmp(node.Text, this.txtName.Text, false) == 0)
            {
              return;
            }
          }
          TreeNode node2 = new TreeNode
          {
            Text = this.txtDir.Text.Trim()
          };
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
            SubItems = {
                            this.cmbV1V2.SelectedItem.ToString(),
                            this.cmbV2V1.SelectedItem.ToString()
                        }
          };
          this.GenreList.Items.Add(item);
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          foreach (DataRow row in Declarations.objSettings.Genres.Rows)
          {
            if (ObjectType.ObjTst(row["Name"], this.txtGenreName.Text.Trim(), false) == 0)
            {
              row["V1V2"] = ID3Functions.GetV1GenreByName(this.cmbV1V2.SelectedItem.ToString());
              row["V2V1"] = ID3Functions.GetV1GenreByName(this.cmbV2V1.SelectedItem.ToString());
              break;
            }
          }
          foreach (ListViewItem item2 in this.GenreList.Items)
          {
            if (StringType.StrCmp(item2.Text, this.txtGenreName.Text.Trim(), false) == 0)
            {
              item2.SubItems[this.colHV1V2.Index].Text = this.cmbV1V2.SelectedItem.ToString();
              item2.SubItems[this.colHV2V1.Index].Text = this.cmbV2V1.SelectedItem.ToString();
              break;
            }
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
      {
        foreach (DataRow row in Declarations.objSettings.Genres.Rows)
        {
          if (ObjectType.ObjTst(row["Name"], this.GenreList.FocusedItem.Text, false) == 0)
          {
            Declarations.objSettings.Genres.Rows.Remove(row);
            break;
          }
        }
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
      {
        list.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
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
      Main.SaveFormSettings(ref form);
      Declarations.objSettings.FavNodes.Clear();
      foreach (TreeNode node in this.FavTree.Nodes)
      {
        Declarations.objSettings.FavNodes.Add(node);
      }
      this.MainForm.FavTree.BeginUpdate();
      this.MainForm.FavTree.Nodes.Clear();
      foreach (TreeNode node in Declarations.objSettings.FavNodes)
      {
        LateBinding.LateCall(this.MainForm.FavTree.Nodes, null, "Add", new object[] { RuntimeHelpers.GetObjectValue(node.Clone()) }, null, null);
      }
      this.MainForm.FavTree.EndUpdate();
      ArrayList list = new ArrayList();
      ArrayList list2 = new ArrayList();
      Declarations.objSettings.OwnGenreOnly = this.chkOnlyOwn.Checked;
      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
      {
        list.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
      list.Sort();
      this.ArtistList.Enabled = false;
      this.ArtistList.DataSource = null;
      foreach (DataRow row in Declarations.objSettings.CommDescriptors.Rows)
      {
        list2.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
      list2.Sort();
      this.CommDList.Enabled = false;
      this.CommDList.DataSource = null;
      Declarations.objSettings.Artists.Rows.Clear();
      Declarations.objSettings.CommDescriptors.Rows.Clear();
      Declarations.objSettings.Genres.Rows.Clear();
      form = this;
      frmProgress.Callback cB = new frmProgress.Callback(this.ArtistCB);
      frmProgress progress = new frmProgress(0, list.Count, 1, ref form, ref cB)
      {
        btnCancel = { Enabled = false }
      };
      progress.SetStateSaveLib();
      progress.List = list;
      progress.ShowDialog(this);
      Application.DoEvents();
      form = this;
      cB = new frmProgress.Callback(this.GenreCB);
      frmProgress progress2 = new frmProgress(0, this.GenreList.Items.Count, 1, ref form, ref cB)
      {
        btnCancel = { Enabled = false }
      };
      progress2.SetStateSaveLib();
      progress2.ShowDialog(this);
      Application.DoEvents();
      form = this;
      cB = new frmProgress.Callback(this.CommDCB);
      frmProgress progress3 = new frmProgress(0, list2.Count, 1, ref form, ref cB)
      {
        btnCancel = { Enabled = false }
      };
      progress3.SetStateSaveLib();
      progress3.List = list2;
      progress3.ShowDialog(this);
      this.MainForm.cmbArtist.Items.Clear();
      foreach (DataRow row in Declarations.objSettings.Artists.Rows)
      {
        this.MainForm.cmbArtist.Items.Add(RuntimeHelpers.GetObjectValue(row["Name"]));
      }
      this.Close();
    }

    private void btnRemoveCommD_Click(object sender, EventArgs e)
    {
      ((DataRowView)this.CommDList.SelectedItem).Delete();
    }

    private void btnRemoveFav_Click(object sender, EventArgs e)
    {
      if ((this.FavTree.SelectedNode != null) && (this.FavTree.SelectedNode.Parent == null))
      {
        this.FavTree.Nodes.Remove(this.FavTree.SelectedNode);
      }
    }

    private void btnRemoveFavDir_Click(object sender, EventArgs e)
    {
      if ((this.FavTree.SelectedNode != null) && (this.FavTree.SelectedNode.Parent != null))
      {
        this.FavTree.Nodes.Remove(this.FavTree.SelectedNode);
      }
    }

    private void CommDCB(ref frmProgress frmProg)
    {
      IEnumerator enumerator;
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
        {
          ((IDisposable)enumerator).Dispose();
        }
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

    private void frmLibraries_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
      foreach (TreeNode node in Declarations.objSettings.FavNodes)
      {
        LateBinding.LateCall(this.FavTree.Nodes, null, "Add", new object[] { RuntimeHelpers.GetObjectValue(node.Clone()) }, null, null);
      }
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
        {
          item.SubItems.Add(Declarations.astrGenreLookup[IntegerType.FromObject(row["V1V2"])]);
        }
        else
        {
          item.SubItems.Add("< undefined >");
        }
        if (ObjectType.ObjTst(row["V2V1"], 0x94, false) < 0)
        {
          item.SubItems.Add(Declarations.astrGenreLookup[IntegerType.FromObject(row["V2V1"])]);
        }
        else
        {
          item.SubItems.Add("< undefined >");
        }
        this.GenreList.Items.Add(item);
      }
      this.AddToolTips();
    }

    private void GenreCB(ref frmProgress frmProg)
    {
      IEnumerator enumerator;
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
        {
          ((IDisposable)enumerator).Dispose();
        }
      }
    }

    private void GenreList_SelectedIndexChanged(object sender, EventArgs e)
    {
      this.txtGenreName.Text = this.GenreList.FocusedItem.Text;
      this.cmbV1V2.Text = this.GenreList.FocusedItem.SubItems[this.colHV1V2.Index].Text;
      this.cmbV2V1.Text = this.GenreList.FocusedItem.SubItems[this.colHV2V1.Index].Text;
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      this.lblInfo1 = new Label();
      this.btnFavBrowse = new Button();
      this.btnRemoveFavDir = new Button();
      this.btnAddFavDir = new Button();
      this.txtDir = new TextBox();
      this.Label2 = new Label();
      this.btnRemoveFav = new Button();
      this.btnAddFav = new Button();
      this.txtName = new TextBox();
      this.Label1 = new Label();
      this.FavTree = new TreeView();
      this.chkOnlyOwn = new CheckBox();
      this.lblDescGenre = new Label();
      this.cmbV2V1 = new ComboBox();
      this.cmbV1V2 = new ComboBox();
      this.lblCorres = new Label();
      this.btnDeleteG = new Button();
      this.btnAddG = new Button();
      this.lblGenreName = new Label();
      this.txtGenreName = new TextBox();
      this.GenreList = new ListView();
      this.colHName = new ColumnHeader();
      this.colHV1V2 = new ColumnHeader();
      this.colHV2V1 = new ColumnHeader();
      this.lblDescArtist = new Label();
      this.btnClearA = new Button();
      this.btnDeleteA = new Button();
      this.btnAdd = new Button();
      this.lblArtistName = new Label();
      this.txtArtistName = new TextBox();
      this.btnGetArtistV1 = new Button();
      this.ArtistList = new ListBox();
      this.btnGetArtistV2 = new Button();
      this.btnClearCommD = new Button();
      this.btnRemoveCommD = new Button();
      this.btnAddCommD = new Button();
      this.Label3 = new Label();
      this.txtNewCommD = new TextBox();
      this.CommDList = new ListBox();
      this.lblInfo2 = new Label();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.Libraries = new DevComponents.DotNetBar.TabControl();
      this.TabControlPanel4 = new TabControlPanel();
      this.Comment = new TabItem(this.components);
      this.TabControlPanel1 = new TabControlPanel();
      this.Favourites = new TabItem(this.components);
      this.TabControlPanel2 = new TabControlPanel();
      this.Genre = new TabItem(this.components);
      this.TabControlPanel3 = new TabControlPanel();
      this.Artist = new TabItem(this.components);
      this.ButtomPanel = new PanelEx();
      ((ISupportInitialize)this.Libraries).BeginInit();
      this.Libraries.SuspendLayout();
      this.TabControlPanel4.SuspendLayout();
      this.TabControlPanel1.SuspendLayout();
      this.TabControlPanel2.SuspendLayout();
      this.TabControlPanel3.SuspendLayout();
      this.ButtomPanel.SuspendLayout();
      this.SuspendLayout();
      this.lblInfo1.BackColor = Color.Transparent;
      this.lblInfo1.BorderStyle = BorderStyle.Fixed3D;
      this.lblInfo1.ImeMode = ImeMode.NoControl;
      Point point = new Point(8, 0x160);
      this.lblInfo1.Location = point;
      this.lblInfo1.Name = "lblInfo1";
      Size size = new Size(0x120, 0x30);
      this.lblInfo1.Size = size;
      this.lblInfo1.TabIndex = 20;
      this.lblInfo1.Text = "You can group different directories under one Favourite so that can access them directly with one click.";
      this.lblInfo1.TextAlign = ContentAlignment.MiddleCenter;
      this.btnFavBrowse.BackColor = SystemColors.Control;
      this.btnFavBrowse.ImeMode = ImeMode.NoControl;
      point = new Point(0xa3, 0xb1);
      this.btnFavBrowse.Location = point;
      this.btnFavBrowse.Name = "btnFavBrowse";
      size = new Size(0x88, 0x18);
      this.btnFavBrowse.Size = size;
      this.btnFavBrowse.TabIndex = 9;
      this.btnFavBrowse.Text = "Browse ...";
      this.btnRemoveFavDir.BackColor = SystemColors.Control;
      this.btnRemoveFavDir.ImeMode = ImeMode.NoControl;
      point = new Point(0xa3, 0x91);
      this.btnRemoveFavDir.Location = point;
      this.btnRemoveFavDir.Name = "btnRemoveFavDir";
      size = new Size(0x88, 0x18);
      this.btnRemoveFavDir.Size = size;
      this.btnRemoveFavDir.TabIndex = 8;
      this.btnRemoveFavDir.Text = "Remove";
      this.btnAddFavDir.BackColor = SystemColors.Control;
      this.btnAddFavDir.ImeMode = ImeMode.NoControl;
      point = new Point(11, 0x91);
      this.btnAddFavDir.Location = point;
      this.btnAddFavDir.Name = "btnAddFavDir";
      size = new Size(0x88, 0x18);
      this.btnAddFavDir.Size = size;
      this.btnAddFavDir.TabIndex = 7;
      this.btnAddFavDir.Text = "Add";
      point = new Point(11, 0x77);
      this.txtDir.Location = point;
      this.txtDir.Name = "txtDir";
      size = new Size(0x120, 20);
      this.txtDir.Size = size;
      this.txtDir.TabIndex = 6;
      this.txtDir.Text = "";
      this.Label2.BackColor = Color.Transparent;
      this.Label2.ImeMode = ImeMode.NoControl;
      point = new Point(11, 0x61);
      this.Label2.Location = point;
      this.Label2.Name = "Label2";
      size = new Size(0xb8, 0x10);
      this.Label2.Size = size;
      this.Label2.TabIndex = 5;
      this.Label2.Text = "Name of Directory:";
      this.btnRemoveFav.BackColor = SystemColors.Control;
      this.btnRemoveFav.ImeMode = ImeMode.NoControl;
      point = new Point(0xa3, 0x39);
      this.btnRemoveFav.Location = point;
      this.btnRemoveFav.Name = "btnRemoveFav";
      size = new Size(0x88, 0x18);
      this.btnRemoveFav.Size = size;
      this.btnRemoveFav.TabIndex = 4;
      this.btnRemoveFav.Text = "Remove";
      this.btnAddFav.BackColor = SystemColors.Control;
      this.btnAddFav.ImeMode = ImeMode.NoControl;
      point = new Point(11, 0x39);
      this.btnAddFav.Location = point;
      this.btnAddFav.Name = "btnAddFav";
      size = new Size(0x88, 0x18);
      this.btnAddFav.Size = size;
      this.btnAddFav.TabIndex = 3;
      this.btnAddFav.Text = "Add";
      point = new Point(11, 0x1f);
      this.txtName.Location = point;
      this.txtName.Name = "txtName";
      size = new Size(0x120, 20);
      this.txtName.Size = size;
      this.txtName.TabIndex = 2;
      this.txtName.Text = "";
      this.Label1.BackColor = Color.Transparent;
      this.Label1.ImeMode = ImeMode.NoControl;
      point = new Point(11, 9);
      this.Label1.Location = point;
      this.Label1.Name = "Label1";
      size = new Size(0xb8, 0x10);
      this.Label1.Size = size;
      this.Label1.TabIndex = 1;
      this.Label1.Text = "Name of Favourite:";
      this.FavTree.ImageIndex = -1;
      this.FavTree.Indent = 0x13;
      this.FavTree.ItemHeight = 0x10;
      point = new Point(0x13b, 9);
      this.FavTree.Location = point;
      this.FavTree.Name = "FavTree";
      this.FavTree.SelectedImageIndex = -1;
      this.FavTree.ShowLines = false;
      size = new Size(0x115, 0x187);
      this.FavTree.Size = size;
      this.FavTree.TabIndex = 0;
      this.chkOnlyOwn.BackColor = Color.Transparent;
      this.chkOnlyOwn.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x138);
      this.chkOnlyOwn.Location = point;
      this.chkOnlyOwn.Name = "chkOnlyOwn";
      size = new Size(0x248, 0x10);
      this.chkOnlyOwn.Size = size;
      this.chkOnlyOwn.TabIndex = 0x11;
      this.chkOnlyOwn.Text = "Use only the own genres entered above in TAG Ver. 2 genre dropdown lists";
      this.lblDescGenre.BackColor = Color.Transparent;
      this.lblDescGenre.BorderStyle = BorderStyle.Fixed3D;
      this.lblDescGenre.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x150);
      this.lblDescGenre.Location = point;
      this.lblDescGenre.Name = "lblDescGenre";
      size = new Size(0x248, 0x40);
      this.lblDescGenre.Size = size;
      this.lblDescGenre.TabIndex = 0x13;
      this.lblDescGenre.Text = "To this library cou can add your own genres for Ver. 2 TAGs which will then appear in the dropdown boxes for TAG Ver. genres. The relations between TAG Ver. 1 and TAG Ver. 2 genres are used when the \"Transfer function\" is started, so e. g. a genre in TAG Ver. 1 becomes the genre you entered above in TAG Ver. 2.";
      this.lblDescGenre.TextAlign = ContentAlignment.MiddleCenter;
      this.cmbV2V1.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbV2V1.ItemHeight = 13;
      point = new Point(0x130, 0xf8);
      this.cmbV2V1.Location = point;
      this.cmbV2V1.Name = "cmbV2V1";
      size = new Size(0x120, 0x15);
      this.cmbV2V1.Size = size;
      this.cmbV2V1.TabIndex = 14;
      this.cmbV1V2.DropDownStyle = ComboBoxStyle.DropDownList;
      this.cmbV1V2.ItemHeight = 13;
      point = new Point(8, 0xf8);
      this.cmbV1V2.Location = point;
      this.cmbV1V2.Name = "cmbV1V2";
      size = new Size(0x120, 0x15);
      this.cmbV1V2.Size = size;
      this.cmbV1V2.TabIndex = 13;
      this.lblCorres.BackColor = Color.Transparent;
      this.lblCorres.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0xe8);
      this.lblCorres.Location = point;
      this.lblCorres.Name = "lblCorres";
      size = new Size(0x248, 0x10);
      this.lblCorres.Size = size;
      this.lblCorres.TabIndex = 12;
      this.lblCorres.Text = "Corres&ponding TAG Ver. 1 genres for transfer from  Ver. 1 to Ver. 2 and  Ver. 2 to Ver. 1:";
      this.btnDeleteG.BackColor = SystemColors.Control;
      this.btnDeleteG.ImeMode = ImeMode.NoControl;
      point = new Point(0x130, 280);
      this.btnDeleteG.Location = point;
      this.btnDeleteG.Name = "btnDeleteG";
      size = new Size(0x120, 0x18);
      this.btnDeleteG.Size = size;
      this.btnDeleteG.TabIndex = 0x10;
      this.btnDeleteG.Text = "&Delete selected genre";
      this.btnAddG.BackColor = SystemColors.Control;
      this.btnAddG.ImeMode = ImeMode.NoControl;
      point = new Point(8, 280);
      this.btnAddG.Location = point;
      this.btnAddG.Name = "btnAddG";
      size = new Size(0x120, 0x18);
      this.btnAddG.Size = size;
      this.btnAddG.TabIndex = 15;
      this.btnAddG.Text = "&Add genre to library";
      this.lblGenreName.BackColor = Color.Transparent;
      this.lblGenreName.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0xc0);
      this.lblGenreName.Location = point;
      this.lblGenreName.Name = "lblGenreName";
      size = new Size(0x248, 0x10);
      this.lblGenreName.Size = size;
      this.lblGenreName.TabIndex = 10;
      this.lblGenreName.Text = "&New TAG Ver. 2 genre name:";
      point = new Point(8, 0xd0);
      this.txtGenreName.Location = point;
      this.txtGenreName.Name = "txtGenreName";
      size = new Size(0x248, 20);
      this.txtGenreName.Size = size;
      this.txtGenreName.TabIndex = 11;
      this.txtGenreName.Text = "";
      this.GenreList.Columns.AddRange(new ColumnHeader[] { this.colHName, this.colHV1V2, this.colHV2V1 });
      this.GenreList.FullRowSelect = true;
      this.GenreList.GridLines = true;
      point = new Point(8, 8);
      this.GenreList.Location = point;
      this.GenreList.Name = "GenreList";
      size = new Size(0x248, 0xb0);
      this.GenreList.Size = size;
      this.GenreList.Sorting = SortOrder.Ascending;
      this.GenreList.TabIndex = 0x12;
      this.GenreList.View = View.Details;
      this.colHName.Text = "Own TAG Ver. 2 genre";
      this.colHName.Width = 0xb2;
      this.colHV1V2.Text = "TAG Ver. 1 genre for transfer 1 ->  2";
      this.colHV1V2.Width = 0xbd;
      this.colHV2V1.Text = "TAG Ver. 1 genre for transfer 2 ->1";
      this.colHV2V1.Width = 0xb6;
      this.lblDescArtist.BackColor = Color.Transparent;
      this.lblDescArtist.BorderStyle = BorderStyle.Fixed3D;
      this.lblDescArtist.ImeMode = ImeMode.NoControl;
      point = new Point(9, 0x150);
      this.lblDescArtist.Location = point;
      this.lblDescArtist.Name = "lblDescArtist";
      size = new Size(0x247, 0x40);
      this.lblDescArtist.Size = size;
      this.lblDescArtist.TabIndex = 9;
      this.lblDescArtist.Text = "You can add the name of the artists you are using to this library and every time you enter an artist name in a dialog, these Artists will be shown as a suggestion. The buttons \"Get artists\" will add the artists found in the currently shown files.";
      this.lblDescArtist.TextAlign = ContentAlignment.MiddleCenter;
      this.btnClearA.BackColor = SystemColors.Control;
      this.btnClearA.ImeMode = ImeMode.NoControl;
      point = new Point(0xd1, 0x110);
      this.btnClearA.Location = point;
      this.btnClearA.Name = "btnClearA";
      size = new Size(0xb8, 0x18);
      this.btnClearA.Size = size;
      this.btnClearA.TabIndex = 5;
      this.btnClearA.Text = "Clea&r Library";
      this.btnDeleteA.BackColor = SystemColors.Control;
      this.btnDeleteA.ImeMode = ImeMode.NoControl;
      point = new Point(0xd1, 240);
      this.btnDeleteA.Location = point;
      this.btnDeleteA.Name = "btnDeleteA";
      size = new Size(0xb8, 0x18);
      this.btnDeleteA.Size = size;
      this.btnDeleteA.TabIndex = 4;
      this.btnDeleteA.Text = "&Delete selected artist";
      this.btnAdd.BackColor = SystemColors.Control;
      this.btnAdd.ImeMode = ImeMode.NoControl;
      point = new Point(9, 240);
      this.btnAdd.Location = point;
      this.btnAdd.Name = "btnAdd";
      size = new Size(0xb8, 0x18);
      this.btnAdd.Size = size;
      this.btnAdd.TabIndex = 3;
      this.btnAdd.Text = "&Add artist to library";
      this.lblArtistName.BackColor = Color.Transparent;
      this.lblArtistName.ImeMode = ImeMode.NoControl;
      point = new Point(9, 0xc0);
      this.lblArtistName.Location = point;
      this.lblArtistName.Name = "lblArtistName";
      size = new Size(0x247, 0x10);
      this.lblArtistName.Size = size;
      this.lblArtistName.TabIndex = 1;
      this.lblArtistName.Text = "&New artist name:";
      point = new Point(8, 0xd0);
      this.txtArtistName.Location = point;
      this.txtArtistName.Name = "txtArtistName";
      size = new Size(0x248, 20);
      this.txtArtistName.Size = size;
      this.txtArtistName.TabIndex = 2;
      this.txtArtistName.Text = "";
      this.btnGetArtistV1.BackColor = SystemColors.Control;
      this.btnGetArtistV1.ImeMode = ImeMode.NoControl;
      point = new Point(0x199, 240);
      this.btnGetArtistV1.Location = point;
      this.btnGetArtistV1.Name = "btnGetArtistV1";
      size = new Size(0xb8, 0x18);
      this.btnGetArtistV1.Size = size;
      this.btnGetArtistV1.TabIndex = 6;
      this.btnGetArtistV1.Text = "Get artists from TAGs Ver. &1";
      point = new Point(8, 8);
      this.ArtistList.Location = point;
      this.ArtistList.Name = "ArtistList";
      size = new Size(0x248, 0xad);
      this.ArtistList.Size = size;
      this.ArtistList.TabIndex = 8;
      this.btnGetArtistV2.BackColor = SystemColors.Control;
      this.btnGetArtistV2.ImeMode = ImeMode.NoControl;
      point = new Point(0x199, 0x110);
      this.btnGetArtistV2.Location = point;
      this.btnGetArtistV2.Name = "btnGetArtistV2";
      size = new Size(0xb8, 0x18);
      this.btnGetArtistV2.Size = size;
      this.btnGetArtistV2.TabIndex = 7;
      this.btnGetArtistV2.Text = "Get artists from TAGs Ver. &2";
      this.btnClearCommD.BackColor = SystemColors.Control;
      this.btnClearCommD.ImeMode = ImeMode.NoControl;
      point = new Point(0x198, 0xed);
      this.btnClearCommD.Location = point;
      this.btnClearCommD.Name = "btnClearCommD";
      size = new Size(0xb8, 0x18);
      this.btnClearCommD.Size = size;
      this.btnClearCommD.TabIndex = 0x1a;
      this.btnClearCommD.Text = "Clea&r Library";
      this.btnRemoveCommD.BackColor = SystemColors.Control;
      this.btnRemoveCommD.ImeMode = ImeMode.NoControl;
      point = new Point(0xd0, 0xed);
      this.btnRemoveCommD.Location = point;
      this.btnRemoveCommD.Name = "btnRemoveCommD";
      size = new Size(0xb8, 0x18);
      this.btnRemoveCommD.Size = size;
      this.btnRemoveCommD.TabIndex = 0x19;
      this.btnRemoveCommD.Text = "&Delete selected com. descriptor";
      this.btnAddCommD.BackColor = SystemColors.Control;
      this.btnAddCommD.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0xed);
      this.btnAddCommD.Location = point;
      this.btnAddCommD.Name = "btnAddCommD";
      size = new Size(0xb8, 0x18);
      this.btnAddCommD.Size = size;
      this.btnAddCommD.TabIndex = 0x18;
      this.btnAddCommD.Text = "&Add com. descriptor to library";
      this.Label3.BackColor = Color.Transparent;
      this.Label3.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0xc0);
      this.Label3.Location = point;
      this.Label3.Name = "Label3";
      size = new Size(0x248, 0x10);
      this.Label3.Size = size;
      this.Label3.TabIndex = 0x16;
      this.Label3.Text = "&New comment descriptor:";
      point = new Point(8, 0xd0);
      this.txtNewCommD.Location = point;
      this.txtNewCommD.Name = "txtNewCommD";
      size = new Size(0x248, 20);
      this.txtNewCommD.Size = size;
      this.txtNewCommD.TabIndex = 0x17;
      this.txtNewCommD.Text = "";
      point = new Point(8, 8);
      this.CommDList.Location = point;
      this.CommDList.Name = "CommDList";
      size = new Size(0x248, 0xad);
      this.CommDList.Size = size;
      this.CommDList.TabIndex = 0x1b;
      this.lblInfo2.BackColor = Color.Transparent;
      this.lblInfo2.BorderStyle = BorderStyle.Fixed3D;
      this.lblInfo2.ImeMode = ImeMode.NoControl;
      point = new Point(7, 0x170);
      this.lblInfo2.Location = point;
      this.lblInfo2.Name = "lblInfo2";
      size = new Size(0x249, 0x20);
      this.lblInfo2.Size = size;
      this.lblInfo2.TabIndex = 0x15;
      this.lblInfo2.Text = "Add or remove comment descriptors which will be displayed in the TAG Ver. 2 Edit dialogs.";
      this.lblInfo2.TextAlign = ContentAlignment.MiddleCenter;
      this.btnCancel.BackColor = SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      point = new Point(0x1d8, 8);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      size = new Size(120, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x15;
      this.btnCancel.Text = "&Cancel";
      this.btnOK.BackColor = SystemColors.Control;
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(0x158, 8);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(120, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 20;
      this.btnOK.Text = "&OK";
      this.Libraries.CanReorderTabs = true;
      this.Libraries.Controls.Add(this.TabControlPanel1);
      this.Libraries.Controls.Add(this.TabControlPanel4);
      this.Libraries.Controls.Add(this.TabControlPanel2);
      this.Libraries.Controls.Add(this.TabControlPanel3);
      this.Libraries.Dock = DockStyle.Fill;
      point = new Point(0, 0);
      this.Libraries.Location = point;
      this.Libraries.Name = "Libraries";
      this.Libraries.SelectedTabFont = new Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold);
      this.Libraries.SelectedTabIndex = 0;
      size = new Size(0x25a, 440);
      this.Libraries.Size = size;
      this.Libraries.Style = eTabStripStyle.VS2005Document;
      this.Libraries.TabIndex = 0x16;
      this.Libraries.TabLayoutType = eTabLayoutType.FixedWithNavigationBox;
      this.Libraries.Tabs.Add(this.Favourites);
      this.Libraries.Tabs.Add(this.Genre);
      this.Libraries.Tabs.Add(this.Artist);
      this.Libraries.Tabs.Add(this.Comment);
      this.TabControlPanel4.AntiAlias = true;
      this.TabControlPanel4.Controls.Add(this.btnClearCommD);
      this.TabControlPanel4.Controls.Add(this.btnAddCommD);
      this.TabControlPanel4.Controls.Add(this.Label3);
      this.TabControlPanel4.Controls.Add(this.txtNewCommD);
      this.TabControlPanel4.Controls.Add(this.btnRemoveCommD);
      this.TabControlPanel4.Controls.Add(this.CommDList);
      this.TabControlPanel4.Controls.Add(this.lblInfo2);
      this.TabControlPanel4.Dock = DockStyle.Fill;
      this.TabControlPanel4.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel4.Location = point;
      this.TabControlPanel4.Name = "TabControlPanel4";
      size = new Size(0x25a, 0x19e);
      this.TabControlPanel4.Size = size;
      this.TabControlPanel4.Style.BackColor2.Color = Color.FromArgb(0xfb, 250, 0xf7);
      this.TabControlPanel4.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel4.Style.BorderColor.Color = Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel4.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel4.Style.GradientAngle = 90;
      this.TabControlPanel4.TabIndex = 4;
      this.TabControlPanel4.TabItem = this.Comment;
      this.Comment.AttachedControl = this.TabControlPanel4;
      this.Comment.Name = "Comment";
      this.Comment.Text = "Comment descriptor Library";
      this.TabControlPanel1.AntiAlias = true;
      this.TabControlPanel1.Controls.Add(this.btnAddFavDir);
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
      this.TabControlPanel1.Dock = DockStyle.Fill;
      this.TabControlPanel1.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel1.Location = point;
      this.TabControlPanel1.Name = "TabControlPanel1";
      size = new Size(0x25a, 0x19e);
      this.TabControlPanel1.Size = size;
      this.TabControlPanel1.Style.BackColor2.Color = Color.FromArgb(0xfb, 250, 0xf7);
      this.TabControlPanel1.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel1.Style.BorderColor.Color = Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel1.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel1.Style.GradientAngle = 90;
      this.TabControlPanel1.TabIndex = 1;
      this.TabControlPanel1.TabItem = this.Favourites;
      this.Favourites.AttachedControl = this.TabControlPanel1;
      this.Favourites.Name = "Favourites";
      this.Favourites.Text = "Favourites Library";
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
      this.TabControlPanel2.Dock = DockStyle.Fill;
      this.TabControlPanel2.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel2.Location = point;
      this.TabControlPanel2.Name = "TabControlPanel2";
      size = new Size(0x25a, 0x19e);
      this.TabControlPanel2.Size = size;
      this.TabControlPanel2.Style.BackColor2.Color = Color.FromArgb(0xfb, 250, 0xf7);
      this.TabControlPanel2.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel2.Style.BorderColor.Color = Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel2.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel2.Style.GradientAngle = 90;
      this.TabControlPanel2.TabIndex = 2;
      this.TabControlPanel2.TabItem = this.Genre;
      this.Genre.AttachedControl = this.TabControlPanel2;
      this.Genre.Name = "Genre";
      this.Genre.Text = "Genre Library";
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
      this.TabControlPanel3.Dock = DockStyle.Fill;
      this.TabControlPanel3.DockPadding.All = 1;
      point = new Point(0, 0x1a);
      this.TabControlPanel3.Location = point;
      this.TabControlPanel3.Name = "TabControlPanel3";
      size = new Size(0x25a, 0x19e);
      this.TabControlPanel3.Size = size;
      this.TabControlPanel3.Style.BackColor2.Color = Color.FromArgb(0xfb, 250, 0xf7);
      this.TabControlPanel3.Style.Border = eBorderType.SingleLine;
      this.TabControlPanel3.Style.BorderColor.Color = Color.FromArgb(0x7f, 0x9d, 0xb9);
      this.TabControlPanel3.Style.BorderSide = eBorderSide.Bottom | eBorderSide.Right | eBorderSide.Left;
      this.TabControlPanel3.Style.GradientAngle = 90;
      this.TabControlPanel3.TabIndex = 3;
      this.TabControlPanel3.TabItem = this.Artist;
      this.Artist.AttachedControl = this.TabControlPanel3;
      this.Artist.Name = "Artist";
      this.Artist.Text = "Artist Library";
      this.ButtomPanel.AntiAlias = true;
      this.ButtomPanel.Controls.Add(this.btnCancel);
      this.ButtomPanel.Controls.Add(this.btnOK);
      this.ButtomPanel.Dock = DockStyle.Bottom;
      point = new Point(0, 440);
      this.ButtomPanel.Location = point;
      this.ButtomPanel.Name = "ButtomPanel";
      size = new Size(0x25a, 40);
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
      this.ButtomPanel.TabIndex = 0x76;
      this.AcceptButton = this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = this.btnCancel;
      size = new Size(0x25a, 480);
      this.ClientSize = size;
      this.ControlBox = false;
      this.Controls.Add(this.Libraries);
      this.Controls.Add(this.ButtomPanel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmLibraries";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Libraries";
      ((ISupportInitialize)this.Libraries).EndInit();
      this.Libraries.ResumeLayout(false);
      this.TabControlPanel4.ResumeLayout(false);
      this.TabControlPanel1.ResumeLayout(false);
      this.TabControlPanel2.ResumeLayout(false);
      this.TabControlPanel3.ResumeLayout(false);
      this.ButtomPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    private void LibCB(ref frmProgress frmProg)
    {
      using (IEnumerator enumerator = frmProg.List.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          string sLeft = StringType.FromObject(enumerator.Current);
          Application.DoEvents();
          if (frmProg.Canceled)
          {
            return;
          }
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
    }

    private void V1CB(ref frmProgress frmProg)
    {
      IEnumerator enumerator;
      try
      {
        enumerator = Declarations.MP3s.GetEnumerator();
        while (enumerator.MoveNext())
        {
          MP3 current = (MP3)enumerator.Current;
          if (current.V1TAG.TAGPresent && !frmProg.List.Contains(current.V1TAG.Artist))
          {
            frmProg.List.Add(current.V1TAG.Artist);
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

    private void V2CB(ref frmProgress frmProg)
    {
      IEnumerator enumerator;
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
            {
              frmProg.List.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null)));
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

    internal virtual TabItem Artist
    {
      get
      {
        return this._Artist;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Artist != null)
        {
        }
        this._Artist = value;
        if (this._Artist != null)
        {
        }
      }
    }

    internal virtual ListBox ArtistList
    {
      get
      {
        return this._ArtistList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ArtistList != null)
        {
        }
        this._ArtistList = value;
        if (this._ArtistList != null)
        {
        }
      }
    }

    internal virtual Button btnAdd
    {
      get
      {
        return this._btnAdd;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAdd != null)
        {
          this._btnAdd.Click -= new EventHandler(this.btnAdd_Click);
        }
        this._btnAdd = value;
        if (this._btnAdd != null)
        {
          this._btnAdd.Click += new EventHandler(this.btnAdd_Click);
        }
      }
    }

    internal virtual Button btnAddCommD
    {
      get
      {
        return this._btnAddCommD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddCommD != null)
        {
          this._btnAddCommD.Click -= new EventHandler(this.btnAddCommD_Click);
        }
        this._btnAddCommD = value;
        if (this._btnAddCommD != null)
        {
          this._btnAddCommD.Click += new EventHandler(this.btnAddCommD_Click);
        }
      }
    }

    internal virtual Button btnAddFav
    {
      get
      {
        return this._btnAddFav;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddFav != null)
        {
          this._btnAddFav.Click -= new EventHandler(this.btnAddFav_Click);
        }
        this._btnAddFav = value;
        if (this._btnAddFav != null)
        {
          this._btnAddFav.Click += new EventHandler(this.btnAddFav_Click);
        }
      }
    }

    internal virtual Button btnAddFavDir
    {
      get
      {
        return this._btnAddFavDir;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddFavDir != null)
        {
          this._btnAddFavDir.Click -= new EventHandler(this.btnAddFavDir_Click);
        }
        this._btnAddFavDir = value;
        if (this._btnAddFavDir != null)
        {
          this._btnAddFavDir.Click += new EventHandler(this.btnAddFavDir_Click);
        }
      }
    }

    internal virtual Button btnAddG
    {
      get
      {
        return this._btnAddG;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnAddG != null)
        {
          this._btnAddG.Click -= new EventHandler(this.btnAddG_Click);
        }
        this._btnAddG = value;
        if (this._btnAddG != null)
        {
          this._btnAddG.Click += new EventHandler(this.btnAddG_Click);
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
        }
        this._btnCancel = value;
        if (this._btnCancel != null)
        {
        }
      }
    }

    internal virtual Button btnClearA
    {
      get
      {
        return this._btnClearA;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnClearA != null)
        {
          this._btnClearA.Click -= new EventHandler(this.btnClearA_Click);
        }
        this._btnClearA = value;
        if (this._btnClearA != null)
        {
          this._btnClearA.Click += new EventHandler(this.btnClearA_Click);
        }
      }
    }

    internal virtual Button btnClearCommD
    {
      get
      {
        return this._btnClearCommD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnClearCommD != null)
        {
          this._btnClearCommD.Click -= new EventHandler(this.btnClearCommD_Click);
        }
        this._btnClearCommD = value;
        if (this._btnClearCommD != null)
        {
          this._btnClearCommD.Click += new EventHandler(this.btnClearCommD_Click);
        }
      }
    }

    internal virtual Button btnDeleteA
    {
      get
      {
        return this._btnDeleteA;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnDeleteA != null)
        {
          this._btnDeleteA.Click -= new EventHandler(this.btnDelete_Click);
        }
        this._btnDeleteA = value;
        if (this._btnDeleteA != null)
        {
          this._btnDeleteA.Click += new EventHandler(this.btnDelete_Click);
        }
      }
    }

    internal virtual Button btnDeleteG
    {
      get
      {
        return this._btnDeleteG;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnDeleteG != null)
        {
          this._btnDeleteG.Click -= new EventHandler(this.btnDeleteG_Click);
        }
        this._btnDeleteG = value;
        if (this._btnDeleteG != null)
        {
          this._btnDeleteG.Click += new EventHandler(this.btnDeleteG_Click);
        }
      }
    }

    internal virtual Button btnFavBrowse
    {
      get
      {
        return this._btnFavBrowse;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnFavBrowse != null)
        {
          this._btnFavBrowse.Click -= new EventHandler(this.btnFavBrowse_Click);
        }
        this._btnFavBrowse = value;
        if (this._btnFavBrowse != null)
        {
          this._btnFavBrowse.Click += new EventHandler(this.btnFavBrowse_Click);
        }
      }
    }

    internal virtual Button btnGetArtistV1
    {
      get
      {
        return this._btnGetArtistV1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnGetArtistV1 != null)
        {
          this._btnGetArtistV1.Click -= new EventHandler(this.btnGetArtist_Click);
        }
        this._btnGetArtistV1 = value;
        if (this._btnGetArtistV1 != null)
        {
          this._btnGetArtistV1.Click += new EventHandler(this.btnGetArtist_Click);
        }
      }
    }

    internal virtual Button btnGetArtistV2
    {
      get
      {
        return this._btnGetArtistV2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnGetArtistV2 != null)
        {
          this._btnGetArtistV2.Click -= new EventHandler(this.btnGetArtist_Click);
        }
        this._btnGetArtistV2 = value;
        if (this._btnGetArtistV2 != null)
        {
          this._btnGetArtistV2.Click += new EventHandler(this.btnGetArtist_Click);
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

    internal virtual Button btnRemoveCommD
    {
      get
      {
        return this._btnRemoveCommD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveCommD != null)
        {
          this._btnRemoveCommD.Click -= new EventHandler(this.btnRemoveCommD_Click);
        }
        this._btnRemoveCommD = value;
        if (this._btnRemoveCommD != null)
        {
          this._btnRemoveCommD.Click += new EventHandler(this.btnRemoveCommD_Click);
        }
      }
    }

    internal virtual Button btnRemoveFav
    {
      get
      {
        return this._btnRemoveFav;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveFav != null)
        {
          this._btnRemoveFav.Click -= new EventHandler(this.btnRemoveFav_Click);
        }
        this._btnRemoveFav = value;
        if (this._btnRemoveFav != null)
        {
          this._btnRemoveFav.Click += new EventHandler(this.btnRemoveFav_Click);
        }
      }
    }

    internal virtual Button btnRemoveFavDir
    {
      get
      {
        return this._btnRemoveFavDir;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnRemoveFavDir != null)
        {
          this._btnRemoveFavDir.Click -= new EventHandler(this.btnRemoveFavDir_Click);
        }
        this._btnRemoveFavDir = value;
        if (this._btnRemoveFavDir != null)
        {
          this._btnRemoveFavDir.Click += new EventHandler(this.btnRemoveFavDir_Click);
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

    internal virtual CheckBox chkOnlyOwn
    {
      get
      {
        return this._chkOnlyOwn;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkOnlyOwn != null)
        {
        }
        this._chkOnlyOwn = value;
        if (this._chkOnlyOwn != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbV1V2
    {
      get
      {
        return this._cmbV1V2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbV1V2 != null)
        {
        }
        this._cmbV1V2 = value;
        if (this._cmbV1V2 != null)
        {
        }
      }
    }

    internal virtual ComboBox cmbV2V1
    {
      get
      {
        return this._cmbV2V1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._cmbV2V1 != null)
        {
        }
        this._cmbV2V1 = value;
        if (this._cmbV2V1 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader colHName
    {
      get
      {
        return this._colHName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._colHName != null)
        {
        }
        this._colHName = value;
        if (this._colHName != null)
        {
        }
      }
    }

    internal virtual ColumnHeader colHV1V2
    {
      get
      {
        return this._colHV1V2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._colHV1V2 != null)
        {
        }
        this._colHV1V2 = value;
        if (this._colHV1V2 != null)
        {
        }
      }
    }

    internal virtual ColumnHeader colHV2V1
    {
      get
      {
        return this._colHV2V1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._colHV2V1 != null)
        {
        }
        this._colHV2V1 = value;
        if (this._colHV2V1 != null)
        {
        }
      }
    }

    internal virtual ListBox CommDList
    {
      get
      {
        return this._CommDList;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._CommDList != null)
        {
        }
        this._CommDList = value;
        if (this._CommDList != null)
        {
        }
      }
    }

    internal virtual TabItem Comment
    {
      get
      {
        return this._Comment;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Comment != null)
        {
        }
        this._Comment = value;
        if (this._Comment != null)
        {
        }
      }
    }

    internal virtual TabItem Favourites
    {
      get
      {
        return this._Favourites;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Favourites != null)
        {
        }
        this._Favourites = value;
        if (this._Favourites != null)
        {
        }
      }
    }

    internal virtual TreeView FavTree
    {
      get
      {
        return this._FavTree;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._FavTree != null)
        {
        }
        this._FavTree = value;
        if (this._FavTree != null)
        {
        }
      }
    }

    internal virtual System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog
    {
      get
      {
        return this._FolderBrowserDialog;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._FolderBrowserDialog != null)
        {
        }
        this._FolderBrowserDialog = value;
        if (this._FolderBrowserDialog != null)
        {
        }
      }
    }

    internal virtual TabItem Genre
    {
      get
      {
        return this._Genre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Genre != null)
        {
        }
        this._Genre = value;
        if (this._Genre != null)
        {
        }
      }
    }

    internal virtual ListView GenreList
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
          this._GenreList.SelectedIndexChanged -= new EventHandler(this.GenreList_SelectedIndexChanged);
        }
        this._GenreList = value;
        if (this._GenreList != null)
        {
          this._GenreList.SelectedIndexChanged += new EventHandler(this.GenreList_SelectedIndexChanged);
        }
      }
    }

    internal virtual Label Label1
    {
      get
      {
        return this._Label1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label1 != null)
        {
        }
        this._Label1 = value;
        if (this._Label1 != null)
        {
        }
      }
    }

    internal virtual Label Label2
    {
      get
      {
        return this._Label2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label2 != null)
        {
        }
        this._Label2 = value;
        if (this._Label2 != null)
        {
        }
      }
    }

    internal virtual Label Label3
    {
      get
      {
        return this._Label3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Label3 != null)
        {
        }
        this._Label3 = value;
        if (this._Label3 != null)
        {
        }
      }
    }

    internal virtual Label lblArtistName
    {
      get
      {
        return this._lblArtistName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblArtistName != null)
        {
        }
        this._lblArtistName = value;
        if (this._lblArtistName != null)
        {
        }
      }
    }

    internal virtual Label lblCorres
    {
      get
      {
        return this._lblCorres;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblCorres != null)
        {
        }
        this._lblCorres = value;
        if (this._lblCorres != null)
        {
        }
      }
    }

    internal virtual Label lblDescArtist
    {
      get
      {
        return this._lblDescArtist;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblDescArtist != null)
        {
        }
        this._lblDescArtist = value;
        if (this._lblDescArtist != null)
        {
        }
      }
    }

    internal virtual Label lblDescGenre
    {
      get
      {
        return this._lblDescGenre;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblDescGenre != null)
        {
        }
        this._lblDescGenre = value;
        if (this._lblDescGenre != null)
        {
        }
      }
    }

    internal virtual Label lblGenreName
    {
      get
      {
        return this._lblGenreName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblGenreName != null)
        {
        }
        this._lblGenreName = value;
        if (this._lblGenreName != null)
        {
        }
      }
    }

    internal virtual Label lblInfo1
    {
      get
      {
        return this._lblInfo1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblInfo1 != null)
        {
        }
        this._lblInfo1 = value;
        if (this._lblInfo1 != null)
        {
        }
      }
    }

    internal virtual Label lblInfo2
    {
      get
      {
        return this._lblInfo2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblInfo2 != null)
        {
        }
        this._lblInfo2 = value;
        if (this._lblInfo2 != null)
        {
        }
      }
    }

    internal virtual DevComponents.DotNetBar.TabControl Libraries
    {
      get
      {
        return this._Libraries;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Libraries != null)
        {
        }
        this._Libraries = value;
        if (this._Libraries != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel1
    {
      get
      {
        return this._TabControlPanel1;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel1 != null)
        {
        }
        this._TabControlPanel1 = value;
        if (this._TabControlPanel1 != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel2
    {
      get
      {
        return this._TabControlPanel2;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel2 != null)
        {
        }
        this._TabControlPanel2 = value;
        if (this._TabControlPanel2 != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel3
    {
      get
      {
        return this._TabControlPanel3;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel3 != null)
        {
        }
        this._TabControlPanel3 = value;
        if (this._TabControlPanel3 != null)
        {
        }
      }
    }

    internal virtual TabControlPanel TabControlPanel4
    {
      get
      {
        return this._TabControlPanel4;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TabControlPanel4 != null)
        {
        }
        this._TabControlPanel4 = value;
        if (this._TabControlPanel4 != null)
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

    internal virtual TextBox txtArtistName
    {
      get
      {
        return this._txtArtistName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtArtistName != null)
        {
        }
        this._txtArtistName = value;
        if (this._txtArtistName != null)
        {
        }
      }
    }

    internal virtual TextBox txtDir
    {
      get
      {
        return this._txtDir;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtDir != null)
        {
        }
        this._txtDir = value;
        if (this._txtDir != null)
        {
        }
      }
    }

    internal virtual TextBox txtGenreName
    {
      get
      {
        return this._txtGenreName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtGenreName != null)
        {
        }
        this._txtGenreName = value;
        if (this._txtGenreName != null)
        {
        }
      }
    }

    internal virtual TextBox txtName
    {
      get
      {
        return this._txtName;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtName != null)
        {
        }
        this._txtName = value;
        if (this._txtName != null)
        {
        }
      }
    }

    internal virtual TextBox txtNewCommD
    {
      get
      {
        return this._txtNewCommD;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtNewCommD != null)
        {
        }
        this._txtNewCommD = value;
        if (this._txtNewCommD != null)
        {
        }
      }
    }
  }
}