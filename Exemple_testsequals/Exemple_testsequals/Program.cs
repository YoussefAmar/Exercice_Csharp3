using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_testsequals
{
    class Program
    {
        static void Main(string[] args)
        {

            O2 Objet2 = new O2(3);
            O1 Objet1 = new O1(10, Objet2);

            O2 AutreObjet2 = new O2(3);
            O1 EncoreObjet1 = new O1(10, AutreObjet2);


            O1 AutreObjet1 = Objet1;

            Console.WriteLine("Test de ==---------------------");

            //A conserver pour le test des référents

            Console.WriteLine("== - Tests de 2 objets qui occupent la même zone mémoire");
            Console.WriteLine(AutreObjet1 == Objet1);

            Console.WriteLine("== - Tests de 2 objets qui occupent des zones mémoire différentes mais ont les mêmes données");
            Console.WriteLine(AutreObjet1 == EncoreObjet1);

            Console.WriteLine("Test de Equal pour O2 ------------------");

            O2 Monique = new O2(7);

            Console.WriteLine("Test de 2 objets qui sont les mêmes mais avec des zones mémoires distinctes");
            Console.WriteLine(Objet2.Equals(AutreObjet2));

            Console.WriteLine("Test de 2 objets qui sont différents");
            Console.WriteLine(Objet2.Equals(Monique));

            Console.ReadLine();

        }
    }
}
