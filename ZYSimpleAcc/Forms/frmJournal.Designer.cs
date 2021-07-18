namespace ZYSimpleAcc.Forms
{
    partial class frmJournal
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmJournal));
            this.txtTransID = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.datetransdate = new DevExpress.XtraEditors.DateEdit();
            this.JournalGrid = new System.Windows.Forms.DataGridView();
            this.label1 = new System.Windows.Forms.Label();
            this.txtTransNote = new System.Windows.Forms.TextBox();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnsaveandprint = new DevExpress.XtraEditors.SimpleButton();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.btnclose = new DevExpress.XtraEditors.SimpleButton();
            this.btnsave = new DevExpress.XtraEditors.SimpleButton();
            this.btndelete = new DevExpress.XtraEditors.SimpleButton();
            this.btnupdate = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtLastNum = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.AccNo = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.AccName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.anountDebit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.amountCredit = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.desc = new System.Windows.Forms.DataGridViewTextBoxColumn();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties.CalendarTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // txtTransID
            // 
            this.txtTransID.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransID.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTransID.Enabled = false;
            this.txtTransID.Location = new System.Drawing.Point(524, 6);
            this.txtTransID.Name = "txtTransID";
            this.txtTransID.Size = new System.Drawing.Size(99, 20);
            this.txtTransID.TabIndex = 58;
            this.txtTransID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTransID.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtTransID_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(629, 10);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(49, 13);
            this.label2.TabIndex = 59;
            this.label2.Text = "رقم القيد";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(466, 10);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(35, 13);
            this.label3.TabIndex = 65;
            this.label3.Text = "التاريخ";
            // 
            // datetransdate
            // 
            this.datetransdate.EditValue = null;
            this.datetransdate.Location = new System.Drawing.Point(328, 7);
            this.datetransdate.Name = "datetransdate";
            this.datetransdate.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetransdate.Properties.CalendarTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.datetransdate.Size = new System.Drawing.Size(132, 20);
            this.datetransdate.TabIndex = 64;
            // 
            // JournalGrid
            // 
            this.JournalGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.JournalGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.AccNo,
            this.AccName,
            this.anountDebit,
            this.amountCredit,
            this.desc});
            this.JournalGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.JournalGrid.Location = new System.Drawing.Point(0, 98);
            this.JournalGrid.Name = "JournalGrid";
            this.JournalGrid.Size = new System.Drawing.Size(696, 258);
            this.JournalGrid.TabIndex = 66;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(629, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 13);
            this.label1.TabIndex = 68;
            this.label1.Text = "ملاحظات";
            // 
            // txtTransNote
            // 
            this.txtTransNote.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtTransNote.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtTransNote.Location = new System.Drawing.Point(114, 32);
            this.txtTransNote.Name = "txtTransNote";
            this.txtTransNote.Size = new System.Drawing.Size(509, 20);
            this.txtTransNote.TabIndex = 67;
            this.txtTransNote.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // btnView
            // 
            this.btnView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnView.ImageOptions.Image")));
            this.btnView.Location = new System.Drawing.Point(239, 70);
            this.btnView.Name = "btnView";
            this.btnView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnView.Size = new System.Drawing.Size(63, 22);
            this.btnView.TabIndex = 398;
            this.btnView.Text = "عرض";
            // 
            // btnsaveandprint
            // 
            this.btnsaveandprint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsaveandprint.ImageOptions.Image")));
            this.btnsaveandprint.Location = new System.Drawing.Point(516, 70);
            this.btnsaveandprint.Name = "btnsaveandprint";
            this.btnsaveandprint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsaveandprint.Size = new System.Drawing.Size(86, 22);
            this.btnsaveandprint.TabIndex = 397;
            this.btnsaveandprint.Text = "حفظ وطباعة";
            // 
            // btnclear
            // 
            this.btnclear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.ImageOptions.Image")));
            this.btnclear.Location = new System.Drawing.Point(115, 70);
            this.btnclear.Name = "btnclear";
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclear.Size = new System.Drawing.Size(118, 22);
            this.btnclear.TabIndex = 396;
            this.btnclear.Text = "تفريغ جميع الحقول";
            this.btnclear.Click += new System.EventHandler(this.btnclear_Click);
            // 
            // btnclose
            // 
            this.btnclose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclose.ImageOptions.Image")));
            this.btnclose.Location = new System.Drawing.Point(308, 70);
            this.btnclose.Name = "btnclose";
            this.btnclose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclose.Size = new System.Drawing.Size(63, 22);
            this.btnclose.TabIndex = 395;
            this.btnclose.Text = "اغلاق";
            this.btnclose.Click += new System.EventHandler(this.btnclose_Click);
            // 
            // btnsave
            // 
            this.btnsave.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnsave.ImageOptions.Image")));
            this.btnsave.Location = new System.Drawing.Point(608, 70);
            this.btnsave.Name = "btnsave";
            this.btnsave.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnsave.Size = new System.Drawing.Size(63, 22);
            this.btnsave.TabIndex = 393;
            this.btnsave.Text = "حفظ";
            // 
            // btndelete
            // 
            this.btndelete.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btndelete.ImageOptions.Image")));
            this.btndelete.Location = new System.Drawing.Point(378, 70);
            this.btndelete.Name = "btndelete";
            this.btndelete.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btndelete.Size = new System.Drawing.Size(63, 22);
            this.btndelete.TabIndex = 394;
            this.btndelete.Text = "إلغاء";
            // 
            // btnupdate
            // 
            this.btnupdate.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnupdate.ImageOptions.Image")));
            this.btnupdate.Location = new System.Drawing.Point(447, 70);
            this.btnupdate.Name = "btnupdate";
            this.btnupdate.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnupdate.Size = new System.Drawing.Size(63, 22);
            this.btnupdate.TabIndex = 392;
            this.btnupdate.Text = "تعديل";
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(8, 70);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton3.Size = new System.Drawing.Size(96, 22);
            this.simpleButton3.TabIndex = 401;
            this.simpleButton3.Text = "حذف الكل";
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(6, 42);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.simpleButton1.Size = new System.Drawing.Size(98, 22);
            this.simpleButton1.TabIndex = 400;
            this.simpleButton1.Text = "حذف المحدد";
            // 
            // txtLastNum
            // 
            this.txtLastNum.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtLastNum.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtLastNum.Enabled = false;
            this.txtLastNum.Location = new System.Drawing.Point(114, 6);
            this.txtLastNum.Name = "txtLastNum";
            this.txtLastNum.Size = new System.Drawing.Size(99, 20);
            this.txtLastNum.TabIndex = 402;
            this.txtLastNum.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(219, 10);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(60, 13);
            this.label4.TabIndex = 403;
            this.label4.Text = "رقم آخر قيد";
            // 
            // AccNo
            // 
            this.AccNo.HeaderText = "رقم الحساب";
            this.AccNo.Name = "AccNo";
            // 
            // AccName
            // 
            this.AccName.HeaderText = "اسم الحساب";
            this.AccName.Name = "AccName";
            // 
            // anountDebit
            // 
            this.anountDebit.HeaderText = "المبلغ المدين";
            this.anountDebit.Name = "anountDebit";
            // 
            // amountCredit
            // 
            this.amountCredit.HeaderText = "المبلغ الدائن";
            this.amountCredit.Name = "amountCredit";
            // 
            // desc
            // 
            this.desc.HeaderText = "وصف الحركة";
            this.desc.Name = "desc";
            // 
            // frmJournal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(696, 356);
            this.Controls.Add(this.txtLastNum);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnsaveandprint);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnclose);
            this.Controls.Add(this.btnsave);
            this.Controls.Add(this.btndelete);
            this.Controls.Add(this.btnupdate);
            this.Controls.Add(this.txtTransNote);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.JournalGrid);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.datetransdate);
            this.Controls.Add(this.txtTransID);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmJournal";
            this.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "القيد";
            this.Load += new System.EventHandler(this.frmJournal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties.CalendarTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.datetransdate.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.JournalGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox txtTransID;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private DevExpress.XtraEditors.DateEdit datetransdate;
        private System.Windows.Forms.DataGridView JournalGrid;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtTransNote;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.SimpleButton btnsaveandprint;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton btnclose;
        private DevExpress.XtraEditors.SimpleButton btnsave;
        private DevExpress.XtraEditors.SimpleButton btndelete;
        private DevExpress.XtraEditors.SimpleButton btnupdate;
        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtLastNum;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccNo;
        private System.Windows.Forms.DataGridViewTextBoxColumn AccName;
        private System.Windows.Forms.DataGridViewTextBoxColumn anountDebit;
        private System.Windows.Forms.DataGridViewTextBoxColumn amountCredit;
        private System.Windows.Forms.DataGridViewTextBoxColumn desc;
    }
}