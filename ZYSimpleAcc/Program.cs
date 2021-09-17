using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ZYSimpleAcc.Class;
using ZYSimpleAcc.Forms;

namespace ZYSimpleAcc
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Shared s = new Shared();
            string table = "ActivationApp";

            string condition = "";


            DataTable dtable2 = s.SelctData(table, 0, condition);
            int ActiveStatus = int.Parse(dtable2.Rows[0]["Activated"].ToString());
            if (ActiveStatus == 1)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmActivation());
            }
            if (ActiveStatus == 0)
            {
                Application.EnableVisualStyles();
                Application.SetCompatibleTextRenderingDefault(false);
                Application.Run(new frmLogin());



            }
        }
    }
}
