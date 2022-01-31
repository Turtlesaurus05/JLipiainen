using System;

namespace tehtava7hissi
{
    class Program
    {
        static void Main(string[] args)
        {
            int uusikerros;

            Console.WriteLine("Kerros jonne haluat.");
            Hissi hissi = new Hissi();
            Console.WriteLine("Kerros luotu, Jatka kirjoittamalla Jatka.");

            while (true)
            {
                Console.WriteLine("Kirjoita uusi kerros (1-6) > ");
                string luettuarvo = Console.ReadLine();

                if (luettuarvo.Equals("Sammuta"))
                {
                    break;
                }
                bool result = int.TryParse(luettuarvo, out uusikerros);

                if (result)
                {
                    hissi.Kerros = uusikerros;

                }
                else
                {
                    Console.WriteLine("VIRHE! Annettu kerros on virheellinen. Koita syöttää uusi kerros.");
                }
            }
            Console.WriteLine("Olet poistunut nyt hissistä.");
          
        }
    }
}
