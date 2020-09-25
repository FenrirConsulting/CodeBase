using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ITTicketSystem
{
    public partial class UpdateTicket : Form
    {
        public sqlLiteMethods DBConn = new sqlLiteMethods();
        DataTable ticketTable = new DataTable();
        DataTable userTable = new DataTable();
        string today = DateTime.Today.ToString("MM'/'dd'/'yyyy");
        string boxUsername = "";
        string boxPassword = "";
        string selectedRecordId = "";

        public UpdateTicket()
        {
            InitializeComponent();
            rebuildTable();
        }

        public void rebuildTable()
        {
            ticketTable = DBConn.getTable("Tickets");
            userTable = DBConn.getTechUserTable("Users");
            dataGridView.DataSource = ticketTable;

            techBox.DataSource = userTable;
            techBox.DisplayMember = "Name";

            List<String> categoriesList = new List<String>();
            categoriesList = DBConn.buildColumnList(categoriesList, "Categories", "Name");
            BindingSource bs = new BindingSource();
            bs.DataSource = categoriesList;
            categoryBox.DataSource = bs;

            this.dataGridView.Columns["ID"].Visible = false;
            this.dataGridView.Columns["TicketID"].Width = 60;
            this.dataGridView.Columns["Created"].Width = 80;
            this.dataGridView.Columns["Modified"].Width = 80;
            this.dataGridView.Columns["Email"].Visible = false;
            this.dataGridView.Columns["Category"].Visible = false;
            this.dataGridView.Columns["Comments"].Visible = false;
            this.dataGridView.Columns["Request"].Visible = false;
            this.dataGridView.Columns["Finished"].Visible = false;
            this.dataGridView.Columns["ClosedBy"].Visible = false;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        private void techBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)techBox.SelectedItem;
            boxUsername = drv["EmployeeId"].ToString();
            boxPassword = drv["Password"].ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == boxUsername && passwordBox.Text == boxPassword)
            {
                submiteUpdate();
            }

            else
            {
                MessageBox.Show("Username or Password Incorrect");
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            if (ticketBox.Text == "")
            {
                MessageBox.Show("Please select a ticket to delete.");
            }

            else
            {

                if (usernameBox.Text == boxUsername && passwordBox.Text == boxPassword)
                {

                    DialogResult dialogResult = MessageBox.Show("Delete Ticket, Are you Sure?", "Delete Ticket?", MessageBoxButtons.YesNo);
                    if (dialogResult == DialogResult.Yes)
                    {
                        string id = selectedRecordId;
                        string table = "Tickets";
                        DBConn.deleteRecord(table, id);
                        MessageBox.Show("Ticket Deleted");
                        rebuildTable();
                        clearFields();
                    }
                    else if (dialogResult == DialogResult.No)
                    {

                    }

                }

                else
                {
                    MessageBox.Show("Username or Password Incorrect");
                }

            }
        }

        private void submiteUpdate()
        {
            if (ticketBox.Text == "")
            {
                MessageBox.Show("Please Select a ticket to update.");
            }

            else
            {

                string modified = DateTime.Today.ToString("MM'/'dd'/'yyyy");
                string updatedText = Environment.NewLine + Environment.NewLine + techBox.Text + " - " + modified + " : " + Environment.NewLine + updateBox.Text;
                string id = selectedRecordId;
                string table = "Tickets";
                string category = categoryBox.Text;
                string request = requestTextBox.Text;
                string status = statusBox.Text;
                string finished = "Unfinished";
                string closedBy = "Unfinished";
                if (status == "Closed")
                {
                    finished = modified;
                    closedBy = techBox.Text;
                }
                string comments = commentsTextBox.Text + updatedText;

                try
                {
                    DBConn.ticketTableUpdate(id, table, modified, request, finished, category, status, comments, closedBy);
                    MessageBox.Show("Ticket Updated");
                    rebuildTable();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Source + "\n" + ex.Message + "\n" + ex.StackTrace);
                }

                clearFields();

            }
        }

        private void dataGridView_CellClick(object sender, DataGridViewCellEventArgs e)
        {

            selectedRecordId = dataGridView.CurrentRow.Cells["ID"].Value.ToString();
            requestorBox.Text = dataGridView.CurrentRow.Cells["Requestor"].Value.ToString();
            ticketBox.Text = dataGridView.CurrentRow.Cells["TicketID"].Value.ToString();
            categoryBox.Text = dataGridView.CurrentRow.Cells["Category"].Value.ToString();
            creationDateBox.Text = dataGridView.CurrentRow.Cells["Created"].Value.ToString();
            modifiedBox.Text = dataGridView.CurrentRow.Cells["Modified"].Value.ToString();
            requestTextBox.Text = dataGridView.CurrentRow.Cells["Request"].Value.ToString();
            commentsTextBox.Text = dataGridView.CurrentRow.Cells["Comments"].Value.ToString();
            statusBox.Text = dataGridView.CurrentRow.Cells["Status"].Value.ToString();

        }

        private void clearFields()
        {
            requestorBox.Text = "";
            ticketBox.Text = "";
            creationDateBox.Text = "";
            modifiedBox.Text = "";
            requestTextBox.Text = "";
            commentsTextBox.Text = "";
            updateBox.Text = "";
            statusBox.Text = "";
            categoryBox.Text = "";
        }

    }
}