using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Text.RegularExpressions;

namespace Problems
{
    public class Stuff
    {
        public static int Answer()
        {
            List<string> combinations = new List<string>();

            for (int i = 0; i < 256; i++)
			{
                string s = Convert.ToString(i, 2);
                s = s.PadLeft(8, '0');

                combinations.Add(s);

                Trace.WriteLine(s);
			}

            Regex ex1 = new Regex("....0..1");
            Regex ex2 = new Regex(".1...0..");
            Regex ex3 = new Regex(".1...0.0");

            //2^4 passar både ex1 och ex2.

            int i1 = combinations.RemoveAll(x => ex1.IsMatch(x));
            int i2 = combinations.RemoveAll(x => ex2.IsMatch(x));
            int i3 = combinations.RemoveAll(x => ex3.IsMatch(x));

            return combinations.Count;
        }
    }
}
