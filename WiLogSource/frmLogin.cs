using Microsoft.VisualBasic.CompilerServices;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WiLog.My;

namespace WiLog
{
	[DesignerGenerated]
	public class frmLogin : Form
	{
		private static List<WeakReference> __ENCList;

		[AccessedThroughProperty("LogoPictureBox")]
		private PictureBox _LogoPictureBox;

		[AccessedThroughProperty("UsernameLabel")]
		private Label _UsernameLabel;

		[AccessedThroughProperty("PasswordLabel")]
		private Label _PasswordLabel;

		[AccessedThroughProperty("txtUsername")]
		private TextBox _txtUsername;

		[AccessedThroughProperty("txtPassword")]
		private TextBox _txtPassword;

		[AccessedThroughProperty("OK")]
		private Button _OK;

		[AccessedThroughProperty("Cancel")]
		private Button _Cancel;

		private IContainer components;

		[AccessedThroughProperty("lblAttempt")]
		private Label _lblAttempt;

		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[AccessedThroughProperty("tmrAppIdle")]
		private Timer _tmrAppIdle;

		[AccessedThroughProperty("lblVersion")]
		private Label _lblVersion;

		[AccessedThroughProperty("lblError")]
		private Label _lblError;

		private int AttemptCount;

		internal virtual Button Cancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Cancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmLogin _frmLogin = this;
				EventHandler eventHandler = new EventHandler(_frmLogin.Cancel_Click);
				if (this._Cancel != null)
				{
					this._Cancel.Click -= eventHandler;
				}
				this._Cancel = value;
				if (this._Cancel != null)
				{
					this._Cancel.Click += eventHandler;
				}
			}
		}

		internal virtual Label lblAttempt
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblAttempt;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblAttempt = value;
			}
		}

		internal virtual Label lblError
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblError;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblError = value;
			}
		}

		internal virtual Label lblVersion
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblVersion;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblVersion = value;
			}
		}

		internal virtual PictureBox LogoPictureBox
		{
			[DebuggerNonUserCode]
			get
			{
				return this._LogoPictureBox;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._LogoPictureBox = value;
			}
		}

		internal virtual Button OK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._OK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmLogin _frmLogin = this;
				EventHandler eventHandler = new EventHandler(_frmLogin.OK_Click);
				if (this._OK != null)
				{
					this._OK.Click -= eventHandler;
				}
				this._OK = value;
				if (this._OK != null)
				{
					this._OK.Click += eventHandler;
				}
			}
		}

		internal virtual Label PasswordLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasswordLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PasswordLabel = value;
			}
		}

		internal virtual Timer tmrAppIdle
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tmrAppIdle;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tmrAppIdle = value;
			}
		}

		internal virtual ToolTip ToolTip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolTip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolTip1 = value;
			}
		}

		internal virtual TextBox txtPassword
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtPassword;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtPassword = value;
			}
		}

		internal virtual TextBox txtUsername
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtUsername;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtUsername = value;
			}
		}

		internal virtual Label UsernameLabel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._UsernameLabel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._UsernameLabel = value;
			}
		}

		[DebuggerNonUserCode]
		static frmLogin()
		{
			frmLogin.__ENCList = new List<WeakReference>();
		}

		public frmLogin()
		{
			frmLogin _frmLogin = this;
			base.Load += new EventHandler(_frmLogin.frmLogin_Load);
			frmLogin.__ENCAddToList(this);
			this.AttemptCount = 0;
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (frmLogin.__ENCList)
			{
				if (frmLogin.__ENCList.Count == frmLogin.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmLogin.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmLogin.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmLogin.__ENCList[item] = frmLogin.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmLogin.__ENCList.RemoveRange(item, checked(frmLogin.__ENCList.Count - item));
					frmLogin.__ENCList.Capacity = frmLogin.__ENCList.Count;
				}
				frmLogin.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void Cancel_Click(object sender, EventArgs e)
		{
			this.Close();
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

		private void frmLogin_Load(object sender, EventArgs e)
		{
			this.lblVersion.Text = string.Concat("Version\r\n", Application.ProductVersion.ToString());
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frmLogin));
			this.LogoPictureBox = new PictureBox();
			this.UsernameLabel = new Label();
			this.PasswordLabel = new Label();
			this.txtUsername = new TextBox();
			this.txtPassword = new TextBox();
			this.OK = new Button();
			this.Cancel = new Button();
			this.lblAttempt = new Label();
			this.ToolTip1 = new ToolTip(this.components);
			this.tmrAppIdle = new Timer(this.components);
			this.lblVersion = new Label();
			this.lblError = new Label();
			((ISupportInitialize)this.LogoPictureBox).BeginInit();
			this.SuspendLayout();
			this.LogoPictureBox.Image = (Image)resources.GetObject("LogoPictureBox.Image");
			PictureBox logoPictureBox = this.LogoPictureBox;
			Point point = new Point(-1, 1);
			logoPictureBox.Location = point;
			this.LogoPictureBox.Name = "LogoPictureBox";
			PictureBox pictureBox = this.LogoPictureBox;
			System.Drawing.Size size = new System.Drawing.Size(394, 104);
			pictureBox.Size = size;
			this.LogoPictureBox.SizeMode = PictureBoxSizeMode.StretchImage;
			this.LogoPictureBox.TabIndex = 0;
			this.LogoPictureBox.TabStop = false;
			this.ToolTip1.SetToolTip(this.LogoPictureBox, "WiLog is designed to allow inputing parts, labor\r\n and shift notes from a remote desktop.  Please\r\n share your ideas to improve the system.");
			Label usernameLabel = this.UsernameLabel;
			point = new Point(85, 103);
			usernameLabel.Location = point;
			this.UsernameLabel.Name = "UsernameLabel";
			Label label = this.UsernameLabel;
			size = new System.Drawing.Size(220, 23);
			label.Size = size;
			this.UsernameLabel.TabIndex = 0;
			this.UsernameLabel.Text = "&User name";
			this.UsernameLabel.TextAlign = ContentAlignment.MiddleLeft;
			Label passwordLabel = this.PasswordLabel;
			point = new Point(85, 146);
			passwordLabel.Location = point;
			this.PasswordLabel.Name = "PasswordLabel";
			Label passwordLabel1 = this.PasswordLabel;
			size = new System.Drawing.Size(220, 23);
			passwordLabel1.Size = size;
			this.PasswordLabel.TabIndex = 2;
			this.PasswordLabel.Text = "&Password";
			this.PasswordLabel.TextAlign = ContentAlignment.MiddleLeft;
			TextBox textBox = this.txtUsername;
			point = new Point(87, 123);
			textBox.Location = point;
			this.txtUsername.Name = "txtUsername";
			TextBox textBox1 = this.txtUsername;
			size = new System.Drawing.Size(220, 20);
			textBox1.Size = size;
			this.txtUsername.TabIndex = 1;
			this.ToolTip1.SetToolTip(this.txtUsername, "AMS User name");
			TextBox textBox2 = this.txtPassword;
			point = new Point(87, 166);
			textBox2.Location = point;
			this.txtPassword.Name = "txtPassword";
			this.txtPassword.PasswordChar = '*';
			TextBox textBox3 = this.txtPassword;
			size = new System.Drawing.Size(220, 20);
			textBox3.Size = size;
			this.txtPassword.TabIndex = 3;
			this.ToolTip1.SetToolTip(this.txtPassword, "AMS User Password");
			Button oK = this.OK;
			point = new Point(98, 193);
			oK.Location = point;
			this.OK.Name = "OK";
			Button button = this.OK;
			size = new System.Drawing.Size(94, 23);
			button.Size = size;
			this.OK.TabIndex = 4;
			this.OK.Text = "&OK";
			this.ToolTip1.SetToolTip(this.OK, "Submit this form");
			this.Cancel.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			Button cancel = this.Cancel;
			point = new Point(201, 193);
			cancel.Location = point;
			this.Cancel.Name = "Cancel";
			Button cancel1 = this.Cancel;
			size = new System.Drawing.Size(94, 23);
			cancel1.Size = size;
			this.Cancel.TabIndex = 5;
			this.Cancel.Text = "&Cancel";
			this.ToolTip1.SetToolTip(this.Cancel, "Close this form");
			this.lblAttempt.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25f, FontStyle.Regular, GraphicsUnit.Point, 0);
			this.lblAttempt.ForeColor = Color.Red;
			Label label1 = this.lblAttempt;
			point = new Point(362, 189);
			label1.Location = point;
			this.lblAttempt.Name = "lblAttempt";
			Label label2 = this.lblAttempt;
			size = new System.Drawing.Size(30, 25);
			label2.Size = size;
			this.lblAttempt.TabIndex = 6;
			this.ToolTip1.SetToolTip(this.lblAttempt, "Failed attempts");
			this.tmrAppIdle.Enabled = true;
			this.tmrAppIdle.Interval = 1000;
			this.lblVersion.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			Label label3 = this.lblVersion;
			point = new Point(323, 146);
			label3.Location = point;
			this.lblVersion.Name = "lblVersion";
			Label label4 = this.lblVersion;
			size = new System.Drawing.Size(69, 26);
			label4.Size = size;
			this.lblVersion.TabIndex = 7;
			this.lblVersion.Text = "lblVersion";
			this.lblError.AutoSize = true;
			this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25f, FontStyle.Bold, GraphicsUnit.Point, 0);
			this.lblError.ForeColor = Color.Red;
			Label label5 = this.lblError;
			point = new Point(163, 219);
			label5.Location = point;
			this.lblError.Name = "lblError";
			Label label6 = this.lblError;
			size = new System.Drawing.Size(47, 13);
			label6.Size = size;
			this.lblError.TabIndex = 8;
			this.lblError.Text = "lblError";
			this.lblError.Visible = false;
			this.AcceptButton = this.OK;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.Cancel;
			size = new System.Drawing.Size(394, 252);
			this.ClientSize = size;
			this.ControlBox = false;
			this.Controls.Add(this.lblError);
			this.Controls.Add(this.lblVersion);
			this.Controls.Add(this.lblAttempt);
			this.Controls.Add(this.LogoPictureBox);
			this.Controls.Add(this.Cancel);
			this.Controls.Add(this.OK);
			this.Controls.Add(this.txtPassword);
			this.Controls.Add(this.txtUsername);
			this.Controls.Add(this.PasswordLabel);
			this.Controls.Add(this.UsernameLabel);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmLogin";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "WiLog Login";
			((ISupportInitialize)this.LogoPictureBox).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void OK_Click(object sender, EventArgs e)
		{
			this.Cursor = Cursors.WaitCursor;
			this.lblError.Visible = false;
			this.lblError.Text = "";
			if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtUsername.Text, "", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.txtPassword.Text, "", false) == 0 ? false : true))
			{
				using (OracleConnection conn = new OracleConnection(Generals.oradb))
				{
					using (OracleCommand cmd = new OracleCommand())
					{
						conn.Open();
						cmd.Connection = conn;
						OracleParameter p1 = new OracleParameter("user_id", OracleDbType.Varchar2)
						{
							Value = this.txtUsername.Text.ToUpper()
						};
						cmd.Parameters.Add(p1);
						OracleParameter p2 = new OracleParameter("password", OracleDbType.Varchar2)
						{
							Value = this.txtPassword.Text
						};
						cmd.Parameters.Add(p2);
						cmd.CommandText = "SELECT * FROM zztechlog_techs WHERE upper(zztlt_auname) = :user_id and zztlt_Pword  = :password and zztlt_isActive = 'True' ";
						cmd.CommandType = CommandType.Text;
						using (OracleDataReader dr = cmd.ExecuteReader())
						{
							if (!dr.Read())
							{
								this.AttemptCount = checked(this.AttemptCount + 1);
								this.lblAttempt.Text = this.AttemptCount.ToString();
								this.Cursor = Cursors.Default;
								if (this.AttemptCount >= 3)
								{
									this.Close();
								}
							}
							else
							{
								Generals.CurUserName = Conversions.ToString(dr["ZZTLT_NAME"]);
								Generals.CurUserShift = Conversions.ToString(dr["ZZTLT_SHIFT"]);
								Generals.CurUserAdmin = Conversions.ToString(dr["ZZTLT_ISAdmin"]);
								Generals.CurUserIsLead = Conversions.ToString(dr["ZZTLT_ISLEAD"]);
								Generals.CurUserIsPartsLead = Conversions.ToString(dr["ZZTLT_ISPartsLEAD"]);
								this.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject("Welcome ", dr["zztlt_name"]), " !"));
								this.Cursor = Cursors.Default;
								MyProject.Forms.frmMain.dgvOverview.DataSource = null;
								MyProject.Forms.frmMain.Show();
								this.Hide();
							}
							dr.Close();
						}
						this.txtPassword.Text = "";
						conn.Close();
						conn.Dispose();
					}
				}
			}
			else
			{
				MessageBox.Show("Please complete the required fields.", "Authentication Error");
			}
		}

		[DllImport("dllsbi.dll", CharSet=CharSet.Ansi, EntryPoint="_SBI_strPassword@16", ExactSpelling=true, SetLastError=true)]
		private static extern long SBI_strPassword(ref string pName, long lName, long bFill, long bDecode);

		public enum AAMS_passwordEncryption
		{
			NoneEncryptionCaseInsensitive,
			SBIEncryptionCaseInsensitive,
			NoneEncryption,
			SBIEncryption
		}
	}
}