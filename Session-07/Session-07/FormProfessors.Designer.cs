﻿namespace Session_07 {
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
            this.ButtonSave = new DevExpress.XtraEditors.SimpleButton();
            this.ButtonCancel = new DevExpress.XtraEditors.SimpleButton();
            this.TextEditProfessorRank = new DevExpress.XtraEditors.TextEdit();
            this.TextEditProfessorAge = new DevExpress.XtraEditors.TextEdit();
            this.TextEditProfessorName = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.Rank = new DevExpress.XtraLayout.LayoutControlItem();
            this.Age = new DevExpress.XtraLayout.LayoutControlItem();
            this.Name = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
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
            ((System.ComponentModel.ISupportInitialize)(this.Name)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl
            // 
            this.layoutControl.Controls.Add(this.simpleButton3);
            this.layoutControl.Controls.Add(this.simpleButton2);
            this.layoutControl.Controls.Add(this.ListBoxProfessors);
            this.layoutControl.Controls.Add(this.ButtonSave);
            this.layoutControl.Controls.Add(this.ButtonCancel);
            this.layoutControl.Controls.Add(this.TextEditProfessorRank);
            this.layoutControl.Controls.Add(this.TextEditProfessorAge);
            this.layoutControl.Controls.Add(this.TextEditProfessorName);
            this.layoutControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl.Location = new System.Drawing.Point(0, 0);
            this.layoutControl.Name = "layoutControl";
            this.layoutControl.OptionsCustomizationForm.DesignTimeCustomizationFormPositionAndSize = new System.Drawing.Rectangle(985, 129, 650, 400);
            this.layoutControl.Root = this.Root;
            this.layoutControl.Size = new System.Drawing.Size(686, 390);
            this.layoutControl.TabIndex = 0;
            this.layoutControl.Text = "layoutControl";
            // 
            // ListBoxProfessors
            // 
            this.ListBoxProfessors.Location = new System.Drawing.Point(12, 12);
            this.ListBoxProfessors.Name = "ListBoxProfessors";
            this.ListBoxProfessors.Size = new System.Drawing.Size(218, 44);
            this.ListBoxProfessors.StyleController = this.layoutControl;
            this.ListBoxProfessors.TabIndex = 0;
            this.ListBoxProfessors.SelectedIndexChanged += new System.EventHandler(this.ListBoxProfessors_SelectedIndexChanged);
            // 
            // ButtonSave
            // 
            this.ButtonSave.Location = new System.Drawing.Point(12, 356);
            this.ButtonSave.Name = "ButtonSave";
            this.ButtonSave.Size = new System.Drawing.Size(162, 22);
            this.ButtonSave.StyleController = this.layoutControl;
            this.ButtonSave.TabIndex = 6;
            this.ButtonSave.Text = "Save";
            this.ButtonSave.Click += new System.EventHandler(this.ButtonSave_Click);
            // 
            // ButtonCancel
            // 
            this.ButtonCancel.Location = new System.Drawing.Point(511, 356);
            this.ButtonCancel.Name = "ButtonCancel";
            this.ButtonCancel.Size = new System.Drawing.Size(163, 22);
            this.ButtonCancel.StyleController = this.layoutControl;
            this.ButtonCancel.TabIndex = 5;
            this.ButtonCancel.Text = "Cancel";
            // 
            // TextEditProfessorRank
            // 
            this.TextEditProfessorRank.Location = new System.Drawing.Point(273, 36);
            this.TextEditProfessorRank.Name = "TextEditProfessorRank";
            this.TextEditProfessorRank.Size = new System.Drawing.Size(179, 20);
            this.TextEditProfessorRank.StyleController = this.layoutControl;
            this.TextEditProfessorRank.TabIndex = 3;
            // 
            // TextEditProfessorAge
            // 
            this.TextEditProfessorAge.Location = new System.Drawing.Point(495, 36);
            this.TextEditProfessorAge.Name = "TextEditProfessorAge";
            this.TextEditProfessorAge.Size = new System.Drawing.Size(179, 20);
            this.TextEditProfessorAge.StyleController = this.layoutControl;
            this.TextEditProfessorAge.TabIndex = 4;
            // 
            // TextEditProfessorName
            // 
            this.TextEditProfessorName.Location = new System.Drawing.Point(273, 12);
            this.TextEditProfessorName.Name = "TextEditProfessorName";
            this.TextEditProfessorName.Size = new System.Drawing.Size(401, 20);
            this.TextEditProfessorName.StyleController = this.layoutControl;
            this.TextEditProfessorName.TabIndex = 2;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.Rank,
            this.Name,
            this.layoutControlItem3,
            this.layoutControlItem5,
            this.layoutControlItem6,
            this.layoutControlItem2,
            this.Age});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(686, 390);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.ListBoxProfessors;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.MinSize = new System.Drawing.Size(54, 4);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(222, 48);
            this.layoutControlItem1.SizeConstraintsType = DevExpress.XtraLayout.SizeConstraintsType.Custom;
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // Rank
            // 
            this.Rank.Control = this.TextEditProfessorRank;
            this.Rank.Location = new System.Drawing.Point(222, 24);
            this.Rank.Name = "Rank";
            this.Rank.Size = new System.Drawing.Size(222, 24);
            this.Rank.TextSize = new System.Drawing.Size(27, 13);
            // 
            // Age
            // 
            this.Age.Control = this.TextEditProfessorAge;
            this.Age.Location = new System.Drawing.Point(444, 24);
            this.Age.Name = "Age";
            this.Age.Size = new System.Drawing.Size(222, 24);
            this.Age.TextSize = new System.Drawing.Size(27, 13);
            // 
            // Name
            // 
            this.Name.Control = this.TextEditProfessorName;
            this.Name.Location = new System.Drawing.Point(222, 0);
            this.Name.Name = "Name";
            this.Name.Size = new System.Drawing.Size(444, 24);
            this.Name.TextSize = new System.Drawing.Size(27, 13);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.layoutControlItem2.Control = this.ButtonCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(499, 48);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(167, 322);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.layoutControlItem3.Control = this.ButtonSave;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 48);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(166, 322);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(344, 356);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(163, 22);
            this.simpleButton2.StyleController = this.layoutControl;
            this.simpleButton2.TabIndex = 8;
            this.simpleButton2.Text = "simpleButton2";
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.layoutControlItem5.Control = this.simpleButton2;
            this.layoutControlItem5.Location = new System.Drawing.Point(332, 48);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(167, 322);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(178, 356);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(162, 22);
            this.simpleButton3.StyleController = this.layoutControl;
            this.simpleButton3.TabIndex = 7;
            this.simpleButton3.Text = "simpleButton3";
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.ContentVertAlignment = DevExpress.Utils.VertAlignment.Bottom;
            this.layoutControlItem6.Control = this.simpleButton3;
            this.layoutControlItem6.Location = new System.Drawing.Point(166, 48);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(166, 322);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
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
            ((System.ComponentModel.ISupportInitialize)(this.Name)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl;
        private DevExpress.XtraEditors.TextEdit TextEditProfessorRank;
        private DevExpress.XtraEditors.TextEdit TextEditProfessorAge;
        private DevExpress.XtraEditors.TextEdit TextEditProfessorName;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem Name;
        private DevExpress.XtraLayout.LayoutControlItem Age;
        private DevExpress.XtraLayout.LayoutControlItem Rank;
        private DevExpress.XtraEditors.ListBoxControl ListBoxProfessors;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraEditors.SimpleButton ButtonCancel;
        private DevExpress.XtraEditors.SimpleButton ButtonSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
    }
}