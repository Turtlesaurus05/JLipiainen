using System;
using System.Collections.Generic;
using System.Text;

namespace tehtava9radio
{
    internal class Radio
    {
        public Radio(string _nimi, bool _on, int _ääni, decimal _taajuus)
        {
            Nimi = _nimi;
            Päällä = _on;
            Äänenvoimakkuus = _ääni;
            taajuus = _taajuus;
        }
        public string Nimi;
        bool Päällä;
        public decimal uusitaajus;
        public int uusivoimakkuus;
        private readonly int ÄänenvoimMax = 9;
        private readonly int ÄänenvoimMin = 0;
        private readonly decimal MaxTaajuus = 107.9M;
        private readonly decimal MinTaajuus = 88.0M;

        private decimal Taajuus { get; set; }
        private int Äänenvoimakkuus { get; set; }

        public decimal taajuus
        {
            get { return Taajuus; }
            set
            {
                
                if (value > MaxTaajuus)
                {
                    value = MaxTaajuus;
                }

                else if (value < MinTaajuus)
                {
                    value = MinTaajuus;
                }
                taajuus = value;
            }

        }
        public int äänenvoimakkuus
        {
            get { return Äänenvoimakkuus; }
            set
            {
                if (value > ÄänenvoimMax)
                {
                    value = ÄänenvoimMax;
                }

                else if (value < ÄänenvoimMin)
                {
                    value = ÄänenvoimMin;
                }
                Äänenvoimakkuus = value;
            }
        }

        public void Radiotila()
        {
            if (Päällä == true)
            {
                Päällä = false;
                Console.WriteLine("Radio on nyt pois päältä. ");
            }
            else if (Päällä == false)
            {
                Päällä = true;
                Console.WriteLine("Radio on nyt päällä ");
            }
        }
        public void RTaajuus()
        {
            string luettuarvo = Console.ReadLine();
            bool result = decimal.TryParse(luettuarvo, out uusitaajus);

            if (result)
            {
                uusitaajus = Taajuus;

            }
            else
            {
                Console.WriteLine("VIRHE! Annettu radio kanava oli virheellinen. ");
            }


        }
        public void RVoimakkuus()
        {
            string luettuarvo = Console.ReadLine();
            bool result = int.TryParse(luettuarvo, out uusivoimakkuus);

            if (result)
            {
                uusivoimakkuus = Äänenvoimakkuus;

            }
            else
            {
                Console.WriteLine("VIRHE! Volume taso oli virheellinen. ");
            }

        }

        public void Tulostadata()
        {
            if (Päällä == true)

            {
                Console.WriteLine("Radio on päällä ");
            }
            else if (Päällä == false)
            {
                Console.WriteLine("Radio ei ole päällä ");
            }
            Console.WriteLine("Radion taajus on {0}", Taajuus);
            Console.WriteLine("Radion äänenvoimakkuus on {0}");
        }


    }
}
