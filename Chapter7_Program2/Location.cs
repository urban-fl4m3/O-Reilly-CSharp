namespace Chapter7_Program2
{
    public abstract class Location
    {
        public string Name { get; private set; }
        public Location[] Exits;

        public virtual string Description
        {
            get
            {
                string description = $"Вы находитесь в {Name}" +
                    $". Вы видете двери, ведущие в: ";

                for (int i = 0; i < Exits.Length; i++)
                {
                    description += $" \"{Exits[i].Name}\"";
                    if (i != Exits.Length - 1)
                    {
                        description += ",";
                    }
                }

                return description;

            }
        }


        public Location(string name)
        {
            Name = name;
        }
    }
}
