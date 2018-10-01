using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_9
{
    public enum ChiFouMi
    {
        Pierre = 0,
        Feuille = 1,
        Ciseaux = 2
    }

    public class Game
    {
        private Random random { get; set; }

        public void Start()
        {
            random = new Random();

            ChiFouMi valeurJoueur = RecupererValeurJoueur();
            ChiFouMi valeurApplication = RecupererValeurApplication();

            CheckWinner(valeurJoueur, valeurApplication);
        }

        private void CheckWinner(ChiFouMi valeurJoueur, ChiFouMi valeurApplication)
        {
            if (valeurJoueur == ChiFouMi.Pierre && valeurApplication == ChiFouMi.Feuille)
                Console.WriteLine("L'application a gagné.");
            else if (valeurJoueur == ChiFouMi.Pierre && valeurApplication == ChiFouMi.Ciseaux)
                Console.WriteLine("L'utilisateur a gagné.");
            else if (valeurJoueur == ChiFouMi.Feuille && valeurApplication == ChiFouMi.Pierre)
                Console.WriteLine("L'utilisateur a gagné.");
            else if (valeurJoueur == ChiFouMi.Feuille && valeurApplication == ChiFouMi.Ciseaux)
                Console.WriteLine("L'application a gagné.");
            else if (valeurJoueur == ChiFouMi.Ciseaux && valeurApplication == ChiFouMi.Feuille)
                Console.WriteLine("L'utilisateur a gagné.");
            else if (valeurJoueur == ChiFouMi.Ciseaux && valeurApplication == ChiFouMi.Pierre)
                Console.WriteLine("L'application a gagné.");
            else
                Console.WriteLine("Egalité.");
        }

        private ChiFouMi RecupererValeurJoueur()
        {
            int valeur = int.Parse(Console.ReadLine());
            return (ChiFouMi)valeur;
        }

        private ChiFouMi RecupererValeurApplication()
        {
            int valeur = random.Next(0, 4);
            return (ChiFouMi)valeur;
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Game game = new Game();
            game.Start();

            Console.ReadLine();
        }
    }
}
