using System;

namespace tehtava2olio
{
         class Program
        {
            static void Main(string[] args)
            {
                Class1 opiskelijat = new Class1("Matti", "TVT1234", 0);

                opiskelijat.TulostaData();

                opiskelijat.MuokkaaOpintopisteitä(5);
                opiskelijat.TulostaData();

            }
        }
    }