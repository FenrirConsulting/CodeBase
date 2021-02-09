using Microsoft.VisualBasic.CompilerServices;
using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WiLog
{
	[DesignerGenerated]
	public class frmNewUser : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("cbTechNames")]
		private ComboBox _cbTechNames;

		[AccessedThroughProperty("lblName")]
		private Label _lblName;

		[AccessedThroughProperty("txtName")]
		private TextBox _txtName;

		[AccessedThroughProperty("txtAUName")]
		private TextBox _txtAUName;

		[AccessedThroughProperty("Label1")]
		private Label _Label1;

		[AccessedThroughProperty("lblAMSName")]
		private Label _lblAMSName;

		[AccessedThroughProperty("cbIsLead")]
		private CheckBox _cbIsLead;

		[AccessedThroughProperty("cbIsAdmin")]
		private CheckBox _cbIsAdmin;

		[AccessedThroughProperty("cbISPartsAdmin")]
		private CheckBox _cbISPartsAdmin;

		[AccessedThroughProperty("cbIsActive")]
		private CheckBox _cbIsActive;

		[AccessedThroughProperty("cbShift")]
		private ComboBox _cbShift;

		[AccessedThroughProperty("Label2")]
		private Label _Label2;

		[AccessedThroughProperty("Button1")]
		private Button _Button1;

		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

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
				this._btnCancel = value;
			}
		}

		internal virtual Button btnSave
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnSave;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmNewUser _frmNewUser = this;
				EventHandler eventHandler = new EventHandler(_frmNewUser.btnSave_Click);
				if (this._btnSave != null)
				{
					this._btnSave.Click -= eventHandler;
				}
				this._btnSave = value;
				if (this._btnSave != null)
				{
					this._btnSave.Click += eventHandler;
				}
			}
		}

		internal virtual Button Button1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Button1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._Button1 = value;
			}
		}

		internal virtual CheckBox cbIsActive
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbIsActive;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbIsActive = value;
			}
		}

		internal virtual CheckBox cbIsAdmin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbIsAdmin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbIsAdmin = value;
			}
		}

		internal virtual CheckBox cbIsLead
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbIsLead;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbIsLead = value;
			}
		}

		internal virtual CheckBox cbISPartsAdmin
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbISPartsAdmin;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbISPartsAdmin = value;
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
				frmNewUser _frmNewUser = this;
				EventHandler eventHandler = new EventHandler(_frmNewUser.cbTechNames_SelectedValueChanged);
				if (this._cbTechNames != null)
				{
					this._cbTechNames.SelectedValueChanged -= eventHandler;
				}
				this._cbTechNames = value;
				if (this._cbTechNames != null)
				{
					this._cbTechNames.SelectedValueChanged += eventHandler;
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

		internal virtual Label lblAMSName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblAMSName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblAMSName = value;
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

		internal virtual TextBox txtAUName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtAUName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtAUName = value;
			}
		}

		internal virtual TextBox txtName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtName = value;
			}
		}

		[DebuggerNonUserCode]
		static frmNewUser()
		{
			frmNewUser.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public frmNewUser()
		{
			frmNewUser _frmNewUser = this;
			base.Load += new EventHandler(_frmNewUser.frmNewUser_Load);
			frmNewUser.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (frmNewUser.__ENCList)
			{
				if (frmNewUser.__ENCList.Count == frmNewUser.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmNewUser.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmNewUser.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmNewUser.__ENCList[item] = frmNewUser.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmNewUser.__ENCList.RemoveRange(item, checked(frmNewUser.__ENCList.Count - item));
					frmNewUser.__ENCList.Capacity = frmNewUser.__ENCList.Count;
				}
				frmNewUser.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			string[] text;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbTechNames.Text, "Create New Tech", false) != 0)
			{
				using (OracleConnection conn = new OracleConnection(Generals.oradb))
				{
					using (OracleCommand cmd = new OracleCommand())
					{
						try
						{
							conn.Open();
							cmd.Connection = conn;
							text = new string[] { "UPDATE zztechlog_techs Set zztlt_Shift = '", this.cbShift.Text, "', zztlt_islead = '", Conversions.ToString(this.cbIsLead.Checked), "', zztlt_isAdmin = '", Conversions.ToString(this.cbIsAdmin.Checked), "', zztlt_ispartslead = '", Conversions.ToString(this.cbISPartsAdmin.Checked), "', zztlt_isactive = '", Conversions.ToString(this.cbIsActive.Checked), "' where zztlt_name='", this.cbTechNames.Text, "'" };
							cmd.CommandText = string.Concat(text);
							cmd.CommandType = CommandType.Text;
							cmd.ExecuteNonQuery();
							MessageBox.Show(string.Concat("User ", this.cbTechNames.Text, " updated!"));
							return;
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							Exception ex = exception;
							MessageBox.Show(ex.Message, "Exception:");
							ErrorHandlingStuff.WriteLogEntry(string.Concat("Error on frmUser/btnSave(NEW): ", ex.Message, " User:", Generals.CurUserName), "E");
							ProjectData.ClearProjectError();
						}
						conn.Close();
						conn.Dispose();
					}
				}
			}
			else
			{
				using (OracleConnection conn = new OracleConnection(Generals.oradb))
				{
					using (OracleCommand cmd = new OracleCommand())
					{
						try
						{
							conn.Open();
							cmd.Connection = conn;
							text = new string[] { "INSERT INTO zztechlog_techs ( ZZTLT_NAME, zztlt_auname, ZZTLT_SHIFT,ZZTLT_ISLEAD,ZZTLT_ISAdmin,ZZTLT_ISPartsLEAD, ZZTLT_ISACTIVE, ZZTLT_PWord) values ('", this.txtName.Text, "','", this.txtAUName.Text, "','", this.cbShift.Text, "','", Conversions.ToString(this.cbIsLead.Checked), "','", Conversions.ToString(this.cbIsAdmin.Checked), "','", Conversions.ToString(this.cbISPartsAdmin.Checked), "','", Conversions.ToString(this.cbIsActive.Checked), "','PalmTree1')" };
							cmd.CommandText = string.Concat(text);
							cmd.CommandType = CommandType.Text;
							cmd.ExecuteNonQuery();
							MessageBox.Show(string.Concat("User ", this.cbTechNames.Text, " added!"));
							this.Close();
							return;
						}
						catch (Exception exception1)
						{
							ProjectData.SetProjectError(exception1);
							Exception ex = exception1;
							MessageBox.Show(ex.Message, "Exception:");
							ErrorHandlingStuff.WriteLogEntry(string.Concat("Error on frmUser/btnSave(NEW): ", ex.Message, " User:", Generals.CurUserName), "E");
							ProjectData.ClearProjectError();
						}
						conn.Close();
						conn.Dispose();
					}
				}
			}
		}

		private void cbTechNames_SelectedValueChanged(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			object[] objArray;
			IEnumerator enumerator1 = null;
			using (OracleConnection conn = new OracleConnection(Generals.oradb))
			{
				DataTable tbl_Search = new DataTable();
				using (OracleCommand cmd = new OracleCommand())
				{
					try
					{
						conn.Open();
						cmd.Connection = conn;
						cmd.CommandText = string.Concat("select * from zztechlog_techs where zztlt_Name = '", this.cbTechNames.Text, "'");
						cmd.CommandType = CommandType.Text;
						using (OracleDataReader dreader = cmd.ExecuteReader())
						{
							tbl_Search.Load(dreader);
							if (tbl_Search.Rows.Count > 0)
							{
								this.txtName.Text = tbl_Search.Rows[0]["zztlt_name"].ToString();
								this.cbShift.Text = tbl_Search.Rows[0]["zztlt_Shift"].ToString();
								this.cbIsLead.Checked = Conversions.ToBoolean(tbl_Search.Rows[0]["zztlt_IsLead"].ToString());
								this.cbIsAdmin.Checked = Conversions.ToBoolean(tbl_Search.Rows[0]["zztlt_IsAdmin"].ToString());
								this.cbISPartsAdmin.Checked = Conversions.ToBoolean(tbl_Search.Rows[0]["zztlt_IsPArtsLead"].ToString());
								this.cbIsActive.Checked = Conversions.ToBoolean(tbl_Search.Rows[0]["zztlt_IsActive"].ToString());
								this.txtAUName.Text = tbl_Search.Rows[0]["zztlt_AUName"].ToString();
								try
								{
									enumerator = this.Controls.GetEnumerator();
									while (enumerator.MoveNext())
									{
										object txtControl = RuntimeHelpers.GetObjectValue(enumerator.Current);
										if (txtControl is TextBox)
										{
											objArray = new object[] { true };
											NewLateBinding.LateSet(txtControl, null, "Enabled", objArray, null, null);
										}
										else if (txtControl is CheckBox)
										{
											objArray = new object[] { true };
											NewLateBinding.LateSet(txtControl, null, "Enabled", objArray, null, null);
										}
									}
								}
								finally
								{
									if (enumerator is IDisposable)
									{
										(enumerator as IDisposable).Dispose();
									}
								}
							}
							else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbTechNames.Text, "Create New Tech", false) != 0)
							{
								MessageBox.Show("No records found! Resetting search.", "cbShowOnly.Exception:");
							}
							else
							{
								this.txtName.Text = "";
								this.cbShift.Text = "";
								this.cbIsLead.Checked = false;
								this.cbIsAdmin.Checked = false;
								this.cbISPartsAdmin.Checked = false;
								this.cbIsActive.Checked = false;
								this.txtAUName.Text = "";
								try
								{
									enumerator1 = this.Controls.GetEnumerator();
									while (enumerator1.MoveNext())
									{
										((Control)enumerator1.Current).Enabled = true;
									}
								}
								finally
								{
									if (enumerator1 is IDisposable)
									{
										(enumerator1 as IDisposable).Dispose();
									}
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

		private void frmNewUser_Load(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			try
			{
				enumerator = this.Controls.GetEnumerator();
				while (enumerator.MoveNext())
				{
					Control txtControl = (Control)enumerator.Current;
					if (txtControl is TextBox)
					{
						txtControl.Enabled = false;
					}
					else if (txtControl is CheckBox)
					{
						txtControl.Enabled = false;
					}
				}
			}
			finally
			{
				if (enumerator is IDisposable)
				{
					(enumerator as IDisposable).Dispose();
				}
			}
			this.cbTechNames.Enabled = true;
			this.LoadData();
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.cbTechNames = new ComboBox();
			this.lblName = new Label();
			this.txtName = new TextBox();
			this.txtAUName = new TextBox();
			this.Label1 = new Label();
			this.lblAMSName = new Label();
			this.cbIsLead = new CheckBox();
			this.cbIsAdmin = new CheckBox();
			this.cbISPartsAdmin = new CheckBox();
			this.cbIsActive = new CheckBox();
			this.cbShift = new ComboBox();
			this.Label2 = new Label();
			this.Button1 = new Button();
			this.btnSave = new Button();
			this.btnCancel = new Button();
			this.SuspendLayout();
			this.cbTechNames.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cbTechNames.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbTechNames.FormattingEnabled = true;
			ComboBox comboBox = this.cbTechNames;
			Point point = new Point(42, 12);
			comboBox.Location = point;
			this.cbTechNames.Name = "cbTechNames";
			ComboBox comboBox1 = this.cbTechNames;
			System.Drawing.Size size = new System.Drawing.Size(170, 21);
			comboBox1.Size = size;
			this.cbTechNames.TabIndex = 10;
			this.lblName.AutoSize = true;
			Label label = this.lblName;
			point = new Point(4, 15);
			label.Location = point;
			this.lblName.Name = "lblName";
			Label label1 = this.lblName;
			size = new System.Drawing.Size(38, 13);
			label1.Size = size;
			this.lblName.TabIndex = 9;
			this.lblName.Text = "Name:";
			this.txtName.Enabled = false;
			TextBox textBox = this.txtName;
			point = new Point(42, 57);
			textBox.Location = point;
			this.txtName.Name = "txtName";
			TextBox textBox1 = this.txtName;
			size = new System.Drawing.Size(170, 20);
			textBox1.Size = size;
			this.txtName.TabIndex = 11;
			this.txtAUName.Enabled = false;
			TextBox textBox2 = this.txtAUName;
			point = new Point(322, 57);
			textBox2.Location = point;
			this.txtAUName.Name = "txtAUName";
			TextBox textBox3 = this.txtAUName;
			size = new System.Drawing.Size(122, 20);
			textBox3.Size = size;
			this.txtAUName.TabIndex = 12;
			this.Label1.AutoSize = true;
			Label label11 = this.Label1;
			point = new Point(4, 60);
			label11.Location = point;
			this.Label1.Name = "Label1";
			Label label12 = this.Label1;
			size = new System.Drawing.Size(38, 13);
			label12.Size = size;
			this.Label1.TabIndex = 13;
			this.Label1.Text = "Name:";
			this.lblAMSName.AutoSize = true;
			Label label2 = this.lblAMSName;
			point = new Point(227, 60);
			label2.Location = point;
			this.lblAMSName.Name = "lblAMSName";
			Label label3 = this.lblAMSName;
			size = new System.Drawing.Size(89, 13);
			label3.Size = size;
			this.lblAMSName.TabIndex = 14;
			this.lblAMSName.Text = "AMS User Name:";
			this.cbIsLead.AutoSize = true;
			this.cbIsLead.Enabled = false;
			CheckBox checkBox = this.cbIsLead;
			point = new Point(7, 94);
			checkBox.Location = point;
			this.cbIsLead.Name = "cbIsLead";
			CheckBox checkBox1 = this.cbIsLead;
			size = new System.Drawing.Size(61, 17);
			checkBox1.Size = size;
			this.cbIsLead.TabIndex = 15;
			this.cbIsLead.Text = "Is Lead";
			this.cbIsLead.UseVisualStyleBackColor = true;
			this.cbIsAdmin.AutoSize = true;
			this.cbIsAdmin.Enabled = false;
			CheckBox checkBox2 = this.cbIsAdmin;
			point = new Point(117, 94);
			checkBox2.Location = point;
			this.cbIsAdmin.Name = "cbIsAdmin";
			CheckBox checkBox3 = this.cbIsAdmin;
			size = new System.Drawing.Size(66, 17);
			checkBox3.Size = size;
			this.cbIsAdmin.TabIndex = 16;
			this.cbIsAdmin.Text = "Is Admin";
			this.cbIsAdmin.UseVisualStyleBackColor = true;
			this.cbISPartsAdmin.AutoSize = true;
			this.cbISPartsAdmin.Enabled = false;
			CheckBox checkBox4 = this.cbISPartsAdmin;
			point = new Point(7, 131);
			checkBox4.Location = point;
			this.cbISPartsAdmin.Name = "cbISPartsAdmin";
			CheckBox checkBox5 = this.cbISPartsAdmin;
			size = new System.Drawing.Size(93, 17);
			checkBox5.Size = size;
			this.cbISPartsAdmin.TabIndex = 17;
			this.cbISPartsAdmin.Text = "Is Parts Admin";
			this.cbISPartsAdmin.UseVisualStyleBackColor = true;
			this.cbIsActive.AutoSize = true;
			this.cbIsActive.Enabled = false;
			CheckBox checkBox6 = this.cbIsActive;
			point = new Point(117, 131);
			checkBox6.Location = point;
			this.cbIsActive.Name = "cbIsActive";
			CheckBox checkBox7 = this.cbIsActive;
			size = new System.Drawing.Size(67, 17);
			checkBox7.Size = size;
			this.cbIsActive.TabIndex = 18;
			this.cbIsActive.Text = "Is Active";
			this.cbIsActive.UseVisualStyleBackColor = true;
			this.cbShift.Enabled = false;
			this.cbShift.FormattingEnabled = true;
			ComboBox comboBox2 = this.cbShift;
			point = new Point(322, 90);
			comboBox2.Location = point;
			this.cbShift.Name = "cbShift";
			ComboBox comboBox3 = this.cbShift;
			size = new System.Drawing.Size(121, 21);
			comboBox3.Size = size;
			this.cbShift.TabIndex = 19;
			this.Label2.AutoSize = true;
			Label label21 = this.Label2;
			point = new Point(285, 98);
			label21.Location = point;
			this.Label2.Name = "Label2";
			Label label22 = this.Label2;
			size = new System.Drawing.Size(31, 13);
			label22.Size = size;
			this.Label2.TabIndex = 20;
			this.Label2.Text = "Shift:";
			Button button1 = this.Button1;
			point = new Point(12, 170);
			button1.Location = point;
			this.Button1.Name = "Button1";
			Button button = this.Button1;
			size = new System.Drawing.Size(75, 23);
			button.Size = size;
			this.Button1.TabIndex = 21;
			this.Button1.Text = "OK";
			this.Button1.UseVisualStyleBackColor = true;
			Button button2 = this.btnSave;
			point = new Point(180, 170);
			button2.Location = point;
			this.btnSave.Name = "btnSave";
			Button button3 = this.btnSave;
			size = new System.Drawing.Size(75, 23);
			button3.Size = size;
			this.btnSave.TabIndex = 22;
			this.btnSave.Text = "Save";
			this.btnSave.UseVisualStyleBackColor = true;
			Button button4 = this.btnCancel;
			point = new Point(368, 170);
			button4.Location = point;
			this.btnCancel.Name = "btnCancel";
			Button button5 = this.btnCancel;
			size = new System.Drawing.Size(75, 23);
			button5.Size = size;
			this.btnCancel.TabIndex = 23;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(454, 202);
			this.ClientSize = size;
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.Button1);
			this.Controls.Add(this.Label2);
			this.Controls.Add(this.cbShift);
			this.Controls.Add(this.cbIsActive);
			this.Controls.Add(this.cbISPartsAdmin);
			this.Controls.Add(this.cbIsAdmin);
			this.Controls.Add(this.cbIsLead);
			this.Controls.Add(this.lblAMSName);
			this.Controls.Add(this.Label1);
			this.Controls.Add(this.txtAUName);
			this.Controls.Add(this.txtName);
			this.Controls.Add(this.cbTechNames);
			this.Controls.Add(this.lblName);
			this.Name = "frmNewUser";
			this.Text = "frmNewUser";
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
								if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserAdmin, "True", false) == 0)
								{
									this.cbTechNames.Items.Add("Create New Tech");
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
			this.cbShift.Items.Add("1");
			this.cbShift.Items.Add("2");
			this.cbShift.Items.Add("3");
		}
	}
}