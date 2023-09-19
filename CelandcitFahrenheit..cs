using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.NetworkInformation;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class CelandcitFahrenheit
    {
        static void Main(string[] args)
        {
            double fahrenheit;
            Console.WriteLine("Enter Celcious");
            double cel=Convert.ToDouble(Console.ReadLine());

            fahrenheit = (cel * 9) / 5 + 32;
            Console.WriteLine(fahrenheit);


        }
    }
}
