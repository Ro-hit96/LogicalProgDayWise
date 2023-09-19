using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthDay
{
    internal class PosiandNegNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int a = Convert.ToInt32(Console.ReadLine());

            if (a>0)
            {
                Console.WriteLine("No is Positive");
            }
            else if (a < 0)
            {
                Console.WriteLine("No is Negative");
            }
        }
    }
}
