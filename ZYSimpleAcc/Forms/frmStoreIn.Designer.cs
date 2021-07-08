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
            this.btnViewItems = new DevExpress.XtraEditors.SimpleButton();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.label37 = new System.Windows.Forms.Label();
            this.cboCat = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.addnewrow = new DevExpress.XtraEditors.SimpleButton();
            this.txtstoreid = new System.Windows.Forms.TextBox();
            this.cboitemsids = new System.Windows.Forms.ComboBox();
            this.txtUnit = new System.Windows.Forms.TextBox();
            this.txtUnitPrice = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtItemID = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.txtQty = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTotal = new System.Windows.Forms.TextBox();
            this.label13 = new System.Windows.Forms.Label();
            this.cbonames = new System.Windows.Forms.ComboBox();
            this.txtTotalIN = new System.Windows.Forms.TextBox();
            this.label14 = new System.Windows.Forms.Label();
            this.txtrowsCount = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.txtTax = new System.Windows.Forms.TextBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.ItemID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ItemUnitPrice = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemQty = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTax = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itemTotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTransID
            // 
            this.txtTransID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTransID.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtTransID.Enabled = false;
            this.txtTransID.Location = new System.Drawing.Point(619, 16);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(90, 20);
            this.txtTransID.TabIndex = 58;
            this.txtTransID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(715, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(55, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "رقم السند";
            // 
            // txtTransnotes
            // 
            this.txtTransnotes.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransnotes.Location = new System.Drawing.Point(178, 45);
            this.txtTransnotes.Name = "txtTransnotes";
            this.txtTransnotes.Size = new System.Drawing.Size(531, 20);
            this.txtTransnotes.TabIndex = 60;
            this.txtTransnotes.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(715, 48);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 61;
            this.label1.Text = "ملاحظات";
            // 
            // datetransdate
            // 
            this.datetransdate.EditValue = null;
            this.datetransdate.Location = new System.Drawing.Point(178, 16);
            this.datetransdate.Name = "datetransdate";
            this.datetransdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetransdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetransdate.Size = new System.Drawing.Size(127, 20);
            this.datetransdate.TabIndex = 62;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(311, 19);
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
            this.txtTranstype.Location = new System.Drawing.Point(577, 16);
            this.txtTranstype.Name = "txtTranstype";
            this.txtTranstype.Size = new System.Drawing.Size(36, 20);
            this.txtTranstype.TabIndex = 64;
            this.txtTranstype.Text = "SIN";
            this.txtTranstype.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(518, 19);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 66;
            this.label4.Text = "المستودع";
            // 
            // cboStore
            // 
            this.cboStore.FormattingEnabled = true;
            this.cboStore.Location = new System.Drawing.Point(412, 15);
            this.cboStore.Name = "cboStore";
            this.cboStore.Size = new System.Drawing.Size(100, 21);
            this.cboStore.TabIndex = 322;
            this.cboStore.TextChanged += new System.EventHandler(this.cboStore_TextChanged);
            // 
            // btnViewItems
            // 
            this.btnViewItems.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnViewItems.ImageOptions.Image")));
            this.btnViewItems.Location = new System.Drawing.Point(23, 52);
            this.btnViewItems.Name = "btnViewItems";
            this.btnViewItems.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnViewItems.Size = new System.Drawing.Size(126, 22);
            this.btnViewItems.TabIndex = 341;
            this.btnViewItems.Text = "عرض";
            // 
            // btnclear
            // 
            this.btnclear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.ImageOptions.Image")));
            this.btnclear.Location = new System.Drawing.Point(3, 234);
            this.btnclear.Name = "btnclear";
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclear.Size = new System.Drawing.Size(63, 22);
            this.btnclear.TabIndex = 340;
            this.btnclear.Text = "تفريغ";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Location = new System.Drawing.Point(3, 206);
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
            this.btnsave.Location = new System.Drawing.Point(3, 122);
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
            this.btndelete.Location = new System.Drawing.Point(3, 150);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(63, 22);
            this.btndelete.TabIndex = 338;
            this.btndelete.Text = "إلغاء";
            // 
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(3, 178);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(63, 22);
            this.btnupdate.TabIndex = 336;
            this.btnupdate.Text = "تعديل";
            // 
            // label37
            // 
            this.label37.AutoSize = true;
            this.label37.Font = new System.Drawing.Font("Tahoma", 6F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label37.ForeColor = System.Drawing.Color.Red;
            this.label37.Location = new System.Drawing.Point(21, 12);
            this.label37.Name = "label37";
            this.label37.Size = new System.Drawing.Size(65, 10);
            this.label37.TabIndex = 342;
            this.label37.Text = "اضغط للمساعدة";
            this.label37.Click += new System.EventHandler(this.label37_Click);
            // 
            // cboCat
            // 
            this.cboCat.FormattingEnabled = true;
            this.cboCat.Location = new System.Drawing.Point(23, 25);
            this.cboCat.Name = "cboCat";
            this.cboCat.Size = new System.Drawing.Size(126, 21);
            this.cboCat.TabIndex = 344;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(110, 9);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(36, 13);
            this.label5.TabIndex = 343;
            this.label5.Text = "الصنف";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(10, 272);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(24, 22);
            this.simpleButton1.TabIndex = 345;
            this.simpleButton1.Text = "اغلاق";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // addnewrow
            // 
            this.addnewrow.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("addnewrow.ImageOptions.Image")));
            this.addnewrow.Location = new System.Drawing.Point(38, 272);
            this.addnewrow.Name = "addnewrow";
            this.addnewrow.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.addnewrow.Size = new System.Drawing.Size(24, 22);
            this.addnewrow.TabIndex = 346;
            this.addnewrow.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtstoreid
            // 
            this.txtstoreid.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtstoreid.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtstoreid.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.txtstoreid.Enabled = false;
            this.txtstoreid.Location = new System.Drawing.Point(370, 16);
            this.txtstoreid.Name = "txtstoreid";
            this.txtstoreid.Size = new System.Drawing.Size(36, 20);
            this.txtstoreid.TabIndex = 348;
            this.txtstoreid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // cboitemsids
            // 
            this.cboitemsids.FormattingEnabled = true;
            this.cboitemsids.Location = new System.Drawing.Point(677, 112);
            this.cboitemsids.Name = "cboitemsids";
            this.cboitemsids.Size = new System.Drawing.Size(110, 21);
            this.cboitemsids.TabIndex = 351;
            this.cboitemsids.TextChanged += new System.EventHandler(this.cboitemsids_TextChanged);
            // 
            // txtUnit
            // 
            this.txtUnit.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnit.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUnit.Enabled = false;
            this.txtUnit.Location = new System.Drawing.Point(334, 113);
            this.txtUnit.Name = "txtUnit";
            this.txtUnit.Size = new System.Drawing.Size(57, 20);
            this.txtUnit.TabIndex = 354;
            this.txtUnit.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtUnitPrice
            // 
            this.txtUnitPrice.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtUnitPrice.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtUnitPrice.Enabled = false;
            this.txtUnitPrice.Location = new System.Drawing.Point(266, 113);
            this.txtUnitPrice.Name = "txtUnitPrice";
            this.txtUnitPrice.Size = new System.Drawing.Size(66, 20);
            this.txtUnitPrice.TabIndex = 355;
            this.txtUnitPrice.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(458, 95);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 13);
            this.label8.TabIndex = 356;
            this.label8.Text = "اسم المادة";
            // 
            // txtItemID
            // 
            this.txtItemID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtItemID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtItemID.Enabled = false;
            this.txtItemID.Location = new System.Drawing.Point(570, 113);
            this.txtItemID.Name = "txtItemID";
            this.txtItemID.Size = new System.Drawing.Size(105, 20);
            this.txtItemID.TabIndex = 357;
            this.txtItemID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(603, 95);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(51, 13);
            this.label9.TabIndex = 358;
            this.label9.Text = "رمز المادة";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(264, 95);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(61, 13);
            this.label10.TabIndex = 359;
            this.label10.Text = "سعر الوحدة";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(328, 95);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(65, 13);
            this.label11.TabIndex = 360;
            this.label11.Text = "وحدة القياس";
            // 
            // txtQty
            // 
            this.txtQty.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtQty.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtQty.Location = new System.Drawing.Point(198, 113);
            this.txtQty.Name = "txtQty";
            this.txtQty.Size = new System.Drawing.Size(66, 20);
            this.txtQty.TabIndex = 361;
            this.txtQty.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtQty.Leave += new System.EventHandler(this.txtQty_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(212, 95);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(36, 13);
            this.label6.TabIndex = 363;
            this.label6.Text = "الكمية";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(85, 97);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(46, 13);
            this.label12.TabIndex = 365;
            this.label12.Text = "المجموع";
            // 
            // txtTotal
            // 
            this.txtTotal.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotal.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTotal.Location = new System.Drawing.Point(71, 113);
            this.txtTotal.Name = "txtTotal";
            this.txtTotal.Size = new System.Drawing.Size(66, 20);
            this.txtTotal.TabIndex = 364;
            this.txtTotal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(703, 94);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(51, 13);
            this.label13.TabIndex = 366;
            this.label13.Text = "رمز المادة";
            // 
            // cbonames
            // 
            this.cbonames.FormattingEnabled = true;
            this.cbonames.Location = new System.Drawing.Point(397, 112);
            this.cbonames.Name = "cbonames";
            this.cbonames.Size = new System.Drawing.Size(167, 21);
            this.cbonames.TabIndex = 367;
            // 
            // txtTotalIN
            // 
            this.txtTotalIN.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTotalIN.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTotalIN.Location = new System.Drawing.Point(6, 354);
            this.txtTotalIN.Name = "txtTotalIN";
            this.txtTotalIN.Size = new System.Drawing.Size(56, 20);
            this.txtTotalIN.TabIndex = 368;
            this.txtTotalIN.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Transparent;
            this.label14.ForeColor = System.Drawing.Color.Black;
            this.label14.Location = new System.Drawing.Point(12, 338);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(46, 13);
            this.label14.TabIndex = 370;
            this.label14.Text = "المجموع";
            // 
            // txtrowsCount
            // 
            this.txtrowsCount.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtrowsCount.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtrowsCount.Location = new System.Drawing.Point(6, 315);
            this.txtrowsCount.Name = "txtrowsCount";
            this.txtrowsCount.Size = new System.Drawing.Size(56, 20);
            this.txtrowsCount.TabIndex = 371;
            this.txtrowsCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Transparent;
            this.label15.ForeColor = System.Drawing.Color.Black;
            this.label15.Location = new System.Drawing.Point(3, 297);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(62, 13);
            this.label15.TabIndex = 372;
            this.label15.Text = "عدد الأسطر";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(146, 97);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(40, 13);
            this.label16.TabIndex = 374;
            this.label16.Text = "الضريبة";
            // 
            // txtTax
            // 
            this.txtTax.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTax.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTax.Location = new System.Drawing.Point(143, 113);
            this.txtTax.Name = "txtTax";
            this.txtTax.Size = new System.Drawing.Size(49, 20);
            this.txtTax.TabIndex = 373;
            this.txtTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ItemID,
            this.ItemName,
            this.ItemUnit,
            this.ItemUnitPrice,
            this.itemQty,
            this.itemTax,
            this.itemTotal});
            this.dataGridView1.Location = new System.Drawing.Point(71, 139);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.dataGridView1.Size = new System.Drawing.Size(724, 238);
            this.dataGridView1.TabIndex = 375;
            // 
            // ItemID
            // 
            this.ItemID.HeaderText = "رمز المادة";
            this.ItemID.Name = "ItemID";
            // 
            // ItemName
            // 
            this.ItemName.HeaderText = "إسم المادة";
            this.ItemName.Name = "ItemName";
            // 
            // ItemUnit
            // 
            this.ItemUnit.HeaderText = "وحدة القياس";
            this.ItemUnit.Name = "ItemUnit";
            // 
            // ItemUnitPrice
            // 
            this.ItemUnitPrice.HeaderText = "سعر الوحدة";
            this.ItemUnitPrice.Name = "ItemUnitPrice";
            // 
            // itemQty
            // 
            this.itemQty.HeaderText = "الكمية";
            this.itemQty.Name = "itemQty";
            // 
            // itemTax
            // 
            this.itemTax.HeaderText = "الضريبة";
            this.itemTax.Name = "itemTax";
            // 
            // itemTotal
            // 
            this.itemTotal.HeaderText = "المجموع";
            this.itemTotal.Name = "itemTotal";
            // 
            // frmStoreIn
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(795, 379);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.txtTax);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.txtrowsCount);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtTotalIN);
            this.Controls.Add(this.cbonames);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTotal);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtQty);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtItemID);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtUnitPrice);
            this.Controls.Add(this.txtUnit);
            this.Controls.Add(this.cboitemsids);
            this.Controls.Add(this.txtstoreid);
            this.Controls.Add(this.addnewrow);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.cboCat);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label37);
            this.Controls.Add(this.btnViewItems);
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
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
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
        private DevExpress.XtraEditors.SimpleButton btnViewItems;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private System.Windows.Forms.Label label37;
        private System.Windows.Forms.ComboBox cboCat;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton addnewrow;
        private System.Windows.Forms.TextBox txtstoreid;
        private System.Windows.Forms.ComboBox cboitemsids;
        private System.Windows.Forms.TextBox txtUnit;
        private System.Windows.Forms.TextBox txtUnitPrice;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtItemID;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtQty;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTotal;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.ComboBox cbonames;
        private System.Windows.Forms.TextBox txtTotalIN;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtrowsCount;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.TextBox txtTax;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemID;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnit;
        private System.Windows.Forms.DataGridViewTextBoxColumn ItemUnitPrice;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemQty;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTax;
        private System.Windows.Forms.DataGridViewTextBoxColumn itemTotal;
    }
}