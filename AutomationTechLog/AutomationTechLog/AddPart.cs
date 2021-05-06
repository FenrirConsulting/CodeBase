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
    public partial class AddPart : Form
    {
        private sqlLiteMethods DBConn = new sqlLiteMethods();

        public AddPart()
        {
            InitializeComponent();
            DataTable locationListTable = DBConn.getTable("TECHLOG_LOCATIONS");
            List<String> locationList = locationListTable.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlloc_locid")).ToList();
            locationList.Insert(0, "Unassigned");
            locationComboBox.DataSource = locationList;

            DataTable partsListTable = DBConn.getTable("TECHLOG_PARTSINVENTORY");
            List<String> partsList = partsListTable.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlinv_partnumber")).ToList();

            var data = partsList.Where(x =>
            {
                decimal temp;
                return decimal.TryParse(x, out temp);
            }).Max(x => Convert.ToDecimal(x));
            data++;
            partNumberTextBox.Text = data.ToString();
            quantityTextBox.Text = "0";
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

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void quantityTextBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        private void addButton_Click(object sender, EventArgs e)
        {
            DataTable partsCheck = DBConn.getTable("TECHLOG_PARTSINVENTORY");
            List<String> partsListCheck = partsCheck.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlinv_partnumber")).ToList();

            int result = partsListCheck.IndexOf(partNumberTextBox.Text);

            if (result < 0)
            {
                if (partNumberTextBox.Text != "")
                {
                    DialogResult dr2 = MessageBox.Show("Create this Part?",
                        "Confirm Create Part", MessageBoxButtons.YesNo);

                    switch (dr2)
                    {
                        case DialogResult.Yes:
                            addPartRecord();
                            Close();
                            break;

                        case DialogResult.No:
                            break;
                    }
                }
                else
                {
                    MessageBox.Show("Please enter a part number.");
                }
            }
            else
            {
                MessageBox.Show("Part Number Exists, Pick a New Number");
            }
        }

        private void addPartRecord()
        {
            int tlinv_ref = DBConn.primaryKeyHighestValue("TECHLOG_PARTSINVENTORY", "tlinv_ref") + 1;
            string tlinv_partnumber = partNumberTextBox.Text;
            string tlloc_locid = locationComboBox.Text;
            int tlinv_qty = Int32.Parse(quantityTextBox.Text);
            string tlinv_desc = descriptionTextBox.Text;

            DBConn.addTechlogPartsInventoryRecord(tlinv_ref, tlinv_partnumber, tlloc_locid, tlinv_qty, tlinv_desc);
            if (tlloc_locid != "Unassigned") { updateLocationCount(tlloc_locid); }
        }

        private void updateLocationCount(string locationID)
        {
            string tempString;
            DataTable TECHLOGInvTable = DBConn.getTable("TECHLOG_PARTSINVENTORY");
            int numberOfRecords = TECHLOGInvTable.Select("tlloc_locid =" + locationID).Length;
            tempString = numberOfRecords.ToString();
            DBConn.updateLocationCount(tempString, locationID);
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.titlePanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.bodyPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }
    }
}