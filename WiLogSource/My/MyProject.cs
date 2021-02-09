using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.Collections;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Diagnostics;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using WiLog;

namespace WiLog.My
{
	[GeneratedCode("MyTemplate", "10.0.0.0")]
	[HideModuleName]
	internal static class MyProject
	{
		private readonly static MyProject.ThreadSafeObjectProvider<MyComputer> m_ComputerObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<MyApplication> m_AppObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User> m_UserObjectProvider;

		private static MyProject.ThreadSafeObjectProvider<MyProject.MyForms> m_MyFormsObjectProvider;

		private readonly static MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices> m_MyWebServicesObjectProvider;

		[HelpKeyword("My.Application")]
		internal static MyApplication Application
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_AppObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Computer")]
		internal static MyComputer Computer
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_ComputerObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.Forms")]
		internal static MyProject.MyForms Forms
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyFormsObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.User")]
		internal static Microsoft.VisualBasic.ApplicationServices.User User
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_UserObjectProvider.GetInstance;
			}
		}

		[HelpKeyword("My.WebServices")]
		internal static MyProject.MyWebServices WebServices
		{
			[DebuggerHidden]
			get
			{
				return MyProject.m_MyWebServicesObjectProvider.GetInstance;
			}
		}

		[DebuggerNonUserCode]
		static MyProject()
		{
			MyProject.m_ComputerObjectProvider = new MyProject.ThreadSafeObjectProvider<MyComputer>();
			MyProject.m_AppObjectProvider = new MyProject.ThreadSafeObjectProvider<MyApplication>();
			MyProject.m_UserObjectProvider = new MyProject.ThreadSafeObjectProvider<Microsoft.VisualBasic.ApplicationServices.User>();
			MyProject.m_MyFormsObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyForms>();
			MyProject.m_MyWebServicesObjectProvider = new MyProject.ThreadSafeObjectProvider<MyProject.MyWebServices>();
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Windows.Forms.Form", "Create__Instance__", "Dispose__Instance__", "My.MyProject.Forms")]
		internal sealed class MyForms
		{
			public frmAMSUser m_frmAMSUser;

			public FrmChangePassword m_FrmChangePassword;

			public frmLogin m_frmLogin;

			public frmMain m_frmMain;

			public frmNewUser m_frmNewUser;

			public frmPassword m_frmPassword;

			public frmReport m_frmReport;

			public frmUsers m_frmUsers;

			[ThreadStatic]
			private static Hashtable m_FormBeingCreated;

			public frmAMSUser frmAMSUser
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmAMSUser = MyProject.MyForms.Create__Instance__<frmAMSUser>(this.m_frmAMSUser);
					return this.m_frmAMSUser;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frmAMSUser)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmAMSUser>(ref this.m_frmAMSUser);
					}
				}
			}

			public FrmChangePassword FrmChangePassword
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_FrmChangePassword = MyProject.MyForms.Create__Instance__<FrmChangePassword>(this.m_FrmChangePassword);
					return this.m_FrmChangePassword;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_FrmChangePassword)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<FrmChangePassword>(ref this.m_FrmChangePassword);
					}
				}
			}

			public frmLogin frmLogin
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmLogin = MyProject.MyForms.Create__Instance__<frmLogin>(this.m_frmLogin);
					return this.m_frmLogin;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frmLogin)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmLogin>(ref this.m_frmLogin);
					}
				}
			}

			public frmMain frmMain
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmMain = MyProject.MyForms.Create__Instance__<frmMain>(this.m_frmMain);
					return this.m_frmMain;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frmMain)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmMain>(ref this.m_frmMain);
					}
				}
			}

			public frmNewUser frmNewUser
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmNewUser = MyProject.MyForms.Create__Instance__<frmNewUser>(this.m_frmNewUser);
					return this.m_frmNewUser;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frmNewUser)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmNewUser>(ref this.m_frmNewUser);
					}
				}
			}

			public frmPassword frmPassword
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmPassword = MyProject.MyForms.Create__Instance__<frmPassword>(this.m_frmPassword);
					return this.m_frmPassword;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frmPassword)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmPassword>(ref this.m_frmPassword);
					}
				}
			}

			public frmReport frmReport
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmReport = MyProject.MyForms.Create__Instance__<frmReport>(this.m_frmReport);
					return this.m_frmReport;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frmReport)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmReport>(ref this.m_frmReport);
					}
				}
			}

			public frmUsers frmUsers
			{
				[DebuggerNonUserCode]
				get
				{
					this.m_frmUsers = MyProject.MyForms.Create__Instance__<frmUsers>(this.m_frmUsers);
					return this.m_frmUsers;
				}
				[DebuggerNonUserCode]
				set
				{
					if (value != this.m_frmUsers)
					{
						if (value != null)
						{
							throw new ArgumentException("Property can only be set to Nothing");
						}
						this.Dispose__Instance__<frmUsers>(ref this.m_frmUsers);
					}
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyForms()
			{
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T Instance)
			where T : Form, new()
			{
				T Create__Instance__;
				if ((Instance == null || Instance.IsDisposed ? false : true))
				{
					Create__Instance__ = Instance;
				}
				else
				{
					if (MyProject.MyForms.m_FormBeingCreated == null)
					{
						MyProject.MyForms.m_FormBeingCreated = new Hashtable();
					}
					else if (MyProject.MyForms.m_FormBeingCreated.ContainsKey(typeof(T)))
					{
						throw new InvalidOperationException(Utils.GetResourceString("WinForms_RecursiveFormCreate", new string[0]));
					}
					MyProject.MyForms.m_FormBeingCreated.Add(typeof(T), null);
					try
					{
						try
						{
							Create__Instance__ = Activator.CreateInstance<T>();
						}
						catch (TargetInvocationException ex) when (ex.InnerException != null)
						{
							string[] message = new string[] { ex.InnerException.Message };
							string BetterMessage = Utils.GetResourceString("WinForms_SeeInnerException", message);
							throw new InvalidOperationException(BetterMessage, ex.InnerException);
						}
					}
					finally
					{
						MyProject.MyForms.m_FormBeingCreated.Remove(typeof(T));
					}
				}
				return Create__Instance__;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			where T : Form
			{
				instance.Dispose();
				instance = default(T);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return this.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return this.GetHashCode();
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyForms);
			}

			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return this.ToString();
			}
		}

		[EditorBrowsable(EditorBrowsableState.Never)]
		[MyGroupCollection("System.Web.Services.Protocols.SoapHttpClientProtocol", "Create__Instance__", "Dispose__Instance__", "")]
		internal sealed class MyWebServices
		{
			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public MyWebServices()
			{
			}

			[DebuggerHidden]
			private static T Create__Instance__<T>(T instance)
			where T : new()
			{
				T Create__Instance__;
				Create__Instance__ = (instance != null ? instance : Activator.CreateInstance<T>());
				return Create__Instance__;
			}

			[DebuggerHidden]
			private void Dispose__Instance__<T>(ref T instance)
			{
				instance = default(T);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override bool Equals(object o)
			{
				return this.Equals(RuntimeHelpers.GetObjectValue(o));
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override int GetHashCode()
			{
				return this.GetHashCode();
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			internal new Type GetType()
			{
				return typeof(MyProject.MyWebServices);
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public override string ToString()
			{
				return this.ToString();
			}
		}

		[ComVisible(false)]
		[EditorBrowsable(EditorBrowsableState.Never)]
		internal sealed class ThreadSafeObjectProvider<T>
		where T : new()
		{
			[CompilerGenerated]
			[ThreadStatic]
			private static T m_ThreadStaticValue;

			internal T GetInstance
			{
				[DebuggerHidden]
				get
				{
					if (MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue == null)
					{
						MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue = Activator.CreateInstance<T>();
					}
					return MyProject.ThreadSafeObjectProvider<T>.m_ThreadStaticValue;
				}
			}

			[DebuggerHidden]
			[EditorBrowsable(EditorBrowsableState.Never)]
			public ThreadSafeObjectProvider()
			{
			}
		}
	}
}