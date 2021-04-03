using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Chapter9_Program3
{
    public partial class Form1 : Form
    {
        private Random random = new Random();

        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Deck deckToWrite = RandomDeck(5);
            using (Stream output = File.Create("Deck1.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, deckToWrite);
            }

            DealCards(deckToWrite, "Что было записано в файл");
        }

        private void button2_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck1.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                Deck deckFromFile = (Deck)formatter.Deserialize(input);
                DealCards(deckFromFile, "Что было прочитано из файла");
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {

            using (Stream output = File.Create("Deck2.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                for (int i = 0; i < 5; i++)
                {
                    Deck deckToWrite = RandomDeck(random.Next(1, 10));
                    formatter.Serialize(output, deckToWrite);
                    DealCards(deckToWrite, $"Колода {i + 1} записана");
                }
            }

        }

        private void button4_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Deck2.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                for (int i = 0; i < 5; i++)
                {
                    Deck deckToRead = (Deck)formatter.Deserialize(input);
                    DealCards(deckToRead, $"Колода {i + 1} прочитана");
                }
            }
        }

        private Deck RandomDeck(int number)
        {
            Deck myDeck = new Deck(new Card[] { });
            for (int i = 0; i < number; i++)
            {
                myDeck.Add(new Card(
                    (Suits)random.Next(4),
                    (Values)random.Next(1, 14)));
            }

            return myDeck;
        }


        private void DealCards(Deck deckToDeal, string title)
        {
            Console.WriteLine(title);

            while (deckToDeal.Count > 0)
            {
                Card nextCard = deckToDeal.Deal();
                Console.WriteLine(nextCard.Name);
            }

            Console.WriteLine("-----------------");
        }
    }
}
