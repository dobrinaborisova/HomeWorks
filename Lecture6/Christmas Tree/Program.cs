using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_Tree
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            Console.WriteLine(string.Concat(Enumerable.Repeat(" ", n+1).Concat(Enumerable.Repeat("|", 1))));
            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(string.Concat(Enumerable.Repeat("*", i).Concat(Enumerable.Repeat(" ", 1)).Concat(Enumerable.Repeat("|", 1).Concat(Enumerable.Repeat(" ", 1).Concat(Enumerable.Repeat("*", i))))));
            }
        }
    }
}
