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
    public partial class frmSalesInvoice : Form
    {
        public frmSalesInvoice()
        {
            InitializeComponent();
        }

        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            invdate.DateTime = DateTime.Now; 
        }

        private void frmSalesInvoice_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();
        }

        private void btnsave_Click(object sender, EventArgs e)
        {
            MessageBox.Show("لو مهتم كان عرفت لحالك ");
        }
    }
}
