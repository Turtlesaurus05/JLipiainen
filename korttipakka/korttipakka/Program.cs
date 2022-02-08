// See https://aka.ms/new-console-template for more information
using korttipakka;

class Program
{
    static void Main(string[] args)
    {
        Deck mydeck = new Deck();
        foreach (Card c in mydeck.Cards)
        {
            Console.WriteLine(c);
        }
        Console.WriteLine("How Many Times Do You Want To Shuffle?");

    }
}
