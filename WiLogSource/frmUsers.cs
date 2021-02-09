using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Net;
using System.Net.Mail;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WiLog.My;

namespace WiLog
{
	[DesignerGenerated]
	public class frmUsers : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("lblName")]
		private Label _lblName;

		[AccessedThroughProperty("lblShift")]
		private Label _lblShift;

		[AccessedThroughProperty("chkIsLead")]
		private CheckBox _chkIsLead;

		[AccessedThroughProperty("cbShift")]
		private ComboBox _cbShift;

		[AccessedThroughProperty("chkAdmin")]
		private CheckBox _chkAdmin;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[AccessedThroughProperty("cbTechNames")]
		private ComboBox _cbTechNames;

		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[AccessedThroughProperty("clbAMSUsers")]
		private CheckedListBox _clbAMSUsers;

		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[AccessedThroughProperty("chkPartsLead")]
		private CheckBox _chkPartsLead;

		[AccessedThroughProperty("chkActive")]
		private CheckBox _chkActive;

		[AccessedThroughProperty("btnPassword")]
		private Button _btnPassword;

		internal virtual Button btnClose
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnClose;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmUsers frmUser = this;
				EventHandler eventHandler = new EventHandler(frmUser.btnClose_Click);
				if (this._btnClose != null)
				{
					this._btnClose.Click -= eventHandler;
				}
				this._btnClose = value;
				if (this._btnClose != null)
				{
					this._btnClose.Click += eventHandler;
				}
			}
		}

		internal virtual Button btnNew
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnNew;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmUsers frmUser = this;
				EventHandler eventHandler = new EventHandler(frmUser.btnSave_Click);
				if (this._btnNew != null)
				{
					this._btnNew.Click -= eventHandler;
				}
				this._btnNew = value;
				if (this._btnNew != null)
				{
					this._btnNew.Click += eventHandler;
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
				this._btnOK = value;
			}
		}

		internal virtual Button btnPassword
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnPassword;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmUsers frmUser = this;
				EventHandler eventHandler = new EventHandler(frmUser.btnPassword_Click);
				if (this._btnPassword != null)
				{
					this._btnPassword.Click -= eventHandler;
				}
				this._btnPassword = value;
				if (this._btnPassword != null)
				{
					this._btnPassword.Click += eventHandler;
				}
			}
		}

		internal virtual ComboBox cbShift
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbShift;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbShift = value;
			}
		}

		internal virtual ComboBox cbTechNames
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbTechNames;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmUsers frmUser = this;
				EventHandler eventHandler = new EventHandler(frmUser.cbTechNames_SelectedIndexChanged);
				if (this._cbTechNames != null)
				{
					this._cbTechNames.SelectedIndexChanged -= eventHandler;
				}
				this._cbTechNames = value;
				if (this._cbTechNames != null)
				{
					this._cbTechNames.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual CheckBox chkActive
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkActive;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkActive = value;
			}
		}

		internal virtual CheckBox chkAdmin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkAdmin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkAdmin = value;
			}
		}

		internal virtual CheckBox chkIsLead
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkIsLead;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkIsLead = value;
			}
		}

		internal virtual CheckBox chkPartsLead
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkPartsLead;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._chkPartsLead = value;
			}
		}

		internal virtual CheckedListBox clbAMSUsers
		{
			[DebuggerNonUserCode]
			get
			{
				return this._clbAMSUsers;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmUsers frmUser = this;
				ItemCheckEventHandler itemCheckEventHandler = new ItemCheckEventHandler(frmUser.clbAMSUsers_ItemCheck);
				frmUsers frmUser1 = this;
				EventHandler eventHandler = new EventHandler(frmUser1.clbAMSUsers_SelectedIndexChanged);
				if (this._clbAMSUsers != null)
				{
					this._clbAMSUsers.ItemCheck -= itemCheckEventHandler;
					this._clbAMSUsers.SelectedIndexChanged -= eventHandler;
				}
				this._clbAMSUsers = value;
				if (this._clbAMSUsers != null)
				{
					this._clbAMSUsers.ItemCheck += itemCheckEventHandler;
					this._clbAMSUsers.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual Label lblName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblName = value;
			}
		}

		internal virtual Label lblShift
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblShift;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblShift = value;
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

		[DebuggerNonUserCode]
		static frmUsers()
		{
			frmUsers.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public frmUsers()
		{
			frmUsers frmUser = this;
			base.Load += new EventHandler(frmUser.frmUsers_Load);
			frmUsers.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (frmUsers.__ENCList)
			{
				if (frmUsers.__ENCList.Count == frmUsers.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmUsers.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmUsers.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmUsers.__ENCList[item] = frmUsers.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmUsers.__ENCList.RemoveRange(item, checked(frmUsers.__ENCList.Count - item));
					frmUsers.__ENCList.Capacity = frmUsers.__ENCList.Count;
				}
				frmUsers.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnPassword_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmPassword.StartPosition = FormStartPosition.CenterParent;
			MyProject.Forms.frmPassword.ShowDialog();
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmNewUser.Show();
		}

		private void cbTechNames_SelectedIndexChanged(object sender, EventArgs e)
		{
			using (OracleConnection conn = new OracleConnection(Generals.oradb))
			{
				DataTable tbl_Search = new DataTable();
				using (OracleCommand cmd = new OracleCommand())
				{
					try
					{
						conn.Open();
						cmd.Connection = conn;
						cmd.CommandText = string.Concat("select * from zztechlog_techs where zztlt_name ='", this.cbTechNames.Text, "'");
						cmd.CommandType = CommandType.Text;
						using (OracleDataReader dreader = cmd.ExecuteReader())
						{
							tbl_Search.Load(dreader);
							if (tbl_Search.Rows.Count <= 0)
							{
								MessageBox.Show("No records found! Resetting search.", "cbShowOnly.Exception:");
							}
							else
							{
								this.cbShift.SelectedItem = tbl_Search.Rows[0]["ZZTLT_Shift"].ToString();
								if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tbl_Search.Rows[0]["ZZTLT_IsAdmin"].ToString(), "True", false) != 0)
								{
									this.chkAdmin.Checked = false;
								}
								else
								{
									this.chkAdmin.Checked = true;
								}
								if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tbl_Search.Rows[0]["ZZTLT_IsLead"].ToString(), "True", false) != 0)
								{
									this.chkIsLead.Checked = false;
								}
								else
								{
									this.chkIsLead.Checked = true;
								}
								if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tbl_Search.Rows[0]["ZZTLT_IsPartsLead"].ToString(), "True", false) != 0)
								{
									this.chkPartsLead.Checked = false;
								}
								else
								{
									this.chkPartsLead.Checked = true;
								}
								if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(tbl_Search.Rows[0]["ZZTLT_IsActive"].ToString(), "True", false) != 0)
								{
									this.chkActive.Checked = false;
								}
								else
								{
									this.chkActive.Checked = true;
								}
							}
							dreader.Close();
						}
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						Exception ex = exception;
						MessageBox.Show(ex.Message, "Exception:");
						ErrorHandlingStuff.WriteLogEntry(string.Concat("Error on frmUser/LoadData: ", ex.Message, " User:", Generals.CurUserName), "E");
						ProjectData.ClearProjectError();
					}
					conn.Close();
					conn.Dispose();
				}
			}
		}

		private void clbAMSUsers_ItemCheck(object sender, ItemCheckEventArgs e)
		{
			if (e.NewValue == CheckState.Checked)
			{
				int count = checked(this.clbAMSUsers.Items.Count - 1);
				for (int i = 0; i <= count; i = checked(i + 1))
				{
					if (i != e.Index)
					{
						this.clbAMSUsers.SetItemChecked(i, false);
					}
				}
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.clbAMSUsers.SelectedItem.ToString(), "Not in list!", false) == 0)
			{
				this.cbTechNames.SelectedIndex = 0;
			}
			else
			{
				this.cbTechNames.Text = this.clbAMSUsers.SelectedItem.ToString();
			}
			this.clbAMSUsers.Visible = false;
			this.clbAMSUsers.SendToBack();
		}

		private void clbAMSUsers_SelectedIndexChanged(object sender, EventArgs e)
		{
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

		private void frmUsers_Load(object sender, EventArgs e)
		{
			this.clbAMSUsers.Visible = false;
			this.clbAMSUsers.SendToBack();
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsLead, "True", false) != 0)
			{
				this.cbShift.Enabled = false;
				this.btnPassword.Enabled = false;
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserAdmin, "True", false) != 0)
			{
				this.chkAdmin.Enabled = false;
				this.chkIsLead.Enabled = false;
				this.chkPartsLead.Enabled = false;
				this.chkActive.Enabled = false;
				this.btnPassword.Enabled = false;
			}
			this.LoadData();
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.lblName = new Label();
			this.lblShift = new Label();
			this.chkIsLead = new CheckBox();
			this.cbShift = new ComboBox();
			this.chkAdmin = new CheckBox();
			this.btnOK = new Button();
			this.btnClose = new Button();
			this.cbTechNames = new ComboBox();
			this.btnNew = new Button();
			this.clbAMSUsers = new CheckedListBox();
			this.chkPartsLead = new CheckBox();
			this.ToolTip1 = new ToolTip(this.components);
			this.chkActive = new CheckBox();
			this.btnPassword = new Button();
			this.SuspendLayout();
			this.lblName.AutoSize = true;
			Label label = this.lblName;
			Point point = new Point(5, 11);
			label.Location = point;
			this.lblName.Name = "lblName";
			Label label1 = this.lblName;
			System.Drawing.Size size = new System.Drawing.Size(38, 13);
			label1.Size = size;
			this.lblName.TabIndex = 0;
			this.lblName.Text = "Name:";
			this.lblShift.AutoSize = true;
			Label label2 = this.lblShift;
			point = new Point(218, 11);
			label2.Location = point;
			this.lblShift.Name = "lblShift";
			Label label3 = this.lblShift;
			size = new System.Drawing.Size(31, 13);
			label3.Size = size;
			this.lblShift.TabIndex = 1;
			this.lblShift.Text = "Shift:";
			this.chkIsLead.AutoSize = true;
			CheckBox checkBox = this.chkIsLead;
			point = new Point(144, 37);
			checkBox.Location = point;
			this.chkIsLead.Name = "chkIsLead";
			CheckBox checkBox1 = this.chkIsLead;
			size = new System.Drawing.Size(91, 17);
			checkBox1.Size = size;
			this.chkIsLead.TabIndex = 2;
			this.chkIsLead.Text = "Is Team Lead";
			this.ToolTip1.SetToolTip(this.chkIsLead, "User can change others shifts");
			this.chkIsLead.UseVisualStyleBackColor = true;
			this.cbShift.FormattingEnabled = true;
			ComboBox.ObjectCollection items = this.cbShift.Items;
			object[] objArray = new object[] { "0", "1", "2", "3", "A", "B", "C" };
			items.AddRange(objArray);
			ComboBox comboBox = this.cbShift;
			point = new Point(264, 8);
			comboBox.Location = point;
			this.cbShift.Name = "cbShift";
			ComboBox comboBox1 = this.cbShift;
			size = new System.Drawing.Size(48, 21);
			comboBox1.Size = size;
			this.cbShift.TabIndex = 4;
			this.chkAdmin.AutoSize = true;
			CheckBox checkBox2 = this.chkAdmin;
			point = new Point(75, 37);
			checkBox2.Location = point;
			this.chkAdmin.Name = "chkAdmin";
			CheckBox checkBox3 = this.chkAdmin;
			size = new System.Drawing.Size(66, 17);
			checkBox3.Size = size;
			this.chkAdmin.TabIndex = 5;
			this.chkAdmin.Text = "Is Admin";
			this.ToolTip1.SetToolTip(this.chkAdmin, "Can add new users and create leads");
			this.chkAdmin.UseVisualStyleBackColor = true;
			Button button = this.btnOK;
			point = new Point(28, 71);
			button.Location = point;
			this.btnOK.Name = "btnOK";
			Button button1 = this.btnOK;
			size = new System.Drawing.Size(75, 23);
			button1.Size = size;
			this.btnOK.TabIndex = 6;
			this.btnOK.Text = "O.K.";
			this.btnOK.UseVisualStyleBackColor = true;
			Button button2 = this.btnClose;
			point = new Point(364, 71);
			button2.Location = point;
			this.btnClose.Name = "btnClose";
			Button button3 = this.btnClose;
			size = new System.Drawing.Size(75, 23);
			button3.Size = size;
			this.btnClose.TabIndex = 7;
			this.btnClose.Text = "&Close";
			this.btnClose.UseVisualStyleBackColor = true;
			this.cbTechNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cbTechNames.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbTechNames.FormattingEnabled = true;
			ComboBox comboBox2 = this.cbTechNames;
			point = new Point(43, 8);
			comboBox2.Location = point;
			this.cbTechNames.Name = "cbTechNames";
			ComboBox comboBox3 = this.cbTechNames;
			size = new System.Drawing.Size(170, 21);
			comboBox3.Size = size;
			this.cbTechNames.TabIndex = 8;
			Button button4 = this.btnNew;
			point = new Point(134, 71);
			button4.Location = point;
			this.btnNew.Name = "btnNew";
			Button button5 = this.btnNew;
			size = new System.Drawing.Size(75, 23);
			button5.Size = size;
			this.btnNew.TabIndex = 9;
			this.btnNew.Text = "&New";
			this.btnNew.UseVisualStyleBackColor = true;
			this.clbAMSUsers.FormattingEnabled = true;
			CheckedListBox checkedListBox = this.clbAMSUsers;
			point = new Point(1, 5);
			checkedListBox.Location = point;
			this.clbAMSUsers.Name = "clbAMSUsers";
			CheckedListBox checkedListBox1 = this.clbAMSUsers;
			size = new System.Drawing.Size(449, 94);
			checkedListBox1.Size = size;
			this.clbAMSUsers.TabIndex = 10;
			this.clbAMSUsers.Visible = false;
			this.chkPartsLead.AutoSize = true;
			CheckBox checkBox4 = this.chkPartsLead;
			point = new Point(244, 37);
			checkBox4.Location = point;
			this.chkPartsLead.Name = "chkPartsLead";
			CheckBox checkBox5 = this.chkPartsLead;
			size = new System.Drawing.Size(88, 17);
			checkBox5.Size = size;
			this.chkPartsLead.TabIndex = 11;
			this.chkPartsLead.Text = "Is Parts Lead";
			this.ToolTip1.SetToolTip(this.chkPartsLead, "User can edit all parts info");
			this.chkPartsLead.UseVisualStyleBackColor = true;
			this.chkActive.AutoSize = true;
			CheckBox checkBox6 = this.chkActive;
			point = new Point(4, 37);
			checkBox6.Location = point;
			this.chkActive.Name = "chkActive";
			CheckBox checkBox7 = this.chkActive;
			size = new System.Drawing.Size(67, 17);
			checkBox7.Size = size;
			this.chkActive.TabIndex = 12;
			this.chkActive.Text = "Is Active";
			this.ToolTip1.SetToolTip(this.chkActive, "Can add new users and create leads");
			this.chkActive.UseVisualStyleBackColor = true;
			Button button6 = this.btnPassword;
			point = new Point(257, 71);
			button6.Location = point;
			this.btnPassword.Name = "btnPassword";
			Button button7 = this.btnPassword;
			size = new System.Drawing.Size(75, 23);
			button7.Size = size;
			this.btnPassword.TabIndex = 13;
			this.btnPassword.Text = "&Password";
			this.btnPassword.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(451, 110);
			this.ClientSize = size;
			this.Controls.Add(this.btnPassword);
			this.Controls.Add(this.chkActive);
			this.Controls.Add(this.chkPartsLead);
			this.Controls.Add(this.btnNew);
			this.Controls.Add(this.cbTechNames);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnOK);
			this.Controls.Add(this.chkAdmin);
			this.Controls.Add(this.cbShift);
			this.Controls.Add(this.chkIsLead);
			this.Controls.Add(this.lblShift);
			this.Controls.Add(this.lblName);
			this.Controls.Add(this.clbAMSUsers);
			this.Name = "frmUsers";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "frmUsers";
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void LoadData()
		{
			this.cbTechNames.Items.Clear();
			using (OracleConnection conn = new OracleConnection(Generals.oradb))
			{
				DataTable tbl_Search = new DataTable();
				using (OracleCommand cmd = new OracleCommand())
				{
					try
					{
						conn.Open();
						cmd.Connection = conn;
						cmd.CommandText = "select distinct(zztlt_name) from zztechlog_techs where zztlt_IsActive = 'True' order by zztlt_name";
						cmd.CommandType = CommandType.Text;
						using (OracleDataReader dreader = cmd.ExecuteReader())
						{
							tbl_Search.Load(dreader);
							if (tbl_Search.Rows.Count <= 0)
							{
								MessageBox.Show("No records found! Resetting search.", "cbShowOnly.Exception:");
							}
							else
							{
								int count = checked(tbl_Search.Rows.Count - 1);
								for (int x = 0; x <= count; x = checked(x + 1))
								{
									this.cbTechNames.Items.Add(tbl_Search.Rows[x][0].ToString());
								}
								this.cbTechNames.SelectedItem = RuntimeHelpers.GetObjectValue(this.cbTechNames.Items[0]);
							}
							dreader.Close();
						}
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						Exception ex = exception;
						MessageBox.Show(ex.Message, "Exception:");
						ErrorHandlingStuff.WriteLogEntry(string.Concat("Error on frmUser/LoadData: ", ex.Message, " User:", Generals.CurUserName), "E");
						ProjectData.ClearProjectError();
					}
					conn.Close();
					conn.Dispose();
				}
			}
		}

		private void testSMTP()
		{
			try
			{
				SmtpClient SmtpServer = new SmtpClient();
				MailMessage mail = new MailMessage();
				SmtpServer.Credentials = new NetworkCredential("justme4326@gmail.com", "Goatballs3");
				SmtpServer.Port = 465;
				SmtpServer.Host = "smtp.gmail.com";
				SmtpServer.EnableSsl = true;
				mail = new MailMessage()
				{
					From = new MailAddress("justme4326@gmail.com")
				};
				mail.To.Add("dmitchell@witron.com");
				mail.Subject = "Test Mail";
				mail.Body = "This is for testing SMTP mail from GMAIL";
				SmtpServer.Send(mail);
				Interaction.MsgBox("mail send", MsgBoxStyle.OkOnly, null);
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.ToString(), MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}
	}
}