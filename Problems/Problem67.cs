using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Problems
{
    public class Problem67
    {
        public static int Answer()
        {
            System.IO.StreamReader sr = new System.IO.StreamReader("C:\\Users\\johan\\Desktop\\triangle.txt");

            List<List<int>> lines = new List<List<int>>();

            while (!sr.EndOfStream)
            {
                string line = sr.ReadLine();
                string[] strings = line.Split(new char[]{' '});

                var lineArr = new List<int>();
                lines.Add(lineArr);

                for (int index = 0; index <= strings.Length - 1; index++)
                {
                    lineArr.Add(Convert.ToInt32(strings[index]));
                }
            }

            for (int lineIndex = lines.Count - 2; lineIndex >= 0; lineIndex += -1)
            {

                for (int colIndex = 0; colIndex <= lines[lineIndex].Count - 1; colIndex++)
                {
                    int val1 = lines[lineIndex + 1][colIndex];
                    int val2 = lines[lineIndex + 1][colIndex + 1];

                    int biggest = 0;

                    if (val1 > val2)
                    {
                        biggest = val1;
                    }
                    else
                    {
                        biggest = val2;
                    }

                    int current = lines[lineIndex][colIndex];
                    lines[lineIndex][colIndex] = current + biggest;
                }
            }

            return lines[0][0];
        }
    }
}
