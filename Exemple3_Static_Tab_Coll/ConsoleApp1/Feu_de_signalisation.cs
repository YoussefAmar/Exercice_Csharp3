using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Feu_de_signalisation
    {
        //Champ = variable au niveau de la classe
        //Attribut = etat d'un objet à un moment donné
        public int couleur = 0;
        public int position;
        public int hauteur;
        //ajout d'un attribut statique partage par tous les objets
        public static int NbFeu = 0;

        //Constructeur 
        //sans argument
        public Feu_de_signalisation()
        {
            couleur = 1;
            position = 45;
            hauteur = 7;
            Console.WriteLine("passage dans constructeur par défaut");
            //Mise à jour de l'attribut statique
            NbFeu++;
        }
        //surcharge du constructeur
        public Feu_de_signalisation(int couleur)
        {
            this.couleur = couleur;
            this.position = 45;
            this.hauteur = 7;
            Console.WriteLine("passage dans constructeur à un arg");
            //Mise à jour de l'attribut statique
            NbFeu++;
        }

        //surcharge du constructeur (3 arguments)
        //à utiliser dans le programme principal

        //constructeur avec une valeur par defaut
        public Feu_de_signalisation(int couleur, int position, int hauteur=3)
        {
            this.couleur = couleur;
            this.position = position;
            this.hauteur = hauteur;
            Console.WriteLine("passage dans constructeur à 3 arg - valeur par defaut");
            //Mise à jour de l'attribut statique
            NbFeu++;
        }

        //Méthodes
        //change
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
            if (couleur == 2)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.White;
            }
            if (couleur == 3)
            {
                Console.ForegroundColor = ConsoleColor.Magenta;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.White;
            }
        }
        public void clignote()
        {
            Console.WriteLine("Clignotant1");
            for (int i = 0; i < 2; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O");
            }

        }
        public void clignote(int a)
        { 
            Console.WriteLine("Clignotant2");
            for (int i = 0; i < a; i++)
            {
                Console.ForegroundColor = ConsoleColor.DarkYellow;
                Console.WriteLine("O");
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine("O");
            }

        }
        //couleur de fond de la console = BackgroundColor
        //couleur d'affichage = ForegroundColor
        //Positionner le curseur à un endroit déteminé = SetCursorPosition(num_colonne, num_ligne);

    }

}

