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
    public partial class frmViewAccounts : Form
    {

   
        public frmViewAccounts()
        {
            InitializeComponent();
        }

        SystemSetup ss = new SystemSetup();

        private void frmViewAccounts_Load(object sender, EventArgs e)
        {
            DataTable dt = new DataTable();
            dt = ss.SearchAccounts("", 0);
            AccountGrid.DataSource = dt;
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(schControl.Text.ToString()))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                string keyword = schControl.Text.ToString();
                DataTable dtable = new DataTable();
               
                 dtable = ss.SearchAccounts(keyword, 0);
                

                int count = dtable.Rows.Count;
                if (count > 0)
                {

                    AccountGrid.DataSource = dtable;
                }
                else
                {

                    AccountGrid.Columns.Clear();
                    dtable = ss.SearchAccounts(keyword, 0);
                    AccountGrid.DataSource = dtable;
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
