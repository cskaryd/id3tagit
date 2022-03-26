using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.ComponentModel;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmProgress : Form
  {
    #region Local variables

    private ArrayList objList;
    private ArrayList objListHelp;
    private ID3_TagIT.MP3 objMP3;
    private bool vboo01;
    private bool vboo02;
    private bool vbooCanceled;
    private bool vbooFinished;
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