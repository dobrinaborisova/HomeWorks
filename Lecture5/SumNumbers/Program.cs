using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumNumbers
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;

            for (int input = 1; input <= number; input++)
            {
                sum += int.Parse(Console.ReadLine());
            }
            Console.WriteLine(sum);
        }
    }
}
