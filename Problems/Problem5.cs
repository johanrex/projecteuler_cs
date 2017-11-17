using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class Problem5
    {
        public static int Answer()
        {

            int current = 1;

            while (true)
            {
                bool divisable = true;

                for (int i = 1; i <= 20; i++)
                {
                    if (current % i != 0)
                    {
                        divisable = false;
                        break;
                    }
                }

                if (divisable)
                {
                    break;
                }
                else
                {
                    current++;
                }
            }

            return current;
        }
    }
}
