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
    public partial class AddForm : Form
    {
        private sqlLiteMethods DBConn = new sqlLiteMethods();
        private DateTimePicker oDateTimePicker = new DateTimePicker();
        private DataTable TECHLOGTable = new DataTable();
        private DataTable TECHLOGUserTable = new DataTable();
        private DataTable TECHLOGPartsTable = new DataTable();
        private DataTable TECHLOGInventoryTable = new DataTable();
        private int creatingRecord;
        private string formmatedTime;

        private GlobalUser globalUser;

        public AddForm(GlobalUser passedUser)
        {
            InitializeComponent();
            globalUser = passedUser;
            buildTables();
        }

        private void buildTables()
        {
            creatingRecord = DBConn.primaryKeyHighestValue("TECHLOG", "tl_ref") + 1;
            string message = globalUser.globalUsername + " is creating Record #" + creatingRecord.ToString();
            creatingRecordLabel.Text = message;

            DataTable UserlistTable = DBConn.getTable("TECHLOG_TECHS");
            List<String> userList = UserlistTable.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlt_name")).ToList();
            addUserBox.DataSource = userList;

            stateComboBox.Text = "Started";
            typeComboBox.Text = "Unplanned";
            assetTextBox.Text = "Enter Asset";
            complaintTextBox.Text = "";
            causeTextBox.Text = "";
            correctionTextBox.Text = "";

            addShiftBox.Text = "1";
            addTimeTextBox.Text = "10";
            DateTime dateBox = DateTime.Now;
            formmatedTime = dateBox.ToString("MM/dd/yyyy");
            addUserDateTime.Text = "";

            addUserDateTime.CustomFormat = "MM-dd-yyyy";
            addUserDateTime.Format = DateTimePickerFormat.Custom;
            DateTime currentTime = DateTime.Now;
            formmatedTime = currentTime.ToString("MM/dd/yyyy HH:mm:ss");
            creatingLabel.Text = "Creating record at : " + formmatedTime;
            addUserBox.Text = globalUser.globalUsername;
            addUserBox.Enabled = false;
            if (globalUser.globalLead == "True" || globalUser.globalPartsLead == "True" || globalUser.globalAdmin == "True")
            {
                addUserBox.Enabled = true;
            }

            TECHLOGInventoryTable = DBConn.getTable("TECHLOG_PARTSINVENTORY");
            List<String> partsList = TECHLOGInventoryTable.Rows.OfType<DataRow>()
                .Select(dr => dr.Field<string>("tlinv_partnumber")).ToList();
            partsList.Insert(0, "Unlisted");
            partsList.Insert(0, "");
            addPartNumberBox.DataSource = partsList;
            addPartNumberBox.DropDownStyle = ComboBoxStyle.DropDown;
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

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.bodyPanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void titlePanel_Paint(object sender, PaintEventArgs e)
        {
            ControlPaint.DrawBorder(e.Graphics, this.titlePanel.ClientRectangle, Color.Black, ButtonBorderStyle.Outset);
        }

        private void titlePanel_MouseMove(object sender, MouseEventArgs e)
        {
            if (e.Button == MouseButtons.Left)
            {
                ReleaseCapture();
                SendMessage(Handle, WM_NCLBUTTONDOWN, HT_CAPTION, 0);
            }
        }

        private void cancelButton_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void addTimeTextBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(addTimeTextBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                addTimeTextBox.Text = addTimeTextBox.Text.Remove(addTimeTextBox.Text.Length - 1);
            }
        }

        private void addQuantityBox_TextChanged(object sender, EventArgs e)
        {
            if (System.Text.RegularExpressions.Regex.IsMatch(addQuantityBox.Text, "[^0-9]"))
            {
                MessageBox.Show("Please enter only numbers.");
                addQuantityBox.Text = addQuantityBox.Text.Remove(addQuantityBox.Text.Length - 1);
            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (stateComboBox.Text == "" || typeComboBox.Text == "" || assetTextBox.Text == "" || addShiftBox.Text == "" || addTimeTextBox.Text == "" || addUserBox.Text == "" ||
                complaintTextBox.Text == "" || causeTextBox.Text == "" || correctionTextBox.Text == "" || addUserDateTime.Text == "")
            {
                MessageBox.Show("Please finish filling out all required fields for Record and Tech details.");
            }
            else
            {
                if (addQuantityBox.Text != "" || addPartNumberBox.Text != "" || addDescriptionBox.Text != "" || addLocationBox.Text != "")
                {
                    if (addQuantityBox.Text == "" || addPartNumberBox.Text == "" || addDescriptionBox.Text == "" || addLocationBox.Text == "")
                    {
                        MessageBox.Show("Please finish filling out all required fields for Parts details.");
                    }
                    else
                    {
                        DialogResult dr2 = MessageBox.Show("Create this Record?",
                        "Confirm Create Record", MessageBoxButtons.YesNo);

                        switch (dr2)
                        {
                            case DialogResult.Yes:
                                createRecord();
                                createPartsRecord();
                                MessageBox.Show("Added Record Succesfully.");
                                Close();
                                break;

                            case DialogResult.No:
                                break;
                        }
                    }
                }
                else
                {
                    DialogResult dr = MessageBox.Show("Create this Record?",
                        "Confirm Create Record", MessageBoxButtons.YesNo);

                    switch (dr)
                    {
                        case DialogResult.Yes:
                            createRecord();

                            MessageBox.Show("Added Record Succesfully.");
                            Close();
                            break;

                        case DialogResult.No:
                            break;
                    }
                }
            }
        }

        private void createRecord()
        {
            int tlu_ref = DBConn.primaryKeyHighestValue("TECHLOG_USER", "tlu_ref") + 1;
            int tl_ref = creatingRecord;

            string tlu_shift = addShiftBox.Text;
            string tlu_time = addTimeTextBox.Text;
            string tlu_date = addUserDateTime.Text;
            string tlu_name = addUserBox.Text;

            string tl_state = stateComboBox.Text;
            string tl_wotype = typeComboBox.Text;
            string tl_woasset = assetTextBox.Text;
            string tl_wocomplaint = complaintTextBox.Text;
            string tl_worootcause = causeTextBox.Text;
            string tl_wocorrection = correctionTextBox.Text;
            string tl_genuser = globalUser.globalUsername;
            string tl_gendate = formmatedTime;
            string tl_moduser = globalUser.globalUsername;
            string tl_moddate = formmatedTime;
            string tl_partsconfirmed = "No";

            DBConn.addTechlogRecord(tl_ref, tl_state, tl_wotype, tl_woasset, tl_wocomplaint, tl_worootcause, tl_wocorrection, tl_genuser, tl_gendate, tl_moduser, tl_moddate);
            DBConn.addTechlogUserRecord(tlu_ref, tl_ref, tlu_shift, tlu_time, tlu_date, tlu_name);
            DBConn.confirmPartsRecord(tl_ref, tl_partsconfirmed);
        }

        private void createPartsRecord()
        {
            int tl_ref = creatingRecord;
            int tlp_ref = DBConn.primaryKeyHighestValue("TECHLOG_PARTS", "tlp_ref") + 1;
            int tlp_qnty = Int32.Parse(addQuantityBox.Text);
            string tlp_partnumber = addPartNumberBox.Text;
            string tlp_location = addLocationBox.Text;
            string tlp_description = addDescriptionBox.Text;

            DBConn.addTechlogPartsRecord(tlp_ref, tl_ref, tlp_qnty, tlp_partnumber, tlp_location, tlp_description);
        }

        private void addPartNumberBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            string tempLocation = "Unassigned";
            string tempDescription = "No Description";

            foreach (DataRow row in TECHLOGInventoryTable.Rows)
            {
                if (addPartNumberBox.Text == row["tlinv_partnumber"].ToString())
                {
                    tempLocation = row["tlloc_locid"].ToString();
                    tempDescription = row["tlinv_desc"].ToString();

                    addLocationBox.Text = tempLocation;
                    addDescriptionBox.Text = tempDescription;
                }

                if (addPartNumberBox.Text == "Unlisted")
                {
                    addLocationBox.Text = "Unassigned";
                    addDescriptionBox.Text = "No Description";
                }
            }
        }
    }
}