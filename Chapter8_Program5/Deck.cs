using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Chapter8_Program5
{
    class Deck
    {
        private List<Card> cards;
        private Random random = new Random();

        public Deck()
        {
            cards = new List<Card>();

            for (int suit = 0; suit < 4; suit++)
            {
                for (int value = 1; value < 14; value++)
                {
                    cards.Add(new Card((Suits)suit, (Values)value));
                }
            }
        }

        public Deck(IEnumerable<Card> initialCards)
        {
            cards = new List<Card>(initialCards);
        }

        public int Count { get { return cards.Count; } }

        public void Add(Card card)
        {
            cards.Add(card);
        }

        public Card Deal(int index)
        {
            Card card = cards[index];
            cards.RemoveAt(index);

            return card;
        }

        public void Shuffle()
        {
            cards.Sort(new CardComparer_byRandom(random));
        }

        public IEnumerable<string> GetCardNames()
        {
            List<string> cardNames = new List<string>();

            foreach(Card card in cards)
            {
                cardNames.Add(card.ToString());
            }

            return cardNames;
        }

        public void Sort()
        {
            cards.Sort(new CardComparer_bySuit());
        }
    }
}
