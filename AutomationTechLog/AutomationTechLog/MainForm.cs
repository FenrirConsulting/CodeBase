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
            DateTime passedTime = DateTime.Now;
            int weekNumber = GetWeekNumber(passedTime);
            weekNumberLabel.Text = "Week Number: " + weekNumber.ToString();
            if (passedRow != null) { nameTitleLabel.Text = passedRow["tlt_name"].ToString(); ; }
            
        }



        private void buildDataGrid() {

            DataTable TECHLOGTable = DBConn.getTable("TECHLOG");
            DataTable TECHLOGUserTable = DBConn.getTable("TECHLOG_USER");
            DataTable dataGridTable;

            var query =

            from dt1 in TECHLOGTable.AsEnumerable()
            join dt2 in TECHLOGUserTable.AsEnumerable()
            on dt1.Field<int>("tl_ref") equals dt2.Field<int>("tl_ref")
            select new
            {
                Ref = dt1.Field<int>("tl_ref"),
                State = dt1.Field<string>("tl_state"),
                Type = dt1.Field<string>("tl_wotype"),
                Asset = dt1.Field<string>("tl_woasset"),
                Complaint = dt1.Field<string>("tl_wocomplaint"),
                GenUser = dt1.Field<string>("tl_genuser"),
                 GenDate = dt1.Field<string>("tl_gendate"),
                RootCause = dt1.Field<string>("tl_worootcause"),
                Correction = dt1.Field<string>("tl_wocorrection"),
                ModUser = dt1.Field<string>("tl_moduser"),
                ModDate = dt1.Field<string>("tl_moddate"),
                Time = dt2.Field<int>("tlu_time")
            };

            DataTable filledTable = query.CopyToDataTable();

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




    }
}
