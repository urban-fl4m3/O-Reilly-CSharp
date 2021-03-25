using System;

namespace Chapter7_Program2
{
    class Opponent
    {
        private Location myLocation;
        private Random random;

        public Opponent(Location startingLocation)
        {
            random = new Random();
            myLocation = startingLocation;
        }

        public void Move()
        {
            bool hidden = false;

            while (!hidden)
            {
                if (myLocation is IHasExteriorDoor locationWithDoor)
                {
                    if (random.Next(2) == 1)
                    {
                        myLocation = locationWithDoor.DoorLocation;
                    }
                }

                int rand = random.Next(myLocation.Exits.Length);
                myLocation = myLocation.Exits[rand];
                hidden = myLocation is IHidingPlace;
            }
        }

        public bool Check(Location location)
        {
            return myLocation == location;
        }
    }
}
