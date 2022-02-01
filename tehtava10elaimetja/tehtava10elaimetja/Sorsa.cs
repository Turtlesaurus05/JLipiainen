using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava10elaimetja
{
    internal class Sorsa : Elain, icanswim, icanfly
    {
        public int SwimSpeed { get; set; }
        public int WingSize { get; set; }

        public Sorsa (string _name, int _wingSize, int _speed)
        {
            SwimSpeed = _speed;  
            WingSize = _wingSize; 
            Name = _name;

        }

        public void Fly()
        {
            Console.WriteLine(" {0} Lentää, Siipien koko on {1}.", Name, WingSize);
            Console.ReadLine();
        }

        public override void Makesound()
        {
            Console.WriteLine("Waak Waak");
           
        }

        public void Swim()
        {
            Console.WriteLine(" {0} ui, Nopeudella {1}", Name, SwimSpeed);
            Console.ReadLine();
        }
    }
}
