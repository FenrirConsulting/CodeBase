/*
    Written by Christopher Olson 
    For CVS Health
    February 12th, 2021
*/


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
using System.Globalization;

namespace AutomationTechLog
{
    public partial class MainForm : Form 
    {
        sqlLiteMethods DBConn = new sqlLiteMethods();
        int rowCount = 0;
        int selectedRow = 0;

        GlobalUser globalUser = new GlobalUser();

        public MainForm(DataRow passedRow)
        {
            InitializeComponent();
            DateTime currentTime = DateTime.Now;
            DateTime olderThanDate = DateTime.Now.AddDays(-60);

            int weekNumber = GetWeekNumber(currentTime);
            weekNumberLabel.Text = "Week Number: " + weekNumber.ToString();
            if (passedRow != null) {

                globalUser.globalUsername = passedRow["tlt_name"].ToString(); nameTitleLabel.Text = globalUser.globalUsername;
                globalUser.globalEmployeeId = passedRow["tlt_auname"].ToString();
                globalUser.globalAdmin = passedRow["tlt_isadmin"].ToString();
                globalUser.globalLead = passedRow["tlt_islead"].ToString();
                globalUser.globalPartsLead = passedRow["tlt_ispartslead"].ToString();
                globalUser.globalActive = passedRow["tlt_isactive"].ToString();
                globalUser.globalPassword = passedRow["tlt_pword"].ToString();

            }
            toolStripCSVButton.Visible = false; ;
            reportsButton.Visible = false;

            string currentTimeFormated = formatDate(currentTime);
            string olderThanDateFormatted = formatDate(olderThanDate);
            olderDateBox.Text = olderThanDateFormatted;

            DataTable searchedTable = buildOverviewDataTable();
            string builtSQL = buildSQL();
            buildDataGridView(searchedTable, builtSQL);
        }

        private string buildSQL() {

            string builtSQL = "";
            string selectSQL = "";
            string whereSQL = "";
            string groupSQL = "";

            builtSQL = selectSQL + whereSQL + groupSQL;

            return builtSQL;
        }

        private string formatDateWithTime (DateTime passedTime) {

            string formattedTime = "";
            formattedTime = passedTime.ToString("MM/dd/yyyy HH:mm:ss");
            return formattedTime;
        
        }

        private string formatDate(DateTime passedTime)
        {
            string formattedDate = "";
            formattedDate = passedTime.ToString("MM/dd/yyyy");
            return formattedDate;
        }

        private DateTime stringToDate(string stringToParse) {

            var parsedDate = DateTime.Parse(stringToParse);

            return parsedDate;
        }

        private DataTable buildOverviewDataTable() {

            DataTable TECHLOGTable = DBConn.getOverviewTable("TECHLOG");
            DataTable TECHLOGUserTable = DBConn.getTable("TECHLOG_USER");


            DataTable filledTable = new DataTable();
            filledTable.Columns.Add("tl_ref", typeof(int));
            filledTable.Columns.Add("tl_state", typeof(string));
            filledTable.Columns.Add("tl_wotype", typeof(string));
            filledTable.Columns.Add("tl_woasset", typeof(string));
            filledTable.Columns.Add("tl_wocomplaint", typeof(string));
            filledTable.Columns.Add("tl_genuser", typeof(string));
            filledTable.Columns.Add("tl_gendate", typeof(string));
            filledTable.Columns.Add("tl_worootcause", typeof(string));
            filledTable.Columns.Add("tl_wocorrection", typeof(string));
            filledTable.Columns.Add("tl_moduser", typeof(string));
            filledTable.Columns.Add("tl_moddate", typeof(string));
            filledTable.Columns.Add("tlu_time", typeof(string));
            filledTable.Columns.Add("TTime", typeof(long));
            filledTable.Columns.Add("CountField", typeof(long));


            var query = 
            from dt1 in TECHLOGTable.AsEnumerable()
            join dt2 in TECHLOGUserTable.AsEnumerable()
            on dt1.Field<int>("tl_ref") equals dt2.Field<int>("tl_ref")
            
            select filledTable.LoadDataRow(new object[] 
            {
                dt1.Field<int>("tl_ref"),
                dt1.Field<string>("tl_state"),
                dt1.Field<string>("tl_wotype"),
                dt1.Field<string>("tl_woasset"),
                dt1.Field<string>("tl_wocomplaint"),
                dt1.Field<string>("tl_genuser"),
                dt1.Field<string>("tl_gendate"),
                dt1.Field<string>("tl_worootcause"),
                dt1.Field<string>("tl_wocorrection"),
                dt1.Field<string>("tl_moduser"),
                dt1.Field<string>("tl_moddate"),
                dt2.Field<string>("tlu_time"),
                dt1.Field<long>("TTime"),
                dt1.Field<long>("CountField")
               
            }, false);
            query.CopyToDataTable();

            
            DataTable clonedTable = filledTable.Clone();
            clonedTable.Columns["tl_gendate"].DataType = typeof(DateTime);
            clonedTable.Columns["tl_moddate"].DataType = typeof(DateTime);

            foreach (DataRow row in filledTable.Rows) {
                clonedTable.ImportRow(row);
            }

            return clonedTable;

        }



