namespace AutomationTechLog
{
    partial class PartsOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PartsOverview));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.partsTitle = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.locationsButton = new System.Windows.Forms.Button();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.addButton = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.locationTextBox = new System.Windows.Forms.ComboBox();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.partNumberTextBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.quantityTextBox = new System.Windows.Forms.TextBox();
            this.locationLabel = new System.Windows.Forms.Label();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSearchLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchLikeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.likeLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripClearButton = new System.Windows.Forms.ToolStripButton();
            this.partsGrid = new System.Windows.Forms.DataGridView();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.panel1.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.titlePanel.Controls.Add(this.partsTitle);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Controls.Add(this.locationsButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(647, 47);
            this.titlePanel.TabIndex = 3;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // partsTitle
            // 
            this.partsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partsTitle.AutoSize = true;
            this.partsTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.partsTitle.Location = new System.Drawing.Point(243, 13);
            this.partsTitle.Name = "partsTitle";
            this.partsTitle.Size = new System.Drawing.Size(161, 23);
            this.partsTitle.TabIndex = 49;
            this.partsTitle.Text = "Parts Management";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(616, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 26);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 48;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // locationsButton
            // 
            this.locationsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.locationsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.locationsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.locationsButton.Location = new System.Drawing.Point(12, 8);
            this.locationsButton.Name = "locationsButton";
            this.locationsButton.Size = new System.Drawing.Size(188, 33);
            this.locationsButton.TabIndex = 48;
            this.locationsButton.Text = "Locations Management";
            this.locationsButton.UseVisualStyleBackColor = false;
            this.locationsButton.Click += new System.EventHandler(this.locationsButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.panel1);
            this.bodyPanel.Controls.Add(this.toolStrip);
            this.bodyPanel.Controls.Add(this.partsGrid);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 47);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(647, 581);
            this.bodyPanel.TabIndex = 4;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.addButton.Location = new System.Drawing.Point(231, 231);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(188, 33);
            this.addButton.TabIndex = 56;
            this.addButton.Text = "Add Part";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.panel1.Controls.Add(this.addButton);
            this.panel1.Controls.Add(this.locationTextBox);
            this.panel1.Controls.Add(this.updateButton);
            this.panel1.Controls.Add(this.deleteButton);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.partNumberTextBox);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.descriptionTextBox);
            this.panel1.Controls.Add(this.quantityLabel);
            this.panel1.Controls.Add(this.quantityTextBox);
            this.panel1.Controls.Add(this.locationLabel);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.panel1.Location = new System.Drawing.Point(0, 305);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(647, 276);
            this.panel1.TabIndex = 54;
            // 
            // locationTextBox
            // 
            this.locationTextBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.locationTextBox.FormattingEnabled = true;
            this.locationTextBox.Location = new System.Drawing.Point(244, 53);
            this.locationTextBox.Name = "locationTextBox";
            this.locationTextBox.Size = new System.Drawing.Size(121, 21);
            this.locationTextBox.TabIndex = 117;
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.updateButton.Location = new System.Drawing.Point(352, 160);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(188, 33);
            this.updateButton.TabIndex = 116;
            this.updateButton.Text = "Update Part";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.deleteButton.Location = new System.Drawing.Point(107, 160);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(188, 33);
            this.deleteButton.TabIndex = 55;
            this.deleteButton.Text = "Delete Part";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // label2
            // 
            this.label2.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label2.Location = new System.Drawing.Point(120, 19);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(102, 19);
            this.label2.TabIndex = 115;
            this.label2.Text = "Part Number:";
            // 
            // partNumberTextBox
            // 
            this.partNumberTextBox.Location = new System.Drawing.Point(244, 18);
            this.partNumberTextBox.Name = "partNumberTextBox";
            this.partNumberTextBox.ReadOnly = true;
            this.partNumberTextBox.Size = new System.Drawing.Size(131, 20);
            this.partNumberTextBox.TabIndex = 114;
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(119, 88);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 113;
            this.label1.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(244, 89);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(269, 52);
            this.descriptionTextBox.TabIndex = 112;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.quantityLabel.Location = new System.Drawing.Point(391, 53);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(73, 19);
            this.quantityLabel.TabIndex = 111;
            this.quantityLabel.Text = "Quantity:";
            // 
            // quantityTextBox
            // 
            this.quantityTextBox.Location = new System.Drawing.Point(470, 54);
            this.quantityTextBox.Name = "quantityTextBox";
            this.quantityTextBox.Size = new System.Drawing.Size(57, 20);
            this.quantityTextBox.TabIndex = 110;
            this.quantityTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.quantityTextBox_KeyPress);
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.locationLabel.Location = new System.Drawing.Point(119, 56);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(71, 19);
            this.locationLabel.TabIndex = 109;
            this.locationLabel.Text = "Location:";
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripSearchLabel,
            this.searchLikeComboBox,
            this.likeLabel,
            this.toolStripSearchTextBox,
            this.searchButton,
            this.toolStripClearButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(647, 25);
            this.toolStrip.TabIndex = 49;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripSearchLabel
            // 
            this.toolStripSearchLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripSearchLabel.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.toolStripSearchLabel.Name = "toolStripSearchLabel";
            this.toolStripSearchLabel.Size = new System.Drawing.Size(47, 22);
            this.toolStripSearchLabel.Text = "Search:";
            // 
            // searchLikeComboBox
            // 
            this.searchLikeComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.searchLikeComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.searchLikeComboBox.Items.AddRange(new object[] {
            "Part Number",
            "Location"});
            this.searchLikeComboBox.Name = "searchLikeComboBox";
            this.searchLikeComboBox.Size = new System.Drawing.Size(121, 25);
            this.searchLikeComboBox.ToolTipText = "Search Type";
            // 
            // likeLabel
            // 
            this.likeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeLabel.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.likeLabel.Name = "likeLabel";
            this.likeLabel.Size = new System.Drawing.Size(31, 22);
            this.likeLabel.Text = "Like:";
            this.likeLabel.ToolTipText = "Like : ";
            // 
            // toolStripSearchTextBox
            // 
            this.toolStripSearchTextBox.BackColor = System.Drawing.SystemColors.InactiveBorder;
            this.toolStripSearchTextBox.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.toolStripSearchTextBox.Margin = new System.Windows.Forms.Padding(10, 0, 1, 0);
            this.toolStripSearchTextBox.Name = "toolStripSearchTextBox";
            this.toolStripSearchTextBox.Size = new System.Drawing.Size(150, 25);
            this.toolStripSearchTextBox.ToolTipText = "Search Criteria";
            // 
            // searchButton
            // 
            this.searchButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.searchButton.Image = global::AutomationTechLog.Properties.Resources.Search;
            this.searchButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.searchButton.Name = "searchButton";
            this.searchButton.Size = new System.Drawing.Size(23, 22);
            this.searchButton.Text = "toolStripButton1";
            this.searchButton.ToolTipText = "Run Current Search";
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click_1);
            // 
            // toolStripClearButton
            // 
            this.toolStripClearButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripClearButton.Image = global::AutomationTechLog.Properties.Resources.Stop;
            this.toolStripClearButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripClearButton.Name = "toolStripClearButton";
            this.toolStripClearButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripClearButton.Text = "toolStripButton1";
            this.toolStripClearButton.ToolTipText = "Clear Search";
            this.toolStripClearButton.Click += new System.EventHandler(this.toolStripClearButton_Click);
            // 
            // partsGrid
            // 
            this.partsGrid.AllowUserToAddRows = false;
            this.partsGrid.AllowUserToDeleteRows = false;
            this.partsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.partsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.partsGrid.Location = new System.Drawing.Point(3, 28);
            this.partsGrid.Name = "partsGrid";
            this.partsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.partsGrid.Size = new System.Drawing.Size(641, 271);
            this.partsGrid.TabIndex = 2;
            this.partsGrid.SelectionChanged += new System.EventHandler(this.partsGrid_SelectionChanged);
            // 
            // PartsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(647, 628);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PartsOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "PartsOverview";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label partsTitle;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Button locationsButton;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.DataGridView partsGrid;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel toolStripSearchLabel;
        private System.Windows.Forms.ToolStripComboBox searchLikeComboBox;
        private System.Windows.Forms.ToolStripTextBox toolStripSearchTextBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton toolStripClearButton;
        private System.Windows.Forms.ToolStripLabel likeLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.TextBox quantityTextBox;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox partNumberTextBox;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.ComboBox locationTextBox;
    }
}