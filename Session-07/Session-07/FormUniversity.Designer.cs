namespace Session_07 {
    partial class FormUniversity {
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
                YearsInService.Text = "Takis";
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.TextEditUniversityYearsInService = new DevExpress.XtraEditors.TextEdit();
            this.TextEditUniversityName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.YearsInService = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditUniversityYearsInService.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditUniversityName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsInService)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.TextEditUniversityYearsInService);
            this.layoutControl1.Controls.Add(this.TextEditUniversityName);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(800, 450);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // TextEditUniversityYearsInService
            // 
            this.TextEditUniversityYearsInService.Location = new System.Drawing.Point(492, 12);
            this.TextEditUniversityYearsInService.Name = "TextEditUniversityYearsInService";
            this.TextEditUniversityYearsInService.Size = new System.Drawing.Size(296, 20);
            this.TextEditUniversityYearsInService.StyleController = this.layoutControl1;
            this.TextEditUniversityYearsInService.TabIndex = 5;
            // 
            // TextEditUniversityName
            // 
            this.TextEditUniversityName.Location = new System.Drawing.Point(102, 12);
            this.TextEditUniversityName.Name = "TextEditUniversityName";
            this.TextEditUniversityName.Size = new System.Drawing.Size(296, 20);
            this.TextEditUniversityName.StyleController = this.layoutControl1;
            this.TextEditUniversityName.TabIndex = 4;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.Name,
            this.emptySpaceItem1,
            this.YearsInService});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(800, 450);
            this.Root.TextVisible = false;
            // 
            // Name
            // 
            this.Name.Control = this.TextEditUniversityName;
            this.Name.Location = new System.Drawing.Point(0, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(390, 24);
            this.Name.TextSize = new System.Drawing.Size(78, 13);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 24);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(780, 406);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // YearsInService
            // 
            this.YearsInService.AccessibleName = "";
            this.YearsInService.Control = this.TextEditUniversityYearsInService;
            this.YearsInService.Location = new System.Drawing.Point(390, 0);
            this.YearsInService.Name = "YearsInService";
            this.YearsInService.Size = new System.Drawing.Size(390, 24);
            this.YearsInService.Text = "Years In Service";
            this.YearsInService.TextSize = new System.Drawing.Size(78, 13);
            // 
            // FormUniversity
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.layoutControl1);
            this.Text = "FormUniversity";
            this.Load += new System.EventHandler(this.FormUniversity_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.TextEditUniversityYearsInService.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.TextEditUniversityName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.YearsInService)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraEditors.TextEdit TextEditUniversityYearsInService;
        private DevExpress.XtraEditors.TextEdit TextEditUniversityName;
        private DevExpress.XtraLayout.LayoutControlItem Name;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem YearsInService;
        
    }
}