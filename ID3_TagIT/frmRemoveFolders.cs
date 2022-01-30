using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmRemoveFolders : Form
  {
    #region Designer

    private Button btnBrowse;
    private Button btnCancel;
    private Button btnOK;
    private CheckBox chkIgnoreOther;
    private System.Windows.Forms.FolderBrowserDialog FolderBrowserDialog;
    private System.Windows.Forms.GroupBox GroupBox;
    private Label lblInfo;
    private Label lblPath;
    private Label lblStatus;
    private System.Windows.Forms.ProgressBar ProgressBar;
    private System.Windows.Forms.ToolTip ToolTip;
    private TextBox txtPath;
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
      this.btnCancel = new System.Windows.Forms.Button();
      this.btnOK = new System.Windows.Forms.Button();
      this.GroupBox = new System.Windows.Forms.GroupBox();
      this.lblStatus = new System.Windows.Forms.Label();
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.ToolTip = new System.Windows.Forms.ToolTip(this.components);
      this.btnBrowse = new System.Windows.Forms.Button();
      this.txtPath = new System.Windows.Forms.TextBox();
      this.lblInfo = new System.Windows.Forms.Label();
      this.lblPath = new System.Windows.Forms.Label();
      this.chkIgnoreOther = new System.Windows.Forms.CheckBox();
      this.FolderBrowserDialog = new System.Windows.Forms.FolderBrowserDialog();
      this.GroupBox.SuspendLayout();
      this.SuspendLayout();
      // 
      // btnCancel
      // 
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(352, 256);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(112, 24);
      this.btnCancel.TabIndex = 19;
      this.btnCancel.Text = "&Cancel";
      // 
      // btnOK
      // 
      this.btnOK.DialogResult = System.Windows.Forms.DialogResult.OK;
      this.btnOK.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnOK.Location = new System.Drawing.Point(232, 256);
      this.btnOK.Name = "btnOK";
      this.btnOK.Size = new System.Drawing.Size(112, 24);
      this.btnOK.TabIndex = 18;
      this.btnOK.Text = "&OK";
      this.btnOK.Click += new System.EventHandler(this.btnOK_Click);
      // 
      // GroupBox
      // 
      this.GroupBox.Controls.Add(this.lblStatus);
      this.GroupBox.Controls.Add(this.ProgressBar);
      this.GroupBox.Enabled = false;
      this.GroupBox.Location = new System.Drawing.Point(8, 168);
      this.GroupBox.Name = "GroupBox";
      this.GroupBox.Size = new System.Drawing.Size(464, 80);
      this.GroupBox.TabIndex = 20;
      this.GroupBox.TabStop = false;
      this.GroupBox.Text = "Progress ...";
      // 
      // lblStatus
      // 
      this.lblStatus.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblStatus.Location = new System.Drawing.Point(8, 24);
      this.lblStatus.Name = "lblStatus";
      this.lblStatus.Size = new System.Drawing.Size(448, 16);
      this.lblStatus.TabIndex = 1;
      this.lblStatus.Text = "Status";
      // 
      // ProgressBar
      // 
      this.ProgressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ProgressBar.Location = new System.Drawing.Point(8, 48);
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Size = new System.Drawing.Size(448, 16);
      this.ProgressBar.TabIndex = 0;
      // 
      // btnBrowse
      // 
      this.btnBrowse.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnBrowse.Location = new System.Drawing.Point(384, 52);
      this.btnBrowse.Name = "btnBrowse";
      this.btnBrowse.Size = new System.Drawing.Size(88, 24);
      this.btnBrowse.TabIndex = 24;
      this.btnBrowse.Text = "&Browse ...";
      this.btnBrowse.Click += new System.EventHandler(this.btnBrowse_Click);
      // 
      // txtPath
      // 
      this.txtPath.Location = new System.Drawing.Point(72, 54);
      this.txtPath.Name = "txtPath";
      this.txtPath.Size = new System.Drawing.Size(304, 20);
      this.txtPath.TabIndex = 23;
      // 
      // lblInfo
      // 
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(8, 8);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(464, 32);
      this.lblInfo.TabIndex = 21;
      this.lblInfo.Text = "This function will scan a folder with its subdirectories and remove all subdirect" +
    "ories which do not contain any files.";
      // 
      // lblPath
      // 
      this.lblPath.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblPath.Location = new System.Drawing.Point(8, 56);
      this.lblPath.Name = "lblPath";
      this.lblPath.Size = new System.Drawing.Size(64, 16);
      this.lblPath.TabIndex = 22;
      this.lblPath.Text = "&Root-Path:";
      // 
      // chkIgnoreOther
      // 
      this.chkIgnoreOther.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.chkIgnoreOther.Location = new System.Drawing.Point(72, 88);
      this.chkIgnoreOther.Name = "chkIgnoreOther";
      this.chkIgnoreOther.Size = new System.Drawing.Size(304, 56);
      this.chkIgnoreOther.TabIndex = 25;
      this.chkIgnoreOther.Text = "Delete all folders with no MP3 files ignoring any other possible present files. (" +
    "WARNING: This will delete non MP3 files when no MP3 files are found in a folder)" +
    "";
      // 
      // frmRemoveFolders
      // 
      this.AcceptButton = this.btnOK;
      this.AutoScaleBaseSize = new System.Drawing.Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(480, 288);
      this.ControlBox = false;
      this.Controls.Add(this.chkIgnoreOther);
      this.Controls.Add(this.btnBrowse);
      this.Controls.Add(this.txtPath);
      this.Controls.Add(this.lblPath);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.GroupBox);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.btnOK);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.Name = "frmRemoveFolders";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
      this.Text = "Remove empty folders";
      this.GroupBox.ResumeLayout(false);
      this.ResumeLayout(false);
      this.PerformLayout();
    }

    public frmRemoveFolders(frmMain Main)
    {
      base.Load += new EventHandler(this.frmRemoveFolders_Load);
      this.vbooCancel = false;
      this.InitializeComponent();
      this.MainForm = Main;
    }

    #endregion

    #region Local variables

    private bool vbooCancel;

    #endregion

    #region Events

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

      if (!Directory.Exists(this.txtPath.Text))
        return;

      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);
      alstFolders.Add(this.txtPath.Text);
      this.ScanFolders(alstFolders, "*.MP3", this.txtPath.Text);
    }

    private void frmRemoveFolders_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;
      Id3TagIT_Main.WindowsXPCheck(ref objForm);
      this.txtPath.Text = Declarations.objSettings.CurrentPath;
      this.AddToolTips();
    }

    #endregion

    #region Class logic

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

    #endregion
  }
}