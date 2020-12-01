using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.IO;
using System.Diagnostics;

namespace AutomationTechLog
{
    public partial class LoginForm : Form
    {
        public sqlLiteMethods DBConn = new sqlLiteMethods();

       
        // Allows moving window by holding down left mouse button
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST) m.Result = (IntPtr)(HT_CAPTION);
        }




        public LoginForm()
        {
            InitializeComponent();

            string tableSelection = "TECHLOG_TECHS";
            DataTable userTable = new DataTable();
            userTable = DBConn.getTable(tableSelection);



        }
    }
}
