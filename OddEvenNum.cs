using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixDay
{
    internal class OddEvenNum
    {
        static void Main(string[] args)
        {
            
            Console.WriteLine("Enter No");
            int a=Convert.ToInt32(Console.ReadLine());

            switch (a % 2 == 0)
            {
                case true:
                    Console.WriteLine("No is Even");
                    break;
                    
                default:
                    Console.WriteLine("No is odd");
                    break;
            }
                        

        }
    }
}
