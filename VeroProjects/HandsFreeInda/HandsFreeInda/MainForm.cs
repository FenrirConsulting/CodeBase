// INDA Hands Free Clock-In System
// Written by Christopher Olson
// For CVS Health, July 7th 2020

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Windows.Forms;
using System.Windows;
using System.Runtime.Serialization;
using System.Runtime.InteropServices;
using System.Threading;
using System.IO;
using System.Drawing;
using System.Security.Cryptography;
using System.Windows.Automation;
using System.Text.RegularExpressions;
using System.Runtime.CompilerServices;
using System.Security.Permissions;
using System.Threading.Tasks;

namespace HandsFreeInda
{

    public partial class MainForm : Form
    {
        AutomationMethods automation = new AutomationMethods();

        // Named elements for Automation use in other methods
        AutomationElement loginFormElement,
        loginFormCloseElement,
        usernameElement,
        passwordElement,
        okButton,
        cancelButton,
        cancelButtonClose,
        workScreenFormElement,
        workScreenInForDay,
        workScreenStartButton,
        workScreenEndButton,
        lunchButtonElement,
        breakButtonElement,
        otherButtonElement,
        jobCodeElement,
        workScreenOutForDay;

        int delayCount = 0;
        int idleCount = 0;

        string indaProgram = "R:\\abl\\runtime\\bin\\INDA.exe";
        string username = "";
        string password = "";
        string jobCode = "";
        string parsedPassword = "";
        string check = "";
        string computerName = System.Environment.GetEnvironmentVariable("USERNAME", EnvironmentVariableTarget.User);
        string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        string localPath = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName) + "\\ErrorLogs\\";
        string serverPath = "\\\\rfl6dpsapw1v\\wms-rt\\ISShare\\Applications\\INDAHandsFree\\ErrorLogs\\";

        System.Windows.Forms.Timer textTimer;
        System.Windows.Forms.Timer clockTimer = null;

        public MainForm()
        {

            InitializeComponent();
            workScreenFormElement = null;
            loginFormElement = null;

            // Waits .8 seconds from last text entered into the text bar to start parsing the entered barcode.
            textTimer = new System.Windows.Forms.Timer();
            textTimer.Interval = 800;
            textTimer.Tick += new EventHandler(textTimer_Tick);


            // Sets the clock
            dateLabel.Text = DateTime.UtcNow.ToString("MM-dd-yyyy");
            clockTimer = new System.Windows.Forms.Timer();
            clockTimer.Interval = 1000;
            clockTimer.Tick += new EventHandler(clockTimer_Tick);
            clockTimer.Enabled = true;

        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            hideButton();
            userBox.Focus();
            this.BringToFront();
        }

        void clockTimer_Tick(object sender, EventArgs e)
        {

            clockLabel.Text = DateTime.Now.ToString("h:mm:ss tt");
        }

        private void userBox_TextChanged(object sender, KeyEventArgs e)
        {
            textTimer.Start();
        }

        // Timer tracks how long since last character enters Input field, to make sure entire string is entered before launching Login function.
        private void textTimer_Tick(Object sender, EventArgs e)
        {
            if (userBox.Focused)
            {
                textTimer.Stop(); //No disposing required, just stop the timer.
                idleCount = 0;
                splitBarcode();
            }
        }

        // Splits the userBox string into 4 parts: User , Password, Job Code, and Check Character for Function Switch
        private void splitBarcode()
        {

            string[] str_split;

            if (userBox.Text.Contains(",") && userBox.Text.Length > 14)
            {

                try
                {
                    str_split = userBox.Text.Split(",".ToCharArray());
                    username = str_split[0];
                    password = str_split[1];
                    jobCode = str_split[2];
                }

                catch {
                    userBox.Text = "";
                    return;
                }


                clearFields();

                // If's account for users with 1 or 2 leading 0's in Username or in Password
                if (username.Length == 6)
                {
                    username = "0" + username;
                }

                if (username == "22679" || username == "57606" || username == "22377")
                {
                    username = "00" + username;
                }

                if (username == "1986934")
                {

                    password = "0" + password;

                }

                if (password.Length < 4)
                {

                    if (password.Length < 3)
                    {

                        password = "00" + password;

                    }

                    else
                    {
                        password = "0" + password;
                    }

                }

                parsedPassword = Regex.Replace(password, "[+^%~()]", "{$0}");

                check = str_split[3];

                // Empties box and starts INDA
                try
                {
                    INDAstart();
                }
                catch (Exception ex)
                {
                    errorLog(ex, username);
                    //generalErrorMessage();
                }

            }
            else {

                userBox.Text = "";
                idleCount = 0;
            }

        }

