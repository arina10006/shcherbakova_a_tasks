using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _17._05._2Xmass_ex15
{
    class Program
    {
        static int[][] ConversionToArray(string stringMass,  int p, int massLenght, int[][] mass)
        {
            
            string[] text = stringMass.Split(new char[] { ',' });
            for (int j = 0; j < mass.GetLength(0); j++)
            {
                mass[p][j] = Convert.ToInt32(text[j]);   
            }

            return mass;
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\HP\Desktop\mess.txt");
            string[] mess = text.Split(new char[] { '.' });
            int[][] mass = new int[mess.Length][];
            for (int i = 0; i < mess.Length; i++)
            {
                mass[i] = new int[mess.Length];
            }
            for (int i = 0; i < mess.Length; i++)
            {
                mass = ConversionToArray(mess[i], i, mess.Length, mass);
            }
            
            for (int i = 0; i < mess.Length; i++)
            {
                for (int j = 0; j < mess.Length; j++)
                {
                    Console.Write(mass[i][j] + "\t");
                }
                Console.WriteLine();
            }
            int sum = 0;
            for (int i = 0; i < mess.Length; i++)
            {
                sum = sum + mass[i][mess.Length-1];
            }
            Console.WriteLine("Сумма элементов последнего столбца = {0}",sum);
            File.AppendAllText(@"C:\Users\HP\Desktop\mess.txt", "Сумма элементов последнего столбца = "+ sum);
        }
    }
}
