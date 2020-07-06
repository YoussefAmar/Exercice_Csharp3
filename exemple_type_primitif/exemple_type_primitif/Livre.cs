using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace exemple_type_primitif
{
    class Livre
    {
        public string auteur;
        public string titre;
        public int annee;


        //Constructeur
        public Livre(string auteur, string titre, int annee)
        {
            this.auteur = auteur;
            this.titre = titre;
            this.annee = annee;
        }

        public new void ToString()
        {
            Console.WriteLine("Infos du livre - {0} - {1} - {2}", auteur, titre, annee);
        }
    }
}
