using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseWorks
{
	class DrawingTree
	{
		/// <summary>
		/// Create and export a drawing tree from an assembly document
		/// </summary>
		/// <returns></returns>
		public List<string[]> GetDrawingTree()
		{
			try
			{
				if (SW.App.ActiveDoc is AssemblyDoc Assembly)
				{
					List<string> PropertyNames = Assembly.GetAllPropertyNames();
				}


			}

			catch (Exception ex)
			{

			}

			return new List<string[]>();
		}

		
	}
}
