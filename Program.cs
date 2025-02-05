///////////////////////////////////////////////////////////////////
// Duc Vy Dang
// TINFO-200, Winter 2024
//
// Change History
// Date           Developer             Description
// 2024-01-16     Duc Vy Dang           Initial creation of program, app, and this file


using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Calculator
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
            Application.Run(new Form1());
        }
    }
}
