using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Xmass__ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] mass = new int[4, 4];
            Random gen = new Random();
            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = gen.Next(-10, 5);
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int negativeElements = 0;
            for (int i = 0; i < mass.GetLength(1); i++)
            {
                if (mass[i, 1] < 0)
                {
                    negativeElements = negativeElements + 1;
                }
            }
            Console.WriteLine("Количество отрицательных элементов во 2-м столбце = {0}", negativeElements);
        }
    }
}
