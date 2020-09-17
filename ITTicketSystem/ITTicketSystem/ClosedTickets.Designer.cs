namespace ITTicketSystem
{
    partial class ClosedTickets
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
            this.closedBox = new System.Windows.Forms.TextBox();
            this.closedLabel = new System.Windows.Forms.Label();
            this.categoryBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.finishedBox = new System.Windows.Forms.TextBox();
            this.finishedLabel = new System.Windows.Forms.Label();
            this.ticketBox = new System.Windows.Forms.TextBox();
            this.ticketLabel = new System.Windows.Forms.Label();
            this.requestorBox = new System.Windows.Forms.TextBox();
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
            this.bodyPanel.Controls.Add(this.closedBox);
            this.bodyPanel.Controls.Add(this.closedLabel);
            this.bodyPanel.Controls.Add(this.categoryBox);
            this.bodyPanel.Controls.Add(this.label2);
            this.bodyPanel.Controls.Add(this.dataGridView);
            this.bodyPanel.Controls.Add(this.finishedBox);
            this.bodyPanel.Controls.Add(this.finishedLabel);
            this.bodyPanel.Controls.Add(this.ticketBox);
            this.bodyPanel.Controls.Add(this.ticketLabel);
            this.bodyPanel.Controls.Add(this.requestorBox);
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
            // closedBox
            // 
            this.closedBox.BackColor = System.Drawing.SystemColors.Menu;
            this.closedBox.Location = new System.Drawing.Point(381, 112);
            this.closedBox.Name = "closedBox";
            this.closedBox.ReadOnly = true;
            this.closedBox.Size = new System.Drawing.Size(98, 20);
            this.closedBox.TabIndex = 44;
            // 
            // closedLabel
            // 
            this.closedLabel.AutoSize = true;
            this.closedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.closedLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.closedLabel.Location = new System.Drawing.Point(259, 112);
            this.closedLabel.Name = "closedLabel";
            this.closedLabel.Size = new System.Drawing.Size(74, 19);
            this.closedLabel.TabIndex = 43;
            this.closedLabel.Text = "Closed By";
            // 
            // categoryBox
            // 
            this.categoryBox.BackColor = System.Drawing.SystemColors.Menu;
            this.categoryBox.Location = new System.Drawing.Point(129, 110);
            this.categoryBox.Name = "categoryBox";
            this.categoryBox.ReadOnly = true;
            this.categoryBox.Size = new System.Drawing.Size(98, 20);
            this.categoryBox.TabIndex = 42;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.label2.Location = new System.Drawing.Point(7, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(70, 19);
            this.label2.TabIndex = 41;
            this.label2.Text = "Category";
            // 
            // dataGridView
            // 
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(645, 54);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.RowHeadersVisible = false;
            this.dataGridView.Size = new System.Drawing.Size(469, 506);
            this.dataGridView.TabIndex = 32;
            this.dataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // finishedBox
            // 
            this.finishedBox.BackColor = System.Drawing.SystemColors.Menu;
            this.finishedBox.Location = new System.Drawing.Point(381, 83);
            this.finishedBox.Name = "finishedBox";
            this.finishedBox.ReadOnly = true;
            this.finishedBox.Size = new System.Drawing.Size(98, 20);
            this.finishedBox.TabIndex = 31;
            // 
            // finishedLabel
            // 
            this.finishedLabel.AutoSize = true;
            this.finishedLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.finishedLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.finishedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.finishedLabel.Location = new System.Drawing.Point(259, 83);
            this.finishedLabel.Name = "finishedLabel";
            this.finishedLabel.Size = new System.Drawing.Size(101, 19);
            this.finishedLabel.TabIndex = 30;
            this.finishedLabel.Text = "Finished Date";
            // 
            // ticketBox
            // 
            this.ticketBox.BackColor = System.Drawing.SystemColors.Menu;
            this.ticketBox.Location = new System.Drawing.Point(381, 54);
            this.ticketBox.Name = "ticketBox";
            this.ticketBox.ReadOnly = true;
            this.ticketBox.Size = new System.Drawing.Size(98, 20);
            this.ticketBox.TabIndex = 29;
            // 
            // ticketLabel
            // 
            this.ticketLabel.AutoSize = true;
            this.ticketLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.ticketLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ticketLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.ticketLabel.Location = new System.Drawing.Point(259, 54);
            this.ticketLabel.Name = "ticketLabel";
            this.ticketLabel.Size = new System.Drawing.Size(62, 19);
            this.ticketLabel.TabIndex = 28;
            this.ticketLabel.Text = "Ticket #";
            // 
            // requestorBox
            // 
            this.requestorBox.BackColor = System.Drawing.SystemColors.Menu;
            this.requestorBox.Location = new System.Drawing.Point(129, 54);
            this.requestorBox.Name = "requestorBox";
            this.requestorBox.ReadOnly = true;
            this.requestorBox.Size = new System.Drawing.Size(98, 20);
            this.requestorBox.TabIndex = 27;
            // 
            // commentsTextBox
            // 
            this.commentsTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.commentsTextBox.Location = new System.Drawing.Point(129, 225);
            this.commentsTextBox.Multiline = true;
            this.commentsTextBox.Name = "commentsTextBox";
            this.commentsTextBox.ReadOnly = true;
            this.commentsTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.commentsTextBox.Size = new System.Drawing.Size(284, 319);
            this.commentsTextBox.TabIndex = 26;
            // 
            // commentsLabel
            // 
            this.commentsLabel.AutoSize = true;
            this.commentsLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.commentsLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.commentsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.commentsLabel.Location = new System.Drawing.Point(7, 225);
            this.commentsLabel.Name = "commentsLabel";
            this.commentsLabel.Size = new System.Drawing.Size(81, 19);
            this.commentsLabel.TabIndex = 25;
            this.commentsLabel.Text = "Comments";
            // 
            // requestTextBox
            // 
            this.requestTextBox.BackColor = System.Drawing.SystemColors.Menu;
            this.requestTextBox.Location = new System.Drawing.Point(129, 155);
            this.requestTextBox.Multiline = true;
            this.requestTextBox.Name = "requestTextBox";
            this.requestTextBox.ReadOnly = true;
            this.requestTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.requestTextBox.Size = new System.Drawing.Size(482, 43);
            this.requestTextBox.TabIndex = 24;
            // 
            // requestLabel
            // 
            this.requestLabel.AutoSize = true;
            this.requestLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.requestLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.requestLabel.Location = new System.Drawing.Point(7, 154);
            this.requestLabel.Name = "requestLabel";
            this.requestLabel.Size = new System.Drawing.Size(64, 19);
            this.requestLabel.TabIndex = 23;
            this.requestLabel.Text = "Request";
            // 
            // requestorLabel
            // 
            this.requestorLabel.AutoSize = true;
            this.requestorLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.requestorLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.requestorLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.requestorLabel.Location = new System.Drawing.Point(7, 54);
            this.requestorLabel.Name = "requestorLabel";
            this.requestorLabel.Size = new System.Drawing.Size(79, 19);
            this.requestorLabel.TabIndex = 22;
            this.requestorLabel.Text = "Requestor";
            // 
            // creationDateBox
            // 
            this.creationDateBox.BackColor = System.Drawing.SystemColors.Menu;
            this.creationDateBox.Location = new System.Drawing.Point(129, 82);
            this.creationDateBox.Name = "creationDateBox";
            this.creationDateBox.ReadOnly = true;
            this.creationDateBox.Size = new System.Drawing.Size(98, 20);
            this.creationDateBox.TabIndex = 21;
            // 
            // creationDateLabel
            // 
            this.creationDateLabel.AutoSize = true;
            this.creationDateLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.creationDateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creationDateLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.creationDateLabel.Location = new System.Drawing.Point(7, 82);
            this.creationDateLabel.Name = "creationDateLabel";
            this.creationDateLabel.Size = new System.Drawing.Size(102, 19);
            this.creationDateLabel.TabIndex = 20;
            this.creationDateLabel.Text = "Creation Date";
            // 
            // formTitle
            // 
            this.formTitle.AutoSize = true;
            this.formTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.formTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.formTitle.Location = new System.Drawing.Point(513, 16);
            this.formTitle.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.formTitle.Name = "formTitle";
            this.formTitle.Size = new System.Drawing.Size(122, 23);
            this.formTitle.TabIndex = 7;
            this.formTitle.Text = "Closed Tickets";
            // 
            // ClosedTickets
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1167, 613);
            this.Controls.Add(this.bodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ClosedTickets";
            this.Text = "ClosedTickets";
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label formTitle;
        private System.Windows.Forms.TextBox finishedBox;
        private System.Windows.Forms.Label finishedLabel;
        private System.Windows.Forms.TextBox ticketBox;
        private System.Windows.Forms.Label ticketLabel;
        private System.Windows.Forms.TextBox requestorBox;
        private System.Windows.Forms.TextBox commentsTextBox;
        private System.Windows.Forms.Label commentsLabel;
        private System.Windows.Forms.TextBox requestTextBox;
        private System.Windows.Forms.Label requestLabel;
        private System.Windows.Forms.Label requestorLabel;
        private System.Windows.Forms.TextBox creationDateBox;
        private System.Windows.Forms.Label creationDateLabel;
        private System.Windows.Forms.DataGridView dataGridView;
        private System.Windows.Forms.TextBox categoryBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox closedBox;
        private System.Windows.Forms.Label closedLabel;

    }
}