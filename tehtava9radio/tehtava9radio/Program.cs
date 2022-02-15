using System;

namespace tehtava9radio
{
    class Program
    {
        static void Main(string[] args)
        {
            Radio pakka = new Radio("Nimi ", false, 0, 88.0M);


            pakka.TulostaData();


            Console.WriteLine("Laitetaanko radio päälle? (Päälle tai Pois.) ");
           
            string luettoarvo = Console.ReadLine();
           
            {


                if (luettoarvo.ToUpper() == "PÄÄLLE")
                {
                    pakka.AsetaKerros();


                }
                else if (luettoarvo.ToUpper() == "POIS")
                {
                    pakka.AsetaKerros();

                }

                if (true)
                {
                    Console.WriteLine("Valitse radio kanava 88.0M ja 107.9M väliltä. " + luettoarvo);
                    pakka.AsetaKerros();

                }

            }
        }
    }
}