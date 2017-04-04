using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_with_texst
{
    class Program
    {
        static double PercentOfALetter(char[] textSymbols, char letter)
        {
            double pct = 0, numberOfLetters = 0;
            foreach (var i in textSymbols)
            {
                if (i == letter)
                {
                    numberOfLetters = numberOfLetters + 1;
                }

                pct = numberOfLetters / (textSymbols.Length / 100);
            }
            return pct;
        }

        static int NumberOfWords(char[] textSymbols, char letter)
        {
            int numberOfWords = 0;
            foreach (var i in textSymbols)
            {
                if (i == letter)
                {
                    numberOfWords = numberOfWords + 1;
                }

            }
            return numberOfWords;
        }

        static bool SearchInUnique(string uniqueStr, char letter)
        {
            for (int i = 0; i < uniqueStr.Length; i++)
			{
			    if (uniqueStr[i]== letter)
	            {
                    return false;
	            }
            }
            return true;


        }
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\HP\Desktop\For Work.txt");
            Console.WriteLine("Текст: " + text);


            string[] textWords = text.Split(new char[] { ' ', ',', '.', '—', '«', '»', '-' });
            Console.WriteLine("Количество слов: " + textWords.Length);

            char[] textSimbol = text.ToCharArray();
            Console.WriteLine("Количество символов: " + textSimbol.Length);
            int copyTextSimbol = textSimbol.Length;


            char letter = 'т';
            double ptc = PercentOfALetter(textSimbol, letter);
            Console.WriteLine("Процент буквы в тексте: {0} %", ptc);


            string lowerText = text.ToLower();
            Console.WriteLine("Текст в нижнем регистре" + lowerText);

            string[] lowerTextWord = lowerText.Split(new char[] { ' ', ',', '.', '—', '«', '»', '-' });
            char[] lowerTextSibbol = lowerText.ToCharArray();

            string uniqueChar = "";

            foreach (char i in lowerText)
            {
                if (uniqueChar.Length == 0)
                {
                    uniqueChar = uniqueChar + i;
                }
                else
                {
                    bool lokal = SearchInUnique(uniqueChar, i);
                    if (lokal)
                    {
                        uniqueChar = uniqueChar + i;

                    }
                }

            }

            Console.WriteLine("Уникальные символы: " + uniqueChar);

            foreach (char i in uniqueChar)
            {
                double prc = PercentOfALetter(textSimbol, i);
                Console.WriteLine("Процент символа \"{0}\" в тексте, равен : {1}%", i, prc);
            }



            }

            
        }
    }

