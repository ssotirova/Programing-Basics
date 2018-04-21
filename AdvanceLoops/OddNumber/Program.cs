using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace OddNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int n = 1;
            while (n<=number)
            {
                Console.WriteLine(n);
                n = n * 2 + 1;
            }
        }
    }
}
