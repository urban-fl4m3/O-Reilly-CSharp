namespace Chapter5_Program1
{
    class DinnerParty
    {
        public const int CostOfFoodPerPerson = 25;

        private int NumberOfPeople;
        decimal CostOfBeveragesPerPerson;
        decimal CostOfDecorations;
    
        public void SetPartyOptions(int people, bool fancy)
        {
            NumberOfPeople = people;
            CalculateCostOfDecorations(fancy);
        }

        public int GetNumberOfPeople()
        {
            return NumberOfPeople;
        }

        public void SetHealthyOptions(bool option)
        {
            if (option)
            {
                CostOfBeveragesPerPerson = 5.00M;
            }
            else
            {
                CostOfBeveragesPerPerson = 20.00M;
            }
        }

        public void CalculateCostOfDecorations(bool option)
        {
            if (option)
            {
                CostOfDecorations = (NumberOfPeople * 15.00M) + 50M;
            }
            else
            {
                CostOfDecorations = (NumberOfPeople * 7.50M) + 30M;
            }
        }

        public decimal CalculateCost(bool option)
        {
            decimal totalCost = CostOfDecorations +
                ((CostOfBeveragesPerPerson + CostOfFoodPerPerson) * NumberOfPeople);

            totalCost = option ? totalCost *= .95M : totalCost;
            return totalCost;
        }
    }
}
