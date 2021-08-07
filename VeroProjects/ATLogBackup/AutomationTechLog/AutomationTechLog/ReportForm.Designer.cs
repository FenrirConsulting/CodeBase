namespace AutomationTechLog
{
    partial class ReportForm
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
            this.titlePanel = new System.Windows.Forms.Panel();
            this.resizeButton = new System.Windows.Forms.PictureBox();
            this.partsTitle = new System.Windows.Forms.Label();
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.splitContainer = new System.Windows.Forms.SplitContainer();
            this.reportViewer1 = new Microsoft.Reporting.WinForms.ReportViewer();
            this.olderDateBox = new System.Windows.Forms.Label();
            this.olderRecordsCheckbox = new System.Windows.Forms.CheckBox();
            this.reportSelectionBox = new System.Windows.Forms.ComboBox();
            this.reportLabel = new System.Windows.Forms.Label();
            this.runReportButton = new System.Windows.Forms.PictureBox();
            this.titlePanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).BeginInit();
            this.splitContainer.Panel1.SuspendLayout();
            this.splitContainer.Panel2.SuspendLayout();
            this.splitContainer.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.runReportButton)).BeginInit();
            this.SuspendLayout();
            // 
            // titlePanel
            // 
            this.titlePanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.titlePanel.Controls.Add(this.resizeButton);
            this.titlePanel.Controls.Add(this.partsTitle);
            this.titlePanel.Controls.Add(this.closeButton);
            this.titlePanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.titlePanel.Location = new System.Drawing.Point(0, 0);
            this.titlePanel.Name = "titlePanel";
            this.titlePanel.Size = new System.Drawing.Size(1100, 47);
            this.titlePanel.TabIndex = 4;
            this.titlePanel.Paint += new System.Windows.Forms.PaintEventHandler(this.titlePanel_Paint);
            this.titlePanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.titlePanel_MouseMove);
            // 
            // resizeButton
            // 
            this.resizeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.resizeButton.Image = global::AutomationTechLog.Properties.Resources.resizeIcon;
            this.resizeButton.Location = new System.Drawing.Point(1044, 0);
            this.resizeButton.Name = "resizeButton";
            this.resizeButton.Size = new System.Drawing.Size(28, 47);
            this.resizeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.resizeButton.TabIndex = 50;
            this.resizeButton.TabStop = false;
            this.resizeButton.Click += new System.EventHandler(this.resizeButton_Click);
            // 
            // partsTitle
            // 
            this.partsTitle.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.partsTitle.AutoSize = true;
            this.partsTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.partsTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.partsTitle.Location = new System.Drawing.Point(568, 13);
            this.partsTitle.Name = "partsTitle";
            this.partsTitle.Size = new System.Drawing.Size(73, 23);
            this.partsTitle.TabIndex = 49;
            this.partsTitle.Text = "Reports";
            // 
            // closeButton
            // 
            this.closeButton.Dock = System.Windows.Forms.DockStyle.Right;
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(1072, 0);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 47);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 48;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // splitContainer
            // 
            this.splitContainer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.splitContainer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.splitContainer.FixedPanel = System.Windows.Forms.FixedPanel.Panel1;
            this.splitContainer.Location = new System.Drawing.Point(0, 47);
            this.splitContainer.Name = "splitContainer";
            this.splitContainer.Orientation = System.Windows.Forms.Orientation.Horizontal;
            // 
            // splitContainer.Panel1
            // 
            this.splitContainer.Panel1.Controls.Add(this.runReportButton);
            this.splitContainer.Panel1.Controls.Add(this.reportLabel);
            this.splitContainer.Panel1.Controls.Add(this.reportSelectionBox);
            this.splitContainer.Panel1.Controls.Add(this.olderDateBox);
            this.splitContainer.Panel1.Controls.Add(this.olderRecordsCheckbox);
            // 
            // splitContainer.Panel2
            // 
            this.splitContainer.Panel2.Controls.Add(this.reportViewer1);
            this.splitContainer.Size = new System.Drawing.Size(1100, 553);
            this.splitContainer.SplitterDistance = 46;
            this.splitContainer.SplitterWidth = 1;
            this.splitContainer.TabIndex = 5;
            this.splitContainer.Paint += new System.Windows.Forms.PaintEventHandler(this.splitContainer_Paint);
            // 
            // reportViewer1
            // 
            this.reportViewer1.AutoSize = true;
            this.reportViewer1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.reportViewer1.Location = new System.Drawing.Point(0, 0);
            this.reportViewer1.Name = "ReportViewer";
            this.reportViewer1.ServerReport.BearerToken = null;
            this.reportViewer1.Size = new System.Drawing.Size(1098, 504);
            this.reportViewer1.TabIndex = 0;
            // 
            // olderDateBox
            // 
            this.olderDateBox.AutoSize = true;
            this.olderDateBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olderDateBox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.olderDateBox.Location = new System.Drawing.Point(450, 12);
            this.olderDateBox.Name = "olderDateBox";
            this.olderDateBox.Size = new System.Drawing.Size(101, 20);
            this.olderDateBox.TabIndex = 48;
            this.olderDateBox.Text = "09-12-2020";
            // 
            // olderRecordsCheckbox
            // 
            this.olderRecordsCheckbox.AutoSize = true;
            this.olderRecordsCheckbox.Checked = true;
            this.olderRecordsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.olderRecordsCheckbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olderRecordsCheckbox.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.olderRecordsCheckbox.Location = new System.Drawing.Point(221, 12);
            this.olderRecordsCheckbox.Name = "olderRecordsCheckbox";
            this.olderRecordsCheckbox.Size = new System.Drawing.Size(223, 24);
            this.olderRecordsCheckbox.TabIndex = 47;
            this.olderRecordsCheckbox.Text = "Hide Records older than";
            this.olderRecordsCheckbox.UseVisualStyleBackColor = true;
            // 
            // reportSelectionBox
            // 
            this.reportSelectionBox.FormattingEnabled = true;
            this.reportSelectionBox.Items.AddRange(new object[] {
            "Parts Report"});
            this.reportSelectionBox.Location = new System.Drawing.Point(699, 12);
            this.reportSelectionBox.Name = "reportSelectionBox";
            this.reportSelectionBox.Size = new System.Drawing.Size(121, 21);
            this.reportSelectionBox.TabIndex = 49;
            // 
            // reportLabel
            // 
            this.reportLabel.AutoSize = true;
            this.reportLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.reportLabel.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.reportLabel.Location = new System.Drawing.Point(599, 12);
            this.reportLabel.Name = "reportLabel";
            this.reportLabel.Size = new System.Drawing.Size(94, 20);
            this.reportLabel.TabIndex = 50;
            this.reportLabel.Text = "Selection :";
            // 
            // runReportButton
            // 
            this.runReportButton.Image = global::AutomationTechLog.Properties.Resources.Report;
            this.runReportButton.Location = new System.Drawing.Point(826, 8);
            this.runReportButton.Name = "runReportButton";
            this.runReportButton.Size = new System.Drawing.Size(51, 33);
            this.runReportButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.runReportButton.TabIndex = 51;
            this.runReportButton.TabStop = false;
            this.runReportButton.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // ReportForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(1100, 600);
            this.Controls.Add(this.splitContainer);
            this.Controls.Add(this.titlePanel);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "ReportForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "ReportForm";
            this.titlePanel.ResumeLayout(false);
            this.titlePanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.resizeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.splitContainer.Panel1.ResumeLayout(false);
            this.splitContainer.Panel1.PerformLayout();
            this.splitContainer.Panel2.ResumeLayout(false);
            this.splitContainer.Panel2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.splitContainer)).EndInit();
            this.splitContainer.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.runReportButton)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel titlePanel;
        private System.Windows.Forms.Label partsTitle;
        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.PictureBox resizeButton;
        private System.Windows.Forms.SplitContainer splitContainer;
        private Microsoft.Reporting.WinForms.ReportViewer reportViewer1;
        private System.Windows.Forms.Label olderDateBox;
        private System.Windows.Forms.CheckBox olderRecordsCheckbox;
        private System.Windows.Forms.ComboBox reportSelectionBox;
        private System.Windows.Forms.Label reportLabel;
        private System.Windows.Forms.PictureBox runReportButton;
    }
}