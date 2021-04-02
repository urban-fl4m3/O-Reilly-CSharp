using System;
using System.IO;

namespace Chapter9_Program2
{
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
            string[] fileNames = Directory.GetFiles(folder, "*.txt");
            OpenFile(fileNames[random.Next(fileNames.Length)));
        }

        public void OpenFile(string excusePath)
        {
            ExcusePath = excusePath;
            using (StreamReader reader = new StreamReader(excusePath))
            {
                Description = reader.ReadLine();
                Results = reader.ReadLine();
                LastUsed = Convert.ToDateTime(reader.ReadLine());
            }
        }

        public void Save(string fileName)
        {
            using(StreamWriter sw = new StreamWriter(fileName))
            {
                sw.WriteLine(Description);
                sw.WriteLine(Results);
                sw.WriteLine(LastUsed);
            }
        }
    }
}
