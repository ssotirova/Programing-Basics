using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_of_10x10_Stars
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 1; row<=10; row++)
            {
                for (int i = 1; i <= 10; i++)
                {
                    Console.Write('*');
                }
                Console.WriteLine();
            }
            
        }
    }
}
