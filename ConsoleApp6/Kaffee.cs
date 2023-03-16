using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Kaffee: Getraenke
    {   

        private double koffeingehalt;
        private string Herkunftsland;
        private string bohnensorte;

        public void SetKoffeingehalt(double d)
        {
            this.koffeingehalt = d;

        }
        public double GetKoffeingehalt()
        {
            return this.koffeingehalt;
        }
        public void SetHerkunftsland(string s)
        {
            this.Herkunftsland = s;
        }
        public string GetHerkunftsland()
        { return this.Herkunftsland; }
        
        public void SetBohnensorte(string s)
        {
            this.bohnensorte = s;
        }
        public string GetBohnensorte()
        {
            return this.bohnensorte;
        }
    }
}
