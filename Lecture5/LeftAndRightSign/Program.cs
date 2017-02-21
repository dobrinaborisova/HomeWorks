using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeftAndRightSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = 2 * int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numberOfNumbers / 2; i++)
            {
                leftSum += int.Parse(Console.ReadLine());
            }
            for (int i = numberOfNumbers / 2; i < numberOfNumbers; i++)
            {
                rightSum += int.Parse(Console.ReadLine());
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes, sum = {0}", leftSum);
            }
            else
            {
                int dif = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No, diff = {0}", dif);
            }
        }
    }
}
