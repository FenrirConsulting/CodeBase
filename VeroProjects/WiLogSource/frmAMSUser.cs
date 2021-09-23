using Microsoft.VisualBasic.CompilerServices;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Drawing;
using System.Runtime.CompilerServices;
using System.Windows.Forms;

namespace WiLog
{
	[DesignerGenerated]
	public class frmAMSUser : Form
	{
		private static List<WeakReference> __ENCList;

		private IContainer components;

		[AccessedThroughProperty("btnOK")]
		private Button _btnOK;

		[AccessedThroughProperty("btnCancel")]
		private Button _btnCancel;

		[AccessedThroughProperty("ComboBox1")]
		private ComboBox _ComboBox1;

		internal virtual Button btnCancel
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnCancel;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnCancel = value;
			}
		}

		internal virtual Button btnOK
		{
			[DebuggerNonUserCode]
			get
			{
				return this._btnOK;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._btnOK = value;
			}
		}

		internal virtual ComboBox ComboBox1
		{
			[DebuggerNonUserCode]
			get
			{
				return this._ComboBox1;
			}
			[DebuggerNonUserCode]
			[MethodImpl(MethodImplOptions.Synchronized)]
			set
			{
				this._ComboBox1 = value;
			}
		}

		[DebuggerNonUserCode]
		static frmAMSUser()
		{
			frmAMSUser.__ENCList = new List<WeakReference>();
		}

		[DebuggerNonUserCode]
		public frmAMSUser()
		{
			frmAMSUser.__ENCAddToList(this);
			this.InitializeComponent();
		}

		[DebuggerNonUserCode]
		private static void __ENCAddToList(object value)
		{
			lock (frmAMSUser.__ENCList)
			{
				if (frmAMSUser.__ENCList.Count == frmAMSUser.__ENCList.Capacity)
				{
					int item = 0;
					int count = checked(frmAMSUser.__ENCList.Count - 1);
					for (int i = 0; i <= count; i = checked(i + 1))
					{
						if (frmAMSUser.__ENCList[i].IsAlive)
						{
							if (i != item)
							{
								frmAMSUser.__ENCList[item] = frmAMSUser.__ENCList[i];
							}
							item = checked(item + 1);
						}
					}
					frmAMSUser.__ENCList.RemoveRange(item, checked(frmAMSUser.__ENCList.Count - item));
					frmAMSUser.__ENCList.Capacity = frmAMSUser.__ENCList.Count;
				}
				frmAMSUser.__ENCList.Add(new WeakReference(RuntimeHelpers.GetObjectValue(value)));
			}
		}

		[DebuggerNonUserCode]
		protected override void Dispose(bool disposing)
		{
			try
			{
				if ((!disposing || this.components == null ? false : true))
				{
					this.components.Dispose();
				}
			}
			finally
			{
				base.Dispose(disposing);
			}
		}

		[DebuggerStepThrough]
		private void InitializeComponent()
		{
			this.btnOK = new Button();
			this.btnCancel = new Button();
			this.ComboBox1 = new ComboBox();
			this.SuspendLayout();
			Button button = this.btnOK;
			Point point = new Point(31, 48);
			button.Location = point;
			this.btnOK.Name = "btnOK";
			Button button1 = this.btnOK;
			System.Drawing.Size size = new System.Drawing.Size(75, 23);
			button1.Size = size;
			this.btnOK.TabIndex = 0;
			this.btnOK.Text = "O.K.";
			this.btnOK.UseVisualStyleBackColor = true;
			Button button2 = this.btnCancel;
			point = new Point(192, 48);
			button2.Location = point;
			this.btnCancel.Name = "btnCancel";
			Button button3 = this.btnCancel;
			size = new System.Drawing.Size(75, 23);
			button3.Size = size;
			this.btnCancel.TabIndex = 1;
			this.btnCancel.Text = "Cancel";
			this.btnCancel.UseVisualStyleBackColor = true;
			this.ComboBox1.FormattingEnabled = true;
			ComboBox comboBox1 = this.ComboBox1;
			point = new Point(12, 12);
			comboBox1.Location = point;
			this.ComboBox1.Name = "ComboBox1";
			ComboBox comboBox = this.ComboBox1;
			size = new System.Drawing.Size(274, 21);
			comboBox.Size = size;
			this.ComboBox1.TabIndex = 2;
			this.AutoScaleDimensions = new SizeF(6f, 13f);
			this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
			size = new System.Drawing.Size(299, 78);
			this.ClientSize = size;
			this.Controls.Add(this.ComboBox1);
			this.Controls.Add(this.btnCancel);
			this.Controls.Add(this.btnOK);
			this.Name = "frmAMSUser";
			this.StartPosition = FormStartPosition.CenterParent;
			this.Text = "frmAMSUser";
			this.ResumeLayout(false);
		}
	}
}