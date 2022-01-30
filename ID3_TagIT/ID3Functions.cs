namespace ID3_TagIT
{
  using ICSharpCode.SharpZipLib.Zip.Compression.Streams;
  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.Collections;
  using System.IO;
  using System.Runtime.CompilerServices;
  using System.Runtime.InteropServices;

  [StandardModule]
  internal sealed class ID3Functions
  {
    public static V2TextFrame CreateTextFrame(string vstrFrameID, string vstrContent)
    {
      return new V2TextFrame
      {
        FID = vstrFrameID,
        Content = vstrContent.Trim(new char[] { ' ' })
      };
    }

    public static V2WebFrame CreateWebFrame(string vstrFrameID, string vstrContent)
    {
      return new V2WebFrame
      {
        FID = vstrFrameID,
        Content = vstrContent.Trim(new char[] { ' ' })
      };
    }

    public static byte[] DoUnsync(byte[] abytBuffer)
    {
      ArrayList list = new ArrayList();
      int num2 = abytBuffer.GetUpperBound(0) - 1;
      for (int i = 0; i <= num2; i++)
      {
        if (((((abytBuffer[i] == 0xff) && (abytBuffer[i + 1] >= 240)) ? 1 : 0) | (((abytBuffer[i] == 0xff) && (abytBuffer[i + 1] == 0)) ? 1 : 0)) != 0)
        {
          list.Add(Convert.ToByte(abytBuffer[i]));
          list.Add(Convert.ToByte(0));
        }
        else
        {
          list.Add(Convert.ToByte(abytBuffer[i]));
        }
      }
      list.Add(Convert.ToByte(abytBuffer[abytBuffer.GetUpperBound(0)]));
      abytBuffer = new byte[(list.Count - 1) + 1];
      list.ToArray(typeof(byte)).CopyTo(abytBuffer, 0);
      return abytBuffer;
    }

    public static void FilenameToTAG(ref MP3 MP3, ArrayList alstFormat, byte vbytTAGVersion)
    {
      int num5;
      ArrayList list2 = new ArrayList();
      ArrayList list = new ArrayList();
      string[] strArray2 = MP3.CurrentFullName.Remove(MP3.CurrentFullName.LastIndexOf("."), MP3.FI.Extension.Length).Split(new char[] { '\\' });
      if (alstFormat.Count >= strArray2.Length)
      {
        num5 = strArray2.Length - 1;
      }
      else
      {
        num5 = alstFormat.Count - 1;
      }
      int num9 = num5;
      for (int i = 0; i <= num9; i++)
      {
        object objectValue;
        object obj3;
        string str;
        object[] objArray;
        object[] objArray2;
        bool[] flagArray;
        object[] objArray3;
        object[] objArray4;
        string str4;
        string[] strArray3;
        object obj4;
        object[] objArray6;
        list2.Clear();
        string[] strArray = (string[])LateBinding.LateGet(alstFormat[i], null, "Delimiters", new object[0], null, null);
        list = (ArrayList)LateBinding.LateGet(alstFormat[i], null, "Parameters", new object[0], null, null);
        string str2 = strArray2[strArray2.GetUpperBound(0) - i];
        int upperBound = strArray.GetUpperBound(0);
        for (int j = 0; j <= upperBound; j++)
        {
          if ((j == strArray.GetUpperBound(0)) | (StringType.StrCmp(strArray[j], "", false) != 0))
          {
            if (str2.IndexOf(strArray[j]) < 0)
            {
              list2.Add(str2);
              break;
            }
            list2.Add(RuntimeHelpers.GetObjectValue(Interaction.IIf(StringType.StrCmp(strArray[j], "", false) == 0, str2, str2.Substring(0, str2.IndexOf(strArray[j])))));
            str2 = str2.Substring(str2.IndexOf(strArray[j]) + strArray[j].Length);
          }
        }
        int num3 = -1;
        int num4 = 1;
        if (vbytTAGVersion != 2)
        {
          goto Label_19D2;
        }
        using (IEnumerator enumerator2 = list.GetEnumerator())
        {
          while (enumerator2.MoveNext())
          {
            str = StringType.FromObject(enumerator2.Current);
            num3++;
            if (num3 == list2.Count)
            {
              goto Label_1999;
            }
            if (ObjectType.ObjTst(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null), "", false) != 0)
            {
              string sLeft = str;
              if ((StringType.StrCmp(sLeft, "<A>", false) == 0) || (StringType.StrCmp(sLeft, "<a>", false) == 0))
              {
                MP3.V2TAG.AddFrame(CreateTextFrame("TPE1", StringType.FromObject(list2[num3])));
                if (Declarations.objSettings.SynchronizeTAGs)
                {
                  if (StringType.StrCmp(MP3.V1TAG.Artist, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 30), false) != 0)
                  {
                    MP3.Changed = true;
                    MP3.V1TAG.TAGPresent = true;
                  }
                  MP3.V1TAG.Artist = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                }
              }
              else
              {
                if ((StringType.StrCmp(sLeft, "<T>", false) == 0) || (StringType.StrCmp(sLeft, "<t>", false) == 0))
                {
                  MP3.V2TAG.AddFrame(CreateTextFrame("TIT2", StringType.FromObject(list2[num3])));
                  if (Declarations.objSettings.SynchronizeTAGs)
                  {
                    if (StringType.StrCmp(MP3.V1TAG.Title, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 30), false) != 0)
                    {
                      MP3.Changed = true;
                      MP3.V1TAG.TAGPresent = true;
                    }
                    MP3.V1TAG.Title = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                  }
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<B>", false) == 0) || (StringType.StrCmp(sLeft, "<b>", false) == 0))
                {
                  MP3.V2TAG.AddFrame(CreateTextFrame("TALB", StringType.FromObject(list2[num3])));
                  if (Declarations.objSettings.SynchronizeTAGs)
                  {
                    if (StringType.StrCmp(MP3.V1TAG.Album, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 30), false) != 0)
                    {
                      MP3.Changed = true;
                      MP3.V1TAG.TAGPresent = true;
                    }
                    MP3.V1TAG.Album = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                  }
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<K>", false) == 0) || (StringType.StrCmp(sLeft, "<k>", false) == 0))
                {
                  if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(list2[num3])))
                  {
                    if (MP3.V2TAG.FrameExists("TRCK"))
                    {
                      objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TRCK"));
                      if (StringType.StrCmp(str, "<K>", false) == 0)
                      {
                        obj3 = new V2TextFrame();
                        LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);
                        if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
                        {
                          LateBinding.LateSet(obj3, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') }, null);
                        }
                        else
                        {
                          objArray = new object[1];
                          objArray4 = new object[1];
                          obj4 = objectValue;
                          object[] args = new object[0];
                          strArray3 = null;
                          objArray6 = new object[1];
                          str4 = "/";
                          objArray6[0] = str4;
                          objArray4[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", args, strArray3, null), null, "IndexOf", objArray6, null, null));
                          objArray3 = objArray4;
                          flagArray = new bool[] { true };
                          if (flagArray[0])
                          {
                            LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", args, strArray3, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray3[0]) }, null, true, true);
                          }
                          objArray[0] = ObjectType.StrCatObj(Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'), LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray3, null, flagArray));
                          LateBinding.LateSet(obj3, null, "Content", objArray, null);
                        }
                        MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                      }
                      else
                      {
                        obj3 = new V2TextFrame();
                        LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);
                        if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
                        {
                          LateBinding.LateSet(obj3, null, "Content", new object[] { ObjectType.StrCatObj(ObjectType.StrCatObj(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), "/"), Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0')) }, null);
                        }
                        else
                        {
                          objArray6 = new object[1];
                          objArray3 = new object[2];
                          objArray3[0] = 0;
                          obj4 = objectValue;
                          objArray = new object[0];
                          strArray3 = null;
                          objArray2 = new object[1];
                          str4 = "/";
                          objArray2[0] = str4;
                          objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", objArray2, null, null));
                          objArray4 = objArray3;
                          flagArray = new bool[] { false, true };
                          if (flagArray[1])
                          {
                            LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);
                          }
                          objArray6[0] = ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray), Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'));
                          LateBinding.LateSet(obj3, null, "Content", objArray6, null);
                        }
                        MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                      }
                    }
                    else if (StringType.StrCmp(str, "<K>", false) == 0)
                    {
                      obj3 = new V2TextFrame();
                      LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);
                      LateBinding.LateSet(obj3, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') }, null);
                      MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                    }
                    else
                    {
                      obj3 = new V2TextFrame();
                      LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);
                      LateBinding.LateSet(obj3, null, "Content", new object[] { "/" + Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') }, null);
                      MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                    }
                    if (Declarations.objSettings.SynchronizeTAGs && ((Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))) >= 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))) <= 255.0)))
                    {
                      if (MP3.V1TAG.Tracknumber != Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))))
                      {
                        MP3.Changed = true;
                        MP3.V1TAG.TAGPresent = true;
                      }
                      MP3.V1TAG.Tracknumber = (byte)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))));
                    }
                  }
                  continue;
                }
                if ((StringType.StrCmp(sLeft, "<P>", false) == 0) || (StringType.StrCmp(sLeft, "<p>", false) == 0))
                {
                  if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(list2[num3])))
                  {
                    if (MP3.V2TAG.FrameExists("TPOS"))
                    {
                      objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TPOS"));
                      if (StringType.StrCmp(str, "<P>", false) == 0)
                      {
                        obj3 = new V2TextFrame();
                        LateBinding.LateSet(obj3, null, "FID", new object[] { "TPOS" }, null);
                        if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
                        {
                          LateBinding.LateSet(obj3, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') }, null);
                        }
                        else
                        {
                          objArray6 = new object[1];
                          objArray3 = new object[1];
                          obj4 = objectValue;
                          objArray = new object[0];
                          strArray3 = null;
                          objArray2 = new object[1];
                          str4 = "/";
                          objArray2[0] = str4;
                          objArray3[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", objArray2, null, null));
                          objArray4 = objArray3;
                          flagArray = new bool[] { true };
                          if (flagArray[0])
                          {
                            LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[0]) }, null, true, true);
                          }
                          objArray6[0] = ObjectType.StrCatObj(Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'), LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray));
                          LateBinding.LateSet(obj3, null, "Content", objArray6, null);
                        }
                        MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                      }
                      else
                      {
                        obj3 = new V2TextFrame();
                        LateBinding.LateSet(obj3, null, "FID", new object[] { "TPOS" }, null);
                        if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
                        {
                          LateBinding.LateSet(obj3, null, "Content", new object[] { ObjectType.StrCatObj(ObjectType.StrCatObj(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), "/"), Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0')) }, null);
                        }
                        else
                        {
                          objArray6 = new object[1];
                          objArray3 = new object[2];
                          objArray3[0] = 0;
                          obj4 = objectValue;
                          objArray = new object[0];
                          strArray3 = null;
                          objArray2 = new object[1];
                          str4 = "/";
                          objArray2[0] = str4;
                          objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", objArray2, null, null));
                          objArray4 = objArray3;
                          flagArray = new bool[] { false, true };
                          if (flagArray[1])
                          {
                            LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);
                          }
                          objArray6[0] = ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray), Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'));
                          LateBinding.LateSet(obj3, null, "Content", objArray6, null);
                        }
                        MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                      }
                    }
                    else if (StringType.StrCmp(str, "<P>", false) == 0)
                    {
                      obj3 = new V2TextFrame();
                      LateBinding.LateSet(obj3, null, "FID", new object[] { "TPOS" }, null);
                      LateBinding.LateSet(obj3, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') }, null);
                      MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                    }
                    else
                    {
                      obj3 = new V2TextFrame();
                      LateBinding.LateSet(obj3, null, "FID", new object[] { "TPOS" }, null);
                      LateBinding.LateSet(obj3, null, "Content", new object[] { "/" + Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') }, null);
                      MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                    }
                  }
                }
                else if ((StringType.StrCmp(sLeft, "<Y>", false) == 0) || (StringType.StrCmp(sLeft, "<y>", false) == 0))
                {
                  if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(list2[num3])))
                  {
                    objectValue = new V2TextFrame();
                    LateBinding.LateSet(objectValue, null, "FID", new object[] { RuntimeHelpers.GetObjectValue(Interaction.IIf(ObjectType.ObjTst(Interaction.IIf(MP3.V2TAG.TAGVersion != 0, MP3.V2TAG.TAGVersion, Declarations.objSettings.NewV2Version), 3, false) == 0, "TYER", "TDRC")) }, null);
                    LateBinding.LateSet(objectValue, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(4, '0') }, null);
                    MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                    if (Declarations.objSettings.SynchronizeTAGs)
                    {
                      if (MP3.V1TAG.Year != Conversion.Val(Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 4)))
                      {
                        MP3.Changed = true;
                        MP3.V1TAG.TAGPresent = true;
                      }
                      MP3.V1TAG.Year = (int)Math.Round(Conversion.Val(Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 4)));
                    }
                  }
                }
                else
                {
                  if ((StringType.StrCmp(sLeft, "<G>", false) == 0) || (StringType.StrCmp(sLeft, "<g>", false) == 0))
                  {
                    MP3.V2TAG.AddFrame(CreateTextFrame("TCON", StringType.FromObject(list2[num3])));
                    if (Declarations.objSettings.SynchronizeTAGs)
                    {
                      if (ObjectType.ObjTst(MP3.V1TAG.GenreText, LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null), false) != 0)
                      {
                        MP3.Changed = true;
                        MP3.V1TAG.TAGPresent = true;
                      }
                      MP3.V1TAG.GenreText = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                    }
                    continue;
                  }
                  if ((StringType.StrCmp(sLeft, "<C>", false) == 0) || (StringType.StrCmp(sLeft, "<c>", false) == 0))
                  {
                    objectValue = new V2LDCFrame();
                    LateBinding.LateSet(objectValue, null, "FID", new object[] { "COMM" }, null);
                    LateBinding.LateSet(objectValue, null, "Descriptor", new object[] { "ID3-TagIT FT " + num4.ToString().Trim(new char[] { ' ' }) }, null);
                    num4++;
                    LateBinding.LateSet(objectValue, null, "Language", new object[] { Declarations.astrLanLookup[Declarations.objSettings.V2Language].Substring(0, 3) }, null);
                    LateBinding.LateSet(objectValue, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(list2[num3]) }, null);
                    MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                    if (Declarations.objSettings.SynchronizeTAGs)
                    {
                      if (MP3.V1TAG.TAGVersion <= 10)
                      {
                        if (StringType.StrCmp(MP3.V1TAG.Comment, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 30), false) != 0)
                        {
                          MP3.Changed = true;
                          MP3.V1TAG.TAGPresent = true;
                        }
                      }
                      else if (StringType.StrCmp(MP3.V1TAG.Comment, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 0x1c), false) != 0)
                      {
                        MP3.Changed = true;
                        MP3.V1TAG.TAGPresent = true;
                      }
                      MP3.V1TAG.Comment = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                    }
                    continue;
                  }
                  if ((StringType.StrCmp(sLeft, "<O>", false) == 0) || (StringType.StrCmp(sLeft, "<o>", false) == 0))
                  {
                    MP3.V2TAG.AddFrame(CreateTextFrame("TPE2", StringType.FromObject(list2[num3])));
                  }
                  else
                  {
                    if ((StringType.StrCmp(sLeft, "<N>", false) == 0) || (StringType.StrCmp(sLeft, "<n>", false) == 0))
                    {
                      MP3.V2TAG.AddFrame(CreateTextFrame("TPE3", StringType.FromObject(list2[num3])));
                      continue;
                    }
                    if ((StringType.StrCmp(sLeft, "<M>", false) == 0) || (StringType.StrCmp(sLeft, "<m>", false) == 0))
                    {
                      MP3.V2TAG.AddFrame(CreateTextFrame("TPE4", StringType.FromObject(list2[num3])));
                      continue;
                    }
                    if ((StringType.StrCmp(sLeft, "<U>", false) == 0) || (StringType.StrCmp(sLeft, "<u>", false) == 0))
                    {
                      MP3.V2TAG.AddFrame(CreateTextFrame("TIT1", StringType.FromObject(list2[num3])));
                      continue;
                    }
                    if ((StringType.StrCmp(sLeft, "<R>", false) == 0) || (StringType.StrCmp(sLeft, "<r>", false) == 0))
                    {
                      MP3.V2TAG.AddFrame(CreateTextFrame("TCOM", StringType.FromObject(list2[num3])));
                      continue;
                    }
                    if ((StringType.StrCmp(sLeft, "<S>", false) == 0) || (StringType.StrCmp(sLeft, "<s>", false) == 0))
                    {
                      MP3.V2TAG.AddFrame(CreateTextFrame("TIT3", StringType.FromObject(list2[num3])));
                      continue;
                    }
                    if ((StringType.StrCmp(sLeft, "<E>", false) == 0) || (StringType.StrCmp(sLeft, "<e>", false) == 0))
                    {
                      int num6 = (int)Math.Round(Conversion.Fix(Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3]))));
                      MP3.V2TAG.AddFrame(CreateTextFrame("TBPM", num6.ToString()));
                      continue;
                    }
                    if ((StringType.StrCmp(sLeft, "<X>", false) != 0) && (StringType.StrCmp(sLeft, "<x>", false) == 0))
                    {
                    }
                  }
                }
              }
            }
          }
        }
        Label_1999:
        if (MP3.V2TAG.Changed)
        {
          if (!MP3.V2TAG.TAGHeaderPresent)
          {
            MP3.V2TAG.TAGHeaderPresent = true;
          }
          MP3.Changed = true;
        }
        continue;
        Label_19D2:
        using (IEnumerator enumerator = list.GetEnumerator())
        {
          while (enumerator.MoveNext())
          {
            str = StringType.FromObject(enumerator.Current);
            num3++;
            if (num3 == list2.Count)
            {
              goto Label_29B2;
            }
            if (ObjectType.ObjTst(list2[num3], "", false) != 0)
            {
              string str3 = str;
              if ((StringType.StrCmp(str3, "<A>", false) == 0) || (StringType.StrCmp(str3, "<a>", false) == 0))
              {
                if (StringType.StrCmp(MP3.V1TAG.Artist, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 30), false) != 0)
                {
                  MP3.Changed = true;
                  MP3.V1TAG.TAGPresent = true;
                }
                MP3.V1TAG.Artist = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                if (Declarations.objSettings.SynchronizeTAGs)
                {
                  MP3.V2TAG.AddFrame(CreateTextFrame("TPE1", StringType.FromObject(list2[num3])));
                }
              }
              else
              {
                if ((StringType.StrCmp(str3, "<T>", false) == 0) || (StringType.StrCmp(str3, "<t>", false) == 0))
                {
                  if (StringType.StrCmp(MP3.V1TAG.Title, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 30), false) != 0)
                  {
                    MP3.Changed = true;
                    MP3.V1TAG.TAGPresent = true;
                  }
                  MP3.V1TAG.Title = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                  if (Declarations.objSettings.SynchronizeTAGs)
                  {
                    MP3.V2TAG.AddFrame(CreateTextFrame("TIT2", StringType.FromObject(list2[num3])));
                  }
                  continue;
                }
                if ((StringType.StrCmp(str3, "<B>", false) == 0) || (StringType.StrCmp(str3, "<b>", false) == 0))
                {
                  if (StringType.StrCmp(MP3.V1TAG.Album, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 30), false) != 0)
                  {
                    MP3.Changed = true;
                    MP3.V1TAG.TAGPresent = true;
                  }
                  MP3.V1TAG.Album = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                  if (Declarations.objSettings.SynchronizeTAGs)
                  {
                    MP3.V2TAG.AddFrame(CreateTextFrame("TALB", StringType.FromObject(list2[num3])));
                  }
                  continue;
                }
                if ((StringType.StrCmp(str3, "<K>", false) == 0) || (StringType.StrCmp(str3, "<k>", false) == 0))
                {
                  if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))))
                  {
                    if ((Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))) >= 0.0) & (Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))) <= 255.0))
                    {
                      if (MP3.V1TAG.Tracknumber != Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))))
                      {
                        MP3.Changed = true;
                        MP3.V1TAG.TAGPresent = true;
                      }
                      MP3.V1TAG.Tracknumber = (byte)Math.Round(Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))));
                    }
                    if (Declarations.objSettings.SynchronizeTAGs)
                    {
                      if (MP3.V2TAG.FrameExists("TRCK"))
                      {
                        objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TRCK"));
                        if (StringType.StrCmp(str, "<K>", false) == 0)
                        {
                          obj3 = new V2TextFrame();
                          LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);
                          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
                          {
                            LateBinding.LateSet(obj3, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') }, null);
                          }
                          else
                          {
                            objArray6 = new object[1];
                            objArray3 = new object[1];
                            obj4 = objectValue;
                            objArray = new object[0];
                            strArray3 = null;
                            objArray2 = new object[1];
                            str4 = "/";
                            objArray2[0] = str4;
                            objArray3[0] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", objArray2, null, null));
                            objArray4 = objArray3;
                            flagArray = new bool[] { true };
                            if (flagArray[0])
                            {
                              LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[0]) }, null, true, true);
                            }
                            objArray6[0] = ObjectType.StrCatObj(Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'), LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray));
                            LateBinding.LateSet(obj3, null, "Content", objArray6, null);
                          }
                          MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                        }
                        else
                        {
                          obj3 = new V2TextFrame();
                          LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);
                          if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
                          {
                            LateBinding.LateSet(obj3, null, "Content", new object[] { ObjectType.StrCatObj(ObjectType.StrCatObj(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), "/"), Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0')) }, null);
                          }
                          else
                          {
                            objArray6 = new object[1];
                            objArray3 = new object[2];
                            objArray3[0] = 0;
                            obj4 = objectValue;
                            objArray = new object[0];
                            strArray3 = null;
                            objArray2 = new object[1];
                            str4 = "/";
                            objArray2[0] = str4;
                            objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", objArray2, null, null));
                            objArray4 = objArray3;
                            flagArray = new bool[] { false, true };
                            if (flagArray[1])
                            {
                              LateBinding.LateSetComplex(LateBinding.LateGet(obj4, null, "Content", objArray, strArray3, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray4[1]) }, null, true, true);
                            }
                            objArray6[0] = ObjectType.StrCatObj(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Substring", objArray4, null, flagArray), Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'));
                            LateBinding.LateSet(obj3, null, "Content", objArray6, null);
                          }
                          MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                        }
                      }
                      else if (StringType.StrCmp(str, "<K>", false) == 0)
                      {
                        obj3 = new V2TextFrame();
                        LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);
                        LateBinding.LateSet(obj3, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') }, null);
                        MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                      }
                      else
                      {
                        obj3 = new V2TextFrame();
                        LateBinding.LateSet(obj3, null, "FID", new object[] { "TRCK" }, null);
                        LateBinding.LateSet(obj3, null, "Content", new object[] { "/" + Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0') }, null);
                        MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(obj3));
                      }
                    }
                  }
                  continue;
                }
                if ((StringType.StrCmp(str3, "<Y>", false) == 0) || (StringType.StrCmp(str3, "<y>", false) == 0))
                {
                  if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null))))
                  {
                    if (MP3.V1TAG.Year != Conversion.Val(Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 4)))
                    {
                      MP3.Changed = true;
                      MP3.V1TAG.TAGPresent = true;
                    }
                    MP3.V1TAG.Year = (int)Math.Round(Conversion.Val(Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 4)));
                    if (Declarations.objSettings.SynchronizeTAGs)
                    {
                      objectValue = new V2TextFrame();
                      LateBinding.LateSet(objectValue, null, "FID", new object[] { RuntimeHelpers.GetObjectValue(Interaction.IIf(ObjectType.ObjTst(Interaction.IIf(MP3.V2TAG.TAGVersion != 0, MP3.V2TAG.TAGVersion, Declarations.objSettings.NewV2Version), 3, false) == 0, "TYER", "TDRC")) }, null);
                      LateBinding.LateSet(objectValue, null, "Content", new object[] { Conversion.Val(RuntimeHelpers.GetObjectValue(list2[num3])).ToString().Trim(new char[] { ' ' }).PadLeft(4, '0') }, null);
                      MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                    }
                  }
                }
                else
                {
                  if ((StringType.StrCmp(str3, "<G>", false) == 0) || (StringType.StrCmp(str3, "<g>", false) == 0))
                  {
                    if (ObjectType.ObjTst(MP3.V1TAG.GenreText, LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null), false) != 0)
                    {
                      MP3.Changed = true;
                      MP3.V1TAG.TAGPresent = true;
                    }
                    MP3.V1TAG.GenreText = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                    if (Declarations.objSettings.SynchronizeTAGs)
                    {
                      MP3.V2TAG.AddFrame(CreateTextFrame("TCON", StringType.FromObject(list2[num3])));
                    }
                    continue;
                  }
                  if ((StringType.StrCmp(str3, "<C>", false) == 0) || (StringType.StrCmp(str3, "<c>", false) == 0))
                  {
                    if (MP3.V1TAG.TAGVersion <= 10)
                    {
                      if (StringType.StrCmp(MP3.V1TAG.Comment, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 30), false) != 0)
                      {
                        MP3.Changed = true;
                        MP3.V1TAG.TAGPresent = true;
                      }
                    }
                    else if (StringType.StrCmp(MP3.V1TAG.Comment, Strings.Left(StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null)), 0x1c), false) != 0)
                    {
                      MP3.Changed = true;
                      MP3.V1TAG.TAGPresent = true;
                    }
                    MP3.V1TAG.Comment = StringType.FromObject(LateBinding.LateGet(list2[num3], null, "trim", new object[] { " " }, null, null));
                    if (Declarations.objSettings.SynchronizeTAGs)
                    {
                      objectValue = new V2LDCFrame();
                      LateBinding.LateSet(objectValue, null, "FID", new object[] { "COMM" }, null);
                      LateBinding.LateSet(objectValue, null, "Descriptor", new object[] { "ID3-TagIT FT " + num4.ToString().Trim(new char[] { ' ' }) }, null);
                      num4++;
                      LateBinding.LateSet(objectValue, null, "Language", new object[] { Declarations.astrLanLookup[Declarations.objSettings.V2Language].Substring(0, 3) }, null);
                      LateBinding.LateSet(objectValue, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(list2[num3]) }, null);
                      MP3.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
                    }
                    continue;
                  }
                  if ((StringType.StrCmp(str3, "<X>", false) != 0) && (StringType.StrCmp(str3, "<x>", false) == 0))
                  {
                  }
                }
              }
            }
          }
        }
        Label_29B2:
        if (Declarations.objSettings.SynchronizeTAGs && MP3.V2TAG.Changed)
        {
          if (!MP3.V2TAG.TAGHeaderPresent)
          {
            MP3.V2TAG.TAGHeaderPresent = true;
          }
          MP3.Changed = true;
        }
      }
    }

    public static Declarations.FormatReplaceFeedback FormatReplaceCheck(string vstrFormat, Declarations.FormatReplace ReplaceFormat)
    {
      if (((((ReplaceFormat & Declarations.FormatReplace.CompareTAGFilename) | (ReplaceFormat & Declarations.FormatReplace.OrganizeFiles)) | (ReplaceFormat & Declarations.FormatReplace.FilenameToTAG)) > ((Declarations.FormatReplace)0)) && ((((((vstrFormat.IndexOf(":") >= 0) | (vstrFormat.IndexOf('"') >= 0)) | (vstrFormat.IndexOf("/") >= 0)) | (vstrFormat.IndexOf("*") >= 0)) | (vstrFormat.IndexOf("|") >= 0)) | (vstrFormat.IndexOf("?") >= 0)))
      {
        return Declarations.FormatReplaceFeedback.InvalidCharFormat;
      }
      if (((ReplaceFormat & Declarations.FormatReplace.TAGToFilename) > ((Declarations.FormatReplace)0)) && (((((((vstrFormat.IndexOf(@"\") >= 0) | (vstrFormat.IndexOf(":") >= 0)) | (vstrFormat.IndexOf('"') >= 0)) | (vstrFormat.IndexOf("/") >= 0)) | (vstrFormat.IndexOf("*") >= 0)) | (vstrFormat.IndexOf("|") >= 0)) | (vstrFormat.IndexOf("?") >= 0)))
      {
        return Declarations.FormatReplaceFeedback.InvalidCharFormat;
      }
      if (((ReplaceFormat & Declarations.FormatReplace.TAGVer1) | (ReplaceFormat & Declarations.FormatReplace.TAGVer2)) > ((Declarations.FormatReplace)0))
      {
        vstrFormat = vstrFormat.Replace("<A>", "\x0001");
        vstrFormat = vstrFormat.Replace("<T>", "\x0001");
        vstrFormat = vstrFormat.Replace("<B>", "\x0001");
        vstrFormat = vstrFormat.Replace("<K>", "\x0001");
        vstrFormat = vstrFormat.Replace("<G>", "\x0001");
        vstrFormat = vstrFormat.Replace("<C>", "\x0001");
        vstrFormat = vstrFormat.Replace("<Y>", "\x0001");
      }
      if ((ReplaceFormat & Declarations.FormatReplace.TAGVer2) > ((Declarations.FormatReplace)0))
      {
        vstrFormat = vstrFormat.Replace("<O>", "\x0001");
        vstrFormat = vstrFormat.Replace("<N>", "\x0001");
        vstrFormat = vstrFormat.Replace("<M>", "\x0001");
        vstrFormat = vstrFormat.Replace("<R>", "\x0001");
        vstrFormat = vstrFormat.Replace("<U>", "\x0001");
        vstrFormat = vstrFormat.Replace("<S>", "\x0001");
        vstrFormat = vstrFormat.Replace("<P>", "\x0001");
        vstrFormat = vstrFormat.Replace("<E>", "\x0001");
        vstrFormat = vstrFormat.Replace("<p>", "\x0001");
        vstrFormat = vstrFormat.Replace("<k>", "\x0001");
      }
      if ((ReplaceFormat & Declarations.FormatReplace.TAGToFilename) > ((Declarations.FormatReplace)0))
      {
        vstrFormat = vstrFormat.Replace("<F>", "\x0001");
        vstrFormat = vstrFormat.Replace("<#>", "\x0001");
      }
      if ((ReplaceFormat & Declarations.FormatReplace.FilenameToTAG) > ((Declarations.FormatReplace)0))
      {
        vstrFormat = vstrFormat.Replace("<X>", "\x0001");
      }
      if (((ReplaceFormat & Declarations.FormatReplace.OrganizeFiles) | (ReplaceFormat & Declarations.FormatReplace.CompareTAGFilename)) > ((Declarations.FormatReplace)0))
      {
        vstrFormat = vstrFormat.Replace("<1>", "\x0001");
        vstrFormat = vstrFormat.Replace("<I>", "\x0001");
      }
      if (((vstrFormat.IndexOf("<") >= 0) | (vstrFormat.IndexOf(">") >= 0)) | ((vstrFormat.IndexOf("\x0001\x0001") >= 0) & ((ReplaceFormat & Declarations.FormatReplace.FilenameToTAG) == Declarations.FormatReplace.FilenameToTAG)))
      {
        return Declarations.FormatReplaceFeedback.InvalidFormat;
      }
      return Declarations.FormatReplaceFeedback.OK;
    }

    public static string FormatReplacedByTag(MP3 MP3, string vstrFormat, byte vbytTAGVersion)
    {
      V1TAG vtag;
      if (MP3.VBR)
      {
        vstrFormat = vstrFormat.Replace("<I>", "VBR");
      }
      else
      {
        vstrFormat = vstrFormat.Replace("<I>", (((double)MP3.Bitrate) / 1000.0).ToString());
      }
      switch (vbytTAGVersion)
      {
        case 1:
          if (!MP3.V1TAG.TAGPresent)
          {
            goto Label_13CF;
          }
          vtag = MP3.V1TAG;
          vstrFormat = vstrFormat.Replace("<A>", vtag.Artist.Trim(new char[] { ' ' }));
          if (StringType.StrCmp(vtag.Artist, "", false) != 0)
          {
            if (!Information.IsNumeric(vtag.Artist.Substring(0, 1)))
            {
              vstrFormat = vstrFormat.Replace("<1>", vtag.Artist.Trim(new char[] { ' ' }).Substring(0, 1));
              break;
            }
            vstrFormat = vstrFormat.Replace("<1>", "#");
          }
          break;

        case 2:
          if (MP3.V2TAG.TAGHeaderPresent)
          {
            object objectValue;
            string str2;
            string str3;
            bool[] flagArray;
            object[] objArray2;
            object[] objArray3;
            object[] objArray4;
            string str4;
            string[] strArray;
            object[] objArray5;
            object obj4;
            object[] objArray6;
            string[] strArray2;
            object[] objArray7;
            object obj5;
            object[] objArray8;
            int num2;
            if (((vstrFormat.IndexOf("<A>") >= 0) && MP3.V2TAG.FrameExists("TPE1")) && (ObjectType.ObjTst(LateBinding.LateGet(MP3.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), "", false) != 0))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TPE1"));
              vstrFormat = vstrFormat.Replace("<A>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
            if (((vstrFormat.IndexOf("<1>") >= 0) && MP3.V2TAG.FrameExists("TPE1")) && (ObjectType.ObjTst(LateBinding.LateGet(MP3.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null), "", false) != 0))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TPE1"));
              if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Substring", new object[] { 0, 1 }, null, null))))
              {
                vstrFormat = vstrFormat.Replace("<1>", "#");
              }
              else
              {
                vstrFormat = vstrFormat.Replace("<1>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Substring", new object[] { 0, 1 }, null, null)));
              }
            }
            if ((vstrFormat.IndexOf("<O>") >= 0) && MP3.V2TAG.FrameExists("TPE2"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TPE2"));
              vstrFormat = vstrFormat.Replace("<O>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
            if ((vstrFormat.IndexOf("<N>") >= 0) && MP3.V2TAG.FrameExists("TPE3"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TPE3"));
              vstrFormat = vstrFormat.Replace("<N>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
            if ((vstrFormat.IndexOf("<M>") >= 0) && MP3.V2TAG.FrameExists("TPE4"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TPE4"));
              vstrFormat = vstrFormat.Replace("<M>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
            if ((vstrFormat.IndexOf("<U>") >= 0) && MP3.V2TAG.FrameExists("TIT1"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TIT1"));
              vstrFormat = vstrFormat.Replace("<U>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
            if ((vstrFormat.IndexOf("<T>") >= 0) && MP3.V2TAG.FrameExists("TIT2"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TIT2"));
              vstrFormat = vstrFormat.Replace("<T>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
            if ((vstrFormat.IndexOf("<S>") >= 0) && MP3.V2TAG.FrameExists("TIT3"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TIT3"));
              vstrFormat = vstrFormat.Replace("<S>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
            if ((vstrFormat.IndexOf("<B>") >= 0) && MP3.V2TAG.FrameExists("TALB"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TALB"));
              vstrFormat = vstrFormat.Replace("<B>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
            if ((vstrFormat.IndexOf("<R>") >= 0) && MP3.V2TAG.FrameExists("TCOM"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TCOM"));
              vstrFormat = vstrFormat.Replace("<R>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
            if ((vstrFormat.IndexOf("<E>") >= 0) && MP3.V2TAG.FrameExists("TBPM"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TBPM"));
              try
              {
                vstrFormat = vstrFormat.Replace("<E>", ((int)Math.Round(Conversion.Fix(Conversion.Val(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)))))).ToString());
              }
              catch (Exception exception1)
              {
                ProjectData.SetProjectError(exception1);
                MP3.V2TAG.RemoveFrame(StringType.FromObject(objectValue));
                vstrFormat = vstrFormat.Replace("<E>", "");
                ProjectData.ClearProjectError();
              }
            }
            if (((vstrFormat.IndexOf("<K>") >= 0) | (vstrFormat.IndexOf("<k>") >= 0)) && MP3.V2TAG.FrameExists("TRCK"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TRCK"));
              if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
              {
                str2 = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null));
                str3 = "";
              }
              else
              {
                objArray3 = new object[2];
                objArray3[0] = 0;
                obj5 = objectValue;
                objArray7 = new object[0];
                strArray2 = null;
                objArray6 = new object[1];
                object[] objArray9 = objArray6;
                num2 = 0;
                obj4 = " ";
                objArray9[num2] = RuntimeHelpers.GetObjectValue(obj4);
                objArray5 = objArray9;
                strArray = null;
                objArray4 = new object[1];
                str4 = "/";
                objArray4[0] = str4;
                objArray3[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(obj5, null, "Content", objArray7, strArray2, null), null, "Trim", objArray5, strArray, null), null, "IndexOf", objArray4, null, null));
                objArray2 = objArray3;
                flagArray = new bool[] { false, true };
                if (flagArray[1])
                {
                  objArray9 = objArray6;
                  objArray9[num2] = RuntimeHelpers.GetObjectValue(obj4);
                  LateBinding.LateSetComplex(LateBinding.LateGet(LateBinding.LateGet(obj5, null, "Content", objArray7, strArray2, null), null, "Trim", objArray5, strArray, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray2[1]) }, null, true, true);
                }
                str2 = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Substring", objArray2, null, flagArray));
                str3 = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Substring", new object[] { ObjectType.AddObj(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "IndexOf", new object[] { "/" }, null, null), 1) }, null, null));
              }
              vstrFormat = vstrFormat.Replace("<K>", str2.PadLeft(Declarations.objSettings.TracknumberDigitsFilename, '0'));
              vstrFormat = vstrFormat.Replace("<k>", str3.PadLeft(Declarations.objSettings.TracknumberDigitsFilename, '0'));
            }
            if (((vstrFormat.IndexOf("<P>") >= 0) | (vstrFormat.IndexOf("<p>") >= 0)) && MP3.V2TAG.FrameExists("TPOS"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TPOS"));
              if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "/" }, null, null), 0, false) < 0)
              {
                str2 = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null));
                str3 = "";
              }
              else
              {
                objArray7 = new object[2];
                objArray7[0] = 0;
                obj4 = objectValue;
                objArray3 = new object[0];
                strArray = null;
                objArray4 = new object[1];
                objArray2 = objArray4;
                num2 = 0;
                obj5 = " ";
                objArray2[num2] = RuntimeHelpers.GetObjectValue(obj5);
                objArray5 = objArray2;
                strArray2 = null;
                objArray6 = new object[1];
                str4 = "/";
                objArray6[0] = str4;
                objArray7[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray3, strArray, null), null, "Trim", objArray5, strArray2, null), null, "IndexOf", objArray6, null, null));
                objArray8 = objArray7;
                flagArray = new bool[] { false, true };
                if (flagArray[1])
                {
                  objArray2 = objArray4;
                  objArray2[num2] = RuntimeHelpers.GetObjectValue(obj5);
                  LateBinding.LateSetComplex(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray3, strArray, null), null, "Trim", objArray5, strArray2, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray8[1]) }, null, true, true);
                }
                str2 = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Substring", objArray8, null, flagArray));
                str3 = StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Substring", new object[] { ObjectType.AddObj(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "IndexOf", new object[] { "/" }, null, null), 1) }, null, null));
              }
              vstrFormat = vstrFormat.Replace("<P>", str2.PadLeft(Declarations.objSettings.TracknumberDigitsFilename, '0'));
              vstrFormat = vstrFormat.Replace("<p>", str3.PadLeft(Declarations.objSettings.TracknumberDigitsFilename, '0'));
            }
            if ((vstrFormat.IndexOf("<G>") >= 0) && MP3.V2TAG.FrameExists("TCON"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TCON"));
              if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "IndexOf", new object[] { "\0" }, null, null), 0, false) < 0)
              {
                vstrFormat = vstrFormat.Replace("<G>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
              }
              else
              {
                objArray7 = new object[2];
                objArray7[0] = 0;
                obj4 = objectValue;
                objArray3 = new object[0];
                strArray = null;
                objArray4 = new object[1];
                objArray2 = objArray4;
                num2 = 0;
                obj5 = " ";
                objArray2[num2] = RuntimeHelpers.GetObjectValue(obj5);
                objArray5 = objArray2;
                strArray2 = null;
                objArray6 = new object[1];
                str4 = "\0";
                objArray6[0] = str4;
                objArray7[1] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray3, strArray, null), null, "Trim", objArray5, strArray2, null), null, "IndexOf", objArray6, null, null));
                objArray8 = objArray7;
                flagArray = new bool[] { false, true };
                if (flagArray[1])
                {
                  objArray2 = objArray4;
                  objArray2[num2] = RuntimeHelpers.GetObjectValue(obj5);
                  LateBinding.LateSetComplex(LateBinding.LateGet(LateBinding.LateGet(obj4, null, "Content", objArray3, strArray, null), null, "Trim", objArray5, strArray2, null), null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray8[1]) }, null, true, true);
                }
                vstrFormat = vstrFormat.Replace("<G>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Substring", objArray8, null, flagArray)));
              }
            }
            if ((vstrFormat.IndexOf("<Y>") >= 0) && MP3.V2TAG.FrameExists("TYER"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TYER"));
              if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Length", new object[0], null, null), 4, false) >= 0)
              {
                vstrFormat = vstrFormat.Replace("<Y>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Substring", new object[] { 0, 4 }, null, null)));
              }
            }
            if ((vstrFormat.IndexOf("<Y>") >= 0) && MP3.V2TAG.FrameExists("TDRC"))
            {
              objectValue = RuntimeHelpers.GetObjectValue(MP3.V2TAG.GetFrame("TDRC"));
              if (ObjectType.ObjTst(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Length", new object[0], null, null), 4, false) >= 0)
              {
                vstrFormat = vstrFormat.Replace("<Y>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(LateBinding.LateGet(objectValue, null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null), null, "Substring", new object[] { 0, 4 }, null, null)));
              }
            }
            if ((vstrFormat.IndexOf("<C>") >= 0) && MP3.V2TAG.FrameExists("COMM"))
            {
              vstrFormat = vstrFormat.Replace("<C>", StringType.FromObject(LateBinding.LateGet(LateBinding.LateGet(MP3.V2TAG.GetFrame("COMM"), null, "Content", new object[0], null, null), null, "Trim", new object[] { " " }, null, null)));
            }
          }
          goto Label_13CF;

        default:
          goto Label_13CF;
      }
      vstrFormat = vstrFormat.Replace("<T>", vtag.Title.Trim(new char[] { ' ' }));
      vstrFormat = vstrFormat.Replace("<B>", vtag.Album.Trim(new char[] { ' ' }));
      vstrFormat = vstrFormat.Replace("<K>", vtag.Tracknumber.ToString().PadLeft(Declarations.objSettings.TracknumberDigitsFilename, '0'));
      vstrFormat = vstrFormat.Replace("<G>", vtag.GenreText);
      vstrFormat = vstrFormat.Replace("<C>", vtag.Comment.Trim(new char[] { ' ' }));
      vstrFormat = vstrFormat.Replace("<Y>", vtag.Year.ToString().Trim(new char[] { ' ' }));
      vtag = null;
      Label_13CF:
      vstrFormat = vstrFormat.Replace("<I>", "");
      vstrFormat = vstrFormat.Replace("<A>", "");
      vstrFormat = vstrFormat.Replace("<T>", "");
      vstrFormat = vstrFormat.Replace("<B>", "");
      vstrFormat = vstrFormat.Replace("<K>", "");
      vstrFormat = vstrFormat.Replace("<G>", "");
      vstrFormat = vstrFormat.Replace("<C>", "");
      vstrFormat = vstrFormat.Replace("<Y>", "");
      vstrFormat = vstrFormat.Replace("<1>", "");
      if (vbytTAGVersion == 2)
      {
        vstrFormat = vstrFormat.Replace("<O>", "");
        vstrFormat = vstrFormat.Replace("<N>", "");
        vstrFormat = vstrFormat.Replace("<M>", "");
        vstrFormat = vstrFormat.Replace("<R>", "");
        vstrFormat = vstrFormat.Replace("<U>", "");
        vstrFormat = vstrFormat.Replace("<S>", "");
        vstrFormat = vstrFormat.Replace("<P>", "");
        vstrFormat = vstrFormat.Replace("<E>", "");
        vstrFormat = vstrFormat.Replace("<k>", "");
        vstrFormat = vstrFormat.Replace("<p>", "");
      }
      return vstrFormat;
    }

    public static byte GetV1GenreByName(string vstrName)
    {
      byte upperBound = (byte)Declarations.astrGenreLookup.GetUpperBound(0);
      for (byte i = 0; i <= upperBound; i = (byte)(i + 1))
      {
        if (StringType.StrCmp(Declarations.astrGenreLookup[i], vstrName, false) == 0)
        {
          return i;
        }
        if (StringType.StrCmp(Declarations.astrGenreLookup[i].ToLower().Replace(" ", "").Replace("-", ""), vstrName.ToLower().Replace(" ", "").Replace("-", ""), false) == 0)
        {
          return i;
        }
      }
      return 0xff;
    }

    public static bool MatchFilenameFormat(string vstrFilename, string vstrFormat, [Optional, DefaultParameterValue(false)] bool vbooModifyFormat)
    {
      string str2;
      ArrayList list = new ArrayList();
      ArrayList list2 = new ArrayList();
      string sRight = "";
      list.Clear();
      list2.Clear();
      string str4 = vstrFormat;
      string sLeft = vstrFormat;
      string str3 = vstrFilename;
      if (vbooModifyFormat)
      {
        str4 = str4.Replace("<A>", "<ABC>").Replace("<T>", "<ABC>").Replace("<B>", "<ABC>").Replace("<K>", "<123>").Replace("<G>", "<ABC>").Replace("<C>", "<ABC>").Replace("<Y>", "<123>").Replace("<U>", "<ABC>").Replace("<X>", "<ABC>").Replace("<O>", "<ABC>").Replace("<N>", "<ABC>").Replace("<M>", "<ABC>").Replace("<R>", "<ABC>").Replace("<S>", "<ABC>").Replace("<P>", "<123>").Replace("<E>", "<123>").Replace("<p>", "<123>").Replace("<k>", "<123>").Replace("<a>", "<ABC>").Replace("<t>", "<ABC>").Replace("<b>", "<ABC>").Replace("<g>", "<ABC>").Replace("<c>", "<ABC>").Replace("<y>", "<123>").Replace("<x>", "<ABC>").Replace("<u>", "<ABC>").Replace("<o>", "<ABC>").Replace("<n>", "<ABC>").Replace("<m>", "<ABC>").Replace("<r>", "<ABC>").Replace("<s>", "<ABC>").Replace("<p>", "<123>").Replace("<e>", "<123>").Replace("<abc>", "<ABC>");
        sLeft = str4;
      }
      str4 = str4.Replace("<ABC>", "\x0001").Replace("<123>", "\x0001");
      string[] strArray = str4.Split(new char[] { '\x0001' });
      int upperBound = strArray.GetUpperBound(0);
      for (int i = 0; i <= upperBound; i++)
      {
        if ((i == strArray.GetUpperBound(0)) | (StringType.StrCmp(strArray[i], "", false) != 0))
        {
          list.Add(strArray[i]);
          str4 = str4.Substring(str4.IndexOf('\x0001') + 1);
          if (str3.IndexOf(strArray[i]) < 0)
          {
            list2.Add(str3);
            break;
          }
          list2.Add(RuntimeHelpers.GetObjectValue(Interaction.IIf(StringType.StrCmp(strArray[i], "", false) == 0, str3, str3.Substring(0, str3.IndexOf(strArray[i])))));
          str3 = str3.Substring(str3.IndexOf(strArray[i]) + strArray[i].Length);
        }
      }
      int num3 = -1;
      if (vstrFormat.StartsWith(StringType.FromObject(list[0])))
      {
        using (IEnumerator enumerator2 = list.GetEnumerator())
        {
          while (enumerator2.MoveNext())
          {
            str2 = StringType.FromObject(enumerator2.Current);
            num3++;
            sRight = sRight + str2;
            if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(list2[num3])))
            {
              sRight = sRight + "<123>";
            }
            else
            {
              sRight = sRight + "<ABC>";
            }
          }
          goto Label_04DF;
        }
      }
      using (IEnumerator enumerator = list.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          str2 = StringType.FromObject(enumerator.Current);
          num3++;
          if (Information.IsNumeric(RuntimeHelpers.GetObjectValue(list2[num3])))
          {
            sRight = sRight + "<123>";
          }
          else
          {
            sRight = sRight + "<ABC>";
          }
          sRight = sRight + str2;
        }
      }
      Label_04DF:
      if (StringType.StrCmp(sLeft, sRight, false) == 0)
      {
        return true;
      }
      return false;
    }

    public static byte[] RemoveUnsync(byte[] abytBuffer)
    {
      ArrayList list = new ArrayList {
                Convert.ToByte(abytBuffer[0])
            };
      int upperBound = abytBuffer.GetUpperBound(0);
      for (int i = 1; i <= upperBound; i++)
      {
        if ((abytBuffer[i - 1] != 0xff) || (abytBuffer[i] != 0))
        {
          list.Add(Convert.ToByte(abytBuffer[i]));
        }
      }
      abytBuffer = new byte[(list.Count - 1) + 1];
      list.ToArray(typeof(byte)).CopyTo(abytBuffer, 0);
      return abytBuffer;
    }

    public static bool ZLibDecompress(int vintOrigSize, ref byte[] abytBuffer)
    {
      bool flag;
      byte[] b = new byte[(vintOrigSize - 1) + 1];
      InflaterInputStream stream = new InflaterInputStream(new MemoryStream(abytBuffer));
      try
      {
        byte[] buffer;
        int num3;
        int num2 = 0;
        for (int i = 0; 1 != 0; i += num3)
        {
          num3 = stream.Read(b, 0, b.Length);
          if (num3 <= 0)
          {
            break;
          }
          byte[] array = new byte[((i + num3) - 1) + 1];
          if (buffer != null)
          {
            buffer.CopyTo(array, 0);
          }
          buffer = new byte[((i + num3) - 1) + 1];
          array.CopyTo(buffer, 0);
          int num5 = num3 - 1;
          for (int j = 0; j <= num5; j++)
          {
            buffer[num2 + j] = b[j];
          }
          num2 += num3;
        }
        stream.Close();
        abytBuffer = new byte[buffer.GetUpperBound(0) + 1];
        buffer.CopyTo(abytBuffer, 0);
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
  }
}