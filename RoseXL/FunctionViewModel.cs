using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Text.RegularExpressions;
using Excel = Microsoft.Office.Interop.Excel;
using Rose;

namespace RoseXL
{
	class FunctionViewModel : INotifyPropertyChanged
	{
		static int bailout = 0;
		static int bailoutCount = 200;
		Excel.Application ExcelApp;

		Excel.Worksheet activeSheet => ExcelApp?.ActiveSheet as Excel.Worksheet;

		Excel.Range activeRange => ExcelApp?.Selection as Excel.Range;

		public FunctionViewModel(Excel.Application excelApp)
		{
			ExcelApp = excelApp;
			ConvertToXLCommand = new Command(ConvertRangeToXL, ConvertToXLCanExecute, "Convert to XL", "Converts the selected cells from Rose functions to pure excel.");
			CreateRoseExcelFuctions();
		}

		public Command ConvertToXLCommand { get; set; }

		public List<RoseExcelFunction> RoseExcelFunctions { get; set; }

		bool ConvertToXLCanExecute()
		{
			return activeRange != null;
		}

		/// <summary>
		/// Convert Rose functions to pure excel.
		/// </summary>
		void ConvertRangeToXL()
		{
			try
			{
				// Do this stuff if the selected range is more than 1 cell
				if (activeRange.Formula is object[,])
				{
					object[,] formulas = (object[,])activeRange.Formula;
					int rank = formulas.Rank;
					int N_i = formulas.GetLength(0);
					int N_j = rank > 1 ? N_j = formulas.GetLength(1) : N_j = 1;

					Debug.Assert(rank < 3, "Check why formulas.Rank > 2.");
					for (int i = 1; i <= N_i; i++)
					{
						for (int j = 1; j <= N_j; j++)
						{
							string formula = formulas[i, j] as string;

							if (ConvertCellToXL(formula, out formula))
							{
								formulas[i, j] = formula;
							}
						}
					}
					activeRange.Formula = formulas;
					int g = 0;
					Debug.WriteLine(g++);
				}

				// Do this stuff if only one cell is selected
				else if (activeRange.Formula is string)
				{
					string formula = activeRange.Formula as string;
					if (ConvertCellToXL(formula, out formula))
					{
						activeRange.Formula = formula;
					}

				}
				//object[,] values = activeRange.Value2 as object[,];
				//var a = activeRange.Address; e.g. "$E$2:$F$7"
			}

			catch (Exception ex)
			{

			}
		}

		/// <summary>
		/// Having determined that a cell contains a formula, pass it here to be converted
		/// </summary>
		/// <param name="formula"></param>
		/// <param name="outer"></param>
		/// <returns>A string with no custom Rose code.</returns>
		bool ConvertCellToXL(string formula, out string outer)
		{
			outer = "";
			bool returner = false;

			if (!string.IsNullOrEmpty(formula))
			{
				foreach (var roseEF in RoseExcelFunctions)
				{
					Regex matcher = new Regex($"\\b{roseEF.Name}\\(");
					if (matcher.IsMatch(formula))
					{
						if (roseEF.Converter != null)
						{
							bailout = 0;
							outer = roseEF.Converter(formula);
							returner = true;
						}
					}
				}
			}
			return returner;
		}

		static string CVTConverter(string cellContents)
		{
			string returner = "cvt converted";
			return returner;
		}
		/// <summary>
		/// Recursively remove the innermost instance of an RSS() function
		/// </summary>
		/// <param name="cellContents"></param>
		/// <returns></returns>
		static string RSSConverter(string cellContents)
		{
			string returner = cellContents;

			if (cellContents.Contains("RSS("))
			{
				int rssIndex = returner.LastIndexOf("RSS(");
				int gutsIndex = rssIndex + 4;

				int parenthesis = 1;
				int closingIndex = gutsIndex;
				while (parenthesis > 0)
				{
					closingIndex++;
					if (returner[closingIndex] == ')')
					{
						parenthesis -= 1;
					}
					else if (returner[closingIndex] == '(')
					{
						parenthesis += 1;
					}
				}

				int gutsLength = closingIndex - gutsIndex;
				int totalLength = gutsLength + 5;
				string guts = returner.Substring(gutsIndex, gutsLength);
				returner = returner.Remove(rssIndex, totalLength);
				returner = returner.Insert(rssIndex, $"SQRT(SUMSQ({guts}))");

				if (returner.Contains("RSS(") && bailout++ < bailoutCount)
				{
					returner = RSSConverter(returner);
				}
			}

			return returner;
		}

