using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SquareofStars
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            int j = 0;
            for (int i = 1; i <= n; i++)
            {
                if (i == 1 || i == n)
                {
                    for (j = 1; j <= n; j++)
                    {
                        Console.Write("*");
                    }
                    Console.WriteLine();
                }
                if (i >= 2 && i <= n - 1)
                {
                    for (j = 1; j <= n; j++)
                    {
                        if (j == 1 || j == n)
                        {
                            Console.Write("*");
                        }
                        else if (j >= 2 && j <= n)
                        {
                            Console.Write(" ");
                        }
                    }
                    Console.WriteLine();
                }
            }
        }
    }
}
