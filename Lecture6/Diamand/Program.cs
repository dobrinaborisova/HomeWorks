using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamand
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n % 2 != 0)
            {

                for (int i = 1; i <= n; i++)
                {
                    Console.Write(new string('_', n - i));
                    Console.Write(string.Concat(Enumerable.Repeat("*_", i)));
                    Console.WriteLine(string.Concat(Enumerable.Repeat("_", n - i)));

                }
                for (int i = n - 1; i > 0; i--)
                {
                    Console.Write(new string('_', n - i));
                    Console.Write(string.Concat(Enumerable.Repeat("*_", i)));
                    Console.WriteLine(string.Concat(Enumerable.Repeat("_", n - i)));
                }
            }
            else
            {
                for (int i = 1; i <= n; i++)
                {
                    Console.Write(new string('-', n - i));
                    Console.Write(string.Concat(Enumerable.Repeat("*_", i)));
                    Console.WriteLine(string.Concat(Enumerable.Repeat("-", n - i)));

                }
                for (int i = n - 1; i > 0; i--)
                {
                    Console.Write(new string('-', n - i));
                    Console.Write(string.Concat(Enumerable.Repeat("*", i)));
                    Console.WriteLine(string.Concat(Enumerable.Repeat("-", n - i)));
                }
            }
        }
    }
}
