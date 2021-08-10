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
    public partial class frmStatmentofAccountReport : Form
    {
        public frmStatmentofAccountReport()
        {
            InitializeComponent();
        }

        SystemSetup ss = new SystemSetup();
        private void button1_Click(object sender, EventArgs e)
        {
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmStatmentofAccountReport_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmViewAccounts va = new frmViewAccounts();
            va.ShowDialog();
            txtaccNo.Text = va.AccountGrid.CurrentRow.Cells[0].Value.ToString();
            txtaccName.Text = va.AccountGrid.CurrentRow.Cells[1].Value.ToString();
            dateFrom.Focus();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtaccNo.Clear();
            txtaccName.Clear();
            dateFrom.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            dateTo.DateTime = new DateTime(DateTime.Now.Year, 12, 31);

        }

        private void frmStatmentofAccountReport_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();
        }

        private void btnView_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrWhiteSpace(txtaccNo.Text.ToString()) && string.IsNullOrWhiteSpace(txtaccName.Text.ToString()))
            {
                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);

            }
            else
            {
                XtraMessageBox.Show(Resources.ProccessCompleted, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
            }
        }
        }
}
