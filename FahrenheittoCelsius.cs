using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class FahrenheittoCelsius
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Fahrenheit");
            double Fer=Convert.ToDouble(Console.ReadLine());
            double cel = (Fer - 32) * 5 / 9;
            Console.WriteLine(cel);
        }
    }
}
