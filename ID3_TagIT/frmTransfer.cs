using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public partial class frmTransfer : Form
  {
    #region Class logic

    private void AddToolTips()
    {
      string vstrName = "frmTransfer";
      Control objControl = this.opt12;
      this.opt12 = (RadioButton)objControl;
      this.ToolTip.SetToolTip(this.opt12, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.opt21;
      this.opt21 = (RadioButton)objControl;
      this.ToolTip.SetToolTip(this.opt21, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.optConvert34;
      this.optConvert34 = (RadioButton)objControl;
      this.ToolTip.SetToolTip(this.optConvert34, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.optConvert43;
      this.optConvert43 = (RadioButton)objControl;
      this.ToolTip.SetToolTip(this.optConvert43, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.chkExists;
      this.chkExists = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.chkExists, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.txtCommentD;
      this.txtCommentD = (TextBox)objControl;
      this.ToolTip.SetToolTip(this.txtCommentD, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.chkYear;
      this.chkYear = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.chkYear, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.chkGenre;
      this.chkGenre = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.chkGenre, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.chkTrack;
      this.chkTrack = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.chkTrack, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.chkComment;
      this.chkComment = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.chkComment, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.chkAlbum;
      this.chkAlbum = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.chkAlbum, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.chkTitle;
      this.chkTitle = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.chkTitle, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));

      vstrName = "frmTransfer";
      objControl = this.chkArtist;
      this.chkArtist = (CheckBox)objControl;
      this.ToolTip.SetToolTip(this.chkArtist, Declarations.objResources.GetToolTip(ref vstrName, ref objControl));
    }

    #endregion

    #region Events

    private void btnDeSelectAll_Click(object sender, EventArgs e)
    {
      this.chkArtist.Checked = false;
      this.chkTitle.Checked = false;
      this.chkAlbum.Checked = false;
      this.chkGenre.Checked = false;
      this.chkTrack.Checked = false;
      this.chkComment.Checked = false;
      this.chkYear.Checked = false;
    }

    private void btnOK_Click(object sender, EventArgs e)
    {
      var list = new ArrayList();
      frmProgress.Callback callback;

      Form form = this;
      Id3TagIT_Main.SaveFormSettings(ref form);

      if (this.optConvert34.Checked)
        Declarations.objSettings.TransferMethod = 3;

      if (this.optConvert43.Checked)
        Declarations.objSettings.TransferMethod = 4;

      if (this.opt12.Checked)
      {
        Declarations.objSettings.TransferMethod = 1;
        Declarations.objSettings.TransferCommentD = this.txtCommentD.Text;
        Declarations.objSettings.TransferArtist12 = this.chkArtist.Checked;
        Declarations.objSettings.TransferTitle12 = this.chkTitle.Checked;
        Declarations.objSettings.TransferAlbum12 = this.chkAlbum.Checked;
        Declarations.objSettings.TransferGenre12 = this.chkGenre.Checked;
        Declarations.objSettings.TransferTrack12 = this.chkTrack.Checked;
        Declarations.objSettings.TransferComment12 = this.chkComment.Checked;
        Declarations.objSettings.TransferYear12 = this.chkYear.Checked;
        Declarations.objSettings.TransferKeep12 = this.chkExists.Checked;
      }

      if (this.opt21.Checked)
      {
        Declarations.objSettings.TransferMethod = 2;
        Declarations.objSettings.TransferArtist21 = this.chkArtist.Checked;
        Declarations.objSettings.TransferTitle21 = this.chkTitle.Checked;
        Declarations.objSettings.TransferAlbum21 = this.chkAlbum.Checked;
        Declarations.objSettings.TransferGenre21 = this.chkGenre.Checked;
        Declarations.objSettings.TransferTrack21 = this.chkTrack.Checked;
        Declarations.objSettings.TransferComment21 = this.chkComment.Checked;
        Declarations.objSettings.TransferYear21 = this.chkYear.Checked;
        Declarations.objSettings.TransferKeep21 = this.chkExists.Checked;
      }

      this.MainForm.MP3View.BeginUpdate();

      if (this.opt12.Checked)
      {
        form = this;
        callback = new frmProgress.Callback(this.CB12);
        frmProgress progress = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref form, ref callback);
        progress.SetStateTransfer();
        progress.List = list;
        progress.ShowDialog(this);
      }

      if (this.opt21.Checked)
      {
        form = this;
        callback = new frmProgress.Callback(this.CB21);
        frmProgress progress2 = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref form, ref callback);
        progress2.SetStateTransfer();
        progress2.List = list;
        progress2.ShowDialog(this);
      }

      if (this.optConvert34.Checked)
      {
        form = this;
        callback = new frmProgress.Callback(this.CB34);
        frmProgress progress3 = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref form, ref callback);
        progress3.SetStateTransfer();
        progress3.List = list;
        progress3.ShowDialog(this);
      }

      if (this.optConvert43.Checked)
      {
        form = this;
        callback = new frmProgress.Callback(this.CB43);
        frmProgress progress4 = new frmProgress(0, this.MainForm.MP3View.SelectedItems.Count, 1, ref form, ref callback);
        progress4.SetStateTransfer();
        progress4.List = list;
        progress4.ShowDialog(this);
      }

      this.MainForm.MP3View.EndUpdate();

      if (list.Count > 0)
      {
        Declarations.UNDOList.Add(list);
        this.MainForm.UnDoEnable(true, true);
      }

      this.Close();
    }

    private void btnSelectAll_Click(object sender, EventArgs e)
    {
      this.chkArtist.Checked = true;
      this.chkTitle.Checked = true;
      this.chkAlbum.Checked = true;
      this.chkGenre.Checked = true;
      this.chkTrack.Checked = true;
      this.chkComment.Checked = true;
      this.chkYear.Checked = true;
    }

    private void CB12(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        MP3 tag = (MP3)item.Tag;
        frmProg.lblInfo.Text = tag.CurrentFullName.Replace("&", "&&");

        if ((tag.V2TAG.TAGVersion == 2) || !tag.V1TAG.TAGPresent)
          goto Label_05DD;

        Declarations.UnDoReDo @do =
          new Declarations.UnDoReDo((MP3)item.Tag,
                                    (V1TAG)LateBinding.LateGet(
                                      LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null),
                                      null, "Clone", new object[0], null, null),
                                    (V2TAG)LateBinding.LateGet(
                                      LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null),
                                      null, "Clone", new object[0], null, null),
                                    StringType.FromObject(
                                      LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)),
                                    BooleanType.FromObject(
                                      LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);

        if (this.chkArtist.Checked && (!this.chkExists.Checked || !tag.V2TAG.FrameExists("TPE1")))
        {
          V2TextFrame frame = ID3Functions.CreateTextFrame("TPE1", tag.V1TAG.Artist);

          if (StringType.StrCmp(tag.V1TAG.Artist, "", false) == 0)
            frame.Remove = true;

          tag.V2TAG.AddFrame(frame);
        }

        if (this.chkTitle.Checked && (!this.chkExists.Checked || !tag.V2TAG.FrameExists("TIT2")))
        {
          V2TextFrame frame2 = ID3Functions.CreateTextFrame("TIT2", tag.V1TAG.Title);
          if (StringType.StrCmp(tag.V1TAG.Title, "", false) == 0)
            frame2.Remove = true;
          tag.V2TAG.AddFrame(frame2);
        }

        if (this.chkAlbum.Checked && (!this.chkExists.Checked || !tag.V2TAG.FrameExists("TALB")))
        {
          V2TextFrame frame3 = ID3Functions.CreateTextFrame("TALB", tag.V1TAG.Album);
          if (StringType.StrCmp(tag.V1TAG.Album, "", false) == 0)
            frame3.Remove = true;
          tag.V2TAG.AddFrame(frame3);
        }

        if (this.chkTrack.Checked && (!this.chkExists.Checked || !tag.V2TAG.FrameExists("TRCK")))
        {
          V2TextFrame frame4 =
            ID3Functions.CreateTextFrame("TRCK",
                                         tag.V1TAG.Tracknumber.ToString().PadLeft(Declarations.objSettings.TracknumberDigitsTAG, '0'));
          if (tag.V1TAG.Tracknumber == 0)
            frame4.Remove = true;
          tag.V2TAG.AddFrame(frame4);
        }

        if (this.chkComment.Checked)
        {
          V2LDCFrame frame5 = new V2LDCFrame
          {
            FID = "COMM",
            Language = Declarations.astrLanLookup[Declarations.objSettings.V2Language].Substring(0, 3),
            Descriptor = this.txtCommentD.Text,
            Content = tag.V1TAG.Comment
          };

          if (StringType.StrCmp(tag.V1TAG.Comment, "", false) == 0)
            frame5.Remove = true;

          if (!this.chkExists.Checked || !tag.V2TAG.FrameExistsExact(frame5))
            tag.V2TAG.AddFrame(frame5);
        }

        if (this.chkGenre.Checked && (!this.chkExists.Checked || !tag.V2TAG.FrameExists("TCON")))
        {
          string genreText = tag.V1TAG.GenreText;

          foreach (DataRow row in Declarations.objSettings.Genres.Rows)
            if (ObjectType.ObjTst(row["V1V2"], tag.V1TAG.GenreByte, false) == 0)
            {
              genreText = row["Name"].ToString();
              break;
            }

          V2TextFrame frame6 = ID3Functions.CreateTextFrame("TCON", genreText);

          if (tag.V1TAG.GenreByte > 0x93)
            frame6.Remove = true;

          tag.V2TAG.AddFrame(frame6);
        }

        if (!this.chkYear.Checked || (this.chkExists.Checked && (tag.V2TAG.FrameExists("TYER") | tag.V2TAG.FrameExists("TDRC"))))
          goto Label_05DD;

        V2TextFrame frame7 = new V2TextFrame();

        switch (tag.V2TAG.TAGVersion)
        {
          case 0:
            if (Declarations.objSettings.NewV2Version != 3)
              break;
            frame7 = ID3Functions.CreateTextFrame("TYER", tag.V1TAG.Year.ToString());
            goto Label_05B6;

          case 3:
            frame7 = ID3Functions.CreateTextFrame("TYER", tag.V1TAG.Year.ToString());
            goto Label_05B6;

          case 4:
            frame7 = ID3Functions.CreateTextFrame("TDRC", tag.V1TAG.Year.ToString());
            goto Label_05B6;

          default:
            goto Label_05B6;
        }

        frame7 = ID3Functions.CreateTextFrame("TDRC", tag.V1TAG.Year.ToString());

