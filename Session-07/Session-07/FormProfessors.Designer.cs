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
            this.layoutControl = new DevExpress.XtraLayout.LayoutControl();
            this.ListBoxProfessors = new DevExpress.XtraEditors.ListBoxControl();
            this.TextEditProfessorRank = new DevExpress.XtraEditors.TextEdit();
            this.TextEditProfessorAge = new DevExpress.XtraEditors.TextEdit();
            this.TextEditProfessorName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Rank = new DevExpress.XtraLayout.LayoutControlItem();
            this.Age = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Name = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxProfessors)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorRank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.ListBoxProfessors);
            this.layoutControl.Controls.Add(this.TextEditProfessorRank);
            this.layoutControl.Controls.Add(this.TextEditProfessorAge);
            this.layoutControl.Controls.Add(this.TextEditProfessorName);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(686, 390);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // ListBoxProfessors
            // 
            this.ListBoxProfessors.Location = new System.Drawing.Point(12, 12);
            this.ListBoxProfessors.Name = "ListBoxProfessors";
            this.ListBoxProfessors.Size = new System.Drawing.Size(329, 366);
            this.ListBoxProfessors.StyleController = this.layoutControl;
            this.ListBoxProfessors.TabIndex = 0;
            this.ListBoxProfessors.SelectedIndexChanged += new System.EventHandler(this.ListBoxProfessors_SelectedIndexChanged);
            // 
            // TextEditProfessorRank
            // 
            this.TextEditProfessorRank.Location = new System.Drawing.Point(429, 36);
            this.TextEditProfessorRank.Name = "TextEditProfessorRank";
            this.TextEditProfessorRank.Size = new System.Drawing.Size(118, 20);
            this.TextEditProfessorRank.StyleController = this.layoutControl;
            this.TextEditProfessorRank.TabIndex = 2;
            // 
            // TextEditProfessorAge
            // 
            this.TextEditProfessorAge.Location = new System.Drawing.Point(590, 36);
            this.TextEditProfessorAge.Name = "TextEditProfessorAge";
            this.TextEditProfessorAge.Size = new System.Drawing.Size(84, 20);
            this.TextEditProfessorAge.StyleController = this.layoutControl;
            this.TextEditProfessorAge.TabIndex = 3;
            // 
            // TextEditProfessorName
            // 
            this.TextEditProfessorName.Location = new System.Drawing.Point(429, 12);
            this.TextEditProfessorName.Name = "TextEditProfessorName";
            this.TextEditProfessorName.Size = new System.Drawing.Size(245, 20);
            this.TextEditProfessorName.StyleController = this.layoutControl;
            this.TextEditProfessorName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.Rank,
            this.Age,
            this.emptySpaceItem1,
            this.Name});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(686, 390);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ListBoxProfessors;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(333, 370);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Rank
            // 
            this.Rank.Control = this.TextEditProfessorRank;
            this.Rank.Location = new System.Drawing.Point(378, 24);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(161, 346);
            this.Rank.TextSize = new System.Drawing.Size(27, 13);
            // 
            // Age
            // 
            this.Age.Control = this.TextEditProfessorAge;
            this.Age.Location = new System.Drawing.Point(539, 24);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(127, 346);
            this.Age.TextSize = new System.Drawing.Size(27, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(333, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(45, 370);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Name
            // 
            this.Name.Control = this.TextEditProfessorName;
            this.Name.Location = new System.Drawing.Point(378, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(288, 24);
            this.Name.TextSize = new System.Drawing.Size(27, 13);
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(686, 390);
            this.Controls.Add(this.layoutControl);
            this.Text = "Professors";
            this.Load += new System.EventHandler(this.FormProfessors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ListBoxProfessors)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorRank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.TextEdit TextEditProfessorRank;
        private DevExpress.XtraEditors.TextEdit TextEditProfessorAge;
        private DevExpress.XtraEditors.TextEdit TextEditProfessorName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem Name;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem Age;
        private DevExpress.XtraLayout.LayoutControlItem Rank;
        private DevExpress.XtraEditors.ListBoxControl ListBoxProfessors;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
    }
}