﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;
using UnitConverter;
using Bolts;



using System.ComponentModel;
using System.Diagnostics;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;

namespace Rose
{
	public static class Functions
	{
		[ExcelFunction(Description = "Convert units")]
		public static object CVT(double value, string fromUnitsIn, string toUnitsIn, int ignoreDim = 0)
		{
			return UnitConverter.CVT.Convert(value, fromUnitsIn, toUnitsIn, ignoreDim);
		}

		[ExcelFunction(Description = "Significant figures")]
		public static object SIGFIGS(double Value, int SigFigs)
		{
			string Format = "G" + SigFigs;
			string ResultString = Value.ToString(Format);
			return double.Parse(ResultString);
		}

		[ExcelFunction(Description = "Root sum squared")]
		public static double RSS(params double[] values)
		{
			double Sum = 0;
			for (int i = 0; i < values.Length; i++)
			{
				Sum += values[i] * values[i];
			}

			return Math.Sqrt(Sum);
		}

		[ExcelFunction(Description = "Concatenate a range of cells")]
		public static object JOIN(string seperator, params object[] values )
		{
			return string.Join(seperator, values).Replace("ExcelDna.Integration.ExcelEmpty","");
		}

		[ExcelFunction(Description = "Return the minor diameter of a thread")]
		public static object MINORDIAMETER(string callout, string limit, string toUnits = "")
		{
			double MinorDiameter = 0;

			callout = callout.ToUpper();
			limit = limit.ToLower();

			Thread thread = Thread.Get(callout);

			if (thread != null)
			{
				switch (limit)
				{
					case "min":
					case "minimum":
						MinorDiameter = thread.MinorMin;
						if (MinorDiameter == -1)
						{
							return "Minimum minor diameter not defined for this thread";
						}
						break;
					case "max":
					case "maximum":
						MinorDiameter = thread.MinorMax;
						if (MinorDiameter == -1)
						{
							return "Maximum minor diameter not defined for this thread";
						}
						break;
					case "nom":
					case "nominal":
					case "basic":
					default:

						// Thread height
						double H = thread.P * Math.Sqrt(3) / 2;

						MinorDiameter = thread.MajorBasic - 10 * H / 8;
						break;
				}
				return WashUnits.WashUnits1(MinorDiameter, callout, toUnits);
			}
			else return "Thread not found. Format should be 0-80 UNF 2A";
		}

		[ExcelFunction(Description = "Return the major diameter of a bolt")]
		public static object MAJORDIAMETER(string callout, string limit = "min", string toUnits = "")
		{
			Double majorDiameter;

			callout = callout.ToUpper();
			limit = limit.ToLower();
			Thread CurrentThread = Thread.Get(callout);

			if (CurrentThread != null)
			{
				switch (limit)
				{
					case "min":
					case "minimum":
						majorDiameter = CurrentThread.MajorMin;
						if (majorDiameter == -1)
						{
							return "Minimum major diameter not defined for this thread";
						}
						break;
					case "max":
					case "maximum":
						majorDiameter = CurrentThread.MajorMax;
						if (majorDiameter == -1)
						{
							return "Maximum major diameter not defined for this thread";
						}
						break;
					case "nom":
					case "nominal":
					case "basic":
					default:
						majorDiameter = CurrentThread.MajorBasic;
						break;
				}
				return WashUnits.WashUnits1(majorDiameter, callout, toUnits);
			}
			else return "Thread not found.Format should be 0 - 80 UNF 2A";
		}

		[ExcelFunction(Description = "Return the pitch diameter of a bolt")]
		public static object PITCHDIAMETER(string callout, string limit = "min", string toUnits = "")
		{
			Double PitchDiameter;

			callout = callout.ToUpper();
			limit = limit.ToLower();
			Thread thread = Thread.Get(callout);

			if (thread != null)
			{
				switch (limit)
				{
					case "min":
					case "minimum":
						PitchDiameter = thread.PitchMin;
						break;
					case "max":
					case "maximum":
						PitchDiameter = thread.PitchMax;
						break;
					case "nom":
					case "nominal":
					case "basic":
					default:

						// Thread height
						double H = thread.P * Math.Sqrt(3) / 2;

						PitchDiameter = thread.MajorBasic - 3 * H / 4;

						break;
				}
				return WashUnits.WashUnits1(PitchDiameter, callout, toUnits);
			}
			else return "Thread not found. Format should be 0-80 UNF 2A";
		}

