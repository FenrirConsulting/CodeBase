namespace MorningRecap
{
    partial class SharePointForm
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
            this.usernameLabel = new System.Windows.Forms.Label();
            this.passwordLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.credentialsButton = new System.Windows.Forms.Button();
            this.passwordBox = new System.Windows.Forms.TextBox();
            this.usernameBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.createLabel = new System.Windows.Forms.Label();
            this.listCreation = new System.Windows.Forms.Button();
            this.listCreateBox = new System.Windows.Forms.TextBox();
            this.listCreateTitle = new System.Windows.Forms.Label();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label1 = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            this.deleteBox = new System.Windows.Forms.TextBox();
            this.deleteTitle = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.SuspendLayout();
            // 
            // usernameLabel
            // 
            this.usernameLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.usernameLabel.AutoSize = true;
            this.usernameLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.usernameLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.usernameLabel.Location = new System.Drawing.Point(19, 10);
            this.usernameLabel.Name = "usernameLabel";
            this.usernameLabel.Size = new System.Drawing.Size(150, 23);
            this.usernameLabel.TabIndex = 1;
            this.usernameLabel.Text = "Username (Email)";
            // 
            // passwordLabel
            // 
            this.passwordLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.passwordLabel.AutoSize = true;
            this.passwordLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.passwordLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.passwordLabel.Location = new System.Drawing.Point(19, 68);
            this.passwordLabel.Name = "passwordLabel";
            this.passwordLabel.Size = new System.Drawing.Size(86, 23);
            this.passwordLabel.TabIndex = 2;
            this.passwordLabel.Text = "Password";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.panel1.Controls.Add(this.credentialsButton);
            this.panel1.Controls.Add(this.passwordBox);
            this.panel1.Controls.Add(this.usernameBox);
            this.panel1.Controls.Add(this.usernameLabel);
            this.panel1.Controls.Add(this.passwordLabel);
            this.panel1.Location = new System.Drawing.Point(21, 27);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(218, 175);
            this.panel1.TabIndex = 3;
            // 
            // credentialsButton
            // 
            this.credentialsButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.credentialsButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.credentialsButton.Location = new System.Drawing.Point(19, 132);
            this.credentialsButton.Name = "credentialsButton";
            this.credentialsButton.Size = new System.Drawing.Size(105, 23);
            this.credentialsButton.TabIndex = 5;
            this.credentialsButton.Text = "Save Credentials";
            this.credentialsButton.UseVisualStyleBackColor = false;
            this.credentialsButton.Click += new System.EventHandler(this.credentialsButton_Click);
            // 
            // passwordBox
            // 
            this.passwordBox.Location = new System.Drawing.Point(19, 94);
            this.passwordBox.Name = "passwordBox";
            this.passwordBox.PasswordChar = '*';
            this.passwordBox.Size = new System.Drawing.Size(146, 20);
            this.passwordBox.TabIndex = 4;
            // 
            // usernameBox
            // 
            this.usernameBox.Location = new System.Drawing.Point(19, 36);
            this.usernameBox.Name = "usernameBox";
            this.usernameBox.Size = new System.Drawing.Size(146, 20);
            this.usernameBox.TabIndex = 3;
            // 
            // panel2
            // 
            this.panel2.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.panel2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.panel2.Controls.Add(this.createLabel);
            this.panel2.Controls.Add(this.listCreation);
            this.panel2.Controls.Add(this.listCreateBox);
            this.panel2.Controls.Add(this.listCreateTitle);
            this.panel2.Location = new System.Drawing.Point(297, 37);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(577, 165);
            this.panel2.TabIndex = 4;
            // 
            // createLabel
            // 
            this.createLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.createLabel.AutoSize = true;
            this.createLabel.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.createLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.createLabel.Location = new System.Drawing.Point(31, 22);
            this.createLabel.Name = "createLabel";
            this.createLabel.Size = new System.Drawing.Size(95, 23);
            this.createLabel.TabIndex = 7;
            this.createLabel.Text = "Create List";
            // 
            // listCreation
            // 
            this.listCreation.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.listCreation.ForeColor = System.Drawing.Color.Gainsboro;
            this.listCreation.Location = new System.Drawing.Point(12, 122);
            this.listCreation.Name = "listCreation";
            this.listCreation.Size = new System.Drawing.Size(105, 23);
            this.listCreation.TabIndex = 6;
            this.listCreation.Text = "Create List";
            this.listCreation.UseVisualStyleBackColor = false;
            this.listCreation.Click += new System.EventHandler(this.listCreation_Click);
            // 
            // listCreateBox
            // 
            this.listCreateBox.Location = new System.Drawing.Point(12, 84);
            this.listCreateBox.Name = "listCreateBox";
            this.listCreateBox.Size = new System.Drawing.Size(146, 20);
            this.listCreateBox.TabIndex = 5;
            // 
            // listCreateTitle
            // 
            this.listCreateTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.listCreateTitle.AutoSize = true;
            this.listCreateTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.listCreateTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.listCreateTitle.Location = new System.Drawing.Point(8, 58);
            this.listCreateTitle.Name = "listCreateTitle";
            this.listCreateTitle.Size = new System.Drawing.Size(50, 23);
            this.listCreateTitle.TabIndex = 4;
            this.listCreateTitle.Text = "Title ";
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(58)))), ((int)(((byte)(66)))));
            this.panel3.Controls.Add(this.label1);
            this.panel3.Controls.Add(this.deleteButton);
            this.panel3.Controls.Add(this.deleteBox);
            this.panel3.Controls.Add(this.deleteTitle);
            this.panel3.Location = new System.Drawing.Point(297, 234);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(350, 165);
            this.panel3.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.label1.Location = new System.Drawing.Point(31, 22);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 23);
            this.label1.TabIndex = 7;
            this.label1.Text = "Delete List";
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(11)))), ((int)(((byte)(12)))), ((int)(((byte)(13)))));
            this.deleteButton.ForeColor = System.Drawing.Color.Gainsboro;
            this.deleteButton.Location = new System.Drawing.Point(12, 122);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(105, 23);
            this.deleteButton.TabIndex = 6;
            this.deleteButton.Text = "Delete List";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // deleteBox
            // 
            this.deleteBox.Location = new System.Drawing.Point(12, 84);
            this.deleteBox.Name = "deleteBox";
            this.deleteBox.Size = new System.Drawing.Size(146, 20);
            this.deleteBox.TabIndex = 5;
            // 
            // deleteTitle
            // 
            this.deleteTitle.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.deleteTitle.AutoSize = true;
            this.deleteTitle.Font = new System.Drawing.Font("Calibri", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(241)))), ((int)(((byte)(75)))), ((int)(((byte)(53)))));
            this.deleteTitle.Location = new System.Drawing.Point(8, 58);
            this.deleteTitle.Name = "deleteTitle";
            this.deleteTitle.Size = new System.Drawing.Size(50, 23);
            this.deleteTitle.TabIndex = 4;
            this.deleteTitle.Text = "Title ";
            // 
            // SharePointForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(40)))), ((int)(((byte)(44)))), ((int)(((byte)(52)))));
            this.ClientSize = new System.Drawing.Size(886, 870);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.panel2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "SharePointForm";
            this.Text = "SharePointForm";
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label usernameLabel;
        private System.Windows.Forms.Label passwordLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox passwordBox;
        private System.Windows.Forms.TextBox usernameBox;
        private System.Windows.Forms.Button credentialsButton;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button listCreation;
        private System.Windows.Forms.TextBox listCreateBox;
        private System.Windows.Forms.Label listCreateTitle;
        private System.Windows.Forms.Label createLabel;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.TextBox deleteBox;
        private System.Windows.Forms.Label deleteTitle;
    }
}