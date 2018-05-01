namespace RoseXL
{
	using System;
	using System.Runtime.InteropServices;
	using System.Windows.Forms;
	using System.Windows.Forms.Integration;

	using ExcelDna.Integration;
	using ExcelDna.Integration.CustomUI;


	/////////////// Define the backing class for the Ribbon ///////////////////////////
	// Would need to be marked with [ComVisible(true)] if in a project that is marked as [assembly:ComVisible(false)] which is the default for VS projects.
	[ComVisible(true)]
	public class RoseRibbon : ExcelRibbon
	{
		static CustomTaskPane BoltTaskPane;

		public void ShowBoltTaskPane(IRibbonControl control)
		{
			if (BoltTaskPane == null)
			{
				// Make a new one using ExcelDna.Integration.CustomUI.CustomTaskPaneFactory 
				BoltTaskPane = CustomTaskPaneFactory.CreateCustomTaskPane(typeof(RoseXL.BoltTaskPane), "Bolts");
				BoltTaskPane.Visible = true;
				BoltTaskPane.DockPosition = MsoCTPDockPosition.msoCTPDockPositionLeft;
				BoltTaskPane.DockPositionStateChange += ctp_DockPositionStateChange;
				BoltTaskPane.VisibleStateChange += ctp_VisibleStateChange;
			}
			else
			{
				// Just show it again
				BoltTaskPane.Visible = true;
			}
		}

		//public void OnDeleteCTP(IRibbonControl control)
		//{
		//	if (BoltTaskPane != null)
		//	{
		//		// Could hide instead, by calling ctp.Visible = false;
		//		BoltTaskPane.Delete();
		//		BoltTaskPane = null;
		//	}
		//}

		static CustomTaskPane FunctionListPane;

		public void ShowFunctionListTaskPane(IRibbonControl control)
		{
			if (FunctionListPane == null)
			{
				// Make a new one using ExcelDna.Integration.CustomUI.CustomTaskPaneFactory 
				FunctionListPane = CustomTaskPaneFactory.CreateCustomTaskPane(typeof(RoseXL.FunctionFormControl), "Functions");
				FunctionListPane.Visible = true;
				FunctionListPane.DockPosition = MsoCTPDockPosition.msoCTPDockPositionLeft;
				FunctionListPane.DockPositionStateChange += ctp_DockPositionStateChange;
				FunctionListPane.VisibleStateChange += ctp_VisibleStateChange;
			}
			else
			{
				// Just show it again
				FunctionListPane.Visible = true;
			}
		}



		



		

		static void ctp_VisibleStateChange(CustomTaskPane CustomTaskPaneInst)
		{
			//MessageBox.Show("Visibility changed to " + CustomTaskPaneInst.Visible);
		}

		static void ctp_DockPositionStateChange(CustomTaskPane CustomTaskPaneInst)
		{
			//((MyUserControl)ctp.ContentControl).Content.MyLabel.Content = "Moved to " + CustomTaskPaneInst.DockPosition.ToString();
		}

	}

}