using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Problems
{
    public class Problem10
    {
        public static long Answer()
        {
            List<long> primes = PrimeTool.GetPrimes(2000000);

            return primes.Sum();
        }
    }
}
