using System;
using System.Windows.Forms;

namespace Chapter4_Program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            startingMileage = (int)numericUpDown1.Value;
            endingMileage = (int)numericUpDown2.Value;

            if (startingMileage < endingMileage)
            {
                milesTraveled = endingMileage -= startingMileage;
                amountOwned = milesTraveled * reimburseRate;
                label4.Text = $"${amountOwned}";
            }
            else
            {
                MessageBox.Show("Начальный пробег не может превышать конечный", "Cannot Calculate");
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            MessageBox.Show($"{milesTraveled} miles");
        }
    }
}
