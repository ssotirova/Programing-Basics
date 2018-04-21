using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Invalid_Number
{
    class Program
    {
        static void Main(string[] args)
        {
            var num = int.Parse(Console.ReadLine());
            bool IsInRange = (num >= 100 && num <= 200) || num == 0;
            if (!IsInRange)
            {
                Console.WriteLine("invalid");
            }
            
        }
    }
}
