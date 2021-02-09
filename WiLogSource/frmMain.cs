using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using Microsoft.VisualBasic.MyServices;
using Oracle.DataAccess.Client;
using System;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Resources;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using WiLog.My;

namespace WiLog
{
	[DesignerGenerated]
	public class frmMain : Form, IMessageFilter
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("btnNew")]
		private Button _btnNew;

		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[AccessedThroughProperty("ToolStripComboBox1")]
		private ToolStripComboBox _ToolStripComboBox1;

		[AccessedThroughProperty("ToolStrip1")]
		private ToolStrip _ToolStrip1;

		[AccessedThroughProperty("tscbShowOnly")]
		private ToolStripComboBox _tscbShowOnly;

		[AccessedThroughProperty("tslSearch")]
		private ToolStripLabel _tslSearch;

		[AccessedThroughProperty("tstxtSearchCriteria")]
		private ToolStripTextBox _tstxtSearchCriteria;

		[AccessedThroughProperty("tslVersion")]
		private ToolStripLabel _tslVersion;

		[AccessedThroughProperty("tscbSearchType")]
		private ToolStripComboBox _tscbSearchType;

		[AccessedThroughProperty("tslSpacer")]
		private ToolStripLabel _tslSpacer;

		[AccessedThroughProperty("tsbSearch")]
		private ToolStripButton _tsbSearch;

		[AccessedThroughProperty("tsbCancelSearch")]
		private ToolStripButton _tsbCancelSearch;

		[AccessedThroughProperty("tsbExport")]
		private ToolStripButton _tsbExport;

		[AccessedThroughProperty("ContextMenuStrip1")]
		private System.Windows.Forms.ContextMenuStrip _ContextMenuStrip1;

		[AccessedThroughProperty("CutToolStripMenuItem")]
		private ToolStripMenuItem _CutToolStripMenuItem;

		[AccessedThroughProperty("CopyToolStripMenuItem")]
		private ToolStripMenuItem _CopyToolStripMenuItem;

		[AccessedThroughProperty("PasteToolStripMenuItem")]
		private ToolStripMenuItem _PasteToolStripMenuItem;

		[AccessedThroughProperty("lblLegend1")]
		private Label _lblLegend1;

		[AccessedThroughProperty("lblLegend3")]
		private Label _lblLegend3;

		[AccessedThroughProperty("lblLegend4")]
		private Label _lblLegend4;

		[AccessedThroughProperty("lblLegend2")]
		private Label _lblLegend2;

		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[AccessedThroughProperty("dgvOverview")]
		private DataGridView _dgvOverview;

		[AccessedThroughProperty("lblTimer")]
		private Label _lblTimer;

		[AccessedThroughProperty("btnReports")]
		private Button _btnReports;

		[AccessedThroughProperty("btnUsers")]
		private Button _btnUsers;

		[AccessedThroughProperty("lblSelectedRow")]
		private Label _lblSelectedRow;

		[AccessedThroughProperty("chkShowEntered")]
		private CheckBox _chkShowEntered;

		[AccessedThroughProperty("Timer1")]
		private System.Windows.Forms.Timer _Timer1;

		[AccessedThroughProperty("lblCountDown")]
		private Label _lblCountDown;

		[AccessedThroughProperty("lblAutoClose")]
		private Label _lblAutoClose;

		[AccessedThroughProperty("lblWeekNum")]
		private Label _lblWeekNum;

		[AccessedThroughProperty("chkHideOld")]
		private CheckBox _chkHideOld;

		private int MinuteCount;

		private int CountDown;

		[AccessedThroughProperty("dtpFromDate")]
		private DateTimePicker _dtpFromDate;

		[AccessedThroughProperty("dtpToDate")]
		private DateTimePicker _dtpToDate;

		private System.Windows.Forms.Timer RefTimer;

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
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.btnClose_Click);
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
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.btnNew_Click);
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

		internal virtual Button btnReports
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnReports;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.btnReports_Click);
				if (this._btnReports != null)
				{
					this._btnReports.Click -= eventHandler;
				}
				this._btnReports = value;
				if (this._btnReports != null)
				{
					this._btnReports.Click += eventHandler;
				}
			}
		}

		internal virtual Button btnUsers
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnUsers;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.btnOptions_Click);
				if (this._btnUsers != null)
				{
					this._btnUsers.Click -= eventHandler;
				}
				this._btnUsers = value;
				if (this._btnUsers != null)
				{
					this._btnUsers.Click += eventHandler;
				}
			}
		}

		internal virtual CheckBox chkHideOld
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkHideOld;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.chkShowEntered_CheckedChanged);
				if (this._chkHideOld != null)
				{
					this._chkHideOld.CheckedChanged -= eventHandler;
				}
				this._chkHideOld = value;
				if (this._chkHideOld != null)
				{
					this._chkHideOld.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual CheckBox chkShowEntered
		{
			[DebuggerNonUserCode]
			get
			{
				return this._chkShowEntered;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.chkShowEntered_CheckedChanged);
				if (this._chkShowEntered != null)
				{
					this._chkShowEntered.CheckedChanged -= eventHandler;
				}
				this._chkShowEntered = value;
				if (this._chkShowEntered != null)
				{
					this._chkShowEntered.CheckedChanged += eventHandler;
				}
			}
		}

		internal virtual System.Windows.Forms.ContextMenuStrip ContextMenuStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ContextMenuStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ContextMenuStrip1 = value;
			}
		}

		internal virtual ToolStripMenuItem CopyToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CopyToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.CopyToolStripMenuItem_Click);
				if (this._CopyToolStripMenuItem != null)
				{
					this._CopyToolStripMenuItem.Click -= eventHandler;
				}
				this._CopyToolStripMenuItem = value;
				if (this._CopyToolStripMenuItem != null)
				{
					this._CopyToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripMenuItem CutToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._CutToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._CutToolStripMenuItem = value;
			}
		}

		internal virtual DataGridView dgvOverview
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgvOverview;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				MouseEventHandler mouseEventHandler = new MouseEventHandler(_frmMain.dgvOverview_MouseDoubleClick);
				frmMain _frmMain1 = this;
				EventHandler eventHandler = new EventHandler(_frmMain1.dgvOverview_SelectionChanged);
				frmMain _frmMain2 = this;
				DataGridViewCellFormattingEventHandler dataGridViewCellFormattingEventHandler = new DataGridViewCellFormattingEventHandler(_frmMain2.dgvOverview_CellFormatting);
				if (this._dgvOverview != null)
				{
					this._dgvOverview.MouseDoubleClick -= mouseEventHandler;
					this._dgvOverview.SelectionChanged -= eventHandler;
					this._dgvOverview.CellFormatting -= dataGridViewCellFormattingEventHandler;
				}
				this._dgvOverview = value;
				if (this._dgvOverview != null)
				{
					this._dgvOverview.MouseDoubleClick += mouseEventHandler;
					this._dgvOverview.SelectionChanged += eventHandler;
					this._dgvOverview.CellFormatting += dataGridViewCellFormattingEventHandler;
				}
			}
		}

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
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.dtp_ValueChanged);
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
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.dtp_ValueChanged);
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

		internal virtual Label lblAutoClose
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblAutoClose;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				MouseEventHandler mouseEventHandler = new MouseEventHandler(_frmMain.lblAutoClose_MouseDown);
				if (this._lblAutoClose != null)
				{
					this._lblAutoClose.MouseDown -= mouseEventHandler;
				}
				this._lblAutoClose = value;
				if (this._lblAutoClose != null)
				{
					this._lblAutoClose.MouseDown += mouseEventHandler;
				}
			}
		}

		internal virtual Label lblCountDown
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCountDown;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblCountDown = value;
			}
		}

		internal virtual Label lblLegend1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblLegend1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblLegend1 = value;
			}
		}

		internal virtual Label lblLegend2
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblLegend2;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblLegend2 = value;
			}
		}

		internal virtual Label lblLegend3
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblLegend3;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblLegend3 = value;
			}
		}

		internal virtual Label lblLegend4
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblLegend4;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.lblLegend4_Click);
				if (this._lblLegend4 != null)
				{
					this._lblLegend4.Click -= eventHandler;
				}
				this._lblLegend4 = value;
				if (this._lblLegend4 != null)
				{
					this._lblLegend4.Click += eventHandler;
				}
			}
		}

		internal virtual Label lblSelectedRow
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblSelectedRow;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblSelectedRow = value;
			}
		}

		internal virtual Label lblTimer
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTimer;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.lblTimer_Click);
				if (this._lblTimer != null)
				{
					this._lblTimer.Click -= eventHandler;
				}
				this._lblTimer = value;
				if (this._lblTimer != null)
				{
					this._lblTimer.Click += eventHandler;
				}
			}
		}

		internal virtual Label lblWeekNum
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblWeekNum;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblWeekNum = value;
			}
		}

		internal virtual ToolStripMenuItem PasteToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._PasteToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._PasteToolStripMenuItem = value;
			}
		}

		internal virtual System.Windows.Forms.Timer Timer1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._Timer1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.Timer1_Tick);
				if (this._Timer1 != null)
				{
					this._Timer1.Tick -= eventHandler;
				}
				this._Timer1 = value;
				if (this._Timer1 != null)
				{
					this._Timer1.Tick += eventHandler;
				}
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

		internal virtual ToolStripComboBox ToolStripComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ToolStripComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ToolStripComboBox1 = value;
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
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.tsbCancelSearch_Click);
				if (this._tsbCancelSearch != null)
				{
					this._tsbCancelSearch.Click -= eventHandler;
				}
				this._tsbCancelSearch = value;
				if (this._tsbCancelSearch != null)
				{
					this._tsbCancelSearch.Click += eventHandler;
				}
			}
		}

		internal virtual ToolStripButton tsbExport
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tsbExport;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.tsbExport_Click);
				if (this._tsbExport != null)
				{
					this._tsbExport.Click -= eventHandler;
				}
				this._tsbExport = value;
				if (this._tsbExport != null)
				{
					this._tsbExport.Click += eventHandler;
				}
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
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.tsbSearch_Click);
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
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.tscbSearchType_SelectedIndexChanged);
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

		internal virtual ToolStripComboBox tscbShowOnly
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tscbShowOnly;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.tscbShowOnly_SelectedIndexChanged);
				if (this._tscbShowOnly != null)
				{
					this._tscbShowOnly.SelectedIndexChanged -= eventHandler;
				}
				this._tscbShowOnly = value;
				if (this._tscbShowOnly != null)
				{
					this._tscbShowOnly.SelectedIndexChanged += eventHandler;
				}
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

		internal virtual ToolStripLabel tslVersion
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tslVersion;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmMain _frmMain = this;
				EventHandler eventHandler = new EventHandler(_frmMain.tslVersion_Click);
				if (this._tslVersion != null)
				{
					this._tslVersion.Click -= eventHandler;
				}
				this._tslVersion = value;
				if (this._tslVersion != null)
				{
					this._tslVersion.Click += eventHandler;
				}
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
		static frmMain()
		{
			frmMain.__ENCList = new List<WeakReference>();
		}

		public frmMain()
		{
			frmMain _frmMain = this;
			base.FormClosing += new FormClosingEventHandler(_frmMain.frmMain_FormClosing);
			frmMain _frmMain1 = this;
			base.KeyDown += new KeyEventHandler(_frmMain1.frmMain_KeyDown);
			frmMain _frmMain2 = this;
			base.Load += new EventHandler(_frmMain2.frmMain_Load);
			frmMain.__ENCAddToList(this);
			this.CountDown = 10;
			this.dtpFromDate = new DateTimePicker();
			this.dtpToDate = new DateTimePicker();
			this.RefTimer = new System.Windows.Forms.Timer();
			this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount$Init = new StaticLocalInitFlag();
			this.$STATIC$GlobalRefreshDGV$2011E$LastSQL$Init = new StaticLocalInitFlag();
			this.InitializeComponent();
			Application.AddMessageFilter(this);
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserAdmin, "True", false) == 0)
			{
				this.CountDown = 90;
			}
			else if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsLead, "True", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsPartsLead, "True", false) == 0))
			{
				this.CountDown = 15;
			}
			else
			{
				this.CountDown = 60;
			}
			this.Timer1.Interval = 60000;
			this.lblCountDown.Text = this.CountDown.ToString();
			this.Timer1.Enabled = true;
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (frmMain.__ENCList)
			{
				if (frmMain.__ENCList.Count == frmMain.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmMain.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmMain.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmMain.__ENCList[item] = frmMain.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmMain.__ENCList.RemoveRange(item, checked(frmMain.__ENCList.Count - item));
					frmMain.__ENCList.Capacity = frmMain.__ENCList.Count;
				}
				frmMain.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			Application.Exit();
		}

		private void btnNew_Click(object sender, EventArgs e)
		{
			(new frmRecord(0, "NEW")).ShowDialog();
		}

		private void btnOptions_Click(object sender, EventArgs e)
		{
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.btnUsers.Text, "Users", false) != 0)
			{
				MyProject.Forms.FrmChangePassword.ShowDialog();
			}
			else
			{
				MyProject.Forms.frmUsers.ShowDialog();
			}
		}

		private void btnReports_Click(object sender, EventArgs e)
		{
			MyProject.Forms.frmReport.ShowDialog();
		}

		public void BuildTitle(string Mode)
		{
			Graphics g = this.CreateGraphics();
			string MyGreeting = string.Concat("Hello ", Generals.CurUserName, " !");
			double width = (double)this.Width / 2;
			SizeF sizeF = g.MeasureString(MyGreeting, this.Font);
			float single = sizeF.Width / 2f;
			SizeF sizeF1 = g.MeasureString(Mode.ToString(), this.Font);
			double startingPoint = width - (double)(single + sizeF1.Width / 2f);
			sizeF1 = g.MeasureString("xxx", this.Font);
			double widthOfASpace = (double)sizeF1.Width;
			string tmp = "   ";
			double tmpWidth = 0;
			do
			{
				tmp = string.Concat(tmp, "   ");
				tmpWidth += widthOfASpace;
			}
			while (tmpWidth + widthOfASpace < startingPoint);
			this.Text = string.Concat(MyGreeting, tmp, Mode.ToString(), tmp);
		}

		private void chkShowEntered_CheckedChanged(object sender, EventArgs e)
		{
			this.tsbSearch_Click(RuntimeHelpers.GetObjectValue(sender), e);
		}

		private void CopyToolStripMenuItem_Click(object sender, EventArgs e)
		{
			this.DGVCutCopyPaste("Copy");
		}

		public void DGVCutCopyPaste(string TheMode)
		{
			string theMode = TheMode;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(theMode, "Cut", false) != 0)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(theMode, "Copy", false) == 0)
				{
					Clipboard.SetDataObject(this.dgvOverview.GetClipboardContent());
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(theMode, "Paste", false) == 0)
				{
				}
			}
		}

		private void dgvOverview_CellFormatting(object sender, DataGridViewCellFormattingEventArgs e)
		{
			string str = this.dgvOverview.Rows[e.RowIndex].Cells["zztl_wotype"].Value.ToString();
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Passdown", false) == 0)
			{
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.PaleTurquoise;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Facility", false) == 0)
			{
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.BurlyWood;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Unplanned", false) == 0)
			{
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkGray;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Improvement", false) == 0)
			{
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.DarkSeaGreen;
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Review", false) != 0)
			{
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.White;
			}
			else
			{
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor = Color.Yellow;
			}
			string str1 = this.dgvOverview.Rows[e.RowIndex].Cells["zztl_state"].Value.ToString();
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Completed", false) == 0)
			{
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font(this.Font.Name, this.Font.Size, FontStyle.Regular);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str1, "Entered", false) != 0)
			{
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font(this.Font.Name, this.Font.Size, FontStyle.Regular);
			}
			else
			{
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.ForeColor = Color.DarkBlue;
				this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.Font = new System.Drawing.Font(this.Font.Name, this.Font.Size, FontStyle.Italic);
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dgvOverview.Rows[e.RowIndex].Cells["zztl_genuser"].Value.ToString(), this.dgvOverview.Rows[e.RowIndex].Cells["zztl_moduser"].Value.ToString(), false) == 0)
			{
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_genuser"].Style.BackColor = this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor;
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_genuser"].Style.ForeColor = this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.ForeColor;
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_gendate"].Style.BackColor = this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.BackColor;
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_gendate"].Style.ForeColor = this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.ForeColor;
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_gendate"].ToolTipText = "";
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_genuser"].ToolTipText = "";
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_genuser"].Style.Font = this.dgvOverview.Rows[e.RowIndex].DefaultCellStyle.Font;
			}
			else
			{
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_genuser"].Style.Font = new System.Drawing.Font(this.Font.Name, this.Font.Size, FontStyle.Bold);
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_genuser"].ToolTipText = string.Concat("Mod by: ", this.dgvOverview.Rows[e.RowIndex].Cells["zztl_moduser"].Value.ToString());
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_genuser"].Style.BackColor = Color.Blue;
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_genuser"].Style.ForeColor = Color.White;
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_gendate"].Style.BackColor = Color.Blue;
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_gendate"].Style.ForeColor = Color.White;
				this.dgvOverview.Rows[e.RowIndex].Cells["zztl_gendate"].ToolTipText = string.Concat("Mod on: ", this.dgvOverview.Rows[e.RowIndex].Cells["zztl_moddate"].Value.ToString());
			}
			this.dgvOverview.Rows[e.RowIndex].Cells["zztl_wocomplaint"].ToolTipText = string.Concat("Correction: ", this.dgvOverview.Rows[e.RowIndex].Cells["zztl_wocorrection"].Value.ToString());
			this.dgvOverview.Rows[e.RowIndex].Cells["TTime"].ToolTipText = string.Concat("Techs: ", this.dgvOverview.Rows[e.RowIndex].Cells["TCount"].Value.ToString());
		}

		private void dgvOverview_KeyUp(object sender, KeyEventArgs e)
		{
			if (Control.ModifierKeys == Keys.Control)
			{
				Keys keyCode = e.KeyCode;
				if (keyCode == Keys.X)
				{
					this.DGVCutCopyPaste("Cut");
				}
				else if (keyCode == Keys.C)
				{
					this.DGVCutCopyPaste("Copy");
				}
				else if (keyCode == Keys.V)
				{
					if (Clipboard.ContainsText())
					{
						this.DGVCutCopyPaste("Paste");
					}
				}
			}
		}

		private void dgvOverview_MouseDoubleClick(object sender, MouseEventArgs e)
		{
			if ((!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dgvOverview.CurrentRow.Cells["zztl_moduser"].Value.ToString(), Generals.CurUserName, false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsLead, "True", false) == 0) || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.dgvOverview.CurrentRow.Cells["zztl_state"].Value.ToString(), "Entered", false) == 0 ? true : false))
			{
				frmRecord MyRecord = new frmRecord(Conversions.ToInteger(this.dgvOverview.CurrentRow.Cells["zztl_ref"].Value), "VIEW");
				MyRecord.ShowDialog();
			}
			else
			{
				frmRecord MyRecord = new frmRecord(Conversions.ToInteger(this.dgvOverview.CurrentRow.Cells["zztl_ref"].Value), "EDIT");
				MyRecord.ShowDialog();
			}
		}

		private void dgvOverview_SelectionChanged(object sender, EventArgs e)
		{
			if (!Information.IsNothing(this.dgvOverview.CurrentRow))
			{
				Label label = this.lblSelectedRow;
				string[] str = new string[] { "Row ", Convert.ToString(checked(this.dgvOverview.CurrentRow.Index + 1)), " of ", null, null };
				int count = this.dgvOverview.Rows.Count;
				str[3] = count.ToString();
				str[4] = " rows.";
				label.Text = string.Concat(str);
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

		public void FormLayout()
		{
			this.Text = string.Concat("Hello ", Generals.CurUserName, " !");
			frmMain _frmMain = this;
			this.RefTimer.Tick += new EventHandler(_frmMain.RefTimer_Tick);
			System.Windows.Forms.Timer refTimer = this.RefTimer;
			refTimer.Interval = 60000;
			refTimer.Start();
			refTimer = null;
			this.tslVersion.Text = string.Concat("Version: ", Application.ProductVersion.ToString());
			this.tscbShowOnly.SelectedIndex = 0;
			this.tscbSearchType.SelectedIndex = 0;
			this.tslSpacer.Text = "";
			ToolTip toolTip1 = this.ToolTip1;
			Label label = this.lblLegend1;
			string text = this.lblLegend1.Text;
			Color backColor = this.lblLegend1.BackColor;
			toolTip1.SetToolTip(label, string.Concat(text, " will show a ", backColor.ToString(), " backcolor"));
			Label label1 = this.lblLegend2;
			string str = this.lblLegend2.Text;
			backColor = this.lblLegend2.BackColor;
			toolTip1.SetToolTip(label1, string.Concat(str, " will show a ", backColor.ToString(), " backcolor"));
			Label label2 = this.lblLegend3;
			string text1 = this.lblLegend3.Text;
			backColor = this.lblLegend3.BackColor;
			toolTip1.SetToolTip(label2, string.Concat(text1, " will show a ", backColor.ToString(), " backcolor"));
			Label label3 = this.lblLegend4;
			string str1 = this.lblLegend4.Text;
			backColor = this.lblLegend4.BackColor;
			toolTip1.SetToolTip(label3, string.Concat(str1, " will show a ", backColor.ToString(), " backcolor"));
			toolTip1 = null;
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
		}

		private void frmMain_FormClosing(object sender, FormClosingEventArgs e)
		{
			Application.Exit();
		}

		private void frmMain_KeyDown(object sender, KeyEventArgs e)
		{
			if (e.KeyData == Keys.F5)
			{
				this.GlobalRefreshDGV("");
			}
		}

		private void frmMain_Load(object sender, EventArgs e)
		{
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsLead, "True", false) == 0)
			{
				this.btnUsers.Text = "Users";
			}
			else
			{
				this.btnUsers.Text = "Password";
			}
			this.lblWeekNum.Text = string.Concat("Week Number: ", Conversions.ToString(DateAndTime.DatePart("ww", DateAndTime.Today, FirstDayOfWeek.Monday, FirstWeekOfYear.Jan1)));
			CheckBox checkBox = this.chkHideOld;
			DateTime dateTime = DateAndTime.DateAdd(DateInterval.Day, -30, DateAndTime.Today);
			checkBox.Text = string.Concat("Hide records older than ", dateTime.ToShortDateString());
			this.FormLayout();
		}

		public void GlobalRefreshDGV(string TheSQL)
		{
			bool flag = false;
			try
			{
				Monitor.Enter(this.$STATIC$GlobalRefreshDGV$2011E$LastSQL$Init, ref flag);
				if (this.$STATIC$GlobalRefreshDGV$2011E$LastSQL$Init.State == 0)
				{
					this.$STATIC$GlobalRefreshDGV$2011E$LastSQL$Init.State = 2;
					this.$STATIC$GlobalRefreshDGV$2011E$LastSQL = "";
				}
				else if (this.$STATIC$GlobalRefreshDGV$2011E$LastSQL$Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.$STATIC$GlobalRefreshDGV$2011E$LastSQL$Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this.$STATIC$GlobalRefreshDGV$2011E$LastSQL$Init);
				}
			}
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(TheSQL, "", false) == 0)
			{
				TheSQL = this.$STATIC$GlobalRefreshDGV$2011E$LastSQL;
			}
			if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(TheSQL, "", false) != 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.$STATIC$GlobalRefreshDGV$2011E$LastSQL, "", false) != 0 ? true : false))
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
							cmd.CommandText = TheSQL;
							cmd.CommandType = CommandType.Text;
							using (OracleDataReader dreader = cmd.ExecuteReader())
							{
								tbl_Search.Load(dreader);
								if (tbl_Search.Rows.Count <= 0)
								{
									MessageBox.Show("No records found! Resetting search.", "cbShowOnly.Exception:");
									this.tscbShowOnly.SelectedIndex = 0;
									this.tstxtSearchCriteria.Text = "";
									this.tsbCancelSearch.Enabled = false;
									this.BuildTitle("");
								}
								else
								{
									this.dgvOverview.DataSource = tbl_Search;
									this.GridSetUp();
									this.tsbCancelSearch.Enabled = true;
									this.$STATIC$GlobalRefreshDGV$2011E$LastSQL = TheSQL;
								}
								dreader.Close();
							}
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							ProjectData.ClearProjectError();
						}
						conn.Close();
						conn.Dispose();
					}
				}
			}
		}

		private void GridSetUp()
		{
			DataGridView dataGridView = this.dgvOverview;
			dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.None;
			dataGridView.RowHeadersWidth = 10;
			dataGridView.AllowUserToAddRows = false;
			dataGridView.AllowUserToDeleteRows = false;
			dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridView.Columns["zztl_ref"].HeaderText = "Ref #";
			dataGridView.Columns["zztl_ref"].ToolTipText = "Internal referance to work order.";
			dataGridView.Columns["zztl_ref"].Width = 40;
			dataGridView.Columns["zztl_ref"].MinimumWidth = 5;
			dataGridView.Columns["zztl_ref"].FillWeight = 100f;
			dataGridView.Columns["zztl_ref"].DataPropertyName = "zztl_ref";
			dataGridView.Columns["zztl_state"].HeaderText = "State";
			dataGridView.Columns["zztl_state"].ToolTipText = "Work order completion state.";
			dataGridView.Columns["zztl_state"].Width = 60;
			dataGridView.Columns["zztl_state"].MinimumWidth = 5;
			dataGridView.Columns["zztl_state"].FillWeight = 100f;
			dataGridView.Columns["zztl_wotype"].HeaderText = "Type";
			dataGridView.Columns["zztl_wotype"].ToolTipText = "Work order type.";
			dataGridView.Columns["zztl_wotype"].Width = 80;
			dataGridView.Columns["zztl_wotype"].MinimumWidth = 5;
			dataGridView.Columns["zztl_wotype"].FillWeight = 80f;
			dataGridView.Columns["zztl_woasset"].HeaderText = "Asset";
			dataGridView.Columns["zztl_woasset"].ToolTipText = "Asset work was done on.";
			dataGridView.Columns["zztl_woasset"].Width = 80;
			dataGridView.Columns["zztl_woasset"].MinimumWidth = 5;
			dataGridView.Columns["zztl_woasset"].FillWeight = 100f;
			dataGridView.Columns["zztl_wocomplaint"].HeaderText = "Complaint";
			dataGridView.Columns["zztl_wocomplaint"].ToolTipText = "";
			dataGridView.Columns["zztl_wocomplaint"].Width = 626;
			dataGridView.Columns["zztl_wocomplaint"].MinimumWidth = 5;
			dataGridView.Columns["zztl_wocomplaint"].FillWeight = 100f;
			dataGridView.Columns["zztl_wocomplaint"].AutoSizeMode = DataGridViewAutoSizeColumnMode.Fill;
			dataGridView.Columns["TTime"].HeaderText = "Time";
			dataGridView.Columns["TTime"].ToolTipText = "Total time booked on this work order.";
			dataGridView.Columns["TTime"].Width = 50;
			dataGridView.Columns["TTime"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns["TTime"].MinimumWidth = 5;
			dataGridView.Columns["TTime"].FillWeight = 100f;
			dataGridView.Columns["TCount"].Visible = false;
			dataGridView.Columns["zztl_genuser"].HeaderText = "Gen User";
			dataGridView.Columns["zztl_genuser"].ToolTipText = "User that created this work order.";
			dataGridView.Columns["zztl_genuser"].Width = 100;
			dataGridView.Columns["zztl_genuser"].MinimumWidth = 5;
			dataGridView.Columns["zztl_genuser"].FillWeight = 100f;
			dataGridView.Columns["zztl_gendate"].HeaderText = "Gen Date";
			dataGridView.Columns["zztl_gendate"].ToolTipText = "Last time this work order was modified.";
			dataGridView.Columns["zztl_gendate"].Width = 110;
			dataGridView.Columns["zztl_gendate"].MinimumWidth = 5;
			dataGridView.Columns["zztl_gendate"].FillWeight = 100f;
			dataGridView.Columns["zztl_worootcause"].Visible = false;
			dataGridView.Columns["zztl_wocorrection"].Visible = false;
			dataGridView.Columns["zztl_moduser"].Visible = false;
			dataGridView.Columns["zztl_moddate"].Visible = false;
			dataGridView = null;
			Label label = this.lblSelectedRow;
			string[] str = new string[] { "Row ", Convert.ToString(checked(this.dgvOverview.CurrentRow.Index + 1)), " of ", null, null };
			int count = this.dgvOverview.Rows.Count;
			str[3] = count.ToString();
			str[4] = " rows.";
			label.Text = string.Concat(str);
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			ComponentResourceManager resources = new ComponentResourceManager(typeof(frmMain));
			this.ContextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.CutToolStripMenuItem = new ToolStripMenuItem();
			this.CopyToolStripMenuItem = new ToolStripMenuItem();
			this.PasteToolStripMenuItem = new ToolStripMenuItem();
			this.btnNew = new Button();
			this.btnClose = new Button();
			this.ToolStripComboBox1 = new ToolStripComboBox();
			this.ToolStrip1 = new ToolStrip();
			this.tscbShowOnly = new ToolStripComboBox();
			this.tslSpacer = new ToolStripLabel();
			this.tslSearch = new ToolStripLabel();
			this.tscbSearchType = new ToolStripComboBox();
			this.tstxtSearchCriteria = new ToolStripTextBox();
			this.tslVersion = new ToolStripLabel();
			this.tsbSearch = new ToolStripButton();
			this.tsbCancelSearch = new ToolStripButton();
			this.tsbExport = new ToolStripButton();
			this.lblLegend1 = new Label();
			this.lblLegend3 = new Label();
			this.lblLegend4 = new Label();
			this.lblLegend2 = new Label();
			this.ToolTip1 = new ToolTip(this.components);
			this.lblTimer = new Label();
			this.btnReports = new Button();
			this.btnUsers = new Button();
			this.lblWeekNum = new Label();
			this.dgvOverview = new DataGridView();
			this.lblSelectedRow = new Label();
			this.chkShowEntered = new CheckBox();
			this.Timer1 = new System.Windows.Forms.Timer(this.components);
			this.lblCountDown = new Label();
			this.lblAutoClose = new Label();
			this.chkHideOld = new CheckBox();
			this.ContextMenuStrip1.SuspendLayout();
			this.ToolStrip1.SuspendLayout();
			((ISupportInitialize)this.dgvOverview).BeginInit();
			this.SuspendLayout();
			ToolStripItemCollection items = this.ContextMenuStrip1.Items;
			ToolStripItem[] cutToolStripMenuItem = new ToolStripItem[] { this.CutToolStripMenuItem, this.CopyToolStripMenuItem, this.PasteToolStripMenuItem };
			items.AddRange(cutToolStripMenuItem);
			this.ContextMenuStrip1.Name = "ContextMenuStrip1";
			System.Windows.Forms.ContextMenuStrip contextMenuStrip1 = this.ContextMenuStrip1;
			System.Drawing.Size size = new System.Drawing.Size(148, 70);
			contextMenuStrip1.Size = size;
			this.CutToolStripMenuItem.Enabled = false;
			this.CutToolStripMenuItem.Name = "CutToolStripMenuItem";
			ToolStripMenuItem toolStripMenuItem = this.CutToolStripMenuItem;
			size = new System.Drawing.Size(147, 22);
			toolStripMenuItem.Size = size;
			this.CutToolStripMenuItem.Text = "&Cut  (Ctrl + X)";
			this.CopyToolStripMenuItem.Name = "CopyToolStripMenuItem";
			ToolStripMenuItem copyToolStripMenuItem = this.CopyToolStripMenuItem;
			size = new System.Drawing.Size(147, 22);
			copyToolStripMenuItem.Size = size;
			this.CopyToolStripMenuItem.Text = "Copy";
			this.PasteToolStripMenuItem.Enabled = false;
			this.PasteToolStripMenuItem.Name = "PasteToolStripMenuItem";
			ToolStripMenuItem pasteToolStripMenuItem = this.PasteToolStripMenuItem;
			size = new System.Drawing.Size(147, 22);
			pasteToolStripMenuItem.Size = size;
			this.PasteToolStripMenuItem.Text = "Paste";
			this.btnNew.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			Button button = this.btnNew;
			Point point = new Point(242, 389);
			button.Location = point;
			this.btnNew.Name = "btnNew";
			Button button1 = this.btnNew;
			size = new System.Drawing.Size(75, 23);
			button1.Size = size;
			this.btnNew.TabIndex = 3;
			this.btnNew.Text = "Add &New";
			this.ToolTip1.SetToolTip(this.btnNew, "Create a new work order.");
			this.btnNew.UseVisualStyleBackColor = true;
			this.btnClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			Button button2 = this.btnClose;
			point = new Point(869, 389);
			button2.Location = point;
			this.btnClose.Name = "btnClose";
			Button button3 = this.btnClose;
			size = new System.Drawing.Size(75, 23);
			button3.Size = size;
			this.btnClose.TabIndex = 4;
			this.btnClose.Text = "&Close";
			this.ToolTip1.SetToolTip(this.btnClose, "Exit the application");
			this.btnClose.UseVisualStyleBackColor = true;
			ComboBox.ObjectCollection objectCollections = this.ToolStripComboBox1.Items;
			object[] objArray = new object[] { "All", "Mine", "Passdown" };
			objectCollections.AddRange(objArray);
			this.ToolStripComboBox1.Name = "ToolStripComboBox1";
			ToolStripComboBox toolStripComboBox1 = this.ToolStripComboBox1;
			size = new System.Drawing.Size(121, 23);
			toolStripComboBox1.Size = size;
			this.ToolStrip1.Dock = DockStyle.Bottom;
			this.ToolStrip1.GripStyle = ToolStripGripStyle.Hidden;
			ToolStripItemCollection toolStripItemCollections = this.ToolStrip1.Items;
			cutToolStripMenuItem = new ToolStripItem[] { this.tscbShowOnly, this.tslSpacer, this.tslSearch, this.tscbSearchType, this.tstxtSearchCriteria, this.tslVersion, this.tsbSearch, this.tsbCancelSearch, this.tsbExport };
			toolStripItemCollections.AddRange(cutToolStripMenuItem);
			ToolStrip toolStrip1 = this.ToolStrip1;
			point = new Point(0, 421);
			toolStrip1.Location = point;
			this.ToolStrip1.Name = "ToolStrip1";
			ToolStrip toolStrip = this.ToolStrip1;
			size = new System.Drawing.Size(1189, 25);
			toolStrip.Size = size;
			this.ToolStrip1.TabIndex = 5;
			this.ToolStrip1.Text = "ToolStrip1";
			this.tscbShowOnly.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox.ObjectCollection items1 = this.tscbShowOnly.Items;
			objArray = new object[] { "All", "Mine", "Passdown" };
			items1.AddRange(objArray);
			this.tscbShowOnly.Name = "tscbShowOnly";
			ToolStripComboBox toolStripComboBox = this.tscbShowOnly;
			size = new System.Drawing.Size(121, 25);
			toolStripComboBox.Size = size;
			this.tslSpacer.AutoSize = false;
			this.tslSpacer.Name = "tslSpacer";
			ToolStripLabel toolStripLabel = this.tslSpacer;
			size = new System.Drawing.Size(89, 22);
			toolStripLabel.Size = size;
			this.tslSpacer.Text = "SPACER ONLY";
			this.tslSearch.Name = "tslSearch";
			ToolStripLabel toolStripLabel1 = this.tslSearch;
			size = new System.Drawing.Size(48, 22);
			toolStripLabel1.Size = size;
			this.tslSearch.Text = "Search: ";
			this.tscbSearchType.DropDownStyle = ComboBoxStyle.DropDownList;
			ComboBox.ObjectCollection objectCollections1 = this.tscbSearchType.Items;
			objArray = new object[] { "Asset Like", "Ref #", "Date Range", "User Like", "State Like", "Full text", "Week #" };
			objectCollections1.AddRange(objArray);
			this.tscbSearchType.Name = "tscbSearchType";
			ToolStripComboBox toolStripComboBox2 = this.tscbSearchType;
			size = new System.Drawing.Size(121, 25);
			toolStripComboBox2.Size = size;
			this.tscbSearchType.ToolTipText = "Search type.";
			this.tstxtSearchCriteria.BorderStyle = BorderStyle.FixedSingle;
			this.tstxtSearchCriteria.Name = "tstxtSearchCriteria";
			this.tstxtSearchCriteria.ShortcutsEnabled = false;
			ToolStripTextBox toolStripTextBox = this.tstxtSearchCriteria;
			size = new System.Drawing.Size(165, 25);
			toolStripTextBox.Size = size;
			this.tstxtSearchCriteria.ToolTipText = "Search criteria.";
			this.tslVersion.Alignment = ToolStripItemAlignment.Right;
			this.tslVersion.Name = "tslVersion";
			ToolStripLabel toolStripLabel2 = this.tslVersion;
			size = new System.Drawing.Size(27, 22);
			toolStripLabel2.Size = size;
			this.tslVersion.Text = "Ver.";
			this.tslVersion.ToolTipText = "Currently running version";
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
			this.tsbExport.Image = (Image)resources.GetObject("tsbExport.Image");
			this.tsbExport.ImageTransparentColor = Color.Magenta;
			this.tsbExport.Name = "tsbExport";
			ToolStripButton toolStripButton2 = this.tsbExport;
			size = new System.Drawing.Size(60, 22);
			toolStripButton2.Size = size;
			this.tsbExport.Text = "Export";
			this.tsbExport.ToolTipText = "Export to CSV (Excel) file.";
			this.lblLegend1.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.lblLegend1.BackColor = Color.PaleTurquoise;
			this.lblLegend1.BorderStyle = BorderStyle.FixedSingle;
			Label label = this.lblLegend1;
			point = new Point(1044, 385);
			label.Location = point;
			this.lblLegend1.Name = "lblLegend1";
			Label label1 = this.lblLegend1;
			size = new System.Drawing.Size(71, 17);
			label1.Size = size;
			this.lblLegend1.TabIndex = 6;
			this.lblLegend1.Text = "Passdown";
			this.ToolTip1.SetToolTip(this.lblLegend1, ".");
			this.lblLegend3.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.lblLegend3.BackColor = Color.BurlyWood;
			this.lblLegend3.BorderStyle = BorderStyle.FixedSingle;
			Label label2 = this.lblLegend3;
			point = new Point(1117, 385);
			label2.Location = point;
			this.lblLegend3.Name = "lblLegend3";
			Label label3 = this.lblLegend3;
			size = new System.Drawing.Size(71, 17);
			label3.Size = size;
			this.lblLegend3.TabIndex = 7;
			this.lblLegend3.Text = "Facility";
			this.ToolTip1.SetToolTip(this.lblLegend3, "..");
			this.lblLegend4.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.lblLegend4.BackColor = Color.DarkSeaGreen;
			this.lblLegend4.BorderStyle = BorderStyle.FixedSingle;
			Label label4 = this.lblLegend4;
			point = new Point(1117, 403);
			label4.Location = point;
			this.lblLegend4.Name = "lblLegend4";
			Label label5 = this.lblLegend4;
			size = new System.Drawing.Size(71, 17);
			label5.Size = size;
			this.lblLegend4.TabIndex = 9;
			this.lblLegend4.Text = "Improvement";
			this.ToolTip1.SetToolTip(this.lblLegend4, "Care to play SIMON?");
			this.lblLegend2.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			this.lblLegend2.BackColor = Color.DarkGray;
			this.lblLegend2.BorderStyle = BorderStyle.FixedSingle;
			Label label6 = this.lblLegend2;
			point = new Point(1044, 403);
			label6.Location = point;
			this.lblLegend2.Name = "lblLegend2";
			Label label7 = this.lblLegend2;
			size = new System.Drawing.Size(71, 17);
			label7.Size = size;
			this.lblLegend2.TabIndex = 8;
			this.lblLegend2.Text = "Unplanned";
			this.ToolTip1.SetToolTip(this.lblLegend2, "...");
			this.lblTimer.Anchor = AnchorStyles.Bottom | AnchorStyles.Right;
			Label label8 = this.lblTimer;
			point = new Point(1024, 393);
			label8.Location = point;
			this.lblTimer.Name = "lblTimer";
			Label label9 = this.lblTimer;
			size = new System.Drawing.Size(16, 15);
			label9.Size = size;
			this.lblTimer.TabIndex = 11;
			this.lblTimer.Text = "5";
			this.ToolTip1.SetToolTip(this.lblTimer, "Auto update timer. Click to disable.");
			this.btnReports.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			Button button4 = this.btnReports;
			point = new Point(451, 389);
			button4.Location = point;
			this.btnReports.Name = "btnReports";
			Button button5 = this.btnReports;
			size = new System.Drawing.Size(75, 23);
			button5.Size = size;
			this.btnReports.TabIndex = 12;
			this.btnReports.Text = "&Reports";
			this.ToolTip1.SetToolTip(this.btnReports, "Reporting menus");
			this.btnReports.UseVisualStyleBackColor = true;
			this.btnUsers.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			Button button6 = this.btnUsers;
			point = new Point(660, 389);
			button6.Location = point;
			this.btnUsers.Name = "btnUsers";
			Button button7 = this.btnUsers;
			size = new System.Drawing.Size(75, 23);
			button7.Size = size;
			this.btnUsers.TabIndex = 13;
			this.btnUsers.Text = "&Users";
			this.ToolTip1.SetToolTip(this.btnUsers, "View/Set options");
			this.btnUsers.UseVisualStyleBackColor = true;
			this.lblWeekNum.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.lblWeekNum.AutoSize = true;
			Label label10 = this.lblWeekNum;
			point = new Point(334, 394);
			label10.Location = point;
			this.lblWeekNum.Name = "lblWeekNum";
			Label label11 = this.lblWeekNum;
			size = new System.Drawing.Size(39, 13);
			label11.Size = size;
			this.lblWeekNum.TabIndex = 18;
			this.lblWeekNum.Text = "Label1";
			this.ToolTip1.SetToolTip(this.lblWeekNum, "ISO 8601 (Monday-Sunday)");
			this.dgvOverview.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.dgvOverview.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvOverview.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedHeaders;
			this.dgvOverview.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvOverview.ContextMenuStrip = this.ContextMenuStrip1;
			this.dgvOverview.EditMode = DataGridViewEditMode.EditProgrammatically;
			DataGridView dataGridView = this.dgvOverview;
			point = new Point(0, 0);
			dataGridView.Location = point;
			this.dgvOverview.Name = "dgvOverview";
			DataGridView dataGridView1 = this.dgvOverview;
			size = new System.Drawing.Size(1189, 378);
			dataGridView1.Size = size;
			this.dgvOverview.TabIndex = 10;
			this.lblSelectedRow.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.lblSelectedRow.AutoSize = true;
			Label label12 = this.lblSelectedRow;
			point = new Point(544, 394);
			label12.Location = point;
			this.lblSelectedRow.Name = "lblSelectedRow";
			Label label13 = this.lblSelectedRow;
			size = new System.Drawing.Size(39, 13);
			label13.Size = size;
			this.lblSelectedRow.TabIndex = 14;
			this.lblSelectedRow.Text = "Label1";
			this.chkShowEntered.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.chkShowEntered.AutoSize = true;
			this.chkShowEntered.Checked = true;
			this.chkShowEntered.CheckState = CheckState.Checked;
			CheckBox checkBox = this.chkShowEntered;
			point = new Point(12, 382);
			checkBox.Location = point;
			this.chkShowEntered.Name = "chkShowEntered";
			CheckBox checkBox1 = this.chkShowEntered;
			size = new System.Drawing.Size(152, 17);
			checkBox1.Size = size;
			this.chkShowEntered.TabIndex = 15;
			this.chkShowEntered.Text = "Show 'Entered' workorders";
			this.chkShowEntered.UseVisualStyleBackColor = true;
			this.Timer1.Interval = 2000;
			this.lblCountDown.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lblCountDown.AutoSize = true;
			Label label14 = this.lblCountDown;
			point = new Point(828, 394);
			label14.Location = point;
			this.lblCountDown.Name = "lblCountDown";
			Label label15 = this.lblCountDown;
			size = new System.Drawing.Size(19, 13);
			label15.Size = size;
			this.lblCountDown.TabIndex = 16;
			this.lblCountDown.Text = "10";
			this.lblAutoClose.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.lblAutoClose.AutoSize = true;
			Label label16 = this.lblAutoClose;
			point = new Point(761, 394);
			label16.Location = point;
			this.lblAutoClose.Name = "lblAutoClose";
			Label label17 = this.lblAutoClose;
			size = new System.Drawing.Size(72, 13);
			label17.Size = size;
			this.lblAutoClose.TabIndex = 17;
			this.lblAutoClose.Text = "Auto Close in:";
			this.chkHideOld.Anchor = AnchorStyles.Bottom | AnchorStyles.Left;
			this.chkHideOld.AutoSize = true;
			this.chkHideOld.Checked = true;
			this.chkHideOld.CheckState = CheckState.Checked;
			CheckBox checkBox2 = this.chkHideOld;
			point = new Point(12, 401);
			checkBox2.Location = point;
			this.chkHideOld.Name = "chkHideOld";
			CheckBox checkBox3 = this.chkHideOld;
			size = new System.Drawing.Size(142, 17);
			checkBox3.Size = size;
			this.chkHideOld.TabIndex = 19;
			this.chkHideOld.Text = "Hide records older than -";
			this.chkHideOld.UseVisualStyleBackColor = true;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			size = new System.Drawing.Size(1189, 446);
			this.ClientSize = size;
			this.Controls.Add(this.chkHideOld);
			this.Controls.Add(this.lblWeekNum);
			this.Controls.Add(this.lblCountDown);
			this.Controls.Add(this.lblAutoClose);
			this.Controls.Add(this.chkShowEntered);
			this.Controls.Add(this.lblSelectedRow);
			this.Controls.Add(this.btnUsers);
			this.Controls.Add(this.btnReports);
			this.Controls.Add(this.lblTimer);
			this.Controls.Add(this.dgvOverview);
			this.Controls.Add(this.lblLegend4);
			this.Controls.Add(this.lblLegend2);
			this.Controls.Add(this.lblLegend3);
			this.Controls.Add(this.lblLegend1);
			this.Controls.Add(this.ToolStrip1);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnNew);
			this.Icon = (System.Drawing.Icon)resources.GetObject("$this.Icon");
			this.KeyPreview = true;
			size = new System.Drawing.Size(1205, 484);
			this.MinimumSize = size;
			this.Name = "frmMain";
			this.StartPosition = FormStartPosition.CenterScreen;
			this.Text = "Wi WorkLog";
			this.ContextMenuStrip1.ResumeLayout(false);
			this.ToolStrip1.ResumeLayout(false);
			this.ToolStrip1.PerformLayout();
			((ISupportInitialize)this.dgvOverview).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void lblAutoClose_MouseDown(object sender, MouseEventArgs e)
		{
			if ((e.Button != System.Windows.Forms.MouseButtons.Right || (Control.ModifierKeys & Keys.Control) == Keys.None || (Control.ModifierKeys & Keys.Alt) == Keys.None || !MyProject.Computer.Keyboard.ShiftKeyDown ? false : true))
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserAdmin, "True", false) == 0)
				{
					this.CountDown = 480;
				}
				else if (!(Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsLead, "True", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsPartsLead, "True", false) == 0))
				{
					this.CountDown = 1;
				}
				else
				{
					this.CountDown = 120;
				}
				ErrorHandlingStuff.WriteLogEntry(string.Concat("Countdown set : ", this.CountDown.ToString(), " : User:", Generals.CurUserName), "I");
			}
		}

		private void lblLegend4_Click(object sender, EventArgs e)
		{
		}

		private void lblTimer_Click(object sender, EventArgs e)
		{
			this.RefTimer.Enabled = !this.RefTimer.Enabled;
			if (!this.RefTimer.Enabled)
			{
				this.lblTimer.ForeColor = Color.Gray;
				this.ToolTip1.SetToolTip(this.lblTimer, "Refreash timer countdown\r\nClick to start.");
			}
			else
			{
				this.lblTimer.ForeColor = Color.Blue;
				this.ToolTip1.SetToolTip(this.lblTimer, "Refreash timer countdown\r\nClick to stop.");
			}
		}

		public bool PreFilterMessage(ref Message m)
		{
			if (m.Msg >= 256 & m.Msg <= 265 | m.Msg >= 512 & m.Msg <= 526)
			{
				this.Timer1.Stop();
				this.Timer1.Start();
				this.lblCountDown.Text = this.CountDown.ToString();
			}
			return false;
		}

		private void RefTimer_Tick(object obj, EventArgs e)
		{
			bool flag = false;
			try
			{
				Monitor.Enter(this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount$Init, ref flag);
				if (this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount$Init.State == 0)
				{
					this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount$Init.State = 2;
					this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount = 5;
				}
				else if (this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount$Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount$Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount$Init);
				}
			}
			if (this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount > 0)
			{
				this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount = checked(this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount - 1);
			}
			if (this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount == 0)
			{
				this.GlobalRefreshDGV("");
				this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount = 5;
			}
			this.lblTimer.Text = this.$STATIC$RefTimer_Tick$20211C12809D$tmrCount.ToString();
		}

		private void Timer1_Tick(object sender, EventArgs e)
		{
			this.MinuteCount = checked(this.MinuteCount + 1);
			Label str = this.lblCountDown;
			int integer = checked(Conversions.ToInteger(this.lblCountDown.Text) - 1);
			str.Text = integer.ToString();
			if (Conversions.ToInteger(this.lblCountDown.Text) < 1)
			{
				this.Timer1.Stop();
				ErrorHandlingStuff.WriteLogEntry(string.Concat("Inactivity time out:  by User:", Generals.CurUserName), "I");
				this.Close();
			}
		}

		private void tsbCancelSearch_Click(object sender, EventArgs e)
		{
			this.BuildTitle("");
			this.tstxtSearchCriteria.Text = "";
			this.tscbShowOnly.SelectedIndex = 0;
			this.tscbSearchType.SelectedIndex = 0;
			this.tsbCancelSearch.Enabled = false;
			this.tscbShowOnly_SelectedIndexChanged(this, e);
		}

		private void tsbExport_Click(object sender, EventArgs e)
		{
			IEnumerator<string[]> enumerator = null;
			string MyFile = "";
			SaveFileDialog saveFileDialog1 = new SaveFileDialog();
			SaveFileDialog myDocuments = saveFileDialog1;
			myDocuments.Title = "As Exported file.";
			myDocuments.CheckPathExists = true;
			myDocuments.InitialDirectory = MyProject.Computer.FileSystem.SpecialDirectories.MyDocuments;
			DateTime now = DateTime.Now;
			myDocuments.FileName = string.Concat("WiLog-", now.ToString("ddMMyyyy"), ".csv");
			myDocuments.DefaultExt = "csv";
			myDocuments.Filter = "csv files (*.csv)|*.csv";
			myDocuments = null;
			if (saveFileDialog1.ShowDialog() == System.Windows.Forms.DialogResult.OK)
			{
				MyFile = saveFileDialog1.FileName;
				string[] headers = (
					from DataGridViewColumn header in this.dgvOverview.Columns
					select string.Concat("\"", header.HeaderText.ToString(), "\"")).ToArray<string>();
				IEnumerable<string[]> rows = 
					from DataGridViewRow row in this.dgvOverview.Rows
					where !row.IsNewRow
					select Array.ConvertAll<DataGridViewCell, string>(row.Cells.Cast<DataGridViewCell>().ToArray<DataGridViewCell>(), (DataGridViewCell c) => (c.Value != null ? string.Concat("\"", c.Value.ToString(), "\"") : ""));
				using (StreamWriter sw = new StreamWriter(MyFile))
				{
					sw.WriteLine(string.Join(",", headers));
					using (enumerator)
					{
						enumerator = rows.GetEnumerator();
						while (enumerator.MoveNext())
						{
							sw.WriteLine(string.Join(",", enumerator.Current));
						}
					}
					sw.Flush();
					sw.Close();
				}
				Process.Start(MyFile);
			}
		}

		private void tsbSearch_Click(object sender, EventArgs e)
		{
			string[] text;
			string MySQL = "";
			string WhereSQL = "";
			string GroupSQL = "";
			if (!((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.tscbSearchType.Text, "Date Range", false) == 0 || Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.tstxtSearchCriteria.Text, "", false) == 0 ? false : true) | (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.tscbSearchType.Text, "Date Range", false) != 0 || !this.dtpFromDate.Visible ? false : true)))
			{
				MySQL = "SELECT tl.*, nvl(sum(zzu.zztlu_time),0) \"TTime\",count(zzu.zztlu_name) \"TCount\" FROM ZZTECHLOG tl, ZZTECHLOG_User zzu ";
				WhereSQL = "where zzu.zztl_ref(+) = tl.zztl_ref ";
				GroupSQL = " group by tl.zztl_ref,tl.zztl_state,tl.zztl_wotype,tl.zztl_woasset,tl.zztl_wocomplaint,tl.zztl_worootcause,tl.zztl_wocorrection,tl.zztl_genuser,tl.zztl_gendate,tl.zztl_moduser,tl.zztl_moddate order by zztl_gendate desc";
				this.BuildTitle("SEARCH: All");
			}
			else
			{
				string str = this.tscbSearchType.Text;
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Asset Like", false) == 0)
				{
					MySQL = "SELECT tl.*, nvl(sum(zzu.zztlu_time),0) \"TTime\",count(zzu.zztlu_name) \"TCount\" FROM ZZTECHLOG tl , ZZTECHLOG_User zzu ";
					WhereSQL = string.Concat(" WHERE zzu.zztl_ref(+) = tl.zztl_ref AND upper(tl.zztl_woasset) like '%", Microsoft.VisualBasic.Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%'  ");
					GroupSQL = " GROUP BY tl.zztl_ref,tl.zztl_state,tl.zztl_wotype,tl.zztl_woasset,tl.zztl_wocomplaint,tl.zztl_worootcause,tl.zztl_wocorrection,tl.zztl_genuser,tl.zztl_gendate,zztl_moduser,zztl_moddate ORDER BY zztl_gendate desc";
					this.BuildTitle(string.Concat("SEARCH: Asset Like '", this.tstxtSearchCriteria.Text.ToUpper(), "'"));
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Date Range", false) == 0)
				{
					MySQL = "SELECT tl.*, nvl(sum(zzu.zztlu_time),0) \"TTime\",count(zzu.zztlu_name) \"TCount\" FROM ZZTECHLOG tl, ZZTECHLOG_User zzu ";
					text = new string[] { "WHERE zzu.zztl_ref(+) = tl.zztl_ref AND trunc(tl.zztl_moddate) between to_date('", this.dtpFromDate.Text, "','MM-DD-YYYY') and to_date('", this.dtpToDate.Text, "','MM-DD-YYYY') " };
					WhereSQL = string.Concat(text);
					GroupSQL = " GROUP BY tl.zztl_ref,tl.zztl_state,tl.zztl_wotype,tl.zztl_woasset,tl.zztl_wocomplaint,tl.zztl_worootcause,tl.zztl_wocorrection,tl.zztl_genuser,tl.zztl_gendate,zztl_moduser,zztl_moddate ORDER BY zztl_gendate desc";
					text = new string[] { "SEARCH: ", this.tscbSearchType.Text, " between ", this.dtpFromDate.Text, " and ", this.dtpToDate.Text };
					this.BuildTitle(string.Concat(text));
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "User Like", false) == 0)
				{
					MySQL = "SELECT tl.*, nvl(sum(zzu.zztlu_time),0) \"TTime\",count(zzu.zztlu_name) \"TCount\" FROM ZZTECHLOG tl, ZZTECHLOG_User zzu ";
					text = new string[] { "WHERE zzu.zztl_ref(+) = tl.zztl_ref AND (upper(tl.zztl_genuser) like '%", Microsoft.VisualBasic.Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' OR upper(tl.zztl_moduser) like '%", Microsoft.VisualBasic.Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' )" };
					WhereSQL = string.Concat(text);
					GroupSQL = " GROUP BY tl.zztl_ref,tl.zztl_state,tl.zztl_wotype,tl.zztl_woasset,tl.zztl_wocomplaint,tl.zztl_worootcause,tl.zztl_wocorrection,tl.zztl_genuser,tl.zztl_gendate,zztl_moduser,zztl_moddate ORDER BY zztl_gendate desc";
					this.BuildTitle(string.Concat("SEARCH: User Like '", this.tstxtSearchCriteria.Text.ToUpper(), "'"));
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "State Like", false) == 0)
				{
					MySQL = "SELECT tl.*, nvl(sum(zzu.zztlu_time),0) \"TTime\",count(zzu.zztlu_name) \"TCount\" from ZZTECHLOG tl, ZZTECHLOG_User zzu ";
					WhereSQL = string.Concat("WHERE zzu.zztl_ref(+) = tl.zztl_ref AND upper(tl.zztl_state) like '%", Microsoft.VisualBasic.Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' ");
					GroupSQL = " GROUP BY tl.zztl_ref,tl.zztl_state,tl.zztl_wotype,tl.zztl_woasset,tl.zztl_wocomplaint,tl.zztl_worootcause,tl.zztl_wocorrection,tl.zztl_genuser,tl.zztl_gendate,zztl_moduser,zztl_moddate ORDER BY zztl_gendate desc";
					this.BuildTitle(string.Concat("SEARCH: State Like '", this.tstxtSearchCriteria.Text.ToUpper(), "'"));
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Full text", false) == 0)
				{
					MySQL = "select * from (SELECT tl.*, nvl(sum(zzu.zztlu_time),0) \"TTime\",count(zzu.zztlu_name) \"TCount\" from ZZTECHLOG tl, ZZTECHLOG_User zzu WHERE zzu.zztl_ref(+) = tl.zztl_ref GROUP BY tl.zztl_ref,tl.zztl_state,tl.zztl_wotype,tl.zztl_woasset,tl.zztl_wocomplaint,tl.zztl_worootcause,tl.zztl_wocorrection,tl.zztl_genuser,tl.zztl_gendate,zztl_moduser,zztl_moddate ORDER BY zztl_gendate desc) tl";
					text = new string[] { " where (upper(tl.zztl_wocomplaint) like '%", Microsoft.VisualBasic.Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' OR upper(tl.zztl_wocorrection) like '%", Microsoft.VisualBasic.Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' OR upper(tl.zztl_worootcause) like '%", Microsoft.VisualBasic.Strings.Replace(this.tstxtSearchCriteria.Text.ToUpper(), "'", "''", 1, -1, CompareMethod.Binary), "%' )" };
					WhereSQL = string.Concat(text);
					GroupSQL = "";
					this.BuildTitle(string.Concat("Full text: Like '", this.tstxtSearchCriteria.Text, "'"));
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Week #", false) == 0)
				{
					MySQL = "SELECT tl.*, nvl(sum(zzu.zztlu_time),0) \"TTime\",count(zzu.zztlu_name) \"TCount\" FROM ZZTECHLOG tl, ZZTECHLOG_User zzu ";
					WhereSQL = string.Concat(" WHERE zzu.zztl_ref(+) = tl.zztl_ref and to_char(zztl_gendate,'IW') = ", this.tstxtSearchCriteria.Text.ToUpper());
					GroupSQL = " GROUP BY tl.zztl_ref,tl.zztl_state,tl.zztl_wotype,tl.zztl_woasset,tl.zztl_wocomplaint,tl.zztl_worootcause,tl.zztl_wocorrection,tl.zztl_genuser,tl.zztl_gendate,zztl_moduser,zztl_moddate ORDER BY zztl_gendate desc";
					this.BuildTitle(string.Concat("SEARCH: Week #", this.tstxtSearchCriteria.Text));
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "Ref #", false) == 0)
				{
					MySQL = "SELECT tl.*, nvl(sum(zzu.zztlu_time),0) \"TTime\",count(zzu.zztlu_name) \"TCount\" FROM ZZTECHLOG tl, ZZTECHLOG_User zzu ";
					WhereSQL = string.Concat(" WHERE zzu.zztl_ref(+) = tl.zztl_ref and tl.zztl_ref = ", this.tstxtSearchCriteria.Text);
					GroupSQL = " GROUP BY tl.zztl_ref,tl.zztl_state,tl.zztl_wotype,tl.zztl_woasset,tl.zztl_wocomplaint,tl.zztl_worootcause,tl.zztl_wocorrection,tl.zztl_genuser,tl.zztl_gendate,zztl_moduser,zztl_moddate ORDER BY zztl_gendate desc";
					this.BuildTitle(string.Concat("SEARCH: Ref #", this.tstxtSearchCriteria.Text));
				}
			}
			if (!this.chkShowEntered.Checked)
			{
				WhereSQL = string.Concat(WhereSQL, " and tl.zztl_state != 'Entered'");
			}
			if (this.chkHideOld.Checked)
			{
				WhereSQL = string.Concat(WhereSQL, " and zztl_gendate > (sysdate - 30) ");
			}
			this.GlobalRefreshDGV(string.Concat(MySQL, WhereSQL, GroupSQL));
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

		private void tscbShowOnly_SelectedIndexChanged(object sender, EventArgs e)
		{
			string MySQL = "";
			string TstStr = "SELECT tl.zztl_ref, tl.zztl_state,tl.zztl_wotype, nvl(zztl_woasset,'N/A') \"zztl_woasset\",zztl_wocomplaint,zztl_worootcause,zztl_wocorrection,zztl_genuser,zztl_gendate,zztl_moduser,zztl_moddate";
			TstStr = string.Concat(TstStr, ",nvl(sum(zzu.zztlu_time),0) \"TTime\",count(zzu.zztlu_name) \"TCount\" FROM ZZTECHLOG tl ,ZZTECHLOG_User zzu where zzu.zztl_ref(+) = tl.zztl_ref ");
			string GrpBy = " group by tl.zztl_ref,tl.zztl_state,tl.zztl_wotype,tl.zztl_woasset,tl.zztl_wocomplaint,tl.zztl_worootcause,tl.zztl_wocorrection,tl.zztl_genuser,tl.zztl_gendate,tl.zztl_moduser,tl.zztl_moddate order by zztl_gendate desc";
			if (!this.chkShowEntered.Checked)
			{
				TstStr = string.Concat(TstStr, " and tl.zztl_state != 'Entered' ");
			}
			if (this.chkHideOld.Checked)
			{
				TstStr = string.Concat(TstStr, " and zztl_gendate > (sysdate - 30) ");
			}
			string text = this.tscbShowOnly.Text;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "All", false) == 0)
			{
				MySQL = string.Concat(TstStr, GrpBy);
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Mine", false) != 0)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Passdown", false) == 0)
				{
					MySQL = string.Concat(TstStr, " and tl.zztl_wotype = 'Passdown'", GrpBy);
					this.BuildTitle(string.Concat("SEARCH: ", this.tscbShowOnly.Text));
					this.GlobalRefreshDGV(MySQL);
					return;
				}
				return;
			}
			else
			{
				string[] curUserName = new string[] { TstStr, " and (tl.zztl_genuser = '", Generals.CurUserName, "' OR tl.zztl_moduser ='", Generals.CurUserName, "')", GrpBy };
				MySQL = string.Concat(curUserName);
			}
			this.BuildTitle(string.Concat("SEARCH: ", this.tscbShowOnly.Text));
			this.GlobalRefreshDGV(MySQL);
		}

		private void tslVersion_Click(object sender, EventArgs e)
		{
			Generals.maketable();
		}
	}
}