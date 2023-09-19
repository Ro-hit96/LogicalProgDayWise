using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace ThirdDay
{
    internal class PosiNegaNo
    {
        static void Main(string[] args)
        {
            int a = 3; int b=6;
            string c = (a > b) ? "a is greater" : "b is greater";
            Console.WriteLine(c);

        }
    }
}
