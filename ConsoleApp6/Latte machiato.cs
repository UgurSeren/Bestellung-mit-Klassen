using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Latte_machiato: Kaffee
    {
        private double milchanteil;
        private bool milchschaum;

        public void SetMilchanteil(double d)
        {
            milchanteil = d;
        }
        public double GetMilchanteil()
        {
            return milchanteil;
        }
        public void SetMilchschaum(bool b)
        {
            this.milchschaum = b;
        }
        public bool GetMilchschaum()
        {
            return this.milchschaum;
        }
    }
}
