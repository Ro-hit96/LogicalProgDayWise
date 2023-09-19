using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_NineDWhileLoop
{
    internal class Pattern7
    {
        static void Main(string[] args)
        {
           // int n= 1;
           for(int i = 1; i <= 4; i++)
            {
                for(int j = 1; j <= i; j++)
                {
                    if (j == 1 || i == 4 || i == j)
                    {
                        Console.Write("*");
                    }
                    else
                    {
                        Console.Write(" ");
                    }
                }
                Console.WriteLine(  );
            }

        }
    }
}
