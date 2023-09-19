using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_NineDWhileLoop
{
    internal class Pattern6
    {
        static void Main(string[] args)
        {

            for (int i = 4; i >= 1; i--)
            {
                for (int j = i; j <= i; j++)
                {
                    
                    Console.Write(j);
                }
                Console.WriteLine();
            }
        }
    }
}
