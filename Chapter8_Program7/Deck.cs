using System;
using System.Collections.Generic;

namespace Chapter8_Program7
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

        public Card Deal()
        {
            return Deal(0);
        }

        public bool ContainsValue(Values value)
        {
            foreach (Card card in cards)
            {
                if (card.Value == value)
                {
                    return true;
                }
            }

            return false;
        }

        public Deck PullOutValue(Values value)
        {
            Deck result = new Deck(new Card[] { });

            for (int i = cards.Count - 1; i >= 0; i--)
            {
                if (cards[i].Value == value)
                {
                    result.Add(Deal(i));
                }
            }

            return result;
        }

        public bool HasBook(Values value)
        {
            int numberOfCards = 0;

            foreach(Card card in cards)
            {
                if (card.Value == value)
                {
                    numberOfCards++;
                }
            }

            return numberOfCards == 4;
        }

        public Card Peek(int cardNumber)
        {
            return cards[cardNumber];
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

        public void SortByValue()
        {
            cards.Sort(new CardComparer_byValue());
        }

        public void SortBySuit()
        {
            cards.Sort(new CardComparer_bySuit());
        }
    }
}
