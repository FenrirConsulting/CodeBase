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
    public partial class SharePointForm : Form
    {

        public DBConnection DBConn = new DBConnection();
        string table = "RxTable";

        List<DataRow> list = new List<DataRow>();

        string username = Credentials.GlobalUser;
        string password = Credentials.GlobalPass;
        string title = "";

        public SharePointForm()
        {
            InitializeComponent();
            
        }

        private void credentialsButton_Click(object sender, EventArgs e)
        {
            username = Credentials.GlobalUser;
            password = Credentials.GlobalPass;
            MessageBox.Show("Credentials Saved");
        }

        private void listCreation_Click(object sender, EventArgs e)
        {
            title = listCreateBox.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter SharePoint Credentials First");
            }
            else
            {
                username = Credentials.GlobalUser;
                password = Credentials.GlobalPass;
                DBConn.ConnectToDatabase();
                DataTable dt = new DataTable();
                dt = DBConn.getTable(table);
                list = dt.AsEnumerable().ToList();

                SharepointMethods.CreateList(username, password, title);
                SharepointMethods.CreateFields(username, password, title);
                MessageBox.Show("List Created");
                DBConn.Disconnect();
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            title = deleteBox.Text;
            if (username == "" || password == "")
            {
                MessageBox.Show("Please enter SharePoint Credentials First");
            }
            else
            {
                SharepointMethods.DeleteList(username, password, title);
                MessageBox.Show("List Deleted");
            }
        }

        private void internalName_Click(object sender, EventArgs e)
        {
            
        }


  

    }
}
