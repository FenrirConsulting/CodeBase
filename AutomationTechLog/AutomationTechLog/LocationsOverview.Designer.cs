namespace AutomationTechLog
{
    partial class LocationsOverview
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(LocationsOverview));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.locationsTitle = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.locationsGrid = new System.Windows.Forms.DataGridView();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.likeLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripClearButton = new System.Windows.Forms.ToolStripButton();
            this.emptyLocationsLabel = new System.Windows.Forms.ToolStripLabel();
            this.emptyLocationsButton = new System.Windows.Forms.ToolStripButton();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsGrid)).BeginInit();
            this.toolStrip.SuspendLayout();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.titlePanel.Controls.Add(this.locationsTitle);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(800, 47);
            this.titlePanel.TabIndex = 4;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // locationsTitle
            // 
            this.locationsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationsTitle.AutoSize = true;
            this.locationsTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.locationsTitle.Location = new System.Drawing.Point(320, 13);
            this.locationsTitle.Name = "locationsTitle";
            this.locationsTitle.Size = new System.Drawing.Size(194, 23);
            this.locationsTitle.TabIndex = 49;
            this.locationsTitle.Text = "Locations Management";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(769, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 26);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 48;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.toolStrip);
            this.bodyPanel.Controls.Add(this.locationsGrid);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 47);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(800, 403);
            this.bodyPanel.TabIndex = 5;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            // 
            // locationsGrid
            // 
            this.locationsGrid.AllowUserToAddRows = false;
            this.locationsGrid.AllowUserToDeleteRows = false;
            this.locationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.locationsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.locationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationsGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.locationsGrid.Location = new System.Drawing.Point(43, 59);
            this.locationsGrid.Name = "locationsGrid";
            this.locationsGrid.Size = new System.Drawing.Size(626, 89);
            this.locationsGrid.TabIndex = 3;
            this.locationsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.locationsGrid_CellFormatting);
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.likeLabel,
            this.toolStripSearchTextBox,
            this.searchButton,
            this.toolStripClearButton,
            this.emptyLocationsLabel,
            this.emptyLocationsButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 0);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(800, 25);
            this.toolStrip.TabIndex = 50;
            this.toolStrip.Text = "toolStrip1";
            // 
            // likeLabel
            // 
            this.likeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.likeLabel.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.likeLabel.Name = "likeLabel";
            this.likeLabel.Size = new System.Drawing.Size(126, 22);
            this.likeLabel.Text = "Search Locations Like:";
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
            this.searchButton.Click += new System.EventHandler(this.searchButton_Click);
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
            // emptyLocationsLabel
            // 
            this.emptyLocationsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.emptyLocationsLabel.Margin = new System.Windows.Forms.Padding(50, 1, 0, 2);
            this.emptyLocationsLabel.Name = "emptyLocationsLabel";
            this.emptyLocationsLabel.Size = new System.Drawing.Size(138, 22);
            this.emptyLocationsLabel.Text = "Search Empty Locations:";
            this.emptyLocationsLabel.ToolTipText = "Like : ";
            // 
            // emptyLocationsButton
            // 
            this.emptyLocationsButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.emptyLocationsButton.Image = global::AutomationTechLog.Properties.Resources.Search;
            this.emptyLocationsButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.emptyLocationsButton.Name = "emptyLocationsButton";
            this.emptyLocationsButton.Size = new System.Drawing.Size(23, 22);
            this.emptyLocationsButton.Text = "toolStripButton1";
            this.emptyLocationsButton.ToolTipText = "Run Current Search";
            this.emptyLocationsButton.Click += new System.EventHandler(this.emptyLocationsButton_Click);
            // 
            // LocationsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "LocationsOverview";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "LocationsOverview";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsGrid)).EndInit();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label locationsTitle;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.DataGridView locationsGrid;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.ToolStripLabel likeLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripSearchTextBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton toolStripClearButton;
        private System.Windows.Forms.ToolStripLabel emptyLocationsLabel;
        private System.Windows.Forms.ToolStripButton emptyLocationsButton;
    }
}