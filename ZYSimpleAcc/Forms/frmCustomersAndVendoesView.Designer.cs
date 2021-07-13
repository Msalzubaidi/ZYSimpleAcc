namespace ZYSimpleAcc.Forms
{
    partial class frmCustomersAndVendoesView
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmCustomersAndVendoesView));
            this.schlabel = new System.Windows.Forms.Label();
            this.schControl = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.CustsGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.CustsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // schlabel
            // 
            this.schlabel.AutoSize = true;
            this.schlabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schlabel.ForeColor = System.Drawing.Color.Black;
            this.schlabel.Location = new System.Drawing.Point(462, 17);
            this.schlabel.Name = "schlabel";
            this.schlabel.Size = new System.Drawing.Size(115, 16);
            this.schlabel.TabIndex = 241;
            this.schlabel.Text = "أدخل كلمة للبحث";
            // 
            // schControl
            // 
            this.schControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schControl.Location = new System.Drawing.Point(154, 12);
            this.schControl.Name = "schControl";
            this.schControl.Size = new System.Drawing.Size(302, 23);
            this.schControl.TabIndex = 238;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(102, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(46, 25);
            this.btnSearch.TabIndex = 239;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // CustsGrid
            // 
            this.CustsGrid.AllowDrop = true;
            this.CustsGrid.AllowUserToDeleteRows = false;
            this.CustsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.CustsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.CustsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.CustsGrid.Location = new System.Drawing.Point(0, 43);
            this.CustsGrid.MultiSelect = false;
            this.CustsGrid.Name = "CustsGrid";
            this.CustsGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.CustsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.CustsGrid.Size = new System.Drawing.Size(695, 287);
            this.CustsGrid.TabIndex = 242;
            this.CustsGrid.DoubleClick += new System.EventHandler(this.CustsGrid_DoubleClick);
            // 
            // frmCustomersAndVendoesView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(695, 330);
            this.Controls.Add(this.CustsGrid);
            this.Controls.Add(this.schlabel);
            this.Controls.Add(this.schControl);
            this.Controls.Add(this.btnSearch);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmCustomersAndVendoesView";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "العملاء والموردين";
            this.Load += new System.EventHandler(this.frmCustomersAndVendoesView_Load);
            ((System.ComponentModel.ISupportInitialize)(this.CustsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schlabel;
        private System.Windows.Forms.TextBox schControl;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        public System.Windows.Forms.DataGridView CustsGrid;
    }
}