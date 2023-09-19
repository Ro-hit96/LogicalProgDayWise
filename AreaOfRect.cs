using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class AreaOfRect
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Length");
            int len=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Width");
            int wid=Convert.ToInt32(Console.ReadLine());
            int Peri;

            Peri=2*(len+wid);
            Console.WriteLine($"Area of rectangle {Peri}");
        }
    }
}
