﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PiramydNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int num = 0;
            for (int row = 1; ; row++)
            {
                for (int col = 1; col <= row; col++)
                {
                    Console.Write($"{++num} ");
                    
                    if (num==number)
                    {
                        Console.WriteLine();
                        return;
                    }
                }
                Console.WriteLine();
            }
        }
    }
}
