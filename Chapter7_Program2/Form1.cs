using System.Windows.Forms;

namespace Chapter7_Program2
{
    public partial class Form1 : Form
    {
        int Moves;
        Location currentLocation;

        RoomWithDoor livingRoom;
        RoomWithDoor kitchen;
        RoomWithHidingPlace diningRoom;
        Room stairs;
        RoomWithHidingPlace hallway;
        RoomWithHidingPlace bathroom;
        RoomWithHidingPlace masterBedroom;
        RoomWithHidingPlace secondBedroom;

        OutsideWithDoor frontYard;
        OutsideWithDoor backYard;
        OutsideWithHidingPlace garden;
        OutsideWithHidingPlace driveWay;

        Opponent opponent;

        public Form1()
        {
            InitializeComponent();
            CreateObjects();
            opponent = new Opponent(frontYard);
            ResetGame(false);
        }

        private void CreateObjects()
        {
            livingRoom = new RoomWithDoor("Гостинная", 
                "старинный ковер", "дубовая дверь с латунной ручкой", "в гардеробе");
            kitchen = new RoomWithDoor("Кухня", 
                "плита из нержавеющей стали", "сетчатая дверь", "в сундуке");
            diningRoom = new RoomWithHidingPlace("Столовая", "хрустальная люстра", "в высоком шкафу");
            stairs = new Room("Лестница", "деревянные перила");
            hallway = new RoomWithHidingPlace("Верхний коридор", "картина с собакой", "в гардеробе");
            bathroom = new RoomWithHidingPlace("Ванная", "раковина и туалет", "в душе");
            masterBedroom = new RoomWithHidingPlace("Главная спальня", "большая кровать", "под кроватью");
            secondBedroom = new RoomWithHidingPlace("Вторая спальня", "маленькая кровать", "под кроватью");

            frontYard = new OutsideWithDoor("Лужайка", false, "дубовая дверь с латунной ручкой");
            backYard = new OutsideWithDoor("Задний двор", true, "сетчатая дверь");
            garden = new OutsideWithHidingPlace("Сад", false, "В сарае");
            driveWay = new OutsideWithHidingPlace("Подъезд", true, "в гараже");

            diningRoom.Exits = new Location[] { livingRoom, diningRoom };
            livingRoom.Exits = new Location[] { diningRoom, stairs };
            kitchen.Exits = new Location[] { diningRoom };
            stairs.Exits = new Location[] { livingRoom, hallway };
            hallway.Exits = new Location[] { stairs, bathroom, masterBedroom, secondBedroom };
            bathroom.Exits = new Location[] { hallway };
            masterBedroom.Exits = new Location[] { hallway };
            secondBedroom.Exits = new Location[] { hallway };
            frontYard.Exits = new Location[] { backYard, garden, driveWay };
            backYard.Exits = new Location[] { frontYard, garden, driveWay };
            garden.Exits = new Location[] { frontYard, backYard };
            driveWay.Exits = new Location[] { backYard, frontYard };

            livingRoom.DoorLocation = frontYard;
            frontYard.DoorLocation = livingRoom;

            kitchen.DoorLocation = backYard;
            backYard.DoorLocation = kitchen;
        }

        private void ResetGame(bool displayMessage)
        {
            if (displayMessage)
            {
                MessageBox.Show($"Меня нашли за {Moves} ходов!");
                IHidingPlace foundLocation = (IHidingPlace)currentLocation;
                description.Text = $"Соперник найден за {Moves} ходов! Он прятался {foundLocation.HidingLocation}.";
            }

            Moves = 0;
            hide.Visible = true;
            goHere.Visible = false;
            check.Visible = false;
            goThroughTheDoor.Visible = false;
            exits.Visible = false;
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
            Moves++;
            currentLocation = location;
            RedrawForm();
        }

        private void RedrawForm()
        {
            exits.Items.Clear();

            for (int i = 0; i < currentLocation.Exits.Length; i++)
            {
                exits.Items.Add(currentLocation.Exits[i].Name);
            }

            exits.SelectedIndex = 0;

            description.Text = $"{currentLocation.Description} \r\n(перемещение #{Moves})";

            if (currentLocation is IHidingPlace hidingPlace)
            {
                check.Text = $"Check {hidingPlace.HidingLocation}";
                check.Visible = true;
            }
            else
            {
                check.Visible = false;
            }

            bool hasDoors = currentLocation is IHasExteriorDoor;
            goThroughTheDoor.Visible = hasDoors;
        }

        private void check_Click(object sender, System.EventArgs e)
        {
            Moves++;

            if (opponent.Check(currentLocation))
            {
                ResetGame(true);
            }
            else
            {
                RedrawForm();
            }
        }

        private void hide_Click(object sender, System.EventArgs e)
        {
            hide.Visible = false;

            for (int i = 0; i < 10; i++)
            {
                opponent.Move();
                description.Text = $"{i + 1}...";
                Application.DoEvents();
                System.Threading.Thread.Sleep(200);
            }

            description.Text = "Я иду искать!";
            Application.DoEvents();
            System.Threading.Thread.Sleep(500);

            goHere.Visible = true;
            exits.Visible = true;
            MoveToANewLocation(livingRoom);
        }
    }
}
