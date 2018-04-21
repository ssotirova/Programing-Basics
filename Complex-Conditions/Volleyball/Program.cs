using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Volleyball
{
    class Program
    {
        static void Main(string[] args)
        {
            var year = Console.ReadLine().ToLower();
            var holidays = int.Parse(Console.ReadLine());
            var weekends = int.Parse(Console.ReadLine());

            var playSofia = (48 - weekends)*3.0/4;
            var hPlaySofia = holidays * (2.0/ 3);
            var allPlays = playSofia + weekends+hPlaySofia;

            if (year == "leap")
            {
                Console.WriteLine("{0:f2}",Math.Truncate((0.15*allPlays)+allPlays));
            }
            else if (year == "normal")
            {
                Console.WriteLine("{0:f2}", Math.Truncate(allPlays));
            }
        }
    }
}
