using System;
using System.Windows.Forms;

namespace Chapter2_Program4
{
    static class Program
    {
        //page 129
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new Form1());
        }
    }
}
