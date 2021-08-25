namespace ZYSimpleAcc.Forms
{
    partial class frmTransactionsReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmTransactionsReports));
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbopaytype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.btnToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.btnClear = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.cbo_transtype = new DevExpress.XtraEditors.ComboBoxEdit();
            this.dtp_to = new DevExpress.XtraEditors.DateEdit();
            this.dtp_from = new DevExpress.XtraEditors.DateEdit();
            this.MyGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn5 = new DevExpress.XtraGrid.Columns.GridColumn();
            ((System.ComponentModel.ISupportInitialize)(this.cbopaytype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_transtype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(533, 9);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 151;
            this.labelControl4.Text = "طريقة الدفع";
            // 
            // cbopaytype
            // 
            this.cbopaytype.Location = new System.Drawing.Point(504, 28);
            this.cbopaytype.Name = "cbopaytype";
            this.cbopaytype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbopaytype.Size = new System.Drawing.Size(102, 20);
            this.cbopaytype.TabIndex = 150;
            // 
            // btnToExcel
            // 
            this.btnToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.btnToExcel.Location = new System.Drawing.Point(23, 25);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.Size = new System.Drawing.Size(104, 23);
            this.btnToExcel.TabIndex = 149;
            this.btnToExcel.Text = "تصدير لإكسل";
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(133, 25);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.Size = new System.Drawing.Size(57, 23);
            this.btnPrint.TabIndex = 148;
            this.btnPrint.Text = "طباعة";
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Checked = true;
            this.chk_all.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_all.Location = new System.Drawing.Point(382, 30);
            this.chk_all.Name = "chk_all";
            this.chk_all.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_all.Size = new System.Drawing.Size(116, 17);
            this.chk_all.TabIndex = 147;
            this.chk_all.Text = "عرض جميع الحركات";
            this.chk_all.UseVisualStyleBackColor = true;
            this.chk_all.CheckedChanged += new System.EventHandler(this.chk_all_CheckedChanged);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(255, 25);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(54, 23);
            this.btnClose.TabIndex = 146;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // btnClear
            // 
            this.btnClear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.btnClear.Location = new System.Drawing.Point(196, 25);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(54, 23);
            this.btnClear.TabIndex = 145;
            this.btnClear.Text = "مسح";
            // 
            // btnView
            // 
            this.btnView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.btnView.Location = new System.Drawing.Point(312, 25);
            this.btnView.Name = "btnView";
            this.btnView.Size = new System.Drawing.Size(57, 23);
            this.btnView.TabIndex = 144;
            this.btnView.Text = "عرض";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(647, 9);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 143;
            this.labelControl3.Text = "نوع الحركة";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(768, 9);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(41, 13);
            this.labelControl2.TabIndex = 142;
            this.labelControl2.Text = "الى تاريخ";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(873, 12);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 141;
            this.labelControl1.Text = "من تاريخ";
            // 
            // cbo_transtype
            // 
            this.cbo_transtype.Location = new System.Drawing.Point(609, 28);
            this.cbo_transtype.Name = "cbo_transtype";
            this.cbo_transtype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_transtype.Size = new System.Drawing.Size(131, 20);
            this.cbo_transtype.TabIndex = 140;
            // 
            // dtp_to
            // 
            this.dtp_to.EditValue = null;
            this.dtp_to.Location = new System.Drawing.Point(746, 28);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_to.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_to.Size = new System.Drawing.Size(88, 20);
            this.dtp_to.TabIndex = 139;
            // 
            // dtp_from
            // 
            this.dtp_from.EditValue = null;
            this.dtp_from.Location = new System.Drawing.Point(839, 28);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_from.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_from.Size = new System.Drawing.Size(90, 20);
            this.dtp_from.TabIndex = 138;
            // 
            // MyGrid
            // 
            this.MyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyGrid.Location = new System.Drawing.Point(0, 53);
            this.MyGrid.MainView = this.gridView1;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyGrid.Size = new System.Drawing.Size(951, 299);
            this.MyGrid.TabIndex = 152;
            this.MyGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4,
            this.gridColumn5});
            this.gridView1.GridControl = this.MyGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "رقم الحركة";
            this.gridColumn1.FieldName = "Username";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.OptionsColumn.AllowEdit = false;
            this.gridColumn1.OptionsColumn.ReadOnly = true;
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "نوع الحركة";
            this.gridColumn2.FieldName = "TransType";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "تاريخ الحركة";
            this.gridColumn3.FieldName = "transDate";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 2;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "القيمة";
            this.gridColumn4.FieldName = "ComputerName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // gridColumn5
            // 
            this.gridColumn5.Caption = "الوصف";
            this.gridColumn5.Name = "gridColumn5";
            this.gridColumn5.Visible = true;
            this.gridColumn5.VisibleIndex = 4;
            // 
            // frmTransactionsReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(951, 352);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbopaytype);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.chk_all);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.btnClear);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.labelControl3);
            this.Controls.Add(this.labelControl2);
            this.Controls.Add(this.labelControl1);
            this.Controls.Add(this.cbo_transtype);
            this.Controls.Add(this.dtp_to);
            this.Controls.Add(this.dtp_from);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmTransactionsReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير الحركات";
            ((System.ComponentModel.ISupportInitialize)(this.cbopaytype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_transtype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbopaytype;
        private DevExpress.XtraEditors.SimpleButton btnToExcel;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private System.Windows.Forms.CheckBox chk_all;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnClear;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit cbo_transtype;
        private DevExpress.XtraEditors.DateEdit dtp_to;
        private DevExpress.XtraEditors.DateEdit dtp_from;
        private DevExpress.XtraGrid.GridControl MyGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn5;
    }
}