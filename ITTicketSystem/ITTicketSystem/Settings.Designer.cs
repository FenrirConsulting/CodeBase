namespace ITTicketSystem
{
    partial class Settings
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
            this.resetPanel = new System.Windows.Forms.Panel();
            this.resetButton = new System.Windows.Forms.Button();
            this.newPasswordLabel = new System.Windows.Forms.Label();
            this.confirmPasswordBox = new System.Windows.Forms.TextBox();
            this.newPasswordBox = new System.Windows.Forms.TextBox();
            this.confirmPasswordLabel = new System.Windows.Forms.Label();
            this.unlockResetButton = new System.Windows.Forms.Button();
            this.resetUser = new System.Windows.Forms.Label();
            this.resetUserBox = new System.Windows.Forms.TextBox();
            this.resetPassword = new System.Windows.Forms.Label();
            this.resetPasswordBox = new System.Windows.Forms.TextBox();
            this.userlistLabel = new System.Windows.Forms.Label();
            this.adminUsernameLabel = new System.Windows.Forms.Label();
            this.adminUsernameBox = new System.Windows.Forms.TextBox();
            this.unlockButton = new System.Windows.Forms.Button();
            this.adminPasswordLabel = new System.Windows.Forms.Label();
            this.adminPasswordTextBox = new System.Windows.Forms.TextBox();
            this.adminPanel = new System.Windows.Forms.Panel();
            this.deleteButton = new System.Windows.Forms.Button();
            this.createButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.recordsGrid = new System.Windows.Forms.DataGridView();
            this.passwordTextBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.formTitle = new System.Windows.Forms.Label();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextBox = new System.Windows.Forms.TextBox();
            this.emailLabel = new System.Windows.Forms.Label();
            this.employeeIDLabel = new System.Windows.Forms.Label();
            this.emailTextBox = new System.Windows.Forms.TextBox();
            this.techComboBox = new System.Windows.Forms.ComboBox();
            this.techLabel = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.resetPanel.SuspendLayout();
            this.adminPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.bodyPanel.Controls.Add(this.resetPanel);
            this.bodyPanel.Controls.Add(this.unlockResetButton);
            this.bodyPanel.Controls.Add(this.resetUser);
            this.bodyPanel.Controls.Add(this.resetUserBox);
            this.bodyPanel.Controls.Add(this.resetPassword);
            this.bodyPanel.Controls.Add(this.resetPasswordBox);
            this.bodyPanel.Controls.Add(this.userlistLabel);
            this.bodyPanel.Controls.Add(this.adminUsernameLabel);
            this.bodyPanel.Controls.Add(this.adminUsernameBox);
            this.bodyPanel.Controls.Add(this.unlockButton);
            this.bodyPanel.Controls.Add(this.adminPasswordLabel);
            this.bodyPanel.Controls.Add(this.adminPasswordTextBox);
            this.bodyPanel.Controls.Add(this.adminPanel);
            this.bodyPanel.Location = new System.Drawing.Point(13, 13);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1141, 587);
            this.bodyPanel.TabIndex = 26;
            // 
            // resetPanel
            // 
            this.resetPanel.Controls.Add(this.resetButton);
            this.resetPanel.Controls.Add(this.newPasswordLabel);
            this.resetPanel.Controls.Add(this.confirmPasswordBox);
            this.resetPanel.Controls.Add(this.newPasswordBox);
            this.resetPanel.Controls.Add(this.confirmPasswordLabel);
            this.resetPanel.Location = new System.Drawing.Point(3, 121);
            this.resetPanel.Name = "resetPanel";
            this.resetPanel.Size = new System.Drawing.Size(416, 152);
            this.resetPanel.TabIndex = 37;
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.resetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.resetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.resetButton.Location = new System.Drawing.Point(261, 53);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(133, 30);
            this.resetButton.TabIndex = 42;
            this.resetButton.Text = "Reset";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // newPasswordLabel
            // 
            this.newPasswordLabel.AutoSize = true;
            this.newPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.newPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.newPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.newPasswordLabel.Location = new System.Drawing.Point(18, 32);
            this.newPasswordLabel.Name = "newPasswordLabel";
            this.newPasswordLabel.Size = new System.Drawing.Size(109, 19);
            this.newPasswordLabel.TabIndex = 41;
            this.newPasswordLabel.Text = "New Password";
            // 
            // confirmPasswordBox
            // 
            this.confirmPasswordBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.confirmPasswordBox.Location = new System.Drawing.Point(152, 63);
            this.confirmPasswordBox.Name = "confirmPasswordBox";
            this.confirmPasswordBox.PasswordChar = '*';
            this.confirmPasswordBox.Size = new System.Drawing.Size(92, 20);
            this.confirmPasswordBox.TabIndex = 39;
            // 
            // newPasswordBox
            // 
            this.newPasswordBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.newPasswordBox.Location = new System.Drawing.Point(152, 34);
            this.newPasswordBox.Name = "newPasswordBox";
            this.newPasswordBox.PasswordChar = '*';
            this.newPasswordBox.Size = new System.Drawing.Size(92, 20);
            this.newPasswordBox.TabIndex = 38;
            // 
            // confirmPasswordLabel
            // 
            this.confirmPasswordLabel.AutoSize = true;
            this.confirmPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.confirmPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.confirmPasswordLabel.Location = new System.Drawing.Point(18, 61);
            this.confirmPasswordLabel.Name = "confirmPasswordLabel";
            this.confirmPasswordLabel.Size = new System.Drawing.Size(132, 19);
            this.confirmPasswordLabel.TabIndex = 40;
            this.confirmPasswordLabel.Text = "Confirm Password";
            // 
            // unlockResetButton
            // 
            this.unlockResetButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.unlockResetButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unlockResetButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockResetButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.unlockResetButton.Location = new System.Drawing.Point(264, 65);
            this.unlockResetButton.Name = "unlockResetButton";
            this.unlockResetButton.Size = new System.Drawing.Size(133, 30);
            this.unlockResetButton.TabIndex = 36;
            this.unlockResetButton.Text = "Unlock Reset";
            this.unlockResetButton.UseVisualStyleBackColor = false;
            this.unlockResetButton.Click += new System.EventHandler(this.unlockResetButton_Click);
            // 
            // resetUser
            // 
            this.resetUser.AutoSize = true;
            this.resetUser.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.resetUser.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.resetUser.Location = new System.Drawing.Point(21, 47);
            this.resetUser.Name = "resetUser";
            this.resetUser.Size = new System.Drawing.Size(57, 19);
            this.resetUser.TabIndex = 35;
            this.resetUser.Text = "User ID";
            // 
            // resetUserBox
            // 
            this.resetUserBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetUserBox.Location = new System.Drawing.Point(155, 46);
            this.resetUserBox.Name = "resetUserBox";
            this.resetUserBox.Size = new System.Drawing.Size(92, 20);
            this.resetUserBox.TabIndex = 32;
            // 
            // resetPassword
            // 
            this.resetPassword.AutoSize = true;
            this.resetPassword.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.resetPassword.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.resetPassword.Location = new System.Drawing.Point(21, 76);
            this.resetPassword.Name = "resetPassword";
            this.resetPassword.Size = new System.Drawing.Size(74, 19);
            this.resetPassword.TabIndex = 34;
            this.resetPassword.Text = "Password";
            // 
            // resetPasswordBox
            // 
            this.resetPasswordBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.resetPasswordBox.Location = new System.Drawing.Point(155, 75);
            this.resetPasswordBox.Name = "resetPasswordBox";
            this.resetPasswordBox.PasswordChar = '*';
            this.resetPasswordBox.Size = new System.Drawing.Size(92, 20);
            this.resetPasswordBox.TabIndex = 33;
            this.resetPasswordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.resetPasswordBox_KeyDown);
            // 
            // userlistLabel
            // 
            this.userlistLabel.AutoSize = true;
            this.userlistLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userlistLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.userlistLabel.Location = new System.Drawing.Point(21, 9);
            this.userlistLabel.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.userlistLabel.Name = "userlistLabel";
            this.userlistLabel.Size = new System.Drawing.Size(136, 23);
            this.userlistLabel.TabIndex = 26;
            this.userlistLabel.Text = "Reset Password";
            // 
            // adminUsernameLabel
            // 
            this.adminUsernameLabel.AutoSize = true;
            this.adminUsernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.adminUsernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminUsernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.adminUsernameLabel.Location = new System.Drawing.Point(468, 47);
            this.adminUsernameLabel.Name = "adminUsernameLabel";
            this.adminUsernameLabel.Size = new System.Drawing.Size(57, 19);
            this.adminUsernameLabel.TabIndex = 31;
            this.adminUsernameLabel.Text = "User ID";
            // 
            // adminUsernameBox
            // 
            this.adminUsernameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminUsernameBox.Location = new System.Drawing.Point(567, 48);
            this.adminUsernameBox.Name = "adminUsernameBox";
            this.adminUsernameBox.Size = new System.Drawing.Size(92, 20);
            this.adminUsernameBox.TabIndex = 0;
            this.adminUsernameBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminUsernameBox_KeyDown);
            // 
            // unlockButton
            // 
            this.unlockButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.unlockButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.unlockButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.unlockButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.unlockButton.Location = new System.Drawing.Point(678, 67);
            this.unlockButton.Name = "unlockButton";
            this.unlockButton.Size = new System.Drawing.Size(184, 28);
            this.unlockButton.TabIndex = 2;
            this.unlockButton.Text = "Unlock Admin";
            this.unlockButton.UseVisualStyleBackColor = false;
            this.unlockButton.Click += new System.EventHandler(this.unlockButton_Click);
            // 
            // adminPasswordLabel
            // 
            this.adminPasswordLabel.AutoSize = true;
            this.adminPasswordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.adminPasswordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.adminPasswordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.adminPasswordLabel.Location = new System.Drawing.Point(468, 76);
            this.adminPasswordLabel.Name = "adminPasswordLabel";
            this.adminPasswordLabel.Size = new System.Drawing.Size(74, 19);
            this.adminPasswordLabel.TabIndex = 28;
            this.adminPasswordLabel.Text = "Password";
            // 
            // adminPasswordTextBox
            // 
            this.adminPasswordTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.adminPasswordTextBox.Location = new System.Drawing.Point(567, 75);
            this.adminPasswordTextBox.Name = "adminPasswordTextBox";
            this.adminPasswordTextBox.PasswordChar = '*';
            this.adminPasswordTextBox.Size = new System.Drawing.Size(92, 20);
            this.adminPasswordTextBox.TabIndex = 1;
            this.adminPasswordTextBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.adminPasswordTextBox_KeyDown);
            // 
            // adminPanel
            // 
            this.adminPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.adminPanel.Controls.Add(this.deleteButton);
            this.adminPanel.Controls.Add(this.createButton);
            this.adminPanel.Controls.Add(this.updateButton);
            this.adminPanel.Controls.Add(this.recordsGrid);
            this.adminPanel.Controls.Add(this.passwordTextBox);
            this.adminPanel.Controls.Add(this.nameLabel);
            this.adminPanel.Controls.Add(this.passwordLabel);
            this.adminPanel.Controls.Add(this.formTitle);
            this.adminPanel.Controls.Add(this.nameTextBox);
            this.adminPanel.Controls.Add(this.employeeIDTextBox);
            this.adminPanel.Controls.Add(this.emailLabel);
            this.adminPanel.Controls.Add(this.employeeIDLabel);
            this.adminPanel.Controls.Add(this.emailTextBox);
            this.adminPanel.Controls.Add(this.techComboBox);
            this.adminPanel.Controls.Add(this.techLabel);
            this.adminPanel.Location = new System.Drawing.Point(463, 109);
            this.adminPanel.Margin = new System.Windows.Forms.Padding(4);
            this.adminPanel.Name = "adminPanel";
            this.adminPanel.Size = new System.Drawing.Size(674, 474);
            this.adminPanel.TabIndex = 27;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.deleteButton.Location = new System.Drawing.Point(481, 260);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(98, 28);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // createButton
            // 
            this.createButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.createButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.createButton.Location = new System.Drawing.Point(481, 226);
            this.createButton.Name = "createButton";
            this.createButton.Size = new System.Drawing.Size(98, 28);
            this.createButton.TabIndex = 6;
            this.createButton.Text = "Create";
            this.createButton.UseVisualStyleBackColor = false;
            this.createButton.Click += new System.EventHandler(this.createButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.updateButton.Location = new System.Drawing.Point(481, 79);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 28);
            this.updateButton.TabIndex = 5;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // recordsGrid
            // 
            this.recordsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.recordsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.recordsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordsGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.recordsGrid.Location = new System.Drawing.Point(9, 308);
            this.recordsGrid.Name = "recordsGrid";
            this.recordsGrid.Size = new System.Drawing.Size(657, 163);
            this.recordsGrid.TabIndex = 14;
            this.recordsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordsGrid_CellClick);
            // 
            // passwordTextBox
            // 
            this.passwordTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordTextBox.Location = new System.Drawing.Point(246, 266);
            this.passwordTextBox.Name = "passwordTextBox";
            this.passwordTextBox.PasswordChar = '*';
            this.passwordTextBox.Size = new System.Drawing.Size(192, 20);
            this.passwordTextBox.TabIndex = 4;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.nameLabel.Location = new System.Drawing.Point(96, 78);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 19);
            this.nameLabel.TabIndex = 5;
            this.nameLabel.Text = "Name";
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.passwordLabel.Location = new System.Drawing.Point(96, 265);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 19);
            this.passwordLabel.TabIndex = 21;
            this.passwordLabel.Text = "Password";
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.formTitle.Location = new System.Drawing.Point(251, 21);
            this.formTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(129, 23);
            this.formTitle.TabIndex = 7;
            this.formTitle.Text = "Admin Settings";
            // 
            // nameTextBox
            // 
            this.nameTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameTextBox.Location = new System.Drawing.Point(246, 79);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(192, 20);
            this.nameTextBox.TabIndex = 0;
            // 
            // employeeIDTextBox
            // 
            this.employeeIDTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.employeeIDTextBox.Location = new System.Drawing.Point(246, 214);
            this.employeeIDTextBox.Name = "employeeIDTextBox";
            this.employeeIDTextBox.Size = new System.Drawing.Size(192, 20);
            this.employeeIDTextBox.TabIndex = 3;
            // 
            // emailLabel
            // 
            this.emailLabel.AutoSize = true;
            this.emailLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.emailLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emailLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.emailLabel.Location = new System.Drawing.Point(96, 120);
            this.emailLabel.Name = "emailLabel";
            this.emailLabel.Size = new System.Drawing.Size(46, 19);
            this.emailLabel.TabIndex = 15;
            this.emailLabel.Text = "Email";
            // 
            // employeeIDLabel
            // 
            this.employeeIDLabel.AutoSize = true;
            this.employeeIDLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.employeeIDLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.employeeIDLabel.Location = new System.Drawing.Point(96, 213);
            this.employeeIDLabel.Name = "employeeIDLabel";
            this.employeeIDLabel.Size = new System.Drawing.Size(94, 19);
            this.employeeIDLabel.TabIndex = 19;
            this.employeeIDLabel.Text = "Employee ID";
            // 
            // emailTextBox
            // 
            this.emailTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailTextBox.Location = new System.Drawing.Point(246, 121);
            this.emailTextBox.Name = "emailTextBox";
            this.emailTextBox.Size = new System.Drawing.Size(192, 20);
            this.emailTextBox.TabIndex = 1;
            // 
            // techComboBox
            // 
            this.techComboBox.FormattingEnabled = true;
            this.techComboBox.Items.AddRange(new object[] {
            "Yes",
            "No"});
            this.techComboBox.Location = new System.Drawing.Point(246, 168);
            this.techComboBox.Name = "techComboBox";
            this.techComboBox.Size = new System.Drawing.Size(121, 21);
            this.techComboBox.TabIndex = 2;
            // 
            // techLabel
            // 
            this.techLabel.AutoSize = true;
            this.techLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.techLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.techLabel.Location = new System.Drawing.Point(96, 169);
            this.techLabel.Name = "techLabel";
            this.techLabel.Size = new System.Drawing.Size(47, 19);
            this.techLabel.TabIndex = 17;
            this.techLabel.Text = "Tech?";
            // 
            // Settings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1167, 613);
            this.Controls.Add(this.bodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Settings";
            this.Text = "Settings";
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            this.resetPanel.ResumeLayout(false);
            this.resetPanel.PerformLayout();
            this.adminPanel.ResumeLayout(false);
            this.adminPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.TextBox nameTextBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.DataGridView recordsGrid;
        private System.Windows.Forms.TextBox emailTextBox;
        private System.Windows.Forms.Label emailLabel;
        private System.Windows.Forms.ComboBox techComboBox;
        private System.Windows.Forms.Label techLabel;
        private System.Windows.Forms.TextBox employeeIDTextBox;
        private System.Windows.Forms.Label employeeIDLabel;
        private System.Windows.Forms.TextBox passwordTextBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel adminPanel;
        private System.Windows.Forms.Label adminPasswordLabel;
        private System.Windows.Forms.TextBox adminPasswordTextBox;
        private System.Windows.Forms.Button unlockButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label userlistLabel;
        private System.Windows.Forms.Label adminUsernameLabel;
        private System.Windows.Forms.TextBox adminUsernameBox;
        private System.Windows.Forms.Panel resetPanel;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Label newPasswordLabel;
        private System.Windows.Forms.TextBox confirmPasswordBox;
        private System.Windows.Forms.TextBox newPasswordBox;
        private System.Windows.Forms.Label confirmPasswordLabel;
        private System.Windows.Forms.Button unlockResetButton;
        private System.Windows.Forms.Label resetUser;
        private System.Windows.Forms.TextBox resetUserBox;
        private System.Windows.Forms.Label resetPassword;
        private System.Windows.Forms.TextBox resetPasswordBox;

    }
}