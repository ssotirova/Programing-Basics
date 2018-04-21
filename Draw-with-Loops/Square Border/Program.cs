using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Square_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());

            var dashes = size - 2;

            Console.Write('+');
            for (int i = 0; i <dashes; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
            for (int row = 0; row < size-2; row++)
            {
                Console.Write('|');
                for (int col = 0; col < dashes; col++)
                {
                    Console.Write(" -");
                }
                Console.WriteLine(" |");
            }
            
            Console.Write('+');
            for (int i = 0; i < dashes; i++)
            {
                Console.Write(" -");
            }
            Console.WriteLine(" +");
        }
    }
}
