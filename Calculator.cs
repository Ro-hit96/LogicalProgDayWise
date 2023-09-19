using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SixDay
{
    internal class Calculator
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First No");
            int a=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Second No");
            int b=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Symbol(+,-,*,%)");
            char sym=Convert.ToChar(Console.ReadLine());

            switch (sym)
            {
                case '+':
                    int c = a + b;
                    Console.WriteLine($"Add is {c} ");
                    break;
                case '-':
                    int d = a - b;
                    Console.WriteLine($"Substraction is {d} ");
                    break;
                case '*':
                    int e = a * b;
                    Console.WriteLine($"Multiplication is {e} ");
                    break;
                case '%':
                    int f = a / b;
                    Console.WriteLine($"Division is {f} ");
                    break;
            }
        }
    }
}
