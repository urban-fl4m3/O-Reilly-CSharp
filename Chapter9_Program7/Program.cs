using System;
using System.IO;
using System.Text;

namespace Chapter9_Program7
{
    class Program
    {
        static void Main(string[] args)
        {
            if (args.Length != 1)
            {
                Console.Error.WriteLine("usage: HexDumper file-to-dump");
                Environment.Exit(1);
            }

            if (!File.Exists(args[0]))
            {
                Console.Error.WriteLine($"File doesn't exists: {args[0]}");
                Environment.Exit(2);
            }

            using (Stream input = File.OpenRead(args[0]))
            {
                int position = 0;
                byte[] buffer = new byte[16];

                while (position < input.Length)
                {
                    int charactersRead = input.Read(buffer, 0, buffer.Length);

                    if (charactersRead > 0)
                    {
                        Console.Write($"{string.Format($"{position:x4}")}: ");
                        position += charactersRead;

                        for (int i = 0; i < 16; i++)
                        {
                            if (i < charactersRead)
                            {
                                string hex = string.Format($"{buffer[i]:x2}");
                                Console.Write($"{hex} ");
                            }
                            else
                            {
                                Console.Write("   ");
                            }

                            if (i == 7)
                            {
                                Console.Write("-- ");
                            }

                            if (buffer[i] < 32 || buffer[i] > 250)
                            {
                                buffer[i] = (byte)'.';
                            }
                        }

                        string bufferContents = Encoding.UTF8.GetString(buffer);
                        Console.WriteLine($"    {bufferContents}");
                    }
                }
            }
        }
    }
}
