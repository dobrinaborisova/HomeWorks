using System;
using System.Linq;

namespace Square_frames
{
    class Program
    {
        static void Main(string[] args)
        {

            int n = int.Parse(Console.ReadLine());

            string strFirstLast = string.Concat(Enumerable.Repeat("+", 1).Concat(Enumerable.Repeat(" -", n - 2).Concat(Enumerable.Repeat(" +", 1))));
            Console.WriteLine(strFirstLast);

            for (int i = 0; i < n - 2; i++)
            {
                string str = string.Concat(Enumerable.Repeat("|", 1).Concat(Enumerable.Repeat(" -", n - 2).Concat(Enumerable.Repeat(" |", 1))));
                Console.WriteLine(str);
            }

            Console.WriteLine(strFirstLast);
        }
    }
}
