namespace ID3_TagIT
{
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.ComponentModel;
  using System.Runtime.CompilerServices;
  using System.Windows.Forms;

  public class ComboBoxAutoComplete : ComboBox
  {
    private bool m_Autocomplete;
    private bool m_isAutoCompleteSuspended;
    private bool m_ListItemsOnly;
    private string m_strOriginal;

    public event NoMatchFoundEventHandler NoMatchFound;

    public ComboBoxAutoComplete()
    {
      base.Leave += new EventHandler(this.ComboBoxAutoComplete_Leave);
      this.m_isAutoCompleteSuspended = false;
      this.m_Autocomplete = true;
      this.m_ListItemsOnly = false;
    }

    private void ComboBoxAutoComplete_Leave(object sender, EventArgs e)
    {
      if (this.m_ListItemsOnly)
      {
        if (this.FindString(this.Text) < 0)
        {
          this.Text = "";
        }
        else
        {
          this.SelectedIndex = this.FindString(this.Text);
        }
      }
    }

    protected override void OnGotFocus(EventArgs e)
    {
      if (this.m_Autocomplete)
      {
        this.m_strOriginal = this.Text;
      }
      base.OnGotFocus(e);
    }

    protected override void OnKeyDown(KeyEventArgs e)
    {
      if (this.m_Autocomplete)
      {
        switch (e.KeyData)
        {
          case Keys.Back:
            if (this.SelectionStart > 0)
            {
              this.m_isAutoCompleteSuspended = true;
            }
            goto Label_0053;

          case Keys.Escape:
            this.m_isAutoCompleteSuspended = false;
            this.Text = this.m_strOriginal;
            this.SelectAll();
            this.m_isAutoCompleteSuspended = true;
            goto Label_0053;
        }
        this.m_isAutoCompleteSuspended = false;
      }
      Label_0053:
      base.OnKeyDown(e);
    }

    protected override void OnLostFocus(EventArgs e)
    {
      if (this.m_Autocomplete)
      {
        this.m_strOriginal = null;
      }
      base.OnLostFocus(e);
    }

    protected virtual void OnNoMatchFound(CancelEventArgs e)
    {
      if (this.NoMatchFoundEvent != null)
      {
        this.NoMatchFoundEvent(this, e);
      }
    }

    protected override void OnTextChanged(EventArgs e)
    {
      base.OnTextChanged(e);
      if (this.m_Autocomplete && !this.m_isAutoCompleteSuspended)
      {
        int length = this.Text.Length;
        if (length != 0)
        {
          int num = this.FindString(this.Text);
          try
          {
            if (num > -1)
            {
              this.SelectedIndex = num;
              this.SelectionStart = length;
              this.SelectionLength = this.Text.Length;
            }
            else if (this.m_ListItemsOnly && (this.Text.Length > 0))
            {
              this.Text = this.Text.Substring(0, this.Text.Length - 1);
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

    protected override void OnValidating(CancelEventArgs e)
    {
      if (this.m_Autocomplete)
      {
        if (StringType.StrCmp(this.Text, "", false) == 0)
        {
          this.SelectedIndex = -1;
        }
        else
        {
          int num = this.FindStringExact(this.Text);
          if (num == -1)
          {
            this.OnNoMatchFound(e);
          }
          else
          {
            this.SelectedIndex = num;
          }
        }
      }
      base.OnValidating(e);
    }

    [Description("Enable or disable the autocomplete feature"), Category("Behavior")]
    public bool Autocomplete
    {
      get
      {
        return this.m_Autocomplete;
      }
      set
      {
        this.m_Autocomplete = value;
        if (this.m_Autocomplete)
        {
          this.DropDownStyle = ComboBoxStyle.DropDown;
        }
      }
    }

    [Category("Behavior"), Description("Indecates whether other items than list items are allowed"), DefaultValue(false)]
    public bool ListItemsOnly
    {
      get
      {
        return this.m_ListItemsOnly;
      }
      set
      {
        this.m_ListItemsOnly = value;
      }
    }

    public delegate void NoMatchFoundEventHandler(object sender, CancelEventArgs e);
  }
}