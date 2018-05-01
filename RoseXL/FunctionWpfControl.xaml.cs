using System;
using System.Runtime.InteropServices;
using System.Windows;
using System.Windows.Controls;
using Excel = Microsoft.Office.Interop.Excel;
using Office = Microsoft.Office.Core;
using Microsoft.Office.Tools.Excel;
using System.Collections.Generic;
using System.Text.RegularExpressions;
//using ExcelDna.Utilities;

namespace RoseXL
{
	/// <summary>
	/// Interaction logic for TaskPaneContent.xaml
	/// </summary>
	public partial class FunctionListContent : UserControl
	{

		Excel.Application ExcelApp;

		public FunctionListContent()
		{
			ExcelApp = (Excel.Application)Marshal.GetActiveObject("Excel.Application");
			InitializeComponent();
		}

		private void ConvertButton_Click(object sender, RoutedEventArgs e)
		{

			try
			{
				Excel.Worksheet activeSheet = ExcelApp.ActiveSheet;
				Excel.Range activeRange = ExcelApp.Selection as Excel.Range;
				object[,] formulas = null;
				int N_i = 0;
				int N_j = 0;

				if (activeRange != null)
				{
					formulas = activeRange.Formula as object[,];

					if (formulas != null)
					{
						N_i = formulas.GetLength(0);
						if (formulas.Rank > 1)
						{
							N_j = formulas.GetLength(1);
						}

						else
						{
							N_j = 1;
						}
					}
					else if (activeRange.Formula is string)
					{
						formulas = new object[,] { { activeRange.Formula as string } };
						N_i = 1;
						N_j = 1;
					}
				}

				//object[,] values = activeRange.Value2 as object[,];
				//var a = activeRange.Address; e.g. "$E$2:$F$7"

				if (formulas != null)
				{
					for (int i = 1; i <= N_i; i++)
					{
						for (int j = 1; j <= N_j; j++)
						{
							string formula = formulas[i, j] as string;
							if (!string.IsNullOrEmpty(formula))
							{
								string functionName = Regex.Match(formula, @"(?<=\=).+?(?=\()").Value;
								if (!string.IsNullOrEmpty(functionName) && FunctionDictionary.ContainsKey(functionName))
								{
									formulas[i, j] = FunctionDictionary[functionName](formula);
								}
							}
						}
					}
					activeRange.Formula = formulas;
				}
			}

			catch (Exception ex)
			{

			}
		}

		static Dictionary<string, Func<string, string>> FunctionDictionary = new Dictionary<string, Func<string, string>>
		{
			{"CVT", CVTConverter},
			{"RSS", RSSConverter}

		};

		static string CVTConverter(string cellContents)
		{
			string returner = "cvt converted";


			return returner;
		}
		static string RSSConverter(string cellContents)
		{
			string returner = "rss converted";


			return returner;
		}
	}
}