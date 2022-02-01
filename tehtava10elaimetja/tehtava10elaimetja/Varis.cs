using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava10elaimetja
{
    internal class Varis : Elain, icanfly
    {
        public int WingSize { get; set; }

        public Varis(string _name, int  _wingSize)
        {
            Name = _name;
            WingSize = _wingSize;

        }

        public void Fly()
        {
            Console.WriteLine(" {0} Lentää, Siipien koko on {1}.", Name, WingSize);
            Console.ReadLine();
        }

        public override void Makesound()
        {
            Console.WriteLine("Kakaaw Kakaaw");

             }        
      
    
    
        }
    }

