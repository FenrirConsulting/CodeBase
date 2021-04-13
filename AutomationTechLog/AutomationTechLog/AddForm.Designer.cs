
namespace AutomationTechLog
{
    partial class AddForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(AddForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.creatingRecordLabel = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.nameLabel = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.timeLabel = new System.Windows.Forms.Label();
            this.shiftLabel = new System.Windows.Forms.Label();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.locationLabel = new System.Windows.Forms.Label();
            this.partNumberLabel = new System.Windows.Forms.Label();
            this.quantityLabel = new System.Windows.Forms.Label();
            this.addLocationBox = new System.Windows.Forms.TextBox();
            this.addDescriptionBox = new System.Windows.Forms.TextBox();
            this.addQuantityBox = new System.Windows.Forms.TextBox();
            this.addShiftBox = new System.Windows.Forms.ComboBox();
            this.addUserDateTime = new System.Windows.Forms.DateTimePicker();
            this.addTimeTextBox = new System.Windows.Forms.TextBox();
            this.addUserBox = new System.Windows.Forms.ComboBox();
            this.stateComboBox = new System.Windows.Forms.ComboBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.assetTextBox = new System.Windows.Forms.TextBox();
            this.assetLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.stateLabel = new System.Windows.Forms.Label();
            this.complaintLabel = new System.Windows.Forms.Label();
            this.complaintTextBox = new System.Windows.Forms.TextBox();
            this.causeLabel = new System.Windows.Forms.Label();
            this.causeTextBox = new System.Windows.Forms.TextBox();
            this.correctionLabel = new System.Windows.Forms.Label();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.partsLabel = new System.Windows.Forms.Label();
            this.techsLabel = new System.Windows.Forms.Label();
            this.correctionTextBox = new System.Windows.Forms.TextBox();
            this.creatingLabel = new System.Windows.Forms.Label();
            this.addPartNumberBox = new System.Windows.Forms.ComboBox();
            this.partsGrid = new System.Windows.Forms.DataGridView();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.titlePanel.Controls.Add(this.creatingRecordLabel);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(548, 47);
            this.titlePanel.TabIndex = 1;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // creatingRecordLabel
            // 
            this.creatingRecordLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creatingRecordLabel.AutoSize = true;
            this.creatingRecordLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatingRecordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.creatingRecordLabel.Location = new System.Drawing.Point(12, 9);
            this.creatingRecordLabel.Name = "creatingRecordLabel";
            this.creatingRecordLabel.Size = new System.Drawing.Size(195, 26);
            this.creatingRecordLabel.TabIndex = 49;
            this.creatingRecordLabel.Text = "User Creating Record";
            // 
            // closeButton
            // 
            this.closeButton.Anchor = System.Windows.Forms.AnchorStyles.Right;
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(517, 10);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 26);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 48;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.partsGrid);
            this.bodyPanel.Controls.Add(this.addPartNumberBox);
            this.bodyPanel.Controls.Add(this.nameLabel);
            this.bodyPanel.Controls.Add(this.label3);
            this.bodyPanel.Controls.Add(this.timeLabel);
            this.bodyPanel.Controls.Add(this.shiftLabel);
            this.bodyPanel.Controls.Add(this.descriptionLabel);
            this.bodyPanel.Controls.Add(this.locationLabel);
            this.bodyPanel.Controls.Add(this.partNumberLabel);
            this.bodyPanel.Controls.Add(this.quantityLabel);
            this.bodyPanel.Controls.Add(this.addLocationBox);
            this.bodyPanel.Controls.Add(this.addDescriptionBox);
            this.bodyPanel.Controls.Add(this.addQuantityBox);
            this.bodyPanel.Controls.Add(this.addShiftBox);
            this.bodyPanel.Controls.Add(this.addUserDateTime);
            this.bodyPanel.Controls.Add(this.addTimeTextBox);
            this.bodyPanel.Controls.Add(this.addUserBox);
            this.bodyPanel.Controls.Add(this.stateComboBox);
            this.bodyPanel.Controls.Add(this.typeComboBox);
            this.bodyPanel.Controls.Add(this.assetTextBox);
            this.bodyPanel.Controls.Add(this.assetLabel);
            this.bodyPanel.Controls.Add(this.typeLabel);
            this.bodyPanel.Controls.Add(this.stateLabel);
            this.bodyPanel.Controls.Add(this.complaintLabel);
            this.bodyPanel.Controls.Add(this.complaintTextBox);
            this.bodyPanel.Controls.Add(this.causeLabel);
            this.bodyPanel.Controls.Add(this.causeTextBox);
            this.bodyPanel.Controls.Add(this.correctionLabel);
            this.bodyPanel.Controls.Add(this.cancelButton);
            this.bodyPanel.Controls.Add(this.saveButton);
            this.bodyPanel.Controls.Add(this.partsLabel);
            this.bodyPanel.Controls.Add(this.techsLabel);
            this.bodyPanel.Controls.Add(this.correctionTextBox);
            this.bodyPanel.Controls.Add(this.creatingLabel);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 47);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(548, 651);
            this.bodyPanel.TabIndex = 0;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            // 
            // nameLabel
            // 
            this.nameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.ForeColor = System.Drawing.Color.Black;
            this.nameLabel.Location = new System.Drawing.Point(426, 344);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(84, 19);
            this.nameLabel.TabIndex = 112;
            this.nameLabel.Text = "Tech Name";
            this.nameLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // label3
            // 
            this.label3.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(295, 344);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(88, 19);
            this.label3.TabIndex = 111;
            this.label3.Text = "Date Begun";
            this.label3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // timeLabel
            // 
            this.timeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.timeLabel.AutoSize = true;
            this.timeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timeLabel.ForeColor = System.Drawing.Color.Black;
            this.timeLabel.Location = new System.Drawing.Point(167, 344);
            this.timeLabel.Name = "timeLabel";
            this.timeLabel.Size = new System.Drawing.Size(65, 19);
            this.timeLabel.TabIndex = 110;
            this.timeLabel.Text = "Minutes";
            this.timeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // shiftLabel
            // 
            this.shiftLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.shiftLabel.AutoSize = true;
            this.shiftLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.shiftLabel.ForeColor = System.Drawing.Color.Black;
            this.shiftLabel.Location = new System.Drawing.Point(35, 344);
            this.shiftLabel.Name = "shiftLabel";
            this.shiftLabel.Size = new System.Drawing.Size(40, 19);
            this.shiftLabel.TabIndex = 109;
            this.shiftLabel.Text = "Shift";
            this.shiftLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.ForeColor = System.Drawing.Color.Black;
            this.descriptionLabel.Location = new System.Drawing.Point(425, 435);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(86, 19);
            this.descriptionLabel.TabIndex = 108;
            this.descriptionLabel.Text = "Description";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // locationLabel
            // 
            this.locationLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.locationLabel.AutoSize = true;
            this.locationLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.locationLabel.ForeColor = System.Drawing.Color.Black;
            this.locationLabel.Location = new System.Drawing.Point(294, 435);
            this.locationLabel.Name = "locationLabel";
            this.locationLabel.Size = new System.Drawing.Size(67, 19);
            this.locationLabel.TabIndex = 107;
            this.locationLabel.Text = "Location";
            this.locationLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partNumberLabel
            // 
            this.partNumberLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partNumberLabel.AutoSize = true;
            this.partNumberLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partNumberLabel.ForeColor = System.Drawing.Color.Black;
            this.partNumberLabel.Location = new System.Drawing.Point(166, 435);
            this.partNumberLabel.Name = "partNumberLabel";
            this.partNumberLabel.Size = new System.Drawing.Size(98, 19);
            this.partNumberLabel.TabIndex = 106;
            this.partNumberLabel.Text = "Part Number";
            this.partNumberLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // quantityLabel
            // 
            this.quantityLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.quantityLabel.AutoSize = true;
            this.quantityLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.quantityLabel.ForeColor = System.Drawing.Color.Black;
            this.quantityLabel.Location = new System.Drawing.Point(34, 435);
            this.quantityLabel.Name = "quantityLabel";
            this.quantityLabel.Size = new System.Drawing.Size(69, 19);
            this.quantityLabel.TabIndex = 105;
            this.quantityLabel.Text = "Quantity";
            this.quantityLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addLocationBox
            // 
            this.addLocationBox.Location = new System.Drawing.Point(274, 457);
            this.addLocationBox.Name = "addLocationBox";
            this.addLocationBox.ReadOnly = true;
            this.addLocationBox.Size = new System.Drawing.Size(131, 20);
            this.addLocationBox.TabIndex = 12;
            this.addLocationBox.Text = "Unassigned";
            // 
            // addDescriptionBox
            // 
            this.addDescriptionBox.Location = new System.Drawing.Point(404, 457);
            this.addDescriptionBox.Name = "addDescriptionBox";
            this.addDescriptionBox.ReadOnly = true;
            this.addDescriptionBox.Size = new System.Drawing.Size(131, 20);
            this.addDescriptionBox.TabIndex = 13;
            this.addDescriptionBox.Text = "No Description";
            // 
            // addQuantityBox
            // 
            this.addQuantityBox.Location = new System.Drawing.Point(14, 457);
            this.addQuantityBox.Name = "addQuantityBox";
            this.addQuantityBox.Size = new System.Drawing.Size(131, 20);
            this.addQuantityBox.TabIndex = 10;
            this.addQuantityBox.TextChanged += new System.EventHandler(this.addQuantityBox_TextChanged);
            // 
            // addShiftBox
            // 
            this.addShiftBox.FormattingEnabled = true;
            this.addShiftBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.addShiftBox.Location = new System.Drawing.Point(12, 366);
            this.addShiftBox.Name = "addShiftBox";
            this.addShiftBox.Size = new System.Drawing.Size(131, 21);
            this.addShiftBox.TabIndex = 6;
            // 
            // addUserDateTime
            // 
            this.addUserDateTime.CustomFormat = "\"MM-dd-yyyy\"";
            this.addUserDateTime.Location = new System.Drawing.Point(272, 366);
            this.addUserDateTime.Name = "addUserDateTime";
            this.addUserDateTime.Size = new System.Drawing.Size(131, 20);
            this.addUserDateTime.TabIndex = 8;
            // 
            // addTimeTextBox
            // 
            this.addTimeTextBox.Location = new System.Drawing.Point(142, 366);
            this.addTimeTextBox.Name = "addTimeTextBox";
            this.addTimeTextBox.Size = new System.Drawing.Size(131, 20);
            this.addTimeTextBox.TabIndex = 7;
            this.addTimeTextBox.TextChanged += new System.EventHandler(this.addTimeTextBox_TextChanged);
            // 
            // addUserBox
            // 
            this.addUserBox.FormattingEnabled = true;
            this.addUserBox.Location = new System.Drawing.Point(402, 366);
            this.addUserBox.Name = "addUserBox";
            this.addUserBox.Size = new System.Drawing.Size(131, 21);
            this.addUserBox.TabIndex = 9;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "Completed",
            "Entered"});
            this.stateComboBox.Location = new System.Drawing.Point(78, 9);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(102, 21);
            this.stateComboBox.TabIndex = 0;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Planned",
            "Unplanned",
            "System Support",
            "Facility",
            "Passdown"});
            this.typeComboBox.Location = new System.Drawing.Point(238, 11);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(111, 21);
            this.typeComboBox.TabIndex = 1;
            // 
            // assetTextBox
            // 
            this.assetTextBox.Location = new System.Drawing.Point(410, 12);
            this.assetTextBox.Name = "assetTextBox";
            this.assetTextBox.Size = new System.Drawing.Size(123, 20);
            this.assetTextBox.TabIndex = 2;
            // 
            // assetLabel
            // 
            this.assetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assetLabel.AutoSize = true;
            this.assetLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetLabel.ForeColor = System.Drawing.Color.Black;
            this.assetLabel.Location = new System.Drawing.Point(355, 11);
            this.assetLabel.Name = "assetLabel";
            this.assetLabel.Size = new System.Drawing.Size(49, 19);
            this.assetLabel.TabIndex = 93;
            this.assetLabel.Text = "Asset:";
            this.assetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.Color.Black;
            this.typeLabel.Location = new System.Drawing.Point(186, 11);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(46, 19);
            this.typeLabel.TabIndex = 92;
            this.typeLabel.Text = "Type:";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.Black;
            this.stateLabel.Location = new System.Drawing.Point(14, 8);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(53, 19);
            this.stateLabel.TabIndex = 91;
            this.stateLabel.Text = "State: ";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // complaintLabel
            // 
            this.complaintLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.complaintLabel.AutoSize = true;
            this.complaintLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintLabel.ForeColor = System.Drawing.Color.Black;
            this.complaintLabel.Location = new System.Drawing.Point(15, 40);
            this.complaintLabel.Name = "complaintLabel";
            this.complaintLabel.Size = new System.Drawing.Size(87, 19);
            this.complaintLabel.TabIndex = 90;
            this.complaintLabel.Text = "Complaint :";
            this.complaintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // complaintTextBox
            // 
            this.complaintTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.complaintTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.complaintTextBox.Location = new System.Drawing.Point(12, 62);
            this.complaintTextBox.Multiline = true;
            this.complaintTextBox.Name = "complaintTextBox";
            this.complaintTextBox.Size = new System.Drawing.Size(524, 65);
            this.complaintTextBox.TabIndex = 3;
            // 
            // causeLabel
            // 
            this.causeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.causeLabel.AutoSize = true;
            this.causeLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.causeLabel.ForeColor = System.Drawing.Color.Black;
            this.causeLabel.Location = new System.Drawing.Point(14, 130);
            this.causeLabel.Name = "causeLabel";
            this.causeLabel.Size = new System.Drawing.Size(56, 19);
            this.causeLabel.TabIndex = 88;
            this.causeLabel.Text = "Cause :";
            this.causeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // causeTextBox
            // 
            this.causeTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.causeTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.causeTextBox.Location = new System.Drawing.Point(12, 152);
            this.causeTextBox.Multiline = true;
            this.causeTextBox.Name = "causeTextBox";
            this.causeTextBox.Size = new System.Drawing.Size(524, 65);
            this.causeTextBox.TabIndex = 4;
            // 
            // correctionLabel
            // 
            this.correctionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.correctionLabel.AutoSize = true;
            this.correctionLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctionLabel.ForeColor = System.Drawing.Color.Black;
            this.correctionLabel.Location = new System.Drawing.Point(14, 220);
            this.correctionLabel.Name = "correctionLabel";
            this.correctionLabel.Size = new System.Drawing.Size(88, 19);
            this.correctionLabel.TabIndex = 86;
            this.correctionLabel.Text = "Correction :";
            this.correctionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.cancelButton.Location = new System.Drawing.Point(332, 580);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(88, 40);
            this.cancelButton.TabIndex = 15;
            this.cancelButton.Text = "Cancel";
            this.cancelButton.UseVisualStyleBackColor = false;
            this.cancelButton.Click += new System.EventHandler(this.cancelButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.saveButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.saveButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.saveButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.saveButton.Location = new System.Drawing.Point(106, 580);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(88, 40);
            this.saveButton.TabIndex = 14;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.ForeColor = System.Drawing.Color.Black;
            this.partsLabel.Location = new System.Drawing.Point(224, 401);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(103, 23);
            this.partsLabel.TabIndex = 83;
            this.partsLabel.Text = "Part Details";
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // techsLabel
            // 
            this.techsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.techsLabel.AutoSize = true;
            this.techsLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techsLabel.ForeColor = System.Drawing.Color.Black;
            this.techsLabel.Location = new System.Drawing.Point(224, 310);
            this.techsLabel.Name = "techsLabel";
            this.techsLabel.Size = new System.Drawing.Size(105, 23);
            this.techsLabel.TabIndex = 82;
            this.techsLabel.Text = "Tech Details";
            this.techsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctionTextBox
            // 
            this.correctionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.correctionTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.correctionTextBox.Location = new System.Drawing.Point(12, 242);
            this.correctionTextBox.Multiline = true;
            this.correctionTextBox.Name = "correctionTextBox";
            this.correctionTextBox.Size = new System.Drawing.Size(524, 65);
            this.correctionTextBox.TabIndex = 5;
            // 
            // creatingLabel
            // 
            this.creatingLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.creatingLabel.AutoSize = true;
            this.creatingLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.creatingLabel.ForeColor = System.Drawing.Color.Black;
            this.creatingLabel.Location = new System.Drawing.Point(8, 623);
            this.creatingLabel.Name = "creatingLabel";
            this.creatingLabel.Size = new System.Drawing.Size(135, 19);
            this.creatingLabel.TabIndex = 80;
            this.creatingLabel.Text = "Creating Record at";
            this.creatingLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addPartNumberBox
            // 
            this.addPartNumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addPartNumberBox.FormattingEnabled = true;
            this.addPartNumberBox.Location = new System.Drawing.Point(142, 457);
            this.addPartNumberBox.Name = "addPartNumberBox";
            this.addPartNumberBox.Size = new System.Drawing.Size(131, 21);
            this.addPartNumberBox.TabIndex = 113;
            this.addPartNumberBox.SelectedIndexChanged += new System.EventHandler(this.addPartNumberBox_SelectedIndexChanged);
            // 
            // partsGrid
            // 
            this.partsGrid.AllowUserToAddRows = false;
            this.partsGrid.AllowUserToDeleteRows = false;
            this.partsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.partsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGrid.Location = new System.Drawing.Point(11, 484);
            this.partsGrid.Name = "partsGrid";
            this.partsGrid.ReadOnly = true;
            this.partsGrid.Size = new System.Drawing.Size(524, 68);
            this.partsGrid.TabIndex = 114;
            // 
            // AddForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(548, 698);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "AddForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATLog";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label creatingRecordLabel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.TextBox addLocationBox;
        private System.Windows.Forms.TextBox addDescriptionBox;
        private System.Windows.Forms.TextBox addQuantityBox;
        private System.Windows.Forms.ComboBox addShiftBox;
        private System.Windows.Forms.DateTimePicker addUserDateTime;
        private System.Windows.Forms.TextBox addTimeTextBox;
        private System.Windows.Forms.ComboBox addUserBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.TextBox assetTextBox;
        private System.Windows.Forms.Label assetLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label complaintLabel;
        private System.Windows.Forms.TextBox complaintTextBox;
        private System.Windows.Forms.Label causeLabel;
        private System.Windows.Forms.TextBox causeTextBox;
        private System.Windows.Forms.Label correctionLabel;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Label techsLabel;
        private System.Windows.Forms.TextBox correctionTextBox;
        private System.Windows.Forms.Label creatingLabel;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Label locationLabel;
        private System.Windows.Forms.Label partNumberLabel;
        private System.Windows.Forms.Label quantityLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label timeLabel;
        private System.Windows.Forms.Label shiftLabel;
        private System.Windows.Forms.ComboBox addPartNumberBox;
        private System.Windows.Forms.DataGridView partsGrid;
    }
}