using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class FindThirdAngle
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num1");
            int num1=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Num2");
            int num2=Convert.ToInt32(Console.ReadLine());

            int third=180;
            int CalAngle = 180 - (num1 + num2);

            Console.WriteLine($"ThirdAngle of Triangle {CalAngle}");
        }
    }
}
