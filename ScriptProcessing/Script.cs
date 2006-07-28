using System;
using System.Collections.Generic;
using System.Text;

using AceLib.General;

namespace ObsessiveComp.ScriptProcessing {

  class Script {
    private int _stepIndex;
    private List<Step> _steps = new List<Step>();

    private void ReadScript(string fileName) {
      string contents = StringLib.ToLfs(FileLib.ReadFile(fileName));
      string[] lines = contents.Split('\n');

      StringBuilder nextNotes = new StringBuilder();
      string nextTitle = "";
      foreach (string line in lines) {
        if (line.Trim() != "" && line == line.TrimStart()) {
          if (nextTitle != "") {
            _steps.Add(new Step(nextTitle, nextNotes.ToString()));
            nextTitle = "";
          }
          nextTitle = line;
          nextNotes.Length = 0;
        } else
          nextNotes.Append(line + "\n");
      }
      if (nextTitle != "") 
        _steps.Add(new Step(nextTitle.TrimEnd(), nextNotes.ToString().TrimEnd()));
    }

    public Script(string fileName) {
      ReadScript(fileName);      
    }

    public Step Step { get { return _steps[_stepIndex]; } }
    public int StepCount { get { return _steps.Count; } }
	
    public int StepIndex { get { return _stepIndex; } set { _stepIndex = value; } }

    public bool IsLastStep() {
      return StepIndex >= _steps.Count - 1;
    }
  }
}
