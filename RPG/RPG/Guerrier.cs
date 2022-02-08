using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Guerrier : Personnage //class guerrier herite de personnage
    {

        public Guerrier(string nom) : base(nom)
        {
            pointsDeVie = 120;
            degatsMin = 10;
            degatsMax = 15;
        }


    }
}
