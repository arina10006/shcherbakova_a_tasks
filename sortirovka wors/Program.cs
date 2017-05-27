using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace sortirovka_wors
{
    struct PairForDic
    {
        public string key;
        public int value;
    }
    class Program
    {
        static PairForDic[] Sortirovka(PairForDic[] words, PairForDic word, PairForDic first, int index)
        {
            string word1 = first.key, word2 = word.key;
            if (word1.Length == word2.Length)
            {
                 for (int i = 0; i < word1.Length; i++)
                 {
                    if ((int)word1[i] == (int)word2[i])
                     {
                        continue;
                     }
                    else
                    {
                        if ((int)word1[i] > (int)word2[i])
                        {
                            words[index-1] = word;
                            words[index] = first;
                            //return words;
                            break;
                        }
                        else
                        {
                           // return words;
                            break;
                        }

                    }
                 }
            }
            if (word1.Length < word2.Length)
            {
                for (int i = 0; i < word1.Length; i++)
                {
                    if ((int)word1[i] == (int)word2[i])
                    {
                        continue;
                    }
                    else
                    {
                        if ((int)word1[i] > (int)word2[i])
                        {
                            words[index - 1] = word;
                            words[index] = first;
                           // return words;
                            break;
                        }
                        else
                        {
                           // return words;
                            break;
                        }

                    }
                }

            }
            else
            {
                for (int i = 0; i < word2.Length; i++)
                {
                    if ((int)word1[i] == (int)word2[i])
                    {
                        continue;
                    }
                    else
                    {
                        if ((int)word1[i] > (int)word2[i])
                        {
                            words[index - 1] = word;
                            words[index] = first;
                            //return words;
                            break;
                        }
                        else
                        {
                           // return words;
                            break;
                        }

                    }
                }
            }
            
            return words;
        }

        static PairForDic[] SortirovkaForValue(PairForDic[] words, PairForDic value, PairForDic first, int index)
        {
            PairForDic one = first, two = value;
            if (value.value>first.value)
            {
                words[index - 1] = two;
                words[index] = one;
            }
            return words;
        }
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\HP\Desktop\news.txt");
            text = text.ToLower();
            
            
            string[] newText = text.Split(new char[] { '.', ',', '-', '_', '(', ')', '«', '»', ' ', ':', '?', '!' });


            Dictionary<string, int> dictionary = new Dictionary<string, int>();
            for (int i = 0; i < newText.Length; i++)
            {
                string symbol = Convert.ToString(newText[i]);
                if ((symbol != " ")&&(symbol !=""))
                {
                    if (!dictionary.ContainsKey(symbol))
                    {
                        dictionary[symbol] = 1;
                    }
                    else dictionary[symbol]++;
                }
            }
            int v = 0;
            foreach (var pair in dictionary)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
                v++;
            }
            Console.WriteLine("--------------------------------------------------------");
            PairForDic[] wordsAndVal = new PairForDic[v];
            int p = 0;
            foreach (var pair in dictionary)
            {
                wordsAndVal[p].key = pair.Key;
                wordsAndVal[p].value = pair.Value;
                p++; 
            }
            for (int i = 0; i < wordsAndVal.Length; i++)
            {
                Console.WriteLine(wordsAndVal[i].key + "\t" + wordsAndVal[i].value);
            }
            Console.WriteLine("--------------------------------------------------------");
            for (int i = wordsAndVal.Length-1; i > 0; i--)
            {
                string one = wordsAndVal[i - 1].key, two = wordsAndVal[i].key;
                if ((int)one[0]> (int)two[0])
                {
                    PairForDic first = wordsAndVal[0];
                    for (int g = 1; g < wordsAndVal.Length; g++)
                    {
                        wordsAndVal = Sortirovka(wordsAndVal, wordsAndVal[g], first, g);
                        first = wordsAndVal[g];
                    }

                }
            }
            
          
            
            for (int i = 0; i < wordsAndVal.Length; i++)
            {
                Console.WriteLine(wordsAndVal[i].key + "\t" + wordsAndVal[i].value);
            }
            Dictionary<string, int> dictionaryNew = new Dictionary<string, int>();
            for (int i = 0; i < wordsAndVal.Length; i++)
            {
                dictionaryNew[wordsAndVal[i].key] = wordsAndVal[i].value;
            }
            Console.WriteLine("--------------------------------------------------------");
            foreach (var pair in dictionaryNew)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
                v++;
            }
            Console.WriteLine("--------------------------------------------------------");
            for (int i = wordsAndVal.Length - 1; i > 0; i--)
            {
                int one = wordsAndVal[i - 1].value, two = wordsAndVal[i].value;
                if (one < two)
                {
                    PairForDic first = wordsAndVal[0];
                    for (int g = 1; g < wordsAndVal.Length; g++)
                    {
                        wordsAndVal = SortirovkaForValue(wordsAndVal, wordsAndVal[g], first, g);
                        first = wordsAndVal[g];
                    }

                }
            }
            for (int i = 0; i < wordsAndVal.Length; i++)
            {
                Console.WriteLine(wordsAndVal[i].key + "\t" + wordsAndVal[i].value);
            }
            Dictionary<string, int> dictionaryNew2 = new Dictionary<string, int>();
            for (int i = 0; i < wordsAndVal.Length; i++)
            {
                dictionaryNew2[wordsAndVal[i].key] = wordsAndVal[i].value;
            }
            Console.WriteLine("--------------------------------------------------------");
            foreach (var pair in dictionaryNew2)
            {
                Console.WriteLine(pair.Key + "\t" + pair.Value);
                v++;
            }
            Console.WriteLine("--------------------------------------------------------");
            Console.ReadKey();
        }
    }
}
