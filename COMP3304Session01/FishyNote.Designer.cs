namespace COMP3304Session01
{
    partial class FishyNote
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
            this.NoteInput = new System.Windows.Forms.TextBox();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.MinimizeNote = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // NoteInput
            // 
            this.NoteInput.Location = new System.Drawing.Point(12, 94);
            this.NoteInput.Multiline = true;
            this.NoteInput.Name = "NoteInput";
            this.NoteInput.Size = new System.Drawing.Size(776, 344);
            this.NoteInput.TabIndex = 0;
            this.NoteInput.Text = "Enter your note here...";
            this.NoteInput.Click += new System.EventHandler(this.NoteInput_Click);
            this.NoteInput.TextChanged += new System.EventHandler(this.NoteInput_TextChanged);
            // 
            // DeleteButton
            // 
            this.DeleteButton.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.DeleteButton.Location = new System.Drawing.Point(773, 0);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(27, 23);
            this.DeleteButton.TabIndex = 1;
            this.DeleteButton.Text = "X";
            this.DeleteButton.UseVisualStyleBackColor = false;
            this.DeleteButton.Click += new System.EventHandler(this.ExitButton_Click);
            // 
            // MinimizeNote
            // 
            this.MinimizeNote.BackColor = System.Drawing.SystemColors.HotTrack;
            this.MinimizeNote.Location = new System.Drawing.Point(12, 12);
            this.MinimizeNote.Name = "MinimizeNote";
            this.MinimizeNote.Size = new System.Drawing.Size(121, 76);
            this.MinimizeNote.TabIndex = 2;
            this.MinimizeNote.UseVisualStyleBackColor = false;
            this.MinimizeNote.Click += new System.EventHandler(this.ToggleShrink_Click);
            // 
            // FishyNote
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.ControlBox = false;
            this.Controls.Add(this.MinimizeNote);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.NoteInput);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FishyNote";
            this.ShowIcon = false;
            this.Text = "FishyNote";
            this.TopMost = true;
            this.MouseDown += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseDown);
            this.MouseMove += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseMove);
            this.MouseUp += new System.Windows.Forms.MouseEventHandler(this.FishyNote_MouseUp);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox NoteInput;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Button MinimizeNote;
    }
}