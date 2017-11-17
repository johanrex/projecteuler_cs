using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;

namespace Problems
{
    public class Problem14
    {
        public static long Answer()
        {
            long longestLength = 0;
            long longestStartingNr = 0;

            for (long i = 1; i < 1000000; i++)
            {
                long length = 1;
                long currentNr = i;

                while (currentNr != 1)
                {
                    if (currentNr % 2 == 0)
                    {
                        currentNr = currentNr / 2;
                    }
                    else
                    {
                        currentNr = 3 * currentNr + 1;
                    }

                    length++;
                }

                if (length >= longestLength)
                {
                    longestStartingNr = i;
                    longestLength = length;
                }
            }

            return longestStartingNr;
        }

    }
}
