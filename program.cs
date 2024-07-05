using ResortPro;
using ResortPro.AllAdminForms;
using ResortPro.AllStaffForms;
using ResortPro.superUser;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ResortPro1
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
<<<<<<< HEAD
            Application.Run(new staffForm(""));
=======
            Application.Run(new staffForm("asd"));
>>>>>>> b11f76e44643863c291b1da36c9637e6b8b14f10
        }
    }
}
