using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter8_Program5
{
    public partial class Form1 : Form
    {
        private Deck deck1;
        private Deck deck2;
        private Random rand = new Random();

        public Form1()
        {
            InitializeComponent();

            ResetDeck(1);
            ResetDeck(2);
            RedrawDeck(1);
            RedrawDeck(2);
        }

        private void moveToDeck2_Click(object sender, EventArgs e)
        {
            Card card = deck1.Deal(listBox1.SelectedIndex);
            listBox1.Items.RemoveAt(listBox1.SelectedIndex);
            listBox2.Items.Add(card.ToString());
            deck2.Add(card);
        }

        private void moveToDeck1_Click(object sender, EventArgs e)
        {
            Card card = deck2.Deal(listBox2.SelectedIndex);
            listBox2.Items.RemoveAt(listBox2.SelectedIndex);
            listBox1.Items.Add(card.ToString());
            deck1.Add(card);
        }

        private void resetDeck1_Click(object sender, EventArgs e)
        {
            ResetDeck(1);
            RedrawDeck(1);
        }

        private void resetDeck2_Click(object sender, EventArgs e)
        {
            ResetDeck(2);
            RedrawDeck(2);
        }

        private void shuffle1_Click(object sender, EventArgs e)
        {
            deck1.Shuffle();
            RedrawDeck(1);
        }

        private void shuffle2_Click(object sender, EventArgs e)
        {
            deck2.Shuffle();
            RedrawDeck(2);
        }

        private void ResetDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                int count = rand.Next(1, 11);

                List<Card> randomCards = new List<Card>();

                for (int i = 0; i < count; i++)
                {
                    int suit = rand.Next(4);
                    int value = rand.Next(1, 14);

                    randomCards.Add(new Card((Suits)suit, (Values)value));
                }

                deck1 = new Deck(randomCards);
                deck1.Sort();
            }
            else
            {
                deck2 = new Deck();
            }
        }

        private void RedrawDeck(int deckNumber)
        {
            if (deckNumber == 1)
            {
                listBox1.Items.Clear();
                foreach (string cardName in deck1.GetCardNames())
                {
                    listBox1.Items.Add(cardName);
                }

                deck1Label.Text = $"Deck #1 ({deck1.Count} cards)";
            }
            else
            {
                listBox2.Items.Clear();
                foreach( string cardName in deck2.GetCardNames())
                {
                    listBox2.Items.Add(cardName);
                }

                deck2Label.Text = $"Deck #2 ({deck2.Count}) cards";
            }
        }
    }
}
