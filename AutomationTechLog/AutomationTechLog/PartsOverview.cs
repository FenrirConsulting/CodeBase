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
    public partial class PartsOverview : Form
    {
        sqlLiteMethods DBConn = new sqlLiteMethods();
        DataTable TECHLOGInventoryTable = new DataTable();
        GlobalUser globalUser;
        int selectedRecord;
        string selectedLocation;
        public PartsOverview(GlobalUser passedUser)
        {
            globalUser = passedUser;
            InitializeComponent();
            buildTables();
        }




        public void buildTables() {

            TECHLOGInventoryTable = buildPartsTable();


            DataView results = new DataView(TECHLOGInventoryTable);

            string builtFilter = "";

            if (searchLikeComboBox.SelectedIndex > -1)
            {
                if (searchLikeComboBox.Text == "Part Number") { builtFilter = builtFilter + " tlinv_partnumber = '" + toolStripSearchTextBox.Text + "'" + " AND "; }
                if (searchLikeComboBox.Text == "Location") { builtFilter = builtFilter + "tlloc_locid = '" + toolStripSearchTextBox.Text + "'" + " AND "; }
            }
            if (builtFilter.Length < 5) { builtFilter = builtFilter + " AND "; }
            builtFilter = builtFilter.Remove(builtFilter.Length - 5);
            results.RowFilter = builtFilter;
            results.Sort = "tlinv_partnumber DESC";

            partsGrid.DataSource = results;
            partsGrid.Columns["tlinv_ref"].Visible = false;
            partsGrid.Columns["tlinv_partnumber"].HeaderText = "Part Number";
            partsGrid.Columns["tlloc_locid"].HeaderText = "Location";
            partsGrid.Columns["tlinv_qty"].HeaderText = "Quantity in Stock";
            partsGrid.Columns["tlinv_desc"].HeaderText = "Part Description";
            partsGrid.Columns["tlinv_partnumber"].ReadOnly = true;
            partsGrid.RowHeadersWidth = 10;

            DataTable locationListTable = DBConn.getTable("TECHLOG_LOCATIONS");
            List<String> locationList = locationListTable.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlloc_locid")).ToList();
            locationTextBox.DataSource = locationList;

        }

        public DataTable buildPartsTable()
        {

            DataTable TECHLOGInvTable = DBConn.getTable("TECHLOG_PARTSINVENTORY"); ;

            DataTable filledTable = new DataTable();
            filledTable.Columns.Add("tlinv_ref", typeof(int));
            filledTable.Columns.Add("tlinv_partnumber", typeof(string));
            filledTable.Columns.Add("tlloc_locid", typeof(string));
            filledTable.Columns.Add("tlinv_qty", typeof(int));
            filledTable.Columns.Add("tlinv_desc", typeof(string));

            var query =
            from dt1 in TECHLOGInvTable.AsEnumerable()

            select filledTable.LoadDataRow(new object[]
            {
                dt1.Field<int>("tlinv_ref"),
                dt1.Field<string>("tlinv_partnumber"),
                dt1.Field<string>("tlloc_locid"),
                dt1.Field<int>("tlinv_qty"),
                dt1.Field<string>("tlinv_desc")
            }, false);
            query.CopyToDataTable();


            return filledTable;
        }

        // Buttons and functions general to forms in applications. 

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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.titlePanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.bodyPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void searchButton_Click(object sender, EventArgs e)
        {

        }

        private void searchButton_Click_1(object sender, EventArgs e)
        {
            buildTables();
        }

        private void toolStripClearButton_Click(object sender, EventArgs e)
        {
            searchLikeComboBox.Text = "";
            searchLikeComboBox.SelectedIndex = -1;
            toolStripSearchTextBox.Text = "";
            buildTables();
        }

        private void partsGrid_SelectionChanged(object sender, EventArgs e)
        {
            if (partsGrid.SelectedRows.Count > 0)
            {
                string partNumber = partsGrid.SelectedRows[0].Cells["tlinv_partnumber"].Value.ToString();
                string location = partsGrid.SelectedRows[0].Cells["tlloc_locid"].Value.ToString();
                string quantity = partsGrid.SelectedRows[0].Cells["tlinv_qty"].Value.ToString();
                string description = partsGrid.SelectedRows[0].Cells["tlinv_desc"].Value.ToString();
                selectedRecord = Int32.Parse(partsGrid.SelectedRows[0].Cells["tlinv_ref"].Value.ToString());
                partNumberTextBox.Text = partNumber;
                locationTextBox.Text = location;
                selectedLocation = location;
                quantityTextBox.Text = quantity;
                descriptionTextBox.Text = description;
            }
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            var addPartsForm = new AddPart();
            addPartsForm.Show();
            addPartsForm.FormClosed += new FormClosedEventHandler(addPartsForm_Closed);
        }

        void addPartsForm_Closed(object sender, FormClosedEventArgs e)
        {
            buildTables();
        }

        private void locationsButton_Click(object sender, EventArgs e)
        {
            var locationForm = new LocationsOverview(globalUser);
            locationForm.Show();
            locationForm.FormClosed += new FormClosedEventHandler(locationForm_Closed);
        }

        void locationForm_Closed(object sender, FormClosedEventArgs e)
        {
            buildTables();
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = MessageBox.Show("Delete this Part?",
                "Confirm Delete Part", MessageBoxButtons.YesNo);

            switch (dr2)
            {
                case DialogResult.Yes:
                    deletePartRecord();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void deletePartRecord() {
            DBConn.deleteRecord("TECHLOG_PARTSINVENTORY", "tlinv_ref", selectedRecord);
            updateLocationCount(selectedLocation);
            buildTables();
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            DialogResult dr2 = MessageBox.Show("Update this Part?",
                "Confirm Update Part", MessageBoxButtons.YesNo);

            switch (dr2)
            {
                case DialogResult.Yes:
                    updatePartRecord();
                    break;
                case DialogResult.No:
                    break;
            }
        }

        private void updatePartRecord() {
            string tlinv_partnumber = partNumberTextBox.Text;
            string tlloc_locid = locationTextBox.Text;
            int tlinv_qty = Int32.Parse(quantityTextBox.Text);
            string tlinv_desc = descriptionTextBox.Text;
            DBConn.techlogPartsInventoryRecordUpdate(selectedRecord, tlinv_partnumber, tlloc_locid, tlinv_qty, tlinv_desc);
            updateLocationCount(tlloc_locid);
            updateLocationCount(selectedLocation);
            buildTables();
        }

        private void workPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.workPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void updateLocationCount(string locationID) {

 
                string tempString;
                DataTable TECHLOGInvTable = DBConn.getTable("TECHLOG_PARTSINVENTORY");
                int numberOfRecords = TECHLOGInvTable.Select("tlloc_locid =" + "'"+locationID+"'").Length;
                tempString = numberOfRecords.ToString();
                DBConn.updateLocationCount(tempString, locationID);
            
        }
    }
}