Label_05B6:
        if (tag.V1TAG.Year < 0x6d9)
          frame7.Remove = true;

        tag.V2TAG.AddFrame(frame7);

Label_05DD:
        if (tag.V2TAG.Changed & !tag.V2TAG.TAGHeaderPresent)
          tag.V2TAG.TAGHeaderPresent = true;

        if (tag.V2TAG.Changed)
          tag.V2TAG.TAGHeaderPresent = true;

        if (tag.V2TAG.Changed)
          tag.Changed = true;

        this.MainForm.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void CB21(ref frmProgress frmProg)
    {
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        bool flag = false;
        MP3 tag = (MP3)item.Tag;
        frmProg.lblInfo.Text = tag.CurrentFullName.Replace("&", "&&");

        if ((tag.V2TAG.TAGVersion != 2) && tag.V2TAG.TAGHeaderPresent)
        {
          Declarations.UnDoReDo @do =
            new Declarations.UnDoReDo((MP3)item.Tag,
                                      (V1TAG)LateBinding.LateGet(
                                        LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null),
                                        null, "Clone", new object[0], null, null),
                                      (V2TAG)LateBinding.LateGet(
                                        LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null),
                                        null, "Clone", new object[0], null, null),
                                      StringType.FromObject(
                                        LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)),
                                      BooleanType.FromObject(
                                        LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
          frmProg.List.Add(@do);

          if (this.chkArtist.Checked && (!this.chkExists.Checked || (StringType.StrCmp(tag.V1TAG.Artist, "", false) == 0)))
          {
            if (tag.V2TAG.FrameExists("TPE1"))
            {
              if (ObjectType.ObjTst(tag.V1TAG.Artist,
                                    LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null),
                                    false) != 0)
              {
                tag.V1TAG.Artist = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TPE1"), null, "Content", new object[0], null, null));
                flag = true;
              }
            }
            else
            {
              if (StringType.StrCmp(tag.V1TAG.Artist, "", false) != 0)
                flag = true;

              tag.V1TAG.Artist = "";
            }
          }

          if (this.chkTitle.Checked && (!this.chkExists.Checked || (StringType.StrCmp(tag.V1TAG.Title, "", false) == 0)))
          {
            if (tag.V2TAG.FrameExists("TIT2"))
            {
              if (ObjectType.ObjTst(tag.V1TAG.Title,
                                    LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null),
                                    false) != 0)
              {
                tag.V1TAG.Title = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TIT2"), null, "Content", new object[0], null, null));
                flag = true;
              }
            }
            else
            {
              if (StringType.StrCmp(tag.V1TAG.Title, "", false) != 0)
                flag = true;

              tag.V1TAG.Title = "";
            }
          }

          if (this.chkAlbum.Checked && (!this.chkExists.Checked || (StringType.StrCmp(tag.V1TAG.Album, "", false) == 0)))
          {
            if (tag.V2TAG.FrameExists("TALB"))
            {
              if (ObjectType.ObjTst(tag.V1TAG.Album,
                                    LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null),
                                    false) != 0)
              {
                tag.V1TAG.Album = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TALB"), null, "Content", new object[0], null, null));
                flag = true;
              }
            }
            else
            {
              if (StringType.StrCmp(tag.V1TAG.Album, "", false) != 0)
                flag = true;

              tag.V1TAG.Album = "";
            }
          }

          if (this.chkTrack.Checked && (!this.chkExists.Checked || (tag.V1TAG.Tracknumber == 0)))
          {
            if (tag.V2TAG.FrameExists("TRCK"))
            {
              if (ObjectType.ObjTst(LateBinding.LateGet(
                                      LateBinding.LateGet(
                                        tag.V2TAG.GetFrame("TRCK"),
                                        null, "Content", new object[0], null, null),
                                    null, "IndexOf", new object[] { "/" }, null, null),
                                    0, false) < 0)
              {
                if ((Conversion.Val(
                       RuntimeHelpers.GetObjectValue(
                         LateBinding.LateGet(
                           tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null))) <= 255.0) &&
                    (tag.V1TAG.Tracknumber !=
                      Convert.ToByte(
                        Conversion.Val(
                          RuntimeHelpers.GetObjectValue(
                            LateBinding.LateGet(
                              tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null))))))
                {
                  tag.V1TAG.Tracknumber =
                    Convert.ToByte(
                      Conversion.Val(
                        RuntimeHelpers.GetObjectValue(
                          LateBinding.LateGet(
                            tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null))));
                  flag = true;
                }
              }
              else
              {
                object[] objArray13 = new object[2];
                objArray13[0] = 0;
                object o = tag.V2TAG.GetFrame("TRCK");
                object[] args = new object[0];
                string[] paramnames = null;
                object[] objArray14 = new object[1];
                string str4 = "/";
                objArray14[0] = str4;
                objArray13[1] =
                  RuntimeHelpers.GetObjectValue(
                    LateBinding.LateGet(
                      LateBinding.LateGet(o, null, "Content", args, paramnames, null),
                      null, "IndexOf", objArray14, null, null));
                object[] objArray12 = objArray13;
                bool[] copyBack = new bool[] { false, true };

                if (copyBack[1])
                  LateBinding.LateSetComplex(
                    LateBinding.LateGet(o, null, "Content", args, paramnames, null),
                    null, "IndexOf", new object[] { str4, RuntimeHelpers.GetObjectValue(objArray12[1]) }, null, true, true);

                if (Conversion.Val(
                  RuntimeHelpers.GetObjectValue(
                    LateBinding.LateGet(
                      LateBinding.LateGet(tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null),
                      null, "Substring", objArray12, null, copyBack))) <= 255.0)
                {
                  object[] objArray8 = new object[2];
                  objArray8[0] = 0;
                  object obj3 = tag.V2TAG.GetFrame("TRCK");
                  object[] objArray10 = new object[0];
                  string[] strArray2 = null;
                  object[] objArray9 = new object[1];
                  string str3 = "/";
                  objArray9[0] = str3;
                  objArray8[1] =
                    RuntimeHelpers.GetObjectValue(
                      LateBinding.LateGet(
                        LateBinding.LateGet(obj3, null, "Content", objArray10, strArray2, null),
                        null, "IndexOf", objArray9, null, null));
                  object[] objArray7 = objArray8;
                  bool[] flagArray2 = new bool[] { false, true };

                  if (flagArray2[1])
                    LateBinding.LateSetComplex(
                      LateBinding.LateGet(obj3, null, "Content", objArray10, strArray2, null),
                      null, "IndexOf", new object[] { str3, RuntimeHelpers.GetObjectValue(objArray7[1]) }, null, true, true);

                  if (tag.V1TAG.Tracknumber !=
                    Convert.ToByte(
                      Conversion.Val(
                        RuntimeHelpers.GetObjectValue(
                          LateBinding.LateGet(
                            LateBinding.LateGet(tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null),
                            null, "Substring", objArray7, null, flagArray2)))))
                  {
                    object[] objArray3 = new object[2];
                    objArray3[0] = 0;
                    object obj2 = tag.V2TAG.GetFrame("TRCK");
                    object[] objArray5 = new object[0];
                    string[] strArray = null;
                    object[] objArray4 = new object[1];
                    string str2 = "/";
                    objArray4[0] = str2;
                    objArray3[1] =
                      RuntimeHelpers.GetObjectValue(
                        LateBinding.LateGet(
                          LateBinding.LateGet(obj2, null, "Content", objArray5, strArray, null),
                          null, "IndexOf", objArray4, null, null));
                    object[] objArray2 = objArray3;
                    bool[] flagArray = new bool[] { false, true };

                    if (flagArray[1])
                      LateBinding.LateSetComplex(
                        LateBinding.LateGet(obj2, null, "Content", objArray5, strArray, null),
                        null, "IndexOf", new object[] { str2, RuntimeHelpers.GetObjectValue(objArray2[1]) }, null, true, true);

                    tag.V1TAG.Tracknumber =
                      Convert.ToByte(
                        Conversion.Val(
                          RuntimeHelpers.GetObjectValue(
                            LateBinding.LateGet(
                              LateBinding.LateGet(tag.V2TAG.GetFrame("TRCK"), null, "Content", new object[0], null, null),
                              null, "Substring", objArray2, null, flagArray))));
                    flag = true;
                  }
                }
              }
            }
            else
            {
              if (tag.V1TAG.Tracknumber != 0)
                flag = true;

              tag.V1TAG.Tracknumber = 0;
            }
          }

          if (this.chkComment.Checked && (!this.chkExists.Checked || (StringType.StrCmp(tag.V1TAG.Comment, "", false) == 0)))
          {
            if (tag.V2TAG.FrameExists("COMM"))
            {
              foreach (V2LDCFrame frame in tag.V2TAG.GetFrames("COMM"))
              {
                if (StringType.StrCmp(tag.V1TAG.Comment, frame.Content, false) != 0)
                {
                  tag.V1TAG.Comment = frame.Content;
                  flag = true;
                }

                break;
              }
            }
            else
            {
              if (StringType.StrCmp(tag.V1TAG.Comment, "", false) != 0)
                flag = true;

              tag.V1TAG.Comment = "";
            }
          }

          if (this.chkGenre.Checked && (!this.chkExists.Checked || (tag.V1TAG.GenreByte == 0xff)))
          {
            if (tag.V2TAG.FrameExists("TCON"))
            {
              string sRight = StringType.FromObject(LateBinding.LateGet(tag.V2TAG.GetFrame("TCON"), null, "Content", new object[0], null, null));
              bool flag2 = false;

              if (sRight.IndexOf('\0') > 0)
                sRight = sRight.Substring(0, sRight.IndexOf('\0'));

              foreach (DataRow row in Declarations.objSettings.Genres.Rows)
              {
                if (StringType.StrCmp(row["Name"].ToString().ToLower(), sRight.ToLower(), false) == 0)
                {
                  if (ObjectType.ObjTst(tag.V1TAG.GenreByte, row["V2V1"], false) != 0)
                  {
                    tag.V1TAG.GenreByte = ByteType.FromObject(row["V2V1"]);
                    flag2 = true;
                    flag = true;
                  }

                  break;
                }
              }

              if (!flag2 & (StringType.StrCmp(tag.V1TAG.GenreText, sRight, false) != 0))
              {
                tag.V1TAG.GenreText = sRight;
                flag = true;
              }
            }
            else
            {
              if (tag.V1TAG.GenreByte != 0xff)
                flag = true;

              tag.V1TAG.GenreByte = 0xff;
            }
          }

          if (this.chkYear.Checked && (!this.chkExists.Checked || (tag.V1TAG.Year == 0)))
          {
            if (tag.V2TAG.FrameExists("TYER"))
            {
              if (tag.V1TAG.Year !=
                Convert.ToInt32(
                  Conversion.Val(
                    RuntimeHelpers.GetObjectValue(
                      LateBinding.LateGet(tag.V2TAG.GetFrame("TYER"), null, "Content", new object[0], null, null)))))
              {
                tag.V1TAG.Year =
                  Convert.ToInt32(
                    Conversion.Val(
                      RuntimeHelpers.GetObjectValue(
                        LateBinding.LateGet(tag.V2TAG.GetFrame("TYER"), null, "Content", new object[0], null, null))));
                flag = true;
              }
            }
            else if (tag.V2TAG.FrameExists("TDRC"))
            {
              if (tag.V1TAG.Year !=
                    Convert.ToInt32(
                      Conversion.Val(
                        RuntimeHelpers.GetObjectValue(
                          LateBinding.LateGet(
                            LateBinding.LateGet(tag.V2TAG.GetFrame("TDRC"), null, "Content", new object[0], null, null),
                            null, "Substring", new object[] { 0, 4 }, null, null)))))
              {
                tag.V1TAG.Year =
                  Convert.ToInt32(
                    Conversion.Val(
                      RuntimeHelpers.GetObjectValue(
                        LateBinding.LateGet(
                          LateBinding.LateGet(tag.V2TAG.GetFrame("TDRC"), null, "Content", new object[0], null, null),
                          null, "Substring", new object[] { 0, 4 }, null, null))));
                flag = true;
              }
            }
            else
            {
              if (tag.V1TAG.Year != 0)
                flag = true;

              tag.V1TAG.Year = 0;
            }
          }
        }

        if (flag & !tag.V1TAG.TAGPresent)
          tag.V1TAG.TAGPresent = true;

        if (flag)
          tag.Changed = true;

        this.MainForm.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void CB34(ref frmProgress frmProg)
    {
      bool flag = false;

      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        MP3 tag = (MP3)item.Tag;
        frmProg.lblInfo.Text = tag.CurrentFullName.Replace("&", "&&");

        if (!tag.V2TAG.TAGHeaderPresent || (tag.V2TAG.TAGVersion != 3))
          goto Label_0715;

        Declarations.UnDoReDo @do =
          new Declarations.UnDoReDo((MP3)item.Tag,
                                    (V1TAG)LateBinding.LateGet(
                                      LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null),
                                      null, "Clone", new object[0], null, null),
                                    (V2TAG)LateBinding.LateGet(
                                      LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null),
                                      null, "Clone", new object[0], null, null),
                                    StringType.FromObject(
                                      LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)),
                                    BooleanType.FromObject(
                                      LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        bool flag2 = false;

        if (!tag.V2TAG.FrameExists("TSIZ") && !tag.V2TAG.FrameExists("TRDA"))
        {
          var enumerator = tag.V2TAG.GetAllNotSupportedFrames().GetEnumerator();
          while (enumerator.MoveNext())
          {
            object objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);
            if ((ObjectType.ObjTst(LateBinding.LateGet(objectValue, null, "FID", new object[0], null, null),
                                   "EQUA",
                                   false) == 0) ||
                (ObjectType.ObjTst(LateBinding.LateGet(objectValue, null, "FID", new object[0], null, null),
                                   "RVAD",
                                   false) == 0))
            {
              flag2 = true;
              goto Label_01FE;
            }
          }
        }
        else
          flag2 = true;

