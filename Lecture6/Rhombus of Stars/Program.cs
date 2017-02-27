using System;
using System.Linq;

namespace Rhombus_of_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            for (int i = 1; i <= n; i++)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(string.Concat(Enumerable.Repeat("* ", i)).TrimEnd());
                
            }
            for (int i = n-1; i > 0; i--)
            {
                Console.Write(new string(' ', n - i));
                Console.WriteLine(string.Concat(Enumerable.Repeat("* ", i)).TrimEnd());
            }

        }
    }
}