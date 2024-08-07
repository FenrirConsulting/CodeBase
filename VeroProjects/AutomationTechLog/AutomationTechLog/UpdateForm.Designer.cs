﻿
namespace AutomationTechLog
{
    partial class UpdateForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(UpdateForm));
            this.titlePanel = new System.Windows.Forms.Panel();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.generatedTitle = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.confirmButton = new System.Windows.Forms.Button();
            this.addPartNumberBox = new System.Windows.Forms.ComboBox();
            this.additionalComplaintsLabel = new System.Windows.Forms.Label();
            this.additionalComplaintsBox = new System.Windows.Forms.TextBox();
            this.additionalCauseLabel = new System.Windows.Forms.Label();
            this.additionalCausesBox = new System.Windows.Forms.TextBox();
            this.correctionAdditionLabel = new System.Windows.Forms.Label();
            this.additionalCorrectionsBox = new System.Windows.Forms.TextBox();
            this.addPartButton = new System.Windows.Forms.Button();
            this.addLocationBox = new System.Windows.Forms.TextBox();
            this.addDescriptionBox = new System.Windows.Forms.TextBox();
            this.addQuantityBox = new System.Windows.Forms.TextBox();
            this.addTechButton = new System.Windows.Forms.Button();
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.cancelButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.partsLabel = new System.Windows.Forms.Label();
            this.techsLabel = new System.Windows.Forms.Label();
            this.correctionTextBox = new System.Windows.Forms.TextBox();
            this.modifiedLabel = new System.Windows.Forms.Label();
            this.partsGrid = new System.Windows.Forms.DataGridView();
            this.userGrid = new System.Windows.Forms.DataGridView();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.bodyPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Controls.Add(this.generatedTitle);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(548, 47);
            this.titlePanel.TabIndex = 0;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint_1);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove_1);
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
            // generatedTitle
            // 
            this.generatedTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.generatedTitle.AutoSize = true;
            this.generatedTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.generatedTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.generatedTitle.Location = new System.Drawing.Point(12, 13);
            this.generatedTitle.Name = "generatedTitle";
            this.generatedTitle.Size = new System.Drawing.Size(173, 23);
            this.generatedTitle.TabIndex = 47;
            this.generatedTitle.Text = "User viewing Record";
            // 
            // bodyPanel
            // 
            this.bodyPanel.Controls.Add(this.confirmButton);
            this.bodyPanel.Controls.Add(this.addPartNumberBox);
            this.bodyPanel.Controls.Add(this.additionalComplaintsLabel);
            this.bodyPanel.Controls.Add(this.additionalComplaintsBox);
            this.bodyPanel.Controls.Add(this.additionalCauseLabel);
            this.bodyPanel.Controls.Add(this.additionalCausesBox);
            this.bodyPanel.Controls.Add(this.correctionAdditionLabel);
            this.bodyPanel.Controls.Add(this.additionalCorrectionsBox);
            this.bodyPanel.Controls.Add(this.addPartButton);
            this.bodyPanel.Controls.Add(this.addLocationBox);
            this.bodyPanel.Controls.Add(this.addDescriptionBox);
            this.bodyPanel.Controls.Add(this.addQuantityBox);
            this.bodyPanel.Controls.Add(this.addTechButton);
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
            this.bodyPanel.Controls.Add(this.deleteButton);
            this.bodyPanel.Controls.Add(this.cancelButton);
            this.bodyPanel.Controls.Add(this.saveButton);
            this.bodyPanel.Controls.Add(this.partsLabel);
            this.bodyPanel.Controls.Add(this.techsLabel);
            this.bodyPanel.Controls.Add(this.correctionTextBox);
            this.bodyPanel.Controls.Add(this.modifiedLabel);
            this.bodyPanel.Controls.Add(this.partsGrid);
            this.bodyPanel.Controls.Add(this.userGrid);
            this.bodyPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.bodyPanel.Location = new System.Drawing.Point(0, 47);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(548, 875);
            this.bodyPanel.TabIndex = 0;
            this.bodyPanel.Paint += new System.Windows.Forms.PaintEventHandler(this.bodyPanel_Paint);
            // 
            // confirmButton
            // 
            this.confirmButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.confirmButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.confirmButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.confirmButton.Location = new System.Drawing.Point(368, 808);
            this.confirmButton.Name = "confirmButton";
            this.confirmButton.Size = new System.Drawing.Size(111, 24);
            this.confirmButton.TabIndex = 88;
            this.confirmButton.Text = "Confirm Parts";
            this.confirmButton.UseVisualStyleBackColor = false;
            this.confirmButton.Click += new System.EventHandler(this.confirmButton_Click);
            // 
            // addPartNumberBox
            // 
            this.addPartNumberBox.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.SuggestAppend;
            this.addPartNumberBox.FormattingEnabled = true;
            this.addPartNumberBox.Location = new System.Drawing.Point(141, 686);
            this.addPartNumberBox.Name = "addPartNumberBox";
            this.addPartNumberBox.Size = new System.Drawing.Size(131, 21);
            this.addPartNumberBox.TabIndex = 87;
            this.addPartNumberBox.SelectedIndexChanged += new System.EventHandler(this.addPartNumberBox_SelectedIndexChanged);
            this.addPartNumberBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addPartNumberBox_KeyPress);
            // 
            // additionalComplaintsLabel
            // 
            this.additionalComplaintsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionalComplaintsLabel.AutoSize = true;
            this.additionalComplaintsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalComplaintsLabel.ForeColor = System.Drawing.Color.Black;
            this.additionalComplaintsLabel.Location = new System.Drawing.Point(12, 108);
            this.additionalComplaintsLabel.Name = "additionalComplaintsLabel";
            this.additionalComplaintsLabel.Size = new System.Drawing.Size(131, 15);
            this.additionalComplaintsLabel.TabIndex = 86;
            this.additionalComplaintsLabel.Text = "Additional Complaints:";
            this.additionalComplaintsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // additionalComplaintsBox
            // 
            this.additionalComplaintsBox.BackColor = System.Drawing.SystemColors.Info;
            this.additionalComplaintsBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.additionalComplaintsBox.Location = new System.Drawing.Point(12, 123);
            this.additionalComplaintsBox.Multiline = true;
            this.additionalComplaintsBox.Name = "additionalComplaintsBox";
            this.additionalComplaintsBox.Size = new System.Drawing.Size(524, 57);
            this.additionalComplaintsBox.TabIndex = 85;
            // 
            // additionalCauseLabel
            // 
            this.additionalCauseLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.additionalCauseLabel.AutoSize = true;
            this.additionalCauseLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.additionalCauseLabel.ForeColor = System.Drawing.Color.Black;
            this.additionalCauseLabel.Location = new System.Drawing.Point(12, 258);
            this.additionalCauseLabel.Name = "additionalCauseLabel";
            this.additionalCauseLabel.Size = new System.Drawing.Size(107, 15);
            this.additionalCauseLabel.TabIndex = 84;
            this.additionalCauseLabel.Text = "Additional Causes:";
            this.additionalCauseLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // additionalCausesBox
            // 
            this.additionalCausesBox.BackColor = System.Drawing.SystemColors.Info;
            this.additionalCausesBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.additionalCausesBox.Location = new System.Drawing.Point(12, 273);
            this.additionalCausesBox.Multiline = true;
            this.additionalCausesBox.Name = "additionalCausesBox";
            this.additionalCausesBox.Size = new System.Drawing.Size(524, 57);
            this.additionalCausesBox.TabIndex = 83;
            // 
            // correctionAdditionLabel
            // 
            this.correctionAdditionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.correctionAdditionLabel.AutoSize = true;
            this.correctionAdditionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctionAdditionLabel.ForeColor = System.Drawing.Color.Black;
            this.correctionAdditionLabel.Location = new System.Drawing.Point(13, 408);
            this.correctionAdditionLabel.Name = "correctionAdditionLabel";
            this.correctionAdditionLabel.Size = new System.Drawing.Size(133, 15);
            this.correctionAdditionLabel.TabIndex = 82;
            this.correctionAdditionLabel.Text = "Additional Corrections:";
            this.correctionAdditionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // additionalCorrectionsBox
            // 
            this.additionalCorrectionsBox.BackColor = System.Drawing.SystemColors.Info;
            this.additionalCorrectionsBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.additionalCorrectionsBox.Location = new System.Drawing.Point(12, 423);
            this.additionalCorrectionsBox.Multiline = true;
            this.additionalCorrectionsBox.Name = "additionalCorrectionsBox";
            this.additionalCorrectionsBox.Size = new System.Drawing.Size(524, 57);
            this.additionalCorrectionsBox.TabIndex = 81;
            // 
            // addPartButton
            // 
            this.addPartButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.addPartButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addPartButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addPartButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.addPartButton.Location = new System.Drawing.Point(432, 658);
            this.addPartButton.Name = "addPartButton";
            this.addPartButton.Size = new System.Drawing.Size(100, 24);
            this.addPartButton.TabIndex = 80;
            this.addPartButton.Text = "Add Part";
            this.addPartButton.UseVisualStyleBackColor = false;
            this.addPartButton.Click += new System.EventHandler(this.addPartButton_Click);
            // 
            // addLocationBox
            // 
            this.addLocationBox.Location = new System.Drawing.Point(271, 686);
            this.addLocationBox.Name = "addLocationBox";
            this.addLocationBox.ReadOnly = true;
            this.addLocationBox.Size = new System.Drawing.Size(131, 20);
            this.addLocationBox.TabIndex = 12;
            this.addLocationBox.Text = "Unassigned";
            // 
            // addDescriptionBox
            // 
            this.addDescriptionBox.Location = new System.Drawing.Point(401, 686);
            this.addDescriptionBox.Name = "addDescriptionBox";
            this.addDescriptionBox.ReadOnly = true;
            this.addDescriptionBox.Size = new System.Drawing.Size(131, 20);
            this.addDescriptionBox.TabIndex = 77;
            this.addDescriptionBox.Text = "Description";
            // 
            // addQuantityBox
            // 
            this.addQuantityBox.Location = new System.Drawing.Point(11, 686);
            this.addQuantityBox.Name = "addQuantityBox";
            this.addQuantityBox.Size = new System.Drawing.Size(131, 20);
            this.addQuantityBox.TabIndex = 10;
            this.addQuantityBox.Text = "0";
            this.addQuantityBox.TextChanged += new System.EventHandler(this.addQuantityBox_TextChanged);
            // 
            // addTechButton
            // 
            this.addTechButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.addTechButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.addTechButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addTechButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.addTechButton.Location = new System.Drawing.Point(432, 507);
            this.addTechButton.Name = "addTechButton";
            this.addTechButton.Size = new System.Drawing.Size(100, 24);
            this.addTechButton.TabIndex = 75;
            this.addTechButton.Text = "Add Tech";
            this.addTechButton.UseVisualStyleBackColor = false;
            this.addTechButton.Click += new System.EventHandler(this.addTechButton_Click);
            // 
            // addShiftBox
            // 
            this.addShiftBox.FormattingEnabled = true;
            this.addShiftBox.Items.AddRange(new object[] {
            "1",
            "2",
            "3"});
            this.addShiftBox.Location = new System.Drawing.Point(11, 537);
            this.addShiftBox.Name = "addShiftBox";
            this.addShiftBox.Size = new System.Drawing.Size(131, 21);
            this.addShiftBox.TabIndex = 6;
            // 
            // addUserDateTime
            // 
            this.addUserDateTime.CustomFormat = "\"MM-dd-yyyy\"";
            this.addUserDateTime.Location = new System.Drawing.Point(271, 537);
            this.addUserDateTime.Name = "addUserDateTime";
            this.addUserDateTime.Size = new System.Drawing.Size(131, 20);
            this.addUserDateTime.TabIndex = 8;
            // 
            // addTimeTextBox
            // 
            this.addTimeTextBox.Location = new System.Drawing.Point(141, 537);
            this.addTimeTextBox.Name = "addTimeTextBox";
            this.addTimeTextBox.Size = new System.Drawing.Size(131, 20);
            this.addTimeTextBox.TabIndex = 7;
            this.addTimeTextBox.TextChanged += new System.EventHandler(this.addTimeTextBox_TextChanged);
            // 
            // addUserBox
            // 
            this.addUserBox.FormattingEnabled = true;
            this.addUserBox.Location = new System.Drawing.Point(401, 537);
            this.addUserBox.Name = "addUserBox";
            this.addUserBox.Size = new System.Drawing.Size(131, 21);
            this.addUserBox.TabIndex = 9;
            // 
            // stateComboBox
            // 
            this.stateComboBox.FormattingEnabled = true;
            this.stateComboBox.Items.AddRange(new object[] {
            "Started",
            "Memo",
            "Entered",
            "Completed"});
            this.stateComboBox.Location = new System.Drawing.Point(60, 6);
            this.stateComboBox.Name = "stateComboBox";
            this.stateComboBox.Size = new System.Drawing.Size(121, 21);
            this.stateComboBox.TabIndex = 0;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Enabled = false;
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Items.AddRange(new object[] {
            "Planned",
            "Unplanned",
            "System Support",
            "Facility",
            "Passdown"});
            this.typeComboBox.Location = new System.Drawing.Point(221, 6);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(121, 21);
            this.typeComboBox.TabIndex = 1;
            // 
            // assetTextBox
            // 
            this.assetTextBox.Location = new System.Drawing.Point(405, 6);
            this.assetTextBox.Name = "assetTextBox";
            this.assetTextBox.ReadOnly = true;
            this.assetTextBox.Size = new System.Drawing.Size(131, 20);
            this.assetTextBox.TabIndex = 2;
            // 
            // assetLabel
            // 
            this.assetLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.assetLabel.AutoSize = true;
            this.assetLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.assetLabel.ForeColor = System.Drawing.Color.Black;
            this.assetLabel.Location = new System.Drawing.Point(365, 12);
            this.assetLabel.Name = "assetLabel";
            this.assetLabel.Size = new System.Drawing.Size(41, 15);
            this.assetLabel.TabIndex = 63;
            this.assetLabel.Text = "Asset:";
            this.assetLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // typeLabel
            // 
            this.typeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.typeLabel.AutoSize = true;
            this.typeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.typeLabel.ForeColor = System.Drawing.Color.Black;
            this.typeLabel.Location = new System.Drawing.Point(187, 12);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(37, 15);
            this.typeLabel.TabIndex = 62;
            this.typeLabel.Text = "Type:";
            this.typeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // stateLabel
            // 
            this.stateLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.stateLabel.AutoSize = true;
            this.stateLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.stateLabel.ForeColor = System.Drawing.Color.Black;
            this.stateLabel.Location = new System.Drawing.Point(17, 12);
            this.stateLabel.Name = "stateLabel";
            this.stateLabel.Size = new System.Drawing.Size(43, 15);
            this.stateLabel.TabIndex = 61;
            this.stateLabel.Text = "State: ";
            this.stateLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // complaintLabel
            // 
            this.complaintLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.complaintLabel.AutoSize = true;
            this.complaintLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.complaintLabel.ForeColor = System.Drawing.Color.Black;
            this.complaintLabel.Location = new System.Drawing.Point(12, 30);
            this.complaintLabel.Name = "complaintLabel";
            this.complaintLabel.Size = new System.Drawing.Size(70, 15);
            this.complaintLabel.TabIndex = 60;
            this.complaintLabel.Text = "Complaint :";
            this.complaintLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // complaintTextBox
            // 
            this.complaintTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.complaintTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.complaintTextBox.Location = new System.Drawing.Point(11, 48);
            this.complaintTextBox.Multiline = true;
            this.complaintTextBox.Name = "complaintTextBox";
            this.complaintTextBox.ReadOnly = true;
            this.complaintTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.complaintTextBox.Size = new System.Drawing.Size(524, 57);
            this.complaintTextBox.TabIndex = 3;
            // 
            // causeLabel
            // 
            this.causeLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.causeLabel.AutoSize = true;
            this.causeLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.causeLabel.ForeColor = System.Drawing.Color.Black;
            this.causeLabel.Location = new System.Drawing.Point(12, 183);
            this.causeLabel.Name = "causeLabel";
            this.causeLabel.Size = new System.Drawing.Size(46, 15);
            this.causeLabel.TabIndex = 58;
            this.causeLabel.Text = "Cause :";
            this.causeLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // causeTextBox
            // 
            this.causeTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.causeTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.causeTextBox.Location = new System.Drawing.Point(12, 198);
            this.causeTextBox.Multiline = true;
            this.causeTextBox.Name = "causeTextBox";
            this.causeTextBox.ReadOnly = true;
            this.causeTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.causeTextBox.Size = new System.Drawing.Size(524, 57);
            this.causeTextBox.TabIndex = 4;
            // 
            // correctionLabel
            // 
            this.correctionLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.correctionLabel.AutoSize = true;
            this.correctionLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.correctionLabel.ForeColor = System.Drawing.Color.Black;
            this.correctionLabel.Location = new System.Drawing.Point(12, 333);
            this.correctionLabel.Name = "correctionLabel";
            this.correctionLabel.Size = new System.Drawing.Size(72, 15);
            this.correctionLabel.TabIndex = 56;
            this.correctionLabel.Text = "Correction :";
            this.correctionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.deleteButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.deleteButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.deleteButton.Location = new System.Drawing.Point(272, 808);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(63, 24);
            this.deleteButton.TabIndex = 15;
            this.deleteButton.Text = "Delete";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // cancelButton
            // 
            this.cancelButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.cancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.cancelButton.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelButton.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.cancelButton.Location = new System.Drawing.Point(176, 808);
            this.cancelButton.Name = "cancelButton";
            this.cancelButton.Size = new System.Drawing.Size(63, 24);
            this.cancelButton.TabIndex = 14;
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
            this.saveButton.Location = new System.Drawing.Point(80, 808);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(63, 24);
            this.saveButton.TabIndex = 13;
            this.saveButton.Text = "Save";
            this.saveButton.UseVisualStyleBackColor = false;
            this.saveButton.Click += new System.EventHandler(this.saveButton_Click);
            // 
            // partsLabel
            // 
            this.partsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partsLabel.AutoSize = true;
            this.partsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsLabel.ForeColor = System.Drawing.Color.Black;
            this.partsLabel.Location = new System.Drawing.Point(14, 668);
            this.partsLabel.Name = "partsLabel";
            this.partsLabel.Size = new System.Drawing.Size(56, 15);
            this.partsLabel.TabIndex = 52;
            this.partsLabel.Text = "Parts: (x)";
            this.partsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // techsLabel
            // 
            this.techsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.techsLabel.AutoSize = true;
            this.techsLabel.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.techsLabel.ForeColor = System.Drawing.Color.Black;
            this.techsLabel.Location = new System.Drawing.Point(13, 516);
            this.techsLabel.Name = "techsLabel";
            this.techsLabel.Size = new System.Drawing.Size(57, 15);
            this.techsLabel.TabIndex = 51;
            this.techsLabel.Text = "Techs: (x)";
            this.techsLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // correctionTextBox
            // 
            this.correctionTextBox.BackColor = System.Drawing.SystemColors.Info;
            this.correctionTextBox.ForeColor = System.Drawing.Color.OrangeRed;
            this.correctionTextBox.Location = new System.Drawing.Point(12, 348);
            this.correctionTextBox.Multiline = true;
            this.correctionTextBox.Name = "correctionTextBox";
            this.correctionTextBox.ReadOnly = true;
            this.correctionTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.correctionTextBox.Size = new System.Drawing.Size(524, 57);
            this.correctionTextBox.TabIndex = 5;
            // 
            // modifiedLabel
            // 
            this.modifiedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.modifiedLabel.AutoSize = true;
            this.modifiedLabel.Font = new System.Drawing.Font("Calibri", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.modifiedLabel.ForeColor = System.Drawing.Color.Black;
            this.modifiedLabel.Location = new System.Drawing.Point(8, 847);
            this.modifiedLabel.Name = "modifiedLabel";
            this.modifiedLabel.Size = new System.Drawing.Size(147, 19);
            this.modifiedLabel.TabIndex = 49;
            this.modifiedLabel.Text = "Last Modified by On";
            this.modifiedLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partsGrid
            // 
            this.partsGrid.AllowUserToAddRows = false;
            this.partsGrid.AllowUserToDeleteRows = false;
            this.partsGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.partsGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.partsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsGrid.Location = new System.Drawing.Point(12, 712);
            this.partsGrid.Name = "partsGrid";
            this.partsGrid.ReadOnly = true;
            this.partsGrid.Size = new System.Drawing.Size(520, 68);
            this.partsGrid.TabIndex = 2;
            this.partsGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.partsGrid_CellMouseClick);
            this.partsGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.partsGrid_CellValidating);
            // 
            // userGrid
            // 
            this.userGrid.AllowUserToAddRows = false;
            this.userGrid.AllowUserToDeleteRows = false;
            this.userGrid.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.userGrid.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.userGrid.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Sunken;
            this.userGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.userGrid.GridColor = System.Drawing.SystemColors.Desktop;
            this.userGrid.Location = new System.Drawing.Point(11, 563);
            this.userGrid.Name = "userGrid";
            this.userGrid.Size = new System.Drawing.Size(521, 89);
            this.userGrid.TabIndex = 1;
            this.userGrid.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.userGrid_CellClick);
            this.userGrid.CellMouseClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.userGrid_CellMouseClick);
            this.userGrid.CellValidating += new System.Windows.Forms.DataGridViewCellValidatingEventHandler(this.userGrid_CellValidating);
            // 
            // UpdateForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(548, 922);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "UpdateForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ATLog";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.bodyPanel.ResumeLayout(false);
            this.bodyPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsGrid)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.userGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label generatedTitle;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.DataGridView partsGrid;
        private System.Windows.Forms.DataGridView userGrid;
        private System.Windows.Forms.Label modifiedLabel;
        private System.Windows.Forms.TextBox correctionTextBox;
        private System.Windows.Forms.Label techsLabel;
        private System.Windows.Forms.Label partsLabel;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button cancelButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.Label correctionLabel;
        private System.Windows.Forms.Label complaintLabel;
        private System.Windows.Forms.TextBox complaintTextBox;
        private System.Windows.Forms.Label causeLabel;
        private System.Windows.Forms.TextBox causeTextBox;
        private System.Windows.Forms.Label stateLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label assetLabel;
        private System.Windows.Forms.TextBox assetTextBox;
        private System.Windows.Forms.ComboBox typeComboBox;
        private System.Windows.Forms.ComboBox stateComboBox;
        private System.Windows.Forms.ComboBox addUserBox;
        private System.Windows.Forms.TextBox addTimeTextBox;
        private System.Windows.Forms.DateTimePicker addUserDateTime;
        private System.Windows.Forms.ComboBox addShiftBox;
        private System.Windows.Forms.Button addTechButton;
        private System.Windows.Forms.TextBox addLocationBox;
        private System.Windows.Forms.TextBox addDescriptionBox;
        private System.Windows.Forms.TextBox addQuantityBox;
        private System.Windows.Forms.Button addPartButton;
        private System.Windows.Forms.Label correctionAdditionLabel;
        private System.Windows.Forms.TextBox additionalCorrectionsBox;
        private System.Windows.Forms.Label additionalCauseLabel;
        private System.Windows.Forms.TextBox additionalCausesBox;
        private System.Windows.Forms.Label additionalComplaintsLabel;
        private System.Windows.Forms.TextBox additionalComplaintsBox;
        private System.Windows.Forms.ComboBox addPartNumberBox;
        private System.Windows.Forms.Button confirmButton;
    }
}