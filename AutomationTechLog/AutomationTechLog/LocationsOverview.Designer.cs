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
            this.workPanel = new System.Windows.Forms.Panel();
            this.countLabel = new System.Windows.Forms.Label();
            this.assignedLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.descriptionTextBox = new System.Windows.Forms.TextBox();
            this.addButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.locationLabel = new System.Windows.Forms.Label();
            this.locationNumberTextBox = new System.Windows.Forms.TextBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.likeLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripClearButton = new System.Windows.Forms.ToolStripButton();
            this.emptyLocationsLabel = new System.Windows.Forms.ToolStripLabel();
            this.emptyLocationsButton = new System.Windows.Forms.ToolStripButton();
            this.locationsGrid = new System.Windows.Forms.DataGridView();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.bodyPanel.SuspendLayout();
            this.workPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsGrid)).BeginInit();
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
            this.titlePanel.Size = new System.Drawing.Size(645, 47);
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
            this.locationsTitle.Location = new System.Drawing.Point(242, 13);
            this.locationsTitle.Name = "locationsTitle";
            this.locationsTitle.Size = new System.Drawing.Size(194, 23);
            this.locationsTitle.TabIndex = 49;
            this.locationsTitle.Text = "Locations Management";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(614, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 26);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 48;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.workPanel);
            this.bodyPanel.Controls.Add(this.toolStrip);
            this.bodyPanel.Controls.Add(this.locationsGrid);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 47);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(645, 581);
            this.bodyPanel.TabIndex = 5;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            // 
            // workPanel
            // 
            this.workPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.workPanel.Controls.Add(this.countLabel);
            this.workPanel.Controls.Add(this.assignedLabel);
            this.workPanel.Controls.Add(this.label1);
            this.workPanel.Controls.Add(this.descriptionTextBox);
            this.workPanel.Controls.Add(this.addButton);
            this.workPanel.Controls.Add(this.updateButton);
            this.workPanel.Controls.Add(this.deleteButton);
            this.workPanel.Controls.Add(this.locationLabel);
            this.workPanel.Controls.Add(this.locationNumberTextBox);
            this.workPanel.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.workPanel.Location = new System.Drawing.Point(0, 266);
            this.workPanel.Name = "workPanel";
            this.workPanel.Size = new System.Drawing.Size(645, 315);
            this.workPanel.TabIndex = 55;
            this.workPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.workPanel_Paint);
            // 
            // countLabel
            // 
            this.countLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.countLabel.AutoSize = true;
            this.countLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.countLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.countLabel.Location = new System.Drawing.Point(233, 159);
            this.countLabel.Name = "countLabel";
            this.countLabel.Size = new System.Drawing.Size(17, 19);
            this.countLabel.TabIndex = 120;
            this.countLabel.Text = "0";
            // 
            // assignedLabel
            // 
            this.assignedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assignedLabel.AutoSize = true;
            this.assignedLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assignedLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.assignedLabel.Location = new System.Drawing.Point(115, 159);
            this.assignedLabel.Name = "assignedLabel";
            this.assignedLabel.Size = new System.Drawing.Size(112, 19);
            this.assignedLabel.TabIndex = 119;
            this.assignedLabel.Text = "Assigned Parts:";
            // 
            // label1
            // 
            this.label1.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.label1.Location = new System.Drawing.Point(137, 71);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(90, 19);
            this.label1.TabIndex = 118;
            this.label1.Text = "Description:";
            // 
            // descriptionTextBox
            // 
            this.descriptionTextBox.Location = new System.Drawing.Point(233, 72);
            this.descriptionTextBox.Multiline = true;
            this.descriptionTextBox.Name = "descriptionTextBox";
            this.descriptionTextBox.Size = new System.Drawing.Size(269, 52);
            this.descriptionTextBox.TabIndex = 117;
            // 
            // addButton
            // 
            this.addButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.addButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.addButton.Location = new System.Drawing.Point(228, 270);
            this.addButton.Name = "addButton";
            this.addButton.Size = new System.Drawing.Size(188, 33);
            this.addButton.TabIndex = 56;
            this.addButton.Text = "Add Location";
            this.addButton.UseVisualStyleBackColor = false;
            this.addButton.Click += new System.EventHandler(this.addButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.updateButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.updateButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.updateButton.Location = new System.Drawing.Point(340, 217);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(188, 33);
            this.updateButton.TabIndex = 116;
            this.updateButton.Text = "Update Location";
            this.updateButton.UseVisualStyleBackColor = false;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.deleteButton.Location = new System.Drawing.Point(129, 217);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(188, 33);
            this.deleteButton.TabIndex = 55;
            this.deleteButton.Text = "Delete Location";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.locationLabel.Location = new System.Drawing.Point(70, 6);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(157, 19);
            this.locationLabel.TabIndex = 115;
            this.locationLabel.Text = "Location Coordinates:";
            // 
            // locationNumberTextBox
            // 
            this.locationNumberTextBox.Location = new System.Drawing.Point(233, 7);
            this.locationNumberTextBox.Name = "locationNumberTextBox";
            this.locationNumberTextBox.ReadOnly = true;
            this.locationNumberTextBox.Size = new System.Drawing.Size(131, 20);
            this.locationNumberTextBox.TabIndex = 114;
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
            this.toolStrip.Size = new System.Drawing.Size(645, 25);
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
            // locationsGrid
            // 
            this.locationsGrid.AllowUserToAddRows = false;
            this.locationsGrid.AllowUserToDeleteRows = false;
            this.locationsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.locationsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.locationsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.locationsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.locationsGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.locationsGrid.Location = new System.Drawing.Point(3, 28);
            this.locationsGrid.Name = "locationsGrid";
            this.locationsGrid.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.locationsGrid.Size = new System.Drawing.Size(639, 232);
            this.locationsGrid.TabIndex = 3;
            this.locationsGrid.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.locationsGrid_CellFormatting);
            this.locationsGrid.SelectionChanged += new System.EventHandler(this.locationsGrid_SelectionChanged);
            // 
            // LocationsOverview
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(645, 628);
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
            this.workPanel.ResumeLayout(false);
            this.workPanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.locationsGrid)).EndInit();
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
        private System.Windows.Forms.Panel workPanel;
        private System.Windows.Forms.Button addButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.TextBox locationNumberTextBox;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox descriptionTextBox;
        private System.Windows.Forms.Label assignedLabel;
        private System.Windows.Forms.Label countLabel;
    }
}