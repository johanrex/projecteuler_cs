using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Problems
{
    public class Problem4
    {
        public static int Answer()
        {
            List<int> palindromes = new List<int>();

            for (int i = 100; i < 999; i++)
            {
                for (int j = 100; j < 999; j++)
                {
                    int result = i * j;

                    if (IsPalindrome(result))
                    {
                        palindromes.Add(result);
                    }
                }                
            }

            palindromes.Sort();

            return palindromes[palindromes.Count-1];
        }

        private static bool IsPalindrome(int value)
        {
            string s = value.ToString();

            string leftPart, rightPart;

            int length = s.Length;
            if (length > 1)
            {
                if ((length % 2) == 0)
                {
                    leftPart = s.Substring(0, length / 2);
                    rightPart = s.Substring(length / 2, length / 2);
                }
                else
                {
                    int middle = (length / 2) + 1;

                    leftPart = s.Substring(0, middle - 1);
                    rightPart = s.Substring(middle, middle - 1);
                }

                for (int i = 0; i < leftPart.Length; i++)
                {
                    if (leftPart[i] != rightPart[(rightPart.Length - 1) - i])
                        return false;
                }
            }

            return true;
        }

    }
}
