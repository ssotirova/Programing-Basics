using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            int number;
            while (true)
            {
                number = int.Parse(Console.ReadLine());
                if (number%2==0)
                {
                    break;
                }
            }
            Console.WriteLine(number);
        }
    }
}
