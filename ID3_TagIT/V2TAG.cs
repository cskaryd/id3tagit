namespace ID3_TagIT
{
  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using System;
  using System.Collections;
  using System.Collections.Specialized;
  using System.IO;
  using System.Runtime.CompilerServices;
  using System.Runtime.InteropServices;
  using System.Runtime.Serialization.Formatters.Binary;

  [Serializable]
  public class V2TAG : V2TAGHeader
  {
    private ListDictionary htAPICFrames = new ListDictionary();
    private ArrayList htBinFrames = new ArrayList();
    private ListDictionary htCOMMFrames = new ListDictionary();
    private ListDictionary htPOPMFrames = new ListDictionary();
    private Hashtable htSingleFrames = new Hashtable();
    private ListDictionary htTXXXFrames = new ListDictionary();
    private ListDictionary htUSLTFrames = new ListDictionary();
    private ListDictionary htWXXXFrames = new ListDictionary();
    private bool vbooChanged = false;

    public void AddFrame(object Frame)
    {
      string sLeft = StringType.FromObject(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null));
      if (((sLeft.StartsWith("T") | sLeft.StartsWith("W")) | (StringType.StrCmp(sLeft, "IPLS", false) == 0)) && !((StringType.StrCmp(sLeft, "TXXX", false) == 0) | (StringType.StrCmp(sLeft, "WXXX", false) == 0)))
      {
        LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        if (BooleanType.FromObject(LateBinding.LateGet(Frame, null, "Remove", new object[0], null, null)))
        {
          if (this.htSingleFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null))))
          {
            this.htSingleFrames.Remove(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null)));
            this.vbooChanged = true;
          }
        }
        else if (this.htSingleFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null))))
        {
          if (ObjectType.ObjTst(LateBinding.LateGet(this.htSingleFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null))], null, "Content", new object[0], null, null), LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), false) != 0)
          {
            LateBinding.LateSetComplex(this.htSingleFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null))], null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null)) }, null, false, true);
            this.vbooChanged = true;
          }
        }
        else
        {
          this.htSingleFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null)), RuntimeHelpers.GetObjectValue(Frame));
          this.vbooChanged = true;
        }
      }
      else
      {
        string str2 = sLeft;
        if (StringType.StrCmp(str2, "COMM", false) == 0)
        {
          LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          LateBinding.LateSet(Frame, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), null, "ToLower", new object[0], null, null)) }, null);
          LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          if (BooleanType.FromObject(LateBinding.LateGet(Frame, null, "Remove", new object[0], null, null)))
          {
            if (this.htCOMMFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
            {
              this.htCOMMFrames.Remove(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
              this.vbooChanged = true;
            }
          }
          else if (this.htCOMMFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
          {
            if (ObjectType.ObjTst(LateBinding.LateGet(this.htCOMMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Content", new object[0], null, null), LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), false) != 0)
            {
              LateBinding.LateSetComplex(this.htCOMMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)) }, null, false, true);
              LateBinding.LateSetComplex(this.htCOMMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null)) }, null, false, true);
              this.vbooChanged = true;
            }
            else if (ObjectType.ObjTst(LateBinding.LateGet(this.htCOMMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), false) != 0)
            {
              LateBinding.LateSetComplex(this.htCOMMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)) }, null, false, true);
              this.vbooChanged = true;
            }
          }
          else
          {
            this.htCOMMFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)), RuntimeHelpers.GetObjectValue(Frame));
            this.vbooChanged = true;
          }
        }
        else if (StringType.StrCmp(str2, "USLT", false) == 0)
        {
          LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          LateBinding.LateSet(Frame, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), null, "ToLower", new object[0], null, null)) }, null);
          LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          if (BooleanType.FromObject(LateBinding.LateGet(Frame, null, "Remove", new object[0], null, null)))
          {
            if (this.htUSLTFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
            {
              this.htUSLTFrames.Remove(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
              this.vbooChanged = true;
            }
          }
          else if (this.htUSLTFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
          {
            if (ObjectType.ObjTst(LateBinding.LateGet(this.htUSLTFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Content", new object[0], null, null), LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), false) != 0)
            {
              LateBinding.LateSetComplex(this.htUSLTFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)) }, null, false, true);
              LateBinding.LateSetComplex(this.htUSLTFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null)) }, null, false, true);
              this.vbooChanged = true;
            }
            else if (ObjectType.ObjTst(LateBinding.LateGet(this.htUSLTFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), false) != 0)
            {
              LateBinding.LateSetComplex(this.htUSLTFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)) }, null, false, true);
              this.vbooChanged = true;
            }
          }
          else
          {
            this.htUSLTFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)), RuntimeHelpers.GetObjectValue(Frame));
            this.vbooChanged = true;
          }
        }
        else if (StringType.StrCmp(str2, "TXXX", false) == 0)
        {
          LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          if (BooleanType.FromObject(LateBinding.LateGet(Frame, null, "Remove", new object[0], null, null)))
          {
            if (this.htTXXXFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
            {
              this.htTXXXFrames.Remove(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
              this.vbooChanged = true;
            }
          }
          else if (this.htTXXXFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
          {
            if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(this.htTXXXFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(this.htTXXXFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "content", new object[0], null, null), LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), false) != 0)))
            {
              LateBinding.LateSetComplex(this.htTXXXFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)) }, null, false, true);
              LateBinding.LateSetComplex(this.htTXXXFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null)) }, null, false, true);
              this.vbooChanged = true;
            }
          }
          else
          {
            this.htTXXXFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)), RuntimeHelpers.GetObjectValue(Frame));
            this.vbooChanged = true;
          }
        }
        else if (StringType.StrCmp(str2, "WXXX", false) == 0)
        {
          LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          if (BooleanType.FromObject(LateBinding.LateGet(Frame, null, "Remove", new object[0], null, null)))
          {
            if (this.htWXXXFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
            {
              this.htWXXXFrames.Remove(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
              this.vbooChanged = true;
            }
          }
          else if (this.htWXXXFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
          {
            if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(this.htWXXXFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(this.htWXXXFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "content", new object[0], null, null), LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), false) != 0)))
            {
              LateBinding.LateSetComplex(this.htWXXXFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)) }, null, false, true);
              LateBinding.LateSetComplex(this.htWXXXFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null)) }, null, false, true);
              this.vbooChanged = true;
            }
          }
          else
          {
            this.htWXXXFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)), RuntimeHelpers.GetObjectValue(Frame));
            this.vbooChanged = true;
          }
        }
        else if (StringType.StrCmp(str2, "POPM", false) == 0)
        {
          LateBinding.LateSet(Frame, null, "User", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "User", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          if (BooleanType.FromObject(LateBinding.LateGet(Frame, null, "Remove", new object[0], null, null)))
          {
            if (this.htPOPMFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
            {
              this.htPOPMFrames.Remove(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
              this.vbooChanged = true;
            }
          }
          else if (this.htPOPMFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
          {
            if (BooleanType.FromObject(ObjectType.BitOrObj(ObjectType.BitOrObj(ObjectType.ObjTst(LateBinding.LateGet(this.htPOPMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Rating", new object[0], null, null), LateBinding.LateGet(Frame, null, "Rating", new object[0], null, null), false) != 0, ObjectType.ObjTst(LateBinding.LateGet(this.htPOPMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "user", new object[0], null, null), LateBinding.LateGet(Frame, null, "User", new object[0], null, null), false) != 0), ObjectType.ObjTst(LateBinding.LateGet(this.htPOPMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "counter", new object[0], null, null), LateBinding.LateGet(Frame, null, "Counter", new object[0], null, null), false) != 0)))
            {
              LateBinding.LateSetComplex(this.htPOPMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "User", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "User", new object[0], null, null)) }, null, false, true);
              LateBinding.LateSetComplex(this.htPOPMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Rating", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Rating", new object[0], null, null)) }, null, false, true);
              LateBinding.LateSetComplex(this.htPOPMFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Counter", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Counter", new object[0], null, null)) }, null, false, true);
              this.vbooChanged = true;
            }
          }
          else
          {
            this.htPOPMFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null)), RuntimeHelpers.GetObjectValue(Frame));
            this.vbooChanged = true;
          }
        }
        else if (StringType.StrCmp(str2, "APIC", false) == 0)
        {
          LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          LateBinding.LateSet(Frame, null, "Path", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Path", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
          if (BooleanType.FromObject(LateBinding.LateGet(Frame, null, "Remove", new object[0], null, null)))
          {
            if (this.htAPICFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
            {
              this.htAPICFrames.Remove(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
              this.vbooChanged = true;
            }
          }
          else if (this.htAPICFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))))
          {
            if (ObjectType.ObjTst(LateBinding.LateGet(this.htAPICFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Path", new object[0], null, null), LateBinding.LateGet(Frame, null, "Path", new object[0], null, null), false) != 0)
            {
              LateBinding.LateSetComplex(this.htAPICFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)) }, null, false, true);
              LateBinding.LateSetComplex(this.htAPICFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Path", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Path", new object[0], null, null)) }, null, false, true);
              this.vbooChanged = true;
            }
            else if (ObjectType.ObjTst(LateBinding.LateGet(this.htAPICFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), false) != 0)
            {
              LateBinding.LateSetComplex(this.htAPICFrames[RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null))], null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)) }, null, false, true);
              this.vbooChanged = true;
            }
          }
          else
          {
            this.htAPICFrames.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)), RuntimeHelpers.GetObjectValue(Frame));
            this.vbooChanged = true;
          }
        }
        else
        {
          this.htBinFrames.Add(RuntimeHelpers.GetObjectValue(Frame));
        }
      }
    }

    public void AddFrames(ArrayList alstFrames)
    {
      IEnumerator enumerator;
      try
      {
        enumerator = alstFrames.GetEnumerator();
        while (enumerator.MoveNext())
        {
          object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
          this.AddFrame(RuntimeHelpers.GetObjectValue(objectValue));
        }
      }
      finally
      {
        if (enumerator is IDisposable)
        {
          ((IDisposable)enumerator).Dispose();
        }
      }
    }

    public V2TAG Clone()
    {
      BinaryFormatter formatter = new BinaryFormatter();
      MemoryStream serializationStream = new MemoryStream();
      formatter.Serialize(serializationStream, this);
      serializationStream.Position = 0L;
      return (V2TAG)formatter.Deserialize(serializationStream);
    }

    private byte[] CreateTAG(MP3 MP3, int vintPadSize, [Optional, DefaultParameterValue(0)] ref int ReturnedPadAdded)
    {
      object objectValue;
      bool[] flagArray;
      object[] objArray2;
      object[] objArray3;
      ArrayList list = new ArrayList();
      int num = 0;
      using (IEnumerator enumerator10 = this.htSingleFrames.Keys.GetEnumerator())
      {
        while (enumerator10.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator10.Current);
          objArray2 = new object[] { MP3 };
          flagArray = new bool[] { true };
          if (flagArray[0])
          {
            MP3 = (MP3)objArray2[0];
          }
          list.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.htSingleFrames[RuntimeHelpers.GetObjectValue(objectValue)], null, "CreateFrame", objArray2, null, flagArray)));
        }
      }
      using (IEnumerator enumerator9 = this.htCOMMFrames.Keys.GetEnumerator())
      {
        while (enumerator9.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator9.Current);
          objArray3 = new object[] { MP3 };
          flagArray = new bool[] { true };
          if (flagArray[0])
          {
            MP3 = (MP3)objArray3[0];
          }
          list.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.htCOMMFrames[RuntimeHelpers.GetObjectValue(objectValue)], null, "CreateFrame", objArray3, null, flagArray)));
        }
      }
      using (IEnumerator enumerator8 = this.htUSLTFrames.Keys.GetEnumerator())
      {
        while (enumerator8.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator8.Current);
          objArray3 = new object[] { MP3 };
          flagArray = new bool[] { true };
          if (flagArray[0])
          {
            MP3 = (MP3)objArray3[0];
          }
          list.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.htUSLTFrames[RuntimeHelpers.GetObjectValue(objectValue)], null, "CreateFrame", objArray3, null, flagArray)));
        }
      }
      using (IEnumerator enumerator7 = this.htAPICFrames.Keys.GetEnumerator())
      {
        while (enumerator7.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator7.Current);
          objArray3 = new object[] { MP3 };
          flagArray = new bool[] { true };
          if (flagArray[0])
          {
            MP3 = (MP3)objArray3[0];
          }
          list.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.htAPICFrames[RuntimeHelpers.GetObjectValue(objectValue)], null, "CreateFrame", objArray3, null, flagArray)));
        }
      }
      using (IEnumerator enumerator6 = this.htTXXXFrames.Keys.GetEnumerator())
      {
        while (enumerator6.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator6.Current);
          objArray3 = new object[] { MP3 };
          flagArray = new bool[] { true };
          if (flagArray[0])
          {
            MP3 = (MP3)objArray3[0];
          }
          list.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.htTXXXFrames[RuntimeHelpers.GetObjectValue(objectValue)], null, "CreateFrame", objArray3, null, flagArray)));
        }
      }
      using (IEnumerator enumerator5 = this.htWXXXFrames.Keys.GetEnumerator())
      {
        while (enumerator5.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator5.Current);
          objArray3 = new object[] { MP3 };
          flagArray = new bool[] { true };
          if (flagArray[0])
          {
            MP3 = (MP3)objArray3[0];
          }
          list.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.htWXXXFrames[RuntimeHelpers.GetObjectValue(objectValue)], null, "CreateFrame", objArray3, null, flagArray)));
        }
      }
      using (IEnumerator enumerator4 = this.htPOPMFrames.Keys.GetEnumerator())
      {
        while (enumerator4.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator4.Current);
          objArray3 = new object[] { MP3 };
          flagArray = new bool[] { true };
          if (flagArray[0])
          {
            MP3 = (MP3)objArray3[0];
          }
          list.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(this.htPOPMFrames[RuntimeHelpers.GetObjectValue(objectValue)], null, "CreateFrame", objArray3, null, flagArray)));
        }
      }
      using (IEnumerator enumerator3 = this.htBinFrames.GetEnumerator())
      {
        while (enumerator3.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator3.Current);
          objArray3 = new object[] { MP3 };
          flagArray = new bool[] { true };
          if (flagArray[0])
          {
            MP3 = (MP3)objArray3[0];
          }
          list.Add(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(objectValue, null, "CreateFrame", objArray3, null, flagArray)));
        }
      }
      using (IEnumerator enumerator2 = list.GetEnumerator())
      {
        while (enumerator2.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
          num = IntegerType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(objectValue, null, "Length", new object[0], null, null)));
        }
      }
      if (!MP3.V2TAG.FooterPresent)
      {
        if (vintPadSize >= num)
        {
          if (vintPadSize > (((num / 0x400) * 0x400) + 0x7f6))
          {
            if (vintPadSize > 0x8000)
            {
              num = ((num / 0x400) * 0x400) + 0x7f6;
            }
            else
            {
              num = vintPadSize;
            }
          }
          else
          {
            num = vintPadSize;
          }
        }
        else
        {
          num = ((num / 0x400) * 0x400) + 0x7f6;
        }
      }
      byte[] abytBuffer = new byte[(num - 1) + 1];
      num = 0;
      using (IEnumerator enumerator = list.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
          objArray2 = new object[5];
          objArray2[0] = RuntimeHelpers.GetObjectValue(objectValue);
          objArray2[1] = 0;
          objArray2[2] = abytBuffer;
          objArray2[3] = num;
          object o = objectValue;
          objArray2[4] = RuntimeHelpers.GetObjectValue(LateBinding.LateGet(o, null, "Length", new object[0], null, null));
          objArray3 = objArray2;
          flagArray = new bool[] { true, false, true, true, true };
          LateBinding.LateCall(null, typeof(Array), "Copy", objArray3, null, flagArray);
          if (flagArray[4])
          {
            LateBinding.LateSetComplex(o, null, "Length", new object[] { RuntimeHelpers.GetObjectValue(objArray3[4]) }, null, true, false);
          }
          if (flagArray[3])
          {
            num = IntegerType.FromObject(objArray3[3]);
          }
          if (flagArray[2])
          {
            abytBuffer = (byte[])objArray3[2];
          }
          if (flagArray[0])
          {
            objectValue = RuntimeHelpers.GetObjectValue(objArray3[0]);
          }
          num = IntegerType.FromObject(ObjectType.AddObj(num, LateBinding.LateGet(objectValue, null, "Length", new object[0], null, null)));
        }
      }
      ReturnedPadAdded = abytBuffer.Length - num;
      if ((MP3.V2TAG.TAGVersion == 3) & Declarations.objSettings.WriteUnsync)
      {
        abytBuffer = ID3Functions.DoUnsync(abytBuffer);
      }
      return abytBuffer;
    }

    public bool FrameExists(string vstrFrameID)
    {
      if (((vstrFrameID.StartsWith("T") | vstrFrameID.StartsWith("W")) | (StringType.StrCmp(vstrFrameID, "IPLS", false) == 0)) && !((StringType.StrCmp(vstrFrameID, "TXXX", false) == 0) | (StringType.StrCmp(vstrFrameID, "WXXX", false) == 0)))
      {
        if (this.htSingleFrames.Contains(vstrFrameID))
        {
          return true;
        }
      }
      else
      {
        string sLeft = vstrFrameID;
        if (StringType.StrCmp(sLeft, "COMM", false) == 0)
        {
          if (this.htCOMMFrames.Keys.Count > 0)
          {
            return true;
          }
        }
        else if (StringType.StrCmp(sLeft, "USLT", false) == 0)
        {
          if (this.htUSLTFrames.Keys.Count > 0)
          {
            return true;
          }
        }
        else if (StringType.StrCmp(sLeft, "TXXX", false) == 0)
        {
          if (this.htTXXXFrames.Keys.Count > 0)
          {
            return true;
          }
        }
        else if (StringType.StrCmp(sLeft, "WXXX", false) == 0)
        {
          if (this.htWXXXFrames.Keys.Count > 0)
          {
            return true;
          }
        }
        else if (StringType.StrCmp(sLeft, "POPM", false) == 0)
        {
          if (this.htPOPMFrames.Keys.Count > 0)
          {
            return true;
          }
        }
        else if (StringType.StrCmp(sLeft, "APIC", false) == 0)
        {
          if (this.htAPICFrames.Keys.Count > 0)
          {
            return true;
          }
        }
        else
        {
          foreach (V2BinFrame frame in this.htBinFrames)
          {
            if (StringType.StrCmp(frame.FID, vstrFrameID, false) == 0)
            {
              return true;
            }
          }
        }
      }
      return false;
    }

    public bool FrameExistsExact(object Frame)
    {
      string sLeft = StringType.FromObject(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null));
      if (((sLeft.StartsWith("T") | sLeft.StartsWith("W")) | (StringType.StrCmp(sLeft, "IPLS", false) == 0)) && !((StringType.StrCmp(sLeft, "TXXX", false) == 0) | (StringType.StrCmp(sLeft, "WXXX", false) == 0)))
      {
        LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        return this.htSingleFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null)));
      }
      string str2 = sLeft;
      if (StringType.StrCmp(str2, "COMM", false) == 0)
      {
        LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        LateBinding.LateSet(Frame, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), null, "ToLower", new object[0], null, null)) }, null);
        LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        return this.htCOMMFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
      }
      if (StringType.StrCmp(str2, "USLT", false) == 0)
      {
        LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        LateBinding.LateSet(Frame, null, "Language", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), null, "ToLower", new object[0], null, null)) }, null);
        LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        return this.htUSLTFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
      }
      if (StringType.StrCmp(str2, "TXXX", false) == 0)
      {
        LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        return this.htTXXXFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
      }
      if (StringType.StrCmp(str2, "WXXX", false) == 0)
      {
        LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        LateBinding.LateSet(Frame, null, "Content", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Content", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        return this.htWXXXFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
      }
      if (StringType.StrCmp(str2, "POPM", false) == 0)
      {
        LateBinding.LateSet(Frame, null, "User", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "User", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
        return this.htPOPMFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
      }
      if (StringType.StrCmp(str2, "APIC", false) != 0)
      {
        return false;
      }
      LateBinding.LateSet(Frame, null, "Descriptor", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
      LateBinding.LateSet(Frame, null, "Path", new object[] { RuntimeHelpers.GetObjectValue(LateBinding.LateGet(LateBinding.LateGet(Frame, null, "Path", new object[0], null, null), null, "Trim", new object[] { Strings.Space(1) }, null, null)) }, null);
      return this.htAPICFrames.Contains(RuntimeHelpers.GetObjectValue(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null)));
    }

    public ArrayList GetAllNotSupportedFrames()
    {
      return this.htBinFrames;
    }

    public ArrayList GetAllSupportedFrames()
    {
      string str;
      ArrayList list = new ArrayList();
      using (IEnumerator enumerator7 = this.htSingleFrames.Keys.GetEnumerator())
      {
        while (enumerator7.MoveNext())
        {
          str = StringType.FromObject(enumerator7.Current);
          list.Add(RuntimeHelpers.GetObjectValue(this.htSingleFrames[str]));
        }
      }
      using (IEnumerator enumerator6 = this.htCOMMFrames.Keys.GetEnumerator())
      {
        while (enumerator6.MoveNext())
        {
          str = StringType.FromObject(enumerator6.Current);
          list.Add(RuntimeHelpers.GetObjectValue(this.htCOMMFrames[str]));
        }
      }
      using (IEnumerator enumerator5 = this.htUSLTFrames.Keys.GetEnumerator())
      {
        while (enumerator5.MoveNext())
        {
          str = StringType.FromObject(enumerator5.Current);
          list.Add(RuntimeHelpers.GetObjectValue(this.htUSLTFrames[str]));
        }
      }
      using (IEnumerator enumerator4 = this.htTXXXFrames.Keys.GetEnumerator())
      {
        while (enumerator4.MoveNext())
        {
          str = StringType.FromObject(enumerator4.Current);
          list.Add(RuntimeHelpers.GetObjectValue(this.htTXXXFrames[str]));
        }
      }
      using (IEnumerator enumerator3 = this.htWXXXFrames.Keys.GetEnumerator())
      {
        while (enumerator3.MoveNext())
        {
          str = StringType.FromObject(enumerator3.Current);
          list.Add(RuntimeHelpers.GetObjectValue(this.htWXXXFrames[str]));
        }
      }
      using (IEnumerator enumerator2 = this.htPOPMFrames.Keys.GetEnumerator())
      {
        while (enumerator2.MoveNext())
        {
          str = StringType.FromObject(enumerator2.Current);
          list.Add(RuntimeHelpers.GetObjectValue(this.htPOPMFrames[str]));
        }
      }
      using (IEnumerator enumerator = this.htAPICFrames.Keys.GetEnumerator())
      {
        while (enumerator.MoveNext())
        {
          str = StringType.FromObject(enumerator.Current);
          list.Add(RuntimeHelpers.GetObjectValue(this.htAPICFrames[str]));
        }
      }
      return list;
    }

    public object GetFrame(string vstrFrameID)
    {
      string str;
      if (((vstrFrameID.StartsWith("T") | vstrFrameID.StartsWith("W")) | (StringType.StrCmp(vstrFrameID, "IPLS", false) == 0)) && !((StringType.StrCmp(vstrFrameID, "TXXX", false) == 0) | (StringType.StrCmp(vstrFrameID, "WXXX", false) == 0)))
      {
        if (this.htSingleFrames.Contains(vstrFrameID))
        {
          return this.htSingleFrames[vstrFrameID];
        }
        return null;
      }
      string sLeft = vstrFrameID;
      if (StringType.StrCmp(sLeft, "COMM", false) == 0)
      {
        using (IEnumerator enumerator7 = this.htCOMMFrames.Keys.GetEnumerator())
        {
          while (enumerator7.MoveNext())
          {
            str = StringType.FromObject(enumerator7.Current);
            return this.htCOMMFrames[str];
          }
          goto Label_0335;
        }
      }
      if (StringType.StrCmp(sLeft, "USLT", false) == 0)
      {
        using (IEnumerator enumerator6 = this.htUSLTFrames.Keys.GetEnumerator())
        {
          while (enumerator6.MoveNext())
          {
            str = StringType.FromObject(enumerator6.Current);
            return this.htUSLTFrames[str];
          }
          goto Label_0335;
        }
      }
      if (StringType.StrCmp(sLeft, "TXXX", false) == 0)
      {
        using (IEnumerator enumerator5 = this.htTXXXFrames.Keys.GetEnumerator())
        {
          while (enumerator5.MoveNext())
          {
            str = StringType.FromObject(enumerator5.Current);
            return this.htTXXXFrames[str];
          }
          goto Label_0335;
        }
      }
      if (StringType.StrCmp(sLeft, "WXXX", false) == 0)
      {
        using (IEnumerator enumerator4 = this.htWXXXFrames.Keys.GetEnumerator())
        {
          while (enumerator4.MoveNext())
          {
            str = StringType.FromObject(enumerator4.Current);
            return this.htWXXXFrames[str];
          }
          goto Label_0335;
        }
      }
      if (StringType.StrCmp(sLeft, "POPM", false) == 0)
      {
        using (IEnumerator enumerator3 = this.htPOPMFrames.Keys.GetEnumerator())
        {
          while (enumerator3.MoveNext())
          {
            str = StringType.FromObject(enumerator3.Current);
            return this.htPOPMFrames[str];
          }
          goto Label_0335;
        }
      }
      if (StringType.StrCmp(sLeft, "APIC", false) == 0)
      {
        using (IEnumerator enumerator2 = this.htAPICFrames.Keys.GetEnumerator())
        {
          while (enumerator2.MoveNext())
          {
            str = StringType.FromObject(enumerator2.Current);
            return this.htAPICFrames[str];
          }
          goto Label_0335;
        }
      }
      foreach (V2BinFrame frame in this.htBinFrames)
      {
        if (StringType.StrCmp(frame.FID, vstrFrameID, false) == 0)
        {
          return frame;
        }
      }
      Label_0335:
      return null;
    }

    public ArrayList GetFrames(string vstrFrameID)
    {
      string str;
      ArrayList list = new ArrayList();
      if (((vstrFrameID.StartsWith("T") | vstrFrameID.StartsWith("W")) | (StringType.StrCmp(vstrFrameID, "IPLS", false) == 0)) && !((StringType.StrCmp(vstrFrameID, "TXXX", false) == 0) | (StringType.StrCmp(vstrFrameID, "WXXX", false) == 0)))
      {
        if (this.htSingleFrames.Contains(vstrFrameID))
        {
          list.Add(RuntimeHelpers.GetObjectValue(this.htSingleFrames[vstrFrameID]));
        }
        return list;
      }
      string sLeft = vstrFrameID;
      if (StringType.StrCmp(sLeft, "COMM", false) == 0)
      {
        using (IEnumerator enumerator7 = this.htCOMMFrames.Keys.GetEnumerator())
        {
          while (enumerator7.MoveNext())
          {
            str = StringType.FromObject(enumerator7.Current);
            list.Add(RuntimeHelpers.GetObjectValue(this.htCOMMFrames[str]));
          }
          return list;
        }
      }
      if (StringType.StrCmp(sLeft, "USLT", false) == 0)
      {
        using (IEnumerator enumerator6 = this.htUSLTFrames.Keys.GetEnumerator())
        {
          while (enumerator6.MoveNext())
          {
            str = StringType.FromObject(enumerator6.Current);
            list.Add(RuntimeHelpers.GetObjectValue(this.htUSLTFrames[str]));
          }
          return list;
        }
      }
      if (StringType.StrCmp(sLeft, "TXXX", false) == 0)
      {
        using (IEnumerator enumerator5 = this.htTXXXFrames.Keys.GetEnumerator())
        {
          while (enumerator5.MoveNext())
          {
            str = StringType.FromObject(enumerator5.Current);
            list.Add(RuntimeHelpers.GetObjectValue(this.htTXXXFrames[str]));
          }
          return list;
        }
      }
      if (StringType.StrCmp(sLeft, "WXXX", false) == 0)
      {
        using (IEnumerator enumerator4 = this.htWXXXFrames.Keys.GetEnumerator())
        {
          while (enumerator4.MoveNext())
          {
            str = StringType.FromObject(enumerator4.Current);
            list.Add(RuntimeHelpers.GetObjectValue(this.htWXXXFrames[str]));
          }
          return list;
        }
      }
      if (StringType.StrCmp(sLeft, "POPM", false) == 0)
      {
        using (IEnumerator enumerator3 = this.htPOPMFrames.Keys.GetEnumerator())
        {
          while (enumerator3.MoveNext())
          {
            str = StringType.FromObject(enumerator3.Current);
            list.Add(RuntimeHelpers.GetObjectValue(this.htPOPMFrames[str]));
          }
          return list;
        }
      }
      if (StringType.StrCmp(sLeft, "APIC", false) == 0)
      {
        using (IEnumerator enumerator2 = this.htAPICFrames.Keys.GetEnumerator())
        {
          while (enumerator2.MoveNext())
          {
            str = StringType.FromObject(enumerator2.Current);
            list.Add(RuntimeHelpers.GetObjectValue(this.htAPICFrames[str]));
          }
          return list;
        }
      }
      foreach (V2BinFrame frame in this.htBinFrames)
      {
        if (StringType.StrCmp(frame.FID, vstrFrameID, false) == 0)
        {
          list.Add(frame);
        }
      }
      return list;
    }

    public string GetTextWebFrameContent(string vstrFrameID)
    {
      if (this.htSingleFrames.Contains(vstrFrameID))
      {
        return StringType.FromObject(LateBinding.LateGet(this.htSingleFrames[vstrFrameID], null, "Content", new object[0], null, null));
      }
      return "";
    }

    public void ReadTAG(ref MP3 MP3)
    {
      byte[] buffer = new byte[4];
      string str = "";
      if (this.GetTAGHeader(ref MP3) && (this.TAGHeaderPresent & (this.TAGSize > 10)))
      {
        byte[] abytBuffer = MP3.BinReader.ReadBytes(this.TAGSize - this.ExtendedHeaderSize);
        if ((this.TAGVersion == 3) & this.Unsynchronisation)
        {
          abytBuffer = ID3Functions.RemoveUnsync(abytBuffer);
        }
        MemoryStream mstrTAG = new MemoryStream(abytBuffer);
        do
        {
          mstrTAG.Read(buffer, 0, 4);
          mstrTAG.Position -= 4L;
          if (buffer[0] == 0)
          {
            break;
          }
          str = StringType.FromChar(Convert.ToChar(buffer[0])) + StringType.FromChar(Convert.ToChar(buffer[1])) + StringType.FromChar(Convert.ToChar(buffer[2])) + StringType.FromChar(Convert.ToChar(buffer[3]));
          if (Array.IndexOf(Declarations.astrDefinedFrames, str) >= 0)
          {
            if ((str.StartsWith("T") && (StringType.StrCmp(str, "TXXX", false) != 0)) | (StringType.StrCmp(str, "IPLS", false) == 0))
            {
              V2TextFrame frame = new V2TextFrame();
              if (frame.GetFrame(ref MP3, ref mstrTAG) & !this.htSingleFrames.Contains(frame.FID))
              {
                this.htSingleFrames.Add(frame.FID, frame);
              }
            }
            else if (str.StartsWith("W") && (StringType.StrCmp(str, "WXXX", false) != 0))
            {
              V2WebFrame frame2 = new V2WebFrame();
              if (frame2.GetFrame(ref MP3, ref mstrTAG) & !this.htSingleFrames.Contains(frame2.FID))
              {
                this.htSingleFrames.Add(frame2.FID, frame2);
              }
            }
            else
            {
              string sLeft = str;
              if (StringType.StrCmp(sLeft, "COMM", false) == 0)
              {
                V2LDCFrame frame3 = new V2LDCFrame();
                if (frame3.GetFrame(ref MP3, ref mstrTAG) & !this.htCOMMFrames.Contains((frame3.Language + frame3.Descriptor).ToLower()))
                {
                  this.htCOMMFrames.Add((frame3.Language + frame3.Descriptor).ToLower(), frame3);
                }
              }
              else if (StringType.StrCmp(sLeft, "USLT", false) == 0)
              {
                V2LDCFrame frame4 = new V2LDCFrame();
                if (frame4.GetFrame(ref MP3, ref mstrTAG) & !this.htUSLTFrames.Contains((frame4.Language + frame4.Descriptor).ToLower()))
                {
                  this.htUSLTFrames.Add((frame4.Language + frame4.Descriptor).ToLower(), frame4);
                }
              }
              else if (StringType.StrCmp(sLeft, "TXXX", false) == 0)
              {
                V2TXXXFrame frame5 = new V2TXXXFrame();
                if (frame5.GetFrame(ref MP3, ref mstrTAG) & !this.htTXXXFrames.Contains("-" + frame5.Descriptor.ToLower()))
                {
                  this.htTXXXFrames.Add("-" + frame5.Descriptor.ToLower(), frame5);
                }
              }
              else if (StringType.StrCmp(sLeft, "WXXX", false) == 0)
              {
                V2WXXXFrame frame6 = new V2WXXXFrame();
                if (frame6.GetFrame(ref MP3, ref mstrTAG) & !this.htWXXXFrames.Contains("-" + frame6.Descriptor.ToLower()))
                {
                  this.htWXXXFrames.Add("-" + frame6.Descriptor.ToLower(), frame6);
                }
              }
              else if (StringType.StrCmp(sLeft, "POPM", false) == 0)
              {
                V2POPMFrame frame7 = new V2POPMFrame();
                if (frame7.GetFrame(ref MP3, ref mstrTAG) & !this.htPOPMFrames.Contains("-" + frame7.User.ToLower()))
                {
                  this.htPOPMFrames.Add("-" + frame7.User.ToLower(), frame7);
                }
              }
              else if (StringType.StrCmp(sLeft, "APIC", false) == 0)
              {
                V2APICFrame frame8 = new V2APICFrame();
                if (frame8.GetFrame(ref MP3, ref mstrTAG) & !this.htAPICFrames.Contains((frame8.PicType.ToString().PadLeft(2, '0') + frame8.Descriptor).ToLower()))
                {
                  this.htAPICFrames.Add((frame8.PicType.ToString().PadLeft(2, '0') + frame8.Descriptor).ToLower(), frame8);
                }
              }
              else
              {
                V2BinFrame frame9 = new V2BinFrame();
                if (frame9.GetFrame(ref MP3, ref mstrTAG))
                {
                  this.htBinFrames.Add(frame9);
                }
                else if (frame9.FSize != 0L)
                {
                  break;
                }
              }
            }
          }
          else
          {
            V2BinFrame frame10 = new V2BinFrame();
            if (!frame10.GetFrame(ref MP3, ref mstrTAG))
            {
              break;
            }
            this.htBinFrames.Add(frame10);
          }
        }
        while ((mstrTAG.Length - mstrTAG.Position) >= 11L);
      }
    }

    public void RemoveAllNotSupportedFrames()
    {
      this.htBinFrames.Clear();
      this.vbooChanged = true;
    }

    public void RemoveAllSupportedFrames()
    {
      this.htSingleFrames.Clear();
      this.htCOMMFrames.Clear();
      this.htUSLTFrames.Clear();
      this.htTXXXFrames.Clear();
      this.htWXXXFrames.Clear();
      this.htPOPMFrames.Clear();
      this.htAPICFrames.Clear();
      this.vbooChanged = true;
    }

    public void RemoveFrame(string vstrFrameID)
    {
      string str3;
      string str4;
      string str5;
      string str6;
      string str7;
      if (((vstrFrameID.StartsWith("T") | vstrFrameID.StartsWith("W")) | (StringType.StrCmp(vstrFrameID, "IPLS", false) == 0)) && !((StringType.StrCmp(vstrFrameID, "TXXX", false) == 0) | (StringType.StrCmp(vstrFrameID, "WXXX", false) == 0)))
      {
        if (this.htSingleFrames.Contains(vstrFrameID))
        {
          this.htSingleFrames.Remove(vstrFrameID);
          this.vbooChanged = true;
        }
        return;
      }
      string sLeft = vstrFrameID;
      if (StringType.StrCmp(sLeft, "COMM", false) != 0)
      {
        if (StringType.StrCmp(sLeft, "USLT", false) != 0)
        {
          if (StringType.StrCmp(sLeft, "TXXX", false) != 0)
          {
            if (StringType.StrCmp(sLeft, "WXXX", false) != 0)
            {
              if (StringType.StrCmp(sLeft, "POPM", false) != 0)
              {
                if (StringType.StrCmp(sLeft, "APIC", false) != 0)
                {
                  foreach (V2BinFrame frame in this.htBinFrames)
                  {
                    if (StringType.StrCmp(frame.FID, vstrFrameID, false) == 0)
                    {
                      this.htBinFrames.Remove(frame);
                      this.vbooChanged = true;
                      break;
                    }
                  }
                  return;
                }
                str7 = "";
                using (IEnumerator enumerator2 = this.htAPICFrames.Keys.GetEnumerator())
                {
                  while (enumerator2.MoveNext())
                  {
                    str7 = StringType.FromObject(enumerator2.Current);
                    this.vbooChanged = true;
                    goto Label_0381;
                  }
                }
                goto Label_0381;
              }
              str6 = "";
              using (IEnumerator enumerator3 = this.htPOPMFrames.Keys.GetEnumerator())
              {
                while (enumerator3.MoveNext())
                {
                  str6 = StringType.FromObject(enumerator3.Current);
                  this.vbooChanged = true;
                  goto Label_02F7;
                }
              }
              goto Label_02F7;
            }
            str5 = "";
            using (IEnumerator enumerator4 = this.htWXXXFrames.Keys.GetEnumerator())
            {
              while (enumerator4.MoveNext())
              {
                str5 = StringType.FromObject(enumerator4.Current);
                this.vbooChanged = true;
                goto Label_026D;
              }
            }
            goto Label_026D;
          }
          str4 = "";
          using (IEnumerator enumerator5 = this.htTXXXFrames.Keys.GetEnumerator())
          {
            while (enumerator5.MoveNext())
            {
              str4 = StringType.FromObject(enumerator5.Current);
              this.vbooChanged = true;
              goto Label_01E5;
            }
          }
          goto Label_01E5;
        }
        str3 = "";
        using (IEnumerator enumerator6 = this.htUSLTFrames.Keys.GetEnumerator())
        {
          while (enumerator6.MoveNext())
          {
            str3 = StringType.FromObject(enumerator6.Current);
            this.vbooChanged = true;
            goto Label_015F;
          }
        }
        goto Label_015F;
      }
      string str2 = "";
      using (IEnumerator enumerator7 = this.htCOMMFrames.Keys.GetEnumerator())
      {
        while (enumerator7.MoveNext())
        {
          str2 = StringType.FromObject(enumerator7.Current);
          this.vbooChanged = true;
          goto Label_00D9;
        }
      }
      Label_00D9:
      if (StringType.StrCmp(str2, "", false) != 0)
      {
        this.htCOMMFrames.Remove(str2);
      }
      return;
      Label_015F:
      if (StringType.StrCmp(str3, "", false) != 0)
      {
        this.htUSLTFrames.Remove(str3);
      }
      return;
      Label_01E5:
      if (StringType.StrCmp(str4, "", false) != 0)
      {
        this.htTXXXFrames.Remove(str4);
      }
      return;
      Label_026D:
      if (StringType.StrCmp(str5, "", false) != 0)
      {
        this.htWXXXFrames.Remove(str5);
      }
      return;
      Label_02F7:
      if (StringType.StrCmp(str6, "", false) != 0)
      {
        this.htPOPMFrames.Remove(str6);
      }
      return;
      Label_0381:
      if (StringType.StrCmp(str7, "", false) != 0)
      {
        this.htAPICFrames.Remove(str7);
      }
    }

    public void RemoveFrameExact(object Frame)
    {
      string sLeft = StringType.FromObject(LateBinding.LateGet(Frame, null, "FID", new object[0], null, null));
      if (((sLeft.StartsWith("T") | sLeft.StartsWith("W")) | (StringType.StrCmp(sLeft, "IPLS", false) == 0)) && !((StringType.StrCmp(sLeft, "TXXX", false) == 0) | (StringType.StrCmp(sLeft, "WXXX", false) == 0)))
      {
        if (this.htSingleFrames.Contains(sLeft))
        {
          this.htSingleFrames.Remove(sLeft);
          this.vbooChanged = true;
        }
      }
      else
      {
        string str8 = sLeft;
        if (StringType.StrCmp(str8, "COMM", false) == 0)
        {
          string key = StringType.FromObject(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null));
          if (this.htCOMMFrames.Contains(key))
          {
            this.htCOMMFrames.Remove(key);
          }
        }
        else if (StringType.StrCmp(str8, "USLT", false) == 0)
        {
          string str3 = StringType.FromObject(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "Language", new object[0], null, null), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null));
          if (this.htUSLTFrames.Contains(str3))
          {
            this.htUSLTFrames.Remove(str3);
          }
        }
        else if (StringType.StrCmp(str8, "TXXX", false) == 0)
        {
          string str4 = StringType.FromObject(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null));
          if (this.htTXXXFrames.Contains(str4))
          {
            this.htTXXXFrames.Remove(str4);
          }
        }
        else if (StringType.StrCmp(str8, "WXXX", false) == 0)
        {
          string str5 = StringType.FromObject(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null));
          if (this.htWXXXFrames.Contains(str5))
          {
            this.htWXXXFrames.Remove(str5);
          }
        }
        else if (StringType.StrCmp(str8, "POPM", false) == 0)
        {
          string str6 = StringType.FromObject(LateBinding.LateGet(ObjectType.StrCatObj("-", LateBinding.LateGet(Frame, null, "User", new object[0], null, null)), null, "ToLower", new object[0], null, null));
          if (this.htPOPMFrames.Contains(str6))
          {
            this.htPOPMFrames.Remove(str6);
          }
        }
        else if (StringType.StrCmp(str8, "APIC", false) == 0)
        {
          string str7 = StringType.FromObject(LateBinding.LateGet(ObjectType.StrCatObj(LateBinding.LateGet(Frame, null, "PicType", new object[0], null, null).ToString().PadLeft(2, '0'), LateBinding.LateGet(Frame, null, "Descriptor", new object[0], null, null)), null, "ToLower", new object[0], null, null));
          if (this.htAPICFrames.Contains(str7))
          {
            this.htAPICFrames.Remove(str7);
          }
        }
        else
        {
          try
          {
            this.htBinFrames.Remove(RuntimeHelpers.GetObjectValue(Frame));
            this.vbooChanged = true;
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }
        }
      }
    }

    public void RemoveFrames(string vstrFrameID)
    {
      if (((vstrFrameID.StartsWith("T") | vstrFrameID.StartsWith("W")) | (StringType.StrCmp(vstrFrameID, "IPLS", false) == 0)) && !((StringType.StrCmp(vstrFrameID, "TXXX", false) == 0) | (StringType.StrCmp(vstrFrameID, "WXXX", false) == 0)))
      {
        if (this.htSingleFrames.Contains(vstrFrameID))
        {
          this.htSingleFrames.Remove(vstrFrameID);
          this.vbooChanged = true;
        }
      }
      else
      {
        string sLeft = vstrFrameID;
        if (StringType.StrCmp(sLeft, "COMM", false) == 0)
        {
          if (this.htCOMMFrames.Keys.Count > 0)
          {
            this.vbooChanged = true;
          }
          this.htCOMMFrames.Clear();
        }
        else if (StringType.StrCmp(sLeft, "USLT", false) == 0)
        {
          if (this.htUSLTFrames.Keys.Count > 0)
          {
            this.vbooChanged = true;
          }
          this.htUSLTFrames.Clear();
        }
        else if (StringType.StrCmp(sLeft, "TXXX", false) == 0)
        {
          if (this.htTXXXFrames.Keys.Count > 0)
          {
            this.vbooChanged = true;
          }
          this.htTXXXFrames.Clear();
        }
        else if (StringType.StrCmp(sLeft, "WXXX", false) == 0)
        {
          if (this.htWXXXFrames.Keys.Count > 0)
          {
            this.vbooChanged = true;
          }
          this.htWXXXFrames.Clear();
        }
        else if (StringType.StrCmp(sLeft, "POPM", false) == 0)
        {
          if (this.htPOPMFrames.Keys.Count > 0)
          {
            this.vbooChanged = true;
          }
          this.htPOPMFrames.Clear();
        }
        else if (StringType.StrCmp(sLeft, "APIC", false) == 0)
        {
          if (this.htAPICFrames.Keys.Count > 0)
          {
            this.vbooChanged = true;
          }
          this.htAPICFrames.Clear();
        }
        else
        {
          ArrayList list = new ArrayList();
          foreach (V2BinFrame frame in this.htBinFrames)
          {
            if (StringType.StrCmp(frame.FID, vstrFrameID, false) == 0)
            {
              list.Add(frame);
              this.vbooChanged = true;
            }
          }
          foreach (V2BinFrame frame in list)
          {
            this.htBinFrames.Remove(frame);
          }
        }
      }
    }

    public int WriteTAG(ref MP3 MP3)
    {
      V2TAGHeader header = new V2TAGHeader();
      int returnedPadAdded = 0;
      int vintPadSize = 0;
      int num3 = 0;
      bool flag = false;
      string path = "";
      if (MP3.OpenFileStreamRW())
      {
        MP3.OpenBinaryReader();
        if (header.GetTAGHeader(ref MP3))
        {
          byte[] buffer;
          byte[] buffer2;
          byte[] buffer3;
          byte[] buffer4;
          MP3.CloseBinaryReader();
          if (header.TAGHeaderPresent)
          {
            vintPadSize = IntegerType.FromObject(Interaction.IIf(header.FooterPresent, header.TAGSize + 20, header.TAGSize + 10));
            num3 = IntegerType.FromObject(ObjectType.SubObj(ObjectType.SubObj(vintPadSize - 10, Interaction.IIf(header.FooterPresent == this.FooterPresent, 0, 10)), this.ExtendedHeaderSize));
            if (!this.TAGHeaderPresent)
            {
              return vintPadSize;
            }
            buffer3 = this.CreateTAG(MP3, num3, ref returnedPadAdded);
            buffer2 = this.CreateTAGHeader(MP3, buffer3, returnedPadAdded);
            if (!MP3.V2TAG.FooterPresent)
            {
              buffer4 = new byte[((buffer3.Length + buffer2.Length) - 1) + 1];
              Array.Copy(buffer2, 0, buffer4, 0, buffer2.Length);
              Array.Copy(buffer3, 0, buffer4, buffer2.Length, buffer3.Length);
            }
            else
            {
              buffer4 = new byte[((buffer3.Length + buffer2.Length) + 9) + 1];
              Array.Copy(buffer2, buffer, 10);
              Array.Reverse(buffer);
              Array.Copy(buffer2, 0, buffer4, 0, buffer2.Length);
              Array.Copy(buffer3, 0, buffer4, buffer2.Length, buffer3.Length);
              Array.Copy(buffer, 0, buffer4, buffer2.Length + buffer3.Length, buffer.Length);
            }
            if (buffer4.Length == vintPadSize)
            {
              if (!MP3.OpenFileStreamRW())
              {
                return -1;
              }
              MP3.OpenBinaryWriter();
              MP3.WriteData(0, SeekOrigin.Begin, buffer4);
              MP3.CloseBinaryWriter();
              flag = false;
            }
            else
            {
              flag = true;
            }
          }
          else if (this.TAGHeaderPresent)
          {
            vintPadSize = 0;
            buffer3 = this.CreateTAG(MP3, vintPadSize, ref returnedPadAdded);
            buffer2 = this.CreateTAGHeader(MP3, buffer3, returnedPadAdded);
            if (!MP3.V2TAG.FooterPresent)
            {
              buffer4 = new byte[((buffer3.Length + buffer2.Length) - 1) + 1];
              Array.Copy(buffer2, 0, buffer4, 0, buffer2.Length);
              Array.Copy(buffer3, 0, buffer4, buffer2.Length, buffer3.Length);
            }
            else
            {
              buffer4 = new byte[((buffer3.Length + buffer2.Length) + 9) + 1];
              Array.Copy(buffer2, buffer, 10);
              Array.Reverse(buffer);
              Array.Copy(buffer2, 0, buffer4, 0, buffer2.Length);
              Array.Copy(buffer3, 0, buffer4, buffer2.Length, buffer3.Length);
              Array.Copy(buffer, 0, buffer4, buffer2.Length + buffer3.Length, buffer.Length);
            }
            flag = true;
          }
          if (flag)
          {
            BinaryWriter writer;
            FileStream stream;
            try
            {
              byte[] buffer5;
              path = MP3.FI.FullName + ".ID3temp";
              stream = new FileStream(path, FileMode.Create, FileAccess.ReadWrite, FileShare.None);
              writer = new BinaryWriter(stream);
              writer.BaseStream.Seek(0L, SeekOrigin.Begin);
              writer.Write(buffer4);
              writer.Flush();
              if (!MP3.OpenFileStreamRW())
              {
                return -1;
              }
              MP3.OpenBinaryReader();
              int vintNumberOfBytes = ((int)MP3.FI.Length) - vintPadSize;
              if (vintNumberOfBytes > 0x800000)
              {
                int num6 = vintNumberOfBytes / 0x800000;
                int num9 = num6 - 1;
                for (int i = 0; i <= num9; i++)
                {
                  buffer5 = MP3.ReadData(vintPadSize + (i * 0x800000), SeekOrigin.Begin, 0x800000);
                  writer.Write(buffer5);
                  writer.Flush();
                }
                buffer5 = MP3.ReadData(vintPadSize + (num6 * 0x800000), SeekOrigin.Begin, ((int)MP3.FI.Length) - (vintPadSize + (num6 * 0x800000)));
                writer.Write(buffer5);
                writer.Flush();
              }
              else
              {
                buffer5 = MP3.ReadData(vintPadSize, SeekOrigin.Begin, vintNumberOfBytes);
                writer.Write(buffer5);
                writer.Flush();
              }
              MP3.CloseBinaryReader();
              MP3.CloseFileStream();
              writer.Close();
              stream.Close();
              File.Delete(MP3.FI.FullName);
              File.Move(path, MP3.FI.FullName);
              File.Delete(path);
              MP3.FI.Refresh();
            }
            catch (Exception exception1)
            {
              ProjectData.SetProjectError(exception1);
              MP3.CloseBinaryReader();
              MP3.CloseFileStream();
              writer.Close();
              stream.Close();
              ProjectData.ClearProjectError();
              return -1;
            }
          }
          this.vbooChanged = false;
          if (this.htAPICFrames.Keys.Count > 0)
          {
            MP3.RemoveV1TAG();
            MP3.RemoveV2TAG();
            MP3.ExploreMP3();
          }
          return 0;
        }
        MP3.CloseBinaryReader();
      }
      return -1;
    }

    public bool Changed
    {
      get
      {
        return this.vbooChanged;
      }
      set
      {
        this.vbooChanged = value;
      }
    }
  }
}