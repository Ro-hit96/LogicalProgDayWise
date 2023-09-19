using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class FiboSeries
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Series");
            int ser=Convert.ToInt32(Console.ReadLine());
            int F1 = 0;
            int F2 = 1;
            int i = 0;
            Console.WriteLine(F1);
            Console.WriteLine(F2);
            while (i <=ser)
            {
                i = F1 + F2;
                Console.WriteLine(i);
                F1 = F2;
                F2 = i;
                i++;
            }
            
        }   
        
    }
}
