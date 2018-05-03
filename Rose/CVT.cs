using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rose
{
	public static class CVT
	{
		public static object Convert(double Value, string FromUnitsIn, string ToUnitsIn, int IgnoreDim = 0)
		{
			Unit FromUnits = new Unit(FromUnitsIn);
			Unit ToUnits = new Unit(ToUnitsIn);

			Value = Value * Unit.GetProduct(FromUnits.Numerator)
						  / Unit.GetProduct(FromUnits.Denominator)
						  * Unit.GetProduct(ToUnits.Denominator)
						  / Unit.GetProduct(ToUnits.Numerator);

			// Don't verify dimension of inputs
			if (IgnoreDim == 1)
			{
				return Value;
			}

			// Verify dimension of inputs
			else
			{

				FromUnits.NumeratorDimension = Unit.GetDimension(FromUnits.Numerator);
				FromUnits.DenominatorDimension = Unit.GetDimension(FromUnits.Denominator);
				ToUnits.NumeratorDimension = Unit.GetDimension(ToUnits.Numerator);
				ToUnits.DenominatorDimension = Unit.GetDimension(ToUnits.Denominator);

				string FromNumeratorDim = FromUnits.NumeratorDimension.Split('/')[0];
				if (FromUnits.DenominatorDimension.Split('/').Length > 1)
					FromNumeratorDim += " " + FromUnits.DenominatorDimension.Split('/')[1];

				string FromDenominatorDim = FromUnits.DenominatorDimension.Split('/')[0];
				if (FromUnits.NumeratorDimension.Split('/').Length > 1)
					FromDenominatorDim += " " + FromUnits.NumeratorDimension.Split('/')[1];

				string ToNumeratorDim = ToUnits.NumeratorDimension.Split('/')[0];
				if (ToUnits.DenominatorDimension.Split('/').Length > 1)
					ToNumeratorDim += " " + ToUnits.DenominatorDimension.Split('/')[1];

				string ToDenominatorDim = ToUnits.DenominatorDimension.Split('/')[0];
				if (ToUnits.NumeratorDimension.Split('/').Length > 1)
					ToDenominatorDim += " " + ToUnits.NumeratorDimension.Split('/')[1];

				FromNumeratorDim = Unit.FlattenUnits(FromNumeratorDim);
				FromDenominatorDim = Unit.FlattenUnits(FromDenominatorDim);
				ToNumeratorDim = Unit.FlattenUnits(ToNumeratorDim);
				ToDenominatorDim = Unit.FlattenUnits(ToDenominatorDim);

				char[] TrimChars = new char[] { ' ', '/' };
				FromUnits.Dimension = (FromNumeratorDim + "/" + FromDenominatorDim).Replace("s/s", "").Trim(TrimChars);
				ToUnits.Dimension = (ToNumeratorDim + "/" + ToDenominatorDim).Replace("s/s", "").Trim(TrimChars);

				if (FromUnits.Dimension != ToUnits.Dimension)
				{
					return "!!DIM: " + "[" + FromUnits.Dimension + "] " + '\u2260'.ToString()
						+ " " + "[" + ToUnits.Dimension + "]!!";
				}

				else
				{
					return Value;
				}
			}
		}
	}
}
