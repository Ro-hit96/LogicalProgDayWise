using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SeventhDay
{
    internal class PalindromeNo
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Num");
            int num=Convert.ToInt32(Console.ReadLine());
            int pal = num;
            int rev = 0;
            while (num != 0)
            {
                int temp = num % 10;
                rev = (rev * 10) + temp;
                num = num / 10;
            }
            Console.WriteLine(rev);
            if (rev == pal)
            {
                Console.WriteLine("no is palindrome");
            }
            else
            {
                Console.WriteLine("Not Palindrome");
            }
        }
    }
}
//131
//temp=131%10-->13-->1
//rev=(0*10)+1
//rev=11
//num=131/10=13

//13%10-->1
//(11*10)+1
//rev=111
//13/10-->1