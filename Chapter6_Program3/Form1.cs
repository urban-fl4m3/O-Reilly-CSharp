using System;
using System.Windows.Forms;

namespace Chapter6_Program3
{
    public partial class Form1 : Form
    {
        Queen queen;

        public Form1()
        {
            InitializeComponent();
            workerBeeJob.SelectedIndex = 0;

            Worker[] workers = new Worker[4];
            workers[0] = new Worker(new string[] { "Nectar collector", "Honey manufacturing" }, 175);
            workers[1] = new Worker(new string[] { "Egg care", "Baby bee tutoring" }, 114);
            workers[2] = new Worker(new string[] { "Hive maintenance", "String patrol"}, 149);
            workers[3] = new Worker(new string[] { "Nectar collector", "Honey manufacturing", "Egg care", 
                "Baby bee tutoring", "Hive maintenance", "Sting patrol"}, 155);

            queen = new Queen(workers, 275);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (!queen.AssignWork(workerBeeJob.Text, (int)shifts.Value))
            {
                MessageBox.Show($"Для этого задания рабочих нет '{workerBeeJob.Text}', Матка говорит...");
            }
            else
            {
                MessageBox.Show($"Задание '{workerBeeJob.Text} будет закончено через {shifts.Value} смен" +
                    $", Матка говорит...'");
            }
        }

        private void nextShift_Click(object sender, EventArgs e)
        {
            report.Text = queen.WorkTheNextShift();
        }
    }
}
