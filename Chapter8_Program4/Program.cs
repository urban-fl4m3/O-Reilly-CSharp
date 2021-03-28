using System;
using System.Collections.Generic;

namespace Chapter8_Program4
{
    class Program
    {
        static void Main(string[] args)
        {
            Random rand = new Random();
            List<Card> randomCards = new List<Card>();

            for (int i = 0; i < 5; i++)
            {
                int numberBetween0and3 = rand.Next(4);
                int numberBetween1and13 = rand.Next(1, 14);

                Card card = new Card((Suits)numberBetween0and3, (Values)numberBetween1and13);
                randomCards.Add(card);
            }

            PrintCards(randomCards);

            Console.ReadKey();
        }

        private static void PrintCards(List<Card> cards)
        {
            foreach(Card card in cards)
            {
                Console.WriteLine($"Card: {card.Value} of {card.Suit}");
            }

            Console.WriteLine();
        }
    }
}
