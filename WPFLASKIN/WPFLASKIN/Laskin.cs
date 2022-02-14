using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WPFLASKIN
{
    static class Laskin // Tämä luokka sisältää kaikki metodit joita käytetään itse laskimessa.
    {
        public static float Summa(float a, float b) 
        {
            return a + b;
        }

        public static float Erotus(float a, float b)
        {
            return a - b;
        }

        public static float Kertolasku(float a, float b)
        {
            return a * b;
        }

        public static float Jakolasku(float a, float b)
        {
            return a / b;
        }
    }
}
