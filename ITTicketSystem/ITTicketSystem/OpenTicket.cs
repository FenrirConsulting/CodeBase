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

namespace ITTicketSystem
{
    public partial class OpenTicket : Form
    {
        public sqlLiteMethods DBConn = new sqlLiteMethods();
        DataTable ticketTable = new DataTable();
        DataTable userTable = new DataTable();
        string today = DateTime.Today.ToString("MM'/'dd'/'yyyy");
        string boxUsername = "";
        string boxPassword = "";
        string selectedRecordId = "";
        string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        string monitorPath = "";

        public OpenTicket()
        {
            InitializeComponent();
            rebuildTable();
            monitorPath = folder + "\\TicketMonitor\\ticketmonitor.exe";
        }

        public void rebuildTable()
        {

            ticketTable = DBConn.getOpenTicketsTable("Tickets");
            userTable = DBConn.getTable("Users");
            dataGridView.DataSource = ticketTable;
            updatorBox.DataSource = userTable;
            updatorBox.DisplayMember = "Name";

            this.dataGridView.Columns["ID"].Visible = false;
            this.dataGridView.Columns["TicketID"].Width = 60;
            this.dataGridView.Columns["Email"].Visible = false;
            this.dataGridView.Columns["Category"].Visible = false;
            this.dataGridView.Columns["Comments"].Visible = false;
            this.dataGridView.Columns["Request"].Visible = false;
            this.dataGridView.Columns["Finished"].Visible = false;
            this.dataGridView.Columns["Status"].Visible = false;
            this.dataGridView.Columns["ClosedBy"].Visible = false;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        private void updatorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)updatorBox.SelectedItem;
            boxUsername = drv["EmployeeId"].ToString();
            boxPassword = drv["Password"].ToString();
        }

        private void submitButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == boxUsername && passwordBox.Text == boxPassword)
            {
                submitUpdate();
            }

            else
            {
                MessageBox.Show("Username or Password Incorrect");
            }
        }

        private void passwordBox_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (usernameBox.Text == boxUsername && passwordBox.Text == boxPassword)
                {
                    submitUpdate();
                    MessageBox.Show("Ticket Submitted");
                }

                else
                {
                    MessageBox.Show("Username or Password Incorrect");
                }
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

        }

        private void submitUpdate()
        {

            if (ticketBox.Text == "")
            {
                MessageBox.Show("Please select a ticket to update.");
            }

            else
            {

                string modified = DateTime.Today.ToString("MM'/'dd'/'yyyy");
                string updatedText = Environment.NewLine + Environment.NewLine + requestorBox.Text + " - " + modified + " : " + Environment.NewLine + updateBox.Text;
                string id = selectedRecordId;
                string table = "Tickets";
                string category = categoryBox.Text;
                string finished = "Unfinished";
                string status = "Open";
                string comments = commentsTextBox.Text + updatedText;
                string closedBy = "Unfinished";

                try
                {
                    DBConn.ticketTableUpdate(id, table, modified, finished, category, status, comments, closedBy);

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

        private void clearFields()
        {
            requestorBox.Text = "";
            ticketBox.Text = "";
            creationDateBox.Text = "";
            modifiedBox.Text = "";
            requestTextBox.Text = "";
            commentsTextBox.Text = "";
            updateBox.Text = "";
        }

        private void ticketMonitorButton_Click(object sender, EventArgs e)
        {
            Process.Start(monitorPath);
        }

    }
}