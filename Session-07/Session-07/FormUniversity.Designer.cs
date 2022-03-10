namespace Session_07 {
    partial class FormUniversity {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.MenuItemFile = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileLoad = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemFileSave = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProfessors = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProfessorsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemProfessors});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(800, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip";
            // 
            // MenuItemFile
            // 
            this.MenuItemFile.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFileLoad,
            this.MenuItemFileSave});
            this.MenuItemFile.Name = "MenuItemFile";
            this.MenuItemFile.Size = new System.Drawing.Size(37, 20);
            this.MenuItemFile.Text = "File";
            // 
            // MenuItemFileLoad
            // 
            this.MenuItemFileLoad.Name = "MenuItemFileLoad";
            this.MenuItemFileLoad.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileLoad.Text = "Load";
            this.MenuItemFileLoad.Click += new System.EventHandler(this.MenuItemFileLoad_Click);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.Size = new System.Drawing.Size(180, 22);
            this.MenuItemFileSave.Text = "Save";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // MenuItemProfessors
            // 
            this.MenuItemProfessors.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemProfessorsEdit});
            this.MenuItemProfessors.Name = "MenuItemProfessors";
            this.MenuItemProfessors.Size = new System.Drawing.Size(73, 20);
            this.MenuItemProfessors.Text = "Professors";
            // 
            // MenuItemProfessorsEdit
            // 
            this.MenuItemProfessorsEdit.Name = "MenuItemProfessorsEdit";
            this.MenuItemProfessorsEdit.Size = new System.Drawing.Size(180, 22);
            this.MenuItemProfessorsEdit.Text = "Edit...";
            this.MenuItemProfessorsEdit.Click += new System.EventHandler(this.MenuItemProfessorsEdit_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "University";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private MenuStrip menuStrip1;
        private ToolStripMenuItem MenuItemFile;
        private ToolStripMenuItem MenuItemFileLoad;
        private ToolStripMenuItem MenuItemFileSave;
        private ToolStripMenuItem MenuItemProfessors;
        private ToolStripMenuItem MenuItemProfessorsEdit;
    }
}