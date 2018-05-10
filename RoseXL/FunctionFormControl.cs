using System.Runtime.InteropServices;
using System.Windows.Forms;
using System.Windows.Forms.Integration;

namespace RoseXL
{
	/// <summary>
	/// Wrapper for the WPF UserControl. The excel API requires Windows Forms. Would need to be marked with [ComVisible(true)] if in a project that is marked as [assembly:ComVisible(false)] which is the default for VS projects.
	/// </summary>
	[ComVisible(true)]
	public class FunctionFormControl : UserControl
	{
		public FunctionFormControl()
		{
			var wpfElementHost = new ElementHost() { Dock = DockStyle.Fill };
			wpfElementHost.HostContainer.Children.Add(new FunctionWpfControl());
			Controls.Add(wpfElementHost);
		}
	}
}
