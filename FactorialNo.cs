using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixDay
{
    internal class FactorialNo
    {
        static void Main(string[] args)
        {
            int fact = 1;
            int num=6;
            for(int i=1;i<=num;i++)
            {
                fact=fact*i;
            }
            Console.WriteLine($"Fact No= {fact}");
        }
    }
}
