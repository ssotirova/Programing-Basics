using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Area
{
    class Program
    {
        static void Main(string[] args)
        {
            var figure = Console.ReadLine();
            double area = 0.000;
            if (figure == "square")
            {
                var a = double.Parse(Console.ReadLine());
                area = a * a;
                Console.WriteLine(Math.Round(area,3));
            }
            else if (figure == "rectangle")
            {
                var a = double.Parse(Console.ReadLine());
                var b = double.Parse(Console.ReadLine());
                area = a * b;
                Console.WriteLine(Math.Round(area, 3));
            }
            else if (figure == "circle")
            {
                var r = double.Parse(Console.ReadLine());
                area = Math.PI * r * r;
                Console.WriteLine(Math.Round(area, 3));
            }
            else
            {
                var a = double.Parse(Console.ReadLine());
                var h= double.Parse(Console.ReadLine());
                area = (a * h) / 2.0;
                Console.WriteLine(Math.Round(area, 3));
            }
        }
    }
}
