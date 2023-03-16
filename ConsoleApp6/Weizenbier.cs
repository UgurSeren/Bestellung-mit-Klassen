using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Weizenbier: Bier
    {
        private double weizenmalzgehalt;
        public void SetWeizenmalzgehalt(double d)
        {
            this.weizenmalzgehalt = d;
        }
        public double GetWeizenmalzgehalt()
        {
            return this.weizenmalzgehalt;
        }
    }
}
