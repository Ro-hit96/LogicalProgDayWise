using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEight
{
    internal class PrimeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter a No");
            int num = Convert.ToInt32(Console.ReadLine());
            int a = 1;
            for(int i=1;i<=num/2; i++) 
            {
                if (i % 2 == 0)
                {
                    a = 0;
                    break;
                }
                   
            }
            if(a == 0)
            {
                Console.WriteLine("Not Prime");
            }
            else
            {
                Console.WriteLine("Prime No");
            }
        }
    }
}
