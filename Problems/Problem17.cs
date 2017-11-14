using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problems
{
    public class Problem17
    {
        public static string Answer()
        {
            string[] numbers1 = new string[] {
                "zero (NOT USED)",
                "one", 
                "two", 
                "three", 
                "four", 
                "five", 
                "six", 
                "seven", 
                "eight", 
                "nine", 
                "ten", 
                "eleven", 
                "twelve", 
                "thirteen", 
                "fourteen", 
                "fifteen", 
                "sixteen", 
                "seventeen", 
                "eighteen", 
                "nineteen"
            };

            string[] numbers2 = new string[] {
                "zero (NOT USED)",
                "ten",
                "twenty", 
                "thirty", 
                "forty", 
                "fifty", 
                "sixty", 
                "seventy", 
                "eighty", 
                "ninety"
            };

            int sum = 0;

            for (int i = 1; i <= 1000; i++)
            {
                string s = "";

                if (i == 1000)
                {
                    s = "onethousand";
                }
                else
                {
                    bool hasHundredDigit = false;

                    int i_modified = i;

                    if (i >= 100 && i <= 999)
                    {
                        int iHundredPart = int.Parse((i.ToString()[0].ToString()));

                        s = numbers1[iHundredPart] + " hundred";

                        hasHundredDigit = true;
                        i_modified = i - (iHundredPart*100);
                    }

                    if (i_modified >= 1 && i_modified <= 19)
                    {
                        if (hasHundredDigit)
                        {
                            s += " and";
                        }

                        s += numbers1[i_modified];
                    }
                    else if (i_modified >= 20 && i_modified <= 99)
                    {
                        int firstPart = int.Parse(i_modified.ToString()[0].ToString());
                        int secondPart = int.Parse(i_modified.ToString()[1].ToString());

                        if (hasHundredDigit)
                        {
                            s += " and ";
                        }

                        s += numbers2[firstPart];
                        if (secondPart > 0)
                        {
                            s += numbers1[secondPart];
                        }
                    }
                }

                sum += AddString(s);
            }

            return sum.ToString();
        }

        private static int AddString(string s)
        {
            s = s.Replace(" ", "");

            Trace.WriteLine(s.Length.ToString() + "\t\t" + s);

            return s.Length;
        }
    }
}
