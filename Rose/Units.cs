using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LumenWorks.Framework.IO.Csv;


namespace Rose
{
    public partial class RefUnits
    {
        public static List<RefUnit> List { get; set; }

        static RefUnits()
        {
            string Line;
            string[] LineParse;

            List = new List<RefUnit>();
            StringReader csv = new StringReader(Data.Units);
            {
                while ((Line = csv.ReadLine()) != null)
                {
                    LineParse = Line.Split(',');
                    RefUnit ru = new RefUnit(LineParse[0], LineParse[1], LineParse[2], LineParse[3],
                        LineParse[4], LineParse[5], double.Parse(LineParse[6]), LineParse[7], LineParse[8], bool.Parse(LineParse[9]));
                    List.Add(ru);
                }
            }
        }

        public static class GetFactor
        {
            public static double Symbol(string Input)
            {
                if (RefUnits.List.Find(x => x.Symbol.Equals(Input)) == null) { return 0; }
                else { return RefUnits.List.Find(x => x.Symbol.Equals(Input)).Factor; }
            }

            public static double AltSymbol1(string Input)
            {
                if (RefUnits.List.Find(x => x.AltSymbol1.Equals(Input)) == null) { return 0; }
                else { return RefUnits.List.Find(x => x.AltSymbol1.Equals(Input)).Factor; }
            }

            public static double AltSymbol2(string Input)
            {
                if (RefUnits.List.Find(x => x.AltSymbol2.Equals(Input)) == null) { return 0; }
                else { return RefUnits.List.Find(x => x.AltSymbol2.Equals(Input)).Factor; }
            }

            public static double Name(string Input)
            {
                if (RefUnits.List.Find(x => x.Name.Equals(Input)) == null) { return 0; }
                else { return RefUnits.List.Find(x => x.Name.Equals(Input)).Factor; }
            }
        }

        public static class GetUnits
        {

            public static string Symbol(string Input)
            {
                string Shizzle;

                if (RefUnits.List.Find(x => x.Symbol.Equals(Input)) == null) { return ""; }
                
                else
                {
                    System.Diagnostics.Debug.WriteLine(RefUnits.List.Find(x => x.Symbol.Equals(Input)).BaseSymbol);
                    Shizzle = RefUnits.List.Find(x => x.Symbol.Equals(Input)).BaseSymbol;
                    return Shizzle; 
                }
            }

            public static string AltSymbol1(string Input)
            {
                if (RefUnits.List.Find(x => x.AltSymbol1.Equals(Input)) == null) { return ""; }
                else { return RefUnits.List.Find(x => x.AltSymbol1.Equals(Input)).BaseSymbol; }
            }

            public static string AltSymbol2(string Input)
            {
                if (RefUnits.List.Find(x => x.AltSymbol2.Equals(Input)) == null) { return ""; }
                else { return RefUnits.List.Find(x => x.AltSymbol2.Equals(Input)).BaseSymbol; }
            }

            public static string Name(string Input)
            {
                if (RefUnits.List.Find(x => x.Name.Equals(Input)) == null) { return ""; }
                else { return RefUnits.List.Find(x => x.Name.Equals(Input)).BaseSymbol; }
            }
        }

    }

    public class RefUnit
    {
        public string Symbol { get; set; }
        public string Name { get; set; }
        public string BaseSymbol { get; set; }
        public string BaseName { get; set; }
        public string DimensionSymbol { get; set; }
        public string DimensionName { get; set; }
        public double Factor { get; set; }
        public string AltSymbol1 { get; set; }
        public string AltSymbol2 { get; set; }
        public bool Valid { get; set; }

        public RefUnit()
        {
            this.Symbol = "-";
            this.Name = "-";
            this.BaseSymbol = "-";
            this.BaseName = "-";
            this.DimensionSymbol = "-";
            this.DimensionName = "-";
            this.Factor = 0;
            this.AltSymbol1 = "-";
            this.AltSymbol2 = "-";
            this.Valid = false;
        }

        public RefUnit(string symbol = "-", string altsymbol1 = "-", string altsymbol2 = "-",
            string name = "-", string basesymbol = "-", string basename = "-", double factor = 0,
            string dimensionname = "-", string dimensionsymbol = "-", bool valid = false)
        {
            this.Symbol = symbol;
            this.Name = name;
            this.BaseSymbol = basesymbol;
            this.BaseName = basename;
            this.DimensionSymbol = dimensionsymbol;
            this.DimensionName = dimensionname;
            this.Factor = factor;
            this.AltSymbol1 = altsymbol1;
            this.AltSymbol2 = altsymbol2;
            this.Valid = Valid;
        }
    }

