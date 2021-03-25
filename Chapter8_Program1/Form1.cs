using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter8_Program1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Random rand = new Random();
            int numberBetween0and3 = rand.Next(4);
            int numberBetween1and13 = rand.Next(1, 14);

            Card card = new Card((Suits)numberBetween0and3, (Values)numberBetween1and13);
            MessageBox.Show(card.Name);
        }
    }
}
