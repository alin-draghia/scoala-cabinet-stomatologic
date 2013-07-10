using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Cabinet
{
    static class Program
    {
        //public static Utilizatori utilizator = null;
        public static Medic utilizator = null;
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            var loginDlg = new LoginForm();
            if (loginDlg.ShowDialog() == DialogResult.OK)
            {
                if (utilizator.isAdmin)
                {
                    Application.Run(new AdminForm());
                }
                else
                {
                    Application.Run(new MedicForm());
                }                
            }             
        }
    }
}
