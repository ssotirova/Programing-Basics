using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace USD_BGN
{
    class Program
    {
        static void Main(string[] args)
        {
            var us = double.Parse(Console.ReadLine());
            var bg = us * 1.79549;
            Console.WriteLine("{0} BGN", Math.Round(bg,2));
        }
    }
}
