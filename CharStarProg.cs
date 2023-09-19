using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_NineDWhileLoop
{                                                       
    internal class CharStarProg
    {
        static void Main(string[] args)
        {
            char ch1;
            char ch2;
            for (ch1 = 'A'; ch1 <= 'D'; ch1++)
            {
                for (ch2 = 'A'; ch2 <= ch1; ch2++)
                {
                    Console.Write(ch2);
                }
                Console.WriteLine();
            }
        }
    }
}
//A
//AB
//ABC
//ABCD