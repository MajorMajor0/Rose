using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseWorks
{
	public static class DrawingTree
	{
		/// <summary>
		/// Create and export a drawing tree from an assembly document
		/// </summary>
		/// <returns></returns>
		public static List<string[]> GetDrawingTree(ModelDoc2 modelDoc2)
		{
			try
			{
				ComponentR component = ComponentR.CreateComponentR(modelDoc2);

			}

			catch (Exception)
			{
				Reporter.Report("Something went wrong and an exception was caught while getting the drawing tree.");
			}

			return new List<string[]>();
		}

	}
}
