namespace ZYSimpleAcc.Forms
{
    partial class frmChildAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmChildAccounts));
            this.label12 = new System.Windows.Forms.Label();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnactivate = new DevExpress.XtraEditors.SimpleButton();
            this.btndeactivaete = new DevExpress.XtraEditors.SimpleButton();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.txtAccType = new System.Windows.Forms.TextBox();
            this.txtCure = new System.Windows.Forms.TextBox();
            this.txtmainaccno = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxBalance = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.acc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaccStatus = new System.Windows.Forms.TextBox();
            this.txtaccname = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.txtchildaccno = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.txtchildName = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.cur = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.txtchildMaxBal = new System.Windows.Forms.TextBox();
            this.MyGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label15 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.comboBoxEdit1 = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.acc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(45, 63);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(115, 13);
            this.label12.TabIndex = 174;
            this.label12.Text = "تعني حقول مطلوبة *";
            this.label12.Click += new System.EventHandler(this.label12_Click);
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnadd);
            this.groupControl1.Controls.Add(this.btndelete);
            this.groupControl1.Controls.Add(this.btnupdate);
            this.groupControl1.Controls.Add(this.simpleButton1);
            this.groupControl1.Controls.Add(this.btnactivate);
            this.groupControl1.Controls.Add(this.btndeactivaete);
            this.groupControl1.Controls.Add(this.btnclear);
            this.groupControl1.Controls.Add(this.simpleButton2);
            this.groupControl1.Location = new System.Drawing.Point(3, 93);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(891, 59);
            this.groupControl1.TabIndex = 169;
            this.groupControl1.Text = "خيارات الحسابات";
            this.groupControl1.Paint += new System.Windows.Forms.PaintEventHandler(this.groupControl1_Paint);
            // 
            // btnadd
            // 
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.Location = new System.Drawing.Point(731, 28);
            this.btnadd.Name = "btnadd";
            this.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnadd.Size = new System.Drawing.Size(68, 22);
            this.btnadd.TabIndex = 83;
            this.btnadd.Text = "اضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndelete
            // 
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.Location = new System.Drawing.Point(603, 28);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(68, 22);
            this.btndelete.TabIndex = 143;
            this.btndelete.Text = "حذف";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(530, 28);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(67, 22);
            this.btnupdate.TabIndex = 79;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(103, 28);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(67, 22);
            this.simpleButton1.TabIndex = 142;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // btnactivate
            // 
            this.btnactivate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnactivate.ImageOptions.Image")));
            this.btnactivate.Location = new System.Drawing.Point(457, 28);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnactivate.Size = new System.Drawing.Size(67, 22);
            this.btnactivate.TabIndex = 84;
            this.btnactivate.Text = "تفعيل";
            // 
            // btndeactivaete
            // 
            this.btndeactivaete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndeactivaete.ImageOptions.Image")));
            this.btndeactivaete.Location = new System.Drawing.Point(384, 28);
            this.btndeactivaete.Name = "btndeactivaete";
            this.btndeactivaete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndeactivaete.Size = new System.Drawing.Size(67, 22);
            this.btndeactivaete.TabIndex = 82;
            this.btndeactivaete.Text = "تجميد";
            // 
            // btnclear
            // 
            this.btnclear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.ImageOptions.Image")));
            this.btnclear.Location = new System.Drawing.Point(176, 28);
            this.btnclear.Name = "btnclear";
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclear.Size = new System.Drawing.Size(99, 22);
            this.btnclear.TabIndex = 81;
            this.btnclear.Text = "تفريغ الحقول";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(29, 28);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton2.Size = new System.Drawing.Size(67, 22);
            this.simpleButton2.TabIndex = 80;
            this.simpleButton2.Text = "اغلاق";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // txtAccType
            // 
            this.txtAccType.Enabled = false;
            this.txtAccType.Location = new System.Drawing.Point(300, 20);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccType.Size = new System.Drawing.Size(112, 20);
            this.txtAccType.TabIndex = 168;
            this.txtAccType.Text = "نوع الحساب";
            this.txtAccType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtCure
            // 
            this.txtCure.Enabled = false;
            this.txtCure.Location = new System.Drawing.Point(12, 20);
            this.txtCure.Name = "txtCure";
            this.txtCure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCure.Size = new System.Drawing.Size(86, 20);
            this.txtCure.TabIndex = 167;
            this.txtCure.Text = "عملة الحساب";
            this.txtCure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtmainaccno
            // 
            this.txtmainaccno.Enabled = false;
            this.txtmainaccno.Location = new System.Drawing.Point(567, 20);
            this.txtmainaccno.Name = "txtmainaccno";
            this.txtmainaccno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtmainaccno.Size = new System.Drawing.Size(98, 20);
            this.txtmainaccno.TabIndex = 164;
            this.txtmainaccno.Text = "رقم الحساب";
            this.txtmainaccno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(112, 5);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 163;
            this.label6.Text = "سقف الحساب";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaxBalance
            // 
            this.txtMaxBalance.Enabled = false;
            this.txtMaxBalance.Location = new System.Drawing.Point(104, 20);
            this.txtMaxBalance.Name = "txtMaxBalance";
            this.txtMaxBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMaxBalance.Size = new System.Drawing.Size(98, 20);
            this.txtMaxBalance.TabIndex = 162;
            this.txtMaxBalance.Text = "سقف الحساب";
            this.txtMaxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(731, 5);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(89, 13);
            this.label5.TabIndex = 161;
            this.label5.Text = "معلومات الحساب ";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acc
            // 
            this.acc.Location = new System.Drawing.Point(671, 21);
            this.acc.Name = "acc";
            this.acc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.acc.Size = new System.Drawing.Size(207, 20);
            this.acc.TabIndex = 160;
            this.acc.TextChanged += new System.EventHandler(this.acc_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(225, 5);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 158;
            this.label1.Text = "حالة الحساب";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(447, 5);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 157;
            this.label3.Text = "إسم الحساب ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(584, 5);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 156;
            this.label2.Text = "رقم الحساب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtaccStatus
            // 
            this.txtaccStatus.Enabled = false;
            this.txtaccStatus.Location = new System.Drawing.Point(208, 20);
            this.txtaccStatus.Name = "txtaccStatus";
            this.txtaccStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaccStatus.Size = new System.Drawing.Size(90, 20);
            this.txtaccStatus.TabIndex = 155;
            this.txtaccStatus.Text = "فعال";
            this.txtaccStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtaccname
            // 
            this.txtaccname.Enabled = false;
            this.txtaccname.Location = new System.Drawing.Point(415, 20);
            this.txtaccname.Name = "txtaccname";
            this.txtaccname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaccname.Size = new System.Drawing.Size(151, 20);
            this.txtaccname.TabIndex = 154;
            this.txtaccname.Text = "إسم الحساب ";
            this.txtaccname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(327, 5);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 175;
            this.label4.Text = "نوع الحساب";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(18, 5);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 176;
            this.label7.Text = "عملة الحساب";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(559, 49);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 181;
            this.label8.Text = "*";
            // 
            // txtchildaccno
            // 
            this.txtchildaccno.Location = new System.Drawing.Point(551, 64);
            this.txtchildaccno.Name = "txtchildaccno";
            this.txtchildaccno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtchildaccno.Size = new System.Drawing.Size(98, 20);
            this.txtchildaccno.TabIndex = 180;
            this.txtchildaccno.Text = "رقم الحساب";
            this.txtchildaccno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(470, 49);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(72, 13);
            this.label9.TabIndex = 179;
            this.label9.Text = "إسم الحساب ";
            this.label9.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(579, 49);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(64, 13);
            this.label10.TabIndex = 178;
            this.label10.Text = "رقم الحساب";
            this.label10.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtchildName
            // 
            this.txtchildName.Location = new System.Drawing.Point(399, 64);
            this.txtchildName.Name = "txtchildName";
            this.txtchildName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtchildName.Size = new System.Drawing.Size(151, 20);
            this.txtchildName.TabIndex = 177;
            this.txtchildName.Text = "إسم الحساب ";
            this.txtchildName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(314, 49);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(71, 13);
            this.label11.TabIndex = 183;
            this.label11.Text = "عملة الحساب";
            this.label11.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cur
            // 
            this.cur.Location = new System.Drawing.Point(308, 64);
            this.cur.Name = "cur";
            this.cur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cur.Size = new System.Drawing.Size(86, 20);
            this.cur.TabIndex = 182;
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(416, 49);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 184;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(225, 49);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(74, 13);
            this.label14.TabIndex = 186;
            this.label14.Text = "سقف الحساب";
            this.label14.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtchildMaxBal
            // 
            this.txtchildMaxBal.Location = new System.Drawing.Point(207, 64);
            this.txtchildMaxBal.Name = "txtchildMaxBal";
            this.txtchildMaxBal.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtchildMaxBal.Size = new System.Drawing.Size(98, 20);
            this.txtchildMaxBal.TabIndex = 185;
            this.txtchildMaxBal.Text = "سقف الحساب";
            this.txtchildMaxBal.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // MyGrid
            // 
            this.MyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyGrid.Location = new System.Drawing.Point(0, 158);
            this.MyGrid.MainView = this.gridView1;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyGrid.Size = new System.Drawing.Size(897, 261);
            this.MyGrid.TabIndex = 187;
            this.MyGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grid1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1});
            this.gridView1.GridControl = this.MyGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grid1
            // 
            this.grid1.Caption = "رقم الحساب";
            this.grid1.FieldName = "accNO";
            this.grid1.Name = "grid1";
            this.grid1.OptionsColumn.AllowEdit = false;
            this.grid1.OptionsColumn.ReadOnly = true;
            this.grid1.Visible = true;
            this.grid1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "اسم الحساب ";
            this.gridColumn2.FieldName = "accName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "سقف الحساب";
            this.gridColumn3.FieldName = "accMaxBalance";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "نوع الحساب";
            this.gridColumn4.FieldName = "accType";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "عملة الحساب";
            this.gridColumn1.FieldName = "accCurrency";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(729, 49);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(124, 13);
            this.label15.TabIndex = 188;
            this.label15.Text = "معلومات الحساب الفرعي";
            this.label15.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.label15.Visible = false;
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(205, 49);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 189;
            this.label16.Text = "*";
            // 
            // comboBoxEdit1
            // 
            this.comboBoxEdit1.Location = new System.Drawing.Point(671, 67);
            this.comboBoxEdit1.Name = "comboBoxEdit1";
            this.comboBoxEdit1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.comboBoxEdit1.Size = new System.Drawing.Size(207, 20);
            this.comboBoxEdit1.TabIndex = 190;
            this.comboBoxEdit1.Visible = false;
            this.comboBoxEdit1.TextChanged += new System.EventHandler(this.comboBoxEdit1_TextChanged);
            // 
            // frmChildAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(897, 419);
            this.Controls.Add(this.comboBoxEdit1);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.txtchildMaxBal);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.cur);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtchildaccno);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtchildName);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.txtCure);
            this.Controls.Add(this.txtmainaccno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxBalance);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaccStatus);
            this.Controls.Add(this.txtaccname);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmChildAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحسابات الفرعية";
            this.Load += new System.EventHandler(this.frmChildAccounts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmChildAccounts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.acc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.comboBoxEdit1.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label12;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnactivate;
        private DevExpress.XtraEditors.SimpleButton btndeactivaete;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.TextBox txtAccType;
        private System.Windows.Forms.TextBox txtCure;
        private System.Windows.Forms.TextBox txtmainaccno;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxBalance;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.ComboBoxEdit acc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaccStatus;
        private System.Windows.Forms.TextBox txtaccname;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtchildaccno;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtchildName;
        private System.Windows.Forms.Label label11;
        private DevExpress.XtraEditors.ComboBoxEdit cur;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.TextBox txtchildMaxBal;
        private DevExpress.XtraGrid.GridControl MyGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grid1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label16;
        private DevExpress.XtraEditors.ComboBoxEdit comboBoxEdit1;
    }
}