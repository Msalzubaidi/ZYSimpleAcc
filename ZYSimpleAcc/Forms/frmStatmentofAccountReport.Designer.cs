namespace ZYSimpleAcc.Forms
{
    partial class frmStatmentofAccountReport
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmStatmentofAccountReport));
            this.txtaccNo = new System.Windows.Forms.TextBox();
            this.txtaccName = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dateFrom = new DevExpress.XtraEditors.DateEdit();
            this.dateTo = new DevExpress.XtraEditors.DateEdit();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.MyGrid = new DevExpress.XtraGrid.GridControl();
            this.gridView1 = new DevExpress.XtraGrid.Views.Grid.GridView();
            this.grid1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn2 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn3 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn4 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.gridColumn1 = new DevExpress.XtraGrid.Columns.GridColumn();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.btnToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtaccNo
            // 
            this.txtaccNo.Location = new System.Drawing.Point(542, 18);
            this.txtaccNo.Name = "txtaccNo";
            this.txtaccNo.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaccNo.Size = new System.Drawing.Size(160, 20);
            this.txtaccNo.TabIndex = 2;
            this.txtaccNo.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtaccName
            // 
            this.txtaccName.Location = new System.Drawing.Point(380, 18);
            this.txtaccName.Name = "txtaccName";
            this.txtaccName.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.txtaccName.Size = new System.Drawing.Size(160, 20);
            this.txtaccName.TabIndex = 3;
            this.txtaccName.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(595, 2);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "رقم الحساب";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(435, 2);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(69, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "إسم الحساب";
            // 
            // dateFrom
            // 
            this.dateFrom.EditValue = null;
            this.dateFrom.Location = new System.Drawing.Point(242, 18);
            this.dateFrom.Name = "dateFrom";
            this.dateFrom.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateFrom.Size = new System.Drawing.Size(132, 20);
            this.dateFrom.TabIndex = 65;
            // 
            // dateTo
            // 
            this.dateTo.EditValue = null;
            this.dateTo.Location = new System.Drawing.Point(104, 18);
            this.dateTo.Name = "dateTo";
            this.dateTo.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dateTo.Size = new System.Drawing.Size(132, 20);
            this.dateTo.TabIndex = 66;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(274, 2);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(45, 13);
            this.label3.TabIndex = 67;
            this.label3.Text = "من تاريخ";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(148, 2);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 68;
            this.label4.Text = "إلى تاريخ";
            // 
            // MyGrid
            // 
            this.MyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyGrid.Location = new System.Drawing.Point(0, 103);
            this.MyGrid.MainView = this.gridView1;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyGrid.Size = new System.Drawing.Size(874, 308);
            this.MyGrid.TabIndex = 137;
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
            this.grid1.Caption = "رقم الحركة";
            this.grid1.FieldName = "accNO";
            this.grid1.Name = "grid1";
            this.grid1.OptionsColumn.AllowEdit = false;
            this.grid1.OptionsColumn.ReadOnly = true;
            this.grid1.Visible = true;
            this.grid1.VisibleIndex = 0;
            // 
            // gridColumn2
            // 
            this.gridColumn2.Caption = "نوع الحركة";
            this.gridColumn2.FieldName = "accName";
            this.gridColumn2.Name = "gridColumn2";
            this.gridColumn2.OptionsColumn.AllowEdit = false;
            this.gridColumn2.OptionsColumn.ReadOnly = true;
            this.gridColumn2.Visible = true;
            this.gridColumn2.VisibleIndex = 1;
            // 
            // gridColumn3
            // 
            this.gridColumn3.Caption = "القيمة";
            this.gridColumn3.FieldName = "accMaxBalance";
            this.gridColumn3.Name = "gridColumn3";
            this.gridColumn3.OptionsColumn.AllowEdit = false;
            this.gridColumn3.OptionsColumn.ReadOnly = true;
            this.gridColumn3.Visible = true;
            this.gridColumn3.VisibleIndex = 3;
            // 
            // gridColumn4
            // 
            this.gridColumn4.Caption = "التاريخ";
            this.gridColumn4.FieldName = "accType";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 2;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "الرصيد";
            this.gridColumn1.FieldName = "accCurrency";
            this.gridColumn1.Name = "gridColumn1";
            this.gridColumn1.Visible = true;
            this.gridColumn1.VisibleIndex = 4;
            // 
            // groupControl1
            // 
            this.groupControl1.Controls.Add(this.btnToExcel);
            this.groupControl1.Controls.Add(this.btnView);
            this.groupControl1.Controls.Add(this.btnPrint);
            this.groupControl1.Controls.Add(this.btnclear);
            this.groupControl1.Controls.Add(this.btnClose);
            this.groupControl1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.groupControl1.Location = new System.Drawing.Point(0, 44);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.groupControl1.Size = new System.Drawing.Size(874, 59);
            this.groupControl1.TabIndex = 148;
            this.groupControl1.Text = "خيارات الحسابات";
            // 
            // btnToExcel
            // 
            this.btnToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnToExcel.ImageOptions.Image")));
            this.btnToExcel.Location = new System.Drawing.Point(259, 31);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnToExcel.Size = new System.Drawing.Size(168, 22);
            this.btnToExcel.TabIndex = 144;
            this.btnToExcel.Text = "تصدير لإكسل";
            // 
            // btnView
            // 
            this.btnView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnView.ImageOptions.Image")));
            this.btnView.Location = new System.Drawing.Point(683, 29);
            this.btnView.Name = "btnView";
            this.btnView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnView.Size = new System.Drawing.Size(168, 22);
            this.btnView.TabIndex = 143;
            this.btnView.Text = "عرض";
            this.btnView.Click += new System.EventHandler(this.btnView_Click);
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(85, 30);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrint.Size = new System.Drawing.Size(168, 22);
            this.btnPrint.TabIndex = 142;
            this.btnPrint.Text = "طباعة";
            // 
            // btnclear
            // 
            this.btnclear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.ImageOptions.Image")));
            this.btnclear.Location = new System.Drawing.Point(509, 29);
            this.btnclear.Name = "btnclear";
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclear.Size = new System.Drawing.Size(168, 22);
            this.btnclear.TabIndex = 81;
            this.btnclear.Text = "تفريغ الحقول";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(12, 29);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(67, 22);
            this.btnClose.TabIndex = 80;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(708, 15);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton3.Size = new System.Drawing.Size(154, 22);
            this.simpleButton3.TabIndex = 143;
            this.simpleButton3.Text = "إختيار حساب";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // frmStatmentofAccountReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(874, 411);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.groupControl1);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.dateTo);
            this.Controls.Add(this.dateFrom);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtaccName);
            this.Controls.Add(this.txtaccNo);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmStatmentofAccountReport";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "كشف حساب";
            this.Load += new System.EventHandler(this.frmStatmentofAccountReport_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmStatmentofAccountReport_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateFrom.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dateTo.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtaccNo;
        private System.Windows.Forms.TextBox txtaccName;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private DevExpress.XtraEditors.DateEdit dateFrom;
        private DevExpress.XtraEditors.DateEdit dateTo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private DevExpress.XtraGrid.GridControl MyGrid;
        private DevExpress.XtraGrid.Views.Grid.GridView gridView1;
        private DevExpress.XtraGrid.Columns.GridColumn grid1;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn2;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn3;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn4;
        private DevExpress.XtraGrid.Columns.GridColumn gridColumn1;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton btnClose;
        private DevExpress.XtraEditors.SimpleButton btnToExcel;
        private DevExpress.XtraEditors.SimpleButton btnView;
    }
}