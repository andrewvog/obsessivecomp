using System;
using System.Collections.Generic;
using System.Text;

namespace AceLib.General {

  public class StringLib {

    public static string ToLfs(string text) {
      StringBuilder result = new StringBuilder(text);
      result.Replace("\r\n", "\n");
      return result.Replace('\r', '\n').ToString();
    }
  }
}
