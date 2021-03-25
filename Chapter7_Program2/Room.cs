namespace Chapter7_Program2
{
    public class Room : Location
    {
        public override string Description
        {
            get
            {
                return base.Description + $" Здесь вы видите {decoration}";
            }
        }

        private string decoration;

        public Room(string name, string decoration) : base(name)
        {
            this.decoration = decoration;
        }
    }
}
