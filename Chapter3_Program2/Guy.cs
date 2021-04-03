using System;
using System.Windows.Forms;

namespace Chapter3_Program2
{
    [Serializable]
    public class Guy
    {
        public readonly string Name;
        public int Cash { get; set; }

        public Guy(string name, int cash)
        {
            Name = name;
            Cash = cash;
        }

        public int GiveCash(int amount)
        {
            if (amount <= Cash && amount > 0)
            {
                Cash -= amount;
                return amount;
            }
            else
            {
                MessageBox.Show($"У меня не хватает денег {amount}, {Name} говорит...");
                return 0;
            }
        }

        public int ReceiveCash(int amount)
        {
            if (amount > 0)
            {
                Cash += amount;
                return amount;
            }
            else
            {
                MessageBox.Show($"{amount} мне не нужно, {Name} говорит...");
                return 0;
            }
        }
    }
}
