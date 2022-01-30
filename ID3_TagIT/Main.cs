using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  [StandardModule]
  internal sealed class Id3TagIT_Main
  {
    public static MemoryStream objDebugStream = new MemoryStream();

    public static bool CheckFilename(string vstrName, [Optional, DefaultParameterValue(false)] bool vbooCompletePath)
    {
      if (vbooCompletePath)
        if (((((((vstrName.IndexOf("<") >= 0) | (vstrName.IndexOf(">") >= 0)) | (vstrName.IndexOf('"') >= 0)) | (vstrName.IndexOf("/") >= 0)) | (vstrName.IndexOf("*") >= 0)) | (vstrName.IndexOf("|") >= 0)) | (vstrName.IndexOf("?") >= 0))
          return false;
        else if ((((((((vstrName.IndexOf(@"\") >= 0) | (vstrName.IndexOf("<") >= 0)) | (vstrName.IndexOf(">") >= 0)) | (vstrName.IndexOf('"') >= 0)) | (vstrName.IndexOf("/") >= 0)) | (vstrName.IndexOf("*") >= 0)) | (vstrName.IndexOf("|") >= 0)) | (vstrName.IndexOf("?") >= 0))
          return false;

      return true;
    }

    public static string CreateTempFile(byte[] abytData, [Optional, DefaultParameterValue("")] string vstrExt)
    {
      string tempFileName = Path.GetTempFileName();
      if (StringType.StrCmp(vstrExt, "", false) != 0)
      {
        string path = tempFileName.Substring(0, tempFileName.LastIndexOf(".") + 1) + vstrExt;
        if (File.Exists(path))
          File.Delete(path);
        File.Move(tempFileName, path);
        tempFileName = path;
        Application.DoEvents();
      }
      FileStream stream = new FileStream(tempFileName, FileMode.Open, FileAccess.ReadWrite);
      stream.Write(abytData, 0, abytData.Length);
      stream.Flush();
      stream.Close();
      Application.DoEvents();
      Declarations.TempFiles.Add(tempFileName);
      return tempFileName;
    }

    public static Icon GetAppIcon(string vstrPath, bool vbooSmallIcon)
    {
      Declarations.SHGFI shgfi;
      Declarations.SHFILEINFO structure = new Declarations.SHFILEINFO(true);
      int cbFileInfo = Marshal.SizeOf(structure);

      if (vbooSmallIcon)
        shgfi = Declarations.SHGFI.ATTRIBUTES | Declarations.SHGFI.ICON | Declarations.SHGFI.ADDOVERLAYS | Declarations.SHGFI.SMALLICON;
      else
        shgfi = Declarations.SHGFI.ATTRIBUTES | Declarations.SHGFI.ICON | Declarations.SHGFI.ADDOVERLAYS;

      Declarations.SHGetFileInfo(ref vstrPath, 0x100, ref structure, cbFileInfo, shgfi);
      Icon icon2 = (Icon)Icon.FromHandle(structure.hIcon).Clone();
      Declarations.DestroyIcon(structure.hIcon);

      return icon2;
    }

    public static int[] GetColumnOrder(ListView ListView)
    {
      int msg = 0x103b;
      int[] numArray = new int[0];
      int[] numArray2 = new int[(ListView.Columns.Count - 1) + 1];

      if (!Declarations.ListViewColumnOrder(ListView.Handle.ToInt32(), msg, numArray2.Length, ref numArray2[0]).Equals(0))
        return numArray2;

      return numArray;
    }

    public static string GetRelativePath(string vstrBaseDir, string vstrFilePath)
    {
      int num;
      string str2 = "";
      int index = 0;
      if (StringType.StrCmp(vstrBaseDir.Substring(0, 2), vstrFilePath.Substring(0, 2), false) != 0)
        return vstrFilePath;
      string[] strArray = vstrBaseDir.Split(new char[] { '\\' });
      string[] strArray2 = vstrFilePath.Split(new char[] { '\\' });
      if (strArray.Length <= strArray2.Length)
      {
        int upperBound = strArray.GetUpperBound(0);
        for (num = 0; num <= upperBound; num++)
        {
          if (StringType.StrCmp(strArray[num], strArray2[num], false) != 0)
            break;
          index = num;
        }
      }
      else
      {
        int num4 = strArray2.GetUpperBound(0);
        for (num = 0; num <= num4; num++)
        {
          if (StringType.StrCmp(strArray[num], strArray2[num], false) != 0)
            break;
          index = num;
        }
      }
      if (index == strArray.GetUpperBound(0))
      {
        index++;
        while (index <= strArray2.GetUpperBound(0))
        {
          str2 = str2 + strArray2[index] + @"\";
          index++;
        }
        return str2.Substring(0, str2.Length - 1);
      }
      int num3 = index + 1;
      while (index < strArray.GetUpperBound(0))
      {
        str2 = str2 + @"..\";
        index++;
      }
      while (num3 <= strArray2.GetUpperBound(0))
      {
        str2 = str2 + strArray2[num3] + @"\";
        num3++;
      }
      return str2.Substring(0, str2.Length - 1);
    }

    [STAThread]
    public static void Main()
    {
      Debug.Listeners.Add(new TextWriterTraceListener(objDebugStream));
      Debug.AutoFlush = true;

      Declarations.Declaration();
      CommandLine line = new CommandLine();

      string sLeft = "";
      string sRight = Application.ProductVersion.ToString().Substring(0, Application.ProductVersion.ToString().LastIndexOf("."));

      try
      {
        if (!Directory.Exists(Declarations.vstrUserAppData))
        {
          Directory.CreateDirectory(Declarations.vstrUserAppData);
          Directory.CreateDirectory(Path.Combine(Declarations.vstrUserAppData, "Libraries"));
          DirectoryInfo info = new DirectoryInfo(Declarations.vstrCommonAppData);
          DirectoryInfo info2 = new DirectoryInfo(Path.Combine(Declarations.vstrCommonAppData, "Libraries"));

          foreach (FileInfo info3 in info.GetFiles())
            info3.CopyTo(Path.Combine(Declarations.vstrUserAppData, info3.Name), true);

          foreach (FileInfo info3 in info2.GetFiles())
            info3.CopyTo(Path.Combine(Path.Combine(Declarations.vstrUserAppData, "Libraries"), info3.Name), true);
        }
        else
        {
          if (!File.Exists(Path.Combine(Declarations.vstrUserAppData, "VersionInfo.txt")))
          {
            Directory.CreateDirectory(Declarations.vstrUserAppData);
            Directory.CreateDirectory(Path.Combine(Declarations.vstrUserAppData, "Libraries"));
            DirectoryInfo info4 = new DirectoryInfo(Declarations.vstrCommonAppData);
            DirectoryInfo info5 = new DirectoryInfo(Path.Combine(Declarations.vstrCommonAppData, "Libraries"));

            foreach (FileInfo info6 in info4.GetFiles())
              info6.CopyTo(Path.Combine(Declarations.vstrUserAppData, info6.Name), true);

            foreach (FileInfo info6 in info5.GetFiles())
              info6.CopyTo(Path.Combine(Path.Combine(Declarations.vstrUserAppData, "Libraries"), info6.Name), true);
          }
          else
          {
            FileStream stream = new FileStream(Path.Combine(Declarations.vstrUserAppData, "VersionInfo.txt"), FileMode.Open);
            StreamReader reader = new StreamReader(stream);

            sLeft = reader.ReadLine();
            stream.Close();
            reader.Close();

            if (StringType.StrCmp(sLeft, sRight, false) < 0)
            {
              Directory.CreateDirectory(Declarations.vstrUserAppData);
              Directory.CreateDirectory(Path.Combine(Declarations.vstrUserAppData, "Libraries"));
              DirectoryInfo info7 = new DirectoryInfo(Declarations.vstrCommonAppData);
              DirectoryInfo info8 = new DirectoryInfo(Path.Combine(Declarations.vstrCommonAppData, "Libraries"));

              if (StringType.StrCmp(sLeft, "3.0.7", false) < 0)
              {
                foreach (FileInfo info9 in info7.GetFiles())
                  info9.CopyTo(Path.Combine(Declarations.vstrUserAppData, info9.Name), true);

                File.Copy(Path.Combine(Declarations.vstrCommonAppData, @"Libraries\Library-Columns.xml"), Path.Combine(Declarations.vstrUserAppData, @"Libraries\Library-Columns.xml"), true);
              }

              if (StringType.StrCmp(sLeft, "3.1.3", false) < 0)
              {
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, @"Libraries\Library-CommDescriptors.xml"), Path.Combine(Declarations.vstrUserAppData, @"Libraries\Library-CommDescriptors.xml"), true);
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "Interface.xml"), Path.Combine(Declarations.vstrUserAppData, "Interface.xml"), true);
              }

              if (StringType.StrCmp(sLeft, "3.1.8", false) < 0)
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "Toolbar.xml"), Path.Combine(Declarations.vstrUserAppData, "Toolbar.xml"), true);

              if (StringType.StrCmp(sLeft, "3.2.1", false) < 0)
              {
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "Toolbar.xml"), Path.Combine(Declarations.vstrUserAppData, "Toolbar.xml"), true);
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "Interface.xml"), Path.Combine(Declarations.vstrUserAppData, "Interface.xml"), true);
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "ExtToolbar.xml"), Path.Combine(Declarations.vstrUserAppData, "ExtToolbar.xml"), true);
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "Navpanel.xml"), Path.Combine(Declarations.vstrUserAppData, "Navpanel.xml"), true);
              }

              if (StringType.StrCmp(sLeft, "3.3.0", false) < 0)
              {
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "Toolbar.xml"), Path.Combine(Declarations.vstrUserAppData, "Toolbar.xml"), true);
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "Interface.xml"), Path.Combine(Declarations.vstrUserAppData, "Interface.xml"), true);
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "ExtToolbar.xml"), Path.Combine(Declarations.vstrUserAppData, "ExtToolbar.xml"), true);
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, "Navpanel.xml"), Path.Combine(Declarations.vstrUserAppData, "Navpanel.xml"), true);
                File.Copy(Path.Combine(Declarations.vstrCommonAppData, @"Libraries\Library-Columns.xml"), Path.Combine(Declarations.vstrUserAppData, @"Libraries\Library-Columns.xml"), true);
              }
            }
          }

          File.Copy(Path.Combine(Declarations.vstrCommonAppData, "VersionInfo.txt"), Path.Combine(Declarations.vstrUserAppData, "VersionInfo.txt"), true);
        }
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        Exception exception = exception1;
        ProjectData.ClearProjectError();
      }

      Declarations.objSettings.ReadSettings();

      if (StringType.StrCmp(sLeft, "", false) != 0)
      {
        DataColumn column;

        try
        {
          Declarations.objSettings.SettingsTable.Columns.Remove("PlaylistPath");
        }
        catch (Exception exception2)
        {
          ProjectData.SetProjectError(exception2);
          ProjectData.ClearProjectError();
        }

        try
        {
          Declarations.objSettings.SettingsTable.Columns.Remove("SearchPlaceholders");
        }
        catch (Exception exception3)
        {
          ProjectData.SetProjectError(exception3);
          ProjectData.ClearProjectError();
        }

        try
        {
          Declarations.objSettings.SettingsTable.Columns.Remove("FilterIndex");
        }
        catch (Exception exception4)
        {
          ProjectData.SetProjectError(exception4);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("FreeDBLastSearch", System.Type.GetType("System.String"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["FreeDBLastSearch"] = "";
        }
        catch (Exception exception5)
        {
          ProjectData.SetProjectError(exception5);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("FreeDBSearchOptions", System.Type.GetType("System.Byte"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["FreeDBSearchOptions"] = 0;
        }
        catch (Exception exception6)
        {
          ProjectData.SetProjectError(exception6);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("RebuildOFilename", System.Type.GetType("System.Boolean"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["RebuildOFilename"] = false;
        }
        catch (Exception exception7)
        {
          ProjectData.SetProjectError(exception7);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("SaveOFilename", System.Type.GetType("System.Boolean"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["SaveOFilename"] = false;
        }
        catch (Exception exception8)
        {
          ProjectData.SetProjectError(exception8);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("SearchRegExpression", System.Type.GetType("System.Boolean"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["SearchRegExpression"] = false;
        }
        catch (Exception exception9)
        {
          ProjectData.SetProjectError(exception9);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("ListExtInfo", System.Type.GetType("System.String"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["ListExtInfo"] = "<A> - <T>";
        }
        catch (Exception exception10)
        {
          ProjectData.SetProjectError(exception10);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("SplitSeparator", System.Type.GetType("System.String"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["SplitSeparator"] = " - ";
        }
        catch (Exception exception11)
        {
          ProjectData.SetProjectError(exception11);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("Language", System.Type.GetType("System.Byte"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["Language"] = 0;
        }
        catch (Exception exception12)
        {
          ProjectData.SetProjectError(exception12);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("OrganizeCopy", System.Type.GetType("System.Boolean"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["OrganizeCopy"] = false;
        }
        catch (Exception exception13)
        {
          ProjectData.SetProjectError(exception13);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("NavPanWidth", System.Type.GetType("System.Int32"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["NavPanWidth"] = 0xec;
        }
        catch (Exception exception14)
        {
          ProjectData.SetProjectError(exception14);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("SideBarWidth", System.Type.GetType("System.Int32"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["SideBarWidth"] = 0xd4;
        }
        catch (Exception exception15)
        {
          ProjectData.SetProjectError(exception15);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("ErrorHeight", System.Type.GetType("System.Int32"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["ErrorHeight"] = 120;
        }
        catch (Exception exception16)
        {
          ProjectData.SetProjectError(exception16);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("NavPanExpanded", System.Type.GetType("System.Boolean"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["NavPanExpanded"] = true;
        }
        catch (Exception exception17)
        {
          ProjectData.SetProjectError(exception17);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("SideBarExpanded", System.Type.GetType("System.Boolean"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["SideBarExpanded"] = true;
        }
        catch (Exception exception18)
        {
          ProjectData.SetProjectError(exception18);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("ErrorExpanded", System.Type.GetType("System.Boolean"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["ErrorExpanded"] = true;
        }
        catch (Exception exception19)
        {
          ProjectData.SetProjectError(exception19);
          ProjectData.ClearProjectError();
        }

        try
        {
          column = new DataColumn("AudioChecksumCalc", System.Type.GetType("System.Boolean"));
          Declarations.objSettings.SettingsTable.Columns.Add(column);
          Declarations.objSettings.SettingsTable.Rows[0]["AudioChecksumCalc"] = true;
        }
        catch (Exception exception20)
        {
          ProjectData.SetProjectError(exception20);
          ProjectData.ClearProjectError();
        }
      }

      Declarations.objResources.ReadResources();
      line.Resolve();

      if ((StringType.StrCmp(line.Path, "", false) != 0) & Directory.Exists(line.Path))
        Declarations.objSettings.CurrentPath = line.Path;

      if (StringType.StrCmp(line.DataFilePath, "", false) == 0)
      {
        frmMain mainForm = new frmMain();
        Application.Run(mainForm);
      }

      Application.Exit();
    }

    // FIXME - Kill with fire
    private static void RecursivelyFormatForWinXP(Control objControl)
    {
      int num2 = objControl.Controls.Count - 1;

      for (int i = 0; i <= num2; i++)
      {
        if (objControl.Controls[i].GetType() == typeof(Button))
          ((ButtonBase)objControl.Controls[i]).FlatStyle = FlatStyle.System;

        if (objControl.Controls.Count > 0)
          RecursivelyFormatForWinXP(objControl.Controls[i]);
      }
    }

    public static void RestoreFormSettings(ref Form Form)
    {
      int num2 = Declarations.objSettings.Forms.Rows.Count - 1;

      for (int i = 0; i <= num2; i++)
      {
        if (ObjectType.ObjTst(Form.Name, Declarations.objSettings.Forms.Rows[i]["Name"], false) == 0)
        {
          DataRow row = Declarations.objSettings.Forms.Rows[i];
          if (ObjectType.ObjTst(row["State"], "Normal", false) == 0)
          {
            Form.Top = IntegerType.FromObject(row["Top"]);
            Form.Left = IntegerType.FromObject(row["Left"]);
            if (Form is frmMain)
            {
              Form.Height = IntegerType.FromObject(row["Height"]);
              Form.Width = IntegerType.FromObject(row["Width"]);
            }
          }
          else if (ObjectType.ObjTst(row["State"], "Maximized", false) == 0)
            Form.WindowState = FormWindowState.Maximized;
          else
            Form.WindowState = FormWindowState.Minimized;

          break;
        }
      }
    }

    public static void SaveFormSettings(ref Form Form)
    {
      int num2 = Declarations.objSettings.Forms.Rows.Count - 1;
      for (int i = 0; i <= num2; i++)
      {
        if (ObjectType.ObjTst(Form.Name, Declarations.objSettings.Forms.Rows[i]["Name"], false) == 0)
        {
          DataRow row2 = Declarations.objSettings.Forms.Rows[i];
          row2["Name"] = Form.Name.ToString();
          row2["State"] = Form.WindowState.ToString();
          row2["Top"] = Form.Top;
          row2["Left"] = Form.Left;
          row2["Height"] = Form.Height;
          row2["Width"] = Form.Width;
          return;
        }
      }
      DataRow row = Declarations.objSettings.Forms.NewRow();
      row["Name"] = Form.Name.ToString();
      row["State"] = Form.WindowState.ToString();
      row["Top"] = Form.Top;
      row["Left"] = Form.Left;
      row["Height"] = Form.Height;
      row["Width"] = Form.Width;
      Declarations.objSettings.Forms.Rows.Add(row);
    }

    public static void ScanForFiles(ArrayList alstFolders, string vstrSearchPattern, bool vbooIncludeSubDir, ref ArrayList alstFile, [Optional, DefaultParameterValue(null)] ref frmProgress frmProg)
    {
      foreach (string str in alstFolders)
      {
        try
        {
          string path = str;
          if (path.EndsWith(":"))
          {
            path = path + @"\";
          }
          DirectoryInfo info = new DirectoryInfo(path);
          DirectoryInfo[] directories = info.GetDirectories();
          if (vbooIncludeSubDir)
          {
            foreach (DirectoryInfo info2 in directories)
            {
              Application.DoEvents();
              if (frmProg.Canceled)
              {
                return;
              }
              ArrayList list = new ArrayList {
                                    info2.FullName
                                };
              ScanForFiles(list, vstrSearchPattern, vbooIncludeSubDir, ref alstFile, ref frmProg);
            }
          }
          if (frmProg != null)
          {
            frmProg.Infos.Text = info.FullName;
          }
          Application.DoEvents();
          foreach (FileInfo info3 in info.GetFiles(vstrSearchPattern))
          {
            alstFile.Add(info3.FullName);
          }
          continue;
        }
        catch (Exception exception1)
        {
          ProjectData.SetProjectError(exception1);
          ProjectData.ClearProjectError();
          continue;
        }
      }
    }

    public static void SetColumnOrder(ListView ListView, int[] SortOrder)
    {
      if ((SortOrder.Length >= 1) && (SortOrder.Length <= ListView.Columns.Count))
      {
        int msg = 0x103a;

        if (!Declarations.ListViewColumnOrder(ListView.Handle.ToInt32(), msg, SortOrder.Length, ref SortOrder[0]).Equals(0))
          ListView.Refresh();
      }
    }

    public static bool ShellFileOp(string vstrFilenames, string vstrDestFolder, Declarations.ShellOperation Operation, Declarations.ShellOperationFlags Flags, Form objForm)
    {
      Declarations.SHFILEOPSTRUCT lpFileOp = new Declarations.SHFILEOPSTRUCT();
      vstrFilenames = vstrFilenames.TrimEnd(new char[] { '\0' });
      vstrDestFolder = vstrDestFolder.TrimEnd(new char[] { '\0' });
      lpFileOp.hWnd = objForm.Handle.ToInt32();
      lpFileOp.wFunc = (int)Operation;
      lpFileOp.pFrom = vstrFilenames + "\0\0";
      lpFileOp.pTo = vstrDestFolder + "\0\0";
      lpFileOp.fFlags = (short)Flags;
      Application.DoEvents();
      return (Declarations.SHFileOperation(ref lpFileOp) == 0);
    }

    // FIXME - Kill with fire
    public static void WindowsXPCheck(ref Form FormToCheck)
    {
      if (((Environment.OSVersion.Version.Major > 4) & (Environment.OSVersion.Version.Minor > 0)) & File.Exists(Application.ExecutablePath + ".manifest"))
      {
        int num2 = FormToCheck.Controls.Count - 1;
        for (int i = 0; i <= num2; i++)
        {
          if (FormToCheck.Controls[i].GetType() == typeof(Button))
            ((ButtonBase)FormToCheck.Controls[i]).FlatStyle = FlatStyle.System;

          RecursivelyFormatForWinXP(FormToCheck.Controls[i]);
        }
      }
    }
  }
}