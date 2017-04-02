using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_with_texst
{
    class Program
    {
        static int PercentOfALetter(char[] textSymbols, char letter)
        {
            int pct = 0, numberOfLetters = 0;
            foreach (var i in textSymbols)
            {
                if (i == letter)
                {
                    numberOfLetters = numberOfLetters +1 ;
                }

                pct = numberOfLetters / (textSymbols.Length / 100);
            }
            return pct;
        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\HP\Desktop\For Work.txt");
            Console.WriteLine("Текст: " + text);

            

            string words = text.Trim(new char[] { ',', '.', '—', '«', '»', '-' });
            string[] textWords = words.Split(new char[] { ' ' });
            Console.WriteLine("Количество слов: " + textWords.Length);

            char[] textSimbol = text.ToCharArray();
            Console.WriteLine("Количество символов: " + textSimbol.Length);
            int copyTextSimbol = textSimbol.Length;

            string toLowText = text;
            
            char letter = 'т';
            int ptc = PercentOfALetter(textSimbol, letter);
            Console.WriteLine("Процент буквы в тексте: {0} %",ptc);

            
        }
    }
}
