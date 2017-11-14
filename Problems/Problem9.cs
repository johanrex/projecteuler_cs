using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class Problem9
    {
        public static string Answer()
        {
            int result = 0;

            for (int c = 3; c < 1000; c++)
            {
                for (int a = 2; a < c; a++)
                {
                    for (int b = 1; b < a; b++)
                    {
                        if ((a + b + c) == 1000)
                        {
                            if (a * a + b * b == c * c)
                            {
                                result = a * b * c;
                                break;
                            }
                        }

                    }

                    if (result != 0)
                    {
                        break;
                    }
                }

                if (result != 0)
                {
                    break;
                }
            }

            return result.ToString();
        }
    }
}
