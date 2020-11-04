namespace HandsFreeInda
{
    partial class MainForm
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.userBox = new System.Windows.Forms.TextBox();
            this.scanLabel = new System.Windows.Forms.Label();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.manualINDA = new System.Windows.Forms.Button();
            this.hiddenLabel = new System.Windows.Forms.Label();
            this.unlockBox = new System.Windows.Forms.TextBox();
            this.unlockLabel = new System.Windows.Forms.Label();
            this.unlockButton = new System.Windows.Forms.Button();
            this.rightBorder = new System.Windows.Forms.Panel();
            this.leftBorder = new System.Windows.Forms.Panel();
            this.topBorder = new System.Windows.Forms.Panel();
            this.bottomBorder = new System.Windows.Forms.Panel();
            this.manualUsername = new System.Windows.Forms.TextBox();
            this.manualPassword = new System.Windows.Forms.TextBox();
            this.manualLabel = new System.Windows.Forms.Label();
            this.manualUsernameLabel = new System.Windows.Forms.Label();
            this.manualPasswordLabel = new System.Windows.Forms.Label();
            this.manualPunchButton = new System.Windows.Forms.Button();
            this.logButton = new System.Windows.Forms.Button();
            this.instructionLabelThree = new System.Windows.Forms.Label();
            this.instructionLabelTwo = new System.Windows.Forms.Label();
            this.instructionLabelOne = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.clockLabel = new System.Windows.Forms.Label();
            this.mainPanelBox = new System.Windows.Forms.Panel();
            this.mapDrivesBUtton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.mainPanelBox.SuspendLayout();
            this.SuspendLayout();
            // 
            // userBox
            // 
            this.userBox.Location = new System.Drawing.Point(188, 177);
            this.userBox.Name = "userBox";
            this.userBox.PasswordChar = '*';
            this.userBox.Size = new System.Drawing.Size(188, 20);
            this.userBox.TabIndex = 1;
            this.userBox.KeyUp += new System.Windows.Forms.KeyEventHandler(this.userBox_TextChanged);
            // 
            // scanLabel
            // 
            this.scanLabel.AutoSize = true;
            this.scanLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.scanLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.scanLabel.Location = new System.Drawing.Point(156, 151);
            this.scanLabel.Name = "scanLabel";
            this.scanLabel.Size = new System.Drawing.Size(241, 23);
            this.scanLabel.TabIndex = 5;
            this.scanLabel.Text = "Please Scan Badge to Clock In";
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::HandsFreeInda.Properties.Resources.greyBackLogo;
            this.pictureBox2.Location = new System.Drawing.Point(160, 23);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(238, 115);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 7;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.pictureBox1.Image = global::HandsFreeInda.Properties.Resources.exit;
            this.pictureBox1.Location = new System.Drawing.Point(886, 14);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(33, 33);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // manualINDA
            // 
            this.manualINDA.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.manualINDA.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualINDA.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.manualINDA.Location = new System.Drawing.Point(412, 425);
            this.manualINDA.Name = "manualINDA";
            this.manualINDA.Size = new System.Drawing.Size(89, 32);
            this.manualINDA.TabIndex = 7;
            this.manualINDA.Text = "Manual INDA";
            this.manualINDA.UseVisualStyleBackColor = false;
            this.manualINDA.Click += new System.EventHandler(this.manualINDA_Click);
            // 
            // hiddenLabel
            // 
            this.hiddenLabel.AutoSize = true;
            this.hiddenLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.hiddenLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.hiddenLabel.Location = new System.Drawing.Point(834, 420);
            this.hiddenLabel.Name = "hiddenLabel";
            this.hiddenLabel.Size = new System.Drawing.Size(0, 24);
            this.hiddenLabel.TabIndex = 9;
            // 
            // unlockBox
            // 
            this.unlockBox.Location = new System.Drawing.Point(182, 425);
            this.unlockBox.Name = "unlockBox";
            this.unlockBox.PasswordChar = '*';
            this.unlockBox.Size = new System.Drawing.Size(124, 20);
            this.unlockBox.TabIndex = 5;
            this.unlockBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.unlockBox_KeyDown_1);
            // 
            // unlockLabel
            // 
            this.unlockLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.unlockLabel.Location = new System.Drawing.Point(52, 421);
            this.unlockLabel.Name = "unlockLabel";
            this.unlockLabel.Size = new System.Drawing.Size(114, 27);
            this.unlockLabel.TabIndex = 11;
            this.unlockLabel.Text = "Unlock INDA";
            // 
            // unlockButton
            // 
            this.unlockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.unlockButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.unlockButton.Location = new System.Drawing.Point(312, 425);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(89, 32);
            this.unlockButton.TabIndex = 6;
            this.unlockButton.Text = "Unlock/Lock";
            this.unlockButton.UseVisualStyleBackColor = false;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // rightBorder
            // 
            this.rightBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.rightBorder.Dock = System.Windows.Forms.DockStyle.Right;
            this.rightBorder.Location = new System.Drawing.Point(953, 0);
            this.rightBorder.Name = "rightBorder";
            this.rightBorder.Size = new System.Drawing.Size(4, 505);
            this.rightBorder.TabIndex = 13;
            // 
            // leftBorder
            // 
            this.leftBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.leftBorder.Dock = System.Windows.Forms.DockStyle.Left;
            this.leftBorder.Location = new System.Drawing.Point(0, 0);
            this.leftBorder.Name = "leftBorder";
            this.leftBorder.Size = new System.Drawing.Size(4, 505);
            this.leftBorder.TabIndex = 14;
            // 
            // topBorder
            // 
            this.topBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.topBorder.Dock = System.Windows.Forms.DockStyle.Top;
            this.topBorder.Location = new System.Drawing.Point(4, 0);
            this.topBorder.Name = "topBorder";
            this.topBorder.Size = new System.Drawing.Size(949, 4);
            this.topBorder.TabIndex = 15;
            // 
            // bottomBorder
            // 
            this.bottomBorder.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.bottomBorder.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.bottomBorder.Location = new System.Drawing.Point(4, 501);
            this.bottomBorder.Name = "bottomBorder";
            this.bottomBorder.Size = new System.Drawing.Size(949, 4);
            this.bottomBorder.TabIndex = 16;
            // 
            // manualUsername
            // 
            this.manualUsername.Location = new System.Drawing.Point(182, 291);
            this.manualUsername.Name = "manualUsername";
            this.manualUsername.PasswordChar = '*';
            this.manualUsername.Size = new System.Drawing.Size(188, 20);
            this.manualUsername.TabIndex = 2;
            // 
            // manualPassword
            // 
            this.manualPassword.Location = new System.Drawing.Point(182, 329);
            this.manualPassword.Name = "manualPassword";
            this.manualPassword.PasswordChar = '*';
            this.manualPassword.Size = new System.Drawing.Size(188, 20);
            this.manualPassword.TabIndex = 3;
            this.manualPassword.KeyDown += new System.Windows.Forms.KeyEventHandler(this.manualPassword_KeyDown);
            // 
            // manualLabel
            // 
            this.manualLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.manualLabel.Location = new System.Drawing.Point(205, 261);
            this.manualLabel.Name = "manualLabel";
            this.manualLabel.Size = new System.Drawing.Size(143, 27);
            this.manualLabel.TabIndex = 19;
            this.manualLabel.Text = "Manual Punch In";
            // 
            // manualUsernameLabel
            // 
            this.manualUsernameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualUsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.manualUsernameLabel.Location = new System.Drawing.Point(54, 288);
            this.manualUsernameLabel.Name = "manualUsernameLabel";
            this.manualUsernameLabel.Size = new System.Drawing.Size(112, 26);
            this.manualUsernameLabel.TabIndex = 20;
            this.manualUsernameLabel.Text = "Username";
            // 
            // manualPasswordLabel
            // 
            this.manualPasswordLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.manualPasswordLabel.Location = new System.Drawing.Point(54, 323);
            this.manualPasswordLabel.Name = "manualPasswordLabel";
            this.manualPasswordLabel.Size = new System.Drawing.Size(112, 26);
            this.manualPasswordLabel.TabIndex = 21;
            this.manualPasswordLabel.Text = "Password";
            // 
            // manualPunchButton
            // 
            this.manualPunchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.manualPunchButton.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.manualPunchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.manualPunchButton.Location = new System.Drawing.Point(376, 317);
            this.manualPunchButton.Name = "manualPunchButton";
            this.manualPunchButton.Size = new System.Drawing.Size(127, 32);
            this.manualPunchButton.TabIndex = 4;
            this.manualPunchButton.Text = "Clock-In";
            this.manualPunchButton.UseVisualStyleBackColor = false;
            this.manualPunchButton.Click += new System.EventHandler(this.manualPunchButton_Click);
            // 
            // logButton
            // 
            this.logButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.logButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.logButton.Location = new System.Drawing.Point(456, 396);
            this.logButton.Name = "logButton";
            this.logButton.Size = new System.Drawing.Size(48, 23);
            this.logButton.TabIndex = 22;
            this.logButton.Text = "Log";
            this.logButton.UseVisualStyleBackColor = false;
            this.logButton.Click += new System.EventHandler(this.logButton_Click_1);
            // 
            // instructionLabelThree
            // 
            this.instructionLabelThree.AutoSize = true;
            this.instructionLabelThree.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabelThree.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.instructionLabelThree.Location = new System.Drawing.Point(514, 357);
            this.instructionLabelThree.Name = "instructionLabelThree";
            this.instructionLabelThree.Size = new System.Drawing.Size(282, 33);
            this.instructionLabelThree.TabIndex = 25;
            this.instructionLabelThree.Text = "3. Note Time Clocked-In";
            // 
            // instructionLabelTwo
            // 
            this.instructionLabelTwo.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabelTwo.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.instructionLabelTwo.Location = new System.Drawing.Point(514, 321);
            this.instructionLabelTwo.Name = "instructionLabelTwo";
            this.instructionLabelTwo.Size = new System.Drawing.Size(367, 33);
            this.instructionLabelTwo.TabIndex = 24;
            this.instructionLabelTwo.Text = "2. Do Not Touch Keys or Mouse";
            // 
            // instructionLabelOne
            // 
            this.instructionLabelOne.AutoSize = true;
            this.instructionLabelOne.Font = new System.Drawing.Font("Calibri", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionLabelOne.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.instructionLabelOne.Location = new System.Drawing.Point(514, 288);
            this.instructionLabelOne.Name = "instructionLabelOne";
            this.instructionLabelOne.Size = new System.Drawing.Size(168, 33);
            this.instructionLabelOne.TabIndex = 23;
            this.instructionLabelOne.Text = "1. Scan Badge";
            // 
            // dateLabel
            // 
            this.dateLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.dateLabel.Location = new System.Drawing.Point(521, 91);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(347, 50);
            this.dateLabel.TabIndex = 27;
            this.dateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // clockLabel
            // 
            this.clockLabel.Font = new System.Drawing.Font("Calibri", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.clockLabel.Location = new System.Drawing.Point(521, 187);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(347, 50);
            this.clockLabel.TabIndex = 26;
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // mainPanelBox
            // 
            this.mainPanelBox.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.mainPanelBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainPanelBox.Controls.Add(this.mapDrivesBUtton);
            this.mainPanelBox.Controls.Add(this.pictureBox2);
            this.mainPanelBox.Controls.Add(this.dateLabel);
            this.mainPanelBox.Controls.Add(this.manualINDA);
            this.mainPanelBox.Controls.Add(this.clockLabel);
            this.mainPanelBox.Controls.Add(this.pictureBox1);
            this.mainPanelBox.Controls.Add(this.hiddenLabel);
            this.mainPanelBox.Controls.Add(this.unlockButton);
            this.mainPanelBox.Controls.Add(this.userBox);
            this.mainPanelBox.Controls.Add(this.instructionLabelThree);
            this.mainPanelBox.Controls.Add(this.manualUsername);
            this.mainPanelBox.Controls.Add(this.unlockLabel);
            this.mainPanelBox.Controls.Add(this.instructionLabelTwo);
            this.mainPanelBox.Controls.Add(this.manualPassword);
            this.mainPanelBox.Controls.Add(this.scanLabel);
            this.mainPanelBox.Controls.Add(this.instructionLabelOne);
            this.mainPanelBox.Controls.Add(this.manualLabel);
            this.mainPanelBox.Controls.Add(this.unlockBox);
            this.mainPanelBox.Controls.Add(this.logButton);
            this.mainPanelBox.Controls.Add(this.manualUsernameLabel);
            this.mainPanelBox.Controls.Add(this.manualPasswordLabel);
            this.mainPanelBox.Controls.Add(this.manualPunchButton);
            this.mainPanelBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.mainPanelBox.Location = new System.Drawing.Point(12, 12);
            this.mainPanelBox.Name = "mainPanelBox";
            this.mainPanelBox.Size = new System.Drawing.Size(933, 480);
            this.mainPanelBox.TabIndex = 28;
            // 
            // mapDrivesBUtton
            // 
            this.mapDrivesBUtton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.mapDrivesBUtton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mapDrivesBUtton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.mapDrivesBUtton.Location = new System.Drawing.Point(788, 425);
            this.mapDrivesBUtton.Name = "mapDrivesBUtton";
            this.mapDrivesBUtton.Size = new System.Drawing.Size(140, 32);
            this.mapDrivesBUtton.TabIndex = 28;
            this.mapDrivesBUtton.Text = "Map Net Drives";
            this.mapDrivesBUtton.UseVisualStyleBackColor = false;
            this.mapDrivesBUtton.Click += new System.EventHandler(this.mapDrivesBUtton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.BackgroundImage = global::HandsFreeInda.Properties.Resources.Turkey;
            this.ClientSize = new System.Drawing.Size(957, 505);
            this.Controls.Add(this.mainPanelBox);
            this.Controls.Add(this.bottomBorder);
            this.Controls.Add(this.topBorder);
            this.Controls.Add(this.leftBorder);
            this.Controls.Add(this.rightBorder);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Inda Login";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.MainForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.mainPanelBox.ResumeLayout(false);
            this.mainPanelBox.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label scanLabel;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        public System.Windows.Forms.Button manualINDA;
        private System.Windows.Forms.Label hiddenLabel;
        private System.Windows.Forms.TextBox unlockBox;
        private System.Windows.Forms.Label unlockLabel;
        public System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.Panel rightBorder;
        private System.Windows.Forms.Panel leftBorder;
        private System.Windows.Forms.Panel topBorder;
        private System.Windows.Forms.Panel bottomBorder;
        private System.Windows.Forms.TextBox manualUsername;
        private System.Windows.Forms.TextBox manualPassword;
        private System.Windows.Forms.Label manualLabel;
        private System.Windows.Forms.Label manualUsernameLabel;
        private System.Windows.Forms.Label manualPasswordLabel;
        public System.Windows.Forms.Button manualPunchButton;
        public System.Windows.Forms.Button logButton;
        private System.Windows.Forms.Label instructionLabelThree;
        private System.Windows.Forms.Label instructionLabelTwo;
        private System.Windows.Forms.Label instructionLabelOne;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Panel mainPanelBox;
        public System.Windows.Forms.Button mapDrivesBUtton;
    }
}

