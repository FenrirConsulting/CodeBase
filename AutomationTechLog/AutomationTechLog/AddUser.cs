/*
    Written by Christopher Olson
    For CVS Health
    February 12th, 2021
*/

using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutomationTechLog
{
    public partial class AddUser : Form
    {
        private DataTable TECHLOGTechTable = new DataTable();
        private sqlLiteMethods DBConn = new sqlLiteMethods();

        public AddUser()
        {
            InitializeComponent();
        }

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

        private void createUserButton_Click(object sender, EventArgs e)
        {
            TECHLOGTechTable = DBConn.getTable("TECHLOG_TECHS");
            bool checkID = false;
            foreach (DataRow row in TECHLOGTechTable.Rows)
            {
                string rowValue = row["tlt_auname"].ToString();

                if (rowValue == userIDBox.Text)
                {
                    checkID = true;
                }
            }

            if (usernameBox.Text == "" || userIDBox.Text == "" || shiftBox.Text == "" || passwordBox.Text == "" || confirmPasswordBox.Text == "")
            {
                MessageBox.Show("Please fill out all fields for new user.");
            }
            else
            {
                if (checkID == true)
                {
                    MessageBox.Show("Employee ID Exists, Must be Unique.");
                }
                else
                {
                    if (passwordBox.Text != confirmPasswordBox.Text)
                    {
                        MessageBox.Show("Passwords do not match, please confirm password.");
                    }
                    else
                    {
                        createUser();
                    }
                }
            }
        }

        private void createUser()
        {
            DialogResult dr = MessageBox.Show("Confirm Create User?",
                 "Confirm Create User", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    string tlt_name = usernameBox.Text;
                    string tlt_shift = shiftBox.Text;
                    string tlt_islead = leadCheckBox.Checked.ToString();
                    string tlt_isadmin = adminCheckBox.Checked.ToString();
                    string tlt_ispartslead = partsLeadCheckBox.Checked.ToString();
                    string tlt_isactive = activeCheck.Checked.ToString();
                    string tlt_pword = confirmPasswordBox.Text;
                    string tlt_auname = userIDBox.Text;
                    DBConn.addTechlogTechRecord(tlt_name, tlt_shift, tlt_islead, tlt_isadmin, tlt_ispartslead, tlt_isactive, tlt_pword, tlt_auname);
                    Close();
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void userIDBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(userIDBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                userIDBox.Text = userIDBox.Text.Remove(userIDBox.Text.Length - 1);
            }
        }
    }
}