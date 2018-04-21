using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace time
{
    class Program
    {
        static void Main(string[] args)
        {
            var hour = int.Parse(Console.ReadLine());
            var minute = int.Parse(Console.ReadLine());
            var newMinute = minute + 15;
            if (newMinute >= 60)
            {
                hour++;
                newMinute = newMinute - 60;
            }
            if (hour >= 24)
            {
                hour = hour - 24;
            }
            if (newMinute < 10)
            {
                Console.WriteLine("{0}:0{1}", hour, newMinute);
            }
            else
            {
                Console.WriteLine("{0}:{1}", hour, newMinute);
            }
            
        }
    }
}
