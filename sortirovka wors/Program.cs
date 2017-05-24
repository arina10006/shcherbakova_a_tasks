using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sortirovka_wors
{
    struct Pair
    {
        public string key;
        public int value;
    }
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\news.txt");
            text = text.ToLower();
            string[] newText = text.Split(new char[] { '.', ',', '-', '_', '(', ')', '«', '»', ' ', ':', '?', '!' });

            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < newText.Length; i++)
            {
                string symbol = Convert.ToString(newText[i]);
                if (symbol != " ")
                {
                    if (!dictionary.ContainsKey(symbol))
                    {
                        dictionary[symbol] = 1;
                    }
                    else dictionary[symbol]++;
                }
            }
            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
            }

        }
    }
}
