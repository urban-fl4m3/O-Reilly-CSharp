namespace Chapter8_Program1
{
    class Card
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
    }
}
