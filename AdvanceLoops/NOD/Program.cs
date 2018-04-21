using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NOD
{
    class Program
    {
        static void Main(string[] args)
        {
            var firstNumber = int.Parse(Console.ReadLine());
            var secondNumber = int.Parse(Console.ReadLine());

            while (secondNumber!=0)
            {
                var result = firstNumber % secondNumber;
                firstNumber = secondNumber;
                secondNumber = result;
            }
            Console.WriteLine(firstNumber);
        }
    }
}
