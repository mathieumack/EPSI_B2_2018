using Exercice_11.Bonus;
using System;
using System.Collections.Generic;

namespace Exercice_11.Actions
{
    public class LancerCourse : IAction
    {
        private List<IBonus> bonux;

        public LancerCourse()
        {
            bonux = new List<IBonus>();
            bonux.Add(new PoussinDerriereDindon());
            //bonux.Add(new ...());
        }

        public void Execute(Menagerie menagerie)
        {
            //foreach(IBonus bonus in bonux)
            //{

            //}
        }
    }
}
