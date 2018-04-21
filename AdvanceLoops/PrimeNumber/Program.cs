using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PrimeNumber
{
    class Program
    {
        static void Main(string[] args)
        {
            var number = int.Parse(Console.ReadLine());

            if (number<=1)
            {
                Console.WriteLine("not prime");
                return;
            }

            bool isPrime = true;
            for (int i = 2; i <= number-1; i++)
            {
                if (number%i==0)
                {
                    isPrime = false;
                    break;
                }
            }
            string result = isPrime ? "prime" : "not prime";
            Console.WriteLine(result);
        }
    }
}