Label_01FE:

        if ((flag2 && !flag) &&
            (Interaction.MsgBox(
              RuntimeHelpers.GetObjectValue(
                LateBinding.LateGet(
                  Declarations.objResources.ResStrings["Convert2324"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)),
              MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo, null) == MsgBoxResult.No))
          break;

        flag = true;
        tag.V2TAG.TAGVersion = 4;
        tag.Changed = true;
        tag.V2TAG.Changed = true;
        string sDest = "XXXX-XX-XXXXX:XX:XX";

        if (tag.V2TAG.FrameExists("TYER"))
        {
          try
          {
            StringType.MidStmtStr(ref sDest, 1, 0x7fffffff,
              StringType.FromObject(
                LateBinding.LateGet(
                  LateBinding.LateGet(tag.V2TAG.GetFrame("TYER"), null, "Content", new object[0], null, null),
                  null, "Substring", new object[] { 0, 4 }, null, null)));
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            ProjectData.ClearProjectError();
          }
          tag.V2TAG.RemoveFrame("TYER");
        }

        if (tag.V2TAG.FrameExists("TDAT"))
        {
          try
          {
            StringType.MidStmtStr(ref sDest, 6, 0x7fffffff,
              StringType.FromObject(
                LateBinding.LateGet(
                  LateBinding.LateGet(tag.V2TAG.GetFrame("TDAT"), null, "Content", new object[0], null, null),
                  null, "Substring", new object[] { 2, 2 }, null, null)));
            StringType.MidStmtStr(ref sDest, 9, 0x7fffffff,
              StringType.FromObject(
                LateBinding.LateGet(
                  LateBinding.LateGet(tag.V2TAG.GetFrame("TDAT"), null, "Content", new object[0], null, null),
                  null, "Substring", new object[] { 0, 2 }, null, null)));
          }
          catch (Exception exception2)
          {
            ProjectData.SetProjectError(exception2);
            ProjectData.ClearProjectError();
          }
          tag.V2TAG.RemoveFrame("TDAT");
        }

        if (tag.V2TAG.FrameExists("TIME"))
        {
          try
          {
            StringType.MidStmtStr(ref sDest, 11, 0x7fffffff,
              StringType.FromObject(
                ObjectType.StrCatObj("T",
                                     LateBinding.LateGet(
                                       LateBinding.LateGet(tag.V2TAG.GetFrame("TIME"), null, "Content", new object[0], null, null),
                                       null, "Substring", new object[] { 0, 2 }, null, null))));
            StringType.MidStmtStr(ref sDest, 15, 0x7fffffff,
              StringType.FromObject(
                LateBinding.LateGet(
                  LateBinding.LateGet(tag.V2TAG.GetFrame("TIME"),
                  null, "Content", new object[0], null, null),
                  null, "Substring", new object[] { 2, 2 }, null, null)));
          }
          catch (Exception exception3)
          {
            ProjectData.SetProjectError(exception3);
            ProjectData.ClearProjectError();
          }
          tag.V2TAG.RemoveFrame("TIME");
        }

        if (tag.V2TAG.FrameExists("TSIZ"))
          tag.V2TAG.RemoveFrame("TSIZ");

        if (tag.V2TAG.FrameExists("TRDA"))
          tag.V2TAG.RemoveFrame("TRDA");

        if (tag.V2TAG.FrameExists("TORY"))
        {
          LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TORY"), null, "FID", new object[] { "TDOR" }, null, false, true);
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TORY")));
          tag.V2TAG.RemoveFrame("TORY");
        }

        if (tag.V2TAG.FrameExists("IPLS"))
        {
          LateBinding.LateSetComplex(tag.V2TAG.GetFrame("IPLS"), null, "FID", new object[] { "TIPL" }, null, false, true);
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("IPLS")));
          tag.V2TAG.RemoveFrame("IPLS");
        }

        tag.V2TAG.RemoveFrames("EQUA");
        tag.V2TAG.RemoveFrames("RVAD");

        if ((StringType.StrCmp(sDest, "XXXX-XX-XXXXX:XX:XX", false) != 0) & !sDest.StartsWith("X"))
        {
          V2TextFrame frame = new V2TextFrame
          {
            FID = "TDRC",
            Content = sDest.Substring(0, sDest.IndexOf("X"))
          };

          if ((frame.Content.EndsWith("-") | frame.Content.EndsWith(":")) | frame.Content.EndsWith("T"))
            frame.Content = frame.Content.Substring(0, frame.Content.Length - 1);
          tag.V2TAG.AddFrame(frame);
        }

        this.MainForm.UpdateListItem(item, false);
