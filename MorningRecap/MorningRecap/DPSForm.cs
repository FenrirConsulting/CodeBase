using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.IO;
using System.Data.SqlServerCe;
using System.Windows.Forms;

namespace MorningRecap
{
    public partial class DPSForm : Form
    {
        public DBConnection DBConn = new DBConnection();

        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();
        List<String> columnData = new List<String>();


        string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        string file = "";
        
        public DPSForm()
        {
            InitializeComponent();
            file = folder + "\\DPS.csv";

            DBConn.ConnectToDatabase();
            DBConn.buildNameList(list1, "DPSTable");
            DBConn.buildValueList(list2, "DPSTable");
            DBConn.Disconnect();





            TextBox[] tbx = new TextBox[] { todayBox,  textBox2, textBox3, textBox4, textBox5,
                                            textBox6,  textBox7, textBox8, textBox9, textBox10, 
                                            textBox11, textBox12, textBox13, textBox14};

            for (int i = 0; i < tbx.Length; i++)
            {

                tbx[i].Text = list2[i+1];

            }


        }



        private void closeButton_Click(object sender, EventArgs e)
        {
            DBConn.Disconnect();
            this.Close();
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TextBox[] tbx = new TextBox[] { todayBox, textBox2, textBox3, textBox4, textBox5,
                                            textBox6,  textBox7, textBox8, textBox9, textBox10, 
                                            textBox11, textBox12, textBox13, textBox14};

            for (int i = 0; i < tbx.Length; i++)
            {

                list2[i+1] = tbx[i].Text;

            }

            var result = list1.Zip(list2, (x, y) => x + "," + y);

            File.WriteAllLines(file, result);
            MessageBox.Show("File Saved");

            DBConn.ConnectToDatabase();

            for (int i = 0; i < (list2.Count-1); i++)
            {

                int idCount = i + 2;
                string id = idCount.ToString();
                string value = list2[i+1];

                DBConn.tableValueUpdate(id, value, "DPSTable");
            }

            DBConn.Disconnect();
        }




        private void rxTitle_Click(object sender, EventArgs e)
        {

        }

        private void bodyPanel_Paint(object sender, PaintEventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int availValue = Int32.Parse(textBox4.Text);
                int firstValue = Int32.Parse(textBox6.Text);
                int secondValue = Int32.Parse(textBox8.Text);
                int calculatedCarryValue = availValue - (firstValue + secondValue);
                int projectedValue = Int32.Parse(textBox11.Text);
                int ttlValue = calculatedCarryValue + projectedValue;
                carryBox.Text = calculatedCarryValue.ToString();
                ttlBox.Text = ttlValue.ToString();

            }
            catch (FormatException d)

            {
            }
        }


        private void textBox6_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int availValue = Int32.Parse(textBox4.Text);
                int firstValue = Int32.Parse(textBox6.Text);
                int secondValue = Int32.Parse(textBox8.Text);
                int calculatedCarryValue = availValue - (firstValue + secondValue);
                int projectedValue = Int32.Parse(textBox11.Text);
                int ttlValue = calculatedCarryValue + projectedValue;
                carryBox.Text = calculatedCarryValue.ToString();
                ttlBox.Text = ttlValue.ToString();

            }
            catch (FormatException d)
            {

            }

        }



        private void textBox8_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int availValue = Int32.Parse(textBox4.Text);
                int firstValue = Int32.Parse(textBox6.Text);
                int secondValue = Int32.Parse(textBox8.Text);
                int calculatedCarryValue = availValue - (firstValue + secondValue);
                int projectedValue = Int32.Parse(textBox11.Text);
                int ttlValue = calculatedCarryValue + projectedValue;
                carryBox.Text = calculatedCarryValue.ToString();
                ttlBox.Text = ttlValue.ToString();

            }
            catch (FormatException d)
            {

            }
        }



        private void textBox11_TextChanged(object sender, EventArgs e)
        {
            try
            {
                int availValue = Int32.Parse(textBox4.Text);
                int firstValue = Int32.Parse(textBox6.Text);
                int secondValue = Int32.Parse(textBox8.Text);
                int calculatedCarryValue = availValue - (firstValue + secondValue);
                int projectedValue = Int32.Parse(textBox11.Text);
                int ttlValue = calculatedCarryValue + projectedValue;
                carryBox.Text = calculatedCarryValue.ToString();
                ttlBox.Text = ttlValue.ToString();

            }
            catch (FormatException d)
            {

            }
        }

        private void carryBox_TextChanged(object sender, EventArgs e)
        {
            int availValue = Int32.Parse(textBox4.Text);
            int firstValue = Int32.Parse(textBox6.Text);
            int secondValue = Int32.Parse(textBox8.Text);
            int calculatedCarryValue = availValue - (firstValue + secondValue);
            int projectedValue = Int32.Parse(textBox11.Text);
            int ttlValue = calculatedCarryValue + projectedValue;
            carryBox.Text = calculatedCarryValue.ToString();
            ttlBox.Text = ttlValue.ToString();
        }

        private void ttlBox_TextChanged(object sender, EventArgs e)
        {
            int availValue = Int32.Parse(textBox4.Text);
            int firstValue = Int32.Parse(textBox6.Text);
            int secondValue = Int32.Parse(textBox8.Text);
            int calculatedCarryValue = availValue - (firstValue + secondValue);
            int projectedValue = Int32.Parse(textBox11.Text);
            int ttlValue = calculatedCarryValue + projectedValue;
            carryBox.Text = calculatedCarryValue.ToString();
            ttlBox.Text = ttlValue.ToString();
        }

        private void calcButton_Click(object sender, EventArgs e)
        {

        }

        private void tomorrowLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void staffingLabel_Click(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {

        }




    }
}
