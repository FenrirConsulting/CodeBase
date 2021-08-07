namespace Startup
{
    partial class CredentialsForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CredentialsForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.okButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.repeatPasswordBox = new System.Windows.Forms.TextBox();
            this.repeatPassLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.instructionsLabel = new System.Windows.Forms.Label();
            this.resetPanel = new System.Windows.Forms.Panel();
            this.lbsCheck = new System.Windows.Forms.CheckBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.pictureBox8 = new System.Windows.Forms.PictureBox();
            this.pictureBox7 = new System.Windows.Forms.PictureBox();
            this.pictureBox6 = new System.Windows.Forms.PictureBox();
            this.pictureBox5 = new System.Windows.Forms.PictureBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.mfcdpsCheck = new System.Windows.Forms.CheckBox();
            this.pcoCheck = new System.Windows.Forms.CheckBox();
            this.avisCheck = new System.Windows.Forms.CheckBox();
            this.mfccpsCheck = new System.Windows.Forms.CheckBox();
            this.bmisCheck = new System.Windows.Forms.CheckBox();
            this.dserviceCheck = new System.Windows.Forms.CheckBox();
            this.cpsCheck = new System.Windows.Forms.CheckBox();
            this.cancelButton = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.resetPanel.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(905, 37);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.titleLabel.Location = new System.Drawing.Point(330, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(245, 26);
            this.titleLabel.TabIndex = 46;
            this.titleLabel.Text = "Selecting Startup Programs";
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = global::Startup.Properties.Resources.exit;
            this.closeButton.InitialImage = global::Startup.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(877, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 37);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 5;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // okButton
            // 
            this.okButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.okButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.okButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.okButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.okButton.Location = new System.Drawing.Point(270, 188);
            this.okButton.Name = "okButton";
            this.okButton.Size = new System.Drawing.Size(98, 28);
            this.okButton.TabIndex = 47;
            this.okButton.Text = "OK";
            this.okButton.UseVisualStyleBackColor = false;
            this.okButton.Click += new System.EventHandler(this.okButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordBox.Location = new System.Drawing.Point(170, 57);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(159, 20);
            this.passwordBox.TabIndex = 44;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.SystemColors.Info;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.passwordLabel.Location = new System.Drawing.Point(17, 56);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(115, 19);
            this.passwordLabel.TabIndex = 46;
            this.passwordLabel.Text = "WMS Password";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameBox.Location = new System.Drawing.Point(170, 14);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(159, 20);
            this.usernameBox.TabIndex = 43;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.SystemColors.Info;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.usernameLabel.Location = new System.Drawing.Point(17, 15);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(64, 19);
            this.usernameLabel.TabIndex = 45;
            this.usernameLabel.Text = "WMS ID";
            // 
            // repeatPasswordBox
            // 
            this.repeatPasswordBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.repeatPasswordBox.Location = new System.Drawing.Point(170, 94);
            this.repeatPasswordBox.Name = "repeatPasswordBox";
            this.repeatPasswordBox.PasswordChar = '*';
            this.repeatPasswordBox.Size = new System.Drawing.Size(159, 20);
            this.repeatPasswordBox.TabIndex = 48;
            // 
            // repeatPassLabel
            // 
            this.repeatPassLabel.AutoSize = true;
            this.repeatPassLabel.BackColor = System.Drawing.SystemColors.Info;
            this.repeatPassLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.repeatPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.repeatPassLabel.Location = new System.Drawing.Point(17, 93);
            this.repeatPassLabel.Name = "repeatPassLabel";
            this.repeatPassLabel.Size = new System.Drawing.Size(132, 19);
            this.repeatPassLabel.TabIndex = 49;
            this.repeatPassLabel.Text = "Confirm Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.instructionsLabel);
            this.panel1.Location = new System.Drawing.Point(374, 47);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(519, 135);
            this.panel1.TabIndex = 50;
            // 
            // instructionsLabel
            // 
            this.instructionsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.instructionsLabel.AutoSize = true;
            this.instructionsLabel.Font = new System.Drawing.Font("Calibri", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.instructionsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.instructionsLabel.Location = new System.Drawing.Point(52, 4);
            this.instructionsLabel.Name = "instructionsLabel";
            this.instructionsLabel.Size = new System.Drawing.Size(414, 126);
            this.instructionsLabel.TabIndex = 47;
            this.instructionsLabel.Text = resources.GetString("instructionsLabel.Text");
            // 
            // resetPanel
            // 
            this.resetPanel.BackColor = System.Drawing.SystemColors.Info;
            this.resetPanel.Controls.Add(this.passwordBox);
            this.resetPanel.Controls.Add(this.usernameLabel);
            this.resetPanel.Controls.Add(this.repeatPasswordBox);
            this.resetPanel.Controls.Add(this.usernameBox);
            this.resetPanel.Controls.Add(this.repeatPassLabel);
            this.resetPanel.Controls.Add(this.passwordLabel);
            this.resetPanel.Location = new System.Drawing.Point(12, 47);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(356, 135);
            this.resetPanel.TabIndex = 87;
            // 
            // lbsCheck
            // 
            this.lbsCheck.AutoSize = true;
            this.lbsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbsCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.lbsCheck.Location = new System.Drawing.Point(48, 41);
            this.lbsCheck.Name = "lbsCheck";
            this.lbsCheck.Size = new System.Drawing.Size(62, 24);
            this.lbsCheck.TabIndex = 88;
            this.lbsCheck.Text = "LBS";
            this.lbsCheck.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.pictureBox8);
            this.panel2.Controls.Add(this.pictureBox7);
            this.panel2.Controls.Add(this.pictureBox6);
            this.panel2.Controls.Add(this.pictureBox5);
            this.panel2.Controls.Add(this.pictureBox4);
            this.panel2.Controls.Add(this.pictureBox3);
            this.panel2.Controls.Add(this.pictureBox2);
            this.panel2.Controls.Add(this.pictureBox1);
            this.panel2.Controls.Add(this.mfcdpsCheck);
            this.panel2.Controls.Add(this.pcoCheck);
            this.panel2.Controls.Add(this.avisCheck);
            this.panel2.Controls.Add(this.mfccpsCheck);
            this.panel2.Controls.Add(this.bmisCheck);
            this.panel2.Controls.Add(this.dserviceCheck);
            this.panel2.Controls.Add(this.cpsCheck);
            this.panel2.Controls.Add(this.lbsCheck);
            this.panel2.Location = new System.Drawing.Point(88, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 150);
            this.panel2.TabIndex = 88;
            // 
            // pictureBox8
            // 
            this.pictureBox8.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox8.Image")));
            this.pictureBox8.Location = new System.Drawing.Point(692, 89);
            this.pictureBox8.Name = "pictureBox8";
            this.pictureBox8.Size = new System.Drawing.Size(26, 37);
            this.pictureBox8.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox8.TabIndex = 103;
            this.pictureBox8.TabStop = false;
            // 
            // pictureBox7
            // 
            this.pictureBox7.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox7.Image")));
            this.pictureBox7.Location = new System.Drawing.Point(493, 88);
            this.pictureBox7.Name = "pictureBox7";
            this.pictureBox7.Size = new System.Drawing.Size(26, 37);
            this.pictureBox7.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox7.TabIndex = 102;
            this.pictureBox7.TabStop = false;
            // 
            // pictureBox6
            // 
            this.pictureBox6.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox6.Image")));
            this.pictureBox6.Location = new System.Drawing.Point(302, 89);
            this.pictureBox6.Name = "pictureBox6";
            this.pictureBox6.Size = new System.Drawing.Size(26, 37);
            this.pictureBox6.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox6.TabIndex = 101;
            this.pictureBox6.TabStop = false;
            // 
            // pictureBox5
            // 
            this.pictureBox5.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox5.Image")));
            this.pictureBox5.Location = new System.Drawing.Point(116, 89);
            this.pictureBox5.Name = "pictureBox5";
            this.pictureBox5.Size = new System.Drawing.Size(26, 37);
            this.pictureBox5.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox5.TabIndex = 100;
            this.pictureBox5.TabStop = false;
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(493, 28);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(26, 37);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox4.TabIndex = 99;
            this.pictureBox4.TabStop = false;
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(270, 28);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(26, 37);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox3.TabIndex = 98;
            this.pictureBox3.TabStop = false;
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox2.Image")));
            this.pictureBox2.Location = new System.Drawing.Point(116, 28);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(26, 37);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox2.TabIndex = 97;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(655, 28);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(26, 37);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 96;
            this.pictureBox1.TabStop = false;
            // 
            // mfcdpsCheck
            // 
            this.mfcdpsCheck.AutoSize = true;
            this.mfcdpsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfcdpsCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.mfcdpsCheck.Location = new System.Drawing.Point(376, 41);
            this.mfcdpsCheck.Name = "mfcdpsCheck";
            this.mfcdpsCheck.Size = new System.Drawing.Size(111, 24);
            this.mfcdpsCheck.TabIndex = 95;
            this.mfcdpsCheck.Text = "MFC_DPS";
            this.mfcdpsCheck.UseVisualStyleBackColor = true;
            // 
            // pcoCheck
            // 
            this.pcoCheck.AutoSize = true;
            this.pcoCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.pcoCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.pcoCheck.Location = new System.Drawing.Point(579, 102);
            this.pcoCheck.Name = "pcoCheck";
            this.pcoCheck.Size = new System.Drawing.Size(107, 24);
            this.pcoCheck.TabIndex = 94;
            this.pcoCheck.Text = "PCO View";
            this.pcoCheck.UseVisualStyleBackColor = true;
            // 
            // avisCheck
            // 
            this.avisCheck.AutoSize = true;
            this.avisCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.avisCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.avisCheck.Location = new System.Drawing.Point(579, 41);
            this.avisCheck.Name = "avisCheck";
            this.avisCheck.Size = new System.Drawing.Size(70, 24);
            this.avisCheck.TabIndex = 93;
            this.avisCheck.Text = "AVIS";
            this.avisCheck.UseVisualStyleBackColor = true;
            // 
            // mfccpsCheck
            // 
            this.mfccpsCheck.AutoSize = true;
            this.mfccpsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mfccpsCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.mfccpsCheck.Location = new System.Drawing.Point(377, 102);
            this.mfccpsCheck.Name = "mfccpsCheck";
            this.mfccpsCheck.Size = new System.Drawing.Size(110, 24);
            this.mfccpsCheck.TabIndex = 92;
            this.mfccpsCheck.Text = "MFC_CPS";
            this.mfccpsCheck.UseVisualStyleBackColor = true;
            // 
            // bmisCheck
            // 
            this.bmisCheck.AutoSize = true;
            this.bmisCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bmisCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.bmisCheck.Location = new System.Drawing.Point(196, 41);
            this.bmisCheck.Name = "bmisCheck";
            this.bmisCheck.Size = new System.Drawing.Size(72, 24);
            this.bmisCheck.TabIndex = 91;
            this.bmisCheck.Text = "BMIS";
            this.bmisCheck.UseVisualStyleBackColor = true;
            // 
            // dserviceCheck
            // 
            this.dserviceCheck.AutoSize = true;
            this.dserviceCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dserviceCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.dserviceCheck.Location = new System.Drawing.Point(196, 102);
            this.dserviceCheck.Name = "dserviceCheck";
            this.dserviceCheck.Size = new System.Drawing.Size(100, 24);
            this.dserviceCheck.TabIndex = 90;
            this.dserviceCheck.Text = "DService";
            this.dserviceCheck.UseVisualStyleBackColor = true;
            // 
            // cpsCheck
            // 
            this.cpsCheck.AutoSize = true;
            this.cpsCheck.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cpsCheck.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.cpsCheck.Location = new System.Drawing.Point(46, 102);
            this.cpsCheck.Name = "cpsCheck";
            this.cpsCheck.Size = new System.Drawing.Size(63, 24);
            this.cpsCheck.TabIndex = 89;
            this.cpsCheck.Text = "CPS";
            this.cpsCheck.UseVisualStyleBackColor = true;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.cancelButton.Location = new System.Drawing.Point(12, 188);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(98, 28);
            this.cancelButton.TabIndex = 89;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // CredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(905, 450);
            this.Controls.Add(this.cancelButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.resetPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.okButton);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CredentialsForm";
            this.Text = "CredentialsForm";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.resetPanel.ResumeLayout(false);
            this.resetPanel.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox8)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox7)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox6)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox5)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button okButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox repeatPasswordBox;
        private System.Windows.Forms.Label repeatPassLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label instructionsLabel;
        private System.Windows.Forms.Panel resetPanel;
        private System.Windows.Forms.CheckBox lbsCheck;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.CheckBox mfcdpsCheck;
        private System.Windows.Forms.CheckBox pcoCheck;
        private System.Windows.Forms.CheckBox avisCheck;
        private System.Windows.Forms.CheckBox mfccpsCheck;
        private System.Windows.Forms.CheckBox bmisCheck;
        private System.Windows.Forms.CheckBox dserviceCheck;
        private System.Windows.Forms.CheckBox cpsCheck;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox8;
        private System.Windows.Forms.PictureBox pictureBox7;
        private System.Windows.Forms.PictureBox pictureBox6;
        private System.Windows.Forms.PictureBox pictureBox5;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.Button cancelButton;
    }
}