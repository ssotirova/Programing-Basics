using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Rectangle_Area
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.Write("x1= ");
            var x1 = double.Parse(Console.ReadLine());
            Console.Write("y1= ");
            var y1 = double.Parse(Console.ReadLine());
            Console.Write("x2= ");
            var x2 = double.Parse(Console.ReadLine());
            Console.Write("y2= ");
            var y2 = double.Parse(Console.ReadLine());
            var a = Math.Max(x1, x2) - Math.Min(x1, x2);
            var b = Math.Max(y1, y2) - Math.Min(y1, y2);
            var area = a * b;
            var perimeter = 2 * (a + b);
            Console.WriteLine(area);
            Console.WriteLine(perimeter);
        }
    }
}
