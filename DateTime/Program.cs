using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace dateTime
{
    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\HP\Desktop\time.txt");
            string[] date = text.Split(new char[] {';'});
            DateTime[] dates = new DateTime[date.Length];

            for (int i = 0; i < dates.Length; i++)
            {
                dates[i] = Convert.ToDateTime(date[i]);
            }
            int indexOfMin = 0, indexOfMax = 0;
            DateTime min = DateTime.MaxValue, max = DateTime.MinValue;

            for (int i = 0; i < dates.Length; i++)
            {
                if (dates[i]< min)
                {
                    min = dates[i];
                    indexOfMin = i;
                }
            }
            for (int i = 0; i < dates.Length; i++)
            {
                if (dates[i] > max)
                {
                    max = dates[i];
                    indexOfMax = i;
                }
            }
            Console.WriteLine("Дата рождения самого младшего: {0}\r\nДата рождения самого старшего: {1}", dates[indexOfMax], dates[indexOfMin]);

        }
    }
}
