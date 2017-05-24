using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace example_for_summ
{
    class Program
    {
        static void Main(string[] args)
        {
            int[][] matrica = new int[4][];
            for (int i = 0; i < 4; i++)
            {
                matrica[i] = new int[4];
            }
            Random gen = new Random();

            for (int i = 0; i < 4; i++)
            {
                for (int j = 0; j < 4; j++)
                {
                    matrica[i][j] = gen.Next(0, 9);
                    Console.Write(matrica[i][j] + "\t");
                }
                Console.WriteLine();
            }
            int[] summ = new int[5];

            for (int i = 0; i < 4; i++)
            {
                int sum = 0;
                for (int j = 0; j < 4; j++)
                {
                    sum = sum + matrica[j][i];
                }
                summ[i] = sum;

            }
            for (int i = 0; i < 4; i++)
            {
                Console.WriteLine("Столбец {0} его сумма = {1}", i, summ[i]);
            }
        
            //    string text = File.ReadAllText(@"C:\Users\student\Desktop\news.txt");

            //    string unic = "";
            //    text.ToLower();
            //    int count = 0;
            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        for (int j = 0; j < unic.Length; j++)
            //        {
            //            if (text[i] == unic[j])
            //            {
            //                count++;
            //            }
            //        }

            //        if (count == 0)
            //        {
            //            unic = unic + text[i];
            //        }

            //    }
            //Console.WriteLine(unic);

            //    Dictionary<string, int> slovari = new Dictionary<string, int>();

            //    for (int i = 0; i < unic.Length; i++)
            //    {
            //        slovari.Add(Convert.ToString(unic[i]), 0);
            //    }

            //    for (int i = 0; i < text.Length; i++)
            //    {
            //        slovari[Convert.ToString(text[i])]++;
            //    }



            //    Console.ReadKey();
            }
    }
}
