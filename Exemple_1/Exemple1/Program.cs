using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp2
{
    class Program
    {
        static void Main(string[] args)
        {
            int taille;
            float pideal;

            Console.WriteLine("Encoder votre taille en cm : ");
            taille = Int32.Parse(Console.ReadLine());
            pideal = 50 + (float)3 * (taille - 150) / 4;

            Console.WriteLine("Poids ideal : ");
            Console.WriteLine("Homme : " + pideal + " kg");
            Console.WriteLine("Femme : " + 0.9 * pideal + " kg");
            Console.ReadLine();

            //appel de fonction

            int poids;
            Console.WriteLine("Encoder votre poids en kg : ");
            poids = Int32.Parse(Console.ReadLine());
            float imc = calcul_imc(poids, taille);
            Console.WriteLine("imc : " + imc.ToString());

            //fonction imc

            float calcul_imc(int p, int t)
            {
                float carre = ((float)t / (float)100 * (float)t / (float)100);
                float temp = (float)p / carre;
                return (temp);
            }
            Console.ReadLine();

        }
    }
}
