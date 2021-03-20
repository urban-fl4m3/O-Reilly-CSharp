using System.Windows.Forms;

namespace Chapter4_Program6
{
    class LabelBouncer
    {
        public Label MyLabel;

        public bool MovingForward = true;

        public void Move()
        {
            if (MyLabel != null)
            {
                if (MovingForward)
                {
                    MyLabel.Left += 5;

                    if (MyLabel.Left >= MyLabel.Parent.Width - MyLabel.Width)
                    {
                        MovingForward = false;
                    }
                }
                else
                {
                    MyLabel.Left -= 5;

                    if (MyLabel.Left <= 0)
                    {
                        MovingForward = true;
                    }
                }
            }
        }
    }
}
