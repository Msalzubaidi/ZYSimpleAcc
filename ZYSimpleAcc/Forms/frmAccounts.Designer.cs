namespace ZYSimpleAcc.Forms
{
    partial class frmAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmAccounts));
            this.simpleButton3 = new DevExpress.XtraEditors.SimpleButton();
            this.simpleButton1 = new DevExpress.XtraEditors.SimpleButton();
            this.txtSalesAcc = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtBuyAcc = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.txtRetSalesAcc = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txtRetBuyAcc = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txtTaxAcc = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtSalaries = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtExpAcc = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtSaved = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.txtCustomers = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtVendors = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // simpleButton3
            // 
            this.simpleButton3.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton3.ImageOptions.Image")));
            this.simpleButton3.Location = new System.Drawing.Point(232, 252);
            this.simpleButton3.Name = "simpleButton3";
            this.simpleButton3.Size = new System.Drawing.Size(60, 23);
            this.simpleButton3.TabIndex = 11;
            this.simpleButton3.Text = "اغلاق";
            this.simpleButton3.Click += new System.EventHandler(this.simpleButton3_Click);
            // 
            // simpleButton1
            // 
            this.simpleButton1.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("simpleButton1.ImageOptions.Image")));
            this.simpleButton1.Location = new System.Drawing.Point(298, 252);
            this.simpleButton1.Name = "simpleButton1";
            this.simpleButton1.Size = new System.Drawing.Size(60, 23);
            this.simpleButton1.TabIndex = 9;
            this.simpleButton1.Text = "حفظ";
            this.simpleButton1.Click += new System.EventHandler(this.simpleButton1_Click);
            // 
            // txtSalesAcc
            // 
            this.txtSalesAcc.Enabled = false;
            this.txtSalesAcc.Location = new System.Drawing.Point(21, 30);
            this.txtSalesAcc.Name = "txtSalesAcc";
            this.txtSalesAcc.Size = new System.Drawing.Size(237, 20);
            this.txtSalesAcc.TabIndex = 1;
            this.txtSalesAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalesAcc.Leave += new System.EventHandler(this.txtSalesAcc_Leave);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(92, 14);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(100, 13);
            this.label1.TabIndex = 43;
            this.label1.Text = "رقم حساب المبيعات";
            // 
            // txtBuyAcc
            // 
            this.txtBuyAcc.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.txtBuyAcc.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.HistoryList;
            this.txtBuyAcc.Enabled = false;
            this.txtBuyAcc.Location = new System.Drawing.Point(268, 30);
            this.txtBuyAcc.Name = "txtBuyAcc";
            this.txtBuyAcc.Size = new System.Drawing.Size(237, 20);
            this.txtBuyAcc.TabIndex = 0;
            this.txtBuyAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBuyAcc.Leave += new System.EventHandler(this.txtBuyAcc_Leave);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(334, 14);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(110, 13);
            this.label2.TabIndex = 57;
            this.label2.Text = "رقم حساب المشتريات";
            // 
            // txtRetSalesAcc
            // 
            this.txtRetSalesAcc.Enabled = false;
            this.txtRetSalesAcc.Location = new System.Drawing.Point(21, 70);
            this.txtRetSalesAcc.Name = "txtRetSalesAcc";
            this.txtRetSalesAcc.Size = new System.Drawing.Size(237, 20);
            this.txtRetSalesAcc.TabIndex = 3;
            this.txtRetSalesAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetSalesAcc.TextChanged += new System.EventHandler(this.txtRetSalesAcc_TextChanged);
            this.txtRetSalesAcc.Leave += new System.EventHandler(this.txtRetSalesAcc_Leave);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(92, 55);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(85, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "رقم حساب م.بيع";
            // 
            // txtRetBuyAcc
            // 
            this.txtRetBuyAcc.Enabled = false;
            this.txtRetBuyAcc.Location = new System.Drawing.Point(268, 70);
            this.txtRetBuyAcc.Name = "txtRetBuyAcc";
            this.txtRetBuyAcc.Size = new System.Drawing.Size(237, 20);
            this.txtRetBuyAcc.TabIndex = 2;
            this.txtRetBuyAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtRetBuyAcc.TextChanged += new System.EventHandler(this.txtRetBuyAcc_TextChanged);
            this.txtRetBuyAcc.Leave += new System.EventHandler(this.txtRetBuyAcc_Leave);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(334, 55);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(95, 13);
            this.label4.TabIndex = 61;
            this.label4.Text = "رقم حساب م.شراء";
            // 
            // txtTaxAcc
            // 
            this.txtTaxAcc.Enabled = false;
            this.txtTaxAcc.Location = new System.Drawing.Point(21, 109);
            this.txtTaxAcc.Name = "txtTaxAcc";
            this.txtTaxAcc.Size = new System.Drawing.Size(237, 20);
            this.txtTaxAcc.TabIndex = 5;
            this.txtTaxAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtTaxAcc.Leave += new System.EventHandler(this.txtTaxAcc_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(92, 93);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(94, 13);
            this.label5.TabIndex = 63;
            this.label5.Text = "رقم حساب الضريبة";
            // 
            // txtSalaries
            // 
            this.txtSalaries.Enabled = false;
            this.txtSalaries.Location = new System.Drawing.Point(268, 109);
            this.txtSalaries.Name = "txtSalaries";
            this.txtSalaries.Size = new System.Drawing.Size(237, 20);
            this.txtSalaries.TabIndex = 4;
            this.txtSalaries.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtSalaries.Leave += new System.EventHandler(this.txtSalaries_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(336, 93);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(93, 13);
            this.label6.TabIndex = 65;
            this.label6.Text = "رقم حساب الرواتب";
            // 
            // txtExpAcc
            // 
            this.txtExpAcc.Enabled = false;
            this.txtExpAcc.Location = new System.Drawing.Point(21, 148);
            this.txtExpAcc.Name = "txtExpAcc";
            this.txtExpAcc.Size = new System.Drawing.Size(237, 20);
            this.txtExpAcc.TabIndex = 7;
            this.txtExpAcc.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtExpAcc.Leave += new System.EventHandler(this.txtExpAcc_Leave);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(92, 132);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(103, 13);
            this.label8.TabIndex = 67;
            this.label8.Text = "رقم حساب المصاريف";
            // 
            // txtSaved
            // 
            this.txtSaved.Enabled = false;
            this.txtSaved.Location = new System.Drawing.Point(118, 255);
            this.txtSaved.Name = "txtSaved";
            this.txtSaved.Size = new System.Drawing.Size(43, 20);
            this.txtSaved.TabIndex = 69;
            this.txtSaved.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(115, 239);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 13);
            this.label7.TabIndex = 70;
            this.label7.Text = "تم الحفظ";
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Location = new System.Drawing.Point(167, 257);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.checkBox1.Size = new System.Drawing.Size(51, 17);
            this.checkBox1.TabIndex = 10;
            this.checkBox1.Text = "تثبيت";
            this.checkBox1.UseVisualStyleBackColor = true;
            this.checkBox1.CheckedChanged += new System.EventHandler(this.checkBox1_CheckedChanged);
            // 
            // txtCustomers
            // 
            this.txtCustomers.Location = new System.Drawing.Point(268, 148);
            this.txtCustomers.Name = "txtCustomers";
            this.txtCustomers.Size = new System.Drawing.Size(237, 20);
            this.txtCustomers.TabIndex = 6;
            this.txtCustomers.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtCustomers.Leave += new System.EventHandler(this.txtCustomers_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(334, 132);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 13);
            this.label9.TabIndex = 72;
            this.label9.Text = "رقم حساب العملاء";
            // 
            // txtVendors
            // 
            this.txtVendors.Location = new System.Drawing.Point(130, 193);
            this.txtVendors.Name = "txtVendors";
            this.txtVendors.Size = new System.Drawing.Size(237, 20);
            this.txtVendors.TabIndex = 8;
            this.txtVendors.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtVendors.Leave += new System.EventHandler(this.txtVendors_Leave);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(196, 177);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(99, 13);
            this.label10.TabIndex = 74;
            this.label10.Text = "رقم حساب الموردين";
            // 
            // frmAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(529, 287);
            this.Controls.Add(this.txtVendors);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.txtCustomers);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.checkBox1);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txtSaved);
            this.Controls.Add(this.txtExpAcc);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.txtSalaries);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtTaxAcc);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtRetBuyAcc);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtRetSalesAcc);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txtBuyAcc);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.simpleButton3);
            this.Controls.Add(this.simpleButton1);
            this.Controls.Add(this.txtSalesAcc);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تخصيص الحسابات";
            this.Load += new System.EventHandler(this.frmAccounts_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmAccounts_KeyDown);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton simpleButton3;
        private DevExpress.XtraEditors.SimpleButton simpleButton1;
        private System.Windows.Forms.TextBox txtSalesAcc;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBuyAcc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox txtRetSalesAcc;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtRetBuyAcc;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox txtTaxAcc;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtSalaries;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtExpAcc;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtSaved;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.CheckBox checkBox1;
        private System.Windows.Forms.TextBox txtCustomers;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtVendors;
        private System.Windows.Forms.Label label10;
    }
}