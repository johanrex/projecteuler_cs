using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;

namespace Problems
{
    public class Problem16
    {
        public static string Answer()
        {
            BigInteger nr = BigInteger.Pow(2, 1000);

            string s = nr.ToString();

            long sum = 0;
            foreach (char c in s)
            {
                sum += long.Parse(c.ToString());
            }

            return sum.ToString();
        }
    }
}
