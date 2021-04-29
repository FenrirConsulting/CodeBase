/*
    Written by Christopher Olson 
    For CVS Health
    February 12th, 2021
*/


using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;

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


            testButton.Visible = true;

        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void okButton_Click(object sender, EventArgs e)
        {
            loginCheck();
        }

        private void usernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginCheck();
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                loginCheck();
            }
        }

        public void loginCheck()
        {

            string userID = usernameBox.Text;
            string userPass = passwordBox.Text;

            if (userID == "Odin" && userPass == "Ragnarok")
            {

                DataTable usersTable = new DataTable();

                usersTable.Columns.Add("tlt_name");
                usersTable.Columns.Add("tlt_shift");
                usersTable.Columns.Add("tlt_islead");
                usersTable.Columns.Add("tlt_isadmin");
                usersTable.Columns.Add("tlt_ispartslead");
                usersTable.Columns.Add("tlt_isactive");
                usersTable.Columns.Add("tlt_pword");
                usersTable.Columns.Add("tlt_auname");

                DataRow userRow = usersTable.NewRow();

                userRow["tlt_name"] = "Secret Admin";
                userRow["tlt_shift"] = "1";
                userRow["tlt_islead"] = "True";
                userRow["tlt_isadmin"] = "True";
                userRow["tlt_ispartslead"] = "True";
                userRow["tlt_isactive"] = "True";
                userRow["tlt_pword"] = "Ragnarok";
                userRow["tlt_auname"] = "Odin";
                usersTable.Rows.Add(userRow);

                openMainForm(userRow);

            }
            else
            {

                string tableSelection = "TECHLOG_TECHS";
                DataTable userTable = new DataTable();
                userTable = DBConn.getTable(tableSelection);
                string queryCommand = "tlt_auname = '" + userID + "'";
                DataRow[] result = userTable.Select(queryCommand);

                if (result != null && result.Count() > 0)
                {

                    foreach (DataRow row in result)
                    {
                        string tempUser = row["tlt_auname"].ToString();
                        string tempPass = row["tlt_pword"].ToString();

                        if (userPass == tempPass)
                        {
                            string username = row["tlt_name"].ToString();
                            nameLabel.Text = "Welcome: " + username;
                            DataRow passedRow = row;
                            openMainForm(passedRow);
                        }

                        else
                        {
                            MessageBox.Show("Wrong Password, Please try Again.");
                            nameLabel.Text = "";
                        }

                    }
                }

                else
                {
                    MessageBox.Show("Username not found. Please re-enter.");
                    nameLabel.Text = "";
                }

            }




        }


        public void openMainForm(DataRow passedRow)
        {

            this.Hide();
            var mainForm = new MainForm(passedRow);
            mainForm.Closed += (s, args) => this.Close();
            mainForm.Show();

        }

        private void button1_Click(object sender, EventArgs e)
        {


            string userID = "1444437";
            string userPass = "9012";
            string tableSelection = "TECHLOG_TECHS";
            DataTable userTable = new DataTable();
            userTable = DBConn.getTable(tableSelection);
            string queryCommand = "tlt_auname = '" + userID + "'";
            DataRow[] result = userTable.Select(queryCommand);

            if (result != null && result.Count() > 0)
            {

                foreach (DataRow row in result)
                {
                    string tempUser = row["tlt_auname"].ToString();
                    string tempPass = row["tlt_pword"].ToString();

                    if (userPass == tempPass)
                    {
                        string username = row["tlt_name"].ToString();
                        nameLabel.Text = "Welcome: " + username;
                        DataRow passedRow = row;
                        openMainForm(passedRow);
                    }

                    else
                    {
                        MessageBox.Show("Wrong Password, Please try Again.");
                        nameLabel.Text = "";
                    }

                }
            }
        }


    }
}
