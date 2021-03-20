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

        public void TellMe(string message, Elephant whoSaidIt)
        {
            MessageBox.Show($"{whoSaidIt.Name} says: {message}");
        }

        public void SpeakTo(Elephant whoTalkTo, string message)
        {
            whoTalkTo.TellMe(message, this);
        }
    }
}
