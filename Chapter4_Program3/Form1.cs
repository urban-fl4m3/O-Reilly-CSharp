using System;
using System.Windows.Forms;

namespace Chapter4_Program3
{
    public partial class Form1 : Form
    {
        Elephant Lloyd;
        Elephant Lucinda;

        public Form1()
        {
            InitializeComponent();

            Lloyd = new Elephant() { Name = "Lloyd", EarSize = 40 };
            Lucinda = new Elephant() { Name = "Lucinda", EarSize = 33 };
        }

        private void LloydButton_Click(object sender, EventArgs e)
        {
            Lloyd.WhoAmI();
        }

        private void LucindaButton_Click(object sender, EventArgs e)
        {
            Lucinda.WhoAmI();
        }

        private void SwapButton_Click(object sender, EventArgs e)
        {
            Elephant temp = Lloyd;
            Lloyd = Lucinda;
            Lucinda = temp;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Lloyd = Lucinda;
            Lloyd.EarSize = 4321;
            Lloyd.WhoAmI();
        }
    }
}
