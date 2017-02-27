using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamand
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            string outerTirence = "";
            string innetTirence = "";
            string star = "";
            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;

            if (n % 2 == 0)
            {
                star = "**";
            }
            else
            {
                star = "*";
                mid = 1;
                Console.WriteLine(new string('-', leftRight) + star + new string('-', leftRight));
                leftRight--;
            }

            int nCount = (n - 2) / 2;

            for (int i = 0; i <= nCount; i++)
            {
                if (leftRight < 0)
                {
                    return;
                }
                outerTirence = new string('-', leftRight);
                innetTirence = new string('-', mid);

                Console.WriteLine(outerTirence + "*" + innetTirence + "*" + outerTirence);

                if (i != nCount)
                {
                    leftRight--;
                    mid += 2;
                }
            }

            leftRight = 1;
            mid -= 2;

            for (int i = 0; i <= nCount - 1; i++)
            {
                outerTirence = new string('-', leftRight);
                innetTirence = new string('-', mid);

                Console.WriteLine(outerTirence + "*" + innetTirence + "*" + outerTirence);

                leftRight++;
                mid -= 2;
            }

            if (n % 2 != 0)
            {
                Console.WriteLine(new string('-', (n - 1) / 2) + star + new string('-', (n - 1) / 2));
            }
        }
    }
}
