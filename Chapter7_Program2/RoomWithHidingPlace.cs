namespace Chapter7_Program2
{
    class RoomWithHidingPlace : Room, IHidingPlace
    {
        public string HidingLocation { get; private set; }
    
        public RoomWithHidingPlace(string name, string decoration, string hidingPlace) : base(name, decoration)
        {
            HidingLocation = hidingPlace;
        }

        public override string Description
        {
            get
            {
                return $"{base.Description} Спрятаться можно {HidingLocation}.";
            }
        }
    }
}
