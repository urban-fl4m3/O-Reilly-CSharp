namespace Chapter5_Program1
{
    class BirthdayParty
    {
        public const int CostOfFoodPerPerson = 25;
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public string CakeWriting { get; set; }

        //page 264
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations();
                totalCost += CostOfFoodPerPerson * NumberOfPeople;
                decimal cakeCost;
                if (CakeSize() == 8)
                {
                    cakeCost = 40M + ActualLength * .25M;
                }
                else
                {
                    cakeCost = 75M + ActualLength * .25M;
                }

                return totalCost + cakeCost;
            }
        }
        public bool CakeWritingTooLong
        {
            get
            {
                return CakeWriting.Length > MaxWritingLength();
            }
        }

        private int ActualLength
        {
            get
            {
                if (CakeWriting.Length > MaxWritingLength())
                {
                    return MaxWritingLength();
                }
                else
                {
                    return CakeWriting.Length;
                }
            }
        }

        public BirthdayParty(int numberOfPeople, bool fancyDecorations, string cakeWriting)
        {
            NumberOfPeople = numberOfPeople;
            FancyDecorations = fancyDecorations;
            CakeWriting = cakeWriting;
        }

        private int CakeSize()
        {
            if (NumberOfPeople <= 4)
            {
                return 8;
            }
            else
            {
                return 16;
            }
        }

        private int MaxWritingLength()
        {
            if (CakeSize() == 8)
            {
                return 16;
            }
            else
            {
                return 40;
            }
        }

        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.0M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }

            return costOfDecorations;
        }
    }
}