		[ExcelFunction(Description = "Return the tensile stress area of a bolt per FED-STD-H28")]
		public static object TENSILEAREA(string callout, string limit = "min", string ToUnits = "")
		{
			//callout = callout.ToUpper();
			limit = limit.ToLower();
			Thread CurrentThread = Thread.Get(callout);
			double dm = 0; // Minor diameter
			double dp = 0; // Pitch diameter

			double P = 1 / CurrentThread.N; // Pitch
			double H = Math.Sqrt(3) * P / 2; // Thread height
			double d1; // Minor diameter
			double d2; // Pitch diameter
			double d3;

			if (CurrentThread.Class[1] == 'B' || CurrentThread.Class[1] == 'H')
			{
				return "Tensile area not defined for internal thread";
			}

			if (CurrentThread != null)
			{
				switch (limit)
				{
					case "min":
					case "minimum":
						dm = CurrentThread.MinorMin;
						dp = CurrentThread.PitchMin;

						// In case of metric thread
						d1 = CurrentThread.MajorMin - 1.082532 * P;
						d2 = CurrentThread.MajorMin - 0.649515 * P;
						d3 = d1 - H / 6;
						break;
					case "max":
					case "maximum":
						dm = CurrentThread.MinorMax;
						dm = CurrentThread.MinorMin;

						// In case of metric thread
						d1 = CurrentThread.MajorMax - 1.082532 * P; // Minor diameter
						d2 = CurrentThread.MajorMax - 0.649515 * P; // Pitch diameter
						d3 = d1 - H / 6;
						break;
					case "nom":
					case "nominal":
					case "basic":
					default:
						dm = Convert.ToDouble(MINORDIAMETER(callout, "basic"));
						dp = Convert.ToDouble(PITCHDIAMETER(callout, "basic"));

						// In case of metric thread
						d1 = CurrentThread.MajorMax - 1.082532 * P; // Minor diameter
						d2 = CurrentThread.MajorMax - 0.649515 * P; // Pitch diameter
						d3 = d1 - H / 6;
						break;
				}
				// In case of metric
				if (callout[0] == 'M')
				{
					return WashUnits.WashUnits2(Math.PI * (d2 + d3) * (d2 + d3) / 16, callout, ToUnits);
				}

				// In case of standard
				else
				{
					return WashUnits.WashUnits2(Math.PI * (dm + dp) * (dm + dp) / 16, callout, ToUnits);
				}

			}
			else return "Bolt callout not found!";
		}

		[ExcelFunction(Description = "Return the minor diameter area of a bolt")]
		public static object MINORAREA(string callout, string ToUnits = "")
		{
			Thread CurrentThread = Thread.Get(callout);
			if (CurrentThread.Class[1] == 'B' || CurrentThread.Class[1] == 'H')
			{
				return "Minor diameter area not defined for internal thread";
			}

			object MinorDiameter = MINORDIAMETER(callout, "basic");
			//object MinorDiameter = Convert.ToDouble(MD);

			// Test whether minor diameter is defined
			if (Double.TryParse(MinorDiameter.ToString(), out double dm))
			{
				return WashUnits.WashUnits2(Math.PI * dm * dm / 4, callout, ToUnits);
			}

			else
			{
				return "Minor diameter not defined";
			}
		}

		[ExcelFunction(Description = "Return the lead angle of a bolt")]
		public static object LEADANGLE(string callout)
		{
			double Pitch;
			Thread CurrentThread = Thread.Get(callout);

			if (CurrentThread != null)
			{
				Double.TryParse(PITCHDIAMETER(callout, "basic", "in").ToString(), out double PitchDiameter);
				if (callout[0] == 'M')
				{
					Pitch = CurrentThread.N;
				}
				else
				{
					Pitch = 1 / CurrentThread.N;
				}

				return Math.Atan(Pitch / (Math.PI * PitchDiameter)) * 180 / Math.PI;
			}
			else
			{
				return "Thread callout not found";
			}
		}

		[ExcelFunction(IsMacroType = true)]
		public static object[,] FUNCTIONTOFORMULA(
		[ExcelArgument(AllowReference = true)]object arg)
		{
			ExcelReference theRef = (ExcelReference)arg;
			int rows = theRef.RowLast - theRef.RowFirst + 1;
			object[,] res = new object[rows, 1];
			for (int i = 0; i < rows; i++)
			{
				ExcelReference cellRef = new ExcelReference(
					theRef.RowFirst + i, theRef.RowFirst + i,
					theRef.ColumnFirst, theRef.ColumnFirst,
					theRef.SheetId);
				res[i, 0] = XlCall.Excel(XlCall.xlfGetFormula, cellRef);
			}
			return res;
		}






	}
}
