using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEight
{
    internal class DisplayEvenNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int num=Convert.ToInt32(Console.ReadLine());

            while (num > 0)
            {
                int digit = num % 10;
                num = num / 10;
                
                if (num % 2 == 1)
                {
                    Console.WriteLine(digit);
                }
            }
        }
    }
}
