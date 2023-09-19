using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class FactorofNo
    {
        static void Main(string[] args)

        {
            int no;
            Console.WriteLine("Enter No");
            int fact=Convert.ToInt32(Console.ReadLine());

            for(int i = 1; i <= fact; i++)
            {
                if (fact % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
