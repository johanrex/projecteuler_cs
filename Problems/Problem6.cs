using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class Problem6
    {
        public static string Answer()
        {

            long sumOfSquares = 0;
            for (int i = 1; i <= 100; i++)
            {
                sumOfSquares += (i * i);
            }

            long squareOfSums = 0;
            for (int i = 1; i <= 100; i++)
            {
                squareOfSums += i;
            }
            squareOfSums *= squareOfSums;

            long answer = squareOfSums - sumOfSquares;

            return answer.ToString();
        }
    }
}
