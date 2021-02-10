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

        GlobalUser globalUser;
        public UpdateForm(GlobalUser passedUser)
        {
            globalUser = passedUser;
            InitializeComponent();

            string titleBar = globalUser.globalUsername + " viewing record #" + globalUser.chosenRecord;
            generatedTitle.Text = titleBar;

            DataTable TECHLOGTable = buildTechlogTable();
            DataTable TECHLOGUserTable = buildTechlogUserTable();
            DataTable TECHLOGPartsTable = buildTechlogPartsTable();

            DataTable UserlistTable = DBConn.getTable("TECHLOG_TECHS");
            List<String> userList = UserlistTable.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlt_name")).ToList();

            var col = new DataGridViewComboBoxColumn();
            col.Name = "tlu_name";
            col.DataPropertyName = "tlu_name";
            col.HeaderText = "Tech Name";
            col.DataSource = userList;
            col.DisplayMember = "tlu_name";
            col.ValueMember = "tlu_name";
            userGrid.Columns.Add(col);

            userGrid.DataSource = TECHLOGUserTable;
            partsGrid.DataSource = TECHLOGPartsTable;
            userGrid.RowHeadersWidth = 4;
            partsGrid.RowHeadersWidth = 4;

            string techCount = TECHLOGUserTable.Rows.Count.ToString();
            string partsCount = TECHLOGPartsTable.Rows.Count.ToString();

            techsLabel.Text = "Techs:(" + techCount + ")";
            partsLabel.Text = "Parts:(" + partsCount + ")";

            DataRow selectedRow = TECHLOGTable.Rows[0];

            string modUser = selectedRow["tl_moduser"].ToString();
            string modDate = selectedRow["tl_moddate"].ToString();
            modifiedLabel.Text = "Last Modified by: " + modUser + " on " + modDate;

            stateComboBox.Text = selectedRow["tl_state"].ToString();
            typeComboBox.Text = selectedRow["tl_wotype"].ToString();
            assetTextBox.Text = selectedRow["tl_woasset"].ToString();
            complaintTextBox.Text = selectedRow["tl_wocomplaint"].ToString();
            causeTextBox.Text = selectedRow["tl_worootcause"].ToString();
            correctionTextBox.Text = selectedRow["tl_wocorrection"].ToString();





            userGrid.Columns["tlu_ref"].Visible = false;
            userGrid.Columns["tl_ref"].Visible = false;
            userGrid.Columns["tlu_name"].HeaderText = "Tech Name";
            userGrid.Columns["tlu_shift"].HeaderText = "Shift";
            userGrid.Columns["tlu_time"].HeaderText = "Minutes";
            userGrid.Columns["tlu_date"].HeaderText = "Date";


            partsGrid.Columns["tlp_ref"].Visible = false;
            partsGrid.Columns["tl_ref"].Visible = false;
            partsGrid.Columns["tlp_qnty"].HeaderText = "Qnty";
            partsGrid.Columns["tlp_partnumber"].HeaderText = "Part Number";
            partsGrid.Columns["tlp_location"].HeaderText = "Location";
            partsGrid.Columns["tlp_description"].HeaderText = "Description";

            

            if (globalUser.globalLead != "True") { deleteButton.Enabled = false; deleteButton.Visible = false; }
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
            filledTable.Columns.Add("tlp_qnty", typeof(string));
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
    }
}
