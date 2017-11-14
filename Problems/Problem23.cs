using System;
using System.Collections.Generic;
using System.Linq;

namespace Problems
{
    public class Problem23
    {
        /*
            Non-abundant sums

            A perfect number is a number for which the sum of its proper divisors is exactly equal to the number. 
            For example, the sum of the proper divisors of 28 would be 1 + 2 + 4 + 7 + 14 = 28, which means that 28 is a perfect number.
            A number n is called deficient if the sum of its proper divisors is less than n and it is called abundant if this sum exceeds n.
            As 12 is the smallest abundant number, 1 + 2 + 3 + 4 + 6 = 16, the smallest number that can be written as the sum of two abundant numbers is 24. 
            By mathematical analysis, it can be shown that all integers greater than 28123 can be written as the sum of two abundant numbers. 
            However, this upper limit cannot be reduced any further by analysis even though it is known that the greatest number that cannot be expressed as the sum of two abundant numbers is less than this limit.
            Find the sum of all the positive integers which cannot be written as the sum of two abundant numbers.
        */

        public static string Answer()
        {
            var sum = 0;

            var nrs = GetAbundantNumbers(28123); //All integers greater than 28123 can be written as the sum of two abundant numbers. 12 is the smallest abundant number

            for (int i = 1; i <= 28123; i++)
            {
                if (!CanBeSumOfTwoAbundantNrs(i, nrs))
                    sum += i;
            }

            return sum.ToString();
        }

        public static bool CanBeSumOfTwoAbundantNrs(int n, List<int> nrs)
        {
            //Assume nrs to be sorted
            //This is probably very inefficient
            for (int i = 0; i < nrs.Count; i++)
            {
                if (nrs[i] >= n)
                    return false;

                for (int j = 0; j < nrs.Count; j++)
                {
                    if (nrs[i] + nrs[j] == n)
                        return true;

                    if (nrs[j] >= n)
                        break;
                }
            }
            
            return false;
        }

        public static List<int> GetAbundantNumbers(int upperBound)
        {
            var list = new List<int>();
            for (int i = 12; i <= upperBound; i++) //12 is the smallest abundant number.
            {
                if (IsAbundant(i))
                    list.Add(i);
            }

            return list;
        }

        public static bool IsAbundant(int number)
        {
            var lst = new List<int>();
            lst.Add(1); //1 is always a proper divisor

            var sum = 1;

            for (int i = 2; i < (number / 2) + 1; i++)
            {
                if (number % i == 0)
                    sum += i;

                if (sum > number)
                    return true;
            }

            return false;
        }
    }
}
