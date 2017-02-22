using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddEvenPositions
{
    class Program
    {
        static void Main(string[] args)
        {
            double number = double.Parse(Console.ReadLine());
            double EvenSum = 0.0;
            double OddSum = 0.0;
            double EvenMax = double.MinValue;
            double EvenMin = double.MaxValue;
            double OddMax = double.MinValue;
            double OddMin = double.MaxValue;

            for (int i = 0; i < number; i++)
            {
                if (i % 2 != 0)
                {
                    double tempNumber = double.Parse(Console.ReadLine());
                    if (tempNumber >= EvenMax)
                    {
                        EvenMax = tempNumber;
                    }

                    if (tempNumber <= EvenMin)
                    {
                        EvenMin = tempNumber;
                    }
                    EvenSum += tempNumber;
                }
                else
                {
                    double tempNumber = double.Parse(Console.ReadLine());
                    if (tempNumber >= OddMax)
                    {
                        OddMax = tempNumber;
                    }

                    if (tempNumber <= OddMin)
                    {
                        OddMin = tempNumber;
                    }
                    OddSum += tempNumber;
                }
            }

            StringBuilder builder = new StringBuilder();

            builder.AppendLine(string.Format("OddSum={0},", OddSum));

            if (OddMin != double.MaxValue)
            {
                builder.AppendLine(string.Format("OddMin={0},", OddMin));
            }
            else
            {
                builder.AppendLine(string.Format("OddMin={0},", "No"));
            }

            if (OddMax != double.MinValue)
            {
                builder.AppendLine(string.Format("OddMax={0},", OddMax));
            }
            else
            {
                builder.AppendLine(string.Format("OddMax={0},", "No"));
            }

            builder.AppendLine(string.Format("EvenSum={0},", EvenSum));

            if (EvenMin != double.MaxValue)
            {
                builder.AppendLine(string.Format("EvenMin={0},", EvenMin));
            }
            else
            {
                builder.AppendLine(string.Format("EvenMin={0},", "No"));
            }

            if (EvenMax != double.MinValue)
            {
                builder.AppendLine(string.Format("EvenMax={0}", EvenMax));
            }
            else
            {
                builder.AppendLine(string.Format("EvenMax={0}", "No"));
            }

            Console.WriteLine(builder.ToString());
        }
    }
}
