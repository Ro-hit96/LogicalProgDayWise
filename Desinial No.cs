using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Day_NineDWhileLoop
{
    internal class Desinial_No
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter No");
            int num = Convert.ToInt32(Console.ReadLine());
            
            int sum = 0;
            int temp = num;
            int Count = 0;

            while (num > 0)
            {
                Count++;
                num = num / 10;
            }
            num = temp;
            while (num > 0)
            {
                int digit = num % 10;
                int power = 1;
                for (int i = 1; i <= Count; i++)
                {
                    power = power * digit;
                }
                sum = sum + power;
                Count--;
                num = num / 10;
            }
                if (sum == temp)
                {
                    Console.WriteLine("No is Desarium");
                }
                else
                {
                    Console.WriteLine("no is not desarium");
                }

            }
        }
    }
//}
