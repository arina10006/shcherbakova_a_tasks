using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex10_in_Function_basic_trapeze
{
    class Program
    {
        static double ThePerimeterOfTrapezoid(double upperBase,double lowerBase, double height)
        {
            double perimeter, side, d;

            d = (lowerBase - upperBase) / 2;
            side = Math.Sqrt(Math.Pow(height, 2)+ Math.Pow(d,2));

            perimeter = upperBase + lowerBase + 2 * side;

            return perimeter;
        }
        static void Main(string[] args)
        {
            double upperBase1 = 4, lowerBase1 = 7, height1 = 3;
            double upperBase2 = 8, lowerBase2 = 12, height2 = 5;

            double thapezoid1 = ThePerimeterOfTrapezoid(upperBase1, lowerBase1, height1);
            double thapeziod2 = ThePerimeterOfTrapezoid(upperBase2, lowerBase2, height2);

            double summ = thapezoid1 + thapeziod2;
            Console.WriteLine("Сумма периметров двух трапеций = {0}", summ);
            Console.ReadKey();

        }
    }
}
