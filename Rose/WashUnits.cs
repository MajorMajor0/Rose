using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rose
{
	public static class WashUnits
	{
		public static object WashUnits1(double Value, string Callout, string ToUnits)
		{
			string FromUnits = "in";

			if (Callout[0] == 'M') { FromUnits = "mm"; }

			if (string.IsNullOrWhiteSpace(ToUnits))
			{
				if (Callout[0] == 'M') { ToUnits = "mm"; }
				else { ToUnits = "in"; }
			}

			try
			{
				return Math.Round(Convert.ToDouble(CVT.Convert(Value, FromUnits, ToUnits)), 4);
			}
			catch (System.FormatException)
			{
				return "Check units!";
			}

		}

		public static object WashUnits2(double Value, string Callout, string ToUnits)
		{
			string FromUnits = "in2";

			if (Callout[0] == 'M')
			{
				FromUnits = "mm2";
			}

			if (string.IsNullOrWhiteSpace(ToUnits))
			{
				if (Callout[0] == 'M') { ToUnits = "mm2"; }
				else { ToUnits = "in2"; }
			}

			try
			{
				return Math.Round(Convert.ToDouble(CVT.Convert(Value, FromUnits, ToUnits)), 4);
			}
			catch (FormatException)
			{
				return "Check units!";
			}

		}
	}
}
