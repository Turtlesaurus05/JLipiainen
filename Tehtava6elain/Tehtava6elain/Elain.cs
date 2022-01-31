using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtava6elain
{
    class Elain
    {
        //Eläin yliluokka
        public string Nimi { get; set; }

        private static int instanssit = 0  ;

        public Elain()
        {
            instanssit++;
        }

        public static void  KuinkaMonta()
        {
            Console.WriteLine("Eläiniä luotu " + instanssit);
        }

        public virtual void Ääntele()
        {
            Console.WriteLine("Eläin Ääntelee");
        }
    }
}
