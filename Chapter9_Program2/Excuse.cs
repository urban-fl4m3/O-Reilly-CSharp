using System;
using System.IO;
using System.Runtime.Serialization.Formatters.Binary;

namespace Chapter9_Program2
{
    [Serializable]
    class Excuse
    {
        public string Description { get; set; }
        public string Results { get; set; }
        public string ExcusePath { get; set; }
        public DateTime LastUsed { get; set; }
        
        public Excuse()
        {
            ExcusePath = "";
        }

        public Excuse(Random random, string folder)
        {
            string[] fileNames = Directory.GetFiles(folder, "*.excuse");
            OpenFile(fileNames[random.Next(fileNames.Length)]);
        }

        public void OpenFile(string excusePath)
        {
            ExcusePath = excusePath;
            Excuse temp;

            using (Stream input = File.OpenRead(excusePath))
            {
                BinaryFormatter bf = new BinaryFormatter();
                temp = (Excuse)bf.Deserialize(input);

            }

            Description = temp.Description;
            Results = temp.Results;
            LastUsed = temp.LastUsed;
        }

        public void Save(string fileName)
        {
            using (Stream output = File.OpenWrite(fileName))
            {
                BinaryFormatter bf = new BinaryFormatter();
                bf.Serialize(output, this);
            }
        }
    }
}
