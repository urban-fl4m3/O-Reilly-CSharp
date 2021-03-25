using System.Windows.Forms;

namespace Chapter7_Program2
{
    public partial class Form1 : Form
    {
        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        Room diningRoom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        Outside garden;

        Location currentLocation;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            MoveToANewLocation(livingRoom);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Гостинная", 
                "старинный ковер", "дубовая дверь с латунной ручкой");
            kitchen = new RoomWithDoor("Кухня", 
                "плита из нержавеющей стали", "сетчатая дверь");
            diningRoom = new Room("Столовая", "хрустальная люстра");
            garden = new Outside("Сад", false);
            
            frontYard = new OutsideWithDoor("Лужайка", false, "дубовая дверь с латунной ручкой");
            backYard = new OutsideWithDoor("Задний двор", false, "сетчатая дверь");

            livingRoom.Exits = new Location[] { diningRoom };
            kitchen.Exits = new Location[] { diningRoom };
            diningRoom.Exits = new Location[] { livingRoom, diningRoom };
            frontYard.Exits = new Location[] { backYard, garden };
            backYard.Exits = new Location[] { frontYard, garden };
            garden.Exits = new Location[] { frontYard, backYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;
            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void goHere_Click(object sender, System.EventArgs e)
        {
            MoveToANewLocation(currentLocation.Exits[exits.SelectedIndex]);
        }

        private void goThroughTheDoor_Click(object sender, System.EventArgs e)
        {
            MoveToANewLocation(((IHasExteriorDoor)currentLocation).DoorLocation);
        }

        private void MoveToANewLocation(Location location)
        {
            currentLocation = location;
            exits.Items.Clear();

            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }

            exits.SelectedIndex = 0;

            description.Text = currentLocation.Description;

            bool hasDoors = currentLocation is IHasExteriorDoor;
            goThroughTheDoor.Visible = hasDoors;
        }
    }
}
