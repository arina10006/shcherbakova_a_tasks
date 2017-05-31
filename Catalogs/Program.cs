using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace Catalogs
{
    class Program
    {
        static void Main(string[] args)
        {
            string dirName = @"C:\Users\student\Desktop\cool";

            if (Directory.Exists(dirName))
            {
                Console.WriteLine("Подкаталоги:");
                string[] dirs = Directory.GetDirectories(dirName);
                foreach (string s in dirs)
                {
                    Console.WriteLine(s);
                }
                string[] files;
                int p = 0;
                string allFiles = "";
                Console.WriteLine("Файлы:");
                
                string doc1 = dirs[0];
                Console.WriteLine();
                    
                files = Directory.GetFiles(doc1);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                    allFiles = allFiles + s + ",";
                    p++;
                }
                string doc2 = dirs[1];
                Console.WriteLine();

                files = Directory.GetFiles(doc2);
                foreach (string s in files)
                {
                    Console.WriteLine(s);
                    allFiles = allFiles + s + ",";
                    p++;
                }
                string[] alFiles = allFiles.Split(new char[] { ',' });
                Console.WriteLine(allFiles);
                string text = "";
                string[] texts = new string[p];
                for (int i = 0; i < p; i++)
                {
                    

                }
                
            }
            Console.ReadKey();
        }
    }
}
