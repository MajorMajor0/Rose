using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using LumenWorks.Framework.IO.Csv;

namespace Rose
{
    class Threads
    {
        public static List<Thread> List { get; set; }

        static Threads()
        {
            string Line;
            string[] LineParse;
            double[] x = new double[16];

            List = new List<Thread>();
            // List the columns in the thread data that are numbers 
            int[] doubles = {1, 6, 7, 8, 9, 10, 11, 12, 13, 14, 15 };

            // Get thread data from constant string
            StringReader csv = new StringReader(Data.Threads);
            {
                while ((Line = csv.ReadLine()) != null)
                {
                    // Put the current line in a string array
                    LineParse = Line.Split(',');

                    foreach (int i in doubles)
                    {
                        if (double.TryParse(LineParse[i], out x[i])) { }
                        else { x[i] = -1; }
                    }

                    Thread thd = new Thread(LineParse[0] , x[1], LineParse[2], LineParse[3],
                    LineParse[4], LineParse[5], x[6], x[7], x[8], x[9], x[10], x[11],
                    x[12], x[13], x[14], x[15]);

                    List.Add(thd);
                }
            }
        }
     }

    public class Thread
    {
        public string Fraction { get; set; }
        public double N { get; set; }
        public string Series { get; set; }
        public string Class { get; set; }
        public string FractionCallout { get; set; }
        public string DecimalCallout { get; set; }
        public double Allowance { get; set; }
        public double MajorMax { get; set; }
        public double MajorBasic { get; set; }
        public double MajorMin { get; set; }
        public double MajorMinE { get; set; }
        public double PitchMax { get; set; }
        public double PitchMin { get; set; }
        public double MinorMax { get; set; }
        public double MinorMin { get; set; }
        public double Tolerance { get; set; }

        public Thread()
        {
            Fraction = "-";
            N = 0;
            Series = "-";
            Class = "-";
            FractionCallout = "-";
            DecimalCallout = "-";
            Allowance = 0;
            MajorMax = 0;
            MajorBasic = 0;
            MajorMin = 0;
            MajorMinE = 0;
            PitchMax = 0;
            PitchMin = 0;
            MinorMax = 0;
            MinorMin = 0;
            Tolerance = 0;
        }

        public Thread(string fraction , double n, string series, string clas,
            string fractioncallout, string decimalcallout, double allowance,
            double majormax, double majorbasic, double majormin, double majormine, 
            double pitchmax, double pitchmin, double minormax, double minormin, double tolerance )
        {

            Fraction = fraction;
            N = n;
            Series = series;
            Class = clas;
            FractionCallout = fractioncallout;
            DecimalCallout = decimalcallout;
            Allowance = allowance;
            MajorMax = majormax ;
            MajorBasic = majorbasic;
            MajorMin = majormin ;
            MajorMinE = majormine;
            PitchMax = pitchmax ;
            PitchMin = pitchmin ;
            MinorMax = minormax ;
            MinorMin = minormin ;
            Tolerance = tolerance;
        }

        public static Thread Get(string callout)
        {
            Thread CurrentThread = null;
            
            if (Threads.List.Find(x => x.DecimalCallout.Equals(callout)) != null)
            {
                CurrentThread = Threads.List.Find(x => x.DecimalCallout.Equals(callout));  
            }

            else if (Threads.List.Find(x => x.FractionCallout.Equals(callout)) != null)
            {
                CurrentThread = Threads.List.Find(x => x.FractionCallout.Equals(callout));
            }

            return CurrentThread;
        }


    }
}
