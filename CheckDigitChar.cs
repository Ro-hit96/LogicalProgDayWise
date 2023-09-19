using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthDay
{
    internal class CheckDigitChar
    {
        static void Main(string[] args)
        {
            Console.WriteLine("enter value");
            char c = Convert.ToChar(Console.ReadLine());

            if((c>='A'&& c<='Z')|| (c >= 'a' && c <= 'z'))
            {
                Console.WriteLine($"Enter value {c} is Aplhabet ");
            }
            else if((c>='0'&& c <= '9'))
            {
                Console.WriteLine($"enter Value {c} is Number");
            }
            else
            {
                Console.WriteLine("Enter value is Special Opertor");
            }

        }
    }
}
