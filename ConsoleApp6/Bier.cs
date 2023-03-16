using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Bier : Getraenke
    {
        private string hopfensorte;  
        private string hefesorte;
        private double alkoholgehalt;

        public void SetHopfensorte(string s)
        {
            hopfensorte = s;
        }
        public string GetHopfensorte()
        {
            return hopfensorte;
        }

        public void SetHefesorte(string s)
        {
            hefesorte = s;
        }
        public string GetHefesorte()
        {
            return hefesorte;
        }

        public void SetAlkoholgehalt(double d)
        {
            alkoholgehalt = d;
        }
        public double GetAlhokolgehalt()
        {
            return alkoholgehalt;   
        }

    }
}
