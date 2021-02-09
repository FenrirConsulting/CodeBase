using Microsoft.VisualBasic;
using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using Microsoft.VisualBasic.Devices;
using System;
using System.Diagnostics;
using System.Drawing;
using System.IO;
using System.Net;
using System.Net.Mail;
using System.Reflection;
using System.Runtime.CompilerServices;
using System.Text;
using System.Windows.Forms;
using WiLog.My;

namespace WiLog
{
	internal static class ErrorHandlingStuff
	{
		private static Assembly objParentAssembly;

		static ErrorHandlingStuff()
		{
			ErrorHandlingStuff.objParentAssembly = null;
		}

		internal static Assembly ParentAssembly()
		{
			if (ErrorHandlingStuff.objParentAssembly == null)
			{
				if (Assembly.GetEntryAssembly() != null)
				{
					ErrorHandlingStuff.objParentAssembly = Assembly.GetEntryAssembly();
				}
				else
				{
					ErrorHandlingStuff.objParentAssembly = Assembly.GetCallingAssembly();
				}
			}
			return ErrorHandlingStuff.objParentAssembly;
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void SendErrorEmail(string msg)
		{
			MailMessage mail = new MailMessage()
			{
				From = new MailAddress(string.Concat(MyProject.Application.Info.Title, "@yahoo.com"))
			};
			mail.To.Add("dmitchell@witron.com");
			mail.Subject = string.Concat("Error: ", MyProject.Application.Info.Title);
			mail.Body = msg;
			SmtpClient smtp = new SmtpClient("smtp.gmail.com", 465)
			{
				UseDefaultCredentials = false,
				Credentials = new NetworkCredential("justme4326@gmail.com", "Gxxxxxxxx7"),
				EnableSsl = true
			};
			smtp.EnableSsl = true;
			smtp.Host = "smtp.gmail.com";
			try
			{
				try
				{
					smtp.Send(mail);
					MessageBox.Show("send attempt", "Exception email");
				}
				catch (Exception exception)
				{
					ProjectData.SetProjectError(exception);
					MessageBox.Show(exception.ToString(), "Exception SMTP error mail");
					ProjectData.ClearProjectError();
				}
			}
			finally
			{
				smtp.Dispose();
			}
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static string SysInfoToString(Exception TheException, bool lnIncludeStackTrace = false, bool IncludeEmail = false)
		{
			int fileLineNumber;
			StringBuilder DetailLines = new StringBuilder();
			AppDomain d = AppDomain.CurrentDomain;
			StringBuilder stringBuilder = DetailLines;
			stringBuilder.AppendLine("++++++++++++++++++++++++++++++++++++++++++");
			stringBuilder.AppendLine(string.Format("Date and time:           {0}", DateTime.Now));
			stringBuilder.AppendLine(string.Format("Exception:               {0}", TheException.Message));
			Exception TheInnerExceptions = TheException.InnerException;
			if (TheInnerExceptions != null)
			{
				stringBuilder.AppendLine("Inner Exception:");
				while (TheInnerExceptions != null)
				{
					stringBuilder.AppendLine(string.Format("                         {0}", TheInnerExceptions.Message));
					TheInnerExceptions = TheInnerExceptions.InnerException;
				}
			}
			else
			{
				stringBuilder.AppendLine("Inner Exception:      N/A");
			}
			try
			{
				StackFrame stackframe = new StackFrame(1);
				stringBuilder.AppendLine(string.Concat("CurrentMethod:            ", MethodBase.GetCurrentMethod().ToString()));
				fileLineNumber = stackframe.GetFileLineNumber();
				stringBuilder.AppendLine(string.Concat("Line #:                   ", fileLineNumber.ToString()));
				stringBuilder.AppendLine(string.Concat("Calling Method:           ", stackframe.ToString()));
			}
			catch (Exception exception)
			{
				ProjectData.SetProjectError(exception);
				Exception e = exception;
				stringBuilder.AppendLine(string.Concat("ERROR IN GETTING METHODS!:   ", e.Message));
				ProjectData.ClearProjectError();
			}
			stringBuilder.Append("Machine Name:            ");
			try
			{
				stringBuilder.Append(Environment.MachineName);
			}
			catch (Exception exception1)
			{
				ProjectData.SetProjectError(exception1);
				stringBuilder.Append(exception1.Message);
				ProjectData.ClearProjectError();
			}
			stringBuilder.Append(Environment.NewLine);
			stringBuilder.AppendLine(string.Format("Current Username:        {0}", MyProject.User.Name));
			fileLineNumber = SystemInformation.PrimaryMonitorSize.Width;
			string str = fileLineNumber.ToString();
			int height = SystemInformation.PrimaryMonitorSize.Height;
			stringBuilder.AppendLine(string.Format("Monitor size:            {0} x {1}", str, height.ToString()));
			stringBuilder.AppendLine(string.Format("System Boot mode:        {0}", SystemInformation.BootMode.ToString()));
			stringBuilder.AppendLine(string.Format("Operating System:        {0}", Environment.OSVersion));
			ulong totalPhysicalMemory = MyProject.Computer.Info.TotalPhysicalMemory;
			stringBuilder.AppendLine(string.Format("Installed RAM:           {0}", totalPhysicalMemory.ToString()));
			stringBuilder.AppendLine(string.Format("Application Path:        {0}", MyProject.Application.Info.DirectoryPath));
			stringBuilder.AppendLine(string.Format("Application Version:     {0}", MyProject.Application.Info.Version));
			if (MyProject.Application.Info.Description.Trim().Length <= 0)
			{
				stringBuilder.AppendLine(string.Format("Application Description: {0}", "<Unknown>"));
			}
			else
			{
				stringBuilder.AppendLine(string.Format("Application Description: {0}", MyProject.Application.Info.Description));
			}
			if (MyProject.Application.Info.Title.Trim().Length <= 0)
			{
				stringBuilder.AppendLine(string.Format("Application Title:       {0}", "<Unknown>"));
			}
			else
			{
				stringBuilder.AppendLine(string.Format("Application Title:       {0}", MyProject.Application.Info.Title));
			}
			if (lnIncludeStackTrace)
			{
				try
				{
					stringBuilder.AppendLine("Stack Trace Info: ");
					stringBuilder.Append(ErrorHandlingStuff.StackTracer.EnhancedStackTrace(TheException, true));
				}
				catch (Exception exception2)
				{
					ProjectData.SetProjectError(exception2);
					stringBuilder.Append(exception2.Message);
					ProjectData.ClearProjectError();
				}
			}
			stringBuilder.AppendLine("");
			stringBuilder = null;
			!IncludeEmail;
			return DetailLines.ToString();
		}

		public static void TestErrorHandle()
		{
		}

		[MethodImpl(MethodImplOptions.NoInlining | MethodImplOptions.NoOptimization)]
		public static void WriteLogEntry(string msg, string severity = "I")
		{
			string str = string.Concat(MyProject.Application.Info.DirectoryPath, "\\", MyProject.Application.Info.Title, ".log");
			string[] shortDateString = new string[] { DateAndTime.Now.ToShortDateString(), " ", DateAndTime.Now.ToShortTimeString(), " -", severity.ToUpper(), "- ", msg, Environment.NewLine };
			File.AppendAllText(str, string.Concat(shortDateString));
		}

		public class StackTracer
		{
			private static string mDetails;

			public static string Details
			{
				get
				{
					return ErrorHandlingStuff.StackTracer.mDetails;
				}
			}

			[DebuggerNonUserCode]
			public StackTracer()
			{
			}

			private static string EnhancedStackTrace(StackTrace objStackTrace, string strSkipClassName = "", bool UseReturns = false)
			{
				string EnhancedStackTrace;
				StringBuilder sb = new StringBuilder();
				int frameCount = checked(objStackTrace.FrameCount - 1);
				for (int intFrame = 0; intFrame <= frameCount; intFrame = checked(intFrame + 1))
				{
					StackFrame sf = objStackTrace.GetFrame(intFrame);
					MemberInfo mi = sf.GetMethod();
					if ((Operators.CompareString(strSkipClassName, "", false) == 0 || mi.DeclaringType.Name.IndexOf(strSkipClassName) <= -1 ? true : false))
					{
						string Results = ErrorHandlingStuff.StackTracer.StackFrameToString(sf, UseReturns);
						if (Results.Length > 0)
						{
							sb.Append(Results);
						}
					}
				}
				EnhancedStackTrace = (!sb.ToString().EndsWith("|") ? sb.ToString() : sb.ToString().Substring(0, checked(sb.ToString().Length - 1)));
				return EnhancedStackTrace;
			}

			public static string EnhancedStackTrace(Exception objException, bool UseReturns = false)
			{
				StackTrace objStackTrace = new StackTrace(objException, true);
				return ErrorHandlingStuff.StackTracer.EnhancedStackTrace(objStackTrace, "", UseReturns);
			}

			private static string EnhancedStackTrace()
			{
				return ErrorHandlingStuff.StackTracer.EnhancedStackTrace(new StackTrace(true), "ExceptionManager", false);
			}

			private static string StackFrameToString(StackFrame ApplicationStack, bool UseReturns = false)
			{
				bool bDiscard;
				string StackFrameToString;
				StringBuilder sb = new StringBuilder();
				MemberInfo mi = ApplicationStack.GetMethod();
				StringBuilder stringBuilder = sb;
				stringBuilder.Append(mi.DeclaringType.Namespace);
				stringBuilder.Append(".");
				stringBuilder.Append(mi.DeclaringType.Name);
				stringBuilder.Append(".");
				stringBuilder.Append(mi.Name);
				ParameterInfo[] objParameters = ApplicationStack.GetMethod().GetParameters();
				stringBuilder.Append("(");
				int intParam = 0;
				ParameterInfo[] parameterInfoArray = objParameters;
				for (int i = 0; i < checked((int)parameterInfoArray.Length); i = checked(i + 1))
				{
					ParameterInfo objParameter = parameterInfoArray[i];
					intParam = checked(intParam + 1);
					if (intParam > 1)
					{
						stringBuilder.Append(", ");
					}
					stringBuilder.Append(objParameter.Name);
					stringBuilder.Append(" As ");
					stringBuilder.Append(objParameter.ParameterType.Name);
				}
				if (!UseReturns)
				{
					stringBuilder.Append(")~");
				}
				else
				{
					stringBuilder.Append(")");
					stringBuilder.Append(Environment.NewLine);
				}
				if ((ApplicationStack.GetFileName() == null || ApplicationStack.GetFileName().Length == 0 ? false : true))
				{
					stringBuilder.Append(Path.GetFileName(ApplicationStack.GetFileName()));
					stringBuilder.Append(": line ");
					stringBuilder.Append(string.Format("{0:#0000}", ApplicationStack.GetFileLineNumber()));
					stringBuilder.Append(", col ");
					stringBuilder.Append(string.Format("{0:#00}", ApplicationStack.GetFileColumnNumber()));
					bDiscard = false;
				}
				else
				{
					stringBuilder.Append(Path.GetFileName(ErrorHandlingStuff.ParentAssembly().CodeBase));
					stringBuilder.Append(": N ");
					stringBuilder.Append(string.Format("{0:#00000}", ApplicationStack.GetNativeOffset()));
					bDiscard = true;
				}
				if (!UseReturns)
				{
					stringBuilder.Append("|");
				}
				else
				{
					stringBuilder.Append(Environment.NewLine);
				}
				stringBuilder = null;
				if (!bDiscard)
				{
					ErrorHandlingStuff.StackTracer.mDetails = sb.ToString();
					StackFrameToString = sb.ToString();
				}
				else
				{
					StackFrameToString = "";
				}
				return StackFrameToString;
			}
		}
	}
}