namespace CreatureStats.Forms
{
    partial class AboutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AboutForm));

            this.AboutGroupBox = new System.Windows.Forms.GroupBox();
            this.AboutRichTextBox = new System.Windows.Forms.RichTextBox();
            this.Button = new System.Windows.Forms.Button();
            this.VersionGroupBox = new System.Windows.Forms.GroupBox();
            this.VersionRichTextBox = new System.Windows.Forms.RichTextBox();
            this.AboutGroupBox.SuspendLayout();
            this.VersionGroupBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // AboutGroupBox
            // 
            this.AboutGroupBox.Controls.Add(this.AboutRichTextBox);
            this.AboutGroupBox.Location = new System.Drawing.Point(13, 11);
            this.AboutGroupBox.Name = "AboutGroupBox";
            this.AboutGroupBox.Size = new System.Drawing.Size(261, 151);
            this.AboutGroupBox.TabIndex = 0;
            this.AboutGroupBox.TabStop = false;
            this.AboutGroupBox.Text = "About";
            // 
            // AboutRichTextBox
            // 
            this.AboutRichTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.AboutRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.AboutRichTextBox.Location = new System.Drawing.Point(13, 25);
            this.AboutRichTextBox.Name = "AboutRichTextBox";
            this.AboutRichTextBox.Size = new System.Drawing.Size(238, 129);
            this.AboutRichTextBox.TabIndex = 0;
            this.AboutRichTextBox.Text = resources.GetString("AboutRichTextBox.Text");
            // 
            // Button
            // 
            this.Button.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.Button.Location = new System.Drawing.Point(87, 219);
            this.Button.Name = "Button";
            this.Button.Size = new System.Drawing.Size(102, 24);
            this.Button.TabIndex = 1;
            this.Button.Text = "OK";
            this.Button.UseVisualStyleBackColor = true;
            // 
            // VersionGroupBox
            // 
            this.VersionGroupBox.Controls.Add(this.VersionRichTextBox);
            this.VersionGroupBox.Location = new System.Drawing.Point(17, 171);
            this.VersionGroupBox.Name = "VersionGroupBox";
            this.VersionGroupBox.Size = new System.Drawing.Size(256, 42);
            this.VersionGroupBox.TabIndex = 2;
            this.VersionGroupBox.TabStop = false;
            this.VersionGroupBox.Text = "Version";
            // 
            // VersionRichTextBox
            // 
            this.VersionRichTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.VersionRichTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.VersionRichTextBox.Location = new System.Drawing.Point(9, 21);
            this.VersionRichTextBox.Name = "VersionRichTextBox";
            this.VersionRichTextBox.Size = new System.Drawing.Size(238, 24);
            this.VersionRichTextBox.TabIndex = 1;
            this.VersionRichTextBox.Text = "Supports client build 15595.";
            // 
            // AboutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(284, 252);
            this.Controls.Add(this.VersionGroupBox);
            this.Controls.Add(this.Button);
            this.Controls.Add(this.AboutGroupBox);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AboutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "About Creature Stats";
            this.AboutGroupBox.ResumeLayout(false);
            this.VersionGroupBox.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox AboutGroupBox;
        private System.Windows.Forms.RichTextBox AboutRichTextBox;
        private System.Windows.Forms.Button Button;
        private System.Windows.Forms.GroupBox VersionGroupBox;
        private System.Windows.Forms.RichTextBox VersionRichTextBox;
    }
}