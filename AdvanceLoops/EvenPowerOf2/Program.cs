﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EvenPowerOf2
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            for (int i = 0; i <= number; i+=2)
            {
                int power = (int)Math.Pow(2, i);
                Console.WriteLine(power);
            }
        }
    }
}
