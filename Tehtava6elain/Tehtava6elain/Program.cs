using System;

namespace Tehtava6elain
{
    class Program
    {
        static void Main(string[] args)
        {

            Elain.KuinkaMonta();
                


            Koira koira1 = new Koira();
            koira1.Ääntele();


            Kissa kissa1 = new Kissa();
            kissa1.Ääntele();

            Koira.KuinkaMonta();

            Koira koira2 = new Koira();
            Koira koira3 = new Koira();

            Kissa kissa2 = new Kissa();

            Elain.KuinkaMonta();
            Kissa.KuinkaMonta();
            Elain.KuinkaMonta();
        }
    }
}
