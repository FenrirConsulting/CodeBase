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
            this.checkBox1 = new System.Windows.Forms.CheckBox();
            this.checkBox2 = new System.Windows.Forms.CheckBox();
            this.checkBox3 = new System.Windows.Forms.CheckBox();
            this.checkBox4 = new System.Windows.Forms.CheckBox();
            this.checkBox5 = new System.Windows.Forms.CheckBox();
            this.checkBox6 = new System.Windows.Forms.CheckBox();
            this.checkBox7 = new System.Windows.Forms.CheckBox();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.panel1.SuspendLayout();
            this.resetPanel.SuspendLayout();
            this.panel2.SuspendLayout();
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
            this.lbsCheck.Location = new System.Drawing.Point(87, 41);
            this.lbsCheck.Name = "lbsCheck";
            this.lbsCheck.Size = new System.Drawing.Size(62, 24);
            this.lbsCheck.TabIndex = 88;
            this.lbsCheck.Text = "LBS";
            this.lbsCheck.UseVisualStyleBackColor = true;
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.SystemColors.Info;
            this.panel2.Controls.Add(this.checkBox7);
            this.panel2.Controls.Add(this.checkBox6);
            this.panel2.Controls.Add(this.checkBox5);
            this.panel2.Controls.Add(this.checkBox4);
            this.panel2.Controls.Add(this.checkBox3);
            this.panel2.Controls.Add(this.checkBox2);
            this.panel2.Controls.Add(this.checkBox1);
            this.panel2.Controls.Add(this.lbsCheck);
            this.panel2.Location = new System.Drawing.Point(88, 253);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(728, 150);
            this.panel2.TabIndex = 88;
            // 
            // checkBox1
            // 
            this.checkBox1.AutoSize = true;
            this.checkBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.checkBox1.Location = new System.Drawing.Point(87, 86);
            this.checkBox1.Name = "checkBox1";
            this.checkBox1.Size = new System.Drawing.Size(63, 24);
            this.checkBox1.TabIndex = 89;
            this.checkBox1.Text = "CPS";
            this.checkBox1.UseVisualStyleBackColor = true;
            // 
            // checkBox2
            // 
            this.checkBox2.AutoSize = true;
            this.checkBox2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.checkBox2.Location = new System.Drawing.Point(243, 86);
            this.checkBox2.Name = "checkBox2";
            this.checkBox2.Size = new System.Drawing.Size(100, 24);
            this.checkBox2.TabIndex = 90;
            this.checkBox2.Text = "DService";
            this.checkBox2.UseVisualStyleBackColor = true;
            // 
            // checkBox3
            // 
            this.checkBox3.AutoSize = true;
            this.checkBox3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.checkBox3.Location = new System.Drawing.Point(243, 41);
            this.checkBox3.Name = "checkBox3";
            this.checkBox3.Size = new System.Drawing.Size(65, 24);
            this.checkBox3.TabIndex = 91;
            this.checkBox3.Text = "MPS";
            this.checkBox3.UseVisualStyleBackColor = true;
            // 
            // checkBox4
            // 
            this.checkBox4.AutoSize = true;
            this.checkBox4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox4.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.checkBox4.Location = new System.Drawing.Point(385, 86);
            this.checkBox4.Name = "checkBox4";
            this.checkBox4.Size = new System.Drawing.Size(110, 24);
            this.checkBox4.TabIndex = 92;
            this.checkBox4.Text = "MFC_CPS";
            this.checkBox4.UseVisualStyleBackColor = true;
            // 
            // checkBox5
            // 
            this.checkBox5.AutoSize = true;
            this.checkBox5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox5.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.checkBox5.Location = new System.Drawing.Point(535, 41);
            this.checkBox5.Name = "checkBox5";
            this.checkBox5.Size = new System.Drawing.Size(70, 24);
            this.checkBox5.TabIndex = 93;
            this.checkBox5.Text = "AVIS";
            this.checkBox5.UseVisualStyleBackColor = true;
            // 
            // checkBox6
            // 
            this.checkBox6.AutoSize = true;
            this.checkBox6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox6.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.checkBox6.Location = new System.Drawing.Point(535, 86);
            this.checkBox6.Name = "checkBox6";
            this.checkBox6.Size = new System.Drawing.Size(107, 24);
            this.checkBox6.TabIndex = 94;
            this.checkBox6.Text = "PCO View";
            this.checkBox6.UseVisualStyleBackColor = true;
            // 
            // checkBox7
            // 
            this.checkBox7.AutoSize = true;
            this.checkBox7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.checkBox7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.checkBox7.Location = new System.Drawing.Point(385, 41);
            this.checkBox7.Name = "checkBox7";
            this.checkBox7.Size = new System.Drawing.Size(111, 24);
            this.checkBox7.TabIndex = 95;
            this.checkBox7.Text = "MFC_DPS";
            this.checkBox7.UseVisualStyleBackColor = true;
            // 
            // CredentialsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(905, 450);
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
        private System.Windows.Forms.CheckBox checkBox7;
        private System.Windows.Forms.CheckBox checkBox6;
        private System.Windows.Forms.CheckBox checkBox5;
        private System.Windows.Forms.CheckBox checkBox4;
        private System.Windows.Forms.CheckBox checkBox3;
        private System.Windows.Forms.CheckBox checkBox2;
        private System.Windows.Forms.CheckBox checkBox1;
    }
}