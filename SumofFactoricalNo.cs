using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEight
{
    internal class SumofFactoricalNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num");
            int num=Convert.ToInt32(Console.ReadLine());
            int fact = 1;
            int sum = 0;
            for(int i=1;i<=num; i++)
            {
                fact = fact * i;
                sum=sum + fact; 
            }
            Console.WriteLine(sum);
        }
    }
}
