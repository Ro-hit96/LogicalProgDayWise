using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class CompoundInterest
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Principale Amount");
            int p=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Rate Amount");
            int r=Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter Time Period");
            int time=Convert.ToInt32(Console.ReadLine());

            int CI = p * (r + 1 / 100) ^ time;
            Console.WriteLine("Compound Interest:"+CI);
        }
    }
}
