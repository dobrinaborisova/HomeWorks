using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Training_Lab
{
    class Program
    {
        static void Main(string[] args)
        {
          //  start:
            double length = double.Parse(Console.ReadLine())*100;
            double width = double.Parse(Console.ReadLine()) * 100;

            double numberOfSpacesPerRow = Math.Truncate((width - 100)/70);
            double numberOfSpacesPerColoumn = Math.Truncate((length / 120));
            double numberOfWorkSpaces = (numberOfSpacesPerRow * numberOfSpacesPerColoumn) - 3;

            Console.WriteLine(Math.Floor(numberOfWorkSpaces));

         //   goto start;
        }
    }
}
