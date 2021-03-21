namespace Chapter5_Program1
{
    class DinnerParty
    {
        public int NumberOfPeople { get; set; }
        public bool FancyDecorations { get; set; }
        public bool HealthyOptions { get; set; }
        public decimal Cost
        {
            get
            {
                decimal totalCost = CalculateCostOfDecorations() +
                    ((CalculateCostOfBeveragesPerson() + costOfFoodPerPerson) * NumberOfPeople);

                totalCost = HealthyOptions ? totalCost *= .95M : totalCost;
                return totalCost;
            }
        }

        private const int costOfFoodPerPerson = 25;

        public DinnerParty(int numberOfPeople, bool healthyOptions, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOptions = healthyOptions;
            FancyDecorations = fancyDecorations;
        }


        private decimal CalculateCostOfDecorations()
        {
            decimal costOfDecorations;
            
            if (FancyDecorations)
            {
                costOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                costOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }

            return costOfDecorations;
        }

        private decimal CalculateCostOfBeveragesPerson()
        {
            if (HealthyOptions)
            {
                return 5.00M;
            }
            else
            {
                return 20.00M;
            }
        }
    }
}
