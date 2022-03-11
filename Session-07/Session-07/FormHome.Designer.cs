namespace Session_07 {
    partial class FormHome {
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
            this.MenuItemUniversity = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemUniversityEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProfessors = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemProfessorsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudents = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemStudentsEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCourses = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemCoursesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGrades = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemGradesEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemSchedule = new System.Windows.Forms.ToolStripMenuItem();
            this.MenuItemScheduleEdit = new System.Windows.Forms.ToolStripMenuItem();
            this.memoEdit1 = new DevExpress.XtraEditors.MemoEdit();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemFile,
            this.MenuItemUniversity,
            this.MenuItemProfessors,
            this.MenuItemStudents,
            this.MenuItemCourses,
            this.MenuItemGrades,
            this.MenuItemSchedule});
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
            this.MenuItemFileLoad.Size = new System.Drawing.Size(100, 22);
            this.MenuItemFileLoad.Text = "Load";
            this.MenuItemFileLoad.Click += new System.EventHandler(this.MenuItemFileLoad_Click);
            // 
            // MenuItemFileSave
            // 
            this.MenuItemFileSave.Name = "MenuItemFileSave";
            this.MenuItemFileSave.Size = new System.Drawing.Size(100, 22);
            this.MenuItemFileSave.Text = "Save";
            this.MenuItemFileSave.Click += new System.EventHandler(this.MenuItemFileSave_Click);
            // 
            // MenuItemUniversity
            // 
            this.MenuItemUniversity.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemUniversityEdit});
            this.MenuItemUniversity.Name = "MenuItemUniversity";
            this.MenuItemUniversity.Size = new System.Drawing.Size(71, 20);
            this.MenuItemUniversity.Text = "University";
            // 
            // MenuItemUniversityEdit
            // 
            this.MenuItemUniversityEdit.Name = "MenuItemUniversityEdit";
            this.MenuItemUniversityEdit.Size = new System.Drawing.Size(103, 22);
            this.MenuItemUniversityEdit.Text = "Edit...";
            this.MenuItemUniversityEdit.Click += new System.EventHandler(this.MenuItemUniversityEdit_Click);
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
            this.MenuItemProfessorsEdit.Size = new System.Drawing.Size(103, 22);
            this.MenuItemProfessorsEdit.Text = "Edit...";
            this.MenuItemProfessorsEdit.Click += new System.EventHandler(this.MenuItemProfessorsEdit_Click);
            // 
            // MenuItemStudents
            // 
            this.MenuItemStudents.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemStudentsEdit});
            this.MenuItemStudents.Name = "MenuItemStudents";
            this.MenuItemStudents.Size = new System.Drawing.Size(65, 20);
            this.MenuItemStudents.Text = "Students";
            // 
            // MenuItemStudentsEdit
            // 
            this.MenuItemStudentsEdit.Name = "MenuItemStudentsEdit";
            this.MenuItemStudentsEdit.Size = new System.Drawing.Size(180, 22);
            this.MenuItemStudentsEdit.Text = "Edit...";
            this.MenuItemStudentsEdit.Click += new System.EventHandler(this.MenuItemStudentsEdit_Click);
            // 
            // MenuItemCourses
            // 
            this.MenuItemCourses.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemCoursesEdit});
            this.MenuItemCourses.Name = "MenuItemCourses";
            this.MenuItemCourses.Size = new System.Drawing.Size(61, 20);
            this.MenuItemCourses.Text = "Courses";
            // 
            // MenuItemCoursesEdit
            // 
            this.MenuItemCoursesEdit.Name = "MenuItemCoursesEdit";
            this.MenuItemCoursesEdit.Size = new System.Drawing.Size(103, 22);
            this.MenuItemCoursesEdit.Text = "Edit...";
            // 
            // MenuItemGrades
            // 
            this.MenuItemGrades.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemGradesEdit});
            this.MenuItemGrades.Name = "MenuItemGrades";
            this.MenuItemGrades.Size = new System.Drawing.Size(55, 20);
            this.MenuItemGrades.Text = "Grades";
            // 
            // MenuItemGradesEdit
            // 
            this.MenuItemGradesEdit.Name = "MenuItemGradesEdit";
            this.MenuItemGradesEdit.Size = new System.Drawing.Size(103, 22);
            this.MenuItemGradesEdit.Text = "Edit...";
            // 
            // MenuItemSchedule
            // 
            this.MenuItemSchedule.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.MenuItemScheduleEdit});
            this.MenuItemSchedule.Name = "MenuItemSchedule";
            this.MenuItemSchedule.Size = new System.Drawing.Size(67, 20);
            this.MenuItemSchedule.Text = "Schedule";
            // 
            // MenuItemScheduleEdit
            // 
            this.MenuItemScheduleEdit.Name = "MenuItemScheduleEdit";
            this.MenuItemScheduleEdit.Size = new System.Drawing.Size(103, 22);
            this.MenuItemScheduleEdit.Text = "Edit...";
            // 
            // memoEdit1
            // 
            this.memoEdit1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.memoEdit1.Location = new System.Drawing.Point(0, 24);
            this.memoEdit1.Name = "memoEdit1";
            this.memoEdit1.Size = new System.Drawing.Size(800, 426);
            this.memoEdit1.TabIndex = 1;
            // 
            // FormHome
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.memoEdit1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "FormHome";
            this.Text = "University";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.memoEdit1.Properties)).EndInit();
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
        private DevExpress.XtraEditors.MemoEdit memoEdit1;
        private ToolStripMenuItem MenuItemUniversity;
        private ToolStripMenuItem MenuItemUniversityEdit;
        private ToolStripMenuItem MenuItemStudents;
        private ToolStripMenuItem MenuItemStudentsEdit;
        private ToolStripMenuItem MenuItemCourses;
        private ToolStripMenuItem MenuItemCoursesEdit;
        private ToolStripMenuItem MenuItemGrades;
        private ToolStripMenuItem MenuItemGradesEdit;
        private ToolStripMenuItem MenuItemSchedule;
        private ToolStripMenuItem MenuItemScheduleEdit;
    }
}