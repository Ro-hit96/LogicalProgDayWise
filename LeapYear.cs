using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class LeapYear
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Name");
            int Year=Convert.ToInt32(Console.ReadLine());
            if(Year%4==0 || Year % 400 == 0 && Year != 0)
            {
                Console.WriteLine("Leap Year");
            }
            else
            {
                Console.WriteLine("Not a Leep Year");
            }
            Console.ReadLine();
        }
    }
}
