namespace ZYSimpleAcc.Forms
{
    partial class frmStoreIn
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStoreIn));
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtTransnotes = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.datetransdate = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.txtTranstype = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cboStore = new System.Windows.Forms.ComboBox();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.addnewrow = new DevExpress.XtraEditors.SimpleButton();
            this.txtstoreid = new System.Windows.Forms.TextBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.txtTotalIN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtTaxValue = new System.Windows.Forms.TextBox();
            this.txtItemName = new System.Windows.Forms.TextBox();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.textBox3 = new System.Windows.Forms.TextBox();
            this.textBox4 = new System.Windows.Forms.TextBox();
            this.textBox5 = new System.Windows.Forms.TextBox();
            this.textBox6 = new System.Windows.Forms.TextBox();
            this.textBox7 = new System.Windows.Forms.TextBox();
            this.textBox8 = new System.Windows.Forms.TextBox();
            this.textBox9 = new System.Windows.Forms.TextBox();
            this.txtTaxPercent = new System.Windows.Forms.TextBox();
            this.StoreInDetailsGrid = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.taxpercent = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnsaveandprint = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.txtLastNum = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtbeforeTax = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtTaxTotal = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreInDetailsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTransID
            // 
            this.txtTransID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransID.Enabled = false;
            this.txtTransID.Location = new System.Drawing.Point(630, 10);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(90, 20);
            this.txtTransID.TabIndex = 58;
            this.txtTransID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTransID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransID_KeyPress);
            this.txtTransID.Leave += new System.EventHandler(this.txtTransID_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(726, 13);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "رقم السند";
            // 
            // txtTransnotes
            // 
            this.txtTransnotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransnotes.Location = new System.Drawing.Point(196, 39);
            this.txtTransnotes.Name = "txtTransnotes";
            this.txtTransnotes.Size = new System.Drawing.Size(524, 20);
            this.txtTransnotes.TabIndex = 2;
            this.txtTransnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(726, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "ملاحظات";
            // 
            // datetransdate
            // 
            this.datetransdate.EditValue = null;
            this.datetransdate.Location = new System.Drawing.Point(196, 10);
            this.datetransdate.Name = "datetransdate";
            this.datetransdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetransdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetransdate.Size = new System.Drawing.Size(132, 20);
            this.datetransdate.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(334, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 63;
            this.label3.Text = "التاريخ";
            // 
            // txtTranstype
            // 
            this.txtTranstype.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTranstype.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTranstype.Enabled = false;
            this.txtTranstype.Location = new System.Drawing.Point(588, 10);
            this.txtTranstype.Name = "txtTranstype";
            this.txtTranstype.Size = new System.Drawing.Size(36, 20);
            this.txtTranstype.TabIndex = 64;
            this.txtTranstype.Text = "SIN";
            this.txtTranstype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(529, 13);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "المستودع";
            // 
            // cboStore
            // 
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(423, 9);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(100, 21);
            this.cboStore.TabIndex = 0;
            this.cboStore.TextChanged += new System.EventHandler(this.cboStore_TextChanged);
            // 
            // btnclear
            // 
            this.btnclear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.ImageOptions.Image")));
            this.btnclear.Location = new System.Drawing.Point(180, 350);
            this.btnclear.Name = "btnclear";
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclear.Size = new System.Drawing.Size(135, 22);
            this.btnclear.TabIndex = 340;
            this.btnclear.Text = "تفريغ جميع الحقول";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Location = new System.Drawing.Point(394, 350);
            this.btnclose.Name = "btnclose";
            this.btnclose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclose.Size = new System.Drawing.Size(63, 22);
            this.btnclose.TabIndex = 339;
            this.btnclose.Text = "اغلاق";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.Location = new System.Drawing.Point(694, 350);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsave.Size = new System.Drawing.Size(63, 22);
            this.btnsave.TabIndex = 337;
            this.btnsave.Text = "حفظ";
            this.btnsave.Click += new System.EventHandler(this.btnsave_Click);
            // 
            // btndelete
            // 
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.Location = new System.Drawing.Point(464, 350);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(63, 22);
            this.btndelete.TabIndex = 338;
            this.btndelete.Text = "إلغاء";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(533, 350);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(63, 22);
            this.btnupdate.TabIndex = 336;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(289, 113);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(168, 22);
            this.simpleButton1.TabIndex = 345;
            this.simpleButton1.Text = "الغاء السطر المحدد";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // addnewrow
            // 
            this.addnewrow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addnewrow.ImageOptions.Image")));
            this.addnewrow.Location = new System.Drawing.Point(15, 113);
            this.addnewrow.Name = "addnewrow";
            this.addnewrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addnewrow.Size = new System.Drawing.Size(96, 22);
            this.addnewrow.TabIndex = 6;
            this.addnewrow.Text = "اضافة السطر";
            this.addnewrow.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtstoreid
            // 
            this.txtstoreid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtstoreid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtstoreid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstoreid.Enabled = false;
            this.txtstoreid.Location = new System.Drawing.Point(381, 10);
            this.txtstoreid.Name = "txtstoreid";
            this.txtstoreid.Size = new System.Drawing.Size(36, 20);
            this.txtstoreid.TabIndex = 348;
            this.txtstoreid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnit
            // 
            this.txtUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUnit.Enabled = false;
            this.txtUnit.Location = new System.Drawing.Point(316, 87);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(79, 20);
            this.txtUnit.TabIndex = 354;
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnitPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUnitPrice.Location = new System.Drawing.Point(249, 87);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(66, 20);
            this.txtUnitPrice.TabIndex = 4;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtUnitPrice.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtUnitPrice_KeyPress);
            this.txtUnitPrice.Leave += new System.EventHandler(this.txtUnitPrice_Leave);
            // 
            // txtItemID
            // 
            this.txtItemID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtItemID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(608, 87);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(97, 20);
            this.txtItemID.TabIndex = 357;
            this.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtQty
            // 
            this.txtQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtQty.Location = new System.Drawing.Point(185, 87);
            this.txtQty.MaxLength = 8;
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(63, 20);
            this.txtQty.TabIndex = 5;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.TextChanged += new System.EventHandler(this.txtQty_TextChanged);
            this.txtQty.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtQty_KeyPress);
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTotal.Enabled = false;
            this.txtTotal.Location = new System.Drawing.Point(15, 87);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(69, 20);
            this.txtTotal.TabIndex = 364;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTotalIN
            // 
            this.txtTotalIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTotalIN.Enabled = false;
            this.txtTotalIN.Location = new System.Drawing.Point(12, 398);
            this.txtTotalIN.Name = "txtTotalIN";
            this.txtTotalIN.Size = new System.Drawing.Size(100, 20);
            this.txtTotalIN.TabIndex = 368;
            this.txtTotalIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(119, 403);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(48, 13);
            this.label14.TabIndex = 370;
            this.label14.Text = "الاجمالي";
            // 
            // txtTaxValue
            // 
            this.txtTaxValue.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTaxValue.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTaxValue.Enabled = false;
            this.txtTaxValue.Location = new System.Drawing.Point(85, 87);
            this.txtTaxValue.Name = "txtTaxValue";
            this.txtTaxValue.Size = new System.Drawing.Size(49, 20);
            this.txtTaxValue.TabIndex = 373;
            this.txtTaxValue.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtItemName
            // 
            this.txtItemName.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtItemName.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtItemName.Enabled = false;
            this.txtItemName.Location = new System.Drawing.Point(396, 87);
            this.txtItemName.Name = "txtItemName";
            this.txtItemName.Size = new System.Drawing.Size(211, 20);
            this.txtItemName.TabIndex = 376;
            this.txtItemName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // simpleButton2
            // 
            this.simpleButton2.Location = new System.Drawing.Point(706, 88);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton2.Size = new System.Drawing.Size(84, 20);
            this.simpleButton2.TabIndex = 3;
            this.simpleButton2.Text = "اختيار مادة";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // textBox1
            // 
            this.textBox1.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox1.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox1.Enabled = false;
            this.textBox1.Location = new System.Drawing.Point(396, 68);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(211, 20);
            this.textBox1.TabIndex = 384;
            this.textBox1.Text = "اسم المادة";
            this.textBox1.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox2
            // 
            this.textBox2.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox2.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox2.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox2.Enabled = false;
            this.textBox2.Location = new System.Drawing.Point(85, 68);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(49, 20);
            this.textBox2.TabIndex = 383;
            this.textBox2.Text = "الضريبة";
            this.textBox2.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox3
            // 
            this.textBox3.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox3.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox3.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox3.Enabled = false;
            this.textBox3.Location = new System.Drawing.Point(15, 68);
            this.textBox3.Name = "textBox3";
            this.textBox3.Size = new System.Drawing.Size(69, 20);
            this.textBox3.TabIndex = 382;
            this.textBox3.Text = "المجموع";
            this.textBox3.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox4
            // 
            this.textBox4.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox4.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox4.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox4.Enabled = false;
            this.textBox4.Location = new System.Drawing.Point(185, 68);
            this.textBox4.Name = "textBox4";
            this.textBox4.Size = new System.Drawing.Size(63, 20);
            this.textBox4.TabIndex = 379;
            this.textBox4.Text = "الكمية";
            this.textBox4.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox5
            // 
            this.textBox5.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox5.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox5.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox5.Enabled = false;
            this.textBox5.Location = new System.Drawing.Point(608, 68);
            this.textBox5.Name = "textBox5";
            this.textBox5.Size = new System.Drawing.Size(97, 20);
            this.textBox5.TabIndex = 381;
            this.textBox5.Text = "رمز الـمادة";
            this.textBox5.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox6
            // 
            this.textBox6.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox6.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox6.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox6.Enabled = false;
            this.textBox6.Location = new System.Drawing.Point(249, 68);
            this.textBox6.Name = "textBox6";
            this.textBox6.Size = new System.Drawing.Size(66, 20);
            this.textBox6.TabIndex = 378;
            this.textBox6.Text = "سعر الوحدة";
            this.textBox6.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox7
            // 
            this.textBox7.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox7.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox7.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox7.Enabled = false;
            this.textBox7.Location = new System.Drawing.Point(316, 68);
            this.textBox7.Name = "textBox7";
            this.textBox7.Size = new System.Drawing.Size(79, 20);
            this.textBox7.TabIndex = 380;
            this.textBox7.Text = "وحدة القياس";
            this.textBox7.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox8
            // 
            this.textBox8.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox8.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox8.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox8.Enabled = false;
            this.textBox8.Location = new System.Drawing.Point(706, 68);
            this.textBox8.Name = "textBox8";
            this.textBox8.Size = new System.Drawing.Size(84, 20);
            this.textBox8.TabIndex = 385;
            this.textBox8.Text = "عرض المواد";
            this.textBox8.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // textBox9
            // 
            this.textBox9.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.textBox9.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.textBox9.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.textBox9.Enabled = false;
            this.textBox9.Location = new System.Drawing.Point(135, 68);
            this.textBox9.Name = "textBox9";
            this.textBox9.Size = new System.Drawing.Size(49, 20);
            this.textBox9.TabIndex = 387;
            this.textBox9.Text = "%ض.م";
            this.textBox9.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtTaxPercent
            // 
            this.txtTaxPercent.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTaxPercent.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTaxPercent.Enabled = false;
            this.txtTaxPercent.Location = new System.Drawing.Point(135, 87);
            this.txtTaxPercent.Name = "txtTaxPercent";
            this.txtTaxPercent.Size = new System.Drawing.Size(49, 20);
            this.txtTaxPercent.TabIndex = 386;
            this.txtTaxPercent.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.taxpercent,
            this.itemTax,
            this.itemTotal});
            this.StoreInDetailsGrid.Location = new System.Drawing.Point(11, 141);
            this.StoreInDetailsGrid.MultiSelect = false;
            this.StoreInDetailsGrid.Name = "StoreInDetailsGrid";
            this.StoreInDetailsGrid.ReadOnly = true;
            this.StoreInDetailsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StoreInDetailsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.StoreInDetailsGrid.Size = new System.Drawing.Size(775, 200);
            this.StoreInDetailsGrid.TabIndex = 375;
            this.StoreInDetailsGrid.DoubleClick += new System.EventHandler(this.StoreInDetailsGrid_DoubleClick);
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
            // btnsaveandprint
            // 
            this.btnsaveandprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveandprint.ImageOptions.Image")));
            this.btnsaveandprint.Location = new System.Drawing.Point(602, 350);
            this.btnsaveandprint.Name = "btnsaveandprint";
            this.btnsaveandprint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsaveandprint.Size = new System.Drawing.Size(86, 22);
            this.btnsaveandprint.TabIndex = 388;
            this.btnsaveandprint.Text = "حفظ وطباعة";
            this.btnsaveandprint.Click += new System.EventHandler(this.btnsaveandprint_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(117, 113);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton3.Size = new System.Drawing.Size(168, 22);
            this.simpleButton3.TabIndex = 389;
            this.simpleButton3.Text = "الغاء جميع السطور";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click_2);
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(15, 12);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "وحدة القياس الرئيسية";
            this.toggleSwitch1.Properties.OnText = "وحدة القياس الفرعية";
            this.toggleSwitch1.Size = new System.Drawing.Size(169, 23);
            this.toggleSwitch1.TabIndex = 390;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled_1);
            // 
            // btnView
            // 
            this.btnView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnView.ImageOptions.Image")));
            this.btnView.Location = new System.Drawing.Point(325, 350);
            this.btnView.Name = "btnView";
            this.btnView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnView.Size = new System.Drawing.Size(63, 22);
            this.btnView.TabIndex = 391;
            this.btnView.Text = "عرض";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // txtLastNum
            // 
            this.txtLastNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLastNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtLastNum.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtLastNum.Enabled = false;
            this.txtLastNum.Location = new System.Drawing.Point(15, 39);
            this.txtLastNum.Name = "txtLastNum";
            this.txtLastNum.Size = new System.Drawing.Size(90, 20);
            this.txtLastNum.TabIndex = 392;
            this.txtLastNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(109, 42);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(66, 13);
            this.label5.TabIndex = 393;
            this.label5.Text = "رقم اخر سند";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.ForeColor = System.Drawing.Color.Black;
            this.label6.Location = new System.Drawing.Point(118, 377);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(60, 13);
            this.label6.TabIndex = 395;
            this.label6.Text = "قبل الضريبة";
            // 
            // txtbeforeTax
            // 
            this.txtbeforeTax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtbeforeTax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtbeforeTax.Enabled = false;
            this.txtbeforeTax.Location = new System.Drawing.Point(11, 372);
            this.txtbeforeTax.Name = "txtbeforeTax";
            this.txtbeforeTax.Size = new System.Drawing.Size(100, 20);
            this.txtbeforeTax.TabIndex = 394;
            this.txtbeforeTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Transparent;
            this.label7.ForeColor = System.Drawing.Color.Black;
            this.label7.Location = new System.Drawing.Point(119, 351);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(40, 13);
            this.label7.TabIndex = 397;
            this.label7.Text = "الضريبة";
            // 
            // txtTaxTotal
            // 
            this.txtTaxTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTaxTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTaxTotal.Enabled = false;
            this.txtTaxTotal.Location = new System.Drawing.Point(12, 346);
            this.txtTaxTotal.Name = "txtTaxTotal";
            this.txtTaxTotal.Size = new System.Drawing.Size(100, 20);
            this.txtTaxTotal.TabIndex = 396;
            this.txtTaxTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // frmStoreIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(796, 420);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtTaxTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtbeforeTax);
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
            this.Controls.Add(this.txtstoreid);
            this.Controls.Add(this.addnewrow);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.cboStore);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtTranstype);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetransdate);
            this.Controls.Add(this.txtTransnotes);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStoreIn";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سند ادخال";
            this.Load += new System.EventHandler(this.frmStoreIn_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStoreIn_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StoreInDetailsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtTransnotes;
        private System.Windows.Forms.Label label1;
        private DevExpress.XtraEditors.DateEdit datetransdate;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtTranstype;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cboStore;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton addnewrow;
        private System.Windows.Forms.TextBox txtstoreid;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.TextBox txtTotalIN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtTaxValue;
        private System.Windows.Forms.TextBox txtItemName;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.TextBox textBox3;
        private System.Windows.Forms.TextBox textBox4;
        private System.Windows.Forms.TextBox textBox5;
        private System.Windows.Forms.TextBox textBox6;
        private System.Windows.Forms.TextBox textBox7;
        private System.Windows.Forms.TextBox textBox8;
        private System.Windows.Forms.TextBox textBox9;
        private System.Windows.Forms.TextBox txtTaxPercent;
        private System.Windows.Forms.DataGridView StoreInDetailsGrid;
        private DevExpress.XtraEditors.SimpleButton btnsaveandprint;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn taxpercent;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTotal;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private System.Windows.Forms.TextBox txtLastNum;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtbeforeTax;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtTaxTotal;
    }
}