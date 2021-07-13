using DevExpress.XtraEditors;
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
    public partial class frmCustomersAndVendoesView : Form
    {
        public frmCustomersAndVendoesView()
        {
            InitializeComponent();
        }

        SystemSetup ss = new SystemSetup();

        private void frmCustomersAndVendoesView_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ss.SerachCusVen("", 1);
            CustsGrid.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(schControl.Text))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string keyword = schControl.Text.ToString();
                DataTable dtable = new DataTable();
                dtable = ss.SerachCusVen(keyword, 2);
                if(dtable.Rows.Count > 0 )
                {
                    CustsGrid.DataSource = dtable;
                }
                else
                {
                    CustsGrid.Columns.Clear();
                    dtable = ss.SerachCusVen("", 1);
                    CustsGrid.DataSource = dtable;
                    schControl.Clear();
                    schControl.Focus();
                    XtraMessageBox.Show(Resources.NoData, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

                    
                }
              
            }
                
        }

        private void CustsGrid_DoubleClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
