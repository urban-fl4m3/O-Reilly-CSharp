using System;
using System.Windows.Forms;

namespace Chapter5_Program2
{
    public partial class Form1 : Form
    {
        //page 249
        Farmer farmer;

        public Form1()
        {
            InitializeComponent();
            farmer = new Farmer((int)numericUpDown1.Value, 30);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Console.WriteLine("I need {0} bags of feed for {1} cows", farmer.BagsOfFeed, farmer.NumberOfCows);
        }

        private void numericUpDown1_ValueChanged(object sender, EventArgs e)
        {
            farmer.NumberOfCows = (int)numericUpDown1.Value;
        }
    }
}
