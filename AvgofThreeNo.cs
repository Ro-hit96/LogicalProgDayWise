using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay
{
    internal class AvgofThreeNo
    {       //WC to calculate avg of 3 no
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First No");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second No");
            int num2 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter third No");
            int num3 = Convert.ToInt32(Console.ReadLine());

            int avg = num1 + num2 + num3 / 3;

            Console.WriteLine($"Average of Three No is = {avg}");
        }
    }
}
