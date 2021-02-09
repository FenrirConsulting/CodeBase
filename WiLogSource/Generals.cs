using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections;
using System.Data;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WiLog
{
	internal static class Generals
	{
		public static string oradb;

		public static string CurUserName;

		public static string CurUserShift;

		public static string CurUserAdmin;

		public static string CurUserIsLead;

		public static string CurUserIsPartsLead;

		public static DataTable PartsTable;

		static Generals()
		{
			Generals.oradb = "Data Source=cvsfl01;User Id=lbs_user;Password=lbs;";
			Generals.CurUserName = "";
			Generals.CurUserShift = "";
			Generals.CurUserAdmin = "";
			Generals.CurUserIsLead = "";
			Generals.CurUserIsPartsLead = "";
			Generals.PartsTable = new DataTable();
		}

		private static void BuildDataTable(string fileFullPath, char seperator)
		{
			int i;
			StreamReader myReader = null;
			Stopwatch MyStopwatch = Stopwatch.StartNew();
			short TheLines = 1;
			string.Concat(Application.StartupPath, "\\Reports\\Partslist.txt");
			DataTable myTable = new DataTable("MyTable");
			try
			{
				try
				{
					myReader = File.OpenText(fileFullPath);
					string str = myReader.ReadLine();
					char[] chrArray = new char[] { seperator };
					string[] fieldValues = str.Split(chrArray);
					int length = checked(checked((int)fieldValues.Length) - 1);
					for (i = 0; i <= length; i = checked(i + 1))
					{
						myTable.Columns.Add(new DataColumn(string.Concat("Field", Conversions.ToString(i))));
					}
					DataRow myRow = myTable.NewRow();
					int num = checked(checked((int)fieldValues.Length) - 1);
					for (i = 0; i <= num; i = checked(i + 1))
					{
						myRow[i] = fieldValues[i].ToString();
					}
					myTable.Rows.Add(myRow);
					while (myReader.Peek() != -1)
					{
						string str1 = myReader.ReadLine();
						chrArray = new char[] { seperator };
						fieldValues = str1.Split(chrArray);
						myRow = myTable.NewRow();
						int length1 = checked(checked((int)fieldValues.Length) - 1);
						for (i = 0; i <= length1; i = checked(i + 1))
						{
							myRow[i] = fieldValues[i].ToString();
						}
						myTable.Rows.Add(myRow);
						TheLines = checked((short)(checked(TheLines + 1)));
					}
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					Exception ex = exception;
					Interaction.MsgBox(string.Concat("Error building datatable: ", ex.Message), MsgBoxStyle.OkOnly, null);
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				myReader.Close();
			}
			MyStopwatch.Stop();
			string[] strArrays = new string[] { "MyStopWatch: Lines added = ", TheLines.ToString(), " in ", null, null };
			TimeSpan elapsed = MyStopwatch.Elapsed;
			strArrays[3] = Conversions.ToString(elapsed.TotalMilliseconds);
			strArrays[4] = " Milliseconds.";
			Interaction.MsgBox(string.Concat(strArrays), MsgBoxStyle.OkOnly, "Timed");
		}

		public static void CreatePartsTable()
		{
			DataTable dt = new DataTable();
		}

		public static void FillComboFromFile(string MyFile, DataGridViewComboBoxColumn TheCombo)
		{
			int I = 1;
			string tmp = "";
			string MyStr = "";
			try
			{
				if (!File.Exists(MyFile))
				{
					Interaction.MsgBox("Oooops, File not found !!!", MsgBoxStyle.OkOnly, null);
				}
				else
				{
					using (StreamReader sr = new StreamReader(MyFile))
					{
						while (!sr.EndOfStream)
						{
							MyStr = sr.ReadLine();
							tmp = Strings.Mid(MyStr, checked(Strings.InStr(MyStr, "\t", CompareMethod.Binary) + 1));
							TheCombo.Items.Add(tmp);
							Debug.WriteLine(string.Concat(I.ToString(), " >>", tmp));
							I = checked(I + 1);
						}
					}
				}
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Interaction.MsgBox(exception.Message, MsgBoxStyle.OkOnly, null);
				ProjectData.ClearProjectError();
			}
		}

		public static DataGridViewColumn GetColByDataName(this DataGridView dgv, string name)
		{
			DataGridViewColumn GetColByDataName;
			IEnumerator enumerator = null;
			try
			{
				enumerator = dgv.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataGridViewColumn col = (DataGridViewColumn)enumerator.Current;
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(col.HeaderText, name, false) == 0)
					{
						GetColByDataName = col;
						return GetColByDataName;
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
			GetColByDataName = null;
			return GetColByDataName;
		}

		public static DataGridViewColumn GetColByHeaderText(this DataGridView dgv, string name)
		{
			DataGridViewColumn GetColByHeaderText;
			IEnumerator enumerator = null;
			try
			{
				enumerator = dgv.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataGridViewColumn col = (DataGridViewColumn)enumerator.Current;
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(col.HeaderText, name, false) == 0)
					{
						GetColByHeaderText = col;
						return GetColByHeaderText;
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
			GetColByHeaderText = null;
			return GetColByHeaderText;
		}

		public static int GetColName(string name, ref DataGridView dgv)
		{
			IEnumerator enumerator = null;
			int retVal = -1;
			try
			{
				enumerator = dgv.Columns.GetEnumerator();
				while (enumerator.MoveNext())
				{
					DataGridViewColumn col = (DataGridViewColumn)enumerator.Current;
					if (Microsoft.VisualBasic.CompilerServices.Operators.CompareString(col.HeaderText, name, false) == 0)
					{
						retVal = col.Index;
						break;
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
			return retVal;
		}

		public static void maketable()
		{
			string FilePath = string.Concat(Application.StartupPath, "\\Reports\\Partslist.txt");
			Generals.BuildDataTable(FilePath, '\t');
		}
	}
}