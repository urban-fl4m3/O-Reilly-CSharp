using System;
using System.Windows.Forms;

namespace Chapter4_Program5
{
    public partial class Form1 : Form
    {
        private Random random = new Random();
        private Stats stats = new Stats();

        public Form1()
        {
            InitializeComponent();

            timer1.Enabled = true;
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            listBox1.Items.Add((Keys)random.Next(65, 90));
            if (listBox1.Items.Count > 7)
            {
                listBox1.Items.Clear();
                listBox1.Items.Add("Игра окончена!");
                timer1.Stop();
            }
        }

        private void Form1_KeyDown(object sender, KeyEventArgs e)
        {
            if (listBox1.Items.Contains(e.KeyCode))
            {
                listBox1.Items.Remove(e.KeyCode);
                listBox1.Refresh();
                if (timer1.Interval > 400)
                    timer1.Interval -= 100;
                if (timer1.Interval > 250)
                    timer1.Interval -= 7;
                if (timer1.Interval > 100)
                    timer1.Interval -= 2;

                difficultyProgressBar.Value = 800 - timer1.Interval;
                stats.Update(true);
            }
            else
            {
                stats.Update(false);
            }

            correctLabel.Text = $"Correct: {stats.Correct}";
            missedLabel.Text = $"Missed: {stats.Missed}";
            totalLabel.Text = $"Total: {stats.Total}";
            accuracyLabel.Text = $"Accuracy: {stats.Accuracy}%";
        }
    }
}
