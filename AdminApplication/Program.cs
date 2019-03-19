﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AdminApplication
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// Creates and runs a new AaminApplication Form
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new frmAdmin());
        }
    }
}
