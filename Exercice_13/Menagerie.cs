using Exercice_11.Actions;
using System;
using System.Collections.Generic;

namespace Exercice_11
{
    public class Menagerie
    {
        public List<Animal> Animaux { get; private set; }

        public Menagerie()
        {
            Animaux = new List<Animal>();
        }

        /// <summary>
        /// Lance la gestion de la ménagerie
        /// </summary>
        public void StartManagement()
        {
            MenagerieAction action = ProchaineAction();
            while(action != MenagerieAction.Stop)
            {
                ExecuteAction(action);
                action = ProchaineAction();
            }
        }

        /// <summary>
        /// Récupère la prochaine action à effectuer
        /// </summary>
        /// <returns></returns>
        private MenagerieAction ProchaineAction()
        {
            Console.WriteLine("Que souhaitez-vous faire ? 1 = Ajouter un animal, 2 = Lister, 3 = Lancer une course, Autre choix = Quitter l'application.");

            string choixUtilisateur = Console.ReadLine();
            switch(choixUtilisateur)
            {
                case "1":
                    return MenagerieAction.AjouterAnimal;
                case "2":
                    return MenagerieAction.ListerAnimaux;
                case "3":
                    return MenagerieAction.LancerUneCourse;
                default:
                    return MenagerieAction.Stop;
            }
        }

        /// <summary>
        /// Lance l'execution d'une action donnée
        /// </summary>
        /// <param name="action"></param>
        private void ExecuteAction(MenagerieAction action)
        {
            switch(action)
            {
                case MenagerieAction.AjouterAnimal:
                    ExecuteAction<AjouterAnimal>();
                    break;
                case MenagerieAction.ListerAnimaux:
                    ExecuteAction<ListerAnimaux>();
                    break;
                default:
                    break;
            }
        }

        /// <summary>
        /// Execute une action d'un type donné
        /// </summary>
        /// <typeparam name="T"></typeparam>
        private void ExecuteAction<T>() where T : IAction, new()
        {
            T action = new T();
            action.Execute(this);
        }
    }
}
