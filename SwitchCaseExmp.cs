using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixDay
{
    internal class SwitchCaseExmp
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter First No");
            int a = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Sec No");
            int b = Convert.ToInt32(Console.ReadLine());

            int c = 0;

            Console.WriteLine("Press 1 for Addition");
            Console.WriteLine("Press 2 for Substraction");
            Console.WriteLine("Press 3 for Multi");
            Console.WriteLine("Press 4 for Division");
            int option = Convert.ToInt32(Console.ReadLine());

            switch (option)
            {
                case 1:
                 c = a + b;
                Console.WriteLine($"Addition of Two No is{c}");
                break;

                case 2:
                c = a - b;
                Console.WriteLine($"Substraction of No is {c}");
                break;

                case 3:
                c = a * b;
                Console.WriteLine($"Multiplication of no is {c}");
                break;

                case 4:
                c = a / b;
                    Console.WriteLine($"$division of no is {c}");
                break;

                default:
                    Console.WriteLine("Thank You");
                    break;




            }
        }

        
    }
}
