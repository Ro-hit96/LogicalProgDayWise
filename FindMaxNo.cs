using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthDay
{
    internal class FindMaxNo
    {
        static void Main(string[] args)
        {
            int a = 50; int b=20; int c=30;

            if(a>b && a>c)
            {
                Console.WriteLine($"print {a} is greater");
            }
            else if(b>a && b > c)
            {
                Console.WriteLine($"print{b} is greater");
            }
           else
            {
                Console.WriteLine($"Print{c} is greater");
            }
        }
    }
}
