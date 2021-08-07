
namespace AutomationTechLog
{
    partial class UserForm
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
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.leadPanel = new System.Windows.Forms.Panel();
            this.updateUserButton = new System.Windows.Forms.Button();
            this.managementLabel = new System.Windows.Forms.Label();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.createUserButton = new System.Windows.Forms.Button();
            this.deleteUserButton = new System.Windows.Forms.Button();
            this.adminLabel = new System.Windows.Forms.Label();
            this.adminPasswordConfirmBox = new System.Windows.Forms.TextBox();
            this.adminResetButton = new System.Windows.Forms.Button();
            this.adminPasswordResetBox = new System.Windows.Forms.TextBox();
            this.adminConfirmPassLabel = new System.Windows.Forms.Label();
            this.adminNewPassLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.shiftBox = new System.Windows.Forms.ComboBox();
            this.userSelectBox = new System.Windows.Forms.ComboBox();
            this.adminCheckBox = new System.Windows.Forms.CheckBox();
            this.userIDBox = new System.Windows.Forms.TextBox();
            this.partsLeadCheckBox = new System.Windows.Forms.CheckBox();
            this.activeCheck = new System.Windows.Forms.CheckBox();
            this.leadCheckBox = new System.Windows.Forms.CheckBox();
            this.resetPanel = new System.Windows.Forms.Panel();
            this.passwordResetLabel = new System.Windows.Forms.Label();
            this.passwordResetButton = new System.Windows.Forms.Button();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.resetBox = new System.Windows.Forms.TextBox();
            this.confirmResetBox = new System.Windows.Forms.TextBox();
            this.titlePanel = new System.Windows.Forms.Panel();
            this.generatedTitle = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.badgeBox = new System.Windows.Forms.TextBox();
            this.badgeLabel = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.leadPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            this.resetPanel.SuspendLayout();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.leadPanel);
            this.bodyPanel.Controls.Add(this.resetPanel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 47);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(548, 435);
            this.bodyPanel.TabIndex = 3;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            // 
            // leadPanel
            // 
            this.leadPanel.BackColor = System.Drawing.SystemColors.Info;
            this.leadPanel.Controls.Add(this.badgeLabel);
            this.leadPanel.Controls.Add(this.badgeBox);
            this.leadPanel.Controls.Add(this.updateUserButton);
            this.leadPanel.Controls.Add(this.managementLabel);
            this.leadPanel.Controls.Add(this.adminPanel);
            this.leadPanel.Controls.Add(this.shiftLabel);
            this.leadPanel.Controls.Add(this.employeeIDLabel);
            this.leadPanel.Controls.Add(this.usernameLabel);
            this.leadPanel.Controls.Add(this.shiftBox);
            this.leadPanel.Controls.Add(this.userSelectBox);
            this.leadPanel.Controls.Add(this.adminCheckBox);
            this.leadPanel.Controls.Add(this.userIDBox);
            this.leadPanel.Controls.Add(this.partsLeadCheckBox);
            this.leadPanel.Controls.Add(this.activeCheck);
            this.leadPanel.Controls.Add(this.leadCheckBox);
            this.leadPanel.Location = new System.Drawing.Point(12, 135);
            this.leadPanel.Name = "leadPanel";
            this.leadPanel.Size = new System.Drawing.Size(524, 284);
            this.leadPanel.TabIndex = 94;
            // 
            // updateUserButton
            // 
            this.updateUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.updateUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateUserButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.updateUserButton.Location = new System.Drawing.Point(402, 79);
            this.updateUserButton.Name = "updateUserButton";
            this.updateUserButton.Size = new System.Drawing.Size(100, 24);
            this.updateUserButton.TabIndex = 2;
            this.updateUserButton.Text = "Update";
            this.updateUserButton.UseVisualStyleBackColor = false;
            this.updateUserButton.Click += new System.EventHandler(this.updateUserButton_Click);
            // 
            // managementLabel
            // 
            this.managementLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.managementLabel.AutoSize = true;
            this.managementLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managementLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.managementLabel.Location = new System.Drawing.Point(176, 12);
            this.managementLabel.Name = "managementLabel";
            this.managementLabel.Size = new System.Drawing.Size(173, 26);
            this.managementLabel.TabIndex = 86;
            this.managementLabel.Text = "User Management";
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.adminPanel.Controls.Add(this.createUserButton);
            this.adminPanel.Controls.Add(this.deleteUserButton);
            this.adminPanel.Controls.Add(this.adminLabel);
            this.adminPanel.Controls.Add(this.adminPasswordConfirmBox);
            this.adminPanel.Controls.Add(this.adminResetButton);
            this.adminPanel.Controls.Add(this.adminPasswordResetBox);
            this.adminPanel.Controls.Add(this.adminConfirmPassLabel);
            this.adminPanel.Controls.Add(this.adminNewPassLabel);
            this.adminPanel.Location = new System.Drawing.Point(97, 115);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(405, 150);
            this.adminPanel.TabIndex = 95;
            // 
            // createUserButton
            // 
            this.createUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.createUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createUserButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.createUserButton.Location = new System.Drawing.Point(272, 113);
            this.createUserButton.Name = "createUserButton";
            this.createUserButton.Size = new System.Drawing.Size(100, 24);
            this.createUserButton.TabIndex = 4;
            this.createUserButton.Text = "Create User";
            this.createUserButton.UseVisualStyleBackColor = false;
            this.createUserButton.Click += new System.EventHandler(this.createUserButton_Click);
            // 
            // deleteUserButton
            // 
            this.deleteUserButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.deleteUserButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteUserButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteUserButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.deleteUserButton.Location = new System.Drawing.Point(20, 113);
            this.deleteUserButton.Name = "deleteUserButton";
            this.deleteUserButton.Size = new System.Drawing.Size(100, 24);
            this.deleteUserButton.TabIndex = 3;
            this.deleteUserButton.Text = "Delete User";
            this.deleteUserButton.UseVisualStyleBackColor = false;
            this.deleteUserButton.Click += new System.EventHandler(this.deleteUserButton_Click);
            // 
            // adminLabel
            // 
            this.adminLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminLabel.AutoSize = true;
            this.adminLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.adminLabel.Location = new System.Drawing.Point(168, 11);
            this.adminLabel.Name = "adminLabel";
            this.adminLabel.Size = new System.Drawing.Size(69, 26);
            this.adminLabel.TabIndex = 86;
            this.adminLabel.Text = "Admin";
            // 
            // adminPasswordConfirmBox
            // 
            this.adminPasswordConfirmBox.Location = new System.Drawing.Point(162, 66);
            this.adminPasswordConfirmBox.Name = "adminPasswordConfirmBox";
            this.adminPasswordConfirmBox.PasswordChar = '*';
            this.adminPasswordConfirmBox.Size = new System.Drawing.Size(95, 20);
            this.adminPasswordConfirmBox.TabIndex = 1;
            // 
            // adminResetButton
            // 
            this.adminResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.adminResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.adminResetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.adminResetButton.Location = new System.Drawing.Point(272, 62);
            this.adminResetButton.Name = "adminResetButton";
            this.adminResetButton.Size = new System.Drawing.Size(100, 24);
            this.adminResetButton.TabIndex = 2;
            this.adminResetButton.Text = "Reset Password";
            this.adminResetButton.UseVisualStyleBackColor = false;
            this.adminResetButton.Click += new System.EventHandler(this.adminResetButton_Click);
            // 
            // adminPasswordResetBox
            // 
            this.adminPasswordResetBox.Location = new System.Drawing.Point(162, 40);
            this.adminPasswordResetBox.Name = "adminPasswordResetBox";
            this.adminPasswordResetBox.PasswordChar = '*';
            this.adminPasswordResetBox.Size = new System.Drawing.Size(95, 20);
            this.adminPasswordResetBox.TabIndex = 0;
            // 
            // adminConfirmPassLabel
            // 
            this.adminConfirmPassLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminConfirmPassLabel.AutoSize = true;
            this.adminConfirmPassLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminConfirmPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.adminConfirmPassLabel.Location = new System.Drawing.Point(16, 67);
            this.adminConfirmPassLabel.Name = "adminConfirmPassLabel";
            this.adminConfirmPassLabel.Size = new System.Drawing.Size(132, 19);
            this.adminConfirmPassLabel.TabIndex = 91;
            this.adminConfirmPassLabel.Text = "Confirm Password";
            // 
            // adminNewPassLabel
            // 
            this.adminNewPassLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.adminNewPassLabel.AutoSize = true;
            this.adminNewPassLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminNewPassLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.adminNewPassLabel.Location = new System.Drawing.Point(16, 39);
            this.adminNewPassLabel.Name = "adminNewPassLabel";
            this.adminNewPassLabel.Size = new System.Drawing.Size(109, 19);
            this.adminNewPassLabel.TabIndex = 90;
            this.adminNewPassLabel.Text = "New Password";
            // 
            // shiftLabel
            // 
            this.shiftLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.shiftLabel.Location = new System.Drawing.Point(242, 57);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(40, 19);
            this.shiftLabel.TabIndex = 95;
            this.shiftLabel.Text = "Shift";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.employeeIDLabel.Location = new System.Drawing.Point(142, 57);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(94, 19);
            this.employeeIDLabel.TabIndex = 94;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.usernameLabel.Location = new System.Drawing.Point(19, 57);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(77, 19);
            this.usernameLabel.TabIndex = 86;
            this.usernameLabel.Text = "Username";
            // 
            // shiftBox
            // 
            this.shiftBox.FormattingEnabled = true;
            this.shiftBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.shiftBox.Location = new System.Drawing.Point(242, 79);
            this.shiftBox.Name = "shiftBox";
            this.shiftBox.Size = new System.Drawing.Size(52, 21);
            this.shiftBox.TabIndex = 93;
            // 
            // userSelectBox
            // 
            this.userSelectBox.FormattingEnabled = true;
            this.userSelectBox.Location = new System.Drawing.Point(14, 78);
            this.userSelectBox.Name = "userSelectBox";
            this.userSelectBox.Size = new System.Drawing.Size(121, 21);
            this.userSelectBox.TabIndex = 0;
            this.userSelectBox.SelectedIndexChanged += new System.EventHandler(this.userSelectBox_SelectedIndexChanged);
            // 
            // adminCheckBox
            // 
            this.adminCheckBox.AutoSize = true;
            this.adminCheckBox.Location = new System.Drawing.Point(14, 198);
            this.adminCheckBox.Name = "adminCheckBox";
            this.adminCheckBox.Size = new System.Drawing.Size(55, 17);
            this.adminCheckBox.TabIndex = 92;
            this.adminCheckBox.Text = "Admin";
            this.adminCheckBox.UseVisualStyleBackColor = true;
            // 
            // userIDBox
            // 
            this.userIDBox.Location = new System.Drawing.Point(141, 79);
            this.userIDBox.Name = "userIDBox";
            this.userIDBox.ReadOnly = true;
            this.userIDBox.Size = new System.Drawing.Size(95, 20);
            this.userIDBox.TabIndex = 1;
            // 
            // partsLeadCheckBox
            // 
            this.partsLeadCheckBox.AutoSize = true;
            this.partsLeadCheckBox.Location = new System.Drawing.Point(14, 136);
            this.partsLeadCheckBox.Name = "partsLeadCheckBox";
            this.partsLeadCheckBox.Size = new System.Drawing.Size(77, 17);
            this.partsLeadCheckBox.TabIndex = 91;
            this.partsLeadCheckBox.Text = "Parts Lead";
            this.partsLeadCheckBox.UseVisualStyleBackColor = true;
            // 
            // activeCheck
            // 
            this.activeCheck.AutoSize = true;
            this.activeCheck.Location = new System.Drawing.Point(14, 105);
            this.activeCheck.Name = "activeCheck";
            this.activeCheck.Size = new System.Drawing.Size(56, 17);
            this.activeCheck.TabIndex = 89;
            this.activeCheck.Text = "Active";
            this.activeCheck.UseVisualStyleBackColor = true;
            // 
            // leadCheckBox
            // 
            this.leadCheckBox.AutoSize = true;
            this.leadCheckBox.Location = new System.Drawing.Point(14, 167);
            this.leadCheckBox.Name = "leadCheckBox";
            this.leadCheckBox.Size = new System.Drawing.Size(50, 17);
            this.leadCheckBox.TabIndex = 90;
            this.leadCheckBox.Text = "Lead";
            this.leadCheckBox.UseVisualStyleBackColor = true;
            // 
            // resetPanel
            // 
            this.resetPanel.BackColor = System.Drawing.SystemColors.Info;
            this.resetPanel.Controls.Add(this.passwordResetLabel);
            this.resetPanel.Controls.Add(this.passwordResetButton);
            this.resetPanel.Controls.Add(this.newPasswordLabel);
            this.resetPanel.Controls.Add(this.confirmPasswordLabel);
            this.resetPanel.Controls.Add(this.resetBox);
            this.resetPanel.Controls.Add(this.confirmResetBox);
            this.resetPanel.Location = new System.Drawing.Point(12, 6);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(524, 114);
            this.resetPanel.TabIndex = 86;
            // 
            // passwordResetLabel
            // 
            this.passwordResetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.passwordResetLabel.AutoSize = true;
            this.passwordResetLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordResetLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.passwordResetLabel.Location = new System.Drawing.Point(169, 15);
            this.passwordResetLabel.Name = "passwordResetLabel";
            this.passwordResetLabel.Size = new System.Drawing.Size(186, 26);
            this.passwordResetLabel.TabIndex = 50;
            this.passwordResetLabel.Text = "Self Password Reset";
            // 
            // passwordResetButton
            // 
            this.passwordResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.passwordResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.passwordResetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.passwordResetButton.Location = new System.Drawing.Point(346, 75);
            this.passwordResetButton.Name = "passwordResetButton";
            this.passwordResetButton.Size = new System.Drawing.Size(100, 24);
            this.passwordResetButton.TabIndex = 2;
            this.passwordResetButton.Text = "Reset Password";
            this.passwordResetButton.UseVisualStyleBackColor = false;
            this.passwordResetButton.Click += new System.EventHandler(this.passwordResetButton_Click);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(79, 50);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(109, 19);
            this.newPasswordLabel.TabIndex = 84;
            this.newPasswordLabel.Text = "New Password";
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(79, 78);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(132, 19);
            this.confirmPasswordLabel.TabIndex = 85;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // resetBox
            // 
            this.resetBox.Location = new System.Drawing.Point(236, 51);
            this.resetBox.Name = "resetBox";
            this.resetBox.PasswordChar = '*';
            this.resetBox.Size = new System.Drawing.Size(95, 20);
            this.resetBox.TabIndex = 0;
            this.resetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.resetBox_KeyPress);
            // 
            // confirmResetBox
            // 
            this.confirmResetBox.Location = new System.Drawing.Point(236, 79);
            this.confirmResetBox.Name = "confirmResetBox";
            this.confirmResetBox.PasswordChar = '*';
            this.confirmResetBox.Size = new System.Drawing.Size(95, 20);
            this.confirmResetBox.TabIndex = 1;
            this.confirmResetBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.confirmResetBox_KeyPress);
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.titlePanel.Controls.Add(this.generatedTitle);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(548, 47);
            this.titlePanel.TabIndex = 2;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // generatedTitle
            // 
            this.generatedTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generatedTitle.AutoSize = true;
            this.generatedTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.generatedTitle.Location = new System.Drawing.Point(12, 13);
            this.generatedTitle.Name = "generatedTitle";
            this.generatedTitle.Size = new System.Drawing.Size(93, 23);
            this.generatedTitle.TabIndex = 49;
            this.generatedTitle.Text = "Hello User";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(517, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 26);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 48;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // badgeBox
            // 
            this.badgeBox.Location = new System.Drawing.Point(300, 79);
            this.badgeBox.Name = "badgeBox";
            this.badgeBox.Size = new System.Drawing.Size(95, 20);
            this.badgeBox.TabIndex = 86;
            // 
            // badgeLabel
            // 
            this.badgeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.badgeLabel.AutoSize = true;
            this.badgeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.badgeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.badgeLabel.Location = new System.Drawing.Point(301, 57);
            this.badgeLabel.Name = "badgeLabel";
            this.badgeLabel.Size = new System.Drawing.Size(63, 19);
            this.badgeLabel.TabIndex = 96;
            this.badgeLabel.Text = "Badge #";
            // 
            // UserForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(548, 482);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UserForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATLog";
            this.bodyPanel.ResumeLayout(false);
            this.leadPanel.ResumeLayout(false);
            this.leadPanel.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            this.resetPanel.ResumeLayout(false);
            this.resetPanel.PerformLayout();
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button passwordResetButton;
        private System.Windows.Forms.TextBox confirmResetBox;
        private System.Windows.Forms.Label generatedTitle;
        private System.Windows.Forms.Label passwordResetLabel;
        private System.Windows.Forms.TextBox resetBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.Panel resetPanel;
        private System.Windows.Forms.ComboBox userSelectBox;
        private System.Windows.Forms.TextBox userIDBox;
        private System.Windows.Forms.CheckBox adminCheckBox;
        private System.Windows.Forms.CheckBox partsLeadCheckBox;
        private System.Windows.Forms.CheckBox leadCheckBox;
        private System.Windows.Forms.CheckBox activeCheck;
        private System.Windows.Forms.ComboBox shiftBox;
        private System.Windows.Forms.Panel leadPanel;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.Label adminLabel;
        private System.Windows.Forms.Button adminResetButton;
        private System.Windows.Forms.Label adminNewPassLabel;
        private System.Windows.Forms.Label adminConfirmPassLabel;
        private System.Windows.Forms.TextBox adminPasswordResetBox;
        private System.Windows.Forms.TextBox adminPasswordConfirmBox;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Button deleteUserButton;
        private System.Windows.Forms.Button createUserButton;
        private System.Windows.Forms.Label managementLabel;
        private System.Windows.Forms.Button updateUserButton;
        private System.Windows.Forms.Label badgeLabel;
        private System.Windows.Forms.TextBox badgeBox;
    }
}