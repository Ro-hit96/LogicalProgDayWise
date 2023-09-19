using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay
{
    internal class DemoTypeConv
    {
        static void Main(string[] args)
        {
            //take input from user
            Console.WriteLine("Enter Your Name");
            String name = Console.ReadLine();

            Console.WriteLine("Enter Your age");
            int age=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your Percentage");
            double Percentage=Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"My name is {name} \n my age is {age}\n my percentage is {Percentage}");
        }
    }
}
