﻿using ResortPro;
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

            Application.Run(new staffForm("asda"));

        }
    }
}
