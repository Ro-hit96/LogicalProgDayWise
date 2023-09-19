using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEight
{
    internal class Spy
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int num=Convert.ToInt32(Console.ReadLine());
            int sum = 0;
            int mul=0;
            while(num > 0)
            {
                int rem = num % 10;
                sum = sum + rem;
                mul = sum * rem;
                num=num/10;
                
            }
            if (sum == mul)
            {
                Console.WriteLine("no is Spy");
            }
            else
            {
                Console.WriteLine("No is not spy");
            }
        }
    }
}
