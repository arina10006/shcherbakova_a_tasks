using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ex5_in_Function_basic_value_y
{
    class Program
    {
        static double Fraction(double numerator, double denominator)
        {
            double y= (numerator + Math.Sin(numerator))/(Math.Sin(denominator) + denominator);

            return y;
        }

       
        static void Main(string[] args)
        {
            double summ = 0;
            Console.WriteLine("Хотите ввести значения дроби? 1-Да, 2-Нет");

            int q = Convert.ToInt16(Console.ReadLine());
            while (q == 1)
                {
                Console.WriteLine("Введите значения для дроби ");
                Console.WriteLine("Введитель число из числителя");
                string a = Console.ReadLine();
                double numerator = Convert.ToDouble(a);

                Console.WriteLine("Введитель число из знаменателя");
                string b = Console.ReadLine();
                double denominator = Convert.ToDouble(b);

                double y = Fraction(numerator, denominator);
                
                summ = summ + y;

                Console.WriteLine("Хотите ввести значения для следующей дроби? 1-Да, 2-Нет");

                int q2 = Convert.ToInt16(Console.ReadLine());
                if (q2==2)
                {
                    break;
                }
                
                }
            

            Console.WriteLine("Сумма у={0}", summ);
            Console.ReadKey();

        }
    }
}
