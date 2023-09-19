using System;
using System.Collections.Generic;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_NineDWhileLoop
{
    internal class Pattern3
    {
        static void Main(string[] args)
        {
            for(int i = 5; i >= 1; i--)
            {
                for(int j=i; j<=5; j++)
                {
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
