namespace AutomationTechLog
{
    partial class CheckoutForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(CheckoutForm));
            this.closeButton = new System.Windows.Forms.PictureBox();
            this.partsBox = new System.Windows.Forms.TextBox();
            this.userBox = new System.Windows.Forms.TextBox();
            this.titleLabel = new System.Windows.Forms.Label();
            this.swipeNameLabel = new System.Windows.Forms.Label();
            this.clockLabel = new System.Windows.Forms.Label();
            this.userPanel = new System.Windows.Forms.Panel();
            this.userSwipedLabel = new System.Windows.Forms.Label();
            this.bodyPanel = new System.Windows.Forms.Panel();
            this.confirmLabel = new System.Windows.Forms.Label();
            this.partsPanel = new System.Windows.Forms.Panel();
            this.swipePartsLabel = new System.Windows.Forms.Label();
            this.foundUserLabel = new System.Windows.Forms.Label();
            this.partsDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).BeginInit();
            this.userPanel.SuspendLayout();
            this.bodyPanel.SuspendLayout();
            this.partsPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.closeButton.Image = global::AutomationTechLog.Properties.Resources.exit;
            this.closeButton.Location = new System.Drawing.Point(562, 12);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(28, 37);
            this.closeButton.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.closeButton.TabIndex = 4;
            this.closeButton.TabStop = false;
            this.closeButton.Click += new System.EventHandler(this.closeButton_Click);
            // 
            // partsBox
            // 
            this.partsBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.partsBox.Location = new System.Drawing.Point(172, 42);
            this.partsBox.Name = "partsBox";
            this.partsBox.PasswordChar = '*';
            this.partsBox.Size = new System.Drawing.Size(169, 20);
            this.partsBox.TabIndex = 6;
            this.partsBox.TextChanged += new System.EventHandler(this.partsBox_TextChanged);
            // 
            // userBox
            // 
            this.userBox.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.userBox.Location = new System.Drawing.Point(172, 32);
            this.userBox.Name = "userBox";
            this.userBox.PasswordChar = '*';
            this.userBox.Size = new System.Drawing.Size(169, 20);
            this.userBox.TabIndex = 5;
            this.userBox.TextChanged += new System.EventHandler(this.userBox_TextChanged);
            // 
            // titleLabel
            // 
            this.titleLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.titleLabel.AutoSize = true;
            this.titleLabel.Font = new System.Drawing.Font("Calibri", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titleLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.titleLabel.Location = new System.Drawing.Point(220, 12);
            this.titleLabel.Name = "titleLabel";
            this.titleLabel.Size = new System.Drawing.Size(163, 29);
            this.titleLabel.TabIndex = 48;
            this.titleLabel.Text = "Parts Checkout";
            // 
            // swipeNameLabel
            // 
            this.swipeNameLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.swipeNameLabel.AutoSize = true;
            this.swipeNameLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swipeNameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.swipeNameLabel.Location = new System.Drawing.Point(172, 3);
            this.swipeNameLabel.Name = "swipeNameLabel";
            this.swipeNameLabel.Size = new System.Drawing.Size(169, 26);
            this.swipeNameLabel.TabIndex = 49;
            this.swipeNameLabel.Text = "Swipe User Badge";
            // 
            // clockLabel
            // 
            this.clockLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clockLabel.ForeColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.clockLabel.Location = new System.Drawing.Point(24, 24);
            this.clockLabel.Name = "clockLabel";
            this.clockLabel.Size = new System.Drawing.Size(513, 33);
            this.clockLabel.TabIndex = 50;
            this.clockLabel.Text = "Test Text";
            this.clockLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // userPanel
            // 
            this.userPanel.BackColor = System.Drawing.SystemColors.Info;
            this.userPanel.Controls.Add(this.foundUserLabel);
            this.userPanel.Controls.Add(this.userSwipedLabel);
            this.userPanel.Controls.Add(this.userBox);
            this.userPanel.Controls.Add(this.swipeNameLabel);
            this.userPanel.Location = new System.Drawing.Point(24, 73);
            this.userPanel.Name = "userPanel";
            this.userPanel.Size = new System.Drawing.Size(513, 64);
            this.userPanel.TabIndex = 87;
            // 
            // userSwipedLabel
            // 
            this.userSwipedLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.userSwipedLabel.AutoSize = true;
            this.userSwipedLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.userSwipedLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.userSwipedLabel.Location = new System.Drawing.Point(3, 28);
            this.userSwipedLabel.Name = "userSwipedLabel";
            this.userSwipedLabel.Size = new System.Drawing.Size(134, 23);
            this.userSwipedLabel.TabIndex = 50;
            this.userSwipedLabel.Text = "User Not Found";
            // 
            // bodyPanel
            // 
            this.bodyPanel.BackColor = System.Drawing.SystemColors.WindowFrame;
            this.bodyPanel.Controls.Add(this.confirmLabel);
            this.bodyPanel.Controls.Add(this.partsPanel);
            this.bodyPanel.Controls.Add(this.userPanel);
            this.bodyPanel.Controls.Add(this.clockLabel);
            this.bodyPanel.Location = new System.Drawing.Point(18, 55);
            this.bodyPanel.Name = "bodyPanel";
            this.bodyPanel.Size = new System.Drawing.Size(563, 482);
            this.bodyPanel.TabIndex = 88;
            // 
            // confirmLabel
            // 
            this.confirmLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.confirmLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.confirmLabel.ForeColor = System.Drawing.Color.Yellow;
            this.confirmLabel.Location = new System.Drawing.Point(24, 435);
            this.confirmLabel.Name = "confirmLabel";
            this.confirmLabel.Size = new System.Drawing.Size(513, 26);
            this.confirmLabel.TabIndex = 51;
            this.confirmLabel.Text = "Swipe Badge Again to Confirm Parts";
            this.confirmLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partsPanel
            // 
            this.partsPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.partsPanel.Controls.Add(this.partsDataGridView);
            this.partsPanel.Controls.Add(this.swipePartsLabel);
            this.partsPanel.Controls.Add(this.partsBox);
            this.partsPanel.Location = new System.Drawing.Point(24, 156);
            this.partsPanel.Name = "partsPanel";
            this.partsPanel.Size = new System.Drawing.Size(513, 255);
            this.partsPanel.TabIndex = 88;
            // 
            // swipePartsLabel
            // 
            this.swipePartsLabel.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.swipePartsLabel.AutoSize = true;
            this.swipePartsLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.swipePartsLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.swipePartsLabel.Location = new System.Drawing.Point(200, 13);
            this.swipePartsLabel.Name = "swipePartsLabel";
            this.swipePartsLabel.Size = new System.Drawing.Size(113, 26);
            this.swipePartsLabel.TabIndex = 51;
            this.swipePartsLabel.Text = "Swipe Parts";
            // 
            // foundUserLabel
            // 
            this.foundUserLabel.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.foundUserLabel.Font = new System.Drawing.Font("Calibri", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.foundUserLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.foundUserLabel.Location = new System.Drawing.Point(42, 19);
            this.foundUserLabel.Name = "foundUserLabel";
            this.foundUserLabel.Size = new System.Drawing.Size(429, 26);
            this.foundUserLabel.TabIndex = 51;
            this.foundUserLabel.Text = "Found User";
            this.foundUserLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // partsDataGridView
            // 
            this.partsDataGridView.AllowUserToAddRows = false;
            this.partsDataGridView.AllowUserToDeleteRows = false;
            this.partsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.partsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.partsDataGridView.Location = new System.Drawing.Point(7, 78);
            this.partsDataGridView.Name = "partsDataGridView";
            this.partsDataGridView.Size = new System.Drawing.Size(503, 150);
            this.partsDataGridView.TabIndex = 52;
            // 
            // CheckoutForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(602, 552);
            this.Controls.Add(this.bodyPanel);
            this.Controls.Add(this.titleLabel);
            this.Controls.Add(this.closeButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "CheckoutForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "CheckoutForm";
            this.Paint += new System.Windows.Forms.PaintEventHandler(this.CheckoutForm_Paint);
            ((System.ComponentModel.ISupportInitialize)(this.closeButton)).EndInit();
            this.userPanel.ResumeLayout(false);
            this.userPanel.PerformLayout();
            this.bodyPanel.ResumeLayout(false);
            this.partsPanel.ResumeLayout(false);
            this.partsPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.partsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox closeButton;
        private System.Windows.Forms.TextBox partsBox;
        private System.Windows.Forms.TextBox userBox;
        private System.Windows.Forms.Label titleLabel;
        private System.Windows.Forms.Label swipeNameLabel;
        private System.Windows.Forms.Label clockLabel;
        private System.Windows.Forms.Panel userPanel;
        private System.Windows.Forms.Label userSwipedLabel;
        private System.Windows.Forms.Panel bodyPanel;
        private System.Windows.Forms.Panel partsPanel;
        private System.Windows.Forms.Label swipePartsLabel;
        private System.Windows.Forms.Label confirmLabel;
        private System.Windows.Forms.Label foundUserLabel;
        private System.Windows.Forms.DataGridView partsDataGridView;
    }
}