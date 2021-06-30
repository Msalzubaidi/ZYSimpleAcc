namespace ZYSimpleAcc.Forms
{
    partial class frmCustomersAndVendors
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersAndVendors));
            this.MyGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn6 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label9 = new System.Windows.Forms.Label();
            this.txtType = new System.Windows.Forms.TextBox();
            this.toggleSwitch1 = new DevExpress.XtraEditors.ToggleSwitch();
            this.searchControl1 = new DevExpress.XtraEditors.SearchControl();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.active = new System.Windows.Forms.CheckBox();
            this.label8 = new System.Windows.Forms.Label();
            this.notactive = new System.Windows.Forms.CheckBox();
            this.txtMaxBalance = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtMail = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMobile = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtDetailedAddress = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtCusvenanme = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtcusvenid = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtMainAcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label18 = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtManfu = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnareas = new DevExpress.XtraEditors.SimpleButton();
            this.label12 = new System.Windows.Forms.Label();
            this.txtTaxNo = new System.Windows.Forms.TextBox();
            this.label20 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManfu.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // MyGrid
            // 
            this.MyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyGrid.Location = new System.Drawing.Point(0, 192);
            this.MyGrid.MainView = this.gridView1;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyGrid.Size = new System.Drawing.Size(917, 297);
            this.MyGrid.TabIndex = 188;
            this.MyGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.MyGrid.Click += new System.EventHandler(this.MyGrid_Click);
            this.MyGrid.DoubleClick += new System.EventHandler(this.MyGrid_DoubleClick);
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.grid1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn1,
            this.gridColumn5,
            this.gridColumn6});
            this.gridView1.GridControl = this.MyGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // grid1
            // 
            this.grid1.Caption = "الرقم";
            this.grid1.FieldName = "CusVenID";
            this.grid1.Name = "grid1";
            this.grid1.OptionsColumn.AllowEdit = false;
            this.grid1.OptionsColumn.ReadOnly = true;
            this.grid1.Visible = true;
            this.grid1.VisibleIndex = 0;
            this.grid1.Width = 78;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "الاسم";
            this.gridColumn2.FieldName = "CusVenName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            this.gridColumn2.Width = 191;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "سقف الرصيد";
            this.gridColumn3.FieldName = "CusVenMaxBalance";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 4;
            this.gridColumn3.Width = 159;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "الهاتف";
            this.gridColumn4.FieldName = "CusVenMobile";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            this.gridColumn4.Width = 94;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "البريد الالكتروني";
            this.gridColumn1.FieldName = "CusVenEmail";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 3;
            this.gridColumn1.Width = 172;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "العنوان";
            this.gridColumn5.FieldName = "CusVenDetailedAddress";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 5;
            this.gridColumn5.Width = 205;
            // 
            // gridColumn6
            // 
            this.gridColumn6.Caption = "الرقم الضريبي";
            this.gridColumn6.FieldName = "CusVenTaxNo";
            this.gridColumn6.Name = "gridColumn6";
            this.gridColumn6.Visible = true;
            this.gridColumn6.VisibleIndex = 6;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(878, 149);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(27, 13);
            this.label9.TabIndex = 217;
            this.label9.Text = "بحث";
            // 
            // txtType
            // 
            this.txtType.Enabled = false;
            this.txtType.Location = new System.Drawing.Point(552, 25);
            this.txtType.Name = "txtType";
            this.txtType.Size = new System.Drawing.Size(45, 20);
            this.txtType.TabIndex = 216;
            this.txtType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // toggleSwitch1
            // 
            this.toggleSwitch1.Location = new System.Drawing.Point(399, 27);
            this.toggleSwitch1.Name = "toggleSwitch1";
            this.toggleSwitch1.Properties.OffText = "عميل";
            this.toggleSwitch1.Properties.OnText = "مورد";
            this.toggleSwitch1.Size = new System.Drawing.Size(95, 23);
            this.toggleSwitch1.TabIndex = 215;
            this.toggleSwitch1.Toggled += new System.EventHandler(this.toggleSwitch1_Toggled_1);
            // 
            // searchControl1
            // 
            this.searchControl1.Location = new System.Drawing.Point(586, 165);
            this.searchControl1.Name = "searchControl1";
            this.searchControl1.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Repository.ClearButton(),
            new DevExpress.XtraEditors.Repository.SearchButton()});
            this.searchControl1.Size = new System.Drawing.Size(319, 20);
            this.searchControl1.TabIndex = 214;
            // 
            // btnadd
            // 
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.Location = new System.Drawing.Point(476, 149);
            this.btnadd.Name = "btnadd";
            this.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnadd.Size = new System.Drawing.Size(68, 22);
            this.btnadd.TabIndex = 211;
            this.btnadd.Text = "اضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click_1);
            // 
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(403, 149);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(67, 22);
            this.btnupdate.TabIndex = 208;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(138, 159);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(67, 22);
            this.simpleButton1.TabIndex = 212;
            this.simpleButton1.Text = "طباعة";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click_1);
            // 
            // btnclear
            // 
            this.btnclear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.ImageOptions.Image")));
            this.btnclear.Location = new System.Drawing.Point(211, 159);
            this.btnclear.Name = "btnclear";
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclear.Size = new System.Drawing.Size(99, 22);
            this.btnclear.TabIndex = 210;
            this.btnclear.Text = "تفريغ الحقول";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click_1);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(64, 159);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton2.Size = new System.Drawing.Size(67, 22);
            this.simpleButton2.TabIndex = 209;
            this.simpleButton2.Text = "اغلاق";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click_1);
            // 
            // active
            // 
            this.active.AutoSize = true;
            this.active.Checked = true;
            this.active.CheckState = System.Windows.Forms.CheckState.Checked;
            this.active.Location = new System.Drawing.Point(247, 136);
            this.active.Name = "active";
            this.active.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.active.Size = new System.Drawing.Size(47, 17);
            this.active.TabIndex = 207;
            this.active.Text = "فعال";
            this.active.UseVisualStyleBackColor = true;
            this.active.CheckedChanged += new System.EventHandler(this.active_CheckedChanged_1);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(319, 137);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(32, 13);
            this.label8.TabIndex = 206;
            this.label8.Text = "الحالة";
            // 
            // notactive
            // 
            this.notactive.AutoSize = true;
            this.notactive.Location = new System.Drawing.Point(175, 136);
            this.notactive.Name = "notactive";
            this.notactive.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.notactive.Size = new System.Drawing.Size(66, 17);
            this.notactive.TabIndex = 205;
            this.notactive.Text = "غير فعال";
            this.notactive.UseVisualStyleBackColor = true;
            this.notactive.CheckedChanged += new System.EventHandler(this.notactive_CheckedChanged_1);
            // 
            // txtMaxBalance
            // 
            this.txtMaxBalance.Location = new System.Drawing.Point(81, 85);
            this.txtMaxBalance.Name = "txtMaxBalance";
            this.txtMaxBalance.Size = new System.Drawing.Size(211, 20);
            this.txtMaxBalance.TabIndex = 204;
            this.txtMaxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(303, 89);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(67, 13);
            this.label7.TabIndex = 203;
            this.label7.Text = "سقف الرصيد";
            // 
            // txtMail
            // 
            this.txtMail.Location = new System.Drawing.Point(81, 56);
            this.txtMail.Name = "txtMail";
            this.txtMail.Size = new System.Drawing.Size(211, 20);
            this.txtMail.TabIndex = 201;
            this.txtMail.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtMail.Leave += new System.EventHandler(this.txtMail_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(299, 60);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(81, 13);
            this.label6.TabIndex = 200;
            this.label6.Text = "البريد الإلكتروني";
            // 
            // txtMobile
            // 
            this.txtMobile.Location = new System.Drawing.Point(81, 28);
            this.txtMobile.Name = "txtMobile";
            this.txtMobile.Size = new System.Drawing.Size(211, 20);
            this.txtMobile.TabIndex = 199;
            this.txtMobile.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(305, 32);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 13);
            this.label5.TabIndex = 198;
            this.label5.Text = "رقم الهاتف";
            // 
            // txtDetailedAddress
            // 
            this.txtDetailedAddress.Location = new System.Drawing.Point(399, 107);
            this.txtDetailedAddress.Name = "txtDetailedAddress";
            this.txtDetailedAddress.Size = new System.Drawing.Size(257, 20);
            this.txtDetailedAddress.TabIndex = 196;
            this.txtDetailedAddress.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(768, 114);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(38, 13);
            this.label4.TabIndex = 195;
            this.label4.Text = "العنوان";
            // 
            // txtCusvenanme
            // 
            this.txtCusvenanme.Location = new System.Drawing.Point(399, 81);
            this.txtCusvenanme.Name = "txtCusvenanme";
            this.txtCusvenanme.Size = new System.Drawing.Size(342, 20);
            this.txtCusvenanme.TabIndex = 194;
            this.txtCusvenanme.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(770, 85);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(36, 13);
            this.label3.TabIndex = 193;
            this.label3.Text = "الإسم";
            // 
            // txtcusvenid
            // 
            this.txtcusvenid.Enabled = false;
            this.txtcusvenid.Location = new System.Drawing.Point(603, 52);
            this.txtcusvenid.Name = "txtcusvenid";
            this.txtcusvenid.Size = new System.Drawing.Size(138, 20);
            this.txtcusvenid.TabIndex = 192;
            this.txtcusvenid.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(754, 56);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(67, 13);
            this.label2.TabIndex = 191;
            this.label2.Text = "رقم الحساب ";
            // 
            // txtMainAcc
            // 
            this.txtMainAcc.Enabled = false;
            this.txtMainAcc.Location = new System.Drawing.Point(603, 26);
            this.txtMainAcc.Name = "txtMainAcc";
            this.txtMainAcc.Size = new System.Drawing.Size(138, 20);
            this.txtMainAcc.TabIndex = 190;
            this.txtMainAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(744, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 13);
            this.label1.TabIndex = 189;
            this.label1.Text = "الحساب الرئيسي";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(754, 9);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(50, 16);
            this.label10.TabIndex = 218;
            this.label10.Text = "العنوان";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label16.ForeColor = System.Drawing.Color.Red;
            this.label16.Location = new System.Drawing.Point(583, 55);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(14, 13);
            this.label16.TabIndex = 220;
            this.label16.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(379, 84);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 221;
            this.label11.Text = "*";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label13.ForeColor = System.Drawing.Color.Red;
            this.label13.Location = new System.Drawing.Point(379, 110);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(14, 13);
            this.label13.TabIndex = 222;
            this.label13.Text = "*";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label14.ForeColor = System.Drawing.Color.Red;
            this.label14.Location = new System.Drawing.Point(61, 30);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(14, 13);
            this.label14.TabIndex = 223;
            this.label14.Text = "*";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label15.ForeColor = System.Drawing.Color.Red;
            this.label15.Location = new System.Drawing.Point(61, 63);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(14, 13);
            this.label15.TabIndex = 224;
            this.label15.Text = "*";
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label17.ForeColor = System.Drawing.Color.Red;
            this.label17.Location = new System.Drawing.Point(61, 89);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(14, 13);
            this.label17.TabIndex = 225;
            this.label17.Text = "*";
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label18.ForeColor = System.Drawing.Color.Red;
            this.label18.Location = new System.Drawing.Point(155, 138);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(14, 13);
            this.label18.TabIndex = 226;
            this.label18.Text = "*";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label19.ForeColor = System.Drawing.Color.Red;
            this.label19.Location = new System.Drawing.Point(400, 61);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(138, 13);
            this.label19.TabIndex = 227;
            this.label19.Text = "لماذا رقم الحساب فارغا ؟";
            this.label19.Click += new System.EventHandler(this.label19_Click);
            // 
            // txtManfu
            // 
            this.txtManfu.EditValue = "";
            this.txtManfu.Location = new System.Drawing.Point(662, 107);
            this.txtManfu.Name = "txtManfu";
            this.txtManfu.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.txtManfu.Size = new System.Drawing.Size(79, 20);
            this.txtManfu.TabIndex = 197;
            this.txtManfu.TextChanged += new System.EventHandler(this.txtManfu_TextChanged);
            // 
            // btnareas
            // 
            this.btnareas.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnareas.ImageOptions.Image")));
            this.btnareas.Location = new System.Drawing.Point(662, 134);
            this.btnareas.Name = "btnareas";
            this.btnareas.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnareas.Size = new System.Drawing.Size(79, 22);
            this.btnareas.TabIndex = 228;
            this.btnareas.Text = "العناوين";
            this.btnareas.Click += new System.EventHandler(this.btnareas_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(61, 114);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 231;
            this.label12.Text = "*";
            // 
            // txtTaxNo
            // 
            this.txtTaxNo.Location = new System.Drawing.Point(81, 110);
            this.txtTaxNo.Name = "txtTaxNo";
            this.txtTaxNo.Size = new System.Drawing.Size(211, 20);
            this.txtTaxNo.TabIndex = 230;
            this.txtTaxNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label20
            // 
            this.label20.AutoSize = true;
            this.label20.Location = new System.Drawing.Point(303, 114);
            this.label20.Name = "label20";
            this.label20.Size = new System.Drawing.Size(72, 13);
            this.label20.TabIndex = 229;
            this.label20.Text = "الرقم الضريبي";
            // 
            // frmCustomersAndVendors
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(917, 489);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.txtTaxNo);
            this.Controls.Add(this.label20);
            this.Controls.Add(this.btnareas);
            this.Controls.Add(this.label19);
            this.Controls.Add(this.label18);
            this.Controls.Add(this.label17);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label13);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.txtType);
            this.Controls.Add(this.toggleSwitch1);
            this.Controls.Add(this.searchControl1);
            this.Controls.Add(this.btnadd);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.active);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.notactive);
            this.Controls.Add(this.txtMaxBalance);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtMail);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMobile);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtManfu);
            this.Controls.Add(this.txtDetailedAddress);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtCusvenanme);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtcusvenid);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtMainAcc);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.MyGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmCustomersAndVendors";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملاء والموردين";
            this.Load += new System.EventHandler(this.frmCustomersAndVendors_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmCustomersAndVendors_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.toggleSwitch1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.searchControl1.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.txtManfu.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraGrid.GridControl MyGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grid1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtType;
        private DevExpress.XtraEditors.ToggleSwitch toggleSwitch1;
        private DevExpress.XtraEditors.SearchControl searchControl1;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private System.Windows.Forms.CheckBox active;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.CheckBox notactive;
        private System.Windows.Forms.TextBox txtMaxBalance;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtMail;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMobile;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtDetailedAddress;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtCusvenanme;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtcusvenid;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtMainAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label19;
        private DevExpress.XtraEditors.ComboBoxEdit txtManfu;
        private DevExpress.XtraEditors.SimpleButton btnareas;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.TextBox txtTaxNo;
        private System.Windows.Forms.Label label20;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn6;
    }
}