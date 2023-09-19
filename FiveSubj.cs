using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Schema;

namespace SeventhDay
{   //Write a program to enter marks of five subjects and calculate total, average and percentage

    internal class FiveSubj
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Hindi Marks");
            int hin=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Marathi Marks");
            int Mar=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter His Marks");
            int his=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Geo Marks");
            int geo=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Alge Marks");
            int alg=Convert.ToInt32(Console.ReadLine());

            double total=hin+Mar+his+geo+alg;
            Console.WriteLine("Total Marks=" + total);

            double avg = total / 5;
            Console.WriteLine("Average is=" + avg);

            double Per = (total / 500) * 100;
            Console.WriteLine("Percentage is ="+Per);

        }
    }
}
