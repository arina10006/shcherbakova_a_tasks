using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _03._05.stringmidl_ex16
{
    struct DateOfBirths
    {
        public int day;
        public int month;
        public int year;
    }
    
    class Program
    {

        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\date.txt");

            string[] date = text.Split(new char[] {';'});
            DateOfBirths[] dates = new DateOfBirths[date.Length];

            for (int i = 0; i < date.Length; i++)
            {
                string[] oneDate = date[i].Split('.');
                dates[i].day = Convert.ToInt32(oneDate[0]);
                dates[i].month = Convert.ToInt32(oneDate[1]);
                dates[i].year = Convert.ToInt32(oneDate[2]);
            }

            for (int i = 0; i < dates.Length; i++)
            {
                Console.WriteLine("{0}  , {1}  , {2}",dates[i].day, dates[i].month,dates[i].year );
            }

            for (int i = 0; i < dates.Length; i++)
            {
                if ((dates[i].month>=3)&&(dates[i].month<=5))
                {
                    Console.WriteLine(date[i]);
                }
            }
            int minYear = dates[0].year;
            int minMonth = dates[0].month;
            int minDay = dates[0].day;
            for (int i = 1; i < date.Length; i++)
            {
                if (minYear> dates[i].year)
                {
                    minYear = dates[i].year;
                    continue;
                }
                if (minYear == dates[i].year)
                {
                    if (minMonth> dates[i].month)
                    {
                        minMonth = dates[i].month;
                        continue;
                    }
                    
                    if (minMonth== dates[i].month)
	                {
                		 if (minDay>=dates[i].day)
                         {
                            Console.WriteLine(dates[i].);
                         }
                	}
	
                        
                    }
                }
                
            }
        }

    }
}
