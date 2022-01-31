using System;
using System.Collections.Generic;
using System.Text;

namespace tehtava7hissi
{
    class Hissi
    {
        private int kerros;


        public int Kerros
        {
            get => kerros;
            set
            { 
   

             if (value > 6)
                {
                    Console.WriteLine("Annettu kerros oli liian suuri.");
                    value = 6;

                }
                 else if (value< 1 )
                {
                    Console.WriteLine("Annetu kerros oli liian pieni.");
                    value = 1;

                }
                       Console.WriteLine("Kerros on asetettu. " + value);
                kerros = value;
            }

        }

       
    }
}
    

          
