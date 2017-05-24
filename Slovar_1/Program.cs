using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Slovar_1
{
    class Program
    {
        static bool SearchInUnique(string uniqueStr, char letter)
        {
            for (int i = 0; i < uniqueStr.Length; i++)
            {
                if (uniqueStr[i] == letter)
                {
                    return false;
                }
            }
            return true;


        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\news.txt");
            text = text.ToLower();
            string[] newText = text.Split(new char[] { '.', ',', '-', '_', '(', ')', '«', '»',' ', ':', '?', '!'});

            string allText = "";
            foreach (string i in newText)
            {
                allText = allText + i + " ";
            }
            Console.WriteLine(allText);
            string unic = "";

            foreach (char i in allText)
            {
                if (unic.Length == 0)
                {
                    unic = unic + i;
                }
                else
                {
                    bool lokal = SearchInUnique(unic, i);
                    if (lokal)
                    {
                        unic = unic + i;

                    }
                }
            }
            Console.WriteLine(unic);
            Dictionary <string, int> dictionary = new Dictionary<string, int>();

            for (int i = 0; i < allText.Length; i++)
            {
                string symbol = Convert.ToString(allText[i]);
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
