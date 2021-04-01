using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter8_Program7
{
    class Player
    {
        private string name;
        public string Name { get { return name; } }

        private Random random;
        private Deck cards;
        private TextBox textBoxOnForm;
        
        public int CardCount { get { return cards.Count; } }
       
        public Player(string name, Random random, TextBox textBoxOnForm)
        {
            this.name = name;
            this.random = random;
            this.textBoxOnForm = textBoxOnForm;
            cards = new Deck(new Card[] { });

            textBoxOnForm.Text += $"{name} has just joined the game\r\n";
        }

        public IEnumerable<Values> PullOutBooks()
        {
            List<Values> books = new List<Values>();

            for (int i = 1; i < 14; i++)
            {
                Values value = (Values)i;
                int howMany = 0;
                for (int card = 0; card < cards.Count; card++)
                {
                    if (cards.Peek(card).Value == value)
                    {
                        howMany++;
                    }
                }

                if (howMany == 4)
                {
                    books.Add(value);
                    cards.PullOutValue(value);
                }
            }

            return books;
        }

        public Values GetRandomValue()
        {
            int randomCardIndex = random.Next(cards.Count);
            return cards.Peek(randomCardIndex).Value;
        }

        public Deck DoYouHaveAny(Values values)
        {
            Deck valuesDeck = cards.PullOutValue(values);
            textBoxOnForm.Text += $"{name} has {valuesDeck.Count} {Card.Plural(values)}\r\n";

            return valuesDeck;
        }

        public void AskForACard(IEnumerable<Player> players, int myIndex, Deck stock)
        {
            if (stock.Count > 0)
            {
                if (cards.Count == 0)
                {
                    cards.Add(stock.Deal());
                }
            }

            AskForACard(players, myIndex, stock, GetRandomValue());
        }

        public void AskForACard(IEnumerable<Player> players, int myIndex, Deck stock, Values value)
        {
            textBoxOnForm.Text += $"{name} asks if anyone has a {value}\r\n";

            int addedCards = 0;

            int playerIndex = 0;
            foreach (Player player in players)
            {
                if (playerIndex == myIndex) continue;

                Deck playerStock = player.DoYouHaveAny(value);
                addedCards += playerStock.Count;

                while (playerStock.Count > 0)
                {
                    cards.Add(playerStock.Deal());
                }

                playerIndex++;
            }

            if (addedCards == 0)
            {
                textBoxOnForm.Text += ($"{name} has to draw from the stock\r\n");
                TakeCard(stock.Deal());
            }
        }

        public void TakeCard(Card card)
        {
            cards.Add(card);
        }

        public IEnumerable<string> GetCardNames()
        {
            return cards.GetCardNames();
        }

        public Card Peek(int cardNumber)
        {
            return cards.Peek(cardNumber);
        }

        public void SortHand()
        {
            cards.SortByValue();
        }
    }
}
