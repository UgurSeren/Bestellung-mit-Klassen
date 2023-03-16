using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Getraenke
    {
        private string name;
        private string zustand;

        public void SetName(string name)
        {
            this.name = name;
        }
        public String GetName()
        {
            return name;
        }
        public void SetZustand(string zustand)
        {
            this.zustand= zustand;
        }
        public string GetZustand()
        {
            return zustand;
        }



        
    }
}
