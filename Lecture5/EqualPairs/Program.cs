using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EqualPairs
{
    class Program
    {
        static void Main(string[] args)
        {
            //сумата, 
            //минимума и 
            //максимума на числата на четни и нечетни позиции (броим от 1). 
            
            double number = double.Parse(Console.ReadLine());
            double sumEven = 0.0;
            double sumOdd = 0.0;
            double maxEven = double.MinValue;
            double minEven = double.MaxValue;
            double maxOdd = double.MinValue;
            double minOdd = double.MaxValue;

            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    double tempNumber = double.Parse(Console.ReadLine());
                    if (tempNumber >= maxEven)
                    {
                        maxEven = tempNumber;
                    }
                    else
                    {
                        minEven = tempNumber;
                    }
                    sumEven += tempNumber;
                }
                else
                {
                    double tempNumber = double.Parse(Console.ReadLine());
                    if (tempNumber >= maxOdd)
                    {
                        maxOdd = tempNumber;
                    }
                    else
                    {
                        minOdd = tempNumber;
                    }
                    sumOdd += tempNumber;
                }
            }

            if (sumOdd != maxEven || sumEven != maxOdd)
            {
                Console.WriteLine("OddSum={0},\r\nOddMin={1},\r\nOddMax={2},\r\nEvenSum={3},\r\nEvenMin={4},\r\nEvenMax={5}", sumOdd, minOdd, maxOdd, sumEven, minEven, maxEven);
            }
            else
            {
                Console.WriteLine("OddSum={0},\r\nOddMin={1},\r\nOddMax={2},\r\nEvenSum={3},\r\nEvenMin={4},\r\nEvenMax={5}", sumOdd, minOdd, maxOdd, sumEven, minEven, maxEven);
            }
        }
    }
}
