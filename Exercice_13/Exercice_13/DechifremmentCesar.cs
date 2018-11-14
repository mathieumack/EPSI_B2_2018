using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exercice_13
{
    public class DechifremmentCesar : Cesar
    {
        public override int CalculPosition(int positionLettre, int decalage)
        {
            return (positionLettre + 26 - Math.Abs(decalage)) % 26;
        }
    }
}
