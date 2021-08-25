using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ZYSimpleAcc.Forms
{
    public partial class frmAccountBalance : Form
    {
        public frmAccountBalance()
        {
            InitializeComponent();
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            frmViewAccounts va = new frmViewAccounts();
            va.ShowDialog();
            txtaccNo.Text = va.AccountGrid.CurrentRow.Cells[0].Value.ToString();
            txtaccName.Text = va.AccountGrid.CurrentRow.Cells[1].Value.ToString();
            dateFrom.Focus();
        }

        private void frmAccountBalance_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            txtaccNo.Clear();
            txtaccName.Clear();
            txtaccBalance.Clear();
            dateFrom.DateTime = new DateTime(DateTime.Now.Year, 1, 1);
            dateTo.DateTime = new DateTime(DateTime.Now.Year, 12, 31);
        }
    }
}
