using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2Xmass__ex16
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int n = gen.Next(2,10);
            int[,] mass = new int[n, n];
            int product = 1;

            for (int i = 0; i < mass.GetLength(0); i++)
            {
                for (int j = 0; j < mass.GetLength(1); j++)
                {
                    mass[i, j] = gen.Next(1, 9);
                    Console.Write(mass[i, j] + "\t");
                }
                Console.WriteLine();
            }
            for (int i = 0; i < n; i++)
            {
                product = product * mass[0, i];
            }
            Console.WriteLine("Сумма элементов первой строки ={0}", product);
        
        }
    }
}
