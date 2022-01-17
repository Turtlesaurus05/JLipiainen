using System;

namespace ConsoleApp1
{
    class Kiuas
    {
        private string v1;
        private int v2;
        string kiukaantila;


        private string Merkki { get; set; }
        private int Lämpötila { get; set; }
        private int Kosteus { get; set; }

        public Kiuas(string _Merkki, int _Lämpötila, int _Kosteus, string _kiukaantila)
        {
            Merkki = _Merkki;
            Lämpötila = _Lämpötila;
            Kosteus = _Kosteus;
            kiukaantila = _kiukaantila;

        }

        public Kiuas(string v1, int v2)
        {
            this.v1 = v1;
            this.v2 = v2;
        }
         public void onOFF()

        {
            Console.WriteLine("Laitetaanko kiuas päälle? Y = päälle/N = ei päälle");
            kiukaantila = Console.ReadLine();
            if (kiukaantila == "Y")
            {
                Console.WriteLine("Kiuas on nyt päällä!");
               
            }
            else 
            {
                Console.WriteLine("Kiuasta ei laitettu päälle.");

            }
        }
        public void TulostaData()
        {
            if (kiukaantila == "Y")
            {
                Console.WriteLine("Ilman kosteus on: " + Kosteus);
                Console.WriteLine("Saunan lämpötila on " + Lämpötila);
                Console.WriteLine("");
            }
                
               // Console.WriteLine("Kiuas: ");
               // Console.WriteLine("--Merkki: " + Merkki);
               // Console.WriteLine("--Lämpötila:" + Lämpötila);
               //
               //Console.WriteLine("--Kosteus: " + Kosteus)
            }
            public void MuokkaaLämpötilaa(int i)
            {
                Lämpötila += i;
                if (Lämpötila < 0)
                {
                    Lämpötila = 0;
                }
            }
        public void MuokkaaKosteutta(int i)
            {
                Lämpötila += i;
                if (Kosteus < 0)
                {
                    Kosteus = 0;
                }
            }

        }
    }


    

