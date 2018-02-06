using SolidWorks.Interop.sldworks;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RoseWorks
{
	static class Extensions
	{
		#region ModelDoc2 Extesions

		/// <summary>
		/// Get a typed list of unique property names in a ModelDoc2.
		/// </summary>
		/// <param name="configurationName">Name of the configuration to secrch for properties. Default = ""</param>
		/// <returns></returns>
		public static List<string> GetPropertyNamesR(this ModelDoc2 modelDoc, string configurationName = "")
		{
			try
			{
				return modelDoc.Extension.CustomPropertyManager[configurationName].GetNames() as List<string>;
				//return modelDoc.Extension.get_CustomPropertyManager(configurationName).GetNames() as List<string>;
			}
			catch
			{
				Reporter.Report("Something went wrong getting a list of property names.");
				return new List<string>();
			}
		}

		/// <summary>
		/// Get a property from a ModelDoc2 by name.
		/// </summary>
		/// <param name="propertyName">Name of the property to return</param>
		/// <param name="configurationName">Name of the configuration to search for properties. Default = ""></param>
		/// <returns></returns>
		public static string GetPropertyR(this ModelDoc2 modelDoc2, string propertyName, string configurationName = "")
		{
			try
			{
				var x = modelDoc2.Extension.get_CustomPropertyManager("").Get6(propertyName, false, out string value, out string resolvedValue, out bool wasResolved, out bool linkToProperty);

				if (wasResolved)
				{
					return resolvedValue;
				}
				else
				{
					return value;
				}
			}

			catch
			{
				Reporter.Report("Something went wrong getting a custom property.");
				return "";
			}
		}

		#endregion ModelDoc2 Extesions

		#region Component2 extensions

		/// <summary>
		/// Get a typed list of child Component2. List is flattened if topLevelOnly = false (default);
		/// </summary>
		/// <param name="topLevelOnly"></param>
		/// <returns></returns>
		public static List<Component2> GetChildrenR(this Component2 component2, bool topLevelOnly = false)
		{
			try
			{
				List<Component2> components = new List<Component2>();

				if (component2.GetChildren() is object[] objects)
				{
					foreach (Object ob in objects)
					{
						Component2 newComponent2 = ob as Component2;
						components.Add(newComponent2);

						if (!topLevelOnly)
						{
							components.AddRange(newComponent2.GetChildrenR());
						}
					}
				}

				return components;
			}

			catch
			{
				Reporter.Report("Something went wrong getting a list of child components.");
				return new List<Component2>();
			}
		}

		/// <summary>
		/// Get typed list of unique property names in a component that is a ModelDoc.
		/// </summary>
		/// <param name="configuration">Name of the configuration to seacrch for properties. Default = "".</param>
		/// <param name="topLevelOnly"></param>
		/// <returns></returns>
		public static List<string> GetPropertyNamesR(this Component2 component2, string configuration = "", bool topLevelOnly = false)
		{
			try
			{
				List<string> returner = new List<string>();

				ModelDoc2 modelDoc = component2.GetModelDoc2() as ModelDoc2;

				returner.AddRange(modelDoc?.GetPropertyNamesR(configuration));

				if (!topLevelOnly)
				{

					foreach (Component2 child in component2.GetChildrenR())
					{
						returner.AddRange(child.GetPropertyNamesR());
					}
				}

				return returner;
			}
			catch
			{
				Reporter.Report("Something went wrong getting a list of property names.");
				return new List<string>();
			}
		}

		/// <summary>
		/// Safe get path name for a Component2
		/// </summary>
		/// <returns></returns>
		public static string GetFilenameR(this Component2 component2)
		{
			try
			{
				return component2.GetPathName();
			}

			catch
			{
				Reporter.Report("Problem getting path name of a component");
				return "";
			}
		}

		/// <summary>
		/// Get a property from the ModelDoc2 of a component by name
		/// </summary>
		/// <param name="propertyName"></param>
		/// <param name="configurationName"></param>
		/// <returns></returns>
		public static string GetPropertyR(this Component2 component2, string propertyName, string configurationName = "")
		{
			if (string.IsNullOrEmpty(configurationName))
			{
				configurationName = component2.ReferencedConfiguration;
			}

			return (component2.GetModelDoc2() as ModelDoc2).GetPropertyR(propertyName, configurationName);
		}

		#endregion Component2 extensions

		#region AssemblyDoc extensions

		/// <summary>
		/// Get a typed list of all components in an AssemblyDOc
		/// </summary>
		/// <param name="topLevelOnly"></param>
		/// <returns></returns>
		public static List<Component2> GetComponentsR(this AssemblyDoc assemblyDoc, bool topLevelOnly = false)
		{
			try
			{
				List<Component2> components2 = new List<Component2>();

				if (assemblyDoc.GetComponents(topLevelOnly) is object[] objects)
				{
					foreach (Object obj in objects)
					{
						components2.Add(obj as Component2);
					}
				}

				return components2;
			}

			catch
			{
				Reporter.Report("Something went wrong getting a list of children.");

				return new List<Component2>();
			}
		}

		/// <summary>
		/// Get list of unique property names for the assembly and all components.
		/// </summary>
		/// <param name="topLevelOnly"></param>
		/// <returns></returns>
		public static List<string> GetAllPropertyNamesR(this AssemblyDoc assemblyDoc, bool topLevelOnly = false)
		{
			try
			{
				List<String> propertyNames = new List<string>();

				List<Component2> AssemblyComponents = assemblyDoc.GetComponentsR(topLevelOnly);

				foreach (Component2 component in AssemblyComponents)
				{
					propertyNames.AddRange(component.GetPropertyNamesR());

				}

				return propertyNames.Distinct().OrderBy(x => x).ToList();
			}

			catch
			{
				Reporter.Report("Something went wrong getting a list of property names.");
				return new List<string>();
			}
		}

		#endregion AssemblyDoc extensions






	}
}
