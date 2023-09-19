using System;
using System.Collections.Generic;
using System.Diagnostics.Metrics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SixDay
{
    internal class VowelandCon
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter Character");
            char ch = Convert.ToChar(Console.ReadLine());

            switch (ch)
            {
                case 'a':
              
                 Console.WriteLine($"Enter Character is Vowel {ch}");
                 break;
                case 'e':
                 
                    Console.WriteLine($"Enter Character is Vowl{ch}");
                break;
                case 'i':
                    
                    Console.WriteLine($"Enter Character is Vowl{ch}");
                break;
                case 'o':
                    
                    Console.WriteLine($"Enter Character is Vowl{ch}");
                break;
                case 'u':
                    Console.WriteLine($"Enter Character is Vowl{ch}");
                    break;
                default:
                    Console.WriteLine("Enter Character is Consololent");
                break;
            }
        }

        }
    }

