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

namespace ITTicketSystem
{
    public partial class MainForm : Form
    {

        public MainForm()
        {
            InitializeComponent();
            menuPanel.Visible = false;
            string today = DateTime.Today.ToString("MM'/'dd'/'yyyy");
            dateLabel.Text = today;
        }

        // Opens one of the ChildForms when the button is pressed into the ContainerPanel
        private Form activeForm = null;
        public void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null) activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(childForm);
            containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        //**********************************************************************
        // Section 2 - Buttons and Title Bar Movement
        //**********************************************************************
        public void hideSubMenu()
        {
            if (menuPanel.Visible == true)
            {
                menuPanel.Visible = false;
            }

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {

                hideSubMenu();
                subMenu.Visible = true;
                subMenu.BringToFront();
            }
            else subMenu.Visible = false;
        }

        private void menuButtons_Click(object sender, EventArgs e)
        {
            showSubMenu(menuPanel);
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;
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

        private void titleLabel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void createButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CreateTicket());
            hideSubMenu();
        }

        private void openButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new OpenTicket());
            hideSubMenu();
        }

        private void closedButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ClosedTickets());
            hideSubMenu();
        }

        private void updateButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new UpdateTicket());
            hideSubMenu();
        }

        private void settingsButton_Click_1(object sender, EventArgs e)
        {
            openChildFormInPanel(new Settings());
            hideSubMenu();
        }

    }
}