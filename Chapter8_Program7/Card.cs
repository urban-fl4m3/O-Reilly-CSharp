﻿namespace Chapter8_Program7
{
    enum Suits
    {
        Spades = 0,
        Clubs = 1,
        Diamonds = 2,
        Hearts = 3
    }

    enum Values
    {
        Ace = 1,
        Two = 2,
        Three = 3,
        Four = 4,
        Five = 5,
        Six = 6,
        Seven = 7,
        Eight = 8,
        Nine = 9,
        Ten = 10,
        Jack = 11,
        Queen = 12,
        King = 13
    }

    partial class Card
    {
        public Suits Suit { get; }
        public Values Value { get; }
        public string Name
        {
            get
            {
                return $"{Value} of {Suit}";
            }
        }

        public Card(Suits suit, Values value)
        {
            Suit = suit;
            Value = value;
        }

        public override string ToString()
        {
            return Name;
        }
    }
}
