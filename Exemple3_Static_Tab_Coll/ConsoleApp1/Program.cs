using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;

namespace ConsoleApp1
{
    class Program
    {
        static void Main(string[] args)
        {
            //instancier un objet
            Feu_de_signalisation Avroy = new Feu_de_signalisation();
            Console.WriteLine(Avroy.couleur);
            Avroy.clignote();
            Console.WriteLine("NbFeux : " + Feu_de_signalisation.NbFeu);

            Feu_de_signalisation Sauveniere = new Feu_de_signalisation(3);
            Console.WriteLine(Sauveniere.position);
            Sauveniere.clignote(10);
            Console.WriteLine("NbFeux : " + Feu_de_signalisation.NbFeu);

            Feu_de_signalisation Sohet = new Feu_de_signalisation(3,5);
            Console.WriteLine(Sohet.hauteur);
            Console.WriteLine("NbFeux : " + Feu_de_signalisation.NbFeu);

            //creation d un tableau de feux
            Console.WriteLine("creation et utilisation d un tableau");
            
            Feu_de_signalisation[] Feux_Liege = new Feu_de_signalisation[3];

            Feux_Liege[0] = Avroy;
            Feux_Liege[1] = Sauveniere;
            Feux_Liege[2] = Sohet;

            for (int i = 0; i <= 2; i++)
            {
                    Feux_Liege[i].change();
            }

            //creation d'une ArrayList (attention ajouter un using : System.Collections)
            Console.WriteLine("creation et utilisation d une ArrayList");

            ArrayList FeuxLiege2 = new ArrayList();
            FeuxLiege2.Add(Avroy);
            FeuxLiege2.Add(Sauveniere);
            FeuxLiege2.Add(Sohet);

            foreach (Feu_de_signalisation element in Feux_Liege)
            {
                element.clignote();
            }

            // Utilisation d une methode statique de la classe math
            double x = Math.Sqrt(81);
            Console.WriteLine("resultat racine 81 : " + x.ToString());
            Console.WriteLine("Max de hauteur : " + Math.Max(Sauveniere.hauteur, Avroy.hauteur).ToString());

            Console.ReadLine();
            

        }
    }
}
