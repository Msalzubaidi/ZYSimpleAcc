namespace ZYSimpleAcc.Forms
{
    partial class frmStoreOut
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreOut));
            this.btnaddnewrow = new DevExpress.XtraEditors.SimpleButton();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txttransType = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.datetransdate = new DevExpress.XtraEditors.DateEdit();
            this.transnotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtstoreid = new System.Windows.Forms.TextBox();
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
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.txtTaxValue = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.btnsaveandprint = new DevExpress.XtraEditors.SimpleButton();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTotalout = new System.Windows.Forms.TextBox();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.StoreoutDetailsGrid = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.txtLastNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreoutDetailsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // btnaddnewrow
            // 
            this.btnaddnewrow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnaddnewrow.ImageOptions.Image")));
            this.btnaddnewrow.Location = new System.Drawing.Point(4, 109);
            this.btnaddnewrow.Name = "btnaddnewrow";
            this.btnaddnewrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnaddnewrow.Size = new System.Drawing.Size(119, 22);
            this.btnaddnewrow.TabIndex = 5;
            this.btnaddnewrow.Text = "اضافة السطر";
            this.btnaddnewrow.Click += new System.EventHandler(this.btnaddnewrow_Click);
            // 
            // btnclear
            // 
            this.btnclear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.ImageOptions.Image")));
            this.btnclear.Location = new System.Drawing.Point(169, 367);
            this.btnclear.Name = "btnclear";
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclear.Size = new System.Drawing.Size(142, 22);
            this.btnclear.TabIndex = 362;
            this.btnclear.Text = "تفريغ الحقول";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Location = new System.Drawing.Point(398, 366);
            this.btnclose.Name = "btnclose";
            this.btnclose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclose.Size = new System.Drawing.Size(67, 22);
            this.btnclose.TabIndex = 361;
            this.btnclose.Text = "اغلاق";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.Location = new System.Drawing.Point(703, 367);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsave.Size = new System.Drawing.Size(68, 22);
            this.btnsave.TabIndex = 359;
            this.btnsave.Text = "حفظ";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.Location = new System.Drawing.Point(472, 367);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(68, 22);
            this.btndelete.TabIndex = 360;
            this.btndelete.Text = "إلغاء";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // cboStore
            // 
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(418, 9);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(100, 21);
            this.cboStore.TabIndex = 0;
            this.cboStore.TextChanged += new System.EventHandler(this.cboStore_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(524, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 355;
            this.label4.Text = "المستودع";
            // 
            // txttransType
            // 
            this.txttransType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txttransType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txttransType.Enabled = false;
            this.txttransType.Location = new System.Drawing.Point(583, 10);
            this.txttransType.Name = "txttransType";
            this.txttransType.Size = new System.Drawing.Size(40, 20);
            this.txttransType.TabIndex = 354;
            this.txttransType.Text = "SOUT";
            this.txttransType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(315, 11);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 353;
            this.label3.Text = "التاريخ";
            // 
            // datetransdate
            // 
            this.datetransdate.EditValue = null;
            this.datetransdate.Location = new System.Drawing.Point(182, 8);
            this.datetransdate.Name = "datetransdate";
            this.datetransdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetransdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetransdate.Size = new System.Drawing.Size(127, 20);
            this.datetransdate.TabIndex = 1;
            // 
            // transnotes
            // 
            this.transnotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.transnotes.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.transnotes.Location = new System.Drawing.Point(182, 34);
            this.transnotes.Name = "transnotes";
            this.transnotes.Size = new System.Drawing.Size(538, 20);
            this.transnotes.TabIndex = 350;
            this.transnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 351;
            this.label1.Text = "ملاحظات";
            // 
            // txtTransID
            // 
            this.txtTransID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTransID.Enabled = false;
            this.txtTransID.Location = new System.Drawing.Point(629, 10);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(90, 20);
            this.txtTransID.TabIndex = 348;
            this.txtTransID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTransID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransID_KeyPress);
            this.txtTransID.Leave += new System.EventHandler(this.txtTransID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(725, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 349;
            this.label2.Text = "رقم السند";
            // 
            // txtstoreid
            // 
            this.txtstoreid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtstoreid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtstoreid.Enabled = false;
            this.txtstoreid.Location = new System.Drawing.Point(367, 10);
            this.txtstoreid.Name = "txtstoreid";
            this.txtstoreid.Size = new System.Drawing.Size(47, 20);
            this.txtstoreid.TabIndex = 370;
            this.txtstoreid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(127, 64);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(49, 20);
            this.textBox9.TabIndex = 405;
            this.textBox9.Text = "%ض.م";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxPercent
            // 
            this.txtTaxPercent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTaxPercent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTaxPercent.Enabled = false;
            this.txtTaxPercent.Location = new System.Drawing.Point(127, 83);
            this.txtTaxPercent.Name = "txtTaxPercent";
            this.txtTaxPercent.Size = new System.Drawing.Size(49, 20);
            this.txtTaxPercent.TabIndex = 404;
            this.txtTaxPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(698, 64);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(84, 20);
            this.textBox8.TabIndex = 403;
            this.textBox8.Text = "عرض المواد";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(388, 64);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 402;
            this.textBox1.Text = "اسم المادة";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(77, 64);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 401;
            this.textBox2.Text = "الضريبة";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(7, 64);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 20);
            this.textBox3.TabIndex = 400;
            this.textBox3.Text = "المجموع";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(177, 64);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 397;
            this.textBox4.Text = "الكمية";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(600, 64);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(97, 20);
            this.textBox5.TabIndex = 399;
            this.textBox5.Text = "رمز الـمادة";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(241, 64);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 20);
            this.textBox6.TabIndex = 396;
            this.textBox6.Text = "سعر الوحدة";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(308, 64);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(79, 20);
            this.textBox7.TabIndex = 398;
            this.textBox7.Text = "وحدة القياس";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton3
            // 
            this.simpleButton3.Location = new System.Drawing.Point(698, 84);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton3.Size = new System.Drawing.Size(84, 20);
            this.simpleButton3.TabIndex = 2;
            this.simpleButton3.Text = "اختيار مادة";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // txtItemName
            // 
            this.txtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(388, 83);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(211, 20);
            this.txtItemName.TabIndex = 395;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxValue
            // 
            this.txtTaxValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTaxValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTaxValue.Enabled = false;
            this.txtTaxValue.Location = new System.Drawing.Point(77, 83);
            this.txtTaxValue.Name = "txtTaxValue";
            this.txtTaxValue.Size = new System.Drawing.Size(49, 20);
            this.txtTaxValue.TabIndex = 394;
            this.txtTaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(7, 83);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(69, 20);
            this.txtTotal.TabIndex = 393;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQty
            // 
            this.txtQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtQty.Location = new System.Drawing.Point(177, 83);
            this.txtQty.MaxLength = 8;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(63, 20);
            this.txtQty.TabIndex = 4;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // txtItemID
            // 
            this.txtItemID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtItemID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(600, 83);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(97, 20);
            this.txtItemID.TabIndex = 392;
            this.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnitPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUnitPrice.Location = new System.Drawing.Point(241, 83);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(66, 20);
            this.txtUnitPrice.TabIndex = 3;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            this.txtUnitPrice.Leave += new System.EventHandler(this.txtUnitPrice_Leave);
            // 
            // txtUnit
            // 
            this.txtUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUnit.Enabled = false;
            this.txtUnit.Location = new System.Drawing.Point(308, 83);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(79, 20);
            this.txtUnit.TabIndex = 391;
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(4, 12);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "وحدة القياس الرئيسية";
            this.toggleSwitch1.Properties.OnText = "وحدة القياس الفرعية";
            this.toggleSwitch1.Size = new System.Drawing.Size(169, 23);
            this.toggleSwitch1.TabIndex = 406;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(129, 109);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton4.Size = new System.Drawing.Size(168, 22);
            this.simpleButton4.TabIndex = 408;
            this.simpleButton4.Text = "الغاء جميع السطور";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(301, 109);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton5.Size = new System.Drawing.Size(168, 22);
            this.simpleButton5.TabIndex = 407;
            this.simpleButton5.Text = "الغاء السطر المحدد";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // btnsaveandprint
            // 
            this.btnsaveandprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveandprint.ImageOptions.Image")));
            this.btnsaveandprint.Location = new System.Drawing.Point(615, 367);
            this.btnsaveandprint.Name = "btnsaveandprint";
            this.btnsaveandprint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsaveandprint.Size = new System.Drawing.Size(86, 22);
            this.btnsaveandprint.TabIndex = 416;
            this.btnsaveandprint.Text = "حفظ وطباعة";
            this.btnsaveandprint.Click += new System.EventHandler(this.btnsaveandprint_Click);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(119, 371);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 415;
            this.label14.Text = "المجموع";
            // 
            // txtTotalout
            // 
            this.txtTotalout.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalout.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTotalout.Enabled = false;
            this.txtTotalout.Location = new System.Drawing.Point(12, 366);
            this.txtTotalout.Name = "txtTotalout";
            this.txtTotalout.Size = new System.Drawing.Size(100, 20);
            this.txtTotalout.TabIndex = 414;
            this.txtTotalout.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(546, 367);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(63, 22);
            this.btnupdate.TabIndex = 409;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // StoreoutDetailsGrid
            // 
            this.StoreoutDetailsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.StoreoutDetailsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemUnit,
            this.ItemUnitPrice,
            this.itemQty,
            this.taxpercent,
            this.itemTax,
            this.itemTotal});
            this.StoreoutDetailsGrid.Location = new System.Drawing.Point(4, 137);
            this.StoreoutDetailsGrid.MultiSelect = false;
            this.StoreoutDetailsGrid.Name = "StoreoutDetailsGrid";
            this.StoreoutDetailsGrid.ReadOnly = true;
            this.StoreoutDetailsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StoreoutDetailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoreoutDetailsGrid.Size = new System.Drawing.Size(778, 220);
            this.StoreoutDetailsGrid.TabIndex = 417;
            this.StoreoutDetailsGrid.DoubleClick += new System.EventHandler(this.StoreoutDetailsGrid_DoubleClick);
            this.StoreoutDetailsGrid.KeyDown += new System.Windows.Forms.KeyEventHandler(this.StoreoutDetailsGrid_KeyDown);
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
            // btnView
            // 
            this.btnView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnView.ImageOptions.Image")));
            this.btnView.Location = new System.Drawing.Point(323, 366);
            this.btnView.Name = "btnView";
            this.btnView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnView.Size = new System.Drawing.Size(67, 22);
            this.btnView.TabIndex = 418;
            this.btnView.Text = "عرض";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtLastNum
            // 
            this.txtLastNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLastNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtLastNum.Enabled = false;
            this.txtLastNum.Location = new System.Drawing.Point(7, 37);
            this.txtLastNum.Name = "txtLastNum";
            this.txtLastNum.Size = new System.Drawing.Size(90, 20);
            this.txtLastNum.TabIndex = 419;
            this.txtLastNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(103, 41);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 420;
            this.label5.Text = "رقم آخر سند";
            // 
            // frmStoreOut
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(789, 398);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtLastNum);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.StoreoutDetailsGrid);
            this.Controls.Add(this.btnsaveandprint);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotalout);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.toggleSwitch1);
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
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.txtItemName);
            this.Controls.Add(this.txtTaxValue);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.txtstoreid);
            this.Controls.Add(this.btnaddnewrow);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.cboStore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txttransType);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetransdate);
            this.Controls.Add(this.transnotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStoreOut";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند إخراج";
            this.Load += new System.EventHandler(this.frmStoreOut_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStoreOut_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreoutDetailsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.SimpleButton btnaddnewrow;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private System.Windows.Forms.ComboBox cboStore;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txttransType;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit datetransdate;
        private System.Windows.Forms.TextBox transnotes;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtstoreid;
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
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.TextBox txtItemName;
        private System.Windows.Forms.TextBox txtTaxValue;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtUnit;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton btnsaveandprint;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTotalout;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private System.Windows.Forms.DataGridView StoreoutDetailsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTotal;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private System.Windows.Forms.TextBox txtLastNum;
        private System.Windows.Forms.Label label5;
    }
}