		void CreateRoseExcelFuctions()
		{
			RoseExcelFunctions = new List<RoseExcelFunction>();
			RoseExcelFunctions.Add(
				new RoseExcelFunction
				{
					Name = "CVT",
					Latex = "input*factor",
					Description = "Convert Units",
					Help = "Returns the input value converted from any units to any units of the same dimension. Returns an error if from and to units are of different dimension.\n\n• Ignores parenthesis. \n• Treats space, *, -, or dot as multiplication\n• Only one division allowed in units.",
					Formula = "CVT(Value, From, To)",
					Reference = "NIST",
					Arguments = new List<string>
					{
						"Value (double): THe value to be converted.",
						"From (string): The units the value is provided in.",
						"To (string): The units to convert to."
					},
					Converter = CVTConverter
				});

			RoseExcelFunctions.Add(
			new RoseExcelFunction
			{
				Name = "MAJORDIAMETER",
				Latex = @"D",
				Description = "Major Diameter",
				Help = "Returns the major diameter of a valid thread callout.",
				Formula = "MAJORDIAMETER(Callout, Limit, Units)",
				Reference = "Machinery's Handbook, 27th Edition",
				Arguments = new List<string>
				{
					"Callout (string): Thread callout in the form .250-20 UNC 2A.",
					"Limit (string): min, max or nominal, based on thread tolerances.",
					"Units (string): Units of the result. Default = inches."
				}
			});

			RoseExcelFunctions.Add(
			new RoseExcelFunction
			{
				Name = "MINORAREA",
				Latex = @"A_m",
				Description = "Minor Diameter Area",
				Help = "Returns the cross-section area of a valid external thread based on the minor diameter.",
				Formula = "MINORAREA(Callout, Limit, Units)",
				Reference = "Machinery's Handbook, 27th Edition",
				Arguments = new List<string>
				{
					"Callout (string): Thread callout in the form .250-20 UNC 2A.",
					"Limit (string): min, max or nominal, based on thread tolerances.",
					"Units (string): Units of the result. Default = inches."
				}
			});

			RoseExcelFunctions.Add(
				new RoseExcelFunction
				{
					Name = "MINORDIAMETER",
					Latex = @"D_m",
					Description = "Minor Diameter",
					Help = "Returns the minor diameter of a valid thread callout.",
					Formula = "MINORDIAMETER(Callout, Limit, Units)",
					Reference = "Machinery's Handbook, 27th Edition",
					Arguments = new List<string>
					{
						"Callout (string): Thread callout in the form .250-20 UNC 2A.",
						"Limit (string): min, max or nominal, based on thread tolerances.",
						"Units (string): Units of the result. Default = inches."
					}
				});

			RoseExcelFunctions.Add(
				new RoseExcelFunction
				{
					Name = "PITCHDIAMETER",
					Latex = @"D_p",
					Description = "Pitch Diameter",
					Help = "Returns the pitch diameter of a valid thread callout.",
					Formula = "PITCHDIAMETER(Callout, Limit, Units)",
					Reference = "Machinery's Handbook, 27th Edition",
					Arguments = new List<string>
					{
						"Callout (string): Thread callout in the form .250-20 UNC 2A.",
						"Limit (string): min, max or nominal, based on thread tolerances.",
						"Units (string): Units of the result. Default = inches."
					}
				});

			RoseExcelFunctions.Add(
				new RoseExcelFunction
				{
					Name = "RSS",
					Latex = @"\sum_{i=1}^n x_i^2",
					Description = "Root Sum Square",
					Help = "Returns the root sum square of each cell in up to 8 ranges, Equivalent to SQRT(SUMSQ())",
					Formula = "RSS(x1, x2:x3, x4...)",
					Reference = "",
					Converter = RSSConverter
				});

			RoseExcelFunctions.Add(
				new RoseExcelFunction
				{
					Name = "SIGFIGS",
					Latex = @"",
					Description = "Significant Figures",
					Help = "Returns the input value rounded to the desired number of significant figures. Should be used only in an output cell, since it is not a format but a truncation.",
					Formula = "SIGFIGS(Value, Significant Figures)",
					Arguments = new List<string>
					{
						"Value (double): The number to be rounded.",
						"Significant figures (int): The number of significant figures in the result."
					}
				});

			RoseExcelFunctions.Add(
				new RoseExcelFunction
				{
					Name = "TENSILEAREA",
					Latex = @"A_s",
					Description = "Tensile Stress Area",
					Help = "Returns the tensile stress area of a valid internal thread callout.",
					Formula = "TENSILEAREA(Callout, Limit, Units)",
					Reference = "Machinery's Handbook, 27th Edition",
					Arguments = new List<string>
					{
						"Callout (string): Thread callout in the form .250-20 UNC 2A.",
						"Limit (string): min, max or nominal, based on thread tolerances.",
						"Units (string): Units of the result. Default = inches."
					}
				});

			RoseExcelFunctions.Add(
			new RoseExcelFunction
			{
				Name = "TURBOENCABULATOR",
				Latex = @"T_e",
				Description = "Turboencabulator",
				Help = "Returns the turbo-encabulation of disparate, frangible binaries.",
				Formula = "TURBOENCABULATOR(Callout, Limit, Units)",
				Reference = "GE HBK-8359 Dec 31, 1962, Pg 801",
				Arguments = new List<string>
				{
					"B0 (bool): Binary #0.",
					"B1 (bool): Binary #1."
				}
			});
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


	public class RoseExcelFunction
	{
		public string Name { get; set; }
		public string Latex { get; set; }
		public string PaddedLatex => @"\color{white}" + Latex;
		public string Description { get; set; }
		public string Help { get; set; }
		public string Formula { get; set; }
		public string Reference { get; set; }
		public List<string> Arguments { get; set; }
		public Func<string, string> Converter { get; set; }
	}

}


//private string name;
//public string Name
//{
//	get { return name; }
//	set { SetField(ref name, value, "Name"); }
//}