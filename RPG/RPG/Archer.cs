using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    class Archer : Personnage
    {
        public Archer(string nom) : base(nom)
        {
            pointsDeVie = 105;
            degatsMin = 15;
            degatsMax = 20;
        }
    }
}
