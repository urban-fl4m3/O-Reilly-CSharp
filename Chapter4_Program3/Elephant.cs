using System.Windows.Forms;

namespace Chapter4_Program3
{
    class Elephant
    {
        public string Name;
        public int EarSize;

        public void WhoAmI()
        {
            MessageBox.Show($"My ears are {EarSize} inches tall", $"{Name} says...");
        }
    }
}
