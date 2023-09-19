using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Transactions;

namespace FifthDay
{
    internal class SwapTwoNoUTV
    {
        static void Main(string[] args)
        {
            int c=0;
            Console.WriteLine("Before Swap No");
            Console.WriteLine("Enter First No");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second No");
            int b = Convert.ToInt32(Console.ReadLine());

            c=a;
            a=b;
            b=c;
            Console.WriteLine("After Swaping No");
            Console.WriteLine($"After Swap A= {a}");
            Console.WriteLine($"After Swap B= {b}");


        }
    }
}
