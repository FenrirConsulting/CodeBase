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
    public partial class UserForm : Form
    {
        private GlobalUser globalUser = new GlobalUser();
        private DataTable TECHLOGTechTable = new DataTable();
        private sqlLiteMethods DBConn = new sqlLiteMethods();

        public UserForm(GlobalUser passedUser)
        {
            InitializeComponent();
            globalUser = passedUser;
            string titleBar = "Hello   " + globalUser.globalUsername;
            generatedTitle.Text = titleBar;

            leadPanel.Visible = false;
            adminPanel.Visible = false;
            adminCheckBox.Enabled = false;

            if (globalUser.globalLead == "True" || globalUser.globalPartsLead == "True" || globalUser.globalAdmin == "True") { leadPanel.Visible = true; }
            if (globalUser.globalAdmin == "True") { adminPanel.Visible = true; ; adminCheckBox.Enabled = true; }

            buildTables();
        }

        public void buildTables()
        {
            TECHLOGTechTable = DBConn.getTable("TECHLOG_TECHS");
            userSelectBox.DataSource = TECHLOGTechTable;
            userSelectBox.DisplayMember = "tlt_name";
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

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.titlePanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.bodyPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void passwordResetButton_Click(object sender, EventArgs e)
        {
            passwordChange();
        }

        private void passwordChange()
        {
            if (globalUser.globalEmployeeId == "Odin")
            {
                MessageBox.Show("Secret Admin Password cannot be Changed.");
            }
            else
            {
                TECHLOGTechTable = DBConn.getTable("TECHLOG_TECHS");
                DataRow[] selectedRow = TECHLOGTechTable.Select("tlt_auname = '" + globalUser.globalEmployeeId + "'");

                if (resetBox.Text == "" || confirmResetBox.Text == "")
                {
                    MessageBox.Show("Please enter a new password.");
                }
                else if (resetBox.Text != confirmResetBox.Text)
                {
                    MessageBox.Show("Please re-enter. Passwords do not match.");
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Change Password?",
                     "Confirm Password Change", MessageBoxButtons.YesNo);

                    switch (dr)
                    {
                        case DialogResult.Yes:
                            string selectedUser = selectedRow[0]["tlt_auname"].ToString();
                            string newPassword = confirmResetBox.Text;
                            DBConn.resetPassword(newPassword, selectedUser);
                            break;

                        case DialogResult.No:
                            break;
                    }
                }
            }
        }

        private void resetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                passwordChange();
            }
        }

        private void confirmResetBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
            {
                passwordChange();
            }
        }

        private void userSelectBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)userSelectBox.SelectedItem;
            bool isLead = false; if (drv["tlt_islead"].ToString() == "True") { isLead = true; }
            bool isActive = false; if (drv["tlt_isactive"].ToString() == "True") { isActive = true; }
            bool isPartsLead = false; if (drv["tlt_ispartslead"].ToString() == "True") { isPartsLead = true; }
            bool isAdmin = false; if (drv["tlt_isadmin"].ToString() == "True") { isAdmin = true; }

            leadCheckBox.Checked = isLead;
            activeCheck.Checked = isActive;
            partsLeadCheckBox.Checked = isPartsLead;
            adminCheckBox.Checked = isAdmin;

            userIDBox.Text = drv["tlt_auname"].ToString();
            shiftBox.Text = drv["tlt_shift"].ToString();
        }

        private void adminResetButton_Click(object sender, EventArgs e)
        {
            adminPasswordChange();
        }

        private void adminPasswordChange()
        {
            if (adminPasswordResetBox.Text == "" || adminPasswordConfirmBox.Text == "")
            {
                MessageBox.Show("Please enter a new password.");
            }
            else if (adminPasswordResetBox.Text != adminPasswordConfirmBox.Text)
            {
                MessageBox.Show("Please re-enter. Passwords do not match.");
            }
            else
            {
                DialogResult dr = MessageBox.Show("Change User Password?",
                 "Confirm Password Change", MessageBoxButtons.YesNo);

                switch (dr)
                {
                    case DialogResult.Yes:
                        string selectedUser = userIDBox.Text;
                        string newPassword = adminPasswordConfirmBox.Text;
                        DBConn.resetPassword(newPassword, selectedUser);
                        break;

                    case DialogResult.No:
                        break;
                }
            }
        }

        private void updateUserButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm Change User?",
                 "Confirm Change User", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    string tlt_name = userSelectBox.Text;
                    string tlt_shift = shiftBox.Text;
                    string tlt_islead = leadCheckBox.Checked.ToString();
                    string tlt_isadmin = adminCheckBox.Checked.ToString();
                    string tlt_ispartslead = partsLeadCheckBox.Checked.ToString();
                    string tlt_isactive = activeCheck.Checked.ToString();
                    string tlt_auname = userIDBox.Text;
                    DBConn.techlogTechsRecordUpdate(tlt_name, tlt_shift, tlt_islead, tlt_isadmin, tlt_ispartslead, tlt_isactive, tlt_auname);
                    buildTables();
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void deleteUserButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Confirm Delete User?",
                 "Confirm Delete User", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    string table = "TECHLOG_TECHS";
                    string column = "tlt_auname";
                    string userID = userIDBox.Text;
                    DBConn.deleteUserRecord(table, column, userID);
                    buildTables();
                    break;

                case DialogResult.No:
                    break;
            }
        }

        private void createUserButton_Click(object sender, EventArgs e)
        {
            AddUser addUser = new AddUser();
            addUser.Show();
            addUser.FormClosed += new FormClosedEventHandler(AddUser_Closed);
        }

        private void AddUser_Closed(object sender, FormClosedEventArgs e)
        {
            buildTables();
        }
    }
}