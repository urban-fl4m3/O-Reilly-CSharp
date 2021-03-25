namespace Chapter7_Program2
{
    class RoomWithDoor : RoomWithHidingPlace, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }
    
        public RoomWithDoor(string name, string decoration, string doorDescrpition, string hidingPlace) 
            : base(name, decoration, hidingPlace)
        {
            DoorDescription = doorDescrpition;
        }
    }
}
