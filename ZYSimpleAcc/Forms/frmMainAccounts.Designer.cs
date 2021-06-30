namespace ZYSimpleAcc.Forms
{
    partial class frmMainAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmMainAccounts));
            this.acc_type = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.txtaccStatus = new System.Windows.Forms.TextBox();
            this.txtaccname = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.acc = new DevExpress.XtraEditors.ComboBoxEdit();
            this.label5 = new System.Windows.Forms.Label();
            this.btnactivate = new DevExpress.XtraEditors.SimpleButton();
            this.btnadd = new DevExpress.XtraEditors.SimpleButton();
            this.btndeactivaete = new DevExpress.XtraEditors.SimpleButton();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.MyGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.label6 = new System.Windows.Forms.Label();
            this.txtMaxBalance = new System.Windows.Forms.TextBox();
            this.txtaccno = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.cur = new DevExpress.XtraEditors.ComboBoxEdit();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.txtCure = new System.Windows.Forms.TextBox();
            this.txtAccType = new System.Windows.Forms.TextBox();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.acc_type.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cur.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // acc_type
            // 
            this.acc_type.Location = new System.Drawing.Point(299, 57);
            this.acc_type.Name = "acc_type";
            this.acc_type.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.acc_type.Size = new System.Drawing.Size(112, 20);
            this.acc_type.TabIndex = 69;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(468, 41);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 13);
            this.label3.TabIndex = 74;
            this.label3.Text = "إسم الحساب ";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(608, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 13);
            this.label2.TabIndex = 73;
            this.label2.Text = "رقم الحساب";
            this.label2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtaccStatus
            // 
            this.txtaccStatus.Enabled = false;
            this.txtaccStatus.Location = new System.Drawing.Point(414, 87);
            this.txtaccStatus.Name = "txtaccStatus";
            this.txtaccStatus.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaccStatus.Size = new System.Drawing.Size(173, 20);
            this.txtaccStatus.TabIndex = 72;
            this.txtaccStatus.Text = "فعال";
            this.txtaccStatus.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtaccname
            // 
            this.txtaccname.Location = new System.Drawing.Point(414, 57);
            this.txtaccname.Name = "txtaccname";
            this.txtaccname.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaccname.Size = new System.Drawing.Size(173, 20);
            this.txtaccname.TabIndex = 71;
            this.txtaccname.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(593, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(66, 13);
            this.label1.TabIndex = 75;
            this.label1.Text = "حالة الحساب";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(339, 41);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(62, 13);
            this.label4.TabIndex = 76;
            this.label4.Text = "نوع الحساب";
            this.label4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // acc
            // 
            this.acc.Location = new System.Drawing.Point(391, 12);
            this.acc.Name = "acc";
            this.acc.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.acc.Size = new System.Drawing.Size(207, 20);
            this.acc.TabIndex = 77;
            this.acc.TextChanged += new System.EventHandler(this.acc_TextChanged);
            this.acc.Validated += new System.EventHandler(this.acc_Validated);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(604, 15);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(126, 13);
            this.label5.TabIndex = 78;
            this.label5.Text = "اختر الحساب المراد تعديله";
            this.label5.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // btnactivate
            // 
            this.btnactivate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnactivate.ImageOptions.Image")));
            this.btnactivate.Location = new System.Drawing.Point(402, 28);
            this.btnactivate.Name = "btnactivate";
            this.btnactivate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnactivate.Size = new System.Drawing.Size(67, 22);
            this.btnactivate.TabIndex = 84;
            this.btnactivate.Text = "تفعيل";
            this.btnactivate.Click += new System.EventHandler(this.btnactivate_Click);
            // 
            // btnadd
            // 
            this.btnadd.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnadd.ImageOptions.Image")));
            this.btnadd.Location = new System.Drawing.Point(676, 28);
            this.btnadd.Name = "btnadd";
            this.btnadd.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnadd.Size = new System.Drawing.Size(68, 22);
            this.btnadd.TabIndex = 83;
            this.btnadd.Text = "اضافة";
            this.btnadd.Click += new System.EventHandler(this.btnadd_Click);
            // 
            // btndeactivaete
            // 
            this.btndeactivaete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndeactivaete.ImageOptions.Image")));
            this.btndeactivaete.Location = new System.Drawing.Point(329, 28);
            this.btndeactivaete.Name = "btndeactivaete";
            this.btndeactivaete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndeactivaete.Size = new System.Drawing.Size(67, 22);
            this.btndeactivaete.TabIndex = 82;
            this.btndeactivaete.Text = "تجميد";
            this.btndeactivaete.Click += new System.EventHandler(this.btndeactivaete_Click);
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
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(475, 28);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(67, 22);
            this.btnupdate.TabIndex = 79;
            this.btnupdate.Text = "تعديل";
            this.btnupdate.Click += new System.EventHandler(this.btnupdate_Click);
            // 
            // MyGrid
            // 
            this.MyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyGrid.Location = new System.Drawing.Point(0, 175);
            this.MyGrid.MainView = this.gridView1;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyGrid.Size = new System.Drawing.Size(800, 199);
            this.MyGrid.TabIndex = 136;
            this.MyGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            this.MyGrid.Click += new System.EventHandler(this.MyGrid_Click);
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
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(219, 41);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(74, 13);
            this.label6.TabIndex = 138;
            this.label6.Text = "سقف الحساب";
            this.label6.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // txtMaxBalance
            // 
            this.txtMaxBalance.Enabled = false;
            this.txtMaxBalance.Location = new System.Drawing.Point(195, 57);
            this.txtMaxBalance.Name = "txtMaxBalance";
            this.txtMaxBalance.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtMaxBalance.Size = new System.Drawing.Size(98, 20);
            this.txtMaxBalance.TabIndex = 137;
            this.txtMaxBalance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtaccno
            // 
            this.txtaccno.Location = new System.Drawing.Point(589, 57);
            this.txtaccno.Name = "txtaccno";
            this.txtaccno.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaccno.Size = new System.Drawing.Size(98, 20);
            this.txtaccno.TabIndex = 139;
            this.txtaccno.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(116, 41);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(71, 13);
            this.label7.TabIndex = 141;
            this.label7.Text = "عملة الحساب";
            this.label7.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cur
            // 
            this.cur.Location = new System.Drawing.Point(103, 57);
            this.cur.Name = "cur";
            this.cur.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cur.Size = new System.Drawing.Size(86, 20);
            this.cur.TabIndex = 140;
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
            // btndelete
            // 
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.Location = new System.Drawing.Point(548, 28);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(68, 22);
            this.btndelete.TabIndex = 143;
            this.btndelete.Text = "حذف";
            this.btndelete.Click += new System.EventHandler(this.btndelete_Click);
            // 
            // txtCure
            // 
            this.txtCure.Enabled = false;
            this.txtCure.Location = new System.Drawing.Point(103, 84);
            this.txtCure.Name = "txtCure";
            this.txtCure.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtCure.Size = new System.Drawing.Size(86, 20);
            this.txtCure.TabIndex = 144;
            this.txtCure.Text = "عملة الحساب";
            this.txtCure.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtAccType
            // 
            this.txtAccType.Enabled = false;
            this.txtAccType.Location = new System.Drawing.Point(299, 87);
            this.txtAccType.Name = "txtAccType";
            this.txtAccType.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtAccType.Size = new System.Drawing.Size(112, 20);
            this.txtAccType.TabIndex = 146;
            this.txtAccType.Text = "نوع الحساب";
            this.txtAccType.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
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
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 113);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(800, 62);
            this.groupControl1.TabIndex = 147;
            this.groupControl1.Text = "خيارات الحسابات";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label8.ForeColor = System.Drawing.Color.Red;
            this.label8.Location = new System.Drawing.Point(448, 41);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(14, 13);
            this.label8.TabIndex = 148;
            this.label8.Text = "*";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label9.ForeColor = System.Drawing.Color.Red;
            this.label9.Location = new System.Drawing.Point(593, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(14, 13);
            this.label9.TabIndex = 149;
            this.label9.Text = "*";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label10.ForeColor = System.Drawing.Color.Red;
            this.label10.Location = new System.Drawing.Point(319, 41);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(14, 13);
            this.label10.TabIndex = 150;
            this.label10.Text = "*";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label11.ForeColor = System.Drawing.Color.Red;
            this.label11.Location = new System.Drawing.Point(199, 41);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(14, 13);
            this.label11.TabIndex = 151;
            this.label11.Text = "*";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Tahoma", 8F, System.Drawing.FontStyle.Bold);
            this.label12.ForeColor = System.Drawing.Color.Red;
            this.label12.Location = new System.Drawing.Point(104, 41);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(14, 13);
            this.label12.TabIndex = 152;
            this.label12.Text = "*";
            // 
            // frmMainAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonFace;
            this.ClientSize = new System.Drawing.Size(800, 374);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.txtAccType);
            this.Controls.Add(this.txtCure);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cur);
            this.Controls.Add(this.txtaccno);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtMaxBalance);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.acc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtaccStatus);
            this.Controls.Add(this.txtaccname);
            this.Controls.Add(this.acc_type);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmMainAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "الحسابات الرئيسية";
            this.Load += new System.EventHandler(this.frmMainAccounts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmMainAccounts_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.acc_type.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.acc.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cur.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private DevExpress.XtraEditors.ComboBoxEdit acc_type;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtaccStatus;
        private System.Windows.Forms.TextBox txtaccname;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraEditors.ComboBoxEdit acc;
        private System.Windows.Forms.Label label5;
        private DevExpress.XtraEditors.SimpleButton btnactivate;
        private DevExpress.XtraEditors.SimpleButton btnadd;
        private DevExpress.XtraEditors.SimpleButton btndeactivaete;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraGrid.GridControl MyGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grid1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtMaxBalance;
        private System.Windows.Forms.TextBox txtaccno;
        private System.Windows.Forms.Label label7;
        private DevExpress.XtraEditors.ComboBoxEdit cur;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private System.Windows.Forms.TextBox txtCure;
        private System.Windows.Forms.TextBox txtAccType;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
    }
}