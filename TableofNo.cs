using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixDay
{
    internal class TableofNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int a=Convert.ToInt32(Console.ReadLine());
            
            for(int i = 1; i <= 10; i++)
            {
                int table = i*a;
                Console.WriteLine(table);
            }
        }
    }
}
