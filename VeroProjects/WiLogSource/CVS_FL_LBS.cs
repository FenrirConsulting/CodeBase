using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Data;
using System.Diagnostics;
using System.Globalization;
using System.IO;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.Serialization;
using System.Xml;
using System.Xml.Schema;
using System.Xml.Serialization;

namespace WiLog
{
	[DesignerCategory("code")]
	[HelpKeyword("vs.data.DataSet")]
	[Serializable]
	[ToolboxItem(true)]
	[XmlRoot("CVS_FL_LBS")]
	[XmlSchemaProvider("GetTypedDataSetSchema")]
	public class CVS_FL_LBS : DataSet
	{
		private static List<WeakReference> __ENCList;

		private CVS_FL_LBS.ZZTECHLOGDataTable tableZZTECHLOG;

		private CVS_FL_LBS.ZZTECHLOG_USERDataTable tableZZTECHLOG_USER;

		private CVS_FL_LBS.ZZTECHLOG_PARTSDataTable tableZZTECHLOG_PARTS;

		private CVS_FL_LBS.AllTechInfoDataTable tableAllTechInfo;

		private CVS_FL_LBS.AllPartInfoDataTable tableAllPartInfo;

		private System.Data.SchemaSerializationMode _schemaSerializationMode;

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CVS_FL_LBS.AllPartInfoDataTable AllPartInfo
		{
			get
			{
				return this.tableAllPartInfo;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CVS_FL_LBS.AllTechInfoDataTable AllTechInfo
		{
			get
			{
				return this.tableAllTechInfo;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataRelationCollection Relations
		{
			get
			{
				return base.Relations;
			}
		}

		[Browsable(true)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Visible)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override System.Data.SchemaSerializationMode SchemaSerializationMode
		{
			get
			{
				return this._schemaSerializationMode;
			}
			set
			{
				this._schemaSerializationMode = value;
			}
		}

		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Hidden)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public new DataTableCollection Tables
		{
			get
			{
				return base.Tables;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CVS_FL_LBS.ZZTECHLOGDataTable ZZTECHLOG
		{
			get
			{
				return this.tableZZTECHLOG;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CVS_FL_LBS.ZZTECHLOG_PARTSDataTable ZZTECHLOG_PARTS
		{
			get
			{
				return this.tableZZTECHLOG_PARTS;
			}
		}

		[Browsable(false)]
		[DebuggerNonUserCode]
		[DesignerSerializationVisibility(DesignerSerializationVisibility.Content)]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CVS_FL_LBS.ZZTECHLOG_USERDataTable ZZTECHLOG_USER
		{
			get
			{
				return this.tableZZTECHLOG_USER;
			}
		}

		[DebuggerNonUserCode]
		static CVS_FL_LBS()
		{
			CVS_FL_LBS.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public CVS_FL_LBS()
		{
			CVS_FL_LBS.__ENCAddToList(this);
			this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.BeginInit();
			this.InitClass();
			CVS_FL_LBS cVSFLLB = this;
			CollectionChangeEventHandler schemaChangedHandler = new CollectionChangeEventHandler(cVSFLLB.SchemaChanged);
			base.Tables.CollectionChanged += schemaChangedHandler;
			base.Relations.CollectionChanged += schemaChangedHandler;
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected CVS_FL_LBS(SerializationInfo info, StreamingContext context) : base(info, context, false)
		{
			CVS_FL_LBS.__ENCAddToList(this);
			this._schemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			if (!this.IsBinarySerialized(info, context))
			{
				string strSchema = Conversions.ToString(info.GetValue("XmlSchema", typeof(string)));
				if (this.DetermineSchemaSerializationMode(info, context) != System.Data.SchemaSerializationMode.IncludeSchema)
				{
					this.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
				}
				else
				{
					DataSet ds = new DataSet();
					ds.ReadXmlSchema(new XmlTextReader(new StringReader(strSchema)));
					if (ds.Tables["ZZTECHLOG"] != null)
					{
						base.Tables.Add(new CVS_FL_LBS.ZZTECHLOGDataTable(ds.Tables["ZZTECHLOG"]));
					}
					if (ds.Tables["ZZTECHLOG_USER"] != null)
					{
						base.Tables.Add(new CVS_FL_LBS.ZZTECHLOG_USERDataTable(ds.Tables["ZZTECHLOG_USER"]));
					}
					if (ds.Tables["ZZTECHLOG_PARTS"] != null)
					{
						base.Tables.Add(new CVS_FL_LBS.ZZTECHLOG_PARTSDataTable(ds.Tables["ZZTECHLOG_PARTS"]));
					}
					if (ds.Tables["AllTechInfo"] != null)
					{
						base.Tables.Add(new CVS_FL_LBS.AllTechInfoDataTable(ds.Tables["AllTechInfo"]));
					}
					if (ds.Tables["AllPartInfo"] != null)
					{
						base.Tables.Add(new CVS_FL_LBS.AllPartInfoDataTable(ds.Tables["AllPartInfo"]));
					}
					this.DataSetName = ds.DataSetName;
					this.Prefix = ds.Prefix;
					this.Namespace = ds.Namespace;
					this.Locale = ds.Locale;
					this.CaseSensitive = ds.CaseSensitive;
					this.EnforceConstraints = ds.EnforceConstraints;
					this.Merge(ds, false, MissingSchemaAction.Add);
					this.InitVars();
				}
				this.GetSerializationData(info, context);
				CVS_FL_LBS cVSFLLB = this;
				CollectionChangeEventHandler schemaChangedHandler = new CollectionChangeEventHandler(cVSFLLB.SchemaChanged);
				base.Tables.CollectionChanged += schemaChangedHandler;
				this.Relations.CollectionChanged += schemaChangedHandler;
			}
			else
			{
				this.InitVars(false);
				CVS_FL_LBS cVSFLLB1 = this;
				CollectionChangeEventHandler schemaChangedHandler1 = new CollectionChangeEventHandler(cVSFLLB1.SchemaChanged);
				this.Tables.CollectionChanged += schemaChangedHandler1;
				this.Relations.CollectionChanged += schemaChangedHandler1;
			}
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (CVS_FL_LBS.__ENCList)
			{
				if (CVS_FL_LBS.__ENCList.Count == CVS_FL_LBS.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(CVS_FL_LBS.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (CVS_FL_LBS.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								CVS_FL_LBS.__ENCList[item] = CVS_FL_LBS.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					CVS_FL_LBS.__ENCList.RemoveRange(item, checked(CVS_FL_LBS.__ENCList.Count - item));
					CVS_FL_LBS.__ENCList.Capacity = CVS_FL_LBS.__ENCList.Count;
				}
				CVS_FL_LBS.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public override DataSet Clone()
		{
			CVS_FL_LBS cln = (CVS_FL_LBS)base.Clone();
			cln.InitVars();
			cln.SchemaSerializationMode = this.SchemaSerializationMode;
			return cln;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override XmlSchema GetSchemaSerializable()
		{
			MemoryStream stream = new MemoryStream();
			this.WriteXmlSchema(new XmlTextWriter(stream, null));
			stream.Position = (long)0;
			return XmlSchema.Read(new XmlTextReader(stream), null);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public static XmlSchemaComplexType GetTypedDataSetSchema(XmlSchemaSet xs)
		{
			XmlSchemaComplexType GetTypedDataSetSchema;
			CVS_FL_LBS ds = new CVS_FL_LBS();
			XmlSchemaComplexType type = new XmlSchemaComplexType();
			XmlSchemaSequence sequence = new XmlSchemaSequence();
			XmlSchemaAny any = new XmlSchemaAny()
			{
				Namespace = ds.Namespace
			};
			sequence.Items.Add(any);
			type.Particle = sequence;
			XmlSchema dsSchema = ds.GetSchemaSerializable();
			if (xs.Contains(dsSchema.TargetNamespace))
			{
				MemoryStream s1 = new MemoryStream();
				MemoryStream s2 = new MemoryStream();
				try
				{
					XmlSchema schema = null;
					dsSchema.Write(s1);
					IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
					while (schemas.MoveNext())
					{
						schema = (XmlSchema)schemas.Current;
						s2.SetLength((long)0);
						schema.Write(s2);
						if (s1.Length == s2.Length)
						{
							s1.Position = (long)0;
							s2.Position = (long)0;
							while (true)
							{
								if ((s1.Position == s1.Length || s1.ReadByte() != s2.ReadByte() ? true : false))
								{
									break;
								}
							}
							if (s1.Position == s1.Length)
							{
								GetTypedDataSetSchema = type;
								return GetTypedDataSetSchema;
							}
						}
					}
				}
				finally
				{
					if (s1 != null)
					{
						s1.Close();
					}
					if (s2 != null)
					{
						s2.Close();
					}
				}
			}
			xs.Add(dsSchema);
			GetTypedDataSetSchema = type;
			return GetTypedDataSetSchema;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void InitClass()
		{
			this.DataSetName = "CVS_FL_LBS";
			this.Prefix = "";
			this.Namespace = "http://tempuri.org/CVS_FL_LBS.xsd";
			this.EnforceConstraints = true;
			this.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
			this.tableZZTECHLOG = new CVS_FL_LBS.ZZTECHLOGDataTable();
			base.Tables.Add(this.tableZZTECHLOG);
			this.tableZZTECHLOG_USER = new CVS_FL_LBS.ZZTECHLOG_USERDataTable();
			base.Tables.Add(this.tableZZTECHLOG_USER);
			this.tableZZTECHLOG_PARTS = new CVS_FL_LBS.ZZTECHLOG_PARTSDataTable();
			base.Tables.Add(this.tableZZTECHLOG_PARTS);
			this.tableAllTechInfo = new CVS_FL_LBS.AllTechInfoDataTable();
			base.Tables.Add(this.tableAllTechInfo);
			this.tableAllPartInfo = new CVS_FL_LBS.AllPartInfoDataTable();
			base.Tables.Add(this.tableAllPartInfo);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void InitializeDerivedDataSet()
		{
			this.BeginInit();
			this.InitClass();
			this.EndInit();
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars()
		{
			this.InitVars(true);
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		internal void InitVars(bool initTable)
		{
			this.tableZZTECHLOG = (CVS_FL_LBS.ZZTECHLOGDataTable)base.Tables["ZZTECHLOG"];
			if (initTable)
			{
				if (this.tableZZTECHLOG != null)
				{
					this.tableZZTECHLOG.InitVars();
				}
			}
			this.tableZZTECHLOG_USER = (CVS_FL_LBS.ZZTECHLOG_USERDataTable)base.Tables["ZZTECHLOG_USER"];
			if (initTable)
			{
				if (this.tableZZTECHLOG_USER != null)
				{
					this.tableZZTECHLOG_USER.InitVars();
				}
			}
			this.tableZZTECHLOG_PARTS = (CVS_FL_LBS.ZZTECHLOG_PARTSDataTable)base.Tables["ZZTECHLOG_PARTS"];
			if (initTable)
			{
				if (this.tableZZTECHLOG_PARTS != null)
				{
					this.tableZZTECHLOG_PARTS.InitVars();
				}
			}
			this.tableAllTechInfo = (CVS_FL_LBS.AllTechInfoDataTable)base.Tables["AllTechInfo"];
			if (initTable)
			{
				if (this.tableAllTechInfo != null)
				{
					this.tableAllTechInfo.InitVars();
				}
			}
			this.tableAllPartInfo = (CVS_FL_LBS.AllPartInfoDataTable)base.Tables["AllPartInfo"];
			if (initTable)
			{
				if (this.tableAllPartInfo != null)
				{
					this.tableAllPartInfo.InitVars();
				}
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override void ReadXmlSerializable(XmlReader reader)
		{
			if (this.DetermineSchemaSerializationMode(reader) != System.Data.SchemaSerializationMode.IncludeSchema)
			{
				this.ReadXml(reader);
				this.InitVars();
			}
			else
			{
				this.Reset();
				DataSet ds = new DataSet();
				ds.ReadXml(reader);
				if (ds.Tables["ZZTECHLOG"] != null)
				{
					base.Tables.Add(new CVS_FL_LBS.ZZTECHLOGDataTable(ds.Tables["ZZTECHLOG"]));
				}
				if (ds.Tables["ZZTECHLOG_USER"] != null)
				{
					base.Tables.Add(new CVS_FL_LBS.ZZTECHLOG_USERDataTable(ds.Tables["ZZTECHLOG_USER"]));
				}
				if (ds.Tables["ZZTECHLOG_PARTS"] != null)
				{
					base.Tables.Add(new CVS_FL_LBS.ZZTECHLOG_PARTSDataTable(ds.Tables["ZZTECHLOG_PARTS"]));
				}
				if (ds.Tables["AllTechInfo"] != null)
				{
					base.Tables.Add(new CVS_FL_LBS.AllTechInfoDataTable(ds.Tables["AllTechInfo"]));
				}
				if (ds.Tables["AllPartInfo"] != null)
				{
					base.Tables.Add(new CVS_FL_LBS.AllPartInfoDataTable(ds.Tables["AllPartInfo"]));
				}
				this.DataSetName = ds.DataSetName;
				this.Prefix = ds.Prefix;
				this.Namespace = ds.Namespace;
				this.Locale = ds.Locale;
				this.CaseSensitive = ds.CaseSensitive;
				this.EnforceConstraints = ds.EnforceConstraints;
				this.Merge(ds, false, MissingSchemaAction.Add);
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private void SchemaChanged(object sender, CollectionChangeEventArgs e)
		{
			if (e.Action == CollectionChangeAction.Remove)
			{
				this.InitVars();
			}
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeAllPartInfo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeAllTechInfo()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeRelations()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		protected override bool ShouldSerializeTables()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeZZTECHLOG()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeZZTECHLOG_PARTS()
		{
			return false;
		}

		[DebuggerNonUserCode]
		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		private bool ShouldSerializeZZTECHLOG_USER()
		{
			return false;
		}

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class AllPartInfoDataTable : TypedTableBase<CVS_FL_LBS.AllPartInfoRow>
		{
			private static List<WeakReference> __ENCList;

			private DataColumn columnZZTLP_REF;

			private DataColumn columnZZTL_REF;

			private DataColumn columnZZTLP_QNTY;

			private DataColumn columnZZHTLP_PARTNUMBER;

			private DataColumn columnZZHTLP_LOCATION;

			private DataColumn columnZZHTLP_DESCRIPTION;

			private DataColumn columnZZTL_REF1;

			private DataColumn columnZZTL_STATE;

			private DataColumn columnZZTL_WOTYPE;

			private DataColumn columnZZTL_WOASSET;

			private DataColumn columnZZTL_WOCOMPLAINT;

			private DataColumn columnZZTL_WOROOTCAUSE;

			private DataColumn columnZZTL_WOCORRECTION;

			private DataColumn columnZZTL_GENUSER;

			private DataColumn columnZZTL_GENDATE;

			private DataColumn columnZZTL_MODUSER;

			private DataColumn columnZZTL_MODDATE;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.AllPartInfoRow this[int index]
			{
				get
				{
					return (CVS_FL_LBS.AllPartInfoRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZHTLP_DESCRIPTIONColumn
			{
				get
				{
					return this.columnZZHTLP_DESCRIPTION;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZHTLP_LOCATIONColumn
			{
				get
				{
					return this.columnZZHTLP_LOCATION;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZHTLP_PARTNUMBERColumn
			{
				get
				{
					return this.columnZZHTLP_PARTNUMBER;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_GENDATEColumn
			{
				get
				{
					return this.columnZZTL_GENDATE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_GENUSERColumn
			{
				get
				{
					return this.columnZZTL_GENUSER;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_MODDATEColumn
			{
				get
				{
					return this.columnZZTL_MODDATE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_MODUSERColumn
			{
				get
				{
					return this.columnZZTL_MODUSER;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_REF1Column
			{
				get
				{
					return this.columnZZTL_REF1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_REFColumn
			{
				get
				{
					return this.columnZZTL_REF;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_STATEColumn
			{
				get
				{
					return this.columnZZTL_STATE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOASSETColumn
			{
				get
				{
					return this.columnZZTL_WOASSET;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOCOMPLAINTColumn
			{
				get
				{
					return this.columnZZTL_WOCOMPLAINT;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOCORRECTIONColumn
			{
				get
				{
					return this.columnZZTL_WOCORRECTION;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOROOTCAUSEColumn
			{
				get
				{
					return this.columnZZTL_WOROOTCAUSE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOTYPEColumn
			{
				get
				{
					return this.columnZZTL_WOTYPE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLP_QNTYColumn
			{
				get
				{
					return this.columnZZTLP_QNTY;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLP_REFColumn
			{
				get
				{
					return this.columnZZTLP_REF;
				}
			}

			[DebuggerNonUserCode]
			static AllPartInfoDataTable()
			{
				CVS_FL_LBS.AllPartInfoDataTable.__ENCList = new List<WeakReference>();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public AllPartInfoDataTable()
			{
				CVS_FL_LBS.AllPartInfoDataTable.__ENCAddToList(this);
				this.TableName = "AllPartInfo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal AllPartInfoDataTable(DataTable table)
			{
				CVS_FL_LBS.AllPartInfoDataTable.__ENCAddToList(this);
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected AllPartInfoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				CVS_FL_LBS.AllPartInfoDataTable.__ENCAddToList(this);
				this.InitVars();
			}

			[DebuggerNonUserCode]
			private static void __ENCAddToList(object value)
			{
				lock (CVS_FL_LBS.AllPartInfoDataTable.__ENCList)
				{
					if (CVS_FL_LBS.AllPartInfoDataTable.__ENCList.Count == CVS_FL_LBS.AllPartInfoDataTable.__ENCList.Capacity)
					{
						int item = 0;
						int count = checked(CVS_FL_LBS.AllPartInfoDataTable.__ENCList.Count - 1);
						for (int i = 0; i <= count; i = checked(i + 1))
						{
							if (CVS_FL_LBS.AllPartInfoDataTable.__ENCList[i].IsAlive)
							{
								if (i != item)
								{
									CVS_FL_LBS.AllPartInfoDataTable.__ENCList[item] = CVS_FL_LBS.AllPartInfoDataTable.__ENCList[i];
								}
								item = checked(item + 1);
							}
						}
						CVS_FL_LBS.AllPartInfoDataTable.__ENCList.RemoveRange(item, checked(CVS_FL_LBS.AllPartInfoDataTable.__ENCList.Count - item));
						CVS_FL_LBS.AllPartInfoDataTable.__ENCList.Capacity = CVS_FL_LBS.AllPartInfoDataTable.__ENCList.Count;
					}
					CVS_FL_LBS.AllPartInfoDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddAllPartInfoRow(CVS_FL_LBS.AllPartInfoRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.AllPartInfoRow AddAllPartInfoRow(decimal ZZTLP_REF, decimal ZZTL_REF, decimal ZZTLP_QNTY, string ZZHTLP_PARTNUMBER, string ZZHTLP_LOCATION, string ZZHTLP_DESCRIPTION, decimal ZZTL_REF1, string ZZTL_STATE, string ZZTL_WOTYPE, string ZZTL_WOASSET, string ZZTL_WOCOMPLAINT, string ZZTL_WOROOTCAUSE, string ZZTL_WOCORRECTION, string ZZTL_GENUSER, DateTime ZZTL_GENDATE, string ZZTL_MODUSER, DateTime ZZTL_MODDATE)
			{
				CVS_FL_LBS.AllPartInfoRow rowAllPartInfoRow = (CVS_FL_LBS.AllPartInfoRow)this.NewRow();
				object[] zZTLPREF = new object[] { ZZTLP_REF, ZZTL_REF, ZZTLP_QNTY, ZZHTLP_PARTNUMBER, ZZHTLP_LOCATION, ZZHTLP_DESCRIPTION, ZZTL_REF1, ZZTL_STATE, ZZTL_WOTYPE, ZZTL_WOASSET, ZZTL_WOCOMPLAINT, ZZTL_WOROOTCAUSE, ZZTL_WOCORRECTION, ZZTL_GENUSER, ZZTL_GENDATE, ZZTL_MODUSER, ZZTL_MODDATE };
				rowAllPartInfoRow.ItemArray = zZTLPREF;
				this.Rows.Add(rowAllPartInfoRow);
				return rowAllPartInfoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				CVS_FL_LBS.AllPartInfoDataTable cln = (CVS_FL_LBS.AllPartInfoDataTable)base.Clone();
				cln.InitVars();
				return cln;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new CVS_FL_LBS.AllPartInfoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(CVS_FL_LBS.AllPartInfoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType GetTypedTableSchema;
				XmlSchemaComplexType type = new XmlSchemaComplexType();
				XmlSchemaSequence sequence = new XmlSchemaSequence();
				CVS_FL_LBS ds = new CVS_FL_LBS();
				XmlSchemaAny any1 = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema"
				};
				decimal num = new decimal(0);
				any1.MinOccurs = num;
				any1.MaxOccurs = new decimal(-1, -1, -1, false, 0);
				any1.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any1);
				XmlSchemaAny any2 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				};
				num = new decimal(1);
				any2.MinOccurs = num;
				any2.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any2);
				XmlSchemaAttribute attribute1 = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = ds.Namespace
				};
				type.Attributes.Add(attribute1);
				XmlSchemaAttribute attribute2 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "AllPartInfoDataTable"
				};
				type.Attributes.Add(attribute2);
				type.Particle = sequence;
				XmlSchema dsSchema = ds.GetSchemaSerializable();
				if (xs.Contains(dsSchema.TargetNamespace))
				{
					MemoryStream s1 = new MemoryStream();
					MemoryStream s2 = new MemoryStream();
					try
					{
						XmlSchema schema = null;
						dsSchema.Write(s1);
						IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
						while (schemas.MoveNext())
						{
							schema = (XmlSchema)schemas.Current;
							s2.SetLength((long)0);
							schema.Write(s2);
							if (s1.Length == s2.Length)
							{
								s1.Position = (long)0;
								s2.Position = (long)0;
								while (true)
								{
									if ((s1.Position == s1.Length || s1.ReadByte() != s2.ReadByte() ? true : false))
									{
										break;
									}
								}
								if (s1.Position == s1.Length)
								{
									GetTypedTableSchema = type;
									return GetTypedTableSchema;
								}
							}
						}
					}
					finally
					{
						if (s1 != null)
						{
							s1.Close();
						}
						if (s2 != null)
						{
							s2.Close();
						}
					}
				}
				xs.Add(dsSchema);
				GetTypedTableSchema = type;
				return GetTypedTableSchema;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnZZTLP_REF = new DataColumn("ZZTLP_REF", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLP_REF);
				this.columnZZTL_REF = new DataColumn("ZZTL_REF", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_REF);
				this.columnZZTLP_QNTY = new DataColumn("ZZTLP_QNTY", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLP_QNTY);
				this.columnZZHTLP_PARTNUMBER = new DataColumn("ZZHTLP_PARTNUMBER", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZHTLP_PARTNUMBER);
				this.columnZZHTLP_LOCATION = new DataColumn("ZZHTLP_LOCATION", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZHTLP_LOCATION);
				this.columnZZHTLP_DESCRIPTION = new DataColumn("ZZHTLP_DESCRIPTION", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZHTLP_DESCRIPTION);
				this.columnZZTL_REF1 = new DataColumn("ZZTL_REF1", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_REF1);
				this.columnZZTL_STATE = new DataColumn("ZZTL_STATE", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_STATE);
				this.columnZZTL_WOTYPE = new DataColumn("ZZTL_WOTYPE", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOTYPE);
				this.columnZZTL_WOASSET = new DataColumn("ZZTL_WOASSET", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOASSET);
				this.columnZZTL_WOCOMPLAINT = new DataColumn("ZZTL_WOCOMPLAINT", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOCOMPLAINT);
				this.columnZZTL_WOROOTCAUSE = new DataColumn("ZZTL_WOROOTCAUSE", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOROOTCAUSE);
				this.columnZZTL_WOCORRECTION = new DataColumn("ZZTL_WOCORRECTION", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOCORRECTION);
				this.columnZZTL_GENUSER = new DataColumn("ZZTL_GENUSER", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_GENUSER);
				this.columnZZTL_GENDATE = new DataColumn("ZZTL_GENDATE", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_GENDATE);
				this.columnZZTL_MODUSER = new DataColumn("ZZTL_MODUSER", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_MODUSER);
				this.columnZZTL_MODDATE = new DataColumn("ZZTL_MODDATE", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_MODDATE);
				this.columnZZTLP_REF.AllowDBNull = false;
				this.columnZZHTLP_PARTNUMBER.MaxLength = 20;
				this.columnZZHTLP_LOCATION.MaxLength = 20;
				this.columnZZHTLP_DESCRIPTION.MaxLength = 200;
				this.columnZZTL_REF1.AllowDBNull = false;
				this.columnZZTL_STATE.MaxLength = 20;
				this.columnZZTL_WOTYPE.MaxLength = 30;
				this.columnZZTL_WOASSET.MaxLength = 50;
				this.columnZZTL_WOCOMPLAINT.MaxLength = 2000;
				this.columnZZTL_WOROOTCAUSE.MaxLength = 2000;
				this.columnZZTL_WOCORRECTION.MaxLength = 2000;
				this.columnZZTL_GENUSER.MaxLength = 20;
				this.columnZZTL_MODUSER.MaxLength = 20;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnZZTLP_REF = base.Columns["ZZTLP_REF"];
				this.columnZZTL_REF = base.Columns["ZZTL_REF"];
				this.columnZZTLP_QNTY = base.Columns["ZZTLP_QNTY"];
				this.columnZZHTLP_PARTNUMBER = base.Columns["ZZHTLP_PARTNUMBER"];
				this.columnZZHTLP_LOCATION = base.Columns["ZZHTLP_LOCATION"];
				this.columnZZHTLP_DESCRIPTION = base.Columns["ZZHTLP_DESCRIPTION"];
				this.columnZZTL_REF1 = base.Columns["ZZTL_REF1"];
				this.columnZZTL_STATE = base.Columns["ZZTL_STATE"];
				this.columnZZTL_WOTYPE = base.Columns["ZZTL_WOTYPE"];
				this.columnZZTL_WOASSET = base.Columns["ZZTL_WOASSET"];
				this.columnZZTL_WOCOMPLAINT = base.Columns["ZZTL_WOCOMPLAINT"];
				this.columnZZTL_WOROOTCAUSE = base.Columns["ZZTL_WOROOTCAUSE"];
				this.columnZZTL_WOCORRECTION = base.Columns["ZZTL_WOCORRECTION"];
				this.columnZZTL_GENUSER = base.Columns["ZZTL_GENUSER"];
				this.columnZZTL_GENDATE = base.Columns["ZZTL_GENDATE"];
				this.columnZZTL_MODUSER = base.Columns["ZZTL_MODUSER"];
				this.columnZZTL_MODDATE = base.Columns["ZZTL_MODDATE"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.AllPartInfoRow NewAllPartInfoRow()
			{
				return (CVS_FL_LBS.AllPartInfoRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CVS_FL_LBS.AllPartInfoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.AllPartInfoRowChanged != null)
				{
					CVS_FL_LBS.AllPartInfoRowChangeEventHandler allPartInfoRowChangeEventHandler = this.AllPartInfoRowChanged;
					if (allPartInfoRowChangeEventHandler != null)
					{
						allPartInfoRowChangeEventHandler(this, new CVS_FL_LBS.AllPartInfoRowChangeEvent((CVS_FL_LBS.AllPartInfoRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.AllPartInfoRowChanging != null)
				{
					CVS_FL_LBS.AllPartInfoRowChangeEventHandler allPartInfoRowChangeEventHandler = this.AllPartInfoRowChanging;
					if (allPartInfoRowChangeEventHandler != null)
					{
						allPartInfoRowChangeEventHandler(this, new CVS_FL_LBS.AllPartInfoRowChangeEvent((CVS_FL_LBS.AllPartInfoRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.AllPartInfoRowDeleted != null)
				{
					CVS_FL_LBS.AllPartInfoRowChangeEventHandler allPartInfoRowChangeEventHandler = this.AllPartInfoRowDeleted;
					if (allPartInfoRowChangeEventHandler != null)
					{
						allPartInfoRowChangeEventHandler(this, new CVS_FL_LBS.AllPartInfoRowChangeEvent((CVS_FL_LBS.AllPartInfoRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.AllPartInfoRowDeleting != null)
				{
					CVS_FL_LBS.AllPartInfoRowChangeEventHandler allPartInfoRowChangeEventHandler = this.AllPartInfoRowDeleting;
					if (allPartInfoRowChangeEventHandler != null)
					{
						allPartInfoRowChangeEventHandler(this, new CVS_FL_LBS.AllPartInfoRowChangeEvent((CVS_FL_LBS.AllPartInfoRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveAllPartInfoRow(CVS_FL_LBS.AllPartInfoRow row)
			{
				this.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.AllPartInfoRowChangeEventHandler AllPartInfoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.AllPartInfoRowChangeEventHandler AllPartInfoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.AllPartInfoRowChangeEventHandler AllPartInfoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.AllPartInfoRowChangeEventHandler AllPartInfoRowDeleting;
		}

		public class AllPartInfoRow : DataRow
		{
			private CVS_FL_LBS.AllPartInfoDataTable tableAllPartInfo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZHTLP_DESCRIPTION
			{
				get
				{
					string ZZHTLP_DESCRIPTION;
					try
					{
						ZZHTLP_DESCRIPTION = Conversions.ToString(this[this.tableAllPartInfo.ZZHTLP_DESCRIPTIONColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZHTLP_DESCRIPTION' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZHTLP_DESCRIPTION;
				}
				set
				{
					this[this.tableAllPartInfo.ZZHTLP_DESCRIPTIONColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZHTLP_LOCATION
			{
				get
				{
					string ZZHTLP_LOCATION;
					try
					{
						ZZHTLP_LOCATION = Conversions.ToString(this[this.tableAllPartInfo.ZZHTLP_LOCATIONColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZHTLP_LOCATION' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZHTLP_LOCATION;
				}
				set
				{
					this[this.tableAllPartInfo.ZZHTLP_LOCATIONColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZHTLP_PARTNUMBER
			{
				get
				{
					string ZZHTLP_PARTNUMBER;
					try
					{
						ZZHTLP_PARTNUMBER = Conversions.ToString(this[this.tableAllPartInfo.ZZHTLP_PARTNUMBERColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZHTLP_PARTNUMBER' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZHTLP_PARTNUMBER;
				}
				set
				{
					this[this.tableAllPartInfo.ZZHTLP_PARTNUMBERColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime ZZTL_GENDATE
			{
				get
				{
					DateTime ZZTL_GENDATE;
					try
					{
						ZZTL_GENDATE = Conversions.ToDate(this[this.tableAllPartInfo.ZZTL_GENDATEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_GENDATE' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_GENDATE;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_GENDATEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_GENUSER
			{
				get
				{
					string ZZTL_GENUSER;
					try
					{
						ZZTL_GENUSER = Conversions.ToString(this[this.tableAllPartInfo.ZZTL_GENUSERColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_GENUSER' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_GENUSER;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_GENUSERColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime ZZTL_MODDATE
			{
				get
				{
					DateTime ZZTL_MODDATE;
					try
					{
						ZZTL_MODDATE = Conversions.ToDate(this[this.tableAllPartInfo.ZZTL_MODDATEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_MODDATE' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_MODDATE;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_MODDATEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_MODUSER
			{
				get
				{
					string ZZTL_MODUSER;
					try
					{
						ZZTL_MODUSER = Conversions.ToString(this[this.tableAllPartInfo.ZZTL_MODUSERColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_MODUSER' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_MODUSER;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_MODUSERColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTL_REF
			{
				get
				{
					decimal ZZTL_REF;
					try
					{
						ZZTL_REF = Conversions.ToDecimal(this[this.tableAllPartInfo.ZZTL_REFColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_REF' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_REF;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_REFColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTL_REF1
			{
				get
				{
					return Conversions.ToDecimal(this[this.tableAllPartInfo.ZZTL_REF1Column]);
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_REF1Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_STATE
			{
				get
				{
					string ZZTL_STATE;
					try
					{
						ZZTL_STATE = Conversions.ToString(this[this.tableAllPartInfo.ZZTL_STATEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_STATE' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_STATE;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_STATEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOASSET
			{
				get
				{
					string ZZTL_WOASSET;
					try
					{
						ZZTL_WOASSET = Conversions.ToString(this[this.tableAllPartInfo.ZZTL_WOASSETColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOASSET' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOASSET;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_WOASSETColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOCOMPLAINT
			{
				get
				{
					string ZZTL_WOCOMPLAINT;
					try
					{
						ZZTL_WOCOMPLAINT = Conversions.ToString(this[this.tableAllPartInfo.ZZTL_WOCOMPLAINTColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOCOMPLAINT' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOCOMPLAINT;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_WOCOMPLAINTColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOCORRECTION
			{
				get
				{
					string ZZTL_WOCORRECTION;
					try
					{
						ZZTL_WOCORRECTION = Conversions.ToString(this[this.tableAllPartInfo.ZZTL_WOCORRECTIONColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOCORRECTION' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOCORRECTION;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_WOCORRECTIONColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOROOTCAUSE
			{
				get
				{
					string ZZTL_WOROOTCAUSE;
					try
					{
						ZZTL_WOROOTCAUSE = Conversions.ToString(this[this.tableAllPartInfo.ZZTL_WOROOTCAUSEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOROOTCAUSE' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOROOTCAUSE;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_WOROOTCAUSEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOTYPE
			{
				get
				{
					string ZZTL_WOTYPE;
					try
					{
						ZZTL_WOTYPE = Conversions.ToString(this[this.tableAllPartInfo.ZZTL_WOTYPEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOTYPE' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOTYPE;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTL_WOTYPEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLP_QNTY
			{
				get
				{
					decimal ZZTLP_QNTY;
					try
					{
						ZZTLP_QNTY = Conversions.ToDecimal(this[this.tableAllPartInfo.ZZTLP_QNTYColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTLP_QNTY' in table 'AllPartInfo' is DBNull.", invalidCastException);
					}
					return ZZTLP_QNTY;
				}
				set
				{
					this[this.tableAllPartInfo.ZZTLP_QNTYColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLP_REF
			{
				get
				{
					return Conversions.ToDecimal(this[this.tableAllPartInfo.ZZTLP_REFColumn]);
				}
				set
				{
					this[this.tableAllPartInfo.ZZTLP_REFColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal AllPartInfoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableAllPartInfo = (CVS_FL_LBS.AllPartInfoDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZHTLP_DESCRIPTIONNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZHTLP_DESCRIPTIONColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZHTLP_LOCATIONNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZHTLP_LOCATIONColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZHTLP_PARTNUMBERNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZHTLP_PARTNUMBERColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_GENDATENull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_GENDATEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_GENUSERNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_GENUSERColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_MODDATENull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_MODDATEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_MODUSERNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_MODUSERColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_REFNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_REFColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_STATENull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_STATEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOASSETNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_WOASSETColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOCOMPLAINTNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_WOCOMPLAINTColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOCORRECTIONNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_WOCORRECTIONColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOROOTCAUSENull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_WOROOTCAUSEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOTYPENull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTL_WOTYPEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTLP_QNTYNull()
			{
				return this.IsNull(this.tableAllPartInfo.ZZTLP_QNTYColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZHTLP_DESCRIPTIONNull()
			{
				this[this.tableAllPartInfo.ZZHTLP_DESCRIPTIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZHTLP_LOCATIONNull()
			{
				this[this.tableAllPartInfo.ZZHTLP_LOCATIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZHTLP_PARTNUMBERNull()
			{
				this[this.tableAllPartInfo.ZZHTLP_PARTNUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_GENDATENull()
			{
				this[this.tableAllPartInfo.ZZTL_GENDATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_GENUSERNull()
			{
				this[this.tableAllPartInfo.ZZTL_GENUSERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_MODDATENull()
			{
				this[this.tableAllPartInfo.ZZTL_MODDATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_MODUSERNull()
			{
				this[this.tableAllPartInfo.ZZTL_MODUSERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_REFNull()
			{
				this[this.tableAllPartInfo.ZZTL_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_STATENull()
			{
				this[this.tableAllPartInfo.ZZTL_STATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOASSETNull()
			{
				this[this.tableAllPartInfo.ZZTL_WOASSETColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOCOMPLAINTNull()
			{
				this[this.tableAllPartInfo.ZZTL_WOCOMPLAINTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOCORRECTIONNull()
			{
				this[this.tableAllPartInfo.ZZTL_WOCORRECTIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOROOTCAUSENull()
			{
				this[this.tableAllPartInfo.ZZTL_WOROOTCAUSEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOTYPENull()
			{
				this[this.tableAllPartInfo.ZZTL_WOTYPEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTLP_QNTYNull()
			{
				this[this.tableAllPartInfo.ZZTLP_QNTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class AllPartInfoRowChangeEvent : EventArgs
		{
			private CVS_FL_LBS.AllPartInfoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.AllPartInfoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public AllPartInfoRowChangeEvent(CVS_FL_LBS.AllPartInfoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void AllPartInfoRowChangeEventHandler(object sender, CVS_FL_LBS.AllPartInfoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class AllTechInfoDataTable : TypedTableBase<CVS_FL_LBS.AllTechInfoRow>
		{
			private static List<WeakReference> __ENCList;

			private DataColumn columnZZTLU_REF;

			private DataColumn columnZZTL_REF;

			private DataColumn columnZZTLU_NAME;

			private DataColumn columnZZTLU_TIME;

			private DataColumn columnZZTLU_SHIFT;

			private DataColumn columnZZTL_REF1;

			private DataColumn columnZZTL_STATE;

			private DataColumn columnZZTL_WOTYPE;

			private DataColumn columnZZTL_WOASSET;

			private DataColumn columnZZTL_WOCOMPLAINT;

			private DataColumn columnZZTL_WOROOTCAUSE;

			private DataColumn columnZZTL_WOCORRECTION;

			private DataColumn columnZZTL_GENUSER;

			private DataColumn columnZZTL_GENDATE;

			private DataColumn columnZZTL_MODUSER;

			private DataColumn columnZZTL_MODDATE;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.AllTechInfoRow this[int index]
			{
				get
				{
					return (CVS_FL_LBS.AllTechInfoRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_GENDATEColumn
			{
				get
				{
					return this.columnZZTL_GENDATE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_GENUSERColumn
			{
				get
				{
					return this.columnZZTL_GENUSER;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_MODDATEColumn
			{
				get
				{
					return this.columnZZTL_MODDATE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_MODUSERColumn
			{
				get
				{
					return this.columnZZTL_MODUSER;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_REF1Column
			{
				get
				{
					return this.columnZZTL_REF1;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_REFColumn
			{
				get
				{
					return this.columnZZTL_REF;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_STATEColumn
			{
				get
				{
					return this.columnZZTL_STATE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOASSETColumn
			{
				get
				{
					return this.columnZZTL_WOASSET;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOCOMPLAINTColumn
			{
				get
				{
					return this.columnZZTL_WOCOMPLAINT;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOCORRECTIONColumn
			{
				get
				{
					return this.columnZZTL_WOCORRECTION;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOROOTCAUSEColumn
			{
				get
				{
					return this.columnZZTL_WOROOTCAUSE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_WOTYPEColumn
			{
				get
				{
					return this.columnZZTL_WOTYPE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLU_NAMEColumn
			{
				get
				{
					return this.columnZZTLU_NAME;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLU_REFColumn
			{
				get
				{
					return this.columnZZTLU_REF;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLU_SHIFTColumn
			{
				get
				{
					return this.columnZZTLU_SHIFT;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLU_TIMEColumn
			{
				get
				{
					return this.columnZZTLU_TIME;
				}
			}

			[DebuggerNonUserCode]
			static AllTechInfoDataTable()
			{
				CVS_FL_LBS.AllTechInfoDataTable.__ENCList = new List<WeakReference>();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public AllTechInfoDataTable()
			{
				CVS_FL_LBS.AllTechInfoDataTable.__ENCAddToList(this);
				this.TableName = "AllTechInfo";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal AllTechInfoDataTable(DataTable table)
			{
				CVS_FL_LBS.AllTechInfoDataTable.__ENCAddToList(this);
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected AllTechInfoDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				CVS_FL_LBS.AllTechInfoDataTable.__ENCAddToList(this);
				this.InitVars();
			}

			[DebuggerNonUserCode]
			private static void __ENCAddToList(object value)
			{
				lock (CVS_FL_LBS.AllTechInfoDataTable.__ENCList)
				{
					if (CVS_FL_LBS.AllTechInfoDataTable.__ENCList.Count == CVS_FL_LBS.AllTechInfoDataTable.__ENCList.Capacity)
					{
						int item = 0;
						int count = checked(CVS_FL_LBS.AllTechInfoDataTable.__ENCList.Count - 1);
						for (int i = 0; i <= count; i = checked(i + 1))
						{
							if (CVS_FL_LBS.AllTechInfoDataTable.__ENCList[i].IsAlive)
							{
								if (i != item)
								{
									CVS_FL_LBS.AllTechInfoDataTable.__ENCList[item] = CVS_FL_LBS.AllTechInfoDataTable.__ENCList[i];
								}
								item = checked(item + 1);
							}
						}
						CVS_FL_LBS.AllTechInfoDataTable.__ENCList.RemoveRange(item, checked(CVS_FL_LBS.AllTechInfoDataTable.__ENCList.Count - item));
						CVS_FL_LBS.AllTechInfoDataTable.__ENCList.Capacity = CVS_FL_LBS.AllTechInfoDataTable.__ENCList.Count;
					}
					CVS_FL_LBS.AllTechInfoDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddAllTechInfoRow(CVS_FL_LBS.AllTechInfoRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.AllTechInfoRow AddAllTechInfoRow(decimal ZZTLU_REF, decimal ZZTL_REF, string ZZTLU_NAME, decimal ZZTLU_TIME, decimal ZZTLU_SHIFT, decimal ZZTL_REF1, string ZZTL_STATE, string ZZTL_WOTYPE, string ZZTL_WOASSET, string ZZTL_WOCOMPLAINT, string ZZTL_WOROOTCAUSE, string ZZTL_WOCORRECTION, string ZZTL_GENUSER, DateTime ZZTL_GENDATE, string ZZTL_MODUSER, DateTime ZZTL_MODDATE)
			{
				CVS_FL_LBS.AllTechInfoRow rowAllTechInfoRow = (CVS_FL_LBS.AllTechInfoRow)this.NewRow();
				object[] zZTLUREF = new object[] { ZZTLU_REF, ZZTL_REF, ZZTLU_NAME, ZZTLU_TIME, ZZTLU_SHIFT, ZZTL_REF1, ZZTL_STATE, ZZTL_WOTYPE, ZZTL_WOASSET, ZZTL_WOCOMPLAINT, ZZTL_WOROOTCAUSE, ZZTL_WOCORRECTION, ZZTL_GENUSER, ZZTL_GENDATE, ZZTL_MODUSER, ZZTL_MODDATE };
				rowAllTechInfoRow.ItemArray = zZTLUREF;
				this.Rows.Add(rowAllTechInfoRow);
				return rowAllTechInfoRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				CVS_FL_LBS.AllTechInfoDataTable cln = (CVS_FL_LBS.AllTechInfoDataTable)base.Clone();
				cln.InitVars();
				return cln;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new CVS_FL_LBS.AllTechInfoDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(CVS_FL_LBS.AllTechInfoRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType GetTypedTableSchema;
				XmlSchemaComplexType type = new XmlSchemaComplexType();
				XmlSchemaSequence sequence = new XmlSchemaSequence();
				CVS_FL_LBS ds = new CVS_FL_LBS();
				XmlSchemaAny any1 = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema"
				};
				decimal num = new decimal(0);
				any1.MinOccurs = num;
				any1.MaxOccurs = new decimal(-1, -1, -1, false, 0);
				any1.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any1);
				XmlSchemaAny any2 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				};
				num = new decimal(1);
				any2.MinOccurs = num;
				any2.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any2);
				XmlSchemaAttribute attribute1 = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = ds.Namespace
				};
				type.Attributes.Add(attribute1);
				XmlSchemaAttribute attribute2 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "AllTechInfoDataTable"
				};
				type.Attributes.Add(attribute2);
				type.Particle = sequence;
				XmlSchema dsSchema = ds.GetSchemaSerializable();
				if (xs.Contains(dsSchema.TargetNamespace))
				{
					MemoryStream s1 = new MemoryStream();
					MemoryStream s2 = new MemoryStream();
					try
					{
						XmlSchema schema = null;
						dsSchema.Write(s1);
						IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
						while (schemas.MoveNext())
						{
							schema = (XmlSchema)schemas.Current;
							s2.SetLength((long)0);
							schema.Write(s2);
							if (s1.Length == s2.Length)
							{
								s1.Position = (long)0;
								s2.Position = (long)0;
								while (true)
								{
									if ((s1.Position == s1.Length || s1.ReadByte() != s2.ReadByte() ? true : false))
									{
										break;
									}
								}
								if (s1.Position == s1.Length)
								{
									GetTypedTableSchema = type;
									return GetTypedTableSchema;
								}
							}
						}
					}
					finally
					{
						if (s1 != null)
						{
							s1.Close();
						}
						if (s2 != null)
						{
							s2.Close();
						}
					}
				}
				xs.Add(dsSchema);
				GetTypedTableSchema = type;
				return GetTypedTableSchema;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnZZTLU_REF = new DataColumn("ZZTLU_REF", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLU_REF);
				this.columnZZTL_REF = new DataColumn("ZZTL_REF", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_REF);
				this.columnZZTLU_NAME = new DataColumn("ZZTLU_NAME", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLU_NAME);
				this.columnZZTLU_TIME = new DataColumn("ZZTLU_TIME", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLU_TIME);
				this.columnZZTLU_SHIFT = new DataColumn("ZZTLU_SHIFT", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLU_SHIFT);
				this.columnZZTL_REF1 = new DataColumn("ZZTL_REF1", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_REF1);
				this.columnZZTL_STATE = new DataColumn("ZZTL_STATE", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_STATE);
				this.columnZZTL_WOTYPE = new DataColumn("ZZTL_WOTYPE", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOTYPE);
				this.columnZZTL_WOASSET = new DataColumn("ZZTL_WOASSET", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOASSET);
				this.columnZZTL_WOCOMPLAINT = new DataColumn("ZZTL_WOCOMPLAINT", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOCOMPLAINT);
				this.columnZZTL_WOROOTCAUSE = new DataColumn("ZZTL_WOROOTCAUSE", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOROOTCAUSE);
				this.columnZZTL_WOCORRECTION = new DataColumn("ZZTL_WOCORRECTION", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_WOCORRECTION);
				this.columnZZTL_GENUSER = new DataColumn("ZZTL_GENUSER", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_GENUSER);
				this.columnZZTL_GENDATE = new DataColumn("ZZTL_GENDATE", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_GENDATE);
				this.columnZZTL_MODUSER = new DataColumn("ZZTL_MODUSER", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_MODUSER);
				this.columnZZTL_MODDATE = new DataColumn("ZZTL_MODDATE", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_MODDATE);
				this.columnZZTLU_REF.AllowDBNull = false;
				this.columnZZTLU_NAME.MaxLength = 50;
				this.columnZZTL_REF1.AllowDBNull = false;
				this.columnZZTL_STATE.MaxLength = 20;
				this.columnZZTL_WOTYPE.MaxLength = 30;
				this.columnZZTL_WOASSET.MaxLength = 50;
				this.columnZZTL_WOCOMPLAINT.MaxLength = 2000;
				this.columnZZTL_WOROOTCAUSE.MaxLength = 2000;
				this.columnZZTL_WOCORRECTION.MaxLength = 2000;
				this.columnZZTL_GENUSER.MaxLength = 20;
				this.columnZZTL_MODUSER.MaxLength = 20;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnZZTLU_REF = base.Columns["ZZTLU_REF"];
				this.columnZZTL_REF = base.Columns["ZZTL_REF"];
				this.columnZZTLU_NAME = base.Columns["ZZTLU_NAME"];
				this.columnZZTLU_TIME = base.Columns["ZZTLU_TIME"];
				this.columnZZTLU_SHIFT = base.Columns["ZZTLU_SHIFT"];
				this.columnZZTL_REF1 = base.Columns["ZZTL_REF1"];
				this.columnZZTL_STATE = base.Columns["ZZTL_STATE"];
				this.columnZZTL_WOTYPE = base.Columns["ZZTL_WOTYPE"];
				this.columnZZTL_WOASSET = base.Columns["ZZTL_WOASSET"];
				this.columnZZTL_WOCOMPLAINT = base.Columns["ZZTL_WOCOMPLAINT"];
				this.columnZZTL_WOROOTCAUSE = base.Columns["ZZTL_WOROOTCAUSE"];
				this.columnZZTL_WOCORRECTION = base.Columns["ZZTL_WOCORRECTION"];
				this.columnZZTL_GENUSER = base.Columns["ZZTL_GENUSER"];
				this.columnZZTL_GENDATE = base.Columns["ZZTL_GENDATE"];
				this.columnZZTL_MODUSER = base.Columns["ZZTL_MODUSER"];
				this.columnZZTL_MODDATE = base.Columns["ZZTL_MODDATE"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.AllTechInfoRow NewAllTechInfoRow()
			{
				return (CVS_FL_LBS.AllTechInfoRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CVS_FL_LBS.AllTechInfoRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.AllTechInfoRowChanged != null)
				{
					CVS_FL_LBS.AllTechInfoRowChangeEventHandler allTechInfoRowChangeEventHandler = this.AllTechInfoRowChanged;
					if (allTechInfoRowChangeEventHandler != null)
					{
						allTechInfoRowChangeEventHandler(this, new CVS_FL_LBS.AllTechInfoRowChangeEvent((CVS_FL_LBS.AllTechInfoRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.AllTechInfoRowChanging != null)
				{
					CVS_FL_LBS.AllTechInfoRowChangeEventHandler allTechInfoRowChangeEventHandler = this.AllTechInfoRowChanging;
					if (allTechInfoRowChangeEventHandler != null)
					{
						allTechInfoRowChangeEventHandler(this, new CVS_FL_LBS.AllTechInfoRowChangeEvent((CVS_FL_LBS.AllTechInfoRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.AllTechInfoRowDeleted != null)
				{
					CVS_FL_LBS.AllTechInfoRowChangeEventHandler allTechInfoRowChangeEventHandler = this.AllTechInfoRowDeleted;
					if (allTechInfoRowChangeEventHandler != null)
					{
						allTechInfoRowChangeEventHandler(this, new CVS_FL_LBS.AllTechInfoRowChangeEvent((CVS_FL_LBS.AllTechInfoRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.AllTechInfoRowDeleting != null)
				{
					CVS_FL_LBS.AllTechInfoRowChangeEventHandler allTechInfoRowChangeEventHandler = this.AllTechInfoRowDeleting;
					if (allTechInfoRowChangeEventHandler != null)
					{
						allTechInfoRowChangeEventHandler(this, new CVS_FL_LBS.AllTechInfoRowChangeEvent((CVS_FL_LBS.AllTechInfoRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveAllTechInfoRow(CVS_FL_LBS.AllTechInfoRow row)
			{
				this.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.AllTechInfoRowChangeEventHandler AllTechInfoRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.AllTechInfoRowChangeEventHandler AllTechInfoRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.AllTechInfoRowChangeEventHandler AllTechInfoRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.AllTechInfoRowChangeEventHandler AllTechInfoRowDeleting;
		}

		public class AllTechInfoRow : DataRow
		{
			private CVS_FL_LBS.AllTechInfoDataTable tableAllTechInfo;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime ZZTL_GENDATE
			{
				get
				{
					DateTime ZZTL_GENDATE;
					try
					{
						ZZTL_GENDATE = Conversions.ToDate(this[this.tableAllTechInfo.ZZTL_GENDATEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_GENDATE' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_GENDATE;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_GENDATEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_GENUSER
			{
				get
				{
					string ZZTL_GENUSER;
					try
					{
						ZZTL_GENUSER = Conversions.ToString(this[this.tableAllTechInfo.ZZTL_GENUSERColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_GENUSER' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_GENUSER;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_GENUSERColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime ZZTL_MODDATE
			{
				get
				{
					DateTime ZZTL_MODDATE;
					try
					{
						ZZTL_MODDATE = Conversions.ToDate(this[this.tableAllTechInfo.ZZTL_MODDATEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_MODDATE' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_MODDATE;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_MODDATEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_MODUSER
			{
				get
				{
					string ZZTL_MODUSER;
					try
					{
						ZZTL_MODUSER = Conversions.ToString(this[this.tableAllTechInfo.ZZTL_MODUSERColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_MODUSER' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_MODUSER;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_MODUSERColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTL_REF
			{
				get
				{
					decimal ZZTL_REF;
					try
					{
						ZZTL_REF = Conversions.ToDecimal(this[this.tableAllTechInfo.ZZTL_REFColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_REF' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_REF;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_REFColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTL_REF1
			{
				get
				{
					return Conversions.ToDecimal(this[this.tableAllTechInfo.ZZTL_REF1Column]);
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_REF1Column] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_STATE
			{
				get
				{
					string ZZTL_STATE;
					try
					{
						ZZTL_STATE = Conversions.ToString(this[this.tableAllTechInfo.ZZTL_STATEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_STATE' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_STATE;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_STATEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOASSET
			{
				get
				{
					string ZZTL_WOASSET;
					try
					{
						ZZTL_WOASSET = Conversions.ToString(this[this.tableAllTechInfo.ZZTL_WOASSETColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOASSET' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOASSET;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_WOASSETColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOCOMPLAINT
			{
				get
				{
					string ZZTL_WOCOMPLAINT;
					try
					{
						ZZTL_WOCOMPLAINT = Conversions.ToString(this[this.tableAllTechInfo.ZZTL_WOCOMPLAINTColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOCOMPLAINT' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOCOMPLAINT;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_WOCOMPLAINTColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOCORRECTION
			{
				get
				{
					string ZZTL_WOCORRECTION;
					try
					{
						ZZTL_WOCORRECTION = Conversions.ToString(this[this.tableAllTechInfo.ZZTL_WOCORRECTIONColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOCORRECTION' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOCORRECTION;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_WOCORRECTIONColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOROOTCAUSE
			{
				get
				{
					string ZZTL_WOROOTCAUSE;
					try
					{
						ZZTL_WOROOTCAUSE = Conversions.ToString(this[this.tableAllTechInfo.ZZTL_WOROOTCAUSEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOROOTCAUSE' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOROOTCAUSE;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_WOROOTCAUSEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTL_WOTYPE
			{
				get
				{
					string ZZTL_WOTYPE;
					try
					{
						ZZTL_WOTYPE = Conversions.ToString(this[this.tableAllTechInfo.ZZTL_WOTYPEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_WOTYPE' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTL_WOTYPE;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTL_WOTYPEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTLU_NAME
			{
				get
				{
					string ZZTLU_NAME;
					try
					{
						ZZTLU_NAME = Conversions.ToString(this[this.tableAllTechInfo.ZZTLU_NAMEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTLU_NAME' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTLU_NAME;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTLU_NAMEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLU_REF
			{
				get
				{
					return Conversions.ToDecimal(this[this.tableAllTechInfo.ZZTLU_REFColumn]);
				}
				set
				{
					this[this.tableAllTechInfo.ZZTLU_REFColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLU_SHIFT
			{
				get
				{
					decimal ZZTLU_SHIFT;
					try
					{
						ZZTLU_SHIFT = Conversions.ToDecimal(this[this.tableAllTechInfo.ZZTLU_SHIFTColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTLU_SHIFT' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTLU_SHIFT;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTLU_SHIFTColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLU_TIME
			{
				get
				{
					decimal ZZTLU_TIME;
					try
					{
						ZZTLU_TIME = Conversions.ToDecimal(this[this.tableAllTechInfo.ZZTLU_TIMEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTLU_TIME' in table 'AllTechInfo' is DBNull.", invalidCastException);
					}
					return ZZTLU_TIME;
				}
				set
				{
					this[this.tableAllTechInfo.ZZTLU_TIMEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal AllTechInfoRow(DataRowBuilder rb) : base(rb)
			{
				this.tableAllTechInfo = (CVS_FL_LBS.AllTechInfoDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_GENDATENull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_GENDATEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_GENUSERNull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_GENUSERColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_MODDATENull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_MODDATEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_MODUSERNull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_MODUSERColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_REFNull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_REFColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_STATENull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_STATEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOASSETNull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_WOASSETColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOCOMPLAINTNull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_WOCOMPLAINTColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOCORRECTIONNull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_WOCORRECTIONColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOROOTCAUSENull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_WOROOTCAUSEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_WOTYPENull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTL_WOTYPEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTLU_NAMENull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTLU_NAMEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTLU_SHIFTNull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTLU_SHIFTColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTLU_TIMENull()
			{
				return this.IsNull(this.tableAllTechInfo.ZZTLU_TIMEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_GENDATENull()
			{
				this[this.tableAllTechInfo.ZZTL_GENDATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_GENUSERNull()
			{
				this[this.tableAllTechInfo.ZZTL_GENUSERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_MODDATENull()
			{
				this[this.tableAllTechInfo.ZZTL_MODDATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_MODUSERNull()
			{
				this[this.tableAllTechInfo.ZZTL_MODUSERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_REFNull()
			{
				this[this.tableAllTechInfo.ZZTL_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_STATENull()
			{
				this[this.tableAllTechInfo.ZZTL_STATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOASSETNull()
			{
				this[this.tableAllTechInfo.ZZTL_WOASSETColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOCOMPLAINTNull()
			{
				this[this.tableAllTechInfo.ZZTL_WOCOMPLAINTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOCORRECTIONNull()
			{
				this[this.tableAllTechInfo.ZZTL_WOCORRECTIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOROOTCAUSENull()
			{
				this[this.tableAllTechInfo.ZZTL_WOROOTCAUSEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_WOTYPENull()
			{
				this[this.tableAllTechInfo.ZZTL_WOTYPEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTLU_NAMENull()
			{
				this[this.tableAllTechInfo.ZZTLU_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTLU_SHIFTNull()
			{
				this[this.tableAllTechInfo.ZZTLU_SHIFTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTLU_TIMENull()
			{
				this[this.tableAllTechInfo.ZZTLU_TIMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class AllTechInfoRowChangeEvent : EventArgs
		{
			private CVS_FL_LBS.AllTechInfoRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.AllTechInfoRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public AllTechInfoRowChangeEvent(CVS_FL_LBS.AllTechInfoRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void AllTechInfoRowChangeEventHandler(object sender, CVS_FL_LBS.AllTechInfoRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class ZZTECHLOG_PARTSDataTable : TypedTableBase<CVS_FL_LBS.ZZTECHLOG_PARTSRow>
		{
			private static List<WeakReference> __ENCList;

			private DataColumn columnZZTLP_REF;

			private DataColumn columnZZTL_REF;

			private DataColumn columnZZTLP_QNTY;

			private DataColumn columnZZHTLP_PARTNUMBER;

			private DataColumn columnZZHTLP_LOCATION;

			private DataColumn columnZZHTLP_DESCRIPTION;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOG_PARTSRow this[int index]
			{
				get
				{
					return (CVS_FL_LBS.ZZTECHLOG_PARTSRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZHTLP_DESCRIPTIONColumn
			{
				get
				{
					return this.columnZZHTLP_DESCRIPTION;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZHTLP_LOCATIONColumn
			{
				get
				{
					return this.columnZZHTLP_LOCATION;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZHTLP_PARTNUMBERColumn
			{
				get
				{
					return this.columnZZHTLP_PARTNUMBER;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_REFColumn
			{
				get
				{
					return this.columnZZTL_REF;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLP_QNTYColumn
			{
				get
				{
					return this.columnZZTLP_QNTY;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLP_REFColumn
			{
				get
				{
					return this.columnZZTLP_REF;
				}
			}

			[DebuggerNonUserCode]
			static ZZTECHLOG_PARTSDataTable()
			{
				CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList = new List<WeakReference>();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ZZTECHLOG_PARTSDataTable()
			{
				CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCAddToList(this);
				this.TableName = "ZZTECHLOG_PARTS";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal ZZTECHLOG_PARTSDataTable(DataTable table)
			{
				CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCAddToList(this);
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected ZZTECHLOG_PARTSDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCAddToList(this);
				this.InitVars();
			}

			[DebuggerNonUserCode]
			private static void __ENCAddToList(object value)
			{
				lock (CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList)
				{
					if (CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList.Count == CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList.Capacity)
					{
						int item = 0;
						int count = checked(CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList.Count - 1);
						for (int i = 0; i <= count; i = checked(i + 1))
						{
							if (CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList[i].IsAlive)
							{
								if (i != item)
								{
									CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList[item] = CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList[i];
								}
								item = checked(item + 1);
							}
						}
						CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList.RemoveRange(item, checked(CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList.Count - item));
						CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList.Capacity = CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList.Count;
					}
					CVS_FL_LBS.ZZTECHLOG_PARTSDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddZZTECHLOG_PARTSRow(CVS_FL_LBS.ZZTECHLOG_PARTSRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOG_PARTSRow AddZZTECHLOG_PARTSRow(decimal ZZTLP_REF, decimal ZZTL_REF, decimal ZZTLP_QNTY, string ZZHTLP_PARTNUMBER, string ZZHTLP_LOCATION, string ZZHTLP_DESCRIPTION)
			{
				CVS_FL_LBS.ZZTECHLOG_PARTSRow rowZZTECHLOG_PARTSRow = (CVS_FL_LBS.ZZTECHLOG_PARTSRow)this.NewRow();
				object[] zZTLPREF = new object[] { ZZTLP_REF, ZZTL_REF, ZZTLP_QNTY, ZZHTLP_PARTNUMBER, ZZHTLP_LOCATION, ZZHTLP_DESCRIPTION };
				rowZZTECHLOG_PARTSRow.ItemArray = zZTLPREF;
				this.Rows.Add(rowZZTECHLOG_PARTSRow);
				return rowZZTECHLOG_PARTSRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				CVS_FL_LBS.ZZTECHLOG_PARTSDataTable cln = (CVS_FL_LBS.ZZTECHLOG_PARTSDataTable)base.Clone();
				cln.InitVars();
				return cln;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new CVS_FL_LBS.ZZTECHLOG_PARTSDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(CVS_FL_LBS.ZZTECHLOG_PARTSRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType GetTypedTableSchema;
				XmlSchemaComplexType type = new XmlSchemaComplexType();
				XmlSchemaSequence sequence = new XmlSchemaSequence();
				CVS_FL_LBS ds = new CVS_FL_LBS();
				XmlSchemaAny any1 = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema"
				};
				decimal num = new decimal(0);
				any1.MinOccurs = num;
				any1.MaxOccurs = new decimal(-1, -1, -1, false, 0);
				any1.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any1);
				XmlSchemaAny any2 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				};
				num = new decimal(1);
				any2.MinOccurs = num;
				any2.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any2);
				XmlSchemaAttribute attribute1 = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = ds.Namespace
				};
				type.Attributes.Add(attribute1);
				XmlSchemaAttribute attribute2 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "ZZTECHLOG_PARTSDataTable"
				};
				type.Attributes.Add(attribute2);
				type.Particle = sequence;
				XmlSchema dsSchema = ds.GetSchemaSerializable();
				if (xs.Contains(dsSchema.TargetNamespace))
				{
					MemoryStream s1 = new MemoryStream();
					MemoryStream s2 = new MemoryStream();
					try
					{
						XmlSchema schema = null;
						dsSchema.Write(s1);
						IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
						while (schemas.MoveNext())
						{
							schema = (XmlSchema)schemas.Current;
							s2.SetLength((long)0);
							schema.Write(s2);
							if (s1.Length == s2.Length)
							{
								s1.Position = (long)0;
								s2.Position = (long)0;
								while (true)
								{
									if ((s1.Position == s1.Length || s1.ReadByte() != s2.ReadByte() ? true : false))
									{
										break;
									}
								}
								if (s1.Position == s1.Length)
								{
									GetTypedTableSchema = type;
									return GetTypedTableSchema;
								}
							}
						}
					}
					finally
					{
						if (s1 != null)
						{
							s1.Close();
						}
						if (s2 != null)
						{
							s2.Close();
						}
					}
				}
				xs.Add(dsSchema);
				GetTypedTableSchema = type;
				return GetTypedTableSchema;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnZZTLP_REF = new DataColumn("ZZTLP_REF", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLP_REF);
				this.columnZZTL_REF = new DataColumn("ZZTL_REF", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_REF);
				this.columnZZTLP_QNTY = new DataColumn("ZZTLP_QNTY", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLP_QNTY);
				this.columnZZHTLP_PARTNUMBER = new DataColumn("ZZHTLP_PARTNUMBER", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZHTLP_PARTNUMBER);
				this.columnZZHTLP_LOCATION = new DataColumn("ZZHTLP_LOCATION", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZHTLP_LOCATION);
				this.columnZZHTLP_DESCRIPTION = new DataColumn("ZZHTLP_DESCRIPTION", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZHTLP_DESCRIPTION);
				ConstraintCollection constraints = this.Constraints;
				DataColumn[] columnZZTLPREF = new DataColumn[] { this.columnZZTLP_REF };
				constraints.Add(new UniqueConstraint("Constraint2", columnZZTLPREF, false));
				this.columnZZTLP_REF.AllowDBNull = false;
				this.columnZZTLP_REF.Unique = true;
				this.columnZZHTLP_PARTNUMBER.MaxLength = 20;
				this.columnZZHTLP_LOCATION.MaxLength = 20;
				this.columnZZHTLP_DESCRIPTION.MaxLength = 200;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnZZTLP_REF = base.Columns["ZZTLP_REF"];
				this.columnZZTL_REF = base.Columns["ZZTL_REF"];
				this.columnZZTLP_QNTY = base.Columns["ZZTLP_QNTY"];
				this.columnZZHTLP_PARTNUMBER = base.Columns["ZZHTLP_PARTNUMBER"];
				this.columnZZHTLP_LOCATION = base.Columns["ZZHTLP_LOCATION"];
				this.columnZZHTLP_DESCRIPTION = base.Columns["ZZHTLP_DESCRIPTION"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CVS_FL_LBS.ZZTECHLOG_PARTSRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOG_PARTSRow NewZZTECHLOG_PARTSRow()
			{
				return (CVS_FL_LBS.ZZTECHLOG_PARTSRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ZZTECHLOG_PARTSRowChanged != null)
				{
					CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEventHandler zZTECHLOGPARTSRowChangeEventHandler = this.ZZTECHLOG_PARTSRowChanged;
					if (zZTECHLOGPARTSRowChangeEventHandler != null)
					{
						zZTECHLOGPARTSRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEvent((CVS_FL_LBS.ZZTECHLOG_PARTSRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ZZTECHLOG_PARTSRowChanging != null)
				{
					CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEventHandler zZTECHLOGPARTSRowChangeEventHandler = this.ZZTECHLOG_PARTSRowChanging;
					if (zZTECHLOGPARTSRowChangeEventHandler != null)
					{
						zZTECHLOGPARTSRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEvent((CVS_FL_LBS.ZZTECHLOG_PARTSRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ZZTECHLOG_PARTSRowDeleted != null)
				{
					CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEventHandler zZTECHLOGPARTSRowChangeEventHandler = this.ZZTECHLOG_PARTSRowDeleted;
					if (zZTECHLOGPARTSRowChangeEventHandler != null)
					{
						zZTECHLOGPARTSRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEvent((CVS_FL_LBS.ZZTECHLOG_PARTSRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ZZTECHLOG_PARTSRowDeleting != null)
				{
					CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEventHandler zZTECHLOGPARTSRowChangeEventHandler = this.ZZTECHLOG_PARTSRowDeleting;
					if (zZTECHLOGPARTSRowChangeEventHandler != null)
					{
						zZTECHLOGPARTSRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEvent((CVS_FL_LBS.ZZTECHLOG_PARTSRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveZZTECHLOG_PARTSRow(CVS_FL_LBS.ZZTECHLOG_PARTSRow row)
			{
				this.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEventHandler ZZTECHLOG_PARTSRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEventHandler ZZTECHLOG_PARTSRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEventHandler ZZTECHLOG_PARTSRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEventHandler ZZTECHLOG_PARTSRowDeleting;
		}

		public class ZZTECHLOG_PARTSRow : DataRow
		{
			private CVS_FL_LBS.ZZTECHLOG_PARTSDataTable tableZZTECHLOG_PARTS;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZHTLP_DESCRIPTION
			{
				get
				{
					string ZZHTLP_DESCRIPTION;
					try
					{
						ZZHTLP_DESCRIPTION = Conversions.ToString(this[this.tableZZTECHLOG_PARTS.ZZHTLP_DESCRIPTIONColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZHTLP_DESCRIPTION' in table 'ZZTECHLOG_PARTS' is DBNull.", invalidCastException);
					}
					return ZZHTLP_DESCRIPTION;
				}
				set
				{
					this[this.tableZZTECHLOG_PARTS.ZZHTLP_DESCRIPTIONColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZHTLP_LOCATION
			{
				get
				{
					string ZZHTLP_LOCATION;
					try
					{
						ZZHTLP_LOCATION = Conversions.ToString(this[this.tableZZTECHLOG_PARTS.ZZHTLP_LOCATIONColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZHTLP_LOCATION' in table 'ZZTECHLOG_PARTS' is DBNull.", invalidCastException);
					}
					return ZZHTLP_LOCATION;
				}
				set
				{
					this[this.tableZZTECHLOG_PARTS.ZZHTLP_LOCATIONColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZHTLP_PARTNUMBER
			{
				get
				{
					string ZZHTLP_PARTNUMBER;
					try
					{
						ZZHTLP_PARTNUMBER = Conversions.ToString(this[this.tableZZTECHLOG_PARTS.ZZHTLP_PARTNUMBERColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZHTLP_PARTNUMBER' in table 'ZZTECHLOG_PARTS' is DBNull.", invalidCastException);
					}
					return ZZHTLP_PARTNUMBER;
				}
				set
				{
					this[this.tableZZTECHLOG_PARTS.ZZHTLP_PARTNUMBERColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTL_REF
			{
				get
				{
					decimal ZZTL_REF;
					try
					{
						ZZTL_REF = Conversions.ToDecimal(this[this.tableZZTECHLOG_PARTS.ZZTL_REFColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_REF' in table 'ZZTECHLOG_PARTS' is DBNull.", invalidCastException);
					}
					return ZZTL_REF;
				}
				set
				{
					this[this.tableZZTECHLOG_PARTS.ZZTL_REFColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLP_QNTY
			{
				get
				{
					decimal ZZTLP_QNTY;
					try
					{
						ZZTLP_QNTY = Conversions.ToDecimal(this[this.tableZZTECHLOG_PARTS.ZZTLP_QNTYColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTLP_QNTY' in table 'ZZTECHLOG_PARTS' is DBNull.", invalidCastException);
					}
					return ZZTLP_QNTY;
				}
				set
				{
					this[this.tableZZTECHLOG_PARTS.ZZTLP_QNTYColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLP_REF
			{
				get
				{
					return Conversions.ToDecimal(this[this.tableZZTECHLOG_PARTS.ZZTLP_REFColumn]);
				}
				set
				{
					this[this.tableZZTECHLOG_PARTS.ZZTLP_REFColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal ZZTECHLOG_PARTSRow(DataRowBuilder rb) : base(rb)
			{
				this.tableZZTECHLOG_PARTS = (CVS_FL_LBS.ZZTECHLOG_PARTSDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZHTLP_DESCRIPTIONNull()
			{
				return this.IsNull(this.tableZZTECHLOG_PARTS.ZZHTLP_DESCRIPTIONColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZHTLP_LOCATIONNull()
			{
				return this.IsNull(this.tableZZTECHLOG_PARTS.ZZHTLP_LOCATIONColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZHTLP_PARTNUMBERNull()
			{
				return this.IsNull(this.tableZZTECHLOG_PARTS.ZZHTLP_PARTNUMBERColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_REFNull()
			{
				return this.IsNull(this.tableZZTECHLOG_PARTS.ZZTL_REFColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTLP_QNTYNull()
			{
				return this.IsNull(this.tableZZTECHLOG_PARTS.ZZTLP_QNTYColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZHTLP_DESCRIPTIONNull()
			{
				this[this.tableZZTECHLOG_PARTS.ZZHTLP_DESCRIPTIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZHTLP_LOCATIONNull()
			{
				this[this.tableZZTECHLOG_PARTS.ZZHTLP_LOCATIONColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZHTLP_PARTNUMBERNull()
			{
				this[this.tableZZTECHLOG_PARTS.ZZHTLP_PARTNUMBERColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_REFNull()
			{
				this[this.tableZZTECHLOG_PARTS.ZZTL_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTLP_QNTYNull()
			{
				this[this.tableZZTECHLOG_PARTS.ZZTLP_QNTYColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ZZTECHLOG_PARTSRowChangeEvent : EventArgs
		{
			private CVS_FL_LBS.ZZTECHLOG_PARTSRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOG_PARTSRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ZZTECHLOG_PARTSRowChangeEvent(CVS_FL_LBS.ZZTECHLOG_PARTSRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void ZZTECHLOG_PARTSRowChangeEventHandler(object sender, CVS_FL_LBS.ZZTECHLOG_PARTSRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class ZZTECHLOG_USERDataTable : TypedTableBase<CVS_FL_LBS.ZZTECHLOG_USERRow>
		{
			private static List<WeakReference> __ENCList;

			private DataColumn columnZZTLU_REF;

			private DataColumn columnZZTL_REF;

			private DataColumn columnZZTLU_NAME;

			private DataColumn columnZZTLU_TIME;

			private DataColumn columnZZTLU_SHIFT;

			private DataColumn columnZZTLU_DATE;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOG_USERRow this[int index]
			{
				get
				{
					return (CVS_FL_LBS.ZZTECHLOG_USERRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTL_REFColumn
			{
				get
				{
					return this.columnZZTL_REF;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLU_DATEColumn
			{
				get
				{
					return this.columnZZTLU_DATE;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLU_NAMEColumn
			{
				get
				{
					return this.columnZZTLU_NAME;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLU_REFColumn
			{
				get
				{
					return this.columnZZTLU_REF;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLU_SHIFTColumn
			{
				get
				{
					return this.columnZZTLU_SHIFT;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn ZZTLU_TIMEColumn
			{
				get
				{
					return this.columnZZTLU_TIME;
				}
			}

			[DebuggerNonUserCode]
			static ZZTECHLOG_USERDataTable()
			{
				CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList = new List<WeakReference>();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ZZTECHLOG_USERDataTable()
			{
				CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCAddToList(this);
				this.TableName = "ZZTECHLOG_USER";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal ZZTECHLOG_USERDataTable(DataTable table)
			{
				CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCAddToList(this);
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected ZZTECHLOG_USERDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCAddToList(this);
				this.InitVars();
			}

			[DebuggerNonUserCode]
			private static void __ENCAddToList(object value)
			{
				lock (CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList)
				{
					if (CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList.Count == CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList.Capacity)
					{
						int item = 0;
						int count = checked(CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList.Count - 1);
						for (int i = 0; i <= count; i = checked(i + 1))
						{
							if (CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList[i].IsAlive)
							{
								if (i != item)
								{
									CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList[item] = CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList[i];
								}
								item = checked(item + 1);
							}
						}
						CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList.RemoveRange(item, checked(CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList.Count - item));
						CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList.Capacity = CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList.Count;
					}
					CVS_FL_LBS.ZZTECHLOG_USERDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddZZTECHLOG_USERRow(CVS_FL_LBS.ZZTECHLOG_USERRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOG_USERRow AddZZTECHLOG_USERRow(decimal ZZTLU_REF, decimal ZZTL_REF, string ZZTLU_NAME, decimal ZZTLU_TIME, decimal ZZTLU_SHIFT, DateTime ZZTLU_DATE)
			{
				CVS_FL_LBS.ZZTECHLOG_USERRow rowZZTECHLOG_USERRow = (CVS_FL_LBS.ZZTECHLOG_USERRow)this.NewRow();
				object[] zZTLUREF = new object[] { ZZTLU_REF, ZZTL_REF, ZZTLU_NAME, ZZTLU_TIME, ZZTLU_SHIFT, ZZTLU_DATE };
				rowZZTECHLOG_USERRow.ItemArray = zZTLUREF;
				this.Rows.Add(rowZZTECHLOG_USERRow);
				return rowZZTECHLOG_USERRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				CVS_FL_LBS.ZZTECHLOG_USERDataTable cln = (CVS_FL_LBS.ZZTECHLOG_USERDataTable)base.Clone();
				cln.InitVars();
				return cln;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new CVS_FL_LBS.ZZTECHLOG_USERDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOG_USERRow FindByZZTLU_REF(decimal ZZTLU_REF)
			{
				DataRowCollection rows = this.Rows;
				object[] zZTLUREF = new object[] { ZZTLU_REF };
				return (CVS_FL_LBS.ZZTECHLOG_USERRow)rows.Find(zZTLUREF);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(CVS_FL_LBS.ZZTECHLOG_USERRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType GetTypedTableSchema;
				XmlSchemaComplexType type = new XmlSchemaComplexType();
				XmlSchemaSequence sequence = new XmlSchemaSequence();
				CVS_FL_LBS ds = new CVS_FL_LBS();
				XmlSchemaAny any1 = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema"
				};
				decimal num = new decimal(0);
				any1.MinOccurs = num;
				any1.MaxOccurs = new decimal(-1, -1, -1, false, 0);
				any1.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any1);
				XmlSchemaAny any2 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				};
				num = new decimal(1);
				any2.MinOccurs = num;
				any2.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any2);
				XmlSchemaAttribute attribute1 = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = ds.Namespace
				};
				type.Attributes.Add(attribute1);
				XmlSchemaAttribute attribute2 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "ZZTECHLOG_USERDataTable"
				};
				type.Attributes.Add(attribute2);
				type.Particle = sequence;
				XmlSchema dsSchema = ds.GetSchemaSerializable();
				if (xs.Contains(dsSchema.TargetNamespace))
				{
					MemoryStream s1 = new MemoryStream();
					MemoryStream s2 = new MemoryStream();
					try
					{
						XmlSchema schema = null;
						dsSchema.Write(s1);
						IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
						while (schemas.MoveNext())
						{
							schema = (XmlSchema)schemas.Current;
							s2.SetLength((long)0);
							schema.Write(s2);
							if (s1.Length == s2.Length)
							{
								s1.Position = (long)0;
								s2.Position = (long)0;
								while (true)
								{
									if ((s1.Position == s1.Length || s1.ReadByte() != s2.ReadByte() ? true : false))
									{
										break;
									}
								}
								if (s1.Position == s1.Length)
								{
									GetTypedTableSchema = type;
									return GetTypedTableSchema;
								}
							}
						}
					}
					finally
					{
						if (s1 != null)
						{
							s1.Close();
						}
						if (s2 != null)
						{
							s2.Close();
						}
					}
				}
				xs.Add(dsSchema);
				GetTypedTableSchema = type;
				return GetTypedTableSchema;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnZZTLU_REF = new DataColumn("ZZTLU_REF", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLU_REF);
				this.columnZZTL_REF = new DataColumn("ZZTL_REF", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTL_REF);
				this.columnZZTLU_NAME = new DataColumn("ZZTLU_NAME", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLU_NAME);
				this.columnZZTLU_TIME = new DataColumn("ZZTLU_TIME", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLU_TIME);
				this.columnZZTLU_SHIFT = new DataColumn("ZZTLU_SHIFT", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLU_SHIFT);
				this.columnZZTLU_DATE = new DataColumn("ZZTLU_DATE", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnZZTLU_DATE);
				ConstraintCollection constraints = this.Constraints;
				DataColumn[] columnZZTLUREF = new DataColumn[] { this.columnZZTLU_REF };
				constraints.Add(new UniqueConstraint("Constraint1", columnZZTLUREF, true));
				this.columnZZTLU_REF.AllowDBNull = false;
				this.columnZZTLU_REF.Unique = true;
				this.columnZZTLU_NAME.MaxLength = 50;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnZZTLU_REF = base.Columns["ZZTLU_REF"];
				this.columnZZTL_REF = base.Columns["ZZTL_REF"];
				this.columnZZTLU_NAME = base.Columns["ZZTLU_NAME"];
				this.columnZZTLU_TIME = base.Columns["ZZTLU_TIME"];
				this.columnZZTLU_SHIFT = base.Columns["ZZTLU_SHIFT"];
				this.columnZZTLU_DATE = base.Columns["ZZTLU_DATE"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CVS_FL_LBS.ZZTECHLOG_USERRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOG_USERRow NewZZTECHLOG_USERRow()
			{
				return (CVS_FL_LBS.ZZTECHLOG_USERRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ZZTECHLOG_USERRowChanged != null)
				{
					CVS_FL_LBS.ZZTECHLOG_USERRowChangeEventHandler zZTECHLOGUSERRowChangeEventHandler = this.ZZTECHLOG_USERRowChanged;
					if (zZTECHLOGUSERRowChangeEventHandler != null)
					{
						zZTECHLOGUSERRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOG_USERRowChangeEvent((CVS_FL_LBS.ZZTECHLOG_USERRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ZZTECHLOG_USERRowChanging != null)
				{
					CVS_FL_LBS.ZZTECHLOG_USERRowChangeEventHandler zZTECHLOGUSERRowChangeEventHandler = this.ZZTECHLOG_USERRowChanging;
					if (zZTECHLOGUSERRowChangeEventHandler != null)
					{
						zZTECHLOGUSERRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOG_USERRowChangeEvent((CVS_FL_LBS.ZZTECHLOG_USERRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ZZTECHLOG_USERRowDeleted != null)
				{
					CVS_FL_LBS.ZZTECHLOG_USERRowChangeEventHandler zZTECHLOGUSERRowChangeEventHandler = this.ZZTECHLOG_USERRowDeleted;
					if (zZTECHLOGUSERRowChangeEventHandler != null)
					{
						zZTECHLOGUSERRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOG_USERRowChangeEvent((CVS_FL_LBS.ZZTECHLOG_USERRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ZZTECHLOG_USERRowDeleting != null)
				{
					CVS_FL_LBS.ZZTECHLOG_USERRowChangeEventHandler zZTECHLOGUSERRowChangeEventHandler = this.ZZTECHLOG_USERRowDeleting;
					if (zZTECHLOGUSERRowChangeEventHandler != null)
					{
						zZTECHLOGUSERRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOG_USERRowChangeEvent((CVS_FL_LBS.ZZTECHLOG_USERRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveZZTECHLOG_USERRow(CVS_FL_LBS.ZZTECHLOG_USERRow row)
			{
				this.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOG_USERRowChangeEventHandler ZZTECHLOG_USERRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOG_USERRowChangeEventHandler ZZTECHLOG_USERRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOG_USERRowChangeEventHandler ZZTECHLOG_USERRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOG_USERRowChangeEventHandler ZZTECHLOG_USERRowDeleting;
		}

		public class ZZTECHLOG_USERRow : DataRow
		{
			private CVS_FL_LBS.ZZTECHLOG_USERDataTable tableZZTECHLOG_USER;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTL_REF
			{
				get
				{
					decimal ZZTL_REF;
					try
					{
						ZZTL_REF = Conversions.ToDecimal(this[this.tableZZTECHLOG_USER.ZZTL_REFColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTL_REF' in table 'ZZTECHLOG_USER' is DBNull.", invalidCastException);
					}
					return ZZTL_REF;
				}
				set
				{
					this[this.tableZZTECHLOG_USER.ZZTL_REFColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime ZZTLU_DATE
			{
				get
				{
					DateTime ZZTLU_DATE;
					try
					{
						ZZTLU_DATE = Conversions.ToDate(this[this.tableZZTECHLOG_USER.ZZTLU_DATEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTLU_DATE' in table 'ZZTECHLOG_USER' is DBNull.", invalidCastException);
					}
					return ZZTLU_DATE;
				}
				set
				{
					this[this.tableZZTECHLOG_USER.ZZTLU_DATEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string ZZTLU_NAME
			{
				get
				{
					string ZZTLU_NAME;
					try
					{
						ZZTLU_NAME = Conversions.ToString(this[this.tableZZTECHLOG_USER.ZZTLU_NAMEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTLU_NAME' in table 'ZZTECHLOG_USER' is DBNull.", invalidCastException);
					}
					return ZZTLU_NAME;
				}
				set
				{
					this[this.tableZZTECHLOG_USER.ZZTLU_NAMEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLU_REF
			{
				get
				{
					return Conversions.ToDecimal(this[this.tableZZTECHLOG_USER.ZZTLU_REFColumn]);
				}
				set
				{
					this[this.tableZZTECHLOG_USER.ZZTLU_REFColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLU_SHIFT
			{
				get
				{
					decimal ZZTLU_SHIFT;
					try
					{
						ZZTLU_SHIFT = Conversions.ToDecimal(this[this.tableZZTECHLOG_USER.ZZTLU_SHIFTColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTLU_SHIFT' in table 'ZZTECHLOG_USER' is DBNull.", invalidCastException);
					}
					return ZZTLU_SHIFT;
				}
				set
				{
					this[this.tableZZTECHLOG_USER.ZZTLU_SHIFTColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal ZZTLU_TIME
			{
				get
				{
					decimal ZZTLU_TIME;
					try
					{
						ZZTLU_TIME = Conversions.ToDecimal(this[this.tableZZTECHLOG_USER.ZZTLU_TIMEColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'ZZTLU_TIME' in table 'ZZTECHLOG_USER' is DBNull.", invalidCastException);
					}
					return ZZTLU_TIME;
				}
				set
				{
					this[this.tableZZTECHLOG_USER.ZZTLU_TIMEColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal ZZTECHLOG_USERRow(DataRowBuilder rb) : base(rb)
			{
				this.tableZZTECHLOG_USER = (CVS_FL_LBS.ZZTECHLOG_USERDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTL_REFNull()
			{
				return this.IsNull(this.tableZZTECHLOG_USER.ZZTL_REFColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTLU_DATENull()
			{
				return this.IsNull(this.tableZZTECHLOG_USER.ZZTLU_DATEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTLU_NAMENull()
			{
				return this.IsNull(this.tableZZTECHLOG_USER.ZZTLU_NAMEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTLU_SHIFTNull()
			{
				return this.IsNull(this.tableZZTECHLOG_USER.ZZTLU_SHIFTColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool IsZZTLU_TIMENull()
			{
				return this.IsNull(this.tableZZTECHLOG_USER.ZZTLU_TIMEColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTL_REFNull()
			{
				this[this.tableZZTECHLOG_USER.ZZTL_REFColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTLU_DATENull()
			{
				this[this.tableZZTECHLOG_USER.ZZTLU_DATEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTLU_NAMENull()
			{
				this[this.tableZZTECHLOG_USER.ZZTLU_NAMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTLU_SHIFTNull()
			{
				this[this.tableZZTECHLOG_USER.ZZTLU_SHIFTColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void SetZZTLU_TIMENull()
			{
				this[this.tableZZTECHLOG_USER.ZZTLU_TIMEColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ZZTECHLOG_USERRowChangeEvent : EventArgs
		{
			private CVS_FL_LBS.ZZTECHLOG_USERRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOG_USERRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ZZTECHLOG_USERRowChangeEvent(CVS_FL_LBS.ZZTECHLOG_USERRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void ZZTECHLOG_USERRowChangeEventHandler(object sender, CVS_FL_LBS.ZZTECHLOG_USERRowChangeEvent e);

		[Serializable]
		[XmlSchemaProvider("GetTypedTableSchema")]
		public class ZZTECHLOGDataTable : TypedTableBase<CVS_FL_LBS.ZZTECHLOGRow>
		{
			private static List<WeakReference> __ENCList;

			private DataColumn columnzztl_ref;

			private DataColumn columnzztl_state;

			private DataColumn columnzztl_wotype;

			private DataColumn columnzztl_woasset;

			private DataColumn columnzztl_wocomplaint;

			private DataColumn columnzztl_worootcause;

			private DataColumn columnzztl_wocorrection;

			private DataColumn columnzztl_genuser;

			private DataColumn columnzztl_gendate;

			private DataColumn columnzztl_moduser;

			private DataColumn columnzztl_moddate;

			[Browsable(false)]
			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public int Count
			{
				get
				{
					return this.Rows.Count;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOGRow this[int index]
			{
				get
				{
					return (CVS_FL_LBS.ZZTECHLOGRow)this.Rows[index];
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_gendateColumn
			{
				get
				{
					return this.columnzztl_gendate;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_genuserColumn
			{
				get
				{
					return this.columnzztl_genuser;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_moddateColumn
			{
				get
				{
					return this.columnzztl_moddate;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_moduserColumn
			{
				get
				{
					return this.columnzztl_moduser;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_refColumn
			{
				get
				{
					return this.columnzztl_ref;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_stateColumn
			{
				get
				{
					return this.columnzztl_state;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_woassetColumn
			{
				get
				{
					return this.columnzztl_woasset;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_wocomplaintColumn
			{
				get
				{
					return this.columnzztl_wocomplaint;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_wocorrectionColumn
			{
				get
				{
					return this.columnzztl_wocorrection;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_worootcauseColumn
			{
				get
				{
					return this.columnzztl_worootcause;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataColumn zztl_wotypeColumn
			{
				get
				{
					return this.columnzztl_wotype;
				}
			}

			[DebuggerNonUserCode]
			static ZZTECHLOGDataTable()
			{
				CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList = new List<WeakReference>();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ZZTECHLOGDataTable()
			{
				CVS_FL_LBS.ZZTECHLOGDataTable.__ENCAddToList(this);
				this.TableName = "ZZTECHLOG";
				this.BeginInit();
				this.InitClass();
				this.EndInit();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal ZZTECHLOGDataTable(DataTable table)
			{
				CVS_FL_LBS.ZZTECHLOGDataTable.__ENCAddToList(this);
				this.TableName = table.TableName;
				if (table.CaseSensitive != table.DataSet.CaseSensitive)
				{
					this.CaseSensitive = table.CaseSensitive;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Locale.ToString(), table.DataSet.Locale.ToString(), false) != 0)
				{
					this.Locale = table.Locale;
				}
				if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(table.Namespace, table.DataSet.Namespace, false) != 0)
				{
					this.Namespace = table.Namespace;
				}
				this.Prefix = table.Prefix;
				this.MinimumCapacity = table.MinimumCapacity;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected ZZTECHLOGDataTable(SerializationInfo info, StreamingContext context) : base(info, context)
			{
				CVS_FL_LBS.ZZTECHLOGDataTable.__ENCAddToList(this);
				this.InitVars();
			}

			[DebuggerNonUserCode]
			private static void __ENCAddToList(object value)
			{
				lock (CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList)
				{
					if (CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList.Count == CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList.Capacity)
					{
						int item = 0;
						int count = checked(CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList.Count - 1);
						for (int i = 0; i <= count; i = checked(i + 1))
						{
							if (CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList[i].IsAlive)
							{
								if (i != item)
								{
									CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList[item] = CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList[i];
								}
								item = checked(item + 1);
							}
						}
						CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList.RemoveRange(item, checked(CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList.Count - item));
						CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList.Capacity = CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList.Count;
					}
					CVS_FL_LBS.ZZTECHLOGDataTable.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void AddZZTECHLOGRow(CVS_FL_LBS.ZZTECHLOGRow row)
			{
				this.Rows.Add(row);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOGRow AddZZTECHLOGRow(decimal zztl_ref, string zztl_state, string zztl_wotype, string zztl_woasset, string zztl_wocomplaint, string zztl_worootcause, string zztl_wocorrection, string zztl_genuser, DateTime zztl_gendate, string zztl_moduser, DateTime zztl_moddate)
			{
				CVS_FL_LBS.ZZTECHLOGRow rowZZTECHLOGRow = (CVS_FL_LBS.ZZTECHLOGRow)this.NewRow();
				object[] zztlRef = new object[] { zztl_ref, zztl_state, zztl_wotype, zztl_woasset, zztl_wocomplaint, zztl_worootcause, zztl_wocorrection, zztl_genuser, zztl_gendate, zztl_moduser, zztl_moddate };
				rowZZTECHLOGRow.ItemArray = zztlRef;
				this.Rows.Add(rowZZTECHLOGRow);
				return rowZZTECHLOGRow;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public override DataTable Clone()
			{
				CVS_FL_LBS.ZZTECHLOGDataTable cln = (CVS_FL_LBS.ZZTECHLOGDataTable)base.Clone();
				cln.InitVars();
				return cln;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataTable CreateInstance()
			{
				return new CVS_FL_LBS.ZZTECHLOGDataTable();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override Type GetRowType()
			{
				return typeof(CVS_FL_LBS.ZZTECHLOGRow);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public static XmlSchemaComplexType GetTypedTableSchema(XmlSchemaSet xs)
			{
				XmlSchemaComplexType GetTypedTableSchema;
				XmlSchemaComplexType type = new XmlSchemaComplexType();
				XmlSchemaSequence sequence = new XmlSchemaSequence();
				CVS_FL_LBS ds = new CVS_FL_LBS();
				XmlSchemaAny any1 = new XmlSchemaAny()
				{
					Namespace = "http://www.w3.org/2001/XMLSchema"
				};
				decimal num = new decimal(0);
				any1.MinOccurs = num;
				any1.MaxOccurs = new decimal(-1, -1, -1, false, 0);
				any1.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any1);
				XmlSchemaAny any2 = new XmlSchemaAny()
				{
					Namespace = "urn:schemas-microsoft-com:xml-diffgram-v1"
				};
				num = new decimal(1);
				any2.MinOccurs = num;
				any2.ProcessContents = XmlSchemaContentProcessing.Lax;
				sequence.Items.Add(any2);
				XmlSchemaAttribute attribute1 = new XmlSchemaAttribute()
				{
					Name = "namespace",
					FixedValue = ds.Namespace
				};
				type.Attributes.Add(attribute1);
				XmlSchemaAttribute attribute2 = new XmlSchemaAttribute()
				{
					Name = "tableTypeName",
					FixedValue = "ZZTECHLOGDataTable"
				};
				type.Attributes.Add(attribute2);
				type.Particle = sequence;
				XmlSchema dsSchema = ds.GetSchemaSerializable();
				if (xs.Contains(dsSchema.TargetNamespace))
				{
					MemoryStream s1 = new MemoryStream();
					MemoryStream s2 = new MemoryStream();
					try
					{
						XmlSchema schema = null;
						dsSchema.Write(s1);
						IEnumerator schemas = xs.Schemas(dsSchema.TargetNamespace).GetEnumerator();
						while (schemas.MoveNext())
						{
							schema = (XmlSchema)schemas.Current;
							s2.SetLength((long)0);
							schema.Write(s2);
							if (s1.Length == s2.Length)
							{
								s1.Position = (long)0;
								s2.Position = (long)0;
								while (true)
								{
									if ((s1.Position == s1.Length || s1.ReadByte() != s2.ReadByte() ? true : false))
									{
										break;
									}
								}
								if (s1.Position == s1.Length)
								{
									GetTypedTableSchema = type;
									return GetTypedTableSchema;
								}
							}
						}
					}
					finally
					{
						if (s1 != null)
						{
							s1.Close();
						}
						if (s2 != null)
						{
							s2.Close();
						}
					}
				}
				xs.Add(dsSchema);
				GetTypedTableSchema = type;
				return GetTypedTableSchema;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			private void InitClass()
			{
				this.columnzztl_ref = new DataColumn("zztl_ref", typeof(decimal), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_ref);
				this.columnzztl_state = new DataColumn("zztl_state", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_state);
				this.columnzztl_wotype = new DataColumn("zztl_wotype", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_wotype);
				this.columnzztl_woasset = new DataColumn("zztl_woasset", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_woasset);
				this.columnzztl_wocomplaint = new DataColumn("zztl_wocomplaint", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_wocomplaint);
				this.columnzztl_worootcause = new DataColumn("zztl_worootcause", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_worootcause);
				this.columnzztl_wocorrection = new DataColumn("zztl_wocorrection", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_wocorrection);
				this.columnzztl_genuser = new DataColumn("zztl_genuser", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_genuser);
				this.columnzztl_gendate = new DataColumn("zztl_gendate", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_gendate);
				this.columnzztl_moduser = new DataColumn("zztl_moduser", typeof(string), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_moduser);
				this.columnzztl_moddate = new DataColumn("zztl_moddate", typeof(DateTime), null, MappingType.Element);
				base.Columns.Add(this.columnzztl_moddate);
				this.columnzztl_ref.Caption = "REF";
				this.columnzztl_state.Caption = "STATE";
				this.columnzztl_wotype.Caption = "TYPE";
				this.columnzztl_wotype.MaxLength = 30;
				this.columnzztl_woasset.Caption = "ASSET";
				this.columnzztl_woasset.MaxLength = 50;
				this.columnzztl_wocomplaint.Caption = "COMPLAINT";
				this.columnzztl_wocomplaint.MaxLength = 2000;
				this.columnzztl_worootcause.Caption = "ROOT CAUSE";
				this.columnzztl_worootcause.MaxLength = 2000;
				this.columnzztl_wocorrection.Caption = "CORRECTION";
				this.columnzztl_wocorrection.MaxLength = 2000;
				this.columnzztl_genuser.Caption = "GENUSER";
				this.columnzztl_gendate.Caption = "GENDATE";
				this.columnzztl_moduser.Caption = "MODUSER";
				this.columnzztl_moddate.Caption = "MODDATE";
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal void InitVars()
			{
				this.columnzztl_ref = base.Columns["zztl_ref"];
				this.columnzztl_state = base.Columns["zztl_state"];
				this.columnzztl_wotype = base.Columns["zztl_wotype"];
				this.columnzztl_woasset = base.Columns["zztl_woasset"];
				this.columnzztl_wocomplaint = base.Columns["zztl_wocomplaint"];
				this.columnzztl_worootcause = base.Columns["zztl_worootcause"];
				this.columnzztl_wocorrection = base.Columns["zztl_wocorrection"];
				this.columnzztl_genuser = base.Columns["zztl_genuser"];
				this.columnzztl_gendate = base.Columns["zztl_gendate"];
				this.columnzztl_moduser = base.Columns["zztl_moduser"];
				this.columnzztl_moddate = base.Columns["zztl_moddate"];
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override DataRow NewRowFromBuilder(DataRowBuilder builder)
			{
				return new CVS_FL_LBS.ZZTECHLOGRow(builder);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOGRow NewZZTECHLOGRow()
			{
				return (CVS_FL_LBS.ZZTECHLOGRow)this.NewRow();
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanged(DataRowChangeEventArgs e)
			{
				base.OnRowChanged(e);
				if (this.ZZTECHLOGRowChanged != null)
				{
					CVS_FL_LBS.ZZTECHLOGRowChangeEventHandler zZTECHLOGRowChangeEventHandler = this.ZZTECHLOGRowChanged;
					if (zZTECHLOGRowChangeEventHandler != null)
					{
						zZTECHLOGRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOGRowChangeEvent((CVS_FL_LBS.ZZTECHLOGRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowChanging(DataRowChangeEventArgs e)
			{
				base.OnRowChanging(e);
				if (this.ZZTECHLOGRowChanging != null)
				{
					CVS_FL_LBS.ZZTECHLOGRowChangeEventHandler zZTECHLOGRowChangeEventHandler = this.ZZTECHLOGRowChanging;
					if (zZTECHLOGRowChangeEventHandler != null)
					{
						zZTECHLOGRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOGRowChangeEvent((CVS_FL_LBS.ZZTECHLOGRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleted(DataRowChangeEventArgs e)
			{
				base.OnRowDeleted(e);
				if (this.ZZTECHLOGRowDeleted != null)
				{
					CVS_FL_LBS.ZZTECHLOGRowChangeEventHandler zZTECHLOGRowChangeEventHandler = this.ZZTECHLOGRowDeleted;
					if (zZTECHLOGRowChangeEventHandler != null)
					{
						zZTECHLOGRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOGRowChangeEvent((CVS_FL_LBS.ZZTECHLOGRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			protected override void OnRowDeleting(DataRowChangeEventArgs e)
			{
				base.OnRowDeleting(e);
				if (this.ZZTECHLOGRowDeleting != null)
				{
					CVS_FL_LBS.ZZTECHLOGRowChangeEventHandler zZTECHLOGRowChangeEventHandler = this.ZZTECHLOGRowDeleting;
					if (zZTECHLOGRowChangeEventHandler != null)
					{
						zZTECHLOGRowChangeEventHandler(this, new CVS_FL_LBS.ZZTECHLOGRowChangeEvent((CVS_FL_LBS.ZZTECHLOGRow)e.Row, e.Action));
					}
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void RemoveZZTECHLOGRow(CVS_FL_LBS.ZZTECHLOGRow row)
			{
				this.Rows.Remove(row);
			}

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOGRowChangeEventHandler ZZTECHLOGRowChanged;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOGRowChangeEventHandler ZZTECHLOGRowChanging;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOGRowChangeEventHandler ZZTECHLOGRowDeleted;

			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public event CVS_FL_LBS.ZZTECHLOGRowChangeEventHandler ZZTECHLOGRowDeleting;
		}

		public class ZZTECHLOGRow : DataRow
		{
			private CVS_FL_LBS.ZZTECHLOGDataTable tableZZTECHLOG;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime zztl_gendate
			{
				get
				{
					DateTime zztl_gendate;
					try
					{
						zztl_gendate = Conversions.ToDate(this[this.tableZZTECHLOG.zztl_gendateColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_gendate' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_gendate;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_gendateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string zztl_genuser
			{
				get
				{
					string zztl_genuser;
					try
					{
						zztl_genuser = Conversions.ToString(this[this.tableZZTECHLOG.zztl_genuserColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_genuser' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_genuser;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_genuserColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DateTime zztl_moddate
			{
				get
				{
					DateTime zztl_moddate;
					try
					{
						zztl_moddate = Conversions.ToDate(this[this.tableZZTECHLOG.zztl_moddateColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_moddate' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_moddate;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_moddateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string zztl_moduser
			{
				get
				{
					string zztl_moduser;
					try
					{
						zztl_moduser = Conversions.ToString(this[this.tableZZTECHLOG.zztl_moduserColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_moduser' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_moduser;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_moduserColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public decimal zztl_ref
			{
				get
				{
					decimal zztl_ref;
					try
					{
						zztl_ref = Conversions.ToDecimal(this[this.tableZZTECHLOG.zztl_refColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_ref' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_ref;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_refColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string zztl_state
			{
				get
				{
					string zztl_state;
					try
					{
						zztl_state = Conversions.ToString(this[this.tableZZTECHLOG.zztl_stateColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_state' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_state;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_stateColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string zztl_woasset
			{
				get
				{
					string zztl_woasset;
					try
					{
						zztl_woasset = Conversions.ToString(this[this.tableZZTECHLOG.zztl_woassetColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_woasset' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_woasset;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_woassetColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string zztl_wocomplaint
			{
				get
				{
					string zztl_wocomplaint;
					try
					{
						zztl_wocomplaint = Conversions.ToString(this[this.tableZZTECHLOG.zztl_wocomplaintColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_wocomplaint' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_wocomplaint;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_wocomplaintColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string zztl_wocorrection
			{
				get
				{
					string zztl_wocorrection;
					try
					{
						zztl_wocorrection = Conversions.ToString(this[this.tableZZTECHLOG.zztl_wocorrectionColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_wocorrection' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_wocorrection;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_wocorrectionColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string zztl_worootcause
			{
				get
				{
					string zztl_worootcause;
					try
					{
						zztl_worootcause = Conversions.ToString(this[this.tableZZTECHLOG.zztl_worootcauseColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_worootcause' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_worootcause;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_worootcauseColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public string zztl_wotype
			{
				get
				{
					string zztl_wotype;
					try
					{
						zztl_wotype = Conversions.ToString(this[this.tableZZTECHLOG.zztl_wotypeColumn]);
					}
					catch (InvalidCastException invalidCastException)
					{
						ProjectData.SetProjectError(invalidCastException);
						throw new StrongTypingException("The value for column 'zztl_wotype' in table 'ZZTECHLOG' is DBNull.", invalidCastException);
					}
					return zztl_wotype;
				}
				set
				{
					this[this.tableZZTECHLOG.zztl_wotypeColumn] = value;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			internal ZZTECHLOGRow(DataRowBuilder rb) : base(rb)
			{
				this.tableZZTECHLOG = (CVS_FL_LBS.ZZTECHLOGDataTable)this.Table;
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_gendateNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_gendateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_genuserNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_genuserColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_moddateNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_moddateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_moduserNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_moduserColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_refNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_refColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_stateNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_stateColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_woassetNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_woassetColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_wocomplaintNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_wocomplaintColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_wocorrectionNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_wocorrectionColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_worootcauseNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_worootcauseColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public bool Iszztl_wotypeNull()
			{
				return this.IsNull(this.tableZZTECHLOG.zztl_wotypeColumn);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_gendateNull()
			{
				this[this.tableZZTECHLOG.zztl_gendateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_genuserNull()
			{
				this[this.tableZZTECHLOG.zztl_genuserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_moddateNull()
			{
				this[this.tableZZTECHLOG.zztl_moddateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_moduserNull()
			{
				this[this.tableZZTECHLOG.zztl_moduserColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_refNull()
			{
				this[this.tableZZTECHLOG.zztl_refColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_stateNull()
			{
				this[this.tableZZTECHLOG.zztl_stateColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_woassetNull()
			{
				this[this.tableZZTECHLOG.zztl_woassetColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_wocomplaintNull()
			{
				this[this.tableZZTECHLOG.zztl_wocomplaintColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_wocorrectionNull()
			{
				this[this.tableZZTECHLOG.zztl_wocorrectionColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_worootcauseNull()
			{
				this[this.tableZZTECHLOG.zztl_worootcauseColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public void Setzztl_wotypeNull()
			{
				this[this.tableZZTECHLOG.zztl_wotypeColumn] = RuntimeHelpers.GetObjectValue(Convert.DBNull);
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public class ZZTECHLOGRowChangeEvent : EventArgs
		{
			private CVS_FL_LBS.ZZTECHLOGRow eventRow;

			private DataRowAction eventAction;

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public DataRowAction Action
			{
				get
				{
					return this.eventAction;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public CVS_FL_LBS.ZZTECHLOGRow Row
			{
				get
				{
					return this.eventRow;
				}
			}

			[DebuggerNonUserCode]
			[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
			public ZZTECHLOGRowChangeEvent(CVS_FL_LBS.ZZTECHLOGRow row, DataRowAction action)
			{
				this.eventRow = row;
				this.eventAction = action;
			}
		}

		[GeneratedCode("System.Data.Design.TypedDataSetGenerator", "4.0.0.0")]
		public delegate void ZZTECHLOGRowChangeEventHandler(object sender, CVS_FL_LBS.ZZTECHLOGRowChangeEvent e);
	}
}