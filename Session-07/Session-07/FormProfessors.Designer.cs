namespace Session_07 {
    partial class FormProfessor {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.ListBoxProfessors = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TextEditProfessorAge = new DevExpress.XtraEditors.TextEdit();
            this.TextEditProfessorRank = new DevExpress.XtraEditors.TextEdit();
            this.TextEditProfessorName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControl2 = new DevExpress.XtraLayout.LayoutControl();
            this.ButtonDeleteProfessor = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancelProfessor = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSaveProfessor = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonNewProfessor = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlGroup1 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ListBoxCourses = new DevExpress.XtraEditors.ListBoxControl();
            this.ListBoxProfessorsCourses = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControl3 = new DevExpress.XtraLayout.LayoutControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.layoutControlGroup2 = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem9 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxProfessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorRank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).BeginInit();
            this.layoutControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxProfessorsCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).BeginInit();
            this.layoutControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxProfessors
            // 
            this.ListBoxProfessors.Location = new System.Drawing.Point(12, 12);
            this.ListBoxProfessors.Name = "ListBoxProfessors";
            this.ListBoxProfessors.Size = new System.Drawing.Size(168, 128);
            this.ListBoxProfessors.TabIndex = 0;
            this.ListBoxProfessors.SelectedIndexChanged += new System.EventHandler(this.ListBoxProfessors_SelectedIndexChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TextEditProfessorAge);
            this.layoutControl1.Controls.Add(this.TextEditProfessorRank);
            this.layoutControl1.Controls.Add(this.TextEditProfessorName);
            this.layoutControl1.Location = new System.Drawing.Point(266, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(408, 78);
            this.layoutControl1.TabIndex = 1;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TextEditProfessorAge
            // 
            this.TextEditProfessorAge.Location = new System.Drawing.Point(346, 36);
            this.TextEditProfessorAge.Name = "TextEditProfessorAge";
            this.TextEditProfessorAge.Size = new System.Drawing.Size(50, 20);
            this.TextEditProfessorAge.StyleController = this.layoutControl1;
            this.TextEditProfessorAge.TabIndex = 6;
            // 
            // TextEditProfessorRank
            // 
            this.TextEditProfessorRank.Location = new System.Drawing.Point(51, 36);
            this.TextEditProfessorRank.Name = "TextEditProfessorRank";
            this.TextEditProfessorRank.Size = new System.Drawing.Size(252, 20);
            this.TextEditProfessorRank.StyleController = this.layoutControl1;
            this.TextEditProfessorRank.TabIndex = 5;
            // 
            // TextEditProfessorName
            // 
            this.TextEditProfessorName.Location = new System.Drawing.Point(51, 12);
            this.TextEditProfessorName.Name = "TextEditProfessorName";
            this.TextEditProfessorName.Size = new System.Drawing.Size(345, 20);
            this.TextEditProfessorName.StyleController = this.layoutControl1;
            this.TextEditProfessorName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem7});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(408, 78);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.TextEditProfessorName;
            this.layoutControlItem5.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(388, 24);
            this.layoutControlItem5.Text = "Name";
            this.layoutControlItem5.TextSize = new System.Drawing.Size(27, 13);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.TextEditProfessorRank;
            this.layoutControlItem6.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(295, 34);
            this.layoutControlItem6.Text = "Rank";
            this.layoutControlItem6.TextSize = new System.Drawing.Size(27, 13);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.TextEditProfessorAge;
            this.layoutControlItem7.Location = new System.Drawing.Point(295, 24);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(93, 34);
            this.layoutControlItem7.Text = "Age";
            this.layoutControlItem7.TextSize = new System.Drawing.Size(27, 13);
            // 
            // layoutControl2
            // 
            this.layoutControl2.Controls.Add(this.ButtonDeleteProfessor);
            this.layoutControl2.Controls.Add(this.ButtonCancelProfessor);
            this.layoutControl2.Controls.Add(this.ButtonSaveProfessor);
            this.layoutControl2.Controls.Add(this.ButtonNewProfessor);
            this.layoutControl2.Location = new System.Drawing.Point(12, 338);
            this.layoutControl2.Name = "layoutControl2";
            this.layoutControl2.Root = this.layoutControlGroup1;
            this.layoutControl2.Size = new System.Drawing.Size(671, 48);
            this.layoutControl2.TabIndex = 2;
            this.layoutControl2.Text = "layoutControl2";
            // 
            // ButtonDeleteProfessor
            // 
            this.ButtonDeleteProfessor.Location = new System.Drawing.Point(174, 12);
            this.ButtonDeleteProfessor.Name = "ButtonDeleteProfessor";
            this.ButtonDeleteProfessor.Size = new System.Drawing.Size(159, 22);
            this.ButtonDeleteProfessor.StyleController = this.layoutControl2;
            this.ButtonDeleteProfessor.TabIndex = 7;
            this.ButtonDeleteProfessor.Text = "Delete";
            this.ButtonDeleteProfessor.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonCancelProfessor
            // 
            this.ButtonCancelProfessor.Location = new System.Drawing.Point(499, 12);
            this.ButtonCancelProfessor.Name = "ButtonCancelProfessor";
            this.ButtonCancelProfessor.Size = new System.Drawing.Size(160, 22);
            this.ButtonCancelProfessor.StyleController = this.layoutControl2;
            this.ButtonCancelProfessor.TabIndex = 6;
            this.ButtonCancelProfessor.Text = "Cancel";
            this.ButtonCancelProfessor.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSaveProfessor
            // 
            this.ButtonSaveProfessor.Location = new System.Drawing.Point(337, 12);
            this.ButtonSaveProfessor.Name = "ButtonSaveProfessor";
            this.ButtonSaveProfessor.Size = new System.Drawing.Size(158, 22);
            this.ButtonSaveProfessor.StyleController = this.layoutControl2;
            this.ButtonSaveProfessor.TabIndex = 5;
            this.ButtonSaveProfessor.Text = "Save";
            this.ButtonSaveProfessor.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonNewProfessor
            // 
            this.ButtonNewProfessor.Location = new System.Drawing.Point(12, 12);
            this.ButtonNewProfessor.Name = "ButtonNewProfessor";
            this.ButtonNewProfessor.Size = new System.Drawing.Size(158, 22);
            this.ButtonNewProfessor.StyleController = this.layoutControl2;
            this.ButtonNewProfessor.TabIndex = 4;
            this.ButtonNewProfessor.Text = "New";
            this.ButtonNewProfessor.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // layoutControlGroup1
            // 
            this.layoutControlGroup1.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup1.GroupBordersVisible = false;
            this.layoutControlGroup1.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.emptySpaceItem2});
            this.layoutControlGroup1.Name = "layoutControlGroup1";
            this.layoutControlGroup1.Size = new System.Drawing.Size(671, 48);
            this.layoutControlGroup1.TextVisible = false;
            // 
            // ListBoxCourses
            // 
            this.ListBoxCourses.Location = new System.Drawing.Point(12, 146);
            this.ListBoxCourses.Name = "ListBoxCourses";
            this.ListBoxCourses.Size = new System.Drawing.Size(168, 152);
            this.ListBoxCourses.TabIndex = 3;
            // 
            // ListBoxProfessorsCourses
            // 
            this.ListBoxProfessorsCourses.Location = new System.Drawing.Point(12, 29);
            this.ListBoxProfessorsCourses.Name = "ListBoxProfessorsCourses";
            this.ListBoxProfessorsCourses.Size = new System.Drawing.Size(374, 154);
            this.ListBoxProfessorsCourses.StyleController = this.layoutControl3;
            this.ListBoxProfessorsCourses.TabIndex = 4;
            // 
            // layoutControl3
            // 
            this.layoutControl3.Controls.Add(this.labelControl1);
            this.layoutControl3.Controls.Add(this.ListBoxProfessorsCourses);
            this.layoutControl3.Location = new System.Drawing.Point(266, 107);
            this.layoutControl3.Name = "layoutControl3";
            this.layoutControl3.Root = this.layoutControlGroup2;
            this.layoutControl3.Size = new System.Drawing.Size(398, 195);
            this.layoutControl3.TabIndex = 5;
            this.layoutControl3.Text = "layoutControl3";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(12, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(95, 13);
            this.labelControl1.StyleController = this.layoutControl3;
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Professor\'s Courses";
            // 
            // layoutControlGroup2
            // 
            this.layoutControlGroup2.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.layoutControlGroup2.GroupBordersVisible = false;
            this.layoutControlGroup2.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem8,
            this.layoutControlItem9});
            this.layoutControlGroup2.Name = "layoutControlGroup2";
            this.layoutControlGroup2.Size = new System.Drawing.Size(398, 195);
            this.layoutControlGroup2.TextVisible = false;
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.ListBoxProfessorsCourses;
            this.layoutControlItem8.Location = new System.Drawing.Point(0, 17);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(378, 158);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // layoutControlItem9
            // 
            this.layoutControlItem9.Control = this.labelControl1;
            this.layoutControlItem9.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem9.Name = "layoutControlItem9";
            this.layoutControlItem9.Size = new System.Drawing.Size(378, 17);
            this.layoutControlItem9.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem9.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(651, 28);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.layoutControl3);
            this.Controls.Add(this.ListBoxCourses);
            this.Controls.Add(this.layoutControl2);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ListBoxProfessors);
            this.Name = "FormProfessor";
            this.Text = "Professors";
            this.Load += new System.EventHandler(this.FormProfessors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxProfessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorRank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl2)).EndInit();
            this.layoutControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxProfessorsCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl3)).EndInit();
            this.layoutControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlGroup2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl ListBoxProfessors;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControl layoutControl2;
        private DevExpress.XtraEditors.SimpleButton ButtonDeleteProfessor;
        private DevExpress.XtraEditors.SimpleButton ButtonCancelProfessor;
        private DevExpress.XtraEditors.SimpleButton ButtonSaveProfessor;
        private DevExpress.XtraEditors.SimpleButton ButtonNewProfessor;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup1;
        private DevExpress.XtraEditors.TextEdit TextEditProfessorAge;
        private DevExpress.XtraEditors.TextEdit TextEditProfessorRank;
        private DevExpress.XtraEditors.TextEdit TextEditProfessorName;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.ListBoxControl ListBoxCourses;
        private DevExpress.XtraEditors.ListBoxControl ListBoxProfessorsCourses;
        private DevExpress.XtraLayout.LayoutControl layoutControl3;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraLayout.LayoutControlGroup layoutControlGroup2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
    }
}