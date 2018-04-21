using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Point_in_the_Figure
{
    class Program
    {
        static void Main(string[] args)
        {
            var h = int.Parse(Console.ReadLine());
            var x = int.Parse(Console.ReadLine());
            var y = int.Parse(Console.ReadLine());

            var inFirstRectangle = (x > 0 && x < 3 * h) && (y > 0 && y < h);
            var inSecondRectangle = (x > h && x < 2 * h) && (y > h && y < 4 * h);
            var onMiddleSide = (x > h && x < 2 * h && y == h);

            var outFirstRectangle = (x < 0 || x > 3 * h) || (y < 0 || y > h);
            var outSecondRectangle = (x < h || x > 2 * h) || (y < h || y > 4 * h);

            if (inFirstRectangle || inSecondRectangle || onMiddleSide)
            {
                Console.WriteLine("inside");
            }
            else if (outFirstRectangle && outSecondRectangle)
            {
                Console.WriteLine("outside");
            }
            else
            {
                Console.WriteLine("border");
            }
        }
    }
}
