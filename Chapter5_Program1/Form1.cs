using System;
using System.Windows.Forms;

namespace Chapter5_Program1
{
    public partial class Form1 : Form
    {
        //page 234
        DinnerParty dinnerParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty();
            dinnerParty.SetPartyOptions((int)numericUpDown1.Value, fancyDecorationsCheckbox.Checked);
            dinnerParty.SetHealthyOptions(healthDecorationsCheckbox.Checked);
            DisplayDinnerPartyCost();
        }

        private void DisplayDinnerPartyCost()
        {
            decimal Cost = dinnerParty.CalculateCost(healthDecorationsCheckbox.Checked);
            costLabel.Text = Cost.ToString("c");
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            dinnerParty.SetPartyOptions((int)numericUpDown1.Value, fancyDecorationsCheckbox.Checked);
            DisplayDinnerPartyCost();
        }

        private void fancyDecorationsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.CalculateCostOfDecorations(fancyDecorationsCheckbox.Checked);
            DisplayDinnerPartyCost();
        }

        private void healthDecorationsCheckbox_CheckedChanged(object sender, EventArgs e)
        {
            dinnerParty.SetHealthyOptions(healthDecorationsCheckbox.Checked);
            DisplayDinnerPartyCost();
        }
    }
}
