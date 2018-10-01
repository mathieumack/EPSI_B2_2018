using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_9_2
{
    public enum ChiFouMi
    {
        Pierre = 0,
        Feuille = 1,
        Ciseaux = 2,
        Puit = 3
    }

    public interface ChiFouMiObject
    {
        ChiFouMi Value { get; }

        /// <summary>
        /// Renvoie vrai si l'objet courant bat la valeur passée en paramètre
        /// </summary>
        /// <param name="value"></param>
        /// <returns></returns>
        bool Bat(ChiFouMi value);
    }

    public class Pierre : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Pierre; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Ciseaux;
        }
    }

    public class Feuille : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Feuille; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Pierre || value == ChiFouMi.Puit;
        }
    }

    public class Ciseaux : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Ciseaux; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Feuille;
        }
    }

    public class Puit : ChiFouMiObject
    {
        public ChiFouMi Value { get { return ChiFouMi.Puit; } }

        public bool Bat(ChiFouMi value)
        {
            return value == ChiFouMi.Pierre || value == ChiFouMi.Ciseaux;
        }
    }

    public class Game
    {
        private Random random { get; set; }

        public void Start()
        {
            random = new Random();
            
            while (true)
            {
                ChiFouMi valeurJoueur = RecupererValeurJoueur();

                ChiFouMiObject valeurApplication = RecupererValeurApplication();

                if (valeurJoueur == valeurApplication.Value)
                    Console.WriteLine("Egalité.");
                else if (valeurApplication.Bat(valeurJoueur))
                    Console.WriteLine("L'ordinateur a gagné, il a joué : " + valeurApplication.Value.ToString());
                else 
                    Console.WriteLine("Bravo, vous avez gagné, il a joué : " + valeurApplication.Value.ToString());
            }
        }

        private ChiFouMi RecupererValeurJoueur()
        {
            Console.WriteLine("Tapez 0 pour la pierre, 1 pour la feuille, 2 pour les ciseaux et 3 pour le puit.");
            int valeur = int.Parse(Console.ReadLine());
            return (ChiFouMi)valeur;
        }

        private ChiFouMiObject RecupererValeurApplication()
        {
            // TODO : coder une IA qui va anticiper les coups de l'utilisateur

            return null;
        }

        private ChiFouMiObject CreateChiFouMiObject<T>() where T : ChiFouMiObject, new()
        {
            return new T();
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Tapez Ctrl+C pour quitter l'application.");

            Game game = new Game();
            game.Start();

            Console.ReadLine();
        }
    }
}
