namespace MorningRecap
{
    partial class Records
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
            this.spUpdateButton = new System.Windows.Forms.Button();
            this.createlistButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.valueLabel = new System.Windows.Forms.Label();
            this.valueBox = new System.Windows.Forms.TextBox();
            this.nameLabel = new System.Windows.Forms.Label();
            this.nameBox = new System.Windows.Forms.TextBox();
            this.searchButton = new System.Windows.Forms.Button();
            this.tableLabel = new System.Windows.Forms.Label();
            this.recordsGrid = new System.Windows.Forms.DataGridView();
            this.tableList = new System.Windows.Forms.ComboBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.Button();
            this.deleteList = new System.Windows.Forms.Button();
            this.bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.bodyPanel.Controls.Add(this.deleteList);
            this.bodyPanel.Controls.Add(this.spUpdateButton);
            this.bodyPanel.Controls.Add(this.createlistButton);
            this.bodyPanel.Controls.Add(this.updateButton);
            this.bodyPanel.Controls.Add(this.valueLabel);
            this.bodyPanel.Controls.Add(this.valueBox);
            this.bodyPanel.Controls.Add(this.nameLabel);
            this.bodyPanel.Controls.Add(this.nameBox);
            this.bodyPanel.Controls.Add(this.searchButton);
            this.bodyPanel.Controls.Add(this.tableLabel);
            this.bodyPanel.Controls.Add(this.recordsGrid);
            this.bodyPanel.Controls.Add(this.tableList);
            this.bodyPanel.Location = new System.Drawing.Point(40, 72);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(842, 462);
            this.bodyPanel.TabIndex = 0;
            // 
            // spUpdateButton
            // 
            this.spUpdateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.spUpdateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.spUpdateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.spUpdateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.spUpdateButton.Location = new System.Drawing.Point(228, 320);
            this.spUpdateButton.Name = "spUpdateButton";
            this.spUpdateButton.Size = new System.Drawing.Size(175, 28);
            this.spUpdateButton.TabIndex = 15;
            this.spUpdateButton.Text = "Update Sharepoint";
            this.spUpdateButton.UseVisualStyleBackColor = false;
            this.spUpdateButton.Click += new System.EventHandler(this.spUpdateButton_Click);
            // 
            // createlistButton
            // 
            this.createlistButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.createlistButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.createlistButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createlistButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.createlistButton.Location = new System.Drawing.Point(194, 137);
            this.createlistButton.Name = "createlistButton";
            this.createlistButton.Size = new System.Drawing.Size(98, 28);
            this.createlistButton.TabIndex = 14;
            this.createlistButton.Text = "Create List";
            this.createlistButton.UseVisualStyleBackColor = false;
            this.createlistButton.Click += new System.EventHandler(this.createlistButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.updateButton.Location = new System.Drawing.Point(124, 320);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(98, 28);
            this.updateButton.TabIndex = 13;
            this.updateButton.Text = "Update";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // valueLabel
            // 
            this.valueLabel.AutoSize = true;
            this.valueLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.valueLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.valueLabel.Location = new System.Drawing.Point(27, 265);
            this.valueLabel.Name = "valueLabel";
            this.valueLabel.Size = new System.Drawing.Size(46, 19);
            this.valueLabel.TabIndex = 11;
            this.valueLabel.Text = "Value";
            // 
            // valueBox
            // 
            this.valueBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.valueBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.valueBox.Location = new System.Drawing.Point(155, 265);
            this.valueBox.Name = "valueBox";
            this.valueBox.Size = new System.Drawing.Size(137, 27);
            this.valueBox.TabIndex = 12;
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.nameLabel.Location = new System.Drawing.Point(27, 209);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(49, 19);
            this.nameLabel.TabIndex = 9;
            this.nameLabel.Text = "Name";
            // 
            // nameBox
            // 
            this.nameBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.nameBox.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameBox.Location = new System.Drawing.Point(155, 209);
            this.nameBox.Name = "nameBox";
            this.nameBox.Size = new System.Drawing.Size(137, 27);
            this.nameBox.TabIndex = 10;
            // 
            // searchButton
            // 
            this.searchButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.searchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.searchButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.searchButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.searchButton.Location = new System.Drawing.Point(31, 137);
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(98, 28);
            this.searchButton.TabIndex = 3;
            this.searchButton.Text = "Search";
            this.searchButton.UseVisualStyleBackColor = false;
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
            // 
            // tableLabel
            // 
            this.tableLabel.AutoSize = true;
            this.tableLabel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.tableLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tableLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(132)))), ((int)(((byte)(154)))), ((int)(((byte)(156)))));
            this.tableLabel.Location = new System.Drawing.Point(27, 63);
            this.tableLabel.Name = "tableLabel";
            this.tableLabel.Size = new System.Drawing.Size(128, 19);
            this.tableLabel.TabIndex = 2;
            this.tableLabel.Text = "Records Category";
            this.tableLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // recordsGrid
            // 
            this.recordsGrid.BackgroundColor = System.Drawing.Color.FromArgb(((int)(((byte)(33)))), ((int)(((byte)(37)))), ((int)(((byte)(43)))));
            this.recordsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.recordsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.recordsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.recordsGrid.GridColor = System.Drawing.SystemColors.ControlText;
            this.recordsGrid.Location = new System.Drawing.Point(440, 18);
            this.recordsGrid.Name = "recordsGrid";
            this.recordsGrid.Size = new System.Drawing.Size(375, 441);
            this.recordsGrid.TabIndex = 1;
            this.recordsGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.recordsGrid_CellClick);
            // 
            // tableList
            // 
            this.tableList.FormattingEnabled = true;
            this.tableList.Items.AddRange(new object[] {
            "CPSTable",
            "DPSTable",
            "ICTable",
            "InboundTable",
            "MPSTable",
            "Notes",
            "OffsiteTable",
            "RxTable",
            "RepackTable",
            "ShippingTable"});
            this.tableList.Location = new System.Drawing.Point(31, 96);
            this.tableList.Name = "tableList";
            this.tableList.Size = new System.Drawing.Size(124, 21);
            this.tableList.TabIndex = 0;
            // 
            // titleLabel
            // 
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.titleLabel.Location = new System.Drawing.Point(40, 46);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(131, 23);
            this.titleLabel.TabIndex = 4;
            this.titleLabel.Text = "Records Search";
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.closeButton.Location = new System.Drawing.Point(40, 540);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(121, 28);
            this.closeButton.TabIndex = 5;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseVisualStyleBackColor = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // deleteList
            // 
            this.deleteList.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.deleteList.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteList.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteList.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.deleteList.Location = new System.Drawing.Point(305, 137);
            this.deleteList.Name = "deleteList";
            this.deleteList.Size = new System.Drawing.Size(98, 28);
            this.deleteList.TabIndex = 16;
            this.deleteList.Text = "Delete List";
            this.deleteList.UseVisualStyleBackColor = false;
            this.deleteList.Click += new System.EventHandler(this.deleteList_Click);
            // 
            // Records
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(894, 897);
            this.Controls.Add(this.closeButton);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.bodyPanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Records";
            this.Text = "Records";
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.recordsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.ComboBox tableList;
        private System.Windows.Forms.DataGridView recordsGrid;
        private System.Windows.Forms.Label tableLabel;
        private System.Windows.Forms.Button searchButton;
        private System.Windows.Forms.Label valueLabel;
        private System.Windows.Forms.TextBox valueBox;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.TextBox nameBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button createlistButton;
        private System.Windows.Forms.Button spUpdateButton;
        private System.Windows.Forms.Button deleteList;
    }
}