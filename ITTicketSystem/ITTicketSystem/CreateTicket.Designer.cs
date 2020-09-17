namespace ITTicketSystem
{
    partial class CreateTicket
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
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.creationDateBox = new System.Windows.Forms.TextBox();
            this.formTitle = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.recipientBox = new System.Windows.Forms.ComboBox();
            this.recipientLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.ticketBox = new System.Windows.Forms.TextBox();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.emailBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.requestorBox = new System.Windows.Forms.ComboBox();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.requestLabel = new System.Windows.Forms.Label();
            this.categoryLabel = new System.Windows.Forms.Label();
            this.requestorLabel = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.creationDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.creationDateLabel.Location = new System.Drawing.Point(58, 114);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(102, 19);
            this.creationDateLabel.TabIndex = 5;
            this.creationDateLabel.Text = "Creation Date";
            // 
            // creationDateBox
            // 
            this.creationDateBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.creationDateBox.Location = new System.Drawing.Point(170, 114);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.ReadOnly = true;
            this.creationDateBox.Size = new System.Drawing.Size(121, 20);
            this.creationDateBox.TabIndex = 3;
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.formTitle.Location = new System.Drawing.Point(513, 16);
            this.formTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(114, 23);
            this.formTitle.TabIndex = 7;
            this.formTitle.Text = "Create Ticket";
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.bodyPanel.Controls.Add(this.recipientBox);
            this.bodyPanel.Controls.Add(this.recipientLabel);
            this.bodyPanel.Controls.Add(this.submitButton);
            this.bodyPanel.Controls.Add(this.passwordBox);
            this.bodyPanel.Controls.Add(this.passwordLabel);
            this.bodyPanel.Controls.Add(this.usernameBox);
            this.bodyPanel.Controls.Add(this.usernameLabel);
            this.bodyPanel.Controls.Add(this.categoryBox);
            this.bodyPanel.Controls.Add(this.ticketBox);
            this.bodyPanel.Controls.Add(this.ticketLabel);
            this.bodyPanel.Controls.Add(this.emailBox);
            this.bodyPanel.Controls.Add(this.label1);
            this.bodyPanel.Controls.Add(this.requestorBox);
            this.bodyPanel.Controls.Add(this.commentsTextBox);
            this.bodyPanel.Controls.Add(this.commentsLabel);
            this.bodyPanel.Controls.Add(this.requestTextBox);
            this.bodyPanel.Controls.Add(this.requestLabel);
            this.bodyPanel.Controls.Add(this.categoryLabel);
            this.bodyPanel.Controls.Add(this.requestorLabel);
            this.bodyPanel.Controls.Add(this.formTitle);
            this.bodyPanel.Controls.Add(this.creationDateBox);
            this.bodyPanel.Controls.Add(this.creationDateLabel);
            this.bodyPanel.Location = new System.Drawing.Point(13, 13);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1141, 587);
            this.bodyPanel.TabIndex = 25;
            // 
            // recipientBox
            // 
            this.recipientBox.FormattingEnabled = true;
            this.recipientBox.Location = new System.Drawing.Point(680, 116);
            this.recipientBox.Name = "recipientBox";
            this.recipientBox.Size = new System.Drawing.Size(121, 21);
            this.recipientBox.TabIndex = 23;
            this.recipientBox.SelectedIndexChanged += new System.EventHandler(this.recipientBox_SelectedIndexChanged);
            // 
            // recipientLabel
            // 
            this.recipientLabel.AutoSize = true;
            this.recipientLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.recipientLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.recipientLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.recipientLabel.Location = new System.Drawing.Point(595, 115);
            this.recipientLabel.Name = "recipientLabel";
            this.recipientLabel.Size = new System.Drawing.Size(73, 19);
            this.recipientLabel.TabIndex = 24;
            this.recipientLabel.Text = "Recipient";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.submitButton.Location = new System.Drawing.Point(1001, 475);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(121, 28);
            this.submitButton.TabIndex = 9;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordBox.Location = new System.Drawing.Point(1001, 428);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(121, 20);
            this.passwordBox.TabIndex = 8;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.passwordLabel.Location = new System.Drawing.Point(889, 428);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 19);
            this.passwordLabel.TabIndex = 22;
            this.passwordLabel.Text = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameBox.Location = new System.Drawing.Point(1001, 398);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(121, 20);
            this.usernameBox.TabIndex = 7;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.usernameLabel.Location = new System.Drawing.Point(889, 398);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(93, 19);
            this.usernameLabel.TabIndex = 20;
            this.usernameLabel.Text = "Employee Id";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(414, 113);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(133, 21);
            this.categoryBox.TabIndex = 4;
            // 
            // ticketBox
            // 
            this.ticketBox.BackColor = System.Drawing.SystemColors.Control;
            this.ticketBox.Location = new System.Drawing.Point(680, 71);
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.ReadOnly = true;
            this.ticketBox.Size = new System.Drawing.Size(133, 20);
            this.ticketBox.TabIndex = 2;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ticketLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.ticketLabel.Location = new System.Drawing.Point(599, 70);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(62, 19);
            this.ticketLabel.TabIndex = 17;
            this.ticketLabel.Text = "Ticket #";
            // 
            // emailBox
            // 
            this.emailBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.emailBox.Location = new System.Drawing.Point(414, 71);
            this.emailBox.Name = "emailBox";
            this.emailBox.ReadOnly = true;
            this.emailBox.Size = new System.Drawing.Size(133, 20);
            this.emailBox.TabIndex = 1;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(333, 70);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 19);
            this.label1.TabIndex = 15;
            this.label1.Text = "Email";
            // 
            // requestorBox
            // 
            this.requestorBox.FormattingEnabled = true;
            this.requestorBox.Location = new System.Drawing.Point(170, 68);
            this.requestorBox.Name = "requestorBox";
            this.requestorBox.Size = new System.Drawing.Size(121, 21);
            this.requestorBox.Sorted = true;
            this.requestorBox.TabIndex = 0;
            this.requestorBox.SelectedIndexChanged += new System.EventHandler(this.requestorBox_SelectedIndexChanged);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.commentsTextBox.Location = new System.Drawing.Point(180, 289);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox.Size = new System.Drawing.Size(482, 229);
            this.commentsTextBox.TabIndex = 6;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.commentsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.commentsLabel.Location = new System.Drawing.Point(58, 287);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(81, 19);
            this.commentsLabel.TabIndex = 12;
            this.commentsLabel.Text = "Comments";
            // 
            // requestTextBox
            // 
            this.requestTextBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.requestTextBox.Location = new System.Drawing.Point(180, 202);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestTextBox.Size = new System.Drawing.Size(482, 43);
            this.requestTextBox.TabIndex = 5;
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.requestLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.requestLabel.Location = new System.Drawing.Point(58, 202);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(64, 19);
            this.requestLabel.TabIndex = 10;
            this.requestLabel.Text = "Request";
            // 
            // categoryLabel
            // 
            this.categoryLabel.AutoSize = true;
            this.categoryLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.categoryLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.categoryLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.categoryLabel.Location = new System.Drawing.Point(333, 115);
            this.categoryLabel.Name = "categoryLabel";
            this.categoryLabel.Size = new System.Drawing.Size(70, 19);
            this.categoryLabel.TabIndex = 9;
            this.categoryLabel.Text = "Category";
            // 
            // requestorLabel
            // 
            this.requestorLabel.AutoSize = true;
            this.requestorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.requestorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.requestorLabel.Location = new System.Drawing.Point(58, 67);
            this.requestorLabel.Name = "requestorLabel";
            this.requestorLabel.Size = new System.Drawing.Size(79, 19);
            this.requestorLabel.TabIndex = 8;
            this.requestorLabel.Text = "Requestor";
            // 
            // CreateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1167, 613);
            this.Controls.Add(this.bodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CreateTicket";
            this.Text = "CreateTicket";
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.TextBox creationDateBox;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label requestorLabel;
        private System.Windows.Forms.Label categoryLabel;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.TextBox ticketBox;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.TextBox emailBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox requestorBox;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.ComboBox recipientBox;
        private System.Windows.Forms.Label recipientLabel;
    }
}