using System;
using System.Collections.Generic;
using System.Windows.Forms;

namespace Chapter8_Program8
{
    public partial class Form1 : Form
    {
        private Queue<Lumberjack> breakfastLine = new Queue<Lumberjack>();

        public Form1()
        {
            InitializeComponent();

            RedrawList();
        }

        private void addLumberjack_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(lumberjackNameText.Text))
            {
                return;
            }

            breakfastLine.Enqueue(new Lumberjack(lumberjackNameText.Text));

            RedrawList();
        }

        private void addFlapjacks_Click(object sender, EventArgs e)
        {
            if (breakfastLine.Count == 0) return;

            Flapjack food;

            if (crispy.Checked)
            {
                food = Flapjack.Crispy;
            }
            else if (soggy.Checked)
            {
                food = Flapjack.Soggy;
            }
            else if (browned.Checked)
            {
                food = Flapjack.Browned;
            }
            else
            {
                food = Flapjack.Banana;
            }

            Lumberjack currentLumberjack = breakfastLine.Peek();
            currentLumberjack.TakeFlapjacks(food, (int)howMany.Value);

            RedrawList();
        }

        private void nextLumberjack_Click(object sender, EventArgs e)
        {
            Lumberjack nextLumberjack = breakfastLine.Dequeue();
            nextLumberjack.EatFlapjacks();

            RedrawList();
        }

        private void RedrawList()
        {
            line.Items.Clear();
            
            if (breakfastLine.Count > 0)
            {
                Lumberjack nextInLine = breakfastLine.Peek();
                nextInLineLabel.Text = $"{nextInLine.Name} has {nextInLine.FlapjackCount} flapjacks";
            }

            lumberjackNameText.Text = string.Empty;

            int lumberjackIndex = 1;

            foreach(Lumberjack lumberjack in breakfastLine)
            {
                line.Items.Add($"{lumberjackIndex} {lumberjack.Name}");
                lumberjackIndex++;
            }
        }
    }
}
