using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace HandsFreeInda
{
    public partial class Clock : Form
    {

        public string ClockText
        {
            get
            {
                return this.clockLabel.Text;
            }
            set
            {
                this.clockLabel.Text = value;
            }
        }


        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST) m.Result = (IntPtr)(HT_CAPTION);
        }

        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;

        public Clock()
        {
            System.Windows.Forms.Timer clockTimer = null;

            InitializeComponent();
            hiddenPicture.Visible = false;

            dateLabel.Text = DateTime.UtcNow.ToString("MM-dd-yyyy");

            clockTimer = new System.Windows.Forms.Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += new EventHandler(clockTimer_Tick);
            clockTimer.Enabled = true;

        }

        void clockTimer_Tick(object sender, EventArgs e)
        {

            clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
        }


        public void hiddenFunctionEnd()
        {
            hiddenLabel.Visible = false;
            hiddenPicture.Visible = false;
        }

        private void Clock_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

        }

    }
}