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
	public class ZZTECHLOGTableAdapter : Component
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
		static ZZTECHLOGTableAdapter()
		{
			ZZTECHLOGTableAdapter.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ZZTECHLOGTableAdapter()
		{
			ZZTECHLOGTableAdapter.__ENCAddToList(this);
			this.ClearBeforeFill = true;
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (ZZTECHLOGTableAdapter.__ENCList)
			{
				if (ZZTECHLOGTableAdapter.__ENCList.Count == ZZTECHLOGTableAdapter.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(ZZTECHLOGTableAdapter.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (ZZTECHLOGTableAdapter.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								ZZTECHLOGTableAdapter.__ENCList[item] = ZZTECHLOGTableAdapter.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					ZZTECHLOGTableAdapter.__ENCList.RemoveRange(item, checked(ZZTECHLOGTableAdapter.__ENCList.Count - item));
					ZZTECHLOGTableAdapter.__ENCList.Capacity = ZZTECHLOGTableAdapter.__ENCList.Count;
				}
				ZZTECHLOGTableAdapter.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(CVS_FL_LBS.ZZTECHLOGDataTable dataTable)
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
		public virtual CVS_FL_LBS.ZZTECHLOGDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			CVS_FL_LBS.ZZTECHLOGDataTable dataTable = new CVS_FL_LBS.ZZTECHLOGDataTable();
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
				DataSetTable = "ZZTECHLOG"
			};
			tableMapping.ColumnMappings.Add("zztl_ref", "zztl_ref");
			tableMapping.ColumnMappings.Add("zztl_state", "zztl_state");
			tableMapping.ColumnMappings.Add("zztl_wotype", "zztl_wotype");
			tableMapping.ColumnMappings.Add("zztl_woasset", "zztl_woasset");
			tableMapping.ColumnMappings.Add("zztl_wocomplaint", "zztl_wocomplaint");
			tableMapping.ColumnMappings.Add("zztl_worootcause", "zztl_worootcause");
			tableMapping.ColumnMappings.Add("zztl_wocorrection", "zztl_wocorrection");
			tableMapping.ColumnMappings.Add("zztl_genuser", "zztl_genuser");
			tableMapping.ColumnMappings.Add("zztl_gendate", "zztl_gendate");
			tableMapping.ColumnMappings.Add("zztl_moduser", "zztl_moduser");
			tableMapping.ColumnMappings.Add("zztl_moddate", "zztl_moddate");
			this._adapter.TableMappings.Add((object)tableMapping);
			this._adapter.InsertCommand = new OracleCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO \"LBS_USER\".\"ZZTECHLOG\" (\"zztl_ref\", \"zztl_state\", \"zztl_wotype\", \"zztl_woasset\", \"zztl_wocomplaint\", \"zztl_worootcause\", \"zztl_wocorrection\", \"zztl_genuser\", \"zztl_gendate\", \"zztl_moduser\", \"zztl_moddate\") VALUES (:zztl_ref, :zztl_state, :zztl_wotype, :zztl_woasset, :zztl_wocomplaint, :zztl_worootcause, :zztl_wocorrection, :zztl_genuser, :zztl_gendate, :zztl_moduser, :zztl_moddate)",
				CommandType = CommandType.Text
			};
			OracleParameter param = new OracleParameter()
			{
				ParameterName = "zztl_ref",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "zztl_ref"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_state",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "zztl_state"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_wotype",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "zztl_wotype"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_woasset",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "zztl_woasset"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_wocomplaint",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "zztl_wocomplaint"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_worootcause",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "zztl_worootcause"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_wocorrection",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "zztl_wocorrection"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_genuser",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "zztl_genuser"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_gendate",
				DbType = DbType.Date,
				OracleDbTypeEx = OracleDbType.Date,
				IsNullable = true,
				SourceColumn = "zztl_gendate"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_moduser",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "zztl_moduser"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "zztl_moddate",
				DbType = DbType.Date,
				OracleDbTypeEx = OracleDbType.Date,
				IsNullable = true,
				SourceColumn = "zztl_moddate"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new OracleCommand[] { new OracleCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT zztl_ref, zztl_state, zztl_wotype, zztl_woasset, zztl_wocomplaint, zztl_worootcause, zztl_wocorrection, zztl_genuser, zztl_gendate, zztl_moduser, zztl_moddate FROM LBS_USER.ZZTECHLOG";
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

		[DataObjectMethod(DataObjectMethodType.Insert, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Insert(decimal? zztl_ref, decimal? zztl_state, string zztl_wotype, string zztl_woasset, string zztl_wocomplaint, string zztl_worootcause, string zztl_wocorrection, decimal? zztl_genuser, DateTime? zztl_gendate, decimal? zztl_moduser, DateTime? zztl_moddate)
		{
			int Insert;
			if (!zztl_ref.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[0].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[0].Value = zztl_ref.Value;
			}
			if (!zztl_state.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = zztl_state.Value;
			}
			if (zztl_wotype != null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = zztl_wotype;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			if (zztl_woasset != null)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = zztl_woasset;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			if (zztl_wocomplaint != null)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = zztl_wocomplaint;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			if (zztl_worootcause != null)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = zztl_worootcause;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			if (zztl_wocorrection != null)
			{
				this.Adapter.InsertCommand.Parameters[6].Value = zztl_wocorrection;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[6].Value = DBNull.Value;
			}
			if (!zztl_genuser.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[7].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[7].Value = zztl_genuser.Value;
			}
			if (!zztl_gendate.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[8].Value = zztl_gendate.Value;
			}
			if (!zztl_moduser.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[9].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[9].Value = zztl_moduser.Value;
			}
			if (!zztl_moddate.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[10].Value = zztl_moddate.Value;
			}
			ConnectionState previousConnectionState = this.Adapter.InsertCommand.Connection.State;
			if ((this.Adapter.InsertCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.InsertCommand.Connection.Open();
			}
			try
			{
				Insert = this.Adapter.InsertCommand.ExecuteNonQuery();
			}
			finally
			{
				if (previousConnectionState == ConnectionState.Closed)
				{
					this.Adapter.InsertCommand.Connection.Close();
				}
			}
			return Insert;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(CVS_FL_LBS.ZZTECHLOGDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(CVS_FL_LBS dataSet)
		{
			return this.Adapter.Update(dataSet, "ZZTECHLOG");
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow dataRow)
		{
			return this.Adapter.Update(new DataRow[] { dataRow });
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(DataRow[] dataRows)
		{
			return this.Adapter.Update(dataRows);
		}
	}
}