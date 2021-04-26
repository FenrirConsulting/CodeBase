namespace AutomationTechLog
{
    partial class MainForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.titleLabel = new System.Windows.Forms.Label();
            this.welcomeLabel = new System.Windows.Forms.Label();
            this.nameTitleLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.resizeButton = new System.Windows.Forms.PictureBox();
            this.minimizeButton = new System.Windows.Forms.PictureBox();
            this.buttonPanel = new System.Windows.Forms.Panel();
            this.partsButton = new System.Windows.Forms.Button();
            this.olderDateBox = new System.Windows.Forms.Label();
            this.legendLabel4 = new System.Windows.Forms.Label();
            this.usersButton = new System.Windows.Forms.Button();
            this.legendLabel3 = new System.Windows.Forms.Label();
            this.rowCountLabel = new System.Windows.Forms.Label();
            this.legendLabel2 = new System.Windows.Forms.Label();
            this.legendLabel1 = new System.Windows.Forms.Label();
            this.reportsButton = new System.Windows.Forms.Button();
            this.weekNumberLabel = new System.Windows.Forms.Label();
            this.addNewButton = new System.Windows.Forms.Button();
            this.olderRecordsCheckbox = new System.Windows.Forms.CheckBox();
            this.enteredOrdersCheckbox = new System.Windows.Forms.CheckBox();
            this.toolStrip = new System.Windows.Forms.ToolStrip();
            this.toolStripTypeLabel = new System.Windows.Forms.ToolStripLabel();
            this.ownerComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.toolStripSeparator1 = new System.Windows.Forms.ToolStripSeparator();
            this.toolStripSearchLabel = new System.Windows.Forms.ToolStripLabel();
            this.searchLikeComboBox = new System.Windows.Forms.ToolStripComboBox();
            this.likeLabel = new System.Windows.Forms.ToolStripLabel();
            this.toolStripSearchTextBox = new System.Windows.Forms.ToolStripTextBox();
            this.toolStripCSVButton = new System.Windows.Forms.ToolStripButton();
            this.searchButton = new System.Windows.Forms.ToolStripButton();
            this.toolStripClearButton = new System.Windows.Forms.ToolStripButton();
            this.datagridOverview = new System.Windows.Forms.DataGridView();
            this.changesButton = new System.Windows.Forms.Button();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).BeginInit();
            this.buttonPanel.SuspendLayout();
            this.toolStrip.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridOverview)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.titlePanel.Controls.Add(this.titleLabel);
            this.titlePanel.Controls.Add(this.welcomeLabel);
            this.titlePanel.Controls.Add(this.nameTitleLabel);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Controls.Add(this.resizeButton);
            this.titlePanel.Controls.Add(this.minimizeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1196, 37);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            this.titlePanel.DoubleClick += new System.EventHandler(this.titlePanel_DoubleClick);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.titleLabel.Location = new System.Drawing.Point(476, 5);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(245, 26);
            this.titleLabel.TabIndex = 46;
            this.titleLabel.Text = "Automation Technician Log";
            // 
            // welcomeLabel
            // 
            this.welcomeLabel.AutoSize = true;
            this.welcomeLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.welcomeLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.welcomeLabel.Location = new System.Drawing.Point(3, 9);
            this.welcomeLabel.Name = "welcomeLabel";
            this.welcomeLabel.Size = new System.Drawing.Size(97, 20);
            this.welcomeLabel.TabIndex = 45;
            this.welcomeLabel.Text = "Welcome : ";
            // 
            // nameTitleLabel
            // 
            this.nameTitleLabel.AutoSize = true;
            this.nameTitleLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameTitleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.nameTitleLabel.Location = new System.Drawing.Point(97, 9);
            this.nameTitleLabel.Name = "nameTitleLabel";
            this.nameTitleLabel.Size = new System.Drawing.Size(158, 20);
            this.nameTitleLabel.TabIndex = 44;
            this.nameTitleLabel.Text = "Olson, Christopher";
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(1112, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 37);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 3;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // resizeButton
            // 
            this.resizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeButton.Image = global::AutomationTechLog.Properties.Resources.resizeIcon;
            this.resizeButton.Location = new System.Drawing.Point(1140, 0);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(28, 37);
            this.resizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resizeButton.TabIndex = 4;
            this.resizeButton.TabStop = false;
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // minimizeButton
            // 
            this.minimizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.minimizeButton.Image = global::AutomationTechLog.Properties.Resources.minimizeIcon;
            this.minimizeButton.Location = new System.Drawing.Point(1168, 0);
            this.minimizeButton.Name = "minimizeButton";
            this.minimizeButton.Size = new System.Drawing.Size(28, 37);
            this.minimizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.minimizeButton.TabIndex = 5;
            this.minimizeButton.TabStop = false;
            this.minimizeButton.Click += new System.EventHandler(this.minimizeButton_Click);
            // 
            // buttonPanel
            // 
            this.buttonPanel.BackColor = System.Drawing.SystemColors.ButtonShadow;
            this.buttonPanel.Controls.Add(this.changesButton);
            this.buttonPanel.Controls.Add(this.partsButton);
            this.buttonPanel.Controls.Add(this.olderDateBox);
            this.buttonPanel.Controls.Add(this.legendLabel4);
            this.buttonPanel.Controls.Add(this.usersButton);
            this.buttonPanel.Controls.Add(this.legendLabel3);
            this.buttonPanel.Controls.Add(this.rowCountLabel);
            this.buttonPanel.Controls.Add(this.legendLabel2);
            this.buttonPanel.Controls.Add(this.legendLabel1);
            this.buttonPanel.Controls.Add(this.reportsButton);
            this.buttonPanel.Controls.Add(this.weekNumberLabel);
            this.buttonPanel.Controls.Add(this.addNewButton);
            this.buttonPanel.Controls.Add(this.olderRecordsCheckbox);
            this.buttonPanel.Controls.Add(this.enteredOrdersCheckbox);
            this.buttonPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.buttonPanel.Location = new System.Drawing.Point(0, 37);
            this.buttonPanel.Name = "buttonPanel";
            this.buttonPanel.Size = new System.Drawing.Size(1196, 51);
            this.buttonPanel.TabIndex = 1;
            // 
            // partsButton
            // 
            this.partsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.partsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.partsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.partsButton.Location = new System.Drawing.Point(715, 7);
            this.partsButton.Name = "partsButton";
            this.partsButton.Size = new System.Drawing.Size(158, 33);
            this.partsButton.TabIndex = 47;
            this.partsButton.Text = "Parts Management";
            this.partsButton.UseVisualStyleBackColor = false;
            this.partsButton.Click += new System.EventHandler(this.partsButton_Click);
            // 
            // olderDateBox
            // 
            this.olderDateBox.AutoSize = true;
            this.olderDateBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olderDateBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.olderDateBox.Location = new System.Drawing.Point(161, 29);
            this.olderDateBox.Name = "olderDateBox";
            this.olderDateBox.Size = new System.Drawing.Size(71, 15);
            this.olderDateBox.TabIndex = 46;
            this.olderDateBox.Text = "09-12-2020";
            // 
            // legendLabel4
            // 
            this.legendLabel4.AutoSize = true;
            this.legendLabel4.BackColor = System.Drawing.Color.DarkSeaGreen;
            this.legendLabel4.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legendLabel4.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendLabel4.ForeColor = System.Drawing.Color.Black;
            this.legendLabel4.Location = new System.Drawing.Point(992, 24);
            this.legendLabel4.Name = "legendLabel4";
            this.legendLabel4.Size = new System.Drawing.Size(68, 17);
            this.legendLabel4.TabIndex = 45;
            this.legendLabel4.Text = "Unplanned";
            // 
            // usersButton
            // 
            this.usersButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.usersButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.usersButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usersButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.usersButton.Location = new System.Drawing.Point(473, 10);
            this.usersButton.Name = "usersButton";
            this.usersButton.Size = new System.Drawing.Size(87, 30);
            this.usersButton.TabIndex = 41;
            this.usersButton.Text = "Users";
            this.usersButton.UseVisualStyleBackColor = false;
            this.usersButton.Click += new System.EventHandler(this.usersButton_Click);
            // 
            // legendLabel3
            // 
            this.legendLabel3.AutoSize = true;
            this.legendLabel3.BackColor = System.Drawing.Color.DarkGray;
            this.legendLabel3.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legendLabel3.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendLabel3.ForeColor = System.Drawing.Color.Black;
            this.legendLabel3.Location = new System.Drawing.Point(924, 24);
            this.legendLabel3.Name = "legendLabel3";
            this.legendLabel3.Size = new System.Drawing.Size(68, 17);
            this.legendLabel3.TabIndex = 44;
            this.legendLabel3.Text = "Unplanned";
            // 
            // rowCountLabel
            // 
            this.rowCountLabel.AutoSize = true;
            this.rowCountLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rowCountLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.rowCountLabel.Location = new System.Drawing.Point(566, 25);
            this.rowCountLabel.Name = "rowCountLabel";
            this.rowCountLabel.Size = new System.Drawing.Size(65, 15);
            this.rowCountLabel.TabIndex = 40;
            this.rowCountLabel.Text = "Row 0 of 0";
            // 
            // legendLabel2
            // 
            this.legendLabel2.BackColor = System.Drawing.Color.BurlyWood;
            this.legendLabel2.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legendLabel2.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendLabel2.ForeColor = System.Drawing.Color.Black;
            this.legendLabel2.Location = new System.Drawing.Point(992, 7);
            this.legendLabel2.Name = "legendLabel2";
            this.legendLabel2.Size = new System.Drawing.Size(68, 17);
            this.legendLabel2.TabIndex = 43;
            this.legendLabel2.Text = "Facility";
            // 
            // legendLabel1
            // 
            this.legendLabel1.BackColor = System.Drawing.Color.PaleTurquoise;
            this.legendLabel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.legendLabel1.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.legendLabel1.ForeColor = System.Drawing.Color.Black;
            this.legendLabel1.Location = new System.Drawing.Point(924, 7);
            this.legendLabel1.Name = "legendLabel1";
            this.legendLabel1.Size = new System.Drawing.Size(68, 17);
            this.legendLabel1.TabIndex = 42;
            this.legendLabel1.Text = "Passdown";
            // 
            // reportsButton
            // 
            this.reportsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.reportsButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.reportsButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportsButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.reportsButton.Location = new System.Drawing.Point(363, 10);
            this.reportsButton.Name = "reportsButton";
            this.reportsButton.Size = new System.Drawing.Size(87, 30);
            this.reportsButton.TabIndex = 39;
            this.reportsButton.Text = "Reports";
            this.reportsButton.UseVisualStyleBackColor = false;
            this.reportsButton.Click += new System.EventHandler(this.reportsButton_Click);
            // 
            // weekNumberLabel
            // 
            this.weekNumberLabel.AutoSize = true;
            this.weekNumberLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.weekNumberLabel.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.weekNumberLabel.Location = new System.Drawing.Point(566, 7);
            this.weekNumberLabel.Name = "weekNumberLabel";
            this.weekNumberLabel.Size = new System.Drawing.Size(112, 15);
            this.weekNumberLabel.TabIndex = 38;
            this.weekNumberLabel.Text = "Week Number : XX";
            // 
            // addNewButton
            // 
            this.addNewButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.addNewButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addNewButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addNewButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.addNewButton.Location = new System.Drawing.Point(253, 10);
            this.addNewButton.Name = "addNewButton";
            this.addNewButton.Size = new System.Drawing.Size(87, 30);
            this.addNewButton.TabIndex = 37;
            this.addNewButton.Text = "Add New";
            this.addNewButton.UseVisualStyleBackColor = false;
            this.addNewButton.Click += new System.EventHandler(this.addNewButton_Click);
            // 
            // olderRecordsCheckbox
            // 
            this.olderRecordsCheckbox.AutoSize = true;
            this.olderRecordsCheckbox.Checked = true;
            this.olderRecordsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.olderRecordsCheckbox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olderRecordsCheckbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.olderRecordsCheckbox.Location = new System.Drawing.Point(7, 28);
            this.olderRecordsCheckbox.Name = "olderRecordsCheckbox";
            this.olderRecordsCheckbox.Size = new System.Drawing.Size(158, 19);
            this.olderRecordsCheckbox.TabIndex = 1;
            this.olderRecordsCheckbox.Text = "Hide Records older than";
            this.olderRecordsCheckbox.UseVisualStyleBackColor = true;
            // 
            // enteredOrdersCheckbox
            // 
            this.enteredOrdersCheckbox.AutoSize = true;
            this.enteredOrdersCheckbox.Checked = true;
            this.enteredOrdersCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.enteredOrdersCheckbox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enteredOrdersCheckbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.enteredOrdersCheckbox.Location = new System.Drawing.Point(7, 5);
            this.enteredOrdersCheckbox.Name = "enteredOrdersCheckbox";
            this.enteredOrdersCheckbox.Size = new System.Drawing.Size(175, 19);
            this.enteredOrdersCheckbox.TabIndex = 0;
            this.enteredOrdersCheckbox.Text = "Show \"Entered\" workorders";
            this.enteredOrdersCheckbox.UseVisualStyleBackColor = true;
            // 
            // toolStrip
            // 
            this.toolStrip.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.toolStripTypeLabel,
            this.ownerComboBox,
            this.toolStripSeparator1,
            this.toolStripSearchLabel,
            this.searchLikeComboBox,
            this.likeLabel,
            this.toolStripSearchTextBox,
            this.toolStripCSVButton,
            this.searchButton,
            this.toolStripClearButton});
            this.toolStrip.Location = new System.Drawing.Point(0, 88);
            this.toolStrip.Name = "toolStrip";
            this.toolStrip.Size = new System.Drawing.Size(1196, 25);
            this.toolStrip.TabIndex = 2;
            this.toolStrip.Text = "toolStrip1";
            // 
            // toolStripTypeLabel
            // 
            this.toolStripTypeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.toolStripTypeLabel.Name = "toolStripTypeLabel";
            this.toolStripTypeLabel.Size = new System.Drawing.Size(37, 22);
            this.toolStripTypeLabel.Text = "Type: ";
            // 
            // ownerComboBox
            // 
            this.ownerComboBox.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.ownerComboBox.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.ownerComboBox.Items.AddRange(new object[] {
            "All",
            "Mine",
            "Passdown"});
            this.ownerComboBox.Name = "ownerComboBox";
            this.ownerComboBox.Size = new System.Drawing.Size(121, 25);
            this.ownerComboBox.ToolTipText = "Owner Type";
            // 
            // toolStripSeparator1
            // 
            this.toolStripSeparator1.Margin = new System.Windows.Forms.Padding(20, 0, 0, 0);
            this.toolStripSeparator1.Name = "toolStripSeparator1";
            this.toolStripSeparator1.Size = new System.Drawing.Size(6, 25);
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
            "Asset Like",
            "Ref #",
            "User Like",
            "State Like",
            "Full text"});
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
            // toolStripCSVButton
            // 
            this.toolStripCSVButton.DisplayStyle = System.Windows.Forms.ToolStripItemDisplayStyle.Image;
            this.toolStripCSVButton.Image = global::AutomationTechLog.Properties.Resources.ExportToExcel_16x;
            this.toolStripCSVButton.ImageTransparentColor = System.Drawing.Color.Magenta;
            this.toolStripCSVButton.Name = "toolStripCSVButton";
            this.toolStripCSVButton.Size = new System.Drawing.Size(23, 22);
            this.toolStripCSVButton.Text = "toolStripButton1";
            this.toolStripCSVButton.ToolTipText = "Export to CSV (Excel)";
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
            // datagridOverview
            // 
            this.datagridOverview.AllowUserToAddRows = false;
            this.datagridOverview.AllowUserToDeleteRows = false;
            this.datagridOverview.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.datagridOverview.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.datagridOverview.Dock = System.Windows.Forms.DockStyle.Fill;
            this.datagridOverview.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.datagridOverview.Location = new System.Drawing.Point(0, 113);
            this.datagridOverview.Name = "datagridOverview";
            this.datagridOverview.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.datagridOverview.Size = new System.Drawing.Size(1196, 558);
            this.datagridOverview.TabIndex = 3;
            this.datagridOverview.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.datagridOverview_CellDoubleClick);
            this.datagridOverview.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.datagridOverview_CellFormatting);
            this.datagridOverview.SelectionChanged += new System.EventHandler(this.datagridOverview_SelectionChanged);
            this.datagridOverview.Paint += new System.Windows.Forms.PaintEventHandler(this.datagridOverview_Paint);
            // 
            // changesButton
            // 
            this.changesButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.changesButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.changesButton.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changesButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.changesButton.Location = new System.Drawing.Point(1087, 14);
            this.changesButton.Name = "changesButton";
            this.changesButton.Size = new System.Drawing.Size(97, 25);
            this.changesButton.TabIndex = 48;
            this.changesButton.Text = "Patch Changes";
            this.changesButton.UseVisualStyleBackColor = false;
            this.changesButton.Click += new System.EventHandler(this.changesButton_Click);
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(1196, 671);
            this.Controls.Add(this.datagridOverview);
            this.Controls.Add(this.toolStrip);
            this.Controls.Add(this.buttonPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATLog";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.resizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.minimizeButton)).EndInit();
            this.buttonPanel.ResumeLayout(false);
            this.buttonPanel.PerformLayout();
            this.toolStrip.ResumeLayout(false);
            this.toolStrip.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.datagridOverview)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox resizeButton;
        private System.Windows.Forms.PictureBox minimizeButton;
        private System.Windows.Forms.Label nameTitleLabel;
        private System.Windows.Forms.Label welcomeLabel;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Panel buttonPanel;
        private System.Windows.Forms.ToolStrip toolStrip;
        private System.Windows.Forms.CheckBox olderRecordsCheckbox;
        private System.Windows.Forms.CheckBox enteredOrdersCheckbox;
        private System.Windows.Forms.Button addNewButton;
        private System.Windows.Forms.Label weekNumberLabel;
        private System.Windows.Forms.Button reportsButton;
        private System.Windows.Forms.Label rowCountLabel;
        private System.Windows.Forms.Button usersButton;
        private System.Windows.Forms.Label legendLabel1;
        private System.Windows.Forms.Label legendLabel2;
        private System.Windows.Forms.Label legendLabel3;
        private System.Windows.Forms.Label legendLabel4;
        private System.Windows.Forms.ToolStripComboBox ownerComboBox;
        private System.Windows.Forms.ToolStripSeparator toolStripSeparator1;
        private System.Windows.Forms.ToolStripLabel toolStripSearchLabel;
        private System.Windows.Forms.ToolStripComboBox searchLikeComboBox;
        private System.Windows.Forms.ToolStripLabel toolStripTypeLabel;
        private System.Windows.Forms.ToolStripTextBox toolStripSearchTextBox;
        private System.Windows.Forms.ToolStripButton searchButton;
        private System.Windows.Forms.ToolStripButton toolStripCSVButton;
        private System.Windows.Forms.DataGridView datagridOverview;
        private System.Windows.Forms.Label olderDateBox;
        private System.Windows.Forms.Button partsButton;
        private System.Windows.Forms.ToolStripButton toolStripClearButton;
        private System.Windows.Forms.ToolStripLabel likeLabel;
        private System.Windows.Forms.Button changesButton;
    }
}