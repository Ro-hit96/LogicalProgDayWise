using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_NineDWhileLoop
{
    internal class Pattern4
    {
        static void Main(string[] args)
        {
            for(int i = 1; i <= 5; i++)
            {
                for(int k = 5; k >= i; k--)
                {
                    Console.Write(" ");
                }
                for (int j = 1; j <= i; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                
            }
        }

    }
}
 //     *
 //    **
 //   ***
 //  ****
 //******