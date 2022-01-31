using System;

namespace tehtava8tyontekijapomo
{
    class Program
    {
        static void Main(string[] args)
        {
            Tyontekija.KuinkaMonta();



            Henkilo henkilo1 = new Henkilo(42, 5000, "Pekka Feikkinen");
            henkilo1.Ääntele();

            

           

            Pomo pomo2 = new Pomo(42, 5000, "Pekka Feikkinen", "Skoda octavia", 500);
            Pomo.KuinkaMonta();
            Tyontekija.KuinkaMonta();
            Henkilo.KuinkaMonta();
            Tyontekija.KuinkaMonta();

        }
    }
}
