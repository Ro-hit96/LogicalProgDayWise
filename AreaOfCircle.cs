using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class AreaOfCircle
    {
        static void Main(string[] args)
        {
            double pi = 3.14;
            Console.WriteLine("Enter Radious");
            int r=Convert.ToInt32(Console.ReadLine());
            double area = pi + r * r;
            Console.WriteLine(area);

        }
    }
}
