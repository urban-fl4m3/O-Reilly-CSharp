using System.Collections.Generic;
using System;

namespace Chapter8_Program7
{
    class CardComparer_byRandom : IComparer<Card>
    {
        private Random random;

        public CardComparer_byRandom(Random random)
        {
            this.random = random;
        }

        public int Compare(Card x, Card y)
        {
            int value = random.Next(2, 5);
            return value - 3;
        }
    }
}
