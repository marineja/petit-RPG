using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public class Monstre : Entite
    {
        public Monstre(string nom) : base(nom)
        {
            this.nom = nom;
            this.pointsDeVie = 60;
            this.degatsMin = 5;
            this.degatsMax = 10;
        }
    }
}
