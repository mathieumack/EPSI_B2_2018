using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_7
{
    public class De
    {
        private Random Random { get; set; }

        public De()
        {
            Random = new Random();
        }

        public int Lancer()
        {
            return Lancer(1, 5);
        }

        public int Lancer(int min, int max)
        {
            return Random.Next(min, max);
        }
    }

    public class Escargot
    {
        public int Pas { get; set; }

        public Escargot()
        {
            Pas = 0;
        }

        public void Avancer(int nbPas)
        {
            Pas = Pas + nbPas;
        }

        public bool EstArrive()
        {
            return Pas > 25;
        }
    }

    public class Jeu
    {
        public De de { get; set; }
        public Escargot[] escargots { get; set; }

        public Jeu()
        {
            int nbEscargots = 5;

            de = new De();
            escargots = new Escargot[nbEscargots];
            for (int i = 0; i < escargots.Length; i++)
            {
                escargots[i] = new Escargot();
            }
        }

        public void LancerCourse()
        {
            bool escargotArrive = false;

            while (!escargotArrive)
            {
                Console.WriteLine("Nouveau tour.");
                for (int i = 0; i < escargots.Length; i++)
                {
                    int valeurDe = de.Lancer();
                    escargots[i].Avancer(valeurDe);
                    escargotArrive = escargotArrive || escargots[i].EstArrive();
                    Console.WriteLine("Escargot " + i + " en position :" + escargots[i].Pas);
                }
            }

            for (int i = 0; i < escargots.Length; i++)
            {
                if (escargots[i].EstArrive())
                    Console.WriteLine("Escargot " + i + " arrivé !");
            }
        }
    }

    class Program
    {
        static void Main(string[] args)
        {
            Jeu monJeu = new Jeu();
            monJeu.LancerCourse();

            Console.ReadLine();
        }
    }
}
