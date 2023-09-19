using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Linq;
using System.Runtime.Intrinsics.X86;
using System.Text;
using System.Threading.Tasks;

namespace DayEight
{
    internal class DisEvenNousingFor
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int num=Convert.ToInt32(Console.ReadLine());

            double sum = 0;
            int cnt = 0;
            while (num>0)

           {
                int rem=num%10;
                sum=sum+rem;
                cnt++;
                num = num / 10;
                
            }
            double avg = sum / cnt;
            Console.WriteLine(avg);


        }
    }
}
