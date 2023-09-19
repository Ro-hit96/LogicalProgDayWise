using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDay
{
    internal class ExpreProg
    {
        static void Main(string[] args)
        {
            int a= 2;
            int b= 3;
            int x = ++a + ++b;
            Console.WriteLine(x+"a="+a +"b="+b);
            x = a++ - b--;
            Console.WriteLine(x + "a=" + a + "b=" + b);
            x = ++a - b++;
            Console.WriteLine(x + "a=" + a + "b=" + b);
            x = --a - --b-a;
            Console.WriteLine(x + "a=" + a + "b=" + b);
            x = b++ - a-- + b;
            Console.WriteLine(x + "a=" + a + "b=" + b);
            x = ++a + ++b - b;
            Console.WriteLine(x + "a=" + a + "b=" + b);

        }
    }
}
