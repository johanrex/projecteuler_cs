using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Utilities
{
    public class PrimeTool
    {
        public static bool IsPrime(long candidate)
        {
            // Test whether the parameter is a prime number.
            if ((candidate & 1) == 0)
            {
                if (candidate == 2)
                {
                    return true;
                }
                else
                {
                    return false;
                }
            }
            // Note:
            // ... This version was changed to test the square.
            // ... Original version tested against the square root.
            // ... Also we exclude 1 at the very end.
            for (long i = 3; (i * i) <= candidate; i += 2)
            {
                if ((candidate % i) == 0)
                {
                    return false;
                }
            }
            return candidate != 1;
        }


        public static List<long> GetPrimes(long max)
        {
            var primes = new List<long>();

            var nonprimes = new bool[max + 1];

            for (long i = 2; i <= max; i++)
            {
                if (nonprimes[i] == false)
                {
                    for (var j = i * i; j <= max; j += i)
                    {
                        nonprimes[j] = true;
                    }

                    primes.Add(i);
                }
            }

            return primes;
        }
    }
}
