namespace FuelStation.Win
{
    partial class FormTransactionEdit
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
            this.lookUpPaymentMethod = new DevExpress.XtraEditors.LookUpEdit();
            this.labelTotalPrice = new System.Windows.Forms.Label();
            this.btnDelete = new DevExpress.XtraEditors.SimpleButton();
            this.spinEditQuantity = new DevExpress.XtraEditors.SpinEdit();
            this.btnCancel = new DevExpress.XtraEditors.SimpleButton();
            this.btnSave = new DevExpress.XtraEditors.SimpleButton();
            this.btnAddItem = new DevExpress.XtraEditors.SimpleButton();
            this.grdCtrlTransactionLines = new DevExpress.XtraGrid.GridControl();
            this.grdViewTransactionLines = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colItemName = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colQuantity = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colNetValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountPercent = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDiscountValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colTotalValue = new DevExpress.XtraGrid.Columns.GridColumn();
            this.grdCtrlItems = new DevExpress.XtraGrid.GridControl();
            this.grdViewItems = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.colCode = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colDescription = new DevExpress.XtraGrid.Columns.GridColumn();
            this.colItemType = new DevExpress.XtraGrid.Columns.GridColumn();
            this.repositoryItemType = new DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit();
            this.colPrice = new DevExpress.XtraGrid.Columns.GridColumn();
            this.Root = new DevExpress.XtraLayout.LayoutControlGroup();
            this.layoutControlItem1 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem2 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.emptySpaceItem3 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem2 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem3 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem4 = new DevExpress.XtraLayout.LayoutControlItem();
            this.layoutControlItem5 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem4 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.ctrlQuantity = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem5 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem6 = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem1 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem7 = new DevExpress.XtraLayout.LayoutControlItem();
            this.ctrlPaymentMethod = new DevExpress.XtraLayout.LayoutControlItem();
            this.emptySpaceItem6 = new DevExpress.XtraLayout.EmptySpaceItem();
            this.layoutControlItem8 = new DevExpress.XtraLayout.LayoutControlItem();
            this.bsItems = new System.Windows.Forms.BindingSource(this.components);
            this.bsTransactionLines = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).BeginInit();
            this.layoutControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPaymentMethod.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuantity.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTransactionLines)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPaymentMethod)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).BeginInit();
            this.SuspendLayout();
            // 
            // layoutControl1
            // 
            this.layoutControl1.Controls.Add(this.labelErrors);
            this.layoutControl1.Controls.Add(this.lookUpPaymentMethod);
            this.layoutControl1.Controls.Add(this.labelTotalPrice);
            this.layoutControl1.Controls.Add(this.btnDelete);
            this.layoutControl1.Controls.Add(this.spinEditQuantity);
            this.layoutControl1.Controls.Add(this.btnCancel);
            this.layoutControl1.Controls.Add(this.btnSave);
            this.layoutControl1.Controls.Add(this.btnAddItem);
            this.layoutControl1.Controls.Add(this.grdCtrlTransactionLines);
            this.layoutControl1.Controls.Add(this.grdCtrlItems);
            this.layoutControl1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.layoutControl1.Location = new System.Drawing.Point(0, 0);
            this.layoutControl1.Name = "layoutControl1";
            this.layoutControl1.Root = this.Root;
            this.layoutControl1.Size = new System.Drawing.Size(2830, 1377);
            this.layoutControl1.TabIndex = 0;
            this.layoutControl1.Text = "layoutControl1";
            // 
            // labelErrors
            // 
            this.labelErrors.ForeColor = System.Drawing.Color.Red;
            this.labelErrors.Location = new System.Drawing.Point(1031, 1245);
            this.labelErrors.Name = "labelErrors";
            this.labelErrors.Size = new System.Drawing.Size(1787, 62);
            this.labelErrors.TabIndex = 11;
            // 
            // lookUpPaymentMethod
            // 
            this.lookUpPaymentMethod.Location = new System.Drawing.Point(1243, 1126);
            this.lookUpPaymentMethod.Name = "lookUpPaymentMethod";
            this.lookUpPaymentMethod.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.lookUpPaymentMethod.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.lookUpPaymentMethod.Properties.NullText = "";
            this.lookUpPaymentMethod.Properties.ShowNullValuePrompt = ((DevExpress.XtraEditors.ShowNullValuePromptOptions)(((DevExpress.XtraEditors.ShowNullValuePromptOptions.EmptyValue | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorFocused) 
            | DevExpress.XtraEditors.ShowNullValuePromptOptions.EditorReadOnly)));
            this.lookUpPaymentMethod.Size = new System.Drawing.Size(456, 48);
            this.lookUpPaymentMethod.StyleController = this.layoutControl1;
            this.lookUpPaymentMethod.TabIndex = 10;
            // 
            // labelTotalPrice
            // 
            this.labelTotalPrice.Location = new System.Drawing.Point(2420, 1126);
            this.labelTotalPrice.Name = "labelTotalPrice";
            this.labelTotalPrice.Size = new System.Drawing.Size(398, 50);
            this.labelTotalPrice.TabIndex = 9;
            this.labelTotalPrice.Text = "Total: 0 €";
            // 
            // btnDelete
            // 
            this.btnDelete.Location = new System.Drawing.Point(2160, 1311);
            this.btnDelete.Name = "btnDelete";
            this.btnDelete.Size = new System.Drawing.Size(185, 54);
            this.btnDelete.StyleController = this.layoutControl1;
            this.btnDelete.TabIndex = 6;
            this.btnDelete.Text = "Remove Line";
            this.btnDelete.Click += new System.EventHandler(this.btnDelete_Click);
            // 
            // spinEditQuantity
            // 
            this.spinEditQuantity.EditValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditQuantity.Location = new System.Drawing.Point(224, 1259);
            this.spinEditQuantity.Name = "spinEditQuantity";
            this.spinEditQuantity.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.spinEditQuantity.Properties.IsFloatValue = false;
            this.spinEditQuantity.Properties.MaskSettings.Set("mask", "N00");
            this.spinEditQuantity.Properties.MaxValue = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.spinEditQuantity.Properties.MinValue = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.spinEditQuantity.Size = new System.Drawing.Size(154, 48);
            this.spinEditQuantity.StyleController = this.layoutControl1;
            this.spinEditQuantity.TabIndex = 4;
            // 
            // btnCancel
            // 
            this.btnCancel.Location = new System.Drawing.Point(2570, 1311);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(238, 54);
            this.btnCancel.StyleController = this.layoutControl1;
            this.btnCancel.TabIndex = 8;
            this.btnCancel.Text = "Cancel Transaction";
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(2349, 1311);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(217, 54);
            this.btnSave.StyleController = this.layoutControl1;
            this.btnSave.TabIndex = 7;
            this.btnSave.Text = "Save Transaction";
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // btnAddItem
            // 
            this.btnAddItem.Location = new System.Drawing.Point(12, 1311);
            this.btnAddItem.Name = "btnAddItem";
            this.btnAddItem.Size = new System.Drawing.Size(167, 54);
            this.btnAddItem.StyleController = this.layoutControl1;
            this.btnAddItem.TabIndex = 5;
            this.btnAddItem.Text = "Add Item(s)";
            this.btnAddItem.Click += new System.EventHandler(this.btnAddLine_Click);
            // 
            // grdCtrlTransactionLines
            // 
            this.grdCtrlTransactionLines.Location = new System.Drawing.Point(1031, 12);
            this.grdCtrlTransactionLines.MainView = this.grdViewTransactionLines;
            this.grdCtrlTransactionLines.Name = "grdCtrlTransactionLines";
            this.grdCtrlTransactionLines.Size = new System.Drawing.Size(1787, 1110);
            this.grdCtrlTransactionLines.TabIndex = 2;
            this.grdCtrlTransactionLines.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewTransactionLines});
            // 
            // grdViewTransactionLines
            // 
            this.grdViewTransactionLines.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colItemName,
            this.colQuantity,
            this.colItemPrice,
            this.colNetValue,
            this.colDiscountPercent,
            this.colDiscountValue,
            this.colTotalValue});
            this.grdViewTransactionLines.GridControl = this.grdCtrlTransactionLines;
            this.grdViewTransactionLines.Name = "grdViewTransactionLines";
            this.grdViewTransactionLines.OptionsBehavior.Editable = false;
            this.grdViewTransactionLines.OptionsView.ShowGroupPanel = false;
            // 
            // colItemName
            // 
            this.colItemName.Caption = "Item";
            this.colItemName.FieldName = "ItemName";
            this.colItemName.MinWidth = 50;
            this.colItemName.Name = "colItemName";
            this.colItemName.Visible = true;
            this.colItemName.VisibleIndex = 0;
            this.colItemName.Width = 187;
            // 
            // colQuantity
            // 
            this.colQuantity.Caption = "Quantity";
            this.colQuantity.FieldName = "Quantity";
            this.colQuantity.MinWidth = 50;
            this.colQuantity.Name = "colQuantity";
            this.colQuantity.Visible = true;
            this.colQuantity.VisibleIndex = 1;
            this.colQuantity.Width = 187;
            // 
            // colItemPrice
            // 
            this.colItemPrice.Caption = "Price";
            this.colItemPrice.FieldName = "ItemPrice";
            this.colItemPrice.MinWidth = 50;
            this.colItemPrice.Name = "colItemPrice";
            this.colItemPrice.Visible = true;
            this.colItemPrice.VisibleIndex = 2;
            this.colItemPrice.Width = 187;
            // 
            // colNetValue
            // 
            this.colNetValue.Caption = "Net Value";
            this.colNetValue.FieldName = "NetValue";
            this.colNetValue.MinWidth = 50;
            this.colNetValue.Name = "colNetValue";
            this.colNetValue.Visible = true;
            this.colNetValue.VisibleIndex = 3;
            this.colNetValue.Width = 187;
            // 
            // colDiscountPercent
            // 
            this.colDiscountPercent.Caption = "Discount (%)";
            this.colDiscountPercent.FieldName = "DiscountPercent";
            this.colDiscountPercent.MinWidth = 50;
            this.colDiscountPercent.Name = "colDiscountPercent";
            this.colDiscountPercent.Visible = true;
            this.colDiscountPercent.VisibleIndex = 4;
            this.colDiscountPercent.Width = 187;
            // 
            // colDiscountValue
            // 
            this.colDiscountValue.Caption = "Discount Value";
            this.colDiscountValue.FieldName = "DiscountValue";
            this.colDiscountValue.MinWidth = 50;
            this.colDiscountValue.Name = "colDiscountValue";
            this.colDiscountValue.Visible = true;
            this.colDiscountValue.VisibleIndex = 5;
            this.colDiscountValue.Width = 187;
            // 
            // colTotalValue
            // 
            this.colTotalValue.Caption = "Total Value";
            this.colTotalValue.FieldName = "TotalValue";
            this.colTotalValue.MinWidth = 50;
            this.colTotalValue.Name = "colTotalValue";
            this.colTotalValue.Visible = true;
            this.colTotalValue.VisibleIndex = 6;
            this.colTotalValue.Width = 187;
            // 
            // grdCtrlItems
            // 
            this.grdCtrlItems.Location = new System.Drawing.Point(12, 12);
            this.grdCtrlItems.MainView = this.grdViewItems;
            this.grdCtrlItems.Name = "grdCtrlItems";
            this.grdCtrlItems.RepositoryItems.AddRange(new DevExpress.XtraEditors.Repository.RepositoryItem[] {
            this.repositoryItemType});
            this.grdCtrlItems.Size = new System.Drawing.Size(1005, 1243);
            this.grdCtrlItems.TabIndex = 0;
            this.grdCtrlItems.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.grdViewItems});
            // 
            // grdViewItems
            // 
            this.grdViewItems.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.colCode,
            this.colDescription,
            this.colItemType,
            this.colPrice});
            this.grdViewItems.GridControl = this.grdCtrlItems;
            this.grdViewItems.Name = "grdViewItems";
            this.grdViewItems.OptionsBehavior.Editable = false;
            this.grdViewItems.OptionsView.ShowGroupPanel = false;
            // 
            // colCode
            // 
            this.colCode.Caption = "Code";
            this.colCode.FieldName = "Code";
            this.colCode.MinWidth = 50;
            this.colCode.Name = "colCode";
            this.colCode.Visible = true;
            this.colCode.VisibleIndex = 0;
            this.colCode.Width = 187;
            // 
            // colDescription
            // 
            this.colDescription.Caption = "Description";
            this.colDescription.FieldName = "Description";
            this.colDescription.MinWidth = 50;
            this.colDescription.Name = "colDescription";
            this.colDescription.Visible = true;
            this.colDescription.VisibleIndex = 1;
            this.colDescription.Width = 187;
            // 
            // colItemType
            // 
            this.colItemType.Caption = "Type";
            this.colItemType.ColumnEdit = this.repositoryItemType;
            this.colItemType.FieldName = "ItemType";
            this.colItemType.MinWidth = 50;
            this.colItemType.Name = "colItemType";
            this.colItemType.Visible = true;
            this.colItemType.VisibleIndex = 2;
            this.colItemType.Width = 187;
            // 
            // repositoryItemType
            // 
            this.repositoryItemType.AutoHeight = false;
            this.repositoryItemType.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.repositoryItemType.Name = "repositoryItemType";
            // 
            // colPrice
            // 
            this.colPrice.Caption = "Price";
            this.colPrice.FieldName = "Price";
            this.colPrice.MinWidth = 50;
            this.colPrice.Name = "colPrice";
            this.colPrice.Visible = true;
            this.colPrice.VisibleIndex = 3;
            this.colPrice.Width = 187;
            // 
            // Root
            // 
            this.Root.EnableIndentsWithoutBorders = DevExpress.Utils.DefaultBoolean.True;
            this.Root.GroupBordersVisible = false;
            this.Root.Items.AddRange(new DevExpress.XtraLayout.BaseLayoutItem[] {
            this.layoutControlItem1,
            this.emptySpaceItem2,
            this.emptySpaceItem3,
            this.layoutControlItem2,
            this.layoutControlItem3,
            this.layoutControlItem4,
            this.layoutControlItem5,
            this.emptySpaceItem4,
            this.ctrlQuantity,
            this.emptySpaceItem5,
            this.layoutControlItem6,
            this.emptySpaceItem1,
            this.layoutControlItem7,
            this.ctrlPaymentMethod,
            this.emptySpaceItem6,
            this.layoutControlItem8});
            this.Root.Name = "Root";
            this.Root.Size = new System.Drawing.Size(2830, 1377);
            this.Root.TextVisible = false;
            // 
            // layoutControlItem1
            // 
            this.layoutControlItem1.Control = this.grdCtrlItems;
            this.layoutControlItem1.Location = new System.Drawing.Point(0, 0);
            this.layoutControlItem1.Name = "layoutControlItem1";
            this.layoutControlItem1.Size = new System.Drawing.Size(1009, 1247);
            this.layoutControlItem1.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem1.TextVisible = false;
            // 
            // emptySpaceItem2
            // 
            this.emptySpaceItem2.AllowHotTrack = false;
            this.emptySpaceItem2.Location = new System.Drawing.Point(2800, 1299);
            this.emptySpaceItem2.Name = "emptySpaceItem2";
            this.emptySpaceItem2.Size = new System.Drawing.Size(10, 58);
            this.emptySpaceItem2.TextSize = new System.Drawing.Size(0, 0);
            // 
            // emptySpaceItem3
            // 
            this.emptySpaceItem3.AllowHotTrack = false;
            this.emptySpaceItem3.Location = new System.Drawing.Point(1009, 0);
            this.emptySpaceItem3.Name = "emptySpaceItem3";
            this.emptySpaceItem3.Size = new System.Drawing.Size(10, 1247);
            this.emptySpaceItem3.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem2
            // 
            this.layoutControlItem2.Control = this.grdCtrlTransactionLines;
            this.layoutControlItem2.Location = new System.Drawing.Point(1019, 0);
            this.layoutControlItem2.Name = "layoutControlItem2";
            this.layoutControlItem2.Size = new System.Drawing.Size(1791, 1114);
            this.layoutControlItem2.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem2.TextVisible = false;
            // 
            // layoutControlItem3
            // 
            this.layoutControlItem3.Control = this.btnAddItem;
            this.layoutControlItem3.Location = new System.Drawing.Point(0, 1299);
            this.layoutControlItem3.Name = "layoutControlItem3";
            this.layoutControlItem3.Size = new System.Drawing.Size(171, 58);
            this.layoutControlItem3.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem3.TextVisible = false;
            // 
            // layoutControlItem4
            // 
            this.layoutControlItem4.Control = this.btnSave;
            this.layoutControlItem4.Location = new System.Drawing.Point(2337, 1299);
            this.layoutControlItem4.Name = "layoutControlItem4";
            this.layoutControlItem4.Size = new System.Drawing.Size(221, 58);
            this.layoutControlItem4.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem4.TextVisible = false;
            // 
            // layoutControlItem5
            // 
            this.layoutControlItem5.Control = this.btnCancel;
            this.layoutControlItem5.Location = new System.Drawing.Point(2558, 1299);
            this.layoutControlItem5.Name = "layoutControlItem5";
            this.layoutControlItem5.Size = new System.Drawing.Size(242, 58);
            this.layoutControlItem5.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem5.TextVisible = false;
            // 
            // emptySpaceItem4
            // 
            this.emptySpaceItem4.AllowHotTrack = false;
            this.emptySpaceItem4.Location = new System.Drawing.Point(171, 1299);
            this.emptySpaceItem4.Name = "emptySpaceItem4";
            this.emptySpaceItem4.Size = new System.Drawing.Size(1977, 58);
            this.emptySpaceItem4.TextSize = new System.Drawing.Size(0, 0);
            // 
            // ctrlQuantity
            // 
            this.ctrlQuantity.Control = this.spinEditQuantity;
            this.ctrlQuantity.Location = new System.Drawing.Point(0, 1247);
            this.ctrlQuantity.Name = "ctrlQuantity";
            this.ctrlQuantity.Size = new System.Drawing.Size(370, 52);
            this.ctrlQuantity.Text = "Quantity";
            this.ctrlQuantity.TextSize = new System.Drawing.Size(200, 33);
            // 
            // emptySpaceItem5
            // 
            this.emptySpaceItem5.AllowHotTrack = false;
            this.emptySpaceItem5.Location = new System.Drawing.Point(370, 1247);
            this.emptySpaceItem5.Name = "emptySpaceItem5";
            this.emptySpaceItem5.Size = new System.Drawing.Size(649, 52);
            this.emptySpaceItem5.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem6
            // 
            this.layoutControlItem6.Control = this.btnDelete;
            this.layoutControlItem6.Location = new System.Drawing.Point(2148, 1299);
            this.layoutControlItem6.Name = "layoutControlItem6";
            this.layoutControlItem6.Size = new System.Drawing.Size(189, 58);
            this.layoutControlItem6.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem6.TextVisible = false;
            // 
            // emptySpaceItem1
            // 
            this.emptySpaceItem1.AllowHotTrack = false;
            this.emptySpaceItem1.Location = new System.Drawing.Point(1691, 1114);
            this.emptySpaceItem1.Name = "emptySpaceItem1";
            this.emptySpaceItem1.Size = new System.Drawing.Size(717, 54);
            this.emptySpaceItem1.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem7
            // 
            this.layoutControlItem7.Control = this.labelTotalPrice;
            this.layoutControlItem7.Location = new System.Drawing.Point(2408, 1114);
            this.layoutControlItem7.Name = "layoutControlItem7";
            this.layoutControlItem7.Size = new System.Drawing.Size(402, 54);
            this.layoutControlItem7.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem7.TextVisible = false;
            // 
            // ctrlPaymentMethod
            // 
            this.ctrlPaymentMethod.Control = this.lookUpPaymentMethod;
            this.ctrlPaymentMethod.CustomizationFormText = "ctrlPaymentMethod";
            this.ctrlPaymentMethod.Location = new System.Drawing.Point(1019, 1114);
            this.ctrlPaymentMethod.Name = "ctrlPaymentMethod";
            this.ctrlPaymentMethod.Size = new System.Drawing.Size(672, 54);
            this.ctrlPaymentMethod.Text = "Payment Method";
            this.ctrlPaymentMethod.TextSize = new System.Drawing.Size(200, 33);
            // 
            // emptySpaceItem6
            // 
            this.emptySpaceItem6.AllowHotTrack = false;
            this.emptySpaceItem6.Location = new System.Drawing.Point(1019, 1168);
            this.emptySpaceItem6.Name = "emptySpaceItem6";
            this.emptySpaceItem6.Size = new System.Drawing.Size(1791, 65);
            this.emptySpaceItem6.TextSize = new System.Drawing.Size(0, 0);
            // 
            // layoutControlItem8
            // 
            this.layoutControlItem8.Control = this.labelErrors;
            this.layoutControlItem8.Location = new System.Drawing.Point(1019, 1233);
            this.layoutControlItem8.Name = "layoutControlItem8";
            this.layoutControlItem8.Size = new System.Drawing.Size(1791, 66);
            this.layoutControlItem8.TextSize = new System.Drawing.Size(0, 0);
            this.layoutControlItem8.TextVisible = false;
            // 
            // FormTransactionEdit
            // 
            this.AcceptButton = this.btnAddItem;
            this.Appearance.BackColor = System.Drawing.Color.LightGray;
            this.Appearance.Options.UseBackColor = true;
            this.AutoScaleDimensions = new System.Drawing.SizeF(15F, 33F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.CancelButton = this.btnCancel;
            this.ClientSize = new System.Drawing.Size(2830, 1377);
            this.Controls.Add(this.layoutControl1);
            this.Name = "FormTransactionEdit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "New Transaction";
            this.Load += new System.EventHandler(this.FormTransactionEdit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.layoutControl1)).EndInit();
            this.layoutControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.lookUpPaymentMethod.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.spinEditQuantity.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewTransactionLines)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdCtrlItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.grdViewItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.repositoryItemType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Root)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlQuantity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ctrlPaymentMethod)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emptySpaceItem6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.layoutControlItem8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsItems)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bsTransactionLines)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraLayout.LayoutControl layoutControl1;
        private DevExpress.XtraEditors.SpinEdit spinEditQuantity;
        private DevExpress.XtraEditors.SimpleButton btnCancel;
        private DevExpress.XtraEditors.SimpleButton btnSave;
        private DevExpress.XtraEditors.SimpleButton btnAddItem;
        private DevExpress.XtraGrid.GridControl grdCtrlTransactionLines;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewTransactionLines;
        private DevExpress.XtraGrid.GridControl grdCtrlItems;
        private DevExpress.XtraGrid.Views.Grid.GridView grdViewItems;
        private DevExpress.XtraLayout.LayoutControlGroup Root;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem1;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem2;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem2;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem3;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem4;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem5;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem4;
        private DevExpress.XtraLayout.LayoutControlItem ctrlQuantity;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem5;
        private BindingSource bsItems;
        private BindingSource bsTransactionLines;
        private DevExpress.XtraGrid.Columns.GridColumn colCode;
        private DevExpress.XtraGrid.Columns.GridColumn colDescription;
        private DevExpress.XtraGrid.Columns.GridColumn colItemType;
        private DevExpress.XtraGrid.Columns.GridColumn colPrice;
        private DevExpress.XtraEditors.Repository.RepositoryItemLookUpEdit repositoryItemType;
        private DevExpress.XtraEditors.SimpleButton btnDelete;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem6;
        private DevExpress.XtraGrid.Columns.GridColumn colItemName;
        private DevExpress.XtraGrid.Columns.GridColumn colQuantity;
        private DevExpress.XtraGrid.Columns.GridColumn colItemPrice;
        private DevExpress.XtraGrid.Columns.GridColumn colNetValue;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountPercent;
        private DevExpress.XtraGrid.Columns.GridColumn colDiscountValue;
        private DevExpress.XtraGrid.Columns.GridColumn colTotalValue;
        private DevExpress.XtraLayout.EmptySpaceItem emptySpaceItem6;
        private Label labelTotalPrice;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem7;
        private DevExpress.XtraEditors.LookUpEdit lookUpPaymentMethod;
        private DevExpress.XtraLayout.LayoutControlItem ctrlPaymentMethod;
        private Label labelErrors;
        private DevExpress.XtraLayout.LayoutControlItem layoutControlItem8;
    }
}