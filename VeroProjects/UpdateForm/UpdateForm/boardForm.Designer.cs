namespace UpdateForm
{
    partial class boardForm
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
            this.closeButton = new System.Windows.Forms.Button();
            this.copyButton = new System.Windows.Forms.Button();
            this.launchButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // closeButton
            // 
            this.closeButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.closeButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.closeButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.closeButton.Location = new System.Drawing.Point(46, 141);
            this.closeButton.Name = "closeButton";
            this.closeButton.Size = new System.Drawing.Size(113, 51);
            this.closeButton.TabIndex = 16;
            this.closeButton.Text = "Close Window";
            this.closeButton.UseCompatibleTextRendering = true;
            this.closeButton.UseVisualStyleBackColor = false;
            // 
            // copyButton
            // 
            this.copyButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.copyButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.copyButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.copyButton.Location = new System.Drawing.Point(46, 54);
            this.copyButton.Name = "copyButton";
            this.copyButton.Size = new System.Drawing.Size(113, 51);
            this.copyButton.TabIndex = 17;
            this.copyButton.Text = "Copy Files";
            this.copyButton.UseCompatibleTextRendering = true;
            this.copyButton.UseVisualStyleBackColor = false;
            this.copyButton.Click += new System.EventHandler(this.copyButton_Click);
            // 
            // launchButton
            // 
            this.launchButton.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.launchButton.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.launchButton.Font = new System.Drawing.Font("Times New Roman", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.launchButton.Location = new System.Drawing.Point(227, 54);
            this.launchButton.Name = "launchButton";
            this.launchButton.Size = new System.Drawing.Size(113, 51);
            this.launchButton.TabIndex = 18;
            this.launchButton.Text = "Launch Boards";
            this.launchButton.UseCompatibleTextRendering = true;
            this.launchButton.UseVisualStyleBackColor = false;
            this.launchButton.Click += new System.EventHandler(this.launchButton_Click);
            // 
            // boardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.ClientSize = new System.Drawing.Size(404, 252);
            this.Controls.Add(this.launchButton);
            this.Controls.Add(this.copyButton);
            this.Controls.Add(this.closeButton);
            this.Name = "boardForm";
            this.Text = "Performance Boards";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button closeButton;
        private System.Windows.Forms.Button copyButton;
        private System.Windows.Forms.Button launchButton;

    }
}