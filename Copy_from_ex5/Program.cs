using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Copy_from_ex5
{
    class Program
    {
        static double Fraction(double numerator, double denominator)
        {
            double y = (numerator + Math.Sin(numerator)) / (Math.Sin(denominator) + denominator);

            return y;
        }
        static void Main(string[] args)
        {
            double summ = 0;
            for (int i = 1; i <= 3; i++)
            {
                Console.WriteLine("Введите значения для дроби {0}", i);
                Console.WriteLine("Введитель число из числителя");
                string a = Console.ReadLine();
                double numerator = Convert.ToDouble(a);

                Console.WriteLine("Введитель число из знаменателя");
                string b = Console.ReadLine();
                double denominator = Convert.ToDouble(b);

                double y = Fraction(numerator, denominator);

                summ = summ + y;

            }

            Console.WriteLine("Сумма у={0}", summ);
            Console.ReadKey();

        }
    }
}
