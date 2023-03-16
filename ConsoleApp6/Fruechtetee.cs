using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Fruechtetee: Tee
    {
        private string sorte;

        public void SetSorte(string s)
        {
            this.sorte = s;
        }
        public string GetSorte()
        {
            return sorte;
        }
    }
}