    public class Unit
    {
        public string[] Numerator { get; set; }
        public string[] Denominator { get; set; }
        public string Both { get; set; }
        public string NumeratorDimension { get; set; }
        public string DenominatorDimension { get; set; }
        public string Dimension { get; set; }

        public Unit() { }

        public Unit(string Input)
        {
            this.Both = Input;
            this.NumeratorDimension = String.Empty;
            this.DenominatorDimension = String.Empty;

            // Standardize format of input
            Input = Input.Replace("·", " ").Replace("*", " ")
                         .Replace("-", " ").Replace("^2", "2")
                         .Replace("^3", "3").Replace("^4", "4")
                         .Replace("(", "").Replace(")", "")
                         .Replace(" /","/").Replace("/ ","/");

            // Break up input units into numerator/denominator
            string[] NumeratorHold = Input.Split('/');

            // Split on spaces and place numerator units in string array
            this.Numerator = NumeratorHold[0].Split(' ');

            if (NumeratorHold.Length > 1)
            {
                this.Denominator = NumeratorHold[1].Split(' ');
            }
        }

        public static double GetProduct(string[] UnitsToParse)
        {
            string Unit;
            string PowerString;
            double Power = 1;
            double Product = 1;
            double Factor;
            bool IsPower;

            if (UnitsToParse != null)
            {
                for (int i = 0; i < UnitsToParse.Length; i++)
                {
                    Unit = UnitsToParse[i];
                    IsPower = false;
                    if ( Unit.Length > 1 )
                    {
                        PowerString = Unit[Unit.Length - 1].ToString();
                        IsPower = double.TryParse(PowerString, out Power) && (Power != 0);
                    }

                    if (IsPower)
                    {
                        Unit = Unit.Remove(Unit.Length - 1);
                    }

                    Factor = RefUnits.GetFactor.Symbol(Unit);
                    if (Factor == 0)
                    {
                        Factor = RefUnits.GetFactor.AltSymbol1(Unit);
                        if (Factor == 0)
                        {
                            Factor = RefUnits.GetFactor.AltSymbol2(Unit);
                            if (Factor == 0)
                            {
                                Factor = RefUnits.GetFactor.Name(Unit);
                            }
                        }
                    }

                    if (IsPower)
                    {
                        Factor = Math.Pow(Factor, Power);
                    }
                    
                    Product = Product * Factor;
                }
            }
            return Product;
        }

        public static string GetDimension(string[] UnitsToParse)
        {
            string Unit;
            string PowerString;
            int Power = 1;

            string[] Dimension = new string[2] {"",""};
            string Term = "";
            string[] SplitTerm;

            if (UnitsToParse != null)
            {
                for (int i = 0; i < UnitsToParse.Length; i++)
                {
                    Unit = UnitsToParse[i];
                    PowerString = Unit[Unit.Length - 1].ToString();
                    bool IsPower = Int32.TryParse(PowerString, out Power) && (Power != 0);
                    if  (Power == 0) Power = 1;
                    if (IsPower) Unit = Unit.Remove(Unit.Length - 1);

                    Term = RefUnits.GetUnits.Symbol(Unit);
                    if (Term == "")
                    {
                        Term = RefUnits.GetUnits.AltSymbol1(Unit);
                        if (Term == "")
                        {
                            Term = RefUnits.GetUnits.AltSymbol2(Unit);
                            if (Term == "")
                            {
                                Term = RefUnits.GetUnits.Name(Unit);
                            }
                        }
                    }

                    SplitTerm = Term.Split('/');
                    //Dimension[0] = SplitTerm[0];

                    for (int j = 1; j <= Power; j++)
                    {
                        Dimension[0] += " " + SplitTerm[0];
                    }
                    
                    if (SplitTerm.Length > 1)
                    {
                        //Dimension[1] = SplitTerm[1];
                        for (int k = 1; k <= Power; k++ )
                        {
                            Dimension[1] += " " + SplitTerm[1];
                        }
                            
                    }
                }

            string retv = string.Join("/", Dimension).TrimEnd('/');
            return retv;
            }

            else
            {
                return "";
            }

        }

        public static string FlattenUnits(string Input)
        {
            Input = Input.Replace("s2", "s s")
                         .Replace("s3", "s s s")
                         .Replace("m2", "m m")
                         .Replace("m3", "m m m")
                         .Replace("m4", "m m m m");

            string[] InputAr = Input.Split(' ');
            Array.Sort<string>(InputAr);
            Input = string.Join(" ", InputAr);
            return Input.Trim();
        }
    }
}

