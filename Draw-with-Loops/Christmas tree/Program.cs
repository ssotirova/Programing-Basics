﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Christmas_tree
{
    class Program
    {
        static void Main(string[] args)
        {
            var size = int.Parse(Console.ReadLine());
            var rows = size + 1;
            int countOfWhiteSpaces = size;

            for (int row = 0; row < rows; row++)
            {
                for (int col = 0; col < countOfWhiteSpaces; col++)
                {
                    Console.Write(" ");
                }
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }

                Console.Write(" | ");
                for (int col = 0; col < row; col++)
                {
                    Console.Write("*");
                }
                countOfWhiteSpaces--;
                Console.WriteLine();
            }
        }
    }
}
