using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Problems
{
    public class Problem3
    {
        public static string Answer()
        {
            long target = 600851475143;

            List<long> factors = new List<long>();

            //get many primes
            List<long> primes =  PrimeTool.GetPrimes(4000000);

            long remainder = target;

            var en = primes.GetEnumerator();

            en.MoveNext();

            while (remainder > 1)
            {
                while (remainder % en.Current == 0)
                {
                    factors.Add(en.Current);
                    remainder = remainder / en.Current;
                }

                en.MoveNext();
            }

            return factors[factors.Count - 1].ToString();
        }
    }
}
