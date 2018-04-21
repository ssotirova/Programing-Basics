using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Factoriel
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int fact = 1;
            do
            {
                fact = fact * number;
                number--;
            } while (number>1);
            Console.WriteLine(fact);
        }
    }
}
