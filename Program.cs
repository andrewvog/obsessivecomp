using System;
using System.Collections.Generic;
using System.IO;
using System.Windows.Forms;

namespace ObsessiveComp {
  static class Program {
    /// <summary>
    /// The main entry point for the application.
    /// </summary>
    [STAThread]
    static void Main(string[] args) {
      Application.EnableVisualStyles();
      if (args.Length != 1) {
        string exeName = Path.GetFileName(Application.ExecutablePath);
        throw new Exception(string.Format("Usage: {0} filename", exeName));
      }
      Application.Run(new MainForm(args[0]));
    }
  }
}