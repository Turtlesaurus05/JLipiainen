// See https://aka.ms/new-console-template for more information
using tehtava10elaimetja;
{
    Varis varis = new Varis("Varis", 90);

    varis.Makesound();
    varis.Fly();

    Kala ahven = new Kala("Ahven", 50, "Blurps");

    ahven.Makesound();
    ahven.Swim();

    Sorsa sorsa = new Sorsa("Sorsa", 90, 10);

    sorsa.Makesound();
    sorsa.Fly();
    sorsa.Makesound(); 
    sorsa.Swim();

}