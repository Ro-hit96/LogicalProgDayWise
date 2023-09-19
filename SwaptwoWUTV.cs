using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthDay
{
    internal class SwaptwoWUTV
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Before Swaping No");
            Console.WriteLine("enter first No");
            int a = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Second No");
            int b = Convert.ToInt32(Console.ReadLine());

            a = a - b;
            b = a + b;
            a = b - a;

            Console.WriteLine("After Swaping No");
            Console.WriteLine($"After Swaping A={a}");
            Console.WriteLine($"After Swaping B={b}");

        }
    }
}
