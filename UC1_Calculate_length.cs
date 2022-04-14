using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LineComparisonComputation
{
    internal class UC1_Calculate_length
    {
        public static int x1;
        public static int x2;
        public static int y1;
        public static int y2;
        public static void points()
        {
            Console.WriteLine("Enter the co-ordinate value");
            Console.WriteLine("Enter co-ordinate x1");
            x1 =Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate y2");
            y2 = Convert.ToInt32(Console.ReadLine());
        }
        public static void Calculatelength()
        {
            double value;
            points();
            double s = ((x1*x1-x2*x2)+(y1*y1-y2*y2));
            if(s<0)
            {
                value = s*(-1);
            }
            else
            {
                value = s;
            }
            double length =Math.Sqrt(value);
            Console.WriteLine("Lenth of Line is : {0} units", +length);
        }

    }
}
