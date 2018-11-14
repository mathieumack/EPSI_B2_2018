using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_13
{
    public class ChiffrementManager
    {
        public void Start()
        {
            Console.WriteLine("Entrez un texte à chiffrer :");
            string valeur = Console.ReadLine();

            Console.WriteLine("Entrez une valeur de décalage :");
            int decalage = int.Parse(Console.ReadLine());

            ICesar chiffrer = new ChiffrementCesar();
            Console.WriteLine("Résultat :" + chiffrer.ChiffreOuDechiffreMot(valeur, decalage));

            ICesar dechiffrer = new DechifremmentCesar();
            Console.WriteLine("Résultat :" + dechiffrer.ChiffreOuDechiffreMot(valeur, decalage));
        }
    }
}
