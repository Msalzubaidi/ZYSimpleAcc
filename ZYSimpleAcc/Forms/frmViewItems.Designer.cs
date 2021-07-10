namespace ZYSimpleAcc.Forms
{
    partial class frmViewItems
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmViewItems));
            this.ItemsGrid = new System.Windows.Forms.DataGridView();
            this.schlabel = new System.Windows.Forms.Label();
            this.schControl = new System.Windows.Forms.TextBox();
            this.btnSearch = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // ItemsGrid
            // 
            this.ItemsGrid.AllowDrop = true;
            this.ItemsGrid.AllowUserToDeleteRows = false;
            this.ItemsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ItemsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ItemsGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.ItemsGrid.Location = new System.Drawing.Point(0, 50);
            this.ItemsGrid.MultiSelect = false;
            this.ItemsGrid.Name = "ItemsGrid";
            this.ItemsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ItemsGrid.Size = new System.Drawing.Size(813, 317);
            this.ItemsGrid.TabIndex = 2;
            this.ItemsGrid.DoubleClick += new System.EventHandler(this.ItemsGrid_DoubleClick);
            // 
            // schlabel
            // 
            this.schlabel.AutoSize = true;
            this.schlabel.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schlabel.ForeColor = System.Drawing.Color.Black;
            this.schlabel.Location = new System.Drawing.Point(530, 19);
            this.schlabel.Name = "schlabel";
            this.schlabel.Size = new System.Drawing.Size(115, 16);
            this.schlabel.TabIndex = 237;
            this.schlabel.Text = "أدخل كلمة للبحث";
            // 
            // schControl
            // 
            this.schControl.Font = new System.Drawing.Font("Tahoma", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.schControl.Location = new System.Drawing.Point(222, 14);
            this.schControl.Name = "schControl";
            this.schControl.Size = new System.Drawing.Size(302, 23);
            this.schControl.TabIndex = 0;
            // 
            // btnSearch
            // 
            this.btnSearch.ImageOptions.Image = ((System.Drawing.Image)(resources.GetObject("btnSearch.ImageOptions.Image")));
            this.btnSearch.ImageOptions.ImageToTextAlignment = DevExpress.XtraEditors.ImageAlignToText.TopCenter;
            this.btnSearch.Location = new System.Drawing.Point(170, 12);
            this.btnSearch.Name = "btnSearch";
            this.btnSearch.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.btnSearch.Size = new System.Drawing.Size(46, 27);
            this.btnSearch.TabIndex = 1;
            this.btnSearch.Click += new System.EventHandler(this.btnSearch_Click);
            // 
            // frmViewItems
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(813, 367);
            this.Controls.Add(this.schlabel);
            this.Controls.Add(this.schControl);
            this.Controls.Add(this.btnSearch);
            this.Controls.Add(this.ItemsGrid);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "frmViewItems";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "اختيار المادة";
            this.Load += new System.EventHandler(this.frmViewItems_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.frmViewItems_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.ItemsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label schlabel;
        private System.Windows.Forms.TextBox schControl;
        private DevExpress.XtraEditors.SimpleButton btnSearch;
        public System.Windows.Forms.DataGridView ItemsGrid;
    }
}