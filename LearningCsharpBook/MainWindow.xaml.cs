using System.Windows;

namespace LearningCsharpBook
{
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            int number = 15;
            number = number + 10;
            number = 36 * 15;
            number = 12 - (42 / 7);
            number += 10;
            number *= 3;
            number = 71 / 3;

            int count = 0;
            count++;
            count--;

            ++count;
            --count;

            string result = "hello";
            result += $" again {result}";
            output.Text = result;
            result = $"the value is: {count}";
            result = string.Empty;

            var yesNo = false;
            var anotherBool = true;
            yesNo = !anotherBool;
        }
    }
}
