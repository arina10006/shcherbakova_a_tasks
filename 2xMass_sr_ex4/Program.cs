using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace _2xMass_sr_ex4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random gen = new Random();
            int n = gen.Next(3,9), m = gen.Next(3,9);
            int[,] mass = new int[n,m];
            int[] mess = new int[m];

            for (int i = 0; i < n; i++)
            {
                for (int j = 0; j < m; j++)
                {
                    mass[i, j] = gen.Next(0, 9);
                }
            }

            for (int i = 0; i < n; i++)
            {
                Dictionary<int,int> miss = new Dictionary<int,int>();
                for (int j = 0; j < m; j++)
                {
                    if (!miss.ContainsKey(mass[i,j]))
                    {
                        miss[mass[i, j]] = 1;
                    }
                    else
                    {
                        miss[mass[i, j]]++;
                    }
                }
                foreach (var pair in miss)
                {
                    if (pair.Value>1)
                    {
                        break;
                    }
                    else
                    {

                    }
                }
                
            }
        }
    }
}
