using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SixDay
{
    internal class SumofOddNo
    {
        static void Main(string[] args)
        {
            int sum = 0;
            for(int i = 1; i <= 10; i++)
            {
                if (i % 2 == 1)
                {
                    sum=sum+i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
