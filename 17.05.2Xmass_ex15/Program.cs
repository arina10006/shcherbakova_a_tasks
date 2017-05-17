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
        static int[][] ConversionToArray(string stringMass,  int p)
        {
            
            string[] text = stringMass.Split(new char[] { ',' });
            int[][] mass = new int[stringMass.Length][];
            for (int j = 0; j < mass.GetLength(0); j++)
            {
                mass[p][j] = Convert.ToInt32(text[j]);   
            }

            return mass;
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\mess.txt");
            string[] mess = text.Split(new char[] { '.' });
            
            
            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    Console.Write(mass[i][j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
