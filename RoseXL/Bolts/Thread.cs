using System.Collections.Generic;
using System.IO;

namespace Bolts
{
	class Threads
	{
		internal static List<Thread> List { get; set; }

		static Threads()
		{
			double[] x = new double[16];

			List = new List<Thread>();
			// List the columns in the thread data that are numbers 
			int[] doubles = { 1, 2, 5, 6, 7, 8, 9, 10, 11, 12, 13 };

			// Get thread data from constant string
			StringReader csv = new StringReader(ThreadData.Threads);
			{
				string line;
				string[] lineParse;
				while ((line = csv.ReadLine()) != null)
				{
					// Put the current line in a string array
					lineParse = line.Split('|');

					foreach (int i in doubles)
					{
						if (double.TryParse(lineParse[i], out x[i])) { }
						else { x[i] = -1; }
					}

					if (x[2] == -1)
					{
						x[2] = 1 / x[3];
					}
					else
					{
						x[3] = 1 / x[2];
					}

					Thread thread = new Thread(lineParse[0], x[1], x[2], lineParse[3],
					lineParse[4], x[5], x[6], x[7], x[8], x[9], x[10], x[11],
					x[12], x[13]);

					List.Add(thread);
				}
			}
		}
	}

	internal class Thread
	{
		public string Fraction { get; }
		public double N { get; }
		public double P { get; }
		public string Series { get; }
		public string Class { get; }
		public string FractionCallout
		{
			get
			{
				if (Series == "M")
				{
					return "METRIC";
				}
				else
				{
					return string.Concat(Fraction, "-", N, " ", Series, " ", Class);
				}
			}
		}
		public string DecimalCallout { get; }
		public double Allowance { get; }
		public double MajorMax { get; }
		public double MajorBasic { get; }
		public double MajorMin { get; }
		public double MajorMinE { get; }
		public double PitchMax { get; }
		public double PitchMin { get; }
		public double MinorMax { get; }
		public double MinorMin { get; }
		public double Tolerance { get; }

		public Thread(string fraction, double n, double p, string series, string clas,
			double allowance, double majormax, double majorbasic, double majormin,
			double pitchmax, double pitchmin, double minormax, double minormin, double tolerance)
		{

			Fraction = fraction;
			N = n;
			P = p;
			Series = series;
			Class = clas;
			Allowance = allowance;
			MajorMax = majormax;
			MajorBasic = majorbasic;
			MajorMin = majormin;
			PitchMax = pitchmax;
			PitchMin = pitchmin;
			MinorMax = minormax;
			MinorMin = minormin;
			Tolerance = tolerance;
		}

		public static Thread Get(string callout)
		{
			//Thread CurrentThread = null;

			//if (Threads.List.Find(x => x.DecimalCallout.Equals(callout)) != null)
			//{
			//	CurrentThread = Threads.List.Find(x => x.DecimalCallout.Equals(callout));
			//}

			//else if (Threads.List.Find(x => x.FractionCallout.Equals(callout)) != null)
			//{
			//	CurrentThread = Threads.List.Find(x => x.FractionCallout.Equals(callout));
			//}

			//return CurrentThread;

			return Threads.List.Find(x => x.DecimalCallout.Equals(callout)) ?? Threads.List.Find(x => x.FractionCallout.Equals(callout));
		}
	}
}
