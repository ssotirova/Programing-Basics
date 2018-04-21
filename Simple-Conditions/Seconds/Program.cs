using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sum_Seconds
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstCompetitor = int.Parse(Console.ReadLine());
            var secondCompetitor = int.Parse(Console.ReadLine());
            var thirdCompetitor = int.Parse(Console.ReadLine());
            int seconds = firstCompetitor + secondCompetitor + thirdCompetitor;
            int minutes = 0;
            if (seconds > 59)
            {
                minutes++;
                seconds = seconds - 60;
            }
            if (seconds > 59)
            {
                minutes++;
                seconds = seconds - 60;
            }
            if (seconds < 10)
            {
                Console.WriteLine(minutes + ":" + "0" + seconds);
            }
            else
            {
                Console.WriteLine(minutes + ":" + seconds);
            }
        }
    }
}

