using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices;
using System.Windows.Forms.Integration;

namespace RoseWorks
{
	[ProgId(Main.SWTASKPANE_PROGID)]
	public partial class TaskPaneHost : UserControl
	{
		public TaskPaneHost()
		{
			InitializeComponent();

			var wpfElementHost = new ElementHost() { Dock = DockStyle.Fill };
			wpfElementHost.HostContainer.Children.Add(new TaskPane());

			Controls.Add(wpfElementHost);
		}
	}
}
