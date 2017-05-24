using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _2Xmass_ex26
{
    class Program
    {
        static int[][] ConversionToArray(string stringMass, int p, int[][] mass)
        {

            string[] text = stringMass.Split(new char[] { ',' });
            for (int j = 0; j < text.Length; j++)
            {
                mass[p][j] = Convert.ToInt32(text[j]);
            }

            return mass;
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\x.txt");
            string[] mess = text.Split(new char[] {'.'});
            int[][] mass = new int[mess.Length][];

            for (int i = 0; i < mess.Length; i++)
            {
                mass[i] = new int[7];
            }
            for (int i = 0; i < mess.Length; i++)
            {
                mass = ConversionToArray(mess[i], i, mass );
            }
            for (int i = 0; i < mess.Length; i++)
            {
                for (int j = 0; j < 7; j++)
                {
                    Console.Write(mass[i][j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < 7; i++)
            {
                int number = 0;
                for (int j = 0; j < mass.Length; j++)
                {
                    number++; 
                }
                Console.WriteLine("Количество элементов в столбце {0} = {1}",i+1, number);
            }
        }
    }
}
