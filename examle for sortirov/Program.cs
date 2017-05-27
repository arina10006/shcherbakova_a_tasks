using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace examle_for_sortirov
{
    class Program
    {
        
            static string[] Sortirovka(string first, string slovo, string[] newText, int znach)
{
    string slovo1 = first;
    string slovo2 = slovo;
    string zamena;
    if (slovo1.Length == slovo2.Length)
    {
        for (int i = 0; i < slovo1.Length; i++)
        {

            if (slovo1[i] == slovo2[i])
            {
                continue;
            }
            else if (slovo1[i] < slovo2[i])
            {

                newText[znach - 1] = first;
                newText[znach] = slovo;
                break;

            }
            else if (slovo1[i] > slovo2[i])
            {
                zamena = newText[znach];
                newText[znach] = first;
                newText[znach - 1] = zamena;
                break;

            }

        }
    }
    if (slovo1.Length > slovo2.Length)
    {
        for (int i = 0; i < slovo2.Length; i++)
        {
            if (slovo1[i] == slovo2[i])
            {
                continue;
            }
            else if (slovo1[i] < slovo2[i])
            {
                newText[znach - 1] = first;
                newText[znach] = slovo;
                break;
            }
            else
            {
                zamena = newText[znach];
                newText[znach] = first;
                newText[znach - 1] = zamena;
                break;
            }
        }
    }
    if (slovo1.Length < slovo2.Length)
    {
        for (int i = 0; i < slovo1.Length; i++)
        {
            if (slovo1[i] == slovo2[i])
            {
                continue;
            }
            else if (slovo1[i] < slovo2[i])
            {
                newText[znach - 1] = first;
                newText[znach] = slovo;
                break;

            }
            else
            {
                zamena = newText[znach];
                newText[znach] = first;
                newText[znach - 1] = zamena;
                break;
            }
        }
    }
    string[] newText1 = newText;
    return newText1;
}
static void Main(string[] args) 
{
                string text = System.IO.File.ReadAllText(@"C:\Users\HP\Desktop\text.txt");
                string[] newText = text.Split(',');
                string allText = null;

                for (int i = 0; i < newText.Length; i++)
                {
                    allText += newText[i] + " ";
                }
                Console.WriteLine(allText);

                string slovo = null;
                string first = newText[0];
                int znach = 0;
                string[] sortirovka = null;
                for (int i = 1; i < newText.Length; i++)
                {
                    slovo = newText[i];
                    znach = i;
                    sortirovka = Sortirovka(first, slovo, newText, znach);
                    first = sortirovka[znach];
                }

                for (int i = 0; i < sortirovka.Length; i++)
                {
                    Console.WriteLine(sortirovka[i]);
                }

                Console.ReadKey();
            }
    }
}
