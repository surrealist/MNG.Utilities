using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MNG.Utilities
{
  /// <summary>
  /// 1,a,2,3,5
  /// Util.WriteFile("product.csv", 1, "a", 2, 3, 5);
  /// </summary>
  public static class Util
  {

    public static void AppendFile(string fileName, params object[] data)
    {
      if (data == null) return;
      if (data.Length == 0) return;

      var text = string.Join(",", data) + Environment.NewLine;

      File.AppendAllText(fileName, text);
    }
  }
}