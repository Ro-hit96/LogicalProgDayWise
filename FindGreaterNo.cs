using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class FindGreaterNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No 1");
            int num1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter No 2");
            int num2=Convert.ToInt32(Console.ReadLine());
            if (num1 > num2)
            {
                Console.WriteLine("Greatest no is"+num1);
            }
            else
            {
                Console.WriteLine("Greatest no is" + num2);
            }
        }
    }
}