Label_0715:
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void CB43(ref frmProgress frmProg)
    {
      bool flag = false;
      foreach (ListViewItem item in this.MainForm.MP3View.SelectedItems)
      {
        object objectValue;
        Application.DoEvents();

        if (frmProg.Canceled)
          break;

        MP3 tag = (MP3)item.Tag;
        frmProg.lblInfo.Text = tag.CurrentFullName.Replace("&", "&&");

        if (!tag.V2TAG.TAGHeaderPresent || (tag.V2TAG.TAGVersion != 4))
          goto Label_0889;

        Declarations.UnDoReDo @do =
          new Declarations.UnDoReDo(
            (MP3)item.Tag,
            (V1TAG)LateBinding.LateGet(
              LateBinding.LateGet(item.Tag, null, "V1TAG", new object[0], null, null),
              null, "Clone", new object[0], null, null),
            (V2TAG)LateBinding.LateGet(
              LateBinding.LateGet(item.Tag, null, "V2TAG", new object[0], null, null),
              null, "Clone", new object[0], null, null),
            StringType.FromObject(
              LateBinding.LateGet(item.Tag, null, "CurrentFullName", new object[0], null, null)),
            BooleanType.FromObject(
              LateBinding.LateGet(item.Tag, null, "Changed", new object[0], null, null)));
        frmProg.List.Add(@do);
        bool flag2 = false;

        if ((((!tag.V2TAG.FrameExists("TDEN") &&
               !tag.V2TAG.FrameExists("TDRL")) &&
              (!tag.V2TAG.FrameExists("TDTG") &&
               !tag.V2TAG.FrameExists("TSST"))) &&
             ((!tag.V2TAG.FrameExists("TMCL") &&
               !tag.V2TAG.FrameExists("TMOO")) &&
              (!tag.V2TAG.FrameExists("TPRO") &&
               !tag.V2TAG.FrameExists("TSOA")))) &&
              (!tag.V2TAG.FrameExists("TSOP") &&
               !tag.V2TAG.FrameExists("TSOT")))
        {
          var enumerator2 = tag.V2TAG.GetAllNotSupportedFrames().GetEnumerator();
          while (enumerator2.MoveNext())
          {
            objectValue = RuntimeHelpers.GetObjectValue(enumerator2.Current);
            if (((ObjectType.ObjTst(
                   LateBinding.LateGet(
                     objectValue, null, "FID", new object[0], null, null),
                   "ASPI", false) == 0) ||
                 (ObjectType.ObjTst(
                   LateBinding.LateGet(
                     objectValue, null, "FID", new object[0], null, null),
                   "EQU2", false) == 0)) ||
               (((ObjectType.ObjTst(
                 LateBinding.LateGet(
                   objectValue, null, "FID", new object[0], null, null),
                 "RVA2", false) == 0) ||
                 (ObjectType.ObjTst(
                   LateBinding.LateGet(objectValue, null, "FID", new object[0], null, null),
                   "SEEK", false) == 0)) ||
                 (ObjectType.ObjTst(
                   LateBinding.LateGet(objectValue, null, "FID", new object[0], null, null),
                   "SIGN", false) == 0)))
            {
              flag2 = true;
              goto Label_0315;
            }
          }
        }
        else
          flag2 = true;

Label_0315:
        if ((flag2 && !flag) &&
            (Interaction.MsgBox(
              RuntimeHelpers.GetObjectValue(
                LateBinding.LateGet(
                  Declarations.objResources.ResStrings["Convert2423"], null, "Replace", new object[] { "%C", "\r\n" }, null, null)),
              MsgBoxStyle.Exclamation | MsgBoxStyle.YesNo, null) == MsgBoxResult.No))
          break;

        flag = true;
        tag.V2TAG.TAGVersion = 3;
        tag.V2TAG.FooterPresent = false;
        tag.Changed = true;
        tag.V2TAG.Changed = true;

        if (tag.V2TAG.FrameExists("TDRC"))
        {
          V2TextFrame frame = (V2TextFrame)tag.V2TAG.GetFrame("TDRC");

          if (StringType.StrCmp(frame.Content, "", false) != 0)
          {
            tag.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TYER", frame.Content.Substring(0, 4)));

            if (frame.Content.Length >= 10)
              tag.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TDAT", frame.Content.Substring(8, 2) + frame.Content.Substring(5, 2)));

            if (Strings.Len(frame.Content) >= 0x10)
              tag.V2TAG.AddFrame(ID3Functions.CreateTextFrame("TIME", frame.Content.Substring(11, 2) + frame.Content.Substring(14, 2)));
          }
          tag.V2TAG.RemoveFrame("TDRC");
        }

        if (tag.V2TAG.FrameExists("TDOR"))
        {
          LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TDOR"), null, "FID", new object[] { "TORY" }, null, false, true);
          LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TDOR"), null, "Content", new object[]
          {
            RuntimeHelpers.GetObjectValue(
              LateBinding.LateGet(
                LateBinding.LateGet(
                  tag.V2TAG.GetFrame("TDOR"), null, "Content", new object[0], null, null),
                null, "Substring", new object[] { 0, 4 }, null, null))
          }, null, false, true);
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TDOR")));
          tag.V2TAG.RemoveFrame("TDOR");
        }

        if (tag.V2TAG.FrameExists("TIPL"))
        {
          LateBinding.LateSetComplex(tag.V2TAG.GetFrame("TIPL"), null, "FID", new object[] { "IPLS" }, null, false, true);
          tag.V2TAG.AddFrame(RuntimeHelpers.GetObjectValue(tag.V2TAG.GetFrame("TIPL")));
          tag.V2TAG.RemoveFrame("TIPL");
        }

        if (tag.V2TAG.FrameExists("TDEN"))
          tag.V2TAG.RemoveFrame("TDEN");

        if (tag.V2TAG.FrameExists("TDRL"))
          tag.V2TAG.RemoveFrame("TDRL");

        if (tag.V2TAG.FrameExists("TDTG"))
          tag.V2TAG.RemoveFrame("TDTG");

        if (tag.V2TAG.FrameExists("TMCL"))
          tag.V2TAG.RemoveFrame("TMCL");

        if (tag.V2TAG.FrameExists("TMOO"))
          tag.V2TAG.RemoveFrame("TMOO");

        if (tag.V2TAG.FrameExists("TPRO"))
          tag.V2TAG.RemoveFrame("TPRO");

        if (tag.V2TAG.FrameExists("TSOA"))
          tag.V2TAG.RemoveFrame("TSOA");

        if (tag.V2TAG.FrameExists("TSOP"))
          tag.V2TAG.RemoveFrame("TSOP");

        if (tag.V2TAG.FrameExists("TSOT"))
          tag.V2TAG.RemoveFrame("TSOT");

        if (tag.V2TAG.FrameExists("TSST"))
          tag.V2TAG.RemoveFrame("TSST");

        tag.V2TAG.RemoveFrames("ASPI");
        tag.V2TAG.RemoveFrames("RVA2");
        tag.V2TAG.RemoveFrames("SIGN");
        tag.V2TAG.RemoveFrames("EQU2");
        tag.V2TAG.RemoveFrames("SEEK");

        var enumerator = tag.V2TAG.GetAllSupportedFrames().GetEnumerator();
        while (enumerator.MoveNext())
        {
          objectValue = RuntimeHelpers.GetObjectValue(enumerator.Current);

          try
          {
            if (BooleanType.FromObject(
                  ObjectType.BitAndObj(
                    ObjectType.ObjTst(
                      LateBinding.LateGet(objectValue, null, "EncodingByte", new object[0], null, null), 0xff, false) != 0,
                    ObjectType.ObjTst(
                      LateBinding.LateGet(objectValue, null, "EncodingByte", new object[0], null, null), 1, false) > 0)))
              LateBinding.LateSet(objectValue, null, "EncodingByte", new object[] { 1 }, null);

            continue;
          }
          catch (Exception exception1)
          {
            ProjectData.SetProjectError(exception1);
            Exception exception = exception1;
            ProjectData.ClearProjectError();
            continue;
          }
        }

Label_0889:
        this.MainForm.UpdateListItem(item, false);
        frmProg.ProgressBar.PerformStep();
      }
    }

    private void frmTransfer_Load(object sender, EventArgs e)
    {
      Form objForm = this;
      Declarations.objResources.ResourcesToForm(ref objForm);
      objForm = this;
      Id3TagIT_Main.RestoreFormSettings(ref objForm);
      objForm = this;

      switch (Declarations.objSettings.TransferMethod)
      {
        case 1:
          this.txtCommentD.Text = Declarations.objSettings.TransferCommentD;
          this.chkArtist.Checked = Declarations.objSettings.TransferArtist12;
          this.chkTitle.Checked = Declarations.objSettings.TransferTitle12;
          this.chkAlbum.Checked = Declarations.objSettings.TransferAlbum12;
          this.chkGenre.Checked = Declarations.objSettings.TransferGenre12;
          this.chkTrack.Checked = Declarations.objSettings.TransferTrack12;
          this.chkComment.Checked = Declarations.objSettings.TransferComment12;
          this.chkYear.Checked = Declarations.objSettings.TransferYear12;
          this.chkExists.Checked = Declarations.objSettings.TransferKeep12;
          this.opt12.Checked = true;
          break;

        case 2:
          this.chkArtist.Checked = Declarations.objSettings.TransferArtist21;
          this.chkTitle.Checked = Declarations.objSettings.TransferTitle21;
          this.chkAlbum.Checked = Declarations.objSettings.TransferAlbum21;
          this.chkGenre.Checked = Declarations.objSettings.TransferGenre21;
          this.chkTrack.Checked = Declarations.objSettings.TransferTrack21;
          this.chkComment.Checked = Declarations.objSettings.TransferComment21;
          this.chkYear.Checked = Declarations.objSettings.TransferYear21;
          this.chkExists.Checked = Declarations.objSettings.TransferKeep21;
          this.opt21.Checked = true;
          break;

        case 3:
          this.optConvert34.Checked = true;
          break;

        case 4:
          this.optConvert43.Checked = true;
          break;
      }
    }

    private void opt12_CheckedChanged(object sender, EventArgs e)
    {
      this.GroupBox.Enabled = true;

      if (!this.opt12.Checked)
      {
        Declarations.objSettings.TransferCommentD = this.txtCommentD.Text;
        Declarations.objSettings.TransferArtist12 = this.chkArtist.Checked;
        Declarations.objSettings.TransferTitle12 = this.chkTitle.Checked;
        Declarations.objSettings.TransferAlbum12 = this.chkAlbum.Checked;
        Declarations.objSettings.TransferGenre12 = this.chkGenre.Checked;
        Declarations.objSettings.TransferTrack12 = this.chkTrack.Checked;
        Declarations.objSettings.TransferComment12 = this.chkComment.Checked;
        Declarations.objSettings.TransferYear12 = this.chkYear.Checked;
        Declarations.objSettings.TransferKeep12 = this.chkExists.Checked;
      }

      if (this.opt12.Checked)
      {
        this.txtCommentD.Text = Declarations.objSettings.TransferCommentD;
        this.chkArtist.Checked = Declarations.objSettings.TransferArtist12;
        this.chkTitle.Checked = Declarations.objSettings.TransferTitle12;
        this.chkAlbum.Checked = Declarations.objSettings.TransferAlbum12;
        this.chkGenre.Checked = Declarations.objSettings.TransferGenre12;
        this.chkTrack.Checked = Declarations.objSettings.TransferTrack12;
        this.chkComment.Checked = Declarations.objSettings.TransferComment12;
        this.chkYear.Checked = Declarations.objSettings.TransferYear12;
        this.chkExists.Checked = Declarations.objSettings.TransferKeep12;
      }
    }

    private void opt21_CheckedChanged(object sender, EventArgs e)
    {
      this.GroupBox.Enabled = true;

      if (!this.opt21.Checked)
      {
        Declarations.objSettings.TransferArtist21 = this.chkArtist.Checked;
        Declarations.objSettings.TransferTitle21 = this.chkTitle.Checked;
        Declarations.objSettings.TransferAlbum21 = this.chkAlbum.Checked;
        Declarations.objSettings.TransferGenre21 = this.chkGenre.Checked;
        Declarations.objSettings.TransferTrack21 = this.chkTrack.Checked;
        Declarations.objSettings.TransferComment21 = this.chkComment.Checked;
        Declarations.objSettings.TransferYear21 = this.chkYear.Checked;
        Declarations.objSettings.TransferKeep21 = this.chkExists.Checked;
      }

      if (this.opt21.Checked)
      {
        this.chkArtist.Checked = Declarations.objSettings.TransferArtist21;
        this.chkTitle.Checked = Declarations.objSettings.TransferTitle21;
        this.chkAlbum.Checked = Declarations.objSettings.TransferAlbum21;
        this.chkGenre.Checked = Declarations.objSettings.TransferGenre21;
        this.chkTrack.Checked = Declarations.objSettings.TransferTrack21;
        this.chkComment.Checked = Declarations.objSettings.TransferComment21;
        this.chkYear.Checked = Declarations.objSettings.TransferYear21;
        this.chkExists.Checked = Declarations.objSettings.TransferKeep21;
      }
    }

    private void optConvert_CheckedChanged(object sender, EventArgs e)
    {
      this.GroupBox.Enabled = false;
    }

    #endregion
  }
}