using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace _03._05.string_ex25
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\PP.txt");

            string[] masOfPeople = text.Split(new char[] {'.'});
            for (int i = 0; i < masOfPeople.Length-1; i++)
            {
                string[] pp = masOfPeople[i].Split(';');
                int a = Convert.ToInt32(pp[3]);
                if (a<=2000)
                {
                    Console.WriteLine("Название оп: {0}\r\nЗавод: {1}\r\nГод выпуска: {2}\r\nЦена: {3} гривен\r\n", pp[0], pp[1], pp[2], pp[3]);
                }
            }
        }
    }
}
