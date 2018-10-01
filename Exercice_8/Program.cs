using System;

namespace Exercice_8
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                int valeurA = int.Parse(Console.ReadLine());
                int valeurB = int.Parse(Console.ReadLine());
                Console.WriteLine(valeurA + valeurB);
            }
            catch(FormatException ex)
            {
                Console.WriteLine("L'une des valeurs saisie n'est pas un entier.");
            }

            Console.ReadLine();
        }
    }
}
