using System;

namespace Exercice_11.Actions
{
    public class AjouterAnimal : IAction
    {
        /// <summary>
        /// Ajoute un nouvel animal à la ménagerie
        /// </summary>
        /// <param name="menagerie"></param>
        public void Execute(Menagerie menagerie)
        {
            Console.WriteLine("Quel type d'animal (1 = Poussin, 2 = Chat, ...):");
            int typeAnimal = int.Parse(Console.ReadLine());

            Animal nouvelAnimal = CreerAnimal((AnimalType)typeAnimal);

            Console.WriteLine("Entrez un nom :");
            nouvelAnimal.Nom = Console.ReadLine();

            menagerie.Animaux.Add(nouvelAnimal);
        }

        /// <summary>
        /// Créé un objet animal et l'initialise (type et nombre de pattes)
        /// </summary>
        /// <param name="typeAnimal"></param>
        /// <returns></returns>
        private Animal CreerAnimal(AnimalType typeAnimal)
        {
            switch(typeAnimal)
            {
                case AnimalType.Chat:
                    return new Animal(typeAnimal, 4, "Miaou");
                case AnimalType.Chien:
                    return new Animal(typeAnimal, 4, "Ouaf");
                case AnimalType.Poussin:
                    return new Animal(typeAnimal, 2, "Cui cui");
                case AnimalType.Vache:
                    return new Animal(typeAnimal, 4, "Mow");
                default:
                    return new Animal(typeAnimal, 0, "??");
            }
        }
    }
}
