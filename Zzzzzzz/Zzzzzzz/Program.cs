using System;

namespace Zzzzzzz
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Korttipakka pakka = new Korttipakka();

            pakka.Tulosta();
            pakka.Sekoita();
            Console.WriteLine("Sekoitetaanko pakka uudelleen? K = Kyllä E = Ei. tai jos haluta lopettaa kirjoita LOPETA ");

            while (true)
            {
                string kirjoitasetus = Console.ReadLine();

                if (kirjoitasetus.ToUpper() == "K")
                {
                    pakka.Tulosta();
                    Console.WriteLine("Pakka sekoitettiin uudestaan. Sekoitetaanko uudestaan? K = Kyllä. E = Ei.  tai jos haluta lopettaa kirjoita LOPETA ");
                }
                else if (kirjoitasetus.ToUpper() == "LOPETA")
                {
                    break;
                }
                else
                {
                    Console.WriteLine("Pakkaa ei sekoitettu uudestaan. sekoittaatanko silti uudestaan?  K = Kyllä. E = Ei. tai jos haluat lopettaa kirjoita LOPETA ");
                }
            }
        }

    }
}

