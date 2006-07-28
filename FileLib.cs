using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace AceLib.General {

  public class FileLib {

    public static string ReadFile(string fileName) {
      FileStream file = new FileStream(fileName, FileMode.Open, FileAccess.Read);
      StreamReader reader = new StreamReader(file);
      try {
        return reader.ReadToEnd();
      } finally {
        reader.Close();
        file.Close();
      }
    }
  }
}
