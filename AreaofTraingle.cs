using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay
{
    internal class AreaofTriangle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Height");
            int hie = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Base");
            int bas = Convert.ToInt32(Console.ReadLine());

            double Area = 0.5*(bas*hie);

            Console.WriteLine($"Area of Triangle={Area}");
        }
    }
}
