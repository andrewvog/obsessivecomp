using System;
using System.Collections.Generic;
using System.Text;

namespace ObsessiveComp.ScriptProcessing {

  class Step {
    private string notes;
    private string title;
    public string Notes { get { return notes; } set { notes = value; } }
    public string Title { get { return title; } set { title = value; } }

    public Step(string title, string notes) {
      this.title = title.TrimEnd();
      this.notes = notes.TrimEnd();
    }
  }
}
