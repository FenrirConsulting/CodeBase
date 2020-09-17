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
    public partial class ClosedTickets : Form
    {
        public DBConnection DBConn = new DBConnection();
        DataTable ticketTable = new DataTable();
        DataTable userTable = new DataTable();

        public ClosedTickets()
        {
            InitializeComponent();
            ticketTable = DBConn.getClosedTicketsTable("Tickets");
            userTable = DBConn.getTable("Users");
            dataGridView.DataSource = ticketTable;
            this.dataGridView.Columns["ID"].Visible = false;
            this.dataGridView.Columns["TicketID"].Width = 60;
            this.dataGridView.Columns["Email"].Visible = false;
            this.dataGridView.Columns["Category"].Visible = false;
            this.dataGridView.Columns["Comments"].Visible = false;
            this.dataGridView.Columns["Request"].Visible = false;
            this.dataGridView.Columns["Modified"].Visible = false;
            this.dataGridView.Columns["Status"].Visible = false;

            foreach (DataGridViewColumn column in dataGridView.Columns)
            {

                column.SortMode = DataGridViewColumnSortMode.Automatic;
            }

        }

        private void dataGridView_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

            requestorBox.Text = dataGridView.CurrentRow.Cells["Requestor"].Value.ToString();
            ticketBox.Text = dataGridView.CurrentRow.Cells["TicketID"].Value.ToString();
            creationDateBox.Text = dataGridView.CurrentRow.Cells["Created"].Value.ToString();
            categoryBox.Text = dataGridView.CurrentRow.Cells["Category"].Value.ToString();
            finishedBox.Text = dataGridView.CurrentRow.Cells["Finished"].Value.ToString();
            requestTextBox.Text = dataGridView.CurrentRow.Cells["Request"].Value.ToString();
            commentsTextBox.Text = dataGridView.CurrentRow.Cells["Comments"].Value.ToString();
            closedBox.Text = dataGridView.CurrentRow.Cells["ClosedBy"].Value.ToString();

        }
    }
}