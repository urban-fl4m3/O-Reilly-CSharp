namespace Chapter6_Program3
{
    class Bee
    {
        public const double HoneyUnitsConsumedPerMg = .25d;
    
        public double WeightMg { get; private set; }

        public Bee(double weightMg)
        {
            WeightMg = weightMg;
        }

        public virtual double HoneyConsumptionRate()
        {
            return WeightMg * HoneyUnitsConsumedPerMg;
        }
    }
}
