using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace tehtava10elaimetja
{
    internal class Kala : Elain, icanswim
    {
        public int SwimSpeed { get; set; }
        public string Sound { get; set; }

        public Kala(string _name, int _speed, string _sound)
        {
            SwimSpeed = _speed; 
            Sound = _sound;
            Name = _name;

        }

        public override void Makesound()
        {
            Console.WriteLine(Sound);
        }

        public void Swim()
        {
            Console.WriteLine(" {0} ui, Nopeudella {1}",Name, SwimSpeed);
            Console.ReadLine();
        }
    }
}
