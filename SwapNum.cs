using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay
{           //WC to swap the two no
    internal class SwapNum
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First No Before Swap");
            int num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second No Before Swap");
            int num2 = Convert.ToInt32(Console.ReadLine());

            int num3 = num1;
            num1 = num2;
            num2 = num3;
            Console.WriteLine("After Swaping No");
            Console.WriteLine($"After Swap First No {num1}\t and second No {num2}");

        }
    }
}
