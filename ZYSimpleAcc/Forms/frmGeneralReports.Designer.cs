namespace ZYSimpleAcc.Forms
{
    partial class frmGeneralReports
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGeneralReports));
            this.btnToExcel = new DevExpress.XtraEditors.SimpleButton();
            this.btnView = new DevExpress.XtraEditors.SimpleButton();
            this.btnPrint = new DevExpress.XtraEditors.SimpleButton();
            this.btnclear = new DevExpress.XtraEditors.SimpleButton();
            this.btnClose = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // btnToExcel
            // 
            this.btnToExcel.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnToExcel.ImageOptions.Image")));
            this.btnToExcel.Location = new System.Drawing.Point(324, 28);
            this.btnToExcel.Name = "btnToExcel";
            this.btnToExcel.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnToExcel.Size = new System.Drawing.Size(168, 22);
            this.btnToExcel.TabIndex = 149;
            this.btnToExcel.Text = "تصدير لإكسل";
            // 
            // btnView
            // 
            this.btnView.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnView.ImageOptions.Image")));
            this.btnView.Location = new System.Drawing.Point(748, 26);
            this.btnView.Name = "btnView";
            this.btnView.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnView.Size = new System.Drawing.Size(168, 22);
            this.btnView.TabIndex = 148;
            this.btnView.Text = "عرض";
            // 
            // btnPrint
            // 
            this.btnPrint.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnPrint.ImageOptions.Image")));
            this.btnPrint.Location = new System.Drawing.Point(150, 27);
            this.btnPrint.Name = "btnPrint";
            this.btnPrint.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnPrint.Size = new System.Drawing.Size(168, 22);
            this.btnPrint.TabIndex = 147;
            this.btnPrint.Text = "طباعة";
            // 
            // btnclear
            // 
            this.btnclear.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnclear.ImageOptions.Image")));
            this.btnclear.Location = new System.Drawing.Point(574, 26);
            this.btnclear.Name = "btnclear";
            this.btnclear.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnclear.Size = new System.Drawing.Size(168, 22);
            this.btnclear.TabIndex = 146;
            this.btnclear.Text = "تفريغ الحقول";
            // 
            // btnClose
            // 
            this.btnClose.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.ImageOptions.Image")));
            this.btnClose.Location = new System.Drawing.Point(77, 26);
            this.btnClose.Name = "btnClose";
            this.btnClose.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnClose.Size = new System.Drawing.Size(67, 22);
            this.btnClose.TabIndex = 145;
            this.btnClose.Text = "اغلاق";
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmGeneralReports
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1025, 337);
            this.Controls.Add(this.btnToExcel);
            this.Controls.Add(this.btnView);
            this.Controls.Add(this.btnPrint);
            this.Controls.Add(this.btnclear);
            this.Controls.Add(this.btnClose);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmGeneralReports";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "تقارير عامة";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton btnToExcel;
        private DevExpress.XtraEditors.SimpleButton btnView;
        private DevExpress.XtraEditors.SimpleButton btnPrint;
        private DevExpress.XtraEditors.SimpleButton btnclear;
        private DevExpress.XtraEditors.SimpleButton btnClose;
    }
}