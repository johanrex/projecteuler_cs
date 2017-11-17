using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problems
{
    public class Problem21
    {
        public static int Answer()
        {
            List<int> pairs = new List<int>();

            int sumOfAmicablePairs = 0;

            for (int i = 0; i < 10000; i++)
            {
                if (pairs.Exists(x => x == i))
                    continue;

                int a = i;

                int sum_a = sumOfDivisors(a);
                int sum_b = sumOfDivisors(sum_a);

                if ((a == sum_b) && (a != sum_a))
                {
                    sumOfAmicablePairs += (a + sum_a);

                    pairs.Add(a);
                    pairs.Add(sum_a);

                    Trace.WriteLine(string.Format("{0}\t{1}", a, sum_a));
                }
            }

            return sumOfAmicablePairs;
        }

        private static int sumOfDivisors(int number)
        {
            int sum = 0;

            for (int i = 1; i < number; i++)
            {
                if (number % i == 0)
                {
                    sum += i;
                }
            }

            return sum;
        }
    }
}
