using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace POS
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            ////decimal num = "43.2";
            // var test = Math.Round(20.4, MidpointRounding.AwayFromZero); // 1
            //var test2 = Math.Ceiling(20.4); // 1
            //DateTime dateTime = DateTime.UtcNow.Date;
            //var strDate = dateTime.ToString("ddMMyyyy");

            //string fileName = String.Format("{0}{1}.txt", "log", strDate);

            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Forms.frmLogin());
            //Application.Run(new Forms.frmMain());
        }
    }
}
