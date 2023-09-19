using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FifthDay
{       //8.  Write a C# program to input electricity consumption unit and calculate
        //total electricity bill according to the given condition: For first 50 units Rs.
        //0.50/unit For next 100 units Rs. 0.75/unit For next 100 units Rs. 1.20/unit For
        //unit above 250 Rs. 1.50/unit An additional surcharge of 20% is added to the bill 
        //<=50  → 0.50 / unit
        //0 -100 → 0.75/ unit
        //100-200 → 1.20/unit
        //200-250 → 1.50 /unit
        //>250 → 1.50 / unit  → amt → additional 20 % surcharge

    internal class CheckElectricityBill
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Enter unit");
            double unit = Convert.ToDouble(Console.ReadLine());
            double bill = 0;
            double tbill = 0;

            if (unit <= 50)
            {
                bill = unit * 10;
            }
            else if(unit<=150)
            {
                bill = (50 * 0.50) + ((unit - 50) * 0.75);
            }
            else if (unit <= 250)
            {
                bill=(50*10)+(150*15)+
            }


        }
    
        }
    }
}




//wc to check given charatcter is upper case or lower case
//Wc to convert uppar case character to lower case character and lower case to upper case