        // Opens INDA program, and uses Check variable to determine which clock function is performed
        private void INDAstart()
        {
            bool foundFile = false;
            idleCount = 0;

            try
            {

                if (File.Exists("R:\\abl\\runtime\\bin\\INDA.exe"))
                {
                    Process.Start("R:\\abl\\runtime\\bin\\INDA.exe");
                    foundFile = true;
                }
                else if (File.Exists(indaProgram))
                {
                    Process.Start(indaProgram);
                    foundFile = true;
                }
                else
                {
                    foundFile = false;
                }


            }
            catch (Exception ex)
            {
                errorLog(ex, username);
                //generalErrorMessage();
                return;
            }

            Thread.Sleep(2500);

            if (foundFile == true)
            {

                try
                {
                    indaLogin();
                }

                catch (Exception ex)
                {
                    errorLog(ex, username);
                    //generalErrorMessage();
                    return;
                }
            }
            else {
                return;
            }


        }


       

        // Variables sent in to log into INDA
        private void indaLogin()
        {

            idleCount = 0;
            bool flagCheck = false;

            try
            {
                // Set several Form elements of the INDA Username and Password Form
                loginFormElement = automation.setParentElement("Welcome To Indirect Activity (INDA)");
                usernameElement = automation.setChildElementId(loginFormElement, "3", true);
                okButton = automation.setChildElementId(loginFormElement, "7", true);
                cancelButton = automation.setChildElementId(loginFormElement, "6", true);
                cancelButton = automation.setChildElementId(loginFormElement, "6", true);
                automation.setValue(usernameElement, username);
                automation.invokeButtonPress(okButton);
            }

            catch (Exception ex)
            {

                errorLog(ex, username);
                //generalErrorMessage();
                return;
            }

            Thread.Sleep(1000);

            if (loginFormElement == null)
            {
                //generalErrorMessage();
                indaExitFocus();
                return;
            }

            // Loops looking to see if the Password textbox is enabled. If never enabled assumes a Username error has happened and closes the loop.
            // Example, if user enters a username not found in INDA that will prevent Password box from showing up. 
            try
            {

                int passwordCheck = 0;

                do
                {
                    Thread.Sleep(500);
                    passwordElement = automation.setChildElementId(loginFormElement, "1", false);
                    flagCheck = automation.enabledCheck(passwordElement);
                    passwordCheck++;
                } while (flagCheck == false && passwordCheck < 2); // Waits up to 2 seconds to see the Password Element. 
            }

            catch (Exception ex)
            {
                errorLog(ex, username);
                //generalErrorMessage();
                return;
            }

            // If the flagCheck is true, that means the Password box is enabled. Password entry proceeds and function is called depending on check character.
            if (flagCheck == true)
            {

                try
                {

                    automation.setValue(passwordElement, password);
                    automation.invokeButtonPress(okButton);

                }

                catch (Exception ex)
                {
                    errorLog(ex, username);
                    //generalErrorMessage();
                    indaExitFocus();
                    return;
                }

                Thread.Sleep(500);


                // Searches for the Work Form Element to move forward with the loop. Otherwise closes out and resets.
                workScreenFormElement = automation.setParentElementWithTime("Indirect Activity Selection | ");

                if (workScreenFormElement != null)
                {
                    indaClockin();
                }
                else {
                    indaExitFocus();
                }

            }

            else
            {
                //generalErrorMessage();
                indaExitFocus();
                return;
            }

        }

