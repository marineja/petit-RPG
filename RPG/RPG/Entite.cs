using System;
using System.Collections.Generic;
using System.Text;

namespace RPG
{
    public abstract class Entite
    {
        protected string nom;
        protected bool estMort = false;
        protected int pointsDeVie;
        protected int degatsMin;
        protected int degatsMax;
        protected Random random = new Random();

        public Entite(string nom)
        {
            this.nom = nom;
        }

        public void Attaquer(Entite uneEntite)
        {
            int degats = random.Next(degatsMin, degatsMax);

            uneEntite.PerdrePOintsDeVie(degats);
            Console.WriteLine(this.nom + "(" + this.pointsDeVie + ")" + " attaque : " + uneEntite.nom);
            Console.WriteLine(uneEntite.nom + " a perdu " + degats + " points de vie");
            Console.WriteLine("Il reste " + uneEntite.pointsDeVie + " points de vie à " + uneEntite.nom);

            if(uneEntite.estMort)
            {
                Console.WriteLine(uneEntite.nom + "est mort");
            }
        }

        protected void PerdrePOintsDeVie(int pointsDeVie)
        {
            this.pointsDeVie -= pointsDeVie;

            if(this.pointsDeVie <= 0)
            {
                //on réinisialise à 0 pour pas avoir des points de vie negatif
                this.pointsDeVie = 0;
                estMort = true;
            }
        }

        public bool EstMort()
        {
            return this.estMort;
        }

    }
}
