using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_11.Bonus
{ 
    public class PoussinDerriereDindon : IBonus
    {
        public int CalculBonus(Animal animal, List<Animal> animaux)
        {
            if (animal.AnimalType == AnimalType.Poussin)
            {
                int poussinIndex = animaux.IndexOf(animal);
                for (int i = poussinIndex + 1; i < poussinIndex; i++)
                {
                    if (animaux[i].AnimalType == AnimalType.Dindon)
                        return 2;
                }
            }
            return 0;
        }
    }
}
