using System;
using System.Collections.Generic;

namespace Zzzzzzz
{
    internal class Korttipakka
    {
        List<string> kortit = new List<string>();
        public Korttipakka()
        {
            Lisaakortit();
        }
         void Lisaakortit()
        {
            for (int i = 1; i < 14; i++)
            {
                
                kortit.Add("Ruutu - " + i);
                kortit.Add("Pata - " + i);
                kortit.Add("Hertta - " + i);
                kortit.Add("Risti - " + i);
             
            }
         
        }
        public void Tulosta()
        {
            //tulostaa otsikon tulostajalle.
            Console.WriteLine("kortit ");
            //forlooppi joka ajaa korttipakan kaikki oliot läpi.

            for (int i = 1; i < kortit.Count + 1; i++)
            {
                Console.WriteLine(i + ".Kortti on: " +  kortit[i - 1]);


            }

        }
       public void Sekoita()
        {
            Shuffle();
            Console.WriteLine("Korttipakka on sekoitettu ");
            Console.WriteLine();

        }
        void Shuffle()
        {
            Random rand = new Random();
            int n = kortit.Count;
            while (n > 1)
            {
                n--;
               int k = rand.Next(n + 1);
                string value = kortit[k];
                kortit[k] = kortit[n];
                kortit[n] = value;
            }
        }

    }
}

