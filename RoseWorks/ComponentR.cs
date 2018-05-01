using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace RoseWorks
{
	class ComponentR
	{
		protected string filename;
		public string Filename => filename;

		protected string number;
		public string Number => number;

		protected ModelDoc2 modelDoc2;

		protected Dictionary<string, string> properties;
		public Dictionary<string, string> Properties => properties;

		public ComponentR()
		{
			properties = new Dictionary<string, string>();
		}

		public static ComponentR CreateComponentR(Component2 component2)
		{
			return CreateComponentR(component2.GetModelDoc2() as ModelDoc2);
		}

		public static ComponentR CreateComponentR(ModelDoc2 modelDoc2)
		{
			if (modelDoc2 is AssemblyDoc)
			{
				return new AssemblyR(modelDoc2);
			}

			if (modelDoc2 is PartDoc)
			{
				return new PartR(modelDoc2);
			}

			return null;
		}

		public string DrawingTreeEntry(int level)
		{
			StringBuilder returner = new StringBuilder("");

			for (int i = 0; i < level; i++)
			{
				returner.Append("\t");
			}

			foreach (KeyValuePair<string, string> property in Properties)
			{
				returner.Append(property.Value);
				returner.Append("\t");
			}

			return returner.ToString();
		}
	}

	class AssemblyR : ComponentR
	{
		AssemblyDoc assemblyDoc => modelDoc2 as AssemblyDoc;

		public List<ComponentR> Children { get; }

		string configurationName => modelDoc2.GetActiveConfiguration() as string;

		public AssemblyR(ModelDoc2 _modelDoc2)
		{
			modelDoc2 = _modelDoc2;
			filename = modelDoc2.GetFilenameR();
			number = Path.GetFileNameWithoutExtension(filename);

			Children = new List<ComponentR>();
			properties = new Dictionary<string, string>();

			List<Component2> childComponents2 = assemblyDoc.GetComponentsR(true);
			foreach (Component2 childComponent in childComponents2)
			{
				Children.Add(CreateComponentR(childComponent));
			}

			List<string> propertyNames = modelDoc2.GetPropertyNamesR(configurationName);
			foreach (string propertyName in propertyNames)
			{
				Properties[propertyName] = modelDoc2.GetPropertyR(propertyName);
			}
		}

		public AssemblyR(Component2 component2) : this(component2.GetModelDoc2() as ModelDoc2)
		{
		}
	}

	class PartR : ComponentR
	{
		PartDoc partDoc => modelDoc2 as PartDoc;

		string configurationName => modelDoc2.GetActiveConfiguration() as string;

		public PartR(ModelDoc2 _modelDoc2)
		{
			modelDoc2 = _modelDoc2;
			filename = _modelDoc2.GetFilenameR();
			number = Path.GetFileNameWithoutExtension(filename);
			properties = new Dictionary<string, string>();

			List<string> propertyNames = modelDoc2.GetPropertyNamesR();

			foreach (string propertyName in propertyNames)
			{
				Properties[propertyName] = modelDoc2.GetPropertyR(propertyName);
			}
		}

		public PartR(Component2 _component2) : this(_component2.GetModelDoc2() as ModelDoc2)
		{
		}
	}

}
