using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Eiskaffee: Kaffee
    {
        private int anzahlEiskugeln;
        private bool sahne;

        public void SetAnzahlEiskugeln(int i)
        {
            anzahlEiskugeln = i;
        }
        public int GetAnzahlEiskugeln()
        {
            return anzahlEiskugeln;
        }

        public void SetSahne(bool b)
        {
            sahne = b;  
        }
        public bool GetSahne()
        {
            return sahne;
        }

    }
}
