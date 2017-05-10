using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _10._05.X2mass_ex6
{
    class Program
    {
        static void Main(string[] args)
        {
            int[,] matrica = new int[4, 3];
            Random gen = new Random();

            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j < matrica.GetLength(1); j++)
                {
                    matrica[i, j] = gen.Next(0, 9);
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
            int max1Index = 0, max3Index = 0;
            for (int i = 1; i < matrica.GetLength(0); i++)
            {
                if (matrica[max1Index,0]< matrica[i,0])
                {
                    max1Index = i;
                }
                if (matrica[max3Index, 2] < matrica[i, 2])
                {
                    max3Index = i;
                }
            }
            int change = matrica[max1Index,0];
            matrica[max1Index,0] = matrica[max3Index,2];
            matrica[max3Index,2] = change;
            for (int i = 0; i < matrica.GetLength(0); i++)
            {
                for (int j = 0; j <  matrica.GetLength(1); j++)
                {
                    Console.Write(matrica[i, j] + "\t");
                }
                Console.WriteLine();
            }
        }
    }
}
