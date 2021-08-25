namespace ZYSimpleAcc.Forms
{
    partial class frmSalesInvoice
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmSalesInvoice));
            this.label5 = new System.Windows.Forms.Label();
            this.txtLastNum = new System.Windows.Forms.TextBox();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.btnsaveandprint = new DevExpress.XtraEditors.SimpleButton();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtTaxPercent = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.StoreInDetailsGrid = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.storeid = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txtTaxValue = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalIN = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.addnewrow = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.txtTranstype = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.invdate = new DevExpress.XtraEditors.DateEdit();
            this.txtTransnotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.textBox10 = new System.Windows.Forms.TextBox();
            this.textBox11 = new System.Windows.Forms.TextBox();
            this.textBox12 = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.textBox13 = new System.Windows.Forms.TextBox();
            this.radioButton1 = new System.Windows.Forms.RadioButton();
            this.radioButton2 = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreInDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 37);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 437;
            this.label5.Text = "رقم آخر فاتورة";
            // 
            // txtLastNum
            // 
            this.txtLastNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLastNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtLastNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastNum.Enabled = false;
            this.txtLastNum.Location = new System.Drawing.Point(15, 34);
            this.txtLastNum.Name = "txtLastNum";
            this.txtLastNum.Size = new System.Drawing.Size(90, 20);
            this.txtLastNum.TabIndex = 436;
            this.txtLastNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnView
            // 
            this.btnView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnView.ImageOptions.Image")));
            this.btnView.Location = new System.Drawing.Point(324, 349);
            this.btnView.Name = "btnView";
            this.btnView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnView.Size = new System.Drawing.Size(63, 22);
            this.btnView.TabIndex = 435;
            this.btnView.Text = "عرض";
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(658, 110);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "وحدة القياس الرئيسية";
            this.toggleSwitch1.Properties.OnText = "وحدة القياس الفرعية";
            this.toggleSwitch1.Size = new System.Drawing.Size(183, 23);
            this.toggleSwitch1.TabIndex = 434;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(116, 112);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton3.Size = new System.Drawing.Size(168, 22);
            this.simpleButton3.TabIndex = 433;
            this.simpleButton3.Text = "الغاء جميع السطور";
            // 
            // btnsaveandprint
            // 
            this.btnsaveandprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveandprint.ImageOptions.Image")));
            this.btnsaveandprint.Location = new System.Drawing.Point(601, 349);
            this.btnsaveandprint.Name = "btnsaveandprint";
            this.btnsaveandprint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsaveandprint.Size = new System.Drawing.Size(86, 22);
            this.btnsaveandprint.TabIndex = 432;
            this.btnsaveandprint.Text = "حفظ وطباعة";
            // 
            // textBox9
            // 
            this.textBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(135, 67);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(49, 20);
            this.textBox9.TabIndex = 431;
            this.textBox9.Text = "%ض.م";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxPercent
            // 
            this.txtTaxPercent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTaxPercent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTaxPercent.Enabled = false;
            this.txtTaxPercent.Location = new System.Drawing.Point(135, 86);
            this.txtTaxPercent.Name = "txtTaxPercent";
            this.txtTaxPercent.Size = new System.Drawing.Size(49, 20);
            this.txtTaxPercent.TabIndex = 430;
            this.txtTaxPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(756, 67);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(84, 20);
            this.textBox8.TabIndex = 429;
            this.textBox8.Text = "عرض المواد";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(446, 67);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 428;
            this.textBox1.Text = "اسم المادة";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(85, 67);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 427;
            this.textBox2.Text = "الضريبة";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(15, 67);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 20);
            this.textBox3.TabIndex = 426;
            this.textBox3.Text = "المجموع";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(235, 67);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 423;
            this.textBox4.Text = "الكمية";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(658, 67);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(97, 20);
            this.textBox5.TabIndex = 425;
            this.textBox5.Text = "رمز الـمادة";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(299, 67);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 20);
            this.textBox6.TabIndex = 422;
            this.textBox6.Text = "سعر الوحدة";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(366, 67);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(79, 20);
            this.textBox7.TabIndex = 424;
            this.textBox7.Text = "وحدة القياس";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(756, 87);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton2.Size = new System.Drawing.Size(84, 20);
            this.simpleButton2.TabIndex = 397;
            this.simpleButton2.Text = "اختيار مادة";
            // 
            // txtItemName
            // 
            this.txtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(446, 86);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(211, 20);
            this.txtItemName.TabIndex = 421;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // StoreInDetailsGrid
            // 
            this.StoreInDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreInDetailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemUnit,
            this.ItemUnitPrice,
            this.itemQty,
            this.storeid,
            this.taxpercent,
            this.itemTax,
            this.itemTotal});
            this.StoreInDetailsGrid.Location = new System.Drawing.Point(10, 140);
            this.StoreInDetailsGrid.MultiSelect = false;
            this.StoreInDetailsGrid.Name = "StoreInDetailsGrid";
            this.StoreInDetailsGrid.ReadOnly = true;
            this.StoreInDetailsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StoreInDetailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoreInDetailsGrid.Size = new System.Drawing.Size(830, 200);
            this.StoreInDetailsGrid.TabIndex = 420;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "رمز المادة";
            this.ItemID.Name = "ItemID";
            this.ItemID.ReadOnly = true;
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "إسم المادة";
            this.ItemName.Name = "ItemName";
            this.ItemName.ReadOnly = true;
            // 
            // ItemUnit
            // 
            this.ItemUnit.HeaderText = "وحدة القياس";
            this.ItemUnit.Name = "ItemUnit";
            this.ItemUnit.ReadOnly = true;
            // 
            // ItemUnitPrice
            // 
            this.ItemUnitPrice.HeaderText = "سعر الوحدة";
            this.ItemUnitPrice.Name = "ItemUnitPrice";
            this.ItemUnitPrice.ReadOnly = true;
            // 
            // itemQty
            // 
            this.itemQty.HeaderText = "الكمية";
            this.itemQty.Name = "itemQty";
            this.itemQty.ReadOnly = true;
            // 
            // storeid
            // 
            this.storeid.HeaderText = "مستودع";
            this.storeid.Name = "storeid";
            this.storeid.ReadOnly = true;
            // 
            // taxpercent
            // 
            this.taxpercent.HeaderText = "ض.م %";
            this.taxpercent.Name = "taxpercent";
            this.taxpercent.ReadOnly = true;
            // 
            // itemTax
            // 
            this.itemTax.HeaderText = "الضريبة";
            this.itemTax.Name = "itemTax";
            this.itemTax.ReadOnly = true;
            // 
            // itemTotal
            // 
            this.itemTotal.HeaderText = "المجموع";
            this.itemTotal.Name = "itemTotal";
            this.itemTotal.ReadOnly = true;
            // 
            // txtTaxValue
            // 
            this.txtTaxValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTaxValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTaxValue.Enabled = false;
            this.txtTaxValue.Location = new System.Drawing.Point(85, 86);
            this.txtTaxValue.Name = "txtTaxValue";
            this.txtTaxValue.Size = new System.Drawing.Size(49, 20);
            this.txtTaxValue.TabIndex = 419;
            this.txtTaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(119, 351);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 418;
            this.label14.Text = "المجموع";
            // 
            // txtTotalIN
            // 
            this.txtTotalIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTotalIN.Enabled = false;
            this.txtTotalIN.Location = new System.Drawing.Point(12, 346);
            this.txtTotalIN.Name = "txtTotalIN";
            this.txtTotalIN.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIN.TabIndex = 417;
            this.txtTotalIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(15, 86);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(69, 20);
            this.txtTotal.TabIndex = 416;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQty
            // 
            this.txtQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtQty.Location = new System.Drawing.Point(235, 86);
            this.txtQty.MaxLength = 8;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(63, 20);
            this.txtQty.TabIndex = 399;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItemID
            // 
            this.txtItemID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtItemID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(658, 86);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(97, 20);
            this.txtItemID.TabIndex = 415;
            this.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnitPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUnitPrice.Location = new System.Drawing.Point(299, 86);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(66, 20);
            this.txtUnitPrice.TabIndex = 398;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnit
            // 
            this.txtUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUnit.Enabled = false;
            this.txtUnit.Location = new System.Drawing.Point(366, 86);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(79, 20);
            this.txtUnit.TabIndex = 414;
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // addnewrow
            // 
            this.addnewrow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addnewrow.ImageOptions.Image")));
            this.addnewrow.Location = new System.Drawing.Point(14, 112);
            this.addnewrow.Name = "addnewrow";
            this.addnewrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addnewrow.Size = new System.Drawing.Size(96, 22);
            this.addnewrow.TabIndex = 400;
            this.addnewrow.Text = "اضافة السطر";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(288, 112);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(168, 22);
            this.simpleButton1.TabIndex = 412;
            this.simpleButton1.Text = "الغاء السطر المحدد";
            // 
            // btnclear
            // 
            this.btnclear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.ImageOptions.Image")));
            this.btnclear.Location = new System.Drawing.Point(179, 349);
            this.btnclear.Name = "btnclear";
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclear.Size = new System.Drawing.Size(135, 22);
            this.btnclear.TabIndex = 411;
            this.btnclear.Text = "تفريغ جميع الحقول";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Location = new System.Drawing.Point(393, 349);
            this.btnclose.Name = "btnclose";
            this.btnclose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclose.Size = new System.Drawing.Size(63, 22);
            this.btnclose.TabIndex = 410;
            this.btnclose.Text = "اغلاق";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.Location = new System.Drawing.Point(693, 349);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsave.Size = new System.Drawing.Size(63, 22);
            this.btnsave.TabIndex = 408;
            this.btnsave.Text = "حفظ";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.Location = new System.Drawing.Point(463, 349);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(63, 22);
            this.btndelete.TabIndex = 409;
            this.btndelete.Text = "إلغاء";
            // 
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(532, 349);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(63, 22);
            this.btnupdate.TabIndex = 407;
            this.btnupdate.Text = "تعديل";
            // 
            // txtTranstype
            // 
            this.txtTranstype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTranstype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTranstype.Enabled = false;
            this.txtTranstype.Location = new System.Drawing.Point(644, 9);
            this.txtTranstype.Name = "txtTranstype";
            this.txtTranstype.Size = new System.Drawing.Size(36, 20);
            this.txtTranstype.TabIndex = 405;
            this.txtTranstype.Text = "SINV";
            this.txtTranstype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(606, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 404;
            this.label3.Text = "التاريخ";
            // 
            // invdate
            // 
            this.invdate.EditValue = null;
            this.invdate.Location = new System.Drawing.Point(463, 10);
            this.invdate.Name = "invdate";
            this.invdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.invdate.Size = new System.Drawing.Size(132, 20);
            this.invdate.TabIndex = 395;
            // 
            // txtTransnotes
            // 
            this.txtTransnotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransnotes.Location = new System.Drawing.Point(331, 38);
            this.txtTransnotes.Name = "txtTransnotes";
            this.txtTransnotes.Size = new System.Drawing.Size(450, 20);
            this.txtTransnotes.TabIndex = 396;
            this.txtTransnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(787, 41);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 403;
            this.label1.Text = "ملاحظات";
            // 
            // txtTransID
            // 
            this.txtTransID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransID.Enabled = false;
            this.txtTransID.Location = new System.Drawing.Point(686, 9);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(90, 20);
            this.txtTransID.TabIndex = 401;
            this.txtTransID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(782, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(59, 13);
            this.label2.TabIndex = 402;
            this.label2.Text = "رقم الفاتورة";
            // 
            // textBox10
            // 
            this.textBox10.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox10.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox10.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox10.Enabled = false;
            this.textBox10.Location = new System.Drawing.Point(185, 67);
            this.textBox10.Name = "textBox10";
            this.textBox10.Size = new System.Drawing.Size(49, 20);
            this.textBox10.TabIndex = 439;
            this.textBox10.Text = "مستودع";
            this.textBox10.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox11
            // 
            this.textBox11.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox11.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox11.Enabled = false;
            this.textBox11.Location = new System.Drawing.Point(185, 86);
            this.textBox11.Name = "textBox11";
            this.textBox11.Size = new System.Drawing.Size(49, 20);
            this.textBox11.TabIndex = 438;
            this.textBox11.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox12
            // 
            this.textBox12.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox12.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox12.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox12.Enabled = false;
            this.textBox12.Location = new System.Drawing.Point(331, 9);
            this.textBox12.Name = "textBox12";
            this.textBox12.Size = new System.Drawing.Size(90, 20);
            this.textBox12.TabIndex = 440;
            this.textBox12.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(424, 12);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 441;
            this.label4.Text = "العميل";
            // 
            // textBox13
            // 
            this.textBox13.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox13.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox13.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textBox13.Enabled = false;
            this.textBox13.Location = new System.Drawing.Point(122, 9);
            this.textBox13.Name = "textBox13";
            this.textBox13.Size = new System.Drawing.Size(208, 20);
            this.textBox13.TabIndex = 442;
            this.textBox13.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // radioButton1
            // 
            this.radioButton1.AutoSize = true;
            this.radioButton1.Location = new System.Drawing.Point(15, 11);
            this.radioButton1.Name = "radioButton1";
            this.radioButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton1.Size = new System.Drawing.Size(44, 17);
            this.radioButton1.TabIndex = 443;
            this.radioButton1.TabStop = true;
            this.radioButton1.Text = "ذمم";
            this.radioButton1.UseVisualStyleBackColor = true;
            // 
            // radioButton2
            // 
            this.radioButton2.AutoSize = true;
            this.radioButton2.Location = new System.Drawing.Point(68, 11);
            this.radioButton2.Name = "radioButton2";
            this.radioButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.radioButton2.Size = new System.Drawing.Size(43, 17);
            this.radioButton2.TabIndex = 444;
            this.radioButton2.TabStop = true;
            this.radioButton2.Text = "نقدا";
            this.radioButton2.UseVisualStyleBackColor = true;
            // 
            // frmSalesInvoice
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(858, 379);
            this.Controls.Add(this.radioButton2);
            this.Controls.Add(this.radioButton1);
            this.Controls.Add(this.textBox13);
            this.Controls.Add(this.textBox12);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox10);
            this.Controls.Add(this.textBox11);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastNum);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.btnsaveandprint);
            this.Controls.Add(this.textBox9);
            this.Controls.Add(this.txtTaxPercent);
            this.Controls.Add(this.textBox8);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.textBox3);
            this.Controls.Add(this.textBox4);
            this.Controls.Add(this.textBox5);
            this.Controls.Add(this.textBox6);
            this.Controls.Add(this.textBox7);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.StoreInDetailsGrid);
            this.Controls.Add(this.txtTaxValue);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotalIN);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.addnewrow);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtTranstype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.invdate);
            this.Controls.Add(this.txtTransnotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Name = "frmSalesInvoice";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "فاتورة بيع";
            this.Load += new System.EventHandler(this.frmSalesInvoice_Load);
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreInDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.invdate.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtLastNum;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnsaveandprint;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtTaxPercent;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.DataGridView StoreInDetailsGrid;
        private System.Windows.Forms.TextBox txtTaxValue;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalIN;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private DevExpress.XtraEditors.SimpleButton addnewrow;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private System.Windows.Forms.TextBox txtTranstype;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit invdate;
        private System.Windows.Forms.TextBox txtTransnotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn storeid;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTotal;
        private System.Windows.Forms.TextBox textBox10;
        private System.Windows.Forms.TextBox textBox11;
        private System.Windows.Forms.TextBox textBox12;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox textBox13;
        private System.Windows.Forms.RadioButton radioButton1;
        private System.Windows.Forms.RadioButton radioButton2;
    }
}