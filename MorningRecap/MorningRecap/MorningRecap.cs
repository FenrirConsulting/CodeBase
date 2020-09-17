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


namespace MorningRecap
{
    public partial class MorningRecap : Form
    {
        public Credentials creds = new Credentials();

        string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        string worksheetfile = "";
        string accessfile = "";

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



        public MorningRecap()
        {
            InitializeComponent();
            customizeDesign();
            dateLabel.Text = DateTime.Now.ToShortDateString();
            //this.WindowState = FormWindowState.Maximized;
            worksheetfile = folder + "\\MorningRecap.xlsm";
            accessfile = folder + "\\SharepointDatabase.accdb";
        }

        private void customizeDesign()

        {
            panelRecapSubMenu.Visible = false;

        }

        private void hideSubMenu ()
        {
            if (panelRecapSubMenu.Visible == true)
            {
                panelRecapSubMenu.Visible = false;
            }

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {

                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void RecapButtons_Click(object sender, EventArgs e)
        {
            showSubMenu(panelRecapSubMenu);
        }

        private void rxButton_Click(object sender, EventArgs e)
        {
            // Open Form for updating.
            openChildFormInPanel(new RXForm() );
        }

        private void inboundButton_Click(object sender, EventArgs e)
        {

            openChildFormInPanel(new InboundForm());
        }

        private void repackButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new RepackForm());
        }

        private void dpsButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new DPSForm());
        }

        private void mpsButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new MPSForm());
        }

        private void cpsButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new CPSForm());
        }

        private void shippingButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ShippingForm());
        }

        private void offsiteButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new OffsiteForm());
        }

        private void icButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new ICForm());
        }

        private void notesButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new NotesForm());
        }

        private Form activeForm = null;
        private void openChildFormInPanel(Form childForm)
        {
            if (activeForm != null)
                activeForm.Close();
            activeForm = childForm;
            childForm.TopLevel = false;
            childForm.FormBorderStyle = FormBorderStyle.None;
            childForm.Dock = DockStyle.Fill;
            containerPanel.Controls.Add(childForm);
            containerPanel.Tag = childForm;
            childForm.BringToFront();
            childForm.Show();
        }

        private void worksheetButton_Click(object sender, EventArgs e)
        {
            Process.Start(worksheetfile); 
        }

        private void pictureBox2_Click(object sender, EventArgs e)
        {

        }

        private void titlePanel_MouseMove_1(object sender, MouseEventArgs e)
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

        private void resizeButton_Click(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else
                this.WindowState = FormWindowState.Maximized;
        }

        private void minimizeButton_Click(object sender, EventArgs e)
        {
            WindowState = FormWindowState.Minimized;
        }

        private void sharepointButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new SharePointForm());
        }

        private void recordsButton_Click(object sender, EventArgs e)
        {
            openChildFormInPanel(new Records());
        }

        private void credentialsButton_Click(object sender, EventArgs e)
        {
            Credentials.GlobalUser = usernameBox.Text;
            Credentials.GlobalPass = passwordBox.Text;
        }

        private void accessButton_Click(object sender, EventArgs e)
        {
            Process.Start(accessfile); 
        }

        private void websiteButton_Click(object sender, EventArgs e)
        {
            Process.Start("https://aetnao365.sharepoint.com/sites/VeroITCodebase/_layouts/15/viewlsts.aspx?view=14");
        }



    }
}
