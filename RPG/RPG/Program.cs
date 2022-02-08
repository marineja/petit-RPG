﻿using System;

namespace RPG
{
    class Program
    {
        static void Main(string[] args)
        {
            Menu();
        }

        static void Jouer(Personnage monPerso)
        {
            Monstre monstre = new Monstre("Loup enragé");
            bool victoire = true;
            bool suivant = false;

            //tant que notre montre n'est pas mort
            while(!monstre.EstMort())
            {

                //tour du monstre
                Console.ForegroundColor = ConsoleColor.Red;
                monstre.Attaquer(monPerso);
                Console.WriteLine();
                Console.ReadKey(true);

                //verification que le personnage est encore en vie
                if(monPerso.EstMort())
                {
                    victoire = false;
                    //interompre la boucle while
                    break;
                }


                //tour du personnage
                Console.ForegroundColor = ConsoleColor.Green;
                monPerso.Attaquer(monstre);
                Console.WriteLine();
                Console.ReadKey(true);

                //si on gagne
                if(victoire)
                {
                    monPerso.gagnierExperience(5);

                    Console.ForegroundColor = ConsoleColor.Blue;
                    Console.WriteLine();
                    Console.WriteLine(monPerso.Caracteristiques());

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.WriteLine();

                    //tant que l'utilisateur continue de jouer
                    while(!suivant)
                    {
                        Console.WriteLine("Salle suivante ? (O/N");
                        //on enregistre la saisie
                        string saisie = Console.ReadLine().ToUpper();
                        if(saisie == "O")
                        {
                            suivant = true;
                            Jouer(monPerso);
                        }
                        else if(saisie == "N")
                        {

                            //on quite
                            Environment.Exit(0);
                        }
                    }

                }
                else
                {
                    Console.ForegroundColor = ConsoleColor.DarkRed;
                    Console.WriteLine();
                    Console.WriteLine("C'est perdu...");
                    Console.ReadKey();
                }
            }

        }

        static void Menu()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine("Bienvenue sur ce petit RPG!");
            Console.WriteLine();
            Console.WriteLine("Choisis ta classe : ");
            Console.WriteLine("1. Guerrier");
            Console.WriteLine("2. Sorcier");
            Console.WriteLine("3. Archer");
            Console.WriteLine("4. Quitter");
            Console.WriteLine();

            switch (Console.ReadLine())
            {
                case "1":
                    Console.WriteLine("Vous avez choisis Guerrier !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Pentinimax"));
                    break;
                case "2":
                    Console.WriteLine("Vous avez choisis Sorcier !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Pentinimax"));
                    break;
                case "3":
                    Console.WriteLine("Vous avez choisis Archer !");
                    Console.WriteLine();
                    Jouer(new Guerrier("Pentinimax"));
                    break;
                case "4":
                    break;
            }

        }
    }
}
