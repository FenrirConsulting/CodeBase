using System;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace UpdateForm
{
    public partial class boardForm : Form
    {

        const string FileName = "testfile.txt";
        const string SourcePath = @"C:\UpdateForm\TestFolder";
        const string TargetPath = @"C:\UpdateForm\TestFolder\SubDir";
        string sourceFile = Path.Combine(SourcePath, FileName);
        string destFile = Path.Combine(TargetPath, FileName);
        string filename = "";


        public boardForm()
        {
            InitializeComponent();
            closeButton.Click += new EventHandler(closeButton_Click);
        }


        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }


        private void copyButton_Click(object sender, EventArgs e)
        {
            System.IO.Directory.CreateDirectory(TargetPath);

            if (System.IO.Directory.Exists(SourcePath))
            {

                string[] files = System.IO.Directory.GetFiles(SourcePath);
                foreach (string s in files)
                {

                    filename = Path.GetFileName(s);
                    destFile = Path.Combine(TargetPath, filename);
                    File.Copy(s, destFile, true);

                }

                MessageBox.Show("Copy Succesful");

            }
            else
            {
                MessageBox.Show("No File Found.");
            }
        }


        private void launchButton_Click(object sender, EventArgs e)
        {

            if (File.Exists("C:\\PerfBoards\\bin\\perfboards.exe"))
            {
                Process.Start("C:\\PerfBoards\\bin\\perfboards.exe");
            }
            else {
                Process.Start("\\\\rfl6dpspw2c\\CVS-CLIENT-RT\\ISShare\\Applications\\PerfBoards\\bin\\perfboards.exe");
            }
            
        }


    }
}
