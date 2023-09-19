using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDay
{                           //wc to check even no is divisible by three or not
    internal class EvenOdd
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int num = Convert.ToInt32(Console.ReadLine());

            string no = (num % 3 == 0) ? "Even Num is divisible" : "Even Num is not divisible";
            Console.WriteLine(no);

        }
    }
}
       