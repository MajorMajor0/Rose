using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SolidWorks.Interop.sldworks;

namespace RoseWorks
{
	class ComponentR
	{
		public string Filename { get; set; }

		public string Number { get; set; }

		public List<ComponentR> Children { get; set; }

		public Dictionary<string, string> Properties;

		protected Component2 component2;

		protected ModelDoc2 modelDoc2;

		public ComponentR()
		{
			Properties = new Dictionary<string, string>();
			Children = new List<ComponentR>();
		}

		public ComponentR(Component2 _component2)
		{
			component2 = _component2;

			modelDoc2 = _component2.GetModelDoc2() as ModelDoc2;

			List<Component2> childComponents2 = component2.GetChildrenR(true);

			Children = new List<ComponentR>();

			foreach (Component2 childComponent in childComponents2)
			{
				Children.Add(new ComponentR(childComponent));
			}

			Properties = new Dictionary<string, string>();

			List<string> propertyNames = component2.GetPropertyNamesR(topLevelOnly: true);

			foreach (string propertyName in propertyNames)
			{
				Properties[propertyName] = component2.GetPropertyR(propertyName);
			}
		}
	}

	class AssemblyR : ComponentR
	{

		public AssemblyR(Component2 _component2)
		{
			if()
			component2 = _component2;

			modelDoc2 = _component2.GetModelDoc2() as ModelDoc2;

			List<Component2> childComponents2 = component2.GetChildrenR(true);

			Children = new List<ComponentR>();

			foreach (Component2 childComponent in childComponents2)
			{
				Children.Add(new ComponentR(childComponent));
			}

			Properties = new Dictionary<string, string>();

			List<string> propertyNames = component2.GetPropertyNamesR(topLevelOnly: true);

			foreach (string propertyName in propertyNames)
			{
				Properties[propertyName] = component2.GetPropertyR(propertyName);
			}
		}

	}

}
