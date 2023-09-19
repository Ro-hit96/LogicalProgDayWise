using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEight
{
    internal class OnetoTwentyDivisibleBy3and5
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 20; i++)
            {
                if (i % 3 == 0 || i%5==0)
                {
                    continue;
                }
                Console.WriteLine(i);

            }
           

        }
    }
}
