namespace Chapter7_Program2
{
    class RoomWithDoor : Room, IHasExteriorDoor
    {
        public string DoorDescription { get; private set; }

        public Location DoorLocation { get; set; }
    
        public RoomWithDoor(string name, string decoration, string doorDescrpition) : base(name, decoration)
        {
            DoorDescription = doorDescrpition;
        }
    }
}
