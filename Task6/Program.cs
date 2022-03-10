using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task6
{
    class Program
    {
        static void Main(string[] args)
        {
            const daysofweek workallday = (daysofweek)0b_1111111;
            string nameone = "Автосалон";
            string nametwo = "Магазин";
            daysofweek workdayone = (daysofweek.Вториник | daysofweek.Восскресенье) ^ workallday;
            daysofweek workdaytwo = (daysofweek.Суббота | daysofweek.Четверг) ^ workallday;
            Console.WriteLine(nameone+" работает: " + workdayone + ".");
            Console.WriteLine(nametwo + " работает: " + workdaytwo + ".");
        }
        [Flags]
        enum daysofweek
        {
             Понедельник = 1 << 0,
                Вториник = 1 << 1,
                   Среда = 1 << 2,
                 Четверг = 1 << 3,
                 Пятница = 1 << 4,
                 Суббота = 1 << 5,
            Восскресенье = 1 << 6
        }
    }
}
