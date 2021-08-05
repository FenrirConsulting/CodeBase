/*
    Written by Christopher Olson
    For CVS Health
    February 12th, 2021
*/

using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices;
using System.Windows.Forms;

namespace AutomationTechLog
{
    public partial class AddLocation : Form
    {
        private sqlLiteMethods DBConn = new sqlLiteMethods();

        public AddLocation()
        {
            InitializeComponent();

            DataTable locationsListTable = DBConn.getTable("TECHLOG_LOCATIONS");
            List<String> locationsList = locationsListTable.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlloc_locid")).ToList();

            int data = locationsList.Where(x => x.Any(Char.IsDigit))
            .Select(x => int.Parse(new string(x.Where(Char.IsDigit).ToArray())))
            .DefaultIfEmpty(0).Max();

            data++;
            locationTextBox.Text = data.ToString();
            descriptionTextBox.Text = "";
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataTable locationsCheckTable = DBConn.getTable("TECHLOG_LOCATIONS");
            List<String> locationsCheck = locationsCheckTable.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlloc_locid")).ToList();

            int result = locationsCheck.IndexOf(locationTextBox.Text);

            if (result < 0)
            {
                if (locationTextBox.Text != "")
                {
                    DialogResult dr2 = MessageBox.Show("Create this Location?",
                        "Confirm Create Location", MessageBoxButtons.YesNo);

                    switch (dr2)
                    {
                        case DialogResult.Yes:
                            addLocationRecord();
                            Close();
                            break;

                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a Location Number.");
                }
            }
            else
            {
                MessageBox.Show("Location Exists, Pick a New Location");
            }
        }

        private void addLocationRecord()
        {
            int tlloc_ref = DBConn.primaryKeyHighestValue("TECHLOG_LOCATIONS", "tlloc_ref") + 1;
            string tlloc_locid = locationTextBox.Text;
            string tlloc_desc = descriptionTextBox.Text;
            string tlloc_asgcount = "0";

            DBConn.addLocationsRecord(tlloc_ref, tlloc_locid, tlloc_desc, tlloc_asgcount);
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