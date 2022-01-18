using System;
using System.Collections.Generic;

namespace tehtava4albumi
{
    class Program
    {
        static void Main(string[] args)
        {

            Albumi albumi1 = new Albumi();
            {
                
                albumi1.Nimi = "Thriller";
                albumi1.Artisti = "Michael Jackson";
                albumi1.Genre = "Pop, post-disco, funk, rock";
                albumi1.Hinta = "100$";                
                albumi1.TulostaKappaleet();
                albumi1.TulostaData();
                string albuminTiedot = albumi1.ToString();
              
             
            }
           
        }
    }
}

