namespace ZYSimpleAcc.Forms
{
    partial class frmViewAccounts
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewAccounts));
            this.schlabel = new System.Windows.Forms.Label();
            this.schControl = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            this.AccountGrid = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.AccountGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // schlabel
            // 
            this.schlabel.AutoSize = true;
            this.schlabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schlabel.ForeColor = System.Drawing.Color.Black;
            this.schlabel.Location = new System.Drawing.Point(372, 16);
            this.schlabel.Name = "schlabel";
            this.schlabel.Size = new System.Drawing.Size(115, 16);
            this.schlabel.TabIndex = 241;
            this.schlabel.Text = "أدخل كلمة للبحث";
            // 
            // schControl
            // 
            this.schControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schControl.Location = new System.Drawing.Point(64, 12);
            this.schControl.Name = "schControl";
            this.schControl.Size = new System.Drawing.Size(302, 23);
            this.schControl.TabIndex = 238;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(12, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(46, 25);
            this.btnSearch.TabIndex = 239;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // AccountGrid
            // 
            this.AccountGrid.AllowDrop = true;
            this.AccountGrid.AllowUserToDeleteRows = false;
            this.AccountGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.AccountGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.AccountGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.AccountGrid.Location = new System.Drawing.Point(0, 43);
            this.AccountGrid.MultiSelect = false;
            this.AccountGrid.Name = "AccountGrid";
            this.AccountGrid.ReadOnly = true;
            this.AccountGrid.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.AccountGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.AccountGrid.Size = new System.Drawing.Size(497, 311);
            this.AccountGrid.TabIndex = 240;
            this.AccountGrid.DoubleClick += new System.EventHandler(this.ItemsGrid_DoubleClick);
            // 
            // frmViewAccounts
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(497, 354);
            this.Controls.Add(this.schlabel);
            this.Controls.Add(this.schControl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.AccountGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MinimizeBox = false;
            this.Name = "frmViewAccounts";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ارقام واسماء الحسابات";
            this.Load += new System.EventHandler(this.frmViewAccounts_Load);
            ((System.ComponentModel.ISupportInitialize)(this.AccountGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label schlabel;
        private System.Windows.Forms.TextBox schControl;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        public System.Windows.Forms.DataGridView AccountGrid;
    }
}