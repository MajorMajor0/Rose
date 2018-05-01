
using SolidWorks.Interop.sldworks;
using SolidWorks.Interop.swcommands;
using SolidWorks.Interop.swconst;
using SolidWorks.Interop.swpublished;
using SolidWorksTools;
using System.Runtime.InteropServices;
using System.IO;
using System.Collections.Generic;
using System;

namespace RoseWorks
{

	public static class SW
	{
		public static int Cookie { get; set; }

		public static SldWorks App { get; set; }

		public static ModelDoc2 ActiveDocument => App.ActiveDoc as ModelDoc2;
	}
}
