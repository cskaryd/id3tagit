using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmRemoveFolders : Form
  {
    [AccessedThroughProperty("btnBrowse")]
    private Button _btnBrowse;
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("btnOK")]
    private Button _btnOK;
    [AccessedThroughProperty("chkIgnoreOther")]
    private CheckBox _chkIgnoreOther;
    [AccessedThroughProperty("FolderBrowserDialog")]
    private System.Windows.Forms.FolderBrowserDialog _FolderBrowserDialog;
    [AccessedThroughProperty("GroupBox")]
    private System.Windows.Forms.GroupBox _GroupBox;
    [AccessedThroughProperty("lblInfo")]
    private Label _lblInfo;
    [AccessedThroughProperty("lblPath")]
    private Label _lblPath;
    [AccessedThroughProperty("lblStatus")]
    private Label _lblStatus;
    [AccessedThroughProperty("ProgressBar")]
    private System.Windows.Forms.ProgressBar _ProgressBar;
    [AccessedThroughProperty("ToolTip")]
    private System.Windows.Forms.ToolTip _ToolTip;
    [AccessedThroughProperty("txtPath")]
    private TextBox _txtPath;
    private IContainer components;
    private frmMain MainForm;
    private bool vbooCancel;

    public frmRemoveFolders(frmMain Main)
    {
      base.Load += new EventHandler(this.frmRemoveFolders_Load);
      this.vbooCancel = false;
      this.InitializeComponent();
      this.MainForm = Main;
    }

    private void AddToolTips()
    {
      string vstrName = "frmRemoveFolders";
      Control btnBrowse = this.btnBrowse;
      this.btnBrowse = (Button)btnBrowse;
      this.ToolTip.SetToolTip(this.btnBrowse, Declarations.objResources.GetToolTip(ref vstrName, ref btnBrowse));
      vstrName = "frmRemoveFolders";
      btnBrowse = this.txtPath;
      this.txtPath = (TextBox)btnBrowse;
      this.ToolTip.SetToolTip(this.txtPath, Declarations.objResources.GetToolTip(ref vstrName, ref btnBrowse));
    }

    private void btnBrowse_Click(object sender, EventArgs e)
    {
      string selectedPath = "";
      this.FolderBrowserDialog.SelectedPath = this.txtPath.Text;
      if (this.FolderBrowserDialog.ShowDialog(this) == System.Windows.Forms.DialogResult.OK)
      {
        selectedPath = this.FolderBrowserDialog.SelectedPath;
        this.txtPath.Text = selectedPath;
      }
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      ArrayList alstFolders = new ArrayList();
      if (Directory.Exists(this.txtPath.Text))
      {
        Form form = this;
        Main.SaveFormSettings(ref form);
        alstFolders.Add(this.txtPath.Text);
        this.ScanFolders(alstFolders, "*.MP3", this.txtPath.Text);
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

    private void frmRemoveFolders_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Main.WindowsXPCheck(ref objForm);
      this.txtPath.Text = Declarations.objSettings.CurrentPath;
      this.AddToolTips();
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      this.btnCancel = new Button();
      this.btnOK = new Button();
      this.GroupBox = new System.Windows.Forms.GroupBox();
      this.lblStatus = new Label();
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.btnBrowse = new Button();
      this.txtPath = new TextBox();
      this.lblInfo = new Label();
      this.lblPath = new Label();
      this.chkIgnoreOther = new CheckBox();
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.GroupBox.SuspendLayout();
      this.SuspendLayout();
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = ImeMode.NoControl;
      Point point = new Point(0x160, 0x100);
      this.btnCancel.Location = point;
      this.btnCancel.Name = "btnCancel";
      Size size = new Size(0x70, 0x18);
      this.btnCancel.Size = size;
      this.btnCancel.TabIndex = 0x13;
      this.btnCancel.Text = "&Cancel";
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = ImeMode.NoControl;
      point = new Point(0xe8, 0x100);
      this.btnOK.Location = point;
      this.btnOK.Name = "btnOK";
      size = new Size(0x70, 0x18);
      this.btnOK.Size = size;
      this.btnOK.TabIndex = 0x12;
      this.btnOK.Text = "&OK";
      this.GroupBox.Controls.Add(this.lblStatus);
      this.GroupBox.Controls.Add(this.ProgressBar);
      this.GroupBox.Enabled = false;
      point = new Point(8, 0xa8);
      this.GroupBox.Location = point;
      this.GroupBox.Name = "GroupBox";
      size = new Size(0x1d0, 80);
      this.GroupBox.Size = size;
      this.GroupBox.TabIndex = 20;
      this.GroupBox.TabStop = false;
      this.GroupBox.Text = "Progress ...";
      this.lblStatus.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x18);
      this.lblStatus.Location = point;
      this.lblStatus.Name = "lblStatus";
      size = new Size(0x1c0, 0x10);
      this.lblStatus.Size = size;
      this.lblStatus.TabIndex = 1;
      this.lblStatus.Text = "Status";
      this.ProgressBar.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x30);
      this.ProgressBar.Location = point;
      this.ProgressBar.Name = "ProgressBar";
      size = new Size(0x1c0, 0x10);
      this.ProgressBar.Size = size;
      this.ProgressBar.TabIndex = 0;
      this.btnBrowse.ImeMode = ImeMode.NoControl;
      point = new Point(0x180, 0x34);
      this.btnBrowse.Location = point;
      this.btnBrowse.Name = "btnBrowse";
      size = new Size(0x58, 0x18);
      this.btnBrowse.Size = size;
      this.btnBrowse.TabIndex = 0x18;
      this.btnBrowse.Text = "&Browse ...";
      point = new Point(0x48, 0x36);
      this.txtPath.Location = point;
      this.txtPath.Name = "txtPath";
      size = new Size(0x130, 20);
      this.txtPath.Size = size;
      this.txtPath.TabIndex = 0x17;
      this.txtPath.Text = "";
      this.lblInfo.ImeMode = ImeMode.NoControl;
      point = new Point(8, 8);
      this.lblInfo.Location = point;
      this.lblInfo.Name = "lblInfo";
      size = new Size(0x1d0, 0x20);
      this.lblInfo.Size = size;
      this.lblInfo.TabIndex = 0x15;
      this.lblInfo.Text = "This function will scan a folder with its subdirectories and remove all subdirectories which do not contain any files.";
      this.lblPath.ImeMode = ImeMode.NoControl;
      point = new Point(8, 0x38);
      this.lblPath.Location = point;
      this.lblPath.Name = "lblPath";
      size = new Size(0x40, 0x10);
      this.lblPath.Size = size;
      this.lblPath.TabIndex = 0x16;
      this.lblPath.Text = "&Root-Path:";
      this.chkIgnoreOther.ImeMode = ImeMode.NoControl;
      point = new Point(0x48, 0x58);
      this.chkIgnoreOther.Location = point;
      this.chkIgnoreOther.Name = "chkIgnoreOther";
      size = new Size(0x130, 0x38);
      this.chkIgnoreOther.Size = size;
      this.chkIgnoreOther.TabIndex = 0x19;
      this.chkIgnoreOther.Text = "Delete all folders with no MP3 files ignoring any other possible present files. (WARNING: This will delete non MP3 files when no MP3 files are found in a folder)";
      this.AcceptButton = this.btnOK;
      size = new Size(5, 13);
      this.AutoScaleBaseSize = size;
      this.CancelButton = this.btnCancel;
      size = new Size(480, 0x120);
      this.ClientSize = size;
      this.ControlBox = false;
      this.Controls.Add(this.chkIgnoreOther);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.lblPath);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.GroupBox);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.Name = "frmRemoveFolders";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterParent;
      this.Text = "Remove empty folders";
      this.GroupBox.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public void ScanFolders(ArrayList alstFolders, string vstrSearchPattern, string vstrStartFolder)
    {
      foreach (string str in alstFolders)
      {
        try
        {
          string path = str;

          if (path.EndsWith(":"))
            path = path + @"\";

          DirectoryInfo info = new DirectoryInfo(path);
          foreach (DirectoryInfo info2 in info.GetDirectories())
          {
            ArrayList list = new ArrayList { info2.FullName };
            this.ScanFolders(list, vstrSearchPattern, vstrStartFolder);
          }

          if (StringType.StrCmp(path.ToLower(), vstrStartFolder.ToLower(), false) == 0)
            return;

          info.Refresh();
          Application.DoEvents();
          DirectoryInfo[] directories = info.GetDirectories();
          FileInfo[] files = info.GetFiles(vstrSearchPattern);
          if ((directories.GetLength(0) <= 0) && (files.GetLength(0) <= 0))
          {
            if (this.chkIgnoreOther.Checked)
            {
              try
              {
                Directory.Delete(path, true);
              }
              catch (Exception exception1)
              {
                ProjectData.SetProjectError(exception1);
                ProjectData.ClearProjectError();
              }
            }
            else if (info.GetFiles("*.*").GetLength(0) <= 0)
            {
              try
              {
                Directory.Delete(path, false);
              }
              catch (Exception exception2)
              {
                ProjectData.SetProjectError(exception2);
                ProjectData.ClearProjectError();
              }
            }
          }
          continue;
        }
        catch (Exception exception3)
        {
          ProjectData.SetProjectError(exception3);
          ProjectData.ClearProjectError();
          continue;
        }
      }
    }

    public Button btnBrowse
    {
      get
      {
        return this._btnBrowse;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._btnBrowse != null)
        {
          this._btnBrowse.Click -= new EventHandler(this.btnBrowse_Click);
        }
        this._btnBrowse = value;
        if (this._btnBrowse != null)
        {
          this._btnBrowse.Click += new EventHandler(this.btnBrowse_Click);
        }
      }
    }

    public Button btnCancel
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

    public Button btnOK
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

    public CheckBox chkIgnoreOther
    {
      get
      {
        return this._chkIgnoreOther;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._chkIgnoreOther != null)
        {
        }
        this._chkIgnoreOther = value;
        if (this._chkIgnoreOther != null)
        {
        }
      }
    }

    public System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog
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

    public System.Windows.Forms.GroupBox GroupBox
    {
      get
      {
        return this._GroupBox;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._GroupBox != null)
        {
        }
        this._GroupBox = value;
        if (this._GroupBox != null)
        {
        }
      }
    }

    public Label lblInfo
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

    public Label lblPath
    {
      get
      {
        return this._lblPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblPath != null)
        {
        }
        this._lblPath = value;
        if (this._lblPath != null)
        {
        }
      }
    }

    public Label lblStatus
    {
      get
      {
        return this._lblStatus;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._lblStatus != null)
        {
        }
        this._lblStatus = value;
        if (this._lblStatus != null)
        {
        }
      }
    }

    public System.Windows.Forms.ProgressBar ProgressBar
    {
      get
      {
        return this._ProgressBar;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._ProgressBar != null)
        {
        }
        this._ProgressBar = value;
        if (this._ProgressBar != null)
        {
        }
      }
    }

    public System.Windows.Forms.ToolTip ToolTip
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

    public TextBox txtPath
    {
      get
      {
        return this._txtPath;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._txtPath != null)
        {
        }
        this._txtPath = value;
        if (this._txtPath != null)
        {
        }
      }
    }
  }
}