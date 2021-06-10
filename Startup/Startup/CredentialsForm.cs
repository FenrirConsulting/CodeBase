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
using System.Globalization;
using System.Security.Cryptography;

namespace Startup
{
    public partial class CredentialsForm : Form
    {
        Program newProgram = new Program();


        string passedPath = "";
        Startup.UserCredentials currentUser = new Startup.UserCredentials();

        public CredentialsForm(Startup.UserCredentials passedUser, string path)
        {
            InitializeComponent();
            currentUser = passedUser;
            passedPath = path;
        }

        // The below code allows moving around the window by holding left click on the title panel.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            if (passwordBox.Text == "" || repeatPasswordBox.Text == "" || usernameBox.Text == "")
            {
                MessageBox.Show("Please fill out username and password fields.");
            }
            else {

                if (passwordBox.Text != repeatPasswordBox.Text)
                {
                    MessageBox.Show("Passwords do not match. Please re-enter passwords.");
                }
                else {

                    sendChoices();
                }
            }
        }

        public void sendChoices() {

            currentUser.user = usernameBox.Text;
            currentUser.pass = passwordBox.Text;
            currentUser.LBS =  lbsCheck.Checked;
            currentUser.CPS = cpsCheck.Checked;
            currentUser.DPS = dserviceCheck.Checked;
            currentUser.BMIS = bmisCheck.Checked;
            currentUser.MFCDPS = mfcdpsCheck.Checked;
            currentUser.MFCCPS = mfccpsCheck.Checked;
            currentUser.AVIS = avisCheck.Checked;
            currentUser.PCO = pcoCheck.Checked;

            writeFile();

            Close();
        }

        public void writeFile()
        {

            var menuList = new List<string>();

            if (currentUser.CPS == true) { menuList.Add("CPS"); }
            if (currentUser.LBS == true) { menuList.Add("LBS"); }
            if (currentUser.BMIS == true) { menuList.Add("BMIS"); }
            if (currentUser.MFCDPS == true) { menuList.Add("MFCDPS"); }
            if (currentUser.MFCCPS == true) { menuList.Add("MFCCPS"); }
            if (currentUser.AVIS == true) { menuList.Add("AVIS"); }
            if (currentUser.INDA == true) { menuList.Add("INDA"); }
            if (currentUser.REMOTEMANAGER == true) { menuList.Add("REMOTEMANAGER"); }
            if (currentUser.LOGCRAWLER == true) { menuList.Add("LOGCRAWLER"); }
            if (currentUser.MAPDRIVES == true) { menuList.Add("MAPDRIVES"); }
            if (currentUser.DPS == true) { menuList.Add("DPS"); }
            if (currentUser.PCO == true) { menuList.Add("PCO"); }

            var menuArray = menuList.ToArray();
            string key = "#CVS2575";

            /*
            FileStream file = File.Create(passedPath); file.Dispose();

            using (StreamWriter writetext = new StreamWriter(passedPath))
            {
                writetext.WriteLine(currentUser.user);
                writetext.WriteLine(currentUser.pass);
                foreach (string s in menuArray)
                    writetext.WriteLine(s);
            }
            file.Close();
            */

            //EncryptFile(passedPath, key);


            string username = System.Environment.UserName;
            string serverFile = "\\\\RFL6LBSAPW1V\\WMS-USER\\" + username + "\\info.txt";
            FileStream file2 = File.Create(serverFile); file2.Dispose();

            using (StreamWriter writetext = new StreamWriter(serverFile))
            {
                writetext.WriteLine(currentUser.user);
                writetext.WriteLine(currentUser.pass);
                foreach (string s in menuArray)
                    writetext.WriteLine(s);
            }
            file2.Close();
            EncryptFile(serverFile, key);
        }

        static void EncryptFile(string path, string key)
        {

            byte[] plainContent = File.ReadAllBytes(path);
            using (var DES = new DESCryptoServiceProvider())
            {
                DES.IV = Encoding.UTF8.GetBytes(key);
                DES.Key = Encoding.UTF8.GetBytes(key);
                DES.Mode = CipherMode.CBC;
                DES.Padding = PaddingMode.PKCS7;

                using (var memStream = new MemoryStream())
                {
                    CryptoStream cryptoStream = new CryptoStream(memStream, DES.CreateEncryptor(), CryptoStreamMode.Write);
                    cryptoStream.Write(plainContent, 0, plainContent.Length);
                    cryptoStream.FlushFinalBlock();
                    File.WriteAllBytes(path, memStream.ToArray());
                }

            }

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }
    }

}
