using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Taajuus
    {
        private int kanava;


        public int Kanava
        {
            get => kanava;
            set
            {


                if (value > 107.9)
                {
                    Console.WriteLine("Annettu kanava oli liian suuri.");
                    value = (int)107.9;

                }
                else if (value< 88.0)
                {
                    Console.WriteLine("Annetu kanava oli liian pieni.");
                    value = (int)88.0;

                }
                Console.WriteLine("Kerros on asetettu. " + value);
                kanava = value;
            }
        }
    }
}
