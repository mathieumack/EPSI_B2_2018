namespace Exercice_11
{
    public class Animal
    {
        /// <summary>
        /// Cri de l'animal
        /// </summary>
        public string Cri { get; set; }

        /// <summary>
        /// Nombre de pattes
        /// </summary>
        public int NbPattes { get; set; }

        /// <summary>
        /// Type de l'animal
        /// </summary>
        public AnimalType AnimalType { get; set; }

        /// <summary>
        /// Nom de l'animal
        /// </summary>
        public string Nom { get; set; }

        public Animal()
        {

        }

        public Animal(AnimalType animalType, int nbPattes, string cri)
        {
            AnimalType = animalType;
            NbPattes = nbPattes;
            Cri = cri;
        }
    }
}
