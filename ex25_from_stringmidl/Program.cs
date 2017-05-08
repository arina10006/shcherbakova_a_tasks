using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace ex25_from_stringmidl
{
    class Program
    {

        static double SquareOfNumber(int number)
        {
            double a;
            a = Math.Pow(number, 2); 
            return a;
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\HP\Desktop\number.txt");
            string[] number = text.Split(new char[] { ';'});
            double summ = 0;
            for (int i = 0; i <number.Length; i++)
            {
                int n = Convert.ToInt32(number[i]);
                double p = SquareOfNumber(n);
                summ = summ + p;
            }
            Console.WriteLine("Сумма квадратов компонент={0}",summ);
        }
    }
}
