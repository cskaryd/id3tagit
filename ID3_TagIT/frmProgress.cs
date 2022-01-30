using DevComponents.DotNetBar;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class frmProgress : Form
  {
    [AccessedThroughProperty("btnCancel")]
    private Button _btnCancel;
    [AccessedThroughProperty("ButtomPanel")]
    private PanelEx _ButtomPanel;
    [AccessedThroughProperty("Infos")]
    private Label _Infos;
    [AccessedThroughProperty("ProgressBar")]
    private System.Windows.Forms.ProgressBar _ProgressBar;
    [AccessedThroughProperty("State")]
    private Label _State;
    [AccessedThroughProperty("Timer")]
    private System.Windows.Forms.Timer _Timer;
    [AccessedThroughProperty("TopPanel")]
    private PanelEx _TopPanel;
    private Callback CBack;
    private IContainer components;
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
      this._ProgressBar.Minimum = vintMinimum;
      this._ProgressBar.Maximum = vintMaximum;
      this._ProgressBar.Step = vintStep;
      this._ProgressBar.Value = vintMinimum;
      this.Owner = OwnerForm;
      this.CBack = CB;
    }

    private void btnCancel_Click(object sender, EventArgs e)
    {
      this.vbooCanceled = true;
    }

    protected override void Dispose(bool disposing)
    {
      if (disposing && (this.components != null))
        this.components.Dispose();

      base.Dispose(disposing);
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
      Main.WindowsXPCheck(ref objForm);
      this.Text = StringType.FromObject(Declarations.objResources.ResStrings["Name"]);
    }

    [DebuggerStepThrough]
    private void InitializeComponent()
    {
      this.components = new Container();
      this._ProgressBar = new System.Windows.Forms.ProgressBar();
      this._btnCancel = new Button();
      this._State = new Label();
      this._Infos = new Label();
      this._Timer = new System.Windows.Forms.Timer(this.components);
      this._ButtomPanel = new PanelEx();
      this._TopPanel = new PanelEx();
      this._ButtomPanel.SuspendLayout();
      this._TopPanel.SuspendLayout();
      this.SuspendLayout();

      this._ProgressBar.ImeMode = ImeMode.NoControl;
      this._ProgressBar.Location = new Point(0x10, 40);
      this._ProgressBar.Name = "_ProgressBar";
      this._ProgressBar.Size = new Size(0x178, 0x10);
      this._ProgressBar.TabIndex = 0;

      this._btnCancel.BackColor = SystemColors.Control;
      this._btnCancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
      this._btnCancel.FlatStyle = FlatStyle.Popup;
      this._btnCancel.ImageAlign = ContentAlignment.MiddleLeft;
      this._btnCancel.ImeMode = ImeMode.NoControl;
      this._btnCancel.Location = new Point(0x88, 8);
      this._btnCancel.Name = "_btnCancel";
      this._btnCancel.Size = new Size(0x80, 0x18);
      this._btnCancel.TabIndex = 1;
      this._btnCancel.Text = "&Cancel";

      this._State.BackColor = Color.White;
      this._State.ForeColor = Color.Black;
      this._State.ImeMode = ImeMode.NoControl;
      this._State.Location = new Point(8, 8);
      this._State.Name = "_State";
      this._State.Size = new Size(0x180, 0x10);
      this._State.TabIndex = 2;

      this._Infos.ImeMode = ImeMode.NoControl;
      this._Infos.Location = new Point(0x10, 0x40);
      this._Infos.Name = "_Infos";
      this._Infos.Size = new Size(0x178, 0x38);
      this._Infos.TabIndex = 3;
      this._Infos.TextAlign = ContentAlignment.MiddleCenter;

      this._Timer.Enabled = true;
      this._Timer.Interval = 10;

      this._ButtomPanel.Controls.Add(this.btnCancel);
      this._ButtomPanel.Dock = DockStyle.Bottom;
      this._ButtomPanel.Location = new Point(0, 0x80);
      this._ButtomPanel.Name = "_ButtomPanel";
      this._ButtomPanel.Size = new Size(0x198, 40);
      this._ButtomPanel.Style.BackColor1.Color = Color.White;
      this._ButtomPanel.Style.BackColor2.Color = Color.White;
      this._ButtomPanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
      this._ButtomPanel.Style.BorderWidth = 0;
      this._ButtomPanel.Style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this._ButtomPanel.Style.ForeColor.Color = Color.Black;
      this._ButtomPanel.Style.GradientAngle = 90;
      this._ButtomPanel.Style.LineAlignment = StringAlignment.Near;
      this._ButtomPanel.Style.MarginBottom = 2;
      this._ButtomPanel.Style.MarginLeft = 7;
      this._ButtomPanel.Style.MarginRight = 2;
      this._ButtomPanel.Style.MarginTop = 2;
      this._ButtomPanel.TabIndex = 0x76;

      this._TopPanel.Controls.Add(this.State);
      this._TopPanel.Dock = DockStyle.Top;
      this._TopPanel.Location = new Point(0, 0);
      this._TopPanel.Name = "_TopPanel";
      this._TopPanel.Size = new Size(0x198, 0x20);
      this._TopPanel.Style.BackColor1.Color = Color.White;
      this._TopPanel.Style.BackColor2.Color = Color.White;
      this._TopPanel.Style.BorderColor.ColorSchemePart = eColorSchemePart.PanelBorder;
      this._TopPanel.Style.BorderWidth = 0;
      this._TopPanel.Style.Font = new Font("Microsoft Sans Serif", 9.75f, FontStyle.Bold, GraphicsUnit.Point, 0);
      this._TopPanel.Style.ForeColor.Color = Color.Black;
      this._TopPanel.Style.GradientAngle = 90;
      this._TopPanel.Style.LineAlignment = StringAlignment.Near;
      this._TopPanel.Style.MarginBottom = 2;
      this._TopPanel.Style.MarginLeft = 7;
      this._TopPanel.Style.MarginRight = 2;
      this._TopPanel.Style.MarginTop = 2;
      this._TopPanel.TabIndex = 0x77;

      this.AllowDrop = true;
      this.AutoScaleMode = AutoScaleMode.None;
      this.AutoScaleBaseSize = new Size(5, 13);
      this.CancelButton = this.btnCancel;
      this.ClientSize = new Size(0x198, 0xa8);
      this.ControlBox = false;
      this.Controls.Add(this._Infos);
      this.Controls.Add(this._ProgressBar);
      this.Controls.Add(this._ButtomPanel);
      this.Controls.Add(this._TopPanel);
      this.FormBorderStyle = FormBorderStyle.FixedDialog;
      this.MaximizeBox = false;
      this.MinimizeBox = false;
      this.Name = "frmProgress";
      this.ShowInTaskbar = false;
      this.StartPosition = FormStartPosition.CenterScreen;
      this.Text = "ID3-TagIT - Progress window";
      this.ButtomPanel.ResumeLayout(false);
      this.TopPanel.ResumeLayout(false);
      this.ResumeLayout(false);
    }

    public void SetStateCaseConv()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["CaseConv"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateCompareFileTAG()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["CompareFileTAG"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateCopy()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Copy"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateCreateLib()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["CreateLib"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateDelete()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Delete"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateFilenameTAG()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["FilenameTAG"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateFill()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Fill"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateFolderRename()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["FolderRename"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateGetArtists()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["GetArtists"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateMove()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Move"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateMultiple()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Multiple"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateOrganize()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Organize"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStatePaste()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Paste"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateRead()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Read"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateRedo()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Redo"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateRemoveTAG()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["RemoveTAG"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateSave()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Save"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateSaveLib()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["SaveLib"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateScan()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Scan"]);
      this.State.Refresh();
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateSplit()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Split"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateSwap()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Swap"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateTAGFilename()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["TAGFilename"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateTransfer()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Transfer"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateUndo()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Undo"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    public void SetStateWrite()
    {
      this.State.Text = StringType.FromObject(Declarations.objResources.ResStrings["Write"]);
      this.Infos.Text = "";
      Application.DoEvents();
    }

    private void Timer_Tick(object sender, EventArgs e)
    {
      if (this.Visible)
      {
        this.Timer.Enabled = false;
        frmProgress frmProg = this;
        this.CBack(ref frmProg);
        this.vbooFinished = true;
        this.Close();
      }
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
          this._btnCancel.Click -= new EventHandler(this.btnCancel_Click);
        }
        this._btnCancel = value;
        if (this._btnCancel != null)
        {
          this._btnCancel.Click += new EventHandler(this.btnCancel_Click);
        }
      }
    }

    public PanelEx ButtomPanel
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

    public bool Canceled
    {
      get
      {
        return this.vbooCanceled;
      }
    }

    public Label Infos
    {
      get
      {
        return this._Infos;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Infos != null)
        {
        }
        this._Infos = value;
        if (this._Infos != null)
        {
        }
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

    public Label State
    {
      get
      {
        return this._State;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        this._State = value;
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

    private System.Windows.Forms.Timer Timer
    {
      get
      {
        return this._Timer;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._Timer != null)
        {
          this._Timer.Tick -= new EventHandler(this.Timer_Tick);
        }
        this._Timer = value;
        if (this._Timer != null)
        {
          this._Timer.Tick += new EventHandler(this.Timer_Tick);
        }
      }
    }

    public PanelEx TopPanel
    {
      get
      {
        return this._TopPanel;
      }
      [MethodImpl(MethodImplOptions.Synchronized)]
      set
      {
        if (this._TopPanel != null)
        {
        }
        this._TopPanel = value;
        if (this._TopPanel != null)
        {
        }
      }
    }

    public delegate void Callback(ref frmProgress frmProg);
  }
}