using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Web;

namespace ITTicketSystem
{
    public partial class Settings : Form
    {

        public sqlLiteMethods DBConn = new sqlLiteMethods();
        string selectedRecordId = "";

        public Settings()
        {
            InitializeComponent();

            adminPanel.Visible = false;
            resetPanel.Visible = false;

            string tableSelection = "Users";
            recordsGrid.DataSource = DBConn.getTable(tableSelection);

            List<String> categoriesList = new List<String>();
            categoriesList = DBConn.buildColumnList(categoriesList, "Categories", "Name");



            this.recordsGrid.Columns["Password"].Visible = false;
            this.recordsGrid.Columns["ID"].Visible = false;

            foreach (DataGridViewColumn column in recordsGrid.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            adminValidation();
        }

        private void adminPasswordTextBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adminValidation();
            }
        }

        private void adminUsernameBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                adminValidation();
            }
        }

        private void unlockResetButton_Click(object sender, EventArgs e)
        {
            userValidation();
        }

        private void resetPasswordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                userValidation();
            }
        }

        private void resetButton_Click(object sender, EventArgs e)
        {
            resetUserPassword();
        }

        private void resetButton_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                resetUserPassword();
            }
        }

        private void resetUserPassword()
        {
            if (newPasswordBox.Text == confirmPasswordBox.Text)
            {

                DataTable userTable = new DataTable();
                userTable = DBConn.getTable("Users");
                string userCheck = resetUserBox.Text;
                string queryCommand = "EmployeeID = '" + userCheck + "'";
                string table = "Users";
                string recordID = "";
                string employeeID = resetUserBox.Text;
                string password = confirmPasswordBox.Text;
                DataRow[] result = userTable.Select(queryCommand);

                if (result != null && result.Count() > 0)
                {
                    bool match = false;

                    foreach (DataRow row in result)
                    {
                        if (row["EmployeeID"].ToString().Equals(userCheck))
                        {
                            match = true;
                            recordID = row["ID"].ToString();
                        }
                    }

                    if (match == true)
                    {
                        DBConn.userPasswordUpdate(recordID, table, employeeID, password);
                        MessageBox.Show("Password Reset.");
                    }

                    else
                    {
                        MessageBox.Show("Error, please try again.");
                    }

                }

            }
            else
            {
                MessageBox.Show("Passwords do not match, try again");
            }

        }

        private void recordsGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRecordId = recordsGrid.CurrentRow.Cells["ID"].Value.ToString();
            nameTextBox.Text = recordsGrid.CurrentRow.Cells["Name"].Value.ToString();
            emailTextBox.Text = recordsGrid.CurrentRow.Cells["Email"].Value.ToString();
            techComboBox.Text = recordsGrid.CurrentRow.Cells["Tech"].Value.ToString();
            employeeIDTextBox.Text = recordsGrid.CurrentRow.Cells["EmployeeID"].Value.ToString();
            passwordTextBox.Text = recordsGrid.CurrentRow.Cells["Password"].Value.ToString();

        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            try
            {
                string id = recordsGrid.CurrentRow.Cells["Id"].Value.ToString();
                string table = "Users";
                string name = nameTextBox.Text;
                string email = emailTextBox.Text;
                string tech = techComboBox.Text;
                string employeeId = employeeIDTextBox.Text;
                string employeepassword = passwordTextBox.Text;

                DBConn.userTableUpdate(id, table, name, email, tech, employeeId, employeepassword);

                recordsGrid.DataSource = DBConn.getTable(table);
                hideAdmin();
            }
            catch
            {

                MessageBox.Show("Please Select a Record");
            }
            clearFields();
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            try
            {
                string table = "Users";
                string name = nameTextBox.Text;
                string email = emailTextBox.Text;
                string tech = techComboBox.Text;
                string employeeId = employeeIDTextBox.Text;
                string employeepassword = passwordTextBox.Text;

                DBConn.userAddRecord(table, name, email, tech, employeeId, employeepassword);

                recordsGrid.DataSource = DBConn.getTable(table);
                hideAdmin();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "\n" + ex.Message + "\n" + ex.StackTrace);
            }
            clearFields();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {

            if (selectedRecordId != "")
            {

                DialogResult dialogResult = MessageBox.Show("Delete User, are you Sure?", "Delete User?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    try
                    {
                        string id = selectedRecordId;
                        string table = "Users";

                        DBConn.deleteRecord(table, id);

                        recordsGrid.DataSource = DBConn.getTable(table);
                        hideAdmin();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Source + "\n" + ex.Message + "\n" + ex.StackTrace);
                    }
                    clearFields();
                }
                else if (dialogResult == DialogResult.No)
                {

                }

            }
        }

        private void clearFields()
        {
            nameTextBox.Text = "";
            emailTextBox.Text = "";
            techComboBox.Text = "";
            employeeIDTextBox.Text = "";
            passwordTextBox.Text = "";
        }

        private void userValidation()
        {

            DataTable userTable = new DataTable();
            userTable = DBConn.getTable("Users");
            string userCheck = resetUserBox.Text;
            string passCheck = resetPasswordBox.Text;
            string queryCommand = "EmployeeID = '" + userCheck + "'";
            DataRow[] result = userTable.Select(queryCommand);

            if (result != null && result.Count() > 0)
            {
                bool match = false;

                foreach (DataRow row in result)
                {
                    if (row["EmployeeID"].ToString().Equals(userCheck) && row["Password"].ToString().Equals(passCheck))
                    {
                        match = true;
                    }
                }

                if (match == true)
                {

                    resetPanel.Visible = true;
                }

                else
                {
                    MessageBox.Show("Incorrect Password, Try Again");
                }

            }
            else
            {
                MessageBox.Show("Username does not Exist");
            }

        }

        private void adminValidation()
        {

            DataTable userTable = new DataTable();
            userTable = DBConn.getTable("Users");
            string userCheck = adminUsernameBox.Text;
            string passCheck = adminPasswordTextBox.Text;
            string queryCommand = "EmployeeID = '" + userCheck + "'";
            DataRow[] result = userTable.Select(queryCommand);

            if (result != null && result.Count() > 0)
            {
                bool match = false;
                bool isTech = false;

                foreach (DataRow row in result)
                {
                    if (row["EmployeeID"].ToString().Equals(userCheck) && row["Password"].ToString().Equals(passCheck))
                    {
                        match = true;
                    }
                    if (row["Tech"].ToString().Equals("Yes"))
                    {
                        isTech = true;
                    }
                }

                if (match == true)
                {
                    if (isTech == true)
                    {
                        adminPanel.Visible = true;
                        hideAdmin();
                    }
                    else
                    {
                        MessageBox.Show("Access Denied, Invalid User");
                    }
                }

                else
                {
                    MessageBox.Show("Incorrect Password, Try Again");
                }

            }
            else
            {
                MessageBox.Show("Username does not Exist");
            }

        }


        private void hideAdmin()
        {

            foreach (DataGridViewRow row in recordsGrid.Rows)
            {
                if (row.Cells[4].Value != null)
                {
                    if (row.Cells[4].Value.Equals("1444437") || row.Cells[4].Value.Equals("1337"))
                    {
                        CurrencyManager currencyManager1 = (CurrencyManager)BindingContext[recordsGrid.DataSource];
                        currencyManager1.SuspendBinding();
                        row.Visible = false;
                        currencyManager1.ResumeBinding();
                    }
                }
            }

        }
    }

}