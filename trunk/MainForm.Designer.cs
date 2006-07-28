namespace ObsessiveComp
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
          this.components = new System.ComponentModel.Container();
          System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
          this.txtStepNotes = new System.Windows.Forms.RichTextBox();
          this.ilGlyphs = new System.Windows.Forms.ImageList(this.components);
          this.tipMain = new System.Windows.Forms.ToolTip(this.components);
          this.tmrFadeOut = new System.Windows.Forms.Timer(this.components);
          this.btnNextStep = new System.Windows.Forms.Button();
          this.btnPriorStep = new System.Windows.Forms.Button();
          this.tmrMouseOverWatcher = new System.Windows.Forms.Timer(this.components);
          this.SuspendLayout();
          // 
          // txtStepNotes
          // 
          this.txtStepNotes.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                      | System.Windows.Forms.AnchorStyles.Right)));
          this.txtStepNotes.BackColor = System.Drawing.Color.White;
          this.txtStepNotes.BorderStyle = System.Windows.Forms.BorderStyle.None;
          this.txtStepNotes.Cursor = System.Windows.Forms.Cursors.SizeAll;
          this.txtStepNotes.Location = new System.Drawing.Point(41, 7);
          this.txtStepNotes.Name = "txtStepNotes";
          this.txtStepNotes.ReadOnly = true;
          this.txtStepNotes.ScrollBars = System.Windows.Forms.RichTextBoxScrollBars.None;
          this.txtStepNotes.Size = new System.Drawing.Size(410, 50);
          this.txtStepNotes.TabIndex = 0;
          this.txtStepNotes.TabStop = false;
          this.txtStepNotes.Text = "This is the first line.\nThis is the second line.\n\nThis is the fourth line.\nhttp:/" +
              "/www.riosoftware.com\nmailto:andrew@riosoftware.com\nhttp://msdn.microsoft.com\nfil" +
              "e:c:\\dev\nfile:c:\\temp\\test.pdf\n";
          this.txtStepNotes.MouseDown += new System.Windows.Forms.MouseEventHandler(this.txtStepNotes_MouseDown);
          this.txtStepNotes.LinkClicked += new System.Windows.Forms.LinkClickedEventHandler(this.txtStepNotes_LinkClicked);
          this.txtStepNotes.Enter += new System.EventHandler(this.txtStepNotes_Enter);
          // 
          // ilGlyphs
          // 
          this.ilGlyphs.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("ilGlyphs.ImageStream")));
          this.ilGlyphs.Images.SetKeyName(0, "SetNextStatement.bmp");
          // 
          // tipMain
          // 
          this.tipMain.ShowAlways = true;
          this.tipMain.ToolTipTitle = "This is a tooltip.";
          // 
          // tmrFadeOut
          // 
          this.tmrFadeOut.Tick += new System.EventHandler(this.tmrFadeOut_Tick);
          // 
          // btnNextStep
          // 
          this.btnNextStep.Cursor = System.Windows.Forms.Cursors.Default;
          this.btnNextStep.Dock = System.Windows.Forms.DockStyle.Right;
          this.btnNextStep.Font = new System.Drawing.Font("Wingdings", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btnNextStep.ImageKey = "(none)";
          this.btnNextStep.ImageList = this.ilGlyphs;
          this.btnNextStep.Location = new System.Drawing.Point(458, 0);
          this.btnNextStep.Name = "btnNextStep";
          this.btnNextStep.Size = new System.Drawing.Size(35, 164);
          this.btnNextStep.TabIndex = 3;
          this.btnNextStep.Text = "ð";
          this.btnNextStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          this.btnNextStep.Click += new System.EventHandler(this.btnNextStep_Click);
          // 
          // btnPriorStep
          // 
          this.btnPriorStep.Cursor = System.Windows.Forms.Cursors.Default;
          this.btnPriorStep.Dock = System.Windows.Forms.DockStyle.Left;
          this.btnPriorStep.Font = new System.Drawing.Font("Wingdings", 16F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
          this.btnPriorStep.ImageKey = "(none)";
          this.btnPriorStep.ImageList = this.ilGlyphs;
          this.btnPriorStep.Location = new System.Drawing.Point(0, 0);
          this.btnPriorStep.Name = "btnPriorStep";
          this.btnPriorStep.Size = new System.Drawing.Size(35, 164);
          this.btnPriorStep.TabIndex = 4;
          this.btnPriorStep.Text = "ï";
          this.btnPriorStep.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
          this.btnPriorStep.Click += new System.EventHandler(this.btnPriorStep_Click);
          // 
          // tmrMouseOverWatcher
          // 
          this.tmrMouseOverWatcher.Enabled = true;
          this.tmrMouseOverWatcher.Tick += new System.EventHandler(this.tmrMouseOverWatcher_Tick);
          // 
          // MainForm
          // 
          this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
          this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
          this.BackColor = System.Drawing.Color.White;
          this.ClientSize = new System.Drawing.Size(493, 164);
          this.ControlBox = false;
          this.Controls.Add(this.btnPriorStep);
          this.Controls.Add(this.btnNextStep);
          this.Controls.Add(this.txtStepNotes);
          this.Cursor = System.Windows.Forms.Cursors.SizeAll;
          this.DoubleBuffered = true;
          this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.SizableToolWindow;
          this.MaximizeBox = false;
          this.MinimizeBox = false;
          this.MinimumSize = new System.Drawing.Size(200, 58);
          this.Name = "MainForm";
          this.ShowInTaskbar = false;
          this.TopMost = true;
          this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.MainForm_MouseDown);
          this.Shown += new System.EventHandler(this.MainForm_Shown);
          this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MainForm_FormClosing);
          this.ResumeLayout(false);

        }

        #endregion

      private System.Windows.Forms.RichTextBox txtStepNotes;
        private System.Windows.Forms.ImageList ilGlyphs;
        private System.Windows.Forms.ToolTip tipMain;
      private System.Windows.Forms.Timer tmrFadeOut;
      private System.Windows.Forms.Button btnNextStep;
      private System.Windows.Forms.Button btnPriorStep;
      private System.Windows.Forms.Timer tmrMouseOverWatcher;
    }
}

