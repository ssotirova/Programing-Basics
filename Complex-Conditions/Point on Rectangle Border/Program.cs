using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_on_Rectangle_Border
{
    class Program
    {
        static void Main(string[] args)
        {
            var x1 = double.Parse(Console.ReadLine());
            var y1 = double.Parse(Console.ReadLine());
            var x2 = double.Parse(Console.ReadLine());
            var y2 = double.Parse(Console.ReadLine());
            var x = double.Parse(Console.ReadLine());
            var y = double.Parse(Console.ReadLine());

            bool IsOnRightSite = (x == x2) && y <= y2 && y >= y1;
            bool IsOnLeftSite = (x == x1)  && y <= y2 && y >= y1;
            bool IsOnTop = (y == y1) && x <= x2 && x >= x1;
            bool IsOnBottom = (y == y2) && x <= x2 && x >= x1;

            if (IsOnBottom||IsOnLeftSite||IsOnRightSite||IsOnTop)
            {
                Console.WriteLine("Border");
            }
            else
            {
                Console.WriteLine("Inside / Outside");
            }
        }
    }
}
