namespace Chapter8_Program6
{
    class JerseyNumber
    {
        public string Player { get; private set; }
        public int YearRetired { get; private set; }

        public JerseyNumber(string player, int numberRetired)
        {
            Player = player;
            YearRetired = numberRetired;
        }
    }
}
