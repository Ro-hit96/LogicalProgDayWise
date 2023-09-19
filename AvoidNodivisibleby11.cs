using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DayEight
{
    internal class AvoidNodivisibleby11
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 25; i++)
            {
                if (i % 11 == 0)
                {
                    break;
                }
                Console.WriteLine(i);
            }
        }
    }
}