        // INDA Clock In
        private void indaClockin()
        {

            bool clockCheck = false;
            try
            {
                // Sets the 3 main elements needed to clock in. 
                workScreenInForDay = automation.setChildElementName(workScreenFormElement, "IN-FOR-DAY", false);
                workScreenStartButton = automation.setChildElementId(workScreenFormElement, "17", true);
                clockCheck = automation.enabledCheck(workScreenInForDay);
            }
            catch (Exception ex)
            {
                errorLog(ex, username);
                //generalErrorMessage();
                indaExitFocus();
            }

            if (workScreenFormElement == null)
            {
                //generalErrorMessage();
                indaExitFocus();
            }
            else
            {
                

                if( clockCheck == false) {
                    clockInErrorMessage();
                    workScreenFormElement = null;
                    loginFormElement = null;
                    loginFormCloseElement = null;
                    username = "";
                    password = "";
                    jobCode = "";
                    parsedPassword = "";
                    check = "";
                    clearFields();
                }

                else {

                    try
                    {
                        Thread.Sleep(500);
                        automation.selectRadioButton(workScreenInForDay);
                        automation.invokeButtonPress(workScreenStartButton);
                        Thread.Sleep(500);
                        indaExitFocus();
                    }
                    catch (ElementNotEnabledException ex)
                    {
                        errorLog(ex, username);
                        //clockInErrorMessage();
                        indaExitFocus();
                    }
                    catch (Exception ex)
                    {
                        errorLog(ex, username);
                        //generalErrorMessage();
                        indaExitFocus();
                    }

                }

  


            }

        }


        // After the loop finishes this makes sure the userBox field is reselected for subsequent users
        private void indaExitFocus()
        {

            username = "";
            password = "";
            jobCode = "";
            parsedPassword = "";
            check = "";
            clearFields();
            Thread.Sleep(1000);
            killINDA();
        }

        // Empties the userBox text box for next user.
        private void clearFields()
        {
            userBox.Text = "";
            manualUsername.Text = "";
            manualPassword.Text = "";
        }

        public void killINDA()
        {
            try
            {

                

                /*
                foreach (Process proc in Process.GetProcessesByName("INDA"))
                {
                    proc.Kill();
                }
                */
                if (workScreenFormElement != null) {

                    automation.closeElement(workScreenFormElement);
                    loginFormCloseElement = automation.setParentElement("Welcome To Indirect Activity (INDA)");
                    Thread.Sleep(500);
                }


                if (loginFormCloseElement != null)
                {
                    
                    cancelButtonClose = automation.setChildElementId(loginFormCloseElement, "6", true);
                    automation.invokeButtonPress(cancelButtonClose);
                    Thread.Sleep(500);
                }

                if (loginFormElement != null)
                {

                    cancelButton = automation.setChildElementId(loginFormElement, "6", true);
                    automation.invokeButtonPress(cancelButton);
                    Thread.Sleep(500);
                }

            }

            catch (Exception ex)
            {
                errorLog(ex, username);
                //MessageBox.Show(ex.Message);
            }

            clearFields();
            workScreenFormElement = null;
            loginFormElement = null;
            loginFormCloseElement = null;
            userBox.Focus();
            this.BringToFront();
        }

        public bool ControlIsVisible
        {
            get
            {
                return manualINDA.Visible;
            }
            set
            {
                manualINDA.Visible = value;
            }
        }

        public void hideButton()
        {
            manualINDA.Visible = false;
        }

        public void showButton()
        {
            manualINDA.Visible = true;
        }

