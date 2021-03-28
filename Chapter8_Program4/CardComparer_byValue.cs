using System;
using System.Collections.Generic;
using System.Diagnostics.CodeAnalysis;
using System.Text;

namespace Chapter8_Program4
{
    class CardComparer_byValue : IComparer<Card>
    {
        public int Compare([AllowNull] Card x, [AllowNull] Card y)
        {
            if (x.Value > y.Value)
            {
                return 1;
            }

            if (x.Value < y.Value)
            {
                return -1;
            }

            if (x.Suit > y.Suit)
            {
                return 1;
            }

            if (x.Suit < y.Suit)
            {
                return -1;
            }

            return 0;
        }
    }
}
