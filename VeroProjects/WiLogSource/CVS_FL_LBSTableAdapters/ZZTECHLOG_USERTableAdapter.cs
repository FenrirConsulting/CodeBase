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
	public class ZZTECHLOG_USERTableAdapter : Component
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
		static ZZTECHLOG_USERTableAdapter()
		{
			ZZTECHLOG_USERTableAdapter.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public ZZTECHLOG_USERTableAdapter()
		{
			ZZTECHLOG_USERTableAdapter.__ENCAddToList(this);
			this.ClearBeforeFill = true;
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (ZZTECHLOG_USERTableAdapter.__ENCList)
			{
				if (ZZTECHLOG_USERTableAdapter.__ENCList.Count == ZZTECHLOG_USERTableAdapter.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(ZZTECHLOG_USERTableAdapter.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (ZZTECHLOG_USERTableAdapter.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								ZZTECHLOG_USERTableAdapter.__ENCList[item] = ZZTECHLOG_USERTableAdapter.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					ZZTECHLOG_USERTableAdapter.__ENCList.RemoveRange(item, checked(ZZTECHLOG_USERTableAdapter.__ENCList.Count - item));
					ZZTECHLOG_USERTableAdapter.__ENCList.Capacity = ZZTECHLOG_USERTableAdapter.__ENCList.Count;
				}
				ZZTECHLOG_USERTableAdapter.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		[DataObjectMethod(DataObjectMethodType.Delete, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Delete(decimal Original_ZZTLU_REF, decimal? Original_ZZTL_REF, string Original_ZZTLU_NAME, decimal? Original_ZZTLU_TIME, decimal? Original_ZZTLU_SHIFT, DateTime? Original_ZZTLU_DATE)
		{
			int Delete;
			this.Adapter.DeleteCommand.Parameters[0].Value = Original_ZZTLU_REF;
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
			if (Original_ZZTLU_NAME != null)
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 0;
				this.Adapter.DeleteCommand.Parameters[4].Value = Original_ZZTLU_NAME;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[3].Value = 1;
				this.Adapter.DeleteCommand.Parameters[4].Value = DBNull.Value;
			}
			if (!Original_ZZTLU_TIME.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 1;
				this.Adapter.DeleteCommand.Parameters[6].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[5].Value = 0;
				this.Adapter.DeleteCommand.Parameters[6].Value = Original_ZZTLU_TIME.Value;
			}
			if (!Original_ZZTLU_SHIFT.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 1;
				this.Adapter.DeleteCommand.Parameters[8].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[7].Value = 0;
				this.Adapter.DeleteCommand.Parameters[8].Value = Original_ZZTLU_SHIFT.Value;
			}
			if (!Original_ZZTLU_DATE.HasValue)
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 1;
				this.Adapter.DeleteCommand.Parameters[10].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.DeleteCommand.Parameters[9].Value = 0;
				this.Adapter.DeleteCommand.Parameters[10].Value = Original_ZZTLU_DATE.Value;
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
		public virtual int Fill(CVS_FL_LBS.ZZTECHLOG_USERDataTable dataTable)
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
		public virtual CVS_FL_LBS.ZZTECHLOG_USERDataTable GetData()
		{
			this.Adapter.SelectCommand = this.CommandCollection[0];
			CVS_FL_LBS.ZZTECHLOG_USERDataTable dataTable = new CVS_FL_LBS.ZZTECHLOG_USERDataTable();
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
				DataSetTable = "ZZTECHLOG_USER"
			};
			tableMapping.ColumnMappings.Add("ZZTLU_REF", "ZZTLU_REF");
			tableMapping.ColumnMappings.Add("ZZTL_REF", "ZZTL_REF");
			tableMapping.ColumnMappings.Add("ZZTLU_NAME", "ZZTLU_NAME");
			tableMapping.ColumnMappings.Add("ZZTLU_TIME", "ZZTLU_TIME");
			tableMapping.ColumnMappings.Add("ZZTLU_SHIFT", "ZZTLU_SHIFT");
			tableMapping.ColumnMappings.Add("ZZTLU_DATE", "ZZTLU_DATE");
			this._adapter.TableMappings.Add((object)tableMapping);
			this._adapter.DeleteCommand = new OracleCommand()
			{
				Connection = this.Connection,
				CommandText = "DELETE FROM \"LBS_USER\".\"ZZTECHLOG_USER\" WHERE ((\"ZZTLU_REF\" = :Original_ZZTLU_REF) AND ((:IsNull_ZZTL_REF = 1 AND \"ZZTL_REF\" IS NULL) OR (\"ZZTL_REF\" = :Original_ZZTL_REF)) AND ((:IsNull_ZZTLU_NAME = 1 AND \"ZZTLU_NAME\" IS NULL) OR (\"ZZTLU_NAME\" = :Original_ZZTLU_NAME)) AND ((:IsNull_ZZTLU_TIME = 1 AND \"ZZTLU_TIME\" IS NULL) OR (\"ZZTLU_TIME\" = :Original_ZZTLU_TIME)) AND ((:IsNull_ZZTLU_SHIFT = 1 AND \"ZZTLU_SHIFT\" IS NULL) OR (\"ZZTLU_SHIFT\" = :Original_ZZTLU_SHIFT)) AND ((:IsNull_ZZTLU_DATE = 1 AND \"ZZTLU_DATE\" IS NULL) OR (\"ZZTLU_DATE\" = :Original_ZZTLU_DATE)))",
				CommandType = CommandType.Text
			};
			OracleParameter param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_REF",
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
				ParameterName = "IsNull_ZZTLU_NAME",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLU_NAME",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_NAME",
				OracleDbTypeEx = OracleDbType.Varchar2,
				IsNullable = true,
				SourceColumn = "ZZTLU_NAME",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTLU_TIME",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLU_TIME",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_TIME",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_TIME",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTLU_SHIFT",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLU_SHIFT",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_SHIFT",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_SHIFT",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTLU_DATE",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLU_DATE",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_DATE",
				DbType = DbType.Date,
				OracleDbTypeEx = OracleDbType.Date,
				IsNullable = true,
				SourceColumn = "ZZTLU_DATE",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.DeleteCommand.Parameters.Add(param);
			this._adapter.InsertCommand = new OracleCommand()
			{
				Connection = this.Connection,
				CommandText = "INSERT INTO \"LBS_USER\".\"ZZTECHLOG_USER\" (\"ZZTLU_REF\", \"ZZTL_REF\", \"ZZTLU_NAME\", \"ZZTLU_TIME\", \"ZZTLU_SHIFT\", \"ZZTLU_DATE\") VALUES (:ZZTLU_REF, :ZZTL_REF, :ZZTLU_NAME, :ZZTLU_TIME, :ZZTLU_SHIFT, :ZZTLU_DATE)",
				CommandType = CommandType.Text
			};
			param = new OracleParameter()
			{
				ParameterName = "ZZTLU_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_REF"
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
				ParameterName = "ZZTLU_NAME",
				OracleDbTypeEx = OracleDbType.Varchar2,
				IsNullable = true,
				SourceColumn = "ZZTLU_NAME"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTLU_TIME",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_TIME"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTLU_SHIFT",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_SHIFT"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTLU_DATE",
				DbType = DbType.Date,
				OracleDbTypeEx = OracleDbType.Date,
				IsNullable = true,
				SourceColumn = "ZZTLU_DATE"
			};
			this._adapter.InsertCommand.Parameters.Add(param);
			this._adapter.UpdateCommand = new OracleCommand()
			{
				Connection = this.Connection,
				CommandText = "UPDATE \"LBS_USER\".\"ZZTECHLOG_USER\" SET \"ZZTLU_REF\" = :ZZTLU_REF, \"ZZTL_REF\" = :ZZTL_REF, \"ZZTLU_NAME\" = :ZZTLU_NAME, \"ZZTLU_TIME\" = :ZZTLU_TIME, \"ZZTLU_SHIFT\" = :ZZTLU_SHIFT, \"ZZTLU_DATE\" = :ZZTLU_DATE WHERE ((\"ZZTLU_REF\" = :Original_ZZTLU_REF) AND ((:IsNull_ZZTL_REF = 1 AND \"ZZTL_REF\" IS NULL) OR (\"ZZTL_REF\" = :Original_ZZTL_REF)) AND ((:IsNull_ZZTLU_NAME = 1 AND \"ZZTLU_NAME\" IS NULL) OR (\"ZZTLU_NAME\" = :Original_ZZTLU_NAME)) AND ((:IsNull_ZZTLU_TIME = 1 AND \"ZZTLU_TIME\" IS NULL) OR (\"ZZTLU_TIME\" = :Original_ZZTLU_TIME)) AND ((:IsNull_ZZTLU_SHIFT = 1 AND \"ZZTLU_SHIFT\" IS NULL) OR (\"ZZTLU_SHIFT\" = :Original_ZZTLU_SHIFT)) AND ((:IsNull_ZZTLU_DATE = 1 AND \"ZZTLU_DATE\" IS NULL) OR (\"ZZTLU_DATE\" = :Original_ZZTLU_DATE)))",
				CommandType = CommandType.Text
			};
			param = new OracleParameter()
			{
				ParameterName = "ZZTLU_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_REF"
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
				ParameterName = "ZZTLU_NAME",
				OracleDbTypeEx = OracleDbType.Varchar2,
				IsNullable = true,
				SourceColumn = "ZZTLU_NAME"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTLU_TIME",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_TIME"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTLU_SHIFT",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_SHIFT"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "ZZTLU_DATE",
				DbType = DbType.Date,
				OracleDbTypeEx = OracleDbType.Date,
				IsNullable = true,
				SourceColumn = "ZZTLU_DATE"
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_REF",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_REF",
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
				ParameterName = "IsNull_ZZTLU_NAME",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLU_NAME",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_NAME",
				OracleDbTypeEx = OracleDbType.Varchar2,
				IsNullable = true,
				SourceColumn = "ZZTLU_NAME",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTLU_TIME",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLU_TIME",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_TIME",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_TIME",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTLU_SHIFT",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLU_SHIFT",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_SHIFT",
				DbType = DbType.Decimal,
				OracleDbTypeEx = OracleDbType.Decimal,
				IsNullable = true,
				SourceColumn = "ZZTLU_SHIFT",
				SourceVersion = DataRowVersion.Original
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "IsNull_ZZTLU_DATE",
				DbType = DbType.Int32,
				OracleDbTypeEx = OracleDbType.Int32,
				IsNullable = true,
				SourceColumn = "ZZTLU_DATE",
				SourceVersion = DataRowVersion.Original,
				SourceColumnNullMapping = true
			};
			this._adapter.UpdateCommand.Parameters.Add(param);
			param = new OracleParameter()
			{
				ParameterName = "Original_ZZTLU_DATE",
				DbType = DbType.Date,
				OracleDbTypeEx = OracleDbType.Date,
				IsNullable = true,
				SourceColumn = "ZZTLU_DATE",
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
			this._commandCollection[0].CommandText = "SELECT ZZTLU_REF, ZZTL_REF, ZZTLU_NAME, ZZTLU_TIME, ZZTLU_SHIFT, ZZTLU_DATE FROM LBS_USER.ZZTECHLOG_USER";
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
		public virtual int Insert(decimal ZZTLU_REF, decimal? ZZTL_REF, string ZZTLU_NAME, decimal? ZZTLU_TIME, decimal? ZZTLU_SHIFT, DateTime? ZZTLU_DATE)
		{
			int Insert;
			this.Adapter.InsertCommand.Parameters[0].Value = ZZTLU_REF;
			if (!ZZTL_REF.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[1].Value = ZZTL_REF.Value;
			}
			if (ZZTLU_NAME != null)
			{
				this.Adapter.InsertCommand.Parameters[2].Value = ZZTLU_NAME;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[2].Value = DBNull.Value;
			}
			if (!ZZTLU_TIME.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[3].Value = ZZTLU_TIME.Value;
			}
			if (!ZZTLU_SHIFT.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[4].Value = ZZTLU_SHIFT.Value;
			}
			if (!ZZTLU_DATE.HasValue)
			{
				this.Adapter.InsertCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.InsertCommand.Parameters[5].Value = ZZTLU_DATE.Value;
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
		public virtual int Update(CVS_FL_LBS.ZZTECHLOG_USERDataTable dataTable)
		{
			return this.Adapter.Update(dataTable);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(CVS_FL_LBS dataSet)
		{
			return this.Adapter.Update(dataSet, "ZZTECHLOG_USER");
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
		public virtual int Update(decimal ZZTLU_REF, decimal? ZZTL_REF, string ZZTLU_NAME, decimal? ZZTLU_TIME, decimal? ZZTLU_SHIFT, DateTime? ZZTLU_DATE, decimal Original_ZZTLU_REF, decimal? Original_ZZTL_REF, string Original_ZZTLU_NAME, decimal? Original_ZZTLU_TIME, decimal? Original_ZZTLU_SHIFT, DateTime? Original_ZZTLU_DATE)
		{
			int Update;
			this.Adapter.UpdateCommand.Parameters[0].Value = ZZTLU_REF;
			if (!ZZTL_REF.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[1].Value = ZZTL_REF.Value;
			}
			if (ZZTLU_NAME != null)
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = ZZTLU_NAME;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[2].Value = DBNull.Value;
			}
			if (!ZZTLU_TIME.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[3].Value = ZZTLU_TIME.Value;
			}
			if (!ZZTLU_SHIFT.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[4].Value = ZZTLU_SHIFT.Value;
			}
			if (!ZZTLU_DATE.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[5].Value = ZZTLU_DATE.Value;
			}
			this.Adapter.UpdateCommand.Parameters[6].Value = Original_ZZTLU_REF;
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
			if (Original_ZZTLU_NAME != null)
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 0;
				this.Adapter.UpdateCommand.Parameters[10].Value = Original_ZZTLU_NAME;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[9].Value = 1;
				this.Adapter.UpdateCommand.Parameters[10].Value = DBNull.Value;
			}
			if (!Original_ZZTLU_TIME.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 1;
				this.Adapter.UpdateCommand.Parameters[12].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[11].Value = 0;
				this.Adapter.UpdateCommand.Parameters[12].Value = Original_ZZTLU_TIME.Value;
			}
			if (!Original_ZZTLU_SHIFT.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 1;
				this.Adapter.UpdateCommand.Parameters[14].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[13].Value = 0;
				this.Adapter.UpdateCommand.Parameters[14].Value = Original_ZZTLU_SHIFT.Value;
			}
			if (!Original_ZZTLU_DATE.HasValue)
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 1;
				this.Adapter.UpdateCommand.Parameters[16].Value = DBNull.Value;
			}
			else
			{
				this.Adapter.UpdateCommand.Parameters[15].Value = 0;
				this.Adapter.UpdateCommand.Parameters[16].Value = Original_ZZTLU_DATE.Value;
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

		[DataObjectMethod(DataObjectMethodType.Update, true)]
		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		[HelpKeyword("vs.data.TableAdapter")]
		public virtual int Update(decimal? ZZTL_REF, string ZZTLU_NAME, decimal? ZZTLU_TIME, decimal? ZZTLU_SHIFT, DateTime? ZZTLU_DATE, decimal Original_ZZTLU_REF, decimal? Original_ZZTL_REF, string Original_ZZTLU_NAME, decimal? Original_ZZTLU_TIME, decimal? Original_ZZTLU_SHIFT, DateTime? Original_ZZTLU_DATE)
		{
			int Update = this.Update(Original_ZZTLU_REF, ZZTL_REF, ZZTLU_NAME, ZZTLU_TIME, ZZTLU_SHIFT, ZZTLU_DATE, Original_ZZTLU_REF, Original_ZZTL_REF, Original_ZZTLU_NAME, Original_ZZTLU_TIME, Original_ZZTLU_SHIFT, Original_ZZTLU_DATE);
			return Update;
		}
	}
}