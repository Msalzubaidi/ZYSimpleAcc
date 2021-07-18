namespace ZYSimpleAcc.Forms
{
    partial class frmUserLogTransactions
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUserLogTransactions));
            this.simpleButton5 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton4 = new DevExpress.XtraEditors.SimpleButton();
            this.chk_all = new System.Windows.Forms.CheckBox();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton2 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
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
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.cbopaytype = new DevExpress.XtraEditors.ComboBoxEdit();
            ((System.ComponentModel.ISupportInitialize)(this.cbo_transtype.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbopaytype.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // simpleButton5
            // 
            this.simpleButton5.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton5.ImageOptions.Image")));
            this.simpleButton5.Location = new System.Drawing.Point(6, 22);
            this.simpleButton5.Name = "simpleButton5";
            this.simpleButton5.Size = new System.Drawing.Size(104, 23);
            this.simpleButton5.TabIndex = 134;
            this.simpleButton5.Text = "تصدير لإكسل";
            this.simpleButton5.Click += new System.EventHandler(this.simpleButton5_Click);
            // 
            // simpleButton4
            // 
            this.simpleButton4.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton4.ImageOptions.Image")));
            this.simpleButton4.Location = new System.Drawing.Point(116, 22);
            this.simpleButton4.Name = "simpleButton4";
            this.simpleButton4.Size = new System.Drawing.Size(57, 23);
            this.simpleButton4.TabIndex = 133;
            this.simpleButton4.Text = "طباعة";
            this.simpleButton4.Click += new System.EventHandler(this.simpleButton4_Click);
            // 
            // chk_all
            // 
            this.chk_all.AutoSize = true;
            this.chk_all.Checked = true;
            this.chk_all.CheckState = System.Windows.Forms.CheckState.Checked;
            this.chk_all.Location = new System.Drawing.Point(355, 28);
            this.chk_all.Name = "chk_all";
            this.chk_all.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.chk_all.Size = new System.Drawing.Size(116, 17);
            this.chk_all.TabIndex = 132;
            this.chk_all.Text = "عرض جميع الحركات";
            this.chk_all.UseVisualStyleBackColor = true;
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(238, 22);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(54, 23);
            this.simpleButton3.TabIndex = 131;
            this.simpleButton3.Text = "اغلاق";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton2
            // 
            this.simpleButton2.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton2.ImageOptions.Image")));
            this.simpleButton2.Location = new System.Drawing.Point(179, 22);
            this.simpleButton2.Name = "simpleButton2";
            this.simpleButton2.Size = new System.Drawing.Size(54, 23);
            this.simpleButton2.TabIndex = 130;
            this.simpleButton2.Text = "مسح";
            this.simpleButton2.Click += new System.EventHandler(this.simpleButton2_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(295, 22);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(57, 23);
            this.simpleButton1.TabIndex = 129;
            this.simpleButton1.Text = "عرض";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(604, 6);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(47, 13);
            this.labelControl3.TabIndex = 128;
            this.labelControl3.Text = "نوع الحركة";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(719, 7);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(17, 13);
            this.labelControl2.TabIndex = 127;
            this.labelControl2.Text = "الى";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(812, 7);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(14, 13);
            this.labelControl1.TabIndex = 126;
            this.labelControl1.Text = "من";
            // 
            // cbo_transtype
            // 
            this.cbo_transtype.Location = new System.Drawing.Point(580, 25);
            this.cbo_transtype.Name = "cbo_transtype";
            this.cbo_transtype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbo_transtype.Size = new System.Drawing.Size(102, 20);
            this.cbo_transtype.TabIndex = 125;
            // 
            // dtp_to
            // 
            this.dtp_to.EditValue = null;
            this.dtp_to.Location = new System.Drawing.Point(688, 26);
            this.dtp_to.Name = "dtp_to";
            this.dtp_to.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_to.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_to.Size = new System.Drawing.Size(88, 20);
            this.dtp_to.TabIndex = 124;
            this.dtp_to.EditValueChanged += new System.EventHandler(this.dtp_to_EditValueChanged);
            // 
            // dtp_from
            // 
            this.dtp_from.EditValue = null;
            this.dtp_from.Location = new System.Drawing.Point(779, 26);
            this.dtp_from.Name = "dtp_from";
            this.dtp_from.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_from.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.dtp_from.Size = new System.Drawing.Size(90, 20);
            this.dtp_from.TabIndex = 123;
            // 
            // MyGrid
            // 
            this.MyGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.MyGrid.Location = new System.Drawing.Point(0, 54);
            this.MyGrid.MainView = this.gridView1;
            this.MyGrid.Name = "MyGrid";
            this.MyGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.MyGrid.Size = new System.Drawing.Size(877, 304);
            this.MyGrid.TabIndex = 135;
            this.MyGrid.ViewCollection.AddRange(new DevExpress.XtraGrid.Views.Base.BaseView[] {
            this.gridView1});
            // 
            // gridView1
            // 
            this.gridView1.Columns.AddRange(new DevExpress.XtraGrid.Columns.GridColumn[] {
            this.gridColumn1,
            this.gridColumn2,
            this.gridColumn3,
            this.gridColumn4});
            this.gridView1.GridControl = this.MyGrid;
            this.gridView1.Name = "gridView1";
            this.gridView1.OptionsView.ShowGroupPanel = false;
            // 
            // gridColumn1
            // 
            this.gridColumn1.Caption = "اسم المستخدم";
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
            this.gridColumn4.Caption = "الجهاز";
            this.gridColumn4.FieldName = "ComputerName";
            this.gridColumn4.Name = "gridColumn4";
            this.gridColumn4.OptionsColumn.AllowEdit = false;
            this.gridColumn4.OptionsColumn.ReadOnly = true;
            this.gridColumn4.Visible = true;
            this.gridColumn4.VisibleIndex = 3;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(502, 6);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(53, 13);
            this.labelControl4.TabIndex = 137;
            this.labelControl4.Text = "طريقة الدفع";
            // 
            // cbopaytype
            // 
            this.cbopaytype.Location = new System.Drawing.Point(474, 25);
            this.cbopaytype.Name = "cbopaytype";
            this.cbopaytype.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.cbopaytype.Size = new System.Drawing.Size(102, 20);
            this.cbopaytype.TabIndex = 136;
            // 
            // frmUserLogTransactions
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(877, 358);
            this.Controls.Add(this.labelControl4);
            this.Controls.Add(this.cbopaytype);
            this.Controls.Add(this.MyGrid);
            this.Controls.Add(this.simpleButton5);
            this.Controls.Add(this.simpleButton4);
            this.Controls.Add(this.chk_all);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton2);
            this.Controls.Add(this.simpleButton1);
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
            this.Name = "frmUserLogTransactions";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "سجل حركات النظام";
            this.Load += new System.EventHandler(this.frmUserLogTransactions_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmUserLogTransactions_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.cbo_transtype.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_to.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dtp_from.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.MyGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.gridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cbopaytype.Properties)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton5;
        private DevExpress.XtraEditors.SimpleButton simpleButton4;
        private System.Windows.Forms.CheckBox chk_all;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton2;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
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
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.ComboBoxEdit cbopaytype;
    }
}