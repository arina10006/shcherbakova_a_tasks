using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;


namespace _19_04_work_with_char
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\HP\Desktop\news.txt");

            char[] arra = new char[text.Length];
            int[] erre = new int[text.Length];
            char[] more = new char[text.Length];
            char[] end = new char[text.Length];

            Random rnd = new Random();
            int n = rnd.Next(1, 7);
            Console.WriteLine(n);

            //string naw = Console.ReadLine();
            //int n = Convert.ToInt16(naw);

            string number = "Число кодировки: " + n + "\r\n";
            File.AppendAllText(@"C:\Users\HP\Desktop\code_the_text.txt",number);

            for (int i = 0; i < text.Length; i++)
            {
                arra[i] = text[i];
            }

            for (int i = 0; i < arra.Length; i++) // кодирование
            {
                erre[i] = (int)arra[i];
                erre[i] = erre[i] + n;
            }




            for (int i = 0; i < erre.Length; i++)
            {
                more[i] = (char)erre[i];
            }
            string wordsAnother = "";
            for (int i = 0; i < erre.Length; i++)
            {
                wordsAnother = wordsAnother + more[i];

            }

            File.AppendAllText(@"C:\Users\HP\Desktop\code_the_text.txt", wordsAnother);
            Console.WriteLine("Кодированный текст: " + wordsAnother);
            for (int i = 0; i < arra.Length; i++) //декод
            {
                erre[i] = (int)more[i];
                erre[i] = erre[i] - n;
            }
            for (int i = 0; i < erre.Length; i++)
            {
                end[i] = (char)erre[i];
            }
            string endWords = "\r\n";
            for (int i = 0; i < end.Length; i++)
            {
                endWords = endWords + end[i];
            }
            File.AppendAllText(@"C:\Users\HP\Desktop\code_the_text.txt", endWords);
            Console.WriteLine("Декодированный текст: " + endWords);
        }
    }
}
