using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Number1to100
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Еnter a number in the range [1...100]: ");
            int n = int.Parse(Console.ReadLine());

            while (n > 100 || n < 1)
            {
                Console.WriteLine("Invalid number!");
                Console.WriteLine("Еnter a number in the range [1...100]: ");
                n = int.Parse(Console.ReadLine());
            }
            if (n <= 100 && n >= 1)
            {
                Console.WriteLine("The number is: {0}", n);
            }
        }
    }
}
