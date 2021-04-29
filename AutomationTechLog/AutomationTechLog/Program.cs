/*
    Written by Christopher Olson 
        For CVS Health, Vero Beach DC | 11/30/2020
*/

using System;
using System.Windows.Forms;

namespace AutomationTechLog
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new LoginForm());
        }
    }
}
