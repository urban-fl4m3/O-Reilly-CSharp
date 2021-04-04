﻿using System;
using System.IO;

namespace Chapter9_Program5
{
    class Program
    {
        static void Main(string[] args)
        {
            int intValue = 48769414;
            string stringValue = "Hello!";
            byte[] byteArray = { 47, 129, 0, 116 };
            float floatValue = 491.695F;
            char charValue = 'E';

            using (FileStream output = File.Create("binarydata.dat"))
            using (BinaryWriter writer = new BinaryWriter(output))
            {
                writer.Write(intValue);
                writer.Write(stringValue);
                writer.Write(byteArray);
                writer.Write(floatValue);
                writer.Write(charValue);
            }

            byte[] dataWritten = File.ReadAllBytes("binarydata.dat");

            foreach(byte b in dataWritten)
            {
                Console.Write($"{b:x2} ");
            }

            Console.WriteLine($" - {dataWritten.Length} bytes");

            using (FileStream input = File.OpenRead("binarydata.dat"))
            using (BinaryReader reader= new BinaryReader(input))
            {
                int intRead = reader.ReadInt32();
                string stringRead = reader.ReadString();
                byte[] byteArrayRead = reader.ReadBytes(4);
                float floatRead = reader.ReadSingle();
                char charRead = reader.ReadChar();

                Console.Write($"int: {intRead}   string: {stringRead}   bytes: ");

                foreach(byte b in byteArrayRead)
                {
                    Console.Write($"{b} ");
                }

                Console.Write($" float: {floatRead}   char: {charRead}");
            }

            Console.ReadKey();
        }
    }
}
