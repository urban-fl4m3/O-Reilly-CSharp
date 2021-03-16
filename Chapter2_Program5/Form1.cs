using System;
using System.Collections.Generic;
using System.Drawing;
using System.Threading;
using System.Windows.Forms;

namespace Chapter2_Program5
{
    public partial class FlashyThing : Form
    {
        public FlashyThing()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            while (Visible)
            {
                int c = 0;

                while (c < 254 && Visible)
                {
                    BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    Thread.Sleep(3);
                    c++;
                }

                while (c > -1 && Visible)
                {
                    BackColor = Color.FromArgb(c, 255 - c, c);
                    Application.DoEvents();
                    Thread.Sleep(3);
                    c--;
                }
            }
        }
    }
}
