using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthDay
{
    internal class IfElseProg1
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter num");
            int no = Convert.ToInt32(Console.ReadLine());
            if (no == 0)
            {
                Console.WriteLine("Its Sunday");
            }
            else if (no == 1)
            {
                Console.WriteLine("Its Monday");
            }
            else if(no == 2)
            {
                Console.WriteLine("Its Tuesday");
            }
            else if( no == 3)
            {
                Console.WriteLine("Its Wedensday");
            }
            else if (no == 4)
            {
                Console.WriteLine("Its thursday");
            }
            else if (no == 5)
            {
                Console.WriteLine("Its Friday");
            }
            else if (no == 6)
            {
                Console.WriteLine("Its Saturday");
            }
            else if (no>=7) 
            {
                Console.WriteLine("Enter Valid No");
            }
        }
    }
}
