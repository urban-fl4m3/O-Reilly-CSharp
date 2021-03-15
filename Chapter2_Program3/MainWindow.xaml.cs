using System.Windows;

namespace Chapter2_Program3
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void changeText_Click(object sender, RoutedEventArgs e)
        {
            bool checkboxEnabled = enableCheckbox.IsChecked.Value;

            if (!checkboxEnabled)
            {
                labelToChange.Text = "Text changing is disabled";
                labelToChange.HorizontalAlignment = HorizontalAlignment.Center;
            }
            else
            {
                if (labelToChange.HorizontalAlignment == HorizontalAlignment.Right)
                {
                    labelToChange.Text = "Left";
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Left;
                }
                else
                {
                    labelToChange.Text = "Right";
                    labelToChange.HorizontalAlignment = HorizontalAlignment.Right;
                }
            }
        }
    }
}
