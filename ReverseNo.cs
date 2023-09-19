using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEight
{
    internal class ReverseNo
    {
        static void Main(string[] args)
        {
            
            int rev = 0, rem;
            Console.WriteLine("Enter No");
            int num=Convert.ToInt32(Console.ReadLine());
            while (num!=0)
            {
                rem = num % 10;
                rev = rev * 10 + rem;
                num = num / 10;
            }
            Console.WriteLine(rev);

        }
    }
}
