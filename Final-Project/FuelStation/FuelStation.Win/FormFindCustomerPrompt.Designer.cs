namespace FuelStation.Win
{
    partial class FormFindCustomerPrompt
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
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelErrors = new System.Windows.Forms.Label();
            this.btnNew = new DevExpress.XtraEditors.SimpleButton();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSubmit = new DevExpress.XtraEditors.SimpleButton();
            this.textEditCustomerCardNumber = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ctrlCustomerCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomerCardNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelErrors);
            this.layoutControl1.Controls.Add(this.btnNew);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSubmit);
            this.layoutControl1.Controls.Add(this.textEditCustomerCardNumber);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1091, 399);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelErrors
            // 
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(12, 279);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(1067, 50);
            this.labelErrors.TabIndex = 5;
            // 
            // btnNew
            // 
            this.btnNew.Location = new System.Drawing.Point(396, 333);
            this.btnNew.Name = "btnNew";
            this.btnNew.Size = new System.Drawing.Size(280, 54);
            this.btnNew.StyleController = this.layoutControl1;
            this.btnNew.TabIndex = 4;
            this.btnNew.Text = "Add New...";
            this.btnNew.Click += new System.EventHandler(this.btnNew_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(680, 333);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(399, 54);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 3;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSubmit
            // 
            this.btnSubmit.Location = new System.Drawing.Point(12, 333);
            this.btnSubmit.Name = "btnSubmit";
            this.btnSubmit.Size = new System.Drawing.Size(380, 54);
            this.btnSubmit.StyleController = this.layoutControl1;
            this.btnSubmit.TabIndex = 2;
            this.btnSubmit.Text = "Submit";
            this.btnSubmit.Click += new System.EventHandler(this.btnSubmit_Click);
            // 
            // textEditCustomerCardNumber
            // 
            this.textEditCustomerCardNumber.Location = new System.Drawing.Point(314, 145);
            this.textEditCustomerCardNumber.Name = "textEditCustomerCardNumber";
            this.textEditCustomerCardNumber.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.SimpleMaskManager));
            this.textEditCustomerCardNumber.Properties.MaskSettings.Set("MaskManagerSignature", "ignoreMaskBlank=True");
            this.textEditCustomerCardNumber.Properties.MaskSettings.Set("mask", "\\AAaaaaaaaaaaaaaaaaaa");
            this.textEditCustomerCardNumber.Size = new System.Drawing.Size(765, 48);
            this.textEditCustomerCardNumber.StyleController = this.layoutControl1;
            this.textEditCustomerCardNumber.TabIndex = 0;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ctrlCustomerCode,
            this.emptySpaceItem2,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1091, 399);
            this.Root.TextVisible = false;
            // 
            // ctrlCustomerCode
            // 
            this.ctrlCustomerCode.Control = this.textEditCustomerCardNumber;
            this.ctrlCustomerCode.Location = new System.Drawing.Point(0, 133);
            this.ctrlCustomerCode.Name = "ctrlCustomerCode";
            this.ctrlCustomerCode.Size = new System.Drawing.Size(1071, 52);
            this.ctrlCustomerCode.Text = "Customer Card Number:";
            this.ctrlCustomerCode.TextSize = new System.Drawing.Size(290, 33);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(0, 185);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(1071, 82);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 0);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1071, 133);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSubmit;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 321);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(384, 58);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(668, 321);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(403, 58);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnNew;
            this.layoutControlItem3.Location = new System.Drawing.Point(384, 321);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(284, 58);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.labelErrors;
            this.layoutControlItem4.Location = new System.Drawing.Point(0, 267);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(1071, 54);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // FormFindCustomerPrompt
            // 
            this.AcceptButton = this.btnSubmit;
            this.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1091, 399);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormFindCustomerPrompt";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Find Customer";
            this.VisibleChanged += new System.EventHandler(this.FormFindCustomerPrompt_VisibleChanged);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.textEditCustomerCardNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCustomerCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSubmit;
        private DevExpress.XtraEditors.TextEdit textEditCustomerCardNumber;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem ctrlCustomerCode;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraEditors.SimpleButton btnNew;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private Label labelErrors;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
    }
}