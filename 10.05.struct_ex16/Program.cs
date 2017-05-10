using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace _10._05.struct_ex16
{
    struct HockeyPlayer
    {
        public string surname;
        public int age;
        public int play;
        public int washer;
    }

    class Program
    {
        static void Main(string[] args)
        {
            string text = File.ReadAllText(@"C:\Users\student\Desktop\text.txt");

            string[] man = text.Split(new char[] { '.' });
            HockeyPlayer[] players = new HockeyPlayer[man.Length]; 
            for (int i = 0; i < man.Length; i++)
            {
                string[] people = man[i].Split(new char[] { ';' });
                players[i].surname = people[0];
                players[i].age = Convert.ToInt32(people[1]);
                players[i].play = Convert.ToInt32(people[2]);
                players[i].washer = Convert.ToInt32(people[3]);
            }
            double midleAge = 0;
            for (int i = 0; i < players.Length; i++)
            {
                midleAge = midleAge + players[i].age;
            }
            midleAge = midleAge / players.Length;
            for (int i = 0; i < players.Length; i++)
            {
                if (players[i].age<=25)
                {
                    Console.WriteLine("Фамилия:{0}\r\nВозраст:{1}\r\nКоличество игр:{2}\r\nЗабитые шайбы:{3}\r\n", players[i].surname, players[i].age,players[i].play, players[i].washer );
                }
                
            }
            
        }
    }
}
