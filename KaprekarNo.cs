using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Day_NineDWhileLoop
{
    internal class KaprekarNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int num=Convert.ToInt32(Console.ReadLine());

            int count=0;
            int sq = num * num;
            int copy = num;
            while (num > 0)
            {
                count++;
                num = num / 10;
            }
            int power = 1;
            for(int i = 1; i <= count; i++)
            {
                power = power * 10;
            }
            int end = sq % power;
            int start = sq / power;
            int ans = end + start;
            Console.WriteLine(ans);
            if (ans == copy)
            {
                Console.WriteLine("no is kaprekar");
            }
            else
            
            {
                    Console.WriteLine("no is not kaprekar");
            }
            
        }

    }
}
