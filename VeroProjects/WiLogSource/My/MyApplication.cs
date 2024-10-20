using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using System;
using System.CodeDom.Compiler;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.IO;
using System.Runtime.CompilerServices;
using System.Threading;
using System.Windows.Forms;
using WiLog;

namespace WiLog.My
{
	[EditorBrowsable(EditorBrowsableState.Never)]
	[GeneratedCode("MyTemplate", "10.0.0.0")]
	internal class MyApplication : WindowsFormsApplicationBase
	{
		private static List<WeakReference> __ENCList;

		[DebuggerNonUserCode]
		static MyApplication()
		{
			MyApplication.__ENCList = new List<WeakReference>();
		}

		[DebuggerStepThrough]
		public MyApplication() : base(AuthenticationMode.Windows)
		{
			MyApplication myApplication = this;
			base.UnhandledException += new Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventHandler(myApplication.MyApplication_UnhandledException);
			MyApplication.__ENCAddToList(this);
			this.IsSingleInstance = true;
			this.EnableVisualStyles = true;
			this.SaveMySettingsOnExit = true;
			this.ShutdownStyle = ShutdownMode.AfterMainFormCloses;
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (MyApplication.__ENCList)
			{
				if (MyApplication.__ENCList.Count == MyApplication.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(MyApplication.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (MyApplication.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								MyApplication.__ENCList[item] = MyApplication.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					MyApplication.__ENCList.RemoveRange(item, checked(MyApplication.__ENCList.Count - item));
					MyApplication.__ENCList.Capacity = MyApplication.__ENCList.Count;
				}
				MyApplication.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		[DebuggerHidden]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		[STAThread]
		internal static void Main(string[] Args)
		{
			try
			{
				Application.SetCompatibleTextRenderingDefault(WindowsFormsApplicationBase.UseCompatibleTextRendering);
			}
			finally
			{
			}
			MyProject.Application.Run(Args);
		}

		private void MyApplication_UnhandledException(object sender, Microsoft.VisualBasic.ApplicationServices.UnhandledExceptionEventArgs e)
		{
			File.AppendAllText("Errors.txt", ErrorHandlingStuff.SysInfoToString(e.Exception, true, false));
			Interaction.MsgBox(string.Concat("Fatal Error:", Environment.NewLine, ErrorHandlingStuff.SysInfoToString(e.Exception, true, true)), MsgBoxStyle.OkOnly, null);
		}

		[DebuggerStepThrough]
		protected override void OnCreateMainForm()
		{
			this.MainForm = MyProject.Forms.frmLogin;
		}
	}
}