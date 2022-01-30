namespace ID3_TagIT
{
  using DevComponents.DotNetBar;
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.Data;
  using System.Reflection;
  using System.Windows.Forms;

  public class Resources
  {
    private DataSet ID3TagITMenus;
    private DataSet ID3TagITRes;
    private DataSet ID3TagITToolTips;
    private DataRow ResStringsRow;
    private DataRow SelectionBarRow;

    public string GetMenuText(string vstrName)
    {
      string str;
      try
      {
        str = StringType.FromObject(this.ID3TagITMenus.Tables[0].Rows[0][vstrName]);
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        str = "";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public string GetMenuToolTip(string vstrName)
    {
      string str;
      try
      {
        str = StringType.FromObject(this.ID3TagITMenus.Tables[0].Rows[1][vstrName]);
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        str = "";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public string GetToolTip(ref string vstrName, ref Control objControl)
    {
      string str;
      try
      {
        str = StringType.FromObject(this.ID3TagITToolTips.Tables[vstrName].Rows[0][objControl.Name]);
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        str = "";
        ProjectData.ClearProjectError();
      }
      return str;
    }

    public void ReadResources()
    {
      string str = string.Empty;
      string str2 = string.Empty;
      string str3 = string.Empty;
      this.ID3TagITRes = new DataSet("ID3TagITResources");
      this.ID3TagITToolTips = new DataSet("ID3TagITToolTips");
      this.ID3TagITMenus = new DataSet("ID3TagITMenus");
      switch (Declarations.objSettings.Language)
      {
        case 0:
          str2 = "ID3_TagIT.Resources.xml";
          str3 = "ID3_TagIT.Tooltips.xml";
          str = "ID3_TagIT.MenuResources.xml";
          break;

        case 1:
          str2 = "ID3_TagIT.Resources-Ger.xml";
          str3 = "ID3_TagIT.Tooltips-Ger.xml";
          str = "ID3_TagIT.MenuResources-Ger.xml";
          break;

        case 2:
          str2 = "ID3_TagIT.Resources-Pol.xml";
          str3 = "ID3_TagIT.Tooltips-Pol.xml";
          str = "ID3_TagIT.MenuResources-Pol.xml";
          break;
      }
      Assembly entryAssembly = Assembly.GetEntryAssembly();
      this.ID3TagITRes.ReadXml(entryAssembly.GetManifestResourceStream(str2));
      this.ID3TagITToolTips.ReadXml(entryAssembly.GetManifestResourceStream(str3));
      this.ID3TagITMenus.ReadXml(entryAssembly.GetManifestResourceStream(str));
      this.ResStringsRow = this.ID3TagITRes.Tables[0].Rows[0];
      this.SelectionBarRow = this.ID3TagITRes.Tables[1].Rows[0];
    }

    public void ResourcesToForm(ref Form objForm)
    {
      DataRow tempRow = this.ID3TagITRes.Tables[objForm.Name].Rows[0];
      try
      {
        objForm.Text = StringType.FromObject(tempRow["FormName"]);
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        ProjectData.ClearProjectError();
      }
      int num2 = objForm.Controls.Count - 1;
      for (int i = 0; i <= num2; i++)
      {
        this.ResourcesToFormRecusiv(objForm.Controls[i], ref tempRow);
      }
    }

    private void ResourcesToFormRecusiv(Control objControl, ref DataRow TempRow)
    {
      try
      {
        if (objControl.GetType() == typeof(DevComponents.DotNetBar.TabControl))
        {
          DevComponents.DotNetBar.TabControl control = (DevComponents.DotNetBar.TabControl)objControl;
          foreach (TabItem item in control.Tabs)
          {
            try
            {
              item.Text = StringType.FromObject(TempRow[item.Name]);
            }
            catch (Exception exception1)
            {
              ProjectData.SetProjectError(exception1);
              ProjectData.ClearProjectError();
            }
          }
        }
        else
        {
          objControl.Text = StringType.FromObject(TempRow[objControl.Name]);
        }
      }
      catch (Exception exception2)
      {
        ProjectData.SetProjectError(exception2);
        Exception exception = exception2;
        ProjectData.ClearProjectError();
      }
      int num2 = objControl.Controls.Count - 1;
      for (int i = 0; i <= num2; i++)
      {
        if (objControl.Controls.Count > 0)
        {
          this.ResourcesToFormRecusiv(objControl.Controls[i], ref TempRow);
        }
      }
    }

    public DataTable MenuTable
    {
      get
      {
        return this.ID3TagITMenus.Tables[0];
      }
    }

    public DataRow ResStrings
    {
      get
      {
        return this.ResStringsRow;
      }
    }

    public DataRow SelectionBar
    {
      get
      {
        return this.SelectionBarRow;
      }
    }
  }
}