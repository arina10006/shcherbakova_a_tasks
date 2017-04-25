using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApplication3
{
    class Program
    {
        public static void Main(string[] args)
        {
            Go ob = new Go();
            ob.MiddleString();

            Console.ReadLine();
        }
    }
    class Go
    {
        public void MiddleString()
        {
            int allWordLength = 0;
            int wordLength = 0;
            int indBegin = 0;
            int indLast = 0;
            string str1 = "написать прогамму, которая";


            string text = System.IO.File.ReadAllText(@"C:\Users\student\Desktop\Путин.txt");
            string[] textWords = text.Split(new char[] { ' ', ',', '.', '—', '«', '»', '-' });

            var mas = text.Split(new char[] { ' ', ',' }, StringSplitOptions.RemoveEmptyEntries);
            for (int i = 0; i < mas.Length; i++)
            {
                indBegin = Array.IndexOf(mas, mas[i]);            //здесь отладчик просто принимает значение indBegin
                indLast = Array.LastIndexOf(mas, mas[i]);         // здесь отладчик просто принимает значение indLast
                wordLength = indLast - indBegin;
                allWordLength = allWordLength + wordLength;
            }
            Console.WriteLine(allWordLength / mas.Length);
        }
    }
}
