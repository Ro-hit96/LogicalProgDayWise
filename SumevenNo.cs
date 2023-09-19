using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixDay
{   //WC to findout the sum of even no bet 1 to 10
    internal class SumevenNo
    {
        static void Main(string[] args)
        { 
            int sum = 0;
            for(int i=1; i<=10; i++)
            {
                if (i % 2 == 0)
                {
                    sum = sum + i;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
