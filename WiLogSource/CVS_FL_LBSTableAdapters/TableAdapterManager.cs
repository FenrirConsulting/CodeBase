using Microsoft.VisualBasic.CompilerServices;
using Oracle.DataAccess.Client;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Data.Common;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using WiLog;

namespace WiLog.CVS_FL_LBSTableAdapters
{
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.TableAdapterManager")]
	[ToolboxItem(true)]
	public class TableAdapterManager : Component
	{
		private static List<WeakReference> __ENCList;

		private TableAdapterManager.UpdateOrderOption _updateOrder;

		private WiLog.CVS_FL_LBSTableAdapters.ZZTECHLOGTableAdapter _zZTECHLOGTableAdapter;

		private WiLog.CVS_FL_LBSTableAdapters.ZZTECHLOG_USERTableAdapter _zZTECHLOG_USERTableAdapter;

		private WiLog.CVS_FL_LBSTableAdapters.ZZTECHLOG_PARTSTableAdapter _zZTECHLOG_PARTSTableAdapter;

		private bool _backupDataSetBeforeUpdate;

		private IDbConnection _connection;

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool BackupDataSetBeforeUpdate
		{
			get
			{
				return this._backupDataSetBeforeUpdate;
			}
			set
			{
				this._backupDataSetBeforeUpdate = value;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public IDbConnection Connection
		{
			get
			{
				IDbConnection Connection;
				if (this._connection != null)
				{
					Connection = this._connection;
				}
				else if ((this._zZTECHLOGTableAdapter == null || this._zZTECHLOGTableAdapter.Connection == null ? false : true))
				{
					Connection = this._zZTECHLOGTableAdapter.Connection;
				}
				else if ((this._zZTECHLOG_USERTableAdapter == null || this._zZTECHLOG_USERTableAdapter.Connection == null ? false : true))
				{
					Connection = this._zZTECHLOG_USERTableAdapter.Connection;
				}
				else if ((this._zZTECHLOG_PARTSTableAdapter == null || this._zZTECHLOG_PARTSTableAdapter.Connection == null ? true : false))
				{
					Connection = null;
				}
				else
				{
					Connection = this._zZTECHLOG_PARTSTableAdapter.Connection;
				}
				return Connection;
			}
			set
			{
				this._connection = value;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public int TableAdapterInstanceCount
		{
			get
			{
				int count = 0;
				if (this._zZTECHLOGTableAdapter != null)
				{
					count = checked(count + 1);
				}
				if (this._zZTECHLOG_USERTableAdapter != null)
				{
					count = checked(count + 1);
				}
				if (this._zZTECHLOG_PARTSTableAdapter != null)
				{
					count = checked(count + 1);
				}
				return count;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public TableAdapterManager.UpdateOrderOption UpdateOrder
		{
			get
			{
				return this._updateOrder;
			}
			set
			{
				this._updateOrder = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public WiLog.CVS_FL_LBSTableAdapters.ZZTECHLOG_PARTSTableAdapter ZZTECHLOG_PARTSTableAdapter
		{
			get
			{
				return this._zZTECHLOG_PARTSTableAdapter;
			}
			set
			{
				this._zZTECHLOG_PARTSTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public WiLog.CVS_FL_LBSTableAdapters.ZZTECHLOG_USERTableAdapter ZZTECHLOG_USERTableAdapter
		{
			get
			{
				return this._zZTECHLOG_USERTableAdapter;
			}
			set
			{
				this._zZTECHLOG_USERTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		[Editor("Microsoft.VSDesigner.DataSource.Design.TableAdapterManagerPropertyEditor, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a", "System.Drawing.Design.UITypeEditor")]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public WiLog.CVS_FL_LBSTableAdapters.ZZTECHLOGTableAdapter ZZTECHLOGTableAdapter
		{
			get
			{
				return this._zZTECHLOGTableAdapter;
			}
			set
			{
				this._zZTECHLOGTableAdapter = value;
			}
		}

		[DebuggerNonUserCode]
		static TableAdapterManager()
		{
			TableAdapterManager.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public TableAdapterManager()
		{
			TableAdapterManager.__ENCAddToList(this);
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (TableAdapterManager.__ENCList)
			{
				if (TableAdapterManager.__ENCList.Count == TableAdapterManager.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(TableAdapterManager.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (TableAdapterManager.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								TableAdapterManager.__ENCList[item] = TableAdapterManager.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					TableAdapterManager.__ENCList.RemoveRange(item, checked(TableAdapterManager.__ENCList.Count - item));
					TableAdapterManager.__ENCList.Capacity = TableAdapterManager.__ENCList.Count;
				}
				TableAdapterManager.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private DataRow[] GetRealUpdatedRows(DataRow[] updatedRows, List<DataRow> allAddedRows)
		{
			DataRow[] GetRealUpdatedRows;
			if ((updatedRows == null || checked((int)updatedRows.Length) < 1 ? true : false))
			{
				GetRealUpdatedRows = updatedRows;
			}
			else if ((allAddedRows == null || allAddedRows.Count < 1 ? false : true))
			{
				List<DataRow> realUpdatedRows = new List<DataRow>();
				for (int i = 0; i < checked((int)updatedRows.Length); i = checked(i + 1))
				{
					DataRow row = updatedRows[i];
					if (!allAddedRows.Contains(row))
					{
						realUpdatedRows.Add(row);
					}
				}
				GetRealUpdatedRows = realUpdatedRows.ToArray();
			}
			else
			{
				GetRealUpdatedRows = updatedRows;
			}
			return GetRealUpdatedRows;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual bool MatchTableAdapterConnection(IDbConnection inputConnection)
		{
			bool MatchTableAdapterConnection;
			if (this._connection != null)
			{
				MatchTableAdapterConnection = true;
			}
			else if ((this.Connection == null || inputConnection == null ? false : true))
			{
				MatchTableAdapterConnection = (!string.Equals(this.Connection.ConnectionString, inputConnection.ConnectionString, StringComparison.Ordinal) ? false : true);
			}
			else
			{
				MatchTableAdapterConnection = true;
			}
			return MatchTableAdapterConnection;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected virtual void SortSelfReferenceRows(DataRow[] rows, DataRelation relation, bool childFirst)
		{
			Array.Sort<DataRow>(rows, new TableAdapterManager.SelfReferenceComparer(relation, childFirst));
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public virtual int UpdateAll(CVS_FL_LBS dataSet)
		{
			int UpdateAll;
			if (dataSet == null)
			{
				throw new ArgumentNullException("dataSet");
			}
			if (dataSet.HasChanges())
			{
				if ((this._zZTECHLOGTableAdapter == null || this.MatchTableAdapterConnection(this._zZTECHLOGTableAdapter.Connection) ? false : true))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._zZTECHLOG_USERTableAdapter == null || this.MatchTableAdapterConnection(this._zZTECHLOG_USERTableAdapter.Connection) ? false : true))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				if ((this._zZTECHLOG_PARTSTableAdapter == null || this.MatchTableAdapterConnection(this._zZTECHLOG_PARTSTableAdapter.Connection) ? false : true))
				{
					throw new ArgumentException("All TableAdapters managed by a TableAdapterManager must use the same connection string.");
				}
				IDbConnection workConnection = this.Connection;
				if (workConnection == null)
				{
					throw new ApplicationException("TableAdapterManager contains no connection information. Set each TableAdapterManager TableAdapter property to a valid TableAdapter instance.");
				}
				bool workConnOpened = false;
				if ((workConnection.State & ConnectionState.Broken) == ConnectionState.Broken)
				{
					workConnection.Close();
				}
				if (workConnection.State == ConnectionState.Closed)
				{
					workConnection.Open();
					workConnOpened = true;
				}
				IDbTransaction workTransaction = workConnection.BeginTransaction();
				if (workTransaction == null)
				{
					throw new ApplicationException("The transaction cannot begin. The current data connection does not support transactions or the current state is not allowing the transaction to begin.");
				}
				List<DataRow> allChangedRows = new List<DataRow>();
				List<DataRow> allAddedRows = new List<DataRow>();
				List<DataAdapter> adaptersWithAcceptChangesDuringUpdate = new List<DataAdapter>();
				Dictionary<object, IDbConnection> revertConnections = new Dictionary<object, IDbConnection>();
				int result = 0;
				DataSet backupDataSet = null;
				if (this.BackupDataSetBeforeUpdate)
				{
					backupDataSet = new DataSet();
					backupDataSet.Merge(dataSet);
				}
				try
				{
					try
					{
						if (this._zZTECHLOGTableAdapter != null)
						{
							revertConnections.Add(this._zZTECHLOGTableAdapter, this._zZTECHLOGTableAdapter.Connection);
							this._zZTECHLOGTableAdapter.Connection = (OracleConnection)workConnection;
							this._zZTECHLOGTableAdapter.Transaction = (OracleTransaction)workTransaction;
							if (this._zZTECHLOGTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._zZTECHLOGTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								adaptersWithAcceptChangesDuringUpdate.Add(this._zZTECHLOGTableAdapter.Adapter);
							}
						}
						if (this._zZTECHLOG_USERTableAdapter != null)
						{
							revertConnections.Add(this._zZTECHLOG_USERTableAdapter, this._zZTECHLOG_USERTableAdapter.Connection);
							this._zZTECHLOG_USERTableAdapter.Connection = (OracleConnection)workConnection;
							this._zZTECHLOG_USERTableAdapter.Transaction = (OracleTransaction)workTransaction;
							if (this._zZTECHLOG_USERTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._zZTECHLOG_USERTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								adaptersWithAcceptChangesDuringUpdate.Add(this._zZTECHLOG_USERTableAdapter.Adapter);
							}
						}
						if (this._zZTECHLOG_PARTSTableAdapter != null)
						{
							revertConnections.Add(this._zZTECHLOG_PARTSTableAdapter, this._zZTECHLOG_PARTSTableAdapter.Connection);
							this._zZTECHLOG_PARTSTableAdapter.Connection = (OracleConnection)workConnection;
							this._zZTECHLOG_PARTSTableAdapter.Transaction = (OracleTransaction)workTransaction;
							if (this._zZTECHLOG_PARTSTableAdapter.Adapter.AcceptChangesDuringUpdate)
							{
								this._zZTECHLOG_PARTSTableAdapter.Adapter.AcceptChangesDuringUpdate = false;
								adaptersWithAcceptChangesDuringUpdate.Add(this._zZTECHLOG_PARTSTableAdapter.Adapter);
							}
						}
						if (this.UpdateOrder != TableAdapterManager.UpdateOrderOption.UpdateInsertDelete)
						{
							result = checked(result + this.UpdateInsertedRows(dataSet, allAddedRows));
							result = checked(result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
						}
						else
						{
							result = checked(result + this.UpdateUpdatedRows(dataSet, allChangedRows, allAddedRows));
							result = checked(result + this.UpdateInsertedRows(dataSet, allAddedRows));
						}
						result = checked(result + this.UpdateDeletedRows(dataSet, allChangedRows));
						workTransaction.Commit();
						if (0 < allAddedRows.Count)
						{
							DataRow[] rows = new DataRow[checked(checked(allAddedRows.Count - 1) + 1)];
							allAddedRows.CopyTo(rows);
							for (int i = 0; i < checked((int)rows.Length); i = checked(i + 1))
							{
								rows[i].AcceptChanges();
							}
						}
						if (0 < allChangedRows.Count)
						{
							DataRow[] rows = new DataRow[checked(checked(allChangedRows.Count - 1) + 1)];
							allChangedRows.CopyTo(rows);
							for (int i = 0; i < checked((int)rows.Length); i = checked(i + 1))
							{
								rows[i].AcceptChanges();
							}
						}
					}
					catch (Exception exception)
					{
						ProjectData.SetProjectError(exception);
						Exception ex = exception;
						workTransaction.Rollback();
						if (this.BackupDataSetBeforeUpdate)
						{
							Debug.Assert(backupDataSet != null);
							dataSet.Clear();
							dataSet.Merge(backupDataSet);
						}
						else if (0 < allAddedRows.Count)
						{
							DataRow[] rows = new DataRow[checked(checked(allAddedRows.Count - 1) + 1)];
							allAddedRows.CopyTo(rows);
							for (int i = 0; i < checked((int)rows.Length); i = checked(i + 1))
							{
								DataRow row = rows[i];
								row.AcceptChanges();
								row.SetAdded();
							}
						}
						throw ex;
					}
				}
				finally
				{
					if (workConnOpened)
					{
						workConnection.Close();
					}
					if (this._zZTECHLOGTableAdapter != null)
					{
						this._zZTECHLOGTableAdapter.Connection = (OracleConnection)revertConnections[this._zZTECHLOGTableAdapter];
						this._zZTECHLOGTableAdapter.Transaction = null;
					}
					if (this._zZTECHLOG_USERTableAdapter != null)
					{
						this._zZTECHLOG_USERTableAdapter.Connection = (OracleConnection)revertConnections[this._zZTECHLOG_USERTableAdapter];
						this._zZTECHLOG_USERTableAdapter.Transaction = null;
					}
					if (this._zZTECHLOG_PARTSTableAdapter != null)
					{
						this._zZTECHLOG_PARTSTableAdapter.Connection = (OracleConnection)revertConnections[this._zZTECHLOG_PARTSTableAdapter];
						this._zZTECHLOG_PARTSTableAdapter.Transaction = null;
					}
					if (0 < adaptersWithAcceptChangesDuringUpdate.Count)
					{
						DataAdapter[] adapters = new DataAdapter[checked(checked(adaptersWithAcceptChangesDuringUpdate.Count - 1) + 1)];
						adaptersWithAcceptChangesDuringUpdate.CopyTo(adapters);
						for (int i = 0; i < checked((int)adapters.Length); i = checked(i + 1))
						{
							adapters[i].AcceptChangesDuringUpdate = true;
						}
					}
				}
				UpdateAll = result;
			}
			else
			{
				UpdateAll = 0;
			}
			return UpdateAll;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateDeletedRows(CVS_FL_LBS dataSet, List<DataRow> allChangedRows)
		{
			int result = 0;
			if (this._zZTECHLOG_USERTableAdapter != null)
			{
				DataRow[] deletedRows = dataSet.ZZTECHLOG_USER.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows == null || 0 >= checked((int)deletedRows.Length) ? false : true))
				{
					result = checked(result + this._zZTECHLOG_USERTableAdapter.Update(deletedRows));
					allChangedRows.AddRange(deletedRows);
				}
			}
			if (this._zZTECHLOGTableAdapter != null)
			{
				DataRow[] deletedRows = dataSet.ZZTECHLOG.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows == null || 0 >= checked((int)deletedRows.Length) ? false : true))
				{
					result = checked(result + this._zZTECHLOGTableAdapter.Update(deletedRows));
					allChangedRows.AddRange(deletedRows);
				}
			}
			if (this._zZTECHLOG_PARTSTableAdapter != null)
			{
				DataRow[] deletedRows = dataSet.ZZTECHLOG_PARTS.Select(null, null, DataViewRowState.Deleted);
				if ((deletedRows == null || 0 >= checked((int)deletedRows.Length) ? false : true))
				{
					result = checked(result + this._zZTECHLOG_PARTSTableAdapter.Update(deletedRows));
					allChangedRows.AddRange(deletedRows);
				}
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateInsertedRows(CVS_FL_LBS dataSet, List<DataRow> allAddedRows)
		{
			int result = 0;
			if (this._zZTECHLOG_PARTSTableAdapter != null)
			{
				DataRow[] addedRows = dataSet.ZZTECHLOG_PARTS.Select(null, null, DataViewRowState.Added);
				if ((addedRows == null || 0 >= checked((int)addedRows.Length) ? false : true))
				{
					result = checked(result + this._zZTECHLOG_PARTSTableAdapter.Update(addedRows));
					allAddedRows.AddRange(addedRows);
				}
			}
			if (this._zZTECHLOGTableAdapter != null)
			{
				DataRow[] addedRows = dataSet.ZZTECHLOG.Select(null, null, DataViewRowState.Added);
				if ((addedRows == null || 0 >= checked((int)addedRows.Length) ? false : true))
				{
					result = checked(result + this._zZTECHLOGTableAdapter.Update(addedRows));
					allAddedRows.AddRange(addedRows);
				}
			}
			if (this._zZTECHLOG_USERTableAdapter != null)
			{
				DataRow[] addedRows = dataSet.ZZTECHLOG_USER.Select(null, null, DataViewRowState.Added);
				if ((addedRows == null || 0 >= checked((int)addedRows.Length) ? false : true))
				{
					result = checked(result + this._zZTECHLOG_USERTableAdapter.Update(addedRows));
					allAddedRows.AddRange(addedRows);
				}
			}
			return result;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private int UpdateUpdatedRows(CVS_FL_LBS dataSet, List<DataRow> allChangedRows, List<DataRow> allAddedRows)
		{
			int result = 0;
			if (this._zZTECHLOG_PARTSTableAdapter != null)
			{
				DataRow[] updatedRows = dataSet.ZZTECHLOG_PARTS.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
				if ((updatedRows == null || 0 >= checked((int)updatedRows.Length) ? false : true))
				{
					result = checked(result + this._zZTECHLOG_PARTSTableAdapter.Update(updatedRows));
					allChangedRows.AddRange(updatedRows);
				}
			}
			if (this._zZTECHLOGTableAdapter != null)
			{
				DataRow[] updatedRows = dataSet.ZZTECHLOG.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
				if ((updatedRows == null || 0 >= checked((int)updatedRows.Length) ? false : true))
				{
					result = checked(result + this._zZTECHLOGTableAdapter.Update(updatedRows));
					allChangedRows.AddRange(updatedRows);
				}
			}
			if (this._zZTECHLOG_USERTableAdapter != null)
			{
				DataRow[] updatedRows = dataSet.ZZTECHLOG_USER.Select(null, null, DataViewRowState.ModifiedCurrent);
				updatedRows = this.GetRealUpdatedRows(updatedRows, allAddedRows);
				if ((updatedRows == null || 0 >= checked((int)updatedRows.Length) ? false : true))
				{
					result = checked(result + this._zZTECHLOG_USERTableAdapter.Update(updatedRows));
					allChangedRows.AddRange(updatedRows);
				}
			}
			return result;
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private class SelfReferenceComparer : IComparer<DataRow>
		{
			private DataRelation _relation;

			private int _childFirst;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal SelfReferenceComparer(DataRelation relation, bool childFirst)
			{
				this._relation = relation;
				if (!childFirst)
				{
					this._childFirst = 1;
				}
				else
				{
					this._childFirst = -1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Compare(DataRow row1, DataRow row2)
			{
				int Compare;
				if (object.ReferenceEquals(row1, row2))
				{
					Compare = 0;
				}
				else if (row1 == null)
				{
					Compare = -1;
				}
				else if (row2 != null)
				{
					int distance1 = 0;
					DataRow root1 = this.GetRoot(row1, ref distance1);
					int distance2 = 0;
					DataRow root2 = this.GetRoot(row2, ref distance2);
					if (!object.ReferenceEquals(root1, root2))
					{
						Debug.Assert((root1.Table == null || root2.Table == null ? false : true));
						Compare = (root1.Table.Rows.IndexOf(root1) >= root2.Table.Rows.IndexOf(root2) ? 1 : -1);
					}
					else
					{
						Compare = checked(this._childFirst * distance1.CompareTo(distance2));
					}
				}
				else
				{
					Compare = 1;
				}
				return Compare;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private DataRow GetRoot(DataRow row, ref int distance)
			{
				Debug.Assert(row != null);
				DataRow root = row;
				distance = 0;
				IDictionary<DataRow, DataRow> traversedRows = new Dictionary<DataRow, DataRow>();
				traversedRows[row] = row;
				DataRow parent = row.GetParentRow(this._relation, DataRowVersion.Default);
				while (true)
				{
					if ((parent == null || traversedRows.ContainsKey(parent) ? true : false))
					{
						break;
					}
					distance = checked(distance + 1);
					root = parent;
					traversedRows[parent] = parent;
					parent = parent.GetParentRow(this._relation, DataRowVersion.Default);
				}
				if (distance == 0)
				{
					traversedRows.Clear();
					traversedRows[row] = row;
					parent = row.GetParentRow(this._relation, DataRowVersion.Original);
					while (true)
					{
						if ((parent == null || traversedRows.ContainsKey(parent) ? true : false))
						{
							break;
						}
						distance = checked(distance + 1);
						root = parent;
						traversedRows[parent] = parent;
						parent = parent.GetParentRow(this._relation, DataRowVersion.Original);
					}
				}
				return root;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public enum UpdateOrderOption
		{
			InsertUpdateDelete,
			UpdateInsertDelete
		}
	}
}