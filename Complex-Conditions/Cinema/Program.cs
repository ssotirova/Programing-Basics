using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cinema
{
    class Program
    {
        static void Main(string[] args)
        {
            var ticket = Console.ReadLine().ToLower();
            var raw = int.Parse(Console.ReadLine());
            var colum = int.Parse(Console.ReadLine());
            var rezult = 0.0;
            switch (ticket)
            {
                case "premiere":rezult = 12.00;
                    Console.WriteLine("{0:f2}",raw * colum * rezult);
                    Console.WriteLine("leva"); break;
                case "normal": rezult = 7.50;
                    Console.WriteLine("{0:f2}", raw * colum * rezult);
                    Console.WriteLine("leva"); break;
                case "discount": rezult = 5.00;
                    Console.WriteLine("{0:f2} leva", raw * colum * rezult); break;
                default:
                    break;
            }
        }
    }
}
