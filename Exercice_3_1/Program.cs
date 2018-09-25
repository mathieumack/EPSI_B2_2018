using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_3_1
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int j = 1; j <= 20; j++)
            {
                for (int i = 1; i <= j; i++)
                {
                    if (i % 5 == 0 && i % 3 == 0)
                        Console.Write("FizzBuzz");
                    else if (i % 3 == 0)
                        Console.Write("Fizz");
                    else if (i % 5 == 0)
                        Console.Write("Buzz");
                    else
                        Console.Write(i);
                }
                Console.WriteLine("");
            }

            Console.ReadLine();
        }
    }
}
