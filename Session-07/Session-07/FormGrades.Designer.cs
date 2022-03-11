namespace Session_07 {
    partial class FormGrades {
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
            this.ListBoxStudents = new DevExpress.XtraEditors.ListBoxControl();
            this.ListBoxGrades = new DevExpress.XtraEditors.ListBoxControl();
            this.ListBoxCourses = new DevExpress.XtraEditors.ListBoxControl();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonAdd = new DevExpress.XtraEditors.SimpleButton();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.TextEditGradeIN = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGrades)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxCourses)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditGradeIN.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxStudents
            // 
            this.ListBoxStudents.Location = new System.Drawing.Point(12, 12);
            this.ListBoxStudents.Name = "ListBoxStudents";
            this.ListBoxStudents.Size = new System.Drawing.Size(225, 244);
            this.ListBoxStudents.TabIndex = 0;
            this.ListBoxStudents.SelectedIndexChanged += new System.EventHandler(this.ListBoxStudents_SelectedIndexChanged);
            // 
            // ListBoxGrades
            // 
            this.ListBoxGrades.Location = new System.Drawing.Point(315, 12);
            this.ListBoxGrades.Name = "ListBoxGrades";
            this.ListBoxGrades.Size = new System.Drawing.Size(336, 244);
            this.ListBoxGrades.TabIndex = 1;
            this.ListBoxGrades.SelectedIndexChanged += new System.EventHandler(this.ListBoxGrades_SelectedIndexChanged);
            // 
            // ListBoxCourses
            // 
            this.ListBoxCourses.Location = new System.Drawing.Point(12, 262);
            this.ListBoxCourses.Name = "ListBoxCourses";
            this.ListBoxCourses.Size = new System.Drawing.Size(225, 116);
            this.ListBoxCourses.TabIndex = 2;
            this.ListBoxCourses.SelectedIndexChanged += new System.EventHandler(this.ListBoxCourses_SelectedIndexChanged);
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.ButtonCancel);
            this.layoutControl1.Controls.Add(this.ButtonSave);
            this.layoutControl1.Controls.Add(this.ButtonDelete);
            this.layoutControl1.Controls.Add(this.ButtonAdd);
            this.layoutControl1.Location = new System.Drawing.Point(323, 287);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(327, 94);
            this.layoutControl1.TabIndex = 3;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(165, 38);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(150, 22);
            this.ButtonCancel.StyleController = this.layoutControl1;
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(12, 38);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(149, 22);
            this.ButtonSave.StyleController = this.layoutControl1;
            this.ButtonSave.TabIndex = 3;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(167, 12);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.ShowFocusRectangle = DevExpress.Utils.DefaultBoolean.False;
            this.ButtonDelete.Size = new System.Drawing.Size(148, 22);
            this.ButtonDelete.StyleController = this.layoutControl1;
            this.ButtonDelete.TabIndex = 2;
            this.ButtonDelete.Text = "Delete Grade";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonAdd
            // 
            this.ButtonAdd.Location = new System.Drawing.Point(12, 12);
            this.ButtonAdd.Name = "ButtonAdd";
            this.ButtonAdd.Size = new System.Drawing.Size(151, 22);
            this.ButtonAdd.StyleController = this.layoutControl1;
            this.ButtonAdd.TabIndex = 0;
            this.ButtonAdd.Text = "New Grade";
            this.ButtonAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(327, 94);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ButtonAdd;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(155, 26);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(153, 52);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(154, 22);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.ButtonDelete;
            this.layoutControlItem2.Location = new System.Drawing.Point(155, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(152, 26);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.ButtonSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 26);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(153, 48);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.ButtonCancel;
            this.layoutControlItem4.Location = new System.Drawing.Point(153, 26);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(154, 26);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // TextEditGradeIN
            // 
            this.TextEditGradeIN.Location = new System.Drawing.Point(243, 327);
            this.TextEditGradeIN.Name = "TextEditGradeIN";
            this.TextEditGradeIN.Size = new System.Drawing.Size(74, 20);
            this.TextEditGradeIN.TabIndex = 4;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(243, 308);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(29, 13);
            this.labelControl1.TabIndex = 5;
            this.labelControl1.Text = "Grade";
            // 
            // FormGrades
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.TextEditGradeIN);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ListBoxGrades);
            this.Controls.Add(this.ListBoxCourses);
            this.Controls.Add(this.ListBoxStudents);
            this.Name = "FormGrades";
            this.Text = "FormGrades";
            this.Load += new System.EventHandler(this.FormGrades_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxGrades)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxCourses)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditGradeIN.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl ListBoxStudents;
        private DevExpress.XtraEditors.ListBoxControl ListBoxGrades;
        private DevExpress.XtraEditors.ListBoxControl ListBoxCourses;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSave;
        private DevExpress.XtraEditors.SimpleButton ButtonDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonAdd;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraEditors.TextEdit TextEditGradeIN;
        private DevExpress.XtraEditors.LabelControl labelControl1;
    }
}