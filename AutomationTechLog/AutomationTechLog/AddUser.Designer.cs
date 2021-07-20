
namespace AutomationTechLog
{
    partial class AddUser
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddUser));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.shiftBox = new System.Windows.Forms.ComboBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.partsLeadCheckBox = new System.Windows.Forms.CheckBox();
            this.activeCheck = new System.Windows.Forms.CheckBox();
            this.leadCheckBox = new System.Windows.Forms.CheckBox();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.createUserButton = new System.Windows.Forms.Button();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.badgeBox = new System.Windows.Forms.TextBox();
            this.BadgeLabel = new System.Windows.Forms.Label();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
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
            this.titlePanel.Size = new System.Drawing.Size(461, 47);
            this.titlePanel.TabIndex = 3;
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.titleLabel.Location = new System.Drawing.Point(164, 13);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(104, 23);
            this.titleLabel.TabIndex = 49;
            this.titleLabel.Text = "Create User";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(430, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 26);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 48;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // shiftLabel
            // 
            this.shiftLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.shiftLabel.Location = new System.Drawing.Point(281, 73);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(40, 19);
            this.shiftLabel.TabIndex = 106;
            this.shiftLabel.Text = "Shift";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.employeeIDLabel.Location = new System.Drawing.Point(155, 74);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(94, 19);
            this.employeeIDLabel.TabIndex = 105;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.usernameLabel.Location = new System.Drawing.Point(17, 75);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 19);
            this.usernameLabel.TabIndex = 96;
            this.usernameLabel.Text = "Username";
            // 
            // shiftBox
            // 
            this.shiftBox.FormattingEnabled = true;
            this.shiftBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.shiftBox.Location = new System.Drawing.Point(269, 95);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(52, 21);
            this.shiftBox.TabIndex = 2;
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.adminCheckBox.Location = new System.Drawing.Point(12, 226);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(55, 17);
            this.adminCheckBox.TabIndex = 6;
            this.adminCheckBox.Text = "Admin";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(155, 96);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.Size = new System.Drawing.Size(95, 20);
            this.userIDBox.TabIndex = 1;
            this.userIDBox.TextChanged += new System.EventHandler(this.userIDBox_TextChanged);
            // 
            // partsLeadCheckBox
            // 
            this.partsLeadCheckBox.AutoSize = true;
            this.partsLeadCheckBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.partsLeadCheckBox.Location = new System.Drawing.Point(12, 164);
            this.partsLeadCheckBox.Name = "partsLeadCheckBox";
            this.partsLeadCheckBox.Size = new System.Drawing.Size(77, 17);
            this.partsLeadCheckBox.TabIndex = 4;
            this.partsLeadCheckBox.Text = "Parts Lead";
            this.partsLeadCheckBox.UseVisualStyleBackColor = true;
            // 
            // activeCheck
            // 
            this.activeCheck.AutoSize = true;
            this.activeCheck.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.activeCheck.Location = new System.Drawing.Point(12, 133);
            this.activeCheck.Name = "activeCheck";
            this.activeCheck.Size = new System.Drawing.Size(56, 17);
            this.activeCheck.TabIndex = 3;
            this.activeCheck.Text = "Active";
            this.activeCheck.UseVisualStyleBackColor = true;
            // 
            // leadCheckBox
            // 
            this.leadCheckBox.AutoSize = true;
            this.leadCheckBox.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.leadCheckBox.Location = new System.Drawing.Point(12, 195);
            this.leadCheckBox.Name = "leadCheckBox";
            this.leadCheckBox.Size = new System.Drawing.Size(50, 17);
            this.leadCheckBox.TabIndex = 5;
            this.leadCheckBox.Text = "Lead";
            this.leadCheckBox.UseVisualStyleBackColor = true;
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(155, 161);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(132, 20);
            this.passwordBox.TabIndex = 7;
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.passwordLabel.Location = new System.Drawing.Point(155, 139);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 19);
            this.passwordLabel.TabIndex = 107;
            this.passwordLabel.Text = "Password";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(155, 195);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 19);
            this.label1.TabIndex = 108;
            this.label1.Text = "Confirm Password";
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.Location = new System.Drawing.Point(155, 217);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.PasswordChar = '*';
            this.confirmPasswordBox.Size = new System.Drawing.Size(132, 20);
            this.confirmPasswordBox.TabIndex = 8;
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.createUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createUserButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.createUserButton.Location = new System.Drawing.Point(324, 213);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(100, 24);
            this.createUserButton.TabIndex = 9;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(12, 95);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(119, 20);
            this.usernameBox.TabIndex = 0;
            // 
            // badgeBox
            // 
            this.badgeBox.Location = new System.Drawing.Point(334, 95);
            this.badgeBox.Name = "badgeBox";
            this.badgeBox.Size = new System.Drawing.Size(119, 20);
            this.badgeBox.TabIndex = 109;
            // 
            // BadgeLabel
            // 
            this.BadgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.BadgeLabel.AutoSize = true;
            this.BadgeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.BadgeLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.BadgeLabel.Location = new System.Drawing.Point(330, 73);
            this.BadgeLabel.Name = "BadgeLabel";
            this.BadgeLabel.Size = new System.Drawing.Size(63, 19);
            this.BadgeLabel.TabIndex = 110;
            this.BadgeLabel.Text = "Badge #";
            // 
            // AddUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.ClientSize = new System.Drawing.Size(461, 269);
            this.Controls.Add(this.BadgeLabel);
            this.Controls.Add(this.badgeBox);
            this.Controls.Add(this.usernameBox);
            this.Controls.Add(this.createUserButton);
            this.Controls.Add(this.confirmPasswordBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.passwordLabel);
            this.Controls.Add(this.shiftLabel);
            this.Controls.Add(this.employeeIDLabel);
            this.Controls.Add(this.usernameLabel);
            this.Controls.Add(this.shiftBox);
            this.Controls.Add(this.adminCheckBox);
            this.Controls.Add(this.userIDBox);
            this.Controls.Add(this.partsLeadCheckBox);
            this.Controls.Add(this.activeCheck);
            this.Controls.Add(this.leadCheckBox);
            this.Controls.Add(this.passwordBox);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddUser";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATLog";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ComboBox shiftBox;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.CheckBox partsLeadCheckBox;
        private System.Windows.Forms.CheckBox activeCheck;
        private System.Windows.Forms.CheckBox leadCheckBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.TextBox badgeBox;
        private System.Windows.Forms.Label BadgeLabel;
    }
}