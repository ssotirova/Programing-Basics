using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sunglassess
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            int formula = size * 2;
            string border = new string('*', formula);
            string middleBorder = new string(' ', size);
            string topAndBotton = border + middleBorder + border;
            Console.WriteLine("{0}{1}{0}", border, middleBorder);

            for (int row = 0; row < size-2; row++)
            {
                int targetRow = (size - 1) / 2 - 1;
                char symbol = ' ';
                if (row == targetRow)
                {
                    symbol = '|';
                }
                string forwardSplash = new string('/', formula - 2);
                string middlePart = new string(symbol, size);
                Console.WriteLine("*{0}*{1}*{0}*", forwardSplash, middlePart);
            }
            Console.WriteLine("{0}{1}{0}", border, middleBorder);
        }
    }
}
