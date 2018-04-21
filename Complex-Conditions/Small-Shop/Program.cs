using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Small_Shop
{
    class Program
    {
        static void Main(string[] args)
        {
            var product = Console.ReadLine().ToLower();
            var town = Console.ReadLine().ToLower();
            var quantity = double.Parse(Console.ReadLine());
            var price = 0.0;

            if (town=="sofia")
            {
                if (product=="coffee")
                {
                    price = 0.5;
                }
                else if(product == "water")
                {
                    price = 0.8;
                }
                else if (product == "beer")
                {
                    price = 1.2;
                }
                else if (product == "sweets")
                {
                    price = 1.45;
                }
                else
                {
                    price = 1.6;
                }
            }
            else if (town == "plovdiv")
            {
                if (product == "coffee")
                {
                    price = 0.4;
                }
                else if (product == "water")
                {
                    price = 0.7;
                }
                else if (product == "beer")
                {
                    price = 1.15;
                }
                else if (product == "sweets")
                {
                    price = 1.3;
                }
                else
                {
                    price = 1.5;
                }
            }
            else
            {
                if (product == "coffee")
                {
                    price = 0.45;
                }
                else if (product == "water")
                {
                    price = 0.7;
                }
                else if (product == "beer")
                {
                    price = 1.1;
                }
                else if (product == "sweets")
                {
                    price = 1.35;
                }
                else
                {
                    price = 1.55;
                }
            }
            var bill = quantity * price;
            Console.WriteLine(bill);
        }
    }
}
