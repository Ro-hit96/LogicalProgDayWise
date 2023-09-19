using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay
{       //WC to calculate cube of no
    internal class CubeofNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num");
            int num1=Convert.ToInt32(Console.ReadLine());

            int Cube=num1*num1*num1;

            Console.WriteLine($"Cube of No is {Cube}");
        }
    }
}
