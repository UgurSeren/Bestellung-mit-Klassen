using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Espresso:Kaffee
    {
        private bool doppel;

        public void SetDoppel(bool b)
        {
            doppel = b;
        }
        public bool GetDoppel()
        {
            return doppel;
        }
    }

}
