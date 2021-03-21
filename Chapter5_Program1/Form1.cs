using System;
using System.Windows.Forms;

namespace Chapter5_Program1
{
    public partial class Form1 : Form
    {
        DinnerParty dinnerParty;
        BirthdayParty birthdayParty;

        public Form1()
        {
            InitializeComponent();
            dinnerParty = new DinnerParty((int)numericUpDown1.Value,
                healthDecorationsCheckbox.Checked, fancyDecorationsCheckbox.Checked);
            DisplayDinnerPartyCost();

            birthdayParty = new BirthdayParty((int)numberBirthday.Value, fancyBirthday.Checked, 
                cakeWriting.Text);
            DisplayBirthdayPartyCost();
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


        private void numberBirthday_ValueChanged(object sender, EventArgs e)
        {
            birthdayParty.NumberOfPeople = (int)numberBirthday.Value;
            DisplayBirthdayPartyCost();
        }

        private void fancyBirthday_CheckedChanged(object sender, EventArgs e)
        {
            birthdayParty.FancyDecorations = fancyBirthday.Checked;
            DisplayBirthdayPartyCost();
        }

        private void cakeWriting_TextChanged(object sender, EventArgs e)
        {
            birthdayParty.CakeWriting = cakeWriting.Text;
            DisplayBirthdayPartyCost();
        }


        private void DisplayDinnerPartyCost()
        {
            decimal cost = dinnerParty.Cost;
            costLabel.Text = cost.ToString("c");
        }

        private void DisplayBirthdayPartyCost()
        {
            tooLongLabel.Visible = birthdayParty.CakeWritingTooLong;
            decimal cost = birthdayParty.Cost;
            birthdayCost.Text = cost.ToString("c");
        }
    }
}
