using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _11.Enter_Even_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Еnter even number: ");
            int n = int.Parse(Console.ReadLine());

            //invalid number
            while (n % 2 != 0)
            {
                Console.WriteLine("The number is not even.");
                Console.Write("Еnter even number: ");
                try
                {
                    n = int.Parse(Console.ReadLine());
                }
                catch (Exception e)
                {
                    Console.WriteLine("Invalid number!");
                }
            }
            //valid number
            if (n % 2 == 0)
            {
                Console.WriteLine("Even number entered: {0}", n);
            }
        }
    }
}
