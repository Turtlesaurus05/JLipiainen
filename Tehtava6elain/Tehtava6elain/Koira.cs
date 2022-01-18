using System;
using System.Collections.Generic;
using System.Text;

namespace Tehtava6elain
{
    class Koira : Elain
    {
        private static int instanssit = 0;
        public Koira()
        {
            instanssit++;
        }

        public static new void KuinkaMonta()
        {
            Console.WriteLine("Koiria luotu " + instanssit);
        }

        public override void Ääntele()
        {
            Console.WriteLine("Woof");
        }


    }
}
