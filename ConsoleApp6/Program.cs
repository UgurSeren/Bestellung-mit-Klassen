using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Program
    {
        static void Main(string[] args)
        {
           

            Fruechtetee fruechtetee1 = new Fruechtetee();

            fruechtetee1.SetSorte("Orange");
            fruechtetee1.SetZitrone(true);
            fruechtetee1.SetZucker(true);
            fruechtetee1.SetMilch(false);
            
            Gast gast1 = new Gast();
            gast1.SetTischnummer(1);

            gast1.SetTischTee(fruechtetee1);

            Kaffee kaffee1 = new Kaffee();
            kaffee1.SetName("Milch");

            Console.WriteLine(gast1.GetTeevonTisch().GetZitrone());
            gast1.SetKaffezuTisch(kaffee1);

            Gast gast2 = new Gast();
            gast2.SetKaffezuTisch(kaffee1);
            kaffee1.SetHerkunftsland("Brazilia");

            Console.WriteLine(gast2.GetKaffevonTisch().GetHerkunftsland());


            Console.ReadLine();




        }
    }
}
