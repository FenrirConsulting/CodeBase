﻿using System;
using System.Data;
using System.Drawing;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Microsoft.Reporting.WinForms;

/*
SELECT  TECHLOG_USER.tlu_name, TECHLOG_PARTS.tlp_partnumber, TECHLOG_PARTS.tlp_description, TECHLOG_PARTS.tlp_qnty, TECHLOG_USER.tlu_date
FROM TECHLOG
INNER JOIN TECHLOG_PARTS  ON TECHLOG.tl_ref = TECHLOG_PARTS.tl_ref
INNER JOIN TECHLOG_USER  ON TECHLOG.tl_ref = TECHLOG_USER.tl_ref
WHERE TECHLOG.tl_partsConfirmed = 'Yes'
 *
 */

namespace AutomationTechLog
{
    public partial class ReportForm : Form
    {
        private sqlLiteMethods DBConn = new sqlLiteMethods();
        private GlobalUser globalUser;

        public ReportForm(GlobalUser passedUser)
        {
            globalUser = passedUser;
            InitializeComponent();

            DateTime olderThanDate = DateTime.Now.AddDays(-60);
            string formattedDate = olderThanDate.ToString("MM/dd/yyyy");
            olderDateBox.Text = formattedDate;
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void buildReport()
        {
            if (reportSelectionBox.Text == "Parts Report") {

                reportViewer1.Reset();
                reportViewer1.LocalReport.ReportPath = string.Concat(Application.StartupPath, "\\Reports\\PartsReport.rdlc");
                DataTable passedTable = DBConn.getPartsReportTable();
                string builtFilter = "";
                if (olderRecordsCheckbox.Checked) { builtFilter = builtFilter + "tl_gendate >= #" + olderDateBox.Text + "#"; }
                DataView results = new DataView(passedTable);
                results.RowFilter = builtFilter;

                ReportDataSource reportSource = new ReportDataSource("PartsDataSet", results);
                reportViewer1.LocalReport.DataSources.Clear();
                reportViewer1.LocalReport.DataSources.Add(reportSource);
                reportViewer1.RefreshReport();
            }



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

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {
            //ControlPaint.DrawBorder(e.Graphics, this.titlePanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;

            splitContainer.Refresh();
        }

        private void splitContainer_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.splitContainer.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }


        private void pictureBox1_Click(object sender, EventArgs e)
        {
            buildReport();
        }
    }
}