using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class EquilateralTriangle

    { 
        static void Main(string[] args)
        {
            Console.WriteLine("Enter area");
            int a=Convert.ToInt32(Console.ReadLine());

            double res = 0;
            res = (1.5 / 4) * (a * a);
            Console.WriteLine("Area of equlateral" + res);
        }
    }
}
