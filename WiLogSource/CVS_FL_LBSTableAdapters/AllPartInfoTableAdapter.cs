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
	[DataObject(true)]
	[Designer("Microsoft.VSDesigner.DataSource.Design.TableAdapterDesigner, Microsoft.VSDesigner, Version=10.0.0.0, Culture=neutral, PublicKeyToken=b03f5f7f11d50a3a")]
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.TableAdapter")]
	[ToolboxItem(true)]
	public class AllPartInfoTableAdapter : Component
	{
		private static List<WeakReference> __ENCList;

		[AccessedThroughProperty("_adapter")]
		private OracleDataAdapter __adapter;

		private OracleConnection _connection;

		private OracleTransaction _transaction;

		private OracleCommand[] _commandCollection;

		private bool _clearBeforeFill;

		private virtual OracleDataAdapter _adapter
		{
			[DebuggerNonUserCode]
			get
			{
				return this.__adapter;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this.__adapter = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected internal OracleDataAdapter Adapter
		{
			get
			{
				if (this._adapter == null)
				{
					this.InitAdapter();
				}
				return this._adapter;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public bool ClearBeforeFill
		{
			get
			{
				return this._clearBeforeFill;
			}
			set
			{
				this._clearBeforeFill = value;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected OracleCommand[] CommandCollection
		{
			get
			{
				if (this._commandCollection == null)
				{
					this.InitCommandCollection();
				}
				return this._commandCollection;
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal OracleConnection Connection
		{
			get
			{
				if (this._connection == null)
				{
					this.InitConnection();
				}
				return this._connection;
			}
			set
			{
				this._connection = value;
				if (this.Adapter.InsertCommand != null)
				{
					this.Adapter.InsertCommand.Connection = value;
				}
				if (this.Adapter.DeleteCommand != null)
				{
					this.Adapter.DeleteCommand.Connection = value;
				}
				if (this.Adapter.UpdateCommand != null)
				{
					this.Adapter.UpdateCommand.Connection = value;
				}
				for (int i = 0; i < checked((int)this.CommandCollection.Length); i = checked(i + 1))
				{
					if (this.CommandCollection[i] != null)
					{
						this.CommandCollection[i].Connection = value;
					}
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal OracleTransaction Transaction
		{
			get
			{
				return this._transaction;
			}
			set
			{
				this._transaction = value;
				for (int i = 0; i < checked((int)this.CommandCollection.Length); i = checked(i + 1))
				{
					this.CommandCollection[i].Transaction = this._transaction;
				}
				if ((this.Adapter == null || this.Adapter.DeleteCommand == null ? false : true))
				{
					this.Adapter.DeleteCommand.Transaction = this._transaction;
				}
				if ((this.Adapter == null || this.Adapter.InsertCommand == null ? false : true))
				{
					this.Adapter.InsertCommand.Transaction = this._transaction;
				}
				if ((this.Adapter == null || this.Adapter.UpdateCommand == null ? false : true))
				{
					this.Adapter.UpdateCommand.Transaction = this._transaction;
				}
			}
		}

		[DebuggerNonUserCode]
		static AllPartInfoTableAdapter()
		{
			AllPartInfoTableAdapter.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public AllPartInfoTableAdapter()
		{
			AllPartInfoTableAdapter.__ENCAddToList(this);
			this.ClearBeforeFill = true;
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (AllPartInfoTableAdapter.__ENCList)
			{
				if (AllPartInfoTableAdapter.__ENCList.Count == AllPartInfoTableAdapter.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(AllPartInfoTableAdapter.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (AllPartInfoTableAdapter.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								AllPartInfoTableAdapter.__ENCList[item] = AllPartInfoTableAdapter.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					AllPartInfoTableAdapter.__ENCList.RemoveRange(item, checked(AllPartInfoTableAdapter.__ENCList.Count - item));
					AllPartInfoTableAdapter.__ENCList.Capacity = AllPartInfoTableAdapter.__ENCList.Count;
				}
				AllPartInfoTableAdapter.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(CVS_FL_LBS.AllPartInfoDataTable dataTable)
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			if (this.ClearBeforeFill)
			{
				dataTable.Clear();
			}
			return this.Adapter.Fill(dataTable);
		}

		[DataObjectMethod(DataObjectMethodType.Select, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual CVS_FL_LBS.AllPartInfoDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			CVS_FL_LBS.AllPartInfoDataTable dataTable = new CVS_FL_LBS.AllPartInfoDataTable();
			this.Adapter.Fill(dataTable);
			return dataTable;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitAdapter()
		{
			this._adapter = new OracleDataAdapter();
			DataTableMapping tableMapping = new DataTableMapping()
			{
				SourceTable = "Table",
				DataSetTable = "AllPartInfo"
			};
			tableMapping.ColumnMappings.Add("ZZTLP_REF", "ZZTLP_REF");
			tableMapping.ColumnMappings.Add("ZZTL_REF", "ZZTL_REF");
			tableMapping.ColumnMappings.Add("ZZTLP_QNTY", "ZZTLP_QNTY");
			tableMapping.ColumnMappings.Add("ZZHTLP_PARTNUMBER", "ZZHTLP_PARTNUMBER");
			tableMapping.ColumnMappings.Add("ZZHTLP_LOCATION", "ZZHTLP_LOCATION");
			tableMapping.ColumnMappings.Add("ZZHTLP_DESCRIPTION", "ZZHTLP_DESCRIPTION");
			tableMapping.ColumnMappings.Add("ZZTL_REF1", "ZZTL_REF1");
			tableMapping.ColumnMappings.Add("ZZTL_STATE", "ZZTL_STATE");
			tableMapping.ColumnMappings.Add("ZZTL_WOTYPE", "ZZTL_WOTYPE");
			tableMapping.ColumnMappings.Add("ZZTL_WOASSET", "ZZTL_WOASSET");
			tableMapping.ColumnMappings.Add("ZZTL_WOCOMPLAINT", "ZZTL_WOCOMPLAINT");
			tableMapping.ColumnMappings.Add("ZZTL_WOROOTCAUSE", "ZZTL_WOROOTCAUSE");
			tableMapping.ColumnMappings.Add("ZZTL_WOCORRECTION", "ZZTL_WOCORRECTION");
			tableMapping.ColumnMappings.Add("ZZTL_GENUSER", "ZZTL_GENUSER");
			tableMapping.ColumnMappings.Add("ZZTL_GENDATE", "ZZTL_GENDATE");
			tableMapping.ColumnMappings.Add("ZZTL_MODUSER", "ZZTL_MODUSER");
			tableMapping.ColumnMappings.Add("ZZTL_MODDATE", "ZZTL_MODDATE");
			this._adapter.TableMappings.Add((object)tableMapping);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new OracleCommand[] { new OracleCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "Select * From ZZTECHLOG_PARTS,ZZTECHLOG where ZZTECHLOG.ZZTL_REF = ZZTECHLOG_PARTS.ZZTL_REF";
			this._commandCollection[0].CommandType = CommandType.Text;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitConnection()
		{
			this._connection = new OracleConnection()
			{
				ConnectionString = "DATA SOURCE=CVSFL01;PASSWORD=lbs;PERSIST SECURITY INFO=True;USER ID=LBS_USER"
			};
		}
	}
}