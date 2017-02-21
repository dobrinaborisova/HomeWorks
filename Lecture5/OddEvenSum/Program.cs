using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers = int.Parse(Console.ReadLine());
            int leftSum = 0;
            int rightSum = 0;

            for (int i = 0; i < numberOfNumbers; i++)
            {
                if ( i % 2 == 0)
                {
                    leftSum += int.Parse(Console.ReadLine());
                }
                else
                {
                    rightSum += int.Parse(Console.ReadLine());
                }
            }

            if (leftSum == rightSum)
            {
                Console.WriteLine("Yes \r\nSum = {0}", leftSum);
            }
            else
            {
                int dif = Math.Abs(leftSum - rightSum);
                Console.WriteLine("No \r\nDiff = {0}", dif);
            }
        }
    }
}
