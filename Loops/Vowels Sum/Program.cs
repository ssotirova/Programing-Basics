using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vowels_Sum
{
    class Program
    {
        static void Main(string[] args)
        {
            var s = Console.ReadLine();
            var sum = 0;

            for (int i = 0; i < s.Length; i++)
            {
              
                switch (s[i])
                {
                    case 'a': sum = sum + 1; break;
                    case 'e': sum = sum + 2; break;
                    case 'i': sum = sum + 3; break;
                    case 'o': sum = sum + 4; break;
                    case 'u': sum = sum + 5; break;
                    default:
                        break;
                }
            }
            Console.WriteLine(sum);
        }
    }
}
