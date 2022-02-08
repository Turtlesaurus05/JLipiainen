using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace korttipakka
{
    internal class Card
    {
        private Suits clubs;
        private string s;

        public Card(Suits clubs, string s)
        {
            this.clubs = clubs;
            this.s = s;
        }

        public int value
        { get; set; }

        public int suite
        { get; set; }
    }

    internal abstract class Deck
    {
        public Card[] Cards
        { get; set; }

        public void ShuffleCards(int timesToShuffle)
        {
            Card temp;
            Random random = new Random();
            // int timesToShuffle = random.Next(300, 600); #Had it setup for random shuffle
            int cardToShuffle1, cardToShuffle2;

            for (int x = 0; x < timesToShuffle; x++)
            {
                cardToShuffle1 = random.Next(this.cards.Length);
                cardToShuffle2 = random.Next(this.cards.Length);
                temp = this.cards[cardToShuffle1];

                this.cards[cardToShuffle1] = this.cards[cardToShuffle2];
                this.cards[cardToShuffle2] = temp;
            }
        }
    }
}
