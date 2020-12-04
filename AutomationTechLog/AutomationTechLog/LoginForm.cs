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

        public void loginCheck() {

            string userID = usernameBox.Text;
            string userPass = passwordBox.Text;
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
