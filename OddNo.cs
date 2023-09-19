using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class FactoeialNo
    {
        static void Main(string[]args)
        {
            Console.WriteLine("Enter No");
            int a = Convert.ToInt32(Console.ReadLine());
            int Fact = 1;
            int i= 1;
            while( i<= a)
            {
                Fact = Fact * i;
               
                i++;
            }
            Console.WriteLine(Fact);
        }
    }
}
