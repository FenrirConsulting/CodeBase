using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Windows.Automation; 
using System.Security.Cryptography;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Threading.Tasks;


namespace HandsFreeInda
{
    public partial class Instructions : Form
    {

        string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        string indaProgram = "";

        [DllImport("user32.dll")]
        static extern IntPtr SetParent(IntPtr hWndChild, IntPtr hWndNewParent);

        public Instructions()
        {
            InitializeComponent();
            indaProgram = folder + "\\INDA.exe";
            
        }

        private void sendToBack() 
        {
            this.SendToBack();
        }

        private void Instructions_Load(object sender, EventArgs e)
        {
            //this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

        private void testButton_Click(object sender, EventArgs e)
        {

        }

        private void functionTestButton_Click(object sender, EventArgs e)
        {

        }

    }
}
