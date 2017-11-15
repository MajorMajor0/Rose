using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ExcelDna.Integration;

namespace Rose
{
    public static class Functions
    {
        [ExcelFunction(Description = "Convert units")]
        public static object CVT(double Value, string FromUnitsIn, string ToUnitsIn, int IgnoreDim = 0)
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
                FromUnits.Dimension = (FromNumeratorDim + "/" + FromDenominatorDim).Replace("s/s","").Trim(TrimChars);
                ToUnits.Dimension = (ToNumeratorDim + "/" + ToDenominatorDim).Replace("s/s", "").Trim(TrimChars);

                if (FromUnits.Dimension != ToUnits.Dimension)
                {
                    return "!!DIM: " + "[" + FromUnits.Dimension + "] " + '\u2260'.ToString()
                        + " " + "[" +ToUnits.Dimension + "]!!";
                }

                else
                {
                    return Value;
                }
            }
        }
          
        [ExcelFunction(Description = "Significant figures")]
        public static object SIGFIGS(double Value, int SigFigs)
        {
            string Format = "G" + SigFigs.ToString();
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

        [ExcelFunction(Description = "Return the minor diameter of a bolt")]
        public static object MINORDIAMETER(string callout, string limit, string ToUnits = "")
        {
            double MinorDiameter = 0;

            //callout = callout.ToUpper();
            limit = limit.ToLower();

            Thread CurrentThread = Thread.Get(callout);

            // If the thread callout was found
            if (CurrentThread != null)
            {
                switch (limit)
                {
                case "min":
                case "minimum":
                    MinorDiameter = CurrentThread.MinorMin;
                    if (MinorDiameter == -1)
                    {
                        return "Minimum minor diameter not defined for this thread";
                    }
                    break;
                case "max":
                case "maximum":
                    MinorDiameter = CurrentThread.MinorMax;
                    if (MinorDiameter == -1)
                    {
                        return "Maximum minor diameter not defined for this thread";
                    }
                    break;
                case "nom":
                case "nominal":
                case "basic":
                default:
                                        
                    // Calculate pitch from threads per inch
                    double P = 1 / CurrentThread.N;

                    // N column (threads/in) for metric screws is really pitch already
                    if(CurrentThread.Class == "M")
                    {
                        P = CurrentThread.N;
                    }

                    // Thread height
                    double H = P * Math.Sqrt(3) / 2;

                    MinorDiameter = CurrentThread.MajorBasic - 10 * H / 8;
                    break;
                }
                return WashUnits(MinorDiameter,callout,ToUnits);
            }
            else return "Thread callout not found";
        }
       
        [ExcelFunction(Description = "Return the major diameter of a bolt")]
        public static object MAJORDIAMETER(string callout, string limit = "min", string ToUnits = "")
        {
            Double MajorDiameter;

            //callout = callout.ToUpper();
            limit = limit.ToLower();
            Thread CurrentThread = Thread.Get(callout);

            if (CurrentThread != null)
            {
                switch (limit)
                {
                    case "min":
                    case "minimum":
                        MajorDiameter = CurrentThread.MajorMin;
                        if (MajorDiameter == -1)
                        {
                            return "Minimum major diameter not defined for this thread";
                        }
                        break;
                    case "max":
                    case "maximum":
                        MajorDiameter = CurrentThread.MajorMax;
                        if (MajorDiameter == -1)
                        {
                            return "Maximum major diameter not defined for this thread";
                        }
                        break;
                    case "nom":
                    case "nominal":
                    case "basic":
                    default:
                        MajorDiameter = CurrentThread.MajorBasic;
                        break;
                                        }
                return WashUnits(MajorDiameter, callout, ToUnits);
            }
            else return "Thread callout not found";
        }

        [ExcelFunction(Description = "Return the pitch diameter of a bolt")]
        public static object PITCHDIAMETER(string callout, string limit = "min", string ToUnits = "")
        {
            Double PitchDiameter;

            //callout = callout.ToUpper();
            limit = limit.ToLower();
            Thread CurrentThread = Thread.Get(callout);

            if (CurrentThread != null)
            {
                switch (limit)
                {
                    case "min":
                    case "minimum":
                        PitchDiameter = CurrentThread.PitchMin;
                        break;
                    case "max":
                    case "maximum":
                        PitchDiameter = CurrentThread.PitchMax;
                        break;
                    case "nom":
                    case "nominal":
                    case "basic":
                    default:
                        // Calculate pitch from threads per inch
                        double P = 1 / CurrentThread.N;

                        // N column (threads/in) for metric screws is really pitch already
                        if (CurrentThread.Class == "M")
                        {
                            P = CurrentThread.N;
                        }

                        // Thread height
                        double H = P * Math.Sqrt(3) / 2;

                        PitchDiameter = CurrentThread.MajorBasic - 3 * H / 4;

                        break;
                }
                return WashUnits(PitchDiameter, callout, ToUnits);
            }
            else return "Thread callout not found";
        }

        [ExcelFunction(Description = "Return the tensile area of a bolt")]
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

            if (CurrentThread.Class[1] == 'B' || CurrentThread.Class[1] == 'H' )
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
                        dm = Convert.ToDouble(MINORDIAMETER(callout,"basic"));
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
                    return WashUnits2(Math.PI * (d2 + d3) * (d2 + d3) / 16, callout, ToUnits);
                }
                
                // In case of standard
                else
                {
                    return WashUnits2(Math.PI * (dm + dp)*(dm + dp)/16,callout,ToUnits);
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
            
            object MinorDiameter = MINORDIAMETER(callout,"basic");
            //object MinorDiameter = Convert.ToDouble(MD);

            // Test whether minor diameter is defined
            if (Double.TryParse(MinorDiameter.ToString(), out double dm))
            {
                return WashUnits2(Math.PI * dm * dm / 4, callout, ToUnits);
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
                Double.TryParse(PITCHDIAMETER(callout,"basic","in").ToString(), out double PitchDiameter);
                if (callout[0]=='M')
                {
                    Pitch = CurrentThread.N;
                }
                else
                {
                    Pitch = 1/CurrentThread.N;
                }

                return Math.Atan( Pitch / (Math.PI * PitchDiameter))*180/Math.PI;
            }
            else
            {
                return "Thread callout not found";
            }
        }


        private static object WashUnits(double Value, string Callout, string ToUnits)
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
                return Math.Round(Convert.ToDouble(CVT(Value, FromUnits, ToUnits)),4);
            }
            catch (System.FormatException)
            {
                return "Check units!";
            }
            
        }

        private static object WashUnits2(double Value, string Callout, string ToUnits)
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
                return Math.Round(Convert.ToDouble(CVT(Value, FromUnits, ToUnits)),4);
            }
            catch (FormatException)
            {
                return "Check units!";
            }

        }

    }
}
