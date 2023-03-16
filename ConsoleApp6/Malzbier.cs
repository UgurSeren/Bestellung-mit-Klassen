using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Malzbier: Bier
    {
        private int stammwuerzegehalt;

        public void SetStammwuerzegehalt(int i)
        {
            this.stammwuerzegehalt = i;
        }
        public int GetStammwuerzegehalt()
        {
            return this.stammwuerzegehalt;
        }
    }
}
