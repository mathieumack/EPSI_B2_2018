using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_4_2
{
    class Program
    {
        static void Main(string[] args)
        {
            int min = 0;
            int max = 1001;
            Console.WriteLine("Pensez à une valeur entre 0 et 1000. Tapez sur entrée pour démarrer.");

            string userValue = Console.ReadLine();
            while(userValue != "=")
            {
                int currentValue = (min + max) / 2;

                Console.WriteLine("Est-ce " + currentValue + " ? (+, - ou =) :");
                userValue = Console.ReadLine();

                if(userValue == "+")
                {
                    min = currentValue;
                }
                else if (userValue == "-")
                {
                    max = currentValue;
                }
            }

            Console.WriteLine("Cool !");

            Console.ReadLine();
        }
    }
}
