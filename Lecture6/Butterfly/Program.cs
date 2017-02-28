using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Butterfly
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int size = 5 * n;

            for (int i = 0; i <( 2 * (n - 2) + 1)/2; i++)
            {
                string middle;
                string body;
                if (i % 2 == 0)
                {
                    middle = string.Concat(Enumerable.Repeat("*", n - 2).Concat(Enumerable.Repeat("\\", 1).Concat(Enumerable.Repeat(" ", 1).Concat(Enumerable.Repeat("/", 1).Concat(Enumerable.Repeat("*", n - 2))))));
                }
                else
                {
                    middle = string.Concat(Enumerable.Repeat("-", n - 2).Concat(Enumerable.Repeat("\\", 1).Concat(Enumerable.Repeat(" ", 1).Concat(Enumerable.Repeat("/", 1).Concat(Enumerable.Repeat("-", n - 2))))));
                }
                Console.WriteLine(middle);
            }
            Console.WriteLine(string.Concat(Enumerable.Repeat(" ", n - 1).Concat(Enumerable.Repeat("@", 1).Concat(Enumerable.Repeat(" ", n - 2)))));
            for (int i = 0; i < (2 * (n - 2) + 1) / 2; i++)
            {
                string middle;
                if (i % 2 == 0)
                {
                    middle = string.Concat(Enumerable.Repeat("*", n - 2).Concat(Enumerable.Repeat("/", 1).Concat(Enumerable.Repeat(" ", 1).Concat(Enumerable.Repeat("\\", 1).Concat(Enumerable.Repeat("*", n - 2))))));
                }
                else
                {
                    middle = string.Concat(Enumerable.Repeat("-", n - 2).Concat(Enumerable.Repeat("/", 1).Concat(Enumerable.Repeat(" ", 1).Concat(Enumerable.Repeat("\\", 1).Concat(Enumerable.Repeat("-", n - 2))))));
                }
                Console.WriteLine(middle);
            }
        }
    }
}
