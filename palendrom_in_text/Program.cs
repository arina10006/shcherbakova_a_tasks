using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace palendrom_in_text
{
    class Program
    {
        static bool PalendromInText(string words)
        {
            for (int i = 0,  j = words.Length-1; i < j ; i++, j--)
            {
                if (words[i] != words[j])
                {
                    return false;
                }
                
            }
            return true;
        }
        static void Main(string[] args)
        {

            string text = File.ReadAllText(@"C:\Users\student\Desktop\news.txt");
            Console.WriteLine(text);
            string lwrText = text.ToLower();
            //string[] words = lwrText.Split(new char[] { ' ', ',', '.', '-', '(', ')', '"', '—', '«', '»', ' ', '\n', '\r' });

            string[] wordsWithNull = lwrText.Split(new char[] { ' ', ',', '.', '-', '(', ')', '"', '—', '«', '»', ' ', '\n', '\r' });

            int numberOfNull = 0;
            for (int i = 0; i < wordsWithNull.Length; i++)
            {
                if (wordsWithNull[i] == "")
                {
                    numberOfNull = numberOfNull + 1;
                }

            }
            int a = wordsWithNull.Length - numberOfNull;
            string[] words = new string[a];

            int j = 0;
            for (int i = 0; i < wordsWithNull.Length; )
            {
                if (wordsWithNull[i] == "")
                    i++;
                else
                {
                    words[j] = wordsWithNull[i];
                    i++;
                    j++;
                }
            }
            string palendrom = "";
            foreach  (string i in words)
            {
                bool itemsOfWords = PalendromInText(i);
                if (itemsOfWords)
                {
                   
                    palendrom = palendrom +i + "\r\n";
                }
                
            }
            Console.WriteLine("Слова палендромы: {0}",palendrom);
        }
    }
}
