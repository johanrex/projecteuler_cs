using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;
using System.Diagnostics;

namespace Problems
{
    public class Problem12
    {
        public static long Answer()
        {

            long target = 0;

            for (long tPos = 1; tPos < long.MaxValue; tPos++)
            {
                long tNr = TriangleNumbers.GetAt(tPos);

                //List<long> list = new List<long>();

                long nrOfTerms = 1;
                for (long i = 2; i <= tNr; i++)
                {
                    if (tNr % i == 0)
                    {
                        nrOfTerms++;

                        //list.Add(i);
                    }
                }

                //Debug.Print(string.Format("tNr: {0}. Factors: {1}", tNr, string.Join(", ", list)));

                //Debug.Print(string.Format("tNr:{0} Factors:{1}", tNr, nrOfTerms));

                if (nrOfTerms > 500)
                {
                    target = tNr;
                    break;
                }                
            }


            return target;
        }
    }
}
