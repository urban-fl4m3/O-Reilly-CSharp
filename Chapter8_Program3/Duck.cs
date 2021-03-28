using System;
using System.Diagnostics.CodeAnalysis;

namespace Chapter8_Program3
{
    class Duck : IComparable<Duck>
    {
        public int Size;
        public KindOfDuck Kind;

        public int CompareTo([AllowNull] Duck other)
        {
            if (Size > other.Size)
            {
                return 1;
            }
            else if (Size < other.Size)
            {
                return -1;
            }
            else
            {
                return 0;
            }
        }
    }
}
