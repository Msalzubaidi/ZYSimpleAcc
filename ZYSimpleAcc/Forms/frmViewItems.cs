﻿using DevExpress.XtraEditors;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Forms
{
    public partial class frmViewItems : Form
    {
        public frmViewItems()
        {
            InitializeComponent();
        }
        SystemSetup ss = new SystemSetup();
        Shared s = new Shared();

        private void frmViewItems_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ss.SerachItems("", 1); 
            ItemsGrid.DataSource = dt; 




            
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(schControl.Text.ToString()))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
            
}
            else
            {
                DataTable dtable = new DataTable();

                string keyword = schControl.Text.ToString();
                dtable = ss.SerachItems(keyword , 0 );

                int count = dtable.Rows.Count;
                if (count > 0)
                {

                    ItemsGrid.DataSource = dtable;
                }
                else
                {

                    ItemsGrid.Columns.Clear();
                    dtable = ss.SerachItems(keyword, 1);
                    ItemsGrid.DataSource = dtable;
                    schControl.Clear();
                    schControl.Focus();
                    XtraMessageBox.Show(Resources.NoData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void ItemsGrid_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
