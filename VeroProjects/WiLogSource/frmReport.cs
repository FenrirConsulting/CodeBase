using Microsoft.Reporting.WinForms;
using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Oracle.DataAccess.Client;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.Drawing.Printing;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using WiLog.My.Resources;

namespace WiLog
{
	[DesignerGenerated]
	public class frmReport : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("ReportViewer1")]
		private ReportViewer _ReportViewer1;

		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		[AccessedThroughProperty("tscbReportName")]
		private ToolStripComboBox _tscbReportName;

		[AccessedThroughProperty("tslSpacer")]
		private ToolStripLabel _tslSpacer;

		[AccessedThroughProperty("tslSearch")]
		private ToolStripLabel _tslSearch;

		[AccessedThroughProperty("tscbSearchType")]
		private ToolStripComboBox _tscbSearchType;

		[AccessedThroughProperty("tstxtSearchCriteria")]
		private ToolStripTextBox _tstxtSearchCriteria;

		[AccessedThroughProperty("tsbSearch")]
		private ToolStripButton _tsbSearch;

		[AccessedThroughProperty("tsbCancelSearch")]
		private ToolStripButton _tsbCancelSearch;

		[AccessedThroughProperty("tscbState")]
		private ToolStripComboBox _tscbState;

		[AccessedThroughProperty("tscheckShowEntered")]
		private ToolStripCheckBox _tscheckShowEntered;

		private OracleConnection conn;

		private OracleCommand cmd;

		private string BaseSQL;

		private string WhereSQL;

		private string OrderSQL;

		[AccessedThroughProperty("dtpFromDate")]
		private DateTimePicker _dtpFromDate;

		[AccessedThroughProperty("dtpToDate")]
		private DateTimePicker _dtpToDate;

		private virtual DateTimePicker dtpFromDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dtpFromDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmReport _frmReport = this;
				EventHandler eventHandler = new EventHandler(_frmReport.dtp_ValueChanged);
				if (this._dtpFromDate != null)
				{
					this._dtpFromDate.ValueChanged -= eventHandler;
				}
				this._dtpFromDate = value;
				if (this._dtpFromDate != null)
				{
					this._dtpFromDate.ValueChanged += eventHandler;
				}
			}
		}

		private virtual DateTimePicker dtpToDate
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dtpToDate;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmReport _frmReport = this;
				EventHandler eventHandler = new EventHandler(_frmReport.dtp_ValueChanged);
				if (this._dtpToDate != null)
				{
					this._dtpToDate.ValueChanged -= eventHandler;
				}
				this._dtpToDate = value;
				if (this._dtpToDate != null)
				{
					this._dtpToDate.ValueChanged += eventHandler;
				}
			}
		}

		internal virtual ReportViewer ReportViewer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ReportViewer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ReportViewer1 = value;
			}
		}

		internal virtual ToolStrip ToolStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStrip1 = value;
			}
		}

		internal virtual ToolStripButton tsbCancelSearch
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tsbCancelSearch;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tsbCancelSearch = value;
			}
		}

		internal virtual ToolStripButton tsbSearch
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tsbSearch;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmReport _frmReport = this;
				EventHandler eventHandler = new EventHandler(_frmReport.tsbSearch_Click);
				if (this._tsbSearch != null)
				{
					this._tsbSearch.Click -= eventHandler;
				}
				this._tsbSearch = value;
				if (this._tsbSearch != null)
				{
					this._tsbSearch.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripComboBox tscbReportName
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tscbReportName;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmReport _frmReport = this;
				EventHandler eventHandler = new EventHandler(_frmReport.tscbReportName_SelectedIndexChanged);
				if (this._tscbReportName != null)
				{
					this._tscbReportName.SelectedIndexChanged -= eventHandler;
				}
				this._tscbReportName = value;
				if (this._tscbReportName != null)
				{
					this._tscbReportName.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual ToolStripComboBox tscbSearchType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tscbSearchType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmReport _frmReport = this;
				EventHandler eventHandler = new EventHandler(_frmReport.tscbSearchType_SelectedIndexChanged);
				if (this._tscbSearchType != null)
				{
					this._tscbSearchType.SelectedIndexChanged -= eventHandler;
				}
				this._tscbSearchType = value;
				if (this._tscbSearchType != null)
				{
					this._tscbSearchType.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual ToolStripComboBox tscbState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tscbState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmReport _frmReport = this;
				EventHandler eventHandler = new EventHandler(_frmReport.tscbReportName_SelectedIndexChanged);
				if (this._tscbState != null)
				{
					this._tscbState.SelectedIndexChanged -= eventHandler;
				}
				this._tscbState = value;
				if (this._tscbState != null)
				{
					this._tscbState.SelectedIndexChanged += eventHandler;
				}
			}
		}

		internal virtual ToolStripCheckBox tscheckShowEntered
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tscheckShowEntered;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tscheckShowEntered = value;
			}
		}

		internal virtual ToolStripLabel tslSearch
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tslSearch;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tslSearch = value;
			}
		}

		internal virtual ToolStripLabel tslSpacer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tslSpacer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tslSpacer = value;
			}
		}

		internal virtual ToolStripTextBox tstxtSearchCriteria
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tstxtSearchCriteria;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tstxtSearchCriteria = value;
			}
		}

		[DebuggerNonUserCode]
		static frmReport()
		{
			frmReport.__ENCList = new List<WeakReference>();
		}

		public frmReport()
		{
			frmReport _frmReport = this;
			base.FormClosing += new FormClosingEventHandler(_frmReport.frmReport_FormClosing);
			frmReport _frmReport1 = this;
			base.Load += new EventHandler(_frmReport1.frmReport_Load);
			frmReport.__ENCAddToList(this);
			this.conn = new OracleConnection(Generals.oradb);
			this.cmd = new OracleCommand();
			this.BaseSQL = "";
			this.WhereSQL = "";
			this.OrderSQL = "";
			this.dtpFromDate = new DateTimePicker();
			this.dtpToDate = new DateTimePicker();
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (frmReport.__ENCList)
			{
				if (frmReport.__ENCList.Count == frmReport.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmReport.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmReport.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmReport.__ENCList[item] = frmReport.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmReport.__ENCList.RemoveRange(item, checked(frmReport.__ENCList.Count - item));
					frmReport.__ENCList.Capacity = frmReport.__ENCList.Count;
				}
				frmReport.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void CreateQuery()
		{
			string[] whereSQL;
			ReportDataSource sReportDataSource = new ReportDataSource();
			this.ReportViewer1.LocalReport.DataSources.Clear();
			this.WhereSQL = "";
			if (!this.tscheckShowEntered.Checked)
			{
				this.WhereSQL = " ";
			}
			else
			{
				this.WhereSQL = " and ZZTL_State != 'Entered'";
			}
			string text = this.tscbSearchType.Text;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Asset Like", false) == 0)
			{
				this.WhereSQL = string.Concat(this.WhereSQL, " and upper(zztl_woasset) like '%", Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' ");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Date Range", false) == 0)
			{
				whereSQL = new string[] { this.WhereSQL, " and trunc(zztl_moddate) between to_date('", this.dtpFromDate.Text, "','MM-DD-YYYY') and to_date('", this.dtpToDate.Text, "','MM-DD-YYYY') " };
				this.WhereSQL = string.Concat(whereSQL);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "User Like", false) == 0)
			{
				whereSQL = new string[] { this.WhereSQL, "and upper(zztl_genuser) like '%", Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' OR upper(zztl_moduser) like '%", Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' " };
				this.WhereSQL = string.Concat(whereSQL);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "State Like", false) == 0)
			{
				this.WhereSQL = string.Concat(this.WhereSQL, " and upper(zztl_state) like '%", Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' ");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Full text", false) == 0)
			{
				whereSQL = new string[] { this.WhereSQL, " and upper(zztl_wocomplaint) like '%", Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' OR upper(zztl_wocorrection) like '%", Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' OR upper(zztl_worootcause) like '%", Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' " };
				this.WhereSQL = string.Concat(whereSQL);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Week #", false) == 0)
			{
				this.WhereSQL = string.Concat(this.WhereSQL, " and to_char(zztl_moddate,'IW') = ", this.tstxtSearchCriteria.Text.ToUpper());
			}
			string str = this.tscbReportName.Text;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Basic Report", false) == 0)
			{
				this.BaseSQL = "Select * From ZZTECHLOG WHERE 1=1";
				this.OrderSQL = " ORDER BY ZZTL_GENDATE desc";
				sReportDataSource.Name = "ds_WiLog";
				this.ReportViewer1.LocalReport.ReportPath = string.Concat(Application.StartupPath, "\\Reports\\Report1.rdlc");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Complete Report", false) == 0)
			{
				this.BaseSQL = "Select * From ZZTECHLOG WHERE 1=1";
				this.OrderSQL = " ORDER BY ZZTL_GENDATE desc";
				sReportDataSource.Name = "dsWorkOrder";
				this.ReportViewer1.LocalReport.ReportPath = string.Concat(Application.StartupPath, "\\Reports\\WorkOrderDetails.rdlc");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Tech Report", false) == 0)
			{
				this.ReportViewer1.Clear();
				this.BaseSQL = "Select * From ZZTECHLOG_USER,ZZTECHLOG where ZZTECHLOG.ZZTL_REF = ZZTECHLOG_USER.ZZTL_REF";
				this.OrderSQL = " ORDER BY ZZTL_GENDATE desc";
				sReportDataSource.Name = "dsTechData";
				this.ReportViewer1.LocalReport.ReportPath = string.Concat(Application.StartupPath, "\\Reports\\Tech.rdlc");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Parts Report", false) == 0)
			{
				this.ReportViewer1.Clear();
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "None", false) != 0)
			{
				this.ReportViewer1.Clear();
			}
			else
			{
				this.ReportViewer1.Clear();
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.BaseSQL, "", false) != 0)
			{
				this.ReportViewer1.LocalReport.DataSources.Add(sReportDataSource);
				using (OracleConnection conn = new OracleConnection(Generals.oradb))
				{
					DataTable tbl_Search = new DataTable();
					using (OracleCommand cmd = new OracleCommand())
					{
						try
						{
							conn.Open();
							cmd.Connection = conn;
							whereSQL = new string[] { this.BaseSQL, " ", this.WhereSQL, " ", this.OrderSQL };
							cmd.CommandText = string.Concat(whereSQL);
							cmd.CommandType = CommandType.Text;
							using (OracleDataReader dreader = cmd.ExecuteReader())
							{
								tbl_Search.Load(dreader);
								if (tbl_Search.Rows.Count <= 0)
								{
									MessageBox.Show("No records found!", "CreateQuery");
								}
								else
								{
									sReportDataSource.Value = tbl_Search;
								}
								dreader.Close();
							}
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							Exception ex = exception;
							MessageBox.Show(ex.Message, "Exception:");
							ErrorHandlingStuff.WriteLogEntry(string.Concat("Error on frmMain: ", ex.Message, " User:", Generals.CurUserName), "E");
							ProjectData.ClearProjectError();
						}
					}
				}
				this.ReportViewer1.RefreshReport();
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

		private void dtp_ValueChanged(object sender, EventArgs e)
		{
			if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectEqual(((Control)sender).Tag, "dtpFromDate", false))
			{
				this.dtpToDate.MinDate = this.dtpFromDate.Value;
				this.dtpToDate.Value = DateAndTime.DateAdd(DateInterval.Day, 1, this.dtpFromDate.Value);
			}
		}

		private void frmReport_FormClosing(object sender, FormClosingEventArgs e)
		{
			if (!Information.IsNothing(this.conn))
			{
				this.conn.Close();
			}
		}

		private void frmReport_Load(object sender, EventArgs e)
		{
			this.ReportViewer1.LocalReport.ShowDetailedSubreportMessages = true;
			this.ReportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
			this.ReportViewer1.ZoomMode = ZoomMode.Percent;
			Margins m = new Margins();
			PageSettings p = new PageSettings();
			Margins margin = m;
			margin.Left = 30;
			margin.Right = 0;
			margin.Top = 50;
			margin.Bottom = 20;
			margin = null;
			p.Margins = m;
			this.ReportViewer1.SetPageSettings(p);
			frmReport _frmReport = this;
			this.ReportViewer1.LocalReport.SubreportProcessing += new SubreportProcessingEventHandler(_frmReport.SubreportProcessingEventHandler);
			this.ReportViewer1.ProcessingMode = ProcessingMode.Local;
			this.ToolStrip1.Items.Insert(4, new ToolStripControlHost(this.dtpFromDate));
			this.ToolStrip1.Items.Insert(5, new ToolStripControlHost(this.dtpToDate));
			DateTimePicker dateTimePicker = this.dtpFromDate;
			dateTimePicker.Format = DateTimePickerFormat.Custom;
			dateTimePicker.CustomFormat = "MM-dd-yyyy";
			dateTimePicker.Width = 83;
			dateTimePicker.Visible = false;
			dateTimePicker.Tag = "dtpFromDate";
			dateTimePicker.Value = DateAndTime.DateAdd(DateInterval.Day, -1, DateAndTime.Today);
			dateTimePicker = null;
			DateTimePicker today = this.dtpToDate;
			today.Format = DateTimePickerFormat.Custom;
			today.CustomFormat = "MM-dd-yyyy";
			today.Width = 83;
			today.Visible = false;
			today.Tag = "dtpToDate";
			today.Value = DateAndTime.Today;
			today = null;
			this.tscbReportName.Items.Clear();
			this.tscbReportName.Items.Add("Basic Report");
			this.tscbReportName.Items.Add("Complete Report");
			this.tscbReportName.Items.Add("None");
			this.tscbReportName.Items.Add("Tech Report");
			this.tscbReportName.Items.Add("Parts Report");
			this.tscbReportName.SelectedItem = "None";
			this.tscbState.Items.Clear();
			this.tscbState.Items.Add("Non-Entered");
			this.tscbState.Items.Add("All");
			this.tscbState.SelectedItem = "Non-Entered";
			this.tscbSearchType.Text = "";
			this.tstxtSearchCriteria.Text = "";
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frmReport));
			this.ToolStrip1 = new ToolStrip();
			this.tscbReportName = new ToolStripComboBox();
			this.tslSpacer = new ToolStripLabel();
			this.tslSearch = new ToolStripLabel();
			this.tscbSearchType = new ToolStripComboBox();
			this.tstxtSearchCriteria = new ToolStripTextBox();
			this.tsbSearch = new ToolStripButton();
			this.tsbCancelSearch = new ToolStripButton();
			this.tscbState = new ToolStripComboBox();
			this.tscheckShowEntered = new ToolStripCheckBox();
			this.ReportViewer1 = new ReportViewer();
			this.ToolStrip1.SuspendLayout();
			this.SuspendLayout();
			this.ToolStrip1.Dock = DockStyle.Bottom;
			this.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			ToolStripItemCollection items = this.ToolStrip1.Items;
			ToolStripItem[] toolStripItemArray = new ToolStripItem[] { this.tscbReportName, this.tslSpacer, this.tslSearch, this.tscbSearchType, this.tstxtSearchCriteria, this.tsbSearch, this.tsbCancelSearch, this.tscbState, this.tscheckShowEntered };
			items.AddRange(toolStripItemArray);
			ToolStrip toolStrip1 = this.ToolStrip1;
			Point point = new Point(0, 471);
			toolStrip1.Location = point;
			this.ToolStrip1.Name = "ToolStrip1";
			ToolStrip toolStrip = this.ToolStrip1;
			System.Drawing.Size size = new System.Drawing.Size(902, 25);
			toolStrip.Size = size;
			this.ToolStrip1.TabIndex = 1;
			this.ToolStrip1.Text = "ToolStrip1";
			this.tscbReportName.Name = "tscbReportName";
			ToolStripComboBox toolStripComboBox = this.tscbReportName;
			size = new System.Drawing.Size(121, 25);
			toolStripComboBox.Size = size;
			this.tslSpacer.AutoSize = false;
			this.tslSpacer.Name = "tslSpacer";
			ToolStripLabel toolStripLabel = this.tslSpacer;
			size = new System.Drawing.Size(89, 22);
			toolStripLabel.Size = size;
			this.tslSpacer.Text = "SPACER ONLY";
			this.tslSpacer.Visible = false;
			this.tslSearch.Name = "tslSearch";
			ToolStripLabel toolStripLabel1 = this.tslSearch;
			size = new System.Drawing.Size(48, 22);
			toolStripLabel1.Size = size;
			this.tslSearch.Text = "Search: ";
			this.tscbSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox.ObjectCollection objectCollections = this.tscbSearchType.Items;
			object[] objArray = new object[] { "Asset Like", "Date Range", "User Like", "State Like", "Full text", "Week #" };
			objectCollections.AddRange(objArray);
			this.tscbSearchType.Name = "tscbSearchType";
			ToolStripComboBox toolStripComboBox1 = this.tscbSearchType;
			size = new System.Drawing.Size(121, 25);
			toolStripComboBox1.Size = size;
			this.tscbSearchType.ToolTipText = "Search type.";
			this.tstxtSearchCriteria.BorderStyle = BorderStyle.FixedSingle;
			this.tstxtSearchCriteria.Name = "tstxtSearchCriteria";
			this.tstxtSearchCriteria.ShortcutsEnabled = false;
			ToolStripTextBox toolStripTextBox = this.tstxtSearchCriteria;
			size = new System.Drawing.Size(165, 25);
			toolStripTextBox.Size = size;
			this.tstxtSearchCriteria.ToolTipText = "Search criteria.";
			this.tsbSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbSearch.Image = (Image)resources.GetObject("tsbSearch.Image");
			this.tsbSearch.ImageTransparentColor = Color.Magenta;
			this.tsbSearch.Name = "tsbSearch";
			ToolStripButton toolStripButton = this.tsbSearch;
			size = new System.Drawing.Size(23, 22);
			toolStripButton.Size = size;
			this.tsbSearch.Text = "tsbSearch";
			this.tsbSearch.ToolTipText = "Run current search.";
			this.tsbCancelSearch.DisplayStyle = ToolStripItemDisplayStyle.Image;
			this.tsbCancelSearch.Enabled = false;
			this.tsbCancelSearch.Image = (Image)resources.GetObject("tsbCancelSearch.Image");
			this.tsbCancelSearch.ImageTransparentColor = Color.Magenta;
			this.tsbCancelSearch.Name = "tsbCancelSearch";
			ToolStripButton toolStripButton1 = this.tsbCancelSearch;
			size = new System.Drawing.Size(23, 22);
			toolStripButton1.Size = size;
			this.tsbCancelSearch.Text = "tsbCancelSearch";
			this.tsbCancelSearch.ToolTipText = "Cancel current search.";
			this.tscbState.Name = "tscbState";
			ToolStripComboBox toolStripComboBox2 = this.tscbState;
			size = new System.Drawing.Size(121, 25);
			toolStripComboBox2.Size = size;
			this.tscheckShowEntered.BackColor = Color.Transparent;
			this.tscheckShowEntered.Checked = true;
			this.tscheckShowEntered.Name = "tscheckShowEntered";
			ToolStripCheckBox toolStripCheckBox = this.tscheckShowEntered;
			size = new System.Drawing.Size(100, 22);
			toolStripCheckBox.Size = size;
			this.tscheckShowEntered.Text = "Hide 'Entered'";
			this.tscheckShowEntered.ToolStripCheckBoxEnabled = true;
			this.ReportViewer1.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.ReportViewer1.BackgroundImage = Resources.Witron_logo_A;
			this.ReportViewer1.BackgroundImageLayout = ImageLayout.Center;
			ReportViewer reportViewer1 = this.ReportViewer1;
			point = new Point(0, 0);
			reportViewer1.Location = point;
			this.ReportViewer1.Name = "ReportViewer1";
			ReportViewer reportViewer = this.ReportViewer1;
			size = new System.Drawing.Size(902, 468);
			reportViewer.Size = size;
			this.ReportViewer1.TabIndex = 0;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(902, 496);
			this.ClientSize = size;
			this.Controls.Add(this.ToolStrip1);
			this.Controls.Add(this.ReportViewer1);
			this.Name = "frmReport";
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Show;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "frmReport";
			this.TopMost = true;
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void SubreportProcessingEventHandler(object sender, SubreportProcessingEventArgs e)
		{
			string reportPath = e.ReportPath;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(reportPath, "TechSubreport", false) == 0)
			{
				DataTable tbl_Techs = new DataTable();
				ReportDataSource sReportDataSource = new ReportDataSource();
				using (OracleConnection conn = new OracleConnection(Generals.oradb))
				{
					if (conn.State != ConnectionState.Open)
					{
						conn.Open();
					}
					sReportDataSource.Name = "dsTechs";
					this.cmd.Connection = conn;
					this.cmd.CommandText = string.Concat("select * from ZZTECHLOG_User where zztl_ref = ", e.Parameters[0].Values[0].ToString());
					this.cmd.CommandType = CommandType.Text;
					using (OracleDataReader dreader = this.cmd.ExecuteReader())
					{
						tbl_Techs.Load(dreader);
						sReportDataSource.Value = tbl_Techs;
						e.DataSources.Add(sReportDataSource);
					}
				}
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(reportPath, "PartSubreport", false) == 0)
			{
				DataTable tbl_Parts = new DataTable();
				ReportDataSource sReportDataSource = new ReportDataSource();
				using (OracleConnection conn = new OracleConnection(Generals.oradb))
				{
					if (conn.State != ConnectionState.Open)
					{
						conn.Open();
					}
					sReportDataSource.Name = "dsParts";
					this.cmd.Connection = conn;
					this.cmd.CommandText = string.Concat("select * from ZZTECHLOG_PARTS where zztl_ref = ", e.Parameters[0].Values[0].ToString(), " order by zztlp_ref");
					this.cmd.CommandType = CommandType.Text;
					using (OracleDataReader dreader = this.cmd.ExecuteReader())
					{
						tbl_Parts.Load(dreader);
						sReportDataSource.Value = tbl_Parts;
						e.DataSources.Add(sReportDataSource);
					}
				}
			}
		}

		private void tsbSearch_Click(object sender, EventArgs e)
		{
			this.CreateQuery();
		}

		private void tscbReportName_SelectedIndexChanged(object sender, EventArgs e)
		{
			this.CreateQuery();
		}

		private void tscbSearchType_SelectedIndexChanged(object sender, EventArgs e)
		{
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.tscbSearchType.Text, "Date Range", false) != 0)
			{
				this.dtpFromDate.Visible = false;
				this.dtpToDate.Visible = false;
				this.tstxtSearchCriteria.Visible = true;
			}
			else
			{
				this.dtpFromDate.Visible = true;
				this.dtpToDate.Visible = true;
				this.tstxtSearchCriteria.Visible = false;
			}
		}
	}
}