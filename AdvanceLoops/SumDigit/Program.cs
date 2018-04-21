﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SumDigit
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int sum = 0;
            while (number>0)
            {
                var lastDigit = number % 10;
                sum += lastDigit;
                number = number / 10;
            }
            Console.WriteLine(sum);
        }
    }
}
