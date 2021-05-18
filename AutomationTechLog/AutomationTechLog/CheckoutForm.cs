using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Runtime.InteropServices;

namespace AutomationTechLog
{

    public partial class CheckoutForm : Form
    {
        public sqlLiteMethods DBConn = new sqlLiteMethods();

        private const int HT_CAPTION = 0x2;

        private const int HT_CLIENT = 0x1;

        // Allows moving window by holding down left mouse button
        private const int WM_NCHITTEST = 0x84;

        Timer textTimer;
        Timer partsTextTimer;
        Timer closeTimer;
        string userNumber;
        string userName;
        string currentPartNumber;
        DataTable checkoutTable = new DataTable();
        int countdown = 5;
        string formattedTime = "";
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST) m.Result = (IntPtr)(HT_CAPTION);
        }

        public CheckoutForm()
        {
            InitializeComponent();
            
            DateTime currentTime = DateTime.Now;
            formattedTime = currentTime.ToString("MM/dd/yyyy HH:mm:ss");
            clockLabel.Text = "Checkout Time: " + formattedTime;
            partsPanel.Visible = true;
            confirmLabel.Visible = true;
            foundUserLabel.Visible = false;
            userSwipedLabel.Visible = false;


            textTimer = new System.Windows.Forms.Timer();
            textTimer.Interval = 1000;
            textTimer.Tick += new EventHandler(textTimer_Tick);

            partsTextTimer = new System.Windows.Forms.Timer();
            partsTextTimer.Interval = 1000;
            partsTextTimer.Tick += new EventHandler(partsTextTimer_Tick);

            checkoutTable.Columns.Add("Part Number", typeof(string));
            checkoutTable.Columns.Add("Part Description", typeof(string));
            checkoutTable.Columns.Add("Qty", typeof(int));
            partsDataGridView.RowHeadersWidth = 4;
            partsDataGridView.DataSource = checkoutTable;
            partsDataGridView.Columns["Qty"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            partsDataGridView.Columns["Qty"].Width = 60;
            partsDataGridView.Columns["Part Number"].AutoSizeMode = DataGridViewAutoSizeColumnMode.None;
            partsDataGridView.Columns["Part Number"].Width = 120;

            userBox.Focus();
        }

        private void userBox_TextChanged(object sender, EventArgs e)
        {
            textTimer.Start();
        }

        private void textTimer_Tick(Object sender, EventArgs e)
        {
            if (userBox.Focused)
            {
                textTimer.Stop(); //No disposing required, just stop the timer.
                splitUserBarcode();
            }
        }

        private void partsBox_TextChanged(object sender, EventArgs e)
        {
            partsTextTimer.Start();
        }
        private void partsTextTimer_Tick(Object sender, EventArgs e)
        {
            if (partsBox.Focused)
            {
                partsTextTimer.Stop(); //No disposing required, just stop the timer.
                splitPartsBarcode();
            }
        }

        private void splitUserBarcode() {

            string[] str_split;

            if (userBox.Text.Contains(",") && userBox.Text.Length > 10) {

                try
                {
                    str_split = userBox.Text.Split(",".ToCharArray());
                    userNumber = str_split[0];
                    findName();
                }

                catch
                {
                    userBox.Text = "";
                    return;
                }

            }

            userBox.Text = "";
        
        }

        private void splitPartsBarcode() {

            string[] str_split;
            string checkName = "";
            if (partsBox.Text.Contains(",") && partsBox.Text.Length > 10)
            {
                try
                {
                    str_split = partsBox.Text.Split(",".ToCharArray());
                    checkName = str_split[0];
                }
                catch
                {
                    partsBox.Text = "";
                    return;
                }
                if (checkName == userNumber)
                {
                    closingSession();
                }
                else
                {
                    partsBox.Text = "";
                }
            }
            else {
                currentPartNumber = partsBox.Text;
                findPart();
            }



            partsBox.Text = "";

        }

        private void findPart() {

            DataTable partTable = new DataTable();
            partTable = DBConn.getTable("TECHLOG_PARTSINVENTORY");
            string tempDescription = "";
            string tempPart = "";
            bool foundFlag = false;

            foreach (DataRow row in partTable.Rows) {

                if (currentPartNumber == row["tlinv_partnumber"].ToString())
                {
                   
                    tempDescription = row["tlinv_desc"].ToString();
                    tempPart = row["tlinv_partnumber"].ToString();
                    foundFlag = true;
                }
            }

            if (foundFlag == true) {
                addPartToTable(tempPart, tempDescription);
            }
        }

        private void addPartToTable(string tempPart, string tempDescription) {

            bool duplicatePart = false;

            foreach (DataRow row in checkoutTable.Rows) {

                if (tempPart == row["Part Number"].ToString())
                {
                    int tempQty = Convert.ToInt32(row["Qty"]);
                    tempQty++;
                    row["Qty"] = tempQty;
                    duplicatePart = true;
                }
            }

            if (duplicatePart == false) {
                DataRow newRow = checkoutTable.NewRow();
                newRow[0] = tempPart;
                newRow[1] = tempDescription;
                newRow[2] = 1;
                checkoutTable.Rows.Add(newRow);
            }
            partsDataGridView.Refresh();
        }

        private void closingSession() {

            confirmParts();
            string tempcountdown = countdown.ToString();
            confirmLabel.Text = "Parts Confirmed, Closing session in " + tempcountdown +" seconds.";
            closeTimer = new System.Windows.Forms.Timer();
            closeTimer.Interval = 1000;
            closeTimer.Tick += new EventHandler(closeTimer_Tick);
            closeTimer.Start();
        }

        private void confirmParts() {

            foreach (DataRow row in checkoutTable.Rows) {

                int tlc_ref = DBConn.primaryKeyHighestValue("TECHLOG_CHECKOUT","tlc_ref");
                tlc_ref++;
                string tlt_name = userName;
                string tlt_auname = userNumber;
                string tlinv_partnumber = row["Part Number"].ToString();
                string tlinv_desc = row["Part Description"].ToString();
                int tlc_qty = Convert.ToInt32(row["Qty"]); ;
                string tlc_date = formattedTime;

                DBConn.addTechlogCheckoutRecord(tlc_ref, tlt_name, tlt_auname, tlinv_partnumber, tlinv_desc, tlc_qty, tlc_date);
            }
        }

        private void closeTimer_Tick(Object sender, EventArgs e)
        {
            countdown--;
            string tempcountdown = countdown.ToString();
            confirmLabel.Text = "Parts Confirmed, Closing session in " + tempcountdown + " seconds.";
            if (countdown == 0) {
                Close();
            }
        }

        private void findName() {

            DataTable nameTable = new DataTable();
            nameTable = DBConn.getTable("TECHLOG_TECHS");
            string tempName = "";
            string tempId = "";
            bool foundFlag = false;

            foreach (DataRow row in nameTable.Rows)
            {
                if (userNumber == row["tlt_auname"].ToString())
                {
                    tempName = row["tlt_name"].ToString();
                    tempId = row["tlt_auname"].ToString();
                    foundFlag = true;
                }
            }

            if (foundFlag == true)
            {
                userSwipedLabel.Visible = false;
                userNumber = tempId;
                userBox.ReadOnly = true;
                userName = tempName;
                swipeNameLabel.Visible = false;
                userBox.Visible = false;
                foundUserLabel.Visible = true;
                foundUserLabel.Text = "Checking out parts for : " +userName;
                partsBox.Focus();

            }
            else {
                userSwipedLabel.Visible = true;
            }

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void CheckoutForm_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

 
    }
}