        public static int GetWeekNumber(DateTime now)
        {
            CultureInfo ci = CultureInfo.CurrentCulture;
            int weekNumber = ci.Calendar.GetWeekOfYear(now, CalendarWeekRule.FirstFourDayWeek, DayOfWeek.Monday);
            return weekNumber;
        } 

        // Title panel button and click events. Moving, resizing, and closing the main window. 
        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void titlePanel_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;
        }

        // The below code allows moving around the window by holding left click on the title panel.
        public const int WM_NCLBUTTONDOWN = 0xA1;
        public const int HT_CAPTION = 0x2;
        [DllImportAttribute("user32.dll")]
        public static extern int SendMessage(IntPtr hWnd, int Msg, int wParam, int lParam);
        [DllImportAttribute("user32.dll")]
        public static extern bool ReleaseCapture();

        protected override void WndProc(ref Message m)
        {
            if (m.Msg == 0x84)
            {
                const int resizeArea = 10;
                Point cursorPosition = PointToClient(new Point(m.LParam.ToInt32() & 0xffff, m.LParam.ToInt32() >> 16));
                if (cursorPosition.X >= ClientSize.Width - resizeArea && cursorPosition.Y >= ClientSize.Height - resizeArea)
                {
                    m.Result = (IntPtr)17;
                    return;
                }
            }

            base.WndProc(ref m);
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        public void searchButton_Click(object sender, EventArgs e)
        {
            searchFunction();
        }

        

        public void searchFunction() {
            DataTable searchedTable = buildOverviewDataTable();
            string builtSQL = buildSQL();
            buildDataGridView(searchedTable, builtSQL);
        }


        public void buildDataGridView(DataTable passedTable, string builtSQL)
        {
            DateTime oldDate = stringToDate(olderDateBox.Text);
            DateTime currentDate = DateTime.Today;
            DataView results = new DataView(passedTable);
            string builtFilter = "";



            if (olderRecordsCheckbox.Checked) { builtFilter = builtFilter +  "tl_gendate >= #" + oldDate + "#" + " AND "; }
            if (enteredOrdersCheckbox.Checked == false) { builtFilter = builtFilter + "tl_state <> 'Entered'" + " AND "; }
            if (ownerComboBox.SelectedIndex > -1) {
                if (ownerComboBox.Text == "Mine") { builtFilter = builtFilter + " tl_genuser = '" + globalUser.globalUsername + "'" + " AND "; }
                if (ownerComboBox.Text == "Passdown") { builtFilter = builtFilter + "tl_wotype = '" + ownerComboBox.Text + "'" + " AND "; }
            }
            if (searchLikeComboBox.SelectedIndex > -1) {
                string searchTerm = toolStripSearchTextBox.Text;
                string likeTerm = "";
                if (searchLikeComboBox.Text == "Asset Like") { likeTerm = "tl_woasset"; }
                if (searchLikeComboBox.Text == "Ref #") { likeTerm = "tl_ref"; }
                if (searchLikeComboBox.Text == "User Like") { likeTerm = "tl_genuser"; }
                if (searchLikeComboBox.Text == "State Like") { likeTerm = "tl_state"; }
                if (searchLikeComboBox.Text == "Full text") { likeTerm = "tl_wocomplaint"; }
                builtFilter = builtFilter + " " + likeTerm + " = '" + searchTerm + "'" + " AND ";
            }
            if (builtFilter.Length < 5) { builtFilter = builtFilter + " AND "; }

            builtFilter = builtFilter.Remove(builtFilter.Length - 5);
            results.RowFilter = builtFilter;
            results.Sort = "tl_gendate DESC";



           

            datagridOverview.DataSource = results;
            datagridOverview.Columns["tl_ref"].HeaderText = "Ref #";
            datagridOverview.Columns["tl_state"].HeaderText = "State";
            datagridOverview.Columns["tl_wotype"].HeaderText = "Type";
            datagridOverview.Columns["tl_woasset"].HeaderText = "Asset";
            datagridOverview.Columns["tl_wocomplaint"].HeaderText = "Complaint";
            datagridOverview.Columns["tl_genuser"].HeaderText = "Gen User";
            datagridOverview.Columns["tl_gendate"].HeaderText = "Gen Date";
            datagridOverview.Columns["tl_worootcause"].Visible = false;
            datagridOverview.Columns["tl_wocorrection"].Visible = false;
            datagridOverview.Columns["tl_moduser"].Visible = false;
            datagridOverview.Columns["tl_moddate"].Visible = false;
            datagridOverview.Columns["tlu_time"].Visible = false;
            datagridOverview.Columns["TTime"].HeaderText = "Time";
            datagridOverview.Columns["CountField"].Visible = false;
            rowCount = datagridOverview.Rows.Count;
            datagridOverview.RowHeadersWidth = 10;
            rowCountLabel.Text = "Row " + selectedRow.ToString() + " of " + rowCount.ToString();



        }

        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            bool showEntered = Convert.ToBoolean(enteredOrdersCheckbox.CheckState);
            MessageBox.Show(showEntered.ToString());
        }

