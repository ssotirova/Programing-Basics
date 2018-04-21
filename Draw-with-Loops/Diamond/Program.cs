using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Diamond
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            int countOfStars = size % 2 == 0 ? 2 : 1;
            int countOfDashes = (size - countOfStars) / 2;
            string topAndBotDashes = new string('-', countOfDashes);
            string stars = new string('*', countOfStars);
            Console.WriteLine("{0}{1}{0}", topAndBotDashes,stars);

            countOfDashes--;
            int countOfMiddleDashes = countOfStars;
            int rows = (size - 1) / 2;
            for (int i = 0; i < rows; i++)
            {
                string dashes = new string('-', countOfDashes);
                string middleDashes = new string('-', countOfMiddleDashes);
                Console.WriteLine("{0}*{1}*{0}", dashes, middleDashes);
                countOfDashes--;
                countOfMiddleDashes += 2;
            }
            rows--;
            countOfDashes += 2;
            countOfMiddleDashes -= 4;
            for (int i = 0; i < rows; i++)
            {
                string dashes = new string('-', countOfDashes);
                string middleDashes = new string('-', countOfMiddleDashes);
                Console.WriteLine("{0}*{1}*{0}", dashes, middleDashes);
                countOfDashes++;
                countOfMiddleDashes -= 2;
            }
            if (size>2)
            {
                Console.WriteLine("{0}{1}{0}", topAndBotDashes, stars);
            }
        }
    }
}
