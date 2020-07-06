using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple2
{
    class Feu_de_signalisation
    {
        //Champ = variable au niveau de la classe
        //Attribut = état d'un objet à un moment donné

        public int couleur = 0;
        public int position;
        public int hauteur;

        //Constructeur
        //Sans argument

        public Feu_de_signalisation()
        {
            couleur = 1;
            position = 45;
            hauteur = 7;

            Console.WriteLine("Passage dans constructeur par défaut");
        }
        // Surcharge du constructeur (même nom pour les 2)
        public Feu_de_signalisation(int couleur)
        {

            this.couleur = couleur;
            this.position = 45;
            this.hauteur = 7;

            Console.WriteLine("Passage dans constructeur à un argument");

        }

        //Surchage du constructeur ( 3 arguments)
        //à utiliser dans le programme principal

        //Constructeur

        public Feu_de_signalisation(int couleur, int position, int hauteur)
        {
            this.couleur = couleur;
            this.position = position;
            this.hauteur = hauteur;

            Console.WriteLine("Passage dans constructeur à 3 arguments");

        }

        //Méthodes 
        //Change

        public void change()
        {
            couleur = couleur + 1;

            if (couleur == 4) couleur = 1;

            if (couleur == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;

                Console.WriteLine("O");

                Console.ForegroundColor = ConsoleColor.White;
            }

            if (couleur == 3)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;

                Console.WriteLine("O");

                Console.ForegroundColor = ConsoleColor.White;
            }

            if (couleur == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;

                Console.WriteLine("O");

                Console.ForegroundColor = ConsoleColor.White;
            }

        }

        public void clignote()
        {
            Console.WriteLine("Clignotant 1");

            for (int i = 0; i < 4; i++)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.DarkGreen;
                Console.WriteLine("O");
            }
        }

        public void clignote(int a)
        {
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine("Clignotant 2");

            for (int i = 0; i < a; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O");
            }
        }

        public int choisir()
        {
            int choix;

            Console.Write("Numero du feu : ");

            choix = Int32.Parse(Console.ReadLine());

            return (choix);

        }
       
    }
}
