using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NumberInRange
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            while (number<1 || number>100)
            {
                number=int.Parse(Console.ReadLine());
            }
            Console.WriteLine(number);
        }
    }
}
