using System;

namespace Chapter6_Program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Owner owner = new Owner();
            Safe safe = new Safe();
            JewelThief thief = new JewelThief();
            thief.OpenSafe(safe, owner);

            Console.ReadKey();
        }
    }
}
