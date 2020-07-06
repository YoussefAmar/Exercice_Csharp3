using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exemple_testsequals
{
    class O2
    {
        public int unAttributO2;

        public O2(int unAttributO2)
        {
            this.unAttributO2 = unAttributO2;
        }

        public override bool Equals(object obj)
        {
            if(this == obj)
            {
                return true;
            }
            else
            {
                O2 AutreObjet2 = obj as O2;
                if(obj != null)
                {
                    if (this.unAttributO2 == AutreObjet2.unAttributO2)

                        return true;
                    else

                        return false;

                }
            }

            return false;
        }


        public void setAttribut(int nouvelleValeur)
        {

        }
    }
}
