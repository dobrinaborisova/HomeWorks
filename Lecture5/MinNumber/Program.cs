using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MaxNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int comp = 0;
            int max = int.MaxValue;

            for (int i = 1; i <= numberOfNumbers; i++)
            {
                comp = int.Parse(Console.ReadLine());

                if (comp < max)
                {
                    max = comp;
                }
            }
            Console.WriteLine(max);
        }
    }
}
