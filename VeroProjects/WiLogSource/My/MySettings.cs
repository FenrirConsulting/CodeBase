using Microsoft.VisualBasic.ApplicationServices;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Configuration;
using System.Diagnostics;
using System.Runtime.CompilerServices;
using System.Threading;

namespace WiLog.My
{
	[CompilerGenerated]
	[EditorBrowsable(EditorBrowsableState.Advanced)]
	[GeneratedCode("Microsoft.VisualStudio.Editors.SettingsDesigner.SettingsSingleFileGenerator", "10.0.0.0")]
	internal sealed class MySettings : ApplicationSettingsBase
	{
		private static MySettings defaultInstance;

		private static bool addedHandler;

		private static object addedHandlerLockObject;

		public static MySettings Default
		{
			get
			{
				if (!MySettings.addedHandler)
				{
					object obj = MySettings.addedHandlerLockObject;
					ObjectFlowControl.CheckForSyncLockOnValueType(obj);
					bool flag = false;
					try
					{
						Monitor.Enter(obj, ref flag);
						if (!MySettings.addedHandler)
						{
							MyProject.Application.Shutdown += new ShutdownEventHandler(MySettings.AutoSaveSettings);
							MySettings.addedHandler = true;
						}
					}
					finally
					{
						if (flag)
						{
							Monitor.Exit(obj);
						}
					}
				}
				return MySettings.defaultInstance;
			}
		}

		[ApplicationScopedSetting]
		[DebuggerNonUserCode]
		[DefaultSettingValue("DATA SOURCE=CVSFL01;PASSWORD=lbs;PERSIST SECURITY INFO=True;USER ID=LBS_USER")]
		[SpecialSetting(SpecialSetting.ConnectionString)]
		public string fl_LBS
		{
			get
			{
				return Conversions.ToString(this["fl_LBS"]);
			}
		}

		static MySettings()
		{
			MySettings.defaultInstance = (MySettings)SettingsBase.Synchronized(new MySettings());
			MySettings.addedHandlerLockObject = RuntimeHelpers.GetObjectValue(new object());
		}

		[DebuggerNonUserCode]
		public MySettings()
		{
		}

		[DebuggerNonUserCode]
		[EditorBrowsable(EditorBrowsableState.Advanced)]
		private static void AutoSaveSettings(object sender, EventArgs e)
		{
			if (MyProject.Application.SaveMySettingsOnExit)
			{
				MySettingsProperty.Settings.Save();
			}
		}
	}
}