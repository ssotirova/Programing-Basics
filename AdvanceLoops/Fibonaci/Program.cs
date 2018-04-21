using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Fibonaci
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());
            int firstNumber = 0;
            int secondNumber = 1;

            for (int i = 0; i < number; i++)
            {
                int newNumber = firstNumber + secondNumber;
                firstNumber = secondNumber;
                secondNumber = newNumber;
            }
            Console.WriteLine(secondNumber);
        }
    }
}
