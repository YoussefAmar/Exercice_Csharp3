using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_exception1
{
    class Program
    {
        class MonException : Exception
        {
            public MonException(string message) : base(message)
            {
                Console.WriteLine("Mon exception personnel");
            }
        }

        static void Main(string[] args)
        {
            int a, b, c;

            a = 1;
            b = 2;
            c = 0;

            for (int i = 0; i < 10; i++)
            { a++; b *= 2; c = a + b; }

            /*
            int i;

            try
            {
                Console.WriteLine("Un nombre : ");
                i = int.Parse(Console.ReadLine());
                if (i < 0) throw new MonException("Que des entiers positifs !");
            }
            catch (OverflowException)
            {
                Console.WriteLine("Nombre hors limite");
            }
            catch(FormatException e)
            {
                Console.WriteLine(e.ToString());
                Console.WriteLine("Pas de lettre");
            }
            finally
            {
                Console.WriteLine("Je passe dans le finally dans tout les cas");

                Console.ReadLine();
            }
            */
        }
    }
}
