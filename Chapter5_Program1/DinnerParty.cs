namespace Chapter5_Program1
{
    class DinnerParty : Party
    {
        public bool HealthyOptions { get; set; }

        public override decimal Cost
        {
            get
            {
                decimal totalCost = base.Cost;
                totalCost += CalculateCostOfBeveragesPerson() * NumberOfPeople;

                totalCost = HealthyOptions ? totalCost *= .95M : totalCost;
                return totalCost;
            }
        }

        public DinnerParty(int numberOfPeople, bool healthyOptions, bool fancyDecorations)
        {
            NumberOfPeople = numberOfPeople;
            HealthyOptions = healthyOptions;
            FancyDecorations = fancyDecorations;
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
