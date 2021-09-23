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
	public class ZZTECHLOG_PARTSTableAdapter : Component
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
		static ZZTECHLOG_PARTSTableAdapter()
		{
			ZZTECHLOG_PARTSTableAdapter.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ZZTECHLOG_PARTSTableAdapter()
		{
			ZZTECHLOG_PARTSTableAdapter.__ENCAddToList(this);
			this.ClearBeforeFill = true;
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (ZZTECHLOG_PARTSTableAdapter.__ENCList)
			{
				if (ZZTECHLOG_PARTSTableAdapter.__ENCList.Count == ZZTECHLOG_PARTSTableAdapter.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(ZZTECHLOG_PARTSTableAdapter.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (ZZTECHLOG_PARTSTableAdapter.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								ZZTECHLOG_PARTSTableAdapter.__ENCList[item] = ZZTECHLOG_PARTSTableAdapter.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					ZZTECHLOG_PARTSTableAdapter.__ENCList.RemoveRange(item, checked(ZZTECHLOG_PARTSTableAdapter.__ENCList.Count - item));
					ZZTECHLOG_PARTSTableAdapter.__ENCList.Capacity = ZZTECHLOG_PARTSTableAdapter.__ENCList.Count;
				}
				ZZTECHLOG_PARTSTableAdapter.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(decimal Original_ZZTLP_REF, decimal? Original_ZZTL_REF, decimal? Original_ZZTLP_QNTY, string Original_ZZHTLP_PARTNUMBER, string Original_ZZHTLP_LOCATION, string Original_ZZHTLP_DESCRIPTION)
		{
			int Delete;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_ZZTLP_REF;
			if (!Original_ZZTL_REF.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 1;
				this.Adapter.DeleteCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[1].Value = 0;
				this.Adapter.DeleteCommand.Parameters[2].Value = Original_ZZTL_REF.Value;
			}
			if (!Original_ZZTLP_QNTY.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_ZZTLP_QNTY.Value;
			}
			if (Original_ZZHTLP_PARTNUMBER != null)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_ZZHTLP_PARTNUMBER;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			if (Original_ZZHTLP_LOCATION != null)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_ZZHTLP_LOCATION;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			if (Original_ZZHTLP_DESCRIPTION != null)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_ZZHTLP_DESCRIPTION;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			ConnectionState previousConnectionState = this.Adapter.DeleteCommand.Connection.State;
			if ((this.Adapter.DeleteCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.DeleteCommand.Connection.Open();
			}
			try
			{
				Delete = this.Adapter.DeleteCommand.ExecuteNonQuery();
			}
			finally
			{
				if (previousConnectionState == ConnectionState.Closed)
				{
					this.Adapter.DeleteCommand.Connection.Close();
				}
			}
			return Delete;
		}

		[DataObjectMethod(DataObjectMethodType.Fill, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Fill(CVS_FL_LBS.ZZTECHLOG_PARTSDataTable dataTable)
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
		public virtual CVS_FL_LBS.ZZTECHLOG_PARTSDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			CVS_FL_LBS.ZZTECHLOG_PARTSDataTable dataTable = new CVS_FL_LBS.ZZTECHLOG_PARTSDataTable();
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
				DataSetTable = "ZZTECHLOG_PARTS"
			};
			tableMapping.ColumnMappings.Add("ZZTLP_REF", "ZZTLP_REF");
			tableMapping.ColumnMappings.Add("ZZTL_REF", "ZZTL_REF");
			tableMapping.ColumnMappings.Add("ZZTLP_QNTY", "ZZTLP_QNTY");
			tableMapping.ColumnMappings.Add("ZZHTLP_PARTNUMBER", "ZZHTLP_PARTNUMBER");
			tableMapping.ColumnMappings.Add("ZZHTLP_LOCATION", "ZZHTLP_LOCATION");
			tableMapping.ColumnMappings.Add("ZZHTLP_DESCRIPTION", "ZZHTLP_DESCRIPTION");
			this._adapter.TableMappings.Add((object)tableMapping);
			this._adapter.DeleteCommand = new OracleCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM \"LBS_USER\".\"ZZTECHLOG_PARTS\" WHERE ((\"ZZTLP_REF\" = :Original_ZZTLP_REF) AND ((:IsNull_ZZTL_REF = 1 AND \"ZZTL_REF\" IS NULL) OR (\"ZZTL_REF\" = :Original_ZZTL_REF)) AND ((:IsNull_ZZTLP_QNTY = 1 AND \"ZZTLP_QNTY\" IS NULL) OR (\"ZZTLP_QNTY\" = :Original_ZZTLP_QNTY)) AND ((:IsNull_ZZHTLP_PARTNUMBER = 1 AND \"ZZHTLP_PARTNUMBER\" IS NULL) OR (\"ZZHTLP_PARTNUMBER\" = :Original_ZZHTLP_PARTNUMBER)) AND ((:IsNull_ZZHTLP_LOCATION = 1 AND \"ZZHTLP_LOCATION\" IS NULL) OR (\"ZZHTLP_LOCATION\" = :Original_ZZHTLP_LOCATION)) AND ((:IsNull_ZZHTLP_DESCRIPTION = 1 AND \"ZZHTLP_DESCRIPTION\" IS NULL) OR (\"ZZHTLP_DESCRIPTION\" = :Original_ZZHTLP_DESCRIPTION)))",
				CommandType = CommandType.Text
			};
			OracleParameter param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLP_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLP_REF",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTL_REF",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTL_REF",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTL_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTL_REF",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTLP_QNTY",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLP_QNTY",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLP_QNTY",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLP_QNTY",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZHTLP_PARTNUMBER",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZHTLP_PARTNUMBER",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZHTLP_PARTNUMBER",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_PARTNUMBER",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZHTLP_LOCATION",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZHTLP_LOCATION",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZHTLP_LOCATION",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_LOCATION",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZHTLP_DESCRIPTION",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZHTLP_DESCRIPTION",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZHTLP_DESCRIPTION",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_DESCRIPTION",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			this._adapter.InsertCommand = new OracleCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO \"LBS_USER\".\"ZZTECHLOG_PARTS\" (\"ZZTLP_REF\", \"ZZTL_REF\", \"ZZTLP_QNTY\", \"ZZHTLP_PARTNUMBER\", \"ZZHTLP_LOCATION\", \"ZZHTLP_DESCRIPTION\") VALUES (:ZZTLP_REF, :ZZTL_REF, :ZZTLP_QNTY, :ZZHTLP_PARTNUMBER, :ZZHTLP_LOCATION, :ZZHTLP_DESCRIPTION)",
				CommandType = CommandType.Text
			};
			param = new OracleParameter()
			{
				ParameterName = "ZZTLP_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLP_REF"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTL_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTL_REF"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTLP_QNTY",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLP_QNTY"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZHTLP_PARTNUMBER",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_PARTNUMBER"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZHTLP_LOCATION",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_LOCATION"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZHTLP_DESCRIPTION",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_DESCRIPTION"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			this._adapter.UpdateCommand = new OracleCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE \"LBS_USER\".\"ZZTECHLOG_PARTS\" SET \"ZZTLP_REF\" = :ZZTLP_REF, \"ZZTL_REF\" = :ZZTL_REF, \"ZZTLP_QNTY\" = :ZZTLP_QNTY, \"ZZHTLP_PARTNUMBER\" = :ZZHTLP_PARTNUMBER, \"ZZHTLP_LOCATION\" = :ZZHTLP_LOCATION, \"ZZHTLP_DESCRIPTION\" = :ZZHTLP_DESCRIPTION WHERE ((\"ZZTLP_REF\" = :Original_ZZTLP_REF) AND ((:IsNull_ZZTL_REF = 1 AND \"ZZTL_REF\" IS NULL) OR (\"ZZTL_REF\" = :Original_ZZTL_REF)) AND ((:IsNull_ZZTLP_QNTY = 1 AND \"ZZTLP_QNTY\" IS NULL) OR (\"ZZTLP_QNTY\" = :Original_ZZTLP_QNTY)) AND ((:IsNull_ZZHTLP_PARTNUMBER = 1 AND \"ZZHTLP_PARTNUMBER\" IS NULL) OR (\"ZZHTLP_PARTNUMBER\" = :Original_ZZHTLP_PARTNUMBER)) AND ((:IsNull_ZZHTLP_LOCATION = 1 AND \"ZZHTLP_LOCATION\" IS NULL) OR (\"ZZHTLP_LOCATION\" = :Original_ZZHTLP_LOCATION)) AND ((:IsNull_ZZHTLP_DESCRIPTION = 1 AND \"ZZHTLP_DESCRIPTION\" IS NULL) OR (\"ZZHTLP_DESCRIPTION\" = :Original_ZZHTLP_DESCRIPTION)))",
				CommandType = CommandType.Text
			};
			param = new OracleParameter()
			{
				ParameterName = "ZZTLP_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLP_REF"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTL_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTL_REF"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTLP_QNTY",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLP_QNTY"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZHTLP_PARTNUMBER",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_PARTNUMBER"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZHTLP_LOCATION",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_LOCATION"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZHTLP_DESCRIPTION",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_DESCRIPTION"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLP_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLP_REF",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTL_REF",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTL_REF",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTL_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTL_REF",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTLP_QNTY",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLP_QNTY",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLP_QNTY",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLP_QNTY",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZHTLP_PARTNUMBER",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZHTLP_PARTNUMBER",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZHTLP_PARTNUMBER",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_PARTNUMBER",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZHTLP_LOCATION",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZHTLP_LOCATION",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZHTLP_LOCATION",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_LOCATION",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZHTLP_DESCRIPTION",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZHTLP_DESCRIPTION",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZHTLP_DESCRIPTION",
				OracleDbTypeEx = OracleDbType.NVarchar2,
				IsNullable = true,
				SourceColumn = "ZZHTLP_DESCRIPTION",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitCommandCollection()
		{
			this._commandCollection = new OracleCommand[] { new OracleCommand() };
			this._commandCollection[0].Connection = this.Connection;
			this._commandCollection[0].CommandText = "SELECT ZZTLP_REF, ZZTL_REF, ZZTLP_QNTY, ZZHTLP_PARTNUMBER, ZZHTLP_LOCATION, ZZHTLP_DESCRIPTION FROM LBS_USER.ZZTECHLOG_PARTS ORDER BY ZZTLP_REF";
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
		public virtual int Insert(decimal ZZTLP_REF, decimal? ZZTL_REF, decimal? ZZTLP_QNTY, string ZZHTLP_PARTNUMBER, string ZZHTLP_LOCATION, string ZZHTLP_DESCRIPTION)
		{
			int Insert;
			this.Adapter.InsertCommand.Parameters[0].Value = ZZTLP_REF;
			if (!ZZTL_REF.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = ZZTL_REF.Value;
			}
			if (!ZZTLP_QNTY.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = ZZTLP_QNTY.Value;
			}
			if (ZZHTLP_PARTNUMBER != null)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = ZZHTLP_PARTNUMBER;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			if (ZZHTLP_LOCATION != null)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = ZZHTLP_LOCATION;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			if (ZZHTLP_DESCRIPTION != null)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = ZZHTLP_DESCRIPTION;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
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
		public virtual int Update(CVS_FL_LBS.ZZTECHLOG_PARTSDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(CVS_FL_LBS dataSet)
		{
			return this.Adapter.Update(dataSet, "ZZTECHLOG_PARTS");
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

		[DataObjectMethod(DataObjectMethodType.Update, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(decimal ZZTLP_REF, decimal? ZZTL_REF, decimal? ZZTLP_QNTY, string ZZHTLP_PARTNUMBER, string ZZHTLP_LOCATION, string ZZHTLP_DESCRIPTION, decimal Original_ZZTLP_REF, decimal? Original_ZZTL_REF, decimal? Original_ZZTLP_QNTY, string Original_ZZHTLP_PARTNUMBER, string Original_ZZHTLP_LOCATION, string Original_ZZHTLP_DESCRIPTION)
		{
			int Update;
			this.Adapter.UpdateCommand.Parameters[0].Value = ZZTLP_REF;
			if (!ZZTL_REF.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = ZZTL_REF.Value;
			}
			if (!ZZTLP_QNTY.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = ZZTLP_QNTY.Value;
			}
			if (ZZHTLP_PARTNUMBER != null)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = ZZHTLP_PARTNUMBER;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			if (ZZHTLP_LOCATION != null)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = ZZHTLP_LOCATION;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			if (ZZHTLP_DESCRIPTION != null)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = ZZHTLP_DESCRIPTION;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			this.Adapter.UpdateCommand.Parameters[6].Value = Original_ZZTLP_REF;
			if (!Original_ZZTL_REF.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = 1;
				this.Adapter.UpdateCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[7].Value = 0;
				this.Adapter.UpdateCommand.Parameters[8].Value = Original_ZZTL_REF.Value;
			}
			if (!Original_ZZTLP_QNTY.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 1;
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 0;
				this.Adapter.UpdateCommand.Parameters[10].Value = Original_ZZTLP_QNTY.Value;
			}
			if (Original_ZZHTLP_PARTNUMBER != null)
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 0;
				this.Adapter.UpdateCommand.Parameters[12].Value = Original_ZZHTLP_PARTNUMBER;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 1;
				this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
			}
			if (Original_ZZHTLP_LOCATION != null)
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 0;
				this.Adapter.UpdateCommand.Parameters[14].Value = Original_ZZHTLP_LOCATION;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 1;
				this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
			}
			if (Original_ZZHTLP_DESCRIPTION != null)
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 0;
				this.Adapter.UpdateCommand.Parameters[16].Value = Original_ZZHTLP_DESCRIPTION;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 1;
				this.Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
			}
			ConnectionState previousConnectionState = this.Adapter.UpdateCommand.Connection.State;
			if ((this.Adapter.UpdateCommand.Connection.State & ConnectionState.Open) != ConnectionState.Open)
			{
				this.Adapter.UpdateCommand.Connection.Open();
			}
			try
			{
				Update = this.Adapter.UpdateCommand.ExecuteNonQuery();
			}
			finally
			{
				if (previousConnectionState == ConnectionState.Closed)
				{
					this.Adapter.UpdateCommand.Connection.Close();
				}
			}
			return Update;
		}
	}
}