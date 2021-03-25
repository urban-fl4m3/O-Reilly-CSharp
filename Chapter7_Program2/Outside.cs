namespace Chapter7_Program2
{
    class Outside : Location
    {
        public override string Description
        {
            get
            {
                string description = base.Description;

                if (hot)
                {
                    description += "Тут очень жарко.";
                }

                return description;
            }
        }

        private bool hot;

        public Outside(string name, bool hot) :base(name)
        {
            this.hot = hot;
        }
    }
}
