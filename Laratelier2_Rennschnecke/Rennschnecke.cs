using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Laratelier2_Rennschnecke
{
    internal class Rennschnecke
    {
        public String name;
	    public String rasse;
        public int vMax;
        private int _sekundenbisfertig = 0;
        public int sekundenbisfertig { get { return _sekundenbisfertig; } }


        public Rennschnecke(string name, string rasse, int vMax)
        {
            this.name = name;
            this.rasse = rasse;
            this.vMax = vMax;
           
             

        }

        public int checkkriechedauer(int strecke)
        {
            bool ab = true;
           
            do
            {
                _sekundenbisfertig++;
                strecke -= vMax;
                if (strecke <= 0)
                {
                    ab = false;
                }
            } while (ab == true);
            return _sekundenbisfertig;
        }


        public string getname()
        {
            return name;

        }
      
        public string getrasse()
        {
            return rasse;
        }

        public double getvMax()
        {
            return vMax;
        }
       

        public string toString()
        {
            return name + " " + rasse + " " + vMax;
           
        }



    }
}
