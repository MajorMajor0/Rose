using System;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

using ExcelDna.Integration;
using ExcelDna.Integration.CustomUI;

namespace RoseXL
{
	/////////////// Define the UserControl to display on the CTP ///////////////////////////
	// Would need to be marked with [ComVisible(true)] if in a project that is marked as [assembly:ComVisible(false)] which is the default for VS projects.
	[ComVisible(true)]
	public class BoltTaskPane : UserControl
	{
		public BoltTaskPane()
		{
			var wpfElementHost = new ElementHost() { Dock = DockStyle.Fill };
			wpfElementHost.HostContainer.Children.Add(new BoltContent());

			Controls.Add(wpfElementHost);



		}

	}
}
