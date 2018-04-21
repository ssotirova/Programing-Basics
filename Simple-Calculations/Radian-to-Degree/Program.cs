using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Radian_to_Degree
{
    class Program
    {
        static void Main(string[] args)
        {
            var r = double.Parse(Console.ReadLine());
            var d = r * 180 / Math.PI;
            Console.WriteLine(Math.Round(d));
        }
    }
}
