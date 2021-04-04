using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter9_Program6
{
    class Program
    {
        static void Main(string[] args)
        {
            using (FileStream output = File.Create("three-c.dat"))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                Card card = new Card(Suits.Clubs, Values.Three);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, card);
            }

            using (FileStream output = File.Create("six-h.dat"))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                Card card = new Card(Suits.Hearts, Values.Six);
                BinaryFormatter formatter = new BinaryFormatter();
                formatter.Serialize(output, card);
            }

            byte[] firstFile = File.ReadAllBytes("three-c.dat");
            byte[] secondFile = File.ReadAllBytes("six-h.dat");

            for (int i = 0; i < firstFile.Length; i++)
            {
                if (firstFile[i] != secondFile[i])
                {
                    Console.WriteLine($"Byte #{i}: {firstFile[i]} versus {secondFile[i]}");
                }
            }
        }
    }
}
