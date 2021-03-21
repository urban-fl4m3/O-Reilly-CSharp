using System;
using System.Windows.Forms;

namespace Chapter5_Program1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value,
                healthDecorationsCheckbox.Checked, fancyDecorationsCheckbox.Checked);

            DisplayDinnerPartyCost();
        }

        private void fancyDecorationsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.FancyDecorations = fancyDecorationsCheckbox.Checked;
            DisplayDinnerPartyCost();
        }

        private void healthDecorationsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.HealthyOptions = healthDecorationsCheckbox.Checked;
            DisplayDinnerPartyCost();
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.NumberOfPeople = (int)numericUpDown1.Value;
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.Cost;
            costLabel.Text = Cost.ToString("c");
        }
    }
}
