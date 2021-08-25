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
using ZYSimpleAcc.Properties;

namespace ZYSimpleAcc.Forms
{
    public partial class frmYearlyPosting : Form
    {
        public frmYearlyPosting()
        {
            InitializeComponent();
        }

        private void simpleButton3_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void hyperlinkLabelControl1_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("التدوير", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void label7_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("قيمة البضاعة المتبقية في جميع المستودعات", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void label9_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("يستخدم للترصيد في حساب البضاعة في السنة التالية", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void label10_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("بعد حساب قيمة البضاعة وقيمة التكلفة والمشتريات والمبيعات يتم تحديد الربح / الخسارة وترصيدها في السنة التالية", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void label12_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("السنة المالية الفعالة", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void label13_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("السنة المالية التي سيتم فتحها والبدء بها", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void label14_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("في حال اختيار هذا الخيار سيتم فتح السنة ونسخ الحسابات للسنة التالية بدون أي قيم", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void label15_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("في حال اختيار هذا الخيار سيتم فتح السنة وتدوير الارصدة واضافة الارصدة الختامية للسنة الفعالة كأرصدة افتتاحية للسنة التالية مع إمكانية الرجوع للسنة الفعالة والتعديل عليها والتدوير مرة أخرى", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void label16_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("في حال اختيار هذا الخيار سيتم فتح السنة وتدوير الارصدة واضافة الارصدة الختامية للسنة الفعالة كأرصدة افتتاحية للسنة التالية بدون إمكانية الرجوع للسنة الفعالة ووعدم التعديل عليها", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void label17_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show("في حال الضغط على موافق لن يمكنك التراجع وستبدأ عملية التدير - يمكن أن تحتاج بعض  الوقت أترك النظام حتى يتم الإنتهاء", Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void simpleButton1_Click(object sender, EventArgs e)
        {
            DialogResult result = XtraMessageBox.Show("في حال الضغط على موافق لن يمكنك التراجع وستبدأ عملية التدير - يمكن أن تحتاج بعض أترك النظام حتى يتم الإنتهاء", "تعديل", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (result == DialogResult.Yes)
            {
                if (this.Controls.OfType<TextBox>().Any(t => string.IsNullOrEmpty(t.Text)))
                {
                    XtraMessageBox.Show(Resources.emptyFields, Resources.MessageTitle, 0, MessageBoxIcon.Warning);
                }
                else
                {

                    XtraMessageBox.Show("تمت عملية التدوير", Resources.MessageTitle, 0, MessageBoxIcon.Information);

                }
            }
            else if (result == DialogResult.No)
            {
                XtraMessageBox.Show(Resources.CancelByUser, Resources.MessageTitle, 0, MessageBoxIcon.Exclamation);
            }
        }

        private void frmYearlyPosting_Load(object sender, EventArgs e)
        {

        }

        private void begBalView_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Resources.ProccessCompleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void SystemMaint_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Resources.ProccessCompleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void AccTransMaint_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Resources.ProccessCompleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void CutsMaint_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Resources.ProccessCompleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void begbalMiant_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Resources.ProccessCompleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void invMaint_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Resources.ProccessCompleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void hrMaint_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Resources.ProccessCompleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void treeMaint_Click(object sender, EventArgs e)
        {
            XtraMessageBox.Show(Resources.ProccessCompleted, Resources.MessageTitle, 0, MessageBoxIcon.Information);
        }

        private void frmYearlyPosting_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                SendKeys.Send("{TAB}");
            }
        }
    }
}
