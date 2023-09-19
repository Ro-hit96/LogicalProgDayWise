using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay
{
    internal class AreaofCircle
    {       //WC to calculate area of circle
        static void Main(string[] args)
        {
            double pi = 3.14;

            Console.WriteLine("Enter Radius");
            int radius = Convert.ToInt32(Console.ReadLine());

            double area=3.14*radius*radius;

            Console.WriteLine($"Area of Cirle= {area}");

        }
    }
}
