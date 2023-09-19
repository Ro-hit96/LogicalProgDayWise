using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SecondDay
{
    internal class Product
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Product Id");
            int id= Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Product Name");
            String name= Console.ReadLine();

            Console.WriteLine("Enter product Amount");
            double price = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine($"Product id= {id}\t Product Name={name}\t Product Amount={price}");
        }
    }
}




