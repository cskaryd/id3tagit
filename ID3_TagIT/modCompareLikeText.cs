﻿namespace ID3_TagIT
{
  using Microsoft.VisualBasic;
  using Microsoft.VisualBasic.CompilerServices;
  using System;

  [StandardModule, OptionText]
  internal sealed class modCompareLikeText
  {
    public static bool CompareLikeT(string vstrText1, string vstrText2)
    {
      return StringType.StrLike(vstrText1, vstrText2, CompareMethod.Text);
    }
  }
}