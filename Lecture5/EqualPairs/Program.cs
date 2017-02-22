using System;
using System.Collections.Generic;
using System.Linq;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfNumbers =  int.Parse(Console.ReadLine());
            int firstSum = 0;

            int sumDiff = 0;
            List<int> numbers = new List<int>();
            List<int> sum = new List<int>();

            for (int i = 0; i < numberOfNumbers; i++)
            {
                
                sum.Add(int.Parse(Console.ReadLine()) + int.Parse(Console.ReadLine()));
            }

            firstSum = sum.ElementAt(0);

            for (int i = 1; i < sum.Count; i++)
            {
                sumDiff = Math.Max(Math.Abs(sum.ElementAt(i) - sum.ElementAt(i - 1)), sumDiff);
            }

            if (sumDiff == 0)
            {
                Console.WriteLine("Yes, value = {0}", firstSum);
            }
            else
            {
                Console.WriteLine("No, maxdiff = {0}", sumDiff);
            }
        }
    }
}
