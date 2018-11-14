using System;

namespace Exercice_11.Actions
{
    public class ListerAnimaux : IAction
    {
        public void Execute(Menagerie menagerie)
        {
            foreach (Animal animal in menagerie.Animaux)
            {
                AfficherAnimal(animal);
            }
        }

        /// <summary>
        /// Affiche un animal dans la console
        /// </summary>
        /// <param name="animal"></param>
        private void AfficherAnimal(Animal animal)
        {
            Console.WriteLine(string.Format("Animal : {0}, {1}, {2}", animal.Nom, animal.AnimalType, animal.Cri));
        }
    }
}
