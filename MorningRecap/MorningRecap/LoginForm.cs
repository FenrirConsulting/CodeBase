using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace MorningRecap
{
    public partial class LoginForm : Form
    {
        bool check = false;

        public LoginForm()
        {
            InitializeComponent();
        }

        private void credentialsButton_Click(object sender, EventArgs e)
        {
             Credentials.GlobalUser = usernameBox.Text;
             Credentials.GlobalPass = passwordBox.Text;
             check = SharepointMethods.credentialCheck(Credentials.GlobalUser, Credentials.GlobalPass);

            if (usernameBox.Text == "" ||  passwordBox.Text == "")
            {
                MessageBox.Show("Please enter Username and Password for Sharepoint Login");
            }
            else if (check == false) {

                MessageBox.Show("Invalid Login, Please Re-Enter Sharepoint Credentials");
            }
            
            else {
                        this.Hide();
                        var main = new MorningRecap();
                        main.Closed += (s, args) => this.Close();
                        main.Show();
            }
                   

        }
    }
}
