using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Numerics;
using Combinatorics.Collections;

namespace Problems
{
    public class Problem15
    {
        public static long Answer()
        {
            //40!/(20!*20!) = 137846528820
            //aka 40 över 20.

            //40! är antalet kombinationer man kan gå 40 steg.
            //20! är antalet likadana kombinationer av tex bara ner, eller bara höger. Dom får man dividera bort.

            BigInteger b40f = factorial(40);
            BigInteger b20f = factorial(20);

            BigInteger result = b40f / (b20f * b20f);

            return (long)result;
        }

        private static BigInteger factorial(int p)
        {
            BigInteger fact = new BigInteger();
            fact = 1;
            for (int i = 1; i <= p; i++)
            {
                fact *= i;
            }

            return fact;
        }
    }


}
