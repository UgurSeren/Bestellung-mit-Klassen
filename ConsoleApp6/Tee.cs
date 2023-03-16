using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp6
{
    internal class Tee: Getraenke
    {
        private bool zucker;
        private bool zitrone;
        private bool milch;
        private int ziehzeit;
        
        public void SetZucker(bool b)
        {
            this.zucker = b;

            if (this.zucker==true)
            {
                Console.WriteLine(" Wie viel Löffeln möchten sie haben");
                int a= Convert.ToInt32(Console.ReadLine());
                switch (a)
                {
                    case 0: Console.WriteLine(" Ohne Zucker");

                        break;
                    case 1: Console.WriteLine("1 Löffeln hinzugefügt");
                        break;
                    case 2:
                        Console.WriteLine("2 Löffeln hinzugefügt");
                        break;


                }
            }
        }
        public bool GetZucker()
        {
            return this.zucker;
        }
        public void SetZitrone(bool b)
        {
            this.zitrone= b;
        }
        public bool GetZitrone()
        {
            return this.zitrone;
        }
        public void SetMilch(bool b)
        {
            this.milch = b;
        }
        public bool GetMilch()
        {
            return this.milch;
        }
        public void SetZiehzeit(int i)
        {
            this.ziehzeit= i;
        }
        public int GetZiehzeit()
        {
            return ziehzeit;
        }

       
    }
}
