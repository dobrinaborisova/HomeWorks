using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace House
{
    class Program
    {
        static void Main(string[] args)
        {
            int n = int.Parse(Console.ReadLine());
            int nCount = (n - 2) / 2;
            string outerTirence = "";
            string innetTirence = "";
            string star = "";
            int leftRight = (n - 1) / 2;
            int mid = n - 2 * leftRight - 2;

            //roof
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

            for (int i = 0; i <= nCount; i++)
            {
                if (leftRight < 0)
                {
                    return;
                }
                outerTirence = new string('-', leftRight);
                innetTirence = new string('*', mid);

                Console.WriteLine(outerTirence + "*" + innetTirence + "*" + outerTirence);

                if (i != nCount)
                {
                    leftRight--;
                    mid += 2;
                }
            }

            //foundation
            for (int i = 0; i < n/2; i++)
            {
                string str = string.Concat(Enumerable.Repeat("|", 1).Concat(Enumerable.Repeat("*", n - 2).Concat(Enumerable.Repeat("|", 1))));
                Console.WriteLine(str);
            }
        }
    }
}
