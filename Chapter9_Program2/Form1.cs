using System;
using System.Windows.Forms;
using System.IO;

namespace Chapter9_Program2
{
    public partial class Form1 : Form
    {
        private Excuse currentExcuse = new Excuse();
        private bool formChanged;
        private string folderPath;
        private Random rnd = new Random();

        public Form1()
        {
            InitializeComponent();
            currentExcuse.LastUsed = lastUsed.Value;
        }

        private void folder_Click(object sender, EventArgs e)
        {
            folderBrowserDialog1.SelectedPath = folderPath;

            if (folderBrowserDialog1.ShowDialog() == DialogResult.OK)
            {
                save.Enabled = true;
                open.Enabled = true;
                random.Enabled = true;

                folderPath = folderBrowserDialog1.SelectedPath;
            }
        }

        private void save_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(excuse.Text) || string.IsNullOrEmpty(results.Text))
            {
                MessageBox.Show("Please specify an excuse and result", "Unable to save",
                    MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                return;
            }

            saveFileDialog1.InitialDirectory = folderPath;
            saveFileDialog1.FileName = $"{excuse.Text}.txt";

            if (saveFileDialog1.ShowDialog() == DialogResult.OK)
            {
                currentExcuse.Save(saveFileDialog1.FileName);
                UpdateForm(false);
            }
        }

        private void open_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                openFileDialog1.InitialDirectory = folderPath;
                openFileDialog1.FileName = $"{excuse.Text}.txt";

                if (openFileDialog1.ShowDialog() == DialogResult.OK)
                {
                    currentExcuse = new Excuse(openFileDialog1.FileName);
                    UpdateForm(false);
                }
            }
        }

        private void random_Click(object sender, EventArgs e)
        {
            if (CheckChanged())
            {
                currentExcuse = new Excuse(random, folderPath);
                UpdateForm(false);
            }
        }

        private void UpdateForm(bool changed)
        {
            if (!changed)
            {
                excuse.Text = currentExcuse.Description;
                results.Text = currentExcuse.Results;
                lastUsed.Value = currentExcuse.LastUsed;

                if (!string.IsNullOrEmpty(currentExcuse.ExcusePath))
                {
                    fileDate.Text = File.GetLastWriteTime(currentExcuse.ExcusePath).ToString();
                }

                Text = "Excuse Manager";
            }
            else
            {
                Text = "Excuse Manager*";
            }

            formChanged = changed;
        }

        private void excuse_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Description = excuse.Text;
            UpdateForm(true);
        }

        private void results_TextChanged(object sender, EventArgs e)
        {
            currentExcuse.Results = results.Text;
            UpdateForm(true);
        }

        private void lastUsed_ValueChanged(object sender, EventArgs e)
        {
            currentExcuse.LastUsed = lastUsed.Value;
            UpdateForm(true);
        }

        private bool CheckChanged()
        {
            if (formChanged)
            {
                DialogResult result = MessageBox.Show("The current excuse has not been saved. Continue?",
                    "Warning", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            
                if (result == DialogResult.No)
                {
                    return false;
                }
            }

            return true;
        }
    }
}
