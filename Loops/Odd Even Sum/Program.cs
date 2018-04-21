﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Odd_Even_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var n = int.Parse(Console.ReadLine());
            var evenSum = 0;
            var oddSum = 0;
            for (int i = 0; i < n; i++)
            {
                var num = int.Parse(Console.ReadLine());
                if (i%2==0)
                {
                    evenSum += num;
                }
                else
                {
                    oddSum += num;
                }
            }

            if (evenSum==oddSum)
            {
                Console.WriteLine($"Yes Sum = {evenSum}");
            }
            else
            {
                var difference = Math.Abs(evenSum - oddSum);
                Console.WriteLine($"No Diff = {difference}");
            }

        }
    }
}