        private void datagridOverview_SelectionChanged(object sender, EventArgs e)
        {
            if (datagridOverview.CurrentCell != null) {
                selectedRow = datagridOverview.CurrentCell.RowIndex;
                rowCountLabel.Text = "Row " + selectedRow.ToString() + " of " + rowCount.ToString();
            }
        }

        private void datagridOverview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            string str = "";
            if (datagridOverview.Rows.Count != 0) {
                if (datagridOverview.Rows[e.RowIndex].Cells["tl_wotype"].Value != null)
                {
                    str = datagridOverview.Rows[e.RowIndex].Cells["tl_wotype"].Value.ToString();
                }
            }
            if (String.Compare(str,"Passdown",false) == 0) {
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
            }
            else if (String.Compare(str, "Facility", false) == 0)
            {
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.BurlyWood;
            }
            else if (String.Compare(str, "Unplanned", false) == 0)
            {
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGray;
            }
            else if (String.Compare(str, "Improvement", false) == 0)
            {
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
            }
            else if (String.Compare(str, "Review", false) != 0)
            {
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
            }
            else {
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
            }

            string str1 = "";
            if (datagridOverview.Rows.Count != 0)
            {
                if (datagridOverview.Rows[e.RowIndex].Cells["tl_state"].Value != null)
                {
                    str1 = datagridOverview.Rows[e.RowIndex].Cells["tl_state"].Value.ToString();
                }
            }
            if (String.Compare(str1, "Completed", false) == 0)
            {
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Regular);
            }
            else if (String.Compare(str1, "Entered", false) != 0)
            {
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Regular);
            }
            else 
            {
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkBlue;
                this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Bold);
            }

            
            if (datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].Value != null && datagridOverview.Rows[e.RowIndex].Cells["tl_moduser"].Value != null)
            {
                if (String.Compare(datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].Value.ToString(), datagridOverview.Rows[e.RowIndex].Cells["tl_moduser"].Value.ToString(), false) == 0)
                {
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].Style.BackColor = this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].Style.ForeColor = this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.ForeColor;
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_gendate"].Style.BackColor = this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor;
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_gendate"].Style.ForeColor = this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.ForeColor;
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].ToolTipText = "";
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_gendate"].ToolTipText = "";
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].Style.Font = this.datagridOverview.Rows[e.RowIndex].DefaultCellStyle.Font;
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_wocomplaint"].ToolTipText = string.Concat("Correction: ", this.datagridOverview.Rows[e.RowIndex].Cells["tl_wocorrection"].Value.ToString());
                    this.datagridOverview.Rows[e.RowIndex].Cells["TTime"].ToolTipText = string.Concat("Techs: ", this.datagridOverview.Rows[e.RowIndex].Cells["CountField"].Value.ToString());
                }
                else
                {
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].Style.Font = new Font(this.Font.Name, this.Font.Size, FontStyle.Bold);
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].ToolTipText = string.Concat ("Mod by: ", this.datagridOverview.Rows[e.RowIndex].Cells["tl_moduser"].Value.ToString());
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].Style.BackColor = Color.Blue;
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_genuser"].Style.ForeColor = Color.White;
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_gendate"].Style.BackColor = Color.Blue;
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_gendate"].Style.ForeColor = Color.White;
                    this.datagridOverview.Rows[e.RowIndex].Cells["tl_gendate"].ToolTipText = string.Concat("Mod by: ", this.datagridOverview.Rows[e.RowIndex].Cells["tl_moddate"].Value.ToString());
                    this.datagridOverview.Rows[e.RowIndex].Cells["TTime"].ToolTipText = string.Concat("Techs: ", this.datagridOverview.Rows[e.RowIndex].Cells["CountField"].Value.ToString());
                }
            }
        }


        private void addNewButton_Click(object sender, EventArgs e)
        {
            var addForm = new AddForm(globalUser);
            addForm.Show();
            addForm.FormClosed += new FormClosedEventHandler(addForm_Closed);
        }

        private void usersButton_Click(object sender, EventArgs e)
        {
            var userForm = new UserForm(globalUser);
            userForm.Show();
        }

        private void reportsButton_Click(object sender, EventArgs e)
        {
            
        }

        private void datagridOverview_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            globalUser.chosenRecord = datagridOverview.Rows[e.RowIndex].Cells[0].Value.ToString();
            var updateForm = new UpdateForm(globalUser);
            updateForm.Show();
            updateForm.FormClosed += new FormClosedEventHandler(UpdateForm_Closed);
        }

        void addForm_Closed(object sender, FormClosedEventArgs e) {
            searchFunction();
        }

        void UpdateForm_Closed(object sender, FormClosedEventArgs e) {
            searchFunction();
        }

        private void partsButton_Click(object sender, EventArgs e)
        {
            var partsForm = new PartsOverview(globalUser);
            partsForm.Show();
        }

     

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {
            
        }

        private void datagridOverview_Paint(object sender, PaintEventArgs e)
        {
          
        }
    }
}