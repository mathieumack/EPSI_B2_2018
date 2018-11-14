using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_11
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> alphabet = "abcdefghijklmnopqrstuvwxyz"
                                    .Select(e => e.ToString())
                                    .ToList();

            string lettre = "y";
            int decalage = 2;

            int positionLettre = alphabet.IndexOf(lettre);
            Console.WriteLine("Position de  " + lettre + " : " + positionLettre);

            positionLettre = (positionLettre + decalage) % 26;

            string lettreChiffree = alphabet[positionLettre];
            Console.WriteLine("Lettre chiffrée : " + lettreChiffree);

            decalage = -2;
            positionLettre = alphabet.IndexOf(lettreChiffree);
            positionLettre = (positionLettre + 26 - Math.Abs(decalage)) % 26;

            string lettreDeChiffree = alphabet[positionLettre];
            Console.WriteLine("Lettre déchiffrée : " + lettreDeChiffree);

            Console.ReadLine();
        }
    }
}
