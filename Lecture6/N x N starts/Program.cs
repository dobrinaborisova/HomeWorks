using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace N_x_N_starts
{
    class Program
    {
        static void Main(string[] args)
        {
            int numberOfSTarts = int.Parse(Console.ReadLine());

            for (int i = 1; i <= numberOfSTarts; i++)
            {
                Console.WriteLine(new string('*', numberOfSTarts));
            }
        }
    }
}
