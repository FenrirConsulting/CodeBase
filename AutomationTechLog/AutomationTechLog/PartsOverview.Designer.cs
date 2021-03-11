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
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripSearchLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchLikeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.likeLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripClearButton = new System.Windows.Forms.ToolStripButton();
            this.partsGrid = new System.Windows.Forms.DataGridView();
            this.selectedDataGrid = new System.Windows.Forms.DataGridView();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDataGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.titlePanel.Controls.Add(this.partsTitle);
            this.titlePanel.Controls.Add(this.closeButton);
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
            this.locationsButton.Location = new System.Drawing.Point(423, 526);
            this.locationsButton.Name = "locationsButton";
            this.locationsButton.Size = new System.Drawing.Size(188, 33);
            this.locationsButton.TabIndex = 48;
            this.locationsButton.Text = "Locations Management";
            this.locationsButton.UseVisualStyleBackColor = false;
            this.locationsButton.Click += new System.EventHandler(this.locationsButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.selectedDataGrid);
            this.bodyPanel.Controls.Add(this.toolStrip);
            this.bodyPanel.Controls.Add(this.locationsButton);
            this.bodyPanel.Controls.Add(this.partsGrid);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 47);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(647, 581);
            this.bodyPanel.TabIndex = 4;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
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
            this.toolStripSearchTextBox.Font = new System.Drawing.Font("Segoe UI", 9F);
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
            this.partsGrid.Location = new System.Drawing.Point(36, 28);
            this.partsGrid.Name = "partsGrid";
            this.partsGrid.Size = new System.Drawing.Size(575, 235);
            this.partsGrid.TabIndex = 2;
            this.partsGrid.SelectionChanged += new System.EventHandler(this.partsGrid_SelectionChanged);
            // 
            // selectedDataGrid
            // 
            this.selectedDataGrid.AllowUserToAddRows = false;
            this.selectedDataGrid.AllowUserToDeleteRows = false;
            this.selectedDataGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.selectedDataGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.selectedDataGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.selectedDataGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.selectedDataGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.selectedDataGrid.Location = new System.Drawing.Point(36, 302);
            this.selectedDataGrid.Name = "selectedDataGrid";
            this.selectedDataGrid.Size = new System.Drawing.Size(575, 71);
            this.selectedDataGrid.TabIndex = 50;
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
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.selectedDataGrid)).EndInit();
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
        private System.Windows.Forms.DataGridView selectedDataGrid;
    }
}