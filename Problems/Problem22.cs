using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;
using System.Diagnostics;
using System.Globalization;
using System.Threading;

namespace Problems
{
    public class Problem22
    {
        public static string Answer()
        {
            string path = @"C:\Users\johan\Desktop\names.txt";

            StreamReader sr = new StreamReader(path);

            string s = sr.ReadToEnd();
            string[] s_arr = s.Split(new char[]{','});

            List<string> list = new List<string>(s_arr);

            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            list.Sort();

            long totalScore = 0;

            for (int i = 0; i < list.Count; i++)
            {
                string item = list[i].Replace("\"","");

                long value = calcAlphabeticalValue(item);

                long currentScore = value * (i+1);
                totalScore += currentScore;
            }

            return totalScore.ToString();
        }

        private static long calcAlphabeticalValue(string item)
        {
            long sum = 0;
            foreach (var c in item)
            {
                sum += (long)c - 'A' + 1;
            }

            return sum;
        }
    }
}
