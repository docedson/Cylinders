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
            //Intro message to say what you're doing
            Console.WriteLine("Let's use a cylinder calculator!");

            //Getting height information from the user
            Console.WriteLine("Please enter the height you would like: ");
            string HeightAsString = Console.ReadLine();
            double height = Convert.ToDouble(HeightAsString);
            Console.WriteLine(" ");

            //Getting the radius information from the user
            Console.WriteLine("Please enter the radius you would like: ");
            string RadiusAsString = Console.ReadLine();
            double radius = Convert.ToDouble(RadiusAsString);
            Console.WriteLine(" ");

            //Giving the program a set variable and math from the user's input
            double pi = 3.1415926;
            double Volume = pi * radius * radius * height;
            double SA = 2*pi * radius * (radius + height);

            //Spitting out the results
            Console.WriteLine("The volume is: " +Volume);
            Console.WriteLine("The surface area is: " +SA);
            Console.ReadKey();
        }
    }
}
