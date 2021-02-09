using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WiLog.My;

namespace WiLog
{
	[DesignerGenerated]
	public class frmPassword : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("lblUser")]
		private Label _lblUser;

		[AccessedThroughProperty("txtPword1")]
		private TextBox _txtPword1;

		[AccessedThroughProperty("txtPWord2")]
		private TextBox _txtPWord2;

		internal virtual Button btnCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmPassword _frmPassword = this;
				EventHandler eventHandler = new EventHandler(_frmPassword.btnCancel_Click);
				if (this._btnCancel != null)
				{
					this._btnCancel.Click -= eventHandler;
				}
				this._btnCancel = value;
				if (this._btnCancel != null)
				{
					this._btnCancel.Click += eventHandler;
				}
			}
		}

		internal virtual Button btnOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmPassword _frmPassword = this;
				EventHandler eventHandler = new EventHandler(_frmPassword.btnOK_Click);
				if (this._btnOK != null)
				{
					this._btnOK.Click -= eventHandler;
				}
				this._btnOK = value;
				if (this._btnOK != null)
				{
					this._btnOK.Click += eventHandler;
				}
			}
		}

		internal virtual Label lblUser
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblUser;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblUser = value;
			}
		}

		internal virtual TextBox txtPword1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtPword1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmPassword _frmPassword = this;
				EventHandler eventHandler = new EventHandler(_frmPassword.TextBox_TextChanged);
				if (this._txtPword1 != null)
				{
					this._txtPword1.TextChanged -= eventHandler;
				}
				this._txtPword1 = value;
				if (this._txtPword1 != null)
				{
					this._txtPword1.TextChanged += eventHandler;
				}
			}
		}

		internal virtual TextBox txtPWord2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtPWord2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmPassword _frmPassword = this;
				EventHandler eventHandler = new EventHandler(_frmPassword.TextBox_TextChanged);
				if (this._txtPWord2 != null)
				{
					this._txtPWord2.TextChanged -= eventHandler;
				}
				this._txtPWord2 = value;
				if (this._txtPWord2 != null)
				{
					this._txtPWord2.TextChanged += eventHandler;
				}
			}
		}

		[DebuggerNonUserCode]
		static frmPassword()
		{
			frmPassword.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public frmPassword()
		{
			frmPassword _frmPassword = this;
			base.Load += new EventHandler(_frmPassword.Form1_Load);
			frmPassword.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (frmPassword.__ENCList)
			{
				if (frmPassword.__ENCList.Count == frmPassword.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmPassword.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmPassword.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmPassword.__ENCList[item] = frmPassword.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmPassword.__ENCList.RemoveRange(item, checked(frmPassword.__ENCList.Count - item));
					frmPassword.__ENCList.Capacity = frmPassword.__ENCList.Count;
				}
				frmPassword.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void btnCancel_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnOK_Click(object sender, EventArgs e)
		{
			using (OracleConnection conn = new OracleConnection(Generals.oradb))
			{
				using (OracleCommand cmd = new OracleCommand())
				{
					conn.Open();
					cmd.Connection = conn;
					cmd.Parameters.Add(new OracleParameter("pUser_id", OracleDbType.NVarchar2)).Value = this.Text.ToUpper();
					cmd.CommandText = string.Concat("UPDATE zztechlog_techs set zztlt_Pword = '", this.txtPword1.Text, "' WHERE upper(zztlt_name) = :pUser_id ");
					cmd.CommandType = CommandType.Text;
					if (cmd.ExecuteNonQuery() <= 0)
					{
						this.txtPword1.Text = "";
						this.txtPWord2.Text = "";
					}
					else
					{
						Interaction.MsgBox(string.Concat("Password for ", MyProject.Forms.frmUsers.cbTechNames.Text, " Changed."), MsgBoxStyle.Information, "Password Changed.");
						this.txtPword1.Text = "";
						this.txtPWord2.Text = "";
						this.Dispose();
					}
					conn.Close();
					conn.Dispose();
				}
			}
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if ((!disposing || this.components == null ? false : true))
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		private void Form1_Load(object sender, EventArgs e)
		{
			this.lblUser.Text = string.Concat("Enter a NEW password for : ", MyProject.Forms.frmUsers.cbTechNames.Text);
			this.Text = MyProject.Forms.frmUsers.cbTechNames.Text;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.lblUser = new Label();
			this.txtPword1 = new TextBox();
			this.txtPWord2 = new TextBox();
			this.SuspendLayout();
			this.btnOK.Enabled = false;
			Button button = this.btnOK;
			Point point = new Point(29, 90);
			button.Location = point;
			this.btnOK.Name = "btnOK";
			Button button1 = this.btnOK;
			System.Drawing.Size size = new System.Drawing.Size(75, 23);
			button1.Size = size;
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "&O.K.";
			this.btnOK.UseVisualStyleBackColor = true;
			Button button2 = this.btnCancel;
			point = new Point(163, 90);
			button2.Location = point;
			this.btnCancel.Name = "btnCancel";
			Button button3 = this.btnCancel;
			size = new System.Drawing.Size(75, 23);
			button3.Size = size;
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.lblUser.AutoSize = true;
			Label label = this.lblUser;
			point = new Point(0, 9);
			label.Location = point;
			this.lblUser.Name = "lblUser";
			Label label1 = this.lblUser;
			size = new System.Drawing.Size(39, 13);
			label1.Size = size;
			this.lblUser.TabIndex = 2;
			this.lblUser.Text = "Label1";
			TextBox textBox = this.txtPword1;
			point = new Point(36, 25);
			textBox.Location = point;
			this.txtPword1.Name = "txtPword1";
			this.txtPword1.PasswordChar = '*';
			TextBox textBox1 = this.txtPword1;
			size = new System.Drawing.Size(191, 20);
			textBox1.Size = size;
			this.txtPword1.TabIndex = 3;
			TextBox textBox2 = this.txtPWord2;
			point = new Point(36, 51);
			textBox2.Location = point;
			this.txtPWord2.Name = "txtPWord2";
			this.txtPWord2.PasswordChar = '*';
			TextBox textBox3 = this.txtPWord2;
			size = new System.Drawing.Size(191, 20);
			textBox3.Size = size;
			this.txtPWord2.TabIndex = 4;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(272, 125);
			this.ClientSize = size;
			this.Controls.Add(this.txtPWord2);
			this.Controls.Add(this.txtPword1);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Name = "frmPassword";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Change Password";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void TextBox_TextChanged(object sender, EventArgs e)
		{
			if (!(this.txtPword1.Text.Length > 3 & this.txtPWord2.Text.Length > 3 & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPword1.Text, this.txtPWord2.Text, false) == 0))
			{
				this.btnOK.Enabled = false;
			}
			else
			{
				this.btnOK.Enabled = true;
			}
		}
	}
}