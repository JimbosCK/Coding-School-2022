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
            this.TextEditProfessorRank = new DevExpress.XtraEditors.TextEdit();
            this.TextEditProfessorAge = new DevExpress.XtraEditors.TextEdit();
            this.TextEditProfessorName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.Age = new DevExpress.XtraLayout.LayoutControlItem();
            this.Rank = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).BeginInit();
            this.layoutControl.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorRank.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorAge.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.TextEditProfessorRank);
            this.layoutControl.Controls.Add(this.TextEditProfessorAge);
            this.layoutControl.Controls.Add(this.TextEditProfessorName);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(800, 450);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // TextEditProfessorRank
            // 
            this.TextEditProfessorRank.Location = new System.Drawing.Point(636, 12);
            this.TextEditProfessorRank.Name = "TextEditProfessorRank";
            this.TextEditProfessorRank.Size = new System.Drawing.Size(152, 20);
            this.TextEditProfessorRank.StyleController = this.layoutControl;
            this.TextEditProfessorRank.TabIndex = 6;
            // 
            // TextEditProfessorAge
            // 
            this.TextEditProfessorAge.Location = new System.Drawing.Point(441, 12);
            this.TextEditProfessorAge.Name = "TextEditProfessorAge";
            this.TextEditProfessorAge.Size = new System.Drawing.Size(152, 20);
            this.TextEditProfessorAge.StyleController = this.layoutControl;
            this.TextEditProfessorAge.TabIndex = 5;
            // 
            // TextEditProfessorName
            // 
            this.TextEditProfessorName.Location = new System.Drawing.Point(51, 12);
            this.TextEditProfessorName.Name = "TextEditProfessorName";
            this.TextEditProfessorName.Size = new System.Drawing.Size(347, 20);
            this.TextEditProfessorName.StyleController = this.layoutControl;
            this.TextEditProfessorName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Name,
            this.emptySpaceItem1,
            this.Age,
            this.Rank});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // Name
            // 
            this.Name.Control = this.TextEditProfessorName;
            this.Name.Location = new System.Drawing.Point(0, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(390, 24);
            this.Name.TextSize = new System.Drawing.Size(27, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 406);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // Age
            // 
            this.Age.Control = this.TextEditProfessorAge;
            this.Age.Location = new System.Drawing.Point(390, 0);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(195, 24);
            this.Age.TextSize = new System.Drawing.Size(27, 13);
            // 
            // Rank
            // 
            this.Rank.Control = this.TextEditProfessorRank;
            this.Rank.Location = new System.Drawing.Point(585, 0);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(195, 24);
            this.Rank.TextSize = new System.Drawing.Size(27, 13);
            // 
            // FormProfessor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl);
            this.Text = "Professors";
            this.Load += new System.EventHandler(this.FormProfessors_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl)).EndInit();
            this.layoutControl.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorRank.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorAge.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditProfessorName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Age)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Rank)).EndInit();
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
    }
}