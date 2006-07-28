using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

using Microsoft.Win32;

using ObsessiveComp.ScriptProcessing;

using AceLib.General;

namespace ObsessiveComp
{
  public partial class MainForm: Form
  {
    Script _script;

    public MainForm(string stepsFile) {
      InitializeComponent();
      _script = new Script(stepsFile);
      txtStepNotes.DetectUrls = true;
    }

    string FormatRtf(string caption, string text) {
      string tabStops = "";
      for (int i = 200; i < 2000; i += 200)
        tabStops += "\\tx" + i.ToString();
      return "{\\rtf1 {\\b" + tabStops + " " + caption + "}\\par\\par "
        + text.Replace("\n", "\\par ")
        + "}";
    }

    private void RefreshStep() {
      string title = string.Format("{0} of {1}:  {2}",
        _script.StepIndex + 1, _script.StepCount, _script.Step.Title);
      txtStepNotes.Rtf = "";
      txtStepNotes.Rtf = FormatRtf(title, _script.Step.Notes);
      ResizeTextViewer();

      Size oldSize = Size;

      bool moveDown = (Top + Height / 2) < (Screen.PrimaryScreen.Bounds.Height / 2);
      Height = txtStepNotes.Height + 2 * txtStepNotes.Top + Height - ClientRectangle.Height;
      int heightDif = Size.Height - oldSize.Height;
      if (!moveDown)
        Top -= heightDif;
    }

    private void ResizeTextViewer() {
      Size oldSize = txtStepNotes.Size;
      txtStepNotes.Size = txtStepNotes.GetPreferredSize(
          new Size(txtStepNotes.Width, 0));
      txtStepNotes.Width = oldSize.Width;
    }

    private void txtStepNotes_LinkClicked(object sender, LinkClickedEventArgs e)
    {
      try
      {
        Process.Start(e.LinkText);
      } catch (Exception exc)
      {
        MessageBox.Show("Failed to launch external process: " + exc.Message,
          "External Process", MessageBoxButtons.OK, MessageBoxIcon.Error);
      }
    }

    private void txtStepNotes_Enter(object sender, EventArgs e)
    {
      ActiveControl = btnNextStep;
    }

    private void tmrFadeOut_Tick(object sender, EventArgs e) {
      const double minOpacity = 0.72;
      const double step = 0.1;

      if (Opacity < minOpacity)
        tmrFadeOut.Enabled = false;
      else {
        Opacity -= step;
      }
    }

    private void btnNextStep_Click(object sender, EventArgs e) {
      if (_script.IsLastStep())
        Application.Exit();
      else {
        _script.StepIndex++;
        RefreshStep();
      }
    }

    private void btnPriorStep_Click(object sender, EventArgs e) {
      if (_script.StepIndex > 0) {
        _script.StepIndex--;
        RefreshStep();
      }
    }

    private void tmrMouseOverWatcher_Tick(object sender, EventArgs e) {
      if (Bounds.Contains(Cursor.Position)) {
        if (Opacity != 1) {
          Opacity = 1;
          tmrFadeOut.Enabled = false;
        }
      } else if (Opacity == 1)
        tmrFadeOut.Enabled = true;
      
    }

    private void MainForm_MouseDown(object sender, MouseEventArgs e) {
      GuiLib.StartDraggingWindow(Handle);
    }

    private void txtStepNotes_MouseDown(object sender, MouseEventArgs e) {
      GuiLib.StartDraggingWindow(Handle);
    }

    private const string _registryKey = "HKEY_CURRENT_USER\\Software\\Ace\\ObsessiveComp";

    private void LoadSettings() {
      try {
        Top = (int)Registry.GetValue(_registryKey, "Top", Top);
        Left = (int)Registry.GetValue(_registryKey, "Left", Left);
        Width = (int)Registry.GetValue(_registryKey, "Width", Width);
        Height = (int)Registry.GetValue(_registryKey, "Height", Height);
      } catch {
      }
    }

    private void SaveSettings() {
      Registry.SetValue(_registryKey, "Top", Top);
      Registry.SetValue(_registryKey, "Left", Left);
      Registry.SetValue(_registryKey, "Width", Width);
      Registry.SetValue(_registryKey, "Height", Height);
    }

    private void MainForm_FormClosing(object sender, FormClosingEventArgs e) {
      SaveSettings();
    }

    private void MainForm_Shown(object sender, EventArgs e) {
      LoadSettings();
      RefreshStep();
    }

  }
}