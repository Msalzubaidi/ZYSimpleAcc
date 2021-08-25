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
    public partial class frmTransactionsReports : Form
    {
        public frmTransactionsReports()
        {
            InitializeComponent();
        }

        private void chk_all_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
