using System;
using System.Runtime.InteropServices;

namespace RoseWorks
{
	public partial class Main
	{
		/// <summary>
		/// COM registration call to add regitry entries to SolidWorks add-in registry
		/// </summary>
		/// <param name="t">Type</param>
		[ComRegisterFunction()]
		private static void ComRegister(Type t)
		{
			string keyPath = String.Format(@"SOFTWARE\SolidWorks\AddIns\{0:b}", t.GUID);

			using (var rk = Microsoft.Win32.Registry.LocalMachine.CreateSubKey(keyPath))
			{
				// Load at startup
				rk.SetValue(null, 1);

				rk.SetValue("Title", "Rose");

				rk.SetValue("Description", "All your solid models are belong to us");
			}
		}

		/// <summary>
		/// COM reistration call to remove regitry entries added in registry function
		/// </summary>
		/// <param name="t">Type</param>
		[ComUnregisterFunction()]
		private static void ComUnregister(Type t)
		{
			string keyPath = String.Format(@"SOFTWARE\SolidWorks\AddIns\{0:b}", t.GUID);
			Microsoft.Win32.Registry.LocalMachine.DeleteSubKeyTree(keyPath);
		}

	}
}
