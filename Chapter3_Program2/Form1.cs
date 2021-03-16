using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
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
    }
}
