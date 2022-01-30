using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;

namespace ID3_TagIT
{
  [StandardModule]
  internal sealed class modCompareLikeBin
  {
    public static bool CompareLikeB(string vstrText1, string vstrText2)
    {
      return StringType.StrLike(vstrText1, vstrText2, CompareMethod.Binary);
    }
  }
}