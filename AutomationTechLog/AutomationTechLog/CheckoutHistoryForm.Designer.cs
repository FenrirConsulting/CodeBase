namespace AutomationTechLog
{
    partial class CheckoutHistoryForm
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
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.historyDataGridView = new System.Windows.Forms.DataGridView();
<<<<<<< HEAD
            this.olderDateBox = new System.Windows.Forms.Label();
            this.olderRecordsCheckbox = new System.Windows.Forms.CheckBox();
=======
>>>>>>> b9e8015a19cc7162dd6e001a7c2c13fb0c2f5454
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(760, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 37);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 5;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.titleLabel.Location = new System.Drawing.Point(279, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(240, 29);
            this.titleLabel.TabIndex = 49;
            this.titleLabel.Text = "Parts Checkout History";
            // 
            // historyDataGridView
            // 
            this.historyDataGridView.AllowUserToAddRows = false;
            this.historyDataGridView.AllowUserToDeleteRows = false;
            this.historyDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.historyDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.historyDataGridView.Location = new System.Drawing.Point(12, 84);
            this.historyDataGridView.Name = "historyDataGridView";
            this.historyDataGridView.Size = new System.Drawing.Size(776, 354);
            this.historyDataGridView.TabIndex = 53;
            // 
<<<<<<< HEAD
            // olderDateBox
            // 
            this.olderDateBox.AutoSize = true;
            this.olderDateBox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olderDateBox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.olderDateBox.Location = new System.Drawing.Point(166, 60);
            this.olderDateBox.Name = "olderDateBox";
            this.olderDateBox.Size = new System.Drawing.Size(71, 15);
            this.olderDateBox.TabIndex = 55;
            this.olderDateBox.Text = "09-12-2020";
            // 
            // olderRecordsCheckbox
            // 
            this.olderRecordsCheckbox.AutoSize = true;
            this.olderRecordsCheckbox.Checked = true;
            this.olderRecordsCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.olderRecordsCheckbox.Font = new System.Drawing.Font("Calibri", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.olderRecordsCheckbox.ForeColor = System.Drawing.Color.WhiteSmoke;
            this.olderRecordsCheckbox.Location = new System.Drawing.Point(12, 59);
            this.olderRecordsCheckbox.Name = "olderRecordsCheckbox";
            this.olderRecordsCheckbox.Size = new System.Drawing.Size(158, 19);
            this.olderRecordsCheckbox.TabIndex = 54;
            this.olderRecordsCheckbox.Text = "Hide Records older than";
            this.olderRecordsCheckbox.UseVisualStyleBackColor = true;
            // 
=======
>>>>>>> b9e8015a19cc7162dd6e001a7c2c13fb0c2f5454
            // CheckoutHistoryForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
<<<<<<< HEAD
            this.Controls.Add(this.olderDateBox);
            this.Controls.Add(this.olderRecordsCheckbox);
=======
>>>>>>> b9e8015a19cc7162dd6e001a7c2c13fb0c2f5454
            this.Controls.Add(this.historyDataGridView);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CheckoutHistoryForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutHistoryForm";
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.historyDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.DataGridView historyDataGridView;
<<<<<<< HEAD
        private System.Windows.Forms.Label olderDateBox;
        private System.Windows.Forms.CheckBox olderRecordsCheckbox;
=======
>>>>>>> b9e8015a19cc7162dd6e001a7c2c13fb0c2f5454
    }
}