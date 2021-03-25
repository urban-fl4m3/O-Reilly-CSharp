using System;

namespace Chapter7_Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            IScaryClown someOtherScaryClown = new ScaryScary("big shoes", 14);
            someOtherScaryClown.Honk();
            
            Console.ReadKey();
        }
    }
}
