using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace RoseXL
{
	/////////////// Define the UserControl to display on the CTP ///////////////////////////
	// Would need to be marked with [ComVisible(true)] if in a project that is marked as [assembly:ComVisible(false)] which is the default for VS projects.
	[ComVisible(true)]
	public class BoltFormControl : UserControl
	{
		public BoltFormControl()
		{
			var wpfElementHost = new ElementHost() { Dock = DockStyle.Fill };
			wpfElementHost.HostContainer.Children.Add(new BoltWpfControl());
			Controls.Add(wpfElementHost);
		}
	}
}
