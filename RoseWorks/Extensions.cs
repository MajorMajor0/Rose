using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseWorks
{
	static class Extensions
	{
		/// <summary>
		/// Get a typed list of unique property names in a ModelDoc.
		/// </summary>
		/// <param name="modelDoc">this</param>
		/// <param name="configuration">Name of the configuration to seacrch for properties. Default = "".</param>
		/// <returns></returns>
		public static List<string> GetPropertyNames(this ModelDoc2 modelDoc, string configuration = "")
		{
			return modelDoc.Extension.get_CustomPropertyManager(configuration).GetNames() as List<string>;
		}

		/// <summary>
		/// Get typed list of unique property names in a component that is a ModelDoc.
		/// </summary>
		/// <param name="modelDoc">this</param>
		/// <param name="configuration">Name of the configuration to seacrch for properties. Default = "".</param>
		/// <returns></returns>
		public static List<string> GetPropertyNames(this Component2 component, string configuration = "")
		{
			ModelDoc2 modelDoc = component.GetModelDoc2() as ModelDoc2;
			return modelDoc?.Extension.get_CustomPropertyManager(configuration).GetNames() as List<string>;
		}

		/// <summary>
		/// Get a typed list of all components in an AssemblyDOc
		/// </summary>
		/// <param name="assemblyDoc"></param>
		/// <param name="topLevelOnly"></param>
		/// <returns></returns>
		public static List<Component2> GetComponents2(this AssemblyDoc assemblyDoc, bool topLevelOnly = false)
		{
			object[] objects = assemblyDoc.GetComponents(topLevelOnly) as object[];

			List<Component2> components2 = new List<Component2>();

			foreach (Object ob in objects)
			{
				components2.Add(ob as Component2);
			}

			return components2;
		}

		public static List<string> GetAllPropertyNames(this AssemblyDoc assemblyDoc, bool topLevelOnly = false)
		{
			List<String> propertyNames = new List<string>();

			List<Component2> AssemblyComponents = assemblyDoc.GetComponents2(topLevelOnly);

			foreach (Component2 component in AssemblyComponents)
			{
				propertyNames.AddRange(component.GetPropertyNames());
			}

			return propertyNames.Distinct().OrderBy(x => x).ToList();
		}
	}


}
