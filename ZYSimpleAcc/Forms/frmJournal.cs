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

namespace ZYSimpleAcc.Forms
{
    public partial class frmJournal : Form
    {
        public frmJournal()
        {
            InitializeComponent();
        }

        Shared s = new Shared();
        string transtable = "Transactions";


        private void btnclose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void ResizeGrid()
        {
            this.JournalGrid.RowHeadersWidth =  010;
            this.JournalGrid.Columns[0].Width = 100;
            this.JournalGrid.Columns[1].Width = 150;
            this.JournalGrid.Columns[2].Width = 100;
            this.JournalGrid.Columns[3].Width = 100;
            this.JournalGrid.Columns[4].Width = 233;


        }

        private void btnclear_Click(object sender, EventArgs e)
        {
            DataTable dtable1 = s.SelctData(transtable, 10 , " where TransType=" + "'" + 11 + "'");
            int max1 = int.Parse(dtable1.Rows[0]["TransID"].ToString());
            if (max1 == 0)
            {
                txtTransID.Clear();
                txtTransID.Text = "1";

            }
            else if (max1 > 0)
            {
                txtTransID.Clear();
                txtTransID.Text = (max1 + 1).ToString();
                txtLastNum.Text = max1.ToString();
                

            }
            datetransdate.EditValue = DateTime.Now;
            this.ResizeGrid();
            txtTransNote.Text = "سند قيد رقم " + txtTransID.Text.ToString();

            if (frmMain.jlstate == 10)
            {
                btnsave.Visible = false;
                btnsaveandprint.Visible = true;
                btnupdate.Visible = true;
                btndelete.Visible = true;
                txtTransID.Clear();
                txtTransID.Enabled = true;
                btnView.Visible = true;
                txtLastNum.Enabled = false;
            }
            else
            {
                btnsave.Visible = true;
                btnsaveandprint.Visible = true;
                btnupdate.Visible = false;
                btndelete.Visible = false;
                txtTransID.Enabled = false;
                btnView.Visible = false;
                txtLastNum.Enabled = false;
            }
        }

        private void txtTransID_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsDigit(e.KeyChar))
            {
                e.Handled = true;
            }
            else
            {

            }
        }

        private void frmJournal_Load(object sender, EventArgs e)
        {
            btnclear.PerformClick();
        }
    }
}
