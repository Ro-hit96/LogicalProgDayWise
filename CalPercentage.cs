using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Channels;
using System.Threading.Tasks;

namespace SecondDay
{
    //WC to Claculate per of five sub marks
    internal class CalPercentage
    {
       static void Main(string[] args)
        {
            Console.WriteLine("Enter Hindi Sub Mark");
            int hindi = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Maths Sub Mark");
            int maths = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter His Sub Mark");
            int his = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter Geo Sub Mark");
            int geo = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter C# Sub Mark");
            int c = Convert.ToInt32(Console.ReadLine());
            
            double Percentage=(hindi+maths+his+geo+c)/500.0*100;

            Console.WriteLine($"Percentage of Five Subject={Percentage}");
        }
    }
}
    