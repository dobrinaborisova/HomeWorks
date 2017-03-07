using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10.Check_Prime
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());

            if (n < 2)
            {
                Console.WriteLine("Not Prime");
            }

            else 
            {
                for (int i = 0; i < n; i++)
                {

                }

                Console.WriteLine("Prime");
            }
        }
    }
}
