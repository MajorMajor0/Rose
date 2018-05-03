using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;

namespace RoseXL
{
	class FunctionViewModel : INotifyPropertyChanged
	{
		Excel.Application ExcelApp;

		Excel.Worksheet activeSheet => ExcelApp?.ActiveSheet;

		Excel.Range activeRange => ExcelApp?.Selection;

		public FunctionViewModel(Excel.Application excelApp)
		{
			ExcelApp = excelApp;
			ConvertToXLCommand = new Command(ConvertToXL, ConvertToXLCanExecute, "Convert to XL", "Converts the selected cells from Rose functions to pure excel.");
		}

		public Command ConvertToXLCommand { get; set; }

		bool ConvertToXLCanExecute()
		{
			return activeRange != null;
		}

		/// <summary>
		/// Convert Rose functions to pure excel
		/// </summary>
		void ConvertToXL()
		{
			try
			{
				object[,] formulas = null;
				int N_i = 0;
				int N_j = 0;
				// Unreal, but excel returns one-indexed array
				int index = 1;

				formulas = activeRange.Formula as object[,];
				if (formulas != null)
				{
					N_i = formulas.GetLength(0) + 1;
					if (formulas.Rank > 1)
					{
						N_j = formulas.GetLength(1) + 1;
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
					index = 0;
				}

				//object[,] values = activeRange.Value2 as object[,];
				//var a = activeRange.Address; e.g. "$E$2:$F$7"

				if (formulas != null)
				{
					Debug.Assert(formulas.Rank <= 2, "Check why formulas.Rank > 2.");
					for (int i = index; i < N_i; i++)
					{
						for (int j = index; j < N_j; j++)
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



		public event PropertyChangedEventHandler PropertyChanged;

		protected virtual void OnPropertyChanged(string propertyName)
		{
			PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
		}
		protected bool SetField<T>(ref T field, T value, string propertyName)
		{
			if (EqualityComparer<T>.Default.Equals(field, value)) return false;
			field = value;
			OnPropertyChanged(propertyName);
			return true;
		}
	}
}


//private string name;
//public string Name
//{
//	get { return name; }
//	set { SetField(ref name, value, "Name"); }
//}