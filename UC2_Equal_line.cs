using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
namespace LineComparisonComputation
{
    internal class UC2_Equal_line
    {
        public static int x1,y1,x2,y2,x3,y3,x4,y4;
        public static void Equal_lines()
        {
            Console.WriteLine("Enter the co-ordinates value");
            Console.WriteLine("Enter co-ordinate for x1");
                x1=Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate for y1");
            y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate for x2");
            x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate for y2");
            y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate for x3");
            x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate for y3");
            y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate for x4");
            x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter co-ordinate for y4");
            y4 = Convert.ToInt32(Console.ReadLine());
        }
        public static void equal_length()
        {
            double value1, value2;
            Equal_lines();
            double s1=((x1*x1-x2*x2)+(y1*y1-y2*y2));
            double s2=((x3*x3-x4*x4)+(y3*y3-y4*y4));
            if (s1<0)
            {
                value1 = s1 * (-1);
            }
            else
            {
                value1 = s1;

            }
            double length1=Math.Sqrt(value1);
            if (s2<0)
            {
                value2=s2* (-1);
            }
            else
            {
                value2 = s2;
            }
            double length2=Math.Sqrt(value2);
            Console.WriteLine("length of line1 is : {0} units ", + length1);
            Console.WriteLine("length of line2 is : {0} units ", + length2);
            if(length1==length2)
            {
                Console.WriteLine("length of line1 is equalto length of line2");
            }
            
            else
            {
                Console.WriteLine("length of line1 is not equalto length of line2");
            }
        }

        
    }
}
