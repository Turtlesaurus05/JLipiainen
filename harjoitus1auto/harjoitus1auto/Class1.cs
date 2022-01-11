using System;
using System.Collections.Generic;
using System.Text;

namespace harjoitus1auto
{
   
       class Ajoneuvo

    {

        public string Nimi { get; set; }
        public int Nopeus { get; set; }
        public int Renkaat { get; set; }

        public void Tulostadata()
        {
            Console.WriteLine("Ajoneuvo: ");
            Console.WriteLine("-- Nimi: " + Nimi);
            Console.WriteLine("-- Nopeus: " + Nopeus);
            Console.WriteLine("-- Renkaat: " + Renkaat);
        }
        // public string ToString()
        //{
        //  }
    }
}

