using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace work_with_texst
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = System.IO.File.ReadAllText(@"C:\Users\Public\Рабочий стол\Путин.txt");
            System.Console.WriteLine("Contents of WriteText.txt = {0}", text);
        }
    }
}
