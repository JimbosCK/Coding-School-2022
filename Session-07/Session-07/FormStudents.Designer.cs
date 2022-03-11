namespace Session_07 {
    partial class FormStudents {
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
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonNew = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonDelete = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.TextEditStudentRegistrationNumber = new DevExpress.XtraEditors.TextEdit();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TextEditStudentName = new DevExpress.XtraEditors.TextEdit();
            this.TextEditStudentAge = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxStudents)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditStudentRegistrationNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditStudentName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditStudentAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            this.SuspendLayout();
            // 
            // ListBoxStudents
            // 
            this.ListBoxStudents.Location = new System.Drawing.Point(25, 12);
            this.ListBoxStudents.Name = "ListBoxStudents";
            this.ListBoxStudents.Size = new System.Drawing.Size(194, 357);
            this.ListBoxStudents.TabIndex = 0;
            this.ListBoxStudents.SelectedIndexChanged += new System.EventHandler(this.listBoxControl1_SelectedIndexChanged);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(566, 331);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(100, 38);
            this.ButtonCancel.TabIndex = 4;
            this.ButtonCancel.Text = "Cancel";
            this.ButtonCancel.Click += new System.EventHandler(this.ButtonCancel_Click);
            // 
            // ButtonNew
            // 
            this.ButtonNew.Location = new System.Drawing.Point(248, 331);
            this.ButtonNew.Name = "ButtonNew";
            this.ButtonNew.Size = new System.Drawing.Size(100, 38);
            this.ButtonNew.TabIndex = 5;
            this.ButtonNew.Text = "New";
            this.ButtonNew.Click += new System.EventHandler(this.ButtonNew_Click);
            // 
            // ButtonDelete
            // 
            this.ButtonDelete.Location = new System.Drawing.Point(354, 331);
            this.ButtonDelete.Name = "ButtonDelete";
            this.ButtonDelete.Size = new System.Drawing.Size(100, 38);
            this.ButtonDelete.TabIndex = 6;
            this.ButtonDelete.Text = "Delete";
            this.ButtonDelete.Click += new System.EventHandler(this.ButtonDelete_Click);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(460, 331);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(100, 38);
            this.ButtonSave.TabIndex = 7;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // TextEditStudentRegistrationNumber
            // 
            this.TextEditStudentRegistrationNumber.Location = new System.Drawing.Point(271, 36);
            this.TextEditStudentRegistrationNumber.Name = "TextEditStudentRegistrationNumber";
            this.TextEditStudentRegistrationNumber.Size = new System.Drawing.Size(114, 20);
            this.TextEditStudentRegistrationNumber.StyleController = this.layoutControl1;
            this.TextEditStudentRegistrationNumber.TabIndex = 8;
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TextEditStudentName);
            this.layoutControl1.Controls.Add(this.TextEditStudentRegistrationNumber);
            this.layoutControl1.Controls.Add(this.TextEditStudentAge);
            this.layoutControl1.Location = new System.Drawing.Point(274, 12);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(397, 193);
            this.layoutControl1.TabIndex = 11;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TextEditStudentName
            // 
            this.TextEditStudentName.Location = new System.Drawing.Point(83, 12);
            this.TextEditStudentName.Name = "TextEditStudentName";
            this.TextEditStudentName.Size = new System.Drawing.Size(302, 20);
            this.TextEditStudentName.StyleController = this.layoutControl1;
            this.TextEditStudentName.TabIndex = 10;
            // 
            // TextEditStudentAge
            // 
            this.TextEditStudentAge.Location = new System.Drawing.Point(83, 36);
            this.TextEditStudentAge.Name = "TextEditStudentAge";
            this.TextEditStudentAge.Size = new System.Drawing.Size(113, 20);
            this.TextEditStudentAge.StyleController = this.layoutControl1;
            this.TextEditStudentAge.TabIndex = 9;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem1,
            this.layoutControlItem2,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(397, 193);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.TextEditStudentAge;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 24);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(188, 24);
            this.layoutControlItem1.Text = "Age";
            this.layoutControlItem1.TextSize = new System.Drawing.Size(59, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 48);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(377, 125);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.TextEditStudentRegistrationNumber;
            this.layoutControlItem2.Location = new System.Drawing.Point(188, 24);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(189, 24);
            this.layoutControlItem2.Text = "Reg Number";
            this.layoutControlItem2.TextSize = new System.Drawing.Size(59, 13);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.TextEditStudentName;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(377, 24);
            this.layoutControlItem3.Text = "Name";
            this.layoutControlItem3.TextSize = new System.Drawing.Size(59, 13);
            // 
            // FormStudents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.layoutControl1);
            this.Controls.Add(this.ButtonSave);
            this.Controls.Add(this.ButtonDelete);
            this.Controls.Add(this.ButtonNew);
            this.Controls.Add(this.ButtonCancel);
            this.Controls.Add(this.ListBoxStudents);
            this.Name = "FormStudents";
            this.Text = "FormStudents";
            this.Load += new System.EventHandler(this.FormStudents_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxStudents)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditStudentRegistrationNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextEditStudentName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditStudentAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.ListBoxControl ListBoxStudents;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonNew;
        private DevExpress.XtraEditors.SimpleButton ButtonDelete;
        private DevExpress.XtraEditors.SimpleButton ButtonSave;
        private DevExpress.XtraEditors.TextEdit TextEditStudentRegistrationNumber;
        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.TextEdit TextEditStudentName;
        private DevExpress.XtraEditors.TextEdit TextEditStudentAge;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}