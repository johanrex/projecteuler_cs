using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class Problem19
    {
        public static int Answer()
        {
            DateTime dtCurrent = new DateTime(1901, 1, 1);
            DateTime dtEnd = new DateTime(2001, 1, 1);

            int nrOfSundays = 0;

            while (dtCurrent < dtEnd)
            {
                if (dtCurrent.DayOfWeek == DayOfWeek.Sunday)
                {
                    nrOfSundays++;
                }

                dtCurrent = dtCurrent.AddMonths(1);
            }

            return nrOfSundays;
        }
    }
}
