namespace Chapter8_Program7
{
    partial class Card
    {
        public static string Plural(Values value)
        {
            if (value == Values.Six)
            {
                return "Sixes";
            }
            else
            {
                return $"{value}s";
            }
        }
    }
}
