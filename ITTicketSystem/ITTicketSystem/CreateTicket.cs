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
using Outlook = Microsoft.Office.Interop.Outlook;

namespace ITTicketSystem
{
    public partial class CreateTicket : Form
    {

        public DBConnection DBConn = new DBConnection();
        string today = DateTime.Today.ToString("MM'/'dd'/'yyyy");
        string boxUsername = "";
        string boxPassword = "";
        string recipientEmail = "";
        DataTable userTable = new DataTable();
        DataTable ticketTable = new DataTable();
        DataTable techTable = new DataTable();

        public CreateTicket()
        {
            InitializeComponent();
            fillFields();
        }

        // Set Email, Id, and PAssword variables to selected Requestor Data Row.
        private void requestorBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)requestorBox.SelectedItem;
            emailBox.Text = drv["Email"].ToString();
            boxUsername = drv["EmployeeId"].ToString();
            boxPassword = drv["Password"].ToString();
        }

        private void recipientBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            DataRowView drv = (DataRowView)recipientBox.SelectedItem;
            recipientEmail = drv["Email"].ToString();
        }

        // Validate Requestor credentials to submit a new ticket under their name.
        private void submitButton_Click(object sender, EventArgs e)
        {
            if (usernameBox.Text == boxUsername && passwordBox.Text == boxPassword)
            {
                submitTicket();
                DialogResult dialogResult = MessageBox.Show("Ticket Submitted, Send Email?", "Send Email?", MessageBoxButtons.YesNo);
                if (dialogResult == DialogResult.Yes)
                {
                    sendEmail();
                    fillFields();
                }
                else if (dialogResult == DialogResult.No)
                {
                    fillFields();
                }

            }

            else
            {
                MessageBox.Show("Username or Password Incorrect");
            }
        }

        // Sends in all of the needed fields to create a ticket record.
        private void submitTicket()
        {

            int sentTicket = Int32.Parse(ticketBox.Text);
            string sentRequestor = requestorBox.Text;
            string sentEmail = emailBox.Text;
            string sentCategory = categoryBox.Text;
            string sentCreated = today;
            string sentModified = today;
            string sentFinished = "Unfinished";
            string sentStatus = "Open";
            string sentComments = commentsTextBox.Text;
            string sentRequest = requestTextBox.Text;
            string sentClosedBy = "Unfinished";

            try
            {
                DBConn.ticketAddRecord(sentTicket, sentRequestor, sentEmail, sentCategory, sentCreated, sentModified, sentFinished, sentStatus, sentComments, sentRequest, sentClosedBy);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Source + "\n" + ex.Message + "\n" + ex.StackTrace);
            }

        }

        // Various actions to populate the fields with correct data.
        public void fillFields()
        {

            creationDateBox.Text = today;

            userTable = DBConn.getTable("Users");
            ticketTable = DBConn.getTable("Tickets");
            techTable = DBConn.getTechUserTable("Users");
            recipientBox.DataSource = techTable;
            recipientBox.DisplayMember = "Name";
            requestorBox.DataSource = userTable;
            requestorBox.DisplayMember = "Name";
            int highestNumber = ticketTable.AsEnumerable().Max(x => x.Field<int>("TicketID"));
            int newTicket = highestNumber + 1;
            ticketBox.Text = newTicket.ToString();

            List<String> categoriesList = new List<String>();
            categoriesList = DBConn.buildColumnList(categoriesList, "Categories", "Name");

            BindingSource bs = new BindingSource();
            bs.DataSource = categoriesList;
            categoryBox.DataSource = bs;

        }

        private void sendEmail()
        {
            Outlook.Application oApp = new Outlook.Application();
            Outlook._MailItem oMailItem = (Outlook._MailItem)oApp.CreateItem(Outlook.OlItemType.olMailItem);
            Outlook.Recipients oRecips = (Outlook.Recipients)oMailItem.Recipients;
            Outlook.Recipient oRecip = (Outlook.Recipient)oRecips.Add(emailBox.Text);
            Outlook.Recipient oRecip2 = (Outlook.Recipient)oRecips.Add(recipientEmail);
            oRecip.Resolve();
            oRecip2.Resolve();
            oMailItem.Subject = "IT Service Ticket #" + ticketBox.Text + " Sent By " + requestorBox.Text + " " + creationDateBox.Text;
            String body;

            body = "<HTML>\n" + "<BODY><P>\n" + "IT Service Ticket,<br> <br>" + "                  Opening Service Ticket #" + ticketBox.Text + " on " + creationDateBox.Text + " from " + requestorBox.Text + ".<br>" + "<br>" + requestTextBox.Text + "<br>" + "<br>" + commentsTextBox.Text + "<br>" + "<br>" + "</BODY>\n" + "</HTML>";
            oMailItem.Display(oMailItem);
            oMailItem.GetInspector.Activate();
            var signature = oMailItem.HTMLBody;
            oMailItem.HTMLBody = body + signature;
            oMailItem.Display(true);

        }

    }
}