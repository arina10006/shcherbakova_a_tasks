using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _03._05.stringmidl_ex6
{
    class Program
    {
        static double ModuleOfComposition(int[] numbers)
        {
            double a = 0;
            for (int i = 0; i < numbers.Length; i++)
            {
                a = a + i;
            }
            a = Math.Abs(a);
            return a;
 
        }

        static double SquareOfProduct(int[] numbers)
        {
            double a = 1;
            for (int i = 0; i < numbers.Length; i++)
            {
                a = a * numbers[i];
            }
            a = Math.Pow(a,2);
            return a;
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\numbers.txt");
            string[] number = text.Split(new char[] { ';' });
            int[] mas = new int[number.Length];
            for (int i = 0; i < number.Length; i++)
            {
                mas[i] = Convert.ToInt32(number[i]);
            }
            double absValue = ModuleOfComposition(mas);

            for (int i = 0; i < mas.Length; i++)
			{

                Console.Write(mas[i]);

			}
            double sqrOfProduct = SquareOfProduct(mas);
            Console.WriteLine("\r\nМодуль сумы: {0}\r\nКвадрат произвдения: {1}", absValue, sqrOfProduct);
            

        }
    }
}
