using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cylinders
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's solve a cylinder problem out!");
            Console.WriteLine("Please enter the height you would like: ");
            string HeightAsString = Console.ReadLine();
            double height = Convert.ToDouble(HeightAsString);
            Console.WriteLine(" ");

            Console.WriteLine("Please enter the radius you would like: ");
            string RadiusAsString = Console.ReadLine();
            double radius = Convert.ToDouble(RadiusAsString);
            Console.WriteLine(" ");

            double pi = 3.1415926;
            double Volume = pi * radius * radius * height;
            double SA = 2*pi * radius * (radius + height);

            Console.WriteLine("The volume is: " +Volume);
            Console.WriteLine("The surface area is: " +SA);
            Console.ReadKey();
        }
    }
}
