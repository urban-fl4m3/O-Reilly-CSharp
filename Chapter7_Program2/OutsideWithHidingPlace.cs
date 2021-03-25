namespace Chapter7_Program2
{
    class OutsideWithHidingPlace : Outside, IHidingPlace
    {
        public string HidingLocation { get; private set; }

        public OutsideWithHidingPlace(string name, bool hot, string hidingPlace) : base(name, hot)
        {
            HidingLocation = hidingPlace;
        }

        public override string Description
        {
            get
            {
                return $"{base.Description} Можно спрятаться {HidingLocation}.";
            }
        }
    }
}
