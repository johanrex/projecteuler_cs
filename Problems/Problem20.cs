using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Numerics;
using Utilities;

namespace Problems
{
    public class Problem20
    {
        public static int Answer()
        {
            BigInteger b = new BigInteger(100);

            BigInteger a = b.Factorial();

            string s = a.ToString();

            int sum = 0;

            foreach (var c in s)
            {
                sum += int.Parse(c.ToString());
            }

            return sum;
        }
    }
}
