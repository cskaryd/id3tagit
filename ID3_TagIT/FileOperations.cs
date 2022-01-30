namespace ID3_TagIT
{
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.IO;

  public class FileOperations
  {
    private BinaryReader objBinaryReader;
    private BinaryWriter objBinaryWriter;
    private FileInfo objFileInfo;
    private FileStream objFileStream;
    private string vstrCurrentFullName = "";
    private string vstrCurrentName = "";

    public FileOperations(string vstrFullFilename)
    {
      this.objFileInfo = new FileInfo(vstrFullFilename);
      this.vstrCurrentName = this.objFileInfo.Name.Remove(this.objFileInfo.Name.LastIndexOf("."), this.objFileInfo.Extension.Length);
      this.vstrCurrentFullName = this.objFileInfo.FullName;
    }

    public void CloseBinaryReader()
    {
      this.objBinaryReader.Close();
    }

    public void CloseBinaryWriter()
    {
      this.objBinaryWriter.Close();
    }

    public void CloseFileStream()
    {
      this.objFileStream.Close();
    }

    public bool OpenBinaryReader()
    {
      bool flag;
      try
      {
        this.objBinaryReader = new BinaryReader(this.objFileStream);
        flag = true;
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public bool OpenBinaryWriter()
    {
      bool flag;
      try
      {
        this.objBinaryWriter = new BinaryWriter(this.objFileStream);
        flag = true;
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public bool OpenFileStreamR()
    {
      bool flag;
      try
      {
        this.objFileStream = this.objFileInfo.Open(FileMode.Open, FileAccess.Read, FileShare.Read);
        flag = true;
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public bool OpenFileStreamRW()
    {
      bool flag;
      try
      {
        this.objFileStream = this.objFileInfo.Open(FileMode.Open, FileAccess.ReadWrite, FileShare.None);
        flag = true;
      }
      catch (Exception exception1)
      {
        ProjectData.SetProjectError(exception1);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
    }

    public byte[] ReadData(int vintStartPos, SeekOrigin Origin, int vintNumberOfBytes)
    {
      this.objBinaryReader.BaseStream.Seek((long)vintStartPos, Origin);
      return this.objBinaryReader.ReadBytes(vintNumberOfBytes);
    }

    public bool TrimFile(int vintRelBegin, int vintRelEnd)
    {
      bool flag;
      try
      {
        if (vintRelBegin == 0)
        {
          if (!this.OpenFileStreamRW())
          {
            return false;
          }
          this.objFileStream.SetLength(this.FI.Length - vintRelEnd);
          this.CloseFileStream();
          goto Label_01C9;
        }
        if (this.OpenFileStreamR())
        {
          BinaryWriter writer;
          FileStream stream;
          this.OpenBinaryReader();
          try
          {
            byte[] buffer;
            string path = this.FI.FullName + ".ID3temp";
            stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
            writer = new BinaryWriter(stream);
            writer.BaseStream.Seek(0L, SeekOrigin.Begin);
            int vintNumberOfBytes = (((int)this.FI.Length) - vintRelBegin) - vintRelEnd;
            if (vintNumberOfBytes > 0x800000)
            {
              int num2 = vintNumberOfBytes / 0x800000;
              int num5 = num2 - 1;
              for (int i = 0; i <= num5; i++)
              {
                buffer = this.ReadData(vintRelBegin + (i * 0x800000), SeekOrigin.Begin, 0x800000);
                writer.Write(buffer);
                writer.Flush();
              }
              buffer = this.ReadData(vintRelBegin + (num2 * 0x800000), SeekOrigin.Begin, (((int)this.FI.Length) - (vintRelBegin + (num2 * 0x800000))) - vintRelEnd);
              writer.Write(buffer);
              writer.Flush();
            }
            else
            {
              buffer = this.ReadData(vintRelBegin, SeekOrigin.Begin, vintNumberOfBytes);
              writer.Write(buffer);
              writer.Flush();
            }
            writer.Close();
            stream.Close();
            this.CloseBinaryReader();
            this.CloseFileStream();
            File.Delete(this.FI.FullName);
            File.Move(path, this.FI.FullName);
            File.Delete(path);
            this.FI.Refresh();
            goto Label_01C9;
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            writer.Close();
            stream.Close();
            this.CloseBinaryReader();
            this.CloseFileStream();
            flag = false;
            ProjectData.ClearProjectError();
            return flag;
          }
        }
        flag = false;
      }
      catch (Exception exception2)
      {
        ProjectData.SetProjectError(exception2);
        flag = false;
        ProjectData.ClearProjectError();
      }
      return flag;
      Label_01C9:
      return true;
    }

    public void WriteData(int vintStartPos, SeekOrigin Origin, byte[] abytBuffer)
    {
      this.objBinaryWriter.BaseStream.Seek((long)vintStartPos, Origin);
      this.objBinaryWriter.Write(abytBuffer);
      this.objBinaryWriter.Flush();
    }

    public BinaryReader BinReader
    {
      get
      {
        return this.objBinaryReader;
      }
    }

    public string CurrentFullName
    {
      get
      {
        return this.vstrCurrentFullName;
      }
      set
      {
        this.vstrCurrentFullName = value;
        this.vstrCurrentName = this.vstrCurrentFullName.Substring(this.vstrCurrentFullName.LastIndexOf(@"\") + 1);
        this.vstrCurrentName = this.vstrCurrentName.Remove(this.vstrCurrentName.LastIndexOf("."), this.objFileInfo.Extension.Length);
      }
    }

    public string CurrentName
    {
      get
      {
        return this.vstrCurrentName;
      }
      set
      {
        this.vstrCurrentName = value;
        this.vstrCurrentFullName = this.vstrCurrentFullName.Substring(0, this.vstrCurrentFullName.LastIndexOf(@"\") + 1);
        this.vstrCurrentFullName = this.vstrCurrentFullName + this.vstrCurrentName + this.objFileInfo.Extension;
      }
    }

    public FileInfo FI
    {
      get
      {
        return this.objFileInfo;
      }
      set
      {
        this.objFileInfo = value;
      }
    }

    public FileStream FStream
    {
      get
      {
        return this.objFileStream;
      }
    }
  }
}