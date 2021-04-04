using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Chapter9_Program4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private const string eurekaName = "eureka.txt";

        private void button1_Click(object sender, EventArgs e)
        {
            File.WriteAllText(eurekaName, "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes(eurekaName);

            foreach (byte b in eurekaBytes)
            {
                Console.Write($"{b} ");
            }
            Console.WriteLine();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            File.WriteAllText(eurekaName, "Eureka!");
            byte[] eurekaBytes = File.ReadAllBytes(eurekaName);

            foreach (byte b in eurekaBytes)
            {
                Console.Write($"{b:x2} ");
            }
            Console.WriteLine();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            File.WriteAllText(eurekaName, "שלום", Encoding.Unicode);
            byte[] eurekaBytes = File.ReadAllBytes(eurekaName);

            foreach (byte b in eurekaBytes)
            {
                Console.Write($"{b:x2} ");
            }
            Console.WriteLine();
        }
    }
}
