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
	public class FrmChangePassword : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("txtPWord2")]
		private TextBox _txtPWord2;

		[AccessedThroughProperty("txtPword1")]
		private TextBox _txtPword1;

		[AccessedThroughProperty("lblUser")]
		private Label _lblUser;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("txtOldPassword")]
		private TextBox _txtOldPassword;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

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
				FrmChangePassword frmChangePassword = this;
				EventHandler eventHandler = new EventHandler(frmChangePassword.btnCancel_Click);
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
				FrmChangePassword frmChangePassword = this;
				EventHandler eventHandler = new EventHandler(frmChangePassword.btnOK_Click);
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

		internal virtual Label Label1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label1 = value;
			}
		}

		internal virtual Label Label2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Label2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Label2 = value;
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

		internal virtual TextBox txtOldPassword
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtOldPassword;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtOldPassword = value;
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
				this._txtPword1 = value;
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
				FrmChangePassword frmChangePassword = this;
				EventHandler eventHandler = new EventHandler(frmChangePassword.txtPWord2_TextChanged);
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
		static FrmChangePassword()
		{
			FrmChangePassword.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public FrmChangePassword()
		{
			FrmChangePassword frmChangePassword = this;
			base.Load += new EventHandler(frmChangePassword.FrmChangePassword_Load);
			FrmChangePassword.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (FrmChangePassword.__ENCList)
			{
				if (FrmChangePassword.__ENCList.Count == FrmChangePassword.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(FrmChangePassword.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (FrmChangePassword.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								FrmChangePassword.__ENCList[item] = FrmChangePassword.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					FrmChangePassword.__ENCList.RemoveRange(item, checked(FrmChangePassword.__ENCList.Count - item));
					FrmChangePassword.__ENCList.Capacity = FrmChangePassword.__ENCList.Count;
				}
				FrmChangePassword.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
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
					cmd.Parameters.Add(new OracleParameter("pUser_id", OracleDbType.NVarchar2)).Value = Generals.CurUserName;
					cmd.Parameters.Add(new OracleParameter("pOldPWord", OracleDbType.NVarchar2)).Value = this.txtOldPassword.Text;
					cmd.CommandText = "SELECT Count(*) FROM zztechlog_techs WHERE upper(zztlt_name) = :pUser_id and zztlt_Pword = :pOldPWord ";
					cmd.CommandType = CommandType.Text;
					if (cmd.ExecuteNonQuery() > 0)
					{
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
					else
					{
						MessageBox.Show("User does not match entered old password.", "User: ");
						this.txtOldPassword.Text = "";
						this.txtPword1.Text = "";
						this.txtPWord2.Text = "";
						return;
					}
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

		private void FrmChangePassword_Load(object sender, EventArgs e)
		{
			this.btnOK.Enabled = false;
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.txtPWord2 = new TextBox();
			this.txtPword1 = new TextBox();
			this.lblUser = new Label();
			this.btnCancel = new Button();
			this.btnOK = new Button();
			this.txtOldPassword = new TextBox();
			this.Label1 = new Label();
			this.Label2 = new Label();
			this.SuspendLayout();
			TextBox textBox = this.txtPWord2;
			Point point = new Point(125, 57);
			textBox.Location = point;
			this.txtPWord2.Name = "txtPWord2";
			this.txtPWord2.PasswordChar = '*';
			TextBox textBox1 = this.txtPWord2;
			System.Drawing.Size size = new System.Drawing.Size(191, 20);
			textBox1.Size = size;
			this.txtPWord2.TabIndex = 9;
			TextBox textBox2 = this.txtPword1;
			point = new Point(125, 31);
			textBox2.Location = point;
			this.txtPword1.Name = "txtPword1";
			this.txtPword1.PasswordChar = '*';
			TextBox textBox3 = this.txtPword1;
			size = new System.Drawing.Size(191, 20);
			textBox3.Size = size;
			this.txtPword1.TabIndex = 8;
			this.lblUser.AutoSize = true;
			Label label = this.lblUser;
			point = new Point(17, 10);
			label.Location = point;
			this.lblUser.Name = "lblUser";
			Label label1 = this.lblUser;
			size = new System.Drawing.Size(70, 13);
			label1.Size = size;
			this.lblUser.TabIndex = 7;
			this.lblUser.Text = "Old Pasword:";
			Button button = this.btnCancel;
			point = new Point(180, 91);
			button.Location = point;
			this.btnCancel.Name = "btnCancel";
			Button button1 = this.btnCancel;
			size = new System.Drawing.Size(75, 23);
			button1.Size = size;
			this.btnCancel.TabIndex = 6;
			this.btnCancel.Text = "&Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.btnOK.Enabled = false;
			Button button2 = this.btnOK;
			point = new Point(46, 91);
			button2.Location = point;
			this.btnOK.Name = "btnOK";
			Button button3 = this.btnOK;
			size = new System.Drawing.Size(75, 23);
			button3.Size = size;
			this.btnOK.TabIndex = 5;
			this.btnOK.Text = "&O.K.";
			this.btnOK.UseVisualStyleBackColor = true;
			TextBox textBox4 = this.txtOldPassword;
			point = new Point(125, 7);
			textBox4.Location = point;
			this.txtOldPassword.Name = "txtOldPassword";
			this.txtOldPassword.PasswordChar = '*';
			TextBox textBox5 = this.txtOldPassword;
			size = new System.Drawing.Size(191, 20);
			textBox5.Size = size;
			this.txtOldPassword.TabIndex = 10;
			this.Label1.AutoSize = true;
			Label label11 = this.Label1;
			point = new Point(17, 34);
			label11.Location = point;
			this.Label1.Name = "Label1";
			Label label12 = this.Label1;
			size = new System.Drawing.Size(76, 13);
			label12.Size = size;
			this.Label1.TabIndex = 11;
			this.Label1.Text = "New Pasword:";
			this.Label2.AutoSize = true;
			Label label2 = this.Label2;
			point = new Point(17, 60);
			label2.Location = point;
			this.Label2.Name = "Label2";
			Label label21 = this.Label2;
			size = new System.Drawing.Size(76, 13);
			label21.Size = size;
			this.Label2.TabIndex = 12;
			this.Label2.Text = "New Pasword:";
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(329, 125);
			this.ClientSize = size;
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtOldPassword);
			this.Controls.Add(this.txtPWord2);
			this.Controls.Add(this.txtPword1);
			this.Controls.Add(this.lblUser);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Name = "FrmChangePassword";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "FrmChangePassword";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void txtPWord2_TextChanged(object sender, EventArgs e)
		{
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPword1.Text, this.txtPWord2.Text, false) == 0 & !string.IsNullOrEmpty(this.txtOldPassword.Text) & this.txtPword1.TextLength > 3)
			{
				this.btnOK.Enabled = true;
			}
		}
	}
}