        // Button and click events
        private void pictureBox2_Click(object sender, EventArgs e)
        {
            killINDA();
            this.Close();
        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {
            killINDA();
            this.Close();
        }

        private void manualINDA_Click(object sender, EventArgs e)
        {
            delayCount = 0;
            idleCount = 0;
            INDAstart();
        }

        private void manualPunchButton_Click(object sender, EventArgs e)
        {
            username = manualUsername.Text;
            password = manualPassword.Text;
            parsedPassword = Regex.Replace(password, "[+^%~()]", "{$0}");
            check = "~";
            clearFields();

            if (username != "" && password != "")
            {
                INDAstart();
            }

            else
            {
                MessageBox.Show("Please Enter a Username and Password.");
            }

        }

        private void manualPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                username = manualUsername.Text;
                password = manualPassword.Text;
                parsedPassword = Regex.Replace(password, "[+^%~()]", "{$0}");
                check = "~";
                clearFields();

                if (username != "" && password != "")
                {
                    INDAstart();
                }

                else
                {
                    MessageBox.Show("Please Enter a Username and Password.");
                }
            }
        }

        private void unlockButton_Click(object sender, EventArgs e)
        {
            if (unlockBox.Text == "COVID19")
            {
                if (manualINDA.Visible == true)
                {
                    hideButton();
                }
                else
                {
                    showButton();
                }
            }
            else
            {
                MessageBox.Show("Incorrect Password");
            }
        }

        private void unlockBox_KeyDown_1(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                if (unlockBox.Text == "COVID19")
                {
                    if (manualINDA.Visible == true)
                    {
                        hideButton();
                    }
                    else
                    {
                        showButton();
                    }
                }

                else
                {
                    MessageBox.Show("Incorrect Password, Please Try Again");
                }
            }
        }

        private void mainPanelBox_DoubleClick(object sender, EventArgs e)
        {
            if (this.WindowState == FormWindowState.Maximized)
            {
                this.WindowState = FormWindowState.Normal;
            }
            else this.WindowState = FormWindowState.Maximized;
        }

        private void clockOutErrorMessage()
        {
            MessageBox.Show("ALREADY CLOCKED OUT. PLEASE CLOCK IN THEN BACK OUT.", "ALREADY CLOCKED OUT ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void clockInErrorMessage()
        {
            MessageBox.Show("ALREADY CLOCKED IN. PLEASE CLOCK OUT THEN BACK IN.", "ALREADY CLOCKED IN ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void generalErrorMessage()
        {
            MessageBox.Show("CLOCK ERROR, PLEASE TRY AGAIN.", "CLOCK ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        private void jobCodeErrorMessage()
        {
            MessageBox.Show("JOB CODE ERROR, PLEASE TRY AGAIN.", "CLOCK ERROR", MessageBoxButtons.OK, MessageBoxIcon.Warning, MessageBoxDefaultButton.Button1, MessageBoxOptions.DefaultDesktopOnly);
        }

        // Writes error log to both local and server location.
        private void errorLog(Exception ex, string user)
        {
            try
            {
                string serverFile = "";

                string today = DateTime.Today.ToString("MM'_'dd'_'yyyy");
                string todayLog = "ErrorLog" + today + ".txt";
                serverFile = serverPath + todayLog;

                // Checks to see if either the X:\ or Server Paths are available to find log file folders

                if (Directory.Exists(serverPath))
                {
                    using (StreamWriter writer = new StreamWriter(serverFile, true))
                    {
                        writer.WriteLine("-----------------------------------------------------------------------------");
                        writer.WriteLine("Date : " + DateTime.Now.ToString());
                        writer.WriteLine("User : " + user);
                        writer.WriteLine("Hostname : " + computerName);
                        writer.WriteLine();

                        while (ex != null)
                        {
                            writer.WriteLine(ex.GetType().FullName);
                            writer.WriteLine("Message : " + ex.Message);
                            writer.WriteLine("StackTrace : " + ex.StackTrace);

                            ex = ex.InnerException;
                        }

                    }
                }
            }

            catch (Exception ex2)
            { 
            
            
            }

           
        }

        // Opens logs with button click. Writes a new file if there is none for the day.
        private void logButton_Click_1(object sender, EventArgs e)
        {

            try
            {
                string today = DateTime.Today.ToString("MM'-'dd'-'yyyy");
                string todayLog = "ErrorLog" + today + ".txt";
                string serverFile = serverPath + todayLog;

                if (Directory.Exists(serverPath) || Directory.Exists(localPath))
                {

                    if (File.Exists(serverFile))
                    {
                        Process.Start(serverFile);
                    }
                    else
                    {

                        using (StreamWriter writer = new StreamWriter(serverFile, true))
                        {
                            writer.WriteLine("-----------------------------------------------------------------------------");
                            writer.WriteLine("Date : " + DateTime.Now.ToString());
                            writer.WriteLine("User : " + username);
                            writer.WriteLine("Hostname : " + computerName);
                            writer.WriteLine();
                        }

                        Process.Start(serverFile);

                    }
                }
            }

            catch (Exception ex2){ 
            
            
            }

            

        }

        // Allows moving the application around by holding mouse button.
        private const int WM_NCHITTEST = 0x84;
        private const int HT_CLIENT = 0x1;
        private const int HT_CAPTION = 0x2;
        protected override void WndProc(ref Message m)
        {
            base.WndProc(ref m);
            if (m.Msg == WM_NCHITTEST) m.Result = (IntPtr)(HT_CAPTION);
        }

        // Prepared mouse event to move to the Userbox and click. Resets Cursor position and idle timers.
        [System.Runtime.InteropServices.DllImport("user32.dll")]
        static extern bool SetCursorPos(int x, int y);

        [System.Runtime.InteropServices.DllImport("user32.dll")]
        public static extern void mouse_event(int dwFlags, int dx, int dy, int cButtons, int dwExtraInfo);

        public const int MOUSEEVENTF_LEFTDOWN = 0x02;
        public const int MOUSEEVENTF_LEFTUP = 0x04;

    }
}