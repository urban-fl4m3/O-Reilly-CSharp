using System;

namespace Chapter7_Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            ScaryScary fingersTheClown = new ScaryScary("big shoes", 14);
            FunnyFunny someFunnyClown = fingersTheClown;
            IScaryClown someOtherScaryClown = (ScaryScary)someFunnyClown;
            someOtherScaryClown.Honk();
            
            Console.ReadKey();
        }
    }
}
