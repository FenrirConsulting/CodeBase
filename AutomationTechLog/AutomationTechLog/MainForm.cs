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

        public MainForm(DataRow passedRow)
        {
            InitializeComponent();
            DateTime currentTime = DateTime.Now;
            DateTime olderThanDate = DateTime.Now.AddDays(-60);

            int weekNumber = GetWeekNumber(currentTime);
            weekNumberLabel.Text = "Week Number: " + weekNumber.ToString();
            if (passedRow != null) { nameTitleLabel.Text = passedRow["tlt_name"].ToString(); ; }

            string currentTimeFormated = formatDate(currentTime);
            string olderThanDateFormatted = formatDate(olderThanDate);
            olderDateBox.Text = olderThanDateFormatted;

            
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


        private DataTable buildOverviewDataTable() {

            DataTable TECHLOGTable = DBConn.getTable("TECHLOG");
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
                dt2.Field<string>("tlu_time")
            }, false);
            query.CopyToDataTable();

            return filledTable;

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

        private void searchButton_Click(object sender, EventArgs e)
        {
            DataTable searchedTable = buildOverviewDataTable();
            datagridOverview.DataSource = searchedTable;
        }

        private void cancelSearchButton_Click(object sender, EventArgs e)
        {
            bool showEntered = Convert.ToBoolean(enteredOrdersCheckbox.CheckState);
            MessageBox.Show(showEntered.ToString());
        }




    }
}
