using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace MorningRecap
{
    public partial class Records : Form
    {
        public DBConnection DBConn = new DBConnection();
        DataTable dt = new DataTable();

        public Records()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void searchButton_Click(object sender, EventArgs e)
        {
            string tableSelection = tableList.Text;
            DBConn.ConnectToDatabase();
            recordsGrid.DataSource = DBConn.getTable(tableSelection);
            nameBox.Text = "";
            valueBox.Text = "";
            DBConn.Disconnect();
        }

        private void recordsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            DBConn.ConnectToDatabase();

            nameBox.Text = recordsGrid.CurrentRow.Cells["Name"].Value.ToString();
            valueBox.Text = recordsGrid.CurrentRow.Cells["Value"].Value.ToString();

            DBConn.Disconnect();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {

            DBConn.ConnectToDatabase();
            try
            {
                string id = recordsGrid.CurrentRow.Cells["ID"].Value.ToString();
                string name = nameBox.Text;
                string value = valueBox.Text;
                string table = tableList.Text;

                DBConn.tableUpdate(id, name, value, table);

                string tableSelection = tableList.Text;
                recordsGrid.DataSource = DBConn.getTable(tableSelection);
            }
            catch {

                MessageBox.Show("Please Select a Record");
            }
            DBConn.Disconnect();

        }

        private void createlistButton_Click(object sender, EventArgs e)
        {

            DBConn.ConnectToDatabase();

            if (Credentials.GlobalUser == "" || Credentials.GlobalPass == "") {
                MessageBox.Show("Please enter SharePoint Credentials First");
            }
            else
            {
                string tableSelection = tableList.Text;
                List<DataRow> list = new List<DataRow>();
                dt = DBConn.getTable(tableSelection);
                list = dt.AsEnumerable().ToList();

                SharepointMethods.CreateList(Credentials.GlobalUser, Credentials.GlobalPass, tableSelection);
                SharepointMethods.CreateFields(Credentials.GlobalUser, Credentials.GlobalPass, tableSelection);
                SharepointMethods.databaseCreateList(Credentials.GlobalUser, Credentials.GlobalPass, tableSelection, dt);

                MessageBox.Show("List Created");
            }

            DBConn.Disconnect();
        }

        private void spUpdateButton_Click(object sender, EventArgs e)
        {
            DBConn.ConnectToDatabase();
            string tableSelection = tableList.Text;
            dt = DBConn.getTable(tableSelection);

            if (Credentials.GlobalUser == "" || Credentials.GlobalPass == "")
            {
                MessageBox.Show("Please enter SharePoint Credentials First");
            }
            else
            {
                SharepointMethods.updateList(Credentials.GlobalUser, Credentials.GlobalPass, tableSelection, dt);
                MessageBox.Show("List Created");
            }
            DBConn.Disconnect();
        }

        private void deleteList_Click(object sender, EventArgs e)
        {
            string title = tableList.Text;
            if (Credentials.GlobalUser == "" || Credentials.GlobalPass == "")
            {
                MessageBox.Show("Please enter SharePoint Credentials First");
            }
            else
            {
                SharepointMethods.DeleteList(Credentials.GlobalUser, Credentials.GlobalPass, title);
                MessageBox.Show("List Deleted");
            }
        }

    }
}
