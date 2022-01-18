using System;
using System.Collections.Generic;
using System.Text;

namespace tehtava4albumi
{
    class Albumi

    {

        public string Artisti { get; set; }
        public string Nimi { get; set; }
        public string Genre { get; set; }
        public string Hinta { get; set; }
        public string Kappaleet { get; set; }


      
      


        List<string> PriceList = new List<string>(5);

        public void TulostaKappaleet()
        {

            PriceList.Add("---The girl is mine");
            PriceList.Add("---Thriller");
            PriceList.Add("---Billie jean");
            PriceList.Add("---Beat it");
            PriceList.Add("---Human Nature");
        }
        

        public void TulostaData()
        {
            Console.WriteLine("Albumi: ");
            Console.WriteLine("--- Artisti:" + Artisti);
            Console.WriteLine("--- Genre: " + Genre);
            Console.WriteLine("--- Hinta: " + Hinta);
            Console.WriteLine("--- Nimi: " + Nimi);
            Console.WriteLine("--- Kappaleet: " + Kappaleet);
            PriceList.Sort();
            PriceList.ForEach(Console.WriteLine);


        }


}
    }

