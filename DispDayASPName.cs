using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixDay
{
    internal class DispDayASPName
    {
        static void Main(string[] args)
        {
           
            Console.WriteLine("Press No 1");
            Console.WriteLine("Press No 2");
            Console.WriteLine("Press No 3");
            Console.WriteLine("Press No 4");
            Console.WriteLine("Press No 5");
            Console.WriteLine("Press No 6");
            Console.WriteLine("Press No 7");
            Console.WriteLine("Enter No");
            int num = Convert.ToInt32(Console.ReadLine());

            switch (num)
            {
                case 1:
                    Console.WriteLine("Monday");
                    break;
                case 2:
                    Console.WriteLine("Tuesday");
                    break;
                case 3:
                    Console.WriteLine("Wednesday");
                    break;
                case 4:
                    Console.WriteLine("Thrusday");
                    break;
                case 5:
                    Console.WriteLine("Friday");
                    break;
                case 6:
                    Console.WriteLine("Saturday");
                    break;
                case 7:
                    Console.WriteLine("Sunday");
                    break;
                default:
                    Console.WriteLine("Please Enter Correct Value");
                    break;
            }

        }
    }
}
