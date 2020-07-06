using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_type_primitif
{
    class Program
    {
        static void Main(string[] args)
        {
            //Test sur les types primitifs
            var x = 5;
            var y = x;
            y = 8;

            Console.WriteLine("Type primitif :");
            Console.WriteLine("var x : " + x.ToString());
            Console.WriteLine("var y : " + y.ToString());
            Console.WriteLine();

            //Test sur les objets

            Livre JFille = new Livre("Brin", "La jeune fille et les clones", 2001);
            Livre MachinesEsprit = JFille;
            MachinesEsprit.auteur = "Silverberg";

            Console.WriteLine("Objet : ");
            Console.WriteLine("JFille :" + JFille.auteur);
            Console.WriteLine("MachinesEsprit : " + MachinesEsprit.auteur);
            Console.WriteLine();

            //Transimision dans une fonction
            //Déconseillé (ceci devrait être fait par une méthode de la classe
            //mais pour monter que le passage des objets se fait par valeur

            void ModifieAnnee(Livre lv, int newannee)
            {
                lv.annee = newannee;
            }

            Livre Elevation = new Livre("David Brin", "Elevation", 1980);
            Elevation.ToString();

            ModifieAnnee(Elevation, 1987);
            Elevation.ToString();

            Console.ReadLine();
        }
    }
}
