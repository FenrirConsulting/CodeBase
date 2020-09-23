namespace ITTicketSystem
{
    partial class OpenTicket
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
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.updatorBox = new System.Windows.Forms.ComboBox();
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
            this.formTitle = new System.Windows.Forms.Label();
            this.creationDateBox = new System.Windows.Forms.TextBox();
            this.creationDateLabel = new System.Windows.Forms.Label();
            this.ticketMonitorButton = new System.Windows.Forms.Button();
            this.bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.bodyPanel.Controls.Add(this.ticketMonitorButton);
            this.bodyPanel.Controls.Add(this.categoryBox);
            this.bodyPanel.Controls.Add(this.label2);
            this.bodyPanel.Controls.Add(this.updatorBox);
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
            this.bodyPanel.Controls.Add(this.formTitle);
            this.bodyPanel.Controls.Add(this.creationDateBox);
            this.bodyPanel.Controls.Add(this.creationDateLabel);
            this.bodyPanel.Location = new System.Drawing.Point(13, 13);
            this.bodyPanel.Margin = new System.Windows.Forms.Padding(4);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(1141, 587);
            this.bodyPanel.TabIndex = 26;
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.SystemColors.Menu;
            this.categoryBox.Location = new System.Drawing.Point(140, 113);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.ReadOnly = true;
            this.categoryBox.Size = new System.Drawing.Size(114, 20);
            this.categoryBox.TabIndex = 40;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(18, 113);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 39;
            this.label2.Text = "Category";
            // 
            // updatorBox
            // 
            this.updatorBox.FormattingEnabled = true;
            this.updatorBox.Location = new System.Drawing.Point(153, 421);
            this.updatorBox.Name = "updatorBox";
            this.updatorBox.Size = new System.Drawing.Size(121, 21);
            this.updatorBox.Sorted = true;
            this.updatorBox.TabIndex = 1;
            this.updatorBox.SelectedIndexChanged += new System.EventHandler(this.updatorBox_SelectedIndexChanged);
            // 
            // updatorLabel
            // 
            this.updatorLabel.AutoSize = true;
            this.updatorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.updatorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updatorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.updatorLabel.Location = new System.Drawing.Point(41, 420);
            this.updatorLabel.Name = "updatorLabel";
            this.updatorLabel.Size = new System.Drawing.Size(66, 19);
            this.updatorLabel.TabIndex = 37;
            this.updatorLabel.Text = "Updator";
            // 
            // submitButton
            // 
            this.submitButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.submitButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.submitButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.submitButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.submitButton.Location = new System.Drawing.Point(152, 537);
            this.submitButton.Name = "submitButton";
            this.submitButton.Size = new System.Drawing.Size(121, 28);
            this.submitButton.TabIndex = 4;
            this.submitButton.Text = "Submit";
            this.submitButton.UseVisualStyleBackColor = false;
            this.submitButton.Click += new System.EventHandler(this.submitButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.passwordBox.Location = new System.Drawing.Point(152, 490);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(121, 20);
            this.passwordBox.TabIndex = 3;
            this.passwordBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.passwordBox_KeyDown);
            // 
            // passwordLabel
            // 
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.passwordLabel.Location = new System.Drawing.Point(40, 490);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(74, 19);
            this.passwordLabel.TabIndex = 34;
            this.passwordLabel.Text = "Password";
            // 
            // usernameBox
            // 
            this.usernameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.usernameBox.Location = new System.Drawing.Point(152, 460);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(121, 20);
            this.usernameBox.TabIndex = 2;
            // 
            // usernameLabel
            // 
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.usernameLabel.Location = new System.Drawing.Point(40, 460);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(93, 19);
            this.usernameLabel.TabIndex = 32;
            this.usernameLabel.Text = "Employee Id";
            // 
            // updateBox
            // 
            this.updateBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.updateBox.Location = new System.Drawing.Point(33, 243);
            this.updateBox.Multiline = true;
            this.updateBox.Name = "updateBox";
            this.updateBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.updateBox.Size = new System.Drawing.Size(284, 160);
            this.updateBox.TabIndex = 0;
            // 
            // updateLabel
            // 
            this.updateLabel.AutoSize = true;
            this.updateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.updateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.updateLabel.Location = new System.Drawing.Point(110, 211);
            this.updateLabel.Name = "updateLabel";
            this.updateLabel.Size = new System.Drawing.Size(135, 19);
            this.updateLabel.TabIndex = 20;
            this.updateLabel.Text = "Update Comments";
            // 
            // modifiedBox
            // 
            this.modifiedBox.BackColor = System.Drawing.SystemColors.Menu;
            this.modifiedBox.Location = new System.Drawing.Point(392, 87);
            this.modifiedBox.Name = "modifiedBox";
            this.modifiedBox.ReadOnly = true;
            this.modifiedBox.Size = new System.Drawing.Size(114, 20);
            this.modifiedBox.TabIndex = 19;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.label1.Location = new System.Drawing.Point(270, 87);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(102, 19);
            this.label1.TabIndex = 18;
            this.label1.Text = "Last Modified";
            // 
            // ticketBox
            // 
            this.ticketBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ticketBox.Location = new System.Drawing.Point(392, 56);
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.ReadOnly = true;
            this.ticketBox.Size = new System.Drawing.Size(114, 20);
            this.ticketBox.TabIndex = 17;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ticketLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.ticketLabel.Location = new System.Drawing.Point(270, 56);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(62, 19);
            this.ticketLabel.TabIndex = 16;
            this.ticketLabel.Text = "Ticket #";
            // 
            // requestorBox
            // 
            this.requestorBox.BackColor = System.Drawing.SystemColors.Menu;
            this.requestorBox.Location = new System.Drawing.Point(140, 56);
            this.requestorBox.Name = "requestorBox";
            this.requestorBox.ReadOnly = true;
            this.requestorBox.Size = new System.Drawing.Size(114, 20);
            this.requestorBox.TabIndex = 15;
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(719, 56);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(407, 506);
            this.dataGridView.TabIndex = 14;
            this.dataGridView.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellClick);
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.commentsTextBox.Location = new System.Drawing.Point(415, 243);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ReadOnly = true;
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox.Size = new System.Drawing.Size(284, 319);
            this.commentsTextBox.TabIndex = 13;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.commentsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.commentsLabel.Location = new System.Drawing.Point(514, 211);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(81, 19);
            this.commentsLabel.TabIndex = 12;
            this.commentsLabel.Text = "Comments";
            // 
            // requestTextBox
            // 
            this.requestTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.requestTextBox.Location = new System.Drawing.Point(140, 148);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.ReadOnly = true;
            this.requestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestTextBox.Size = new System.Drawing.Size(482, 43);
            this.requestTextBox.TabIndex = 11;
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.requestLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.requestLabel.Location = new System.Drawing.Point(18, 147);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(64, 19);
            this.requestLabel.TabIndex = 10;
            this.requestLabel.Text = "Request";
            // 
            // requestorLabel
            // 
            this.requestorLabel.AutoSize = true;
            this.requestorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.requestorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.requestorLabel.Location = new System.Drawing.Point(18, 56);
            this.requestorLabel.Name = "requestorLabel";
            this.requestorLabel.Size = new System.Drawing.Size(79, 19);
            this.requestorLabel.TabIndex = 8;
            this.requestorLabel.Text = "Requestor";
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.formTitle.Location = new System.Drawing.Point(514, 16);
            this.formTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(112, 23);
            this.formTitle.TabIndex = 7;
            this.formTitle.Text = "Open Tickets";
            // 
            // creationDateBox
            // 
            this.creationDateBox.BackColor = System.Drawing.SystemColors.Menu;
            this.creationDateBox.Location = new System.Drawing.Point(140, 87);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.ReadOnly = true;
            this.creationDateBox.Size = new System.Drawing.Size(114, 20);
            this.creationDateBox.TabIndex = 6;
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.creationDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.creationDateLabel.Location = new System.Drawing.Point(18, 87);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(102, 19);
            this.creationDateLabel.TabIndex = 5;
            this.creationDateLabel.Text = "Creation Date";
            // 
            // ticketMonitorButton
            // 
            this.ticketMonitorButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.ticketMonitorButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.ticketMonitorButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketMonitorButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.ticketMonitorButton.Location = new System.Drawing.Point(1005, 11);
            this.ticketMonitorButton.Name = "ticketMonitorButton";
            this.ticketMonitorButton.Size = new System.Drawing.Size(121, 28);
            this.ticketMonitorButton.TabIndex = 41;
            this.ticketMonitorButton.Text = "Ticket Monitor";
            this.ticketMonitorButton.UseVisualStyleBackColor = false;
            this.ticketMonitorButton.Click += new System.EventHandler(this.ticketMonitorButton_Click);
            // 
            // OpenTicket
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1167, 613);
            this.Controls.Add(this.bodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "OpenTicket";
            this.Text = "OpenTicket";
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label requestorLabel;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.TextBox creationDateBox;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox modifiedBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ticketBox;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.TextBox requestorBox;
        private System.Windows.Forms.TextBox updateBox;
        private System.Windows.Forms.Label updateLabel;
        private System.Windows.Forms.Button submitButton;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.ComboBox updatorBox;
        private System.Windows.Forms.Label updatorLabel;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ticketMonitorButton;

    }
}