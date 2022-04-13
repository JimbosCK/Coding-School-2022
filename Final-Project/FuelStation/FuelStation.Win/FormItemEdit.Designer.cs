namespace FuelStation.Win
{
    partial class FormItemEdit
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
            this.components = new System.ComponentModel.Container();
            this.layoutControl1 = new DevExpress.XtraLayout.LayoutControl();
            this.labelErrors = new System.Windows.Forms.Label();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.lookUpEditItemType = new DevExpress.XtraEditors.LookUpEdit();
            this.textEditDescription = new DevExpress.XtraEditors.TextEdit();
            this.textEditCost = new DevExpress.XtraEditors.TextEdit();
            this.textEditCode = new DevExpress.XtraEditors.TextEdit();
            this.textEditPrice = new DevExpress.XtraEditors.TextEdit();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.ctrlPrice = new DevExpress.XtraLayout.LayoutControlItem();
            this.ctrlCode = new DevExpress.XtraLayout.LayoutControlItem();
            this.ctrlCost = new DevExpress.XtraLayout.LayoutControlItem();
            this.ctrlDescription = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem9 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ctrlItemType = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem8 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem7 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.bsItem = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditItemType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCost.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCode.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelErrors);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.lookUpEditItemType);
            this.layoutControl1.Controls.Add(this.textEditDescription);
            this.layoutControl1.Controls.Add(this.textEditCost);
            this.layoutControl1.Controls.Add(this.textEditCode);
            this.layoutControl1.Controls.Add(this.textEditPrice);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(1517, 784);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelErrors
            // 
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(12, 664);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(1493, 50);
            this.labelErrors.TabIndex = 8;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(1256, 718);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(249, 54);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 7;
            this.btnCancel.Text = "Cancel";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(1033, 718);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(219, 54);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 6;
            this.btnSave.Text = "Save";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // lookUpEditItemType
            // 
            this.lookUpEditItemType.Location = new System.Drawing.Point(156, 136);
            this.lookUpEditItemType.Name = "lookUpEditItemType";
            this.lookUpEditItemType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpEditItemType.Size = new System.Drawing.Size(591, 48);
            this.lookUpEditItemType.StyleController = this.layoutControl1;
            this.lookUpEditItemType.TabIndex = 5;
            // 
            // textEditDescription
            // 
            this.textEditDescription.Location = new System.Drawing.Point(905, 12);
            this.textEditDescription.Name = "textEditDescription";
            this.textEditDescription.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textEditDescription.Properties.MaxLength = 30;
            this.textEditDescription.Size = new System.Drawing.Size(600, 48);
            this.textEditDescription.StyleController = this.layoutControl1;
            this.textEditDescription.TabIndex = 2;
            // 
            // textEditCost
            // 
            this.textEditCost.Location = new System.Drawing.Point(905, 76);
            this.textEditCost.Name = "textEditCost";
            this.textEditCost.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEditCost.Properties.MaskSettings.Set("mask", "c");
            this.textEditCost.Properties.MaskSettings.Set("culture", "el-GR");
            this.textEditCost.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.textEditCost.Size = new System.Drawing.Size(600, 48);
            this.textEditCost.StyleController = this.layoutControl1;
            this.textEditCost.TabIndex = 4;
            // 
            // textEditCode
            // 
            this.textEditCode.Location = new System.Drawing.Point(156, 12);
            this.textEditCode.Name = "textEditCode";
            this.textEditCode.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textEditCode.Properties.MaxLength = 6;
            this.textEditCode.Size = new System.Drawing.Size(591, 48);
            this.textEditCode.StyleController = this.layoutControl1;
            this.textEditCode.TabIndex = 0;
            // 
            // textEditPrice
            // 
            this.textEditPrice.Location = new System.Drawing.Point(156, 74);
            this.textEditPrice.Name = "textEditPrice";
            this.textEditPrice.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.textEditPrice.Properties.MaskSettings.Set("MaskManagerType", typeof(DevExpress.Data.Mask.NumericMaskManager));
            this.textEditPrice.Properties.MaskSettings.Set("mask", "c");
            this.textEditPrice.Properties.MaskSettings.Set("culture", "el-GR");
            this.textEditPrice.Properties.MaskSettings.Set("valueType", typeof(decimal));
            this.textEditPrice.Size = new System.Drawing.Size(591, 48);
            this.textEditPrice.StyleController = this.layoutControl1;
            this.textEditPrice.TabIndex = 3;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.ctrlPrice,
            this.ctrlCode,
            this.ctrlCost,
            this.ctrlDescription,
            this.emptySpaceItem9,
            this.emptySpaceItem3,
            this.emptySpaceItem2,
            this.emptySpaceItem4,
            this.ctrlItemType,
            this.emptySpaceItem8,
            this.emptySpaceItem1,
            this.layoutControlItem1,
            this.layoutControlItem2,
            this.emptySpaceItem7,
            this.layoutControlItem3});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(1517, 784);
            this.Root.TextVisible = false;
            // 
            // ctrlPrice
            // 
            this.ctrlPrice.Control = this.textEditPrice;
            this.ctrlPrice.Location = new System.Drawing.Point(0, 62);
            this.ctrlPrice.Name = "ctrlPrice";
            this.ctrlPrice.Size = new System.Drawing.Size(739, 52);
            this.ctrlPrice.Text = "Price";
            this.ctrlPrice.TextSize = new System.Drawing.Size(132, 33);
            // 
            // ctrlCode
            // 
            this.ctrlCode.Control = this.textEditCode;
            this.ctrlCode.Location = new System.Drawing.Point(0, 0);
            this.ctrlCode.Name = "ctrlCode";
            this.ctrlCode.Size = new System.Drawing.Size(739, 52);
            this.ctrlCode.Text = "Code";
            this.ctrlCode.TextSize = new System.Drawing.Size(132, 33);
            // 
            // ctrlCost
            // 
            this.ctrlCost.Control = this.textEditCost;
            this.ctrlCost.Location = new System.Drawing.Point(749, 64);
            this.ctrlCost.Name = "ctrlCost";
            this.ctrlCost.Size = new System.Drawing.Size(748, 52);
            this.ctrlCost.Text = "Cost";
            this.ctrlCost.TextSize = new System.Drawing.Size(132, 33);
            // 
            // ctrlDescription
            // 
            this.ctrlDescription.Control = this.textEditDescription;
            this.ctrlDescription.CustomizationFormText = "ctrlDescription";
            this.ctrlDescription.Location = new System.Drawing.Point(749, 0);
            this.ctrlDescription.Name = "ctrlDescription";
            this.ctrlDescription.Size = new System.Drawing.Size(748, 52);
            this.ctrlDescription.Text = "Description";
            this.ctrlDescription.TextSize = new System.Drawing.Size(132, 33);
            // 
            // emptySpaceItem9
            // 
            this.emptySpaceItem9.AllowHotTrack = false;
            this.emptySpaceItem9.Location = new System.Drawing.Point(739, 0);
            this.emptySpaceItem9.Name = "emptySpaceItem9";
            this.emptySpaceItem9.Size = new System.Drawing.Size(10, 176);
            this.emptySpaceItem9.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(739, 10);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(749, 52);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(748, 12);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(749, 116);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(748, 60);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ctrlItemType
            // 
            this.ctrlItemType.Control = this.lookUpEditItemType;
            this.ctrlItemType.Location = new System.Drawing.Point(0, 124);
            this.ctrlItemType.Name = "ctrlItemType";
            this.ctrlItemType.Size = new System.Drawing.Size(739, 52);
            this.ctrlItemType.Text = "Item Type";
            this.ctrlItemType.TextSize = new System.Drawing.Size(132, 33);
            // 
            // emptySpaceItem8
            // 
            this.emptySpaceItem8.AllowHotTrack = false;
            this.emptySpaceItem8.Location = new System.Drawing.Point(0, 114);
            this.emptySpaceItem8.Name = "emptySpaceItem8";
            this.emptySpaceItem8.Size = new System.Drawing.Size(739, 10);
            this.emptySpaceItem8.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(0, 176);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(1497, 476);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.btnSave;
            this.layoutControlItem1.Location = new System.Drawing.Point(1021, 706);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(223, 58);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.btnCancel;
            this.layoutControlItem2.Location = new System.Drawing.Point(1244, 706);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(253, 58);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // emptySpaceItem7
            // 
            this.emptySpaceItem7.AllowHotTrack = false;
            this.emptySpaceItem7.Location = new System.Drawing.Point(0, 706);
            this.emptySpaceItem7.Name = "emptySpaceItem7";
            this.emptySpaceItem7.Size = new System.Drawing.Size(1021, 58);
            this.emptySpaceItem7.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.labelErrors;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 652);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(1497, 54);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem5.Name = "emptySpaceItem3";
            this.emptySpaceItem5.Size = new System.Drawing.Size(1497, 27);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(0, 52);
            this.emptySpaceItem6.Name = "emptySpaceItem3";
            this.emptySpaceItem6.Size = new System.Drawing.Size(1497, 27);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // FormItemEdit
            // 
            this.AcceptButton = this.btnSave;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(1517, 784);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormItemEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Item Managment";
            this.Load += new System.EventHandler(this.FormItemEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpEditItemType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCost.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditCode.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.textEditPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPrice)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlCost)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlDescription)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem9)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItem)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private DevExpress.XtraEditors.TextEdit textEditDescription;
        private DevExpress.XtraEditors.TextEdit textEditCost;
        private DevExpress.XtraEditors.TextEdit textEditCode;
        private DevExpress.XtraEditors.TextEdit textEditPrice;
        private DevExpress.XtraLayout.LayoutControlItem ctrlPrice;
        private DevExpress.XtraLayout.LayoutControlItem ctrlCode;
        private DevExpress.XtraLayout.LayoutControlItem ctrlCost;
        private DevExpress.XtraLayout.LayoutControlItem ctrlDescription;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem9;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private BindingSource bsItem;
        private DevExpress.XtraEditors.LookUpEdit lookUpEditItemType;
        private DevExpress.XtraLayout.LayoutControlItem ctrlItemType;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem8;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem7;
        private Label labelErrors;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
    }
}