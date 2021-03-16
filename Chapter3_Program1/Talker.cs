using System.Windows.Forms;

namespace Chapter3_Program1
{
    class Talker
    {
        public static int BlahBlahBlah(string thingToStay, int numberOfTime)
        {
            string result = "";

            for (int count = 0; count < numberOfTime; count++)
            {
                result = $"{result}{thingToStay}\n";
            }

            MessageBox.Show(result);
            return result.Length;        
        }
    }
}
