using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay
{           // Wc to calculate area of rectangle
    internal class AreaofRect
    {
        static void Main(String[] args)
        {
            Console.WriteLine("Enter Length");
            int length = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter breadth");
            int breadth = Convert.ToInt32(Console.ReadLine());

            int area = length * breadth;

            Console.WriteLine($"area of Recatangle is={area}");

        }
    }
}
