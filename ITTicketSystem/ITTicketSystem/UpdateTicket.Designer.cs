namespace ITTicketSystem
{
    partial class UpdateTicket
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.statusBox = new System.Windows.Forms.ComboBox();
            this.statusLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.ComboBox();
            this.label2 = new System.Windows.Forms.Label();
            this.techBox = new System.Windows.Forms.ComboBox();
            this.updatorLabel = new System.Windows.Forms.Label();
            this.submitButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.usernameLabel = new System.Windows.Forms.Label();
            this.updateBox = new System.Windows.Forms.TextBox();
            this.updateLabel = new System.Windows.Forms.Label();
            this.modifiedBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.ticketBox = new System.Windows.Forms.TextBox();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.requestorBox = new System.Windows.Forms.TextBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.commentsTextBox = new System.Windows.Forms.TextBox();
            this.commentsLabel = new System.Windows.Forms.Label();
            this.requestTextBox = new System.Windows.Forms.TextBox();
            this.requestLabel = new System.Windows.Forms.Label();
            this.requestorLabel = new System.Windows.Forms.Label();
            this.creationDateBox = new System.Windows.Forms.TextBox();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.formTitle = new System.Windows.Forms.Label();
            this.bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.bodyPanel.Controls.Add(this.deleteButton);
            this.bodyPanel.Controls.Add(this.statusBox);
            this.bodyPanel.Controls.Add(this.statusLabel);
            this.bodyPanel.Controls.Add(this.categoryBox);
            this.bodyPanel.Controls.Add(this.label2);
            this.bodyPanel.Controls.Add(this.techBox);
            this.bodyPanel.Controls.Add(this.updatorLabel);
            this.bodyPanel.Controls.Add(this.submitButton);
            this.bodyPanel.Controls.Add(this.passwordBox);
            this.bodyPanel.Controls.Add(this.passwordLabel);
            this.bodyPanel.Controls.Add(this.usernameBox);
            this.bodyPanel.Controls.Add(this.usernameLabel);
            this.bodyPanel.Controls.Add(this.updateBox);
            this.bodyPanel.Controls.Add(this.updateLabel);
            this.bodyPanel.Controls.Add(this.modifiedBox);
            this.bodyPanel.Controls.Add(this.label1);
            this.bodyPanel.Controls.Add(this.ticketBox);
            this.bodyPanel.Controls.Add(this.ticketLabel);
            this.bodyPanel.Controls.Add(this.requestorBox);
            this.bodyPanel.Controls.Add(this.dataGridView);
            this.bodyPanel.Controls.Add(this.commentsTextBox);
            this.bodyPanel.Controls.Add(this.commentsLabel);
            this.bodyPanel.Controls.Add(this.requestTextBox);
            this.bodyPanel.Controls.Add(this.requestLabel);
            this.bodyPanel.Controls.Add(this.requestorLabel);
            this.bodyPanel.Controls.Add(this.creationDateBox);
            this.bodyPanel.Controls.Add(this.creationDateLabel);
            this.bodyPanel.Controls.Add(this.formTitle);
            this.bodyPanel.Location = new System.Drawing.Point(13, 13);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1141, 587);
            this.bodyPanel.TabIndex = 26;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.deleteButton.Location = new System.Drawing.Point(42, 537);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(94, 28);
            this.deleteButton.TabIndex = 7;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // statusBox
            // 
            this.statusBox.FormattingEnabled = true;
            this.statusBox.Items.AddRange(new object[] {
            "Open",
            "Closed"});
            this.statusBox.Location = new System.Drawing.Point(390, 127);
            this.statusBox.Name = "statusBox";
            this.statusBox.Size = new System.Drawing.Size(114, 21);
            this.statusBox.TabIndex = 1;
            // 
            // statusLabel
            // 
            this.statusLabel.AutoSize = true;
            this.statusLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.statusLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.statusLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.statusLabel.Location = new System.Drawing.Point(268, 126);
            this.statusLabel.Name = "statusLabel";
            this.statusLabel.Size = new System.Drawing.Size(52, 19);
            this.statusLabel.TabIndex = 66;
            this.statusLabel.Text = "Status";
            // 
            // categoryBox
            // 
            this.categoryBox.FormattingEnabled = true;
            this.categoryBox.Location = new System.Drawing.Point(139, 126);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.Size = new System.Drawing.Size(113, 21);
            this.categoryBox.TabIndex = 0;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(16, 125);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 64;
            this.label2.Text = "Category";
            // 
            // techBox
            // 
            this.techBox.FormattingEnabled = true;
            this.techBox.Location = new System.Drawing.Point(151, 424);
            this.techBox.Name = "techBox";
            this.techBox.Size = new System.Drawing.Size(121, 21);
            this.techBox.Sorted = true;
            this.techBox.TabIndex = 3;
            this.techBox.SelectedIndexChanged += new System.EventHandler(this.techBox_SelectedIndexChanged);
            // 
            // updatorLabel
            // 
            this.updatorLabel.AutoSize = true;
            this.updatorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.updatorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.updatorLabel.Location = new System.Drawing.Point(39, 423);
            this.updatorLabel.Name = "updatorLabel";
            this.updatorLabel.Size = new System.Drawing.Size(81, 19);
            this.updatorLabel.TabIndex = 62;
            this.updatorLabel.Text = "Technician";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.submitButton.Location = new System.Drawing.Point(177, 537);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(94, 28);
            this.submitButton.TabIndex = 6;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordBox.Location = new System.Drawing.Point(150, 493);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(121, 20);
            this.passwordBox.TabIndex = 5;
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.passwordLabel.Location = new System.Drawing.Point(38, 493);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 19);
            this.passwordLabel.TabIndex = 59;
            this.passwordLabel.Text = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameBox.Location = new System.Drawing.Point(150, 463);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(121, 20);
            this.usernameBox.TabIndex = 4;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.usernameLabel.Location = new System.Drawing.Point(38, 463);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(93, 19);
            this.usernameLabel.TabIndex = 57;
            this.usernameLabel.Text = "Employee Id";
            // 
            // updateBox
            // 
            this.updateBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBox.Location = new System.Drawing.Point(31, 246);
            this.updateBox.Multiline = true;
            this.updateBox.Name = "updateBox";
            this.updateBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.updateBox.Size = new System.Drawing.Size(284, 160);
            this.updateBox.TabIndex = 2;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.updateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.updateLabel.Location = new System.Drawing.Point(108, 214);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(135, 19);
            this.updateLabel.TabIndex = 55;
            this.updateLabel.Text = "Update Comments";
            // 
            // modifiedBox
            // 
            this.modifiedBox.BackColor = System.Drawing.SystemColors.Menu;
            this.modifiedBox.Location = new System.Drawing.Point(390, 90);
            this.modifiedBox.Name = "modifiedBox";
            this.modifiedBox.ReadOnly = true;
            this.modifiedBox.Size = new System.Drawing.Size(114, 20);
            this.modifiedBox.TabIndex = 54;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(268, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 53;
            this.label1.Text = "Last Modified";
            // 
            // ticketBox
            // 
            this.ticketBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ticketBox.Location = new System.Drawing.Point(390, 59);
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.ReadOnly = true;
            this.ticketBox.Size = new System.Drawing.Size(114, 20);
            this.ticketBox.TabIndex = 52;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ticketLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.ticketLabel.Location = new System.Drawing.Point(268, 59);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(62, 19);
            this.ticketLabel.TabIndex = 51;
            this.ticketLabel.Text = "Ticket #";
            // 
            // requestorBox
            // 
            this.requestorBox.BackColor = System.Drawing.SystemColors.Menu;
            this.requestorBox.Location = new System.Drawing.Point(138, 59);
            this.requestorBox.Name = "requestorBox";
            this.requestorBox.ReadOnly = true;
            this.requestorBox.Size = new System.Drawing.Size(114, 20);
            this.requestorBox.TabIndex = 50;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(703, 59);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(435, 506);
            this.dataGridView.TabIndex = 49;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.commentsTextBox.Location = new System.Drawing.Point(413, 246);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox.Size = new System.Drawing.Size(284, 319);
            this.commentsTextBox.TabIndex = 48;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.commentsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.commentsLabel.Location = new System.Drawing.Point(512, 214);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(81, 19);
            this.commentsLabel.TabIndex = 47;
            this.commentsLabel.Text = "Comments";
            // 
            // requestTextBox
            // 
            this.requestTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.requestTextBox.Location = new System.Drawing.Point(138, 164);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestTextBox.Size = new System.Drawing.Size(482, 43);
            this.requestTextBox.TabIndex = 46;
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.requestLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.requestLabel.Location = new System.Drawing.Point(16, 163);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(64, 19);
            this.requestLabel.TabIndex = 45;
            this.requestLabel.Text = "Request";
            // 
            // requestorLabel
            // 
            this.requestorLabel.AutoSize = true;
            this.requestorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.requestorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.requestorLabel.Location = new System.Drawing.Point(16, 59);
            this.requestorLabel.Name = "requestorLabel";
            this.requestorLabel.Size = new System.Drawing.Size(79, 19);
            this.requestorLabel.TabIndex = 44;
            this.requestorLabel.Text = "Requestor";
            // 
            // creationDateBox
            // 
            this.creationDateBox.BackColor = System.Drawing.SystemColors.Menu;
            this.creationDateBox.Location = new System.Drawing.Point(138, 90);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.ReadOnly = true;
            this.creationDateBox.Size = new System.Drawing.Size(114, 20);
            this.creationDateBox.TabIndex = 42;
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.creationDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.creationDateLabel.Location = new System.Drawing.Point(16, 90);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(102, 19);
            this.creationDateLabel.TabIndex = 41;
            this.creationDateLabel.Text = "Creation Date";
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.formTitle.Location = new System.Drawing.Point(511, 17);
            this.formTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(205, 23);
            this.formTitle.TabIndex = 7;
            this.formTitle.Text = "Technician Update Ticket";
            // 
            // UpdateTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1167, 613);
            this.Controls.Add(this.bodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "UpdateTicket";
            this.Text = "UpdateTicket";
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox techBox;
        private System.Windows.Forms.Label updatorLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.TextBox updateBox;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.TextBox modifiedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ticketBox;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.TextBox requestorBox;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label requestorLabel;
        private System.Windows.Forms.TextBox creationDateBox;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.ComboBox categoryBox;
        private System.Windows.Forms.ComboBox statusBox;
        private System.Windows.Forms.Label statusLabel;
        private System.Windows.Forms.Button deleteButton;

    }
}