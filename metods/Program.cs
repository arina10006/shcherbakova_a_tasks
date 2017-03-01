using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace metods
{
    class Program
    {
        static void IntInMassByRandomValyes(int[] internel_mass, int max, int min)
        {
            Random gen = new Random();
            for (int i = 0; i < internel_mass.Length; i++)
            {
                internel_mass[i] = gen.Next(min, max);
            }
        }

        static void IntInMassByRandomValyes(int[] internel_mass)
        { 

        }
        static void Main(string[] args)
        {
            int[] mas1;
            mas1 = new int[10];


        }
    }
}
