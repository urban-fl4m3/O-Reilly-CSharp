using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;
using System.Windows.Forms;

namespace Chapter3_Program2
{
    public partial class Form1 : Form
    {
        Guy joe;
        Guy bob;
        int bank = 100;

        public Form1()
        {
            InitializeComponent();
            joe = new Guy("Joe", 50);
            bob = new Guy("Bob", 100);

            UpdateForm();
        }

        public void UpdateForm()
        {
            joesCashLabel.Text = $"{joe.Name} has ${joe.Cash}";
            bobsCashLabel.Text = $"{bob.Name} has ${bob.Cash}";
            bankCashLabel.Text = $"The bank has ${bank}";
        }

        private void giveCashToJoeButton_Click(object sender, EventArgs e)
        {
            if (bank >= 10)
            {
                bank -= joe.ReceiveCash(10);
                UpdateForm();
            }
            else
            {
                MessageBox.Show($"There is no money in the bank");
            }
        }

        private void receiveFromBobButton_Click(object sender, EventArgs e)
        {
            bank += bob.GiveCash(5);
            UpdateForm();
        }

        private void joeGivesCashToBobButton_Click(object sender, EventArgs e)
        {
            var cash = joe.GiveCash(10);
            bob.ReceiveCash(cash);
            UpdateForm();
        }

        private void bobGivesCashToJoeButton_Click(object sender, EventArgs e)
        {
            var cash = bob.GiveCash(5);
            joe.ReceiveCash(cash);
            UpdateForm();
        }

        private void saveJoe_Click(object sender, EventArgs e)
        {
            using (Stream output = File.Create("Guy_File.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, joe);
            }
        }

        private void loadJoe_Click(object sender, EventArgs e)
        {
            using (Stream input = File.OpenRead("Guy_File.dat"))
            {
                BinaryFormatter formatter = new BinaryFormatter();
                joe = (Guy)formatter.Deserialize(input);
            }
            UpdateForm();
        }
    }
}
