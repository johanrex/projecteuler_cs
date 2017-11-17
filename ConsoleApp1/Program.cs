using System;
using Problems;
using System.Diagnostics;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //LogAnswer(typeof(Problem3).Name, Problem3.Answer());
            //LogAnswer(typeof(Problem4).Name, Problem4.Answer());
            //LogAnswer(typeof(Problem5).Name, Problem5.Answer());
            //LogAnswer(typeof(Problem6).Name, Problem6.Answer());
            //LogAnswer(typeof(Problem7).Name, Problem7.Answer());
            //LogAnswer(typeof(Problem8).Name, Problem8.Answer());
            //LogAnswer(typeof(Problem9).Name, Problem9.Answer());
            //LogAnswer(typeof(Problem10).Name, Problem10.Answer());
            //LogAnswer(typeof(Problem11).Name, Problem11.Answer());
            //LogAnswer(typeof(Problem12).Name, Problem12.Answer());
            //LogAnswer(typeof(Problem13).Name, Problem13.Answer());
            //LogAnswer(typeof(Problem14).Name, Problem14.Answer());
            //LogAnswer(typeof(Problem15).Name, Problem15.Answer());
            //LogAnswer(typeof(Problem16).Name, Problem16.Answer());
            //LogAnswer(typeof(Problem17).Name, Problem17.Answer());
            //LogAnswer(typeof(Problem18).Name, Problem18.Answer());
            //LogAnswer(typeof(Problem19).Name, Problem19.Answer());
            //LogAnswer(typeof(Problem20).Name, Problem20.Answer());
            //LogAnswer(typeof(Problem21).Name, Problem21.Answer());
            //LogAnswer(typeof(Problem22).Name, Problem22.Answer());
            LogAnswer(typeof(Problem23).Name, Problem23.Answer());

            //LogAnswer(typeof(Problem67).Name, Problem67.Answer());
            //LogAnswer(typeof(Stuff).Name, Stuff.Answer()); //TODO what problem nr was this?

            //TODO where did I put the code for problems nr 24, 25, 28, 35, 37, 41, 48, 49? Perhaps I used python for those?

        }

        public static void LogAnswer(string problemNr, long number)
        {
            var s = string.Format("{0}:\t{1}", problemNr, number.ToString());
            Trace.WriteLine(s);
            Console.WriteLine(s);
        }

    }
}
