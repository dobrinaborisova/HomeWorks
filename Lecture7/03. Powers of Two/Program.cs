using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _03.Powers_of_Two
{
    class Program
    {
        static void Main(string[] args)
        {
            double n = double.Parse(Console.ReadLine());

            for (double i = 0; i <= n; i++)
            {
                Console.WriteLine(Math.Pow(2, i));
            }
        }
    }
}
