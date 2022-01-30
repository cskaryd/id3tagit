using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Windows.Forms;

namespace ID3_TagIT
{
  public class SortClass : IComparer
  {
    private bool vbooAltSort;
    private byte vbytSorterMethod;
    private int vintColumn;

    public int Compare(object x, object y)
    {
      int num = 0;
      ListViewItem item = (ListViewItem)x;
      ListViewItem item2 = (ListViewItem)y;

      switch (this.vbytSorterMethod)
      {
        case 1:
          if (!this.vbooAltSort)
            return string.Compare(item.SubItems[this.vintColumn].Text, item2.SubItems[this.vintColumn].Text);
          else
            return string.Compare(item2.SubItems[this.vintColumn].Text, item.SubItems[this.vintColumn].Text);

        case 2:
          {
            string text = item.SubItems[this.vintColumn].Text;

            if (text.IndexOf("/") >= 0)
              text = text.Substring(0, text.IndexOf("/"));

            string expression = item2.SubItems[this.vintColumn].Text;

            if (expression.IndexOf("/") >= 0)
              expression = expression.Substring(0, expression.IndexOf("/"));

            if (!(Information.IsNumeric(text) & Information.IsNumeric(expression)))
            {
              if (StringType.StrCmp(item.SubItems[this.vintColumn].Text, "", false) == 0)
              {
                if (!this.AltSort)
                  return -1;
                else
                  return 1;
              }

              if (this.AltSort)
                return -1;
              else
                return 1;
            }

            if (!this.vbooAltSort)
            {
              try
              {
                num = (int)(LongType.FromString(text) - LongType.FromString(expression));
              }
              catch (Exception exception3)
              {
                ProjectData.SetProjectError(exception3);
                Exception exception2 = exception3;
                num = (int)((LongType.FromString(text) - LongType.FromString(expression)) / 0xf4240L);
                ProjectData.ClearProjectError();
              }

              return num;
            }

            try
            {
              num = (int)(LongType.FromString(text) + LongType.FromString(expression));
            }
            catch (Exception exception1)
            {
              ProjectData.SetProjectError(exception1);
              Exception exception = exception1;
              num = (int)((LongType.FromString(text) + LongType.FromString(expression)) / 0xf4240L);
              ProjectData.ClearProjectError();
            }

            return num;
          }

        case 3:
          if (!this.vbooAltSort)
            return DateTime.Compare(DateType.FromString(item.SubItems[this.vintColumn].Text), DateType.FromString(item2.SubItems[this.vintColumn].Text));
          else
            return DateTime.Compare(DateType.FromString(item2.SubItems[this.vintColumn].Text), DateType.FromString(item.SubItems[this.vintColumn].Text));
      }

      return num;
    }

    public bool AltSort
    {
      get
      {
        return this.vbooAltSort;
      }
      set
      {
        this.vbooAltSort = value;
      }
    }

    public int Column
    {
      get
      {
        return this.vintColumn;
      }
      set
      {
        this.vintColumn = value;
      }
    }

    public SorterMethod SortMethod
    {
      get
      {
        return (SorterMethod)this.vbytSorterMethod;
      }
      set
      {
        this.vbytSorterMethod = (byte)value;
      }
    }

    public enum SorterMethod : byte
    {
      Text = 1,
      Numeric = 2,
      Dat = 3
    }
  }
}