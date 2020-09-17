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
    public partial class CPSForm : Form
    {
        public DBConnection DBConn = new DBConnection();

        List<string> list1 = new List<string>();
        List<string> list2 = new List<string>();

        List<String> columnData = new List<String>();

        string folder = Path.GetDirectoryName(Process.GetCurrentProcess().MainModule.FileName);
        string file = "";

        public CPSForm()
        {
            InitializeComponent();
            file = folder + "\\CPS.csv";

            DBConn.ConnectToDatabase();
            DBConn.buildNameList(list1, "CPSTable");
            DBConn.buildValueList(list2, "CPSTable");
            DBConn.Disconnect();


            TextBox[] tbx = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5,
                                            textBox6, textBox7, textBox8, textBox9, textBox10, textBox11,
                                            textBox12};

            for (int i = 0; i < tbx.Length; i++)
            {

                tbx[i].Text = list2[i+1];

            }
        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            TextBox[] tbx = new TextBox[] { textBox1, textBox2, textBox3, textBox4, textBox5,
                                            textBox6, textBox7, textBox8, textBox9, textBox10, textBox11,
                                            textBox12};

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

                DBConn.tableValueUpdate(id, value, "CPSTable");
            }
            DBConn.Disconnect();

        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            DBConn.Disconnect();
            this.Close();
        }

 

       
    }
}
