using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixDay
{
    internal class DivisibleByThree
    {
       // wc to display no bet 1 t0 30 which are divisible by three
        static void Main(string[] args)
        {

            for(int i=1;i<=30;i++)
            {
                if (i % 3 == 0)// && i%5==0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
