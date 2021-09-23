using Microsoft.VisualBasic;
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
using System.Threading;
using System.Windows.Forms;
using WiLog.My;

namespace WiLog
{
	[DesignerGenerated]
	public class frmRecord : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("btnClose")]
		private Button _btnClose;

		[AccessedThroughProperty("btnSave")]
		private Button _btnSave;

		[AccessedThroughProperty("StatusStrip1")]
		private StatusStrip _StatusStrip1;

		[AccessedThroughProperty("cbState")]
		private ComboBox _cbState;

		[AccessedThroughProperty("cbType")]
		private ComboBox _cbType;

		[AccessedThroughProperty("txtAssest")]
		private TextBox _txtAssest;

		[AccessedThroughProperty("dgvParts")]
		private DataGridView _dgvParts;

		[AccessedThroughProperty("dgvTechs")]
		private DataGridView _dgvTechs;

		[AccessedThroughProperty("ToolTip1")]
		private ToolTip _ToolTip1;

		[AccessedThroughProperty("btnDelete")]
		private Button _btnDelete;

		[AccessedThroughProperty("cmsDGV")]
		private System.Windows.Forms.ContextMenuStrip _cmsDGV;

		[AccessedThroughProperty("DeleteRowToolStripMenuItem")]
		private ToolStripMenuItem _DeleteRowToolStripMenuItem;

		[AccessedThroughProperty("tsslblModInfo")]
		private ToolStripStatusLabel _tsslblModInfo;

		[AccessedThroughProperty("lblTechRows")]
		private Label _lblTechRows;

		[AccessedThroughProperty("lblPartsRows")]
		private Label _lblPartsRows;

		[AccessedThroughProperty("lblComplaint")]
		private Label _lblComplaint;

		[AccessedThroughProperty("lblCause")]
		private Label _lblCause;

		[AccessedThroughProperty("lblCorrection")]
		private Label _lblCorrection;

		[AccessedThroughProperty("rtbCorrection")]
		private RichTextBox _rtbCorrection;

		[AccessedThroughProperty("rtbCause")]
		private RichTextBox _rtbCause;

		[AccessedThroughProperty("rtbComplaint")]
		private RichTextBox _rtbComplaint;

		public int ThisRecord;

		public string EditMode;

		public DataTable tbl_Tech;

		private DataGridViewComboBoxColumn cbTech;

		private int rowIndex;

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
				frmRecord _frmRecord = this;
				EventHandler eventHandler = new EventHandler(_frmRecord.btnClose_Click);
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

		internal virtual Button btnDelete
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnDelete;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmRecord _frmRecord = this;
				EventHandler eventHandler = new EventHandler(_frmRecord.btnDelete_Click);
				if (this._btnDelete != null)
				{
					this._btnDelete.Click -= eventHandler;
				}
				this._btnDelete = value;
				if (this._btnDelete != null)
				{
					this._btnDelete.Click += eventHandler;
				}
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
				frmRecord _frmRecord = this;
				EventHandler eventHandler = new EventHandler(_frmRecord.btnSave_Click);
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

		internal virtual ComboBox cbState
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbState;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbState = value;
			}
		}

		internal virtual ComboBox cbType
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cbType;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cbType = value;
			}
		}

		internal virtual System.Windows.Forms.ContextMenuStrip cmsDGV
		{
			[DebuggerNonUserCode]
			get
			{
				return this._cmsDGV;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._cmsDGV = value;
			}
		}

		internal virtual ToolStripMenuItem DeleteRowToolStripMenuItem
		{
			[DebuggerNonUserCode]
			get
			{
				return this._DeleteRowToolStripMenuItem;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmRecord _frmRecord = this;
				EventHandler eventHandler = new EventHandler(_frmRecord.DeleteRowToolStripMenuItem_Click);
				if (this._DeleteRowToolStripMenuItem != null)
				{
					this._DeleteRowToolStripMenuItem.Click -= eventHandler;
				}
				this._DeleteRowToolStripMenuItem = value;
				if (this._DeleteRowToolStripMenuItem != null)
				{
					this._DeleteRowToolStripMenuItem.Click += eventHandler;
				}
			}
		}

		internal virtual DataGridView dgvParts
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgvParts;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmRecord _frmRecord = this;
				DataGridViewRowEventHandler dataGridViewRowEventHandler = new DataGridViewRowEventHandler(_frmRecord.dgvParts_DefaultValuesNeeded);
				frmRecord _frmRecord1 = this;
				DataGridViewCellValidatingEventHandler dataGridViewCellValidatingEventHandler = new DataGridViewCellValidatingEventHandler(_frmRecord1.dgvParts_CellValidating);
				frmRecord _frmRecord2 = this;
				DataGridViewEditingControlShowingEventHandler dataGridViewEditingControlShowingEventHandler = new DataGridViewEditingControlShowingEventHandler(_frmRecord2.dgv_EditingControlShowing);
				frmRecord _frmRecord3 = this;
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(_frmRecord3.dgvParts_CellValidated);
				frmRecord _frmRecord4 = this;
				DataGridViewCellCancelEventHandler dataGridViewCellCancelEventHandler = new DataGridViewCellCancelEventHandler(_frmRecord4.dgvParts_RowValidating);
				frmRecord _frmRecord5 = this;
				DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler = new DataGridViewCellMouseEventHandler(_frmRecord5.dgv_CellMouseUp);
				frmRecord _frmRecord6 = this;
				DataGridViewRowsRemovedEventHandler dataGridViewRowsRemovedEventHandler = new DataGridViewRowsRemovedEventHandler(_frmRecord6.dgvParts_RowsRemoved);
				frmRecord _frmRecord7 = this;
				DataGridViewRowsAddedEventHandler dataGridViewRowsAddedEventHandler = new DataGridViewRowsAddedEventHandler(_frmRecord7.dgvTechs_RowsAdded);
				if (this._dgvParts != null)
				{
					this._dgvParts.DefaultValuesNeeded -= dataGridViewRowEventHandler;
					this._dgvParts.CellValidating -= dataGridViewCellValidatingEventHandler;
					this._dgvParts.EditingControlShowing -= dataGridViewEditingControlShowingEventHandler;
					this._dgvParts.CellValidated -= dataGridViewCellEventHandler;
					this._dgvParts.RowValidating -= dataGridViewCellCancelEventHandler;
					this._dgvParts.CellMouseUp -= dataGridViewCellMouseEventHandler;
					this._dgvParts.RowsRemoved -= dataGridViewRowsRemovedEventHandler;
					this._dgvParts.RowsAdded -= dataGridViewRowsAddedEventHandler;
				}
				this._dgvParts = value;
				if (this._dgvParts != null)
				{
					this._dgvParts.DefaultValuesNeeded += dataGridViewRowEventHandler;
					this._dgvParts.CellValidating += dataGridViewCellValidatingEventHandler;
					this._dgvParts.EditingControlShowing += dataGridViewEditingControlShowingEventHandler;
					this._dgvParts.CellValidated += dataGridViewCellEventHandler;
					this._dgvParts.RowValidating += dataGridViewCellCancelEventHandler;
					this._dgvParts.CellMouseUp += dataGridViewCellMouseEventHandler;
					this._dgvParts.RowsRemoved += dataGridViewRowsRemovedEventHandler;
					this._dgvParts.RowsAdded += dataGridViewRowsAddedEventHandler;
				}
			}
		}

		internal virtual DataGridView dgvTechs
		{
			[DebuggerNonUserCode]
			get
			{
				return this._dgvTechs;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmRecord _frmRecord = this;
				DataGridViewEditingControlShowingEventHandler dataGridViewEditingControlShowingEventHandler = new DataGridViewEditingControlShowingEventHandler(_frmRecord.dgv_EditingControlShowing);
				frmRecord _frmRecord1 = this;
				DataGridViewCellEventHandler dataGridViewCellEventHandler = new DataGridViewCellEventHandler(_frmRecord1.dgvParts_CellValidated);
				frmRecord _frmRecord2 = this;
				DataGridViewCellMouseEventHandler dataGridViewCellMouseEventHandler = new DataGridViewCellMouseEventHandler(_frmRecord2.dgv_CellMouseUp);
				frmRecord _frmRecord3 = this;
				DataGridViewRowsRemovedEventHandler dataGridViewRowsRemovedEventHandler = new DataGridViewRowsRemovedEventHandler(_frmRecord3.dgvParts_RowsRemoved);
				frmRecord _frmRecord4 = this;
				DataGridViewRowsAddedEventHandler dataGridViewRowsAddedEventHandler = new DataGridViewRowsAddedEventHandler(_frmRecord4.dgvTechs_RowsAdded);
				frmRecord _frmRecord5 = this;
				DataGridViewRowEventHandler dataGridViewRowEventHandler = new DataGridViewRowEventHandler(_frmRecord5.dgvTechs_DefaultValuesNeeded);
				if (this._dgvTechs != null)
				{
					this._dgvTechs.EditingControlShowing -= dataGridViewEditingControlShowingEventHandler;
					this._dgvTechs.CellValidated -= dataGridViewCellEventHandler;
					this._dgvTechs.CellMouseUp -= dataGridViewCellMouseEventHandler;
					this._dgvTechs.RowsRemoved -= dataGridViewRowsRemovedEventHandler;
					this._dgvTechs.RowsAdded -= dataGridViewRowsAddedEventHandler;
					this._dgvTechs.DefaultValuesNeeded -= dataGridViewRowEventHandler;
				}
				this._dgvTechs = value;
				if (this._dgvTechs != null)
				{
					this._dgvTechs.EditingControlShowing += dataGridViewEditingControlShowingEventHandler;
					this._dgvTechs.CellValidated += dataGridViewCellEventHandler;
					this._dgvTechs.CellMouseUp += dataGridViewCellMouseEventHandler;
					this._dgvTechs.RowsRemoved += dataGridViewRowsRemovedEventHandler;
					this._dgvTechs.RowsAdded += dataGridViewRowsAddedEventHandler;
					this._dgvTechs.DefaultValuesNeeded += dataGridViewRowEventHandler;
				}
			}
		}

		internal virtual Label lblCause
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCause;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmRecord _frmRecord = this;
				EventHandler eventHandler = new EventHandler(_frmRecord.lblCorrection_Click);
				if (this._lblCause != null)
				{
					this._lblCause.Click -= eventHandler;
				}
				this._lblCause = value;
				if (this._lblCause != null)
				{
					this._lblCause.Click += eventHandler;
				}
			}
		}

		internal virtual Label lblComplaint
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblComplaint;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmRecord _frmRecord = this;
				EventHandler eventHandler = new EventHandler(_frmRecord.lblCorrection_Click);
				if (this._lblComplaint != null)
				{
					this._lblComplaint.Click -= eventHandler;
				}
				this._lblComplaint = value;
				if (this._lblComplaint != null)
				{
					this._lblComplaint.Click += eventHandler;
				}
			}
		}

		internal virtual Label lblCorrection
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblCorrection;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				frmRecord _frmRecord = this;
				EventHandler eventHandler = new EventHandler(_frmRecord.lblCorrection_Click);
				if (this._lblCorrection != null)
				{
					this._lblCorrection.Click -= eventHandler;
				}
				this._lblCorrection = value;
				if (this._lblCorrection != null)
				{
					this._lblCorrection.Click += eventHandler;
				}
			}
		}

		internal virtual Label lblPartsRows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblPartsRows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblPartsRows = value;
			}
		}

		internal virtual Label lblTechRows
		{
			[DebuggerNonUserCode]
			get
			{
				return this._lblTechRows;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._lblTechRows = value;
			}
		}

		internal virtual RichTextBox rtbCause
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rtbCause;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rtbCause = value;
			}
		}

		internal virtual RichTextBox rtbComplaint
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rtbComplaint;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rtbComplaint = value;
			}
		}

		internal virtual RichTextBox rtbCorrection
		{
			[DebuggerNonUserCode]
			get
			{
				return this._rtbCorrection;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._rtbCorrection = value;
			}
		}

		internal virtual StatusStrip StatusStrip1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._StatusStrip1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._StatusStrip1 = value;
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

		internal virtual ToolStripStatusLabel tsslblModInfo
		{
			[DebuggerNonUserCode]
			get
			{
				return this._tsslblModInfo;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._tsslblModInfo = value;
			}
		}

		internal virtual TextBox txtAssest
		{
			[DebuggerNonUserCode]
			get
			{
				return this._txtAssest;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._txtAssest = value;
			}
		}

		[DebuggerNonUserCode]
		static frmRecord()
		{
			frmRecord.__ENCList = new List<WeakReference>();
		}

		public frmRecord(int Record_Ref = 0, string TheMode = "New")
		{
			frmRecord _frmRecord = this;
			base.Load += new EventHandler(_frmRecord.frmNew_Load);
			frmRecord _frmRecord1 = this;
			base.KeyDown += new KeyEventHandler(_frmRecord1.frmRecord_KeyDown);
			frmRecord.__ENCAddToList(this);
			this.ThisRecord = 0;
			this.EditMode = "";
			this.tbl_Tech = new DataTable();
			this.cbTech = new DataGridViewComboBoxColumn();
			this.rowIndex = 0;
			this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x$Init = new StaticLocalInitFlag();
			this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x$Init = new StaticLocalInitFlag();
			this.InitializeComponent();
			this.ThisRecord = Record_Ref;
			this.EditMode = TheMode;
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (frmRecord.__ENCList)
			{
				if (frmRecord.__ENCList.Count == frmRecord.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmRecord.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmRecord.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmRecord.__ENCList[item] = frmRecord.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmRecord.__ENCList.RemoveRange(item, checked(frmRecord.__ENCList.Count - item));
					frmRecord.__ENCList.Capacity = frmRecord.__ENCList.Count;
				}
				frmRecord.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void btnClose_Click(object sender, EventArgs e)
		{
			this.Close();
		}

		private void btnDelete_Click(object sender, EventArgs e)
		{
			int result = (int)MessageBox.Show(string.Concat("Delete work order #", Conversions.ToString(this.ThisRecord)), "Are you sure?", MessageBoxButtons.YesNoCancel);
			if (result != 2)
			{
				if (result == 7)
				{
					this.Close();
				}
				else if (result == 6)
				{
					this.EditMode = "DELETE";
					this.btnSave_Click(this, e);
					ErrorHandlingStuff.WriteLogEntry(string.Concat("DELETE of work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName), "I");
				}
			}
		}

		private void btnSave_Click(object sender, EventArgs e)
		{
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbState.Text, "Entered", false) == 0)
			{
				int result = (int)MessageBox.Show("Marking this record as 'Entered' will prevent ANY further changes!", "Are you sure?", MessageBoxButtons.YesNo);
				if (result == 7)
				{
					return;
				}
				if (result == 6)
				{
					ErrorHandlingStuff.WriteLogEntry(string.Concat("State 'Entered' of work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName), "I");
				}
			}
			this.RecordSaveDGV();
			MyProject.Forms.frmMain.GlobalRefreshDGV("");
			this.Close();
		}

		private void BuildEmptyPartsDGV()
		{
			DataGridView dataGridView = this.dgvParts;
			dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.RowHeadersWidth = 10;
			dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridView.AutoGenerateColumns = true;
			dataGridView.Columns.Add("zztlp_ref", "zztlp_ref");
			dataGridView.Columns["zztlp_ref"].Visible = false;
			dataGridView.Columns.Add("zztl_ref", "zztl_ref");
			dataGridView.Columns["zztl_ref"].Visible = false;
			dataGridView.Columns.Add("zztlp_qnty", "Qnty");
			dataGridView.Columns["zztlp_qnty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns["zztlp_qnty"].MinimumWidth = 30;
			dataGridView.Columns["zztlp_qnty"].FillWeight = 50f;
			dataGridView.Columns["zztlp_qnty"].ToolTipText = "Number of this item used in repair.";
			dataGridView.Columns.Add("zzhtlp_partnumber", "Part Number");
			dataGridView.Columns["zzhtlp_partnumber"].MinimumWidth = 90;
			dataGridView.Columns["zzhtlp_partnumber"].FillWeight = 50f;
			dataGridView.Columns["zzhtlp_partnumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns.Add("zzhtlp_location", "Location");
			dataGridView.Columns["zzhtlp_location"].MinimumWidth = 70;
			dataGridView.Columns["zzhtlp_location"].FillWeight = 100f;
			dataGridView.Columns["zzhtlp_location"].ToolTipText = "Asile and side (left/right)";
			dataGridView.Columns.Add("zzhtlp_description", "Description");
			dataGridView.Columns["zzhtlp_description"].MinimumWidth = 80;
			dataGridView.Columns["zzhtlp_description"].FillWeight = 400f;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.EditMode, "VIEW", false) == 0)
			{
				dataGridView.AllowUserToDeleteRows = false;
				dataGridView.AllowUserToAddRows = false;
				dataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
			}
			else
			{
				dataGridView.AllowUserToDeleteRows = true;
				dataGridView.AllowUserToAddRows = true;
				dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
			}
			dataGridView = null;
		}

		private void BuildEmptyTechsDGV()
		{
			DataGridView dataGridView = this.dgvTechs;
			dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.RowHeadersWidth = 10;
			dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridView.AutoGenerateColumns = true;
			dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
			dataGridView.Columns.Add("ZZTLU_REF", "ZZTLU_REF");
			dataGridView.Columns["ZZTLU_REF"].Visible = false;
			dataGridView.Columns.Add("ZZTL_REF", "ZZTL_REF");
			dataGridView.Columns["ZZTL_REF"].Visible = false;
			dataGridView.Columns.Add(this.cbTech);
			dataGridView.Columns["cbTech"].MinimumWidth = 90;
			dataGridView.Columns["cbTech"].FillWeight = 50f;
			dataGridView.Columns["cbTech"].ToolTipText = "Name of tech with time on this repair.";
			dataGridView.Columns.Add("ZZTLU_Shift", "Shift");
			dataGridView.Columns["ZZTLU_Shift"].ReadOnly = true;
			dataGridView.Columns["ZZTLU_Shift"].MinimumWidth = 90;
			dataGridView.Columns["ZZTLU_Shift"].FillWeight = 50f;
			dataGridView.Columns["ZZTLU_Shift"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView.Columns["ZZTLU_Shift"].ToolTipText = "Shift this user is assigned to.";
			dataGridView.Columns.Add("ZZTLU_TIME", "Minutes");
			dataGridView.Columns["ZZTLU_TIME"].MinimumWidth = 90;
			dataGridView.Columns["ZZTLU_TIME"].FillWeight = 50f;
			dataGridView.Columns["ZZTLU_TIME"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns["ZZTLU_TIME"].ToolTipText = "Time in 5 min blocks.";
			dataGridView.Columns.Add("zzTLU_DATE", "Date");
			dataGridView.Columns["zzTLU_DATE"].HeaderText = "Date";
			dataGridView.Columns["zzTLU_DATE"].MinimumWidth = 90;
			dataGridView.Columns["zzTLU_DATE"].FillWeight = 50f;
			dataGridView.Columns["zzTLU_DATE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns["zzTLU_DATE"].ToolTipText = "Date labor was done on.";
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.EditMode, "VIEW", false) == 0)
			{
				dataGridView.AllowUserToDeleteRows = false;
				dataGridView.AllowUserToAddRows = false;
				dataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
			}
			else
			{
				dataGridView.AllowUserToDeleteRows = true;
				dataGridView.AllowUserToAddRows = true;
				dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
			}
			dataGridView = null;
		}

		private void DeleteRowToolStripMenuItem_Click(object sender, EventArgs e)
		{
			string str = this.cmsDGV.SourceControl.Name.ToString();
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "dgvParts", false) == 0)
			{
				if (Interaction.MsgBox("Delete this parts row?", MsgBoxStyle.YesNo | MsgBoxStyle.SystemModal, "Are you sure?") == MsgBoxResult.Yes)
				{
					if (!this.dgvParts.Rows[this.dgvParts.CurrentRow.Index].IsNewRow)
					{
						this.dgvParts.Rows.RemoveAt(this.dgvParts.CurrentRow.Index);
						ErrorHandlingStuff.WriteLogEntry(string.Concat("DELETE of parts from work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName), "I");
					}
				}
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(str, "dgvTechs", false) == 0)
			{
				if (MessageBox.Show("Delete this tech's time row?", "Are you sure?", MessageBoxButtons.YesNo) == System.Windows.Forms.DialogResult.Yes)
				{
					if (!this.dgvTechs.Rows[this.rowIndex].IsNewRow)
					{
						this.dgvTechs.Rows.RemoveAt(this.rowIndex);
					}
				}
			}
		}

		private void dgv_CellMouseUp(object sender, DataGridViewCellMouseEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (e.Button == System.Windows.Forms.MouseButtons.Right)
			{
				dgv.Rows[e.RowIndex].Selected = true;
				this.rowIndex = e.RowIndex;
				dgv.CurrentCell = dgv.Rows[e.RowIndex].Cells[4];
				this.cmsDGV.Show(dgv, e.Location);
				this.cmsDGV.Show(System.Windows.Forms.Cursor.Position);
			}
		}

		private void dgv_EditingControlShowing(object sender, DataGridViewEditingControlShowingEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (e.Control is TextBox)
			{
				TextBox tb = e.Control as TextBox;
				string name = dgv.Name;
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "dgvParts", false) == 0)
				{
					if (dgv.CurrentCell.ColumnIndex != Generals.GetColName("Qnty", ref dgv))
					{
						frmRecord _frmRecord = this;
						tb.KeyPress -= new KeyPressEventHandler(_frmRecord.tb_KeyPress);
					}
					else
					{
						frmRecord _frmRecord1 = this;
						tb.KeyPress -= new KeyPressEventHandler(_frmRecord1.tb_KeyPress);
						frmRecord _frmRecord2 = this;
						tb.KeyPress += new KeyPressEventHandler(_frmRecord2.tb_KeyPress);
					}
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "dgvTechs", false) == 0)
				{
					if (dgv.CurrentCell.ColumnIndex != Generals.GetColName("Minutes", ref dgv))
					{
						frmRecord _frmRecord3 = this;
						tb.KeyPress -= new KeyPressEventHandler(_frmRecord3.tb_KeyPress);
					}
					else
					{
						frmRecord _frmRecord4 = this;
						tb.KeyPress -= new KeyPressEventHandler(_frmRecord4.tb_KeyPress);
						frmRecord _frmRecord5 = this;
						tb.KeyPress += new KeyPressEventHandler(_frmRecord5.tb_KeyPress);
					}
				}
			}
			else if (e.Control is ComboBox)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dgv.Name, "dgvTechs", false) == 0)
				{
					ComboBox editingComboBox = e.Control as ComboBox;
					if (dgv.CurrentCell.ColumnIndex != Generals.GetColName("Tech Name", ref dgv))
					{
						frmRecord _frmRecord6 = this;
						editingComboBox.SelectedIndexChanged -= new EventHandler(_frmRecord6.editingComboBox_SelectedIndexChanged);
					}
					else
					{
						frmRecord _frmRecord7 = this;
						editingComboBox.SelectedIndexChanged -= new EventHandler(_frmRecord7.editingComboBox_SelectedIndexChanged);
						frmRecord _frmRecord8 = this;
						editingComboBox.SelectedIndexChanged += new EventHandler(_frmRecord8.editingComboBox_SelectedIndexChanged);
					}
				}
			}
		}

		private void dgvParts_CellValidated(object sender, DataGridViewCellEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(dgv.Name, "dgvTechs", false) == 0)
			{
				if (dgv.CurrentCell.ColumnIndex == Generals.GetColName("Minutes", ref dgv))
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(dgv.Rows[e.RowIndex].Cells[Generals.GetColName("Minutes", ref dgv)].Value, 600, false))
					{
						MessageBox.Show(string.Concat("Times over 600 minutes are not allowed! (", dgv.Rows[e.RowIndex].Cells[Generals.GetColName("Minutes", ref dgv)].Value.ToString(), " entered.)"), "Error!");
						DataGridViewCell cell = ((DataGridView)sender).Rows[e.RowIndex].Cells[e.ColumnIndex];
						cell.Value = 60;
					}
				}
			}
		}

		private void dgvParts_CellValidating(object sender, DataGridViewCellValidatingEventArgs e)
		{
		}

		private void dgvParts_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			bool flag = false;
			try
			{
				Monitor.Enter(this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x$Init, ref flag);
				if (this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x$Init.State == 0)
				{
					this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x$Init.State = 2;
					this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x = 1;
				}
				else if (this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x$Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x$Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x$Init);
				}
			}
			DataGridViewRow row = e.Row;
			row.Cells["zztlp_ref"].Value = this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x;
			row.Cells["zztl_ref"].Value = this.ThisRecord;
			row.Cells["zztlp_qnty"].Value = "1";
			this.$STATIC$dgvParts_DefaultValuesNeeded$20211C128159$x = 1;
			row = null;
		}

		private void dgvParts_RowsRemoved(object sender, DataGridViewRowsRemovedEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			string name = dgv.Name;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "dgvTechs", false) == 0)
			{
				this.lblTechRows.Text = string.Concat("(", Conversions.ToString(checked(dgv.Rows.Count - 1)), ")");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "dgvParts", false) == 0)
			{
				this.lblPartsRows.Text = string.Concat("(", Conversions.ToString(checked(dgv.Rows.Count - 1)), ")");
			}
		}

		private void dgvParts_RowValidating(object sender, DataGridViewCellCancelEventArgs e)
		{
		}

		private void dgvTechs_DefaultValuesNeeded(object sender, DataGridViewRowEventArgs e)
		{
			bool flag = false;
			try
			{
				Monitor.Enter(this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x$Init, ref flag);
				if (this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x$Init.State == 0)
				{
					this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x$Init.State = 2;
					this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x = 1;
				}
				else if (this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x$Init.State == 2)
				{
					throw new IncompleteInitialization();
				}
			}
			finally
			{
				this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x$Init.State = 1;
				if (flag)
				{
					Monitor.Exit(this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x$Init);
				}
			}
			DataGridViewRow row = e.Row;
			row.Cells["ZZTLU_REF"].Value = this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x;
			row.Cells["ZZTL_REF"].Value = this.ThisRecord;
			row.Cells["ZZTLU_Shift"].Value = "1";
			row.Cells["zzTLU_DATE"].Value = DateTime.Today.ToShortDateString();
			row.Cells["ZZTLU_TIME"].Value = "10";
			this.$STATIC$dgvTechs_DefaultValuesNeeded$20211C128159$x = 1;
			row = null;
		}

		private void dgvTechs_RowsAdded(object sender, DataGridViewRowsAddedEventArgs e)
		{
			DataGridView dgv = (DataGridView)sender;
			string name = dgv.Name;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "dgvTechs", false) == 0)
			{
				this.lblTechRows.Text = string.Concat("(", Conversions.ToString(checked(dgv.Rows.Count - 1)), ")");
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(name, "dgvParts", false) == 0)
			{
				this.lblPartsRows.Text = string.Concat("(", Conversions.ToString(checked(dgv.Rows.Count - 1)), ")");
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

		private void editingComboBox_SelectedIndexChanged(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			ComboBox editingComboBox = sender as ComboBox;
			if (editingComboBox != null)
			{
				try
				{
					enumerator = this.tbl_Tech.Rows.GetEnumerator();
					while (enumerator.MoveNext())
					{
						object oRecord = RuntimeHelpers.GetObjectValue(enumerator.Current);
						object[] objArray = new object[] { "zztlt_name" };
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(NewLateBinding.LateIndexGet(oRecord, objArray, null).ToString(), editingComboBox.Text, false) == 0)
						{
							DataGridViewCell item = this.dgvTechs.CurrentRow.Cells["ZZTLU_Shift"];
							object[] objArray1 = new object[] { "zztlt_shift" };
							item.Value = NewLateBinding.LateIndexGet(oRecord, objArray1, null).ToString();
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
				frmRecord _frmRecord = this;
				editingComboBox.SelectedIndexChanged -= new EventHandler(_frmRecord.editingComboBox_SelectedIndexChanged);
				frmRecord _frmRecord1 = this;
				this.dgvTechs.EditingControlShowing += new DataGridViewEditingControlShowingEventHandler(_frmRecord1.dgv_EditingControlShowing);
			}
		}

		public void fillTechDropdown()
		{
			this.cbTech.HeaderText = "Tech Name";
			this.cbTech.Name = "cbTech";
			this.cbTech.MaxDropDownItems = 4;
			this.cbTech.Items.Clear();
			using (OracleConnection conn = new OracleConnection(Generals.oradb))
			{
				using (OracleCommand cmd = new OracleCommand())
				{
					try
					{
						conn.Open();
						cmd.Connection = conn;
						cmd.CommandText = "select distinct(zztlt_name), zztlt_shift from zztechlog_techs where zztlt_IsActive = 'True' order by  zztlt_name";
						cmd.CommandType = CommandType.Text;
						using (OracleDataReader dreader = cmd.ExecuteReader())
						{
							this.tbl_Tech.Load(dreader);
							if (this.tbl_Tech.Rows.Count <= 0)
							{
								MessageBox.Show("No records found! Resetting search.", "cbShowOnly.Exception:");
							}
							else
							{
								this.cbTech.DataSource = this.tbl_Tech;
								this.cbTech.DisplayMember = "zztlt_name";
							}
							dreader.Close();
						}
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						Exception ex = exception;
						MessageBox.Show(ex.Message, "Exception:frmRecord/fillTechDropdown");
						ErrorHandlingStuff.WriteLogEntry(string.Concat("Error on frmRecord/fillTechDropdown: ", ex.Message, " User:", Generals.CurUserName), "E");
						ProjectData.ClearProjectError();
					}
					conn.Close();
					conn.Dispose();
				}
			}
		}

		private void frmNew_Load(object sender, EventArgs e)
		{
			IEnumerator enumerator = null;
			this.cbState.Items.Add("Planned");
			this.cbState.Items.Add("Released");
			this.cbState.Items.Add("In-process");
			this.cbState.Items.Add("Completed");
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserAdmin, "True", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsPartsLead, "True", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsLead, "True", false) == 0)
			{
				this.cbState.Items.Add("Entered");
			}
			this.cbState.SelectedIndex = 0;
			this.cbType.SelectedIndex = 0;
			this.fillTechDropdown();
			string editMode = this.EditMode;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(editMode, "NEW", false) != 0)
			{
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(editMode, "EDIT", false) == 0)
				{
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbState.Text, "Entered", false) != 0)
					{
						this.Text = string.Concat(Generals.CurUserName, " editing record #", this.ThisRecord.ToString(), ".");
						this.btnDelete.Enabled = true;
					}
					else
					{
						this.Text = string.Concat(Generals.CurUserName, " viewing LOCKED record #", this.ThisRecord.ToString(), ".");
						this.btnDelete.Enabled = false;
						this.btnSave.Enabled = false;
					}
				}
				else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(editMode, "VIEW", false) != 0)
				{
					this.Text = "??????????ERROR??????????????";
				}
				else
				{
					this.Text = string.Concat(Generals.CurUserName, " viewing record #", this.ThisRecord.ToString(), ".");
					try
					{
						enumerator = this.Controls.GetEnumerator();
						while (enumerator.MoveNext())
						{
							Control cControl = (Control)enumerator.Current;
							if (cControl is ComboBox)
							{
								cControl.Enabled = false;
							}
							if (cControl is DataGridView)
							{
								((DataGridView)cControl).ReadOnly = true;
							}
							if (cControl is RichTextBox)
							{
								RichTextBox cRichTextbox = (RichTextBox)cControl;
								cRichTextbox.BackColor = Color.Beige;
								cRichTextbox.ForeColor = Color.DarkRed;
								cRichTextbox.ReadOnly = true;
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
					this.btnSave.Enabled = false;
				}
				if ((Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsPartsLead, "True", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserIsLead, "True", false) == 0 | Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Generals.CurUserAdmin, "True", false) == 0) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.cbState.Text, "Entered", false) != 0)
				{
					this.dgvParts.Enabled = true;
					this.btnSave.Enabled = true;
					this.cbState.Enabled = true;
					this.EditMode = "EDIT";
				}
				this.LoadDGV(string.Concat("select * from ZZTECHLOG hl where hl.zztl_ref = ", Conversions.ToString(this.ThisRecord)));
			}
			else
			{
				this.Text = string.Concat(Generals.CurUserName, " creating a new record.");
				this.BuildEmptyPartsDGV();
				this.BuildEmptyTechsDGV();
				DataGridViewRowCollection rows = this.dgvTechs.Rows;
				object[] curUserName = new object[] { "3", "1", Generals.CurUserName, Generals.CurUserShift, "10", null };
				curUserName[5] = DateTime.Today.ToShortDateString();
				rows.Add(curUserName);
				this.tsslblModInfo.Visible = false;
			}
		}

		private void frmRecord_KeyDown(object sender, KeyEventArgs e)
		{
			IEnumerator enumerator = null;
			if (e.KeyCode == Keys.A & (!e.Control || !e.Alt ? false : true))
			{
				this.Text = string.Concat(Generals.CurUserName, " OVERRIDE EDIT of record #", this.ThisRecord.ToString(), "!");
				this.EditMode = "EDIT";
				ErrorHandlingStuff.WriteLogEntry(string.Concat("OVERride edit mode work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName), "I");
				try
				{
					enumerator = this.Controls.GetEnumerator();
					while (enumerator.MoveNext())
					{
						Control cControl = (Control)enumerator.Current;
						if (cControl is TextBox | cControl is ComboBox | cControl is DataGridView | cControl is Button)
						{
							cControl.Enabled = true;
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
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.components = new System.ComponentModel.Container();
			this.btnClose = new Button();
			this.btnSave = new Button();
			this.StatusStrip1 = new StatusStrip();
			this.tsslblModInfo = new ToolStripStatusLabel();
			this.cbState = new ComboBox();
			this.cbType = new ComboBox();
			this.txtAssest = new TextBox();
			this.dgvParts = new DataGridView();
			this.cmsDGV = new System.Windows.Forms.ContextMenuStrip(this.components);
			this.DeleteRowToolStripMenuItem = new ToolStripMenuItem();
			this.dgvTechs = new DataGridView();
			this.ToolTip1 = new ToolTip(this.components);
			this.btnDelete = new Button();
			this.lblComplaint = new Label();
			this.lblCause = new Label();
			this.lblCorrection = new Label();
			this.lblTechRows = new Label();
			this.lblPartsRows = new Label();
			this.rtbCorrection = new RichTextBox();
			this.rtbCause = new RichTextBox();
			this.rtbComplaint = new RichTextBox();
			Label lblState = new Label();
			Label lblType = new Label();
			Label lblAsset = new Label();
			Label Label6 = new Label();
			Label Label7 = new Label();
			this.StatusStrip1.SuspendLayout();
			((ISupportInitialize)this.dgvParts).BeginInit();
			this.cmsDGV.SuspendLayout();
			((ISupportInitialize)this.dgvTechs).BeginInit();
			this.SuspendLayout();
			lblState.AutoSize = true;
			Point point = new Point(5, 15);
			lblState.Location = point;
			lblState.Name = "lblState";
			System.Drawing.Size size = new System.Drawing.Size(35, 13);
			lblState.Size = size;
			lblState.TabIndex = 9;
			lblState.Text = "State:";
			lblType.AutoSize = true;
			point = new Point(170, 15);
			lblType.Location = point;
			lblType.Name = "lblType";
			size = new System.Drawing.Size(34, 13);
			lblType.Size = size;
			lblType.TabIndex = 11;
			lblType.Text = "Type:";
			lblAsset.AutoSize = true;
			point = new Point(343, 15);
			lblAsset.Location = point;
			lblAsset.Name = "lblAsset";
			size = new System.Drawing.Size(36, 13);
			lblAsset.Size = size;
			lblAsset.TabIndex = 13;
			lblAsset.Text = "Asset:";
			Label6.AutoSize = true;
			point = new Point(5, 339);
			Label6.Location = point;
			Label6.Name = "Label6";
			size = new System.Drawing.Size(34, 13);
			Label6.Size = size;
			Label6.TabIndex = 21;
			Label6.Text = "Parts:";
			Label7.AutoSize = true;
			point = new Point(5, 237);
			Label7.Location = point;
			Label7.Name = "Label7";
			size = new System.Drawing.Size(40, 13);
			Label7.Size = size;
			Label7.TabIndex = 23;
			Label7.Text = "Techs:";
			this.btnClose.DialogResult = System.Windows.Forms.DialogResult.Cancel;
			Button button = this.btnClose;
			point = new Point(245, 457);
			button.Location = point;
			this.btnClose.Name = "btnClose";
			Button button1 = this.btnClose;
			size = new System.Drawing.Size(75, 23);
			button1.Size = size;
			this.btnClose.TabIndex = 8;
			this.btnClose.Text = "&Cancel";
			this.ToolTip1.SetToolTip(this.btnClose, "Close the form.");
			this.btnClose.UseVisualStyleBackColor = true;
			Button button2 = this.btnSave;
			point = new Point(148, 457);
			button2.Location = point;
			this.btnSave.Name = "btnSave";
			Button button3 = this.btnSave;
			size = new System.Drawing.Size(75, 23);
			button3.Size = size;
			this.btnSave.TabIndex = 7;
			this.btnSave.Text = "&Save";
			this.ToolTip1.SetToolTip(this.btnSave, "Save any changes.");
			this.btnSave.UseVisualStyleBackColor = true;
			ToolStripItemCollection items = this.StatusStrip1.Items;
			ToolStripItem[] deleteRowToolStripMenuItem = new ToolStripItem[] { this.tsslblModInfo };
			items.AddRange(deleteRowToolStripMenuItem);
			StatusStrip statusStrip1 = this.StatusStrip1;
			point = new Point(0, 484);
			statusStrip1.Location = point;
			this.StatusStrip1.Name = "StatusStrip1";
			StatusStrip statusStrip = this.StatusStrip1;
			size = new System.Drawing.Size(564, 22);
			statusStrip.Size = size;
			this.StatusStrip1.TabIndex = 5;
			this.StatusStrip1.Text = "StatusStrip1";
			this.tsslblModInfo.DisplayStyle = ToolStripItemDisplayStyle.Text;
			this.tsslblModInfo.ForeColor = SystemColors.HotTrack;
			this.tsslblModInfo.Name = "tsslblModInfo";
			ToolStripStatusLabel toolStripStatusLabel = this.tsslblModInfo;
			size = new System.Drawing.Size(549, 17);
			toolStripStatusLabel.Size = size;
			this.tsslblModInfo.Spring = true;
			this.tsslblModInfo.Text = "ToolStripStatusLabel1";
			this.tsslblModInfo.ToolTipText = "Last modification info";
			this.cbState.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cbState.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbState.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbState.FormattingEnabled = true;
			ComboBox comboBox = this.cbState;
			point = new Point(56, 11);
			comboBox.Location = point;
			this.cbState.Name = "cbState";
			ComboBox comboBox1 = this.cbState;
			size = new System.Drawing.Size(108, 21);
			comboBox1.Size = size;
			this.cbState.TabIndex = 10;
			this.ToolTip1.SetToolTip(this.cbState, "Work order state.");
			this.cbType.AutoCompleteMode = AutoCompleteMode.SuggestAppend;
			this.cbType.AutoCompleteSource = AutoCompleteSource.ListItems;
			this.cbType.DropDownStyle = ComboBoxStyle.DropDownList;
			this.cbType.FormattingEnabled = true;
			ComboBox.ObjectCollection objectCollections = this.cbType.Items;
			object[] objArray = new object[] { "Planned", "Unplanned", "Improvement", "Project", "Facility", "Admin", "Review", "Passdown", "System Support" };
			objectCollections.AddRange(objArray);
			ComboBox comboBox2 = this.cbType;
			point = new Point(221, 11);
			comboBox2.Location = point;
			this.cbType.Name = "cbType";
			ComboBox comboBox3 = this.cbType;
			size = new System.Drawing.Size(116, 21);
			comboBox3.Size = size;
			this.cbType.TabIndex = 12;
			this.ToolTip1.SetToolTip(this.cbType, "Type of work order.");
			TextBox textBox = this.txtAssest;
			point = new Point(397, 11);
			textBox.Location = point;
			this.txtAssest.Name = "txtAssest";
			TextBox textBox1 = this.txtAssest;
			size = new System.Drawing.Size(156, 20);
			textBox1.Size = size;
			this.txtAssest.TabIndex = 14;
			this.ToolTip1.SetToolTip(this.txtAssest, "Area of repair.");
			this.dgvParts.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.dgvParts.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			this.dgvParts.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			this.dgvParts.ContextMenuStrip = this.cmsDGV;
			DataGridView dataGridView = this.dgvParts;
			point = new Point(6, 353);
			dataGridView.Location = point;
			this.dgvParts.Name = "dgvParts";
			DataGridView dataGridView1 = this.dgvParts;
			size = new System.Drawing.Size(548, 100);
			dataGridView1.Size = size;
			this.dgvParts.TabIndex = 22;
			ToolStripItemCollection toolStripItemCollections = this.cmsDGV.Items;
			deleteRowToolStripMenuItem = new ToolStripItem[] { this.DeleteRowToolStripMenuItem };
			toolStripItemCollections.AddRange(deleteRowToolStripMenuItem);
			this.cmsDGV.Name = "cmsPartsdgv";
			System.Windows.Forms.ContextMenuStrip contextMenuStrip = this.cmsDGV;
			size = new System.Drawing.Size(134, 26);
			contextMenuStrip.Size = size;
			this.DeleteRowToolStripMenuItem.Name = "DeleteRowToolStripMenuItem";
			ToolStripMenuItem toolStripMenuItem = this.DeleteRowToolStripMenuItem;
			size = new System.Drawing.Size(133, 22);
			toolStripMenuItem.Size = size;
			this.DeleteRowToolStripMenuItem.Text = "Delete Row";
			this.dgvTechs.Anchor = AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
			this.dgvTechs.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.DisplayedCells;
			this.dgvTechs.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
			DataGridView dataGridView2 = this.dgvTechs;
			point = new Point(6, 252);
			dataGridView2.Location = point;
			this.dgvTechs.Name = "dgvTechs";
			DataGridView dataGridView3 = this.dgvTechs;
			size = new System.Drawing.Size(548, 84);
			dataGridView3.Size = size;
			this.dgvTechs.TabIndex = 24;
			this.btnDelete.Enabled = false;
			Button button4 = this.btnDelete;
			point = new Point(341, 457);
			button4.Location = point;
			this.btnDelete.Name = "btnDelete";
			Button button5 = this.btnDelete;
			size = new System.Drawing.Size(75, 23);
			button5.Size = size;
			this.btnDelete.TabIndex = 25;
			this.btnDelete.Text = "&Delete";
			this.ToolTip1.SetToolTip(this.btnDelete, "Delete the currently displayed WO.");
			this.btnDelete.UseVisualStyleBackColor = true;
			this.lblComplaint.AutoSize = true;
			Label label = this.lblComplaint;
			point = new Point(5, 39);
			label.Location = point;
			this.lblComplaint.Name = "lblComplaint";
			Label label1 = this.lblComplaint;
			size = new System.Drawing.Size(56, 13);
			label1.Size = size;
			this.lblComplaint.TabIndex = 28;
			this.lblComplaint.Text = "Complaint:";
			this.ToolTip1.SetToolTip(this.lblComplaint, "Click to copy text to clipboard");
			this.lblCause.AutoSize = true;
			Label label2 = this.lblCause;
			point = new Point(5, 107);
			label2.Location = point;
			this.lblCause.Name = "lblCause";
			Label label3 = this.lblCause;
			size = new System.Drawing.Size(40, 13);
			label3.Size = size;
			this.lblCause.TabIndex = 29;
			this.lblCause.Text = "Cause:";
			this.ToolTip1.SetToolTip(this.lblCause, "Click to copy text to clipboard");
			this.lblCorrection.AutoSize = true;
			Label label4 = this.lblCorrection;
			point = new Point(5, 172);
			label4.Location = point;
			this.lblCorrection.Name = "lblCorrection";
			Label label5 = this.lblCorrection;
			size = new System.Drawing.Size(58, 13);
			label5.Size = size;
			this.lblCorrection.TabIndex = 30;
			this.lblCorrection.Text = "Correction:";
			this.ToolTip1.SetToolTip(this.lblCorrection, "Click to copy text to clipboard");
			this.lblTechRows.AutoSize = true;
			this.lblTechRows.ForeColor = SystemColors.HotTrack;
			Label label6 = this.lblTechRows;
			point = new Point(40, 237);
			label6.Location = point;
			this.lblTechRows.Name = "lblTechRows";
			Label label7 = this.lblTechRows;
			size = new System.Drawing.Size(19, 13);
			label7.Size = size;
			this.lblTechRows.TabIndex = 26;
			this.lblTechRows.Text = "(0)";
			this.lblPartsRows.AutoSize = true;
			this.lblPartsRows.ForeColor = SystemColors.HotTrack;
			Label label8 = this.lblPartsRows;
			point = new Point(40, 339);
			label8.Location = point;
			this.lblPartsRows.Name = "lblPartsRows";
			Label label9 = this.lblPartsRows;
			size = new System.Drawing.Size(19, 13);
			label9.Size = size;
			this.lblPartsRows.TabIndex = 27;
			this.lblPartsRows.Text = "(0)";
			RichTextBox richTextBox = this.rtbCorrection;
			point = new Point(6, 186);
			richTextBox.Location = point;
			this.rtbCorrection.Name = "rtbCorrection";
			RichTextBox richTextBox1 = this.rtbCorrection;
			size = new System.Drawing.Size(545, 50);
			richTextBox1.Size = size;
			this.rtbCorrection.TabIndex = 31;
			this.rtbCorrection.Text = "";
			RichTextBox richTextBox2 = this.rtbCause;
			point = new Point(8, 121);
			richTextBox2.Location = point;
			this.rtbCause.Name = "rtbCause";
			RichTextBox richTextBox3 = this.rtbCause;
			size = new System.Drawing.Size(545, 50);
			richTextBox3.Size = size;
			this.rtbCause.TabIndex = 32;
			this.rtbCause.Text = "";
			RichTextBox richTextBox4 = this.rtbComplaint;
			point = new Point(7, 54);
			richTextBox4.Location = point;
			this.rtbComplaint.Name = "rtbComplaint";
			RichTextBox richTextBox5 = this.rtbComplaint;
			size = new System.Drawing.Size(545, 50);
			richTextBox5.Size = size;
			this.rtbComplaint.TabIndex = 33;
			this.rtbComplaint.Text = "";
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			this.CancelButton = this.btnClose;
			size = new System.Drawing.Size(564, 506);
			this.ClientSize = size;
			this.Controls.Add(this.rtbComplaint);
			this.Controls.Add(this.rtbCause);
			this.Controls.Add(this.rtbCorrection);
			this.Controls.Add(this.lblCorrection);
			this.Controls.Add(this.lblCause);
			this.Controls.Add(this.lblComplaint);
			this.Controls.Add(this.lblPartsRows);
			this.Controls.Add(this.lblTechRows);
			this.Controls.Add(this.btnDelete);
			this.Controls.Add(this.dgvTechs);
			this.Controls.Add(Label7);
			this.Controls.Add(this.dgvParts);
			this.Controls.Add(Label6);
			this.Controls.Add(this.txtAssest);
			this.Controls.Add(lblAsset);
			this.Controls.Add(lblType);
			this.Controls.Add(this.cbType);
			this.Controls.Add(lblState);
			this.Controls.Add(this.cbState);
			this.Controls.Add(this.btnClose);
			this.Controls.Add(this.btnSave);
			this.Controls.Add(this.StatusStrip1);
			this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
			this.KeyPreview = true;
			this.MaximizeBox = false;
			this.MinimizeBox = false;
			this.Name = "frmRecord";
			this.ShowInTaskbar = false;
			this.SizeGripStyle = System.Windows.Forms.SizeGripStyle.Hide;
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "Add New";
			this.TopMost = true;
			this.StatusStrip1.ResumeLayout(false);
			this.StatusStrip1.PerformLayout();
			((ISupportInitialize)this.dgvParts).EndInit();
			this.cmsDGV.ResumeLayout(false);
			((ISupportInitialize)this.dgvTechs).EndInit();
			this.ResumeLayout(false);
			this.PerformLayout();
		}

		private void lblCorrection_Click(object sender, EventArgs e)
		{
			Label lbl = (Label)sender;
			lbl.BackColor = Color.DarkOrange;
			this.Refresh();
			Clipboard.Clear();
			string text = lbl.Text;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Cause:", false) == 0)
			{
				if (Strings.Len(this.rtbCause.Text) > 0)
				{
					Clipboard.SetText(this.rtbCause.Text);
				}
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Complaint:", false) == 0)
			{
				if (Strings.Len(this.rtbComplaint.Text) > 0)
				{
					Clipboard.SetText(this.rtbComplaint.Text);
				}
			}
			else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(text, "Correction:", false) == 0)
			{
				if (Strings.Len(this.rtbCorrection.Text) > 0)
				{
					Clipboard.SetText(this.rtbCorrection.Text);
				}
			}
			Thread.Sleep(300);
			lbl.BackColor = Color.FromKnownColor(KnownColor.Control);
			this.Refresh();
		}

		public void LoadDGV(string TheSQL)
		{
			using (OracleConnection conn = new OracleConnection(Generals.oradb))
			{
				DataTable tbl_Parts = new DataTable();
				DataTable tbl_Techs = new DataTable();
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
							dreader.Read();
							if (!string.IsNullOrEmpty(dreader["zztl_state"].ToString()))
							{
								if (!this.cbState.Items.Contains(RuntimeHelpers.GetObjectValue(dreader["zztl_state"])))
								{
									this.cbState.Items.Add(RuntimeHelpers.GetObjectValue(dreader["zztl_state"]));
								}
								this.cbState.Text = Conversions.ToString(dreader["zztl_state"]);
							}
							if (!string.IsNullOrEmpty(dreader["zztl_wotype"].ToString()))
							{
								this.cbType.Text = Conversions.ToString(dreader["zztl_wotype"]);
							}
							if (!string.IsNullOrEmpty(dreader["zztl_woasset"].ToString()))
							{
								this.txtAssest.Text = Conversions.ToString(dreader["zztl_woasset"]);
							}
							if (!string.IsNullOrEmpty(dreader["zztl_wocomplaint"].ToString()))
							{
								this.rtbComplaint.Text = Conversions.ToString(dreader["zztl_wocomplaint"]);
							}
							if (!string.IsNullOrEmpty(dreader["zztl_worootcause"].ToString()))
							{
								this.rtbCause.Text = Conversions.ToString(dreader["zztl_worootcause"]);
							}
							if (!string.IsNullOrEmpty(dreader["zztl_wocorrection"].ToString()))
							{
								this.rtbCorrection.Text = Conversions.ToString(dreader["zztl_wocorrection"]);
							}
							if (!string.IsNullOrEmpty(dreader["zztl_moduser"].ToString()))
							{
								this.tsslblModInfo.Text = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject("Last Mod: ", dreader["zztl_moduser"]), " on "), dreader["zztl_moddate"]));
							}
							dreader.Close();
						}
						cmd.CommandText = string.Concat("SELECT * FROM LBS_USER.ZZTECHLOG_PARTS where zztl_ref = ", Conversions.ToString(this.ThisRecord), " order by zztlp_ref");
						using (OracleDataReader dreader = cmd.ExecuteReader())
						{
							tbl_Parts.Load(dreader);
							if (tbl_Parts.Rows.Count <= 0)
							{
								this.BuildEmptyPartsDGV();
							}
							else
							{
								this.dgvParts.DataSource = null;
								this.dgvParts.DataSource = tbl_Parts;
								this.SetUpdgvParts();
							}
							dreader.Close();
						}
						cmd.CommandText = string.Concat("SELECT * FROM LBS_USER.ZZTECHLOG_User where ZZTL_REF = ", Conversions.ToString(this.ThisRecord), " order by ZZTLU_REF");
						using (OracleDataReader dreader = cmd.ExecuteReader())
						{
							tbl_Techs.Load(dreader);
							if (tbl_Techs.Rows.Count <= 0)
							{
								this.BuildEmptyTechsDGV();
							}
							else
							{
								this.dgvTechs.DataSource = null;
								this.dgvTechs.DataSource = tbl_Techs;
								this.SetUpdgvTechs();
							}
							dreader.Close();
						}
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						Exception ex = exception;
						MessageBox.Show(ex.Message, "Exception/LoadDGV:");
						string[] str = new string[] { "Error during LoadDGV of work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName, " error:", ex.Message };
						ErrorHandlingStuff.WriteLogEntry(string.Concat(str), "E");
						ErrorHandlingStuff.WriteLogEntry(string.Concat("^^ ", cmd.CommandText, " ^^"), "E");
						ProjectData.ClearProjectError();
					}
					conn.Close();
					conn.Dispose();
				}
			}
		}

		public void RecordSaveDGV()
		{
			string[] curUserName;
			string MyNow = DateAndTime.Now.ToString("yyyy/MM/dd HH:mm:ss");
			string MySQL = "";
			using (OracleConnection conn = new OracleConnection(Generals.oradb))
			{
				DataTable tbl_Search = new DataTable();
				DataTable tbl_Parts = new DataTable();
				DataTable tbl_Techs = new DataTable();
				using (OracleCommand cmd = new OracleCommand())
				{
					try
					{
						conn.Open();
						cmd.Connection = conn;
						cmd.CommandType = CommandType.Text;
						string editMode = this.EditMode;
						if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(editMode, "NEW", false) == 0)
						{
							cmd.Parameters.Clear();
							cmd.BindByName = true;
							MySQL = "INSERT INTO ZZTECHLOG (zztl_state,zztl_wotype,zztl_woasset,zztl_wocomplaint,zztl_worootcause,zztl_wocorrection,zztl_genuser,zztl_gendate,zztl_moduser,zztl_moddate ) VALUES (";
							curUserName = new string[] { MySQL, ":State,:Type,:Assest,:Complaint,:Cause,:Correction,'", Generals.CurUserName, "',TO_DATE('", MyNow, "','yyyy/mm/dd hh24:mi:ss'),'", Generals.CurUserName, "',TO_DATE('", MyNow, "','yyyy/mm/dd hh24:mi:ss')) " };
							MySQL = string.Concat(curUserName);
							cmd.CommandText = string.Concat(MySQL, " RETURNING zztl_ref into :retPK");
							cmd.Parameters.Add("State", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(this.cbState.Text);
							cmd.Parameters.Add("Type", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(this.cbType.Text);
							cmd.Parameters.Add("Assest", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(this.txtAssest.Text);
							cmd.Parameters.Add("Complaint", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(this.rtbComplaint.Text);
							cmd.Parameters.Add("Cause", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(this.rtbCause.Text);
							cmd.Parameters.Add("Correction", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(this.rtbCorrection.Text);
							cmd.Parameters.Add("retPK", OracleDbType.Int32, ParameterDirection.ReturnValue);
							cmd.ExecuteNonQuery();
							this.ThisRecord = Convert.ToInt32(cmd.Parameters["retPK"].Value.ToString());
							this.SaveParts(this.ThisRecord);
							this.SaveTechs(this.ThisRecord);
						}
						else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(editMode, "DELETE", false) == 0)
						{
							OracleTransaction trans = conn.BeginTransaction();
							try
							{
								cmd.CommandText = string.Concat("DELETE from LBS_USER.ZZTECHLOG_PARTS where zztl_ref = ", Conversions.ToString(this.ThisRecord));
								cmd.ExecuteNonQuery();
								cmd.CommandText = string.Concat("DELETE from LBS_USER.ZZTECHLOG_User where ZZTL_REF = ", Conversions.ToString(this.ThisRecord));
								cmd.ExecuteNonQuery();
								cmd.CommandText = string.Concat("DELETE from ZZTECHLOG WHERE zztl_ref =", Conversions.ToString(this.ThisRecord));
								cmd.ExecuteNonQuery();
								trans.Commit();
							}
							catch (Exception exception)
							{
								ProjectData.SetProjectError(exception);
								Exception ex = exception;
								MessageBox.Show(ex.Message, "Exception:RecordRefreshDGV=DELETE");
								curUserName = new string[] { "Error during DELETE of work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName, " error:", ex.Message };
								ErrorHandlingStuff.WriteLogEntry(string.Concat(curUserName), "E");
								ErrorHandlingStuff.WriteLogEntry(string.Concat("^^ ", cmd.CommandText, " ^^"), "E");
								ErrorHandlingStuff.WriteLogEntry("^^ trans.ROLLBACK ^^", "E");
								trans.Rollback();
								MessageBox.Show("This record was NOT deleted do to a failed transaction in the database!\r\nPlease report this error!", "DELETE FAILED:");
								ProjectData.ClearProjectError();
							}
						}
						else if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(editMode, "EDIT", false) != 0)
						{
							MessageBox.Show("Hit case Else!", "Exception/RecordSaveDGV:");
						}
						else
						{
							cmd.Parameters.Clear();
							cmd.BindByName = true;
							MySQL = "UPDATE ZZTECHLOG set zztl_state=:State, zztl_wotype=:Type,zztl_woasset=:Assest, zztl_wocomplaint=:Complaint,zztl_worootcause=:Cause,zztl_wocorrection = ";
							curUserName = new string[] { MySQL, ":Correction,zztl_moduser='", Generals.CurUserName, "',zztl_moddate=TO_DATE('", MyNow, "','yyyy/mm/dd hh24:mi:ss') where zztl_ref =", Conversions.ToString(this.ThisRecord) };
							cmd.CommandText = string.Concat(curUserName);
							cmd.Parameters.Add("State", OracleDbType.Varchar2, ParameterDirection.Input).Value = this.cbState.Text;
							cmd.Parameters.Add("Type", OracleDbType.Varchar2, ParameterDirection.Input).Value = this.cbType.Text;
							cmd.Parameters.Add("Assest", OracleDbType.Varchar2, ParameterDirection.Input).Value = this.txtAssest.Text;
							cmd.Parameters.Add("Complaint", OracleDbType.Varchar2, ParameterDirection.Input).Value = this.rtbComplaint.Text;
							cmd.Parameters.Add("Cause", OracleDbType.Varchar2, ParameterDirection.Input).Value = this.rtbCause.Text;
							cmd.Parameters.Add("Correction", OracleDbType.Varchar2, ParameterDirection.Input).Value = this.rtbCorrection.Text;
							cmd.ExecuteNonQuery();
							ErrorHandlingStuff.WriteLogEntry(string.Concat("Edited work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName), "I");
							this.SaveParts(this.ThisRecord);
							this.SaveTechs(this.ThisRecord);
						}
					}
					catch (Exception exception1)
					{
						ProjectData.SetProjectError(exception1);
						Exception ex = exception1;
						MessageBox.Show(ex.Message, "Exception/RecordSaveDGV:.");
						curUserName = new string[] { "Error during RecordSaveDGV of work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName, " error:", ex.Message };
						ErrorHandlingStuff.WriteLogEntry(string.Concat(curUserName), "E");
						ErrorHandlingStuff.WriteLogEntry(string.Concat("^^ ", cmd.CommandText, " ^^"), "E");
						ProjectData.ClearProjectError();
					}
					conn.Close();
					conn.Dispose();
				}
			}
		}

		public void SaveParts(int TheRecord)
		{
			using (OracleConnection conn = new OracleConnection(Generals.oradb))
			{
				using (OracleCommand cmd = new OracleCommand())
				{
					cmd.Parameters.Clear();
					cmd.BindByName = true;
					conn.Open();
					cmd.Connection = conn;
					cmd.CommandType = CommandType.Text;
					OracleTransaction trans = conn.BeginTransaction();
					try
					{
						try
						{
							int rowCount = checked(this.dgvParts.RowCount - 1);
							for (int i = 0; i <= rowCount; i = checked(i + 1))
							{
								if (Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.dgvParts.Rows[i].Cells["zztlp_ref"].Value, 100, false))
								{
									if ((Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvParts.Rows[i].Cells["zzhtlp_partnumber"].Value)) || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.dgvParts.Rows[i].Cells["zztlp_qnty"].Value, 0, false) ? false : true))
									{
										cmd.CommandText = Conversions.ToString(Microsoft.VisualBasic.CompilerServices.Operators.ConcatenateObject("UPDATE ZZTECHLOG_PARTS SET zztlp_qnty = :Qnty, zzhtlp_partnumber = :PartNumber, zzhtlp_location = :Location ,zzhtlp_description = :Description WHERE zztlp_ref = ", this.dgvParts.Rows[i].Cells[0].Value));
										cmd.Parameters.Clear();
										cmd.Parameters.Add("Qnty", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(Conversions.ToString(this.dgvParts.Rows[i].Cells["zztlp_qnty"].Value));
										cmd.Parameters.Add("PartNumber", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(string.Concat(this.dgvParts.Rows[i].Cells["zzhtlp_partnumber"].Value.ToString(), ""));
										cmd.Parameters.Add("Location", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(string.Concat(this.dgvParts.Rows[i].Cells["zzhtlp_location"].Value.ToString(), ""));
										cmd.Parameters.Add("Description", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(string.Concat(this.dgvParts.Rows[i].Cells["zzhtlp_description"].Value.ToString(), ""));
										cmd.ExecuteNonQuery();
									}
								}
								else if ((Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvParts.Rows[i].Cells["zzhtlp_partnumber"].Value)) || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.dgvParts.Rows[i].Cells["zztlp_qnty"].Value, 0, false) ? false : true))
								{
									cmd.CommandText = string.Concat("INSERT INTO ZZTECHLOG_PARTS (zztl_ref,zztlp_qnty,zzhtlp_partnumber,zzhtlp_location,zzhtlp_description) VALUES (", Conversions.ToString(TheRecord), ",:Qnty,:PartNumber,:Location,:Description)");
									cmd.Parameters.Clear();
									cmd.Parameters.Add("Qnty", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(Conversions.ToString(this.dgvParts.Rows[i].Cells["zztlp_qnty"].Value));
									cmd.Parameters.Add("PartNumber", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(string.Concat(this.dgvParts.Rows[i].Cells["zzhtlp_partnumber"].Value.ToString(), ""));
									cmd.Parameters.Add("Location", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(string.Concat(this.dgvParts.Rows[i].Cells["zzhtlp_location"].Value.ToString(), ""));
									cmd.Parameters.Add("Description", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(string.Concat(this.dgvParts.Rows[i].Cells["zzhtlp_description"].Value.ToString(), ""));
									cmd.ExecuteNonQuery();
								}
							}
							trans.Commit();
							ErrorHandlingStuff.WriteLogEntry(string.Concat("Parts saved for work order # ", TheRecord.ToString(), " by User:", Generals.CurUserName), "I");
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							Exception ex = exception;
							MessageBox.Show(ex.Message, "Exception/SaveParts:");
							Debug.Write(string.Concat("++ERROR>> ", ex.Message));
							string[] str = new string[] { "Error during SaveParts of work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName, " error:", ex.Message };
							ErrorHandlingStuff.WriteLogEntry(string.Concat(str), "E");
							trans.Rollback();
							ProjectData.ClearProjectError();
						}
					}
					finally
					{
					}
				}
			}
		}

		public void SaveTechs(int TheRecord)
		{
			using (OracleConnection conn = new OracleConnection(Generals.oradb))
			{
				using (OracleCommand cmd = new OracleCommand())
				{
					cmd.Parameters.Clear();
					cmd.BindByName = true;
					conn.Open();
					cmd.Connection = conn;
					cmd.CommandText = string.Concat("DELETE FROM LBS_USER.ZZTECHLOG_User where ZZTL_REF = ", Conversions.ToString(TheRecord));
					cmd.CommandType = CommandType.Text;
					OracleTransaction trans = conn.BeginTransaction();
					try
					{
						try
						{
							cmd.ExecuteNonQuery();
							int rowCount = checked(this.dgvTechs.RowCount - 1);
							for (int i = 0; i <= rowCount; i = checked(i + 1))
							{
								if ((string.IsNullOrEmpty(Conversions.ToString(this.dgvTechs.Rows[i].Cells["cbtech"].Value)) || !Microsoft.VisualBasic.CompilerServices.Operators.ConditionalCompareObjectGreater(this.dgvTechs.Rows[i].Cells["ZZTLU_TIME"].Value, 0, false) ? false : true))
								{
									cmd.CommandText = string.Concat("INSERT INTO LBS_USER.ZZTECHLOG_User (ZZTL_REF,ZZTLU_NAME,ZZTLU_Shift,ZZTLU_TIME,ZZTLU_DATE) VALUES (", Conversions.ToString(TheRecord), ",:Tech,:Shift,:Time,:TheDate)");
									cmd.Parameters.Clear();
									cmd.Parameters.Add("Tech", OracleDbType.Varchar2, ParameterDirection.Input).Value = Strings.Trim(Conversions.ToString(this.dgvTechs.Rows[i].Cells["cbtech"].Value));
									if (Information.IsDBNull(RuntimeHelpers.GetObjectValue(this.dgvTechs.Rows[i].Cells["ZZTLU_Shift"].Value)))
									{
										cmd.Parameters.Add("Shift", OracleDbType.Int32, ParameterDirection.Input).Value = "0";
									}
									else
									{
										cmd.Parameters.Add("Shift", OracleDbType.Int32, ParameterDirection.Input).Value = Strings.Trim(Conversions.ToString(this.dgvTechs.Rows[i].Cells["ZZTLU_Shift"].Value));
									}
									cmd.Parameters.Add("Time", OracleDbType.Int32, ParameterDirection.Input).Value = Strings.Trim(Conversions.ToString(this.dgvTechs.Rows[i].Cells["ZZTLU_TIME"].Value));
									cmd.Parameters.Add("TheDate", OracleDbType.Date, ParameterDirection.Input).Value = Convert.ToDateTime(Strings.Trim(Conversions.ToString(this.dgvTechs.Rows[i].Cells["ZZTLU_Date"].Value)));
									cmd.ExecuteNonQuery();
								}
							}
							trans.Commit();
						}
						catch (Exception exception)
						{
							ProjectData.SetProjectError(exception);
							Exception ex = exception;
							MessageBox.Show(string.Concat("Record NOT saved!.\r\n", ex.Message), "Exception/SaveTechs:");
							trans.Rollback();
							string[] str = new string[] { "Error during SaveTechs of work order # ", this.ThisRecord.ToString(), " by User:", Generals.CurUserName, " error:", ex.Message };
							ErrorHandlingStuff.WriteLogEntry(string.Concat(str), "E");
							ErrorHandlingStuff.WriteLogEntry(string.Concat("^^ ", cmd.CommandText, " ^^"), "E");
							ErrorHandlingStuff.WriteLogEntry(string.Concat("** ", cmd.Parameters.ToString(), " **"), "E");
							ErrorHandlingStuff.WriteLogEntry("^^ trans.ROLLBACK ^^", "E");
							ProjectData.ClearProjectError();
						}
					}
					finally
					{
					}
				}
			}
		}

		private void SetUpdgvParts()
		{
			DataGridView dataGridView = this.dgvParts;
			dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.RowHeadersWidth = 10;
			dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridView.AutoGenerateColumns = true;
			dataGridView.Columns["zztlp_ref"].Visible = false;
			dataGridView.Columns["zztl_ref"].Visible = false;
			dataGridView.Columns["zztlp_qnty"].HeaderText = "Qnty";
			dataGridView.Columns["zztlp_qnty"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns["zztlp_qnty"].MinimumWidth = 30;
			dataGridView.Columns["zztlp_qnty"].FillWeight = 50f;
			dataGridView.Columns["zzhtlp_partnumber"].HeaderText = "Part Number";
			dataGridView.Columns["zzhtlp_partnumber"].MinimumWidth = 90;
			dataGridView.Columns["zzhtlp_partnumber"].FillWeight = 50f;
			dataGridView.Columns["zzhtlp_partnumber"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns["zzhtlp_location"].HeaderText = "Location";
			dataGridView.Columns["zzhtlp_location"].MinimumWidth = 70;
			dataGridView.Columns["zzhtlp_location"].FillWeight = 100f;
			dataGridView.Columns["zzhtlp_location"].ToolTipText = "Asile and side (left/right)";
			dataGridView.Columns["zzhtlp_description"].HeaderText = "Description";
			dataGridView.Columns["zzhtlp_description"].MinimumWidth = 80;
			dataGridView.Columns["zzhtlp_description"].FillWeight = 400f;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.EditMode, "VIEW", false) == 0)
			{
				dataGridView.AllowUserToDeleteRows = false;
				dataGridView.AllowUserToAddRows = false;
				dataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
			}
			else
			{
				dataGridView.AllowUserToDeleteRows = true;
				dataGridView.AllowUserToAddRows = true;
				dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
			}
			dataGridView = null;
		}

		private void SetUpdgvTechs()
		{
			DataGridView dataGridView = this.dgvTechs;
			dataGridView.SelectionMode = DataGridViewSelectionMode.CellSelect;
			dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
			dataGridView.RowHeadersWidth = 10;
			dataGridView.Columns["zzTLU_REF"].Visible = false;
			dataGridView.Columns["zzTL_REF"].Visible = false;
			dataGridView.Columns["zzTLU_NAME"].Visible = false;
			dataGridView.Columns.Insert(0, this.cbTech);
			dataGridView.Columns["cbtech"].DataPropertyName = "ZZTLU_NAME";
			dataGridView.Columns["cbTech"].MinimumWidth = 90;
			dataGridView.Columns["cbTech"].FillWeight = 100f;
			dataGridView.Columns["ZZTLU_Shift"].HeaderText = "Shift";
			dataGridView.Columns["ZZTLU_Shift"].ReadOnly = true;
			dataGridView.Columns["ZZTLU_Shift"].DisplayIndex = 4;
			dataGridView.Columns["ZZTLU_Shift"].MinimumWidth = 30;
			dataGridView.Columns["ZZTLU_Shift"].FillWeight = 50f;
			dataGridView.Columns["ZZTLU_Shift"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;
			dataGridView.Columns["ZZTLU_Shift"].ToolTipText = "Shift this user is assigned to.";
			dataGridView.Columns["zzTLU_DATE"].HeaderText = "Date";
			dataGridView.Columns["zzTLU_DATE"].MinimumWidth = 90;
			dataGridView.Columns["zzTLU_DATE"].FillWeight = 100f;
			dataGridView.Columns["zzTLU_DATE"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			dataGridView.Columns["zzTLU_TIME"].HeaderText = "Minutes";
			dataGridView.Columns["zzTLU_TIME"].MinimumWidth = 90;
			dataGridView.Columns["zzTLU_TIME"].FillWeight = 100f;
			dataGridView.Columns["zzTLU_TIME"].DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleRight;
			if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(this.EditMode, "VIEW", false) == 0)
			{
				dataGridView.AllowUserToDeleteRows = false;
				dataGridView.AllowUserToAddRows = false;
				dataGridView.EditMode = DataGridViewEditMode.EditOnKeystroke;
			}
			else
			{
				dataGridView.AllowUserToDeleteRows = true;
				dataGridView.AllowUserToAddRows = true;
				dataGridView.EditMode = DataGridViewEditMode.EditOnEnter;
			}
			dataGridView.AutoSizeRowsMode = DataGridViewAutoSizeRowsMode.DisplayedCells;
			dataGridView = null;
		}

		private void tb_KeyPress(object sender, KeyPressEventArgs e)
		{
			if (!char.IsDigit(e.KeyChar) & Microsoft.VisualBasic.CompilerServices.Operators.CompareString(Conversions.ToString(e.KeyChar), "\b", false) != 0)
			{
				e.Handled = true;
			}
		}
	}
}