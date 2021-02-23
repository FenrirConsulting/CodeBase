
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
    public partial class UpdateForm : Form
    {
        sqlLiteMethods DBConn = new sqlLiteMethods();
        DateTimePicker oDateTimePicker = new DateTimePicker();
        DataTable TECHLOGTable = new DataTable();
        DataTable TECHLOGUserTable = new DataTable();
        DataTable TECHLOGPartsTable = new DataTable();
        string modUser = "";
        string modDate = "";
        int techsCount = 0;
        int partsCount = 0;
        ContextMenu techContextMenu = new ContextMenu();
        ContextMenu partsContextMenu = new ContextMenu();

        GlobalUser globalUser;
        public UpdateForm(GlobalUser passedUser)
        {
            globalUser = passedUser;
            InitializeComponent();
            buildTables();
        }

        public void buildTables() {

            string titleBar = globalUser.globalUsername + " viewing record #" + globalUser.chosenRecord;
            generatedTitle.Text = titleBar;

            addUserDateTime.CustomFormat = "MM-dd-yyyy";
            addUserDateTime.Format = DateTimePickerFormat.Custom;

            TECHLOGTable = buildTechlogTable();
            TECHLOGUserTable = buildTechlogUserTable();
            TECHLOGPartsTable = buildTechlogPartsTable();



            userGrid.DataSource = TECHLOGUserTable;
            partsGrid.DataSource = TECHLOGPartsTable;
            userGrid.RowHeadersWidth = 4;
            partsGrid.RowHeadersWidth = 4;

            techsCount = TECHLOGUserTable.Rows.Count;
            partsCount = TECHLOGPartsTable.Rows.Count;

            techsLabel.Text = "Techs:(" + techsCount + ")";
            partsLabel.Text = "Parts:(" + partsCount + ")";

            DataRow selectedRow = TECHLOGTable.Rows[0];

            modUser = selectedRow["tl_moduser"].ToString();
            modDate = selectedRow["tl_moddate"].ToString();
            modifiedLabel.Text = "Last Modified by: " + modUser + " on " + modDate;

            stateComboBox.Text = selectedRow["tl_state"].ToString();
            typeComboBox.Text = selectedRow["tl_wotype"].ToString();
            assetTextBox.Text = selectedRow["tl_woasset"].ToString();
            complaintTextBox.Text = selectedRow["tl_wocomplaint"].ToString();
            causeTextBox.Text = selectedRow["tl_worootcause"].ToString();
            correctionTextBox.Text = selectedRow["tl_wocorrection"].ToString();



            DataTable UserlistTable = DBConn.getTable("TECHLOG_TECHS");
            List<String> userList = UserlistTable.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlt_name")).ToList();
            addUserBox.DataSource = userList;
            DataGridViewComboBoxColumn userListBox = new DataGridViewComboBoxColumn();
            userListBox.DataSource = userList;
            userListBox.HeaderText = "Tech Name";
            userListBox.Name = "Tech Name";
            userGrid.Columns.Add(userListBox);
            userGrid.Columns["Tech Name"].DataPropertyName = "tlu_name";

            DataGridViewCellStyle cell_style = new DataGridViewCellStyle();
            cell_style.BackColor = Color.LightYellow;
            cell_style.Alignment = DataGridViewContentAlignment.MiddleLeft;
            userGrid.Columns["Tech Name"].DefaultCellStyle = cell_style;

            userGrid.Columns["tlu_ref"].Visible = false;
            userGrid.Columns["tl_ref"].Visible = false;
            userGrid.Columns["tlu_name"].Visible = false;
            userGrid.Columns["tlu_shift"].HeaderText = "Shift";
            userGrid.Columns["tlu_time"].HeaderText = "Minutes";
            userGrid.Columns["tlu_date"].HeaderText = "Date";


            partsGrid.Columns["tlp_ref"].Visible = false;
            partsGrid.Columns["tl_ref"].Visible = false;
            partsGrid.Columns["tlp_qnty"].HeaderText = "Qnty";
            partsGrid.Columns["tlp_partnumber"].HeaderText = "Part Number";
            partsGrid.Columns["tlp_location"].HeaderText = "Location";
            partsGrid.Columns["tlp_description"].HeaderText = "Description";


            deleteButton.Enabled = false; deleteButton.Visible = false;
            addUserBox.Text = globalUser.globalUsername;

            if (globalUser.globalLead == "True" || globalUser.globalPartsLead == "True" || globalUser.globalAdmin == "True") { deleteButton.Enabled = true; deleteButton.Visible = true; }



        }

        public DataTable buildTechlogTable() {

            DataTable TECHLOGTable = DBConn.getSelectedRecord("TECHLOG", globalUser.chosenRecord);
            
            DataTable filledTable = new DataTable();
            filledTable.Columns.Add("tl_ref", typeof(int));
            filledTable.Columns.Add("tl_state", typeof(string));
            filledTable.Columns.Add("tl_wotype", typeof(string));
            filledTable.Columns.Add("tl_woasset", typeof(string));
            filledTable.Columns.Add("tl_wocomplaint", typeof(string));
            filledTable.Columns.Add("tl_worootcause", typeof(string));
            filledTable.Columns.Add("tl_wocorrection", typeof(string));
            filledTable.Columns.Add("tl_genuser", typeof(string));
            filledTable.Columns.Add("tl_gendate", typeof(string));
            filledTable.Columns.Add("tl_moduser", typeof(string));
            filledTable.Columns.Add("tl_moddate", typeof(string));

            var query =
            from dt1 in TECHLOGTable.AsEnumerable()

            select filledTable.LoadDataRow(new object[]
            {
                dt1.Field<int>("tl_ref"),
                dt1.Field<string>("tl_state"),
                dt1.Field<string>("tl_wotype"),
                dt1.Field<string>("tl_woasset"),
                dt1.Field<string>("tl_wocomplaint"),
                dt1.Field<string>("tl_worootcause"),
                dt1.Field<string>("tl_wocorrection"),
                dt1.Field<string>("tl_genuser"),
                dt1.Field<string>("tl_gendate"),
                dt1.Field<string>("tl_moduser"),
                dt1.Field<string>("tl_moddate")

            }, false);
            query.CopyToDataTable();


            DataTable clonedTable = filledTable.Clone();
            clonedTable.Columns["tl_moddate"].DataType = typeof(DateTime);

            foreach (DataRow row in filledTable.Rows)
            {
                clonedTable.ImportRow(row);
            }

            return clonedTable;
        }

        public DataTable buildTechlogUserTable()
        {

            DataTable TECHLOGTable = DBConn.getSelectedRecord("TECHLOG_USER", globalUser.chosenRecord);

            DataTable filledTable = new DataTable();
            filledTable.Columns.Add("tlu_ref", typeof(int));
            filledTable.Columns.Add("tl_ref", typeof(int));
            filledTable.Columns.Add("tlu_name", typeof(string));
            filledTable.Columns.Add("tlu_shift", typeof(string));
            filledTable.Columns.Add("tlu_time", typeof(string));
            filledTable.Columns.Add("tlu_date", typeof(string));


            if (TECHLOGTable != null && TECHLOGTable.Rows.Count > 0) {

                var query =
                from dt1 in TECHLOGTable.AsEnumerable()

                select filledTable.LoadDataRow(new object[]
                {
                dt1.Field<int>("tlu_ref"),
                dt1.Field<int>("tl_ref"),
                dt1.Field<string>("tlu_name"),
                dt1.Field<string>("tlu_shift"),
                dt1.Field<string>("tlu_time"),
                dt1.Field<string>("tlu_date")
                }, false);
                query.CopyToDataTable();

            }




            DataTable clonedTable = filledTable.Clone();
            clonedTable.Columns["tlu_date"].DataType = typeof(DateTime);

            foreach (DataRow row in filledTable.Rows)
            {
                clonedTable.ImportRow(row);
            }

            return clonedTable;
        }

        public DataTable buildTechlogPartsTable()
        {

            DataTable TECHLOGTable = DBConn.getSelectedRecord("TECHLOG_PARTS", globalUser.chosenRecord);


            DataTable filledTable = new DataTable();
            filledTable.Columns.Add("tlp_ref", typeof(int));
            filledTable.Columns.Add("tl_ref", typeof(int));
            filledTable.Columns.Add("tlp_qnty", typeof(int));
            filledTable.Columns.Add("tlp_partnumber", typeof(string));
            filledTable.Columns.Add("tlp_location", typeof(string));
            filledTable.Columns.Add("tlp_description", typeof(string));

            if (TECHLOGTable != null && TECHLOGTable.Rows.Count>0) {

                var query =
                from dt1 in TECHLOGTable.AsEnumerable()

                select filledTable.LoadDataRow(new object[]
                {
                dt1.Field<int>("tlp_ref"),
                dt1.Field<int>("tl_ref"),
                dt1.Field<int>("tlp_qnty"),
                dt1.Field<string>("tlp_partnumber"),
                dt1.Field<string>("tlp_location"),
                dt1.Field<string>("tlp_description")

                }, false);
                  query.CopyToDataTable();

            }

            return filledTable;
        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

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

        private void titlePanel_MouseMove_1(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void titlePanel_Paint_1(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.titlePanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.bodyPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void userGrid_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == 5) {
                //Initialized a new DateTimePicker Control  

                //Adding DateTimePicker control into DataGridView   
                userGrid.Controls.Add(oDateTimePicker);

                // Setting the format (i.e. 2014-10-10)  
                oDateTimePicker.Format = DateTimePickerFormat.Custom;
                oDateTimePicker.CustomFormat = "MM-dd-yyyy";

                // It returns the retangular area that represents the Display area for a cell  
                Rectangle oRectangle = userGrid.GetCellDisplayRectangle(e.ColumnIndex, e.RowIndex, true);

                //Setting area for DateTimePicker Control  
                oDateTimePicker.Size = new Size(oRectangle.Width, oRectangle.Height);

                // Setting Location  
                oDateTimePicker.Location = new Point(oRectangle.X, oRectangle.Y);

                // An event attached to dateTimePicker Control which is fired when DateTimeControl is closed  
                oDateTimePicker.CloseUp += new EventHandler(oDateTimePicker_CloseUp);

                // An event attached to dateTimePicker Control which is fired when any date is selected  
                oDateTimePicker.TextChanged += new EventHandler(dateTimePicker_OnTextChange);

                // Now make it visible  
                oDateTimePicker.Visible = true;
            }

        }

        private void dateTimePicker_OnTextChange(object sender, EventArgs e)
        {
            // Saving the 'Selected Date on Calendar' into DataGridView current cell  
            userGrid.CurrentCell.Value = oDateTimePicker.Text.ToString();
        }

        void oDateTimePicker_CloseUp(object sender, EventArgs e)
        {
            // Hiding the control after use   
            oDateTimePicker.Visible = false;
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Update this record?",
                      "Confirm Change", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes: updateRecord();
                    break;
                case DialogResult.No:
                    break;

            }
        }

        private void updateRecord() {

            foreach (DataRow selectedRow in TECHLOGTable.Rows)
            {
                DateTime currentTime = DateTime.Now;
                DataRow currentRow = TECHLOGTable.Rows[0];

                int tl_ref = (int)currentRow["tl_ref"];
                string tl_state = stateComboBox.Text;
                string tl_wotype = typeComboBox.Text;
                string tl_woasset = assetTextBox.Text;
                string tl_wocomplaint = complaintTextBox.Text;
                string tl_worootcause = causeTextBox.Text;
                string tl_wocorrection = correctionTextBox.Text;
                string tl_genuser = currentRow["tl_genuser"].ToString();
                string tl_gendate = currentRow["tl_gendate"].ToString();
                string tl_moduser = modUser;
                string tl_moddate = currentTime.ToString("MM/dd/yyyy HH:mm:ss");

                DBConn.techlogRecordUpdate(tl_ref, tl_state, tl_wotype, tl_woasset, tl_wocomplaint, tl_worootcause, tl_wocorrection, tl_genuser, tl_gendate, tl_moduser,tl_moddate);

            }

            foreach (DataGridViewRow currentRow in userGrid.Rows) {

                if (currentRow.Index <= techsCount) {

                    if (currentRow.Cells["tlu_ref"].Value != null) {
                        DateTime currentTime = DateTime.Now;
                        int tlu_ref = (int)currentRow.Cells["tlu_ref"].Value;
                        int tl_ref  = (int)currentRow.Cells["tl_ref"].Value;
                        string tlu_name = currentRow.Cells["tlu_name"].Value.ToString();
                        string tlu_time = currentRow.Cells["tlu_time"].Value.ToString();
                        string tlu_shift = currentRow.Cells["tlu_shift"].Value.ToString();
                        string raw_date = currentRow.Cells["tlu_date"].Value.ToString();
                        DateTime parsedDateTime = DateTime.Parse(raw_date, CultureInfo.InvariantCulture);
                        string tlu_date = parsedDateTime.ToString("MM-dd-yyyy");

                        DBConn.techlogUserRecordUpdate(tlu_ref, tl_ref, tlu_name, tlu_time, tlu_shift, tlu_date);
                    }
                }


            }

            foreach (DataGridViewRow currentRow in partsGrid.Rows) {

                if (currentRow.Index <= partsCount)
                {
                    if (currentRow.Cells["tlp_ref"].Value != null)
                    {
                        int tlp_ref = (int)currentRow.Cells["tlp_ref"].Value;
                        int tl_ref = (int)currentRow.Cells["tl_ref"].Value;
                        int tlp_qnty = (int)currentRow.Cells["tlp_qnty"].Value;
                        string tlp_partnumber = currentRow.Cells["tlp_partnumber"].Value.ToString();
                        string tlp_location = currentRow.Cells["tlp_location"].Value.ToString();
                        string tlp_description = currentRow.Cells["tlp_description"].Value.ToString();

                        DBConn.techlogPartsRecordUpdate(tlp_ref, tl_ref, tlp_qnty, tlp_partnumber, tlp_location, tlp_description);
                    }
                }

            }

            updateModDate();
            refreshTable();

        }



        private void addTechButton_Click(object sender, EventArgs e)
        {

            DialogResult dr = MessageBox.Show("Add this tech?",
            "Confirm Add", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    if (globalUser.chosenRecord != null && addShiftBox.Text != "" && addTimeTextBox.Text != "" && addUserDateTime.Text != "" && addUserBox.Text != "")
                    {

                        int tlu_ref = DBConn.primaryKeyHighestValue("TECHLOG_USER", "tlu_ref") + 1;
                        int tl_ref = Int32.Parse(globalUser.chosenRecord);
                        string tlu_shift = addShiftBox.Text;
                        string tlu_time = addTimeTextBox.Text; 
                        string tlu_date = addUserDateTime.Text; 
                        string tlu_name = addUserBox.Text; 

                        DBConn.addTechlogUserRecord(tlu_ref, tl_ref, tlu_shift, tlu_time, tlu_date, tlu_name);
                        updateModDate();
                    }
                    else {
                        MessageBox.Show("Error, record not added. Fill out all fields correctly.");
                    }
                    refreshTable();
                    break;
                case DialogResult.No:
                    break;

            }

        }

        private void addPartButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Add this part?",
           "Confirm Add", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    if (globalUser.chosenRecord != null && addQuantityBox.Text != "" && addPartNumberBox.Text != "" && addLocationBox.Text != "" && addDescriptionBox.Text != "")
                    {

                        int tlp_ref = DBConn.primaryKeyHighestValue("TECHLOG_PARTS", "tlp_ref") + 1;
                        int tl_ref = Int32.Parse(globalUser.chosenRecord);
                        int tlp_qnty = Int32.Parse(addQuantityBox.Text);
                        string tlp_partnumber = addPartNumberBox.Text;
                        string tlp_location = addLocationBox.Text;
                        string tlp_description = addDescriptionBox.Text;

                        DBConn.addTechlogPartsRecord(tlp_ref, tl_ref, tlp_qnty, tlp_partnumber, tlp_location, tlp_description);
                        updateModDate();
                    }
                    else
                    {
                        MessageBox.Show("Error, record not added. Fill out all fields correctly.");
                    }
                    refreshTable();
                    break;
                case DialogResult.No:
                    break;

            }
        }

        private void userGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right) {

                if (globalUser.globalLead == "True" || globalUser.globalAdmin == "True" || globalUser.globalPartsLead == "True") {
                    int selectedRow = (int)userGrid.Rows[e.RowIndex].Cells[0].Value;
                    userGrid.Rows[e.RowIndex].Selected = true;

                    MenuItem deleteItem = new MenuItem();

                    deleteItem.Text = "Delete Tech Entry";
                    techContextMenu.MenuItems.Add(deleteItem);
                    deleteItem.Click += new System.EventHandler((s, f) => TechMenuItemNew_Click(s, f, selectedRow));

                    techContextMenu.Show(userGrid, new Point(e.X, e.Y));
                }
            }
        }

        private void TechMenuItemNew_Click(Object sender, System.EventArgs e, int selectedRow)
        {

            DialogResult dr = MessageBox.Show("Delete this tech?",
            "Confirm Deletion", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    DBConn.deleteRecord("TECHLOG_USER", "tlu_ref", selectedRow);
                    techContextMenu.MenuItems.Clear();
                    userGrid.ClearSelection();
                    updateModDate();
                    refreshTable();
                    break;
                case DialogResult.No:
                    techContextMenu.MenuItems.Clear();
                    userGrid.ClearSelection();
                    break;

            }

        }

        private void partsGrid_CellMouseClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (e.Button == MouseButtons.Right)
            {

                if (globalUser.globalLead == "True" || globalUser.globalAdmin == "True" || globalUser.globalPartsLead == "True")
                {
                    int selectedRow = (int)partsGrid.Rows[e.RowIndex].Cells[0].Value;
                    partsGrid.Rows[e.RowIndex].Selected = true;

                    MenuItem deleteItem = new MenuItem();
                    deleteItem.Text = "Delete Parts Entry";
                    partsContextMenu.MenuItems.Add(deleteItem);
                    deleteItem.Click += new System.EventHandler((s, f) => PartsMenuItemNew_Click(s, f, selectedRow));

                    partsContextMenu.Show(partsGrid, new Point(e.X, e.Y));
                }
            }
        }

        private void PartsMenuItemNew_Click(Object sender, System.EventArgs e, int selectedRow)
        {

            DialogResult dr = MessageBox.Show("Delete this part?",
            "Confirm Deletion", MessageBoxButtons.YesNo);

            switch (dr)
            {
                case DialogResult.Yes:
                    DBConn.deleteRecord("TECHLOG_PARTS", "tlp_ref", selectedRow);
                    partsContextMenu.MenuItems.Clear();
                    partsGrid.ClearSelection();
                    updateModDate();
                    refreshTable();
                    break;
                case DialogResult.No:
                    partsContextMenu.MenuItems.Clear();
                    partsGrid.ClearSelection();
                    break;

            }

        }


        private void refreshTable() {

            userGrid.DataSource = null;
            userGrid.Rows.Clear();
            partsGrid.DataSource = null;
            partsGrid.Rows.Clear();
            buildTables();
        }

        private void userGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 3 || e.ColumnIndex == 4) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter only numbers.");
                }
                else
                {
                    // the input is numeric 
                }
            }
        }

        private void partsGrid_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
        {
            if (e.ColumnIndex == 2 || e.ColumnIndex == 3) // 1 should be your column index
            {
                int i;

                if (!int.TryParse(Convert.ToString(e.FormattedValue), out i))
                {
                    e.Cancel = true;
                    MessageBox.Show("Please enter only numbers.");
                }
                else
                {
                    // the input is numeric 
                }
            }
        }

        private void addTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(addTimeTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                addTimeTextBox.Text = addTimeTextBox.Text.Remove(addTimeTextBox.Text.Length - 1);
            }
        }

        private void addQuantityBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(addQuantityBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                addQuantityBox.Text = addQuantityBox.Text.Remove(addQuantityBox.Text.Length - 1);
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr = MessageBox.Show("Delete this whole record?",
            "Confirm Deletion", MessageBoxButtons.YesNo);

            int selectedRow = Int32.Parse(globalUser.chosenRecord);
            switch (dr)
            {
                case DialogResult.Yes:
                    DBConn.deleteRecord("TECHLOG", "tl_ref", selectedRow);
                    DBConn.deleteRecord("TECHLOG_USER", "tl_ref", selectedRow);
                    DBConn.deleteRecord("TECHLOG_PARTS", "tl_ref", selectedRow);
                    MessageBox.Show("Record Deleted");
                    Close();
                    break;
                case DialogResult.No:
                    break;

            }
        }

        private void updateModDate() {

            DateTime currentTime = DateTime.Now;
            int tl_ref = Int32.Parse(globalUser.chosenRecord);
            string tl_moduser = globalUser.globalUsername;
            string tl_moddate = currentTime.ToString("MM/dd/yyyy HH:mm:ss");
            DBConn.techlogModDateUpdate(tl_ref, tl_moduser, tl_moddate);
        }
    }
}
