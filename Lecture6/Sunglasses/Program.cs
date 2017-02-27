using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglasses
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int size = 5 * n;

            string firstLast = string.Concat(Enumerable.Repeat("*", 2 * n).Concat(Enumerable.Repeat(" ", n).Concat(Enumerable.Repeat("*", 2 * n))));
            Console.WriteLine(firstLast);
            //Console.WriteLine();
            for (int i = 0; i < n - 2; i++)
            {
                string middle;
                if (i == ((n - 2) / 2))
                {
                    middle = string.Concat(Enumerable.Repeat("*", 1).Concat(Enumerable.Repeat("/", 2 * n - 2).Concat(Enumerable.Repeat("*", 1).Concat(Enumerable.Repeat(" ", n).Concat(Enumerable.Repeat("*", 1).Concat(Enumerable.Repeat("/", 2 * n - 2).Concat(Enumerable.Repeat("*", 1))))))));
                }

                else
                {
                    middle = string.Concat(Enumerable.Repeat("*", 1).Concat(Enumerable.Repeat("/", 2 * n - 2).Concat(Enumerable.Repeat("*", 1).Concat(Enumerable.Repeat("|", n).Concat(Enumerable.Repeat("*", 1).Concat(Enumerable.Repeat("/", 2 * n - 2).Concat(Enumerable.Repeat("*", 1))))))));

                }
                Console.WriteLine(middle);
            }
                //Console.WriteLine();
            Console.WriteLine(firstLast);
        }
    }
}
