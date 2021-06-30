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
    public partial class frmInvoiceSetting : Form
    {
        public frmInvoiceSetting()
        {
            InitializeComponent();
        }

        Shared s = new Shared();
        DataBase db = new DataBase();

        string table = "InvoiceSettings"; 

        private void frmInvoiceSetting_Load(object sender, EventArgs e)
        {
            string condition = "";

            DataTable dtable = s.SelctData(table, 0, condition);


       
            txtInvSymbol.Text = dtable.Rows[0]["invSymbol"].ToString();
         
            txtInvNotes.Text = dtable.Rows[0]["invNotes"].ToString();
    
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            if (this.Controls.OfType<DevExpress.XtraEditors.TextEdit>().Any(t => string.IsNullOrEmpty(t.Text)))
            {

                XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
              
            }
            else
            {
                string symbol = txtInvSymbol.Text;
                string notes = txtInvNotes.Text;
               
                int result = db.updateinvSettings(symbol, notes);
                if (result > 0 )
                {
                    XtraMessageBox.Show(Resources.Updated, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Information);
                    db.UserLogTransactions(DataBase.Username.ToString(), "حفظ  اعدادات الفواتير", DateTime.Now, Environment.MachineName);
                }
                else
                {
                    XtraMessageBox.Show(Resources.TryAgain, Resources.MessageTitle, MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }

            }
        }

        private void frmInvoiceSetting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
