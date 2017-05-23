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
            string text = File.ReadAllText(@"C:\Users\HP\Desktop\news.txt");
            text.ToLower();

            string unic = "";

            foreach (char i in text)
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
            Dictionary <string, int> dictionary = new Dictionary<string, int>();
            
        }
    }
}
