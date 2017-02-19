using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HalfSumElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            int sum = 0;
            int max = int.MinValue;

            for (int i = 0; i < number; i++)
            {
                int tempNumber = int.Parse(Console.ReadLine());
                if (tempNumber >= max)
                    max = tempNumber;

                sum += tempNumber;
            }

            sum = sum - max;

            if (sum == max)
            {
                Console.WriteLine("Yes\r\nSum = {0}", max);
            }
            else
            {
                int dif = Math.Abs(max - sum);
                Console.WriteLine("No\r\nDiff = {0}", dif);
            }
        }
    }
}
