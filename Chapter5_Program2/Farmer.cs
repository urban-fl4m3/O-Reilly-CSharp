namespace Chapter5_Program2
{
    class Farmer
    {
        public int FeedMultiplier { get { return feedMultiplier; } }
        public int BagsOfFeed { get; private set; }
        private int feedMultiplier;

        private int numberOfCows;
        public int NumberOfCows
        {
            get
            {
                return numberOfCows;
            }
            set
            {
                numberOfCows = value;
                BagsOfFeed = numberOfCows * FeedMultiplier;
            }
        }
    }
}
