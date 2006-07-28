using System;
using System.Collections.Generic;
using System.Text;
using System.Runtime.InteropServices;

namespace AceLib.General {
  public class GuiLib {

    [DllImport("user32.dll")]
    static extern IntPtr ReleaseCapture();

    [DllImport("user32.dll")]
    static extern IntPtr SendMessage(IntPtr hWnd, uint Msg, IntPtr wParam, IntPtr lParam);
    
    public static void StartDraggingWindow(IntPtr hWnd) {
      const int HTCAPTION = 2;
      const int WM_NCLBUTTONDOWN = 0xA1;

      ReleaseCapture();
      SendMessage(hWnd, WM_NCLBUTTONDOWN, new IntPtr(HTCAPTION), new IntPtr(0));
    }
  }
}
