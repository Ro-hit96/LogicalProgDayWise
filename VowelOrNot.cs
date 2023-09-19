using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthDay
{
    internal class VowelOrNot
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Char");
            char c=Convert.ToChar(Console.ReadLine());  

            if ((c =='A')||(c=='E')||(c=='I')||(c== 'O')||(c=='U'))
                {
                    Console.WriteLine("enter character is vowel");
                }
              else
                {
                    Console.WriteLine("Enter character is not vowel");
                }
            
        }
    }
}
