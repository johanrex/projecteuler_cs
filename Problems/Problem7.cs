using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Utilities;

namespace Problems
{
    public class Problem7
    {
        public static string Answer()
        {
            //10001

            List<long> list = PrimeTool.GetPrimes(1000000);

            long count = list.Count;
            System.Diagnostics.Trace.Assert(count >= 10000);

            long target = list[10000];

            return target.ToString();
        }
    }
}
