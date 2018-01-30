
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.swpublished;
using SolidWorksTools;
using System.Runtime.InteropServices;
using System.IO;

namespace RoseWorks
{

	public partial class Main : ISwAddin
	{
		TaskpaneView taskpaneView;
		TaskPaneHost taskPaneHost;

		public const string SWTASKPANE_PROGID = "RoseWorks.TaskPaneHost";

		/// <summary>
		/// Called when SolidWorks has loaded the adddin  and wants connection logic.
		/// </summary>
		/// <param name="thisSW">The current SolidWorks instance</param>
		/// <param name="cookie">The current SolidWorks cookie ID</param>
		/// <returns></returns>
		public bool ConnectToSW(object thisSW, int cookie)
		{
			SW.App = (SldWorks)thisSW;

			SW.Cookie = cookie;

			// Set-up add-in call back info
			bool ok = SW.App.SetAddinCallbackInfo(0, this, cookie);

			LoadUI();

			return true;
		}

		/// <summary>
		/// Called when SolidWorks is about to disconnect the adddin and wants disconnection logic.
		/// </summary>
		/// <returns></returns>
		public bool DisconnectFromSW()
		{
			UnloadUI();
			return true;
		}

		void LoadUI()
		{
			var imagePath = Path.Combine(Path.GetDirectoryName(typeof(Main).Assembly.CodeBase).Replace(@"file:\", string.Empty), "logo-small.bmp");

			taskpaneView = SW.App.CreateTaskpaneView2(imagePath, "Rose");

			taskPaneHost = (TaskPaneHost)taskpaneView.AddControl(Main.SWTASKPANE_PROGID, string.Empty);
		}

		/// <summary>
		/// Clean up on task pane close
		/// </summary>
		void UnloadUI()
		{

			taskPaneHost = null;
			taskpaneView.DeleteView();

			// Release memory
			Marshal.ReleaseComObject(taskpaneView);
		}

	}

}
