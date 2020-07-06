using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple2
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancier un objet (le creer)

            Feu_de_signalisation Avroy = new Feu_de_signalisation();

            Console.WriteLine(Avroy.couleur);

            Feu_de_signalisation Sauveniere = new Feu_de_signalisation(3);

            Console.WriteLine(Sauveniere.position);

            Feu_de_signalisation Sohet = new Feu_de_signalisation(3, 5, 7);

            Console.WriteLine(Sohet.hauteur);

            Sohet.change();
            Sohet.change();
            Sohet.change();

            Sohet.clignote();
            Sohet.clignote(3);

            Console.ReadLine();
        }
    }
}

