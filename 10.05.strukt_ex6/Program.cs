using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10._05.strukt_ex6
{
    struct Good
    {
        public string name;
        public int amount;
        public int price;
        public string manufacturer;
        public int date;

    }
    class Program
    {
        static double TotalValueOfGood(int amount, int price)
        {
            int total = amount * price;
            return total;
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\text.txt");
            string[] goods = text.Split(new char[] {'.'});

            Good[] goodsMas = new Good[goods.Length];
            for (int i = 0; i < goods.Length; i++)
            {
                string[] g = goods[i].Split(new char[] { ';' });
                goodsMas[i].name = g[0];
                goodsMas[i].amount = Convert.ToInt32(g[1]);
                goodsMas[i].price = Convert.ToInt32(g[2]);
                goodsMas[i].manufacturer = g[3];
                goodsMas[i].date = Convert.ToInt32(g[4]);
            }
            int ibig = 0;
            for (int i = 1; i < goodsMas.Length; i++)
            {
                if (TotalValueOfGood(goodsMas[ibig].amount, goodsMas[ibig].price) < TotalValueOfGood(goodsMas[i].amount, goodsMas[i].price))
                {
                    ibig = i;
                }
            }
            Console.WriteLine("Наибольшая общая стоимость у товара :{0}", goodsMas[ibig].name);



        }
    }
}
