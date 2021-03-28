using System;
using System.Collections.Generic;

namespace Chapter8_Program3
{
    class Program
    {
        static void Main(string[] args)
        {
            List<Duck> ducks = new List<Duck>()
            {
                new Duck { Kind = KindOfDuck.Mallard, Size = 17},
                new Duck { Kind = KindOfDuck.Muscovy, Size = 18},
                new Duck { Kind = KindOfDuck.Decoy, Size = 14},
                new Duck { Kind = KindOfDuck.Muscovy, Size = 11},
                new Duck { Kind = KindOfDuck.Mallard, Size = 14},
                new Duck { Kind = KindOfDuck.Decoy, Size = 13}
            };

            PrintDucks(ducks);
            DuckComparerBySize comparer = new DuckComparerBySize();
            ducks.Sort(comparer);
            PrintDucks(ducks);

            Console.ReadKey();
        }

        private static void PrintDucks(List<Duck> ducks)
        {
            foreach(Duck duck in ducks)
            {
                Console.WriteLine($"{duck.Size} - дюймов {duck.Kind}\r\n");
            }

            Console.WriteLine("Утки кончились! \r\n");
        }
    }
}
