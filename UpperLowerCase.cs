using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ThirdDay
{            //WC chracter is upper case letter or Lower case letter using ternary
    internal class UpperLowerCase
    {
        static void Main(string[] args)
        {
            char b= 'A';

            string c = (b ='a'&& b='A') ? "b is Upper Case" : "b is lower case";



        }
    }
}
