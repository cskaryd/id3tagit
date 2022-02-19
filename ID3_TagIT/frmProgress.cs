﻿using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmProgress : Form
  {
    #region Designer

    public Button btnCancel;
    public Label lblInfo;
    public System.Windows.Forms.ProgressBar ProgressBar;
    public Label State;
    private System.Windows.Forms.Timer Timer;
    private IContainer components;

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
      this.ProgressBar = new System.Windows.Forms.ProgressBar();
      this.btnCancel = new System.Windows.Forms.Button();
      this.State = new System.Windows.Forms.Label();
      this.lblInfo = new System.Windows.Forms.Label();
      this.Timer = new System.Windows.Forms.Timer(this.components);
      this.SuspendLayout();
      // 
      // ProgressBar
      // 
      this.ProgressBar.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.ProgressBar.Location = new System.Drawing.Point(16, 40);
      this.ProgressBar.Name = "ProgressBar";
      this.ProgressBar.Size = new System.Drawing.Size(376, 16);
      this.ProgressBar.TabIndex = 0;
      // 
      // btnCancel
      // 
      this.btnCancel.BackColor = System.Drawing.SystemColors.Control;
      this.btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this.btnCancel.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
      this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
      this.btnCancel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.btnCancel.Location = new System.Drawing.Point(138, 132);
      this.btnCancel.Name = "btnCancel";
      this.btnCancel.Size = new System.Drawing.Size(128, 24);
      this.btnCancel.TabIndex = 1;
      this.btnCancel.Text = "&Cancel";
      this.btnCancel.UseVisualStyleBackColor = false;
      this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
      // 
      // State
      // 
      this.State.BackColor = System.Drawing.SystemColors.Control;
      this.State.ForeColor = System.Drawing.Color.Black;
      this.State.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.State.Location = new System.Drawing.Point(12, 9);
      this.State.Name = "State";
      this.State.Size = new System.Drawing.Size(384, 16);
      this.State.TabIndex = 2;
      // 
      // lblInfo
      // 
      this.lblInfo.ImeMode = System.Windows.Forms.ImeMode.NoControl;
      this.lblInfo.Location = new System.Drawing.Point(16, 64);
      this.lblInfo.Name = "lblInfo";
      this.lblInfo.Size = new System.Drawing.Size(376, 56);
      this.lblInfo.TabIndex = 3;
      this.lblInfo.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
      // 
      // Timer
      // 
      this.Timer.Enabled = true;
      this.Timer.Interval = 10;
      this.Timer.Tick += new System.EventHandler(this.Timer_Tick);
      // 
      // frmProgress
      // 
      this.AllowDrop = true;
      this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
      this.CancelButton = this.btnCancel;
      this.ClientSize = new System.Drawing.Size(408, 168);
      this.ControlBox = false;
      this.Controls.Add(this.State);
      this.Controls.Add(this.btnCancel);
      this.Controls.Add(this.lblInfo);
      this.Controls.Add(this.ProgressBar);
      this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmProgress";
      this.ShowInTaskbar = false;
      this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
      this.Text = "ID3-TagIT - Progress window";
      this.ResumeLayout(false);

    }

    public frmProgress(int vintMinimum, int vintMaximum, int vintStep, ref Form OwnerForm, ref Callback CB)
    {
      base.Load += new EventHandler(this.frmProgress_Load);
      base.Closing += new CancelEventHandler(this.frmProgress_Closing);
      this.vbooCanceled = false;
      this.vbooFinished = false;
      this.vbooScanForFiles = false;
      this.vstr01 = "";
      this.vstr02 = "";
      this.vstr03 = "";
      this.vint01 = 0;
      this.vint02 = 0;
      this.vint03 = 0;
      this.vboo01 = false;
      this.vboo02 = false;
      this.objMP3 = null;
      this.objList = null;
      this.objListHelp = null;
      this.InitializeComponent();
      this.ProgressBar.Minimum = vintMinimum;
      this.ProgressBar.Maximum = vintMaximum;
      this.ProgressBar.Step = vintStep;
      this.ProgressBar.Value = vintMinimum;
      this.Owner = OwnerForm;
      this.CBack = CB;
    }

    #endregion

    #region Local variables

    private ArrayList objList;
    private ArrayList objListHelp;
    private ID3_TagIT.MP3 objMP3;
    private bool vboo01;
    private bool vboo02;
    private bool vbooCanceled;
    private bool vbooFinished;
    private bool vbooScanForFiles;
    private int vint01;
    private int vint02;
    private int vint03;
    private string vstr01;
    private string vstr02;
    private string vstr03;
    private Callback CBack;

    public delegate void Callback(ref frmProgress frmProg);

    #endregion

    #region Events

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.vbooCanceled = true;
    }

    private void frmProgress_Closing(object sender, CancelEventArgs e)
    {
      e.Cancel = !this.vbooFinished;
      Application.DoEvents();
    }

    private void frmProgress_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      this.Text = StringType.FromObject(Declarations.objResources.ResStrings["Name"]);
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      if (!this.Visible)
        return;

      this.Timer.Enabled = false;
      frmProgress frmProg = this;
      this.CBack(ref frmProg);
      this.vbooFinished = true;
      this.Close();
    }

    #endregion

    #region Class logic

    public void SetStateCaseConv()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["CaseConv"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateCompareFileTAG()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["CompareFileTAG"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateCopy()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Copy"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateCreateLib()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["CreateLib"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateDelete()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Delete"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateFilenameTAG()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["FilenameTAG"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateFill()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Fill"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateFolderRename()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["FolderRename"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateGetArtists()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["GetArtists"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateMove()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Move"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateMultiple()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Multiple"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateOrganize()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Organize"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStatePaste()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Paste"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateRead()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Read"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateRedo()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Redo"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateRemoveTAG()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["RemoveTAG"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateSave()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Save"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateSaveLib()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["SaveLib"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateScan()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Scan"]);
      this.State.Refresh();
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateSplit()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Split"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateSwap()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Swap"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateTAGFilename()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["TAGFilename"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateTransfer()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Transfer"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateUndo()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Undo"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public void SetStateWrite()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Write"]);
      this.lblInfo.Text = "";
      Application.DoEvents();
    }

    public bool Boolean01
    {
      get
      {
        return this.vboo01;
      }
      set
      {
        this.vboo01 = value;
      }
    }

    public bool Boolean02
    {
      get
      {
        return this.vboo02;
      }
      set
      {
        this.vboo02 = value;
      }
    }

    public bool Canceled
    {
      get
      {
        return this.vbooCanceled;
      }
    }

    public int Integer01
    {
      get
      {
        return this.vint01;
      }
      set
      {
        this.vint01 = value;
      }
    }

    public int Integer02
    {
      get
      {
        return this.vint02;
      }
      set
      {
        this.vint02 = value;
      }
    }

    public int Integer03
    {
      get
      {
        return this.vint03;
      }
      set
      {
        this.vint03 = value;
      }
    }

    public ArrayList List
    {
      get
      {
        return this.objList;
      }
      set
      {
        this.objList = value;
      }
    }

    public ArrayList ListHelp
    {
      get
      {
        return this.objListHelp;
      }
      set
      {
        this.objListHelp = value;
      }
    }

    public ID3_TagIT.MP3 MP3
    {
      get
      {
        return this.objMP3;
      }
      set
      {
        this.objMP3 = value;
      }
    }

    public string String01
    {
      get
      {
        return this.vstr01;
      }
      set
      {
        this.vstr01 = value;
      }
    }

    public string String02
    {
      get
      {
        return this.vstr02;
      }
      set
      {
        this.vstr02 = value;
      }
    }

    public string String03
    {
      get
      {
        return this.vstr03;
      }
      set
      {
        this.vstr03 = value;
      }
    }

    #endregion
  }
}