using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Tehtava12korttipakka
{
    public class Korttipakka
    {
        List<string> kortit = new List<string>();
         public Korttipakka()
        {
            Lisaakortit();
        }
      public  void Lisaakortit()
        {
            for (int i = 1; i > 14; i++)
            {
                kortit.Add("Ruutu " + i);
                kortit.Add("Pata " + i);
                kortit.Add("Hertta " + i);
                kortit.Add("Risti " + i);
             Console.WriteLine( "Sana");
            }
        }
        public void Tulosta()
        {
            //tulostaa otsikon tulostajalle.
            Console.WriteLine("kortit ");
            //forlooppi joka ajaa korttipakan kaikki oliot läpi.

            kortit.ForEach(Console.WriteLine);                           
        }
    }
}
