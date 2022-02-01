using System;
using System.Collections.Generic;
using System.Text;

namespace ConsoleApp2
{
    class Radio
    {




        private string Paallepois { get; set; }
        private int Taajuus { get; set; }
        private int Volume { get; set; }

        public Radio(string _Paallepois, int _Taajuus, int _volume)
        {
            Volume = _volume;
        }

        public Radio()
        {
        }

        public void onOFF()

            {
                Console.WriteLine("Laitetaanko Radio päälle? Y = päälle/N = ei päälle");
                Paallepois = Console.ReadLine();
                if (Paallepois == "Y")
                {
                    Console.WriteLine("Radio on nyt päällä!");

                }
                else
                {
                    Console.WriteLine("Radiota ei laitettu päälle.");

                }
            }
            public void TulostaData()
            {
                if (Paallepois == "Y")
                {

                }
            }

        }
    }


