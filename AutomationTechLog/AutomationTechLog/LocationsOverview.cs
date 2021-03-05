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

    public partial class LocationsOverview : Form
    {
        sqlLiteMethods DBConn = new sqlLiteMethods();
        DataTable TECHLOGLocationsTable = new DataTable();
        GlobalUser globalUser;

        public LocationsOverview(GlobalUser passedUser)
        {
            globalUser = passedUser;
            InitializeComponent();
            buildTables();
        }

        public void buildTables()
        {

            TECHLOGLocationsTable = buildPartsTable();
            locationsGrid.DataSource = TECHLOGLocationsTable;

            locationsGrid.Columns["tlloc_ref"].Visible = false;
            locationsGrid.Columns["tlloc_locid"].HeaderText = "Location";
            locationsGrid.Columns["tlloc_desc"].HeaderText = "Location Description";
            locationsGrid.Columns["tlloc_asgcount"].HeaderText = "Assigned Parts";
            locationsGrid.RowHeadersWidth = 10;
        }

        public DataTable buildPartsTable()
        {

            DataTable TECHLOGLocTable = DBConn.getTable("TECHLOG_LOCATIONS"); ;

            DataTable filledTable = new DataTable();
            filledTable.Columns.Add("tlloc_ref", typeof(int));
            filledTable.Columns.Add("tlloc_locid", typeof(string));
            filledTable.Columns.Add("tlloc_desc", typeof(string));
            filledTable.Columns.Add("tlloc_asgcount", typeof(string));

            var query =
            from dt1 in TECHLOGLocTable.AsEnumerable()

            select filledTable.LoadDataRow(new object[]
            {
                dt1.Field<int>("tlloc_ref"),
                dt1.Field<string>("tlloc_locid"),
                dt1.Field<string>("tlloc_desc"),
                dt1.Field<string>("tlloc_asgcount")
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

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.bodyPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.titlePanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void locationsGrid_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
        {
            if (e.ColumnIndex == 3)
            {
                string temp = e.Value.ToString();
                if (temp == "0")
                {
                    e.Value = "Empty";
                }
            }
        }

    }
}
