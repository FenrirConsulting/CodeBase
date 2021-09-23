using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace WiLog
{
	[DebuggerStepThrough]
	[ToolStripItemDesignerAvailability(ToolStripItemDesignerAvailability.ToolStrip)]
	public class ToolStripCheckBox : ToolStripControlHost
	{
		private static List<WeakReference> __ENCList;

		public bool Checked
		{
			get
			{
				return this.ToolStripCheckBoxControl.Checked;
			}
			set
			{
				this.ToolStripCheckBoxControl.Checked = value;
			}
		}

		public CheckBox ToolStripCheckBoxControl
		{
			get
			{
				return this.Control as CheckBox;
			}
		}

		public bool ToolStripCheckBoxEnabled
		{
			get
			{
				return this.ToolStripCheckBoxControl.Enabled;
			}
			set
			{
				this.ToolStripCheckBoxControl.Enabled = value;
			}
		}

		[DebuggerNonUserCode]
		static ToolStripCheckBox()
		{
			ToolStripCheckBox.__ENCList = new List<WeakReference>();
		}

		public ToolStripCheckBox() : base(new CheckBox())
		{
			ToolStripCheckBox.__ENCAddToList(this);
			this.ToolStripCheckBoxControl.BackColor = Color.Transparent;
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (ToolStripCheckBox.__ENCList)
			{
				if (ToolStripCheckBox.__ENCList.Count == ToolStripCheckBox.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(ToolStripCheckBox.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (ToolStripCheckBox.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								ToolStripCheckBox.__ENCList[item] = ToolStripCheckBox.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					ToolStripCheckBox.__ENCList.RemoveRange(item, checked(ToolStripCheckBox.__ENCList.Count - item));
					ToolStripCheckBox.__ENCList.Capacity = ToolStripCheckBox.__ENCList.Count;
				}
				ToolStripCheckBox.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		private void OnCheckedChanged(object sender, EventArgs e)
		{
			EventHandler eventHandler = this.CheckedChanged;
			if (eventHandler != null)
			{
				eventHandler(this, e);
			}
		}

		protected override void OnSubscribeControlEvents(System.Windows.Forms.Control c)
		{
			base.OnSubscribeControlEvents(c);
			ToolStripCheckBox toolStripCheckBox = this;
			((CheckBox)c).CheckedChanged += new EventHandler(toolStripCheckBox.OnCheckedChanged);
		}

		protected override void OnUnsubscribeControlEvents(System.Windows.Forms.Control c)
		{
			base.OnUnsubscribeControlEvents(c);
			ToolStripCheckBox toolStripCheckBox = this;
			((CheckBox)c).CheckedChanged -= new EventHandler(toolStripCheckBox.OnCheckedChanged);
		}

		public event EventHandler CheckedChanged;
	}
}