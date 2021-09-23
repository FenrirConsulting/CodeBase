using Microsoft.VisualBasic;
using Microsoft.VisualBasic.CompilerServices;
using System;
using System.CodeDom.Compiler;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Globalization;
using System.Resources;
using System.Runtime.CompilerServices;

namespace WiLog.My.Resources
{
	[CompilerGenerated]
	[DebuggerNonUserCode]
	[GeneratedCode("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
	[HideModuleName]
	internal static class Resources
	{
		private static System.Resources.ResourceManager resourceMan;

		private static CultureInfo resourceCulture;

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static CultureInfo Culture
		{
			get
			{
				return WiLog.My.Resources.Resources.resourceCulture;
			}
			set
			{
				WiLog.My.Resources.Resources.resourceCulture = value;
			}
		}

		[EditorBrowsable(EditorBrowsableState.Advanced)]
		internal static System.Resources.ResourceManager ResourceManager
		{
			get
			{
				if (object.ReferenceEquals(WiLog.My.Resources.Resources.resourceMan, null))
				{
					WiLog.My.Resources.Resources.resourceMan = new System.Resources.ResourceManager("WiLog.Resources", typeof(WiLog.My.Resources.Resources).Assembly);
				}
				return WiLog.My.Resources.Resources.resourceMan;
			}
		}

		internal static Bitmap Witron_logo
		{
			get
			{
				object obj = RuntimeHelpers.GetObjectValue(WiLog.My.Resources.Resources.ResourceManager.GetObject("Witron_logo", WiLog.My.Resources.Resources.resourceCulture));
				return (Bitmap)obj;
			}
		}

		internal static Bitmap Witron_logo_A
		{
			get
			{
				object obj = RuntimeHelpers.GetObjectValue(WiLog.My.Resources.Resources.ResourceManager.GetObject("Witron_logo_A", WiLog.My.Resources.Resources.resourceCulture));
				return (Bitmap)obj;
			}
		}
	}
}